Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class StaffSideBarViewModel
        Inherits ViewModel(Of Forms.StaffSideBar, StaffKeys)

        Public Sub New(view As StaffSideBar, mediator As Mediator(Of StaffKeys))
            MyBase.New(view, mediator)
        End Sub
    End Class

End Namespace