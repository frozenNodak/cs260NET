Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.UI.WebControls

Partial Class AuthorInfo
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If control.GetAdmin = True Then
            adminTab.Visible = True
            custTab.Visible = False
        Else
            adminTab.Visible = False
            custTab.Visible = True
        End If

        conn = control.GetConnection()
        Dim sql As String = "SELECT Authors.AID, Authors.Name, Books.Title, Books.ISBN " +
                            "FROM (Authors INNER JOIN Writtenby ON Authors.[AID] = Writtenby.[AID]) " +
                            "INNER JOIN Books ON Writtenby.[ISBN] = Books.[ISBN] WHERE Authors.AID = @AID;"

        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim aidKey As String
        Dim dbInfo As OleDbDataReader
        Try
            If String.IsNullOrEmpty(Request.QueryString("aid")) = False Then
                aidKey = Request.QueryString("aid")
                cmd.Parameters.AddWithValue("@AID", aidKey)
            End If
            conn.Open()
            dbInfo = cmd.ExecuteReader()
        Catch ex As Exception
            message.Text = ex.Message
            Return
        End Try

        If dbInfo.HasRows Then
            While dbInfo.Read()
                Name.Text = dbInfo.Item(1).ToString
                ID.Text = dbInfo.Item(0).ToString

                Dim tRow As New TableRow()
                Dim tCell As New TableCell()
                Dim hyplink As New HyperLink
                hyplink.Text = dbInfo.Item(2).ToString()
                hyplink.NavigateUrl = "BookInfo.aspx?isbn=" & dbInfo.Item(3).ToString
                tCell.Controls.Add(hyplink)
                tRow.Cells.Add(tCell)
                tb_books.Rows.Add(tRow)
            End While
        End If

        cmd.Dispose()
        conn.Close()
    End Sub
End Class
