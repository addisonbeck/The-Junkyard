Public Class Song
    'Programmed By: Addison Beck
    'Part 1 - Design and Implement a Class Of Your Choosing

    Implements IComparable

    'At least 5 relevant instance variables of a variety of data types
    Private m_title As String 'Song title
    Private m_artist As String 'Song artist
    Private m_album As String 'Song album
    Private m_year As Integer 'Year released
    Private m_trackNumber As Integer 'Track number

    'Property blocks for each instance variable
    Public Property Title() As String
        Get
            Return m_title
        End Get
        Set(value As String)
            m_title = value
        End Set
    End Property

    Public Property Artist() As String
        Get
            Return m_artist
        End Get
        Set(value As String)
            m_artist = value
        End Set
    End Property

    Public Property Album() As String
        Get
            Return m_album
        End Get
        Set(value As String)
            m_album = value
        End Set
    End Property

    Public Property Year() As Integer
        Get
            Return m_year
        End Get
        Set(value As Integer)
            m_year = value
        End Set
    End Property

    Public Property TrackNumber() As Integer
        Get
            Return m_trackNumber
        End Get
        Set(value As Integer)
            m_trackNumber = value
        End Set
    End Property


    'Default constructor
    Public Sub New()
        m_title = "song"
        m_artist = "artist"
        m_album = "album"
        m_trackNumber = 1
        m_year = 1
    End Sub

    'A minimum of one additional constructor
    Public Sub New(ByRef p_title, ByRef p_artist, ByRef p_album, ByRef p_trackNumber, ByRef p_year)
        m_title = p_title
        m_artist = p_artist
        m_album = p_album
        m_trackNumber = p_trackNumber
        m_year = p_year
    End Sub

    'An appropriate overloaded ToString method
    Public Overrides Function ToString() As String
        Return "Title: " & m_title & vbCrLf & "Artist: " & m_artist & vbCrLf & "Album: " & m_album & vbCrLf & "Track Number: " & CStr(m_trackNumber) & vbCrLf & "Year Released: " & CStr(m_year)
    End Function

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Return m_title.CompareTo(CType(obj, Song).m_title)
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Me.Title.Equals(CType(obj, String))
    End Function
End Class
