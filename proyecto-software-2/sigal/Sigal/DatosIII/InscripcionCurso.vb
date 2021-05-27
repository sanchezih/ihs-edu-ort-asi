Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class InscripcionCurso

    Public Function add(ByVal item As Entidades.InscripcionCurso) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.INSCRIPCION_CURSO_INSERT"
                    cmd.Parameters.AddWithValue("@cd_alumno", item._cd_alumno)
                    cmd.Parameters.AddWithValue("@cd_curso", item._cd_curso)

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

    Public Function get_all_by_filtros(ByVal cd_plan_estudio As String, ByVal cd_curso As Int32, ByVal cd_alumno As Int32) As List(Of Entidades.InscripcionCurso)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos.INSCRIPCION_CURSO_SEARCH"
                cmd.Parameters.AddWithValue("@cd_plan_estudio", cd_plan_estudio)
                cmd.Parameters.AddWithValue("@cd_curso", cd_curso)
                cmd.Parameters.AddWithValue("@cd_alumno", cd_alumno)

                Dim l_entidades_inscripcionCurso As New List(Of Entidades.InscripcionCurso)
                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_inscripcionCurso As New Entidades.InscripcionCurso
                            o_entidades_inscripcionCurso._cd_curso = oReader("cd_curso")
                            o_entidades_inscripcionCurso._cd_alumno = oReader("cd_alumno")
                            o_entidades_inscripcionCurso._fc_alta = oReader("fc_alta")
                            o_entidades_inscripcionCurso._an = oReader("an")
                            o_entidades_inscripcionCurso._nombre_materia = oReader("nombre_materia")

                            l_entidades_inscripcionCurso.Add(o_entidades_inscripcionCurso)
                            o_entidades_inscripcionCurso = Nothing
                        Loop
                        Return l_entidades_inscripcionCurso
                    End Using
                Finally
                    l_entidades_inscripcionCurso = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function consulta_cantidad_inscriptos(ByVal cd_curso As Int32) As Int32

        Dim res As OleDbDataReader
        Dim aux As String


        aux = CStr(cd_curso)

        res = General.Seleccion("SELECT COUNT (*) FROM Alumnos.INSCRIPCION_CURSO WHERE cd_curso = " + aux)


        res.Read()
        Dim maxId As New Integer
        maxId = res.Item(0)

        Return maxId
    End Function

End Class
