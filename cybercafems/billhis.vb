Public Class billhis
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            DataGridView1.Show()
            DataGridView2.Hide()
        End If
    End Sub

    Private Sub billhis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BillingDataSet.bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.BillingDataSet.bill)
        'TODO: This line of code loads data into the 'PrintDataSet.print' table. You can move, or remove it, as needed.
        Me.PrintTableAdapter.Fill(Me.PrintDataSet.print)
        'TODO: This line of code loads data into the 'SessionsDataSet.session' table. You can move, or remove it, as needed.
        Me.SessionTableAdapter.Fill(Me.SessionsDataSet.session)
        DataGridView2.Hide()
        DataGridView1.Hide()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            DataGridView2.Show()
            DataGridView1.Hide()
        End If
    End Sub
End Class