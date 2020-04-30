Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Pais
    Public Function get_all() As List(Of Entidades.Pais)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_ALL_PAIS"
                Dim l_entidades_pais As New List(Of Entidades.Pais)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_pais As New Entidades.Pais

                            o_entidades_pais._cd_pais = oReader("cd_pais")
                            o_entidades_pais._desc_pais = oReader("desc_pais")

                            l_entidades_pais.Add(o_entidades_pais)
                            o_entidades_pais = Nothing
                        Loop
                        Return l_entidades_pais
                    End Using
                Finally
                    l_entidades_pais = Nothing
                End Try

            End Using
        End Using
    End Function
End Class
