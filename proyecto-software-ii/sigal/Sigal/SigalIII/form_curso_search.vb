Public Class form_curso_search

#Region "VARIABLES DE CLASE"

    Dim i As Int32
    Dim Componentes As New Sigal.Componentes
    Dim o_entidades_curso As New Entidades.Curso
    Dim o_entidades_materia As New Entidades.Materia
    Dim o_entidades_profesor As New Entidades.Profesor

#End Region

#Region "PROPIEDADES DE CONTROL"

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        ' PROPIEDADES DEL FORM
        txt_anio.MaxLength = 4
        txt_cd_curso.MaxLength = 9

        grilla_curso.RowsDefaultCellStyle.BackColor = Color.White
        grilla_curso.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        txt_cd_curso.TabIndex = 0
        cb_materias.TabIndex = 1
        txt_anio.TabIndex = 2
        cb_profesores.TabIndex = 3
        check_estado.TabIndex = 4
        btn_buscar.TabIndex = 5
        btn_ir.TabIndex = 6
        btn_limpiar.TabIndex = 7
        btn_cancelar.TabIndex = 8

        cb_opciones.SelectedIndex = 0
        ' FIN PROPIEDADES DEL FORM

        txt_cd_curso.Focus()
        check_estado.CheckState = CheckState.Checked

        Componentes.llenar_combo_con_materias_que_pertenecen_a_un_curso(cb_materias)
        Componentes.llenar_combo_con_profesores_que_dan_algun_curso(cb_profesores)
        buscar_curso()
    End Sub

    Public Sub buscar_curso()

        Dim l_entidades_materia As New List(Of Entidades.Curso)
        Dim o_negocio_curso As New Negocio.Curso
        Dim estado As Int32
        Dim cd_curso As Int32
        Dim anio As Int32
        Dim materia As String
        Dim profesor As String

        If Me.txt_cd_curso.Text.Trim = "" Then
            cd_curso = 0
        Else
            cd_curso = CInt(txt_cd_curso.Text)
        End If

        If Me.txt_anio.Text.Trim = "" Then
            anio = 0
        Else
            anio = CInt(txt_anio.Text)
        End If

        If check_estado.Checked Then
            estado = 1
        Else
            estado = 0
        End If

        If cb_materias.Items.Count > 0 Then
            o_entidades_materia = cb_materias.SelectedItem
            If Not o_entidades_materia Is Nothing Then
                materia = o_entidades_materia._cd_materia
                If materia Is Nothing Then
                    materia = ""
                End If
            Else
                materia = ""
            End If
        Else
            materia = ""
        End If

        If cb_profesores.Items.Count > 0 Then
            o_entidades_profesor = cb_profesores.SelectedItem
            If Not o_entidades_profesor Is Nothing Then
                profesor = o_entidades_profesor._cd_profesor
                If profesor Is Nothing Then
                    profesor = 0
                End If
            Else
                profesor = 0
            End If
        Else
            profesor = 0
        End If

        Try
            l_entidades_materia = o_negocio_curso.get_all_by_filtros(cd_curso, estado, anio, materia, profesor)
            grilla_curso.Rows.Clear()

            For i = 1 To l_entidades_materia.ToArray.Length
                o_entidades_curso = l_entidades_materia.Item(i - 1)

                grilla_curso.Rows.Add()
                grilla_curso.Rows(i - 1).Cells(0).Value = o_entidades_curso._cd_curso

                grilla_curso.Rows(i - 1).Cells(1).Value = o_entidades_curso._cd_plan_estudio
                grilla_curso.Rows(i - 1).Cells(2).Value = o_entidades_curso._titulo
                grilla_curso.Rows(i - 1).Cells(3).Value = o_entidades_curso._nombre_profesor
                grilla_curso.Rows(i - 1).Cells(4).Value = o_entidades_curso._cd_materia
                grilla_curso.Rows(i - 1).Cells(5).Value = o_entidades_curso._nombre_materia
                grilla_curso.Rows(i - 1).Cells(6).Value = o_entidades_curso._anio
                grilla_curso.Rows(i - 1).Cells(7).Value = o_entidades_curso._fc_baja
    

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'Libero memoria
            l_entidades_materia = Nothing
            o_negocio_curso = Nothing
        End Try
    End Sub

    Public Sub alta_curso()
        Dim o_form_curso_alta As form_curso_alta
        o_form_curso_alta = New form_curso_alta
        o_form_curso_alta.ShowDialog()
        o_form_curso_alta.Close()
        o_form_curso_alta = Nothing
        iniciar_formulario()
    End Sub

    Private Sub eliminar_curso()

        If item_seleccionado() Then

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma la eliminación del curso?", "Eliminación de curso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then
                If Not curso_dado_de_baja() Then
                    If curso_apto_edicion() Then
                        Dim o_negocio_curso As New Negocio.Curso

                        Dim cd_curso As Int32

                        Try
                            cd_curso = grilla_curso.SelectedCells.Item(0).Value

                            o_negocio_curso.delete(cd_curso)

                            MessageBox.Show("El curso se eliminó correctamente.", "Eliminación de curso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            iniciar_formulario()

                        Catch ex As Exception

                            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            o_negocio_curso = Nothing
                        End Try

                    Else
                        MessageBox.Show("El curso no se puede eliminar por que ya hay alumnos inscriptos a él.", "Edición de curso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("El curso no se puede eliminar por que se encuentra dado de baja.", "Edición de curso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Debe seleccionar un curso para eliminar.", "Eliminación de curso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function item_seleccionado() As Boolean
        Return grilla_curso.SelectedCells.Count > 0
    End Function

    Private Function curso_apto_edicion() As Boolean

        Dim o_negocio_inscripcionCurso As New Negocio.InscripcionCurso
        Dim curso As New Entidades.Curso
        Dim cantidad As Integer

        curso._cd_curso = grilla_curso.SelectedCells.Item(0).Value

        cantidad = o_negocio_inscripcionCurso.consulta_cantidad_inscriptos(curso._cd_curso)

        Return cantidad = 0

    End Function

    Private Function curso_dado_de_baja() As Boolean

        Dim o_negocio_inscripcionCurso As New Negocio.InscripcionCurso
        Dim curso As New Entidades.Curso
        curso._fc_baja = grilla_curso.SelectedCells.Item(7).Value()
        Return curso._fc_baja.HasValue()

    End Function

    Private Sub consultar_curso()

        If item_seleccionado() Then

            Dim o_form_curso_consulta As form_curso_consulta
            o_form_curso_consulta = New form_curso_consulta

            o_form_curso_consulta._cd_curso = grilla_curso.SelectedCells.Item(0).Value

            o_form_curso_consulta.ShowDialog()

            Dim ResultadoOk As Boolean = Not o_form_curso_consulta.Cancelado

            o_form_curso_consulta.Close()

            o_form_curso_consulta = Nothing

            If ResultadoOk Then
                '   Buscar()
            End If

        Else
            MessageBox.Show("Debe seleccionar un curso para ver el detalle.", "Detalle de curso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ver_inscripciones_a_curso()

        If item_seleccionado() Then

            Dim o_form_calificacion_cursada_search As form_inscripcion_curso_search
            o_form_calificacion_cursada_search = New form_inscripcion_curso_search

            o_form_calificacion_cursada_search._curso = grilla_curso.SelectedCells.Item(0).Value

            o_form_calificacion_cursada_search.ShowDialog()

            o_form_calificacion_cursada_search.Close()

            o_form_calificacion_cursada_search = Nothing

        Else
            MessageBox.Show("Debe seleccionar un curso para ver las inscripciones.", "Consulta de inscripción a curso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_curso_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Friend Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        buscar_curso()
    End Sub

    Private Sub btn_alta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        alta_curso()
    End Sub

    Private Sub check_estado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_estado.CheckedChanged
        buscar_curso()
    End Sub

    Private Sub cb_materias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_materias.SelectedIndexChanged
        buscar_curso()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        Componentes.limpiar(Me)
        buscar_curso()
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

    Private Sub txt_anio_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_anio.KeyPress
        Dim c As Char = e.KeyChar
        If Not Char.IsDigit(c) Then
            Select Case c
                Case Chr(8) ' Tecla retroceso
                Case Else
                    e.Handled = True
            End Select
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        consultar_curso()
    End Sub

    Private Sub cb_profesores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_profesores.SelectedIndexChanged
        buscar_curso()
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        eliminar_curso()
    End Sub

    Private Sub btn_ir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ir.Click
        If Me.cb_opciones.SelectedIndex = 0 Then
            alta_curso()
        End If
        If Me.cb_opciones.SelectedIndex = 1 Then
            eliminar_curso()
        End If
        If Me.cb_opciones.SelectedIndex = 2 Then
            consultar_curso()
        End If
        If Me.cb_opciones.SelectedIndex = 3 Then
            ver_inscripciones_a_curso()
        End If
    End Sub

#End Region

    Private Sub cb_opciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_opciones.SelectedIndexChanged

    End Sub
End Class