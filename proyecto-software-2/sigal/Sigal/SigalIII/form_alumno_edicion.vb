Public Class form_alumno_edicion

#Region "VARIABLES DE CLASE"
    Private cancelado As Boolean = True
    Private cd_curso As Int32 = 0
    Dim Componentes As New Sigal.Componentes
#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cancelado() As Boolean
        Get
            Return cancelado
        End Get
        Set(ByVal value As Boolean)
            cancelado = value
        End Set
    End Property

    Public Property _cd_curso() As Int32
        Get
            Return cd_curso
        End Get
        Set(ByVal Value As Int32)
            cd_curso = Value
        End Set
    End Property

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        ' PROPIEDADES DEL FORM
        txt_nombre_alumno.MaxLength = 100
        txt_apellido_alumno.MaxLength = 100
        txt_nro_doc_alumno.MaxLength = 9
        txt_direccion_alumno.MaxLength = 100
        txt_piso_alumno.MaxLength = 3
        txt_departamento_alumno.MaxLength = 3
        txt_tel1_alumno.MaxLength = 15
        txt_email_alumno.MaxLength = 100

        txt_apellido_alumno.TabIndex = 0
        txt_nombre_alumno.TabIndex = 1
        cb_tipo_doc_alumno.TabIndex = 2
        txt_nro_doc_alumno.TabIndex = 3
        cb_sexo.TabIndex = 4
        dtp_fc_nacimiento.TabIndex = 5
        txt_tel1_alumno.TabIndex = 6
        cb_desc_pais.TabIndex = 7
        txt_email_alumno.TabIndex = 8
        txt_direccion_alumno.TabIndex = 9
        txt_piso_alumno.TabIndex = 10
        txt_departamento_alumno.TabIndex = 11
        cb_desc_localidad.TabIndex = 12
        txt_cd_postal.TabIndex = 13
        btn_aceptar.TabIndex = 14
        btn_cancelar.TabIndex = 15
        ' FIN PROPIEDADES DEL FORM

        Me.txt_apellido_alumno.Focus()
        Componentes.llenar_combo_pais(cb_desc_pais)
        Componentes.llenar_combo_localidad(cb_desc_localidad)


        Dim l_entidades_curso As List(Of Entidades.Alumno)
        Dim oMateriaNegocio As New Negocio.Alumno

        Try

            l_entidades_curso = oMateriaNegocio.get_one(cd_curso)

            If l_entidades_curso.Count > 0 Then
                With l_entidades_curso(0)

                    Label1.Text = ._cd_alumno
                    txt_apellido_alumno.Text = ._apellido_alumno
                    txt_nombre_alumno.Text = ._nombre_alumno
                    cb_tipo_doc_alumno.Text = ._tipo_doc_alumno
                    txt_nro_doc_alumno.Text = ._nro_doc_alumno
                    cb_sexo.Text = ._sexo
                    txt_tel1_alumno.Text = ._tel1_alumno
                    cb_desc_pais.Text = ._desc_pais
                    txt_email_alumno.Text = ._email_alumno
                    txt_direccion_alumno.Text = ._direccion_alumno
                    txt_departamento_alumno.Text = ._departamento_alumno
                    txt_piso_alumno.Text = ._piso_alumno
                    txt_cd_postal.Text = ._cd_postal
                    cb_desc_localidad.Text = ._desc_localidad
                    dtp_fc_nacimiento.Value = ._fc_nacimiento

                    lbl_titulo_form.Text = "Edición de " + ._apellido_alumno + ", " + ._nombre_alumno
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            oMateriaNegocio = Nothing
            l_entidades_curso = Nothing
        End Try

    End Sub

    Private Sub aceptar_operacion()

        Dim o_entidades_alumno As New Entidades.Alumno
        Dim o_neogcio_alumno As New Negocio.Alumno

        Dim o_entidad_pais As New Entidades.Pais

        Dim o_entidad_localidad As New Entidades.Localidad

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma la modificación de los datos del alumno?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If confirmacion = 1 Then

                o_entidades_alumno._cd_alumno = Label1.Text
                o_entidades_alumno._nombre_alumno = txt_nombre_alumno.Text
                o_entidades_alumno._apellido_alumno = txt_apellido_alumno.Text
                o_entidades_alumno._nro_doc_alumno = txt_nro_doc_alumno.Text
                o_entidades_alumno._tel1_alumno = txt_tel1_alumno.Text
                o_entidades_alumno._email_alumno = txt_email_alumno.Text
                o_entidades_alumno._direccion_alumno = txt_direccion_alumno.Text
                o_entidades_alumno._piso_alumno = txt_piso_alumno.Text
                o_entidades_alumno._departamento_alumno = txt_departamento_alumno.Text
                o_entidades_alumno._cd_postal = txt_cd_postal.Text

                o_entidades_alumno._tipo_doc_alumno = cb_tipo_doc_alumno.SelectedItem
                o_entidades_alumno._fc_nacimiento = dtp_fc_nacimiento.Value
                o_entidades_alumno._sexo = cb_sexo.SelectedItem

                o_entidad_pais = cb_desc_pais.SelectedItem
                o_entidades_alumno.cd_pais = o_entidad_pais._cd_pais

                o_entidad_localidad = cb_desc_localidad.SelectedItem
                o_entidades_alumno.cd_localidad = o_entidad_localidad._cd_localidad

                o_neogcio_alumno.update(o_entidades_alumno)

                cancelado = False
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            o_entidades_alumno = Nothing
            o_neogcio_alumno = Nothing
        End Try
    End Sub
    Private Sub validar()
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_plan_edicion_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_operacion()
    End Sub


    Private Sub txt_nombre_alumno_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nombre_alumno.Validating
        If Me.txt_nombre_alumno.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_nombre_alumno, "Debe ingresar un nombre válido")
        Else
            ErrorProvider.SetError(Me.txt_nombre_alumno, "")
        End If
    End Sub

    Private Sub txt_apellido_alumno_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_apellido_alumno.Validating
        If Me.txt_apellido_alumno.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_apellido_alumno, "Debe ingresar un apellido válido")
        Else
            ErrorProvider.SetError(Me.txt_apellido_alumno, "")
        End If
    End Sub

    Private Sub cb_tipo_doc_alumno_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_tipo_doc_alumno.Validating
        If Me.cb_tipo_doc_alumno.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_tipo_doc_alumno, "Debe ingresar un tipo de documento válido")
        Else
            ErrorProvider.SetError(Me.cb_tipo_doc_alumno, "")
        End If
    End Sub

    Private Sub txt_nro_doc_alumno_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nro_doc_alumno.Validating
        If Me.txt_nro_doc_alumno.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_nro_doc_alumno, "Debe ingresar un número válido")
        Else
            ErrorProvider.SetError(Me.txt_nro_doc_alumno, "")
        End If
    End Sub

    Private Sub cb_sexo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_sexo.Validating
        If Me.cb_sexo.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_sexo, "Debe ingresar un sexo válido")
        Else
            ErrorProvider.SetError(Me.cb_sexo, "")
        End If
    End Sub

    Private Sub cb_desc_pais_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_desc_pais.Validating
        If Me.cb_desc_pais.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_desc_pais, "Debe ingresar un país válido")
        Else
            ErrorProvider.SetError(Me.cb_desc_pais, "")
        End If
    End Sub

    Private Sub txt_direccion_alumno_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_direccion_alumno.Validating
        If Me.txt_direccion_alumno.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_direccion_alumno, "Debe ingresar una dirección válida")
        Else
            ErrorProvider.SetError(Me.txt_direccion_alumno, "")
        End If
    End Sub

    Private Sub txt_cd_postal_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Me.txt_cd_postal.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_cd_postal, "Debe ingresar un código postal válido")
        Else
            ErrorProvider.SetError(Me.txt_cd_postal, "")
        End If
    End Sub

    Private Sub cb_desc_localidad_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cb_desc_localidad.Validating
        If Me.cb_desc_localidad.Text.Trim = "" Then
            ErrorProvider.SetError(Me.cb_desc_localidad, "Debe ingresar una localidad válida")
        Else
            ErrorProvider.SetError(Me.cb_desc_localidad, "")
        End If
    End Sub

    Private Sub txt_tel1_alumno_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_tel1_alumno.Validating
        If Me.txt_tel1_alumno.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_tel1_alumno, "Debe ingresar un número válido")
        Else
            ErrorProvider.SetError(Me.txt_tel1_alumno, "")
        End If
    End Sub

    Private Sub txt_email_alumno_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_email_alumno.Validating
        If Me.txt_email_alumno.Text.Trim = "" Then
            ErrorProvider.SetError(Me.txt_email_alumno, "Debe ingresar un email válido")
        Else
            ErrorProvider.SetError(Me.txt_email_alumno, "")
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

    Private Sub txt_nro_doc_alumno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_nro_doc_alumno.KeyPress
        ' Carácter tecleado
        Dim c As Char = e.KeyChar

        If Not Char.IsDigit(c) Then
            Select Case c
                'Case "."c, "-"c
                ' Sin implementación
                Case Chr(8) ' Tecla retroceso
                Case Else
                    e.Handled = True
                    '  MessageBox.Show("Ingrese Rut Correctamente", "Registro Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If
    End Sub

    Private Sub txt_piso_alumno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_piso_alumno.KeyPress
        ' Carácter tecleado
        Dim c As Char = e.KeyChar
        If Not Char.IsLetter(c) Then
            If Not Char.IsDigit(c) Then
                Select Case c
                    'Case "."c, "-"c
                    ' Sin implementación
                    Case Chr(8) ' Tecla retroceso
                    Case Else
                        e.Handled = True
                        '  MessageBox.Show("Ingrese Rut Correctamente", "Registro Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            End If
        End If
    End Sub

    Private Sub txt_departamento_alumno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_departamento_alumno.KeyPress
        ' Carácter tecleado
        Dim c As Char = e.KeyChar
        If Not Char.IsLetter(c) Then
            If Not Char.IsDigit(c) Then
                Select Case c
                    'Case "."c, "-"c
                    ' Sin implementación
                    Case Chr(8) ' Tecla retroceso
                    Case Else
                        e.Handled = True
                        '  MessageBox.Show("Ingrese Rut Correctamente", "Registro Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            End If
        End If
    End Sub

    Private Sub txt_tel1_alumno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_tel1_alumno.KeyPress
        ' Carácter tecleado
        Dim c As Char = e.KeyChar
        If Not Char.IsDigit(c) Then
            Select Case c
                'Case "-"c
                ' Sin implementación
                Case Chr(8) ' Tecla retroceso
                Case Else
                    e.Handled = True
                    '  MessageBox.Show("Ingrese Rut Correctamente", "Registro Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End If
    End Sub

#End Region

End Class