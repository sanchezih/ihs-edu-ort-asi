/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ALL_ESTADO_GENERAL.sql                          */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/08                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
SET NOCOUNT ON;
GO

USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ALL_ESTADO_GENERAL', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ALL_ESTADO_GENERAL;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ALL_ESTADO_GENERAL', 'Stored procedure que obtiene todos los registros de la tabla Alumnos.ESTADO_GENERAL.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ALL_ESTADO_GENERAL
AS
	SELECT cd_estado_general,
           desc_estado_general
    FROM   Alumnos.ESTADO_GENERAL
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ALL_PAIS.sql                                    */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/10                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ALL_PAIS', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ALL_PAIS;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ALL_PAIS', 'Stored procedure que obtiene todos los registros de la tabla Alumnos.PAIS.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ALL_PAIS
AS
	SELECT cd_pais,
           desc_pais
    FROM   Alumnos.PAIS
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ALL_LOCALIDAD.sql                               */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ALL_LOCALIDAD', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ALL_LOCALIDAD;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ALL_LOCALIDAD', 'Stored procedure que obtiene todos los registros de la tabla Alumnos.LOCALIDAD.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ALL_LOCALIDAD
AS
	SELECT cd_localidad,
           desc_localidad
    FROM   Alumnos.LOCALIDAD
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_PLANES_CON_ESTADO_ALTA.sql                      */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_PLANES_CON_ESTADO_ALTA', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_PLANES_CON_ESTADO_ALTA;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_PLANES_CON_ESTADO_ALTA', 'Stored procedure que obtiene los titulos de los PE que tiene estado A.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_PLANES_CON_ESTADO_ALTA
AS
	SELECT (cd_plan_estudio + ' - ' + titulo ) As cd_plan_estudio_y_titulo,
           cd_plan_estudio,
           titulo
    FROM   Alumnos.PLAN_ESTUDIO
	WHERE  cd_estado_general = 'A'
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_PLANES.sql                                      */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_PLANES', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_PLANES;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_PLANES', 'Stored procedure...'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_PLANES
AS
	SELECT (cd_plan_estudio + ' - ' + titulo ) As cd_plan_estudio_y_titulo,
           cd_plan_estudio,
           titulo
    FROM   Alumnos.PLAN_ESTUDIO
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_PROFESORES_CON_ESTADO_ALTA.sql                  */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_PROFESORES_CON_ESTADO_ALTA', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_PROFESORES_CON_ESTADO_ALTA;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_PROFESORES_CON_ESTADO_ALTA', 'Stored procedure que obtiene los profesores que tienen estado A.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_PROFESORES_CON_ESTADO_ALTA
AS
	SELECT (CAST(cd_profesor AS NVARCHAR(30)) + ' - ' + apellido_profesor + ', ' + nombre_profesor ) As cna,
           cd_profesor,
           nombre_profesor,
           apellido_profesor
    FROM   Alumnos.PROFESOR
	WHERE  cd_estado_general = 'A'
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_MATERIAS_DE_UN_PLAN.sql                         */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_MATERIAS_DE_UN_PLAN', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_MATERIAS_DE_UN_PLAN;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_MATERIAS_DE_UN_PLAN', 'Stored procedure que restorna las materias de un plan pasado como parametro.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_MATERIAS_DE_UN_PLAN
@cd_plan_estudio NVARCHAR(6)
AS
	SELECT (m.cd_materia + ' - ' + m.nombre_materia) As cn,
           m.cd_materia,
           m.nombre_materia
    FROM   Alumnos.MATERIA m,
           Alumnos.PLAN_MATERIA_CUATRIMESTRE pmc
	WHERE  m.cd_estado_general = 'A'
    AND    m.cd_materia = pmc.cd_materia
    AND    pmc.cd_plan_estudio = @cd_plan_estudio
    ORDER BY cn
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_MATERIAS_PARA_ALTA_PMC.sql                      */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_MATERIAS_PARA_ALTA_PMC', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_MATERIAS_PARA_ALTA_PMC;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_MATERIAS_PARA_ALTA_PMC', 'Stored procedure que retorna las materias en base a un plan, para hacer asignacion PMC.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_MATERIAS_PARA_ALTA_PMC
@cd_plan_estudio      NVARCHAR(6),
@cuatrimestre_carrera INT
AS
	SELECT (m.cd_materia + ' - ' + m.nombre_materia) As cn,
           m.cd_materia,
           m.nombre_materia
    FROM   Alumnos.MATERIA m
	WHERE  m.cd_estado_general = 'A'
    AND    m.cd_materia NOT IN(SELECT pmc.cd_materia
                               FROM   Alumnos.PLAN_MATERIA_CUATRIMESTRE pmc
                               WHERE  pmc.cd_plan_estudio = @cd_plan_estudio)
    ORDER BY cn
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_MATERIAS_QUE_PUEDEN_TENER_CORREL.sql            */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_MATERIAS_QUE_PUEDEN_TENER_CORREL', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_MATERIAS_QUE_PUEDEN_TENER_CORREL;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_MATERIAS_QUE_PUEDEN_TENER_CORREL', 'Stored procedure que retorna las materias que pueden tener materias correlativas.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_MATERIAS_QUE_PUEDEN_TENER_CORREL
@cd_plan_estudio NVARCHAR(6)
AS
	SELECT (m.cd_materia + ' - ' + m.nombre_materia) As cn,
           m.cd_materia,
           m.nombre_materia
	FROM   Alumnos.MATERIA m
	WHERE  m.cd_estado_general = 'A'
	AND    m.cd_materia IN (SELECT pmc.cd_materia
                            FROM   Alumnos.PLAN_MATERIA_CUATRIMESTRE pmc
                            WHERE  pmc.cuatrimestre_carrera > 1
                            AND    pmc.cd_plan_estudio = @cd_plan_estudio)
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_MATERIAS_QUE_PUEDEN_SER_CORREL.sql              */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_MATERIAS_QUE_PUEDEN_SER_CORREL', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_MATERIAS_QUE_PUEDEN_SER_CORREL;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_MATERIAS_QUE_PUEDEN_SER_CORREL', 'Stored procedure que retorna las materias que pueden ser materias correlativas de la pasada como parametro.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_MATERIAS_QUE_PUEDEN_SER_CORREL
@cd_plan_estudio NVARCHAR(6),
@cd_materia      NVARCHAR(6)
AS

	SELECT (m.cd_materia + ' - ' + m.nombre_materia) As cn,
           m.cd_materia,
           m.nombre_materia
    FROM   Alumnos.MATERIA m
    WHERE  m.cd_materia IN(SELECT m.cd_materia
	                       FROM   Alumnos.MATERIA m,
                                  Alumnos.PLAN_MATERIA_CUATRIMESTRE pmc
                           WHERE  m.cd_materia = pmc.cd_materia
                           AND    @cd_plan_estudio = pmc.cd_plan_estudio
                           AND    pmc.cuatrimestre_carrera < (SELECT pmc.cuatrimestre_carrera
                                                              FROM   Alumnos.PLAN_MATERIA_CUATRIMESTRE pmc
                                                              WHERE  @cd_plan_estudio = pmc.cd_plan_estudio
                                                              AND    @cd_materia      = pmc.cd_materia))
    AND m.cd_materia NOT IN(SELECT c.cd_materia_correlativa
                            FROM   Alumnos.CORRELATIVIDAD c
                            WHERE  @cd_plan_estudio = c.cd_plan_estudio
                            AND    @cd_materia      = c.cd_materia)
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ALUMNOS_APTOS_INSCRIPCION_PLAN.sql              */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ALUMNOS_APTOS_INSCRIPCION_PLAN', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ALUMNOS_APTOS_INSCRIPCION_PLAN;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ALUMNOS_APTOS_INSCRIPCION_PLAN', 'Stored procedure que obtiene los nombres de los alumnos aptos para insribirse a un plan.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ALUMNOS_APTOS_INSCRIPCION_PLAN
@cd_plan_estudio NVARCHAR(6)
AS
	SELECT (CAST(cd_alumno AS NVARCHAR(30)) + ' - ' + apellido_alumno + ', ' + nombre_alumno ) As cna,
           cd_alumno,
           nombre_alumno,
           apellido_alumno
    FROM   Alumnos.ALUMNO
	WHERE  cd_estado_alumno = 1
    AND    cd_alumno NOT IN (SELECT cd_alumno
                             FROM   Alumnos.INSCRIPCION_PLAN
                             WHERE  cd_plan_estudio = @cd_plan_estudio)
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_MATERIAS_QUE_PERTENECEN_A_UN_CURSO.sql          */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_MATERIAS_QUE_PERTENECEN_A_UN_CURSO', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_MATERIAS_QUE_PERTENECEN_A_UN_CURSO;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_MATERIAS_QUE_PERTENECEN_A_UN_CURSO', 'Stored procedure que restorna las materias de un plan pasado como parametro.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_MATERIAS_QUE_PERTENECEN_A_UN_CURSO

AS
	SELECT DISTINCT(m.cd_materia + ' - ' + m.nombre_materia) As cn,
           m.cd_materia,
           m.nombre_materia
    FROM   Alumnos.MATERIA m,
           Alumnos.CURSO c
	WHERE  c.cd_materia = m.cd_materia
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_MATERIAS_QUE_TIENEN_CORREL.sql                   */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_MATERIAS_QUE_TIENEN_CORREL', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_MATERIAS_QUE_TIENEN_CORREL;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_MATERIAS_QUE_TIENEN_CORREL', 'Stored procedure que restorna las materias que tienen al menos una correlativa.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_MATERIAS_QUE_TIENEN_CORREL
@cd_plan_estudio NVARCHAR(6)

AS
	SELECT DISTINCT(m.cd_materia + ' - ' + m.nombre_materia) As cn,
           m.cd_materia,
           m.nombre_materia
    FROM   Alumnos.MATERIA m,
           Alumnos.CORRELATIVIDAD c
	WHERE  c.cd_materia = m.cd_materia
    AND    c.cd_plan_estudio = @cd_plan_estudio
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_PLANES_CON_AL_MENOS_UN_CURSO_ACTIVO.sql         */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_PLANES_CON_AL_MENOS_UN_CURSO_ACTIVO', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_PLANES_CON_AL_MENOS_UN_CURSO_ACTIVO;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_PLANES_CON_AL_MENOS_UN_CURSO_ACTIVO', 'Stored procedure que obtiene los titulos de los PE que tienen al menos un curso activo.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_PLANES_CON_AL_MENOS_UN_CURSO_ACTIVO
AS
	SELECT (pe.cd_plan_estudio + ' - ' + pe.titulo ) As cd_plan_estudio_y_titulo,
           pe.cd_plan_estudio,
           pe.titulo
    FROM   Alumnos.PLAN_ESTUDIO pe
	WHERE  pe.cd_estado_general = 'A'
    AND    pe.cd_plan_estudio IN (SELECT DISTINCT cd_plan_estudio
                                  FROM   Alumnos.CURSO
                                  WHERE  fc_baja IS NULL)
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_CURSOS_QUE_PERMITEN_INSCRIPCIONES.sql           */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_CURSOS_QUE_PERMITEN_INSCRIPCIONES', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_CURSOS_QUE_PERMITEN_INSCRIPCIONES;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_CURSOS_QUE_PERMITEN_INSCRIPCIONES', 'Stored procedure que obtiene los cursos de un plan que permiten inscripciones.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_CURSOS_QUE_PERMITEN_INSCRIPCIONES
@cd_plan_estudio NVARCHAR(6)
AS
	SELECT (CAST(c.cd_curso AS NVARCHAR(30)) + ' - ' + m.nombre_materia) as cn,
           c.cd_curso,
           c.cd_materia
     FROM  Alumnos.CURSO c,
           Alumnos.MATERIA m
    WHERE  c.cd_plan_estudio = @cd_plan_estudio
    AND    c.fc_baja IS NULL
    AND    c.cd_materia = m.cd_materia
--    AND    c.cd_curso IN (SELECT cd_curso
--                          FROM   Alumnos.CURSO c
--                          WHERE  CAST(YEAR(c.fc_alta) AS INT) = c.anio
--                          AND    (c.semestre = 1 AND (CAST(MONTH(c.fc_alta) AS INT) BETWEEN 1 AND 6)) OR
--                                 (c.semestre = 2 AND (CAST(MONTH(c.fc_alta) AS INT) BETWEEN 7 AND 12)))
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ALUMNOS_APTOS_INSCRIPCION_CURSO.sql             */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ALUMNOS_APTOS_INSCRIPCION_CURSO', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ALUMNOS_APTOS_INSCRIPCION_CURSO;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ALUMNOS_APTOS_INSCRIPCION_CURSO', 'Stored procedure que obtiene los alumnos que se pueden inscribir a un curso.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ALUMNOS_APTOS_INSCRIPCION_CURSO

@cd_plan_estudio NVARCHAR(6),
@cd_curso        INT

AS
  
SELECT (CAST(a.cd_alumno AS NVARCHAR(30)) + ' - ' + a.apellido_alumno + ', ' + a.nombre_alumno) as cna,
       a.cd_alumno
FROM   Alumnos.ALUMNO a
WHERE  a.cd_alumno IN (SELECT ip.cd_alumno
                       FROM   Alumnos.INSCRIPCION_PLAN ip
                       WHERE  ip.cd_plan_estudio = @cd_plan_estudio)
AND    a.cd_alumno NOT IN (SELECT ic.cd_alumno
                           FROM   Alumnos.INSCRIPCION_CURSO ic
                           WHERE  ic.cd_curso = @cd_curso)
AND    NOT EXISTS (SELECT 1
                   FROM   Alumnos.MATERIA m
                   WHERE  m.cd_materia IN (SELECT co.cd_materia_correlativa
                                           FROM   Alumnos.CORRELATIVIDAD co
                                           WHERE  co.cd_plan_estudio = @cd_plan_estudio
                                           AND    co.cd_materia = (SELECT m.cd_materia
                                                                   FROM   Alumnos.MATERIA m,
                                                                          Alumnos.CURSO c
                                                                   WHERE  m.cd_materia = c.cd_materia
                                                                   AND    c.cd_curso   = @cd_curso))
                   AND    m.cd_materia NOT IN (SELECT aem.cd_materia
                                               FROM   Alumnos.ALUMNO_ESTADO_MATERIA aem   --  ,alumnos.alumno a
                                               WHERE  a.cd_alumno = aem.cd_alumno
                                               AND    aem.cd_estado_materia  IN ('FAP', 'PRO', 'EQ')))
AND    a.cd_alumno NOT IN (SELECT cd_alumno
                                          FROM   Alumnos.ALUMNO_ESTADO_MATERIA
                                          WHERE  cd_estado_materia IN ('EQ', 'CAP', 'FNA', 'FAP', 'PRO')
                                          AND    cd_materia = (SELECT m.cd_materia
                                                               FROM   Alumnos.MATERIA m,
                                                                      Alumnos.CURSO c
                                                               WHERE  m.cd_materia = c.cd_materia
                                                               AND    c.cd_curso   = @cd_curso))
                   
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_PLANES_QUE_TIENEN_CURSOS_SIN_TODAS_LAS_NOTAS    */
/*               _INFORMADAS.sql                                              */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_PLANES_QUE_TIENEN_CURSOS_SIN_TODAS_LAS_NOTAS_INFORMADAS', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_PLANES_QUE_TIENEN_CURSOS_SIN_TODAS_LAS_NOTAS_INFORMADAS;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_PLANES_QUE_TIENEN_CURSOS_SIN_TODAS_LAS_NOTAS_INFORMADAS', 'Stored procedure que obtiene los titulos de los PE que tienen cursos con alguna nota sin informar.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_PLANES_QUE_TIENEN_CURSOS_SIN_TODAS_LAS_NOTAS_INFORMADAS
AS
--	SELECT (pe.cd_plan_estudio + ' - ' + pe.titulo ) As cd_plan_estudio_y_titulo,
--           pe.cd_plan_estudio,
--           pe.titulo
--    FROM   Alumnos.PLAN_ESTUDIO pe
--	WHERE  pe.cd_estado_general = 'A'
--    AND    pe.cd_plan_estudio IN (SELECT DISTINCT c.cd_plan_estudio
--                                  FROM   Alumnos.CURSO c
--                                  WHERE  c.cd_curso IN (SELECT DISTINCT T.cd_curso
--                                                        FROM   Alumnos.INSCRIPCION_CURSO T LEFT JOIN
--                                                               Alumnos.ACTA_CURSADA T2 ON 
--                                                               T.cd_alumno = T2.cd_alumno
--                                                        AND    T.cd_curso  = T2.cd_curso
--                                                        WHERE  T2.cd_alumno IS NULL))

	SELECT (pe.cd_plan_estudio + ' - ' + pe.titulo ) As cd_plan_estudio_y_titulo,
           pe.cd_plan_estudio,
           pe.titulo
    FROM   Alumnos.PLAN_ESTUDIO pe
	WHERE  pe.cd_estado_general = 'A'



GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_CURSOS_ACTIVOS_DE_UN_PLAN.sql                   */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_CURSOS_ACTIVOS_DE_UN_PLAN', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_CURSOS_ACTIVOS_DE_UN_PLAN;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_CURSOS_ACTIVOS_DE_UN_PLAN', 'Stored procedure que obtiene los cursos activos de un plan.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_CURSOS_ACTIVOS_DE_UN_PLAN
@cd_plan_estudio NVARCHAR(6)
AS
	SELECT (CAST(c.cd_curso AS NVARCHAR(30)) + ' - ' + m.nombre_materia) as cn,
           c.cd_curso,
           c.cd_materia
    FROM   Alumnos.CURSO c,
           Alumnos.MATERIA m
    WHERE  c.cd_plan_estudio = @cd_plan_estudio
    AND    c.fc_baja IS NULL
    AND    c.cd_materia = m.cd_materia
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ALUMNOS_PARA_CALIFICACION_CURSADA.sql           */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ALUMNOS_PARA_CALIFICACION_CURSADA', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ALUMNOS_PARA_CALIFICACION_CURSADA;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ALUMNOS_PARA_CALIFICACION_CURSADA', 'Stored procedure que obtiene los alumnos de un curso que todavia no tienen nota.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ALUMNOS_PARA_CALIFICACION_CURSADA
@cd_curso INT
AS
	SELECT (CAST(a.cd_alumno AS NVARCHAR(30)) + ' - ' + a.apellido_alumno + ', ' + a.nombre_alumno) as cna,
           a.cd_alumno
    FROM   Alumnos.ALUMNO a,
           Alumnos.INSCRIPCION_CURSO ic
    WHERE  ic.cd_curso   = @cd_curso
    AND    ic.cd_alumno  = a.cd_alumno
    AND    a.cd_alumno NOT IN (SELECT ac.cd_alumno
                               FROM   Alumnos.ACTA_CURSADA ac
                               WHERE  ac.cd_curso = @cd_curso)

GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_ALUMNOS_PARA_CALIFICACION_FINAL.sql             */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_ALUMNOS_PARA_CALIFICACION_FINAL', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_ALUMNOS_PARA_CALIFICACION_FINAL;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_ALUMNOS_PARA_CALIFICACION_FINAL', 'Stored procedure que obtiene los alumnos de un curso que todavia no tienen nota de final.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_ALUMNOS_PARA_CALIFICACION_FINAL
@cd_curso INT
AS
	SELECT (CAST(a.cd_alumno AS NVARCHAR(30)) + ' - ' + a.apellido_alumno + ', ' + a.nombre_alumno) as cna,
           a.cd_alumno
    FROM   Alumnos.ALUMNO a
    WHERE  a.cd_alumno IN (SELECT cd_alumno
                           FROM   Alumnos.INSCRIPCION_CURSO
                           WHERE  cd_curso = @cd_curso)
	AND    a.cd_alumno IN (SELECT cd_alumno
                           FROM   Alumnos.ALUMNO_ESTADO_MATERIA
                           WHERE  cd_estado_materia IN ('CAP', 'FNA')
                           AND    cd_curso = @cd_curso)

GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_PROFES_QUE_DAN_ALGUN_CURSO.sql                  */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos._GET_PROFES_QUE_DAN_ALGUN_CURSO', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_PROFES_QUE_DAN_ALGUN_CURSO;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_PROFES_QUE_DAN_ALGUN_CURSO', 'Stored procedure que obtiene los...'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_PROFES_QUE_DAN_ALGUN_CURSO

AS
	SELECT (CAST(cd_profesor AS NVARCHAR(30)) + ' - ' + apellido_profesor + ', ' + nombre_profesor ) As cna,
           cd_profesor
    FROM   Alumnos.PROFESOR
    WHERE  cd_profesor IN (SELECT DISTINCT cd_profesor
                           FROM   Alumnos.curso)
GO

USE SIGAL
GO

/******************************************************************************/
/* NOMBRE:       Alumnos._GET_CURSOS_DE_PLAN_PARA_CALIF_FINAL.sql             */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/

IF OBJECT_ID ('Alumnos._GET_CURSOS_DE_PLAN_PARA_CALIF_FINAL', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos._GET_CURSOS_DE_PLAN_PARA_CALIF_FINAL;
GO

EXECUTE Alumnos.PROCESO_INSERT '_GET_CURSOS_DE_PLAN_PARA_CALIF_FINAL', 'Stored procedure que obtiene los cursos activos de un plan.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos._GET_CURSOS_DE_PLAN_PARA_CALIF_FINAL
@cd_plan_estudio NVARCHAR(6)
AS
	SELECT (CAST(c.cd_curso AS NVARCHAR(30)) + ' - ' + m.nombre_materia) as cn,
           c.cd_curso,
           c.cd_materia
    FROM   Alumnos.CURSO c,
           Alumnos.MATERIA m
    WHERE  c.cd_plan_estudio = @cd_plan_estudio
    AND    c.cd_materia      = m.cd_materia
    AND    c.cd_curso IN (SELECT cd_curso
                          FROM   Alumnos.ALUMNO_ESTADO_MATERIA
                          WHERE  cd_estado_materia IN ('FNA', 'CAP'))
GO

PRINT getDate();
PRINT N'Se crearon los stored procedures de queries.';
GO