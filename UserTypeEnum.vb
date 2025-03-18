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
    End Enum

    Public Enum CustomerKeys
        CustomerEntry
        CustomerLandingPage
        CustomerTestPage
    End Enum

    Public Enum StaffKeys
        StaffEntry
        StafflandingPage
        SupplierTestPage
    End Enum

    Public Enum SupplierKeys
        SupplierEntry
        SupplierLandingPage
        SupplierTestPage
    End Enum
End Namespace