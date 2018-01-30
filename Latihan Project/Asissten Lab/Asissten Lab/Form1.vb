Public Class Form1

    Private Sub FormCalonAsistenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormCalonAsistenToolStripMenuItem.Click
        Form2.Show()
        Form2.MdiParent = Me
    End Sub

    Private Sub LatihanFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LatihanFormToolStripMenuItem.Click
        Form3.Show()
        Form3.MdiParent = Me
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
