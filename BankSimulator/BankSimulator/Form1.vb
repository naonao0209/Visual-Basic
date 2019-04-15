Public Class Form1

    Dim conObj As New ADODB.Connection
    Dim recSetObj As New ADODB.Recordset
    Dim initilizetoggle As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conObj.Provider = "Microsoft.ACE.OLEDB.12.0"
        conObj.ConnectionString = "../../CustomerInfo.accdb"
        conObj.Open()
        recSetObj.Open("SELECT * FROM BranchNumber",
                       conObj,
                       ADODB.CursorTypeEnum.adOpenDynamic,
                       ADODB.LockTypeEnum.adLockOptimistic)
    End Sub
    'move tabs
    Private Sub Signupbutton_Click(sender As Object, e As EventArgs) Handles Signupbutton.Click
        tab.SelectedTab = SignupPage
    End Sub
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        tab.SelectedTab = LoginPage
    End Sub
    'input ID
    Private Sub CusID_TextChanged(sender As Object, e As EventArgs) Handles CusID.TextChanged
        validation()
    End Sub
    'input password
    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        passCheck()
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If passCheck() Then
            tab.SelectedTab = TabPage4
        End If
    End Sub



    Function isFormEmpty()

        If CusID.Text = "" Then

            Return True

        End If

        Return False

    End Function

    Function validation()

        recSetObj.MoveFirst()
        Dim StrCriteria As String
        StrCriteria = "ClientID ='" + CusID.Text + "'"
        recSetObj.Find(StrCriteria)
        If recSetObj.EOF Then
            printError("No matching data in our record.")
            Return False
        End If
        Return True
    End Function
    Function passCheck()

        If validation() Then
            Dim StrCriteria As String
            StrCriteria = "Password ='" + Password.Text + "'"
            recSetObj.Find(StrCriteria)
            If recSetObj.EOF Then
                printError("Password not correct.")
                Return False
            End If
        Else
            Return True
        End If
    End Function


    Sub printError(message As String)
        errorMessage.Text = message
    End Sub
End Class
