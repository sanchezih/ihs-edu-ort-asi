Public Class form_plan_edicion

#Region "VARIABLES DE CLASE"
    Private cancelado As Boolean = True
    Private cd_plan As String = ""
    Dim Componentes As New Sigal.Componentes
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

    Public Property _cd_plan() As String
        Get
            Return cd_plan
        End Get
        Set(ByVal Value As String)
            cd_plan = Value
        End Set
    End Property

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        txt_titulo.TabIndex = 0
        cb_desc_estado_general.TabIndex = 1
        btn_aceptar.TabIndex = 2
        btn_cancelar.TabIndex = 3

        Componentes.llenar_combo_estado(cb_desc_estado_general)

        Dim l_entidades_materia As List(Of Entidades.Plan)
        Dim oMateriaNegocio As New Negocio.Plan
        Try

            l_entidades_materia = oMateriaNegocio.get_one(cd_plan)

            If l_entidades_materia.Count > 0 Then
                With l_entidades_materia(0)
                    cb_desc_estado_general.Text = ._desc_estado_general
                    txt_titulo.Text = ._titulo
                    lbl_valor_cd_plan_estudio.Text = ._cd_plan_estudio
                    Label8.Text = "Edición de " + ._cd_plan_estudio
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            oMateriaNegocio = Nothing
            l_entidades_materia = Nothing
        End Try
    End Sub

    Private Sub aceptar_operacion()

        Dim o_e_materia As New Entidades.Plan
        Dim o_n_materia As New Negocio.Plan
        Dim o_e_estado_general As New Entidades.EstadoGeneral

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma la modificación de los datos del plan de estudio?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If confirmacion = 1 Then
                o_e_materia._cd_plan_estudio = lbl_valor_cd_plan_estudio.Text
                o_e_materia._titulo = txt_titulo.Text

                o_e_estado_general = cb_desc_estado_general.SelectedItem
                o_e_materia.cd_estado_general = o_e_estado_general._cd_estado_general

                o_n_materia.update(o_e_materia)

                cancelado = False
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            o_e_materia = Nothing
            o_n_materia = Nothing
        End Try
    End Sub

    Private Sub validar()
        If txt_titulo.Text.Trim = "" Then
            txt_titulo.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_plan_edicion_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_titulo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_titulo.Validating
        If Me.txt_titulo.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_titulo, "Debe tener un valor")
        Else
            ErrorProvider.SetError(Me.txt_titulo, "")
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_operacion()
    End Sub

#End Region

End Class