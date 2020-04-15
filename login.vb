Imports System.Data.SqlClient

Public Class login

    Private userID As Integer

    Public Function getUserID()
        Return userID
    End Function

    Private Sub Linknovo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linknovo.LinkClicked
        novoregisto.Show()
        Me.Hide()
    End Sub

    Private Sub Linkpass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Linkpass.LinkClicked
        validaruser.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fastfood.mdf;Integrated Security=True;Connect Timeout=30")
        connection.Open()
        Dim command As New SqlCommand("select * from users_perfil where UserId = '" & usertxt.Text & "' and Password = '" & passtxt.Text & "'", connection)
        Dim adpater As New SqlDataAdapter(command)
        Dim DataTable As New DataTable()
        adpater.Fill(DataTable)
        If DataTable.Rows.Count <> 0 Then
            Dim DataRow As DataRow = DataTable.Rows(0)
            userID = DataRow("cargo_Id")
            MsgBox(" Login com sucesso ")
            usertxt.Text = ""
            passtxt.Text = ""
            Me.Hide()
            menuprincipal.Show()
        ElseIf passtxt.Text = "" Or usertxt.Text = "" Then
            MsgBox("Nome de Utilizador ou password errados")
            passtxt.Text = ""
            usertxt.Text = ""
            usertxt.Select()
        Else
            MsgBox("Nome de Utilizador ou password errados")
            passtxt.Text = ""
            usertxt.Text = ""
            usertxt.Select()
        End If
        connection.Close()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usertxt.Select()
    End Sub
End Class
