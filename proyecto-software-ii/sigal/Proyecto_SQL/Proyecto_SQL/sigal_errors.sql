/******************************************************************************/
/* NOMBRE:       sigal_errors.sql                                             */
/* DESCRIPCION:                                                               */
/* AUTOR:        Ignacio Sanchez                                              */
/* FECHA:        2009/04/24                                                   */
/* MODIFICACION: -                                                            */
/******************************************************************************/

/*----------------------------------------------------------------------------*/
/*    EXECUTE sp_dropmessage 50005;                                           */
/*    GO                                                                      */
/*    -----------------------------------------------------------------       */
/*    EXECUTE sp_addmessage 50005, -- Message id number.                      */
/*                          10, -- Severity.                                  */
/*                          N'The current database ID is: %d,                 */
/*                            the database name is: %s.';                     */
/*    GO                                                                      */
/*    -----------------------------------------------------------------       */
/*    DECLARE @DBID INT;                                                      */
/*    SET @DBID = DB_ID();                                                    */
/*                                                                            */
/*    DECLARE @DBNAME NVARCHAR(128);                                          */
/*    SET @DBNAME = DB_NAME();                                                */
/*                                                                            */
/*    RAISERROR (50005,                                                       */
/*               10, -- Severity.                                             */
/*               1, -- State.                                                 */
/*               @DBID, -- First substitution argument.                       */
/*               @DBNAME); -- Second substitution argument.                   */
/*    GO                                                                      */
/*----------------------------------------------------------------------------*/

USE SIGAL
GO

EXECUTE sp_addmessage 70001,
                      16,
                      N'Error en la inscripcion.',
                      @with_log = true,
                      @replace = 'REPLACE';
GO

EXECUTE sp_addmessage 70002,
                      16,
                      N'Error.',
                      @with_log = true,
                      @replace = 'REPLACE';
GO
PRINT getDate();
PRINT N'Se actualizo la tabla de errores.';
GO