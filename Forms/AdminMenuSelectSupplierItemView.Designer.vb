<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenuSelectSupplierItemView
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BatchSelectionGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ConfirmButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CancelButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.BatchSelectionGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BatchSelectionGrid
        '
        Me.BatchSelectionGrid.AllowUserToAddRows = False
        Me.BatchSelectionGrid.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.BatchSelectionGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.BatchSelectionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.BatchSelectionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BatchSelectionGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.BatchSelectionGrid.ColumnHeadersHeight = 40
        Me.BatchSelectionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.BatchSelectionGrid.Cursor = System.Windows.Forms.Cursors.Cross
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BatchSelectionGrid.DefaultCellStyle = DataGridViewCellStyle9
        Me.BatchSelectionGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BatchSelectionGrid.Location = New System.Drawing.Point(8, 72)
        Me.BatchSelectionGrid.Name = "BatchSelectionGrid"
        Me.BatchSelectionGrid.ReadOnly = True
        Me.BatchSelectionGrid.RowHeadersVisible = False
        Me.BatchSelectionGrid.Size = New System.Drawing.Size(680, 368)
        Me.BatchSelectionGrid.TabIndex = 0
        Me.BatchSelectionGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.BatchSelectionGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.BatchSelectionGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.BatchSelectionGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.BatchSelectionGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.BatchSelectionGrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.BatchSelectionGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BatchSelectionGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BatchSelectionGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.BatchSelectionGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchSelectionGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BatchSelectionGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.BatchSelectionGrid.ThemeStyle.HeaderStyle.Height = 40
        Me.BatchSelectionGrid.ThemeStyle.ReadOnly = True
        Me.BatchSelectionGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BatchSelectionGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BatchSelectionGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BatchSelectionGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BatchSelectionGrid.ThemeStyle.RowsStyle.Height = 22
        Me.BatchSelectionGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BatchSelectionGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ConfirmButton
        '
        Me.ConfirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ConfirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ConfirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ConfirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ConfirmButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ConfirmButton.ForeColor = System.Drawing.Color.White
        Me.ConfirmButton.Location = New System.Drawing.Point(696, 72)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(96, 29)
        Me.ConfirmButton.TabIndex = 1
        Me.ConfirmButton.Text = "Confirm Batch"
        Me.ConfirmButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'CancelButton
        '
        Me.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CancelButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CancelButton.ForeColor = System.Drawing.Color.White
        Me.CancelButton.Location = New System.Drawing.Point(696, 112)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(96, 32)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(8, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(97, 15)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "Select Supplier Item"
        '
        'AdminMenuSelectSupplierItemView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.BatchSelectionGrid)
        Me.Name = "AdminMenuSelectSupplierItemView"
        Me.Text = "AdminMenuSelectSupplierItemView"
        CType(Me.BatchSelectionGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BatchSelectionGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ConfirmButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CancelButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
