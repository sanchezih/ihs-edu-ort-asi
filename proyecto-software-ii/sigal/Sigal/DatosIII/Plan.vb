Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class Plan

    Public Function get_all_by_filtros(ByVal cd_plan_estudio As String, ByVal titulo As String) As List(Of Entidades.Plan)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos.PLAN_ESTUDIO_SEARCH"
                cmd.Parameters.AddWithValue("@cd_plan_estudio", cd_plan_estudio)
                cmd.Parameters.AddWithValue("@titulo", titulo)
                Dim l_entidades_plan As New List(Of Entidades.Plan)
                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_plan As New Entidades.Plan
                            o_entidades_plan._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_plan._titulo = oReader("titulo")
                            o_entidades_plan._fc_alta = oReader("fc_alta")
                            o_entidades_plan._fc_ultima_modificacion = IIf(Convert.IsDBNull(oReader("fc_ultima_modificacion")), Nothing, oReader("fc_ultima_modificacion"))
                            o_entidades_plan._cd_estado_general = oReader("cd_estado_general")
                            o_entidades_plan._desc_estado_general = oReader("desc_estado_general")
                            l_entidades_plan.Add(o_entidades_plan)
                            o_entidades_plan = Nothing
                        Loop
                        Return l_entidades_plan
                    End Using
                Finally
                    l_entidades_plan = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function add(ByVal item As Entidades.Plan) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.PLAN_ESTUDIO_INSERT"
                    cmd.Parameters.AddWithValue("@cd_plan_estudio", item._cd_plan_estudio)
                    cmd.Parameters.AddWithValue("@titulo", item._titulo)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            'Capturamos las excepciones producidas por Microsoft SQL Server.
        Catch ex As SqlException
            'Recorremos la colección Errors del objeto SqlException.
            For Each err As SqlError In ex.Errors
                Dim o_dataError As New Sigal.Datos.DataError
                o_dataError.clasificar_error(err.Number)
                Exit For
            Next
            ' Capturamos excepciones genéricas.
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function get_planes_con_estado_alta() As List(Of Entidades.Plan)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_PLANES_CON_ESTADO_ALTA"
                Dim l_entidades_localidad As New List(Of Entidades.Plan)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_estadoGeneral As New Entidades.Plan
                            o_entidades_estadoGeneral._cd_plan_estudio_y_titulo = oReader("cd_plan_estudio_y_titulo")
                            o_entidades_estadoGeneral._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_estadoGeneral._titulo = oReader("titulo")

                            l_entidades_localidad.Add(o_entidades_estadoGeneral)
                            o_entidades_estadoGeneral = Nothing
                        Loop
                        Return l_entidades_localidad
                    End Using
                Finally
                    l_entidades_localidad = Nothing
                End Try

            End Using
        End Using
    End Function

    Public Function get_planes() As List(Of Entidades.Plan)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_PLANES"
                Dim l_entidades_localidad As New List(Of Entidades.Plan)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_estadoGeneral As New Entidades.Plan
                            o_entidades_estadoGeneral._cd_plan_estudio_y_titulo = oReader("cd_plan_estudio_y_titulo")
                            o_entidades_estadoGeneral._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_estadoGeneral._titulo = oReader("titulo")

                            l_entidades_localidad.Add(o_entidades_estadoGeneral)
                            o_entidades_estadoGeneral = Nothing
                        Loop
                        Return l_entidades_localidad
                    End Using
                Finally
                    l_entidades_localidad = Nothing
                End Try

            End Using
        End Using
    End Function

    Public Function get_planes_con_al_menos_un_curso_activo() As List(Of Entidades.Plan)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_PLANES_CON_AL_MENOS_UN_CURSO_ACTIVO"
                Dim l_entidades_localidad As New List(Of Entidades.Plan)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_estadoGeneral As New Entidades.Plan
                            o_entidades_estadoGeneral._cd_plan_estudio_y_titulo = oReader("cd_plan_estudio_y_titulo")
                            o_entidades_estadoGeneral._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_estadoGeneral._titulo = oReader("titulo")

                            l_entidades_localidad.Add(o_entidades_estadoGeneral)
                            o_entidades_estadoGeneral = Nothing
                        Loop
                        Return l_entidades_localidad
                    End Using
                Finally
                    l_entidades_localidad = Nothing
                End Try

            End Using
        End Using
    End Function

    Public Function get_planes_que_tienen_cursos_sin_todas_las_notas_informadas() As List(Of Entidades.Plan)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_PLANES_QUE_TIENEN_CURSOS_SIN_TODAS_LAS_NOTAS_INFORMADAS"
                Dim l_entidades_localidad As New List(Of Entidades.Plan)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_estadoGeneral As New Entidades.Plan
                            o_entidades_estadoGeneral._cd_plan_estudio_y_titulo = oReader("cd_plan_estudio_y_titulo")
                            o_entidades_estadoGeneral._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_estadoGeneral._titulo = oReader("titulo")

                            l_entidades_localidad.Add(o_entidades_estadoGeneral)
                            o_entidades_estadoGeneral = Nothing
                        Loop
                        Return l_entidades_localidad
                    End Using
                Finally
                    l_entidades_localidad = Nothing
                End Try

            End Using
        End Using
    End Function

    Public Function get_one(ByVal cd_plan As String) As List(Of Entidades.Plan)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()

            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_ONE_PLAN"
                cmd.Parameters.AddWithValue("@cd_plan_estudio", cd_plan)
                Dim l_entidades_plan As New List(Of Entidades.Plan)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read

                            Dim o_entidades_plan As New Entidades.Plan
                            o_entidades_plan._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_plan._titulo = oReader("titulo")
                            o_entidades_plan._fc_alta = oReader("fc_alta")
                            o_entidades_plan._fc_ultima_modificacion = IIf(Convert.IsDBNull(oReader("fc_ultima_modificacion")), Nothing, oReader("fc_ultima_modificacion"))
                            o_entidades_plan._cd_estado_general = oReader("cd_estado_general")
                            o_entidades_plan._desc_estado_general = oReader("desc_estado_general")

                            l_entidades_plan.Add(o_entidades_plan)

                            o_entidades_plan = Nothing
                        Loop

                        Return l_entidades_plan

                    End Using

                Finally
                    l_entidades_plan = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Sub update(ByVal item As Entidades.Plan)
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.PLAN_ESTUDIO_UPDATE"
                    cmd.Parameters.AddWithValue("@titulo", item._titulo)
                    cmd.Parameters.AddWithValue("@cd_estado_general", item._cd_estado_general)
                    cmd.Parameters.AddWithValue("@cd_plan_estudio", item._cd_plan_estudio)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As SqlException
            For Each err As SqlError In ex.Errors
                Dim o_dataError As New Sigal.Datos.DataError
                o_dataError.clasificar_error(err.Number)
                Exit For
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
