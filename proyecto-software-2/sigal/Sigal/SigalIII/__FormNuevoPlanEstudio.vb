Friend Class __FormNuevoPlanEstudio

#Region "Propiedades de control"
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
#End Region

    'Inicializa el formulario
    Private Sub IniciarFormulario()
        Me.Text = "Nuevo Plan de estudio"
        Dim max As Int32
        Dim oNegocio As New Negocio.__PlanEstudio_figuls
        max = oNegocio.GetMaxID
        TextBoxcodPlan.Text = max + 1

    End Sub

    'Confirmar la operación en curso
    Private Sub AceptarOperacion()
        Dim oPlanNegocio As New Negocio.__PlanEstudio_figuls
        Dim oPlanEntidad As New Entidades.__PlanEstudio_figuls
        Try
            'Primero valido los datos
            Validar()
            Dim returnValue As String
            returnValue = MessageBox.Show("Esta seguro que desea dar de alta el plan de estudio?", "Confirmación", MessageBoxButtons.OKCancel)
            If returnValue = 1 Then
                'Si todo está bien creo un objeto cita con la nueva informacion
                oPlanEntidad.cdPlanEstudio = TextBoxcodPlan.Text
                oPlanEntidad.titulo = TextBoxtitulo.Text

                'agrego nueva cita
                oPlanNegocio.Add(oPlanEntidad)

                'indico que todo salio bien y cierro el formulario
                Cancelado = False
                Me.Hide()
            End If
        Catch ex As Exception
            'muestro cualquier error de la aplicacion o por validación
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'libera objetos
            oPlanEntidad = Nothing
            oPlanNegocio = Nothing
        End Try
    End Sub

    Private Sub FormNuevoPlanEstudio_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'inicializa el formulario
        IniciarFormulario()
    End Sub

    'Cancela la operacion
    Private Sub CerrarOperacion()
        'cancelo la operación y retorno al formulario llamador
        Cancelado = True
        Me.Hide()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        CerrarOperacion()
    End Sub

    Private Sub ButtonCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCrear.Click
        AceptarOperacion()
    End Sub


    'Valida los datos antes de realizar cualquier operación
    Private Sub Validar()
        If TextBoxtitulo.Text.Trim = "" Then
            TextBoxtitulo.Focus()
            Throw New ArgumentException("El titulo no puede estar en blanco.")
        End If
    End Sub

    Private Sub FormNuevoPlanEstudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
