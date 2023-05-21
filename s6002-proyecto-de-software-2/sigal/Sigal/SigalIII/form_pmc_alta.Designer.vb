<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_pmc_alta
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
        Me.cb_planes = New System.Windows.Forms.ComboBox
        Me.lb_materias = New System.Windows.Forms.ListBox
        Me.cb_cuatrimestres = New System.Windows.Forms.ComboBox
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_planes
        '
        Me.cb_planes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_planes.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_planes, "Seleccione aquí el plan de estudio al que se le asignarán materias")
        Me.cb_planes.Location = New System.Drawing.Point(8, 40)
        Me.cb_planes.Name = "cb_planes"
        Me.HelpProvider1.SetShowHelp(Me.cb_planes, True)
        Me.cb_planes.Size = New System.Drawing.Size(276, 21)
        Me.cb_planes.TabIndex = 0
        '
        'lb_materias
        '
        Me.lb_materias.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.lb_materias, "Seleccione aquí las materias que se asignarán al plan de estudio seleccionado")
        Me.lb_materias.Location = New System.Drawing.Point(8, 136)
        Me.lb_materias.Name = "lb_materias"
        Me.lb_materias.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.HelpProvider1.SetShowHelp(Me.lb_materias, True)
        Me.lb_materias.Size = New System.Drawing.Size(276, 134)
        Me.lb_materias.TabIndex = 1
        '
        'cb_cuatrimestres
        '
        Me.cb_cuatrimestres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cuatrimestres.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_cuatrimestres, "Seleccione aquí el cuatrimestre en que se cursaran las materias seleccionadas")
        Me.cb_cuatrimestres.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cb_cuatrimestres.Location = New System.Drawing.Point(8, 88)
        Me.cb_cuatrimestres.Name = "cb_cuatrimestres"
        Me.HelpProvider1.SetShowHelp(Me.cb_cuatrimestres, True)
        Me.cb_cuatrimestres.Size = New System.Drawing.Size(92, 21)
        Me.cb_cuatrimestres.TabIndex = 2
        '
        'btn_aceptar
        '
        Me.HelpProvider1.SetHelpString(Me.btn_aceptar, "Presione aquí para efectuar la operación")
        Me.btn_aceptar.Location = New System.Drawing.Point(168, 344)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.HelpProvider1.SetShowHelp(Me.btn_aceptar, True)
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 3
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btn_cancelar, "Presione aquí para cancelar la operación")
        Me.btn_cancelar.Location = New System.Drawing.Point(256, 344)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.HelpProvider1.SetShowHelp(Me.btn_cancelar, True)
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Plan de estudio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Cuatrimestre:"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Materia/s:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SandyBrown
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(312, 22)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Alta de asignación plan - materia"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_planes)
        Me.GroupBox1.Controls.Add(Me.cb_cuatrimestres)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lb_materias)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 280)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la asignación plan - materia"
        '
        'form_pmc_alta
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(338, 378)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_pmc_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de asignación plan - materia"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cb_planes As System.Windows.Forms.ComboBox
    Friend WithEvents lb_materias As System.Windows.Forms.ListBox
    Friend WithEvents cb_cuatrimestres As System.Windows.Forms.ComboBox
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
