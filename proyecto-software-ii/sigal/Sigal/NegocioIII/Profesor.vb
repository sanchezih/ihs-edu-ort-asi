Public Class Profesor

    Public Function get_all_by_filtros(ByVal cd_profesor As Int32, ByVal nombre_profesor As String, ByVal apellido_profesor As String) As List(Of Entidades.Profesor)
        Dim o_datos_profesor As Datos.Profesor
        Try
            o_datos_profesor = New Datos.Profesor
            Return o_datos_profesor.get_all_by_filtros(cd_profesor, nombre_profesor, apellido_profesor)
        Finally
            o_datos_profesor = Nothing
        End Try
    End Function

    Public Function add(ByVal item As Entidades.Profesor) As Int32
        Dim o_datos_materia As Datos.Profesor
        Try
            o_datos_materia = New Datos.Profesor
            Return o_datos_materia.add(item)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

    Public Function get_profesores_con_estado_alta() As List(Of Entidades.Profesor)
        Dim o_datos_localidad As Datos.Profesor
        Try
            o_datos_localidad = New Datos.Profesor
            Return o_datos_localidad.get_profesores_con_estado_alta()
        Finally
            o_datos_localidad = Nothing
        End Try
    End Function

    Public Function get_profes_que_dan_algun_curso() As List(Of Entidades.Profesor)
        Dim o_datos_localidad As Datos.Profesor
        Try
            o_datos_localidad = New Datos.Profesor
            Return o_datos_localidad.get_profes_que_dan_algun_curso()
        Finally
            o_datos_localidad = Nothing
        End Try
    End Function
End Class
