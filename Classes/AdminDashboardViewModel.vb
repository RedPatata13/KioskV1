Imports Autofac
Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Services

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
            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Dim _adminService = container.Resolve(Of AdminService)()
            Dim previousDate = _adminService.PreviousDateRange(_view.StartingDateDateTime, _view.EndDateDateTime)

            _view.Order = _adminService.GetSalesData(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.TotalSales = _adminService.GetTotalSales(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.NetProfit = _adminService.GetNetProfit(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.NumberOfCustomers = _adminService.GetNumberCustomers(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.PreviousSales = _adminService.GetTotalSales(previousDate.Item1, previousDate.Item2)
            _view.Growth = _adminService.GetGrowth(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.GrowthPercentage = _adminService.GetGrowthPercentage(_view.StartingDateDateTime, _view.EndDateDateTime)
            _view.LoadChart()
        End Sub
        Private Sub SetMinAndMaxDateForAllData()
            Dim container As IContainer = ContainerConfiguration.ConfigureContainer()
            Dim _adminService = container.Resolve(Of AdminService)()
            Dim dateRange = _adminService.GetSalesDateRange()

            _view.Order = _adminService.GetSalesData(dateRange.Item1, dateRange.Item2)
            _view.TotalSales = _adminService.GetTotalSales(dateRange.Item1, dateRange.Item2)
            _view.NetProfit = _adminService.GetNetProfit(dateRange.Item1, dateRange.Item2)
            _view.NumberOfCustomers = _adminService.GetNumberCustomers(dateRange.Item1, dateRange.Item2)

        End Sub

    End Class

End Namespace
