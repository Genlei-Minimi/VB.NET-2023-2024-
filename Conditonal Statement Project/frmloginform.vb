Public Class frmloginform
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        If txtusr.Text = "0322-0252@lspu.edu.ph" And txtpswrd.Text = "TEST1234" Or txtusr.Text = "Guian Nico" And txtpswrd.Text = "ABCDEF" Then
            MsgBox("LOGIN SUCCESSFULLY")

        Else
            MsgBox("LOGIN FAILED")

        End If

    End Sub

End Class
