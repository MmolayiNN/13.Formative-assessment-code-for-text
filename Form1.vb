Public Class Form1

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the pressed key is a numeric digit or a control key (e.g., Backspace, Delete)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If the pressed key is not a numeric digit and not a control key, suppress it
            e.Handled = True
        End If

    End Sub
End Class
