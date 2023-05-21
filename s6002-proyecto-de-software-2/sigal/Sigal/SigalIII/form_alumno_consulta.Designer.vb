<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_alumno_consulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_alumno_consulta))
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.mail = New System.Windows.Forms.Label
        Me.pais = New System.Windows.Forms.Label
        Me.tel = New System.Windows.Forms.Label
        Me.nacimiento = New System.Windows.Forms.Label
        Me.sex = New System.Windows.Forms.Label
        Me.nro_doc = New System.Windows.Forms.Label
        Me.tipo_doc = New System.Windows.Forms.Label
        Me.nombre = New System.Windows.Forms.Label
        Me.apellido = New System.Windows.Forms.Label
        Me.lbl_nombre_alumno = New System.Windows.Forms.Label
        Me.lbl_apellido_alumno = New System.Windows.Forms.Label
        Me.lbl_tel1_alumno = New System.Windows.Forms.Label
        Me.lbl_email_alumno = New System.Windows.Forms.Label
        Me.lbl_tipo_doc_alumno = New System.Windows.Forms.Label
        Me.lbl_nro_doc_alumno = New System.Windows.Forms.Label
        Me.lbl_fc_nacimiento = New System.Windows.Forms.Label
        Me.lbl_sexo = New System.Windows.Forms.Label
        Me.lbl_desc_pais = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cp = New System.Windows.Forms.Label
        Me.local = New System.Windows.Forms.Label
        Me.lbl_desc_localidad = New System.Windows.Forms.Label
        Me.dto = New System.Windows.Forms.Label
        Me.piso = New System.Windows.Forms.Label
        Me.lbl_departamento_alumno = New System.Windows.Forms.Label
        Me.lo = New System.Windows.Forms.Label
        Me.lbl_cd_postal = New System.Windows.Forms.Label
        Me.lbl_direccion_alumno = New System.Windows.Forms.Label
        Me.lbl_piso_alumno = New System.Windows.Forms.Label
        Me.lbl_titulo_form = New System.Windows.Forms.Label
        Me.fc_ult = New System.Windows.Forms.Label
        Me.lbl_fc_alta = New System.Windows.Forms.Label
        Me.estado = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.btn_aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_aceptar.Location = New System.Drawing.Point(566, 511)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 45
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mail)
        Me.GroupBox2.Controls.Add(Me.pais)
        Me.GroupBox2.Controls.Add(Me.tel)
        Me.GroupBox2.Controls.Add(Me.nacimiento)
        Me.GroupBox2.Controls.Add(Me.sex)
        Me.GroupBox2.Controls.Add(Me.nro_doc)
        Me.GroupBox2.Controls.Add(Me.tipo_doc)
        Me.GroupBox2.Controls.Add(Me.nombre)
        Me.GroupBox2.Controls.Add(Me.apellido)
        Me.GroupBox2.Controls.Add(Me.lbl_nombre_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_apellido_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_tel1_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_email_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_tipo_doc_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_nro_doc_alumno)
        Me.GroupBox2.Controls.Add(Me.lbl_fc_nacimiento)
        Me.GroupBox2.Controls.Add(Me.lbl_sexo)
        Me.GroupBox2.Controls.Add(Me.lbl_desc_pais)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(629, 214)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos personales del alumno"
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.Location = New System.Drawing.Point(88, 184)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(39, 13)
        Me.mail.TabIndex = 11
        Me.mail.Text = "Label2"
        '
        'pais
        '
        Me.pais.AutoSize = True
        Me.pais.Location = New System.Drawing.Point(384, 152)
        Me.pais.Name = "pais"
        Me.pais.Size = New System.Drawing.Size(39, 13)
        Me.pais.TabIndex = 10
        Me.pais.Text = "Label2"
        '
        'tel
        '
        Me.tel.AutoSize = True
        Me.tel.Location = New System.Drawing.Point(88, 152)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(39, 13)
        Me.tel.TabIndex = 10
        Me.tel.Text = "Label2"
        '
        'nacimiento
        '
        Me.nacimiento.AutoSize = True
        Me.nacimiento.Location = New System.Drawing.Point(384, 120)
        Me.nacimiento.Name = "nacimiento"
        Me.nacimiento.Size = New System.Drawing.Size(39, 13)
        Me.nacimiento.TabIndex = 10
        Me.nacimiento.Text = "Label2"
        '
        'sex
        '
        Me.sex.AutoSize = True
        Me.sex.Location = New System.Drawing.Point(88, 120)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(39, 13)
        Me.sex.TabIndex = 10
        Me.sex.Text = "Label2"
        '
        'nro_doc
        '
        Me.nro_doc.AutoSize = True
        Me.nro_doc.Location = New System.Drawing.Point(384, 88)
        Me.nro_doc.Name = "nro_doc"
        Me.nro_doc.Size = New System.Drawing.Size(39, 13)
        Me.nro_doc.TabIndex = 10
        Me.nro_doc.Text = "Label2"
        '
        'tipo_doc
        '
        Me.tipo_doc.AutoSize = True
        Me.tipo_doc.Location = New System.Drawing.Point(88, 88)
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.Size = New System.Drawing.Size(39, 13)
        Me.tipo_doc.TabIndex = 10
        Me.tipo_doc.Text = "Label2"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(88, 56)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(39, 13)
        Me.nombre.TabIndex = 10
        Me.nombre.Text = "Label2"
        '
        'apellido
        '
        Me.apellido.AutoSize = True
        Me.apellido.Location = New System.Drawing.Point(88, 24)
        Me.apellido.Name = "apellido"
        Me.apellido.Size = New System.Drawing.Size(39, 13)
        Me.apellido.TabIndex = 10
        Me.apellido.Text = "Label2"
        '
        'lbl_nombre_alumno
        '
        Me.lbl_nombre_alumno.AutoSize = True
        Me.lbl_nombre_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_alumno.Location = New System.Drawing.Point(8, 56)
        Me.lbl_nombre_alumno.Name = "lbl_nombre_alumno"
        Me.lbl_nombre_alumno.Size = New System.Drawing.Size(54, 13)
        Me.lbl_nombre_alumno.TabIndex = 2
        Me.lbl_nombre_alumno.Text = "Nombre:"
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
        'lbl_tel1_alumno
        '
        Me.lbl_tel1_alumno.AutoSize = True
        Me.lbl_tel1_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tel1_alumno.Location = New System.Drawing.Point(8, 152)
        Me.lbl_tel1_alumno.Name = "lbl_tel1_alumno"
        Me.lbl_tel1_alumno.Size = New System.Drawing.Size(61, 13)
        Me.lbl_tel1_alumno.TabIndex = 6
        Me.lbl_tel1_alumno.Text = "Teléfono:"
        '
        'lbl_email_alumno
        '
        Me.lbl_email_alumno.AutoSize = True
        Me.lbl_email_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email_alumno.Location = New System.Drawing.Point(8, 184)
        Me.lbl_email_alumno.Name = "lbl_email_alumno"
        Me.lbl_email_alumno.Size = New System.Drawing.Size(41, 13)
        Me.lbl_email_alumno.TabIndex = 7
        Me.lbl_email_alumno.Text = "Email:"
        '
        'lbl_tipo_doc_alumno
        '
        Me.lbl_tipo_doc_alumno.AutoSize = True
        Me.lbl_tipo_doc_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_doc_alumno.Location = New System.Drawing.Point(8, 88)
        Me.lbl_tipo_doc_alumno.Name = "lbl_tipo_doc_alumno"
        Me.lbl_tipo_doc_alumno.Size = New System.Drawing.Size(36, 13)
        Me.lbl_tipo_doc_alumno.TabIndex = 4
        Me.lbl_tipo_doc_alumno.Text = "Tipo:"
        '
        'lbl_nro_doc_alumno
        '
        Me.lbl_nro_doc_alumno.AutoSize = True
        Me.lbl_nro_doc_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro_doc_alumno.Location = New System.Drawing.Point(216, 88)
        Me.lbl_nro_doc_alumno.Name = "lbl_nro_doc_alumno"
        Me.lbl_nro_doc_alumno.Size = New System.Drawing.Size(138, 13)
        Me.lbl_nro_doc_alumno.TabIndex = 5
        Me.lbl_nro_doc_alumno.Text = "Número de documento:"
        '
        'lbl_fc_nacimiento
        '
        Me.lbl_fc_nacimiento.AutoSize = True
        Me.lbl_fc_nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fc_nacimiento.Location = New System.Drawing.Point(216, 120)
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
        Me.lbl_desc_pais.Location = New System.Drawing.Point(216, 152)
        Me.lbl_desc_pais.Name = "lbl_desc_pais"
        Me.lbl_desc_pais.Size = New System.Drawing.Size(74, 13)
        Me.lbl_desc_pais.TabIndex = 8
        Me.lbl_desc_pais.Text = "Nacimiento:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cp)
        Me.GroupBox1.Controls.Add(Me.local)
        Me.GroupBox1.Controls.Add(Me.lbl_desc_localidad)
        Me.GroupBox1.Controls.Add(Me.dto)
        Me.GroupBox1.Controls.Add(Me.piso)
        Me.GroupBox1.Controls.Add(Me.lbl_departamento_alumno)
        Me.GroupBox1.Controls.Add(Me.lo)
        Me.GroupBox1.Controls.Add(Me.lbl_cd_postal)
        Me.GroupBox1.Controls.Add(Me.lbl_direccion_alumno)
        Me.GroupBox1.Controls.Add(Me.lbl_piso_alumno)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 120)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dirección del alumno"
        '
        'cp
        '
        Me.cp.AutoSize = True
        Me.cp.Location = New System.Drawing.Point(388, 88)
        Me.cp.Name = "cp"
        Me.cp.Size = New System.Drawing.Size(39, 13)
        Me.cp.TabIndex = 11
        Me.cp.Text = "Label2"
        '
        'local
        '
        Me.local.AutoSize = True
        Me.local.Location = New System.Drawing.Point(92, 88)
        Me.local.Name = "local"
        Me.local.Size = New System.Drawing.Size(39, 13)
        Me.local.TabIndex = 11
        Me.local.Text = "Label2"
        '
        'lbl_desc_localidad
        '
        Me.lbl_desc_localidad.AutoSize = True
        Me.lbl_desc_localidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc_localidad.Location = New System.Drawing.Point(8, 88)
        Me.lbl_desc_localidad.Name = "lbl_desc_localidad"
        Me.lbl_desc_localidad.Size = New System.Drawing.Size(66, 13)
        Me.lbl_desc_localidad.TabIndex = 5
        Me.lbl_desc_localidad.Text = "Localidad:"
        '
        'dto
        '
        Me.dto.AutoSize = True
        Me.dto.Location = New System.Drawing.Point(388, 56)
        Me.dto.Name = "dto"
        Me.dto.Size = New System.Drawing.Size(39, 13)
        Me.dto.TabIndex = 10
        Me.dto.Text = "Label2"
        '
        'piso
        '
        Me.piso.AutoSize = True
        Me.piso.Location = New System.Drawing.Point(92, 56)
        Me.piso.Name = "piso"
        Me.piso.Size = New System.Drawing.Size(39, 13)
        Me.piso.TabIndex = 10
        Me.piso.Text = "Label2"
        '
        'lbl_departamento_alumno
        '
        Me.lbl_departamento_alumno.AutoSize = True
        Me.lbl_departamento_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_departamento_alumno.Location = New System.Drawing.Point(220, 56)
        Me.lbl_departamento_alumno.Name = "lbl_departamento_alumno"
        Me.lbl_departamento_alumno.Size = New System.Drawing.Size(90, 13)
        Me.lbl_departamento_alumno.TabIndex = 3
        Me.lbl_departamento_alumno.Text = "Departamento:"
        '
        'lo
        '
        Me.lo.AutoSize = True
        Me.lo.Location = New System.Drawing.Point(92, 24)
        Me.lo.Name = "lo"
        Me.lo.Size = New System.Drawing.Size(39, 13)
        Me.lo.TabIndex = 10
        Me.lo.Text = "Label2"
        '
        'lbl_cd_postal
        '
        Me.lbl_cd_postal.AutoSize = True
        Me.lbl_cd_postal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cd_postal.Location = New System.Drawing.Point(220, 88)
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
        'lbl_piso_alumno
        '
        Me.lbl_piso_alumno.AutoSize = True
        Me.lbl_piso_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_piso_alumno.Location = New System.Drawing.Point(8, 56)
        Me.lbl_piso_alumno.Name = "lbl_piso_alumno"
        Me.lbl_piso_alumno.Size = New System.Drawing.Size(35, 13)
        Me.lbl_piso_alumno.TabIndex = 10
        Me.lbl_piso_alumno.Text = "Piso:"
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
        Me.lbl_titulo_form.Size = New System.Drawing.Size(629, 22)
        Me.lbl_titulo_form.TabIndex = 42
        '
        'fc_ult
        '
        Me.fc_ult.AutoSize = True
        Me.fc_ult.Location = New System.Drawing.Point(224, 56)
        Me.fc_ult.Name = "fc_ult"
        Me.fc_ult.Size = New System.Drawing.Size(39, 13)
        Me.fc_ult.TabIndex = 46
        Me.fc_ult.Text = "Label2"
        '
        'lbl_fc_alta
        '
        Me.lbl_fc_alta.AutoSize = True
        Me.lbl_fc_alta.Location = New System.Drawing.Point(224, 24)
        Me.lbl_fc_alta.Name = "lbl_fc_alta"
        Me.lbl_fc_alta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_fc_alta.TabIndex = 46
        Me.lbl_fc_alta.Text = "Label2"
        '
        'estado
        '
        Me.estado.AutoSize = True
        Me.estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estado.Location = New System.Drawing.Point(224, 88)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(45, 13)
        Me.estado.TabIndex = 47
        Me.estado.Text = "Label1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.fc_ult)
        Me.GroupBox3.Controls.Add(Me.estado)
        Me.GroupBox3.Controls.Add(Me.lbl_fc_alta)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 384)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(633, 120)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado del alumno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Fecha de última modificación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Estado general:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Fecha de alta:"
        '
        'form_alumno_consulta
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_aceptar
        Me.ClientSize = New System.Drawing.Size(653, 546)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_titulo_form)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_alumno_consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de alumno"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_nombre_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_tel1_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_email_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_tipo_doc_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_nro_doc_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_fc_nacimiento As System.Windows.Forms.Label
    Friend WithEvents lbl_sexo As System.Windows.Forms.Label
    Friend WithEvents lbl_desc_pais As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_desc_localidad As System.Windows.Forms.Label
    Friend WithEvents lbl_departamento_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_cd_postal As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_piso_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo_form As System.Windows.Forms.Label
    Friend WithEvents mail As System.Windows.Forms.Label
    Friend WithEvents pais As System.Windows.Forms.Label
    Friend WithEvents tel As System.Windows.Forms.Label
    Friend WithEvents nacimiento As System.Windows.Forms.Label
    Friend WithEvents sex As System.Windows.Forms.Label
    Friend WithEvents nro_doc As System.Windows.Forms.Label
    Friend WithEvents tipo_doc As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents apellido As System.Windows.Forms.Label
    Friend WithEvents cp As System.Windows.Forms.Label
    Friend WithEvents local As System.Windows.Forms.Label
    Friend WithEvents dto As System.Windows.Forms.Label
    Friend WithEvents piso As System.Windows.Forms.Label
    Friend WithEvents lo As System.Windows.Forms.Label
    Friend WithEvents fc_ult As System.Windows.Forms.Label
    Friend WithEvents lbl_fc_alta As System.Windows.Forms.Label
    Friend WithEvents estado As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
