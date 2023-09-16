Imports System.Data.SqlClient
Public Class FORM_ADD_USER
    Dim CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim STRSTRING As String = "INSERT INTO TABLE_USERS (PASS_WORD, USER_NAME) VALUES(" & TXTPASSWORD.Text & ", '" & TXTUSERNAME.Text & "')"
        Dim CMD As New SqlCommand(STRSTRING, CON)
        CON.Open()
        CMD.ExecuteNonQuery()
        CON.Close()
        MsgBox("تمت الاضافة ", MsgBoxStyle.Information, "نجاح")
    End Sub
    Sub FGFG()
        Dim ADAPTER As SqlDataAdapter
        Dim DS As New DataSet
        Dim QUERY As String = "Select * from TABLE_USERS"
        ADAPTER = New SqlDataAdapter(QUERY, CON)
        ADAPTER.Fill(DS, "TABLE_USERS")
        DGVUSERS.DataSource = DS.Tables("TABLE_USERS")

    End Sub
    Private Sub FORM_ADD_USER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FGFG()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Close()
    End Sub
End Class
