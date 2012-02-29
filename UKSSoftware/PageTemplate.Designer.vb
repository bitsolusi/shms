<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageTemplate
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PageTemplate))
        Dim CBlendItems1 As gLabel.cBlendItems = New gLabel.cBlendItems
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TitleHeader = New gLabel.gLabel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.TitleHeader)
        Me.Panel1.Location = New System.Drawing.Point(11, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 91)
        Me.Panel1.TabIndex = 0
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
        Me.TitleHeader.GlowColor = System.Drawing.Color.AliceBlue
        Me.TitleHeader.Location = New System.Drawing.Point(45, 23)
        Me.TitleHeader.MouseOver = False
        Me.TitleHeader.Name = "TitleHeader"
        Me.TitleHeader.PulseSpeed = 25
        Me.TitleHeader.Size = New System.Drawing.Size(461, 35)
        Me.TitleHeader.TabIndex = 3
        Me.TitleHeader.Text = "<Head Title>"
        Me.TitleHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PageTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PageTemplate"
        Me.Size = New System.Drawing.Size(990, 428)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TitleHeader As gLabel.gLabel

End Class
