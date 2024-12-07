Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class LoginPage
    ' Import the CreateRoundRectRgn function from the Windows API
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(
        ByVal nLeftRect As Integer,
        ByVal nTopRect As Integer,
        ByVal nRightRect As Integer,
        ByVal nBottomRect As Integer,
        ByVal nWidthEllipse As Integer,
        ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    ' Variables for dragging the form
    Private drag As Boolean
    Private mouseX As Integer
    Private mouseY As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Remove the default title bar
        Me.FormBorderStyle = FormBorderStyle.None

        ' Set a clean, rounded corner radius
        Dim radius As Integer = 20  ' Use a smaller value for crisper edges
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))

        ' Optional: Set background color to highlight edges better
        Me.BackColor = Color.White

        ' Add click event handlers
        AddHandler CloseWindow1.Click, AddressOf CloseWindow1_Click
        AddHandler MinimizedWindow1.Click, AddressOf MinimizedWindow1_Click

        ' Add hover effect event handlers
        AddHandler CloseWindow1.MouseEnter, AddressOf CloseWindow1_MouseEnter
        AddHandler CloseWindow1.MouseLeave, AddressOf CloseWindow1_MouseLeave
        AddHandler MinimizedWindow1.MouseEnter, AddressOf MinimizedWindow1_MouseEnter
        AddHandler MinimizedWindow1.MouseLeave, AddressOf MinimizedWindow1_MouseLeave

        ' Add dragging events to the Panel
        AddHandler Panel1.MouseDown, AddressOf Panel_MouseDown
        AddHandler Panel1.MouseMove, AddressOf Panel_MouseMove
        AddHandler Panel1.MouseUp, AddressOf Panel_MouseUp

        ' Set placeholder text and no PasswordChar initially
        txtPassword.Text = "enter your password"
        txtPassword.ForeColor = Color.Gray
        txtPassword.UseSystemPasswordChar = False ' No password masking for placeholder text

        lblRegisterNow.Cursor = Cursors.Hand  ' Make cursor a hand to indicate clickability
        AddHandler lblRegisterNow.Click, AddressOf lblRegisterNow_Click

        Me.StartPosition = FormStartPosition.Manual
    End Sub

    ' Event handler for close button click
    Private Sub CloseWindow1_Click(sender As Object, e As EventArgs)
        Me.Close() ' Close the form
    End Sub

    ' Event handlers for CloseWindow1 hover effects
    Private Sub CloseWindow1_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Hand  ' Change cursor to hand on hover
    End Sub

    Private Sub CloseWindow1_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Default  ' Revert cursor to default
    End Sub

    ' Event handler for minimize button click
    Private Sub MinimizedWindow1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Event handlers for MinimizedWindow1 hover effects
    Private Sub MinimizedWindow1_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Hand  ' Change cursor to hand on hover
    End Sub

    Private Sub MinimizedWindow1_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Default  ' Revert cursor to default
    End Sub

    ' Mouse Down event to start dragging
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    ' Mouse Move event to drag the form
    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    ' Mouse Up event to stop dragging
    Private Sub Panel_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub

    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        If txtEmail.Text = "enter your email" Then
            txtEmail.Text = ""
            txtEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.Text = "" Then
            txtEmail.Text = "enter your email"
            txtEmail.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        ' Clear placeholder text when focused and set the color to black
        If txtPassword.Text = "enter your password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            ' Enable password masking when user starts typing (if checkbox is unchecked)
            If Not chkShow.Checked Then
                txtPassword.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        ' If no input, set the placeholder text back
        If txtPassword.Text = "" Then
            txtPassword.Text = "enter your password"
            txtPassword.ForeColor = Color.Gray
            txtPassword.UseSystemPasswordChar = False ' No password masking for placeholder
        End If
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        ' If the TextBox is not showing the placeholder text
        If txtPassword.Text <> "enter your password" Then
            If chkShow.Checked Then
                ' Show password as plain text when checkbox is checked
                txtPassword.UseSystemPasswordChar = False
            Else
                ' Mask password with '*' when checkbox is unchecked
                txtPassword.UseSystemPasswordChar = True
            End If
        Else
            ' If the placeholder is showing, no password masking is needed
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private form2 As RegisterPage

    Private Sub lblRegisterNow_Click(sender As Object, e As EventArgs) Handles lblRegisterNow.Click
        ' If Form2 is not open, create and show it
        If form2 Is Nothing OrElse form2.IsDisposed Then
            form2 = New RegisterPage
            form2.StartPosition = FormStartPosition.Manual
            form2.Location = Me.Location ' Set Form2's location to the same as Form1's location
            form2.Show()
            Me.Hide()
        Else
            form2.BringToFront() ' If Form2 is already open, bring it to the front
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            con.Open()
            Dim cmd As New MySqlCommand("Select TypeOfAccount from users where email = @Email and Password = @Password", con)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

            Dim TypeOfAccount As String = Convert.ToString(cmd.ExecuteScalar)
            If Not String.IsNullOrEmpty(TypeOfAccount) Then
                MessageBox.Show("Login Successful")
                Select Case TypeOfAccount
                    Case "User"
                        UserInterface.Show()
                    Case "Admin"
                        AdminDashboard.Show()
                    Case Else
                        MessageBox.Show("Invalid Credentials")

                End Select

                Me.Hide()
            Else

            End If
        Catch ex As Exception
            MsgBox("mysql error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class