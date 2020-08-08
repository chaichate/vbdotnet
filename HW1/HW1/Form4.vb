Public Class Form4
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim amount As Double = txtAmount.Text
        Dim counter As Integer = txtCounter.Text
        Dim ternOfPay As Double = amount / counter
        txtTernOfPay.Text = Format(ternOfPay, "฿#,##0.00")

    End Sub

    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmount.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txtCounter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCounter.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class