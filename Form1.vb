Imports System.Net.Mail
Imports System.Data.OleDb
Public Class formCA
    'Dim provider As String
    'Dim datafile As String
    Dim Connstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    'Dim myconnection As OleDbConnection
    Dim dbda As OleDbDataAdapter
    Dim dbds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource

    Dim con As New OleDbConnection
    Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    'Dim dbSource As String = " Data Source=C:\Users\CHIEF\Desktop\CA\CollegeDB.mdb;"
    Public dbSource As String = "Data source= " & Application.StartupPath & "\collegeDB.mdb;"

    Private Property vbUnchecked As String


    Function ContinueAssessments(ByVal Number1 As Single, ByVal Number2 As Single, ByVal Number3 As Single, ByVal Number4 As Single) As Single

        Dim ContAss As Single

        ContAss = Number1 + Number2 + Number3 + Number4

        Return ContAss

    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CollegeDBDataSet2.GradeDetail' table. You can move, or remove it, as needed.
        'Me.GradeDetailTableAdapter.Fill(Me.CollegeDBDataSet2.GradeDetail)
        txtReg_no.Text = "01-0421-02-"
        con.ConnectionString = dbProvider & dbSource
        txtRich.Text = "this window will help you to calculate Continue assessments based on test1, test2, assignment1 and assignment2 Also you can  " & vbNewLine & "check for any Additional Marks"
        txtGrid.Visible = False
        txtAdmin.Text = "chiefdogan19@gmail.com"
        txtEmail.Text = "doganrstephanotz1@gmail.com"
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCA.Click

        Dim Test1 As Single
        Dim Test2 As Single
        Dim Assgn1 As Single
        Dim Assgn2 As Single
        Dim studentlow As Single
        Dim studentHigh As Single
        Dim mbs As String

        studentHigh = 3
        studentlow = 5
        mbs = " No additionals Marks!!!"

        If txttest1.Text = " " Or txttest2.Text = " " Then

            MsgBox("You must Enter Marks for test 1 or Test 2 to Proceed", vbBack, "Missing Test report")

            txttest1.Focus()

        End If


        If IsNumeric(txttest1.Text) = False Then

            MsgBox("Only Numeric test values are entered", vbOKCancel, "Numeric Values required")

            txttest1.Focus()
        Else

        End If

        Test1 = CShort(txttest1.Text)

        Test2 = CSng(txttest2.Text)

        Assgn1 = CSng(txtAssignment1.Text)

        Assgn2 = CSng(txtAssignment2.Text)

        If (txtcheck.Checked = True And CStr(ContinueAssessments(Test1, Test2, Assgn1, Assgn2) <= 20)) Then

            ContinueAssessments(Test1, Test2, Assgn1, Assgn2 + studentlow)

            txtCA.Text = ContinueAssessments(Test1, Test2, Assgn1, Assgn2 + studentlow)

            txtAdditional.Text = (studentlow)

            txtRich.Text = ("-------------------------------  " & vbNewLine & "Student Registration_no is :" & "   " & txtReg_no.Text & vbNewLine & "Name of the Student is :" & "   " & txtFullname.Text & vbNewLine & " And His Continous Assessment Is :" & "  " & txtCA.Text & vbNewLine & " Your Test 1 marks  is :" & "   " & txttest1.Text & vbNewLine & " Your Test 2 marks  is :" & "   " & txttest2.Text & vbNewLine & " Your Assignment 1 marks  is :" & "   " & txtAssignment1.Text & vbNewLine & " Your Assignment 2 marks  is :" & "   " & txtAssignment2.Text & vbNewLine & " Your  Additional marks  is :" & "   " & txtAdditional.Text)

            MsgBox("you have to study hard in order to pass your UE", MsgBoxStyle.Exclamation, "Fail")


        ElseIf (txtcheck.Checked = True And CStr(ContinueAssessments(Test1, Test2, Assgn1, Assgn2) <= 37)) Then

            ContinueAssessments(Test1, Test2, Assgn1, Assgn2 + studentHigh)

            txtCA.Text = ContinueAssessments(Test1, Test2, Assgn1, Assgn2 + studentHigh)

            txtAdditional.Text = (studentHigh)

            txtRich.Text = ("-------------------------------  " & vbNewLine & "Student Registration_no is :" & "   " & txtReg_no.Text & vbNewLine & "Name of the Student is :" & "   " & txtFullname.Text & vbNewLine & " And His Continous Assessment Is :" & "  " & txtCA.Text & vbNewLine & " Your Test 1 marks  is :" & "   " & txttest1.Text & vbNewLine & " Your Test 2 marks  is :" & "   " & txttest2.Text & vbNewLine & " Your Assignment 1 marks  is :" & "   " & txtAssignment1.Text & vbNewLine & " Your Assignment 2 marks  is :" & "   " & txtAssignment2.Text & vbNewLine & " Your  Additional marks  is :" & "   " & txtAdditional.Text)

            MsgBox("Good try Student Never Giveup ", MsgBoxStyle.Question, "Congratulations!!!")


        ElseIf (txtcheck.Checked = True And CStr(ContinueAssessments(Test1, Test2, Assgn1, Assgn2) = 40)) Then

            ContinueAssessments(Test1, Test2, Assgn1, Assgn2)

            txtCA.Text = ContinueAssessments(Test1, Test2, Assgn1, Assgn2)

            txtAdditional.Text = (mbs)

            txtRich.Text = ("-------------------------------  " & vbNewLine & "Student Registration_no is :" & "   " & txtReg_no.Text & vbNewLine & "Name of the Student is :" & "   " & txtFullname.Text & vbNewLine & " And His Continous Assessment Is :" & "  " & txtCA.Text & vbNewLine & " Your Test 1 marks  is :" & "   " & txttest1.Text & vbNewLine & " Your Test 2 marks  is :" & "   " & txttest2.Text & vbNewLine & " Your Assignment 1 marks  is :" & "   " & txtAssignment1.Text & vbNewLine & " Your Assignment 2 marks  is :" & "   " & txtAssignment2.Text & vbNewLine & " Your  Additional marks  is :" & "   " & txtAdditional.Text)


            MsgBox("Your Genious no Additional marks for You", MsgBoxStyle.Critical & vbNewLine, "Best Student in Programming")


        Else
            txtcheck.Checked = False
            txtAdditional.Clear()

            txtCA.Text = ContinueAssessments(Test1, Test2, Assgn1, Assgn2)

            txtRich.Text = ("-------------------------------  " & vbNewLine & "Student Registration_no is :" & "   " & txtReg_no.Text & vbNewLine & "Name of the Student is :" & "   " & txtFullname.Text & vbNewLine & " And His Continous Assessment Is :" & "  " & txtCA.Text & vbNewLine & " Your Test 1 marks  is :" & "   " & txttest1.Text & vbNewLine & " Your Test 2 marks  is :" & "   " & txttest2.Text & vbNewLine & " Your Assignment 1 marks  is :" & "   " & txtAssignment1.Text & vbNewLine & " Your Assignment 2 marks  is :" & "   " & txtAssignment2.Text & vbNewLine & " Your  Additional marks  is :" & "   " & txtAdditional.Text)

        End If

    End Sub

    Private Sub txtlink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles txtlink.LinkClicked
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        txttest1.Clear()
        txttest2.Clear()
        txtAssignment1.Clear()
        txtCA.Clear()
        txtAssignment2.Clear()
        'txtRich.Clear()
        txtFullname.Clear()
        txtcheck.Text = " "
        txtAdditional.Clear()


    End Sub

    Private Sub txtCA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCA.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdditional.TextChanged

    End Sub


    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
    Private Sub btnStore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStore.Click

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = True
            Smtp_Server.Credentials = New Net.NetworkCredential("chiefdogan19@gmail.com", "ichekzypfydyqkuo")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtAdmin.Text)
            e_mail.To.Add(txtEmail.Text)
            e_mail.Subject = "Your Course Work"
            e_mail.IsBodyHtml = False
            e_mail.Body = (txtRich.Text)
            Smtp_Server.Send(e_mail)
            MsgBox("Your Course Work Mail Sent to " & " " & txtEmail.Text)

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try

        If txtFullname.Text = Nothing And txtAssignment1.Text = Nothing Then

            MessageBox.Show("Please enter empty details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        If con.State = ConnectionState.Closed Then

            con.Open()

        End If
            

        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM GradeDetail WHERE [Reg_no] = @Reg_no and [studFullname] = @studFullname and [studTest1] = @studTest1 and [studTest2] = @studTest2 and [studAss1] = @studAss1 and [studAss2] = @studAss2 and [studCA] = @studCA and [addMarks] = @addMarks ", con)

            cmd.Parameters.AddWithValue("@Reg_no", OleDbType.VarChar).Value = txtReg_no.Text.Trim
            cmd.Parameters.AddWithValue("@studFullname", OleDbType.VarChar).Value = txtFullname.Text.Trim
            cmd.Parameters.AddWithValue("@studTest1", OleDbType.VarChar).Value = txttest1.Text.Trim
            cmd.Parameters.AddWithValue("@studTest2", OleDbType.VarChar).Value = txttest2.Text.Trim
            cmd.Parameters.AddWithValue("@studAss1", OleDbType.VarChar).Value = txtAssignment1.Text.Trim
            cmd.Parameters.AddWithValue("@studAss2", OleDbType.VarChar).Value = txtAssignment2.Text.Trim
            cmd.Parameters.AddWithValue("@studCA", OleDbType.VarChar).Value = txtCA.Text.Trim
            cmd.Parameters.AddWithValue("@addMarks", OleDbType.VarChar).Value = txtAdditional.Text.Trim

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then

                MessageBox.Show("Opps, Marks has already inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtAdditional.Clear()
                txtAssignment1.Clear()
                txtAssignment2.Clear()
                'txtcheck.Text = vbUnchecked()
                txtFullname.Clear()
                txtRich.Clear()
                txttest1.Clear()
                txttest2.Clear()
                txtCA.Clear()

                Exit Sub

            End If

        End Using


        Using create As New OleDbCommand("Insert into [GradeDetail]([Reg_no],[studFullname],[studTest1],[studTest2],[studAss1],[studAss2],[studCA],[addMarks]) Values ('" & txtReg_no.Text & "','" & txtFullname.Text & "','" & txttest1.Text & "','" & txttest2.Text & "','" & txtAssignment1.Text & "','" & txtAssignment2.Text & "','" & txtCA.Text & "','" & txtAdditional.Text & "')", con)

            If txtFullname.Text = Nothing And txtAssignment1.Text = Nothing Then

                MessageBox.Show("Please enter empty details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If



            create.Parameters.AddWithValue("@Reg_no", OleDbType.VarChar).Value = txtReg_no.Text.Trim
            create.Parameters.AddWithValue("@studFullname", OleDbType.VarChar).Value = txtFullname.Text.Trim
            create.Parameters.AddWithValue("@studTest1", OleDbType.VarChar).Value = txttest1.Text.Trim
            create.Parameters.AddWithValue("@studTest2", OleDbType.VarChar).Value = txttest2.Text.Trim
            create.Parameters.AddWithValue("@studAss1", OleDbType.VarChar).Value = txtAssignment1.Text.Trim
            create.Parameters.AddWithValue("@studAss2", OleDbType.VarChar).Value = txtAssignment2.Text.Trim
            create.Parameters.AddWithValue("@studCA", OleDbType.VarChar).Value = txtCA.Text.Trim
            create.Parameters.AddWithValue("@addMarks", OleDbType.VarChar).Value = txtAdditional.Text.Trim

            If create.ExecuteNonQuery Then
                'If create.ExecuteScalar Then

                MessageBox.Show("Student Marks Added successfully!! Get your Gmail in Touch ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAdditional.Clear()
                txtAssignment1.Clear()
                txtAssignment2.Clear()
                txtFullname.Clear()
                txtRich.Clear()
                txttest1.Clear()
                txttest2.Clear()
                txtCA.Clear()
                txtcheck.Checked = False

            End If

        End Using

            con.Close()

    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        ''myconnection = New OleDbConnection
        'con.ConnectionString = Connstring
        'dbds = New DataSet
        'tables = dbds.Tables
        'dbda = New OleDbDataAdapter("Select * from [GradeDetail]", con)
        'dbda.Fill(dbds, "GradeDetail")
        'Dim view As New DataView(tables(0))
        'source.DataSource = view
        'CollegeDBDataSetBindingSource.DataSource = view
        txtGrid.Visible = True
        Dim adp As OleDbDataAdapter = New OleDbDataAdapter("select * from GradeDetail", con)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        txtGrid.DataSource = ds.Tables(0)


        
    End Sub



    Private Sub txtGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles txtGrid.CellContentClick

    End Sub

   

    Private Sub txtRich_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRich.TextChanged

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        txtGrid.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        Me.Hide()
        formupdate.Show()
    End Sub
End Class
