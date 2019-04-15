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
        Me.tab = New System.Windows.Forms.TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.Signupbutton = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LoginPage = New System.Windows.Forms.TabPage()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.CusID = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.SignupPage = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.errorMessage = New System.Windows.Forms.Label()
        Me.tab.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.LoginPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Controls.Add(Me.Home)
        Me.tab.Controls.Add(Me.LoginPage)
        Me.tab.Controls.Add(Me.SignupPage)
        Me.tab.Controls.Add(Me.TabPage4)
        Me.tab.Location = New System.Drawing.Point(122, 28)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(594, 410)
        Me.tab.TabIndex = 0
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Home.Controls.Add(Me.TextBox5)
        Me.Home.Controls.Add(Me.TextBox4)
        Me.Home.Controls.Add(Me.LoginButton)
        Me.Home.Controls.Add(Me.Signupbutton)
        Me.Home.Controls.Add(Me.TextBox3)
        Me.Home.Location = New System.Drawing.Point(4, 22)
        Me.Home.Name = "Home"
        Me.Home.Padding = New System.Windows.Forms.Padding(3)
        Me.Home.Size = New System.Drawing.Size(586, 384)
        Me.Home.TabIndex = 0
        Me.Home.Text = "Home"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("High Tower Text", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(70, 161)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(449, 32)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Text = "If it is your first time,please sign up."
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("MV Boli", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(156, 30)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(262, 57)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = "Bank Simulator"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.Location = New System.Drawing.Point(312, 234)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(122, 40)
        Me.LoginButton.TabIndex = 2
        Me.LoginButton.Text = "Log in"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'Signupbutton
        '
        Me.Signupbutton.BackColor = System.Drawing.SystemColors.Highlight
        Me.Signupbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signupbutton.ForeColor = System.Drawing.Color.White
        Me.Signupbutton.Location = New System.Drawing.Point(137, 234)
        Me.Signupbutton.Name = "Signupbutton"
        Me.Signupbutton.Size = New System.Drawing.Size(122, 40)
        Me.Signupbutton.TabIndex = 1
        Me.Signupbutton.Text = "Sign up"
        Me.Signupbutton.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("High Tower Text", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(136, 123)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(297, 32)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = "Welcome to ITD bank page."
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoginPage
        '
        Me.LoginPage.Controls.Add(Me.errorMessage)
        Me.LoginPage.Controls.Add(Me.Password)
        Me.LoginPage.Controls.Add(Me.CusID)
        Me.LoginPage.Controls.Add(Me.TextBox2)
        Me.LoginPage.Controls.Add(Me.TextBox1)
        Me.LoginPage.Controls.Add(Me.ConfirmButton)
        Me.LoginPage.Location = New System.Drawing.Point(4, 22)
        Me.LoginPage.Name = "LoginPage"
        Me.LoginPage.Padding = New System.Windows.Forms.Padding(3)
        Me.LoginPage.Size = New System.Drawing.Size(586, 384)
        Me.LoginPage.TabIndex = 1
        Me.LoginPage.Text = "Log in"
        Me.LoginPage.UseVisualStyleBackColor = True
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(168, 225)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(253, 35)
        Me.Password.TabIndex = 15
        Me.Password.Text = "Password here"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CusID
        '
        Me.CusID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusID.Location = New System.Drawing.Point(168, 173)
        Me.CusID.Name = "CusID"
        Me.CusID.Size = New System.Drawing.Size(253, 35)
        Me.CusID.TabIndex = 14
        Me.CusID.Text = "ID here"
        Me.CusID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("MV Boli", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(156, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(253, 57)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.Text = "Bank Simulator"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(96, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(395, 33)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "Please type your ID and password."
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(229, 295)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(115, 36)
        Me.ConfirmButton.TabIndex = 11
        Me.ConfirmButton.Text = "Login"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'SignupPage
        '
        Me.SignupPage.Location = New System.Drawing.Point(4, 22)
        Me.SignupPage.Name = "SignupPage"
        Me.SignupPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SignupPage.Size = New System.Drawing.Size(586, 384)
        Me.SignupPage.TabIndex = 2
        Me.SignupPage.Text = "Sign up"
        Me.SignupPage.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(586, 384)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'errorMessage
        '
        Me.errorMessage.AutoSize = True
        Me.errorMessage.Location = New System.Drawing.Point(280, 275)
        Me.errorMessage.Name = "errorMessage"
        Me.errorMessage.Size = New System.Drawing.Size(0, 13)
        Me.errorMessage.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tab)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tab.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        Me.Home.PerformLayout()
        Me.LoginPage.ResumeLayout(False)
        Me.LoginPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tab As TabControl
    Friend WithEvents Home As TabPage
    Friend WithEvents LoginPage As TabPage
    Friend WithEvents Password As TextBox
    Friend WithEvents CusID As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents SignupPage As TabPage
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents Signupbutton As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents errorMessage As Label
End Class
