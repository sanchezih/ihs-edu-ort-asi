/******************************************************************************/
/* NOMBRE:       Alumnos.CORRELATIVIDAD_DELETE.sql                            */
/* DESCRIPCION:  Stored procedure                                             */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
SET NOCOUNT ON;
GO

USE SIGAL
GO

IF OBJECT_ID ('Alumnos.CORRELATIVIDAD_DELETE', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.CORRELATIVIDAD_DELETE;
GO

EXECUTE Alumnos.PROCESO_INSERT 'CORRELATIVIDAD_DELETE', 'Stored procedure...'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.CORRELATIVIDAD_DELETE

-- Parametros de entrada
@cd_plan_estudio        NVARCHAR(6),
@cd_materia             NVARCHAR(6),
@cd_materia_correlativa NVARCHAR(6)

AS
	DELETE FROM Sigal.Alumnos.CORRELATIVIDAD
	WHERE  cd_plan_estudio        = @cd_plan_estudio
    AND    cd_materia             = @cd_materia
    AND    cd_materia_correlativa = @cd_materia_correlativa
	
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.CURSO_DELETE.sql                                     */
/* DESCRIPCION:  Stored procedure                                             */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.CURSO_DELETE', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.CURSO_DELETE;
GO

EXECUTE Alumnos.PROCESO_INSERT 'CURSO_DELETE', 'Stored procedure...'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.CURSO_DELETE

-- Parametros de entrada
@cd_curso INT

AS
	DELETE FROM Sigal.Alumnos.CURSO
	WHERE  cd_curso = @cd_curso	
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.PMC_DELETE.sql                                       */
/* DESCRIPCION:  Stored procedure                                             */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.PMC_DELETE', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.PMC_DELETE;
GO

EXECUTE Alumnos.PROCESO_INSERT 'PMC_DELETE', 'Stored procedure...'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.PMC_DELETE

-- Parametros de entrada
@cd_plan_estudio NVARCHAR(6),
@cd_materia      NVARCHAR(6),
@cuatrimestre    INT

AS
	DELETE FROM Sigal.Alumnos.PLAN_MATERIA_CUATRIMESTRE
	WHERE  cd_plan_estudio      = @cd_plan_estudio
    AND    cd_materia           = @cd_materia
    AND    cuatrimestre_carrera = @cuatrimestre
	
	RETURN
GO

PRINT getDate();
PRINT N'Se crearon los stored procedures de delete.';
GO