<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserInterface
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
        Me.MinimizedWindow3 = New System.Windows.Forms.PictureBox()
        Me.MaximizeWindow3 = New System.Windows.Forms.PictureBox()
        Me.CloseWindow3 = New System.Windows.Forms.PictureBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.ProfilePictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NotifBellBox1 = New System.Windows.Forms.PictureBox()
        Me.SearchPicture1 = New System.Windows.Forms.PictureBox()
        Me.txtSearch1 = New System.Windows.Forms.TextBox()
        Me.lblNewReleases1 = New System.Windows.Forms.Label()
        Me.lblBorrowingofBooks1 = New System.Windows.Forms.Label()
        Me.lblBooks1 = New System.Windows.Forms.Label()
        Me.flpBookCovers = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DetailsPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbDescription = New System.Windows.Forms.RichTextBox()
        Me.BackWindow1 = New System.Windows.Forms.PictureBox()
        Me.dtpReleaseDate = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.Label()
        Me.txtGenre = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.Label()
        Me.txtBookTitle = New System.Windows.Forms.Label()
        Me.pbBookCover1 = New System.Windows.Forms.PictureBox()
        Me.ChapterContentPanel = New System.Windows.Forms.Panel()
        Me.rtbChapterContentDisplay = New System.Windows.Forms.RichTextBox()
        Me.lblChapterTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.MinimizedWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaximizeWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.ProfilePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotifBellBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchPicture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpBookCovers.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.DetailsPanel.SuspendLayout()
        CType(Me.BackWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBookCover1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChapterContentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MinimizedWindow3)
        Me.Panel1.Controls.Add(Me.MaximizeWindow3)
        Me.Panel1.Controls.Add(Me.CloseWindow3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1649, 52)
        Me.Panel1.TabIndex = 0
        '
        'MinimizedWindow3
        '
        Me.MinimizedWindow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizedWindow3.Image = Global.LoginNRegisterPage.My.Resources.Resources.MinimizedWindow
        Me.MinimizedWindow3.Location = New System.Drawing.Point(1529, 15)
        Me.MinimizedWindow3.Name = "MinimizedWindow3"
        Me.MinimizedWindow3.Size = New System.Drawing.Size(28, 26)
        Me.MinimizedWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimizedWindow3.TabIndex = 5
        Me.MinimizedWindow3.TabStop = False
        '
        'MaximizeWindow3
        '
        Me.MaximizeWindow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximizeWindow3.Image = Global.LoginNRegisterPage.My.Resources.Resources.MaximizeWindow
        Me.MaximizeWindow3.Location = New System.Drawing.Point(1569, 15)
        Me.MaximizeWindow3.Name = "MaximizeWindow3"
        Me.MaximizeWindow3.Size = New System.Drawing.Size(28, 26)
        Me.MaximizeWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MaximizeWindow3.TabIndex = 4
        Me.MaximizeWindow3.TabStop = False
        '
        'CloseWindow3
        '
        Me.CloseWindow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseWindow3.Image = Global.LoginNRegisterPage.My.Resources.Resources.CloseWindow
        Me.CloseWindow3.Location = New System.Drawing.Point(1609, 15)
        Me.CloseWindow3.Name = "CloseWindow3"
        Me.CloseWindow3.Size = New System.Drawing.Size(28, 26)
        Me.CloseWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseWindow3.TabIndex = 2
        Me.CloseWindow3.TabStop = False
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Guna2GradientPanel1.Controls.Add(Me.ProfilePictureBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.NotifBellBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.SearchPicture1)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtSearch1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblNewReleases1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblBorrowingofBooks1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblBooks1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.PowderBlue
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 52)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1649, 113)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'ProfilePictureBox1
        '
        Me.ProfilePictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProfilePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.ProfilePictureBox1.Image = Global.LoginNRegisterPage.My.Resources.Resources.UserProfile
        Me.ProfilePictureBox1.Location = New System.Drawing.Point(1578, 38)
        Me.ProfilePictureBox1.Name = "ProfilePictureBox1"
        Me.ProfilePictureBox1.Size = New System.Drawing.Size(53, 47)
        Me.ProfilePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePictureBox1.TabIndex = 15
        Me.ProfilePictureBox1.TabStop = False
        '
        'NotifBellBox1
        '
        Me.NotifBellBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NotifBellBox1.BackColor = System.Drawing.Color.Transparent
        Me.NotifBellBox1.Image = Global.LoginNRegisterPage.My.Resources.Resources.NotificationBell
        Me.NotifBellBox1.Location = New System.Drawing.Point(1276, 40)
        Me.NotifBellBox1.Name = "NotifBellBox1"
        Me.NotifBellBox1.Size = New System.Drawing.Size(48, 43)
        Me.NotifBellBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NotifBellBox1.TabIndex = 14
        Me.NotifBellBox1.TabStop = False
        '
        'SearchPicture1
        '
        Me.SearchPicture1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchPicture1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SearchPicture1.Image = Global.LoginNRegisterPage.My.Resources.Resources.SearchBar
        Me.SearchPicture1.Location = New System.Drawing.Point(1530, 48)
        Me.SearchPicture1.Name = "SearchPicture1"
        Me.SearchPicture1.Size = New System.Drawing.Size(28, 26)
        Me.SearchPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SearchPicture1.TabIndex = 13
        Me.SearchPicture1.TabStop = False
        '
        'txtSearch1
        '
        Me.txtSearch1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch1.Location = New System.Drawing.Point(1338, 44)
        Me.txtSearch1.Name = "txtSearch1"
        Me.txtSearch1.Size = New System.Drawing.Size(222, 34)
        Me.txtSearch1.TabIndex = 12
        '
        'lblNewReleases1
        '
        Me.lblNewReleases1.AutoSize = True
        Me.lblNewReleases1.BackColor = System.Drawing.Color.Transparent
        Me.lblNewReleases1.Font = New System.Drawing.Font("Baskerville Old Face", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewReleases1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNewReleases1.Location = New System.Drawing.Point(571, 45)
        Me.lblNewReleases1.Name = "lblNewReleases1"
        Me.lblNewReleases1.Size = New System.Drawing.Size(234, 43)
        Me.lblNewReleases1.TabIndex = 11
        Me.lblNewReleases1.Text = "New Releases"
        '
        'lblBorrowingofBooks1
        '
        Me.lblBorrowingofBooks1.AutoSize = True
        Me.lblBorrowingofBooks1.BackColor = System.Drawing.Color.Transparent
        Me.lblBorrowingofBooks1.Font = New System.Drawing.Font("Baskerville Old Face", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowingofBooks1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBorrowingofBooks1.Location = New System.Drawing.Point(198, 45)
        Me.lblBorrowingofBooks1.Name = "lblBorrowingofBooks1"
        Me.lblBorrowingofBooks1.Size = New System.Drawing.Size(333, 43)
        Me.lblBorrowingofBooks1.TabIndex = 10
        Me.lblBorrowingofBooks1.Text = "Borrowing of Books"
        '
        'lblBooks1
        '
        Me.lblBooks1.AutoSize = True
        Me.lblBooks1.BackColor = System.Drawing.Color.Transparent
        Me.lblBooks1.Font = New System.Drawing.Font("Baskerville Old Face", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooks1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBooks1.Location = New System.Drawing.Point(40, 45)
        Me.lblBooks1.Name = "lblBooks1"
        Me.lblBooks1.Size = New System.Drawing.Size(118, 43)
        Me.lblBooks1.TabIndex = 9
        Me.lblBooks1.Text = "Books"
        '
        'flpBookCovers
        '
        Me.flpBookCovers.Controls.Add(Me.FlowLayoutPanel1)
        Me.flpBookCovers.Controls.Add(Me.Guna2GradientPanel2)
        Me.flpBookCovers.Cursor = System.Windows.Forms.Cursors.Default
        Me.flpBookCovers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpBookCovers.FillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.flpBookCovers.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.flpBookCovers.Location = New System.Drawing.Point(0, 165)
        Me.flpBookCovers.Name = "flpBookCovers"
        Me.flpBookCovers.ShadowDecoration.Parent = Me.flpBookCovers
        Me.flpBookCovers.Size = New System.Drawing.Size(1649, 774)
        Me.flpBookCovers.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 67)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1649, 707)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel2.FillColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.RoyalBlue
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(1649, 67)
        Me.Guna2GradientPanel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Recommendation"
        '
        'DetailsPanel
        '
        Me.DetailsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DetailsPanel.Controls.Add(Me.Label3)
        Me.DetailsPanel.Controls.Add(Me.ListBox1)
        Me.DetailsPanel.Controls.Add(Me.Label1)
        Me.DetailsPanel.Controls.Add(Me.rtbDescription)
        Me.DetailsPanel.Controls.Add(Me.BackWindow1)
        Me.DetailsPanel.Controls.Add(Me.dtpReleaseDate)
        Me.DetailsPanel.Controls.Add(Me.cmbStatus)
        Me.DetailsPanel.Controls.Add(Me.txtGenre)
        Me.DetailsPanel.Controls.Add(Me.txtAuthor)
        Me.DetailsPanel.Controls.Add(Me.txtBookTitle)
        Me.DetailsPanel.Controls.Add(Me.pbBookCover1)
        Me.DetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailsPanel.Location = New System.Drawing.Point(0, 165)
        Me.DetailsPanel.Name = "DetailsPanel"
        Me.DetailsPanel.Size = New System.Drawing.Size(1649, 774)
        Me.DetailsPanel.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1238, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Chapters:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(1233, 173)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(240, 324)
        Me.ListBox1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(661, 471)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Description:"
        '
        'rtbDescription
        '
        Me.rtbDescription.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDescription.Location = New System.Drawing.Point(665, 505)
        Me.rtbDescription.Name = "rtbDescription"
        Me.rtbDescription.Size = New System.Drawing.Size(452, 121)
        Me.rtbDescription.TabIndex = 11
        Me.rtbDescription.Text = ""
        '
        'BackWindow1
        '
        Me.BackWindow1.BackColor = System.Drawing.Color.Transparent
        Me.BackWindow1.Image = Global.LoginNRegisterPage.My.Resources.Resources.BackWindow
        Me.BackWindow1.Location = New System.Drawing.Point(4, 5)
        Me.BackWindow1.Name = "BackWindow1"
        Me.BackWindow1.Size = New System.Drawing.Size(66, 62)
        Me.BackWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackWindow1.TabIndex = 10
        Me.BackWindow1.TabStop = False
        '
        'dtpReleaseDate
        '
        Me.dtpReleaseDate.AutoSize = True
        Me.dtpReleaseDate.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReleaseDate.Location = New System.Drawing.Point(662, 404)
        Me.dtpReleaseDate.Name = "dtpReleaseDate"
        Me.dtpReleaseDate.Size = New System.Drawing.Size(68, 21)
        Me.dtpReleaseDate.TabIndex = 5
        Me.dtpReleaseDate.Text = "Label5"
        '
        'cmbStatus
        '
        Me.cmbStatus.AutoSize = True
        Me.cmbStatus.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.Location = New System.Drawing.Point(661, 361)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(68, 21)
        Me.cmbStatus.TabIndex = 4
        Me.cmbStatus.Text = "Label4"
        '
        'txtGenre
        '
        Me.txtGenre.AutoSize = True
        Me.txtGenre.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenre.Location = New System.Drawing.Point(662, 314)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(68, 21)
        Me.txtGenre.TabIndex = 3
        Me.txtGenre.Text = "Label3"
        '
        'txtAuthor
        '
        Me.txtAuthor.AutoSize = True
        Me.txtAuthor.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(661, 269)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(68, 21)
        Me.txtAuthor.TabIndex = 2
        Me.txtAuthor.Text = "Label2"
        '
        'txtBookTitle
        '
        Me.txtBookTitle.AutoSize = True
        Me.txtBookTitle.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle.Location = New System.Drawing.Point(659, 173)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(105, 33)
        Me.txtBookTitle.TabIndex = 1
        Me.txtBookTitle.Text = "Label1"
        '
        'pbBookCover1
        '
        Me.pbBookCover1.Location = New System.Drawing.Point(246, 141)
        Me.pbBookCover1.Name = "pbBookCover1"
        Me.pbBookCover1.Size = New System.Drawing.Size(353, 485)
        Me.pbBookCover1.TabIndex = 0
        Me.pbBookCover1.TabStop = False
        '
        'ChapterContentPanel
        '
        Me.ChapterContentPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ChapterContentPanel.Controls.Add(Me.rtbChapterContentDisplay)
        Me.ChapterContentPanel.Controls.Add(Me.lblChapterTitle)
        Me.ChapterContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChapterContentPanel.Location = New System.Drawing.Point(0, 165)
        Me.ChapterContentPanel.Name = "ChapterContentPanel"
        Me.ChapterContentPanel.Size = New System.Drawing.Size(1649, 774)
        Me.ChapterContentPanel.TabIndex = 15
        '
        'rtbChapterContentDisplay
        '
        Me.rtbChapterContentDisplay.Location = New System.Drawing.Point(47, 142)
        Me.rtbChapterContentDisplay.Name = "rtbChapterContentDisplay"
        Me.rtbChapterContentDisplay.Size = New System.Drawing.Size(1413, 511)
        Me.rtbChapterContentDisplay.TabIndex = 1
        Me.rtbChapterContentDisplay.Text = ""
        '
        'lblChapterTitle
        '
        Me.lblChapterTitle.AutoSize = True
        Me.lblChapterTitle.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChapterTitle.Location = New System.Drawing.Point(692, 5)
        Me.lblChapterTitle.Name = "lblChapterTitle"
        Me.lblChapterTitle.Size = New System.Drawing.Size(72, 24)
        Me.lblChapterTitle.TabIndex = 0
        Me.lblChapterTitle.Text = "Label4"
        '
        'UserInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1649, 939)
        Me.Controls.Add(Me.flpBookCovers)
        Me.Controls.Add(Me.ChapterContentPanel)
        Me.Controls.Add(Me.DetailsPanel)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.MinimizedWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaximizeWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.ProfilePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotifBellBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchPicture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpBookCovers.ResumeLayout(False)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.DetailsPanel.ResumeLayout(False)
        Me.DetailsPanel.PerformLayout()
        CType(Me.BackWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBookCover1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChapterContentPanel.ResumeLayout(False)
        Me.ChapterContentPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CloseWindow3 As PictureBox
    Friend WithEvents MaximizeWindow3 As PictureBox
    Friend WithEvents MinimizedWindow3 As PictureBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents ProfilePictureBox1 As PictureBox
    Friend WithEvents NotifBellBox1 As PictureBox
    Friend WithEvents SearchPicture1 As PictureBox
    Friend WithEvents txtSearch1 As TextBox
    Friend WithEvents lblNewReleases1 As Label
    Friend WithEvents lblBorrowingofBooks1 As Label
    Friend WithEvents lblBooks1 As Label
    Friend WithEvents flpBookCovers As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents DetailsPanel As Panel
    Friend WithEvents dtpReleaseDate As Label
    Friend WithEvents cmbStatus As Label
    Friend WithEvents txtGenre As Label
    Friend WithEvents txtAuthor As Label
    Friend WithEvents txtBookTitle As Label
    Friend WithEvents pbBookCover1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BackWindow1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rtbDescription As RichTextBox
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ChapterContentPanel As Panel
    Friend WithEvents lblChapterTitle As Label
    Friend WithEvents rtbChapterContentDisplay As RichTextBox
End Class
