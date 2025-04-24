<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffPaymentUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffPaymentUserControl))
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.PayingAmountTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SubmitPaymentButton = New Guna.UI2.WinForms.Guna2Button()
        Me.NoteTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PaymentChoiceCombobox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Change = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ReceivedAmountTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.BorderThickness = 1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(70, 70)
        Me.Guna2Button1.Location = New System.Drawing.Point(13, 15)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(66, 46)
        Me.Guna2Button1.TabIndex = 38
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(0, 2)
        '
        'PayingAmountTextBox
        '
        Me.PayingAmountTextBox.BorderColor = System.Drawing.Color.DarkGray
        Me.PayingAmountTextBox.BorderRadius = 10
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
        Me.PayingAmountTextBox.Location = New System.Drawing.Point(80, 318)
        Me.PayingAmountTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PayingAmountTextBox.Name = "PayingAmountTextBox"
        Me.PayingAmountTextBox.PlaceholderText = ""
        Me.PayingAmountTextBox.SelectedText = ""
        Me.PayingAmountTextBox.Size = New System.Drawing.Size(1756, 37)
        Me.PayingAmountTextBox.TabIndex = 29
        Me.PayingAmountTextBox.TextOffset = New System.Drawing.Point(0, 2)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(80, 14)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(275, 51)
        Me.Guna2HtmlLabel1.TabIndex = 26
        Me.Guna2HtmlLabel1.Text = "Create Payment"
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
        Me.SubmitPaymentButton.Location = New System.Drawing.Point(1668, 998)
        Me.SubmitPaymentButton.Name = "SubmitPaymentButton"
        Me.SubmitPaymentButton.Size = New System.Drawing.Size(184, 46)
        Me.SubmitPaymentButton.TabIndex = 37
        Me.SubmitPaymentButton.Text = "Submit"
        Me.SubmitPaymentButton.TextOffset = New System.Drawing.Point(0, 2)
        '
        'NoteTextBox
        '
        Me.NoteTextBox.AutoSize = True
        Me.NoteTextBox.BorderColor = System.Drawing.Color.DarkGray
        Me.NoteTextBox.BorderRadius = 10
        Me.NoteTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NoteTextBox.DefaultText = ""
        Me.NoteTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NoteTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NoteTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NoteTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NoteTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NoteTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.NoteTextBox.ForeColor = System.Drawing.Color.Black
        Me.NoteTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NoteTextBox.Location = New System.Drawing.Point(80, 766)
        Me.NoteTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.PlaceholderText = ""
        Me.NoteTextBox.SelectedText = ""
        Me.NoteTextBox.Size = New System.Drawing.Size(1756, 193)
        Me.NoteTextBox.TabIndex = 36
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Poppins", 19.0!)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(80, 685)
        Me.Guna2HtmlLabel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(61, 46)
        Me.Guna2HtmlLabel6.TabIndex = 35
        Me.Guna2HtmlLabel6.Text = "Note"
        '
        'PaymentChoiceCombobox
        '
        Me.PaymentChoiceCombobox.BackColor = System.Drawing.Color.Transparent
        Me.PaymentChoiceCombobox.BorderColor = System.Drawing.Color.DarkGray
        Me.PaymentChoiceCombobox.BorderRadius = 10
        Me.PaymentChoiceCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.PaymentChoiceCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaymentChoiceCombobox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PaymentChoiceCombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PaymentChoiceCombobox.Font = New System.Drawing.Font("Poppins", 12.0!)
        Me.PaymentChoiceCombobox.ForeColor = System.Drawing.Color.Black
        Me.PaymentChoiceCombobox.ItemHeight = 30
        Me.PaymentChoiceCombobox.Location = New System.Drawing.Point(80, 616)
        Me.PaymentChoiceCombobox.Name = "PaymentChoiceCombobox"
        Me.PaymentChoiceCombobox.Size = New System.Drawing.Size(1756, 36)
        Me.PaymentChoiceCombobox.TabIndex = 34
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Poppins", 19.0!)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(80, 541)
        Me.Guna2HtmlLabel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(208, 46)
        Me.Guna2HtmlLabel5.TabIndex = 33
        Me.Guna2HtmlLabel5.Text = "Payment Choice"
        '
        'Change
        '
        Me.Change.BorderColor = System.Drawing.Color.DarkGray
        Me.Change.BorderRadius = 10
        Me.Change.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Change.DefaultText = ""
        Me.Change.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Change.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Change.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Change.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Change.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Change.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Change.ForeColor = System.Drawing.Color.Black
        Me.Change.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Change.Location = New System.Drawing.Point(80, 469)
        Me.Change.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Change.Name = "Change"
        Me.Change.PlaceholderText = "00.0"
        Me.Change.SelectedText = ""
        Me.Change.Size = New System.Drawing.Size(1756, 37)
        Me.Change.TabIndex = 32
        Me.Change.TextOffset = New System.Drawing.Point(0, 2)
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Poppins", 19.0!)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(80, 389)
        Me.Guna2HtmlLabel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(103, 46)
        Me.Guna2HtmlLabel4.TabIndex = 31
        Me.Guna2HtmlLabel4.Text = "Change"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Poppins", 19.0!)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(80, 245)
        Me.Guna2HtmlLabel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(108, 46)
        Me.Guna2HtmlLabel3.TabIndex = 30
        Me.Guna2HtmlLabel3.Text = "Subtotal"
        '
        'ReceivedAmountTextBox
        '
        Me.ReceivedAmountTextBox.BorderColor = System.Drawing.Color.DarkGray
        Me.ReceivedAmountTextBox.BorderRadius = 10
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
        Me.ReceivedAmountTextBox.Location = New System.Drawing.Point(80, 180)
        Me.ReceivedAmountTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ReceivedAmountTextBox.Name = "ReceivedAmountTextBox"
        Me.ReceivedAmountTextBox.PlaceholderText = ""
        Me.ReceivedAmountTextBox.SelectedText = ""
        Me.ReceivedAmountTextBox.Size = New System.Drawing.Size(1756, 37)
        Me.ReceivedAmountTextBox.TabIndex = 28
        Me.ReceivedAmountTextBox.TextOffset = New System.Drawing.Point(0, 2)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Poppins", 19.0!)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(80, 110)
        Me.Guna2HtmlLabel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(222, 46)
        Me.Guna2HtmlLabel2.TabIndex = 27
        Me.Guna2HtmlLabel2.Text = "Received Amount"
        '
        'StaffPaymentUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.PayingAmountTextBox)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.SubmitPaymentButton)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.PaymentChoiceCombobox)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Change)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.ReceivedAmountTextBox)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Name = "StaffPaymentUserControl"
        Me.Size = New System.Drawing.Size(1920, 1080)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PayingAmountTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents SubmitPaymentButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents NoteTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PaymentChoiceCombobox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Change As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ReceivedAmountTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
