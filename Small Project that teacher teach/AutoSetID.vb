Imports System.Data.SqlClient
Public Class AutoSetID
    Public Sub SetConnection(ByVal constr As String)

    End Sub
    Public Sub ExecuteConnection()

    End Sub
    Public Function SetID(ByVal constr As String, ByVal colummID As String, ByVal TableName As String, ByVal style As String) As String
        Dim CN As New SqlConnection(constr)
        Dim dr As SqlDataReader
        Dim autoSql As String
        Dim id As String
        Dim subid As String
        autoSql = "SELECT " & colummID & " FROM " & TableName & " ORDER BY " & colummID & " DESC "
        CN.Open()
        Dim CMAuto As New SqlCommand(autoSql, CN)
        dr = CMAuto.ExecuteReader()
        dr.Read()
        id = dr(0).ToString
        subid = id.Substring(2, 3)
        Return style & (subid + 1)
    End Function

End Class
