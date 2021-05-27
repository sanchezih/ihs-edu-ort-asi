Public Class __FormNuevoCurso

#Region "Propiedades de control"

    Private mCancelado As Boolean = True
    Private mIdToEdit As Int32 = 0
    Private mIdContacto As Int32 = 0


    'indica si la operación fue cancelada
    Public Property Cancelado() As Boolean
        Get
            Return mCancelado
        End Get
        Set(ByVal value As Boolean)
            mCancelado = value
        End Set
    End Property

    'Indica el Id de la cita a editar
    Public Property IdToEdit() As Int32
        Get
            Return mIdToEdit
        End Get
        Set(ByVal Value As Int32)
            mIdToEdit = Value
        End Set
    End Property

    'Indica el IdContacto 
    Public Property IdContacto() As Int32
        Get
            Return mIdContacto
        End Get
        Set(ByVal Value As Int32)
            mIdContacto = Value
        End Set
    End Property

#End Region

    Dim oPlanNegocio As New Negocio.__PlanEstudio_figuls
    Dim listaDePlanes As New ArrayList
    Dim oMateriaNegocio As New Negocio.Materia
    Dim listaDeMaterias As New ArrayList
    Dim oProfeNegocio As New Negocio.Profesor
    Dim listaDeProfes As New ArrayList
    Dim Plan As New Entidades.__PlanEstudio_figuls
    Dim componentes As New Sigal.Componentes

    'Inicializa el formulario
    Private Sub IniciarFormulario()

        Me.Text = "Nuevo Curso"

        componentes.LlenarComboPlanEstudio(ComboBoxPlan)
        ComboBoxMateria.Text = "Seleccione una Materia..."

        LlenarComboProfesor(ComboBoxProfe)
        ComboBoxCuatri.Text = "Seleccione Cuatrimestre..."


    End Sub

    'Confirmar la operación en curso
    Private Sub AceptarOperacion()
        Dim oCursoNegocio As New Negocio.Curso
        Dim oCurso As New Entidades.Curso
        Dim oPlan As New Entidades.__PlanEstudio_figuls
        Dim oMateria As New Entidades.Materia
        Dim oProfesor As New Entidades.Profesor

        Try
            Dim returnValue As String
            returnValue = MessageBox.Show("Esta seguro que desea dar de alta el curso?", "Confirmación", MessageBoxButtons.OKCancel)
            If returnValue = 1 Then
                'Si todo está bien creo un objeto cita con la nueva informacion
                'oPlan = ComboBoxPlan.SelectedItem
                'oCurso.cdPlanEstudio = oPlan.cdPlanEstudio
                'oMateria = ComboBoxMateria.SelectedItem
                'oCurso.cdMateria = oMateria._cd_materia
                'oProfesor = ComboBoxProfe.SelectedItem
                'oCurso.cdProfesor = oProfesor._cd_profesor
                'oCurso.anio = MaskedTextBoxAnio.Text
                'oCurso.nroCuatrimestre = ComboBoxCuatri.SelectedItem
                'agrego nueva cita
                oCursoNegocio.Add(oCurso)

                'indico que todo salio bien y cierro el formulario
                Cancelado = False
                Me.Hide()
            End If
        Catch ex As Exception
            'muestro cualquier error de la aplicacion o por validación
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'libera objetos
            oCurso = Nothing
            oCursoNegocio = Nothing
        End Try
    End Sub

    Public Sub LlenarComboPlanEstudio(ByVal ComboPlanEstudio)
        ComboPlanEstudio.Enabled = True
        ComboPlanEstudio.Items.Clear()
        ComboPlanEstudio.Text = "Seleccione un Plan..."
        listaDePlanes = oPlanNegocio.GetAll()
        ComboPlanEstudio.DisplayMember = "cdPlanEstudio"
        ComboPlanEstudio.ValueMember = "cdPlanEstudio"
        ComboPlanEstudio.Items.AddRange(listaDePlanes.ToArray)
    End Sub

    Public Sub LlenarComboMateria(ByVal ComboBoxMateria, ByVal ComboBoxPlan)
        ComboBoxMateria.Enabled = True
        Plan = ComboBoxPlan.SelectedItem
        ComboBoxMateria.Items.Clear()
        ComboBoxMateria.Text = "Seleccione una Materia..."

        listaDeMaterias = oMateriaNegocio.get_all(Plan.cdPlanEstudio)
        ComboBoxMateria.DisplayMember = "nombreMateria"
        ComboBoxMateria.ValueMember = "cdMateria"
        ComboBoxMateria.Items.AddRange(listaDeMaterias.ToArray)
    End Sub

    Public Sub LlenarComboProfesor(ByVal ComboBoxProfe)
        ComboBoxProfe.Enabled = True
        ComboBoxProfe.Items.Clear()
        ComboBoxProfe.Text = "Seleccione un Profesor..."
        'listaDeProfes = oProfeNegocio.GetAll()
        ComboBoxProfe.DisplayMember = "ToString"
        ComboBoxProfe.ValueMember = "cdProfesor"
        ComboBoxProfe.Items.AddRange(listaDeProfes.ToArray)
    End Sub

    'Cancela la operacion
    Private Sub CancelarOperacion()
        'cancelo la operación y retorno al formulario llamador
        Cancelado = True
        Me.Hide()
    End Sub

    Private Sub FormNuevoCurso_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'inicializa el formulario
        IniciarFormulario()
    End Sub

    Private Sub ButtonCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCrear.Click
        AceptarOperacion()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        CancelarOperacion()
    End Sub


    Private Sub ComboBoxPlan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPlan.SelectedIndexChanged
        LlenarComboMateria(ComboBoxMateria, ComboBoxPlan)
    End Sub

End Class
