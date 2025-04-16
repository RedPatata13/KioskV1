Public Class StaffPosOrderUserControl
    Public Property DeleteClick As Action
    Private Property _model As OrderDetail
    Private Property _count As Integer = 0
    Public Property TextCount As Integer
        Get
            Return _count
            If _count > 0 Then
                RemoveButton.Enabled = True
            Else
                RemoveButton.Enabled = False
            End If

            If _count < 99 Then
                AddOrderButton.Enabled = True
            Else
                AddOrderButton.Enabled = False
            End If
        End Get
        Set(value As Integer)
            If value <= 99 And value >= 0 Then
                _count = value
                If _model IsNot Nothing Then _model.Quantity = value
                Dim fmt_sd = $"0{_count}"
                Dim fmt_td = $"{_count}"

                If _count < 10 Then
                    ProductQuantityLabel.Text = fmt_sd
                Else
                    ProductQuantityLabel.Text = fmt_td
                End If
            End If
        End Set
    End Property
    Public Property Model As OrderDetail
        Get
            Return _model
        End Get
        Set(value As OrderDetail)
            _model = value
            TextCount = value.Quantity
            ProductNameLabel.Text = TruncateText(value.CustomerItem.Name, 40)
        End Set
    End Property
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TextCount = 0
        ProductQuantityLabel.ForeColor = Color.Black
        ProductNameLabel.ForeColor = Color.Black
    End Sub

    Private Sub AddOrderButton_Click(sender As Object, e As EventArgs) Handles AddOrderButton.Click
        If _count < 99 Then
            TextCount += 1
            RemoveButton.Enabled = True

            If _count = 99 Then
                AddOrderButton.Enabled = False
            End If
        Else
            AddOrderButton.Enabled = False
        End If
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        If _count > 0 Then
            TextCount -= 1
            AddOrderButton.Enabled = True

            If _count = 0 Then
                RemoveButton.Enabled = False
            End If

        Else
            RemoveButton.Enabled = False
        End If
    End Sub

    Private Function TruncateText(input As String, maxLength As Integer) As String
        If String.IsNullOrEmpty(input) OrElse input.Length <= maxLength Then
            Return input
        End If
        If maxLength <= 3 Then
            Return "..."
        End If
        Return input.Substring(0, maxLength - 3) & "..."
    End Function

    Private Sub DeleteOrderButton_Click(sender As Object, e As EventArgs) Handles DeleteOrderButton.Click
        DeleteClick?.Invoke()
    End Sub
End Class
