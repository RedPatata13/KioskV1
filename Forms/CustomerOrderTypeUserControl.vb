Namespace KioskV0.Forms
    Public Class CustomerOrderTypeUserControl
        Private Sub CustomerOrderTypeUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub TakeOutButton_Click(sender As Object, e As EventArgs) Handles TakeOutButton.Click

            TakeOutButton.HoverState.FillColor = ColorTranslator.FromHtml("#EAEAEA")
            TakeOutButton.HoverState.ForeColor = Color.Black

        End Sub

        Private Sub DineInButton_Click(sender As Object, e As EventArgs) Handles DineInButton.Click
            DineInButton.HoverState.FillColor = ColorTranslator.FromHtml("#EAEAEA")
            DineInButton.HoverState.ForeColor = Color.Black
        End Sub
    End Class

End Namespace