Imports System.Data.SqlClient
Public Class RegistrationForm
    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim usernameText As String = UserName.Text
        Dim emailText As String = Mail.Text
        Dim birthdayDate As Date = Birthday.Text
        Dim passwordText As String = Password.Text
        Dim confPassText As String = PassCon.Text

        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

    End Sub

End Class