<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseWindow1 = New System.Windows.Forms.PictureBox()
        Me.MinimizedWindow1 = New System.Windows.Forms.PictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.txtConPassword1 = New System.Windows.Forms.TextBox()
        Me.chkShow2 = New System.Windows.Forms.CheckBox()
        Me.txtEmail2 = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLoginNow = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.CloseWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizedWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.Panel1.Controls.Add(Me.CloseWindow1)
        Me.Panel1.Controls.Add(Me.MinimizedWindow1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 58)
        Me.Panel1.TabIndex = 3
        '
        'CloseWindow1
        '
        Me.CloseWindow1.Image = Global.LoginNRegisterPage.My.Resources.Resources.CloseWindow
        Me.CloseWindow1.Location = New System.Drawing.Point(456, 17)
        Me.CloseWindow1.Name = "CloseWindow1"
        Me.CloseWindow1.Size = New System.Drawing.Size(28, 26)
        Me.CloseWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseWindow1.TabIndex = 1
        Me.CloseWindow1.TabStop = False
        '
        'MinimizedWindow1
        '
        Me.MinimizedWindow1.Image = Global.LoginNRegisterPage.My.Resources.Resources.MinimizedWindow
        Me.MinimizedWindow1.Location = New System.Drawing.Point(409, 16)
        Me.MinimizedWindow1.Name = "MinimizedWindow1"
        Me.MinimizedWindow1.Size = New System.Drawing.Size(31, 26)
        Me.MinimizedWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimizedWindow1.TabIndex = 2
        Me.MinimizedWindow1.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblLogin.Location = New System.Drawing.Point(100, 92)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(275, 38)
        Me.lblLogin.TabIndex = 4
        Me.lblLogin.Text = "REGISTER NOW"
        '
        'txtName1
        '
        Me.txtName1.BackColor = System.Drawing.Color.Gainsboro
        Me.txtName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName1.ForeColor = System.Drawing.Color.Gray
        Me.txtName1.Location = New System.Drawing.Point(71, 161)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(355, 28)
        Me.txtName1.TabIndex = 5
        Me.txtName1.TabStop = False
        Me.txtName1.Text = "enter your name"
        '
        'txtPassword2
        '
        Me.txtPassword2.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPassword2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword2.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword2.Location = New System.Drawing.Point(71, 255)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(355, 28)
        Me.txtPassword2.TabIndex = 6
        Me.txtPassword2.TabStop = False
        Me.txtPassword2.Text = "enter your password"
        Me.txtPassword2.UseSystemPasswordChar = True
        '
        'txtConPassword1
        '
        Me.txtConPassword1.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConPassword1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConPassword1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConPassword1.ForeColor = System.Drawing.Color.Gray
        Me.txtConPassword1.Location = New System.Drawing.Point(71, 300)
        Me.txtConPassword1.Name = "txtConPassword1"
        Me.txtConPassword1.Size = New System.Drawing.Size(355, 28)
        Me.txtConPassword1.TabIndex = 7
        Me.txtConPassword1.TabStop = False
        Me.txtConPassword1.Text = "confirm your password"
        Me.txtConPassword1.UseSystemPasswordChar = True
        '
        'chkShow2
        '
        Me.chkShow2.AutoSize = True
        Me.chkShow2.Font = New System.Drawing.Font("Arial Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow2.Location = New System.Drawing.Point(294, 346)
        Me.chkShow2.Name = "chkShow2"
        Me.chkShow2.Size = New System.Drawing.Size(143, 22)
        Me.chkShow2.TabIndex = 8
        Me.chkShow2.Text = "Show password"
        Me.chkShow2.UseVisualStyleBackColor = True
        '
        'txtEmail2
        '
        Me.txtEmail2.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEmail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail2.ForeColor = System.Drawing.Color.Gray
        Me.txtEmail2.Location = New System.Drawing.Point(71, 210)
        Me.txtEmail2.Name = "txtEmail2"
        Me.txtEmail2.Size = New System.Drawing.Size(355, 28)
        Me.txtEmail2.TabIndex = 10
        Me.txtEmail2.TabStop = False
        Me.txtEmail2.Text = "enter your email"
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Azure
        Me.btnRegister.Location = New System.Drawing.Point(72, 390)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(354, 43)
        Me.btnRegister.TabIndex = 11
        Me.btnRegister.TabStop = False
        Me.btnRegister.Text = "Register Now"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(86, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "already have an account?"
        '
        'lblLoginNow
        '
        Me.lblLoginNow.AutoSize = True
        Me.lblLoginNow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginNow.ForeColor = System.Drawing.Color.Black
        Me.lblLoginNow.Location = New System.Drawing.Point(299, 461)
        Me.lblLoginNow.Name = "lblLoginNow"
        Me.lblLoginNow.Size = New System.Drawing.Size(76, 18)
        Me.lblLoginNow.TabIndex = 13
        Me.lblLoginNow.Text = "login now"
        '
        'RegisterPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(496, 538)
        Me.Controls.Add(Me.lblLoginNow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtEmail2)
        Me.Controls.Add(Me.chkShow2)
        Me.Controls.Add(Me.txtConPassword1)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.txtName1)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegisterPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.CloseWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizedWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseWindow1 As PictureBox
    Friend WithEvents MinimizedWindow1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtName1 As TextBox
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents txtConPassword1 As TextBox
    Friend WithEvents chkShow2 As CheckBox
    Friend WithEvents txtEmail2 As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLoginNow As Label
End Class
