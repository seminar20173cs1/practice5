Imports System.Data.SqlClient
Public Class testCommand
    Dim aa As testclass = New testclass()
    Dim bb As tryClass = New tryClass()
    Dim cc As tryClass = New tryClass()


    Dim cn As SqlConnection
    Dim cm As SqlCommand
    Dim da As SqlDataAdapter
    Dim constr As String = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=EmployeeDB;Integrated Security=True"
    Dim sql As String = "SELECT EmployeeID FROM tb_Employee ORDER BY EmployeeID DESC"
    Dim ds As New DataSet
    Dim dr As SqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '   cc.CallConnection()
        '  Dim a As Double = Double.Parse(TextBox1.Text)


        'Dim b As Double = Double.Parse(TextBox2.Text)
        'MessageBox.Show(bb.calSquare(a, b))
    End Sub
    Class testclass
        Public number1 As Integer

        Public Function calSquare(ByVal a As Double, ByVal b As Double) As Double
            Return a * b
        End Function



    End Class
    Dim dd As tryClass = New tryClass()
    Dim ee As names = New names()
    Dim id As String
    Public subid As String
    Private Sub testCommand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CallEmployeeID()
    End Sub
    Public Sub CallEmployeeID()
        cn = New SqlConnection(constr)
        cn.Open()
        cm = New SqlCommand(sql, cn)
        dr = cm.ExecuteReader
        dr.Read()
        id = dr(0).ToString
        subid = id.Substring(2, 3)
        '    txtCallID.Text = id
        '   txtNewID.Text = "EP00" & (subid + 1)
    End Sub
End Class