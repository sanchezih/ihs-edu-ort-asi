<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_inscripcion_plan_search
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
        Me.grilla_inscripcion_plan = New System.Windows.Forms.DataGridView
        Me.cd_plan_estudio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.codigo_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.an = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fc_alta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.cb_planes = New System.Windows.Forms.ComboBox
        Me.txt_cd_alumno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_limpiar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.btn_ir = New System.Windows.Forms.Button
        Me.cb_opciones = New System.Windows.Forms.ComboBox
        CType(Me.grilla_inscripcion_plan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grilla_inscripcion_plan
        '
        Me.grilla_inscripcion_plan.AllowUserToAddRows = False
        Me.grilla_inscripcion_plan.AllowUserToDeleteRows = False
        Me.grilla_inscripcion_plan.AllowUserToResizeRows = False
        Me.grilla_inscripcion_plan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla_inscripcion_plan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_inscripcion_plan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla_inscripcion_plan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_inscripcion_plan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cd_plan_estudio, Me.titulo, Me.codigo_alumno, Me.an, Me.fc_alta})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_inscripcion_plan.DefaultCellStyle = DataGridViewCellStyle2
        Me.grilla_inscripcion_plan.Location = New System.Drawing.Point(12, 90)
        Me.grilla_inscripcion_plan.MultiSelect = False
        Me.grilla_inscripcion_plan.Name = "grilla_inscripcion_plan"
        Me.grilla_inscripcion_plan.ReadOnly = True
        Me.grilla_inscripcion_plan.RowHeadersVisible = False
        Me.grilla_inscripcion_plan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla_inscripcion_plan.Size = New System.Drawing.Size(788, 255)
        Me.grilla_inscripcion_plan.TabIndex = 0
        '
        'cd_plan_estudio
        '
        Me.cd_plan_estudio.HeaderText = "Código de plan de estudio"
        Me.cd_plan_estudio.Name = "cd_plan_estudio"
        Me.cd_plan_estudio.ReadOnly = True
        '
        'titulo
        '
        Me.titulo.HeaderText = "Nombre de plan de estudio"
        Me.titulo.Name = "titulo"
        Me.titulo.ReadOnly = True
        '
        'codigo_alumno
        '
        Me.codigo_alumno.HeaderText = "Código de alumno"
        Me.codigo_alumno.Name = "codigo_alumno"
        Me.codigo_alumno.ReadOnly = True
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
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(725, 351)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
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
        'cb_planes
        '
        Me.cb_planes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_planes.FormattingEnabled = True
        Me.cb_planes.Location = New System.Drawing.Point(12, 63)
        Me.cb_planes.Name = "cb_planes"
        Me.cb_planes.Size = New System.Drawing.Size(276, 21)
        Me.cb_planes.TabIndex = 4
        '
        'txt_cd_alumno
        '
        Me.txt_cd_alumno.Location = New System.Drawing.Point(324, 63)
        Me.txt_cd_alumno.Name = "txt_cd_alumno"
        Me.txt_cd_alumno.Size = New System.Drawing.Size(92, 20)
        Me.txt_cd_alumno.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Plan de estudio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(321, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Código de alumno:"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_limpiar.Location = New System.Drawing.Point(644, 351)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 8
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
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Consulta de inscripción a plan de estudio"
        '
        'btn_ir
        '
        Me.btn_ir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ir.Image = Global.Sigal.My.Resources.Resources.bullet_go
        Me.btn_ir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ir.Location = New System.Drawing.Point(294, 351)
        Me.btn_ir.Name = "btn_ir"
        Me.btn_ir.Size = New System.Drawing.Size(75, 23)
        Me.btn_ir.TabIndex = 48
        Me.btn_ir.Text = "&Ir..."
        Me.btn_ir.UseVisualStyleBackColor = True
        '
        'cb_opciones
        '
        Me.cb_opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_opciones.FormattingEnabled = True
        Me.cb_opciones.Items.AddRange(New Object() {"Dar de alta una nueva inscripción"})
        Me.cb_opciones.Location = New System.Drawing.Point(12, 353)
        Me.cb_opciones.Name = "cb_opciones"
        Me.cb_opciones.Size = New System.Drawing.Size(276, 21)
        Me.cb_opciones.TabIndex = 47
        '
        'form_inscripcion_plan_search
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cd_alumno)
        Me.Controls.Add(Me.cb_planes)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.grilla_inscripcion_plan)
        Me.MinimumSize = New System.Drawing.Size(820, 420)
        Me.Name = "form_inscripcion_plan_search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de inscripción a plan de estudio"
        CType(Me.grilla_inscripcion_plan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grilla_inscripcion_plan As System.Windows.Forms.DataGridView
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents cb_planes As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cd_alumno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents cd_alumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cd_plan_estudio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo_alumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents an As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fc_alta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_ir As System.Windows.Forms.Button
    Friend WithEvents cb_opciones As System.Windows.Forms.ComboBox
End Class
