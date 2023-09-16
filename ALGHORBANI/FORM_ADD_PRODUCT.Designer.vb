<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_ADD_PRODUCT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_ADD_PRODUCT))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.DGVPRODUCT = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTID = New System.Windows.Forms.TextBox()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTDATE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTCOUNT = New System.Windows.Forms.TextBox()
        Me.TXTLEN = New System.Windows.Forms.TextBox()
        Me.COMUNIT = New System.Windows.Forms.ComboBox()
        Me.COMTYPE = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGVPRODUCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1472, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Black
        Me.ToolStripButton1.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(111, 29)
        Me.ToolStripButton1.Text = "إضـــــافـــة"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(102, 29)
        Me.ToolStripButton2.Text = "إغــــــلاق"
        '
        'DGVPRODUCT
        '
        Me.DGVPRODUCT.AllowUserToAddRows = False
        Me.DGVPRODUCT.AllowUserToDeleteRows = False
        Me.DGVPRODUCT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVPRODUCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVPRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPRODUCT.Location = New System.Drawing.Point(0, 346)
        Me.DGVPRODUCT.Name = "DGVPRODUCT"
        Me.DGVPRODUCT.ReadOnly = True
        Me.DGVPRODUCT.RowHeadersWidth = 51
        Me.DGVPRODUCT.RowTemplate.Height = 26
        Me.DGVPRODUCT.Size = New System.Drawing.Size(1490, 770)
        Me.DGVPRODUCT.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(33, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "رقم الصنف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(33, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "اسم الصنف"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(421, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "نوع  الصنف"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(421, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "وحدة الصنف"
        '
        'TXTID
        '
        Me.TXTID.Location = New System.Drawing.Point(122, 54)
        Me.TXTID.Name = "TXTID"
        Me.TXTID.Size = New System.Drawing.Size(290, 30)
        Me.TXTID.TabIndex = 6
        '
        'TXTNAME
        '
        Me.TXTNAME.Location = New System.Drawing.Point(121, 102)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(290, 30)
        Me.TXTNAME.TabIndex = 7
        '
        'TXTPRICE
        '
        Me.TXTPRICE.Location = New System.Drawing.Point(918, 102)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.Size = New System.Drawing.Size(242, 30)
        Me.TXTPRICE.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(819, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "سعر  الصنف"
        '
        'TXTDATE
        '
        Me.TXTDATE.Location = New System.Drawing.Point(917, 54)
        Me.TXTDATE.Name = "TXTDATE"
        Me.TXTDATE.Size = New System.Drawing.Size(243, 30)
        Me.TXTDATE.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(836, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "التــاريـــخ"
        '
        'TXTCOUNT
        '
        Me.TXTCOUNT.Location = New System.Drawing.Point(1177, 54)
        Me.TXTCOUNT.Name = "TXTCOUNT"
        Me.TXTCOUNT.Size = New System.Drawing.Size(73, 30)
        Me.TXTCOUNT.TabIndex = 14
        '
        'TXTLEN
        '
        Me.TXTLEN.Location = New System.Drawing.Point(1177, 98)
        Me.TXTLEN.Name = "TXTLEN"
        Me.TXTLEN.Size = New System.Drawing.Size(73, 30)
        Me.TXTLEN.TabIndex = 15
        '
        'COMUNIT
        '
        Me.COMUNIT.FormattingEnabled = True
        Me.COMUNIT.Items.AddRange(New Object() {"حبة", "علبة", "درزن"})
        Me.COMUNIT.Location = New System.Drawing.Point(520, 54)
        Me.COMUNIT.Name = "COMUNIT"
        Me.COMUNIT.Size = New System.Drawing.Size(290, 31)
        Me.COMUNIT.TabIndex = 16
        '
        'COMTYPE
        '
        Me.COMTYPE.FormattingEnabled = True
        Me.COMTYPE.Items.AddRange(New Object() {"معجنات", "مخبزات", "كعك", "سندوتشات", "عصائر", "مشروبات"})
        Me.COMTYPE.Location = New System.Drawing.Point(520, 102)
        Me.COMTYPE.Name = "COMTYPE"
        Me.COMTYPE.Size = New System.Drawing.Size(290, 31)
        Me.COMTYPE.TabIndex = 17
        '
        'FORM_ADD_PRODUCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 723)
        Me.ControlBox = False
        Me.Controls.Add(Me.COMTYPE)
        Me.Controls.Add(Me.COMUNIT)
        Me.Controls.Add(Me.TXTLEN)
        Me.Controls.Add(Me.TXTCOUNT)
        Me.Controls.Add(Me.TXTDATE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTPRICE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTNAME)
        Me.Controls.Add(Me.TXTID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVPRODUCT)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FORM_ADD_PRODUCT"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شاشـــــة إدخال الاصنــــــاف"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGVPRODUCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents DGVPRODUCT As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTID As TextBox
    Friend WithEvents TXTNAME As TextBox
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTDATE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTCOUNT As TextBox
    Friend WithEvents TXTLEN As TextBox
    Friend WithEvents COMUNIT As ComboBox
    Friend WithEvents COMTYPE As ComboBox
End Class
