Imports System.Data.SqlClient

Public Class AccountForm
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        My.Forms.indexForm.SwitchPanel(LandingForm)
    End Sub

    Private Sub AccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

        Try
            Using con As New SqlConnection(conString)
                Dim command As New SqlCommand(String.Format("SELECT * FROM Users WHERE user_id = '{0}'", My.Settings.userid), con)

                con.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()

                    NameBox.Text = reader(1).ToString()
                    DescriptionBox.Text = reader(5).ToString()
                    EmailBox.Text = reader(2).ToString()
                    BirthdateBox.Text = reader(3).ToString()
                    CountryBox.Text = reader(4).ToString()

                End While

                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong...", ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class