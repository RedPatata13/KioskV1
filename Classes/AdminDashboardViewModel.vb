Imports KioskV0.KioskV0.Forms
Namespace KioskV0.Classes
    Public Class AdminDashboardViewModel
        Inherits ViewModel(Of Forms.AdminDashboardView, AdminKeys)

        Public Sub New(view As AdminDashboardView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            SetMinAndMaxDateForAllData()
            _view.LoadChart()
            SetEvents()
        End Sub
        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            _view.RangeOfDateClick = AddressOf RangeOfDateClick
        End Sub
        Private Sub RangeOfDateClick()
            If _view.StartingDateDateTime = DateTime.MinValue OrElse _view.EndDateDateTime = DateTime.MinValue Then
                Return
            End If

            Dim previousDate = PreviousDateRange(_view.StartingDateDateTime, _view.EndDateDateTime)

            _view.Order = GetSalesData(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.TotalSales = GetTotalSales(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.NetProfit = GetNetProfit(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.NumberOfCustomers = GetNumberCustomers(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.LoadChart()
        End Sub

        Private Sub SetMinAndMaxDateForAllData()
            Dim dateRange = GetSalesDateRange()
            Dim startDate = dateRange.Item1.GetValueOrDefault(DateTime.MinValue) ' Default to DateTime.MinValue
            Dim endDate = dateRange.Item2.GetValueOrDefault(DateTime.MinValue)

            _view.Order = GetSalesData(startDate, endDate)
            _view.TotalSales = GetTotalSales(startDate, endDate)
            _view.NetProfit = GetNetProfit(startDate.ToString(), endDate.ToString())
            _view.NumberOfCustomers = GetNumberCustomers(startDate, endDate)
        End Sub
        '*****************************************************************Services
        'VALIDATION SERVICE
        Public Function ValidateUser(user As User) As Boolean
            Dim existingUser = _mediator.GetUnitOfWork.Users.GetAll.FirstOrDefault(Function(u) u.Username = user.Username)
            If existingUser IsNot Nothing Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            Return True
        End Function
        'ADMIN SERVICE
        Public Function GetAllOrders() As List(Of OrderPrimal)
            Dim orders = _mediator.GetUnitOfWork.Orders.GetAll()
            Return If(orders?.ToList(), New List(Of OrderPrimal)())
        End Function
        Public Function GetTotalSales(startDate As DateTime, endDate As DateTime) As String
            Dim orders = GetAllOrders()
            Dim totalSales As Decimal = If(orders?.
                                   Where(Function(order) order.CreatedAt.Date >= startDate.Date AndAlso order.CreatedAt.Date <= endDate.Date).
                                   Sum(Function(order) order.TotalPrice), 0D)
            Return "₱" & totalSales.ToString("F2")
        End Function

        Public Function GetNumberCustomers(startDate As DateTime, endDate As DateTime) As Integer
            Dim orders = GetAllOrders()
            Return If(orders?.
              Where(Function(order) order.CreatedAt.Date >= startDate.Date AndAlso order.CreatedAt.Date <= endDate.Date).Count(), 0)
        End Function

        Public Function GetNetProfit(startDate As DateTime, endDate As DateTime) As String
            Dim totalSalesDecimal As Decimal
            Decimal.TryParse(GetTotalSales(startDate, endDate).Replace("₱", "").Trim(), totalSalesDecimal)

            Dim totalCostDecimal As Decimal
            Decimal.TryParse(GetTotalCost(startDate.ToString(), endDate.ToString()).Replace("₱", "").Trim(), totalCostDecimal)

            Dim netProfit As Decimal = totalSalesDecimal - totalCostDecimal

            Return "₱" & netProfit.ToString("F2")
        End Function
        Public Function GetTotalCost(startDate As String, endDate As String) As String
            Dim parsedStartDate As DateTime = DateTime.Parse(startDate)
            Dim parsedEndDate As DateTime = DateTime.Parse(endDate)

            Dim totalCost As Decimal = _mediator.GetUnitOfWork.InventoryBatches.GetAll() _
        .Where(Function(st) st.RemainingQuantity > 0 AndAlso
                            st.ReceivedDate.Date >= parsedStartDate.Date AndAlso
                            st.ReceivedDate.Date <= parsedEndDate.Date) _
        .Sum(Function(st) st.UnitCost * st.QuantityReceived)

            Return "₱" & totalCost.ToString("F2")
        End Function


        Public Function GetSalesData(startDate As DateTime, endDate As DateTime) As List(Of OrderPrimal)
            Dim allSales = GetAllOrders()
            endDate = endDate.Date.AddDays(1).AddMilliseconds(-1)
            Return If(allSales?.Where(Function(s) s.CreatedAt >= startDate AndAlso s.CreatedAt <= endDate).ToList(), New List(Of OrderPrimal)())
        End Function

        Public Function GetSalesDateRange() As (DateTime?, DateTime?)
            Dim orders = GetAllOrders()
            Dim minDate = If(orders?.Min(Function(o) CType(o.CreatedAt, DateTime?)), DateTime.MinValue)
            Dim maxDate = If(orders?.Max(Function(o) CType(o.CreatedAt, DateTime?)), DateTime.MinValue)
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


    End Class

End Namespace