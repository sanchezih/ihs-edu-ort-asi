<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_principal))
        Me.menu_form_pricipal = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaDeAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.InformesAnalíticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PlanDeEstudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDePlanDeEstudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsulaDePlanDeEstudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AsignacionesPlanMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeAsignaciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaDeAsignaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.InscripcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeInscripciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaDeInscripciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaDeMateriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CorrelatividadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeCorrelatividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeCursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaDeCursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.InscripcionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeInscripciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaDeInscripciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.CalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsultaDeCalificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalificacionesDeFinalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AltaDeCalificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CondultaDeCalificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SigalV10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.usuario = New System.Windows.Forms.ToolStripStatusLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.menu_form_pricipal.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_form_pricipal
        '
        Me.menu_form_pricipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AlumnoToolStripMenuItem, Me.PlanDeEstudioToolStripMenuItem, Me.MateriaToolStripMenuItem, Me.CursoToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.menu_form_pricipal.Location = New System.Drawing.Point(0, 0)
        Me.menu_form_pricipal.Name = "menu_form_pricipal"
        Me.menu_form_pricipal.Size = New System.Drawing.Size(812, 24)
        Me.menu_form_pricipal.TabIndex = 0
        Me.menu_form_pricipal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeUsuarioToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem, Me.ToolStripSeparator7, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Usuario"
        '
        'AltaDeUsuarioToolStripMenuItem
        '
        Me.AltaDeUsuarioToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.alumno_consulta
        Me.AltaDeUsuarioToolStripMenuItem.Name = "AltaDeUsuarioToolStripMenuItem"
        Me.AltaDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AltaDeUsuarioToolStripMenuItem.Text = "&Alta de usuario"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.alumno_consulta
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CambiarContraseñaToolStripMenuItem.Text = "&Cambiar contraseña"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(178, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.salir
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'AlumnoToolStripMenuItem
        '
        Me.AlumnoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeAlumnoToolStripMenuItem, Me.ConsultaDeAlumnoToolStripMenuItem, Me.ToolStripSeparator6, Me.InformesAnalíticosToolStripMenuItem})
        Me.AlumnoToolStripMenuItem.Name = "AlumnoToolStripMenuItem"
        Me.AlumnoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.AlumnoToolStripMenuItem.Text = "&Alumno"
        '
        'AltaDeAlumnoToolStripMenuItem
        '
        Me.AltaDeAlumnoToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.alumno_alta
        Me.AltaDeAlumnoToolStripMenuItem.Name = "AltaDeAlumnoToolStripMenuItem"
        Me.AltaDeAlumnoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AltaDeAlumnoToolStripMenuItem.Text = "&Alta de alumno"
        '
        'ConsultaDeAlumnoToolStripMenuItem
        '
        Me.ConsultaDeAlumnoToolStripMenuItem.Image = CType(resources.GetObject("ConsultaDeAlumnoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultaDeAlumnoToolStripMenuItem.Name = "ConsultaDeAlumnoToolStripMenuItem"
        Me.ConsultaDeAlumnoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ConsultaDeAlumnoToolStripMenuItem.Text = "&Consulta de alumno"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(176, 6)
        '
        'InformesAnalíticosToolStripMenuItem
        '
        Me.InformesAnalíticosToolStripMenuItem.Image = CType(resources.GetObject("InformesAnalíticosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InformesAnalíticosToolStripMenuItem.Name = "InformesAnalíticosToolStripMenuItem"
        Me.InformesAnalíticosToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.InformesAnalíticosToolStripMenuItem.Text = "&Informes analíticos"
        '
        'PlanDeEstudioToolStripMenuItem
        '
        Me.PlanDeEstudioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDePlanDeEstudioToolStripMenuItem, Me.ConsulaDePlanDeEstudioToolStripMenuItem, Me.ToolStripSeparator1, Me.AsignacionesPlanMateriaToolStripMenuItem, Me.ToolStripSeparator3, Me.InscripcionesToolStripMenuItem})
        Me.PlanDeEstudioToolStripMenuItem.Name = "PlanDeEstudioToolStripMenuItem"
        Me.PlanDeEstudioToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.PlanDeEstudioToolStripMenuItem.Text = "&Plan de estudio"
        '
        'AltaDePlanDeEstudioToolStripMenuItem
        '
        Me.AltaDePlanDeEstudioToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.plan_alta
        Me.AltaDePlanDeEstudioToolStripMenuItem.Name = "AltaDePlanDeEstudioToolStripMenuItem"
        Me.AltaDePlanDeEstudioToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.AltaDePlanDeEstudioToolStripMenuItem.Text = "&Alta de plan de estudio"
        '
        'ConsulaDePlanDeEstudioToolStripMenuItem
        '
        Me.ConsulaDePlanDeEstudioToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.plan_consulta
        Me.ConsulaDePlanDeEstudioToolStripMenuItem.Name = "ConsulaDePlanDeEstudioToolStripMenuItem"
        Me.ConsulaDePlanDeEstudioToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.ConsulaDePlanDeEstudioToolStripMenuItem.Text = "&Consula de plan de estudio"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(213, 6)
        '
        'AsignacionesPlanMateriaToolStripMenuItem
        '
        Me.AsignacionesPlanMateriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeAsignaciónToolStripMenuItem1, Me.ConsultaDeAsignaciónToolStripMenuItem})
        Me.AsignacionesPlanMateriaToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.asignacion_plan_materia
        Me.AsignacionesPlanMateriaToolStripMenuItem.Name = "AsignacionesPlanMateriaToolStripMenuItem"
        Me.AsignacionesPlanMateriaToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.AsignacionesPlanMateriaToolStripMenuItem.Text = "Asignaciones plan - &materia"
        '
        'AltaDeAsignaciónToolStripMenuItem1
        '
        Me.AltaDeAsignaciónToolStripMenuItem1.Image = Global.Sigal.My.Resources.Resources.pmc_alta
        Me.AltaDeAsignaciónToolStripMenuItem1.Name = "AltaDeAsignaciónToolStripMenuItem1"
        Me.AltaDeAsignaciónToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.AltaDeAsignaciónToolStripMenuItem1.Text = "Alta de asignación"
        '
        'ConsultaDeAsignaciónToolStripMenuItem
        '
        Me.ConsultaDeAsignaciónToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.pmc_consulta
        Me.ConsultaDeAsignaciónToolStripMenuItem.Name = "ConsultaDeAsignaciónToolStripMenuItem"
        Me.ConsultaDeAsignaciónToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ConsultaDeAsignaciónToolStripMenuItem.Text = "Consulta de asignación"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(213, 6)
        '
        'InscripcionesToolStripMenuItem
        '
        Me.InscripcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeInscripciónToolStripMenuItem, Me.ConsultaDeInscripciónToolStripMenuItem})
        Me.InscripcionesToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.inscripcion
        Me.InscripcionesToolStripMenuItem.Name = "InscripcionesToolStripMenuItem"
        Me.InscripcionesToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.InscripcionesToolStripMenuItem.Text = "&Inscripciones"
        '
        'AltaDeInscripciónToolStripMenuItem
        '
        Me.AltaDeInscripciónToolStripMenuItem.Image = CType(resources.GetObject("AltaDeInscripciónToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AltaDeInscripciónToolStripMenuItem.Name = "AltaDeInscripciónToolStripMenuItem"
        Me.AltaDeInscripciónToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AltaDeInscripciónToolStripMenuItem.Text = "&Alta de inscripción"
        '
        'ConsultaDeInscripciónToolStripMenuItem
        '
        Me.ConsultaDeInscripciónToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.inscripcion_consulta
        Me.ConsultaDeInscripciónToolStripMenuItem.Name = "ConsultaDeInscripciónToolStripMenuItem"
        Me.ConsultaDeInscripciónToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ConsultaDeInscripciónToolStripMenuItem.Text = "Consulta de inscripción"
        '
        'MateriaToolStripMenuItem
        '
        Me.MateriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeMateriaToolStripMenuItem, Me.ConsultaDeMateriaToolStripMenuItem, Me.ToolStripSeparator2, Me.CorrelatividadesToolStripMenuItem})
        Me.MateriaToolStripMenuItem.Name = "MateriaToolStripMenuItem"
        Me.MateriaToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MateriaToolStripMenuItem.Text = "&Materia"
        '
        'AltaDeMateriaToolStripMenuItem
        '
        Me.AltaDeMateriaToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.materia_alta
        Me.AltaDeMateriaToolStripMenuItem.Name = "AltaDeMateriaToolStripMenuItem"
        Me.AltaDeMateriaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AltaDeMateriaToolStripMenuItem.Text = "&Alta de materia"
        '
        'ConsultaDeMateriaToolStripMenuItem
        '
        Me.ConsultaDeMateriaToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.materia_consulta
        Me.ConsultaDeMateriaToolStripMenuItem.Name = "ConsultaDeMateriaToolStripMenuItem"
        Me.ConsultaDeMateriaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ConsultaDeMateriaToolStripMenuItem.Text = "&Consulta de materia"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(178, 6)
        '
        'CorrelatividadesToolStripMenuItem
        '
        Me.CorrelatividadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeCorrelatividadToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.CorrelatividadesToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.correlatividades
        Me.CorrelatividadesToolStripMenuItem.Name = "CorrelatividadesToolStripMenuItem"
        Me.CorrelatividadesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CorrelatividadesToolStripMenuItem.Text = "C&orrelatividades"
        '
        'AltaDeCorrelatividadToolStripMenuItem
        '
        Me.AltaDeCorrelatividadToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.correlatividad_alta
        Me.AltaDeCorrelatividadToolStripMenuItem.Name = "AltaDeCorrelatividadToolStripMenuItem"
        Me.AltaDeCorrelatividadToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.AltaDeCorrelatividadToolStripMenuItem.Text = "Alta de correlatividad"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.correlatividad_consulta
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta de correlatividad"
        '
        'CursoToolStripMenuItem
        '
        Me.CursoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeCursoToolStripMenuItem, Me.ConsultaDeCursoToolStripMenuItem, Me.ToolStripSeparator4, Me.InscripcionesToolStripMenuItem1, Me.ToolStripSeparator5, Me.CalificacionesToolStripMenuItem, Me.CalificacionesDeFinalesToolStripMenuItem})
        Me.CursoToolStripMenuItem.Name = "CursoToolStripMenuItem"
        Me.CursoToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.CursoToolStripMenuItem.Text = "&Curso"
        '
        'AltaDeCursoToolStripMenuItem
        '
        Me.AltaDeCursoToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.curso_alta
        Me.AltaDeCursoToolStripMenuItem.Name = "AltaDeCursoToolStripMenuItem"
        Me.AltaDeCursoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.AltaDeCursoToolStripMenuItem.Text = "&Alta de curso"
        '
        'ConsultaDeCursoToolStripMenuItem
        '
        Me.ConsultaDeCursoToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.curso_consulta
        Me.ConsultaDeCursoToolStripMenuItem.Name = "ConsultaDeCursoToolStripMenuItem"
        Me.ConsultaDeCursoToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.ConsultaDeCursoToolStripMenuItem.Text = "&Consulta de curso"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(207, 6)
        '
        'InscripcionesToolStripMenuItem1
        '
        Me.InscripcionesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeInscripciónToolStripMenuItem1, Me.ConsultaDeInscripciónToolStripMenuItem1})
        Me.InscripcionesToolStripMenuItem1.Image = Global.Sigal.My.Resources.Resources.inscripcion
        Me.InscripcionesToolStripMenuItem1.Name = "InscripcionesToolStripMenuItem1"
        Me.InscripcionesToolStripMenuItem1.Size = New System.Drawing.Size(210, 22)
        Me.InscripcionesToolStripMenuItem1.Text = "&Inscripciones"
        '
        'AltaDeInscripciónToolStripMenuItem1
        '
        Me.AltaDeInscripciónToolStripMenuItem1.Image = CType(resources.GetObject("AltaDeInscripciónToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.AltaDeInscripciónToolStripMenuItem1.Name = "AltaDeInscripciónToolStripMenuItem1"
        Me.AltaDeInscripciónToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
        Me.AltaDeInscripciónToolStripMenuItem1.Text = "&Alta de inscripción"
        '
        'ConsultaDeInscripciónToolStripMenuItem1
        '
        Me.ConsultaDeInscripciónToolStripMenuItem1.Image = Global.Sigal.My.Resources.Resources.inscripcion_consulta
        Me.ConsultaDeInscripciónToolStripMenuItem1.Name = "ConsultaDeInscripciónToolStripMenuItem1"
        Me.ConsultaDeInscripciónToolStripMenuItem1.Size = New System.Drawing.Size(194, 22)
        Me.ConsultaDeInscripciónToolStripMenuItem1.Text = "&Consulta de inscripción"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(207, 6)
        '
        'CalificacionesToolStripMenuItem
        '
        Me.CalificacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeFinalToolStripMenuItem, Me.ConsultaDeCalificaciónToolStripMenuItem})
        Me.CalificacionesToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.calificacion_cursada
        Me.CalificacionesToolStripMenuItem.Name = "CalificacionesToolStripMenuItem"
        Me.CalificacionesToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.CalificacionesToolStripMenuItem.Text = "Calificaciones de c&ursadas"
        '
        'DeFinalToolStripMenuItem
        '
        Me.DeFinalToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.calificacion_cursada_alta
        Me.DeFinalToolStripMenuItem.Name = "DeFinalToolStripMenuItem"
        Me.DeFinalToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DeFinalToolStripMenuItem.Text = "Alta de calificación"
        '
        'ConsultaDeCalificaciónToolStripMenuItem
        '
        Me.ConsultaDeCalificaciónToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.calificacion_cursada_consulta
        Me.ConsultaDeCalificaciónToolStripMenuItem.Name = "ConsultaDeCalificaciónToolStripMenuItem"
        Me.ConsultaDeCalificaciónToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ConsultaDeCalificaciónToolStripMenuItem.Text = "Consulta de calificación"
        '
        'CalificacionesDeFinalesToolStripMenuItem
        '
        Me.CalificacionesDeFinalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaDeCalificaciónToolStripMenuItem, Me.CondultaDeCalificaciónToolStripMenuItem})
        Me.CalificacionesDeFinalesToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.calificacion_final
        Me.CalificacionesDeFinalesToolStripMenuItem.Name = "CalificacionesDeFinalesToolStripMenuItem"
        Me.CalificacionesDeFinalesToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.CalificacionesDeFinalesToolStripMenuItem.Text = "Calificaciones de &finales"
        '
        'AltaDeCalificaciónToolStripMenuItem
        '
        Me.AltaDeCalificaciónToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.calificacion_final_alta
        Me.AltaDeCalificaciónToolStripMenuItem.Name = "AltaDeCalificaciónToolStripMenuItem"
        Me.AltaDeCalificaciónToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AltaDeCalificaciónToolStripMenuItem.Text = "Alta de calificación"
        '
        'CondultaDeCalificaciónToolStripMenuItem
        '
        Me.CondultaDeCalificaciónToolStripMenuItem.Image = Global.Sigal.My.Resources.Resources.calificacion_final_consulta
        Me.CondultaDeCalificaciónToolStripMenuItem.Name = "CondultaDeCalificaciónToolStripMenuItem"
        Me.CondultaDeCalificaciónToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CondultaDeCalificaciónToolStripMenuItem.Text = "Consulta de calificación"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SigalV10ToolStripMenuItem})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca &de..."
        '
        'SigalV10ToolStripMenuItem
        '
        Me.SigalV10ToolStripMenuItem.Image = CType(resources.GetObject("SigalV10ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SigalV10ToolStripMenuItem.Name = "SigalV10ToolStripMenuItem"
        Me.SigalV10ToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.SigalV10ToolStripMenuItem.Text = "&Sigal"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.usuario})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 364)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(812, 22)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'usuario
        '
        Me.usuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuario.Image = Global.Sigal.My.Resources.Resources.alumno_consulta
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(66, 17)
        Me.usuario.Text = "Usuario"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.Sigal.My.Resources.Resources.glossymetal
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 386)
        Me.Panel1.TabIndex = 3
        '
        'form_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 386)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.menu_form_pricipal)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu_form_pricipal
        Me.MinimumSize = New System.Drawing.Size(820, 420)
        Me.Name = "form_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sigal - Sistema de gestión de alumnos"
        Me.menu_form_pricipal.ResumeLayout(False)
        Me.menu_form_pricipal.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menu_form_pricipal As System.Windows.Forms.MenuStrip
    Friend WithEvents MateriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeMateriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeMateriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanDeEstudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDePlanDeEstudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsulaDePlanDeEstudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents CursoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeCursoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeCursoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SigalV10ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CorrelatividadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignacionesPlanMateriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeAsignaciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeAsignaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeCorrelatividadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InscripcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeInscripciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InscripcionesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeInscripciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeInscripciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeInscripciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeFinalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeCalificaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalificacionesDeFinalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaDeCalificaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CondultaDeCalificaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InformesAnalíticosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents usuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AltaDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
End Class
