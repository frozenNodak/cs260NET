Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.UI.WebControls

Partial Class AuthorInfo
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection
    Dim royList As New List(Of Tuple(Of String, String, String))

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim royList As New List(Of Tuple(Of String, String, String, String))()
        conn = control.GetConnection()
        Dim sql As String = "SELECT Authors.Name AS Authors_Name, Authors.AID, Authors.Sex, Publishers.Name AS Publishers_Name, Publishers.PID, Royalties.Royalty " &
                            "FROM Publishers INNER JOIN (Authors INNER JOIN Royalties ON Authors.[AID] = Royalties.[AID]) ON Publishers.[PID] = Royalties.[PID] " &
                            "where authors.aid = @AID"

        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim idKey As String
        Dim dbInfo As OleDbDataReader
        Try
            If String.IsNullOrEmpty(Request.QueryString("id")) = False Then
                idKey = Request.QueryString("id")
            End If
            cmd.Parameters.AddWithValue("@AID", idKey)
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
                sex.Text = dbInfo.Item(2).ToString

                Dim tRow As New TableRow()
                Dim newtuple As Tuple(Of String, String, String, String) = New Tuple(Of String, String, String, String)(dbRoyal.Item(0).ToString(), dbRoyal.Item(1).ToString(), dbRoyal.Item(2).ToString(), dbRoyal.Item(3).ToString)
                royList.Add(newtuple)
                For cellCtr = 1 To cellCnt

                    Dim tCell As New TableCell()
                    If cellCtr = 1 Then
                        Dim hyplink As New HyperLink
                        hyplink.Text = dbInfo.Item(3).ToString()
                        hyplink.NavigateUrl = "PublisherInfo.aspx?id=" & dbInfo.Item(4).ToString
                        tCell.Controls.Add(hyplink)
                    ElseIf cellCtr = 2 Then
                        tCell.Text = dbInfo.Item(4).ToString
                    ElseIf cellCtr = 3 Then
                        Dim tb As New TextBox With {
                            .ID = "tb_" & Convert.ToString(tRowNum) & "_" & Convert.ToString(cellCtr),
                            .Text = dbInfo.Item(5).ToString()
                        }
                        tCell.Controls.Add(tb)
                    ElseIf cellCtr = 4 Then
                        'add a checkbox for update
                        Dim chk As New CheckBox With {
                            .ID = "chb_" & Convert.ToString(tRowNum) & "_" & Convert.ToString(cellCtr),
                            .Text = Convert.ToString("Update")
                        }
                        'cb_toUpdate.Add(chk)
                        tCell.Controls.Add(chk)

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
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
