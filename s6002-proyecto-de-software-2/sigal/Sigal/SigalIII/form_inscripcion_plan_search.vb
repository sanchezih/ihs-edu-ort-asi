Public Class form_inscripcion_plan_search

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String = ""
    Private alumno As Int32 = 0

    Dim Componentes As New Sigal.Componentes
    Dim o_entidades_inscripcionPlan As New Entidades.InscripcionPlan
    Dim i As Integer
    Dim plan As String
    Dim e_plan As Entidades.Plan = Nothing
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

    Public Property _alumno() As Int32
        Get
            Return alumno
        End Get
        Set(ByVal Value As Int32)
            alumno = Value
        End Set
    End Property


    Public Property _plan() As Entidades.Plan
        Get
            Return e_plan
        End Get
        Set(ByVal Value As Entidades.Plan)
            e_plan = Value
        End Set
    End Property

#End Region

#Region "METODOS"

    Private Sub seteo_form()
        cb_planes.Focus()
        txt_cd_alumno.MaxLength = 9

        grilla_inscripcion_plan.RowsDefaultCellStyle.BackColor = Color.White
        grilla_inscripcion_plan.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        cb_planes.TabIndex = 0
        txt_cd_alumno.TabIndex = 1
        btn_buscar.TabIndex = 2
        btn_ir.TabIndex = 3
        btn_limpiar.TabIndex = 4
        btn_cancelar.TabIndex = 5
    End Sub

    Private Sub iniciar_formulario()

        cb_opciones.SelectedIndex = 0

        Componentes.llenar_combo_con_todos_los_planes(cb_planes)

        If Not e_plan Is Nothing Then
            Dim i As Integer
            i = cb_planes.FindString(e_plan._cd_plan_estudio + " - " + e_plan._titulo)
            cb_planes.SelectedIndex = i
            buscar_inscripcion_plan()
        Else
            If alumno <> 0 Then
                txt_cd_alumno.Text = alumno
                buscar_inscripcion_plan()
            Else
                If cb_planes.Items.Count > 0 Then
                    'cb_planes.SelectedItem = cb_planes.Items.Item(0)
                    cb_planes.SelectedItem = Nothing
                    buscar_inscripcion_plan()
                End If
            End If
        End If
    End Sub

    Public Sub buscar_inscripcion_plan()

        Dim l_entidades_inscripcionPlan As New List(Of Entidades.InscripcionPlan)
        Dim o_negocio_inscripcionPlan As New Negocio.InscripcionPlan
        Dim o_entidades_plan As New Entidades.Plan

        If cb_planes.Items.Count > 0 Then

            'o_entidades_plan = cb_planes.SelectedItem

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

                Dim cd_alumno As Int32
                If Me.txt_cd_alumno.Text.Trim = "" Then
                    cd_alumno = 0
                Else
                    cd_alumno = CInt(txt_cd_alumno.Text)
                End If

                l_entidades_inscripcionPlan = o_negocio_inscripcionPlan.get_all_by_filtros(plan, cd_alumno)
                grilla_inscripcion_plan.Rows.Clear()

                For i = 1 To l_entidades_inscripcionPlan.ToArray.Length
                    o_entidades_inscripcionPlan = l_entidades_inscripcionPlan.Item(i - 1)

                    grilla_inscripcion_plan.Rows.Add()
                    grilla_inscripcion_plan.Rows(i - 1).Cells(0).Value = o_entidades_inscripcionPlan._cd_plan_estudio
                    grilla_inscripcion_plan.Rows(i - 1).Cells(1).Value = o_entidades_inscripcionPlan._titulo
                    grilla_inscripcion_plan.Rows(i - 1).Cells(2).Value = o_entidades_inscripcionPlan._cd_alumno
                    grilla_inscripcion_plan.Rows(i - 1).Cells(3).Value = o_entidades_inscripcionPlan._an
                    grilla_inscripcion_plan.Rows(i - 1).Cells(4).Value = o_entidades_inscripcionPlan._fc_alta
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                'Libero memoria
                l_entidades_inscripcionPlan = Nothing
                o_negocio_inscripcionPlan = Nothing
            End Try
        End If
    End Sub

    Public Sub alta_inscripcion_plan()
        Dim o_form_inscripcion_plan_alta As form_inscripcion_plan_alta
        o_form_inscripcion_plan_alta = New form_inscripcion_plan_alta
        o_form_inscripcion_plan_alta.ShowDialog()

        Dim resultado_ok As Boolean = Not o_form_inscripcion_plan_alta._cancelado

        o_form_inscripcion_plan_alta.Close()
        o_form_inscripcion_plan_alta = Nothing

        If resultado_ok Then
            buscar_inscripcion_plan()
        End If

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_inscripcion_plan_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        seteo_form()
        iniciar_formulario()
    End Sub

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        buscar_inscripcion_plan()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        buscar_inscripcion_plan()
    End Sub

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        alta_inscripcion_plan()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        Componentes.limpiar(Me)
        buscar_inscripcion_plan()
    End Sub

    Private Sub txt_cd_curso_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim c As Char = e.KeyChar
        If Not Char.IsDigit(c) Then
            Select Case c
                Case Chr(8) ' Tecla retroceso
                Case Else
                    e.Handled = True
            End Select
        End If
    End Sub


    Private Sub txt_cd_alumno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_cd_alumno.KeyPress

        ' Carácter tecleado'
        Dim c As Char = e.KeyChar

        If Not Char.IsDigit(c) Then
            Select Case c

                'Case "."c, "-"c
                ' Sin implementación

                Case Chr(8)
                    ' Tecla retroceso

                Case Else
                    e.Handled = True
                    '  MessageBox.Show("Ingrese Rut Correctamente", "Registro Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Select
        End If

    End Sub

#End Region

    Private Sub btn_ir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ir.Click
        If Me.cb_opciones.SelectedIndex = 0 Then
            alta_inscripcion_plan()
        End If
    End Sub
End Class