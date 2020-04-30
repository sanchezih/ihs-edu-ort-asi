Public Class form_pmc_search

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String = ""
    Dim Componentes As New Sigal.Componentes
    Dim o_entidades_materia As New Entidades.PMC
    Dim i As Integer
    Dim plan As Entidades.Plan = Nothing
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

    Public Property _plan() As Entidades.Plan
        Get
            Return plan
        End Get
        Set(ByVal Value As Entidades.Plan)
            plan = Value
        End Set
    End Property
#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        ' PROPIEDADES DEL FORM
        txt_cuatrimestre_carrera.MaxLength = 1

        grilla_pmc.RowsDefaultCellStyle.BackColor = Color.White
        grilla_pmc.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        cb_planes.TabIndex = 0
        txt_cuatrimestre_carrera.TabIndex = 1
        btn_buscar.TabIndex = 2
        btn_ir.TabIndex = 3

        btn_limpiar.TabIndex = 4
        btn_cancelar.TabIndex = 5
        ' FIN PROPIEDADES DEL FORM

        cb_opciones.SelectedIndex = 0
        cb_planes.Focus()


        Componentes.llenar_combo_con_todos_los_planes(cb_planes)
        If Not plan Is Nothing Then
            Dim i As Integer
            i = cb_planes.FindString(plan._cd_plan_estudio + " - " + plan._titulo)
            cb_planes.SelectedIndex = i
            buscar_pmc()
        Else
            If cb_planes.Items.Count > 0 Then
                cb_planes.SelectedItem = cb_planes.Items.Item(0)
                buscar_pmc()
            End If
        End If


    End Sub

    Public Sub alta_pmc()
        Dim r As Int32
        r = Componentes.consulta_rol(cd_usuario)
        If r = 1 Then
            Dim o_form_pmc_alta As form_pmc_alta
            o_form_pmc_alta = New form_pmc_alta
            o_form_pmc_alta.ShowDialog()
            Dim resultado_ok As Boolean = Not o_form_pmc_alta._cancelado
            o_form_pmc_alta.Close()
            o_form_pmc_alta = Nothing
            If resultado_ok Then
                buscar_pmc()
            End If
        Else
            Componentes.mostrar_mensaje_no_tiene_privilegios()
        End If

    End Sub

    Public Sub buscar_pmc()

        Dim l_entidades_materia As New List(Of Entidades.PMC)
        Dim o_negocio_materia As New Negocio.PMC
        Dim o_entidades_plan As New Entidades.Plan
        Dim plan As String

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

            Dim cuatrimestre_carrera As Int32

            If Me.txt_cuatrimestre_carrera.Text.Trim = "" Then
                cuatrimestre_carrera = 0
            Else
                cuatrimestre_carrera = CInt(txt_cuatrimestre_carrera.Text)
            End If

            Try
                l_entidades_materia = o_negocio_materia.get_all_by_filtros(plan, cuatrimestre_carrera)
                grilla_pmc.Rows.Clear()

                For i = 1 To l_entidades_materia.ToArray.Length
                    o_entidades_materia = l_entidades_materia.Item(i - 1)

                    grilla_pmc.Rows.Add()
                    grilla_pmc.Rows(i - 1).Cells(0).Value = o_entidades_materia._cd_plan_estudio
                    grilla_pmc.Rows(i - 1).Cells(1).Value = o_entidades_materia._titulo
                    grilla_pmc.Rows(i - 1).Cells(2).Value = o_entidades_materia._cd_materia
                    grilla_pmc.Rows(i - 1).Cells(3).Value = o_entidades_materia._nombre_materia
                    grilla_pmc.Rows(i - 1).Cells(4).Value = o_entidades_materia._cuatrimestre_carrera
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                l_entidades_materia = Nothing
                o_negocio_materia = Nothing
            End Try
        End If
    End Sub

    Private Sub eliminar_pmc()
        Dim r As Int32
        r = Componentes.consulta_rol(cd_usuario)
        If r = 1 Then
            If IsItemSelected() Then
                Dim confirmacion As String
                confirmacion = MessageBox.Show("¿Confirma la eliminación de la asignación plan - materia?", "Eliminación de asignación plan - materia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If confirmacion = 1 Then
                    If pmc_apta_alimincacion() Then
                        Dim o_negocio_pmc As New Negocio.PMC
                        Dim cd_plan_estudio As String
                        Dim cd_materia As String
                        Dim cuatrimestre As Int32
                        Try
                            cd_plan_estudio = grilla_pmc.SelectedCells.Item(0).Value
                            cd_materia = grilla_pmc.SelectedCells.Item(2).Value
                            cuatrimestre = grilla_pmc.SelectedCells.Item(4).Value
                            o_negocio_pmc.delete(cd_plan_estudio, cd_materia, cuatrimestre)
                            MessageBox.Show("La asignación plan - materia se eliminó correctamente.", "Eliminación de asignación plan - materia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            iniciar_formulario()
                        Catch ex As Exception

                            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            o_negocio_pmc = Nothing
                        End Try
                    Else
                        MessageBox.Show("La materia seleccionada es correlativa de alguna materia" & Chr(13) & "y/o tiene una o mas materia/s correlativa/s." & Chr(13) & "Verifique antes de eliminar.", "Eliminación de asignación plan - materia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Debe seleccionar una asignación plan - materia para eliminar.", "Eliminación de asignación plan - materia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Componentes.mostrar_mensaje_no_tiene_privilegios()
        End If
    End Sub

    Private Function IsItemSelected() As Boolean
        'si hay algun item seleccionado retorna true sino false
        Return grilla_pmc.SelectedRows.Count > 0
    End Function

    Private Function pmc_apta_alimincacion() As Boolean

        Dim o_negocio_inscripcionCurso As New Negocio.Correlatividad
        Dim pmc As New Entidades.PMC
        Dim cantidad As Integer

        pmc._cd_plan_estudio = grilla_pmc.SelectedCells.Item(0).Value
        pmc._cd_materia = grilla_pmc.SelectedCells.Item(2).Value

        cantidad = o_negocio_inscripcionCurso.consulta_cantidad_correlativas(pmc._cd_plan_estudio, pmc._cd_materia)

        Return cantidad = 0

    End Function

#End Region

#Region "EVENTOS"

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        buscar_pmc()
    End Sub

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        alta_pmc()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        Componentes.limpiar(Me)
        buscar_pmc()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        eliminar_pmc()
    End Sub

    Private Sub form_pmc_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        buscar_pmc()
    End Sub

    Private Sub txt_cuatrimestre_carrera_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_cuatrimestre_carrera.KeyPress

        Dim c As Char = e.KeyChar
        Select Case c
            Case "1"c, "2"c, "3"c, "4"c, "5"c, "6"c

            Case Chr(8) ' Tecla retroceso
            Case Else
                e.Handled = True
        End Select
    End Sub

#End Region

    Private Sub btn_ir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ir.Click
        If Me.cb_opciones.SelectedIndex = 0 Then
            alta_pmc()
        End If
        If Me.cb_opciones.SelectedIndex = 1 Then
            eliminar_pmc()
        End If
    End Sub
End Class