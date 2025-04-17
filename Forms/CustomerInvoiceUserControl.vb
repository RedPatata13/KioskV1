Namespace KioskV0.Forms
    Public Class CustomerInvoiceUserControl
        Private Sub CustomerInvoiceUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub CustomerReceiptLbl2_Click(sender As Object, e As EventArgs) Handles CustomerReceiptLbl2.Click

        End Sub

        Private Sub CustomerReceiptLbl_Click(sender As Object, e As EventArgs) Handles CustomerReceiptLbl.Click

        End Sub

        Private Sub OrderPanel_Paint(sender As Object, e As PaintEventArgs) Handles OrderPanel.Paint

        End Sub

        Private Sub OrderNumberLabel_Click(sender As Object, e As EventArgs) Handles OrderNumber.Click

        End Sub

        Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage

            Dim bmp As New Bitmap(OrderPanel.Width, OrderPanel.Height)
            OrderPanel.DrawToBitmap(bmp, New Rectangle(0, 0, OrderPanel.Width, OrderPanel.Height))
            Dim scaleFactor As Single = Math.Min(e.MarginBounds.Width / OrderPanel.Width, e.MarginBounds.Height / OrderPanel.Height)
            e.Graphics.ScaleTransform(scaleFactor, scaleFactor)
            e.Graphics.DrawImage(bmp, 0, 0)

            Dim orderNoFont As New Font("Poppins", 22, FontStyle.Bold)
            Dim yourOrderFont As New Font("Poppins", 22, FontStyle.Bold)
            Dim orderNumberFont As New Font("Poppins", 120, FontStyle.Bold)

            e.Graphics.DrawString(YourOrderLbl.Text, yourOrderFont, Brushes.Black, 50, 50)
            e.Graphics.DrawString(OrderNoLbl.Text, orderNoFont, Brushes.Black, 50, 100)
            e.Graphics.DrawString(OrderNumber.Text, orderNumberFont, Brushes.Black, 50, 150)

        End Sub

        Private Sub PrintOrderNumberButton_Click(sender As Object, e As EventArgs) Handles PrintOrderNumberButton.Click
            PrintDoc.Print()
        End Sub
    End Class

End Namespace