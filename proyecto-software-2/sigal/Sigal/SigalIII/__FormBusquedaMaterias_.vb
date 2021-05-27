Public Class __FormBusquedaMaterias_

    Private mCancelado As Boolean = True
    Dim oBindingSource As New BindingSource
    Dim i, rta As Int32
    Dim materiaGrid As New Entidades.Materia

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
    'busca alumnos en funcion de lo datos del filtro
    Private Sub Buscar()
        Dim oMateriaEntidad As New List(Of Entidades.Materia)
        Dim oMateriaNegocio As New Negocio.Materia
        Dim codMateria As String
        Dim materia As String

        codMateria = TextBoxcodCodMateria.Text
        materia = TextBoxmateria.Text

        Try
            oMateriaEntidad = oMateriaNegocio.get_all_by_filtros(codMateria, materia)

            DataGridView2.Rows.Clear()
            For i = 1 To oMateriaEntidad.ToArray.Length
                materiaGrid = oMateriaEntidad.Item(i - 1)

                DataGridView2.Rows.Add()
                DataGridView2.Rows(i - 1).Cells(0).Value = materiaGrid._cd_materia
                DataGridView2.Rows(i - 1).Cells(1).Value = materiaGrid._nombre_materia
                DataGridView2.Rows(i - 1).Cells(2).Value = materiaGrid._cd_estado_general

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'Libero memoria
            oMateriaEntidad = Nothing
            oMateriaNegocio = Nothing
        End Try

    End Sub

    'Creo un nuevo plan
    Public Sub NuevaMateria()
        'creo nueva instancia de formulario para dar de alta de plan
        Dim ofrmNuevoAlu As __FormNuevoMateria
        ofrmNuevoAlu = New __FormNuevoMateria

        'muestro el formulario de manera modal
        ofrmNuevoAlu.ShowDialog()

        'cierro formulario
        ofrmNuevoAlu.Close()

        'elimino instancia
        ofrmNuevoAlu = Nothing

        'si todo estuvo bien recargo la grilla
        Buscar()

    End Sub


    'Verifica si hay un item seleccionado
    Private Function IsItemSelected() As Boolean
        'verifica que este seleccionado un item en la gridview
        Return DataGridView2.SelectedCells.Count > 0
    End Function

    'Permite editar una cita
    Private Sub EditarAlumno()
        'Antes de editar verifica que exista algun elemento seleccionado
        If IsItemSelected() Then

            'creo nueva instancia de formulario para modificar la cita seleccionada
            Dim formEditoMateria As __FormEditoMateria
            formEditoMateria = New __FormEditoMateria

            'indico cual actualizar
            ' formEditoAlumno.cdalumno = CType(oBindingSource.Current, Entidades.viewAlumnos).CdAlumno
            formEditoMateria.micdmateria = DataGridView2.SelectedCells.Item(0).Value


            'muestro el formulario de manera modal
            formEditoMateria.ShowDialog()

            'Verifico el resultado de la operacion
            Dim ResultadoOk As Boolean = Not formEditoMateria.Cancelado

            'cierro formulario
            formEditoMateria.Close()

            'elimino instancia
            formEditoMateria = Nothing

            'si todo estuvo bien recargo la grilla
            If ResultadoOk Then
                Buscar()
            End If

        Else
            'informo que no hay seleccionado
            MessageBox.Show("No existe item seleccionado para editar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CerrarOperacion()
    End Sub

    Private Sub ButtonNuevoAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevoAlumno.Click
        NuevaMateria()
    End Sub

    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        Buscar()
    End Sub

    Private Sub ButtonEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditar.Click
        EditarAlumno()
    End Sub

    Private Sub FormBusquedaMaterias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxcodCodMateria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxcodCodMateria.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class
