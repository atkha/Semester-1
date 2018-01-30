<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHOTEL
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
        Me.lblLamaInap = New System.Windows.Forms.Label
        Me.txtlamainap = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbextrabed = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.texboxBiayaInapPerHari = New System.Windows.Forms.TextBox
        Me.Textboxbiayainap = New System.Windows.Forms.TextBox
        Me.TextBoxTotalBayar = New System.Windows.Forms.TextBox
        Me.RBDeluxe = New System.Windows.Forms.RadioButton
        Me.RBSuperior = New System.Windows.Forms.RadioButton
        Me.RBStandart = New System.Windows.Forms.RadioButton
        Me.btnHitung = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblLamaInap
        '
        Me.lblLamaInap.AutoSize = True
        Me.lblLamaInap.Location = New System.Drawing.Point(28, 36)
        Me.lblLamaInap.Name = "lblLamaInap"
        Me.lblLamaInap.Size = New System.Drawing.Size(70, 13)
        Me.lblLamaInap.TabIndex = 0
        Me.lblLamaInap.Text = "Lama Inap   :"
        '
        'txtlamainap
        '
        Me.txtlamainap.Location = New System.Drawing.Point(103, 33)
        Me.txtlamainap.Name = "txtlamainap"
        Me.txtlamainap.Size = New System.Drawing.Size(120, 20)
        Me.txtlamainap.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kelas          :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Extra Bed   :"
        '
        'cmbextrabed
        '
        Me.cmbextrabed.AccessibleDescription = ""
        Me.cmbextrabed.FormattingEnabled = True
        Me.cmbextrabed.Items.AddRange(New Object() {"Ya", "Tidak"})
        Me.cmbextrabed.Location = New System.Drawing.Point(102, 112)
        Me.cmbextrabed.Name = "cmbextrabed"
        Me.cmbextrabed.Size = New System.Drawing.Size(121, 21)
        Me.cmbextrabed.TabIndex = 7
        Me.cmbextrabed.Text = "--Pilihan--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Biaya Inap Per Hari :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(103, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Biaya Inap :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Bayar :"
        '
        'texboxBiayaInapPerHari
        '
        Me.texboxBiayaInapPerHari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.texboxBiayaInapPerHari.Location = New System.Drawing.Point(172, 149)
        Me.texboxBiayaInapPerHari.Name = "texboxBiayaInapPerHari"
        Me.texboxBiayaInapPerHari.ReadOnly = True
        Me.texboxBiayaInapPerHari.Size = New System.Drawing.Size(140, 13)
        Me.texboxBiayaInapPerHari.TabIndex = 11
        '
        'Textboxbiayainap
        '
        Me.Textboxbiayainap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textboxbiayainap.Location = New System.Drawing.Point(172, 174)
        Me.Textboxbiayainap.Name = "Textboxbiayainap"
        Me.Textboxbiayainap.ReadOnly = True
        Me.Textboxbiayainap.Size = New System.Drawing.Size(140, 13)
        Me.Textboxbiayainap.TabIndex = 12
        '
        'TextBoxTotalBayar
        '
        Me.TextBoxTotalBayar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxTotalBayar.Location = New System.Drawing.Point(172, 199)
        Me.TextBoxTotalBayar.Name = "TextBoxTotalBayar"
        Me.TextBoxTotalBayar.ReadOnly = True
        Me.TextBoxTotalBayar.Size = New System.Drawing.Size(140, 13)
        Me.TextBoxTotalBayar.TabIndex = 13
        '
        'RBDeluxe
        '
        Me.RBDeluxe.AutoSize = True
        Me.RBDeluxe.Location = New System.Drawing.Point(31, 89)
        Me.RBDeluxe.Name = "RBDeluxe"
        Me.RBDeluxe.Size = New System.Drawing.Size(58, 17)
        Me.RBDeluxe.TabIndex = 14
        Me.RBDeluxe.TabStop = True
        Me.RBDeluxe.Text = "Deluxe"
        Me.RBDeluxe.UseVisualStyleBackColor = True
        '
        'RBSuperior
        '
        Me.RBSuperior.AutoSize = True
        Me.RBSuperior.Location = New System.Drawing.Point(96, 89)
        Me.RBSuperior.Name = "RBSuperior"
        Me.RBSuperior.Size = New System.Drawing.Size(65, 17)
        Me.RBSuperior.TabIndex = 15
        Me.RBSuperior.TabStop = True
        Me.RBSuperior.Text = "Superior"
        Me.RBSuperior.UseVisualStyleBackColor = True
        '
        'RBStandart
        '
        Me.RBStandart.AutoSize = True
        Me.RBStandart.Location = New System.Drawing.Point(167, 89)
        Me.RBStandart.Name = "RBStandart"
        Me.RBStandart.Size = New System.Drawing.Size(67, 17)
        Me.RBStandart.TabIndex = 16
        Me.RBStandart.TabStop = True
        Me.RBStandart.Text = "Standart"
        Me.RBStandart.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(261, 33)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 40)
        Me.btnHitung.TabIndex = 17
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(261, 89)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 36)
        Me.btnKeluar.TabIndex = 18
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'frmHOTEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 249)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.RBStandart)
        Me.Controls.Add(Me.RBSuperior)
        Me.Controls.Add(Me.RBDeluxe)
        Me.Controls.Add(Me.TextBoxTotalBayar)
        Me.Controls.Add(Me.Textboxbiayainap)
        Me.Controls.Add(Me.texboxBiayaInapPerHari)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbextrabed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtlamainap)
        Me.Controls.Add(Me.lblLamaInap)
        Me.Name = "frmHOTEL"
        Me.Text = "HOTEL (1411500042)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLamaInap As System.Windows.Forms.Label
    Friend WithEvents txtlamainap As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbextrabed As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents texboxBiayaInapPerHari As System.Windows.Forms.TextBox
    Friend WithEvents Textboxbiayainap As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents RBDeluxe As System.Windows.Forms.RadioButton
    Friend WithEvents RBSuperior As System.Windows.Forms.RadioButton
    Friend WithEvents RBStandart As System.Windows.Forms.RadioButton
    Friend WithEvents btnHitung As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button

End Class
