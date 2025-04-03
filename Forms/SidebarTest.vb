Public Class SidebarTest

    Public Property HomeButtonClick As Action
    Public Property TestButtonClick As Action

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        HomeButtonClick?.Invoke()
    End Sub

    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        TestButtonClick?.Invoke()
    End Sub
End Class