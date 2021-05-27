Public Class form_inscripcion_curso_alta

#Region "VARIABLES DE CLASE"
    Dim Componentes As New Sigal.Componentes
    Private cancelado As Boolean = True

#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cancelado() As Boolean
        Get
            Return cancelado
        End Get
        Set(ByVal value As Boolean)
            cancelado = value
        End Set
    End Property

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        ' PROPIEDADES DEL FORM
        lb_cursos.SelectionMode = SelectionMode.One
        lb_alumnos.SelectionMode = SelectionMode.MultiSimple

        cb_planes.TabIndex = 0
        lb_cursos.TabIndex = 1
        lb_alumnos.TabIndex = 2
        btn_aceptar.TabIndex = 3
        btn_cancelar.TabIndex = 4
        ' FIN PROPIEDADES DEL FORM

        cb_planes.Focus()

        Componentes.llenar_combo_con_planes_que_tienen_al_menos_un_curso_activo(cb_planes)
        If cb_planes.Items.Count > 0 Then
            cb_planes.SelectedItem = cb_planes.Items.Item(0)
            Componentes.llenar_listbox_con_cursos_que_permiten_inscripciones(cb_planes, lb_cursos, lb_alumnos)
        End If
    End Sub

    Private Sub aceptar_operacion()

        Dim o_negocio_inscripcionCurso As New Negocio.InscripcionCurso
        Dim o_entidades_inscripcionCurso As New Entidades.InscripcionCurso
        Dim o_entidades_curso As New Entidades.Curso
        Dim o_entidades_alumno As New Entidades.Alumno

        Try
            validar()

            Dim confirmacion As String
            Dim cantidad As Int32
            o_entidades_curso = lb_cursos.SelectedItem

            cantidad = o_negocio_inscripcionCurso.consulta_cantidad_inscriptos(o_entidades_curso._cd_curso)


            If cantidad = 0 Then
                confirmacion = MessageBox.Show("Actualmente, el curso seleccionado no tiene alumnos inscriptos. Al inscribir alumnos al curso, este no podra ser eliminado." & Chr(13) & "¿Confirma el alta de las inscripciones?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            Else
                confirmacion = MessageBox.Show("¿Confirma el alta de las inscripciones?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            End If

            If confirmacion = 1 Then

                For Each alumno As Entidades.Alumno In lb_alumnos.SelectedItems

                    o_entidades_inscripcionCurso._cd_curso = o_entidades_curso._cd_curso
                    o_entidades_inscripcionCurso._cd_alumno = alumno._cd_alumno

                    o_negocio_inscripcionCurso.add(o_entidades_inscripcionCurso)

                    cancelado = False
                    Me.Close()

                Next

                MessageBox.Show("Las inscripciones se dieron de alta correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            o_entidades_inscripcionCurso = Nothing
            o_negocio_inscripcionCurso = Nothing
        End Try

    End Sub

    Private Sub validar()
        If lb_cursos.SelectedItems.Count < 1 Then
            lb_cursos.Focus()
            Throw New ArgumentException("Se debe seleccionar al menos un curso.")
        Else
            If lb_alumnos.SelectedItems.Count < 1 Then
                lb_alumnos.Focus()
                Throw New ArgumentException("Se debe seleccionar al menos un alumno.")
            End If
            End If
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_inscripcion_curso_alta_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        Componentes.llenar_listbox_con_cursos_que_permiten_inscripciones(cb_planes, lb_cursos, lb_alumnos)
    End Sub

    Private Sub lb_cursos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_cursos.SelectedIndexChanged
        If lb_cursos.SelectedIndex >= 0 Then
            Componentes.llenar_listbox_con_alumnos_aptos_inscripcion_curso(cb_planes, lb_cursos, lb_alumnos)
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_operacion()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cb_planes_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_planes.Validating
        If Me.cb_planes.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_planes, "Debe seleccionar un plan válido")
        Else
            ErrorProvider.SetError(Me.cb_planes, "")
        End If
    End Sub

#End Region

End Class