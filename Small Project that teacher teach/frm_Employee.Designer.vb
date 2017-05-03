<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btCanel = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtemID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.cbprovincer = New System.Windows.Forms.ComboBox()
        Me.cbposition = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtvillage = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdistrict = New System.Windows.Forms.TextBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btclear = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btCanel
        '
        Me.btCanel.Location = New System.Drawing.Point(453, 205)
        Me.btCanel.Name = "btCanel"
        Me.btCanel.Size = New System.Drawing.Size(75, 38)
        Me.btCanel.TabIndex = 15
        Me.btCanel.Text = "Cancel"
        Me.btCanel.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(372, 205)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 38)
        Me.btEdit.TabIndex = 14
        Me.btEdit.Text = "Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(291, 205)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 38)
        Me.btDelete.TabIndex = 13
        Me.btDelete.Text = "Delete"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(210, 205)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 38)
        Me.btSave.TabIndex = 12
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 29)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ລະຫັດ:"
        '
        'txtemID
        '
        Me.txtemID.Enabled = False
        Me.txtemID.Location = New System.Drawing.Point(117, 22)
        Me.txtemID.Name = "txtemID"
        Me.txtemID.Size = New System.Drawing.Size(100, 35)
        Me.txtemID.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ຊື່:"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(117, 107)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 35)
        Me.txtname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ນາມສະກຸນ:"
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(119, 151)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(100, 35)
        Me.txtlastname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ເພດ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ເບີໂທ:"
        '
        'txttel
        '
        Me.txttel.Location = New System.Drawing.Point(354, 22)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(100, 35)
        Me.txttel.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ອີເມວ:"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(354, 66)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 35)
        Me.txtemail.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(238, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 29)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "ວັນເດືອນປີເກີດ:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(477, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 29)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "ແຂວງ:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(477, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 29)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "ຕໍາແໜ່ງ:"
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Location = New System.Drawing.Point(119, 65)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(59, 33)
        Me.rbmale.TabIndex = 1
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "ຊາຍ"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(186, 65)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(49, 33)
        Me.rbfemale.TabIndex = 2
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "ຍິງ"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'cbprovincer
        '
        Me.cbprovincer.FormattingEnabled = True
        Me.cbprovincer.Location = New System.Drawing.Point(556, 73)
        Me.cbprovincer.Name = "cbprovincer"
        Me.cbprovincer.Size = New System.Drawing.Size(121, 37)
        Me.cbprovincer.TabIndex = 10
        '
        'cbposition
        '
        Me.cbposition.FormattingEnabled = True
        Me.cbposition.Location = New System.Drawing.Point(556, 126)
        Me.cbposition.Name = "cbposition"
        Me.cbposition.Size = New System.Drawing.Size(121, 37)
        Me.cbposition.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(294, 151)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 29)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "ບ້ານ:"
        '
        'txtvillage
        '
        Me.txtvillage.Location = New System.Drawing.Point(354, 145)
        Me.txtvillage.Name = "txtvillage"
        Me.txtvillage.Size = New System.Drawing.Size(100, 35)
        Me.txtvillage.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(481, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 29)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "ເມືອງ:"
        '
        'txtdistrict
        '
        Me.txtdistrict.Location = New System.Drawing.Point(556, 22)
        Me.txtdistrict.Name = "txtdistrict"
        Me.txtdistrict.Size = New System.Drawing.Size(100, 35)
        Me.txtdistrict.TabIndex = 9
        '
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(354, 105)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(100, 35)
        Me.dtp.TabIndex = 7
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 300)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(698, 111)
        Me.DataGridView1.TabIndex = 16
        '
        'btclear
        '
        Me.btclear.Location = New System.Drawing.Point(534, 205)
        Me.btclear.Name = "btclear"
        Me.btclear.Size = New System.Drawing.Size(75, 38)
        Me.btclear.TabIndex = 15
        Me.btclear.Text = "Clear"
        Me.btclear.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(54, 249)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(474, 35)
        Me.txtSearch.TabIndex = 17
        '
        'btRefresh
        '
        Me.btRefresh.Location = New System.Drawing.Point(74, 205)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(118, 38)
        Me.btRefresh.TabIndex = 18
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.UseVisualStyleBackColor = True
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(534, 249)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(143, 35)
        Me.btSearch.TabIndex = 19
        Me.btSearch.Text = "Search"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 423)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btSearch)
        Me.Controls.Add(Me.btRefresh)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.cbposition)
        Me.Controls.Add(Me.cbprovincer)
        Me.Controls.Add(Me.rbfemale)
        Me.Controls.Add(Me.rbmale)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdistrict)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtvillage)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtemID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btclear)
        Me.Controls.Add(Me.btCanel)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.btSave)
        Me.Font = New System.Drawing.Font("Saysettha OT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "frm_Employee"
        Me.Text = "da"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btCanel As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents btSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtemID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txttel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents cbprovincer As ComboBox
    Friend WithEvents cbposition As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtvillage As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtdistrict As TextBox
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btclear As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btRefresh As Button
    Friend WithEvents btSearch As Button
    Friend WithEvents Button1 As Button
End Class
