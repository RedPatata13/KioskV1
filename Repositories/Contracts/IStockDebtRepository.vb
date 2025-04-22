Public Interface IStockDebtRepository
    Inherits IBaseRepository(Of StockDebt)

    Function GetAllUnresolved() As IEnumerable(Of StockDebt)
    Function GetAllResolved() As IEnumerable(Of StockDebt)
End Interface
