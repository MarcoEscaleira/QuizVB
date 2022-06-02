Public Class indexForm
    Public userId As String

    Public Sub SwitchPanel(ByVal panel As Form)
        panel.TopLevel = False

        Panel1.Controls.Clear()

        Panel1.Controls.Add(panel)

        panel.Show()
    End Sub

    Private Sub indexForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(LandingForm)

        Dim greeting As String = My.Settings.user_id
        MsgBox(greeting)
    End Sub

    Private Sub goToLogin_Click(sender As Object, e As EventArgs) Handles goToLogin.Click
        SwitchPanel(LoginForm)
    End Sub

    Private Sub goToHome_Click(sender As Object, e As EventArgs) Handles goToHome.Click
        SwitchPanel(LandingForm)

        MsgBox(My.Settings.user_id)
    End Sub

    Private Sub goToRegistration_Click(sender As Object, e As EventArgs) Handles goToRegistration.Click
        SwitchPanel(RegistrationForm)
    End Sub
End Class