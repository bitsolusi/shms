<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class templateFormDialog
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(templateFormDialog))
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems
        Me.LayoutButton = New DevExpress.XtraLayout.LayoutControl
        Me.LayoutControlGroupButton = New DevExpress.XtraLayout.LayoutControlGroup
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.btnReset = New DevExpress.XtraEditors.SimpleButton
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TitleHeader = New gLabel.gLabel
        CType(Me.LayoutButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutButton.SuspendLayout()
        CType(Me.LayoutControlGroupButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutButton
        '
        Me.LayoutButton.Controls.Add(Me.btnReset)
        Me.LayoutButton.Controls.Add(Me.btnSimpan)
        Me.LayoutButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LayoutButton.Location = New System.Drawing.Point(0, 326)
        Me.LayoutButton.Name = "LayoutButton"
        Me.LayoutButton.Root = Me.LayoutControlGroupButton
        Me.LayoutButton.Size = New System.Drawing.Size(503, 51)
        Me.LayoutButton.TabIndex = 8
        Me.LayoutButton.Text = "LayoutControl2"
        '
        'LayoutControlGroupButton
        '
        Me.LayoutControlGroupButton.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroupButton.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.EmptySpaceItem3, Me.LayoutControlItem24, Me.LayoutControlItem7})
        Me.LayoutControlGroupButton.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroupButton.Name = "LayoutControlGroupButton"
        Me.LayoutControlGroupButton.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroupButton.Size = New System.Drawing.Size(503, 51)
        Me.LayoutControlGroupButton.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroupButton.Text = "LayoutControlGroupButton"
        Me.LayoutControlGroupButton.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(475, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(26, 49)
        Me.EmptySpaceItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.EmptySpaceItem1.Text = "EmptySpaceItem1"
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.CustomizationFormText = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(229, 49)
        Me.EmptySpaceItem3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.EmptySpaceItem3.Text = "EmptySpaceItem3"
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'btnReset
        '
        Me.btnReset.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Appearance.Options.UseFont = True
        Me.btnReset.Image = Global.SchoolHealtyMS.My.Resources.Resources.delete_comment
        Me.btnReset.Location = New System.Drawing.Point(355, 7)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(116, 32)
        Me.btnReset.StyleController = Me.LayoutButton
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Cancel / Close"
        '
        'btnSimpan
        '
        Me.btnSimpan.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Appearance.Options.UseFont = True
        Me.btnSimpan.Image = Global.SchoolHealtyMS.My.Resources.Resources.process_accept
        Me.btnSimpan.Location = New System.Drawing.Point(236, 7)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(108, 32)
        Me.btnSimpan.StyleController = Me.LayoutButton
        Me.btnSimpan.TabIndex = 5
        Me.btnSimpan.Text = "Simpan"
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.btnReset
        Me.LayoutControlItem24.CustomizationFormText = "LayoutControlItem24"
        Me.LayoutControlItem24.Location = New System.Drawing.Point(348, 0)
        Me.LayoutControlItem24.Name = "LayoutControlItem24"
        Me.LayoutControlItem24.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem24.Size = New System.Drawing.Size(127, 49)
        Me.LayoutControlItem24.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem24.Text = "LayoutControlItem24"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem24.TextToControlDistance = 0
        Me.LayoutControlItem24.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnSimpan
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(229, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(119, 49)
        Me.LayoutControlItem7.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlItem7.Text = "LayoutControlItem7"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextToControlDistance = 0
        Me.LayoutControlItem7.TextVisible = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.TitleHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 62)
        Me.Panel1.TabIndex = 7
        '
        'TitleHeader
        '
        Me.TitleHeader.BackColor = System.Drawing.Color.Transparent
        Me.TitleHeader.BorderWidth = 1.0!
        Me.TitleHeader.FillType = gLabel.gLabel.eFillType.Solid
        Me.TitleHeader.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TitleHeader.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleHeader.ForeColor = System.Drawing.Color.White
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.TitleHeader.ForeColorBlend = CBlendItems1
        Me.TitleHeader.Glow = 8
        Me.TitleHeader.GlowColor = System.Drawing.Color.AliceBlue
        Me.TitleHeader.Location = New System.Drawing.Point(24, 14)
        Me.TitleHeader.MouseOver = False
        Me.TitleHeader.Name = "TitleHeader"
        Me.TitleHeader.PulseSpeed = 25
        Me.TitleHeader.Size = New System.Drawing.Size(461, 35)
        Me.TitleHeader.TabIndex = 4
        Me.TitleHeader.Text = "<TitelHeader>"
        Me.TitleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'templateFormDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 377)
        Me.Controls.Add(Me.LayoutButton)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.LookAndFeel.SkinName = "Liquid Sky"
        Me.Name = "templateFormDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "School Healthy Management System"
        CType(Me.LayoutButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutButton.ResumeLayout(False)
        CType(Me.LayoutControlGroupButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TitleHeader As gLabel.gLabel
    Friend WithEvents LayoutButton As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnReset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroupButton As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
End Class
