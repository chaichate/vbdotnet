Public Class Form6
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim TotalPrice As Double = txtTotalPrice.Text
        Dim Price As Double = TotalPrice / 1.07

        Dim Vat As Double = Price * 7 / 100

        txtPrice.Text = Math.Round(Price, 2)
        txtVat.Text = Math.Round(Vat, 2)

    End Sub

    Private Sub txtTotalPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalPrice.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class