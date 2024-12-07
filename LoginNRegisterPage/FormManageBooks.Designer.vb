<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormManageBooks
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
        Me.btnSubmit1 = New System.Windows.Forms.Button()
        Me.cmbSpecificBook1 = New System.Windows.Forms.ComboBox()
        Me.lblChapterContent1 = New System.Windows.Forms.Label()
        Me.rtbChapterContent1 = New System.Windows.Forms.RichTextBox()
        Me.txtChapterTitle1 = New System.Windows.Forms.TextBox()
        Me.lblChapterTitle1 = New System.Windows.Forms.Label()
        Me.rtbDescription1 = New System.Windows.Forms.RichTextBox()
        Me.lblBookDescription1 = New System.Windows.Forms.Label()
        Me.dtpReleaseDate1 = New System.Windows.Forms.DateTimePicker()
        Me.pbBookCover1 = New System.Windows.Forms.PictureBox()
        Me.btnSave1 = New System.Windows.Forms.Button()
        Me.btnAddImage1 = New System.Windows.Forms.Button()
        Me.cmbStatus1 = New System.Windows.Forms.ComboBox()
        Me.txtGenre1 = New System.Windows.Forms.TextBox()
        Me.txtAuthor1 = New System.Windows.Forms.TextBox()
        Me.txtBookTitle1 = New System.Windows.Forms.TextBox()
        Me.lblDateReleased1 = New System.Windows.Forms.Label()
        Me.lblBookCover1 = New System.Windows.Forms.Label()
        Me.lblBookStatus1 = New System.Windows.Forms.Label()
        Me.lblGenre1 = New System.Windows.Forms.Label()
        Me.lblAuthor1 = New System.Windows.Forms.Label()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel4 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.BackWindow1 = New System.Windows.Forms.PictureBox()
        Me.lblEditBooks1 = New System.Windows.Forms.Label()
        Me.lblAddBooks1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rtbDescription2 = New System.Windows.Forms.RichTextBox()
        Me.pbPictureCover2 = New System.Windows.Forms.PictureBox()
        Me.btAddImage2 = New System.Windows.Forms.Button()
        Me.lblBookCover2 = New System.Windows.Forms.Label()
        Me.btnDelete1 = New System.Windows.Forms.Button()
        Me.lblNumberOfBooks1 = New System.Windows.Forms.Label()
        Me.lblBookArchives2 = New System.Windows.Forms.Label()
        Me.btnSave2 = New System.Windows.Forms.Button()
        Me.dtpReleaseDate2 = New System.Windows.Forms.DateTimePicker()
        Me.cmbStatus2 = New System.Windows.Forms.ComboBox()
        Me.txtGenre2 = New System.Windows.Forms.TextBox()
        Me.txtAuthor2 = New System.Windows.Forms.TextBox()
        Me.txtBookTitle2 = New System.Windows.Forms.TextBox()
        Me.lblDateReleased2 = New System.Windows.Forms.Label()
        Me.lblBookStatus2 = New System.Windows.Forms.Label()
        Me.lblGenre2 = New System.Windows.Forms.Label()
        Me.lblAuthor2 = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.MinimizedWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaximizeWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseWindow3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.pbBookCover1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel4.SuspendLayout()
        CType(Me.BackWindow1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPictureCover2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MinimizedWindow3)
        Me.Panel1.Controls.Add(Me.MaximizeWindow3)
        Me.Panel1.Controls.Add(Me.CloseWindow3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1315, 58)
        Me.Panel1.TabIndex = 1
        '
        'MinimizedWindow3
        '
        Me.MinimizedWindow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizedWindow3.Image = Global.LoginNRegisterPage.My.Resources.Resources.MinimizedWindow
        Me.MinimizedWindow3.Location = New System.Drawing.Point(1186, 17)
        Me.MinimizedWindow3.Name = "MinimizedWindow3"
        Me.MinimizedWindow3.Size = New System.Drawing.Size(28, 26)
        Me.MinimizedWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MinimizedWindow3.TabIndex = 7
        Me.MinimizedWindow3.TabStop = False
        '
        'MaximizeWindow3
        '
        Me.MaximizeWindow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximizeWindow3.Image = Global.LoginNRegisterPage.My.Resources.Resources.MaximizeWindow
        Me.MaximizeWindow3.Location = New System.Drawing.Point(1231, 17)
        Me.MaximizeWindow3.Name = "MaximizeWindow3"
        Me.MaximizeWindow3.Size = New System.Drawing.Size(28, 26)
        Me.MaximizeWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MaximizeWindow3.TabIndex = 6
        Me.MaximizeWindow3.TabStop = False
        '
        'CloseWindow3
        '
        Me.CloseWindow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseWindow3.Image = Global.LoginNRegisterPage.My.Resources.Resources.CloseWindow
        Me.CloseWindow3.Location = New System.Drawing.Point(1274, 17)
        Me.CloseWindow3.Name = "CloseWindow3"
        Me.CloseWindow3.Size = New System.Drawing.Size(28, 26)
        Me.CloseWindow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CloseWindow3.TabIndex = 5
        Me.CloseWindow3.TabStop = False
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.btnSubmit1)
        Me.Guna2GradientPanel1.Controls.Add(Me.cmbSpecificBook1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblChapterContent1)
        Me.Guna2GradientPanel1.Controls.Add(Me.rtbChapterContent1)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtChapterTitle1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblChapterTitle1)
        Me.Guna2GradientPanel1.Controls.Add(Me.rtbDescription1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblBookDescription1)
        Me.Guna2GradientPanel1.Controls.Add(Me.dtpReleaseDate1)
        Me.Guna2GradientPanel1.Controls.Add(Me.pbBookCover1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnSave1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnAddImage1)
        Me.Guna2GradientPanel1.Controls.Add(Me.cmbStatus1)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtGenre1)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtAuthor1)
        Me.Guna2GradientPanel1.Controls.Add(Me.txtBookTitle1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblDateReleased1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblBookCover1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblBookStatus1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblGenre1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblAuthor1)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblTitle1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 140)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1315, 551)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'btnSubmit1
        '
        Me.btnSubmit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit1.Location = New System.Drawing.Point(1145, 399)
        Me.btnSubmit1.Name = "btnSubmit1"
        Me.btnSubmit1.Size = New System.Drawing.Size(127, 33)
        Me.btnSubmit1.TabIndex = 35
        Me.btnSubmit1.Text = "Submit"
        Me.btnSubmit1.UseVisualStyleBackColor = True
        '
        'cmbSpecificBook1
        '
        Me.cmbSpecificBook1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSpecificBook1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSpecificBook1.FormattingEnabled = True
        Me.cmbSpecificBook1.Location = New System.Drawing.Point(886, 399)
        Me.cmbSpecificBook1.Name = "cmbSpecificBook1"
        Me.cmbSpecificBook1.Size = New System.Drawing.Size(252, 31)
        Me.cmbSpecificBook1.TabIndex = 34
        '
        'lblChapterContent1
        '
        Me.lblChapterContent1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChapterContent1.AutoSize = True
        Me.lblChapterContent1.BackColor = System.Drawing.Color.Transparent
        Me.lblChapterContent1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChapterContent1.Location = New System.Drawing.Point(882, 69)
        Me.lblChapterContent1.Name = "lblChapterContent1"
        Me.lblChapterContent1.Size = New System.Drawing.Size(146, 19)
        Me.lblChapterContent1.TabIndex = 33
        Me.lblChapterContent1.Text = "Chapter Content:"
        '
        'rtbChapterContent1
        '
        Me.rtbChapterContent1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbChapterContent1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbChapterContent1.Location = New System.Drawing.Point(886, 97)
        Me.rtbChapterContent1.Name = "rtbChapterContent1"
        Me.rtbChapterContent1.Size = New System.Drawing.Size(386, 285)
        Me.rtbChapterContent1.TabIndex = 32
        Me.rtbChapterContent1.Text = ""
        '
        'txtChapterTitle1
        '
        Me.txtChapterTitle1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChapterTitle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChapterTitle1.Location = New System.Drawing.Point(1019, 34)
        Me.txtChapterTitle1.Name = "txtChapterTitle1"
        Me.txtChapterTitle1.Size = New System.Drawing.Size(253, 25)
        Me.txtChapterTitle1.TabIndex = 31
        '
        'lblChapterTitle1
        '
        Me.lblChapterTitle1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChapterTitle1.AutoSize = True
        Me.lblChapterTitle1.BackColor = System.Drawing.Color.Transparent
        Me.lblChapterTitle1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChapterTitle1.Location = New System.Drawing.Point(882, 37)
        Me.lblChapterTitle1.Name = "lblChapterTitle1"
        Me.lblChapterTitle1.Size = New System.Drawing.Size(116, 19)
        Me.lblChapterTitle1.TabIndex = 30
        Me.lblChapterTitle1.Text = "Chapter Title:"
        '
        'rtbDescription1
        '
        Me.rtbDescription1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDescription1.Location = New System.Drawing.Point(589, 65)
        Me.rtbDescription1.Name = "rtbDescription1"
        Me.rtbDescription1.Size = New System.Drawing.Size(274, 332)
        Me.rtbDescription1.TabIndex = 29
        Me.rtbDescription1.Text = ""
        '
        'lblBookDescription1
        '
        Me.lblBookDescription1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBookDescription1.AutoSize = True
        Me.lblBookDescription1.BackColor = System.Drawing.Color.Transparent
        Me.lblBookDescription1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookDescription1.Location = New System.Drawing.Point(585, 37)
        Me.lblBookDescription1.Name = "lblBookDescription1"
        Me.lblBookDescription1.Size = New System.Drawing.Size(151, 19)
        Me.lblBookDescription1.TabIndex = 28
        Me.lblBookDescription1.Text = "Book Description:"
        '
        'dtpReleaseDate1
        '
        Me.dtpReleaseDate1.CalendarFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReleaseDate1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReleaseDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReleaseDate1.Location = New System.Drawing.Point(45, 278)
        Me.dtpReleaseDate1.Name = "dtpReleaseDate1"
        Me.dtpReleaseDate1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpReleaseDate1.Size = New System.Drawing.Size(249, 25)
        Me.dtpReleaseDate1.TabIndex = 27
        Me.dtpReleaseDate1.Value = New Date(2024, 12, 3, 9, 52, 3, 0)
        '
        'pbBookCover1
        '
        Me.pbBookCover1.Location = New System.Drawing.Point(325, 65)
        Me.pbBookCover1.Name = "pbBookCover1"
        Me.pbBookCover1.Size = New System.Drawing.Size(240, 332)
        Me.pbBookCover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBookCover1.TabIndex = 26
        Me.pbBookCover1.TabStop = False
        '
        'btnSave1
        '
        Me.btnSave1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave1.Location = New System.Drawing.Point(71, 438)
        Me.btnSave1.Name = "btnSave1"
        Me.btnSave1.Size = New System.Drawing.Size(197, 44)
        Me.btnSave1.TabIndex = 22
        Me.btnSave1.Text = "Save"
        Me.btnSave1.UseVisualStyleBackColor = True
        '
        'btnAddImage1
        '
        Me.btnAddImage1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddImage1.Location = New System.Drawing.Point(346, 438)
        Me.btnAddImage1.Name = "btnAddImage1"
        Me.btnAddImage1.Size = New System.Drawing.Size(197, 44)
        Me.btnAddImage1.TabIndex = 25
        Me.btnAddImage1.Text = "Add Image "
        Me.btnAddImage1.UseVisualStyleBackColor = True
        '
        'cmbStatus1
        '
        Me.cmbStatus1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus1.FormattingEnabled = True
        Me.cmbStatus1.Location = New System.Drawing.Point(45, 353)
        Me.cmbStatus1.Name = "cmbStatus1"
        Me.cmbStatus1.Size = New System.Drawing.Size(249, 25)
        Me.cmbStatus1.TabIndex = 21
        '
        'txtGenre1
        '
        Me.txtGenre1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenre1.Location = New System.Drawing.Point(45, 206)
        Me.txtGenre1.Name = "txtGenre1"
        Me.txtGenre1.Size = New System.Drawing.Size(249, 25)
        Me.txtGenre1.TabIndex = 19
        '
        'txtAuthor1
        '
        Me.txtAuthor1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor1.Location = New System.Drawing.Point(45, 134)
        Me.txtAuthor1.Name = "txtAuthor1"
        Me.txtAuthor1.Size = New System.Drawing.Size(249, 25)
        Me.txtAuthor1.TabIndex = 20
        '
        'txtBookTitle1
        '
        Me.txtBookTitle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle1.Location = New System.Drawing.Point(45, 64)
        Me.txtBookTitle1.Name = "txtBookTitle1"
        Me.txtBookTitle1.Size = New System.Drawing.Size(249, 25)
        Me.txtBookTitle1.TabIndex = 18
        '
        'lblDateReleased1
        '
        Me.lblDateReleased1.AutoSize = True
        Me.lblDateReleased1.BackColor = System.Drawing.Color.Transparent
        Me.lblDateReleased1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateReleased1.Location = New System.Drawing.Point(48, 255)
        Me.lblDateReleased1.Name = "lblDateReleased1"
        Me.lblDateReleased1.Size = New System.Drawing.Size(127, 19)
        Me.lblDateReleased1.TabIndex = 17
        Me.lblDateReleased1.Text = "Date Released:"
        '
        'lblBookCover1
        '
        Me.lblBookCover1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBookCover1.AutoSize = True
        Me.lblBookCover1.BackColor = System.Drawing.Color.Transparent
        Me.lblBookCover1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookCover1.Location = New System.Drawing.Point(334, 37)
        Me.lblBookCover1.Name = "lblBookCover1"
        Me.lblBookCover1.Size = New System.Drawing.Size(108, 19)
        Me.lblBookCover1.TabIndex = 15
        Me.lblBookCover1.Text = "Book Cover:"
        '
        'lblBookStatus1
        '
        Me.lblBookStatus1.AutoSize = True
        Me.lblBookStatus1.BackColor = System.Drawing.Color.Transparent
        Me.lblBookStatus1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookStatus1.Location = New System.Drawing.Point(48, 330)
        Me.lblBookStatus1.Name = "lblBookStatus1"
        Me.lblBookStatus1.Size = New System.Drawing.Size(112, 19)
        Me.lblBookStatus1.TabIndex = 14
        Me.lblBookStatus1.Text = "Book Status:"
        '
        'lblGenre1
        '
        Me.lblGenre1.AutoSize = True
        Me.lblGenre1.BackColor = System.Drawing.Color.Transparent
        Me.lblGenre1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre1.Location = New System.Drawing.Point(48, 183)
        Me.lblGenre1.Name = "lblGenre1"
        Me.lblGenre1.Size = New System.Drawing.Size(63, 19)
        Me.lblGenre1.TabIndex = 13
        Me.lblGenre1.Text = "Genre:"
        '
        'lblAuthor1
        '
        Me.lblAuthor1.AutoSize = True
        Me.lblAuthor1.BackColor = System.Drawing.Color.Transparent
        Me.lblAuthor1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor1.Location = New System.Drawing.Point(48, 111)
        Me.lblAuthor1.Name = "lblAuthor1"
        Me.lblAuthor1.Size = New System.Drawing.Size(69, 19)
        Me.lblAuthor1.TabIndex = 12
        Me.lblAuthor1.Text = "Author:"
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.Location = New System.Drawing.Point(48, 42)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(48, 19)
        Me.lblTitle1.TabIndex = 11
        Me.lblTitle1.Text = "Title:"
        '
        'Guna2GradientPanel4
        '
        Me.Guna2GradientPanel4.Controls.Add(Me.BackWindow1)
        Me.Guna2GradientPanel4.Controls.Add(Me.lblEditBooks1)
        Me.Guna2GradientPanel4.Controls.Add(Me.lblAddBooks1)
        Me.Guna2GradientPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Guna2GradientPanel4.Location = New System.Drawing.Point(0, 58)
        Me.Guna2GradientPanel4.Name = "Guna2GradientPanel4"
        Me.Guna2GradientPanel4.ShadowDecoration.Parent = Me.Guna2GradientPanel4
        Me.Guna2GradientPanel4.Size = New System.Drawing.Size(1315, 82)
        Me.Guna2GradientPanel4.TabIndex = 0
        '
        'BackWindow1
        '
        Me.BackWindow1.BackColor = System.Drawing.Color.Transparent
        Me.BackWindow1.Image = Global.LoginNRegisterPage.My.Resources.Resources.BackWindow
        Me.BackWindow1.Location = New System.Drawing.Point(11, 9)
        Me.BackWindow1.Name = "BackWindow1"
        Me.BackWindow1.Size = New System.Drawing.Size(66, 62)
        Me.BackWindow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackWindow1.TabIndex = 9
        Me.BackWindow1.TabStop = False
        '
        'lblEditBooks1
        '
        Me.lblEditBooks1.AutoSize = True
        Me.lblEditBooks1.BackColor = System.Drawing.Color.Transparent
        Me.lblEditBooks1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditBooks1.Location = New System.Drawing.Point(258, 30)
        Me.lblEditBooks1.Name = "lblEditBooks1"
        Me.lblEditBooks1.Size = New System.Drawing.Size(104, 21)
        Me.lblEditBooks1.TabIndex = 30
        Me.lblEditBooks1.Text = "Edit Books"
        '
        'lblAddBooks1
        '
        Me.lblAddBooks1.AutoSize = True
        Me.lblAddBooks1.BackColor = System.Drawing.Color.Transparent
        Me.lblAddBooks1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddBooks1.Location = New System.Drawing.Point(118, 30)
        Me.lblAddBooks1.Name = "lblAddBooks1"
        Me.lblAddBooks1.Size = New System.Drawing.Size(105, 21)
        Me.lblAddBooks1.TabIndex = 29
        Me.lblAddBooks1.Text = "Add Books"
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.dgvBooks)
        Me.Guna2GradientPanel2.Controls.Add(Me.Button1)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel2.Controls.Add(Me.rtbDescription2)
        Me.Guna2GradientPanel2.Controls.Add(Me.btAddImage2)
        Me.Guna2GradientPanel2.Controls.Add(Me.pbPictureCover2)
        Me.Guna2GradientPanel2.Controls.Add(Me.lblBookCover2)
        Me.Guna2GradientPanel2.Controls.Add(Me.btnDelete1)
        Me.Guna2GradientPanel2.Controls.Add(Me.lblNumberOfBooks1)
        Me.Guna2GradientPanel2.Controls.Add(Me.lblBookArchives2)
        Me.Guna2GradientPanel2.Controls.Add(Me.btnSave2)
        Me.Guna2GradientPanel2.Controls.Add(Me.dtpReleaseDate2)
        Me.Guna2GradientPanel2.Controls.Add(Me.cmbStatus2)
        Me.Guna2GradientPanel2.Controls.Add(Me.txtGenre2)
        Me.Guna2GradientPanel2.Controls.Add(Me.txtAuthor2)
        Me.Guna2GradientPanel2.Controls.Add(Me.txtBookTitle2)
        Me.Guna2GradientPanel2.Controls.Add(Me.lblDateReleased2)
        Me.Guna2GradientPanel2.Controls.Add(Me.lblBookStatus2)
        Me.Guna2GradientPanel2.Controls.Add(Me.lblGenre2)
        Me.Guna2GradientPanel2.Controls.Add(Me.lblAuthor2)
        Me.Guna2GradientPanel2.Controls.Add(Me.lblTitle2)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(0, 140)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.ShadowDecoration.Parent = Me.Guna2GradientPanel2
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(1315, 551)
        Me.Guna2GradientPanel2.TabIndex = 28
        '
        'dgvBooks
        '
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Location = New System.Drawing.Point(898, 72)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.RowHeadersWidth = 51
        Me.dgvBooks.RowTemplate.Height = 24
        Me.dgvBooks.Size = New System.Drawing.Size(380, 332)
        Me.dgvBooks.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(39, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 36)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(595, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 19)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Book Description:"
        '
        'rtbDescription2
        '
        Me.rtbDescription2.Location = New System.Drawing.Point(589, 72)
        Me.rtbDescription2.Name = "rtbDescription2"
        Me.rtbDescription2.Size = New System.Drawing.Size(274, 332)
        Me.rtbDescription2.TabIndex = 46
        Me.rtbDescription2.Text = ""
        '
        'pbPictureCover2
        '
        Me.pbPictureCover2.Location = New System.Drawing.Point(313, 72)
        Me.pbPictureCover2.Name = "pbPictureCover2"
        Me.pbPictureCover2.Size = New System.Drawing.Size(240, 332)
        Me.pbPictureCover2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPictureCover2.TabIndex = 45
        Me.pbPictureCover2.TabStop = False
        '
        'btAddImage2
        '
        Me.btAddImage2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddImage2.Location = New System.Drawing.Point(168, 414)
        Me.btAddImage2.Name = "btAddImage2"
        Me.btAddImage2.Size = New System.Drawing.Size(120, 36)
        Me.btAddImage2.TabIndex = 44
        Me.btAddImage2.Text = "Add Image "
        Me.btAddImage2.UseVisualStyleBackColor = True
        '
        'lblBookCover2
        '
        Me.lblBookCover2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBookCover2.AutoSize = True
        Me.lblBookCover2.BackColor = System.Drawing.Color.Transparent
        Me.lblBookCover2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookCover2.Location = New System.Drawing.Point(318, 41)
        Me.lblBookCover2.Name = "lblBookCover2"
        Me.lblBookCover2.Size = New System.Drawing.Size(108, 19)
        Me.lblBookCover2.TabIndex = 43
        Me.lblBookCover2.Text = "Book Cover:"
        '
        'btnDelete1
        '
        Me.btnDelete1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete1.Location = New System.Drawing.Point(168, 456)
        Me.btnDelete1.Name = "btnDelete1"
        Me.btnDelete1.Size = New System.Drawing.Size(120, 36)
        Me.btnDelete1.TabIndex = 42
        Me.btnDelete1.Text = "Delete"
        Me.btnDelete1.UseVisualStyleBackColor = True
        '
        'lblNumberOfBooks1
        '
        Me.lblNumberOfBooks1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumberOfBooks1.AutoSize = True
        Me.lblNumberOfBooks1.BackColor = System.Drawing.Color.Transparent
        Me.lblNumberOfBooks1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfBooks1.Location = New System.Drawing.Point(900, 416)
        Me.lblNumberOfBooks1.Name = "lblNumberOfBooks1"
        Me.lblNumberOfBooks1.Size = New System.Drawing.Size(152, 19)
        Me.lblNumberOfBooks1.TabIndex = 41
        Me.lblNumberOfBooks1.Text = "Number of Books:"
        '
        'lblBookArchives2
        '
        Me.lblBookArchives2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBookArchives2.AutoSize = True
        Me.lblBookArchives2.BackColor = System.Drawing.Color.Transparent
        Me.lblBookArchives2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookArchives2.Location = New System.Drawing.Point(899, 46)
        Me.lblBookArchives2.Name = "lblBookArchives2"
        Me.lblBookArchives2.Size = New System.Drawing.Size(128, 19)
        Me.lblBookArchives2.TabIndex = 40
        Me.lblBookArchives2.Text = "Book Archives:"
        '
        'btnSave2
        '
        Me.btnSave2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave2.Location = New System.Drawing.Point(39, 414)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(120, 36)
        Me.btnSave2.TabIndex = 39
        Me.btnSave2.Text = "Save"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'dtpReleaseDate2
        '
        Me.dtpReleaseDate2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpReleaseDate2.CalendarFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReleaseDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReleaseDate2.Location = New System.Drawing.Point(39, 281)
        Me.dtpReleaseDate2.Name = "dtpReleaseDate2"
        Me.dtpReleaseDate2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpReleaseDate2.Size = New System.Drawing.Size(249, 22)
        Me.dtpReleaseDate2.TabIndex = 37
        '
        'cmbStatus2
        '
        Me.cmbStatus2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbStatus2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus2.FormattingEnabled = True
        Me.cmbStatus2.Location = New System.Drawing.Point(39, 356)
        Me.cmbStatus2.Name = "cmbStatus2"
        Me.cmbStatus2.Size = New System.Drawing.Size(249, 25)
        Me.cmbStatus2.TabIndex = 36
        '
        'txtGenre2
        '
        Me.txtGenre2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtGenre2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenre2.Location = New System.Drawing.Point(39, 209)
        Me.txtGenre2.Name = "txtGenre2"
        Me.txtGenre2.Size = New System.Drawing.Size(249, 25)
        Me.txtGenre2.TabIndex = 34
        '
        'txtAuthor2
        '
        Me.txtAuthor2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtAuthor2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor2.Location = New System.Drawing.Point(39, 137)
        Me.txtAuthor2.Name = "txtAuthor2"
        Me.txtAuthor2.Size = New System.Drawing.Size(249, 25)
        Me.txtAuthor2.TabIndex = 35
        '
        'txtBookTitle2
        '
        Me.txtBookTitle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtBookTitle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle2.Location = New System.Drawing.Point(39, 67)
        Me.txtBookTitle2.Name = "txtBookTitle2"
        Me.txtBookTitle2.Size = New System.Drawing.Size(249, 25)
        Me.txtBookTitle2.TabIndex = 33
        '
        'lblDateReleased2
        '
        Me.lblDateReleased2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDateReleased2.AutoSize = True
        Me.lblDateReleased2.BackColor = System.Drawing.Color.Transparent
        Me.lblDateReleased2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateReleased2.Location = New System.Drawing.Point(42, 258)
        Me.lblDateReleased2.Name = "lblDateReleased2"
        Me.lblDateReleased2.Size = New System.Drawing.Size(127, 19)
        Me.lblDateReleased2.TabIndex = 32
        Me.lblDateReleased2.Text = "Date Released:"
        '
        'lblBookStatus2
        '
        Me.lblBookStatus2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBookStatus2.AutoSize = True
        Me.lblBookStatus2.BackColor = System.Drawing.Color.Transparent
        Me.lblBookStatus2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookStatus2.Location = New System.Drawing.Point(42, 333)
        Me.lblBookStatus2.Name = "lblBookStatus2"
        Me.lblBookStatus2.Size = New System.Drawing.Size(112, 19)
        Me.lblBookStatus2.TabIndex = 31
        Me.lblBookStatus2.Text = "Book Status:"
        '
        'lblGenre2
        '
        Me.lblGenre2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblGenre2.AutoSize = True
        Me.lblGenre2.BackColor = System.Drawing.Color.Transparent
        Me.lblGenre2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre2.Location = New System.Drawing.Point(42, 186)
        Me.lblGenre2.Name = "lblGenre2"
        Me.lblGenre2.Size = New System.Drawing.Size(63, 19)
        Me.lblGenre2.TabIndex = 30
        Me.lblGenre2.Text = "Genre:"
        '
        'lblAuthor2
        '
        Me.lblAuthor2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor2.AutoSize = True
        Me.lblAuthor2.BackColor = System.Drawing.Color.Transparent
        Me.lblAuthor2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor2.Location = New System.Drawing.Point(42, 114)
        Me.lblAuthor2.Name = "lblAuthor2"
        Me.lblAuthor2.Size = New System.Drawing.Size(69, 19)
        Me.lblAuthor2.TabIndex = 29
        Me.lblAuthor2.Text = "Author:"
        '
        'lblTitle2
        '
        Me.lblTitle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Location = New System.Drawing.Point(42, 45)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(48, 19)
        Me.lblTitle2.TabIndex = 28
        Me.lblTitle2.Text = "Title:"
        '
        'FormManageBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 691)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientPanel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormManageBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.MinimizedWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaximizeWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseWindow3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.pbBookCover1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel4.ResumeLayout(False)
        Me.Guna2GradientPanel4.PerformLayout()
        CType(Me.BackWindow1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPictureCover2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MinimizedWindow3 As PictureBox
    Friend WithEvents MaximizeWindow3 As PictureBox
    Friend WithEvents CloseWindow3 As PictureBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents dtpReleaseDate1 As DateTimePicker
    Friend WithEvents pbBookCover1 As PictureBox
    Friend WithEvents btnAddImage1 As Button
    Friend WithEvents btnSave1 As Button
    Friend WithEvents cmbStatus1 As ComboBox
    Friend WithEvents txtAuthor1 As TextBox
    Friend WithEvents txtBookTitle1 As TextBox
    Friend WithEvents lblDateReleased1 As Label
    Friend WithEvents lblBookCover1 As Label
    Friend WithEvents lblBookStatus1 As Label
    Friend WithEvents lblGenre1 As Label
    Friend WithEvents lblAuthor1 As Label
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents Guna2GradientPanel4 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents BackWindow1 As PictureBox
    Friend WithEvents lblEditBooks1 As Label
    Friend WithEvents lblAddBooks1 As Label
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblBookDescription1 As Label
    Friend WithEvents lblChapterContent1 As Label
    Friend WithEvents rtbChapterContent1 As RichTextBox
    Friend WithEvents txtChapterTitle1 As TextBox
    Friend WithEvents lblChapterTitle1 As Label
    Friend WithEvents rtbDescription1 As RichTextBox
    Friend WithEvents btnSubmit1 As Button
    Friend WithEvents cmbSpecificBook1 As ComboBox
    Friend WithEvents dtpReleaseDate2 As DateTimePicker
    Friend WithEvents cmbStatus2 As ComboBox
    Friend WithEvents txtGenre2 As TextBox
    Friend WithEvents txtAuthor2 As TextBox
    Friend WithEvents txtBookTitle2 As TextBox
    Friend WithEvents lblDateReleased2 As Label
    Friend WithEvents lblBookStatus2 As Label
    Friend WithEvents lblGenre2 As Label
    Friend WithEvents lblAuthor2 As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lblNumberOfBooks1 As Label
    Friend WithEvents lblBookArchives2 As Label
    Friend WithEvents btnDelete1 As Button
    Friend WithEvents btnSave2 As Button
    Friend WithEvents pbPictureCover2 As PictureBox
    Friend WithEvents btAddImage2 As Button
    Friend WithEvents lblBookCover2 As Label
    Friend WithEvents txtGenre1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rtbDescription2 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvBooks As DataGridView
End Class
