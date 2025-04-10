Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Forms
    Public Class StaffProductCategoryUserControl

        Private StaffPosView As StaffPosView

        Public Sub New(posView As StaffPosView)
            InitializeComponent()
            StaffPosView = posView
        End Sub
        Private Sub ProductCategoryButton_Click(sender As Object, e As EventArgs) Handles ProductCategoryButton.Click
            Dim orderControl As New StaffPosOrderUserControl()
            orderControl.ItemProductName = "Category"
            StaffPosView.OrderListFlowLayout.Controls.Add(orderControl)
        End Sub

    End Class
End Namespace