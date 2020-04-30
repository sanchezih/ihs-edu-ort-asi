@echo off
echo INSTALACION DE LA BASE DE DATOS DEL SISTEMA SIGAL
@echo off
sqlcmd -i sigal_db.sql -b          >> InstalarBD.log
echo Se creo la base de datos Sigal.
sqlcmd -i sigal_tables.sql -b      >> InstalarBD.log
echo Se crearon las tablas de la base de datos Sigal.
sqlcmd -i sigal_errors.sql -b      >> InstalarBD.log
echo Se actualizo la tabla de errores.
sqlcmd -i sigal_triggers.sql -b    >> InstalarBD.log
echo Se crearon los triggers para las tablas.
sqlcmd -i sigal_jobs.sql -b        >> InstalarBD.log
echo Se crearon los jobs en el motor de bases de datos.
sqlcmd -i sigal_pau_insert.sql -b  >> InstalarBD.log
echo Se crearon los stored procedures de insert.
sqlcmd -i sigal_pau_update.sql -b  >> InstalarBD.log
echo Se crearon los stored procedures de update.
sqlcmd -i sigal_pau_delete.sql -b  >> InstalarBD.log
echo Se crearon los stored procedures de delete.
sqlcmd -i sigal_pau_search.sql -b  >> InstalarBD.log
echo Se crearon los stored procedures de busqueda.
sqlcmd -i sigal_pau_queries.sql -b >> InstalarBD.log
echo Se crearon los stored procedures de queries.
sqlcmd -i sigal_pau_get_one.sql -b >> InstalarBD.log
echo Se crearon los stored procedures de seleccion unitaria.
sqlcmd -i sigal_initialize.sql -b  >> InstalarBD.log
echo Se inicializo la base de datos.
echo Se genero el archivo de log de la instalacion - InstalarBD.log
echo Se creo correctamente la base de datos para el sistema Sigal.
pause
:exit