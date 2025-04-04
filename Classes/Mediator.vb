

Namespace KioskV0.Classes
    Public Class Mediator(Of TKey)
        Private Property Login As LoginViewModel
        Private Property _Projector As Projector
        Private Property VMMap As Dictionary(Of TKey, IProjectable)
        Private VMMap_Instantiated As Boolean = False

        Public Sub New(projector As Projector, login As LoginViewModel)
            _Projector = projector
            Me.Login = login
        End Sub

        Public Sub SetupMap(map As Dictionary(Of TKey, IProjectable))
            If VMMap_Instantiated Then Throw New Exception($"{GetType(TKey).Name} Mediator Instantiated Twice")
            VMMap = map
            VMMap_Instantiated = True
        End Sub

        Public Sub SwapPage(pageKey As TKey)
            If VMMap.ContainsKey(pageKey) Then
                _Projector.Project(VMMap(pageKey))
            Else
                Throw New KeyNotFoundException($"Page {pageKey} not found in {GetType(TKey).Name} mediator.")
            End If
        End Sub
    End Class
End Namespace
