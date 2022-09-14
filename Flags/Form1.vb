Public Class Form1
    Private Sub picUSA_Click(sender As Object, e As EventArgs) Handles picUSA.Click
        ' Display Los Angeles
        lblMessage.Text = "Los Angeles"
    End Sub

    Private Sub picCanada_Click(sender As Object, e As EventArgs) Handles picCanada.Click
        ' Display Toronto
        lblMessage.Text = "Toronto"
    End Sub

    Private Sub picUK_Click(sender As Object, e As EventArgs) Handles picUK.Click
        ' Display London
        lblMessage.Text = "London"
    End Sub

    Private Sub picAustralia_Click(sender As Object, e As EventArgs) Handles picAustralia.Click
        ' Display Sydney
        lblMessage.Text = "Sydney"
    End Sub

    Private Sub picBrazil_Click(sender As Object, e As EventArgs) Handles picBrazil.Click
        ' Display São Paulo
        lblMessage.Text = "São Paulo"
    End Sub

    Private Sub picItaly_Click(sender As Object, e As EventArgs) Handles picItaly.Click
        ' Display Rome
        lblMessage.Text = "Rome"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the form
        Me.Close()
    End Sub
End Class
