Namespace KioskV0.Forms
    Public Class StaffPosView


        Private Sub StaffPosView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim categoryControl As New StaffProductCategoryUserControl(Me)
            Dim productControl As New StaffProductUserControl(Me)
            Dim variationControl As New StaffProductVariationUserControl(Me)

            CategoryButtonFlowLayout.Controls.Add(categoryControl)
            ProductButtonFlowLayout.Controls.Add(productControl)
            VariationButtonFlowLayout.Controls.Add(variationControl)
        End Sub

        Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
            Dim StaffPaymentView As New StaffPaymentView()
            StaffPaymentView.Show()
        End Sub



    End Class
End Namespace
