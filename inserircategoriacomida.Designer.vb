<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inserircategoriacomida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inserircategoriacomida))
        Dim IdLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Me.FastfoodDataSet = New McDonalds.fastfoodDataSet()
        Me.ComidaCategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComidaCategoriaTableAdapter = New McDonalds.fastfoodDataSetTableAdapters.comidaCategoriaTableAdapter()
        Me.TableAdapterManager = New McDonalds.fastfoodDataSetTableAdapters.TableAdapterManager()
        Me.ComidaCategoriaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ComidaCategoriaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.ComidaCategoriaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.FastfoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComidaCategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComidaCategoriaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComidaCategoriaBindingNavigator.SuspendLayout()
        CType(Me.ComidaCategoriaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FastfoodDataSet
        '
        Me.FastfoodDataSet.DataSetName = "fastfoodDataSet"
        Me.FastfoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComidaCategoriaBindingSource
        '
        Me.ComidaCategoriaBindingSource.DataMember = "comidaCategoria"
        Me.ComidaCategoriaBindingSource.DataSource = Me.FastfoodDataSet
        '
        'ComidaCategoriaTableAdapter
        '
        Me.ComidaCategoriaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.comidaCategoriaTableAdapter = Me.ComidaCategoriaTableAdapter
        Me.TableAdapterManager.ComidaTableAdapter = Nothing
        Me.TableAdapterManager.ordemTransacaoTableAdapter = Nothing
        Me.TableAdapterManager.transacaoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = McDonalds.fastfoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_categoriaTableAdapter = Nothing
        Me.TableAdapterManager.Users_perfilTableAdapter = Nothing
        '
        'ComidaCategoriaBindingNavigator
        '
        Me.ComidaCategoriaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ComidaCategoriaBindingNavigator.BindingSource = Me.ComidaCategoriaBindingSource
        Me.ComidaCategoriaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ComidaCategoriaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ComidaCategoriaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ComidaCategoriaBindingNavigatorSaveItem})
        Me.ComidaCategoriaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ComidaCategoriaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ComidaCategoriaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ComidaCategoriaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ComidaCategoriaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ComidaCategoriaBindingNavigator.Name = "ComidaCategoriaBindingNavigator"
        Me.ComidaCategoriaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ComidaCategoriaBindingNavigator.Size = New System.Drawing.Size(343, 25)
        Me.ComidaCategoriaBindingNavigator.TabIndex = 0
        Me.ComidaCategoriaBindingNavigator.Text = "BindingNavigator1"
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
        'ComidaCategoriaBindingNavigatorSaveItem
        '
        Me.ComidaCategoriaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ComidaCategoriaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ComidaCategoriaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ComidaCategoriaBindingNavigatorSaveItem.Name = "ComidaCategoriaBindingNavigatorSaveItem"
        Me.ComidaCategoriaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ComidaCategoriaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(93, 56)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComidaCategoriaBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(137, 53)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(93, 82)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComidaCategoriaBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(137, 79)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'ComidaCategoriaDataGridView
        '
        Me.ComidaCategoriaDataGridView.AutoGenerateColumns = False
        Me.ComidaCategoriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComidaCategoriaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ComidaCategoriaDataGridView.DataSource = Me.ComidaCategoriaBindingSource
        Me.ComidaCategoriaDataGridView.Location = New System.Drawing.Point(36, 171)
        Me.ComidaCategoriaDataGridView.Name = "ComidaCategoriaDataGridView"
        Me.ComidaCategoriaDataGridView.Size = New System.Drawing.Size(244, 347)
        Me.ComidaCategoriaDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'inserircategoriacomida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 532)
        Me.Controls.Add(Me.ComidaCategoriaDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.ComidaCategoriaBindingNavigator)
        Me.Name = "inserircategoriacomida"
        Me.Text = "inserircategoriacomida"
        CType(Me.FastfoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComidaCategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComidaCategoriaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComidaCategoriaBindingNavigator.ResumeLayout(False)
        Me.ComidaCategoriaBindingNavigator.PerformLayout()
        CType(Me.ComidaCategoriaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FastfoodDataSet As fastfoodDataSet
    Friend WithEvents ComidaCategoriaBindingSource As BindingSource
    Friend WithEvents ComidaCategoriaTableAdapter As fastfoodDataSetTableAdapters.comidaCategoriaTableAdapter
    Friend WithEvents TableAdapterManager As fastfoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComidaCategoriaBindingNavigator As BindingNavigator
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
    Friend WithEvents ComidaCategoriaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents ComidaCategoriaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
