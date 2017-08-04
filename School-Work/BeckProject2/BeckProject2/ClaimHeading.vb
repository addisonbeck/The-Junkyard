'Programmed By Addison Beck
Public Class ClaimHeading
    'Private adapter As New ClaimsDataSetTableAdapters.ClaimHeadingTableAdapter

    Public Property Claim_Heading_Id As Integer
    Public Property Claim_Number As Integer
    Public Property First_Name As String
    Public Property Last_Name As String
    Public Property Group_Number As Integer
    Public Property Total_Damages As Double
    Public Property Change_Reason As String

    'Public ReadOnly Property Items As DataTable
    '    Get
    '        Dim table As DataTable = adapter.GetData()
    '        Return table
    '    End Get
    'End Property

    'Public Function Add(ByVal Dept_Name As String, ByVal Num_Employees As Integer) As Boolean
    '    Return adapter.InsertQuery(Dept_Name, Num_Employees)
    'End Function

    'Public Function Edit(ByVal Dept_Id As Integer, ByVal Dept_Name As String, ByVal Num_Employees As Integer) As Boolean
    '    Return adapter.UpdateQuery(Dept_Name, Num_Employees, Dept_Id) > 0
    'End Function

    'Public Function Delete(ByVal Dept_Id As Integer) As Boolean
    '    Return adapter.DeleteQuery(Dept_Id)
    'End Function

    'Public Function Search(ByVal dept_id As Integer) As CompanyDataSet.DepartmentsRow
    '    Return adapter.GetData().FindByDept_Id(dept_id)
    'End Function

    Public Overrides Function ToString() As String
        Return "Heading ID: " & CStr(Claim_Heading_Id) & vbCrLf _
                & "Claim Number: " & CStr(Claim_Number) & vbCrLf _
                & "First Name: " & First_Name & vbCrLf _
                & "Last Name: " & Last_Name & vbCrLf _
                & "Group Number: " & CStr(Group_Number) & vbCrLf _
                & "Total Damages: " & CStr(Total_Damages) & vbCrLf _
                & "Change Reason: " & Change_Reason
    End Function

End Class
