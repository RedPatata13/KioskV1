Imports System.ComponentModel.DataAnnotations

Namespace KioskV0
    Public Enum UserType
        <Display(Name:="Admin")>
        Admin = 0

        <Display(Name:="Staff")>
        Staff = 1

        <Display(Name:="Supplier")>
        Supplier = 2

        <Display(Name:="Customer")>
        Customer = 3

        <Display(Name:="None")>
        Null = 4
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