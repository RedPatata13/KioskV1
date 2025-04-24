Imports KioskV0.KioskV0.Forms
Imports System.Collections.Generic

Namespace KioskV0.Classes
    Public Class AdminSupplyRequestViewModel
        Inherits ViewModel(Of AdminSupplyRequestView, AdminKeys)

        Private Property Loaded As Boolean = False
        Public Sub New(view As AdminSupplyRequestView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)

            SetEvents()
        End Sub

        Public Overrides Sub Project(projector As Form)
            If Not Loaded Then
                MyBase.Project(projector)
                ResizeComponents(_mediator.GetProjectorPanelSize())
            End If
            MyBase.Project(projector)
        End Sub
        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            _view.IDText_Changed = AddressOf IDTextChanged
            _view.ConfirmButtonClick = AddressOf ConfirmActionClick
        End Sub

        Private Function GetInput(item As SupplierItem) As BatchRequest
            Dim units As Integer
            If Not Integer.TryParse(_view.Quantity, units) Then
                Throw New FormatException("Invalid format for Cost.")
            End If


            Dim model As New BatchRequest With {
                .RequestID = Guid.NewGuid().ToString().Substring(0, 8),
                .ItemID = item.Id,
                .RequesterID = _mediator.GetCurrentUser.UserId,
                .RecipientID = item.SupplierId,
                .RequestMSG = _view.Notes,
                .DateRequested = DateTime.Now,
                .Units = units,
                .IsPending = True
            }

            Return model
        End Function

        Private Sub ConfirmActionClick()
            Dim units As Integer
            If Not Integer.TryParse(_view.Quantity, units) Then
                MessageBox.Show("Please input a proper number field")
                Return
            End If

            Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context
            Dim item As SupplierItem = context.SupplierItems.Local.FirstOrDefault(Function(s) s.Id = _view.IDField)
            If item Is Nothing Then
                item = context.SupplierItems.Find(_view.IDField)
                If item Is Nothing Then
                    MessageBox.Show("Item not found")
                    Return
                End If
            End If
            Dim model = GetInput(item)

            _mediator.GetUnitOfWork.BatchRequests.Add(model)
            _mediator.GetUnitOfWork.SaveChanges()

            MessageBox.Show("Request created!")
            _mediator.SwapPage(AdminKeys.AdminInventory)
            ResetField()
        End Sub

        Private Sub IDTextChanged()
            If _view.IDField.Length > 0 Then
                Dim context = DirectCast(_mediator.GetUnitOfWork(), UnitOfWork)._context
                Dim item As SupplierItem = context.SupplierItems.Local.FirstOrDefault(Function(s) s.SupplierId = _view.IDField)
                If item Is Nothing Then
                    item = context.SupplierItems.Find(_view.IDField)
                    If item Is Nothing Then
                        _view.Product_Name = "Product not found"
                        Return
                    End If
                End If

                _view.Product_Name = item.Name
            End If
        End Sub

        Private Sub ResetField()
            _view.IDField = ""
            _view.ProductNameField.Text = ""
            _view.Notes = ""
            _view.Quantity = ""
        End Sub
    End Class
End Namespace
