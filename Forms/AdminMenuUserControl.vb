Imports System.Web.ModelBinding
Imports KioskV0.KioskV0.Model
Imports Newtonsoft.Json.Linq

Namespace KioskV0.Forms
    Public Class AdminMenuUserControl
        Private Property _selfClick As Action
        Public Property SelfClick As Action
            Get
                Return _selfClick
            End Get
            Set(value As Action)
                _selfClick = value
                ApplyClickEvent(Me)
            End Set
        End Property
        Private Property _model As Menu
        Public Property Model As Menu
            Get
                Return _model
            End Get
            Set(value As Menu)
                _model = value
                SetLabels()
            End Set
        End Property
        Public Sub New(model As Menu)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.Model = model
            'SetLabels()
        End Sub

        Private Sub SetLabels()
            ProductName.Text = _model.MenuName
            CategoryLabel.Text = _model.Category
            PriceLabel.Text = $"P{_model.Selling}"
            If Not String.IsNullOrEmpty(_model.ProductImagePath) AndAlso IO.File.Exists(_model.ProductImagePath) Then
                Try
                    Using fs As New IO.FileStream(_model.ProductImagePath, IO.FileMode.Open, IO.FileAccess.Read)
                        MenuImage.Image = Image.FromStream(fs)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error loading image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    MenuImage.Image = Nothing
                End Try
            Else
                MenuImage.Image = Nothing
            End If
        End Sub


        Private Sub AdminMenuUserControl_Click(sender As Object, e As EventArgs) Handles Me.Click
            SelfClick?.Invoke()
        End Sub

        Private Sub ApplyClickEvent(ctrl As Control)
            AddHandler ctrl.Click, Sub(sender, e)
                                       SelfClick?.Invoke()
                                   End Sub

            For Each child As Control In ctrl.Controls
                ApplyClickEvent(child)
            Next
        End Sub
    End Class

End Namespace