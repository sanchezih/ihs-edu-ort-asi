Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class Usuario

    Public Function get_all_by_filtros(ByVal cd_usuario As String, ByVal password_usuario As String) As List(Of Entidades.Usuario)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos.USUARIO_SEARCH"
                cmd.Parameters.AddWithValue("@cd_usuario", cd_usuario)
                cmd.Parameters.AddWithValue("@password_usuario", password_usuario)
                Dim l_entidades_usuario As New List(Of Entidades.Usuario)
                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_usuario As New Entidades.Usuario
                            o_entidades_usuario._cd_usuario = oReader("cd_usuario")
                            o_entidades_usuario._password_usuario = oReader("password_usuario")
                            o_entidades_usuario._fc_alta = oReader("fc_alta")
                            o_entidades_usuario._fc_ultima_modificacion = IIf(Convert.IsDBNull(oReader("fc_ultima_modificacion")), Nothing, oReader("fc_ultima_modificacion"))
                            o_entidades_usuario._cd_estado_general = oReader("cd_estado_general")
                            o_entidades_usuario._desc_estado_general = oReader("desc_estado_general")
                            l_entidades_usuario.Add(o_entidades_usuario)
                            o_entidades_usuario = Nothing
                        Loop
                        Return l_entidades_usuario
                    End Using
                Finally
                    l_entidades_usuario = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function consulta_rol(ByVal cd_usuario As String) As Int32

        Dim res As OleDbDataReader

        res = General.Seleccion("SELECT cd_rol FROM Alumnos.USUARIO WHERE cd_usuario = '" + cd_usuario + "'")

        res.Read()
        Dim maxId As New Integer
        maxId = res.Item(0)

        Return maxId
    End Function

    Public Function consulta_existencia_cd_usuario(ByVal cd_usuario As String) As Int32

        Dim res As OleDbDataReader

        res = General.Seleccion("SELECT COUNT(*) FROM Alumnos.USUARIO WHERE cd_usuario = '" + cd_usuario + "'")

        res.Read()
        Dim cant As New Integer
        cant = res.Item(0)

        Return cant
    End Function

    Public Function add(ByVal item As Entidades.Usuario) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.USUARIO_INSERT"
                    cmd.Parameters.AddWithValue("@cd_usuario", item._cd_usuario)
                    cmd.Parameters.AddWithValue("@password_usuario", item._password_usuario)
                    cmd.Parameters.AddWithValue("@cd_rol", item._cd_rol)
                    cmd.ExecuteScalar()
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

    End Function

    Public Function update(ByVal item As Entidades.Usuario) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.USUARIO_UPDATE"
                    cmd.Parameters.AddWithValue("@cd_usuario", item._cd_usuario)
                    cmd.Parameters.AddWithValue("@password_usuario", item._password_usuario)

                    cmd.ExecuteScalar()
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

    End Function

End Class
