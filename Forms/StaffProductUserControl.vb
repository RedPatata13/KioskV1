Namespace KioskV0.Forms
    Public Class StaffProductUserControl

        Private StaffPosView As StaffPosView

        Public Sub New(posView As StaffPosView)
            InitializeComponent()
            StaffPosView = posView
        End Sub
        Private Sub ProductButton_Click(sender As Object, e As EventArgs) Handles ProductButton.Click
            Dim orderControl As New StaffPosOrderUserControl()
            StaffPosView.OrderListFlowLayout.Controls.Add(orderControl)
        End Sub
    End Class

End Namespace