Public Class CustomerLandingPage
    Private Sub Guna2Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Guna2Panel1.MouseEnter
        Guna2Panel1.FillColor = Color.FromArgb(234, 234, 234)
    End Sub

    Private Sub Guna2Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Panel1.MouseLeave
        If Not Guna2Panel1.Tag?.ToString() = "Selected" Then
            Guna2Panel1.FillColor = Color.White
        End If
    End Sub

    Private Sub Guna2Panel1_Click(sender As Object, e As EventArgs) Handles Guna2Panel1.Click
        Guna2Panel1.Tag = "Selected"
        Guna2Panel1.FillColor = Color.FromArgb(234, 234, 234)
        Guna2Panel2.Tag = Nothing
        Guna2Panel2.FillColor = Color.Transparent
    End Sub

    Private Sub Guna2Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Guna2Panel2.MouseEnter
        Guna2Panel2.FillColor = Color.FromArgb(234, 234, 234)
    End Sub

    Private Sub Guna2Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Guna2Panel2.MouseLeave
        If Not Guna2Panel2.Tag?.ToString() = "Selected" Then
            Guna2Panel2.FillColor = Color.Transparent
        End If
    End Sub

    Private Sub Guna2Panel2_Click(sender As Object, e As EventArgs) Handles Guna2Panel2.Click
        Guna2Panel2.Tag = "Selected"
        Guna2Panel2.FillColor = Color.FromArgb(234, 234, 234)
        Guna2Panel1.Tag = Nothing
        Guna2Panel1.FillColor = Color.White
    End Sub

    Private Sub CustomerLandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub
End Class