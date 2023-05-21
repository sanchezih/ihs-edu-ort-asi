Public Class form_usuario_alta

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String = ""
    Dim componentes As New Sigal.Componentes
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
        txt_usuario.TabIndex = 0
        txt_pass.TabIndex = 1
        txt_confirma_pass.TabIndex = 2
        RadioButton1.TabIndex = 3
        RadioButton2.TabIndex = 4
        btn_aceptar.TabIndex = 5
        btn_cancelar.TabIndex = 6

        Me.txt_usuario.Focus()
        RadioButton1.Checked = True
    End Sub

    Private Sub aceptar_operacion()

        Dim o_negocio_materia As New Negocio.Usuario
        Dim o_entidad_materia As New Entidades.Usuario

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el alta del usuario """ + txt_usuario.Text + """?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then

                o_entidad_materia._cd_usuario = txt_usuario.Text
                o_entidad_materia._password_usuario = txt_pass.Text

                If RadioButton1.Checked = True Then
                    o_entidad_materia._cd_rol = 1
                Else
                    o_entidad_materia._cd_rol = 2
                End If

                o_negocio_materia.add(o_entidad_materia)

            End If
            Me.Close()
            MessageBox.Show("El usuario se dio de alta correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            o_entidad_materia = Nothing
            o_negocio_materia = Nothing
        End Try
    End Sub

    Private Sub validar()

        If txt_usuario.Text.Trim = "" Then
            txt_usuario.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_pass.Text.Trim = "" Then
            txt_pass.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_confirma_pass.Text.Trim = "" Then
            txt_confirma_pass.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If Not txt_pass.Text = txt_confirma_pass.Text Then
            txt_pass.Clear()
            txt_confirma_pass.Clear()
            txt_pass.Focus()
            Throw New ArgumentException("Las contraseñas ingresadas no coinciden.")
        End If

        Dim r As Int32
        r = componentes.consulta_existencia_cd_usuario(txt_usuario.Text)

        If r > 0 Then
            componentes.limpiar(Me)
            txt_usuario.Focus()
            Throw New ArgumentException("El usuario ingresado ya existe.")
        End If

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_usuario_alta_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_operacion()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_usuario_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_usuario.Validating
        If Me.txt_usuario.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_usuario, "Debe ingresar un usuario válido")
        Else
            ErrorProvider.SetError(Me.txt_usuario, "")
        End If
    End Sub

    Private Sub txt_pass_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_pass.Validating
        If Me.txt_pass.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_pass, "Debe ingresar una contraseña válida")
        Else
            ErrorProvider.SetError(Me.txt_pass, "")
        End If
    End Sub

    Private Sub txt_confirma_pass_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_confirma_pass.Validating
        If Me.txt_confirma_pass.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_confirma_pass, "Debe confirmar la contraseña ingresada")
        Else
            ErrorProvider.SetError(Me.txt_confirma_pass, "")
        End If
    End Sub
    
#End Region

End Class