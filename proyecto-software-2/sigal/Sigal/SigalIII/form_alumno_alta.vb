Public Class form_alumno_alta

#Region "VARIABLES DE CLASE"
    Private cancelado As Boolean = True
    Dim Componentes As New Sigal.Componentes
    Private cd_alumno As String = ""
    Dim o_form_principal As New form_principal
#End Region

#Region "PROPIEDADES DE CONTROL"

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

        cb_tipo_doc_alumno.SelectedItem = cb_tipo_doc_alumno.Items.Item(0)
        cb_sexo.SelectedItem = cb_sexo.Items.Item(1)
        cb_desc_pais.SelectedItem = cb_desc_pais.Items.Item(0)
        cb_desc_localidad.SelectedItem = cb_desc_localidad.Items.Item(4)
    End Sub

    Private Sub aceptar_operacion()

        Dim o_negocio_materia As New Negocio.Alumno
        Dim o_entidad_materia As New Entidades.Alumno

        Dim o_entidad_pais As New Entidades.Pais

        Dim o_entidad_localidad As New Entidades.Localidad

        Try
            validar()

            Dim confirmacion As String
            confirmacion = MessageBox.Show("¿Confirma el alta del alumno """ + Me.txt_nombre_alumno.Text + " " + Me.txt_apellido_alumno.Text + """?", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If confirmacion = 1 Then
                o_entidad_materia._nombre_alumno = txt_nombre_alumno.Text
                o_entidad_materia._apellido_alumno = txt_apellido_alumno.Text
                o_entidad_materia._tipo_doc_alumno = cb_tipo_doc_alumno.SelectedItem
                o_entidad_materia._nro_doc_alumno = txt_nro_doc_alumno.Text
                o_entidad_materia._fc_nacimiento = dtp_fc_nacimiento.Value
                o_entidad_materia._sexo = cb_sexo.SelectedItem
                'o_entidad_materia._desc_pais = cb_desc_pais.SelectedItem
                o_entidad_materia._direccion_alumno = txt_direccion_alumno.Text
                o_entidad_materia._piso_alumno = txt_piso_alumno.Text.ToUpper
                o_entidad_materia._departamento_alumno = txt_departamento_alumno.Text.ToUpper
                o_entidad_materia._cd_postal = txt_cd_postal.Text.ToUpper
                ' o_entidad_materia._desc_localidad = cb_desc_localidad.SelectedItem
                o_entidad_materia._tel1_alumno = txt_tel1_alumno.Text
                o_entidad_materia._email_alumno = txt_email_alumno.Text

                o_entidad_pais = cb_desc_pais.SelectedItem
                o_entidad_materia.cd_pais = o_entidad_pais._cd_pais

                o_entidad_localidad = cb_desc_localidad.SelectedItem
                o_entidad_materia.cd_localidad = o_entidad_localidad._cd_localidad

                'Agrego una materia
                o_negocio_materia.add(o_entidad_materia)

                'Indico que todo salio bien y cierro el formulario
                cancelado = False
                'Me.Hide()
                Me.Close()
            End If

        Catch ex As Exception
            'Capturo excepciones genéricas.
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            'Libero los objetos.
            o_entidad_materia = Nothing
            o_negocio_materia = Nothing
        End Try
    End Sub

    Private Sub validar()

        If txt_apellido_alumno.Text.Trim = "" Then
            txt_apellido_alumno.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_nombre_alumno.Text.Trim = "" Then
            txt_nombre_alumno.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_nro_doc_alumno.Text.Trim = "" Then
            txt_nro_doc_alumno.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        Componentes.validar_edad(dtp_fc_nacimiento)

        If txt_direccion_alumno.Text.Trim = "" Then
            txt_direccion_alumno.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_cd_postal.Text.Trim = "" Then
            txt_cd_postal.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_tel1_alumno.Text.Trim = "" Then
            txt_tel1_alumno.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        If txt_email_alumno.Text.Trim = "" Then
            txt_email_alumno.Focus()
            Dim o As New Sigal.Componentes
            o.mostrar_mensaje_datos_obligatorios()
        End If

        Dim res_email As New Boolean
        res_email = Sigal.Componentes.validar_email(txt_email_alumno.Text)
        If res_email = False Then
            Throw New ArgumentException("La dirección de email ingresada es invalida.")
        End If

    End Sub

#End Region

#Region "EVENTOS"

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        aceptar_operacion()
    End Sub

    Private Sub form_alumno_alta_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
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

    Private Sub txt_cd_postal_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_cd_postal.Validating
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

    Private Sub txt_piso_alumno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_piso_alumno.KeyPress, txt_cd_postal.KeyPress
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

    Private Sub txt_cd_postal_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_cd_postal.KeyPress
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