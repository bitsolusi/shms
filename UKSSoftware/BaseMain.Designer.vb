<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseMain
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseMain))
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.MenuGroup = New DevExpress.XtraNavBar.NavBarControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        Me.object_58dfc26f_0203_41cd_8492_dced1ee5f086 = New DevExpress.XtraBars.Bar
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnMinimize = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnMaximize = New System.Windows.Forms.Button
        Me.TitleHeader = New gLabel.gLabel
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.grouppnlUtama = New DevExpress.XtraEditors.GroupControl
        Me.pnlUtama = New System.Windows.Forms.Panel
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.MenuGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grouppnlUtama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grouppnlUtama.SuspendLayout()
        Me.SuspendLayout()
        '
        'imageCollection1
        '
        Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.imageCollection1.ImageStream = CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.MenuGroup)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 94)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(247, 337)
        Me.PanelControl1.TabIndex = 12
        '
        'MenuGroup
        '
        Me.MenuGroup.ActiveGroup = Nothing
        Me.MenuGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuGroup.Location = New System.Drawing.Point(2, 2)
        Me.MenuGroup.LookAndFeel.SkinName = "Liquid Sky"
        Me.MenuGroup.Name = "MenuGroup"
        Me.MenuGroup.OptionsNavPane.ExpandedWidth = 201
        Me.MenuGroup.Size = New System.Drawing.Size(243, 241)
        Me.MenuGroup.SmallImages = Me.imageCollection1
        Me.MenuGroup.TabIndex = 13
        Me.MenuGroup.Text = "NavBarControl1"
        Me.MenuGroup.View = New DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Lilian")
        '
        'GroupControl1
        '
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(2, 243)
        Me.GroupControl1.LookAndFeel.SkinName = "Liquid Sky"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(243, 92)
        Me.GroupControl1.TabIndex = 12
        Me.GroupControl1.Text = "Information"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(247, 94)
        Me.SplitterControl1.LookAndFeel.SkinName = "Liquid Sky"
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(7, 337)
        Me.SplitterControl1.TabIndex = 14
        Me.SplitterControl1.TabStop = False
        '
        'object_58dfc26f_0203_41cd_8492_dced1ee5f086
        '
        Me.object_58dfc26f_0203_41cd_8492_dced1ee5f086.BarName = "Main Menu"
        Me.object_58dfc26f_0203_41cd_8492_dced1ee5f086.DockCol = 0
        Me.object_58dfc26f_0203_41cd_8492_dced1ee5f086.DockRow = 0
        Me.object_58dfc26f_0203_41cd_8492_dced1ee5f086.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.object_58dfc26f_0203_41cd_8492_dced1ee5f086.OptionsBar.AllowQuickCustomization = False
        Me.object_58dfc26f_0203_41cd_8492_dced1ee5f086.OptionsBar.DisableCustomization = True
        Me.object_58dfc26f_0203_41cd_8492_dced1ee5f086.OptionsBar.MultiLine = True
        Me.object_58dfc26f_0203_41cd_8492_dced1ee5f086.OptionsBar.UseWholeRow = True
        Me.object_58dfc26f_0203_41cd_8492_dced1ee5f086.Text = "Main Menu"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DisableCustomization = True
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Liquid Sky"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnMinimize)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnMaximize)
        Me.Panel1.Controls.Add(Me.TitleHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(697, 74)
        Me.Panel1.TabIndex = 18
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.LightCyan
        Me.btnMinimize.Location = New System.Drawing.Point(502, 22)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(57, 32)
        Me.btnMinimize.TabIndex = 34
        Me.btnMinimize.Text = "Min"
        Me.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.LightCyan
        Me.btnClose.Location = New System.Drawing.Point(628, 22)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(57, 32)
        Me.btnClose.TabIndex = 33
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaximize.ForeColor = System.Drawing.Color.LightCyan
        Me.btnMaximize.Location = New System.Drawing.Point(565, 22)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(57, 32)
        Me.btnMaximize.TabIndex = 32
        Me.btnMaximize.Text = "Max"
        Me.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'TitleHeader
        '
        Me.TitleHeader.BackColor = System.Drawing.Color.Transparent
        Me.TitleHeader.BorderWidth = 1.0!
        Me.TitleHeader.FillType = gLabel.gLabel.eFillType.Solid
        Me.TitleHeader.FillTypeLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.TitleHeader.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold)
        Me.TitleHeader.ForeColor = System.Drawing.Color.White
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.White, System.Drawing.Color.White}
        CBlendItems1.iPoint = New Single() {0.0!, 1.0!}
        Me.TitleHeader.ForeColorBlend = CBlendItems1
        Me.TitleHeader.Glow = 8
        Me.TitleHeader.GlowColor = System.Drawing.Color.LightBlue
        Me.TitleHeader.Location = New System.Drawing.Point(12, 19)
        Me.TitleHeader.MouseOver = False
        Me.TitleHeader.Name = "TitleHeader"
        Me.TitleHeader.PulseSpeed = 25
        Me.TitleHeader.Size = New System.Drawing.Size(461, 35)
        Me.TitleHeader.TabIndex = 2
        Me.TitleHeader.Text = "School Healty Management System"
        Me.TitleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.White
        Me.PanelControl2.Appearance.BorderColor = System.Drawing.Color.White
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseBorderColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 74)
        Me.PanelControl2.LookAndFeel.SkinName = "Liquid Sky"
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(697, 20)
        Me.PanelControl2.TabIndex = 0
        '
        'grouppnlUtama
        '
        Me.grouppnlUtama.Controls.Add(Me.pnlUtama)
        Me.grouppnlUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grouppnlUtama.Location = New System.Drawing.Point(254, 94)
        Me.grouppnlUtama.LookAndFeel.SkinName = "Glass Oceans"
        Me.grouppnlUtama.Name = "grouppnlUtama"
        Me.grouppnlUtama.Size = New System.Drawing.Size(443, 337)
        Me.grouppnlUtama.TabIndex = 28
        '
        'pnlUtama
        '
        Me.pnlUtama.AutoScroll = True
        Me.pnlUtama.BackColor = System.Drawing.Color.White
        Me.pnlUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUtama.Location = New System.Drawing.Point(2, 21)
        Me.pnlUtama.Margin = New System.Windows.Forms.Padding(15)
        Me.pnlUtama.Name = "pnlUtama"
        Me.pnlUtama.Size = New System.Drawing.Size(439, 314)
        Me.pnlUtama.TabIndex = 27
        '
        'BaseMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(697, 453)
        Me.Controls.Add(Me.grouppnlUtama)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "BaseMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BaseMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.MenuGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grouppnlUtama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grouppnlUtama.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Private WithEvents imageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents MenuGroup As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents object_58dfc26f_0203_41cd_8492_dced1ee5f086 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TitleHeader As gLabel.gLabel
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnMaximize As System.Windows.Forms.Button
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grouppnlUtama As DevExpress.XtraEditors.GroupControl
    Friend WithEvents pnlUtama As System.Windows.Forms.Panel

End Class
