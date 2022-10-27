CREATE DATABASE Inventario
GO
USE Inventario
GO

CREATE TABLE Categorias(
    Categoria_Id NVARCHAR(3) NOT NULL,
    Nombre NVARCHAR(20) NOT NULL
)
GO

CREATE TABLE Productos(
    Producto_Id NUMERIC(5, 0) NOT NULL,
    Categoria_Id NVARCHAR(3) NOT NULL,
    Nombre NVARCHAR(25) NOT NULL,
    Existencia SMALLINT NOT NULL,
    Precio NUMERIC(10, 2) NOT NULL
)
GO

ALTER TABLE Categorias ADD 
CONSTRAINT PK_Categoria PRIMARY KEY (Categoria_Id)
GO

ALTER TABLE Productos ADD 
CONSTRAINT PK_Productos PRIMARY KEY (Producto_Id),
CONSTRAINT FK_Productos_Categorias FOREIGN KEY (Categoria_Id) REFERENCES Categorias (Categoria_Id)
GO

INSERT INTO Categorias VALUES
    ('LAC', 'Lacteos'),
    ('CAR', 'Carnes'),
    ('BAS', 'Canasta basica'),
    ('LIM', 'Limpieza'),
    ('DUL', 'Dulces')
GO

INSERT INTO Productos VALUES
    (1, 'LAC', 'Leche Lala 2L', 12, 30.95),
    (2, 'CAR', 'Pollo 500 gr', 2, 40.99),
    (3, 'DUL', 'Paleta payaso', 30, 10.23),
    (4, 'LIM', 'Escoba', 2, 30.50),
    (5, 'BAS', 'Cartera de huevos', 9, 42.13)
GO
