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
        Me.txtsomhat = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bltadd
        '
        Me.bltadd.Location = New System.Drawing.Point(92, 222)
        Me.bltadd.Name = "bltadd"
        Me.bltadd.Size = New System.Drawing.Size(78, 27)
        Me.bltadd.TabIndex = 0
        Me.bltadd.Text = "បន្ថែម"
        Me.bltadd.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(92, 51)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(142, 20)
        Me.txtid.TabIndex = 1
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(92, 99)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(142, 20)
        Me.txtname.TabIndex = 2
        '
        'txtgender
        '
        Me.txtgender.Location = New System.Drawing.Point(92, 148)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(142, 20)
        Me.txtgender.TabIndex = 3
        '
        'txtscore
        '
        Me.txtscore.Location = New System.Drawing.Point(92, 194)
        Me.txtscore.Name = "txtscore"
        Me.txtscore.Size = New System.Drawing.Size(142, 20)
        Me.txtscore.TabIndex = 4
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(26, 49)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(60, 18)
        Me.lbID.TabIndex = 5
        Me.lbID.Text = "លេខរៀង"
        '
        'lbname
        '
        Me.lbname.AutoSize = True
        Me.lbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbname.Location = New System.Drawing.Point(49, 97)
        Me.lbname.Name = "lbname"
        Me.lbname.Size = New System.Drawing.Size(37, 20)
        Me.lbname.TabIndex = 6
        Me.lbname.Text = "ឈ្មោះ"
        '
        'lbgender
        '
        Me.lbgender.AutoSize = True
        Me.lbgender.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbgender.Location = New System.Drawing.Point(52, 146)
        Me.lbgender.Name = "lbgender"
        Me.lbgender.Size = New System.Drawing.Size(34, 18)
        Me.lbgender.TabIndex = 7
        Me.lbgender.Text = "ភេទ"
        '
        'lbscore
        '
        Me.lbscore.AutoSize = True
        Me.lbscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbscore.Location = New System.Drawing.Point(57, 188)
        Me.lbscore.Name = "lbscore"
        Me.lbscore.Size = New System.Drawing.Size(29, 20)
        Me.lbscore.TabIndex = 8
        Me.lbscore.Text = "ពិន្ទុ"
        '
        'clb_name
        '
        Me.clb_name.FormattingEnabled = True
        Me.clb_name.Location = New System.Drawing.Point(255, 51)
        Me.clb_name.Name = "clb_name"
        Me.clb_name.Size = New System.Drawing.Size(350, 169)
        Me.clb_name.TabIndex = 9
        '
        'txtsomhat
        '
        Me.txtsomhat.Location = New System.Drawing.Point(62, 229)
        Me.txtsomhat.Name = "txtsomhat"
        Me.txtsomhat.Size = New System.Drawing.Size(24, 20)
        Me.txtsomhat.TabIndex = 10
        Me.txtsomhat.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(530, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 280)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtsomhat)
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
    Friend WithEvents txtsomhat As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
