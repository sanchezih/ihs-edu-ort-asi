/******************************************************************************/
/* NOMBRE:       Alumnos.USUARIO_UPDATE.sql                                   */
/* DESCRIPCION:  Stored procedure que actualiza los registros de la tabla     */
/*               Alumnos.USUARIO                                              */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
SET NOCOUNT ON;
GO

USE SIGAL
GO

IF OBJECT_ID ('Alumnos.USUARIO_UPDATE', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.USUARIO_UPDATE;
GO

EXECUTE Alumnos.PROCESO_INSERT 'USUARIO_UPDATE', 'Stored procedure que actualiza los registros de la tabla Alumnos.USUARIO.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.USUARIO_UPDATE

-- Parametros de entrada
@cd_usuario       NVARCHAR(100),
@password_usuario NVARCHAR(100)

AS
	IF NOT EXISTS (SELECT 1
                   FROM   Alumnos.USUARIO
                   WHERE  cd_usuario       = @cd_usuario
                   AND    password_usuario = @password_usuario)
	BEGIN
		DECLARE @fc_ultima_modificacion DATETIME;
		SET @fc_ultima_modificacion = getDate();

		UPDATE Sigal.Alumnos.USUARIO
		SET    password_usuario      = @password_usuario,
			   fc_ultima_modificacion = @fc_ultima_modificacion
		WHERE  cd_usuario = @cd_usuario;
		RETURN
	END
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.MATERIA_UPDATE.sql                                   */
/* DESCRIPCION:  Stored procedure que actualiza los registros de la tabla     */
/*               Alumnos.MATERIA                                              */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
SET NOCOUNT ON;
GO

USE SIGAL
GO

IF OBJECT_ID ('Alumnos.MATERIA_UPDATE', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.MATERIA_UPDATE;
GO

EXECUTE Alumnos.PROCESO_INSERT 'MATERIA_UPDATE', 'Stored procedure que actualiza los registros de la tabla Alumnos.MATERIA.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.MATERIA_UPDATE

-- Parametros de entrada
@nombre_materia    NVARCHAR(100),
@cd_estado_general NVARCHAR(1),
@cd_materia        NVARCHAR(6)

AS
	IF NOT EXISTS (SELECT 1
                   FROM   Alumnos.MATERIA
                   WHERE  nombre_materia    = @nombre_materia
                   AND    cd_estado_general = @cd_estado_general
                   AND    cd_materia        = @cd_materia)
	BEGIN
		DECLARE @fc_ultima_modificacion DATETIME;
		SET @fc_ultima_modificacion = getDate();

		UPDATE Sigal.Alumnos.MATERIA
		SET    nombre_materia         = @nombre_materia,
			   cd_estado_general      = @cd_estado_general,
			   fc_ultima_modificacion = @fc_ultima_modificacion
		WHERE  cd_materia = @cd_materia;
		RETURN
	END
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.PLAN_ESTUDIO_UPDATE.sql                              */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.PLAN_ESTUDIO_UPDATE', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.PLAN_ESTUDIO_UPDATE;
GO

EXECUTE Alumnos.PROCESO_INSERT 'PLAN_ESTUDIO_UPDATE', 'Stored procedure que actualiza los registros de la tabla Alumnos.PLAN_ESTUDIO.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.PLAN_ESTUDIO_UPDATE

-- Parametros de entrada
@titulo            NVARCHAR(100),
@cd_estado_general NVARCHAR(1),
@cd_plan_estudio   NVARCHAR(6)

AS
	IF NOT EXISTS (SELECT 1
                   FROM   Alumnos.PLAN_ESTUDIO
                   WHERE  titulo            = @titulo
                   AND    cd_estado_general = @cd_estado_general
                   AND    cd_plan_estudio   = @cd_plan_estudio)
	BEGIN
		DECLARE @fc_ultima_modificacion DATETIME;
		SET     @fc_ultima_modificacion = getDate();

		UPDATE Sigal.Alumnos.PLAN_ESTUDIO
		SET    titulo                 = @titulo,
			   cd_estado_general      = @cd_estado_general,
			   fc_ultima_modificacion = @fc_ultima_modificacion
		WHERE  cd_plan_estudio        = @cd_plan_estudio;
		RETURN
	END
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.CURSO_UPDATE.sql                                     */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.CURSO_UPDATE', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.CURSO_UPDATE;
GO

EXECUTE Alumnos.PROCESO_INSERT 'CURSO_UPDATE', 'Stored procedure que actualiza los registros de la tabla Alumnos.CURSO.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.CURSO_UPDATE

-- Parametros de entrada
@anio     INT,
@cd_curso INT

AS
	IF NOT EXISTS (SELECT 1
                   FROM   Alumnos.CURSO
                   WHERE  cd_curso = @cd_curso
                   AND  anio       = @anio)
	BEGIN
		DECLARE @fc_ultima_modificacion DATETIME;
		SET     @fc_ultima_modificacion = getDate();

		UPDATE Sigal.Alumnos.CURSO
		SET    anio = @anio
		WHERE  cd_curso        = @cd_curso;
		RETURN
	END
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.ALUMNO_UPDATE.sql                                    */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.ALUMNO_UPDATE', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.ALUMNO_UPDATE;
GO

EXECUTE Alumnos.PROCESO_INSERT 'ALUMNO_UPDATE', 'Stored procedure que actualiza los registros de la tabla Alumnos.ALUMNO.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.ALUMNO_UPDATE

-- Parametros de entrada
@cd_alumno       INT,
@nombre_alumno   NVARCHAR(100),
@apellido_alumno NVARCHAR(100),
@nro_doc_alumno      INT,
@tel1_alumno         NVARCHAR(15),
@email_alumno        NVARCHAR(100),
@direccion_alumno    NVARCHAR(100),
@piso_alumno         NVARCHAR(3),
@departamento_alumno NVARCHAR(3),
@cd_postal           NVARCHAR(8),

@tipo_doc_alumno     NVARCHAR(3),
@sexo                NVARCHAR(9),
@fc_nacimiento       DATETIME,
@cd_pais             INT,
@cd_localidad        INT

AS
	IF NOT EXISTS (SELECT 1
                   FROM   Alumnos.ALUMNO
                   WHERE  nombre_alumno       = @nombre_alumno
                   AND    cd_alumno           = @cd_alumno
                   AND    apellido_alumno     = @apellido_alumno
                   AND    nro_doc_alumno      = @nro_doc_alumno
                   AND    tel1_alumno         = @tel1_alumno
                   AND    email_alumno        = @email_alumno
                   AND    direccion_alumno    = @direccion_alumno
                   AND    piso_alumno         = @piso_alumno
                   AND    departamento_alumno = @departamento_alumno
                   AND    cd_postal           = @cd_postal
                   AND    tipo_doc_alumno     = @tipo_doc_alumno
                   AND    sexo                = @sexo
                   AND    fc_nacimiento       = @fc_nacimiento
                   AND    cd_pais             = @cd_pais
                   AND    cd_localidad        = @cd_localidad)
	BEGIN
		DECLARE @fc_ultima_modificacion DATETIME;
		SET     @fc_ultima_modificacion = getDate();

		UPDATE Sigal.Alumnos.ALUMNO
		SET    nombre_alumno          = @nombre_alumno,
			   fc_ultima_modificacion = @fc_ultima_modificacion,
               apellido_alumno        = @apellido_alumno,
               nro_doc_alumno         = @nro_doc_alumno,
               tel1_alumno            = @tel1_alumno,
               email_alumno           = @email_alumno,
               direccion_alumno       = @direccion_alumno,
               piso_alumno            = @piso_alumno,
               departamento_alumno    = @departamento_alumno,
               cd_postal              = @cd_postal,
               tipo_doc_alumno        = @tipo_doc_alumno,
               sexo                   = @sexo,
               fc_nacimiento          = @fc_nacimiento,
               cd_pais                = @cd_pais,
               cd_localidad           = @cd_localidad
		WHERE  cd_alumno              = @cd_alumno;
		RETURN
	END
GO

PRINT getDate();
PRINT N'Se crearon los stored procedures de update.';
GO