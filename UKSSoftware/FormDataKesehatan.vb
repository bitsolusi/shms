Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports System.Runtime.Serialization.Formatters.Binary

Public Class FormDataKesehatan
    Inherits PageTemplate
    Public filename As String

    Private Sub GetLoadDataSiswa(ByRef dtsiswa As DataTable)
        Dim strQuery As String()
        Dim err As String = ""
        strQuery = New String() {"*", "datasiswa", "nis", txtCARIID.Text}
        If Utils.executeSP("proc_searchallEqual", strQuery, dtsiswa) Then

        End If
    End Sub

    Private Function GetEquall(ByVal tablename As String, ByVal kriteria As String, ByVal value As String) As DataTable
        Dim dtretval As New DataTable
        Dim strQuery As String()
        Dim err As String = ""
        strQuery = New String() {"*", tablename, kriteria, value}
        If Utils.executeSP("proc_searchallEqual", strQuery, dtretval) Then

        End If
        Return dtretval
    End Function

    Private Function imagetobyte(ByVal imageBox As Control, ByVal strGambar As String) As Byte()
        Dim imageArray As Byte()
        If strGambar = "" Then
            Dim originalImage As Image
            originalImage = Nothing
            If TypeOf imageBox Is PictureBox Then
                Dim boximg As New PictureBox
                boximg = CType(imageBox, PictureBox)
                originalImage = boximg.Image
            ElseIf TypeOf imageBox Is ImageEdit Then
                Dim boximg As New ImageEdit
                boximg = CType(imageBox, ImageEdit)
                originalImage = boximg.Image
            End If

            If originalImage IsNot Nothing Then
                Using stream As IO.MemoryStream = New IO.MemoryStream()
                    originalImage.Save(stream, Imaging.ImageFormat.Jpeg)
                    imageArray = stream.ToArray
                End Using

            Else
                imageArray = Nothing
            End If
        Else
            imageArray = IO.File.ReadAllBytes(strGambar)
        End If
        Return imageArray
    End Function

    Public Sub Byte2Image(ByRef NewImage As Image, ByVal ByteArr() As Byte)
        '
        Dim ImageStream As MemoryStream
        Try

            If ByteArr.GetUpperBound(0) > 0 Then
                ImageStream = New MemoryStream(ByteArr)
                NewImage = Image.FromStream(ImageStream)
            Else
                NewImage = Nothing
            End If

        Catch ex As Exception

            NewImage = Nothing

        End Try

    End Sub

    Private Sub FillLayout(ByVal data As DataTable)

        For Each item As LayoutControlItem In LayoutControlGroup2.Items
            If TypeOf item.Control Is MemoEdit Then
                Dim ctlmemo As New MemoEdit
                ctlmemo = CType(item.Control, MemoEdit)
                Dim rch As New RichTextBox
                rch.Text = IIf(IsDBNull(data(0)(item.Control.Tag)), "", data(0)(item.Control.Tag))
                ctlmemo.Lines = rch.Lines
            ElseIf TypeOf item.Control Is TextEdit Then
                item.Control.Text = IIf(IsDBNull(data(0)(item.Control.Tag)), "", data(0)(item.Control.Tag))
            ElseIf TypeOf item.Control Is CheckEdit Then
                Dim chkedit As New CheckEdit
                chkedit = CType(item.Control, CheckEdit)
                chkedit.Checked = IIf(IsDBNull(data(0)(item.Control.Tag)), 0, data(0)(item.Control.Tag))
            End If
        Next
        If Not IsDBNull(data(0)(ImageEdit1.Tag)) Then
            Byte2Image(ImageEdit1.Image, data(0)(ImageEdit1.Tag))
        End If



    End Sub
    Private Sub ClearLayout()
        txtNIS.Text = ""
        txtNAMA.Text = ""
        ImageEdit1.Image = Nothing
        For Each item As LayoutControlItem In LayoutControlGroup2.Items
            If TypeOf item.Control Is TextEdit Then
                item.Control.Text = ""
            ElseIf TypeOf item.Control Is CheckEdit Then
                Dim chkedit As New CheckEdit
                chkedit = CType(item.Control, CheckEdit)
                chkedit.Checked = 0
            End If
        Next
    End Sub
    Private Function valueLayout(ByVal tagname As String) As Object
        Dim retval As Object
        retval = Nothing
        If tagname = "nis" Then
            retval = txtNIS.Text
        End If
        For Each item As LayoutControlItem In LayoutControlGroup2.Items
            If item.Control.Tag = tagname Then
                If TypeOf item.Control Is MemoEdit Then
                    Dim bf As New BinaryFormatter
                    Dim ms As New MemoryStream
                    Dim bytearr As Byte()
                    Dim meALAMAT As New MemoEdit
                    meALAMAT = CType(item.Control, MemoEdit)
                    If meALAMAT.Lines.Count > 0 Then
                        ms = New MemoryStream
                        bf.Serialize(ms, meALAMAT.Lines)
                        bytearr = ms.ToArray
                        Dim vmemo As String = String.Empty
                        For i As Integer = 0 To meALAMAT.Lines.Count - 1
                            vmemo += meALAMAT.Lines(i).ToString
                            If i < meALAMAT.Lines.Count - 1 Then
                                vmemo += "\n"
                            End If
                        Next
                        retval = vmemo
                    End If
                ElseIf TypeOf item.Control Is TextEdit Then
                    retval = item.Control.Text
                ElseIf TypeOf item.Control Is CheckEdit Then
                    Dim chkedit As New CheckEdit
                    chkedit = CType(item.Control, CheckEdit)
                    retval = chkedit.Checked.GetHashCode
                End If
            End If

        Next

        Return retval
    End Function
    Private Sub setControlAktif(ByVal aktif As Boolean)
        If aktif Then
            txtUMUR_INPUT.Properties.ReadOnly = False
            txtBB_INPUT.Properties.ReadOnly = False
            txtTB_INPUT.Properties.ReadOnly = False
            txtGolDarah.Properties.ReadOnly = False
            txtHobi.Properties.ReadOnly = False
            txtOLAHRAGA.Properties.ReadOnly = False
            cbMEROKOK.Properties.ReadOnly = False
            txtMULAI_MEROKOK.Properties.ReadOnly = False
            txtKONSUMSIROKOK.Properties.ReadOnly = False
            meCATATAN.Properties.ReadOnly = False
            btnSIMPAN.Enabled = True
            btnAMBIL_FOTO.Enabled = True
        Else
            txtUMUR_INPUT.Properties.ReadOnly = True
            txtBB_INPUT.Properties.ReadOnly = True
            txtTB_INPUT.Properties.ReadOnly = True
            txtGolDarah.Properties.ReadOnly = True
            txtHobi.Properties.ReadOnly = True
            txtOLAHRAGA.Properties.ReadOnly = True
            cbMEROKOK.Properties.ReadOnly = True
            txtMULAI_MEROKOK.Properties.ReadOnly = True
            txtKONSUMSIROKOK.Properties.ReadOnly = True
            meCATATAN.Properties.ReadOnly = True
            btnSIMPAN.Enabled = False
            btnAMBIL_FOTO.Enabled = False
        End If

    End Sub
    Private Sub btnCARI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCARI.Click
        Dim dtsiswa As New DataTable
        Dim dtkes As New DataTable
        ClearLayout()
        setControlAktif(False)
        GetLoadDataSiswa(dtsiswa)
        If Utils.RowExist(dtsiswa) Then

            txtNIS.Text = dtsiswa(0)(0)
            txtNAMA.Text = dtsiswa(0)(1)

            dtkes = GetEquall("datakesehatan", "nis", txtNIS.Text)
            If Utils.RowExist(dtkes) Then
                FillLayout(dtkes)
            Else
                Dim dtumur As New DataTable
                dtumur = GetEquall("vumursiswa", "nis", txtNIS.Text)
                If Utils.RowExist(dtumur) Then
                    txtUMUR_INPUT.Text = dtumur(0)("umur").ToString
                End If
            End If

            setControlAktif(True)
        Else
            MsgBox("Data Siswa Tidak Ditemukan.", MsgBoxStyle.OkOnly, "Informasi")
            Return
        End If
    End Sub


    Private Sub btnAMBIL_FOTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAMBIL_FOTO.Click

        OpenFileDialog1.InitialDirectory = "c:\"
        OpenFileDialog1.Filter = "JPEG (*.jpg) |*.jpg;*.jpe;*.jpeg | PNG (*.png)|*.png;*.png | GIF (*.gif)|*.gif;*.gif | BMP (*.bmp)|*.bmp;*.bmp |All files (*.*)|*.*" '"Word (*.doc) |*.doc;*.rtf|(*.txt) |*.txt|(*.*) |*.*" 

        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            filename = OpenFileDialog1.FileName
            Dim fz As UInt32 = 0
            Dim fs As IO.MemoryStream
            Try

                fs = New IO.MemoryStream(IO.File.ReadAllBytes(filename))
                fz = fs.Length
                If fz > 500000 Then
                    MsgBox("Maaf Maksimal Ukuran File = 1Mb(1.000.000 byte)")
                    Exit Sub
                End If
            Catch ex As Exception

            End Try

            ImageEdit1.ImageLocation = filename
            ImageEdit1.SizeMode = PictureBoxSizeMode.StretchImage
            ImageEdit1.Refresh()
        End If
    End Sub

    Private Sub btnSIMPAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSIMPAN.Click
        Dim strParam As String() = {"nis", "umur", "tinggibadan", "beratbadan", "golongandarah", _
                                  "hobi", "olahraga", "merokok", "mulaimerokok", "rokokperhari", _
                                  "catatanperiksagigi", "fotogigi"}
        Dim paramlist As New List(Of Object)
        Dim setvalue As Object
        setvalue = Nothing
        paramlist.Clear()
        For Each param As String In strParam
            If param = "fotogigi" Then
                Dim foto As Byte()
                foto = imagetobyte(ImageEdit1, filename)
                paramlist.Add(IIf(foto Is Nothing, Convert.DBNull, foto))
            Else
                setvalue = IIf(valueLayout(param) Is Nothing, Convert.DBNull, valueLayout(param))
                paramlist.Add(setvalue)
            End If
        Next

        Dim dtretval As New DataTable

        paramlist.Insert(0, "insert")
        If Utils.executeSP("proc_datakesehatan", paramlist.ToArray, dtretval) Then
            If Utils.RowExist(dtretval) Then
                If dtretval(0)(0).ToString = "Data is exists insert another data" Then
                    paramlist.Item(0) = "update"
                    If Utils.executeSP("proc_datakesehatan", paramlist.ToArray, dtretval) Then
                        MsgBox(dtretval(0)(0).ToString)
                        ClearLayout()
                        setControlAktif(False)
                    End If
                Else
                    MsgBox(dtretval(0)(0).ToString)
                    ClearLayout()
                    setControlAktif(False)
                End If
            End If
        End If


    End Sub

    Private Sub txtCARIID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCARIID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCARIID.Text = "" Then
                Exit Sub
            Else
                btnCARI_Click(sender, e)
            End If
        End If
        
    End Sub
End Class
