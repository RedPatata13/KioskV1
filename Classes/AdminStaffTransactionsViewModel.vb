Imports System.ComponentModel
Imports KioskV0.KioskV0.Forms

Namespace KioskV0.Classes
    Public Class AdminStaffTransactionsViewModel
        Inherits ViewModel(Of Forms.AdminStaffTransactionsView, AdminKeys)
        Private Property Loaded As Boolean = False
        Public Sub New(view As AdminStaffTransactionsView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            LoadAccounts()
            SetEvents()
            _ordercache = _mediator.GetOrderList()
        End Sub
        Private Property _ordercache As List(Of Order)
        Private Property _staffCache As List(Of User)
        Public Property Staffs As List(Of User)
            Get
                Return _staffCache
            End Get
            Set(ByVal value As List(Of User))
                _staffCache = value
                UpdateSupplierComboBox() ' Automatically update the ComboBox when suppliers change
            End Set
        End Property

        Private Sub UpdateSupplierComboBox()
            If _staffCache IsNot Nothing Then
                _view.Staffs = _staffCache
            End If
        End Sub
        Protected Friend Overrides Sub SetEvents()
            _view.StaffNameCBChanged = AddressOf UpdateDGV
            _view.SearchInput = AddressOf Search
        End Sub
        Public Overrides Sub Project(projector As Form)
            If Not Loaded Then
                MyBase.Project(projector)
                Staffs = _mediator.GetUserList()
                ResizeComponents(_mediator.GetProjectorPanelSize())
            End If
            MyBase.Project(projector)
            _mediator.LayoutAction(Sub() LoadAccounts())
        End Sub
        Public Sub LoadAccounts()
            Dim dgv = _view.StaffTransacDataGrid
            dgv.DataSource = Nothing
            dgv.Columns.Clear()
            dgv.AutoGenerateColumns = True
            dgv.ReadOnly = True
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.ColumnHeadersHeight = 40
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            _view.DGV_Source = New BindingSource With {.DataSource = _mediator.GetOrderList()}
        End Sub

        Private Sub UpdateDGV()
            Dim selectedValue As String = _view.StaffNameComboBox.SelectedItem.ToString()
            Dim all = _ordercache
            If selectedValue = "All" Then
                _view.DGV_Source = New BindingSource With {.DataSource = all}
                Return
            End If

            Dim list As New List(Of Order)
            For Each order In all
                If order.User.UserName.Contains(selectedValue) Then
                    list.Add(order)
                End If
            Next
            _view.DGV_Source = New BindingSource With {.DataSource = list}

        End Sub
        Private Sub Search()
            Dim input = _view.SearchItem.Text
            Dim all = _ordercache

            If String.IsNullOrWhiteSpace(input) Then
                _view.DGV_Source = New BindingSource With {.DataSource = all}
            Else
                Dim list As New List(Of Order)
                For Each order In all
                    If order.User.Username.StartsWith(input) Then
                        list.Add(order)
                    End If
                Next
                _view.DGV_Source = New BindingSource With {.DataSource = list}
            End If
        End Sub

    End Class

End Namespace