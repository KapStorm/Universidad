-- Consulta con el nombre del cliente, el importe total de ventas,
-- importe de 1996, importe 1997 e importe 1998
SELECT NomCliente, Total = SUM(Quantity * UnitPrice)
FROM vw_orderdetails
GROUP BY NomCliente

-- Estructura de case when
-- CASE WHEN condicion THEN "verdadero" ELSE "falso" END

-- CASE WHEN condicion THEN 
--  "verdadero" 
-- ELSE 
--  "falso" 
-- END

SELECT NomCliente, 
Total = SUM(Quantity * UnitPrice), 
total96 = SUM(CASE WHEN YEAR(OrderDate) = 1996 THEN Quantity * UnitPrice ELSE 0 END),
total97 = SUM(CASE WHEN YEAR(OrderDate) = 1997 THEN Quantity * UnitPrice ELSE 0 END),
total98 = SUM(CASE WHEN YEAR(OrderDate) = 1998 THEN Quantity * UnitPrice ELSE 0 END)
FROM vw_orderdetails
GROUP BY NomCliente

-- La consulta anterior no muestra todos los clientes, modificar la consulta para que los muestre
SELECT
c.CompanyName,
ImporteTotal = ISNULL(SUM(Quantity * UnitPrice), 0),
total96 = SUM(CASE WHEN YEAR(OrderDate) = 1996 THEN Quantity * UnitPrice ELSE 0 END),
total97 = SUM(CASE WHEN YEAR(OrderDate) = 1997 THEN Quantity * UnitPrice ELSE 0 END),
total98 = SUM(CASE WHEN YEAR(OrderDate) = 1998 THEN Quantity * UnitPrice ELSE 0 END)
FROM vw_orderdetails d
RIGHT OUTER JOIN Customers c ON d.CustomerId = c.CustomerID
GROUP BY c.CompanyName

-- Consulta con el nombre del cliente, el importe total de ventas,
-- importe de 1996, importe 1997 e importe 1998
GO
CREATE VIEW vw_cte96 AS
SELECT NomCliente, T96 = SUM(Quantity * UnitPrice)
FROM vw_orderdetails
WHERE YEAR(OrderDate) = 1996
GROUP BY NomCliente
GO

CREATE VIEW vw_cte97 AS 
SELECT NomCliente, T97 = SUM(Quantity * UnitPrice)
FROM vw_orderdetails
WHERE YEAR(OrderDate) = 1997
GROUP BY NomCliente
GO

CREATE VIEW vw_cte98 AS 
SELECT NomCliente, T98 = SUM(Quantity * UnitPrice)
FROM vw_orderdetails
WHERE YEAR(OrderDate) = 1998
GROUP BY NomCliente
GO

-- No muestra todos los clientes
SELECT A.NomCliente, A.T96, B.T97, C.T98
FROM vw_cte96 A
LEFT OUTER JOIN vw_cte97 B ON A.NomCliente = B.NomCliente
LEFT OUTER JOIN vw_cte98 C ON A.NomCliente = C.NomCliente

-- Muetra todos los clientes
SELECT C.CompanyName, ISNULL(A.T96, 0), ISNULL(B.T97, 0), ISNULL(D.T98, 0)
FROM Customers C
LEFT OUTER JOIN vw_cte96 A ON C.CompanyName = A.NomCliente
LEFT OUTER JOIN vw_cte97 B ON C.CompanyName = B.NomCliente
LEFT OUTER JOIN vw_cte98 D ON C.CompanyName = D.NomCliente

-- Consulta con el nombre de producto, total de piezas vendidas e importe de venta
-- mostrar solo los productos que tengan un importe menor a 3000
SELECT OrderId, NomCliente, ProductName, Quantity, UnitPrice
FROM vw_orderdetails
ORDER BY ProductName

SELECT ProductName, Piezas = COUNT(Quantity), Importe = SUM(Quantity * UnitPrice)
FROM vw_orderdetails
GROUP BY ProductName
HAVING SUM(Quantity * UnitPrice) < 3000

-- Nombre del empleado, total de clientes atendidos, total de ordenes realizadas en
-- importe de venta
SELECT OrderId, FirstName, LastName, CustomerId, NomCliente, ProductName, Quantity, UnitPrice
FROM vw_orderdetails
ORDER BY FirstName

SELECT FirstName, LastName, Clientes = COUNT(DISTINCT CustomerId), Ordernes = COUNT(DISTINCT OrderId), Importe = SUM(Quantity * UnitPrice), COUNT(*)
FROM vw_orderdetails
GROUP BY FirstName, LastName
