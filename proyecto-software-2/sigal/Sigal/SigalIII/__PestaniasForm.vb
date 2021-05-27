Public Class __PestaniasForm


    Private Sub CalificaciónFinalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'creo nueva instancia de formulario para buscar las calificaciones finales
        Dim ofrm As __FormCalificacionFinal
        ofrm = New __FormCalificacionFinal

        'muestro el formulario de manera modal
        ofrm.ShowDialog()

        'cierro formulario
        ofrm.Close()

        'elimino instancia
        ofrm = Nothing
    End Sub


    Private Sub InscripciónCursoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InscripciónCursoToolStripMenuItem.Click
        'creo nueva instancia de formulario para inscribir cursos
        Dim ofrm As __FormNuevoInscripcionCurso
        ofrm = New __FormNuevoInscripcionCurso
        '
        'muestro el formulario de manera modal
        ofrm.ShowDialog()

        'cierro formulario
        ofrm.Close()

        'elimino instancia
        ofrm = Nothing
    End Sub

    'Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
    '    'creo nueva instancia de formulario para dar de alta una cita
    '    Dim ofrm As FormBusquedaAlumnos
    '    ofrm = New FormBusquedaAlumnos

    '    'muestro el formulario de manera modal
    '    ofrm.ShowDialog()

    '    'cierro formulario
    '    ofrm.Close()

    '    'elimino instancia
    '    ofrm = Nothing
    'End Sub

    'Private Sub AltaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem.Click
    '    FormBusquedaAlumnos.NuevoAlumno()
    'End Sub

    Private Sub ConsultasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem1.Click
        'creo nueva instancia de formulario para dar de alta una cita
        Dim ofrm As __FormBusquedaPlanEstudio
        ofrm = New __FormBusquedaPlanEstudio

        'muestro el formulario de manera modal
        ofrm.ShowDialog()

        'cierro formulario
        ofrm.Close()

        'elimino instancia
        ofrm = Nothing
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem1.Click
        __FormBusquedaPlanEstudio.NuevoPlan()
    End Sub

    Private Sub ConsultasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem2.Click
        'creo nueva instancia de formulario para buscar cursos
        Dim ofrm As __FormBusquedaCurso
        ofrm = New __FormBusquedaCurso
        '
        'muestro el formulario de manera modal
        ofrm.ShowDialog()

        'cierro formulario
        ofrm.Close()

        'elimino instancia
        ofrm = Nothing
    End Sub

    Private Sub AltaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem2.Click
        __FormBusquedaCurso.NuevoCurso()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem.Click
        'creo nueva instancia de formulario para buscar materias
        Dim ofrm As __FormBusquedaMaterias_
        ofrm = New __FormBusquedaMaterias_
        '
        'muestro el formulario de manera modal
        ofrm.ShowDialog()

        'cierro formulario
        ofrm.Close()

        'elimino instancia
        ofrm = Nothing
    End Sub

    Private Sub AltaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaToolStripMenuItem3.Click
        __FormBusquedaMaterias_.NuevaMateria()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub InscripciónAPlanDeEstudioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InscripciónAPlanDeEstudioToolStripMenuItem.Click
        'creo nueva instancia de formulario para buscar materias
        Dim ofrm As __FormNuevoInscripcionPlanEstudio
        ofrm = New __FormNuevoInscripcionPlanEstudio
        '
        'muestro el formulario de manera modal
        ofrm.ShowDialog()

        'cierro formulario
        ofrm.Close()

        'elimino instancia
        ofrm = Nothing
    End Sub


End Class
