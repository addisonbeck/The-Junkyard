'Programmed By Addison Beck
Public Class frmEdit1

    Private claimHeading As New ClaimHeading

    Private Sub frmEdit1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        claimHeading.Claim_Heading_Id = frmHome1.selectedId
        txtFirstName.Focus()

        'Fill textboxes
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            claimHeading.First_Name = txtFirstName.Text
            claimHeading.Last_Name = txtLastName.Text
            claimHeading.Group_Number = CInt(txtGroupNumber.Text)
            claimHeading.Total_Damages = CDbl(txtTotalDamages.Text)
            claimHeading.Change_Reason = txtChangeReason.Text
        Catch ex As Exception
            lblError.Text = "One or more input properties are invalid. Please try again."
            txtFirstName.Focus()
            Return
        End Try

        'Call Edit Procedure 
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Call Delete Procedure 
        Me.Close()
    End Sub

    Private Sub frmEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso (e.KeyCode = Keys.D)) Then
            btnDelete_Click(sender, e)
        End If
        If (e.Control AndAlso (e.KeyCode = Keys.E)) Then
            btnEdit_Click(sender, e)
        End If
    End Sub
End Class