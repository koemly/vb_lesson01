Public Class Form2

    Private Sub bltadd_Click(sender As Object, e As EventArgs) Handles bltadd.Click
        Me.clb_name.Items.Add(Me.txtsomhat.Text & "   លេខរៀង " & Me.txtid.Text & "   ឈ្មោះ  " & Me.txtname.Text & "   ភេទ  " & Me.txtgender.Text & "   ពិន្ទុ  " & Me.txtscore.Text & "   ")
        Me.txtid.Text = ""
        Me.txtname.Text = ""
        Me.txtgender.Text = ""
        Me.txtscore.Text = ""
        Me.txtid.Focus()
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtid.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class