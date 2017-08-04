Public Class HomePage
    'Create an application that sorts a list of Stock objects based on:
    ' Ticker Symbol

    ' Price-to-Earnings (PE) Ratio (Allow the user can select whether to sort in ascending Or descending order 
    ' you will need comparator methods For the List.Sort)

    Dim Stock As New Stock
    Dim stockList As New List(Of Stock)()

    'Use the following sample stocks (you can build a list of Stock objects in the Form_Load event)
    Private Sub HomePage_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        stockList.Add(New Stock() With {
    .StockSymbol = "MMA",
    .Price = 40,
    .Earnings = 5})

        stockList.Add(New Stock() With {
            .StockSymbol = "XYZ",
            .Price = 77.5,
            .Earnings = 4.25})

        stockList.Add(New Stock() With {
            .StockSymbol = "LLT",
            .Price = 43.25,
            .Earnings = 5.5})

        stockList.Add(New Stock() With {
            .StockSymbol = "SBA",
            .Price = 42,
            .Earnings = 7.1})

        For Each Stock In stockList
            dgvStocks.Rows.Add(Stock.StockSymbol, Stock.Price, Stock.Earnings, Stock.PeRatio)
            Debug.Write(Stock.StockSymbol)
        Next

    End Sub

    'Sorts by price
    Public Function ComparePrice(ByVal x As Stock, ByVal y As Stock) As Integer
        Return x.Price.CompareTo(y.Price)
    End Function

    'Sorts by PE
    Public Function ComparePeRation(ByVal x As Stock, ByVal y As Stock) As Integer
        Return x.PeRatio.CompareTo(y.PeRatio)
    End Function

    Private Sub btnSortByStock_Click(sender As Object, e As EventArgs) Handles btnSortByStock.Click
        dgvStocks.Rows.Clear()
        cmbOrder.Text = ""

        stockList.Sort()

        If cmbOrder.Text = "Dec" Then 'Reverses list based on cmb input
            stockList.Reverse()
        End If

        For Each Stock In stockList
            dgvStocks.Rows.Add(Stock.StockSymbol, Stock.Price, Stock.Earnings, Stock.PeRatio)
            Debug.Write(Stock.StockSymbol)
        Next
    End Sub

    Private Sub btnSortByPrice_Click(sender As Object, e As EventArgs) Handles btnSortByPrice.Click
        dgvStocks.Rows.Clear()

        stockList.Sort(AddressOf ComparePrice)

        If cmbOrder.Text = "Dec" Then 'Reverses list based on cmb input
            stockList.Reverse()
        End If

        For Each Stock In stockList
            dgvStocks.Rows.Add(Stock.StockSymbol, Stock.Price, Stock.Earnings, Stock.PeRatio)
            Debug.Write(Stock.StockSymbol)
        Next
    End Sub

    Private Sub btnSortByPE_Click(sender As Object, e As EventArgs) Handles btnSortByPE.Click
        dgvStocks.Rows.Clear()
        stockList.Sort(AddressOf ComparePeRation)

        If cmbOrder.Text = "Dec" Then 'Reverses list based on cmb input
            stockList.Reverse()
        End If

        For Each Stock In stockList
            dgvStocks.Rows.Add(Stock.StockSymbol, Stock.Price, Stock.Earnings, Stock.PeRatio)
            Debug.Write(Stock.StockSymbol)
        Next
    End Sub

End Class
