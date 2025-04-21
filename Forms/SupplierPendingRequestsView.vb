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

    End Class
End Namespace
