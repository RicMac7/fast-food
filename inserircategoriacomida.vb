Public Class inserircategoriacomida
    Private Sub ComidaCategoriaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ComidaCategoriaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ComidaCategoriaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FastfoodDataSet)

    End Sub

    Private Sub inserircategoriacomida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FastfoodDataSet.comidaCategoria' table. You can move, or remove it, as needed.
        Me.ComidaCategoriaTableAdapter.Fill(Me.FastfoodDataSet.comidaCategoria)

    End Sub
End Class