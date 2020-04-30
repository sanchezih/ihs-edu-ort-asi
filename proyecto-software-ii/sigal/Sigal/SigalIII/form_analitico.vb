Public Class form_analitico

#Region "VARIABLES DE CLASE"
    Private alumno As Int32 = 0
    Dim i As Int32
    Dim o_entidades_materia As New Entidades.Analitico
    Dim componentes As New Sigal.Componentes
#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _alumno() As Int32
        Get
            Return alumno
        End Get
        Set(ByVal Value As Int32)
            alumno = Value
        End Set
    End Property
#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        ' PROPIEDADES DEL FORM
        Me.txt_cd_alumno.MaxLength = 9
        Me.txt_nombre_alumno.MaxLength = 100
        Me.txt_apellido_alumno.MaxLength = 100
        grilla_analitico.RowsDefaultCellStyle.BackColor = Color.White
        grilla_analitico.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue

        txt_cd_alumno.TabIndex = 0
        txt_nombre_alumno.TabIndex = 1
        txt_apellido_alumno.TabIndex = 2
        btn_buscar.TabIndex = 3
        btn_cerrar.TabIndex = 4

        ' FIN PROPIEDADES DEL FORM

        txt_cd_alumno.Focus()

        If alumno <> 0 Then
            txt_cd_alumno.Text = alumno
            buscar_analitico()
        Else
            buscar_analitico()
        End If
    End Sub

    Public Sub buscar_analitico()

        Dim l_entidades_materia As New List(Of Entidades.Analitico)
        Dim o_negocio_materia As New Negocio.Analitico

        Dim l_entidades_alumno As New List(Of Entidades.Alumno)
        Dim o_negocio_alumno As New Negocio.Alumno

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
            grilla_analitico.Rows.Clear()

            For i = 1 To l_entidades_materia.ToArray.Length
                o_entidades_materia = l_entidades_materia.Item(i - 1)

                grilla_analitico.Rows.Add()
                grilla_analitico.Rows(i - 1).Cells(0).Value = o_entidades_materia._cd_alumno
                grilla_analitico.Rows(i - 1).Cells(1).Value = o_entidades_materia._an
                grilla_analitico.Rows(i - 1).Cells(2).Value = o_entidades_materia._cd_materia
                grilla_analitico.Rows(i - 1).Cells(3).Value = o_entidades_materia._cd_curso
                grilla_analitico.Rows(i - 1).Cells(4).Value = o_entidades_materia._desc_estado_materia
                grilla_analitico.Rows(i - 1).Cells(5).Value = o_entidades_materia._fc_ultima_modificacion
            Next

            l_entidades_alumno = o_negocio_alumno.get_one(cd_alumno)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            l_entidades_materia = Nothing
            o_negocio_materia = Nothing
        End Try
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_analitico_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        buscar_analitico()
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click
        componentes.limpiar(Me)
        buscar_analitico()
    End Sub

    Private Sub txt_cd_alumno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_cd_alumno.KeyPress

        ' Carácter tecleado        '
        Dim c As Char = e.KeyChar

        If Not Char.IsDigit(c) Then
            Select Case c
                Case Chr(8)
                Case Else
                    e.Handled = True
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


End Class