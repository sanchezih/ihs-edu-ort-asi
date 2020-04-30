Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class PMC

    Public Function add(ByVal item As Entidades.PMC) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.PMC_INSERT"
                    cmd.Parameters.AddWithValue("@cd_materia", item._cd_materia)
                    cmd.Parameters.AddWithValue("@cuatrimestre_carrera", item._cuatrimestre_carrera)
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

    Public Function get_all_by_filtros(ByVal cd_plan_estudio As String, ByVal cuatrimestre_carrera As Int32) As List(Of Entidades.PMC)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos.PMC_SEARCH"
                cmd.Parameters.AddWithValue("@cd_plan_estudio", cd_plan_estudio)
                cmd.Parameters.AddWithValue("@cuatrimestre_carrera", cuatrimestre_carrera)

                Dim l_entidades_plan As New List(Of Entidades.PMC)
                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_plan As New Entidades.PMC
                            o_entidades_plan._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_plan._titulo = oReader("titulo")
                            o_entidades_plan._cd_materia = oReader("cd_materia")
                            o_entidades_plan._nombre_materia = oReader("nombre_materia")
                            o_entidades_plan._cuatrimestre_carrera = oReader("cuatrimestre_carrera")

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

    Public Sub delete(ByVal cd_plan_estudio As String, ByVal cd_materia As String, ByVal cuatrimestre As Int32)
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.PMC_DELETE"
                    cmd.Parameters.AddWithValue("@cd_plan_estudio", cd_plan_estudio)
                    cmd.Parameters.AddWithValue("@cd_materia", cd_materia)
                    cmd.Parameters.AddWithValue("@cuatrimestre", cuatrimestre)

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

End Class
