USE [master]
GO
/****** Object:  Database [Parroquia]    Script Date: 7/6/2021 1:13:39 PM ******/
CREATE DATABASE [Parroquia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Parroquia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERVERSANTI\MSSQL\DATA\Parroquia.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Parroquia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERVERSANTI\MSSQL\DATA\Parroquia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Parroquia] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Parroquia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Parroquia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Parroquia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Parroquia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Parroquia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Parroquia] SET ARITHABORT OFF 
GO
ALTER DATABASE [Parroquia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Parroquia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Parroquia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Parroquia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Parroquia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Parroquia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Parroquia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Parroquia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Parroquia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Parroquia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Parroquia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Parroquia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Parroquia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Parroquia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Parroquia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Parroquia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Parroquia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Parroquia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Parroquia] SET  MULTI_USER 
GO
ALTER DATABASE [Parroquia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Parroquia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Parroquia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Parroquia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Parroquia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Parroquia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Parroquia] SET QUERY_STORE = OFF
GO
USE [Parroquia]
GO
/****** Object:  User [usuario]    Script Date: 7/6/2021 1:13:39 PM ******/
CREATE USER [usuario] FOR LOGIN [usuario] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [usuario]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [usuario]
GO
/****** Object:  Table [dbo].[Bautismos]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bautismos](
	[Codigo_Partida] [varchar](255) NULL,
	[Libro] [varchar](255) NULL,
	[Folio] [varchar](255) NULL,
	[Numero] [varchar](255) NULL,
	[Nombre_Niño] [varchar](255) NULL,
	[Fecha_Bautismo] [varchar](255) NULL,
	[Ministro] [varchar](255) NULL,
	[Lugar_Nacimiento] [varchar](255) NULL,
	[Fecha_Nacimiento] [varchar](255) NULL,
	[Nombre_Padres] [varchar](255) NULL,
	[Abuelos_Paternos] [varchar](255) NULL,
	[Abuelos_Maternos] [varchar](255) NULL,
	[Padrinos] [varchar](255) NULL,
	[Doy_Fe] [int] NULL,
	[Nota_Marginal] [text] NULL,
	[Firmante] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Confirmaciones]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Confirmaciones](
	[Codigo_Partida] [nvarchar](20) NOT NULL,
	[libro] [nvarchar](5) NOT NULL,
	[Folio] [nvarchar](5) NOT NULL,
	[Numero] [nvarchar](5) NOT NULL,
	[Fecha_Confirmacion] [nvarchar](100) NULL,
	[Nombre_Confirmado] [varchar](100) NULL,
	[Lugar_Nacimiento] [varchar](100) NULL,
	[Fecha_Nacimiento] [nvarchar](100) NULL,
	[Nombre_Padres] [varchar](200) NULL,
	[Parroquia_Bautizo] [varchar](100) NULL,
	[Diocesis] [varchar](100) NULL,
	[Fecha_Bautismo] [nvarchar](100) NULL,
	[Libro_B] [nvarchar](5) NULL,
	[Folio_B] [nvarchar](5) NULL,
	[Numero_B] [nvarchar](5) NULL,
	[Padrinos] [varchar](200) NULL,
	[Ministro] [varchar](100) NULL,
	[Doy_Fe] [varchar](100) NULL,
	[Notas_Correcciones] [text] NULL,
	[Firmante] [int] NULL,
 CONSTRAINT [PK_Confirmacion] PRIMARY KEY CLUSTERED 
(
	[Codigo_Partida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Defunciones]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Defunciones](
	[No_Defuncion] [varchar](255) NOT NULL,
	[Libro] [varchar](255) NULL,
	[Folio] [varchar](255) NULL,
	[Numero] [varchar](255) NULL,
	[Fecha_Sepelio] [nvarchar](100) NULL,
	[Nombre_Difunto] [varchar](100) NULL,
	[Ciudad_Origenv] [varchar](50) NULL,
	[Edad] [varchar](254) NULL,
	[Padres] [varchar](100) NULL,
	[Estado_Civil] [varchar](50) NULL,
	[Ocacion_Muerte] [varchar](100) NULL,
	[Doy_Fe] [varchar](100) NULL,
	[Firmante] [int] NULL,
	[NotaMarginal] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[No_Defuncion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doy_Fe]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doy_Fe](
	[Id_Firmante] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Firmante] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Firmante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matrimonios]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matrimonios](
	[Codigo_Partida] [nvarchar](15) NOT NULL,
	[libro] [nvarchar](5) NULL,
	[Folio] [nvarchar](5) NULL,
	[Numero] [nvarchar](5) NULL,
	[Fecha_Matrimonio] [nvarchar](50) NULL,
	[Presencio] [varchar](100) NULL,
	[Nombre_Novio] [varchar](100) NULL,
	[Padres_Novio] [varchar](200) NULL,
	[Parroquia_Novio] [varchar](100) NULL,
	[Fecha_Bautismo_Novio] [nvarchar](50) NULL,
	[Libro_Novio] [nvarchar](10) NULL,
	[Folio_Novio] [nvarchar](5) NULL,
	[Acta_Novio] [nvarchar](5) NULL,
	[Novia] [varchar](100) NULL,
	[Padres_Novia] [varchar](200) NULL,
	[Parroquia_Novia] [varchar](100) NULL,
	[Fecha_Bautismo_Novia] [nvarchar](50) NULL,
	[Libro_Novia] [nvarchar](10) NULL,
	[Folio_Novia] [nvarchar](5) NULL,
	[Acta_Novia] [nvarchar](5) NULL,
	[Testigos] [varchar](200) NULL,
	[Doy_Fe] [int] NULL,
	[Nota_Marginal] [text] NULL,
	[Firmante] [int] NULL,
 CONSTRAINT [PK_Matrimonio] PRIMARY KEY CLUSTERED 
(
	[Codigo_Partida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ministros_Firmantes]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ministros_Firmantes](
	[Id_Firmante] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Firmante] [varchar](50) NULL,
	[Cargo] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Firmante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tabla_Log]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tabla_Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Log] [datetime] NULL,
	[Tabla] [varchar](100) NULL,
	[No_Partida] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_Usuarios]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_Usuarios](
	[Id_Tipo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Usuario] [varchar](20) NULL,
	[Tipo_Usuario] [int] NULL,
	[Clave] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bautismos]  WITH CHECK ADD  CONSTRAINT [Fk_Doy] FOREIGN KEY([Doy_Fe])
REFERENCES [dbo].[Doy_Fe] ([Id_Firmante])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Bautismos] CHECK CONSTRAINT [Fk_Doy]
GO
ALTER TABLE [dbo].[Bautismos]  WITH CHECK ADD  CONSTRAINT [FK_FIRMANTE] FOREIGN KEY([Firmante])
REFERENCES [dbo].[Ministros_Firmantes] ([Id_Firmante])
GO
ALTER TABLE [dbo].[Bautismos] CHECK CONSTRAINT [FK_FIRMANTE]
GO
ALTER TABLE [dbo].[Confirmaciones]  WITH CHECK ADD  CONSTRAINT [Fk_ConfirFirmantes] FOREIGN KEY([Firmante])
REFERENCES [dbo].[Ministros_Firmantes] ([Id_Firmante])
GO
ALTER TABLE [dbo].[Confirmaciones] CHECK CONSTRAINT [Fk_ConfirFirmantes]
GO
ALTER TABLE [dbo].[Defunciones]  WITH CHECK ADD  CONSTRAINT [Fk_DoyFe] FOREIGN KEY([Firmante])
REFERENCES [dbo].[Ministros_Firmantes] ([Id_Firmante])
GO
ALTER TABLE [dbo].[Defunciones] CHECK CONSTRAINT [Fk_DoyFe]
GO
ALTER TABLE [dbo].[Matrimonios]  WITH CHECK ADD  CONSTRAINT [Fk_Matri_DoyFe] FOREIGN KEY([Doy_Fe])
REFERENCES [dbo].[Doy_Fe] ([Id_Firmante])
GO
ALTER TABLE [dbo].[Matrimonios] CHECK CONSTRAINT [Fk_Matri_DoyFe]
GO
ALTER TABLE [dbo].[Matrimonios]  WITH CHECK ADD  CONSTRAINT [Fk_MatriFirmantes] FOREIGN KEY([Firmante])
REFERENCES [dbo].[Ministros_Firmantes] ([Id_Firmante])
GO
ALTER TABLE [dbo].[Matrimonios] CHECK CONSTRAINT [Fk_MatriFirmantes]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [Fk_TipoUsuario] FOREIGN KEY([Tipo_Usuario])
REFERENCES [dbo].[Tipos_Usuarios] ([Id_Tipo])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [Fk_TipoUsuario]
GO
/****** Object:  StoredProcedure [dbo].[AdminUsuarios]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdminUsuarios]
@Dato int,
@No_Usuario int,
@Usuario varchar(20),
@Tipo int,
@Clave varchar(20),
@Mensaje text out
AS
begin
if @Dato=1 
    INSERT INTO Usuarios VALUES (@Usuario,@Tipo,@Clave);
	set @Mensaje='Has Añadido el nuevo usario'
end

if @Dato=4
select Id_Usuario,Nombre_Usuario,Clave,Tipos_Usuarios.Nombre FROM Usuarios
INNER JOIN  Tipos_Usuarios on Usuarios.Tipo_Usuario= Tipos_Usuarios.Id_Tipo

if @Dato=2 begin
Update Usuarios set Nombre_Usuario=@Usuario, Clave=@Clave, Tipo_Usuario= @Tipo WHERE Id_Usuario=@No_Usuario
set @Mensaje='Se ha editado el Usuario';
end

if @Dato=3 begin
DELETE FROM Usuarios WHERE Id_Usuario= @No_Usuario
set @Mensaje='Has Eliminado el Usuario'
end
GO
/****** Object:  StoredProcedure [dbo].[Bautizos]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[Bautizos]

@Dato int,
@Partida_Codigo nvarchar(15),
@Libro nvarchar(10),
@Folio nvarchar(10),
@Numero nvarchar(10),
@Nombre nvarchar(100),
@Ministro nvarchar(100),
@FechaBautismo nvarchar(50),
@FechaNacimiento nvarchar(50),
@LugarNacimiento nvarchar(100),
@Padres nvarchar(100),
@AbuelosP nvarchar(100),
@AbuelosM nvarchar(100),
@Padrinos nvarchar(100),
@DoyFe int,
@NotaMarginal text,
@Firmante int,
@mensaje varchar(100) out
AS
begin 
if @Dato=1 begin  
     if exists(select * from Bautismos where Codigo_Partida = @Partida_Codigo)or len(@Partida_Codigo) <= 1 begin
	    SET @mensaje='Ya registraste este numero de partida'; 
		end
        else begin
        INSERT INTO Bautismos VALUES (@Partida_Codigo,@Libro,@Folio,@Numero,@Nombre,@FechaBautismo,@Ministro,@LugarNacimiento,@FechaNacimiento,@Padres,@AbuelosP,@AbuelosM,@Padrinos,@DoyFe,@NotaMarginal,@Firmante);
		SET @mensaje= 'Se ha insertado el bautismo';
	  end
	end
else
   if @Dato= 2 begin
      
      update Bautismos set Nombre_Niño=@Nombre,Fecha_Bautismo= @FechaBautismo,Ministro=@Ministro,Lugar_Nacimiento=@LugarNacimiento,Fecha_Nacimiento=@FechaNacimiento,Nombre_Padres=@Padres,Abuelos_Paternos=@AbuelosP,
	  Abuelos_Maternos= @AbuelosM,Padrinos=@Padrinos,Doy_Fe=@DoyFe,Nota_Marginal=@NotaMarginal,Firmante=@Firmante WHERE Codigo_Partida=@Partida_Codigo
	  SET @mensaje = 'Se ha actualizado la partida'
	  end

	if @Dato = 3 begin

	  Delete FROM Bautismos WHERE Codigo_Partida= @Partida_Codigo
	  set @mensaje= 'Se ha eliminado la Partida';

	end
 end
GO
/****** Object:  StoredProcedure [dbo].[BuscarMatrimonios]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[BuscarMatrimonios]
@Dato  int,
@Partida nvarchar(15),
@NombreNovio nvarchar(100),
@NombreNovia nvarchar(100)
AS

if @Dato = 1 begin

SELECT * FROM Matrimonios WHERE Codigo_Partida = @Partida;
end

else begin
if @Dato = 2
SELECT * FROM Matrimonios WHERE Codigo_Partida like + '%'+RTRIM(@Partida)+'%';

else begin

if @Dato = 3
SELECT * FROM Matrimonios WHERE Nombre_Novio like + '%'+RTRIM(@NombreNovio)+'%';

else begin

if @Dato = 4
SELECT * FROM Matrimonios WHERE Novia like + '%'+RTRIM(@NombreNovia)+'%';
end
end
end
GO
/****** Object:  StoredProcedure [dbo].[BusquedaBautisos]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BusquedaBautisos]
@Dato  int,
@Partida nvarchar(12),
@Nombre nvarchar(100),
@NombrePadres nvarchar(100)
AS

if @Dato = 1 begin

SELECT * FROM Bautismos WHERE Codigo_Partida = @Partida;

end

else begin
if @Dato = 2
Select Codigo_Partida,Libro,Folio,Numero,Nombre_Niño,Fecha_Bautismo,Ministro,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,Abuelos_Paternos,
Abuelos_Maternos,Padrinos,Doy_Fe.Nombre_Firmante AS Doy_Fe,Nota_Marginal,Ministros_Firmantes.Nombre_Firmante From Bautismos
left JOIN Ministros_Firmantes on Bautismos.Firmante = Ministros_Firmantes.Id_Firmante
left JOIN Doy_Fe on Bautismos.Doy_Fe = Doy_Fe.Id_Firmante
 WHERE Codigo_Partida like + '%'+RTRIM(@Partida)+'%';

else begin

if @Dato = 3
Select Codigo_Partida,Libro,Folio,Numero,Nombre_Niño,Fecha_Bautismo,Ministro,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,Abuelos_Paternos,
Abuelos_Maternos,Padrinos,Doy_Fe.Nombre_Firmante  AS Doy_Fe,Nota_Marginal,Ministros_Firmantes.Nombre_Firmante From Bautismos
left JOIN Ministros_Firmantes on Bautismos.Firmante = Ministros_Firmantes.Id_Firmante
left JOIN Doy_Fe on Bautismos.Doy_Fe = Doy_Fe.Id_Firmante
WHERE Nombre_Niño like + '%'+RTRIM(@Nombre)+'%';

else begin
if @dato = 4
Select Codigo_Partida,Libro,Folio,Numero,Nombre_Niño,Fecha_Bautismo,Ministro,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,Abuelos_Paternos,
Abuelos_Maternos,Padrinos,Doy_Fe.Nombre_Firmante  AS Doy_Fe,Nota_Marginal,Ministros_Firmantes.Nombre_Firmante From Bautismos
left JOIN Ministros_Firmantes on Bautismos.Firmante = Ministros_Firmantes.Id_Firmante
left JOIN Doy_Fe on Bautismos.Doy_Fe = Doy_Fe.Id_Firmante
 WHERE Nombre_Padres like + '%'+RTRIM(@NombrePadres)+'%';
end
end
end
GO
/****** Object:  StoredProcedure [dbo].[BusquedaConfirmaciones]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[BusquedaConfirmaciones]
@Dato  int,
@Codigo_Partida nvarchar(20),
@Nombre nvarchar(100),
@NombrePadres nvarchar(100)
AS

if @Dato = 1 begin

SELECT * FROM Confirmaciones WHERE Codigo_Partida= @Codigo_Partida;

end

else begin
if @Dato = 2
Select Codigo_Partida,libro,Folio,Numero, Fecha_Confirmacion,Nombre_Confirmado,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,Parroquia_Bautizo,Diocesis,
Fecha_Bautismo,Libro_B,Folio_B,Numero_B,Padrinos,Ministro,Doy_Fe,Notas_Correcciones,Ministros_Firmantes.Nombre_Firmante From Confirmaciones
INNER JOIN Ministros_Firmantes on Confirmaciones.Firmante = Ministros_Firmantes.Id_Firmante

 WHERE Codigo_Partida like + '%'+RTRIM(@Codigo_Partida)+'%';

else begin

if @Dato = 3
Select Codigo_Partida,libro,Folio,Numero, Fecha_Confirmacion,Nombre_Confirmado,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,Parroquia_Bautizo,Diocesis,
Fecha_Bautismo,Libro_B,Folio_B,Numero_B,Padrinos,Ministro,Doy_Fe,Notas_Correcciones,Ministros_Firmantes.Nombre_Firmante From Confirmaciones
INNER JOIN Ministros_Firmantes on Confirmaciones.Firmante = Ministros_Firmantes.Id_Firmante
WHERE Nombre_Confirmado like + '%'+RTRIM(@Nombre)+'%';

else begin
if @dato = 4
Select Codigo_Partida,libro,Folio,Numero, Fecha_Confirmacion,Nombre_Confirmado,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,Parroquia_Bautizo,Diocesis,
Fecha_Bautismo,Libro_B,Folio_B,Numero_B,Padrinos,Ministro,Doy_Fe,Notas_Correcciones,Ministros_Firmantes.Nombre_Firmante From Confirmaciones
INNER JOIN Ministros_Firmantes on Confirmaciones.Firmante = Ministros_Firmantes.Id_Firmante
 WHERE Nombre_Padres like + '%'+RTRIM(@NombrePadres)+'%';
end
end
end
GO
/****** Object:  StoredProcedure [dbo].[BusquedaDefunciones]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[BusquedaDefunciones]
@Dato  int,
@No_Defuncion nvarchar(20),
@Nombre nvarchar(100),
@NombrePadres nvarchar(100)
AS

if @Dato = 1 begin

SELECT * FROM Defunciones WHERE No_Defuncion = @No_Defuncion;

end

else begin
if @Dato = 2
Select No_Defuncion,Libro,Folio,Numero,Fecha_Sepelio,Nombre_Difunto,Ciudad_Origenv,Edad,Padres,Estado_Civil,Ocacion_Muerte,Doy_Fe,Ministros_Firmantes.Nombre_Firmante,NotaMarginal From Defunciones
INNER JOIN Ministros_Firmantes on Defunciones.Firmante = Ministros_Firmantes.Id_Firmante

 WHERE No_Defuncion like + '%'+RTRIM(@No_Defuncion)+'%';

else begin

if @Dato = 3
Select No_Defuncion,Libro,Folio,Numero,Fecha_Sepelio,Nombre_Difunto,Ciudad_Origenv,Edad,
Padres,Estado_Civil,Ocacion_Muerte,Doy_Fe,Ministros_Firmantes.Nombre_Firmante,NotaMarginal From Defunciones
INNER JOIN Ministros_Firmantes on Defunciones.Firmante = Ministros_Firmantes.Id_Firmante
WHERE Nombre_Difunto like + '%'+RTRIM(@Nombre)+'%';

else begin
if @dato = 4
Select No_Defuncion,Libro,Folio,Numero,Fecha_Sepelio,Nombre_Difunto,Ciudad_Origenv,Edad,
Padres,Estado_Civil,Ocacion_Muerte,Doy_Fe,Ministros_Firmantes.Nombre_Firmante,NotaMarginal From Defunciones
INNER JOIN Ministros_Firmantes on Defunciones.Firmante = Ministros_Firmantes.Id_Firmante
 WHERE Padres like + '%'+RTRIM(@NombrePadres)+'%';
end
end
end
GO
/****** Object:  StoredProcedure [dbo].[BusquedaFirmantes]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[BusquedaFirmantes]
@Dato int,
@Id int
AS
if @Dato = 1 begin
SELECT Cargo FROM Ministros_Firmantes WHERE Id_Firmante= @Id
end
GO
/****** Object:  StoredProcedure [dbo].[BusquedaMatrimonios]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[BusquedaMatrimonios]
@Dato  int,
@Codigo_Partida nvarchar(15),
@Nombre_Novio nvarchar(100),
@Nombre_Novia nvarchar(100)
AS

if @Dato = 1 begin

SELECT * FROM Matrimonios WHERE Codigo_Partida= @Codigo_Partida;

end

else begin
if @Dato = 2
SELECT Codigo_Partida,libro,Folio,Numero,Fecha_Matrimonio,Presencio,Nombre_Novio,Padres_Novio,Parroquia_Novio,Fecha_Bautismo_Novio,Libro_Novio,Folio_Novio,Acta_Novio,
Novia,Padres_Novia,Parroquia_Novia,Fecha_Bautismo_Novia,Libro_Novia,Folio_Novia,Acta_Novia,Testigos,Doy_Fe.Nombre_Firmante as DoyFe,Nota_Marginal,Ministros_Firmantes.Nombre_Firmante,Ministros_Firmantes.Cargo 
FROM Matrimonios 
left JOIN Ministros_Firmantes ON Matrimonios.Firmante= Ministros_Firmantes.Id_Firmante
LEFT JOIN Doy_Fe on Matrimonios.Doy_Fe = Doy_Fe.Id_Firmante

 WHERE Codigo_Partida like + '%'+RTRIM(@Codigo_Partida)+'%';

else begin

if @Dato = 3
SELECT Codigo_Partida,libro,Folio,Numero,Fecha_Matrimonio,Presencio,Nombre_Novio,Padres_Novio,Parroquia_Novio,Fecha_Bautismo_Novio,Libro_Novio,Folio_Novio,Acta_Novio,
Novia,Padres_Novia,Parroquia_Novia,Fecha_Bautismo_Novia,Libro_Novia,Folio_Novia,Acta_Novia,Testigos,Doy_Fe.Nombre_Firmante as DoyFe,Nota_Marginal,Ministros_Firmantes.Nombre_Firmante,Ministros_Firmantes.Cargo 
FROM Matrimonios 
LEFT JOIN Doy_Fe on Matrimonios.Doy_Fe = Doy_Fe.Id_Firmante
left JOIN Ministros_Firmantes ON Matrimonios.Firmante= Ministros_Firmantes.Id_Firmante
WHERE Nombre_Novio like + '%'+RTRIM(@Nombre_Novio)+'%';

else begin
if @dato = 4
SELECT Codigo_Partida,libro,Folio,Numero,Fecha_Matrimonio,Presencio,Nombre_Novio,Padres_Novio,Parroquia_Novio,Fecha_Bautismo_Novio,Libro_Novio,Folio_Novio,Acta_Novio,
Novia,Padres_Novia,Parroquia_Novia,Fecha_Bautismo_Novia,Libro_Novia,Folio_Novia,Acta_Novia,Testigos,Doy_Fe.Nombre_Firmante as DoyFe,Nota_Marginal,Ministros_Firmantes.Nombre_Firmante,Ministros_Firmantes.Cargo 
FROM Matrimonios 
LEFT JOIN Ministros_Firmantes ON Matrimonios.Firmante= Ministros_Firmantes.Id_Firmante
LEFT JOIN Doy_Fe on Matrimonios.Doy_Fe = Doy_Fe.Id_Firmante
 WHERE Novia like + '%'+RTRIM(@Nombre_Novia)+'%';
end
end
end
GO
/****** Object:  StoredProcedure [dbo].[ListarBautismos]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ListarBautismos]
AS
Select Codigo_Partida,Libro,Folio,Numero,Nombre_Niño,Fecha_Bautismo,Ministro,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,Abuelos_Paternos,
Abuelos_Maternos,Padrinos,Doy_Fe.Nombre_Firmante  AS Doy_Fe,Nota_Marginal,Ministros_Firmantes.Nombre_Firmante From Bautismos
left JOIN Ministros_Firmantes on Bautismos.Firmante = Ministros_Firmantes.Id_Firmante
INNER JOIN Doy_Fe on Bautismos.Doy_Fe = Doy_Fe.Id_Firmante
GO
/****** Object:  StoredProcedure [dbo].[ListarConfirmaciones]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[ListarConfirmaciones]
as
Select Codigo_Partida,libro,Folio,Numero,Fecha_Confirmacion,Nombre_Confirmado,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,Parroquia_Bautizo,Diocesis,
Fecha_Bautismo,Libro_B,Folio_B,Numero_B,Padrinos,Ministro,Doy_Fe,Notas_Correcciones,Ministros_Firmantes.Nombre_Firmante From Confirmaciones
INNER JOIN Ministros_Firmantes on Confirmaciones.Firmante = Ministros_Firmantes.Id_Firmante
GO
/****** Object:  StoredProcedure [dbo].[ListarDefunciones]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarDefunciones]
AS
Select No_Defuncion,Libro,Folio,Numero,Fecha_Sepelio,Nombre_Difunto,Ciudad_Origenv,Edad,
Padres,Estado_Civil,Ocacion_Muerte,Doy_Fe,Ministros_Firmantes.Nombre_Firmante,NotaMarginal From Defunciones
INNER JOIN Ministros_Firmantes on Defunciones.Firmante = Ministros_Firmantes.Id_Firmante
GO
/****** Object:  StoredProcedure [dbo].[ListarDoyFe]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListarDoyFe]
AS
SELECT * FROM Doy_Fe
GO
/****** Object:  StoredProcedure [dbo].[ListarMatrimonios]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ListarMatrimonios]
AS
SELECT Codigo_Partida,libro,Folio,Numero, Fecha_Matrimonio,Presencio,Nombre_Novio,Padres_Novio,Parroquia_Novio,Fecha_Bautismo_Novio,Libro_Novio,Folio_Novio,Acta_Novio,
Novia,Padres_Novia,Parroquia_Novia,Fecha_Bautismo_Novia,Libro_Novia,Folio_Novia,Acta_Novia,Testigos,Doy_Fe.Nombre_Firmante as Doy_fe,Nota_Marginal,Ministros_Firmantes.Nombre_Firmante,Ministros_Firmantes.Cargo 
FROM Matrimonios 
LEFT JOIN Ministros_Firmantes ON Matrimonios.Firmante= Ministros_Firmantes.Id_Firmante
LEFT JOIN Doy_Fe on Matrimonios.Doy_Fe = Doy_Fe.Id_Firmante
GO
/****** Object:  StoredProcedure [dbo].[ListarMinistros]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarMinistros]
AS
SELECT * FROM Ministros_Firmantes WHERE Cargo!='Cargo Nuevo' 
GO
/****** Object:  StoredProcedure [dbo].[Logueo]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Logueo]
@Usuario varchar(20),
@Clave varchar(20)
AS
SELECT *
FROM Usuarios
WHERE Nombre_Usuario = @Usuario and Clave = @Clave
GO
/****** Object:  StoredProcedure [dbo].[PConfirmaciones]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PConfirmaciones]
@Dato int,
@Codigo_Partida nvarchar(20),
@Libro  nvarchar(5),
@Folio nvarchar(5),
@Numero nvarchar(5),
@FechaConfirmacion nvarchar(100),
@Nombre nvarchar(50),
@Lugar_Nacimiento nvarchar(50),
@Fecha_Nacimiento nvarchar(100),
@Padres nvarchar(100),
@ParroquiaB nvarchar(100),
@Diocesis nvarchar(100),
@FechaB nvarchar(100),
@LibroB nvarchar(5),
@FolioB nvarchar(5),
@NumeroB nvarchar(5),
@Padrinos nvarchar(100),
@Ministro nvarchar(100),
@DoyFe nvarchar(100),
@Notas text,
@Firmante int,
@mensaje varchar(100) out
AS
begin 
if @Dato=1 begin  
     if exists(select * from Confirmaciones where Codigo_Partida= @Codigo_Partida)or len(@Codigo_Partida) <= 1 begin
	    SET @mensaje='Ya registraste esta Confirmacion'; 
		end
        else begin
        INSERT INTO Confirmaciones VALUES (@Codigo_Partida,@Libro,@Folio,@Numero,@FechaConfirmacion,@Nombre,@Lugar_Nacimiento,@Fecha_Nacimiento,@Padres,
		@ParroquiaB,@Diocesis,@FechaB,@LibroB,@FolioB,@NumeroB,@Padrinos,@Ministro,@DoyFe,@Notas,@Firmante);
		SET @mensaje= 'Se ha insertado la Confirmacion';
	  end
	end
else
   if @Dato= 2 begin
      
      update Confirmaciones set Fecha_Confirmacion=@FechaConfirmacion,Nombre_Confirmado= @Nombre,Lugar_Nacimiento=@Lugar_Nacimiento,
	  Fecha_Nacimiento=@Fecha_Nacimiento,Nombre_Padres=@Padres,Parroquia_Bautizo=@ParroquiaB,Diocesis=@Diocesis,Fecha_Bautismo=@FechaB
	  ,Libro_B=@LibroB,Folio_B= @FolioB,Numero_B= @NumeroB,Padrinos=@Padrinos,Ministro=@Ministro,Doy_Fe=@DoyFe,Notas_Correcciones=@Notas,
	  Firmante=@Firmante 
	  WHERE Codigo_Partida=@Codigo_Partida
	  SET @mensaje = 'Se ha actualizado la Confirmacion'
	  end

	if @Dato = 3 begin

	  Delete FROM Confirmaciones WHERE Codigo_Partida= @Codigo_Partida
	  set @mensaje= 'Se ha eliminado la Confirmacion';

	end
 end
GO
/****** Object:  StoredProcedure [dbo].[PDefunciones]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PDefunciones]
@Dato int,
@No_Defuncion nvarchar(250),
@Libro nvarchar(20),
@Folio nvarchar(20),
@Numero nvarchar(20),
@FechaSepelio nvarchar(100),
@Nombre nvarchar(50),
@CiudadOrigen nvarchar(50),
@Edad nvarchar(250),
@Padres nvarchar(100),
@EstadoCivil nvarchar(100),
@OcacionMuerte nvarchar(100),
@DoyFe nvarchar(100),
@NotaMarginal text,
@Firmante int,
@mensaje varchar(100) out
AS
begin 
if @Dato=1 begin  
     if exists(select * from Defunciones where No_Defuncion= @No_Defuncion)or len(@No_Defuncion) = 0 begin
	    SET @mensaje='Ya registraste esta defuncion o el numero esta vacio'; 
		end
        else begin
        INSERT INTO Defunciones VALUES (@No_Defuncion,@Libro,@Folio,@Numero,@FechaSepelio,@Nombre,@CiudadOrigen,@Edad,@Padres,@EstadoCivil,@OcacionMuerte,@DoyFe,@Firmante,@NotaMarginal);
		SET @mensaje= 'Se ha insertado la defuncion';
	  end
	end
else
   if @Dato= 2 begin
      
      update Defunciones set Fecha_Sepelio=@FechaSepelio,Nombre_Difunto= @Nombre,Ciudad_Origenv=@CiudadOrigen,Edad=@Edad,
	  Padres=@Padres,Estado_Civil=@EstadoCivil,Ocacion_Muerte=@OcacionMuerte,Doy_Fe=@DoyFe,
	  Firmante=@Firmante,NotaMarginal = @NotaMarginal 
	  WHERE No_Defuncion=@No_Defuncion
	  SET @mensaje = 'Se ha actualizado la defuncion'
	  end

	if @Dato = 3 begin

	  Delete FROM Defunciones WHERE No_Defuncion= @No_Defuncion
	  set @mensaje= 'Se ha eliminado la defuncion';

	end
 end
GO
/****** Object:  StoredProcedure [dbo].[PMatrimonios]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PMatrimonios]
@Dato int,
@Partida_Codigo nvarchar(15),
@Libro nvarchar(5),
@Folio nvarchar(5),
@Numero nvarchar(5),
@Fecha_Matrimonio nvarchar(100),
@Presencio nvarchar(100),
@Nombre_Novio nvarchar(100),
@Padres_Novio nvarchar(200),
@Parroquia_Novio nvarchar(100),
@Fecha_Bautismo_Novio nvarchar(100),
@Libro_H nvarchar(5),
@Folio_H nvarchar(5),
@Acta_H nvarchar(5),
@Nombre_Novia nvarchar(100),
@Padres_Novia nvarchar(200),
@Parroquia_Novia nvarchar(100),
@Fecha_Bautismo_Novia nvarchar(100),
@Libro_M nvarchar(5),
@Folio_M nvarchar(5),
@Acta_M nvarchar(5),

@Testigos nvarchar(100),
@DoyFe int,
@NotaMarginal text,
@Firmante int,
@mensaje varchar(100) out
AS
begin 
if @Dato=1 begin  
     if exists(select * from Matrimonios where Codigo_Partida = @Partida_Codigo)or len(@Partida_Codigo) <= 1 begin
	    SET @mensaje='Ya registraste este numero de partida'; 
		end
        else begin
        INSERT INTO Matrimonios VALUES (@Partida_Codigo,@Libro,@Folio,@Numero,@Fecha_Matrimonio,@Presencio,@Nombre_Novio,@Padres_Novio,@Parroquia_Novio,@Fecha_Bautismo_Novio,@Libro_H,@Folio_M,@Acta_H,
		 @Nombre_Novia,@Padres_Novia,@Parroquia_Novia,@Fecha_Bautismo_Novia,@Libro_M,@Folio_M,@Acta_M,@Testigos,@DoyFe,@NotaMarginal,@Firmante);
		SET @mensaje= 'Se ha insertado el Matrimonio';
	  end
	end
else
   if @Dato= 2 begin
      
      update Matrimonios set Fecha_Matrimonio=@Fecha_Matrimonio,Presencio= @Presencio,Nombre_Novio=@Nombre_Novio,Padres_Novio=@Padres_Novio,Parroquia_Novio=@Parroquia_Novio,
	  Fecha_Bautismo_Novio=@Fecha_Bautismo_Novio,Libro_Novio=@Libro_H,Folio_Novio=@Folio_H,Acta_Novio=@Acta_H,Novia=@Nombre_Novia,Padres_Novia=@Padres_Novia,
	  Parroquia_Novia=@Parroquia_Novia,Fecha_Bautismo_Novia=@Fecha_Bautismo_Novia,Libro_Novia=@Libro_M,Folio_Novia=@Folio_M,Acta_Novia=@Acta_M,Testigos=@Testigos,
	  Doy_Fe=@DoyFe,Nota_Marginal=@NotaMarginal,Firmante=@Firmante WHERE Codigo_Partida=@Partida_Codigo
	  SET @mensaje = 'Se ha actualizado la partida'
	  end

	if @Dato = 3 begin

	  Delete FROM Matrimonios WHERE Codigo_Partida= @Partida_Codigo
	  set @mensaje= 'Se ha eliminado el matrimonio';

	end
 end
GO
/****** Object:  StoredProcedure [dbo].[PMinistros]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PMinistros]
@Dato int,
@Id int,
@Nombre nvarchar(50),
@Cargo nvarchar(50),
@mensaje varchar(100) out
AS
begin 
if @Dato=1 begin  
        INSERT INTO Ministros_Firmantes VALUES (@Nombre,@Cargo);
		SET @mensaje= 'Se ha insertado el ministro';
	  
	end
else
   if @Dato= 2 begin
      
      update Ministros_Firmantes set Nombre_Firmante= @Nombre,Cargo=@Cargo
	  WHERE Id_Firmante=@Id
	  SET @mensaje = 'Se ha actualizado el ministro'
	  end
	  else
	  if (@Dato =3) begin
	  select * FROM Ministros_Firmantes where Id_Firmante = @Id
	  end
 end
GO
/****** Object:  StoredProcedure [dbo].[ReporteBautismo]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ReporteBautismo]
@Codigo nvarchar(15)
AS
SELECT Codigo_Partida,Libro,Folio,Numero,Nombre_Niño,Fecha_Bautismo,Ministro,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,
Abuelos_Paternos,Abuelos_Maternos,Padrinos,Doy_Fe.Nombre_Firmante,Nota_Marginal,Ministros_Firmantes.Nombre_Firmante,Ministros_Firmantes.Cargo  FROM Bautismos
LEFT join Doy_Fe on Bautismos.Doy_Fe = Doy_Fe.Id_Firmante
LEFT JOIN Ministros_Firmantes on Bautismos.Firmante = Ministros_Firmantes.Id_Firmante
WHERE Codigo_Partida= @Codigo
GO
/****** Object:  StoredProcedure [dbo].[ReporteConfirmacion]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ReporteConfirmacion]
@Codigo nvarchar(20)
AS
Select Codigo_Partida,libro,Folio,Numero,Fecha_Confirmacion,Nombre_Confirmado,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,Parroquia_Bautizo,Diocesis,
Fecha_Bautismo,Libro_B,Folio_B,Numero_B,Padrinos,Ministro,Doy_Fe,Notas_Correcciones,Ministros_Firmantes.Nombre_Firmante,Ministros_Firmantes.Cargo From Confirmaciones
INNER JOIN Ministros_Firmantes on Confirmaciones.Firmante = Ministros_Firmantes.Id_Firmante
where Codigo_Partida= @Codigo








































GO
/****** Object:  StoredProcedure [dbo].[ReporteDefuncion]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ReporteDefuncion]
@NoDefuncion nvarchar(20)
AS
Select No_Defuncion,Libro,Folio,Numero,Fecha_Sepelio,Nombre_Difunto,Ciudad_Origenv,Edad,
Padres,Estado_Civil,Ocacion_Muerte,Doy_Fe,Ministros_Firmantes.Nombre_Firmante,Ministros_Firmantes.Cargo,NotaMarginal From Defunciones
LEFT JOIN Ministros_Firmantes on Defunciones.Firmante = Ministros_Firmantes.Id_Firmante
WHERE No_Defuncion=@NoDefuncion
GO
/****** Object:  StoredProcedure [dbo].[ReporteMatrimonio]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ReporteMatrimonio]
@Codigo nvarchar(15)
AS
SELECT Codigo_Partida,Libro,Folio ,Numero,Fecha_Matrimonio, Presencio, Nombre_Novio,Padres_Novio, Parroquia_Novio,Fecha_Bautismo_Novio,Libro_Novio,Folio_Novio,Acta_Novio,
Novia,Padres_Novia,Parroquia_Novia,Fecha_Bautismo_Novia,Libro_Novia,Folio_Novia,Acta_Novia,Testigos,Doy_Fe.Nombre_Firmante,Nota_Marginal,Ministros_Firmantes.Nombre_Firmante,Cargo FROM Matrimonios
left JOIN Ministros_Firmantes ON Matrimonios.Firmante = Ministros_Firmantes.Id_Firmante
left Join Doy_Fe  on Doy_Fe = Doy_Fe.Id_Firmante
WHERE Codigo_Partida = @Codigo
GO
/****** Object:  StoredProcedure [dbo].[TraerRegistroB]    Script Date: 7/6/2021 1:13:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TraerRegistroB]
@Codigo varchar(100)
AS
SELECT Codigo_Partida,Libro,Folio,Numero,Nombre_Niño,Fecha_Bautismo,Ministro,Lugar_Nacimiento,Fecha_Nacimiento,Nombre_Padres,Abuelos_Paternos,
Abuelos_Maternos,Padrinos,Doy_Fe,Doy_Fe.Nombre_Firmante,Nota_Marginal,Ministros_Firmantes.Id_Firmante,Ministros_Firmantes.Nombre_Firmante
FROM Bautismos
INNER JOIN Doy_Fe on Doy_Fe = Doy_Fe.Id_Firmante
INNER JOIN Ministros_Firmantes on Firmante = Ministros_Firmantes.Id_Firmante
WHERE Codigo_Partida =@Codigo
GO
USE [master]
GO
ALTER DATABASE [Parroquia] SET  READ_WRITE 
GO
