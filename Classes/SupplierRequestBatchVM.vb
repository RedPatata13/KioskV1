Imports System.Windows.Forms.VisualStyles
Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class SupplierRequestBatchVM
    Inherits Classes.ViewModel(Of SupplierRequestDetailsView, SupplierKeys)
    Private Property Loaded As Boolean = False
    Private Property QTY As Integer = 0
    Private Property CurrentItem As SupplierItem = Nothing
    Private Property CurrentBatchReq As BatchRequest = Nothing
    Public Sub New(view As SupplierRequestDetailsView, mediator As Mediator(Of SupplierKeys))
        MyBase.New(view, mediator)


        SetEvents()
    End Sub
    Protected Friend Overrides Sub SetEvents()
        MyBase.SetEvents()

        '_view.CopyAdminIDClick = Sub(
        _view.CopyAdminIDClick = AddressOf CopyAdminClick
        _view.CopyItemIDClick = AddressOf CopyItemIDClick
        _view.ConfirmButtonClick = AddressOf ConfirmButtonClick
        _view.CancelButtonClick = AddressOf CancelButtonClick
        _view.RejectClick = AddressOf RejectClick
    End Sub

    Public Overrides Sub Project(projector As Form)
        If Not Loaded Then
            MyBase.Project(projector)
            ResizeComponents(_mediator.GetProjectorPanelSize())
            Loaded = True
        End If
        MyBase.Project(projector)
    End Sub
    Public Sub LoadAsEdit(request As BatchRequest)
        Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context

        Dim item = context.SupplierItems.Local.FirstOrDefault(Function(s) s.Id = request.ItemID)
        If item Is Nothing Then
            item = context.SupplierItems.Find(request.ItemID)
            If item Is Nothing Then
                Throw New Exception($"item with ID: {request.ItemID}")
            End If
        End If

        Dim admin = context.Users.Local.FirstOrDefault(Function(s) s.UserId = request.RequesterID AndAlso s.Role = "Supplier")
        If admin Is Nothing Then
            admin = context.Users.Find(request.RequesterID)
            If admin Is Nothing Then
                Throw New Exception($"User with ID: {admin.UserId}")
            End If
        End If
        '_view.ItemIDField.Enabled = True


        _view.ItemIDField.Text = item.Id
        _view.ItemNameField.Text = item.Name
        _view.DescriptionField.Text = item.Description
        _view.UnitCostField.Text = item.UnitCost

        _view.AdminNameField.Text = admin.Username
        _view.AdminID_field.Text = admin.UserId
        _view.QTY_Field.Text = request.Units
        _view.DateReq.Text = request.DateRequested.Date.ToString()

        QTY = request.Units
        CurrentItem = item
        CurrentBatchReq = request
        _mediator.SwapPage(SupplierKeys.SupplierAssessRequest)
        'ResetField()
    End Sub

    Private Sub ResetField()
        _view.ItemIDField.Text = ""
        _view.ItemIDField.Text = ""
        _view.DescriptionField.Text = ""
        _view.UnitCostField.Text = ""

        _view.AdminNameField.Text = ""
        _view.AdminID_field.Text = ""
        _view.QTY_Field.Text = ""
        _view.DateReq.Text = ""
        QTY = 0
        CurrentItem = Nothing
    End Sub

    Private Sub CopyAdminClick()
        Clipboard.SetText(_view.AdminID_field.Text)
        MessageBox.Show("Admin ID Copied!")
    End Sub

    Private Sub CopyItemIDClick()
        Clipboard.SetText(_view.ItemIDField.Text)
        MessageBox.Show("Item ID Copied!")
    End Sub

    Private Sub CancelButtonClick()
        _mediator.SwapPage(SupplierKeys.SupplierAdminBatchReq)
        ResetField()
    End Sub

    Private Sub ConfirmButtonClick()
        Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context
        Dim batch_req As InventoryBatch = Nothing
        If _view.BatchName_field.Text.Length > 0 Then
            batch_req = New InventoryBatch With {
            .BatchId = "BATCH_" & Guid.NewGuid().ToString().Substring(0, 8),
            .SupplierId = _mediator.GetCurrentUser.UserId,
            .SupplierItemId = _view.ItemIDField.Text,
            .RemainingQuantity = QTY,
            .QuantityReceived = QTY,
            .BatchName = _view.BatchName_field.Text,
            .IsActive = True,
            .IsDeprecated = False,
            .UnitCost = 0.0,
            .ReceivedDate = DateTime.Now
        }
        Else
            MessageBox.Show("Batch Name cannot be empty")
            Return
        End If

        Dim item = context.BatchRequests.Local.FirstOrDefault(Function(br) br.RequestID = CurrentBatchReq.RequestID AndAlso br.IsPending)
        If item Is Nothing Then
            item = context.BatchRequests.Find(CurrentBatchReq.RequestID)
            If item Is Nothing Then
                Throw New Exception($"item with ID: {CurrentBatchReq.RequestID}")
            End If
        End If

        item.IsPending = False
        item.FinalResult = "Accepted"

        _mediator.GetUnitOfWork.BatchRequests.Update(item)
        _mediator.GetUnitOfWork.InventoryBatches.Add(batch_req)
        _mediator.GetUnitOfWork.SaveChanges()
        MessageBox.Show("Batch request accepted")
        _mediator.SwapPage(SupplierKeys.SupplierAdminBatchReq)
    End Sub

    Private Sub RejectClick()
        Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context

        Dim item = context.BatchRequests.Local.FirstOrDefault(Function(br) br.RequestID = CurrentBatchReq.RequestID AndAlso br.IsPending)
        If item Is Nothing Then
            item = context.BatchRequests.Find(CurrentBatchReq.RequestID)
            If item Is Nothing Then
                Throw New Exception($"item with ID: {CurrentBatchReq.RequestID}")
            End If
        End If

        item.IsPending = False
        item.FinalResult = "Accepted"

        _mediator.GetUnitOfWork.BatchRequests.Update(item)
        _mediator.GetUnitOfWork.SaveChanges()
        MessageBox.Show("Batch request rejected")
        _mediator.SwapPage(SupplierKeys.SupplierAdminBatchReq)

    End Sub
End Class
