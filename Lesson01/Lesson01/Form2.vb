Public Class Form2

    Private Sub bltadd_Click(sender As Object, e As EventArgs) Handles bltadd.Click
        SaveToCLV()
        SaveToLV()
        clearForm()
    End Sub
    Private Sub clearForm()
        Me.txtid.Text = ""
        Me.txtname.Text = ""
        Me.txtgender.Text = ""
        Me.txtscore.Text = ""
        Me.txtid.Focus()
    End Sub
    Private Sub SaveToLV()
        Dim i As Integer
        ' i = lv_Students.Items.Count

        Me.lv_Students.Items.Add(Me.txtid.Text)
        Me.lv_Students.Items(i).SubItems.Add(Me.txtname.Text)
        Me.lv_Students.Items(i).SubItems.Add(Me.txtgender.Text)
        Me.lv_Students.Items(i).SubItems.Add(Me.txtscore.Text)
    End Sub
    Private Sub SaveToCLV()
        Me.clb_name.Items.Add("លេខរៀង : " & Me.txtid.Text & "   ឈ្មោះ :  " & Me.txtname.Text & "   ភេទ : " & Me.txtgender.Text & "   ពិន្ទុ : " & Me.txtscore.Text & "   ")
        Me.txtCount.Text = Me.clb_name.Items.Count
    End Sub
    Private Sub txtid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtid.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtname.Focus()
        End If
    End Sub
    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtid.Focus()
        Me.txtCount.Text = Me.clb_name.Items.Count

       
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class