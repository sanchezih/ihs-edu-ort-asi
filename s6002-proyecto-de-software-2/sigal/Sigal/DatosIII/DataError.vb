Public Class DataError

    Public Sub clasificar_error(ByVal numero As Integer)

        Select Case numero
            Case 2627
                MessageBox.Show("Datos duplicados. Verifique los datos ingreados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Case 70001
                MessageBox.Show("Error en la inscripción. Existen inscripciones sin calificaciones informadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Case 70002
                MessageBox.Show("El usuario ingrsado ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Case Else
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Select
    End Sub
End Class
