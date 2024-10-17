Public Class Form1
    Dim Firstnum As Decimal
    Dim secondnum As Decimal
    Dim operations As Integer
    Dim operator_selector As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If Label1.Text <> "0" Then
            Label1.Text += "1"
        Else
            Label1.Text = "1"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label1.Text <> "0" Then
            Label1.Text += "2"
        Else
            Label1.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label1.Text <> "0" Then
            Label1.Text += "3"
        Else
            Label1.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label1.Text <> "0" Then
            Label1.Text += "4"
        Else
            Label1.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Label1.Text <> "0" Then
            Label1.Text += "5"
        Else
            Label1.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Label1.Text <> "0" Then
            Label1.Text += "6"
        Else
            Label1.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Label1.Text <> "0" Then
            Label1.Text += "7"
        Else
            Label1.Text = "7"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Label1.Text <> "0" Then
            Label1.Text += "8"
        Else
            Label1.Text = "8"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Label1.Text <> "0" Then
            Label1.Text += "9"
        Else
            Label1.Text = "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Label1.Text <> "0" Then
            Label1.Text += "0"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Not (Label1.Text.Contains(".")) Then
            Label1.Text += "."
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Label1.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Firstnum = Label1.Text
        Label1.Text = "0"
        operator_selector = True
        operations = 1 ' = +
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Firstnum = Label1.Text
        Label1.Text = "0"
        operator_selector = True
        operations = 2 ' = -
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Firstnum = Label1.Text
        Label1.Text = "0"
        operator_selector = True
        operations = 3 ' = /
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Firstnum = Label1.Text
        Label1.Text = "0"
        operator_selector = True
        operations = 4 ' = *
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If operator_selector = True Then
            secondnum = Label1.Text
        ElseIf operations = 1 Then
            Label1.Text = Firstnum + secondnum
        ElseIf operations = 2 Then
            Label1.Text = Firstnum - secondnum
        ElseIf operations = 4 Then
            Label1.Text = Firstnum * secondnum
        Else
            If secondnum = 0 Then
                Label1.Text = ("Error")
            Else
                Label1.Text = Firstnum / secondnum
            End If
        End If
        operator_selector = False
    End Sub
End Class
