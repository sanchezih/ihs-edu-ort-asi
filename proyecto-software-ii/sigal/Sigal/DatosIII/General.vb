Imports System.Data.SqlClient
Imports System.Data.OleDb
Module General

    Private con As OleDbConnection

    Public Function getConexion() As OleDbConnection
        If (con Is Nothing) Then
            con = New OleDbConnection("Provider=SQLOLEDB;Data Source=zara;Integrated Security=SSPI;Initial Catalog=Sigal")
            con.Open()
        End If
        Return con
    End Function

    Private Function query(ByVal stmt As String) As Integer
        Dim command As New OleDbCommand
        command.CommandText = stmt
        command.CommandType = CommandType.Text
        command.Connection = getConexion()
        Dim res As Integer = command.ExecuteNonQuery()
        Return res
    End Function

    'Public Function Insert(ByVal sqlInsert As String) As Integer
    '    Return query(sqlInsert)
    'End Function

    'Public Function Delete(ByVal sqlDelete As String) As Integer
    '    Return query(sqlDelete)
    'End Function

    'Public Function Update(ByVal sqlUpdate As String) As Integer
    '    Return query(sqlUpdate)
    'End Function

    Public Function Seleccion(ByVal sqlSelect As String) As OleDbDataReader
        Dim command As New OleDbCommand
        command.CommandText = sqlSelect
        command.CommandType = CommandType.Text
        command.Connection = getConexion()
        Dim res As OleDbDataReader = command.ExecuteReader()
        Return res
    End Function

    '   Public Shared Function SeleccionStore(ByVal sqlProcedimiento As String) As SqlCommand
    'Dim command As New SqlCommand
    '   command.CommandText = sqlProcedimiento
    '  command.CommandType = CommandType.StoredProcedure
    ' command.Connection = getConexion()
    '    command.ExecuteScalar()
    '    Return command
    'End Function

    Const consKeyDefaultCnnString As String = "DefaultCnnString"

    Public Function CreateConnection() As SqlConnection
        Dim oCnn As SqlConnection
        Dim ConnectionString As String = ""
        Try
            'Obtenemos el ConnectionString desde el archivo de configuración
            ConnectionString = Configuracion.ConfigManager.GetValue(consKeyDefaultCnnString)

            'Creamos una conexión
            oCnn = New SqlConnection

            'Asignamos el connectionString que se obtenido del archivo de configuración
            oCnn.ConnectionString = Configuracion.ConfigManager.GetValue(consKeyDefaultCnnString)
            'Retornamos el objeto conexion creado
            Return oCnn

        Finally
            'No nos olvidemos de eliminar las referencias a objetos que no utilicemos
            oCnn = Nothing
        End Try
    End Function

End Module
