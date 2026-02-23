Module Module1

    Public etat As String

    Public WithEvents Recherche As New Recherche
    Public WithEvents Parcours As New Parcours
    Public WithEvents Reservation As New Reservation

    Public Sub Main()
        etat = "Recherche"
        Recherche.Show()
        Parcours.Hide()
        Reservation.Hide()
    End Sub

    Private Sub C1() Handles Recherche.LancerRecherche
        Select Case etat
            Case "Recherche"
                If Recherche.adresse_depart.Text <> "" Then
                    etat = "Parcours"
                    Recherche.Hide()
                    Parcours.Show()
                    Reservation.Hide()
                Else
                    etat = "Recherche"
                End If
            Case "Adv_Recherche"
                If Recherche.adresse_depart.Text <> "" Then
                    etat = "Parcours"
                    Recherche.Hide()
                    Parcours.Show()
                    Reservation.Hide()
                Else
                    etat = "Adv_Recherche"
                End If
            Case "Parcours"
                'interdit
            Case "Selection"
                'interdit
            Case "Reservation"
                'interdit
        End Select
    End Sub

    Private Sub C2() Handles Parcours.AfficherAnnonce
        Select Case etat
            Case "Recherche"
                'interdit
            Case "Adv_Recherche"
                'interdit
            Case "Parcours"
                etat = "Selection"
                Parcours.annonce_detail.Visible = True
            Case "Selection"
                etat = "Selection"
                Parcours.annonce_detail.Visible = True
            Case "Reservation"
                'interdit
        End Select
    End Sub

    Private Sub C3() Handles Parcours.OuvrirReservation
        Select Case etat
            Case "Recherche"
                'interdit
            Case "Adv_Recherche"
                'interdit
            Case "Parcours"
                'interdit
            Case "Selection"
                etat = "Reservation"
                Recherche.Hide()
                Parcours.Show()
                Reservation.ShowDialog()
            Case "Reservation"
                'interdit
        End Select
    End Sub

    Private Sub C4() Handles Recherche.AdvancedOptions
        Select Case etat
            Case "Recherche"
                etat = "Adv_Recherche"
                If Recherche.options.Visible = False Then
                    Recherche.options.Visible = True
                    Recherche.Label_options.Text = "Options avancées 
             ▲"
                Else
                    Recherche.options.Visible = False
                    Recherche.Label_options.Text = "Options avancées 
             ▼"
                End If
            Case "Adv_Recherche"
                etat = "Recherche"
                If Recherche.options.Visible = False Then
                    Recherche.options.Visible = True
                    Recherche.Label_options.Text = "Options avancées 
             ▲"
                Else
                    Recherche.options.Visible = False
                    Recherche.Label_options.Text = "Options avancées 
             ▼"
                End If
            Case "Parcours"
                'interdit
            Case "Selection"
                'interdit
            Case "Reservation"
                'interdit
        End Select
    End Sub

    Private Sub C5() Handles Reservation.FermerReservation
        Select Case etat
            Case "Recherche"
                'interdit
            Case "Adv_Recherche"
                'interdit
            Case "Parcours"
                'interdit
            Case "Selection"
                'interdit
            Case "Reservation"
                etat = "Selection"
        End Select
    End Sub

    Private Sub C6() Handles Reservation.OuvrirRecherche
        Select Case etat
            Case "Recherche"
                'interdit
            Case "Adv_Recherche"
                'interdit
            Case "Parcours"
                'interdit
            Case "Selection"
                'interdit
            Case "Reservation"
                If (Reservation.date_debut_resa.Value <= Reservation.date_retour_resa.Value) Then
                    etat = "Recherche"
                    Recherche.options.Visible = False
                    Parcours.annonce_detail.Visible = False
                    Recherche.Show()
                    Parcours.Hide()
                    Reservation.Hide()
                Else
                    etat = "Reservation"
                End If
        End Select
    End Sub

End Module
