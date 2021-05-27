/******************************************************************************/
/* NOMBRE:       sigal_db.sql                                                 */
/* DESCRIPCION:  Script de creación de la base de datos, filegroups y         */
/*               schemas.                                                     */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/02/09                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE [master]
IF db_id('SIGAL') IS NOT NULL
DROP DATABASE SIGAL
GO

USE [master]
GO

/****** Object:  Database [Sigal]    Script Date: 02/13/2009 18:46:58 ******/
CREATE DATABASE [Sigal] ON  PRIMARY
(
	NAME = N'Sigal',
	FILENAME = N'C:\Program files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\Sigal.mdf',
	SIZE = 4096KB,
	MAXSIZE = UNLIMITED,
	FILEGROWTH = 1024KB
)
LOG ON
(
	NAME = N'Sigal_log',
	FILENAME = N'C:\Program files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\Sigal_log.ldf',
	SIZE = 1024KB,
	MAXSIZE = 2048GB,
	FILEGROWTH = 10%
)
GO

-- Creo el FILEGROUP Alumnos
ALTER DATABASE [Sigal] ADD FILEGROUP [Alumnos]
GO

-- Creo el FILE Sigal_data.mdf
ALTER DATABASE [Sigal] ADD FILE
(
	NAME='Sigal_data',
	FILENAME='C:\Program files\Microsoft SQL Server\MSSQL.1\MSSQL\Data\Sigal_data.mdf',
	SIZE=5
)
TO FILEGROUP Alumnos
GO

-- Creo el SCHEMA Alumnos
USE Sigal
GO

CREATE SCHEMA Alumnos
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sigal].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO

ALTER DATABASE [Sigal] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Sigal] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Sigal] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Sigal] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Sigal] SET ARITHABORT OFF
GO
ALTER DATABASE [Sigal] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Sigal] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Sigal] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Sigal] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Sigal] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Sigal] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Sigal] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Sigal] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Sigal] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Sigal] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Sigal] SET  ENABLE_BROKER
GO
ALTER DATABASE [Sigal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Sigal] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Sigal] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Sigal] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Sigal] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Sigal] SET  READ_WRITE
GO
ALTER DATABASE [Sigal] SET RECOVERY FULL
GO
ALTER DATABASE [Sigal] SET  MULTI_USER
GO
ALTER DATABASE [Sigal] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Sigal] SET DB_CHAINING OFF

PRINT getDate();
PRINT N'Se creo la base de datos Sigal.';
GO



/******************************************************************************/
/* NOMBRE:       Alumnos.PROCESO_INSERT.sql                                   */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/08                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO
IF OBJECT_ID ('Alumnos.PROCESO_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.PROCESO_INSERT;
GO
CREATE PROCEDURE Alumnos.PROCESO_INSERT
@nombre      NVARCHAR(200),
@descripcion NVARCHAR(1000)
AS
	DELETE FROM Alumnos.PROCESO WHERE nombre = @nombre
	DECLARE @fc_ultima_modificacion DATETIME
	SET @fc_ultima_modificacion = getDate();
	INSERT INTO Sigal.Alumnos.PROCESO
	(	
		nombre,
        descripcion,
		fc_ultima_modificacion
	)
	VALUES
	(	
		@nombre,
        @descripcion,
		@fc_ultima_modificacion
	)
    RETURN
GO