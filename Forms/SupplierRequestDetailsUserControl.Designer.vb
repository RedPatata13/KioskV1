Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplierRequestDetailsUserControl
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
            Me.CostLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.SupplierLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.RequestIdLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.NoteLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.QuantityLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ProductLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CancelButton = New Guna.UI2.WinForms.Guna2Button()
            Me.AcceptButton = New Guna.UI2.WinForms.Guna2Button()
            Me.DeclineButton = New Guna.UI2.WinForms.Guna2Button()
            Me.Guna2Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel1
            '
            Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel1.BorderRadius = 20
            Me.Guna2Panel1.BorderThickness = 3
            Me.Guna2Panel1.Controls.Add(Me.DeclineButton)
            Me.Guna2Panel1.Controls.Add(Me.CostLabel)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
            Me.Guna2Panel1.Controls.Add(Me.SupplierLabel)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Guna2Panel1.Controls.Add(Me.RequestIdLabel)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
            Me.Guna2Panel1.Controls.Add(Me.NoteLabel)
            Me.Guna2Panel1.Controls.Add(Me.QuantityLabel)
            Me.Guna2Panel1.Controls.Add(Me.ProductLabel)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
            Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Guna2Panel1.Controls.Add(Me.CancelButton)
            Me.Guna2Panel1.Controls.Add(Me.AcceptButton)
            Me.Guna2Panel1.FillColor = System.Drawing.Color.White
            Me.Guna2Panel1.Location = New System.Drawing.Point(92, 77)
            Me.Guna2Panel1.Name = "Guna2Panel1"
            Me.Guna2Panel1.Size = New System.Drawing.Size(1100, 748)
            Me.Guna2Panel1.TabIndex = 0
            '
            'CostLabel
            '
            Me.CostLabel.BackColor = System.Drawing.Color.Transparent
            Me.CostLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CostLabel.Location = New System.Drawing.Point(215, 445)
            Me.CostLabel.Name = "CostLabel"
            Me.CostLabel.Size = New System.Drawing.Size(36, 39)
            Me.CostLabel.TabIndex = 39
            Me.CostLabel.Text = "100"
            '
            'Guna2HtmlLabel7
            '
            Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(51, 445)
            Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
            Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(55, 39)
            Me.Guna2HtmlLabel7.TabIndex = 38
            Me.Guna2HtmlLabel7.Text = "Cost:"
            '
            'SupplierLabel
            '
            Me.SupplierLabel.BackColor = System.Drawing.Color.Transparent
            Me.SupplierLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SupplierLabel.Location = New System.Drawing.Point(188, 173)
            Me.SupplierLabel.Name = "SupplierLabel"
            Me.SupplierLabel.Size = New System.Drawing.Size(100, 39)
            Me.SupplierLabel.TabIndex = 37
            Me.SupplierLabel.Text = "Supplier 1"
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(51, 173)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(91, 39)
            Me.Guna2HtmlLabel6.TabIndex = 36
            Me.Guna2HtmlLabel6.Text = "Supplier:"
            '
            'RequestIdLabel
            '
            Me.RequestIdLabel.BackColor = System.Drawing.Color.Transparent
            Me.RequestIdLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RequestIdLabel.Location = New System.Drawing.Point(264, 101)
            Me.RequestIdLabel.Name = "RequestIdLabel"
            Me.RequestIdLabel.Size = New System.Drawing.Size(36, 39)
            Me.RequestIdLabel.TabIndex = 35
            Me.RequestIdLabel.Text = "001"
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(51, 101)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(183, 39)
            Me.Guna2HtmlLabel5.TabIndex = 34
            Me.Guna2HtmlLabel5.Text = "Request Number: "
            '
            'NoteLabel
            '
            Me.NoteLabel.BackColor = System.Drawing.Color.Transparent
            Me.NoteLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NoteLabel.Location = New System.Drawing.Point(215, 515)
            Me.NoteLabel.Name = "NoteLabel"
            Me.NoteLabel.Size = New System.Drawing.Size(52, 39)
            Me.NoteLabel.TabIndex = 33
            Me.NoteLabel.Text = "Note"
            '
            'QuantityLabel
            '
            Me.QuantityLabel.BackColor = System.Drawing.Color.Transparent
            Me.QuantityLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.QuantityLabel.Location = New System.Drawing.Point(215, 361)
            Me.QuantityLabel.Name = "QuantityLabel"
            Me.QuantityLabel.Size = New System.Drawing.Size(36, 39)
            Me.QuantityLabel.TabIndex = 32
            Me.QuantityLabel.Text = "100"
            '
            'ProductLabel
            '
            Me.ProductLabel.BackColor = System.Drawing.Color.Transparent
            Me.ProductLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ProductLabel.Location = New System.Drawing.Point(215, 270)
            Me.ProductLabel.Name = "ProductLabel"
            Me.ProductLabel.Size = New System.Drawing.Size(72, 39)
            Me.ProductLabel.TabIndex = 31
            Me.ProductLabel.Text = "Burger"
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(51, 515)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(56, 39)
            Me.Guna2HtmlLabel4.TabIndex = 30
            Me.Guna2HtmlLabel4.Text = "Note:"
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(51, 361)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(97, 39)
            Me.Guna2HtmlLabel3.TabIndex = 29
            Me.Guna2HtmlLabel3.Text = "Quantity:"
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(51, 270)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(123, 39)
            Me.Guna2HtmlLabel2.TabIndex = 28
            Me.Guna2HtmlLabel2.Text = "Item name:"
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(43, 45)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(236, 39)
            Me.Guna2HtmlLabel1.TabIndex = 27
            Me.Guna2HtmlLabel1.Text = "Suppy Request Details"
            '
            'CancelButton
            '
            Me.CancelButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.CancelButton.BorderRadius = 15
            Me.CancelButton.BorderThickness = 1
            Me.CancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.CancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.CancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.CancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.CancelButton.FillColor = System.Drawing.Color.White
            Me.CancelButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.CancelButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
            Me.CancelButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.CancelButton.HoverState.ForeColor = System.Drawing.Color.White
            Me.CancelButton.Location = New System.Drawing.Point(426, 668)
            Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(189, 51)
            Me.CancelButton.TabIndex = 25
            Me.CancelButton.Text = "Cancel"
            '
            'AcceptButton
            '
            Me.AcceptButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AcceptButton.BorderRadius = 15
            Me.AcceptButton.BorderThickness = 1
            Me.AcceptButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.AcceptButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.AcceptButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.AcceptButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.AcceptButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AcceptButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.AcceptButton.ForeColor = System.Drawing.Color.White
            Me.AcceptButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AcceptButton.HoverState.FillColor = System.Drawing.Color.White
            Me.AcceptButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.AcceptButton.Location = New System.Drawing.Point(868, 668)
            Me.AcceptButton.Margin = New System.Windows.Forms.Padding(2)
            Me.AcceptButton.Name = "AcceptButton"
            Me.AcceptButton.Size = New System.Drawing.Size(189, 51)
            Me.AcceptButton.TabIndex = 24
            Me.AcceptButton.Text = "Accept"
            '
            'DeclineButton
            '
            Me.DeclineButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeclineButton.BorderRadius = 15
            Me.DeclineButton.BorderThickness = 1
            Me.DeclineButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.DeclineButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.DeclineButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.DeclineButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.DeclineButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeclineButton.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DeclineButton.ForeColor = System.Drawing.Color.White
            Me.DeclineButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeclineButton.HoverState.FillColor = System.Drawing.Color.White
            Me.DeclineButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.DeclineButton.Location = New System.Drawing.Point(634, 668)
            Me.DeclineButton.Margin = New System.Windows.Forms.Padding(2)
            Me.DeclineButton.Name = "DeclineButton"
            Me.DeclineButton.Size = New System.Drawing.Size(189, 51)
            Me.DeclineButton.TabIndex = 41
            Me.DeclineButton.Text = "Decline"
            '
            'SupplierRequestDetailsUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.Guna2Panel1)
            Me.Name = "SupplierRequestDetailsUserControl"
            Me.Size = New System.Drawing.Size(1321, 878)
            Me.Guna2Panel1.ResumeLayout(False)
            Me.Guna2Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CancelButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents AcceptButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents NoteLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents QuantityLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ProductLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents RequestIdLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents SupplierLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CostLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents DeclineButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace