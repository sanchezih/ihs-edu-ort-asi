Public Class __FormBusquedaCurso
    Dim i, rta As Integer
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
    'busca cursos en funcion de lo datos del filtro
    Private Sub Buscar()
        Dim oCursosEntidad As New List(Of Entidades.Curso)
        Dim oCursosNegocio As New Negocio.Curso
        Dim anioCurso As String
        Dim materia As String
        Dim curso As Entidades.Curso
        anioCurso = MaskedTextBoxAnio.Text
        materia = TextBoxmateria.Text


        Try
            oCursosEntidad = oCursosNegocio.GetAllByFiltros(anioCurso, materia)

            DataGridView1.Rows.Clear()
            For i = 1 To oCursosEntidad.ToArray.Length
                curso = oCursosEntidad.Item(i - 1)

                'DataGridView1.Rows.Add()
                'DataGridView1.Rows(i - 1).Cells(0).Value = curso._cd_curso
                'DataGridView1.Rows(i - 1).Cells(1).Value = curso.nombreMateria
                'DataGridView1.Rows(i - 1).Cells(2).Value = curso.anio

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'Libero memoria
            oCursosNegocio = Nothing
            oCursosEntidad = Nothing
        End Try

    End Sub

    'Creo un nuevo plan
    Public Sub NuevoCurso()
        'creo nueva instancia de formulario para dar de alta de plan
        Dim ofrmNuevoAlu As __FormNuevoCurso
        ofrmNuevoAlu = New __FormNuevoCurso

        'muestro el formulario de manera modal
        ofrmNuevoAlu.ShowDialog()

        'cierro formulario
        ofrmNuevoAlu.Close()

        'elimino instancia
        ofrmNuevoAlu = Nothing

        'si todo estuvo bien recargo la grilla
        Buscar()

    End Sub

    'Permite editar una cita
    Private Sub EditarCurso()
        'Antes de editar verifica que exista algun elemento seleccionado
        If IsItemSelected() Then

            'creo nueva instancia de formulario para modificar la cita seleccionada
            Dim formEditoCurso As __FormEditoCurso
            formEditoCurso = New __FormEditoCurso

            'indico cual actualizar
            ' formEditoAlumno.cdalumno = CType(oBindingSource.Current, Entidades.viewAlumnos).CdAlumno
            formEditoCurso.cdcurso = DataGridView1.SelectedCells.Item(0).Value


            'muestro el formulario de manera modal
            formEditoCurso.ShowDialog()

            'Verifico el resultado de la operacion
            Dim ResultadoOk As Boolean = Not formEditoCurso.Cancelado

            'cierro formulario
            formEditoCurso.Close()

            'elimino instancia
            formEditoCurso = Nothing

            'si todo estuvo bien recargo la grilla
            If ResultadoOk Then
                Buscar()
            End If

        Else
            'informo que no hay seleccionado
            MessageBox.Show("No existe item seleccionado para editar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    'Verifica si hay un item seleccionado
    Private Function IsItemSelected() As Boolean
        'verifica que este seleccionado un item en la gridview
        Return DataGridView1.SelectedCells.Count > 0
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CerrarOperacion()
    End Sub

    Private Sub ButtonNuevoAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevoAlumno.Click
        NuevoCurso()
    End Sub

    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        Buscar()
    End Sub

    Private Sub FormBusquedaCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditar.Click
        EditarCurso()
    End Sub
End Class
