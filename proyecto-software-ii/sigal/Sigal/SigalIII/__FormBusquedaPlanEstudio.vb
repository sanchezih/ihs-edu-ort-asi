Friend Class __FormBusquedaPlanEstudio
    Private mCancelado As Boolean = True
    Dim i, rta As Integer
    Dim factura As New Entidades.__PlanEstudio_figuls
    'indica si la operación fue cancelada
    Public Property Cancelado() As Boolean
        Get
            Return mCancelado
        End Get
        Set(ByVal value As Boolean)
            mCancelado = value
        End Set
    End Property


    'Verifica si hay un item seleccionado
    Private Function IsItemSelected() As Boolean
        'verifica que este seleccionado un item en la gridview
        Return DataGridView1.SelectedCells.Count > 0
    End Function

    'Creo un nuevo plan
    Public Sub NuevoPlan()
        'creo nueva instancia de formulario para dar de alta de plan
        Dim ofrmNuevoAlu As __FormNuevoPlanEstudio
        ofrmNuevoAlu = New __FormNuevoPlanEstudio

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
    Private Sub EditarPlan()
        'Antes de editar verifica que exista algun elemento seleccionado
        If IsItemSelected() Then

            'creo nueva instancia de formulario para modificar la cita seleccionada
            Dim formEditoPlan As __FormEditoPlanEstudio
            formEditoPlan = New __FormEditoPlanEstudio

            'indico cual actualizar
            ' formEditoAlumno.cdalumno = CType(oBindingSource.Current, Entidades.viewAlumnos).CdAlumno
            formEditoPlan.cdplanestudio = DataGridView1.SelectedCells.Item(0).Value


            'muestro el formulario de manera modal
            formEditoPlan.ShowDialog()

            'Verifico el resultado de la operacion
            Dim ResultadoOk As Boolean = Not formEditoPlan.Cancelado

            'cierro formulario
            formEditoPlan.Close()

            'elimino instancia
            formEditoPlan = Nothing

            'si todo estuvo bien recargo la grilla
            If ResultadoOk Then
                Buscar()
            End If

        Else
            'informo que no hay seleccionado
            MessageBox.Show("No existe item seleccionado para editar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    'busca alumnos en funcion de lo datos del filtro
    Private Sub Buscar()
        Dim oPlanEstudioEntidad As New List(Of Entidades.__PlanEstudio_figuls)
        Dim oPlanEstudioNegocio As New Negocio.__PlanEstudio_figuls
        Dim codPlan As String
        Dim titulo As String


        codPlan = TextBoxCodPlan.Text
        titulo = TextBoxTitulo.Text

        Try
            oPlanEstudioEntidad = oPlanEstudioNegocio.GetAllByFiltros(codPlan, titulo)
            DataGridView1.Rows.Clear()
            For i = 1 To oPlanEstudioEntidad.ToArray.Length
                factura = oPlanEstudioEntidad.Item(i - 1)
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i - 1).Cells(0).Value = factura.cdPlanEstudio
                DataGridView1.Rows(i - 1).Cells(1).Value = factura.titulo
                DataGridView1.Rows(i - 1).Cells(2).Value = factura.fcAlta
                DataGridView1.Rows(i - 1).Cells(3).Value = factura.estado
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'Libero memoria
            oPlanEstudioEntidad = Nothing
            oPlanEstudioNegocio = Nothing
        End Try

    End Sub
    'Cancela la operacion
    Private Sub CerrarOperacion()
        'cancelo la operación y retorno al formulario llamador
        Cancelado = True
        Me.Hide()
    End Sub

    Private Sub ButtonNuevoAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevoAlumno.Click
        NuevoPlan()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CerrarOperacion()
    End Sub

    Private Sub ButtonBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBuscar.Click
        Buscar()
    End Sub

    Private Sub ButtonEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditar.Click
        EditarPlan()
    End Sub


    Private Sub FormBusquedaPlanEstudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class