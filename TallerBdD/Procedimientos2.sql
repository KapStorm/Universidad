USE Northwind
GO

-- 2. SIN PARAMETROS
-- Procedimientos que actualice el precio de todos los productos y aumente el 10%
CREATE PROC SP_aumento AS
UPDATE Products SET UnitPrice = UnitPrice * 1.1
GO

-- Ejecución
EXEC SP_aumento

-- Validar el producto 1
SELECT ProductID, UnitPrice
FROM Products
WHERE ProductID = 1

-- 3. SP CON PARAMETROS DE ENTRADA

-- SP QUE RECIBA 4 CALIFICACIONES IMPRIMIR EL PROMEDIO
GO
CREATE PROC SP_Calificaciones
@CAL1 INT, @CAL2 INT, @CAL3 INT, @CAL4 INT AS
DECLARE @PROM NUMERIC(12, 2)

SELECT @PROM = (@CAL1 + @CAL2 + @CAL3 + @CAL4) / 4

SELECT @PROM
GO

-- EJECUCION
EXEC SP_Calificaciones 34, 56, 79, 80

-- Se puede cambiar el orden de los parametros indicando el nombre antes del valor
EXEC SP_Calificaciones @CAL2 = 56, @CAL3 = 79, @CAL4 = 80, @CAL1 = 34

-- 4. CON PARAMETROS DE SALIDA

-- SP QUE RECIBA 4 CALIFICACIONES Y REGRESE COMO PARAMETRO DE SALIDA EL PROMEDIO Y
-- SI FUE APOBADO
GO
CREATE PROC SP_Calificaciones_SAL
@CAL1 INT, @CAL2 INT, @CAL3 INT, @CAL4 INT,
@PROM NUMERIC(12, 3) OUTPUT, @TIPO CHAR(20) OUTPUT AS
SELECT @PROM = (@CAL1 + @CAL2 + @CAL3 + @CAL4) / 4

IF @PROM >= 70
    SELECT @TIPO = 'APROBADO'
ELSE
    SELECT @TIPO = 'REPROBADO'
GO

-- EJECUTARLO
DECLARE @A NUMERIC(12, 3), @B CHAR(20)
SELECT @A, @B
EXEC SP_Calificaciones_SAL 70, 80, 60, 70, @A OUTPUT, @B OUTPUT
SELECT Calificacion = @A, Resultado = @B
GO
-- 5, POR VALOR POR RETORNO

-- VALOR POR RETORNO UTILIZA LA PALABRA RESERVADA RETURN Y
-- REGRESA SOO VALORES ENTEROS
CREATE PROC SP_CalificacionesReturn
@CAL1 INT, @CAL2 INT, @CAL3 INT, @CAL4 INT AS
DECLARE @Prom INT
SELECT @Prom = (@CAL1 + @CAL2 + @CAL3 + @CAL4) / 4
RETURN @Prom
GO

-- Ejecucion
DECLARE @A INT
SELECT @A
EXEC @A = SP_CalificacionesReturn 60, 80, 90, 70
SELECT @A

-- 6. CON VALORES PREDEFINIDOS

-- PROCEDIMIENTO QUE RECIBE PARAMETROS Y TIENEN VALORES PREDEFINIDOS
-- DECLARACION
GO
CREATE PROC sp_recibir_default
@VAL1 INT, @VAL2 INT, @VAL3 INT, @VAL4 INT AS
DECLARE @TOTAL INT
SELECT @TOTAL = @VAL1 + @VAL2 + @VAL3 + @VAL4
SELECT @TOTAL
GO

-- EJECUCION
EXEC sp_recibir_default 2, 4, 5, 6
GO
-- SE PUEDE OMITIR LOS 2 ULTIMOS VALORES

EXEC sp_recibir_default 2, 4
GO

EXEC sp_recibir_default 2, 4, @VAL4 = 6
GO