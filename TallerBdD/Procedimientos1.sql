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

CREATE PROC SP_AUMENTO AS 
UPDATE PRODUCTS SET UNITPRICE= UNITPRICE*1.1
GO
--EJECUCION
EXEC SP_AUMENTO
--VALIDAR EL PRODUCTO 1
SELECT PRODUCTID, UNITPRICE FROM PRODUCTS WHERE PRODUCTID=1
--3.-SP CON PARAMETROS DE ENTRADA
--SP RECIBA 4 CALIFICACIONES IMPRIMIR EL PROMEDIO
CREATE PROC SP_CALIFICACIONES
@CAL1 INT, @CAL2 INT, @CAL3 INT, @CAL4 INT AS
DECLARE @PROM NUMERIC(12,2)
SELECT @PROM =(@CAL1+@CAL2+@CAL3+@CAL4)/4
SELECT @PROM
GO