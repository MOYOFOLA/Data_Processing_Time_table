﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TimeTable_genration_system
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_TimeTable_genration_system))
        GroupBox1 = New GroupBox()
        Label17 = New Label()
        cmbdept = New ComboBox()
        Label16 = New Label()
        cmbfac = New ComboBox()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        cmbsem = New ComboBox()
        Label2 = New Label()
        cmbses = New ComboBox()
        CheckBox1 = New CheckBox()
        btnUpdate = New GelButtons.GelButton()
        btnSave = New GelButtons.GelButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label17)
        GroupBox1.Controls.Add(cmbdept)
        GroupBox1.Controls.Add(Label16)
        GroupBox1.Controls.Add(cmbfac)
        GroupBox1.Location = New Point(20, 23)
        GroupBox1.Margin = New Padding(6, 5, 6, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(6, 5, 6, 5)
        GroupBox1.Size = New Size(849, 170)
        GroupBox1.TabIndex = 398
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dept And Faculty"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Microsoft Sans Serif", 10F)
        Label17.Location = New Point(10, 110)
        Label17.Margin = New Padding(6, 0, 6, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(113, 25)
        Label17.TabIndex = 45
        Label17.Text = "Department"
        ' 
        ' cmbdept
        ' 
        cmbdept.DropDownStyle = ComboBoxStyle.DropDownList
        cmbdept.FormattingEnabled = True
        cmbdept.Location = New Point(186, 100)
        cmbdept.Margin = New Padding(6, 5, 6, 5)
        cmbdept.Name = "cmbdept"
        cmbdept.Size = New Size(634, 33)
        cmbdept.TabIndex = 44
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Microsoft Sans Serif", 10F)
        Label16.Location = New Point(10, 42)
        Label16.Margin = New Padding(6, 0, 6, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(75, 25)
        Label16.TabIndex = 43
        Label16.Text = "Faculty"
        ' 
        ' cmbfac
        ' 
        cmbfac.DropDownStyle = ComboBoxStyle.DropDownList
        cmbfac.FormattingEnabled = True
        cmbfac.Location = New Point(189, 42)
        cmbfac.Margin = New Padding(6, 5, 6, 5)
        cmbfac.Name = "cmbfac"
        cmbfac.Size = New Size(631, 33)
        cmbfac.TabIndex = 42
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(cmbsem)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(cmbses)
        GroupBox2.Location = New Point(20, 203)
        GroupBox2.Margin = New Padding(6, 5, 6, 5)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(6, 5, 6, 5)
        GroupBox2.Size = New Size(849, 170)
        GroupBox2.TabIndex = 399
        GroupBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10F)
        Label1.Location = New Point(10, 110)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 45
        Label1.Text = "Semester"
        ' 
        ' cmbsem
        ' 
        cmbsem.DropDownStyle = ComboBoxStyle.DropDownList
        cmbsem.FormattingEnabled = True
        cmbsem.Items.AddRange(New Object() {"First Semester", "Second Semester", "Third Semester"})
        cmbsem.Location = New Point(186, 100)
        cmbsem.Margin = New Padding(6, 5, 6, 5)
        cmbsem.Name = "cmbsem"
        cmbsem.Size = New Size(634, 33)
        cmbsem.TabIndex = 44
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10F)
        Label2.Location = New Point(10, 42)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 25)
        Label2.TabIndex = 43
        Label2.Text = "Session"
        ' 
        ' cmbses
        ' 
        cmbses.DropDownStyle = ComboBoxStyle.DropDownList
        cmbses.FormattingEnabled = True
        cmbses.Items.AddRange(New Object() {"Admin", "Cashier", "Store Manager", "Inventory Manager", "Store Keeper", "Employee", "Security Guard"})
        cmbses.Location = New Point(189, 42)
        cmbses.Margin = New Padding(6, 5, 6, 5)
        cmbses.Name = "cmbses"
        cmbses.Size = New Size(631, 33)
        cmbses.TabIndex = 42
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(879, 38)
        CheckBox1.Margin = New Padding(6, 5, 6, 5)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(173, 79)
        CheckBox1.TabIndex = 402
        CheckBox1.Text = "Allocate Lecturer " & vbCrLf & "Based on " & vbCrLf & "Department"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.SteelBlue
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Popup
        btnUpdate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.GradientBottom = Color.Purple
        btnUpdate.GradientTop = Color.DarkMagenta
        btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), Image)
        btnUpdate.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdate.Location = New Point(897, 272)
        btnUpdate.Margin = New Padding(6, 5, 6, 5)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(149, 113)
        btnUpdate.TabIndex = 401
        btnUpdate.Text = "Auto " & vbCrLf & "Generate"
        btnUpdate.TextAlign = ContentAlignment.MiddleRight
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SteelBlue
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Popup
        btnSave.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.GradientBottom = Color.Purple
        btnSave.GradientTop = Color.DarkMagenta
        btnSave.Image = CType(resources.GetObject("btnSave.Image"), Image)
        btnSave.ImageAlign = ContentAlignment.MiddleLeft
        btnSave.Location = New Point(897, 133)
        btnSave.Margin = New Padding(6, 5, 6, 5)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(149, 127)
        btnSave.TabIndex = 400
        btnSave.Text = "Generate" & vbCrLf & "Manually"
        btnSave.TextAlign = ContentAlignment.MiddleRight
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Frm_TimeTable_genration_system
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1066, 402)
        Controls.Add(CheckBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(6, 5, 6, 5)
        MaximizeBox = False
        Name = "Frm_TimeTable_genration_system"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TIME TABLE SYSTEM"
        TransparencyKey = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents cmbdept As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbfac As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbsem As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbses As ComboBox
    Friend WithEvents btnUpdate As GelButtons.GelButton
    Friend WithEvents btnSave As GelButtons.GelButton
    Friend WithEvents CheckBox1 As CheckBox
End Class
