Public Class __FormEditoPlanEstudio
    Private mCancelado As Boolean = True
    Private mCdplanestudio As Int32 = 0

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
    Public Property cdplanestudio() As Int32
        Get
            Return mCdplanestudio
        End Get
        Set(ByVal Value As Int32)
            mCdplanestudio = Value
        End Set
    End Property

    Private Sub IniciarFormulario()
        'cargo el combo con los valores de la enumeracion
        'Esta esuna manera rápida de obtener los nombres y agregarlos al
        'mismo tiempo
        'debo obtener la cita para editar
        Dim oCitas As List(Of Entidades.__PlanEstudio_figuls)

        Dim oPlanNegocio As New Negocio.__PlanEstudio_figuls
        Try
            'Solicito a negocio toda la informacion de la cita a editar
            Dim titulo As String = ""
            oCitas = oPlanNegocio.GetAllByFiltros(cdplanestudio, titulo)

            'verifico que haya obtenido datos
            If oCitas.Count > 0 Then
                'siempre es el primer valor de la coleccion
                'visualizo los datos en los controles
                With oCitas(0)
                    TextBoxcodPlan.Text = .cdPlanEstudio
                    TextBoxtitulo.Text = .titulo
                    ComboBoxEstado.SelectedItem = .estado

                End With
            Else
                'sino puedo encontrar la cita contacto, puede haberse
                'eliminado por otro usuario
                'Informo de la situación e invalido el formulario para 
                'cualquier operación
                '   MessageBox.Show("La cita solicitada no existe. Verifique su Id y que no haya sido eliminada por otro usuario.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                '  grpDatosCita.Enabled = False
                ' btnAceptar.Visible = False
            End If

        Catch ex As Exception
            'Muestra el error ocurrido
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            'Liberamos memoria
            oCitas = Nothing
            oPlanNegocio = Nothing
        End Try
    End Sub
    'Cancela la operacion
    Private Sub CancelarOperacion()
        'cancelo la operación y retorno al formulario llamador
        Cancelado = True
        Me.Hide()
    End Sub

    Private Sub FormEditoPlanEstudio_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'inicializa el formulario
        IniciarFormulario()
    End Sub
    'Confirmar la operación en curso

    'Valida los datos antes de realizar cualquier operación
    Private Sub Validar()
        If TextBoxtitulo.Text.Trim = "" Then
            TextBoxtitulo.Focus()
            Throw New ArgumentException("El titulo no puede estar en blanco.")
        End If
    End Sub

    Private Sub AceptarOperacion()
        Dim oPlanNegocio As New Negocio.__PlanEstudio_figuls
        Dim oPlanEntidad As New Entidades.__PlanEstudio_figuls
        Try
            'Primero valido los datos
            Validar()

            'Si todo está bien creo un objeto cita con la nueva informacion
            oPlanEntidad.cdPlanEstudio = TextBoxcodPlan.Text
            oPlanEntidad.titulo = TextBoxtitulo.Text.ToUpper
            oPlanEntidad.estado = ComboBoxEstado.SelectedItem
            'actualizo cita existente
            oPlanNegocio.Update(oPlanEntidad)
            MessageBox.Show("Plan actualizado exitosamente!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            'indico que todo salio bien y cierro el formulario
            Cancelado = False
            Me.Hide()

        Catch ex As Exception
            'muestro cualquier error de la aplicacion o por validación
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'libera objetos
            oPlanEntidad = Nothing
            oPlanNegocio = Nothing
        End Try
    End Sub

    Private Sub ButtonCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCrear.Click
        AceptarOperacion()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        CancelarOperacion()
    End Sub

    Private Sub ComboBoxEstado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEstado.SelectedIndexChanged

    End Sub
End Class
