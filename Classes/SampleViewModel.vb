Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class SampleViewModel

        Inherits ViewModel(Of Forms.SampleForm, AdminKeys)

        Public Sub New(view As SampleForm, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
        End Sub

    End Class

End Namespace