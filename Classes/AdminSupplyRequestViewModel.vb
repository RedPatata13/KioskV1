Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminSupplyRequestViewModel
        Inherits ViewModel(Of AdminSupplyRequestView, AdminKeys)

        Public Sub New(view As AdminSupplyRequestView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace