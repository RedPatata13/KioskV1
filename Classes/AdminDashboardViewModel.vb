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
            Dim previousDate = PreviousDateRange(_view.StartingDateDateTime, _view.EndDateDateTime)

            _view.Order = GetSalesData(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.TotalSales = GetTotalSales(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.NetProfit = GetNetProfit(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.NumberOfCustomers = GetNumberCustomers(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.PreviousSales = GetTotalSales(previousDate.Item1, previousDate.Item2)
            _view.Growth = GetGrowth(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.GrowthPercentage = GetGrowthPercentage(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.LoadChart()
        End Sub
        Private Sub SetMinAndMaxDateForAllData()
            Dim dateRange = GetSalesDateRange()
            _view.Order = GetSalesData(dateRange.Item1, dateRange.Item2)
            _view.TotalSales = GetTotalSales(dateRange.Item1, dateRange.Item2)
            _view.NetProfit = GetNetProfit(dateRange.Item1, dateRange.Item2)
            _view.NumberOfCustomers = GetNumberCustomers(dateRange.Item1, dateRange.Item2)

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
            Return _mediator.GetUnitOfWork.Orders.GetAll().ToList()
        End Function
        Public Function GetTotalSales(startDate As DateTime, endDate As DateTime) As String
            Dim totalSales As Decimal = GetAllOrders().
               Where(Function(order) order.CreatedAt.Date >= DateTime.Parse(startDate).Date And order.CreatedAt.Date <= DateTime.Parse(endDate).Date).
               Sum(Function(order) order.TotalPrice)
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
            Dim totalCost As Decimal = _mediator.GetUnitOfWork.InventoryBatches.GetAll() _
        .Where(Function(st) st.IsActive = 1 AndAlso
                           st.ReceivedDate.Date >= DateTime.Parse(startDate).Date AndAlso
                           st.ReceivedDate.Date <= DateTime.Parse(endDate).Date) _
        .Sum(Function(st) st.UnitCost)

            Return "₱" & totalCost.ToString("F2")
        End Function

        Public Function GetSalesData(startDate As DateTime, endDate As DateTime) As List(Of OrderPrimal)
            Dim allSales = GetAllOrders()

            endDate = endDate.Date.AddDays(1).AddMilliseconds(-1)

            If allSales IsNot Nothing Then
                Return allSales.Where(Function(s) s.CreatedAt >= startDate AndAlso s.CreatedAt <= endDate).ToList()
            Else
                Return New List(Of OrderPrimal)()
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
