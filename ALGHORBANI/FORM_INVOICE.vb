Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class FORM_INVOICE
    Private Sub FORM_INVOICE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SETDATASU()
        YUY()
        CALCULAMOUNT1()
        QAID_NU()
    End Sub
    Public DTA As New DataTable
    Sub SETDATASU()
        DTA.Columns.Add("رقم الفاتورة")
        DTA.Columns.Add("رقم الصنف")
        DTA.Columns.Add("اسم الصنف")
        DTA.Columns.Add("الفئة")
        DTA.Columns.Add("الوحدة")
        DTA.Columns.Add("الكمية")
        DTA.Columns.Add("السعر")
        DTA.Columns.Add("المبلغ")
        DGVPRUDCOT.DataSource = DTA
        DGVPRUDCOT.Columns(0).Width = 10
        DGVPRUDCOT.Columns(1).Width = 80
        DGVPRUDCOT.Columns(2).Width = 600
        DGVPRUDCOT.Columns(3).Width = 150
        DGVPRUDCOT.Columns(4).Width = 150
        DGVPRUDCOT.Columns(5).Width = 150
        DGVPRUDCOT.Columns(6).Width = 150
        DGVPRUDCOT.Columns(7).Width = 200

    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Close()
    End Sub
    Public CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
    Private Sub TXTPRONO_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTPRONO.KeyDown
        Try
            Dim CMD As SqlCommand
            If e.KeyCode = Keys.Enter Then
                CMD = New SqlCommand("SELECT PRONAME, PROUNIT, PROTYPE, PROPRICE FROM FORM_PRODUCT WHERE PROID =" & TXTPRONO.Text, CON)
                CON.Open()
                Dim DM As SqlDataReader = CMD.ExecuteReader
                DM.Read()
                If DM.HasRows Then
                    TXTPRONAME.Text = DM(0)
                    TXTPROUNIT.Text = DM(1)
                    TXTPROTYPE.Text = DM(2)
                    TXTPRICE.Text = DM(3)
                    TXTQUNT.Focus()
                Else
                    MsgBox("رقم الصنف غير موجود", MsgBoxStyle.Exclamation, "تنبيه")
                    TXTPRONO.Clear()
                    TXTPRONAME.Clear()
                    TXTPROUNIT.Clear()
                    TXTPROTYPE.Clear()
                    TXTQUNT.Clear()
                    TXTPRICE.Clear()
                    TXTAMOUNT.Clear()
                    TXTPRONO.Focus()
                End If
                DM.Close()

            End If
        Catch ex As Exception
            Exit Sub

        Finally
            CON.Close()
        End Try
        '=======
    End Sub
    Sub YUY()
        Dim ADPT As SqlDataAdapter
        Dim USERNA As New DataTable
        ADPT = New SqlDataAdapter("select * from INVOICE_TABLE", CON)
        ADPT.Fill(USERNA)
        Me.DGVPRUDCOT.DataSource = USERNA
        TXTIND.Text = "00000" & DGVPRUDCOT.Rows.Count - 1 + 1
        TXTINVNO.Text = "00000" & DGVPRUDCOT.Rows.Count - 1 + 1
    End Sub
    Sub QAID_NU()
        Dim ADPT As SqlDataAdapter
        Dim USERNA As New DataTable
        ADPT = New SqlDataAdapter("select * from QAID", CON)
        ADPT.Fill(USERNA)
        Me.DataGridView1.DataSource = USERNA
        TXTQD.Text = DataGridView1.Rows.Count / 2 + 1
    End Sub

    Sub CALCULAMOUNT1()
        TXTAMOUNT.Text = Val(TXTQUNT.Text) * Val(TXTPRICE.Text)
    End Sub

    Private Sub TXTQUNT_TextChanged(sender As Object, e As EventArgs) Handles TXTQUNT.TextChanged, TXTPRICE.TextChanged
        TXTAMOUNT.Text = Val(TXTQUNT.Text) * Val(TXTPRICE.Text)
    End Sub

    Private Sub TXTQUNT_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTQUNT.KeyDown
        If e.KeyCode = Keys.Enter Then
            For i As Integer = 0 To DGVPRUDCOT.Rows.Count - 1
                If DGVPRUDCOT.Rows(i).Cells(0).Value = TXTPRONO.Text Then
                    MsgBox("هذا المنتج موجود مسبقاً", MsgBoxStyle.Critical, "worning")
                    TXTPRONO.Clear()
                    TXTPRONAME.Clear()
                    TXTPROTYPE.Clear()
                    TXTPROUNIT.Clear()
                    TXTQUNT.Clear()
                    TXTPRICE.Clear()
                    TXTAMOUNT.Clear()
                    TXTPRONO.Focus()

                    Exit Sub
                End If
                If TXTQUNT.Text = "" Then
                    MsgBox("KK", MsgBoxStyle.Critical, "JJJJJ")
                    Exit Sub

                End If
            Next

            Dim ROW As DataRow = DTA.NewRow
            ROW(0) = TXTIND.Text
            ROW(1) = TXTPRONO.Text
            ROW(2) = TXTPRONAME.Text
            ROW(3) = TXTPROUNIT.Text
            ROW(4) = TXTPROTYPE.Text
            ROW(5) = TXTQUNT.Text
            ROW(6) = TXTPRICE.Text
            ROW(7) = TXTAMOUNT.Text
            DTA.Rows.Add(ROW)
            Me.DGVPRUDCOT.DataSource = DTA
            TXTPRONO.Focus()

            TXTPRONO.Clear()
            TXTPRONAME.Clear()
            TXTPROUNIT.Clear()
            TXTPROTYPE.Clear()
            TXTQUNT.Clear()
            TXTPRICE.Clear()
            TXTAMOUNT.Clear()
            Dim SUM As Integer = 0
            For N As Integer = 0 To DGVPRUDCOT.Rows.Count() - 1 Step +1
                SUM += DGVPRUDCOT.Rows(N).Cells(7).Value
            Next
            TXTTOTAL.Text = SUM.ToString
            TXTTOTALACC.Text = SUM.ToString
        End If
    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        Try
            DGVPRUDCOT.Rows.RemoveAt(DGVPRUDCOT.CurrentRow.Index)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub DGVPRUDCOT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPRUDCOT.CellContentClick
        TXTIND.Text = Me.DGVPRUDCOT.CurrentRow.Cells(0).Value
        TXTPRONO.Text = Me.DGVPRUDCOT.CurrentRow.Cells(1).Value
        TXTPRONAME.Text = Me.DGVPRUDCOT.CurrentRow.Cells(2).Value
        TXTPROUNIT.Text = Me.DGVPRUDCOT.CurrentRow.Cells(3).Value
        TXTPROTYPE.Text = Me.DGVPRUDCOT.CurrentRow.Cells(4).Value
        TXTQUNT.Text = Me.DGVPRUDCOT.CurrentRow.Cells(5).Value
        TXTPRICE.Text = Me.DGVPRUDCOT.CurrentRow.Cells(6).Value
        TXTAMOUNT.Text = Me.DGVPRUDCOT.CurrentRow.Cells(7).Value
        DGVPRUDCOT.Rows.RemoveAt(DGVPRUDCOT.CurrentRow.Index)
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        CON.Open()
        Dim CMD As New SqlCommand
        Dim STRSTRING1 As String = "INSERT INTO QAID (QD, TYPEDOC, MD, DA, DES, ACCOUNT, DESCR, DATE_) VALUES(" & TXTQD.Text & ", '" & TXTTYPE.Text & "', '" & TXTTOTAL.Text & "', '" & "0" & "', '" & TextBox1.Text & "', '" & TXTCUSNAME.Text & "', '" & TXTDATE.MinDate & "', '" & TXTDATE.MinDate & "')"
        CMD.CommandText = STRSTRING1
        CMD.Connection = CON
        CMD.ExecuteNonQuery()
        '__________________________________________________________________________________
        STRSTRING1 = "INSERT INTO QAID (QD, TYPEDOC, MD, DA, DES, ACCOUNT, DESCR, DATE_) VALUES(" & TXTQD.Text & ", '" & TXTTYPE.Text & "', '" & "0" & "', '" & TXTTOTAL.Text & "', '" & TextBox2.Text & "', '" & TXTACCNAME1.Text & "', '" & TXTDATE.MinDate & "', '" & TXTDATE.MinDate & "')"
        CMD.CommandText = STRSTRING1
        CMD.Connection = CON
        CMD.ExecuteNonQuery()
        '__________________________________________________________________________________
        STRSTRING1 = "INSERT INTO INVOICE_TABLE (INVID, INVDATE, INVTYPE, CUSNO, cusname, TOTAL, RESBONS, CURRNCY, STORY, REFRNCE, QAID, ACCNO, ACCNAME, ACCCURRNCY, ACCAMOUNT, NOTEE, ACCQAID) VALUES(" & TXTINVNO.Text & ", '" & TXTDATE.MinDate & "', '" & TXTTYPE.Text & "', '" & TXTCUSNO.Text & "', '" & TXTCUSNAME.Text & "', '" & TXTTOTAL.Text & "', '" & TXTCURNCY.Text & "', '" & TXTCURNCY.Text & "', '" & TXTSTORS.Text & "', '" & TXTREF.Text & "', '" & TXTQD.Text & "', '" & TXTACCNO.Text & "', '" & TXTACCNAME1.Text & "', '" & TXTACCCURRNCY.Text & "', '" & TXTTOTALACC.Text & "', '" & TXTNOTE.Text & "', '" & ACCQD.Text & "')"
        CMD.CommandText = STRSTRING1
        CMD.Connection = CON
        CMD.ExecuteNonQuery()

        '==========================================
        Dim IDP, PRNO, QTY, PRI, AMOU As Integer


        STRSTRING1 = "INSERT INTO INVOICE_TABLE (INVIDD, PROID, QUNT, PROPRICE, AMOUNT)
                      VALUSE(@INVIDD, @PROID, @QUNT, @PROPRICE, @AMOUNT) "
        For I As Integer = 0 To DGVPRUDCOT.RowCount - 1
            IDP = DGVPRUDCOT.Rows(I).Cells(0).Value
            PRNO = DGVPRUDCOT.Rows(I).Cells(1).Value
            QTY = DGVPRUDCOT.Rows(I).Cells(5).Value
            PRI = DGVPRUDCOT.Rows(I).Cells(6).Value
            AMOU = DGVPRUDCOT.Rows(I).Cells(7).Value
            CMD.Parameters.Add(New SqlParameter("@INVIDD", SqlDbType.Int)).Value = IDP
            CMD.Parameters.Add(New SqlParameter("@PROID", SqlDbType.Int)).Value = PRNO
            CMD.Parameters.Add(New SqlParameter("@QUNT", SqlDbType.Int)).Value = QTY
            CMD.Parameters.Add(New SqlParameter("@PROPRICE", SqlDbType.Int)).Value = PRI
            CMD.Parameters.Add(New SqlParameter("@AMOUNT", SqlDbType.Int)).Value = AMOU
            CMD = New SqlCommand(STRSTRING1, CON)
            CMD.ExecuteNonQuery()

        Next
        MsgBox("تمت الاضافة ", MsgBoxStyle.Information, "نجاح")
        TXTACCNO.Clear()
        TXTACCNAME1.Clear()
        CON.Close()

        '" & " لكم مبيعات " & TEXTTYPE.Text & "GGGGGGGGGGGG" & TXTINVNO.Text & "'
    End Sub

    Private Sub COMTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMTYPE.SelectedIndexChanged
        If COMTYPE.Text = "نقد" Then
            TXTTYPE.Text = "مبيعات نقد"


        Else
            If COMTYPE.Text = "اجل" Then
                TXTTYPE.Text = "مبيعات اجل"

            Else
                If COMTYPE.Text = "كمبيالة" Then
                    TXTTYPE.Text = "مبيعات بكمبيالة"

                End If
            End If
        End If
    End Sub

    Private Sub COMCUSNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMCUSNAME.SelectedIndexChanged
        TextBox1.Text = " عليكم مبيعات " & TXTTYPE.Text & " بموجب فاتورة مبيعات رقم " & (TXTINVNO.Text)
        TextBox2.Text = " لكم مبيعات " & TXTTYPE.Text & " بموجب فاتورة مبيعات رقم " & (TXTINVNO.Text)
        TXTCUSNAME.Text = COMCUSNAME.Text
    End Sub
    Private Sub COMSTORS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMSTORS.SelectedIndexChanged
        TXTSTORS.Text = COMSTORS.Text
    End Sub

    Private Sub ACCQD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ACCQD.SelectedIndexChanged
        TXTACCQD.Text = ACCQD.Text
    End Sub

    Private Sub COMCURRNCY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMCURRNCY.SelectedIndexChanged
        TXTCURNCY.Text = COMCURRNCY.Text
    End Sub

    Private Sub COMACCCURRNCY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMACCCURRNCY.SelectedIndexChanged
        TXTACCCURRNCY.Text = COMACCCURRNCY.Text
    End Sub
    Private Sub COMACCNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMACCNAME.SelectedIndexChanged
        TXTACCNAME1.Text = COMACCNAME.Text
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class