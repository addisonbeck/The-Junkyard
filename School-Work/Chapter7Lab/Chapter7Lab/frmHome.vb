Public Class frmHome

    Dim db As New StudentsClassesDataContext
    Dim studentQuery = From Students In db.Students 'Group Students By Students.LastName Into StudentGroup = Count()
    Dim coursesQuery = From Courses In db.Courses
    Dim selectedID As Integer

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectedID = 0
        dgvStudents.DataSource = studentQuery
        dgvCourses.DataSource = coursesQuery
    End Sub

    'Private Sub dgvStudents_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.RowEnter
    '    selectedID = CInt(dgvStudents.SelectedRows(0).Cells(0).Value)
    '    Dim q = From Courses In db.Courses Where Courses.Student_Id = selectedID
    'End Sub
End Class
