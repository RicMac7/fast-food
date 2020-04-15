Public Class inserircomida
    Private Sub ComidaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ComidaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ComidaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FastfoodDataSet)

    End Sub

    Private Sub inserircomida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FastfoodDataSet.Comida' table. You can move, or remove it, as needed.
        Me.ComidaTableAdapter.Fill(Me.FastfoodDataSet.Comida)

    End Sub
End Class