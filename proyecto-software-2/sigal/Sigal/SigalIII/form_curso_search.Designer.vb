<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_curso_search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_curso_search))
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_cd_curso = New System.Windows.Forms.TextBox
        Me.grilla_curso = New System.Windows.Forms.DataGridView
        Me.cd_curso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cd_plan_estudio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre_profesor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cd_matera = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre_materia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.anio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fc_baja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.check_estado = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_anio = New System.Windows.Forms.TextBox
        Me.cb_materias = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btn_limpiar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.cb_profesores = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btn_ir = New System.Windows.Forms.Button
        Me.cb_opciones = New System.Windows.Forms.ComboBox
        CType(Me.grilla_curso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelar.Location = New System.Drawing.Point(725, 353)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 1
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.Location = New System.Drawing.Point(725, 61)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "&Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código de curso:"
        '
        'txt_cd_curso
        '
        Me.txt_cd_curso.Location = New System.Drawing.Point(16, 64)
        Me.txt_cd_curso.MaxLength = 9
        Me.txt_cd_curso.Name = "txt_cd_curso"
        Me.txt_cd_curso.Size = New System.Drawing.Size(92, 20)
        Me.txt_cd_curso.TabIndex = 4
        '
        'grilla_curso
        '
        Me.grilla_curso.AllowUserToAddRows = False
        Me.grilla_curso.AllowUserToDeleteRows = False
        Me.grilla_curso.AllowUserToResizeRows = False
        Me.grilla_curso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla_curso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_curso.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla_curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_curso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cd_curso, Me.cd_plan_estudio, Me.titulo, Me.nombre_profesor, Me.cd_matera, Me.nombre_materia, Me.anio, Me.fc_baja})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_curso.DefaultCellStyle = DataGridViewCellStyle2
        Me.grilla_curso.Location = New System.Drawing.Point(12, 138)
        Me.grilla_curso.MultiSelect = False
        Me.grilla_curso.Name = "grilla_curso"
        Me.grilla_curso.ReadOnly = True
        Me.grilla_curso.RowHeadersVisible = False
        Me.grilla_curso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla_curso.Size = New System.Drawing.Size(788, 207)
        Me.grilla_curso.TabIndex = 5
        '
        'cd_curso
        '
        Me.cd_curso.HeaderText = "Código de curso"
        Me.cd_curso.Name = "cd_curso"
        Me.cd_curso.ReadOnly = True
        '
        'cd_plan_estudio
        '
        Me.cd_plan_estudio.HeaderText = "Código de plan de estudio"
        Me.cd_plan_estudio.Name = "cd_plan_estudio"
        Me.cd_plan_estudio.ReadOnly = True
        '
        'titulo
        '
        Me.titulo.HeaderText = "Plan de estudio"
        Me.titulo.Name = "titulo"
        Me.titulo.ReadOnly = True
        '
        'nombre_profesor
        '
        Me.nombre_profesor.HeaderText = "Profesor"
        Me.nombre_profesor.Name = "nombre_profesor"
        Me.nombre_profesor.ReadOnly = True
        '
        'cd_matera
        '
        Me.cd_matera.HeaderText = "Código de materia"
        Me.cd_matera.Name = "cd_matera"
        Me.cd_matera.ReadOnly = True
        '
        'nombre_materia
        '
        Me.nombre_materia.HeaderText = "Materia"
        Me.nombre_materia.Name = "nombre_materia"
        Me.nombre_materia.ReadOnly = True
        '
        'anio
        '
        Me.anio.HeaderText = "Año lectivo"
        Me.anio.Name = "anio"
        Me.anio.ReadOnly = True
        '
        'fc_baja
        '
        Me.fc_baja.HeaderText = "Fecha de baja"
        Me.fc_baja.Name = "fc_baja"
        Me.fc_baja.ReadOnly = True
        '
        'check_estado
        '
        Me.check_estado.AutoSize = True
        Me.check_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_estado.Location = New System.Drawing.Point(456, 64)
        Me.check_estado.Name = "check_estado"
        Me.check_estado.Size = New System.Drawing.Size(137, 17)
        Me.check_estado.TabIndex = 6
        Me.check_estado.Text = "Solo cursos activos"
        Me.check_estado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Año lectivo:"
        '
        'txt_anio
        '
        Me.txt_anio.Location = New System.Drawing.Point(16, 112)
        Me.txt_anio.MaxLength = 4
        Me.txt_anio.Name = "txt_anio"
        Me.txt_anio.Size = New System.Drawing.Size(92, 20)
        Me.txt_anio.TabIndex = 8
        '
        'cb_materias
        '
        Me.cb_materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_materias.FormattingEnabled = True
        Me.cb_materias.Location = New System.Drawing.Point(144, 64)
        Me.cb_materias.Name = "cb_materias"
        Me.cb_materias.Size = New System.Drawing.Size(276, 21)
        Me.cb_materias.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Materia:"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_limpiar.Location = New System.Drawing.Point(644, 353)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 11
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
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Consulta de curso"
        '
        'cb_profesores
        '
        Me.cb_profesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_profesores.FormattingEnabled = True
        Me.cb_profesores.Location = New System.Drawing.Point(144, 112)
        Me.cb_profesores.Name = "cb_profesores"
        Me.cb_profesores.Size = New System.Drawing.Size(276, 21)
        Me.cb_profesores.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Profesor:"
        '
        'btn_ir
        '
        Me.btn_ir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ir.Image = Global.Sigal.My.Resources.Resources.bullet_go
        Me.btn_ir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ir.Location = New System.Drawing.Point(294, 353)
        Me.btn_ir.Name = "btn_ir"
        Me.btn_ir.Size = New System.Drawing.Size(75, 23)
        Me.btn_ir.TabIndex = 44
        Me.btn_ir.Text = "&Ir..."
        Me.btn_ir.UseVisualStyleBackColor = True
        '
        'cb_opciones
        '
        Me.cb_opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_opciones.FormattingEnabled = True
        Me.cb_opciones.Items.AddRange(New Object() {"Dar de alta un neuvo curso", "Eliminar el curso seleccionado", "Ver los detalles del curso seleccionado", "Ver las inscripciones al curso seleccionado"})
        Me.cb_opciones.Location = New System.Drawing.Point(12, 353)
        Me.cb_opciones.Name = "cb_opciones"
        Me.cb_opciones.Size = New System.Drawing.Size(276, 21)
        Me.cb_opciones.TabIndex = 43
        '
        'form_curso_search
        '
        Me.AcceptButton = Me.btn_buscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(812, 386)
        Me.Controls.Add(Me.btn_ir)
        Me.Controls.Add(Me.cb_opciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cb_profesores)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_materias)
        Me.Controls.Add(Me.txt_anio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.check_estado)
        Me.Controls.Add(Me.grilla_curso)
        Me.Controls.Add(Me.txt_cd_curso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(820, 420)
        Me.Name = "form_curso_search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de curso"
        CType(Me.grilla_curso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cd_curso As System.Windows.Forms.TextBox
    Friend WithEvents grilla_curso As System.Windows.Forms.DataGridView
    Friend WithEvents check_estado As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_anio As System.Windows.Forms.TextBox
    Friend WithEvents cb_materias As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cb_profesores As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cd_curso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd_plan_estudio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_profesor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd_matera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_materia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents anio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fc_baja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_ir As System.Windows.Forms.Button
    Friend WithEvents cb_opciones As System.Windows.Forms.ComboBox
End Class
