Public Class form_inscripcion_curso_search

#Region "VARIABLES DE CLASE"
    Private curso As Int32 = 0
    Private cd_usuario As String = ""
    Private alumno As Int32 = 0
    Dim Componentes As New Sigal.Componentes
    Dim o_entidades_inscripcionPlan As New Entidades.InscripcionCurso
    Dim i As Int32

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

    Public Property _curso() As Int32
        Get
            Return curso
        End Get
        Set(ByVal Value As Int32)
            curso = Value
        End Set
    End Property

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        ' PROPIEDADES DEL FORM
        txt_cd_curso.MaxLength = 9
        txt_cd_alumno.MaxLength = 9

        grilla_inscripcion_curso.RowsDefaultCellStyle.BackColor = Color.White
        grilla_inscripcion_curso.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        grilla_inscripcion_curso.TabIndex = 0
        cb_planes.TabIndex = 0
        txt_cd_curso.TabIndex = 1
        txt_cd_alumno.TabIndex = 2
        btn_buscar.TabIndex = 3
        btn_ir.TabIndex = 4
        btn_limpiar.TabIndex = 5
        btn_cancelar.TabIndex = 6

        ' FIN PROPIEDADES DEL FORM
        cb_opciones.SelectedIndex = 0
        cb_planes.Focus()

        Componentes.llenar_combo_con_todos_los_planes(cb_planes)

        If curso <> 0 Then
            txt_cd_curso.Text = curso
            buscar_inscripcion_curso()
        Else
            If alumno <> 0 Then
                txt_cd_alumno.Text = alumno
                buscar_inscripcion_curso()
            Else
                If cb_planes.Items.Count > 0 Then
                    cb_planes.SelectedItem = cb_planes.Items.Item(0)
                    cb_planes.SelectedItem = Nothing
                    buscar_inscripcion_curso()
                End If
            End If
        End If

    End Sub

    Public Sub buscar_inscripcion_curso()

        Dim l_entidades_inscripcionCurso As New List(Of Entidades.InscripcionCurso)
        Dim o_negocio_inscripcionCurso As New Negocio.InscripcionCurso
        Dim o_entidades_plan As New Entidades.Plan

        Dim plan As String
        Dim curso As Int32
        Dim alumno As Int32

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

            If Me.txt_cd_curso.Text.Trim = "" Then
                curso = 0
            Else
                curso = CInt(txt_cd_curso.Text)
            End If

            If Me.txt_cd_alumno.Text.Trim = "" Then
                alumno = 0
            Else
                alumno = CInt(txt_cd_alumno.Text)
            End If

            Try

                l_entidades_inscripcionCurso = o_negocio_inscripcionCurso.get_all_by_filtros(plan, curso, alumno)
                grilla_inscripcion_curso.Rows.Clear()

                For i = 1 To l_entidades_inscripcionCurso.ToArray.Length
                    o_entidades_inscripcionPlan = l_entidades_inscripcionCurso.Item(i - 1)

                    grilla_inscripcion_curso.Rows.Add()
                    grilla_inscripcion_curso.Rows(i - 1).Cells(0).Value = o_entidades_inscripcionPlan._cd_curso
                    grilla_inscripcion_curso.Rows(i - 1).Cells(1).Value = o_entidades_inscripcionPlan._nombre_materia
                    grilla_inscripcion_curso.Rows(i - 1).Cells(2).Value = o_entidades_inscripcionPlan._cd_alumno
                    grilla_inscripcion_curso.Rows(i - 1).Cells(3).Value = o_entidades_inscripcionPlan._an
                    grilla_inscripcion_curso.Rows(i - 1).Cells(4).Value = o_entidades_inscripcionPlan._fc_alta
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                'Libero memoria
                l_entidades_inscripcionCurso = Nothing
                o_negocio_inscripcionCurso = Nothing
            End Try
        End If
    End Sub

    Public Sub alta_inscripcion_curso()
        Dim o_form_inscripcion_plan_alta As form_inscripcion_curso_alta
        o_form_inscripcion_plan_alta = New form_inscripcion_curso_alta
        o_form_inscripcion_plan_alta.ShowDialog()

        Dim resultado_ok As Boolean = Not o_form_inscripcion_plan_alta._cancelado

        o_form_inscripcion_plan_alta.Close()
        o_form_inscripcion_plan_alta = Nothing

        If resultado_ok Then
            buscar_inscripcion_curso()
        End If

    End Sub

    Private Sub ver_calificacion_cursada_asociada()

        If item_seleccionado() Then

            Dim o_form_calificacion_cursada_search As form_calificacion_cursada_search
            o_form_calificacion_cursada_search = New form_calificacion_cursada_search

            o_form_calificacion_cursada_search._curso = grilla_inscripcion_curso.SelectedCells.Item(0).Value
            o_form_calificacion_cursada_search._alumno = grilla_inscripcion_curso.SelectedCells.Item(2).Value

            o_form_calificacion_cursada_search.ShowDialog()

            o_form_calificacion_cursada_search.Close()

            o_form_calificacion_cursada_search = Nothing

        Else
            MessageBox.Show("Debe seleccionar una inscripción para ver la calificación asocaida.", "Consulta de calificación de cursada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ver_calificacion_final_asociada()

        If item_seleccionado() Then

            Dim o_form_calificacion_cursada_search As form_calificacion_final_search
            o_form_calificacion_cursada_search = New form_calificacion_final_search

            o_form_calificacion_cursada_search._curso = grilla_inscripcion_curso.SelectedCells.Item(0).Value
            o_form_calificacion_cursada_search._alumno = grilla_inscripcion_curso.SelectedCells.Item(2).Value

            o_form_calificacion_cursada_search.ShowDialog()

            o_form_calificacion_cursada_search.Close()

            o_form_calificacion_cursada_search = Nothing

        Else
            MessageBox.Show("Debe seleccionar una inscripción para ver la calificación asocaida.", "Consulta de calificación de cursada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function item_seleccionado() As Boolean
        Return grilla_inscripcion_curso.SelectedCells.Count > 0
    End Function

#End Region

#Region "EVENTOS"

    Private Sub form_inscripcion_curso_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        Componentes.limpiar(Me)
        buscar_inscripcion_curso()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        buscar_inscripcion_curso()
    End Sub

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        alta_inscripcion_curso()
    End Sub

    Private Sub txt_cd_curso_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_cd_curso.KeyPress
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

        ' Carácter tecleado        '
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

    Private Sub cb_planes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_planes.SelectedIndexChanged
        buscar_inscripcion_curso()
    End Sub

    Private Sub btn_ir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ir.Click
        If Me.cb_opciones.SelectedIndex = 0 Then
            alta_inscripcion_curso()
        End If

        If Me.cb_opciones.SelectedIndex = 1 Then
            ver_calificacion_cursada_asociada()
        End If

        If Me.cb_opciones.SelectedIndex = 2 Then
            ver_calificacion_final_asociada()
        End If
    End Sub

#End Region

End Class