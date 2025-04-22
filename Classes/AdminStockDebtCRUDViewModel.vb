Imports KioskV0.KioskV0
Imports KioskV0.KioskV0.Classes

Public Class AdminStockDebtCRUDViewModel
    Inherits ViewModel(Of AdminStockDebtCRUDView, KioskV0.AdminKeys)
    Private Property Loaded As Boolean = False
    Public Sub New(view As AdminStockDebtCRUDView, mediator As Mediator(Of AdminKeys))
        MyBase.New(view, mediator)
    End Sub
    Public Overrides Sub Project(projector As Form)
        If Not Loaded Then
            MyBase.Project(projector)
            ResizeComponents(_mediator.GetProjectorPanelSize())
        End If

        Loaded = True
        MyBase.Project(projector)
    End Sub
    Protected Friend Overrides Sub SetEvents()
        MyBase.SetEvents()


    End Sub

    Public Sub LoadAsCreate(itb As ItemToBatchDeduction)
        _view.ItemIDField.Text = itb.BaseItemId
        _view.ItemNameField.Text = itb.BaseItem.Name
        _view.UnitField.Text = itb.AmountDeducted

        _view.ConfirmButtonCick = Sub() Deduct(itb)
        _mediator.SwapPage(AdminKeys.AdminStockDebtCRUD)
    End Sub

    Private Sub Deduct(itb As ItemToBatchDeduction)
        If _view.ReasonTextBox.Text.Length = 0 Then
            MessageBox.Show("Reason cannot be Empty")
            Return
        End If

        If Not itb.IsValid Then
            MessageBox.Show("Item to Batch Deduction is not Valid")
            Return
        End If
        'Create StockDebt
        Dim sd As New StockDebt With {
            .SD_Id = "SD_ID_" & Guid.NewGuid().ToString().Substring(0, 5),
            .ItemId = itb.BaseItemId,
            .GeneratorID = _mediator.GetCurrentUser().UserId,
            .Reason = _view.ReasonTextBox.Text,
            .DateGenerated = DateTime.Now(),
            .Status = "Unresolved",
            .Units = itb.AmountDeducted,
            .IsResolved = False,
            .VersionId = itb.VersionId
        }
        Dim context = DirectCast(_mediator.GetUnitOfWork, UnitOfWork)._context

        Dim itb_cpy = context.Deductions.Local.FirstOrDefault(Function(s) s.ItB_Id = itb.ItB_Id AndAlso s.IsValid)
        If itb_cpy Is Nothing Then
            itb_cpy = context.Deductions.Find(itb.ItB_Id)
            If itb_cpy Is Nothing Then
                MessageBox.Show("ITB ID does not exist")
                Return
            End If
        End If
        itb_cpy.IsValid = False

        Dim batch_cpy = context.InventoryBatches.Local.FirstOrDefault(Function(s) s.BatchId = itb.BatchId)
        If batch_cpy Is Nothing Then
            batch_cpy = context.InventoryBatches.Find(itb.BatchId)
            If batch_cpy Is Nothing Then
                MessageBox.Show("Batch is nonexistent")
                Return
            End If
        End If

        'Re add quantity
        batch_cpy.RemainingQuantity += itb.AmountDeducted

        _mediator.GetUnitOfWork.InventoryBatches.Update(batch_cpy)
        _mediator.GetUnitOfWork.Deductions.Update(itb_cpy)
        _mediator.GetUnitOfWork.StockDebts.Add(sd)
        _mediator.GetUnitOfWork.SaveChanges()
        MessageBox.Show("Stock debt genreated!")

        _mediator.SwapPage(AdminKeys.AdminInventory)
        ResetField()
    End Sub

    Private Sub ResetField()
        _view.ItemIDField.Text = ""
        _view.ItemNameField.Text = ""
        _view.UnitField.Text = ""

        _view.ConfirmButtonCick = Sub()
                                      'Do nothing
                                  End Sub
    End Sub
End Class
