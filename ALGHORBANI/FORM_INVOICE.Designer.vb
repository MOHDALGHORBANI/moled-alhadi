<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FORM_INVOICE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_INVOICE))
        Me.DGVPRUDCOT = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TXTNOTE = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTACCNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.COMTYPE = New System.Windows.Forms.ComboBox()
        Me.TXTDATE = New System.Windows.Forms.DateTimePicker()
        Me.COMCUSNAME = New System.Windows.Forms.ComboBox()
        Me.TXTINVNO = New System.Windows.Forms.TextBox()
        Me.TXTCUSNO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTPRONAME = New System.Windows.Forms.TextBox()
        Me.TXTIND = New System.Windows.Forms.TextBox()
        Me.TXTPRONO = New System.Windows.Forms.TextBox()
        Me.TXTPROUNIT = New System.Windows.Forms.TextBox()
        Me.TXTPROTYPE = New System.Windows.Forms.TextBox()
        Me.TXTQUNT = New System.Windows.Forms.TextBox()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.TXTAMOUNT = New System.Windows.Forms.TextBox()
        Me.TXTREF = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTQD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.COMCURRNCY = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TXTTYPE = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TXTDES = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.COMSTORS = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.COMACCCURRNCY = New System.Windows.Forms.ComboBox()
        Me.TXTTOTALACC = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ACCQD = New System.Windows.Forms.ComboBox()
        Me.TXTCUSNAME = New System.Windows.Forms.TextBox()
        Me.TXTCURNCY = New System.Windows.Forms.TextBox()
        Me.TXTACCCURRNCY = New System.Windows.Forms.TextBox()
        Me.TXTACCQD = New System.Windows.Forms.TextBox()
        Me.TXTACCNAME1 = New System.Windows.Forms.TextBox()
        Me.TXTSTORS = New System.Windows.Forms.TextBox()
        Me.COMACCNAME = New System.Windows.Forms.ComboBox()
        CType(Me.DGVPRUDCOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVPRUDCOT
        '
        Me.DGVPRUDCOT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVPRUDCOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPRUDCOT.Location = New System.Drawing.Point(-2, 357)
        Me.DGVPRUDCOT.Name = "DGVPRUDCOT"
        Me.DGVPRUDCOT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGVPRUDCOT.RowHeadersWidth = 51
        Me.DGVPRUDCOT.RowTemplate.Height = 26
        Me.DGVPRUDCOT.Size = New System.Drawing.Size(1926, 725)
        Me.DGVPRUDCOT.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2, Me.ToolStripLabel3, Me.ToolStripLabel4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(1534, 32)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Image = Global.ALGHORBANI.My.Resources.Resources.FB_IMG_1677811449838
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(75, 29)
        Me.ToolStripLabel1.Text = "إضافة"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Image = Global.ALGHORBANI.My.Resources.Resources.FB_IMG_1677811449838
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(70, 29)
        Me.ToolStripLabel2.Text = "تعديل"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Image = Global.ALGHORBANI.My.Resources.Resources.FB_IMG_1677811449838
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(68, 29)
        Me.ToolStripLabel3.Text = "بحـث"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel4.Image = Global.ALGHORBANI.My.Resources.Resources.FB_IMG_1677811449838
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(69, 29)
        Me.ToolStripLabel4.Text = "حذف"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Red
        Me.ToolStripButton1.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(97, 29)
        Me.ToolStripButton1.Text = "خــــروج"
        '
        'TXTNOTE
        '
        Me.TXTNOTE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOTE.Location = New System.Drawing.Point(884, 181)
        Me.TXTNOTE.Name = "TXTNOTE"
        Me.TXTNOTE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTNOTE.Size = New System.Drawing.Size(562, 30)
        Me.TXTNOTE.TabIndex = 92
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Snow
        Me.Label10.Location = New System.Drawing.Point(743, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(130, 30)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "ملاحظــــــــــات"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Snow
        Me.Label8.Location = New System.Drawing.Point(16, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(130, 30)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "الرقم"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(572, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(130, 30)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "النـــــوع"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(278, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(130, 30)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "اســـــم الحســـاب"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTACCNO
        '
        Me.TXTACCNO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTACCNO.Location = New System.Drawing.Point(150, 135)
        Me.TXTACCNO.Name = "TXTACCNO"
        Me.TXTACCNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTACCNO.Size = New System.Drawing.Size(120, 30)
        Me.TXTACCNO.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(14, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(130, 30)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "رقم الحسـاب"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'COMTYPE
        '
        Me.COMTYPE.FormattingEnabled = True
        Me.COMTYPE.Items.AddRange(New Object() {"نقد", "اجل", "كمبيالة"})
        Me.COMTYPE.Location = New System.Drawing.Point(708, 47)
        Me.COMTYPE.Name = "COMTYPE"
        Me.COMTYPE.Size = New System.Drawing.Size(165, 33)
        Me.COMTYPE.TabIndex = 86
        '
        'TXTDATE
        '
        Me.TXTDATE.CustomFormat = ""
        Me.TXTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TXTDATE.Location = New System.Drawing.Point(414, 46)
        Me.TXTDATE.Name = "TXTDATE"
        Me.TXTDATE.Size = New System.Drawing.Size(152, 34)
        Me.TXTDATE.TabIndex = 83
        '
        'COMCUSNAME
        '
        Me.COMCUSNAME.FormattingEnabled = True
        Me.COMCUSNAME.Items.AddRange(New Object() {"الميزانية العمومية", "الارباح والخسارة", "المتاجرة"})
        Me.COMCUSNAME.Location = New System.Drawing.Point(414, 93)
        Me.COMCUSNAME.Name = "COMCUSNAME"
        Me.COMCUSNAME.Size = New System.Drawing.Size(459, 33)
        Me.COMCUSNAME.TabIndex = 84
        '
        'TXTINVNO
        '
        Me.TXTINVNO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTINVNO.Location = New System.Drawing.Point(152, 45)
        Me.TXTINVNO.Name = "TXTINVNO"
        Me.TXTINVNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTINVNO.Size = New System.Drawing.Size(118, 30)
        Me.TXTINVNO.TabIndex = 82
        '
        'TXTCUSNO
        '
        Me.TXTCUSNO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCUSNO.Location = New System.Drawing.Point(150, 92)
        Me.TXTCUSNO.Name = "TXTCUSNO"
        Me.TXTCUSNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTCUSNO.Size = New System.Drawing.Size(120, 30)
        Me.TXTCUSNO.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(16, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(130, 30)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "رقم العميل"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(278, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(130, 30)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "التاريخ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Snow
        Me.Label11.Location = New System.Drawing.Point(278, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(130, 30)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "اسم العميل"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.Enabled = False
        Me.TXTTOTAL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(1284, 93)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTTOTAL.Size = New System.Drawing.Size(162, 30)
        Me.TXTTOTAL.TabIndex = 95
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(1148, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(130, 30)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "الاجمــــــالي"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTPRONAME
        '
        Me.TXTPRONAME.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRONAME.Location = New System.Drawing.Point(214, 265)
        Me.TXTPRONAME.Name = "TXTPRONAME"
        Me.TXTPRONAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTPRONAME.Size = New System.Drawing.Size(370, 30)
        Me.TXTPRONAME.TabIndex = 96
        '
        'TXTIND
        '
        Me.TXTIND.Enabled = False
        Me.TXTIND.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTIND.Location = New System.Drawing.Point(13, 265)
        Me.TXTIND.Name = "TXTIND"
        Me.TXTIND.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTIND.Size = New System.Drawing.Size(83, 30)
        Me.TXTIND.TabIndex = 98
        '
        'TXTPRONO
        '
        Me.TXTPRONO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRONO.Location = New System.Drawing.Point(95, 265)
        Me.TXTPRONO.Name = "TXTPRONO"
        Me.TXTPRONO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTPRONO.Size = New System.Drawing.Size(120, 30)
        Me.TXTPRONO.TabIndex = 97
        '
        'TXTPROUNIT
        '
        Me.TXTPROUNIT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPROUNIT.Location = New System.Drawing.Point(583, 265)
        Me.TXTPROUNIT.Name = "TXTPROUNIT"
        Me.TXTPROUNIT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTPROUNIT.Size = New System.Drawing.Size(177, 30)
        Me.TXTPROUNIT.TabIndex = 99
        '
        'TXTPROTYPE
        '
        Me.TXTPROTYPE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPROTYPE.Location = New System.Drawing.Point(759, 265)
        Me.TXTPROTYPE.Name = "TXTPROTYPE"
        Me.TXTPROTYPE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTPROTYPE.Size = New System.Drawing.Size(177, 30)
        Me.TXTPROTYPE.TabIndex = 100
        '
        'TXTQUNT
        '
        Me.TXTQUNT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTQUNT.Location = New System.Drawing.Point(935, 265)
        Me.TXTQUNT.Name = "TXTQUNT"
        Me.TXTQUNT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTQUNT.Size = New System.Drawing.Size(155, 30)
        Me.TXTQUNT.TabIndex = 101
        '
        'TXTPRICE
        '
        Me.TXTPRICE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRICE.Location = New System.Drawing.Point(1089, 265)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTPRICE.Size = New System.Drawing.Size(177, 30)
        Me.TXTPRICE.TabIndex = 102
        '
        'TXTAMOUNT
        '
        Me.TXTAMOUNT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAMOUNT.Location = New System.Drawing.Point(1264, 265)
        Me.TXTAMOUNT.Name = "TXTAMOUNT"
        Me.TXTAMOUNT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTAMOUNT.Size = New System.Drawing.Size(182, 30)
        Me.TXTAMOUNT.TabIndex = 103
        '
        'TXTREF
        '
        Me.TXTREF.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTREF.Location = New System.Drawing.Point(1022, 47)
        Me.TXTREF.Name = "TXTREF"
        Me.TXTREF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTREF.Size = New System.Drawing.Size(120, 30)
        Me.TXTREF.TabIndex = 105
        Me.TXTREF.Text = "0"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(886, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(130, 30)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "رقم المرجع"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTQD
        '
        Me.TXTQD.Enabled = False
        Me.TXTQD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTQD.Location = New System.Drawing.Point(1284, 47)
        Me.TXTQD.Name = "TXTQD"
        Me.TXTQD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTQD.Size = New System.Drawing.Size(162, 30)
        Me.TXTQD.TabIndex = 107
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Snow
        Me.Label9.Location = New System.Drawing.Point(1148, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(130, 30)
        Me.Label9.TabIndex = 106
        Me.Label9.Text = "رقم القيد"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Snow
        Me.Label12.Location = New System.Drawing.Point(886, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(130, 30)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "العملة"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'COMCURRNCY
        '
        Me.COMCURRNCY.FormattingEnabled = True
        Me.COMCURRNCY.Items.AddRange(New Object() {"ريال يمني", "ريال سعودي", "دولار امريكي"})
        Me.COMCURRNCY.Location = New System.Drawing.Point(1022, 90)
        Me.COMCURRNCY.Name = "COMCURRNCY"
        Me.COMCURRNCY.Size = New System.Drawing.Size(120, 33)
        Me.COMCURRNCY.TabIndex = 108
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1488, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 26
        Me.DataGridView1.Size = New System.Drawing.Size(46, 36)
        Me.DataGridView1.TabIndex = 110
        Me.DataGridView1.Visible = False
        '
        'TXTTYPE
        '
        Me.TXTTYPE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTYPE.Location = New System.Drawing.Point(1472, 46)
        Me.TXTTYPE.Name = "TXTTYPE"
        Me.TXTTYPE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTTYPE.Size = New System.Drawing.Size(10, 30)
        Me.TXTTYPE.TabIndex = 111
        Me.TXTTYPE.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1472, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(10, 30)
        Me.TextBox1.TabIndex = 112
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1472, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox2.Size = New System.Drawing.Size(10, 30)
        Me.TextBox2.TabIndex = 113
        Me.TextBox2.Visible = False
        '
        'TXTDES
        '
        Me.TXTDES.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDES.Location = New System.Drawing.Point(1472, 45)
        Me.TXTDES.Name = "TXTDES"
        Me.TXTDES.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTDES.Size = New System.Drawing.Size(10, 30)
        Me.TXTDES.TabIndex = 114
        Me.TXTDES.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Snow
        Me.Label13.Location = New System.Drawing.Point(14, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(130, 30)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "المخزن"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'COMSTORS
        '
        Me.COMSTORS.FormattingEnabled = True
        Me.COMSTORS.Items.AddRange(New Object() {"ريال يمني", "ريال سعودي", "دولار امريكي"})
        Me.COMSTORS.Location = New System.Drawing.Point(150, 176)
        Me.COMSTORS.Name = "COMSTORS"
        Me.COMSTORS.Size = New System.Drawing.Size(120, 33)
        Me.COMSTORS.TabIndex = 115
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Snow
        Me.Label14.Location = New System.Drawing.Point(886, 137)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label14.Size = New System.Drawing.Size(130, 30)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = " عملة الحساب"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'COMACCCURRNCY
        '
        Me.COMACCCURRNCY.FormattingEnabled = True
        Me.COMACCCURRNCY.Items.AddRange(New Object() {"ريال يمني", "ريال سعودي", "دولار امريكي"})
        Me.COMACCCURRNCY.Location = New System.Drawing.Point(1022, 134)
        Me.COMACCCURRNCY.Name = "COMACCCURRNCY"
        Me.COMACCCURRNCY.Size = New System.Drawing.Size(120, 33)
        Me.COMACCCURRNCY.TabIndex = 117
        '
        'TXTTOTALACC
        '
        Me.TXTTOTALACC.Enabled = False
        Me.TXTTOTALACC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTALACC.Location = New System.Drawing.Point(1284, 135)
        Me.TXTTOTALACC.Name = "TXTTOTALACC"
        Me.TXTTOTALACC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTTOTALACC.Size = New System.Drawing.Size(162, 30)
        Me.TXTTOTALACC.TabIndex = 120
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Snow
        Me.Label15.Location = New System.Drawing.Point(1148, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label15.Size = New System.Drawing.Size(130, 30)
        Me.Label15.TabIndex = 119
        Me.Label15.Text = "اجمـالي الحساب"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Snow
        Me.Label16.Location = New System.Drawing.Point(278, 179)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(130, 30)
        Me.Label16.TabIndex = 122
        Me.Label16.Text = "قيد الحساب"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ACCQD
        '
        Me.ACCQD.FormattingEnabled = True
        Me.ACCQD.Items.AddRange(New Object() {"المخزن", "العميل"})
        Me.ACCQD.Location = New System.Drawing.Point(414, 179)
        Me.ACCQD.Name = "ACCQD"
        Me.ACCQD.Size = New System.Drawing.Size(269, 33)
        Me.ACCQD.TabIndex = 121
        '
        'TXTCUSNAME
        '
        Me.TXTCUSNAME.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCUSNAME.Location = New System.Drawing.Point(1472, 45)
        Me.TXTCUSNAME.Name = "TXTCUSNAME"
        Me.TXTCUSNAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTCUSNAME.Size = New System.Drawing.Size(10, 30)
        Me.TXTCUSNAME.TabIndex = 123
        Me.TXTCUSNAME.Visible = False
        '
        'TXTCURNCY
        '
        Me.TXTCURNCY.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCURNCY.Location = New System.Drawing.Point(1472, 45)
        Me.TXTCURNCY.Name = "TXTCURNCY"
        Me.TXTCURNCY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTCURNCY.Size = New System.Drawing.Size(10, 30)
        Me.TXTCURNCY.TabIndex = 124
        Me.TXTCURNCY.Visible = False
        '
        'TXTACCCURRNCY
        '
        Me.TXTACCCURRNCY.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTACCCURRNCY.Location = New System.Drawing.Point(1472, 45)
        Me.TXTACCCURRNCY.Name = "TXTACCCURRNCY"
        Me.TXTACCCURRNCY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTACCCURRNCY.Size = New System.Drawing.Size(10, 30)
        Me.TXTACCCURRNCY.TabIndex = 125
        Me.TXTACCCURRNCY.Visible = False
        '
        'TXTACCQD
        '
        Me.TXTACCQD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTACCQD.Location = New System.Drawing.Point(1472, 46)
        Me.TXTACCQD.Name = "TXTACCQD"
        Me.TXTACCQD.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTACCQD.Size = New System.Drawing.Size(10, 30)
        Me.TXTACCQD.TabIndex = 126
        Me.TXTACCQD.Visible = False
        '
        'TXTACCNAME1
        '
        Me.TXTACCNAME1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTACCNAME1.Location = New System.Drawing.Point(1472, 45)
        Me.TXTACCNAME1.Name = "TXTACCNAME1"
        Me.TXTACCNAME1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTACCNAME1.Size = New System.Drawing.Size(10, 30)
        Me.TXTACCNAME1.TabIndex = 127
        Me.TXTACCNAME1.Visible = False
        '
        'TXTSTORS
        '
        Me.TXTSTORS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSTORS.Location = New System.Drawing.Point(1472, 45)
        Me.TXTSTORS.Name = "TXTSTORS"
        Me.TXTSTORS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXTSTORS.Size = New System.Drawing.Size(10, 30)
        Me.TXTSTORS.TabIndex = 128
        Me.TXTSTORS.Visible = False
        '
        'COMACCNAME
        '
        Me.COMACCNAME.FormattingEnabled = True
        Me.COMACCNAME.Items.AddRange(New Object() {"الميزانية العمومية", "الارباح والخسارة", "المتاجرة"})
        Me.COMACCNAME.Location = New System.Drawing.Point(414, 135)
        Me.COMACCNAME.Name = "COMACCNAME"
        Me.COMACCNAME.Size = New System.Drawing.Size(459, 33)
        Me.COMACCNAME.TabIndex = 129
        '
        'FORM_INVOICE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1534, 723)
        Me.ControlBox = False
        Me.Controls.Add(Me.COMACCNAME)
        Me.Controls.Add(Me.TXTSTORS)
        Me.Controls.Add(Me.TXTACCNAME1)
        Me.Controls.Add(Me.TXTACCQD)
        Me.Controls.Add(Me.TXTACCCURRNCY)
        Me.Controls.Add(Me.TXTCURNCY)
        Me.Controls.Add(Me.TXTCUSNAME)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ACCQD)
        Me.Controls.Add(Me.TXTTOTALACC)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.COMACCCURRNCY)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.COMSTORS)
        Me.Controls.Add(Me.TXTDES)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TXTTYPE)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.COMCURRNCY)
        Me.Controls.Add(Me.TXTQD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTREF)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTAMOUNT)
        Me.Controls.Add(Me.TXTPRICE)
        Me.Controls.Add(Me.TXTQUNT)
        Me.Controls.Add(Me.TXTPROTYPE)
        Me.Controls.Add(Me.TXTPROUNIT)
        Me.Controls.Add(Me.TXTPRONAME)
        Me.Controls.Add(Me.TXTIND)
        Me.Controls.Add(Me.TXTPRONO)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXTNOTE)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTACCNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.COMTYPE)
        Me.Controls.Add(Me.TXTDATE)
        Me.Controls.Add(Me.COMCUSNAME)
        Me.Controls.Add(Me.TXTINVNO)
        Me.Controls.Add(Me.TXTCUSNO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DGVPRUDCOT)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FORM_INVOICE"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "فاتورة_مبيعـــــات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVPRUDCOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVPRUDCOT As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TXTNOTE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTACCNO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents COMTYPE As ComboBox
    Friend WithEvents TXTDATE As DateTimePicker
    Friend WithEvents COMCUSNAME As ComboBox
    Friend WithEvents TXTINVNO As TextBox
    Friend WithEvents TXTCUSNO As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTTOTAL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTPRONAME As TextBox
    Friend WithEvents TXTIND As TextBox
    Friend WithEvents TXTPRONO As TextBox
    Friend WithEvents TXTPROUNIT As TextBox
    Friend WithEvents TXTPROTYPE As TextBox
    Friend WithEvents TXTQUNT As TextBox
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents TXTAMOUNT As TextBox
    Friend WithEvents TXTREF As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTQD As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents COMCURRNCY As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXTTYPE As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TXTDES As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents COMSTORS As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents COMACCCURRNCY As ComboBox
    Friend WithEvents TXTTOTALACC As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ACCQD As ComboBox
    Friend WithEvents TXTCUSNAME As TextBox
    Friend WithEvents TXTCURNCY As TextBox
    Friend WithEvents TXTACCCURRNCY As TextBox
    Friend WithEvents TXTACCQD As TextBox
    Friend WithEvents TXTACCNAME1 As TextBox
    Friend WithEvents TXTSTORS As TextBox
    Friend WithEvents COMACCNAME As ComboBox
End Class
