<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_alumno_edicion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lbl_titulo_form = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_nombre_alumno = New System.Windows.Forms.Label
        Me.txt_nombre_alumno = New System.Windows.Forms.TextBox
        Me.lbl_apellido_alumno = New System.Windows.Forms.Label
        Me.txt_apellido_alumno = New System.Windows.Forms.TextBox
        Me.txt_email_alumno = New System.Windows.Forms.TextBox
        Me.cb_desc_pais = New System.Windows.Forms.ComboBox
        Me.dtp_fc_nacimiento = New System.Windows.Forms.DateTimePicker
        Me.lbl_tel1_alumno = New System.Windows.Forms.Label
        Me.lbl_email_alumno = New System.Windows.Forms.Label
        Me.lbl_tipo_doc_alumno = New System.Windows.Forms.Label
        Me.cb_tipo_doc_alumno = New System.Windows.Forms.ComboBox
        Me.txt_tel1_alumno = New System.Windows.Forms.TextBox
        Me.lbl_nro_doc_alumno = New System.Windows.Forms.Label
        Me.txt_nro_doc_alumno = New System.Windows.Forms.TextBox
        Me.lbl_fc_nacimiento = New System.Windows.Forms.Label
        Me.lbl_sexo = New System.Windows.Forms.Label
        Me.lbl_desc_pais = New System.Windows.Forms.Label
        Me.cb_sexo = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_desc_localidad = New System.Windows.Forms.Label
        Me.lbl_departamento_alumno = New System.Windows.Forms.Label
        Me.lbl_cd_postal = New System.Windows.Forms.Label
        Me.lbl_direccion_alumno = New System.Windows.Forms.Label
        Me.cb_desc_localidad = New System.Windows.Forms.ComboBox
        Me.lbl_piso_alumno = New System.Windows.Forms.Label
        Me.txt_departamento_alumno = New System.Windows.Forms.TextBox
        Me.txt_direccion_alumno = New System.Windows.Forms.TextBox
        Me.txt_piso_alumno = New System.Windows.Forms.TextBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.txt_cd_postal = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo_form
        '
        Me.lbl_titulo_form.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_titulo_form.BackColor = System.Drawing.Color.SandyBrown
        Me.lbl_titulo_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_titulo_form.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo_form.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_titulo_form.Location = New System.Drawing.Point(12, 9)
        Me.lbl_titulo_form.Name = "lbl_titulo_form"
        Me.lbl_titulo_form.Size = New System.Drawing.Size(471, 22)
        Me.lbl_titulo_form.TabIndex = 38
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lbl_nombre_alumno)
        Me.GroupBox2.Controls.Add(Me.txt_nombre_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_apellido_alumno)
        Me.GroupBox2.Controls.Add(Me.txt_apellido_alumno)
        Me.GroupBox2.Controls.Add(Me.txt_email_alumno)
        Me.GroupBox2.Controls.Add(Me.cb_desc_pais)
        Me.GroupBox2.Controls.Add(Me.dtp_fc_nacimiento)
        Me.GroupBox2.Controls.Add(Me.lbl_tel1_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_email_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_tipo_doc_alumno)
        Me.GroupBox2.Controls.Add(Me.cb_tipo_doc_alumno)
        Me.GroupBox2.Controls.Add(Me.txt_tel1_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_nro_doc_alumno)
        Me.GroupBox2.Controls.Add(Me.txt_nro_doc_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_fc_nacimiento)
        Me.GroupBox2.Controls.Add(Me.lbl_sexo)
        Me.GroupBox2.Controls.Add(Me.lbl_desc_pais)
        Me.GroupBox2.Controls.Add(Me.cb_sexo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 264)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos personales del alumno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(323, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'lbl_nombre_alumno
        '
        Me.lbl_nombre_alumno.AutoSize = True
        Me.lbl_nombre_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_alumno.Location = New System.Drawing.Point(224, 24)
        Me.lbl_nombre_alumno.Name = "lbl_nombre_alumno"
        Me.lbl_nombre_alumno.Size = New System.Drawing.Size(54, 13)
        Me.lbl_nombre_alumno.TabIndex = 2
        Me.lbl_nombre_alumno.Text = "Nombre:"
        '
        'txt_nombre_alumno
        '
        Me.HelpProvider1.SetHelpString(Me.txt_nombre_alumno, "Ingrese aquí el nombre del alumno")
        Me.txt_nombre_alumno.Location = New System.Drawing.Point(224, 40)
        Me.txt_nombre_alumno.MaxLength = 100
        Me.txt_nombre_alumno.Name = "txt_nombre_alumno"
        Me.HelpProvider1.SetShowHelp(Me.txt_nombre_alumno, True)
        Me.txt_nombre_alumno.Size = New System.Drawing.Size(184, 20)
        Me.txt_nombre_alumno.TabIndex = 1
        '
        'lbl_apellido_alumno
        '
        Me.lbl_apellido_alumno.AutoSize = True
        Me.lbl_apellido_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido_alumno.Location = New System.Drawing.Point(8, 24)
        Me.lbl_apellido_alumno.Name = "lbl_apellido_alumno"
        Me.lbl_apellido_alumno.Size = New System.Drawing.Size(56, 13)
        Me.lbl_apellido_alumno.TabIndex = 3
        Me.lbl_apellido_alumno.Text = "Apellido:"
        '
        'txt_apellido_alumno
        '
        Me.HelpProvider1.SetHelpString(Me.txt_apellido_alumno, "Ingrese aquí el apellido del alumno")
        Me.txt_apellido_alumno.Location = New System.Drawing.Point(8, 40)
        Me.txt_apellido_alumno.MaxLength = 100
        Me.txt_apellido_alumno.Name = "txt_apellido_alumno"
        Me.HelpProvider1.SetShowHelp(Me.txt_apellido_alumno, True)
        Me.txt_apellido_alumno.Size = New System.Drawing.Size(184, 20)
        Me.txt_apellido_alumno.TabIndex = 0
        '
        'txt_email_alumno
        '
        Me.HelpProvider1.SetHelpString(Me.txt_email_alumno, "Ingrese aquí la dirección de email del alumno")
        Me.txt_email_alumno.Location = New System.Drawing.Point(8, 232)
        Me.txt_email_alumno.MaxLength = 100
        Me.txt_email_alumno.Name = "txt_email_alumno"
        Me.HelpProvider1.SetShowHelp(Me.txt_email_alumno, True)
        Me.txt_email_alumno.Size = New System.Drawing.Size(184, 20)
        Me.txt_email_alumno.TabIndex = 8
        '
        'cb_desc_pais
        '
        Me.cb_desc_pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_desc_pais.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_desc_pais, "Seleccione aquí el país de nacimiento del alumno")
        Me.cb_desc_pais.Location = New System.Drawing.Point(224, 184)
        Me.cb_desc_pais.Name = "cb_desc_pais"
        Me.HelpProvider1.SetShowHelp(Me.cb_desc_pais, True)
        Me.cb_desc_pais.Size = New System.Drawing.Size(184, 21)
        Me.cb_desc_pais.TabIndex = 7
        '
        'dtp_fc_nacimiento
        '
        Me.HelpProvider1.SetHelpString(Me.dtp_fc_nacimiento, "Seleccione aquí la fecha de nacimiento del alumno")
        Me.dtp_fc_nacimiento.Location = New System.Drawing.Point(224, 136)
        Me.dtp_fc_nacimiento.Name = "dtp_fc_nacimiento"
        Me.HelpProvider1.SetShowHelp(Me.dtp_fc_nacimiento, True)
        Me.dtp_fc_nacimiento.Size = New System.Drawing.Size(184, 20)
        Me.dtp_fc_nacimiento.TabIndex = 5
        '
        'lbl_tel1_alumno
        '
        Me.lbl_tel1_alumno.AutoSize = True
        Me.lbl_tel1_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tel1_alumno.Location = New System.Drawing.Point(8, 168)
        Me.lbl_tel1_alumno.Name = "lbl_tel1_alumno"
        Me.lbl_tel1_alumno.Size = New System.Drawing.Size(61, 13)
        Me.lbl_tel1_alumno.TabIndex = 6
        Me.lbl_tel1_alumno.Text = "Teléfono:"
        '
        'lbl_email_alumno
        '
        Me.lbl_email_alumno.AutoSize = True
        Me.lbl_email_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email_alumno.Location = New System.Drawing.Point(8, 216)
        Me.lbl_email_alumno.Name = "lbl_email_alumno"
        Me.lbl_email_alumno.Size = New System.Drawing.Size(41, 13)
        Me.lbl_email_alumno.TabIndex = 7
        Me.lbl_email_alumno.Text = "Email:"
        '
        'lbl_tipo_doc_alumno
        '
        Me.lbl_tipo_doc_alumno.AutoSize = True
        Me.lbl_tipo_doc_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_doc_alumno.Location = New System.Drawing.Point(8, 72)
        Me.lbl_tipo_doc_alumno.Name = "lbl_tipo_doc_alumno"
        Me.lbl_tipo_doc_alumno.Size = New System.Drawing.Size(120, 13)
        Me.lbl_tipo_doc_alumno.TabIndex = 4
        Me.lbl_tipo_doc_alumno.Text = "Tipo de documento:"
        '
        'cb_tipo_doc_alumno
        '
        Me.cb_tipo_doc_alumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo_doc_alumno.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_tipo_doc_alumno, "Seleccione aquí el tipo de documento del alumno")
        Me.cb_tipo_doc_alumno.Items.AddRange(New Object() {"DNI", "CI"})
        Me.cb_tipo_doc_alumno.Location = New System.Drawing.Point(8, 88)
        Me.cb_tipo_doc_alumno.Name = "cb_tipo_doc_alumno"
        Me.HelpProvider1.SetShowHelp(Me.cb_tipo_doc_alumno, True)
        Me.cb_tipo_doc_alumno.Size = New System.Drawing.Size(92, 21)
        Me.cb_tipo_doc_alumno.TabIndex = 2
        '
        'txt_tel1_alumno
        '
        Me.HelpProvider1.SetHelpString(Me.txt_tel1_alumno, "Ingrese aquí el número de teléfono del alumno. El mismo debe estar compuesto solo" & _
                " por números")
        Me.txt_tel1_alumno.Location = New System.Drawing.Point(8, 184)
        Me.txt_tel1_alumno.MaxLength = 15
        Me.txt_tel1_alumno.Name = "txt_tel1_alumno"
        Me.HelpProvider1.SetShowHelp(Me.txt_tel1_alumno, True)
        Me.txt_tel1_alumno.Size = New System.Drawing.Size(184, 20)
        Me.txt_tel1_alumno.TabIndex = 6
        '
        'lbl_nro_doc_alumno
        '
        Me.lbl_nro_doc_alumno.AutoSize = True
        Me.lbl_nro_doc_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro_doc_alumno.Location = New System.Drawing.Point(224, 72)
        Me.lbl_nro_doc_alumno.Name = "lbl_nro_doc_alumno"
        Me.lbl_nro_doc_alumno.Size = New System.Drawing.Size(138, 13)
        Me.lbl_nro_doc_alumno.TabIndex = 5
        Me.lbl_nro_doc_alumno.Text = "Número de documento:"
        '
        'txt_nro_doc_alumno
        '
        Me.HelpProvider1.SetHelpString(Me.txt_nro_doc_alumno, "Ingrese aquí el número de documento del alumno. El mismo debe estar compuesto sol" & _
                "o por números")
        Me.txt_nro_doc_alumno.Location = New System.Drawing.Point(224, 88)
        Me.txt_nro_doc_alumno.MaxLength = 9
        Me.txt_nro_doc_alumno.Name = "txt_nro_doc_alumno"
        Me.HelpProvider1.SetShowHelp(Me.txt_nro_doc_alumno, True)
        Me.txt_nro_doc_alumno.Size = New System.Drawing.Size(184, 20)
        Me.txt_nro_doc_alumno.TabIndex = 3
        '
        'lbl_fc_nacimiento
        '
        Me.lbl_fc_nacimiento.AutoSize = True
        Me.lbl_fc_nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fc_nacimiento.Location = New System.Drawing.Point(224, 120)
        Me.lbl_fc_nacimiento.Name = "lbl_fc_nacimiento"
        Me.lbl_fc_nacimiento.Size = New System.Drawing.Size(129, 13)
        Me.lbl_fc_nacimiento.TabIndex = 6
        Me.lbl_fc_nacimiento.Text = "Fecha de nacimiento:"
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sexo.Location = New System.Drawing.Point(8, 120)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_sexo.TabIndex = 7
        Me.lbl_sexo.Text = "Sexo:"
        '
        'lbl_desc_pais
        '
        Me.lbl_desc_pais.AutoSize = True
        Me.lbl_desc_pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc_pais.Location = New System.Drawing.Point(224, 168)
        Me.lbl_desc_pais.Name = "lbl_desc_pais"
        Me.lbl_desc_pais.Size = New System.Drawing.Size(74, 13)
        Me.lbl_desc_pais.TabIndex = 8
        Me.lbl_desc_pais.Text = "Nacimiento:"
        '
        'cb_sexo
        '
        Me.cb_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sexo.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_sexo, "Seleccione aquí el sexo del alumno")
        Me.cb_sexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cb_sexo.Location = New System.Drawing.Point(8, 136)
        Me.cb_sexo.Name = "cb_sexo"
        Me.HelpProvider1.SetShowHelp(Me.cb_sexo, True)
        Me.cb_sexo.Size = New System.Drawing.Size(184, 21)
        Me.cb_sexo.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cd_postal)
        Me.GroupBox1.Controls.Add(Me.lbl_desc_localidad)
        Me.GroupBox1.Controls.Add(Me.lbl_departamento_alumno)
        Me.GroupBox1.Controls.Add(Me.lbl_cd_postal)
        Me.GroupBox1.Controls.Add(Me.lbl_direccion_alumno)
        Me.GroupBox1.Controls.Add(Me.cb_desc_localidad)
        Me.GroupBox1.Controls.Add(Me.lbl_piso_alumno)
        Me.GroupBox1.Controls.Add(Me.txt_departamento_alumno)
        Me.GroupBox1.Controls.Add(Me.txt_direccion_alumno)
        Me.GroupBox1.Controls.Add(Me.txt_piso_alumno)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 306)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 120)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dirección del alumno"
        '
        'lbl_desc_localidad
        '
        Me.lbl_desc_localidad.AutoSize = True
        Me.lbl_desc_localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc_localidad.Location = New System.Drawing.Point(8, 72)
        Me.lbl_desc_localidad.Name = "lbl_desc_localidad"
        Me.lbl_desc_localidad.Size = New System.Drawing.Size(66, 13)
        Me.lbl_desc_localidad.TabIndex = 5
        Me.lbl_desc_localidad.Text = "Localidad:"
        '
        'lbl_departamento_alumno
        '
        Me.lbl_departamento_alumno.AutoSize = True
        Me.lbl_departamento_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_departamento_alumno.Location = New System.Drawing.Point(352, 24)
        Me.lbl_departamento_alumno.Name = "lbl_departamento_alumno"
        Me.lbl_departamento_alumno.Size = New System.Drawing.Size(90, 13)
        Me.lbl_departamento_alumno.TabIndex = 3
        Me.lbl_departamento_alumno.Text = "Departamento:"
        '
        'lbl_cd_postal
        '
        Me.lbl_cd_postal.AutoSize = True
        Me.lbl_cd_postal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cd_postal.Location = New System.Drawing.Point(224, 72)
        Me.lbl_cd_postal.Name = "lbl_cd_postal"
        Me.lbl_cd_postal.Size = New System.Drawing.Size(88, 13)
        Me.lbl_cd_postal.TabIndex = 4
        Me.lbl_cd_postal.Text = "Código postal:"
        '
        'lbl_direccion_alumno
        '
        Me.lbl_direccion_alumno.AutoSize = True
        Me.lbl_direccion_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion_alumno.Location = New System.Drawing.Point(8, 24)
        Me.lbl_direccion_alumno.Name = "lbl_direccion_alumno"
        Me.lbl_direccion_alumno.Size = New System.Drawing.Size(65, 13)
        Me.lbl_direccion_alumno.TabIndex = 9
        Me.lbl_direccion_alumno.Text = "Dirección:"
        '
        'cb_desc_localidad
        '
        Me.cb_desc_localidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_desc_localidad.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_desc_localidad, "Seleccione aquí la localidad en la que vive el alumno")
        Me.cb_desc_localidad.Location = New System.Drawing.Point(8, 88)
        Me.cb_desc_localidad.Name = "cb_desc_localidad"
        Me.HelpProvider1.SetShowHelp(Me.cb_desc_localidad, True)
        Me.cb_desc_localidad.Size = New System.Drawing.Size(180, 21)
        Me.cb_desc_localidad.TabIndex = 12
        '
        'lbl_piso_alumno
        '
        Me.lbl_piso_alumno.AutoSize = True
        Me.lbl_piso_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_piso_alumno.Location = New System.Drawing.Point(224, 24)
        Me.lbl_piso_alumno.Name = "lbl_piso_alumno"
        Me.lbl_piso_alumno.Size = New System.Drawing.Size(35, 13)
        Me.lbl_piso_alumno.TabIndex = 10
        Me.lbl_piso_alumno.Text = "Piso:"
        '
        'txt_departamento_alumno
        '
        Me.HelpProvider1.SetHelpString(Me.txt_departamento_alumno, "Ingrese aquí el departamento del alumno")
        Me.txt_departamento_alumno.Location = New System.Drawing.Point(352, 40)
        Me.txt_departamento_alumno.MaxLength = 3
        Me.txt_departamento_alumno.Name = "txt_departamento_alumno"
        Me.HelpProvider1.SetShowHelp(Me.txt_departamento_alumno, True)
        Me.txt_departamento_alumno.Size = New System.Drawing.Size(92, 20)
        Me.txt_departamento_alumno.TabIndex = 11
        '
        'txt_direccion_alumno
        '
        Me.HelpProvider1.SetHelpString(Me.txt_direccion_alumno, "Ingrese aquí la dirección del alumno")
        Me.txt_direccion_alumno.Location = New System.Drawing.Point(8, 40)
        Me.txt_direccion_alumno.MaxLength = 100
        Me.txt_direccion_alumno.Name = "txt_direccion_alumno"
        Me.HelpProvider1.SetShowHelp(Me.txt_direccion_alumno, True)
        Me.txt_direccion_alumno.Size = New System.Drawing.Size(180, 20)
        Me.txt_direccion_alumno.TabIndex = 9
        '
        'txt_piso_alumno
        '
        Me.HelpProvider1.SetHelpString(Me.txt_piso_alumno, "Ingrese aquí el piso del alumno")
        Me.txt_piso_alumno.Location = New System.Drawing.Point(224, 40)
        Me.txt_piso_alumno.MaxLength = 3
        Me.txt_piso_alumno.Name = "txt_piso_alumno"
        Me.HelpProvider1.SetShowHelp(Me.txt_piso_alumno, True)
        Me.txt_piso_alumno.Size = New System.Drawing.Size(92, 20)
        Me.txt_piso_alumno.TabIndex = 10
        '
        'btn_aceptar
        '
        Me.HelpProvider1.SetHelpString(Me.btn_aceptar, "Presione aquí para efectuar la operación")
        Me.btn_aceptar.Location = New System.Drawing.Point(327, 438)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.HelpProvider1.SetShowHelp(Me.btn_aceptar, True)
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 41
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btn_cancelar, "Presione aquí para cancelar la operación")
        Me.btn_cancelar.Location = New System.Drawing.Point(408, 438)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.HelpProvider1.SetShowHelp(Me.btn_cancelar, True)
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 42
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'txt_cd_postal
        '
        Me.HelpProvider1.SetHelpString(Me.txt_cd_postal, "Ingrese aquí el código postal de la dirección. El mismo debera ser de 4 dígitos")
        Me.txt_cd_postal.Location = New System.Drawing.Point(224, 89)
        Me.txt_cd_postal.MaxLength = 4
        Me.txt_cd_postal.Name = "txt_cd_postal"
        Me.HelpProvider1.SetShowHelp(Me.txt_cd_postal, True)
        Me.txt_cd_postal.Size = New System.Drawing.Size(92, 20)
        Me.txt_cd_postal.TabIndex = 13
        '
        'form_alumno_edicion
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(495, 472)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_titulo_form)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_alumno_edicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edición de alumno"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_titulo_form As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_nombre_alumno As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_alumno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido_alumno As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_alumno As System.Windows.Forms.TextBox
    Friend WithEvents txt_email_alumno As System.Windows.Forms.TextBox
    Friend WithEvents cb_desc_pais As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fc_nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_tel1_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_email_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_doc_alumno As System.Windows.Forms.Label
    Friend WithEvents cb_tipo_doc_alumno As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tel1_alumno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nro_doc_alumno As System.Windows.Forms.Label
    Friend WithEvents txt_nro_doc_alumno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fc_nacimiento As System.Windows.Forms.Label
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents lbl_desc_pais As System.Windows.Forms.Label
    Friend WithEvents cb_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_desc_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_departamento_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_cd_postal As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion_alumno As System.Windows.Forms.Label
    Friend WithEvents cb_desc_localidad As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_piso_alumno As System.Windows.Forms.Label
    Friend WithEvents txt_departamento_alumno As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion_alumno As System.Windows.Forms.TextBox
    Friend WithEvents txt_piso_alumno As System.Windows.Forms.TextBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents txt_cd_postal As System.Windows.Forms.TextBox
End Class
