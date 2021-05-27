<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_inscripcion_curso_search
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
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.grilla_inscripcion_curso = New System.Windows.Forms.DataGridView
        Me.cd_curso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre_materia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cd_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.an = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fc_alta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cb_planes = New System.Windows.Forms.ComboBox
        Me.btn_limpiar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_cd_curso = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_cd_alumno = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btn_ir = New System.Windows.Forms.Button
        Me.cb_opciones = New System.Windows.Forms.ComboBox
        CType(Me.grilla_inscripcion_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(725, 351)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.Location = New System.Drawing.Point(725, 62)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "&Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'grilla_inscripcion_curso
        '
        Me.grilla_inscripcion_curso.AllowUserToAddRows = False
        Me.grilla_inscripcion_curso.AllowUserToDeleteRows = False
        Me.grilla_inscripcion_curso.AllowUserToResizeRows = False
        Me.grilla_inscripcion_curso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla_inscripcion_curso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_inscripcion_curso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla_inscripcion_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_inscripcion_curso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cd_curso, Me.nombre_materia, Me.cd_alumno, Me.an, Me.fc_alta})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_inscripcion_curso.DefaultCellStyle = DataGridViewCellStyle2
        Me.grilla_inscripcion_curso.Location = New System.Drawing.Point(12, 91)
        Me.grilla_inscripcion_curso.MultiSelect = False
        Me.grilla_inscripcion_curso.Name = "grilla_inscripcion_curso"
        Me.grilla_inscripcion_curso.ReadOnly = True
        Me.grilla_inscripcion_curso.RowHeadersVisible = False
        Me.grilla_inscripcion_curso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla_inscripcion_curso.Size = New System.Drawing.Size(788, 254)
        Me.grilla_inscripcion_curso.TabIndex = 3
        '
        'cd_curso
        '
        Me.cd_curso.HeaderText = "Código de curso"
        Me.cd_curso.Name = "cd_curso"
        Me.cd_curso.ReadOnly = True
        '
        'nombre_materia
        '
        Me.nombre_materia.HeaderText = "Materia"
        Me.nombre_materia.Name = "nombre_materia"
        Me.nombre_materia.ReadOnly = True
        '
        'cd_alumno
        '
        Me.cd_alumno.HeaderText = "Código de alumno"
        Me.cd_alumno.Name = "cd_alumno"
        Me.cd_alumno.ReadOnly = True
        '
        'an
        '
        Me.an.HeaderText = "Apellido y nombre"
        Me.an.Name = "an"
        Me.an.ReadOnly = True
        '
        'fc_alta
        '
        Me.fc_alta.HeaderText = "Fecha de alta"
        Me.fc_alta.Name = "fc_alta"
        Me.fc_alta.ReadOnly = True
        '
        'cb_planes
        '
        Me.cb_planes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_planes.FormattingEnabled = True
        Me.cb_planes.Location = New System.Drawing.Point(12, 64)
        Me.cb_planes.Name = "cb_planes"
        Me.cb_planes.Size = New System.Drawing.Size(276, 21)
        Me.cb_planes.TabIndex = 0
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_limpiar.Location = New System.Drawing.Point(644, 351)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 5
        Me.btn_limpiar.Text = "&Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Plan de estudio:"
        '
        'txt_cd_curso
        '
        Me.txt_cd_curso.Location = New System.Drawing.Point(324, 64)
        Me.txt_cd_curso.Name = "txt_cd_curso"
        Me.txt_cd_curso.Size = New System.Drawing.Size(92, 20)
        Me.txt_cd_curso.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(321, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Código de curso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(449, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Código de alumno:"
        '
        'txt_cd_alumno
        '
        Me.txt_cd_alumno.Location = New System.Drawing.Point(452, 64)
        Me.txt_cd_alumno.Name = "txt_cd_alumno"
        Me.txt_cd_alumno.Size = New System.Drawing.Size(92, 20)
        Me.txt_cd_alumno.TabIndex = 10
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
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Consulta de inscripción a curso"
        '
        'btn_ir
        '
        Me.btn_ir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ir.Image = Global.Sigal.My.Resources.Resources.bullet_go
        Me.btn_ir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ir.Location = New System.Drawing.Point(294, 351)
        Me.btn_ir.Name = "btn_ir"
        Me.btn_ir.Size = New System.Drawing.Size(75, 23)
        Me.btn_ir.TabIndex = 46
        Me.btn_ir.Text = "&Ir..."
        Me.btn_ir.UseVisualStyleBackColor = True
        '
        'cb_opciones
        '
        Me.cb_opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_opciones.FormattingEnabled = True
        Me.cb_opciones.Items.AddRange(New Object() {"Dar de alta una nueva inscripción", "Ver la calificación de cursada asociada a la inscripción", "Ver la calificación de final asociada a la inscripción"})
        Me.cb_opciones.Location = New System.Drawing.Point(12, 353)
        Me.cb_opciones.Name = "cb_opciones"
        Me.cb_opciones.Size = New System.Drawing.Size(276, 21)
        Me.cb_opciones.TabIndex = 45
        '
        'form_inscripcion_curso_search
        '
        Me.AcceptButton = Me.btn_buscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(812, 386)
        Me.Controls.Add(Me.btn_ir)
        Me.Controls.Add(Me.cb_opciones)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_cd_alumno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cd_curso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.cb_planes)
        Me.Controls.Add(Me.grilla_inscripcion_curso)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.MinimumSize = New System.Drawing.Size(820, 420)
        Me.Name = "form_inscripcion_curso_search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de inscripción a curso"
        CType(Me.grilla_inscripcion_curso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents grilla_inscripcion_curso As System.Windows.Forms.DataGridView
    Friend WithEvents cb_planes As System.Windows.Forms.ComboBox
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cd_curso As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_cd_alumno As System.Windows.Forms.TextBox
    Friend WithEvents cd_curso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_materia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd_alumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents an As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fc_alta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_ir As System.Windows.Forms.Button
    Friend WithEvents cb_opciones As System.Windows.Forms.ComboBox
End Class
