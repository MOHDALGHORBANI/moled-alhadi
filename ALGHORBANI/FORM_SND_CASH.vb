Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FORM_SND_CASH
    Public CON As New SqlConnection("Data Source=.; Initial Catalog=ALWLAIH; Integrated Security=True")
    Private Sub FORM_SND_CASH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SD()
        QAID_NU()
    End Sub
    Sub SD()
        Dim ADPT As SqlDataAdapter
        Dim USERNA As New DataTable
        ADPT = New SqlDataAdapter("select * from SNDCASH_TABLE", CON)
        ADPT.Fill(USERNA)
        Me.DGVSND.DataSource = USERNA
        TXTSNDNO.Text = "00000" & DGVSND.Rows.Count + 1

    End Sub
    Sub QAID_NU()
        Dim ADPT As SqlDataAdapter
        Dim USERNA As New DataTable
        ADPT = New SqlDataAdapter("select * from QAID", CON)
        ADPT.Fill(USERNA)
        Me.DGVQD.DataSource = USERNA
        TXTQD.Text = DGVQD.Rows.Count / 2 + 1
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Close()
    End Sub

    Private Sub COMBANKNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBANKNAME.SelectedIndexChanged
        TXTBANKNAME.Text = COMBANKNAME.Text
    End Sub

    Private Sub COMTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMTYPE.SelectedIndexChanged
        TXTTYPE.Text = COMTYPE.Text
        If TXTTYPE.Text = "شيك" Then
            Label5.Enabled = True
            Label13.Enabled = True
            Label14.Enabled = True
            Label15.Enabled = True
            TXTSHEKNO.Enabled = True
            TXTTDATESHEK.Enabled = True
            TXTBANKNO.Enabled = True
            COMBANKNAME.Enabled = True
        Else
            Label5.Enabled = False
            Label13.Enabled = False
            Label14.Enabled = False
            Label15.Enabled = False
            TXTSHEKNO.Enabled = False
            TXTTDATESHEK.Enabled = False
            TXTBANKNO.Enabled = False
            COMBANKNAME.Enabled = False
        End If

    End Sub

    Private Sub COMCUSNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMCUSNAME.SelectedIndexChanged
        TXTCUSNAME.Text = COMCUSNAME.Text
        TXTMD.Text = " لكم دفعة من الحساب " & TXTTYPE.Text & " بموجب سند قبض رقم " & (TXTSNDNO.Text)
        TXTDA.Text = " عليكم دفعة من حساب " & TXTCUSNAME.Text & "" & TXTTYPE.Text & " بموجب سند قبض رقم " & (TXTSNDNO.Text)
    End Sub

    Private Sub COMACCNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMACCNAME.SelectedIndexChanged
        TXTACCNAME.Text = COMACCNAME.Text
    End Sub

    Private Sub COMCURRNCY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMCURRNCY.SelectedIndexChanged
        TXTCURRNCY.Text = COMCURRNCY.Text
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Try
            CON.Open()
            Dim CMD As New SqlCommand
            Dim STRSTRING1 As String = "INSERT INTO SNDCASH_TABLE (SNDID, SNDDATE, SNDTYPE, SNDREF, SNDQD, SNDCUSNO, SNDCUSNAME, SNDBOXNO, SNDBOXNAME, SNDCURRNCY, SNDAMUNT, SNDNOTE, SNDSHEKNO, SNDSHEKDATE, SNDSHEKBANK, SNDACCNO, SNDACCNAME, SNDBANKNO) VALUES(" & TXTSNDNO.Text & ", '" & TXTDATE.MinDate & "', '" & TXTTYPE.Text & "', '" & TXTREF.Text & "', '" & TXTQD.Text & "', '" & TXTCUSNO.Text & "', '" & TXTCUSNAME.Text & "', '" & TXTBOXNO.Text & "', '" & TXTBOXNAME.Text & "', '" & TXTCURRNCY.Text & "', '" & TXTTOTAL.Text & "', '" & TXTSHEKNO.Text & "', '" & TXTTDATESHEK.Text & "', '" & TXTBANKNAME.Text & "', '" & TXTNOTE.Text & "', '" & TXTACCNO.Text & "', '" & TXTACCNAME.Text & "', '" & TXTBANKNO.Text & "')"
            CMD.CommandText = STRSTRING1
            CMD.Connection = CON
            CMD.ExecuteNonQuery()
            STRSTRING1 = "INSERT INTO QAID (QD, TYPEDOC, MD, DA, DES, ACCOUNT, DATE_) VALUES(" & TXTQD.Text & ", '" & TXTDOCNAME.Text & "', '" & TXTTOTAL.Text & "', '" & "0" & "', '" & TXTMD.Text & "', '" & TXTACCNAME.Text & "', '" & TXTDATE.MinDate & "')"
            CMD.CommandText = STRSTRING1
            CMD.Connection = CON
            CMD.ExecuteNonQuery()
            STRSTRING1 = "INSERT INTO QAID (QD, TYPEDOC, MD, DA, DES, ACCOUNT,DATE_) VALUES(" & TXTQD.Text & ", '" & TXTDOCNAME.Text & "', '" & "0" & "', '" & TXTTOTAL.Text & "', '" & TXTDA.Text & "', '" & TXTCUSNAME.Text & "', '" & TXTDATE.MinDate & "')"
            CMD.CommandText = STRSTRING1
            CMD.Connection = CON
            CMD.ExecuteNonQuery()

            MsgBox("تمت الاضافة ", MsgBoxStyle.Information, "نجاح")


        Catch ex As Exception
            MsgBox("FAIL ", MsgBoxStyle.Information, "WRONG")
            Exit Sub
        Finally
            CON.Close()
        End Try


    End Sub

    Private Sub COMBOXNAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMBOXNAME.SelectedIndexChanged
        TXTBOXNAME.Text = COMBOXNAME.Text
    End Sub
End Class