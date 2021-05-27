Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Curso

#Region "FIGULS"



    Public Function GetAllByFiltros(ByVal anioPlan As String, ByVal materia As String) As List(Of Entidades.Curso)

        Dim oCnn As New SqlConnection()
        oCnn.ConnectionString = "Data Source=pcrocky;Integrated Security=SSPI;Initial Catalog=Sigal"
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
            oCmd.CommandText = "alumnos.CURSO_SEARCH"


            'le asignamos el parámetro para el stored procedure
            oCmd.Parameters.AddWithValue("@anio", anioPlan)
            oCmd.Parameters.AddWithValue("@nombre_materia", materia)

            'aunque debemos buscar solo un elemento, siempre devolvemos
            'una colección. Es más fácil de manipular y controlar 
            Dim oCitas As New List(Of Entidades.Curso)

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
                        Dim alu As New Entidades.Curso

                        alu._cd_curso = oReader("cd_curso").ToString
                        alu._cd_materia = oReader("cd_materia").ToString
                        alu._cd_plan_estudio = oReader("cd_plan_estudio").ToString
                        alu._semestre = oReader("nro_cuatrimestre").ToString
                        alu._anio = oReader("anio").ToString
                        '   alu.nomeMateria = oReader("nombre_materia").ToString
                        '  alu.titulo = oReader("titulo").ToString
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

    Public Function GetAllByCurso(ByVal cdCurso As String) As List(Of Entidades.Curso)

        Dim oCnn As New SqlConnection()
        oCnn.ConnectionString = "Data Source=pcrocky;Integrated Security=SSPI;Initial Catalog=Sigal"
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
            oCmd.CommandText = "alumnos.CURSO_CONSULTA"


            'le asignamos el parámetro para el stored procedure
            oCmd.Parameters.AddWithValue("@cd_curso", cdCurso)


            'aunque debemos buscar solo un elemento, siempre devolvemos
            'una colección. Es más fácil de manipular y controlar 
            Dim oCitas As New List(Of Entidades.Curso)

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
                        Dim alu As New Entidades.Curso

                        'alu.cdCurso = oReader("cd_curso").ToString
                        'alu.cdMateria = oReader("cd_materia").ToString
                        'alu.cdPlanEstudio = oReader("cd_plan_estudio").ToString
                        'alu.cdPlanEstudio = oReader("nro_cuatrimestre").ToString
                        'alu.anio = oReader("anio").ToString
                        'alu.nombreMateria = oReader("nombre_materia").ToString
                        'alu.titulo = oReader("titulo").ToString
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

    ''
    'Public Function Add(ByVal item As Entidades.Curso) As Int32
    '    'Creamos la conexión a utilizar.
    '    ' crear conexión
    '    Dim oConexion As New SqlConnection()
    '    oConexion.ConnectionString = "Data Source=pcrocky;Integrated Security=SSPI;Initial Catalog=Sigal"
    '    ' crear comando para ejecutar procedimiento almacenado
    '    ' que borra un registro
    '    Dim oComando As New SqlCommand()
    '    oComando.Connection = oConexion
    '    oComando.CommandType = CommandType.StoredProcedure
    '    oComando.CommandText = "alumnos.CURSO_INSERT"
    '    ' añadir parámetro al comando
    '    oComando.Parameters.AddWithValue("@CD_MATERIA", item._cd_materia)
    '    oComando.Parameters.AddWithValue("@CD_PROFESOR", item._cd_profesor)
    '    oComando.Parameters.AddWithValue("@CD_PLAN_ESTUDIO", item._cd_plan_estudio)
    '    oComando.Parameters.AddWithValue("@NRO_CUATRIMESTRE", item._semestre)
    '    oComando.Parameters.AddWithValue("@ANIO", item._anio)

    '    'Dim iResultado As Integer
    '    oConexion.Open() ' abrir conexión
    '    Return oComando.ExecuteScalar
    '    MessageBox.Show("Curso Guardado")


    'End Function

    ''' <summary>
    ''' Actualiza una cita en la base de datos
    ''' </summary>
    ''' <param name="item"></param>
    ''' <remarks></remarks>
    Public Sub Update____(ByVal item As Entidades.Curso)
        'Creamos la conexión a utilizar.
        'Utilizamos la sentencia Using para asegurarnos de cerrar la conexión
        'y liberar el objeto al salir de esta sección de manera automática            


        Using oCnn As New SqlConnection()
            oCnn.ConnectionString = "Data Source=pcrocky;Integrated Security=SSPI;Initial Catalog=Sigal"
            ' crear comando para ejecutar procedimiento almacenado
            ' Using oCnn As SqlConnection = CreateConnection()
            'abrimos conexion
            oCnn.Open()

            'Creamos un commando para realizar el alta del
            'contacto en la base de datos
            Using oComando As New SqlCommand

                'asignamos la conexion de trabajo
                oComando.Connection = oCnn

                'utilizamos stored procedures
                oComando.CommandType = CommandType.StoredProcedure

                'el indicamos cual stored procedure utilizar
                oComando.CommandText = "alumnos.PLAN_ESTUDIO_UPDATE"

                ''le asignamos los parámetros para el stored procedure
                ''los valores viene en el parámetro item del procedimiento
                'oComando.Parameters.AddWithValue("@cd_plan_estudio", item.cdPlanEstudio)
                'oComando.Parameters.AddWithValue("@titulo", item.titulo)
                'Ejecutamos el comando 
                oComando.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    Public Function GetAll() As ArrayList
        Dim res As OleDbDataReader
        res = General.Seleccion("SELECT CD_PLAN_ESTUDIO, TITULO FROM Alumnos.PLAN_ESTUDIO where estado = 'AC'")
        Dim lista As New ArrayList

        While res.Read()
            Dim alu As New Entidades.__PlanEstudio_figuls
            alu.cdPlanEstudio = res.Item("CD_PLAN_ESTUDIO")
            alu.titulo = res.Item("TITULO")
            lista.Add(alu)
        End While
        Return lista
    End Function

    Public Function GetAllByPlan(ByVal codPlan As String) As ArrayList

        Dim oCnn As New SqlConnection()
        oCnn.ConnectionString = "Data Source=pcrocky;Integrated Security=SSPI;Initial Catalog=Sigal"
        oCnn.Open()
        Using oCmd As New SqlCommand
            oCmd.Connection = oCnn
            oCmd.CommandType = CommandType.StoredProcedure
            oCmd.CommandText = "alumnos.PAU_W_INSCRIPCION_CURSO_BUSCA_CURSO_DISPONIBLES"
            oCmd.Parameters.AddWithValue("@cd_plan_estudio", codPlan)
            Dim oCitas As New ArrayList
            Try
                Using oReader As SqlDataReader = oCmd.ExecuteReader
                    Do While oReader.Read
                        Dim alu As New Entidades.Curso
                        'alu.cdCurso = oReader("cd_curso").ToString
                        oCitas.Add(alu)
                        alu = Nothing
                    Loop
                    Return oCitas
                End Using
            Finally
                oCitas = Nothing
            End Try
        End Using
    End Function
#End Region


    Public Function add(ByVal item As Entidades.Curso) As Int32
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.CURSO_INSERT"
                    cmd.Parameters.AddWithValue("@cd_materia", item._cd_materia)
                    cmd.Parameters.AddWithValue("@cd_profesor", item._cd_profesor)
                    cmd.Parameters.AddWithValue("@cd_plan_estudio", item._cd_plan_estudio)
                    cmd.Parameters.AddWithValue("@anio", item._anio)
                    cmd.Parameters.AddWithValue("@semestre", item._semestre)

                    ' cmd.ExecuteScalar()

                    Dim n As Integer
                    n = CInt(cmd.ExecuteScalar())
                    MessageBox.Show("Se dio de alta el curso con el código " & n & ".", "Alta de curso", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Public Function get_all_by_filtros(ByVal cd_curso As Int32, ByVal estado As Integer, ByVal anio As Integer, ByVal materia As String, ByVal profesor As Int32) As List(Of Entidades.Curso)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos.CURSO_SEARCH"

                cmd.Parameters.AddWithValue("@cd_curso", cd_curso)
                cmd.Parameters.AddWithValue("@estado", estado)
                cmd.Parameters.AddWithValue("@anio", anio)
                cmd.Parameters.AddWithValue("@materia", materia)
                cmd.Parameters.AddWithValue("@profesor", profesor)

                Dim l_entidades_curso As New List(Of Entidades.Curso)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read

                            Dim o_entidades_curso As New Entidades.Curso

                            o_entidades_curso._cd_curso = oReader("cd_curso")
                            o_entidades_curso._cd_materia = oReader("cd_materia")
                            o_entidades_curso._cd_profesor = oReader("cd_profesor")
                            o_entidades_curso._cd_plan_estudio = oReader("cd_plan_estudio")
                            o_entidades_curso._semestre = oReader("semestre")
                            o_entidades_curso._anio = oReader("anio")
                            o_entidades_curso._fc_alta = oReader("fc_alta")
                            o_entidades_curso._fc_baja = IIf(Convert.IsDBNull(oReader("fc_baja")), Nothing, oReader("fc_baja"))
                            o_entidades_curso._nombre_materia = oReader("nombre_materia")
                            o_entidades_curso._nombre_profesor = oReader("nombre_profesor")
                            o_entidades_curso._titulo = oReader("titulo")

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

    Public Function get_cursos_que_permiten_inscripciones(ByVal plan As Entidades.Plan) As List(Of Entidades.Curso)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_CURSOS_QUE_PERMITEN_INSCRIPCIONES"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)

                Dim l_entidades_materia As New List(Of Entidades.Curso)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_materia As New Entidades.Curso
                            o_entidades_materia._cn = oReader("cn")
                            o_entidades_materia._cd_curso = oReader("cd_curso")
                            o_entidades_materia._cd_materia = oReader("cd_materia")


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

    Public Function get_cursos_de_plan_para_calif_final(ByVal plan As Entidades.Plan) As List(Of Entidades.Curso)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_CURSOS_DE_PLAN_PARA_CALIF_FINAL"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)


                Dim l_entidades_materia As New List(Of Entidades.Curso)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_materia As New Entidades.Curso
                            o_entidades_materia._cn = oReader("cn")
                            o_entidades_materia._cd_curso = oReader("cd_curso")
                            o_entidades_materia._cd_materia = oReader("cd_materia")

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

    Public Function get_cursos_activos_de_un_plan(ByVal plan As Entidades.Plan) As List(Of Entidades.Curso)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_CURSOS_ACTIVOS_DE_UN_PLAN"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)


                Dim l_entidades_materia As New List(Of Entidades.Curso)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_materia As New Entidades.Curso
                            o_entidades_materia._cn = oReader("cn")
                            o_entidades_materia._cd_curso = oReader("cd_curso")
                            o_entidades_materia._cd_materia = oReader("cd_materia")

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

    Public Function get_cursos_de_plan_para_calif_final(ByVal plan) As List(Of Entidades.Curso)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_CURSOS_DE_PLAN_PARA_CALIF_FINAL"

                cmd.Parameters.AddWithValue("@cd_plan_estudio", plan._cd_plan_estudio)


                Dim l_entidades_materia As New List(Of Entidades.Curso)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read
                            Dim o_entidades_materia As New Entidades.Curso
                            o_entidades_materia._cn = oReader("cn")
                            o_entidades_materia._cd_curso = oReader("cd_curso")
                            o_entidades_materia._cd_materia = oReader("cd_materia")

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

    Public Function get_one(ByVal cd_curso As Int32) As List(Of Entidades.Curso)
        Using cnn As SqlConnection = CreateConnection()
            cnn.Open()
            Using cmd As New SqlCommand
                cmd.Connection = cnn
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "Alumnos._GET_ONE_CURSO"

                cmd.Parameters.AddWithValue("@cd_curso", cd_curso)

                Dim l_entidades_curso As New List(Of Entidades.Curso)

                Try
                    Using oReader As SqlDataReader = cmd.ExecuteReader
                        Do While oReader.Read

                            Dim o_entidades_curso As New Entidades.Curso

                            o_entidades_curso._cd_curso = oReader("cd_curso")
                            o_entidades_curso._cd_plan_estudio = oReader("cd_plan_estudio_y_titulo")
                            o_entidades_curso._cn = oReader("cn")
                            o_entidades_curso._semestre = oReader("semestre")
                            o_entidades_curso._anio = oReader("anio")
                            o_entidades_curso._nombre_profesor = oReader("nombre_profesor")
                            o_entidades_curso._fc_alta = oReader("fc_alta")
                            o_entidades_curso._fc_baja = IIf(Convert.IsDBNull(oReader("fc_baja")), Nothing, oReader("fc_baja"))
                         
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

    Public Sub update(ByVal item As Entidades.Curso)
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.CURSO_UPDATE"
                    cmd.Parameters.AddWithValue("@anio", item._anio)
                    cmd.Parameters.AddWithValue("@cd_curso", item._cd_curso)

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

    Public Sub delete(ByVal cd_curso As Int32)
        Try
            Using cnn As SqlConnection = CreateConnection()
                cnn.Open()
                Using cmd As New SqlCommand
                    cmd.Connection = cnn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "Alumnos.CURSO_DELETE"
                    cmd.Parameters.AddWithValue("@cd_curso", cd_curso)

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
