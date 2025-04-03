Imports KioskV0.KioskV0.Model

Namespace KioskV0.Forms

    Public Class AdminAccountUserControl
        Private Property _editClick As Action
        Private Property _delClick As Action
        Public WriteOnly Property EditButtonClick As Action
            Set(value As Action)
                _editClick = value
            End Set
        End Property

        Public WriteOnly Property DeleteButtonClick As Action
            Set(value As Action)
                _delClick = value
            End Set
        End Property

        Private Property _model As UserModel
        Public Property Model As UserModel
            Get
                Return _model
            End Get
            Set(value As UserModel)
                _model = value
                SetLabels()
            End Set
        End Property



        Private Sub SetLabels()
            Dim role_factory = Function(userType As UserType) As Int32
                                   Select Case userType
                                       Case UserType.Admin
                                           Return 0
                                       Case UserType.Staff
                                           Return 1
                                       Case UserType.Supplier
                                           Return 2
                                       Case UserType.Customer
                                           Return 3
                                       Case Else
                                           Throw New Exception("Invalid User Type")
                                   End Select
                               End Function
            UIDField.Text = Model.UserName
            FName_Field.Text = Model.FirstName
            LName_Field.Text = Model.LastName
            PasswordField.Text = Model.Password
            EmailField.Text = Model.Email
            ContactNumField.Text = Model.ContactNo
            Role.SelectedIndex = role_factory(Model.Role)
        End Sub

        Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
            _editClick?.Invoke()
        End Sub

        Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
            _delClick?.Invoke()
        End Sub

        Private Sub AdminAccountUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class

End Namespace