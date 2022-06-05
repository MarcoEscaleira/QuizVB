Imports System.Data.SqlClient
Public Class ResultsForm
    Public Sub loadSelectedQuizResults()
        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

        Try
            Using con As New SqlConnection(conString)
                Dim quizQuery = String.Format("SELECT quiz_title, Quizzes.quiz_questions_amount FROM Quizzes WHERE quiz_id = {0}", My.Settings.selectedQuiz)
                Dim command As New SqlCommand(quizQuery, con)

                con.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim quizTitle = reader(0)
                    Dim quizQuestions = reader(1)
                    Dim quizResult = My.Settings.quizResult

                    QuizTitleLabel.Text = quizTitle

                    TrackBar.Maximum = quizQuestions
                    TrackBar.Value = quizResult

                    ' Get quiz answer percentage
                    Dim percentage = (100 * quizResult) / quizQuestions

                    PercentageLabel.Text = Math.Round(percentage, 0).ToString() + "%"

                    If percentage > 90 Then
                        SuccessLabel.Text = "Yay, you nailed it!"
                    ElseIf percentage > 60 Then
                        SuccessLabel.Text = "Good job, you did well !"
                    ElseIf percentage > 30 Then
                        SuccessLabel.Text = "Okay, do better next time !"
                    Else
                        SuccessLabel.Text = "Upss, prepare your self better next time."
                    End If
                End While

                ResetResult()

                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong...", ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ResetResult()
        My.Settings.quizResult = 0
        My.Settings.questionNumber = 0
        My.Settings.Save()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        ' TODO: save results to table

        My.Forms.indexForm.SwitchPanel(LandingForm)
    End Sub

    Private Sub TryAgainBtn_Click(sender As Object, e As EventArgs) Handles TryAgainBtn.Click
        ' TODO: save results to table

        My.Forms.QuizPageForm.loadSelectedQuiz()

        My.Forms.indexForm.SwitchPanel(QuizPageForm)
    End Sub

    Private Sub ResultsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSelectedQuizResults()
    End Sub
End Class