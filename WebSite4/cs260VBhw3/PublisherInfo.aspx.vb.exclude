Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.UI.WebControls

Partial Class PublisherInfo
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection
    Dim Delete_list As New List(Of CheckBox)

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
                    ElseIf cellCtr = 4 Then
                        'add a checkbox for delete
                        Dim chk As New CheckBox With {
                            .ID = Convert.ToString(tRowNum) & "_" & Convert.ToString(cellCtr)
                        }
                        Delete_list.Add(chk)
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
    Protected Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim pubID As String
        pubID = ID.Text
        For Each chb As CheckBox In Delete_list
            Dim newRoy As String
            Dim parsas As Array
            Dim cellx As Integer
            Dim celly As Integer
            Dim value As TextBox
            Dim royalty As String
            Dim authID As String
            If chb.Checked = True Then
                newRoy = chb.ClientID
                parsas = newRoy.Split("_").ToArray()
                celly = parsas.GetValue(0)
                cellx = parsas.GetValue(1)

                'value = Table1.Rows(celly + 1).Cells(cellx - 3).Controls.Item(0) 'out of 5 cells
                'royalty = value.Text 'this gets the updated royalties
                authID = Table1.Rows(celly + 1).Cells(cellx - 3).Text


                conn = control.GetConnection()
                Dim sql As String = "DELETE FROM Royalties WHERE PID = @pid and AID = @aid"
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@pid", pubID)
                cmd.Parameters.AddWithValue("@aid", authID)
                conn.Open()
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conn.Close()
            End If
        Next

        Response.Redirect(HttpContext.Current.Request.Url.ToString(), True)
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = control.GetConnection()
        conn.Open()
        Dim sql As String = "DELETE FROM Royalties WHERE PID = @pid"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@pid", ID.Text)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        sql = "DELETE FROM Publishers WHERE PID = @pid"
        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@pid", ID.Text)
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        conn.Close()

        Response.Redirect(HttpContext.Current.Request.Url.ToString(), True)
    End Sub
End Class
