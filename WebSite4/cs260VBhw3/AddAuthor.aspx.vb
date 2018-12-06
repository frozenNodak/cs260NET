
Imports System.Data
Imports System.Data.OleDb

Partial Class _Default
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrEmpty(tb_Name.Text) Then
            MsgBox("Please enter the Author's name.", 0, "INPUT ERROR")
            Return
        End If
        conn = control.GetConnection()
        Dim sql As String = "INSERT INTO Authors(Name) VALUES(@Name)"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@Name", tb_Name.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()


        greet.Text = "Added: " + tb_Name.Text

        'clear for another entry
        tb_Name.Text = ""
    End Sub
End Class
