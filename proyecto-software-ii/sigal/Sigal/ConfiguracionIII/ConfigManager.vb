Imports System
Imports System.Configuration
Imports System.Web.Configuration
Public Class ConfigManager

    ''' <summary>
    ''' Obtiene la seccion de configuracion del archivo 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Shared Function GetConfiguration() As Configuration

        Dim Path As String 'Path del archivo de configuracion
        Dim Config As Configuration 'Objeto configuracion
        'verificamos entorno
        If System.Web.HttpContext.Current Is Nothing Then
            'Windows
            Path = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName)
            'abrimos configuracion windows
            Config = ConfigurationManager.OpenExeConfiguration(Path)
        Else
            'Web
            Path = System.Web.HttpContext.Current.Request.ApplicationPath
            'abrimos configuracion Web
            Config = WebConfigurationManager.OpenWebConfiguration(Path)
        End If
        Return Config
    End Function

    ''' <summary>
    ''' Lee un valor de la configuracion
    ''' </summary>
    ''' <param name="Key"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetValue(ByVal Key As String) As String
        Dim Config As Configuration 'Objeto configuracion
        Dim Value As String
        Try

            'obtengo configuracion 
            Config = GetConfiguration()

            Try
                'Obtengo el valor
                Value = Config.AppSettings.Settings(Key).Value
            Catch ex As Exception
                'Si no existe creo una exception
                Throw New KeyNotFoundException(String.Format("Error: la clave '{0}' no existe en el archivo de configuración.", Key), ex)
            End Try
            Return Value
        Finally
            Config = Nothing
        End Try
    End Function

End Class

