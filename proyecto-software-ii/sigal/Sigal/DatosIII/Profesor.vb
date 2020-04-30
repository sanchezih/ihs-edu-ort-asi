Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Profesor

    Public Function get_all_by_filtros(ByVal cd_profesor As Int32, ByVal nombre_profesor As String, ByVal apellido_profesor As String) As List(Of Entidades.Profesor)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()

            'Creamos un commando para realizar el alta del
            'contacto en la base de datos
            Using cmd As New SqlCommand

                'asignamos la conexion de trabajo
                cmd.Connection = cnn

                'utilizamos stored procedures
                cmd.CommandType = CommandType.StoredProcedure

                'el indicamos cual stored procedure utilizar
                cmd.CommandText = "Alumnos.PROFESOR_SEARCH"

                'le asignamos el parámetro para el stored procedure
                cmd.Parameters.AddWithValue("@cd_profesor", cd_profesor)
                cmd.Parameters.AddWithValue("@nombre_profesor", nombre_profesor)
                cmd.Parameters.AddWithValue("@apellido_profesor", apellido_profesor)

                'aunque debemos buscar solo un elemento, siempre devolvemos
                'una colección. Es más fácil de manipular y controlar 
                Dim l_entidades_profesor As New List(Of Entidades.Profesor)

                'No retornamos DataSets, siempre utilizamos objetos para hacernos 
                'independientes de la estructura de las tablas en el resto
                'de las capas. Para ellos leemos con el DataReader y creamos
                'los objetos asociados que se esperan
                Try
                    'Ejecutamos el comando y retornamos los valores
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            'si existe algun valor, creamos el objeto y lo almacenamos
                            'en la colección

                            Dim o_entidades_profesor As New Entidades.Profesor
                            o_entidades_profesor._cd_profesor = oReader("cd_profesor")
                            o_entidades_profesor._nombre_profesor = oReader("nombre_profesor")
                            o_entidades_profesor._apellido_profesor = oReader("apellido_profesor")
                            o_entidades_profesor._email_profesor = oReader("email_profesor")
                            o_entidades_profesor._cd_estado_general = oReader("cd_estado_general")
                            o_entidades_profesor._fc_alta = oReader("fc_alta")
                            o_entidades_profesor._fc_ultima_modificacion = IIf(Convert.IsDBNull(oReader("fc_ultima_modificacion")), Nothing, oReader("fc_ultima_modificacion"))
                            o_entidades_profesor._desc_estado_general = oReader("desc_estado_general")

                            'Agregamos el objeto a la coleccion de resultados
                            l_entidades_profesor.Add(o_entidades_profesor)

                            o_entidades_profesor = Nothing
                        Loop

                        'retornamos los valores encontrados
                        Return l_entidades_profesor

                    End Using

                Finally
                    'el Finally nos da siempre la oportunidad de liberar
                    'la memoria utilizada por los objetos 
                    l_entidades_profesor = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function add(ByVal item As Entidades.Profesor) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.PROFESOR_INSERT"
                    cmd.Parameters.AddWithValue("@nombre_profesor", item._nombre_profesor)
                    cmd.Parameters.AddWithValue("@apellido_profesor", item._apellido_profesor)
                    cmd.Parameters.AddWithValue("@email_profesor", item._email_profesor)

                    Dim n As Integer = CInt(cmd.ExecuteScalar())
                    MessageBox.Show("Se dio de alta el profesor con el código " & n & ".", "Alta de profesor", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

            ' Capturamos excepciones genéricas.
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Public Function get_profesores_con_estado_alta() As List(Of Entidades.Profesor)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_PROFESORES_CON_ESTADO_ALTA"
                Dim l_entidades_localidad As New List(Of Entidades.Profesor)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_estadoGeneral As New Entidades.Profesor

                            o_entidades_estadoGeneral._cna = oReader("cna")
                            o_entidades_estadoGeneral._cd_profesor = oReader("cd_profesor")
                            o_entidades_estadoGeneral._nombre_profesor = oReader("nombre_profesor")

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

    Public Function get_profes_que_dan_algun_curso() As List(Of Entidades.Profesor)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_PROFES_QUE_DAN_ALGUN_CURSO"
                Dim l_entidades_profesor As New List(Of Entidades.Profesor)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_profesor As New Entidades.Profesor

                            o_entidades_profesor._cna = oReader("cna")
                            o_entidades_profesor._cd_profesor = oReader("cd_profesor")

                            l_entidades_profesor.Add(o_entidades_profesor)
                            o_entidades_profesor = Nothing
                        Loop
                        Return l_entidades_profesor
                    End Using
                Finally
                    l_entidades_profesor = Nothing
                End Try

            End Using
        End Using
    End Function

End Class
