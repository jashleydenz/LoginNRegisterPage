Imports System.Diagnostics.Eventing.Reader
Imports System.Reflection.Emit
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Google.Protobuf.Reflection.FieldDescriptorProto.Types
Imports Guna.UI2.Native.WinApi

Public Class UserInterface
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

    Dim bookCovers As New List(Of Image)()

    Private books As List(Of Book)

    ' Constructor to receive the list of books
    Public Sub New(books As List(Of Book))
        InitializeComponent()
        Me.books = books
        LoadBooks()
    End Sub

    Private Sub LoadBooks()
        ' Clear any existing PictureBoxes
        FlowLayoutPanelBooks.Controls.Clear()

        ' Loop through the books and add PictureBoxes to the FlowLayoutPanel
        For Each book In books
            Dim picBox As New PictureBox()
            picBox.Size = New Drawing.Size(100, 150) ' Adjust size as needed
            picBox.Image = book.CoverImage ' Use the book's cover image
            picBox.SizeMode = PictureBoxSizeMode.StretchImage
            picBox.Tag = book ' Store the book object in the Tag property

            ' Add a click event to show the book description
            AddHandler picBox.Click, AddressOf Book_Click

            FlowLayoutPanelBooks.Controls.Add(picBox)
        Next
    End Sub

    Private Sub Book_Click(sender As Object, e As EventArgs)
        Dim picBox As PictureBox = CType(sender, PictureBox)
        Dim book As Book = CType(picBox.Tag, Book) ' Get the book object from the Tag property

        ' Display book description in a Label (or any other control)
        lblBookTitle1.Text = "Title: " & book.Title
        lblAuthor1.Text = "Author: " & book.Author
        lblGenre1.Text = "Genre: " & book.Genre
        lbldatereleased1.Text = "Date Released: " & book.ReleaseDate
        lblbookstatus1.Text = "Book Status: " & book.BookStatus
        lblDescription1.Text = "Description: " & book.Description

        ' Optionally display chapters for the book
        ShowChapters(book)
    End Sub

    Private Sub ShowChapters(book As Book)
        ' Clear existing chapter list
        ListBoxChapters.Items.Clear()

        ' Add each chapter title to the ListBox
        For Each chapter As Chapter In book.Chapters
            ListBoxChapters.Items.Add(chapter.Title)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxChapters.SelectedIndexChanged
        If ListBoxChapters.SelectedIndex >= 0 Then
            Dim selectedChapter As Chapter = books(0).Chapters(ListBoxChapters.SelectedIndex) ' Assuming you're showing the chapters for the first book
            rtbChapterContent.Text = selectedChapter.Content ' Show the chapter content in a RichTextBox (or another control)
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        AddHandler Guna2GradientPanel2.MouseDown, AddressOf Panel_MouseDown
        AddHandler Guna2GradientPanel2.MouseMove, AddressOf Panel_MouseMove
        AddHandler Guna2GradientPanel2.MouseUp, AddressOf Panel_MouseUp

        AddHandler lblBooks1.MouseEnter, AddressOf lblBooks1_MouseEnter
        AddHandler lblBooks1.MouseLeave, AddressOf lblBooks1_MouseLeave
        AddHandler lblBorrowingofBooks1.MouseEnter, AddressOf lblBorrowingofBooks1_MouseEnter
        AddHandler lblBorrowingofBooks1.MouseLeave, AddressOf lblBorrowingofBooks1_MouseLeave
        AddHandler lblNewReleases1.MouseEnter, AddressOf lblNewReleases1_MouseEnter
        Me.ActiveControl = Nothing
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
    ' MouseEnter for lblBooks1
    Private Sub lblBooks1_MouseEnter(sender As Object, e As EventArgs) Handles lblBooks1.MouseEnter
        lblBooks1.ForeColor = Color.FromArgb(139, 0, 0) ' Dark red
        lblBooks1.Cursor = Cursors.Hand
    End Sub

    ' MouseLeave for lblBooks1
    Private Sub lblBooks1_MouseLeave(sender As Object, e As EventArgs) Handles lblBooks1.MouseLeave
        lblBooks1.ForeColor = Color.Black ' Back to black
    End Sub

    ' MouseEnter for lblBorrowingofBooks1
    Private Sub lblBorrowingofBooks1_MouseEnter(sender As Object, e As EventArgs) Handles lblBorrowingofBooks1.MouseEnter
        lblBorrowingofBooks1.ForeColor = Color.FromArgb(139, 0, 0) ' Dark red
        lblBorrowingofBooks1.Cursor = Cursors.Hand
    End Sub

    ' MouseLeave for lblBorrowingofBooks1
    Private Sub lblBorrowingofBooks1_MouseLeave(sender As Object, e As EventArgs) Handles lblBorrowingofBooks1.MouseLeave
        lblBorrowingofBooks1.ForeColor = Color.Black ' Back to black
    End Sub

    ' MouseEnter for lblNewReleases1
    Private Sub lblNewReleases1_MouseEnter(sender As Object, e As EventArgs) Handles lblNewReleases1.MouseEnter
        lblNewReleases1.ForeColor = Color.FromArgb(139, 0, 0) ' Dark red
        lblNewReleases1.Cursor = Cursors.Hand
    End Sub

    ' MouseLeave for lblNewReleases1
    Private Sub lblNewReleases1_MouseLeave(sender As Object, e As EventArgs) Handles lblNewReleases1.MouseLeave
        lblNewReleases1.ForeColor = Color.Black ' Back to black
    End Sub
End Class