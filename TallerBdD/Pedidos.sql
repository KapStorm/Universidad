USE master
DROP DATABASE Pedidos
GO

CREATE DATABASE Pedidos
GO
USE Pedidos
GO

CREATE TABLE Paises
(
    PaisId INT NOT NULL,
    Nombre NVARCHAR(40) NOT NULL
)
GO

CREATE TABLE Estados
(
    EdoId INT NOT NULL,
    PaisId INT NOT NULL,
    Nombre NVARCHAR(40) NOT NULL,
    Area NVARCHAR(40) NOT NULL
)
GO

CREATE TABLE Empleados
(
    EmpId INT NOT NULL,
    Nombre NVARCHAR(40) NOT NULL,
    Apellidos NVARCHAR(40) NOT NULL,
    Celular CHAR(10) NOT NULL,
    JefeId INT NULL
)
GO

CREATE TABLE Clientes
(
    CliId INT NOT NULL,
    Nombre NVARCHAR(40) NOT NULL,
    Apellidos NVARCHAR(40) NOT NULL,
    Domicilio NVARCHAR(50) NOT NULL,
    RFC NCHAR(13) NULL,
    PaisId INT NOT NULL,
    EdoId INT NOT NULL
)
GO

CREATE TABLE Pedidos
(
    Folio INT NOT NULL,
    Fecha DATE NOT NULL,
    Importe NUMERIC(6, 2),
    CliId INT NOT NULL,
    EmpId INT NOT NULL,
)
GO

ALTER TABLE Paises ADD
CONSTRAINT pk_pais PRIMARY KEY (PaisId)
GO

ALTER TABLE Estados ADD
CONSTRAINT pk_estados PRIMARY KEY (EdoId, PaisId),
CONSTRAINT fk_estados_paises FOREIGN KEY (PaisId) REFERENCES Paises (PaisId)
GO

ALTER TABLE Empleados ADD
CONSTRAINT pk_empleados PRIMARY KEY (EmpId)
GO

ALTER TABLE Clientes ADD
CONSTRAINT pk_clientes PRIMARY KEY (CliId),
CONSTRAINT fk_clientes_estados FOREIGN KEY (EdoId, PaisId) REFERENCES Estados (EdoId, PaisId)
GO

ALTER TABLE Pedidos ADD
CONSTRAINT pk_pedidos PRIMARY KEY (Folio),
CONSTRAINT fk_pedidos_empleados FOREIGN KEY (EmpId) REFERENCES Empleados (EmpId),
CONSTRAINT fk_pedidos_clientes FOREIGN KEY (CliId) REFERENCES Clientes (CliId)
GO

----
-- Integridad
----
ALTER TABLE Paises ADD
CONSTRAINT cc_pais_nombre_length CHECK(LEN(Nombre) > 2)
GO

ALTER TABLE Estados ADD
CONSTRAINT cc_estados_nombre_length CHECK(LEN(Nombre) > 2),
CONSTRAINT cd_estados_area DEFAULT('Sin area') FOR Area
GO

ALTER TABLE Clientes ADD 
CONSTRAINT cc_clientes_nombre_length CHECK(LEN(Nombre) > 2),
CONSTRAINT cc_clientes_apellidos_length CHECK(LEN(Apellidos) > 2),
CONSTRAINT cd_clientes_domicilio DEFAULT('Sin domicilio') FOR Domicilio,
CONSTRAINT cc_clientes_rfc CHECK(LEN(TRIM(RFC)) = 13)
GO

ALTER TABLE Empleados ADD
CONSTRAINT cc_empleados_nombre_length CHECK(LEN(Nombre) > 2),
CONSTRAINT cc_empleados_apellidos_length CHECK(LEN(Apellidos) > 2),
CONSTRAINT cc_empleados_celular_length CHECK(LEN(Celular) = 10)
GO

----
-- Aqui van los insert
----
INSERT INTO Paises
VALUES
    (1, 'Mexico'),
    (2, 'USA'),
    (3, 'Canada'),
    (4, 'Alemania'),
    (5, 'Rusia')

INSERT INTO Estados
VALUES
    (1, 1, 'Sinaloa', 'Norte'),
    (2, 1, 'Sonora', 'Norte'),
    (3, 1, 'Jalisco', 'Centro'),
    (4, 2, 'Texas', 'Sur'),
    (5, 5, 'Moscu', 'Centro')

INSERT INTO Empleados
VALUES
    (1, 'Sebastian', 'Arellanes', '6673569491', NULL),
    (2, 'Max', 'Rendon', '6673231238', 1),
    (3, 'Bryan', 'Inzunza', '6673421239', 2),
    (4, 'Maria', 'Sanchez', '6679381320', 3),
    (5, 'Syl', 'Stormblessed', '6679380218', 1)

INSERT INTO Clientes
VALUES
    (1, 'Juan', 'Perez', 'Villa Bonita', 'KDI432SDK1PEI', 1, 1),
    (2, 'Ricardo', 'Guerrero', 'Las Quintas', 'RASD324MNC943', 1, 1),
    (3, 'Alan', 'Torres Gerardo', 'Guadalupe Victoria', 'FDOELR342098Q', 1, 3),
    (4, 'Abraham', 'Coppel Guzman', 'Colinas', 'POEI342091ZXC', 2, 4),
    (5, 'Shallan', 'Kholin', 'Urithiru', '938KLJMNCXZ12', 5, 5)

INSERT INTO Pedidos
VALUES
    (1, '2020-01-25', 40.2, 1, 3),
    (2, '2020-04-12', 10.1, 2, 4),
    (3, '2021-09-10', 204.2, 5, 3),
    (4, '2021-09-10', 943.12, 3, 2),
    (5, '2022-10-01', 2.43, 5, 5)
GO

-----
-- Aqui van los views
-----
CREATE VIEW vw_estados AS
SELECT 
EstadoId = e.EdoId, EstadoNombre = e.Nombre, EstadoArea = e.Area, 
PaisId = p.PaisId, PaisNombre = p.Nombre
FROM Estados e
INNER JOIN Paises p ON e.PaisId = p.PaisId
GO

CREATE VIEW vw_clientes AS
SELECT
ClienteId = c.CliId, ClienteNombreCompleto = c.Nombre + ' ' + c.Apellidos, ClienteDomicilio = c.Domicilio, ClienteRFC = c.RFC,
e.*
FROM Clientes c
INNER JOIN vw_estados e ON c.EdoId = e.EstadoId
GO

CREATE VIEW vw_pedidos AS
SELECT 
PedidoFolio = p.Folio, PedidoFecha = p.Fecha, PedidoImporte = p.Importe,
EmpleadoId = e.EmpId, EmpleadoNombreCompleto = e.Nombre + ' ' + e.Apellidos, EmpleadoCelular = e.Celular, EmpleadoJefeId = e.JefeId,
c.*
FROM Pedidos p
INNER JOIN Empleados e ON p.EmpId = e.EmpId 
INNER JOIN vw_clientes c ON p.CliId = c.ClienteId
GO



-- 1.- NOMBRE DE LA PAIS Y TOTAL DE ESTADOS QUE CONTIENE.
SELECT PaisNombre, TotalDeEstados = COUNT(*)
FROM vw_estados
GROUP BY PaisNombre



-- 2.- NOMBRE DEL ESTADO, TOTAL DE PEDIDOS REALIZADOS E IMPORTE TOTAL.
SELECT EstadoNombre, TotalDePedidos = COUNT(*), ImporteTotal = SUM(PedidoImporte)
FROM vw_pedidos
GROUP BY EstadoNombre



-- 3.- AÑO, TOTAL DE PEDIDOS REALIZADOS E IMPORTE TOTAL.
SELECT Año = YEAR(PedidoFecha), TotalDePedidos = COUNT(*), ImporteTotal = SUM(PedidoImporte)
FROM vw_pedidos
GROUP BY YEAR(PedidoFecha)



-- 4.- MES Y TOTAL DE PEDIDOS REALIZADOS. MOSTRAR TODOS LOS MESES, SI NO TIENE PEDIDOS, MOSTAR EN CERO.
SELECT 
Enero = SUM(CASE MONTH(PedidoFecha) WHEN 1 THEN 1 ELSE 0 END),
Febrero = SUM(CASE MONTH(PedidoFecha) WHEN 2 THEN 1 ELSE 0 END),
Marzo = SUM(CASE MONTH(PedidoFecha) WHEN 3 THEN 1 ELSE 0 END),
Abril = SUM(CASE MONTH(PedidoFecha) WHEN 4 THEN 1 ELSE 0 END),
Mayo = SUM(CASE MONTH(PedidoFecha) WHEN 5 THEN 1 ELSE 0 END),
Juno = SUM(CASE MONTH(PedidoFecha) WHEN 6 THEN 1 ELSE 0 END),
Julio = SUM(CASE MONTH(PedidoFecha) WHEN 7 THEN 1 ELSE 0 END),
Agosto = SUM(CASE MONTH(PedidoFecha) WHEN 8 THEN 1 ELSE 0 END),
Septiembre = SUM(CASE MONTH(PedidoFecha) WHEN 9 THEN 1 ELSE 0 END),
Octubre = SUM(CASE MONTH(PedidoFecha) WHEN 10 THEN 1 ELSE 0 END),
Noviembre = SUM(CASE MONTH(PedidoFecha) WHEN 11 THEN 1 ELSE 0 END),
Diciembre = SUM(CASE MONTH(PedidoFecha) WHEN 12 THEN 1 ELSE 0 END)
FROM vw_pedidos



-- 5.- NOMBRE DEL EMPLEADO, TOTAL DE PEDIDOS REALIZADOS E IMPORTE TOTAL.
SELECT Nombre = e.Nombre + ' ' + e.Apellidos, CantidadPedidos = COUNT(p.PedidoFolio), ImporteTotal = ISNULL(SUM(PedidoImporte), 0)
FROM vw_pedidos p
RIGHT OUTER JOIN Empleados e ON p.EmpleadoId = e.EmpId
GROUP BY e.Nombre, e.Apellidos



-- 6.- NOMBRE DEL CLIENTE, TOTAL DE PEDIDOS REALIZADOS E IMPORTE TOTAL.
SELECT c.ClienteNombreCompleto, CantidadPedidos = COUNT(p.PedidoFolio), ImporteTotal = ISNULL(SUM(PedidoImporte), 0)
FROM vw_pedidos p
RIGHT OUTER JOIN vw_clientes c ON p.ClienteId = c.ClienteId
GROUP BY c.ClienteNombreCompleto



-- 7.- NOMBRE DEL ESTADO Y TOTAL DE PEDIDOS REALIZADOS POR MES DEL AÑO 2020. POR EJEMPLO 
SELECT 
EstadoNombre,
Enero = SUM(CASE WHEN MONTH(PedidoFecha) = 1 THEN 1 ELSE 0 END),
Febrero = SUM(CASE WHEN MONTH(PedidoFecha) = 2 THEN 1 ELSE 0 END),
Marzo = SUM(CASE WHEN MONTH(PedidoFecha) = 3 THEN 1 ELSE 0 END),
Abril = SUM(CASE WHEN MONTH(PedidoFecha) = 4 THEN 1 ELSE 0 END),
Mayo = SUM(CASE WHEN MONTH(PedidoFecha) = 5 THEN 1 ELSE 0 END),
Juno = SUM(CASE WHEN MONTH(PedidoFecha) = 6 THEN 1 ELSE 0 END),
Julio = SUM(CASE WHEN MONTH(PedidoFecha) = 7 THEN 1 ELSE 0 END),
Agosto = SUM(CASE WHEN MONTH(PedidoFecha) = 8 THEN 1 ELSE 0 END),
Septiembre = SUM(CASE WHEN MONTH(PedidoFecha) = 9 THEN 1 ELSE 0 END),
Octubre = SUM(CASE WHEN MONTH(PedidoFecha) = 10 THEN 1 ELSE 0 END),
Noviembre = SUM(CASE WHEN MONTH(PedidoFecha) = 11 THEN 1 ELSE 0 END),
Diciembre = SUM(CASE WHEN MONTH(PedidoFecha) = 12 THEN 1 ELSE 0 END)
FROM vw_pedidos
WHERE YEAR(PedidoFecha) = 2020
GROUP BY EstadoNombre



-- 8.- AÑO, Y TOTAL DE PEDIDOS REALIZADOS POR DIA DE LA SEMANA.
SELECT 
Año = YEAR(PedidoFecha),
Lunes = SUM(CASE WHEN DATEPART(DW, PedidoFecha) = 2 THEN 1 ELSE 0 END),
Martes = SUM(CASE WHEN DATEPART(DW, PedidoFecha) = 3 THEN 1 ELSE 0 END),
Miercoles = SUM(CASE WHEN DATEPART(DW, PedidoFecha) = 4 THEN 1 ELSE 0 END),
Jueves = SUM(CASE WHEN DATEPART(DW, PedidoFecha) = 5 THEN 1 ELSE 0 END),
Viernes = SUM(CASE WHEN DATEPART(DW, PedidoFecha) = 6 THEN 1 ELSE 0 END),
Sabado = SUM(CASE WHEN DATEPART(DW, PedidoFecha) = 7 THEN 1 ELSE 0 END),
Domingo = SUM(CASE WHEN DATEPART(DW, PedidoFecha) = 1 THEN 1 ELSE 0 END)
FROM vw_pedidos
GROUP BY YEAR(PedidoFecha)




-- 9.- AÑO Y TOTAL DE PEDIDOS REALIZADOS POR ESTADO.
SELECT
Año = YEAR(PedidoFecha),
Sinaloa = SUM(CASE WHEN EstadoNombre = 'Sinaloa' THEN 1 ELSE 0 END),
Sonora = SUM(CASE WHEN EstadoNombre = 'Sonora' THEN 1 ELSE 0 END),
Jalisco = SUM(CASE WHEN EstadoNombre = 'Jalisco' THEN 1 ELSE 0 END)
FROM vw_pedidos
GROUP BY YEAR(PedidoFecha)




-- 10.- NOMBRE DEL PAIS, TOTAL DE ESTADOS QUE CONTIENE, TOTAL DE CLIENTES QUE CONTIENE.
SELECT PaisNombre, TotalDeEstados = COUNT(EstadoId), TotalDeClientes = COUNT(ClienteId)
FROM vw_pedidos p
GROUP BY PaisNombre