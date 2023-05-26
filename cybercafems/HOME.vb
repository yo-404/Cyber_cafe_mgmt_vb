Public Class Form2
    Public Shared i As Integer = 0
    Private Sub CUSTOMERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERToolStripMenuItem.Click

    End Sub

    Private Sub ADDCUSTOMERToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ADDCUSTOMERToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ADDCUSTOMERToolStripMenuItem.Click
        custom.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SessionsDataSet.session' table. You can move, or remove it, as needed.
        Me.SessionTableAdapter.Fill(Me.SessionsDataSet.session)
        'TODO: This line of code loads data into the 'SessionsDataSet4.session' table. You can move, or remove it, as needed.
        Me.SessionTableAdapter.Fill(Me.SessionsDataSet.session)
        'TODO: This line of code loads data into the 'SessionsDataSet2.session' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'SessionsDataSet1.PC2' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'SessionsDataSet.session' table. You can move, or remove it, as needed.




    End Sub

    Private Sub MANAGESESSIONSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANAGESESSIONSToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Button1.Show()
        Button3.Show()
        Button1.Enabled = False
        SessionBindingSource.AddNew()
        PictureBox1.Enabled = False
        PictureBox1.Hide()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Enabled = True
        Timer3.Start()
        Button2.Enabled = False
        Button3.Enabled = True
        Button1.Enabled = False
        Button3.Show()
        TextBox1.Text = "PC1"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer3.Stop()
        Button2.Enabled = True
        Button3.Enabled = False
        Button1.Enabled = False
        Button2.Show()
        Button1.Hide()
        Button3.Hide()
        TextBox7.Text = Label36.Text + Label35.Text + Label34.Text + Label31.Text + Label33.Text + Label30.Text + Label32.Text
        If (Label34.Text > 0) Then
            TextBox6.Text = Label34.Text
        Else TextBox6.Text = "0"
            Timer3.Stop()
        End If
        Label34.Text = "0"
        Label33.Text = "0"
        Label32.Text = "0"
        Label36.Text = "0"
        Timer2.Enabled = False
        TextBox5.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        PictureBox1.Enabled = True
        PictureBox1.Show()
        On Error GoTo saveErr
        SessionBindingSource.EndEdit()
        SessionTableAdapter.Update(SessionsDataSet)
        MsgBox("Data saved ")
        bill.Show()

saveErr:
        Exit Sub

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        TextBox3.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
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
            i = i + 1
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        GroupBox1.ResumeLayout()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Button6.Show()
        Button4.Show()
        SessionBindingSource.AddNew()
        PictureBox3.Enabled = False
        PictureBox3.Hide()
        Button1.Show()
        Button6.Enabled = True
        Button5.Enabled = False
        Button4.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer5.Enabled = True
        Timer6.Start()
        Button5.Enabled = False
        Button4.Enabled = True
        Button6.Enabled = False
        TextBox9.Text = "PC2"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer6.Stop()
        Button5.Enabled = True
        Button4.Enabled = False
        Button6.Enabled = False
        Button6.Hide()
        Button4.Hide()
        Button5.Show()
        TextBox8.Text = Label6.Text + Label37.Text + Label42.Text + Label39.Text + Label41.Text + Label38.Text + Label40.Text
        If (Label42.Text > 0) Then
            TextBox11.Text = Label42.Text
        Else TextBox11.Text = "0"
            Timer6.Stop()
        End If
        Timer6.Stop()
        Label42.Text = "0"
        Label41.Text = "0"
        Label40.Text = "0"
        Label6.Text = "0"
        Timer5.Enabled = False
        TextBox10.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Label40.Text = Label40.Text + 1

        If Label40.Text = "60" Then
            Label40.Text = "0"
            Label41.Text = Label41.Text + 1
        End If

        If Label41.Text = "60" Then
            Label58.Text = +1
            Label41.Text = "0"
            Label42.Text = Label42.Text + 1
        End If

        If Label42.Text = "60" Then
            Label42.Text = "0"
            Label41.Text = "0"
            Label40.Text = "0"
        End If
        If Label42.Text = "24" Then
            Label40.Text = "0"
            Label41.Text = "0"
            Label42.Text = "0"

        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer5.Enabled = False
        TextBox12.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Enabled = False
        PictureBox3.Enabled = True
        PictureBox3.Show()
        On Error GoTo saveErr
        SessionBindingSource.EndEdit()
        SessionTableAdapter.Update(SessionsDataSet)
        MsgBox("Data saved ")
        bill.Show()
saveErr:
        Exit Sub



    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Enabled = True
        TextBox13.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Timer7.Enabled = True
        TextBox20.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Timer8.Enabled = False
        TextBox19.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Label45.Text = Label45.Text + 1

        If Label45.Text = "60" Then
            Label45.Text = "0"
            Label44.Text = Label44.Text + 1
        End If

        If Label44.Text = "60" Then

            Label44.Text = "0"
            Label43.Text = Label43.Text + 1
            Label59.Text = +1
        End If

        If Label43.Text = "60" Then
            Label43.Text = "0"
            Label44.Text = "0"
            Label45.Text = "0"
        End If
        If Label43.Text = "24" Then
            Label45.Text = "0"
            Label44.Text = "0"
            Label43.Text = "0"

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Timer8.Enabled = True
        Timer9.Start()
        Button8.Enabled = False
        Button7.Enabled = True
        Button9.Enabled = False
        TextBox16.Text = "PC3"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Timer9.Stop()
        Button8.Enabled = True
        Button7.Enabled = False
        Button9.Enabled = False
        Button9.Hide()
        Button7.Hide()
        Button8.Show()
        TextBox15.Text = Label49.Text + Label48.Text + Label43.Text + Label46.Text + Label44.Text + Label47.Text + Label45.Text
        If (Label43.Text > 0) Then
            TextBox18.Text = Label43.Text
        Else TextBox18.Text = "0"
            Timer9.Stop()
        End If
        Timer9.Stop()
        Label43.Text = "0"
        Label44.Text = "0"
        Label45.Text = "0"
        Label49.Text = "0"
        Timer8.Enabled = False
        TextBox17.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.Enabled = False
        PictureBox6.Enabled = True
        PictureBox6.Show()
        On Error GoTo saveErr
        SessionBindingSource.EndEdit()
        SessionTableAdapter.Update(SessionsDataSet)
        MsgBox("Data saved ")
        bill.Show()
saveErr:

        Exit Sub
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Button9.Show()
        Button7.Show()
        SessionBindingSource.AddNew()
        PictureBox6.Enabled = False
        PictureBox6.Hide()
        Button9.Enabled = True
        Button8.Enabled = False
        Button7.Enabled = False
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Timer10.Enabled = True
        TextBox27.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        Timer11.Enabled = False
        TextBox26.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        Label52.Text = Label52.Text + 1

        If Label52.Text = "60" Then
            Label52.Text = "0"
            Label51.Text = Label51.Text + 1
        End If

        If Label51.Text = "60" Then

            Label51.Text = "0"
            Label50.Text = Label50.Text + 1
            Label60.Text = +1
        End If

        If Label50.Text = "60" Then
            Label50.Text = "0"
            Label51.Text = "0"
            Label52.Text = "0"
        End If
        If Label50.Text = "24" Then
            Label52.Text = "0"
            Label51.Text = "0"
            Label50.Text = "0"

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Timer11.Enabled = True
        Timer12.Start()
        Button11.Enabled = False
        Button10.Enabled = True
        Button12.Enabled = False
        TextBox23.Text = "PC4"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Timer12.Stop()
        Button11.Enabled = True
        Button10.Enabled = False
        Button12.Enabled = False
        Button12.Hide()
        Button10.Hide()
        Button11.Show()
        TextBox22.Text = Label56.Text + Label55.Text + Label50.Text + Label53.Text + Label51.Text + Label54.Text + Label52.Text
        If (Label50.Text > 0) Then
            TextBox25.Text = Label50.Text
        Else TextBox25.Text = "0"
            Timer12.Stop()
        End If
        Timer12.Stop()
        Label50.Text = "0"
        Label51.Text = "0"
        Label52.Text = "0"
        Label56.Text = "0"
        Timer11.Enabled = False
        TextBox24.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.Enabled = False
        PictureBox5.Enabled = True
        PictureBox5.Show()
        On Error GoTo saveErr
        SessionBindingSource.EndEdit()
        SessionTableAdapter.Update(SessionsDataSet)
        MsgBox("Data saved ")
        bill.Show()
saveErr:
        Exit Sub

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Button12.Show()
        Button10.Show()
        SessionBindingSource.AddNew()
        PictureBox5.Enabled = False
        PictureBox5.Hide()
        Button12.Enabled = True
        Button11.Enabled = False
        Button10.Enabled = False
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub VIEWSESSIONToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BILLINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BILLINGToolStripMenuItem.Click

    End Sub

    Private Sub BILLINGHISTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BILLINGHISTORYToolStripMenuItem.Click
        billhis.Show()
    End Sub

    Private Sub ONLYPRINTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ONLYPRINTToolStripMenuItem.Click
        print.Show()

    End Sub

    Private Sub SessionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SessionsToolStripMenuItem.Click

    End Sub

    Private Sub VIEWMAINTENANCELOGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIEWMAINTENANCELOGToolStripMenuItem.Click
        maintain.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = 0 Then
            GroupBox1.Show()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
            GroupBox6.Hide()
            GroupBox7.Hide()
        End If

        If ListBox1.SelectedIndex = 1 Then
            GroupBox1.Hide()
            GroupBox2.Show()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
            GroupBox6.Hide()
            GroupBox7.Hide()

        End If

        If ListBox1.SelectedIndex = 2 Then
            GroupBox1.Hide()
            GroupBox2.Hide()
            GroupBox3.Show()
            GroupBox4.Hide()
            GroupBox5.Hide()
            GroupBox6.Hide()
            GroupBox7.Hide()
        End If

        If ListBox1.SelectedIndex = 3 Then
            GroupBox1.Hide()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Show()
            GroupBox5.Hide()
            GroupBox6.Hide()
            GroupBox7.Hide()
        End If

        If ListBox1.SelectedIndex = 4 Then
            GroupBox1.Hide()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Show()
            GroupBox6.Hide()
            GroupBox7.Hide()
        End If

        If ListBox1.SelectedIndex = 5 Then
            GroupBox1.Hide()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
            GroupBox6.Show()
            GroupBox7.Hide()
        End If

        If ListBox1.SelectedIndex = 6 Then
            GroupBox1.Show()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox5.Hide()
            GroupBox6.Hide()
            GroupBox7.Show()
        End If

    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        Timer13.Enabled = True
        TextBox34.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        Timer14.Enabled = False
        TextBox33.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        Label76.Text = Label76.Text + 1

        If Label76.Text = "60" Then
            Label76.Text = "0"
            Label77.Text = Label77.Text + 1
        End If

        If Label77.Text = "60" Then

            Label77.Text = "0"
            Label75.Text = Label75.Text + 1

        End If

        If Label75.Text = "60" Then
            Label75.Text = "0"
            Label77.Text = "0"
            Label76.Text = "0"
        End If
        If Label75.Text = "24" Then
            Label76.Text = "0"
            Label77.Text = "0"
            Label75.Text = "0"

        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Timer14.Enabled = True
        Timer15.Start()
        Button14.Enabled = False
        Button13.Enabled = True
        Button15.Enabled = False
        TextBox31.Text = "PC5"

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Timer15.Stop()
        Button14.Enabled = True
        Button13.Enabled = False
        Button15.Enabled = False
        Button15.Hide()
        Button13.Hide()
        Button14.Show()
        TextBox30.Text = Label66.Text + Label68.Text + Label75.Text + Label73.Text + Label77.Text + Label70.Text + Label76.Text
        If (Label75.Text > 0) Then
            TextBox29.Text = Label75.Text
        Else TextBox29.Text = "0"
            Timer15.Stop()
        End If
        Timer15.Stop()
        Label75.Text = "0"
        Label77.Text = "0"
        Label76.Text = "0"
        Label66.Text = "0"
        Timer14.Enabled = False
        TextBox32.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Button14.Enabled = False
        PictureBox9.Enabled = True
        PictureBox9.Show()
        On Error GoTo saveErr
        SessionBindingSource.EndEdit()
        SessionTableAdapter.Update(SessionsDataSet)
        MsgBox("Data saved ")
        bill.Show()
saveErr:
        Exit Sub

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Button15.Show()
        Button13.Show()
        SessionBindingSource.AddNew()
        PictureBox9.Enabled = False
        PictureBox9.Hide()
        Button15.Enabled = True
        Button14.Enabled = False
        Button13.Enabled = False
    End Sub

    Private Sub Timer16_Tick(sender As Object, e As EventArgs) Handles Timer16.Tick
        Timer16.Enabled = True
        TextBox41.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Timer17_Tick(sender As Object, e As EventArgs) Handles Timer17.Tick
        Timer17.Enabled = False
        TextBox40.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Timer18_Tick(sender As Object, e As EventArgs) Handles Timer18.Tick
        Label92.Text = Label92.Text + 1

        If Label92.Text = "60" Then
            Label92.Text = "0"
            Label93.Text = Label93.Text + 1
        End If

        If Label93.Text = "60" Then

            Label93.Text = "0"
            Label91.Text = Label91.Text + 1

        End If

        If Label91.Text = "60" Then
            Label91.Text = "0"
            Label93.Text = "0"
            Label92.Text = "0"
        End If
        If Label91.Text = "24" Then
            Label92.Text = "0"
            Label93.Text = "0"
            Label91.Text = "0"

        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Timer17.Enabled = True
        Timer18.Start()
        Button17.Enabled = False
        Button16.Enabled = True
        Button18.Enabled = False
        TextBox38.Text = "PC6"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Timer18.Stop()
        Button17.Enabled = True
        Button16.Enabled = False
        Button18.Enabled = False
        Button18.Hide()
        Button16.Hide()
        Button17.Show()
        TextBox37.Text = Label82.Text + Label84.Text + Label91.Text + Label89.Text + Label93.Text + Label86.Text + Label92.Text
        If (Label91.Text > 0) Then
            TextBox36.Text = Label91.Text
        Else TextBox36.Text = "0"
            Timer18.Stop()
        End If
        Timer18.Stop()
        Label91.Text = "0"
        Label93.Text = "0"
        Label92.Text = "0"
        Label82.Text = "0"
        Timer17.Enabled = False
        TextBox39.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Button17.Enabled = False
        PictureBox11.Enabled = True
        PictureBox11.Show()
        On Error GoTo saveErr
        SessionBindingSource.EndEdit()
        SessionTableAdapter.Update(SessionsDataSet)
        MsgBox("Data saved ")
        bill.Show()
saveErr:
        Exit Sub

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Button18.Show()
        Button16.Show()
        SessionBindingSource.AddNew()
        PictureBox11.Enabled = False
        PictureBox11.Hide()
        Button18.Enabled = True
        Button17.Enabled = False
        Button16.Enabled = False
    End Sub

    Private Sub Timer19_Tick(sender As Object, e As EventArgs) Handles Timer19.Tick
        Timer19.Enabled = True
        TextBox48.Text = Date.Now.ToString("dd-MM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Timer20_Tick(sender As Object, e As EventArgs) Handles Timer20.Tick
        Timer20.Enabled = False
        TextBox47.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Timer21_Tick(sender As Object, e As EventArgs) Handles Timer21.Tick
        Label108.Text = Label108.Text + 1

        If Label108.Text = "60" Then
            Label108.Text = "0"
            Label109.Text = Label109.Text + 1
        End If

        If Label109.Text = "60" Then

            Label109.Text = "0"
            Label107.Text = Label107.Text + 1

        End If

        If Label107.Text = "60" Then
            Label107.Text = "0"
            Label109.Text = "0"
            Label108.Text = "0"
        End If
        If Label107.Text = "24" Then
            Label108.Text = "0"
            Label109.Text = "0"
            Label107.Text = "0"

        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Timer20.Enabled = True
        Timer21.Start()
        Button20.Enabled = False
        Button19.Enabled = True
        Button21.Enabled = False
        TextBox45.Text = "PC7"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Timer21.Stop()
        Button20.Enabled = True
        Button19.Enabled = False
        Button21.Enabled = False
        Button21.Hide()
        Button19.Hide()
        Button20.Show()
        TextBox44.Text = Label98.Text + Label100.Text + Label107.Text + Label105.Text + Label109.Text + Label102.Text + Label108.Text
        If (Label107.Text > 0) Then
            TextBox43.Text = Label107.Text
        Else TextBox43.Text = "0"
            Timer21.Stop()
        End If
        Timer21.Stop()
        Label107.Text = "0"
        Label109.Text = "0"
        Label108.Text = "0"
        Label98.Text = "0"
        Timer20.Enabled = False
        TextBox46.Text = Date.Now.ToLongTimeString.ToString()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Button20.Enabled = False
        PictureBox13.Enabled = True
        PictureBox13.Show()
        On Error GoTo saveErr
        SessionBindingSource.EndEdit()
        SessionTableAdapter.Update(SessionsDataSet)
        MsgBox("Data saved ")
        bill.Show()
saveErr:
        Exit Sub
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Button21.Show()
        Button19.Show()
        SessionBindingSource.AddNew()
        PictureBox13.Enabled = False
        PictureBox13.Hide()
        Button21.Enabled = True
        Button20.Enabled = False
        Button19.Enabled = False
    End Sub
End Class