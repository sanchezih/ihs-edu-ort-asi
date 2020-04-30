Public Class InscripcionPlan

    Public Function add(ByVal item As Entidades.InscripcionPlan) As Int32
        Dim o_datos_correlatividad As Datos.InscripcionPlan
        Try
            o_datos_correlatividad = New Datos.InscripcionPlan
            Return o_datos_correlatividad.add(item)
        Finally
            o_datos_correlatividad = Nothing
        End Try
    End Function

    Public Function get_all_by_filtros(ByVal cd_plan_estudio As String, ByVal cd_alumno As Int32) As List(Of Entidades.InscripcionPlan)
        Dim o_datos_inscripcionPlan As Datos.InscripcionPlan
        Try
            o_datos_inscripcionPlan = New Datos.InscripcionPlan

            Return o_datos_inscripcionPlan.get_all_by_filtros(cd_plan_estudio, cd_alumno)

        Finally
            o_datos_inscripcionPlan = Nothing
        End Try

    End Function

End Class
