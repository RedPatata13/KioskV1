Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class CustomerPaymentViewModel
        Inherits ViewModel(Of Forms.CustomerPaymentView, CustomerKeys)

        Public Sub New(view As CustomerPaymentView, mediator As Mediator(Of CustomerKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace