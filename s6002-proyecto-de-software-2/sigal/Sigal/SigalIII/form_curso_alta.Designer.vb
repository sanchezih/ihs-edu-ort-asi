<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_curso_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_curso_alta))
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_anio = New System.Windows.Forms.TextBox
        Me.cb_planes = New System.Windows.Forms.ComboBox
        Me.cb_materias = New System.Windows.Forms.ComboBox
        Me.cb_profesores = New System.Windows.Forms.ComboBox
        Me.cb_semestres = New System.Windows.Forms.ComboBox
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.HelpProvider1.SetHelpString(Me.btn_aceptar, "Presione aquí para efectuar la operación")
        Me.btn_aceptar.Location = New System.Drawing.Point(168, 280)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.HelpProvider1.SetShowHelp(Me.btn_aceptar, True)
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 6
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btn_cancelar, "Presione aquí para cancelar la operación")
        Me.btn_cancelar.Location = New System.Drawing.Point(256, 280)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.HelpProvider1.SetShowHelp(Me.btn_cancelar, True)
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 7
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
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plan de estudio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Materia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Profesor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Semestre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Año lectivo:"
        '
        'txt_anio
        '
        Me.HelpProvider1.SetHelpString(Me.txt_anio, "Ingrese aquí el año lectivo en que se dictara el curso")
        Me.txt_anio.Location = New System.Drawing.Point(136, 184)
        Me.txt_anio.MaxLength = 4
        Me.txt_anio.Name = "txt_anio"
        Me.HelpProvider1.SetShowHelp(Me.txt_anio, True)
        Me.txt_anio.Size = New System.Drawing.Size(92, 20)
        Me.txt_anio.TabIndex = 5
        Me.txt_anio.Tag = ""
        '
        'cb_planes
        '
        Me.cb_planes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_planes.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_planes, "Seleccione aquí el plan de estudio del curso")
        Me.cb_planes.Location = New System.Drawing.Point(8, 40)
        Me.cb_planes.Name = "cb_planes"
        Me.HelpProvider1.SetShowHelp(Me.cb_planes, True)
        Me.cb_planes.Size = New System.Drawing.Size(276, 21)
        Me.cb_planes.TabIndex = 1
        '
        'cb_materias
        '
        Me.cb_materias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_materias.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_materias, "Seleccione aquí la materia que se dictara en el curso")
        Me.cb_materias.Location = New System.Drawing.Point(8, 88)
        Me.cb_materias.Name = "cb_materias"
        Me.HelpProvider1.SetShowHelp(Me.cb_materias, True)
        Me.cb_materias.Size = New System.Drawing.Size(276, 21)
        Me.cb_materias.TabIndex = 2
        '
        'cb_profesores
        '
        Me.cb_profesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_profesores.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_profesores, "Seleccione aquí el profesor que dictara el curso")
        Me.cb_profesores.Location = New System.Drawing.Point(8, 136)
        Me.cb_profesores.Name = "cb_profesores"
        Me.HelpProvider1.SetShowHelp(Me.cb_profesores, True)
        Me.cb_profesores.Size = New System.Drawing.Size(276, 21)
        Me.cb_profesores.TabIndex = 3
        '
        'cb_semestres
        '
        Me.cb_semestres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_semestres.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_semestres, "Seleccione aquí en que semestre del año se dictara el curso")
        Me.cb_semestres.Items.AddRange(New Object() {"1", "2"})
        Me.cb_semestres.Location = New System.Drawing.Point(8, 184)
        Me.cb_semestres.Name = "cb_semestres"
        Me.HelpProvider1.SetShowHelp(Me.cb_semestres, True)
        Me.cb_semestres.Size = New System.Drawing.Size(92, 21)
        Me.cb_semestres.TabIndex = 4
        Me.cb_semestres.Tag = ""
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
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
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Alta de curso"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cb_semestres)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cb_profesores)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cb_materias)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cb_planes)
        Me.GroupBox1.Controls.Add(Me.txt_anio)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 216)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del curso"
        '
        'form_curso_alta
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(339, 314)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_curso_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de curso"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_anio As System.Windows.Forms.TextBox
    Friend WithEvents cb_planes As System.Windows.Forms.ComboBox
    Friend WithEvents cb_materias As System.Windows.Forms.ComboBox
    Friend WithEvents cb_profesores As System.Windows.Forms.ComboBox
    Friend WithEvents cb_semestres As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
