CREATE FUNCTION dbo.fn_5(@Empleado INT)
RETURNS @Salida TABLE (Fecha DATE, Folios VARCHAR(1000))
AS
BEGIN
    DECLARE @Fecha DATE, @Folios VARCHAR(1000) = ''

    SELECT @Fecha = MIN(OrderDate) 
    FROM Orders
    WHERE EmployeeID = @Empleado

    WHILE @Fecha IS NOT NULL
    BEGIN
        SELECT @Folios = STRING_AGG(CONVERT(VARCHAR(10), o.OrderID), ', ')
        FROM Orders o
        INNER JOIN Employees e ON o.EmployeeID = e.EmployeeID
        WHERE e.EmployeeID = @Empleado
        AND o.OrderDate = @Fecha

        INSERT INTO @Salida VALUES (@Fecha, @Folios)

        SELECT @Fecha = MIN(OrderDate) 
        FROM Orders
        WHERE EmployeeID = @Empleado
        AND OrderDate > @Fecha
    END

    RETURN
END
GO

SELECT * FROM dbo.fn_5(1)
