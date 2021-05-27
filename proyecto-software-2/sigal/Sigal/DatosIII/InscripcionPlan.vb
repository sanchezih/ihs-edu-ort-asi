Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class InscripcionPlan

    Public Function add(ByVal item As Entidades.InscripcionPlan) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.INSCRIPCION_PLAN_INSERT"
                    cmd.Parameters.AddWithValue("@cd_alumno", item._cd_alumno)
                    cmd.Parameters.AddWithValue("@cd_plan_estudio", item._cd_plan_estudio)

                    ' cmd.ExecuteScalar()

                    Dim n As Integer
                    n = CInt(cmd.ExecuteScalar())

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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Function get_all_by_filtros(ByVal cd_plan_estudio As String, ByVal cd_alumno As Int32) As List(Of Entidades.InscripcionPlan)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos.INSCRIPCION_PLAN_SEARCH"
                cmd.Parameters.AddWithValue("@cd_plan_estudio", cd_plan_estudio)
                cmd.Parameters.AddWithValue("@cd_alumno", cd_alumno)

                Dim l_entidades_inscripcionPlan As New List(Of Entidades.InscripcionPlan)
                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_inscripcionPlan As New Entidades.InscripcionPlan
                            o_entidades_inscripcionPlan._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_inscripcionPlan._titulo = oReader("titulo")
                            o_entidades_inscripcionPlan._cd_alumno = oReader("cd_alumno")
                            o_entidades_inscripcionPlan._an = oReader("an")
                            o_entidades_inscripcionPlan._fc_alta = oReader("fc_alta")

                            l_entidades_inscripcionPlan.Add(o_entidades_inscripcionPlan)
                            o_entidades_inscripcionPlan = Nothing
                        Loop
                        Return l_entidades_inscripcionPlan
                    End Using
                Finally
                    l_entidades_inscripcionPlan = Nothing
                End Try
            End Using
        End Using
    End Function

End Class
