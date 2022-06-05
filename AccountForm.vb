Imports System.Data.SqlClient

Public Class AccountForm
    Public Sub loadUserDetails()
        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

        Try
            Using con As New SqlConnection(conString)
                Dim command As New SqlCommand(String.Format("SELECT * FROM Users WHERE user_id = '{0}'", My.Settings.userid), con)

                con.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                'Check when results come from the DB
                While reader.Read()
                    ' Update fields with the row data
                    NameBox.Text = reader(1).ToString()
                    DescriptionBox.Text = reader(5).ToString()
                    EmailBox.Text = reader(2).ToString()
                    BirthdateBox.Text = reader(3).ToString()
                End While

                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong...", ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub AccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadUserDetails()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

        Try
            Using con As New SqlConnection(conString)
                Dim editQuery = String.Format("UPDATE Users SET user_description = '{0}' WHERE user_id = '{1}'", DescriptionBox.Text, My.Settings.userid)
                Dim command As New SqlCommand(editQuery, con)

                con.Open()

                Dim result As Integer = command.ExecuteNonQuery()

                If result = 1 Then
                    loadUserDetails()

                    MsgBox("Details updated with success!", MsgBoxStyle.Information)
                Else
                    MsgBox("Error while updating your details", MsgBoxStyle.Critical)
                End If

                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong...", ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        My.Forms.indexForm.SwitchPanel(LandingForm)
    End Sub
End Class