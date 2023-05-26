Public Class login

    Public Shared attempt As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Label1.BackColor = Color.Empty

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "123" Then
            Form2.ShowDialog()
            Me.Close()
        ElseIf TextBox1.Text = Nothing And TextBox2.Text = Nothing Then
            MsgBox("NO CREDENTIALS ENTERED ", MsgBoxStyle.Exclamation)
        Else
            MsgBox("ENTERED USERNAME OR PASSWORD IS INVALID", MsgBoxStyle.Critical)
            attempt = attempt + 1
            If (attempt = 3) Then
                MsgBox("YOU HAVE ENTERED CREDENTIALS WRONG 3 TIMES ..PROGRAM IS EXITING !!", MsgBoxStyle.Critical)
                Me.Close()




            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
