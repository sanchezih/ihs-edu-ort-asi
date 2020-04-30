Public Class Pais
    Public Function get_all() As List(Of Entidades.Pais)
        Dim oDatos As Datos.Pais
        Try
            oDatos = New Datos.Pais
            Return oDatos.get_all()
        Finally
            oDatos = Nothing
        End Try
    End Function
End Class
