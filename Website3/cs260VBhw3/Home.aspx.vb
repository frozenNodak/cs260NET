Imports System.Data
Imports System.Data.OleDb

Partial Class Home
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = control.GetConnection()
        conn.Open()
        Dim sql As String = "DELETE FROM Authors "
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        sql = "DELETE FROM Publishers"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        sql = "DELETE FROM Royalties"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        conn.Close()
    End Sub
End Class
