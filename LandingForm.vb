Public Class LandingForm
    Private Sub LandingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim index As New indexForm

        index.SwitchPanel(QuizPageForm)
    End Sub
End Class
