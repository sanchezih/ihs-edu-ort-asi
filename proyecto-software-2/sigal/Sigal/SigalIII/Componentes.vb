Imports System.Text.RegularExpressions

Public Class Componentes

#Region "FIGULS"


    Dim listaDeAlumnos As New ArrayList
    Dim oPlanNegocio As New Negocio.__PlanEstudio_figuls
    Dim listaDePlanes As New ArrayList
    Dim oCursoNegocio As New Negocio.Curso
    Dim listaDeCursos As New ArrayList
    Dim oAlumno As New Entidades.__Alumno
    Dim oPlan As New Entidades.__PlanEstudio_figuls
    Dim listaDeMaterias As New ArrayList
    Dim oMateria As New Entidades.Materia
    Dim oMateriaNegocio As New Negocio.Materia

    'Public Sub LlenarComboAlumnos(ByVal ComboAlumno)
    '    ComboAlumno.Enabled = True
    '    ComboAlumno.Items.Clear()
    '    ComboAlumno.Text = "Seleccione un Plan..."
    '    listaDeAlumnos = oAlumnosNegocio.GetAll()
    '    ComboAlumno.DisplayMember = "ToString"
    '    ComboAlumno.ValueMember = "CdAlumno"
    '    ComboAlumno.Items.AddRange(listaDeAlumnos.ToArray)
    'End Sub

    Public Sub LlenarComboPlanEstudio(ByVal ComboBox1)
        ComboBox1.Enabled = True
        ComboBox1.Items.Clear()
        ComboBox1.Text = "Seleccione un Plan..."
        listaDePlanes = oPlanNegocio.GetAll()
        ComboBox1.DisplayMember = "titulo"
        ComboBox1.ValueMember = "cdPlanEstudio"
        ComboBox1.Items.AddRange(listaDePlanes.ToArray)
    End Sub

    'Public Sub LlenarComboPlanEstudioByAlumno(ByVal ComboPlanEstudio, ByVal ComboBoxAlumno)
    '    ComboPlanEstudio.Enabled = True
    '    oAlumno = ComboBoxAlumno.SelectedItem
    '    ComboPlanEstudio.Items.Clear()
    '    ComboPlanEstudio.Text = "Seleccione un Plan..."
    '    listaDePlanes = oPlanNegocio.GetAllByAlumno(oAlumno._cd_alumno)
    '    ComboPlanEstudio.DisplayMember = "titulo"
    '    ComboPlanEstudio.ValueMember = "cdPlanEstudio"
    '    ComboPlanEstudio.Items.AddRange(listaDePlanes.ToArray)
    'End Sub

    Public Sub LlenarComboCurso(ByVal ComboCurso)
        ComboCurso.Enabled = True
        ComboCurso.Items.Clear()
        ComboCurso.Text = "Seleccione un Plan..."
        listaDeCursos = oCursoNegocio.GetAll()
        ComboCurso.DisplayMember = "titulo"
        ComboCurso.ValueMember = "cdPlanEstudio"
        ComboCurso.Items.AddRange(listaDePlanes.ToArray)
    End Sub

    Public Sub LlenarComboCursoByPlanEstudio(ByVal ComboCurso, ByVal ComboPlanEstudio)
        ComboCurso.Enabled = True
        oPlan = ComboPlanEstudio.SelectedItem
        ComboCurso.Items.Clear()
        ComboCurso.Text = "Seleccione un Cod de Curso..."
        listaDeCursos = oCursoNegocio.GetAllByPlan(oPlan.cdPlanEstudio)
        ComboCurso.DisplayMember = "cdCurso"
        ComboCurso.ValueMember = "cdCurso"
        ComboCurso.Items.AddRange(listaDeCursos.ToArray)
    End Sub

    Public Sub LlenarComboMateriaIsNotPlanEstudio(ByVal ComboBoxMateria, ByVal ComboBoxPlan)
        ComboBoxMateria.Enabled = True
        oPlan = ComboBoxPlan.SelectedItem
        ComboBoxMateria.Items.Clear()
        ComboBoxMateria.Text = "Seleccione una Materia..."
        listaDeMaterias = oMateriaNegocio.GetAllIsNotPlanEstudio(oPlan.cdPlanEstudio)
        ComboBoxMateria.DisplayMember = "nombreMateria"
        ComboBoxMateria.ValueMember = "cdMateria"
        ComboBoxMateria.Items.AddRange(listaDeMaterias.ToArray)
    End Sub

#End Region

    Dim o_negocio_estado_general As New Negocio.EstadoGeneral
    Dim o_negocio_localidad As New Negocio.Localidad
    Dim o_negocio_pais As New Negocio.Pais
    Dim o_negocio_plan As New Negocio.Plan
    Dim o_negocio_profesor As New Negocio.Profesor
    Dim o_negocio_materia As New Negocio.Materia
    Dim o_negocio_alumno As New Negocio.Alumno
    Dim o_negocio_curso As New Negocio.Curso

    Dim plan As New Entidades.Plan
    Dim materia As New Entidades.Materia
    Dim cuat As New Int32
    Dim curso As New Entidades.Curso

    Dim lista_de_paises As List(Of Entidades.Pais)
    Dim lista_de_planes As List(Of Entidades.Plan)
    Dim lista_de_cursos As List(Of Entidades.Curso)
    Dim lista_de_alumnos As List(Of Entidades.Alumno)
    Dim lista_de_estados As List(Of Entidades.EstadoGeneral)
    Dim lista_de_materias As List(Of Entidades.Materia)
    Dim lista_de_profesores As List(Of Entidades.Profesor)
    Dim lista_de_localidades As List(Of Entidades.Localidad)


    Public Sub llenar_combo_estado(ByVal cb_desc_estado_general)
        cb_desc_estado_general.Enabled = True
        lista_de_estados = o_negocio_estado_general.get_all()
        cb_desc_estado_general.DisplayMember = "_desc_estado_general"
        cb_desc_estado_general.ValueMember = "_cd_estado_general"
        cb_desc_estado_general.Items.AddRange(lista_de_estados.ToArray)
    End Sub

    Public Sub llenar_combo_localidad(ByVal cb_desc_localidad)
        cb_desc_localidad.Enabled = True
        lista_de_localidades = o_negocio_localidad.get_all()
        cb_desc_localidad.DisplayMember = "_desc_localidad"
        cb_desc_localidad.ValueMember = "_cd_localidad"
        cb_desc_localidad.Items.AddRange(lista_de_localidades.ToArray)
    End Sub

    Public Sub llenar_combo_pais(ByVal cb_desc_pais)
        cb_desc_pais.Enabled = True
        lista_de_paises = o_negocio_pais.get_all()
        cb_desc_pais.DisplayMember = "_desc_pais"
        cb_desc_pais.ValueMember = "_cd_pais"
        cb_desc_pais.Items.AddRange(lista_de_paises.ToArray)
    End Sub

    Public Sub llenar_combo_con_cursos_activos_de_un_plan(ByVal cb_cursos, ByVal cb_planes, ByVal lb_alumnos)
        plan = cb_planes.SelectedItem
        cb_planes.Enabled = True
        cb_cursos.Items.Clear()
        lb_alumnos.Items.Clear()
        lista_de_cursos = o_negocio_curso.get_cursos_activos_de_un_plan(plan)
        cb_cursos.DisplayMember = "_cn"
        cb_cursos.ValueMember = "_cd_curso"
        cb_cursos.Items.AddRange(lista_de_cursos.ToArray)
    End Sub

    Public Sub llenar_combo_con_cursos_para_alta_calif_final(ByVal cb_cursos, ByVal cb_planes, ByVal lb_alumnos)
        plan = cb_planes.SelectedItem
        cb_planes.Enabled = True
        cb_cursos.Items.Clear()
        lb_alumnos.Items.Clear()
        lista_de_cursos = o_negocio_curso.get_cursos_de_plan_para_calif_final(plan)
        cb_cursos.DisplayMember = "_cn"
        cb_cursos.ValueMember = "_cd_curso"
        cb_cursos.Items.AddRange(lista_de_cursos.ToArray)
    End Sub

    Public Sub llenar_combo_con_cursos_de_plan_para_calif_final(ByVal cb_planes, ByVal cb_cursos, ByVal lb_alumnos)
        plan = cb_planes.SelectedItem
        cb_planes.Enabled = True
        cb_cursos.Items.Clear()
        lb_alumnos.Items.Clear()
        lista_de_cursos = o_negocio_curso.GET_CURSOS_DE_PLAN_PARA_CALIF_FINAL(plan)
        cb_cursos.DisplayMember = "_cn"
        cb_cursos.ValueMember = "_cd_curso"
        cb_cursos.Items.AddRange(lista_de_cursos.ToArray)
    End Sub

    Public Sub llenar_combo_con_planes_que_tienen_estado_activo(ByVal cb_planes)
        cb_planes.Enabled = True
        cb_planes.items.clear()
        lista_de_planes = o_negocio_plan.get_planes_con_estado_alta()
        cb_planes.DisplayMember = "_cd_plan_estudio_y_titulo"
        cb_planes.ValueMember = "_cd_plan_estudio"
        cb_planes.Items.AddRange(lista_de_planes.ToArray)
    End Sub

    Public Sub llenar_combo_con_todos_los_planes(ByVal cb_planes)
        cb_planes.Enabled = True
        cb_planes.items.clear()
        lista_de_planes = o_negocio_plan.get_planes()
        cb_planes.DisplayMember = "_cd_plan_estudio_y_titulo"
        cb_planes.ValueMember = "_cd_plan_estudio"
        cb_planes.Items.AddRange(lista_de_planes.ToArray)
    End Sub

    Public Sub llenar_combo_con_planes_que_tienen_al_menos_un_curso_activo(ByVal cb_planes)
        cb_planes.Enabled = True
        lista_de_planes = o_negocio_plan.get_planes_con_al_menos_un_curso_activo()
        cb_planes.DisplayMember = "_cd_plan_estudio_y_titulo"
        cb_planes.ValueMember = "_cd_plan_estudio"
        cb_planes.Items.AddRange(lista_de_planes.ToArray)
    End Sub

    Public Sub llenar_combo_con_planes_que_tienen_cursos_sin_todas_las_notas_informadas(ByVal cb_planes)
        cb_planes.Enabled = True
        lista_de_planes = o_negocio_plan.get_planes_que_tienen_cursos_sin_todas_las_notas_informadas()
        cb_planes.DisplayMember = "_cd_plan_estudio_y_titulo"
        cb_planes.ValueMember = "_cd_plan_estudio"
        cb_planes.Items.AddRange(lista_de_planes.ToArray)
    End Sub

    Public Sub llenar_combo_con_profesores_que_tienen_estado_activo(ByVal cb_profesor)
        cb_profesor.Enabled = True
        lista_de_profesores = o_negocio_profesor.get_profesores_con_estado_alta()
        cb_profesor.DisplayMember = "_cna"
        cb_profesor.ValueMember = "_cd_profesor"
        cb_profesor.Items.AddRange(lista_de_profesores.ToArray)
    End Sub

    Public Sub llenar_combo_con_profesores_que_dan_algun_curso(ByVal cb_profesor)
        cb_profesor.Enabled = True
        cb_profesor.items.clear()
        lista_de_profesores = o_negocio_profesor.get_profes_que_dan_algun_curso()
        cb_profesor.DisplayMember = "_cna"
        cb_profesor.ValueMember = "_cd_profesor"
        cb_profesor.Items.AddRange(lista_de_profesores.ToArray)
    End Sub

    Public Sub llenar_combo_con_materias_de_un_plan(ByVal cb_materias, ByVal cb_planes)
        plan = cb_planes.SelectedItem
        cb_materias.Enabled = True
        cb_materias.Items.Clear()
        lista_de_materias = o_negocio_materia.get_materias_de_un_plan(plan)
        cb_materias.DisplayMember = "_cn"
        cb_materias.ValueMember = "_cd_materia"
        cb_materias.Items.AddRange(lista_de_materias.ToArray)
    End Sub

    Public Sub llenar_combo_con_materias_que_pertenecen_a_un_curso(ByVal cb_materias)
        cb_materias.Enabled = True
        cb_materias.Items.Clear()
        lista_de_materias = o_negocio_materia.get_materias_que_pertenecen_a_un_curso()
        cb_materias.DisplayMember = "_cn"
        cb_materias.ValueMember = "_cd_materia"
        cb_materias.Items.AddRange(lista_de_materias.ToArray)
    End Sub

    Public Sub llenar_combo_con_materias_que_pueden_tener_correl(ByVal cb_materias, ByVal cb_planes, ByVal lb_materias_correlativas)
        plan = cb_planes.SelectedItem
        cb_materias.Enabled = True
        cb_materias.Items.Clear()
        lb_materias_correlativas.Items.clear()
        lista_de_materias = o_negocio_materia.get_materias_que_pueden_tener_correl(plan)
        cb_materias.DisplayMember = "_cn"
        cb_materias.ValueMember = "_cd_materia"
        cb_materias.Items.AddRange(lista_de_materias.ToArray)
    End Sub

    Public Sub llenar_combo_con_materias_que_tienen_correl(ByVal cb_materias, ByVal cb_planes)
        plan = cb_planes.SelectedItem
        cb_materias.Enabled = True
        cb_materias.Items.Clear()
        lista_de_materias = o_negocio_materia.get_materias_que_tienen_corel(plan)
        cb_materias.DisplayMember = "_cn"
        cb_materias.ValueMember = "_cd_materia"
        cb_materias.Items.AddRange(lista_de_materias.ToArray)
    End Sub


    Public Sub llenar_listbox_con_alumnos_para_inscripcion_plan(ByVal cb_planes, ByVal lb_alumnos)
        plan = cb_planes.SelectedItem

        lb_alumnos.items.clear()
        lista_de_alumnos = o_negocio_alumno.get_alumnos_aptos_inscripcion_plan(plan)
        lb_alumnos.DisplayMember = "_cna"
        lb_alumnos.ValueMember = "_cd_alumno"
        lb_alumnos.Items.AddRange(lista_de_alumnos.ToArray)
    End Sub

    Public Sub llenar_listbox_con_alumnos_aptos_inscripcion_curso(ByVal cb_planes, ByVal lb_cursos, ByVal lb_alumnos)

        plan = cb_planes.SelectedItem
        curso = lb_cursos.SelectedItem

        lb_alumnos.Enabled = True
        lb_alumnos.Items.Clear()
        lista_de_alumnos = o_negocio_alumno.get_alumnos_aptos_inscripcion_curso(plan, curso)
        lb_alumnos.DisplayMember = "_cna"
        lb_alumnos.ValueMember = "_cd_alumno"
        lb_alumnos.items.addrange(lista_de_alumnos.ToArray)

    End Sub

    Public Sub llenar_listbox_con_alumnos_para_calificacion_cursada(ByVal cb_cursos, ByVal lb_alumnos)
        curso = cb_cursos.SelectedItem

        lb_alumnos.items.clear()
        lista_de_alumnos = o_negocio_alumno.get_alumnos_para_calificacion_cursada(curso)
        lb_alumnos.DisplayMember = "_cna"
        lb_alumnos.ValueMember = "_cd_alumno"
        lb_alumnos.Items.AddRange(lista_de_alumnos.ToArray)
    End Sub

    Public Sub llenar_listbox_con_alumnos_para_calificacion_final(ByVal cb_cursos, ByVal lb_alumnos)
        curso = cb_cursos.SelectedItem
        lb_alumnos.items.clear()
        lista_de_alumnos = o_negocio_alumno.get_alumnos_para_calificacion_final(curso)
        lb_alumnos.DisplayMember = "_cna"
        lb_alumnos.ValueMember = "_cd_alumno"
        lb_alumnos.Items.AddRange(lista_de_alumnos.ToArray)
    End Sub

    Public Sub llenar_listbox_con_materias_de_un_plan(ByVal cb_planes, ByVal cb_cuatrimestres, ByVal lb_materias)

        plan = cb_planes.SelectedItem
        cuat = cb_cuatrimestres.SelectedItem
        lb_materias.Enabled = True
        lb_materias.Items.Clear()
        lista_de_materias = o_negocio_materia.get_materias_para_alta_pmc(plan, cuat)
        lb_materias.DisplayMember = "_cn"
        lb_materias.ValueMember = "_cd_materia"
        lb_materias.items.addrange(lista_de_materias.ToArray)

    End Sub

    Public Sub llenar_listbox_con_cursos_que_permiten_inscripciones(ByVal cb_planes, ByVal lb_cursos, ByVal lb_alumnos)
        lb_alumnos.Items.Clear()
        plan = cb_planes.SelectedItem

        lb_cursos.Enabled = True
        lb_cursos.Items.Clear()
        lista_de_cursos = o_negocio_curso.get_cursos_que_permiten_inscripciones(plan)
        lb_cursos.DisplayMember = "_cn"
        lb_cursos.ValueMember = "_cd_curso"
        lb_cursos.items.addrange(lista_de_cursos.ToArray)

    End Sub

    Public Sub llenar_listbox_con_posibles_correl(ByVal cb_materias, ByVal cb_planes, ByVal lb_materias_correlativas)
        plan = cb_planes.SelectedItem
        materia = cb_materias.SelectedItem
        cb_materias.Enabled = True
        lb_materias_correlativas.Items.clear()
        lista_de_materias = o_negocio_materia.get_materias_que_pueden_ser_correl(plan, materia)
        lb_materias_correlativas.DisplayMember = "_cn"
        lb_materias_correlativas.ValueMember = "_cd_materia"
        lb_materias_correlativas.Items.AddRange(lista_de_materias.ToArray)
    End Sub


    Public Sub mostrar_mensaje_datos_obligatorios()
        Throw New ArgumentException("Se deben ingresar todos los datos obligatorios.")
    End Sub

    Public Sub mostrar_mensaje_fc_examen_final_incorrecta()
        Throw New ArgumentException("La fecha de examen final ingresada es incorrecta.")
    End Sub

    Public Sub mostrar_mensaje_anio_curso_incorrecto()
        Throw New ArgumentException("El año lectivo ingresado es incorrecto.")
    End Sub

    Public Sub mostrar_mensaje_calificacion_incorrecta()
        Throw New ArgumentException("La calificacion ingresada es incorrecta.")
    End Sub

    Public Sub mostrar_mensaje_no_tiene_privilegios()
        MessageBox.Show("No posee los privilegios necesarios para efectuar esta operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Shared Function validar_email(ByVal direccion As String) As Boolean
        Return Regex.IsMatch(direccion, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Public Sub limpiar(ByVal f As Form)

        Dim ctl As Object

        For Each ctl In f.Controls
            If TypeOf ctl Is CheckBox Then
                ctl.CheckState = CheckState.Unchecked
            ElseIf TypeOf ctl Is TextBox Then
                ctl.Text = ""
            ElseIf TypeOf ctl Is ComboBox Then
                If Not ctl.name = "cb_opciones" Then
                    ctl.SelectedItem = Nothing
                End If
            End If
        Next
    End Sub

    Public Function consulta_rol(ByVal cd_usuario As String) As Int32

        Dim usuario As New Negocio.Usuario
        Dim rol As Integer

        rol = usuario.consulta_rol(cd_usuario)

        Return rol

    End Function

    Public Function consulta_existencia_cd_usuario(ByVal cd_usuario As String) As Int32

        Dim usuario As New Negocio.Usuario
        Dim rol As Integer

        rol = usuario.consulta_existencia_cd_usuario(cd_usuario)

        Return rol

    End Function

    Public Sub validar_edad(ByVal fecha As DateTimePicker)

        Dim a, b, c As Date

        a = fecha.Value.Date.AddYears(18)
        b = Date.Now
        c = fecha.Value.Date.AddYears(100)

        If a > b Then
            Throw New ArgumentException("El alumno no puede tener menos de 18 años.")
        End If
        If c < b Then
            Throw New ArgumentException("El alumno no puede tener más de 100 años.")
        End If

    End Sub

End Class