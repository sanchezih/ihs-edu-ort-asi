<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_alumno_search
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_alumno_search))
        Me.grilla_alumno = New System.Windows.Forms.DataGridView
        Me.cd_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.apellido_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.lbl_cd_alumno = New System.Windows.Forms.Label
        Me.lbl_nombre_alumno = New System.Windows.Forms.Label
        Me.lbl_apellido_alumno = New System.Windows.Forms.Label
        Me.txt_apellido_alumno = New System.Windows.Forms.TextBox
        Me.txt_nombre_alumno = New System.Windows.Forms.TextBox
        Me.txt_cd_alumno = New System.Windows.Forms.TextBox
        Me.btn_limpiar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.btn_ir = New System.Windows.Forms.Button
        Me.cb_opciones = New System.Windows.Forms.ComboBox
        CType(Me.grilla_alumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grilla_alumno
        '
        Me.grilla_alumno.AllowUserToAddRows = False
        Me.grilla_alumno.AllowUserToDeleteRows = False
        Me.grilla_alumno.AllowUserToResizeRows = False
        Me.grilla_alumno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla_alumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_alumno.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla_alumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_alumno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cd_alumno, Me.apellido_alumno, Me.nombre_alumno, Me.documento, Me.Estado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_alumno.DefaultCellStyle = DataGridViewCellStyle2
        Me.grilla_alumno.Location = New System.Drawing.Point(12, 90)
        Me.grilla_alumno.MultiSelect = False
        Me.grilla_alumno.Name = "grilla_alumno"
        Me.grilla_alumno.ReadOnly = True
        Me.grilla_alumno.RowHeadersVisible = False
        Me.grilla_alumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla_alumno.Size = New System.Drawing.Size(788, 255)
        Me.grilla_alumno.TabIndex = 0
        Me.grilla_alumno.TabStop = False
        '
        'cd_alumno
        '
        Me.cd_alumno.HeaderText = "Código"
        Me.cd_alumno.Name = "cd_alumno"
        Me.cd_alumno.ReadOnly = True
        '
        'apellido_alumno
        '
        Me.apellido_alumno.HeaderText = "Apellido"
        Me.apellido_alumno.Name = "apellido_alumno"
        Me.apellido_alumno.ReadOnly = True
        '
        'nombre_alumno
        '
        Me.nombre_alumno.HeaderText = "Nombre"
        Me.nombre_alumno.Name = "nombre_alumno"
        Me.nombre_alumno.ReadOnly = True
        '
        'documento
        '
        Me.documento.HeaderText = "Documento"
        Me.documento.Name = "documento"
        Me.documento.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.Location = New System.Drawing.Point(725, 61)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 3
        Me.btn_buscar.Text = "&Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(725, 353)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 6
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_cd_alumno
        '
        Me.lbl_cd_alumno.AutoSize = True
        Me.lbl_cd_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cd_alumno.Location = New System.Drawing.Point(9, 48)
        Me.lbl_cd_alumno.Name = "lbl_cd_alumno"
        Me.lbl_cd_alumno.Size = New System.Drawing.Size(112, 13)
        Me.lbl_cd_alumno.TabIndex = 3
        Me.lbl_cd_alumno.Text = "Código de alumno:"
        '
        'lbl_nombre_alumno
        '
        Me.lbl_nombre_alumno.AutoSize = True
        Me.lbl_nombre_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_alumno.Location = New System.Drawing.Point(361, 48)
        Me.lbl_nombre_alumno.Name = "lbl_nombre_alumno"
        Me.lbl_nombre_alumno.Size = New System.Drawing.Size(54, 13)
        Me.lbl_nombre_alumno.TabIndex = 5
        Me.lbl_nombre_alumno.Text = "Nombre:"
        '
        'lbl_apellido_alumno
        '
        Me.lbl_apellido_alumno.AutoSize = True
        Me.lbl_apellido_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido_alumno.Location = New System.Drawing.Point(137, 48)
        Me.lbl_apellido_alumno.Name = "lbl_apellido_alumno"
        Me.lbl_apellido_alumno.Size = New System.Drawing.Size(56, 13)
        Me.lbl_apellido_alumno.TabIndex = 6
        Me.lbl_apellido_alumno.Text = "Apellido:"
        '
        'txt_apellido_alumno
        '
        Me.txt_apellido_alumno.Location = New System.Drawing.Point(140, 64)
        Me.txt_apellido_alumno.MaxLength = 100
        Me.txt_apellido_alumno.Name = "txt_apellido_alumno"
        Me.txt_apellido_alumno.Size = New System.Drawing.Size(184, 20)
        Me.txt_apellido_alumno.TabIndex = 1
        '
        'txt_nombre_alumno
        '
        Me.txt_nombre_alumno.Location = New System.Drawing.Point(364, 64)
        Me.txt_nombre_alumno.MaxLength = 100
        Me.txt_nombre_alumno.Name = "txt_nombre_alumno"
        Me.txt_nombre_alumno.Size = New System.Drawing.Size(184, 20)
        Me.txt_nombre_alumno.TabIndex = 2
        '
        'txt_cd_alumno
        '
        Me.txt_cd_alumno.Location = New System.Drawing.Point(12, 64)
        Me.txt_cd_alumno.MaxLength = 9
        Me.txt_cd_alumno.Name = "txt_cd_alumno"
        Me.txt_cd_alumno.Size = New System.Drawing.Size(92, 20)
        Me.txt_cd_alumno.TabIndex = 0
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_limpiar.Location = New System.Drawing.Point(644, 353)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 5
        Me.btn_limpiar.Text = "&Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.SandyBrown
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(788, 22)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Consulta de alumno"
        '
        'btn_ir
        '
        Me.btn_ir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ir.Image = Global.Sigal.My.Resources.Resources.bullet_go
        Me.btn_ir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ir.Location = New System.Drawing.Point(294, 353)
        Me.btn_ir.Name = "btn_ir"
        Me.btn_ir.Size = New System.Drawing.Size(75, 23)
        Me.btn_ir.TabIndex = 38
        Me.btn_ir.Text = "&Ir..."
        Me.btn_ir.UseVisualStyleBackColor = True
        '
        'cb_opciones
        '
        Me.cb_opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_opciones.FormattingEnabled = True
        Me.cb_opciones.Items.AddRange(New Object() {"Dar de alta un nuevo alumno", "Editar el alumno seleccionado", "Ver los detalles del alumno seleccionado", "Ver las inscripciones a plan del alumno seleccionado", "Ver las inscripciones a curso del alumno seleccionado", "Ver las calificaciones de cursada del alumno seleccionado", "Ver las calificaciones de final del alumno seleccionado", "Ver el informe analítico del alumno seleccionado"})
        Me.cb_opciones.Location = New System.Drawing.Point(12, 353)
        Me.cb_opciones.Name = "cb_opciones"
        Me.cb_opciones.Size = New System.Drawing.Size(276, 21)
        Me.cb_opciones.TabIndex = 37
        '
        'form_alumno_search
        '
        Me.AcceptButton = Me.btn_buscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(812, 386)
        Me.Controls.Add(Me.btn_ir)
        Me.Controls.Add(Me.cb_opciones)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.txt_cd_alumno)
        Me.Controls.Add(Me.txt_nombre_alumno)
        Me.Controls.Add(Me.txt_apellido_alumno)
        Me.Controls.Add(Me.lbl_apellido_alumno)
        Me.Controls.Add(Me.lbl_nombre_alumno)
        Me.Controls.Add(Me.lbl_cd_alumno)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.grilla_alumno)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(820, 420)
        Me.Name = "form_alumno_search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de alumno"
        CType(Me.grilla_alumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grilla_alumno As System.Windows.Forms.DataGridView
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_cd_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido_alumno As System.Windows.Forms.Label
    Friend WithEvents txt_apellido_alumno As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_alumno As System.Windows.Forms.TextBox
    Friend WithEvents txt_cd_alumno As System.Windows.Forms.TextBox
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cd_alumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido_alumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_alumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_ir As System.Windows.Forms.Button
    Friend WithEvents cb_opciones As System.Windows.Forms.ComboBox
End Class
