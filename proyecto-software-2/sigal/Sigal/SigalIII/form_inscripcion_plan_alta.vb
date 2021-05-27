Public Class form_inscripcion_plan_alta

#Region "VARIABLES DE CLASE"
    Dim Componentes As New Sigal.Componentes
    Private cancelado As Boolean = True
    Dim alumno As Entidades.Alumno
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

    Private Sub seteo_form()

        cb_planes.Focus()
        lb_alumnos.SelectionMode = SelectionMode.MultiSimple

        cb_planes.TabIndex = 0
        lb_alumnos.TabIndex = 1
        btn_aceptar.TabIndex = 2
        btn_cancelar.TabIndex = 3

    End Sub

    Private Sub iniciar_formulario()
        Componentes.llenar_combo_con_planes_que_tienen_estado_activo(cb_planes)
        If cb_planes.Items.Count > 0 Then
            cb_planes.SelectedItem = cb_planes.Items.Item(0)
        End If
    End Sub

    Private Sub aceptar_oepracion()

        Dim o_negocio_inscripcionPlan As New Negocio.InscripcionPlan
        Dim o_entidades_inscripcionPlan As New Entidades.InscripcionPlan
        Dim o_entidades_plan As New Entidades.Plan
        Dim o_entidades_alumno As New Entidades.Alumno

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el alta de las inscripciones?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then

                For Each alumno As Entidades.Alumno In lb_alumnos.SelectedItems
                    'Procedimiento de insercion
                    'La Variable stringInsertar seria cada valor del ListBox

                    o_entidades_plan = cb_planes.SelectedItem

                    o_entidades_inscripcionPlan._cd_plan_estudio = o_entidades_plan._cd_plan_estudio
                    o_entidades_inscripcionPlan._cd_alumno = alumno._cd_alumno

                    o_negocio_inscripcionPlan.add(o_entidades_inscripcionPlan)

                    cancelado = False
                    Me.Close()

                Next
                MessageBox.Show("Las inscripciones se dieron de alta correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            'Capturo excepciones genéricas.
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            'Libero los objetos.
            o_entidades_inscripcionPlan = Nothing
            o_negocio_inscripcionPlan = Nothing
        End Try
    End Sub

    Private Sub validar()
        If lb_alumnos.SelectedItems.Count < 1 Then
            lb_alumnos.Focus()
            Throw New ArgumentException("Se debe seleccionar al menos un alumno.")
        End If
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_inscripcion_plan_alta_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        seteo_form()
        iniciar_formulario()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_oepracion()
    End Sub

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        Componentes.llenar_listbox_con_alumnos_para_inscripcion_plan(cb_planes, lb_alumnos)

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