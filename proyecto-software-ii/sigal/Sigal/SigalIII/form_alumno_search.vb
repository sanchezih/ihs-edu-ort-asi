Public Class form_alumno_search

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String = ""
    Dim Componentes As New Sigal.Componentes
    Dim o_entidades_materia As New Entidades.Alumno
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
#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        ' PROPIEDADES DEL FORM
        Me.txt_cd_alumno.MaxLength = 9
        Me.txt_nombre_alumno.MaxLength = 100
        Me.txt_apellido_alumno.MaxLength = 100

        grilla_alumno.RowsDefaultCellStyle.BackColor = Color.White
        grilla_alumno.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        txt_cd_alumno.TabIndex = 0
        txt_apellido_alumno.TabIndex = 1
        txt_nombre_alumno.TabIndex = 2
        btn_buscar.TabIndex = 3
        btn_ir.TabIndex = 4
        btn_limpiar.TabIndex = 5
        btn_cancelar.TabIndex = 6
        ' FIN PROPIEDADES DEL FORM

        cb_opciones.SelectedIndex = 0
        txt_cd_alumno.Focus()
        buscar_alumno()
    End Sub

    Private Sub buscar_alumno()

        Dim l_entidades_materia As New List(Of Entidades.Alumno)
        Dim o_negocio_materia As New Negocio.Alumno

        Dim cd_alumno As Int32
        Dim nombre_alumno As String
        Dim apellido_alumno As String

        If Me.txt_cd_alumno.Text.Trim = "" Then
            cd_alumno = 0
        Else
            cd_alumno = CInt(txt_cd_alumno.Text)
        End If

        nombre_alumno = Me.txt_nombre_alumno.Text
        apellido_alumno = Me.txt_apellido_alumno.Text

        Try
            l_entidades_materia = o_negocio_materia.get_all_by_filtros(cd_alumno, nombre_alumno, apellido_alumno)
            grilla_alumno.Rows.Clear()

            For i = 1 To l_entidades_materia.ToArray.Length
                o_entidades_materia = l_entidades_materia.Item(i - 1)

                grilla_alumno.Rows.Add()
                grilla_alumno.Rows(i - 1).Cells(0).Value = o_entidades_materia._cd_alumno
                grilla_alumno.Rows(i - 1).Cells(1).Value = o_entidades_materia._apellido_alumno
                grilla_alumno.Rows(i - 1).Cells(2).Value = o_entidades_materia._nombre_alumno
                grilla_alumno.Rows(i - 1).Cells(3).Value = o_entidades_materia._documento
                grilla_alumno.Rows(i - 1).Cells(4).Value = o_entidades_materia._desc_estado_alumno
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally

            'Libero memoria
            l_entidades_materia = Nothing
            o_negocio_materia = Nothing
        End Try
    End Sub

    Public Sub alta_alumno()
        Dim o_form_alumno_alta As form_alumno_alta
        o_form_alumno_alta = New form_alumno_alta
        o_form_alumno_alta.ShowDialog()
        o_form_alumno_alta.Close()
        o_form_alumno_alta = Nothing
        buscar_alumno()
    End Sub

    Private Sub editar_alumno()

        If item_seleccionado() Then

            Dim o_form_alumno_edicion As form_alumno_edicion
            o_form_alumno_edicion = New form_alumno_edicion

            o_form_alumno_edicion._cd_curso = grilla_alumno.SelectedCells.Item(0).Value

            o_form_alumno_edicion.ShowDialog()

            o_form_alumno_edicion.Close()

            o_form_alumno_edicion = Nothing

            buscar_alumno()

        Else
            MessageBox.Show("Debe seleccionar un alumno para editar.", "Edición de alumno", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function item_seleccionado() As Boolean
        Return grilla_alumno.SelectedCells.Count > 0
    End Function

    Private Sub consultar_alumno()

        If item_seleccionado() Then

            Dim o_form_alumno_consulta As form_alumno_consulta
            o_form_alumno_consulta = New form_alumno_consulta

            o_form_alumno_consulta._cd_alumno = grilla_alumno.SelectedCells.Item(0).Value

            o_form_alumno_consulta.ShowDialog()

            Dim ResultadoOk As Boolean = Not o_form_alumno_consulta.Cancelado

            o_form_alumno_consulta.Close()

            o_form_alumno_consulta = Nothing

            If ResultadoOk Then
                '   Buscar()
            End If

        Else
            MessageBox.Show("Debe seleccionar un alumno para ver el detalle.", "Detalle de alumno", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ver_inscripciones_a_plan()

        If item_seleccionado() Then

            Dim o_form_inscripcion_plan_search As form_inscripcion_plan_search
            o_form_inscripcion_plan_search = New form_inscripcion_plan_search

            o_form_inscripcion_plan_search._alumno = grilla_alumno.SelectedCells.Item(0).Value

            o_form_inscripcion_plan_search._cd_usuario = cd_usuario

            o_form_inscripcion_plan_search.ShowDialog()

            o_form_inscripcion_plan_search.Close()

            o_form_inscripcion_plan_search = Nothing

            ' buscar_plan()

        Else
            MessageBox.Show("Debe seleccionar un alumno para ver las inscripciones.", "Consulta de inscripción a plan de estudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ver_inscripciones_a_curso()

            If item_seleccionado() Then

                Dim o_form_inscripcion_curso_search As form_inscripcion_curso_search
                o_form_inscripcion_curso_search = New form_inscripcion_curso_search

                o_form_inscripcion_curso_search._alumno = grilla_alumno.SelectedCells.Item(0).Value

                o_form_inscripcion_curso_search._cd_usuario = cd_usuario

                o_form_inscripcion_curso_search.ShowDialog()

                o_form_inscripcion_curso_search.Close()

                o_form_inscripcion_curso_search = Nothing

            Else
                MessageBox.Show("Debe seleccionar un alumno para ver las inscripciones.", "Consulta de inscripción a curso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
       
    End Sub

    Private Sub ver_calificaciones_cursada()

        If item_seleccionado() Then

            Dim o_form_calificacion_cursada_search As form_calificacion_cursada_search
            o_form_calificacion_cursada_search = New form_calificacion_cursada_search

            o_form_calificacion_cursada_search._alumno = grilla_alumno.SelectedCells.Item(0).Value

            o_form_calificacion_cursada_search._cd_usuario = cd_usuario

            o_form_calificacion_cursada_search.ShowDialog()

            o_form_calificacion_cursada_search.Close()

            o_form_calificacion_cursada_search = Nothing

        Else
            MessageBox.Show("Debe seleccionar un alumno para ver las calificaciones de cursada.", "Consulta de calificación de cursada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      
    End Sub

    Private Sub ver_calificaciones_final()

        If item_seleccionado() Then

            Dim o_form_calificacion_final_search As form_calificacion_final_search
            o_form_calificacion_final_search = New form_calificacion_final_search

            o_form_calificacion_final_search._alumno = grilla_alumno.SelectedCells.Item(0).Value

            o_form_calificacion_final_search._cd_usuario = cd_usuario

            o_form_calificacion_final_search.ShowDialog()

            o_form_calificacion_final_search.Close()

            o_form_calificacion_final_search = Nothing

        Else
            MessageBox.Show("Debe seleccionar un alumno para ver las calificaciones de final.", "Consulta de calificación de final", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ver_analitico()

            If item_seleccionado() Then

            Dim o_form_analitico As form_analitico
            o_form_analitico = New form_analitico

            o_form_analitico._alumno = grilla_alumno.SelectedCells.Item(0).Value

            o_form_analitico.ShowDialog()

            o_form_analitico.Close()

            o_form_analitico = Nothing

        Else
            MessageBox.Show("Debe seleccionar un alumno para ver el informe analítico.", "Informes analíticos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_alumno_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Friend Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        buscar_alumno()
    End Sub

    Private Sub btn_editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        editar_alumno()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        alta_alumno()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        Componentes.limpiar(Me)
        buscar_alumno()
    End Sub

    Private Sub btn_detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        consultar_alumno()
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

    Private Sub txt_nombre_alumno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_nombre_alumno.KeyPress
        ' Carácter tecleado
        Dim c As Char = e.KeyChar

        If Not Char.IsLetter(c) Then
            Select Case c
                'Case "."c, "-"c
                ' Sin implementación
                Case Chr(8) ' Tecla retroceso
                Case Chr(32) ' Tecla barra espaciadora
                Case Else
                    e.Handled = True
                    '  MessageBox.Show("Ingrese Rut Correctamente", "Registro Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If
    End Sub

    Private Sub txt_apellido_alumno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_apellido_alumno.KeyPress

        ' Carácter tecleado
        Dim c As Char = e.KeyChar

        If Not Char.IsLetter(c) Then
            Select Case c
                'Case "."c, "-"c
                ' Sin implementación
                Case Chr(8) ' Tecla retroceso
                Case Chr(32) ' Tecla barra espaciadora
                Case Else
                    e.Handled = True
                    '  MessageBox.Show("Ingrese Rut Correctamente", "Registro Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If
    End Sub

    Private Sub btn_ir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ir.Click
        If Me.cb_opciones.SelectedIndex = 0 Then
            alta_alumno()
        End If
        If Me.cb_opciones.SelectedIndex = 1 Then
            editar_alumno()
        End If
        If Me.cb_opciones.SelectedIndex = 2 Then
            consultar_alumno()
        End If
        If Me.cb_opciones.SelectedIndex = 3 Then
            ver_inscripciones_a_plan()
        End If
        If Me.cb_opciones.SelectedIndex = 4 Then
            ver_inscripciones_a_curso()
        End If
        If Me.cb_opciones.SelectedIndex = 5 Then
            ver_calificaciones_cursada()
        End If
        If Me.cb_opciones.SelectedIndex = 6 Then
            ver_calificaciones_final()
        End If
        If Me.cb_opciones.SelectedIndex = 7 Then
            ver_analitico()
        End If
    End Sub

#End Region
End Class