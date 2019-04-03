Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TabControl1.SelectTab(TabPage2)
        TabControl1.SelectTab(1)
    End Sub

    'add to the list
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If taskBar.Text = "" Then
            statusMessage.Text = "please type your task and hit the botton"
            statusMessage.ForeColor = Color.Red
        Else
            Dim task As String = taskBar.Text
            'task = LTrim(RTrim(task))
            task = Trim(task)
            todoList.Items.Add(task + "    Time : " + Format(Now, "hh:mm").ToString)
            taskBar.Clear()
            statusMessage.Text = "please type your task and hit the botton"
            statusMessage.ForeColor = Color.White
        End If
    End Sub

    'clear all button
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        'check if the list is empty
        Dim listCounter As Integer = todoList.Items.Count

        If listCounter > 0 Then
            'ask are you sure message
            DialogResult = MessageBox.Show("Are you sure you want to delete ALL?", "WARNING", MessageBoxButtons.YesNo)

            If DialogResult.ToString = "Yes" Then
                todoList.Items.Clear()
                statusMessage.Text = "to do list cleared"
                statusMessage.ForeColor = Color.Red
            Else
                'no action
            End If
        Else
            statusMessage.Text = "List is empty"
            statusMessage.ForeColor = Color.Red
        End If
    End Sub

    'Delete button
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        '                        != not equal 
        If todoList.SelectedItem <> "" Then
            'selected
            DialogResult = MessageBox.Show("are you sure you want to delete this?", "WARNING", MessageBoxButtons.OKCancel)

            If DialogResult.ToString = "OK" Then
                todoList.Items.Remove(todoList.SelectedItem)
                statusMessage.Text = "item deleted successfully"
            Else
                'no action
            End If
        Else
            'not selected
            statusMessage.Text = "Select an item first!"
            statusMessage.ForeColor = Color.Red
        End If

    End Sub

    Private Sub taskBar_TextChanged_1(sender As Object, e As EventArgs) Handles taskBar.TextChanged
        statusMessage.Text = "please type your task and hit the botton"
        statusMessage.ForeColor = Color.White
    End Sub
    Private Sub input1_TextChanged(sender As Object, e As EventArgs) Handles input1.TextChanged
        input1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub input2_TextChanged(sender As Object, e As EventArgs) Handles input2.TextChanged
        input2.SelectionAlignment = HorizontalAlignment.Center
    End Sub


    '1 to 10
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        statusMessage2.Text = "Press any button,will show you the result!"
        statusMessage2.ForeColor = Color.White

        Dim index As Integer = 0
        RichTextBox1.Text += "1 to 10 : "
        For index = 1 To 10 Step +1

            RichTextBox1.Text += index.ToString & " "
        Next
        RichTextBox1.Text += vbCrLf

    End Sub

    '10 to 1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        statusMessage2.Text = "Press any button,will show you the result!"
        statusMessage2.ForeColor = Color.White

        Dim index As Integer = 11
        RichTextBox1.Text += "10 to 1 : "
        For index = 10 To 1 Step -1
            RichTextBox1.Text += index.ToString & " "
        Next
        RichTextBox1.Text += vbCrLf
    End Sub

    'find maximum
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        statusMessage2.Text = "Press any button,will show you the result!"
        statusMessage2.ForeColor = Color.White

        If IsNumeric(input1.Text) And IsNumeric(input2.Text) Then
            Dim userInput1 As Integer = Convert.ToInt64(input1.Text)
            Dim userInput2 As Integer = Convert.ToInt64(input2.Text)

            If userInput1 > userInput2 Then
                RichTextBox1.Text += "Max value is : " & userInput1.ToString & vbCrLf
            Else
                RichTextBox1.Text += "Max value is : " & userInput2.ToString & vbCrLf

            End If
        End If
    End Sub

    'find minimum
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        statusMessage2.Text = "Press any button,will show you the result!"
        statusMessage2.ForeColor = Color.White

        If IsNumeric(input1.Text) And IsNumeric(input2.Text) Then
            Dim userInput1 As Integer = Convert.ToInt64(input1.Text)
            Dim userInput2 As Integer = Convert.ToInt64(input2.Text)

            If userInput1 < userInput2 Then
                RichTextBox1.Text += "Min value is : " & userInput1.ToString & vbCrLf
            Else
                RichTextBox1.Text += "Min value is : " & userInput2.ToString & vbCrLf

            End If
        End If

    End Sub

    'sum 1 to 100
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        statusMessage2.Text = "Press any button,will show you the result!"
        statusMessage2.ForeColor = Color.White

        Dim index As Integer = 1
        Dim sum As Integer = 0

        RichTextBox1.Text += "Sum 1 to 100 : "
        While index <= 100
            index += 1
            sum = sum + index
        End While
        RichTextBox1.Text += sum.ToString & vbCrLf
    End Sub

    'print pirmes 1 to 100
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        statusMessage2.Text = "Press any button,will show you the result!"
        statusMessage2.ForeColor = Color.White

        Dim a, b, c As Integer
        a = 1
        RichTextBox1.Text += "Prime 1 to 100 : "
        For b = 2 To 100
            For c = 2 To b - 1
                If b Mod c = 0 Then
                    a = 0
                    Exit For
                Else
                    a = 1
                End If
            Next
            If a = 1 Then
                RichTextBox1.Text += b.ToString & " "
            End If
        Next
        RichTextBox1.Text += vbCrLf
    End Sub

    'sum 1 to 100 even numbers
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        statusMessage2.Text = "Press any button,will show you the result!"
        statusMessage2.ForeColor = Color.White

        Dim even As Integer = 0
        Dim sum As Integer = 0
        RichTextBox1.Text += "Sum 1 to 100(Even) : "
        For even = 0 To 100 Step +2
            sum = sum + even
        Next
        RichTextBox1.Text += sum.ToString & vbCrLf
    End Sub

    'sum 1 to 100 odd numbers
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        statusMessage2.Text = "Press any button,will show you the result!"
        statusMessage2.ForeColor = Color.White

        Dim odd As Integer = 1
        Dim sum As Integer = 0
        RichTextBox1.Text += "Odd 1 to 100(Odd) : "
        For odd = 1 To 100 Step +2
            sum = sum + odd
        Next
        RichTextBox1.Text += sum.ToString & vbCrLf
    End Sub

    'clear 
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        Dim listCounter As Integer = RichTextBox1.Text.Count
        If listCounter > 0 Then
            DialogResult = MessageBox.Show("Are you sure you want to delete ALL?", "WARNING", MessageBoxButtons.YesNo)

            If DialogResult.ToString = "Yes" Then
                RichTextBox1.Clear()
                statusMessage2.Text = "Successfully cleared!"
                statusMessage2.ForeColor = Color.Red
            Else
                'no action
            End If
        Else
            statusMessage2.Text = "List is empty..."
            statusMessage2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click

        Dim userInput1 As Integer = Convert.ToInt64(number1.Text)
        Dim userInput2 As Integer = Convert.ToInt64(number2.Text)

        result.Text = "Addition : " & addNumbers(userInput1, userInput2).ToString

    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        Dim userInput1 As Integer = Convert.ToInt64(number1.Text)
        Dim userInput2 As Integer = Convert.ToInt64(number2.Text)

        result.Text = "Substraction : " & subNumbers(userInput1, userInput2).ToString

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        Dim userInput1 As Integer = Convert.ToInt64(number1.Text)
        Dim userInput2 As Integer = Convert.ToInt64(number2.Text)

        result.Text = "Multiplication : " & mulNumbers(userInput1, userInput2).ToString

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        Dim userInput1 As Integer = Convert.ToInt64(number1.Text)
        Dim userInput2 As Integer = Convert.ToInt64(number2.Text)

        result.Text = "Division : " & divNumbers(userInput1, userInput2).ToString

    End Sub
    Function addNumbers(number1 As Integer, number2 As Integer) As Integer
        'calculate here
        Dim result As Integer = number1 + number2

        Return result

    End Function

    Function subNumbers(number1 As Integer, number2 As Integer) As Integer
        'calculate here
        Dim result As Integer = number1 - number2

        Return result

    End Function

    Function mulNumbers(number1 As Integer, number2 As Integer) As Integer
        'calculate here
        Dim result As Integer = number1 * number2

        Return result

    End Function

    Function divNumbers(number1 As Integer, number2 As Integer) As Double
        'calculate here
        Dim result As Double = number1 / number2

        Return result

    End Function


End Class
