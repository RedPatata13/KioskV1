Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class StaffPaymentView
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
            Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.ReceivedAmountTextBox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.PayingAmountTextBox = New Guna.UI2.WinForms.Guna2TextBox()
            Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.PaymentChoiceCombobox = New Guna.UI2.WinForms.Guna2ComboBox()
            Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
            Me.SubmitPaymentButton = New Guna.UI2.WinForms.Guna2Button()
            Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
            Me.OrderNoteTextBox = New System.Windows.Forms.TextBox()
            Me.ChangeLabelText = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
            Me.CloseCreatePaymentView = New Guna.UI2.WinForms.Guna2Button()
            Me.SuspendLayout()
            '
            'Guna2HtmlLabel1
            '
            Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 28.0!, System.Drawing.FontStyle.Bold)
            Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(32, 22)
            Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
            Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(317, 60)
            Me.Guna2HtmlLabel1.TabIndex = 11
            Me.Guna2HtmlLabel1.Text = "Create Payment"
            '
            'Guna2HtmlLabel2
            '
            Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 19.0!)
            Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(35, 107)
            Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
            Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(222, 46)
            Me.Guna2HtmlLabel2.TabIndex = 12
            Me.Guna2HtmlLabel2.Text = "Received Amount"
            '
            'ReceivedAmountTextBox
            '
            Me.ReceivedAmountTextBox.BorderColor = System.Drawing.Color.Black
            Me.ReceivedAmountTextBox.BorderRadius = 18
            Me.ReceivedAmountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.ReceivedAmountTextBox.DefaultText = ""
            Me.ReceivedAmountTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.ReceivedAmountTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ReceivedAmountTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ReceivedAmountTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.ReceivedAmountTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ReceivedAmountTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.ReceivedAmountTextBox.ForeColor = System.Drawing.Color.Black
            Me.ReceivedAmountTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.ReceivedAmountTextBox.Location = New System.Drawing.Point(35, 159)
            Me.ReceivedAmountTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
            Me.ReceivedAmountTextBox.Name = "ReceivedAmountTextBox"
            Me.ReceivedAmountTextBox.PlaceholderText = ""
            Me.ReceivedAmountTextBox.SelectedText = ""
            Me.ReceivedAmountTextBox.Size = New System.Drawing.Size(478, 37)
            Me.ReceivedAmountTextBox.TabIndex = 13
            Me.ReceivedAmountTextBox.TextOffset = New System.Drawing.Point(0, 2)
            '
            'PayingAmountTextBox
            '
            Me.PayingAmountTextBox.BorderColor = System.Drawing.Color.Black
            Me.PayingAmountTextBox.BorderRadius = 18
            Me.PayingAmountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.PayingAmountTextBox.DefaultText = ""
            Me.PayingAmountTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
            Me.PayingAmountTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.PayingAmountTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.PayingAmountTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.PayingAmountTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.PayingAmountTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
            Me.PayingAmountTextBox.ForeColor = System.Drawing.Color.Black
            Me.PayingAmountTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.PayingAmountTextBox.Location = New System.Drawing.Point(35, 295)
            Me.PayingAmountTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
            Me.PayingAmountTextBox.Name = "PayingAmountTextBox"
            Me.PayingAmountTextBox.PlaceholderText = ""
            Me.PayingAmountTextBox.SelectedText = ""
            Me.PayingAmountTextBox.Size = New System.Drawing.Size(478, 37)
            Me.PayingAmountTextBox.TabIndex = 14
            Me.PayingAmountTextBox.TextOffset = New System.Drawing.Point(0, 2)
            '
            'Guna2HtmlLabel3
            '
            Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 19.0!)
            Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(35, 243)
            Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
            Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(194, 46)
            Me.Guna2HtmlLabel3.TabIndex = 15
            Me.Guna2HtmlLabel3.Text = "Paying Amount"
            '
            'Guna2HtmlLabel4
            '
            Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 19.0!)
            Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(35, 367)
            Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
            Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(103, 46)
            Me.Guna2HtmlLabel4.TabIndex = 16
            Me.Guna2HtmlLabel4.Text = "Change"
            '
            'Guna2HtmlLabel5
            '
            Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins", 19.0!)
            Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(35, 444)
            Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
            Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(208, 46)
            Me.Guna2HtmlLabel5.TabIndex = 18
            Me.Guna2HtmlLabel5.Text = "Payment Choice"
            '
            'PaymentChoiceCombobox
            '
            Me.PaymentChoiceCombobox.BackColor = System.Drawing.Color.Transparent
            Me.PaymentChoiceCombobox.BorderColor = System.Drawing.Color.Black
            Me.PaymentChoiceCombobox.BorderRadius = 17
            Me.PaymentChoiceCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.PaymentChoiceCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.PaymentChoiceCombobox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.PaymentChoiceCombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.PaymentChoiceCombobox.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.PaymentChoiceCombobox.ForeColor = System.Drawing.Color.Black
            Me.PaymentChoiceCombobox.ItemHeight = 30
            Me.PaymentChoiceCombobox.Items.AddRange(New Object() {"Cash"})
            Me.PaymentChoiceCombobox.Location = New System.Drawing.Point(35, 506)
            Me.PaymentChoiceCombobox.Name = "PaymentChoiceCombobox"
            Me.PaymentChoiceCombobox.Size = New System.Drawing.Size(478, 36)
            Me.PaymentChoiceCombobox.TabIndex = 19
            '
            'Guna2HtmlLabel6
            '
            Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins", 19.0!)
            Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(35, 570)
            Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
            Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(61, 46)
            Me.Guna2HtmlLabel6.TabIndex = 20
            Me.Guna2HtmlLabel6.Text = "Note"
            '
            'FlowLayoutPanel1
            '
            Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.FlowLayoutPanel1.Location = New System.Drawing.Point(603, 107)
            Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
            Me.FlowLayoutPanel1.Size = New System.Drawing.Size(655, 467)
            Me.FlowLayoutPanel1.TabIndex = 23
            '
            'SubmitPaymentButton
            '
            Me.SubmitPaymentButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SubmitPaymentButton.BorderRadius = 15
            Me.SubmitPaymentButton.BorderThickness = 1
            Me.SubmitPaymentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.SubmitPaymentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.SubmitPaymentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.SubmitPaymentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.SubmitPaymentButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.SubmitPaymentButton.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.SubmitPaymentButton.ForeColor = System.Drawing.Color.White
            Me.SubmitPaymentButton.Location = New System.Drawing.Point(35, 790)
            Me.SubmitPaymentButton.Name = "SubmitPaymentButton"
            Me.SubmitPaymentButton.Size = New System.Drawing.Size(184, 46)
            Me.SubmitPaymentButton.TabIndex = 24
            Me.SubmitPaymentButton.Text = "Submit"
            Me.SubmitPaymentButton.TextOffset = New System.Drawing.Point(0, 2)
            '
            'OrderNoteTextBox
            '
            Me.OrderNoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.OrderNoteTextBox.Font = New System.Drawing.Font("Poppins", 12.0!)
            Me.OrderNoteTextBox.Location = New System.Drawing.Point(32, 621)
            Me.OrderNoteTextBox.Multiline = True
            Me.OrderNoteTextBox.Name = "OrderNoteTextBox"
            Me.OrderNoteTextBox.Size = New System.Drawing.Size(478, 125)
            Me.OrderNoteTextBox.TabIndex = 25
            '
            'ChangeLabelText
            '
            Me.ChangeLabelText.BackColor = System.Drawing.Color.Transparent
            Me.ChangeLabelText.Font = New System.Drawing.Font("Poppins", 19.0!)
            Me.ChangeLabelText.Location = New System.Drawing.Point(204, 367)
            Me.ChangeLabelText.Margin = New System.Windows.Forms.Padding(2)
            Me.ChangeLabelText.Name = "ChangeLabelText"
            Me.ChangeLabelText.Size = New System.Drawing.Size(103, 46)
            Me.ChangeLabelText.TabIndex = 26
            Me.ChangeLabelText.Text = "Change"
            Me.ChangeLabelText.Visible = False
            '
            'Guna2HtmlLabel7
            '
            Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
            Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Poppins", 19.0!)
            Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(160, 367)
            Me.Guna2HtmlLabel7.Margin = New System.Windows.Forms.Padding(2)
            Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
            Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(8, 46)
            Me.Guna2HtmlLabel7.TabIndex = 27
            Me.Guna2HtmlLabel7.Text = ":"
            '
            'CloseCreatePaymentView
            '
            Me.CloseCreatePaymentView.DisabledState.BorderColor = System.Drawing.Color.DarkGray
            Me.CloseCreatePaymentView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
            Me.CloseCreatePaymentView.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
            Me.CloseCreatePaymentView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
            Me.CloseCreatePaymentView.FillColor = System.Drawing.Color.White
            Me.CloseCreatePaymentView.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.CloseCreatePaymentView.ForeColor = System.Drawing.Color.Black
            Me.CloseCreatePaymentView.Location = New System.Drawing.Point(1265, 22)
            Me.CloseCreatePaymentView.Name = "CloseCreatePaymentView"
            Me.CloseCreatePaymentView.Size = New System.Drawing.Size(34, 30)
            Me.CloseCreatePaymentView.TabIndex = 28
            Me.CloseCreatePaymentView.Text = "X"
            '
            'StaffPaymentView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(1321, 878)
            Me.Controls.Add(Me.CloseCreatePaymentView)
            Me.Controls.Add(Me.Guna2HtmlLabel7)
            Me.Controls.Add(Me.ChangeLabelText)
            Me.Controls.Add(Me.OrderNoteTextBox)
            Me.Controls.Add(Me.PayingAmountTextBox)
            Me.Controls.Add(Me.Guna2HtmlLabel1)
            Me.Controls.Add(Me.SubmitPaymentButton)
            Me.Controls.Add(Me.FlowLayoutPanel1)
            Me.Controls.Add(Me.Guna2HtmlLabel6)
            Me.Controls.Add(Me.PaymentChoiceCombobox)
            Me.Controls.Add(Me.Guna2HtmlLabel5)
            Me.Controls.Add(Me.Guna2HtmlLabel4)
            Me.Controls.Add(Me.Guna2HtmlLabel3)
            Me.Controls.Add(Me.ReceivedAmountTextBox)
            Me.Controls.Add(Me.Guna2HtmlLabel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "StaffPaymentView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = " "
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents ReceivedAmountTextBox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents PayingAmountTextBox As Guna.UI2.WinForms.Guna2TextBox
        Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents PaymentChoiceCombobox As Guna.UI2.WinForms.Guna2ComboBox
        Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
        Friend WithEvents SubmitPaymentButton As Guna.UI2.WinForms.Guna2Button
        Friend WithEvents PrintDocument1 As Printing.PrintDocument
        Friend WithEvents OrderNoteTextBox As TextBox
        Friend WithEvents ChangeLabelText As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
        Friend WithEvents CloseCreatePaymentView As Guna.UI2.WinForms.Guna2Button
    End Class

End Namespace