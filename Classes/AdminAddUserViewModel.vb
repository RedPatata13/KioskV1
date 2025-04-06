Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminAddUserViewModel
        Inherits ViewModel(Of Forms.AdminAddUserView, AdminKeys)

        Public Sub New(view As AdminAddUserView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            SetEvents()
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.CancelButtonClick = AddressOf CancelButtonClick
            _view.SaveButtonClick = AddressOf SaveButtonClick
        End Sub

        Private Sub CancelButtonClick()
            _mediator.SwapPage(AdminKeys.AdminAccountSettings)
            _view.ResetFields()
        End Sub
        Private Sub SaveButtonClick()
            Dim UserTypeFactory = Function(userType As String) As UserType
                                      Select Case userType
                                          Case "Admin"
                                              Return KioskV0.UserType.Admin
                                          Case "Staff"
                                              Return KioskV0.UserType.Staff
                                          Case "Supplier"
                                              Return KioskV0.UserType.Supplier
                                          Case "Customer"
                                              Return KioskV0.UserType.Customer
                                          Case Else
                                              Throw New Exception("Invalid UserType")
                                      End Select
                                  End Function

            Try
                Dim model = New User()
                model.Role = UserTypeFactory(_view.Role)
                model.Username = _view.UserName

                If _view.Password <> _view.ConfirmPassword Then Throw New Exception("Ensure that text in 'Password' and 'Confirm Password' is the same")
                model.PasswordHash = _view.Password
                model.FirstName = _view.FirstName
                model.LastName = _view.LastName
                model.Email = _view.Email
                model.ContactNumber = _view.ContactNo
                model.Address = "Sa gitna ng kawalan street ng mga enkanto"
                model.CreatedAt = DateTime.Now

                Dim validationResults As New List(Of ValidationResult)()
                Dim validationContext As New ValidationContext(model, Nothing, Nothing)

                If Not Validator.TryValidateObject(model, validationContext, validationResults, True) Then
                    Dim errorMessages As String = String.Join(Environment.NewLine, validationResults.Select(Function(r) r.ErrorMessage))
                    Throw New Exception(errorMessages)
                End If
                Dim properties = model.GetType().GetProperties()
                Dim str As String = ""
                For Each prop As PropertyInfo In properties
                    Dim value = prop.GetValue(model)
                    str &= Convert.ToString(value) & vbCrLf
                Next

                MessageBox.Show(str)
                _mediator.CreateUser(model)

                _view.ResetFields()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
    End Class
End Namespace