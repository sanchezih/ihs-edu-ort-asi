Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class Analitico

    Public Function get_all_by_filtros(ByVal cd_alumno As Int32, ByVal nombre_alumno As String, ByVal apellido_alumno As String) As List(Of Entidades.Analitico)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos.ALUMNO_ESTADO_MATERIA_SEARCH"

                cmd.Parameters.AddWithValue("@cd_alumno", cd_alumno)
                cmd.Parameters.AddWithValue("@nombre_alumno", nombre_alumno)
                cmd.Parameters.AddWithValue("@apellido_alumno", apellido_alumno)

                Dim l_entidades_analitico As New List(Of Entidades.Analitico)
                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read

                            Dim o_entidades_analitico As New Entidades.Analitico
                            o_entidades_analitico._cd_materia = oReader("cd_materia")
                            o_entidades_analitico._cd_alumno = oReader("cd_alumno")
                            o_entidades_analitico._cd_curso = oReader("cd_curso")
                            o_entidades_analitico._cd_estado_materia = oReader("cd_estado_materia")
                            o_entidades_analitico._fc_ultima_modificacion = oReader("fc_ultima_modificacion")
                            o_entidades_analitico._desc_estado_materia = oReader("desc_estado_materia")
                            o_entidades_analitico._an = oReader("an")

                            l_entidades_analitico.Add(o_entidades_analitico)
                            o_entidades_analitico = Nothing
                        Loop
                        Return l_entidades_analitico
                    End Using
                Finally
                    l_entidades_analitico = Nothing
                End Try
            End Using
        End Using
    End Function

End Class
