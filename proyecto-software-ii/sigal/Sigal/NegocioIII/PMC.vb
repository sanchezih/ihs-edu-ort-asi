Public Class PMC

    Public Function add(ByVal item As Entidades.PMC) As Int32
        Dim o_datos_pmc As Datos.PMC
        Try
            o_datos_pmc = New Datos.PMC
            Return o_datos_pmc.add(item)
        Finally
            o_datos_pmc = Nothing
        End Try
    End Function

    Public Function get_all_by_filtros(ByVal cd_plan_estudio As String, ByVal cuatrimestre_carrera As Int32) As List(Of Entidades.PMC)
        Dim o_datos_materia As Datos.PMC
        Try
            o_datos_materia = New Datos.PMC

            Return o_datos_materia.get_all_by_filtros(cd_plan_estudio, cuatrimestre_carrera)

        Finally
            o_datos_materia = Nothing
        End Try

    End Function

    Public Sub delete(ByVal cd_plan_estudio As String, ByVal cd_materia As String, ByVal cuatrimestre As Int32)
        Dim oDatos As Datos.PMC
        Try
            oDatos = New Datos.PMC
            oDatos.delete(cd_plan_estudio, cd_materia, cuatrimestre)
        Finally
            oDatos = Nothing
        End Try

    End Sub

End Class
