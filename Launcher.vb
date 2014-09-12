Public Class Launcher

    Private Sub Launcher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Thread current = Thread.CurrentThread;
        Thread.Sleep(3000);
        Try
			{
				Process newProc = Process.Start("iexplore.exe", forumaddr);
			}
        Catch
			{
				MessageBox.Show("Internet Explorer is not found", "Error!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
    End Sub
End Class
