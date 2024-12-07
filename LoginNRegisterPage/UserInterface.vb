Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Reflection.Emit
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Guna.UI2.WinForms.Suite
Imports Org.BouncyCastle.Asn1.Cmp
Imports Org.BouncyCastle.Pqc.Crypto

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
    Private Sub LoadBookCovers()
        Dim savePath As String = Path.Combine(Application.StartupPath, "bookstore1.txt")

        ' Ensure FlowLayoutPanel is visible and DetailsPanel is hidden initially
        FlowLayoutPanel1.Visible = True
        DetailsPanel.Visible = False
        ChapterContentPanel.Visible = False

        If File.Exists(savePath) Then
            Dim bookEntries = File.ReadAllLines(savePath)

            For Each entry In bookEntries
                Dim details = entry.Split("|"c)
                Dim coverImagePath = details(5).Trim() ' Image path is in the 3rd column

                ' Create a PictureBox for each book
                Dim cover As New PictureBox()
                If Not String.IsNullOrWhiteSpace(coverImagePath) AndAlso File.Exists(coverImagePath) Then
                    cover.Image = Image.FromFile(coverImagePath)
                End If

                cover.SizeMode = PictureBoxSizeMode.StretchImage
                cover.Width = 156
                cover.Height = 230
                cover.Margin = New Padding(5) ' Add padding around the PictureBox
                cover.Tag = entry ' Store all details in the Tag


                AddHandler cover.Click, AddressOf PictureBox_Click ' Ensure the PictureBox is clickable

                ' Add the PictureBox to the FlowLayoutPanel
                FlowLayoutPanel1.Controls.Add(cover)
            Next
        End If
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookCovers()

        flpBookCovers.Visible = True
        DetailsPanel.Visible = False

        ' Remove the default title bar
        ' Me.FormBorderStyle = FormBorderStyle.None

        ' Set a clean, rounded corner radius
        Dim radius As Integer = 20  ' Use a smaller value for crisper edges
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))

        ' Optional: Set background color to highlight edges better
        Me.BackColor = Color.White

        ' Add click event handlers
        AddHandler CloseWindow3.Click, AddressOf CloseWindow1_Click
        AddHandler MinimizedWindow3.Click, AddressOf MinimizedWindow1_Click

        ' Add hover effect event handlers
        AddHandler CloseWindow3.MouseEnter, AddressOf CloseWindow3_MouseEnter
        AddHandler CloseWindow3.MouseLeave, AddressOf CloseWindow3_MouseLeave
        AddHandler MinimizedWindow3.MouseEnter, AddressOf MinimizedWindow3_MouseEnter
        AddHandler MinimizedWindow3.MouseLeave, AddressOf MinimizedWindow3_MouseLeave
        AddHandler MaximizeWindow3.MouseEnter, AddressOf MaximizeWindow3_MouseEnter
        AddHandler MaximizeWindow3.MouseLeave, AddressOf MaximizeWindow3_MouseLeave

        ' Add dragging events to the Panel
        AddHandler Panel1.MouseDown, AddressOf Panel_MouseDown
        AddHandler Panel1.MouseMove, AddressOf Panel_MouseMove
        AddHandler Panel1.MouseUp, AddressOf Panel_MouseUp

        AddHandler Guna2GradientPanel1.MouseDown, AddressOf Panel_MouseDown
        AddHandler Guna2GradientPanel1.MouseMove, AddressOf Panel_MouseMove
        AddHandler Guna2GradientPanel1.MouseUp, AddressOf Panel_MouseUp

        AddHandler flpBookCovers.MouseDown, AddressOf Panel_MouseDown
        AddHandler flpBookCovers.MouseMove, AddressOf Panel_MouseMove
        AddHandler flpBookCovers.MouseUp, AddressOf Panel_MouseUp

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

    ' Event handler for minimize button click
    Private Sub MinimizedWindow1_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
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


    Private Sub NotifBellBox1_MouseEnter(sender As Object, e As EventArgs) Handles NotifBellBox1.MouseEnter
        NotifBellBox1.Cursor = Cursors.Hand
    End Sub

    Private Sub NotifBellBox1_MouseLeave(sender As Object, e As EventArgs) Handles NotifBellBox1.MouseLeave
        NotifBellBox1.Cursor = Cursors.Hand
    End Sub

    Private Sub CloseWindow3_MouseEnter(sender As Object, e As EventArgs) Handles CloseWindow3.MouseEnter
        CloseWindow3.Cursor = Cursors.Hand
    End Sub

    Private Sub CloseWindow3_MouseLeave(sender As Object, e As EventArgs) Handles CloseWindow3.MouseLeave
        CloseWindow3.Cursor = Cursors.Hand
    End Sub

    Private Sub MaximizeWindow3_MouseEnter(sender As Object, e As EventArgs) Handles MaximizeWindow3.MouseEnter
        MaximizeWindow3.Cursor = Cursors.Hand
    End Sub

    Private Sub MaximizeWindow3_MouseLeave(sender As Object, e As EventArgs) Handles MaximizeWindow3.MouseLeave
        MaximizeWindow3.Cursor = Cursors.Hand
    End Sub

    Private Sub MinimizedWindow3_MouseEnter(sender As Object, e As EventArgs) Handles MinimizedWindow3.MouseEnter
        MinimizedWindow3.Cursor = Cursors.Hand
    End Sub

    Private Sub MinimizedWindow3_MouseLeave(sender As Object, e As EventArgs) Handles MinimizedWindow3.MouseLeave
        MinimizedWindow3.Cursor = Cursors.Hand
    End Sub

    Private Sub CloseWindow3_Click(sender As Object, e As EventArgs) Handles CloseWindow3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        Dim clickedPictureBox As PictureBox = CType(sender, PictureBox)
        Dim details = clickedPictureBox.Tag.ToString().Split("|"c)

        ' Load details into the details panel
        Dim title = details(0)
        Dim author = details(1)
        Dim genre = details(2)
        Dim dateReleased = details(3)
        Dim bookStatus = details(4)
        Dim coverImagePath = details(5)
        Dim description = details(6)

        ' Display the book cover
        If File.Exists(coverImagePath) Then
            pbBookCover1.Image = Image.FromFile(coverImagePath)
        Else
        End If
        pbBookCover1.SizeMode = PictureBoxSizeMode.StretchImage

        ' Load chapters into ListBox
        LoadChaptersIntoListBox(title)

        ' Display the book details
        txtBookTitle.Text = title
        txtAuthor.Text = "Author: " & author
        txtGenre.Text = "Genre: " & genre
        cmbStatus.Text = "Status: " & bookStatus
        dtpReleaseDate.Text = "Release Date: " & dateReleased
        rtbDescription.Text = description

        ' Show the details panel and hide the flow panel
        DetailsPanel.Visible = True
        FlowLayoutPanel1.Visible = False
        Guna2GradientPanel2.Visible = False
        flpBookCovers.Visible = False
    End Sub

    Private Sub LoadChaptersIntoListBox(bookTitle As String)
        Dim chapterPath As String = Path.Combine(Application.StartupPath, "chapters.txt")
        ListBox1.Items.Clear()

        If File.Exists(chapterPath) Then
            Dim chapterEntries = File.ReadAllLines(chapterPath)

            For Each entry In chapterEntries
                Dim details = entry.Split("|"c)
                If details.Length >= 3 Then
                    Dim title = details(0)
                    Dim chapterTitle = details(1)

                    If title = bookTitle Then
                        ListBox1.Items.Add(chapterTitle)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim selectedChapter As String = ListBox1.SelectedItem.ToString()
            Dim bookTitle As String = txtBookTitle.Text.Substring(7) ' Extract the book title from the label

            ' Load the chapter content based on the selected chapter title
            LoadChapterContent(bookTitle, selectedChapter)

            ' Show the chapter content panel and hide the details panel
            ChapterContentPanel.Visible = True
            DetailsPanel.Visible = False
        Else
            MessageBox.Show("Please select a chapter.")
        End If
    End Sub


    Private Sub LoadChapterContent(bookTitle As String, chapterTitle As String)
        Dim chapterPath As String = Path.Combine(Application.StartupPath, "chapters.txt")

        If File.Exists(chapterPath) Then
            Dim chapterEntries = File.ReadAllLines(chapterPath)

            For Each entry In chapterEntries
                Dim details = entry.Split("|"c)
                If details.Length >= 3 Then
                    Dim title = details(0)
                    Dim chapter = details(1)
                    Dim content = details(2)

                    If title = bookTitle AndAlso chapter = chapterTitle Then
                        ' Display the chapter title and content
                        lblChapterTitle.Text = $"Chapter: {chapterTitle}"
                        rtbChapterContentDisplay.Text = content
                        Exit For
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub BackWindow1_Click_1(sender As Object, e As EventArgs) Handles BackWindow1.Click
        FlowLayoutPanel1.Visible = True
        DetailsPanel.Visible = False
        Guna2GradientPanel2.Visible = True
        flpBookCovers.Visible = True
    End Sub
End Class