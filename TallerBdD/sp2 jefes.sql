USE Northwind
GO

CREATE PROC sp_jefesuperior
@Emp INT, @JefesSup INT OUTPUT, @Nivel INT OUTPUT AS
    DECLARE @Aux INT
    
    SELECT @Nivel = 0
    SELECT @JefesSup = ReportsTo 
        FROM Employees
        WHERE EmployeeID = @Emp
    
    WHILE @JefesSup IS NOT NULL
    BEGIN
        SELECT @Aux = @JefesSup
        SELECT @Nivel = @Nivel + 1

        SELECT @JefesSup = ReportsTo
            FROM Employees
            WHERE EmployeeID = @JefesSup
    END
    
    SELECT @JefesSup = @Aux
GO

-- Ejecucion
DECLARE @A INT, @B INT
EXEC sp_jefesuperior 3, @A OUTPUT, @B OUTPUT
SELECT SUP = @A, Nivel = @B
