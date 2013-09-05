Public Class Form1

    Private Sub RebootMenyToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutTheAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTheAppToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub RebootToSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToSystemToolStripMenuItem.Click
        System.Diagnostics.Process.Start("C:\Program Files\Project Open Cannibal\Resources\adb.exe", "reboot")
    End Sub

    Private Sub RebootToRecoveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToRecoveryToolStripMenuItem.Click
        System.Diagnostics.Process.Start("C:\Program Files\Project Open Cannibal\Resources\adb.exe", "reboot recovery")
    End Sub

    Private Sub BarnesNobleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarnesNobleToolStripMenuItem.Click

    End Sub

    Private Sub SamsungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SamsungToolStripMenuItem.Click

    End Sub

    Private Sub NexusS4GToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NexusS4GToolStripMenuItem.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/samsung/crespo4g/CannibalOpenTouch-v2.1_crespo4g.img", "C:\Users\Public\Downloads\recovery.img")
    End Sub

    Private Sub KindleFireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KindleFireToolStripMenuItem.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/amazon/otter/CannibalOpenTouch-v2.1_otter.img", "C:\Users\Public\Downloads\recovery.img")
    End Sub

    Private Sub NookColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NookColorToolStripMenuItem.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/amazon/otter/CannibalOpenTouch-v2.1_otter.img", "C:\Users\Public\Downloads\recovery.img")
    End Sub

    Private Sub Nexus4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Nexus4ToolStripMenuItem.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery", "C:\Users\Public\Downloads\recovery.img")
    End Sub

    Private Sub Nexus7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Nexus7ToolStripMenuItem.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/asus/grouper/CannibalOpenTouch-v2.1_grouper.img", "C:\Users\Public\Downloads\recovery.img")
    End Sub

    Private Sub DroidIncredibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DroidIncredibleToolStripMenuItem.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/htc/inc/CannibalOpenTouch-v2.1_inc.img", "C:\Users\Public\Downloads\recovery.img")
    End Sub

    Private Sub OneVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OneVToolStripMenuItem.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/htc/primoc/testing/CannibalOpenTouch-v2.1-dev1.2_primoc.img", "C:\Users\Public\Downloads\recovery.img")
    End Sub

    Private Sub OptimusEliteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptimusEliteToolStripMenuItem.Click

    End Sub

    Private Sub OptimusSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptimusSToolStripMenuItem.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/lge/thunderc_LS670/CannibalOpenTouch-v2.1_ls670.img", "C:\Users\Public\Downloads\recovery.img")
    End Sub

    Private Sub OptimusVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptimusVToolStripMenuItem.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/lge/thunderc_VM670/CannibalOpenTouch-v2.1_vm670.img", "C:\Users\Public\Downloads\recovery.img")
    End Sub

    Private Sub OptimusMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptimusMToolStripMenuItem.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/lge/thunderc_MS690/CannibalOpenTouch-v2.1_ms690.img", "C:\Users\Public\Downloads\recovery.img")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form2.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim response As MsgBoxResult
        response = MsgBox("Do you want to close this application?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub RebootToBootloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToBootloaderToolStripMenuItem.Click
        System.Diagnostics.Process.Start("C:\Program Files\Project Open Cannibal\Resources\adb.exe", "reboot bootloader")
    End Sub

    Private Sub RebootToDownloadModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToDownloadModeToolStripMenuItem.Click
        System.Diagnostics.Process.Start("C:\Program Files\Project Open Cannibal\Resources\adb.exe", "reboot download")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim response As MsgBoxResult
        response = MsgBox("Do you want to close form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenRecoveryImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenRecoveryImageToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Nexus7.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Amazon.ShowDialog()
    End Sub
End Class
