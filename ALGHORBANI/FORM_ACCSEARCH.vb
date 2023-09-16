Imports System.Data.SqlClient
Public Class FORM_ACCSEARCH
    Public IS_NO As Boolean = False
    Private Sub FORM_ACCSEARCH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
        Dim ADAPTER As SqlDataAdapter
        Dim DS As New DataSet
        Dim QUERY As String = "Select ACCOUNTS_TABLE.ACCCODE, ACCOUNTS_TABLE.ACCNAME, ACCOUNTS_TABLE.ACC,  ACCOUNTS_TABLE.ACCLEVEL, ACCOUNTS_TABLE.ACCEND,  ACCOUNTS_TABLE.ACCNUT, COUNT(ACCFATHERSS_TABLE.ACCFATHENNO)+1, Len(COUNT(ACCFATHERSS_TABLE.ACCFATHENNO)+1) From ACCOUNTS_TABLE INNER JOIN ACCFATHERSS_TABLE On ACCOUNTS_TABLE.ACCCODE=ACCFATHERSS_TABLE.ACCFATHENNO GROUP BY ACCOUNTS_TABLE.ACCCODE, ACCOUNTS_TABLE.ACCNAME, ACCOUNTS_TABLE.ACC, ACCOUNTS_TABLE.ACCLEVEL, ACCOUNTS_TABLE.ACCEND, ACCOUNTS_TABLE.ACCNUT"
        ADAPTER = New SqlDataAdapter(QUERY, CON)
        ADAPTER.Fill(DS, "ACCOUNTS_TABLE")
        DGVALL.DataSource = DS.Tables("ACCOUNTS_TABLE")
    End Sub
    Private Sub DGVALL_DoubleClick(sender As Object, e As EventArgs) Handles DGVALL.DoubleClick
        IS_NO = True
        Close()
    End Sub
End Class