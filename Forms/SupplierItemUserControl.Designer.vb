Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierItemUserControl
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
            Me.ItemDesc = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ItemId = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ItemName = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.EditButton = New Guna.UI2.WinForms.Guna2Button()
            Me.RequestIdLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.DeleteButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel1.BorderRadius = 20
            Me.Guna2Panel1.BorderThickness = 2
            Me.Guna2Panel1.Controls.Add(Me.DeleteButton)
            Me.Guna2Panel1.Controls.Add(Me.ItemDesc)
            Me.Guna2Panel1.Controls.Add(Me.ItemId)
            Me.Guna2Panel1.Controls.Add(Me.ItemName)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Guna2Panel1.Controls.Add(Me.EditButton)
            Me.Guna2Panel1.Controls.Add(Me.RequestIdLabel)
            Me.Guna2Panel1.FillColor = System.Drawing.Color.White
            Me.Guna2Panel1.Location = New System.Drawing.Point(29, 26)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(382, 276)
            Me.Guna2Panel1.TabIndex = 0
            '
            'ItemDesc
            '
            Me.ItemDesc.BackColor = System.Drawing.Color.Transparent
            Me.ItemDesc.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ItemDesc.Location = New System.Drawing.Point(17, 153)
            Me.ItemDesc.Name = "ItemDesc"
            Me.ItemDesc.Size = New System.Drawing.Size(121, 39)
            Me.ItemDesc.TabIndex = 36
            Me.ItemDesc.Text = "Description"
            '
            'ItemId
            '
            Me.ItemId.BackColor = System.Drawing.Color.Transparent
            Me.ItemId.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ItemId.Location = New System.Drawing.Point(65, 63)
            Me.ItemId.Name = "ItemId"
            Me.ItemId.Size = New System.Drawing.Size(23, 39)
            Me.ItemId.TabIndex = 35
            Me.ItemId.Text = "ID"
            '
            'ItemName
            '
            Me.ItemName.BackColor = System.Drawing.Color.Transparent
            Me.ItemName.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ItemName.Location = New System.Drawing.Point(107, 18)
            Me.ItemName.Name = "ItemName"
            Me.ItemName.Size = New System.Drawing.Size(67, 39)
            Me.ItemName.TabIndex = 34
            Me.ItemName.Text = "Name"
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(17, 108)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(125, 39)
            Me.Guna2HtmlLabel2.TabIndex = 32
            Me.Guna2HtmlLabel2.Text = "Description:"
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(17, 63)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(27, 39)
            Me.Guna2HtmlLabel1.TabIndex = 31
            Me.Guna2HtmlLabel1.Text = "ID:"
            '
            'EditButton
            '
            Me.EditButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.EditButton.BorderRadius = 15
            Me.EditButton.BorderThickness = 1
            Me.EditButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.EditButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.EditButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.EditButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.EditButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.EditButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EditButton.ForeColor = System.Drawing.Color.White
            Me.EditButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.EditButton.HoverState.FillColor = System.Drawing.Color.White
            Me.EditButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.EditButton.Location = New System.Drawing.Point(253, 224)
            Me.EditButton.Margin = New System.Windows.Forms.Padding(2)
            Me.EditButton.Name = "EditButton"
            Me.EditButton.Size = New System.Drawing.Size(112, 32)
            Me.EditButton.TabIndex = 30
            Me.EditButton.Text = "Edit"
            '
            'RequestIdLabel
            '
            Me.RequestIdLabel.BackColor = System.Drawing.Color.Transparent
            Me.RequestIdLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RequestIdLabel.Location = New System.Drawing.Point(17, 18)
            Me.RequestIdLabel.Name = "RequestIdLabel"
            Me.RequestIdLabel.Size = New System.Drawing.Size(71, 39)
            Me.RequestIdLabel.TabIndex = 29
            Me.RequestIdLabel.Text = "Name:"
            '
            'DeleteButton
            '
            Me.DeleteButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeleteButton.BorderRadius = 15
            Me.DeleteButton.BorderThickness = 1
            Me.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.DeleteButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeleteButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DeleteButton.ForeColor = System.Drawing.Color.White
            Me.DeleteButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeleteButton.HoverState.FillColor = System.Drawing.Color.White
            Me.DeleteButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeleteButton.Location = New System.Drawing.Point(124, 224)
            Me.DeleteButton.Margin = New System.Windows.Forms.Padding(2)
            Me.DeleteButton.Name = "DeleteButton"
            Me.DeleteButton.Size = New System.Drawing.Size(112, 32)
            Me.DeleteButton.TabIndex = 37
            Me.DeleteButton.Text = "Delete"
            '
            'SupplierItemUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Name = "SupplierItemUserControl"
            Me.Size = New System.Drawing.Size(414, 317)
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents RequestIdLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents EditButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents ItemDesc As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ItemId As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ItemName As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents DeleteButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace