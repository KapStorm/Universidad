-- 1. mostrar el nombre completo del empleado imprimiendo el nombre en un renglon y el apellido en otro
USE Northwind
SELECT FirstName + ' ' + LastName
	FROM Employees

-- 2. mostrar los empleados que tengan una antiguedad menor a 15 a�os
SELECT *
	FROM Employees
	WHERE YEAR(GETDATE()) - YEAR(HireDate) < 32

-- 3. Consulta con el nombre del empleado y la fecha de nacimiento, debe aparece de la siguiente forma cada
-- empleado:
-- 'JOSE PEREZ NACIO EL DIA 2 DE FEBRERO DE 1998'

SELECT FirstName + ' ' + LastName + ' nacio el dia ' + 
	CONVERT(VARCHAR(2), DAY(BirthDate)) + ' de ' +
	DATENAME(Month, BirthDate) + ' de ' +
	CONVERT(VARCHAR(4), YEAR(BirthDate))
	FROM Employees

-- 4. consulta con la clave y fecha de la orden que se hayan realizado hace 12 a�os
SELECT OrderID, OrderDate
	FROM Orders
	WHERE YEAR(GETDATE()) - YEAR(OrderDate) = 12

-- 5. Consulta con las clave de la orden y fecha de la orden. mostrar solamente las
-- ordenes que se hayan realizado los fines de semana.
SELECT OrderID, OrderDate
	FROM Orders
	WHERE DATEPART(WEEKDAY, OrderDate) = 2
	OR DATEPART(WEEKDAY, OrderDate) = 3

-- 1. Domingo
-- 2. Lunes
-- ..
-- 7. Sabado

-- 6. mostrar en una sola columna la siguiente informaci�n de cada orden :
-- 'la orden 1 fue realizada el dia lunes de la fecha 23 de octubre de 2008'
SELECT 'La orden ' + CONVERT(VARCHAR(10), OrderID) + ' fue realzada el dia ' +
	DATENAME(Day, OrderDate) + ' de la fecha ' +
	CONVERT(VARCHAR(2), DAY(OrderDate)) + ' de ' +
	DATENAME(MM, OrderDate) + ' de ' +
	CONVERT(VARCHAR(4), YEAR(OrderDate))
	FROM Orders

-- 7. consulta con los clientes cuya nombre sea mayor a 10 caracteres.
SELECT *
	FROM Customers
	WHERE LEN(ContactName) > 10

-- 8. consulta con los productos que su nombre empieza con vocal
SELECT *
	FROM Products
	WHERE ProductName LIKE '[aeiou]%'

-- 9. consulta con los empleados que su apellido empiece con consonante.
SELECT *
	FROM Employees
	WHERE LastName LIKE '[^aeiou]%'

-- 10. consulta con todas las ordenes que se hayan realizado en los meses que inicial con vocal.
SELECT *
	FROM Orders
	WHERE DATENAME(MM, OrderDate) LIKE '[aeiou]%'