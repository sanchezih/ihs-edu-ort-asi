Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Correlatividad

    Public Function add(ByVal item As Entidades.Correlatividad) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.CORRELATIVIDAD_INSERT"
                    cmd.Parameters.AddWithValue("@cd_materia", item._cd_materia)
                    cmd.Parameters.AddWithValue("@cd_materia_correlativa", item._cd_materia_correlativa)
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

    Public Function get_all_by_filtros(ByVal cd_plan_estudio As String, ByVal cd_materia As String) As List(Of Entidades.Correlatividad)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos.CORRELATIVIDAD_SEARCH"
                cmd.Parameters.AddWithValue("@cd_plan_estudio", cd_plan_estudio)

                Dim l_entidades_correlatividad As New List(Of Entidades.Correlatividad)
                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_correlatividad As New Entidades.Correlatividad
                            o_entidades_correlatividad._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_correlatividad._cd_materia_correlativa = oReader("cd_materia_correlativa")
                            o_entidades_correlatividad._cd_materia = oReader("cd_materia")
                            o_entidades_correlatividad._nombre_materia = oReader("nombre_materia")
                            o_entidades_correlatividad._correl = oReader("correl")

                            l_entidades_correlatividad.Add(o_entidades_correlatividad)
                            o_entidades_correlatividad = Nothing
                        Loop
                        Return l_entidades_correlatividad
                    End Using
                Finally
                    l_entidades_correlatividad = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Sub delete(ByVal cd_plan_estudio As String, ByVal cd_materia As String, ByVal cd_materia_correlativa As String)
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.CORRELATIVIDAD_DELETE"
                    cmd.Parameters.AddWithValue("@cd_plan_estudio", cd_plan_estudio)
                    cmd.Parameters.AddWithValue("@cd_materia", cd_materia)
                    cmd.Parameters.AddWithValue("@cd_materia_correlativa", cd_materia_correlativa)

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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function consulta_cantidad_correlativas(ByVal cd_plan_estudio As String, ByVal cd_materia As String) As Int32

        Dim res As OleDbDataReader
        res = General.Seleccion("SELECT COUNT (*) FROM Alumnos.CORRELATIVIDAD WHERE cd_materia = '" + cd_materia + "' OR cd_materia_correlativa = '" + cd_materia + "' AND cd_plan_estudio = '" + cd_plan_estudio + "'")

        res.Read()
        Dim maxId As New Integer
        maxId = res.Item(0)

        Return maxId
    End Function

End Class
