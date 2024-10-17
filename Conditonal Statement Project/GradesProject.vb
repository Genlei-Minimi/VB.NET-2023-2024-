Public Class GradesProject
    Private Sub GradesProject_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Val(txtgrd.Text) <= 100 And Val(txtgrd.Text) >= 91 Then
            lblremarks.Text = "A"
        ElseIf Val(txtgrd.Text) <= 90 And Val(txtgrd.Text) >= 86 Then
            lblremarks.Text = "B"
        ElseIf Val(txtgrd.Text) <= 85 And Val(txtgrd.Text) >= 81 Then
            lblremarks.Text = "C"
        ElseIf Val(txtgrd.Text) <= 80 And Val(txtgrd.Text) >= 75 Then
            lblremarks.Text = "D"
        ElseIf Val(txtgrd.Text) < 75 Then
            lblremarks.Text = "F"



        End If
    End Sub
End Class