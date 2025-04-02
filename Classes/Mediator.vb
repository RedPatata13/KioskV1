Namespace KioskV0.Classes
    Public Class Mediator(Of TKey)
        Private Property _Login As LoginViewModel
        Private Property _Projector As Projector
        Private Property _tempDB As TempDB
        Private Property VMMap As Dictionary(Of TKey, IProjectable)
        Private VMMap_Instantiated As Boolean = False


        Public Sub New(projector As Projector, login As LoginViewModel, tempDB As TempDB)
            _Projector = projector
            _Login = login
            _tempDB = tempDB
        End Sub

        Public Sub SetupMap(map As Dictionary(Of TKey, IProjectable))
            If VMMap_Instantiated Then Throw New Exception($"{GetType(TKey).Name} Mediator Instantiated Twice")
            VMMap = map
            VMMap_Instantiated = True
        End Sub

        Public Sub SwapPage(pageKey As TKey)
            'If VMMap.ContainsKey(pageKey) Then
            '    _Projector.Project(VMMap(pageKey))
            'Else
            '    Throw New KeyNotFoundException($"Page {pageKey} not found in {GetType(TKey).Name} mediator.")
            'End If
            VerifyKey(pageKey)
            _Projector.Project(VMMap(pageKey))
        End Sub

        Public Function GetVM(pageKey As TKey) As IProjectable
            VerifyKey(pageKey)
            Return VMMap(pageKey)
        End Function

        Public Sub VerifyKey(pageKey As TKey)
            If VMMap.ContainsKey(pageKey) Then
                Return
            End If

            Throw New KeyNotFoundException($"Page {pageKey} not found in {GetType(TKey).Name} mediator.")
        End Sub

        Public Sub LayoutAction(action As Action)
            _Projector.LayoutAction(action)
        End Sub

        Public Function GetMenuList()
            Return _tempDB.GetMenuList()
        End Function
    End Class
End Namespace
