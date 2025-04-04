Namespace KioskV0.Classes
    Public Class Projector
        Public Property _projector

        Public Sub New()
            _projector = New Form()
            _projector.WindowState = FormWindowState.Maximized
            _projector.Size = Screen.PrimaryScreen.WorkingArea.Size
            _projector.Text = "Kiosk"
        End Sub

        Public Sub Project(projectable As IProjectable)
            Clear()
            projectable.Project(_projector)
        End Sub

        Public Sub LoginProject()
            Clear()
            Dim lvm = New LoginViewModel(Me)
            _projector.ShowDialog()
        End Sub

        Private Sub Clear()
            _projector.Controls.Clear()
        End Sub
    End Class

End Namespace