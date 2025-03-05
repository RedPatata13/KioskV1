Namespace KioskV0.Classes
    Public Module PageDir
        Public Function GetAdminPages(mediator As Mediator(Of AdminKeys)) As Dictionary(Of AdminKeys, IProjectable)
            Return New Dictionary(Of AdminKeys, IProjectable) From
            {
                {AdminKeys.AdminLandingPage, New Classes.AdminLandingPageViewModel(New Forms.AdminLandingPageView(), mediator)},
                {AdminKeys.AdminTestPage, New Classes.AdminTestPageViewModel(New Forms.AdminTestPageView(), mediator)}
            }
        End Function


        Public Function GetStaffPages() As Dictionary(Of StaffKeys, IProjectable)
            Return New Dictionary(Of StaffKeys, IProjectable)
        End Function
        Public Function GetCustomerPages() As Dictionary(Of CustomerKeys, IProjectable)
            Return New Dictionary(Of CustomerKeys, IProjectable)
        End Function
        Public Function GetSupplierPages() As Dictionary(Of SupplierKeys, IProjectable)
            Return New Dictionary(Of SupplierKeys, IProjectable)
        End Function
    End Module

End Namespace