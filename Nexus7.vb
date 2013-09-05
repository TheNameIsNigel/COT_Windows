Public Class Nexus7

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/asus/grouper/CannibalOpenTouch-v2.1_grouper.img", "C:\Users\Public\Downloads\Grouper.img")
        System.Diagnostics.Process.Start("C:\Program Files\Project Open Cannibal\Resources\Asus\nexus7.bat")
    End Sub
End Class