<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class validaruser
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
        Dim UserIdLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(validaruser))
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserIdTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.btpass = New System.Windows.Forms.Button()
        Me.confirmartxt = New System.Windows.Forms.TextBox()
        Me.verificarbt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        UserIdLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserIdLabel
        '
        UserIdLabel.AutoSize = True
        UserIdLabel.Location = New System.Drawing.Point(450, 171)
        UserIdLabel.Name = "UserIdLabel"
        UserIdLabel.Size = New System.Drawing.Size(84, 13)
        UserIdLabel.TabIndex = 7
        UserIdLabel.Text = "Nome Utilizador:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(450, 252)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "email:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(450, 209)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(38, 13)
        NomeLabel.TabIndex = 1
        NomeLabel.Text = "Nome:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(566, 349)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(126, 20)
        Me.PasswordTextBox.TabIndex = 6
        Me.PasswordTextBox.Visible = False
        '
        'UserIdTextBox
        '
        Me.UserIdTextBox.Location = New System.Drawing.Point(566, 168)
        Me.UserIdTextBox.Name = "UserIdTextBox"
        Me.UserIdTextBox.Size = New System.Drawing.Size(126, 20)
        Me.UserIdTextBox.TabIndex = 8
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(566, 249)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(195, 20)
        Me.EmailTextBox.TabIndex = 10
        '
        'NomeTextBox
        '
        Me.NomeTextBox.Location = New System.Drawing.Point(566, 206)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(195, 20)
        Me.NomeTextBox.TabIndex = 2
        '
        'btpass
        '
        Me.btpass.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btpass.Location = New System.Drawing.Point(566, 441)
        Me.btpass.Name = "btpass"
        Me.btpass.Size = New System.Drawing.Size(120, 46)
        Me.btpass.TabIndex = 11
        Me.btpass.Text = "Mudar Password"
        Me.btpass.UseVisualStyleBackColor = False
        Me.btpass.Visible = False
        '
        'confirmartxt
        '
        Me.confirmartxt.Location = New System.Drawing.Point(566, 393)
        Me.confirmartxt.Name = "confirmartxt"
        Me.confirmartxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmartxt.Size = New System.Drawing.Size(126, 20)
        Me.confirmartxt.TabIndex = 13
        Me.confirmartxt.Visible = False
        '
        'verificarbt
        '
        Me.verificarbt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.verificarbt.Location = New System.Drawing.Point(566, 300)
        Me.verificarbt.Name = "verificarbt"
        Me.verificarbt.Size = New System.Drawing.Size(120, 29)
        Me.verificarbt.TabIndex = 14
        Me.verificarbt.Text = "Verificar"
        Me.verificarbt.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(451, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Password:"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Confirmar password:"
        Me.Label2.Visible = False
        '
        'validaruser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.verificarbt)
        Me.Controls.Add(Me.confirmartxt)
        Me.Controls.Add(Me.btpass)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UserIdLabel)
        Me.Controls.Add(Me.UserIdTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "validaruser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UserIdTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents btpass As Button
    Friend WithEvents confirmartxt As TextBox
    Friend WithEvents verificarbt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
