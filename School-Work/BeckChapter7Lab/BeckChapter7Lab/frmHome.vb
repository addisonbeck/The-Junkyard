Public Class frmHome

    Dim db As New StudentsClassSetDataContext
    Dim studentQuery = From Students In db.Students
                       Join Courses In db.Courses On Students.Id Equals Courses.Student_Id
                       Group Courses By Students.Id, Students.LastName, Students.Status, Students.Major Into Count()

    Dim coursesQuery = From Courses In db.Courses
    Dim selectedID As Integer

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        selectedID = 0
        dgvStudents.DataSource = studentQuery
        dgvCourses.DataSource = coursesQuery
    End Sub

    Private Sub dgvStudents_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.RowEnter
        Try
            selectedID = CInt(dgvStudents.SelectedRows(0).Cells(0).Value)
            Dim q = From Courses In db.Courses Where Courses.Student_Id = selectedID
            dgvStudents.DataSource = studentQuery
            dgvCourses.DataSource = q
        Catch
            dgvStudents.DataSource = studentQuery
            dgvCourses.DataSource = coursesQuery
        End Try
    End Sub
End Class

