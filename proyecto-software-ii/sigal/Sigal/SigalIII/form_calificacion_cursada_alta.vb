Public Class form_calificacion_cursada_alta

#Region "VARIABLES DE CLASE"
    Dim Componentes As New Sigal.Componentes
    Private cancelado As Boolean = True
    Private ind As Int32
    Private base As String
    Private calif As Int32
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
        cb_base_calificacion.TabIndex = 5
        txt_calificacion.TabIndex = 6
        btn_aceptar.TabIndex = 7
        btn_cancelar.TabIndex = 8
        ' FIN PROPIEDADES DEL FORM

        cb_planes.Focus()

        cb_base_calificacion.SelectedItem = cb_base_calificacion.Items.Item(0)

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

        Dim o_negocio_actaCursada As New Negocio.ActaCursada
        Dim o_entidades_actaCursada As New Entidades.ActaCursada
        Dim o_entidades_plan As New Entidades.Plan
        Dim o_entidades_materia As New Entidades.Materia
        Dim o_entidades_curso As New Entidades.Curso
        Dim o_entidades_alumno As New Entidades.Alumno

        Try
            ind = cb_base_calificacion.SelectedIndex
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el alta de la calificación?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then

                If ind = 0 Then
                    base = "CUR"
                    calif = txt_calificacion.Text.Trim
                ElseIf ind = 1 Then
                    base = "PRO"
                    calif = txt_calificacion.Text.Trim
                ElseIf ind = 2 Then
                    base = "LIB"
                    calif = 0
                Else
                    base = "EQ"
                    calif = 0
                End If
       

                o_entidades_plan = Me.cb_planes.SelectedItem
                o_entidades_curso = Me.cb_cursos.SelectedItem
                o_entidades_alumno = Me.lb_alumnos.SelectedItem

                o_entidades_actaCursada._cd_plan_estudio = o_entidades_plan._cd_plan_estudio
                o_entidades_actaCursada._cd_curso = o_entidades_curso._cd_curso
                o_entidades_actaCursada._cd_alumno = o_entidades_alumno._cd_alumno
                o_entidades_actaCursada._libro = txt_libro.Text.Trim
                o_entidades_actaCursada._folio = txt_folio.Text.Trim
                o_entidades_actaCursada._base_calificacion = base
                o_entidades_actaCursada._calificacion = calif

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

        If ind = 1 Then
            If txt_calificacion.Text.Trim = "" Then
                txt_calificacion.Focus()
                Dim o As New Sigal.Componentes
                o.mostrar_mensaje_datos_obligatorios()
            Else
                If txt_calificacion.Text.Trim < 11 Then
                    If txt_calificacion.Text.Trim < 7 Then
                        Throw New ArgumentException("Una materia aprobada por promoción directa no puede tener una nota menor a 7 puntos.")
                    End If
                Else
                    Dim o As New Sigal.Componentes
                    o.mostrar_mensaje_calificacion_incorrecta()
                End If
            End If
        End If

        If ind = 0 Then
            If txt_calificacion.Text.Trim = "" Then
                txt_calificacion.Focus()
                Dim o As New Sigal.Componentes
                o.mostrar_mensaje_datos_obligatorios()
            Else
                If Not txt_calificacion.Text.Trim < 11 Then
                    Dim o As New Sigal.Componentes
                    o.mostrar_mensaje_calificacion_incorrecta()
                End If
            End If
        End If

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_calificacion_cursada_alta_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_oepracion()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        Componentes.llenar_combo_con_cursos_activos_de_un_plan(cb_cursos, cb_planes, lb_alumnos)
        If cb_cursos.Items.Count > 0 Then
            cb_cursos.SelectedItem = cb_cursos.Items.Item(0)
        End If
    End Sub

    Private Sub cb_base_calificacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_base_calificacion.SelectedIndexChanged
        If cb_base_calificacion.SelectedItem = cb_base_calificacion.Items.Item(2) Then
            txt_calificacion.Clear()
            txt_calificacion.Enabled = False
            txt_calificacion.Text = "N/A"
        ElseIf cb_base_calificacion.SelectedItem = cb_base_calificacion.Items.Item(3) Then
            txt_calificacion.Clear()
            txt_calificacion.Enabled = False
            txt_calificacion.Text = "N/A"
        Else
            txt_calificacion.Clear()
            txt_calificacion.Enabled = True
        End If

    End Sub

    Private Sub cb_cursos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cursos.SelectedIndexChanged
        Componentes.llenar_listbox_con_alumnos_para_calificacion_cursada(cb_cursos, lb_alumnos)
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
            ErrorProvider.SetError(Me.cb_planes, "Debe seleccionar un plan válido")
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

#End Region

  
End Class