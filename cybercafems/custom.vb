Imports System.Text.RegularExpressions ' Regular Expressions Namespace
Public Class custom
    Private NameValid As Boolean 'Is Name  Valid?
    Private SurnameValid As Boolean 'Is Surname Valid?
    Private PhoneValid As Boolean 'Is Phone Number Valid?
    Private EmailValid As Boolean 'Is Email Valid?
    Private Const V As Boolean = False

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CpyDataSet.customer' table. You can move, or remove it, as needed.

        Me.CustomerTableAdapter.Fill(Me.CpyDataSet.customer)
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CustomerBindingSource1.MovePrevious()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        CustomerBindingSource1.MoveNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CustomerBindingSource1.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_name.Text = "" Or TextBox2.Text = "" Or txtphone.Text = "" Or ComboBox1.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Please fill in all boxes", MsgBoxStyle.Information)

        Else

            On Error GoTo saveErr
            CustomerBindingSource1.EndEdit()
            CustomerTableAdapter.Update(CpyDataSet)
            MsgBox("Data saved ")

        End If
saveErr:
        Exit Sub
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("just select the LOG ,ammend the data and save!!", MsgBoxStyle.Information)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        CustomerBindingSource1.RemoveCurrent()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        CustomerBindingSource1.RemoveCurrent()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        TextBox2.Text = DateTimePicker1.Value.Date
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Public Function ValidatePhone(ByVal strPhoneNum As String) As Boolean

        ''Create Reg Exp Pattern
        Dim strPhonePattern As String = "^[1-9]{10}$"

        'Create Reg Ex Object
        Dim rePhone As New Regex(strPhonePattern)

        'Something Typed In
        If Not String.IsNullOrEmpty(strPhoneNum) Then

            PhoneValid = rePhone.IsMatch(strPhoneNum) 'Check Validity

        Else

            PhoneValid = False 'Not Valid / Empty

        End If

        Return PhoneValid 'Return True / False

    End Function
    Private Sub txtphone_LostFocus(sender As Object, e As System.EventArgs) Handles txtphone.LostFocus

        If Not ValidatePhone(txtphone.Text) Then 'Call Phone Validation Function

            MessageBox.Show("Please Enter Phone Number In Correct Format! i.e 10 digit no")

            txtphone.Clear() 'Clear Input
            txtphone.Focus() 'Return Focus

        End If

    End Sub

    Private Sub txtName_Leave(sender As Object, e As System.EventArgs) Handles txt_name.Leave

        'If Not A Matching Format Entered
        If Not Regex.Match(txt_name.Text, "^[a-zA-Z\s]+$", RegexOptions.IgnoreCase).Success Then 'Only Letters

            MessageBox.Show("Please Enter Alphabetic Characters Only!") 'Inform User

            txt_name.Focus() 'Return Focus
            txt_name.Clear() 'Clear TextBox

            NameValid = False 'Boolean = False
        Else

            NameValid = True 'Everything Fine

        End If

    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles txtphone.TextChanged

    End Sub
End Class