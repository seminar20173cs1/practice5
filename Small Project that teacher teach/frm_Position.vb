Imports System.Data.SqlClient
Public Class frm_Position
    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Dim sql, constr As String

    Private Sub frm_Position_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        sql = "INSERT INTO tb_Pos Values ('" & txtPosition.Text & "')"
        constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=EmployeeDB;Integrated Security=True"
        cn = New SqlConnection(constr)
        cn.Open()
        cm = New SqlCommand(sql, cn)
        If (cm.ExecuteNonQuery() = 1) Then
            MsgBox("Data Save")
        End If

        txtPosition.Clear()
    End Sub
End Class