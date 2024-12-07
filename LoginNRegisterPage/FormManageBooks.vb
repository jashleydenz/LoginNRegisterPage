Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Guna.UI2.WinForms.Suite
Imports Org.BouncyCastle.Asn1.Cmp
Imports ZstdSharp.Unsafe

Public Class FormManageBooks
    Private savePath As String = Path.Combine(Application.StartupPath, "bookstore1.txt")
    '================= API for Rounded Corners ================='
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(
        ByVal nLeftRect As Integer,
        ByVal nTopRect As Integer,
        ByVal nRightRect As Integer,
        ByVal nBottomRect As Integer,
        ByVal nWidthEllipse As Integer,
        ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    '==================== Variables ==========================='
    Private drag As Boolean ' For form dragging
    Private mouseX As Integer
    Private mouseY As Integer
    Private totalBooksReleased As Integer = 0 ' Counter for books
    Private editingIndex As Integer = -1 ' Current editing index

    ' Original book details (for edit mode)
    Private originalTitle As String
    Private originalAuthor As String
    Private originalGenre As String
    Private originalDateReleased As Date
    Private originalBookStatus As String



    '================= Form Load =============================='
    Private Sub FormManageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add columns (if not added in Designer)
        With dgvBooks
            .Columns.Add("Title", "Title")
            .Columns.Add("Author", "Author")
            .Columns.Add("Genre", "Genre")
            .Columns.Add("ReleaseDate", "Release Date")
            .Columns.Add("Status", "Status")
            .Columns.Add("CoverPath", "Cover Path")
            .Columns.Add("Description", "Description")
        End With

        ' Load data into DataGridView
        LoadBooksIntoDataGridView()
        LoadBookTitlesIntoComboBox()

        ' Set custom form style
        Me.FormBorderStyle = FormBorderStyle.None
        Dim radius As Integer = 20
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))
        Me.BackColor = Color.White

        ' Initialize ComboBox values
        cmbStatus1.Items.AddRange(New String() {"Available", "Returned", "Borrowed"})
        cmbStatus2.Items.AddRange(New String() {"Available", "Returned", "Borrowed"})


        ' Assign event handlers
        AddEventHandlers()
        Me.ActiveControl = Nothing

        Guna2GradientPanel1.Visible = True
        Guna2GradientPanel2.Visible = False
    End Sub

    '================= Event Handlers =========================='
    Private Sub AddEventHandlers()
        ' Close and Minimize buttons
        AddHandler CloseWindow3.Click, AddressOf CloseWindow_Click
        AddHandler MinimizedWindow3.Click, AddressOf MinimizeWindow_Click
        AddHandler MaximizeWindow3.Click, AddressOf MaximizeWindow_Click

        ' Hover effects for close/minimize/maximize
        AddHandler CloseWindow3.MouseEnter, AddressOf Button_MouseEnter
        AddHandler CloseWindow3.MouseLeave, AddressOf Button_MouseLeave
        AddHandler MinimizedWindow3.MouseEnter, AddressOf Button_MouseEnter
        AddHandler MinimizedWindow3.MouseLeave, AddressOf Button_MouseLeave
        AddHandler MaximizeWindow3.MouseEnter, AddressOf Button_MouseEnter
        AddHandler MaximizeWindow3.MouseLeave, AddressOf Button_MouseLeave

        ' Back button hover
        AddHandler BackWindow1.MouseEnter, AddressOf Button_MouseEnter
        AddHandler BackWindow1.MouseLeave, AddressOf Button_MouseLeave

        ' Navigation labels
        AddHandler lblAddBooks1.MouseEnter, AddressOf Label_MouseEnter
        AddHandler lblAddBooks1.MouseLeave, AddressOf Label_MouseLeave
        AddHandler lblEditBooks1.MouseEnter, AddressOf Label_MouseEnter
        AddHandler lblEditBooks1.MouseLeave, AddressOf Label_MouseLeave

        ' Form dragging
        AddHandler Panel1.MouseDown, AddressOf Panel_MouseDown
        AddHandler Panel1.MouseMove, AddressOf Panel_MouseMove
        AddHandler Panel1.MouseUp, AddressOf Panel_MouseUp
        AddHandler Guna2GradientPanel1.MouseDown, AddressOf Panel_MouseDown
        AddHandler Guna2GradientPanel1.MouseMove, AddressOf Panel_MouseMove
        AddHandler Guna2GradientPanel1.MouseUp, AddressOf Panel_MouseUp
    End Sub

    '================= Button and Label Clicks ================'
    Private Sub CloseWindow_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub MinimizeWindow_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MaximizeWindow_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            Me.Bounds = Screen.PrimaryScreen.Bounds
        Else
            Me.WindowState = FormWindowState.Normal
        End If
        UpdateRoundedCorners()
    End Sub

    Private Sub BackWindow1_Click(sender As Object, e As EventArgs) Handles BackWindow1.Click
        AdminDashboard.Show()
        Me.Close()
    End Sub

    '================= UI Enhancements ========================='
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        CType(sender, Control).Cursor = Cursors.Hand
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        CType(sender, Control).Cursor = Cursors.Default
    End Sub

    Private Sub Label_MouseEnter(sender As Object, e As EventArgs)
        Select Case CType(sender, Label).Name
            Case "lblAddBooks1"
                lblAddBooks1.ForeColor = Color.FromArgb(139, 0, 0) ' Dark red
            Case "lblEditBooks1"
                lblEditBooks1.ForeColor = Color.FromArgb(139, 0, 0) ' Dark red
        End Select
        CType(sender, Label).Cursor = Cursors.Hand
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs)
        Select Case CType(sender, Label).Name
            Case "lblAddBooks1"
                lblAddBooks1.ForeColor = Color.Black ' Back to black
            Case "lblEditBooks1"
                lblEditBooks1.ForeColor = Color.Black ' Back to black
        End Select
        CType(sender, Label).Cursor = Cursors.Default
    End Sub

    '================= Panel Management ========================'
    Private Sub ShowPanel(panel As Panel)
        Guna2GradientPanel1.Visible = False
        Guna2GradientPanel2.Visible = False
        panel.Visible = True
    End Sub

    Private Sub UpdateRoundedCorners()
        Dim radius As Integer = 20
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Me.Width, Me.Height, radius, radius))
    End Sub

    '================= Dragging Functionality =================='
    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel_MouseMove(sender As Object, e As MouseEventArgs)
        If drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Panel_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub

    '================= Image Upload ============================'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnAddImage1.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                pbBookCover1.Image = Image.FromFile(openFileDialog.FileName)
                pbBookCover1.Tag = openFileDialog.FileName ' Save the file path in the Tag property
            End If
        End Using
    End Sub

    Private Sub btnSave1_Click(sender As Object, e As EventArgs) Handles btnSave1.Click
        ' Ensure all required fields are filled
        If String.IsNullOrWhiteSpace(txtBookTitle1.Text) OrElse
       String.IsNullOrWhiteSpace(txtAuthor1.Text) OrElse
       String.IsNullOrWhiteSpace(txtGenre1.Text) OrElse
       cmbStatus1.SelectedIndex = -1 OrElse
       pbBookCover1.Image Is Nothing OrElse
       String.IsNullOrWhiteSpace(rtbDescription1.Text) Then
            MessageBox.Show("Please fill out all fields and select a cover image.")
            Return
        End If

        Dim coverFilePath As String = If(pbBookCover1.Tag?.ToString(), String.Empty)

        If String.IsNullOrEmpty(coverFilePath) OrElse Not File.Exists(coverFilePath) Then
            MessageBox.Show("Please select a valid book cover before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Stop the save process if no valid cover is selected
        End If

        Dim bookStatus As String = cmbStatus1.SelectedItem.ToString()
        Dim bookDetails As String = $"{txtBookTitle1.Text}|{txtAuthor1.Text}|{txtGenre1.Text}|{dtpReleaseDate1.Value.ToString("yyyy-MM-dd")}|{bookStatus}|{coverFilePath}|{rtbDescription1.Text}"

        File.AppendAllLines(savePath, New String() {bookDetails})

        ' Clear inputs after saving
        MessageBox.Show("Book saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearInputs()

        LoadBooksIntoDataGridView()
        LoadBookTitlesIntoComboBox()
    End Sub

    Private Sub ClearInputs()
        txtBookTitle1.Clear()
        txtAuthor1.Clear()
        txtGenre1.Clear()
        cmbStatus1.SelectedIndex = -1
        dtpReleaseDate1.Value = DateTime.Now
        pbBookCover1.Image = Nothing
        pbBookCover1.Tag = Nothing
        rtbDescription1.Clear()
    End Sub

    Private Sub ClearInputs1()
        txtBookTitle2.Clear()
        txtAuthor2.Clear()
        txtGenre2.Clear()
        cmbStatus2.SelectedIndex = -1
        dtpReleaseDate2.Value = DateTime.Now
        pbPictureCover2.Image = Nothing
        pbPictureCover2.Tag = Nothing
        rtbDescription2.Clear()
    End Sub

    Private Sub LoadBookTitlesIntoComboBox()
        cmbSpecificBook1.Items.Clear()

        If File.Exists(savePath) Then
            Dim bookEntries = File.ReadAllLines(savePath)

            For Each entry In bookEntries
                Dim title = entry.Split("|"c)(0)
                cmbSpecificBook1.Items.Add(title)
            Next
        End If
    End Sub

    Private Sub LoadBooksIntoDataGridView()
        dgvBooks.Rows.Clear() ' Clear existing rows

        If File.Exists(savePath) Then
            Dim bookEntries = File.ReadAllLines(savePath)
            For Each entry In bookEntries
                Dim details = entry.Split("|"c)
                If details.Length = 7 Then
                    dgvBooks.Rows.Add(details(0), details(1), details(2), details(3), details(4), details(5), details(6))
                Else
                    MessageBox.Show($"Invalid entry: {entry}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Next
        Else
            MessageBox.Show("The file 'bookstore1.txt' does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub lblEditBooks1_Click(sender As Object, e As EventArgs) Handles lblEditBooks1.Click
        Guna2GradientPanel2.Visible = True
        Guna2GradientPanel1.Visible = False
    End Sub

    Private Sub lblAddBooks1_Click(sender As Object, e As EventArgs) Handles lblAddBooks1.Click
        Guna2GradientPanel1.Visible = True
        Guna2GradientPanel2.Visible = False
    End Sub

    ' Load selected row into inputs for editing (optional)
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow = dgvBooks.Rows(e.RowIndex)

            ' Populate the fields with data from the selected row
            txtBookTitle2.Text = selectedRow.Cells(0).Value.ToString() ' Title
            txtAuthor2.Text = selectedRow.Cells(1).Value.ToString()    ' Author
            txtGenre2.Text = selectedRow.Cells(2).Value.ToString()     ' Genre
            rtbDescription2.Text = selectedRow.Cells(6).Value.ToString() ' Description (correct column for description)

            ' Safely parse the ReleaseDate from DataGridView cell
            Dim releaseDateString = selectedRow.Cells(3).Value.ToString() ' Assuming column 3 holds the ReleaseDate
            Dim releaseDate As DateTime

            ' Try to parse the date, and if successful, set it in the DateTimePicker
            If DateTime.TryParse(releaseDateString, releaseDate) Then
                dtpReleaseDate2.Value = releaseDate
            Else
                MessageBox.Show("Invalid date format in the selected row.")
            End If

            ' Set Status
            cmbStatus2.SelectedItem = selectedRow.Cells(4).Value.ToString() ' Status (correct column for status)

            ' Load image into PictureBox
            Dim coverImagePath = selectedRow.Cells(5).Value.ToString() ' Assuming column 5 holds the Cover Image Path
            If File.Exists(coverImagePath) Then
                pbPictureCover2.Image = Image.FromFile(coverImagePath)
                pbPictureCover2.Tag = coverImagePath ' Save the cover path in the Tag
            End If
        End If
    End Sub



    Private Sub DeleteSelectedBook()
        If dgvBooks.SelectedRows.Count > 0 Then
            ' Get the selected row and book title
            Dim selectedRow = dgvBooks.SelectedRows(0)
            Dim titleToDelete = selectedRow.Cells(0).Value.ToString()

            ' Remove the selected row from the DataGridView
            dgvBooks.Rows.Remove(selectedRow)

            ' Update the text file by removing the book entry
            If File.Exists(savePath) Then
                Dim bookEntries = File.ReadAllLines(savePath).ToList()
                bookEntries = bookEntries.Where(Function(entry) Not entry.StartsWith(titleToDelete & "|")).ToList()
                File.WriteAllLines(savePath, bookEntries)
            End If

            ' Show confirmation message and refresh ComboBox
            MessageBox.Show("Book deleted successfully!")

        Else
            MessageBox.Show("Please select a book to delete.")
        End If

        ' Clear inputs after deletion
        ClearInputs()
    End Sub

    Private Sub btnDelete1_Click(sender As Object, e As EventArgs) Handles btnDelete1.Click
        DeleteSelectedBook()
        ClearInputs1()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if a row is selected
        If dgvBooks.SelectedRows.Count > 0 Then
            Dim selectedRow = dgvBooks.SelectedRows(0)

            ' Ensure all fields are filled
            If String.IsNullOrWhiteSpace(txtBookTitle2.Text) OrElse
                String.IsNullOrWhiteSpace(txtAuthor2.Text) OrElse
                String.IsNullOrWhiteSpace(txtGenre2.Text) OrElse
                cmbStatus2.SelectedIndex = -1 OrElse
                String.IsNullOrWhiteSpace(rtbDescription2.Text) OrElse
                pbPictureCover2.Image Is Nothing Then
                MessageBox.Show("Please fill out all fields and select a cover image.")
                Return
            End If

            ' Retrieve the edited values
            Dim updatedTitle = txtBookTitle2.Text
            Dim updatedAuthor = txtAuthor2.Text
            Dim updatedGenre = txtGenre2.Text
            Dim updatedStatus = cmbStatus2.SelectedItem.ToString()
            Dim updatedDescription = rtbDescription2.Text
            Dim updatedReleaseDate = dtpReleaseDate2.Value.ToString("yyyy-MM-dd")
            Dim updatedCoverPath = pbPictureCover2.Tag?.ToString()

            ' Update the selected row with the edited values
            selectedRow.Cells(0).Value = updatedTitle ' Title
            selectedRow.Cells(1).Value = updatedAuthor ' Author
            selectedRow.Cells(2).Value = updatedGenre ' Genre
            selectedRow.Cells(3).Value = updatedReleaseDate ' Release Date
            selectedRow.Cells(4).Value = updatedStatus ' Status
            selectedRow.Cells(5).Value = updatedCoverPath ' Cover Image Path
            selectedRow.Cells(6).Value = updatedDescription ' Description

            ' Update the data in the text file
            If File.Exists(savePath) Then
                Dim bookEntries = File.ReadAllLines(savePath).ToList()
                For i = 0 To bookEntries.Count - 1
                    ' Update the entry corresponding to the selected title
                    If bookEntries(i).StartsWith(selectedRow.Cells(0).Value.ToString() & "|") Then
                        bookEntries(i) = $"{updatedTitle}|{updatedAuthor}|{updatedGenre}|{updatedReleaseDate}|{updatedStatus}|{updatedCoverPath}|{updatedDescription}"
                        Exit For
                    End If
                Next
                ' Save the updated list back to the file
                File.WriteAllLines(savePath, bookEntries)
            End If

            MessageBox.Show("Book updated successfully!")
            ClearInputs()
            LoadBooksIntoDataGridView() ' Reload the books into the DataGridView
        Else
            MessageBox.Show("Please select a book to edit.")
        End If
    End Sub

    Private Sub btnSubmit1_Click(sender As Object, e As EventArgs) Handles btnSubmit1.Click
        If String.IsNullOrWhiteSpace(txtChapterTitle1.Text) OrElse cmbSpecificBook1.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a book and enter a chapter title before submitting.")
            Return
        End If

        Dim selectedBook As String = cmbSpecificBook1.SelectedItem.ToString()
        Dim chapterContent As String = rtbChapterContent1.Text
        Dim chapterDetails As String = $"{selectedBook}|{txtChapterTitle1.Text}|{chapterContent}"
        Dim chapterPath As String = Path.Combine(Application.StartupPath, "chapters.txt")

        File.AppendAllLines(chapterPath, New String() {chapterDetails})
        MessageBox.Show("Chapter title and content submitted successfully!")
    End Sub
End Class

