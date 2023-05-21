Public Class form_pmc_alta

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

        cb_planes.Focus()

        Componentes.llenar_combo_con_planes_que_tienen_estado_activo(cb_planes)
        If cb_planes.Items.Count > 0 Then
            cb_planes.SelectedItem = cb_planes.Items.Item(0)
        End If

        cb_cuatrimestres.SelectedItem = cb_cuatrimestres.Items.Item(0)

        cb_planes.TabIndex = 0
        cb_cuatrimestres.TabIndex = 1
        lb_materias.TabIndex = 2
        btn_aceptar.TabIndex = 3
        btn_cancelar.TabIndex = 4

    End Sub

    Private Sub aceptar_oepracion()

        Dim o_negocio_pmc As New Negocio.PMC
        Dim o_entidades_pmc As New Entidades.PMC
        Dim o_entidades_plan As New Entidades.Plan
        Dim o_entidades_materia As New Entidades.Materia
        Dim o_entidades_profesor As New Entidades.Profesor
        Dim cuat As New Int32

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el alta de las asignaciones?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then

                For Each asd As Entidades.Materia In lb_materias.SelectedItems
                    'Procedimiento de insercion
                    'La Variable stringInsertar seria cada valor del ListBox

                    o_entidades_plan = cb_planes.SelectedItem
                    cuat = cb_cuatrimestres.SelectedItem

                    o_entidades_pmc._cd_plan_estudio = o_entidades_plan._cd_plan_estudio
                    o_entidades_pmc._cd_materia = asd._cd_materia
                    o_entidades_pmc._cuatrimestre_carrera = cuat

                    o_negocio_pmc.add(o_entidades_pmc)

                    cancelado = False
                    Me.Close()

                Next
                MessageBox.Show("Las asignaciones se dieron de alta correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            'Capturo excepciones genéricas.
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            'Libero los objetos.
            o_entidades_pmc = Nothing
            o_negocio_pmc = Nothing
        End Try
    End Sub

    Private Sub validar()
        If lb_materias.SelectedItems.Count < 1 Then
            lb_materias.Focus()
            Throw New ArgumentException("Se debe seleccionar al menos una materia.")
        End If
    End Sub

    Private Sub cancelar_operacion()
        cancelado = True
        Me.Close()
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_pmc_alta_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'Me.Close()
        cancelar_operacion()
    End Sub

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        If cb_planes.Items.Count > 0 Then
            Componentes.llenar_listbox_con_materias_de_un_plan(cb_planes, cb_cuatrimestres, lb_materias)
        End If

    End Sub

    Private Sub cb_cuatrimestres_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_cuatrimestres.SelectedIndexChanged
        If cb_planes.Items.Count > 0 Then
            Componentes.llenar_listbox_con_materias_de_un_plan(cb_planes, cb_cuatrimestres, lb_materias)
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_oepracion()
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