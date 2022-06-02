Imports System.Data
Imports System.Data.SqlClient

Public Class test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim binding_source As New BindingSource()
        Dim data_table As New DataTable()

        Me.DataGridView1.DataSource = binding_source

        Dim con As New SqlConnection("Data Source=dmu-marco.database.windows.net;Initial Catalog=quizDB;Persist Security Info=True;User ID=todoAdmin;Password=mDuCQAmVMpxAJ6vmGq9P")

        con.Open()

        Dim data_adapter As New SqlDataAdapter("SELECT * FROM Users", con)
        Dim cb As New SqlCommandBuilder(data_adapter)

        data_adapter.Fill(data_table)
        binding_source.DataSource = data_table

        con.Close()

    End Sub
End Class