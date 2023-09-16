<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_ACCSEARCH
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
        Me.DGVALL = New System.Windows.Forms.DataGridView()
        CType(Me.DGVALL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVALL
        '
        Me.DGVALL.AllowUserToAddRows = False
        Me.DGVALL.AllowUserToDeleteRows = False
        Me.DGVALL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVALL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVALL.Location = New System.Drawing.Point(2, 93)
        Me.DGVALL.Name = "DGVALL"
        Me.DGVALL.ReadOnly = True
        Me.DGVALL.RowHeadersWidth = 51
        Me.DGVALL.RowTemplate.Height = 26
        Me.DGVALL.Size = New System.Drawing.Size(432, 356)
        Me.DGVALL.TabIndex = 0
        '
        'FORM_ACCSEARCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.DGVALL)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FORM_ACCSEARCH"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "البحث عن خســـــاب"
        CType(Me.DGVALL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVALL As DataGridView
End Class
