Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text <> "" Then
            If PasswordTextBox.Text <> "" Then
                Dim dt As New DataTable
                If Utils.executeSP("proc_petugas", New Object() {"selectlogin", UsernameTextBox.Text, PasswordTextBox.Text, "0", "0", "0", "0"}, dt) Then
                    If dt.Rows.Count > 0 Then
                        Session.username = dt.Rows(0)("username") 
                        Session.password = dt.Rows(0)("pass")
                        Session.kodeRole = dt.Rows(0)("koderole")
                        LocalSession.operatorname = dt.Rows(0)("username")
                        LocalSession.operatorrole = dt.Rows(0)("role")
                        'TOFIX : ini spy cepet aja
                        'Dim dtN As New DataTable
                        'If Utils.executeSP("proc_master_profil", New Object() {"select", Convert.DBNull, Convert.DBNull, Convert.DBNull, Convert.DBNull}, dtN) Then
                        '    If dtN IsNot Nothing Then
                        '        If dtN.Rows.Count > 0 Then
                        '            LocalSession.namaresto = dtN.Rows(0)("nama")
                        '            LocalSession.alamatresto = dtN.Rows(0)("alamat")
                        '            LocalSession.telpresto = dtN.Rows(0)("telepon")
                        '            LocalSession.faxrest = dtN.Rows(0)("fax")
                        '        Else
                        '            LocalSession.namaresto = ""
                        '            LocalSession.alamatresto = ""
                        '            LocalSession.telpresto = ""
                        '            LocalSession.faxrest = ""
                        '        End If
                        '    Else
                        '        LocalSession.namaresto = ""
                        '        LocalSession.alamatresto = ""
                        '        LocalSession.telpresto = ""
                        '        LocalSession.faxrest = ""
                        '    End If
                        'End If


                        LocalSession.isLoggedIn = True

                        UsernameTextBox.Text = ""
                        PasswordTextBox.Text = ""

                        BaseMain.Show()
                        Me.Visible = False

                       
                    Else
                        MessageBox.Show("Username atau password salah. Silahkan coba lagi.")
                    End If
                End If
            Else
                MessageBox.Show("Password belum diisi.")
            End If
        Else
            MessageBox.Show("Username belum diisi.")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Config.init()
    End Sub
End Class
