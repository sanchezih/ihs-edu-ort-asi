USE SIGAL

/*----------------------------------------------------------------------------*/
/* TABLAS SIN CAMPOS FORANEOS                                                 */
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla PERIODO_INSCRIPCIONES                       */
/*----------------------------------------------------------------------------*/

CREATE TABLE PERIODO_INSCRIPCIONES(
	cd_periodo_inscripcion	NVARCHAR(10) PRIMARY KEY,
	fc_inicio				DATETIME NOT NULL,
	fc_fin					DATETIME NOT NULL
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ROL                                         */
/*----------------------------------------------------------------------------*/

CREATE TABLE ROL(
	cd_rol		SMALLINT PRIMARY KEY NOT NULL,
	desc_rol	NVARCHAR(60) NOT NULL
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ESTADO_ALUMNO                               */
/*----------------------------------------------------------------------------*/

CREATE TABLE ESTADO_ALUMNO(
	cd_estado_alumno	SMALLINT PRIMARY KEY NOT NULL,
	desc_estado_alumno	NVARCHAR(60) NOT NULL,
	fc_alta				DATETIME NOT NULL,
	fc_baja				DATETIME
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla PAIS_ORIGEN                                 */
/*----------------------------------------------------------------------------*/

CREATE TABLE PAIS_ORIGEN(
	cd_pais		INT PRIMARY KEY,
	nombre_pais	NVARCHAR(60) NOT NULL
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla PLAN_ESTUDIO                                */
/*----------------------------------------------------------------------------*/

CREATE TABLE PLAN_ESTUDIO(
	cd_plan_estudio		INT PRIMARY KEY,
	titulo				NVARCHAR(60) NOT NULL,
	fc_alta				DATETIME NOT NULL,
	fc_baja				DATETIME,
	fc_aprobacion_plan	DATETIME,
	entidad_aprobadora	NVARCHAR(60)
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla HORA_CATEDRA                                */
/*----------------------------------------------------------------------------*/

CREATE TABLE HORA_CATEDRA(
	cd_hora_catedra	NVARCHAR(1) PRIMARY KEY,
	hr_inicio		NVARCHAR(5) NOT NULL,
	hr_fin			NVARCHAR(5) NOT NULL
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ESTADO_MATERIA                              */
/*----------------------------------------------------------------------------*/

CREATE TABLE ESTADO_MATERIA(
	cd_estado_materia	NVARCHAR(3) CHECK (cd_estado_materia IN ('FAP', 'FNA', 'CAP', 'CNA', 'EQ', 'PRO')) PRIMARY KEY,
	desc_estado_materia	NVARCHAR(60) NOT NULL,
	fc_alta				DATETIME NOT NULL,
	fc_baja				DATETIME
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla CUATRIMESTRE_CURSO                          */
/*----------------------------------------------------------------------------*/

CREATE TABLE CUATRIMESTRE_CURSO(
	cd_cuatrimestre			INT PRIMARY KEY,
	fc_inicio_cuatrimestre	DATETIME NOT NULL,
	fc_fin_cuatrimestre		DATETIME NOT NULL
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla AULA                                        */
/*----------------------------------------------------------------------------*/

CREATE TABLE AULA(
	cd_aula					INT PRIMARY KEY,
	cantidad_pupitres		INT NOT NULL,
	cantidad_computadoras	INT NOT NULL,
	fc_alta					DATETIME NOT NULL,
	fc_baja					DATETIME
);

/*----------------------------------------------------------------------------*/
/* TABLAS CON CAMPOS FORANEOS                                                 */
/*----------------------------------------------------------------------------*/

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla USUARIO                                     */
/*----------------------------------------------------------------------------*/

CREATE TABLE USUARIO(
	cd_usuario			NVARCHAR(10) PRIMARY KEY,
	cd_rol				SMALLINT REFERENCES ROL(cd_rol) NOT NULL,
	password_usuario	NVARCHAR(60) NOT NULL,
	fc_alta				DATETIME NOT NULL,
	fc_baja				DATETIME
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla MATERIA                                     */
/*----------------------------------------------------------------------------*/

CREATE TABLE MATERIA(
	cd_materia		NVARCHAR(6) PRIMARY KEY,
	nombre_materia	NVARCHAR(60) NOT NULL,
	fc_alta			DATETIME NOT NULL,
	fc_baja			DATETIME
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ALUMNO                                      */
/*----------------------------------------------------------------------------*/

CREATE TABLE ALUMNO
(
	cd_alumno			NVARCHAR(6) PRIMARY KEY,
	nombre_alumno		NVARCHAR(60) NOT NULL,
	apellido_alumno		NVARCHAR(60) NOT NULL,
	tipo_doc_alumno		NVARCHAR(3) CHECK (tipo_doc_alumno IN ('DNI', 'LC', 'LE', 'PAS', 'CI')) NOT NULL,
	nro_doc_alumno		NVARCHAR(10) UNIQUE NOT NULL,
	sexo				NVARCHAR(1) CHECK (sexo = 'F' OR sexo = 'M') NOT NULL,
	cd_pais				INT REFERENCES PAIS_ORIGEN(cd_pais) NOT NULL,
	dire_alumno			NVARCHAR(80) NOT NULL,
	piso_alumno			NVARCHAR(2),
	depto_alumno		NVARCHAR(2),
	cd_postal			NVARCHAR(8) NOT NULL,
	localidad			NVARCHAR(60) NOT NULL,
	tel1_alumno			NVARCHAR(20) NOT NULL,
	tel2_alumno			NVARCHAR(20),
	email_alumno		NVARCHAR(60) NOT NULL,
	cd_estado_alumno	SMALLINT REFERENCES ESTADO_ALUMNO(cd_estado_alumno) NOT NULL,
	fc_alta				DATETIME NOT NULL,
	fc_baja				DATETIME,
	cd_usuario			NVARCHAR(10) REFERENCES USUARIO(cd_usuario)
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla PROFESOR                                    */
/*----------------------------------------------------------------------------*/

CREATE TABLE PROFESOR
(
	cd_profesor			NVARCHAR(6) PRIMARY KEY,
	nombre_profesor		NVARCHAR(60) NOT NULL,
	apellido_profesor	NVARCHAR(60) NOT NULL,
	email_profesor		NVARCHAR(60) UNIQUE NOT NULL,
	fc_alta				DATETIME NOT NULL,
	fc_baja				DATETIME,
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ADMINISTRADOR                                    */
/*----------------------------------------------------------------------------*/

CREATE TABLE ADMINISTRADOR
(
	cd_administrador		NVARCHAR(6) PRIMARY KEY,
	nombre_administrador	NVARCHAR(60) NOT NULL,
	apellido_administrador	NVARCHAR(60) NOT NULL,
	email_administrador		NVARCHAR(60) UNIQUE NOT NULL,
	fc_alta					DATETIME NOT NULL,
	fc_baja					DATETIME,
	cd_usuario				NVARCHAR(10) REFERENCES USUARIO(cd_usuario)
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla CORRELATIVA                                 */
/*----------------------------------------------------------------------------*/

CREATE TABLE CORRELATIVA(
	cd_correlatividad		INT IDENTITY (1, 1) PRIMARY KEY,
	cd_materia				NVARCHAR(6)	REFERENCES MATERIA(cd_materia) NOT NULL,
	cd_materia_correlativa	NVARCHAR(6) REFERENCES MATERIA(cd_materia),
	fc_alta					DATETIME NOT NULL,
	fc_baja					DATETIME
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ACTA                                      */
/*----------------------------------------------------------------------------*/

CREATE TABLE ACTA(
	cd_alumno			NVARCHAR(6)	REFERENCES ALUMNO(cd_alumno),
	libro				INT NOT NULL,
	folio				INT NOT NULL,
	fc_examen_final		DATETIME,
	cd_materia			NVARCHAR(6) REFERENCES MATERIA(cd_materia) NOT NULL,
	cd_estado_materia	NVARCHAR(3) REFERENCES ESTADO_MATERIA(cd_estado_materia) NOT NULL,
	cd_plan_estudio		INT REFERENCES PLAN_ESTUDIO(cd_plan_Estudio) NOT NULL,
	calificacion		SMALLINT,
	fc_alta				DATETIME NOT NULL,
	PRIMARY KEY(cd_alumno,cd_materia,cd_estado_materia,fc_examen_final)
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla CURSO                                       */
/*----------------------------------------------------------------------------*/

CREATE TABLE CURSO(
	cd_curso		NVARCHAR(6) PRIMARY KEY,
	cd_materia		NVARCHAR(6) REFERENCES MATERIA(cd_materia) NOT NULL,
	cd_aula			INT REFERENCES AULA(cd_aula) NOT NULL,
	cd_profesor		NVARCHAR(6) REFERENCES PROFESOR(cd_profesor) NOT NULL,
	cd_plan_estudio	INT REFERENCES PLAN_ESTUDIO(cd_plan_estudio) NOT NULL,
	cantidad_clases	INT NOT NULL,
	cd_cuatrimestre	INT REFERENCES CUATRIMESTRE_CURSO(cd_cuatrimestre) NOT NULL
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla CURSO_HORA_CATEDRA                          */
/*----------------------------------------------------------------------------*/

CREATE TABLE CURSO_HORA_CATEDRA(
	cd_curso		NVARCHAR(6) REFERENCES CURSO(cd_curso),
	dia_curso		NVARCHAR(9),
	cd_hora_catedra	NVARCHAR(1) REFERENCES HORA_CATEDRA(cd_hora_catedra) NOT NULL,
	PRIMARY KEY(cd_curso, dia_curso, cd_hora_catedra)
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla INSCRIPCION_MATERIA                         */
/*----------------------------------------------------------------------------*/

CREATE TABLE INSCRIPCION_MATERIA(
	cd_inscripcion_materia	INT IDENTITY (1, 1) PRIMARY KEY,
	cd_alumno				NVARCHAR(6)	REFERENCES ALUMNO(cd_alumno) NOT NULL,
	cd_curso				NVARCHAR(6) REFERENCES CURSO(cd_curso),
	cd_periodo_inscripcion	NVARCHAR(10) REFERENCES PERIODO_INSCRIPCIONES(cd_periodo_inscripcion) NOT NULL,
	fc_alta					DATETIME NOT NULL,
	fc_baja					DATETIME
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla ASISTENCIA                                  */
/*----------------------------------------------------------------------------*/

CREATE TABLE ASISTENCIA(
	cd_alumno	NVARCHAR(6)	REFERENCES ALUMNO(cd_alumno),
	cd_curso	NVARCHAR(6) REFERENCES CURSO(cd_curso),
	fc_clase	DATETIME NOT NULL,
	presente	NVARCHAR(1) CHECK(presente IN ('P', 'A')) NOT NULL,
	PRIMARY KEY (cd_alumno, cd_curso, fc_clase)
);

/*----------------------------------------------------------------------------*/
/* Creo la estructura de la tabla MATERIA_CUATRIMESTRE                        */
/*----------------------------------------------------------------------------*/

CREATE TABLE MATERIA_CUATRIMESTRE(
	cd_plan_estudio	INT REFERENCES PLAN_ESTUDIO(cd_plan_estudio),
	cd_materia		NVARCHAR(6) REFERENCES MATERIA(cd_materia),
	cuatrimestre	SMALLINT CHECK (cuatrimestre IN (1, 2, 3, 4, 5, 6)) NOT NULL,
	PRIMARY KEY (cd_plan_estudio, cd_materia, cuatrimestre)
);