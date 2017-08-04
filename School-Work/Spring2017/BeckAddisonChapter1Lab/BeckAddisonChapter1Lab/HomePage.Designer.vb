<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.lblPleaseInput = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.gpbUserInput = New System.Windows.Forms.GroupBox()
        Me.btnAddVehicle = New System.Windows.Forms.Button()
        Me.cmbMilesPerGallon = New System.Windows.Forms.ComboBox()
        Me.cmbTankCapacity = New System.Windows.Forms.ComboBox()
        Me.cmbPassengerCount = New System.Windows.Forms.ComboBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lblPassengerCapacity = New System.Windows.Forms.Label()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.numTripMiles = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstVehicles = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gpbUserInput.SuspendLayout()
        CType(Me.numTripMiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPleaseInput
        '
        Me.lblPleaseInput.AutoSize = True
        Me.lblPleaseInput.Location = New System.Drawing.Point(12, 9)
        Me.lblPleaseInput.Name = "lblPleaseInput"
        Me.lblPleaseInput.Size = New System.Drawing.Size(0, 17)
        Me.lblPleaseInput.TabIndex = 0
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(13, 31)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(46, 17)
        Me.lblMake.TabIndex = 1
        Me.lblMake.Text = "Make:"
        '
        'gpbUserInput
        '
        Me.gpbUserInput.Controls.Add(Me.btnAddVehicle)
        Me.gpbUserInput.Controls.Add(Me.cmbMilesPerGallon)
        Me.gpbUserInput.Controls.Add(Me.cmbTankCapacity)
        Me.gpbUserInput.Controls.Add(Me.cmbPassengerCount)
        Me.gpbUserInput.Controls.Add(Me.cmbModel)
        Me.gpbUserInput.Controls.Add(Me.cmbMake)
        Me.gpbUserInput.Controls.Add(Me.lblPassengerCapacity)
        Me.gpbUserInput.Controls.Add(Me.lblCapacity)
        Me.gpbUserInput.Controls.Add(Me.Label1)
        Me.gpbUserInput.Controls.Add(Me.lblModel)
        Me.gpbUserInput.Controls.Add(Me.lblMake)
        Me.gpbUserInput.Location = New System.Drawing.Point(16, 12)
        Me.gpbUserInput.Name = "gpbUserInput"
        Me.gpbUserInput.Size = New System.Drawing.Size(442, 248)
        Me.gpbUserInput.TabIndex = 2
        Me.gpbUserInput.TabStop = False
        Me.gpbUserInput.Text = "Please Input The Following Vehicle Information:"
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.Location = New System.Drawing.Point(325, 186)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(111, 24)
        Me.btnAddVehicle.TabIndex = 7
        Me.btnAddVehicle.Text = "Add Vehicle"
        Me.btnAddVehicle.UseVisualStyleBackColor = True
        '
        'cmbMilesPerGallon
        '
        Me.cmbMilesPerGallon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMilesPerGallon.FormattingEnabled = True
        Me.cmbMilesPerGallon.Items.AddRange(New Object() {"12", "16", "24"})
        Me.cmbMilesPerGallon.Location = New System.Drawing.Point(380, 156)
        Me.cmbMilesPerGallon.Name = "cmbMilesPerGallon"
        Me.cmbMilesPerGallon.Size = New System.Drawing.Size(56, 24)
        Me.cmbMilesPerGallon.TabIndex = 10
        '
        'cmbTankCapacity
        '
        Me.cmbTankCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTankCapacity.FormattingEnabled = True
        Me.cmbTankCapacity.Items.AddRange(New Object() {"14", "18", "20"})
        Me.cmbTankCapacity.Location = New System.Drawing.Point(380, 126)
        Me.cmbTankCapacity.Name = "cmbTankCapacity"
        Me.cmbTankCapacity.Size = New System.Drawing.Size(56, 24)
        Me.cmbTankCapacity.TabIndex = 9
        '
        'cmbPassengerCount
        '
        Me.cmbPassengerCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPassengerCount.FormattingEnabled = True
        Me.cmbPassengerCount.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbPassengerCount.Location = New System.Drawing.Point(380, 94)
        Me.cmbPassengerCount.Name = "cmbPassengerCount"
        Me.cmbPassengerCount.Size = New System.Drawing.Size(56, 24)
        Me.cmbPassengerCount.TabIndex = 8
        '
        'cmbModel
        '
        Me.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Items.AddRange(New Object() {"Minivan", "Sportscar", "Crossover"})
        Me.cmbModel.Location = New System.Drawing.Point(315, 58)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(121, 24)
        Me.cmbModel.TabIndex = 7
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Chevy", "Honda", "Lexus"})
        Me.cmbMake.Location = New System.Drawing.Point(315, 28)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 24)
        Me.cmbMake.Sorted = True
        Me.cmbMake.TabIndex = 6
        '
        'lblPassengerCapacity
        '
        Me.lblPassengerCapacity.AutoSize = True
        Me.lblPassengerCapacity.Location = New System.Drawing.Point(13, 97)
        Me.lblPassengerCapacity.Name = "lblPassengerCapacity"
        Me.lblPassengerCapacity.Size = New System.Drawing.Size(86, 17)
        Me.lblPassengerCapacity.TabIndex = 5
        Me.lblPassengerCapacity.Text = "Seat Count: "
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(13, 129)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(127, 17)
        Me.lblCapacity.TabIndex = 4
        Me.lblCapacity.Text = "Tank Capacity (gl):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MPG"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(13, 61)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(50, 17)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Model:"
        '
        'numTripMiles
        '
        Me.numTripMiles.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numTripMiles.Location = New System.Drawing.Point(166, 309)
        Me.numTripMiles.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numTripMiles.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numTripMiles.Name = "numTripMiles"
        Me.numTripMiles.Size = New System.Drawing.Size(56, 22)
        Me.numTripMiles.TabIndex = 13
        Me.numTripMiles.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Miles In Your Trip:"
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.Location = New System.Drawing.Point(184, 318)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(0, 17)
        Me.lblGallons.TabIndex = 4
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.txtOutput.Location = New System.Drawing.Point(270, 296)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(188, 68)
        Me.txtOutput.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Added Vehicles:"
        '
        'lstVehicles
        '
        Me.lstVehicles.FormattingEnabled = True
        Me.lstVehicles.ItemHeight = 16
        Me.lstVehicles.Location = New System.Drawing.Point(15, 296)
        Me.lstVehicles.Name = "lstVehicles"
        Me.lstVehicles.Size = New System.Drawing.Size(121, 68)
        Me.lstVehicles.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Vehicle Details"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 381)
        Me.Controls.Add(Me.numTripMiles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstVehicles)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.gpbUserInput)
        Me.Controls.Add(Me.lblPleaseInput)
        Me.Name = "HomePage"
        Me.Text = "Trip Mileage Calculator"
        Me.gpbUserInput.ResumeLayout(False)
        Me.gpbUserInput.PerformLayout()
        CType(Me.numTripMiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPleaseInput As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents gpbUserInput As GroupBox
    Friend WithEvents lblPassengerCapacity As Label
    Friend WithEvents lblCapacity As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents cmbPassengerCount As ComboBox
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents cmbMilesPerGallon As ComboBox
    Friend WithEvents cmbTankCapacity As ComboBox
    Friend WithEvents lblGallons As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddVehicle As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents numTripMiles As NumericUpDown
    Friend WithEvents lstVehicles As ListBox
    Friend WithEvents Label2 As Label
End Class
