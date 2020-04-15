<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inserircomida
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inserircomida))
        Dim IDLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim PrecoLabel As System.Windows.Forms.Label
        Dim Comida_cat_idLabel As System.Windows.Forms.Label
        Me.FastfoodDataSet = New McDonalds.fastfoodDataSet()
        Me.ComidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComidaTableAdapter = New McDonalds.fastfoodDataSetTableAdapters.ComidaTableAdapter()
        Me.TableAdapterManager = New McDonalds.fastfoodDataSetTableAdapters.TableAdapterManager()
        Me.ComidaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ComidaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.PrecoTextBox = New System.Windows.Forms.TextBox()
        Me.Comida_cat_idTextBox = New System.Windows.Forms.TextBox()
        Me.ComidaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        PrecoLabel = New System.Windows.Forms.Label()
        Comida_cat_idLabel = New System.Windows.Forms.Label()
        CType(Me.FastfoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComidaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComidaBindingNavigator.SuspendLayout()
        CType(Me.ComidaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FastfoodDataSet
        '
        Me.FastfoodDataSet.DataSetName = "fastfoodDataSet"
        Me.FastfoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComidaBindingSource
        '
        Me.ComidaBindingSource.DataMember = "Comida"
        Me.ComidaBindingSource.DataSource = Me.FastfoodDataSet
        '
        'ComidaTableAdapter
        '
        Me.ComidaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.comidaCategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ComidaTableAdapter = Me.ComidaTableAdapter
        Me.TableAdapterManager.ordemTransacaoTableAdapter = Nothing
        Me.TableAdapterManager.transacaoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = McDonalds.fastfoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_categoriaTableAdapter = Nothing
        Me.TableAdapterManager.Users_perfilTableAdapter = Nothing
        '
        'ComidaBindingNavigator
        '
        Me.ComidaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ComidaBindingNavigator.BindingSource = Me.ComidaBindingSource
        Me.ComidaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ComidaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ComidaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ComidaBindingNavigatorSaveItem})
        Me.ComidaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ComidaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ComidaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ComidaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ComidaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ComidaBindingNavigator.Name = "ComidaBindingNavigator"
        Me.ComidaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ComidaBindingNavigator.Size = New System.Drawing.Size(571, 25)
        Me.ComidaBindingNavigator.TabIndex = 0
        Me.ComidaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ComidaBindingNavigatorSaveItem
        '
        Me.ComidaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ComidaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ComidaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ComidaBindingNavigatorSaveItem.Name = "ComidaBindingNavigatorSaveItem"
        Me.ComidaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ComidaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(246, 52)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComidaBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(325, 49)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(246, 78)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComidaBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(325, 75)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'PrecoLabel
        '
        PrecoLabel.AutoSize = True
        PrecoLabel.Location = New System.Drawing.Point(246, 104)
        PrecoLabel.Name = "PrecoLabel"
        PrecoLabel.Size = New System.Drawing.Size(38, 13)
        PrecoLabel.TabIndex = 5
        PrecoLabel.Text = "Preco:"
        '
        'PrecoTextBox
        '
        Me.PrecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComidaBindingSource, "Preco", True))
        Me.PrecoTextBox.Location = New System.Drawing.Point(325, 101)
        Me.PrecoTextBox.Name = "PrecoTextBox"
        Me.PrecoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecoTextBox.TabIndex = 6
        '
        'Comida_cat_idLabel
        '
        Comida_cat_idLabel.AutoSize = True
        Comida_cat_idLabel.Location = New System.Drawing.Point(246, 130)
        Comida_cat_idLabel.Name = "Comida_cat_idLabel"
        Comida_cat_idLabel.Size = New System.Drawing.Size(73, 13)
        Comida_cat_idLabel.TabIndex = 7
        Comida_cat_idLabel.Text = "comida cat id:"
        '
        'Comida_cat_idTextBox
        '
        Me.Comida_cat_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComidaBindingSource, "comida_cat_id", True))
        Me.Comida_cat_idTextBox.Location = New System.Drawing.Point(325, 127)
        Me.Comida_cat_idTextBox.Name = "Comida_cat_idTextBox"
        Me.Comida_cat_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Comida_cat_idTextBox.TabIndex = 8
        '
        'ComidaDataGridView
        '
        Me.ComidaDataGridView.AutoGenerateColumns = False
        Me.ComidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComidaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ComidaDataGridView.DataSource = Me.ComidaBindingSource
        Me.ComidaDataGridView.Location = New System.Drawing.Point(30, 176)
        Me.ComidaDataGridView.Name = "ComidaDataGridView"
        Me.ComidaDataGridView.Size = New System.Drawing.Size(449, 365)
        Me.ComidaDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Preco"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Preco"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "comida_cat_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "comida_cat_id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'inserircomida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 553)
        Me.Controls.Add(Me.ComidaDataGridView)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(PrecoLabel)
        Me.Controls.Add(Me.PrecoTextBox)
        Me.Controls.Add(Comida_cat_idLabel)
        Me.Controls.Add(Me.Comida_cat_idTextBox)
        Me.Controls.Add(Me.ComidaBindingNavigator)
        Me.Name = "inserircomida"
        Me.Text = "inserircomida"
        CType(Me.FastfoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComidaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComidaBindingNavigator.ResumeLayout(False)
        Me.ComidaBindingNavigator.PerformLayout()
        CType(Me.ComidaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FastfoodDataSet As fastfoodDataSet
    Friend WithEvents ComidaBindingSource As BindingSource
    Friend WithEvents ComidaTableAdapter As fastfoodDataSetTableAdapters.ComidaTableAdapter
    Friend WithEvents TableAdapterManager As fastfoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComidaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ComidaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents PrecoTextBox As TextBox
    Friend WithEvents Comida_cat_idTextBox As TextBox
    Friend WithEvents ComidaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
