﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.FileUTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormTiketHotelHasilUjianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileUTSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(606, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileUTSToolStripMenuItem
        '
        Me.FileUTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormTiketHotelHasilUjianToolStripMenuItem})
        Me.FileUTSToolStripMenuItem.Name = "FileUTSToolStripMenuItem"
        Me.FileUTSToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FileUTSToolStripMenuItem.Text = "File UTS"
        '
        'FormTiketHotelHasilUjianToolStripMenuItem
        '
        Me.FormTiketHotelHasilUjianToolStripMenuItem.Name = "FormTiketHotelHasilUjianToolStripMenuItem"
        Me.FormTiketHotelHasilUjianToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.FormTiketHotelHasilUjianToolStripMenuItem.Text = "Form Tiket/Hotel/Hasil Ujian"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama (1412500751)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileUTSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormTiketHotelHasilUjianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
