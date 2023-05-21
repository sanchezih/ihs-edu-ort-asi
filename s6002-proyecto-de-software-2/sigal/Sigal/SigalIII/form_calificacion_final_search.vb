Public Class form_calificacion_final_search

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String = ""
    Private alumno As Int32 = 0
    Private curso As Int32 = 0
    Dim componentes As New Sigal.Componentes
    Dim i As Int32
    Dim o_entidades_plan As New Entidades.ActaFinal
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
        Me.txt_cd_curso.MaxLength = 9
        Me.txt_cd_alumno.MaxLength = 9
        Me.txt_nombre_alumno.MaxLength = 100
        Me.txt_apellido_alumno.MaxLength = 100

        grilla_calificacion_final.RowsDefaultCellStyle.BackColor = Color.White
        grilla_calificacion_final.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        txt_cd_alumno.TabIndex = 0
        txt_apellido_alumno.TabIndex = 1
        txt_nombre_alumno.TabIndex = 2
        txt_cd_curso.TabIndex = 3
        btn_buscar.TabIndex = 4
        cb_opciones.TabIndex = 5
        btn_ir.TabIndex = 6
        btn_limpiar.TabIndex = 7
        btn_cancelar.TabIndex = 8

        ' FIN PROPIEDADES DEL FORM

        cb_opciones.SelectedIndex = 0
        txt_cd_alumno.Focus()

        If alumno <> 0 Then
            txt_cd_alumno.Text = alumno
            If curso <> 0 Then
                txt_cd_curso.Text = curso
                buscar_calificacionFinal()
            End If
        Else
            buscar_calificacionFinal()
        End If

    End Sub

    Private Sub buscar_calificacionFinal()

        Dim l_entidades_calificacionCursada As New List(Of Entidades.ActaFinal)
        Dim o_negocio_calificacionCursada As New Negocio.ActaFinal

        Dim cd_curso As Int32
        Dim cd_alumno As Int32
        Dim nombre_alumno As String
        Dim apellido_alumno As String

        If Me.txt_cd_alumno.Text.Trim = "" Then
            cd_alumno = 0
        Else
            cd_alumno = CInt(txt_cd_alumno.Text)
        End If

        If Me.txt_cd_curso.Text.Trim = "" Then
            cd_curso = 0
        Else
            cd_curso = CInt(txt_cd_curso.Text)
        End If

        nombre_alumno = Me.txt_nombre_alumno.Text
        apellido_alumno = Me.txt_apellido_alumno.Text

        Try
            l_entidades_calificacionCursada = o_negocio_calificacionCursada.get_all_by_filtros(cd_curso, cd_alumno, nombre_alumno, apellido_alumno)
            grilla_calificacion_final.Rows.Clear()

            For i = 1 To l_entidades_calificacionCursada.ToArray.Length
                o_entidades_plan = l_entidades_calificacionCursada.Item(i - 1)

                grilla_calificacion_final.Rows.Add()


                grilla_calificacion_final.Rows(i - 1).Cells(0).Value = o_entidades_plan._cd_plan_estudio
                grilla_calificacion_final.Rows(i - 1).Cells(1).Value = o_entidades_plan._cd_curso
                grilla_calificacion_final.Rows(i - 1).Cells(2).Value = o_entidades_plan._cd_alumno
                grilla_calificacion_final.Rows(i - 1).Cells(3).Value = o_entidades_plan._an
                grilla_calificacion_final.Rows(i - 1).Cells(4).Value = o_entidades_plan._calificacion
                grilla_calificacion_final.Rows(i - 1).Cells(5).Value = o_entidades_plan._fc_alta
                grilla_calificacion_final.Rows(i - 1).Cells(6).Value = o_entidades_plan._fc_ultima_modificacion

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally

            'Libero memoria
            l_entidades_calificacionCursada = Nothing
            o_negocio_calificacionCursada = Nothing
        End Try
    End Sub

    Public Sub alta_calificacionFinal()

        Dim o_form_calificacion_final_alta As form_calificacion_final_alta
        o_form_calificacion_final_alta = New form_calificacion_final_alta
        o_form_calificacion_final_alta.ShowDialog()
        o_form_calificacion_final_alta.Close()
        o_form_calificacion_final_alta = Nothing
        buscar_calificacionFinal()

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_calificacion_final_search_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        buscar_calificacionFinal()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        componentes.limpiar(Me)
        buscar_calificacionFinal()
    End Sub

    Private Sub btn_ir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ir.Click
        If Me.cb_opciones.SelectedIndex = 0 Then
            alta_calificacionFinal()
        End If
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

#End Region



    Private Sub cb_opciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_opciones.SelectedIndexChanged

    End Sub
End Class