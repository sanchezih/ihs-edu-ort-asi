/******************************************************************************/
/* NOMBRE:       sigal_create_tables.sql                                      */
/* DESCRIPCION:  Script que crea en la base de datos las tablas del modelo    */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/02/09                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/

USE SIGAL
GO

-- TABLAS SIN CAMPOS FORANEOS

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla PAIS                                        */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.PAIS
(
	cd_pais   INT CHECK (cd_pais > 0) PRIMARY KEY,
	desc_pais NVARCHAR(100) UNIQUE NOT NULL
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla LOCALIDAD                                   */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.LOCALIDAD
(
	cd_localidad   INT CHECK (cd_localidad > 0) PRIMARY KEY,
	desc_localidad NVARCHAR(100) UNIQUE NOT NULL
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ROL                                         */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.ROL
(
	cd_rol   INT CHECK (cd_rol > 0) PRIMARY KEY,
	desc_rol NVARCHAR(100) UNIQUE NOT NULL
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ESTADO_ALUMNO                               */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.ESTADO_ALUMNO
(
	cd_estado_alumno   INT CHECK (cd_estado_alumno > 0) PRIMARY KEY,
	desc_estado_alumno NVARCHAR(100) UNIQUE NOT NULL
)
ON Alumnos;


/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ESTADO_MATERIA                              */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.ESTADO_MATERIA
(
	cd_estado_materia	NVARCHAR(3) PRIMARY KEY,
	desc_estado_materia	NVARCHAR(100) UNIQUE NOT NULL
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ESTADO_GENERAL                              */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.ESTADO_GENERAL
(
	cd_estado_general   NVARCHAR(1) PRIMARY KEY,
	desc_estado_general NVARCHAR(100) UNIQUE NOT NULL
)
ON Alumnos;

-- TABLAS CON CAMPOS FORANEOS

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla MATERIA                                     */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.MATERIA
(
	cd_materia             NVARCHAR(6) PRIMARY KEY,
	nombre_materia         NVARCHAR(100) NOT NULL,
	fc_alta                DATETIME NOT NULL,
    fc_ultima_modificacion DATETIME,
    cd_estado_general      NVARCHAR(1) REFERENCES Alumnos.ESTADO_GENERAL(cd_estado_general) NOT NULL
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla PROFESOR                                    */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.PROFESOR
(
	cd_profesor            INT IDENTITY(1,1) PRIMARY KEY,
	nombre_profesor        NVARCHAR(100) NOT NULL,
	apellido_profesor      NVARCHAR(100) NOT NULL,
	email_profesor         NVARCHAR(100) NOT NULL,
	fc_alta                DATETIME NOT NULL,
    fc_ultima_modificacion DATETIME,
    cd_estado_general      NVARCHAR(1) REFERENCES Alumnos.ESTADO_GENERAL(cd_estado_general) NOT NULL
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla PLAN_ESTUDIO                                */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.PLAN_ESTUDIO
(
	cd_plan_estudio        NVARCHAR(6) PRIMARY KEY,
	titulo                 NVARCHAR(100) NOT NULL,
	fc_alta                DATETIME NOT NULL,
    fc_ultima_modificacion DATETIME,
    cd_estado_general      NVARCHAR(1) REFERENCES Alumnos.ESTADO_GENERAL(cd_estado_general) NOT NULL
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla USUARIO                                     */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.USUARIO
(
	cd_usuario			   NVARCHAR(100) PRIMARY KEY,
	cd_rol                 INT REFERENCES Alumnos.ROL(cd_rol) NOT NULL,
	password_usuario       NVARCHAR(100) NOT NULL,
	fc_alta                DATETIME NOT NULL,
	fc_ultima_modificacion DATETIME,
    cd_estado_general      NVARCHAR(1) REFERENCES Alumnos.ESTADO_GENERAL(cd_estado_general) NOT NULL
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ALUMNO                                      */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.ALUMNO
(
	cd_alumno              INT IDENTITY (1000,1) PRIMARY KEY,
	nombre_alumno          NVARCHAR(100) NOT NULL,
	apellido_alumno        NVARCHAR(100) NOT NULL,
	tipo_doc_alumno        NVARCHAR(3) CHECK (tipo_doc_alumno IN ('DNI', 'CI')) NOT NULL,
	nro_doc_alumno         INT CHECK (nro_doc_alumno BETWEEN 1000 AND 999999999) NOT NULL,
	fc_nacimiento          DATETIME CHECK (fc_nacimiento >= '1900/01/01') NOT NULL,
	sexo                   NVARCHAR(9) CHECK (sexo = 'Femenino' OR sexo = 'Masculino') NOT NULL,
	cd_pais                INT REFERENCES Alumnos.PAIS(cd_pais) NOT NULL,
	direccion_alumno       NVARCHAR(100) NOT NULL,
	piso_alumno            NVARCHAR(3),
	departamento_alumno    NVARCHAR(3),
	cd_postal              NVARCHAR(8) NOT NULL,
	cd_localidad           INT REFERENCES Alumnos.LOCALIDAD(cd_localidad) NOT NULL,
	tel1_alumno            NVARCHAR(15) NOT NULL,
	email_alumno	       NVARCHAR(100) NOT NULL,
	cd_estado_alumno       INT REFERENCES Alumnos.ESTADO_ALUMNO(cd_estado_alumno) NOT NULL,
	fc_alta                DATETIME NOT NULL,
	fc_ultima_modificacion DATETIME
	CONSTRAINT tipo_nro_doc_UNIQUE UNIQUE (tipo_doc_alumno, nro_doc_alumno)
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla CORRELATIVIDAD                              */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.CORRELATIVIDAD
(
	cd_plan_estudio	       NVARCHAR(6) REFERENCES Alumnos.PLAN_ESTUDIO(cd_plan_estudio),
	cd_materia			   NVARCHAR(6) REFERENCES Alumnos.MATERIA(cd_materia),
	cd_materia_correlativa NVARCHAR(6) REFERENCES Alumnos.MATERIA(cd_materia)
	PRIMARY KEY(cd_plan_estudio, cd_materia, cd_materia_correlativa)
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla CURSO                                       */
/*----------------------------------------------------------------------------*/

-- Poner un cartel al ingresar el primer alumno

CREATE TABLE Alumnos.CURSO
(
	cd_curso         INT PRIMARY KEY,
	cd_materia       NVARCHAR(6) REFERENCES Alumnos.MATERIA(cd_materia) NOT NULL,
	cd_profesor      INT REFERENCES Alumnos.PROFESOR(cd_profesor) NOT NULL,
	cd_plan_estudio  NVARCHAR(6) REFERENCES Alumnos.PLAN_ESTUDIO(cd_plan_estudio) NOT NULL,
	semestre		 INT CHECK (semestre = 1 OR semestre = 2) NOT NULL,
	anio             INT CHECK (anio BETWEEN 2005 AND 3000) NOT NULL,
	fc_alta          DATETIME NOT NULL,
	fc_baja          DATETIME
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ACTA_CURSADA                                */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.ACTA_CURSADA
(
	cd_alumno			   INT REFERENCES Alumnos.ALUMNO (cd_alumno),
	libro				   NVARCHAR(6) NOT NULL,
	folio				   NVARCHAR(6) NOT NULL,
	cd_curso			   INT REFERENCES Alumnos.CURSO (cd_curso) NOT NULL,
	cd_plan_estudio		   NVARCHAR(6) REFERENCES Alumnos.PLAN_ESTUDIO (cd_plan_estudio) NOT NULL,
	calificacion		   INT CHECK (calificacion BETWEEN 0 AND 10) NOT NULL,
	base_calificacion	   NVARCHAR(3) CHECK (base_calificacion IN ('CUR', 'PRO', 'LIB', 'EQ')) NOT NULL,
	fc_alta                DATETIME NOT NULL,
	fc_ultima_modificacion DATETIME
	PRIMARY KEY(cd_alumno, cd_curso)
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ACTA_FINAL                                  */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.ACTA_FINAL
(
	cd_alumno			   INT REFERENCES Alumnos.ALUMNO(cd_alumno),
	libro				   NVARCHAR(6) NOT NULL,
	folio				   NVARCHAR(6) NOT NULL,
	cd_curso			   INT REFERENCES Alumnos.CURSO (cd_curso) NOT NULL,
	cd_plan_estudio		   NVARCHAR(6) REFERENCES Alumnos.PLAN_ESTUDIO(cd_plan_estudio) NOT NULL,
	calificacion		   INT CHECK (calificacion BETWEEN 0 AND 10),
	fc_alta                DATETIME NOT NULL,
	fc_ultima_modificacion DATETIME,
    instancia              INT CHECK (instancia IN(1, 2, 3))
	PRIMARY KEY(cd_alumno, cd_curso, instancia)
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla INSCRIPCION_CURSO                           */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.INSCRIPCION_CURSO
(
	cd_alumno            INT REFERENCES Alumnos.ALUMNO(cd_alumno) NOT NULL,
	cd_curso             INT REFERENCES Alumnos.CURSO(cd_curso) NOT NULL,
	fc_alta              DATETIME NOT NULL
	PRIMARY KEY(cd_alumno, cd_curso)
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla INSCRIPCION_PLAN                            */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.INSCRIPCION_PLAN
(
	cd_alumno       INT REFERENCES Alumnos.ALUMNO(cd_alumno) NOT NULL,
	cd_plan_estudio NVARCHAR(6) REFERENCES Alumnos.PLAN_ESTUDIO(cd_plan_estudio) NOT NULL,
	fc_alta         DATETIME NOT NULL
	PRIMARY KEY(cd_alumno, cd_plan_estudio)
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla PLAN_MATERIA_CUATRIMESTRE                   */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.PLAN_MATERIA_CUATRIMESTRE
(
	cd_plan_estudio      NVARCHAR(6) REFERENCES Alumnos.PLAN_ESTUDIO(cd_plan_estudio),
	cd_materia           NVARCHAR(6) REFERENCES Alumnos.MATERIA(cd_materia),
	cuatrimestre_carrera INT CHECK (cuatrimestre_carrera IN (1, 2, 3, 4, 5, 6))
	PRIMARY KEY (cd_plan_estudio, cd_materia, cuatrimestre_carrera)
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ALUMNO_ESTADO_MATERIA                       */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.ALUMNO_ESTADO_MATERIA
(
	cd_alumno              INT REFERENCES Alumnos.ALUMNO(cd_alumno),
	cd_materia             NVARCHAR(6) REFERENCES Alumnos.MATERIA(cd_materia),
	cd_curso               INT REFERENCES Alumnos.CURSO(cd_curso) NOT NULL,
	cd_estado_materia      NVARCHAR(3) REFERENCES Alumnos.ESTADO_MATERIA(cd_estado_materia) NOT NULL,
	fc_ultima_modificacion DATETIME NOT NULL
    PRIMARY KEY (cd_alumno, cd_materia)
)
ON Alumnos;

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla PROCESO                                     */
/*----------------------------------------------------------------------------*/

CREATE TABLE Alumnos.PROCESO
(
	nombre                 NVARCHAR(200) PRIMARY KEY,
	descripcion            NVARCHAR(1000) NOT NULL,
    fc_ultima_modificacion DATETIME
)
ON Alumnos;

PRINT getDate();
PRINT N'Se crearon las tablas de la base de datos Sigal.';
GO