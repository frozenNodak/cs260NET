Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.UI.WebControls

Partial Class CustInfo
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        conn = control.GetConnection()
        Dim cid As String
        Dim name As String
        Dim sqlOrders As String = "SELECT Orders.Quantity, Orders.ISBN, Books.Title " +
                                    "FROM Books INNER JOIN Orders ON Books.[ISBN] = Orders.[ISBN] WHERE Orders.[CID] = @CID;"
        Dim sqlbooks As String = "Select TOP 1 Title, ISBN FROM Books where ISBN = @ISBN"
        Dim cmdOrders As New OleDb.OleDbCommand(sqlOrders, conn)
        Dim dbOrders As OleDbDataReader
        Dim Totalqty As Integer = 0

        If control.GetAdmin = True Then 'If user is the admin
            adminTab.Visible = True
            custTab.Visible = False

            If String.IsNullOrEmpty(Request.QueryString("cid")) = False Then
                cid = Request.QueryString("cid")
                name = Request.QueryString("name")
                cmdOrders.Parameters.AddWithValue("@CID", cid)
                lbl_Name.Text = name
                lbl_ID.Text = cid

            End If
        Else 'If user is the customer
            adminTab.Visible = False
            custTab.Visible = True
            Dim sqlCustID As String = "SELECT Name, CID FROM Customers WHERE Name = @name"
            conn.Open()
            Dim cmdCID As New OleDb.OleDbCommand(sqlCustID, conn)
            cmdCID.Parameters.AddWithValue("@name", control.getCurrentUser)
            Dim dbCID As OleDbDataReader
            dbCID = cmdCID.ExecuteReader()

            If dbCID.HasRows Then
                While dbCID.Read()
                    lbl_Name.Text = dbCID.Item(0).ToString
                    lbl_ID.Text = dbCID.Item(1).ToString
                    cmdOrders.Parameters.AddWithValue("@CID", dbCID.Item(1).ToString)
                End While
            End If
            conn.Close()
        End If

        ''Fill in the customer book info
        conn.Open()
        dbOrders = cmdOrders.ExecuteReader()
        cmdOrders.Dispose()
        If dbOrders.HasRows Then
            While dbOrders.Read()
                Dim tRow As New TableRow()

                Dim tCell As New TableCell()
                Dim hyplink As New HyperLink
                hyplink.Text = dbOrders.Item(2).ToString()
                hyplink.NavigateUrl = "BookInfo.aspx?isbn=" & dbOrders.Item(1).ToString
                tCell.Controls.Add(hyplink)
                tRow.Cells.Add(tCell)

                Dim tCell2 As New TableCell()
                tCell2.Text = dbOrders.Item(0).ToString
                Totalqty = Totalqty + Convert.ToInt32(dbOrders.Item(0).ToString)
                tRow.Cells.Add(tCell2)

                tb_books.Rows.Add(tRow)
            End While
        Else
            message.Text = "No Books Found"
        End If

        lbl_Purchased.Text = Totalqty.ToString
        cmdOrders.Dispose()
        conn.Close()

    End Sub
End Class
