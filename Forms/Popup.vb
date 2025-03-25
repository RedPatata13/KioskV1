Public Class Popup
    Implements IPopup

    Private Sub Popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Close(action As Action) Implements IPopup.Closing
        action?.Invoke()
    End Sub
End Class

Public Interface IPopup
    Sub Closing(action As Action)
End Interface
