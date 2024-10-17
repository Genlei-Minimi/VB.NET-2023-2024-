<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MenuForm))
        lblprice = New Label()
        Label3 = New Label()
        txtOrder = New TextBox()
        btnConfirm = New Button()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' lblprice
        ' 
        lblprice.BackColor = Color.White
        lblprice.Location = New Point(26, 258)
        lblprice.Name = "lblprice"
        lblprice.Size = New Size(122, 27)
        lblprice.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Snow
        Label3.Location = New Point(4, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 31)
        Label3.TabIndex = 3
        Label3.Text = "MENU"' 
        ' txtOrder
        ' 
        txtOrder.Font = New Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtOrder.ForeColor = Color.SaddleBrown
        txtOrder.Location = New Point(26, 147)
        txtOrder.Name = "txtOrder"
        txtOrder.Size = New Size(122, 23)
        txtOrder.TabIndex = 4
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnConfirm.Location = New Point(26, 176)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(122, 32)
        btnConfirm.TabIndex = 5
        btnConfirm.Text = "CONFIRM"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label4.Location = New Point(4, 109)
        Label4.Name = "Label4"
        Label4.Size = New Size(224, 35)
        Label4.TabIndex = 6
        Label4.Text = "PLACE YOUR ORDER HERE!"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Agency FB", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label1.Location = New Point(4, 223)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 35)
        Label1.TabIndex = 7
        Label1.Text = "ITEM PRICE"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Sienna
        Label2.Location = New Point(4, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 40)
        Label2.TabIndex = 8
        Label2.Text = "Burger"' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Sienna
        Label5.Location = New Point(266, 49)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 40)
        Label5.TabIndex = 9
        Label5.Text = "Fish"' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Sienna
        Label6.Location = New Point(97, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 40)
        Label6.TabIndex = 10
        Label6.Text = "Pizza"' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Sienna
        Label7.Location = New Point(334, 49)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 40)
        Label7.TabIndex = 11
        Label7.Text = "Salad"' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Sienna
        Label8.Location = New Point(184, 49)
        Label8.Name = "Label8"
        Label8.Size = New Size(76, 40)
        Label8.TabIndex = 12
        Label8.Text = "Steak"' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Maroon
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(405, 298)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(btnConfirm)
        Controls.Add(txtOrder)
        Controls.Add(Label3)
        Controls.Add(lblprice)
        Name = "Form1"
        Text = "Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblprice As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
