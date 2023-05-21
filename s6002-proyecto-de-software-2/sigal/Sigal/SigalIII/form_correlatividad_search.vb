Public Class form_correlatividad_search

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String = ""
    Dim o_entidades_correlatividad As New Entidades.Correlatividad
    Dim i As Integer
    Dim componentes As New Sigal.Componentes
    Dim plan As String
    Dim materia As String

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
        grilla_correlatividad.RowsDefaultCellStyle.BackColor = Color.White
        grilla_correlatividad.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        cb_planes.TabIndex = 0
        btn_ir.TabIndex = 1
        btn_cancelar.TabIndex = 2

        cb_opciones.SelectedIndex = 0
        ' FIN PROPIEDADES DEL FORM

        cb_planes.Focus()
        componentes.llenar_combo_con_todos_los_planes(cb_planes)
        If cb_planes.Items.Count > 0 Then
            cb_planes.SelectedItem = cb_planes.Items.Item(0)

            buscar_correlatividad()
        End If
    End Sub

    Public Sub alta_correlatividad()
        Dim r As Int32
        r = componentes.consulta_rol(cd_usuario)

        If r = 1 Then
            Dim o_form_correlatividad_alta As form_correlatividad_alta
            o_form_correlatividad_alta = New form_correlatividad_alta
            o_form_correlatividad_alta.ShowDialog()
            o_form_correlatividad_alta.Close()
            o_form_correlatividad_alta = Nothing

            iniciar_formulario()
        Else
            componentes.mostrar_mensaje_no_tiene_privilegios()
        End If
    End Sub

    Public Sub buscar_correlatividad()

        Dim l_entidades_correlatividad As New List(Of Entidades.Correlatividad)
        Dim o_negocio_correlatividad As New Negocio.Correlatividad
        Dim o_entidades_plan As New Entidades.Plan
        Dim o_entidades_materia As New Entidades.Materia

        If cb_planes.Items.Count > 0 Then

            o_entidades_plan = cb_planes.SelectedItem
            If Not o_entidades_plan Is Nothing Then
                plan = o_entidades_plan._cd_plan_estudio
                If plan Is Nothing Then
                    plan = ""
                End If
            Else
                plan = ""
            End If

            Try

                l_entidades_correlatividad = o_negocio_correlatividad.get_all_by_filtros(plan, materia)
                grilla_correlatividad.Rows.Clear()

                For i = 1 To l_entidades_correlatividad.ToArray.Length
                    o_entidades_correlatividad = l_entidades_correlatividad.Item(i - 1)

                    grilla_correlatividad.Rows.Add()
                    grilla_correlatividad.Rows(i - 1).Cells(0).Value = o_entidades_correlatividad._cd_plan_estudio
                    grilla_correlatividad.Rows(i - 1).Cells(1).Value = o_entidades_correlatividad._cd_materia
                    grilla_correlatividad.Rows(i - 1).Cells(2).Value = o_entidades_correlatividad._nombre_materia
                    grilla_correlatividad.Rows(i - 1).Cells(3).Value = o_entidades_correlatividad._cd_materia_correlativa
                    grilla_correlatividad.Rows(i - 1).Cells(4).Value = o_entidades_correlatividad._correl
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                'Libero memoria
                l_entidades_correlatividad = Nothing
                o_negocio_correlatividad = Nothing
            End Try
        End If
    End Sub

    Private Sub eliminar_correlatividad()
        Dim r As Int32
        r = componentes.consulta_rol(cd_usuario)

        If r = 1 Then
            If IsItemSelected() Then

                Dim confirmacion As String
                confirmacion = MessageBox.Show("¿Confirma la eliminación de la correlatividad?", "Eliminación de correlatividad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If confirmacion = 1 Then
                    Dim o_negocio_correlatividad As New Negocio.Correlatividad

                    Dim cd_plan_estudio As String
                    Dim cd_materia As String
                    Dim cd_materia_correlativa As String

                    Try
                        cd_plan_estudio = grilla_correlatividad.SelectedCells.Item(0).Value
                        cd_materia = grilla_correlatividad.SelectedCells.Item(1).Value
                        cd_materia_correlativa = grilla_correlatividad.SelectedCells.Item(3).Value

                        o_negocio_correlatividad.delete(cd_plan_estudio, cd_materia, cd_materia_correlativa)

                        MessageBox.Show("La correlatividad se eliminó correctamente.", "Eliminación de correlatividad", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        iniciar_formulario()

                    Catch ex As Exception

                        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        o_negocio_correlatividad = Nothing
                    End Try

                End If

            Else
                'informo que no hay seleccionado
                MessageBox.Show("Debe seleccionar una correlatividad para eliminar.", "Eliminación de correlatividad", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            componentes.mostrar_mensaje_no_tiene_privilegios()
        End If
    End Sub

    Private Function IsItemSelected() As Boolean
        'si hay algun item seleccionado retorna true sino false
        Return grilla_correlatividad.SelectedRows.Count > 0
    End Function

#End Region

#Region "EVENTOS"

    Private Sub form_correlatividad_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        buscar_correlatividad()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub cb_materias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        buscar_correlatividad()
    End Sub

    Private Sub btn_ir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ir.Click
        If Me.cb_opciones.SelectedIndex = 0 Then
            alta_correlatividad()
        End If
        If Me.cb_opciones.SelectedIndex = 1 Then
            eliminar_correlatividad()
        End If
    End Sub

#End Region

End Class