Public Class CustomerLandingPage
    Private Sub Guna2Panel1_MouseEnter(sender As Object, e As EventArgs) Handles DineinPanel.MouseEnter
        DineinPanel.FillColor = Color.FromArgb(234, 234, 234)
    End Sub

    Private Sub Guna2Panel1_MouseLeave(sender As Object, e As EventArgs) Handles DineinPanel.MouseLeave
        If Not DineinPanel.Tag?.ToString() = "Selected" Then
            DineinPanel.FillColor = Color.White
        End If
    End Sub

    Private Sub Guna2Panel1_Click(sender As Object, e As EventArgs) Handles DineinPanel.Click
        DineinPanel.Tag = "Selected"
        DineinPanel.FillColor = Color.FromArgb(234, 234, 234)
        TakeOutPanel.Tag = Nothing
        TakeOutPanel.FillColor = Color.Transparent
    End Sub

    Private Sub Guna2Panel2_MouseEnter(sender As Object, e As EventArgs) Handles TakeOutPanel.MouseEnter
        TakeOutPanel.FillColor = Color.FromArgb(234, 234, 234)
    End Sub

    Private Sub Guna2Panel2_MouseLeave(sender As Object, e As EventArgs) Handles TakeOutPanel.MouseLeave
        If Not TakeOutPanel.Tag?.ToString() = "Selected" Then
            TakeOutPanel.FillColor = Color.Transparent
        End If
    End Sub

    Private Sub Guna2Panel2_Click(sender As Object, e As EventArgs) Handles TakeOutPanel.Click
        TakeOutPanel.Tag = "Selected"
        TakeOutPanel.FillColor = Color.FromArgb(234, 234, 234)
        DineinPanel.Tag = Nothing
        DineinPanel.FillColor = Color.White
    End Sub

    Private Sub CustomerLandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles LandingPagePanel.Paint

    End Sub
End Class