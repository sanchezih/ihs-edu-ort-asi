Public Class form_correlatividad_alta

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
        lb_materias_correlativas.TabIndex = 2
        btn_aceptar.TabIndex = 3
        btn_cancelar.TabIndex = 4

        cb_planes.Focus()

        Componentes.llenar_combo_con_planes_que_tienen_estado_activo(cb_planes)
        If cb_planes.Items.Count > 0 Then
            cb_planes.SelectedItem = cb_planes.Items.Item(0)

            Componentes.llenar_combo_con_materias_que_pueden_tener_correl(cb_materias, cb_planes, lb_materias_correlativas)
            If cb_materias.Items.Count > 0 Then
                cb_materias.SelectedItem = cb_materias.Items.Item(0)
            End If
        End If
    End Sub

    Private Sub aceptar_oepracion()

        Dim o_negocio_correlatividad As New Negocio.Correlatividad
        Dim o_entidades_correlatividad As New Entidades.Correlatividad
        Dim o_entidades_plan As New Entidades.Plan
        Dim o_entidades_materia As New Entidades.Materia
        ' Dim o_entidades_profesor As New Entidades.Profesor
        Dim cuat As New Int32

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el alta de las correlatividades?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then

                For Each materia As Entidades.Materia In lb_materias_correlativas.SelectedItems
                    'Procedimiento de insercion
                    'La Variable stringInsertar seria cada valor del ListBox

                    o_entidades_plan = cb_planes.SelectedItem
                    o_entidades_materia = cb_materias.SelectedItem

                    o_entidades_correlatividad._cd_plan_estudio = o_entidades_plan._cd_plan_estudio
                    o_entidades_correlatividad._cd_materia = o_entidades_materia._cd_materia
                    o_entidades_correlatividad._cd_materia_correlativa = materia._cd_materia

                    o_negocio_correlatividad.add(o_entidades_correlatividad)

                    cancelado = False
                    Me.Close()

                Next
                MessageBox.Show("Las correlatividades se dieron de alta correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            'Capturo excepciones genéricas.
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            'Libero los objetos.
            o_entidades_correlatividad = Nothing
            o_negocio_correlatividad = Nothing
        End Try
    End Sub

    Private Sub validar()
        If lb_materias_correlativas.SelectedItems.Count < 1 Then
            lb_materias_correlativas.Focus()
            Throw New ArgumentException("Se debe seleccionar al menos una materia.")
        End If
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_correlatividad_alta_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_oepracion()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        Componentes.llenar_combo_con_materias_que_pueden_tener_correl(cb_materias, cb_planes, lb_materias_correlativas)
        If cb_materias.Items.Count > 0 Then
            cb_materias.SelectedItem = cb_materias.Items.Item(0)
        End If

    End Sub

    Private Sub lb_materias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_materias.SelectedIndexChanged
        Componentes.llenar_listbox_con_posibles_correl(cb_materias, cb_planes, lb_materias_correlativas)
    End Sub

    Private Sub cb_materias_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_materias.Validating
        If Me.cb_materias.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_materias, "Debe seleccionar una materia válida")
        Else
            ErrorProvider.SetError(Me.cb_materias, "")
        End If
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