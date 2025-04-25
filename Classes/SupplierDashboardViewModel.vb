Imports System.ComponentModel
Imports KioskV0.KioskV0.Classes

Public Class SupplierDashboardViewModel
    Inherits ViewModel(Of SupplierDashboardView, KioskV0.SupplierKeys)

    Private _isPendingView As Boolean = True

    Public Sub New(view As SupplierDashboardView, mediator As Mediator(Of KioskV0.SupplierKeys))
        MyBase.New(view, mediator)

        SetEvents()

        Dim currentUser As User = mediator.GetCurrentUser()
        _view.UnitSoldPercentageDataGridView.DataSource = GetBatchSoldPercentages(currentUser.UserId)


        _view.OrderStatusDataGridView.DataSource = SortBatchRequests(_isPendingView)
        _view.SupplierWelcomeHomeBitchButton.Text = currentUser.FirstName & " " & currentUser.LastName
    End Sub

    Public Function GetBatchSoldPercentages(supplierId As String) As List(Of BatchSoldPercentageDisplay)
        Dim result = _mediator.GetUnitOfWork.InventoryBatches.GetAll().
        Where(Function(b) b.SupplierId = supplierId).
        Select(Function(b) New BatchSoldPercentageDisplay With {
            .BatchNumber = b.BatchName,
            .ItemName = If(b.SupplierItem IsNot Nothing, b.SupplierItem.Name, "Unknown"),
            .QuantityReceived = b.QuantityReceived,
            .RemainingQuantity = b.RemainingQuantity,
            .UnitsSold = b.QuantityReceived - b.RemainingQuantity,
            .SoldPercentage = If(b.QuantityReceived = 0, 0,
                                 Math.Round(((b.QuantityReceived - b.RemainingQuantity) / b.QuantityReceived) * 100, 2))
        }).ToList()

        Return result
    End Function

    Public Function SortBatchRequests(Optional showPending As Boolean = True) As List(Of BatchRequestDisplay)
        Dim requests = _mediator.GetUnitOfWork.BatchRequests.GetAll()

        Dim filtered = If(showPending,
               requests.Where(Function(r) r.IsPending = True),
               requests.Where(Function(r) r.IsPending = False))

        Dim result = filtered.
        OrderByDescending(Function(r) r.DateRequested).
        Select(Function(r) New BatchRequestDisplay With {
            .Item = If(r.Item IsNot Nothing, r.Item.Name, "Unknown"),
            .DateRequested = r.DateRequested,
            .Requester = If(r.Requester IsNot Nothing, r.Requester.FirstName & " " & r.Requester.LastName, "Unknown"),
            .Units = r.Units
        }).ToList()

        Return result
    End Function

    Private Sub TogglePendingApprovedView()
        _isPendingView = Not _isPendingView
        _view.OrderStatusDataGridView.DataSource = SortBatchRequests(_isPendingView)

        If _isPendingView Then
            _view.SwitchPendingCompleteButton.Text = "Show Pending Requests"
        Else
            _view.SwitchPendingCompleteButton.Text = "Show Approved Requests"
        End If
    End Sub


    Private Sub SetEvents()
        _view.SwitchPendingCompleteButtonClick = AddressOf TogglePendingApprovedView
    End Sub

End Class
