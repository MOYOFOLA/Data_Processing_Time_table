<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents LabelCompanyName As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents LabelCopyright As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        TableLayoutPanel = New TableLayoutPanel()
        LogoPictureBox = New PictureBox()
        LabelProductName = New Label()
        LabelVersion = New Label()
        LabelCopyright = New Label()
        LabelCompanyName = New Label()
        TextBoxDescription = New TextBox()
        lblLicense = New Label()
        Panel1 = New Panel()
        btnRenew = New GelButtons.GelButton()
        OKButton = New GelButtons.GelButton()
        TableLayoutPanel.SuspendLayout()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel
        ' 
        TableLayoutPanel.ColumnCount = 2
        TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 41.73554F))
        TableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 58.26446F))
        TableLayoutPanel.Controls.Add(LogoPictureBox, 0, 0)
        TableLayoutPanel.Controls.Add(LabelProductName, 1, 0)
        TableLayoutPanel.Controls.Add(LabelVersion, 1, 1)
        TableLayoutPanel.Controls.Add(LabelCopyright, 1, 2)
        TableLayoutPanel.Controls.Add(LabelCompanyName, 1, 3)
        TableLayoutPanel.Controls.Add(TextBoxDescription, 1, 5)
        TableLayoutPanel.Controls.Add(lblLicense, 1, 4)
        TableLayoutPanel.Controls.Add(Panel1, 1, 6)
        TableLayoutPanel.Dock = DockStyle.Fill
        TableLayoutPanel.ForeColor = Color.Purple
        TableLayoutPanel.Location = New Point(15, 17)
        TableLayoutPanel.Margin = New Padding(5, 6, 5, 6)
        TableLayoutPanel.Name = "TableLayoutPanel"
        TableLayoutPanel.RowCount = 8
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 11.16279F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 49.76744F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 62F))
        TableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 15F))
        TableLayoutPanel.Size = New Size(913, 497)
        TableLayoutPanel.TabIndex = 0
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Dock = DockStyle.Fill
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(5, 6)
        LogoPictureBox.Margin = New Padding(5, 6, 5, 6)
        LogoPictureBox.Name = "LogoPictureBox"
        TableLayoutPanel.SetRowSpan(LogoPictureBox, 6)
        LogoPictureBox.Size = New Size(371, 405)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' LabelProductName
        ' 
        LabelProductName.Dock = DockStyle.Fill
        LabelProductName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelProductName.ForeColor = Color.Purple
        LabelProductName.Location = New Point(391, 0)
        LabelProductName.Margin = New Padding(10, 0, 5, 0)
        LabelProductName.MaximumSize = New Size(0, 33)
        LabelProductName.Name = "LabelProductName"
        LabelProductName.Size = New Size(517, 33)
        LabelProductName.TabIndex = 0
        LabelProductName.Text = "Product Name"
        LabelProductName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelVersion
        ' 
        LabelVersion.Dock = DockStyle.Fill
        LabelVersion.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelVersion.ForeColor = Color.Purple
        LabelVersion.Location = New Point(391, 41)
        LabelVersion.Margin = New Padding(10, 0, 5, 0)
        LabelVersion.MaximumSize = New Size(0, 33)
        LabelVersion.Name = "LabelVersion"
        LabelVersion.Size = New Size(517, 33)
        LabelVersion.TabIndex = 0
        LabelVersion.Text = "Version"
        LabelVersion.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelCopyright
        ' 
        LabelCopyright.Dock = DockStyle.Fill
        LabelCopyright.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelCopyright.ForeColor = Color.Purple
        LabelCopyright.Location = New Point(391, 82)
        LabelCopyright.Margin = New Padding(10, 0, 5, 0)
        LabelCopyright.MaximumSize = New Size(0, 33)
        LabelCopyright.Name = "LabelCopyright"
        LabelCopyright.Size = New Size(517, 33)
        LabelCopyright.TabIndex = 0
        LabelCopyright.Text = "Copyright"
        LabelCopyright.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelCompanyName
        ' 
        LabelCompanyName.Dock = DockStyle.Fill
        LabelCompanyName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelCompanyName.ForeColor = Color.Purple
        LabelCompanyName.Location = New Point(391, 123)
        LabelCompanyName.Margin = New Padding(10, 0, 5, 0)
        LabelCompanyName.MaximumSize = New Size(0, 33)
        LabelCompanyName.Name = "LabelCompanyName"
        LabelCompanyName.Size = New Size(517, 33)
        LabelCompanyName.TabIndex = 0
        LabelCompanyName.Text = "Company Name"
        LabelCompanyName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBoxDescription
        ' 
        TextBoxDescription.BackColor = Color.White
        TextBoxDescription.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBoxDescription.ForeColor = Color.Purple
        TextBoxDescription.Location = New Point(391, 216)
        TextBoxDescription.Margin = New Padding(10, 6, 5, 6)
        TextBoxDescription.Multiline = True
        TextBoxDescription.Name = "TextBoxDescription"
        TextBoxDescription.ReadOnly = True
        TextBoxDescription.ScrollBars = ScrollBars.Both
        TextBoxDescription.Size = New Size(516, 177)
        TextBoxDescription.TabIndex = 0
        TextBoxDescription.TabStop = False
        TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        ' 
        ' lblLicense
        ' 
        lblLicense.Dock = DockStyle.Fill
        lblLicense.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLicense.ForeColor = Color.Purple
        lblLicense.Location = New Point(391, 164)
        lblLicense.Margin = New Padding(10, 0, 5, 0)
        lblLicense.MaximumSize = New Size(0, 33)
        lblLicense.Name = "lblLicense"
        lblLicense.Size = New Size(517, 33)
        lblLicense.TabIndex = 1
        lblLicense.Text = "Company Name"
        lblLicense.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnRenew)
        Panel1.Controls.Add(OKButton)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(386, 423)
        Panel1.Margin = New Padding(5, 6, 5, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(522, 50)
        Panel1.TabIndex = 3
        ' 
        ' btnRenew
        ' 
        btnRenew.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnRenew.DialogResult = DialogResult.Cancel
        btnRenew.ForeColor = Color.White
        btnRenew.GradientBottom = Color.Purple
        btnRenew.GradientTop = Color.Purple
        btnRenew.Location = New Point(304, 6)
        btnRenew.Margin = New Padding(5, 6, 5, 6)
        btnRenew.Name = "btnRenew"
        btnRenew.Size = New Size(213, 44)
        btnRenew.TabIndex = 2
        btnRenew.Text = "Renew License"
        ' 
        ' OKButton
        ' 
        OKButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        OKButton.DialogResult = DialogResult.Cancel
        OKButton.ForeColor = Color.White
        OKButton.GradientBottom = Color.Purple
        OKButton.GradientTop = Color.Purple
        OKButton.Location = New Point(4, 8)
        OKButton.Margin = New Padding(5, 6, 5, 6)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(163, 38)
        OKButton.TabIndex = 0
        OKButton.Text = "&OK"
        ' 
        ' frmAbout
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        CancelButton = OKButton
        ClientSize = New Size(943, 531)
        Controls.Add(TableLayoutPanel)
        ForeColor = Color.Purple
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAbout"
        Padding = New Padding(15, 17, 15, 17)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "frmAbout"
        TableLayoutPanel.ResumeLayout(False)
        TableLayoutPanel.PerformLayout()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)

    End Sub
    Friend WithEvents OKButton As GelButtons.GelButton
    Friend WithEvents lblLicense As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRenew As GelButtons.GelButton
End Class
