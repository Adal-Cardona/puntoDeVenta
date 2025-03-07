USE master
GO
/****** Object:  Database tiendaAbarrotes    Script Date: 25/02/2025 01:35:17 a. m. ******/
CREATE DATABASE tiendaAbarrotes
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tiendaAbarrotes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\tiendaAbarrotes.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tiendaAbarrotes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\tiendaAbarrotes_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE tiendaAbarrotes SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC tiendaAbarrotes.dbo.sp_fulltext_database @action = 'enable'
end
GO
ALTER DATABASE tiendaAbarrotes SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE tiendaAbarrotes SET ANSI_NULLS OFF 
GO
ALTER DATABASE tiendaAbarrotes SET ANSI_PADDING OFF 
GO
ALTER DATABASE tiendaAbarrotes SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE tiendaAbarrotes SET ARITHABORT OFF 
GO
ALTER DATABASE tiendaAbarrotes SET AUTO_CLOSE OFF 
GO
ALTER DATABASE tiendaAbarrotes SET AUTO_SHRINK OFF 
GO
ALTER DATABASE tiendaAbarrotes SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE tiendaAbarrotes SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE tiendaAbarrotes SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE tiendaAbarrotes SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE tiendaAbarrotes SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE tiendaAbarrotes SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE tiendaAbarrotes SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE tiendaAbarrotes SET  DISABLE_BROKER 
GO
ALTER DATABASE tiendaAbarrotes SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE tiendaAbarrotes SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE tiendaAbarrotes SET TRUSTWORTHY OFF 
GO
ALTER DATABASE tiendaAbarrotes SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE tiendaAbarrotes SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE tiendaAbarrotes SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE tiendaAbarrotes SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE tiendaAbarrotes SET RECOVERY FULL 
GO
ALTER DATABASE tiendaAbarrotes SET  MULTI_USER 
GO
ALTER DATABASE tiendaAbarrotes SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE tiendaAbarrotes SET DB_CHAINING OFF 
GO
ALTER DATABASE tiendaAbarrotes SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE tiendaAbarrotes SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE tiendaAbarrotes SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE tiendaAbarrotes SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'tiendaAbarrotes', N'ON'
GO
ALTER DATABASE tiendaAbarrotes SET QUERY_STORE = ON
GO
ALTER DATABASE tiendaAbarrotes SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE tiendaAbarrotes
GO
/****** Object:  Table dbo.departamentos    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE dbo.departamentos(
	id int IDENTITY(1,1) NOT NULL,
	siglasDepartamento nvarchar(50) NOT NULL,
	nombre nvarchar(50) NOT NULL,
	idGerente int NOT NULL,
 CONSTRAINT PK_nombre_de_la_clave PRIMARY KEY CLUSTERED 
(
	id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  Table dbo.empleados    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE dbo.empleados(
	id int IDENTITY(1,1) NOT NULL,
	primerNombre nvarchar(50) NOT NULL,
	segundoNombre nvarchar(50) NULL,
	primerApellido nvarchar(50) NOT NULL,
	segundoApellido nvarchar(max) NULL,
	id_departamento nvarchar(50) NOT NULL,
	id_puesto int NOT NULL,
	edad int NOT NULL,
	rfc nvarchar(50) NOT NULL,
	activo int NOT NULL,
 CONSTRAINT PK_nombre_de_la_clave_empleados PRIMARY KEY CLUSTERED 
(
	id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
) ON PRIMARY TEXTIMAGE_ON PRIMARY
GO
/****** Object:  Table dbo.entradaInventario    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE dbo.entradaInventario(
	id int IDENTITY(1,1) NOT NULL,
	idEmpleado int NOT NULL,
	fecha datetime NOT NULL,
 CONSTRAINT PK_nombre_de_la_clave_entradaInventario PRIMARY KEY CLUSTERED 
(
	id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  Table dbo.infoEntradaInventario    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE dbo.infoEntradaInventario(
	id int IDENTITY(1,1) NOT NULL,
	idEntrada int NOT NULL,
	idEmpleado int NOT NULL,
	codigoBarras bigint NOT NULL,
	cantidad int NOT NULL,
PRIMARY KEY CLUSTERED 
(
	id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  Table dbo.infoTicket    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE dbo.infoTicket(
	id int IDENTITY(1,1) NOT NULL,
	idTicket int NOT NULL,
	codigoBarras bigint NOT NULL,
	cantidad int NOT NULL,
	precioFinal money NOT NULL,
PRIMARY KEY CLUSTERED 
(
	id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  Table dbo.inicioDeSesion    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE dbo.inicioDeSesion(
	id int IDENTITY(1,1) NOT NULL,
	id_empleado int NOT NULL,
	contraseña nvarchar(50) NULL,
 CONSTRAINT PK_nombre_de_la_clave_inicioDeSesion PRIMARY KEY CLUSTERED 
(
	id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  Table dbo.inventario    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

insert into inicioDeSesion(id_empleado, contraseña) VALUES (0, '1234');

CREATE TABLE dbo.inventario(
	id int IDENTITY(1,1) NOT NULL,
	codigoBarras bigint NOT NULL,
	nombre nvarchar(50) NOT NULL,
	precioUnidad int NOT NULL,
	stock int NOT NULL,
	id_departamento nvarchar(50) NOT NULL,
 CONSTRAINT PK_nombre_de_la_clave_inventario PRIMARY KEY CLUSTERED 
(
	id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  Table dbo.puestos    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE dbo.puestos(
	id int IDENTITY(1,1) NOT NULL,
	nombre nvarchar(50) NOT NULL,
	ventas int NOT NULL,
	entradaInventario int NOT NULL,
	revisionStock int NOT NULL,
	productosNuevos int NOT NULL,
	infoEmpleados int NOT NULL,
	reporteVentas int NOT NULL,
	reporteInventarios int NOT NULL,
	cambios int NOT NULL,
 CONSTRAINT PK_nombre_de_la_clave_puestos PRIMARY KEY CLUSTERED 
(
	id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
) ON PRIMARY
GO
/****** Object:  Table dbo.ticket    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE dbo.ticket(
	id int IDENTITY(1,1) NOT NULL,
	total money NOT NULL,
	fecha datetime NOT NULL,
	id_Empleado int NOT NULL,
 CONSTRAINT PK_nombre_de_la_clave_ticket PRIMARY KEY CLUSTERED 
(
	id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
) ON PRIMARY
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index IX_siglas_depa    Script Date: 25/02/2025 01:35:18 a. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX IX_siglas_depa ON dbo.departamentos
(
	nombre ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON PRIMARY
GO
ALTER TABLE dbo.departamentos  WITH CHECK ADD FOREIGN KEY(idGerente)
REFERENCES dbo.empleados (id)
GO
ALTER TABLE dbo.entradaInventario  WITH CHECK ADD FOREIGN KEY(idEmpleado)
REFERENCES dbo.empleados (id)
GO
ALTER TABLE dbo.infoEntradaInventario  WITH CHECK ADD FOREIGN KEY(idEmpleado)
REFERENCES dbo.empleados (id)
GO
ALTER TABLE dbo.infoEntradaInventario  WITH CHECK ADD FOREIGN KEY(idEntrada)
REFERENCES dbo.entradaInventario (id)
GO
ALTER TABLE dbo.infoTicket  WITH CHECK ADD FOREIGN KEY(idTicket)
REFERENCES dbo.ticket (id)
GO
ALTER TABLE dbo.ticket  WITH CHECK ADD FOREIGN KEY(id_Empleado)
REFERENCES dbo.empleados (id)
GO
/****** Object:  StoredProcedure dbo.aumentarStock    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure dbo.aumentarStock
	@codigoBarras BigInt,
	@cantidad int
as
begin
	Update inventario Set stock += @cantidad where codigoBarras = @codigoBarras;
end
GO
/****** Object:  StoredProcedure dbo.restarStock    Script Date: 25/02/2025 01:35:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure dbo.restarStock
	@codigoBarras BigInt,
	@cantidad int
as
begin
	Update inventario Set stock -= @cantidad where codigoBarras = @codigoBarras;
end
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create trigger dbo.crearUsuario on dbo.empleados
after insert
as
begin
	Insert into inicioDeSesion(id_empleado, contraseña) Select id, '1234' from inserted
end;
GO

ALTER TABLE dbo.empleados ENABLE TRIGGER crearUsuario
GO

USE master
GO
ALTER DATABASE tiendaAbarrotes SET  READ_WRITE 
GO


/****** Object:  Trigger dbo.crearUsuario    Script Date: 25/02/2025 01:37:19 a. m. ******/


