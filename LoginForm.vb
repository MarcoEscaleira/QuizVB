Imports System.Data.SqlClient
Public Class LoginForm
    Dim binding_source As New BindingSource()
    Dim data_table As New DataTable()

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim usernameText As String = UsernameTextBox.Text
        Dim passwordText As String = PasswordTextBox.Text

        If usernameText = Nothing Or passwordText = Nothing Then
            MsgBox("Enter all credentials", MsgBoxStyle.Exclamation)
        End If

        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

        Try
            Using con As New SqlConnection(conString)
                Dim command As New SqlCommand(String.Format("SELECT user_id, user_password, user_username FROM Users WHERE user_username = '{0}'", usernameText), con)

                con.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                Dim hasFoundUser = False

                While reader.Read()
                    If reader(1) = passwordText Then
                        My.Settings.userid = reader(0).ToString()
                        My.Settings.username = reader(2).ToString()
                        My.Settings.Save()

                        ' Clear all test boxes
                        Dim txtbox As Control
                        For Each txtbox In Controls
                            If TypeOf txtbox Is TextBox Then txtbox.Text = ""
                        Next txtbox

                        My.Forms.indexForm.loadSession()
                        My.Forms.AccountForm.loadUserDetails()
                        My.Forms.indexForm.SwitchPanel(LandingForm)
                    Else
                        MsgBox("Password is incorrect.", MsgBoxStyle.Critical)
                    End If
                    hasFoundUser = True
                End While

                If hasFoundUser = False Then
                    MsgBox("User not found.", MsgBoxStyle.Critical)
                End If

                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong...", ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

    End Sub
End Class
