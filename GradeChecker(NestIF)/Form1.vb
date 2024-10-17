Imports System.Security.Authentication

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If Val(txtScore.Text) <= 100 And Val(txtScore.Text) >= 90 Then txtGrade.Text = "A"
        If txtScore.Text >= 97 Then txtGrade.Text = "A+"
        If txtScore.Text <= 93 Then
            txtGrade.Text = "A-"
        End If
        If Val(txtScore.Text) <= 89 And Val(txtScore.Text) >= 80 Then
            txtGrade.Text = "B"

            If txtScore.Text >= 87 Then txtGrade.Text = "B+"
            If txtScore.Text <= 83 Then txtGrade.Text = "B-"
        End If
        If Val(txtScore.Text) <= 79 And Val(txtScore.Text) >= 70 Then
            txtGrade.Text = "C"

            If txtScore.Text >= 77 Then txtGrade.Text = "C+"
            If txtScore.Text <= 73 Then txtGrade.Text = "C-"
        End If
        If Val(txtScore.Text) <= 69 And Val(txtScore.Text) >= 60 Then
            txtGrade.Text = "D"

            If txtScore.Text >= 67 Then txtGrade.Text = "D+"
            If txtScore.Text <= 63 Then txtGrade.Text = "D-"
        End If
        If Val(txtScore.Text) < 60 Then
            txtGrade.Text = "F"
        End If









    End Sub


End Class
