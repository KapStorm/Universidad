USE Northwind
GO

GO

CREATE OR ALTER PROC sp_temp AS
BEGIN
    DECLARE @TablaId INT, @TablaNombre VARCHAR(50), @Query VARCHAR(2000) = ''

    SELECT @TablaId = MIN(id) 
    FROM SYSOBJECTS 
    WHERE name NOT LIKE 'sys%' 
    AND XTYPE LIKE 'U'

    WHILE @TablaId IS NOT NULL
    BEGIN
        DECLARE @ColumnaId INT

        SELECT @TablaNombre = name
        FROM SYSOBJECTS 
        WHERE id = @TablaId

        SELECT @Query = 'ALTER TABLE [' + @TablaNombre + '] ADD Bandera VARCHAR(2000)'
        EXEC(@Query)
        SELECT @Query = 'UPDATE [' + @TablaNombre + '] SET Bandera = ' + CHAR(39) + CHAR(39)
        EXEC(@Query)

        SELECT @ColumnaId = MIN(colid)
        FROM SYSCOLUMNS 
        WHERE id = @TablaId

        WHILE @ColumnaId IS NOT NULL
        BEGIN
            DECLARE @NombreColumna VARCHAR(50)

            SELECT @NombreColumna = name
            FROM SYSCOLUMNS
            WHERE colid = @ColumnaId
            AND id = @TablaId

            -- PRINT 'CREATE TRIGGER TR_' + @TablaNombre + '_' + @NombreColumna + '_UPDATE'
            -- PRINT 'ON [' + @TablaNombre + '] FOR UPDATE AS'
            -- PRINT 'IF UPDATE(' + @NombreColumna + ')'
            -- PRINT 'BEGIN'
            -- PRINT 'DECLARE @Temp VARCHAR(2000)'
            -- PRINT 'SELECT @Temp = Bandera FROM INSERTED'
            -- PRINT 'IF @Temp LIKE ' + CHAR(39) + '%' + @NombreColumna + '%' + CHAR(39)
            -- PRINT 'BEGIN'
            -- PRINT 'ROLLBACK TRAN'
            -- PRINT 'RAISE ERROR (' + CHAR(39) + 'NO SE PUEDE' + CHAR(39) + ')'
            -- PRINT 'END'
            -- PRINT 'ELSE'
            -- PRINT 'BEGIN'
            -- PRINT 'UPDATE ' + @TablaNombre + ' SET Bandera=@Temp+' + CHAR(39) + @NombreColumna + CHAR(39)
            -- PRINT 'END'
            -- PRINT 'END'

            SELECT @Query = 'CREATE TRIGGER TR_' + REPLACE(@TablaNombre, ' ', '') + '_' + @NombreColumna + '_UPDATE ON [' + @TablaNombre + '] FOR UPDATE AS IF UPDATE(' + @NombreColumna + ') BEGIN ' + 'DECLARE @Temp VARCHAR(2000) SELECT @Temp = Bandera FROM INSERTED IF @Temp LIKE ' + CHAR(39) + '%' + @NombreColumna + '%' + CHAR(39) + ' BEGIN ROLLBACK TRAN RAISERROR(' + CHAR(39) + 'NO SE PUEDE' + CHAR(39) + ', 16, 1) END ELSE BEGIN UPDATE [' + @TablaNombre + '] SET Bandera=' + CHAR(39) + @NombreColumna + CHAR(39) + ' END END'

            EXEC(@Query)

            SELECT @ColumnaId = MIN(colid)
            FROM SYSCOLUMNS 
            WHERE id = @TablaId
            AND colid > @ColumnaId
        END

        SELECT @TablaId = MIN(id) 
        FROM SYSOBJECTS 
        WHERE name NOT LIKE 'sys%' 
        AND XTYPE LIKE 'U'
        AND @TablaId < id
    END
END
GO

EXEC sp_temp

SELECT * FROM SYSOBJECTS WHERE name LIKE 'TR_Ord%' AND XTYPE LIKE 'TR'

SELECT * FROM [Order Details]

SELECT REPLACE(name, ' ', '') FROM SYSOBJECTS WHERE name NOT LIKE 'sys%' AND XTYPE LIKE 'U'

SELECT * FROM SYSCOLUMNS WHERE id = 885578193


UPDATE Employees SET PhotoPath = 'a' 
SELECT * FROM Employees

ALTER TABLE Employees DROP COLUMN