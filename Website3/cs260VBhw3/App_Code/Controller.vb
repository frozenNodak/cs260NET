Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Web
Imports Microsoft.VisualBasic
Imports Microsoft.SqlServer

Public Class Controller
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

    'Function AID_generator()
    'This is not relevant. DB will auto incriment the AID 
    'Dim AID As Integer
    'Dim conn = GetConnection()
    'Dim sql As String = "Select MAX(AID) from Authors"
    'Dim cmd As New OleDb.OleDbCommand(sql, conn)
    'conn.Open()
    'Dim dbread = cmd.ExecuteReader()
    'While dbread.Read
    '    AID = dbread.GetValue("AID")
    'End While
    'AID = AID + 1
    'Return AID
    'End Function

End Class
