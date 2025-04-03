Public Class CustomerMenuPage

    Private Sub CategoryButtons_MouseEnter(sender As Object, e As EventArgs) Handles _
        Guna2ContainerControl2.MouseEnter,
        Guna2ContainerControl1.MouseEnter,
        Guna2ContainerControl3.MouseEnter,
        Guna2ContainerControl4.MouseEnter,
        Guna2ContainerControl5.MouseEnter,
        Guna2ContainerControl6.MouseEnter,
        Guna2ContainerControl7.MouseEnter,
        Guna2ContainerControl10.MouseEnter,
        Guna2ContainerControl9.MouseEnter,
        Guna2ContainerControl8.MouseEnter

        Dim button = CType(sender, Guna.UI2.WinForms.Guna2ContainerControl)
        button.FillColor = Color.FromArgb(234, 234, 234)
    End Sub

    Private Sub CategoryButtons_MouseLeave(sender As Object, e As EventArgs) Handles _
        Guna2ContainerControl2.MouseLeave,
        Guna2ContainerControl1.MouseLeave,
        Guna2ContainerControl3.MouseLeave,
        Guna2ContainerControl4.MouseLeave,
        Guna2ContainerControl5.MouseLeave,
        Guna2ContainerControl6.MouseLeave,
        Guna2ContainerControl7.MouseLeave,
        Guna2ContainerControl10.MouseLeave,
        Guna2ContainerControl9.MouseLeave,
        Guna2ContainerControl8.MouseLeave

        Dim button = CType(sender, Guna.UI2.WinForms.Guna2ContainerControl)
        If button.Tag?.ToString() <> "Selected" Then
            button.FillColor = Color.Transparent
        End If
    End Sub

    Private Sub CategoryButtons_Click(sender As Object, e As EventArgs) Handles _
        Guna2ContainerControl2.Click,
        Guna2ContainerControl1.Click,
        Guna2ContainerControl3.Click,
        Guna2ContainerControl4.Click,
        Guna2ContainerControl5.Click,
        Guna2ContainerControl6.Click,
        Guna2ContainerControl7.Click,
        Guna2ContainerControl10.Click,
        Guna2ContainerControl9.Click,
        Guna2ContainerControl8.Click


        For Each btn As Guna.UI2.WinForms.Guna2ContainerControl In {
            Guna2ContainerControl2, Guna2ContainerControl1, Guna2ContainerControl3,
            Guna2ContainerControl4, Guna2ContainerControl5, Guna2ContainerControl6,
            Guna2ContainerControl7, Guna2ContainerControl10, Guna2ContainerControl9,
            Guna2ContainerControl8
        }
            btn.Tag = Nothing
            btn.FillColor = Color.Transparent
        Next

        Dim clickedButton = CType(sender, Guna.UI2.WinForms.Guna2ContainerControl)
        clickedButton.Tag = "Selected"
        clickedButton.FillColor = Color.FromArgb(234, 234, 234)
    End Sub

    Private Sub ProductContainers_MouseEnter(sender As Object, e As EventArgs) Handles _
        Guna2ContainerControl18.MouseEnter,
        Guna2ContainerControl12.MouseEnter,
        Guna2ContainerControl16.MouseEnter,
        Guna2ContainerControl17.MouseEnter,
        Guna2ContainerControl25.MouseEnter,
        Guna2ContainerControl15.MouseEnter,
        Guna2ContainerControl27.MouseEnter,
        Guna2ContainerControl29.MouseEnter

        Dim product = CType(sender, Guna.UI2.WinForms.Guna2ContainerControl)
        product.FillColor = Color.FromArgb(234, 234, 234)
    End Sub

    Private Sub ProductContainers_MouseLeave(sender As Object, e As EventArgs) Handles _
        Guna2ContainerControl18.MouseLeave,
        Guna2ContainerControl12.MouseLeave,
        Guna2ContainerControl16.MouseLeave,
        Guna2ContainerControl17.MouseLeave,
        Guna2ContainerControl25.MouseLeave,
        Guna2ContainerControl15.MouseLeave,
        Guna2ContainerControl27.MouseLeave,
        Guna2ContainerControl29.MouseLeave

        Dim product = CType(sender, Guna.UI2.WinForms.Guna2ContainerControl)
        If product.Tag?.ToString() <> "Selected" Then
            product.FillColor = Color.Transparent
        End If
    End Sub

    Private Sub ProductContainers_Click(sender As Object, e As EventArgs) Handles _
        Guna2ContainerControl18.Click,
        Guna2ContainerControl12.Click,
        Guna2ContainerControl16.Click,
        Guna2ContainerControl17.Click,
        Guna2ContainerControl25.Click,
        Guna2ContainerControl15.Click,
        Guna2ContainerControl27.Click,
        Guna2ContainerControl29.Click


        For Each container As Guna.UI2.WinForms.Guna2ContainerControl In {
            Guna2ContainerControl18, Guna2ContainerControl12, Guna2ContainerControl16,
            Guna2ContainerControl17, Guna2ContainerControl25, Guna2ContainerControl15,
            Guna2ContainerControl27, Guna2ContainerControl29
        }
            container.Tag = Nothing
            container.FillColor = Color.Transparent
        Next

        Dim clickedProduct = CType(sender, Guna.UI2.WinForms.Guna2ContainerControl)
        clickedProduct.Tag = "Selected"
        clickedProduct.FillColor = Color.FromArgb(234, 234, 234)
    End Sub

    Private Sub Guna2Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel11.Paint

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class