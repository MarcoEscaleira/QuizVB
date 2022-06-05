Imports System.Data.SqlClient

Public Class QuizPageForm

    Public Sub loadSelectedQuiz()
        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

        Try
            Using con As New SqlConnection(conString)

                'Get quiz data
                Dim quizQuery = String.Format("
                    SELECT Quizzes.quiz_title, Quizzes.quiz_description, Quizzes.quiz_category, Quizzes.quiz_questions_amount , Quizzes.quiz_timecreated, Users.user_username 
                    FROM Quizzes 
                    INNER JOIN Users ON Quizzes.user_id = Users.user_id
                    WHERE quiz_id = {0}
                ", My.Settings.selectedQuiz)
                Dim command As New SqlCommand(quizQuery, con)

                con.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim quizTitle = reader(0)
                    Dim quizDescription = reader(1)
                    Dim quizCategory = reader(2)
                    Dim quizQuestions = reader(3)
                    Dim quizDate = reader(4)
                    Dim quizCreatorName = reader(5)

                    TitleLabel.Text = quizTitle
                    DescriptionLabel.Text = quizDescription
                    QuizCategoryLabel.Text = quizCategory
                    QuestionsLabel.Text = quizQuestions
                    DateLabel.Text = quizDate
                    UserLabel.Text = quizCreatorName

                End While

                con.Close()

                'Check if user is logged in to get results
                If My.Settings.userid <> "" Then
                    'Get user results
                    Dim resultsQuery = String.Format("
                    SELECT Results.result_answers , Quizzes.quiz_questions_amount, Results.result_date
                    FROM Results 
                    INNER JOIN Quizzes ON Results.quiz_id = Quizzes.quiz_id
                    WHERE Results.user_id = {0} AND Results.quiz_id = {1}
                ", My.Settings.userid, My.Settings.selectedQuiz)
                    Dim resultsCommand As New SqlCommand(resultsQuery, con)

                    con.Open()

                    Dim resultsReader As SqlDataReader = resultsCommand.ExecuteReader()

                    ResultsLabel.Text = ""
                    Dim counter = 0
                    While resultsReader.Read()
                        Dim userAnswers = resultsReader(0)
                        Dim quizTotalAnswers = resultsReader(1)
                        Dim resultDate = resultsReader(2).ToString().Split("12")(0)

                        ResultsLabel.Text = ResultsLabel.Text & vbCrLf & String.Format("Answered {0} out of {1} questions on {2}", userAnswers, quizTotalAnswers, resultDate)

                        counter = counter + 1
                    End While

                    If counter = 0 Then
                        ResultsLabel.Text = "N/A"
                    End If

                    con.Close()
                End If
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong...", ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub _Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSelectedQuiz()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        'Check if user is logged in to get results
        If My.Settings.userid = "" Then
            MsgBox("Please login first.", MsgBoxStyle.Critical)
            Return
        End If

        My.Settings.questionNumber = 0
        My.Settings.Save()

        My.Forms.QuizQuestionForm.loadSelectedQuiz()
        ' To load the first question
        My.Forms.QuizQuestionForm.loadQuestion()

        My.Forms.indexForm.SwitchPanel(QuizQuestionForm)
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        My.Forms.indexForm.SwitchPanel(LandingForm)
    End Sub
End Class