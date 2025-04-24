Imports System.Security.Cryptography.X509Certificates

Public Class SupplierItemDetailView

    Public Event CopyIdButtonClick()

    Private Sub CopyIdButton_Click(sender As Object, e As EventArgs) Handles CopyIdButton.Click
        RaiseEvent CopyIdButtonClick()
    End Sub
End Class