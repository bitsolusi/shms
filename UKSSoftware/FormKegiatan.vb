Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class FormKegiatan
    Inherits PageTemplate

    Dim istambah As Boolean = False
    Dim vID As String = ""
    Dim vTANGGAL As String = ""
    Dim vKEGIATAN As String = ""
    Dim vKETERANGAN As String = ""

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        clear_input_box()
    End Sub

    Private Sub clear_input_box()
        txtID.Properties.ReadOnly = False
        txtID.Text = ""
        txtKEGIATAN.Text = ""
        dePELAKSANAAN.Text = ""
        meKETERANGAN.Text = ""
        istambah = True
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim cek As String = "insert"
        Dim hasilcekinput As Boolean
        hasilcekinput = cekdata(cek)

        If hasilcekinput = False Then
            MsgBox("Entri Data Tidak Lengkap", MsgBoxStyle.Exclamation, "Informasi")
            Return
        End If

        Dim eksekusi As String = ""
        Dim keterangan As String = ""
        Dim bf As New BinaryFormatter
        Dim ms As New MemoryStream
        Dim bytearr As Byte()
        If meKETERANGAN.Lines.Count > 0 Then
            ms = New MemoryStream
            bf.Serialize(ms, meKETERANGAN.Lines)
            bytearr = ms.ToArray
            Dim vmemo As String = String.Empty
            For i As Integer = 0 To meKETERANGAN.Lines.Count - 1
                vmemo += meKETERANGAN.Lines(i).ToString
                If i < meKETERANGAN.Lines.Count - 1 Then
                    vmemo += "\n"
                End If
            Next
            keterangan = vmemo
        Else
        End If
        If istambah = True Then
            eksekusi = "insert"
        Else
            eksekusi = "update"
        End If

        SimpanData(eksekusi)
        load_data()
    End Sub

    Private Sub load_data()
        Dim dtkegiatan As New DataTable
        Dim strQuery As String()
        Dim err As String = ""
        strQuery = New String() {"*", "datakegiatan", "id", ""}
        If Utils.executeSP("proc_searchall", strQuery, dtkegiatan) Then
            'If Utils.RowExist(dtkegiatan) Then
            GridControl1.DataSource = dtkegiatan
            GridControl1.Refresh()
            GridControl1.RefreshDataSource()

            GridView1.RefreshData()
            'End If
        End If
    End Sub

    Private Sub SimpanData(ByVal jnsSimpan As String)
        Dim strQuery As Object()
        Dim err As String = ""
        inisial()
        Dim dtResulExecute As New DataTable
        Dim MsgResult As String = ""
        Dim ValResult As String = ""

        strQuery = New Object() {jnsSimpan, vID, vKEGIATAN, vTANGGAL, vKETERANGAN}
        If Utils.executeSP("proc_kegiatan", strQuery, dtResulExecute) Then
            If Utils.RowExist(dtResulExecute) Then
                MsgResult = dtResulExecute(0)(1)
                ValResult = dtResulExecute(0)(0)
            End If
        End If

        If ValResult = "1" Then
            MsgBox(MsgResult, MsgBoxStyle.Information, "Success")
            If istambah = True Then
                clear_input_box()
            End If
        Else
            MsgBox(MsgResult, MsgBoxStyle.Critical, "Gagal")
        End If

    End Sub

    Private Sub inisial()
        vID = txtID.Text
        vTANGGAL = dePELAKSANAAN.Text
        vKEGIATAN = txtKEGIATAN.Text
        vKETERANGAN = meKETERANGAN.Text
    End Sub

    Private Sub FormKegiatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Private Function cekdata(ByVal jnscek As String) As Boolean
        Dim hasilcek As Boolean = True
        If jnscek = "insert" Then
            If txtID.Text = "" Then Return False
            If txtKEGIATAN.Text = "" Then Return False
            If dePELAKSANAAN.Text = "" Then Return False
        ElseIf jnscek = "delete" Then
            If txtID.Text = "" Then Return False
        End If
        Return hasilcek
    End Function

    Private Sub GridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.Click
        Dim obj As DataRow
        Dim i As Integer
        txtID.Properties.ReadOnly = True
        istambah = False
        i = GridView1.FocusedRowHandle
        obj = GridView1.GetDataRow(i)
        txtID.Text = obj(0)
        txtKEGIATAN.Text = obj(1)
        dePELAKSANAAN.Text = obj(2).ToString
        meKETERANGAN.Text = obj(3)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim cek As String = "delete"
        Dim hasilcekinput As Boolean
        hasilcekinput = cekdata(cek)

        If hasilcekinput = False Then
            MsgBox("Entri Data Tidak Lengkap", MsgBoxStyle.Exclamation, "Informasi")
            Return
        End If

        Dim eksekusi As String = ""
        'If istambah = True Then
        eksekusi = "delete"
        SimpanData(eksekusi)
        'End If
        load_data()
    End Sub
End Class
