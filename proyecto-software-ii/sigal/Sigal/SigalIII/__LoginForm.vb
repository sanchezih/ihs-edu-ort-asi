Public Class __LoginForm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If (USUARIOTableAdapter.FillByLoadUsuarioPassword(UsuarioDataSet.USUARIO, UsernameTextBox.Text, PasswordTextBox.Text) > 0) Then
            My.Forms.__PestaniasForm.ShowDialog()
            Me.Close()
        Else
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
            MessageBox.Show("El usuario o password es incorrecto.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Show()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


End Class
