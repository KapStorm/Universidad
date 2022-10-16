CREATE VIEW vw_estados AS
SELECT 
EstadoId = e.EdoId, EstadoNombre = e.Nombre, EstadoArea = e.Area,
PaisId = p.PaisId, PaisNombre = p.Nombre
FROM Estados e
INNER JOIN Paises p ON e.PaisId = p.PaisId
GO

CREATE VIEW vw_clientes AS
SELECT
ClienteId = c.CliId, ClienteNombre = c.Nombre, ClienteApellidos = c.Apellidos, ClienteDomicilio = c.Domcilio, ClienteRFC = c.rfc,
e.*
FROM Clientes c
INNER JOIN vw_estados e ON c.PaisId = e.PaisId
GO

CREATE VIEW vw_rentas AS
SELECT 
RentasFolio = r.Folio, RentasFecha = r.Fecha, RentasImporte = r.Importe,
SucursalId = s.SucId, SucursalNombre = s.Nombre,
RadioId = ra.RadId, RadioNombre = ra.Nombre, RadioPrecioRenta = ra.PrecioRenta,
e.*
FROM Rentas r
INNER JOIN Sucursales s ON r.SucId = s.SucId
INNER JOIN Radios ra ON r.RadId = ra.RadId
INNER JOIN vw_estados e ON r.CliId = e.ClienteId 
GO



-- 2.- NOMBRE DEL PAIS, TOTAL DE ESTADOS QUE CONTIENE Y AREA TOTAL DEL PAIS
SELECT PaisId, TotalDeEstados = COUNT(*), AreaTotal = SUM(EstadoArea)
FROM vw_rentas
GROUP BY PaisId



-- 3.- NOMBRE DEL ESTADO Y TOTAL DE CLIENTES QUE CONTIENEN
SELECT EstadoNombre, TotalDeClientes = COUNT(*)
FROM vw_rentas
GROUP BY EstadoNombre



-- 4.- NOMBRE DE LA SUCURSAL, TOTAL DE RENTAS REALIZADOS EI MPORTE TOTAL DE RENTAS
SELECT SucursalNombre, TotalDeRentas = COUNT(*), ImporteTotal = SUM(RentasImporte)
FROM vw_rentas
GROUP BY SucursalNombre



-- 5.- NOMBRE DEL CLIENTE, TOTAL DE RENTAS REALIZADOS E IMPORTE TOTAL DE LA RENTA
-- MOSTRAR SOLO LOS CLIENTES QUE SU NOMBRE TENGAN 20 LETRAS Y QUE EL IMPORTE
-- TOTAL DE LAR ENTA SEA MAYOR A 1000 PESOS
SELECT ClienteNombre, TotalDeRentas = COUNT(*), ImporteTotal = SUM(RentasImporte)
FROM vw_rentas
WHERE LEN(ClienteNombre) > 20
GROUP BY ClienteNombre
HAVING SUM(RentasImporte) > 1000



-- 6. CONSULTA CON EL AÑO E IMPORTE TOTAL DE LA RENTA, MOSTRAR SOLO EL PRIMER SEMESTRE 
-- DE LOS AÑOS Y QUE EL IMPORTE SEA MAYOR A 500 PESOS
SELECT 
YEAR(RentasFecha),
ImportePrimerSemestre = SUM(CASE WHEN MONTH(RentasFecha) IN (1, 2, 3, 4, 5, 6) THEN 1 ELSE 0 END)
FROM vw_rentas
GROUP BY YEAR(RentasFecha)
HAVING SUM(CASE WHEN MONTH(RentasFecha) IN (1, 2, 3, 4, 5, 6) THEN 1 ELSE 0 END) > 500



-- 7. CONSULTA CON EL DIA DE LA SEMANA EL TOTAL DE RENTAS REALIZADAS EN EL 2020, TOTAL DE
-- RENTAS REALIZADAS EN 2021 Y TOTAL DE RENTAS REALIZADAS EN 2022
SELECT 
YEAR(RentasFecha),
LUN = SUM(CASE WHEN DATEPART(DW, RentasFecha) = 2 THEN 1 ELSE 0 END),
MAR = SUM(CASE WHEN DATEPART(DW, RentasFecha) = 3 THEN 1 ELSE 0 END),
MIE = SUM(CASE WHEN DATEPART(DW, RentasFecha) = 4 THEN 1 ELSE 0 END),
JUE = SUM(CASE WHEN DATEPART(DW, RentasFecha) = 5 THEN 1 ELSE 0 END),
VIE = SUM(CASE WHEN DATEPART(DW, RentasFecha) = 6 THEN 1 ELSE 0 END),
SAB = SUM(CASE WHEN DATEPART(DW, RentasFecha) = 7 THEN 1 ELSE 0 END),
DOM = SUM(CASE WHEN DATEPART(DW, RentasFecha) = 1 THEN 1 ELSE 0 END)
FROM vw_rentas
WHERE YEAR(RentasFecha) IN (2020, 2021, 2022)
GROUP BY YEAR(RentasFecha)