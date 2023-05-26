Imports System.Data
Imports System.Data.OleDb
Public Class Form3
    Dim con As OleDbConnection

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SessionsDataSet.session' table. You can move, or remove it, as needed.
        Me.SessionTableAdapter.Fill(Me.SessionsDataSet.session)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



    End Sub
End Class