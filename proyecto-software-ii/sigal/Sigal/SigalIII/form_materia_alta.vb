Public Class form_materia_alta

#Region "VARIABLES DE CLASE"
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
        txt_cd_materia.TabIndex = 0
        txt_nombre_materia.TabIndex = 1
        btn_aceptar.TabIndex = 2
        btn_cancelar.TabIndex = 3

        Me.txt_cd_materia.Focus()
    End Sub

    Private Sub aceptar_operacion()

        Dim o_negocio_materia As New Negocio.Materia
        Dim o_entidad_materia As New Entidades.Materia

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el alta de la materia """ + txt_nombre_materia.Text + """?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then
                o_entidad_materia._cd_materia = txt_cd_materia.Text.ToUpper
                o_entidad_materia._nombre_materia = txt_nombre_materia.Text

                'Agrego una materia
                o_negocio_materia.add(o_entidad_materia)

            End If
            Me.Close()
            MessageBox.Show("La materia se dio de alta correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            'Capturo excepciones genéricas.
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            'Libero los objetos.
            o_entidad_materia = Nothing
            o_negocio_materia = Nothing
        End Try
    End Sub

    Private Sub validar()

        If txt_cd_materia.Text.Trim = "" Then
            txt_cd_materia.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_nombre_materia.Text.Trim = "" Then
            txt_nombre_materia.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_materia_alta_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub txt_cd_materia_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_cd_materia.Validating
        If Me.txt_cd_materia.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_cd_materia, "Debe ingresar un código válido")
        Else
            ErrorProvider.SetError(Me.txt_cd_materia, "")
        End If
    End Sub

    Private Sub txt_nombre_materia_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nombre_materia.Validating
        If Me.txt_nombre_materia.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_nombre_materia, "Debe ingresar un nombre válido")
        Else
            ErrorProvider.SetError(Me.txt_nombre_materia, "")
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_operacion()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        'Me.Hide()

        'Pongo esto para probar
        Me.Close()
    End Sub

    Private Sub txt_cd_materia_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_cd_materia.KeyPress
        Dim c As Char = e.KeyChar
        If c = Chr(32) Then
            e.Handled = True
        End If
    End Sub

#End Region

End Class