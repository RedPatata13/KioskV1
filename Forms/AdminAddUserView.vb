Namespace KioskV0.Forms
    Public Class AdminAddUserView
        Public Property SaveButtonClick As Action
        Public Property CancelButtonClick As Action
        Public ReadOnly Property Role As String
            Get
                Return _roles.Text
            End Get
        End Property

        Public ReadOnly Property UserName As String
            Get
                Return _userNameField.Text
            End Get
        End Property

        Public ReadOnly Property Password As String
            Get
                Return _passwordField.Text
            End Get
        End Property

        Public ReadOnly Property ConfirmPassword As String
            Get
                Return _confirmPasswordField.Text
            End Get
        End Property

        Public ReadOnly Property FirstName As String
            Get
                Return _firstNameField.Text
            End Get
        End Property

        Public ReadOnly Property LastName As String
            Get
                Return _lastNameField.Text
            End Get
        End Property

        Public ReadOnly Property Email As String
            Get
                Return _emailField.Text
            End Get
        End Property

        Public ReadOnly Property ContactNo As String
            Get
                Return _contactNumField.Text
            End Get
        End Property

        Public Sub ResetFields()
            _roles.SelectedIndex = -1
            _userNameField.Text = String.Empty
            _passwordField.Text = String.Empty
            _confirmPasswordField.Text = String.Empty
            _firstNameField.Text = String.Empty
            _lastNameField.Text = String.Empty
            _emailField.Text = String.Empty
            _contactNumField.Text = String.Empty
        End Sub
        Private Sub _saveButton_Click(sender As Object, e As EventArgs) Handles _saveButton.Click
            SaveButtonClick?.Invoke()
        End Sub

        Private Sub _cancelButton_Click(sender As Object, e As EventArgs) Handles _cancelButton.Click
            CancelButtonClick?.Invoke()
        End Sub

        Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged

        End Sub
    End Class
End Namespace