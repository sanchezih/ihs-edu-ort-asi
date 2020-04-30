<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_materia_alta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_materia_alta))
        Me.btn_aceptar = New System.Windows.Forms.Button
        Me.btn_cancelar = New System.Windows.Forms.Button
        Me.txt_nombre_materia = New System.Windows.Forms.TextBox
        Me.lbl_nombre_materia = New System.Windows.Forms.Label
        Me.lbl_cd_materia = New System.Windows.Forms.Label
        Me.txt_cd_materia = New System.Windows.Forms.TextBox
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_aceptar
        '
        Me.HelpProvider1.SetHelpString(Me.btn_aceptar, "Presione aquí para efectuar la operación")
        Me.btn_aceptar.Location = New System.Drawing.Point(80, 184)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.HelpProvider1.SetShowHelp(Me.btn_aceptar, True)
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 2
        Me.btn_aceptar.Text = "&Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HelpProvider1.SetHelpString(Me.btn_cancelar, "Presione aquí para cancelar la operación")
        Me.btn_cancelar.Location = New System.Drawing.Point(168, 184)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.HelpProvider1.SetShowHelp(Me.btn_cancelar, True)
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "&Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'txt_nombre_materia
        '
        Me.HelpProvider1.SetHelpString(Me.txt_nombre_materia, "Ingrese aquí el nombre de la materia")
        Me.txt_nombre_materia.Location = New System.Drawing.Point(8, 88)
        Me.txt_nombre_materia.MaxLength = 100
        Me.txt_nombre_materia.Name = "txt_nombre_materia"
        Me.HelpProvider1.SetShowHelp(Me.txt_nombre_materia, True)
        Me.txt_nombre_materia.Size = New System.Drawing.Size(184, 20)
        Me.txt_nombre_materia.TabIndex = 1
        '
        'lbl_nombre_materia
        '
        Me.lbl_nombre_materia.AutoSize = True
        Me.lbl_nombre_materia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_materia.Location = New System.Drawing.Point(8, 72)
        Me.lbl_nombre_materia.Name = "lbl_nombre_materia"
        Me.lbl_nombre_materia.Size = New System.Drawing.Size(113, 13)
        Me.lbl_nombre_materia.TabIndex = 3
        Me.lbl_nombre_materia.Text = "Nombrede materia:"
        '
        'lbl_cd_materia
        '
        Me.lbl_cd_materia.AutoSize = True
        Me.lbl_cd_materia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cd_materia.Location = New System.Drawing.Point(8, 24)
        Me.lbl_cd_materia.Name = "lbl_cd_materia"
        Me.lbl_cd_materia.Size = New System.Drawing.Size(113, 13)
        Me.lbl_cd_materia.TabIndex = 4
        Me.lbl_cd_materia.Text = "Código de materia:"
        '
        'txt_cd_materia
        '
        Me.HelpProvider1.SetHelpString(Me.txt_cd_materia, "Ingrese aquí el código de la materia")
        Me.txt_cd_materia.Location = New System.Drawing.Point(8, 40)
        Me.txt_cd_materia.MaxLength = 6
        Me.txt_cd_materia.Name = "txt_cd_materia"
        Me.HelpProvider1.SetShowHelp(Me.txt_cd_materia, True)
        Me.txt_cd_materia.Size = New System.Drawing.Size(184, 20)
        Me.txt_cd_materia.TabIndex = 0
        Me.txt_cd_materia.Tag = ""
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
        Me.Label8.Size = New System.Drawing.Size(224, 22)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Alta de materia"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_nombre_materia)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre_materia)
        Me.GroupBox1.Controls.Add(Me.txt_cd_materia)
        Me.GroupBox1.Controls.Add(Me.lbl_cd_materia)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 120)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la materia"
        '
        'form_materia_alta
        '
        Me.AcceptButton = Me.btn_aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cancelar
        Me.ClientSize = New System.Drawing.Size(251, 218)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_materia_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de materia"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_nombre_materia As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre_materia As System.Windows.Forms.Label
    Friend WithEvents lbl_cd_materia As System.Windows.Forms.Label
    Friend WithEvents txt_cd_materia As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
