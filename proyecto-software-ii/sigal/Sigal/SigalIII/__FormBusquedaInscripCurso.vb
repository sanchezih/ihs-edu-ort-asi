Public Class __FormBusquedaInscripCurso

    Private mCancelado As Boolean = True
    'indica si la operación fue cancelada
    Public Property Cancelado() As Boolean
        Get
            Return mCancelado
        End Get
        Set(ByVal value As Boolean)
            mCancelado = value
        End Set
    End Property

    'Cancela la operacion
    Private Sub CerrarOperacion()
        'cancelo la operación y retorno al formulario llamador
        Cancelado = True
        Me.Hide()
    End Sub
    'Creo un nuevo plan
    Private Sub NuevoInscripcionCurso()
        'creo nueva instancia de formulario para dar de alta de plan
        Dim ofrmNuevoAlu As __FormNuevoInscripcionCurso
        ofrmNuevoAlu = New __FormNuevoInscripcionCurso

        'muestro el formulario de manera modal
        ofrmNuevoAlu.ShowDialog()

        'cierro formulario
        ofrmNuevoAlu.Close()

        'elimino instancia
        ofrmNuevoAlu = Nothing

        'si todo estuvo bien recargo la grilla
        Buscar()

    End Sub
    'busca alumnos en funcion de lo datos del filtro
    Private Sub Buscar()
        '  Dim oAlumnos As New List(Of Entidades.Alumno)
        '  Dim oAlumnosNegocio As New Negocio.Alumnos
        ' Dim apellido As String
        'Dim nombre As String
        'Dim cdalumno As String

        '     apellido = TextBoxApellido.Text
        '      nombre = TextBoxNombre.Text
        '    cdalumno = TextBoxLegajo.Text

        '   Try
        'oAlumnos = oAlumnosNegocio.GetAllByNombreApellido(cdalumno, nombre, apellido)

        ' DataGridView1.Rows.Clear()
        ' For i = 1 To oAlumnos.ToArray.Length
        'factura = oAlumnos.Item(i - 1)

        ' DataGridView1.Rows.Add()
        'DataGridView1.Rows(i - 1).Cells(0).Value = factura.CdAlumno
        'DataGridView1.Rows(i - 1).Cells(1).Value = factura.ToString
        'DataGridView1.Rows(i - 1).Cells(2).Value = factura.Telefono
        'DataGridView1.Rows(i - 1).Cells(3).Value = factura.TelefonoMovil
        'DataGridView1.Rows(i - 1).Cells(4).Value = factura.Email
        '        DataGridView1.Rows(i - 1).Cells(5).Value = factura.DescEstadoAlumno
        '       Next

        '      Catch ex As Exception
        'MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Finally
        'Libero memoria
        'oAlumnos = Nothing
        'oAlumnosNegocio = Nothing
        ' End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CerrarOperacion()
    End Sub

    Private Sub ButtonNuevoAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevoAlumno.Click
        NuevoInscripcionCurso()
    End Sub

    Private Sub TextBoxcurso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxcurso.TextChanged, TextBox1.TextChanged

    End Sub

    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click, Label4.Click

    End Sub
End Class
