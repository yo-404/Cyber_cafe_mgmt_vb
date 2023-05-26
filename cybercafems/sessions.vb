Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        TextBox3.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        TextBox4.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label32.Text = Label32.Text + 1

        If Label32.Text = "60" Then
            Label32.Text = "0"
            Label33.Text = Label33.Text + 1
        End If

        If Label33.Text = "60" Then
            Label33.Text = "0"
            Label34.Text = Label34.Text + 1
        End If

        If Label34.Text = "60" Then
            Label34.Text = "0"
            Label33.Text = "0"
            Label32.Text = "0"
        End If
        If Label34.Text = "24" Then
            Label32.Text = "0"
            Label33.Text = "0"
            Label34.Text = "0"

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        PictureBox1.Enabled = True
        PictureBox1.Show()
        On Error GoTo saveErr
        SessionBindingSource.EndEdit()
        SessionTableAdapter.Update(SessionsDataSet)
        MsgBox("Data saved ")

saveErr:
        Exit Sub





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Enabled = True
        Timer3.Start()
        Button2.Enabled = False
        Button3.Enabled = True
        Button1.Enabled = False
        TextBox1.Text = "PC1"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer3.Stop()
        Button2.Enabled = True
        Button3.Enabled = False
        Button1.Enabled = False
        TextBox7.Text = Label36.Text + Label35.Text + Label34.Text + Label31.Text + Label33.Text + Label30.Text + Label32.Text
        Timer3.Stop()
        Label34.Text = "0"
        Label33.Text = "0"
        Label32.Text = "0"
        Label36.Text = "0"
        Timer2.Enabled = False
        TextBox5.Text = Date.Now.ToLongTimeString.ToString()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SessionsDataSet.session' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'CpyDataSet1.session' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'CpyDataSet1.session' table. You can move, or remove it, as needed.

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Button1.Enabled = False
        SessionBindingSource.AddNew()
        PictureBox1.Enabled = False
        PictureBox1.Hide()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub
End Class