Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Validation
Imports System.Data.SqlClient
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class LoginViewModel
        Private Property _view As Forms.Login
        Private Property _projector As Projector
        Private ReadOnly _unitOfWork As IUnitOfWork ' access to repositories
        Private _tempModelMap As Dictionary(Of String, Model.AuthModel)
        Private _uid As String
        Private _password As String

        <Required(AllowEmptyStrings:=False, ErrorMessage:="UID Cannot be Empty")>
        Private WriteOnly Property UID As String
            Set(value As String)
                _uid = value
            End Set
        End Property

        <Required(AllowEmptyStrings:=False, ErrorMessage:="Password Cannot be Empty")>
        Private WriteOnly Property Password As String
            Set(value As String)
                _password = value
            End Set
        End Property

        ''' <summary>
        ''' Constructor to initialize dependencies and prepare the view
        ''' </summary>
        ''' <param name="projector">Projector object to control view navigation</param>
        ''' <param name="unitOfWork">UnitOfWork for accessing repositories</param>
        Public Sub New(projector As Projector, unitOfWork As IUnitOfWork)
            _unitOfWork = unitOfWork
            _view = New Forms.Login()
            _projector = projector
            SetEvents()
            PrepareView(projector.ProjectPanel)
        End Sub

        ''' <summary>
        ''' Function that handles the actual user authentication
        ''' </summary>
        ''' <param name="key">User ID</param>
        ''' <param name="password">User Password</param>
        Private Sub Authenticate(key As String, password As String)
            ' Use UnitOfWork to access the UsersRepository
            Dim acc As User = _unitOfWork.Users.GetUserByUsername(key)

            If acc Is Nothing Then
                Throw New UnauthorizedAccessException("User not found.")
            End If

            If password <> acc.PasswordHash Then
                Throw New UnauthorizedAccessException("Incorrect Password. Please check if UID or Password is correct")
            Else
                'MessageBox.Show($"Login Successful {vbCrLf}User type is: {acc.UserType}")

                Dim mediator

                Select Case acc.Role.ToLower()
                    Case "admin"
                        mediator = New Mediator(Of AdminKeys)(_projector, Me, _unitOfWork)
                        mediator.SetCurrentUser(acc)
                        mediator.SetupMap(GetAdminPages(mediator))
                        Dim sb = New AdminSideBarViewModel(New Forms.AdminSidebar(), mediator)
                        _projector.ProjectSidebar(sb)
                        mediator.SwapPage(AdminKeys.AdminDashboard)
                    Case "customer"
                        mediator = New Mediator(Of CustomerKeys)(_projector, Me, _unitOfWork)
                        mediator.SetCurrentUser(acc)
                        mediator.SetupMap(GetCustomerPages(mediator))
                    Case "staff"
                        mediator = New Mediator(Of StaffKeys)(_projector, Me, _unitOfWork)
                        mediator.SetCurrentUser(acc)
                        mediator.SetupMap(GetStaffPages(mediator))
                        Dim staff_sb = New StaffSideBarViewModel(New Forms.StaffSideBar(), mediator)
                        _projector.ProjectSidebar(staff_sb)
                        mediator.SwapPage(StaffKeys.StaffPos)
                        mediator.SwapPage(StaffKeys.StaffPos)

                    Case "supplier"
                        mediator = New Mediator(Of SupplierKeys)(_projector, Me, _unitOfWork)
                        mediator.SetCurrentUser(acc)
                        mediator.SetupMap(GetSupplierPages(mediator))
                        'Dim supplier_sb = New SupplierSidebarViewModel(New Forms.SupplierSidebar(), mediator)
                        mediator.SwapPage(SupplierKeys.SupplierLandingPage)
                        mediator.SwapPage(SupplierKeys.SupplierLandingPage)
                    Case Else
                        MessageBox.Show("User type not null")
                End Select

                _projector.SpawnSideBar()
            End If
        End Sub

        Private Sub PrepareView(projector As Form)
            _view.TopLevel = False
            _view.FormBorderStyle = FormBorderStyle.None
            _view.Dock = DockStyle.Fill
            _view.Location = New Point(0, 0)
            _view.Visible = True
            projector.Controls.Add(_view)
        End Sub

        Private Sub SetEvents()
            _view.SubmitButtonClick = AddressOf SubmitButtonClick
            _view.CustomerButtonClick = AddressOf CustomerButtonClick
        End Sub

        Private Sub SubmitButtonClick()
            Try
                UID = _view.UID
                Password = _view.Password
                ValidateLogin()

            Catch ex As ValidationException
                MessageBox.Show("Validation Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Catch ex As DbEntityValidationException
                ' Entity Framework validation errors
                Dim errors = String.Join(Environment.NewLine, ex.EntityValidationErrors.SelectMany(Function(e) e.ValidationErrors).Select(Function(e) e.ErrorMessage))
                MessageBox.Show("Database Validation Error: " & errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As DbUpdateException
                ' Handles EF database update errors (like duplicate keys, foreign key violations)
                Dim innerExceptionMessage As String = GetInnerExceptionMessage(ex)
                MessageBox.Show("Database Update Error: " & innerExceptionMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As SqlException
                ' Handles SQL-related errors
                MessageBox.Show("SQL Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Catch ex As Exception
                Dim innerExceptionMessage As String = GetInnerExceptionMessage(ex)
                LogException(ex) ' Log the full error
                MessageBox.Show("An unexpected error occurred. Please check the logs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        Private Function GetInnerExceptionMessage(ex As Exception) As String
            Dim message As String = ex.Message
            Dim innerEx As Exception = ex.InnerException
            While innerEx IsNot Nothing
                message &= Environment.NewLine & "Inner: " & innerEx.Message
                innerEx = innerEx.InnerException
            End While
            Return message
        End Function
        Private Sub CustomerButtonClick()
            Dim mediator
            mediator = New Mediator(Of CustomerKeys)(_projector, Me, _unitOfWork)

            Dim customerUser As New User With {
            .UserId = 0,
            .Username = "Customer",
            .FirstName = "Guest",
            .LastName = "",
            .Role = "Customer"
            }
            mediator.SetCurrentUser(customerUser)
            mediator.SetupMap(GetCustomerPages(mediator))
            mediator.SwapPage(CustomerKeys.CustomerMenu)
        End Sub
        Private Sub LogException(ex As Exception)
            MessageBox.Show(ex.Message)
            Dim logFilePath As String = "error_log.txt"
            Dim logMessage As String = $"[{DateTime.Now}] ERROR: {ex.Message}{Environment.NewLine}STACK TRACE: {ex.StackTrace}"

            Dim innerEx As Exception = ex.InnerException
            While innerEx IsNot Nothing
                logMessage &= Environment.NewLine & $"INNER EXCEPTION: {innerEx.Message}{Environment.NewLine}STACK TRACE: {innerEx.StackTrace}"
                innerEx = innerEx.InnerException
            End While


            System.IO.File.AppendAllText(logFilePath, logMessage & Environment.NewLine & "----------------------------------" & Environment.NewLine)
        End Sub
        ''' <summary>
        ''' Function for checking if User Input is Valid
        ''' </summary>
        Private Sub ValidateLogin()
            If String.IsNullOrWhiteSpace(_uid) Then
                Throw New ArgumentException("User ID is required")
            End If

            If String.IsNullOrWhiteSpace(_password) Then
                Throw New ArgumentException("Password is required")
            End If

            Authenticate(_uid, _password)
        End Sub
    End Class
End Namespace
