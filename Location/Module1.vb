Module Module1

    Public etat As String

    Public WithEvents init As New Init
    Public WithEvents search As New Recherche

    Public Sub Main()
        etat = "Init"
        init.Show()
        search.Hide()
    End Sub

    Private Sub Init_nextwindow() Handles Init.NextWindow
        Select Case etat
            Case "Init"
                etat = "Recherche"
                init.Hide()
                search.Show()
            Case "Search"
                'interdit
            Case "Selection"
                'interdit
            Case "Reserver"
                'interdit
        End Select
    End Sub

End Module
