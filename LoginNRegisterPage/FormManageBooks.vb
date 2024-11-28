Imports System.Runtime.InteropServices

Public Class FormManageBooks
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

    ' Counter for total books released
    Private totalBooksReleased As Integer = 0

    ' Original book details
    Private originalTitle As String
    Private originalAuthor As String
    Private originalGenre As String
    Private originalDateReleased As Date
    Private originalBookStatus As String

    Private editingIndex As Integer = -1 ' Track the index being edited

    Private Sub FormManageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Remove the default title bar
        Me.FormBorderStyle = FormBorderStyle.None

        ' Set a clean, rounded corner radius
        Dim radius As Integer = 20  ' Use a smaller value for crisper edges
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))

        ' Optional: Set background color to highlight edges better
        Me.BackColor = Color.White

        ' Add click event handlers
        AddHandler CloseWindow3.Click, AddressOf CloseWindow1_Click
        AddHandler MinimizedWindow3.Click, AddressOf MinimizedWindow1_Click

        ' Add hover effect event handlers
        AddHandler CloseWindow3.MouseEnter, AddressOf CloseWindow1_MouseEnter
        AddHandler CloseWindow3.MouseLeave, AddressOf CloseWindow1_MouseLeave
        AddHandler MinimizedWindow3.MouseEnter, AddressOf MinimizedWindow1_MouseEnter
        AddHandler MinimizedWindow3.MouseLeave, AddressOf MinimizedWindow1_MouseLeave
        AddHandler MaximizeWindow3.MouseEnter, AddressOf MaximizeWindow1_MouseEnter
        AddHandler MaximizeWindow3.MouseLeave, AddressOf MaximizeWindow1_MouseLeave

        ' Add dragging events to the Panel
        AddHandler Panel1.MouseDown, AddressOf Panel_MouseDown
        AddHandler Panel1.MouseMove, AddressOf Panel_MouseMove
        AddHandler Panel1.MouseUp, AddressOf Panel_MouseUp

        AddHandler Guna2GradientPanel1.MouseDown, AddressOf Panel_MouseDown
        AddHandler Guna2GradientPanel1.MouseMove, AddressOf Panel_MouseMove
        AddHandler Guna2GradientPanel1.MouseUp, AddressOf Panel_MouseUp

        Me.ActiveControl = Nothing

        ' Initialize Book Status combobox
        ComboBox1.Items.AddRange(New String() {"Available", "Returned", "Borrowed"})
    End Sub

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

    Private Sub MaximizeWindow1_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Hand  ' Change cursor to hand on hover
    End Sub

    Private Sub MaximizeWindow1_MouseLeave(sender As Object, e As EventArgs)
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

    Private Sub MaximizeWindow1_Click(sender As Object, e As EventArgs) Handles MaximizeWindow3.Click
        If Me.WindowState = FormWindowState.Normal Then
            ' Maximize the form
            Me.WindowState = FormWindowState.Maximized
            ' Manually set the form size to fill the screen
            Me.Bounds = Screen.PrimaryScreen.Bounds
            ' Recalculate region for rounded corners after maximizing
            Dim radius As Integer = 20  ' Adjust for rounded corners
            Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))
        Else
            ' Restore the form to its normal size
            Me.WindowState = FormWindowState.Normal
            ' Recalculate region for rounded corners when restored
            Dim radius As Integer = 20
            Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Implement the logic for adding the book details here
        Dim title As String = TextBox1.Text
            Dim author As String = TextBox2.Text
            Dim genre As String = TextBox3.Text
            Dim dateReleased As Date = DateTimePicker1.Value
            Dim bookStatus As String = ComboBox1.SelectedItem.ToString()

        ' If we are editing an existing entry
        If editingIndex <> -1 Then
            ' Update the selected item in the ListBox
            ListBox1.Items(editingIndex) = $"Title: {title}, Author: {author}, Genre: {genre}, Date Released: {dateReleased.ToShortDateString()}, Status: {bookStatus}"
            MessageBox.Show("Updated Successfully")
            editingIndex = -1 ' Reset the editing index
        Else
            ' Add the book details to the ListBox
            ListBox1.Items.Add($"Title: {title}, Author: {author}, Genre: {genre}, Date Released: {dateReleased.ToShortDateString()}, Status: {bookStatus}")

            ' Increment the total books released and update the label
            totalBooksReleased += 1
            Label11.Text = $"Total Books Released: {totalBooksReleased}"

            MessageBox.Show("Saved Successfully")
        End If

        ' Clear input fields
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            DateTimePicker1.Value = DateTime.Now
            ComboBox1.SelectedIndex = -1
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If ListBox1.SelectedIndex <> -1 Then
            ' Populate the text boxes with the selected item data
            editingIndex = ListBox1.SelectedIndex ' Track the selected index for editing
            Dim selectedItem As String = ListBox1.SelectedItem.ToString()
            Dim details As String() = selectedItem.Split(", ")

            TextBox1.Text = details(0).Replace("Title: ", "").Trim()
            TextBox2.Text = details(1).Replace("Author: ", "").Trim()
            TextBox3.Text = details(2).Replace("Genre: ", "").Trim()
            DateTimePicker1.Value = Date.Parse(details(3).Replace("Date Released: ", "").Trim())
            ComboBox1.SelectedItem = details(4).Replace("Status: ", "").Trim()
        End If

    Private Sub lblAddBooks1_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Default  ' Revert cursor to default
    End Sub
    Private Sub lblEditBooks1_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, PictureBox).Cursor = Cursors.Hand  ' Change cursor to hand on hover
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        ' Open file dialog to select an image
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

    End Sub
End Class