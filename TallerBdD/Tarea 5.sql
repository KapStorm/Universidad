/*
    Nombre                  Tablas utilizadas
    ----------------------------------------------------
    vw_colonia              Colonias, Municipios
    vw_clientes             Clientes, vw_colonia
    vw_articulos            Articulos, Familias
    vw_empleados            Empleados, Zonas
    vw_jefe                 Empleados, Empleados
    vw_ventas               Ventas, Ferreterias, vw_clientes, vw_empleados
    vw_detalle              Detalle, vw_articulos
    vw_detalle_ventas       vw_detalle, vw_ventas
*/

--     vw_colonia              Colonias, Municipios
CREATE VIEW vw_colonia AS
SELECT 
ColId = c.COLID, ColNombre = c.COLNOMBRE, ColCP = c.COLCP, 

MunId = m.MUNID, MunNombre = m.MUNNOMBRE
FROM COLONIAS c
INNER JOIN MUNICIPIOS m ON c.MUNID = m.MUNID
GO

--    vw_clientes             Clientes, vw_colonia
CREATE VIEW vw_clientes AS
SELECT 
ClenteId = c.CTEID, [Nombre Cliente] = c.CTENOMBRE + ' ' + c.CTEAPEMAT + ' ' + c.CTEAPEPAT, ClienteCelular = c.CTECELULAR, ClienteTelefono = c.CTETELEFONO, ClienteCURP = c.CTECURP, ClienteDomicilio = c.CTEDOMICILIO, ClienteFechaNacimiento = c.CTEFECHANACIMIENTO, ClienteRFC = c.CTERFC, ClienteSexo = c.CTESEXO,

vc.*
FROM CLIENTES c
INNER JOIN vw_colonia vc ON c.COLID = vc.COLID
GO

--     vw_articulos            Articulos, Familias
CREATE VIEW vw_articulos AS
SELECT 
ArtId = a.ARTID, ArtNombre = a.ARTNOMBRE, ArtDescripcion = a.ARTDESCRIPCION, ArtPrecio = a.ARTPRECIO,

FamId = f.FAMID, FamNombre = f.FAMNOMBRE, FamDescripcion = f.FAMDESCRIPTION
FROM ARTICULOS a
INNER JOIN FAMILIAS f ON a.FAMID = f.FAMID
GO

--     vw_empleados            Empleados, Zonas
CREATE VIEW vw_empleados AS
SELECT 
EmpId = e.EMPID, [Nombre Empleado] = e.EMPNOMBRE + ' ' + e.EMPAPEMAT + ' ' + e.EMPAPEPAT, EmpDomicilio = e.EMPDOMICILIO, EmpTelefono = e.EMPTELEFONO, EmpCelular = e.EMPCELULAR, EmpRFC = e.EMPRFC, EmpCURP = e.EMPCURP, EmpFechaIngreso = e.EMPFECHAINGRESO, EmpFechaNacimiento = e.EMPFECHANACIMIENTO, EmpSexo = e.EMPSEXO, EmpJefeId = e.JEFEID,

ZonaId = z.ZONAID, ZonaNombre = z.ZONANOMBRE
FROM EMPLEADOS e
INNER JOIN ZONAS z ON e.ZONAID = z.ZONAID
GO

--     vw_jefe                 Empleados, Empleados
CREATE VIEW vw_jefe AS
SELECT
EmpleadoId = e.EMPID, [Nombre Empleado] = e.EMPNOMBRE + ' ' + e.EMPAPEMAT + ' ' + e.EMPAPEPAT, EmpleadoDomicilio = e.EMPDOMICILIO, EmpleadoTelefono = e.EMPTELEFONO, EmpleadoCelular = e.EMPCELULAR, EmpleadoRFC = e.EMPRFC, EmpleadoCurp = e.EMPCURP, EmpleadoFechaIngreso = e.EMPFECHAINGRESO, EmpleadoFechaNacimiento = e.EMPFECHANACIMIENTO, EmpleadoSexo = e.EMPSEXO,

JefeId = j.EMPID, [Nombre Jefe] = j.EMPNOMBRE + ' ' + j.EMPAPEMAT + ' ' + j.EMPAPEPAT, JefeDomicilio = j.EMPDOMICILIO, JefeTelefono = j.EMPTELEFONO, JefeCelular = j.EMPCELULAR, JefeRFC = j.EMPRFC, JefeCurp = j.EMPCURP, JefeFechaIngreso = j.EMPFECHAINGRESO, JefeFechaNacimiento = j.EMPFECHANACIMIENTO, JefeSexo = j.EMPSEXO
FROM EMPLEADOS e
INNER JOIN EMPLEADOS j ON e.JEFEID = j.EMPID
GO

--     vw_ventas               Ventas, Ferreterias, vw_clientes, vw_empleados
CREATE VIEW vw_ventas AS
SELECT 
VentasFolio = v.FOLIO, VentasFecha= v.FECHA, 

vc.*, 
ve.*, 
f.*
FROM VENTAS v
INNER JOIN vw_clientes vc ON v.CTEID = vc.ClenteId
INNER JOIN vw_empleados ve ON v.EMPID = ve.EMPID
INNER JOIN FERRETERIAS f ON v.FERRID = f.FERRID
GO

--     vw_detalle              Detalle, vw_articulos
CREATE VIEW vw_detalle AS
SELECT 
DetalleFolio = d.FOLIO, DetalleCantidad = d.CANTIDAD, DetallePrecio = d.PRECIO,

va.*
FROM DETALLE d
INNER JOIN vw_articulos va ON d.ARTID = va.ARTID 
GO

--     vw_detalle_ventas       vw_detalle, vw_ventas
CREATE VIEW vw_detalle_ventas AS
SELECT vv.*, vd.*
FROM vw_ventas vv
INNER JOIN vw_detalle vd ON vv.VentasFolio = vd.DetalleFolio
GO
