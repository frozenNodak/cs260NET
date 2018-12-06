
Imports System.Data
Imports System.Data.OleDb

Partial Class AddPublisher
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        If String.IsNullOrEmpty(tb_Title.Text) Then
            MsgBox("Please enter the Book's Title.", 0, "INPUT ERROR")
            Return
        End If
        If String.IsNullOrEmpty(tb_isbn.Text) Then
            MsgBox("Please enter the Book's ISBN.", 0, "INPUT ERROR")
            Return
        End If
        If String.IsNullOrEmpty(tb_price.Text) Then
            MsgBox("Please enter the Book's price.", 0, "INPUT ERROR")
            Return
        End If
        conn = control.GetConnection()
        'add to books
        Dim sql As String = "INSERT INTO Books(ISBN, Title, Price) VALUES(@isbn, @title, @price)"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@isbn", tb_isbn.Text)
        cmd.Parameters.AddWithValue("@title", tb_Title.Text)
        cmd.Parameters.AddWithValue("@price", tb_price.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        'add to written-by
        If String.IsNullOrEmpty(ddl_Authors.SelectedValue) = False Then
            sql = "INSERT INTO Writtenby(ISBN, AID) VALUES(@isbn, @aid)"
            cmd = New OleDb.OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@isbn", Convert.ToInt32(tb_isbn.Text))
            cmd.Parameters.AddWithValue("@aid", ddl_Authors.SelectedValue)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        End If


        conn.Close()


        greet.Text = "Added: " + tb_Title.Text + ", " + tb_isbn.Text + ", $" + tb_price.Text

        'clear for another entry
        tb_Title.Text = ""
        tb_isbn.Text = ""
        tb_price.Text = ""
    End Sub
End Class
