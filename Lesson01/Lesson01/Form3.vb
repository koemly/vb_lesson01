Public Class Form3

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        addlv_name()
        clear()
        Me.txt_id.Focus()
    End Sub
    Private Sub btn_delet_Click(sender As Object, e As EventArgs) Handles btn_delet.Click
        removeaddlv_name()
    End Sub
    Private Sub addlv_name()
        Dim i As ListViewItem
        i = lv_name.Items.Add(txt_id.Text)
        i.SubItems.Add(txt_name.Text)
        i.SubItems.Add(txt_gender.Text)
        i.SubItems.Add(txt_score.Text)
    End Sub
    Private Sub removeaddlv_name()
        Dim i As ListViewItem
        i = lv_name.SelectedItems(0)
        i.Remove()
    End Sub
    Private Sub clear()
        Me.txt_id.Text = ""
        Me.txt_name.Text = ""
        Me.txt_gender.Text = ""
        Me.txt_score.Text = ""
    End Sub

    Private Sub txt_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_id.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_name.Focus()
        End If
    End Sub

    Private Sub txt_name_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_name.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_gender.Focus()
        End If
    End Sub

    Private Sub txt_gender_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_gender.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_score.Focus()
        End If
    End Sub

    Private Sub txt_score_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_score.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.Focus()
        End If
    End Sub

    Private Sub btn_edite_Click(sender As Object, e As EventArgs) Handles btn_edite.Click
        Dim i As ListViewItem
        i = lv_name.SelectedItems(0)
        i.Text = txt_id.Text
        i.SubItems.Item(2).Text = txt_score.Text
    End Sub
End Class