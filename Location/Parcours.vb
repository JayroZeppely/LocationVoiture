Public Class Parcours

    Public Event AfficherAnnonce()
    Public Event OuvrirReservation()
    Private Sub Recherche_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles Btn_reserver.Click
        RaiseEvent OuvrirReservation()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub photo_exemple2_Click(sender As Object, e As EventArgs) Handles photo_exemple2.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles photo_exemple1.Click

    End Sub

    Private Sub TableLayoutPanel1_MouseClick(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel1.MouseClick
        RaiseEvent AfficherAnnonce()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class