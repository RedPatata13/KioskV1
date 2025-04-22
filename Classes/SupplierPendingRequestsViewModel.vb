Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class SupplierPendingRequestsViewModel
        Inherits ViewModel(Of SupplierPendingRequestsView, SupplierKeys)

        
        Public Sub New(view As SupplierPendingRequestsView, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)
            LoadPendingRequests()

        End Sub


        Private Sub LoadPendingRequests()
            _view.PendingReqsFlowLayout.Controls.Clear()

            Dim currentSupplier = _mediator.GetCurrentUser
            If currentSupplier Is Nothing Then
                MessageBox.Show("Current supplier is null!")
                Return
            End If

            '    ' Debug info
            '    Dim allRequests = _mediator.GetSupplyRequestList
            '    Dim debugInfo = $"Total requests: {allRequests.Count}, " &
            '            $"Current SupplierID: {currentSupplier.UserId}, "
            '    '$"Pending for this supplier: {allRequests.Count(Function(req) req.SupplierID = currentSupplier.UserId AndAlso req.Status = "Pending")}"

            '    MessageBox.Show(debugInfo)

            '    Dim pendingReqs = allRequests.Where(
            'Function(req) req.SupplierID = currentSupplier.UserId AndAlso req.Status = "Pending").ToList(

            Dim pendingReqs = _mediator.GetSupplyRequestList.Where(
               Function(req) req.SupplierID = currentSupplier.UserId AndAlso req.Status = "Pending").ToList()

            For Each request In pendingReqs
                Dim uc As New SupplyRequestUserControl()
                uc.Bind(request)

                AddHandler uc.SelfClicked, Sub() ShowRequestDetails(request)   
                _view.PendingReqsFlowLayout.Controls.Add(uc)
            Next

        End Sub

        Private Sub ShowRequestDetails(request As SupplyRequest)
            Dim detailsUC As New SupplierRequestDetailsUserControl
            detailsUC.BindDetails(request)

            AddHandler detailsUC.AcceptClicked, Sub()
                                                    OnAcceptClicked(request)
                                                    LoadPendingRequests()
                                                End Sub
            AddHandler detailsUC.Declineclicked, Sub()
                                                     MessageBox.Show("Decline button clicked!")
                                                     OnDeclineClicked(request)
                                                     LoadPendingRequests()
                                                 End Sub
            AddHandler detailsUC.Cancelclicked, Sub()
                                                    _view.ShowPendingList()
                                                End Sub
            _view.ShowDetailsUC(detailsUC)
        End Sub

        Private Sub OnAcceptClicked(request As SupplyRequest)
            'request.Status = "Accepted"
            'AddInventoryBatchForRequest(request)
            '_mediator.GetUnitOfWork().SaveChanges()
            '_view.ShowPendingList()
            'LoadPendingRequests()
            request.Status = "Accepted"
            AddInventoryBatchForRequest(request)
            _mediator.GetUnitOfWork().SaveChanges()
            MessageBox.Show("Request accepted successfully!")
            _view.ShowPendingList()
            _view.PendingReqsFlowLayout.Controls.Clear()
            Dim currentSupplier = _mediator.GetCurrentUser
            Dim freshRequestList = _mediator.GetUnitOfWork().SupplyRequests.GetAll().ToList()

            Dim pendingReqs = freshRequestList.Where(
                Function(req) req.SupplierID = currentSupplier.UserId AndAlso req.Status = "Pending").ToList()

            For Each req In pendingReqs
                Dim uc As New SupplyRequestUserControl()
                uc.Bind(req)
                AddHandler uc.SelfClicked, Sub() ShowRequestDetails(req)
                _view.PendingReqsFlowLayout.Controls.Add(uc)
            Next

            _mediator.NotifyRequestStatusChanged()
            _view.PendingReqsFlowLayout.Refresh()
        End Sub

        Private Sub OnDeclineClicked(request As SupplyRequest)
            request.Status = "Declined"
            _mediator.GetUnitOfWork().SaveChanges()
            MessageBox.Show("Request declined successfully!")
            _view.ShowPendingList()

            ' Refresh the list completely like in OnAcceptClicked
            _view.PendingReqsFlowLayout.Controls.Clear()
            Dim currentSupplier = _mediator.GetCurrentUser
            Dim freshRequestList = _mediator.GetUnitOfWork().SupplyRequests.GetAll().ToList()

            Dim pendingReqs = freshRequestList.Where(
        Function(req) req.SupplierID = currentSupplier.UserId AndAlso req.Status = "Pending").ToList()

            For Each req In pendingReqs
                Dim uc As New SupplyRequestUserControl()
                uc.Bind(req)
                AddHandler uc.SelfClicked, Sub() ShowRequestDetails(req)
                _view.PendingReqsFlowLayout.Controls.Add(uc)
            Next
            _mediator.NotifyRequestStatusChanged()
            _view.PendingReqsFlowLayout.Refresh()
        End Sub

        Private Sub AddInventoryBatchForRequest(request As SupplyRequest)
            Dim supplierItems = _mediator.GetUnitOfWork.SupplierItems.GetAll().Where(Function(i) i.SupplierId = request.SupplierID).ToList()
            Dim item = supplierItems.FirstOrDefault(Function(s) s.Name = request.ProductName)


            If item Is Nothing Then
                item = New SupplierItem With {
                    .Id = Guid.NewGuid().ToString(),
                    .SupplierId = request.SupplierID,
                    .Name = request.ProductName,
                    .Description = "",
                    .Batches = New List(Of InventoryBatch)()
                }
                _mediator.GetUnitOfWork.SupplierItems.Add(item)
            End If

            Dim batchId As String = "BATCH_" & Guid.NewGuid().ToString().Substring(0, 8)
            Dim batchNumber As String = $"B-{item.Name.Substring(0, 3)}-{DateTime.Now.Year}"

            Dim newBatch As New InventoryBatch With {
                 .BatchId = batchId,
                .SupplierId = request.SupplierID,
                .SupplierItemId = item.Id,
                .QuantityReceived = request.Quantity,
                .RemainingQuantity = request.Quantity,
                .UnitCost = request.UnitCost,
                .ReceivedDate = DateTime.Now,
                .BatchNumber = batchNumber,
                .IsActive = True,
                .IsDeprecated = False,
                .DeprecationReason = Nothing,
                .DeprecatedDate = Nothing
                }
            _mediator.GetUnitOfWork.InventoryBatches.Add(newBatch)

        End Sub



    End Class
End Namespace

'                .ExpiryDate = If(request.ExpiryDate.HasValue, request.ExpiryDate, Nothing),