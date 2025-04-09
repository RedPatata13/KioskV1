Namespace KioskV0.Forms
    Public Class StaffProductVariationUserControl

        Private StaffPosView As StaffPosView

        Public Sub New(posView As StaffPosView)
            InitializeComponent()
            StaffPosView = posView
        End Sub
        Private Sub ProductVariationButton_Click(sender As Object, e As EventArgs) Handles ProductVariationButton.Click
            Dim orderControl As New StaffPosOrderUserControl()
            StaffPosView.OrderListFlowLayout.Controls.Add(orderControl)
        End Sub
    End Class

End Namespace