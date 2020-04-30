Public Class __FormNuevoInscripcionCurso

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
    'Private Sub IniciarFormulario()
    '    Me.Text = "Inscripción a plan de estudio"
    '    componentes.LlenarComboAlumnos(ComboBoxAlumno)
    'End Sub

    'Confirmar la operación en curso
    Private Sub AceptarOperacion()
        Dim oPlan As New Entidades.__PlanEstudio_figuls
        Dim oAlumno As New Entidades.__Alumno
        Dim oCurso As New Entidades.Curso
        Dim oInscrpCuso As New Entidades.InscripcionCurso
        Dim oIncripcionCursoNegocio As New Negocio.InscripcionCurso
        Try

            Dim returnValue As String
            returnValue = MessageBox.Show("Esta seguro de inscribir este Alumno al curso", "Confirmación", MessageBoxButtons.OKCancel)
            If returnValue = 1 Then
                'Si todo está bien creo un objeto cita con la nueva informacion
                '        oPlan = ComboBoxPlan.SelectedItem
                oAlumno = ComboBoxAlumno.SelectedItem
                oPlan = ComboBoxPlan.SelectedItem
                oCurso = ComboBoxCurso.SelectedItem
                oInscrpCuso._cd_alumno = oAlumno._cd_alumno
                'oInscrpCuso.cdCurso = oCurso.cdCurso

                oIncripcionCursoNegocio.Add(oInscrpCuso)

                'indico que todo salio bien y cierro el formulario
                Cancelado = False
                Me.Hide()
            End If
        Catch ex As Exception
            'muestro cualquier error de la aplicacion o por validación
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'libera objetos
            oAlumno = Nothing
            oPlan = Nothing
            oCurso = Nothing
            oInscrpCuso = Nothing
            oIncripcionCursoNegocio = Nothing

        End Try
    End Sub

    'Cancela la operacion
    Private Sub CancelarOperacion()
        'cancelo la operación y retorno al formulario llamador
        Cancelado = True
        Me.Hide()
    End Sub

    'Private Sub FormNuevoInscripcionCurso_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
    '    'inicializa el formulario
    '    IniciarFormulario()
    'End Sub

    Private Sub ButtonCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCrear.Click
        AceptarOperacion()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        CancelarOperacion()
    End Sub
    'Private Sub ComboBoxAlumno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxAlumno.SelectedIndexChanged
    '    componentes.LlenarComboPlanEstudioByAlumno(ComboBoxPlan, ComboBoxAlumno)
    'End Sub

    Private Sub ComboBoxPlan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxPlan.SelectedIndexChanged
        componentes.LlenarComboCursoByPlanEstudio(ComboBoxCurso, ComboBoxPlan)
    End Sub
End Class
