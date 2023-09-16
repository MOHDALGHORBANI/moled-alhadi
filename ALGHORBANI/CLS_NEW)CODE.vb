Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CLS_NEW_CODE
    Public CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
    Public GET_NEW_CODE As Double
    ' Public Sub GET_ACCCODE(ByVal RESULT As Integer, ByVal FFF As ACCOUNTS_FORM)
    '  Dim DT As New DataTable
    ' DT.Clear()
    'Dim ADAPTER As SqlDataAdapter
    'ADAPTER = New SqlDataAdapter("SELECT ISNULL(MAX(ACCCODE),1) FROM ACCOUNTS_TABLE WHERE ACCCODEFTH = " + RESULT + "", CON)
    'ADAPTER.Fill(DT)
    ' Dim MY_NEW_ID As Integer = 0
    'MY_NEW_ID = Integer.Parse(RESULT.ToString() + "&".ToString() + 1)
    'If FFF.TXTLEVLY.Text = 1 Then
    'If MY_NEW_ID = 1 Then
    'MY_NEW_ID = Integer.Parse(RESULT.ToString() + "&".ToString() + 1)
    'End If
    'If MY_NEW_ID = 2 Then
    'MY_NEW_ID = Integer.Parse(RESULT.ToString() + "&".ToString() + 1)
    'End If
    'If MY_NEW_ID = 3 Then
    'MY_NEW_ID = Integer.Parse(RESULT.ToString() + "&".ToString() + 1)
    'End If
    'If MY_NEW_ID = 4 Then
    'MY_NEW_ID = Integer.Parse(RESULT.ToString() + "&".ToString() + 1)
    'End If
    'If MY_NEW_ID = 5 Then
    'MY_NEW_ID = Integer.Parse(RESULT.ToString() And "0000".ToString() + 1)
    'End If
    'End If
    'FFF.TextBox1.Text = MY_NEW_ID
    'End Sub
End Class
