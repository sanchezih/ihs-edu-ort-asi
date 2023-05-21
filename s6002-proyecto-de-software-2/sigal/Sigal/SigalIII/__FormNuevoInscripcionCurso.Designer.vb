<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class __FormNuevoInscripcionCurso
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
        Me.ButtonCancelar = New System.Windows.Forms.Button
        Me.ButtonCrear = New System.Windows.Forms.Button
        Me.ComboBoxAlumno = New System.Windows.Forms.ComboBox
        Me.ComboBoxCurso = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBoxPlan = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.Text = "Inscripción a curso"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxPlan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ButtonCancelar)
        Me.GroupBox1.Controls.Add(Me.ButtonCrear)
        Me.GroupBox1.Controls.Add(Me.ComboBoxAlumno)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCurso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.Location = New System.Drawing.Point(124, 430)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelar.TabIndex = 113
        Me.ButtonCancelar.Text = "Cancelar"
        Me.ButtonCancelar.UseVisualStyleBackColor = True
        '
        'ButtonCrear
        '
        Me.ButtonCrear.Location = New System.Drawing.Point(27, 430)
        Me.ButtonCrear.Name = "ButtonCrear"
        Me.ButtonCrear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCrear.TabIndex = 112
        Me.ButtonCrear.Text = "Crear"
        Me.ButtonCrear.UseVisualStyleBackColor = True
        '
        'ComboBoxAlumno
        '
        Me.ComboBoxAlumno.FormattingEnabled = True
        Me.ComboBoxAlumno.Location = New System.Drawing.Point(119, 19)
        Me.ComboBoxAlumno.Name = "ComboBoxAlumno"
        Me.ComboBoxAlumno.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxAlumno.TabIndex = 111
        '
        'ComboBoxCurso
        '
        Me.ComboBoxCurso.FormattingEnabled = True
        Me.ComboBoxCurso.Location = New System.Drawing.Point(119, 75)
        Me.ComboBoxCurso.Name = "ComboBoxCurso"
        Me.ComboBoxCurso.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxCurso.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Alumno:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Curso:"
        '
        'ComboBoxPlan
        '
        Me.ComboBoxPlan.FormattingEnabled = True
        Me.ComboBoxPlan.Location = New System.Drawing.Point(119, 48)
        Me.ComboBoxPlan.Name = "ComboBoxPlan"
        Me.ComboBoxPlan.Size = New System.Drawing.Size(160, 21)
        Me.ComboBoxPlan.TabIndex = 115
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Plan de estudio:"
        '
        'FormNuevoInscripcionCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Name = "FormNuevoInscripcionCurso"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonCancelar As System.Windows.Forms.Button
    Friend WithEvents ButtonCrear As System.Windows.Forms.Button
    Friend WithEvents ComboBoxAlumno As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxPlan As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
