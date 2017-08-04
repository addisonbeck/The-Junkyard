Public Class Vehicle

    'Create a “Vehicle” class. Each vehicle should have the following characteristics:
    Private m_make As String ' Make
    Private m_model As String ' Model
    Private m_passengerCount As Integer  'Number of Passengers
    Private m_tankCapacity As Integer ' Gas Tank Capacity
    Private m_milesPerGallon As Integer ' Miles per Gallon


    'Each vehicle should also have the following functionality:
    'Create an object of itself (with and without parameters)
    'without parameters
    Public Sub New()
        m_make = "make"
        m_model = "model"
        m_passengerCount = 0
        m_tankCapacity = 0
        m_milesPerGallon = 0
    End Sub

    'with parameters
    Public Sub New(ByRef p_make As String, ByRef p_model As String, ByRef p_passengerCount As Integer, ByRef p_tankCapacity As Integer, ByRef p_milesPerGallon As Integer)
        m_make = p_make
        m_model = p_model
        m_passengerCount = p_passengerCount
        m_tankCapacity = p_tankCapacity
        m_milesPerGallon = p_milesPerGallon
    End Sub

    'Property Blocks
    Public Property Make() As String
        Get
            Return m_make
        End Get
        Set(value As String)
            m_make = value
        End Set
    End Property

    Public Property Model() As String
        Get
            Return m_model
        End Get
        Set(value As String)
            m_model = value
        End Set
    End Property
    Public Property PassengerCount() As String
        Get
            Return m_passengerCount
        End Get
        Set(value As String)
            m_passengerCount = value
        End Set
    End Property
    Public Property TankCapacity() As String
        Get
            Return m_tankCapacity
        End Get
        Set(value As String)
            m_tankCapacity = value
        End Set
    End Property
    Public Property MilesPerGallon() As String
        Get
            Return m_milesPerGallon
        End Get
        Set(value As String)
            m_milesPerGallon = value
        End Set
    End Property

    'Methods
    'Calculate the range (in miles) for a full tank of gas
    Public Function CalcFullTankMileage() As Integer
        Dim mileage As Integer
        mileage = (m_milesPerGallon * m_tankCapacity)
        Return mileage
    End Function

    'Determine how much gas is needed to drive a user-input number of miles
    Public Function CalcGasForTrip(ByVal tripMiles As Integer)
        Dim gallons As Integer
        gallons = (tripMiles / m_milesPerGallon)
        Return gallons
    End Function

    'Output a string representation of itself
    Public Overloads Function ToString(ByVal tripMiles As Integer) As String
        Return m_make & " " & m_model & vbCrLf & vbCrLf & "Range Of A Full Tank: " & CalcFullTankMileage() & " miles" & vbCrLf & "Gallons Needed For Your Trip: " & CalcGasForTrip(tripMiles)
    End Function
End Class
