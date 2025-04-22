Imports System.Data.Entity

Public Class ItemDeductionRepository
    Inherits BaseRepository(Of ItemToBatchDeduction)
    Implements IItemDeductionRepository

    Public Sub New(context As KioskDbContext)
        MyBase.New(context)
    End Sub

    Public Function GetDeductor(version_id As String, batch_id As String) As ItemToBatchDeduction Implements IItemDeductionRepository.GetDeductor
        ' First check local context (change tracker)
        Dim localResult = _dbSet.Local.FirstOrDefault(Function(i) i.VersionId = version_id AndAlso i.BatchId = batch_id)
        If localResult IsNot Nothing Then
            Return localResult
        End If

        ' If not found locally, query the database
        Return _dbSet.FirstOrDefault(Function(i) i.VersionId = version_id AndAlso i.BatchId = batch_id)
    End Function

    Public Function GetDeductorOfItem(item_id As String, batch_id As String) As IEnumerable(Of ItemToBatchDeduction) Implements IItemDeductionRepository.GetDeductorOfItem
        ' Query with eager loading of related entities
        Return _dbSet.Include(Function(i) i.BaseItem) _
        .Include(Function(i) i.Batch) _
        .Include(Function(i) i.Version) _
        .Where(Function(i) i.BaseItemId = item_id AndAlso i.BatchId = batch_id) _
        .ToList()
    End Function

    Public Function GetDeductorOfBatch(batch_id As String) As IEnumerable(Of ItemToBatchDeduction) Implements IItemDeductionRepository.GetDeductorOfBatch
        Return _dbSet.Include(Function(i) i.BaseItem) _
            .Include(Function(i) i.Batch) _
            .Include(Function(i) i.Version) _
            .Where(Function(i) i.BatchId = batch_id AndAlso i.IsValid) _
            .ToList()
    End Function
End Class
