Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class Localidad

    Public Function get_all() As List(Of Entidades.Localidad)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_ALL_LOCALIDAD"
                Dim l_entidades_localidad As New List(Of Entidades.Localidad)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_estadoGeneral As New Entidades.Localidad

                            o_entidades_estadoGeneral._cd_localidad = oReader("cd_localidad")
                            o_entidades_estadoGeneral._desc_localidad = oReader("desc_localidad")

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

End Class
