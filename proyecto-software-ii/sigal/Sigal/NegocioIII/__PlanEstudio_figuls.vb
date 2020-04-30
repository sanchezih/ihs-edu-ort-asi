Public Class __PlanEstudio_figuls

    Public Function GetAllByFiltros(ByVal codPlan As String, ByVal titulo As String) As List(Of Entidades.__PlanEstudio_figuls)
        'Utiliza la capa de datos para la operación
        'Si hay alguna validación extra a realizar este es el momento de hacerla
        Dim oDatos As Datos.__PlanEstudio_figuls
        Try
            'Crea una instancia de la clase citas de la capa de datos
            'para realizar la operación y delegar la tarea
            oDatos = New Datos.__PlanEstudio_figuls

            Return oDatos.GetAllByFiltros(codPlan, titulo)

        Finally
            oDatos = Nothing
        End Try

    End Function
   
    Public Function Add(ByVal item As Entidades.__PlanEstudio_figuls) As Int32
        'Utiliza la capa de datos para la operación
        'Si hay alguna validación extra a realizar este es el momento de hacerla
        Dim oDatos As Datos.__PlanEstudio_figuls
        Try
            'Crea una instancia de la clase citas de la capa de datos
            'para realizar la operación y delegar la tarea
            oDatos = New Datos.__PlanEstudio_figuls

            Return oDatos.Add(item)
        Finally
            oDatos = Nothing
        End Try
    End Function
   
    Public Sub Update(ByVal item As Entidades.__PlanEstudio_figuls)
        'Utiliza la capa de datos para la operación
        'Si hay alguna validación extra a realizar este es el momento de hacerla
        Dim oDatos As Datos.__PlanEstudio_figuls
        Try
            'Crea una instancia de la clase citas de la capa de datos
            'para realizar la operación y delegar la tarea
            oDatos = New Datos.__PlanEstudio_figuls

            oDatos.Update(item)
        Finally
            oDatos = Nothing
        End Try

    End Sub

    Public Function GetMaxID() As Integer

        Dim oDatos As Datos.__PlanEstudio_figuls
        Try
            'Crea una instancia de la clase citas de la capa de datos
            'para realizar la operación y delegar la tarea
            oDatos = New Datos.__PlanEstudio_figuls

            Return oDatos.GetMaxID
        Finally
            oDatos = Nothing
        End Try

    End Function

    Public Function GetAll() As ArrayList
        Dim oDatos As Datos.__PlanEstudio_figuls
        Try
            oDatos = New Datos.__PlanEstudio_figuls
            Return oDatos.GetAll()
        Finally
            oDatos = Nothing
        End Try

    End Function

    'Public Function GetAllByAlumno(ByVal codAlumno As String) As ArrayList
    '    Dim oDatos As Datos.__PlanEstudio_figuls
    '    Try
    '        oDatos = New Datos.__PlanEstudio_figuls
    '        Return oDatos.GetAllByAlumno(codAlumno)
    '    Finally
    '        oDatos = Nothing
    '    End Try

    'End Function

End Class
