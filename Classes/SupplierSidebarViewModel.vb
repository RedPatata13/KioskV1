Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class SupplierSidebarViewModel
    Inherits ViewModel(Of SupplierSidebar, KioskV0.SupplierKeys)

    Public Sub New(view As SupplierSidebar, mediator As Mediator(Of SupplierKeys))
        MyBase.New(view, mediator)

        SetEvents()
    End Sub

    Protected Friend Overrides Sub SetEvents()
        MyBase.SetEvents()

        _view.LogoutClick = Sub() _mediator.Logout()
        _view.DashboardClick = Sub() _mediator.SwapPage(SupplierKeys.SupplierDashboard)
        _view.SupplierItems = Sub() _mediator.SwapPage(SupplierKeys.SupplierItems)
    End Sub
    Public Overrides Sub Project(projector As Form)
        MyBase.Project(projector)

        '_view.AutoScroll = True
        ResizeComponents(_mediator.GetSidebarSize())
    End Sub
End Class
