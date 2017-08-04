'Programmed By Addison Beck
Public Class frmAdd1

    Private claimHeading As New ClaimHeading

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        SetFields()

        'Fill table adapter
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblError.Text = ""

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

        'Call add procedure

        SetFields()
    End Sub

    Private Sub SetFields()
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtGroupNumber.Text = String.Empty
        txtTotalDamages.Text = String.Empty
        txtChangeReason.Text = "Created"

        txtFirstName.Focus()
    End Sub

    Private Sub frmAdd1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso (e.KeyCode = Keys.A)) Then
            btnAdd_Click(sender, e)
        End If
    End Sub
End Class