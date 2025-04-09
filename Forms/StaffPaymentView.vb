Imports System.Drawing.Printing


Namespace KioskV0.Forms
    Public Class StaffPaymentView

        Dim WithEvents Receipt As New PrintDocument
        Dim PrintDocumentDialouge As New PrintPreviewDialog
        Dim longPaper As Integer
        Public recievedAmount As String
        Public payingAmount As String
        Public change As String
        Public note As String

        Private Sub Receipt_BeginPrint(sender As Object, e As PrintEventArgs) Handles Receipt.BeginPrint
            Dim pagesetup As New PageSettings
            pagesetup.PaperSize = New PaperSize("Custom", 250, 750) '250 width 500 height
            Receipt.DefaultPageSettings = pagesetup
        End Sub

        Private Sub Receipt_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Receipt.PrintPage
            Dim receivedVal As Decimal = 0
            Dim payingVal As Decimal = 0

            Decimal.TryParse(ReceivedAmountTextBox.Text, receivedVal)
            Decimal.TryParse(PayingAmountTextBox.Text, payingVal)

            recievedAmount = receivedVal.ToString("F2")
            payingAmount = payingVal.ToString("F2")
            change = (receivedVal - payingVal).ToString("F2")
            note = OrderNoteTextBox.Text

            Dim cashierName As String = "Toni Fowler"
            Dim customerName As String = "Walk-in"
            Dim orderNumber As String = "ORD-001"
            Dim orderType As String = "Dine In"
            Dim subtotal As Decimal = 0.89D
            Dim vat As Decimal = 0.11D
            Dim discount As Decimal = 0.00D

            Dim font8 As New Font("Roboto", 8, FontStyle.Regular)
            Dim font10 As New Font("Roboto", 10, FontStyle.Regular)
            Dim font10b As New Font("Roboto", 10, FontStyle.Bold)
            Dim font14b As New Font("Roboto", 14, FontStyle.Bold)

            Dim leftMargin As Integer = Receipt.DefaultPageSettings.Margins.Left
            Dim centerMargin As Integer = Receipt.DefaultPageSettings.PaperSize.Width / 2
            Dim rightMargin As Integer = Receipt.DefaultPageSettings.PaperSize.Width

            Dim right As New StringFormat With {.Alignment = StringAlignment.Far}
            Dim center As New StringFormat With {.Alignment = StringAlignment.Center}
            Dim left As New StringFormat With {.Alignment = StringAlignment.Near}

            Dim line As String = "------------------------------------------------"
            Dim dot As String = "......................"

            Dim logoImage As Image = My.Resources.ResourceManager.GetObject("LOGO_traced")
            e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - 150) / 2), 5, 150, 150)

            e.Graphics.DrawString("Fast Food Kiosk", font14b, Brushes.Black, centerMargin, 150, center)
            e.Graphics.DrawString("123 Street, Manila, PH", font10, Brushes.Black, 2, 170)
            e.Graphics.DrawString("(0912) 345-6789", font8, Brushes.Black, 2, 188)

            e.Graphics.DrawString("Date :", font8, Brushes.Black, 5, 203)
            e.Graphics.DrawString(Date.Now.ToString("MM/dd/yyyy"), font8, Brushes.Black, 60, 203)

            e.Graphics.DrawString("Time :", font8, Brushes.Black, 5, 218)
            e.Graphics.DrawString(Date.Now.ToString("hh:mm tt"), font8, Brushes.Black, 60, 218)

            e.Graphics.DrawString("Receipt No :", font8, Brushes.Black, 5, 233)
            e.Graphics.DrawString(orderNumber, font8, Brushes.Black, 100, 233)

            e.Graphics.DrawString(line, font8, Brushes.Black, 0, 248)

            e.Graphics.DrawString("Cashier :", font8, Brushes.Black, 5, 263)
            e.Graphics.DrawString(cashierName, font8, Brushes.Black, 100, 263)

            e.Graphics.DrawString("Customer :", font8, Brushes.Black, 5, 278)
            e.Graphics.DrawString(customerName, font8, Brushes.Black, 100, 278)

            e.Graphics.DrawString("ORDER SUMMARY", font10b, Brushes.Black, 5, 293)
            e.Graphics.DrawString(line, font8, Brushes.Black, 0, 308)

            e.Graphics.DrawString("Subtotal" + dot, font10, Brushes.Black, 5, 323)
            e.Graphics.DrawString("P" & subtotal.ToString("F2"), font8, Brushes.Black, rightMargin, 323, right)

            e.Graphics.DrawString("VAT (12%)" + dot, font8, Brushes.Black, 8, 338)
            e.Graphics.DrawString("P" & vat.ToString("F2"), font8, Brushes.Black, rightMargin, 338, right)

            e.Graphics.DrawString("Promo Discount" + dot, font8, Brushes.Black, 8, 353)
            e.Graphics.DrawString("P" & discount.ToString("F2"), font8, Brushes.Black, rightMargin, 353, right)

            e.Graphics.DrawString("Total Amount" + dot, font10b, Brushes.Black, 5, 368)
            e.Graphics.DrawString("P" & payingAmount, font10b, Brushes.Black, rightMargin, 368, right)

            e.Graphics.DrawString("Cash" + dot, font8, Brushes.Black, 8, 383)
            e.Graphics.DrawString("P" & recievedAmount, font8, Brushes.Black, rightMargin, 383, right)

            e.Graphics.DrawString("Change" + dot, font8, Brushes.Black, 8, 393)
            e.Graphics.DrawString("P" & change, font8, Brushes.Black, rightMargin, 393, right)

            Dim yPos As Integer = 413
            e.Graphics.DrawString("ORDER  #", font8, Brushes.Black, 5, yPos)
            e.Graphics.DrawString(orderNumber, font8, Brushes.Black, 100, yPos)
            yPos += 15

            e.Graphics.DrawString(orderType, font8, Brushes.Black, 5, yPos)
            yPos += 15

            e.Graphics.DrawString("ORDER NOTE:", font8, Brushes.Black, 5, yPos)
            yPos += 15

            Dim noteWidth As Integer = rightMargin - 10
            Dim noteText As String = note
            Dim noteHeight As Integer = e.Graphics.MeasureString(noteText, font8, noteWidth).Height
            e.Graphics.DrawString(noteText, font8, Brushes.Black, 5, yPos, New StringFormat With {.Trimming = StringTrimming.Word})
            yPos += CInt(noteHeight) + 10

            e.Graphics.DrawString("Thank you for dining with us!", font8, Brushes.Black, 5, yPos)
            yPos += 15
            e.Graphics.DrawString(line, font8, Brushes.Black, 0, yPos)
            yPos += 15
            e.Graphics.DrawString("No Refund After Payment", font8, Brushes.Black, 5, yPos)
            yPos += 15
            e.Graphics.DrawString("Enjoy your meal!", font8, Brushes.Black, 5, yPos)
        End Sub


        Private Sub SubmitPaymentButton_Click(sender As Object, e As EventArgs) Handles SubmitPaymentButton.Click
            PrintDocumentDialouge.Document = Receipt
            PrintDocumentDialouge.ShowDialog()
        End Sub

        Private Sub CalculateChange()
            Dim received As Decimal
            Dim paying As Decimal


            If Decimal.TryParse(ReceivedAmountTextBox.Text, received) AndAlso Decimal.TryParse(PayingAmountTextBox.Text, paying) Then
                Dim change As Decimal = received - paying
                ChangeLabelText.Text = change.ToString("F2")
                ChangeLabelText.Visible = True
            Else
                ChangeLabelText.Visible = False
            End If
        End Sub

        Private Sub PayingAmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles PayingAmountTextBox.TextChanged
            CalculateChange()
        End Sub

        Private Sub ReceivedAmountTextBox_TextChanged(sender As Object, e As EventArgs) Handles ReceivedAmountTextBox.TextChanged
            CalculateChange()
        End Sub
    End Class
End Namespace