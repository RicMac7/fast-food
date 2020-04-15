Imports System.Data.SqlClient

Public Class validaruser

    Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fastfood.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub verificarbt_Click(sender As Object, e As EventArgs) Handles verificarbt.Click
        connection.Open()
        If UserIdTextBox.Text = "" Or NomeTextBox.Text = "" Or EmailTextBox.Text = "" Then
            MsgBox("Preencha todos os campos")
        Else
            Dim command As New SqlClient.SqlCommand(" SELECT * FROM users_perfil WHERE UserId='" & UserIdTextBox.Text & "' and Nome = '" & NomeTextBox.Text & "' and email = '" & EmailTextBox.Text & "'", connection)
            Dim adpater As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adpater.Fill(table)
            If table.Rows.Count() <= 0 Then
                MsgBox("Insira a informacao correta")
            Else
                MsgBox("Verificado")
                'Me.Height = 500
                verificarbt.Visible = False
                Label1.Visible = True
                Label2.Visible = True
                btpass.Visible = True
                PasswordTextBox.Visible = True
                confirmartxt.Visible = True
                NomeTextBox.Enabled = False
                UserIdTextBox.Enabled = False
                EmailTextBox.Enabled = False
            End If
        End If
        connection.Close()
    End Sub

    Private Sub validaruser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Height = 300
        UserIdTextBox.Select()
    End Sub

    Private Sub btpass_Click(sender As Object, e As EventArgs) Handles btpass.Click
        connection.Open()
        Dim i As Integer
        If PasswordTextBox.Text = "" Or confirmartxt.Text = "" Then
            MsgBox("insira a password")
        Else
            If PasswordTextBox.Text = confirmartxt.Text Then
                Using cmd As New SqlClient.SqlCommand("UPDATE users_perfil SET password = '" & PasswordTextBox.Text & "' WHERE UserId = '" & UserIdTextBox.Text & "' and Nome = '" & NomeTextBox.Text & "' and email='" & EmailTextBox.Text & "'", connection)
                    i = cmd.ExecuteNonQuery
                End Using
                If (i > 0) Then
                    MsgBox("Password alterada")
                    Me.Hide()
                    login.Show()
                Else
                    MsgBox("confirmação da password errada insira novamente")
                    PasswordTextBox.Text = ""
                    confirmartxt.Text = ""
                End If
            End If
        End If
        connection.Close()
    End Sub

    Private Sub validaruser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        login.Show()
    End Sub
End Class