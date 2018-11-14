Imports System.Data
Imports System.Data.OleDb
Partial Class AddRoyalties
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ON load, get a list of the AID, PID, and Royalties[textbox] and go through them and add a row in the table for each one
        'along with a update and delete checkbox. 
        Dim royList As New List(Of Tuple(Of String, String, String))()
        conn = Control.GetConnection()
        Dim sql As String = "SELECT * FROM Royalties"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        conn.Open()
        Dim dbRoyal = cmd.ExecuteReader()
        'cmd = Nothing



        Dim cellCtr As Integer
        Dim cellCnt As Integer
        cellCnt = 5
        If dbRoyal.HasRows Then
            While dbRoyal.Read()
                'royList.Add(New Tuple(Of String, String, String)(dbRoyal.GetString(0), dbRoyal.GetString(0), dbRoyal.GetString(0)))
                Dim tRow As New TableRow()
                For cellCtr = 1 To cellCnt
                    Dim tCell As New TableCell()
                    If cellCtr = 1 Then
                        tCell.Text = dbRoyal.Item(0).ToString()
                    ElseIf cellCtr = 2 Then
                        tCell.Text = dbRoyal.Item(1).ToString()
                    ElseIf cellCtr = 3 Then
                        tCell.Text = dbRoyal.Item(2).ToString()
                    ElseIf cellCtr = 4 Then
                        'add a checkbox for update
                    ElseIf cellCtr = 5 Then
                        'add a checkbox for delete
                    End If

                    tRow.Cells.Add(tCell)

                Next
                .Rows.Add(tRow)
            End While
        End If

        cmd.Dispose()
        conn.Close()
    End Sub
End Class
