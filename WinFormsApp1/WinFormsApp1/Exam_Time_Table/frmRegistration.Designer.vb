<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        txtPIN = New TextBox()
        Panel4 = New Panel()
        Label18 = New Label()
        cmblev = New ComboBox()
        Label17 = New Label()
        cmbdept = New ComboBox()
        Label16 = New Label()
        cmbfac = New ComboBox()
        txtCardNo = New TextBox()
        Label12 = New Label()
        cmbPayrollType = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        txtSSN = New MaskedTextBox()
        Label8 = New Label()
        chkActive = New CheckBox()
        btnCheckAvailability = New GelButtons.GelButton()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        txtContactNo = New TextBox()
        txtEmailID = New TextBox()
        txtName = New TextBox()
        txtPassword = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        cmbUserType = New ComboBox()
        Label3 = New Label()
        txtUserID = New TextBox()
        txtlev3 = New TextBox()
        Panel3 = New Panel()
        btnDelete = New GelButtons.GelButton()
        btnSave = New GelButtons.GelButton()
        btnUpdate = New GelButtons.GelButton()
        btnNew = New GelButtons.GelButton()
        Label15 = New Label()
        dgw = New DataGridView()
        txtCNo = New TextBox()
        txtlev2 = New TextBox()
        CheckBox1 = New CheckBox()
        Label14 = New Label()
        Label9 = New Label()
        txtlev1 = New TextBox()
        chkBackoffice = New CheckBox()
        Label13 = New Label()
        chkCredit = New CheckBox()
        chkBill = New CheckBox()
        chksales = New CheckBox()
        chkSalesList = New CheckBox()
        chkquotation = New CheckBox()
        txtEmail = New TextBox()
        Panel2 = New Panel()
        lblUser = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        btnCancel = New Button()
        Description = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewCheckBoxColumn()
        Column18 = New DataGridViewTextBoxColumn()
        Column19 = New DataGridViewTextBoxColumn()
        Column20 = New DataGridViewTextBoxColumn()
        Column21 = New DataGridViewTextBoxColumn()
        Column22 = New DataGridViewTextBoxColumn()
        Column23 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgw, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(txtPIN)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(txtlev3)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(dgw)
        Panel1.Controls.Add(txtCNo)
        Panel1.Controls.Add(txtlev2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(txtlev1)
        Panel1.Controls.Add(chkBackoffice)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(chkCredit)
        Panel1.Controls.Add(chkBill)
        Panel1.Controls.Add(chksales)
        Panel1.Controls.Add(chkSalesList)
        Panel1.Controls.Add(chkquotation)
        Panel1.Location = New Point(7, 58)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1129, 596)
        Panel1.TabIndex = 2
        ' 
        ' txtPIN
        ' 
        txtPIN.Location = New Point(980, 246)
        txtPIN.Margin = New Padding(4, 3, 4, 3)
        txtPIN.Name = "txtPIN"
        txtPIN.Size = New Size(129, 23)
        txtPIN.TabIndex = 7
        txtPIN.Visible = False
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label18)
        Panel4.Controls.Add(cmblev)
        Panel4.Controls.Add(Label17)
        Panel4.Controls.Add(cmbdept)
        Panel4.Controls.Add(Label16)
        Panel4.Controls.Add(cmbfac)
        Panel4.Controls.Add(txtCardNo)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(cmbPayrollType)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(txtSSN)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(chkActive)
        Panel4.Controls.Add(btnCheckAvailability)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(txtContactNo)
        Panel4.Controls.Add(txtEmailID)
        Panel4.Controls.Add(txtName)
        Panel4.Controls.Add(txtPassword)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(cmbUserType)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(txtUserID)
        Panel4.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel4.Location = New Point(7, 321)
        Panel4.Margin = New Padding(4, 3, 4, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(966, 269)
        Panel4.TabIndex = 0
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(345, 160)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(39, 15)
        Label18.TabIndex = 43
        Label18.Text = "Level:"
        ' 
        ' cmblev
        ' 
        cmblev.DropDownStyle = ComboBoxStyle.DropDownList
        cmblev.FormattingEnabled = True
        cmblev.Items.AddRange(New Object() {"Admin", "Cashier", "Store Manager", "Inventory Manager", "Store Keeper", "Employee", "Security Guard"})
        cmblev.Location = New Point(348, 181)
        cmblev.Margin = New Padding(4, 3, 4, 3)
        cmblev.Name = "cmblev"
        cmblev.Size = New Size(182, 23)
        cmblev.TabIndex = 42
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(346, 110)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(72, 15)
        Label17.TabIndex = 41
        Label17.Text = "Department"
        ' 
        ' cmbdept
        ' 
        cmbdept.DropDownStyle = ComboBoxStyle.DropDownList
        cmbdept.FormattingEnabled = True
        cmbdept.Items.AddRange(New Object() {"Admin", "Cashier", "Store Manager", "Inventory Manager", "Store Keeper", "Employee", "Security Guard"})
        cmbdept.Location = New Point(349, 130)
        cmbdept.Margin = New Padding(4, 3, 4, 3)
        cmbdept.Name = "cmbdept"
        cmbdept.Size = New Size(182, 23)
        cmbdept.TabIndex = 40
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(345, 57)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(45, 15)
        Label16.TabIndex = 39
        Label16.Text = "Faculty"
        ' 
        ' cmbfac
        ' 
        cmbfac.DropDownStyle = ComboBoxStyle.DropDownList
        cmbfac.FormattingEnabled = True
        cmbfac.Items.AddRange(New Object() {"Admin", "Cashier", "Store Manager", "Inventory Manager", "Store Keeper", "Employee", "Security Guard"})
        cmbfac.Location = New Point(348, 77)
        cmbfac.Margin = New Padding(4, 3, 4, 3)
        cmbfac.Name = "cmbfac"
        cmbfac.Size = New Size(182, 23)
        cmbfac.TabIndex = 38
        ' 
        ' txtCardNo
        ' 
        txtCardNo.BackColor = Color.White
        txtCardNo.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCardNo.Location = New Point(548, 80)
        txtCardNo.Margin = New Padding(4, 3, 4, 3)
        txtCardNo.Name = "txtCardNo"
        txtCardNo.Size = New Size(209, 21)
        txtCardNo.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(545, 59)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 15)
        Label12.TabIndex = 22
        Label12.Text = "Card No. :"
        ' 
        ' cmbPayrollType
        ' 
        cmbPayrollType.AllowDrop = True
        cmbPayrollType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPayrollType.FormattingEnabled = True
        cmbPayrollType.Items.AddRange(New Object() {"Full Time", "Part Time"})
        cmbPayrollType.Location = New Point(548, 128)
        cmbPayrollType.Margin = New Padding(4, 3, 4, 3)
        cmbPayrollType.Name = "cmbPayrollType"
        cmbPayrollType.Size = New Size(209, 23)
        cmbPayrollType.TabIndex = 8
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(548, 110)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 15)
        Label11.TabIndex = 21
        Label11.Text = "Staff  Type :"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(8, 202)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(45, 15)
        Label10.TabIndex = 20
        Label10.Text = "SSN# :"
        ' 
        ' txtSSN
        ' 
        txtSSN.Location = New Point(146, 202)
        txtSSN.Margin = New Padding(4, 3, 4, 3)
        txtSSN.Mask = "000-00-0000"
        txtSSN.Name = "txtSSN"
        txtSSN.Size = New Size(182, 21)
        txtSSN.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(548, 187)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 15)
        Label8.TabIndex = 16
        Label8.Text = "Status :"
        ' 
        ' chkActive
        ' 
        chkActive.AutoSize = True
        chkActive.Location = New Point(623, 186)
        chkActive.Margin = New Padding(4, 3, 4, 3)
        chkActive.Name = "chkActive"
        chkActive.Size = New Size(57, 19)
        chkActive.TabIndex = 9
        chkActive.Text = "Active"
        chkActive.UseVisualStyleBackColor = True
        ' 
        ' btnCheckAvailability
        ' 
        btnCheckAvailability.BackColor = Color.SteelBlue
        btnCheckAvailability.FlatStyle = FlatStyle.Popup
        btnCheckAvailability.ForeColor = Color.White
        btnCheckAvailability.GradientBottom = Color.Purple
        btnCheckAvailability.GradientTop = Color.Purple
        btnCheckAvailability.ImageAlign = ContentAlignment.MiddleLeft
        btnCheckAvailability.Location = New Point(356, 12)
        btnCheckAvailability.Margin = New Padding(4, 3, 4, 3)
        btnCheckAvailability.Name = "btnCheckAvailability"
        btnCheckAvailability.Size = New Size(175, 42)
        btnCheckAvailability.TabIndex = 10
        btnCheckAvailability.Text = "Check Availability"
        btnCheckAvailability.TextAlign = ContentAlignment.MiddleRight
        btnCheckAvailability.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(8, 171)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 13
        Label7.Text = "Contact No :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(8, 140)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 15)
        Label6.TabIndex = 12
        Label6.Text = "Email ID :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(8, 108)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 15)
        Label5.TabIndex = 11
        Label5.Text = "Name :"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.BackColor = Color.White
        txtContactNo.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContactNo.Location = New Point(146, 171)
        txtContactNo.Margin = New Padding(4, 3, 4, 3)
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(182, 21)
        txtContactNo.TabIndex = 5
        ' 
        ' txtEmailID
        ' 
        txtEmailID.BackColor = Color.White
        txtEmailID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmailID.Location = New Point(146, 140)
        txtEmailID.Margin = New Padding(4, 3, 4, 3)
        txtEmailID.Name = "txtEmailID"
        txtEmailID.Size = New Size(182, 21)
        txtEmailID.TabIndex = 4
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.White
        txtName.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(146, 108)
        txtName.Margin = New Padding(4, 3, 4, 3)
        txtName.Name = "txtName"
        txtName.Size = New Size(182, 21)
        txtName.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(146, 77)
        txtPassword.Margin = New Padding(4, 3, 4, 3)
        txtPassword.MaxLength = 8
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "♠"c
        txtPassword.Size = New Size(182, 21)
        txtPassword.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 77)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(33, 15)
        Label4.TabIndex = 6
        Label4.Text = "PIN :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 47)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 5
        Label2.Text = "User Type :"
        ' 
        ' cmbUserType
        ' 
        cmbUserType.DropDownStyle = ComboBoxStyle.DropDownList
        cmbUserType.FormattingEnabled = True
        cmbUserType.Items.AddRange(New Object() {"Admin", "Staff", "Security Guard"})
        cmbUserType.Location = New Point(146, 44)
        cmbUserType.Margin = New Padding(4, 3, 4, 3)
        cmbUserType.Name = "cmbUserType"
        cmbUserType.Size = New Size(182, 23)
        cmbUserType.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 16)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 0
        Label3.Text = "User ID :"
        ' 
        ' txtUserID
        ' 
        txtUserID.BackColor = Color.White
        txtUserID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUserID.Location = New Point(146, 13)
        txtUserID.Margin = New Padding(4, 3, 4, 3)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(182, 21)
        txtUserID.TabIndex = 0
        ' 
        ' txtlev3
        ' 
        txtlev3.BackColor = Color.White
        txtlev3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtlev3.Location = New Point(1372, 519)
        txtlev3.Margin = New Padding(4, 3, 4, 3)
        txtlev3.Name = "txtlev3"
        txtlev3.Size = New Size(185, 21)
        txtlev3.TabIndex = 37
        txtlev3.UseSystemPasswordChar = True
        txtlev3.Visible = False
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnDelete)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnUpdate)
        Panel3.Controls.Add(btnNew)
        Panel3.Location = New Point(980, 7)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(120, 232)
        Panel3.TabIndex = 2
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.SteelBlue
        btnDelete.Cursor = Cursors.Hand
        btnDelete.FlatStyle = FlatStyle.Popup
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.GradientBottom = Color.Purple
        btnDelete.GradientTop = Color.Purple
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.ImageAlign = ContentAlignment.MiddleLeft
        btnDelete.Location = New Point(14, 171)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(97, 46)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.TextAlign = ContentAlignment.MiddleRight
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SteelBlue
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.GradientBottom = Color.Purple
        btnSave.GradientTop = Color.Purple
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(14, 68)
        btnSave.Margin = New Padding(4, 3, 4, 3)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(96, 43)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.TextAlign = ContentAlignment.MiddleRight
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.SteelBlue
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.GradientBottom = Color.Purple
        btnUpdate.GradientTop = Color.Purple
        btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), Image)
        btnUpdate.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdate.Location = New Point(14, 118)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(97, 46)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.TextAlign = ContentAlignment.MiddleRight
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = Color.SteelBlue
        btnNew.Cursor = Cursors.Hand
        btnNew.FlatStyle = FlatStyle.Popup
        btnNew.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNew.ForeColor = Color.White
        btnNew.GradientBottom = Color.Purple
        btnNew.GradientTop = Color.Purple
        btnNew.Image = CType(resources.GetObject("btnNew.Image"), Image)
        btnNew.ImageAlign = ContentAlignment.MiddleLeft
        btnNew.Location = New Point(14, 15)
        btnNew.Margin = New Padding(4, 3, 4, 3)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(97, 46)
        btnNew.TabIndex = 4
        btnNew.Text = "New"
        btnNew.TextAlign = ContentAlignment.MiddleRight
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(1315, 527)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(40, 15)
        Label15.TabIndex = 36
        Label15.Text = "Level3"
        Label15.Visible = False
        ' 
        ' dgw
        ' 
        dgw.AllowUserToAddRows = False
        dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FloralWhite
        dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgw.BackgroundColor = Color.White
        dgw.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Purple
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.Purple
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgw.ColumnHeadersHeight = 24
        dgw.Columns.AddRange(New DataGridViewColumn() {Description, Column1, Column2, Column3, Column4, Column5, Column10, Column8, Column9, Column7, Column6, Column11, Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19, Column20, Column21, Column22, Column23})
        dgw.Cursor = Cursors.Hand
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgw.DefaultCellStyle = DataGridViewCellStyle5
        dgw.EnableHeadersVisualStyles = False
        dgw.GridColor = Color.White
        dgw.Location = New Point(6, 7)
        dgw.Margin = New Padding(4, 3, 4, 3)
        dgw.MultiSelect = False
        dgw.Name = "dgw"
        dgw.ReadOnly = True
        dgw.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.Moccasin
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgw.RowHeadersWidth = 25
        dgw.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.SelectionBackColor = Color.Moccasin
        DataGridViewCellStyle7.SelectionForeColor = Color.Black
        dgw.RowsDefaultCellStyle = DataGridViewCellStyle7
        dgw.RowTemplate.Height = 18
        dgw.RowTemplate.Resizable = DataGridViewTriState.False
        dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgw.Size = New Size(967, 309)
        dgw.TabIndex = 1
        ' 
        ' txtCNo
        ' 
        txtCNo.Location = New Point(981, 351)
        txtCNo.Margin = New Padding(4, 3, 4, 3)
        txtCNo.Name = "txtCNo"
        txtCNo.Size = New Size(129, 23)
        txtCNo.TabIndex = 10
        txtCNo.Visible = False
        ' 
        ' txtlev2
        ' 
        txtlev2.BackColor = Color.White
        txtlev2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtlev2.Location = New Point(1372, 482)
        txtlev2.Margin = New Padding(4, 3, 4, 3)
        txtlev2.Name = "txtlev2"
        txtlev2.Size = New Size(185, 21)
        txtlev2.TabIndex = 35
        txtlev2.UseSystemPasswordChar = True
        txtlev2.Visible = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(1013, 597)
        CheckBox1.Margin = New Padding(4, 3, 4, 3)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(132, 19)
        CheckBox1.TabIndex = 30
        CheckBox1.Text = "Load All Transaction"
        CheckBox1.UseVisualStyleBackColor = True
        CheckBox1.Visible = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(1315, 490)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(40, 15)
        Label14.TabIndex = 34
        Label14.Text = "Level2"
        Label14.Visible = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Maroon
        Label9.Location = New Point(999, 622)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(168, 15)
        Label9.TabIndex = 11
        Label9.Text = "*4 digits pin allowed only"
        ' 
        ' txtlev1
        ' 
        txtlev1.BackColor = Color.White
        txtlev1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtlev1.Location = New Point(1372, 444)
        txtlev1.Margin = New Padding(4, 3, 4, 3)
        txtlev1.Name = "txtlev1"
        txtlev1.Size = New Size(185, 21)
        txtlev1.TabIndex = 33
        txtlev1.UseSystemPasswordChar = True
        txtlev1.Visible = False
        ' 
        ' chkBackoffice
        ' 
        chkBackoffice.AutoSize = True
        chkBackoffice.Location = New Point(1014, 653)
        chkBackoffice.Margin = New Padding(4, 3, 4, 3)
        chkBackoffice.Name = "chkBackoffice"
        chkBackoffice.Size = New Size(169, 19)
        chkBackoffice.TabIndex = 23
        chkBackoffice.Text = "Allow Access to BackOffice"
        chkBackoffice.UseVisualStyleBackColor = True
        chkBackoffice.Visible = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(1315, 452)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(40, 15)
        Label13.TabIndex = 32
        Label13.Text = "Level1"
        Label13.Visible = False
        ' 
        ' chkCredit
        ' 
        chkCredit.AutoSize = True
        chkCredit.Location = New Point(1014, 708)
        chkCredit.Margin = New Padding(4, 3, 4, 3)
        chkCredit.Name = "chkCredit"
        chkCredit.Size = New Size(113, 19)
        chkCredit.TabIndex = 24
        chkCredit.Text = "Credit Customer"
        chkCredit.UseVisualStyleBackColor = True
        chkCredit.Visible = False
        ' 
        ' chkBill
        ' 
        chkBill.AutoSize = True
        chkBill.Location = New Point(1194, 455)
        chkBill.Margin = New Padding(4, 3, 4, 3)
        chkBill.Name = "chkBill"
        chkBill.Size = New Size(83, 19)
        chkBill.TabIndex = 25
        chkBill.Text = "Bill Reprint"
        chkBill.UseVisualStyleBackColor = True
        chkBill.Visible = False
        ' 
        ' chksales
        ' 
        chksales.AutoSize = True
        chksales.Location = New Point(1194, 485)
        chksales.Margin = New Padding(4, 3, 4, 3)
        chksales.Name = "chksales"
        chksales.Size = New Size(95, 19)
        chksales.TabIndex = 26
        chksales.Text = "Sales Returns"
        chksales.UseVisualStyleBackColor = True
        chksales.Visible = False
        ' 
        ' chkSalesList
        ' 
        chkSalesList.AutoSize = True
        chkSalesList.Location = New Point(1194, 509)
        chkSalesList.Margin = New Padding(4, 3, 4, 3)
        chkSalesList.Name = "chkSalesList"
        chkSalesList.Size = New Size(73, 19)
        chkSalesList.TabIndex = 28
        chkSalesList.Text = "Sales List"
        chkSalesList.UseVisualStyleBackColor = True
        chkSalesList.Visible = False
        ' 
        ' chkquotation
        ' 
        chkquotation.AutoSize = True
        chkquotation.Location = New Point(1013, 682)
        chkquotation.Margin = New Padding(4, 3, 4, 3)
        chkquotation.Name = "chkquotation"
        chkquotation.Size = New Size(80, 19)
        chkquotation.TabIndex = 27
        chkquotation.Text = "Quotation"
        chkquotation.UseVisualStyleBackColor = True
        chkquotation.Visible = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(747, 20)
        txtEmail.Margin = New Padding(4, 3, 4, 3)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(129, 23)
        txtEmail.TabIndex = 8
        txtEmail.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Purple
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(txtEmail)
        Panel2.Controls.Add(lblUser)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(2, 2)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1072, 55)
        Panel2.TabIndex = 0
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.Location = New Point(776, -6)
        lblUser.Margin = New Padding(4, 0, 4, 0)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(41, 15)
        lblUser.TabIndex = 5
        lblUser.Text = "Label8"
        lblUser.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(357, 8)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 30)
        Label1.TabIndex = 0
        Label1.Text = "List of Registered Users/Staffs"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(902, 20)
        TextBox1.Margin = New Padding(4, 3, 4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(129, 23)
        TextBox1.TabIndex = 4
        TextBox1.Visible = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCancel.BackColor = Color.Transparent
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.Image = My.Resources.Resources.Button_Delete_icon
        btnCancel.Location = New Point(1082, 0)
        btnCancel.Margin = New Padding(4, 3, 4, 3)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(61, 58)
        btnCancel.TabIndex = 396
        btnCancel.TextAlign = ContentAlignment.MiddleRight
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Description
        ' 
        Description.HeaderText = "User ID"
        Description.Name = "Description"
        Description.ReadOnly = True
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "User Type"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        DataGridViewCellStyle3.NullValue = Nothing
        Column2.DefaultCellStyle = DataGridViewCellStyle3
        Column2.HeaderText = "PIN"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 50
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Name"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 120
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Email ID"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Contact No."
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Card No."
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "SSN#"
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Payroll Type"
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Visible = False
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Active"
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 60
        ' 
        ' Column6
        ' 
        DataGridViewCellStyle4.Format = "dd/MM/yyyy hh:mm:ss tt"
        Column6.DefaultCellStyle = DataGridViewCellStyle4
        Column6.HeaderText = "Registered Date"
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 150
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Allow Backoffice"
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Visible = False
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Quotation"
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Visible = False
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "Bill Reprint"
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        Column13.Visible = False
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "Credit Customer"
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        Column14.Visible = False
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "Sales Return"
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        Column15.Visible = False
        ' 
        ' Column16
        ' 
        Column16.HeaderText = "Sales List"
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        Column16.Visible = False
        ' 
        ' Column17
        ' 
        Column17.HeaderText = "Load All Transaction"
        Column17.Name = "Column17"
        Column17.ReadOnly = True
        Column17.Resizable = DataGridViewTriState.True
        Column17.SortMode = DataGridViewColumnSortMode.Automatic
        Column17.Visible = False
        ' 
        ' Column18
        ' 
        Column18.HeaderText = "Level1"
        Column18.Name = "Column18"
        Column18.ReadOnly = True
        Column18.Visible = False
        ' 
        ' Column19
        ' 
        Column19.HeaderText = "Level2"
        Column19.Name = "Column19"
        Column19.ReadOnly = True
        Column19.Visible = False
        ' 
        ' Column20
        ' 
        Column20.HeaderText = "Level3"
        Column20.Name = "Column20"
        Column20.ReadOnly = True
        Column20.Visible = False
        ' 
        ' Column21
        ' 
        Column21.HeaderText = "FacultyId"
        Column21.Name = "Column21"
        Column21.ReadOnly = True
        ' 
        ' Column22
        ' 
        Column22.HeaderText = "DeptId"
        Column22.Name = "Column22"
        Column22.ReadOnly = True
        ' 
        ' Column23
        ' 
        Column23.HeaderText = "evelId"
        Column23.Name = "Column23"
        Column23.ReadOnly = True
        ' 
        ' frmRegistration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Purple
        ClientSize = New Size(1143, 662)
        Controls.Add(btnCancel)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmRegistration"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(dgw, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPIN As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSSN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbPayrollType As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCheckAvailability As GelButtons.GelButton
    Friend WithEvents btnNew As GelButtons.GelButton
    Friend WithEvents btnUpdate As GelButtons.GelButton
    Friend WithEvents btnDelete As GelButtons.GelButton
    Friend WithEvents btnSave As GelButtons.GelButton
    Friend WithEvents txtCNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCardNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkBackoffice As CheckBox
    Friend WithEvents chkquotation As CheckBox
    Friend WithEvents chksales As CheckBox
    Friend WithEvents chkBill As CheckBox
    Friend WithEvents chkCredit As CheckBox
    Friend WithEvents chkSalesList As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtlev3 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtlev2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtlev1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbdept As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbfac As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cmblev As ComboBox
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewCheckBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
End Class
