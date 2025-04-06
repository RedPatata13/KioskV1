Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class UserControl(Of T1, T2)
        Private view As AdminTransactionHistoryUserControl
        Private mediator As Mediator(Of AdminKeys)

        Public Sub New(view As AdminTransactionHistoryUserControl, mediator As Mediator(Of AdminKeys))
            Me.view = view
            Me.mediator = mediator
        End Sub
    End Class
End Namespace
