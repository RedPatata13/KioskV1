Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports KioskV0.KioskV0.Classes
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminEditMenuDetailsViewModel
        Inherits ViewModel(Of Forms.AdminEditMenuDetailsView, AdminKeys)

        Public Sub New(view As Forms.AdminEditMenuDetailsView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            SetEvents()
        End Sub
        Public Sub LoadAsEdit(model As MenuModel)
            model.Validate()
            _view.Label = "Edit Menu"
            _view.DeleteButton.Visible = True
            _mediator.LayoutAction(Sub()
                                       _mediator.AddAction(Sub() LoadWithDetails(model))
                                       _mediator.AddAction(Sub() _mediator.SwapPage(AdminKeys.AdminEditMenuDetails))
                                       _mediator.InvokeAllAction()
                                   End Sub)
            _view.DeleteButtonClick = Sub() DeleteMenu(model)
            _view.SaveButtonClick = Sub() UpdateMenu(model)
        End Sub
        Private Sub RestoreView()
            _view.ResetFields()
            _view.DeleteButton.Visible = False
            _view.Label = "Add Menu"
            _view.SaveButtonClick = AddressOf SaveButtonClick
        End Sub
        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            Previous = AdminKeys.AdminLandingPage
            _view.CancelButtonClick = AddressOf CancelButtonClick
            _view.SelectImageClick = AddressOf SelectImageClick
            _view.SaveButtonClick = AddressOf SaveButtonClick
        End Sub
        Private Sub DeleteMenu(model As MenuModel)
            '_mediator.DeleteMenu(model)
            _mediator.AddAction(Sub() _mediator.SwapPage(Previous))
            _mediator.AddAction(Sub() _mediator.DeleteMenu(model))
            _mediator.AddAction(Sub() RestoreView())
            '_mediator.AddAction(Sub() MessageBox.Show("Menu Deleted"))
            _mediator.InvokeAllAction()
        End Sub
        Private Sub CancelButtonClick()
            _mediator.AddAction(Sub() _mediator.SwapPage(Previous))
            _mediator.AddAction(Sub() RestoreView())
            _mediator.InvokeAllAction()
        End Sub

        Private Sub SelectImageClick()
            MessageBox.Show("Works")
        End Sub

        Private Sub SaveButtonClick()
            Try
                Dim model = New MenuModel()
                model.MenuName = _view.MenuName
                model.Category = _view.CategoryName
                model.Supplier = _view.SupplierName
                model.ProductDescription = _view.ProductDescription
                Dim cost As Decimal
                Dim selling As Decimal

                If Not Decimal.TryParse(_view.Cost, cost) Then
                    Throw New FormatException("Invalid format for Cost.")
                End If
                If Not Decimal.TryParse(_view.Sell, selling) Then
                    Throw New FormatException("Invalid format for Selling price.")
                End If

                model.Cost = cost
                model.Selling = selling

                model.Validate()
                _mediator.CreateMenu(model)
                _mediator.SwapPage(Previous)
                RestoreView()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Sub
        Private Sub UpdateMenu(model As MenuModel)
            Try
                Dim newModel = New MenuModel()
                newModel.MenuID = model.MenuID
                newModel.MenuName = _view.MenuName
                newModel.Category = _view.CategoryName
                newModel.Supplier = _view.SupplierName
                newModel.ProductDescription = _view.ProductDescription
                Dim cost As Decimal
                Dim selling As Decimal

                If Not Decimal.TryParse(_view.Cost, cost) Then
                    Throw New FormatException("Invalid format for Cost.")
                End If
                If Not Decimal.TryParse(_view.Sell, selling) Then
                    Throw New FormatException("Invalid format for Selling price.")
                End If

                newModel.Cost = cost
                newModel.Selling = selling

                newModel.Validate()

                _mediator.UpdateMenu(newModel.MenuID, newModel)
                _mediator.SwapPage(Previous)
                RestoreView()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try

        End Sub

        Private Sub LoadWithDetails(model As MenuModel)
            model.Validate()
            _view.MenuName = model.MenuName
            _view.CategoryName = model.Category
            _view.SupplierName = model.Supplier
            _view.ProductDescription = model.ProductDescription
            _view.Cost = $"{model.Cost}"
            _view.Sell = $"{model.Selling}"
        End Sub

        Private Sub DefaultLoad()
            _view.ResetFields()
        End Sub
    End Class
End Namespace