Public Class form_materia_search

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String = ""
    Dim oBindingSource As New BindingSource
    Dim i As Integer
    Dim rta As Integer
    Dim o_entidades_materia As New Entidades.Materia
    Dim o_form_materia_edicion As New form_materia_edicion
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

        ' PROPIEDADES DEL FORM
        txt_cd_materia.MaxLength = 6
        txt_nombre_materia.MaxLength = 100

        grilla_materia.RowsDefaultCellStyle.BackColor = Color.White
        grilla_materia.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        txt_cd_materia.TabIndex = 0
        txt_nombre_materia.TabIndex = 1
        btn_buscar.TabIndex = 2
        btn_ir.TabIndex = 3

        btn_limpiar.TabIndex = 4
        btn_cancelar.TabIndex = 5
        ' FIN PROPIEDADES DEL FORM

        cb_opciones.SelectedIndex = 0
        txt_cd_materia.Focus()
        buscar_materia()
    End Sub

    Public Sub buscar_materia()

        Dim l_entidades_materia As New List(Of Entidades.Materia)
        Dim o_negocio_materia As New Negocio.Materia

        Dim cd_materia As String
        Dim nombre_materia As String

        cd_materia = txt_cd_materia.Text
        nombre_materia = txt_nombre_materia.Text

        Try
            l_entidades_materia = o_negocio_materia.get_all_by_filtros(cd_materia, nombre_materia)
            grilla_materia.Rows.Clear()

            For i = 1 To l_entidades_materia.ToArray.Length
                o_entidades_materia = l_entidades_materia.Item(i - 1)

                grilla_materia.Rows.Add()
                grilla_materia.Rows(i - 1).Cells(0).Value = o_entidades_materia._cd_materia
                grilla_materia.Rows(i - 1).Cells(1).Value = o_entidades_materia._nombre_materia
                grilla_materia.Rows(i - 1).Cells(2).Value = o_entidades_materia._desc_estado_general
                grilla_materia.Rows(i - 1).Cells(3).Value = o_entidades_materia._fc_alta
                grilla_materia.Rows(i - 1).Cells(4).Value = o_entidades_materia._fc_ultima_modificacion
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally

            'Libero memoria
            l_entidades_materia = Nothing
            o_negocio_materia = Nothing
        End Try
    End Sub

    Private Sub editar_materia()
        Dim r As Int32
        r = componentes.consulta_rol(cd_usuario)
        If r = 1 Then
            If item_seleccionado() Then
                Dim o_form_materia_edicion As form_materia_edicion
                o_form_materia_edicion = New form_materia_edicion
                o_form_materia_edicion._cd_materia = grilla_materia.SelectedCells.Item(0).Value
                o_form_materia_edicion.ShowDialog()
                o_form_materia_edicion.Close()
                o_form_materia_edicion = Nothing
                buscar_materia()
            Else
                MessageBox.Show("Debe seleccionar una materia para editar.", "Edición de materia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            componentes.mostrar_mensaje_no_tiene_privilegios()
        End If
    End Sub

    Private Function item_seleccionado() As Boolean
        Return grilla_materia.SelectedCells.Count > 0
    End Function

    Public Sub alta_materia()
        Dim r As Int32
        r = componentes.consulta_rol(cd_usuario)

        If r = 1 Then
            Dim o_form_materia_alta As form_materia_alta
            o_form_materia_alta = New form_materia_alta
            o_form_materia_alta.ShowDialog()
            o_form_materia_alta.Close()
            o_form_materia_alta = Nothing
            buscar_materia()
        Else
            componentes.mostrar_mensaje_no_tiene_privilegios()
        End If
    End Sub

#End Region

#Region "EVENTOS"

    Friend Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        buscar_materia()
    End Sub

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        alta_materia()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        editar_materia()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        componentes.limpiar(Me)
        buscar_materia()
    End Sub

    Private Sub form_materia_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub txt_cd_materia_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_cd_materia.KeyPress
        Dim c As Char = e.KeyChar
        If c = Chr(32) Then
            e.Handled = True
        End If
    End Sub

#End Region

    Private Sub btn_ir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ir.Click
        If Me.cb_opciones.SelectedIndex = 0 Then
            alta_materia()
        End If
        If Me.cb_opciones.SelectedIndex = 1 Then
            editar_materia()
        End If
    End Sub
End Class