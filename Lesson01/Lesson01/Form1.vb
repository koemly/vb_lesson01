Public Class frmLesson01

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Me.btnSave.Visible = False



    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click

        Me.btnSave.Visible = True

        Me.clb_ListProvinces.Items.Add(" Click Show Button ")
        'Me.clb_ListProvinces.Items.Add(3)="Click Show"


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Me.clb_ListProvinces.Items.Add(Me.txtID.Text & " - " & Me.txtProvinceName.Text)
        Me.txtProvinceName.Text = ""
        'Me.clb_ListProvinces.Visible = False

        Me.txtProvinceName.Focus()

    End Sub

    Private Sub frmLesson01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.clb_ListProvinces.Items.Clear()


    End Sub
End Class
