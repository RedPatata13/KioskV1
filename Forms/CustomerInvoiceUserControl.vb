Namespace KioskV0.Forms
    Public Class CustomerInvoiceUserControl
        Dim WithEvents PrintDoc As New Printing.PrintDocument()

        Public Event ReturnToMenuClick()

        Public Sub SetOrderNumber(orderNumber As String)
            OrderNumberLabel.Text = $"{orderNumber}"
        End Sub

        Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click

            RaiseEvent ReturnToMenuClick()

            PrintDoc.Print()

        End Sub
    End Class
End Namespace
