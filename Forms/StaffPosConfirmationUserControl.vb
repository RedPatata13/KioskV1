﻿Public Class StaffPosConfirmationUserControl
    Public Property CancelButtonClick As Action
    Public Property ConfirmButtonClick As Action
    Public Property LabelMessage As String
        Get
            Return Message.Text
        End Get
        Set(value As String)
            Message.Text = value
        End Set
    End Property
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles CancelClick.Click
        CancelButtonClick?.Invoke()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles ConfirmClick.Click
        ConfirmButtonClick?.Invoke
    End Sub
End Class
