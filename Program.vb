﻿

Namespace KioskV0
    Module Program
        <STAThread()>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            'Application.Run(New KioskV0.Forms.Login())

            Dim projector = New Classes.Projector()
            projector.LoginProject()

        End Sub
    End Module
End Namespace