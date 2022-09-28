CREATE VIEW vw_productos AS
SELECT ProductId, ProductName, UnitPrice
FROM Products;

SELECT *
FROM vw_productos;

SELECT *
FROM vw_productos p
INNER JOIN [Order Details] D ON D.ProductId = P.ProductId;

UPDATE vw_productos
SET UnitPrice = UnitPrice + 1
WHERE ProductId = 1;

SELECT ProductName, UnitPrice
FROM Products WHERE ProductId = 1;

DROP VIEW vw_productos;

CREATE VIEW vw_productos WITH ENCRYPTION AS
SELECT ProductId, UnitPrice, COSTO = UnitPrice * 0.2
FROM Products;

-- RESTRICCIONES DE VISTAS
-- 1.- Debe especificar en una vista los nombres de todas las columnas derivadas,
-- además los nombres de las columnas no se deben de repetir
CREATE VIEW vw_productoprecio AS
SELECT ProductName, Precio = UnitPrice * 1.4
FROM Products;

-- 2.- Las instrucciones CREATE VIEW no pueden combinarse con ninguna otra
-- instrucción SQL en un lote. Un lote es un conjunto de instrucciones
-- separadas por la palabra GO
CREATE VIEW vw_productos2 AS
SELECT *
FROM Products
GO
CREATE VIEW vw_productos3 AS
SELECT * 
FROM Products
GO

-- 3.- Todos los objetos de BD a los que se haga referencia en la vista,
-- se verifican al momento de crearla

-- marca error, el campo gastos no existe en la tabla productos
CREATE VIEW vw_productos4 AS
SELECT Gastos 
FROM Products
GO

-- 4.- No se puede incluir las clausulas ORDER BY en la instrucción SELECT
-- dentro de una vista
CREATE VIEW vw_productos6 AS
SELECT *
FROM Products
ORDER BY ProductName;

-- se ordena hasta que se ejecuta la vista
SELECT * 
FROM vw_productos6
ORDER BY ProductName;

-- 5.- Si se eliminan objetos a los que se hace referencia dentro de una vista,
-- la vista permanecem la sogioemte vez que intente utilizar esa vista recibirá
-- un mensaje de error
CREATE VIEW vw_productos7 AS
SELECT *
FROM vw_productos6
GO
DROP VIEW vw_productos6

-- La vista 7 ya no se ejecuta, la vista 6 fue eliminada previamente
SELECT *
FROM vw_productos7
ORDER BY ProductIds

-- SELECT INTO, COPIA LA ESTRUCTURA DE UNA TABLA Y LA LLENA DE DATOS
SELECT *
INTO CopiaProd
FROM Products
GO
SELECT *
FROM CopiaProd

DROP TABLE CopiaProd
GO
-- MARCA ERROR
CREATE VIEW vw_productos5 AS
SELECT *
INTO Tabla4
FROM Product
GO

-- 7.- Si la vistaemplea el asterisco * en la isntruccion SELECT y
-- la tabla base a la que hace referencia sele agregan nuevas columnas,
-- estas no se mostrarán en la ista.
CREATE TABLE Tabla1(col1 INT, col2 INT)
GO
CREATE VIEW vw_tablaA AS
SELECT *
FROM Tabla1
GO
ALTER TABLE Tabla1 ADD
col3 INT
GO
SELECT *
FROM vw_tablaA
GO
-- Es necesario utilizar el comando alter view para actualizar los cmapos en la vista
ALTER VIEW vw_tablaA AS
SELECT *
FROM Tabla1
GO  
-- Al eliminar una columna de tabla1, la vista marcará error al ejecutarse
ALTER TABLE Tabla1
DROP COLUMN col1
-- Marca error
SELECT * 
FROM vw_tablaA
-- Se corrige ejecutando alter view

-- 8.- Si creau na vista hija con base en una padre, debe tomarpresente lo
-- que esta haicendo la vita padre

-- 9,- Los datos de la vistas no se almacenan por separado, si cambia un dato en
-- una vista, está modificando el dato en al tabla base.
CREATE VIEW vw_products AS
SELECT *
FROM Product
GO
UPDATE vw_products 
SET UnitPrice=UnitPrice + 10
WHERE ProductId = 1

SELECT *
FROM Products 
WHERE ProductId=1

-- 10.- En una vista no puede hacer referencia a mas de 1024 columnas

-- 11.- En una vista no puede crear indices, ni desencadenados (triggers)