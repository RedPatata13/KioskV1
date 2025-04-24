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
        AdminMenuSelectSupplierItem
        AdminViewDeductions
        AdminStockDebt
        AdminStockDebtCRUD
        AdminResolveStockDebt
    End Enum

    Public Enum CustomerKeys
        CustomerEntry
        CustomerLandingPage
        CustomerTestPage
        CustomerMenu
        CustomerConfirmOrder
        CustomerOrderList
        CustomerPayment

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
        StaffOrderList
    End Enum

    Public Enum SupplierKeys
        SupplierEntry
        SupplierDashboard
        SupplierTestPage
        SupplierItems
    End Enum

    Public Enum ItemStatus
        Active
        Inactive
        OutOfStock
    End Enum
End Namespace