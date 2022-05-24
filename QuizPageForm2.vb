Public Class QuizPageForm2
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button2.MouseEnter
        Me.Button2.Image = Image.FromFile("C:\Users\alber\OneDrive - De Montfort University\coursework_quiz\settings5.png")
    End Sub

    Private Sub Button2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button2.MouseLeave
        Me.Button2.Image = Image.FromFile("C:\Users\alber\OneDrive - De Montfort University\coursework_quiz\settings4.png")
    End Sub
    Private Sub _Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assign an image to the button.

        Button2.Image = Image.FromFile("C:\Users\alber\OneDrive - De Montfort University\coursework_quiz\settings4.png")

        ' Align the image and text on the button.  

        Button2.ImageAlign = ContentAlignment.MiddleRight

        Button2.TextAlign = ContentAlignment.MiddleLeft

        ' Give the button a flat appearance.

        Button2.FlatStyle = FlatStyle.Flat


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class