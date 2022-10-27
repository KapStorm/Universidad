/*
3.- FUNCION DE TABLA EN LINEA QUE RECIBA LA CLAVE DE UN PRODUCTO Y REGRESE UNA TABLA CON EL NOMBRE DE TODOS LOS CLIENTES QUE HAN COMPRADO ESE PRODUCTO, EL TOTAL DE PRODUCTOS COMPRADO Y EL TOTAL DE ORDENES EN LAS QUE SE HA VENDIDO.
*/
CREATE OR ALTER FUNCTION dbo.fn_tres(@ProductoId INT)
RETURNS @Test TABLE (ClientNombre NVARCHAR(50), TotalProductos INT, TotalOrdenes INT)
AS
BEGIN
    DECLARE @Min NCHAR(5)

    SELECT @Min = MIN(c.CustomerID)
    FROM Customers c
    INNER JOIN Orders o ON c.CustomerID = o.CustomerID
    INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
    WHERE od.ProductID = @ProductoId

    WHILE @Min IS NOT NULL
    BEGIN
        DECLARE @NombreTemp NVARCHAR(50), @TotalProd INT, @TotalOrd INT
        
        SELECT @NombreTemp = CompanyName
        FROM Customers 
        WHERE CustomerID = @Min

        SELECT 
        @TotalProd = SUM(Quantity),
        @TotalOrd = COUNT(od.OrderID)
        FROM [Order Details] od
        INNER JOIN Orders o ON od.OrderID = o.OrderID
        INNER JOIN Customers c ON o.CustomerID = c.CustomerID
        WHERE od.ProductID = @ProductoId
        AND c.CustomerID = @Min

        INSERT INTO @Test VALUES(@NombreTemp, @TotalProd, @TotalOrd)

        SELECT @Min = MIN(c.CustomerID)
        FROM Customers c
        INNER JOIN Orders o ON c.CustomerID = o.CustomerID
        INNER JOIN [Order Details] od ON o.OrderID = od.OrderID
        WHERE od.ProductID = @ProductoId
        AND c.CustomerID > @Min
    END

    RETURN
END
GO

SELECT * FROM dbo.fn_tres(1)

GO
CREATE OR ALTER FUNCTION dbo.productos(@PRODUCTO INT)
RETURNS TABLE
AS
RETURN (
    SELECT 'Nombre Cliente' = c.CompanyName, 'Total Productos' = SUM(quantity), 'Total Ordenes' = COUNT(o.OrderId)
    FROM Orders o
    INNER JOIN Customers c ON c.CustomerID = o.CustomerID
    INNER JOIN [Order Details] od ON  od.OrderID = o.OrderID
    WHERE od.ProductID = @PRODUCTO
    GROUP BY c.CompanyName
)
GO

SELECT * FROM dbo.productos(1) 
GO
