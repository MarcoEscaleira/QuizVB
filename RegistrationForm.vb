Imports System.Data.SqlClient
Public Class RegistrationForm
    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub clearTxtBox()
        ' Clear all test boxes
        Dim txtbox As Control
        For Each txtbox In Controls
            If TypeOf txtbox Is TextBox Then txtbox.Text = ""
        Next txtbox
    End Sub

    Private Sub Create_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateBtn.Click
        Dim usernameText As String = UsernameBox.Text
        Dim emailText As String = EmailBox.Text
        Dim birthdayDate As Date = BirthdayBox.Text
        Dim passwordText As String = PasswordBox.Text
        Dim confPassText As String = PasswordConfirmationBox.Text

        If passwordText <> confPassText Then
            MsgBox("Passwords must match!", MsgBoxStyle.Critical)
            Return
        ElseIf usernameText = Nothing Or emailText = Nothing Or birthdayDate = Nothing Then
            MsgBox("Complete all fields first!", MsgBoxStyle.Critical)
            Return
        End If

        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

        Try
            Using con As New SqlConnection(conString)
                Dim insertQuery = String.Format("INSERT INTO Users (user_username, user_email, user_birthdate, user_password) VALUES ('{0}', '{1}', '{2}', '{3}')", usernameText, emailText, birthdayDate, passwordText)
                Dim command As New SqlCommand(insertQuery, con)

                con.Open()

                Dim result As Integer = command.ExecuteNonQuery()

                If result = 1 Then
                    MsgBox("Created with success", MsgBoxStyle.Information)

                    clearTxtBox()

                    My.Forms.indexForm.SwitchPanel(LoginForm)
                Else
                    MsgBox("Error while creating your account", MsgBoxStyle.Critical)
                End If

                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong...", ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs)
        clearTxtBox()
        My.Forms.indexForm.SwitchPanel(LandingForm)
    End Sub
End Class