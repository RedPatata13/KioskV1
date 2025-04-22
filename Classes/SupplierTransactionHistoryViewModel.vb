Imports Autofac.Core
Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class SupplierTransactionHistoryViewModel
        Inherits ViewModel(Of SupplierTransactionHistoryView, SupplierKeys)
        Implements IDisposable
        Private _disposed As Boolean = False
        Public Sub New(view As SupplierTransactionHistoryView, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)

            ' Initial load
            LoadTransactionHistory()

            ' Subscribe to request status changes
            AddHandler _mediator.RequestStatusChanged, AddressOf OnRequestStatusChanged
        End Sub

        Private Sub OnRequestStatusChanged(sender As Object, e As EventArgs)
            ' Reload transaction history when request statuses change
            LoadTransactionHistory()
        End Sub

        Public Sub LoadTransactionHistory()
            ' Get current supplier
            Dim currentSupplier = _mediator.GetCurrentUser()
            If currentSupplier Is Nothing Then
                MessageBox.Show("Current supplier is null!")
                Return
            End If

            ' Get all processed requests for this supplier
            Dim processedRequests = _mediator.GetUnitOfWork().SupplyRequests.GetAll().Where(
                Function(req) req.SupplierID = currentSupplier.UserId AndAlso
                           (req.Status = "Accepted" OrElse req.Status = "Declined")).ToList()

            ' Clear existing rows
            _view.TransactionDataGridView.Rows.Clear()

            ' Add rows for each processed request
            For Each request In processedRequests
                Dim row As String() = {
                    request.ID,
                    request.ProductName,
                    request.Quantity.ToString(),
                    request.UnitCost.ToString("C"),
                    (request.Quantity * request.UnitCost).ToString("C"),
                    request.Status,
                    request.CreatedAt.ToString("MM/dd/yyyy HH:mm")
                }

                ' Add row to the DataGridView
                Dim rowIndex = _view.TransactionDataGridView.Rows.Add(row)

                ' Apply color based on status
                If request.Status = "Accepted" Then
                    _view.TransactionDataGridView.Rows(rowIndex).DefaultCellStyle.BackColor = Color.LightGreen
                ElseIf request.Status = "Declined" Then
                    _view.TransactionDataGridView.Rows(rowIndex).DefaultCellStyle.BackColor = Color.LightPink
                End If
            Next

            ' Refresh the view
            _view.TransactionDataGridView.Refresh()
        End Sub

        ' Clean up when this view is disposed
        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        ' Dispose pattern implementation
        Protected Sub Dispose(disposing As Boolean)
            If Not _disposed Then
                If disposing Then
                    ' Unsubscribe from events
                    RemoveHandler _mediator.RequestStatusChanged, AddressOf OnRequestStatusChanged
                End If

                _disposed = True
            End If
        End Sub
        Protected Overrides Sub Finalize()
            Dispose(False)
            MyBase.Finalize()
        End Sub
    End Class
End Namespace