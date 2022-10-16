create database PEDIDOS
go
use PEDIDOS
go
-- Creacion de tablas
create table paises
(
    paisid int not null,
    nombre nvarchar(30) not null
)
go
create table estados
(
    paisid int not null,
    edoid int not null,
    nombre nvarchar(30) not null,
    area nvarchar(30) null
)
go
create table clientes
(
    clid int not null,
    nombre nvarchar(30) not null,
    apellidos nvarchar(30) not null,
    domicilio nvarchar(60) null,
    rfc nchar(13) null,
    paisid int not null,
    edoid int not null
)
go
create table pedidos
(
    folio int not null,
    fecha date not null,
    clid int not null,
    empid int not null,
    importe numeric(10,2) not null
)
go
create table empleados
(
    empid int not null,
    nombre nvarchar(30) not null,
    apellidos nvarchar(30) not null,
    celular nchar(10) null,
    jefeid int null
)
go
--Definicion de primary keys
alter table paises add constraint pk_paises primary key (paisid)
alter table estados add constraint pk_estados primary key (edoid,paisid)
alter table clientes add constraint pk_clientes primary key (clid)
alter table pedidos add constraint pk_pedidos primary key (folio)
alter table empleados add constraint pk_empleados primary key (empid)
go
--Definicion de foreign keys
alter table estados add 
constraint fk_estados_paises foreign key (paisid) references paises (paisid)

alter table clientes add constraint fk_clientes_estados foreign key (edoid,paisid) references estados (edoid,paisid)

alter table pedidos add 
constraint fk_pedidos_clientes foreign key (clid) references clientes (clid),
constraint fk_pedidos_empleados foreign key (empid) references empleados (empid)

alter table empleados add constraint fk_empledos_jefe foreign key (jefeid) references empleados (empid)
go
--Definicion de unique key
alter table clientes add constraint uc_clientes_rfc unique (rfc)
go
--Definicion default
alter table estados add constraint cd_estados_area default ('Sin area') for area
go
alter table clientes add
constraint cd_clientes_dom default ('Sin domicilio') for domicilio,
constraint cd_clientes_rfc default ('Sin rfc') for rfc
go
alter table empleados add constraint cd_empleados_cel default ('No celular') for celular
go
--Definicion Check
alter table pedidos add 
constraint cc_pedidos_fecha check (fecha>'01-01-1980'),
constraint cc_pedidos_importe check (importe>0)
go
--Insercion de datos
insert into paises
values
    (001, 'Mexico'),
    (002, 'Argentina'),
    (003, 'Uruguay'),
    (004, 'Peru'),
    (005, 'Guatemala')
go
insert into estados
values
    (001, 005, 'Sinaloa', 'Norte'),
    (001, 006, 'Sonora', 'Sur'),
    (001, 007, 'Jalisco', default),
    (003, 025, 'Canelones', 'Centro'),
    (004, 002, 'La libertad', 'Norte')
go
insert into clientes
values
    (001, 'Jose', 'Perez', default, 'JOP1020203654', 001, 006),
    ( 002, 'Luis Felipe', 'Hernandez Lopez', 'calle benito juarez,#300', 'LUFH597824510', 001, 005),
    ( 003, 'Jose', 'Garcia', 'calle iztapalapa,#1521', 'JOG1452637485', 001, 007),
    ( 004, 'Daniel', 'Castro', 'calle jose portillo,SN', 'DAC7485612543', 003, 025),
    ( 005, 'Alejandro', 'Lopez Valenzuela', 'calle miguel amador,#1541', default, 004, 002)
go
insert into empleados
values
    (001, 'Jose', 'Lopez', '6672241524', NULL),
    (002, 'Miguel', 'Calderon', '6678854512', 001),
    (003, 'Elias', 'Fernandez', '6631121415', 001),
    (004, 'Humberto', 'Felix', '6645000000', 002),
    (005, 'Bryan', 'Felix', '6678521200', 002)
go
insert into pedidos
values
    (001, '01-01-2002', 001, 001, 600.00),
    (002, '05-01-2002', 002, 002, 600.00),
    (003, '10-03-2003', 003, 003, 1500.50),
    (004, '12-04-2020', 004, 004, 1740.25),
    (005, '06-05-2020', 005, 005, 300.10)
go
--FAMILIA DE VISTAS
CREATE VIEW VW_ESTADOS
AS
    SELECT e.paisid, e.edoid, e.nombre AS nombreEstado, e.area, p.nombre AS nombrePais
    FROM estados e
        INNER JOIN paises p ON p.paisid = e.paisid
GO








CREATE VIEW VW_CLIENTES
AS
    SELECT c.clid, c.nombre AS clienteNombre, c.apellidos AS clienteApellidos, c.domicilio, c.rfc, e.*
    FROM clientes c
        INNER JOIN VW_ESTADOS e ON e.edoid = c.edoid
GO






CREATE VIEW VW_PEDIDOS
AS
    SELECT p.folio, p.fecha, e.empid, e.nombre AS empleadoNombre, e.apellidos AS empleadoApellidos, e.celular, e.jefeid, c.*, p.importe
    FROM pedidos p
        INNER JOIN VW_CLIENTES c ON c.clid = p.clid
        INNER JOIN empleados e ON e.empid = p.empid













GO
--CONSULTAS
--CONSULTA 1
SELECT nombrePais, COUNT(*) AS cantEstados
FROM VW_ESTADOS
GROUP BY nombrePais
GO
--CONSULTA 2
SELECT nombreEstado, COUNT(edoid) AS cantPedidos
FROM VW_PEDIDOS
GROUP BY nombreEstado
GO
--CONSULTA 3
SELECT YEAR(fecha) AS AÑO, COUNT(*) AS totalPedidos, SUM(importe) AS importeTotal
FROM VW_PEDIDOS
GROUP BY YEAR(fecha) 
GO
--CONSULTA 4
CREATE VIEW VW_MESES
AS
                                                    SELECT clave = 1, nombreMes = 'Enero'
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
SELECT m.nombreMes, ISNULL(COUNT(p.folio),0) AS pedidosRealizados
FROM VW_PEDIDOS p
    RIGHT OUTER JOIN VW_MESES m ON m.clave = DATEPART(mm,p.fecha)
GROUP BY m.clave, m.nombreMes
ORDER BY m.clave ASC
GO
--CONSULTA 5
SELECT nombreEmpleado = (empleadoNombre + ' ' + empleadoApellidos), COUNT(folio) AS totalPedidos, SUM(importe) importeTotal
FROM VW_PEDIDOS
GROUP BY empleadoNombre, empleadoApellidos
GO
--CONSULTA 6
SELECT nombreCliente = (clienteNombre + ' ' + clienteApellidos), COUNT(folio) AS totalPedidos, SUM(importe) importeTotal
FROM VW_PEDIDOS p
GROUP BY clienteNombre, clienteApellidos
GO
--CONSULTA 7
SELECT nombreEstado AS ESTADOS,
    ENE = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 1) THEN 1 ELSE 0 END),
    FEB = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 2) THEN 1 ELSE 0 END),
    MAR = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 3) THEN 1 ELSE 0 END),
    ABR = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 4) THEN 1 ELSE 0 END),
    MAY = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 5) THEN 1 ELSE 0 END),
    JUN = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 6) THEN 1 ELSE 0 END),
    JUL = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 7) THEN 1 ELSE 0 END),
    AGO = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 8) THEN 1 ELSE 0 END),
    SEP = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 9) THEN 1 ELSE 0 END),
    OCT = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 10) THEN 1 ELSE 0 END),
    NOV = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 11) THEN 1 ELSE 0 END),
    DIC = SUM(CASE WHEN (YEAR(fecha) = 2020 AND MONTH(fecha) = 12) THEN 1 ELSE 0 END)
FROM VW_PEDIDOS
GROUP BY nombreEstado
--CONSULTA 8
SET LANGUAGE SPANISH
SELECT YEAR(fecha) AS AÑO,
    DOMINGO = SUM(CASE WHEN (DATENAME(DW,fecha) LIKE 'DOMINGO') THEN 1 ELSE 0 END),
    LUNES = SUM(CASE WHEN (DATENAME(DW,fecha) LIKE 'LUNES') THEN 1 ELSE 0 END),
    MARTES = SUM(CASE WHEN (DATENAME(DW,fecha) LIKE 'MARTES') THEN 1 ELSE 0 END),
    MIERCOLES = SUM(CASE WHEN (DATENAME(DW,fecha) LIKE 'MIÉRCOLES') THEN 1 ELSE 0 END),
    JUEVES = SUM(CASE WHEN (DATENAME(DW,fecha) LIKE 'JUEVES') THEN 1 ELSE 0 END),
    VIERNES = SUM(CASE WHEN (DATENAME(DW,fecha) LIKE 'VIERNES') THEN 1 ELSE 0 END),
    SABADO = SUM(CASE WHEN (DATENAME(DW,fecha) LIKE 'SÁBADO') THEN 1 ELSE 0 END)
FROM VW_PEDIDOS
GROUP BY YEAR(fecha)
--CONSULTA 9
SELECT YEAR(fecha) AS AÑO,
    SINALOA = SUM(CASE WHEN(nombreEstado LIKE 'SINALOA') THEN 1 ELSE 0 END),
    SONORA = SUM(CASE WHEN(nombreEstado LIKE 'SONORA') THEN 1 ELSE 0 END),
    JALISCO = SUM(CASE WHEN(nombreEstado LIKE 'JALISCO') THEN 1 ELSE 0 END)
FROM VW_PEDIDOS
GROUP BY YEAR(fecha)
--CONSULTA 10
SELECT nombrePais, COUNT(nombreEstado) AS cantidadEstados, COUNT(clid) AS cantidadClientes
FROM VW_CLIENTES
GROUP BY nombrePais
--drop database Pedidos