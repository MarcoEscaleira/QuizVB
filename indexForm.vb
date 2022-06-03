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
            LoginBtn.Visible = False
            RegisterBtn.Visible = False
            UserLabel.Visible = True
            UserLabel.Text = "Hello " + My.Settings.username + " !"
            logoutBtn.Visible = True
            profileBtn.Visible = True
        Else
            LoginBtn.Visible = True
            RegisterBtn.Visible = True
            UserLabel.Visible = False
            logoutBtn.Visible = False
            profileBtn.Visible = False
        End If
    End Sub

    Private Sub indexForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(LandingForm)

        loadSession()
    End Sub

    Private Sub goToHome_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        SwitchPanel(LandingForm)
    End Sub

    Private Sub goToLogin_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        SwitchPanel(LoginForm)
    End Sub

    Private Sub goToRegistration_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        SwitchPanel(RegistrationForm)
    End Sub

    Private Sub profileBtn_Click(sender As Object, e As EventArgs) Handles ProfileBtn.Click
        SwitchPanel(AccountForm)
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        My.Settings.userid = ""
        My.Settings.username = ""
        My.Settings.Save()

        loadSession()

        MsgBox("Logged out with success!", MsgBoxStyle.Information)
    End Sub
End Class