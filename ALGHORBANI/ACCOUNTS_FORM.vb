Imports System.Data.SqlClient
Public Class ACCOUNTS_FORM
    Public CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")

    Sub MMMM()
        Dim ADAPTER As SqlDataAdapter
        Dim DS As New DataSet
        Dim QUERY As String = "Select * from ACCOUNTS_TABLE"
        ADAPTER = New SqlDataAdapter(QUERY, CON)
        ADAPTER.Fill(DS, "ACCOUNTS_TABLE")
        DGVACC.DataSource = DS.Tables("ACCOUNTS_TABLE")
    End Sub
    Private Sub ACCOUNTS_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MMMM()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub TXTACCFNO_DoubleClick(sender As Object, e As EventArgs) Handles TXTACCFNO.DoubleClick
        Dim FRM As New FORM_ACCSEARCH
        FRM.ShowDialog()
        If FRM.IS_NO = True Then
            Dim I As Integer = FRM.DGVALL.CurrentRow.Index
            TXTACCFNO.Text = FRM.DGVALL.Rows(I).Cells(0).Value.ToString()
            TXTACCFNAME.Text = FRM.DGVALL.Rows(I).Cells(1).Value.ToString()
            TXTGH1.Text = FRM.DGVALL.Rows(I).Cells(2).Value.ToString()
            TXTLEVLY.Text = FRM.DGVALL.Rows(I).Cells(3).Value.ToString() + 1
            TXTENDLY.Text = FRM.DGVALL.Rows(I).Cells(4).Value.ToString()
            TXTNUTLY.Text = FRM.DGVALL.Rows(I).Cells(5).Value.ToString()
            TXTGH2.Text = FRM.DGVALL.Rows(I).Cells(6).Value.ToString()
            TXTLEN.Text = FRM.DGVALL.Rows(I).Cells(7).Value.ToString()
        End If
    End Sub
    Private Sub COMLEVEL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMLEVEL.SelectedIndexChanged
        If COMLEVEL.Text = "الاول" Then
            TXTLEVLY.Text = 1
            COMTYPE.Text = "رئيسي"
        Else
            If COMLEVEL.Text = "الثاني" Then
                TXTLEVLY.Text = 2
                COMTYPE.Text = "رئيسي"
            Else
                If COMLEVEL.Text = "الثالث" Then
                    TXTLEVLY.Text = 3
                    COMTYPE.Text = "رئيسي"
                Else
                    If COMLEVEL.Text = "الرابع" Then
                        TXTLEVLY.Text = "4"
                        COMTYPE.Text = "رئيسي"
                    Else
                        If COMLEVEL.Text = "الخامس" Then
                            TXTLEVLY.Text = 5
                            COMTYPE.Text = "فرعي"
                        End If
                    End If
                End If
            End If

        End If
        COMTYPE.Focus()
    End Sub
    Private Sub TXTLEVLY_TextChanged(sender As Object, e As EventArgs) Handles TXTLEVLY.TextChanged
        If TXTLEVLY.Text = 1 Then
            COMLEVEL.Text = "الاول"
            COMTYPE.Text = "رئيسي"
            TXTTYPELY.Text = 1
        Else
            If TXTLEVLY.Text = 2 Then
                COMLEVEL.Text = "الثاني"
                COMTYPE.Text = "رئيسي"
                TXTTYPELY.Text = 1
            Else
                If TXTLEVLY.Text = 3 Then
                    COMLEVEL.Text = "الثالث"
                    COMTYPE.Text = "رئيسي"
                    TXTTYPELY.Text = 1
                Else
                    If TXTLEVLY.Text = 4 Then
                        COMLEVEL.Text = "الرابع"
                        COMTYPE.Text = "رئيسي"
                        TXTTYPELY.Text = 1
                    Else
                        If TXTLEVLY.Text = 5 Then
                            COMLEVEL.Text = "الخامس"
                            COMTYPE.Text = "فرعي"
                            TXTTYPELY.Text = 2
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub COMEND_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMEND.SelectedIndexChanged
        If COMEND.Text = "الميزانية العمومية" Then
            TXTENDLY.Text = 1
        Else
            If COMEND.Text = "الارباح والخسائر" Then
                TXTENDLY.Text = 2
            Else
                If COMEND.Text = "المتاجرة" Then
                    TXTENDLY.Text = 3


                End If
            End If
        End If
    End Sub

    Private Sub COMNUT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMNUT.SelectedIndexChanged
        If COMNUT.Text = "مدين" Then
            TXTNUTLY.Text = 1
        Else
            TXTNUTLY.Text = 2
        End If
        TXTACCFNO.Focus()
    End Sub
    Private Sub COMTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMTYPE.SelectedIndexChanged
        If COMTYPE.Text = "رئيسي" Then
            TXTTYPELY.Text = 1
        Else
            TXTTYPELY.Text = 2
        End If

    End Sub

    Private Sub TXTACCNAME_TextChanged(sender As Object, e As EventArgs) Handles TXTACCNAME.TextChanged

        If TXTLEVLY.Text = 2 And TXTTYPELY.Text = 1 And TXTLEN.Text = 1 Then
            TXTACC.Text = TXTGH1.Text & TXTGH2.Text
            TXTACCNO.Text = TXTACC.Text
        End If
        TXTLEN.Text = Len(TXTGH2.Text)
        If TXTLEVLY.Text = 3 And TXTTYPELY.Text = 1 And TXTLEN.Text = 1 Then
            TXTACC.Text = TXTGH1.Text & TXTGH2.Text
            TXTACCNO.Text = TXTACC.Text
        End If
        If TXTLEVLY.Text = 4 And TXTTYPELY.Text = 1 And TXTLEN.Text = 1 Then
            TXTACC.Text = TXTGH1.Text & "0" & TXTGH2.Text
            TXTACCNO.Text = TXTACC.Text
        Else
            If TXTLEVLY.Text = 4 And TXTTYPELY.Text = 1 And TXTLEN.Text = 2 Then
                TXTACC.Text = TXTGH1.Text & TXTGH2.Text
                TXTACCNO.Text = TXTACC.Text
            End If
        End If
        If TXTLEVLY.Text = 5 And TXTTYPELY.Text = 2 And TXTLEN.Text = 1 Then
            TXTACC.Text = TXTGH1.Text
            TXTACCNO.Text = TXTACC.Text & "0000" & TXTGH2.Text
        End If
        If TXTLEVLY.Text = 5 And TXTTYPELY.Text = 2 And TXTLEN.Text = 2 Then
            TXTACC.Text = TXTGH1.Text
            TXTACCNO.Text = TXTACC.Text & "000" & TXTGH2.Text
        End If
        If TXTLEVLY.Text = 5 And TXTTYPELY.Text = 2 And TXTLEN.Text = 3 Then
            TXTACC.Text = TXTGH1.Text
            TXTACCNO.Text = TXTACC.Text & "00" & TXTGH2.Text
        End If
        If TXTLEVLY.Text = 5 And TXTTYPELY.Text = 2 And TXTLEN.Text = 4 Then
            TXTACC.Text = TXTGH1.Text
            TXTACCNO.Text = TXTACC.Text & "0" & TXTGH2.Text

        End If

    End Sub
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        If TXTLEVLY.Text = "" Then
            MsgBox("الرجاء تحديد مستوى الحساب", MsgBoxStyle.Information, "خطأ في البيانات")
            Exit Sub
        End If
        If TXTTYPELY.Text = "" Then
            MsgBox("الرجاء إدخال نوع الحساب", MsgBoxStyle.Information, "خطأ في البيانات")
            Exit Sub
        End If
        If TXTNUTLY.Text = "" Then
            MsgBox("الرجاء إدخال طبيعة الحساب", MsgBoxStyle.Information, "خطأ في البيانات")
            Exit Sub
        End If
        If TXTENDLY.Text = "" Then
            MsgBox("الرجاء إدخال الحساب الختامي", MsgBoxStyle.Information, "خطأ في البيانات")
            Exit Sub
        End If
        If TXTACCNAME.Text = "" Then
            MsgBox("الرجاء إدخال اسم الحساب", MsgBoxStyle.Information, "خطأ في البيانات")
            Exit Sub
        End If
        If TXTACCFNO.Text = "" And TXTLEVLY.Text > 1 Then
            MsgBox("الرجاء إدخال اسم الحساب الاب", MsgBoxStyle.Information, "خطأ في البيانات")
            Exit Sub
        End If
        CON.Open()
        Dim CMD As New SqlCommand
        Dim STRSTRING1 As String = "INSERT INTO ACCOUNTS_TABLE (ACCCODE, ACCNAME, ACCCODEFTH, ACCNAMEFTH, ACCLEVEL, ACCTYPE, ACCNUT, ACCEND, ACC) VALUES(" & TXTACCNO.Text & ", '" & TXTACCNAME.Text & "', '" & TXTACCFNO.Text & "', '" & TXTACCFNAME.Text & "', '" & TXTLEVLY.Text & "', '" & TXTTYPELY.Text & "', '" & TXTNUTLY.Text & "', '" & TXTENDLY.Text & "', '" & TXTACC.Text & "')"
        CMD.CommandText = STRSTRING1
        CMD.Connection = CON
        CMD.ExecuteNonQuery()
        '__________________________________________________________________________________
        STRSTRING1 = "INSERT INTO ACCFATHERSS_TABLE (ACCCNO, ACCFATHENNO) VALUES(" & TXTACCNO.Text & ", " & TXTACCFNO.Text & ")"
        CMD.CommandText = STRSTRING1
        CMD.Connection = CON
        CMD.ExecuteNonQuery()
        MsgBox("تمت الاضافة ", MsgBoxStyle.Information, "نجاح")
        TXTACCFNO.Clear()
        TXTACCFNAME.Clear()
        TXTACCNO.Clear()
        TXTACCNAME.Clear()
        CON.Close()

    End Sub


    Private Sub TXTACCFNAME_DoubleClick(sender As Object, e As EventArgs) Handles TXTACCFNAME.DoubleClick
        Dim FRM As New FORM_ACCSEARCH
        FRM.ShowDialog()
        If FRM.IS_NO = True Then
            Dim I As Integer = FRM.DGVALL.CurrentRow.Index
            TXTACCFNO.Text = FRM.DGVALL.Rows(I).Cells(0).Value.ToString()
            TXTACCFNAME.Text = FRM.DGVALL.Rows(I).Cells(1).Value.ToString()
            TXTGH1.Text = FRM.DGVALL.Rows(I).Cells(2).Value.ToString()
            TXTLEVLY.Text = FRM.DGVALL.Rows(I).Cells(3).Value.ToString() + 1
            TXTENDLY.Text = FRM.DGVALL.Rows(I).Cells(4).Value.ToString()
            TXTNUTLY.Text = FRM.DGVALL.Rows(I).Cells(5).Value.ToString()
            TXTGH2.Text = FRM.DGVALL.Rows(I).Cells(6).Value.ToString()
            TXTLEN.Text = FRM.DGVALL.Rows(I).Cells(7).Value.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            CON.Open()
            Dim CMD As New SqlCommand
            Dim TRANS As SqlTransaction = CON.BeginTransaction
            Dim STRSTRING1 As String = "INSERT INTO ACCOUNTS_TABLE (ACCCODE, ACCNAME, ACCCODEFTH, ACCNAMEFTH, ACCLEVEL, ACCTYPE, ACCNUT, ACCEND, ACC) VALUES(" & TXTACCNO.Text & ", '" & TXTACCNAME.Text & "', '" & TXTACCFNO.Text & "', '" & TXTACCFNAME.Text & "', '" & TXTLEVLY.Text & "', '" & TXTTYPELY.Text & "', '" & TXTNUTLY.Text & "', '" & TXTENDLY.Text & "', '" & TXTACC.Text & "')"
            CMD.CommandText = STRSTRING1
            CMD.Connection = CON
            CMD.Transaction = TRANS
            CMD.ExecuteNonQuery()
            For I As Integer = 0 To 3
                STRSTRING1 = "INSERT INTO ACCFATHERSS_TABLE (ACCCNO, ACCFATHENNO) VALUES(" & TXTACCNO.Text & ", " & TXTACCFNO.Text & ")"
                CMD.CommandText = STRSTRING1
                CMD.Connection = CON
                CMD.Transaction = TRANS
                CMD.ExecuteNonQuery()
            Next
            MsgBox("تمت الاضافة ", MsgBoxStyle.Information, "نجاح")
            TXTLEVLY.Clear()
            TXTTYPELY.Clear()
            TXTNUTLY.Clear()
            TXTENDLY.Clear()
            TXTACCFNO.Clear()
            TXTACCFNAME.Clear()
            TXTACCNO.Clear()
            TXTACCNAME.Clear()


        Catch ex As Exception
            MsgBox("عذراً هناك مشكلة", MsgBoxStyle.Information, "فشل")
            Exit Sub
        End Try
    End Sub



    Private Sub TXTNUTLY_TextChanged(sender As Object, e As EventArgs) Handles TXTNUTLY.TextChanged
        If TXTNUTLY.Text = 1 Then
            COMNUT.Text = "مدين"
        Else
            COMNUT.Text = "دائن"
        End If
    End Sub

    Private Sub TXTENDLY_TextChanged(sender As Object, e As EventArgs) Handles TXTENDLY.TextChanged
        If TXTENDLY.Text = 1 Then
            COMEND.Text = "الميزانية العمومية"
        Else
            If TXTENDLY.Text = 2 Then
                COMEND.Text = "الارباح والخسائر"
            Else
                If TXTENDLY.Text = 3 Then
                    COMEND.Text = "المتاجرة"
                End If
            End If
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim FRM As New FORM_COUNTFATHER
        FRM.ShowDialog()
        If FRM.IS_YES = True Then
            Dim I As Integer = FRM.DGVFTH.CurrentRow.Index
            TXTACCFNO.Text = FRM.DGVFTH.Rows(I).Cells(0).Value.ToString()
            TXTACCFNAME.Text = FRM.DGVFTH.Rows(I).Cells(1).Value.ToString()
            TXTGH1.Text = FRM.DGVFTH.Rows(I).Cells(2).Value.ToString()
            TXTLEVLY.Text = FRM.DGVFTH.Rows(I).Cells(3).Value.ToString() + 1
            TXTENDLY.Text = FRM.DGVFTH.Rows(I).Cells(4).Value.ToString()
            TXTNUTLY.Text = FRM.DGVFTH.Rows(I).Cells(5).Value.ToString()
            TXTGH2.Text = FRM.DGVFTH.Rows(I).Cells(6).Value.ToString()
            TXTLEN.Text = FRM.DGVFTH.Rows(I).Cells(7).Value.ToString()
        End If
    End Sub
    ' Dim DT As New DataSet
    'Dim IDID As String
    'Dim SINGH As SqlDataAdapter
    ' Sub NEWIDCODE(ByVal RESULT As Integer)
    '   SINGH.SelectCommand = New SqlCommand("SELECT ISNULL(MAX(ACCCODF),1) FROM ACCOUNTS_TABLE WHERE ACCCODEFTH = " + RESULT + "", CON)
    '  SINGH.Fill(DT)
    ' If TXTLEVLY.Text = 2 Then
    'Dim idd As Integer
    'idd = Integer.Parse(RESULT.ToString() + 1)
    'IDID = idd.ToString() & 1
    'End If
    'TextBox1.Text = IDID.ToString()
    '   End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim FRM As New FORM_ALL_ACCOUNT
        FRM.ShowDialog()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Dim DT As New DataTable
        ' Dim RESULT As Integer
        'DT.Clear()
        'Dim ADAPTER As SqlDataAdapter
        'ADAPTER = New SqlDataAdapter("SELECT ISNULL(MAX(ACCCODE),1) FROM ACCOUNTS_TABLE WHERE ACCCODEFTH = " + RESULT + "", CON)
        'ADAPTER.Fill(DT)
        'Dim MY_NEW_ID As Integer = 0
        'MY_NEW_ID = Integer.Parse(RESULT.ToString() + "&".ToString() + 1)
        'If TXTLEVLY.Text = 1 Then
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
        'TextBox1.Text = MY_NEW_ID
    End Sub
    ' ElseIf (Convert.IsDBNull(DT.Tables(0))) Then
End Class
