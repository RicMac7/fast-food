Imports System.Data.SqlClient

Public Class menuprincipal

    Dim connection As SqlConnection
    Dim sqlCommand As SqlCommand
    Dim dataAdaptor As New SqlDataAdapter
    Dim dataTable As DataTable
    Dim panelPictureBoxArray() As PictureBox
    Dim panelLableItemArray() As Label
    Dim panelAddButtonArray() As Button
    Dim panelRemoveButtonArray() As Button
    Dim customerId As Integer
    Dim orderDataDictionary As Dictionary(Of Integer, Integer)
    Const Tax_Rate = 0.13
    Dim subTotal As Decimal
    Dim tax As Decimal
    Dim total As Decimal
    Dim comidas As String

    Private Sub menuprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectPath As String = Application.StartupPath.ToString() + "\i-meal.mdf"
        Dim connectString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fastfood.mdf;Integrated Security=True;Connect Timeout=30"
        connection = New SqlConnection(connectString)
        connection.Open()
        panelPictureBoxArray = {pic1, pic2, pic3, pic4}
        panelAddButtonArray = {btadd1, btadd2, btadd3, btadd4}
        panelRemoveButtonArray = {btremove1, btremove2, btremove3, btremove4}
        panelLableItemArray = {lblItem1, lblItem2, lblItem3, lblItem4, lblItem5, lblItem6, lblItem7, lblItem8}
        grelhasumario.ColumnCount = 3
        grelhasumario.ColumnHeadersVisible = True
        grelhasumario.RowHeadersVisible = False
        grelhasumario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grelhasumario.Columns(0).Name = "User ID"
        grelhasumario.Columns(0).FillWeight = 60
        grelhasumario.Columns(1).Name = "Qtd"
        grelhasumario.Columns(1).FillWeight = 50
        grelhasumario.Columns(2).Name = "Nome Item"
        grelhasumario.Columns(2).FillWeight = 150
        grelhatotal.ColumnCount = 2
        grelhatotal.ColumnHeadersVisible = False
        grelhatotal.RowHeadersVisible = False
        grelhatotal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        iniciarvariaveis()
        DisplayFoodCategory(1)
        customerId = login.getUserID
    End Sub

    Private Sub menuprincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        login.Show()
    End Sub

    Private Sub btmenus_Click(sender As Object, e As EventArgs) Handles btmenus.Click
        DisplayFoodCategory(1)
    End Sub

    Private Sub bthamburgers_Click(sender As Object, e As EventArgs) Handles bthamburgers.Click
        DisplayFoodCategory(2)
    End Sub

    Private Sub bebidas_Click(sender As Object, e As EventArgs) Handles bebidas.Click
        DisplayFoodCategory(3)
    End Sub

    Private Sub btsaladas_Click(sender As Object, e As EventArgs) Handles btsaladas.Click
        DisplayFoodCategory(4)
    End Sub

    Private Sub btbatatas_Click(sender As Object, e As EventArgs) Handles btbatatas.Click
        DisplayFoodCategory(5)
    End Sub

    Private Sub btsobremesas_Click(sender As Object, e As EventArgs) Handles btsobremesas.Click
        DisplayFoodCategory(6)
    End Sub

    Private Sub DisplayFoodCategory(ByVal categoryID As Integer)
        sqlCommand = New SqlCommand("SELECT * FROM comida WHERE comida_Cat_id = @id", connection)
        sqlCommand.Parameters.Add("@id", SqlDbType.Int)
        sqlCommand.Parameters("@id").Value = categoryID
        dataAdaptor.SelectCommand = sqlCommand
        Dim cmdBuilder As New SqlCommandBuilder(dataAdaptor)
        dataTable = New DataTable
        dataAdaptor.Fill(dataTable)
        '"0" + displayedIndex.ToString +'
        For index As Integer = 0 To (dataTable.Rows.Count - 1)
            Dim foodInfo As DataRow = dataTable.Rows(index)
            panelPictureBoxArray(index).SizeMode = PictureBoxSizeMode.StretchImage
            panelPictureBoxArray(index).Image = Image.FromFile("C:\Users\Ricardo\Documents\Visual Studio 2019\McDonalds\McDonalds\imagens\" + foodInfo("ID").ToString + ".jpg")
            Dim displayedIndex As Integer = index + 1
            panelLableItemArray((index + 1) * 2 - 2).Text = " €" + Format(foodInfo("Preco"), "0.00").ToString
            panelLableItemArray((index + 1) * 2 - 1).Text = foodInfo("Nome")
            panelPictureBoxArray(index).Visible = True
            panelAddButtonArray(index).Visible = True
            panelRemoveButtonArray(index).Visible = True
            panelLableItemArray((index + 1) * 2 - 2).Visible = True
            panelLableItemArray((index + 1) * 2 - 1).Visible = True
        Next
        For index As Integer = dataTable.Rows.Count To 3
            panelPictureBoxArray(index).Visible = False
            panelAddButtonArray(index).Visible = False
            panelRemoveButtonArray(index).Visible = False
            panelLableItemArray((index + 1) * 2 - 2).Visible = False
            panelLableItemArray((index + 1) * 2 - 1).Visible = False
        Next
    End Sub

    Private Sub selectFood(ByVal index As Integer)
        Dim foodInfo As DataRow = dataTable.Rows(index)
        Dim foodId As Integer = foodInfo("ID")
        Dim value As Integer
        If orderDataDictionary.TryGetValue(foodId, value) Then
            orderDataDictionary(foodId) = value + 1
        Else
            orderDataDictionary.Add(foodId, 1)
        End If
        updateSummaryTable()
    End Sub

    Private Sub btadd1_Click(sender As Object, e As EventArgs) Handles btadd1.Click
        selectFood(0)
    End Sub

    Private Sub btadd2_Click(sender As Object, e As EventArgs) Handles btadd2.Click
        selectFood(1)
    End Sub

    Private Sub btadd3_Click(sender As Object, e As EventArgs) Handles btadd3.Click
        selectFood(2)
    End Sub

    Private Sub btadd4_Click(sender As Object, e As EventArgs) Handles btadd4.Click
        selectFood(3)
    End Sub

    Private Sub btremove1_Click(sender As Object, e As EventArgs) Handles btremove1.Click
        removeFood(0)
    End Sub

    Private Sub btremove2_Click(sender As Object, e As EventArgs) Handles btremove2.Click
        removeFood(1)
    End Sub

    Private Sub btremove3_Click(sender As Object, e As EventArgs) Handles btremove3.Click
        removeFood(2)
    End Sub

    Private Sub btremove4_Click(sender As Object, e As EventArgs) Handles btremove4.Click
        removeFood(3)
    End Sub

    Private Sub removeFood(ByVal index As Integer)
        Dim foodInfo As DataRow = dataTable.Rows(index)
        Dim foodId As Integer = foodInfo("ID")
        Dim value As Integer
        If orderDataDictionary.TryGetValue(foodId, value) Then
            If value <> 1 Then
                orderDataDictionary(foodId) = value - 1
            Else
                orderDataDictionary.Remove(foodId)
            End If
        End If
        updateSummaryTable()
    End Sub

    Private Sub updateSummaryTable()
        Dim totalex As Decimal
        grelhasumario.Rows.Clear()
        subTotal = 0
        comidas = ""
        totalex = 0
        For Each pair In orderDataDictionary
            subTotal += pair.Value * buscarprecocomida(pair.Key)
            totalex = (pair.Value * buscarprecocomida(pair.Key)) * Tax_Rate + (pair.Value * buscarprecocomida(pair.Key))
            grelhasumario.Rows.Add(customerId, pair.Value, buscarnomecomida(pair.Key))
            comidas += pair.Value.ToString + "x " + buscarnomecomida(pair.Key) + " " + Format(totalex, "0.00").ToString + "€" + Environment.NewLine
        Next
        tax = subTotal * Tax_Rate
        total = subTotal + tax
        grelhatotal.Rows.Clear()
        grelhatotal.Rows.Add("SubTotal: ", Format(subTotal, "0.00€"))
        grelhatotal.Rows.Add("IVA: ", Format(tax, "0.00€"))
        grelhatotal.Rows.Add("Total: ", Format(total, "0.00€"))
        grelhasumario.ClearSelection()
        grelhatotal.ClearSelection()
    End Sub

    Private Function buscarprecocomida(ByVal id)
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT * FROM comida WHERE ID = @id", connection)
        sqlCommand.Parameters.Add("@id", SqlDbType.Int)
        sqlCommand.Parameters("@id").Value = id
        dataAdaptor.SelectCommand = sqlCommand
        Dim cmdBuilder As New SqlCommandBuilder(dataAdaptor)
        Dim dataTable As New DataTable
        dataAdaptor.Fill(dataTable)
        Return dataTable.Rows(0)("Preco")
    End Function

    Private Function buscarnomecomida(ByVal id)
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT * FROM comida WHERE ID = @id", connection)
        sqlCommand.Parameters.Add("@id", SqlDbType.Int)
        sqlCommand.Parameters("@id").Value = id
        dataAdaptor.SelectCommand = sqlCommand
        Dim cmdBuilder As New SqlCommandBuilder(dataAdaptor)
        Dim dataTable As New DataTable
        dataAdaptor.Fill(dataTable)
        Return dataTable.Rows(0)("Nome")
    End Function

    Private Sub btpedido_Click(sender As Object, e As EventArgs) Handles btpedido.Click
        contribuinte.Show()
        Me.Hide()
    End Sub

    Public Function pedidoreal()
        If (orderDataDictionary.Count = 0) Then
            MsgBox("Tem que pedir algo primeiro")
            Return False
        Else
            Me.Hide()
            lbcontribuinte.Text = contribuinte.TextBox1.Text
            Dim transID As Integer = gerartransacaoID()
            Dim isInsertSuccessful
            isInsertSuccessful = inserirtransacao(transID, customerId, total, comidas, lbcontribuinte.Text)
            'For Each pair In orderDataDictionary
            '    If (Not inserirordemtransacao(transID, pair.Key, pair.Value)) Then
            '        isInsertSuccessful = False
            '    End If
            'Next
            'If isInsertSuccessful Then
            '    MsgBox("Pedido feito com sucesso")
            '    Me.Show()
            'Else
            '    MsgBox("falha no pedido")
            '    Me.Show()
            'End If
            iniciarvariaveis()
            contribuinte.Hide()
            recibo.Show()
            contribuinte.TextBox1.Clear()
            Return True
        End If
    End Function

    Private Function gerartransacaoID()
        Dim sqlCommand As SqlCommand = New SqlCommand("SELECT ID FROM [transacao] ORDER BY ID DESC", connection)
        dataAdaptor.SelectCommand = sqlCommand
        Dim cmdBuilder As New SqlCommandBuilder(dataAdaptor)
        Dim dataTable As New DataTable
        dataAdaptor.Fill(dataTable)
        If dataTable.Rows.Count = 0 Then
            Return 1
        Else
            Return dataTable.Rows(0)("ID") + 1
        End If
    End Function

    Private Function inserirtransacao(ByVal transID As Integer, ByVal userID As Integer, ByVal preco As Decimal, ByVal descricao As String, ByVal contribuinte As String)
        Dim sqlCommand As SqlCommand = New SqlCommand("INSERT INTO [transacao](ID, data, status, UserId, preco, descricao, contribuinte) VALUES (@transacao_id, @data, @status, @userId, @preco, @descricao, @contribuinte)", connection)
        sqlCommand.Parameters.Add("@transacao_id", SqlDbType.Int)
        sqlCommand.Parameters("@transacao_id").Value = transID
        sqlCommand.Parameters.Add("@data", SqlDbType.DateTime)
        sqlCommand.Parameters("@data").Value = DateAndTime.Now
        sqlCommand.Parameters.Add("@status", SqlDbType.VarChar)
        sqlCommand.Parameters("@status").Value = "Pago"
        sqlCommand.Parameters.Add("@userId", SqlDbType.Int)
        sqlCommand.Parameters("@userId").Value = userID
        sqlCommand.Parameters.Add("@preco", SqlDbType.Decimal)
        sqlCommand.Parameters("@preco").Value = preco
        sqlCommand.Parameters.Add("@descricao", SqlDbType.NVarChar)
        sqlCommand.Parameters("@descricao").Value = descricao
        sqlCommand.Parameters.Add("@contribuinte", SqlDbType.VarChar)
        sqlCommand.Parameters("@contribuinte").Value = contribuinte
        Dim rowsAffected As Integer = sqlCommand.ExecuteNonQuery()
        If (rowsAffected = 1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function inserirordemtransacao(ByVal transID As Integer, ByVal foodID As Integer, ByVal qty As Integer)
        Dim sqlCommand As SqlCommand = New SqlCommand("INSERT INTO ordemtransacao(Transacao_Id, comida_Id, quantidade) VALUES (@transacaoId, @comidaId, @qtd)", connection)
        sqlCommand.Parameters.Add("@transacaoId", SqlDbType.Int)
        sqlCommand.Parameters("@transacaoId").Value = transID
        sqlCommand.Parameters.Add("@comidaId", SqlDbType.Int)
        sqlCommand.Parameters("@comidaId").Value = foodID
        sqlCommand.Parameters.Add("@qtd", SqlDbType.Int)
        sqlCommand.Parameters("@qtd").Value = qty
        Dim rowsAffected As Integer = sqlCommand.ExecuteNonQuery()
        If (rowsAffected = 1) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btlimpar_Click(sender As Object, e As EventArgs) Handles btlimpar.Click
        iniciarvariaveis()
    End Sub

    Private Sub iniciarvariaveis()
        orderDataDictionary = New Dictionary(Of Integer, Integer)
        grelhasumario.Rows.Clear()
        grelhatotal.Rows.Clear()
        subTotal = 0
        tax = 0
        total = 0
        comidas = ""
    End Sub

End Class