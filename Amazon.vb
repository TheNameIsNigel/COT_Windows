Public Class Amazon

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("http://downloads.projectopencannibal.net/Recovery/amazon/otter/CannibalOpenTouch-v2.1_otter.img", "C:\Users\Public\Downloads\otter.img")
        System.Diagnostics.Process.Start("C:\Program Files\Project Open Cannibal\Resources\Amazon\otter.bat")
    End Sub
End Class