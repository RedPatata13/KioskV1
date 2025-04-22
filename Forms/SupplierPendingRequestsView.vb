Namespace KioskV0.Forms
    Public Class SupplierPendingRequestsView
        Private Sub SupplierPendingRequestsView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Public Sub ShowDetailsUC(detailsUC As SupplierRequestDetailsUserControl)
            DetailsPanel.Controls.Clear()
            DetailsPanel.BringToFront()
            DetailsPanel.Controls.Add(detailsUC)
            detailsUC.Dock = DockStyle.Fill
        End Sub

        Public Sub ShowPendingList()
            DetailsPanel.Controls.Clear()
            Panel1.BringToFront()
        End Sub

        Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

        End Sub

        Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

        End Sub

        Private Sub PendingReqsFlowLayout_Paint(sender As Object, e As PaintEventArgs) Handles PendingReqsFlowLayout.Paint

        End Sub
    End Class
End Namespace
