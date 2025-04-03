<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerOrderListPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerOrderListPage))
        Me.OrderListPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.YourOrderListLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.OrderListLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BeefBurgerPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.BBurgerQtyPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.BburgerAddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.BBurgerMinusBtm = New Guna.UI2.WinForms.Guna2Button()
        Me.BburgerLbl = New System.Windows.Forms.Label()
        Me.BBurgerNotes = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Bburgerproductqtylbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BburgerPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BBurgerTotalPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BBurgerRemoveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.BBburgerPicture = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.KCafePanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.KCafePicture = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.KCafeRemoveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.KCafeTotalPrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.KCafeNotes = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.KCafePrice = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.KCafeLbl = New System.Windows.Forms.Label()
        Me.KCafeQtyPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.KCafeMinusBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.KCafeAddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.KCafeProductQtyLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.OrderListFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.OrderListPanel.SuspendLayout()
        CType(Me.OrderListLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BeefBurgerPanel.SuspendLayout()
        Me.BBurgerQtyPanel.SuspendLayout()
        CType(Me.BBburgerPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KCafePanel.SuspendLayout()
        CType(Me.KCafePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KCafeQtyPanel.SuspendLayout()
        Me.OrderListFlowLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrderListPanel
        '
        Me.OrderListPanel.BackColor = System.Drawing.Color.White
        Me.OrderListPanel.Controls.Add(Me.OrderListFlowLayoutPanel)
        Me.OrderListPanel.Controls.Add(Me.OrderListLogo)
        Me.OrderListPanel.Controls.Add(Me.YourOrderListLbl)
        Me.OrderListPanel.Location = New System.Drawing.Point(1, 1)
        Me.OrderListPanel.Name = "OrderListPanel"
        Me.OrderListPanel.Size = New System.Drawing.Size(1920, 1080)
        Me.OrderListPanel.TabIndex = 0
        '
        'YourOrderListLbl
        '
        Me.YourOrderListLbl.BackColor = System.Drawing.Color.Transparent
        Me.YourOrderListLbl.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YourOrderListLbl.Location = New System.Drawing.Point(105, 26)
        Me.YourOrderListLbl.Name = "YourOrderListLbl"
        Me.YourOrderListLbl.Size = New System.Drawing.Size(188, 51)
        Me.YourOrderListLbl.TabIndex = 39
        Me.YourOrderListLbl.Text = "Your Order"
        '
        'OrderListLogo
        '
        Me.OrderListLogo.BackColor = System.Drawing.Color.Transparent
        Me.OrderListLogo.Image = CType(resources.GetObject("OrderListLogo.Image"), System.Drawing.Image)
        Me.OrderListLogo.ImageRotate = 0!
        Me.OrderListLogo.Location = New System.Drawing.Point(3, 3)
        Me.OrderListLogo.Name = "OrderListLogo"
        Me.OrderListLogo.Size = New System.Drawing.Size(106, 93)
        Me.OrderListLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.OrderListLogo.TabIndex = 40
        Me.OrderListLogo.TabStop = False
        Me.OrderListLogo.UseTransparentBackground = True
        '
        'BeefBurgerPanel
        '
        Me.BeefBurgerPanel.BackColor = System.Drawing.Color.White
        Me.BeefBurgerPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.BeefBurgerPanel.BorderRadius = 10
        Me.BeefBurgerPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.BeefBurgerPanel.BorderThickness = 1
        Me.BeefBurgerPanel.Controls.Add(Me.BBburgerPicture)
        Me.BeefBurgerPanel.Controls.Add(Me.BBurgerRemoveBtn)
        Me.BeefBurgerPanel.Controls.Add(Me.BBurgerTotalPrice)
        Me.BeefBurgerPanel.Controls.Add(Me.BBurgerNotes)
        Me.BeefBurgerPanel.Controls.Add(Me.BburgerPrice)
        Me.BeefBurgerPanel.Controls.Add(Me.BburgerLbl)
        Me.BeefBurgerPanel.Controls.Add(Me.BBurgerQtyPanel)
        Me.BeefBurgerPanel.Location = New System.Drawing.Point(3, 147)
        Me.BeefBurgerPanel.Name = "BeefBurgerPanel"
        Me.BeefBurgerPanel.Size = New System.Drawing.Size(1216, 138)
        Me.BeefBurgerPanel.TabIndex = 0
        '
        'BBurgerQtyPanel
        '
        Me.BBurgerQtyPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BBurgerQtyPanel.BorderColor = System.Drawing.Color.Silver
        Me.BBurgerQtyPanel.BorderRadius = 10
        Me.BBurgerQtyPanel.BorderThickness = 1
        Me.BBurgerQtyPanel.Controls.Add(Me.BBurgerMinusBtm)
        Me.BBurgerQtyPanel.Controls.Add(Me.BburgerAddBtn)
        Me.BBurgerQtyPanel.Controls.Add(Me.Bburgerproductqtylbl)
        Me.BBurgerQtyPanel.Location = New System.Drawing.Point(794, 24)
        Me.BBurgerQtyPanel.Name = "BBurgerQtyPanel"
        Me.BBurgerQtyPanel.Size = New System.Drawing.Size(174, 43)
        Me.BBurgerQtyPanel.TabIndex = 34
        '
        'BburgerAddBtn
        '
        Me.BburgerAddBtn.BackColor = System.Drawing.Color.Transparent
        Me.BburgerAddBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BburgerAddBtn.BorderRadius = 5
        Me.BburgerAddBtn.BorderThickness = 1
        Me.BburgerAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BburgerAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BburgerAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BburgerAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BburgerAddBtn.FillColor = System.Drawing.Color.White
        Me.BburgerAddBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BburgerAddBtn.ForeColor = System.Drawing.Color.White
        Me.BburgerAddBtn.Image = CType(resources.GetObject("BburgerAddBtn.Image"), System.Drawing.Image)
        Me.BburgerAddBtn.ImageOffset = New System.Drawing.Point(1, 3)
        Me.BburgerAddBtn.Location = New System.Drawing.Point(132, 2)
        Me.BburgerAddBtn.Name = "BburgerAddBtn"
        Me.BburgerAddBtn.Size = New System.Drawing.Size(39, 37)
        Me.BburgerAddBtn.TabIndex = 31
        '
        'BBurgerMinusBtm
        '
        Me.BBurgerMinusBtm.BackColor = System.Drawing.Color.Transparent
        Me.BBurgerMinusBtm.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BBurgerMinusBtm.BorderRadius = 5
        Me.BBurgerMinusBtm.BorderThickness = 1
        Me.BBurgerMinusBtm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BBurgerMinusBtm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BBurgerMinusBtm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BBurgerMinusBtm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BBurgerMinusBtm.FillColor = System.Drawing.Color.White
        Me.BBurgerMinusBtm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BBurgerMinusBtm.ForeColor = System.Drawing.Color.White
        Me.BBurgerMinusBtm.Image = CType(resources.GetObject("BBurgerMinusBtm.Image"), System.Drawing.Image)
        Me.BBurgerMinusBtm.ImageOffset = New System.Drawing.Point(1, 3)
        Me.BBurgerMinusBtm.Location = New System.Drawing.Point(4, 3)
        Me.BBurgerMinusBtm.Name = "BBurgerMinusBtm"
        Me.BBurgerMinusBtm.Size = New System.Drawing.Size(42, 37)
        Me.BBurgerMinusBtm.TabIndex = 32
        '
        'BburgerLbl
        '
        Me.BburgerLbl.AutoSize = True
        Me.BburgerLbl.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BburgerLbl.Location = New System.Drawing.Point(134, 20)
        Me.BburgerLbl.Name = "BburgerLbl"
        Me.BburgerLbl.Size = New System.Drawing.Size(301, 42)
        Me.BburgerLbl.TabIndex = 29
        Me.BburgerLbl.Text = "Classic Beef w/ Cheese"
        '
        'BBurgerNotes
        '
        Me.BBurgerNotes.BackColor = System.Drawing.Color.White
        Me.BBurgerNotes.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BBurgerNotes.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BBurgerNotes.Image = CType(resources.GetObject("BBurgerNotes.Image"), System.Drawing.Image)
        Me.BBurgerNotes.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BBurgerNotes.ImageRotate = 0!
        Me.BBurgerNotes.ImageSize = New System.Drawing.Size(20, 20)
        Me.BBurgerNotes.Location = New System.Drawing.Point(144, 85)
        Me.BBurgerNotes.Name = "BBurgerNotes"
        Me.BBurgerNotes.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BBurgerNotes.Size = New System.Drawing.Size(32, 38)
        Me.BBurgerNotes.TabIndex = 37
        '
        'Bburgerproductqtylbl
        '
        Me.Bburgerproductqtylbl.BackColor = System.Drawing.Color.Transparent
        Me.Bburgerproductqtylbl.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bburgerproductqtylbl.Location = New System.Drawing.Point(75, 9)
        Me.Bburgerproductqtylbl.Name = "Bburgerproductqtylbl"
        Me.Bburgerproductqtylbl.Size = New System.Drawing.Size(25, 30)
        Me.Bburgerproductqtylbl.TabIndex = 33
        Me.Bburgerproductqtylbl.Text = "00"
        '
        'BburgerPrice
        '
        Me.BburgerPrice.BackColor = System.Drawing.Color.Transparent
        Me.BburgerPrice.Font = New System.Drawing.Font("Roboto Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BburgerPrice.Location = New System.Drawing.Point(144, 58)
        Me.BburgerPrice.Name = "BburgerPrice"
        Me.BburgerPrice.Size = New System.Drawing.Size(73, 23)
        Me.BburgerPrice.TabIndex = 36
        Me.BburgerPrice.Text = "P249.00"
        '
        'BBurgerTotalPrice
        '
        Me.BBurgerTotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.BBurgerTotalPrice.Font = New System.Drawing.Font("Roboto SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBurgerTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BBurgerTotalPrice.Location = New System.Drawing.Point(1029, 23)
        Me.BBurgerTotalPrice.Name = "BBurgerTotalPrice"
        Me.BBurgerTotalPrice.Size = New System.Drawing.Size(133, 31)
        Me.BBurgerTotalPrice.TabIndex = 38
        Me.BBurgerTotalPrice.Text = "PHP 000.00"
        '
        'BBurgerRemoveBtn
        '
        Me.BBurgerRemoveBtn.BackColor = System.Drawing.Color.Transparent
        Me.BBurgerRemoveBtn.BorderColor = System.Drawing.Color.DimGray
        Me.BBurgerRemoveBtn.BorderRadius = 10
        Me.BBurgerRemoveBtn.BorderThickness = 1
        Me.BBurgerRemoveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BBurgerRemoveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BBurgerRemoveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BBurgerRemoveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BBurgerRemoveBtn.FillColor = System.Drawing.Color.WhiteSmoke
        Me.BBurgerRemoveBtn.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBurgerRemoveBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BBurgerRemoveBtn.ImageOffset = New System.Drawing.Point(0, 3)
        Me.BBurgerRemoveBtn.Location = New System.Drawing.Point(795, 74)
        Me.BBurgerRemoveBtn.Name = "BBurgerRemoveBtn"
        Me.BBurgerRemoveBtn.Size = New System.Drawing.Size(173, 38)
        Me.BBurgerRemoveBtn.TabIndex = 39
        Me.BBurgerRemoveBtn.Text = "Remove"
        Me.BBurgerRemoveBtn.TextOffset = New System.Drawing.Point(0, 1)
        '
        'BBburgerPicture
        '
        Me.BBburgerPicture.BorderRadius = 10
        Me.BBburgerPicture.Image = CType(resources.GetObject("BBburgerPicture.Image"), System.Drawing.Image)
        Me.BBburgerPicture.ImageRotate = 0!
        Me.BBburgerPicture.Location = New System.Drawing.Point(18, 18)
        Me.BBburgerPicture.Name = "BBburgerPicture"
        Me.BBburgerPicture.Size = New System.Drawing.Size(107, 104)
        Me.BBburgerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BBburgerPicture.TabIndex = 40
        Me.BBburgerPicture.TabStop = False
        '
        'KCafePanel
        '
        Me.KCafePanel.BackColor = System.Drawing.Color.White
        Me.KCafePanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.KCafePanel.BorderRadius = 10
        Me.KCafePanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.KCafePanel.BorderThickness = 1
        Me.KCafePanel.Controls.Add(Me.KCafePicture)
        Me.KCafePanel.Controls.Add(Me.KCafeRemoveBtn)
        Me.KCafePanel.Controls.Add(Me.KCafeTotalPrice)
        Me.KCafePanel.Controls.Add(Me.KCafeNotes)
        Me.KCafePanel.Controls.Add(Me.KCafePrice)
        Me.KCafePanel.Controls.Add(Me.KCafeLbl)
        Me.KCafePanel.Controls.Add(Me.KCafeQtyPanel)
        Me.KCafePanel.Location = New System.Drawing.Point(3, 3)
        Me.KCafePanel.Name = "KCafePanel"
        Me.KCafePanel.Size = New System.Drawing.Size(1216, 138)
        Me.KCafePanel.TabIndex = 41
        '
        'KCafePicture
        '
        Me.KCafePicture.BorderRadius = 10
        Me.KCafePicture.Image = CType(resources.GetObject("KCafePicture.Image"), System.Drawing.Image)
        Me.KCafePicture.ImageRotate = 0!
        Me.KCafePicture.Location = New System.Drawing.Point(18, 18)
        Me.KCafePicture.Name = "KCafePicture"
        Me.KCafePicture.Size = New System.Drawing.Size(107, 104)
        Me.KCafePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.KCafePicture.TabIndex = 40
        Me.KCafePicture.TabStop = False
        '
        'KCafeRemoveBtn
        '
        Me.KCafeRemoveBtn.BackColor = System.Drawing.Color.Transparent
        Me.KCafeRemoveBtn.BorderColor = System.Drawing.Color.DimGray
        Me.KCafeRemoveBtn.BorderRadius = 10
        Me.KCafeRemoveBtn.BorderThickness = 1
        Me.KCafeRemoveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.KCafeRemoveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.KCafeRemoveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.KCafeRemoveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KCafeRemoveBtn.FillColor = System.Drawing.Color.WhiteSmoke
        Me.KCafeRemoveBtn.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KCafeRemoveBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(5, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.KCafeRemoveBtn.ImageOffset = New System.Drawing.Point(0, 3)
        Me.KCafeRemoveBtn.Location = New System.Drawing.Point(795, 67)
        Me.KCafeRemoveBtn.Name = "KCafeRemoveBtn"
        Me.KCafeRemoveBtn.Size = New System.Drawing.Size(173, 38)
        Me.KCafeRemoveBtn.TabIndex = 39
        Me.KCafeRemoveBtn.Text = "Remove"
        Me.KCafeRemoveBtn.TextOffset = New System.Drawing.Point(0, 1)
        '
        'KCafeTotalPrice
        '
        Me.KCafeTotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.KCafeTotalPrice.Font = New System.Drawing.Font("Roboto SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KCafeTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.KCafeTotalPrice.Location = New System.Drawing.Point(1029, 23)
        Me.KCafeTotalPrice.Name = "KCafeTotalPrice"
        Me.KCafeTotalPrice.Size = New System.Drawing.Size(133, 31)
        Me.KCafeTotalPrice.TabIndex = 38
        Me.KCafeTotalPrice.Text = "PHP 000.00"
        '
        'KCafeNotes
        '
        Me.KCafeNotes.BackColor = System.Drawing.Color.White
        Me.KCafeNotes.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.KCafeNotes.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.KCafeNotes.Image = CType(resources.GetObject("KCafeNotes.Image"), System.Drawing.Image)
        Me.KCafeNotes.ImageOffset = New System.Drawing.Point(0, 0)
        Me.KCafeNotes.ImageRotate = 0!
        Me.KCafeNotes.ImageSize = New System.Drawing.Size(20, 20)
        Me.KCafeNotes.Location = New System.Drawing.Point(144, 85)
        Me.KCafeNotes.Name = "KCafeNotes"
        Me.KCafeNotes.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.KCafeNotes.Size = New System.Drawing.Size(32, 38)
        Me.KCafeNotes.TabIndex = 37
        '
        'KCafePrice
        '
        Me.KCafePrice.BackColor = System.Drawing.Color.Transparent
        Me.KCafePrice.Font = New System.Drawing.Font("Roboto Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KCafePrice.Location = New System.Drawing.Point(144, 58)
        Me.KCafePrice.Name = "KCafePrice"
        Me.KCafePrice.Size = New System.Drawing.Size(73, 23)
        Me.KCafePrice.TabIndex = 36
        Me.KCafePrice.Text = "P139.00"
        '
        'KCafeLbl
        '
        Me.KCafeLbl.AutoSize = True
        Me.KCafeLbl.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KCafeLbl.Location = New System.Drawing.Point(134, 20)
        Me.KCafeLbl.Name = "KCafeLbl"
        Me.KCafeLbl.Size = New System.Drawing.Size(143, 42)
        Me.KCafeLbl.TabIndex = 29
        Me.KCafeLbl.Text = "KioskCafe"
        '
        'KCafeQtyPanel
        '
        Me.KCafeQtyPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.KCafeQtyPanel.BorderColor = System.Drawing.Color.Silver
        Me.KCafeQtyPanel.BorderRadius = 10
        Me.KCafeQtyPanel.BorderThickness = 1
        Me.KCafeQtyPanel.Controls.Add(Me.KCafeMinusBtn)
        Me.KCafeQtyPanel.Controls.Add(Me.KCafeAddBtn)
        Me.KCafeQtyPanel.Controls.Add(Me.KCafeProductQtyLbl)
        Me.KCafeQtyPanel.Location = New System.Drawing.Point(794, 17)
        Me.KCafeQtyPanel.Name = "KCafeQtyPanel"
        Me.KCafeQtyPanel.Size = New System.Drawing.Size(174, 43)
        Me.KCafeQtyPanel.TabIndex = 34
        '
        'KCafeMinusBtn
        '
        Me.KCafeMinusBtn.BackColor = System.Drawing.Color.Transparent
        Me.KCafeMinusBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KCafeMinusBtn.BorderRadius = 5
        Me.KCafeMinusBtn.BorderThickness = 1
        Me.KCafeMinusBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.KCafeMinusBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.KCafeMinusBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.KCafeMinusBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KCafeMinusBtn.FillColor = System.Drawing.Color.White
        Me.KCafeMinusBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.KCafeMinusBtn.ForeColor = System.Drawing.Color.White
        Me.KCafeMinusBtn.Image = CType(resources.GetObject("KCafeMinusBtn.Image"), System.Drawing.Image)
        Me.KCafeMinusBtn.ImageOffset = New System.Drawing.Point(1, 3)
        Me.KCafeMinusBtn.Location = New System.Drawing.Point(4, 3)
        Me.KCafeMinusBtn.Name = "KCafeMinusBtn"
        Me.KCafeMinusBtn.Size = New System.Drawing.Size(42, 37)
        Me.KCafeMinusBtn.TabIndex = 32
        '
        'KCafeAddBtn
        '
        Me.KCafeAddBtn.BackColor = System.Drawing.Color.Transparent
        Me.KCafeAddBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.KCafeAddBtn.BorderRadius = 5
        Me.KCafeAddBtn.BorderThickness = 1
        Me.KCafeAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.KCafeAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.KCafeAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.KCafeAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KCafeAddBtn.FillColor = System.Drawing.Color.White
        Me.KCafeAddBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.KCafeAddBtn.ForeColor = System.Drawing.Color.White
        Me.KCafeAddBtn.Image = CType(resources.GetObject("KCafeAddBtn.Image"), System.Drawing.Image)
        Me.KCafeAddBtn.ImageOffset = New System.Drawing.Point(1, 3)
        Me.KCafeAddBtn.Location = New System.Drawing.Point(132, 2)
        Me.KCafeAddBtn.Name = "KCafeAddBtn"
        Me.KCafeAddBtn.Size = New System.Drawing.Size(39, 37)
        Me.KCafeAddBtn.TabIndex = 31
        '
        'KCafeProductQtyLbl
        '
        Me.KCafeProductQtyLbl.BackColor = System.Drawing.Color.Transparent
        Me.KCafeProductQtyLbl.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KCafeProductQtyLbl.Location = New System.Drawing.Point(79, 9)
        Me.KCafeProductQtyLbl.Name = "KCafeProductQtyLbl"
        Me.KCafeProductQtyLbl.Size = New System.Drawing.Size(25, 30)
        Me.KCafeProductQtyLbl.TabIndex = 33
        Me.KCafeProductQtyLbl.Text = "00"
        '
        'OrderListFlowLayoutPanel
        '
        Me.OrderListFlowLayoutPanel.AutoScroll = True
        Me.OrderListFlowLayoutPanel.Controls.Add(Me.KCafePanel)
        Me.OrderListFlowLayoutPanel.Controls.Add(Me.BeefBurgerPanel)
        Me.OrderListFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.OrderListFlowLayoutPanel.Location = New System.Drawing.Point(81, 113)
        Me.OrderListFlowLayoutPanel.Name = "OrderListFlowLayoutPanel"
        Me.OrderListFlowLayoutPanel.Size = New System.Drawing.Size(1250, 603)
        Me.OrderListFlowLayoutPanel.TabIndex = 42
        Me.OrderListFlowLayoutPanel.WrapContents = False
        '
        'CustomerOrderListPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.OrderListPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerOrderListPage"
        Me.Text = "CustomerOrderListPage"
        Me.OrderListPanel.ResumeLayout(False)
        Me.OrderListPanel.PerformLayout()
        CType(Me.OrderListLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BeefBurgerPanel.ResumeLayout(False)
        Me.BeefBurgerPanel.PerformLayout()
        Me.BBurgerQtyPanel.ResumeLayout(False)
        Me.BBurgerQtyPanel.PerformLayout()
        CType(Me.BBburgerPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KCafePanel.ResumeLayout(False)
        Me.KCafePanel.PerformLayout()
        CType(Me.KCafePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KCafeQtyPanel.ResumeLayout(False)
        Me.KCafeQtyPanel.PerformLayout()
        Me.OrderListFlowLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OrderListPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents YourOrderListLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents OrderListLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BeefBurgerPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BBurgerTotalPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BBurgerNotes As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BburgerPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BburgerLbl As Label
    Friend WithEvents BBurgerQtyPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BBurgerMinusBtm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BburgerAddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Bburgerproductqtylbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BBurgerRemoveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BBburgerPicture As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents KCafePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents KCafePicture As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents KCafeRemoveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents KCafeTotalPrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents KCafeNotes As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents KCafePrice As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents KCafeLbl As Label
    Friend WithEvents KCafeQtyPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents KCafeMinusBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents KCafeAddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents KCafeProductQtyLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents OrderListFlowLayoutPanel As FlowLayoutPanel
End Class
