Namespace KioskV0.Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Login
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
            Me.UIDField = New System.Windows.Forms.RichTextBox()
            Me.PasswordField = New System.Windows.Forms.RichTextBox()
            Me.SubmitButton = New System.Windows.Forms.Button()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'UIDField
            '
            Me.UIDField.Location = New System.Drawing.Point(3, 3)
            Me.UIDField.Multiline = False
            Me.UIDField.Name = "UIDField"
            Me.UIDField.Size = New System.Drawing.Size(248, 40)
            Me.UIDField.TabIndex = 0
            Me.UIDField.Text = ""
            '
            'PasswordField
            '
            Me.PasswordField.Location = New System.Drawing.Point(3, 59)
            Me.PasswordField.Multiline = False
            Me.PasswordField.Name = "PasswordField"
            Me.PasswordField.Size = New System.Drawing.Size(248, 40)
            Me.PasswordField.TabIndex = 1
            Me.PasswordField.Text = ""
            '
            'SubmitButton
            '
            Me.SubmitButton.Location = New System.Drawing.Point(3, 115)
            Me.SubmitButton.Name = "SubmitButton"
            Me.SubmitButton.Size = New System.Drawing.Size(248, 32)
            Me.SubmitButton.TabIndex = 2
            Me.SubmitButton.Text = "Button1"
            Me.SubmitButton.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.PasswordField, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.UIDField, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.SubmitButton, 0, 2)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(264, 152)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 3
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(256, 168)
            Me.TableLayoutPanel1.TabIndex = 3
            '
            'Login
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Name = "Login"
            Me.Text = "Login"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents UIDField As RichTextBox
        Friend WithEvents PasswordField As RichTextBox
        Friend WithEvents SubmitButton As Button
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    End Class

End Namespace