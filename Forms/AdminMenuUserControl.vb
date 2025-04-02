Imports KioskV0.KioskV0.Model

Namespace KioskV0.Forms
    Public Class AdminMenuUserControl
        Private Property _model As MenuModel
        Public Property Model As MenuModel
            Get
                Return _model
            End Get
            Set(value As MenuModel)
                _model = value
            End Set
        End Property

        Public Sub New(model As MenuModel)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _model = model
            SetLabels()
        End Sub

        Private Sub SetLabels()
            ProductName.Text = _model.MenuName
            CategoryLabel.Text = _model.Category
            PriceLabel.Text = $"P{_model.Selling}"
        End Sub
    End Class

End Namespace