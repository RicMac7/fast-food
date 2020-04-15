<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inserirusers
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Cargo_idLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inserirusers))
        Me.FastfoodDataSet = New McDonalds.fastfoodDataSet()
        Me.Users_perfilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Users_perfilTableAdapter = New McDonalds.fastfoodDataSetTableAdapters.Users_perfilTableAdapter()
        Me.TableAdapterManager = New McDonalds.fastfoodDataSetTableAdapters.TableAdapterManager()
        Me.Users_perfilBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.Cargo_idTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Users_perfilBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Users_perfilDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NomeLabel = New System.Windows.Forms.Label()
        Cargo_idLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        UserIdLabel = New System.Windows.Forms.Label()
        CType(Me.FastfoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Users_perfilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Users_perfilBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Users_perfilBindingNavigator.SuspendLayout()
        CType(Me.Users_perfilDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FastfoodDataSet
        '
        Me.FastfoodDataSet.DataSetName = "fastfoodDataSet"
        Me.FastfoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Users_perfilBindingSource
        '
        Me.Users_perfilBindingSource.DataMember = "Users_perfil"
        Me.Users_perfilBindingSource.DataSource = Me.FastfoodDataSet
        '
        'Users_perfilTableAdapter
        '
        Me.Users_perfilTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.comidaCategoriaTableAdapter = Nothing
        Me.TableAdapterManager.ComidaTableAdapter = Nothing
        Me.TableAdapterManager.ordemTransacaoTableAdapter = Nothing
        Me.TableAdapterManager.transacaoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = McDonalds.fastfoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_categoriaTableAdapter = Nothing
        Me.TableAdapterManager.Users_perfilTableAdapter = Me.Users_perfilTableAdapter
        '
        'Users_perfilBindingNavigator
        '
        Me.Users_perfilBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Users_perfilBindingNavigator.BindingSource = Me.Users_perfilBindingSource
        Me.Users_perfilBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Users_perfilBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Users_perfilBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Users_perfilBindingNavigatorSaveItem})
        Me.Users_perfilBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Users_perfilBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Users_perfilBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Users_perfilBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Users_perfilBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Users_perfilBindingNavigator.Name = "Users_perfilBindingNavigator"
        Me.Users_perfilBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Users_perfilBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.Users_perfilBindingNavigator.TabIndex = 0
        Me.Users_perfilBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(186, 48)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Users_perfilBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(247, 45)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomeTextBox.TabIndex = 2
        '
        'Cargo_idLabel
        '
        Cargo_idLabel.AutoSize = True
        Cargo_idLabel.Location = New System.Drawing.Point(186, 74)
        Cargo_idLabel.Name = "Cargo_idLabel"
        Cargo_idLabel.Size = New System.Drawing.Size(48, 13)
        Cargo_idLabel.TabIndex = 3
        Cargo_idLabel.Text = "cargo id:"
        '
        'Cargo_idTextBox
        '
        Me.Cargo_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Users_perfilBindingSource, "cargo_id", True))
        Me.Cargo_idTextBox.Location = New System.Drawing.Point(247, 71)
        Me.Cargo_idTextBox.Name = "Cargo_idTextBox"
        Me.Cargo_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cargo_idTextBox.TabIndex = 4
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(186, 100)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Users_perfilBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(247, 97)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 6
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(186, 126)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Users_perfilBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(247, 123)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 8
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(186, 152)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(44, 13)
        UserIdLabel.TabIndex = 9
        UserIdLabel.Text = "User Id:"
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Users_perfilBindingSource, "UserId", True))
        Me.UserIdTextBox.Location = New System.Drawing.Point(247, 149)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserIdTextBox.TabIndex = 10
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'Users_perfilBindingNavigatorSaveItem
        '
        Me.Users_perfilBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Users_perfilBindingNavigatorSaveItem.Image = CType(resources.GetObject("Users_perfilBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Users_perfilBindingNavigatorSaveItem.Name = "Users_perfilBindingNavigatorSaveItem"
        Me.Users_perfilBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Users_perfilBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Users_perfilDataGridView
        '
        Me.Users_perfilDataGridView.AutoGenerateColumns = False
        Me.Users_perfilDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Users_perfilDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Users_perfilDataGridView.DataSource = Me.Users_perfilBindingSource
        Me.Users_perfilDataGridView.Location = New System.Drawing.Point(37, 206)
        Me.Users_perfilDataGridView.Name = "Users_perfilDataGridView"
        Me.Users_perfilDataGridView.Size = New System.Drawing.Size(549, 251)
        Me.Users_perfilDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cargo_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cargo_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UserId"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UserId"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'inserirusers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 499)
        Me.Controls.Add(Me.Users_perfilDataGridView)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Cargo_idLabel)
        Me.Controls.Add(Me.Cargo_idTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(UserIdLabel)
        Me.Controls.Add(Me.UserIdTextBox)
        Me.Controls.Add(Me.Users_perfilBindingNavigator)
        Me.Name = "inserirusers"
        Me.Text = "inserirusers"
        CType(Me.FastfoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Users_perfilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Users_perfilBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Users_perfilBindingNavigator.ResumeLayout(False)
        Me.Users_perfilBindingNavigator.PerformLayout()
        CType(Me.Users_perfilDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FastfoodDataSet As fastfoodDataSet
    Friend WithEvents Users_perfilBindingSource As BindingSource
    Friend WithEvents Users_perfilTableAdapter As fastfoodDataSetTableAdapters.Users_perfilTableAdapter
    Friend WithEvents TableAdapterManager As fastfoodDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Users_perfilBindingNavigator As BindingNavigator
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
    Friend WithEvents Users_perfilBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents Cargo_idTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents UserIdTextBox As TextBox
    Friend WithEvents Users_perfilDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
