Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class CustomerConfirmOrderViewModel
        Inherits ViewModel(Of Forms.CustomerConfirmOrderView, CustomerKeys)

        Public Sub New(view As CustomerConfirmOrderView, mediator As Mediator(Of CustomerKeys))
            MyBase.New(view, mediator)
        End Sub

    End Class

End Namespace