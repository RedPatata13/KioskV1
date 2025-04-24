<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminStockDebtView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StockDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SupplyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResolvedButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.UnresolvedCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ShowResolved = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel7 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.StockDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel7.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.Guna2Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'StockDataGrid
        '
        Me.StockDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.StockDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StockDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StockDataGrid.ColumnHeadersHeight = 4
        Me.StockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.StockDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplyID, Me.ProductName})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StockDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.StockDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StockDataGrid.Location = New System.Drawing.Point(16, 213)
        Me.StockDataGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.StockDataGrid.Name = "StockDataGrid"
        Me.StockDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StockDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.StockDataGrid.RowHeadersVisible = False
        Me.StockDataGrid.RowHeadersWidth = 51
        Me.StockDataGrid.RowTemplate.Height = 24
        Me.StockDataGrid.Size = New System.Drawing.Size(1254, 581)
        Me.StockDataGrid.TabIndex = 5
        Me.StockDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.StockDataGrid.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StockDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StockDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.StockDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.StockDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StockDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StockDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StockDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.StockDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.StockDataGrid.ThemeStyle.HeaderStyle.Height = 4
        Me.StockDataGrid.ThemeStyle.ReadOnly = False
        Me.StockDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.StockDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StockDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.StockDataGrid.ThemeStyle.RowsStyle.Height = 24
        Me.StockDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StockDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'SupplyID
        '
        Me.SupplyID.HeaderText = "ID"
        Me.SupplyID.MinimumWidth = 6
        Me.SupplyID.Name = "SupplyID"
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "Product"
        Me.ProductName.MinimumWidth = 6
        Me.ProductName.Name = "ProductName"
        '
        'ResolvedButton
        '
        Me.ResolvedButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResolvedButton.BorderRadius = 15
        Me.ResolvedButton.BorderThickness = 1
        Me.ResolvedButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ResolvedButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ResolvedButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ResolvedButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ResolvedButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResolvedButton.Font = New System.Drawing.Font("Poppins", 10.8!)
        Me.ResolvedButton.ForeColor = System.Drawing.Color.White
        Me.ResolvedButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResolvedButton.HoverState.FillColor = System.Drawing.Color.White
        Me.ResolvedButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResolvedButton.Location = New System.Drawing.Point(1045, 86)
        Me.ResolvedButton.Name = "ResolvedButton"
        Me.ResolvedButton.Size = New System.Drawing.Size(225, 51)
        Me.ResolvedButton.TabIndex = 11
        Me.ResolvedButton.Text = "Resolve"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(16, 8)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(466, 52)
        Me.Guna2HtmlLabel1.TabIndex = 12
        Me.Guna2HtmlLabel1.Text = "Stock Debt"
        '
        'UnresolvedCount
        '
        Me.UnresolvedCount.AutoSize = False
        Me.UnresolvedCount.BackColor = System.Drawing.Color.Transparent
        Me.UnresolvedCount.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnresolvedCount.Location = New System.Drawing.Point(16, 64)
        Me.UnresolvedCount.Margin = New System.Windows.Forms.Padding(2)
        Me.UnresolvedCount.Name = "UnresolvedCount"
        Me.UnresolvedCount.Size = New System.Drawing.Size(466, 32)
        Me.UnresolvedCount.TabIndex = 13
        Me.UnresolvedCount.Text = "There's 0 unresolved stock debt!"
        '
        'ShowResolved
        '
        Me.ShowResolved.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowResolved.BorderRadius = 15
        Me.ShowResolved.BorderThickness = 1
        Me.ShowResolved.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ShowResolved.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ShowResolved.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ShowResolved.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ShowResolved.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowResolved.Font = New System.Drawing.Font("Poppins", 10.8!)
        Me.ShowResolved.ForeColor = System.Drawing.Color.White
        Me.ShowResolved.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowResolved.HoverState.FillColor = System.Drawing.Color.White
        Me.ShowResolved.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowResolved.Location = New System.Drawing.Point(796, 86)
        Me.ShowResolved.Name = "ShowResolved"
        Me.ShowResolved.Size = New System.Drawing.Size(225, 51)
        Me.ShowResolved.TabIndex = 14
        Me.ShowResolved.Text = "Show previously resolved"
        '
        'Guna2Panel7
        '
        Me.Guna2Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel7.BorderRadius = 15
        Me.Guna2Panel7.Controls.Add(Me.Guna2HtmlLabel8)
        Me.Guna2Panel7.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Panel7.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Panel7.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel7.Location = New System.Drawing.Point(817, 164)
        Me.Guna2Panel7.Name = "Guna2Panel7"
        Me.Guna2Panel7.Size = New System.Drawing.Size(167, 40)
        Me.Guna2Panel7.TabIndex = 20
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(26, 6)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(113, 30)
        Me.Guna2HtmlLabel8.TabIndex = 13
        Me.Guna2HtmlLabel8.Text = "Generated by"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.BorderRadius = 15
        Me.Guna2Panel6.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Panel6.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Panel6.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel6.Location = New System.Drawing.Point(674, 164)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.Size = New System.Drawing.Size(137, 40)
        Me.Guna2Panel6.TabIndex = 21
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(27, 7)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(62, 30)
        Me.Guna2HtmlLabel7.TabIndex = 13
        Me.Guna2HtmlLabel7.Text = "Reason"
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.BorderRadius = 15
        Me.Guna2Panel5.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Panel5.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Panel5.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel5.Location = New System.Drawing.Point(552, 164)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(116, 40)
        Me.Guna2Panel5.TabIndex = 22
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(25, 7)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(53, 30)
        Me.Guna2HtmlLabel6.TabIndex = 13
        Me.Guna2HtmlLabel6.Text = "Status"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.BorderRadius = 15
        Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Panel4.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Panel4.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel4.Location = New System.Drawing.Point(413, 164)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(135, 40)
        Me.Guna2Panel4.TabIndex = 23
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(42, 6)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(41, 30)
        Me.Guna2HtmlLabel5.TabIndex = 13
        Me.Guna2HtmlLabel5.Text = "Date"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 15
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Panel3.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Panel3.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Location = New System.Drawing.Point(294, 164)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(115, 40)
        Me.Guna2Panel3.TabIndex = 19
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(34, 5)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(42, 30)
        Me.Guna2HtmlLabel4.TabIndex = 13
        Me.Guna2HtmlLabel4.Text = "Units"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Panel2.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Panel2.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.Location = New System.Drawing.Point(168, 164)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(120, 43)
        Me.Guna2Panel2.TabIndex = 18
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(31, 7)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(58, 30)
        Me.Guna2HtmlLabel3.TabIndex = 13
        Me.Guna2HtmlLabel3.Text = "Item Id"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Panel1.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(16, 164)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(146, 40)
        Me.Guna2Panel1.TabIndex = 17
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(42, 5)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(39, 30)
        Me.Guna2HtmlLabel2.TabIndex = 13
        Me.Guna2HtmlLabel2.Text = "Item"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(30, 7)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(62, 30)
        Me.Guna2HtmlLabel9.TabIndex = 13
        Me.Guna2HtmlLabel9.Text = "Version"
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel8.BorderRadius = 15
        Me.Guna2Panel8.Controls.Add(Me.Guna2HtmlLabel9)
        Me.Guna2Panel8.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Panel8.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Panel8.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel8.Location = New System.Drawing.Point(990, 164)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(137, 40)
        Me.Guna2Panel8.TabIndex = 24
        '
        'Guna2Panel9
        '
        Me.Guna2Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel9.BorderRadius = 15
        Me.Guna2Panel9.Controls.Add(Me.Guna2HtmlLabel10)
        Me.Guna2Panel9.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.Guna2Panel9.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Panel9.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Panel9.Location = New System.Drawing.Point(1133, 164)
        Me.Guna2Panel9.Name = "Guna2Panel9"
        Me.Guna2Panel9.Size = New System.Drawing.Size(137, 40)
        Me.Guna2Panel9.TabIndex = 25
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(32, 7)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(64, 30)
        Me.Guna2HtmlLabel10.TabIndex = 13
        Me.Guna2HtmlLabel10.Text = "Resolve"
        '
        'AdminStockDebtView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1305, 839)
        Me.Controls.Add(Me.Guna2Panel9)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.Controls.Add(Me.Guna2Panel7)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.ShowResolved)
        Me.Controls.Add(Me.UnresolvedCount)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.ResolvedButton)
        Me.Controls.Add(Me.StockDataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminStockDebtView"
        Me.Text = "AdminStockDebtView"
        CType(Me.StockDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel7.ResumeLayout(False)
        Me.Guna2Panel7.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2Panel8.PerformLayout()
        Me.Guna2Panel9.ResumeLayout(False)
        Me.Guna2Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StockDataGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SupplyID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents ResolvedButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UnresolvedCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ShowResolved As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel7 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
