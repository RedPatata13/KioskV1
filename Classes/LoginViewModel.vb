
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model
Namespace KioskV0.Classes
    Public Class LoginViewModel
        Private Property _view As Forms.Login
        Private Property _model
        Private Property _projector As Projector
        Private Property _db As TempDB
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
        Public Sub New(projector As Projector)
            _db = New TempDB()
            _view = New Forms.Login()
            SetEvents()
            PrepareView(projector.ProjectPanel)
            _projector = projector
        End Sub

        ''' <summary>
        ''' Function that handles the actual user authentication
        ''' </summary>
        ''' <param name="key">User ID</param>
        ''' <param name="password">User Password</param>
        Private Sub Authenticate(key As String, password As String)
            Dim acc As AuthModel = _db.GetAccount(key)
            If (password <> acc.Password) Then
                Throw New UnauthorizedAccessException("Incorrect Password. Please check if UID or Password is correct")
            Else
                'MessageBox.Show($"Login Successful {vbCrLf}User type is: {acc.UserType}")

                Dim mediator

                Select Case acc.UserType
                    Case UserType.Admin
                        mediator = New Mediator(Of AdminKeys)(_projector, Me, _db)
                        mediator.SetupMap(GetAdminPages(mediator))
                        Dim sb = New AdminSideBarViewModel(New Forms.AdminSidebar(), mediator)
                        _projector.ProjectSidebar(sb)
                        mediator.SwapPage(AdminKeys.AdminDashboard) 'for sum reason only gods know, the fill doesn't happen on first call 
                        mediator.SwapPage(AdminKeys.AdminDashboard) 'so call it again. I have no fckin clue why this happens cuz ts was working just fine before the merge
                    Case UserType.Customer
                        mediator = New Mediator(Of CustomerKeys)(_projector, Me, _db)
                        mediator.SetupMap(GetCustomerPages())

                    Case UserType.Staff
                        mediator = New Mediator(Of StaffKeys)(_projector, Me, _db)
                        mediator.SetupMap(GetStaffPages(mediator))
                        Dim staff_sb = New StaffSideBarViewModel(New Forms.StaffSideBar(), mediator)
                        _projector.ProjectSidebar(staff_sb)
                        mediator.SwapPage(StaffKeys.StaffPos)
                        mediator.SwapPage(StaffKeys.StaffPos)

                    Case UserType.Supplier
                        mediator = New Mediator(Of SupplierKeys)(_projector, Me, _db)
                    Case Else
                        Throw New Exception("Invalid User Type")
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
        End Sub

        Private Sub SubmitButtonClick()
            Try
                UID = _view.UID
                Password = _view.Password
                ValidateLogin()

            Catch ex As ArgumentException
                MessageBox.Show(ex.Message)
            Catch ex As UnauthorizedAccessException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show("An unexpected Error has occured")

            End Try
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