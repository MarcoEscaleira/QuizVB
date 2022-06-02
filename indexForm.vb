Public Class indexForm
    Public userId As String

    Public Sub SwitchPanel(ByVal panel As Form)
        panel.TopLevel = False

        Panel1.Controls.Clear()

        Panel1.Controls.Add(panel)

        panel.Show()
    End Sub

    Public Sub loadSession()
        If My.Settings.userid <> "" Then
            goToLogin.Visible = False
            goToRegistration.Visible = False
            UserLabel.Visible = True
            UserLabel.Text = "Hello " + My.Settings.username + " !"
            logoutBtn.Visible = True
            profileBtn.Visible = True
        End If
    End Sub

    Private Sub indexForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(LandingForm)

        loadSession()
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

    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles profileBtn.Click
        SwitchPanel(AccountForm)
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        My.Settings.userid = ""
        My.Settings.username = ""
        My.Settings.Save()

        goToLogin.Visible = True
        goToRegistration.Visible = True
        UserLabel.Visible = False
        logoutBtn.Visible = False
        profileBtn.Visible = False

        MsgBox("Logged out with success!", MsgBoxStyle.Information)
    End Sub

End Class