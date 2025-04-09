Imports KioskV0.KioskV0.Classes
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model
Imports LiveCharts.Maps
Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports System.Runtime.InteropServices.ComTypes
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
        'Admin Dashboard
        Public Function GetTotalSales(startDate As DateTime, endDate As DateTime) As String
            Dim totalSales As Decimal = GetAllOrders().
               Where(Function(order) order.CreatedAt.Date >= DateTime.Parse(startDate).Date And order.CreatedAt.Date <= DateTime.Parse(endDate).Date).
               Sum(Function(order) order.TotalAmount)
            Return "₱" & totalSales.ToString("F2")
        End Function

        Public Function GetNumberCustomers(startDate As DateTime, endDate As DateTime) As Integer
            Return GetAllOrders().Where(Function(order) order.CreatedAt.Date >= startDate.Date AndAlso order.CreatedAt.Date <= endDate.Date).Count()
        End Function

        Public Function GetNetProfit(startDate As String, endDate As String) As String
            Dim totalSales As String = GetTotalSales(startDate, endDate)
            Dim totalCost As String = GetTotalCost(startDate, endDate)

            Dim totalSalesValue As Decimal = Decimal.Parse(totalSales.Replace("₱", "").Trim())
            Dim totalCostValue As Decimal = Decimal.Parse(totalCost.Replace("₱", "").Trim())

            Dim netProfit As Decimal = totalSalesValue - totalCostValue

            Return "₱" & netProfit.ToString("F2")
        End Function

        Public Function GetTotalCost(startDate As String, endDate As String) As String
            Dim totalCost As Decimal = _unitOfWork.SupplierTransactions.GetAll() _
        .Where(Function(st) st.Status = "Completed" AndAlso st.DateRelease.HasValue AndAlso
                            st.DateRelease.Value.Date >= DateTime.Parse(startDate).Date AndAlso
                            st.DateRelease.Value.Date <= DateTime.Parse(endDate).Date) _
        .Sum(Function(st) st.TotalCost)

            Return "₱" & totalCost.ToString("F2")
        End Function

        Public Function GetSalesData(startDate As DateTime, endDate As DateTime) As List(Of Order)
            Dim allSales = GetAllOrders()

            endDate = endDate.Date.AddDays(1).AddMilliseconds(-1)

            If allSales IsNot Nothing Then
                Return allSales.Where(Function(s) s.CreatedAt >= startDate AndAlso s.CreatedAt <= endDate).ToList()
            Else
                Return New List(Of Order)()
            End If
        End Function

        Public Function GetSalesDateRange() As (DateTime?, DateTime?)
            Dim minDate = GetAllOrders().Min(Function(o) CType(o.CreatedAt, DateTime?))
            Dim maxDate = GetAllOrders().Max(Function(o) CType(o.CreatedAt, DateTime?))
            Return (minDate, maxDate)
        End Function
        Public Function PreviousDateRange(_startDate As DateTime, _endDate As DateTime) As (DateTime?, DateTime?)
            Dim startDate As DateTime = _startDate
            Dim endDate As DateTime = _endDate

            ' Calculate the number of days in the range between start and end date
            Dim daysInRange As Integer = (endDate - startDate).Days

            ' Calculate the start date of the previous range
            Dim previousRangeStartDate As DateTime = startDate.AddDays(-daysInRange)

            ' Calculate the end date of the previous range by subtracting the same number of days from the endDate
            Dim previousRangeEndDate As DateTime = endDate.AddDays(-daysInRange)

            ' Return the start and end dates of the previous range
            Return (previousRangeStartDate, previousRangeEndDate)
        End Function

        Public Function GetGrowth(startDate As DateTime, endDate As DateTime)
            Dim previousDate = PreviousDateRange(startDate, endDate)
            Return GetTotalSales(startDate, endDate) - GetTotalSales(previousDate.Item1, previousDate.Item2)
        End Function
        Public Function GetGrowthPercentage(startDate As DateTime, endDate As DateTime) As String
            Dim previousDate = PreviousDateRange(startDate, endDate)

            Dim growth As Decimal = GetTotalSales(startDate, endDate) - GetTotalSales(previousDate.Item1, previousDate.Item2)

            Dim result As Decimal = (growth / GetTotalSales(previousDate.Item1, previousDate.Item2)) * 100

            Return result.ToString("F2") & "%"
        End Function


    End Class
End Namespace
