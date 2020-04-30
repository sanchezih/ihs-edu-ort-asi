Public Class Materia

    Public Function get_all_by_filtros(ByVal cd_materia As String, ByVal nombre_materia As String) As List(Of Entidades.Materia)
        'Utiliza la capa de datos para la operación
        'Si hay alguna validación extra a realizar este es el momento de hacerla
        Dim o_datos_materia As Datos.Materia
        Try
            'Crea una instancia de la clase citas de la capa de datos
            'para realizar la operación y delegar la tarea
            o_datos_materia = New Datos.Materia

            Return o_datos_materia.get_all_by_filtros(cd_materia, nombre_materia)

        Finally
            o_datos_materia = Nothing
        End Try

    End Function

    Public Function add(ByVal item As Entidades.Materia) As Int32
        Dim o_datos_materia As Datos.Materia
        Try
            o_datos_materia = New Datos.Materia
            Return o_datos_materia.add(item)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

    Public Sub update(ByVal item As Entidades.Materia)
        'Utiliza la capa de datos para la operación
        'Si hay alguna validación extra a realizar este es el momento de hacerla
        Dim o_datos_materia As Datos.Materia
        Try
            'Crea una instancia de la clase citas de la capa de datos
            'para realizar la operación y delegar la tarea
            o_datos_materia = New Datos.Materia

            o_datos_materia.update(item)
        Finally
            o_datos_materia = Nothing
        End Try

    End Sub

    Public Function get_all(ByVal cd_plan_estudio As String) As ArrayList
        Dim o_datos_materia As Datos.Materia
        Try
            o_datos_materia = New Datos.Materia
            Return o_datos_materia.get_all(cd_plan_estudio)
        Finally
            o_datos_materia = Nothing
        End Try

    End Function

    Public Function GetAllIsNotPlanEstudio(ByVal codPlanEstudio As String) As ArrayList
        Dim o_datos_materia As Datos.Materia
        Try
            o_datos_materia = New Datos.Materia
            Return o_datos_materia.GetAllIsNotPlanEstudio(codPlanEstudio)
        Finally
            o_datos_materia = Nothing
        End Try

    End Function

    Public Function get_materias_de_un_plan(ByVal plan As Entidades.Plan) As List(Of Entidades.Materia)
        Dim o_datos_materia As Datos.Materia
        Try
            o_datos_materia = New Datos.Materia
            Return o_datos_materia.get_materias_de_un_plan(plan)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

    Public Function get_materias_que_pertenecen_a_un_curso() As List(Of Entidades.Materia)
        Dim o_datos_materia As Datos.Materia
        Try
            o_datos_materia = New Datos.Materia
            Return o_datos_materia.get_materias_que_pertenecen_a_un_curso()
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

    Public Function get_materias_que_pueden_tener_correl(ByVal plan As Entidades.Plan) As List(Of Entidades.Materia)
        Dim o_datos_materia As Datos.Materia
        Try
            o_datos_materia = New Datos.Materia
            Return o_datos_materia.get_materias_que_pueden_tener_correl(plan)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

    Public Function get_materias_que_pueden_ser_correl(ByVal plan As Entidades.Plan, ByVal materia As Entidades.Materia) As List(Of Entidades.Materia)
        Dim o_datos_materia As Datos.Materia
        Try
            o_datos_materia = New Datos.Materia
            Return o_datos_materia.get_materias_que_pueden_ser_correl(plan, materia)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

    Public Function get_materias_que_tienen_corel(ByVal plan As Entidades.Plan) As List(Of Entidades.Materia)
        Dim o_datos_materia As Datos.Materia
        Try
            o_datos_materia = New Datos.Materia
            Return o_datos_materia.get_materias_que_tienen_corel(plan)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

    Public Function get_one(ByVal cd_materia As String) As List(Of Entidades.Materia)
        'Utiliza la capa de datos para la operación
        'Si hay alguna validación extra a realizar este es el momento de hacerla
        Dim o_datos_materia As Datos.Materia
        Try
            'Crea una instancia de la clase citas de la capa de datos
            'para realizar la operación y delegar la tarea
            o_datos_materia = New Datos.Materia

            Return o_datos_materia.get_one(cd_materia)

        Finally
            o_datos_materia = Nothing
        End Try

    End Function

    Public Function get_materias_para_alta_pmc(ByVal plan As Entidades.Plan, ByVal cuat As Integer) As List(Of Entidades.Materia)
        Dim o_datos_materia As Datos.Materia
        Try
            o_datos_materia = New Datos.Materia
            Return o_datos_materia.get_materias_para_alta_pmc(plan, cuat)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

End Class
