/******************************************************************************/
/* NOMBRE:       Alumnos.USUARIO_INSERT.sql                                   */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.USUARIO_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.USUARIO_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'USUARIO_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.USUARIO.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.USUARIO_INSERT

-- Parametros de entrada
@cd_usuario       NVARCHAR(100),
@password_usuario NVARCHAR(100),
@cd_rol           INT

AS
	IF EXISTS (SELECT *
               FROM   Alumnos.USUARIO
               WHERE  cd_usuario = @cd_usuario)
BEGIN
	RAISERROR (70002, 16, 1)
	RETURN
END
ELSE
BEGIN
	DECLARE @fc_alta                DATETIME,
            @fc_ultima_modificacion DATETIME,
            @cd_estado_general      NVARCHAR(1)

	SET @fc_alta                = getDate();
    SET @fc_ultima_modificacion = NULL;
    SET @cd_estado_general      = 'A';

	INSERT INTO Sigal.Alumnos.USUARIO
	(
		cd_usuario,
		password_usuario,
        cd_rol,
        fc_alta,
		fc_ultima_modificacion,
		cd_estado_general
	)
	VALUES
	(
		@cd_usuario,
		@password_usuario,
        @cd_rol,
		@fc_alta,
		@fc_ultima_modificacion,
        @cd_estado_general
	)
	RETURN
END
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.MATERIA_INSERT.sql                                   */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.MATERIA_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.MATERIA_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'MATERIA_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.MATERIA.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.MATERIA_INSERT

-- Parametros de entrada
@cd_materia     NVARCHAR(6),
@nombre_materia NVARCHAR(100)

AS
	DECLARE @fc_alta                DATETIME,
            @fc_ultima_modificacion DATETIME,
            @cd_estado_general      NVARCHAR(1)

	SET @fc_alta                = getDate();
    SET @fc_ultima_modificacion = NULL;
    SET @cd_estado_general      = 'A';

	INSERT INTO Sigal.Alumnos.MATERIA
	(
		cd_materia,
		nombre_materia,
        fc_alta,
		fc_ultima_modificacion,
		cd_estado_general
	)
	VALUES
	(
		@cd_materia,
		@nombre_materia,
		@fc_alta,
		@fc_ultima_modificacion,
        @cd_estado_general
	)
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.ALUMNO_INSERT.sql                                    */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/08/18                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.ALUMNO_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.ALUMNO_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'ALUMNO_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.ALUMNO.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.ALUMNO_INSERT

-- Parametros de entrada
@nombre_alumno       NVARCHAR(100),
@apellido_alumno     NVARCHAR(100),
@tipo_doc_alumno     NVARCHAR(3),
@nro_doc_alumno      INT,
@fc_nacimiento       DATETIME,
@sexo                NVARCHAR(9),
@cd_pais             INT,
@direccion_alumno    NVARCHAR(100),
@piso_alumno         NVARCHAR(3),
@departamento_alumno NVARCHAR(3),
@cd_postal           NVARCHAR(8),
@cd_localidad        INT,
@tel1_alumno         NVARCHAR(15),
@email_alumno	     NVARCHAR(100)

AS
	DECLARE @fc_alta                DATETIME,
            @fc_ultima_modificacion DATETIME,
            @cd_estado_alumno       INT

	SET @fc_alta                = getDate();
    SET @fc_ultima_modificacion = NULL;
    SET @cd_estado_alumno       = 1;

	INSERT INTO Sigal.Alumnos.ALUMNO
	(
        nombre_alumno,
        apellido_alumno,
        tipo_doc_alumno,
        nro_doc_alumno,
        fc_nacimiento,
        sexo,
        cd_pais,
        direccion_alumno,
        piso_alumno,
        departamento_alumno,
        cd_postal,
        cd_localidad,
        tel1_alumno,
        email_alumno,
        fc_alta,
        fc_ultima_modificacion,
        cd_estado_alumno
	)
	VALUES
	(
        @nombre_alumno,
        @apellido_alumno,
        @tipo_doc_alumno,
        @nro_doc_alumno,
        @fc_nacimiento,
        @sexo,
        @cd_pais,
        @direccion_alumno,
        @piso_alumno,
        @departamento_alumno,
        @cd_postal,
        @cd_localidad,
        @tel1_alumno,
        @email_alumno,
        @fc_alta,
        @fc_ultima_modificacion,
        @cd_estado_alumno
	)
    SELECT @@IDENTITY
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.PLAN_ESTUDIO_INSERT.sql                              */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.PLAN_ESTUDIO_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.PLAN_ESTUDIO_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'PLAN_ESTUDIO_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.PLAN_ESTUDIO.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.PLAN_ESTUDIO_INSERT

-- Parametros de entrada
@cd_plan_estudio NVARCHAR(6),
@titulo          NVARCHAR(100)

AS
	DECLARE @fc_alta                DATETIME,
            @fc_ultima_modificacion DATETIME,
            @cd_estado_general      NVARCHAR(1)

	SET @fc_alta                = getDate();
    SET @fc_ultima_modificacion = NULL;
    SET @cd_estado_general      = 'A';

	INSERT INTO Sigal.Alumnos.PLAN_ESTUDIO
	(
		cd_plan_estudio,
		titulo,
        fc_alta,
		fc_ultima_modificacion,
		cd_estado_general
	)
	VALUES
	(
		@cd_plan_estudio,
		@titulo,
		@fc_alta,
		@fc_ultima_modificacion,
        @cd_estado_general
	)
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.PROFESOR_INSERT.sql                                  */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.PROFESOR_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.PROFESOR_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'PROFESOR_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.PROFESOR.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.PROFESOR_INSERT

-- Parametros de entrada
@nombre_profesor   NVARCHAR(100),
@apellido_profesor NVARCHAR(100),
@email_profesor    NVARCHAR(100)

AS
	DECLARE @fc_alta                DATETIME,
            @fc_ultima_modificacion DATETIME,
            @cd_estado_general      NVARCHAR(1)

	SET @fc_alta                = getDate();
    SET @fc_ultima_modificacion = NULL;
    SET @cd_estado_general      = 'A';

	INSERT INTO Sigal.Alumnos.PROFESOR
	(
		nombre_profesor,
		apellido_profesor,
        email_profesor,
        fc_alta,
		fc_ultima_modificacion,
		cd_estado_general
	)
	VALUES
	(
		@nombre_profesor,
		@apellido_profesor,
        @email_profesor,
		@fc_alta,
		@fc_ultima_modificacion,
        @cd_estado_general
	)
    SELECT @@IDENTITY
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.CURSO_INSERT.sql                                     */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.CURSO_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.CURSO_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'CURSO_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.CURSO.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.CURSO_INSERT

-- Parametros de entrada
@cd_materia      NVARCHAR(6),
@cd_profesor     INT,
@cd_plan_estudio NVARCHAR(6),
@semestre        INT,
@anio            INT

AS
	DECLARE @fc_alta DATETIME,
            @fc_baja DATETIME,
            @cd      INT

	SET @fc_alta = getDate();
    SET @fc_baja = NULL;
	SET @cd      = 1;

	WHILE EXISTS (SELECT *
				  FROM   Alumnos.CURSO
				  WHERE  cd_curso = @cd)
	BEGIN
		SET @cd = @cd + 1
	END

	INSERT INTO Sigal.Alumnos.CURSO
	(
		cd_curso,
        cd_materia,
        cd_profesor,
        cd_plan_estudio,
        semestre,
        anio,
        fc_alta,
        fc_baja
	)
	VALUES
	(
        @cd,
        @cd_materia,
        @cd_profesor,
        @cd_plan_estudio,
        @semestre,
        @anio,
        @fc_alta,
        @fc_baja
	)
	SELECT @cd
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.PMC_INSERT.sql                                       */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.PMC_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.PMC_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'PMC_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.PLAN_MATERIA_CUATRIMESTRE.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.PMC_INSERT

-- Parametros de entrada
@cd_materia           NVARCHAR(6),
@cd_plan_estudio      NVARCHAR(6),
@cuatrimestre_carrera INT

AS
	INSERT INTO Sigal.Alumnos.PLAN_MATERIA_CUATRIMESTRE
	(
		cd_materia,
		cd_plan_estudio,
        cuatrimestre_carrera
	)
	VALUES
	(
		@cd_materia,
		@cd_plan_estudio,
		@cuatrimestre_carrera
	)
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.CORRELATIVIDAD_INSERT.sql                            */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.CORRELATIVIDAD_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.CORRELATIVIDAD_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'CORRELATIVIDAD_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.CORRELATIVIDAD.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.CORRELATIVIDAD_INSERT

-- Parametros de entrada
@cd_materia             NVARCHAR(6),
@cd_plan_estudio        NVARCHAR(6),
@cd_materia_correlativa NVARCHAR(6)

AS
	INSERT INTO Sigal.Alumnos.CORRELATIVIDAD
	(
		cd_materia,
		cd_plan_estudio,
        cd_materia_correlativa
	)
	VALUES
	(
		@cd_materia,
		@cd_plan_estudio,
		@cd_materia_correlativa
	)
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.INSCRIPCION_PLAN_INSERT.sql                          */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.INSCRIPCION_PLAN_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.INSCRIPCION_PLAN_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'INSCRIPCION_PLAN_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.INSCRIPCION_PLAN.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.INSCRIPCION_PLAN_INSERT

-- Parametros de entrada
@cd_alumno       INT,
@cd_plan_estudio NVARCHAR(6)

AS
	DECLARE @fc_alta DATETIME
	SET     @fc_alta = getDate();

	INSERT INTO Sigal.Alumnos.INSCRIPCION_PLAN
	(
		cd_alumno,
		cd_plan_estudio,
        fc_alta
	)
	VALUES
	(
		@cd_alumno,
		@cd_plan_estudio,
		@fc_alta
	)
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.INSCRIPCION_CURSO_INSERT.sql                         */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.INSCRIPCION_CURSO_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.INSCRIPCION_CURSO_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'INSCRIPCION_CURSO_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.INSCRIPCION_CURSO.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.INSCRIPCION_CURSO_INSERT

-- Parametros de entrada
@cd_alumno INT,
@cd_curso  INT

AS
	DECLARE @fc_alta DATETIME
	SET     @fc_alta = getDate();

	INSERT INTO Sigal.Alumnos.INSCRIPCION_CURSO
	(
		cd_alumno,
		cd_curso,
        fc_alta
	)
	VALUES
	(
		@cd_alumno,
		@cd_curso,
		@fc_alta
	)
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.ACTA_CURSADA_INSERT.sql                              */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.ACTA_CURSADA_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.ACTA_CURSADA_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'ACTA_CURSADA_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.ACTA_CURSADA.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.ACTA_CURSADA_INSERT

-- Parametros de entrada
@cd_alumno         INT,
@libro             NVARCHAR(6),
@folio             NVARCHAR(6),
@cd_curso          INT,
@cd_plan_estudio   NVARCHAR(6),
@calificacion      INT,
@base_calificacion NVARCHAR(3)

AS
	DECLARE @fc_alta                DATETIME,
            @fc_ultima_modificacion DATETIME

	SET @fc_alta                = getDate();
    SET @fc_ultima_modificacion = NULL;

	INSERT INTO Sigal.Alumnos.ACTA_CURSADA
	(
		cd_alumno,
		libro,
        folio,
        cd_curso,
        cd_plan_estudio,
        calificacion,
        base_calificacion,
        fc_alta,
        fc_ultima_modificacion
	)
	VALUES
	(
		@cd_alumno,
		@libro,
        @folio,
        @cd_curso,
        @cd_plan_estudio,
        @calificacion,
        @base_calificacion,
        @fc_alta,
        @fc_ultima_modificacion
	)
	RETURN
GO

/******************************************************************************/
/* NOMBRE:       Alumnos.ACTA_FINAL_INSERT.sql                                */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/20                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.ACTA_FINAL_INSERT', 'P' ) IS NOT NULL
DROP PROCEDURE Alumnos.ACTA_FINAL_INSERT;
GO

EXECUTE Alumnos.PROCESO_INSERT 'ACTA_FINAL_INSERT', 'Stored procedure que inserta registros en la tabla Alumnos.ACTA_FINAL.'
GO

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/

CREATE PROCEDURE Alumnos.ACTA_FINAL_INSERT

-- Parametros de entrada
@cd_alumno         INT,
@libro             NVARCHAR(6),
@folio             NVARCHAR(6),
@cd_curso          INT,
@cd_plan_estudio   NVARCHAR(6),
@calificacion      INT

AS
	DECLARE @fc_alta                DATETIME,
            @fc_ultima_modificacion DATETIME,
            @instancia              INT

	SET @fc_alta                = getDate();
    SET @fc_ultima_modificacion = NULL;
    SET @instancia              = 0;

	SELECT @instancia = (COUNT(*) + 1)
    FROM   Sigal.Alumnos.ACTA_FINAL
    WHERE  cd_alumno = @cd_alumno
    AND    cd_curso  = @cd_curso

	INSERT INTO Sigal.Alumnos.ACTA_FINAL
	(
		cd_alumno,
		libro,
        folio,
        cd_curso,
        cd_plan_estudio,
        calificacion,
        fc_alta,
        fc_ultima_modificacion,
        instancia
	)
	VALUES
	(
		@cd_alumno,
		@libro,
        @folio,
        @cd_curso,
        @cd_plan_estudio,
        @calificacion,
        @fc_alta,
        @fc_ultima_modificacion,
        @instancia
	)
	RETURN
GO

PRINT getDate();
PRINT N'Se crearon los stored procedures de insert.';
GO