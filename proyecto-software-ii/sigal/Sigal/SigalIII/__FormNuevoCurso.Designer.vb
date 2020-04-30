<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class __FormNuevoCurso
    Inherits Sigal.__Plantilla

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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.MaskedTextBoxAnio = New System.Windows.Forms.MaskedTextBox
        Me.ComboBoxPlan = New System.Windows.Forms.ComboBox
        Me.ComboBoxCuatri = New System.Windows.Forms.ComboBox
        Me.ComboBoxProfe = New System.Windows.Forms.ComboBox
        Me.ComboBoxMateria = New System.Windows.Forms.ComboBox
        Me.ButtonCancelar = New System.Windows.Forms.Button
        Me.ButtonCrear = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.Text = "Alta de Curso"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonCancelar)
        Me.GroupBox1.Controls.Add(Me.ButtonCrear)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMateria)
        Me.GroupBox1.Controls.Add(Me.ComboBoxProfe)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCuatri)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPlan)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBoxAnio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Size = New System.Drawing.Size(355, 254)
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Cod Plan Estudio:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Materia :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Profesor :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Año :"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Cuatrimestre:"
        '
        'MaskedTextBoxAnio
        '
        Me.MaskedTextBoxAnio.Location = New System.Drawing.Point(131, 116)
        Me.MaskedTextBoxAnio.Mask = "9999"
        Me.MaskedTextBoxAnio.Name = "MaskedTextBoxAnio"
        Me.MaskedTextBoxAnio.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxAnio.TabIndex = 89
        '
        'ComboBoxPlan
        '
        Me.ComboBoxPlan.FormattingEnabled = True
        Me.ComboBoxPlan.Location = New System.Drawing.Point(131, 33)
        Me.ComboBoxPlan.Name = "ComboBoxPlan"
        Me.ComboBoxPlan.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxPlan.TabIndex = 90
        '
        'ComboBoxCuatri
        '
        Me.ComboBoxCuatri.FormattingEnabled = True
        Me.ComboBoxCuatri.Items.AddRange(New Object() {"1", "2"})
        Me.ComboBoxCuatri.Location = New System.Drawing.Point(131, 143)
        Me.ComboBoxCuatri.Name = "ComboBoxCuatri"
        Me.ComboBoxCuatri.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxCuatri.TabIndex = 91
        '
        'ComboBoxProfe
        '
        Me.ComboBoxProfe.FormattingEnabled = True
        Me.ComboBoxProfe.Location = New System.Drawing.Point(131, 86)
        Me.ComboBoxProfe.Name = "ComboBoxProfe"
        Me.ComboBoxProfe.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxProfe.TabIndex = 92
        '
        'ComboBoxMateria
        '
        Me.ComboBoxMateria.FormattingEnabled = True
        Me.ComboBoxMateria.Location = New System.Drawing.Point(131, 61)
        Me.ComboBoxMateria.Name = "ComboBoxMateria"
        Me.ComboBoxMateria.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxMateria.TabIndex = 93
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(149, 197)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 95
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonCrear
        '
        Me.ButtonCrear.Location = New System.Drawing.Point(52, 197)
        Me.ButtonCrear.Name = "ButtonCrear"
        Me.ButtonCrear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCrear.TabIndex = 94
        Me.ButtonCrear.Text = "Crear"
        Me.ButtonCrear.UseVisualStyleBackColor = True
        '
        'FormNuevoCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(379, 337)
        Me.Name = "FormNuevoCurso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMateria As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxProfe As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxCuatri As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPlan As System.Windows.Forms.ComboBox
    Friend WithEvents MaskedTextBoxAnio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents ButtonCrear As System.Windows.Forms.Button

End Class
