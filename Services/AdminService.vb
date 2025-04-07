Imports KioskV0.KioskV0.Classes
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model
Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports System.Web.Security
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Namespace KioskV0.Services
    Public Class AdminService
        Private ReadOnly _unitOfWork As IUnitOfWork
        Private ReadOnly _validationService As ValidationService
        Private ReadOnly _user As User
        Public Sub New(unitOfWork As IUnitOfWork, validationService As ValidationService, user As User)
            _unitOfWork = unitOfWork
            _validationService = validationService
            _user = user
        End Sub
        Public Sub MapViewToUser(_view As AdminAddUserView)
            _user.Role = _view.Role
            _user.Username = _view.UserName
            _user.PasswordHash = _view.Password
            _user.FirstName = _view.FirstName
            _user.LastName = _view.LastName
            _user.Email = _view.Email
            _user.ContactNumber = _view.ContactNo
            _user.Address = "Default Address"
            _user.CreatedAt = DateTime.Now
        End Sub
        'Users
        Public Function GetAllUsers() As List(Of User)
            Return _unitOfWork.Users.GetAll().ToList()
        End Function
        Public Function AddUser() As Boolean
            ' Validates unique username
            If Not _validationService.ValidateUser(_user) Then
                Return False
            End If
            If _user.ValidateOrGetErrors() = False Then
                Return False
            End If
            ' Add user and save changes
            _unitOfWork.Users.Add(_user)
            _unitOfWork.SaveChanges()

            MessageBox.Show("User added successfully.")

            Return True
        End Function

        'Delete user not yet implemented
        Public Sub DeleteUser(users As User)
            Dim user = _unitOfWork.Users.GetById(users.UserId)
            If user IsNot Nothing Then
                _unitOfWork.Users.Delete(users.UserId)
                _unitOfWork.SaveChanges()
            Else
                Throw New Exception("User not found")
            End If
        End Sub
        'update user not yet implemented
        Public Sub UpdateUser(user As User)
            Dim existingUser = _unitOfWork.Users.GetById(user.UserId)
            If existingUser IsNot Nothing Then
                existingUser.Username = user.Username
                existingUser.Email = user.Email
                existingUser.Role = user.Role
                existingUser.FirstName = user.FirstName
                existingUser.LastName = user.LastName
                existingUser.ContactNumber = user.ContactNumber
                existingUser.PasswordHash = user.PasswordHash
                existingUser.Address = user.Address
                _unitOfWork.Users.Update(existingUser)
                _unitOfWork.SaveChanges()
            Else
                Throw New Exception("User not found")
            End If
        End Sub
        'Menus
        Public Sub AddMenu(menu As Menu)
            If Not menu.ValidateOrGetErrors() Then
                Exit Sub
            End If
            _unitOfWork.Menus.Add(menu)
            _unitOfWork.SaveChanges()
        End Sub
        Public Sub DeleteMenu(menus As Menu)
            Dim menuItem = _unitOfWork.Menus.GetById(menus.MenuId)
            If menuItem IsNot Nothing Then
                _unitOfWork.Menus.Delete(menus.MenuId)
                _unitOfWork.SaveChanges()
            Else
                Throw New Exception("Menu item not found")
            End If
        End Sub
        Public Function GetAllMenus() As List(Of Menu)
            Return _unitOfWork.Menus.GetAll().ToList()
        End Function
        'Inventories
        Public Function GetAllInventories() As List(Of Inventory)
            Return _unitOfWork.Inventories.GetAll().ToList()
        End Function
        'Orders
        Public Function GetAllOrders() As List(Of Order)
            Return _unitOfWork.Orders.GetAll().ToList()
        End Function
    End Class
End Namespace
