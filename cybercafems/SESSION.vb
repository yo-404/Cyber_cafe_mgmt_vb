Public Class SESSION

    Dim s As Integer = 0
    Dim m As Integer = 0
    Dim m1 As Integer = 0
    Dim h As Integer = 0

    Public selectedPC As String
    Dim lst As ListView.SelectedIndexCollection

    Public Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim i As Integer
        Dim pc As String
        For i = 0 To ListView1.SelectedItems.Count - 1
            pc = ListView1.SelectedItems(i).Text
            selectedPC = pc
            TextBox7.Text = ListView1.SelectedItems(i).Text
        Next


    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub SESSION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GroupBox2.ResumeLayout(True)
        Me.GroupBox2.PerformLayout()



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        Label1.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Enabled = True
        TextBox4.Text = Date.Now.ToString()
        Timer3.Start()
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Enabled = True

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        TextBox4.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label10.Text = Label10.Text + 1

        If Label10.Text = "60" Then
            Label10.Text = "0"
            Label9.Text = Label9.Text + 1
        End If

        If Label9.Text = "60" Then
            Label9.Text = "0"
            Label8.Text = Label8.Text + 1
        End If

        If Label8.Text = "24" Then
            Label8.Text = "0"
            Label9.Text = "0"
            Label10.Text = "0"
        End If
        If Label8.Text = "60" Then
            Label10.Text = "0"
            Label9.Text = "0"
            Label8.Text = "0"
        End If


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Label8.Text + Label11.Text + Label9.Text + Label12.Text + Label10.Text
        Timer3.Stop()
        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = True
        Label8.Text = "0"
        Label9.Text = "0"
        Label10.Text = "0"
        Timer3.Stop()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer3.Stop()
        Button2.Enabled = False
        Button3.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class