Public Class Form2
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click


        Dim hour As Integer = txtHour.Text
        txtMunute.Text = hour * 60
        txtSecond.Text = hour * 60 * 60

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtHour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHour.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub
End Class