<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(DiscountForm))
        btnConfirm = New Button()
        txtItem = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblResult = New Label()
        lbldiscount = New Label()
        lblPrice = New Label()
        lblTotal = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Font = New Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnConfirm.Location = New Point(140, 103)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(122, 23)
        btnConfirm.TabIndex = 7
        btnConfirm.Text = "CONFIRM"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' txtItem
        ' 
        txtItem.Font = New Font("Agency FB", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtItem.ForeColor = SystemColors.ActiveCaptionText
        txtItem.Location = New Point(12, 103)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(122, 23)
        txtItem.TabIndex = 6
        txtItem.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(12, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 25)
        Label1.TabIndex = 12
        Label1.Text = "PRICE:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(140, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 25)
        Label2.TabIndex = 13
        Label2.Text = "TOTAL DISCOUNT"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblResult
        ' 
        lblResult.BackColor = SystemColors.ButtonHighlight
        lblResult.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblResult.Location = New Point(164, 248)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(98, 25)
        lblResult.TabIndex = 14
        lblResult.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbldiscount
        ' 
        lbldiscount.BackColor = SystemColors.ButtonHighlight
        lbldiscount.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbldiscount.Location = New Point(140, 181)
        lbldiscount.Name = "lbldiscount"
        lbldiscount.Size = New Size(114, 25)
        lbldiscount.TabIndex = 17
        lbldiscount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPrice
        ' 
        lblPrice.BackColor = SystemColors.ButtonHighlight
        lblPrice.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrice.Location = New Point(12, 181)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(98, 25)
        lblPrice.TabIndex = 18
        lblPrice.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotal
        ' 
        lblTotal.BackColor = SystemColors.ButtonHighlight
        lblTotal.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(35, 248)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(114, 25)
        lblTotal.TabIndex = 19
        lblTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(12, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 25)
        Label3.TabIndex = 20
        Label3.Text = "ORIGINAL PRICE"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(120, 187)
        Label4.Name = "Label4"
        Label4.Size = New Size(14, 17)
        Label4.TabIndex = 21
        Label4.Text = "*"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(12, 248)
        Label5.Name = "Label5"
        Label5.Size = New Size(17, 17)
        Label5.TabIndex = 22
        Label5.Text = "="' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(35, 223)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 25)
        Label6.TabIndex = 23
        Label6.Text = "TOTAL PAYMENT"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(164, 223)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 25)
        Label7.TabIndex = 24
        Label7.Text = "SAVED:"' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Agency FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(76, 28)
        Label8.Name = "Label8"
        Label8.Size = New Size(158, 25)
        Label8.TabIndex = 25
        Label8.Text = "PAYMENT CALCULATOR"' 
        ' DiscountForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(311, 291)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lblTotal)
        Controls.Add(lblPrice)
        Controls.Add(lbldiscount)
        Controls.Add(lblResult)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnConfirm)
        Controls.Add(txtItem)
        Name = "DiscountForm"
        Text = "DiscountForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConfirm As Button
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lbldiscount As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
