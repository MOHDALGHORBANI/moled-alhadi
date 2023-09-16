Imports System.Data.SqlClient
Imports System.Windows
Public Class FORM_COUNTFATHER
    Public IS_YES As Boolean = False
    Private Sub FORM_COUNTFATHER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
        Dim ADAPTER As SqlDataAdapter
        Dim DS As New DataSet
        Dim QUERY As String = "Select ACCNAMEFTH, ACCCODEFTH, COUNT(ACCNAMEFTH) As GGGGG FROM ACCOUNTS_TABLE Group By ACCNAMEFTH, ACCCODEFTH"
        ADAPTER = New SqlDataAdapter(QUERY, CON)
        ADAPTER.Fill(DS, "ACCOUNTS_TABLE")
        DGVFTH.DataSource = DS.Tables("ACCOUNTS_TABLE")
    End Sub
    Private Sub DGVFTH_DoubleClick(sender As Object, e As EventArgs) Handles DGVFTH.DoubleClick
        IS_YES = True
        Close()
    End Sub
End Class