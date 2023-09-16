Public Class FORM_MAIN

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub دليلالحساباتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles دليلالحساباتToolStripMenuItem.Click
        Dim FRM As New ACCOUNTS_FORM
        ACCOUNTS_FORM.MdiParent = Me
        FRM.Show()

    End Sub

    Private Sub دليلالمستخدمينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles دليلالمستخدمينToolStripMenuItem.Click
        Dim FRM As New FORM_ADD_USER
        FORM_ADD_USER.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub فاتورةمبيعاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles فاتورةمبيعاتToolStripMenuItem.Click
        Dim FRM As New FORM_INVOICE
        FORM_INVOICE.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub إضافةصنفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles إضافةصنفToolStripMenuItem.Click
        Dim FRM As New FORM_ADD_PRODUCT
        FORM_ADD_PRODUCT.MdiParent = Me
        FRM.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim FRM As New FORM_SND_CASH
        FORM_SND_CASH.MdiParent = Me
        FRM.Show()
    End Sub
End Class