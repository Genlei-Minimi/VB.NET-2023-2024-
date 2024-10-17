Public Class DiscountForm
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim DisocuntForm As Integer = txtItem.Text
        Select Case DisocuntForm
            Case Is >= 1000
                lblPrice.Text = txtItem.Text
                lbldiscount.Text = ("0.2")
                lblResult.Text = (txtItem.Text * lbldiscount.Text)
                lblTotal.Text = (lblPrice.Text - lblResult.Text)
            Case 500 To 999
                lblPrice.Text = txtItem.Text
                lbldiscount.Text = ("0.1")
                lblResult.Text = (txtItem.Text * lbldiscount.Text)
                lblTotal.Text = (lblPrice.Text - lblResult.Text)
            Case Is < 500
                lbldiscount.Text = (" ")
                lblPrice.Text = txtItem.Text
                lblResult.Text = ("0")
                lblTotal.Text = txtItem.Text
        End Select
    End Sub

End Class