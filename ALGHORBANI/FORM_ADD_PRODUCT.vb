Imports System.Data.SqlClient
Public Class FORM_ADD_PRODUCT
    Sub HGHGH()
        Dim CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
        Dim ADAPTER As SqlDataAdapter
        Dim DS As New DataTable
        Dim QUERY As String = "Select * From FORM_PRODUCT"
        ADAPTER = New SqlDataAdapter(QUERY, CON)
        ADAPTER.Fill(DS)
        DGVPRODUCT.DataSource = DS
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Close()
    End Sub
    Private Sub FORM_ADD_PRODUCT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HGHGH()
        TXTCOUNT.Text = DGVPRODUCT.Rows.Count + 1
        TXTLEN.Text = Len(TXTCOUNT.Text)
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
        Dim STRSTRING As String = "INSERT INTO FORM_PRODUCT (PROID, PRONAME, PROUNIT, PROTYPE, PROPRICE) VALUES(" & TXTID.Text & ", '" & TXTNAME.Text & "', '" & COMUNIT.Text & "', '" & COMTYPE.Text & "', '" & TXTPRICE.Text & "')"
        Dim CMD As New SqlCommand(STRSTRING, CON)
        CON.Open()
        CMD.ExecuteNonQuery()
        CON.Close()
        MsgBox("تمت الاضافة ", MsgBoxStyle.Information, "نجاح")
        TXTCOUNT.Text = DGVPRODUCT.Rows.Count + 1
        TXTLEN.Text = Len(TXTCOUNT.Text)
    End Sub

    Private Sub TXTNAME_TextChanged(sender As Object, e As EventArgs) Handles TXTNAME.TextChanged
        If TXTLEN.Text = 1 Then
            TXTID.Text = 1 & "000" & TXTCOUNT.Text
            If TXTLEN.Text = 2 Then
                TXTID.Text = 1 & "00" & TXTCOUNT.Text
                If TXTLEN.Text = 3 Then
                    TXTID.Text = 1 & "0" & TXTCOUNT.Text
                End If
            End If
        End If
    End Sub
End Class