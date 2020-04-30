Public Class Plan

    Public Function get_all_by_filtros(ByVal cd_plan_estudio As String, ByVal titulo As String) As List(Of Entidades.Plan)
        Dim o_datos_plan As Datos.Plan
        Try
            o_datos_plan = New Datos.Plan
            Return o_datos_plan.get_all_by_filtros(cd_plan_estudio, titulo)
        Finally
            o_datos_plan = Nothing
        End Try
    End Function

    Public Function add(ByVal item As Entidades.Plan) As Int32
        Dim o_datos_plan As Datos.Plan
        Try
            o_datos_plan = New Datos.Plan
            Return o_datos_plan.add(item)
        Finally
            o_datos_plan = Nothing
        End Try
    End Function

    Public Function get_planes_con_estado_alta() As List(Of Entidades.Plan)
        Dim o_datos_localidad As Datos.Plan
        Try
            o_datos_localidad = New Datos.Plan
            Return o_datos_localidad.get_planes_con_estado_alta()
        Finally
            o_datos_localidad = Nothing
        End Try
    End Function

    Public Function get_planes() As List(Of Entidades.Plan)
        Dim o_datos_localidad As Datos.Plan
        Try
            o_datos_localidad = New Datos.Plan
            Return o_datos_localidad.get_planes()
        Finally
            o_datos_localidad = Nothing
        End Try
    End Function

    Public Function get_planes_con_al_menos_un_curso_activo() As List(Of Entidades.Plan)
        Dim o_datos_localidad As Datos.Plan
        Try
            o_datos_localidad = New Datos.Plan
            Return o_datos_localidad.get_planes_con_al_menos_un_curso_activo()
        Finally
            o_datos_localidad = Nothing
        End Try
    End Function

    Public Function get_planes_que_tienen_cursos_sin_todas_las_notas_informadas() As List(Of Entidades.Plan)
        Dim o_datos_localidad As Datos.Plan
        Try
            o_datos_localidad = New Datos.Plan
            Return o_datos_localidad.get_planes_que_tienen_cursos_sin_todas_las_notas_informadas()
        Finally
            o_datos_localidad = Nothing
        End Try
    End Function

    Public Function get_one(ByVal cd_plan As String) As List(Of Entidades.Plan)
        Dim o_datos_plan As Datos.Plan
        Try

            o_datos_plan = New Datos.Plan

            Return o_datos_plan.get_one(cd_plan)

        Finally
            o_datos_plan = Nothing
        End Try

    End Function

    Public Sub update(ByVal item As Entidades.Plan)
        Dim o_datos_plan As Datos.Plan
        Try
            o_datos_plan = New Datos.Plan
            o_datos_plan.update(item)
        Finally
            o_datos_plan = Nothing
        End Try

    End Sub

End Class
