Imports System.Data
Imports System.Data.OleDb

Partial Class Home
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection

    Protected Sub btn_author_Click(sender As Object, e As EventArgs) Handles btn_author.Click
        conn = control.GetConnection()
        conn.Open()
        Dim sql As String = "DELETE FROM Authors "
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()
    End Sub
    Protected Sub btn_book_Click(sender As Object, e As EventArgs) Handles btn_book.Click
        conn = control.GetConnection()
        conn.Open()
        Dim Sql As String = "DELETE FROM Books"
        Dim cmd As New OleDb.OleDbCommand(Sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()
    End Sub
    Protected Sub btn_cust_Click(sender As Object, e As EventArgs) Handles btn_cust.Click
        conn = control.GetConnection()
        conn.Open()
        Dim Sql As String = "DELETE FROM Customers"
        Dim cmd As New OleDb.OleDbCommand(Sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()
    End Sub
    Protected Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        conn = control.GetConnection()
        conn.Open()
        Dim Sql As String = "DELETE FROM Orders"
        Dim cmd As New OleDb.OleDbCommand(Sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()
    End Sub
    Protected Sub btn_writtenby_Click(sender As Object, e As EventArgs) Handles btn_writtenby.Click
        conn = control.GetConnection()
        conn.Open()
        Dim Sql As String = "DELETE FROM Writtenby"
        Dim cmd As New OleDb.OleDbCommand(Sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()
    End Sub
    Protected Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click
        conn = control.GetConnection()
        conn.Open()
        Dim sql As String = "DELETE FROM Authors "
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        sql = "DELETE FROM Books"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        sql = "DELETE FROM Customers"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        sql = "DELETE FROM Orders"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        sql = "DELETE FROM Writtenby"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()
    End Sub
End Class
