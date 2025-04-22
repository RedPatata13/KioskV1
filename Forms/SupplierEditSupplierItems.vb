Imports KioskV0.KioskV0.Classes

Namespace KioskV0.Forms
    Public Class SupplierEditSupplierItems
        Public Property SaveClicked As Action
        Public Property CancelClicked As Action
        Public Property DeleteClicked As Action


        Private Sub _saveButton_Click(sender As Object, e As EventArgs) Handles _saveButton.Click
            SaveClicked?.Invoke()
        End Sub

        Private Sub _cancelButton_Click(sender As Object, e As EventArgs) Handles _cancelButton.Click
            CancelClicked?.Invoke()
        End Sub

<<<<<<< HEAD
        Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
            DeleteClicked?.Invoke()
=======
        Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

        End Sub

        Private Sub DescField_TextChanged(sender As Object, e As EventArgs) Handles DescField.TextChanged

        End Sub

        Private Sub _itemNameField_TextChanged(sender As Object, e As EventArgs) Handles _itemNameField.TextChanged

        End Sub

        Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel6.Click

        End Sub

        Private Sub _IDField_TextChanged(sender As Object, e As EventArgs) Handles _IDField.TextChanged

        End Sub

        Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

        End Sub

        Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel3.Click

        End Sub

        Private Sub SupplierEditSupplierItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

>>>>>>> 2ccb63bf22d1ca6f23858979392ba795bfd84fd3
        End Sub
    End Class
End Namespace