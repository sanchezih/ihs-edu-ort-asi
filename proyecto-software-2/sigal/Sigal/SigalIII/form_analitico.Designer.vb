<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_analitico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_analitico))
        Me.grilla_analitico = New System.Windows.Forms.DataGridView
        Me.cd_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.an = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cd_materia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cd_curso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cd_estado_materia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fc_ultima_modificacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_cd_alumno = New System.Windows.Forms.TextBox
        Me.btn_cerrar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_nombre_alumno = New System.Windows.Forms.TextBox
        Me.txt_apellido_alumno = New System.Windows.Forms.TextBox
        Me.lbl_apellido_alumno = New System.Windows.Forms.Label
        Me.lbl_nombre_alumno = New System.Windows.Forms.Label
        Me.btn_limpiar = New System.Windows.Forms.Button
        CType(Me.grilla_analitico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grilla_analitico
        '
        Me.grilla_analitico.AllowUserToAddRows = False
        Me.grilla_analitico.AllowUserToDeleteRows = False
        Me.grilla_analitico.AllowUserToResizeRows = False
        Me.grilla_analitico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla_analitico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_analitico.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grilla_analitico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_analitico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cd_alumno, Me.an, Me.cd_materia, Me.cd_curso, Me.cd_estado_materia, Me.fc_ultima_modificacion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_analitico.DefaultCellStyle = DataGridViewCellStyle2
        Me.grilla_analitico.Location = New System.Drawing.Point(12, 88)
        Me.grilla_analitico.MultiSelect = False
        Me.grilla_analitico.Name = "grilla_analitico"
        Me.grilla_analitico.ReadOnly = True
        Me.grilla_analitico.RowHeadersVisible = False
        Me.grilla_analitico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grilla_analitico.Size = New System.Drawing.Size(788, 257)
        Me.grilla_analitico.TabIndex = 0
        '
        'cd_alumno
        '
        Me.cd_alumno.HeaderText = "Código de alumno"
        Me.cd_alumno.Name = "cd_alumno"
        Me.cd_alumno.ReadOnly = True
        '
        'an
        '
        Me.an.HeaderText = "Apellido y nombre"
        Me.an.Name = "an"
        Me.an.ReadOnly = True
        '
        'cd_materia
        '
        Me.cd_materia.HeaderText = "Código de materia"
        Me.cd_materia.Name = "cd_materia"
        Me.cd_materia.ReadOnly = True
        '
        'cd_curso
        '
        Me.cd_curso.HeaderText = "Código de curso"
        Me.cd_curso.Name = "cd_curso"
        Me.cd_curso.ReadOnly = True
        '
        'cd_estado_materia
        '
        Me.cd_estado_materia.HeaderText = "Estado de la materia"
        Me.cd_estado_materia.Name = "cd_estado_materia"
        Me.cd_estado_materia.ReadOnly = True
        '
        'fc_ultima_modificacion
        '
        Me.fc_ultima_modificacion.HeaderText = "Fecha de ultima modificación"
        Me.fc_ultima_modificacion.Name = "fc_ultima_modificacion"
        Me.fc_ultima_modificacion.ReadOnly = True
        '
        'btn_buscar
        '
        Me.btn_buscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_buscar.Location = New System.Drawing.Point(725, 58)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.Text = "&Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código de alumno:"
        '
        'txt_cd_alumno
        '
        Me.txt_cd_alumno.Location = New System.Drawing.Point(12, 60)
        Me.txt_cd_alumno.Name = "txt_cd_alumno"
        Me.txt_cd_alumno.Size = New System.Drawing.Size(92, 20)
        Me.txt_cd_alumno.TabIndex = 3
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cerrar.Location = New System.Drawing.Point(725, 351)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 4
        Me.btn_cerrar.Text = "&Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
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
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Informes analíticos"
        '
        'txt_nombre_alumno
        '
        Me.txt_nombre_alumno.Location = New System.Drawing.Point(371, 61)
        Me.txt_nombre_alumno.MaxLength = 100
        Me.txt_nombre_alumno.Name = "txt_nombre_alumno"
        Me.txt_nombre_alumno.Size = New System.Drawing.Size(184, 20)
        Me.txt_nombre_alumno.TabIndex = 8
        '
        'txt_apellido_alumno
        '
        Me.txt_apellido_alumno.Location = New System.Drawing.Point(147, 60)
        Me.txt_apellido_alumno.MaxLength = 100
        Me.txt_apellido_alumno.Name = "txt_apellido_alumno"
        Me.txt_apellido_alumno.Size = New System.Drawing.Size(184, 20)
        Me.txt_apellido_alumno.TabIndex = 7
        '
        'lbl_apellido_alumno
        '
        Me.lbl_apellido_alumno.AutoSize = True
        Me.lbl_apellido_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido_alumno.Location = New System.Drawing.Point(144, 46)
        Me.lbl_apellido_alumno.Name = "lbl_apellido_alumno"
        Me.lbl_apellido_alumno.Size = New System.Drawing.Size(56, 13)
        Me.lbl_apellido_alumno.TabIndex = 10
        Me.lbl_apellido_alumno.Text = "Apellido:"
        '
        'lbl_nombre_alumno
        '
        Me.lbl_nombre_alumno.AutoSize = True
        Me.lbl_nombre_alumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_alumno.Location = New System.Drawing.Point(368, 45)
        Me.lbl_nombre_alumno.Name = "lbl_nombre_alumno"
        Me.lbl_nombre_alumno.Size = New System.Drawing.Size(54, 13)
        Me.lbl_nombre_alumno.TabIndex = 9
        Me.lbl_nombre_alumno.Text = "Nombre:"
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_limpiar.Location = New System.Drawing.Point(644, 351)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_limpiar.TabIndex = 11
        Me.btn_limpiar.Text = "&Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'form_analitico
        '
        Me.AcceptButton = Me.btn_buscar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_cerrar
        Me.ClientSize = New System.Drawing.Size(812, 386)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.txt_nombre_alumno)
        Me.Controls.Add(Me.txt_apellido_alumno)
        Me.Controls.Add(Me.lbl_apellido_alumno)
        Me.Controls.Add(Me.lbl_nombre_alumno)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.txt_cd_alumno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.grilla_analitico)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(820, 420)
        Me.Name = "form_analitico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes analíticos"
        CType(Me.grilla_analitico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grilla_analitico As System.Windows.Forms.DataGridView
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cd_alumno As System.Windows.Forms.TextBox
    Friend WithEvents btn_cerrar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_alumno As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido_alumno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_apellido_alumno As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_alumno As System.Windows.Forms.Label
    Friend WithEvents cd_alumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents an As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd_materia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd_curso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cd_estado_materia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fc_ultima_modificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
End Class
