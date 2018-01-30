Public Class Form2

    Private Sub txtxNim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtxNim.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtxNim_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtxNim.TextChanged
        If txtxNim.Text = "1412" Then
            cmbFakultas.Text = "FTI"
            cmbProdi.Text = "Sistem Informasi"
        ElseIf txtxNim.Text = "1411" Then
            cmbFakultas.Text = "FTI"
            cmbProdi.Text = "Teknologi Informatika"
        ElseIf txtxNim.Text = "1413" Then
            cmbFakultas.Text = "FTI"
            cmbProdi.Text = "Sistem Komputer"
        ElseIf txtxNim.Text = "1414" Then
            cmbFakultas.Text = "FIKOM"
            cmbProdi.Text = "Desain Komunikasi Visual"
        ElseIf txtxNim.Text = "1415" Then
            cmbFakultas.Text = "FIKOM"
            cmbProdi.Text = "Public Relations"
        ElseIf txtxNim.Text = "1416" Then
            cmbFakultas.Text = "FE"
            cmbProdi.Text = "Akuntansi"
        ElseIf txtxNim.Text = "1417" Then
            cmbFakultas.Text = "FE"
            cmbProdi.Text = "Management"
        ElseIf txtxNim.Text = "1418" Then
            cmbFakultas.Text = "FISIP"
            cmbProdi.Text = "Hubungan Internasional"
        ElseIf txtxNim.Text = "1419" Then
            cmbFakultas.Text = "FISIP"
            cmbProdi.Text = "Kriminologi"
        ElseIf txtxNim.Text = "1420" Then
            cmbFakultas.Text = "FT"
            cmbProdi.Text = "Arsitektur"
        ElseIf txtxNim.Text = "1421" Then
            cmbFakultas.Text = "FT"
            cmbProdi.Text = "Teknik Elektro"
        End If
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        ListBox1.Items.Add("Nim                     : " & txtxNim.Text)
        ListBox1.Items.Add("Nama                    : " & txtNama.Text)
        If rbLaki.Checked = True Then
            ListBox1.Items.Add("Jenis Kelamin       : " & rbLaki.Text)
        ElseIf rbPerempuan.Checked = True Then
            ListBox1.Items.Add("Janis Kelamin       : " & rbPerempuan.Text)
        Else
            ListBox1.Items.Add("Janis Kelamin       :  ")
        End If
        ListBox1.Items.Add("Fakultas            : " & cmbFakultas.Text)
        ListBox1.Items.Add("Prodi               : " & cmbProdi.Text)
        ListBox1.Items.Add("Tanggal Lahir   : " & DateTimePicker1.Text)
        If chkbaca.Checked = True Then
            ListBox1.Items.Add("Hobi            : " & chkbaca.Text)
        ElseIf chkGambar.Checked = True Then
            ListBox1.Items.Add("Hobi            : " & chkGambar.Text)
        ElseIf chkMemasak.Checked = True Then
            ListBox1.Items.Add("Hobi            : " & chkMemasak.Text)
        ElseIf chkTravel.Checked = True Then
            ListBox1.Items.Add("Hobi            : " & chkTravel.Text)
        Else
            ListBox1.Items.Add("Hobi            : ")
        End If

    End Sub

    Private Sub btnBersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersih.Click
        ListBox1.Items.Clear()
        txtNama.Text = ""
        txtxNim.Text = ""
        cmbFakultas.Text = ""
        cmbProdi.Text = ""
        DateTimePicker1.Text = ""
        chkbaca.Checked = False
        chkGambar.Checked = False
        chkMemasak.Checked = False
        chkTravel.Checked = False
        rbLaki.Checked = False
        rbPerempuan.Checked = False
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNama.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 And Asc(e.KeyChar) = 32 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class