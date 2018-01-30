Public Class Form1

    Private Sub HOTELToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HOTELToolStripMenuItem.Click
        frmHOTEL.MdiParent = Me
        frmHOTEL.Show()

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class