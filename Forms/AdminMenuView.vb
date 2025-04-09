Namespace KioskV0.Forms
    Public Class AdminMenuView
        Public Property AddMenuButtonClick As Action
        Public Property MenuSearch As Action
        Public ReadOnly Property ItemPanel As FlowLayoutPanel
            Get
                Return MenuListFlowLayoutPanel
            End Get
        End Property

        Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles SearchMenu.TextChanged
            MenuSearch?.Invoke()
        End Sub

        Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

        End Sub

        Private Sub AddMenuButton_Click(sender As Object, e As EventArgs) Handles AddMenuButton.Click
            AddMenuButtonClick?.Invoke()
        End Sub
    End Class
End Namespace