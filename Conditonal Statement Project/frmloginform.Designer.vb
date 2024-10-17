<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmloginform
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmloginform))
        txtusr = New TextBox()
        txtpswrd = New TextBox()
        lblusr = New Label()
        lblpswrd = New Label()
        btnlog = New Button()
        SuspendLayout()
        ' 
        ' txtusr
        ' 

        txtusr.Location = New Point(295, 229)
        txtusr.Name = "txtusr"
        txtusr.Size = New Size(186, 23)
        txtusr.TabIndex = 0
        ' 
        ' txtpswrd
        ' 
        txtpswrd.Location = New Point(295, 269)
        txtpswrd.Name = "txtpswrd"
        txtpswrd.PasswordChar = "*"c
        txtpswrd.Size = New Size(186, 23)
        txtpswrd.TabIndex = 1
        ' 
        ' lblusr
        ' 
        lblusr.AutoSize = True
        lblusr.Location = New Point(226, 232)
        lblusr.Name = "lblusr"
        lblusr.Size = New Size(63, 15)
        lblusr.TabIndex = 2
        lblusr.Text = "Username:"' 
        ' lblpswrd
        ' 
        lblpswrd.AutoSize = True
        lblpswrd.Location = New Point(229, 272)
        lblpswrd.Name = "lblpswrd"
        lblpswrd.Size = New Size(60, 15)
        lblpswrd.TabIndex = 3
        lblpswrd.Text = "Password:"' 
        ' btnlog
        ' 
        btnlog.Location = New Point(295, 298)
        btnlog.Name = "btnlog"
        btnlog.Size = New Size(186, 23)
        btnlog.TabIndex = 4
        btnlog.Text = "LOG IN"
        btnlog.UseVisualStyleBackColor = True
        ' 
        ' frmloginform
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(796, 450)
        Controls.Add(btnlog)
        Controls.Add(lblpswrd)
        Controls.Add(lblusr)
        Controls.Add(txtpswrd)
        Controls.Add(txtusr)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmloginform"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtusr As TextBox
    Friend WithEvents txtpswrd As TextBox
    Friend WithEvents lblusr As Label
    Friend WithEvents lblpswrd As Label
    Friend WithEvents btnlog As Button
End Class
