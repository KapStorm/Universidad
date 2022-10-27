-- Validar que realmente se ejecuta un ROLlbACk TRAn (deshacer una transaccion)
-- es peligroso una actualización masiva
UPDATE Materiales SET Precio = 20
GO

-- No permitir actualizaciones masivas en la tabla materiales
CREATE TRIGGER tr_mat_upd
ON Materiales FOR UPDATE AS
BEGIN
    DECLARE @Conta INT
    SELECT @Conta = COUNT(*)
    FROM Inserted

    IF @Conta > 1
    BEGIN
        ROLLBACK TRAN
        RAISERROR('No se permiten actualizaciones masivas', 16, 1)
    END
END
GO

-- No es permitido
UPDATE Materiales SET Precio = 1000

-- Es permitido
UPDATE Materiales SET Precio = 555 WHERE Clave = 30
GO

-- No permitir que se eliminen registros en la tabla materiales
CREATE TRIGGER tr_mat_del
ON Materiales FOR DELETE AS
BEGIN
    ROLLBACK TRAN
    RAISERROR('Por el momento no se puede eliminar registos', 16, 1)
END
GO

-- Ejecucion
DELETE Materiales WHERE Clave = 45