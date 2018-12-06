Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Partial Class ListOfAll
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
        Dim sql As String = "SELECT Name, AID FROM Authors"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        conn.Open()
        Dim dbAuth = cmd.ExecuteReader()

        If dbAuth.HasRows Then
            While dbAuth.Read()
                Dim tRow As New TableRow()
                Dim tCell As New TableCell()
                Dim hypLink As New HyperLink
                hypLink.Text = dbAuth.Item(0).ToString()
                hypLink.NavigateUrl = "AuthorInfo.aspx?aid=" & dbAuth.Item(1).ToString
                tCell.Controls.Add(hypLink)
                tRow.Cells.Add(tCell)

                t_Authors.Rows.Add(tRow)
            End While
        End If
        cmd.Dispose()

        sql = "SELECT Title, ISBN FROM Books"
        cmd = New OleDb.OleDbCommand(sql, conn)
        Dim dbBook = cmd.ExecuteReader()
        If dbBook.HasRows Then
            While dbBook.Read()
                Dim tRow As New TableRow()
                Dim tCell As New TableCell()
                Dim hypLink As New HyperLink
                hypLink.Text = dbBook.Item(0).ToString()
                hypLink.NavigateUrl = "BookInfo.aspx?isbn=" & dbBook.Item(1).ToString
                tCell.Controls.Add(hypLink)
                tRow.Cells.Add(tCell)

                t_Books.Rows.Add(tRow)
            End While
        End If
        cmd.Dispose()

        sql = "SELECT Name, CID FROM Customers"
        cmd = New OleDb.OleDbCommand(sql, conn)
        Dim dbCust = cmd.ExecuteReader()
        If dbCust.HasRows Then
            While dbCust.Read()
                Dim tRow As New TableRow()
                Dim tCell As New TableCell()
                Dim hypLink As New HyperLink
                hypLink.Text = dbCust.Item(0).ToString()
                hypLink.NavigateUrl = "CustInfo.aspx?cid=" & dbCust.Item(1).ToString + "&name=" + dbCust.Item(0).ToString
                tCell.Controls.Add(hypLink)
                tRow.Cells.Add(tCell)

                t_Customers.Rows.Add(tRow)
            End While
        End If
        cmd.Dispose()

        conn.Close()
    End Sub

End Class
