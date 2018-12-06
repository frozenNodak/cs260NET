Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Partial Class NewCustomer
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_Signup.Click
        conn = control.GetConnection()
        'Dim sql As String = "INSERT INTO Customers (Name, Password) values (@Name, @Password)"
        'Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Try
            If String.IsNullOrEmpty(tb_Username.Text) Then
                message.Text = "Please enter a user name"
                Return
            ElseIf String.IsNullOrEmpty(tb_password.Text) Then
                message.Text = "Please enter a password"
                Return
            End If
            Dim sql As String = "INSERT INTO Customers ([Name], [Password] ) VALUES (@name, @password);"
            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@name", tb_Username.Text)
            cmd.Parameters.AddWithValue("@password", tb_password.Text)
            conn.Open()
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()


            'Dim con As New SqlConnection
            'Dim cmd As New SqlCommand
            'con.ConnectionString = conn.ConnectionString
            'con.Open()
            'cmd.CommandText = String.Format("INSERT INTO Customers (Name, Password) VALUES ({0},  {1})", tb_Username.Text, tb_password.Text)
            'cmd.ExecuteNonQuery()
        Catch ex As Exception
            message.Text = ex.Message
            Return
        End Try
        control.Setcurrent(tb_Username.Text)
        message.Text = "Created Customer: " + tb_Username.Text + "."
        tb_Username.Text = ""
        tb_password.Text = ""
        Response.Redirect("Home.aspx")
    End Sub
End Class
