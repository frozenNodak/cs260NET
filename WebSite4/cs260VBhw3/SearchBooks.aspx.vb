Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Partial Class SearchBooks
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection = control.GetConnection()
    Private Shared bookList As New List(Of Tuple(Of String, String, String))()
    Private Shared ch_purchase As New List(Of CheckBox)
    Private Shared tb_qtities As List(Of TextBox)

    Protected Sub LoadTable()
        Dim cellCtr As Integer
        Dim cellCnt As Integer
        Dim tRowNum As Integer
        cellCnt = 4

        If bookList.Count > 0 Then
            For Each tup As Tuple(Of String, String, String) In bookList
                Dim tRow As New TableRow()
                For cellCtr = 1 To cellCnt
                    Dim tCell As New TableCell()

                    If cellCtr = 1 Then 'Book Title
                        Dim hypLink As New HyperLink
                        hypLink.ID = "hl_" + cellCtr.ToString + "_" + tRowNum.ToString
                        hypLink.Text = tup.Item2.ToString()
                        hypLink.NavigateUrl = "BookInfo.aspx?&isbn=" & tup.Item1.ToString()
                        tCell.Controls.Add(hypLink)
                    ElseIf cellCtr = 2 Then 'Price
                        tCell.Text = "$" + tup.Item3.ToString()
                    ElseIf cellCtr = 3 Then 'Purchase Checkbox
                        Dim chk As New CheckBox With {
                            .ID = Convert.ToString(tRowNum) & "_" & Convert.ToString(cellCtr)}
                        'AddHandler chk.CheckedChanged, AddressOf Me.chkChanged_click

                        ch_purchase.Add(chk)
                        tCell.Controls.Add(chk)
                    ElseIf cellCtr = 4 Then 'qty
                        Dim tb_qty As New TextBox
                        tb_qty.ID = Convert.ToString(tRowNum) & "_" & Convert.ToString(cellCtr)

                        'tb_qtities.Add(tb_qty)
                        tCell.Controls.Add(tb_qty)

                    End If

                    tRow.Cells.Add(tCell)
                Next
                tRowNum = tRowNum + 1
                tbl_booksearch.Rows.Add(tRow)
            Next
        End If
    End Sub

    'Protected Sub chkChanged_click(sender As Object, e As EventArgs)
    '    Dim update As New CheckBox
    '    'update = bookList.IndexOf(sender)
    'End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        bookList.Clear()
        Dim Sql As String
        Dim priceqry As String
        Dim cmd As New OleDb.OleDbCommand()
        If l10.Checked = True Then
            Sql = "SELECT ISBN, Title, Price FROM Books WHERE Price <= 10"
            cmd = New OleDb.OleDbCommand(Sql, conn)
        ElseIf p20.Checked = True Then
            Sql = "SELECT ISBN, Title, Price FROM Books WHERE 10 < Price and Price <= 20"
            cmd = New OleDb.OleDbCommand(Sql, conn)
        ElseIf p30.Checked = True Then
            Sql = "SELECT ISBN, Title, Price FROM Books WHERE 20 < Price and Price <= 30"
            cmd = New OleDb.OleDbCommand(Sql, conn)
        ElseIf p40.Checked = True Then
            Sql = "SELECT ISBN, Title, Price FROM Books WHERE 30 < Price and Price <= 40"
            cmd = New OleDb.OleDbCommand(Sql, conn)
        ElseIf o40.Checked = True Then
            Sql = "SELECT ISBN, Title, Price FROM Books WHERE 40 < Price"
            cmd = New OleDb.OleDbCommand(Sql, conn)
        ElseIf String.IsNullOrEmpty(tb_search.Text) Then 'if there is no search keyword, get all books
            sql = "SELECT ISBN, Title, Price FROM Books"
            cmd = New OleDb.OleDbCommand(sql, conn)
        Else
            If rb_Title.Checked = True Then
                sql = "SELECT ISBN, Title, Price FROM Books WHERE [Title] LIKE '%" & tb_search.Text & "%'"
            ElseIf rb_Author.Checked = True Then
                sql = "SELECT Books.ISBN, Books.Title, Books.Price " +
                        "FROM (Authors INNER JOIN Writtenby ON Authors.[AID] = Writtenby.[AID]) " +
                        "INNER JOIN Books ON Writtenby.[ISBN] = Books.[ISBN] where Authors.[Name] LIKE '%" & tb_search.Text & "%';"
            End If

            cmd = New OleDb.OleDbCommand(sql, conn)
            'cmd.Parameters.AddWithValue("@keyword", tb_search.Text)
        End If
        conn.Open()
        Dim dbSearch = cmd.ExecuteReader()

        If dbSearch.HasRows Then
            While dbSearch.Read()
                Dim newtuple As Tuple(Of String, String, String) = New Tuple(Of String, String, String)(dbSearch.Item(0).ToString(), dbSearch.Item(1).ToString(), dbSearch.Item(2).ToString())
                bookList.Add(newtuple)
            End While
        End If
        conn.Close()
        cmd.Dispose()
        LoadTable()
    End Sub

    Protected Sub btn_Purchase_Click(sender As Object, e As EventArgs) Handles btn_Purchase.Click

        'For Each chb As CheckBox In ch_purchase
        '    Dim newRoy As String
        '    Dim parsas As Array
        '    Dim cellx As Integer
        '    Dim celly As Integer
        '    Dim value As TextBox
        '    Dim chb_Checked As CheckBox
        '    Dim royalty As String
        '    Dim isbn As String
        '    Dim cid As String
        '    Dim qty As String
        '    newRoy = chb.ID
        '    parsas = newRoy.Split("_").ToArray()
        '    celly = parsas.GetValue(0)
        '    cellx = parsas.GetValue(1)
        '    chb_Checked = DirectCast(tbl_booksearch.Rows(celly + 1).Cells(cellx - 3).Controls.Item(0), CheckBox)

        '    If chb.Checked = True Then
        '        newRoy = chb.ClientID
        '        parsas = newRoy.Split("_").ToArray()
        '        celly = parsas.GetValue(0)
        '        cellx = parsas.GetValue(1)

        '        'value = Table1.Rows(celly + 1).Cells(cellx - 3).Controls.Item(0) 'out of 5 cells
        '        'royalty = value.Text 'this gets the updated royalties
        '        isbn = tbl_booksearch.Rows(celly + 1).Cells(cellx - 3).Text
        '        qty = tbl_booksearch.Rows(celly + 1).Cells(cellx - 2).Text

        '        conn = control.GetConnection()
        '        Dim sql As String = "INSERT INTO Orders ([ISBN], [CID], [Quantity]) VALUES (@isbn, @cid, @qty)"
        '        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        '        cmd.Parameters.AddWithValue("@isbn", isbn)
        '        cmd.Parameters.AddWithValue("@cid", cid)
        '        cmd.Parameters.AddWithValue("@qty", qty)
        '        conn.Open()
        '        cmd.ExecuteNonQuery()
        '        cmd.Dispose()
        '        conn.Close()
        '    End If
        'Next
        message.Text = "Purchasing is Offline at the time. Please try back later."
    End Sub

    'Protected Sub btn_Purchase_Click2(sender As Object, e As EventArgs) Handles btn_Purchase.Click
    '    For Each row As TableRow In tbl_booksearch.Rows
    '        Dim chbox As New CheckBox
    '        chbox = row.Cells(2).Text
    '    Next
    'End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If control.GetAdmin = True Then
            adminTab.Visible = True
            custTab.Visible = False
        Else
            adminTab.Visible = False
            custTab.Visible = True
        End If
    End Sub
End Class
