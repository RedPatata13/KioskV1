Imports System.ComponentModel

Namespace KioskV0.Forms
    Public Class AdminStaffTransactionsView
        Public Property CellClick As Action
        Public Property SearchInput As Action
        Private _dgvSource As BindingSource
        Private _staffs As List(Of User)
        Public Property StaffNameCBChanged As Action
        Public Property Staffs() As List(Of User)
            Get
                Return _staffs
            End Get
            Set(ByVal value As List(Of User))
                _staffs = value
                UpdateSupplierComboBox() ' Automatically update the ComboBox when suppliers change
            End Set
        End Property

        Public Property DGV_Source As BindingSource
            Get
                Return _dgvSource
            End Get
            Set(value As BindingSource)
                _dgvSource = value
                StaffTransacDataGrid.DataSource = _dgvSource
            End Set
        End Property

        Private Sub StaffTransacDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffTransacDataGrid.CellClick
            CellClick?.Invoke()
        End Sub

        Private Sub UpdateSupplierComboBox()
            StaffNameComboBox.Items.Clear()
            StaffNameComboBox.Items.Add("All")
            StaffNameComboBox.SelectedIndex = 0
            If _staffs IsNot Nothing AndAlso _staffs.Count > 0 Then
                For Each staff As User In _staffs
                    If staff.Role = "Staff" Or staff.Role = "1" Then
                        StaffNameComboBox.Items.Add(staff.Username)
                    End If
                Next
            End If
        End Sub

        Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StaffNameComboBox.SelectedIndexChanged
            StaffNameCBChanged?.Invoke()
        End Sub

        Private Sub SearchItem_TextChanged(sender As Object, e As EventArgs) Handles SearchItem.TextChanged
            SearchInput?.Invoke()
        End Sub
    End Class
End Namespace
