Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity.Infrastructure
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminEditUserViewModel
        Inherits ViewModel(Of Forms.AdminAddUserView, AdminKeys)
        Private Property Loaded As Boolean = False
        Public Sub New(view As AdminAddUserView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            SetEvents()
            _view._roles.SelectedIndex = 1
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.CancelButtonClick = AddressOf CancelButtonClick
            _view.SaveButtonClick = AddressOf SaveButtonClick
        End Sub

        Public Overrides Sub Project(projector As Form)
            If Not Loaded Then
                MyBase.Project(projector)
                ResizeComponents(_mediator.GetProjectorPanelSize())
                Loaded = True
            End If
            MyBase.Project(projector)

        End Sub

        Public Sub LoadAsEdit(model As User)
            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() LoadWithDetails(model))
                                       _mediator.AddAction(Sub() _mediator.SwapPage(AdminKeys.AdminAddUser))
                                       _mediator.InvokeAllAction()
                                   End Sub)
            _view.Label = "Edit User"
            _view.SaveButtonClick = Sub() UpdateUser(model)
        End Sub
        Private Sub LoadWithDetails(model As User)
            'model.Validate()
            _view._roles.Enabled = False
            _view.Role = model.Role
            _view.UserName = model.Username
            _view.Password = model.PasswordHash
            _view.Email = model.Email
            _view.ContactNo = model.ContactNumber
            _view.ConfirmPassword = model.PasswordHash
            _view.FirstName = model.FirstName
            _view.LastName = model.LastName
            _view.Address = model.Address
            '_view.Sell = $"{model.Selling}"
        End Sub
        Private Function GetInput() As User
            _view.Label = "Edit User"
            Dim newModel = New User()
            'newModel.Role = "Admin"
            newModel.Username = _view.UserName
            newModel.PasswordHash = _view.Password
            newModel.FirstName = _view.FirstName
            newModel.LastName = _view.LastName
            newModel.Email = _view.Email
            newModel.ContactNumber = _view.ContactNo
            newModel.Address = _view.Address
            'newModel.CreatedAt = Model.CreatedAt

            Return newModel
        End Function
        Private Sub UpdateUser(model As User)
            Try
                Dim newModel As User = GetInput()
                newModel.UserId = model.UserId
                newModel.CreatedAt = model.CreatedAt

                If _view.Password <> _view.ConfirmPassword Then Throw New Exception("Please ensure that field: Password and field: Confirm Password have the same input.")

                Dim user = _mediator.GetUnitOfWork().Users.GetUserByID(newModel.UserId)
                If user Is Nothing Then
                    MessageBox.Show("User does not exist")
                Else
                    user.Username = newModel.Username
                    user.PasswordHash = newModel.PasswordHash
                    user.Address = newModel.Address
                    user.Email = newModel.Email
                    user.ContactNumber = newModel.ContactNumber
                    user.FirstName = newModel.FirstName
                    user.LastName = newModel.LastName
                    user.Role = user.Role
                    MessageBox.Show($"{user.Role}")
                    _mediator.GetUnitOfWork.Users.Update(user)
                    _mediator.GetUnitOfWork().SaveChanges()
                    _mediator.SwapPage(AdminKeys.AdminAccountSettings)
                    'MessageBox.Show("User Updated!")
                End If
            Catch ex As Exception
                'MessageBox.Show("{}")
                MessageBox.Show($"{ex.Message}")
            End Try

        End Sub
        Private Sub CancelButtonClick()
            _mediator.SwapPage(AdminKeys.AdminAccountSettings)
            RevertView()
        End Sub
        Private Sub SaveButtonClick()
            Try
                Dim model = New User()
                'model.Role = _view.Role
                model.Username = _view.UserName

                If _view.Password <> _view.ConfirmPassword Then Throw New Exception("Ensure that text in 'Password' and 'Confirm Password' is the same")
                model.Role = _view.Role
                model.UserId = "UID_" & Guid.NewGuid().ToString().Substring(0, 10)
                model.PasswordHash = _view.Password
                model.FirstName = _view.FirstName
                model.LastName = _view.LastName
                model.Email = _view.Email
                model.ContactNumber = _view.ContactNo
                model.Address = _view.Address
                model.CreatedAt = DateTime.Now

                'Dim validationResults As New List(Of ValidationResult)()
                'Dim validationContext As New ValidationContext(model, Nothing, Nothing)

                'If Not Validator.TryValidateObject(model, validationContext, validationResults, True) Then
                '    Dim errorMessages As String = String.Join(Environment.NewLine, validationResults.Select(Function(r) r.ErrorMessage))
                '    Throw New Exception(errorMessages)
                'End If
                'Dim properties = model.GetType().GetProperties()

                model.Validate()

                _mediator.CreateUser(model)
                _mediator.SwapPage(AdminKeys.AdminAccountSettings)
                _view.ResetFields()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub RevertView()
            _view.Label = "Add User"
            _view.SaveButtonClick = AddressOf SaveButtonClick
            _view.ResetFields()
            _view._roles.Enabled = True
        End Sub
    End Class
End Namespace