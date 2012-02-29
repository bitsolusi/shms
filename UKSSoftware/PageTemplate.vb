Imports System.Windows.Forms

Public Class PageTemplate
    Public Property TitleHead() As String
        Get
            Return TitleHeader.Text
        End Get
        Set(ByVal value As String)
            TitleHeader.Text = value
        End Set
    End Property
End Class
