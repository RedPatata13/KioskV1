

Namespace KioskV0
    Module Program
        <STAThread()>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New KioskV0.Forms.StaffPosView())


            Dim projector = New Classes.Projector()
            projector.LoginProject()
            'projector._projector.ShowDialog()
            'Application.Run(New ProjectorView())


        End Sub
    End Module
End Namespace