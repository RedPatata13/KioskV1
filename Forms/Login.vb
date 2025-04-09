Namespace KioskV0.Forms
    Public Class Login
        Public Property SubmitButtonClick As Action
        Public Property CustomerButtonClick As Action
        Public Property UID As String
            Get
                Return UIDField.Text
            End Get

            Set(value As String)
                UIDField.Text = value
            End Set
        End Property

        Public Property Password As String
            Get
                Return PasswordField.Text
            End Get
            Set(value As String)
                PasswordField.Text = value
            End Set
        End Property

        Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
            SubmitButtonClick?.Invoke()
        End Sub

        Private Sub CustomerLogInButton_Click(sender As Object, e As EventArgs) Handles CustomerLogInButton.Click
            CustomerButtonClick?.Invoke()
        End Sub
    End Class
End Namespace