Imports System.Text.RegularExpressions ' Regular Expressions Namespace
Public Class print
    Private NameValid As Boolean 'Is Name  Valid?
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        TextBox1.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        TextBox4.Text = ComboBox2.Text * 3
        ComboBox3.Enabled = True


    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        TextBox5.Text = ComboBox3.Text * 10
        ComboBox4.Enabled = True

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        TextBox6.Text = ComboBox4.Text * 20
        Button1.Enabled = True

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Int(TextBox4.Text) + Int(TextBox5.Text) + Int(TextBox6.Text)
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo saveErr
        PrintBindingSource.EndEdit()
        PrintTableAdapter.Update(PrintDataSet)
        MsgBox("Data saved ")
        Me.Close()

saveErr:
        Exit Sub


    End Sub

    Private Sub print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintBindingSource.AddNew()
        'TODO: This line of code loads data into the 'PrintDataSet.print' table. You can move, or remove it, as needed.
        Me.PrintTableAdapter.Fill(Me.PrintDataSet.print)
        ComboBox1.Enabled = False


        ComboBox1.Enabled = False
        ComboBox2.Text = 0
        ComboBox3.Text = 0
        ComboBox4.Text = 0
        ComboBox1.Text = " pendrive "
        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)






    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ComboBox1.Enabled = True
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If Not Regex.Match(TextBox2.Text, "^[a-zA-Z\s]+$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            TextBox2.Focus() 'Return Focus
            TextBox2.Clear() 'Clear TextBox

            NameValid = False 'Boolean = False
        Else

            NameValid = True 'Everything Fine

        End If
    End Sub
End Class