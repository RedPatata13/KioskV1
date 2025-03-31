Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminEditInventoryViewModel
        Inherits ViewModel(Of AdminEditInventoryView, AdminKeys)

        Public Sub New(view As AdminEditInventoryView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace