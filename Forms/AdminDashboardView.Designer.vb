Namespace KioskV0.Forms

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminDashboardView
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
            Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
            Me.TotalSalesLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
            Me.NumberOfCustomersLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2ShadowPanel3 = New Guna.UI2.WinForms.Guna2ShadowPanel()
            Me.NetProfitLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2ShadowPanel5 = New Guna.UI2.WinForms.Guna2ShadowPanel()
            Me.SalesLineGraph = New LiveCharts.WinForms.CartesianChart()
            Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel16 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.StartingDateDateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
            Me.EndDateDateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
            Me.Guna2HtmlLabel17 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.FilterButton = New Guna.UI2.WinForms.Guna2TileButton()
            Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
            Me.StartDateTextBox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.Guna2ShadowPanel1.SuspendLayout()
            Me.Guna2ShadowPanel2.SuspendLayout()
            Me.Guna2ShadowPanel3.SuspendLayout()
            Me.Guna2ShadowPanel5.SuspendLayout()
            CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Guna2ShadowPanel1
            '
            Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2ShadowPanel1.Controls.Add(Me.TotalSalesLabel)
            Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2PictureBox1)
            Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
            Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(27, 71)
            Me.Guna2ShadowPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
            Me.Guna2ShadowPanel1.Radius = 20
            Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
            Me.Guna2ShadowPanel1.ShadowShift = 10
            Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(600, 297)
            Me.Guna2ShadowPanel1.TabIndex = 0
            '
            'TotalSalesLabel
            '
            Me.TotalSalesLabel.AutoSize = False
            Me.TotalSalesLabel.BackColor = System.Drawing.Color.Transparent
            Me.TotalSalesLabel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.TotalSalesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TotalSalesLabel.Location = New System.Drawing.Point(0, 147)
            Me.TotalSalesLabel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.TotalSalesLabel.MinimumSize = New System.Drawing.Size(349, 57)
            Me.TotalSalesLabel.Name = "TotalSalesLabel"
            Me.TotalSalesLabel.Size = New System.Drawing.Size(600, 150)
            Me.TotalSalesLabel.TabIndex = 2
            Me.TotalSalesLabel.Text = "₱ 0"
            Me.TotalSalesLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.AutoSize = False
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(128, 52)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(395, 58)
            Me.Guna2HtmlLabel1.TabIndex = 1
            Me.Guna2HtmlLabel1.Text = "Total Sales"
            '
            'Guna2ShadowPanel2
            '
            Me.Guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2ShadowPanel2.Controls.Add(Me.NumberOfCustomersLabel)
            Me.Guna2ShadowPanel2.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Guna2ShadowPanel2.Controls.Add(Me.Guna2PictureBox3)
            Me.Guna2ShadowPanel2.FillColor = System.Drawing.Color.White
            Me.Guna2ShadowPanel2.Location = New System.Drawing.Point(1257, 71)
            Me.Guna2ShadowPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
            Me.Guna2ShadowPanel2.Radius = 20
            Me.Guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black
            Me.Guna2ShadowPanel2.ShadowShift = 10
            Me.Guna2ShadowPanel2.Size = New System.Drawing.Size(600, 297)
            Me.Guna2ShadowPanel2.TabIndex = 1
            '
            'NumberOfCustomersLabel
            '
            Me.NumberOfCustomersLabel.AutoSize = False
            Me.NumberOfCustomersLabel.BackColor = System.Drawing.Color.Transparent
            Me.NumberOfCustomersLabel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.NumberOfCustomersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NumberOfCustomersLabel.Location = New System.Drawing.Point(0, 147)
            Me.NumberOfCustomersLabel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.NumberOfCustomersLabel.Name = "NumberOfCustomersLabel"
            Me.NumberOfCustomersLabel.Size = New System.Drawing.Size(600, 150)
            Me.NumberOfCustomersLabel.TabIndex = 6
            Me.NumberOfCustomersLabel.Text = "0"
            Me.NumberOfCustomersLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.AutoSize = False
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(120, 52)
            Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(535, 58)
            Me.Guna2HtmlLabel3.TabIndex = 3
            Me.Guna2HtmlLabel3.Text = "Total No. of Customer"
            '
            'Guna2ShadowPanel3
            '
            Me.Guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2ShadowPanel3.Controls.Add(Me.NetProfitLabel)
            Me.Guna2ShadowPanel3.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Guna2ShadowPanel3.Controls.Add(Me.Guna2PictureBox2)
            Me.Guna2ShadowPanel3.FillColor = System.Drawing.Color.White
            Me.Guna2ShadowPanel3.Location = New System.Drawing.Point(643, 71)
            Me.Guna2ShadowPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2ShadowPanel3.Name = "Guna2ShadowPanel3"
            Me.Guna2ShadowPanel3.Radius = 20
            Me.Guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black
            Me.Guna2ShadowPanel3.ShadowShift = 10
            Me.Guna2ShadowPanel3.Size = New System.Drawing.Size(600, 297)
            Me.Guna2ShadowPanel3.TabIndex = 2
            '
            'NetProfitLabel
            '
            Me.NetProfitLabel.AutoSize = False
            Me.NetProfitLabel.BackColor = System.Drawing.Color.Transparent
            Me.NetProfitLabel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.NetProfitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NetProfitLabel.Location = New System.Drawing.Point(0, 147)
            Me.NetProfitLabel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.NetProfitLabel.Name = "NetProfitLabel"
            Me.NetProfitLabel.Size = New System.Drawing.Size(600, 150)
            Me.NetProfitLabel.TabIndex = 5
            Me.NetProfitLabel.Text = "₱ 0"
            Me.NetProfitLabel.TextAlignment = System.Drawing.ContentAlignment.TopCenter
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.AutoSize = False
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(133, 52)
            Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(411, 58)
            Me.Guna2HtmlLabel2.TabIndex = 2
            Me.Guna2HtmlLabel2.Text = "Net Profit"
            '
            'Guna2ShadowPanel5
            '
            Me.Guna2ShadowPanel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2ShadowPanel5.Controls.Add(Me.SalesLineGraph)
            Me.Guna2ShadowPanel5.Controls.Add(Me.Guna2HtmlLabel13)
            Me.Guna2ShadowPanel5.FillColor = System.Drawing.Color.White
            Me.Guna2ShadowPanel5.Location = New System.Drawing.Point(33, 385)
            Me.Guna2ShadowPanel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2ShadowPanel5.Name = "Guna2ShadowPanel5"
            Me.Guna2ShadowPanel5.Radius = 20
            Me.Guna2ShadowPanel5.ShadowColor = System.Drawing.Color.Black
            Me.Guna2ShadowPanel5.ShadowShift = 10
            Me.Guna2ShadowPanel5.Size = New System.Drawing.Size(1825, 562)
            Me.Guna2ShadowPanel5.TabIndex = 2
            '
            'SalesLineGraph
            '
            Me.SalesLineGraph.Location = New System.Drawing.Point(40, 98)
            Me.SalesLineGraph.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.SalesLineGraph.Name = "SalesLineGraph"
            Me.SalesLineGraph.Size = New System.Drawing.Size(1738, 418)
            Me.SalesLineGraph.TabIndex = 8
            Me.SalesLineGraph.Text = "CartesianChart1"
            '
            'Guna2HtmlLabel13
            '
            Me.Guna2HtmlLabel13.AutoSize = False
            Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel13.Dock = System.Windows.Forms.DockStyle.Top
            Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
            Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(0, 0)
            Me.Guna2HtmlLabel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
            Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(1825, 94)
            Me.Guna2HtmlLabel13.TabIndex = 7
            Me.Guna2HtmlLabel13.Text = "Sales Trend"
            Me.Guna2HtmlLabel13.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Guna2HtmlLabel16
            '
            Me.Guna2HtmlLabel16.AutoSize = False
            Me.Guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel16.ForeColor = System.Drawing.Color.DimGray
            Me.Guna2HtmlLabel16.Location = New System.Drawing.Point(33, 16)
            Me.Guna2HtmlLabel16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2HtmlLabel16.MinimumSize = New System.Drawing.Size(220, 39)
            Me.Guna2HtmlLabel16.Name = "Guna2HtmlLabel16"
            Me.Guna2HtmlLabel16.Size = New System.Drawing.Size(240, 40)
            Me.Guna2HtmlLabel16.TabIndex = 8
            Me.Guna2HtmlLabel16.Text = "Date Period:"
            Me.Guna2HtmlLabel16.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
            '
            'StartingDateDateTimePicker
            '
            Me.StartingDateDateTimePicker.BackColor = System.Drawing.Color.White
            Me.StartingDateDateTimePicker.BorderRadius = 20
            Me.StartingDateDateTimePicker.Checked = True
            Me.StartingDateDateTimePicker.FillColor = System.Drawing.Color.White
            Me.StartingDateDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.StartingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            Me.StartingDateDateTimePicker.Location = New System.Drawing.Point(284, 7)
            Me.StartingDateDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.StartingDateDateTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
            Me.StartingDateDateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
            Me.StartingDateDateTimePicker.Name = "StartingDateDateTimePicker"
            Me.StartingDateDateTimePicker.Size = New System.Drawing.Size(255, 54)
            Me.StartingDateDateTimePicker.TabIndex = 3
            Me.StartingDateDateTimePicker.Value = New Date(2025, 4, 4, 1, 20, 49, 920)
            '
            'EndDateDateTimePicker
            '
            Me.EndDateDateTimePicker.BackColor = System.Drawing.Color.White
            Me.EndDateDateTimePicker.BorderRadius = 20
            Me.EndDateDateTimePicker.Checked = True
            Me.EndDateDateTimePicker.FillColor = System.Drawing.Color.White
            Me.EndDateDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.EndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            Me.EndDateDateTimePicker.Location = New System.Drawing.Point(613, 7)
            Me.EndDateDateTimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.EndDateDateTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
            Me.EndDateDateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
            Me.EndDateDateTimePicker.Name = "EndDateDateTimePicker"
            Me.EndDateDateTimePicker.Size = New System.Drawing.Size(255, 54)
            Me.EndDateDateTimePicker.TabIndex = 10
            Me.EndDateDateTimePicker.Value = New Date(2025, 4, 4, 1, 20, 49, 920)
            '
            'Guna2HtmlLabel17
            '
            Me.Guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
            Me.Guna2HtmlLabel17.Location = New System.Drawing.Point(557, 23)
            Me.Guna2HtmlLabel17.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2HtmlLabel17.Name = "Guna2HtmlLabel17"
            Me.Guna2HtmlLabel17.Size = New System.Drawing.Size(33, 27)
            Me.Guna2HtmlLabel17.TabIndex = 6
            Me.Guna2HtmlLabel17.Text = "To:"
            Me.Guna2HtmlLabel17.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
            '
            'FilterButton
            '
            Me.FilterButton.BackgroundImage = Global.KioskV0.My.Resources.Resources.magnifying_glass__1_
            Me.FilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.FilterButton.BorderColor = System.Drawing.Color.Transparent
            Me.FilterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.FilterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.FilterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.FilterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.FilterButton.FillColor = System.Drawing.Color.Transparent
            Me.FilterButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.FilterButton.ForeColor = System.Drawing.Color.White
            Me.FilterButton.Location = New System.Drawing.Point(885, 14)
            Me.FilterButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.FilterButton.Name = "FilterButton"
            Me.FilterButton.Size = New System.Drawing.Size(43, 42)
            Me.FilterButton.TabIndex = 12
            '
            'Guna2TextBox1
            '
            Me.Guna2TextBox1.Animated = True
            Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Gray
            Me.Guna2TextBox1.BorderRadius = 20
            Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.Guna2TextBox1.DefaultText = "End Date"
            Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.Guna2TextBox1.Enabled = False
            Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 10.2!)
            Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Guna2TextBox1.IconLeft = Global.KioskV0.My.Resources.Resources.calendar__1_
            Me.Guna2TextBox1.IconLeftOffset = New System.Drawing.Point(20, 0)
            Me.Guna2TextBox1.Location = New System.Drawing.Point(613, 7)
            Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.Guna2TextBox1.Name = "Guna2TextBox1"
            Me.Guna2TextBox1.PlaceholderText = "End Date"
            Me.Guna2TextBox1.SelectedText = ""
            Me.Guna2TextBox1.Size = New System.Drawing.Size(255, 54)
            Me.Guna2TextBox1.TabIndex = 11
            Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.Guna2TextBox1.TextOffset = New System.Drawing.Point(-3, 0)
            '
            'StartDateTextBox
            '
            Me.StartDateTextBox.Animated = True
            Me.StartDateTextBox.BorderColor = System.Drawing.Color.Gray
            Me.StartDateTextBox.BorderRadius = 20
            Me.StartDateTextBox.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.StartDateTextBox.DefaultText = "Start Date"
            Me.StartDateTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.StartDateTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.StartDateTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.StartDateTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.StartDateTextBox.Enabled = False
            Me.StartDateTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.StartDateTextBox.Font = New System.Drawing.Font("Segoe UI", 10.2!)
            Me.StartDateTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.StartDateTextBox.IconLeft = Global.KioskV0.My.Resources.Resources.calendar__1_
            Me.StartDateTextBox.IconLeftOffset = New System.Drawing.Point(20, 0)
            Me.StartDateTextBox.Location = New System.Drawing.Point(284, 7)
            Me.StartDateTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.StartDateTextBox.Name = "StartDateTextBox"
            Me.StartDateTextBox.PlaceholderText = "Start Date"
            Me.StartDateTextBox.SelectedText = ""
            Me.StartDateTextBox.Size = New System.Drawing.Size(255, 54)
            Me.StartDateTextBox.TabIndex = 9
            Me.StartDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.StartDateTextBox.TextOffset = New System.Drawing.Point(-3, 0)
            '
            'Guna2PictureBox2
            '
            Me.Guna2PictureBox2.Image = Global.KioskV0.My.Resources.Resources.money_bag
            Me.Guna2PictureBox2.ImageRotate = 0!
            Me.Guna2PictureBox2.Location = New System.Drawing.Point(49, 39)
            Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
            Me.Guna2PictureBox2.Size = New System.Drawing.Size(69, 70)
            Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.Guna2PictureBox2.TabIndex = 1
            Me.Guna2PictureBox2.TabStop = False
            '
            'Guna2PictureBox3
            '
            Me.Guna2PictureBox3.Image = Global.KioskV0.My.Resources.Resources.customer
            Me.Guna2PictureBox3.ImageRotate = 0!
            Me.Guna2PictureBox3.Location = New System.Drawing.Point(45, 39)
            Me.Guna2PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
            Me.Guna2PictureBox3.Size = New System.Drawing.Size(69, 70)
            Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.Guna2PictureBox3.TabIndex = 2
            Me.Guna2PictureBox3.TabStop = False
            '
            'Guna2PictureBox1
            '
            Me.Guna2PictureBox1.Image = Global.KioskV0.My.Resources.Resources.increase
            Me.Guna2PictureBox1.ImageRotate = 0!
            Me.Guna2PictureBox1.Location = New System.Drawing.Point(45, 39)
            Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
            Me.Guna2PictureBox1.Size = New System.Drawing.Size(69, 70)
            Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.Guna2PictureBox1.TabIndex = 0
            Me.Guna2PictureBox1.TabStop = False
            '
            'AdminDashboardView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1900, 999)
            Me.Controls.Add(Me.FilterButton)
            Me.Controls.Add(Me.Guna2TextBox1)
            Me.Controls.Add(Me.Guna2HtmlLabel17)
            Me.Controls.Add(Me.EndDateDateTimePicker)
            Me.Controls.Add(Me.StartDateTextBox)
            Me.Controls.Add(Me.Guna2HtmlLabel16)
            Me.Controls.Add(Me.StartingDateDateTimePicker)
            Me.Controls.Add(Me.Guna2ShadowPanel5)
            Me.Controls.Add(Me.Guna2ShadowPanel3)
            Me.Controls.Add(Me.Guna2ShadowPanel2)
            Me.Controls.Add(Me.Guna2ShadowPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "AdminDashboardView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "AdminDashboard"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Guna2ShadowPanel1.ResumeLayout(False)
            Me.Guna2ShadowPanel2.ResumeLayout(False)
            Me.Guna2ShadowPanel3.ResumeLayout(False)
            Me.Guna2ShadowPanel5.ResumeLayout(False)
            CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
        Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
        Friend WithEvents Guna2ShadowPanel3 As Guna.UI2.WinForms.Guna2ShadowPanel
        Friend WithEvents Guna2ShadowPanel5 As Guna.UI2.WinForms.Guna2ShadowPanel
        Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents TotalSalesLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents NumberOfCustomersLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents NetProfitLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents SalesLineGraph As LiveCharts.WinForms.CartesianChart
        Friend WithEvents Guna2HtmlLabel16 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents StartingDateDateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
        Friend WithEvents StartDateTextBox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents EndDateDateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
        Friend WithEvents Guna2HtmlLabel17 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents FilterButton As Guna.UI2.WinForms.Guna2TileButton
    End Class
End Namespace