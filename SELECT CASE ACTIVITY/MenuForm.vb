Public Class MenuForm
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim Form1 As String = txtOrder.Text
        Select Case Form1
            Case "Burger"
                lblprice.Text = "P59.00"
            Case "Pizza"
                lblprice.Text = "P199.00"
            Case "Steak"
                lblprice.Text = "P379.00"
            Case "Fish"
                lblprice.Text = "P109.00"
            Case "Salad"
                lblprice.Text = "P39.00"
            Case Else
                MsgBox("ITEM IS NOT ON MENU!")
        End Select
    End Sub
End Class
