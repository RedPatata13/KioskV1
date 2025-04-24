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
        Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            PasswordField.UseSystemPasswordChar = True
        End Sub
        Private Sub Show_Click(sender As Object, e As EventArgs) Handles Show.Click
            If PasswordField.UseSystemPasswordChar = True Then
                PasswordField.UseSystemPasswordChar = False
                Hide.BringToFront()
            End If
        End Sub

        Private Sub Hide_Click(sender As Object, e As EventArgs) Handles Hide.Click
            If PasswordField.UseSystemPasswordChar = False Then
                PasswordField.UseSystemPasswordChar = True
                Show.BringToFront()
            End If
        End Sub
    End Class
End Namespace