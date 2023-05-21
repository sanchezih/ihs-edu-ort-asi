Public Class Curso

#Region "FIGULS"

    ''' <summary>
    ''' retorna todas los cursos de la base de datos
    ''' </summary>
    ''' <remarks></remarks>
    Public Function GetAllByFiltros(ByVal anioCurso As String, ByVal materia As String) As List(Of Entidades.Curso)
        'Utiliza la capa de datos para la operación
        'Si hay alguna validación extra a realizar este es el momento de hacerla
        Dim oDatos As Datos.Curso
        Try
            'Crea una instancia de la clase citas de la capa de datos
            'para realizar la operación y delegar la tarea
            oDatos = New Datos.Curso

            Return oDatos.GetAllByFiltros(anioCurso, materia)

        Finally
            oDatos = Nothing
        End Try

    End Function
    'Public Function Add(ByVal item As Entidades.Curso) As Int32
    '    'Utiliza la capa de datos para la operación
    '    'Si hay alguna validación extra a realizar este es el momento de hacerla
    '    Dim oDatos As Datos.Curso
    '    Try
    '        'Crea una instancia de la clase citas de la capa de datos
    '        'para realizar la operación y delegar la tarea
    '        oDatos = New Datos.Curso

    '        Return oDatos.add(item)
    '    Finally
    '        oDatos = Nothing
    '    End Try
    'End Function

    ''' <summary>
    ''' Actualiza un plan de estudio en la base de datos
    ''' </summary>
    ''' <param name="item"></param>
    ''' <remarks></remarks>
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

    Public Function GetAllByCurso(ByVal cdCurso As String) As List(Of Entidades.Curso)
        'Utiliza la capa de datos para la operación
        'Si hay alguna validación extra a realizar este es el momento de hacerla
        Dim oDatos As Datos.Curso
        Try
            'Crea una instancia de la clase citas de la capa de datos
            'para realizar la operación y delegar la tarea
            oDatos = New Datos.Curso

            Return oDatos.GetAllByCurso(cdCurso)

        Finally
            oDatos = Nothing
        End Try

    End Function

    Public Function GetAll() As ArrayList
        Dim oDatos As Datos.Curso
        Try
            oDatos = New Datos.Curso
            Return oDatos.GetAll()
        Finally
            oDatos = Nothing
        End Try

    End Function

    Public Function GetAllByPlan(ByVal codPlanEstudio As String) As ArrayList
        Dim oDatos As Datos.Curso
        Try
            oDatos = New Datos.Curso
            Return oDatos.GetAllByPlan(codPlanEstudio)
        Finally
            oDatos = Nothing
        End Try

    End Function
#End Region


    Public Function add(ByVal item As Entidades.Curso) As Int32
        Dim o_datos_curso As Datos.Curso
        Try
            o_datos_curso = New Datos.Curso
            Return o_datos_curso.add(item)
        Finally
            o_datos_curso = Nothing
        End Try
    End Function

    Public Function get_all_by_filtros(ByVal cd_curso As Int32, ByVal estado As Integer, ByVal anio As Integer, ByVal materia As String, ByVal profesor As Int32) As List(Of Entidades.Curso)
        Dim o_datos_curso As Datos.Curso
        Try
            o_datos_curso = New Datos.Curso
            Return o_datos_curso.get_all_by_filtros(cd_curso, estado, anio, materia, profesor)
        Finally
            o_datos_curso = Nothing
        End Try
    End Function

    Public Function get_cursos_que_permiten_inscripciones(ByVal plan As Entidades.Plan) As List(Of Entidades.Curso)
        Dim o_datos_materia As Datos.Curso
        Try
            o_datos_materia = New Datos.Curso
            Return o_datos_materia.get_cursos_que_permiten_inscripciones(plan)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

    Public Function get_cursos_activos_de_un_plan(ByVal plan As Entidades.Plan) As List(Of Entidades.Curso)
        Dim o_datos_localidad As Datos.Curso
        Try
            o_datos_localidad = New Datos.Curso
            Return o_datos_localidad.get_cursos_activos_de_un_plan(plan)
        Finally
            o_datos_localidad = Nothing
        End Try
    End Function

    Public Function GET_CURSOS_DE_PLAN_PARA_CALIF_FINAL(ByVal plan As Entidades.Plan) As List(Of Entidades.Curso)
        Dim o_datos_localidad As Datos.Curso
        Try
            o_datos_localidad = New Datos.Curso
            Return o_datos_localidad.get_cursos_de_plan_para_calif_final(plan)
        Finally
            o_datos_localidad = Nothing
        End Try
    End Function

    Public Function get_cursos_de_plan_para_calif_final(ByVal plan) As List(Of Entidades.Curso)
        Dim o_datos_localidad As Datos.Curso
        Try
            o_datos_localidad = New Datos.Curso
            Return o_datos_localidad.get_cursos_de_plan_para_calif_final(plan)
        Finally
            o_datos_localidad = Nothing
        End Try
    End Function

    Public Function get_one(ByVal cd_curso As Int32) As List(Of Entidades.Curso)
        Dim o_datos_plan As Datos.Curso
        Try

            o_datos_plan = New Datos.Curso

            Return o_datos_plan.get_one(cd_curso)

        Finally
            o_datos_plan = Nothing
        End Try

    End Function

    Public Sub update(ByVal item As Entidades.Curso)
        Dim o_datos_curso As Datos.Curso
        Try
            o_datos_curso = New Datos.Curso
            o_datos_curso.Update(item)
        Finally
            o_datos_curso = Nothing
        End Try

    End Sub

    Public Sub delete(ByVal cd_curso As Int32)
        Dim o_datos_curso As Datos.Curso
        Try
            o_datos_curso = New Datos.Curso
            o_datos_curso.delete(cd_curso)
        Finally
            o_datos_curso = Nothing
        End Try

    End Sub

End Class