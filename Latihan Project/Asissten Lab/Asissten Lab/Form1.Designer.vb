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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.SoalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormCalonAsistenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LatihanFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoalToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(684, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SoalToolStripMenuItem
        '
        Me.SoalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormCalonAsistenToolStripMenuItem, Me.LatihanFormToolStripMenuItem})
        Me.SoalToolStripMenuItem.Name = "SoalToolStripMenuItem"
        Me.SoalToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SoalToolStripMenuItem.Text = "Soal"
        '
        'FormCalonAsistenToolStripMenuItem
        '
        Me.FormCalonAsistenToolStripMenuItem.Name = "FormCalonAsistenToolStripMenuItem"
        Me.FormCalonAsistenToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.FormCalonAsistenToolStripMenuItem.Text = "Form Calon Asisten"
        '
        'LatihanFormToolStripMenuItem
        '
        Me.LatihanFormToolStripMenuItem.Name = "LatihanFormToolStripMenuItem"
        Me.LatihanFormToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LatihanFormToolStripMenuItem.Text = "Latihan Form"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 742)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SoalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormCalonAsistenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LatihanFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
