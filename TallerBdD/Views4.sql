-- Consulta con el año, total de piezas enviadas y peso total enviado
SELECT YEAR(Fecha), SUM(Cantidad), SUM(Cantidad * Peso)
FROM vw_Detalle
GROUP BY YEAR(Fecha)

-- Consulta con el mes y el total de piezas vendidas
SELECT DATENAME(MM, Fecha), SUM(Cantidad)
FROM vw_detalle
GROUP BY DATENAME(MM, Fecha), DATEPART(MM, Fecha)
ORDER BY DATEPART(MM, Fecha)
GO

CREATE VIEW vw_meses AS
SELECT Clave = 1, Nombre = 'Enero'
UNION
SELECT 2, 'Febrero'
UNION
SELECT 3, 'Marzo'
UNION
SELECT 4, 'Abril'
UNION
SELECT 5, 'Mayo'
UNION
SELECT 6, 'Junio'
UNION
SELECT 7, 'Julio'
UNION
SELECT 8, 'Agosto'
UNION
SELECT 9, 'Septiembre'
UNION
SELECT 10, 'Octubre'
UNION
SELECT 11, 'Noviembre'
UNION
SELECT 12, 'Diciembre'
GO

SELECT m.Nombre, Cantidad = ISNULL(SUM(d.Cantidad), 0)
FROM vw_detalle d
RIGHT OUTER JOIN vw_meses m ON m.Clave = DATEPART(MM, d.Fecha)
GROUP BY m.Clave, m.Nombre
ORDER BY m.Clave ASC