USE Northwind
GO

 /*
 1.- FUNCION ESCALAR QUE RECIBA DOS CLAVES DE CLIENTES Y UN A�O,
 Y REGRESE EL NOMBRE DEL CLIENTE QUE MAS HA VENDIDO PIEZAS DE LOS DOS EN ESE A�O Y 
 EL TOTAL DE PIEZAS VENDIDAS.
 POR EJEMPLO, DEBE REGRESAR: EL CLIENTE JUAN PEREZ VENDIO 450 PIEZAS.
 */
CREATE OR ALTER FUNCTION dbo.fn1Clientes (@CLIENTE1 NCHAR(5), @CLIENTE2 NCHAR(5), @ANIO INT)
RETURNS VARCHAR(1000)
AS 
BEGIN
	DECLARE @NOMBRE1 VARCHAR(30), @NOMBRE2 VARCHAR(30), @TOTALPIEZAS1 INT, @TOTALPIEZAS2 INT, @R VARCHAR(1000)

	SELECT @NOMBRE1 = CONTACTNAME 
	FROM Customers 
	WHERE CustomerID = @CLIENTE1

	SELECT @NOMBRE2 = CONTACTNAME 
	FROM Customers 
	WHERE CustomerID = @CLIENTE2

	SELECT @TOTALPIEZAS1 = SUM(Quantity) 
	FROM Orders o
	INNER JOIN [Order Details] oD ON oD.OrderID = o.OrderID
	WHERE o.CustomerID = @CLIENTE1
	AND YEAR(o.OrderDate) = @ANIO

	SELECT @TOTALPIEZAS2 = SUM(Quantity) 
	FROM Orders o
	INNER JOIN [Order Details] oD ON oD.OrderID = o.OrderID
	WHERE o.CustomerID = @CLIENTE2
	AND YEAR(o.OrderDate) = @ANIO

	IF @TOTALPIEZAS1 > @TOTALPIEZAS2
		SELECT @R = 'EL CLIENTE ' + @NOMBRE1 + ' VENDIO ' + CONVERT(VARCHAR, @TOTALPIEZAS1) + ' PIEZAS'
	ELSE
		SELECT @R = 'EL CLIENTE ' + @NOMBRE2 + ' VENDIO ' + CONVERT(VARCHAR, @TOTALPIEZAS2) + ' PIEZAS'

	RETURN @R
END
GO
--Ejecuci�n
SELECT [Cliente con mas ventas] = dbo.fn1Clientes('ALFKI', 'SPLIR', 1996)
GO

/*
 	2.- FUNCION ESCALAR QUE RECIBA LA CLAVE DEL EMPLEADO Y REGRESE UNA CADENA CON LOS NOMBRE DE LOS TERRITORIOS QUE ATIENDE.
*/

CREATE OR ALTER FUNCTION dbo.fndos(@Emp INT)
RETURNS VARCHAR(1000)
AS
BEGIN
	DECLARE @Nom VARCHAR(1000)

	SELECT @Nom = STRING_AGG(TRIM(t.TerritoryDescription), ', ')
	FROM Employees e
	INNER JOIN EmployeeTerritories et ON e.EmployeeID = et.EmployeeID
	INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID
	WHERE e.EmployeeID = @Emp

	RETURN @Nom
END
--EJECUCI�N
GO
SELECT NombreTerritorios = dbo.fndos(1)
GO

/*
  3.- FUNCION DE TABLA EN LINEA QUE RECIBA LA CLAVE DE UN PRODUCTO Y 
  REGRESE UNA TABLA CON EL NOMBRE DE TODOS LOS CLIENTES QUE HAN COMPRADO ESE PRODUCTO, 
  EL TOTAL DE PRODUCTOS COMPRADO Y EL TOTAL DE ORDENES EN LAS QUE SE HA VENDIDO.
*/
CREATE OR ALTER FUNCTION dbo.fntres(@PRODUCTO INT)
RETURNS TABLE
AS
RETURN (
	SELECT 'NombreCliente' = c.ContactName, 'TolalProductos' = SUM(quantity), 'TotalOrdenes' = COUNT(o.OrderId)
	FROM Orders o
	INNER JOIN Customers c ON c.CustomerID = o.CustomerID
	INNER JOIN [Order Details] od ON  od.OrderID = o.OrderID
	WHERE od.ProductID = @PRODUCTO
	GROUP BY c.ContactName
)
GO
--EJECUCION
SELECT * 
FROM dbo.fntres(1) 
GO


/*
  4.- FUNCION DE TABLA EN LINEA QUE RECIBA LA CLAVE DEL EMPLEADO Y A�O, 
  REGRESE EN UNA CONSULTA EL NOMBRE DEL PRODUCTO 
  Y TOTAL DE PRODUCTOS VENDIDOS POR ESE EMPLEADO Y ESE A�O.
*/

CREATE OR ALTER FUNCTION dbo.fn_cuatro(@EMP INT, @ANIO INT)
RETURNS TABLE
AS
RETURN (
	SELECT 'NombreProducto' = p.ProductName, 'TotalProductos' = SUM(quantity)
	FROM Orders o
	INNER JOIN Employees e ON e.EmployeeID = o.EmployeeID
	INNER JOIN [Order Details] od ON od.OrderID = o.OrderID
	INNER JOIN Products p ON p.ProductID = od.ProductID
	WHERE o.EmployeeID = @EMP
	AND YEAR(o.OrderDate) = @ANIO
	GROUP BY p.ProductName
)
GO
--EJECUCION
SELECT * 
FROM dbo.fn_cuatro(1, 1996)
GO

/*
  5.- UTILIZANDO LA FUNCION ANTERIOR MOSTRAR UNA CONSULTA SIGUIENTE:
 */
SELECT NombreProducto= p.ProductName ,
TotalPiezas96= ISNULL(A.TotalProductos,0), TotalPiezas97= ISNULL(B.TotalProductos,0), TotalPiezas98= ISNULL(C.TotalProductos,0)
FROM Products p
LEFT OUTER JOIN dbo.fn_cuatro(1,1998) A ON p.ProductName = a.NombreProducto
LEFT OUTER JOIN dbo.fn_cuatro(1,1997) B ON p.ProductName = b.NombreProducto
LEFT OUTER JOIN dbo.fn_cuatro(1,1996) C ON p.ProductName = c.NombreProducto
GO

/*
  6.- FUNCION DE TABLA DE MULTISENTENCIA (NO LLEVA PARAMETROS DE ENTRADA) 
  QUE REGRESE UNA TABLA CON EL NOMBRE DE LA CATEGORIA 
  Y LOS NOMBRES DE LOS PRODUCTOS QUE PERTENECEN A LA CATEGORIA 
  Y EL TOTAL DE PIEZAS QUE SE HAN VENDIDO DE ESA CATEGORIA
*/

CREATE OR ALTER FUNCTION dbo.fn_seis()
RETURNS @retorno TABLE ([Nombre de la categoria] VARCHAR(20), [Productos de la categoria] VARCHAR(200), [Total de piezas] INT)
AS
	BEGIN
	DECLARE @categoria INT, @nomprod VARCHAR(200), @pzs INT,@nombreCat VARCHAR(20),@cont INT, @pdId INT

	SELECT @categoria=MIN(CategoryID) 
	FROM Categories

	WHILE @categoria IS NOT NULL
	BEGIN
		SELECT @nombreCat=CategoryName
		FROM Categories
		WHERE @categoria=CategoryID

		SELECT @nomprod = STRING_AGG(p.ProductName, ', ')
		FROM Categories c
		INNER JOIN Products p ON p.CategoryID = c.CategoryID
		WHERE c.CategoryID = @categoria

		SELECT @cont = SUM(od.quantity) 
		FROM [Order Details] od
		INNER JOIN Products p ON p.ProductID=od.ProductID
		WHERE @categoria = p.CategoryID

		INSERT INTO @retorno VALUES (@nombreCat, @nomprod, @cont)

		SELECT @categoria = MIN(CategoryID) 
		FROM Categories 
		WHERE @categoria < CategoryID
	END
	RETURN
END
GO

SELECT * 
FROM dbo.fn_seis()
GO


/*
	7.- FUNCION DE TABLA DE MULTISENTENCIA QUE RECIBA UN A�O COMO PARAMETRO DE ENTRADA, 
	QUE REGRESE UNA TABLA CON DOS COLUMNAS: DIA DE LA SEMANA, 
	FOLIOS QUE SE VENDIERON ESE D�A DE SEMANA. 
	NOTA, DEBE MOSTRAR TODOS LOS DIAS DE LA SEMANA AUNQUE NO SE HAYAN REALIZADO ORDENES.
 */

CREATE OR ALTER FUNCTION dbo.fn_folios_por_semana(@ANIO INT)
RETURNS @Salida TABLE ([Dia de la semana] VARCHAR(50), Folios VARCHAR(1000))
AS 
BEGIN
	DECLARE @DiasSemana TABLE(ID INT, DIA VARCHAR(50))

	INSERT INTO @DiasSemana VALUES (1, 'Domingo'), 
		(2, 'Lunes'),
		(3, 'Martes'),
		(4, 'Miercoles'),
		(5, 'Jueves'),
		(6, 'Viernes'),
		(7, 'Sabado')

	INSERT @Salida
	SELECT d.DIA, ISNULL(STRING_AGG(CONVERT(VARCHAR(50), o.OrderID), ', '), 0)
	FROM Orders o
	RIGHT OUTER JOIN @DiasSemana d ON DATEPART(DW, o.OrderDate) = d.ID
	AND YEAR(o.OrderDate) = @ANIO
	GROUP BY d.DIA, d.ID
	ORDER BY d.ID

	RETURN
END
GO

SELECT * 
FROM dbo.fn_folios_por_semana(1998)
GO