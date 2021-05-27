/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ONE_MATERIA.sql                                 */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
SET NOCOUNT ON;
GO

USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ONE_MATERIA', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ONE_MATERIA;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ONE_MATERIA', 'Stored procedure que obtiene una materia en base a la PK.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ONE_MATERIA

-- Parametros de entrada
@cd_materia NVARCHAR(6)

AS
	SELECT m.cd_materia,
           m.nombre_materia,
           m.fc_alta,
		   m.fc_ultima_modificacion,
           m.cd_estado_general,
           e.desc_estado_general
	FROM   Alumnos.MATERIA m,
           Alumnos.ESTADO_GENERAL e 
	WHERE  m.cd_estado_general = e.cd_estado_general
	AND    m.cd_materia        = @cd_materia
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ONE_PLAN.sql                                    */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ONE_PLAN', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ONE_PLAN;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ONE_PLAN', 'Stored procedure que obtiene un plan de estudio en base a la PK.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ONE_PLAN

-- Parametros de entrada
@cd_plan_estudio NVARCHAR(6)

AS
	SELECT pe.cd_plan_estudio,
           pe.titulo,
           pe.fc_alta,
		   pe.fc_ultima_modificacion,
           pe.cd_estado_general,
           e.desc_estado_general
	FROM   Alumnos.PLAN_ESTUDIO pe,
           Alumnos.ESTADO_GENERAL e 
	WHERE  pe.cd_estado_general = e.cd_estado_general
	AND    pe.cd_plan_estudio   = @cd_plan_estudio
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ONE_CURSO.sql                                   */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ONE_CURSO', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ONE_CURSO;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ONE_CURSO', 'Stored procedure que obtiene un curso en base a la PK.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ONE_CURSO

-- Parametros de entrada
@cd_curso INT

AS
	SELECT c.cd_curso,
           c.cd_materia,
           c.cd_profesor,
          (CAST(p.cd_profesor AS NVARCHAR(30)) + ' - ' + p.apellido_profesor + ', ' + p.nombre_profesor ) As nombre_profesor,
           c.cd_plan_estudio,
          (pe.cd_plan_estudio + ' - ' + pe.titulo ) As cd_plan_estudio_y_titulo,          
           c.semestre,
           c.anio,
           c.fc_alta,
           c.fc_baja,
           (m.cd_materia + ' - ' + m.nombre_materia ) As cn
    FROM   Alumnos.CURSO c,
           Alumnos.PLAN_ESTUDIO pe,
           Alumnos.PROFESOR p,
           Alumnos.MATERIA m
    WHERE  c.cd_curso         = @cd_curso
    AND    pe.cd_plan_estudio = c.cd_plan_estudio
    AND    p.cd_profesor      = c.cd_profesor
    AND    m.cd_materia       = c.cd_materia

GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ONE_ALUMNO.sql                                  */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ONE_ALUMNO', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ONE_ALUMNO;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ONE_ALUMNO', 'Stored procedure que obtiene un alumno en base a la PK.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ONE_ALUMNO

-- Parametros de entrada
@cd_alumno INT

AS
	SELECT a.*,
           p.desc_pais,
           l.desc_localidad,
           ea.desc_estado_alumno
    FROM   Alumnos.ALUMNO a,
           Alumnos.PAIS p,
           Alumnos.LOCALIDAD l,
           Alumnos.ESTADO_ALUMNO ea
    WHERE  a.cd_alumno    = @cd_alumno
    AND    a.cd_pais      = p.cd_pais
    AND    a.cd_localidad = l.cd_localidad
    AND    a.cd_estado_alumno = ea.cd_estado_alumno

GO

PRINT getDate();
PRINT N'Se crearon los stored procedures de seleccion unitaria.';
GO