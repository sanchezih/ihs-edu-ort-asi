<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_calificacion_cursada_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_calificacion_cursada_alta))
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cb_planes = New System.Windows.Forms.ComboBox
        Me.cb_cursos = New System.Windows.Forms.ComboBox
        Me.lb_alumnos = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_libro = New System.Windows.Forms.TextBox
        Me.txt_folio = New System.Windows.Forms.TextBox
        Me.txt_calificacion = New System.Windows.Forms.TextBox
        Me.cb_base_calificacion = New System.Windows.Forms.ComboBox
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.HelpProvider1.SetHelpString(Me.btn_aceptar, "Presione aquí para efectuar la operación")
        Me.btn_aceptar.Location = New System.Drawing.Point(200, 440)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.HelpProvider1.SetShowHelp(Me.btn_aceptar, True)
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 0
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btn_cancelar, "Presione aquí para cancelar la operación")
        Me.btn_cancelar.Location = New System.Drawing.Point(288, 440)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.HelpProvider1.SetShowHelp(Me.btn_cancelar, True)
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 1
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
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Plan de estudio:"
        '
        'cb_planes
        '
        Me.cb_planes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_planes.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_planes, "Seleccione aquí el plan de estudio de la calificación de cursada")
        Me.cb_planes.Location = New System.Drawing.Point(8, 40)
        Me.cb_planes.Name = "cb_planes"
        Me.HelpProvider1.SetShowHelp(Me.cb_planes, True)
        Me.cb_planes.Size = New System.Drawing.Size(276, 21)
        Me.cb_planes.TabIndex = 3
        '
        'cb_cursos
        '
        Me.cb_cursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cursos.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_cursos, "Seleccione aquí el curso de la calificación de cursada")
        Me.cb_cursos.Location = New System.Drawing.Point(8, 88)
        Me.cb_cursos.Name = "cb_cursos"
        Me.HelpProvider1.SetShowHelp(Me.cb_cursos, True)
        Me.cb_cursos.Size = New System.Drawing.Size(276, 21)
        Me.cb_cursos.TabIndex = 4
        '
        'lb_alumnos
        '
        Me.lb_alumnos.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.lb_alumnos, "Seleccione aquí el alumno al cual se le ingresara la calificación")
        Me.lb_alumnos.Location = New System.Drawing.Point(8, 136)
        Me.lb_alumnos.Name = "lb_alumnos"
        Me.HelpProvider1.SetShowHelp(Me.lb_alumnos, True)
        Me.lb_alumnos.Size = New System.Drawing.Size(276, 134)
        Me.lb_alumnos.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Curso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Alumno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Libro:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(224, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Folio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Base calificación:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Calificación:"
        '
        'txt_libro
        '
        Me.HelpProvider1.SetHelpString(Me.txt_libro, "Ingrese aquí el código del libro en el cual se registrara la calificación del alu" & _
                "mno")
        Me.txt_libro.Location = New System.Drawing.Point(8, 296)
        Me.txt_libro.Name = "txt_libro"
        Me.HelpProvider1.SetShowHelp(Me.txt_libro, True)
        Me.txt_libro.Size = New System.Drawing.Size(92, 20)
        Me.txt_libro.TabIndex = 12
        '
        'txt_folio
        '
        Me.HelpProvider1.SetHelpString(Me.txt_folio, "Ingrese aquí el código del folio en el cual se registrara la calificación del alu" & _
                "mno")
        Me.txt_folio.Location = New System.Drawing.Point(224, 296)
        Me.txt_folio.Name = "txt_folio"
        Me.HelpProvider1.SetShowHelp(Me.txt_folio, True)
        Me.txt_folio.Size = New System.Drawing.Size(92, 20)
        Me.txt_folio.TabIndex = 13
        '
        'txt_calificacion
        '
        Me.HelpProvider1.SetHelpString(Me.txt_calificacion, "Ingrese aquí la calificación del alumno para el curso seleccionado. La misma debe" & _
                "ra ser entre 0 y 10")
        Me.txt_calificacion.Location = New System.Drawing.Point(224, 344)
        Me.txt_calificacion.Name = "txt_calificacion"
        Me.HelpProvider1.SetShowHelp(Me.txt_calificacion, True)
        Me.txt_calificacion.Size = New System.Drawing.Size(92, 20)
        Me.txt_calificacion.TabIndex = 14
        '
        'cb_base_calificacion
        '
        Me.cb_base_calificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_base_calificacion.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cb_base_calificacion, resources.GetString("cb_base_calificacion.HelpString"))
        Me.cb_base_calificacion.Items.AddRange(New Object() {"Cursada", "Promoción directa", "Libre", "Equivalencia"})
        Me.cb_base_calificacion.Location = New System.Drawing.Point(8, 344)
        Me.cb_base_calificacion.Name = "cb_base_calificacion"
        Me.HelpProvider1.SetShowHelp(Me.cb_base_calificacion, True)
        Me.cb_base_calificacion.Size = New System.Drawing.Size(182, 21)
        Me.cb_base_calificacion.TabIndex = 15
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_planes)
        Me.GroupBox1.Controls.Add(Me.cb_base_calificacion)
        Me.GroupBox1.Controls.Add(Me.cb_cursos)
        Me.GroupBox1.Controls.Add(Me.txt_calificacion)
        Me.GroupBox1.Controls.Add(Me.lb_alumnos)
        Me.GroupBox1.Controls.Add(Me.txt_folio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_libro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 376)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la calificación"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.SandyBrown
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(16, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(344, 22)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Alta de calificación de cursada"
        '
        'form_calificacion_cursada_alta
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(371, 474)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_calificacion_cursada_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de calificación de cursada"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_planes As System.Windows.Forms.ComboBox
    Friend WithEvents cb_cursos As System.Windows.Forms.ComboBox
    Friend WithEvents lb_alumnos As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_libro As System.Windows.Forms.TextBox
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents txt_calificacion As System.Windows.Forms.TextBox
    Friend WithEvents cb_base_calificacion As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
