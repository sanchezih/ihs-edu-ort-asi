Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class Alumno

    Public Function get_all_by_filtros(ByVal cd_alumno As Int32, ByVal nombre_alumno As String, ByVal apellido_alumno As String) As List(Of Entidades.Alumno)
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
                cmd.CommandText = "Alumnos.ALUMNO_SEARCH"

                'le asignamos el parámetro para el stored procedure
                cmd.Parameters.AddWithValue("@cd_alumno", cd_alumno)
                cmd.Parameters.AddWithValue("@nombre_alumno", nombre_alumno)
                cmd.Parameters.AddWithValue("@apellido_alumno", apellido_alumno)

                'aunque debemos buscar solo un elemento, siempre devolvemos
                'una colección. Es más fácil de manipular y controlar 
                Dim l_entidades_alumno As New List(Of Entidades.Alumno)

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

                            Dim o_entidades_alumno As New Entidades.Alumno
                            o_entidades_alumno._cd_alumno = oReader("cd_alumno")
                            o_entidades_alumno._nombre_alumno = oReader("nombre_alumno")
                            o_entidades_alumno._apellido_alumno = oReader("apellido_alumno")
                            o_entidades_alumno._tipo_doc_alumno = oReader("tipo_doc_alumno")
                            o_entidades_alumno._nro_doc_alumno = oReader("nro_doc_alumno")
                            o_entidades_alumno._fc_nacimiento = oReader("fc_nacimiento")
                            o_entidades_alumno._sexo = oReader("sexo")
                            o_entidades_alumno._cd_pais = oReader("cd_pais")
                            o_entidades_alumno._direccion_alumno = oReader("direccion_alumno")
                            o_entidades_alumno._piso_alumno = IIf(Convert.IsDBNull(oReader("piso_alumno")), Nothing, oReader("piso_alumno"))
                            o_entidades_alumno._departamento_alumno = IIf(Convert.IsDBNull(oReader("departamento_alumno")), Nothing, oReader("departamento_alumno"))
                            o_entidades_alumno._cd_postal = oReader("cd_postal")
                            o_entidades_alumno._cd_localidad = oReader("cd_localidad")
                            o_entidades_alumno._tel1_alumno = oReader("tel1_alumno")
                            o_entidades_alumno._email_alumno = oReader("email_alumno")
                            o_entidades_alumno._cd_estado_alumno = oReader("cd_estado_alumno")
                            o_entidades_alumno._fc_alta = oReader("fc_alta")
                            o_entidades_alumno._fc_ultima_modificacion = IIf(Convert.IsDBNull(oReader("fc_ultima_modificacion")), Nothing, oReader("fc_ultima_modificacion"))
                            o_entidades_alumno._desc_pais = oReader("desc_pais")
                            o_entidades_alumno._desc_localidad = oReader("desc_localidad")
                            o_entidades_alumno._desc_estado_alumno = oReader("desc_estado_alumno")
                            o_entidades_alumno._documento = oReader("documento")

                            'Agregamos el objeto a la coleccion de resultados
                            l_entidades_alumno.Add(o_entidades_alumno)

                            o_entidades_alumno = Nothing
                        Loop

                        'retornamos los valores encontrados
                        Return l_entidades_alumno

                    End Using

                Finally
                    'el Finally nos da siempre la oportunidad de liberar
                    'la memoria utilizada por los objetos 
                    l_entidades_alumno = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function add(ByVal item As Entidades.Alumno) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.ALUMNO_INSERT"
                    cmd.Parameters.AddWithValue("@nombre_alumno", item._nombre_alumno)
                    cmd.Parameters.AddWithValue("@apellido_alumno", item._apellido_alumno)
                    cmd.Parameters.AddWithValue("@tipo_doc_alumno", item._tipo_doc_alumno)
                    cmd.Parameters.AddWithValue("@nro_doc_alumno", item._nro_doc_alumno)
                    cmd.Parameters.AddWithValue("@fc_nacimiento", item._fc_nacimiento)
                    cmd.Parameters.AddWithValue("@sexo", item._sexo)
                    cmd.Parameters.AddWithValue("@cd_pais", item._cd_pais)
                    cmd.Parameters.AddWithValue("@direccion_alumno", item._direccion_alumno)
                    cmd.Parameters.AddWithValue("@piso_alumno", item._piso_alumno)
                    cmd.Parameters.AddWithValue("@departamento_alumno", item._departamento_alumno)
                    cmd.Parameters.AddWithValue("@cd_postal", item._cd_postal)
                    cmd.Parameters.AddWithValue("@cd_localidad", item._cd_localidad)
                    cmd.Parameters.AddWithValue("@tel1_alumno", item._tel1_alumno)
                    cmd.Parameters.AddWithValue("@email_alumno", item._email_alumno)

                    'cmd.ExecuteScalar()

                    Dim n As Integer = CInt(cmd.ExecuteScalar())
                    MessageBox.Show("Se dio de alta el alumno con el código " & n & ".", "Alta de alumno", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End Using
            End Using
        Catch ex As SqlException

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

    Public Function get_alumnos_aptos_inscripcion_plan(ByVal plan As Entidades.Plan) As List(Of Entidades.Alumno)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_ALUMNOS_APTOS_INSCRIPCION_PLAN"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)

                Dim l_entidades_alumno As New List(Of Entidades.Alumno)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_alumno As New Entidades.Alumno

                            o_entidades_alumno._cna = oReader("cna")
                            o_entidades_alumno._cd_alumno = oReader("cd_alumno")
                            o_entidades_alumno._nombre_alumno = oReader("nombre_alumno")
                            o_entidades_alumno._apellido_alumno = oReader("apellido_alumno")

                            l_entidades_alumno.Add(o_entidades_alumno)
                            o_entidades_alumno = Nothing
                        Loop
                        Return l_entidades_alumno
                    End Using
                Finally
                    l_entidades_alumno = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function get_alumnos_aptos_inscripcion_curso(ByVal plan As Entidades.Plan, ByVal curso As Entidades.Curso) As List(Of Entidades.Alumno)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_ALUMNOS_APTOS_INSCRIPCION_CURSO"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)
                cmd.Parameters.AddWithValue("@cd_curso", curso._cd_curso)


                Dim l_entidades_alumno As New List(Of Entidades.Alumno)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_alumno As New Entidades.Alumno

                            o_entidades_alumno._cna = oReader("cna")
                            o_entidades_alumno._cd_alumno = oReader("cd_alumno")

                            l_entidades_alumno.Add(o_entidades_alumno)
                            o_entidades_alumno = Nothing
                        Loop
                        Return l_entidades_alumno
                    End Using
                Finally
                    l_entidades_alumno = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function get_alumnos_para_calificacion_cursada(ByVal curso As Entidades.Curso) As List(Of Entidades.Alumno)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_ALUMNOS_PARA_CALIFICACION_CURSADA"

                cmd.Parameters.AddWithValue("@cd_curso", curso._cd_curso)

                Dim l_entidades_alumno As New List(Of Entidades.Alumno)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_alumno As New Entidades.Alumno

                            o_entidades_alumno._cna = oReader("cna")
                            o_entidades_alumno._cd_alumno = oReader("cd_alumno")

                            l_entidades_alumno.Add(o_entidades_alumno)
                            o_entidades_alumno = Nothing
                        Loop
                        Return l_entidades_alumno
                    End Using
                Finally
                    l_entidades_alumno = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function get_alumnos_para_calificacion_final(ByVal curso As Entidades.Curso) As List(Of Entidades.Alumno)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_ALUMNOS_PARA_CALIFICACION_FINAL"

                cmd.Parameters.AddWithValue("@cd_curso", curso._cd_curso)

                Dim l_entidades_alumno As New List(Of Entidades.Alumno)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_alumno As New Entidades.Alumno

                            o_entidades_alumno._cna = oReader("cna")
                            o_entidades_alumno._cd_alumno = oReader("cd_alumno")

                            l_entidades_alumno.Add(o_entidades_alumno)
                            o_entidades_alumno = Nothing
                        Loop
                        Return l_entidades_alumno
                    End Using
                Finally
                    l_entidades_alumno = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function get_one(ByVal cd_alumno As Int32) As List(Of Entidades.Alumno)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_ONE_ALUMNO"

                cmd.Parameters.AddWithValue("@cd_alumno", cd_alumno)

                Dim l_entidades_curso As New List(Of Entidades.Alumno)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read

                            Dim o_entidades_curso As New Entidades.Alumno

                            o_entidades_curso._cd_alumno = oReader("cd_alumno")
                            o_entidades_curso._nombre_alumno = oReader("nombre_alumno")
                            o_entidades_curso._apellido_alumno = oReader("apellido_alumno")
                            o_entidades_curso._tipo_doc_alumno = oReader("tipo_doc_alumno")
                            o_entidades_curso._nro_doc_alumno = oReader("nro_doc_alumno")
                            o_entidades_curso._fc_nacimiento = oReader("fc_nacimiento")
                            o_entidades_curso._sexo = oReader("sexo")
                            o_entidades_curso._cd_pais = oReader("cd_pais")
                            o_entidades_curso._direccion_alumno = oReader("direccion_alumno")
                            o_entidades_curso._piso_alumno = IIf(Convert.IsDBNull(oReader("piso_alumno")), Nothing, oReader("piso_alumno"))
                            o_entidades_curso._departamento_alumno = IIf(Convert.IsDBNull(oReader("departamento_alumno")), Nothing, oReader("departamento_alumno"))
                            o_entidades_curso._cd_postal = oReader("cd_postal")
                            o_entidades_curso._cd_localidad = oReader("cd_localidad")
                            o_entidades_curso._tel1_alumno = oReader("tel1_alumno")
                            o_entidades_curso._email_alumno = oReader("email_alumno")
                            o_entidades_curso._cd_estado_alumno = oReader("cd_estado_alumno")
                            o_entidades_curso._fc_alta = oReader("fc_alta")
                            o_entidades_curso._fc_ultima_modificacion = IIf(Convert.IsDBNull(oReader("fc_ultima_modificacion")), Nothing, oReader("fc_ultima_modificacion"))
                            o_entidades_curso._desc_pais = oReader("desc_pais")
                            o_entidades_curso._desc_localidad = oReader("desc_localidad")
                            o_entidades_curso._desc_estado_alumno = oReader("desc_estado_alumno")

                            l_entidades_curso.Add(o_entidades_curso)

                            o_entidades_curso = Nothing
                        Loop

                        Return l_entidades_curso

                    End Using

                Finally
                    l_entidades_curso = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Sub update(ByVal item As Entidades.Alumno)
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.ALUMNO_UPDATE"
                    cmd.Parameters.AddWithValue("@nombre_alumno", item._nombre_alumno)
                    cmd.Parameters.AddWithValue("@cd_alumno", item._cd_alumno)
                    cmd.Parameters.AddWithValue("@apellido_alumno", item._apellido_alumno)
                    cmd.Parameters.AddWithValue("@nro_doc_alumno", item._nro_doc_alumno)
                    cmd.Parameters.AddWithValue("@tel1_alumno", item._tel1_alumno)
                    cmd.Parameters.AddWithValue("@email_alumno", item._email_alumno)
                    cmd.Parameters.AddWithValue("@direccion_alumno", item._direccion_alumno)
                    cmd.Parameters.AddWithValue("@piso_alumno", item._piso_alumno)
                    cmd.Parameters.AddWithValue("@departamento_alumno", item._departamento_alumno)
                    cmd.Parameters.AddWithValue("@cd_postal", item._cd_postal)
                    cmd.Parameters.AddWithValue("@tipo_doc_alumno", item._tipo_doc_alumno)
                    cmd.Parameters.AddWithValue("@sexo", item._sexo)
                    cmd.Parameters.AddWithValue("@fc_nacimiento", item._fc_nacimiento)
                    cmd.Parameters.AddWithValue("@cd_pais", item._cd_pais)
                    cmd.Parameters.AddWithValue("@cd_localidad", item._cd_localidad)

                    cmd.ExecuteNonQuery()
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
    End Sub

End Class
