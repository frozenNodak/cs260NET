Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Partial Class AddRoyalties
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection
    Dim royList As New List(Of Tuple(Of String, String, String))
    Dim cb_toUpdate As List(Of CheckBox)
    Dim cb_toDelete As List(Of CheckBox)

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ON load, get a list of the Authors, Name, and Royalties[textbox] and go through them and add a row in the table for each one
        'along with a update and delete checkbox. 
        Dim royList As New List(Of Tuple(Of String, String, String))()

        conn = control.GetConnection()
        Dim sql As String = "SELECT Authors.Name AS Authors_Name, Authors.AID, Publishers.Name As Publishers_Name, Publishers.PID, Royalties.Royalty " &
                    "From Publishers INNER Join (Authors INNER Join Royalties On Authors.[AID] = Royalties.[AID]) ON Publishers.[PID] = Royalties.[PID];"

        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        conn.Open()
        Dim dbRoyal = cmd.ExecuteReader()
        'cmd = Nothing


        Dim cellCtr As Integer
        Dim cellCnt As Integer
        Dim tRowNum As Integer
        cellCnt = 5
        If dbRoyal.HasRows Then
            While dbRoyal.Read()
                Dim tRow As New TableRow()
                Dim newtuple As Tuple(Of String, String, String) = New Tuple(Of String, String, String)(dbRoyal.Item(0).ToString(), dbRoyal.Item(1).ToString(), dbRoyal.Item(2).ToString())
                royList.Add(newtuple)
                For cellCtr = 1 To cellCnt

                    Dim tCell As New TableCell()
                    If cellCtr = 1 Then
                        Dim hypLink As New HyperLink
                        hypLink.Text = dbRoyal.Item(0).ToString() & " (" & dbRoyal.Item(1).ToString & ")"
                        hypLink.NavigateUrl = "AuthorInfo.aspx?&id=" & dbRoyal.Item(1).ToString
                        tCell.Controls.Add(hypLink)
                    ElseIf cellCtr = 2 Then
                        Dim hyplink As New HyperLink
                        hyplink.Text = dbRoyal.Item(2).ToString() & " (" & dbRoyal.Item(3).ToString & ")"
                        hyplink.NavigateUrl = "PublisherInfo.aspx?&id=" & dbRoyal.Item(3).ToString
                        tCell.Controls.Add(hyplink)
                    ElseIf cellCtr = 3 Then
                        tCell.Text = dbRoyal.Item(4).ToString
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
