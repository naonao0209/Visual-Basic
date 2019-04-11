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
    Dim id As Integer = CusID.ToString
    Private Sub CusID_TextChanged(sender As Object, e As EventArgs) Handles CusID.TextChanged

    End Sub
    'input password
    Dim pass As String = Password.ToString
    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click

    End Sub

    Function isInputDataExist() As Boolean

    End Function

End Class
