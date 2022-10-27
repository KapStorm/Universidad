CREATE PROC sp_problema1 @Fecha DATETIME, @N INT, @Anios NVARCHAR(200) OUTPUT AS
BEGIN
    DECLARE @Aux DATETIME
    SELECT @Aux = @Fecha
    SELECT @Anios = ''

    WHILE @N > 0
    BEGIN
        IF DATEPART(DW, @Aux) = 1
        BEGIN
            SELECT @N = @N - 1

            SELECT @Anios = @Anios + CONVERT(VARCHAR(10), YEAR(@Aux)) + ', '
        END

        SELECT @Aux = DATEADD(YY, 1, @Aux)
    END

    SELECT @Anios = SUBSTRING(@Anios, 1, LEN(@Anios) - 1) -- Esto quita la ultima coma
END
GO

DECLARE @Anios NVARCHAR(200)
EXEC sp_problema1 '2002-02-23', 4, @Anios OUTPUT
