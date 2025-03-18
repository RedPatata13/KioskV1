Namespace KioskV0.Forms
    Public Class Login
        Public Property SubmitButtonClick As Action
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

        Private Sub SubmitButton_Click(sender As Object, e As EventArgs)
            SubmitButtonClick?.Invoke()
        End Sub

        Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        End Sub

        Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

        End Sub

        Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

        End Sub

        Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

        End Sub
    End Class
End Namespace