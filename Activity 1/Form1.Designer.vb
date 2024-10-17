<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PrintDialog1 = New PrintDialog()
        TextBox2 = New TextBox()
        btnInput = New Button()
        Btn2 = New Button()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        Backgorund = New GroupBox()
        Label3 = New Label()
        Forecolor = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        lblMessage = New Label()
        GroupBox1.SuspendLayout()
        Backgorund.SuspendLayout()
        Forecolor.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(6, 13)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(233, 23)
        TextBox2.TabIndex = 1
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(8, 13)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(231, 51)
        btnInput.TabIndex = 2
        btnInput.Text = "Message"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' Btn2
        ' 
        Btn2.Location = New Point(6, 51)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(231, 51)
        Btn2.TabIndex = 3
        Btn2.Text = "Enter"
        Btn2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(294, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 4
        Label1.Text = "Text Align"' 
        ' Button1
        ' 
        Button1.Location = New Point(8, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(113, 41)
        Button1.TabIndex = 5
        Button1.Text = "LEFT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(8, 81)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 41)
        Button2.TabIndex = 6
        Button2.Text = "RIGHT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(8, 140)
        Button3.Name = "Button3"
        Button3.Size = New Size(113, 41)
        Button3.TabIndex = 7
        Button3.Text = "CENTER"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(10, 143)
        Button4.Name = "Button4"
        Button4.Size = New Size(113, 41)
        Button4.TabIndex = 10
        Button4.Text = "GREEN"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(10, 84)
        Button5.Name = "Button5"
        Button5.Size = New Size(113, 41)
        Button5.TabIndex = 9
        Button5.Text = "BLUE"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(10, 28)
        Button6.Name = "Button6"
        Button6.Size = New Size(113, 41)
        Button6.TabIndex = 8
        Button6.Text = "RED"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(6, 143)
        Button7.Name = "Button7"
        Button7.Size = New Size(113, 41)
        Button7.TabIndex = 13
        Button7.Text = "VIOLET"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(6, 84)
        Button8.Name = "Button8"
        Button8.Size = New Size(113, 41)
        Button8.TabIndex = 12
        Button8.Text = "BLACK"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(6, 28)
        Button9.Name = "Button9"
        Button9.Size = New Size(113, 41)
        Button9.TabIndex = 11
        Button9.Text = "ORANGE"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 14
        Label2.Text = "Background"' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(286, 170)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(129, 188)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Text Align"' 
        ' Backgorund
        ' 
        Backgorund.BackColor = SystemColors.ActiveBorder
        Backgorund.Controls.Add(Label2)
        Backgorund.Controls.Add(Button4)
        Backgorund.Controls.Add(Button5)
        Backgorund.Controls.Add(Button6)
        Backgorund.Location = New Point(444, 167)
        Backgorund.Name = "Backgorund"
        Backgorund.Size = New Size(131, 188)
        Backgorund.TabIndex = 16
        Backgorund.TabStop = False
        Backgorund.Text = "GroupBox2"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 15
        Label3.Text = "Forecolor"' 
        ' Forecolor
        ' 
        Forecolor.Controls.Add(Label3)
        Forecolor.Controls.Add(Button7)
        Forecolor.Controls.Add(Button8)
        Forecolor.Controls.Add(Button9)
        Forecolor.Location = New Point(618, 167)
        Forecolor.Name = "Forecolor"
        Forecolor.Size = New Size(126, 189)
        Forecolor.TabIndex = 17
        Forecolor.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnInput)
        GroupBox2.Location = New Point(11, 171)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(244, 75)
        GroupBox2.TabIndex = 18
        GroupBox2.TabStop = False
        GroupBox2.Text = "Input"' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Btn2)
        GroupBox3.Controls.Add(TextBox2)
        GroupBox3.Location = New Point(13, 307)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(243, 103)
        GroupBox3.TabIndex = 19
        GroupBox3.TabStop = False
        GroupBox3.Text = "Custom Output"' 
        ' lblMessage
        ' 
        lblMessage.BackColor = SystemColors.ButtonHighlight
        lblMessage.Font = New Font("Segoe UI Historic", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lblMessage.Location = New Point(19, 9)
        lblMessage.Name = "lblMessage"
        lblMessage.Size = New Size(769, 94)
        lblMessage.TabIndex = 20
        lblMessage.Text = "Label1"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(821, 450)
        Controls.Add(lblMessage)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(Forecolor)
        Controls.Add(Backgorund)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        Backgorund.ResumeLayout(False)
        Backgorund.PerformLayout()
        Forecolor.ResumeLayout(False)
        Forecolor.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Backgorund As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Forecolor As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblMessage As Label
End Class
