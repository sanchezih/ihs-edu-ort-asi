Public Class form_curso_alta

#Region "VARIABLES DE CLASE"
    Dim Componentes As New Sigal.Componentes
    Private cancelado As Boolean = True
#End Region

#Region "PROPIEDADES DE CONTROL"

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        cb_planes.TabIndex = 0
        cb_materias.TabIndex = 1
        cb_profesores.TabIndex = 2
        cb_semestres.TabIndex = 3
        txt_anio.TabIndex = 4
        btn_aceptar.TabIndex = 5
        btn_cancelar.TabIndex = 6

        cb_planes.Focus()

        Componentes.llenar_combo_con_planes_que_tienen_estado_activo(cb_planes)
        If cb_planes.Items.Count > 0 Then
            cb_planes.SelectedItem = cb_planes.Items.Item(0)
        End If

        Componentes.llenar_combo_con_profesores_que_tienen_estado_activo(cb_profesores)
        If cb_profesores.Items.Count > 0 Then
            cb_profesores.SelectedItem = cb_profesores.Items.Item(0)
        End If

        cb_semestres.SelectedItem = cb_semestres.Items.Item(0)

        Dim mes As Int32
        mes = Month(DateAndTime.Now)
        If mes > 7 Then
            txt_anio.Text = (Year(DateAndTime.Now) + 1).ToString
        Else
            txt_anio.Text = Year(DateAndTime.Now).ToString
        End If

    End Sub

    Private Sub aceptar_oepracion()

        Dim o_negocio_curso As New Negocio.Curso
        Dim o_entidades_curso As New Entidades.Curso
        Dim o_entidades_plan As New Entidades.Plan
        Dim o_entidades_materia As New Entidades.Materia
        Dim o_entidades_profesor As New Entidades.Profesor

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el alta del curso?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then

                o_entidades_plan = cb_planes.SelectedItem
                o_entidades_materia = cb_materias.SelectedItem
                o_entidades_profesor = cb_profesores.SelectedItem

                o_entidades_curso._cd_plan_estudio = o_entidades_plan._cd_plan_estudio
                o_entidades_curso._cd_materia = o_entidades_materia._cd_materia
                o_entidades_curso._cd_profesor = o_entidades_profesor._cd_profesor
                o_entidades_curso._anio = txt_anio.Text
                o_entidades_curso._semestre = cb_semestres.SelectedItem

                o_negocio_curso.add(o_entidades_curso)

                cancelado = False
                Me.Close()
            End If

        Catch ex As Exception
            'Capturo excepciones genéricas.
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            'Libero los objetos.
            o_entidades_curso = Nothing
            o_negocio_curso = Nothing
        End Try
    End Sub

    Private Sub validar()

        If txt_anio.Text.Trim = "" Then
            txt_anio.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        ElseIf (CInt(txt_anio.Text) < Year(DateAndTime.Now)) Then
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_anio_curso_incorrecto()
        End If

        Dim ind, sem, anio As Int32
        sem = Month(DateAndTime.Now)
        anio = Year(DateAndTime.Now)
        ind = cb_semestres.SelectedIndex

        If anio = txt_anio.Text.Trim Then
            If ind = 0 Then
                If sem > 4 Then
                    Dim o As New Sigal.Componentes
                    o.mostrar_mensaje_anio_curso_incorrecto()
                End If
            Else
                If sem > 6 Then
                    Dim o As New Sigal.Componentes
                    o.mostrar_mensaje_anio_curso_incorrecto()
                End If
            End If
        End If

        If cb_materias.Text.Trim = "" Then
            cb_materias.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If cb_planes.Text.Trim = "" Then
            cb_planes.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If cb_profesores.Text.Trim = "" Then
            cb_profesores.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_materia_alta_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        iniciar_formulario()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_oepracion()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub form_curso_alta_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If form_curso_search.IsMdiChild = False Then
            form_principal.menu_form_pricipal.Enabled = True
        End If

        My.Forms.form_curso_search.btn_buscar_Click(sender, New EventArgs)
    End Sub

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        Componentes.llenar_combo_con_materias_de_un_plan(cb_materias, cb_planes)
        If cb_materias.Items.Count > 0 Then
            cb_materias.SelectedItem = cb_materias.Items.Item(0)
        End If
    End Sub

    Private Sub cb_planes_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_planes.Validating
        If Me.cb_planes.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_planes, "Debe seleccionar un plan válido")
        Else
            ErrorProvider.SetError(Me.cb_planes, "")
        End If
    End Sub

    Private Sub cb_materias_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_materias.Validating
        If Me.cb_materias.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_materias, "Debe seleccionar una materia válida")
        Else
            ErrorProvider.SetError(Me.cb_materias, "")
        End If
    End Sub

    Private Sub cb_profesores_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_profesores.Validating
        If Me.cb_profesores.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_profesores, "Debe seleccionar un profesor válido")
        Else
            ErrorProvider.SetError(Me.cb_profesores, "")
        End If
    End Sub

    Private Sub txt_anio_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_anio.Validating
        If Me.txt_anio.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_anio, "Debe ingresar un año válido")
            'ElseIf (CInt(txt_anio.Text) < Year(DateAndTime.Now)) Then
            '    ErrorProvider.SetError(Me.txt_anio, "El año lectivo ingresado es incorrecto.")
        Else
            ErrorProvider.SetError(Me.txt_anio, "")
        End If
    End Sub

    Private Sub txt_anio_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_anio.KeyPress
        Dim c As Char = e.KeyChar
        If Not Char.IsDigit(c) Then
            Select Case c
                Case Chr(8) ' Tecla retroceso
                Case Chr(32) ' Tecla barra espaciadora
                Case Else
                    e.Handled = True
            End Select
        End If
    End Sub

#End Region

End Class