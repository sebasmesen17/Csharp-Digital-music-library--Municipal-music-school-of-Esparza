
USE [master]
GO
/****** Object:  Database [BibliotecaVirtualEM]    Script Date: 10/12/2019 04:36:16 ******/
CREATE DATABASE [BibliotecaVirtualEM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BibliotecaVirtualEM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BibliotecaVirtualEM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BibliotecaVirtualEM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\BibliotecaVirtualEM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BibliotecaVirtualEM] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BibliotecaVirtualEM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BibliotecaVirtualEM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET ARITHABORT OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET RECOVERY FULL 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET  MULTI_USER 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BibliotecaVirtualEM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BibliotecaVirtualEM] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BibliotecaVirtualEM', N'ON'
GO
ALTER DATABASE [BibliotecaVirtualEM] SET QUERY_STORE = OFF
GO
USE [BibliotecaVirtualEM]
GO
/****** Object:  Table [dbo].[tbAutor]    Script Date: 10/12/2019 04:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAutor](
	[idAutor] [int] IDENTITY(1,1) NOT NULL,
	[nombreCompleto] [varchar](50) NOT NULL,
	[fechaNacimiento] [datetime] NOT NULL,
	[informacion] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbObrasMusicales]    Script Date: 10/12/2019 04:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbObrasMusicales](
	[idObra] [int] IDENTITY(1,1) NOT NULL,
	[idAutor] [int] NOT NULL,
	[codigoObra] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[genero] [varchar](50) NOT NULL,
	[instrumento] [varchar](50) NOT NULL,
	[ruta] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idObra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[VP_CNS_ConsultaObrasConAutor]    Script Date: 10/12/2019 04:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   view [dbo].[VP_CNS_ConsultaObrasConAutor]
as
select o.idObra, o.codigoObra,o.nombre, o.instrumento,o.ruta,o.genero, a.nombreCompleto from dbo.tbAutor a, dbo.tbObrasMusicales o
where o.idAutor = A.idAutor;
GO
/****** Object:  Table [dbo].[tbAdministrador]    Script Date: 10/12/2019 04:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbAdministrador](
	[cedula] [varchar](20) NOT NULL,
	[nombreCompleto] [varchar](50) NOT NULL,
	[cargo] [varchar](50) NOT NULL,
	[contrasenia] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbObrasMusicales]  WITH CHECK ADD FOREIGN KEY([idAutor])
REFERENCES [dbo].[tbAutor] ([idAutor])
GO
USE [master]
GO
ALTER DATABASE [BibliotecaVirtualEM] SET  READ_WRITE 
GO
