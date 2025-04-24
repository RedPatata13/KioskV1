Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdminStaffTransactionsView
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
            Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminStaffTransactionsView))
            Me.StaffTransacDataGrid = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.SupplyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.StaffNameComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
            Me.SearchItem = New Guna.UI2.WinForms.Guna2TextBox()
            CType(Me.StaffTransacDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Guna2Panel7.SuspendLayout()
            Me.Guna2Panel6.SuspendLayout()
            Me.Guna2Panel5.SuspendLayout()
            Me.Guna2Panel4.SuspendLayout()
            Me.Guna2Panel3.SuspendLayout()
            Me.Guna2Panel2.SuspendLayout()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'StaffTransacDataGrid
            '
            Me.StaffTransacDataGrid.AllowUserToResizeRows = False
            DataGridViewCellStyle25.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.StaffTransacDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
            DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            DataGridViewCellStyle26.Font = New System.Drawing.Font("Poppins SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.StaffTransacDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
            Me.StaffTransacDataGrid.ColumnHeadersHeight = 4
            Me.StaffTransacDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.StaffTransacDataGrid.ColumnHeadersVisible = False
            Me.StaffTransacDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplyID, Me.ProductName})
            DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle27.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.StaffTransacDataGrid.DefaultCellStyle = DataGridViewCellStyle27
            Me.StaffTransacDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.StaffTransacDataGrid.Location = New System.Drawing.Point(39, 228)
            Me.StaffTransacDataGrid.Margin = New System.Windows.Forms.Padding(2)
            Me.StaffTransacDataGrid.Name = "StaffTransacDataGrid"
            Me.StaffTransacDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle28.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.White
            DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.StaffTransacDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
            Me.StaffTransacDataGrid.RowHeadersVisible = False
            Me.StaffTransacDataGrid.RowHeadersWidth = 51
            Me.StaffTransacDataGrid.RowTemplate.Height = 24
            Me.StaffTransacDataGrid.Size = New System.Drawing.Size(1251, 608)
            Me.StaffTransacDataGrid.TabIndex = 6
            Me.StaffTransacDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.StaffTransacDataGrid.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StaffTransacDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
            Me.StaffTransacDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.StaffTransacDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.StaffTransacDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.StaffTransacDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.StaffTransacDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.StaffTransacDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.StaffTransacDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StaffTransacDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.StaffTransacDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.StaffTransacDataGrid.ThemeStyle.HeaderStyle.Height = 4
            Me.StaffTransacDataGrid.ThemeStyle.ReadOnly = False
            Me.StaffTransacDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.StaffTransacDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.StaffTransacDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StaffTransacDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.StaffTransacDataGrid.ThemeStyle.RowsStyle.Height = 24
            Me.StaffTransacDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.StaffTransacDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
            'StaffNameComboBox
            '
            Me.StaffNameComboBox.BackColor = System.Drawing.Color.Transparent
            Me.StaffNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.StaffNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.StaffNameComboBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.StaffNameComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.StaffNameComboBox.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StaffNameComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.StaffNameComboBox.ItemHeight = 30
            Me.StaffNameComboBox.Location = New System.Drawing.Point(51, 105)
            Me.StaffNameComboBox.Margin = New System.Windows.Forms.Padding(2)
            Me.StaffNameComboBox.Name = "StaffNameComboBox"
            Me.StaffNameComboBox.Size = New System.Drawing.Size(272, 36)
            Me.StaffNameComboBox.TabIndex = 7
            Me.StaffNameComboBox.Tag = ""
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.AutoSize = False
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(30, 36)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(360, 61)
            Me.Guna2HtmlLabel1.TabIndex = 9
            Me.Guna2HtmlLabel1.Text = "Staff Transactions"
            '
            'Guna2Panel7
            '
            Me.Guna2Panel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel7.BorderRadius = 15
            Me.Guna2Panel7.Controls.Add(Me.Guna2HtmlLabel8)
            Me.Guna2Panel7.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel7.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel7.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel7.Location = New System.Drawing.Point(1105, 183)
            Me.Guna2Panel7.Name = "Guna2Panel7"
            Me.Guna2Panel7.Size = New System.Drawing.Size(185, 40)
            Me.Guna2Panel7.TabIndex = 20
            '
            'Guna2HtmlLabel8
            '
            Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(69, 6)
            Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
            Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(41, 30)
            Me.Guna2HtmlLabel8.TabIndex = 13
            Me.Guna2HtmlLabel8.Text = "Date"
            '
            'Guna2Panel6
            '
            Me.Guna2Panel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel6.BorderRadius = 15
            Me.Guna2Panel6.Controls.Add(Me.Guna2HtmlLabel7)
            Me.Guna2Panel6.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel6.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel6.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel6.Location = New System.Drawing.Point(934, 183)
            Me.Guna2Panel6.Name = "Guna2Panel6"
            Me.Guna2Panel6.Size = New System.Drawing.Size(165, 40)
            Me.Guna2Panel6.TabIndex = 21
            '
            'Guna2HtmlLabel7
            '
            Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(47, 6)
            Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
            Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(67, 30)
            Me.Guna2HtmlLabel7.TabIndex = 13
            Me.Guna2HtmlLabel7.Text = "Change"
            '
            'Guna2Panel5
            '
            Me.Guna2Panel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel5.BorderRadius = 15
            Me.Guna2Panel5.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel5.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel5.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel5.Location = New System.Drawing.Point(748, 183)
            Me.Guna2Panel5.Name = "Guna2Panel5"
            Me.Guna2Panel5.Size = New System.Drawing.Size(180, 40)
            Me.Guna2Panel5.TabIndex = 22
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(49, 7)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(83, 30)
            Me.Guna2HtmlLabel6.TabIndex = 13
            Me.Guna2HtmlLabel6.Text = "Cash Paid"
            '
            'Guna2Panel4
            '
            Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel4.BorderRadius = 15
            Me.Guna2Panel4.Controls.Add(Me.Guna2HtmlLabel5)
            Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel4.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel4.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel4.Location = New System.Drawing.Point(566, 183)
            Me.Guna2Panel4.Name = "Guna2Panel4"
            Me.Guna2Panel4.Size = New System.Drawing.Size(176, 40)
            Me.Guna2Panel4.TabIndex = 23
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(53, 7)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(70, 30)
            Me.Guna2HtmlLabel5.TabIndex = 13
            Me.Guna2HtmlLabel5.Text = "Subtotal"
            '
            'Guna2Panel3
            '
            Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel3.BorderRadius = 15
            Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel3.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel3.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel3.Location = New System.Drawing.Point(381, 183)
            Me.Guna2Panel3.Name = "Guna2Panel3"
            Me.Guna2Panel3.Size = New System.Drawing.Size(179, 40)
            Me.Guna2Panel3.TabIndex = 19
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(45, 7)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(68, 30)
            Me.Guna2HtmlLabel4.TabIndex = 13
            Me.Guna2HtmlLabel4.Text = "Order ID"
            '
            'Guna2Panel2
            '
            Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel2.BorderRadius = 15
            Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel2.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel2.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel2.Location = New System.Drawing.Point(210, 183)
            Me.Guna2Panel2.Name = "Guna2Panel2"
            Me.Guna2Panel2.Size = New System.Drawing.Size(165, 40)
            Me.Guna2Panel2.TabIndex = 18
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(54, 7)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(48, 30)
            Me.Guna2HtmlLabel3.TabIndex = 13
            Me.Guna2HtmlLabel3.Text = "Mode"
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.BorderRadius = 15
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel1.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2Panel1.ForeColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.Location = New System.Drawing.Point(39, 183)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(165, 40)
            Me.Guna2Panel1.TabIndex = 17
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(58, 7)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(38, 30)
            Me.Guna2HtmlLabel2.TabIndex = 13
            Me.Guna2HtmlLabel2.Text = "User"
            '
            'SearchItem
            '
            Me.SearchItem.BorderRadius = 15
            Me.SearchItem.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.SearchItem.DefaultText = ""
            Me.SearchItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.SearchItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.SearchItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchItem.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.SearchItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SearchItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.SearchItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SearchItem.IconLeft = CType(resources.GetObject("SearchItem.IconLeft"), System.Drawing.Image)
            Me.SearchItem.IconLeftOffset = New System.Drawing.Point(10, 0)
            Me.SearchItem.IconLeftSize = New System.Drawing.Size(25, 25)
            Me.SearchItem.Location = New System.Drawing.Point(936, 96)
            Me.SearchItem.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.SearchItem.Name = "SearchItem"
            Me.SearchItem.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
            Me.SearchItem.PlaceholderText = "Search item"
            Me.SearchItem.SelectedText = ""
            Me.SearchItem.Size = New System.Drawing.Size(301, 45)
            Me.SearchItem.TabIndex = 4
            '
            'AdminStaffTransactionsView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1321, 878)
            Me.Controls.Add(Me.Guna2Panel7)
            Me.Controls.Add(Me.Guna2Panel6)
            Me.Controls.Add(Me.Guna2Panel5)
            Me.Controls.Add(Me.Guna2Panel4)
            Me.Controls.Add(Me.Guna2Panel3)
            Me.Controls.Add(Me.Guna2Panel2)
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.StaffNameComboBox)
            Me.Controls.Add(Me.StaffTransacDataGrid)
            Me.Controls.Add(Me.SearchItem)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "AdminStaffTransactionsView"
            Me.Text = "AdminStaffTransactions"
            CType(Me.StaffTransacDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents SearchItem As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents StaffTransacDataGrid As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents SupplyID As DataGridViewTextBoxColumn
        Friend WithEvents ProductName As DataGridViewTextBoxColumn
        Friend WithEvents StaffNameComboBox As Guna.UI2.WinForms.Guna2ComboBox
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
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
    End Class

End Namespace