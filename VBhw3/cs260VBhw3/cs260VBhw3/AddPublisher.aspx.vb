
Imports System.Data
Imports System.Data.OleDb

Partial Class AddPublisher
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrEmpty(tb_Name.Text) Then
            MsgBox("Please enter the Author's name.", 0, "INPUT ERROR")
        End If
        If String.IsNullOrEmpty(tb_City.Text) Then
            MsgBox("Please enter the City's name.", 0, "INPUT ERROR")
        End If
        conn = control.GetConnection()
        Dim sql As String = "INSERT INTO Publishers(Name, City) VALUES(@Name, @City)"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@Name", tb_Name.Text)
        cmd.Parameters.AddWithValue("@City", tb_City.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()


        greet.Text = "Adding: " + tb_Name.Text + ", " + tb_City.Text
    End Sub
End Class
