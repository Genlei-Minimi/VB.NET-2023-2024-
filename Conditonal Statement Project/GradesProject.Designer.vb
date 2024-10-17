<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradesProject
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblgrades = New Label()
        Label2 = New Label()
        txtgrd = New TextBox()
        btnOK = New Button()
        lblremarks = New Label()
        Label1 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label14 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblgrades
        ' 
        lblgrades.AutoSize = True
        lblgrades.Font = New Font("Agency FB", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblgrades.ForeColor = SystemColors.ButtonHighlight
        lblgrades.Location = New Point(26, 165)
        lblgrades.Name = "lblgrades"
        lblgrades.Size = New Size(48, 18)
        lblgrades.TabIndex = 0
        lblgrades.Text = "Grades:"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(19, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 1
        Label2.Text = "Remarks:"' 
        ' txtgrd
        ' 
        txtgrd.Location = New Point(80, 160)
        txtgrd.Name = "txtgrd"
        txtgrd.Size = New Size(129, 23)
        txtgrd.TabIndex = 2
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(80, 253)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(129, 23)
        btnOK.TabIndex = 4
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' lblremarks
        ' 
        lblremarks.BackColor = Color.WhiteSmoke
        lblremarks.BorderStyle = BorderStyle.FixedSingle
        lblremarks.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblremarks.ForeColor = Color.Maroon
        lblremarks.Location = New Point(80, 188)
        lblremarks.Name = "lblremarks"
        lblremarks.Size = New Size(129, 62)
        lblremarks.TabIndex = 5
        lblremarks.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(2, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 24)
        Label1.TabIndex = 6
        Label1.Text = "Grade:"' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(2, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 24)
        Label3.TabIndex = 7
        Label3.Text = "Remark:"' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.WhiteSmoke
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.Maroon
        GroupBox1.Location = New Point(12, 38)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(367, 81)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "RATING GUIDE"' 
        ' Label13
        ' 
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(308, 46)
        Label13.Name = "Label13"
        Label13.Size = New Size(57, 24)
        Label13.TabIndex = 17
        Label13.Text = "A"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(250, 46)
        Label12.Name = "Label12"
        Label12.Size = New Size(57, 24)
        Label12.TabIndex = 16
        Label12.Text = "B"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(187, 46)
        Label11.Name = "Label11"
        Label11.Size = New Size(57, 24)
        Label11.TabIndex = 15
        Label11.Text = "C"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(124, 46)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 24)
        Label10.TabIndex = 14
        Label10.Text = "D"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(61, 46)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 24)
        Label9.TabIndex = 13
        Label9.Text = "F"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(313, 22)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 24)
        Label8.TabIndex = 12
        Label8.Text = "91 to 100"' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(250, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 24)
        Label7.TabIndex = 11
        Label7.Text = "86 to 90"' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(187, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 24)
        Label6.TabIndex = 10
        Label6.Text = "81 to 85"' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(124, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 24)
        Label5.TabIndex = 9
        Label5.Text = "75 to 80"' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(61, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 24)
        Label4.TabIndex = 8
        Label4.Text = "75 below"' 
        ' Label14
        ' 
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = SystemColors.Control
        Label14.Location = New Point(0, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(801, 35)
        Label14.TabIndex = 9
        Label14.Text = "GRADES COMPUTER SYSTEM"' 
        ' GradesProject
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        ClientSize = New Size(407, 331)
        Controls.Add(Label14)
        Controls.Add(GroupBox1)
        Controls.Add(lblremarks)
        Controls.Add(btnOK)
        Controls.Add(txtgrd)
        Controls.Add(Label2)
        Controls.Add(lblgrades)
        Name = "GradesProject"
        Text = "GradesProject"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblgrades As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtgrd As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents lblremarks As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
End Class
