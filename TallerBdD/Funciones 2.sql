/*
Tipos de funciones definidas por los usuarios
SQL utiliza tres tipos de funciones:
    1. Funciones escalares
    2. Tabla en linea
    3. Funciones de tabla de multisentencias

Los tes tipos de funciones aceptan parámetros de cualquier tipo excepto de rowversion.
Las funciones escalares devuelven un solo valor, tabla en linea y multisentencias devuelven
un tipo de dato tabla

Limitaciones
Las funciones definidas por el usuario tiene algunas restricciones. No todas las sentencias SQL son
válidas dentro de una función

Inválidas:
    - Armar funciones no determinadas como GETDATE()
    - Sentencias de modificacion o actualizacion de tablas o vistas sobre tablas de usuario
      (update, delete, insert)
    - Operaciones CURSOR FETCH que devuelven datos del cliente
    - No se pueden utilizar procedimientos almacenados dentro de una función ni tablas temporales

Válido:
    - Las sentencias de asignación
    - Lassentences de control de flujo while, if
    - Sentencias SELECT y modificacion de variables locales

1.- Funciones Escalares
    Las funciones escalares vuelven un tipo de los datos tal como INT, MONEY, VARCHAR, REAL, etc.
    Pueden ser utilizadas en cualquier lugar incluso incorporada dentro de sentencias SQL

    La sintaxis para una funcion escalar es la siguiente

    CREATE FUNCTION [NombrePropetario.]NombreFuncion
    (@nombreParametro TIPODATO [= default], ...)
    RETURNS TIPODATORETORNO
    AS
    BEGIN
        CuerpoFuncion

        RETURN ValorRetorno
    END  
*/

-- Funcion que calcula el cubo de un numero
CREATE FUNCTION dbo.Cubo(@num NUMERIC(12, 2))
RETURNS NUMERIC(12, 2)
AS
BEGIN
    RETURN @num * @num * @num
END
GO
