<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class __FormCalificacionFinal
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
        Me.TextBoxalumno = New System.Windows.Forms.TextBox
        Me.ButtonBuscar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ButtonNuevoAlumno = New System.Windows.Forms.Button
        Me.ButtonEditar = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.alumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.planEstudio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.libro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.folio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Curso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxcurso = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(231, 20)
        Me.Label1.Text = "Busqueda Calificación Final"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ButtonNuevoAlumno)
        Me.GroupBox1.Controls.Add(Me.ButtonEditar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxcurso)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        '
        'TextBoxalumno
        '
        Me.TextBoxalumno.Location = New System.Drawing.Point(18, 33)
        Me.TextBoxalumno.Name = "TextBoxalumno"
        Me.TextBoxalumno.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxalumno.TabIndex = 6
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(563, 29)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBuscar.TabIndex = 0
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Legajo Alumno"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 446)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonNuevoAlumno
        '
        Me.ButtonNuevoAlumno.Location = New System.Drawing.Point(63, 446)
        Me.ButtonNuevoAlumno.Name = "ButtonNuevoAlumno"
        Me.ButtonNuevoAlumno.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNuevoAlumno.TabIndex = 25
        Me.ButtonNuevoAlumno.Text = "Crear"
        Me.ButtonNuevoAlumno.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Location = New System.Drawing.Point(153, 446)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditar.TabIndex = 23
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.alumno, Me.planEstudio, Me.libro, Me.folio, Me.fecha, Me.Curso})
        Me.DataGridView1.Location = New System.Drawing.Point(63, 101)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(642, 309)
        Me.DataGridView1.TabIndex = 24
        '
        'alumno
        '
        Me.alumno.HeaderText = "Alumno"
        Me.alumno.Name = "alumno"
        '
        'planEstudio
        '
        Me.planEstudio.HeaderText = "Plan de Estudio"
        Me.planEstudio.Name = "planEstudio"
        '
        'libro
        '
        Me.libro.HeaderText = "Libro"
        Me.libro.Name = "libro"
        '
        'folio
        '
        Me.folio.HeaderText = "Folio"
        Me.folio.Name = "folio"
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha examen final"
        Me.fecha.Name = "fecha"
        '
        'Curso
        '
        Me.Curso.HeaderText = "Curso"
        Me.Curso.Name = "Curso"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(626, 446)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Cod Curso"
        '
        'TextBoxcurso
        '
        Me.TextBoxcurso.Location = New System.Drawing.Point(252, 47)
        Me.TextBoxcurso.Name = "TextBoxcurso"
        Me.TextBoxcurso.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxcurso.TabIndex = 26
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TextBoxalumno)
        Me.GroupBox2.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(63, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 81)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'FormCalificacionFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Name = "FormCalificacionFinal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonNuevoAlumno As System.Windows.Forms.Button
    Friend WithEvents ButtonEditar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxcurso As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxalumno As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents alumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents planEstudio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents libro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents folio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Curso As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
