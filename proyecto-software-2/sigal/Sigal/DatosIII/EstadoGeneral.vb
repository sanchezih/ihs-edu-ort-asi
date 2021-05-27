Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class EstadoGeneral

    'Public Function get_all() As ArrayList
    '    Dim res As OleDbDataReader
    '    res = General.Seleccion("SELECT cd_estado_general, desc_estado_general FROM Alumnos.ESTADO_GENERAL")
    '    Dim lista As New ArrayList

    '    While res.Read()
    '        Dim alu As New Entidades.estado_general
    '        alu._cd_estado_general = res.Item("cd_estado_general")
    '        alu._desc_estado_general = res.Item("desc_estado_general")
    '        lista.Add(alu)
    '    End While
    '    Return lista
    'End Function

    Public Function get_all() As List(Of Entidades.EstadoGeneral)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_ALL_ESTADO_GENERAL"
                Dim l_entidades_estadoGeneral As New List(Of Entidades.EstadoGeneral)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_estadoGeneral As New Entidades.EstadoGeneral

                            o_entidades_estadoGeneral._cd_estado_general = oReader("cd_estado_general")
                            o_entidades_estadoGeneral._desc_estado_general = oReader("desc_estado_general")

                            l_entidades_estadoGeneral.Add(o_entidades_estadoGeneral)
                            o_entidades_estadoGeneral = Nothing
                        Loop
                        Return l_entidades_estadoGeneral
                    End Using
                Finally
                    l_entidades_estadoGeneral = Nothing
                End Try

            End Using
        End Using
    End Function

End Class
