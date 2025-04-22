Public Interface IItemDeductionRepository
    Inherits IBaseRepository(Of ItemToBatchDeduction)

    Function GetDeductor(id As String, batch_id As String) As ItemToBatchDeduction
    Function GetDeductorOfItem(item_id As String, batch_id As String) As IEnumerable(Of ItemToBatchDeduction)
    Function GetDeductorOfBatch(batch_id As String) As IEnumerable(Of ItemToBatchDeduction)
End Interface
