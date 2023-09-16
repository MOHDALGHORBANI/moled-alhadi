<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_ALL_ACCOUNT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGVALLACC = New System.Windows.Forms.DataGridView()
        CType(Me.DGVALLACC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVALLACC
        '
        Me.DGVALLACC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVALLACC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVALLACC.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVALLACC.Location = New System.Drawing.Point(0, 48)
        Me.DGVALLACC.Name = "DGVALLACC"
        Me.DGVALLACC.RowHeadersWidth = 51
        Me.DGVALLACC.RowTemplate.Height = 26
        Me.DGVALLACC.Size = New System.Drawing.Size(426, 432)
        Me.DGVALLACC.TabIndex = 0
        '
        'FORM_ALL_ACCOUNT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 480)
        Me.Controls.Add(Me.DGVALLACC)
        Me.Name = "FORM_ALL_ACCOUNT"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شاشة البحث"
        CType(Me.DGVALLACC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVALLACC As DataGridView
End Class
