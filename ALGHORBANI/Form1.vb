Imports System.Data.SqlClient
Public Class Form1
    Private Sub BUTLOGIN_Click_1(sender As Object, e As EventArgs) Handles BUTLOGIN.Click
        Dim CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
        Dim QUERY As String = "Select * from TABLE_USERS WHERE USER_NAME='" & TXTNAME.Text & "' AND PASS_WORD='" & TXTPASS.Text & "'"
        Dim CMD As New SqlCommand(QUERY, CON)
        CON.Open()
        Dim READER As SqlDataReader = CMD.ExecuteReader
        READER.Read()
        If READER.HasRows Then
            Dim FRM As New FORM_MAIN
            FRM.Show()
            Me.Close()

        Else
            MsgBox("البيانات المدخلة غير صحيحة", MsgBoxStyle.Critical, "فشــل")
        End If
        READER.Close()
        CON.Close()
    End Sub

    Private Sub BUTCLOSE_Click_1(sender As Object, e As EventArgs) Handles BUTCLOSE.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

