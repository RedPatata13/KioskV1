Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Validation
Imports System.Data.SqlClient
Imports System.Web.Management
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class Mediator(Of TKey)
        Private Property _Login As LoginViewModel
        Private Property _Projector As Projector
        Private ReadOnly _unitOfWork As IUnitOfWork
        Private Property _actionManager As New ActionManager
        Private Property VMMap As Dictionary(Of TKey, IProjectable)
        Private VMMap_Instantiated As Boolean = False


        Public Sub New(projector As Projector, login As LoginViewModel, unitOfWork As IUnitOfWork)
            _Projector = projector
            _Login = login
            _unitOfWork = unitOfWork
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
        Public Sub UpdateMenu(id As String, model As Menu)
            _unitOfWork.Menus.Update(model)
        End Sub

        Public Sub CreateMenu(model As Menu)
            _unitOfWork.Menus.Add(model)
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


        Public Sub LayoutAction(action As Action)
            _Projector.LayoutAction(action)
        End Sub
    End Class
End Namespace
