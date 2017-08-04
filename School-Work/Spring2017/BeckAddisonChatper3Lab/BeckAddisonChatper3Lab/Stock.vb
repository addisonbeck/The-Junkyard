Public Class Stock
    'Programmed By: Addison Beck
    'Chapter 3 Lab

    'Create a stock class

    Implements IComparable

    'With the following properties:
    Private m_stockSymbol As String 'Stock Symbol (String)
    Private m_price As Double 'Price (Double)
    Private m_earning As Double 'Earnings (Double)

    Public Property StockSymbol() As String
        Get
            Return m_stockSymbol
        End Get
        Set(value As String)
            m_stockSymbol = value
        End Set
    End Property

    Public Property Price() As Double
        Get
            Return m_price
        End Get
        Set(value As Double)
            m_price = value
        End Set
    End Property

    Public Property Earnings() As Double
        Get
            Return m_earning
        End Get
        Set(value As Double)
            m_earning = value
        End Set
    End Property

    'Create a default constructor that initializes these values to 0 or empty strings
    Public Sub New()
        m_stockSymbol = ""
        m_price = 0
        m_earning = 0
    End Sub

    'Create an additional constructor that initializes these values based on user input
    Public Sub New(ByRef p_stockSymbol, ByRef p_price, ByRef p_earnings)
        m_stockSymbol = p_stockSymbol
        m_price = p_price
        m_earning = p_earnings
    End Sub

    'Create a ReadOnly method/property named PeRatio that returns the stock’s price divided by the earnings
    Public ReadOnly Property PeRatio() As Double
        Get
            Return (m_price / m_earning)
        End Get
    End Property

    'Sorts by ticker
    Private Function IComparable_CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Return m_stockSymbol.CompareTo(CType(obj, Stock).m_stockSymbol)
    End Function
End Class
