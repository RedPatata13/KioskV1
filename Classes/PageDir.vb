Imports KioskV0.KioskV0.Forms

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
                {AdminKeys.AdminAddUser, New Classes.AdminEditUserViewModel(New Forms.AdminAddUserView(), mediator)},
                {AdminKeys.AdminEditMenuDetails, New Classes.AdminEditMenuDetailsViewModel(New Forms.AdminEditMenuDetailsView(), mediator)},
                {AdminKeys.AdminEditInventory, New Classes.AdminEditInventoryViewModel(New Forms.AdminEditInventoryView(), mediator)},
                {AdminKeys.AdminSupplyRequest, New Classes.AdminSupplyRequestViewModel(New Forms.AdminSupplyRequestView(), mediator)},
                {AdminKeys.Sample, New Classes.SampleViewModel(New Forms.SampleForm(), mediator)},
                {AdminKeys.AdminMenuSelectSupplierItem, New Classes.AdminMenuSelectSupplierItemViewModel(New AdminMenuSelectSupplierItemView(), mediator)}
            }
        End Function


        Public Function GetStaffPages(mediator As Mediator(Of StaffKeys)) As Dictionary(Of StaffKeys, IProjectable)
            Return New Dictionary(Of StaffKeys, IProjectable) From
            {
                {StaffKeys.StafflandingPage, New Classes.StaffLandingPageViewModel(New Forms.StaffLandingPageView(), mediator)},
                {StaffKeys.StaffPayment, New Classes.StaffPaymentViewModel(New Forms.StaffPaymentView(), mediator)},
                {StaffKeys.StaffSideBar, New Classes.StaffSideBarViewModel(New Forms.StaffSideBar(), mediator)},
                {StaffKeys.StaffPos, New Classes.StaffPosViewModel(New Forms.StaffPosView(), mediator)},
                {StaffKeys.StaffManagerAuthorization, New Classes.StaffManagerAuthorizationViewModel(New Forms.StaffManagerAuthorizationView(), mediator)},
                {StaffKeys.StaffCreditSales, New Classes.StaffCreditSalesViewModel(New Forms.StaffCreditSalesView(), mediator)}
            }
        End Function
        Public Function GetCustomerPages(mediator As Mediator(Of CustomerKeys)) As Dictionary(Of CustomerKeys, IProjectable)
            Return New Dictionary(Of CustomerKeys, IProjectable) From
            {
               {CustomerKeys.CustomerConfirmOrder, New Classes.CustomerConfirmOrderViewModel(New Forms.CustomerConfirmOrderView(), mediator)},
               {CustomerKeys.CustomerMenu, New Classes.CustomerMenuViewModel(New Forms.CustomerMenuView(), mediator)},
               {CustomerKeys.CustomerOrderList, New Classes.CustomerOrderListViewModel(New Forms.CustomerOrderListView(), mediator)},
               {CustomerKeys.CustomerPayment, New Classes.CustomerPaymentViewModel(New Forms.CustomerPaymentView(), mediator)}
            }
        End Function
        Public Function GetSupplierPages(mediator As Mediator(Of SupplierKeys)) As Dictionary(Of SupplierKeys, IProjectable)
            Return New Dictionary(Of SupplierKeys, IProjectable) From
            {
                {SupplierKeys.SupplierLandingPage, New SupplierLandingPageViewModel(New SupplierLandingPageView(), mediator)},
                {SupplierKeys.SupplierPendingRequest, New SupplierPendingRequestsViewModel(New SupplierPendingRequestsView(), mediator)},
                {SupplierKeys.SupplierTransaction, New SupplierTransactionHistoryViewModel(New SupplierTransactionHistoryView(), mediator)},
                {SupplierKeys.SupplierItems, New SupplierItemsViewModel(New SupplierItemsView(), mediator)},
                {SupplierKeys.SupplierEditSupplierItem, New SupplierEditSupplierItemViewModel(New SupplierEditSupplierItems(), mediator)}
            }
        End Function
    End Module

End Namespace

'{SupplierKeys.SupplierItems, New SupplierItemsViewModel(New SupplierItemsView(), mediator)}