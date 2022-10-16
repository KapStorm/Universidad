-- Programacion cn Transact-SQL

-- Declaracion de variable
DECLARE @nom_variable tipo_dato

-- Tipo_dato: Son tipos de datos valido en SQL Server
-- BIT, INT, NUMERIC, CHAR, VACHAR, DATETIME, etc

-- Asignacion de variable
SELECT @nom_variable = valor;
SET @nom_variable = valor;

-- Los valores de cadena de caracteres y fecha llevan comillas para su asignacion
SELECT @nacimiento = '01-01-2007'
SELECT @nombre = 'Juan Perez'

-- Los valores numericos se asignan de manera normal
SELECT @x = 12.1

-- Impresion
PRINT @nom_variable
SELECT @nom_variable

-- Ejemplo
DECLARE @total NUMERIC(7, 3) -- +- 9999.999
SELECT @total
SELECT @total = 9999.999
SELECT @total
SELECT @total = COUNT(*) FROM Employees
SELECT @total
GO