Public Class form_principal

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String = ""
    Dim Componentes As New Sigal.Componentes
#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cd_usuario() As String
        Get
            Return cd_usuario
        End Get
        Set(ByVal Value As String)
            cd_usuario = Value
        End Set
    End Property

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()
        StatusStrip.Items.Item(0).Text = "Usuario logueado: " + cd_usuario
    End Sub

#End Region

#Region "EVENTOS"

#Region "ARCHIVO"
    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
#End Region

#Region "MATERIA"

    Private Sub alta_de_materia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeMateriaToolStripMenuItem.Click
        Dim o_form_alumno_search As form_materia_search
        o_form_alumno_search = New form_materia_search
        o_form_alumno_search._cd_usuario = cd_usuario
        o_form_alumno_search.alta_materia()
        o_form_alumno_search.Close()
        o_form_alumno_search = Nothing
    End Sub

    Private Sub consulta_de_materia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeMateriaToolStripMenuItem.Click
        Dim o_form_materia_search As form_materia_search
        o_form_materia_search = New form_materia_search
        o_form_materia_search._cd_usuario = cd_usuario
        o_form_materia_search.ShowDialog()
        o_form_materia_search.Close()
        o_form_materia_search = Nothing
    End Sub

#End Region

#Region "ALUMNO"

    Private Sub alta_de_alumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeAlumnoToolStripMenuItem.Click
        Dim o_form_alumno_search As form_alumno_search
        o_form_alumno_search = New form_alumno_search
        o_form_alumno_search.alta_alumno()
        o_form_alumno_search.Close()
        o_form_alumno_search = Nothing
    End Sub

    Private Sub consulta_de_alumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeAlumnoToolStripMenuItem.Click
        Dim o_form_alumno_search As form_alumno_search
        o_form_alumno_search = New form_alumno_search
        o_form_alumno_search._cd_usuario = cd_usuario
        o_form_alumno_search.ShowDialog()
        o_form_alumno_search.Close()
        o_form_alumno_search = Nothing
    End Sub

#End Region

#Region "INFORMES ANALITICOS"

    Private Sub informes_analiticos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformesAnalíticosToolStripMenuItem.Click
        Dim o_form_analitico As form_analitico
        o_form_analitico = New form_analitico
        o_form_analitico.ShowDialog()
        o_form_analitico.Close()
        o_form_analitico = Nothing
    End Sub

#End Region

#Region "PLAN DE ESTUDIO"

    Private Sub consulta_de_plan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsulaDePlanDeEstudioToolStripMenuItem.Click
        Dim o_form_plan_search As form_plan_search
        o_form_plan_search = New form_plan_search
        o_form_plan_search._cd_usuario = cd_usuario
        o_form_plan_search.ShowDialog()
        o_form_plan_search.Close()
        o_form_plan_search = Nothing
    End Sub

    Private Sub alta_de_plan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDePlanDeEstudioToolStripMenuItem.Click
      
        Dim o_form_alumno_search As form_plan_search
        o_form_alumno_search = New form_plan_search
        o_form_alumno_search._cd_usuario = cd_usuario
        o_form_alumno_search.alta_plan()
        o_form_alumno_search.Close()
        o_form_alumno_search = Nothing
    
    End Sub

#End Region

#Region "CURSO"

    Private Sub alta_de_curso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeCursoToolStripMenuItem.Click
        form_curso_search.alta_curso()
    End Sub

    Private Sub consulta_de_curso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeCursoToolStripMenuItem.Click
        Dim o_form_curso_search As form_curso_search
        o_form_curso_search = New form_curso_search
        o_form_curso_search.ShowDialog()
        o_form_curso_search.Close()
        o_form_curso_search = Nothing
    End Sub

#End Region

#Region "PMC"

    Private Sub AltaDeAsignaciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeAsignaciónToolStripMenuItem1.Click
        Dim o_form_alumno_search As form_pmc_search
        o_form_alumno_search = New form_pmc_search
        o_form_alumno_search._cd_usuario = cd_usuario
        o_form_alumno_search.alta_pmc()
        o_form_alumno_search.Close()
        o_form_alumno_search = Nothing
    End Sub

    Private Sub ConsultaDeAsignaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeAsignaciónToolStripMenuItem.Click
        Dim o_form_pmc_search As form_pmc_search
        o_form_pmc_search = New form_pmc_search
        o_form_pmc_search._cd_usuario = cd_usuario
        o_form_pmc_search.ShowDialog()
        o_form_pmc_search.Close()
        o_form_pmc_search = Nothing
    End Sub

#End Region

#Region "CORRELATIVIDAD"

    Private Sub alta_de_correlatividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeCorrelatividadToolStripMenuItem.Click
        Dim o_form_alumno_search As form_correlatividad_search
        o_form_alumno_search = New form_correlatividad_search
        o_form_alumno_search._cd_usuario = cd_usuario
        o_form_alumno_search.alta_correlatividad()
        o_form_alumno_search.Close()
        o_form_alumno_search = Nothing
    End Sub

    Private Sub consulta_de_correlatividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem.Click
        Dim o_form_correlatividad_search As form_correlatividad_search
        o_form_correlatividad_search = New form_correlatividad_search
        o_form_correlatividad_search._cd_usuario = cd_usuario
        o_form_correlatividad_search.ShowDialog()
        o_form_correlatividad_search.Close()
        o_form_correlatividad_search = Nothing
    End Sub

#End Region

#Region "INSCRIPCION PLAN"

    Private Sub AltaDeInscripciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeInscripciónToolStripMenuItem.Click
        form_inscripcion_plan_search.alta_inscripcion_plan()
    End Sub

    Private Sub ConsultaDeInscripciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeInscripciónToolStripMenuItem.Click
        Dim o_form_inscripcion_plan_search As form_inscripcion_plan_search
        o_form_inscripcion_plan_search = New form_inscripcion_plan_search
        o_form_inscripcion_plan_search.ShowDialog()
        o_form_inscripcion_plan_search.Close()
        o_form_inscripcion_plan_search = Nothing
    End Sub

#End Region

#Region "INSCRIPCION CURSO"

    Private Sub consulta_de_inscripcion_a_curso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeInscripciónToolStripMenuItem1.Click
        Dim o_form_inscripcion_curso_search As form_inscripcion_curso_search
        o_form_inscripcion_curso_search = New form_inscripcion_curso_search
        o_form_inscripcion_curso_search.ShowDialog()
        o_form_inscripcion_curso_search.Close()
        o_form_inscripcion_curso_search = Nothing
    End Sub

    Private Sub AltaDeInscripciónToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeInscripciónToolStripMenuItem1.Click
        form_inscripcion_curso_search.alta_inscripcion_curso()
    End Sub

#End Region

#Region "CALIFICACION DE CURSADA"

    Private Sub alta_de_calificacion_de_cursada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeFinalToolStripMenuItem.Click
        form_calificacion_cursada_search.alta_calificacionCursada()
    End Sub

    Private Sub consulta_de_calificacion_de_cursada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeCalificaciónToolStripMenuItem.Click
        Dim o_form_calificacion_cursada_search As form_calificacion_cursada_search
        o_form_calificacion_cursada_search = New form_calificacion_cursada_search
        o_form_calificacion_cursada_search.ShowDialog()
        o_form_calificacion_cursada_search.Close()
        o_form_calificacion_cursada_search = Nothing
    End Sub

#End Region

#Region "CALIFICACION DE FINAL"

    Private Sub alta_de_calificacion_de_final_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeCalificaciónToolStripMenuItem.Click
        form_calificacion_final_search.alta_calificacionFinal()
    End Sub

    Private Sub consulta_de_calificacion_de_final_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CondultaDeCalificaciónToolStripMenuItem.Click
        Dim o_form_calificacion_final_search As form_calificacion_final_search
        o_form_calificacion_final_search = New form_calificacion_final_search
        o_form_calificacion_final_search.ShowDialog()
        o_form_calificacion_final_search.Close()
        o_form_calificacion_final_search = Nothing
    End Sub

#End Region

    Private Sub form_principal_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub form_principal_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub acerca_de_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SigalV10ToolStripMenuItem.Click
        My.Forms.form_acerca.ShowDialog()
    End Sub

    Private Sub AltaDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaDeUsuarioToolStripMenuItem.Click
        Dim r As Int32
        r = Componentes.consulta_rol(cd_usuario)

        If r = 1 Then
            Dim o_form_usuario_alta As form_usuario_alta
            o_form_usuario_alta = New form_usuario_alta
            o_form_usuario_alta._cd_usuario = cd_usuario
            o_form_usuario_alta.ShowDialog()
            o_form_usuario_alta.Close()
            o_form_usuario_alta = Nothing
        Else
            Componentes.mostrar_mensaje_no_tiene_privilegios()
        End If
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        Dim o_form_usuario_cambio_pass As form_usuario_cambio_pass
        o_form_usuario_cambio_pass = New form_usuario_cambio_pass
        o_form_usuario_cambio_pass._cd_usuario = cd_usuario
        o_form_usuario_cambio_pass.ShowDialog()
        o_form_usuario_cambio_pass.Close()
        o_form_usuario_cambio_pass = Nothing
    End Sub

#End Region

End Class