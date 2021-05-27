/******************************************************************************/
/* NOMBRE:       Alumnos.MATERIA_SEARCH.sql                                   */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
SET NOCOUNT ON;
GO

USE SIGAL
GO

IF OBJECT_ID ('Alumnos.MATERIA_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.MATERIA_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'MATERIA_SEARCH', 'Stored procedure que obtiene materias en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.MATERIA_SEARCH

-- Parametros de entrada
@cd_materia     NVARCHAR(6),
@nombre_materia NVARCHAR(100)

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE m.cd_estado_general = e.cd_estado_general'

	IF NOT @cd_materia IS NULL
		SET @criterio = @criterio + N' AND cd_materia LIKE ''%' + @cd_materia + '%'' '

	IF NOT @nombre_materia IS NULL
		SET @criterio = @criterio + N' AND nombre_materia LIKE ''%' + @nombre_materia + '%'' '

	SET @statement = 'SELECT m.cd_materia,
	                         m.nombre_materia,
							 m.fc_alta,
							 m.fc_ultima_modificacion,
                             m.cd_estado_general,
                             e.desc_estado_general
                      FROM   Alumnos.MATERIA m,
                             Alumnos.ESTADO_GENERAL e ' + @criterio

	EXEC sp_executesql @statement, N'@cd_materia NVARCHAR(6), @nombre_materia NVARCHAR(100)',
                                     @cd_materia, @nombre_materia
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.ALUMNO_SEARCH.sql                                    */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.ALUMNO_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.ALUMNO_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'ALUMNO_SEARCH', 'Stored procedure que obtiene alumnos en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.ALUMNO_SEARCH

-- Parametros de entrada
@cd_alumno       INT,
@nombre_alumno   NVARCHAR(100),
@apellido_alumno NVARCHAR(100)

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE a.cd_pais          = p.cd_pais
                       AND   a.cd_localidad     = l.cd_localidad
                       AND   a.cd_estado_alumno = ea.cd_estado_alumno '

	IF NOT @nombre_alumno IS NULL
		SET @criterio = @criterio + N' AND nombre_alumno LIKE ''%' + @nombre_alumno + '%'' '

	IF NOT @apellido_alumno IS NULL
		SET @criterio = @criterio + N' AND apellido_alumno LIKE ''%' + @apellido_alumno + '%'' '

	IF NOT @cd_alumno = 0
		--SET @criterio = @criterio + N' AND cd_alumno LIKE ''%' + @cd_alumno + '%'' '
          SET @criterio = @criterio + N' AND cd_alumno LIKE ''%' + CAST(@cd_alumno AS NVARCHAR(30)) + '%'' '

	SET @statement = 'SELECT a.cd_alumno,
                             a.nombre_alumno,
                             a.apellido_alumno,
                             a.tipo_doc_alumno,
                             a.nro_doc_alumno,
                             a.tipo_doc_alumno + '' - '' + CAST(a.nro_doc_alumno AS NVARCHAR(30)) AS documento,
                             a.fc_nacimiento,
                             a.sexo,
                             a.cd_pais,
                             a.direccion_alumno,
                             a.piso_alumno,
						     a.departamento_alumno,
							 a.cd_postal,
							 a.cd_localidad,
							 a.tel1_alumno,
							 a.email_alumno,
							 a.cd_estado_alumno,
							 a.fc_alta,
							 a.fc_ultima_modificacion,
                             p.desc_pais,
                             l.desc_localidad,
                             ea.desc_estado_alumno
                      FROM   Alumnos.ALUMNO a,
                             Alumnos.PAIS p,
                             Alumnos.LOCALIDAD l,
                             Alumnos.ESTADO_ALUMNO ea ' + @criterio

	EXEC sp_executesql @statement, N'@cd_alumno INT, @nombre_alumno NVARCHAR(100), @apellido_alumno NVARCHAR(100) ',
                                     @cd_alumno, @nombre_alumno, @apellido_alumno
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.PLAN_ESTUDIO_SEARCH.sql                              */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.PLAN_ESTUDIO_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.PLAN_ESTUDIO_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'PLAN_ESTUDIO_SEARCH', 'Stored procedure que obtiene planes en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.PLAN_ESTUDIO_SEARCH

-- Parametros de entrada
@cd_plan_estudio NVARCHAR(6),
@titulo          NVARCHAR(100)

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE p.cd_estado_general = e.cd_estado_general'

	IF NOT @cd_plan_estudio IS NULL
		SET @criterio = @criterio + N' AND cd_plan_estudio LIKE ''%' + @cd_plan_estudio + '%'' '

	IF NOT @titulo IS NULL
		SET @criterio = @criterio + N' AND titulo LIKE ''%' + @titulo + '%'' '

	SET @statement = 'SELECT p.cd_plan_estudio,
	                         p.titulo,
							 p.fc_alta,
							 p.fc_ultima_modificacion,
                             p.cd_estado_general,
                             e.desc_estado_general
                      FROM   Alumnos.PLAN_ESTUDIO p,
                             Alumnos.ESTADO_GENERAL e ' + @criterio

	EXEC sp_executesql @statement, N'@cd_plan_estudio NVARCHAR(6), @titulo NVARCHAR(100)',
                                     @cd_plan_estudio, @titulo
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.PROFESOR_SEARCH.sql                                  */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.PROFESOR_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.PROFESOR_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'PROFESOR_SEARCH', 'Stored procedure que obtiene profesores en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.PROFESOR_SEARCH

-- Parametros de entrada
@cd_profesor       INT,
@nombre_profesor   NVARCHAR(100),
@apellido_profesor NVARCHAR(100)

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE p.cd_estado_general = e.cd_estado_general'

	IF NOT @nombre_profesor IS NULL
		SET @criterio = @criterio + N' AND nombre_profesor LIKE ''%' + @nombre_profesor + '%'' '

	IF NOT @apellido_profesor IS NULL
		SET @criterio = @criterio + N' AND apellido_profesor LIKE ''%' + @apellido_profesor + '%'' '

	IF NOT @cd_profesor = 0
          SET @criterio = @criterio + N' AND cd_profesor LIKE ''%' + CAST(@cd_profesor AS NVARCHAR(30)) + '%'' '

	SET @statement = 'SELECT p.cd_profesor,
	                         p.nombre_profesor,
							 p.apellido_profesor,
                             p.email_profesor,
                             p.fc_alta,
							 p.fc_ultima_modificacion,
                             p.cd_estado_general,
                             e.desc_estado_general
                      FROM   Alumnos.PROFESOR p,
                             Alumnos.ESTADO_GENERAL e ' + @criterio

	EXEC sp_executesql @statement, N'@cd_profesor INT, @nombre_profesor NVARCHAR(100), @apellido_profesor NVARCHAR(100)',
                                     @cd_profesor, @nombre_profesor, @apellido_profesor
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.USUARIO_SEARCH.sql                                   */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.USUARIO_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.USUARIO_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'USUARIO_SEARCH', 'Stored procedure que obtiene usuarios en base a patametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.USUARIO_SEARCH

-- Parametros de entrada
@cd_usuario       NVARCHAR(100),
@password_usuario NVARCHAR(100)

AS
	SELECT u.cd_usuario,
           u.cd_rol,
           u.password_usuario,
           u.fc_alta,
           u.fc_ultima_modificacion,
           u.cd_estado_general,
           r.desc_rol,
           eg.desc_estado_general
	FROM   Alumnos.USUARIO u,
           Alumnos.ROL r,
           Alumnos.ESTADO_GENERAL eg
	WHERE  u.cd_rol = r.cd_rol
    AND    u.cd_estado_general = eg.cd_estado_general
    AND    u.cd_usuario = @cd_usuario
    AND    u.password_usuario = @password_usuario
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.CURSO_SEARCH.sql                                     */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.CURSO_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.CURSO_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'CURSO_SEARCH', 'Stored procedure que obtiene cursos en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.CURSO_SEARCH

-- Parametros de entrada
@cd_curso INT,
@estado   INT,
@anio     INT,
@materia  NVARCHAR(6),
@profesor INT

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE m.cd_materia = c.cd_materia
                       AND   p.cd_profesor = c.cd_profesor
                       AND   pe.cd_plan_estudio = c.cd_plan_estudio'

	IF NOT @profesor = 0
        SET @criterio = @criterio + N' AND c.cd_profesor LIKE ''%' + CAST(@profesor AS NVARCHAR(30)) + '%'' '

	IF NOT @cd_curso = 0
		SET @criterio = @criterio + N' AND cd_curso LIKE ''%' + CAST(@cd_curso AS NVARCHAR(30)) + '%'' '

	IF NOT @anio = 0
        SET @criterio = @criterio + N' AND anio LIKE ''%' + CAST(@anio AS NVARCHAR(30)) + '%'' '

	IF NOT @estado = 0
        SET @criterio = @criterio + N' AND fc_baja IS NULL '

	IF NOT @materia IS NULL
		SET @criterio = @criterio + N' AND c.cd_materia LIKE ''%' + @materia + '%'' '

	SET @statement = 'SELECT c.cd_curso,
	                         c.cd_materia,
							 c.cd_profesor,
							 c.cd_plan_estudio,
                             c.semestre,
                             c.anio,
                             c.fc_alta,
                             c.fc_baja,
                             m.nombre_materia,
                             CAST(p.cd_profesor AS NVARCHAR(30)) + '' - '' + p.apellido_profesor + '', '' + p.nombre_profesor as nombre_profesor,
                             pe.titulo
                      FROM   Alumnos.CURSO c,
                             Alumnos.MATERIA m,
                             Alumnos.PROFESOR p,
                             Alumnos.PLAN_ESTUDIO pe ' + @criterio
print @statement

	EXEC sp_executesql @statement, N'@cd_curso INT, @estado INT, @anio INT, @materia NVARCHAR(6)',
                                     @cd_curso, @estado, @anio, @materia
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.PMC_SEARCH.sql                                       */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.PMC_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.PMC_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'PMC_SEARCH', 'Stored procedure que obtiene asignaciones pmc en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.PMC_SEARCH

-- Parametros de entrada
@cd_plan_estudio      NVARCHAR(6),
@cuatrimestre_carrera INT

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE pmc.cd_plan_estudio = pe.cd_plan_estudio
                       AND   pmc.cd_materia = m.cd_materia'

	IF NOT @cd_plan_estudio IS NULL
		SET @criterio = @criterio + N' AND pmc.cd_plan_estudio LIKE ''%' + @cd_plan_estudio + '%'' '

	IF NOT @cuatrimestre_carrera = 0
		SET @criterio = @criterio + N' AND pmc.cuatrimestre_carrera LIKE ''%' + CAST(@cuatrimestre_carrera AS NVARCHAR(30)) + '%'' '

	SET @criterio = @criterio + N'ORDER BY pmc.cuatrimestre_carrera '

	SET @statement = 'SELECT pmc.cd_plan_estudio,
                             pe.titulo,
                             pmc.cd_materia,
                             m.nombre_materia,
                             pmc.cuatrimestre_carrera
                      FROM   Alumnos.PLAN_MATERIA_CUATRIMESTRE pmc,
                             Alumnos.MATERIA m,
                             Alumnos.PLAN_ESTUDIO pe ' + @criterio

	EXEC sp_executesql @statement, N'@cd_plan_estudio NVARCHAR(6)',
                                     @cd_plan_estudio
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.CORRELATIVIDAD_SEARCH.sql                            */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.CORRELATIVIDAD_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.CORRELATIVIDAD_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'CORRELATIVIDAD_SEARCH', 'Stored procedure que obtiene correlatividades en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.CORRELATIVIDAD_SEARCH

-- Parametros de entrada
@cd_plan_estudio NVARCHAR(6)

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE c.cd_plan_estudio = pe.cd_plan_estudio
                       AND   c.cd_materia = m.cd_materia
                       AND   c.cd_materia_correlativa = m2.cd_materia'

	IF NOT @cd_plan_estudio IS NULL
		SET @criterio = @criterio + N' AND c.cd_plan_estudio = ''' + @cd_plan_estudio + ''' '

--	SET @criterio = @criterio + N'ORDER BY pmc.cuatrimestre_carrera '

	SET @statement = 'SELECT c.cd_plan_estudio,
                             pe.titulo,
                             c.cd_materia,
                             m.nombre_materia,
                             c.cd_materia_correlativa,
                             m2.nombre_materia as correl
                      FROM   Alumnos.CORRELATIVIDAD c,
                             Alumnos.MATERIA m,
                             Alumnos.MATERIA m2,
                             Alumnos.PLAN_ESTUDIO pe ' + @criterio
print @statement
	EXEC sp_executesql @statement, N'@cd_plan_estudio NVARCHAR(6)',
                                     @cd_plan_estudio
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.INSCRIPCION_PLAN_SEARCH.sql                          */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.INSCRIPCION_PLAN_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.INSCRIPCION_PLAN_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'INSCRIPCION_PLAN_SEARCH', 'Stored procedure que obtiene inscripciones a plan en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.INSCRIPCION_PLAN_SEARCH

-- Parametros de entrada
@cd_plan_estudio NVARCHAR(6),
@cd_alumno       INT

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE a.cd_alumno = ip.cd_alumno
                       AND   ip.cd_plan_estudio = pe.cd_plan_estudio'

	IF NOT @cd_plan_estudio IS NULL
		SET @criterio = @criterio + N' AND ip.cd_plan_estudio LIKE ''%' + @cd_plan_estudio + '%'' '

	IF NOT @cd_alumno = 0
		SET @criterio = @criterio + N' AND ip.cd_alumno LIKE ''%' + CAST(@cd_alumno AS NVARCHAR(30)) + '%'' '

	SET @statement = 'SELECT ip.cd_alumno,
                             ip.cd_plan_estudio,
                             ip.fc_alta,
                             (a.apellido_alumno + '', '' + a.nombre_alumno) AS an,
                             pe.titulo
                      FROM   Alumnos.INSCRIPCION_PLAN ip,
                             Alumnos.ALUMNO a,
                             Alumnos.PLAN_ESTUDIO pe ' + @criterio

	EXEC sp_executesql @statement, N'@cd_plan_estudio NVARCHAR(6), @cd_alumno INT',
                                     @cd_plan_estudio, @cd_alumno
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.INSCRIPCION_CURSO_SEARCH.sql                         */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.INSCRIPCION_CURSO_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.INSCRIPCION_CURSO_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'INSCRIPCION_PLAN_SEARCH', 'Stored procedure que obtiene inscripciones a curso en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.INSCRIPCION_CURSO_SEARCH

-- Parametros de entrada
@cd_plan_estudio NVARCHAR(6),
@cd_curso        INT,
@cd_alumno       INT

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE ic.cd_curso      = c.cd_curso
                       AND   ic.cd_alumno     = a.cd_alumno
                       AND   c.cd_materia = m.cd_materia'

	IF NOT @cd_curso = 0
          SET @criterio = @criterio + N' AND ic.cd_curso LIKE ''%' + CAST(@cd_curso AS NVARCHAR(30)) + '%'' '

	IF NOT @cd_plan_estudio IS NULL
		SET @criterio = @criterio + N' AND c.cd_plan_estudio LIKE ''%' + @cd_plan_estudio + '%'' '

	IF NOT @cd_alumno = 0
		SET @criterio = @criterio + N' AND ic.cd_alumno LIKE ''%' + CAST(@cd_alumno AS NVARCHAR(30)) + '%'' '

	SET @statement = 'SELECT ic.cd_curso,
                             ic.cd_alumno,
                             ic.fc_alta,
                             (a.apellido_alumno + '', '' + a.nombre_alumno) AS an,
                             m.nombre_materia
                      FROM   Alumnos.INSCRIPCION_CURSO ic,
                             Alumnos.CURSO c,
                             Alumnos.ALUMNO a,
                             Alumnos.MATERIA m' + @criterio

	EXEC sp_executesql @statement, N'@cd_plan_estudio NVARCHAR(6), @cd_curso INT, @cd_alumno INT',
                                     @cd_plan_estudio, @cd_curso, @cd_alumno
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.ACTA_CURSADA_SEARCH.sql                              */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.ACTA_CURSADA_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.ACTA_CURSADA_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'ACTA_CURSADA_SEARCH', 'Stored procedure que obtiene calificaciones de cursada en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.ACTA_CURSADA_SEARCH

-- Parametros de entrada
@cd_curso  INT,
@cd_alumno INT,
@nombre_alumno   NVARCHAR(100),
@apellido_alumno NVARCHAR(100)

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE a.cd_alumno = ac.cd_alumno'

	IF NOT @cd_curso = 0
          SET @criterio = @criterio + N' AND ac.cd_curso LIKE ''%' + CAST(@cd_curso AS NVARCHAR(30)) + '%'' '

	IF NOT @cd_alumno = 0
		SET @criterio = @criterio + N' AND ac.cd_alumno LIKE ''%' + CAST(@cd_alumno AS NVARCHAR(30)) + '%'' '

	IF NOT @nombre_alumno IS NULL
		SET @criterio = @criterio + N' AND a.nombre_alumno LIKE ''%' + @nombre_alumno + '%'' '

	IF NOT @apellido_alumno IS NULL
		SET @criterio = @criterio + N' AND a.apellido_alumno LIKE ''%' + @apellido_alumno + '%'' '

	SET @statement = 'SELECT ac.cd_alumno,
                             ac.libro,
                             ac.folio,
                             ac.cd_curso,
                             ac.cd_plan_estudio,
                             ac.calificacion,
                             ac.base_calificacion,
                             ac.fc_alta,
                             ac.fc_ultima_modificacion,
                             a.apellido_alumno,
                             a.nombre_alumno,
                             (a.apellido_alumno + '', '' + a.nombre_alumno) AS an           
                      FROM   Alumnos.ACTA_CURSADA ac,
                             Alumnos.ALUMNO a ' + @criterio

	EXEC sp_executesql @statement, N'@cd_curso INT',
                                     @cd_curso
GO

--/******************************************************************************/
--/* NOMBRE:       Alumnos.ALUMNO_ESTADO_MATERIA_SEARCH.sql                     */
--/* DESCRIPCION:                                                               */
--/* AUTOR:        Ignacio Sanchez                                              */
--/* FECHA:        2009/04/26                                                   */
--/* MODIFICACION: -                                                            */
--/******************************************************************************/
--USE SIGAL
--GO
--
--IF OBJECT_ID ('Alumnos.ALUMNO_ESTADO_MATERIA_SEARCH', 'P' ) IS NOT NULL
--DROP PROCEDURE Alumnos.ALUMNO_ESTADO_MATERIA_SEARCH;
--GO
--
--EXECUTE Alumnos.PROCESO_INSERT 'ALUMNO_ESTADO_MATERIA_SEARCH', 'Stored procedure que obtiene los estados de las materias en base a parametros.'
--GO
--
--/*----------------------------------------------------------------------------*/
--/* COMIENZO                                                                   */
--/*----------------------------------------------------------------------------*/
--CREATE PROCEDURE Alumnos.ALUMNO_ESTADO_MATERIA_SEARCH
--
---- Parametros de entrada
--@cd_alumno INT
--AS
--	DECLARE @criterio  NVARCHAR(1000),
--            @statement NVARCHAR(2000)
--
--	SET @criterio = N'WHERE Alumnos.ALUMNO_ESTADO_MATERIA.cd_estado_materia = Alumnos.ESTADO_MATERIA.cd_estado_materia
--                      AND   EXISTS (SELECT  1
--                                    FROM    Alumnos.ALUMNO_ESTADO_MATERIA AS A
--                                    WHERE   Alumnos.ALUMNO_ESTADO_MATERIA.cd_alumno  = A.cd_alumno
--                                    AND     Alumnos.ALUMNO_ESTADO_MATERIA.cd_materia = A.cd_materia
--                                    GROUP   BY cd_alumno, cd_materia
--                                    HAVING  Alumnos.ALUMNO_ESTADO_MATERIA.fc_ultima_modificacion = MAX(A.fc_ultima_modificacion))'
--
--	IF NOT @cd_alumno = 0
--		SET @criterio = @criterio + N' AND cd_alumno LIKE ''%' + CAST(@cd_alumno AS NVARCHAR(30)) + '%'' '
--
--	SET @statement = 'SELECT cd_alumno,
--                             cd_materia,
--                             cd_curso,
--                             Alumnos.ALUMNO_ESTADO_MATERIA.cd_estado_materia,
--                             fc_ultima_modificacion,
--                             Alumnos.ALUMNO_ESTADO_MATERIA.cd_estado_materia + '' - '' + Alumnos.ESTADO_MATERIA.desc_estado_materia AS desc_estado_materia
--                      FROM   Alumnos.ALUMNO_ESTADO_MATERIA,
--                             Alumnos.ESTADO_MATERIA ' + @criterio
--PRINT @statement
--
--	EXEC sp_executesql @statement, N'@cd_alumno INT',
--                                     @cd_alumno
--GO

/******************************************************************************/
/* NOMBRE:       Alumnos.ALUMNO_ESTADO_MATERIA_SEARCH.sql                     */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.ALUMNO_ESTADO_MATERIA_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.ALUMNO_ESTADO_MATERIA_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'ALUMNO_ESTADO_MATERIA_SEARCH', 'Stored procedure que obtiene los estados de las materias en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.ALUMNO_ESTADO_MATERIA_SEARCH

-- Parametros de entrada
@cd_alumno       INT,
@nombre_alumno   NVARCHAR(100),
@apellido_alumno NVARCHAR(100)
AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N'WHERE aem.cd_estado_materia = Alumnos.ESTADO_MATERIA.cd_estado_materia
                      AND   aem.cd_alumno = Alumnos.ALUMNO.cd_alumno
                      AND   EXISTS (SELECT  1
                                    FROM    Alumnos.ALUMNO_ESTADO_MATERIA AS A
                                    WHERE   aem.cd_alumno  = A.cd_alumno
                                    AND     aem.cd_materia = A.cd_materia
                                    GROUP   BY cd_alumno, cd_materia
                                    HAVING  aem.fc_ultima_modificacion = MAX(A.fc_ultima_modificacion))'

	IF NOT @cd_alumno = 0
		SET @criterio = @criterio + N' AND aem.cd_alumno LIKE ''%' + CAST(@cd_alumno AS NVARCHAR(30)) + '%'' '

	IF NOT @nombre_alumno IS NULL
		SET @criterio = @criterio + N' AND Alumnos.ALUMNO.nombre_alumno LIKE ''%' + @nombre_alumno + '%'' '

	IF NOT @apellido_alumno IS NULL
		SET @criterio = @criterio + N' AND Alumnos.ALUMNO.apellido_alumno LIKE ''%' + @apellido_alumno + '%'' '


	SET @statement = 'SELECT (Alumnos.ALUMNO.apellido_alumno + '', '' + Alumnos.ALUMNO.nombre_alumno) AS an,
                             aem.cd_alumno,
                             aem.cd_materia,
                             aem.cd_curso,
                             aem.cd_estado_materia,
                             aem.fc_ultima_modificacion,
                             aem.cd_estado_materia + '' - '' + Alumnos.ESTADO_MATERIA.desc_estado_materia AS desc_estado_materia
                      FROM   Alumnos.ALUMNO_ESTADO_MATERIA aem,
                             Alumnos.ESTADO_MATERIA,
                             Alumnos.ALUMNO ' + @criterio
PRINT @statement

	EXEC sp_executesql @statement, N'@cd_alumno INT, @nombre_alumno NVARCHAR(100), @apellido_alumno NVARCHAR(100) ',
                                     @cd_alumno, @nombre_alumno, @apellido_alumno
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.ACTA_FINAL_SEARCH.sql                                */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/26                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.ACTA_FINAL_SEARCH', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.ACTA_FINAL_SEARCH;
GO

EXECUTE Alumnos.PROCESO_INSERT 'ACTA_FINAL_SEARCH', 'Stored procedure que obtiene calificaciones de final en base a parametros.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
CREATE PROCEDURE Alumnos.ACTA_FINAL_SEARCH

-- Parametros de entrada
@cd_curso        INT,
@cd_alumno       INT,
@nombre_alumno   NVARCHAR(100),
@apellido_alumno NVARCHAR(100)

AS
	DECLARE @criterio  NVARCHAR(1000),
            @statement NVARCHAR(2000)

	SET @criterio = N' WHERE a.cd_alumno = af.cd_alumno'

	IF NOT @cd_curso = 0
          SET @criterio = @criterio + N' AND af.cd_curso LIKE ''%' + CAST(@cd_curso AS NVARCHAR(30)) + '%'' '

	IF NOT @cd_alumno = 0
          SET @criterio = @criterio + N' AND af.cd_alumno LIKE ''%' + CAST(@cd_alumno AS NVARCHAR(30)) + '%'' '

	IF NOT @nombre_alumno IS NULL
		SET @criterio = @criterio + N' AND a.nombre_alumno LIKE ''%' + @nombre_alumno + '%'' '

	IF NOT @apellido_alumno IS NULL
		SET @criterio = @criterio + N' AND a.apellido_alumno LIKE ''%' + @apellido_alumno + '%'' '

	SET @statement = 'SELECT af.cd_alumno,
                             af.libro,
                             af.folio,
                             af.cd_curso,
                             af.cd_plan_estudio,
                             af.calificacion,
                             af.fc_alta,
                             af.fc_ultima_modificacion,
                             a.apellido_alumno,
                             a.nombre_alumno,
                            (a.apellido_alumno + '', '' + a.nombre_alumno) AS an
                      FROM   Alumnos.ACTA_FINAL af,
                             Alumnos.ALUMNO a' + @criterio

	EXEC sp_executesql @statement, N'@cd_curso INT, @cd_alumno INT',
                                     @cd_curso, @cd_alumno
GO

PRINT getDate();
PRINT N'Se crearon los stored procedures de busqueda.';
GO