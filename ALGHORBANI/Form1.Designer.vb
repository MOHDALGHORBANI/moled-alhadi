<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BUTCLOSE = New System.Windows.Forms.Button()
        Me.BUTLOGIN = New System.Windows.Forms.Button()
        Me.TXTPASS = New System.Windows.Forms.TextBox()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(269, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 27)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "اسم المستخدم"
        Me.Label7.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(269, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 27)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "الرقـم السري"
        Me.Label4.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(65, 8)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(267, 39)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "شـــــاشـــــة الدخـــــول"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.UseWaitCursor = True
        '
        'BUTCLOSE
        '
        Me.BUTCLOSE.BackColor = System.Drawing.Color.Red
        Me.BUTCLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BUTCLOSE.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BUTCLOSE.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUTCLOSE.ForeColor = System.Drawing.Color.Transparent
        Me.BUTCLOSE.Location = New System.Drawing.Point(50, 156)
        Me.BUTCLOSE.Name = "BUTCLOSE"
        Me.BUTCLOSE.Size = New System.Drawing.Size(74, 33)
        Me.BUTCLOSE.TabIndex = 11
        Me.BUTCLOSE.Text = "إغــلاق"
        Me.BUTCLOSE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BUTCLOSE.UseVisualStyleBackColor = False
        '
        'BUTLOGIN
        '
        Me.BUTLOGIN.BackColor = System.Drawing.Color.DarkGray
        Me.BUTLOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BUTLOGIN.Font = New System.Drawing.Font("Times New Roman", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUTLOGIN.Location = New System.Drawing.Point(192, 156)
        Me.BUTLOGIN.Name = "BUTLOGIN"
        Me.BUTLOGIN.Size = New System.Drawing.Size(74, 33)
        Me.BUTLOGIN.TabIndex = 10
        Me.BUTLOGIN.Text = "الدخول"
        Me.BUTLOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BUTLOGIN.UseVisualStyleBackColor = False
        '
        'TXTPASS
        '
        Me.TXTPASS.Location = New System.Drawing.Point(50, 114)
        Me.TXTPASS.Name = "TXTPASS"
        Me.TXTPASS.Size = New System.Drawing.Size(216, 24)
        Me.TXTPASS.TabIndex = 9
        '
        'TXTNAME
        '
        Me.TXTNAME.Location = New System.Drawing.Point(50, 76)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(216, 24)
        Me.TXTNAME.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BUTLOGIN)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TXTPASS)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BUTCLOSE)
        Me.Panel1.Controls.Add(Me.TXTNAME)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 214)
        Me.Panel1.TabIndex = 15
        '
        'Form1
        '
        Me.AcceptButton = Me.BUTLOGIN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BUTCLOSE
        Me.ClientSize = New System.Drawing.Size(398, 219)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "شاشة دخول المستخدمين"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BUTCLOSE As Button
    Friend WithEvents BUTLOGIN As Button
    Friend WithEvents TXTPASS As TextBox
    Friend WithEvents TXTNAME As TextBox
    Friend WithEvents Panel1 As Panel
End Class
