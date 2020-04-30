Public Class ActaCursada

    Public Function get_all_by_filtros(ByVal cd_curso As Int32, ByVal cd_alumno As Int32, ByVal nombre_alumno As String, ByVal apellido_alumno As String) As List(Of Entidades.ActaCursada)
        Dim o_datos_calificacionCursada As Datos.ActaCursada
        Try
            o_datos_calificacionCursada = New Datos.ActaCursada
            Return o_datos_calificacionCursada.get_all_by_filtros(cd_curso, cd_alumno, nombre_alumno, apellido_alumno)
        Finally
            o_datos_calificacionCursada = Nothing
        End Try

    End Function

    Public Function add(ByVal item As Entidades.ActaCursada) As Int32
        Dim o_datos_actaCursada As Datos.ActaCursada
        Try
            o_datos_actaCursada = New Datos.ActaCursada
            Return o_datos_actaCursada.add(item)
        Finally
            o_datos_actaCursada = Nothing
        End Try
    End Function

End Class
