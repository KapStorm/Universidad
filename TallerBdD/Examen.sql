USE Examen
GO
-- Familia de vistas
CREATE VIEW vw_articulos AS
SELECT 
a.ArtId, ArtNombre = a.Nombre,
f.FamId, FamNombre = f.Nombre
FROM Articulos a
INNER JOIN Familias f ON a.FamId = f.FamId
GO

CREATE VIEW vw_detalle AS
SELECT 
d.Folio, d.ArtId, d.Cantidad, d.Precio,
a.ArtNombre, a.FamId, a.FamNombre,
e.Fecha, e.Domicilio
FROM Detalle d
INNER JOIN vw_articulos a ON d.ArtId = a.ArtId
INNER JOIN Envios e ON d.Folio = e.Folio
GO

SELECT ArtNombre, FamNombre
FROM vw_articulos

SELECT FamNombre, CantidadArticulos = COUNT(*)
FROM vw_articulos
GROUP BY FamNombre

SELECT FamNombre, CantidadArticulos = COUNT(DISTINCT ArtId)
from vw_detalle
GROUP BY FamNombre

SELECT Folio, SUM(Cantidad * Precio)
FROM vw_detalle
GROUP BY Folio
HAVING SUM(Cantidad * Precio) > 100000

-- Consulta con el nombre del articulo, total de piezas enviadas
SELECT ArtNombre, SUM(Cantidad)
FROM vw_detalle
GROUP BY ArtNombre

-- Consulta con el año, total de piezas enviadas y peso total enviado
SELECT YEAR(Fecha), SUM(Cantidad), SUM(Cantidad * Precio)
FROM vw_detalle
GROUP BY YEAR(Fecha)

SELECT *
FROM vw_detalle