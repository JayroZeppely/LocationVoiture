Public Class Reservation

    Public Event FermerReservation()
    Public Event OuvrirRecherche()
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Reservation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RaiseEvent FermerReservation()
    End Sub

    Private Sub Btn_confirmer_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_confirmer.MouseClick
        RaiseEvent OuvrirRecherche()
    End Sub
End Class