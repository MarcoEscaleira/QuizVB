Imports System.Data.SqlClient

Public Class QuizPageForm

    Public Sub loadSelectedQuiz()
        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

        Try
            Using con As New SqlConnection(conString)
                Dim quizQuery = String.Format("SELECT quiz_title, quiz_description, quiz_questions_amount FROM Quizzes WHERE quiz_id = {0}", My.Settings.selectedQuiz)
                Dim command As New SqlCommand(quizQuery, con)

                con.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim quizTitle = reader(0)
                    Dim quizDescription = reader(1)
                    Dim quizQuestions = reader(2)

                    TitleLabel.Text = quizTitle
                    DescriptionLabel.Text = quizDescription

                End While

                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong...", ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub _Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSelectedQuiz()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        My.Forms.indexForm.SwitchPanel(LandingForm)
    End Sub
End Class