'Programmed By: Addison Beck

'Known issues: I couldn't figure out how to effectivly write to a file using multiple properites. 
'   I didn't start writing that part until it was too late to ask about, and couldn't find anything online about it.

Public Class frmHome

    Dim Song As New Song
    Dim SongList As New List(Of Song)()

    'Add Objects to Inventory (and Data file) 
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddSong()
        RefreshList()
        ClearFields()
    End Sub

    'Edit Existing Objects in Inventory (and Data file)
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        SaveEdit()
        RefreshList()
        ClearFields()
    End Sub

    'Delete Objects from Inventory (and Data file
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteSong()
        RefreshList()
        ClearFields()
    End Sub

    'Display All Objects In order Using the implemented “Compare To” method
    Private Sub btnSortByTitle_Click(sender As Object, e As EventArgs) Handles btnSortByTitle.Click
        ClearFields()
        SongList.Sort()
        RefreshList()
    End Sub

    'Display All Objects in order using the designed comparator method
    Private Sub btnSortByArtist_Click(sender As Object, e As EventArgs) Handles btnSortByArtist.Click
        ClearFields()
        SongList.Sort(AddressOf CompareArtist)
        RefreshList()
    End Sub

    'Search for specific Object (must use equality method)
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchForItem()
    End Sub

    Public Sub RefreshList()
        lstList.Items.Clear()

        For Each Song In SongList
            lstList.Items.Add(Song.Artist + " " + Song.Title)
        Next
    End Sub

    Private Sub ClearFields()
        txtTitle.Clear()
        txtArtist.Clear()
        txtAlbum.Clear()
        txtYear.Clear()
        txtTrackNumber.Clear()
        txtSelectionOutput.Clear()
    End Sub

    'Add Objects to Inventory (and Data file) 
    Public Sub AddSong()
        Dim title As String = txtTitle.Text
        Dim artist As String = txtArtist.Text
        Dim album As String = txtArtist.Text

        Try 'Input Validation / Error Correction and Detection
            Dim x As Integer = CInt(txtYear.Text)
            Exit Try
        Catch ex As Exception
            MsgBox("Please Enter A Valid Year")
            Return
        End Try

        Try
            Dim y As Integer = CInt(txtTrackNumber.Text)
        Catch ex As Exception
            MsgBox("Please Enter A Valid Track Number")
            Return
        End Try

        Dim year As Integer = CInt(txtYear.Text)
        Dim trackNumber As Integer = CInt(txtTrackNumber.Text)

        SongList.Add(New Song() With {
          .Title = title,
          .Artist = artist,
          .Album = album,
          .Year = year,
          .TrackNumber = trackNumber
            })
    End Sub

    Private Sub lstList_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstList.SelectedValueChanged
        Dim listIndex As Integer = lstList.SelectedIndex

        If listIndex = -1 Then
            listIndex = 0
        End If

        txtTitle.Text = SongList(listIndex).Title
        txtArtist.Text = SongList(listIndex).Artist
        txtAlbum.Text = SongList(listIndex).Album
        txtYear.Text = SongList(listIndex).Year
        txtTrackNumber.Text = SongList(listIndex).TrackNumber

        txtSelectionOutput.Text = SongList(listIndex).ToString

    End Sub

    'Edit Existing Objects in Inventory (and Data file)
    Private Sub SaveEdit()
        Dim title As String = txtTitle.Text
        Dim artist As String = txtArtist.Text
        Dim album As String = txtArtist.Text

        Try 'Input Validation / Error Correction and Detection
            Dim x As Integer = CInt(txtYear.Text)
            Exit Try
        Catch ex As Exception
            MsgBox("Please Enter A Valid Year")
            Return
        End Try

        Try
            Dim y As Integer = CInt(txtTrackNumber.Text)
        Catch ex As Exception
            MsgBox("Please Enter A Valid Track Number")
            Return
        End Try

        Dim year As Integer = CInt(txtYear.Text)
        Dim trackNumber As Integer = CInt(txtTrackNumber.Text)

        Dim listIndex As Integer = lstList.SelectedIndex

        If listIndex = -1 Then
            listIndex = 0
        End If

        SongList(listIndex).Title = title
        SongList(listIndex).Artist = artist
        SongList(listIndex).Album = album
        SongList(listIndex).Year = CInt(year)
        SongList(listIndex).TrackNumber = CInt(trackNumber)
    End Sub

    'Delete Objects from Inventory (And Data file)
    Private Sub DeleteSong()
        Dim listIndex As Integer = lstList.SelectedIndex

        If listIndex = -1 Then
            listIndex = 0
        End If

        SongList.RemoveAt(listIndex)
    End Sub

    'Search for specific Object (must use equality method)
    Private Sub SearchForItem()

        Dim i As Integer
        Dim k As Integer
        Dim input As String = txtTitle.Text

        For i = 0 To SongList.Count - 1
            If SongList(i).Title.Equals(input) Then
                k = i
            End If
        Next

        lstList.SelectedIndex = k

    End Sub

    Public Function CompareArtist(ByVal x As Song, ByVal y As Song) As Integer
        Return x.Artist.CompareTo(y.Artist)
    End Function

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\abeck\Documents\USA\Spring2017\BeckProject1\BeckProject1\TextFile\Data.txt")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        SongList.Add(New Song() With {
                             .Title = currentField,
                             .Artist = "",
                             .Album = "",
                             .Year = 0,
                             .TrackNumber = 0
                            })
                    Next
                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using

        RefreshList()
    End Sub

    Private Sub frmHome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim sb As New System.Text.StringBuilder()

        For Each o As Object In lstList.Items
            sb.AppendLine(o)
        Next

        System.IO.File.WriteAllText("C:\Users\abeck\Documents\USA\Spring2017\BeckProject1\BeckProject1\TextFile\Data.txt", sb.ToString())
    End Sub

End Class
