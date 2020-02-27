/*----------------------------------------------------------------------------*/
/* INSERT en la tabla PERIODO_INSCRIPCIONES                                   */
/*----------------------------------------------------------------------------*/

INSERT INTO PERIODO_INSCRIPCIONES VALUES('1',	'17/02/2008', '29/02/2008');

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla ROL                                                     */
/*----------------------------------------------------------------------------*/

INSERT INTO ROL VALUES(01,	'Administrador');
INSERT INTO ROL VALUES(02,	'Alumno');

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla ESTADO_ALUMNO                                           */
/*----------------------------------------------------------------------------*/

INSERT INTO ESTADO_ALUMNO VALUES(01,	'OK',			getDate(),	NULL);
INSERT INTO ESTADO_ALUMNO VALUES(02,	'Tesoreria',	getDate(),	NULL);
INSERT INTO ESTADO_ALUMNO VALUES(03,	'Biblioteca',	getDate(),	NULL);

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla PAIS_ORIGEN                                             */
/*----------------------------------------------------------------------------*/

INSERT INTO PAIS_ORIGEN VALUES (01,	'Argentina');
INSERT INTO PAIS_ORIGEN VALUES (02,	'Bolivia');
INSERT INTO PAIS_ORIGEN VALUES (03,	'Brasil');
INSERT INTO PAIS_ORIGEN VALUES (04,	'Chile');
INSERT INTO PAIS_ORIGEN VALUES (05,	'Uruguay');
INSERT INTO PAIS_ORIGEN VALUES (06,	'Paraguay');
INSERT INTO PAIS_ORIGEN VALUES (07,	'Peru');
INSERT INTO PAIS_ORIGEN VALUES (08,	'Colombia');
INSERT INTO PAIS_ORIGEN VALUES (09,	'Venezuela');
INSERT INTO PAIS_ORIGEN VALUES (10,	'España');
INSERT INTO PAIS_ORIGEN VALUES (11,	'Italia');
INSERT INTO PAIS_ORIGEN VALUES (12,	'Inglaterra');
INSERT INTO PAIS_ORIGEN VALUES (13,	'Ecuador');
INSERT INTO PAIS_ORIGEN VALUES (14,	'Guatemala');
INSERT INTO PAIS_ORIGEN VALUES (15,	'Cuba');

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla PLAN_ESTUDIO                                            */
/*----------------------------------------------------------------------------*/

INSERT INTO PLAN_ESTUDIO VALUES (0001,	'Locutor integral de radio y TV',		getDate(),	NULL,	'15/01/2008',	'D.G.E.G.P.');
INSERT INTO PLAN_ESTUDIO VALUES (0002,	'Productor y director para radio y TV',	getDate(),	NULL,	'15/01/2008',	'D.G.E.G.P.');
INSERT INTO PLAN_ESTUDIO VALUES (0003,	'Guionista de radio y televisión',		getDate(),	NULL,	'15/01/2008',	'D.G.E.G.P.');

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla HORA_CATEDRA                                            */
/*----------------------------------------------------------------------------*/

INSERT INTO HORA_CATEDRA VALUES ('1',	'19:00', '19:40');
INSERT INTO HORA_CATEDRA VALUES ('2',	'19:40', '20:20');
INSERT INTO HORA_CATEDRA VALUES ('3',	'20:20', '21:00');
INSERT INTO HORA_CATEDRA VALUES ('4',	'21:15', '21:55');
INSERT INTO HORA_CATEDRA VALUES ('5',	'21:55', '22:35');
INSERT INTO HORA_CATEDRA VALUES ('6',	'22:35', '23:15');

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla ESTADO_MATERIA                                          */
/*----------------------------------------------------------------------------*/

INSERT INTO ESTADO_MATERIA VALUES ('FAP',	'Materia con final aprobado',				getDate(),	NULL);
INSERT INTO ESTADO_MATERIA VALUES ('FNA',	'Materia con final no aprobado',			getDate(),	NULL);
INSERT INTO ESTADO_MATERIA VALUES ('CAP',	'Materia con cursada aprobada',		    	getDate(),	NULL);
INSERT INTO ESTADO_MATERIA VALUES ('CNA',	'Materia con cursada no aprobada',		   	getDate(),	NULL);
INSERT INTO ESTADO_MATERIA VALUES ('EQ',	'Materia aprobada por equivalencia',		getDate(),	NULL);
INSERT INTO ESTADO_MATERIA VALUES ('PRO',	'Materia aprobada por promocion directa',	getDate(),	NULL);

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla CUATRIMESTRE_CURSO                                      */
/*----------------------------------------------------------------------------*/

INSERT INTO CUATRIMESTRE_CURSO VALUES (0108,	'10/03/2008',	'04/07/2008');
INSERT INTO CUATRIMESTRE_CURSO VALUES (0208,	'04/08/2008',	'28/11/2008');

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla AULA                                                    */
/*----------------------------------------------------------------------------*/

INSERT INTO AULA VALUES (1,		35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (2,		35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (3,		35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (4,		35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (5,		35,	30,	getDate(),	NULL);
INSERT INTO AULA VALUES (6,		35,	30,	getDate(),	NULL);
INSERT INTO AULA VALUES (7,		35,	30,	getDate(),	NULL);
INSERT INTO AULA VALUES (8,		35,	30,	getDate(),	NULL);
INSERT INTO AULA VALUES (9,		35,	30,	getDate(),	NULL);
INSERT INTO AULA VALUES (10,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (11,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (12,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (13,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (14,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (15,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (16,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (17,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (18,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (19,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (20,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (21,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (22,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (23,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (24,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (25,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (26,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (27,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (28,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (29,	35,	0,	getDate(),	NULL);
INSERT INTO AULA VALUES (30,	35,	0,	getDate(),	NULL);

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla USUARIO                                                 */
/*----------------------------------------------------------------------------*/

INSERT INTO USUARIO VALUES ('23543543', 01, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('26262734', 01, '123',		getDate(), NULL);
INSERT INTO USUARIO VALUES ('25231988', 01, '123',		getDate(), NULL);
INSERT INTO USUARIO VALUES ('23061254', 01,	'123',		getDate(), NULL);
INSERT INTO USUARIO VALUES ('26774903', 01, '123',		getDate(), NULL);

INSERT INTO USUARIO VALUES ('31133246', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31423654', 02, '123',		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31126029', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31826120', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31455668', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31460125', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31928130', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31900100', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31318954', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31490308', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31445006', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31444333', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31028552', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31658952', 02, '123',		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31251423', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31478920', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31524102', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31520200', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31528241', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31425011', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31582477', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31422522', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31596854', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31745874', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31444574', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31496005', 02, '123',		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31584729', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31585999', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31854802', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31852402', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31825436', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31852471', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31582475', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31721005', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31065065', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31350656', 02, '123',	 	getDate(), NULL);
INSERT INTO USUARIO VALUES ('31350645', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31638565', 02, '123',		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31326544', 02, '123', 		getDate(), NULL);
INSERT INTO USUARIO VALUES ('31654857', 02, '123', 		getDate(), NULL);

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla MATERIA                                                 */
/*----------------------------------------------------------------------------*/

INSERT INTO MATERIA VALUES ('0001',	'Composición e iluminación',						getDate(), NULL);
INSERT INTO MATERIA VALUES ('0002', 'Creatividad I',									getDate(), NULL);
INSERT INTO MATERIA VALUES ('0003', 'Creatividad II',									getDate(), NULL);
INSERT INTO MATERIA VALUES ('0004', 'Creatividad III',									getDate(), NULL);
INSERT INTO MATERIA VALUES ('0005', 'Dirección de doblaje',								getDate(), NULL);
INSERT INTO MATERIA VALUES ('0006', 'Doblaje',											getDate(), NULL);
INSERT INTO MATERIA VALUES ('0007',	'Escenografía y vestuario',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0008', 'Ética periodística',								getDate(), NULL);
INSERT INTO MATERIA VALUES ('0009', 'Expresión corporal',								getDate(), NULL);
INSERT INTO MATERIA VALUES ('0010', 'Expresión oral y escrita',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0011', 'Foniatría I',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0012', 'Foniatría II',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0013', 'Foniatría III',									getDate(), NULL);
INSERT INTO MATERIA VALUES ('0014', 'Fundamentos de tecnología',						getDate(), NULL);
INSERT INTO MATERIA VALUES ('0015', 'Generación electrónica de imagen I',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0016', 'Generación electrónica de imagen II',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0017', 'Generación electrónica de imagen III',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0018', 'Géneros literarios y audiovisuales',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0019', 'Géneros radiales y televisivos',					getDate(), NULL);
INSERT INTO MATERIA VALUES ('0020',	'Geopolítica',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0021', 'Gestión y administración de la producción',		getDate(), NULL);
INSERT INTO MATERIA VALUES ('0022', 'Guión I',											getDate(), NULL);
INSERT INTO MATERIA VALUES ('0023',	'Guión II',											getDate(), NULL);
INSERT INTO MATERIA VALUES ('0024',	'Guión III',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0025',	'Historia americana y argentina',					getDate(), NULL);
INSERT INTO MATERIA VALUES ('0026', 'Historia del arte',								getDate(), NULL);
INSERT INTO MATERIA VALUES ('0027',	'Historia del arte contemporáneo',					getDate(), NULL);
INSERT INTO MATERIA VALUES ('0028',	'Historia del espectáculo',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0029', 'Historia I',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0030',	'Historia II',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0031',	'Historia social argentina',						getDate(), NULL);
INSERT INTO MATERIA VALUES ('0032',	'Informática',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0033',	'Informática e internet',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0034',	'Inglés',											getDate(), NULL);
INSERT INTO MATERIA VALUES ('0035',	'Inglés I',											getDate(), NULL);
INSERT INTO MATERIA VALUES ('0036',	'Inglés II',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0037',	'Interpretación',									getDate(), NULL);
INSERT INTO MATERIA VALUES ('0038',	'Introducción al conocimiento musical',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0039',	'Investigación y redacción periodística',			getDate(), NULL);
INSERT INTO MATERIA VALUES ('0040', 'Lenguaje audiovisual I',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0041',	'Lenguaje audiovisual II',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0042',	'Lenguaje audiovisual III',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0043',	'Lenguaje de la música',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0044',	'Lenguaje de las artes plásticas',					getDate(), NULL);
INSERT INTO MATERIA VALUES ('0045',	'Literatura',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0046',	'Literatura dramática',								getDate(), NULL);
INSERT INTO MATERIA VALUES ('0047',	'Literatura I',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0048',	'Literatura II',									getDate(), NULL);
INSERT INTO MATERIA VALUES ('0049',	'Locución I',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0050',	'Locución II',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0051', 'Locución III',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0052',	'Metodología aplicada',								getDate(), NULL);
INSERT INTO MATERIA VALUES ('0053',	'Metodología de la investigación',					getDate(), NULL);
INSERT INTO MATERIA VALUES ('0054',	'Música',											getDate(), NULL);
INSERT INTO MATERIA VALUES ('0055',	'Oratoria',											getDate(), NULL);
INSERT INTO MATERIA VALUES ('0056',	'Planificación y gestión de medios',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0057',	'Portugués',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0058',	'Posproducción',									getDate(), NULL);
INSERT INTO MATERIA VALUES ('0059',	'Práctica integral de producción de radio I',		getDate(), NULL);
INSERT INTO MATERIA VALUES ('0060',	'Práctica integral de producción de radio II',		getDate(), NULL);
INSERT INTO MATERIA VALUES ('0061',	'Práctica integral de producción de radio III',		getDate(), NULL);
INSERT INTO MATERIA VALUES ('0062',	'Práctica integral de producción de televisión I',	getDate(), NULL);
INSERT INTO MATERIA VALUES ('0063',	'Práctica integral de producción de televisión II',	getDate(), NULL);
INSERT INTO MATERIA VALUES ('0064',	'Práctica integral de producción de televisión III',getDate(), NULL);
INSERT INTO MATERIA VALUES ('0065',	'Práctica integral de radio I',						getDate(), NULL);
INSERT INTO MATERIA VALUES ('0066',	'Práctica integral de radio II',					getDate(), NULL);
INSERT INTO MATERIA VALUES ('0067',	'Práctica integral de radio III',					getDate(), NULL);
INSERT INTO MATERIA VALUES ('0068',	'Práctica integral de televisión I',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0069',	'Práctica integral de televisión II',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0070',	'Práctica integral de televisión III',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0071',	'Principios de edición y lenguaje audiovisual',		getDate(), NULL);
INSERT INTO MATERIA VALUES ('0072',	'Principios de estética e historia del arte',		getDate(), NULL);
INSERT INTO MATERIA VALUES ('0073',	'Producción radial y televisiva',					getDate(), NULL);
INSERT INTO MATERIA VALUES ('0074',	'Pronunciación del alemán',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0075',	'Pronunciación del francés',						getDate(), NULL);
INSERT INTO MATERIA VALUES ('0076',	'Pronunciación del italiano',						getDate(), NULL);
INSERT INTO MATERIA VALUES ('0077',	'Publicidad',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0078',	'Puesta en escena',									getDate(), NULL);
INSERT INTO MATERIA VALUES ('0079',	'Radio y televisión educativa',						getDate(), NULL);
INSERT INTO MATERIA VALUES ('0080',	'Realización publicitaria',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0081',	'Redacción',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0082',	'Régimen legal de la radiodifusión',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0083',	'Seminario de creatividad',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0084',	'Seminario de industrias culturales',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0085',	'Semiología',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0086',	'Sonido y musicalización',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0087',	'Taller de escritura',								getDate(), NULL);
INSERT INTO MATERIA VALUES ('0088',	'Taller de libretos y guiones',						getDate(), NULL);
INSERT INTO MATERIA VALUES ('0089',	'Taller de práctica profesional I',					getDate(), NULL);
INSERT INTO MATERIA VALUES ('0090',	'Taller de práctica profesional II',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0091',	'Taller de práctica profesional III',				getDate(), NULL);
INSERT INTO MATERIA VALUES ('0092',	'Taller de redacción',								getDate(), NULL);
INSERT INTO MATERIA VALUES ('0093',	'Técnicas de la actuación',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0094',	'Tecnología I',										getDate(), NULL);
INSERT INTO MATERIA VALUES ('0095',	'Tecnología II',									getDate(), NULL);
INSERT INTO MATERIA VALUES ('0096',	'Televisión de exteriores',							getDate(), NULL);
INSERT INTO MATERIA VALUES ('0097',	'Teorías de la comunicación',						getDate(), NULL);

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla ALUMNO                                                  */
/*----------------------------------------------------------------------------*/

INSERT INTO ALUMNO VALUES('200001',	'Juan',			'Perez',		'DNI',	'33445689',	'M',	01,	'Correa 3454',			NULL,	NULL,	'C1659ADF',	'Capital Federal',		'47826618',	'1553132590',	'jperez@iar.com',		01,	getDate(),	NULL,	'31133246');
INSERT INTO ALUMNO VALUES('200002',	'Pedro',		'Aranda',		'DNI',	'32501560',	'M',	01,	'Sarmiento 3123',		NULL,	NULL,	'B1770FDA',	'Capital Federal',		'46204356',	'1545977487',	'paranda@iar.com',		01,	getDate(),	NULL,	'31423654');
INSERT INTO ALUMNO VALUES('200003',	'Marcos',		'Rebollido',	'DNI',	'33783988',	'M',	01,	'Vega 5324',			NULL,	NULL,	'B1854CMJ',	'Capital Federal',		'43361406',	'1550850539',	'mrebollido@iar.com',	01,	getDate(),	NULL,	'31126029');
INSERT INTO ALUMNO VALUES('200004',	'Ezequiel',		'Rodriguez',	'DNI',	'28780728',	'M',	01,	'Magnolias 2345',		NULL,	NULL,	'B1863FED',	'Capital Federal',		'49408996',	'1558328712',	'erodriguez@iar.com',	01,	getDate(),	NULL,	'31826120');
INSERT INTO ALUMNO VALUES('200005',	'Jonathan',		'Truk',			'DNI',	'32363586',	'M',	01,	'Libertador 5445',		NULL,	NULL,	'C1471ADF',	'Capital Federal',		'43788353',	'1553703228',	'jtruk@iar.com',		01,	getDate(),	NULL,	'31455668');
INSERT INTO ALUMNO VALUES('200006',	'Jacinto',		'Ramirez',		'DNI',	'34806210',	'M',	01,	'Peron 3452',			'14',	'A',	'B1429FDA',	'Capital Federal',		'46017959',	'1546478677',	'jramirez@iar.com',		01,	getDate(),	NULL,	'31460125');
INSERT INTO ALUMNO VALUES('200007',	'Federico',		'Diaz',			'DNI',	'26001863',	'M',	01,	'Calchaqui 3535',		NULL,	NULL,	'C1307CMJ',	'Capital Federal',		'44904422',	'1544545077',	'fdiaz@iar.com',		01,	getDate(),	NULL,	'31928130');
INSERT INTO ALUMNO VALUES('200008',	'Ignacio ',		'Diemel',		'DNI',	'33012350',	'M',	01,	'Rosas 934',			NULL,	NULL,	'C1507FED',	'Capital Federal',		'48410364',	'1546667021',	'idiemel@iar.com',		01,	getDate(),	NULL,	'31900100');
INSERT INTO ALUMNO VALUES('200009',	'German',		'Trovato',		'DNI',	'25723663',	'M',	01,	'Conesa 2553',			'3',	'C',	'B1411ADF',	'Capital Federal',		'44522900',	'1547071718',	'gtrovato@iar.com',		01,	getDate(),	NULL,	'31318954');
INSERT INTO ALUMNO VALUES('200010',	'Pablo',		'Gonzalez',		'DNI',	'29505475',	'M',	01,	'Rivadavia 9432',		NULL,	NULL,	'B1389FDA',	'Capital Federal',		'49809344',	'1545808743',	'pgonzalez@iar.com',	01,	getDate(),	NULL,	'31490308');
INSERT INTO ALUMNO VALUES('200011',	'Martin',		'Zibel',		'DNI',	'25349263',	'M',	01,	'Santos Dumont 2218',	NULL,	NULL,	'B1379CMJ',	'Capital Federal',		'48557872',	'1554442615',	'mzibel@iar.com',		01,	getDate(),	NULL,	'31445006');
INSERT INTO ALUMNO VALUES('200012',	'Daniel',		'Airis',		'DNI',	'30181848',	'M',	01,	'Campos 4535',			NULL,	NULL,	'B1348FED',	'Capital Federal',		'48492366',	'1550912627',	'dairis@iar.com',		01,	getDate(),	NULL,	'31444333');
INSERT INTO ALUMNO VALUES('200013',	'Maximiliano',	'Carbone',		'DNI',	'29861260',	'M',	01,	'Vidal 132',			NULL,	NULL,	'C1971ADF',	'Capital Federal',		'45905856',	'1547058488',	'mcarbone@iar.com',		01,	getDate(),	NULL,	'31028552');
INSERT INTO ALUMNO VALUES('200014',	'Hugo',			'Strujek',		'DNI',	'25753446',	'M',	01,	'Belgrano 4578',		NULL,	NULL,	'B1240FDA',	'Capital Federal',		'44685583',	'1551091411',	'hstrujek@iar.com',		01,	getDate(),	NULL,	'31658952');
INSERT INTO ALUMNO VALUES('200015',	'Jeremias',		'Fontana',		'DNI',	'32646980',	'M',	01,	'La Plata 4266',		'19',	'D'	,	'C1237CMJ',	'Capital Federal',		'43527273',	'1553095499',	'jfontana@iar.com',		01,	getDate(),	NULL,	'31251423');
INSERT INTO ALUMNO VALUES('200016',	'Gerardo',		'Maciel',		'DNI',	'30616371',	'M',	01,	'Rivadavia 15324',		NULL,	NULL,	'B1350FED',	'Capital Federal',		'47214951',	'1559453016',	'gmaciel@iar.com',		01,	getDate(),	NULL,	'31478920');
INSERT INTO ALUMNO VALUES('200017',	'Enrique',		'Otero',		'DNI',	'30225081',	'M',	01,	'Tucuman 4324',			NULL,	NULL,	'B1347ADF',	'Capital Federal',		'43608957',	'1557637307',	'eotero@iar.com',		01,	getDate(),	NULL,	'31524102');
INSERT INTO ALUMNO VALUES('200018',	'Alan',			'Ochoa',		'DNI',	'26552506',	'M',	01,	'Cochabamba 1542',		'3'	,	'B'	,	'B1727FDA',	'Olivos',				'45249712',	'1551606854',	'aochoa@iar.com',		01,	getDate(),	NULL,	'31520200');
INSERT INTO ALUMNO VALUES('200019',	'Alejandro',	'Maccio',		'DNI',	'33172136',	'M',	01,	'Paraná 6345',			NULL,	NULL,	'B1820CMJ',	'Capital Federal',		'43987442',	'1552835303',	'amaccio@iar.com',		01,	getDate(),	NULL,	'31528241');
INSERT INTO ALUMNO VALUES('200020',	'Mario',		'Marco',		'DNI',	'25893853',	'M',	01,	'Caminito 1234',		NULL,	NULL,	'B1186FED',	'Capital Federal',		'45255454',	'1557089619',	'mmarco@iar.com',		01,	getDate(),	NULL,	'31425011');
INSERT INTO ALUMNO VALUES('200021',	'Jorge',		'Loureiro',		'DNI',	'29080447',	'M',	01,	'Las Heras 5352',		NULL,	NULL,	'C1289ADF',	'Capital Federal',		'44011131',	'1548998136',	'jloureiro@iar.com',	01,	getDate(),	NULL,	'31582477');
INSERT INTO ALUMNO VALUES('200022',	'Juan ',		'Esquivel',		'DNI',	'34350940',	'M',	01,	'Cochabamba 3532',		NULL,	NULL,	'B1373FDA',	'Capital Federal',		'49825133',	'1554051295',	'nesquivel@iar.com',	01,	getDate(),	NULL,	'31422522');
INSERT INTO ALUMNO VALUES('200023',	'Mauricio',		'Politino',		'DNI',	'32206112',	'M',	01,	'Marconi 1555',			NULL,	NULL,	'B1466CMJ',	'San Martin',			'45794669',	'1551634516',	'mpolitino@iar.com',	02,	getDate(),	NULL,	'31596854');
INSERT INTO ALUMNO VALUES('200024',	'Eliseo',		'Ortiz',		'DNI',	'30698223',	'M',	01,	'Dante 2452',			NULL,	NULL,	'B1650FED',	'Caseros',				'47996636',	'1555676881',	'eortiz@iar.com',		02,	getDate(),	NULL,	'31745874');
INSERT INTO ALUMNO VALUES('200025',	'Juan',			'Baravalle',	'DNI',	'29560899',	'M',	01,	'Felix Ballester 2845',	NULL,	NULL,	'C1937ADF',	'San Martín',			'47194345',	'1549977907',	'jbaravalle@iar.com',	02,	getDate(),	NULL,	'31444574');
INSERT INTO ALUMNO VALUES('200026',	'Nataly',		'Ruggeri',		'DNI',	'25104872',	'F',	01,	'Rosario 3543',			NULL,	NULL,	'B1907FDA',	'Capital Federal',		'44094393',	'1553898393',	'nruggeri@iar.com',		02,	getDate(),	NULL,	'31496005');
INSERT INTO ALUMNO VALUES('200027',	'Mariana',		'Tedesco',		'DNI',	'32866919',	'F',	01,	'Tropezon 5245',		NULL,	NULL,	'B1655CMJ',	'Capital Federal',		'46729624',	'1545643328',	'mtedesco@iar.com',		01,	getDate(),	NULL,	'31584729');
INSERT INTO ALUMNO VALUES('200028',	'Mariela',		'Sinner',		'DNI',	'34130797',	'F',	01,	'4 de Noviembre 5020',	NULL,	NULL,	'B1979FED',	'Capital Federal',		'45221303',	'1558249961',	'msinner@iar.com',		03,	getDate(),	NULL,	'31585999');
INSERT INTO ALUMNO VALUES('200029',	'Maria',		'Anacoreto',	'DNI',	'28561740',	'F',	01,	'Almeyra 2346',			NULL,	NULL,	'C1615ADF',	'Capital Federal',		'43487770',	'1551829587',	'manacoreto@iar.com',	03,	getDate(),	NULL,	'31854802');
INSERT INTO ALUMNO VALUES('200030',	'Veronica',		'Perez',		'DNI',	'25025501',	'F',	01,	'Segurola 4245',		NULL,	NULL,	'B1841FDA',	'Capital Federal',		'43955282',	'1556200427',	'vperez@iar.com',		01,	getDate(),	NULL,	'31852402');
INSERT INTO ALUMNO VALUES('200031',	'Sabrina',		'Pisacane',		'DNI',	'27183209',	'F',	01,	'Bynnon 1424',			NULL,	NULL,	'B1726CMJ',	'Capital Federal',		'49193830',	'1547714895',	'spisacane@iar.com',	03,	getDate(),	NULL,	'31825436');
INSERT INTO ALUMNO VALUES('200032',	'Anabella',		'Tacconelli',	'DNI',	'26242665',	'F',	01,	'Avenida Córdoba 2345',	NULL,	NULL,	'B1899FED',	'Capital Federal',		'45528216',	'1552859949',	'atacconelli@iar.com',	03,	getDate(),	NULL,	'31852471');
INSERT INTO ALUMNO VALUES('200033',	'Marcela',		'Barreto',		'DNI',	'30219027',	'F',	01,	'El Parque 3235',		NULL,	NULL,	'B1284ADF',	'Capital Federal',		'45583729',	'1551777610',	'mbarreto@iar.com',		03,	getDate(),	NULL,	'31582475');
INSERT INTO ALUMNO VALUES('200034',	'Valeria',		'Lamel',		'DNI',	'30058582',	'F',	01,	'Los Pinos 2577',		NULL,	NULL,	'C1934FDA',	'Capital Federal',		'46152936',	'1550856965',	'vlamel@iar.com',		03,	getDate(),	NULL,	'31721005');
INSERT INTO ALUMNO VALUES('200035',	'Evangelina',	'Serio',		'DNI',	'32521549',	'F',	01,	'Peru 422',				NULL,	NULL,	'B1692CMJ',	'Capital Federal',		'44659004',	'1547850300',	'eserio@iar.com',		03,	getDate(),	NULL,	'31065065');
INSERT INTO ALUMNO VALUES('200036',	'Evelin',		'Luna',			'DNI',	'33609140',	'F',	01,	'Peron 2245',			NULL,	NULL,	'B1856FED',	'Capital Federal',		'49364335',	'1550001726',	'eluna@iar.com',		01,	getDate(),	NULL,	'31350656');
INSERT INTO ALUMNO VALUES('200037',	'Flavia',		'OConnor',		'DNI',	'32104215',	'F',	01,	'Madrid 6703',			NULL,	NULL,	'B1767ADF',	'Moron',				'48174809',	'1551727168',	'foconnor@iar.com',		01,	getDate(),	NULL,	'31350645');
INSERT INTO ALUMNO VALUES('200038',	'Paula',		'Miranda',		'DNI',	'25582900',	'F',	01,	'Mendoza 3245',			'14',	'C'	,	'B1682FDA',	'Capital Federal',		'47329616',	'1553539491',	'pmiranda@iar.com',		01,	getDate(),	NULL,	'31638565');
INSERT INTO ALUMNO VALUES('200039',	'Andrea',		'Villalba',		'DNI',	'29300937',	'F',	01,	'Jujuy 3688',			NULL,	NULL,	'C1263CMJ',	'Capital Federal',		'46614342',	'1552531601',	'avillalba@iar.com',	01,	getDate(),	NULL,	'31326544');
INSERT INTO ALUMNO VALUES('200040',	'Carola',		'Vazquez',		'DNI',	'34794334',	'F',	01,	'Conesa 3754',			NULL,	NULL,	'B1961FED',	'Capital Federal',		'47020416',	'1558576785',	'cvazquez@iar.com',		01,	getDate(),	NULL,	'31654857');

/*----------------------------------------------------------------------------*/                                                                                                                                                                             
/* INSERT en la tabla PROFESOR                                                */                                                                                                                                                                             
/*----------------------------------------------------------------------------*/                                                                                                                                                                             

INSERT INTO PROFESOR VALUES('300001',	'Lorena',		'Maciel',    	'lmaciel@iar.com',	 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300002',	'Patricio',		'Molina',     	'pmolina@iar.com',		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300003',	'Julieta',		'Market',     	'jmarket@iar.com',		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300004',	'Lucas',		'Aguirre',    	'laguirre@iar.com',		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300005',	'Jorge',	 	'Fren',       	'jfren@iar.com',		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300006',	'Alejandra',	'Ruiz',       	'aruiz@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300007',	'Pablo',	 	'Salas',      	'psalas@iar.com',   	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300008',	'Marcela',  	'Veiga',      	'mveiga@iar.com',  		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300009',	'Ernesto',		'Grillo',     	'egrillo@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300010',	'Sabrina',		'Pico',         'spico@iar.com',		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300011',	'Micaela', 		'Alvarez',    	'malvarez@iar.com',		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300012',	'Fernanda', 	'Martins',    	'fmartins@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300013',	'Victor',		'Morales',   	'vmorales@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300014',	'Mariano',		'Cepeda',    	'mcepeda@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300015',	'Juan',		  	'Sarlanga',   	'jsarlanga@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300016',	'Omar',     	'Rodriguez',    'orodriguez@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300017',	'Ruben',    	'Solis',        'rsolis@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300018',	'Marcos',   	'Rubies',       'mrubies@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300019',	'Hugo',     	'Perez',        'hperez@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300020',	'Jose',     	'Alvarez',      'jalvarez@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300021',	'Jorge',    	'Borges',       'jborges@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300022',	'Hector',   	'Saenz',        'hsaenz@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300023',	'Gustavo',  	'Caponi',       'gcaponi@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300024',	'Leonardo',	 	'Garcia',       'lgarcia@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300025',	'Claudio',  	'Castro',       'ccastro@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300026',	'Mario',    	'Cid',          'mcid@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300027',	'Rogelio',  	'Roldan',       'rroldan@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300028',	'Roberto',  	'Bosetti',      'rbosetti@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300029',	'Miguel',   	'Martinez',     'mmartinez@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300030',	'Emiliano', 	'Kan',          'ekan@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300031',	'Diego',    	'Lopez',        'dlopez@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300032',	'Carlos',   	'Vargas',       'cvargas@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300033',	'Hugo',    		'Rojas',        'hrojas@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300034',	'Pedro',    	'Molina',       'pmolina2@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300035',	'Ubaldo',   	'Cabral',		'ucabral@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300036',	'Guillermo',	'Veliz',        'gveliz@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300037',	'Carlos',   	'Artigas',      'cartigas@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300038',	'Manuel',   	'Montoya',      'mmontoya@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300039',	'Alfredo',  	'Espinoza',     'aespinoza@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300040',	'Margarita',	'Martinez',     'mmartine2@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300041',	'Alfredo',  	'Saguez',       'asaguez@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300042',	'Fernando', 	'Rojo',         'frojo@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300043',	'Jorge',    	'Rivera',       'jrivera@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300044',	'Victor',   	'Paz',          'vpaz@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300045',	'Eugenia',  	'Olguin',       'eolguin@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300046',	'Manuel',   	'Pizarro',      'mpizarro@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300047',	'Carmen',   	'Vazquez',      'cvazquez@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300048',	'Oscar',    	'Gomez',        'ogomez@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300049',	'Lina',     	'Fillol',		'lfillol@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300050',	'Juana',    	'Donoso',       'jdonoso@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300051',	'Cecilia',  	'Fuentes',      'cfuentes@iar.com', 	getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300052',	'Manuel',   	'Chacon',       'mchacon@iar.com', 		getDate(),	NULL);                                                                                                                                           
INSERT INTO PROFESOR VALUES('300053',	'Maria',    	'Nuñez',        'marian@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300054',	'Francisco',	'Muñoz',        'franciscom@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300055',	'Elisa',    	'Salinas',      'esalinas@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300056',	'Gustavo',  	'Gallardo',     'ggallardo@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300057',	'Jorge',    	'Osorio',       'josorio@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300058',	'Hernan',   	'Soto',         'hsoto@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300059',	'Patricio', 	'Rey',          'prey@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300060',	'Elena',    	'Pichincha',    'epichincha@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300061',	'Alejandro',	'Rey',          'arey@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300062',	'Oscar',    	'Martinez',     'omartinez@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300063',	'Juan',     	'Torres',       'jtorres@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300064',	'Berenice',		'Ferreira',     'bferreira@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300065',	'Daniel',		'Burotto',    	'dburotto@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300066',	'Carmen',		'Barros',     	'cbarros@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300067',	'Rosa',			'Hernandez',  	'rhernandez@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300068',	'Ana',			'Cane',       	'acane@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300069',	'Sara',     	'Leon',         'sleon@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300070',	'Ricardo',  	'Martin',       'rmartin@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300071',	'Veronica', 	'Rivas',        'vrivas@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300072',	'Rolando',  	'Cafrune',      'rcafrune@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300073',	'Clara',    	'Tapia',        'ctapia@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300074',	'Lautaro',  	'Rebeco',       'lrebeco@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300075',	'Raul',     	'Sauer',        'rsauer@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300076',	'Lucila',   	'Cautivo',      'lcautivo@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300077',	'Juan',     	'Hidalgo',      'jhidalgo@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300078',	'Carlos',   	'Monzon',       'cmonzon@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300079',	'Pilar',    	'Chaffe',       'pchaffe@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300080',	'María',    	'Prado',        'mprado@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300081',	'Ines',     	'Orellana',     'iorellana@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300082',	'Gustavo',  	'Diaz',         'gdiaz@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300083',	'Fresia',   	'Cabello',      'fcabello@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300084',	'Rosa',     	'Sanguinetti',  'rsanguinetti@iar.com',	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300085',	'Sergio',   	'Elgueta',      'selgueta@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300086',	'Ciro',     	'Mena',         'cmena@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300087',	'Cesar',    	'Cejas',        'ccejas@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300088',	'Hernan',   	'Lopez',        'hlopez@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300089',	'Jorge',    	'Toro',         'jtoro@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300090',	'Amelia',   	'Morales',      'amorales@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300091',	'Juan',     	'Deacon',       'jdeacon@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300092',	'Norberto', 	'Solano',       'nsolano@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300093',	'Benito',   	'Olmos',        'bolmos@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300094',	'Brian',    	'Mayo',         'bmayo@iar.com', 		getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300095',	'Federico', 	'Mercurio',     'fmercurio@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300096',	'Elio',     	'Valdivia',     'evaldivia@iar.com', 	getDate(),	NULL);
INSERT INTO PROFESOR VALUES('300097',	'Adolfo',   	'Silva',        'asilva@iar.com', 		getDate(),	NULL);

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla ADMINISTRADOR                               */
/*----------------------------------------------------------------------------*/

INSERT INTO ADMINISTRADOR VALUES('100001',	'Mario',		'Serrano',		'mserrano@iar.com', getDate(),	NULL,	'23543543');
INSERT INTO ADMINISTRADOR VALUES('100002',	'Manuel',		'Perez',		'mperez@iar.com',	getDate(),	NULL,	'26262734');
INSERT INTO ADMINISTRADOR VALUES('100003',	'Mariana',		'Vila',			'mvila@iar.com',	getDate(),	NULL,	'25231988');
INSERT INTO ADMINISTRADOR VALUES('100004',	'Patricia', 	'Dali',			'pdali@iar.com',	getDate(),	NULL,	'23061254');
INSERT INTO ADMINISTRADOR VALUES('100005',	'Alberto',		'Juarez',		'ajuarez@iar.com',	getDate(),	NULL,	'26774903');

/*----------------------------------------------------------------------------*/
/* INSERT en la tabla CORRELATIVA                                             */
/*----------------------------------------------------------------------------*/

INSERT INTO CORRELATIVA VALUES ('0049',	NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0011', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0065', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0068', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0029', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0010', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0032', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0097', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0075', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0074', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0054', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0009', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0094', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0050', '0049', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0012', '0011', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0066', '0065', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0069', '0068', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0030', '0029', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0072', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0039', '0097', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0045', '0010', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0076', '0075', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0037', '0054', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0077', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0095', '0094', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0088', '0009', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0051', '0050', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0013', '0012', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0067', '0066', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0070', '0069', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0008', '0039', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0034', '0076', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0057', '0076', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0006', '0045', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0055', '0037', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0056', '0095', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0082', '0077', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0020', '0072', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0081', '0088', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0062', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0059', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0015', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0071', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0086', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0010', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0014', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0001', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0019', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0052', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0026', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0007', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0035', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0063', '0062', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0060', '0059', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0016', '0015', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0058', '0014', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0078', '0086', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0092', '0071', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0080', '0010', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0025', '0026', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0027', '0026', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0047', '0052', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0083', '0001', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0036', '0035', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0096', '0007', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0064', '0063', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0061', '0060', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0017', '0016', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0079', '0080', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0082', '0092', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0021', '0058', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0048', '0047', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0005', '0036', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0084', '0078', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0022', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0089', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0002', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0040', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0035', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0010', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0097', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0033', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0046', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0053', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0026', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0028', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0087', NULL,	getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0023', '0022', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0090', '0089', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0003', '0002', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0041', '0040', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0036', '0035', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0085', '0010', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0073', '0097', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0031', '0026', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0018', '0087', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0024', '0023', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0091', '0090', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0004', '0003', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0042', '0041', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0044', '0085', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0043', '0073', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0093', '0010', getDate(),	NULL);
INSERT INTO CORRELATIVA VALUES ('0038', '0018', getDate(),	NULL);
