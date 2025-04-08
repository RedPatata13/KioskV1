Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminMenuViewModel
        Inherits ViewModel(Of Forms.AdminMenuView, AdminKeys)

        Private Property Loaded As Boolean = False
        Private _menuCache As List(Of Menu)

        Public Sub New(view As AdminMenuView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            _menuCache = New List(Of Menu)()
            SetEvents()
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            _view.AddMenuButtonClick = AddressOf AddMenuButtonClick
        End Sub

        Public Overrides Sub Project(projector As Form)
            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() MyBase.Project(projector))
                                       If Not Loaded Then
                                           _mediator.AddAction(Sub() MyBase.Project(projector)) ' Required for sizing fix
                                           '_mediator.AddAction(Sub() ResizeComponents(_mediator.Get))
                                       End If
                                       _mediator.AddAction(Sub() LoadMenuItems())
                                       _mediator.InvokeAllAction()
                                   End Sub)
            Loaded = True
        End Sub

        Private Sub AddMenuButtonClick()
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)
            vm.Previous = AdminKeys.AdminMenu
            _mediator.SwapPage(AdminKeys.AdminEditMenuDetails)
        End Sub

        Private Sub PrepareEditMenu(model As Menu)
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)
            vm.Previous = AdminKeys.AdminMenu
            vm.LoadAsEdit(model)
        End Sub

        Private Sub LoadMenuItems()
            Dim newItems = _mediator.GetMenuList()

            ' Check if cache is empty (initial load)
            If _menuCache.Count = 0 Then
                _menuCache = newItems
                RefreshUI(newItems)
                Return
            End If

            ' Find changes (new, removed, or updated items)
            Dim updatedItems As New List(Of Menu)
            Dim newItemsToAdd As New List(Of Menu)
            Dim removedItems As New List(Of Menu)

            ' Identify new and updated items
            For Each item In newItems
                Dim existingItem = _menuCache.FirstOrDefault(Function(m) m.MenuId = item.MenuId)
                If existingItem Is Nothing Then
                    ' New item
                    newItemsToAdd.Add(item)
                ElseIf Not existingItem.Equals(item) Then
                    ' Modified item
                    updatedItems.Add(item)
                End If
            Next

            ' Identify removed items
            For Each cachedItem In _menuCache
                If Not newItems.Any(Function(m) m.MenuId = cachedItem.MenuId) Then
                    removedItems.Add(cachedItem)
                End If
            Next

            ' Apply changes
            UpdateUI(updatedItems)
            AddNewItemsToUI(newItemsToAdd)
            RemoveItemsFromUI(removedItems)

            ' Update cache
            _menuCache = newItems.ToList()
        End Sub

        Private Sub RefreshUI(items As List(Of Menu))
            _view.ItemPanel.Controls.Clear()
            For Each item In items
                Dim uc = New AdminMenuUserControl(item)
                uc.SelfClick = Sub() PrepareEditMenu(item)
                _view.ItemPanel.Controls.Add(uc)
            Next
        End Sub

        Private Sub UpdateUI(updatedItems As List(Of Menu))
            For Each item In updatedItems
                Dim matchingUC = _view.ItemPanel.Controls.OfType(Of AdminMenuUserControl)().
                FirstOrDefault(Function(ctrl) ctrl.Model.MenuId = item.MenuId)
                If matchingUC IsNot Nothing Then
                    matchingUC.Model = item
                End If
            Next
        End Sub


        Private Sub AddNewItemsToUI(newItems As List(Of Menu))
            For Each item In newItems
                Dim uc = New AdminMenuUserControl(item)
                uc.SelfClick = Sub() PrepareEditMenu(item)
                _view.ItemPanel.Controls.Add(uc)
            Next
        End Sub

        Private Sub RemoveItemsFromUI(removedItems As List(Of Menu))
            For Each item In removedItems
                Dim ucToRemove = _view.ItemPanel.Controls.OfType(Of AdminMenuUserControl)().
                        FirstOrDefault(Function(uc) uc.Model.MenuId = item.MenuId)
                If ucToRemove IsNot Nothing Then
                    _view.ItemPanel.Controls.Remove(ucToRemove)
                End If
            Next
        End Sub
    End Class
End Namespace
