Public Class novoregisto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim cnn As New System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fastfood.mdf;Integrated Security=True;Connect Timeout=30")
        cnn.Open()
        CargoidTxt.Text = 2
        If UserIdTextBox.Text = "" Or NomeTextBox.Text = "" Or PasswordTextBox.Text = "" Or EmailTextBox.Text = "" Then
            MsgBox("Preencha todos os campos")
            EmailTextBox.Text = ""
            UserIdTextBox.Text = ""
            NomeTextBox.Text = ""
            PasswordTextBox.Text = ""
        ElseIf Label2.Text = "Iguais" Then
            Using cmd As New Data.SqlClient.SqlCommand("insert into users_perfil(Nome,cargo_id,password,email,UserId) values('" & NomeTextBox.Text & "','" & CargoidTxt.Text & "','" & PasswordTextBox.Text & "','" & EmailTextBox.Text & "','" & UserIdTextBox.Text & "')", cnn)
                    i = cmd.ExecuteNonQuery
                End Using
                If (i > 0) Then
                    MsgBox("Utilizador Criado com sucesso!!")
                    login.Show()
                    Me.Close()
                End If
            End If
            cnn.Close()
    End Sub

    Private Sub repitapasstxt_TextChanged(sender As Object, e As EventArgs) Handles repitapasstxt.TextChanged
        If PasswordTextBox.Text = repitapasstxt.Text Then
            Label2.Text = "Iguais"
            Label2.ForeColor = Color.Green
        Else
            Label2.Text = "diferentes"
            Label2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub novoregisto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        login.Show()
    End Sub
End Class