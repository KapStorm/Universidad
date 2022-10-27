--Programacion con Transact-SQL
--Declaracion de variable
declare @nom_variable tipo_dato
--Tipo_dato: Son tipos de datos validos en sql server:
bit, int, numeric, char, varchar,datetime, etc.
--Asignacion de variable
select @nom_variable=valor;
set @nom_variable=valor;
--Los valores de cadena de caracteres y fecha llevan comillas para su asignacion
select @nacimiento='01-01-2007'
select @nombre='Juan Perez'
--Los valores numericos se asignan de manera formal
select @x=12.1

--Impresion
print @nom_variable
select @nom_variable

--Ejemplo
declare @total numeric(7,3)-- -+9999.999
select @total
select @total=9999.999
select @total
select @total=count(*) from employees
select @total
go

--Control de flujo
--Bloque: determina una unidad de trabahjo en sql server

--Sentencia if: Se utiliza para ejecutar una condicion
if(condicion)
begin
	sentencia1
	sentencia2
end 
else
begin
	sentencia3
	sentencia4
end
--Imprimir el precio del producto mas caro y especificar si es mayor a 30 pesos o no
declare @precio numeric(12,2)
select @precio=max(unitprice) from products 

if @precio>30
	print 'El precio maximo es mayor a 30=' + convert(varchar(10),@precio)
else
	print 'El precio maximo es menor a 30='+ convert(varchar(10),@precio)

--instruccion if exists(consulta): se utiliza para consultar y verificar la existencia
--de registros.

--verificar si existe el producto 1000
if(select * from products where productid=1000)
	print'Si existe el producto 1000'
else
	print 'no existe el producto 1000'

--sentencia while
while(condicion)
begin
	sentencia1
	sentencia2
end
use Northwind
--recorrer la tabla productos e imprimir la clave de todos los productos
declare @min int
select @min = min(productid) from products
while @min is not null
begin
	print @min
	select @min=min(productid) from products where productid>@min
end
print 'fin del ciclo'

--recorrer la tabla empleados e imprimir la clave de todos los empleados de menor a mayor
declare @emp int
select @emp = min(employeeid) from employess
while @emp is not null
begin
	print @emp
	select @emp=min(employeeid) from employees where employees>@emp
end
print 'fin del ciclo'

declare @emp int, @jefe int 
select @emp= max(employeeid) from employees

while @emp is not null
begin
	select @jefe= reportsto from employees where employeeid=@emp
	print str(@emp) + ','+ str( is not null(@jefe,'') )
	select @emp= max(employeeid) from employees where employeeid<@emp
end
print 'fin del ciclo'

--	Proceso que reciba la fecha en la que inicio a trabajar un empleado  y calcule los dias 
--	trabajados restar solo los sabados y domingos

declare @fecha datetime, @conta int=0, @dia int

select @fecha='1-1-2000'

while @fecha<=getDate()
begin
	select @dia=datepart(dw, @fecha)
	if @dia in (2,3,4,5,6)
		select @conta=@conta+1
	select @fecha=dateadd(dd,1,@fecha)
end
select @conta
--proceso para encontrar los dias trabajados de todos los empleado descontando sabados y domingos
declare @clave int, @dia int, @conta int, @fecha datetime
create table #tabla(emp int, dias int)
select @clave=min(employeeid) from employees
while @clave is not null
begin
	select @fecha=hiredate from employees where employeeid=@clave
	select @conta=0
	while @fecha<= getdate()
	begin
		select @dia=datepart(dw, @fecha)
		if @dia not in(1,7)
			select @conta= @conta+1
		select @fecha=dateadd(dd,1,@fecha)
	end
	insert #tabla values(@clave, @conta)
	select @clave= min(employeeid) from Employees where employeeid>@clave
end
select e.firstname+' '+ e.lastname, trabajados=T.dias, datediff(dd, e.hiredate, getdate() )
from #tabla T
inner join employees e on e.EmployeeID=T.emp

--2.- SIN PARAMETROS
--PROCEDIMIENTO QUE ACTUALICE EL PRECIO DE TODOS LOS PRODUCTOS Y AUMENTE EL 10%
GO
CREATE PROC SP_AUMENTO AS 
UPDATE PRODUCTS SET UNITPRICE= UNITPRICE*1.1
GO
--EJECUCION
EXEC SP_AUMENTO
--VALIDAR EL PRODUCTO 1
SELECT PRODUCTID, UNITPRICE FROM PRODUCTS WHERE PRODUCTID=1
--3.-SP CON PARAMETROS DE ENTRADA
--SP RECIBA 4 CALIFICACIONES IMPRIMIR EL PROMEDIO
GO	
CREATE PROC SP_CALIFICACIONES
@CAL1 INT, @CAL2 INT, @CAL3 INT, @CAL4 INT AS
DECLARE @PROM NUMERIC(12,2)
SELECT @PROM =(@CAL1+@CAL2+@CAL3+@CAL4)/4
SELECT @PROM
GO
EXEC SP_CALIFICACIONES 34,56,79,80

--SE PUEDE CAMBIAR EL NOMBRE DE LOS PARAMETROS INDICANDO EL NOMBRE ANTES DEL VALOR
GO
--4.- CON PAREMETROS DE SALIDA
-- SP QUE RECIBA 4 CALIFICACIONES Y REGRESE COMO PARAMETRO DE SALIDA EL PROMEDIO Y SI FUE APROBADO
CREATE PROC SP_CALIFICACIONES_SAL
@CAL1 INT, @CAL2 INT, @CAL3 INT, @CAL4 INT,
@PROM NUMERIC(12,2) OUTPUT, @TIPO CHAR(20) OUTPUT AS

SELECT @PROM=(@CAL1+@CAL2+@CAL3+@CAL4)/4.0
IF @PROM >=70
	SELECT @TIPO='APROBADO'
ELSE
	SELECT @TIPO='REPROBADO'
GO
--EJECUTARLO
DECLARE @A NUMERIC(12,3), @B CHAR(20)
SELECT @A, @B
EXEC SP_CALIFICACIONES_SAL 70,80,60,70 @A OUTPUT, @B OUTPUT
SELECT CALIFICACION=@A, RESULTADO=@B
GO
--SP PROPORCIONAR UNA FECHA DE NACIMIENTO Y CALCULAR UNA FECHA EXACTA
CREATE PROC SP_EDAD @FECHA DATETIME, @EDAD INT OUTPUT AS
SELECT @EDAD= DATEDIFF(YY,@FECHA,GETDATE())
SELECT @FECHA=DATEADD(YY, @EDAD, @FECHA)

IF(@FECHA>GETDATE())
	SELECT @EDAD= @EDAD-1
GO
--EJECUCION
DECLARE @R INT
EXEC SP_EDAD '10-11-2000', @R OUTPUT
SELECT @R
GO
--SP QUE IMPRIMA TABLA CON EL NOMBRE DEL EMPLEADO Y LA EDAD EXACTA DEL EMPLEADO
CREATE PROC SP_EDAD_TODOS AS
DECLARE @EMP INT, @EDADEXACTA INT, @FECHANAC DATETIME
CREATE TABLE #AUX( EMP INT, EDADEXACTA INT)
SELECT @EMP=MIN(EMPLOYEEID) FROM EMPLOYEES
WHILE(@EMP IS NOT NULL)
BEGIN
	SELECT @FECHANAC=BIRTHDATE FROM EMPLOYEES WHERE EMPLOYEEID=@EMP
	EXEC SP_EDAD @FECHANAC, @EDADEXACTA OUTPUT
	INSERT INTO #AUX VALUES(@EMP,@EDADEXACTA)
	SELECT @EMP=MIN(EMPLOYEEID) FROM EMPLOYEES WHERE EMPLOYEEID>@EMP
END
SELECT NOMBRE=e.FirstName+' '+e.LastName, e.BirthDate, EDADEXACTA=a.EDADEXACTA
FROM #AUX a
INNER JOIN EMPLOYEES e ON e.EmployeeID=a.emp
GO
EXEC SP_EDAD_TODOS
--5.- POR VALOR POR RETORNO
--VALOR POR RETORNO UTILIZA LA PALABRA RESERVADA RETURN Y
--REGRESA SOLO VALORES ENTEROS
CREATE PROC SP_CALIFICACIONES_RETURN
@CAL1 INT, @CAL2 INT, @CAL3 INT, @CAL4 INT AS
DECLARE @PROM INT
SELECT @PROM=(@CAL1+@CAL2+@CAL3+@CAL4)/4.0
RETURN @PROM
--EJECUCION
DECLARE @A INTEGER
SELECT @A
EXEC @A=SP_CALIFICACIONES_RETURN 60,80,98,70
SELECT @A
GO
--6 CON VALORES PREDEFINIDOS
-- PROCEDIMIENTO QUE RECIBE PARAMETROS Y TIENEN VALORES PREDEFINIDOS 
-- DECLARACION
CREATE PROC SP_RECIBIR_DEFAULT
@VAL1 INT, @VAL2 INT, @VAL3 INT=20, @VAL4 INT=30 AS
DECLARE @TOTAL INT
SELECT @TOTAL =@VAL1 + @VAL2 +@VAL3+@VAL4
SELECT @TOTAL
GO
--EJECUCION
EXEC SP_RECIBIR_DEFAULT 2,4,5,6
--SE PUEDEN OMITIR LOS 2 ULTIMOS VALORES
EXEC SP_RECIBIR_DEFAULT 2,4
EXEC SP_RECIBIR_DEFAULT 2,4,@VAL4=6
GO
/*
	DICCIONARIO DE DATOS
	Es la referencia con la que cuenta el servidor para guardar
	la estructura de las tablas, vistas y sp. Esta informacion esta 
	contenida en tablas de sistema, las cuales guardan la informacion
	de las tablas de usuario
*/
--TABLAS DEL SISTEMA
-- Tabla de SYSOBJECTS:
-- Contiene la informacion referente a tablas, vistas, sp, funciones y demas 
-- objetos en la BDD
select * from sysobjects
select * from information_schema.tables
xtype:
u: tablas
p: sp
v: vistas
fn, tf: funciones

--Tablas de usuario de la base de datos
select id, name, xtype
from sysobjects where xtype='u'
order by id

funciones utilizadas: 
object_id('Nombre Tabla'):
--Funci�n que recibe el nombre de un objeto y regresa el
--identificador de dicho objeto
select object_id( 'categories' )

object_name( Identificador )
--Funcion que recibe el identificador de un objeto y regresa el nombre
--de dicho objeto
select object_name(21575115)
use Northwind
--Tabla SYSCOLUMNS:
--Contiene el nombre de las columnas de tablas y vistas, tambi�n
--el nombre de los parametros de los procedimientos almacenados.
select id,colid,colorder,name,xtype, length, prec, scale,isnullable
from syscolumns where object_id('products')=id



select a.COLUMN_NAME,IS_NULLABLE,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH from information_schema.columns a where table_name like'products'
--Tabla SYSTYPES:
--Contiene los tipos de datos asociados a columnas de tablas y vistas,
--tambien incluye los tipos de datos asociados a los parametros de los proc alm.
select  XTYPE, NAME from systypes

--consultar el nombre de las columnas y tipos de datos
select c.colid, c.name, tipo=t.name, c.prec, c.scale, isnullable
from syscolumns c
inner join systypes t on c.xtype=t.xtype
where c.id=object_id('region') and t.name not like 'sysname'
order by c.colid

/*
	SP QUE RECIBA LA CLAVE DEL EMPLEADO Y REGRESE LA CLAVE 
	DEL JEFE SUPERIOR Y EL NIVEL DEL EMPLEADO
*/
GO
CREATE PROC SP_JEFESUPERIOR @EMP INT, @JEFESUP INT OUTPUT, @NIVEL INT OUTPUT AS
	DECLARE @AUX INT
	SELECT @NIVEL=0
	SELECT @JEFESUP= REPORTSTO FROM EMPLOYEES WHERE EmployeeID=@EMP
	WHILE @JEFESUP IS NOT NULL
	BEGIN
		SELECT @AUX=@JEFESUP
		SELECT @NIVEL= @NIVEL+1
		SELECT @JEFESUP= REPORTSTO FROM Employees WHERE EmployeeID=@JEFESUP
	END
	SELECT @JEFESUP=@AUX
GO
--EJECUCION
DECLARE @A INT, @B INT
EXEC SP_JEFESUPERIOR 3,@A OUTPUT, @B OUTPUT
SELECT SUP=@A, NIVEL=@B
GO
--FACTORIAL RECURSIVO

CREATE FUNCTION DBO.FACTORIAL( @NUMERO INT )
RETURNS INT
AS 
BEGIN 
	IF @NUMERO<=1
		RETURN 1
	RETURN @NUMERO * DBO.FACTORIAL(@NUMERO-1)
END
GO
--
SELECT DBO.FACTORIAL(5)

SELECT EMPLOYEEID, REPORTSTO FROM Employees
--FUNCION JEFE SUPERIOR: LA FUNCION RECIBE LA CLAVE DE UN EMPLEADO Y REGRESA
--EL JEFE SUPERIOR
GO
CREATE FUNCTION dbo.JEFE( @EMP INT)
RETURNS INT
AS
BEGIN 
	DECLARE @JEFE INT, @R INT 
	SELECT @JEFE= REPORTSTO FROM EMPLOYEES WHERE EMPLOYEEID=@EMP
	IF @JEFE IS NULL
		SELECT @R=@EMP
	ELSE
		SELECT @R=dbo.JEFE(@JEFE)
	RETURN @R
END
GO
--EJECUCION
SELECT dbo.JEFE(3)
GO
/*
	||. FUNCIONES DE TABLA EN LINEA
	Las funciones de tabkla en linea son las funciones que devuelven la salida de una simple declaracion
	SELECT. La salida se puede utilizar adentro de consultas como si fuera una tabla estandar.

	La sintaxis para una funcion de una tabla en linea es como sigue: 
*/
CREATE FUNCTION [PROPIETARIO].NOMBRE_FUNCION
(@NOMBREPARAMETRO TIPODATO[=default],...)
RETURNS TABLE
AS 
RETURN (SENTENCIA_SELECT)
--ejecucion
SELECT * FROM dbo.nombre(parametros)
GO
CREATE FUNCTION dbo.Ordenes(@EMP INT)
RETURNS TABLE
AS 
RETURN (SELECT * FROM Orders WHERE EmployeeID=@EMP)
GO
--EJECUCION
SELECT * FROM dbo.Ordenes(1)

SELECT O.OrderID,E.FirstName, D.UnitPrice, D.Quantity
FROM dbo.Ordenes(1) O
INNER JOIN [Order Details] D ON O.OrderID=D.OrderID
INNER JOIN Employees E ON O.EmployeeID=E.EmployeeID
--EJEMPLO 1
--FUNCION DE TABLA EN LINEA QUE RECIBA EL A�O Y REGRESE EL NOMBRE DEL CLIENTE
--Y EL TOTAL DE ORDENES DE ESE A�O, DEBE MOSTRAR TODOS LOS CLIENTES AUNQUE NO HAYAN
--
GO
CREATE OR ALTER FUNCTION dbo.OrdenesA�o(@a�o INT )
RETURNS TABLE
AS
RETURN (
	SELECT c.CompanyName, 'Total'= COUNT(o.OrderID)
	FROM Orders o
	RIGHT OUTER JOIN Customers c on o.CustomerID=c.CustomerID
	GROUP BY c.CompanyName
)
GO
--EJECUCION
SELECT * FROM dbo.OrdenesA�o(1996) ORDER BY CompanyName
SELECT * FROM dbo.OrdenesA�o(1997) ORDER BY 1
SELECT * FROM dbo.OrdenesA�o(2000) ORDER BY 1

--NOMBRE DEL CLIENTE, TOTAL DE ORDENES 96, TOTAL DE ORDENES 97, TOTAL DE ORDENES 98
SELECT  a.CompanyName, T96=a.Total, T97=b.Total, T98=c.Total 
FROM dbo.OrdenesA�o(1996) a
INNER JOIN dbo.OrdenesA�o(1997) b on a.CompanyName=b.CompanyName
INNER JOIN dbo.OrdenesA�o(1998) c on a.CompanyName=c.CompanyName

--EJEMPLO 2
--FUNCION DE TABLA EN LINEA QUE RECIBA EL A�O Y REGRESA EL DIA DE LA SEMANA
--Y EL IMPORTE TOTAL DE VENTA DE ESE DIA
GO
CREATE FUNCTION DBO.FN_VENTASDIA(@A�O INT)
RETURNS TABLE
AS RETURN(
	SELECT CLAVE= DATEPART(DW, O.OrderDate), DIA=DATENAME(DW, O.OrderDate),TOTAL=SUM(D.Quantity*D.UnitPrice)
	FROM ORDERS O
	INNER JOIN [Order Details] D ON D.OrderID=O.OrderID
	WHERE YEAR(O.OrderDate)=@A�O
	GROUP BY DATENAME(DW, O.OrderDate), DATEPART(DW, O.OrderDate))
GO
SELECT * FROM DBO.FN_VENTASDIA(2000) ORDER BY CLAVE
GO
--PROBLEMA, NO APARECEN LOS 7 DIAS DE LA SEMANA Y NO APARECEN ORDENADOS POR DIA DE LA SEMANA
CREATE FUNCTION DBO.FN_DIASSEMANA()
RETURNS TABLE
AS RETURN(
	SELECT CLAVE=1, NOMBRE='Sunday' UNION
	SELECT 2, 'Monday' UNION
	SELECT 3,'Tuesday' UNION
	SELECT 4,'Wednesdey' UNION
	SELECT 5,'Thursday' UNION
	SELECT 6,'Friday' UNION
	SELECT 7,'Saturday' 
)
GO
--Ejecucion
SELECT *FROM dbo.FN_DIASSEMANA()
--Soluci�n A
SELECT d.nombre,TOTAL=COALESCE(V.TOTAL,0)
FROM dbo.FN_DIASSEMANA() d
LEFT OUTER JOIN dbo.FN_VENTASDIA(2000) v on v.clave=d.clave
ORDER BY d.clave
GO
--Solucion B
CREATE FUNCTION DBO.FN_VENTASDIAS(@A�O INT)
RETURNS TABLE
AS RETURN(
	SELECT S.CLAVE, DIA=S.NOMBRE,TOTAL=ISNULL(SUM(D.QUANTITY* D.UNITPRICE),0)
	FROM DBO.FN_DIASSEMANA() S
	LEFT OUTER JOIN ORDERS O ON S.CLAVE=DATEPART(DW,O.ORDERDATE) AND YEAR(O.ORDERDATE)=@A�O
	LEFT OUTER JOIN [ORDER DETAILS] D on D.ORDERID=O.OrderID
	GROUP BY S.NOMBRE, S.CLAVE
)
--
SELECT * FROM DBO.FN_VENTASDIAS(2000) O ORDER BY 1
/*
	|||.-LAS FUNCIONES DE TABLA DE MULTISENTENCIAS
	Son simillares a los procedimientos almacenados, excepto que regresan una tabla siempre,
	Este tipo de funci�n se usa en situaciones donde se requiere m�s logica y proceso.
	Su sintaxis es:
*/
CREATE FUNCTION [propietario.] nombreFuncion
(@parametros Tipo[=DEFAULT])
GO
CREATE FUNCTION dbo.DiaSemana2()
returns @semana table( clave int, nombre varchar(20) )
as
begin
	insert @semana values(1,'Sunday')
	insert @semana values(2,'Monday')
	insert @semana values(3,'Tuesday')
	insert @semana values(4,'Wednesday')
	insert @semana values(5,'Thursday')
	insert @semana values(6,'Friday')
	insert @semana values(7,'Saturday')
	return
end
--
select * from dbo.DiaSemana2()
--CONSULTA CON EL DIA DE LA SEMANA Y EL TOTAL DE ORDENES REALIZADAS,
-- SE DEBEN MOSTRAR LOS 7 DIAS DE LA SEMANA
SELECT d.nombre, count(o.orderid)
FROM dbo.DiaSemana2() d
LEFT OUTER JOIN Orders o on datepart(dw, o.orderdate)=d.claveCREATE OR ALTER PROC sp_compras AS
BEGIN
    CREATE TABLE #Salida(Fecha DATETIME, Nombre VARCHAR(500))
    DECLARE @Fecha DATE

    SELECT @Fecha = MIN(OrderDate) 
    FROM Orders

    WHILE @Fecha IS NOT NULL
    BEGIN
        DECLARE @Aux INT, @Nombres VARCHAR(500)
        SELECT @Nombres = ''

        SELECT @Aux = MIN(OrderID)
        FROM Orders
        WHERE OrderDate = @Fecha

        WHILE @Aux IS NOT NULL
        BEGIN
            SELECT @Nombres = @Nombres + c.CompanyName + ', '
            FROM Orders o
            INNER JOIN Customers c ON o.CustomerID = c.CustomerID
            WHERE o.OrderID = @Aux

            SELECT @Aux = MIN(OrderID)
            FROM Orders
            WHERE @Aux < OrderID
            AND OrderDate = @Fecha
        END

        SELECT @Nombres = SUBSTRING(@Nombres, 1, LEN(@Nombres) - 1)

        INSERT INTO #Salida VALUES (@Fecha, @Nombres)

        SELECT @Fecha = MIN(OrderDate)
        FROM Orders
        WHERE @Fecha < OrderDate
    END

    SELECT * FROM #Salida
END          
GO

EXEC sp_compras
GO

CREATE OR ALTER PROC sp_compras AS
BEGIN
    CREATE TABLE #Salida(Fecha DATETIME, Nombre VARCHAR(500))
    DECLARE @Fecha DATE

    SELECT @Fecha = MIN(OrderDate) 
    FROM Orders

    WHILE @Fecha IS NOT NULL
    BEGIN
        DECLARE @Aux NVARCHAR(500) = ''

        SELECT @Aux = STRING_AGG(c.CompanyName, ',') 
        FROM Orders o
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        WHERE o.OrderDate = @Fecha

        INSERT INTO #Salida VALUES (@Fecha, @Aux)

        SELECT @Fecha = MIN(OrderDate)
        FROM Orders
        WHERE @Fecha < OrderDate
    END

    SELECT * FROM #Salida
END
GO

EXEC sp_compras
GO

GROUP BY d.nombre, d.clave
ORDER BY d.clave
--Funcion multisentencia que reciba un a�o, regrese el nombre del empleado y el total de ventas de los
--empleados en ese a�o, mostrar todos los empleados aunque no hayan realizado ordenes
CREATE FUNCTION FN_VENTAS(@A�O INT)
RETURNS @VENTAS TABLE(NOMEMP VARCHAR(100), TOTAL NUMERIC(12,2) )
AS
BEGIN
	INSERT @VENTAS
	SELECT FIRSTNAME+''+LASTNAME,TOTAL=ISNULL(SUM(QUANTITY*UNITPRICE),0)
	FROM ORDERS O
	RIGHT OUTER JOIN [ORDER DETAILS] D ON O.ORDERID=D.ORDERID
	RIGHT OUTER JOIN EMPLOYEES E ON E.EMPLOYEEID=O.EMPLOYEEID AND YEAR(O.ORDERDATE)=@A�O
	GROUP BY FIRSTNAME, LASTNAME
	RETURN
END
--EJECUCION
SELECT * FROM FN_VENTAS(2000)
--CONSULTA CON EL NOMBRE DEL EMPLEADO Y EL IMPORTE TOTAL DE VENTAS 94,96,99
SELECT A.NOMEMP, T94=ISNULL(A.TOTAL, 0),T96=ISNULL(B.TOTAL,0), T99=ISNULL(C.TOTAL,0)
FROM FN_VENTAS(1994) A
INNER JOIN FN_VENTAS(1996) B ON B.NOMEMP=A.NOMEMP
INNER JOIN FN_VENTAS(1999) C ON C.NOMEMP=A.NOMEMP
--FUNCION DE TABLA MULTISENTENCIA QUE REGRESE LA CLAVE DEL EMPLEADO Y EL TOTAL DE DIAS TRABAJADOS
--DESCONTANDO SABADOS Y DOMINGOS
CREATE FUNCTION dbo.fn_diastrabajados()
returns @resp table( emp int, dias int) as
begin
	declare @empid int,@dias int, @fechainicio datetime,@contador int
	select @empid=min(employeeid) from employees
	while @empid is not null
	begin 
		select @fechainicio=hiredate from employees where employeeid=@empid
		select @contador=0
		while @fechainicio<=getdate()
		begin
			if not( datepart(dw, @fechainicio) in (1,7) )
				select @contador+=1
			select @fechainicio=dateadd(dd,1,@fechainicio)
		end
		insert @resp values (@empid, @contador)
		select @empid=min(employeeid) from employees where employeeid>@empid
	end
	return
end
select * from dbo.fn_diastrabajados()
--ejecucion
select e.firstname+' '+e.lastname, d.dias
from dbo.fn_diastrabajados() d
inner join employees e on e.employeeid=d.emp
--funcion multisentencia que recibe el a�o y regrese todos los meses y el importe total de venta
go
create OR ALTER function dbo.fn_ImporteMeses(@anio int)
returns @resp table( clave int, nombremes varchar(20), total numeric(12,2) ) as
begin
	declare @mes table(clave int, nombremes varchar(20) )
	insert @mes values(1,'January')
	insert @mes values(2,'February')
	insert @mes values(3,'March')
	insert @mes values(4,'April')
	insert @mes values(5,'May')
	insert @mes values(6,'June')
	insert @mes values(7,'July')
	insert @mes values(8,'August')
	insert @mes values(9,'September')
	insert @mes values(10,'October')
	insert @mes values(11,'November')
	insert @mes values(12,'December')

	insert @resp
	select m.clave, m.nombremes, SUM(d.Quantity * d.UnitPrice - d.Discount)
	from [order details] d
	RIGHT outer join orders o ON d.OrderID = o.OrderID
	RIGHT outer join @mes m ON DATEPART(MM, o.OrderDate) = m.clave
	WHERE YEAR(o.OrderDate) = @anio
	group by m.clave, m.nombremes
	order by m.clave

	return
end
GO

SELECT * FROM dbo.fn_ImporteMeses(1996)

SELECT Mes = DATENAME(MM, o.OrderDate) ,Total = SUM(od.Quantity * od.UnitPrice - od.Discount)
FROM [Order Details] od
INNER JOIN Orders o ON od.OrderID = o.OrderID
WHERE YEAR(o.OrderDate) = 1996
GROUP BY DATEPART(MM, o.OrderDate), DATENAME(MM, o.OrderDate)
ORDER BY DATEPART(MM, o.OrderDate) ASC