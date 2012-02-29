Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data
Imports DevExpress.XtraEditors.Controls


Public Class FormEditDataSiswa
    Dim nis, nama, kodepos, alamat, notelp, tempatlahir, jnskelamin, namaayah, namaibu, kota, tanggallahir, catatan As String
    Public filename As String

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        cbJNSKELAMIN.Properties.TextEditStyle = TextEditStyles.DisableTextEditor

        Dim Coll As ComboBoxItemCollection = cbJNSKELAMIN.Properties.Items
        Try
            Coll.Add("Laki-Laki")
            Coll.Add("Perempuan")
        Finally
            Coll.EndUpdate()
        End Try

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim bf As New BinaryFormatter
        Dim ms As New MemoryStream
        Dim bytearr As Byte()
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
            alamat = vmemo

        Else

        End If
        If meCATATAN.Lines.Count > 0 Then
            ms = New MemoryStream
            bf.Serialize(ms, meCATATAN.Lines)
            bytearr = ms.ToArray
            Dim vmemo As String = String.Empty
            For i As Integer = 0 To meCATATAN.Lines.Count - 1
                vmemo += meCATATAN.Lines(i).ToString
                If i < meCATATAN.Lines.Count - 1 Then
                    vmemo += "\n"
                End If
            Next
            catatan = vmemo

        Else

        End If
        If MsgBox("Anda yakin ingin menambah data siswa dengan NIS : " & txtNIS.Text, MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            SimpanData("insert")
            Me.Close()
        Else
        End If
    End Sub

    Private Function imagetobyte(ByVal strGambar As String) As Byte()
        Dim imageArray As Byte()
        If strGambar = "" Then

            Dim originalImage As Image = ImageEdit1.Image
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

    Private Sub ClearInput()
        txtNIS.Text = Nothing
        txtNAMA.Text = Nothing
        txtKODEPOS.Text = Nothing
        meALAMAT.Text = Nothing
        txtNOTELP.Text = Nothing
        txtTEMPATLAHIR.Text = Nothing
        cbJNSKELAMIN.Text = Nothing
        txtNAMAAYAH.Text = Nothing
        txtNAMAIBU.Text = Nothing
        txtKOTA.Text = Nothing
        deTANGGALLAHIR.Text = Nothing
        meCATATAN.Text = Nothing
        ImageEdit1.Image = Nothing
        txtNIS.Properties.ReadOnly = False
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click

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

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim bf As New BinaryFormatter
        Dim ms As New MemoryStream
        Dim bytearr As Byte()
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
            alamat = vmemo
            'paramlis(6) = vmemo
        Else

        End If
        If meCATATAN.Lines.Count > 0 Then
            ms = New MemoryStream
            bf.Serialize(ms, meCATATAN.Lines)
            bytearr = ms.ToArray
            Dim vmemo As String = String.Empty
            For i As Integer = 0 To meCATATAN.Lines.Count - 1
                vmemo += meCATATAN.Lines(i).ToString
                If i < meCATATAN.Lines.Count - 1 Then
                    vmemo += "\n"
                End If
            Next
            catatan = vmemo            
        Else            
        End If
        If MsgBox("Anda yakin ingin mengubah data siswa dengan NIS : " & txtNIS.Text, MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            SimpanData("update")
            Me.Close()
        Else

        End If

    End Sub

    Private Sub inisial()
        nis = txtNIS.Text
        nama = txtNAMA.Text
        kodepos = txtKODEPOS.Text
        notelp = txtNOTELP.Text
        tempatlahir = txtTEMPATLAHIR.Text
        jnskelamin = cbJNSKELAMIN.Text.ToString
        namaayah = txtNAMAAYAH.Text
        namaibu = txtNAMAIBU.Text
        kota = txtKOTA.Text
        tanggallahir = deTANGGALLAHIR.DateTime.ToString("yyyy-MM-dd")
    End Sub

    Private Sub SimpanData(ByVal jnsSimpan As String)
        Dim strQuery As Object()
        Dim err As String = ""
        Dim foto As Byte()
        inisial()
        Dim dtResulExecute As New DataTable
        foto = imagetobyte(filename)

        strQuery = New Object() {jnsSimpan, nis, nama, alamat, kota, kodepos, jnskelamin, tempatlahir, tanggallahir, notelp, namaayah, namaibu, catatan, foto}


        If Utils.executeSP("proc_datasiswa", strQuery, dtResulExecute) Then
            If Utils.RowExist(dtResulExecute) Then
                'GridControl1.DataSource = dtsiswa
            End If
        End If
        'MsgBox(dtResulExecute(0)(0))
        Dim MsgResult As String = "Data Berhasil Disimpan"

        If MsgResult = "Data Berhasil Disimpan" Then
            MsgBox(MsgResult, MsgBoxStyle.Information, "Success")
            ClearInput()
        Else
            MsgBox("Gagal Simpan", MsgBoxStyle.Critical, "Error")
        End If

    End Sub


    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        ClearInput()
        SimpleButton3.Enabled = True
        SimpleButton1.Enabled = False
        SimpleButton2.Enabled = False
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim bf As New BinaryFormatter
        Dim ms As New MemoryStream
        Dim bytearr As Byte()
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
            alamat = vmemo
            'paramlis(6) = vmemo
        Else
            'paramlis(6) = Convert.DBNull
        End If
        If meCATATAN.Lines.Count > 0 Then
            ms = New MemoryStream
            bf.Serialize(ms, meCATATAN.Lines)
            bytearr = ms.ToArray
            Dim vmemo As String = String.Empty
            For i As Integer = 0 To meCATATAN.Lines.Count - 1
                vmemo += meCATATAN.Lines(i).ToString
                If i < meCATATAN.Lines.Count - 1 Then
                    vmemo += "\n"
                End If
            Next
            catatan = vmemo
            'paramlis(6) = vmemo
        Else
            'paramlis(6) = Convert.DBNull
        End If
        If MsgBox("Anda yakin ingin menghapus data siswa dengan NIS : " & txtNIS.Text, MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Ok Then
            SimpanData("delete")
            Me.Close()
        Else

        End If
        
    End Sub
End Class