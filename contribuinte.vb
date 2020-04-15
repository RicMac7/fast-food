Public Class contribuinte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menuprincipal.pedidoreal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        menuprincipal.Show()
    End Sub

    Private Sub contribuinte_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        menuprincipal.Show()
    End Sub

    Private Sub contribuinte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub
End Class