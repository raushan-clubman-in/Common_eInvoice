Imports System.Data.SqlClient
Public Class Accountposting_Others
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lbl_Fromdate As System.Windows.Forms.Label
    Friend WithEvents dtp_Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Todate As System.Windows.Forms.Label
    Friend WithEvents dtp_Todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_heading As System.Windows.Forms.Label
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents grp_Billposting As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Fill As System.Windows.Forms.Button
    Friend WithEvents Cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents Cmd_Posted As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Accountpostingssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents lbl_head As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grp_AccountPosting As System.Windows.Forms.GroupBox
    Friend WithEvents GrdAuditTrail As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpPost As System.Windows.Forms.GroupBox
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPost As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents cmdDosView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdFillExport As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Accountposting_Others))
        Me.lbl_Fromdate = New System.Windows.Forms.Label
        Me.dtp_Fromdate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Todate = New System.Windows.Forms.Label
        Me.dtp_Todate = New System.Windows.Forms.DateTimePicker
        Me.lbl_heading = New System.Windows.Forms.Label
        Me.Cmd_Posted = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.grp_Billposting = New System.Windows.Forms.GroupBox
        Me.lbl_head = New System.Windows.Forms.Label
        Me.Cmd_Cancel = New System.Windows.Forms.Button
        Me.Cmd_Fill = New System.Windows.Forms.Button
        Me.Accountpostingssgrid = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdDosView = New System.Windows.Forms.Button
        Me.cmdFillExport = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grp_AccountPosting = New System.Windows.Forms.GroupBox
        Me.GrdAuditTrail = New AxFPSpreadADO.AxfpSpread
        Me.Label16 = New System.Windows.Forms.Label
        Me.grpPost = New System.Windows.Forms.GroupBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPost = New System.Windows.Forms.Button
        Me.cmdView = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdExport = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.grp_Billposting.SuspendLayout()
        CType(Me.Accountpostingssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Grp_AccountPosting.SuspendLayout()
        CType(Me.GrdAuditTrail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPost.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Fromdate
        '
        Me.lbl_Fromdate.AutoSize = True
        Me.lbl_Fromdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fromdate.Location = New System.Drawing.Point(24, 56)
        Me.lbl_Fromdate.Name = "lbl_Fromdate"
        Me.lbl_Fromdate.Size = New System.Drawing.Size(116, 22)
        Me.lbl_Fromdate.TabIndex = 5
        Me.lbl_Fromdate.Text = "FROM DATE :"
        '
        'dtp_Fromdate
        '
        Me.dtp_Fromdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Fromdate.Location = New System.Drawing.Point(160, 56)
        Me.dtp_Fromdate.Name = "dtp_Fromdate"
        Me.dtp_Fromdate.Size = New System.Drawing.Size(168, 26)
        Me.dtp_Fromdate.TabIndex = 0
        '
        'lbl_Todate
        '
        Me.lbl_Todate.AutoSize = True
        Me.lbl_Todate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Todate.Location = New System.Drawing.Point(53, 96)
        Me.lbl_Todate.Name = "lbl_Todate"
        Me.lbl_Todate.Size = New System.Drawing.Size(89, 22)
        Me.lbl_Todate.TabIndex = 6
        Me.lbl_Todate.Text = "TO DATE :"
        '
        'dtp_Todate
        '
        Me.dtp_Todate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Todate.Location = New System.Drawing.Point(160, 96)
        Me.dtp_Todate.Name = "dtp_Todate"
        Me.dtp_Todate.Size = New System.Drawing.Size(168, 26)
        Me.dtp_Todate.TabIndex = 1
        '
        'lbl_heading
        '
        Me.lbl_heading.AutoSize = True
        Me.lbl_heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_heading.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heading.Location = New System.Drawing.Point(352, 8)
        Me.lbl_heading.Name = "lbl_heading"
        Me.lbl_heading.Size = New System.Drawing.Size(220, 28)
        Me.lbl_heading.TabIndex = 5
        Me.lbl_heading.Text = "ACCOUNT POSTING"
        '
        'Cmd_Posted
        '
        Me.Cmd_Posted.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Posted.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Posted.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Posted.ForeColor = System.Drawing.Color.White
        Me.Cmd_Posted.Image = CType(resources.GetObject("Cmd_Posted.Image"), System.Drawing.Image)
        Me.Cmd_Posted.Location = New System.Drawing.Point(496, 24)
        Me.Cmd_Posted.Name = "Cmd_Posted"
        Me.Cmd_Posted.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Posted.TabIndex = 1
        Me.Cmd_Posted.Text = "Audit Trial[F6]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(616, 24)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 4
        Me.Cmd_Exit.Text = "Exit [F11]"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(256, 24)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 2
        Me.Cmd_Print.Text = "Print [F12]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(16, 24)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 3
        Me.Cmd_View.Text = "Fill View [F9]"
        '
        'grp_Billposting
        '
        Me.grp_Billposting.BackgroundImage = CType(resources.GetObject("grp_Billposting.BackgroundImage"), System.Drawing.Image)
        Me.grp_Billposting.Controls.Add(Me.lbl_head)
        Me.grp_Billposting.Controls.Add(Me.Cmd_Cancel)
        Me.grp_Billposting.Controls.Add(Me.Cmd_Fill)
        Me.grp_Billposting.Controls.Add(Me.lbl_Fromdate)
        Me.grp_Billposting.Controls.Add(Me.dtp_Fromdate)
        Me.grp_Billposting.Controls.Add(Me.lbl_Todate)
        Me.grp_Billposting.Controls.Add(Me.dtp_Todate)
        Me.grp_Billposting.Location = New System.Drawing.Point(376, 1000)
        Me.grp_Billposting.Name = "grp_Billposting"
        Me.grp_Billposting.Size = New System.Drawing.Size(384, 192)
        Me.grp_Billposting.TabIndex = 0
        Me.grp_Billposting.TabStop = False
        '
        'lbl_head
        '
        Me.lbl_head.BackColor = System.Drawing.Color.Maroon
        Me.lbl_head.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_head.ForeColor = System.Drawing.Color.White
        Me.lbl_head.Location = New System.Drawing.Point(5, 9)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(376, 24)
        Me.lbl_head.TabIndex = 7
        Me.lbl_head.Text = "BILL POSTING"
        Me.lbl_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmd_Cancel
        '
        Me.Cmd_Cancel.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Cancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Cancel.ForeColor = System.Drawing.Color.White
        Me.Cmd_Cancel.Image = CType(resources.GetObject("Cmd_Cancel.Image"), System.Drawing.Image)
        Me.Cmd_Cancel.Location = New System.Drawing.Point(200, 144)
        Me.Cmd_Cancel.Name = "Cmd_Cancel"
        Me.Cmd_Cancel.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Cancel.TabIndex = 3
        Me.Cmd_Cancel.Text = "Cancel [F10]"
        '
        'Cmd_Fill
        '
        Me.Cmd_Fill.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Fill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fill.ForeColor = System.Drawing.Color.White
        Me.Cmd_Fill.Image = CType(resources.GetObject("Cmd_Fill.Image"), System.Drawing.Image)
        Me.Cmd_Fill.Location = New System.Drawing.Point(72, 144)
        Me.Cmd_Fill.Name = "Cmd_Fill"
        Me.Cmd_Fill.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Fill.TabIndex = 2
        Me.Cmd_Fill.Text = "Fill [F4]"
        '
        'Accountpostingssgrid
        '
        Me.Accountpostingssgrid.DataSource = Nothing
        Me.Accountpostingssgrid.Location = New System.Drawing.Point(8, 40)
        Me.Accountpostingssgrid.Name = "Accountpostingssgrid"
        Me.Accountpostingssgrid.OcxState = CType(resources.GetObject("Accountpostingssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Accountpostingssgrid.Size = New System.Drawing.Size(1008, 528)
        Me.Accountpostingssgrid.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Posted)
        Me.GroupBox2.Controls.Add(Me.Cmd_Print)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Controls.Add(Me.cmdDosView)
        Me.GroupBox2.Controls.Add(Me.cmdFillExport)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 576)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 72)
        Me.GroupBox2.TabIndex = 79
        Me.GroupBox2.TabStop = False
        '
        'cmdDosView
        '
        Me.cmdDosView.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdDosView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDosView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDosView.ForeColor = System.Drawing.Color.White
        Me.cmdDosView.Image = CType(resources.GetObject("cmdDosView.Image"), System.Drawing.Image)
        Me.cmdDosView.Location = New System.Drawing.Point(136, 24)
        Me.cmdDosView.Name = "cmdDosView"
        Me.cmdDosView.Size = New System.Drawing.Size(104, 32)
        Me.cmdDosView.TabIndex = 130
        Me.cmdDosView.Text = "View [F10]"
        '
        'cmdFillExport
        '
        Me.cmdFillExport.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdFillExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFillExport.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFillExport.ForeColor = System.Drawing.Color.White
        Me.cmdFillExport.Image = CType(resources.GetObject("cmdFillExport.Image"), System.Drawing.Image)
        Me.cmdFillExport.Location = New System.Drawing.Point(376, 24)
        Me.cmdFillExport.Name = "cmdFillExport"
        Me.cmdFillExport.Size = New System.Drawing.Size(104, 32)
        Me.cmdFillExport.TabIndex = 169
        Me.cmdFillExport.Text = "Export[F2]"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(72, 680)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(912, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "F4-->Help  F2-->Bill No   F3-->Delete Item  Alt+P--> Payment Mode   Alt+M--> Memb" & _
        "er Code  Alt+S--> Server Code Alt+G-->Focus on Grid"
        '
        'Grp_AccountPosting
        '
        Me.Grp_AccountPosting.BackColor = System.Drawing.Color.Transparent
        Me.Grp_AccountPosting.Controls.Add(Me.Label16)
        Me.Grp_AccountPosting.Controls.Add(Me.grpPost)
        Me.Grp_AccountPosting.Controls.Add(Me.Label2)
        Me.Grp_AccountPosting.Controls.Add(Me.GrdAuditTrail)
        Me.Grp_AccountPosting.Location = New System.Drawing.Point(8, 8)
        Me.Grp_AccountPosting.Name = "Grp_AccountPosting"
        Me.Grp_AccountPosting.Size = New System.Drawing.Size(1008, 672)
        Me.Grp_AccountPosting.TabIndex = 129
        Me.Grp_AccountPosting.TabStop = False
        '
        'GrdAuditTrail
        '
        Me.GrdAuditTrail.ContainingControl = Me
        Me.GrdAuditTrail.DataSource = Nothing
        Me.GrdAuditTrail.Location = New System.Drawing.Point(13, 64)
        Me.GrdAuditTrail.Name = "GrdAuditTrail"
        Me.GrdAuditTrail.OcxState = CType(resources.GetObject("GrdAuditTrail.OcxState"), System.Windows.Forms.AxHost.State)
        Me.GrdAuditTrail.Size = New System.Drawing.Size(987, 480)
        Me.GrdAuditTrail.TabIndex = 128
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(176, 640)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(245, 19)
        Me.Label16.TabIndex = 169
        Me.Label16.Text = "[Press F8 to Search and F3 to Continue]"
        '
        'grpPost
        '
        Me.grpPost.Controls.Add(Me.cmdexit)
        Me.grpPost.Controls.Add(Me.cmdPost)
        Me.grpPost.Controls.Add(Me.cmdView)
        Me.grpPost.Controls.Add(Me.cmdPrint)
        Me.grpPost.Controls.Add(Me.cmdExport)
        Me.grpPost.Location = New System.Drawing.Point(176, 568)
        Me.grpPost.Name = "grpPost"
        Me.grpPost.Size = New System.Drawing.Size(624, 72)
        Me.grpPost.TabIndex = 133
        Me.grpPost.TabStop = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(496, 24)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 134
        Me.cmdexit.Text = "Exit[F11]"
        '
        'cmdPost
        '
        Me.cmdPost.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPost.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPost.ForeColor = System.Drawing.Color.White
        Me.cmdPost.Image = CType(resources.GetObject("cmdPost.Image"), System.Drawing.Image)
        Me.cmdPost.Location = New System.Drawing.Point(376, 24)
        Me.cmdPost.Name = "cmdPost"
        Me.cmdPost.Size = New System.Drawing.Size(104, 32)
        Me.cmdPost.TabIndex = 135
        Me.cmdPost.Text = "Post[F6]"
        '
        'cmdView
        '
        Me.cmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.ForeColor = System.Drawing.Color.White
        Me.cmdView.Image = CType(resources.GetObject("cmdView.Image"), System.Drawing.Image)
        Me.cmdView.Location = New System.Drawing.Point(16, 24)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(104, 32)
        Me.cmdView.TabIndex = 135
        Me.cmdView.Text = "View[F9]"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(136, 24)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 135
        Me.cmdPrint.Text = "Print[F12]"
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExport.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.ForeColor = System.Drawing.Color.White
        Me.cmdExport.Image = CType(resources.GetObject("cmdExport.Image"), System.Drawing.Image)
        Me.cmdExport.Location = New System.Drawing.Point(256, 24)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(104, 32)
        Me.cmdExport.TabIndex = 135
        Me.cmdExport.Text = "Export[F5]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 31)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "AUDIT TRIAL"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(321, 1000)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 96)
        Me.GroupBox1.TabIndex = 168
        Me.GroupBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(224, 56)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 32)
        Me.btnCancel.TabIndex = 152
        Me.btnCancel.Text = "&Hide Me"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 18)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Search Text :"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(320, 56)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 32)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "&Go"
        '
        'txtSearch
        '
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(120, 24)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(240, 26)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = ""
        '
        'Accountposting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 699)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_Billposting)
        Me.Controls.Add(Me.lbl_heading)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Accountpostingssgrid)
        Me.Controls.Add(Me.Grp_AccountPosting)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Accountposting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNT POSTING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_Billposting.ResumeLayout(False)
        CType(Me.Accountpostingssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Grp_AccountPosting.ResumeLayout(False)
        CType(Me.GrdAuditTrail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPost.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim itembool, chkbool, smartcardbool As Boolean
    Dim TotalItemCount As Integer
    Dim gconnection As New GlobalClass
    'Added on 09 Feb'08
    'Mk Kannan
    'Begin Audit Trial
    Dim boolSearchResult, boolSearchNext, boolAddLess As Boolean
    'End

    Private Sub Accountposting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Accountpostingbool = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        grp_Billposting.Top = 1000
    End Sub
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Accountpostingssgrid.ClearRange(1, 1, -1, -1, True)
        grp_Billposting.Top = 150
        grp_Billposting.Left = 296
        dtp_Fromdate.Focus()
    End Sub
    Private Sub Cmd_Posted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Posted.Click
        'Added on 07 Feb'08
        'Mk Kannan
        'Begin Audit Trial

        'Account Posting Trial
        'Begin
        Dim SQLSTRING, ACCOUNTCODE, SLCODE, strAccHead As String
        Dim CLS_CREDITS, CLS_DEBITS, CUR_CREDITS, CUR_DEBITS, TOT_CREDITS, TOT_DEBITS, CUR_GRANDCREDITS, CUR_GRANDDEBITS, CUR_GRANDCREDITSTOTAL, CUR_GRANDDEBITSTOTAL As Double
        Dim I, ROWCOUNT, J, K As Integer

        GrdAuditTrail.ClearRange(1, 1, -1, -1, True)

        ROWCOUNT = 1
        For K = 0 To 1
            If K = 0 Then
                'Posted Accounts
                SQLSTRING = "EXEC Cp_AccountsPostingView_Others " & "'" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "','" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "', 'T'"
                strAccHead = "Posted Accounts"
            Else
                'Accounts to be Posted
                SQLSTRING = "EXEC Cp_AccountsPostingView_Others " & "'" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "','" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "', 'P'"
                strAccHead = "Accounts to be Posted"
            End If
            gconnection.dataOperation(6, SQLSTRING, "ACCOUNTPOSTING")
            SQLSTRING = "EXEC Cp_PosJv_Others '" & Mid(Trim(gFinancalyearStart), 3, 4) & "','" & Mid(Trim(gFinancialYearEnd), 3, 4) & "','" & Trim(gUsername) & "','" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "', 'T'"
            gconnection.dataOperation(6, SQLSTRING, "ACCOUNTPOSTING")
            'End

            SQLSTRING = "SELECT ISNULL(POSCLOSE,'') AS POSCLOSE, ISNULL(GLOBALCLOSE,'') AS GLOBALCLOSE FROM MONTHCLOSE WHERE MONTHNO=" & Month(dtp_Fromdate.Value)
            gconnection.getDataSet(SQLSTRING, "MONTHCLOSE")
            If gdataset.Tables("MONTHCLOSE").Rows.Count > 0 Then
                MsgBox("Sorry!, Month is Closed.", MsgBoxStyle.Critical, "Warning!")
            Else
                SQLSTRING = "SELECT DISTINCT ISNULL(ACCOUNTCODE,'') AS ACCOUNTCODE, ISNULL(ACCOUNTCODEDESC,'') AS ACCOUNTCODEDESC FROM TBL_AUDITTRIAL"
                SQLSTRING = SQLSTRING & " WHERE VOUCHERDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' ORDER BY ACCOUNTCODE"
                gconnection.getDataSet(SQLSTRING, "ACCODE")
                With GrdAuditTrail
                    .Row = ROWCOUNT
                    .Col = 1
                    .Text = "AcCode"
                    .FontBold = True
                    .Col = 2
                    .Text = "Description"
                    .FontBold = True
                    .Col = 3
                    .Text = "SlCode"
                    .FontBold = True
                    .Col = 4
                    .Text = "Description"
                    .FontBold = True
                    .Col = 5
                    .Text = "Opening Balance"
                    .FontBold = True
                    .Col = 6
                    .Text = "Credit"
                    .FontBold = True
                    .Col = 7
                    .Text = "Debit"
                    .FontBold = True
                    .Col = 8
                    .Text = "Closing Balance"
                    .FontBold = True
                End With
                If gdataset.Tables("ACCODE").Rows.Count > 0 Then
                    With GrdAuditTrail
                        .MaxRows = .MaxRows + 2
                        ROWCOUNT = ROWCOUNT + 2
                        .Row = ROWCOUNT
                        .Col = 4
                        .Text = strAccHead
                        ROWCOUNT = ROWCOUNT + 1
                        .MaxRows = .MaxRows + 1
                    End With

                    For I = 0 To gdataset.Tables("ACCODE").Rows.Count - 1
                        With GrdAuditTrail
                            .Row = ROWCOUNT
                            .Col = 1
                            .Text = Trim(gdataset.Tables("ACCODE").Rows(I).Item("Accountcode"))
                            .Col = 2
                            .Text = Trim(gdataset.Tables("ACCODE").Rows(I).Item("AccountcodeDesc"))
                            SQLSTRING = "SELECT DISTINCT ISNULL(SLCODE,'') AS SLCODE, ISNULL(SLDESC,'') AS SLDESC FROM TBL_AUDITTRIAL"
                            SQLSTRING = SQLSTRING & " WHERE ACCOUNTCODE = '" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("Accountcode")) & "'  ORDER BY SLCODE"
                            gconnection.getDataSet(SQLSTRING, "SLCODE")
                            If gdataset.Tables("SLCODE").Rows.Count > 0 Then
                                For J = 0 To gdataset.Tables("SLCODE").Rows.Count - 1
                                    .Row = ROWCOUNT

                                    .Col = 3
                                    If Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLCode")) <> "" Then
                                        .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SlCode"))
                                    Else
                                        .Text = ""
                                    End If

                                    .Col = 4
                                    If Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLDesc")) <> "" Then
                                        .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SlDesc"))
                                    Else
                                        .Text = ""
                                    End If

                                    .Col = 5
                                    If Trim(gdataset.Tables("SLCODE").Rows(J).Item("sldesc")) <> "" Then
                                        SQLSTRING = "SELECT ISNULL(SLCODE,'') AS SLCODE, ISNULL(SLDESC,'') SLDESC,ISNULL(CLDEBITS,0) AS CLDEBITS, ISNULL(CLCREDITS,0) AS CLCREDITS FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("Accountcode")) & "' AND ISNULL(FREEZEFLAG,'')<>'Y' and Slcode='" & Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLCODE")) & "'"
                                        gconnection.getDataSet(SQLSTRING, "Subledger")
                                        If gdataset.Tables("Subledger").Rows.Count > 0 Then
                                            If gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS") = gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS") Then
                                                .Text = Format(Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS")) - Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS")), "0.00")
                                            ElseIf gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS") > gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS") Then
                                                .Text = Format(Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS")) - Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS")), "0.00") & " - Dr "
                                            Else
                                                .Text = Format(Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS")) - Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS")), "0.00") & " - Cr "
                                            End If
                                            CLS_CREDITS = Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS"))
                                            CLS_DEBITS = Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS"))
                                        End If
                                        .Col = 6
                                        .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                                        SQLSTRING = "SELECT ISNULL(SUM(AMOUNT),0) As CREDITAMOUNT FROM TBL_AUDITTRIAL WHERE "
                                        SQLSTRING = SQLSTRING & "ACCOUNTCODE='" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("Accountcode")) & "' AND ISNULL(VOID,'')<>'Y' and slcode='" & Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLCODE")) & "' AND CREDITDEBIT='CREDIT'"
                                        gconnection.getDataSet(SQLSTRING, "PJV_CR_SL")
                                        If gdataset.Tables("PJV_CR_SL").Rows.Count > 0 Then
                                            .Text = Trim(gdataset.Tables("PJV_CR_SL").Rows(0).Item("CREDITAMOUNT"))
                                        Else
                                            .Text = ""
                                        End If
                                        CUR_CREDITS = Val(gdataset.Tables("PJV_CR_SL").Rows(0).Item("CREDITAMOUNT"))
                                        .Col = 7
                                        .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                                        SQLSTRING = "SELECT ISNULL(SUM(AMOUNT),0) CREDITAMOUNT FROM TBL_AUDITTRIAL WHERE "
                                        SQLSTRING = SQLSTRING & "ACCOUNTCODE='" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("AccountCODE")) & "' AND ISNULL(VOID,'')<>'Y' and slcode='" & Trim(gdataset.Tables("SLCODE").Rows(J).Item("slCODE")) & "' AND CREDITDEBIT='DEBIT'"
                                        gconnection.getDataSet(SQLSTRING, "PJV_DB_SL")
                                        If gdataset.Tables("PJV_DB_SL").Rows.Count > 0 Then
                                            .Text = Trim(gdataset.Tables("PJV_DB_SL").Rows(0).Item("CREDITAMOUNT"))
                                        Else
                                            .Text = ""
                                        End If
                                        CUR_DEBITS = Val(gdataset.Tables("PJV_DB_SL").Rows(0).Item("CREDITAMOUNT"))
                                    Else
                                        SQLSTRING = "Select Isnull(Accode,'') as Accode, Isnull(Acdesc,'') as Acdesc,Isnull(CLDEBITS,0) As CLDEBITS, Isnull(CLCREDITS,0) As CLCREDITS  from AccountsGlAccountMaster  where isnull(Freezeflag,'') <> 'Y' AND ACCODE='" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("ACCOUNTCODE")) & "'"
                                        gconnection.getDataSet(SQLSTRING, "ACCOUNTMASTER")
                                        If gdataset.Tables("ACCOUNTMASTER").Rows.Count > 0 Then
                                            If gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS") = gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS") Then
                                                .Text = Format(Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS")) - Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS")), "0.00")
                                            ElseIf gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS") > gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS") Then
                                                .Text = Format(Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS")) - Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS")), "0.00") & " - Dr "
                                            Else
                                                .Text = Format(Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS")) - Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS")), "0.00") & " - Cr "
                                            End If
                                            CLS_CREDITS = Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS"))
                                            CLS_DEBITS = Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS"))
                                        End If
                                        .Col = 6
                                        .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                                        SQLSTRING = "SELECT ISNULL(SUM(AMOUNT),0) CREDITAMOUNT FROM TBL_AUDITTRIAL WHERE "
                                        SQLSTRING = SQLSTRING & "ACCOUNTCODE='" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("AccountCODE")) & "' AND ISNULL(VOID,'')<>'Y' AND CREDITDEBIT='CREDIT'"
                                        gconnection.getDataSet(SQLSTRING, "PJV_CR_SL")
                                        If gdataset.Tables("PJV_CR_SL").Rows.Count > 0 Then
                                            .Text = Trim(gdataset.Tables("PJV_CR_SL").Rows(0).Item("CREDITAMOUNT"))
                                            CUR_CREDITS = Val(gdataset.Tables("PJV_CR_SL").Rows(0).Item("CREDITAMOUNT"))
                                        Else
                                            .Text = ""
                                            CUR_CREDITS = 0
                                        End If
                                        .Col = 7
                                        .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                                        SQLSTRING = "SELECT ISNULL(SUM(AMOUNT),0) DEBITAMOUNT FROM TBL_AUDITTRIAL WHERE "
                                        SQLSTRING = SQLSTRING & "ACCOUNTCODE='" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("AccountCODE")) & "' AND ISNULL(VOID,'')<>'Y' AND CREDITDEBIT='DEBIT'"
                                        gconnection.getDataSet(SQLSTRING, "PJV_DB_SL")
                                        If gdataset.Tables("PJV_DB_SL").Rows.Count > 0 Then
                                            .Text = Trim(gdataset.Tables("PJV_DB_SL").Rows(0).Item("DEBITAMOUNT"))
                                            CUR_DEBITS = Val(gdataset.Tables("PJV_DB_SL").Rows(0).Item("DEBITAMOUNT"))
                                        Else
                                            .Text = ""
                                            CUR_DEBITS = 0
                                        End If
                                    End If
                                    CUR_GRANDCREDITSTOTAL = CUR_GRANDCREDITSTOTAL + CUR_CREDITS
                                    CUR_GRANDDEBITSTOTAL = CUR_GRANDDEBITSTOTAL + CUR_DEBITS
                                    CUR_GRANDCREDITS = CUR_GRANDCREDITS + CUR_CREDITS
                                    CUR_GRANDDEBITS = CUR_GRANDDEBITS + CUR_DEBITS
                                    TOT_CREDITS = CLS_CREDITS + CUR_CREDITS
                                    TOT_DEBITS = CLS_DEBITS + CUR_DEBITS
                                    .Col = 8
                                    If TOT_DEBITS = TOT_CREDITS Then
                                        .Text = TOT_DEBITS - TOT_CREDITS
                                    ElseIf TOT_DEBITS > TOT_CREDITS Then
                                        .Text = Format(TOT_DEBITS - TOT_CREDITS, "0.00") & " - Dr "
                                    Else
                                        .Text = Format(TOT_CREDITS - TOT_DEBITS, "0.00") & " - Cr "
                                    End If
                                    ROWCOUNT = ROWCOUNT + 1
                                    .MaxRows = .MaxRows + 1
                                Next J
                            End If
                        End With
                    Next I
                    GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 1
                    ROWCOUNT = ROWCOUNT + 1
                    GrdAuditTrail.Row = ROWCOUNT
                    GrdAuditTrail.Col = 5
                    GrdAuditTrail.Text = "TOTAL"
                    GrdAuditTrail.Col = 6
                    GrdAuditTrail.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                    GrdAuditTrail.Text = CUR_GRANDCREDITS
                    GrdAuditTrail.Col = 7
                    GrdAuditTrail.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                    GrdAuditTrail.Text = CUR_GRANDDEBITS
                    GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 2
                    ROWCOUNT = ROWCOUNT + 2
                End If
                CUR_GRANDCREDITS = 0
                CUR_GRANDDEBITS = 0
            End If
        Next
        GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 1
        ROWCOUNT = ROWCOUNT + 1
        GrdAuditTrail.Row = ROWCOUNT
        GrdAuditTrail.Col = 5
        GrdAuditTrail.Text = "GRAND TOTAL"
        GrdAuditTrail.Col = 6
        GrdAuditTrail.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        GrdAuditTrail.Text = CUR_GRANDCREDITSTOTAL
        GrdAuditTrail.Col = 7
        GrdAuditTrail.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        GrdAuditTrail.Text = CUR_GRANDDEBITSTOTAL
        GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 1
        ROWCOUNT = ROWCOUNT + 1

        'Accouts to be Posted
        'SQLSTRING = "EXEC Cp_AccountsPostingView_New " & "'" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "','" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "', 'P'"
        'gconnection.dataOperation(6, SQLSTRING, "ACCOUNTPOSTINGPOSTED")

        'SQLSTRING = "EXEC Cp_PosJv '" & Mid(Trim(gFinancalyearStart), 3, 4) & "','" & Mid(Trim(gFinancialYearEnd), 3, 4) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "', 'T'"
        'gconnection.dataOperation(6, SQLSTRING, "ACCOUNTPOSTING")

        'SQLSTRING = "SELECT DISTINCT ISNULL(ACCOUNTCODE,'') AS ACCOUNTCODE, ISNULL(ACCOUNTCODEDESC,'') AS ACCOUNTCODEDESC FROM TBL_AUDITTRIAL"
        'SQLSTRING = SQLSTRING & " WHERE VOUCHERDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' ORDER BY ACCOUNTCODE"
        'gconnection.getDataSet(SQLSTRING, "ACCODE")

        'If gdataset.Tables("ACCODE").Rows.Count > 0 Then
        '    With GrdAuditTrail
        '        If ROWCOUNT = 1 Then
        '            .MaxRows = .MaxRows + 2
        '            ROWCOUNT = ROWCOUNT + 2
        '        End If
        '        .Row = ROWCOUNT
        '        .Col = 4
        '        .Text = "Accounts To Be Posted"
        '        .MaxRows = GrdAuditTrail.MaxRows + 1
        '        ROWCOUNT = ROWCOUNT + 1
        '    End With

        '    For I = 0 To gdataset.Tables("ACCODE").Rows.Count - 1
        '        With GrdAuditTrail
        '            .Row = ROWCOUNT
        '            .Col = 1
        '            .Text = Trim(gdataset.Tables("ACCODE").Rows(I).Item("Accountcode"))
        '            .Col = 2
        '            .Text = Trim(gdataset.Tables("ACCODE").Rows(I).Item("AccountcodeDesc"))
        '            SQLSTRING = "SELECT DISTINCT ISNULL(SLCODE,'') AS SLCODE, ISNULL(SLDESC,'') AS SLDESC FROM TBL_AUDITTRIAL"
        '            SQLSTRING = SQLSTRING & " WHERE ACCOUNTCODE = '" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("Accountcode")) & "'  ORDER BY SLCODE"
        '            gconnection.getDataSet(SQLSTRING, "SLCODE")
        '            If gdataset.Tables("SLCODE").Rows.Count > 0 Then
        '                For J = 0 To gdataset.Tables("SLCODE").Rows.Count - 1
        '                    .Row = ROWCOUNT

        '                    .Col = 3
        '                    If Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLCode")) <> "" Then
        '                        .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SlCode"))
        '                    Else
        '                        .Text = ""
        '                    End If

        '                    .Col = 4
        '                    If Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLDesc")) <> "" Then
        '                        .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SlDesc"))
        '                    Else
        '                        .Text = ""
        '                    End If

        '                    .Col = 5
        '                    If Trim(gdataset.Tables("SLCODE").Rows(J).Item("sldesc")) <> "" Then
        '                        SQLSTRING = "SELECT ISNULL(SLCODE,'') AS SLCODE, ISNULL(SLDESC,'') SLDESC,ISNULL(CLDEBITS,0) AS CLDEBITS, ISNULL(CLCREDITS,0) AS CLCREDITS FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("Accountcode")) & "' AND ISNULL(FREEZEFLAG,'')<>'Y' and Slcode='" & Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLCODE")) & "'"
        '                        gconnection.getDataSet(SQLSTRING, "Subledger")
        '                        If gdataset.Tables("Subledger").Rows.Count > 0 Then
        '                            If gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS") = gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS") Then
        '                                .Text = Format(Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS")) - Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS")), "0.00")
        '                            ElseIf gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS") > gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS") Then
        '                                .Text = Format(Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS")) - Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS")), "0.00") & " - Dr "
        '                            Else
        '                                .Text = Format(Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS")) - Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS")), "0.00") & " - Cr "
        '                            End If
        '                            CLS_CREDITS = Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLCREDITS"))
        '                            CLS_DEBITS = Val(gdataset.Tables("SUBLEDGER").Rows(0).Item("CLDEBITS"))
        '                        End If
        '                        .Col = 6
        '                        .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        '                        SQLSTRING = "SELECT ISNULL(SUM(AMOUNT),0) As CREDITAMOUNT FROM TBL_AUDITTRIAL WHERE "
        '                        SQLSTRING = SQLSTRING & "ACCOUNTCODE='" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("Accountcode")) & "' AND ISNULL(VOID,'')<>'Y' and slcode='" & Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLCODE")) & "' AND CREDITDEBIT='CREDIT'"
        '                        gconnection.getDataSet(SQLSTRING, "PJV_CR_SL")
        '                        If gdataset.Tables("PJV_CR_SL").Rows.Count > 0 Then
        '                            .Text = Trim(gdataset.Tables("PJV_CR_SL").Rows(0).Item("CREDITAMOUNT"))
        '                        Else
        '                            .Text = ""
        '                        End If
        '                        CUR_CREDITS = Val(gdataset.Tables("PJV_CR_SL").Rows(0).Item("CREDITAMOUNT"))
        '                        .Col = 7
        '                        .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        '                        SQLSTRING = "SELECT ISNULL(SUM(AMOUNT),0) CREDITAMOUNT FROM TBL_AUDITTRIAL WHERE "
        '                        SQLSTRING = SQLSTRING & "ACCOUNTCODE='" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("AccountCODE")) & "' AND ISNULL(VOID,'')<>'Y' and slcode='" & Trim(gdataset.Tables("SLCODE").Rows(J).Item("slCODE")) & "' AND CREDITDEBIT='DEBIT'"
        '                        gconnection.getDataSet(SQLSTRING, "PJV_DB_SL")
        '                        If gdataset.Tables("PJV_DB_SL").Rows.Count > 0 Then
        '                            .Text = Trim(gdataset.Tables("PJV_DB_SL").Rows(0).Item("CREDITAMOUNT"))
        '                        Else
        '                            .Text = ""
        '                        End If
        '                        CUR_DEBITS = Val(gdataset.Tables("PJV_DB_SL").Rows(0).Item("CREDITAMOUNT"))
        '                    Else
        '                        SQLSTRING = "Select Isnull(Accode,'') as Accode, Isnull(Acdesc,'') as Acdesc,Isnull(CLDEBITS,0) As CLDEBITS, Isnull(CLCREDITS,0) As CLCREDITS  from AccountsGlAccountMaster  where isnull(Freezeflag,'') <> 'Y' AND ACCODE='" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("ACCOUNTCODE")) & "'"
        '                        gconnection.getDataSet(SQLSTRING, "ACCOUNTMASTER")
        '                        If gdataset.Tables("ACCOUNTMASTER").Rows.Count > 0 Then
        '                            If gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS") = gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS") Then
        '                                .Text = Format(Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS")) - Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS")), "0.00")
        '                            ElseIf gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS") > gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS") Then
        '                                .Text = Format(Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS")) - Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS")), "0.00") & " - Dr "
        '                            Else
        '                                .Text = Format(Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS")) - Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS")), "0.00") & " - Cr "
        '                            End If
        '                            CLS_CREDITS = Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLCREDITS"))
        '                            CLS_DEBITS = Val(gdataset.Tables("AccountMAster").Rows(0).Item("CLDEBITS"))
        '                        End If
        '                        .Col = 6
        '                        .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        '                        SQLSTRING = "SELECT ISNULL(SUM(AMOUNT),0) CREDITAMOUNT FROM TBL_AUDITTRIAL WHERE "
        '                        SQLSTRING = SQLSTRING & "ACCOUNTCODE='" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("AccountCODE")) & "' AND ISNULL(VOID,'')<>'Y' AND CREDITDEBIT='CREDIT'"
        '                        gconnection.getDataSet(SQLSTRING, "PJV_CR_SL")
        '                        If gdataset.Tables("PJV_CR_SL").Rows.Count > 0 Then
        '                            .Text = Trim(gdataset.Tables("PJV_CR_SL").Rows(0).Item("CREDITAMOUNT"))
        '                            CUR_CREDITS = Val(gdataset.Tables("PJV_CR_SL").Rows(0).Item("CREDITAMOUNT"))
        '                        Else
        '                            .Text = ""
        '                            CUR_CREDITS = 0
        '                        End If
        '                        .Col = 7
        '                        .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        '                        SQLSTRING = "SELECT ISNULL(SUM(AMOUNT),0) DEBITAMOUNT FROM TBL_AUDITTRIAL WHERE "
        '                        SQLSTRING = SQLSTRING & "ACCOUNTCODE='" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("AccountCODE")) & "' AND ISNULL(VOID,'')<>'Y' AND CREDITDEBIT='DEBIT'"
        '                        gconnection.getDataSet(SQLSTRING, "PJV_DB_SL")
        '                        If gdataset.Tables("PJV_DB_SL").Rows.Count > 0 Then
        '                            .Text = Trim(gdataset.Tables("PJV_DB_SL").Rows(0).Item("DEBITAMOUNT"))
        '                            CUR_DEBITS = Val(gdataset.Tables("PJV_DB_SL").Rows(0).Item("DEBITAMOUNT"))
        '                        Else
        '                            .Text = ""
        '                            CUR_DEBITS = 0
        '                        End If
        '                    End If
        '                    CUR_GRANDCREDITSTOTAL = CUR_GRANDCREDITSTOTAL + CUR_CREDITS
        '                    CUR_GRANDDEBITSTOTAL = CUR_GRANDDEBITSTOTAL + CUR_DEBITS
        '                    CUR_GRANDCREDITS = CUR_GRANDCREDITS + CUR_CREDITS
        '                    CUR_GRANDDEBITS = CUR_GRANDDEBITS + CUR_DEBITS
        '                    TOT_CREDITS = CLS_CREDITS + CUR_CREDITS
        '                    TOT_DEBITS = CLS_DEBITS + CUR_DEBITS
        '                    .Col = 8
        '                    If TOT_DEBITS = TOT_CREDITS Then
        '                        .Text = TOT_DEBITS - TOT_CREDITS
        '                    ElseIf TOT_DEBITS > TOT_CREDITS Then
        '                        .Text = Format(TOT_DEBITS - TOT_CREDITS, "0.00") & " - Dr "
        '                    Else
        '                        .Text = Format(TOT_CREDITS - TOT_DEBITS, "0.00") & " - Cr "
        '                    End If
        '                    ROWCOUNT = ROWCOUNT + 1
        '                    .MaxRows = .MaxRows + 1
        '                Next J
        '            End If
        '        End With
        '    Next I
        '    GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 1
        '    ROWCOUNT = ROWCOUNT + 1
        '    GrdAuditTrail.Row = ROWCOUNT
        '    GrdAuditTrail.Col = 5
        '    GrdAuditTrail.Text = "TOTAL"
        '    GrdAuditTrail.Col = 6
        '    GrdAuditTrail.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        '    GrdAuditTrail.Text = CUR_GRANDCREDITS
        '    GrdAuditTrail.Col = 7
        '    GrdAuditTrail.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        '    GrdAuditTrail.Text = CUR_GRANDDEBITS
        '    GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 1
        '    ROWCOUNT = ROWCOUNT + 1
        '    GrdAuditTrail.Row = ROWCOUNT

        '    GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 1
        '    ROWCOUNT = ROWCOUNT + 1
        '    GrdAuditTrail.Row = ROWCOUNT
        '    GrdAuditTrail.Col = 5
        '    GrdAuditTrail.Text = "GRAND TOTAL"
        '    GrdAuditTrail.Col = 6
        '    GrdAuditTrail.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        '    GrdAuditTrail.Text = CUR_GRANDCREDITSTOTAL
        '    GrdAuditTrail.Col = 7
        '    GrdAuditTrail.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        '    GrdAuditTrail.Text = CUR_GRANDDEBITSTOTAL
        '    GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 1
        '    ROWCOUNT = ROWCOUNT + 1
        'End If
        Grp_AccountPosting.Visible = True
        Accountpostingssgrid.Visible = False
        GroupBox2.Visible = False
        'End Audit Trial
    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
    Private Sub Cmd_Fill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Fill.Click
        Call Fillaccountpostingdetails()
    End Sub
    Private Sub Cmd_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Cancel.Click
        grp_Billposting.Top = 1000
        Cmd_View.Focus()
    End Sub
    Private Sub Accountposting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call Cmd_Fill_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call Cmd_Posted_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F10 Then
            Call cmdDosView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F12 Then
            Call Cmd_Print_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Then
            Call Cmd_Exit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Then
            If grp_Billposting.Top = 80 Then
                grp_Billposting.Top = 1000
                Cmd_View.Focus()
                Exit Sub
            Else
                Call Cmd_Exit_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.Alt = True And e.KeyCode = Keys.G Then
            Me.Accountpostingssgrid.Focus()
            Me.Accountpostingssgrid.SetActiveCell(1, 1)
            Exit Sub
        End If
    End Sub
    Private Sub dtp_Fromdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Fromdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_Todate.Focus()
        End If
    End Sub
    Private Sub dtp_Todate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Todate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmd_Fill.Focus()
        End If
    End Sub

    Private Sub Accountposting_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Accountpostingbool = False
    End Sub
    Private Sub Fillaccountpostingdetails()
        Dim strsql, varpayment, varsubpayment, varposloc, varbillno, VkotNo, VBillNo As String
        Dim i, j, k, row As Integer
        Dim Billdate As Date
        Dim billdatebool As Boolean
        Dim dblTaxamount, dblTotalamount, dblnetamount, dblSubTaxamount, dblSubTotalamount, dblSubnetamount As Double
        'Added on 09 Feb'08
        'MK Kannan
        'Begin Audit Trial
        Dim dblPackamount, dblSubPackAmount, dblRoundoffamount, dblSubRoundoffAmount As Double
        Dim dblTaxamountPosCode, dblPackamountPosCode, dblRoundoffamountPosCode, dblTotalamountPosCode, dblnetamountPosCode As Double
        Dim dblTaxamountPayMode, dblPackamountPayMode, dblRoundoffamountPayMode, dblTotalamountPayMode, dblnetamountPayMode As Double
        Dim dblTaxamountSalesAcct, dblPackamountSalesAcct, dblRoundoffamountSalesAcct, dblTotalamountSalesAcct, dblnetamountSalesAcct As Double
        Dim dblTaxamountTaxAcct, dblPackamountTaxAcct, dblRoundoffamountTaxAcct, dblTotalamountTaxAcct, dblnetamountTaxAcct As Double
        Dim dblTaxamountPackAcct, dblPackamountPackAcct, dblRoundoffamountPackAcct, dblTotalamountPackAcct, dblnetamountPackAcct As Double
        Dim dblTaxamountRoundoffAcct, dblPackamountRoundoffAcct, dblRoundoffamountRoundoffAcct, dblTotalamountRoundoffAcct, dblnetamountRoundoffAcct As Double
        Dim dblGTotalAmount, dblGTaxamount, dblGPackamount, dblGRoundoffamount, dblGnetamount As Double
        Dim dblGSubTotalamount, dblGSubTaxamount, dblGSubPackAmount, dblGSubRoundoffAmount, dblGSubnetamount As Double
        Dim strSalesCode, strSalesCodeDesc, strTaxCode, strTaxCodeDesc, strPackCode, strPackCodeDesc, strRoundoffCode, strRoundoffCodeDesc, strPostHead As String
        'End
        i = 1
        row = 3
        Try
            Accountpostingssgrid.ClearRange(1, 1, -1, -1, True)
            With Accountpostingssgrid
                .Row = 1
                .Col = 1
                .Text = "PaymentMode"
                .FontBold = True
                .Col = 2
                .Text = "SubPaymentMode"
                .FontBold = True
                .Col = 3
                .Text = "Pos Location"
                .FontBold = True
                .Col = 4
                .Text = "Bill Number"
                .FontBold = True
                .Col = 5
                .Text = "Basic Amount"
                .FontBold = True
                .Col = 6
                .Text = "Tax Amount"
                .FontBold = True
                .Col = 7
                .Text = "Pack Amount"
                .FontBold = True
                .Col = 8
                .Text = "Roundoff Amt"
                .FontBold = True
                .Col = 9
                .Text = "Net Amount"
                .FontBold = True
                .Col = 10
                .Text = "Sales Account In"
                .FontBold = True
                .Col = 11
                .Text = "Description"
                .FontBold = True
                .Col = 12
                .Text = "Tax Account In"
                .FontBold = True
                .Col = 13
                .Text = "Description"
                .FontBold = True
                .Col = 14
                .Text = "Pack Account In"
                .FontBold = True
                .Col = 15
                .Text = "Description"
                .FontBold = True
                .Col = 16
                .Text = "Roundoff Account In"
                .FontBold = True
                .Col = 17
                .Text = "Description"
                .FontBold = True
            End With
            strPostHead = ""
            For j = 0 To 1
                If j = 0 Then
                    strsql = "Exec Cp_AccountsPostingView_Others " & "'" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "','" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "', 'T'"
                    strPostHead = "Posted Accounts"
                Else
                    strsql = "Exec Cp_AccountsPostingView_Others " & "'" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "','" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "', 'P'"
                    If Len(Trim(strPostHead)) > 0 Then
                        row = row + 2
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                    End If
                    strPostHead = "Accounts to be Posted"
                End If
                gconnection.dataOperation(6, strsql, "AccountsPosting_SP")
                strsql = "Select ISNULL(BILLDETAILS,'') AS BILLDETAILS, ISNULL(BILLDATE,'') AS BILLDATE, ISNULL(AMOUNT,0) AS AMOUNT, ISNULL(TAXAMOUNT,0) AS TAXAMOUNT, ISNULL(PACKAMOUNT,0) AS PACKAMOUNT, ISNULL(BILLAMOUNT,0) AS BILLAMOUNT, ISNULL(ROUNDOFF,0) AS ROUNDOFF, ISNULL(PACKACCOUNTCODE,'') AS PACKACCOUNTCODE, ISNULL(PACKACCOUNTDESC,'') AS PACKACCOUNTDESC, ISNULL(ROUNDACCOUNTCODE,'') AS ROUNDACCOUNTCODE, ISNULL(ROUNDACCOUNTDESC,'') AS ROUNDACCOUNTDESC, ISNULL(PAYMENTMODE,'') AS PAYMENTMODE, ISNULL(PAYMENTACCOUNTCODE,'') AS PAYMENTACCOUNTCODE, ISNULL(SUBPAYMENTMODE,'') AS SUBPAYMENTMODE, ISNULL(SUBPAYMENTNAME,'') AS SUBPAYMENTNAME, ISNULL(SUBPAYMENTACCOUNTCODE,'') AS SUBPAYMENTACCOUNTCODE, ISNULL(POSCODE,'') AS POSCODE, ISNULL(POSDESC,'') AS POSDESC, ISNULL(POSACCOUNTCODE,'') AS POSACCOUNTCODE, ISNULL(POSACCOUNTDESC,'') AS POSACCOUNTDESC, ISNULL(TAXACCOUNTCODE,'') AS TAXACCOUNTCODE, ISNULL(TAXACCOUNTDESC,'') AS TAXACCOUNTDESC, ISNULL(PREFIX,'') AS PREFIX, ISNULL(MCODE,'') AS MCODE, ISNULL(MNAME,'') AS MNAME from AccountsPosting Where Isnull(Poscode,'') <> '' Order By BillDate,PaymentMode,SubPaymentMode,PosDesc,PoSAccountCode, TaxAccountCode,PackAccountcode,BillDetails"
                gconnection.getDataSet(strsql, "AccountsPosting")
                If gdataset.Tables("AccountsPosting").Rows.Count > 0 Then
                    Accountpostingssgrid.Row = row
                    Accountpostingssgrid.Col = 4
                    Accountpostingssgrid.Text = strPostHead
                    'strSalesCode = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(0).Item("PosAccOuntCode")))
                    'strSalesCodeDesc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(0).Item("PosAccountDesc")))
                    'strTaxCode = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(0).Item("TAXACCOUNTCODE")))
                    'strTaxCodeDesc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(0).Item("TAXACCOUNTDESC")))
                    'strPackCode = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(0).Item("PACKACCOUNTCODE")))
                    'strPackCodeDesc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(0).Item("PACKACCOUNTDESC")))
                    'varpayment = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(0).Item("PAYMENTMODE")))
                    'varposloc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(0).Item("POSDESC")))
                    For i = 0 To gdataset.Tables("AccountsPosting").Rows.Count - 1
                        'Added on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        If strSalesCode <> Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PosAccOuntCode"))) Then
                            If Val(dblTotalamountSalesAcct) > 0 Then
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                Accountpostingssgrid.Col = 1
                                Accountpostingssgrid.Text = "SALES ACCOUNT TOTAL :"
                                Accountpostingssgrid.Col = 2
                                Accountpostingssgrid.Text = strSalesCode
                                Accountpostingssgrid.Col = 3
                                Accountpostingssgrid.Text = strSalesCodeDesc
                                'Accountpostingssgrid.Col = 5
                                'Accountpostingssgrid.Text = Format(Val(dblTaxamountSalesAcct), "0.00")
                                Accountpostingssgrid.Col = 5
                                Accountpostingssgrid.Text = Format(Val(dblTotalamountSalesAcct), "0.00")
                                'Accountpostingssgrid.Col = 7
                                'Accountpostingssgrid.Text = Format(Val(dblnetamountSalesAcct), "0.00")

                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                dblTaxamountSalesAcct = 0 : dblTotalamountSalesAcct = 0 : dblnetamountSalesAcct = 0 : dblPackamountSalesAcct = 0 : dblRoundoffamountSalesAcct = 0
                            End If
                            strSalesCode = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PosAccountCode")))
                            strSalesCodeDesc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PosAccountDesc")))
                        End If

                        If strTaxCode <> Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("TaxAccountCode"))) Then
                            If Val(dblTaxamountTaxAcct) > 0 Then
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                Accountpostingssgrid.Col = 1
                                Accountpostingssgrid.Text = "TAX SUB TOTAL :"
                                Accountpostingssgrid.Col = 2
                                Accountpostingssgrid.Text = strTaxCode
                                Accountpostingssgrid.Col = 3
                                Accountpostingssgrid.Text = strTaxCodeDesc
                                Accountpostingssgrid.Col = 6
                                Accountpostingssgrid.Text = Format(Val(dblTaxamountTaxAcct), "0.00")
                                'Accountpostingssgrid.Col = 6
                                'Accountpostingssgrid.Text = Format(Val(dblTotalamountTaxAcct), "0.00")
                                'Accountpostingssgrid.Col = 7
                                'Accountpostingssgrid.Text = Format(Val(dblnetamountTaxAcct), "0.00")

                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                dblTaxamountTaxAcct = 0 : dblTotalamountTaxAcct = 0 : dblnetamountTaxAcct = 0 : dblPackamountTaxAcct = 0 : dblRoundoffamountTaxAcct = 0
                            End If
                            strTaxCode = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("TaxAccountCode")))
                            strTaxCodeDesc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("TaxAccountDesc")))
                        End If

                        If strPackCode <> Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PackAccountCode"))) Then
                            If Val(dblPackamountPackAcct) > 0 Then
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                Accountpostingssgrid.Col = 1
                                Accountpostingssgrid.Text = "PACK SUB TOTAL :"
                                Accountpostingssgrid.Col = 2
                                Accountpostingssgrid.Text = strPackCode
                                Accountpostingssgrid.Col = 3
                                Accountpostingssgrid.Text = strPackCodeDesc
                                'Accountpostingssgrid.Col = 5
                                'Accountpostingssgrid.Text = Format(Val(dblTaxamountPackAcct), "0.00")
                                'Accountpostingssgrid.Col = 6
                                'Accountpostingssgrid.Text = Format(Val(dblTotalamountPackAcct), "0.00")
                                'Accountpostingssgrid.Col = 7
                                'Accountpostingssgrid.Text = Format(Val(dblnetamountPackAcct), "0.00")
                                Accountpostingssgrid.Col = 7
                                Accountpostingssgrid.Text = Format(Val(dblPackamountPackAcct), "0.00")
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                dblTaxamountPackAcct = 0 : dblTotalamountPackAcct = 0 : dblnetamountPackAcct = 0 : dblPackamountPackAcct = 0 : dblRoundoffamountPackAcct = 0
                            End If
                            strPackCode = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PackAccountCode")))
                            strPackCodeDesc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PackAccountDesc")))
                        End If

                        If strRoundoffCode <> Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("RoundAccountCode"))) Then
                            If Val(dblRoundoffamountRoundoffAcct) > 0 Then
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                Accountpostingssgrid.Col = 1
                                Accountpostingssgrid.Text = "ROUNDOFF SUB TOTAL :"
                                Accountpostingssgrid.Col = 2
                                Accountpostingssgrid.Text = strRoundoffCode
                                Accountpostingssgrid.Col = 3
                                Accountpostingssgrid.Text = strRoundoffCodeDesc
                                'Accountpostingssgrid.Col = 5
                                'Accountpostingssgrid.Text = Format(Val(dblTaxamountPackAcct), "0.00")
                                'Accountpostingssgrid.Col = 6
                                'Accountpostingssgrid.Text = Format(Val(dblTotalamountPackAcct), "0.00")
                                'Accountpostingssgrid.Col = 7
                                'Accountpostingssgrid.Text = Format(Val(dblnetamountPackAcct), "0.00")
                                Accountpostingssgrid.Col = 7
                                Accountpostingssgrid.Text = Format(Val(dblRoundoffamountRoundoffAcct), "0.00")
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                dblTaxamountPackAcct = 0 : dblTotalamountPackAcct = 0 : dblnetamountPackAcct = 0 : dblPackamountPackAcct = 0 : dblRoundoffamountRoundoffAcct = 0
                            End If
                            strRoundoffCode = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("RoundAccountCode")))
                            strRoundoffCodeDesc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("RoundAccountDesc")))
                        End If

                        If Trim(varpayment) <> Trim(gdataset.Tables("AccountsPosting").Rows(i).Item("PAYMENTMODE")) Then
                            'Added on 09 Feb'08
                            'MK Kannan
                            'Begin Audit Trial
                            If Val(dblTotalamountPayMode) > 0 Or Val(dblTaxamountPayMode) > 0 Or Val(dblPackamountPayMode) > 0 Or Val(dblnetamountPayMode) > 0 Then
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                Accountpostingssgrid.Col = 1
                                Accountpostingssgrid.Text = "PAYMENT MODE SUB TOTAL :"
                                'Modified on 09 Feb'08
                                'MK Kannan
                                'Begin Audit Trial
                                'Accountpostingssgrid.Col = 5
                                'Accountpostingssgrid.Text = Format(Val(dblTaxamountPayMode), "0.00")
                                'Accountpostingssgrid.Col = 6
                                'Accountpostingssgrid.Text = Format(Val(dblTotalamountPayMode), "0.00")
                                'Accountpostingssgrid.Col = 7
                                'Accountpostingssgrid.Text = Format(Val(dblnetamountPayMode), "0.00")
                                Accountpostingssgrid.Col = 5
                                Accountpostingssgrid.Text = Format(Val(dblTotalamountPayMode), "0.00")
                                Accountpostingssgrid.Col = 6
                                Accountpostingssgrid.Text = Format(Val(dblTaxamountPayMode), "0.00")
                                Accountpostingssgrid.Col = 7
                                Accountpostingssgrid.Text = Format(Val(dblPackamountPayMode), "0.00")
                                Accountpostingssgrid.Col = 8
                                Accountpostingssgrid.Text = Format(Val(dblRoundoffamountPayMode), "0.00")
                                Accountpostingssgrid.Col = 9
                                Accountpostingssgrid.Text = Format(Val(dblnetamountPayMode), "0.00")
                                'End
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                dblTaxamountPayMode = 0 : dblTotalamountPayMode = 0 : dblnetamountPayMode = 0 : dblPackamountPayMode = 0 : dblRoundoffamountPayMode = 0
                            End If
                            'End
                        End If

                        If Trim(varposloc) <> Trim(gdataset.Tables("AccountsPosting").Rows(i).Item("POSDESC")) Then
                            'Added on 09 Feb'08
                            'MK Kannan
                            'Begin Audit Trial
                            If Val(dblTaxamountPosCode) > 0 Or Val(dblTotalamountPosCode) > 0 Or Val(dblPackamountPosCode) > 0 Or Val(dblnetamountPosCode) > 0 Then
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                Accountpostingssgrid.Col = 1
                                Accountpostingssgrid.Text = "POS SUB TOTAL :"
                                'Modified on 09 Feb'08
                                'MK Kannan
                                'Begin Audit Trial
                                'Accountpostingssgrid.Col = 5
                                'Accountpostingssgrid.Text = Format(Val(dblTaxamountPosCode), "0.00")
                                'Accountpostingssgrid.Col = 6
                                'Accountpostingssgrid.Text = Format(Val(dblTotalamountPosCode), "0.00")
                                'Accountpostingssgrid.Col = 7
                                'Accountpostingssgrid.Text = Format(Val(dblnetamountPosCode), "0.00")
                                Accountpostingssgrid.Col = 5
                                Accountpostingssgrid.Text = Format(Val(dblTotalamountPosCode), "0.00")
                                Accountpostingssgrid.Col = 6
                                Accountpostingssgrid.Text = Format(Val(dblTaxamountPosCode), "0.00")
                                Accountpostingssgrid.Col = 7
                                Accountpostingssgrid.Text = Format(Val(dblPackamountPosCode), "0.00")
                                Accountpostingssgrid.Col = 9
                                Accountpostingssgrid.Text = Format(Val(dblRoundoffamountPosCode), "0.00")
                                Accountpostingssgrid.Col = 9
                                Accountpostingssgrid.Text = Format(Val(dblnetamountPosCode), "0.00")
                            End If
                            'End
                            row = row + 1
                            Accountpostingssgrid.Row = row
                            Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                            dblTaxamountPosCode = 0 : dblTotalamountPosCode = 0 : dblnetamountPosCode = 0 : dblPackamountPosCode = 0 : dblRoundoffamountPosCode = 0
                            'End
                        End If
                        'End

                        If Format(CDate(Billdate), "dd-MMM-yyyy") <> Format(CDate(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLDATE")), "dd-MMM-yyyy") Then
                            If billdatebool = True Then
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1

                                Accountpostingssgrid.Col = 1
                                Accountpostingssgrid.Text = "SUB TOTAL :"

                                'Modified on 09 Feb'08
                                'MK Kannan
                                'Begin Audit Trial
                                'Accountpostingssgrid.Col = 5
                                'Accountpostingssgrid.Text = Format(Val(dblSubTaxamount), "0.00")
                                'Accountpostingssgrid.Col = 6
                                'Accountpostingssgrid.Text = Format(Val(dblSubTotalamount), "0.00")
                                'Accountpostingssgrid.Col = 7
                                'Accountpostingssgrid.Text = Format(Val(dblSubnetamount), "0.00")
                                Accountpostingssgrid.Col = 5
                                Accountpostingssgrid.Text = Format(Val(dblSubTotalamount), "0.00")
                                Accountpostingssgrid.Col = 6
                                Accountpostingssgrid.Text = Format(Val(dblSubTaxamount), "0.00")
                                Accountpostingssgrid.Col = 7
                                Accountpostingssgrid.Text = Format(Val(dblSubPackAmount), "0.00")
                                Accountpostingssgrid.Col = 8
                                Accountpostingssgrid.Text = Format(Val(dblSubRoundoffAmount), "0.00")
                                Accountpostingssgrid.Col = 9
                                Accountpostingssgrid.Text = Format(Val(dblSubnetamount), "0.00")
                                'End
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                Accountpostingssgrid.Col = 1
                                Accountpostingssgrid.Text = "BILL DATE :" & Format(CDate(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLDATE")), "dd-MMM-yyyy")
                                Accountpostingssgrid.BackColor = Color.Wheat

                                'Accountpostingssgrid.Col = 2
                                'Accountpostingssgrid.Text = Format(CDate(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLDATE")), "dd-MMM-yyyy")
                                'Accountpostingssgrid.BackColor = Color.Wheat
                                Billdate = Format(CDate(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLDATE")), "dd-MMM-yyyy")
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                dblSubTaxamount = 0 : dblSubTotalamount = 0 : dblSubnetamount = 0 : dblSubPackAmount = 0 : dblSubRoundoffAmount = 0
                            Else
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                                Accountpostingssgrid.Col = 1
                                Accountpostingssgrid.Text = "BILL DATE :  " & Format(CDate(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLDATE")), "dd-MMM-yyyy")
                                Accountpostingssgrid.BackColor = Color.Wheat
                                'Accountpostingssgrid.Col = 2
                                'Accountpostingssgrid.Text = Format(CDate(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLDATE")), "dd-MMM-yyyy")
                                'Accountpostingssgrid.BackColor = Color.Wheat
                                Billdate = Format(CDate(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLDATE")), "dd-MMM-yyyy")
                                row = row + 1
                                Accountpostingssgrid.Row = row
                                billdatebool = True
                                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                            End If
                        End If
                        If Trim(varpayment) <> Trim(gdataset.Tables("AccountsPosting").Rows(i).Item("PAYMENTMODE")) Then
                            row = row + 1
                            Accountpostingssgrid.Row = row
                            Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                            Accountpostingssgrid.Col = 1
                            Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PAYMENTMODE")))
                            Accountpostingssgrid.BackColor = Color.Yellow
                            varpayment = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PAYMENTMODE")))
                            varsubpayment = ""
                            row = row + 1
                            Accountpostingssgrid.Row = row
                            Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        End If

                        If Trim(varsubpayment) <> Trim(gdataset.Tables("AccountsPosting").Rows(i).Item("SUBPAYMENTNAME")) Then
                            row = row + 1
                            Accountpostingssgrid.Row = row
                            Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                            Accountpostingssgrid.Col = 2
                            Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("SUBPAYMENTNAME")))
                            Accountpostingssgrid.BackColor = Color.Wheat
                            varsubpayment = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("SUBPAYMENTNAME")))
                            varposloc = ""
                            row = row + 1
                            Accountpostingssgrid.Row = row
                            Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        End If
                        If Trim(varposloc) <> Trim(gdataset.Tables("AccountsPosting").Rows(i).Item("POSDESC")) Then
                            row = row + 1
                            Accountpostingssgrid.Row = row
                            Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1

                            Accountpostingssgrid.Col = 3
                            Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("POSDESC"))) & ":"
                            Accountpostingssgrid.BackColor = Color.Gold
                            varposloc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("POSDESC")))

                            'Modified on 09 Feb'08
                            'MK Kannan
                            'Begin Audit Trial
                            row = row + 1
                            Accountpostingssgrid.Row = row
                            Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                            'Else
                            'row = row + 1
                            'Accountpostingssgrid.Row = row
                            'End
                        End If

                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 4
                        Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLDETAILS")))

                        'Modified on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        'Accountpostingssgrid.Row = row
                        'Accountpostingssgrid.Col = 5
                        'Accountpostingssgrid.Text = Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        'dblTaxamount = Val(dblTaxamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        'dblSubTaxamount = Val(dblSubTaxamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 5
                        Accountpostingssgrid.Text = Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        dblTotalamount = Val(dblTotalamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        dblSubTotalamount = Val(dblSubTotalamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        'End
                        'Added on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        dblTotalamountPayMode = Val(dblTotalamountPayMode) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        dblTotalamountSalesAcct = Val(dblTotalamountSalesAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        'dblTotalamountTaxAcct = Val(dblTotalamountTaxAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        'dblTotalamountPackAcct = Val(dblTotalamountPackAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        dblTotalamountPosCode = Val(dblTotalamountPosCode) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        'End

                        'Modified on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        'Accountpostingssgrid.Row = row
                        'Accountpostingssgrid.Col = 6
                        'Accountpostingssgrid.Text = Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        'dblTotalamount = Val(dblTotalamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        'dblSubTotalamount = Val(dblSubTotalamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("AMOUNT")), "0.00")
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 6
                        Accountpostingssgrid.Text = Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        dblTaxamount = Val(dblTaxamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        dblSubTaxamount = Val(dblSubTaxamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        'End
                        'Added on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        dblTaxamountPayMode = Val(dblTaxamountPayMode) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        'dblTaxamountSalesAcct = Val(dblTaxamountSalesAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        dblTaxamountTaxAcct = Val(dblTaxamountTaxAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        'dblTaxamountPackAcct = Val(dblTaxamountPackAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        dblTaxamountPosCode = Val(dblTaxamountPosCode) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXAMOUNT")), "0.00")
                        'End

                        'Modified on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 7
                        Accountpostingssgrid.Text = Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("PACKAMOUNT")), "0.00")
                        dblPackamount = Val(dblPackamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("PACKAMOUNT")), "0.00")
                        dblSubPackAmount = Val(dblSubPackAmount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("PACKAMOUNT")), "0.00")
                        'End

                        'Added on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        dblPackamountPayMode = Val(dblPackamountPayMode) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("PACKAMOUNT")), "0.00")
                        'dblPackamountSalesAcct = Val(dblPackamountSalesAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("PACKAMOUNT")), "0.00")
                        'dblPackamountTaxAcct = Val(dblPackamountTaxAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("PACKAMOUNT")), "0.00")
                        dblPackamountPackAcct = Val(dblPackamountPackAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("PACKAMOUNT")), "0.00")
                        dblPackamountPosCode = Val(dblPackamountPosCode) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("PACKAMOUNT")), "0.00")
                        'End

                        'Modified on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 8
                        Accountpostingssgrid.Text = Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDOFF")), "0.00")
                        dblRoundoffamount = Val(dblRoundoffamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDOFF")), "0.00")
                        dblSubRoundoffAmount = Val(dblSubRoundoffAmount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDOFF")), "0.00")
                        'End

                        'Added on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        dblRoundoffamountPayMode = Val(dblRoundoffamountPayMode) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDOFF")), "0.00")
                        'dblRoundoffamountSalesAcct = Val(dblRoundoffamountSalesAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDOFF")), "0.00")
                        'dblRoundoffamountTaxAcct = Val(dblRoundoffamountTaxAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDOFF")), "0.00")
                        'dblRoundoffamountPackAcct = Val(dblRoundoffamountPackAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDOFF")), "0.00")
                        dblRoundoffamountPosCode = Val(dblRoundoffamountPosCode) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDOFF")), "0.00")
                        dblRoundoffamountRoundoffAcct = Val(dblRoundoffamountRoundoffAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDOFF")), "0.00")
                        'End

                        'Modified on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 9
                        Accountpostingssgrid.Text = Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLAMOUNT")), "0.00")
                        dblnetamount = Val(dblnetamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLAMOUNT")), "0.00")
                        dblSubnetamount = Val(dblSubnetamount) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLAMOUNT")), "0.00")
                        'End

                        'Added on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        dblnetamountPayMode = Val(dblnetamountPayMode) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLAMOUNT")), "0.00")
                        dblnetamountSalesAcct = Val(dblnetamountSalesAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLAMOUNT")), "0.00")
                        dblnetamountTaxAcct = Val(dblnetamountTaxAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLAMOUNT")), "0.00")
                        dblnetamountPackAcct = Val(dblnetamountPackAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLAMOUNT")), "0.00")
                        dblnetamountPosCode = Val(dblnetamountPosCode) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLAMOUNT")), "0.00")
                        dblnetamountRoundoffAcct = Val(dblnetamountRoundoffAcct) + Format(Val(gdataset.Tables("AccountsPosting").Rows(i).Item("BILLAMOUNT")), "0.00")
                        'End

                        'Modified on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        'Accountpostingssgrid.Row = row
                        'Accountpostingssgrid.Col = 8
                        'Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXACCOUNTCODE")))
                        'Accountpostingssgrid.Row = row
                        'Accountpostingssgrid.Col = 9
                        'Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("TaxAccountDesc")))
                        'Accountpostingssgrid.Row = row
                        'Accountpostingssgrid.Col = 10
                        'Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PosAccOuntCode")))
                        'Accountpostingssgrid.Row = row
                        'Accountpostingssgrid.Col = 11
                        'Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PosAccOuntDesc")))
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 10
                        Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PosAccOuntCode")))
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 11
                        Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PosAccOuntDesc")))
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 12
                        Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("TAXACCOUNTCODE")))
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 13
                        Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("TaxAccountDesc")))
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 14
                        Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PACKACCOUNTCODE")))
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 15
                        Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PACKACCOUNTDESC")))

                        'Added on 11 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 16
                        Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDACCOUNTCODE")))
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.Col = 17
                        Accountpostingssgrid.Text = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("ROUNDACCOUNTDESC")))
                        'End 11 Feb'08
                        'End

                        'If i = Accountpostingssgrid.MaxRows - 10 Then
                        '    Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 500
                        'End If
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                    Next

                    'Added on 09 Feb'08
                    'MK Kannan
                    'Begin Audit Trial
                    'If strSalesCode <> Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PosAccOuntCode"))) Then
                    If Val(dblTotalamountSalesAcct) > 0 Then
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        Accountpostingssgrid.Col = 1
                        Accountpostingssgrid.Text = "SALES SUB TOTAL :"
                        Accountpostingssgrid.Col = 2
                        Accountpostingssgrid.Text = strSalesCode
                        Accountpostingssgrid.Col = 3
                        Accountpostingssgrid.Text = strSalesCodeDesc
                        'Accountpostingssgrid.Col = 5
                        'Accountpostingssgrid.Text = Format(Val(dblTaxamountSalesAcct), "0.00")
                        Accountpostingssgrid.Col = 5
                        Accountpostingssgrid.Text = Format(Val(dblTotalamountSalesAcct), "0.00")
                        'Accountpostingssgrid.Col = 7
                        'Accountpostingssgrid.Text = Format(Val(dblnetamountSalesAcct), "0.00")
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        dblTaxamountSalesAcct = 0 : dblTotalamountSalesAcct = 0 : dblnetamountSalesAcct = 0 : dblPackamountSalesAcct = 0 : dblRoundoffamountSalesAcct = 0
                    End If
                    'strSalesCode = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PosAccountCode")))
                    'strSalesCodeDesc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PosAccountDesc")))
                    'End If

                    'If strTaxCode <> Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("TaxAccountCode"))) Then
                    If Val(dblTaxamountTaxAcct) > 0 Then
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        Accountpostingssgrid.Col = 1
                        Accountpostingssgrid.Text = "TAX SUB TOTAL :"
                        Accountpostingssgrid.Col = 2
                        Accountpostingssgrid.Text = strTaxCode
                        Accountpostingssgrid.Col = 3
                        Accountpostingssgrid.Text = strTaxCodeDesc
                        Accountpostingssgrid.Col = 6
                        Accountpostingssgrid.Text = Format(Val(dblTaxamountTaxAcct), "0.00")
                        'Accountpostingssgrid.Col = 6
                        'Accountpostingssgrid.Text = Format(Val(dblTotalamountTaxAcct), "0.00")
                        'Accountpostingssgrid.Col = 7
                        'Accountpostingssgrid.Text = Format(Val(dblnetamountTaxAcct), "0.00")
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        dblTaxamountTaxAcct = 0 : dblTotalamountTaxAcct = 0 : dblnetamountTaxAcct = 0 : dblPackamountTaxAcct = 0 : dblRoundoffamountTaxAcct = 0
                    End If
                    'strTaxCode = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("TaxAccountCode")))
                    'strTaxCodeDesc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("TaxAccountDesc")))
                    'End If

                    'If strPackCode <> Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PackAccountCode"))) Then
                    If Val(dblPackamountPackAcct) > 0 Then
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        Accountpostingssgrid.Col = 1
                        Accountpostingssgrid.Text = "PACK SUB TOTAL :"
                        Accountpostingssgrid.Col = 2
                        Accountpostingssgrid.Text = strPackCode
                        Accountpostingssgrid.Col = 3
                        Accountpostingssgrid.Text = strPackCodeDesc
                        'Accountpostingssgrid.Col = 5
                        'Accountpostingssgrid.Text = Format(Val(dblTaxamountPackAcct), "0.00")
                        'Accountpostingssgrid.Col = 6
                        'Accountpostingssgrid.Text = Format(Val(dblTotalamountPackAcct), "0.00")
                        'Accountpostingssgrid.Col = 7
                        'Accountpostingssgrid.Text = Format(Val(dblnetamountPackAcct), "0.00")
                        Accountpostingssgrid.Col = 7
                        Accountpostingssgrid.Text = Format(Val(dblPackamountPackAcct), "0.00")
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        dblTaxamountPackAcct = 0 : dblTotalamountPackAcct = 0 : dblnetamountPackAcct = 0 : dblPackamountPackAcct = 0 : dblRoundoffamountPackAcct = 0
                    End If
                    'strPackCode = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PackAccountCode")))
                    'strPackCodeDesc = Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("PackAccountDesc")))
                    'End If

                    'If strRoundoffCode <> Trim(CStr(gdataset.Tables("AccountsPosting").Rows(i).Item("RoundAccountCode"))) Then
                    If Val(dblRoundoffamountRoundoffAcct) <> 0 Then
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        Accountpostingssgrid.Col = 1
                        Accountpostingssgrid.Text = "ROUNDOFF SUB TOTAL :"
                        Accountpostingssgrid.Col = 2
                        Accountpostingssgrid.Text = strRoundoffCode
                        Accountpostingssgrid.Col = 3
                        Accountpostingssgrid.Text = strRoundoffCodeDesc
                        'Accountpostingssgrid.Col = 5
                        'Accountpostingssgrid.Text = Format(Val(dblTaxamountPackAcct), "0.00")
                        'Accountpostingssgrid.Col = 6
                        'Accountpostingssgrid.Text = Format(Val(dblTotalamountPackAcct), "0.00")
                        'Accountpostingssgrid.Col = 7
                        'Accountpostingssgrid.Text = Format(Val(dblnetamountPackAcct), "0.00")
                        Accountpostingssgrid.Col = 7
                        Accountpostingssgrid.Text = Format(Val(dblRoundoffamountRoundoffAcct), "0.00")
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        dblTaxamountPackAcct = 0 : dblTotalamountPackAcct = 0 : dblnetamountPackAcct = 0 : dblPackamountPackAcct = 0 : dblRoundoffamountRoundoffAcct = 0
                    End If
                    'End If

                    'If Trim(varpayment) <> Trim(gdataset.Tables("AccountsPosting").Rows(i).Item("PAYMENTMODE")) Then
                    'Added on 09 Feb'08
                    'MK Kannan
                    'Begin Audit Trial
                    If Val(dblTotalamountPayMode) > 0 Or Val(dblTaxamountPayMode) > 0 Or Val(dblPackamountPayMode) > 0 Or Val(dblnetamountPayMode) > 0 Or Val(dblRoundoffamountPayMode) <> 0 Then
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        Accountpostingssgrid.Col = 1
                        Accountpostingssgrid.Text = "PAYMENT MODE SUB TOTAL :"
                        'Modified on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        'Accountpostingssgrid.Col = 5
                        'Accountpostingssgrid.Text = Format(Val(dblTaxamountPayMode), "0.00")
                        'Accountpostingssgrid.Col = 6
                        'Accountpostingssgrid.Text = Format(Val(dblTotalamountPayMode), "0.00")
                        'Accountpostingssgrid.Col = 7
                        'Accountpostingssgrid.Text = Format(Val(dblnetamountPayMode), "0.00")
                        Accountpostingssgrid.Col = 5
                        Accountpostingssgrid.Text = Format(Val(dblTotalamountPayMode), "0.00")
                        Accountpostingssgrid.Col = 6
                        Accountpostingssgrid.Text = Format(Val(dblTaxamountPayMode), "0.00")
                        Accountpostingssgrid.Col = 7
                        Accountpostingssgrid.Text = Format(Val(dblPackamountPayMode), "0.00")
                        Accountpostingssgrid.Col = 8
                        Accountpostingssgrid.Text = Format(Val(dblRoundoffamountPayMode), "0.00")
                        Accountpostingssgrid.Col = 9
                        Accountpostingssgrid.Text = Format(Val(dblnetamountPayMode), "0.00")
                        'End
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        dblTaxamountPayMode = 0 : dblTotalamountPayMode = 0 : dblnetamountPayMode = 0 : dblPackamountPayMode = 0 : dblRoundoffamountPayMode = 0
                    End If
                    'End
                    'End If

                    'If Trim(varposloc) <> Trim(gdataset.Tables("AccountsPosting").Rows(i).Item("POSDESC")) Then
                    'Added on 09 Feb'08
                    'MK Kannan
                    'Begin Audit Trial
                    If Val(dblTaxamountPosCode) > 0 Or Val(dblTotalamountPosCode) > 0 Or Val(dblPackamountPosCode) > 0 Or Val(dblnetamountPosCode) > 0 Or Val(dblRoundoffamountPosCode) <> 0 Then
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        Accountpostingssgrid.Col = 1
                        Accountpostingssgrid.Text = "POS SUB TOTAL :"
                        'Modified on 09 Feb'08
                        'MK Kannan
                        'Begin Audit Trial
                        'Accountpostingssgrid.Col = 5
                        'Accountpostingssgrid.Text = Format(Val(dblTaxamountPosCode), "0.00")
                        'Accountpostingssgrid.Col = 6
                        'Accountpostingssgrid.Text = Format(Val(dblTotalamountPosCode), "0.00")
                        'Accountpostingssgrid.Col = 7
                        'Accountpostingssgrid.Text = Format(Val(dblnetamountPosCode), "0.00")
                        Accountpostingssgrid.Col = 5
                        Accountpostingssgrid.Text = Format(Val(dblTotalamountPosCode), "0.00")
                        Accountpostingssgrid.Col = 6
                        Accountpostingssgrid.Text = Format(Val(dblTaxamountPosCode), "0.00")
                        Accountpostingssgrid.Col = 7
                        Accountpostingssgrid.Text = Format(Val(dblPackamountPosCode), "0.00")
                        Accountpostingssgrid.Col = 9
                        Accountpostingssgrid.Text = Format(Val(dblRoundoffamountPosCode), "0.00")
                        Accountpostingssgrid.Col = 9
                        Accountpostingssgrid.Text = Format(Val(dblnetamountPosCode), "0.00")
                        row = row + 1
                        Accountpostingssgrid.Row = row
                        Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                        dblTaxamountPosCode = 0 : dblTotalamountPosCode = 0 : dblnetamountPosCode = 0 : dblPackamountPosCode = 0 : dblRoundoffamountPosCode = 0
                    End If
                    'End
                    'End
                    'End If
                    'End

                    row = row + 1
                    Accountpostingssgrid.Row = row
                    Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
                    Accountpostingssgrid.Col = 1
                    Accountpostingssgrid.Text = strPostHead & " SUB TOTAL :"

                    'Modified on 09 Feb'08
                    'MK Kannan
                    'Begin Audit Trial
                    'Accountpostingssgrid.Col = 5
                    'Accountpostingssgrid.Text = Format(Val(dblSubTaxamount), "0.00")
                    'Accountpostingssgrid.Col = 6
                    'Accountpostingssgrid.Text = Format(Val(dblSubTotalamount), "0.00")
                    'Accountpostingssgrid.Col = 7
                    'Accountpostingssgrid.Text = Format(Val(dblSubnetamount), "0.00")

                    Accountpostingssgrid.Col = 5
                    Accountpostingssgrid.Text = Format(Val(dblSubTotalamount), "0.00")
                    Accountpostingssgrid.Col = 6
                    Accountpostingssgrid.Text = Format(Val(dblSubTaxamount), "0.00")
                    Accountpostingssgrid.Col = 7
                    Accountpostingssgrid.Text = Format(Val(dblSubPackAmount), "0.00")
                    Accountpostingssgrid.Col = 8
                    Accountpostingssgrid.Text = Format(Val(dblSubRoundoffAmount), "0.00")
                    Accountpostingssgrid.Col = 9
                    Accountpostingssgrid.Text = Format(Val(dblSubnetamount), "0.00")

                    dblGSubTotalamount = dblGSubTotalamount + dblSubTotalamount
                    dblGSubTaxamount = dblGSubTaxamount + dblSubTaxamount
                    dblGSubPackAmount = dblGSubPackAmount + dblSubPackAmount
                    dblGSubRoundoffAmount = dblGSubRoundoffAmount + dblSubRoundoffAmount
                    dblGSubnetamount = dblGSubnetamount + dblSubnetamount
                    dblSubTotalamount = 0 : dblSubTaxamount = 0 : dblSubPackAmount = 0 : dblSubRoundoffAmount = 0 : dblSubnetamount = 0
                    'End
                    row = row + 2
                    Accountpostingssgrid.Row = row
                    Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 2
                    Accountpostingssgrid.Col = 1
                    Accountpostingssgrid.Text = strPostHead & " GRAND TOTAL :"
                    'Modified on 09 Feb'08
                    'MK Kannan
                    'Begin Audit Trial

                    'Accountpostingssgrid.Col = 5
                    'Accountpostingssgrid.Text = Format(Val(dblTaxamount), "0.00")
                    'Accountpostingssgrid.Col = 6
                    'Accountpostingssgrid.Text = Format(Val(dblTotalamount), "0.00")
                    'Accountpostingssgrid.Col = 7
                    'Accountpostingssgrid.Text = Format(Val(dblnetamount), "0.00")

                    Accountpostingssgrid.Col = 5
                    Accountpostingssgrid.Text = Format(Val(dblTotalamount), "0.00")
                    Accountpostingssgrid.Col = 6
                    Accountpostingssgrid.Text = Format(Val(dblTaxamount), "0.00")
                    Accountpostingssgrid.Col = 7
                    Accountpostingssgrid.Text = Format(Val(dblPackamount), "0.00")
                    Accountpostingssgrid.Col = 8
                    Accountpostingssgrid.Text = Format(Val(dblRoundoffamount), "0.00")
                    Accountpostingssgrid.Col = 9
                    Accountpostingssgrid.Text = Format(Val(dblnetamount), "0.00")
                    'End

                    dblGTotalAmount = dblGTotalAmount + dblTotalamount
                    dblGTaxamount = dblGTaxamount + dblTaxamount
                    dblGPackamount = dblGPackamount + dblPackamount
                    dblGRoundoffamount = dblGRoundoffamount + dblRoundoffamount
                    dblGnetamount = dblGnetamount + dblnetamount

                    dblTotalamount = 0 : dblTaxamount = 0 : dblPackamount = 0 : dblRoundoffamount = 0 : dblnetamount = 0
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                End If
            Next

            If dblGSubTotalamount > 0 Or dblGSubTaxamount > 0 Or dblGSubPackAmount > 0 Or dblGSubRoundoffAmount > 0 Or dblGSubnetamount > 0 Then
                row = row + 2
                Accountpostingssgrid.Row = row
                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 2
                Accountpostingssgrid.Col = 1
                Accountpostingssgrid.Text = "SUB TOTAL :"
                Accountpostingssgrid.Col = 5
                Accountpostingssgrid.Text = Format(Val(dblGSubTotalamount), "0.00")
                Accountpostingssgrid.Col = 6
                Accountpostingssgrid.Text = Format(Val(dblGSubTaxamount), "0.00")
                Accountpostingssgrid.Col = 7
                Accountpostingssgrid.Text = Format(Val(dblGSubPackAmount), "0.00")
                Accountpostingssgrid.Col = 8
                Accountpostingssgrid.Text = Format(Val(dblGSubRoundoffAmount), "0.00")
                Accountpostingssgrid.Col = 9
                Accountpostingssgrid.Text = Format(Val(dblGSubnetamount), "0.00")
            End If

            If dblGTotalAmount > 0 Or dblGTaxamount > 0 Or dblGPackamount > 0 Or dblGRoundoffamount > 0 Or dblGnetamount > 0 Then
                row = row + 2
                Accountpostingssgrid.Row = row
                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 2
                Accountpostingssgrid.Col = 1
                Accountpostingssgrid.Text = "GRAND TOTAL :"
                Accountpostingssgrid.Col = 5
                Accountpostingssgrid.Text = Format(Val(dblGTotalAmount), "0.00")
                Accountpostingssgrid.Col = 6
                Accountpostingssgrid.Text = Format(Val(dblGTaxamount), "0.00")
                Accountpostingssgrid.Col = 7
                Accountpostingssgrid.Text = Format(Val(dblGPackamount), "0.00")
                Accountpostingssgrid.Col = 8
                Accountpostingssgrid.Text = Format(Val(dblGRoundoffamount), "0.00")
                Accountpostingssgrid.Col = 9
                Accountpostingssgrid.Text = Format(Val(dblGnetamount), "0.00")
                row = row + 1
                Accountpostingssgrid.Row = row
                Accountpostingssgrid.MaxRows = Accountpostingssgrid.MaxRows + 1
            End If
            grp_Billposting.Top = 1000
        Catch ex As Exception
            MessageBox.Show("Plz Check The error " & ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='ACCOUNTS INTEGRATION' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.Cmd_Posted.Enabled = False
        Me.Cmd_View.Enabled = False
        Me.Cmd_Print.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Posted.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Me.Cmd_Print.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Posted.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Posted.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Posted.Enabled = True
                    End If
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.Cmd_Print.Enabled = True
                End If
            Next
        End If
    End Sub
    'Added on 08 Feb'08
    'Mk Kannan
    'Begin Audit Trial
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Grp_AccountPosting.Visible = False
        Accountpostingssgrid.Visible = True
        GroupBox2.Visible = True
    End Sub

    Private Sub cmdPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPost.Click
        Dim strsql As String
        Dim i As Integer
        Try
            'Modified on 06 AUG 08
            'Mk Kannan
            'Begin
            strsql = "EXEC Cp_AccountsPostingView_Others " & "'" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "','" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "', 'P'"
            gconnection.dataOperation(6, strsql, "ACCOUNTPOSTING")
            'strsql = "EXEC Cp_PosJv " & "'" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "','" & Mid(Trim(gFinancalyearStart), 3, 4) & "','" & Mid(Trim(gFinancialYearEnd), 3, 4) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "'"
            strsql = "EXEC Cp_PosJv_Others '" & Mid(Trim(gFinancalyearStart), 3, 4) & "','" & Mid(Trim(gFinancialYearEnd), 3, 4) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "', 'P'"
            'End
            gconnection.dataOperation(6, strsql, "ACCOUNTPOSTING")
            'strsql = "EXEC Cp_AccountUpdate"
            'gconnection.dataOperation(6, strsql, "ACCOUNTPOSTING1")
            MessageBox.Show("Account Posting Completed Sucessfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            For i = 0 To Accountpostingssgrid.DataRowCnt
                Accountpostingssgrid.Row = i
                Accountpostingssgrid.Col = 1
                Accountpostingssgrid.BackColor = Color.White
                Accountpostingssgrid.Row = i
                Accountpostingssgrid.Col = 2
                Accountpostingssgrid.BackColor = Color.White
                Accountpostingssgrid.Row = i
                Accountpostingssgrid.Col = 3
                Accountpostingssgrid.BackColor = Color.White
            Next
            Accountpostingssgrid.ClearRange(1, 1, -1, -1, True)
            grp_Billposting.Top = 1000
            If MsgBox("Do You Want to Refresh a Audit Trial Page!", MsgBoxStyle.YesNo, "Request!") = MsgBoxResult.Yes Then
                Call Cmd_Posted_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Account Posting is Terminated Abnormally! Bcoz " & ex.Message.ToString(), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Call ExportTo(GrdAuditTrail)
    End Sub
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        gPrint = False
        Call subAuditTrial()
    End Sub

    Private Sub subAuditTrial()
        Dim boolPrintNext As Boolean
        Dim vOutfile, vCaption, SSQL As String
        Dim strCol1, strCol2, strCol3, strCol4, strCol5, strCol6, strCol7, strCol8 As String
        Dim PageNo, I As Integer
        Dim intRowCount As Double
        Randomize()
        vOutfile = Mid("Aud" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = System.IO.File.AppendText(VFilePath)
        printfile = VFilePath
        I = 1 : intRowCount = 3 : vCaption = "" : PageNo = 1


        Dim intPageLength As Int16
        Dim strHead, strColumnHead As String
        intPageLength = 147
        vCaption = "THE ACCOUNTCODEWISE AUDIT TRIAL FOR POINT OF SALE'S ACCOUNT POSTING FROM " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & " TO " & Format(dtp_Todate.Value, "dd-MMM-yyyy")
        strColumnHead = "|  AcCode  | Description                  |  SlCode  | Description                  |Opening Balance |   Credit    |    Debit    |Closing Balance |"
        With GrdAuditTrail
            If .DataRowCnt > 3 Then
                For I = 3 To .DataRowCnt
                    .Row = I
                    .Col = 1
                    strCol1 = Trim(.Text)

                    .Col = 2
                    strCol2 = Mid(Trim(.Text), 1, 30)

                    .Col = 3
                    strCol3 = Trim(.Text)

                    .Col = 4
                    strCol4 = Mid(Trim(.Text), 1, 30)

                    .Col = 5
                    strCol5 = Trim(.Text)

                    .Col = 6
                    strCol6 = Trim(.Text)

                    .Col = 7
                    strCol7 = Trim(.Text)

                    .Col = 8
                    strCol8 = Trim(.Text)

                    boolPrintNext = False

                    If intRowCount > 61 Or (PageNo = 1 And intRowCount = 3) Then
                        If intRowCount > 61 Then
                            gconnection.subWriteLine(intPageLength, True)
                            gconnection.subPrintFooter(intPageLength, PageNo, True)
                            PageNo = PageNo + 1
                        End If
                        gconnection.subPrintHeader(vCaption, strColumnHead, intPageLength, True)
                        intRowCount = 11
                    End If

                    If strCol1 = "" And strCol4 = "" And strCol5 = "" Then
                        gconnection.subWriteLine(intPageLength, True)
                        intRowCount = intRowCount + 1
                        boolPrintNext = True
                    End If
                    If strCol4.ToUpper = "POSTED ACCOUNTS" Then
                        Filewrite.WriteLine(Chr(15) & "|" & Space(59) & strCol4 & Space(86 - Len(strCol4)) & "|")
                        intRowCount = intRowCount + 1
                        boolPrintNext = True
                    End If

                    If strCol4.ToUpper = "ACCOUNTS TO BE POSTED" Then
                        Filewrite.WriteLine(Chr(15) & "|" & Space(59) & strCol4 & Space(86 - Len(strCol4)) & "|")
                        intRowCount = intRowCount + 1
                        boolPrintNext = True
                    End If

                    If strCol5.ToUpper = "TOTAL" Then
                        Filewrite.WriteLine(Chr(15) & "|" & Space(91) & strCol5 & Space(5) & Space(14 - Len(strCol6)) & strCol6 & Space(14 - Len(strCol7)) & strCol7 & Space(16) & "|")
                        intRowCount = intRowCount + 1
                        boolPrintNext = True
                    End If

                    If strCol5.ToUpper = "GRAND TOTAL" Then
                        Filewrite.WriteLine(Chr(15) & "|" & Space(85) & strCol5 & Space(5) & Space(14 - Len(strCol6)) & strCol6 & Space(14 - Len(strCol7)) & strCol7 & Space(16) & "|")
                        intRowCount = intRowCount + 1
                        boolPrintNext = True
                    End If

                    SSQL = "|" & strCol1 & Space(10 - Len(strCol1))
                    SSQL = SSQL & "|" & strCol2 & Space(30 - Len(strCol2))
                    SSQL = SSQL & "|" & strCol3 & Space(10 - Len(strCol3))
                    SSQL = SSQL & "|" & strCol4 & Space(30 - Len(strCol4))
                    SSQL = SSQL & "|" & Space(16 - Len(strCol5)) & strCol5
                    SSQL = SSQL & "|" & Space(13 - Len(strCol6)) & strCol6
                    SSQL = SSQL & "|" & Space(13 - Len(strCol7)) & strCol7
                    SSQL = SSQL & "|" & Space(16 - Len(strCol8)) & strCol8 & "|"
                    If boolPrintNext = False Then
                        Filewrite.WriteLine(Chr(15) & SSQL)
                        intRowCount = intRowCount + 1
                    End If
                Next
                gconnection.subWriteLine(intPageLength, True)
                gconnection.subPrintFooter(intPageLength, PageNo, True)
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            End If
        End With
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        Call subPoSView()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        gPrint = True
        Call subAuditTrial()
    End Sub

    Private Sub cmdDosView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDosView.Click
        gPrint = False
        Call subPoSView()
    End Sub
    Private Sub subPoSView()
        Dim boolPrintNext As Boolean
        Dim vOutfile, vCaption, SSQL As String
        Dim strCol1, strCol2, strCol3, strCol4, strCol5, strCol6, strCol7, strCol8, strCol9 As String
        Dim PageNo, I As Integer
        Dim intRowCount As Double
        Randomize()
        vOutfile = Mid("POS" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = System.IO.File.AppendText(VFilePath)
        printfile = VFilePath
        I = 1 : intRowCount = 3 : vCaption = "" : PageNo = 1

        Dim intPageLength As Int16
        Dim strHead, strColumnHead, strLine As String
        intPageLength = 155
        vCaption = "THE BILLWISE AUDIT TRIAL FOR POINT OF SALE'S ACCOUNT POSTING FROM " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & " TO " & Format(dtp_Todate.Value, "dd-MMM-yyyy")
        strColumnHead = "| Pay Mode      |SubPayMode     |PoS                 | Bill Number                  |Basic Amount |Tax Amount   | Pack Amount |Roundoff Amt | Net Amount  |"
        strLine = "|" & Space(15) & "|" & Space(15) & "|" & Space(20) & "|" & Space(30) & "|" & Space(13) & "|" & Space(13) & "|" & Space(13) & "|" & Space(13) & "|" & Space(13) & "|"
        With Accountpostingssgrid
            If .DataRowCnt > 2 Then
                For I = 3 To .DataRowCnt
                    .Row = I
                    .Col = 1
                    strCol1 = Trim(.Text)

                    .Col = 2
                    strCol2 = Trim(.Text)

                    .Col = 3
                    strCol3 = Trim(.Text)

                    .Col = 4
                    strCol4 = Trim(.Text)

                    .Col = 5
                    strCol5 = Trim(.Text)

                    .Col = 6
                    strCol6 = Trim(.Text)

                    .Col = 7
                    strCol7 = Trim(.Text)

                    .Col = 8
                    strCol8 = Trim(.Text)

                    .Col = 9
                    strCol9 = Trim(.Text)

                    boolPrintNext = False

                    If intRowCount > 61 Or (PageNo = 1 And intRowCount = 3) Then
                        If intRowCount > 61 Then
                            gconnection.subWriteLine(intPageLength, True)
                            gconnection.subPrintFooter(intPageLength, PageNo, True)
                            PageNo = PageNo + 1
                        End If
                        gconnection.subPrintHeader(vCaption, strColumnHead, intPageLength, True)
                        intRowCount = 11
                    End If

                    If strCol1 = "" And strCol2 = "" And strCol3 = "" And strCol4 = "" And strCol5 = "" And intRowCount <> 11 Then
                        gconnection.subWriteLine(intPageLength, True)
                        'Filewrite.WriteLine(Chr(15) & strLine)
                        intRowCount = intRowCount + 1
                        boolPrintNext = True
                    ElseIf strCol1 <> "" And strCol2 = "" And strCol3 = "" And strCol4 = "" And strCol5 = "" And strCol6 = "" Then
                        Filewrite.WriteLine(Chr(15) & "|" & strCol1 & Space(52 - Len(strCol1)) & "|" & Space(30) & "|" & Space(13) & "|" & Space(13) & "|" & Space(13) & "|" & Space(13) & "|" & Space(13) & "|")
                        intRowCount = intRowCount + 1
                        boolPrintNext = True
                    ElseIf strCol1 <> "" And (strCol2 <> "" Or strCol3 <> "") And strCol4 = "" And (strCol5 <> "" Or strCol6 <> "" Or strCol7 <> "" Or strCol8 <> "" Or strCol9 <> "") Then
                        SSQL = "|" & Mid(strCol2 & "-" & strCol3, 1, 83) & Space(83 - Len(Mid(strCol2 & "-" & strCol3, 1, 83)))
                        SSQL = SSQL & "|" & Space(13 - Len(strCol5)) & strCol5
                        SSQL = SSQL & "|" & Space(13 - Len(strCol6)) & strCol6
                        SSQL = SSQL & "|" & Space(13 - Len(strCol7)) & strCol7
                        SSQL = SSQL & "|" & Space(13 - Len(strCol8)) & strCol8
                        SSQL = SSQL & "|" & Space(13 - Len(strCol9)) & strCol9 & "|"
                        Filewrite.WriteLine(Chr(15) & SSQL)
                        intRowCount = intRowCount + 1
                        boolPrintNext = True
                    ElseIf strCol1 <> "" And strCol2 = "" And strCol3 = "" And strCol4 = "" And (strCol5 <> "" Or strCol6 <> "" Or strCol7 <> "" Or strCol8 <> "" Or strCol9 <> "") Then
                        SSQL = "|" & Mid(strCol1, 1, 83) & Space(83 - Len(Mid(strCol1, 1, 80)))
                        SSQL = SSQL & "|" & Space(13 - Len(strCol5)) & strCol5
                        SSQL = SSQL & "|" & Space(13 - Len(strCol6)) & strCol6
                        SSQL = SSQL & "|" & Space(13 - Len(strCol7)) & strCol7
                        SSQL = SSQL & "|" & Space(13 - Len(strCol8)) & strCol8
                        SSQL = SSQL & "|" & Space(13 - Len(strCol9)) & strCol9 & "|"
                        Filewrite.WriteLine(Chr(15) & SSQL)
                        intRowCount = intRowCount + 1
                        boolPrintNext = True
                    ElseIf strCol1 = "" And strCol2 = "" And strCol3 = "" And strCol4 <> "" And strCol5 = "" Then
                        Filewrite.WriteLine(Chr(15) & "|" & Space(55) & strCol4 & Space(98 - Len(Mid(strCol4, 1, 98))) & "|")
                        intRowCount = intRowCount + 1
                        boolPrintNext = True
                    End If

                    If boolPrintNext = False And intRowCount <> 11 Then
                        SSQL = "|" & strCol1 & Space(15 - Len(Mid(strCol1, 1, 15)))
                        SSQL = SSQL & "|" & strCol2 & Space(15 - Len(strCol2))
                        SSQL = SSQL & "|" & strCol3 & Space(20 - Len(strCol3))
                        SSQL = SSQL & "|" & strCol4 & Space(30 - Len(strCol4))
                        SSQL = SSQL & "|" & Space(13 - Len(strCol5)) & strCol5
                        SSQL = SSQL & "|" & Space(13 - Len(strCol6)) & strCol6
                        SSQL = SSQL & "|" & Space(13 - Len(strCol7)) & strCol7
                        SSQL = SSQL & "|" & Space(13 - Len(strCol8)) & strCol8
                        SSQL = SSQL & "|" & Space(13 - Len(strCol9)) & strCol9 & "|"
                        Filewrite.WriteLine(Chr(15) & SSQL)
                        intRowCount = intRowCount + 1
                    End If
                Next
                gconnection.subWriteLine(intPageLength, True)
                gconnection.subPrintFooter(intPageLength, PageNo, True)
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            End If
        End With
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        boolSearchNext = False
        Call subSearch()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        GroupBox1.Top = 1000
        Accountpostingssgrid.Focus()
    End Sub
    Public Sub subSearch()
        If Len(Trim(txtSearch.Text)) = 0 Then
            MsgBox("Search Text Can't Be Blank....", MsgBoxStyle.OKOnly, Application.ProductName)
            Accountpostingssgrid.Focus()
            Exit Sub
        End If
        Dim i, j, intStringLength, intRow As Int16
        If Accountpostingssgrid.DataRowCnt > 2 Then
            boolSearchResult = False
            If boolSearchNext = False Then
                intRow = 1
            Else
                intRow = Me.Accountpostingssgrid.ActiveRow + 1
            End If
            For i = intRow To Accountpostingssgrid.DataRowCnt
                Me.Accountpostingssgrid.Row = i
                Me.Accountpostingssgrid.Col = Me.Accountpostingssgrid.ActiveCol
                intStringLength = Me.Accountpostingssgrid.Text.Length
                For j = 1 To intStringLength
                    If intStringLength - j >= Len(Trim(txtSearch.Text)) Then
                        If UCase(Mid(Trim(Me.Accountpostingssgrid.Text), j, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                            Me.Accountpostingssgrid.SetActiveCell(Me.Accountpostingssgrid.ActiveCol, i)
                            boolSearchResult = True
                            Exit For
                        End If
                    End If
                Next
                If boolSearchResult = True Then
                    Exit For
                End If
            Next
            If boolSearchResult = False Then
                MsgBox("Sorry, No Match Found...", MsgBoxStyle.OKOnly, Application.ProductName)
                txtSearch.Focus()
                Exit Sub
            End If
        End If
        Accountpostingssgrid.Focus()
    End Sub

    Private Sub Accountpostingssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles Accountpostingssgrid.KeyDownEvent
        If e.keyCode = Keys.F8 Then
            GroupBox1.Top = 321
            GroupBox1.Left = 287
            txtSearch.Text = ""
            txtSearch.Focus()
        End If
        If e.keyCode = Keys.F3 Then
            boolSearchNext = True
            Call subSearch()
        End If
    End Sub
    'End Audit Trial

    Private Sub cmdFillExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFillExport.Click
        Call ExportTo(Accountpostingssgrid)
    End Sub
End Class