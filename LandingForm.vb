Imports System.Data.SqlClient

Public Class LandingForm
    Private Sub loadQuizButtons()
        Dim conString As String = "Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P"

        Try
            Using con As New SqlConnection(conString)
                Dim command As New SqlCommand("SELECT quiz_id, quiz_title, quiz_questions_amount FROM Quizzes", con)

                con.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim quizTitle = reader(1)
                    Dim quizId = reader(0).ToString()
                    Dim quizQuestions = reader(2)

                    Dim button = New Button()
                    Dim Generator = New Random()

                    Dim startRange = 150
                    Dim endRange = 255

                    ' Define button styles
                    With button
                        .Text = String.Format("{0} - {1} Questions", quizTitle, quizQuestions)
                        .Width = 100
                        .FlatStyle = FlatStyle.Flat
                        .FlatAppearance.BorderSize = 1
                        .BackColor = Color.FromArgb(255, Generator.Next(startRange, endRange), Generator.Next(startRange, endRange), Generator.Next(startRange, endRange))
                        .Dock = DockStyle.Left
                    End With

                    ' Define the click event for the new button so that we can open the quiz page
                    AddHandler button.Click, Sub(sender As Object, e As EventArgs)
                                                 Panel2.Focus()

                                                 ' Update selectedQuiz variable to the clicked quiz to be loaded on the quiz page
                                                 My.Settings.selectedQuiz = quizId
                                                 My.Settings.Save()

                                                 My.Forms.QuizPageForm.loadSelectedQuiz()

                                                 My.Forms.indexForm.SwitchPanel(QuizPageForm)
                                             End Sub

                    ButtonsPanel.Controls.Add(button)
                End While

                con.Close()
            End Using
        Catch ex As Exception
            MsgBox("Something went wrong...", ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LandingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim test = "Where are you from?|Jamaica|Portugal|Spain|1||Second question?|a|b|c|0"
        'Dim questionsList = test.Split("||")

        'For Each questionItem In questionsList
        'Dim lastPos = questionItem.Length - 1

        'Dim question = questionItem(1)
        'Dim questionAnswer = questionItem(lastPos)

        'MsgBox(question)
        'Next

        loadQuizButtons()
    End Sub
End Class
