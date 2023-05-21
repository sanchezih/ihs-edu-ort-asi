Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class __PlanEstudio_figuls

    Public Function GetAllByFiltros(ByVal codPlan As String, ByVal titulo As String) As List(Of Entidades.__PlanEstudio_figuls)

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
            oCmd.CommandText = "alumnos.PLAN_ESTUDIO_SEARCH"


            'le asignamos el parámetro para el stored procedure
            oCmd.Parameters.AddWithValue("@cd_plan_estudio", codPlan)
            oCmd.Parameters.AddWithValue("@titulo", titulo)

            'aunque debemos buscar solo un elemento, siempre devolvemos
            'una colección. Es más fácil de manipular y controlar 
            Dim oCitas As New List(Of Entidades.__PlanEstudio_figuls)

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
                        Dim alu As New Entidades.__PlanEstudio_figuls
                        alu.cdPlanEstudio = oReader("cd_plan_estudio").ToString
                        alu.titulo = oReader("titulo").ToString
                        alu.fcAlta = oReader("fc_alta").ToString
                        alu.fcUltimaModificacion = oReader("fc_ultima_modificacion").ToString
                        alu.estado = oReader("estado").ToString

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

    Public Function Add(ByVal item As Entidades.__PlanEstudio_figuls) As Int32
        'Creamos la conexión a utilizar.
        ' crear conexión
        Dim oConexion As New SqlConnection()
        oConexion.ConnectionString = "Data Source=pcrocky;Integrated Security=SSPI;Initial Catalog=Sigal"
        ' crear comando para ejecutar procedimiento almacenado
        ' que borra un registro
        Dim oComando As New SqlCommand()
        oComando.Connection = oConexion
        oComando.CommandType = CommandType.StoredProcedure
        oComando.CommandText = "alumnos.PLAN_ESTUDIO_INSERT"
        ' añadir parámetro al comando
        oComando.Parameters.AddWithValue("@cd_plan_estudio", item.cdPlanEstudio)
        oComando.Parameters.AddWithValue("@titulo", item.titulo)

        'Dim iResultado As Integer
        oConexion.Open() ' abrir conexión
        Return oComando.ExecuteScalar
        MessageBox.Show("Plan de Estudio Guardado")


    End Function

    Public Sub Update(ByVal item As Entidades.__PlanEstudio_figuls)
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

                'le asignamos los parámetros para el stored procedure
                'los valores viene en el parámetro item del procedimiento
                oComando.Parameters.AddWithValue("@cd_plan_estudio", item.cdPlanEstudio)
                oComando.Parameters.AddWithValue("@titulo", item.titulo)
                oComando.Parameters.AddWithValue("@estado", item.estado)
                'Ejecutamos el comando 
                oComando.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    Public Function GetMaxID() As Integer
        Dim res As OleDbDataReader
        res = General.Seleccion("SELECT MAX(cd_plan_estudio) AS max FROM Alumnos.PLAN_ESTUDIO")

        res.Read()
        Dim maxId As New Integer
        maxId = res.Item(0)

        Return maxId
    End Function

    Public Function GetAll() As ArrayList
        Dim res As OleDbDataReader
        res = General.Seleccion("SELECT CD_PLAN_ESTUDIO, TITULO FROM Alumnos.PLAN_ESTUDIO")
        Dim lista As New ArrayList

        While res.Read()
            Dim alu As New Entidades.__PlanEstudio_figuls
            alu.cdPlanEstudio = res.Item("CD_PLAN_ESTUDIO")
            alu.titulo = res.Item("TITULO")
            lista.Add(alu)
        End While
        Return lista
    End Function

    'Public Function GetAllByAlumno(ByVal codAlumno As String) As ArrayList
    '    Dim res As OleDbDataReader
    '    res = General.Seleccion("SELECT PLAN_ESTUDIO.cd_plan_estudio, PLAN_ESTUDIO.titulo, PLAN_ESTUDIO.estado, INSCRIPCION_PLAN.cd_alumno FROM Alumnos.PLAN_ESTUDIO INNER JOIN Alumnos.INSCRIPCION_PLAN ON PLAN_ESTUDIO.cd_plan_estudio = INSCRIPCION_PLAN.cd_plan_estudio WHERE (INSCRIPCION_PLAN.cd_alumno = " + codAlumno + ")")
    '    Dim lista As New ArrayList

    '    While res.Read()
    '        Dim alu As New Entidades.__PlanEstudio_figuls
    '        alu.cdPlanEstudio = res.Item("CD_PLAN_ESTUDIO")
    '        alu.titulo = res.Item("TITULO")
    '        lista.Add(alu)
    '    End While
    '    Return lista
    'End Function

End Class
