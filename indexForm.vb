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

        If My.Settings.userid <> "" Then
            goToLogin.Visible = False
            goToRegistration.Visible = False
            userTextBox.Visible = True
            userTextBox.Text = "Hello " + My.Settings.username
            logoutBtn.Visible = True
        End If
    End Sub

    Private Sub goToHome_Click(sender As Object, e As EventArgs) Handles goToHome.Click
        SwitchPanel(LandingForm)
    End Sub

    Private Sub goToLogin_Click(sender As Object, e As EventArgs) Handles goToLogin.Click
        SwitchPanel(LoginForm)
    End Sub

    Private Sub goToRegistration_Click(sender As Object, e As EventArgs) Handles goToRegistration.Click
        SwitchPanel(RegistrationForm)
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        My.Settings.userid = ""
        My.Settings.username = ""
        My.Settings.Save()

        goToLogin.Visible = True
        goToRegistration.Visible = True
        userTextBox.Visible = False
        logoutBtn.Visible = False

        MsgBox("Logged out with success!", MsgBoxStyle.Information)
    End Sub
End Class