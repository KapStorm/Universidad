USE Northwind
GO


/*
    1.- AGREGAR A LA TABLA CATEGORIES EL CAMPO TOTALPIEZAS, EL CUAL REPRESENTARÁ EL TOTAL 
    DE PIEZAS VENDIDAS DE CADA CATEGORIA. CREAR UN PROCEDIMIENTO ALMACENADO QUE LLENE DICHO CAMPO.
*/
ALTER TABLE Categories ADD PiezasVendidas INT
GO

CREATE OR ALTER PROC sp_piezas AS
BEGIN
    DECLARE @AuxCategoria INT, @AuxTotal INT

    SELECT @AuxCategoria = MIN(CategoryID)
    FROM Categories

    WHILE @AuxCategoria IS NOT NULL
    BEGIN
        SELECT @AuxTotal = SUM(od.Quantity)
        FROM [Order Details] od
        INNER JOIN Products p ON od.ProductID = p.ProductID
        WHERE @AuxCategoria = p.CategoryID

        UPDATE Categories 
        SET PiezasVendidas = @AuxTotal 
        WHERE CategoryID = @AuxCategoria 

        SELECT @AuxCategoria = MIN(CategoryID)
        FROM Categories
        WHERE @AuxCategoria < CategoryID
    END
END
GO

EXEC sp_piezas
SELECT * FROM Categories
GO


/*
    2.- SP QUE RECIBA LA CLAVE DEL EMPLEADO Y REGRESE POR RETORNO LA EDAD EXACTA DEL EMPLEADO.
*/
CREATE OR ALTER PROC sp_edad_exacta @EmpId INT, @EdadExacta INT OUTPUT AS
BEGIN
    DECLARE @FechaNacimiento DATETIME

    SELECT @FechaNacimiento = BirthDate 
    FROM Employees 
    WHERE EmployeeID = @EmpId

    SELECT @EdadExacta = DATEDIFF(YY, @FechaNacimiento, GETDATE())
    IF @FechaNacimiento > GETDATE()
        SELECT @EdadExacta = @EdadExacta - 1
END
GO

DECLARE @R INT
EXEC sp_edad_exacta 4, @R OUTPUT
SELECT EdadExacta = @R
GO


/*
    3.- PROCEDIMIENTO ALMACENADO QUE RECIBA COMO PARAMETRO UNA FECHA Y REGRESE DOS PARAMETROS: 
    UN PARAMETRO CON EL NOMBRE DE TODOS LOS CLIENTES QUE COMPRARON ESE DIA Y OTRO PARAMETRO 
    CON LA LISTA DE LAS ORDENES REALIZADAS ESE DIA.
*/
CREATE OR ALTER PROC sp_compras_por_fecha_dos_parametros @Fecha DATE, @Clientes VARCHAR(500) OUTPUT, @Ordenes VARCHAR(500) OUTPUT AS
BEGIN
    DECLARE @Aux INT

    SELECT @Aux = MIN(OrderID)
    FROM Orders
    WHERE OrderDate = @Fecha

    SELECT @Clientes = '', @Ordenes = ''

    WHILE @Aux IS NOT NULL
    BEGIN
        SELECT @Clientes = @Clientes + c.CompanyName + ', ', @Ordenes = @Ordenes + CONVERT(VARCHAR(10), o.OrderID) + ', '
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        WHERE o.OrderID = @Aux

        SELECT @Aux = MIN(OrderID)
        FROM Orders
        WHERE OrderDate = @Fecha AND @Aux < OrderID
    END
END
GO

DECLARE @R1 VARCHAR(500), @R2 VARCHAR(500)
EXEC sp_compras_por_fecha_dos_parametros '1996-07-19', @R1 OUTPUT, @R2 OUTPUT

SELECT Clientes = @R1, Ordenes = @R2
GO


/*
    4.- PROCEDIMIENTO ALMACENADO QUE REGRESE UNA TABLA CON LA FECHA Y LOS NOMBRES DE LOS 
    CLIENTES QUE COMPRARON ESE DÍA.
*/
CREATE OR ALTER PROC sp_compras_por_fecha @Fecha DATE AS
BEGIN
    SELECT o.OrderDate, c.CompanyName
    FROM Orders o
    INNER JOIN Customers c ON o.CustomerID = c.CustomerID
    WHERE o.OrderDate = @Fecha
END
GO

EXEC sp_compras_por_fecha '1996-07-19'
GO


/*
    5.- SP QUE RECIBA UN AÑO Y REGRESE COMO PARAMETRO DE SALIDA LA CLAVE DEL ARTICULO QUE MAS SE VENDIO ESE AÑO Y CANTIDAD DE PIEZAS VENDIDAS DE ESE PRODUCTO EN ESE AÑO.
*/
CREATE OR ALTER PROC sp_articulo_mas_vendido @Anio INT, @ArticuloId INT OUTPUT, @Cantidad INT OUTPUT AS
BEGIN
    SELECT TOP 1 @ArticuloId = od.ProductID, @Cantidad = SUM(od.Quantity)
    FROM [Order Details] od
    INNER JOIN Orders o ON od.OrderID = o.OrderID
    WHERE YEAR(o.OrderDate) = @Anio
    GROUP BY od.ProductID
    ORDER BY SUM(od.Quantity) DESC
END
GO

DECLARE @R1 INT, @R2 INT
EXEC sp_articulo_mas_vendido 1996, @R1 OUTPUT, @R2 OUTPUT

SELECT Articulo = @R1, Cantidad = @R2
GO

/*
    6.- SP QUE RECIBA LA CLAVE DEL EMPLEADO Y REGRESE COMO PARAMETRO DE SALIDA TODOS LOS NOMBRES DE LOS TERRITORIOS QUE ATIENDEN EL EMPLEADO.
*/
CREATE OR ALTER PROC sp_territorios_empleado @EmpleadoId INT AS
BEGIN
    SELECT t.TerritoryDescription
    FROM EmployeeTerritories et
    INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID
END 
GO

EXEC sp_territorios_empleado 1
GO


/*
    7.- SP QUE REALICE UN PROCESO DONDE REGRESE LA SIGUIENTE TABLA:
    | Nombre empleado | Nombre de jefe | Jefe Superior |
*/
CREATE OR ALTER PROC sp_empleado_jefes AS
BEGIN
    CREATE TABLE #Aux (
        NombreEmpleado VARCHAR(50), 
        NombreDeJefes VARCHAR(500), 
        JefeSuperior VARCHAR(50)
    )

    DECLARE @AuxEmpId INT

    SELECT @AuxEmpId = MIN(EmployeeID)
    FROM Employees

    WHILE @AuxEmpId IS NOT NULL
    BEGIN
        DECLARE @AuxJefeId INT, @AuxNombreJefes VARCHAR(500), @AuxUltimoJefe VARCHAR(50), @AuxNombreEmp VARCHAR(50)

        SELECT @AuxNombreEmp = FirstName + ' ' + LastName
        FROM Employees
        WHERE EmployeeID = @AuxEmpId

        SELECT @AuxJefeId = ReportsTo
        FROM Employees
        WHERE EmployeeID = @AuxEmpId

        SELECT @AuxNombreJefes = ''

        WHILE @AuxJefeId IS NOT NULL
        BEGIN
            SELECT 
            @AuxJefeId = ReportsTo,
            @AuxNombreJefes = @AuxNombreJefes + FirstName + ' ' + LastName + ', ',
            @AuxUltimoJefe = FirstName + ' ' + LastName
            FROM Employees
            WHERE EmployeeID = @AuxJefeId
        END

        INSERT INTO #Aux VALUES (@AuxNombreEmp, @AuxNombreJefes, @AuxUltimoJefe)

        SELECT @AuxEmpId = MIN(EmployeeID)
        FROM Employees 
        WHERE EmployeeID > @AuxEmpId

        SELECT @AuxNombreJefes = '', @AuxUltimoJefe = '', @AuxNombreEmp = ''
    END

    SELECT *
    FROM #Aux
END
GO

EXEC sp_empleado_jefes
GO


/*
    8.- PROCEDIMIENTO ALMACENADO QUE RECIBA EL NOMBRE DE UNA TABLA Y 
    QUE EL PROCEDIMIENTO IMPRIMA EL CODIGO DE CREACIÓN DE DICHA TABLA.
*/
CREATE OR ALTER PROC sp_codigo_tabla @NombreTabla VARCHAR(50) AS
BEGIN
    SELECT Id = OBJECT_ID(@NombreTabla)
END
GO

EXEC sp_codigo_tabla 'Employees'
