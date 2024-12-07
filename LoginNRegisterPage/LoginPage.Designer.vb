<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
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
        Me.MinimizedWindow1 = New System.Windows.Forms.PictureBox()
        Me.CloseWindow1 = New System.Windows.Forms.PictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRegisterNow = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.MinimizedWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MinimizedWindow1)
        Me.Panel1.Controls.Add(Me.CloseWindow1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 58)
        Me.Panel1.TabIndex = 0
        '
        'MinimizedWindow1
        '
        Me.MinimizedWindow1.Image = Global.LoginNRegisterPage.My.Resources.Resources.MinimizedWindow
        Me.MinimizedWindow1.Location = New System.Drawing.Point(409, 16)
        Me.MinimizedWindow1.Name = "MinimizedWindow1"
        Me.MinimizedWindow1.Size = New System.Drawing.Size(31, 26)
        Me.MinimizedWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimizedWindow1.TabIndex = 1
        Me.MinimizedWindow1.TabStop = False
        '
        'CloseWindow1
        '
        Me.CloseWindow1.Image = Global.LoginNRegisterPage.My.Resources.Resources.CloseWindow
        Me.CloseWindow1.Location = New System.Drawing.Point(456, 16)
        Me.CloseWindow1.Name = "CloseWindow1"
        Me.CloseWindow1.Size = New System.Drawing.Size(28, 26)
        Me.CloseWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseWindow1.TabIndex = 0
        Me.CloseWindow1.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Bell MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(175, 110)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(165, 46)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "LOGIN "
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Gray
        Me.txtEmail.Location = New System.Drawing.Point(74, 183)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(355, 28)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.TabStop = False
        Me.txtEmail.Text = "enter your email"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Gray
        Me.txtPassword.Location = New System.Drawing.Point(74, 239)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(355, 28)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.TabStop = False
        Me.txtPassword.Text = "enter your password"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.LightCoral
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Cooper Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Maroon
        Me.btnLogin.Location = New System.Drawing.Point(74, 326)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(354, 43)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.TabStop = False
        Me.btnLogin.Text = "Login Now"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Font = New System.Drawing.Font("Cooper Black", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShow.Location = New System.Drawing.Point(293, 273)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(134, 19)
        Me.chkShow.TabIndex = 3
        Me.chkShow.Text = "Show password"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 404)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "don't have an account?"
        '
        'lblRegisterNow
        '
        Me.lblRegisterNow.AutoSize = True
        Me.lblRegisterNow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterNow.ForeColor = System.Drawing.Color.Maroon
        Me.lblRegisterNow.Location = New System.Drawing.Point(288, 404)
        Me.lblRegisterNow.Name = "lblRegisterNow"
        Me.lblRegisterNow.Size = New System.Drawing.Size(88, 17)
        Me.lblRegisterNow.TabIndex = 6
        Me.lblRegisterNow.Text = "register now"
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(496, 477)
        Me.Controls.Add(Me.lblRegisterNow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkShow)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.MinimizedWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CloseWindow1 As PictureBox
    Friend WithEvents MinimizedWindow1 As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblRegisterNow As Label
End Class
