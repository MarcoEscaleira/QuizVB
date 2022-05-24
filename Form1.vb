Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim loginForm = New LoginForm1()
        loginForm.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button1.MouseEnter
        Me.Button1.Image = Image.FromFile("C:\Users\alber\OneDrive - De Montfort University\coursework_quiz\settings5.png")
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        Me.Button1.Image = Image.FromFile("C:\Users\alber\OneDrive - De Montfort University\coursework_quiz\settings4.png")
    End Sub
    Private Sub _Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign an image to the button.

        Button1.Image = Image.FromFile("C:\Users\alber\OneDrive - De Montfort University\coursework_quiz\settings4.png")

        ' Align the image and text on the button.  

        Button1.ImageAlign = ContentAlignment.MiddleRight

        Button1.TextAlign = ContentAlignment.MiddleLeft

        ' Give the button a flat appearance.

        Button1.FlatStyle = FlatStyle.Flat


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
