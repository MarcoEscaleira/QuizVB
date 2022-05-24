Imports System.Data
Imports System.Data.SqlClient

Public Class test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim binding_source As New BindingSource()
        Dim data_table As New DataTable()

        Me.DataGridView1.DataSource = binding_source
        Dim conString As String = My.Settings.databaseConnectionString

        'Dim con As New SqlClient.SqlConnection(conString)'

        'con.Open()
        MessageBox.Show("Connection Open")
        'con.Close()

    End Sub
End Class