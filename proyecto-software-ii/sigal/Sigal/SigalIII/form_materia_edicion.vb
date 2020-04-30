Public Class form_materia_edicion

#Region "VARIABLES DE CLASE"
    Private cancelado As Boolean = True
    Private cd_materia As String = ""
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

    Public Property _cd_materia() As String
        Get
            Return cd_materia
        End Get
        Set(ByVal Value As String)
            cd_materia = Value
        End Set
    End Property

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        txt_nombre_materia.TabIndex = 0
        cb_desc_estado_general.TabIndex = 1
        btn_aceptar.TabIndex = 2
        btn_cancelar.TabIndex = 3

        Componentes.llenar_combo_estado(cb_desc_estado_general)

        Dim l_entidades_materia As List(Of Entidades.Materia)
        Dim oMateriaNegocio As New Negocio.Materia
        Try

            l_entidades_materia = oMateriaNegocio.get_one(cd_materia)

            If l_entidades_materia.Count > 0 Then
                With l_entidades_materia(0)
                    cb_desc_estado_general.Text = ._desc_estado_general
                    txt_nombre_materia.Text = ._nombre_materia
                    lbl_valor_cd_materia.Text = ._cd_materia

                    Label8.Text = "Edición de " + ._cd_materia
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

        Dim o_e_materia As New Entidades.materia
        Dim o_n_materia As New Negocio.materia
        Dim o_e_estado_general As New Entidades.EstadoGeneral

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma la modificación de los datos de la materia?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If confirmacion = 1 Then
                o_e_materia._cd_materia = lbl_valor_cd_materia.Text
                o_e_materia._nombre_materia = txt_nombre_materia.Text

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
        If txt_nombre_materia.Text.Trim = "" Then
            txt_nombre_materia.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_materia_edicion_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_titulo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nombre_materia.Validating
        If Me.txt_nombre_materia.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_nombre_materia, "Debe tener un valor")
        Else
            ErrorProvider.SetError(Me.txt_nombre_materia, "")
        End If
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_operacion()
    End Sub

#End Region

End Class