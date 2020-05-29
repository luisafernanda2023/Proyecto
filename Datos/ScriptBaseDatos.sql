CREATE DATABASE [AlquilerTopografria];
USE [AlquilerTopografria]
CREATE TABLE [dbo].[Clientes](
[TipoId] [nvarchar](25) NULL,    
[IdCliente] [nvarchar](10) NOT NULL PRIMARY KEY,
[Nombre] [nvarchar](30) NULL,
[Telefono] [nvarchar](2) NULL,
[Direccion] [int] NULL,
[Pulsacion] [numeric](18, 0) NULL,
)
GO
COMMIT

CREATE DATABASE [AlquilerTopografria];
USE [AlquilerTopografria]
CREATE TABLE [dbo].[Equipos](
[IdEquipo] [nvarchar](10) NOT NULL PRIMARY KEY,    
[NEquipo] [nvarchar](20) Null,
[Marca] [nvarchar](30) NULL,
[TiempoAlquiler] [nvarchar](2) NULL,
[Valor] [int] NULL,
)
GO
COMMIT
