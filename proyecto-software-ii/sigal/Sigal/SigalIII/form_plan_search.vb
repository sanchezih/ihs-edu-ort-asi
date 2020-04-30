Public Class form_plan_search

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String = ""
    Dim componentes As New Sigal.Componentes
    Dim i As Integer
    Dim o_entidades_plan As New Entidades.Plan
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
        txt_cd_plan_estudio.MaxLength = 6
        txt_titulo.MaxLength = 100

        grilla_plan.RowsDefaultCellStyle.BackColor = Color.White
        grilla_plan.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        txt_cd_plan_estudio.TabIndex = 0
        txt_titulo.TabIndex = 1
        btn_buscar.TabIndex = 2
        btn_ir.TabIndex = 3
        btn_limpiar.TabIndex = 4
        btn_cancelar.TabIndex = 5
        ' FIN PROPIEDADES DEL FORM
        cb_opciones.SelectedIndex = 0
        txt_cd_plan_estudio.Focus()
        buscar_plan()
    End Sub

    Private Sub buscar_plan()

        Dim l_entidades_plan As New List(Of Entidades.Plan)
        Dim o_negocio_plan As New Negocio.Plan

        Dim cd_plan_estudio As String
        Dim titulo As String

        cd_plan_estudio = txt_cd_plan_estudio.Text
        titulo = txt_titulo.Text

        Try
            l_entidades_plan = o_negocio_plan.get_all_by_filtros(cd_plan_estudio, titulo)
            grilla_plan.Rows.Clear()

            For i = 1 To l_entidades_plan.ToArray.Length
                o_entidades_plan = l_entidades_plan.Item(i - 1)

                grilla_plan.Rows.Add()
                grilla_plan.Rows(i - 1).Cells(0).Value = o_entidades_plan._cd_plan_estudio
                grilla_plan.Rows(i - 1).Cells(1).Value = o_entidades_plan._titulo
                grilla_plan.Rows(i - 1).Cells(2).Value = o_entidades_plan._desc_estado_general
                grilla_plan.Rows(i - 1).Cells(3).Value = o_entidades_plan._fc_alta
                grilla_plan.Rows(i - 1).Cells(4).Value = o_entidades_plan._fc_ultima_modificacion
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally

            'Libero memoria
            l_entidades_plan = Nothing
            o_negocio_plan = Nothing
        End Try
    End Sub

    Public Sub alta_plan()

        Dim r As Int32
        r = componentes.consulta_rol(cd_usuario)

        If r = 1 Then
            Dim o_form_plan_alta As form_plan_alta
            o_form_plan_alta = New form_plan_alta
            o_form_plan_alta.ShowDialog()
            o_form_plan_alta.Close()
            o_form_plan_alta = Nothing
            buscar_plan()
        Else
            componentes.mostrar_mensaje_no_tiene_privilegios()
        End If
    End Sub

    Private Sub editar_plan()

        Dim r As Int32
        r = componentes.consulta_rol(cd_usuario)

        If r = 1 Then
            If item_seleccionado() Then

                Dim o_form_plan_edicion As form_plan_edicion
                o_form_plan_edicion = New form_plan_edicion

                o_form_plan_edicion._cd_plan = grilla_plan.SelectedCells.Item(0).Value

                o_form_plan_edicion.ShowDialog()

                o_form_plan_edicion.Close()

                o_form_plan_edicion = Nothing

                buscar_plan()

            Else
                MessageBox.Show("Debe seleccionar un plan de estudio para editar.", "Edición de plan de estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            componentes.mostrar_mensaje_no_tiene_privilegios()
        End If
    End Sub

    Private Function item_seleccionado() As Boolean
        Return grilla_plan.SelectedCells.Count > 0
    End Function

    Private Sub ver_materias()

        Dim r As Int32
        r = componentes.consulta_rol(cd_usuario)

        If r = 1 Then
            If item_seleccionado() Then

                Dim o_form_pmc_search As form_pmc_search
                o_form_pmc_search = New form_pmc_search

                o_entidades_plan._cd_plan_estudio = grilla_plan.SelectedCells.Item(0).Value
                o_entidades_plan._titulo = grilla_plan.SelectedCells.Item(1).Value

                o_form_pmc_search._plan = o_entidades_plan
                o_form_pmc_search._cd_usuario = cd_usuario

                o_form_pmc_search.ShowDialog()

                o_form_pmc_search.Close()

                o_form_pmc_search = Nothing

                ' buscar_plan()

            Else
                MessageBox.Show("Debe seleccionar un plan de estudio para ver sus materias.", "Consulta de asignación plan - materia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            componentes.mostrar_mensaje_no_tiene_privilegios()
        End If
    End Sub

    Private Sub ver_inscripciones_a_plan()

        If item_seleccionado() Then

            Dim o_form_inscripcion_plan_search As form_inscripcion_plan_search
            o_form_inscripcion_plan_search = New form_inscripcion_plan_search

            o_entidades_plan._cd_plan_estudio = grilla_plan.SelectedCells.Item(0).Value
            o_entidades_plan._titulo = grilla_plan.SelectedCells.Item(1).Value

            o_form_inscripcion_plan_search._plan = o_entidades_plan
            o_form_inscripcion_plan_search._cd_usuario = cd_usuario

            o_form_inscripcion_plan_search.ShowDialog()

            o_form_inscripcion_plan_search.Close()

            o_form_inscripcion_plan_search = Nothing

            ' buscar_plan()

        Else
            MessageBox.Show("Debe seleccionar un plan de estudio para ver las inscripciones.", "Consulta de inscripción a plan de estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_plan_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Friend Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        buscar_plan()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub txt_cd_plan_estudio_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_cd_plan_estudio.KeyPress
        Dim c As Char = e.KeyChar
        If c = Chr(32) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        componentes.limpiar(Me)
        buscar_plan()
    End Sub

    Private Sub btn_ir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ir.Click
        If Me.cb_opciones.SelectedIndex = 0 Then
            alta_plan()
        End If
        If Me.cb_opciones.SelectedIndex = 1 Then
            editar_plan()
        End If
        If Me.cb_opciones.SelectedIndex = 2 Then
            ver_materias()
        End If
        If Me.cb_opciones.SelectedIndex = 3 Then
            ver_inscripciones_a_plan()
        End If
    End Sub

#End Region

End Class