Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierAdminBatchReqView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SupplierAdminBatchReqView))
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.ViewModeButton = New Guna.UI2.WinForms.Guna2Button()
            Me.ViewBatchDetailButton = New Guna.UI2.WinForms.Guna2Button()
            Me.SearchUser = New Guna.UI2.WinForms.Guna2TextBox()
            Me.BatchRequestDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            CType(Me.BatchRequestDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ViewModeButton
            '
            Me.ViewModeButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewModeButton.BorderRadius = 15
            Me.ViewModeButton.BorderThickness = 1
            Me.ViewModeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.ViewModeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.ViewModeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.ViewModeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.ViewModeButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewModeButton.Font = New System.Drawing.Font("Poppins", 10.8!)
            Me.ViewModeButton.ForeColor = System.Drawing.Color.White
            Me.ViewModeButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewModeButton.HoverState.FillColor = System.Drawing.Color.White
            Me.ViewModeButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewModeButton.Location = New System.Drawing.Point(737, 67)
            Me.ViewModeButton.Name = "ViewModeButton"
            Me.ViewModeButton.Size = New System.Drawing.Size(188, 45)
            Me.ViewModeButton.TabIndex = 19
            Me.ViewModeButton.Text = "Deprecated batches"
            '
            'ViewBatchDetailButton
            '
            Me.ViewBatchDetailButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewBatchDetailButton.BorderRadius = 15
            Me.ViewBatchDetailButton.BorderThickness = 1
            Me.ViewBatchDetailButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.ViewBatchDetailButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.ViewBatchDetailButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.ViewBatchDetailButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.ViewBatchDetailButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewBatchDetailButton.Font = New System.Drawing.Font("Poppins", 10.8!)
            Me.ViewBatchDetailButton.ForeColor = System.Drawing.Color.White
            Me.ViewBatchDetailButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewBatchDetailButton.HoverState.FillColor = System.Drawing.Color.White
            Me.ViewBatchDetailButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ViewBatchDetailButton.Location = New System.Drawing.Point(551, 67)
            Me.ViewBatchDetailButton.Name = "ViewBatchDetailButton"
            Me.ViewBatchDetailButton.Size = New System.Drawing.Size(180, 45)
            Me.ViewBatchDetailButton.TabIndex = 18
            Me.ViewBatchDetailButton.Text = "View batch detail"
            '
            'SearchUser
            '
            Me.SearchUser.BorderRadius = 15
            Me.SearchUser.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.SearchUser.DefaultText = ""
            Me.SearchUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.SearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.SearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.SearchUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.SearchUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SearchUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.SearchUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.SearchUser.IconLeft = CType(resources.GetObject("SearchUser.IconLeft"), System.Drawing.Image)
            Me.SearchUser.IconLeftOffset = New System.Drawing.Point(10, 0)
            Me.SearchUser.IconLeftSize = New System.Drawing.Size(25, 25)
            Me.SearchUser.Location = New System.Drawing.Point(949, 67)
            Me.SearchUser.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.SearchUser.Name = "SearchUser"
            Me.SearchUser.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
            Me.SearchUser.PlaceholderText = "Search AdminID/Admin Name/Item ID/Item Name"
            Me.SearchUser.SelectedText = ""
            Me.SearchUser.Size = New System.Drawing.Size(301, 45)
            Me.SearchUser.TabIndex = 17
            '
            'BatchRequestDataGridView
            '
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
            Me.BatchRequestDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.BatchRequestDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.BatchRequestDataGridView.ColumnHeadersHeight = 4
            Me.BatchRequestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.BatchRequestDataGridView.DefaultCellStyle = DataGridViewCellStyle3
            Me.BatchRequestDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.BatchRequestDataGridView.Location = New System.Drawing.Point(59, 127)
            Me.BatchRequestDataGridView.Name = "BatchRequestDataGridView"
            Me.BatchRequestDataGridView.RowHeadersVisible = False
            Me.BatchRequestDataGridView.Size = New System.Drawing.Size(1191, 688)
            Me.BatchRequestDataGridView.TabIndex = 16
            Me.BatchRequestDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
            Me.BatchRequestDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
            Me.BatchRequestDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
            Me.BatchRequestDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
            Me.BatchRequestDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
            Me.BatchRequestDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
            Me.BatchRequestDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.BatchRequestDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.BatchRequestDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            Me.BatchRequestDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BatchRequestDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
            Me.BatchRequestDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            Me.BatchRequestDataGridView.ThemeStyle.HeaderStyle.Height = 4
            Me.BatchRequestDataGridView.ThemeStyle.ReadOnly = False
            Me.BatchRequestDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
            Me.BatchRequestDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.BatchRequestDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BatchRequestDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            Me.BatchRequestDataGridView.ThemeStyle.RowsStyle.Height = 22
            Me.BatchRequestDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.BatchRequestDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(11, 11)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(405, 61)
            Me.Guna2HtmlLabel1.TabIndex = 15
            Me.Guna2HtmlLabel1.Text = "Item batch requests"
            '
            'SupplierAdminBatchReqView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1305, 839)
            Me.Controls.Add(Me.ViewModeButton)
            Me.Controls.Add(Me.ViewBatchDetailButton)
            Me.Controls.Add(Me.SearchUser)
            Me.Controls.Add(Me.BatchRequestDataGridView)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SupplierAdminBatchReqView"
            Me.Text = "Form1"
            CType(Me.BatchRequestDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents ViewModeButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents ViewBatchDetailButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents SearchUser As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents BatchRequestDataGridView As Guna.UI2.WinForms.Guna2DataGridView
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace