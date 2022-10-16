-- SP que reciba la fecha de nacimiento y regrese por parametro de salida la edad exacta
CREATE PROC sp_edad @Fecha DATETIME, @Edad INT OUTPUT AS
SELECT @Edad = DATEDIFF(YY, @Fecha, GETDATE())
SELECT @Fecha = DATEADD(YY, @Edad, @Fecha)
IF @Fecha > GETDATE()
    SELECT @Edad = @Edad - 1
GO

-- Ejecucion
DECLARE @R INT
EXEC sp_edad '10-11-2000', @R OUTPUT
SELECT @R


GO
CREATE PROC sp_edad_todos AS
DECLARE @Emp INT, @EdadExacta INT, @FechaNac DATETIME
CREATE TABLE #Aux (Emp INT, EdadExacta INT)
SELECT @Emp = MIN(EmployeeId) FROM Employees
WHILE @Emp IS NOT NULL
    BEGIN
        SELECT @FechaNac = BirthDate FROM Employees WHERE EmployeeID = @Emp
        EXEC sp_edad @FechaNac, @EdadExacta OUTPUT
        INSERT INTO #Aux VALUES(@Emp, @EdadExacta)
        SELECT @Emp = MIN(EmployeeId) FROM Employees WHERE EmployeeID > @Emp
    END
SELECT Nombre = e.FirstName + '' + e.LastName, e.BirthDate, EdadExacta = a.EdadExacta
FROM #Aux a
INNER JOIN Employees e ON E.EmployeeID = a.Emp
GO

-- Ejecucion
EXEC sp_edad_todos