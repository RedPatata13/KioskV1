Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes
Public Class AdminResolveStockDebtViewModel
    Inherits ViewModel(Of AdminResolveStockDebtView, KioskV0.AdminKeys)

    Public Sub New(view As AdminResolveStockDebtView, mediator As Mediator(Of AdminKeys))
        MyBase.New(view, mediator)

        SetEvents()
    End Sub

    Public Sub LoadAsEdit(sd As StockDebt)
        _view.ItemNameField.Text = sd.Item.Name
        _view.ItemIDField.Text = sd.ItemId
        _view.UnitField.Text = $"{sd.Units}"

        _mediator.SwapPage(AdminKeys.AdminResolveStockDebt)

        _view.ConfirmButtonClick = Sub()
                                       Resolve(sd)
                                   End Sub
    End Sub


    Protected Friend Overrides Sub SetEvents()
        MyBase.SetEvents()

        _view.CancelButtonClick = Sub() _mediator.SwapPage(AdminKeys.AdminStockDebt)
    End Sub

    Private Sub Resolve(sd As StockDebt)
        Dim id = _view.BatchIdField.Text
        If id.Length = 0 Then
            MessageBox.Show("Id cannot be empty")
            Return
        End If


        Dim context = DirectCast(_mediator.GetUnitOfWork, UnitOfWork)._context

        Dim batch_cpy = context.InventoryBatches.Local.FirstOrDefault(Function(b) b.BatchId = id)
        If batch_cpy Is Nothing Then
            batch_cpy = context.InventoryBatches.Find(id)
            If batch_cpy Is Nothing Then
                MessageBox.Show("No batch corresponding with the submitted ID")
                Return
            End If
        End If
        If batch_cpy.RemainingQuantity < sd.Units Then
            MessageBox.Show("Submitted Batch has less remaining quantity than the debt units")
            Return
        End If
        Dim ai_cpy = context.AdminItems.Local.FirstOrDefault(Function(a) a.Id = _view.ItemIDField.Text)
        If ai_cpy Is Nothing Then
            ai_cpy = context.AdminItems.Find(_view.ItemIDField.Text)
            If ai_cpy Is Nothing Then
                MessageBox.Show($"StockDebtID: {sd.SD_Id} can't be found.")
                Return
            End If
        End If

        Dim sd_cpy = context.StockDebts.Local.FirstOrDefault(Function(s) s.SD_Id = sd.SD_Id)
        If sd_cpy Is Nothing Then
            sd_cpy = context.StockDebts.Find(sd.SD_Id)
            If sd_cpy Is Nothing Then
                MessageBox.Show($"StockDebtID: {sd.SD_Id} can't be found.")
                Return
            End If
        End If

        'Dim version = context.StockDebts.Local.FirstOrDefault(Function(s) s.ItemId = ai_cpy.Id AndAlso )

        sd_cpy.IsResolved = True
        ai_cpy.BatchId = batch_cpy.BatchId
        batch_cpy.RemainingQuantity -= sd.Units


        Dim deduction As New ItemToBatchDeduction With {
            .ItB_Id = "DDCT_" & Guid.NewGuid().ToString().Substring(0, 8),
            .BatchId = batch_cpy.BatchId,
            .CausedBy = $"Resolving stock change for item with Id: [{ai_cpy.Id}]'",
            .BaseItemId = ai_cpy.Id,
            .OrderId = "0000-0000",
            .IsValid = True,
            .AmountDeducted = sd.Units,
            .VersionId = sd.VersionId
        }

        _mediator.GetUnitOfWork.Deductions.Add(deduction)
        _mediator.GetUnitOfWork.StockDebts.Update(sd_cpy)
        _mediator.GetUnitOfWork.AdminItems.Update(ai_cpy)
        _mediator.GetUnitOfWork.InventoryBatches.Update(batch_cpy)
        _mediator.GetUnitOfWork.SaveChanges()
        MessageBox.Show("Stock Debt resolved!")
        _mediator.SwapPage(AdminKeys.AdminStockDebt)
    End Sub
End Class
