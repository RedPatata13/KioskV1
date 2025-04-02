Imports System.ComponentModel.DataAnnotations
Imports System.Reflection
Imports KioskV0.KioskV0.Classes
Imports KioskV0.KioskV0.Model

Namespace KioskV0.Classes
    Public Class AdminEditMenuDetailsViewModel
        Inherits ViewModel(Of Forms.AdminEditMenuDetailsView, AdminKeys)
        'Public Property Previous As AdminKeys
        Public Property PendingAction As Action(Of BaseModel)
        Public Sub New(view As Forms.AdminEditMenuDetailsView, mediator As Mediator(Of AdminKeys))
            MyBase.New(view, mediator)
            InitializeActions()
            AddActions()
            SetEvents()
        End Sub

        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()
            Previous = AdminKeys.AdminLandingPage
            _view.CancelButtonClick = AddressOf CancelButtonClick
            _view.SelectImageClick = AddressOf SelectImageClick
            _view.SaveButtonClick = AddressOf SaveButtonClick
        End Sub
        Protected Sub AddActions()
            ExternalActions.Add("LoadWithDetails", AddressOf LoadWithDetails)
        End Sub
        Protected Overrides Sub InitializeActions()
            ExternalActions = New Dictionary(Of String, Action(Of Model.BaseModel))
            'InternalActions = New Dictionary(Of String, Action(Of ViewModel(Of)
        End Sub

        Private Sub CancelButtonClick()
            _mediator.SwapPage(Previous)
            _view.ResetFields()
            'Dim temp = _view
            '_view = New Forms.AdminAddMenuView()
            'SetEvents()
            'temp.Dispose()
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

                'Dim properties = model.GetType().GetProperties()
                'Dim str As String = ""
                'For Each prop As PropertyInfo In properties
                '    Dim value = prop.GetValue(model)
                '    str &= Convert.ToString(value) & vbCrLf
                'Next

                'MessageBox.Show(str)
                PendingAction?.Invoke(model)
                _mediator.SwapPage(Previous)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Sub

        Private Sub LoadWithDetails(model As BaseModel)
            Dim menuModel As MenuModel = TryCast(model, MenuModel)

            If menuModel Is Nothing Then
                Throw New InvalidCastException("The provided model is not of type MenuModel.")
            End If

            menuModel.Validate()
            _view.MenuName = menuModel.MenuName
            _view.CategoryName = menuModel.Category
            _view.SupplierName = menuModel.Supplier
            _view.ProductDescription = menuModel.ProductDescription
            _view.Cost = $"{menuModel.Cost}"
            _view.Sell = $"{menuModel.Selling}"

            _mediator.SwapPage(AdminKeys.AdminEditMenuDetails)
        End Sub

        Private Sub DefaultLoad()
            _view.ResetFields()
        End Sub
    End Class
End Namespace