Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ActaFinal

    Public Function add(ByVal item As Entidades.ActaFinal) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.ACTA_FINAL_INSERT"
                    cmd.Parameters.AddWithValue("@cd_plan_estudio", item._cd_plan_estudio)
                    cmd.Parameters.AddWithValue("@cd_curso", item._cd_curso)
                    cmd.Parameters.AddWithValue("@cd_alumno", item._cd_alumno)
                    cmd.Parameters.AddWithValue("@libro", item._libro)
                    cmd.Parameters.AddWithValue("@folio", item._folio)
                    cmd.Parameters.AddWithValue("@calificacion", item._calificacion)

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

    Public Function get_all_by_filtros(ByVal cd_curso As Int32, ByVal cd_alumno As Int32, ByVal nombre_alumno As String, ByVal apellido_alumno As String) As List(Of Entidades.ActaFinal)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn

                cmd.CommandType = CommandType.StoredProcedure

                cmd.CommandText = "Alumnos.ACTA_FINAL_SEARCH"

                cmd.Parameters.AddWithValue("@cd_curso", cd_curso)
                cmd.Parameters.AddWithValue("@cd_alumno", cd_alumno)
                cmd.Parameters.AddWithValue("@nombre_alumno", nombre_alumno)
                cmd.Parameters.AddWithValue("@apellido_alumno", apellido_alumno)

                Dim l_entidades_calificacionCursada As New List(Of Entidades.ActaFinal)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read

                            Dim o_entidades_calificacionCursada As New Entidades.ActaFinal

                            o_entidades_calificacionCursada._cd_alumno = oReader("cd_alumno")
                            o_entidades_calificacionCursada._cd_curso = oReader("cd_curso")
                            o_entidades_calificacionCursada._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_calificacionCursada._calificacion = oReader("calificacion")
                            o_entidades_calificacionCursada._fc_alta = oReader("fc_alta")
                            o_entidades_calificacionCursada._an = oReader("an")
                            o_entidades_calificacionCursada._fc_ultima_modificacion = IIf(Convert.IsDBNull(oReader("fc_ultima_modificacion")), Nothing, oReader("fc_ultima_modificacion"))

                            l_entidades_calificacionCursada.Add(o_entidades_calificacionCursada)

                            o_entidades_calificacionCursada = Nothing
                        Loop

                        Return l_entidades_calificacionCursada

                    End Using

                Finally
                    l_entidades_calificacionCursada = Nothing
                End Try
            End Using
        End Using
    End Function

End Class
