<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.bltadd = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.txtscore = New System.Windows.Forms.TextBox()
        Me.lbID = New System.Windows.Forms.Label()
        Me.lbname = New System.Windows.Forms.Label()
        Me.lbgender = New System.Windows.Forms.Label()
        Me.lbscore = New System.Windows.Forms.Label()
        Me.clb_name = New System.Windows.Forms.CheckedListBox()
        Me.btn_delet = New System.Windows.Forms.Button()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.lv_Students = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'bltadd
        '
        Me.bltadd.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bltadd.Location = New System.Drawing.Point(92, 232)
        Me.bltadd.Name = "bltadd"
        Me.bltadd.Size = New System.Drawing.Size(78, 27)
        Me.bltadd.TabIndex = 0
        Me.bltadd.Text = "បន្ថែម"
        Me.bltadd.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(92, 51)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(142, 30)
        Me.txtid.TabIndex = 1
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(92, 99)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(142, 30)
        Me.txtname.TabIndex = 2
        '
        'txtgender
        '
        Me.txtgender.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.Location = New System.Drawing.Point(92, 148)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(142, 30)
        Me.txtgender.TabIndex = 3
        '
        'txtscore
        '
        Me.txtscore.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtscore.Location = New System.Drawing.Point(92, 194)
        Me.txtscore.Name = "txtscore"
        Me.txtscore.Size = New System.Drawing.Size(142, 30)
        Me.txtscore.TabIndex = 4
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(26, 49)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(54, 22)
        Me.lbID.TabIndex = 5
        Me.lbID.Text = "លេខរៀង"
        '
        'lbname
        '
        Me.lbname.AutoSize = True
        Me.lbname.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbname.Location = New System.Drawing.Point(49, 97)
        Me.lbname.Name = "lbname"
        Me.lbname.Size = New System.Drawing.Size(41, 22)
        Me.lbname.TabIndex = 6
        Me.lbname.Text = "ឈ្មោះ"
        '
        'lbgender
        '
        Me.lbgender.AutoSize = True
        Me.lbgender.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgender.Location = New System.Drawing.Point(52, 146)
        Me.lbgender.Name = "lbgender"
        Me.lbgender.Size = New System.Drawing.Size(30, 22)
        Me.lbgender.TabIndex = 7
        Me.lbgender.Text = "ភេទ"
        '
        'lbscore
        '
        Me.lbscore.AutoSize = True
        Me.lbscore.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbscore.Location = New System.Drawing.Point(57, 188)
        Me.lbscore.Name = "lbscore"
        Me.lbscore.Size = New System.Drawing.Size(26, 22)
        Me.lbscore.TabIndex = 8
        Me.lbscore.Text = "ពិន្ទុ"
        '
        'clb_name
        '
        Me.clb_name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clb_name.CheckOnClick = True
        Me.clb_name.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clb_name.FormattingEnabled = True
        Me.clb_name.Location = New System.Drawing.Point(255, 51)
        Me.clb_name.Name = "clb_name"
        Me.clb_name.Size = New System.Drawing.Size(350, 179)
        Me.clb_name.TabIndex = 9
        '
        'btn_delet
        '
        Me.btn_delet.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delet.Location = New System.Drawing.Point(176, 232)
        Me.btn_delet.Name = "btn_delet"
        Me.btn_delet.Size = New System.Drawing.Size(58, 27)
        Me.btn_delet.TabIndex = 11
        Me.btn_delet.Text = "លុប"
        Me.btn_delet.UseVisualStyleBackColor = True
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(255, 25)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(350, 20)
        Me.txtCount.TabIndex = 12
        '
        'lv_Students
        '
        Me.lv_Students.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_Students.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_Students.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Students.FullRowSelect = True
        Me.lv_Students.GridLines = True
        Me.lv_Students.Location = New System.Drawing.Point(256, 236)
        Me.lv_Students.Name = "lv_Students"
        Me.lv_Students.Size = New System.Drawing.Size(349, 154)
        Me.lv_Students.TabIndex = 13
        Me.lv_Students.UseCompatibleStateImageBehavior = False
        Me.lv_Students.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ល.រ"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ឈ្មោះ"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ភេទ"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "ពិន្ទុ"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 402)
        Me.Controls.Add(Me.lv_Students)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.btn_delet)
        Me.Controls.Add(Me.clb_name)
        Me.Controls.Add(Me.lbscore)
        Me.Controls.Add(Me.lbgender)
        Me.Controls.Add(Me.lbname)
        Me.Controls.Add(Me.lbID)
        Me.Controls.Add(Me.txtscore)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.bltadd)
        Me.Name = "Form2"
        Me.Text = "Home Work Lesson  001"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bltadd As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents txtscore As System.Windows.Forms.TextBox
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents lbname As System.Windows.Forms.Label
    Friend WithEvents lbgender As System.Windows.Forms.Label
    Friend WithEvents lbscore As System.Windows.Forms.Label
    Friend WithEvents clb_name As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_delet As System.Windows.Forms.Button
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents lv_Students As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
