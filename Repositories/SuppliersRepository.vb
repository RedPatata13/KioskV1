Public Class SuppliersRepository
    Implements IBaseRepository(Of Supplier)

    Public Sub Add(entity As Supplier) Implements IBaseRepository(Of Supplier).Add
        Throw New NotImplementedException()
    End Sub

    Public Sub Update(entity As Supplier) Implements IBaseRepository(Of Supplier).Update
        Throw New NotImplementedException()
    End Sub

    Public Sub Delete(id As Integer) Implements IBaseRepository(Of Supplier).Delete
        Throw New NotImplementedException()
    End Sub

    Public Function GetAll() As IEnumerable(Of Supplier) Implements IBaseRepository(Of Supplier).GetAll
        Throw New NotImplementedException()
    End Function

    Public Function GetById(id As Integer) As Supplier Implements IBaseRepository(Of Supplier).GetById
        Throw New NotImplementedException()
    End Function
End Class
