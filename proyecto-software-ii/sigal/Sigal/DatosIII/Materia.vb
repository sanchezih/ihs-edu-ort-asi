Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class Materia

#Region "FIGULS"

    'Public Function add(ByVal item As Entidades.Materia) As Int32
    '    Using cnn As SqlConnection = CreateConnection()
    '        cnn.Open()
    '        Using cmd As New SqlCommand
    '            cmd.Connection = cnn
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.CommandText = "Alumnos.MATERIA_INSERT"

    '            cmd.Parameters.AddWithValue("@cd_materia", item._cd_materia)
    '            cmd.Parameters.AddWithValue("@nombre_materia", item._nombre_materia)
    '            'Return cmd.ExecuteNonQuery

    '            Dim n As Integer
    '            n = CInt(cmd.ExecuteScalar())
    '            'MessageBox.Show("Se dio de alta la materia " + item._nombre_materia + " con el código " & n)
    '        End Using
    '    End Using
    'End Function

    'Public Function GetAll() As ArrayList
    '    Dim res As OleDbDataReader
    '    res = General.Seleccion("SELECT cd_materia, nombre_materia FROM Alumnos.MATERIA")
    '    Dim lista As New ArrayList

    '    While res.Read()
    '        Dim o_entidades_materia As New Entidades.Materia
    '        o_entidades_materia._cd_materia = res.Item("cd_ateria")
    '        o_entidades_materia._nombre_materia = res.Item("nombre_materia")
    '        lista.Add(o_entidades_materia)
    '    End While
    '    Return lista
    'End Function

    Public Function GetAllIsNotPlanEstudio(ByVal codPlanEstudio As String) As ArrayList
        Dim res As OleDbDataReader
        res = General.Seleccion("SELECT m.cd_materia, m.nombre_materia FROM Alumnos.materia m where  m.cd_materia not in(select cd_materia from alumnos.plan_materia_cuatrimestre where cd_plan_estudio = " + codPlanEstudio + " )")
        Dim lista As New ArrayList

        While res.Read()
            Dim alu As New Entidades.Materia
            alu._cd_materia = res.Item("CD_MATERIA")
            alu._nombre_materia = res.Item("NOMBRE_MATERIA")
            lista.Add(alu)
        End While
        Return lista
    End Function

    Public Function get_all(ByVal codPlanEstudio As String) As ArrayList

        Dim oCnn As New SqlConnection()
        oCnn.ConnectionString = "Data Source=xpsp3;Initial Catalog=Sigal;Integrated Security=True"
        ' crear comando para ejecutar procedimiento almacenado
        'Using oCnn As SqlConnection = CreateConnection()
        'abrimos conexion
        oCnn.Open()

        'Creamos un commando para realizar el alta del
        'contacto en la base de datos
        Using oCmd As New SqlCommand

            'asignamos la conexion de trabajo
            oCmd.Connection = oCnn

            'utilizamos stored procedures
            oCmd.CommandType = CommandType.StoredProcedure

            'el indicamos cual stored procedure utilizar
            oCmd.CommandText = "alumnos.PAU_W_CURSO_BUSCA_MAT_X_PLAN"


            'le asignamos el parámetro para el stored procedure
            oCmd.Parameters.AddWithValue("@cd_plan_estudio", codPlanEstudio)

            'aunque debemos buscar solo un elemento, siempre devolvemos
            'una colección. Es más fácil de manipular y controlar 
            Dim oCitas As New ArrayList

            'No retornamos DataSets, siempre utilizamos objetos para hacernos 
            'independientes de la estructura de las tablas en el resto
            'de las capas. Para ellos leemos con el DataReader y creamos
            'los objetos asociados que se esperan
            Try
                'Ejecutamos el comando y retornamos los valores
                Using oReader As SqlDataReader = oCmd.ExecuteReader
                    Do While oReader.Read
                        'si existe algun valor, creamos el objeto y lo almacenamos
                        'en la colección

                        Dim alu As New Entidades.Materia
                        alu._cd_materia = oReader("cd_materia").ToString
                        alu._nombre_materia = oReader("nombre_materia").ToString
                        'Agregamos el objeto a la coleccion de resultados
                        oCitas.Add(alu)

                        alu = Nothing
                    Loop

                    'retornamos los valores encontrados
                    Return oCitas

                End Using

            Finally
                'el Finally nos da siempre la oportunidad de liberar
                'la memoria utilizada por los objetos 
                oCitas = Nothing
            End Try

        End Using
    End Function

#End Region

    Public Function get_all_by_filtros(ByVal cd_materia As String, ByVal nombre_materia As String) As List(Of Entidades.Materia)
        Using cnn As SqlConnection = CreateConnection()
            'abrimos conexion
            cnn.Open()

            'Creamos un commando para realizar el alta del
            'contacto en la base de datos
            Using cmd As New SqlCommand

                'asignamos la conexion de trabajo
                cmd.Connection = cnn

                'utilizamos stored procedures
                cmd.CommandType = CommandType.StoredProcedure

                'el indicamos cual stored procedure utilizar
                cmd.CommandText = "Alumnos.MATERIA_SEARCH"

                'le asignamos el parámetro para el stored procedure
                cmd.Parameters.AddWithValue("@cd_materia", cd_materia)
                cmd.Parameters.AddWithValue("@nombre_materia", nombre_materia)

                'aunque debemos buscar solo un elemento, siempre devolvemos
                'una colección. Es más fácil de manipular y controlar 
                Dim l_entidades_materia As New List(Of Entidades.Materia)

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

                            Dim o_entidades_materia As New Entidades.Materia
                            o_entidades_materia._cd_materia = oReader("cd_materia")
                            o_entidades_materia._nombre_materia = oReader("nombre_materia")
                            o_entidades_materia._fc_alta = oReader("fc_alta")
                            o_entidades_materia._fc_ultima_modificacion = IIf(Convert.IsDBNull(oReader("fc_ultima_modificacion")), Nothing, oReader("fc_ultima_modificacion"))
                            o_entidades_materia._cd_estado_general = oReader("cd_estado_general")
                            o_entidades_materia._desc_estado_general = oReader("desc_estado_general")

                            'Agregamos el objeto a la coleccion de resultados
                            l_entidades_materia.Add(o_entidades_materia)

                            o_entidades_materia = Nothing
                        Loop

                        'retornamos los valores encontrados
                        Return l_entidades_materia

                    End Using

                Finally
                    'el Finally nos da siempre la oportunidad de liberar
                    'la memoria utilizada por los objetos 
                    l_entidades_materia = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Sub update(ByVal item As Entidades.Materia)
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.MATERIA_UPDATE"
                    cmd.Parameters.AddWithValue("@nombre_materia", item._nombre_materia)
                    cmd.Parameters.AddWithValue("@cd_estado_general", item._cd_estado_general)
                    cmd.Parameters.AddWithValue("@cd_materia", item._cd_materia)
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

    Public Function add(ByVal item As Entidades.Materia) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.MATERIA_INSERT"
                    cmd.Parameters.AddWithValue("@cd_materia", item._cd_materia)
                    cmd.Parameters.AddWithValue("@nombre_materia", item._nombre_materia)
                    cmd.ExecuteScalar()

                    'Dim n As String = CStr(cmd.ExecuteScalar())
                    'MessageBox.Show("Se dio de alta la materia " + item._nombre_materia + " con el código " & n)

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

    Public Function get_materias_de_un_plan(ByVal plan As Entidades.Plan) As List(Of Entidades.Materia)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_MATERIAS_DE_UN_PLAN"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)


                Dim l_entidades_materia As New List(Of Entidades.Materia)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_materia As New Entidades.Materia

                            o_entidades_materia._cn = oReader("cn")
                            o_entidades_materia._cd_materia = oReader("cd_materia")
                            o_entidades_materia._nombre_materia = oReader("nombre_materia")

                            l_entidades_materia.Add(o_entidades_materia)
                            o_entidades_materia = Nothing
                        Loop
                        Return l_entidades_materia
                    End Using
                Finally
                    l_entidades_materia = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function get_materias_que_pueden_tener_correl(ByVal plan As Entidades.Plan) As List(Of Entidades.Materia)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_MATERIAS_QUE_PUEDEN_TENER_CORREL"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)


                Dim l_entidades_materia As New List(Of Entidades.Materia)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_materia As New Entidades.Materia

                            o_entidades_materia._cn = oReader("cn")
                            o_entidades_materia._cd_materia = oReader("cd_materia")
                            o_entidades_materia._nombre_materia = oReader("nombre_materia")

                            l_entidades_materia.Add(o_entidades_materia)
                            o_entidades_materia = Nothing
                        Loop
                        Return l_entidades_materia
                    End Using
                Finally
                    l_entidades_materia = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function get_materias_que_pueden_ser_correl(ByVal plan As Entidades.Plan, ByVal materia As Entidades.Materia) As List(Of Entidades.Materia)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_MATERIAS_QUE_PUEDEN_SER_CORREL"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)
                cmd.Parameters.AddWithValue("@cd_materia", materia._cd_materia)


                Dim l_entidades_materia As New List(Of Entidades.Materia)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_materia As New Entidades.Materia

                            o_entidades_materia._cn = oReader("cn")
                            o_entidades_materia._cd_materia = oReader("cd_materia")
                            o_entidades_materia._nombre_materia = oReader("nombre_materia")

                            l_entidades_materia.Add(o_entidades_materia)
                            o_entidades_materia = Nothing
                        Loop
                        Return l_entidades_materia
                    End Using
                Finally
                    l_entidades_materia = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function get_one(ByVal cd_materia As String) As List(Of Entidades.Materia)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()

            Using cmd As New SqlCommand

                'asignamos la conexion de trabajo
                cmd.Connection = cnn

                'utilizamos stored procedures
                cmd.CommandType = CommandType.StoredProcedure

                'el indicamos cual stored procedure utilizar
                cmd.CommandText = "Alumnos._GET_ONE_MATERIA"

                'le asignamos el parámetro para el stored procedure
                cmd.Parameters.AddWithValue("@cd_materia", cd_materia)

                'aunque debemos buscar solo un elemento, siempre devolvemos
                'una colección. Es más fácil de manipular y controlar 
                Dim l_entidades_materia As New List(Of Entidades.Materia)

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

                            Dim o_entidades_materia As New Entidades.Materia
                            o_entidades_materia._cd_materia = oReader("cd_materia")
                            o_entidades_materia._nombre_materia = oReader("nombre_materia")
                            o_entidades_materia._fc_alta = oReader("fc_alta")
                            o_entidades_materia._fc_ultima_modificacion = IIf(Convert.IsDBNull(oReader("fc_ultima_modificacion")), Nothing, oReader("fc_ultima_modificacion"))
                            o_entidades_materia._cd_estado_general = oReader("cd_estado_general")
                            o_entidades_materia._desc_estado_general = oReader("desc_estado_general")

                            'Agregamos el objeto a la coleccion de resultados
                            l_entidades_materia.Add(o_entidades_materia)

                            o_entidades_materia = Nothing
                        Loop

                        'retornamos los valores encontrados
                        Return l_entidades_materia

                    End Using

                Finally
                    'el Finally nos da siempre la oportunidad de liberar
                    'la memoria utilizada por los objetos 
                    l_entidades_materia = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function get_materias_para_alta_pmc(ByVal plan As Entidades.Plan, ByVal cuat As Integer) As List(Of Entidades.Materia)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_MATERIAS_PARA_ALTA_PMC"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)
                cmd.Parameters.AddWithValue("@cuatrimestre_carrera", cuat)


                Dim l_entidades_materia As New List(Of Entidades.Materia)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_materia As New Entidades.Materia

                            o_entidades_materia._cn = oReader("cn")
                            o_entidades_materia._cd_materia = oReader("cd_materia")
                            o_entidades_materia._nombre_materia = oReader("nombre_materia")

                            l_entidades_materia.Add(o_entidades_materia)
                            o_entidades_materia = Nothing
                        Loop
                        Return l_entidades_materia
                    End Using
                Finally
                    l_entidades_materia = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function get_materias_que_pertenecen_a_un_curso() As List(Of Entidades.Materia)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_MATERIAS_QUE_PERTENECEN_A_UN_CURSO"

                ' cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)


                Dim l_entidades_materia As New List(Of Entidades.Materia)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_materia As New Entidades.Materia

                            o_entidades_materia._cn = oReader("cn")
                            o_entidades_materia._cd_materia = oReader("cd_materia")
                            o_entidades_materia._nombre_materia = oReader("nombre_materia")

                            l_entidades_materia.Add(o_entidades_materia)
                            o_entidades_materia = Nothing
                        Loop
                        Return l_entidades_materia
                    End Using
                Finally
                    l_entidades_materia = Nothing
                End Try
            End Using
        End Using
    End Function

    Public Function get_materias_que_tienen_corel(ByVal plan As Entidades.Plan) As List(Of Entidades.Materia)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_MATERIAS_QUE_TIENEN_CORREL"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)


                Dim l_entidades_materia As New List(Of Entidades.Materia)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_materia As New Entidades.Materia

                            o_entidades_materia._cn = oReader("cn")
                            o_entidades_materia._cd_materia = oReader("cd_materia")
                            o_entidades_materia._nombre_materia = oReader("nombre_materia")

                            l_entidades_materia.Add(o_entidades_materia)
                            o_entidades_materia = Nothing
                        Loop
                        Return l_entidades_materia
                    End Using
                Finally
                    l_entidades_materia = Nothing
                End Try
            End Using
        End Using
    End Function

End Class