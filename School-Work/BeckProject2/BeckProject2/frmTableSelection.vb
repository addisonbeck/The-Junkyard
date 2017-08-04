'Programmed By Addison Beck
Public Class frmTableSelection
    Private Sub frmTableSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSelection.SelectedIndex = 0
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If cmbSelection.SelectedIndex = 0 Then
            frmHome1.ShowDialog()
        ElseIf cmbSelection.SelectedIndex = 1 Then
            MessageBox.Show("Table Two Has Not Been Created Yet")
            'frmTwoHome.ShowDialog()
        Else
            MessageBox.Show("There was an error. Please try your selection again.")
        End If
    End Sub
End Class