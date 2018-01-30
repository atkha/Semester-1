<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblJudul = New System.Windows.Forms.Label
        Me.lblKodeSepatu = New System.Windows.Forms.Label
        Me.lblNamaSepatu = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblBayar = New System.Windows.Forms.Label
        Me.lblKembali = New System.Windows.Forms.Label
        Me.cmbKodeSepatu = New System.Windows.Forms.ComboBox
        Me.txtNama = New System.Windows.Forms.TextBox
        Me.txtHara = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblPersen2 = New System.Windows.Forms.Label
        Me.persen1 = New System.Windows.Forms.Label
        Me.rbtn2 = New System.Windows.Forms.RadioButton
        Me.rbtn1 = New System.Windows.Forms.RadioButton
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtBayar = New System.Windows.Forms.TextBox
        Me.txtKembali = New System.Windows.Forms.TextBox
        Me.btnHitung = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.lblHargaSatuan = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Location = New System.Drawing.Point(93, 9)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(123, 13)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Penjualan Sepatu ""Cool"""
        '
        'lblKodeSepatu
        '
        Me.lblKodeSepatu.AutoSize = True
        Me.lblKodeSepatu.Location = New System.Drawing.Point(42, 49)
        Me.lblKodeSepatu.Name = "lblKodeSepatu"
        Me.lblKodeSepatu.Size = New System.Drawing.Size(68, 13)
        Me.lblKodeSepatu.TabIndex = 1
        Me.lblKodeSepatu.Text = "Kode Sepatu"
        '
        'lblNamaSepatu
        '
        Me.lblNamaSepatu.AutoSize = True
        Me.lblNamaSepatu.Location = New System.Drawing.Point(42, 76)
        Me.lblNamaSepatu.Name = "lblNamaSepatu"
        Me.lblNamaSepatu.Size = New System.Drawing.Size(71, 13)
        Me.lblNamaSepatu.TabIndex = 2
        Me.lblNamaSepatu.Text = "Nama Sepatu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 3
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(40, 220)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(62, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total Bayar"
        '
        'lblBayar
        '
        Me.lblBayar.AutoSize = True
        Me.lblBayar.Location = New System.Drawing.Point(40, 194)
        Me.lblBayar.Name = "lblBayar"
        Me.lblBayar.Size = New System.Drawing.Size(63, 13)
        Me.lblBayar.TabIndex = 5
        Me.lblBayar.Text = "Uang Bayar"
        '
        'lblKembali
        '
        Me.lblKembali.AutoSize = True
        Me.lblKembali.Location = New System.Drawing.Point(42, 247)
        Me.lblKembali.Name = "lblKembali"
        Me.lblKembali.Size = New System.Drawing.Size(43, 13)
        Me.lblKembali.TabIndex = 6
        Me.lblKembali.Text = "Kembali"
        '
        'cmbKodeSepatu
        '
        Me.cmbKodeSepatu.FormattingEnabled = True
        Me.cmbKodeSepatu.Items.AddRange(New Object() {"SPads01", "SPads03", "SPree01", "SPmiz02", "SPmiz03"})
        Me.cmbKodeSepatu.Location = New System.Drawing.Point(124, 46)
        Me.cmbKodeSepatu.Name = "cmbKodeSepatu"
        Me.cmbKodeSepatu.Size = New System.Drawing.Size(121, 21)
        Me.cmbKodeSepatu.TabIndex = 7
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(124, 73)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(100, 20)
        Me.txtNama.TabIndex = 8
        '
        'txtHara
        '
        Me.txtHara.Location = New System.Drawing.Point(124, 99)
        Me.txtHara.Name = "txtHara"
        Me.txtHara.ReadOnly = True
        Me.txtHara.Size = New System.Drawing.Size(100, 20)
        Me.txtHara.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPersen2)
        Me.GroupBox1.Controls.Add(Me.persen1)
        Me.GroupBox1.Controls.Add(Me.rbtn2)
        Me.GroupBox1.Controls.Add(Me.rbtn1)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 59)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'lblPersen2
        '
        Me.lblPersen2.AutoSize = True
        Me.lblPersen2.Location = New System.Drawing.Point(101, 19)
        Me.lblPersen2.Name = "lblPersen2"
        Me.lblPersen2.Size = New System.Drawing.Size(33, 13)
        Me.lblPersen2.TabIndex = 3
        Me.lblPersen2.Text = "10 %"
        '
        'persen1
        '
        Me.persen1.AutoSize = True
        Me.persen1.Location = New System.Drawing.Point(38, 19)
        Me.persen1.Name = "persen1"
        Me.persen1.Size = New System.Drawing.Size(27, 13)
        Me.persen1.TabIndex = 2
        Me.persen1.Text = "5 %"
        '
        'rbtn2
        '
        Me.rbtn2.AutoSize = True
        Me.rbtn2.Location = New System.Drawing.Point(81, 19)
        Me.rbtn2.Name = "rbtn2"
        Me.rbtn2.Size = New System.Drawing.Size(14, 13)
        Me.rbtn2.TabIndex = 1
        Me.rbtn2.TabStop = True
        Me.rbtn2.UseVisualStyleBackColor = True
        '
        'rbtn1
        '
        Me.rbtn1.AutoSize = True
        Me.rbtn1.Location = New System.Drawing.Point(18, 19)
        Me.rbtn1.Name = "rbtn1"
        Me.rbtn1.Size = New System.Drawing.Size(14, 13)
        Me.rbtn1.TabIndex = 0
        Me.rbtn1.TabStop = True
        Me.rbtn1.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(124, 217)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 4
        '
        'txtBayar
        '
        Me.txtBayar.Location = New System.Drawing.Point(124, 191)
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(100, 20)
        Me.txtBayar.TabIndex = 5
        '
        'txtKembali
        '
        Me.txtKembali.Enabled = False
        Me.txtKembali.Location = New System.Drawing.Point(124, 247)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.ReadOnly = True
        Me.txtKembali.Size = New System.Drawing.Size(100, 20)
        Me.txtKembali.TabIndex = 6
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(43, 287)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 11
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(149, 287)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 12
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'lblHargaSatuan
        '
        Me.lblHargaSatuan.AutoSize = True
        Me.lblHargaSatuan.Location = New System.Drawing.Point(42, 102)
        Me.lblHargaSatuan.Name = "lblHargaSatuan"
        Me.lblHargaSatuan.Size = New System.Drawing.Size(73, 13)
        Me.lblHargaSatuan.TabIndex = 13
        Me.lblHargaSatuan.Text = "Harga Satuan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 355)
        Me.Controls.Add(Me.lblHargaSatuan)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtBayar)
        Me.Controls.Add(Me.txtKembali)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtHara)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.cmbKodeSepatu)
        Me.Controls.Add(Me.lblKembali)
        Me.Controls.Add(Me.lblBayar)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNamaSepatu)
        Me.Controls.Add(Me.lblKodeSepatu)
        Me.Controls.Add(Me.lblJudul)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblKodeSepatu As System.Windows.Forms.Label
    Friend WithEvents lblNamaSepatu As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblBayar As System.Windows.Forms.Label
    Friend WithEvents lblKembali As System.Windows.Forms.Label
    Friend WithEvents cmbKodeSepatu As System.Windows.Forms.ComboBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtHara As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPersen2 As System.Windows.Forms.Label
    Friend WithEvents persen1 As System.Windows.Forms.Label
    Friend WithEvents rbtn2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtBayar As System.Windows.Forms.TextBox
    Friend WithEvents txtKembali As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents lblHargaSatuan As System.Windows.Forms.Label

End Class
