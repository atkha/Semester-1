Public Class Form1
    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Dim diskon, kembali As Double
            If txtBayar.Text = "" Then
            MsgBox("Input Jumlah Bayar Terlebih Dahulu")
            txtBayar.Focus()
        Else

            If rbtn1.Checked = True Then
                diskon = (5 * txtHara.Text) / 100
                txtTotal.Text = txtHara.Text - diskon
            ElseIf rbtn2.Checked = True Then
                diskon = (10 * txtHara.Text) / 100
                txtTotal.Text = txtHara.Text - diskon
            End If

            kembali = txtBayar.Text - txtTotal.Text
            txtKembali.Text = kembali
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtBayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim kembali As Double
            kembali = txtBayar.Text - txtTotal.Text
            txtKembali.Text = kembali
        End If
    End Sub

    Private Sub cmbKodeSepatu_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKodeSepatu.TextChanged
        If cmbKodeSepatu.Text = "SPads01" Then
            txtNama.Text = "Adidas"
            txtHara.Text = "230000"
        ElseIf cmbKodeSepatu.Text = "SPads03" Then
            txtNama.Text = "Adidas"
            txtHara.Text = "225000"
        ElseIf cmbKodeSepatu.Text = "SPree01" Then
            txtNama.Text = "Reebook"
            txtHara.Text = "240000"
        ElseIf cmbKodeSepatu.Text = "SPmiz02" Then
            txtNama.Text = "Mizuno"
            txtHara.Text = "260000"
        ElseIf cmbKodeSepatu.Text = "SPmiz03" Then
            txtNama.Text = "Mizuno"
            txtHara.Text = "230000"
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbKodeSepatu.Focus()
    End Sub
End Class
