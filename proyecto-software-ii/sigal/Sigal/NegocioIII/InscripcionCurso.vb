Public Class InscripcionCurso

    Public Function add(ByVal item As Entidades.InscripcionCurso) As Int32
        Dim o_datos_correlatividad As Datos.InscripcionCurso
        Try
            o_datos_correlatividad = New Datos.InscripcionCurso
            Return o_datos_correlatividad.add(item)
        Finally
            o_datos_correlatividad = Nothing
        End Try
    End Function

    Public Function get_all_by_filtros(ByVal cd_plan_estudio As String, ByVal cd_curso As Int32, ByVal cd_alumno As Int32) As List(Of Entidades.InscripcionCurso)
        Dim o_datos_inscripcionCurso As Datos.InscripcionCurso
        Try
            o_datos_inscripcionCurso = New Datos.InscripcionCurso

            Return o_datos_inscripcionCurso.get_all_by_filtros(cd_plan_estudio, cd_curso, cd_alumno)

        Finally
            o_datos_inscripcionCurso = Nothing
        End Try

    End Function

    Public Function consulta_cantidad_inscriptos(ByVal cd_curso As Int32) As Int32
        Dim o_datos_inscripcionCurso As Datos.InscripcionCurso
        Try
            o_datos_inscripcionCurso = New Datos.InscripcionCurso

            Return o_datos_inscripcionCurso.consulta_cantidad_inscriptos(cd_curso)

        Finally
            o_datos_inscripcionCurso = Nothing
        End Try

    End Function

End Class
