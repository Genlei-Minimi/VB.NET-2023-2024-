Imports System.Diagnostics.Eventing.Reader

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCheckEligibity_Click(sender As Object, e As EventArgs) Handles btnCheckEligibity.Click
        If Val(txtAge.Text) >= 18 And txtResidency.Text = "San Pablo City" Then
            MsgBox("Eligible to Vote. You can now proceed.")

        Else
            MsgBox("Not Eligble to Vote. You must be 18 years old or above and a resident of San Pablo City to vote.")

        End If
    End Sub
End Class
