/******************************************************************************/
/* NOMBRE:       trg_iu_acta_cursada.sql                                      */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/05/12                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.trg_iu_acta_cursada', 'TR') IS NOT NULL DROP TRIGGER Alumnos.trg_iu_acta_cursada;
GO

CREATE TRIGGER trg_iu_acta_cursada
ON Alumnos.ACTA_CURSADA
AFTER INSERT, UPDATE AS

/*----------------------------------------------------------------------------*/
/* VARIABLES                                                                  */
/*----------------------------------------------------------------------------*/
DECLARE @fc_ultima_modificacion DATETIME,
        @cd_estado_materia      NVARCHAR(3),
        @cd_alumno              INT,
        @cd_curso               INT,
        @cd_materia             NVARCHAR(6),
        @calificacion           INT,
        @base_calificacion      NVARCHAR(3)

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
SELECT @base_calificacion = i.base_calificacion,
       @calificacion      = i.calificacion,
       @cd_alumno         = i.cd_alumno,
       @cd_curso          = i.cd_curso 
FROM   INSERTED i;

-- Selecciono la materia que se da en el curso
SELECT @cd_materia = c.cd_materia
FROM   Alumnos.MATERIA m,
       Alumnos.CURSO c,
       Alumnos.ACTA_CURSADA ac
WHERE  ac.cd_curso  = c.cd_curso
AND    c.cd_materia = m.cd_materia
AND    c.cd_curso   = @cd_curso;

-- Hago las validaciones si es una nota de cursada
IF @base_calificacion = 'CUR'
BEGIN
	IF @calificacion > 3
	BEGIN
		SET @cd_estado_materia = 'CAP'
	END
	ELSE
	BEGIN
		SET @cd_estado_materia = 'CNA'
	END
END

-- Hago las validaciones si es una nota de promocion directa
IF @base_calificacion = 'PRO'
BEGIN
	SET @cd_estado_materia = @base_calificacion
END

IF @base_calificacion = 'EQ'
BEGIN
	SET @cd_estado_materia = @base_calificacion
END

IF @base_calificacion = 'LIB'
BEGIN
	SET @cd_estado_materia = @base_calificacion
END

-- Preparo las variables para hacer el INSERT en ALUMNO_ESTADO_MATERIA.

SET @fc_ultima_modificacion = getDate();

IF EXISTS (SELECT 1
           FROM   Alumnos.ALUMNO_ESTADO_MATERIA
           WHERE  cd_materia = @cd_materia
           AND    cd_alumno  = @cd_alumno)
BEGIN
	UPDATE Alumnos.ALUMNO_ESTADO_MATERIA
    SET    cd_estado_materia      = @cd_estado_materia,
           fc_ultima_modificacion = @fc_ultima_modificacion,
           cd_curso               = @cd_curso
	WHERE  cd_materia = @cd_materia
    AND    cd_alumno  = @cd_alumno 
END
ELSE
BEGIN
	INSERT INTO Sigal.Alumnos.ALUMNO_ESTADO_MATERIA
	(	
		cd_alumno,
		cd_materia,
        cd_curso,
		cd_estado_materia,
		fc_ultima_modificacion
	)
	VALUES
	(
		@cd_alumno,
		@cd_materia,
        @cd_curso,
		@cd_estado_materia,
		@fc_ultima_modificacion
	)
END

-- Hago las validaciones correspondientes para ver si tengo que dar de baja el curso

DECLARE @cant_inscriptos       INT,
        @cant_notas_ingresadas INT

SELECT @cant_inscriptos = COUNT(*)
FROM   Alumnos.INSCRIPCION_CURSO

SELECT @cant_notas_ingresadas = COUNT(*)
FROM   Alumnos.ACTA_CURSADA
WHERE  cd_curso = @cd_curso

IF @cant_inscriptos = @cant_notas_ingresadas
BEGIN
	UPDATE Alumnos.CURSO
	SET    fc_baja  = getDate()
    WHERE  cd_curso = @cd_curso
END

GO

/******************************************************************************/
/* NOMBRE:       trg_iu_inscripcion_curso.sql                                */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/05/12                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.trg_iu_inscripcion_curso', 'TR') IS NOT NULL DROP TRIGGER Alumnos.trg_iu_inscripcion_curso;
GO

CREATE TRIGGER trg_iu_inscripcion_curso
ON Alumnos.INSCRIPCION_CURSO
AFTER INSERT, UPDATE AS

/*----------------------------------------------------------------------------*/
/* VARIABLES                                                                  */
/*----------------------------------------------------------------------------*/
DECLARE @cd_alumno  INT,
        @cd_curso   INT,
        @cd_materia NVARCHAR(6),
        @cant       INT,
        @cant2      INT

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
SELECT @cd_alumno = i.cd_alumno,
       @cd_curso  = i.cd_curso 
FROM   INSERTED i;

SELECT @cd_materia = m.cd_materia
FROM   Alumnos.MATERIA m,
       Alumnos.CURSO c
WHERE  c.cd_materia = m.cd_materia
AND    c.cd_curso   = @cd_curso


SELECT @cant = COUNT(*)
FROM   Alumnos.INSCRIPCION_CURSO ic
WHERE  ic.cd_alumno = @cd_alumno
AND    ic.cd_curso IN (SELECT c.cd_curso
                       FROM   Alumnos.CURSO c
                       WHERE  c.cd_materia = @cd_materia);

SELECT @cant2 = COUNT(*)
FROM   Alumnos.ACTA_CURSADA ac
WHERE  ac.cd_alumno = @cd_alumno
AND    ac.cd_curso IN (SELECT c.cd_curso
                       FROM   Alumnos.CURSO c
                       WHERE  c.cd_materia = @cd_materia);

IF (@cant-1) <> @cant2
BEGIN
	ROLLBACK TRANSACTION
	RAISERROR (70001, 16, 1)
	RETURN
END        

GO

/******************************************************************************/
/* NOMBRE:       trg_iu_acta_final.sql                                        */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/05/12                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/
USE SIGAL
GO

IF OBJECT_ID ('Alumnos.trg_iu_acta_final', 'TR') IS NOT NULL DROP TRIGGER Alumnos.trg_iu_acta_final;
GO

CREATE TRIGGER trg_iu_acta_final
ON Alumnos.ACTA_FINAL
AFTER INSERT, UPDATE AS

/*----------------------------------------------------------------------------*/
/* VARIABLES                                                                  */
/*----------------------------------------------------------------------------*/
DECLARE @fc_ultima_modificacion DATETIME,
        @cd_estado_materia      NVARCHAR(3),
        @cd_alumno              INT,
        @cd_curso               INT,
        @cd_materia             NVARCHAR(6),
        @calificacion           INT,
        @veces                  INT

/*----------------------------------------------------------------------------*/
/* COMIENZO                                                                   */
/*----------------------------------------------------------------------------*/
SELECT @calificacion = i.calificacion,
       @cd_alumno    = i.cd_alumno,
       @cd_curso     = i.cd_curso 
FROM   INSERTED i;

-- Selecciono la materia que se da en el curso
SELECT @cd_materia = c.cd_materia
FROM   Alumnos.MATERIA m,
       Alumnos.CURSO c,
       Alumnos.ACTA_CURSADA ac
WHERE  ac.cd_curso  = c.cd_curso
AND    c.cd_materia = m.cd_materia
AND    c.cd_curso   = @cd_curso;

-- Determino si aprobo el final o no
IF @calificacion > 3
BEGIN
	SET @cd_estado_materia = 'FAP'
END
ELSE
BEGIN
	SET @cd_estado_materia = 'FNA'
END

-- Veo cuantas veces rindio ese final

SELECT @veces = COUNT(*)
FROM   Alumnos.ACTA_FINAL
WHERE  cd_alumno = @cd_alumno
AND    cd_curso  = @cd_curso

IF @veces = 3 AND @cd_estado_materia = 'FNA'
BEGIN
	SET @cd_estado_materia = 'CNA'
END

-- Preparo las variables para hacer el INSERT en ALUMNO_ESTADO_MATERIA.

SET @fc_ultima_modificacion = getDate();

IF EXISTS (SELECT 1
           FROM   Alumnos.ALUMNO_ESTADO_MATERIA
           WHERE  cd_materia = @cd_materia
           AND    cd_alumno  = @cd_alumno)
BEGIN
	UPDATE Alumnos.ALUMNO_ESTADO_MATERIA
    SET    cd_estado_materia      = @cd_estado_materia,
           fc_ultima_modificacion = @fc_ultima_modificacion
	WHERE  cd_materia = @cd_materia
    AND    cd_alumno  = @cd_alumno
    AND    cd_curso   = @cd_curso
END
ELSE
BEGIN
	INSERT INTO Sigal.Alumnos.ALUMNO_ESTADO_MATERIA
	(	
		cd_alumno,
		cd_materia,
        cd_curso,
		cd_estado_materia,
		fc_ultima_modificacion
	)
	VALUES
	(
		@cd_alumno,
		@cd_materia,
        @cd_curso,
		@cd_estado_materia,
		@fc_ultima_modificacion
	)
END
GO

PRINT getDate();
PRINT N'Se crearon los triggers para las tablas.';
GO