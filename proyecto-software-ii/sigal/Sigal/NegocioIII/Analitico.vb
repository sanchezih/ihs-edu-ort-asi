Public Class Analitico

    Public Function get_all_by_filtros(ByVal cd_alumno As Int32, ByVal nombre_alumno As String, ByVal apellido_alumno As String) As List(Of Entidades.Analitico)
        Dim o_datos_analitico As Datos.Analitico
        Try
            o_datos_analitico = New Datos.Analitico
            Return o_datos_analitico.get_all_by_filtros(cd_alumno, nombre_alumno, apellido_alumno)
        Finally
            o_datos_analitico = Nothing
        End Try
    End Function

End Class
