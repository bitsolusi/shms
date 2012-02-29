<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIdentitas1
    Inherits Global.SchoolHealtyMS.PageTemplate

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.pnlUtama = New System.Windows.Forms.Panel
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.pnlUtama)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 109)
        Me.GroupControl1.LookAndFeel.SkinName = "Liquid Sky"
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(965, 304)
        Me.GroupControl1.TabIndex = 1
        '
        'pnlUtama
        '
        Me.pnlUtama.AutoScroll = True
        Me.pnlUtama.BackColor = System.Drawing.Color.White
        Me.pnlUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUtama.Location = New System.Drawing.Point(2, 21)
        Me.pnlUtama.Margin = New System.Windows.Forms.Padding(15)
        Me.pnlUtama.Name = "pnlUtama"
        Me.pnlUtama.Size = New System.Drawing.Size(961, 281)
        Me.pnlUtama.TabIndex = 28
        '
        'FormIdentitas1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FormIdentitas1"
        Me.TitleHead = "Identitas Sekolah"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnlUtama As System.Windows.Forms.Panel

End Class
