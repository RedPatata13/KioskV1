Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SupplyRequestUserControl
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
            Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
            Me.DateLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.QuantityLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ProductLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.RequestIdLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2Panel4.SuspendLayout()
            Me.SuspendLayout()
            '
            'Guna2Panel4
            '
            Me.Guna2Panel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.Guna2Panel4.BorderRadius = 10
            Me.Guna2Panel4.BorderThickness = 2
            Me.Guna2Panel4.Controls.Add(Me.DateLabel)
            Me.Guna2Panel4.Controls.Add(Me.QuantityLabel)
            Me.Guna2Panel4.Controls.Add(Me.ProductLabel)
            Me.Guna2Panel4.Controls.Add(Me.RequestIdLabel)
            Me.Guna2Panel4.FillColor = System.Drawing.Color.WhiteSmoke
            Me.Guna2Panel4.Location = New System.Drawing.Point(71, 14)
            Me.Guna2Panel4.Name = "Guna2Panel4"
            Me.Guna2Panel4.Size = New System.Drawing.Size(1163, 52)
            Me.Guna2Panel4.TabIndex = 2
            '
            'DateLabel
            '
            Me.DateLabel.BackColor = System.Drawing.Color.Transparent
            Me.DateLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateLabel.Location = New System.Drawing.Point(299, 7)
            Me.DateLabel.Name = "DateLabel"
            Me.DateLabel.Size = New System.Drawing.Size(53, 39)
            Me.DateLabel.TabIndex = 31
            Me.DateLabel.Text = "Date"
            '
            'QuantityLabel
            '
            Me.QuantityLabel.BackColor = System.Drawing.Color.Transparent
            Me.QuantityLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.QuantityLabel.Location = New System.Drawing.Point(1037, 7)
            Me.QuantityLabel.Name = "QuantityLabel"
            Me.QuantityLabel.Size = New System.Drawing.Size(40, 39)
            Me.QuantityLabel.TabIndex = 30
            Me.QuantityLabel.Text = "Qty"
            '
            'ProductLabel
            '
            Me.ProductLabel.BackColor = System.Drawing.Color.Transparent
            Me.ProductLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ProductLabel.Location = New System.Drawing.Point(694, 7)
            Me.ProductLabel.Name = "ProductLabel"
            Me.ProductLabel.Size = New System.Drawing.Size(119, 39)
            Me.ProductLabel.TabIndex = 29
            Me.ProductLabel.Text = "Item name"
            '
            'RequestIdLabel
            '
            Me.RequestIdLabel.BackColor = System.Drawing.Color.Transparent
            Me.RequestIdLabel.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.RequestIdLabel.Location = New System.Drawing.Point(12, 7)
            Me.RequestIdLabel.Name = "RequestIdLabel"
            Me.RequestIdLabel.Size = New System.Drawing.Size(127, 39)
            Me.RequestIdLabel.TabIndex = 28
            Me.RequestIdLabel.Text = " Request 001"
            '
            'SupplyRequestUserControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.Guna2Panel4)
            Me.Name = "SupplyRequestUserControl"
            Me.Size = New System.Drawing.Size(1321, 80)
            Me.Guna2Panel4.ResumeLayout(False)
            Me.Guna2Panel4.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents DateLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents QuantityLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ProductLabel As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents RequestIdLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    End Class

End Namespace