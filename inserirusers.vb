Public Class inserirusers
    Private Sub Users_perfilBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Users_perfilBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Users_perfilBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FastfoodDataSet)

    End Sub

    Private Sub inserirusers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FastfoodDataSet.Users_perfil' table. You can move, or remove it, as needed.
        Me.Users_perfilTableAdapter.Fill(Me.FastfoodDataSet.Users_perfil)

    End Sub
End Class