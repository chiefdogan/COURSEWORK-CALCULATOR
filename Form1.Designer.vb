<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCA))
        Me.btnCA = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txttest1 = New System.Windows.Forms.TextBox()
        Me.txttest2 = New System.Windows.Forms.TextBox()
        Me.txtAssignment1 = New System.Windows.Forms.TextBox()
        Me.txtCA = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtReg_no = New System.Windows.Forms.TextBox()
        Me.txtAdmin = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.txtAdditional = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGrid = New System.Windows.Forms.DataGridView()
        Me.StudIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudFullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudTest1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudTest2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudAss1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudAss2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudCADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddMarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollegeDBDataSet2 = New FUNCTION_CA.CollegeDBDataSet2()
        Me.txtAssignment2 = New System.Windows.Forms.TextBox()
        Me.txtFullname = New System.Windows.Forms.TextBox()
        Me.btnStore = New System.Windows.Forms.Button()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.txtRich = New System.Windows.Forms.RichTextBox()
        Me.CollegeDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollegeDBDataSet = New FUNCTION_CA.CollegeDBDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.Label()
        Me.txtcheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtlink = New System.Windows.Forms.LinkLabel()
        Me.GradeDetailTableAdapter = New FUNCTION_CA.CollegeDBDataSet2TableAdapters.GradeDetailTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradeDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeDBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollegeDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCA
        '
        Me.btnCA.Location = New System.Drawing.Point(228, 231)
        Me.btnCA.Name = "btnCA"
        Me.btnCA.Size = New System.Drawing.Size(94, 34)
        Me.btnCA.TabIndex = 0
        Me.btnCA.Text = "Calculate CA"
        Me.btnCA.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(385, 231)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 34)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Details"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(471, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Continous Assessment Calculations"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Marks from Test 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter Marks from Test 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Enter Marks  Obtained from Assignment 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Student Continous Assessment is"
        '
        'txttest1
        '
        Me.txttest1.Location = New System.Drawing.Point(10, 48)
        Me.txttest1.Name = "txttest1"
        Me.txttest1.Size = New System.Drawing.Size(202, 20)
        Me.txttest1.TabIndex = 7
        '
        'txttest2
        '
        Me.txttest2.Location = New System.Drawing.Point(10, 77)
        Me.txttest2.Name = "txttest2"
        Me.txttest2.Size = New System.Drawing.Size(202, 20)
        Me.txttest2.TabIndex = 8
        '
        'txtAssignment1
        '
        Me.txtAssignment1.Location = New System.Drawing.Point(10, 103)
        Me.txtAssignment1.Name = "txtAssignment1"
        Me.txtAssignment1.Size = New System.Drawing.Size(202, 20)
        Me.txtAssignment1.TabIndex = 9
        '
        'txtCA
        '
        Me.txtCA.Location = New System.Drawing.Point(11, 158)
        Me.txtCA.Name = "txtCA"
        Me.txtCA.Size = New System.Drawing.Size(201, 20)
        Me.txtCA.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.txtReg_no)
        Me.GroupBox1.Controls.Add(Me.txtAdmin)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.btnupdate)
        Me.GroupBox1.Controls.Add(Me.btnHide)
        Me.GroupBox1.Controls.Add(Me.txtAdditional)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtGrid)
        Me.GroupBox1.Controls.Add(Me.txtAssignment2)
        Me.GroupBox1.Controls.Add(Me.txtFullname)
        Me.GroupBox1.Controls.Add(Me.btnStore)
        Me.GroupBox1.Controls.Add(Me.btnRetrieve)
        Me.GroupBox1.Controls.Add(Me.txtRich)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCA)
        Me.GroupBox1.Controls.Add(Me.txtCA)
        Me.GroupBox1.Controls.Add(Me.txtAssignment1)
        Me.GroupBox1.Controls.Add(Me.txttest2)
        Me.GroupBox1.Controls.Add(Me.txttest1)
        Me.GroupBox1.Location = New System.Drawing.Point(283, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1005, 511)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtReg_no
        '
        Me.txtReg_no.Location = New System.Drawing.Point(9, 0)
        Me.txtReg_no.Name = "txtReg_no"
        Me.txtReg_no.Size = New System.Drawing.Size(202, 20)
        Me.txtReg_no.TabIndex = 22
        '
        'txtAdmin
        '
        Me.txtAdmin.Location = New System.Drawing.Point(12, 273)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(200, 20)
        Me.txtAdmin.TabIndex = 21
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(11, 247)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 20
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(881, 231)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 34)
        Me.btnupdate.TabIndex = 19
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(655, 231)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(86, 34)
        Me.btnHide.TabIndex = 18
        Me.btnHide.Text = "Hide Record"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'txtAdditional
        '
        Me.txtAdditional.Location = New System.Drawing.Point(10, 212)
        Me.txtAdditional.Name = "txtAdditional"
        Me.txtAdditional.Size = New System.Drawing.Size(201, 20)
        Me.txtAdditional.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(537, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Output Result "
        '
        'txtGrid
        '
        Me.txtGrid.AutoGenerateColumns = False
        Me.txtGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.txtGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudIDDataGridViewTextBoxColumn, Me.StudFullnameDataGridViewTextBoxColumn, Me.StudTest1DataGridViewTextBoxColumn, Me.StudTest2DataGridViewTextBoxColumn, Me.StudAss1DataGridViewTextBoxColumn, Me.StudAss2DataGridViewTextBoxColumn, Me.StudCADataGridViewTextBoxColumn, Me.AddMarksDataGridViewTextBoxColumn})
        Me.txtGrid.DataSource = Me.GradeDetailBindingSource
        Me.txtGrid.Location = New System.Drawing.Point(228, 271)
        Me.txtGrid.Name = "txtGrid"
        Me.txtGrid.Size = New System.Drawing.Size(752, 217)
        Me.txtGrid.TabIndex = 16
        '
        'StudIDDataGridViewTextBoxColumn
        '
        Me.StudIDDataGridViewTextBoxColumn.DataPropertyName = "studID"
        Me.StudIDDataGridViewTextBoxColumn.HeaderText = "studID"
        Me.StudIDDataGridViewTextBoxColumn.Name = "StudIDDataGridViewTextBoxColumn"
        '
        'StudFullnameDataGridViewTextBoxColumn
        '
        Me.StudFullnameDataGridViewTextBoxColumn.DataPropertyName = "studFullname"
        Me.StudFullnameDataGridViewTextBoxColumn.HeaderText = "studFullname"
        Me.StudFullnameDataGridViewTextBoxColumn.Name = "StudFullnameDataGridViewTextBoxColumn"
        '
        'StudTest1DataGridViewTextBoxColumn
        '
        Me.StudTest1DataGridViewTextBoxColumn.DataPropertyName = "studTest1"
        Me.StudTest1DataGridViewTextBoxColumn.HeaderText = "studTest1"
        Me.StudTest1DataGridViewTextBoxColumn.Name = "StudTest1DataGridViewTextBoxColumn"
        '
        'StudTest2DataGridViewTextBoxColumn
        '
        Me.StudTest2DataGridViewTextBoxColumn.DataPropertyName = "studTest2"
        Me.StudTest2DataGridViewTextBoxColumn.HeaderText = "studTest2"
        Me.StudTest2DataGridViewTextBoxColumn.Name = "StudTest2DataGridViewTextBoxColumn"
        '
        'StudAss1DataGridViewTextBoxColumn
        '
        Me.StudAss1DataGridViewTextBoxColumn.DataPropertyName = "studAss1"
        Me.StudAss1DataGridViewTextBoxColumn.HeaderText = "studAss1"
        Me.StudAss1DataGridViewTextBoxColumn.Name = "StudAss1DataGridViewTextBoxColumn"
        '
        'StudAss2DataGridViewTextBoxColumn
        '
        Me.StudAss2DataGridViewTextBoxColumn.DataPropertyName = "studAss2"
        Me.StudAss2DataGridViewTextBoxColumn.HeaderText = "studAss2"
        Me.StudAss2DataGridViewTextBoxColumn.Name = "StudAss2DataGridViewTextBoxColumn"
        '
        'StudCADataGridViewTextBoxColumn
        '
        Me.StudCADataGridViewTextBoxColumn.DataPropertyName = "studCA"
        Me.StudCADataGridViewTextBoxColumn.HeaderText = "studCA"
        Me.StudCADataGridViewTextBoxColumn.Name = "StudCADataGridViewTextBoxColumn"
        '
        'AddMarksDataGridViewTextBoxColumn
        '
        Me.AddMarksDataGridViewTextBoxColumn.DataPropertyName = "addMarks"
        Me.AddMarksDataGridViewTextBoxColumn.HeaderText = "addMarks"
        Me.AddMarksDataGridViewTextBoxColumn.Name = "AddMarksDataGridViewTextBoxColumn"
        '
        'GradeDetailBindingSource
        '
        Me.GradeDetailBindingSource.DataMember = "GradeDetail"
        Me.GradeDetailBindingSource.DataSource = Me.CollegeDBDataSet2
        '
        'CollegeDBDataSet2
        '
        Me.CollegeDBDataSet2.DataSetName = "CollegeDBDataSet2"
        Me.CollegeDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtAssignment2
        '
        Me.txtAssignment2.Location = New System.Drawing.Point(10, 129)
        Me.txtAssignment2.Name = "txtAssignment2"
        Me.txtAssignment2.Size = New System.Drawing.Size(202, 20)
        Me.txtAssignment2.TabIndex = 15
        '
        'txtFullname
        '
        Me.txtFullname.Location = New System.Drawing.Point(9, 22)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(202, 20)
        Me.txtFullname.TabIndex = 14
        '
        'btnStore
        '
        Me.btnStore.Location = New System.Drawing.Point(766, 231)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(94, 34)
        Me.btnStore.TabIndex = 13
        Me.btnStore.Text = "Store Record in Database"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(540, 231)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(94, 34)
        Me.btnRetrieve.TabIndex = 12
        Me.btnRetrieve.Text = "Retrieve Record from Database"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'txtRich
        '
        Me.txtRich.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRich.Location = New System.Drawing.Point(228, 32)
        Me.txtRich.Name = "txtRich"
        Me.txtRich.Size = New System.Drawing.Size(752, 193)
        Me.txtRich.TabIndex = 11
        Me.txtRich.Text = ""
        '
        'CollegeDBDataSetBindingSource
        '
        Me.CollegeDBDataSetBindingSource.DataSource = Me.CollegeDBDataSet
        Me.CollegeDBDataSetBindingSource.Position = 0
        '
        'CollegeDBDataSet
        '
        Me.CollegeDBDataSet.DataSetName = "CollegeDBDataSet"
        Me.CollegeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.txtcheck)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 488)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(48, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Enter student Reg_no"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(51, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Admin Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Enter Your Email Here"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(70, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Check for any Additional Marks..?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Display Additional Marks"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(202, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Enter Marks  Obtained from Assignment 2"
        '
        'TextBox1
        '
        Me.TextBox1.AutoSize = True
        Me.TextBox1.Location = New System.Drawing.Point(51, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 13)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "Enter student Fullname"
        '
        'txtcheck
        '
        Me.txtcheck.AutoSize = True
        Me.txtcheck.Location = New System.Drawing.Point(49, 190)
        Me.txtcheck.Name = "txtcheck"
        Me.txtcheck.Size = New System.Drawing.Size(15, 14)
        Me.txtcheck.TabIndex = 7
        Me.txtcheck.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.txtlink)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1239, 55)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'txtlink
        '
        Me.txtlink.AutoSize = True
        Me.txtlink.Location = New System.Drawing.Point(1201, 16)
        Me.txtlink.Name = "txtlink"
        Me.txtlink.Size = New System.Drawing.Size(32, 13)
        Me.txtlink.TabIndex = 15
        Me.txtlink.TabStop = True
        Me.txtlink.Text = "close"
        '
        'GradeDetailTableAdapter
        '
        Me.GradeDetailTableAdapter.ClearBeforeFill = True
        '
        'formCA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1275, 562)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formCA"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Function CA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradeDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollegeDBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollegeDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollegeDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCA As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txttest1 As System.Windows.Forms.TextBox
    Friend WithEvents txttest2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAssignment1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtlink As System.Windows.Forms.LinkLabel
    Friend WithEvents txtFullname As System.Windows.Forms.TextBox
    Friend WithEvents btnStore As System.Windows.Forms.Button
    Friend WithEvents btnRetrieve As System.Windows.Forms.Button
    Friend WithEvents txtRich As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.Label
    Friend WithEvents txtcheck As System.Windows.Forms.CheckBox
    Friend WithEvents txtAssignment2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents txtAdditional As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CollegeDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CollegeDBDataSet As FUNCTION_CA.CollegeDBDataSet
    Friend WithEvents CollegeDBDataSet2 As FUNCTION_CA.CollegeDBDataSet2
    Friend WithEvents GradeDetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GradeDetailTableAdapter As FUNCTION_CA.CollegeDBDataSet2TableAdapters.GradeDetailTableAdapter
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAdmin As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtReg_no As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents StudIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudFullnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudTest1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudTest2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudAss1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudAss2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudCADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddMarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
