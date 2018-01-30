Public Class Form3

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged
        
    End Sub

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Dim absen, tugas, uts, uas, hasil As Double
        absen = txtAbsen.Text
        tugas = txtTugas.Text
        uts = txtUTS.Text
        uas = txtUAS.Text
        hasil = (0.1 * absen) + (0.2 * tugas) + (0.3 * uts) + (0.4 * uas)
        txtTotal.Text = hasil
        If txtTotal.Text >= 85 And txtTotal.Text <= 100 Then
            txtGrade.Text = "A"
        ElseIf txtTotal.Text >= 75 And txtTotal.Text <= 84 Then
            txtGrade.Text = "B"
        ElseIf txtTotal.Text >= 65 And txtTotal.Text <= 74 Then
            txtGrade.Text = "C"
        ElseIf txtTotal.Text >= 0 And txtTotal.Text <= 64 Then
            txtGrade.Text = "D"
        Else
            txtGrade.Text = "Salah Input Nilai"
        End If

        If txtGrade.Text = "D" Then
            txtKet.Text = "Tidak Lulus"
        Else
            txtKet.Text = "Lulus"
        End If
    End Sub

    Private Sub btnBersih_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBersih.Click
        txtAbsen.Text = ""
        txtGrade.Text = ""
        txtKet.Text = ""
        txtNama.Text = ""
        txtNIM.Text = ""
        txtTotal.Text = ""
        txtTugas.Text = ""
        txtUAS.Text = ""
        txtUTS.Text = ""
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtNIM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNIM.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAbsen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbsen.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTugas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTugas.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtUAS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUAS.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtUTS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUTS.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNama.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class