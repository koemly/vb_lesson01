<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLesson01
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.clb_ListProvinces = New System.Windows.Forms.CheckedListBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtProvinceName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoEllipsis = True
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = Global.Lesson01.My.Resources.Resources.if_save_173091
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(596, 35)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 52)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(183, 31)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'clb_ListProvinces
        '
        Me.clb_ListProvinces.FormattingEnabled = True
        Me.clb_ListProvinces.Items.AddRange(New Object() {"Go to PP", "Go to BB", "Go to SR"})
        Me.clb_ListProvinces.Location = New System.Drawing.Point(12, 54)
        Me.clb_ListProvinces.Name = "clb_ListProvinces"
        Me.clb_ListProvinces.Size = New System.Drawing.Size(252, 379)
        Me.clb_ListProvinces.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(290, 171)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(413, 262)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Image = Global.Lesson01.My.Resources.Resources.if_save_173091
        Me.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShow.Location = New System.Drawing.Point(474, 35)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(107, 52)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "Show"
        Me.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'txtProvinceName
        '
        Me.txtProvinceName.Location = New System.Drawing.Point(386, 116)
        Me.txtProvinceName.Name = "txtProvinceName"
        Me.txtProvinceName.Size = New System.Drawing.Size(258, 20)
        Me.txtProvinceName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Province Name"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(651, 115)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(52, 23)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(290, 35)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(162, 20)
        Me.txtID.TabIndex = 7
        '
        'frmLesson01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 472)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProvinceName)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.clb_ListProvinces)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmLesson01"
        Me.Text = "Lesson One Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents clb_ListProvinces As System.Windows.Forms.CheckedListBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents txtProvinceName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox

End Class
