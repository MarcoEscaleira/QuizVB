Imports System.Data.SqlClient

Public Class QuizQuestionForm
    Public Sub loadSelectedQuiz()
        clearButtons()

        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

        Try
            Using con As New SqlConnection(conString)
                Dim quizQuery = String.Format("SELECT quiz_title, quiz_questions, quiz_questions_amount FROM Quizzes WHERE quiz_id = {0}", My.Settings.selectedQuiz)
                Dim command As New SqlCommand(quizQuery, con)

                con.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim quizTitle = reader(0)
                    Dim quizQuestions = reader(1)
                    Dim quizTotalQuestions = reader(2)

                    QuizTitleLabel.Text = quizTitle
                    TotalLabel.Text = String.Format("/ {0}", quizTotalQuestions)
                    QuestionsTotal.Text = quizTotalQuestions

                    My.Settings.quizQuestions = quizQuestions
                    My.Settings.quizResult = 0
                    My.Settings.questionNumber = 0
                    My.Settings.Save()

                End While

                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong... " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub clearButtons()
        For Each cn As Control In Panel1.Controls
            If cn.[GetType]() = GetType(Button) Then
                Panel1.Controls.Remove(cn)
            End If
        Next

        For Each cn As Control In Panel2.Controls
            If cn.[GetType]() = GetType(Button) Then
                Panel2.Controls.Remove(cn)
            End If
        Next

        For Each cn As Control In Panel3.Controls
            If cn.[GetType]() = GetType(Button) Then
                Panel3.Controls.Remove(cn)
            End If
        Next

        For Each cn As Control In Panel4.Controls
            If cn.[GetType]() = GetType(Button) Then
                Panel4.Controls.Remove(cn)
            End If
        Next
    End Sub

    Public Sub loadQuestion()
        ' Change this to the correct variable
        Dim currentQuestion = My.Settings.quizQuestions
        Dim questionNumber = My.Settings.questionNumber
        CurrentLabel.Text = questionNumber + 1

        'Check if final question has been reached
        If questionNumber = Convert.ToInt32(QuestionsTotal.Text) Then
            My.Forms.ResultsForm.loadSelectedQuizResults()
            My.Forms.indexForm.SwitchPanel(ResultsForm)

            Return
        End If

        'Get current question and answers
        Dim questionsList = currentQuestion.Split("|||")
        Dim question = questionsList(My.Settings.questionNumber).Split("||")

        ' Grab current question variables
        Dim questionTitle = question(0)
        Dim questionAnswers = question(1).Split("|")
        Dim questionCorrectAnswer = question(2)

        QuestionLabel.Text = questionTitle

        Dim questionIndex = 1
        ' Render each button to each panel
        For Each answer In questionAnswers
            Dim currentQuestionIndex = questionIndex
            Dim answerButton = New Button()

            Dim Generator = New Random()
            Dim startRange = 170
            Dim endRange = 255

            ' Define button styles
            With answerButton
                .Text = answer
                .Width = 243
                .Height = 184
                .Font = New Font(answerButton.Font.FontFamily, 12, answerButton.Font.Style)
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .BackColor = Color.FromArgb(255, Generator.Next(startRange, endRange), Generator.Next(startRange, endRange), Generator.Next(startRange, endRange))
            End With

            ' Define the click event for the new button so that we can open the quiz page
            AddHandler answerButton.Click, Sub(sender As Object, e As EventArgs)
                                               ' Check if user got the correct answer
                                               If currentQuestionIndex = Convert.ToInt32(questionCorrectAnswer) Then
                                                   MsgBox("Yay, correct answer!", MsgBoxStyle.Information)
                                                   ' Update user score
                                                   My.Settings.quizResult = My.Settings.quizResult + 1
                                                   My.Settings.Save()
                                               Else
                                                   MsgBox("Upss, you got it wrong", MsgBoxStyle.Critical)
                                               End If

                                               clearButtons()

                                               My.Settings.questionNumber = My.Settings.questionNumber + 1
                                               My.Settings.Save()

                                               ' To load next question
                                               loadQuestion()
                                           End Sub

            ' Check in which panel should the button be rendered
            If questionIndex = 1 Then
                Panel1.Controls.Add(answerButton)
            ElseIf questionIndex = 2 Then
                Panel2.Controls.Add(answerButton)
            ElseIf questionIndex = 3 Then
                Panel3.Controls.Add(answerButton)
            ElseIf questionIndex = 4 Then
                Panel4.Controls.Add(answerButton)
            End If

            questionIndex = questionIndex + 1
        Next
    End Sub

    Private Sub QuizQuestionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class