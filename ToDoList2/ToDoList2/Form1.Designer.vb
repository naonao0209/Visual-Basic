<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.todoList = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.statusMessage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.taskBar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.statusMessage2 = New System.Windows.Forms.TextBox()
        Me.input2 = New System.Windows.Forms.RichTextBox()
        Me.input1 = New System.Windows.Forms.RichTextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.TextBox()
        Me.number2 = New System.Windows.Forms.TextBox()
        Me.button13 = New System.Windows.Forms.Button()
        Me.number1 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(28, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(551, 655)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.todoList)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.statusMessage)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.taskBar)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(543, 623)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "todo List"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkRed
        Me.Button3.Location = New System.Drawing.Point(37, 537)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 61)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Clear All"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'todoList
        '
        Me.todoList.FormattingEnabled = True
        Me.todoList.ItemHeight = 19
        Me.todoList.Location = New System.Drawing.Point(41, 59)
        Me.todoList.Name = "todoList"
        Me.todoList.Size = New System.Drawing.Size(435, 403)
        Me.todoList.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkRed
        Me.Button2.Location = New System.Drawing.Point(338, 537)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 61)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'statusMessage
        '
        Me.statusMessage.AutoSize = True
        Me.statusMessage.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusMessage.ForeColor = System.Drawing.Color.White
        Me.statusMessage.Location = New System.Drawing.Point(83, 475)
        Me.statusMessage.Name = "statusMessage"
        Me.statusMessage.Size = New System.Drawing.Size(353, 26)
        Me.statusMessage.TabIndex = 11
        Me.statusMessage.Text = "please type your task and hit the botton"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(120, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Todo list Application"
        '
        'taskBar
        '
        Me.taskBar.Location = New System.Drawing.Point(41, 504)
        Me.taskBar.Name = "taskBar"
        Me.taskBar.Size = New System.Drawing.Size(435, 27)
        Me.taskBar.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(181, 537)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 61)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add to do list"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.statusMessage2)
        Me.TabPage2.Controls.Add(Me.input2)
        Me.TabPage2.Controls.Add(Me.input1)
        Me.TabPage2.Controls.Add(Me.Button12)
        Me.TabPage2.Controls.Add(Me.Button11)
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(543, 623)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Loops"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Gray
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Wide Latin", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(33, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(475, 30)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "Loops"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'statusMessage2
        '
        Me.statusMessage2.BackColor = System.Drawing.Color.Gray
        Me.statusMessage2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusMessage2.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusMessage2.ForeColor = System.Drawing.Color.White
        Me.statusMessage2.Location = New System.Drawing.Point(33, 576)
        Me.statusMessage2.Name = "statusMessage2"
        Me.statusMessage2.Size = New System.Drawing.Size(475, 25)
        Me.statusMessage2.TabIndex = 14
        Me.statusMessage2.Text = "Press any button,will show you the result"
        Me.statusMessage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'input2
        '
        Me.input2.BackColor = System.Drawing.Color.DimGray
        Me.input2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.input2.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input2.ForeColor = System.Drawing.Color.White
        Me.input2.Location = New System.Drawing.Point(297, 309)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(211, 39)
        Me.input2.TabIndex = 11
        Me.input2.Text = ""
        '
        'input1
        '
        Me.input1.BackColor = System.Drawing.Color.DimGray
        Me.input1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.input1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input1.ForeColor = System.Drawing.Color.White
        Me.input1.Location = New System.Drawing.Point(33, 309)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(211, 39)
        Me.input1.TabIndex = 10
        Me.input1.Text = ""
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.DimGray
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.White
        Me.Button12.Location = New System.Drawing.Point(33, 526)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(475, 37)
        Me.Button12.TabIndex = 9
        Me.Button12.Text = "Clear"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.DimGray
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.White
        Me.Button11.Location = New System.Drawing.Point(297, 440)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(211, 37)
        Me.Button11.TabIndex = 8
        Me.Button11.Text = "Print Prime to 100"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.DimGray
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(297, 483)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(211, 37)
        Me.Button10.TabIndex = 7
        Me.Button10.Text = "Sum 1 to 100(Odd)"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DimGray
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(297, 397)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(211, 37)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "Find min."
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DimGray
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(33, 397)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(211, 37)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Find max."
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DimGray
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(33, 483)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(211, 37)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Sum 1 to 100(Even)"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DimGray
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(33, 440)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(211, 37)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Sum 1 to 100"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DimGray
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(297, 354)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(211, 37)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "10 to 1"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DimGray
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(33, 354)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(211, 37)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "1 to 10"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.DimGray
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(33, 59)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(475, 235)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.DimGray
        Me.TabPage3.Controls.Add(Me.Button15)
        Me.TabPage3.Controls.Add(Me.Button14)
        Me.TabPage3.Controls.Add(Me.Button16)
        Me.TabPage3.Controls.Add(Me.result)
        Me.TabPage3.Controls.Add(Me.number2)
        Me.TabPage3.Controls.Add(Me.button13)
        Me.TabPage3.Controls.Add(Me.number1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(543, 623)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Functions"
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Black
        Me.Button15.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.Color.White
        Me.Button15.Location = New System.Drawing.Point(271, 63)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(181, 47)
        Me.Button15.TabIndex = 6
        Me.Button15.Text = "Substraction"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Black
        Me.Button14.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.White
        Me.Button14.Location = New System.Drawing.Point(82, 116)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(181, 47)
        Me.Button14.TabIndex = 5
        Me.Button14.Text = "Multiplication"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Black
        Me.Button16.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.ForeColor = System.Drawing.Color.White
        Me.Button16.Location = New System.Drawing.Point(271, 116)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(181, 47)
        Me.Button16.TabIndex = 4
        Me.Button16.Text = "Division"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'result
        '
        Me.result.BackColor = System.Drawing.Color.DarkGray
        Me.result.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.Location = New System.Drawing.Point(82, 169)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(370, 41)
        Me.result.TabIndex = 3
        '
        'number2
        '
        Me.number2.BackColor = System.Drawing.Color.DarkGray
        Me.number2.ForeColor = System.Drawing.Color.Black
        Me.number2.Location = New System.Drawing.Point(271, 30)
        Me.number2.Name = "number2"
        Me.number2.Size = New System.Drawing.Size(181, 27)
        Me.number2.TabIndex = 2
        '
        'button13
        '
        Me.button13.BackColor = System.Drawing.Color.Black
        Me.button13.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button13.ForeColor = System.Drawing.Color.White
        Me.button13.Location = New System.Drawing.Point(82, 63)
        Me.button13.Name = "button13"
        Me.button13.Size = New System.Drawing.Size(181, 47)
        Me.button13.TabIndex = 1
        Me.button13.Text = "Addition"
        Me.button13.UseVisualStyleBackColor = False
        '
        'number1
        '
        Me.number1.BackColor = System.Drawing.Color.DarkGray
        Me.number1.ForeColor = System.Drawing.Color.Black
        Me.number1.Location = New System.Drawing.Point(82, 30)
        Me.number1.Name = "number1"
        Me.number1.Size = New System.Drawing.Size(181, 27)
        Me.number1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(619, 690)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents todoList As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents statusMessage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents taskBar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents input2 As RichTextBox
    Friend WithEvents input1 As RichTextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents statusMessage2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents result As TextBox
    Friend WithEvents number2 As TextBox
    Friend WithEvents button13 As Button
    Friend WithEvents number1 As TextBox
    Friend WithEvents Button14 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
End Class
