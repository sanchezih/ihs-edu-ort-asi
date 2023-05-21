Public Class Alumno

    Public Function get_all_by_filtros(ByVal cd_alumno As Int32, ByVal nombre_alumno As String, ByVal apellido_alumno As String) As List(Of Entidades.Alumno)
        'Utiliza la capa de datos para la operación
        'Si hay alguna validación extra a realizar este es el momento de hacerla
        Dim o_datos_alumno As Datos.Alumno
        Try
            'Crea una instancia de la clase citas de la capa de datos
            'para realizar la operación y delegar la tarea
            o_datos_alumno = New Datos.Alumno

            Return o_datos_alumno.get_all_by_filtros(cd_alumno, nombre_alumno, apellido_alumno)

        Finally
            o_datos_alumno = Nothing
        End Try

    End Function

    Public Function add(ByVal item As Entidades.Alumno) As Int32
        Dim o_datos_alumno As Datos.Alumno
        Try
            o_datos_alumno = New Datos.Alumno
            Return o_datos_alumno.add(item)
        Finally
            o_datos_alumno = Nothing
        End Try
    End Function

    Public Function get_alumnos_aptos_inscripcion_plan(ByVal plan As Entidades.Plan) As List(Of Entidades.Alumno)
        Dim o_datos_materia As Datos.Alumno
        Try
            o_datos_materia = New Datos.Alumno
            Return o_datos_materia.get_alumnos_aptos_inscripcion_plan(plan)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

    Public Function get_alumnos_aptos_inscripcion_curso(ByVal plan As Entidades.Plan, ByVal curso As Entidades.Curso) As List(Of Entidades.Alumno)
        Dim o_datos_alumno As Datos.Alumno
        Try
            o_datos_alumno = New Datos.Alumno
            Return o_datos_alumno.get_alumnos_aptos_inscripcion_curso(plan, curso)
        Finally
            o_datos_alumno = Nothing
        End Try
    End Function

    Public Function get_alumnos_para_calificacion_cursada(ByVal curso As Entidades.Curso) As List(Of Entidades.Alumno)
        Dim o_datos_alumno As Datos.Alumno
        Try
            o_datos_alumno = New Datos.Alumno
            Return o_datos_alumno.get_alumnos_para_calificacion_cursada(curso)
        Finally
            o_datos_alumno = Nothing
        End Try
    End Function

    Public Function get_alumnos_para_calificacion_final(ByVal curso As Entidades.Curso) As List(Of Entidades.Alumno)
        Dim o_datos_alumno As Datos.Alumno
        Try
            o_datos_alumno = New Datos.Alumno
            Return o_datos_alumno.get_alumnos_para_calificacion_final(curso)
        Finally
            o_datos_alumno = Nothing
        End Try
    End Function

    Public Function get_one(ByVal cd_alumno As Int32) As List(Of Entidades.Alumno)
        Dim o_datos_alumno As Datos.Alumno
        Try

            o_datos_alumno = New Datos.Alumno

            Return o_datos_alumno.get_one(cd_alumno)

        Finally
            o_datos_alumno = Nothing
        End Try

    End Function

    Public Sub update(ByVal item As Entidades.Alumno)
        Dim o_datos_alumno As Datos.Alumno
        Try
            o_datos_alumno = New Datos.Alumno
            o_datos_alumno.update(item)
        Finally
            o_datos_alumno = Nothing
        End Try

    End Sub

End Class
