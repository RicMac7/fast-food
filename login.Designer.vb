<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Linkpass = New System.Windows.Forms.LinkLabel()
        Me.Linknovo = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(672, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome Utilizador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(671, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'Linkpass
        '
        Me.Linkpass.AutoSize = True
        Me.Linkpass.Location = New System.Drawing.Point(805, 473)
        Me.Linkpass.Name = "Linkpass"
        Me.Linkpass.Size = New System.Drawing.Size(92, 13)
        Me.Linkpass.TabIndex = 3
        Me.Linkpass.TabStop = True
        Me.Linkpass.Text = "esqueci password"
        '
        'Linknovo
        '
        Me.Linknovo.AutoSize = True
        Me.Linknovo.Location = New System.Drawing.Point(653, 473)
        Me.Linknovo.Name = "Linknovo"
        Me.Linknovo.Size = New System.Drawing.Size(103, 13)
        Me.Linknovo.TabIndex = 4
        Me.Linknovo.TabStop = True
        Me.Linknovo.Text = "Criar Novo Utilizador"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(797, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'usertxt
        '
        Me.usertxt.Location = New System.Drawing.Point(777, 276)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(120, 20)
        Me.usertxt.TabIndex = 6
        '
        'passtxt
        '
        Me.passtxt.Location = New System.Drawing.Point(777, 318)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtxt.Size = New System.Drawing.Size(120, 20)
        Me.passtxt.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.McDonalds.My.Resources.Resources.logotipo_mcdonalds
        Me.PictureBox1.Location = New System.Drawing.Point(277, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 188)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usertxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Linknovo)
        Me.Controls.Add(Me.Linkpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Linkpass As LinkLabel
    Friend WithEvents Linknovo As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents usertxt As TextBox
    Friend WithEvents passtxt As TextBox
End Class
