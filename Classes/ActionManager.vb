Namespace KioskV0.Classes
    Public Class ActionManager
        Private ReadOnly _queue As New Queue(Of Action)
        Private ReadOnly _postQueue As New Queue(Of Action)
        Private ReadOnly _lock As New Object()

        Public Sub EnqueuePost(action As Action)
            SyncLock _lock
                _postQueue.Enqueue(action)
            End SyncLock
        End Sub
        Public Sub Enqueue(action As Action)
            SyncLock _lock
                _queue.Enqueue(action)
            End SyncLock
        End Sub

        Public Sub ProcessNext()
            Dim nextAction As Action = Nothing
            SyncLock _lock
                If _queue.Count > 0 Then
                    nextAction = _queue.Dequeue()
                End If
            End SyncLock

            nextAction?.Invoke()
        End Sub

        Private Sub ProcessNextPost()
            Dim nextAction As Action = Nothing
            SyncLock _lock
                If _queue.Count > 0 Then
                    nextAction = _queue.Dequeue()
                End If
            End SyncLock
        End Sub

        Public Sub ProcessAll()
            While _queue.Count > 0
                ProcessNext()
            End While

            ProcessAllPost()
        End Sub

        Private Sub ProcessAllPost()
            While _queue.Count > 0
                ProcessNextPost()
            End While
        End Sub
    End Class

End Namespace