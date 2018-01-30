Public Class frmHOTEL
    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Dim Inaphari, extra, diskon As Integer
        If RBDeluxe.Checked = True Then
            Inaphari = 3000000
        ElseIf RBSuperior.Checked = True Then
            Inaphari = 200000
        ElseIf RBStandart.Checked = True Then
            Inaphari = 100000
        End If

        If cmbextrabed.Text = "Ya" Then
            extra = 75000
        ElseIf cmbextrabed.Text = "Tidak" Then

            extra = 0

        End If
        texboxBiayaInapPerHari.Text = Inaphari + extra
        Textboxbiayainap.Text = txtlamainap.Text * texboxBiayaInapPerHari.Text
        TextBoxTotalBayar.Text = Textboxbiayainap.Text - diskon

        If txtlamainap.Text >= 5 Then
            diskon = Textboxbiayainap.Text * (5 / 100)
            TextBoxTotalBayar.Text = Textboxbiayainap.Text - diskon

        End If

    End Sub


    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtlamainap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlamainap.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Textboxbiayainap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textboxbiayainap.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
