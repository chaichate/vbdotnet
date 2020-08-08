Public Class Form3
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim phoneVale As Double = txtPhone.Text
        Dim Vat As Double = phoneVale * 7 / 100
        txtVat.Text = Vat
        txtNetPrice.Text = phoneVale + Vat
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If

    End Sub
End Class