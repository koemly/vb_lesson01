<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lb_id = New System.Windows.Forms.Label()
        Me.lb_name = New System.Windows.Forms.Label()
        Me.lb_gender = New System.Windows.Forms.Label()
        Me.lb_score = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_gender = New System.Windows.Forms.TextBox()
        Me.txt_score = New System.Windows.Forms.TextBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_delet = New System.Windows.Forms.Button()
        Me.lv_name = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btn_edite = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.Font = New System.Drawing.Font("Khmer OS Bokor", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_id.Location = New System.Drawing.Point(12, 57)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(30, 27)
        Me.lb_id.TabIndex = 0
        Me.lb_id.Text = "ល.រ"
        '
        'lb_name
        '
        Me.lb_name.AutoSize = True
        Me.lb_name.Font = New System.Drawing.Font("Khmer OS Bokor", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_name.Location = New System.Drawing.Point(2, 105)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.Size = New System.Drawing.Size(40, 27)
        Me.lb_name.TabIndex = 1
        Me.lb_name.Text = "ឈ្មោះ"
        '
        'lb_gender
        '
        Me.lb_gender.AutoSize = True
        Me.lb_gender.Font = New System.Drawing.Font("Khmer OS Bokor", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_gender.Location = New System.Drawing.Point(12, 153)
        Me.lb_gender.Name = "lb_gender"
        Me.lb_gender.Size = New System.Drawing.Size(30, 27)
        Me.lb_gender.TabIndex = 2
        Me.lb_gender.Text = "ភេទ"
        '
        'lb_score
        '
        Me.lb_score.AutoSize = True
        Me.lb_score.Font = New System.Drawing.Font("Khmer OS Bokor", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_score.Location = New System.Drawing.Point(16, 201)
        Me.lb_score.Name = "lb_score"
        Me.lb_score.Size = New System.Drawing.Size(26, 27)
        Me.lb_score.TabIndex = 3
        Me.lb_score.Text = "ពិន្ទុ"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(48, 63)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(188, 20)
        Me.txt_id.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(48, 110)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(188, 20)
        Me.txt_name.TabIndex = 5
        '
        'txt_gender
        '
        Me.txt_gender.Location = New System.Drawing.Point(48, 157)
        Me.txt_gender.Name = "txt_gender"
        Me.txt_gender.Size = New System.Drawing.Size(188, 20)
        Me.txt_gender.TabIndex = 6
        '
        'txt_score
        '
        Me.txt_score.Location = New System.Drawing.Point(48, 204)
        Me.txt_score.Name = "txt_score"
        Me.txt_score.Size = New System.Drawing.Size(188, 20)
        Me.txt_score.TabIndex = 7
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Khmer OS Bokor", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(48, 239)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(51, 31)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "បន្ថែម"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_delet
        '
        Me.btn_delet.Font = New System.Drawing.Font("Khmer OS Bokor", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delet.Location = New System.Drawing.Point(105, 239)
        Me.btn_delet.Name = "btn_delet"
        Me.btn_delet.Size = New System.Drawing.Size(63, 31)
        Me.btn_delet.TabIndex = 9
        Me.btn_delet.Text = "លុប"
        Me.btn_delet.UseVisualStyleBackColor = True
        '
        'lv_name
        '
        Me.lv_name.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_name.Location = New System.Drawing.Point(242, 57)
        Me.lv_name.Name = "lv_name"
        Me.lv_name.Size = New System.Drawing.Size(425, 309)
        Me.lv_name.TabIndex = 10
        Me.lv_name.UseCompatibleStateImageBehavior = False
        Me.lv_name.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAME"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "SEX"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SCORE"
        Me.ColumnHeader4.Width = 90
        '
        'btn_edite
        '
        Me.btn_edite.Font = New System.Drawing.Font("Khmer OS Bokor", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edite.Location = New System.Drawing.Point(173, 239)
        Me.btn_edite.Name = "btn_edite"
        Me.btn_edite.Size = New System.Drawing.Size(63, 31)
        Me.btn_edite.TabIndex = 11
        Me.btn_edite.Text = "កែ"
        Me.btn_edite.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 392)
        Me.Controls.Add(Me.btn_edite)
        Me.Controls.Add(Me.lv_name)
        Me.Controls.Add(Me.btn_delet)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_score)
        Me.Controls.Add(Me.txt_gender)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lb_score)
        Me.Controls.Add(Me.lb_gender)
        Me.Controls.Add(Me.lb_name)
        Me.Controls.Add(Me.lb_id)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_id As System.Windows.Forms.Label
    Friend WithEvents lb_name As System.Windows.Forms.Label
    Friend WithEvents lb_gender As System.Windows.Forms.Label
    Friend WithEvents lb_score As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_gender As System.Windows.Forms.TextBox
    Friend WithEvents txt_score As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_delet As System.Windows.Forms.Button
    Friend WithEvents lv_name As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_edite As System.Windows.Forms.Button
End Class
