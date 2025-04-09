Namespace KioskV0
    Public Enum UserType
        Admin
        Staff
        Supplier
        Customer
        Null
    End Enum

    Public Enum AdminKeys
        AdminEntry
        AdminLandingPage
        AdminTestPage
        Sample
        AdminDashboard
        AdminMenu
        AdminInventory
        AdminOrderHistory
        AdminStaffTransactions
        AdminAccountSettings
        AdminEditMenuDetails
        AdminAddUser
        AdminEditInventory
        AdminSupplyRequest
    End Enum

    Public Enum CustomerKeys
        CustomerEntry
        CustomerLandingPage
        CustomerTestPage
        CustomerAddNote
        CustomerOrderType
        CustomerMenu
        CustomerConfirmOrder
        CustomerOrderList
        CustomerOrderQuantity
        CustomerInvoice
        CustomerThankYou
    End Enum

    Public Enum StaffKeys
        StaffEntry
        StafflandingPage
        SupplierTestPage
        StaffPos
        StaffCreditSales
        StaffManagerAuthorization
        StaffPayment
        StaffSideBar
    End Enum

    Public Enum SupplierKeys
        SupplierEntry
        SupplierLandingPage
        SupplierTestPage
    End Enum

    Public Enum ItemStatus
        Active
        Inactive
        OutOfStock
    End Enum
End Namespace