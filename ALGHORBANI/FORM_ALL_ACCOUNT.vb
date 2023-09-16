Imports System.Data.SqlClient
Public Class FORM_ALL_ACCOUNT
    Public GTNEW_ID As Double
    Private Sub FORM_ALL_ACCOUNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
        Dim ADAPTER As SqlDataAdapter
        Dim DS As New DataTable
        Dim QUERY As String = "Select * FROM ACCOUNTS_TABLE WHERE ACCTYPE=1"
        ADAPTER = New SqlDataAdapter(QUERY, CON)
        ADAPTER.Fill(DS)
        DGVALLACC.DataSource = DS
    End Sub

    Private Sub DGVALLACC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVALLACC.CellContentClick
        Dim CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
        Dim DT As New DataTable
        Dim FFF = ACCOUNTS_FORM
        Dim Result As Integer
        DT.Clear()
        Dim ADAPTER As SqlDataAdapter
        Dim QUERY As String = "SELECT MAX(ACCCODE),1 FROM ACCOUNTS_TABLE WHERE ACCCODEFTH = " + Result + ""
        ADAPTER = New SqlDataAdapter(QUERY, CON)
        ADAPTER.Fill(DT)
        Dim MY_NEW_ID As Int64
        MY_NEW_ID = Convert.ToInt64(ADAPTER)
        If FFF.TXTTYPELY.Text = 1 Then
            If MY_NEW_ID = 1 Then
                MY_NEW_ID = Int64.Parse(Result) + 1
            Else
                MY_NEW_ID = (Convert.ToInt64(ADAPTER))
            End If


        End If
        FFF.TextBox1.Text = MY_NEW_ID
    End Sub
End Class