Public Class bill
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'BillingDataSet.bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter.Fill(Me.BillingDataSet.bill)
        'TODO: This line of code loads data into the 'SessionsDataSet.session' table. You can move, or remove it, as needed.
        Me.SessionTableAdapter.Fill(Me.SessionsDataSet.session)

        BillBindingSource.AddNew()
        SessionBindingSource.MoveLast()
        TextBox13.Hide()
        TextBox14.Hide()
        TextBox15.Hide()
        TextBox16.Hide()
        TextBox17.Hide()


        Button1.Enabled = False
        Button2.Enabled = False


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox13.Text = TextBox1.Text
        TextBox14.Text = TextBox2.Text
        TextBox15.Text = TextBox3.Text
        TextBox16.Text = TextBox4.Text
        TextBox17.Text = TextBox5.Text

        If TextBox7.Text = Nothing Or 0 Then
            TextBox6.Text = 0
        Else
            TextBox6.Text = TextBox7.Text * 1.5

            TextBox12.Text = TextBox7.Text * 1.5 + TextBox8.Text + TextBox9.Text + TextBox10.Text

        End If
        Button1.Enabled = False
        Button2.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox11.Text = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        On Error GoTo saveErr
        BillBindingSource.EndEdit()
        BillTableAdapter.Update(BillingDataSet)
        MsgBox("SUCCESSFULLY MARKED AS PAID AND SAVED TO DATABASE")
        Me.Close()


saveErr:
        Exit Sub
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        TextBox8.Text = ComboBox1.Text * 3
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        TextBox9.Text = ComboBox2.Text * 10
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

        TextBox10.Text = ComboBox3.Text * 20
        Button1.Enabled = True

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class