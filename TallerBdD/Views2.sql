-- FAMILIA DE VISTAS

-- Plan para generar la familia de vistas en la base de datos Northwind:

-- Se debe ir generando las vistas de afuera hacia adentro e ir reutilizando las
-- vistas creadas previamente con todas sus columnas.

-- Secuencia de creacion de vistas
/*
 * nombre           tablas utilizadas
 * --------------------------------------------------------
 * vw_products              products, categories, suppliers
 * vw_orders                orders, employees, shippers, customers
 * vw_orderdetails          [order details], vw_orders, vw_products
 * 
 * -- suplementarias
 * vw_territories           territories region
 * vw_employeeterritories   vw_territories, employees, employeeterritories
*/
USE Northwind
GO

-- Vistas productos
CREATE VIEW vw_products AS
SELECT p.ProductID, p.ProductName, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued, 
s.SupplierID, s.CompanyName, s.ContactName, s.Address, s.City, s.Region, s.PostalCode, s.Country, s.Phone, s.Fax, s.HomePage, 
c.CategoryID, c.CategoryName, c.[Description], c.Picture
FROM Products p
INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
INNER JOIN Categories c ON p.CategoryID = c.CategoryID
GO

SELECT *
FROM vw_products
GO

-- Consulta con el nombre del proveedor y cuantos productos surte
SELECT ProductName, ContactName, CompanyName
FROM vw_products
ORDER BY CompanyName
GO

-- Primero agrupamos por nombre del proveedor
SELECT CompanyName
FROM vw_products
GROUP BY CompanyName
GO -- Busca los proveedores distintos

-- Total de productos
SELECT COUNT(*)
FROM vw_products
GO

-- Suma de todos los precios de los productos
SELECT SUM(UnitPrice)
FROM vw_products
GO

SELECT UnitPrice
FROM vw_products
GO

-- Clave maxima de productos
SELECT MAX(UnitPrice)
FROM vw_products
GO

-- Clave minima de productos
SELECT MIN(UnitPrice)
FROM vw_products
GO

-- Fecha mas grande de ordenes
SELECT MAX(OrderDate)
FROM Orders
GO

-- Consulta con el nombre del proveedor y cuanto productos surte
SELECT ProductName, CategoryName, CompanyName
FROM vw_products
ORDER BY CompanyName
GO

-- Primero agrupamos por nombre del proveedor
SELECT CompanyName
FROM vw_products
GROUP BY CompanyName
GO

-- Consulta con el nombre de la categoia y cuantos porductos contiene
SELECT ProductName, CategoryName, CompanyName
FROM vw_products
ORDER BY CategoryName
GO

SELECT CategoryName
FROM vw_products
ORDER BY CategoryName
GO

SELECT CategoryName, Total = COUNT(*)
FROM vw_products
GROUP BY CategoryName
GO



-- 27/09/2022
-- Consulta con el folio de la orden y el importe total de la venta
SELECT OrderId, ProductName, Quantity, UnitPrice
FROM vw_orderdetails

SELECT OrderId
FROM vw_orderdetails
GROUP BY OrderId

SELECT OrderId, Importe = SUM(Quantity * UnitPrice)
FROM vw_orderdetails
GROUP BY OrderId

-- Consulta con el nombre de la categoria y total de productos que surte
-- mostrar solo las categorias que tengan menos de 10 productos

-- marca error, no se permiten funciones de agegado en el where
SELECT CategoryName, total = COUNT(*)
FROM vw_products
WHERE COUNT(*) < 10
GROUP BY CategoryName

-- Es neceario incluir laf uncion de agregado en la clausula having
SELECT CategoryName, Total = COUNT(*)
FROM vw_products
GROUP BY CategoryName
HAVING COUNT(*) < 10

-- Consulta con el nombre del proveedor y total de productos que surte
-- mostrar solo los proveedores que su nombe empiece con m, n
-- y que surtan entre 1 y 3 productos

SELECT ProductName, CategoryName, CompanyName
FROM vw_products
ORDER BY CompanyName

SELECT CompanyName, COUNT(*)
FROM vw_products
WHERE CompanyName LIKE '[mn]%'
GROUP BY CompanyName
HAVING COUNT(*) BETWEEN 1 AND 3

-- Consulta con el nombre del cliente, total de ordenes realizadas e importe de ventas,
-- mostrar solo los clientes con un importe mayor a 10,000
SELECT OrderId, NomCliente, ProductName, Qutantity, UnitPrice
FROM vw_orderdetails
ORDER BY NomCliente

SELECT NomCliente, mal = COUNT(*), correcto = COUNT(DISTINCT OrderId), imp = SUM(Quantity * UnitPrice)
FROM vw_orderdetails
ORDER BY NomCliente
HAVING SUM(Quantity * UnitPrice) > 10000