Public Class Init

    Public Event NextWindow()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_search.Click
        RaiseEvent NextWindow()
    End Sub
End Class
