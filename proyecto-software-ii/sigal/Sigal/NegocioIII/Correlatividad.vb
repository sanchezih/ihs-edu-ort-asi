Public Class Correlatividad

    Public Function add(ByVal item As Entidades.Correlatividad) As Int32
        Dim o_datos_correlatividad As Datos.Correlatividad
        Try
            o_datos_correlatividad = New Datos.Correlatividad
            Return o_datos_correlatividad.add(item)
        Finally
            o_datos_correlatividad = Nothing
        End Try
    End Function

    Public Function get_all_by_filtros(ByVal cd_plan_estudio As String, ByVal cd_materia As String) As List(Of Entidades.Correlatividad)
        Dim o_datos_correlatividad As Datos.Correlatividad
        Try
            o_datos_correlatividad = New Datos.Correlatividad

            Return o_datos_correlatividad.get_all_by_filtros(cd_plan_estudio, cd_materia)

        Finally
            o_datos_correlatividad = Nothing
        End Try

    End Function

    Public Sub delete(ByVal cd_plan_estudio As String, ByVal cd_materia As String, ByVal cd_materia_correlativa As String)
        Dim oDatos As Datos.Correlatividad
        Try
            oDatos = New Datos.Correlatividad
            oDatos.delete(cd_plan_estudio, cd_materia, cd_materia_correlativa)
        Finally
            oDatos = Nothing
        End Try

    End Sub

    Public Function consulta_cantidad_correlativas(ByVal cd_plan_estudio As String, ByVal cd_materia As String) As Int32
        Dim o_datos_correlatividad As Datos.Correlatividad
        Try
            o_datos_correlatividad = New Datos.Correlatividad

            Return o_datos_correlatividad.consulta_cantidad_correlativas(cd_plan_estudio, cd_materia)

        Finally
            o_datos_correlatividad = Nothing
        End Try

    End Function

End Class
