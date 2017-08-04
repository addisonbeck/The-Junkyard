<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblGroupNumber = New System.Windows.Forms.Label()
        Me.lblTotalDamages = New System.Windows.Forms.Label()
        Me.lblChangeReason = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGroupNumber = New System.Windows.Forms.TextBox()
        Me.txtTotalDamages = New System.Windows.Forms.TextBox()
        Me.txtChangeReason = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.ttEdit1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(8, 11)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 17)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(8, 39)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(76, 17)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(8, 67)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(76, 17)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'lblGroupNumber
        '
        Me.lblGroupNumber.AutoSize = True
        Me.lblGroupNumber.Location = New System.Drawing.Point(8, 93)
        Me.lblGroupNumber.Name = "lblGroupNumber"
        Me.lblGroupNumber.Size = New System.Drawing.Size(102, 17)
        Me.lblGroupNumber.TabIndex = 3
        Me.lblGroupNumber.Text = "Group Number"
        '
        'lblTotalDamages
        '
        Me.lblTotalDamages.AutoSize = True
        Me.lblTotalDamages.Location = New System.Drawing.Point(8, 121)
        Me.lblTotalDamages.Name = "lblTotalDamages"
        Me.lblTotalDamages.Size = New System.Drawing.Size(104, 17)
        Me.lblTotalDamages.TabIndex = 4
        Me.lblTotalDamages.Text = "Total Damages"
        '
        'lblChangeReason
        '
        Me.lblChangeReason.AutoSize = True
        Me.lblChangeReason.Location = New System.Drawing.Point(8, 149)
        Me.lblChangeReason.Name = "lblChangeReason"
        Me.lblChangeReason.Size = New System.Drawing.Size(110, 17)
        Me.lblChangeReason.TabIndex = 5
        Me.lblChangeReason.Text = "Change Reason"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(123, 8)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(273, 22)
        Me.txtID.TabIndex = 6
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(123, 36)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(273, 22)
        Me.txtFirstName.TabIndex = 7
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(123, 64)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(273, 22)
        Me.txtLastName.TabIndex = 8
        '
        'txtGroupNumber
        '
        Me.txtGroupNumber.Location = New System.Drawing.Point(123, 90)
        Me.txtGroupNumber.Name = "txtGroupNumber"
        Me.txtGroupNumber.Size = New System.Drawing.Size(273, 22)
        Me.txtGroupNumber.TabIndex = 9
        '
        'txtTotalDamages
        '
        Me.txtTotalDamages.Location = New System.Drawing.Point(123, 118)
        Me.txtTotalDamages.Name = "txtTotalDamages"
        Me.txtTotalDamages.Size = New System.Drawing.Size(273, 22)
        Me.txtTotalDamages.TabIndex = 10
        '
        'txtChangeReason
        '
        Me.txtChangeReason.Location = New System.Drawing.Point(123, 146)
        Me.txtChangeReason.Name = "txtChangeReason"
        Me.txtChangeReason.Size = New System.Drawing.Size(273, 22)
        Me.txtChangeReason.TabIndex = 11
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(103, 174)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete Claim"
        Me.ttEdit1.SetToolTip(Me.btnDelete, "Deletes Claim With Matching ID (Ctlr + D)")
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(208, 174)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(102, 23)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Save Edit"
        Me.ttEdit1.SetToolTip(Me.btnEdit, "Edits Claim To Show Info Based On Input (Ctrl + E)")
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(12, 229)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 14
        '
        'frmEdit1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 248)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtChangeReason)
        Me.Controls.Add(Me.txtTotalDamages)
        Me.Controls.Add(Me.txtGroupNumber)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblChangeReason)
        Me.Controls.Add(Me.lblTotalDamages)
        Me.Controls.Add(Me.lblGroupNumber)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmEdit1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblGroupNumber As Label
    Friend WithEvents lblTotalDamages As Label
    Friend WithEvents lblChangeReason As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGroupNumber As TextBox
    Friend WithEvents txtTotalDamages As TextBox
    Friend WithEvents txtChangeReason As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblError As Label
    Friend WithEvents ttEdit1 As ToolTip
End Class
