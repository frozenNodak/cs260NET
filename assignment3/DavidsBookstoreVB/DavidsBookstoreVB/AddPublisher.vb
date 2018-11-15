Public Class AddPublisher
    Dim sum As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Enter.Click
        sum = Val(tb_Name.Text) + Val(tb_City.Text)
        TextBox3.Text = sum
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
