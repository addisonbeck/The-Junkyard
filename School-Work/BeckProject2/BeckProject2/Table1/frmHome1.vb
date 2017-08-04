'Programmed By Addison Beck
Public Class frmHome1

    Public selectedId As String

    Private Sub frmHome1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        btnDisplay_Click(sender, e)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAdd1.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEdit1.ShowDialog()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Call default fill
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim input As String = txtSearch.Text
        'Call search function
    End Sub

    Private Sub frmHome1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso (e.KeyCode = Keys.D)) Then
            btnDisplay_Click(sender, e)
        End If

        If (e.Control AndAlso (e.KeyCode = Keys.A)) Then
            btnAdd_Click(sender, e)
        End If

        If (e.Control AndAlso (e.KeyCode = Keys.E)) Then
            btnEdit_Click(sender, e)
        End If

        If (e.Control AndAlso (e.KeyCode = Keys.S)) Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub dgvOutput_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvOutput.CurrentCellChanged
        selectedId = dgvOutput.CurrentCell.Value
    End Sub
End Class
