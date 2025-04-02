Namespace KioskV0.Classes
    Public Module PageDir
        Public Function GetAdminPages(mediator As Mediator(Of AdminKeys)) As Dictionary(Of AdminKeys, IProjectable)
            Return New Dictionary(Of AdminKeys, IProjectable) From
            {
                {AdminKeys.AdminLandingPage, New Classes.AdminLandingPageViewModel(New Forms.AdminLandingPageView(), mediator)},
                {AdminKeys.AdminTestPage, New Classes.AdminTestPageViewModel(New Forms.AdminTestPageView(), mediator)},
                {AdminKeys.AdminDashboard, New Classes.AdminDashboardViewModel(New Forms.AdminDashboardView(), mediator)},
                {AdminKeys.AdminMenu, New Classes.AdminMenuViewModel(New Forms.AdminMenuView(), mediator)},
                {AdminKeys.AdminInventory, New Classes.AdminInventoryViewModel(New Forms.AdminInventoryView(), mediator)},
                {AdminKeys.AdminOrderHistory, New Classes.AdminOrderHistoryViewModel(New Forms.AdminOrderHistoryView(), mediator)},
                {AdminKeys.AdminStaffTransactions, New Classes.AdminStaffTransactionsViewModel(New Forms.AdminStaffTransactionsView(), mediator)},
                {AdminKeys.AdminAccountSettings, New Classes.AdminAccountSettingsViewModel(New Forms.AdminAccountSettingsView(), mediator)},
                {AdminKeys.AdminAddUser, New Classes.AdminAddUserViewModel(New Forms.AdminAddUserView(), mediator)},
                {AdminKeys.AdminEditInventoryDetails, New Classes.AdminEditMenuDetailsViewModel(New Forms.AdminEditMenuDetailsView(), mediator)},
                {AdminKeys.AdminEditInventory, New Classes.AdminEditInventoryViewModel(New Forms.AdminEditInventoryView(), mediator)},
                {AdminKeys.Sample, New Classes.SampleViewModel(New Forms.SampleForm(), mediator)}
            }
        End Function


        Public Function GetStaffPages(mediator As Mediator(Of StaffKeys)) As Dictionary(Of StaffKeys, IProjectable)
            Return New Dictionary(Of StaffKeys, IProjectable) From {
            {StaffKeys.StafflandingPage, New Classes.StaffLandingPageViewModel(New Forms.StaffLandingPageView(), mediator)}
            }
        End Function
        Public Function GetCustomerPages() As Dictionary(Of CustomerKeys, IProjectable)
            Return New Dictionary(Of CustomerKeys, IProjectable)
        End Function
        Public Function GetSupplierPages() As Dictionary(Of SupplierKeys, IProjectable)
            Return New Dictionary(Of SupplierKeys, IProjectable)
        End Function
    End Module

End Namespace