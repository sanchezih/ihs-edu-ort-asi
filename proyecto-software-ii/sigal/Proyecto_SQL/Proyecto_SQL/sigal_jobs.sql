USE [msdb]
DECLARE @jobId binary(16),
        @nombre NVARCHAR(2000)

SET @jobId = NULL
SET @nombre = 'job_actualiza_alumnos_estado_materia'

SELECT @jobId = job_id
FROM   msdb.dbo.sysjobs
WHERE  (name = @nombre)

IF(@jobId IS NOT NULL)
BEGIN
	EXEC sp_delete_job @job_name = @nombre;
END

USE [msdb]
GO
/****** Object:  Job [job_actualiza_alumnos_estado_materia]    Script Date: 10/23/2009 10:45:40 ******/
BEGIN TRANSACTION
DECLARE @ReturnCode INT
SELECT @ReturnCode = 0
/****** Object:  JobCategory [[Uncategorized (Local)]]]    Script Date: 10/23/2009 10:45:40 ******/
IF NOT EXISTS (SELECT name FROM msdb.dbo.syscategories WHERE name=N'[Uncategorized (Local)]' AND category_class=1)
BEGIN
EXEC @ReturnCode = msdb.dbo.sp_add_category @class=N'JOB', @type=N'LOCAL', @name=N'[Uncategorized (Local)]'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

END

DECLARE @jobId BINARY(16)
EXEC @ReturnCode =  msdb.dbo.sp_add_job @job_name=N'job_actualiza_alumnos_estado_materia', 
		@enabled=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=0, 
		@notify_level_netsend=0, 
		@notify_level_page=0, 
		@delete_level=0, 
		@description=N'No description available.', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'ZARA\Ignacio', @job_id = @jobId OUTPUT
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [step_actualiza_estado_materia]    Script Date: 10/23/2009 10:45:41 ******/
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'step_actualiza_estado_materia', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'UPDATE Alumnos.ALUMNO_ESTADO_MATERIA
                   SET    cd_estado_materia      = ''CNA'',
                          fc_ultima_modificacion = GetDate()
                   WHERE  cd_estado_materia IN (''CAP'', ''FNA'')
                   AND    DATEDIFF(YEAR, fc_ultima_modificacion, GetDate()) = 2', 
		@database_name=N'Sigal', 
		@output_file_name=N'C:\jobs_log.txt', 
		@flags=6
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_update_job @job_id = @jobId, @start_step_id = 1
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobschedule @job_id=@jobId, @name=N'job_actualiza_alumnos_estado_materia', 
		@enabled=1, 
		@freq_type=4, 
		@freq_interval=1, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=0, 
		@active_start_date=20060101, 
		@active_end_date=99991231, 
		@active_start_time=0, 
		@active_end_time=235959
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobserver @job_id = @jobId, @server_name = N'(local)'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
COMMIT TRANSACTION
GOTO EndSave
QuitWithRollback:
    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
EndSave:

GO

--------------------------------------------------------------------------------

USE [msdb]
DECLARE @jobId binary(16),
        @nombre NVARCHAR(2000)

SET @jobId = NULL
SET @nombre = 'job_depurador_general'

SELECT @jobId = job_id
FROM   msdb.dbo.sysjobs
WHERE  (name = @nombre)

IF(@jobId IS NOT NULL)
BEGIN
	EXEC sp_delete_job @job_name = @nombre;
END

USE [msdb]
GO
/****** Object:  Job [job_depurador_general]    Script Date: 10/23/2009 10:45:45 ******/
BEGIN TRANSACTION
DECLARE @ReturnCode INT
SELECT @ReturnCode = 0
/****** Object:  JobCategory [[Uncategorized (Local)]]]    Script Date: 10/23/2009 10:45:45 ******/
IF NOT EXISTS (SELECT name FROM msdb.dbo.syscategories WHERE name=N'[Uncategorized (Local)]' AND category_class=1)
BEGIN
EXEC @ReturnCode = msdb.dbo.sp_add_category @class=N'JOB', @type=N'LOCAL', @name=N'[Uncategorized (Local)]'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback

END

DECLARE @jobId BINARY(16)
EXEC @ReturnCode =  msdb.dbo.sp_add_job @job_name=N'job_depurador_general', 
		@enabled=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=0, 
		@notify_level_netsend=0, 
		@notify_level_page=0, 
		@delete_level=0, 
		@description=N'No description available.', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'ZARA\Ignacio', @job_id = @jobId OUTPUT
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [step_depura_plan_estudio]    Script Date: 10/23/2009 10:45:46 ******/
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'step_depura_plan_estudio', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=3, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'DELETE FROM   Sigal.Alumnos.PLAN_ESTUDIO
WHERE  cd_plan_estudio IN (SELECT DISTINCT cd_plan_estudio
                           FROM   Sigal.Alumnos.PLAN_ESTUDIO)
AND    cd_plan_estudio NOT IN (SELECT DISTINCT cd_plan_estudio
                               FROM   Sigal.Alumnos.PLAN_MATERIA_CUATRIMESTRE)', 
		@database_name=N'Sigal', 
		@output_file_name=N'C:\jobs_log.txt', 
		@flags=6
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
/****** Object:  Step [step_depura_materia]    Script Date: 10/23/2009 10:45:46 ******/
EXEC @ReturnCode = msdb.dbo.sp_add_jobstep @job_id=@jobId, @step_name=N'step_depura_materia', 
		@step_id=2, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_success_step_id=0, 
		@on_fail_action=2, 
		@on_fail_step_id=0, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'TSQL', 
		@command=N'DELETE FROM   Sigal.Alumnos.MATERIA
WHERE  cd_materia IN (SELECT DISTINCT cd_materia
                           FROM   Sigal.Alumnos.MATERIA)
AND    cd_materia NOT IN (SELECT DISTINCT cd_materia 
                               FROM   Sigal.Alumnos.PLAN_MATERIA_CUATRIMESTRE)', 
		@database_name=N'Sigal', 
		@output_file_name=N'C:\jobs_log.txt', 
		@flags=6
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_update_job @job_id = @jobId, @start_step_id = 1
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobschedule @job_id=@jobId, @name=N'job_depurador_general', 
		@enabled=1, 
		@freq_type=16, 
		@freq_interval=1, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=12, 
		@active_start_date=20060101, 
		@active_end_date=99991231, 
		@active_start_time=120000, 
		@active_end_time=235959
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
EXEC @ReturnCode = msdb.dbo.sp_add_jobserver @job_id = @jobId, @server_name = N'(local)'
IF (@@ERROR <> 0 OR @ReturnCode <> 0) GOTO QuitWithRollback
COMMIT TRANSACTION
GOTO EndSave
QuitWithRollback:
    IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
EndSave:

GO

PRINT getDate();
PRINT N'Se crearon los jobs en el motor de bases de datos.';
GO