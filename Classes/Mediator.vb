Imports System.Web.Management
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class Mediator(Of TKey)
        Private Property _Login As LoginViewModel
        Private Property _Projector As Projector
        Private Property _tempDB As TempDB
        Private Property _actionManager As New ActionManager
        Private Property VMMap As Dictionary(Of TKey, IProjectable)
        Private VMMap_Instantiated As Boolean = False


        Public Sub New(projector As Projector, login As LoginViewModel, tempDB As TempDB)
            _Projector = projector
            _Login = login
            _tempDB = tempDB
        End Sub

        Public Sub AddAction(action As Action)
            _actionManager.Enqueue(action)
        End Sub

        Public Sub AddPostAction(action As Action)
            _actionManager.EnqueuePost(action)
        End Sub
        Public Sub InvokeNext()
            _actionManager.ProcessNext()
        End Sub
        Public Sub InvokeAllAction()
            _actionManager.ProcessAll()
        End Sub

        Public Sub SetupMap(map As Dictionary(Of TKey, IProjectable))
            If VMMap_Instantiated Then Throw New Exception($"{GetType(TKey).Name} Mediator Instantiated Twice")
            VMMap = map
            VMMap_Instantiated = True
        End Sub
        Public Sub UpdateMenu(id As String, model As Model.MenuModel)
            _tempDB.UpdateMenu(id, model)
        End Sub

        Public Sub CreateMenu(model As MenuModel)
            _tempDB.AddMenu(model)
        End Sub
        Public Sub SwapPage(pageKey As TKey)
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

        Public Function GetUserList() As List(Of UserModel)
            Return _tempDB.GetUserList()
        End Function


        Public Sub LayoutAction(action As Action)
            _Projector.LayoutAction(action)
        End Sub

        Public Function GetMenuList()
            Return _tempDB.GetMenuList()
        End Function

        Public Function GetItemList()
            Return _tempDB.GetItemList()
        End Function

        Public Function GetOrderList()
            Return _tempDB.GetOrderList()
        End Function

        Public Sub DeleteMenu(model As MenuModel)
            _tempDB.DeleteMenu(model)
        End Sub

        Public Function GetProjectorPanelSize() As Size
            Return _Projector.GetWindowSize()
        End Function

        Public Function GetSidebarSize() As Size
            Return _Projector.GetSidebarSize()
        End Function
    End Class
End Namespace
