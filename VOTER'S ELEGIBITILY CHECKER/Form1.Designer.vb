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
        lblName = New Label()
        lblAge = New Label()
        lblResidency = New Label()
        Label1 = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        txtResidency = New TextBox()
        btnCheckEligibity = New Button()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.Transparent
        lblName.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblName.Location = New Point(28, 159)
        lblName.Name = "lblName"
        lblName.Size = New Size(46, 26)
        lblName.TabIndex = 0
        lblName.Text = "NAME:"' 
        ' lblAge
        ' 
        lblAge.BackColor = Color.Transparent
        lblAge.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAge.Location = New Point(35, 190)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(39, 26)
        lblAge.TabIndex = 1
        lblAge.Text = "AGE:"' 
        ' lblResidency
        ' 
        lblResidency.BackColor = Color.Transparent
        lblResidency.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblResidency.Location = New Point(20, 219)
        lblResidency.Name = "lblResidency"
        lblResidency.Size = New Size(74, 26)
        lblResidency.TabIndex = 2
        lblResidency.Text = "RESIDENCY:"' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Agency FB", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(383, 46)
        Label1.TabIndex = 3
        Label1.Text = "    VOTER'S ELIGIBILITY CHECKER"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(100, 162)
        txtName.Name = "txtName"
        txtName.Size = New Size(254, 23)
        txtName.TabIndex = 4
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(100, 191)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(42, 23)
        txtAge.TabIndex = 5
        ' 
        ' txtResidency
        ' 
        txtResidency.Location = New Point(100, 220)
        txtResidency.Name = "txtResidency"
        txtResidency.Size = New Size(254, 23)
        txtResidency.TabIndex = 6
        ' 
        ' btnCheckEligibity
        ' 
        btnCheckEligibity.Font = New Font("Agency FB", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnCheckEligibity.Location = New Point(28, 262)
        btnCheckEligibity.Name = "btnCheckEligibity"
        btnCheckEligibity.Size = New Size(367, 23)
        btnCheckEligibity.TabIndex = 7
        btnCheckEligibity.Text = "CHECK ELIGIBILITY"
        btnCheckEligibity.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlLight
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Font = New Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(28, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(328, 61)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Voter's must be;"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 17)
        Label3.TabIndex = 1
        Label3.Text = "-resident of San Pablo City"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 17)
        Label2.TabIndex = 0
        Label2.Text = "-at least 18 years old and above"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(407, 325)
        Controls.Add(GroupBox1)
        Controls.Add(btnCheckEligibity)
        Controls.Add(txtResidency)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(lblResidency)
        Controls.Add(lblAge)
        Controls.Add(lblName)
        Name = "Form1"
        Text = "Voter's Eligibility Checker"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblResidency As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtResidency As TextBox
    Friend WithEvents btnCheckEligibity As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
