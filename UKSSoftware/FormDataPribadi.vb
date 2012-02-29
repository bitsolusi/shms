Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports MySql.Data
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Views.Base.BaseView
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraTab
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base

Public Class FormDataPribadi
    Inherits PageTemplate

    Private Sub LoadDataSiswa(ByRef dtsiswa As DataTable)
        Dim strQuery As String()
        Dim err As String = ""
        strQuery = New String() {"*", "datasiswa", "nis", ""}
        If Utils.executeSP("proc_searchall", strQuery, dtsiswa) Then
            If Utils.RowExist(dtsiswa) Then
                GridControl1.DataSource = dtsiswa
                GridControl1.Refresh()
                GridControl1.RefreshDataSource()

                GridView1.RefreshData()
            End If
        End If
    End Sub

    Private Sub RefreshGrid()
        Dim dtsiswa As New DataTable
        LoadDataSiswa(dtsiswa)
        Dim item As New RepositoryItemPictureEdit()
        item.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        GridControl1.RepositoryItems.Add(item)
        If dtsiswa.Rows.Count > 0 Then
            GridView1.Columns("foto").ColumnEdit = item
        End If
        GridView1.OptionsBehavior.Editable = False
        GridView1.OptionsView.ShowGroupPanel = False
    End Sub

    Private Sub FormDataPribadi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

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

    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        'Dim dlg As FormEditDataSiswa = New FormEditDataSiswa()
        'Dim i As Integer
        'Dim obj As DataRow
        'Dim nis As String = ""
        'Dim nama As String = ""
        'Dim alamat As String = ""
        'Dim kota As String = ""
        'Dim kodepos As String = ""
        'Dim jeniskelamin As String = ""
        'Dim tempatlahir As String = ""
        'Dim tanggallahir As String = ""
        'Dim notelp As String = ""
        'Dim namaayah As String = ""
        'Dim namaibu As String = ""
        'Dim catatan As String = ""

        'Dim imagebaru As Image
        'imagebaru = Nothing
        'If GridView1.RowCount > 0 Then
        '    i = GridView1.FocusedRowHandle
        '    obj = GridView1.GetDataRow(i)
        '    nis = obj("nis").ToString
        '    nama = obj("nama").ToString
        '    alamat = obj("alamat").ToString
        '    kota = obj("kota").ToString
        '    kodepos = obj("kodepos").ToString
        '    jeniskelamin = obj("jeniskelamin").ToString
        '    tempatlahir = obj("tempatlahir").ToString
        '    tanggallahir = obj("tanggallahir").ToString
        '    notelp = obj("notelp").ToString
        '    namaayah = obj("namaayah").ToString
        '    namaibu = obj("namaibu").ToString
        '    catatan = obj("catatan").ToString
        '    Byte2Image(imagebaru, obj("foto"))
        'End If
        'dlg.txtNIS.Text = nis
        'dlg.txtNAMA.Text = nama
        'dlg.txtKODEPOS.Text = kodepos
        'dlg.meALAMAT.Text = alamat
        'dlg.txtNOTELP.Text = notelp
        'dlg.txtTEMPATLAHIR.Text = tempatlahir
        'dlg.cbJNSKELAMIN.Text = jeniskelamin
        'dlg.txtNAMAAYAH.Text = namaayah
        'dlg.txtNAMAIBU.Text = namaibu
        'dlg.txtKOTA.Text = kota
        'dlg.deTANGGALLAHIR.Text = tanggallahir
        'dlg.meCATATAN.Text = catatan
        'dlg.ImageEdit1.Image = imagebaru

        'If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        'End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim dlg As New FormEditSiswa
        dlg.exec = "tambah"
        dlg.setComboJK()
        dlg.ClearInput()
        dlg.ShowDialog()
        RefreshGrid()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim dlg As FormEditSiswa = New FormEditSiswa()
        Dim i As Integer
        Dim obj As DataRow
        Dim nis As String = ""
        Dim nama As String = ""
        'Dim alamat As String = ""
        Dim alamat As New RichTextBox
        Dim kota As String = ""
        Dim kodepos As String = ""
        Dim jeniskelamin As String = ""
        Dim tempatlahir As String = ""
        Dim tanggallahir As String = ""
        Dim notelp As String = ""
        Dim namaayah As String = ""
        Dim namaibu As String = ""
        Dim catatan As New RichTextBox

        Dim imagebaru As Image
        imagebaru = Nothing

        If GridView1.RowCount > 0 Then
            i = GridView1.FocusedRowHandle
            obj = GridView1.GetDataRow(i)
            nis = obj("nis").ToString
            nama = obj("nama").ToString
            alamat.Text = obj("alamat")
            kota = obj("kota").ToString
            kodepos = obj("kodepos").ToString
            jeniskelamin = obj("jeniskelamin").ToString
            tempatlahir = obj("tempatlahir").ToString
            tanggallahir = obj("tanggallahir").ToString
            notelp = obj("notelp").ToString
            namaayah = obj("namaayah").ToString
            namaibu = obj("namaibu").ToString
            catatan.Text = obj("catatan").ToString
            If Not IsDBNull(obj("foto")) Then
                Byte2Image(imagebaru, obj("foto"))
            End If

        End If
        dlg.txtNIS.Text = nis
        dlg.txtNAMA.Text = nama
        dlg.txtKODEPOS.Text = kodepos
        'Dim arralamat As String()
        'arralamat = alamat.Split(vbCrLf)

        dlg.meALAMAT.Lines = alamat.Lines
        dlg.txtNOTELP.Text = notelp
        dlg.txtTEMPATLAHIR.Text = tempatlahir
        dlg.cbJNSKELAMIN.Text = jeniskelamin
        dlg.txtNAMAAYAH.Text = namaayah
        dlg.txtNAMAIBU.Text = namaibu
        dlg.txtKOTA.Text = kota
        dlg.deTANGGALLAHIR.Text = tanggallahir
        dlg.meCATATAN.Lines = catatan.Lines
        dlg.ImageEdit1.Image = imagebaru
        dlg.exec = "edit"
        dlg.ShowDialog()
        RefreshGrid()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim dlg As FormEditSiswa = New FormEditSiswa()
        Dim i As Integer
        Dim obj As DataRow
        Dim nis As String = ""
        Dim nama As String = ""
        Dim alamat As String = ""
        Dim kota As String = ""
        Dim kodepos As String = ""
        Dim jeniskelamin As String = ""
        Dim tempatlahir As String = ""
        Dim tanggallahir As String = ""
        Dim notelp As String = ""
        Dim namaayah As String = ""
        Dim namaibu As String = ""
        Dim catatan As String = ""

        Dim imagebaru As Image
        imagebaru = Nothing

        If GridView1.RowCount > 0 Then
            i = GridView1.FocusedRowHandle
            obj = GridView1.GetDataRow(i)
            nis = obj("nis").ToString
            nama = obj("nama").ToString
            alamat = obj("alamat").ToString
            kota = obj("kota").ToString
            kodepos = obj("kodepos").ToString
            jeniskelamin = obj("jeniskelamin").ToString
            tempatlahir = obj("tempatlahir").ToString
            tanggallahir = obj("tanggallahir").ToString
            notelp = obj("notelp").ToString
            namaayah = obj("namaayah").ToString
            namaibu = obj("namaibu").ToString
            catatan = obj("catatan").ToString
            Byte2Image(imagebaru, obj("foto"))
        End If
        dlg.txtNIS.Text = nis
        dlg.txtNAMA.Text = nama
        dlg.txtKODEPOS.Text = kodepos
        dlg.meALAMAT.Text = alamat
        dlg.txtNOTELP.Text = notelp
        dlg.txtTEMPATLAHIR.Text = tempatlahir
        dlg.cbJNSKELAMIN.Text = jeniskelamin
        dlg.txtNAMAAYAH.Text = namaayah
        dlg.txtNAMAIBU.Text = namaibu
        dlg.txtKOTA.Text = kota
        dlg.deTANGGALLAHIR.Text = tanggallahir
        dlg.meCATATAN.Text = catatan
        dlg.ImageEdit1.Image = imagebaru
        dlg.exec = "hapus"
        dlg.ShowDialog()
        RefreshGrid()
    End Sub
End Class
