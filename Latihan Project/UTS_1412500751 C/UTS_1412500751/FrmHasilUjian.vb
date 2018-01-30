Public Class Form2
    
    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Dim tugas, uts, uas, jmlkehadiran, rata As Double
        Dim hasil As String
        tugas = txtBox1.Text
        uts = txtBox2.Text
        uas = txtBox3.Text
        jmlkehadiran = txtBox4.Text
        rata = (tugas + uas + uts) / 3
        txtBox5.Text = rata
        If txtBox5.Text <= 60 Then
            hasil = "Tidak Lulus"
        Else
            hasil = "Lulus"
        End If
        txtBox6.Text = hasil
        If txtBox4.Text < 12 Then
            hasil = "Tidak Lulus"
        End If
        txtBox6.Text = hasil
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        txtBox1.Text = ""
        txtBox2.Text = ""
        txtBox3.Text = ""
        txtBox4.Text = ""
        txtBox5.Text = ""
        txtBox6.Text = ""
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()

    End Sub

    Private Sub txtBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class