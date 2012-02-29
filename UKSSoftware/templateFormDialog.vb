Public Class templateFormDialog 
    Public Property TitleHead() As String
        Get
            Return TitleHeader.Text
        End Get
        Set(ByVal value As String)
            TitleHeader.Text = value
        End Set
    End Property
    Private retdelete As Boolean
    Public Property ExecDelete() As Boolean
        Get
            Return retdelete
        End Get
        Set(ByVal value As Boolean)
            retdelete = value
        End Set
    End Property
    Overridable Function validationTambah() As Boolean
        Return validationTambah
    End Function
    Overridable Function validationHapus() As Boolean
        Return validationHapus
    End Function
    Overridable Sub SetTambah()
        If Not validationTambah() Then
            MsgBox("Maaf Data Entry Tidak Valid")
            Exit Sub
        End If
    End Sub
    Overridable Sub SetHapus()
        If Not validationTambah() Then
            MsgBox("Maaf Data Entry Tidak Valid")
            Exit Sub
        End If
    End Sub
    Overridable Sub SetSimpan()
        'If retdelete Then
        '    If Not validationHapus() Then
        '        MsgBox("Maaf Data Entry Tidak Valid")
        '        Exit Sub
        '    End If
        'Else
        '    If Not validationTambah() Then
        '        MsgBox("Maaf Data Entry Tidak Valid")
        '        Exit Sub
        '    End If
        'End If



    End Sub
    Overridable Sub SetReset()

    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        SetReset()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        SetSimpan()
    End Sub
End Class