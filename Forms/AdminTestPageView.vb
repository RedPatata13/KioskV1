﻿Namespace KioskV0.Forms
    Public Class AdminTestPageView
        Public Property TestButtonClick As Action
        Private Sub AdminTestPageView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            TestButtonClick?.Invoke()
        End Sub
    End Class
End Namespace