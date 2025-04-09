Imports KioskV0.KioskV0.Forms
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminMenuViewModel
        Inherits ViewModel(Of Forms.AdminMenuView, AdminKeys)
        Private Property Loaded As Boolean = False
        Private Property _ucCache As Dictionary(Of String, UserControl)
        Private Property _modelCache As Dictionary(Of String, Menu)
        Private Property _staged As Menu = Nothing
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
            _view.ItemPanel.Controls.Remove(_ucCache(_staged.MenuId))
            _ucCache.Remove(_staged.MenuId)
            _modelCache.Remove(_staged.MenuId)
            _staged = Nothing
        End Sub

        Public Sub UpdateStaged(model As Menu)
            Dim val = _ucCache(_staged.MenuId)
            Dim uc1 As AdminMenuUserControl = DirectCast(val, AdminMenuUserControl)
            uc1.Model = model
            _staged.MenuName = model.MenuName
            _staged.Supplier = _staged.Supplier
            _staged.ProductDescription = model.ProductDescription
            _staged.Cost = model.Cost
            _staged.Category = model.Category
            _modelCache(_staged.MenuId) = model
            _ucCache(_staged.MenuId) = uc1
            uc1.SelfClick = Sub() PrepareEditMenu(uc1.Model)
        End Sub

        Public Sub AddNewMenu(Model As Menu)
            Dim amuc = New AdminMenuUserControl(Model)
            amuc.SelfClick = Sub() PrepareEditMenu(Model)
            _ucCache.Add(Model.MenuId, amuc)
            _modelCache.Add(Model.MenuId, Model)
            _view.ItemPanel.Controls.Add(amuc)
        End Sub
        Private Sub AddMenuButtonClick()
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)
            vm.Previous = AdminKeys.AdminMenu
            _mediator.SwapPage(AdminKeys.AdminEditMenuDetails)
        End Sub


        Private Sub InitializeCache()
            _ucCache = New Dictionary(Of String, UserControl)
            _modelCache = New Dictionary(Of String, Menu)
            Dim items = _mediator.GetMenuList()
            For Each item In items
                Dim uc = New AdminMenuUserControl(item)
                uc.SelfClick = Sub() PrepareEditMenu(item)
                _ucCache.Add(item.MenuId, uc)
                _modelCache.Add(item.MenuId, item)
            Next
        End Sub

        Private Sub ReloadAllItems()
            'MessageBox.Show($"{_ucCache.Count}")
            '_view.ItemPanel.Controls.Clear()
            For Each item In _ucCache
                _view.ItemPanel.Controls.Add(_ucCache(item.Key))
            Next
        End Sub

        Private Sub MenuUserControlClick()

        End Sub
        Private Sub PrepareEditMenu(model As Menu)
            _staged = model
            Dim vm = DirectCast(_mediator.GetVM(AdminKeys.AdminEditMenuDetails), AdminEditMenuDetailsViewModel)
            vm.Previous = AdminKeys.AdminMenu
            vm.LoadAsEdit(model)
        End Sub

        Private Sub LoadMenuItems()
            _view.ItemPanel.Controls.Clear()
            ReloadAllItems()
        End Sub

        Private Sub LoadSelected(str As String)
            'MessageBox.Show($"{_ucCache.Count}")
            _view.ItemPanel.Controls.Clear()
            For Each item In _ucCache
                If _modelCache(item.Key).MenuName.ToLower().StartsWith(str.ToLower()) Then
                    _view.ItemPanel.Controls.Add(item.Value)
                End If
            Next
        End Sub
    End Class
End Namespace