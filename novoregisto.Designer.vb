<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class novoregisto
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
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Cargo_idLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(novoregisto))
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.CargoidTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.repitapasstxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Cargo_idLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UserIdLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(463, 203)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'Cargo_idLabel
        '
        Cargo_idLabel.AutoSize = True
        Cargo_idLabel.Location = New System.Drawing.Point(754, 253)
        Cargo_idLabel.Name = "Cargo_idLabel"
        Cargo_idLabel.Size = New System.Drawing.Size(48, 13)
        Cargo_idLabel.TabIndex = 5
        Cargo_idLabel.Text = "cargo id:"
        Cargo_idLabel.Visible = False
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(452, 331)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "password:"
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(417, 299)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(84, 13)
        UserIdLabel.TabIndex = 9
        UserIdLabel.Text = "Nome Utilizador:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(473, 238)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 11
        EmailLabel.Text = "email:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(423, 366)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(84, 13)
        Label1.TabIndex = 14
        Label1.Text = "repita password:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.Location = New System.Drawing.Point(513, 200)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomeTextBox.TabIndex = 4
        '
        'CargoidTxt
        '
        Me.CargoidTxt.Location = New System.Drawing.Point(815, 250)
        Me.CargoidTxt.Name = "CargoidTxt"
        Me.CargoidTxt.Size = New System.Drawing.Size(100, 20)
        Me.CargoidTxt.TabIndex = 6
        Me.CargoidTxt.Visible = False
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(513, 328)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 8
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.Location = New System.Drawing.Point(513, 296)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserIdTextBox.TabIndex = 10
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(513, 235)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(513, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 36)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Criar Utilizador"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'repitapasstxt
        '
        Me.repitapasstxt.Location = New System.Drawing.Point(513, 363)
        Me.repitapasstxt.Name = "repitapasstxt"
        Me.repitapasstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.repitapasstxt.Size = New System.Drawing.Size(100, 20)
        Me.repitapasstxt.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(619, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 16
        '
        'novoregisto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.repitapasstxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(UserIdLabel)
        Me.Controls.Add(Me.UserIdTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Cargo_idLabel)
        Me.Controls.Add(Me.CargoidTxt)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "novoregisto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Novo registo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents CargoidTxt As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UserIdTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents repitapasstxt As TextBox
    Friend WithEvents Label2 As Label
End Class
