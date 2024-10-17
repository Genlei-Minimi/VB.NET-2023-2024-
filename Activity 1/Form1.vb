Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        lblMessage.Text = "WELCOME TO JOLLIBEE!"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblMessage.TextAlign = ContentAlignment.MiddleLeft
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblMessage.TextAlign = ContentAlignment.MiddleRight
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        lblMessage.BackColor = Color.Red
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lblMessage.BackColor = Color.Blue
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        lblMessage.BackColor = Color.Green
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        lblMessage.ForeColor = Color.Orange
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        lblMessage.ForeColor = Color.Black
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lblMessage.ForeColor = Color.Violet
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        lblMessage.Text = TextBox2.Text
    End Sub
End Class

