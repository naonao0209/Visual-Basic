<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.firstButton = New System.Windows.Forms.Button()
        Me.studentProgramBox = New System.Windows.Forms.TextBox()
        Me.studentNameBox = New System.Windows.Forms.TextBox()
        Me.studentLastNameBox = New System.Windows.Forms.TextBox()
        Me.studentNumberBox = New System.Windows.Forms.TextBox()
        Me.studentStartDateBox = New System.Windows.Forms.TextBox()
        Me.studentAddressBox = New System.Windows.Forms.TextBox()
        Me.womanAvatar = New System.Windows.Forms.PictureBox()
        Me.manAvatar = New System.Windows.Forms.PictureBox()
        Me.RadioButtonMan = New System.Windows.Forms.RadioButton()
        Me.RadioButtonWoman = New System.Windows.Forms.RadioButton()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.prevButton = New System.Windows.Forms.Button()
        Me.lastButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.studentPhoneBox = New System.Windows.Forms.TextBox()
        Me.studentEmailBox = New System.Windows.Forms.TextBox()
        Me.studentCountryBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.searchBox = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.userMessage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radioButtonByStudentId = New System.Windows.Forms.RadioButton()
        Me.radioButtonByEmail = New System.Windows.Forms.RadioButton()
        Me.addinfo = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.delete = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.update = New System.Windows.Forms.Button()
        CType(Me.womanAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.manAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'firstButton
        '
        Me.firstButton.BackColor = System.Drawing.Color.Transparent
        Me.firstButton.BackgroundImage = CType(resources.GetObject("firstButton.BackgroundImage"), System.Drawing.Image)
        Me.firstButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.firstButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.firstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.firstButton.ForeColor = System.Drawing.Color.Transparent
        Me.firstButton.Location = New System.Drawing.Point(368, 303)
        Me.firstButton.Margin = New System.Windows.Forms.Padding(6)
        Me.firstButton.Name = "firstButton"
        Me.firstButton.Size = New System.Drawing.Size(70, 70)
        Me.firstButton.TabIndex = 0
        Me.firstButton.UseVisualStyleBackColor = False
        '
        'studentProgramBox
        '
        Me.studentProgramBox.BackColor = System.Drawing.Color.White
        Me.studentProgramBox.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentProgramBox.ForeColor = System.Drawing.Color.DimGray
        Me.studentProgramBox.Location = New System.Drawing.Point(299, 104)
        Me.studentProgramBox.Margin = New System.Windows.Forms.Padding(6)
        Me.studentProgramBox.Name = "studentProgramBox"
        Me.studentProgramBox.Size = New System.Drawing.Size(337, 33)
        Me.studentProgramBox.TabIndex = 1
        Me.studentProgramBox.Text = "Course"
        '
        'studentNameBox
        '
        Me.studentNameBox.BackColor = System.Drawing.Color.White
        Me.studentNameBox.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNameBox.ForeColor = System.Drawing.Color.Black
        Me.studentNameBox.Location = New System.Drawing.Point(299, 50)
        Me.studentNameBox.Margin = New System.Windows.Forms.Padding(6)
        Me.studentNameBox.Name = "studentNameBox"
        Me.studentNameBox.Size = New System.Drawing.Size(218, 47)
        Me.studentNameBox.TabIndex = 2
        Me.studentNameBox.Text = "Name"
        '
        'studentLastNameBox
        '
        Me.studentLastNameBox.BackColor = System.Drawing.Color.White
        Me.studentLastNameBox.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentLastNameBox.ForeColor = System.Drawing.Color.Black
        Me.studentLastNameBox.Location = New System.Drawing.Point(527, 50)
        Me.studentLastNameBox.Margin = New System.Windows.Forms.Padding(6)
        Me.studentLastNameBox.Name = "studentLastNameBox"
        Me.studentLastNameBox.Size = New System.Drawing.Size(324, 47)
        Me.studentLastNameBox.TabIndex = 3
        Me.studentLastNameBox.Text = "Lastname"
        '
        'studentNumberBox
        '
        Me.studentNumberBox.BackColor = System.Drawing.Color.White
        Me.studentNumberBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNumberBox.ForeColor = System.Drawing.Color.DimGray
        Me.studentNumberBox.Location = New System.Drawing.Point(126, 345)
        Me.studentNumberBox.Margin = New System.Windows.Forms.Padding(6)
        Me.studentNumberBox.Name = "studentNumberBox"
        Me.studentNumberBox.Size = New System.Drawing.Size(144, 27)
        Me.studentNumberBox.TabIndex = 5
        Me.studentNumberBox.Text = "ID"
        '
        'studentStartDateBox
        '
        Me.studentStartDateBox.BackColor = System.Drawing.Color.White
        Me.studentStartDateBox.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentStartDateBox.ForeColor = System.Drawing.Color.DimGray
        Me.studentStartDateBox.Location = New System.Drawing.Point(648, 104)
        Me.studentStartDateBox.Margin = New System.Windows.Forms.Padding(6)
        Me.studentStartDateBox.Name = "studentStartDateBox"
        Me.studentStartDateBox.Size = New System.Drawing.Size(203, 33)
        Me.studentStartDateBox.TabIndex = 8
        Me.studentStartDateBox.Text = "Start date"
        '
        'studentAddressBox
        '
        Me.studentAddressBox.BackColor = System.Drawing.Color.White
        Me.studentAddressBox.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentAddressBox.ForeColor = System.Drawing.Color.DimGray
        Me.studentAddressBox.Location = New System.Drawing.Point(299, 186)
        Me.studentAddressBox.Margin = New System.Windows.Forms.Padding(6)
        Me.studentAddressBox.Name = "studentAddressBox"
        Me.studentAddressBox.Size = New System.Drawing.Size(337, 33)
        Me.studentAddressBox.TabIndex = 9
        Me.studentAddressBox.Text = "City"
        '
        'womanAvatar
        '
        Me.womanAvatar.BackColor = System.Drawing.Color.White
        Me.womanAvatar.BackgroundImage = CType(resources.GetObject("womanAvatar.BackgroundImage"), System.Drawing.Image)
        Me.womanAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.womanAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.womanAvatar.Location = New System.Drawing.Point(50, 48)
        Me.womanAvatar.Name = "womanAvatar"
        Me.womanAvatar.Size = New System.Drawing.Size(220, 211)
        Me.womanAvatar.TabIndex = 10
        Me.womanAvatar.TabStop = False
        '
        'manAvatar
        '
        Me.manAvatar.BackgroundImage = CType(resources.GetObject("manAvatar.BackgroundImage"), System.Drawing.Image)
        Me.manAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.manAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.manAvatar.Location = New System.Drawing.Point(50, 48)
        Me.manAvatar.Name = "manAvatar"
        Me.manAvatar.Size = New System.Drawing.Size(220, 211)
        Me.manAvatar.TabIndex = 11
        Me.manAvatar.TabStop = False
        '
        'RadioButtonMan
        '
        Me.RadioButtonMan.AutoSize = True
        Me.RadioButtonMan.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonMan.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red
        Me.RadioButtonMan.Location = New System.Drawing.Point(136, 265)
        Me.RadioButtonMan.Name = "RadioButtonMan"
        Me.RadioButtonMan.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonMan.TabIndex = 12
        Me.RadioButtonMan.TabStop = True
        Me.RadioButtonMan.UseVisualStyleBackColor = False
        '
        'RadioButtonWoman
        '
        Me.RadioButtonWoman.AutoSize = True
        Me.RadioButtonWoman.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonWoman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RadioButtonWoman.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonWoman.Location = New System.Drawing.Point(170, 265)
        Me.RadioButtonWoman.Name = "RadioButtonWoman"
        Me.RadioButtonWoman.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonWoman.TabIndex = 13
        Me.RadioButtonWoman.TabStop = True
        Me.RadioButtonWoman.UseVisualStyleBackColor = False
        '
        'nextButton
        '
        Me.nextButton.BackColor = System.Drawing.Color.Transparent
        Me.nextButton.BackgroundImage = CType(resources.GetObject("nextButton.BackgroundImage"), System.Drawing.Image)
        Me.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextButton.Location = New System.Drawing.Point(577, 303)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(6)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(70, 70)
        Me.nextButton.TabIndex = 14
        Me.nextButton.UseVisualStyleBackColor = False
        '
        'prevButton
        '
        Me.prevButton.BackColor = System.Drawing.Color.Transparent
        Me.prevButton.BackgroundImage = CType(resources.GetObject("prevButton.BackgroundImage"), System.Drawing.Image)
        Me.prevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.prevButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prevButton.Location = New System.Drawing.Point(471, 303)
        Me.prevButton.Margin = New System.Windows.Forms.Padding(6)
        Me.prevButton.Name = "prevButton"
        Me.prevButton.Size = New System.Drawing.Size(70, 70)
        Me.prevButton.TabIndex = 15
        Me.prevButton.UseVisualStyleBackColor = False
        '
        'lastButton
        '
        Me.lastButton.BackColor = System.Drawing.Color.Transparent
        Me.lastButton.BackgroundImage = CType(resources.GetObject("lastButton.BackgroundImage"), System.Drawing.Image)
        Me.lastButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lastButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.lastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lastButton.ForeColor = System.Drawing.Color.Transparent
        Me.lastButton.Location = New System.Drawing.Point(681, 303)
        Me.lastButton.Margin = New System.Windows.Forms.Padding(6)
        Me.lastButton.Name = "lastButton"
        Me.lastButton.Size = New System.Drawing.Size(70, 70)
        Me.lastButton.TabIndex = 16
        Me.lastButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "first"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(691, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "last"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(460, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "previous"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(586, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 24)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "next"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(123, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 21)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "student ID"
        '
        'studentPhoneBox
        '
        Me.studentPhoneBox.BackColor = System.Drawing.Color.White
        Me.studentPhoneBox.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentPhoneBox.ForeColor = System.Drawing.Color.DimGray
        Me.studentPhoneBox.Location = New System.Drawing.Point(299, 228)
        Me.studentPhoneBox.Margin = New System.Windows.Forms.Padding(6)
        Me.studentPhoneBox.Name = "studentPhoneBox"
        Me.studentPhoneBox.Size = New System.Drawing.Size(337, 33)
        Me.studentPhoneBox.TabIndex = 23
        Me.studentPhoneBox.Text = "Phone"
        '
        'studentEmailBox
        '
        Me.studentEmailBox.BackColor = System.Drawing.Color.White
        Me.studentEmailBox.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentEmailBox.ForeColor = System.Drawing.Color.DimGray
        Me.studentEmailBox.Location = New System.Drawing.Point(299, 145)
        Me.studentEmailBox.Margin = New System.Windows.Forms.Padding(6)
        Me.studentEmailBox.Name = "studentEmailBox"
        Me.studentEmailBox.Size = New System.Drawing.Size(552, 33)
        Me.studentEmailBox.TabIndex = 24
        Me.studentEmailBox.Text = "Email"
        '
        'studentCountryBox
        '
        Me.studentCountryBox.BackColor = System.Drawing.Color.White
        Me.studentCountryBox.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentCountryBox.ForeColor = System.Drawing.Color.DimGray
        Me.studentCountryBox.Location = New System.Drawing.Point(648, 186)
        Me.studentCountryBox.Margin = New System.Windows.Forms.Padding(6)
        Me.studentCountryBox.Name = "studentCountryBox"
        Me.studentCountryBox.Size = New System.Drawing.Size(203, 33)
        Me.studentCountryBox.TabIndex = 25
        Me.studentCountryBox.Text = "Country"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(888, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 24)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "search"
        '
        'searchBox
        '
        Me.searchBox.BackColor = System.Drawing.Color.White
        Me.searchBox.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBox.ForeColor = System.Drawing.Color.Black
        Me.searchBox.Location = New System.Drawing.Point(892, 107)
        Me.searchBox.Margin = New System.Windows.Forms.Padding(6)
        Me.searchBox.Name = "searchBox"
        Me.searchBox.Size = New System.Drawing.Size(218, 33)
        Me.searchBox.TabIndex = 28
        '
        'searchButton
        '
        Me.searchButton.BackColor = System.Drawing.Color.Transparent
        Me.searchButton.BackgroundImage = CType(resources.GetObject("searchButton.BackgroundImage"), System.Drawing.Image)
        Me.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchButton.ForeColor = System.Drawing.Color.Transparent
        Me.searchButton.Location = New System.Drawing.Point(1122, 108)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(6)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(33, 32)
        Me.searchButton.TabIndex = 29
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'userMessage
        '
        Me.userMessage.AutoSize = True
        Me.userMessage.ForeColor = System.Drawing.Color.Maroon
        Me.userMessage.Location = New System.Drawing.Point(363, 274)
        Me.userMessage.Name = "userMessage"
        Me.userMessage.Size = New System.Drawing.Size(0, 24)
        Me.userMessage.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(47, 303)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 67)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.Transparent
        Me.clearButton.BackgroundImage = CType(resources.GetObject("clearButton.BackgroundImage"), System.Drawing.Image)
        Me.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clearButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearButton.ForeColor = System.Drawing.Color.Transparent
        Me.clearButton.Location = New System.Drawing.Point(892, 187)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(6)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(70, 70)
        Me.clearButton.TabIndex = 32
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(894, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 24)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "clear"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.radioButtonByStudentId)
        Me.Panel1.Controls.Add(Me.radioButtonByEmail)
        Me.Panel1.Location = New System.Drawing.Point(892, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(263, 32)
        Me.Panel1.TabIndex = 34
        '
        'radioButtonByStudentId
        '
        Me.radioButtonByStudentId.AutoSize = True
        Me.radioButtonByStudentId.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButtonByStudentId.ForeColor = System.Drawing.Color.Black
        Me.radioButtonByStudentId.Location = New System.Drawing.Point(99, 7)
        Me.radioButtonByStudentId.Name = "radioButtonByStudentId"
        Me.radioButtonByStudentId.Size = New System.Drawing.Size(133, 25)
        Me.radioButtonByStudentId.TabIndex = 2
        Me.radioButtonByStudentId.TabStop = True
        Me.radioButtonByStudentId.Text = "by student ID"
        Me.radioButtonByStudentId.UseVisualStyleBackColor = True
        '
        'radioButtonByEmail
        '
        Me.radioButtonByEmail.AutoSize = True
        Me.radioButtonByEmail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButtonByEmail.ForeColor = System.Drawing.Color.Black
        Me.radioButtonByEmail.Location = New System.Drawing.Point(0, 7)
        Me.radioButtonByEmail.Name = "radioButtonByEmail"
        Me.radioButtonByEmail.Size = New System.Drawing.Size(93, 25)
        Me.radioButtonByEmail.TabIndex = 1
        Me.radioButtonByEmail.TabStop = True
        Me.radioButtonByEmail.Text = "by email"
        Me.radioButtonByEmail.UseVisualStyleBackColor = True
        '
        'addinfo
        '
        Me.addinfo.BackColor = System.Drawing.Color.Transparent
        Me.addinfo.BackgroundImage = CType(resources.GetObject("addinfo.BackgroundImage"), System.Drawing.Image)
        Me.addinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addinfo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.addinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addinfo.ForeColor = System.Drawing.Color.Transparent
        Me.addinfo.Location = New System.Drawing.Point(892, 301)
        Me.addinfo.Margin = New System.Windows.Forms.Padding(6)
        Me.addinfo.Name = "addinfo"
        Me.addinfo.Size = New System.Drawing.Size(70, 70)
        Me.addinfo.TabIndex = 35
        Me.addinfo.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(899, 377)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 24)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "add"
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Transparent
        Me.delete.BackgroundImage = CType(resources.GetObject("delete.BackgroundImage"), System.Drawing.Image)
        Me.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.delete.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.ForeColor = System.Drawing.Color.Transparent
        Me.delete.Location = New System.Drawing.Point(991, 303)
        Me.delete.Margin = New System.Windows.Forms.Padding(6)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(70, 70)
        Me.delete.TabIndex = 36
        Me.delete.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(987, 377)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 24)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "delete"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(987, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 24)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "update"
        '
        'update
        '
        Me.update.BackColor = System.Drawing.Color.Transparent
        Me.update.BackgroundImage = CType(resources.GetObject("update.BackgroundImage"), System.Drawing.Image)
        Me.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.update.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update.ForeColor = System.Drawing.Color.Transparent
        Me.update.Location = New System.Drawing.Point(991, 187)
        Me.update.Margin = New System.Windows.Forms.Padding(6)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(70, 70)
        Me.update.TabIndex = 38
        Me.update.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1212, 415)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.addinfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.userMessage)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.searchBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.studentCountryBox)
        Me.Controls.Add(Me.studentEmailBox)
        Me.Controls.Add(Me.studentPhoneBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lastButton)
        Me.Controls.Add(Me.prevButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.RadioButtonWoman)
        Me.Controls.Add(Me.RadioButtonMan)
        Me.Controls.Add(Me.studentAddressBox)
        Me.Controls.Add(Me.studentStartDateBox)
        Me.Controls.Add(Me.studentNumberBox)
        Me.Controls.Add(Me.studentLastNameBox)
        Me.Controls.Add(Me.studentNameBox)
        Me.Controls.Add(Me.studentProgramBox)
        Me.Controls.Add(Me.firstButton)
        Me.Controls.Add(Me.womanAvatar)
        Me.Controls.Add(Me.manAvatar)
        Me.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.womanAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.manAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstButton As Button
    Friend WithEvents studentProgramBox As TextBox
    Friend WithEvents studentNameBox As TextBox
    Friend WithEvents studentLastNameBox As TextBox
    Friend WithEvents studentNumberBox As TextBox
    Friend WithEvents studentStartDateBox As TextBox
    Friend WithEvents studentAddressBox As TextBox
    Friend WithEvents womanAvatar As PictureBox
    Friend WithEvents manAvatar As PictureBox
    Friend WithEvents RadioButtonMan As RadioButton
    Friend WithEvents RadioButtonWoman As RadioButton
    Friend WithEvents nextButton As Button
    Friend WithEvents prevButton As Button
    Friend WithEvents lastButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents studentPhoneBox As TextBox
    Friend WithEvents studentEmailBox As TextBox
    Friend WithEvents studentCountryBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents searchBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents userMessage As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents clearButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents radioButtonByStudentId As RadioButton
    Friend WithEvents radioButtonByEmail As RadioButton
    Friend WithEvents addinfo As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents delete As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents update As Button
End Class
