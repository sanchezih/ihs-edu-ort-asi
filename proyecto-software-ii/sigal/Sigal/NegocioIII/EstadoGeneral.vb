Public Class EstadoGeneral

    'Public Function get_all() As ArrayList
    '    Dim o_datos_estadoGeneral As Datos.EstadoGeneral
    '    Try
    '        o_datos_estadoGeneral = New Datos.EstadoGeneral
    '        Return o_datos_estadoGeneral.get_all()
    '    Finally
    '        o_datos_estadoGeneral = Nothing
    '    End Try
    'End Function

    Public Function get_all() As List(Of Entidades.EstadoGeneral)
        Dim o_datos_estadoGeneral As Datos.EstadoGeneral
        Try
            o_datos_estadoGeneral = New Datos.EstadoGeneral
            Return o_datos_estadoGeneral.get_all()
        Finally
            o_datos_estadoGeneral = Nothing
        End Try
    End Function

End Class
