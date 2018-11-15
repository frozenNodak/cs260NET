Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.UI.WebControls

Partial Class PublisherInfo
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim royList As New List(Of Tuple(Of String, String, String, String))()
        conn = control.GetConnection()
        Dim sql As String = "SELECT Publishers.Name AS Publishers_Name, Publishers.PID, Publishers.City, Authors.Name AS Authors_Name, Authors.AID, Royalties.Royalty " &
                            "FROM Publishers INNER JOIN (Authors INNER JOIN Royalties ON Authors.[AID] = Royalties.[AID]) ON Publishers.[PID] = Royalties.[PID] " &
                            "WHERE publishers.pid = @PID"

        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim idKey As String
        Dim dbInfo As OleDbDataReader
        Try
            If String.IsNullOrEmpty(Request.QueryString("id")) = False Then
                idKey = Request.QueryString("id")
            End If
            cmd.Parameters.AddWithValue("@PID", idKey)
            conn.Open()
            dbInfo = cmd.ExecuteReader()
        Catch ex As Exception
            greet.Text = ex.Message
            Return
        End Try

        Dim cellCtr As Integer
        Dim cellCnt As Integer
        Dim tRowNum As Integer
        cellCnt = 5
        If dbInfo.HasRows Then
            While dbInfo.Read()
                Name.Text = dbInfo.Item(0).ToString
                ID.Text = dbInfo.Item(1).ToString
                City.Text = dbInfo.Item(2).ToString

                Dim tRow As New TableRow()
                For cellCtr = 1 To cellCnt

                    Dim tCell As New TableCell()
                    If cellCtr = 1 Then
                        Dim hyplink As New HyperLink
                        hyplink.Text = dbInfo.Item(3).ToString()
                        hyplink.NavigateUrl = "AuthorInfo.aspx?id=" & dbInfo.Item(4).ToString
                        tCell.Controls.Add(hyplink)
                    ElseIf cellCtr = 2 Then
                        tCell.Text = dbInfo.Item(4).ToString
                    ElseIf cellCtr = 3 Then
                        tCell.Text = dbInfo.Item(5).ToString & " %"

                    End If

                    tRow.Cells.Add(tCell)

                Next
                tRowNum = tRowNum + 1
                Table1.Rows.Add(tRow)
            End While
        End If

        cmd.Dispose()
        conn.Close()
    End Sub
End Class
