<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPublisher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Enter = New System.Windows.Forms.Button()
        Me.tb_Name = New System.Windows.Forms.TextBox()
        Me.tb_City = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Delete = New System.Windows.Forms.Button()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Enter
        '
        Me.btn_Enter.Location = New System.Drawing.Point(57, 205)
        Me.btn_Enter.Name = "btn_Enter"
        Me.btn_Enter.Size = New System.Drawing.Size(75, 23)
        Me.btn_Enter.TabIndex = 0
        Me.btn_Enter.Text = "Enter"
        Me.btn_Enter.UseVisualStyleBackColor = True
        '
        'tb_Name
        '
        Me.tb_Name.Location = New System.Drawing.Point(157, 60)
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.Size = New System.Drawing.Size(141, 20)
        Me.tb_Name.TabIndex = 1
        '
        'tb_City
        '
        Me.tb_City.Location = New System.Drawing.Point(157, 112)
        Me.tb_City.Name = "tb_City"
        Me.tb_City.Size = New System.Drawing.Size(141, 20)
        Me.tb_City.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "City"
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(142, 205)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_Delete.TabIndex = 5
        Me.btn_Delete.Text = "Delete"
        Me.btn_Delete.UseVisualStyleBackColor = True
        '
        'btn_Search
        '
        Me.btn_Search.Location = New System.Drawing.Point(223, 205)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(75, 23)
        Me.btn_Search.TabIndex = 6
        Me.btn_Search.Text = "Search"
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ID"
        '
        'tb_ID
        '
        Me.tb_ID.Enabled = False
        Me.tb_ID.Location = New System.Drawing.Point(157, 157)
        Me.tb_ID.Name = "tb_ID"
        Me.tb_ID.Size = New System.Drawing.Size(141, 20)
        Me.tb_ID.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Add Publisher"
        '
        'AddPublisher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(938, 632)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_Search)
        Me.Controls.Add(Me.btn_Delete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_City)
        Me.Controls.Add(Me.tb_Name)
        Me.Controls.Add(Me.btn_Enter)
        Me.Name = "AddPublisher"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Enter As Button
    Friend WithEvents tb_Name As TextBox
    Friend WithEvents tb_City As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Search As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_ID As TextBox
    Friend WithEvents Label4 As Label
End Class
