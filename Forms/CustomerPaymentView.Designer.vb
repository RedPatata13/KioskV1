<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerPaymentPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerPaymentPage))
        Me.CustomerPaymentViewLbl = New Guna.UI2.WinForms.Guna2Panel()
        Me.PayMessageLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PaymentMethodLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PaymentPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.LogoPctrBx = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CustomerPaymentViewLbl.SuspendLayout()
        Me.PaymentPanel.SuspendLayout()
        CType(Me.LogoPctrBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerPaymentViewLbl
        '
        Me.CustomerPaymentViewLbl.BackColor = System.Drawing.Color.White
        Me.CustomerPaymentViewLbl.Controls.Add(Me.LogoPctrBx)
        Me.CustomerPaymentViewLbl.Controls.Add(Me.PaymentPanel)
        Me.CustomerPaymentViewLbl.Location = New System.Drawing.Point(2, 0)
        Me.CustomerPaymentViewLbl.Name = "CustomerPaymentViewLbl"
        Me.CustomerPaymentViewLbl.Size = New System.Drawing.Size(1920, 1080)
        Me.CustomerPaymentViewLbl.TabIndex = 0
        '
        'PayMessageLbl
        '
        Me.PayMessageLbl.BackColor = System.Drawing.Color.White
        Me.PayMessageLbl.Font = New System.Drawing.Font("Poppins", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayMessageLbl.Location = New System.Drawing.Point(542, 9)
        Me.PayMessageLbl.Name = "PayMessageLbl"
        Me.PayMessageLbl.Size = New System.Drawing.Size(231, 44)
        Me.PayMessageLbl.TabIndex = 7
        Me.PayMessageLbl.Text = "Pay at the Counter"
        '
        'PaymentMethodLbl
        '
        Me.PaymentMethodLbl.BackColor = System.Drawing.Color.White
        Me.PaymentMethodLbl.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentMethodLbl.Location = New System.Drawing.Point(629, 50)
        Me.PaymentMethodLbl.Name = "PaymentMethodLbl"
        Me.PaymentMethodLbl.Size = New System.Drawing.Size(41, 21)
        Me.PaymentMethodLbl.TabIndex = 8
        Me.PaymentMethodLbl.Text = "(Cash)"
        '
        'PaymentPanel
        '
        Me.PaymentPanel.BackColor = System.Drawing.Color.Transparent
        Me.PaymentPanel.Controls.Add(Me.PayMessageLbl)
        Me.PaymentPanel.Controls.Add(Me.PaymentMethodLbl)
        Me.PaymentPanel.FillColor = System.Drawing.Color.White
        Me.PaymentPanel.Location = New System.Drawing.Point(67, 327)
        Me.PaymentPanel.Name = "PaymentPanel"
        Me.PaymentPanel.ShadowColor = System.Drawing.Color.Black
        Me.PaymentPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.PaymentPanel.Size = New System.Drawing.Size(1235, 90)
        Me.PaymentPanel.TabIndex = 9
        '
        'LogoPctrBx
        '
        Me.LogoPctrBx.Image = CType(resources.GetObject("LogoPctrBx.Image"), System.Drawing.Image)
        Me.LogoPctrBx.ImageRotate = 0!
        Me.LogoPctrBx.Location = New System.Drawing.Point(644, 12)
        Me.LogoPctrBx.Name = "LogoPctrBx"
        Me.LogoPctrBx.Size = New System.Drawing.Size(196, 166)
        Me.LogoPctrBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPctrBx.TabIndex = 10
        Me.LogoPctrBx.TabStop = False
        '
        'CustomerPaymentPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.CustomerPaymentViewLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerPaymentPage"
        Me.Text = "CustomerPaymentPage"
        Me.CustomerPaymentViewLbl.ResumeLayout(False)
        Me.PaymentPanel.ResumeLayout(False)
        Me.PaymentPanel.PerformLayout()
        CType(Me.LogoPctrBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerPaymentViewLbl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PaymentPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents PayMessageLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PaymentMethodLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LogoPctrBx As Guna.UI2.WinForms.Guna2PictureBox
End Class
