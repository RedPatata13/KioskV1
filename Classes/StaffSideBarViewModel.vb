Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class StaffSideBarViewModel
        Inherits ViewModel(Of Forms.StaffSideBar, StaffKeys)

        Public Sub New(view As StaffSideBar, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)
            SetEvents()
        End Sub

        Protected Friend Overrides Sub SetEvents()
            _view.POSButtonClick = AddressOf StaffPosButtonClick
            _view.CreditSalesButtonClick = AddressOf CreditSalesButtonClick
        End Sub

        Private Sub StaffPosButtonClick()
            _mediator.SwapPage(StaffKeys.StaffPos)
        End Sub

        Private Sub CreditSalesButtonClick()
            _mediator.SwapPage(StaffKeys.StaffCreditSales)
        End Sub
    End Class

End Namespace