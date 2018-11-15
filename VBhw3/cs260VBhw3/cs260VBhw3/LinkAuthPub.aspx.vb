
Imports System.Data
Imports System.Data.OleDb

Partial Class LinkAuthPub
    Inherits System.Web.UI.Page
    Dim control As New Controller
    Dim conn As OleDbConnection
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'verify inputs
        If String.IsNullOrEmpty(ddl_Publishers.SelectedValue) Then
            MsgBox("Please select a Publisher.", 0, "INPUT ERROR")
            Return
        End If
        If String.IsNullOrEmpty(ddl_Authors.SelectedValue) Then
            MsgBox("Please select an Author.", 0, "INPUT ERROR")
            Return
        End If
        If String.IsNullOrEmpty(tb_Royalties.Text) Then
            tb_Royalties.Text = 0
        ElseIf CheckForAlphaCharacters(tb_Royalties.Text) Then
            MsgBox("Please enter only numeric values", 0, "INPUT ERROR")
            Return
        End If

        'Insert into DB
        conn = control.GetConnection()
        Dim sql As String = "INSERT INTO Royalties(PID, AID, Royalty) VALUES(@PID, @AID, @Royalty)"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@PID", ddl_Publishers.SelectedValue)
        cmd.Parameters.AddWithValue("@AID", ddl_Authors.SelectedValue)
        cmd.Parameters.AddWithValue("@Royalty", tb_Royalties.Text)
        conn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()


        greet.Text = "Linking: " + ddl_Authors.SelectedItem.Text + ", " + ddl_Publishers.SelectedItem.Text + ", " + tb_Royalties.Text & "%"
    End Sub

    'Checks for aplha chars
    Public Function CheckForAlphaCharacters(ByVal StringToCheck As String) As Boolean
        For i = 0 To StringToCheck.Length - 1
            If Not Char.IsLetter(StringToCheck.Chars(i)) Then
                Return False
            End If
        Next

        Return True 'Return true if all elements are characters
    End Function
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'add the connection string programatically


    End Sub
End Class
