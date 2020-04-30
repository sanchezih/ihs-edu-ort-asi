Friend Class __FormBusquedaCalificacionCursada

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


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CerrarOperacion()
    End Sub

    Private Sub ButtonNuevoAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNuevoAlumno.Click

    End Sub
End Class
