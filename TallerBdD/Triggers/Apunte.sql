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
GO

-- Proc alm que llegue a crear un trigger que no permita eliminar
-- registros en todas las tablas
CREATE PROC sp_crea_trigger_delete AS
BEGIN
    DECLARE @Min INT, @Nom VARCHAR(50)

    SELECT @Min = MIN(Id)
    FROM SYSOBJECTS
    WHERE xType = 'U' AND Name NOT LIKE 'SYS%'

    WHILE @Min IS NOT NULL
    BEGIN
        SELECT @Nom = Name 
        FROM SYSOBJECTS
        WHERE Id = @Min

        PRINT 'CREATE TRIGGER TR_' + REPLACE(@Nom, ' ', '') + '_DELETE'
        PRINT 'ON [' + @Nom + '] FOR DELETE AS'
        PRINT 'ROLLBACK TRAN'
        PRINT 'RAISE ERROR(' + CHAR(39) + 'Por el momento no se puede eliminar registros' + CHAR(39) + ', 16, 1)'
        PRINT 'GO'

        -- EXEC(@Texto)
        SELECT @Min = MIN(Id)
        FROM SYSOBJECTS
        WHERE xType = 'U' AND Name NOT LIKE 'SYS%' AND Id > @Min
    END
END
GO

-- Validar que el nombre de los materiales no se actualice
CREATE TRIGGER tr_materiales_ins
ON Materiales FOR UPDATE AS
BEGIN
    IF UPDATE(Nombre)
    BEGIN
        ROLLBACK TRAN
        RAISERROR('No se puede actualizar el nombre del material', 16, 1)
    END
END
GO

-- No se actualiza el nombre
UPDATE Materiales SET Nombre = 'Queso Cab' WHERE Clave = 46
UPDATE Materiales SET Nombre = 'Queso Cab', Precio = 200 WHERE Clave = 46

-- Si se actualiza el precio
UPDATE Materiales SET Precio = 200 WHERE Clave = 46

-- Para que solo se modifique una sola vez el nombre de los materiales
ALTER TABLE Materiales ADD Contador INT
UPDATE Materiales SET Contador = 0
ALTER TABLE Materiales ADD CONSTRAINT df_mat_contadr DEFAULT(0) FOR Contador
GO

CREATE TRIGGER tr_materiales_conta
ON Materiales FOR UPDATE AS
BEGIN
    DECLARE @Clave INT, @Conta INT

    SELECT @Clave = Clave, @Conta = ISNULL(Contador, 0) 
    FROM Inserted

    IF UPDATE(Nombre)
    BEGIN
        IF @Conta > 0
        BEGIN
            ROLLBACK TRAN
            RAISERROR('No se puede actualizar mas de una vez el nombre', 16, 1)
        END
        ELSE
        BEGIN
            UPDATE Materiales SET Contador = @Conta + 1 
            WHERE Clave = @Clave
        END
    END
END
GO
