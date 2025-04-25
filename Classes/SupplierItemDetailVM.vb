Namespace KioskV0.Classes
    Public Class SupplierItemDetailVM
        Inherits ViewModel(Of SupplierItemDetailView, SupplierKeys)
        Private Property Loaded As Boolean = False
        Public Sub New(view As SupplierItemDetailView, mediator As Mediator(Of SupplierKeys))
            MyBase.New(view, mediator)
        End Sub
        Protected Friend Overrides Sub SetEvents()
            MyBase.SetEvents()

            AddHandler _view.CopyIdButtonClick, AddressOf OnCopyItemClick
        End Sub
        Public Overrides Sub Project(projector As Form)
            If Not Loaded Then
                MyBase.Project(projector)
                ResizeComponents(_mediator.GetProjectorPanelSize())
                Loaded = True
            End If
            MyBase.Project(projector)
        End Sub

        Private Sub LoadAsEdit(item As SupplierItem)
            _view.ItemIDField.Text = item.Id
            _view.ItemNameField.Text = item.Name
            _view.DescriptionField.Text = item.Description
            _view.UnitCostField.Text = item.UnitCost
        End Sub

        Private Sub ResetFields()
            _view.ItemIDField.Text = ""
            _view.ItemNameField.Text = ""
            _view.DescriptionField.Text = ""
            _view.UnitCostField.Text = ""
        End Sub

        Private Sub OnCopyItemClick()
            If Not String.IsNullOrWhiteSpace(_view.ItemIDField.Text) Then
                Clipboard.SetText(_view.ItemIDField.Text)
                MessageBox.Show("Item ID copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Public Sub LoadItem(item As SupplierItem)
            LoadAsEdit(item)
        End Sub
    End Class

End Namespace