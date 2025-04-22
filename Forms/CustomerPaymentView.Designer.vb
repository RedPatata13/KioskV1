Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CustomerPaymentView
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerPaymentView))
            Me.CustomerPaymentViewLbl = New Guna.UI2.WinForms.Guna2Panel()
            Me.PaymentMethodLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.LogoPctrBx = New Guna.UI2.WinForms.Guna2PictureBox()
            Me.PayButton = New Guna.UI2.WinForms.Guna2Button()
            Me.CustomerPaymentViewLbl.SuspendLayout()
            CType(Me.LogoPctrBx, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'CustomerPaymentViewLbl
            '
            Me.CustomerPaymentViewLbl.BackColor = System.Drawing.Color.White
            Me.CustomerPaymentViewLbl.Controls.Add(Me.PaymentMethodLbl)
            Me.CustomerPaymentViewLbl.Controls.Add(Me.LogoPctrBx)
            Me.CustomerPaymentViewLbl.Controls.Add(Me.PayButton)
            Me.CustomerPaymentViewLbl.Location = New System.Drawing.Point(2, 0)
            Me.CustomerPaymentViewLbl.Name = "CustomerPaymentViewLbl"
            Me.CustomerPaymentViewLbl.Size = New System.Drawing.Size(1920, 1080)
            Me.CustomerPaymentViewLbl.TabIndex = 0
            '
            'PaymentMethodLbl
            '
            Me.PaymentMethodLbl.BackColor = System.Drawing.Color.White
            Me.PaymentMethodLbl.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PaymentMethodLbl.Location = New System.Drawing.Point(651, 385)
            Me.PaymentMethodLbl.Name = "PaymentMethodLbl"
            Me.PaymentMethodLbl.Size = New System.Drawing.Size(41, 21)
            Me.PaymentMethodLbl.TabIndex = 8
            Me.PaymentMethodLbl.Text = "(Cash)"
            '
            'LogoPctrBx
            '
            Me.LogoPctrBx.Image = CType(resources.GetObject("LogoPctrBx.Image"), System.Drawing.Image)
            Me.LogoPctrBx.ImageRotate = 0!
            Me.LogoPctrBx.Location = New System.Drawing.Point(-10, 0)
            Me.LogoPctrBx.Name = "LogoPctrBx"
            Me.LogoPctrBx.Size = New System.Drawing.Size(146, 109)
            Me.LogoPctrBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.LogoPctrBx.TabIndex = 10
            Me.LogoPctrBx.TabStop = False
            '
            'PayButton
            '
            Me.PayButton.BackColor = System.Drawing.Color.Transparent
            Me.PayButton.BorderColor = System.Drawing.Color.White
            Me.PayButton.BorderRadius = 10
            Me.PayButton.BorderThickness = 1
            Me.PayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.PayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.PayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.PayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.PayButton.FillColor = System.Drawing.Color.White
            Me.PayButton.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.PayButton.ForeColor = System.Drawing.Color.Black
            Me.PayButton.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(44, Byte), Integer))
            Me.PayButton.Location = New System.Drawing.Point(67, 327)
            Me.PayButton.Name = "PayButton"
            Me.PayButton.PressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PayButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.PayButton.ShadowDecoration.Enabled = True
            Me.PayButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
            Me.PayButton.Size = New System.Drawing.Size(1235, 90)
            Me.PayButton.TabIndex = 11
            Me.PayButton.Text = "Pay at the Counter"
            '
            'CustomerPaymentView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1386, 788)
            Me.Controls.Add(Me.CustomerPaymentViewLbl)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "CustomerPaymentView"
            Me.ShowInTaskbar = False
            Me.Text = "CustomerPaymentPage"
            Me.CustomerPaymentViewLbl.ResumeLayout(False)
            Me.CustomerPaymentViewLbl.PerformLayout()
            CType(Me.LogoPctrBx, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents CustomerPaymentViewLbl As Guna.UI2.WinForms.Guna2Panel
        Friend WithEvents PaymentMethodLbl As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents LogoPctrBx As Guna.UI2.WinForms.Guna2PictureBox
        Friend WithEvents PayButton As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace