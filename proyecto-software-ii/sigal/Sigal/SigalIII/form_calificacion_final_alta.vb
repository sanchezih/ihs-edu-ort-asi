Public Class form_calificacion_final_alta

#Region "VARIABLES DE CLASE"
    Dim Componentes As New Sigal.Componentes
    Private cancelado As Boolean = True
#End Region

#Region "PROPIEDADES DE CONTROL"

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        ' PROPIEDADES DEL FORM
        txt_libro.MaxLength = 5
        txt_folio.MaxLength = 5
        txt_calificacion.MaxLength = 2

        cb_planes.TabIndex = 0
        cb_cursos.TabIndex = 1
        lb_alumnos.TabIndex = 2
        txt_libro.TabIndex = 3
        txt_folio.TabIndex = 4
        txt_calificacion.TabIndex = 5
        btn_aceptar.TabIndex = 6
        btn_cancelar.TabIndex = 7
        ' FIN PROPIEDADES DEL FORM

        cb_planes.Focus()

        Componentes.llenar_combo_con_planes_que_tienen_estado_activo(cb_planes)

        If cb_planes.Items.Count > 0 Then
            cb_planes.SelectedItem = cb_planes.Items.Item(0)
            Componentes.llenar_combo_con_cursos_activos_de_un_plan(cb_cursos, cb_planes, lb_alumnos)
            If cb_cursos.Items.Count > 0 Then
                cb_cursos.SelectedItem = cb_cursos.Items.Item(0)
            End If
        End If

    End Sub

    Private Sub aceptar_oepracion()

        Dim o_negocio_actaCursada As New Negocio.ActaFinal
        Dim o_entidades_actaCursada As New Entidades.ActaFinal
        Dim o_entidades_plan As New Entidades.Plan
        Dim o_entidades_materia As New Entidades.Materia
        Dim o_entidades_curso As New Entidades.Curso
        Dim o_entidades_alumno As New Entidades.Alumno

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el alta de la calificación?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then

                o_entidades_plan = Me.cb_planes.SelectedItem
                o_entidades_curso = Me.cb_cursos.SelectedItem
                o_entidades_alumno = Me.lb_alumnos.SelectedItem

                o_entidades_actaCursada._cd_plan_estudio = o_entidades_plan._cd_plan_estudio
                o_entidades_actaCursada._cd_curso = o_entidades_curso._cd_curso
                o_entidades_actaCursada._cd_alumno = o_entidades_alumno._cd_alumno
                o_entidades_actaCursada._libro = txt_libro.Text.Trim
                o_entidades_actaCursada._folio = txt_folio.Text.Trim
                o_entidades_actaCursada._calificacion = txt_calificacion.Text.Trim

                o_negocio_actaCursada.add(o_entidades_actaCursada)

                cancelado = False
                Me.Close()
                MessageBox.Show("La calificación se dio de alta correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            'Capturo excepciones genéricas.
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            'Libero los objetos.
            o_entidades_actaCursada = Nothing
            o_negocio_actaCursada = Nothing
        End Try
    End Sub

    Private Sub validar()

        If cb_planes.Text.Trim = "" Then
            cb_planes.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If cb_cursos.Text.Trim = "" Then
            cb_cursos.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If lb_alumnos.Text.Trim = "" Then
            lb_alumnos.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_libro.Text.Trim = "" Then
            txt_libro.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_folio.Text.Trim = "" Then
            txt_folio.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_calificacion.Text.Trim = "" Then
            txt_calificacion.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        Else
            If txt_calificacion.Text.Trim > 10 Then
                Dim o As New Sigal.Componentes
                o.mostrar_mensaje_calificacion_incorrecta()
            End If
        End If
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_calificacion_final_alta_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub cb_cursos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cursos.SelectedIndexChanged
        Componentes.llenar_listbox_con_alumnos_para_calificacion_final(cb_cursos, lb_alumnos)
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_oepracion()
    End Sub

    Private Sub txt_libro_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_libro.KeyPress
        Dim c As Char = e.KeyChar
        If Not Char.IsDigit(c) Then
            Select Case c
                Case Chr(8) ' Tecla retroceso
                Case Else
                    e.Handled = True
            End Select
        End If
    End Sub

    Private Sub txt_folio_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_folio.KeyPress
        Dim c As Char = e.KeyChar
        If Not Char.IsDigit(c) Then
            Select Case c
                Case Chr(8) ' Tecla retroceso
                Case Else
                    e.Handled = True
            End Select
        End If
    End Sub

    Private Sub txt_calificacion_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_calificacion.KeyPress
        Dim c As Char = e.KeyChar
        If Not Char.IsDigit(c) Then
            Select Case c
                Case Chr(8) ' Tecla retroceso
                Case Else
                    e.Handled = True
            End Select
        End If
    End Sub

    Private Sub cb_planes_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_planes.Validating
        If Me.cb_planes.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_planes, "Debe tener un valor")
        Else
            ErrorProvider.SetError(Me.cb_planes, "")
        End If
    End Sub

    Private Sub cb_cursos_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_cursos.Validating
        If Me.cb_cursos.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_cursos, "Debe seleccionar un curso válido")
        Else
            ErrorProvider.SetError(Me.cb_cursos, "")
        End If
    End Sub

    Private Sub txt_libro_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_libro.Validating
        If Me.txt_libro.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_libro, "Debe ingresar un libro válido")
        Else
            ErrorProvider.SetError(Me.txt_libro, "")
        End If
    End Sub

    Private Sub txt_folio_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_folio.Validating
        If Me.txt_folio.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_folio, "Debe ingresar un folio válido")
        Else
            ErrorProvider.SetError(Me.txt_folio, "")
        End If
    End Sub

    Private Sub txt_calificacion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_calificacion.Validating
        If Me.txt_calificacion.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_calificacion, "Debe ingresar una calificación válida")
        Else
            ErrorProvider.SetError(Me.txt_calificacion, "")
        End If
    End Sub

#End Region

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        Componentes.llenar_combo_con_cursos_de_plan_para_calif_final(cb_planes, cb_cursos, lb_alumnos)

    End Sub

End Class