Public Class Form5
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim salary As Double = txtSalary.Text
        Dim hour As Integer = txtHour.Text
        Dim manday = hour / 8
        Dim overHour As Integer = 0

        If (manday >= 30) Then
            overHour = hour - (8 * 30)

            If (overHour > 0) Then
                txtPrice.Text = overHour * ((salary / (8 * 30)) * 1.5)
            Else
                txtPrice.Text = 0
            End If
        Else
            txtPrice.Text = 0
        End If




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txtHour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHour.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub
End Class