Public Class Config
    Public Shared Sub init()
        My.Settings.Reload()
        'store to session
        Session.dbname = My.Settings.dbname
        Session.dbhost = My.Settings.dbhost
        Session.dbuser = My.Settings.dbuser
        Session.dbpassword = My.Settings.dbpassword
        Session.dbport = My.Settings.dbport
    End Sub
End Class
