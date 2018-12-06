Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.UI.WebControls

Partial Class BookInfo
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
        Dim sql As String = "SELECT Title, ISBN, Price FROM Books where ISBN = @isbn"
        Dim sql2 As String = "SELECT TOP 1 Writtenby.ISBN, Authors.Name, Authors.AID FROM Authors INNER " +
                            "JOIN Writtenby ON Authors.[AID] = Writtenby.[AID] WHERE Writtenby.ISBN = @isbn;"

        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim cmd2 As New OleDb.OleDbCommand(sql2, conn)
        Dim isbn As String
        Dim dbInfo As OleDbDataReader
        Dim dbInfo2 As OleDbDataReader
        If String.IsNullOrEmpty(Request.QueryString("isbn")) = False Then
            isbn = Request.QueryString("isbn")
            cmd.Parameters.AddWithValue("@isbn", isbn)
            cmd2.Parameters.AddWithValue("@isbn", isbn)
        End If
        conn.Open()
        dbInfo = cmd.ExecuteReader()

        If dbInfo.HasRows Then
            While dbInfo.Read()
                lbl_Title.Text = dbInfo.Item(0).ToString
                lbl_ISBN.Text = dbInfo.Item(1).ToString
                lbl_Price.Text = dbInfo.Item(2).ToString
            End While
        Else
            message.Text = "Some Information Missing"
        End If
        cmd.Dispose()

        dbInfo2 = cmd2.ExecuteReader()
        If dbInfo2.HasRows Then
            While dbInfo2.Read()
                Dim hypLink As New HyperLink
                hypLink.Text = dbInfo2.Item(1).ToString
                hypLink.NavigateUrl = "AuthorInfo.aspx?&aid=" & dbInfo2.Item(2).ToString
                lbl_Author.Controls.Add(hypLink)
            End While
        Else
            message.Text = "No Author Listed."
        End If
        cmd2.Dispose()

        conn.Close()
    End Sub
End Class
