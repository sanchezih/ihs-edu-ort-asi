Public Class form_login


#Region "VARIABLES DE CLASE"
    Public veces As Integer = 0
    Public intentos As Integer = 3
#End Region

#Region "PROPIEDADES DE CONTROL"

#End Region

#Region "METODOS"

    Private Sub seteo_form()
        Me.txt_cd_usuario.Focus()
        Me.txt_cd_usuario.MaxLength = 100
        Me.txt_password_usuario.MaxLength = 100

        txt_cd_usuario.TabIndex = 0
        txt_password_usuario.TabIndex = 1
        btn_aceptar.TabIndex = 2
        btn_cancelar.TabIndex = 3
    End Sub

    Private Sub iniciar_formulario()

    End Sub

    Public Sub ingreso()

        Dim l_entidades_usuario As New List(Of Entidades.Usuario)
        Dim o_negocio_usuario As New Negocio.Usuario
        Try
            validar()
            l_entidades_usuario = o_negocio_usuario.get_all_by_filtros(Me.txt_cd_usuario.Text, Me.txt_password_usuario.Text)
            If l_entidades_usuario.Count > 0 Then
                Me.Hide()
                ' form_principal.Show()

                Dim o_form_principal As form_principal
                o_form_principal = New form_principal

                o_form_principal._cd_usuario = txt_cd_usuario.Text

                o_form_principal.ShowDialog()

                o_form_principal.Close()

                o_form_principal = Nothing

            Else
                Me.txt_cd_usuario.Clear()
                Me.txt_password_usuario.Clear()
                Me.txt_cd_usuario.Focus()
                MessageBox.Show("Los datos ingresados son invalidos.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            o_negocio_usuario = Nothing
            l_entidades_usuario = Nothing
        End Try


    End Sub

    Private Sub validar()

        If txt_cd_usuario.Text.Trim = "" Then
            txt_cd_usuario.Focus()
            Throw New ArgumentException("Debe ingresar un nombre de usuario.")
        End If

        If txt_password_usuario.Text.Trim = "" Then
            txt_password_usuario.Focus()
            Throw New ArgumentException("Debe ingresar una contraseña.")
        End If

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Application.Exit()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        ingreso()
    End Sub

    Private Sub form_login_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        seteo_form()
        iniciar_formulario()
    End Sub

    Private Sub txt_cd_usuario_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_cd_usuario.Validating
        If Me.txt_cd_usuario.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_cd_usuario, "Debe ingresar un nombre de usuario")
        Else
            ErrorProvider.SetError(Me.txt_cd_usuario, "")
        End If
    End Sub

    Private Sub txt_password_usuario_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_password_usuario.Validating
        If Me.txt_password_usuario.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_password_usuario, "Debe ingresar una contraseña")
        Else
            ErrorProvider.SetError(Me.txt_password_usuario, "")
        End If
    End Sub

#End Region

End Class
