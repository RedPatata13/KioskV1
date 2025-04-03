<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerOrderQuantityPage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerOrderQuantityPage))
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.productPanel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.productImage = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.productName = New System.Windows.Forms.Label()
        Me.productPrice = New System.Windows.Forms.Label()
        Me.posiBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.cancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.negaBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.orderQuantityPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.quanText = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.productImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.orderQuantityPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'productPanel
        '
        Me.productPanel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.productPanel.BackColor = System.Drawing.Color.Transparent
        Me.productPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.productPanel.BorderRadius = 10
        Me.productPanel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.productPanel.DefaultText = ""
        Me.productPanel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.productPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.productPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.productPanel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.productPanel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productPanel.Font = New System.Drawing.Font("Poppins", 21.75!)
        Me.productPanel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.productPanel.Location = New System.Drawing.Point(545, 146)
        Me.productPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.productPanel.Name = "productPanel"
        Me.productPanel.PlaceholderText = ""
        Me.productPanel.SelectedText = ""
        Me.productPanel.ShadowDecoration.BorderRadius = 25
        Me.productPanel.ShadowDecoration.Depth = 25
        Me.productPanel.ShadowDecoration.Enabled = True
        Me.productPanel.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.productPanel.Size = New System.Drawing.Size(269, 300)
        Me.productPanel.TabIndex = 5
        '
        'productImage
        '
        Me.productImage.BackColor = System.Drawing.Color.Transparent
        Me.productImage.BorderRadius = 20
        Me.productImage.Image = CType(resources.GetObject("productImage.Image"), System.Drawing.Image)
        Me.productImage.ImageRotate = 0!
        Me.productImage.Location = New System.Drawing.Point(561, 163)
        Me.productImage.Name = "productImage"
        Me.productImage.Size = New System.Drawing.Size(237, 218)
        Me.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.productImage.TabIndex = 29
        Me.productImage.TabStop = False
        '
        'productName
        '
        Me.productName.AutoSize = True
        Me.productName.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productName.Location = New System.Drawing.Point(619, 384)
        Me.productName.Name = "productName"
        Me.productName.Size = New System.Drawing.Size(129, 34)
        Me.productName.TabIndex = 30
        Me.productName.Text = "Inferno Bite"
        '
        'productPrice
        '
        Me.productPrice.AutoSize = True
        Me.productPrice.Font = New System.Drawing.Font("Roboto Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productPrice.Location = New System.Drawing.Point(648, 414)
        Me.productPrice.Name = "productPrice"
        Me.productPrice.Size = New System.Drawing.Size(64, 18)
        Me.productPrice.TabIndex = 31
        Me.productPrice.Text = "P299.00"
        '
        'posiBtn
        '
        Me.posiBtn.BackColor = System.Drawing.Color.Transparent
        Me.posiBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.posiBtn.BorderRadius = 10
        Me.posiBtn.BorderThickness = 1
        Me.posiBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.posiBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.posiBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.posiBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.posiBtn.FillColor = System.Drawing.Color.White
        Me.posiBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.posiBtn.ForeColor = System.Drawing.Color.White
        Me.posiBtn.Image = CType(resources.GetObject("posiBtn.Image"), System.Drawing.Image)
        Me.posiBtn.ImageOffset = New System.Drawing.Point(0, 12)
        Me.posiBtn.Location = New System.Drawing.Point(730, 466)
        Me.posiBtn.Name = "posiBtn"
        Me.posiBtn.Size = New System.Drawing.Size(59, 35)
        Me.posiBtn.TabIndex = 0
        Me.posiBtn.Text = "Guna2Button1"
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.White
        Me.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cancelBtn.BorderRadius = 10
        Me.cancelBtn.BorderThickness = 1
        Me.cancelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelBtn.FillColor = System.Drawing.Color.White
        Me.cancelBtn.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.cancelBtn.Location = New System.Drawing.Point(474, 527)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(201, 37)
        Me.cancelBtn.TabIndex = 33
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.TextOffset = New System.Drawing.Point(2, 2)
        '
        'negaBtn
        '
        Me.negaBtn.BackColor = System.Drawing.Color.Transparent
        Me.negaBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.negaBtn.BorderRadius = 10
        Me.negaBtn.BorderThickness = 1
        Me.negaBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.negaBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.negaBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.negaBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.negaBtn.FillColor = System.Drawing.Color.White
        Me.negaBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.negaBtn.ForeColor = System.Drawing.Color.White
        Me.negaBtn.Image = CType(resources.GetObject("negaBtn.Image"), System.Drawing.Image)
        Me.negaBtn.ImageOffset = New System.Drawing.Point(0, 12)
        Me.negaBtn.Location = New System.Drawing.Point(578, 466)
        Me.negaBtn.Name = "negaBtn"
        Me.negaBtn.Size = New System.Drawing.Size(59, 35)
        Me.negaBtn.TabIndex = 2
        Me.negaBtn.Text = "Guna2Button2"
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.White
        Me.addBtn.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.addBtn.BorderRadius = 10
        Me.addBtn.BorderThickness = 1
        Me.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.addBtn.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.ForeColor = System.Drawing.Color.Black
        Me.addBtn.Location = New System.Drawing.Point(681, 527)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(204, 37)
        Me.addBtn.TabIndex = 34
        Me.addBtn.Text = "Add Order"
        Me.addBtn.TextOffset = New System.Drawing.Point(2, 2)
        '
        'orderQuantityPanel
        '
        Me.orderQuantityPanel.BackColor = System.Drawing.Color.White
        Me.orderQuantityPanel.Controls.Add(Me.Guna2TextBox2)
        Me.orderQuantityPanel.Controls.Add(Me.Guna2TextBox1)
        Me.orderQuantityPanel.Controls.Add(Me.quanText)
        Me.orderQuantityPanel.Controls.Add(Me.addBtn)
        Me.orderQuantityPanel.Controls.Add(Me.negaBtn)
        Me.orderQuantityPanel.Controls.Add(Me.cancelBtn)
        Me.orderQuantityPanel.Controls.Add(Me.posiBtn)
        Me.orderQuantityPanel.Controls.Add(Me.productPrice)
        Me.orderQuantityPanel.Controls.Add(Me.productName)
        Me.orderQuantityPanel.Controls.Add(Me.productImage)
        Me.orderQuantityPanel.Controls.Add(Me.productPanel)
        Me.orderQuantityPanel.Location = New System.Drawing.Point(-1, -1)
        Me.orderQuantityPanel.Name = "orderQuantityPanel"
        Me.orderQuantityPanel.Size = New System.Drawing.Size(1920, 1080)
        Me.orderQuantityPanel.TabIndex = 0
        '
        'quanText
        '
        Me.quanText.AutoSize = True
        Me.quanText.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quanText.Location = New System.Drawing.Point(663, 469)
        Me.quanText.Name = "quanText"
        Me.quanText.Size = New System.Drawing.Size(39, 34)
        Me.quanText.TabIndex = 35
        Me.quanText.Text = "00"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderRadius = 10
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(648, 683)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(63, 50)
        Me.Guna2TextBox1.TabIndex = 36
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderRadius = 10
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = "0"
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(930, 870)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(87, 65)
        Me.Guna2TextBox2.TabIndex = 37
        Me.Guna2TextBox2.TextOffset = New System.Drawing.Point(9, 9)
        '
        'CustomerOrderQuantityPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.orderQuantityPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerOrderQuantityPage"
        Me.Text = "CustomerOrderQuantityPage"
        CType(Me.productImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.orderQuantityPanel.ResumeLayout(False)
        Me.orderQuantityPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents productPanel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents productImage As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents productName As Label
    Friend WithEvents productPrice As Label
    Friend WithEvents posiBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents negaBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents orderQuantityPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents quanText As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
End Class
