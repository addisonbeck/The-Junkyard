Public Class HomePage
    'Create an application that creates objects of the Vehicle Class.

    'Create New Vehicle Instance
    Dim vehicle As Vehicle
    Dim vehicleList As New List(Of Vehicle)()

    'Allow the user to enter the following data through the interface to create the following objects of the class
    Private Sub formLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMake.SelectedIndex = 0
        cmbModel.SelectedIndex = 0
        cmbPassengerCount.SelectedIndex = 0
        cmbTankCapacity.SelectedIndex = 0
        cmbMilesPerGallon.SelectedIndex = 0
    End Sub

    'The objects, as they are added, should be displayed in a list box.
    Private Sub btnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        vehicle = New Vehicle
        Dim count As Integer

        vehicle.Make = cmbMake.Text
        vehicle.Model = cmbModel.Text
        vehicle.PassengerCount = CInt(cmbPassengerCount.Text)
        vehicle.TankCapacity = CInt(cmbTankCapacity.Text)
        vehicle.MilesPerGallon = CInt(cmbMilesPerGallon.Text)

        vehicleList.Add(New Vehicle(vehicle.Make, vehicle.Model, vehicle.PassengerCount, vehicle.TankCapacity, vehicle.MilesPerGallon))
        count = vehicleList.Count - 1

        lstVehicles.Items.Add(vehicleList(count).Make & " " & vehicleList(count).Model)
    End Sub

    'When a vehicle is selected in the list box, the program should output (in a nicely formatted way)...
    Private Sub lstVehicles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstVehicles.SelectedIndexChanged
        Dim tripMiles As Integer = numTripMiles.Value
        Dim index As Integer = lstVehicles.SelectedIndex

        txtOutput.Clear()
        txtOutput.Text = vehicleList(index).ToString(tripMiles)
    End Sub

    'Added feature: also update the output text if tripMiles is changed
    Private Sub numTripMiles_ValueChanged(sender As Object, e As EventArgs) Handles numTripMiles.ValueChanged
        If lstVehicles.Items.Count >= 1 Then
            If lstVehicles.SelectedIndex >= 0 Then
                Dim tripMiles As Integer = numTripMiles.Value
                Dim index As Integer = lstVehicles.SelectedIndex

                txtOutput.Clear()
                txtOutput.Text = vehicleList(index).ToString(tripMiles)
            Else
                Return
            End If
        End If
    End Sub
End Class
