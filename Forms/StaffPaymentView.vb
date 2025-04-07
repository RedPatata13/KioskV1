Imports System.Drawing.Printing


Namespace KioskV0.Forms
    Public Class StaffPaymentView

        Dim WithEvents Receipt As New PrintDocument
        Dim PrintDocumentDialouge As New PrintPreviewDialog
        Dim longPaper As Integer
        Public recievedAmount As String
        Public payingAmount As String
        Public change As String

        Private Sub Receipt_BeginPrint(sender As Object, e As PrintEventArgs) Handles Receipt.BeginPrint
            Dim pagesetup As New PageSettings
            pagesetup.PaperSize = New PaperSize("Custom", 250, 500) '250 width 500 height
            Receipt.DefaultPageSettings = pagesetup
        End Sub

        Private Sub Receipt_PrintPage(sender As Object, e As PrintPageEventArgs) Handles Receipt.PrintPage
            Dim font8 As New Font("Poppins", 8, FontStyle.Regular)
            Dim font10 As New Font("Poppins", 10, FontStyle.Regular)
            Dim font10b As New Font("Poppins", 10, FontStyle.Bold)
            Dim font14b As New Font("Poppins", 14, FontStyle.Bold)

            Dim leftMargin As Integer = Receipt.DefaultPageSettings.Margins.Left
            Dim centerMargin As Integer = Receipt.DefaultPageSettings.PaperSize.Width / 2
            Dim rightMargin As Integer = Receipt.DefaultPageSettings.PaperSize.Width

            Dim right As New StringFormat
            Dim center As New StringFormat
            Dim left As New StringFormat

            right.Alignment = StringAlignment.Far
            center.Alignment = StringAlignment.Center
            left.Alignment = StringAlignment.Near

            Dim line As String
            Dim dot As String
            line = "-------------------------------------------------------------------"
            dot = "..................................."

            recievedAmount = ReceivedAmountTextBox.Text
            payingAmount = PayingAmountTextBox.Text
            change = ChangeTextBox.Text

            'Format (text, font, color, margin, space_fromthetop, alignment)
            e.Graphics.DrawString("KIOSK TEST", font14b, Brushes.Black, centerMargin, 25, center)
            e.Graphics.DrawString("123 Street, Manila, PH", font10, Brushes.Black, centerMargin, 55, right)
            e.Graphics.DrawString("(0912) 345-6789)", font10, Brushes.Black, centerMargin, 75, right)


            e.Graphics.DrawString("Date", font8, Brushes.Black, 5, 93)
            e.Graphics.DrawString(":", font8, Brushes.Black, 40, 93)
            e.Graphics.DrawString("[Sample]", font8, Brushes.Black, 60, 93)

            e.Graphics.DrawString("Time", font8, Brushes.Black, 5, 108)
            e.Graphics.DrawString(":", font8, Brushes.Black, 40, 108)
            e.Graphics.DrawString("[Sample]", font8, Brushes.Black, 60, 108)

            e.Graphics.DrawString("Receipt No", font8, Brushes.Black, 5, 123)
            e.Graphics.DrawString(":", font8, Brushes.Black, 80, 123)
            e.Graphics.DrawString("[001234]", font8, Brushes.Black, 100, 123)

            e.Graphics.DrawString(line, font8, Brushes.Black, 0, 138)

            e.Graphics.DrawString("Cashier", font8, Brushes.Black, 5, 153)
            e.Graphics.DrawString(":", font8, Brushes.Black, 80, 153)
            e.Graphics.DrawString("[Toni Fowler]", font8, Brushes.Black, 100, 153)

            e.Graphics.DrawString("Customer", font8, Brushes.Black, 5, 168)
            e.Graphics.DrawString(":", font8, Brushes.Black, 80, 168)
            e.Graphics.DrawString("[Choice]", font8, Brushes.Black, 100, 168)

            e.Graphics.DrawString("ORDER SUMMARY", font10, Brushes.Black, 5, 183)

            e.Graphics.DrawString(line, font8, Brushes.Black, 0, 198)

            e.Graphics.DrawString("Subtotal" + dot, font10, Brushes.Black, 5, 213)
            e.Graphics.DrawString("[Price]", font8, Brushes.Black, rightMargin, 213, right)

            e.Graphics.DrawString("VAT (12%)" + dot, font8, Brushes.Black, 8, 228)
            e.Graphics.DrawString("[Price]", font8, Brushes.Black, rightMargin, 228, right)

            e.Graphics.DrawString("Promo Discount" + dot, font8, Brushes.Black, 8, 243)
            e.Graphics.DrawString("[Price]", font8, Brushes.Black, rightMargin, 243, right)

            e.Graphics.DrawString("Total Amount" + dot, font10, Brushes.Black, 5, 258)
            e.Graphics.DrawString($"{payingAmount}", font8, Brushes.Black, rightMargin, 258, right)

            e.Graphics.DrawString("Cash" + dot, font8, Brushes.Black, 8, 273)
            e.Graphics.DrawString($"P{recievedAmount}", font8, Brushes.Black, rightMargin, 273, right)

            e.Graphics.DrawString("Change" + dot, font8, Brushes.Black, 8, 288)
            e.Graphics.DrawString($"P{change}", font8, Brushes.Black, rightMargin, 288, right)


            'Dim cash As Integer
            'Dim _payingamount As Integer
            'Dim _change As Integer

            'cash = ReceivedAmountTextBox.Text
            '_payingamount = PayingAmountTextBox.Text
            '_change = cash - _payingamount

            'payingAmount = _payingamount
            'recievedAmount = cash
            'change = _change

        End Sub



        Private Sub SubmitPaymentButton_Click(sender As Object, e As EventArgs) Handles SubmitPaymentButton.Click
            PrintDocumentDialouge.Document = Receipt
            PrintDocumentDialouge.ShowDialog()
        End Sub
    End Class
End Namespace