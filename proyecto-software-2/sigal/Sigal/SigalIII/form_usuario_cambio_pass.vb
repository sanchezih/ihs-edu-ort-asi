Public Class form_usuario_cambio_pass

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String = ""
#End Region

#Region "PROPIEDADES DE CONTROL"
    Public Property _cd_usuario() As String
        Get
            Return cd_usuario
        End Get
        Set(ByVal Value As String)
            cd_usuario = Value
        End Set
    End Property
#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()
        txt_pass_antigua.TabIndex = 0
        txt_pass_nueva.TabIndex = 1
        txt_confirma_nueva_pass.TabIndex = 2
        btn_aceptar.TabIndex = 3
        btn_cancelar.TabIndex = 4

        Label5.Text = _cd_usuario
    End Sub

    Private Sub aceptar_operacion()

        Dim o_negocio_usuario As New Negocio.Usuario
        Dim o_entidad_usuario As New Entidades.Usuario
        Dim l_entidades_usuario As New List(Of Entidades.Usuario)

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el cambio de contraseña?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then

                l_entidades_usuario = o_negocio_usuario.get_all_by_filtros(cd_usuario, Me.txt_pass_antigua.Text)
                If l_entidades_usuario.Count > 0 Then
                    o_entidad_usuario._cd_usuario = cd_usuario
                    o_entidad_usuario._password_usuario = txt_pass_nueva.Text

                    o_negocio_usuario.update(o_entidad_usuario)
                Else
                    Me.txt_pass_antigua.Clear()
                    Me.txt_pass_nueva.Clear()
                    Me.txt_confirma_nueva_pass.Focus()
                    MessageBox.Show("Los datos ingresados son invalidos.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            o_entidad_usuario = Nothing
            o_negocio_usuario = Nothing
        End Try
    End Sub

    Private Sub validar()

        If txt_pass_antigua.Text.Trim = "" Then
            txt_pass_antigua.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_pass_nueva.Text.Trim = "" Then
            txt_pass_nueva.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_confirma_nueva_pass.Text.Trim = "" Then
            txt_confirma_nueva_pass.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

    End Sub

    Private Sub validar_pass_introducida(ByVal cd_usuario As String, ByVal pass_antigua As String)

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_operacion()
    End Sub

    Private Sub form_usuario_cambio_pass_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub txt_pass_antigua_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_pass_antigua.Validating
        If Me.txt_pass_antigua.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_pass_antigua, "Debe ingresar una contraseña válida")
        Else
            ErrorProvider.SetError(Me.txt_pass_antigua, "")
        End If
    End Sub

    Private Sub txt_pass_nueva_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_pass_nueva.Validating
        If Me.txt_pass_nueva.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_pass_nueva, "Debe ingresar una contraseña válida")
        Else
            ErrorProvider.SetError(Me.txt_pass_nueva, "")
        End If
    End Sub

    Private Sub txt_confirma_nueva_pass_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_confirma_nueva_pass.Validating
        If Me.txt_confirma_nueva_pass.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_confirma_nueva_pass, "Debe confirmar la contraseña ingresada")
        Else
            ErrorProvider.SetError(Me.txt_confirma_nueva_pass, "")
        End If
    End Sub

#End Region

End Class