Public Class Recherche

    Public Event LancerRecherche()
    Public Event AdvancedOptions()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_search.Click
        RaiseEvent LancerRecherche()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles manuelle.CheckedChanged

    End Sub

    Private Sub Label4_place_min_Click(sender As Object, e As EventArgs) Handles Label4_place_min.Click

    End Sub

    Private Sub Label_options_Click(sender As Object, e As EventArgs) Handles Label_options.Click
        RaiseEvent AdvancedOptions()
    End Sub
End Class
