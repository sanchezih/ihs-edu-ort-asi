<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class __FormBusquedaInscripCurso
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
        Me.codInscripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.alumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Curso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxcurso = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(234, 20)
        Me.Label1.Text = "Busqueda Inscripción Curso"
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
        Me.ButtonBuscar.Location = New System.Drawing.Point(544, 30)
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
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonNuevoAlumno
        '
        Me.ButtonNuevoAlumno.Location = New System.Drawing.Point(63, 446)
        Me.ButtonNuevoAlumno.Name = "ButtonNuevoAlumno"
        Me.ButtonNuevoAlumno.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNuevoAlumno.TabIndex = 41
        Me.ButtonNuevoAlumno.Text = "Crear"
        Me.ButtonNuevoAlumno.UseVisualStyleBackColor = True
        '
        'ButtonEditar
        '
        Me.ButtonEditar.Location = New System.Drawing.Point(153, 446)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditar.TabIndex = 39
        Me.ButtonEditar.Text = "Editar"
        Me.ButtonEditar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codInscripcion, Me.alumno, Me.Curso, Me.fechaAlta})
        Me.DataGridView1.Location = New System.Drawing.Point(63, 101)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(642, 309)
        Me.DataGridView1.TabIndex = 40
        '
        'codInscripcion
        '
        Me.codInscripcion.HeaderText = "Cod Inscripción Curso"
        Me.codInscripcion.Name = "codInscripcion"
        Me.codInscripcion.ReadOnly = True
        '
        'alumno
        '
        Me.alumno.HeaderText = "Alumno"
        Me.alumno.Name = "alumno"
        Me.alumno.ReadOnly = True
        '
        'Curso
        '
        Me.Curso.HeaderText = "Curso"
        Me.Curso.Name = "Curso"
        Me.Curso.ReadOnly = True
        '
        'fechaAlta
        '
        Me.fechaAlta.HeaderText = "Fecha de Alta"
        Me.fechaAlta.Name = "fechaAlta"
        Me.fechaAlta.ReadOnly = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(626, 446)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Nombre materia"
        '
        'TextBoxcurso
        '
        Me.TextBoxcurso.Location = New System.Drawing.Point(252, 47)
        Me.TextBoxcurso.Name = "TextBoxcurso"
        Me.TextBoxcurso.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxcurso.TabIndex = 42
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TextBoxalumno)
        Me.GroupBox2.Controls.Add(Me.ButtonBuscar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(63, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 81)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(347, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Año"
        '
        'FormBusquedaInscripCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Name = "FormBusquedaInscripCurso"
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
    Friend WithEvents codInscripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents alumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Curso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaAlta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
