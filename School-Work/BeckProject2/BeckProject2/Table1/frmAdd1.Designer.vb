<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd1
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblGroupNumber = New System.Windows.Forms.Label()
        Me.lblTotalDamages = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGroupNumber = New System.Windows.Forms.TextBox()
        Me.txtTotalDamages = New System.Windows.Forms.TextBox()
        Me.txtChangeReason = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.ttAdd1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(157, 141)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(87, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.ttAdd1.SetToolTip(Me.btnAdd, "Adds Claim With Provied Info (Ctrl + A)")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(15, 9)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(76, 17)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(15, 35)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(76, 17)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'lblGroupNumber
        '
        Me.lblGroupNumber.AutoSize = True
        Me.lblGroupNumber.Location = New System.Drawing.Point(15, 63)
        Me.lblGroupNumber.Name = "lblGroupNumber"
        Me.lblGroupNumber.Size = New System.Drawing.Size(102, 17)
        Me.lblGroupNumber.TabIndex = 3
        Me.lblGroupNumber.Text = "Group Number"
        '
        'lblTotalDamages
        '
        Me.lblTotalDamages.AutoSize = True
        Me.lblTotalDamages.Location = New System.Drawing.Point(15, 89)
        Me.lblTotalDamages.Name = "lblTotalDamages"
        Me.lblTotalDamages.Size = New System.Drawing.Size(104, 17)
        Me.lblTotalDamages.TabIndex = 4
        Me.lblTotalDamages.Text = "Total Damages"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Change Reason"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(130, 4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(259, 22)
        Me.txtFirstName.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(130, 30)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(259, 22)
        Me.txtLastName.TabIndex = 7
        '
        'txtGroupNumber
        '
        Me.txtGroupNumber.Location = New System.Drawing.Point(130, 58)
        Me.txtGroupNumber.Name = "txtGroupNumber"
        Me.txtGroupNumber.Size = New System.Drawing.Size(259, 22)
        Me.txtGroupNumber.TabIndex = 8
        '
        'txtTotalDamages
        '
        Me.txtTotalDamages.Location = New System.Drawing.Point(130, 86)
        Me.txtTotalDamages.Name = "txtTotalDamages"
        Me.txtTotalDamages.Size = New System.Drawing.Size(259, 22)
        Me.txtTotalDamages.TabIndex = 9
        '
        'txtChangeReason
        '
        Me.txtChangeReason.Location = New System.Drawing.Point(130, 113)
        Me.txtChangeReason.Name = "txtChangeReason"
        Me.txtChangeReason.ReadOnly = True
        Me.txtChangeReason.Size = New System.Drawing.Size(259, 22)
        Me.txtChangeReason.TabIndex = 10
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(12, 169)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 11
        '
        'frmAdd1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 212)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.txtChangeReason)
        Me.Controls.Add(Me.txtTotalDamages)
        Me.Controls.Add(Me.txtGroupNumber)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalDamages)
        Me.Controls.Add(Me.lblGroupNumber)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnAdd)
        Me.KeyPreview = True
        Me.Name = "frmAdd1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblGroupNumber As Label
    Friend WithEvents lblTotalDamages As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGroupNumber As TextBox
    Friend WithEvents txtTotalDamages As TextBox
    Friend WithEvents txtChangeReason As TextBox
    Friend WithEvents lblError As Label
    Friend WithEvents ttAdd1 As ToolTip
End Class
