Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Web.UI.WebControls
Partial Class Login
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_login.Click
        'Response.Redirect("Home.aspx")

        conn = control.GetConnection()
        Dim sql As String = "SELECT Name, Password FROM Customers WHERE Name = @CName and Password = @password"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim dbInfo As OleDbDataReader
        Try
            If String.IsNullOrEmpty(tb_login.Text) Then
                'Error message
                Return
            ElseIf String.IsNullOrEmpty(tb_password.Text) Then
                'error message
                Return
            End If
            cmd.Parameters.AddWithValue("@CName", tb_login.Text)
            cmd.Parameters.AddWithValue("@password", tb_password.Text)
            conn.Open()
            dbInfo = cmd.ExecuteReader()
        Catch ex As Exception
            Return
        End Try

        While dbInfo.Read()
            If dbInfo.HasRows Then
                'login passed
                If String.Equals(dbInfo.Item(0), "David Erickson") Then
                    'Admin login
                    control.Setcurrent(dbInfo.Item(0))
                    Response.Redirect("AdminHome.aspx")
                End If
                'customer login
                control.Setcurrent(dbInfo.Item(0))
                Response.Redirect("Home.aspx")
            Else
                'login failed
            End If
        End While
    End Sub
    Protected Sub btn_newCust_Click(sender As Object, e As EventArgs) Handles btn_newCust.Click

        Response.Redirect("NewCustomer.aspx")

    End Sub
End Class
