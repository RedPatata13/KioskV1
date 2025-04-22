Imports KioskV0.KioskV0.Forms
Imports System.Collections.Generic
Imports System.Linq

Namespace KioskV0.Classes
    Public Class SupplierItemsViewModel
        Inherits ViewModel(Of SupplierItemsView, SupplierKeys)

        Private _currentSupplier As Supplier
        Private _allItems As List(Of SupplierItem)
        Private _ucCache As Dictionary(Of String, SupplierItemUserControl)
        Private _itemCache As Dictionary(Of String, SupplierItem)
        Public Sub New(view As SupplierItemsView, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)
            'LoadSupplierItems()
            SetEvents()
            InitializeCache()
        End Sub
        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            _view.MenuSearch = Sub() LoadSelected(_view.SearchMenu.Text)
        End Sub

        Private Sub EditSupplierItem(item As SupplierItem)

            Dim editVM = DirectCast(_mediator.GetVM(SupplierKeys.SupplierEditSupplierItem), SupplierEditSupplierItemViewModel)
            editVM.LoadAsEdit(item)
            _mediator.SwapPage(SupplierKeys.SupplierEditSupplierItem)
        End Sub

        Public Sub Refresh()
            InitializeCache()
        End Sub

        Private Sub InitializeCache()
            _ucCache = New Dictionary(Of String, SupplierItemUserControl)
            _itemCache = New Dictionary(Of String, SupplierItem)()

            _view.SupplierItemFlowLayout.Controls.Clear()

            Dim currentSupp = _mediator.GetCurrentUser()
            If currentSupp Is Nothing Then
                MessageBox.Show("Current supplier is null")
                Return
            End If

            Dim items = _mediator.GetSupplierItemList().
                        Where(Function(item) item.SupplierId = currentSupp.UserId).ToList()

            For Each item As SupplierItem In items
                Dim uc As New SupplierItemUserControl()
                uc.LoadDetails(item)
                AddHandler uc.EditClick, Sub() EditSupplierItem(item)

                _ucCache(item.Id) = uc
                _itemCache(item.Id) = item
                _view.SupplierItemFlowLayout.Controls.Add(uc)
            Next
        End Sub

        Private Sub LoadSelected(str As String)
            _view.SupplierItemFlowLayout.Controls.Clear()
            Dim searchText = str.ToLower()

            For Each item In _itemCache.Values
                If item.Id.ToLower().Contains(searchText) OrElse item.Name.ToLower().Contains(searchText) Then
                    _view.SupplierItemFlowLayout.Controls.Add(_ucCache(item.Id))
                End If
            Next
        End Sub

    End Class
End Namespace