<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTrackNumber = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtTrackNumber = New System.Windows.Forms.TextBox()
        Me.lstList = New System.Windows.Forms.ListBox()
        Me.txtSelectionOutput = New System.Windows.Forms.TextBox()
        Me.btnSortByTitle = New System.Windows.Forms.Button()
        Me.btnSortByArtist = New System.Windows.Forms.Button()
        Me.ttSearch = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.lblTrackNumber)
        Me.GroupBox1.Controls.Add(Me.lblYear)
        Me.GroupBox1.Controls.Add(Me.lblAlbum)
        Me.GroupBox1.Controls.Add(Me.lblArtist)
        Me.GroupBox1.Controls.Add(Me.lblTitle)
        Me.GroupBox1.Controls.Add(Me.txtAlbum)
        Me.GroupBox1.Controls.Add(Me.txtArtist)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.txtYear)
        Me.GroupBox1.Controls.Add(Me.txtTrackNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add/Edit/Search For Song"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(271, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(128, 29)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search (By Title)"
        Me.ttSearch.SetToolTip(Me.btnSearch, "Search for an item using title input.")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(271, 118)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 29)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete Song"
        Me.ttSearch.SetToolTip(Me.btnDelete, "Delete the currently selected song")
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(272, 87)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(128, 29)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Save Edit"
        Me.ttSearch.SetToolTip(Me.btnEdit, "Edit the currently selected song")
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(272, 55)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 29)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add Song"
        Me.ttSearch.SetToolTip(Me.btnAdd, "Add a song to the list")
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblTrackNumber
        '
        Me.lblTrackNumber.AutoSize = True
        Me.lblTrackNumber.Location = New System.Drawing.Point(19, 136)
        Me.lblTrackNumber.Name = "lblTrackNumber"
        Me.lblTrackNumber.Size = New System.Drawing.Size(98, 17)
        Me.lblTrackNumber.TabIndex = 10
        Me.lblTrackNumber.Text = "Track Number"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(19, 108)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(94, 17)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "Release Year"
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Location = New System.Drawing.Point(19, 80)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(47, 17)
        Me.lblAlbum.TabIndex = 8
        Me.lblAlbum.Text = "Album"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(19, 52)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(40, 17)
        Me.lblArtist.TabIndex = 7
        Me.lblArtist.Text = "Artist"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(19, 26)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(35, 17)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Title"
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(123, 77)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(142, 22)
        Me.txtAlbum.TabIndex = 3
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(123, 49)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(142, 22)
        Me.txtArtist.TabIndex = 2
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(123, 21)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(142, 22)
        Me.txtTitle.TabIndex = 1
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(123, 105)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(142, 22)
        Me.txtYear.TabIndex = 4
        '
        'txtTrackNumber
        '
        Me.txtTrackNumber.Location = New System.Drawing.Point(123, 133)
        Me.txtTrackNumber.Name = "txtTrackNumber"
        Me.txtTrackNumber.Size = New System.Drawing.Size(142, 22)
        Me.txtTrackNumber.TabIndex = 5
        '
        'lstList
        '
        Me.lstList.FormattingEnabled = True
        Me.lstList.ItemHeight = 16
        Me.lstList.Location = New System.Drawing.Point(7, 179)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(205, 148)
        Me.lstList.TabIndex = 1
        '
        'txtSelectionOutput
        '
        Me.txtSelectionOutput.Location = New System.Drawing.Point(225, 179)
        Me.txtSelectionOutput.Multiline = True
        Me.txtSelectionOutput.Name = "txtSelectionOutput"
        Me.txtSelectionOutput.ReadOnly = True
        Me.txtSelectionOutput.Size = New System.Drawing.Size(187, 172)
        Me.txtSelectionOutput.TabIndex = 2
        '
        'btnSortByTitle
        '
        Me.btnSortByTitle.Location = New System.Drawing.Point(7, 328)
        Me.btnSortByTitle.Name = "btnSortByTitle"
        Me.btnSortByTitle.Size = New System.Drawing.Size(101, 24)
        Me.btnSortByTitle.TabIndex = 10
        Me.btnSortByTitle.Text = "Sort By Title"
        Me.ttSearch.SetToolTip(Me.btnSortByTitle, "Sort list by song title")
        Me.btnSortByTitle.UseVisualStyleBackColor = True
        '
        'btnSortByArtist
        '
        Me.btnSortByArtist.Location = New System.Drawing.Point(114, 328)
        Me.btnSortByArtist.Name = "btnSortByArtist"
        Me.btnSortByArtist.Size = New System.Drawing.Size(98, 24)
        Me.btnSortByArtist.TabIndex = 11
        Me.btnSortByArtist.Text = "Sort By Artist"
        Me.ttSearch.SetToolTip(Me.btnSortByArtist, "Sort list by song artist")
        Me.btnSortByArtist.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 359)
        Me.Controls.Add(Me.btnSortByArtist)
        Me.Controls.Add(Me.btnSortByTitle)
        Me.Controls.Add(Me.txtSelectionOutput)
        Me.Controls.Add(Me.lstList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmHome"
        Me.Text = "Homepage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtTrackNumber As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblTrackNumber As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblAlbum As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lstList As ListBox
    Friend WithEvents txtSelectionOutput As TextBox
    Friend WithEvents btnSortByTitle As Button
    Friend WithEvents btnSortByArtist As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents ttSearch As ToolTip
End Class
