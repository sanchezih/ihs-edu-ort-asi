<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pmc_search
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.grilla_pmc = New System.Windows.Forms.DataGridView
        Me.cd_plan_estudio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cd_materia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre_materia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cuatrimestre_carrera = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cb_planes = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_cuatrimestre_carrera = New System.Windows.Forms.TextBox
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_limpiar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.btn_ir = New System.Windows.Forms.Button
        Me.cb_opciones = New System.Windows.Forms.ComboBox
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.grilla_pmc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'grilla_pmc
        '
        Me.grilla_pmc.AllowUserToAddRows = False
        Me.grilla_pmc.AllowUserToDeleteRows = False
        Me.grilla_pmc.AllowUserToResizeRows = False
        Me.grilla_pmc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla_pmc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_pmc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla_pmc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_pmc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cd_plan_estudio, Me.titulo, Me.cd_materia, Me.nombre_materia, Me.cuatrimestre_carrera})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_pmc.DefaultCellStyle = DataGridViewCellStyle2
        Me.grilla_pmc.Location = New System.Drawing.Point(12, 91)
        Me.grilla_pmc.MultiSelect = False
        Me.grilla_pmc.Name = "grilla_pmc"
        Me.grilla_pmc.ReadOnly = True
        Me.grilla_pmc.RowHeadersVisible = False
        Me.grilla_pmc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla_pmc.Size = New System.Drawing.Size(788, 254)
        Me.grilla_pmc.TabIndex = 3
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
        'cd_materia
        '
        Me.cd_materia.HeaderText = "Código de materia"
        Me.cd_materia.Name = "cd_materia"
        Me.cd_materia.ReadOnly = True
        '
        'nombre_materia
        '
        Me.nombre_materia.HeaderText = "Nombre de materia"
        Me.nombre_materia.Name = "nombre_materia"
        Me.nombre_materia.ReadOnly = True
        '
        'cuatrimestre_carrera
        '
        Me.cuatrimestre_carrera.HeaderText = "Cuatrimestre"
        Me.cuatrimestre_carrera.Name = "cuatrimestre_carrera"
        Me.cuatrimestre_carrera.ReadOnly = True
        '
        'cb_planes
        '
        Me.cb_planes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_planes.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_planes, "Seleccione aquí el plan de estudio para ver sus materias asociadas")
        Me.cb_planes.Location = New System.Drawing.Point(12, 64)
        Me.cb_planes.Name = "cb_planes"
        Me.HelpProvider1.SetShowHelp(Me.cb_planes, True)
        Me.cb_planes.Size = New System.Drawing.Size(276, 21)
        Me.cb_planes.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Plan de estudio:"
        '
        'txt_cuatrimestre_carrera
        '
        Me.HelpProvider1.SetHelpString(Me.txt_cuatrimestre_carrera, "Ingrese aquí el cuatrimestre del plan dee estudio. El mismo no puede ser mayor a " & _
                "6")
        Me.txt_cuatrimestre_carrera.Location = New System.Drawing.Point(323, 65)
        Me.txt_cuatrimestre_carrera.MaxLength = 1
        Me.txt_cuatrimestre_carrera.Name = "txt_cuatrimestre_carrera"
        Me.HelpProvider1.SetShowHelp(Me.txt_cuatrimestre_carrera, True)
        Me.txt_cuatrimestre_carrera.Size = New System.Drawing.Size(92, 20)
        Me.txt_cuatrimestre_carrera.TabIndex = 6
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cuatrimestre:"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_limpiar.Location = New System.Drawing.Point(644, 353)
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
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Consulta de asignación plan - materia"
        '
        'btn_ir
        '
        Me.btn_ir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ir.Image = Global.Sigal.My.Resources.Resources.bullet_go
        Me.btn_ir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ir.Location = New System.Drawing.Point(294, 353)
        Me.btn_ir.Name = "btn_ir"
        Me.btn_ir.Size = New System.Drawing.Size(75, 23)
        Me.btn_ir.TabIndex = 28
        Me.btn_ir.Text = "&Ir..."
        Me.btn_ir.UseVisualStyleBackColor = True
        '
        'cb_opciones
        '
        Me.cb_opciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_opciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_opciones.FormattingEnabled = True
        Me.cb_opciones.Items.AddRange(New Object() {"Dar de alta una nueva asignación", "Eliminar la asignación seleccionada"})
        Me.cb_opciones.Location = New System.Drawing.Point(12, 353)
        Me.cb_opciones.Name = "cb_opciones"
        Me.cb_opciones.Size = New System.Drawing.Size(276, 21)
        Me.cb_opciones.TabIndex = 27
        '
        'form_pmc_search
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
        Me.Controls.Add(Me.txt_cuatrimestre_carrera)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_planes)
        Me.Controls.Add(Me.grilla_pmc)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.MinimumSize = New System.Drawing.Size(820, 420)
        Me.Name = "form_pmc_search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de asignación plan - materia"
        CType(Me.grilla_pmc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents grilla_pmc As System.Windows.Forms.DataGridView
    Friend WithEvents cb_planes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cd_plan_estudio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd_materia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre_materia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuatrimestre_carrera As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_cuatrimestre_carrera As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_ir As System.Windows.Forms.Button
    Friend WithEvents cb_opciones As System.Windows.Forms.ComboBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
