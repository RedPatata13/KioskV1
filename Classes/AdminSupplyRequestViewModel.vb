Imports KioskV0.KioskV0.Forms
Imports System.Collections.Generic

Namespace KioskV0.Classes
    Public Class AdminSupplyRequestViewModel
        Inherits ViewModel(Of AdminSupplyRequestView, AdminKeys)

        Private _supplierCache As List(Of Supplier)
        Public Sub New(view As AdminSupplyRequestView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            InitializeSupplierCache()
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

    End Class
End Namespace
