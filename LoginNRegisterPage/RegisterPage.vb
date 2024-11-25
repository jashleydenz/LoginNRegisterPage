Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices

Public Class RegisterPage
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        txtPassword2.Text = "enter your password"
        txtPassword2.ForeColor = Color.Gray
        txtPassword2.UseSystemPasswordChar = False ' No password masking for placeholder text

        ' Set placeholder text and no PasswordChar initially
        txtConPassword1.Text = "confirm your password"
        txtConPassword1.ForeColor = Color.Gray
        txtConPassword1.UseSystemPasswordChar = False ' No password masking for placeholder text

        lblLoginNow.Cursor = Cursors.Hand  ' Make cursor a hand to indicate clickability
        AddHandler lblLoginNow.Click, AddressOf lblLoginNow_Click

        Me.StartPosition = FormStartPosition.Manual
    End Sub

    ' Event handler for close button click
    Private Sub CloseWindow1_Click(sender As Object, e As EventArgs)
        Application.Exit()
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
    Private Sub txtName1_Enter(sender As Object, e As EventArgs) Handles txtName1.Enter
        If txtName1.Text = "enter your name" Then
            txtName1.Text = ""
            txtName1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtName1_Leave(sender As Object, e As EventArgs) Handles txtName1.Leave
        If txtName1.Text = "" Then
            txtName1.Text = "enter your name"
            txtName1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtEmail2_Enter(sender As Object, e As EventArgs) Handles txtEmail2.Enter
        If txtEmail2.Text = "enter your email" Then
            txtEmail2.Text = ""
            txtEmail2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmail2_Leave(sender As Object, e As EventArgs) Handles txtEmail2.Leave
        If txtEmail2.Text = "" Then
            txtEmail2.Text = "enter your email"
            txtEmail2.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPassword2_Enter(sender As Object, e As EventArgs) Handles txtPassword2.Enter
        ' Clear placeholder text when focused and set the color to black
        If txtPassword2.Text = "enter your password" Then
            txtPassword2.Text = ""
            txtPassword2.ForeColor = Color.Black
            ' Enable password masking when user starts typing (if checkbox is unchecked)
            If Not chkShow2.Checked Then
                txtPassword2.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    Private Sub txtPassword2_Leave(sender As Object, e As EventArgs) Handles txtPassword2.Leave
        ' If no input, set the placeholder text back
        If txtPassword2.Text = "" Then
            txtPassword2.Text = "enter your password"
            txtPassword2.ForeColor = Color.Gray
            txtPassword2.UseSystemPasswordChar = False ' No password masking for placeholder
        End If
    End Sub

    Private Sub txtConPassword1_Enter(sender As Object, e As EventArgs) Handles txtConPassword1.Enter
        ' Clear placeholder text when focused and set the color to black
        If txtConPassword1.Text = "confirm your password" Then
            txtConPassword1.Text = ""
            txtConPassword1.ForeColor = Color.Black
            ' Enable password masking when user starts typing (if checkbox is unchecked)
            If Not chkShow2.Checked Then
                txtConPassword1.UseSystemPasswordChar = True
            End If
        End If
    End Sub

    Private Sub txtConPassword1_Leave(sender As Object, e As EventArgs) Handles txtConPassword1.Leave
        ' If no input, set the placeholder text back
        If txtConPassword1.Text = "" Then
            txtConPassword1.Text = "confirm your password"
            txtConPassword1.ForeColor = Color.Gray
            txtConPassword1.UseSystemPasswordChar = False ' No password masking for placeholder
        End If
    End Sub
    Private Sub chkShow2_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow2.CheckedChanged
        ' Toggle visibility based on the checkbox state and placeholder presence
        If txtPassword2.Text <> "enter your password" Then
            txtPassword2.UseSystemPasswordChar = Not chkShow2.Checked
        Else
            txtPassword2.UseSystemPasswordChar = False ' No masking for placeholder
        End If

        If txtConPassword1.Text <> "confirm your password" Then
            txtConPassword1.UseSystemPasswordChar = Not chkShow2.Checked
        Else
            txtConPassword1.UseSystemPasswordChar = False ' No masking for placeholder
        End If
    End Sub


    ' Declare a variable to hold the reference to Form1
    Private form1 As LoginPage

    Private Sub lblLoginNow_Click(sender As Object, e As EventArgs) Handles lblLoginNow.Click
        ' If Form1 is not open, create and show it
        If form1 Is Nothing OrElse form1.IsDisposed Then
            form1 = New LoginPage
            form1.StartPosition = FormStartPosition.Manual
            form1.Location = Me.Location ' Set Form1's location to the same as Form2's location
            form1.Show()
            Me.Hide()
        Else
            form1.BringToFront() ' If Form1 is already open, bring it to the front
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        MessageBox.Show("Registered Successfully")
        LoginPage.Show()
        txtName1.Clear()
        txtEmail2.Clear()
        txtPassword2.Clear()
        txtConPassword1.Clear()
        Me.Hide()
    End Sub
End Class