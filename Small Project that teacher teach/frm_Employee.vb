Imports System.Data.SqlClient
Public Class frm_Employee
    Dim sql As String
    Dim cn As SqlConnection
    Dim cm, cm2 As SqlCommand
    Dim da, da2 As SqlDataAdapter
    Dim ds, ds2, ds3 As New DataSet
    Dim sqlID As String = "SELECT EmployeeID FROM tb_Employee ORDER BY EmployeeID DESC"
    ' Dim ds As New DataSet
    Dim dr As SqlDataReader
    ' Dim SQLk As New SQLControl
    Dim dob As String
    Dim id As String
    Dim subID As String
    Dim constr As String = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=EmployeeDB;Integrated Security=True"
    Dim SetAutoID As AutoSetID = New AutoSetID()
    'Public Sub CallEmployeeID()
    '    cn = New SqlConnection(constr)
    '    cn.Open()
    '    cm = New SqlCommand(sqlID, cn)
    '    dr = cm.ExecuteReader
    '    dr.Read()
    '    id = dr(0).ToString
    '    subID = id.Substring(2, 3)
    '    '    txtCallID.Text = id
    '    txtemID.Enabled = False
    '    txtemID.Text = "EP00" & (subID + 1)
    'End Sub
    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click

        constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=EmployeeDB;Integrated Security=True"


        sql = "INSERT INTO tb_Employee Values ('" & txtemID.Text & "', "
        sql &= "" & " N'" & sex.ToString & "'," & " N'" & txtname.Text & "'," & " N'" & txtlastname.Text & "',"
        sql &= "'" & txttel.Text & "','" & txtemail.Text & "','" & dtp.Value.ToString("MM/dd/yyyy") & "',"
        sql &= "'" & txtvillage.Text & "','" & txtdistrict.Text & "',"
        sql &= "'" & cbprovincer.SelectedValue & "','" & cbposition.SelectedValue & "')"
        cn = New SqlConnection(constr)
        cn.Open()
        cm = New SqlCommand(sql, cn)
        If (cm.ExecuteNonQuery() = 1) Then
            MsgBox("Save")
            '   CallEmployeeID()
            txtemID.Text = SetAutoID.SetID(constr, "EmployeeID", "tb_Employee", "EP00")
            ClearTextBox()
        Else
            MsgBox("Error")
        End If
        '    MsgBox("Data Save!!!")
        'Else
        '    MsgBox("Error Ocurre")
        '  End If

        'If cn.State = ConnectionState.Open Then
        '    MsgBox("Success!")
        'End If
        'constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=EmployeeDB;Integrated Security=True"
        'sql = "INSERT INTO tb_Employee(EmployeeID, EmployeeSex, EmployeeName, EmployeeLastName)  Values ('" & txtemID.Text & "','" & sex & "','" & txtname.Text & "','" & txtlastname.Text & "')"
        'cn = New SqlConnection(constr)
        'cn.Open()
        'cm = New SqlCommand(sql, cn)
        'cm.ExecuteNonQuery()
        '  CallEmployeeID()
        txtemID.Text = SetAutoID.SetID(constr, "EmployeeID", "tb_Employee", "EP00")
        ClearTextBox()
        Showdata()
    End Sub
    Dim sex As String

    Public Sub ClearTextBox()
        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = ""
            End If
        Next
    End Sub
    Private Sub rbmale_CheckedChanged(sender As Object, e As EventArgs) Handles rbmale.CheckedChanged
        If rbfemale.Checked Then
            sex = "ຍິງ"
        End If
        If rbmale.Checked Then
            sex = "ຊາຍ"
        End If
    End Sub

    Private Sub rbfemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbfemale.CheckedChanged
        If rbfemale.Checked Then
            sex = "ຍິງ"
        End If
        If rbmale.Checked Then
            sex = "ຊາຍ"
        End If
    End Sub

    Private Sub cbprovincer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbprovincer.SelectedIndexChanged

    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    '   Dim constr, sql As String
    Dim userdelete As String
    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        sql = "DELETE FROM tb_employee WHERE EmployeeID = '" & userdelete & "'"
        cn = New SqlConnection("Data Source=DESKTOP-RQOFH4P;Initial Catalog=EmployeeDB;Integrated Security=True")
        cn.Open()
        cm = New SqlCommand(sql, cn)
        Dim result As Integer = MessageBox.Show("Do you really want to Delete '" & userdelete & "'", "caption", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            MessageBox.Show("Cancel pressed")
            '  ElseIf result = DialogResult.No Then
            '     MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            cm.ExecuteNonQuery()
        End If
        Showdata()


    End Sub

    Dim sqlpos As String = "Select * from tb_pos"

    Private Sub btclear_Click(sender As Object, e As EventArgs) Handles btclear.Click
        ClearTextBox()
        txtemID.Text = SetAutoID.SetID(constr, "EmployeeID", "tb_Employee")
        '  CallEmployeeID()
    End Sub

    Private Sub btRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        Showdata()
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=EmployeeDB;Integrated Security=True"
        sql = "SELECT        dbo.tb_Employee.EmployeeID, dbo.tb_Employee.EmployeeSex, dbo.tb_Employee.EmployeeName, dbo.tb_Employee.EmployeeLastName, dbo.tb_Employee.Tel, dbo.tb_Employee.Email, dbo.tb_Employee.Dob, 
                         dbo.tb_Employee.Village, dbo.tb_Employee.District, dbo.tb_pos.Position, dbo.tb_Pro.Province
FROM            dbo.tb_Employee INNER JOIN
                         dbo.tb_pos ON dbo.tb_Employee.PositionID = dbo.tb_pos.PositionID INNER JOIN
                         dbo.tb_Pro ON dbo.tb_Employee.ProvinceID = dbo.tb_Pro.ProvinceID
where EmployeeID like('%" & txtSearch.Text & "%') or EmployeeName like('%" & txtSearch.Text & "%');

"
        cn = New SqlConnection(constr)
        cn.Open()
        cm = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cm)
        ds3.Clear()
        da.Fill(ds3, "a")
        With DataGridView1
            .DataSource = ds3.Tables("a")
            .Columns(0).HeaderText = "ລະຫັດພະນັກງານ"
        End With
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=EmployeeDB;Integrated Security=True"
        sql = "SELECT        dbo.tb_Employee.EmployeeID, dbo.tb_Employee.EmployeeSex, dbo.tb_Employee.EmployeeName, dbo.tb_Employee.EmployeeLastName, dbo.tb_Employee.Tel, dbo.tb_Employee.Email, dbo.tb_Employee.Dob, 
                         dbo.tb_Employee.Village, dbo.tb_Employee.District, dbo.tb_pos.Position, dbo.tb_Pro.Province
FROM            dbo.tb_Employee INNER JOIN
                         dbo.tb_pos ON dbo.tb_Employee.PositionID = dbo.tb_pos.PositionID INNER JOIN
                         dbo.tb_Pro ON dbo.tb_Employee.ProvinceID = dbo.tb_Pro.ProvinceID
where EmployeeID like('%" & txtSearch.Text & "%') or EmployeeName like('%" & txtSearch.Text & "%');

"
        cn = New SqlConnection(constr)
        cn.Open()
        cm = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cm)
        ds3.Clear()
        da.Fill(ds3, "a")
        With DataGridView1
            .DataSource = ds3.Tables("a")
            .Columns(0).HeaderText = "ລະຫັດພະນັກງານ"
        End With
    End Sub

    Private Sub frm_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Showdata()
        ' CallEmployeeID()
        txtemID.Text = SetAutoID.SetID(constr, "EmployeeID", "tb_Employee")
        dtp.CustomFormat = "dd/MM/yyyy"
        dtp.Format = DateTimePickerFormat.Custom

        constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=EmployeeDB;Integrated Security=True"
        cn = New SqlConnection(constr)
        cn.Open()
        sql = "Select * from tb_Pro"
        cm = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cm)
        da.Fill(ds, "pro")
        With cbprovincer
            .DisplayMember = "Province"
            .ValueMember = "ProvinceID"
            cbprovincer.DataSource = ds.Tables("pro")
        End With
        cm = New SqlCommand(sqlpos, cn)
        da = New SqlDataAdapter(cm)
        da.Fill(ds2)
        With cbposition
            .DisplayMember = "Position"
            .ValueMember = "PositionID"
            cbposition.DataSource = ds2.Tables(0)
        End With
    End Sub
    Private Sub Showdata()
        constr = "Data Source=DESKTOP-RQOFH4P;Initial Catalog=EmployeeDB;Integrated Security=True"
        sql = "SELECT        dbo.tb_Employee.EmployeeID, dbo.tb_Employee.EmployeeSex, dbo.tb_Employee.EmployeeName, dbo.tb_Employee.EmployeeLastName, dbo.tb_Employee.Tel, dbo.tb_Employee.Email, dbo.tb_Employee.Dob, 
                         dbo.tb_Employee.Village, dbo.tb_Employee.District, dbo.tb_pos.Position, dbo.tb_Pro.Province
FROM            dbo.tb_Employee INNER JOIN
                         dbo.tb_pos ON dbo.tb_Employee.PositionID = dbo.tb_pos.PositionID INNER JOIN
                         dbo.tb_Pro ON dbo.tb_Employee.ProvinceID = dbo.tb_Pro.ProvinceID"
        cn = New SqlConnection(constr)
        cn.Open()
        cm = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cm)
        ds3.Clear()
        da.Fill(ds3, "a")
        With DataGridView1
            .DataSource = ds3.Tables("a")
            .Columns(0).HeaderText = "ລະຫັດພະນັກງານ"
        End With

    End Sub
    Dim usernameUpdate As String
    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        With DataGridView1
            userdelete = .Rows(e.RowIndex).Cells(0).Value
            usernameUpdate = .Rows(e.RowIndex).Cells(0).Value
            txtemID.Text = .Rows(e.RowIndex).Cells(0).Value
            If .Rows(e.RowIndex).Cells(1).Value = "ຍິງ" Then
                rbfemale.Checked = True
            ElseIf .Rows(e.RowIndex).Cells(1).Value = "ຊາຍ" Then
                rbmale.Checked = True
            End If
            txtname.Text = .Rows(e.RowIndex).Cells(2).Value
            txtlastname.Text = .Rows(e.RowIndex).Cells(3).Value
            txttel.Text = .Rows(e.RowIndex).Cells(4).Value
            txtemail.Text = .Rows(e.RowIndex).Cells(5).Value
            dtp.Text = Format(.Rows(e.RowIndex).Cells(6).Value, "MM/dd/yyyy")
            txtvillage.Text = .Rows(e.RowIndex).Cells(7).Value
            txtdistrict.Text = .Rows(e.RowIndex).Cells(8).Value
            cbprovincer.Text = .Rows(e.RowIndex).Cells(10).Value
            cbposition.Text = .Rows(e.RowIndex).Cells(9).Value
        End With

    End Sub

    Private Sub frm_Employee_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        ClearTextBox()
        'CallEmployeeID()
        txtemID.Text = SetAutoID.SetID(constr, "EmployeeID", "tb_Employee")
    End Sub


    Sub CheckID()

    End Sub

End Class