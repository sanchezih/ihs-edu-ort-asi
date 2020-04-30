Public Class __FormEditoMateria

    Private mCancelado As Boolean = True
    Private mCdMateria As Int32 = 0
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
    Public Property micdmateria() As Int32
        Get
            Return mCdMateria
        End Get
        Set(ByVal Value As Int32)
            mCdMateria = Value
        End Set
    End Property

    'Valida los datos antes de realizar cualquier operación
    Private Sub Validar()
        If TextBoxMateria.Text.Trim = "" Then
            TextBoxMateria.Focus()
            Throw New ArgumentException("La matería no puede estar en blanco.")
        End If
    End Sub

    Private Sub IniciarFormulario()
        'cargo el combo con los valores de la enumeracion
        'Esta esuna manera rápida de obtener los nombres y agregarlos al
        'mismo tiempo
        'debo obtener la cita para editar
        Dim oMateriasEntidades As List(Of Entidades.Materia)
        Dim oMateriaNegocio As New Negocio.Materia
        Try
            'Solicito a negocio toda la informacion de la cita a editar
            Dim materia As String = ""
            oMateriasEntidades = oMateriaNegocio.get_all_by_filtros(mCdMateria, materia)

            'verifico que haya obtenido datos
            If oMateriasEntidades.Count > 0 Then
                'siempre es el primer valor de la coleccion
                'visualizo los datos en los controles
                With oMateriasEntidades(0)
                    TextBoxCodMateria.Text = ._cd_materia
                    ComboBoxEstado.SelectedItem = ._cd_estado_general
                    TextBoxMateria.Text = ._nombre_materia
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
            oMateriaNegocio = Nothing
            oMateriasEntidades = Nothing
        End Try
    End Sub
    'Cancela la operacion
    Private Sub CancelarOperacion()
        'cancelo la operación y retorno al formulario llamador
        Cancelado = True
        Me.Hide()
    End Sub

    'Confirmar la operación en curso
    Private Sub AceptarOperacion()
        Dim oMateriaEntidad As New Entidades.Materia
        Dim oMateriaNegocio As New Negocio.Materia
        Try
            'Primero valido los datos
            Validar()

            'Si todo está bien creo un objeto cita con la nueva informacion
            oMateriaEntidad._cd_materia = TextBoxCodMateria.Text
            oMateriaEntidad._nombre_materia = TextBoxMateria.Text
            oMateriaEntidad._cd_estado_general = ComboBoxEstado.SelectedItem
            'actualizo cita existente
            oMateriaNegocio.Update(oMateriaEntidad)
            MessageBox.Show("Materia actualizada exitosamente!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            'indico que todo salio bien y cierro el formulario
            Cancelado = False
            Me.Hide()

        Catch ex As Exception
            'muestro cualquier error de la aplicacion o por validación
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            'libera objetos
            oMateriaEntidad = Nothing
            oMateriaNegocio = Nothing
        End Try
    End Sub

    Private Sub ButtonCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCrear.Click
        AceptarOperacion()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        CancelarOperacion()
    End Sub

    Private Sub FormEditoMateria_show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'inicializa el formulario
        IniciarFormulario()
    End Sub

End Class