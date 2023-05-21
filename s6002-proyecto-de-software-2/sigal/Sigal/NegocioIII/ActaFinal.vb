Public Class ActaFinal

    Public Function add(ByVal item As Entidades.ActaFinal) As Int32
        Dim o_datos_actaFinal As Datos.ActaFinal
        Try
            o_datos_actaFinal = New Datos.ActaFinal
            Return o_datos_actaFinal.add(item)
        Finally
            o_datos_actaFinal = Nothing
        End Try
    End Function

    Public Function get_all_by_filtros(ByVal cd_curso As Int32, ByVal cd_alumno As Int32, ByVal nombre_alumno As String, ByVal apellido_alumno As String) As List(Of Entidades.ActaFinal)
        Dim o_datos_calificacionCursada As Datos.ActaFinal
        Try
            o_datos_calificacionCursada = New Datos.ActaFinal
            Return o_datos_calificacionCursada.get_all_by_filtros(cd_curso, cd_alumno, nombre_alumno, apellido_alumno)
        Finally
            o_datos_calificacionCursada = Nothing
        End Try

    End Function

End Class
