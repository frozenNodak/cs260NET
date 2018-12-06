
Imports System.Data
Imports System.Data.OleDb

Partial Class _Default
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sex As String
        If rb_Male.Checked Then
            sex = "Male"
        ElseIf rb_Female.Checked Then
            sex = "Female"
        End If
        If String.IsNullOrEmpty(sex) Then
            MsgBox("Please select your sex.", 0, "INPUT ERROR")
            Return
        End If
        If String.IsNullOrEmpty(tb_Name.Text) Then
            MsgBox("Please enter the Author's name.", 0, "INPUT ERROR")
            Return
        End If
        conn = control.GetConnection()
        Dim sql As String = "INSERT INTO Authors(Name, Sex) VALUES(@Name, @Sex)"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@Name", tb_Name.Text)
        cmd.Parameters.AddWithValue("@Sex", sex)
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()


        greet.Text = "Added: " + tb_Name.Text + ", " + sex

        'clear for another entry
        rb_Female.Checked = False
        rb_Male.Checked = False
        tb_Name.Text = ""
    End Sub
End Class
