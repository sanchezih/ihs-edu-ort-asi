Public Class __FormNuevoMateria

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
        Me.Text = "Nueva Alta de Materia"
    End Sub

    'Valida los datos antes de realizar cualquier operación
    Private Sub Validar()
        If TextBoxMateria.Text.Trim = "" Then
            TextBoxMateria.Focus()
            Throw New ArgumentException("El nombre de la Materia no puede estar en blanco.")
        End If
    End Sub
    'Confirmar la operación en curso
    Private Sub AceptarOperacion()
        Dim oMateriaNegocio As New Negocio.Materia
        Dim oMateriaEntidad As New Entidades.Materia
        Try
            'Primero valido los datos
            Validar()
            Dim returnValue As String
            returnValue = MessageBox.Show("Esta seguro que desea dar de alta el materia?", "Confirmación", MessageBoxButtons.OKCancel)
            If returnValue = 1 Then
                'Si todo está bien creo un objeto cita con la nueva informacion
                oMateriaEntidad._nombre_materia = TextBoxMateria.Text.ToUpper

                'agrego nueva cita
                oMateriaNegocio.add(oMateriaEntidad)

                'indico que todo salio bien y cierro el formulario
                Cancelado = False
                Me.Hide()
            End If
        Catch ex As Exception
            'muestro cualquier error de la aplicacion o por validación
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'libera objetos
            oMateriaEntidad = Nothing
            oMateriaNegocio = Nothing
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

    Private Sub ButtonCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCrear.Click
        AceptarOperacion()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        CerrarOperacion()
    End Sub

    Private Sub FormNuevoMateria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
