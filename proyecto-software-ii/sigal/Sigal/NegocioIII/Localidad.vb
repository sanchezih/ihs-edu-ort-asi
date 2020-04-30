Public Class Localidad
    Public Function get_all() As List(Of Entidades.Localidad)
        Dim o_datos_localidad As Datos.Localidad
        Try
            o_datos_localidad = New Datos.Localidad
            Return o_datos_localidad.get_all()
        Finally
            o_datos_localidad = Nothing
        End Try
    End Function
End Class
