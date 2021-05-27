Public Class form_plan_alta

#Region "VARIABLES DE CLASE"
    Private cancelado As Boolean = True
#End Region

#Region "CONTROLES"

#End Region

#Region "PROPIEDADES DE CONTROL"

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()
        Me.txt_cd_plan_estudio.Focus()

        txt_cd_plan_estudio.TabIndex = 0
        txt_titulo.TabIndex = 1
        btn_aceptar.TabIndex = 2
        btn_cancelar.TabIndex = 3
    End Sub

    Private Sub aceptar_operacion()

        Dim o_negocio_plan As New Negocio.Plan
        Dim o_entidad_plan As New Entidades.Plan

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el alta del plan de estudio """ + txt_titulo.Text + """?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then
                o_entidad_plan._cd_plan_estudio = txt_cd_plan_estudio.Text.ToUpper
                o_entidad_plan._titulo = txt_titulo.Text

                o_negocio_plan.add(o_entidad_plan)


                cancelado = False

                Me.Close()
                MessageBox.Show("El plan de estudio se dio de alta correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Catch ex As Exception
            'Capturo excepciones genéricas.
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            'Libero los objetos.
            o_entidad_plan = Nothing
            o_negocio_plan = Nothing
        End Try
    End Sub

    Private Sub validar()

        If txt_cd_plan_estudio.Text.Trim = "" Then
            txt_cd_plan_estudio.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_titulo.Text.Trim = "" Then
            txt_titulo.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_plan_alta_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        iniciar_formulario()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_operacion()
    End Sub

    Private Sub txt_cd_plan_estudio_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_cd_plan_estudio.Validating
        If Me.txt_cd_plan_estudio.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_cd_plan_estudio, "Debe ingresar un código válido")
        Else
            ErrorProvider.SetError(Me.txt_cd_plan_estudio, "")
        End If
    End Sub

    Private Sub txt_titulo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_titulo.Validating
        If Me.txt_titulo.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_titulo, "Debe ingresar un nombre válido")
        Else
            ErrorProvider.SetError(Me.txt_titulo, "")
        End If
    End Sub

    Private Sub txt_cd_plan_estudio_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_cd_plan_estudio.KeyPress
        Dim c As Char = e.KeyChar
        If c = Chr(32) Then
            e.Handled = True
        End If
    End Sub

#End Region


End Class