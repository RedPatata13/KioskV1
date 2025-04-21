Imports KioskV0.KioskV0.Forms
Imports System.Collections.Generic

Namespace KioskV0.Classes
    Public Class AdminSupplyRequestViewModel
        Inherits ViewModel(Of AdminSupplyRequestView, AdminKeys)

        Private _supplierCache As List(Of Supplier)
        Public Sub New(view As AdminSupplyRequestView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            InitializeSupplierCache()

            _view.ConfirmButtonClick = Sub() OnConfirmClicked()
        End Sub

        Private Sub InitializeSupplierCache()
            Dim suppliers As List(Of Supplier) = _mediator.GetUnitOfWork().Suppliers.GetAll()
            _supplierCache = suppliers
            UpdateSupplierComboBox()
        End Sub


        Private Sub UpdateSupplierComboBox()
            If _supplierCache IsNot Nothing Then
                _view.Suppliers = _supplierCache
            End If
        End Sub

        Private Sub OnConfirmClicked()
            Dim selectedSupplier As Supplier = TryCast(_view.SupplierField.SelectedItem, Supplier)

            If selectedSupplier Is Nothing Then
                MessageBox.Show("Please select a supplier.")
                Return
            End If

            Dim req As New SupplyRequest() With {
            .ID = "SI_" & Guid.NewGuid().ToString().Substring(0, 10),
            .SupplierID = selectedSupplier.UserId,
            .ProductName = _view.Product_Name,
            .Quantity = Integer.Parse(_view.Quantity),
            .UnitCost = _view.UnitCost,
            .Note = _view.Notes,
            .Status = "Pending",
            .CreatedAt = DateTime.Now
            }

            If _mediator.GetUnitOfWork() Is Nothing Then
                MessageBox.Show("UnitOfWork is NULL")
                Return
            End If

            If _mediator.GetUnitOfWork().SupplyRequests Is Nothing Then
                MessageBox.Show("SupplyRequests is NULL")
                Return
            End If

            _mediator.GetUnitOfWork().SupplyRequests.Add(req)
            _mediator.GetUnitOfWork().SaveChanges()
            MessageBox.Show("Request sent!")
            ResetFields()
            _mediator.SwapPage(AdminKeys.AdminInventory)
        End Sub

        Private Sub ResetFields()

            _view.SupplierField.SelectedIndex = -1
            _view.IDField = ""
            _view.Product_Name = ""
            _view.Quantity = ""
            _view.Supplier = ""
            _view.Notes = ""
        End Sub


    End Class

End Namespace
