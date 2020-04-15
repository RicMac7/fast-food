Public Class recibo
    Private Sub recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FastfoodDataSet.transacao' table. You can move, or remove it, as needed.
        Me.TransacaoTableAdapter.Fill(Me.FastfoodDataSet.transacao)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub recibo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        login.Show()
    End Sub
End Class