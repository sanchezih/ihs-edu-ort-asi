Public Class __FormEditoCurso
#Region "Propiedades de control"

    Private mCancelado As Boolean = True
    Private mCdCurso As Int32 = 0
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
    Public Property cdcurso() As Int32
        Get
            Return mCdCurso
        End Get
        Set(ByVal Value As Int32)
            mCdCurso = Value
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

    Private Sub FormEditoCurso_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'inicializa el formulario
        IniciarFormulario()
    End Sub

    'Inicializa el formulario
    Private Sub IniciarFormulario()
        'cargo el combo con los valores de la enumeracion
        'Esta esuna manera rápida de obtener los nombres y agregarlos al
        'mismo tiempo
        __FormNuevoCurso.LlenarComboProfesor(ComboBoxProfe)
        __FormNuevoCurso.LlenarComboPlanEstudio(ComboBoxPlan)
        '   FormNuevoCurso.LlenarComboMateria(ComboBoxMateria)
        'debo obtener la cita para editar
        Dim oCurso As List(Of Entidades.Curso)

        Dim oCursoNegocio As New Negocio.Curso
        Try
            'Solicito a negocio toda la informacion de la cita a editar


            oCurso = oCursoNegocio.GetAllByCurso(cdcurso)

            'verifico que haya obtenido datos
            If oCurso.Count > 0 Then
                'siempre es el primer valor de la coleccion
                'visualizo los datos en los controles
                With oCurso(0)

                    'ComboBoxPlan.SelectedIndex = .cdPlanEstudio - 1
                    'ComboBoxMateria.SelectedIndex = .cdMateria - 1
                    'ComboBoxProfe.SelectedIndex = .cdProfesor - 1
                    'MaskedTextBoxAnio.Text = .anio
                    'ComboBoxCuatri.SelectedItem = .nroCuatrimestre
                End With
            Else
                'sino puedo encontrar la cita contacto, puede haberse
                'eliminado por otro usuario
                'Informo de la situación e invalido el formulario para 
                'cualquier operación
                MessageBox.Show("La alumno solicitado no existe. Verifique su Id y que no haya sido eliminado por otro usuario.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                '  grpDatosCita.Enabled = False
                ' btnAceptar.Visible = False
            End If
        Catch ex As Exception
            'Muestra el error ocurrido
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Liberamos memoria
            oCurso = Nothing
            oCursoNegocio = Nothing
        End Try
    End Sub
    'Cancela la operacion
    Private Sub CancelarOperacion()
        'cancelo la operación y retorno al formulario llamador
        Cancelado = True
        Me.Hide()
    End Sub

    Private Sub FormEditoCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        CancelarOperacion()
    End Sub
End Class
