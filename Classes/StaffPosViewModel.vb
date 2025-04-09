Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class StaffPosViewModel
        Inherits ViewModel(Of Forms.StaffPosView, StaffKeys)

        Public Sub New(view As StaffPosView, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace