/*
* Diccionario de datos
* Es la referencia con la que cuenta el servidor para guardar la estructura de las
* tablas, vistas y sp. Esta información esta contenida en tablas de sistema, las cuales 
* guardan la información de las tablas de usuario
*/

-- Tablas de sistema

-- Tabla SYSOBJECTS
-- Contiene toda la información referente a tablas, vistas, SP, funciones y demáß objetos de la BD.
USE Northwind
GO

SELECT *
FROM Sysobjects
SELECT *
FROM Information_schema.tables
-- xtype:
-- u: tablas,
-- p: sp,
-- v: vistas
-- fn, tf: funciones

-- Tablas de usuario de la base de datos
SELECT id, name, xtype
FROM Sysobjects
WHERE xtype = 'u'
ORDER BY id

-- Funciones utilizadas
-- OBJECT_ID('NOmbre Tabla')
-- Funcion que recibe el nombre de un objeto y regresa el idetificador de dicho objeto
SELECT OBJECT_ID('categories')

-- OBJECT_NAME(Identificador)
-- Funcion que recibe el identificador de un objeto y regresa el nombre de dicho objeto
SELECT OBJECT_NAME(949578421)

-- Tabla SYSCOLUMNS:
-- Contiene el nombre de columnas de tablas y vistas, también el nombre de los parametros de los
-- procedimientos almacenados
SELECT id, colid, name, xtype, length, prec, scale, isnullable
FROM SYSCOLUMNS
WHERE OBJECT_ID('Products') = id

SELECT *
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME LIKE 'Products'

-- TABLA SYSTYPES:
-- Contienes los tipos de datos asociados a columnas de tablas y vistas,
-- tambien incluye los tipos de datos asociados a los parametros de los proc alm.
SELECT xtype, name
FROM SYSTYPES

-- Consulta el nombre de la columnas y tipos de datos
SELECT *
FROM SYSCOLUMNS c
    INNER JOIN SYSTYPES t ON c.xtype = t.xtype
WHERE c.id = OBJECT_ID('Products') AND t.name NOT LIKE 'sysname'
ORDER BY c.colorder
GO

CREATE PROC sp_columnas @Tabla NVARCHAR(100) AS
DECLARE @Texto NVARCHAR(2000), @Alias VARCHAR(2), @Min INT, @Columna VARCHAR(50)

SELECT @Alias = SUBSTRING(@Tabla, 1, 1)
SELECT @Texto = 'Select'

SELECT @Min = MIN(ColId) 
FROM SYSCOLUMNS 
WHERE id = OBJECT_ID(@Tabla)
BEGIN
    SELECT @Columna = name
    FROM SYSCOLUMNS 
    WHERE id = OBJECT_ID(@Tabla) AND @Min = ColId

    SELECT @Texto = @Texto + @Aligas + '.' + @Columna + '.'

    SELECT @Min = MIN(ColId)
    FROM SYSCOLUMNS
    WHERE id = OBJECT_ID(@Tabla) AND ColId > @Min
END

SELECT @Texto = SUBSTRING(@Texto, 1, LEN(@Texto) - 1) -- Quitar la ultima coma
SELECT @Texto = @Texto + 'from' + @Tabla + '' + @Alias
SELECT @Texto
GO
-- Ejecucion
sp_columnas 'Products'