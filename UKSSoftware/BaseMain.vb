Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.UserSkins
Imports DevExpress.Skins

Public Class BaseMain
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        SkinManager.Default.RegisterAssembly(GetType(DevExpress.UserSkins.BonusSkins).Assembly)
        InitializeComponent()
        

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub



    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Private Function IndexOf(ByVal itemsCollection As ListBoxItemCollection, ByVal s As String) As Integer
        For i As Integer = 0 To itemsCollection.Count - 1
            If itemsCollection(i).ToString() = s Then
                Return i
            End If
        Next i
        Return -1
    End Function
    'Private Sub listBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    MenuGroup.View = TryCast(sender.SelectedItem, DevExpress.XtraNavBar.ViewInfo.BaseViewInfoRegistrator)
    '    MenuGroup.ResetStyles()
    'End Sub
    Private Sub BaseMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'Application.EnableVisualStyles()
        CreateMenu()
        Dim listBox1 As New DevExpress.XtraEditors.ListBoxControl
        'AddHandler listBox1.SelectedIndexChanged, AddressOf listBox1_SelectedIndexChanged
        listBox1.Height = 356
        listBox1.Items.AddRange(TryCast(MenuGroup.AvailableNavBarViews.ToArray(GetType(Object)), Object()))
        listBox1.SelectedItem = "Skin:Liquid Sky"
        listBox1.SelectedIndex = IndexOf(listBox1.Items, "Skin:Liquid Sky")
        MenuGroup.View = TryCast(listBox1.SelectedItem, DevExpress.XtraNavBar.ViewInfo.BaseViewInfoRegistrator)

        MenuGroup.ResetStyles()
        DefaultLookAndFeel1.LookAndFeel.SkinName = "Liquid Sky"
    End Sub

    Private Sub CreateMenu()
        Dim dtmenu As New DataTable
        If Utils.executeSP("proc_z_getrolemenu", New Object() {"role", Session.kodeRole}, dtmenu) Then
            'If executeSP("proc_z_getmenuform", New Object() {"get"}, dsmenu) Then
            If dtmenu.Rows.Count > 0 Then
                If Utils.RowExist(dtmenu) Then
                    Dim dtgroup As New DataTable
                    Try
                        dtgroup = dtmenu.Select("header = 0").CopyToDataTable
                    Catch ex As Exception

                    End Try
                    For Each r As DataRow In dtgroup.Rows
                        Dim navBarGroup As DevExpress.XtraNavBar.NavBarGroup = MenuGroup.Groups.Add()

                        navBarGroup.Caption = r("menuname").ToString
                        navBarGroup.Name = r("menuid").ToString

                        Dim dtdetail As New DataTable
                        Try
                            dtdetail = dtmenu.Select("header = '" & navBarGroup.Name & "'").CopyToDataTable
                        Catch ex As Exception

                        End Try
                        If Utils.RowExist(dtdetail) Then
                            For Each rd As DataRow In dtdetail.Rows
                                Dim item As DevExpress.XtraNavBar.NavBarItem = MenuGroup.Items.Add()
                                item.SmallImageIndex = rd("imageid")
                                'item.LargeImageIndex = item.SmallImageIndex
                                'i += 1
                                item.Caption = rd("menuname").ToString
                                item.Name = rd("menuid").ToString
                                item.Tag = rd("formname").ToString
                                AddHandler item.LinkClicked, AddressOf SelectedMenu_OnClick
                                navBarGroup.ItemLinks.Add(item)
                                navBarGroup.Expanded = True
                                'ExistSelectedItemLink()
                            Next

                        End If
                        'ChangeGroups()
                    Next


                End If
            End If
        End If
    End Sub
    Private Function DynamicallyLoadedObject(ByVal objectName As String, Optional ByVal args() As Object = Nothing) As Form
        Dim returnObj As Object = Nothing
        Dim ProjectName As String = Reflection.Assembly.GetExecutingAssembly.GetName.Name
        Dim Type As Type = Reflection.Assembly.GetExecutingAssembly().GetType(ProjectName & "." & objectName)
        If Type IsNot Nothing Then
            returnObj = Activator.CreateInstance(Type, args)
        End If
        Return returnObj
    End Function
    Private Sub ShowForm(ByVal FormName As String, ByVal IsDialog As Boolean)
        Dim f As Form = DynamicallyLoadedObject(FormName)
        If IsDialog = True Then
            For Each ChildForm As Form In Me.MdiChildren
                'If ChildForm.Name = f.Name Then
                ChildForm.Close()
                'End If
            Next

            f.MdiParent = Me
            'f.Top = 0
            'f.Left = 0

            f.Show()
            'f.BringToFront()
        Else
            MessageBox.Show("Menu tidak ditemukan", "Error", MessageBoxButtons.OK)

        End If
    End Sub
    Public Sub CloseForm(ByVal FormName As String)
        'Dim f As Form = DynamicallyLoadedObject(FormName)
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name = FormName Then
                ChildForm.Close()
            End If
        Next
    End Sub
    Private Function GetControl(ByVal objectName As String, Optional ByVal args() As Object = Nothing) As Control
        Dim returnObj As Object = Nothing
        Dim ProjectName As String = Reflection.Assembly.GetExecutingAssembly.GetName.Name
        Dim Type As Type = Reflection.Assembly.GetExecutingAssembly().GetType(ProjectName & "." & objectName)
        If Type IsNot Nothing Then
            returnObj = Activator.CreateInstance(Type, args)
        End If
        Return returnObj
    End Function

    Private Sub SelectedMenu_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim item As DevExpress.XtraNavBar.NavBarItem
        item = CType(sender, DevExpress.XtraNavBar.NavBarItem)
        ' ShowForm(item.Tag, True)
        Me.pnlUtama.Controls.Clear()
        Dim ctl As New PageTemplate
        ctl = GetControl(item.Tag)
        ctl.Size = pnlUtama.Size
        ctl.TitleHeader.Text = item.Caption.ToString
        Me.pnlUtama.Controls.Add(ctl)
        Me.pnlUtama.Refresh()
    End Sub

    Private Sub BaseMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub pnlUtama_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For Each ctl As Control In pnlUtama.Controls
            If ctl.Name.StartsWith("Form") Then
                ctl.Size = pnlUtama.Size
            End If
        Next
    End Sub
End Class
