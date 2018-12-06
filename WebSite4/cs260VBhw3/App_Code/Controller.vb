Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Web
Imports Microsoft.VisualBasic
Imports Microsoft.SqlServer

Public Class Controller
    Public Shared CurrentAdmin As Boolean
    Public Shared CurrentUser As String
    Public Function GetConnection() As OleDbConnection
        Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + System.Web.HttpContext.Current.Server.MapPath("~/Access/Connect.accdb"))
        'Dim sql As String = "INSERT INTO Contacts( FullName, City ) VALUES( @FullName, @City )"
        'Dim cmd As New OleDb.OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@FullName", FullName.Text)
        'cmd.Parameters.AddWithValue("@City", City.Text)
        'conn.Open()
        'cmd.ExecuteNonQuery()
        'cmd.Dispose()
        'conn.Close()
        Return conn
    End Function

    Public Function Setcurrent(ByVal name As String) As Boolean
        If name.Equals("David Erickson") Then
            CurrentAdmin = True
            CurrentUser = name
        Else
            CurrentAdmin = False
            CurrentUser = name
        End If
    End Function

    Public Function GetAdmin()
        Return CurrentAdmin
    End Function

    Public Function getCurrentUser()
        Return CurrentUser
    End Function

End Class
