Public Class maintain
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MaintenanceDataSet.maintain' table. You can move, or remove it, as needed.
        Me.MaintainTableAdapter.Fill(Me.MaintenanceDataSet.maintain)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MaintainBindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MaintainBindingSource.MoveNext()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaintainBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MaintainBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo saveErr
        MaintainBindingSource.EndEdit()
        MaintainTableAdapter.Update(MaintenanceDataSet)
        MsgBox("Data saved ")


saveErr:
        Exit Sub
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox2.Text = DateTimePicker1.Value.Date
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class