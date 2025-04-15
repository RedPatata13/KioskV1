Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminMenuViewModel
        Inherits ViewModel(Of Forms.AdminMenuView, AdminKeys)
        Private Property Loaded As Boolean = False
        Private Property _ucCache As Dictionary(Of String, UserControl)
        Private Property _modelCache As Dictionary(Of String, AdminItem)
        Private Property _staged As AdminItem = Nothing
        Public Sub New(view As AdminMenuView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            SetEvents()
            InitializeCache()
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.AddMenuButtonClick = AddressOf AddMenuButtonClick
            _view.MenuSearch = Sub() LoadSelected(_view.SearchMenu.Text)
        End Sub

        Public Overrides Sub Project(projector As Form)
            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() MyBase.Project(projector))
                                       If Not Loaded Then
                                           _mediator.AddAction(Sub() MyBase.Project(projector)) 'I have to call this twice for the sizing
                                           _mediator.AddAction(Sub() ResizeComponents(_mediator.GetProjectorPanelSize()))
                                           _mediator.AddAction(Sub() LoadMenuItems())
                                       End If
                                       _mediator.InvokeAllAction()
                                   End Sub)
            Loaded = True
        End Sub
        Public Sub DeleteStaged()
            '_view.ItemPanel.Controls.Remove(_ucCache(_staged.MenuId))
            '_ucCache.Remove(_staged.MenuId)
            '_modelCache.Remove(_staged.MenuId)
            _staged = Nothing
        End Sub

        Public Sub UpdateStaged(model As AdminItem)
            Dim val = _ucCache(_staged.Id)
            Dim uc1 As AdminMenuUserControl = DirectCast(val, AdminMenuUserControl)
            uc1.Model = model
            '_staged.MenuName = model.MenuName
            _staged.Name = model.Name
            '_staged.SupplierItem = model.SupplierItem
            _staged.Description = model.Description
            _staged.SellingCost = model.SellingCost
            _staged.Category = model.Category
            _modelCache(_staged.Id) = model
            _ucCache(_staged.Id) = uc1
            uc1.SelfClick = Sub() PrepareEditMenu(uc1.Model)
        End Sub

        Public Sub AddNewMenu(model As AdminItem)
            Dim amuc = New AdminMenuUserControl(model)
            amuc.SelfClick = Sub() PrepareEditMenu(model)
            _ucCache.Add(model.Id, amuc)
            _modelCache.Add(model.Id, model)
            _view.ItemPanel.Controls.Add(amuc)
        End Sub
        Private Sub AddMenuButtonClick()
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)
            vm.Previous = AdminKeys.AdminMenu
            _mediator.SwapPage(AdminKeys.AdminEditMenuDetails)
        End Sub


        Private Sub InitializeCache()
            _ucCache = New Dictionary(Of String, UserControl)
            _modelCache = New Dictionary(Of String, AdminItem)
            Dim items = _mediator.GetItemList()
            For Each item As AdminItem In items
                Dim uc = New AdminMenuUserControl(item)
                uc.SelfClick = Sub() PrepareEditMenu(item)
                _ucCache.Add(item.Id, uc)
                _modelCache.Add(item.Id, item)
            Next
        End Sub

        Private Sub ReloadAllItems()
            For Each item In _ucCache
                _view.ItemPanel.Controls.Add(_ucCache(item.Key))
            Next
        End Sub
        Private Sub PrepareEditMenu(model As AdminItem)
            _staged = model
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)
            vm.Previous = AdminKeys.AdminMenu
            vm.LoadAsEdit(model)
        End Sub

        Private Sub LoadMenuItems()
            '_view.ItemPanel.Controls.Clear()
            ReloadAllItems()
        End Sub

        Private Sub LoadSelected(str As String)
            'MessageBox.Show($"{_ucCache.Count}")
            _view.ItemPanel.Controls.Clear()
            For Each item In _ucCache
                If _modelCache(item.Key).Name.ToLower().Contains(str.ToLower()) Then
                    _view.ItemPanel.Controls.Add(item.Value)
                End If
            Next
        End Sub
    End Class
End Namespace