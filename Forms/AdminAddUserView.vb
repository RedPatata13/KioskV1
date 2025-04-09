Namespace KioskV0.Forms
    Public Class AdminAddUserView
        Public Property SaveButtonClick As Action
        Public Property CancelButtonClick As Action
        Public Property Role As String
            Get
                Return _roles.Text
            End Get
            Set(value As String)
                Dim index As Integer = _roles.FindStringExact(value)
                If index <> -1 Then
                    _roles.SelectedIndex = index
                Else
                    _roles.Items.Add(value)
                End If

            End Set
        End Property
        Public Property Label As String
            Get
                Return _label.Text
            End Get
            Set(value As String)
                _label.Text = value
            End Set
        End Property
        Public Property UserName As String
            Get
                Return _userNameField.Text
            End Get
            Set(value As String)
                _userNameField.Text = value
            End Set
        End Property

        Public Property Password As String
            Get
                Return _passwordField.Text
            End Get
            Set(value As String)
                _passwordField.Text = value
            End Set
        End Property

        Public Property ConfirmPassword As String
            Get
                Return _confirmPasswordField.Text
            End Get
            Set(value As String)
                _confirmPasswordField.Text = value
            End Set
        End Property

        Public Property FirstName As String
            Get
                Return _firstNameField.Text
            End Get
            Set(value As String)
                _firstNameField.Text = value
            End Set
        End Property

        Public Property LastName As String
            Get
                Return _lastNameField.Text
            End Get
            Set(value As String)
                _lastNameField.Text = value
            End Set
        End Property

        Public Property Email As String
            Get
                Return _emailField.Text
            End Get
            Set(value As String)
                _emailField.Text = value
            End Set
        End Property

        Public Property ContactNo As String
            Get
                Return _contactNumField.Text
            End Get
            Set(value As String)
                _contactNumField.Text = value
            End Set
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
    End Class
End Namespace