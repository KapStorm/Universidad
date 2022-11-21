USE Northwind
GO

-- 1.- Utilizando trigger, validar que solo se vendan ordenes de lunes a viernes.
CREATE OR ALTER TRIGGER tr_uno 
ON Orders FOR INSERT AS
BEGIN
    DECLARE @DiaSemana INT

    SELECT @DiaSemana = DATEPART(DW, OrderDate) 
    FROM inserted

    IF @DiaSemana IN (1, 7)
    BEGIN
        ROLLBACK
        RAISERROR('No se admiten pedidos en fin de semana', 16, 1)
    END
END
GO

-- 2.- Validar que no se vendan mas de 20 ordenes por empleado en una semana.
CREATE OR ALTER TRIGGER tr_dos
ON Orders FOR INSERT AS
BEGIN
    DECLARE @Empleado INT, @Cantidad INT, @Semana INT, @Anio INT

    SELECT @Empleado = EmployeeId
    FROM Employees

    SELECT @Semana = DATEPART(WW, GETDATE()),
    @Anio = YEAR(GETDATE())

    SELECT @Cantidad = COUNT(*)
    FROM Orders
    WHERE EmployeeID = @Empleado
    AND DATEPART(WW, OrderDate) = @Semana
    AND YEAR(OrderDate) = @Anio

    IF @Cantidad > 20
    BEGIN
        ROLLBACK
        RAISERROR('No se admiten mas de 20 ventas en la semana', 16, 1)
    END
END
GO

-- 3.- Validar que el campo firstname en la tabla employees solamente tenga nombres que inicien con vocal.
CREATE OR ALTER TRIGGER tr_tres
ON Employees FOR INSERT, UPDATE AS
BEGIN
    DECLARE @FirstName NVARCHAR(10)

    SELECT @FirstName = FirstName
    FROM inserted

    IF @FirstName NOT LIKE '[aeiou]%'
    BEGIN
        ROLLBACK
        RAISERROR('No se admiten nombres que no empiecen con vocal', 16, 1)
    END
END
GO

-- 4.- validar que el importe de venta de cada orden no sea mayor a $10,000.
CREATE OR ALTER TRIGGER tr_cuato
ON [Order Details] FOR INSERT AS
BEGIN
    DECLARE @ImporteTotal REAL

    SELECT @ImporteTotal = Discount 
    FROM inserted

    IF @ImporteTotal > 10000
    BEGIN
        ROLLBACK
        RAISERROR('No se admiten totales menores a 10000', 16, 1)
    END
END
GO

-- 5.- validar que no se puedan eliminar ordenes que se hicieron los lunes.
CREATE OR ALTER TRIGGER tr_cinco
ON Orders FOR DELETE AS
BEGIN
    DECLARE @DiaSemana INT

    SELECT @DiaSemana = DATEPART(DW, OrderDate)
    FROM inserted

    IF @DiaSemana = 2
    BEGIN
        ROLLBACK
        RAISERROR('No se puede eliminar ordenes que sean del lunes', 16, 1)
    END
END
GO

-- 6.- Validar que no se realicen inserciones masivas en la tabla products.
CREATE OR ALTER TRIGGER tr_seis
ON Products FOR INSERT AS
BEGIN
    DECLARE @Cantidad INT

    SELECT @Cantidad = COUNT(*)
    FROM inserted

    IF @Cantidad > 1
    BEGIN
        ROLLBACK
        RAISERROR('No se admiten inserciones masivas', 16, 1)
    END 
END
GO

-- 7.- Validar que no se pueda modificar el campo unitprice de la tabla [order details].
CREATE OR ALTER TRIGGER tr_siete
ON [Order Details] FOR UPDATE AS
BEGIN
    IF UPDATE(UnitPrice)
    BEGIN
        ROLLBACK
        RAISERROR('No se puede modificar el precio', 16, 1)
    END
END
GO

-- 8.- Validar que solo se pueda actualizar una sola vez el nombre del cliente.
ALTER TABLE Customers ADD Contador INT
UPDATE Customers SET Contador = 0
GO

CREATE OR ALTER TRIGGER tr_ocho
ON Customers FOR UPDATE AS
BEGIN
    IF UPDATE(ContactName)
    BEGIN
        DECLARE @Contador INT, @Id NCHAR(5)

        SELECT @Contador = Contador
        FROM inserted

        IF @Contador = 1
        BEGIN
            ROLLBACK
            RAISERROR('No se puede modificar el nombre más de una vez', 16, 1)
        END
        ELSE
        BEGIN
            UPDATE Customers SET Contador = 1 WHERE CustomerID = @Id
        END
    END
END
GO

-- 9.- Validar que no se puedan eliminar categorías que tengan una clave impar.
CREATE OR ALTER TRIGGER tr_nueve
ON Categories FOR DELETE AS
BEGIN
    DECLARE @Clave INT

    SELECT @Clave = CategoryID 
    FROM Categories

    IF @Clave % 2 = 1
    BEGIN
        ROLLBACK
        RAISERROR('No se puede eliminar categorias con clave impar', 16, 1)
    END
END
GO

-- 10.- Validar que no se puedan insertar ordenes que se realicen en domingo.
CREATE OR ALTER TRIGGER tr_diez
ON Orders FOR INSERT AS
BEGIN
    DECLARE @DiaSemana INT

    SELECT @DiaSemana = DATEPART(DW, OrderDate)
    FROM inserted

    IF @DiaSemana = 1
    BEGIN
        ROLLBACK
        RAISERROR('No se admiten ordenes de los dias domingos', 16, 1)
    END
END
GO
