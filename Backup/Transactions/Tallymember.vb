Imports System.Data.SqlClient
Imports System.IO
Imports System.Math
Public Class TallyMember
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
    Friend WithEvents grp_Billposting As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Fill As System.Windows.Forms.Button
    Friend WithEvents Cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents lbl_head As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrdAuditTrail As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpPost As System.Windows.Forms.GroupBox
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPost As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Grp_TallyMember As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chk_Reset As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Posted As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmdDosView As System.Windows.Forms.Button
    Friend WithEvents cmdFillExport As System.Windows.Forms.Button
    Friend WithEvents TallyMemberssgrid As AxFPSpreadADO.AxfpSpread
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TallyMember))
        Me.lbl_Fromdate = New System.Windows.Forms.Label
        Me.dtp_Fromdate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Todate = New System.Windows.Forms.Label
        Me.dtp_Todate = New System.Windows.Forms.DateTimePicker
        Me.lbl_heading = New System.Windows.Forms.Label
        Me.grp_Billposting = New System.Windows.Forms.GroupBox
        Me.lbl_head = New System.Windows.Forms.Label
        Me.Cmd_Cancel = New System.Windows.Forms.Button
        Me.Cmd_Fill = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grp_TallyMember = New System.Windows.Forms.GroupBox
        Me.TallyMemberssgrid = New AxFPSpreadADO.AxfpSpread
        Me.chk_Reset = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GrdAuditTrail = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Posted = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.cmdDosView = New System.Windows.Forms.Button
        Me.cmdFillExport = New System.Windows.Forms.Button
        Me.grpPost = New System.Windows.Forms.GroupBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPost = New System.Windows.Forms.Button
        Me.cmdView = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdExport = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.grp_Billposting.SuspendLayout()
        Me.Grp_TallyMember.SuspendLayout()
        CType(Me.TallyMemberssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdAuditTrail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.lbl_heading.Location = New System.Drawing.Point(344, 16)
        Me.lbl_heading.Name = "lbl_heading"
        Me.lbl_heading.Size = New System.Drawing.Size(329, 28)
        Me.lbl_heading.TabIndex = 5
        Me.lbl_heading.Text = "Billing Tally - Export- Smart KOT"
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
        Me.grp_Billposting.Location = New System.Drawing.Point(280, 312)
        Me.grp_Billposting.Name = "grp_Billposting"
        Me.grp_Billposting.Size = New System.Drawing.Size(386, 200)
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
        Me.Cmd_Cancel.Text = "Cancel "
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
        Me.Cmd_Fill.Text = "Fill "
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
        'Grp_TallyMember
        '
        Me.Grp_TallyMember.BackColor = System.Drawing.Color.Transparent
        Me.Grp_TallyMember.Controls.Add(Me.TallyMemberssgrid)
        Me.Grp_TallyMember.Controls.Add(Me.chk_Reset)
        Me.Grp_TallyMember.Controls.Add(Me.Button1)
        Me.Grp_TallyMember.Controls.Add(Me.Label16)
        Me.Grp_TallyMember.Controls.Add(Me.Label2)
        Me.Grp_TallyMember.Controls.Add(Me.GrdAuditTrail)
        Me.Grp_TallyMember.Controls.Add(Me.GroupBox2)
        Me.Grp_TallyMember.Controls.Add(Me.grpPost)
        Me.Grp_TallyMember.Location = New System.Drawing.Point(8, 0)
        Me.Grp_TallyMember.Name = "Grp_TallyMember"
        Me.Grp_TallyMember.Size = New System.Drawing.Size(1008, 680)
        Me.Grp_TallyMember.TabIndex = 129
        Me.Grp_TallyMember.TabStop = False
        '
        'TallyMemberssgrid
        '
        Me.TallyMemberssgrid.ContainingControl = Me
        Me.TallyMemberssgrid.DataSource = Nothing
        Me.TallyMemberssgrid.Location = New System.Drawing.Point(32, 96)
        Me.TallyMemberssgrid.Name = "TallyMemberssgrid"
        Me.TallyMemberssgrid.OcxState = CType(resources.GetObject("TallyMemberssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TallyMemberssgrid.Size = New System.Drawing.Size(960, 432)
        Me.TallyMemberssgrid.TabIndex = 173
        '
        'chk_Reset
        '
        Me.chk_Reset.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Reset.Location = New System.Drawing.Point(432, 544)
        Me.chk_Reset.Name = "chk_Reset"
        Me.chk_Reset.Size = New System.Drawing.Size(72, 16)
        Me.chk_Reset.TabIndex = 171
        Me.chk_Reset.Text = "Reset"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(904, 592)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 40)
        Me.Button1.TabIndex = 170
        Me.Button1.Text = "Audit Trial"
        Me.Button1.Visible = False
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
        Me.Label16.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 34)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Audit Trial"
        '
        'GrdAuditTrail
        '
        Me.GrdAuditTrail.ContainingControl = Me
        Me.GrdAuditTrail.DataSource = Nothing
        Me.GrdAuditTrail.Location = New System.Drawing.Point(32, 96)
        Me.GrdAuditTrail.Name = "GrdAuditTrail"
        Me.GrdAuditTrail.OcxState = CType(resources.GetObject("GrdAuditTrail.OcxState"), System.Windows.Forms.AxHost.State)
        Me.GrdAuditTrail.Size = New System.Drawing.Size(920, 432)
        Me.GrdAuditTrail.TabIndex = 128
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
        Me.GroupBox2.Location = New System.Drawing.Point(280, 544)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 56)
        Me.GroupBox2.TabIndex = 172
        Me.GroupBox2.TabStop = False
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(16, 16)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 3
        Me.Cmd_View.Text = "Period [F9]"
        '
        'Cmd_Posted
        '
        Me.Cmd_Posted.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Posted.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Posted.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Posted.ForeColor = System.Drawing.Color.White
        Me.Cmd_Posted.Image = CType(resources.GetObject("Cmd_Posted.Image"), System.Drawing.Image)
        Me.Cmd_Posted.Location = New System.Drawing.Point(688, 16)
        Me.Cmd_Posted.Name = "Cmd_Posted"
        Me.Cmd_Posted.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Posted.TabIndex = 1
        Me.Cmd_Posted.Text = "Audit Trial[F6]"
        Me.Cmd_Posted.Visible = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(256, 16)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 2
        Me.Cmd_Print.Text = "Print [F12]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(496, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 4
        Me.Cmd_Exit.Text = "Exit [F11]"
        '
        'cmdDosView
        '
        Me.cmdDosView.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdDosView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDosView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDosView.ForeColor = System.Drawing.Color.White
        Me.cmdDosView.Image = CType(resources.GetObject("cmdDosView.Image"), System.Drawing.Image)
        Me.cmdDosView.Location = New System.Drawing.Point(136, 16)
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
        Me.cmdFillExport.Location = New System.Drawing.Point(376, 16)
        Me.cmdFillExport.Name = "cmdFillExport"
        Me.cmdFillExport.Size = New System.Drawing.Size(104, 32)
        Me.cmdFillExport.TabIndex = 169
        Me.cmdFillExport.Text = "Export[F2]"
        '
        'grpPost
        '
        Me.grpPost.Controls.Add(Me.cmdexit)
        Me.grpPost.Controls.Add(Me.cmdPost)
        Me.grpPost.Controls.Add(Me.cmdView)
        Me.grpPost.Controls.Add(Me.cmdPrint)
        Me.grpPost.Controls.Add(Me.cmdExport)
        Me.grpPost.Location = New System.Drawing.Point(160, 544)
        Me.grpPost.Name = "grpPost"
        Me.grpPost.Size = New System.Drawing.Size(616, 56)
        Me.grpPost.TabIndex = 133
        Me.grpPost.TabStop = False
        Me.grpPost.Visible = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(496, 18)
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
        Me.cmdPost.Location = New System.Drawing.Point(16, 18)
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
        Me.cmdView.Location = New System.Drawing.Point(16, 48)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(104, 32)
        Me.cmdView.TabIndex = 135
        Me.cmdView.Text = "View[F9]"
        Me.cmdView.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(136, 48)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 135
        Me.cmdPrint.Text = "Print[F12]"
        Me.cmdPrint.Visible = False
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExport.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.ForeColor = System.Drawing.Color.White
        Me.cmdExport.Image = CType(resources.GetObject("cmdExport.Image"), System.Drawing.Image)
        Me.cmdExport.Location = New System.Drawing.Point(256, 18)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(104, 32)
        Me.cmdExport.TabIndex = 135
        Me.cmdExport.Text = "Export[F2]"
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
        'TallyMember
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 699)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_Billposting)
        Me.Controls.Add(Me.lbl_heading)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grp_TallyMember)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "TallyMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Tally - Export- Smart KOT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_Billposting.ResumeLayout(False)
        Me.Grp_TallyMember.ResumeLayout(False)
        CType(Me.TallyMemberssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdAuditTrail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.grpPost.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim itembool, chkbool, smartcardbool As Boolean
    Dim TotalItemCount As Integer
    Dim gconnection As New GlobalClass
    Dim boolSearchResult, boolSearchNext, boolAddLess As Boolean
    Dim TALLYADDFLAG, TALLYUPDATEFLAG, TALLYCANCELFLAG As Boolean
    Public pageno, pagesize As Integer
    Dim dr As DataRow
    Dim SerHttp As New MSXML2.ServerXMLHTTP30
    Dim xmlDom As New MSXML2.DOMDocument30
    Dim strRequestXML As String
    Private Sub TallyMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            grpPost.Visible = False
            GroupBox2.Visible = True

            '            TallyMemberbool = True
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            grp_Billposting.Top = 1000
        Catch ex As Exception
            MessageBox.Show("Check The Error Load : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            TallyMemberssgrid.ClearRange(1, 1, -1, -1, True)

            grp_Billposting.Top = 150
            grp_Billposting.Left = 296
            dtp_Fromdate.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error view click : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Function PrintHeaderbill(ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", "SM Vs Tally Posting Duplication - BILL", " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(25, "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("BILL DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function tallybillerr_Old()
        Try
            Dim sqlstring, ssql As String
            Dim rowi As Integer
            pagesize = 0
            sqlstring = "SELECT ISNULL(H.KOTDETAILS,'') AS KOTDETAILS,ISNULL(D.BILLDETAILS,'') AS BILLDETAILS,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(BILL_HDR.TallyAddFlag,'')='Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY H.KOTDETAILS,D.BILLDETAILS,H.MCODE,H.MNAME"
            gconnection.getDataSet(sqlstring, "TALLY")
            If gdataset.Tables("TALLY").Rows.Count > 0 Then

                Call Randomize()
                AppPath = Application.StartupPath
                vOutfile = Mid("Bil" & (Rnd() * 800000), 1, 8)
                VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
                Filewrite = File.AppendText(VFilePath)
                printfile = VFilePath
                pageno = 1
                Filewrite.Write(Chr(15))
                Call PrintHeaderbill(dtp_Fromdate.Value, dtp_Todate.Value)

                For rowi = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    With gdataset.Tables("TALLY").Rows(rowi)
                        Dim myconnection As New ADODB.Connection
                        myconnection.Open(gTallyDsn)
                        Dim vfill As New ADODB.Recordset
                        ssql = "Select * from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'COMPANYVOUCHERS' where $Reference = '" & Funapos(Funamp(Trim(.Item("KOTDETAILS")))) & "'"
                        vfill.Open(ssql, myconnection)
                        If vfill.EOF Then
                            If pagesize > 58 Then
                                Filewrite.Write(StrDup(40, "-"))
                                Filewrite.Write(Chr(12))
                                pageno = pageno + 1
                                Call PrintHeaderbill(dtp_Fromdate.Value, dtp_Todate.Value)
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            Filewrite.WriteLine(.Item("KOTDETAILS") & " - " & .Item("billdetails"))
                            sqlstring = "UPDATE KOT_HDR SET TALLYADDFLAG='N' WHERE KOTDETAILS='" & .Item("KOTDETAILS") & "'"
                            gconnection.getDataSet(sqlstring, "TALLY1")
                            pagesize = pagesize + 1
                            tallybillerr_Old = True
                        End If
                        vfill.Close()
                        myconnection = Nothing
                    End With
                Next
                Filewrite.Write(Chr(12))
                Filewrite.Close()
                gPrint = False
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            Else
                tallybillerr_Old = False
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallybillerr : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Function PrintHeadergroup(ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", "SM Vs Tally Posting Duplication - GROUP", " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(25, "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("BILL DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function tallygrouperr()
        Try
            Dim sqlstring, ssql, strstring As String
            Dim rowi As Integer
            Dim headcount As Integer = 0
            pagesize = 0

            sqlstring = "SELECT ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(BILL_HDR.TallyAddFlag,'')<>'Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY D.BILLDETAILS,H.MCODE,H.MNAME"
            gconnection.getDataSet(sqlstring, "TALLY")
            If gdataset.Tables("TALLY").Rows.Count > 0 Then
                For rowi = 0 To gdataset.Tables("TALLY").Rows.Count - 1

                    strstring = "SELECT a.membertypecode as membertypecode,b.membertype as typedesc,a.mcode as mcode,a.mname as mname,a.padd1 as padd1,a.padd2 as padd2,a.padd3 as padd3,a.pcity as pcity,a.pstate as pstate,a.ppin as ppin,a.pcountry as pcountry,a.pemail as pemail,a.pphone1 as pphone1, a.pphone2 as pphone2, a.pcell as pcell, a.creditlimit as creditlimit from membermaster a,membertype b WHERE a.MCODE='" & Trim(gdataset.Tables("TALLY").Rows(rowi).Item("mcode")) & "' and a.membertypecode=b.typedesc"
                    gconnection.getDataSet(strstring, "member")
                    If gdataset.Tables("member").Rows.Count > 0 Then
                        Dim myconnection As New ADODB.Connection
                        myconnection.Open(gTallyDsn)
                        Dim vfill As New ADODB.Recordset
                        ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Groups' where $Name='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("TYPEDESC")))) & "'"
                        vfill.Open(ssql, myconnection)
                        If vfill.EOF Then
                            If headcount = 0 Then
                                Call Randomize()
                                AppPath = Application.StartupPath
                                vOutfile = Mid("Grp" & (Rnd() * 800000), 1, 8)
                                VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
                                Filewrite = File.AppendText(VFilePath)
                                printfile = VFilePath
                                pageno = 1
                                Filewrite.Write(Chr(15))
                                Call PrintHeadergroup(dtp_Fromdate.Value, dtp_Todate.Value)
                                headcount = 1
                            End If
                            With gdataset.Tables("MEMBER").Rows(0)
                                If pagesize > 58 Then
                                    Filewrite.Write(StrDup(40, "-"))
                                    Filewrite.Write(Chr(12))
                                    pageno = pageno + 1
                                    Call PrintHeadergroup(dtp_Fromdate.Value, dtp_Todate.Value)
                                    Filewrite.WriteLine()
                                    pagesize = pagesize + 1
                                End If
                                Filewrite.WriteLine(.Item("TYPEDESC"))
                                pagesize = pagesize + 1
                                tallygrouperr = True

                                strRequestXML = ""
                                strRequestXML = strRequestXML & "<ENVELOPE>"
                                strRequestXML = strRequestXML & "<HEADER>"
                                strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                strRequestXML = strRequestXML & "</HEADER>"
                                strRequestXML = strRequestXML & "<BODY>"
                                strRequestXML = strRequestXML & "<IMPORTDATA>"
                                strRequestXML = strRequestXML & "<REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                strRequestXML = strRequestXML & "</REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REQUESTDATA>"
                                strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"

                                strRequestXML = strRequestXML & "<GROUP NAME='" & Funapos(Funamp(Trim(.Item("TYPEDESC")))) & "' ACTION='Create'>"
                                strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("TYPEDESC")))) & "</NAME>"
                                strRequestXML = strRequestXML & "<PARENT>Sundry Debtors</PARENT>"
                                strRequestXML = strRequestXML & "<ISSUBLEDGER>No</ISSUBLEDGER>"
                                strRequestXML = strRequestXML & "<ISBILLWISEON>No</ISBILLWISEON>"
                                strRequestXML = strRequestXML & "<ISCOSTCENTRESON>No</ISCOSTCENTRESON>"
                                strRequestXML = strRequestXML & "</GROUP>"
                                strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                strRequestXML = strRequestXML & "</REQUESTDATA>"
                                strRequestXML = strRequestXML & "</IMPORTDATA>"
                                strRequestXML = strRequestXML & "</BODY>"
                                strRequestXML = strRequestXML & "</ENVELOPE>"

                                SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                SerHttp.send(strRequestXML)


                            End With
                        End If
                        vfill.Close()
                        myconnection = Nothing
                    End If
                Next
                If headcount = 1 Then
                    Filewrite.Write(Chr(12))

                    Filewrite.Close()
                    gPrint = False
                    If gPrint = False Then
                        OpenTextFile(vOutfile)
                    Else
                        PrintTextFile1(VFilePath)
                    End If
                End If
            Else
                tallygrouperr = False
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallygrouperr : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function

    Private Function PrintHeaderLedger(ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", "SM Vs Tally Posting Duplication - Ledger", " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(25, "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("BILL DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function tallyLedgererr()
        Try
            Dim sqlstring, ssql, strstring As String
            Dim rowi As Integer = 0
            Dim headcount As Integer = 0
            pagesize = 0
            sqlstring = "SELECT ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(BILL_HDR.TallyAddFlag,'')<>'Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY D.BILLDETAILS,H.MCODE,H.MNAME"
            gconnection.getDataSet(sqlstring, "TALLY")
            If gdataset.Tables("TALLY").Rows.Count > 0 Then

                For rowi = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    strstring = "SELECT ISNULL(a.membertypecode,'') as membertypecode,ISNULL(b.membertype,'') as typedesc,ISNULL(a.mcode,'') as mcode,ISNULL(a.mname,'') as mname,ISNULL(a.padd1,'') as padd1,ISNULL(a.padd2,'') as padd2,ISNULL(a.padd3,'') as padd3,ISNULL(a.pcity,'') as pcity,ISNULL(a.pstate,'') as pstate,ISNULL(a.ppin,'') as ppin,ISNULL(a.pcountry,'') as pcountry,ISNULL(a.pemail,'') as pemail,ISNULL(a.pphone1,'') as pphone1, ISNULL(a.pphone2,'') as pphone2, ISNULL(a.pcell,'') as pcell, ISNULL(a.creditlimit,'') as creditlimit from membermaster a,membertype b WHERE a.MCODE='" & Trim(gdataset.Tables("TALLY").Rows(rowi).Item("mcode")) & "' or a.Mname='" & Trim(gdataset.Tables("TALLY").Rows(rowi).Item("mname")) & "' and a.membertypecode=b.typedesc"
                    gconnection.getDataSet(strstring, "member")
                    If gdataset.Tables("member").Rows.Count > 0 Then
                        Dim myconnection As New ADODB.Connection
                        myconnection.Open(gTallyDsn)
                        Dim vfill As New ADODB.Recordset
                        ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Ledger' where $Name='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("MCODE")))) & "' OR $Name='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("MNAME")))) & "'"
                        vfill.Open(ssql, myconnection)
                        If vfill.EOF Then
                            If headcount = 0 Then
                                Call Randomize()
                                AppPath = Application.StartupPath
                                vOutfile = Mid("Led" & (Rnd() * 800000), 1, 8)
                                VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
                                Filewrite = File.AppendText(VFilePath)
                                printfile = VFilePath
                                pageno = 1
                                Filewrite.Write(Chr(15))
                                Call PrintHeaderLedger(dtp_Fromdate.Value, dtp_Todate.Value)
                                headcount = 1
                                pagesize = 0
                            End If
                            With gdataset.Tables("MEMBER").Rows(0)
                                If pagesize > 58 Then
                                    Filewrite.Write(StrDup(40, "-"))
                                    Filewrite.Write(Chr(12))
                                    pageno = pageno + 1
                                    Call PrintHeaderLedger(dtp_Fromdate.Value, dtp_Todate.Value)
                                    Filewrite.WriteLine()
                                    pagesize = pagesize + 1
                                End If
                                Filewrite.WriteLine(.Item("MCODE") & " " & .Item("MNAME"))
                                pagesize = pagesize + 1
                                tallyLedgererr = True

                                strRequestXML = ""
                                strRequestXML = strRequestXML & "<ENVELOPE>"
                                strRequestXML = strRequestXML & "<HEADER>"
                                strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                strRequestXML = strRequestXML & "</HEADER>"
                                strRequestXML = strRequestXML & "<BODY>"
                                strRequestXML = strRequestXML & "<IMPORTDATA>"
                                strRequestXML = strRequestXML & "<REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                strRequestXML = strRequestXML & "</STATICVARIABLES>"


                                strRequestXML = strRequestXML & "</REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REQUESTDATA>"
                                strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                strRequestXML = strRequestXML & "<LEDGER NAME='" & Funapos(Funamp(Trim(.Item("MCODE")))) & "' ACTION='Create'>"
                                strRequestXML = strRequestXML & "<ADDRESS.LIST>"
                                strRequestXML = strRequestXML & "<ADDRESS1>" & Funapos(Funamp(Trim(.Item("PADD1")))) & "</ADDRESS1>"
                                strRequestXML = strRequestXML & "<ADDRESS2>" & Funapos(Funamp(Trim(.Item("PADD2")))) & "</ADDRESS2>"
                                strRequestXML = strRequestXML & "<ADDRESS3>" & Funapos(Funamp(Trim(.Item("PADD3")))) & "</ADDRESS3>"
                                strRequestXML = strRequestXML & "<ADDRESS4>" & Funapos(Funamp(Trim(.Item("PCITY")))) & "</ADDRESS4>"
                                strRequestXML = strRequestXML & "<ADDRESS5>" & Funapos(Funamp(Trim(.Item("PSTATE")))) & "</ADDRESS5>"

                                strRequestXML = strRequestXML & "</ADDRESS.LIST>"

                                strRequestXML = strRequestXML & "<ADDITIONALNAME.LIST>"
                                strRequestXML = strRequestXML & "<ADDITIONALNAME>" & Funapos(Funamp(Trim(.Item("MCODE")))) & "</ADDITIONALNAME>"
                                strRequestXML = strRequestXML & "</ADDITIONALNAME.LIST>"

                                strRequestXML = strRequestXML & "<EMAIL>info@databasesoftware.in</EMAIL>"
                                strRequestXML = strRequestXML & "<PINCODE>" & Funapos(Funamp(Trim(.Item("PPIN")))) & "</PINCODE>"
                                strRequestXML = strRequestXML & "<PARENT>" & Funapos(Funamp(Trim(.Item("typedesc")))) & " </PARENT>"
                                strRequestXML = strRequestXML & "<LEDGERPHONE>" & Funapos(Funamp(Trim(.Item("pphone1")))) & " </LEDGERPHONE>"
                                strRequestXML = strRequestXML & "<LEDGERFAX>" & Funapos(Funamp(Trim(.Item("pphone2")))) & " </LEDGERFAX>"
                                strRequestXML = strRequestXML & "<LEDGERCONTACT>" & Funapos(Funamp(Trim(.Item("pcell")))) & "</LEDGERCONTACT>"
                                strRequestXML = strRequestXML & "<CREDITLIMIT> " & Trim(.Item("CREDITLIMIT")) & "</CREDITLIMIT>"
                                strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                                strRequestXML = strRequestXML & "<NAME.LIST>"

                                strRequestXML = strRequestXML & "  <NAME>" & Funapos(Funamp(Trim(.Item("MNAME")))) & "</NAME>"
                                strRequestXML = strRequestXML & "  </NAME.LIST>"
                                strRequestXML = strRequestXML & "  <LANGUAGEID>1033</LANGUAGEID>"
                                strRequestXML = strRequestXML & "  </LANGUAGENAME.LIST>"
                                strRequestXML = strRequestXML & "  </LEDGER>"
                                strRequestXML = strRequestXML & "  </TALLYMESSAGE>"
                                strRequestXML = strRequestXML & "</REQUESTDATA>"
                                strRequestXML = strRequestXML & "</IMPORTDATA>"
                                strRequestXML = strRequestXML & "</BODY>"
                                strRequestXML = strRequestXML & "</ENVELOPE>"

                                SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                SerHttp.send(strRequestXML)

                            End With
                        End If
                        vfill.Close()
                        myconnection = Nothing
                    End If
                Next
                If headcount = 1 Then
                    Filewrite.Write(Chr(12))

                    Filewrite.Close()
                    gPrint = False
                    If gPrint = False Then
                        OpenTextFile(vOutfile)
                    Else
                        PrintTextFile1(VFilePath)
                    End If
                End If
            Else
                tallyLedgererr = False
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallyledgererr  : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function

    Private Function PrintHeaderCost(ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", "SM Vs Tally Posting Duplication - Cost", " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(25, "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("BILL DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function tallyCosterr()
        Try
            Dim sqlstring, ssql, strstring As String
            Dim rowi As Integer
            pagesize = 0
            sqlstring = "SELECT ISNULL(D.POSCODE,'') AS POSCODE,ISNULL(P.POSDESC,'') AS POSDESC"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(BILL_HDR.TallyAddFlag,'')<>'Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY D.POSCODE,P.POSDESC"
            gconnection.getDataSet(sqlstring, "TALLY")
            If gdataset.Tables("TALLY").Rows.Count > 0 Then
                Call Randomize()
                AppPath = Application.StartupPath
                vOutfile = Mid("Cst" & (Rnd() * 800000), 1, 8)
                VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
                Filewrite = File.AppendText(VFilePath)
                printfile = VFilePath
                pageno = 1
                Filewrite.Write(Chr(15))
                Call PrintHeaderLedger(dtp_Fromdate.Value, dtp_Todate.Value)

                For rowi = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    Dim myconnection As New ADODB.Connection
                    myconnection.Open(gTallyDsn)
                    Dim vfill As New ADODB.Recordset
                    ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'CostCentres' where $Name='" & Funapos(Funamp(Trim(gdataset.Tables("TALLY").Rows(rowi).Item("POSCODE")))) & "' OR $Name='" & Funapos(Funamp(Trim(gdataset.Tables("TALLY").Rows(rowi).Item("POSDESC")))) & "'"
                    vfill.Open(ssql, myconnection)
                    If vfill.EOF Then
                        With gdataset.Tables("TALLY").Rows(rowi)
                            If pagesize > 58 Then
                                Filewrite.Write(StrDup(40, "-"))
                                Filewrite.Write(Chr(12))
                                pageno = pageno + 1
                                Call PrintHeaderLedger(dtp_Fromdate.Value, dtp_Todate.Value)
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            Filewrite.WriteLine(.Item("POSCODE") & " " & .Item("POSDESC"))
                            pagesize = pagesize + 1
                            tallyCosterr = True

                            strRequestXML = ""
                            strRequestXML = strRequestXML & "<ENVELOPE>"
                            strRequestXML = strRequestXML & "<HEADER>"
                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                            strRequestXML = strRequestXML & "</HEADER>"
                            strRequestXML = strRequestXML & "<BODY>"
                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                            strRequestXML = strRequestXML & "</STATICVARIABLES>"

                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                            strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                            strRequestXML = strRequestXML & "<COSTCENTRE NAME='" & Funapos(Funamp(Trim(.Item("POSCODE")))) & "' ACTION='Create'>"
                            strRequestXML = strRequestXML & "<CATEGORY>Primary Cost Category</CATEGORY>"
                            strRequestXML = strRequestXML & "<AFFECTSSTOCK>No</AFFECTSSTOCK>"
                            strRequestXML = strRequestXML & "<FORPAYROLL>No</FORPAYROLL>"
                            strRequestXML = strRequestXML & "<FORJOBCOSTING>No</FORJOBCOSTING>"
                            strRequestXML = strRequestXML & "<ISEMPLOYEEGROUP>No</ISEMPLOYEEGROUP>"
                            strRequestXML = strRequestXML & "<SORTPOSITION>1000</SORTPOSITION>"
                            strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                            strRequestXML = strRequestXML & "<NAME.LIST>"

                            strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("POSCODE")))) & " </NAME>"
                            strRequestXML = strRequestXML & "</NAME.LIST>"
                            strRequestXML = strRequestXML & "<LANGUAGEID>1033</LANGUAGEID>"
                            strRequestXML = strRequestXML & "</LANGUAGENAME.LIST>"
                            strRequestXML = strRequestXML & "</COSTCENTRE>"
                            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                            strRequestXML = strRequestXML & "</BODY>"
                            strRequestXML = strRequestXML & "</ENVELOPE>"

                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                            SerHttp.send(strRequestXML)

                        End With
                    End If
                    vfill.Close()
                    myconnection = Nothing
                Next
                Filewrite.Write(Chr(12))

                Filewrite.Close()
                gPrint = False
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            Else
                tallyCosterr = False
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallycosterr : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function

    Private Function PrintHeaderStockGroup(ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", "SM Vs Tally Posting Duplication - Stock Group", " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(25, "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("BILL DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function tallyStockGrouperr()
        Try
            Dim sqlstring, ssql, strstring As String
            Dim rowi As Integer
            pagesize = 0

            sqlstring = "SELECT ISNULL(G.GROUPCODE,'') AS GROUPCODE,ISNULL(G.GROUPDESC,'') AS GROUPDESC"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(BILL_HDR.TallyAddFlag,'')<>'Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY G.GROUPCODE,G.GROUPDESC"
            gconnection.getDataSet(sqlstring, "TALLY")
            If gdataset.Tables("TALLY").Rows.Count > 0 Then
                Call Randomize()
                AppPath = Application.StartupPath
                vOutfile = Mid("Sgr" & (Rnd() * 800000), 1, 8)
                VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
                Filewrite = File.AppendText(VFilePath)
                printfile = VFilePath
                pageno = 1
                Filewrite.Write(Chr(15))
                Call PrintHeaderLedger(dtp_Fromdate.Value, dtp_Todate.Value)

                For rowi = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    Dim myconnection As New ADODB.Connection
                    myconnection.Open(gTallyDsn)
                    Dim vfill As New ADODB.Recordset
                    ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'StockGroup' where $Name='" & Funapos(Funamp(Trim(gdataset.Tables("TALLY").Rows(rowi).Item("GROUPCODE")))) & "' OR $Name='" & Funapos(Funamp(Trim(gdataset.Tables("TALLY").Rows(rowi).Item("GROUPDESC")))) & "'"
                    vfill.Open(ssql, myconnection)
                    If vfill.EOF Then
                        With gdataset.Tables("TALLY").Rows(rowi)
                            If pagesize > 58 Then
                                Filewrite.Write(StrDup(40, "-"))
                                Filewrite.Write(Chr(12))
                                pageno = pageno + 1
                                Call PrintHeaderLedger(dtp_Fromdate.Value, dtp_Todate.Value)
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            Filewrite.WriteLine(.Item("GROUPCODE") & " " & .Item("GROUPDESC"))
                            pagesize = pagesize + 1
                            tallyStockGrouperr = True

                            strRequestXML = ""
                            strRequestXML = strRequestXML & "<ENVELOPE>"
                            strRequestXML = strRequestXML & "<HEADER>"
                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                            strRequestXML = strRequestXML & "</HEADER>"
                            strRequestXML = strRequestXML & "<BODY>"
                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                            strRequestXML = strRequestXML & "</STATICVARIABLES>"

                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                            strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                            strRequestXML = strRequestXML & "<STOCKGROUP NAME='" & Funapos(Funamp(Trim(.Item("groupdesc")))) & "' ACTION='Create'>"
                            strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                            strRequestXML = strRequestXML & "<NAME.LIST>"
                            strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("groupdesc")))) & "</NAME>"
                            strRequestXML = strRequestXML & "</NAME.LIST>"
                            strRequestXML = strRequestXML & "</LANGUAGENAME.LIST>"
                            strRequestXML = strRequestXML & "</STOCKGROUP>"
                            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                            strRequestXML = strRequestXML & "</BODY>"
                            strRequestXML = strRequestXML & "</ENVELOPE>"

                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                            SerHttp.send(strRequestXML)

                        End With
                    End If
                    vfill.Close()
                    myconnection = Nothing
                Next
                Filewrite.Write(Chr(12))

                Filewrite.Close()
                gPrint = False
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            Else
                tallyStockGrouperr = False
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallystockgroup err : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function

    Private Function PrintHeaderUNIT(ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", "SM Vs Tally Posting Duplication - Unit", " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(25, "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("BILL DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function tallyUniterr()
        Try
            Dim sqlstring, ssql, strstring As String
            Dim rowi As Integer
            pagesize = 0

            sqlstring = "SELECT ISNULL(U.UOMCODE,'') AS UOMCODE,ISNULL(U.UOMDESC,'') AS UOMDESC"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE INNER JOIN UOMMASTER AS U ON U.UOMCODE = I.BASEUOM WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(BILL_HDR.TallyAddFlag,'')<>'Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY U.UOMCODE,U.UOMDESC"
            gconnection.getDataSet(sqlstring, "TALLY")
            If gdataset.Tables("TALLY").Rows.Count > 0 Then
                Call Randomize()
                AppPath = Application.StartupPath
                vOutfile = Mid("Unt" & (Rnd() * 800000), 1, 8)
                VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
                Filewrite = File.AppendText(VFilePath)
                printfile = VFilePath
                pageno = 1
                Filewrite.Write(Chr(15))
                Call PrintHeaderLedger(dtp_Fromdate.Value, dtp_Todate.Value)

                For rowi = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    Dim myconnection As New ADODB.Connection
                    myconnection.Open(gTallyDsn)
                    Dim vfill As New ADODB.Recordset
                    ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'UNIT' where $Name='" & Funapos(Funamp(Trim(gdataset.Tables("TALLY").Rows(rowi).Item("UOMCODE")))) & "' OR $Name='" & Funapos(Funamp(Trim(gdataset.Tables("TALLY").Rows(rowi).Item("UOMDESC")))) & "'"
                    vfill.Open(ssql, myconnection)
                    If vfill.EOF Then
                        With gdataset.Tables("TALLY").Rows(rowi)
                            If pagesize > 58 Then
                                Filewrite.Write(StrDup(40, "-"))
                                Filewrite.Write(Chr(12))
                                pageno = pageno + 1
                                Call PrintHeaderLedger(dtp_Fromdate.Value, dtp_Todate.Value)
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            Filewrite.WriteLine(.Item("UOMCODE") & " " & .Item("UOMDESC"))
                            pagesize = pagesize + 1
                            tallyUniterr = True


                            strRequestXML = ""
                            strRequestXML = strRequestXML & "<ENVELOPE>"
                            strRequestXML = strRequestXML & "<HEADER>"
                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                            strRequestXML = strRequestXML & "</HEADER>"
                            strRequestXML = strRequestXML & "<BODY>"
                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                            strRequestXML = strRequestXML & "</STATICVARIABLES>"

                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                            strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                            strRequestXML = strRequestXML & "<UNIT NAME='" & Funapos(Funamp(Trim(.Item("uomcode")))) & "' ACTION='Create'>"
                            strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("uomcode")))) & "</NAME>"
                            strRequestXML = strRequestXML & "<ORIGINALNAME>" & Funapos(Funamp(Trim(.Item("uomdesc")))) & " </ORIGINALNAME>"
                            strRequestXML = strRequestXML & "<ISSIMPLEUNIT>Yes</ISSIMPLEUNIT>"
                            strRequestXML = strRequestXML & "</UNIT>"
                            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                            strRequestXML = strRequestXML & "</BODY>"
                            strRequestXML = strRequestXML & "</ENVELOPE>"

                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                            SerHttp.send(strRequestXML)

                        End With
                    End If
                    vfill.Close()
                    myconnection = Nothing
                Next
                Filewrite.Write(Chr(12))

                Filewrite.Close()
                gPrint = False
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            Else
                tallyUniterr = False
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallyuniterr  : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function

    Private Function PrintHeaderStockItem(ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", "SM Vs Tally Posting Duplication - Stock Item", " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(25, "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("BILL DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(40, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function tallyStockItemerr()
        Try
            Dim sqlstring, ssql, strstring As String
            Dim rowi As Integer
            pagesize = 0

            sqlstring = "SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMDESC,'') AS ITEMDESC,isnull(i.baseqty,0) as baseqty,isnull(i.groupcode,'') as groupcode,isnull(i.baseuomstd,'') as baseuomstd"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE INNER JOIN UOMMASTER AS U ON U.UOMCODE = I.BASEUOM WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(BILL_HDR.TallyAddFlag,'')<>'Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY I.ITEMCODE,I.ITEMDESC,I.BASEQTY,I.baseuomstd,I.GROUPCODE"
            gconnection.getDataSet(sqlstring, "TALLY")
            If gdataset.Tables("TALLY").Rows.Count > 0 Then
                Call Randomize()
                AppPath = Application.StartupPath
                vOutfile = Mid("Itm" & (Rnd() * 800000), 1, 8)
                VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
                Filewrite = File.AppendText(VFilePath)
                printfile = VFilePath
                pageno = 1
                Filewrite.Write(Chr(15))
                Call PrintHeaderLedger(dtp_Fromdate.Value, dtp_Todate.Value)

                For rowi = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    Dim myconnection As New ADODB.Connection
                    myconnection.Open(gTallyDsn)
                    Dim vfill As New ADODB.Recordset
                    ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'STOCKITEM' where $Name='" & Funapos(Funamp(Trim(gdataset.Tables("TALLY").Rows(rowi).Item("ITEMCODE")))) & "' OR $Name='" & Funapos(Funamp(Trim(gdataset.Tables("TALLY").Rows(rowi).Item("ITEMDESC")))) & "'"
                    vfill.Open(ssql, myconnection)
                    If vfill.EOF Then
                        With gdataset.Tables("TALLY").Rows(rowi)
                            If pagesize > 58 Then
                                Filewrite.Write(StrDup(40, "-"))
                                Filewrite.Write(Chr(12))
                                pageno = pageno + 1
                                Call PrintHeaderLedger(dtp_Fromdate.Value, dtp_Todate.Value)
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            Filewrite.WriteLine(.Item("ITEMCODE") & " " & .Item("ITEMDESC"))
                            pagesize = pagesize + 1
                            tallyStockItemerr = True

                            strRequestXML = ""
                            strRequestXML = strRequestXML & "<ENVELOPE>"
                            strRequestXML = strRequestXML & "<HEADER>"
                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                            strRequestXML = strRequestXML & "</HEADER>"

                            strRequestXML = strRequestXML & "<BODY>"
                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                            strRequestXML = strRequestXML & "</STATICVARIABLES>"

                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                            strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"

                            strRequestXML = strRequestXML & "<STOCKITEM NAME='" & Funapos(Funamp(Trim(.Item("itemdesc")))) & "' ACTION='Create'>"
                            strRequestXML = strRequestXML & "<COSTINGMETHOD>Avg. Cost</COSTINGMETHOD>"
                            strRequestXML = strRequestXML & "<VALUATIONMETHOD>Avg. Price</VALUATIONMETHOD>"
                            strRequestXML = strRequestXML & "<BASEUNITS>" & Funapos(Funamp(Trim(.Item("baseuomstd")))) & " </BASEUNITS>"
                            strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                            strRequestXML = strRequestXML & "<NAME.LIST>"

                            strRequestXML = strRequestXML & "<NAME>" & Trim(.Item("itemdesc")) & "</NAME>"
                            strRequestXML = strRequestXML & "</NAME.LIST>"
                            strRequestXML = strRequestXML & "<LANGUAGEID>1033</LANGUAGEID>"
                            strRequestXML = strRequestXML & "</LANGUAGENAME.LIST>"
                            strRequestXML = strRequestXML & "<BATCHALLOCATIONS.LIST>"
                            strRequestXML = strRequestXML & "<GODOWNNAME>KITCHEN</GODOWNNAME>"
                            strRequestXML = strRequestXML & "<BATCHNAME> " & Funapos(Funamp(Trim(.Item("groupcode")))) & " </BATCHNAME>"
                            strRequestXML = strRequestXML & "</BATCHALLOCATIONS.LIST>"
                            strRequestXML = strRequestXML & "</STOCKITEM>"
                            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                            strRequestXML = strRequestXML & "</BODY>"
                            strRequestXML = strRequestXML & "</ENVELOPE>"

                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                            SerHttp.send(strRequestXML)

                        End With
                    End If
                    vfill.Close()
                    myconnection = Nothing
                Next
                Filewrite.Write(Chr(12))

                Filewrite.Close()
                gPrint = False
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            Else
                tallyStockItemerr = False
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallystockitemerr : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Function tallyvalidate()
        Dim myconnection As New ADODB.Connection
        Dim ssql As String
        Dim sval1 As Double
        Try
            myconnection.Open(gTallyDsn)

            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30
            Dim strRequestXML As String
            Dim strstring, sqlstring As String


            Dim sql As String
            Dim otherbillno As String
            Dim otherbool As Boolean
            Dim ROWJ, ROWI As Integer
            Dim BILLDETAILS, MCODE, MNAME As String
            Dim taxapplicable As String = "Y"

            sqlstring = "SELECT ISNULL(D.BILLDETAILS,'') AS BILLDETAILS,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(BILL_HDR.TallyAddFlag,'')<>'Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY D.BILLDETAILS,H.MCODE,H.MNAME"
            gconnection.getDataSet(sqlstring, "TALLY")
            If gdataset.Tables("TALLY").Rows.Count > 0 Then
                For ROWI = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    With gdataset.Tables("TALLY").Rows(ROWI)
                        BILLDETAILS = "'" & Trim(.Item("BILLDETAILS")) & "'"
                        MCODE = .Item("MCODE")
                        MNAME = .Item("MNAME")

                        'FOR GROUP
                        strstring = "SELECT isnull(a.Taxflag,'Y') AS TAXFLAG,a.membertypecode as membertypecode,b.membertype as typedesc,a.mcode as mcode,a.mname as mname,a.padd1 as padd1,a.padd2 as padd2,a.padd3 as padd3,a.pcity as pcity,a.pstate as pstate,a.ppin as ppin,a.pcountry as pcountry,a.pemail as pemail,a.pphone1 as pphone1, a.pphone2 as pphone2, a.pcell as pcell, a.creditlimit as creditlimit from membermaster a,membertype b WHERE a.MCODE='" & Trim(MCODE) & "' and a.membertypecode=b.typedesc"
                        gconnection.getDataSet(strstring, "member")
                        If gdataset.Tables("member").Rows.Count > 0 Then
                            taxapplicable = Trim(gdataset.Tables("member").Rows(0).Item("TAXFLAG"))
                            ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Groups' where $Name='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("TYPEDESC")))) & "'"
                            vfill.Open(ssql, myconnection)
                            If vfill.EOF Then
                                strRequestXML = ""
                                strRequestXML = strRequestXML & "<ENVELOPE>"
                                strRequestXML = strRequestXML & "<HEADER>"
                                strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                strRequestXML = strRequestXML & "</HEADER>"
                                strRequestXML = strRequestXML & "<BODY>"
                                strRequestXML = strRequestXML & "<IMPORTDATA>"
                                strRequestXML = strRequestXML & "<REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                strRequestXML = strRequestXML & "</REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REQUESTDATA>"
                                strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"

                                strRequestXML = strRequestXML & "<GROUP NAME='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("TYPEDESC")))) & "' ACTION='Create'>"
                                strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("TYPEDESC")))) & "</NAME>"
                                strRequestXML = strRequestXML & "<PARENT>Sundry Debtors</PARENT>"
                                strRequestXML = strRequestXML & "<ISSUBLEDGER>No</ISSUBLEDGER>"
                                strRequestXML = strRequestXML & "<ISBILLWISEON>No</ISBILLWISEON>"
                                strRequestXML = strRequestXML & "<ISCOSTCENTRESON>No</ISCOSTCENTRESON>"
                                strRequestXML = strRequestXML & "</GROUP>"
                                strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                strRequestXML = strRequestXML & "</REQUESTDATA>"
                                strRequestXML = strRequestXML & "</IMPORTDATA>"
                                strRequestXML = strRequestXML & "</BODY>"
                                strRequestXML = strRequestXML & "</ENVELOPE>"

                                SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                SerHttp.send(strRequestXML)

                            End If
                            vfill.Close()
                        Else
                            taxapplicable = "Y"
                        End If

                        'FOR LEDGER

                        ssql = "Select $Name,$ClosingBalance from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Ledger' where $$IsBelongsTo:$$GroupSundryDebtors and ($Name='" & Funapos(Funamp(Trim(MCODE))) & "' OR $Name='" & Funapos(Funamp(Trim(MNAME))) & "')"
                        vfill.Open(ssql, myconnection)
                        If vfill.EOF Then
                            strstring = "SELECT isnull(a.Taxflag,'Y') AS TAXFLAG,a.membertypecode as membertypecode,b.membertype as typedesc,isnull(a.mcode,'') as mcode,isnull(a.mname,'') as mname,isnull(a.padd1,'') as padd1,isnull(a.padd2,'') as padd2,isnull(a.padd3,'') as padd3,isnull(a.pcity,'') as pcity,isnull(a.pstate,'') as pstate,isnull(a.ppin,'') as ppin,isnull(a.pcountry,'') as pcountry,isnull(a.pemail,'') as pemail,isnull(a.pphone1,'') as pphone1, isnull(a.pphone2,'') as pphone2, isnull(a.pcell,'') as pcell, isnull(a.creditlimit,0) as creditlimit from membermaster a,membertype b WHERE a.MCODE='" & Trim(MCODE) & "' and a.membertypecode=b.typedesc"
                            gconnection.getDataSet(strstring, "membermaster")
                            If gdataset.Tables("membermaster").Rows.Count > 0 Then
                                taxapplicable = Trim(gdataset.Tables("membermaster").Rows(0).Item("TAXFLAG"))
                                strRequestXML = ""
                                strRequestXML = strRequestXML & "<ENVELOPE>"
                                strRequestXML = strRequestXML & "<HEADER>"
                                strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                strRequestXML = strRequestXML & "</HEADER>"
                                strRequestXML = strRequestXML & "<BODY>"
                                strRequestXML = strRequestXML & "<IMPORTDATA>"
                                strRequestXML = strRequestXML & "<REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                strRequestXML = strRequestXML & "</REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REQUESTDATA>"
                                strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                strRequestXML = strRequestXML & "<LEDGER NAME='" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "' ACTION='Create'>"
                                strRequestXML = strRequestXML & "<ADDRESS.LIST>"
                                strRequestXML = strRequestXML & "<ADDRESS1>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD1")))) & "</ADDRESS1>"
                                strRequestXML = strRequestXML & "<ADDRESS2>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD2")))) & "</ADDRESS2>"
                                strRequestXML = strRequestXML & "<ADDRESS3>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD3")))) & "</ADDRESS3>"
                                strRequestXML = strRequestXML & "<ADDRESS4>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PCITY")))) & "</ADDRESS4>"
                                strRequestXML = strRequestXML & "<ADDRESS5>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PSTATE")))) & "</ADDRESS5>"

                                strRequestXML = strRequestXML & "</ADDRESS.LIST>"

                                strRequestXML = strRequestXML & "<ADDITIONALNAME.LIST>"
                                strRequestXML = strRequestXML & "<ADDITIONALNAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "</ADDITIONALNAME>"
                                strRequestXML = strRequestXML & "</ADDITIONALNAME.LIST>"

                                strRequestXML = strRequestXML & "<EMAIL>info@databasesoftware.in</EMAIL>"
                                strRequestXML = strRequestXML & "<PINCODE>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PPIN")))) & "</PINCODE>"
                                strRequestXML = strRequestXML & "<PARENT>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("typedesc")))) & " </PARENT>"
                                strRequestXML = strRequestXML & "<LEDGERPHONE>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pphone1")))) & " </LEDGERPHONE>"
                                strRequestXML = strRequestXML & "<LEDGERFAX>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pphone2")))) & " </LEDGERFAX>"
                                strRequestXML = strRequestXML & "<LEDGERCONTACT>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pcell")))) & "</LEDGERCONTACT>"
                                strRequestXML = strRequestXML & "<CREDITLIMIT> " & Trim(gdataset.Tables("membermaster").Rows(0).Item("CREDITLIMIT")) & "</CREDITLIMIT>"
                                strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                                strRequestXML = strRequestXML & "<NAME.LIST>"

                                strRequestXML = strRequestXML & "  <NAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MNAME")))) & "</NAME>"
                                strRequestXML = strRequestXML & "  </NAME.LIST>"
                                strRequestXML = strRequestXML & "  <LANGUAGEID>1033</LANGUAGEID>"
                                strRequestXML = strRequestXML & "  </LANGUAGENAME.LIST>"
                                strRequestXML = strRequestXML & "  </LEDGER>"
                                strRequestXML = strRequestXML & "  </TALLYMESSAGE>"
                                strRequestXML = strRequestXML & "</REQUESTDATA>"
                                strRequestXML = strRequestXML & "</IMPORTDATA>"
                                strRequestXML = strRequestXML & "</BODY>"
                                strRequestXML = strRequestXML & "</ENVELOPE>"

                                SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                SerHttp.send(strRequestXML)
                            Else
                                taxapplicable = "Y"
                            End If
                        End If
                        vfill.Close()

                        'for cost centre
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(D.TAXAMOUNT,0)),0) AS TAXAMOUNT,ISNULL(T.ITEMTYPEDESC,'') AS ITEMTYPEDESC,ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXPERC,0) AS TAXPERC,ISNULL(D.POSCODE,'') AS POSCODE,ISNULL(P.POSDESC,'') AS POSDESC"
                        sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN (" & Trim(BILLDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY T.ITEMTYPEDESC,D.TAXCODE,D.TAXPERC,D.POSCODE,P.POSDESC ORDER BY P.POSDESC"
                        gconnection.getDataSet(sqlstring, "TAX")
                        If gdataset.Tables("TAX").Rows.Count > 0 Then
                            For ROWJ = 0 To gdataset.Tables("TAX").Rows.Count - 1
                                With gdataset.Tables("TAX").Rows(ROWJ)
                                    ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'CostCentres' where $name = '" & Funapos(Funamp(Trim(.Item("POSDESC")))) & "'"
                                    vfill.Open(ssql, myconnection)
                                    If vfill.EOF Then
                                        strRequestXML = ""
                                        strRequestXML = strRequestXML & "<ENVELOPE>"
                                        strRequestXML = strRequestXML & "<HEADER>"
                                        strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                        strRequestXML = strRequestXML & "</HEADER>"
                                        strRequestXML = strRequestXML & "<BODY>"
                                        strRequestXML = strRequestXML & "<IMPORTDATA>"
                                        strRequestXML = strRequestXML & "<REQUESTDESC>"
                                        strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                        strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                        strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                        strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                        strRequestXML = strRequestXML & "</REQUESTDESC>"
                                        strRequestXML = strRequestXML & "<REQUESTDATA>"
                                        strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                        strRequestXML = strRequestXML & "<COSTCENTRE NAME='" & Funapos(Funamp(Trim(.Item("POSDESC")))) & "' ACTION='Create'>"
                                        strRequestXML = strRequestXML & "<CATEGORY>Primary Cost Category</CATEGORY>"
                                        strRequestXML = strRequestXML & "<AFFECTSSTOCK>No</AFFECTSSTOCK>"
                                        strRequestXML = strRequestXML & "<FORPAYROLL>No</FORPAYROLL>"
                                        strRequestXML = strRequestXML & "<FORJOBCOSTING>No</FORJOBCOSTING>"
                                        strRequestXML = strRequestXML & "<ISEMPLOYEEGROUP>No</ISEMPLOYEEGROUP>"
                                        strRequestXML = strRequestXML & "<SORTPOSITION>1000</SORTPOSITION>"
                                        strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                                        strRequestXML = strRequestXML & "<NAME.LIST>"

                                        strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("POSDESC")))) & " </NAME>"
                                        strRequestXML = strRequestXML & "</NAME.LIST>"
                                        strRequestXML = strRequestXML & "<LANGUAGEID>1033</LANGUAGEID>"
                                        strRequestXML = strRequestXML & "</LANGUAGENAME.LIST>"
                                        strRequestXML = strRequestXML & "</COSTCENTRE>"
                                        strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                        strRequestXML = strRequestXML & "</REQUESTDATA>"
                                        strRequestXML = strRequestXML & "</IMPORTDATA>"
                                        strRequestXML = strRequestXML & "</BODY>"
                                        strRequestXML = strRequestXML & "</ENVELOPE>"

                                        SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                        SerHttp.send(strRequestXML)
                                    End If
                                    vfill.Close()
                                End With
                            Next
                        End If

                        'For stock group

                        sqlstring = "SELECT ISNULL(D.GROUPCODE,'') AS GROUPCODE,ISNULL(G.GROUPDESC,'') AS GROUPDESC"
                        sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(BILLDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY D.GROUPCODE,G.GROUPDESC"
                        gconnection.getDataSet(sqlstring, "TAX")
                        If gdataset.Tables("TAX").Rows.Count > 0 Then
                            For ROWJ = 0 To gdataset.Tables("TAX").Rows.Count - 1
                                With gdataset.Tables("TAX").Rows(ROWJ)
                                    ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'STOCKGROUP' where $name = '" & Funapos(Funamp(Trim(.Item("groupdesc")))) & "' or $name = '" & Funapos(Funamp(Trim(.Item("groupcode")))) & "'"
                                    vfill.Open(ssql, myconnection)
                                    If vfill.EOF Then
                                        strRequestXML = ""
                                        strRequestXML = strRequestXML & "<ENVELOPE>"
                                        strRequestXML = strRequestXML & "<HEADER>"
                                        strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                        strRequestXML = strRequestXML & "</HEADER>"
                                        strRequestXML = strRequestXML & "<BODY>"
                                        strRequestXML = strRequestXML & "<IMPORTDATA>"
                                        strRequestXML = strRequestXML & "<REQUESTDESC>"
                                        strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                        strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                        strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                        strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                        strRequestXML = strRequestXML & "</REQUESTDESC>"
                                        strRequestXML = strRequestXML & "<REQUESTDATA>"
                                        strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                        strRequestXML = strRequestXML & "<STOCKGROUP NAME='" & Funapos(Funamp(Trim(.Item("groupdesc")))) & "' ACTION='Create'>"
                                        strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                                        strRequestXML = strRequestXML & "<NAME.LIST>"
                                        strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("groupdesc")))) & "</NAME>"
                                        strRequestXML = strRequestXML & "</NAME.LIST>"
                                        strRequestXML = strRequestXML & "</LANGUAGENAME.LIST>"
                                        strRequestXML = strRequestXML & "</STOCKGROUP>"
                                        strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                        strRequestXML = strRequestXML & "</REQUESTDATA>"
                                        strRequestXML = strRequestXML & "</IMPORTDATA>"
                                        strRequestXML = strRequestXML & "</BODY>"
                                        strRequestXML = strRequestXML & "</ENVELOPE>"

                                        SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                        SerHttp.send(strRequestXML)
                                    End If
                                    vfill.Close()
                                End With
                            Next
                        End If


                        'For uom

                        sqlstring = "SELECT ISNULL(D.UOM,'') AS UOMCODE,ISNULL(U.UOMDESC,'') AS UOMDESC"
                        sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS INNER JOIN UOMMASTER U ON U.UOMCODE = D.UOM WHERE D.Billdetails IN ( " & Trim(BILLDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY D.UOM,U.UOMDESC"
                        gconnection.getDataSet(sqlstring, "TAX")
                        If gdataset.Tables("TAX").Rows.Count > 0 Then
                            For ROWJ = 0 To gdataset.Tables("TAX").Rows.Count - 1
                                With gdataset.Tables("TAX").Rows(ROWJ)
                                    ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'UNIT' where $name = '" & Funapos(Funamp(Trim(.Item("uomcode")))) & "' or $name = '" & Funapos(Funamp(Trim(.Item("uomdesc")))) & "'"
                                    vfill.Open(ssql, myconnection)
                                    If vfill.EOF Then

                                        strRequestXML = ""
                                        strRequestXML = strRequestXML & "<ENVELOPE>"
                                        strRequestXML = strRequestXML & "<HEADER>"
                                        strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                        strRequestXML = strRequestXML & "</HEADER>"
                                        strRequestXML = strRequestXML & "<BODY>"
                                        strRequestXML = strRequestXML & "<IMPORTDATA>"
                                        strRequestXML = strRequestXML & "<REQUESTDESC>"
                                        strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                        strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                        strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                        strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                        strRequestXML = strRequestXML & "</REQUESTDESC>"
                                        strRequestXML = strRequestXML & "<REQUESTDATA>"
                                        strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                        strRequestXML = strRequestXML & "<UNIT NAME='" & Funapos(Funamp(Trim(.Item("uomcode")))) & "' ACTION='Create'>"
                                        strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("uomcode")))) & "</NAME>"
                                        strRequestXML = strRequestXML & "<ORIGINALNAME>" & Funapos(Funamp(Trim(.Item("uomdesc")))) & " </ORIGINALNAME>"
                                        strRequestXML = strRequestXML & "<ISSIMPLEUNIT>Yes</ISSIMPLEUNIT>"
                                        strRequestXML = strRequestXML & "</UNIT>"
                                        strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                        strRequestXML = strRequestXML & "</REQUESTDATA>"
                                        strRequestXML = strRequestXML & "</IMPORTDATA>"
                                        strRequestXML = strRequestXML & "</BODY>"
                                        strRequestXML = strRequestXML & "</ENVELOPE>"

                                        SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                        SerHttp.send(strRequestXML)
                                    End If
                                    vfill.Close()
                                End With
                            Next
                        End If



                        'FOR STOCK ITEM


                        sqlstring = "SELECT isnull(I.itemcode,'') as itemcode,isnull(I.itemdesc,'') as itemdesc,isnull(I.baseuomstd,'') as baseuomstd,isnull(I.baseqty,0) as baseqty,isnull(I.groupcode,'') as groupcode"
                        sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(BILLDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY I.itemcode,I.itemdesc,I.baseuomstd,I.baseqty,I.groupcode"
                        gconnection.getDataSet(sqlstring, "TAX")
                        If gdataset.Tables("TAX").Rows.Count > 0 Then
                            For ROWJ = 0 To gdataset.Tables("TAX").Rows.Count - 1
                                With gdataset.Tables("TAX").Rows(ROWJ)
                                    ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'STOCKITEM' where $Name = '" & Funapos(Funamp(Trim(.Item("itemcode")))) & "' or $Name = '" & Funapos(Funamp(Trim(.Item("itemdesc")))) & "'"
                                    vfill.Open(ssql, myconnection)
                                    If vfill.EOF Then
                                        strRequestXML = ""
                                        strRequestXML = strRequestXML & "<ENVELOPE>"
                                        strRequestXML = strRequestXML & "<HEADER>"
                                        strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                        strRequestXML = strRequestXML & "</HEADER>"

                                        strRequestXML = strRequestXML & "<BODY>"
                                        strRequestXML = strRequestXML & "<IMPORTDATA>"
                                        strRequestXML = strRequestXML & "<REQUESTDESC>"
                                        strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                        strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                        strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                        strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                        strRequestXML = strRequestXML & "</REQUESTDESC>"
                                        strRequestXML = strRequestXML & "<REQUESTDATA>"
                                        strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"

                                        strRequestXML = strRequestXML & "<STOCKITEM NAME='" & Funapos(Funamp(Trim(.Item("itemdesc")))) & "' ACTION='Create'>"
                                        strRequestXML = strRequestXML & "<COSTINGMETHOD>Avg. Cost</COSTINGMETHOD>"
                                        strRequestXML = strRequestXML & "<VALUATIONMETHOD>Avg. Price</VALUATIONMETHOD>"
                                        strRequestXML = strRequestXML & "<BASEUNITS>" & Funapos(Funamp(Trim(.Item("baseuomstd")))) & " </BASEUNITS>"
                                        strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                                        strRequestXML = strRequestXML & "<NAME.LIST>"

                                        strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("itemdesc")))) & "</NAME>"
                                        strRequestXML = strRequestXML & "</NAME.LIST>"
                                        strRequestXML = strRequestXML & "<LANGUAGEID>1033</LANGUAGEID>"
                                        strRequestXML = strRequestXML & "</LANGUAGENAME.LIST>"
                                        strRequestXML = strRequestXML & "<BATCHALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "<GODOWNNAME>KITCHEN</GODOWNNAME>"
                                        strRequestXML = strRequestXML & "<BATCHNAME> " & Funapos(Funamp(Trim(.Item("groupcode")))) & " </BATCHNAME>"
                                        strRequestXML = strRequestXML & "</BATCHALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "</STOCKITEM>"
                                        strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                        strRequestXML = strRequestXML & "</REQUESTDATA>"
                                        strRequestXML = strRequestXML & "</IMPORTDATA>"
                                        strRequestXML = strRequestXML & "</BODY>"
                                        strRequestXML = strRequestXML & "</ENVELOPE>"

                                        SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                        SerHttp.send(strRequestXML)
                                    End If
                                    vfill.Close()
                                End With

                            Next
                        End If

                        'for BILL create

                        strRequestXML = ""
                        strRequestXML = strRequestXML & "<ENVELOPE>"
                        strRequestXML = strRequestXML & "<HEADER>"
                        strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                        strRequestXML = strRequestXML & "</HEADER>"
                        strRequestXML = strRequestXML & "<BODY>"
                        strRequestXML = strRequestXML & "<IMPORTDATA>"
                        strRequestXML = strRequestXML & "<REQUESTDESC>"
                        strRequestXML = strRequestXML & "<REPORTNAME>Vouchers</REPORTNAME>"
                        strRequestXML = strRequestXML & "<STATICVARIABLES>"
                        strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                        strRequestXML = strRequestXML & "</STATICVARIABLES>"

                        strRequestXML = strRequestXML & "</REQUESTDESC>"

                        strRequestXML = strRequestXML & "<REQUESTDATA>"
                        strRequestXML = strRequestXML & "<TALLYMESSAGE>"

                        sqlstring = "SELECT ISNULL(H.TOTAL,0)+ISNULL(H.TOTALTAX,0) AS BILLAMT,ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXPERC,0) AS TAXPERC,ISNULL(BILL_HDR.PAYMENTMODE,'') AS PAYMENTTYPE,isnull(h.total,0) as TOTAL,isnull(h.roundoff,0) as roundoff,isnull(H.TOTALTAX,0) AS TOTALTAX,ISNULL(H.ADDUSERID,'') AS ADDUSERID,ISNULL(H.KOTNO,'') AS KOTNO,ISNULL(D.KOTDETAILS,'') AS KOTDETAILS,convert(char(39),ISNULL(D.KOTDATE,GETDATE()),112) AS KOTDATE,isnull(D.billdetails,'') as billdetails,ISNULL(D.ITEMCODE,'') AS ITEMCODE,"
                        sqlstring = sqlstring & " ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(I.LEDGERNAME,'') AS LEDGERNAME,ISNULL(I.STORENAME,'') AS STORENAME,ISNULL(D.POSCODE,'') AS POSCODE,ISNULL(P.POSDESC,'') AS POSDESC,ISNULL(P.PACKINGPERCENT,0) AS PACKINGPERCENT,ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,"
                        sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.SERVERCODE,'') AS SERVERCODE,ISNULL(H.BILLAMOUNT,0) AS BILLAMOUNT,"
                        sqlstring = sqlstring & " ISNULL(H.SERVERNAME,'') AS SERVERNAME,ISNULL(H.REMARKS,'') AS REMARKS  FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(BILLDETAILS) & ") AND ISNULL(KotStatus,'N')='N' ORDER BY POSCODE"

                        gconnection.getDataSet(sqlstring, "KOTHDR")
                        If gdataset.Tables("KOTHDR").Rows.Count > 0 Then
                            If taxapplicable = "Y" Then
                                Select Case Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PAYMENTTYPE"))
                                    Case "CASH"
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='CASH COUPON' ACTION='Create'>"       ' for create / update / delete
                                    Case "ROOM" 'ROOM
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='ROOM' ACTION='Create'>"       ' for create / update / delete
                                    Case "SMART CARD"
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='CASH COUPON' ACTION='Create'>"       ' for create / update / delete
                                    Case "R.MEMBER"
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='CASH COUPON' ACTION='Create'>"       ' for create / update / delete
                                    Case "COUPON" 'CASH COUPON - CNOTE
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='CASH COUPON - C NOTE' ACTION='Create'>"       ' for create / update / delete
                                    Case "PARTY" 'DINNER
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='DINNER' ACTION='Create'>"       ' for create / update / delete
                                    Case Else '"CREDIT" 'KOT
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='K O T' ACTION='Create'>"       ' for create / update / delete
                                End Select
                            Else
                                strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='DNR-KOT' ACTION='Create'>"       ' for create / update / delete
                            End If

                            strRequestXML = strRequestXML & "<DATE>" & Trim(gdataset.Tables("KOTHDR").Rows(0).Item("KOTDATE")) & "</DATE>" ' kotdate
                            strRequestXML = strRequestXML & "<AUTOCOSTLEVEL>" & Trim(Mid(gdataset.Tables("KOTHDR").Rows(0).Item("POSDESC"), 1, 3)) & "</AUTOCOSTLEVEL>" 'cost center
                            strRequestXML = strRequestXML & "<NARRATION>AUTO POSTING FROM CLUBMAN-SMART CARD</NARRATION>"

                            Select Case Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PAYMENTTYPE"))
                                Case "CASH"
                                    Select Case Val(Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PACKINGPERCENT")))
                                        Case Is <> 0
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - YORKER/BOU</CLASSNAME>"    'kottype
                                        Case Else
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - OTHERS</CLASSNAME>"    'kottype
                                    End Select
                                Case "SMART CARD"
                                    Select Case Val(Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PACKINGPERCENT")))
                                        Case Is <> 0
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - YORKER/BOU</CLASSNAME>"    'kottype
                                        Case Else
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - OTHERS</CLASSNAME>"    'kottype
                                    End Select
                                Case "R.MEMBER"  'CASH COUPON
                                    Select Case Val(Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PACKINGPERCENT")))
                                        Case Is <> 0
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - YORKER/BOU</CLASSNAME>"    'kottype
                                        Case Else
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - OTHERS</CLASSNAME>"    'kottype
                                    End Select
                                Case "COUPON" 'CASH COUPON - CNOTE
                                    Select Case Val(Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PACKINGPERCENT")))
                                        Case Is <> 0
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - YORKER/BOU</CLASSNAME>"    'kottype
                                        Case Else
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - OTHERS</CLASSNAME>"    'kottype
                                    End Select


                                Case "ROOM" 'ROOM COUPON - CNOTE
                                    Select Case Val(Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PACKINGPERCENT")))
                                        Case Is <> 0
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - YORKER/BOU</CLASSNAME>"    'kottype
                                        Case Else
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - OTHERS</CLASSNAME>"    'kottype
                                    End Select


                                Case "PARTY" 'DINNER
                                    Select Case Val(Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PACKINGPERCENT")))
                                        Case Is <> 0
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - YORKER/BOU</CLASSNAME>"    'kottype
                                        Case Else
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - OTHERS</CLASSNAME>"    'kottype
                                    End Select
                                Case Else '"CREDIT" 'KOT
                                    Select Case Val(Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PACKINGPERCENT")))
                                        Case Is <> 0
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - YORKER/BOU</CLASSNAME>"    'kottype
                                        Case Else
                                            strRequestXML = strRequestXML & "<CLASSNAME>KOT - OTHERS</CLASSNAME>"    'kottype
                                    End Select
                            End Select


                            If taxapplicable = "Y" Then
                                Select Case Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PAYMENTTYPE"))
                                    Case "CASH"
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>CASH COUPON</VOUCHERTYPENAME>"
                                    Case "SMART CARD"
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>CASH COUPON</VOUCHERTYPENAME>"
                                    Case "R.MEMBER" 'CASH COUPON 
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>CASH COUPON</VOUCHERTYPENAME>"
                                    Case "COUPON" 'CASH COUPON - CNOTE
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>CASH COUPON - C NOTE</VOUCHERTYPENAME>"
                                    Case "ROOM" 'ROOM
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>ROOM</VOUCHERTYPENAME>"
                                    Case "PARTY" 'DINNER
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>DINNER</VOUCHERTYPENAME>"
                                    Case Else '"CREDIT" 'KOT
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>K O T</VOUCHERTYPENAME>"
                                End Select
                            Else
                                strRequestXML = strRequestXML & "<VOUCHERTYPENAME>DNR-KOT</VOUCHERTYPENAME>"
                            End If

                            strRequestXML = strRequestXML & "<VOUCHERNUMBER>" & Trim(gdataset.Tables("KOTHDR").Rows(0).Item("BILLDETAILS")) & "</VOUCHERNUMBER>"
                            strRequestXML = strRequestXML & "<REFERENCE>" & Trim(gdataset.Tables("KOTHDR").Rows(0).Item("BILLDETAILS")) & "</REFERENCE>" 'kotno

                            sqlstring = "SELECT ISNULL(LEDGERNAME,'') AS LEDGERNAME FROM PAYMENTMODEMASTER WHERE PAYMENTCODE='" & Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PAYMENTTYPE")) & "'"
                            gconnection.getDataSet(sqlstring, "CRLEDGER")
                            Dim CRLEDGER As String
                            If gdataset.Tables("CRLEDGER").Rows.Count > 0 Then
                                If gdataset.Tables("CRLEDGER").Rows(0).Item("ledgername") <> "" Then
                                    CRLEDGER = gdataset.Tables("CRLEDGER").Rows(0).Item("ledgername")
                                Else
                                    CRLEDGER = Trim(gdataset.Tables("KOTHDR").Rows(0).Item("MCODE"))
                                End If
                            Else
                                CRLEDGER = Trim(gdataset.Tables("KOTHDR").Rows(0).Item("MCODE"))
                            End If

                            strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(Trim(CRLEDGER))) & "</PARTYLEDGERNAME>" 'mcode
                            strRequestXML = strRequestXML & "<CSTFORMISSUETYPE/>"
                            strRequestXML = strRequestXML & "<CSTFORMRECVTYPE/>"
                            strRequestXML = strRequestXML & "<FBTPAYMENTTYPE>Default</FBTPAYMENTTYPE>"
                            strRequestXML = strRequestXML & "<ENTEREDBY>DBS</ENTEREDBY>" ' PENDING
                            strRequestXML = strRequestXML & "<DIFFACTUALQTY>No</DIFFACTUALQTY>"
                            strRequestXML = strRequestXML & "<AUDITED>No</AUDITED>"
                            strRequestXML = strRequestXML & "<FORJOBCOSTING>No</FORJOBCOSTING>"
                            strRequestXML = strRequestXML & "<ISOPTIONAL>No</ISOPTIONAL>"
                            strRequestXML = strRequestXML & "<EFFECTIVEDATE>" & Trim(gdataset.Tables("KOTHDR").Rows(0).Item("KOTDATE")) & "</EFFECTIVEDATE>" 'kotdate
                            strRequestXML = strRequestXML & "<USEFORINTEREST>No</USEFORINTEREST>"
                            strRequestXML = strRequestXML & "<USEFORGAINLOSS>No</USEFORGAINLOSS>"
                            strRequestXML = strRequestXML & "<USEFORGODOWNTRANSFER>No</USEFORGODOWNTRANSFER>"
                            strRequestXML = strRequestXML & "<USEFORCOMPOUND>No</USEFORCOMPOUND>"
                            strRequestXML = strRequestXML & "<EXCISEOPENING>No</EXCISEOPENING>"
                            strRequestXML = strRequestXML & "<ISCANCELLED>No</ISCANCELLED>"
                            strRequestXML = strRequestXML & "<HASCASHFLOW>No</HASCASHFLOW>"
                            strRequestXML = strRequestXML & "<ISPOSTDATED>No</ISPOSTDATED>"
                            strRequestXML = strRequestXML & "<USETRACKINGNUMBER>No</USETRACKINGNUMBER>"
                            strRequestXML = strRequestXML & "<ISINVOICE>Yes</ISINVOICE>"
                            strRequestXML = strRequestXML & "<MFGJOURNAL>No</MFGJOURNAL>"
                            strRequestXML = strRequestXML & "<HASDISCOUNTS>No</HASDISCOUNTS>"
                            strRequestXML = strRequestXML & "<ASPAYSLIP>No</ASPAYSLIP>"
                            strRequestXML = strRequestXML & "<ISDELETED>No</ISDELETED>"
                            strRequestXML = strRequestXML & "<ASORIGINAL>No</ASORIGINAL>"

                            strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                            strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(Trim(CRLEDGER))) & "</LEDGERNAME>"   'mcode
                            strRequestXML = strRequestXML & "<GSTCLASS/>"
                            strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                            strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                            strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                            strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"


                            sqlstring = "SELECT ISNULL(SUM(ISNULL(D.AMOUNT,0)+ISNULL(D.TAXAMOUNT,0)+ISNULL(D.PACKAMOUNT,0)),0) AS BILLAMT"
                            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(BILLDETAILS) & ") AND ISNULL(KotStatus,'N')='N'"
                            gconnection.getDataSet(sqlstring, "KOTHDR_AMT")
                            If gdataset.Tables("KOTHDR_AMT").Rows.Count <= 0 Then
                                Exit Function
                            End If

                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("KOTHDR_AMT").Rows(0).Item("BILLAMT")) & "</AMOUNT>"    'net amount
                            strRequestXML = strRequestXML & "<BILLALLOCATIONS.LIST>"
                            strRequestXML = strRequestXML & "<NAME>BILL</NAME>"
                            strRequestXML = strRequestXML & "<BILLCREDITPERIOD>45 Days</BILLCREDITPERIOD>"
                            strRequestXML = strRequestXML & "<BILLTYPE>New Ref</BILLTYPE>"
                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("KOTHDR_AMT").Rows(0).Item("BILLAMT")) & "</AMOUNT>"    'net amount
                            strRequestXML = strRequestXML & "</BILLALLOCATIONS.LIST>"
                            strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"

                            'START TAX LOOP

                            sqlstring = "SELECT ISNULL(SUM(ISNULL(D.TAXAMOUNT,0)),0) AS TAXAMOUNT,ISNULL(T.ITEMTYPEDESC,'') AS ITEMTYPEDESC,ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXPERC,0) AS TAXPERC,ISNULL(H.LOCATIONCODE,'') AS POSCODE,ISNULL(P.POSDESC,'') AS POSDESC"
                            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(BILLDETAILS) & ") AND ISNULL(KotStatus,'N')='N' AND ISNULL(D.TAXAMOUNT,0)>0 GROUP BY T.ITEMTYPEDESC,D.TAXCODE,D.TAXPERC,H.LOCATIONCODE,P.POSDESC ORDER BY P.POSDESC"

                            gconnection.getDataSet(sqlstring, "TAX")
                            If gdataset.Tables("TAX").Rows.Count > 0 Then
                                For ROWJ = 0 To gdataset.Tables("TAX").Rows.Count - 1
                                    With gdataset.Tables("TAX").Rows(ROWJ)
                                        strRequestXML = strRequestXML & "<LEDGERENTRIES.LIST>"
                                        strRequestXML = strRequestXML & "<BASICRATEOFINVOICETAX.LIST>"
                                        strRequestXML = strRequestXML & "<BASICRATEOFINVOICETAX> " & Trim(Format(.Item("TAXPERC"), "00.00")) & "</BASICRATEOFINVOICETAX>"
                                        strRequestXML = strRequestXML & "</BASICRATEOFINVOICETAX.LIST>"
                                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(Trim(.Item("ITEMTYPEDESC")))) & "</LEDGERNAME>"
                                        strRequestXML = strRequestXML & "<METHODTYPE>On Item Rate</METHODTYPE>"
                                        strRequestXML = strRequestXML & "<CLASSRATE> " & Trim(Format(.Item("TAXPERC"), "00.00")) & "%</CLASSRATE>"
                                        strRequestXML = strRequestXML & "<GSTCLASS/>"
                                        strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                                        strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                        strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>Yes</REMOVEZEROENTRIES>"
                                        strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>"
                                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(.Item("TAXAMOUNT"), "0.00")) & "</AMOUNT>" 'taxamount
                                        strRequestXML = strRequestXML & "<CATEGORYALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "<CATEGORY>Primary Cost Category</CATEGORY>"
                                        strRequestXML = strRequestXML & "<COSTCENTREALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("POSDESC")))) & "</NAME>" 'CLARIFICATION REQUIRED
                                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(.Item("TAXAMOUNT"), "0.00")) & "</AMOUNT>" 'taxamount
                                        strRequestXML = strRequestXML & "</COSTCENTREALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "</CATEGORYALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "</LEDGERENTRIES.LIST>"
                                    End With
                                Next
                            End If

                            'END TAX LOOP

                            'PACKING AMOUNT

                            sqlstring = "SELECT ISNULL(P.POSDESC,'') AS POSDESC,ISNULL(SUM(ISNULL(D.PACKAMOUNT,0)),0) AS PACKAMOUNT,((ISNULL(SUM(ISNULL(D.PACKAMOUNT,0)),0)/10.2)*10) AS TEN,ISNULL(SUM(ISNULL(D.PACKAMOUNT,0)),0)-((ISNULL(SUM(ISNULL(D.PACKAMOUNT,0)),0)/10.2)*10) AS TWO"
                            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(BILLDETAILS) & ") AND ISNULL(KotStatus,'N')='N' AND ISNULL(D.PACKAMOUNT,0)>0 GROUP BY H.LOCATIONCODE,P.POSDESC ORDER BY P.POSDESC"
                            gconnection.getDataSet(sqlstring, "TAX")
                            If gdataset.Tables("TAX").Rows.Count > 0 Then
                                For ROWJ = 0 To gdataset.Tables("TAX").Rows.Count - 1
                                    With gdataset.Tables("TAX").Rows(ROWJ)
                                        strRequestXML = strRequestXML & "<LEDGERENTRIES.LIST>"
                                        strRequestXML = strRequestXML & "<BASICRATEOFINVOICETAX.LIST>"
                                        strRequestXML = strRequestXML & "<BASICRATEOFINVOICETAX> 10</BASICRATEOFINVOICETAX>"
                                        strRequestXML = strRequestXML & "</BASICRATEOFINVOICETAX.LIST>"
                                        strRequestXML = strRequestXML & "<LEDGERNAME>SALES SURCHARGE-AIRCONDITIONI(Y/B)</LEDGERNAME>"
                                        strRequestXML = strRequestXML & "<METHODTYPE>On Item Rate</METHODTYPE>"
                                        strRequestXML = strRequestXML & "<CLASSRATE> 10%</CLASSRATE>"
                                        strRequestXML = strRequestXML & "<GSTCLASS/>"
                                        strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                                        strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                        strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>Yes</REMOVEZEROENTRIES>"
                                        strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>"
                                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(.Item("TEN"), "0.00")) & "</AMOUNT>" 'taxamount
                                        strRequestXML = strRequestXML & "<CATEGORYALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "<CATEGORY>Primary Cost Category</CATEGORY>"
                                        strRequestXML = strRequestXML & "<COSTCENTREALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("POSDESC")))) & "</NAME>" 'CLARIFICATION REQUIRED
                                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(.Item("TEN"), "0.00")) & "</AMOUNT>" 'taxamount
                                        strRequestXML = strRequestXML & "</COSTCENTREALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "</CATEGORYALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "</LEDGERENTRIES.LIST>"


                                        strRequestXML = strRequestXML & "<LEDGERENTRIES.LIST>"
                                        strRequestXML = strRequestXML & "<BASICRATEOFINVOICETAX.LIST>"
                                        strRequestXML = strRequestXML & "<BASICRATEOFINVOICETAX> 2</BASICRATEOFINVOICETAX>"
                                        strRequestXML = strRequestXML & "</BASICRATEOFINVOICETAX.LIST>"
                                        strRequestXML = strRequestXML & "<LEDGERNAME>VAT @ 2% ON A/C CHARGES</LEDGERNAME>"
                                        strRequestXML = strRequestXML & "<METHODTYPE>As Surcharge</METHODTYPE>"
                                        strRequestXML = strRequestXML & "<CLASSRATE> 2%</CLASSRATE>"
                                        strRequestXML = strRequestXML & "<GSTCLASS/>"
                                        strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                                        strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                        strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>Yes</REMOVEZEROENTRIES>"
                                        strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>"
                                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(.Item("TWO"), "0.00")) & "</AMOUNT>" 'taxamount
                                        strRequestXML = strRequestXML & "<CATEGORYALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "<CATEGORY>Primary Cost Category</CATEGORY>"
                                        strRequestXML = strRequestXML & "<COSTCENTREALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("POSDESC")))) & "</NAME>" 'CLARIFICATION REQUIRED
                                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(.Item("TWO"), "0.00")) & "</AMOUNT>" 'taxamount
                                        strRequestXML = strRequestXML & "</COSTCENTREALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "</CATEGORYALLOCATIONS.LIST>"
                                        strRequestXML = strRequestXML & "</LEDGERENTRIES.LIST>"
                                    End With
                                Next
                            End If


                            For ROWJ = 0 To gdataset.Tables("KOTHDR").Rows.Count - 1
                                With gdataset.Tables("KOTHDR").Rows(ROWJ)
                                    strRequestXML = strRequestXML & "<ALLINVENTORYENTRIES.LIST>"
                                    strRequestXML = strRequestXML & "<STOCKITEMNAME>" & Funapos(Funamp(Trim(.Item("ITEMDESC")))) & "</STOCKITEMNAME>"
                                    strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                                    strRequestXML = strRequestXML & "<ISAUTONEGATE>No</ISAUTONEGATE>"
                                    strRequestXML = strRequestXML & "<RATE>" & Trim(Format(.Item("Rate"), "0.00")) & "/" & Trim(.Item("UOM")) & "</RATE>"
                                    strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(.Item("AMOUNT"), "0.00")) & "</AMOUNT>"
                                    strRequestXML = strRequestXML & "<ACTUALQTY> " & Trim(.Item("Qty")) & " " & Trim(.Item("UOM")) & "</ACTUALQTY>"
                                    strRequestXML = strRequestXML & "<BILLEDQTY> " & Trim(.Item("Qty")) & " " & Trim(.Item("UOM")) & "</BILLEDQTY>"
                                    strRequestXML = strRequestXML & "<ACCOUNTINGALLOCATIONS.LIST>"
                                    strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(Trim(.Item("LEDGERNAME")))) & "</LEDGERNAME>"
                                    strRequestXML = strRequestXML & "<CLASSRATE>1.00000</CLASSRATE>"
                                    strRequestXML = strRequestXML & "<GSTCLASS/>"
                                    strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                                    strRequestXML = strRequestXML & "<LEDGERFROMITEM>Yes</LEDGERFROMITEM>"
                                    strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                    strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>"
                                    strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(.Item("AMOUNT"), "0.00")) & "</AMOUNT>"
                                    strRequestXML = strRequestXML & "<CATEGORYALLOCATIONS.LIST>"
                                    strRequestXML = strRequestXML & "<CATEGORY>Primary Cost Category</CATEGORY>"
                                    strRequestXML = strRequestXML & "<COSTCENTREALLOCATIONS.LIST>"
                                    strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("POSDESC")))) & "</NAME>" 'PENDING
                                    strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(.Item("AMOUNT"), "0.00")) & "</AMOUNT>"
                                    strRequestXML = strRequestXML & "</COSTCENTREALLOCATIONS.LIST>"
                                    strRequestXML = strRequestXML & "</CATEGORYALLOCATIONS.LIST>"
                                    strRequestXML = strRequestXML & "</ACCOUNTINGALLOCATIONS.LIST>"
                                    strRequestXML = strRequestXML & "<BATCHALLOCATIONS.LIST>"
                                    strRequestXML = strRequestXML & "<GODOWNNAME>" & Funapos(Funamp(Trim(.Item("STORENAME")))) & "</GODOWNNAME>"
                                    strRequestXML = strRequestXML & "<BATCHNAME>Primary Batch</BATCHNAME>"
                                    strRequestXML = strRequestXML & "<DESTINATIONGODOWNNAME>" & Funapos(Funamp(Trim(.Item("STORENAME")))) & "</DESTINATIONGODOWNNAME>"
                                    strRequestXML = strRequestXML & "<INDENTNO/>"
                                    strRequestXML = strRequestXML & "<ORDERNO/>"
                                    strRequestXML = strRequestXML & "<TRACKINGNUMBER/>"
                                    strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(.Item("AMOUNT"), "0.00")) & "</AMOUNT>"
                                    strRequestXML = strRequestXML & "<ACTUALQTY> " & Trim(.Item("Qty")) & " " & Trim(.Item("UOM")) & "</ACTUALQTY>"
                                    strRequestXML = strRequestXML & "<BILLEDQTY> " & Trim(.Item("Qty")) & " " & Trim(.Item("UOM")) & "</BILLEDQTY>"
                                    strRequestXML = strRequestXML & "</BATCHALLOCATIONS.LIST>"
                                    strRequestXML = strRequestXML & "</ALLINVENTORYENTRIES.LIST>"
                                End With
                            Next
                            '    'loop end here

                            strRequestXML = strRequestXML & "</VOUCHER>"
                            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                            strRequestXML = strRequestXML & "</BODY>"
                            strRequestXML = strRequestXML & "</ENVELOPE>"
                        End If

                        SerHttp.open("POST", gTallyOdbc & gTallyPort)

                        SerHttp.send(strRequestXML)

                        'for tally error


                        'new for tally xml error
                        'begin
                        Dim resstr, errorstr, j
                        Dim errmsg As Boolean = False

                        resstr = SerHttp.responseText
                        'MsgBox(resstr)
                        xmlDom.loadXML(resstr)

                        'Dim ChildNodes As Xml.XmlNode

                        'ChildNodes = xmlDom.selectNodes("/RESPONSE/LINEERROR")

                        'If (ChildNodes.Value > 0) Then
                        '    errorstr = ""
                        '    For j = 0 To Len(ChildNodes) - 1
                        '        errorstr = errorstr & ChildNodes.Item(j).Value & " "
                        '        errmsg = True
                        '    Next
                        '    If errmsg = True Then
                        '        MsgBox("Error String : " & errorstr)
                        '    End If
                        '    sqlstring = "UPDATE BILL_HDR SET TALLYADDFLAG='N' WHERE BILLdetails IN ( '" & Trim(.Item("BILLDETAILS")) & "')"
                        '    gconnection.dataOperation(6, sqlstring, "flag")
                        'Else
                        '    sqlstring = "UPDATE BILL_HDR SET TALLYADDFLAG='Y' WHERE BILLdetails IN ( '" & Trim(.Item("BILLDETAILS")) & "')"
                        '    gconnection.dataOperation(6, sqlstring, "flag")
                        'End If
                        '                        ChildNodes = Nothing

                        sqlstring = "UPDATE BILL_HDR SET TALLYADDFLAG='Y' WHERE BILLdetails IN ( '" & Trim(.Item("BILLDETAILS")) & "')"
                        gconnection.dataOperation(6, sqlstring, "flag")

                    End With
                Next
                MsgBox("Successcully Created", vbInformation, "BILL Posted to Tally")
            Else
                MsgBox("There is no record(s) to Post.......", MsgBoxStyle.OKOnly, "TallyPost")
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallyvalidate : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Function tallyvalidate_kot()
        Try
            Dim myconnection As New ADODB.Connection
            Dim ssql As String
            Dim sval1 As Double
            myconnection.Open(gTallyDsn)
            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30
            Dim strRequestXML As String
            Dim strstring, sqlstring As String
            Dim sql As String
            Dim otherbillno As String
            Dim otherbool As Boolean
            Dim ROWJ, ROWI As Integer
            Dim KOTDETAILS, MCODE, MNAME As String
            Dim taxapplicable As String = "Y"



            sqlstring = " SELECT ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME "
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS LEFT OUTER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE LEFT OUTER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE ISNULL(D.KotStatus,'N')='N' and isnull(d.delflag,'')<>'Y' and CONVERT(CHAR(39),H.KOTDATE,106) BETWEEN '" & Format(dtp_Fromdate.Value, "dd MMM yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd MMM yyyy") & "' AND ISNULL(H.TALLYADDFLAG,'')<>'Y' AND ISNULL(H.BILLSTATUS,'')='ST' and mcode in(select mcode from membermaster) GROUP BY H.MCODE,H.MNAME "
            gconnection.getDataSet(sqlstring, "TALLY")
            If gdataset.Tables("TALLY").Rows.Count > 0 Then
                For ROWI = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    With gdataset.Tables("TALLY").Rows(ROWI)
                        MCODE = .Item("MCODE")
                        MNAME = .Item("MNAME")
                        'FOR GROUP
                        strstring = "SELECT ISNULL(A.TAXFLAG,'Y') as taxflag,a.membertypecode as membertypecode,b.membertype as typedesc,a.mcode as mcode,a.mname as mname,a.contadd1 as padd1,a.contadd2 as padd2,a.contadd3 as padd3,a.contcity as pcity,a.contstate as pstate,a.contpin as ppin,a.contcountry as pcountry,a.contemail as pemail,a.contphone1 as pphone1, a.contphone2 as pphone2, a.contcell as pcell, a.creditlimit as creditlimit from membermaster a,membertype b WHERE a.MCODE='" & Trim(MCODE) & "' and a.membertypecode=b.membertype"
                        gconnection.getDataSet(strstring, "member")
                        If gdataset.Tables("member").Rows.Count > 0 Then
                            taxapplicable = Trim(gdataset.Tables("member").Rows(0).Item("TAXFLAG"))
                            ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Groups' where $$Alias='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("TYPEDESC")))) & "'"
                            vfill.Open(ssql, myconnection)
                            If vfill.EOF Then
                                strRequestXML = ""
                                strRequestXML = strRequestXML & "<ENVELOPE>"
                                strRequestXML = strRequestXML & "<HEADER>"
                                strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                strRequestXML = strRequestXML & "</HEADER>"
                                strRequestXML = strRequestXML & "<BODY>"
                                strRequestXML = strRequestXML & "<IMPORTDATA>"
                                strRequestXML = strRequestXML & "<REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                strRequestXML = strRequestXML & "</REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REQUESTDATA>"
                                strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"

                                strRequestXML = strRequestXML & "<GROUP NAME='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("TYPEDESC")))) & "' ACTION='Create'>"
                                strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("TYPEDESC")))) & "</NAME>"
                                strRequestXML = strRequestXML & "<PARENT>Sundry Debtors</PARENT>"
                                strRequestXML = strRequestXML & "<ISSUBLEDGER>No</ISSUBLEDGER>"
                                strRequestXML = strRequestXML & "<ISBILLWISEON>No</ISBILLWISEON>"
                                strRequestXML = strRequestXML & "<ISCOSTCENTRESON>No</ISCOSTCENTRESON>"
                                strRequestXML = strRequestXML & "</GROUP>"
                                strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                strRequestXML = strRequestXML & "</REQUESTDATA>"
                                strRequestXML = strRequestXML & "</IMPORTDATA>"
                                strRequestXML = strRequestXML & "</BODY>"
                                strRequestXML = strRequestXML & "</ENVELOPE>"

                                SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                SerHttp.send(strRequestXML)

                            End If
                            vfill.Close()
                        Else
                            taxapplicable = "Y"
                        End If
                        'FOR LEDGER

                        ssql = "Select $Name,$ClosingBalance from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Ledger' where $$IsBelongsTo:$$GroupSundryDebtors and ($Alias='" & Funapos(Funamp(Trim(MCODE))) & "' OR $Alias='" & Funapos(Funamp(Trim(MNAME))) & "')"
                        vfill.Open(ssql, myconnection)
                        If vfill.EOF Then
                            strstring = "SELECT ISNULL(A.TAXFLAG,'Y') AS TAXFLAG,a.membertypecode as membertypecode,isnull(b.membertype,'SUNDRY DEBTORS') as typedesc,isnull(a.mcode,'') as mcode,isnull(a.mname,'') as mname,isnull(a.padd1,'') as padd1,isnull(a.padd2,'') as padd2,isnull(a.padd3,'') as padd3,isnull(a.pcity,'') as pcity,isnull(a.pstate,'') as pstate,isnull(a.ppin,'') as ppin,isnull(a.pcountry,'') as pcountry,isnull(a.pemail,'') as pemail,isnull(a.pphone1,'') as pphone1, isnull(a.pphone2,'') as pphone2, isnull(a.pcell,'') as pcell, isnull(a.creditlimit,0) as creditlimit from membermaster a LEFT OUTER JOIN membertype b ON a.membertypecode=b.membertype WHERE a.MCODE='" & Trim(MCODE) & "' or a.MNAME='" & Trim(MNAME) & "'"
                            gconnection.getDataSet(strstring, "membermaster")
                            If gdataset.Tables("membermaster").Rows.Count > 0 Then
                                taxapplicable = Trim(gdataset.Tables("membermaster").Rows(0).Item("TAXFLAG"))
                                strRequestXML = ""
                                strRequestXML = strRequestXML & "<ENVELOPE>"
                                strRequestXML = strRequestXML & "<HEADER>"
                                strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                strRequestXML = strRequestXML & "</HEADER>"
                                strRequestXML = strRequestXML & "<BODY>"
                                strRequestXML = strRequestXML & "<IMPORTDATA>"
                                strRequestXML = strRequestXML & "<REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                strRequestXML = strRequestXML & "</STATICVARIABLES>"
                                strRequestXML = strRequestXML & "</REQUESTDESC>"
                                strRequestXML = strRequestXML & "<REQUESTDATA>"
                                strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                strRequestXML = strRequestXML & "<LEDGER NAME='" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "' ACTION='Create'>"
                                strRequestXML = strRequestXML & "<MAILINGNAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "</MAILINGNAME>"
                                strRequestXML = strRequestXML & "<ALIASNAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "</ALIASNAME>"
                                strRequestXML = strRequestXML & "<ADDRESS.LIST>"
                                strRequestXML = strRequestXML & "<ADDRESS1>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD1")))) & "</ADDRESS1>"
                                strRequestXML = strRequestXML & "<ADDRESS2>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD2")))) & "</ADDRESS2>"
                                strRequestXML = strRequestXML & "<ADDRESS3>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD3")))) & "</ADDRESS3>"
                                strRequestXML = strRequestXML & "<ADDRESS4>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PCITY")))) & "</ADDRESS4>"
                                strRequestXML = strRequestXML & "<ADDRESS5>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PSTATE")))) & "</ADDRESS5>"
                                strRequestXML = strRequestXML & "</ADDRESS.LIST>"
                                strRequestXML = strRequestXML & "<ADDITIONALNAME.LIST>"
                                strRequestXML = strRequestXML & "<ADDITIONALNAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "</ADDITIONALNAME>"
                                strRequestXML = strRequestXML & "</ADDITIONALNAME.LIST>"
                                strRequestXML = strRequestXML & "<EMAIL>info@databasesoftware.in</EMAIL>"
                                strRequestXML = strRequestXML & "<PINCODE>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PPIN")))) & "</PINCODE>"
                                strRequestXML = strRequestXML & "<PARENT>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("typedesc")))) & " </PARENT>"
                                strRequestXML = strRequestXML & "<LEDGERPHONE>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pphone1")))) & " </LEDGERPHONE>"
                                strRequestXML = strRequestXML & "<LEDGERFAX>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pphone2")))) & " </LEDGERFAX>"
                                strRequestXML = strRequestXML & "<LEDGERCONTACT>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pcell")))) & "</LEDGERCONTACT>"
                                strRequestXML = strRequestXML & "<CREDITLIMIT> " & Trim(gdataset.Tables("membermaster").Rows(0).Item("CREDITLIMIT")) & "</CREDITLIMIT>"
                                strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                                strRequestXML = strRequestXML & "<NAME.LIST>"
                                'strRequestXML = strRequestXML & "  <NAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "</NAME>"
                                strRequestXML = strRequestXML & "  <NAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MNAME")))) & "</NAME>"

                                strRequestXML = strRequestXML & "  </NAME.LIST>"
                                strRequestXML = strRequestXML & "  <LANGUAGEID>1033</LANGUAGEID>"
                                strRequestXML = strRequestXML & "  </LANGUAGENAME.LIST>"
                                strRequestXML = strRequestXML & "  </LEDGER>"
                                strRequestXML = strRequestXML & "  </TALLYMESSAGE>"
                                strRequestXML = strRequestXML & "</REQUESTDATA>"
                                strRequestXML = strRequestXML & "</IMPORTDATA>"
                                strRequestXML = strRequestXML & "</BODY>"
                                strRequestXML = strRequestXML & "</ENVELOPE>"
                                SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                SerHttp.send(strRequestXML)
                            End If
                        Else
                            taxapplicable = "Y"
                        End If
                        vfill.Close()
                    End With
                Next
            End If

            Exit Function
                sqlstring = " SELECT ISNULL(H.KOTDETAILS,'') AS KOTDETAILS,ISNULL(H.KOTDETAILS,'') AS KOTDETAILS,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME "
                sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS LEFT OUTER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE LEFT OUTER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE ISNULL(D.KotStatus,'N')='N' and isnull(d.delflag,'')<>'Y' and CONVERT(CHAR(39),H.KOTDATE,106) BETWEEN '" & Format(dtp_Fromdate.Value, "dd MMM yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd MMM yyyy") & "' AND ISNULL(H.TALLYADDFLAG,'')<>'Y' AND ISNULL(H.BILLSTATUS,'')='ST' AND H.MCODE='1494' GROUP BY H.KOTDETAILS,H.KOTDETAILS,H.MCODE,H.MNAME "
                gconnection.getDataSet(sqlstring, "TALLY")
                If gdataset.Tables("TALLY").Rows.Count > 0 Then
                    For ROWI = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                        With gdataset.Tables("TALLY").Rows(ROWI)
                            KOTDETAILS = "'" & Trim(.Item("KOTDETAILS")) & "'"
                            MCODE = .Item("MCODE")
                            MNAME = .Item("MNAME")

                            'FOR GROUP

                            strstring = "SELECT ISNULL(A.TAXFLAG,'Y') as taxflag,a.membertypecode as membertypecode,b.membertype as typedesc,a.mcode as mcode,a.mname as mname,a.padd1 as padd1,a.padd2 as padd2,a.padd3 as padd3,a.pcity as pcity,a.pstate as pstate,a.ppin as ppin,a.pcountry as pcountry,a.pemail as pemail,a.pphone1 as pphone1, a.pphone2 as pphone2, a.pcell as pcell, a.creditlimit as creditlimit from membermaster a,membertype b WHERE a.MCODE='" & Trim(MCODE) & "' and a.membertypecode=b.membertype"
                            gconnection.getDataSet(strstring, "member")
                            If gdataset.Tables("member").Rows.Count > 0 Then
                                taxapplicable = Trim(gdataset.Tables("member").Rows(0).Item("TAXFLAG"))
                                ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Groups' where $$Alias='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("TYPEDESC")))) & "'"
                                vfill.Open(ssql, myconnection)
                                If vfill.EOF Then
                                    strRequestXML = ""
                                    strRequestXML = strRequestXML & "<ENVELOPE>"
                                    strRequestXML = strRequestXML & "<HEADER>"
                                    strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                    strRequestXML = strRequestXML & "</HEADER>"
                                    strRequestXML = strRequestXML & "<BODY>"
                                    strRequestXML = strRequestXML & "<IMPORTDATA>"
                                    strRequestXML = strRequestXML & "<REQUESTDESC>"
                                    strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                    strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                    strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                    strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                    strRequestXML = strRequestXML & "</REQUESTDESC>"
                                    strRequestXML = strRequestXML & "<REQUESTDATA>"
                                    strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"

                                    strRequestXML = strRequestXML & "<GROUP NAME='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("TYPEDESC")))) & "' ACTION='Create'>"
                                    strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(0).Item("TYPEDESC")))) & "</NAME>"
                                    strRequestXML = strRequestXML & "<PARENT>Sundry Debtors</PARENT>"
                                    strRequestXML = strRequestXML & "<ISSUBLEDGER>No</ISSUBLEDGER>"
                                    strRequestXML = strRequestXML & "<ISBILLWISEON>No</ISBILLWISEON>"
                                    strRequestXML = strRequestXML & "<ISCOSTCENTRESON>No</ISCOSTCENTRESON>"
                                    strRequestXML = strRequestXML & "</GROUP>"
                                    strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                    strRequestXML = strRequestXML & "</REQUESTDATA>"
                                    strRequestXML = strRequestXML & "</IMPORTDATA>"
                                    strRequestXML = strRequestXML & "</BODY>"
                                    strRequestXML = strRequestXML & "</ENVELOPE>"

                                    SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                    SerHttp.send(strRequestXML)

                                End If
                                vfill.Close()
                            Else
                                taxapplicable = "Y"
                            End If
                            'FOR LEDGER

                            ssql = "Select $Name,$ClosingBalance from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Ledger' where $$IsBelongsTo:$$GroupSundryDebtors and ($Alias='" & Funapos(Funamp(Trim(MCODE))) & "' OR $Alias='" & Funapos(Funamp(Trim(MNAME))) & "')"
                            vfill.Open(ssql, myconnection)
                            If vfill.EOF Then
                                strstring = "SELECT ISNULL(A.TAXFLAG,'Y') AS TAXFLAG,a.membertypecode as membertypecode,isnull(b.membertype,'SUNDRY DEBTORS') as typedesc,isnull(a.mcode,'') as mcode,isnull(a.mname,'') as mname,isnull(a.padd1,'') as padd1,isnull(a.padd2,'') as padd2,isnull(a.padd3,'') as padd3,isnull(a.pcity,'') as pcity,isnull(a.pstate,'') as pstate,isnull(a.ppin,'') as ppin,isnull(a.pcountry,'') as pcountry,isnull(a.pemail,'') as pemail,isnull(a.pphone1,'') as pphone1, isnull(a.pphone2,'') as pphone2, isnull(a.pcell,'') as pcell, isnull(a.creditlimit,0) as creditlimit from membermaster a LEFT OUTER JOIN membertype b ON a.membertypecode=b.membertype WHERE a.MCODE='" & Trim(MCODE) & "' or a.MNAME='" & Trim(MNAME) & "'"
                                gconnection.getDataSet(strstring, "membermaster")
                                If gdataset.Tables("membermaster").Rows.Count > 0 Then
                                    taxapplicable = Trim(gdataset.Tables("membermaster").Rows(0).Item("TAXFLAG"))
                                    strRequestXML = ""
                                    strRequestXML = strRequestXML & "<ENVELOPE>"
                                    strRequestXML = strRequestXML & "<HEADER>"
                                    strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                    strRequestXML = strRequestXML & "</HEADER>"
                                    strRequestXML = strRequestXML & "<BODY>"
                                    strRequestXML = strRequestXML & "<IMPORTDATA>"
                                    strRequestXML = strRequestXML & "<REQUESTDESC>"
                                    strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                    strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                    strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                    strRequestXML = strRequestXML & "</STATICVARIABLES>"
                                    strRequestXML = strRequestXML & "</REQUESTDESC>"
                                    strRequestXML = strRequestXML & "<REQUESTDATA>"
                                    strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                    strRequestXML = strRequestXML & "<LEDGER NAME='" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "' ACTION='Create'>"
                                    strRequestXML = strRequestXML & "<MAILINGNAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "</MAILINGNAME>"
                                    strRequestXML = strRequestXML & "<ADDRESS.LIST>"
                                    strRequestXML = strRequestXML & "<ADDRESS1>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD1")))) & "</ADDRESS1>"
                                    strRequestXML = strRequestXML & "<ADDRESS2>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD2")))) & "</ADDRESS2>"
                                    strRequestXML = strRequestXML & "<ADDRESS3>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD3")))) & "</ADDRESS3>"
                                    strRequestXML = strRequestXML & "<ADDRESS4>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PCITY")))) & "</ADDRESS4>"
                                    strRequestXML = strRequestXML & "<ADDRESS5>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PSTATE")))) & "</ADDRESS5>"
                                    strRequestXML = strRequestXML & "</ADDRESS.LIST>"
                                    strRequestXML = strRequestXML & "<ADDITIONALNAME.LIST>"
                                    strRequestXML = strRequestXML & "<ADDITIONALNAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "</ADDITIONALNAME>"
                                    strRequestXML = strRequestXML & "</ADDITIONALNAME.LIST>"
                                    strRequestXML = strRequestXML & "<EMAIL>info@databasesoftware.in</EMAIL>"
                                    strRequestXML = strRequestXML & "<PINCODE>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PPIN")))) & "</PINCODE>"
                                    strRequestXML = strRequestXML & "<PARENT>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("typedesc")))) & " </PARENT>"
                                    strRequestXML = strRequestXML & "<LEDGERPHONE>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pphone1")))) & " </LEDGERPHONE>"
                                    strRequestXML = strRequestXML & "<LEDGERFAX>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pphone2")))) & " </LEDGERFAX>"
                                    strRequestXML = strRequestXML & "<LEDGERCONTACT>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pcell")))) & "</LEDGERCONTACT>"
                                    strRequestXML = strRequestXML & "<CREDITLIMIT> " & Trim(gdataset.Tables("membermaster").Rows(0).Item("CREDITLIMIT")) & "</CREDITLIMIT>"
                                    strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                                    strRequestXML = strRequestXML & "<NAME.LIST>"
                                    strRequestXML = strRequestXML & "  <NAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MNAME")))) & "</NAME>"
                                    strRequestXML = strRequestXML & "  </NAME.LIST>"
                                    strRequestXML = strRequestXML & "  <LANGUAGEID>1033</LANGUAGEID>"
                                    strRequestXML = strRequestXML & "  </LANGUAGENAME.LIST>"
                                    strRequestXML = strRequestXML & "  </LEDGER>"
                                    strRequestXML = strRequestXML & "  </TALLYMESSAGE>"
                                    strRequestXML = strRequestXML & "</REQUESTDATA>"
                                    strRequestXML = strRequestXML & "</IMPORTDATA>"
                                    strRequestXML = strRequestXML & "</BODY>"
                                    strRequestXML = strRequestXML & "</ENVELOPE>"
                                    SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                    SerHttp.send(strRequestXML)
                                End If
                            Else
                                taxapplicable = "Y"
                            End If
                            vfill.Close()
                            'for cost centre
                            sqlstring = "SELECT ISNULL(SUM(ISNULL(D.TAXAMOUNT,0)),0) AS TAXAMOUNT,ISNULL(T.ITEMTYPEDESC,'') AS ITEMTYPEDESC,ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXPERC,0) AS TAXPERC,ISNULL(D.POSCODE,'') AS POSCODE,ISNULL(P.POSDESC,'') AS POSDESC"
                            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS LEFT OUTER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE LEFT OUTER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE LEFT OUTER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE H.KOTdetails IN (" & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY T.ITEMTYPEDESC,D.TAXCODE,D.TAXPERC,D.POSCODE,P.POSDESC ORDER BY P.POSDESC "
                            gconnection.getDataSet(sqlstring, "TAX")
                            If gdataset.Tables("TAX").Rows.Count > 0 Then
                                For ROWJ = 0 To gdataset.Tables("TAX").Rows.Count - 1
                                    With gdataset.Tables("TAX").Rows(ROWJ)
                                        ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'CostCentres' where $name = '" & Funapos(Funamp(Trim(.Item("POSDESC")))) & "'"
                                        vfill.Open(ssql, myconnection)
                                        If vfill.EOF Then
                                            strRequestXML = ""
                                            strRequestXML = strRequestXML & "<ENVELOPE>"
                                            strRequestXML = strRequestXML & "<HEADER>"
                                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                            strRequestXML = strRequestXML & "</HEADER>"
                                            strRequestXML = strRequestXML & "<BODY>"
                                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                                            strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                            strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                                            strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                            strRequestXML = strRequestXML & "<COSTCENTRE NAME='" & Funapos(Funamp(Trim(.Item("POSDESC")))) & "' ACTION='Create'>"
                                            strRequestXML = strRequestXML & "<CATEGORY>Primary Cost Category</CATEGORY>"
                                            strRequestXML = strRequestXML & "<AFFECTSSTOCK>No</AFFECTSSTOCK>"
                                            strRequestXML = strRequestXML & "<FORPAYROLL>No</FORPAYROLL>"
                                            strRequestXML = strRequestXML & "<FORJOBCOSTING>No</FORJOBCOSTING>"
                                            strRequestXML = strRequestXML & "<ISEMPLOYEEGROUP>No</ISEMPLOYEEGROUP>"
                                            strRequestXML = strRequestXML & "<SORTPOSITION>1000</SORTPOSITION>"
                                            strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                                            strRequestXML = strRequestXML & "<NAME.LIST>"

                                            strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("POSDESC")))) & " </NAME>"
                                            strRequestXML = strRequestXML & "</NAME.LIST>"
                                            strRequestXML = strRequestXML & "<LANGUAGEID>1033</LANGUAGEID>"
                                            strRequestXML = strRequestXML & "</LANGUAGENAME.LIST>"
                                            strRequestXML = strRequestXML & "</COSTCENTRE>"
                                            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                                            strRequestXML = strRequestXML & "</BODY>"
                                            strRequestXML = strRequestXML & "</ENVELOPE>"

                                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                            SerHttp.send(strRequestXML)
                                        End If
                                        vfill.Close()
                                    End With
                                Next
                            End If

                            'For stock group

                            sqlstring = "SELECT ISNULL(D.GROUPCODE,'') AS GROUPCODE,ISNULL(G.GROUPDESC,'') AS GROUPDESC"
                            'sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY D.GROUPCODE,G.GROUPDESC"
                            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS LEFT OUTER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE LEFT OUTER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE LEFT OUTER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY D.GROUPCODE,G.GROUPDESC"
                            gconnection.getDataSet(sqlstring, "TAX")
                            If gdataset.Tables("TAX").Rows.Count > 0 Then
                                For ROWJ = 0 To gdataset.Tables("TAX").Rows.Count - 1
                                    With gdataset.Tables("TAX").Rows(ROWJ)
                                        ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'STOCKGROUP' where $name = '" & Funapos(Funamp(Trim(.Item("groupdesc")))) & "' or $name = '" & Funapos(Funamp(Trim(.Item("groupcode")))) & "'"
                                        vfill.Open(ssql, myconnection)
                                        If vfill.EOF Then
                                            strRequestXML = ""
                                            strRequestXML = strRequestXML & "<ENVELOPE>"
                                            strRequestXML = strRequestXML & "<HEADER>"
                                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                            strRequestXML = strRequestXML & "</HEADER>"
                                            strRequestXML = strRequestXML & "<BODY>"
                                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                                            strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                            strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                                            strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                            strRequestXML = strRequestXML & "<STOCKGROUP NAME='" & Funapos(Funamp(Trim(.Item("groupdesc")))) & "' ACTION='Create'>"
                                            strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                                            strRequestXML = strRequestXML & "<NAME.LIST>"
                                            strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("groupdesc")))) & "</NAME>"
                                            strRequestXML = strRequestXML & "</NAME.LIST>"
                                            strRequestXML = strRequestXML & "</LANGUAGENAME.LIST>"
                                            strRequestXML = strRequestXML & "</STOCKGROUP>"
                                            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                                            strRequestXML = strRequestXML & "</BODY>"
                                            strRequestXML = strRequestXML & "</ENVELOPE>"

                                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                            SerHttp.send(strRequestXML)
                                        End If
                                        vfill.Close()
                                    End With
                                Next
                            End If

                            'For uom
                            sqlstring = "SELECT ISNULL(D.UOM,'') AS UOMCODE,ISNULL(U.UOMDESC,'') AS UOMDESC "
                            'sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE  INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN UOMMASTER U ON U.UOMCODE = D.UOM WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY D.UOM,U.UOMDESC "
                            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS LEFT OUTER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE LEFT OUTER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE  LEFT OUTER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE LEFT OUTER JOIN UOMMASTER U ON U.UOMCODE = D.UOM WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY D.UOM,U.UOMDESC "
                            gconnection.getDataSet(sqlstring, "TAX")
                            If gdataset.Tables("TAX").Rows.Count > 0 Then
                                For ROWJ = 0 To gdataset.Tables("TAX").Rows.Count - 1
                                    With gdataset.Tables("TAX").Rows(ROWJ)
                                        ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'UNIT' where $name = '" & Funapos(Funamp(Trim(.Item("uomcode")))) & "' or $name = '" & Funapos(Funamp(Trim(.Item("uomdesc")))) & "'"
                                        vfill.Open(ssql, myconnection)
                                        If vfill.EOF Then
                                            strRequestXML = ""
                                            strRequestXML = strRequestXML & "<ENVELOPE>"
                                            strRequestXML = strRequestXML & "<HEADER>"
                                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                            strRequestXML = strRequestXML & "</HEADER>"
                                            strRequestXML = strRequestXML & "<BODY>"
                                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                                            strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                            strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                                            strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                            strRequestXML = strRequestXML & "<UNIT NAME='" & Funapos(Funamp(Trim(.Item("uomcode")))) & "' ACTION='Create'>"
                                            strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("uomcode")))) & "</NAME>"
                                            strRequestXML = strRequestXML & "<ORIGINALNAME>" & Funapos(Funamp(Trim(.Item("uomdesc")))) & " </ORIGINALNAME>"
                                            strRequestXML = strRequestXML & "<ISSIMPLEUNIT>Yes</ISSIMPLEUNIT>"
                                            strRequestXML = strRequestXML & "</UNIT>"
                                            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                                            strRequestXML = strRequestXML & "</BODY>"
                                            strRequestXML = strRequestXML & "</ENVELOPE>"

                                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                            SerHttp.send(strRequestXML)
                                        End If
                                        vfill.Close()
                                    End With
                                Next
                            End If

                            'FOR STOCK ITEM
                            sqlstring = "SELECT isnull(I.itemcode,'') as itemcode,isnull(I.itemdesc,'') as itemdesc,isnull(I.baseuomstd,'') as baseuomstd,isnull(I.baseqty,0) as baseqty,isnull(I.groupcode,'') as groupcode"
                            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS LEFT OUTER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE LEFT OUTER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE LEFT OUTER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE LEFT OUTER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY I.itemcode,I.itemdesc,I.baseuomstd,I.baseqty,I.groupcode"
                            '''sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY I.itemcode,I.itemdesc,I.baseuomstd,I.baseqty,I.groupcode"
                            gconnection.getDataSet(sqlstring, "TAX")
                            If gdataset.Tables("TAX").Rows.Count > 0 Then
                                For ROWJ = 0 To gdataset.Tables("TAX").Rows.Count - 1
                                    With gdataset.Tables("TAX").Rows(ROWJ)
                                        ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'STOCKITEM' where $Name = '" & Funapos(Funamp(Trim(.Item("itemcode")))) & "' or $Name = '" & Funapos(Funamp(Trim(.Item("itemdesc")))) & "'"
                                        vfill.Open(ssql, myconnection)
                                        If vfill.EOF Then
                                            strRequestXML = ""
                                            strRequestXML = strRequestXML & "<ENVELOPE>"
                                            strRequestXML = strRequestXML & "<HEADER>"
                                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                            strRequestXML = strRequestXML & "</HEADER>"

                                            strRequestXML = strRequestXML & "<BODY>"
                                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                                            strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                            strRequestXML = strRequestXML & "</STATICVARIABLES>"

                                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                                            strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"

                                            strRequestXML = strRequestXML & "<STOCKITEM NAME='" & Funapos(Funamp(Trim(.Item("itemdesc")))) & "' ACTION='Create'>"
                                            strRequestXML = strRequestXML & "<COSTINGMETHOD>Avg. Cost</COSTINGMETHOD>"
                                            strRequestXML = strRequestXML & "<VALUATIONMETHOD>Avg. Price</VALUATIONMETHOD>"
                                            strRequestXML = strRequestXML & "<BASEUNITS>" & Funapos(Funamp(Trim(.Item("baseuomstd")))) & " </BASEUNITS>"
                                            strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                                            strRequestXML = strRequestXML & "<NAME.LIST>"

                                            strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("itemdesc")))) & "</NAME>"
                                            strRequestXML = strRequestXML & "</NAME.LIST>"
                                            strRequestXML = strRequestXML & "<LANGUAGEID>1033</LANGUAGEID>"
                                            strRequestXML = strRequestXML & "</LANGUAGENAME.LIST>"
                                            strRequestXML = strRequestXML & "<BATCHALLOCATIONS.LIST>"
                                            strRequestXML = strRequestXML & "<GODOWNNAME>KITCHEN</GODOWNNAME>"
                                            strRequestXML = strRequestXML & "<BATCHNAME> " & Funapos(Funamp(Trim(.Item("groupcode")))) & " </BATCHNAME>"
                                            strRequestXML = strRequestXML & "</BATCHALLOCATIONS.LIST>"
                                            strRequestXML = strRequestXML & "</STOCKITEM>"
                                            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                                            strRequestXML = strRequestXML & "</BODY>"
                                            strRequestXML = strRequestXML & "</ENVELOPE>"
                                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                            SerHttp.send(strRequestXML)
                                        End If
                                        vfill.Close()
                                    End With
                                Next
                            End If
                    End With
                Next
                MsgBox("Successcully Created", vbInformation, "BILL Posted to Tally")
            Else
                MsgBox("There is no record(s) to Post.......", MsgBoxStyle.OKOnly, "TallyPost")
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallyvalidate : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Sub Cmd_Posted_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Check The Error exit click : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Fill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Fill.Click
        Try
            grpPost.Visible = True
            grp_Billposting.Top = 1000
            Call FillTallyMemberdetails()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Cancel.Click
        Try
            grp_Billposting.Top = 1000
            Cmd_View.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub TallyMember_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If grpPost.Visible = True Then
                If e.KeyCode = Keys.F6 Then
                    Call cmdPost_Click(sender, e)
                    Exit Sub
                ElseIf e.KeyCode = Keys.F2 Then
                    Call cmdFillExport_Click_1(sender, e)
                    Exit Sub
                ElseIf e.KeyCode = Keys.F11 Then
                    Call cmdexit_Click(sender, e)
                    Exit Sub
                End If
            End If

            If GroupBox2.Visible = True Then
                If e.KeyCode = Keys.F9 Then
                    Call Cmd_View_Click_1(sender, e)
                    Exit Sub
                ElseIf e.KeyCode = Keys.F10 Then
                    Call cmdDosView_Click_1(sender, e)
                    Exit Sub
                ElseIf e.KeyCode = Keys.F12 Then
                    Call Cmd_Print_Click_1(sender, e)
                    Exit Sub
                ElseIf e.KeyCode = Keys.F10 Then
                    Call cmdDosView_Click_1(sender, e)
                    Exit Sub
                ElseIf e.KeyCode = Keys.F12 Then
                    Call Cmd_Print_Click_1(sender, e)
                    Exit Sub
                ElseIf e.KeyCode = Keys.F2 Then
                    Call cmdExport_Click(sender, e)
                    Exit Sub
                ElseIf e.KeyCode = Keys.F11 Then
                    Call Cmd_Exit_Click_1(sender, e)
                    Exit Sub
                End If
            End If
            If e.KeyCode = Keys.Escape Then
                'If grp_Billposting.Top = 80 Then
                '    grp_Billposting.Top = 1000
                '    Cmd_View.Focus()
                '    Exit Sub
                'Else
                Call Cmd_Exit_Click_1(sender, e)
                Exit Sub
                'End If
            End If

        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub dtp_Fromdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Fromdate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                dtp_Todate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub dtp_Todate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Todate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Cmd_Fill.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TallyMember_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            '            TallyMemberbool = False
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillTallyMemberdetails()
        Try
            Dim SQLSTRING, ACCOUNTCODE, SLCODE, strAccHead As String
            Dim MTOTAL, TTOTAL As Double
            Dim I, ROWCOUNT, J, K As Integer


            SQLSTRING = "DROP TABLE Tally_MemberMaster_tmp "
            gconnection.getDataSet(SQLSTRING, "TALLYMST")

            SQLSTRING = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,'N' AS VOID"
            SQLSTRING = SQLSTRING & " into Tally_MemberMaster_tmp FROM membermaster "
            gconnection.getDataSet(SQLSTRING, "TALLYMST")


            SQLSTRING = "Update Tally_MemberMaster_tmp set void='Y' where mcode in (select mcode from Tally_membermaster)"
            gconnection.getDataSet(SQLSTRING, "ACCODE")

            SQLSTRING = "Update Tally_MemberMaster_Tmp set void='N' where mcode not in (select mcode from Tally_Membermaster)"
            gconnection.getDataSet(SQLSTRING, "ACCODE")

            GrdAuditTrail.ClearRange(1, 1, -1, -1, True)


            If Mid(gTallyIntegration, 1, 1) = "Y" And Mid(gTallyBulkUpdateKOT, 1, 1) = "Y" Then
                SQLSTRING = "SELECT ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
                SQLSTRING = SQLSTRING & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS LEFT OUTER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE LEFT OUTER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(D.DELFLAG,'')<>'Y' AND ISNULL(H.TallyAddFlag,'')<>'Y' and CONVERT(CHAR(39),H.KOTDATE,106) BETWEEN '" & Format(dtp_Fromdate.Value, "dd MMM yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd MMM yyyy") & "' AND ISNULL(H.BILLSTATUS,'')='ST' GROUP BY H.MCODE,H.MNAME"
            Else
                SQLSTRING = "SELECT ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
                SQLSTRING = SQLSTRING & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS LEFT OUTER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE LEFT OUTER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE LEFT OUTER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(D.DELFLAG,'')<>'Y' AND ISNULL(BILL_HDR.TallyAddFlag,'')<>'Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'  AND ISNULL(H.BILLSTATUS,'')='ST'  GROUP BY H.MCODE,H.MNAME"
            End If
            gconnection.getDataSet(SQLSTRING, "ACCODE")
            With GrdAuditTrail
                .Row = ROWCOUNT
                .Col = 1
                .Text = "MCODE"
                .FontBold = True
                .Col = 2
                .Text = "MNAME"
                .FontBold = True

                .Col = 3
                .Text = "EXIST"
                .FontBold = True

            End With
            If gdataset.Tables("ACCODE").Rows.Count > 0 Then

                ROWCOUNT = ROWCOUNT + 1
                For I = 0 To gdataset.Tables("ACCODE").Rows.Count - 1
                    With TallyMemberssgrid
                        .Row = ROWCOUNT
                        .Col = 1
                        .Text = Trim(gdataset.Tables("ACCODE").Rows(I).Item("Mcode"))
                        .Col = 2
                        .Text = Trim(gdataset.Tables("ACCODE").Rows(I).Item("MNAME"))

                        .Col = 3
                        SQLSTRING = "SELECT * from Tally_membermaster where mcode='" & Trim(gdataset.Tables("ACCODE").Rows(J).Item("mcode")) & "'"
                        gconnection.getDataSet(SQLSTRING, "BILLDETAILS")
                        If gdataset.Tables("BILLDETAILS").Rows.Count > 0 Then
                            .Text = "YES"
                        Else
                            .Text = "NO"
                        End If
                        ROWCOUNT = ROWCOUNT + 1
                        .MaxRows = .MaxRows + 1
                    End With
                Next I
                TallyMemberssgrid.MaxRows = TallyMemberssgrid.MaxRows + 1
                ROWCOUNT = ROWCOUNT + 1
            End If
            TallyMemberssgrid.MaxRows = TallyMemberssgrid.MaxRows + 1
            ROWCOUNT = ROWCOUNT + 1
            TallyMemberssgrid.Visible = True
            GrdAuditTrail.Visible = False
            GroupBox2.Visible = False
        Catch ex As Exception
            MessageBox.Show("Check The Error filleTallyMemberdetails : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub GetRights()
        Try
            Dim i, j, k, x As Integer
            Dim vmain, vsmod, vssmod As Long
            Dim ssql, SQLSTRING As String
            Dim M1 As New MainMenu
            Dim chstr As String
            SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='" & GModule & "' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
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
        Catch ex As Exception
            MessageBox.Show("Check The Error getrights : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            'GrdAuditTrail.ClearRange(1, 1, -1, -1, True)
            'Grp_TallyMember.Visible = False
            'TallyMemberssgrid.Visible = True
            'GroupBox2.Visible = True
            'Label2.Visible = True
            'GroupBox2.BringToFront()
            'GroupBox2.Top = 160
            'GroupBox2.Left = 576
            'TallyMemberssgrid.ClearRange(1, 1, -1, -1, True)
            grpPost.Visible = False
            TallyMemberssgrid.Visible = False
            GrdAuditTrail.Visible = True
            GroupBox2.Visible = True


        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdPost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPost.Click
        Dim strsql As String
        Dim i As Integer
        Try
            If Mid(gTallyIntegration, 1, 1) = "Y" And Mid(gTallyBulkUpdateKOT, 1, 1) = "Y" Then
                Call tallyvalidate_kot()
            Else
                Call tallyvalidate()
            End If
        Catch ex As Exception
            MessageBox.Show("Account Posting is Terminated Abnormally! Bcoz " & ex.Message.ToString(), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Try
            Call ExportTo(TallyMemberssgrid)
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Try
            gPrint = False
            Call subAuditTrial()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub subAuditTrial()
        Try
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
            vCaption = "THE Tally AUDIT TRIAL POSTING FROM " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & " TO " & Format(dtp_Todate.Value, "dd-MMM-yyyy")
            strColumnHead = "|  MCODE  | MNAME                        | Bill Details                 |Bill Amount     |"
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
                        strCol4 = Trim(.Text)

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

                        If strCol3.ToUpper = "TOTAL" Then
                            Filewrite.WriteLine(Chr(15) & "|" & Space(91) & strCol4 & "|")
                            intRowCount = intRowCount + 1
                            boolPrintNext = True
                        End If

                        If strCol3.ToUpper = "GRAND TOTAL" Then
                            Filewrite.WriteLine(Chr(15) & "|" & Space(85) & strCol4 & "|")
                            intRowCount = intRowCount + 1
                            boolPrintNext = True
                        End If

                        SSQL = "|" & strCol1 & Space(10 - Len(strCol1))
                        SSQL = SSQL & "|" & strCol2 & Space(30 - Len(strCol2))
                        SSQL = SSQL & "|" & strCol3 & Space(20 - Len(strCol3))
                        SSQL = SSQL & "|" & Space(16 - Len(strCol4)) & strCol4 & "|"
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
        Catch ex As Exception
            MessageBox.Show("Check The Error subaudittrial : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            gPrint = True
            Call subAuditTrial()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            gPrint = True
            Call subAuditTrial()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdDosView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            gPrint = False
            Call subAuditTrial()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            boolSearchNext = False
            Call subSearch()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            'GroupBox1.Top = 1000
            TallyMemberssgrid.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub subSearch()
        Try
            If Len(Trim(txtSearch.Text)) = 0 Then
                MsgBox("Search Text Can't Be Blank....", MsgBoxStyle.OKOnly, Application.ProductName)
                TallyMemberssgrid.Focus()
                Exit Sub
            End If
            Dim i, j, intStringLength, intRow As Int16
            If TallyMemberssgrid.DataRowCnt > 2 Then
                boolSearchResult = False
                If boolSearchNext = False Then
                    intRow = 1
                Else
                    intRow = Me.TallyMemberssgrid.ActiveRow + 1
                End If
                For i = intRow To TallyMemberssgrid.DataRowCnt
                    Me.TallyMemberssgrid.Row = i
                    Me.TallyMemberssgrid.Col = Me.TallyMemberssgrid.ActiveCol
                    intStringLength = Me.TallyMemberssgrid.Text.Length
                    For j = 1 To intStringLength
                        If intStringLength - j >= Len(Trim(txtSearch.Text)) Then
                            If UCase(Mid(Trim(Me.TallyMemberssgrid.Text), j, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                                Me.TallyMemberssgrid.SetActiveCell(Me.TallyMemberssgrid.ActiveCol, i)
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
            TallyMemberssgrid.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error subserach : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub TallyMemberssgrid_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent)
        Try
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
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    'End Audit Trial
    Private Sub cmdFillExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Call ExportTo(TallyMemberssgrid)
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Function tallybillerr()
        Try
            Dim sqlstring, ssql As String
            Dim rowi As Integer
            pagesize = 0

            sqlstring = "SELECT ISNULL(H.BILLAMOUNT,0) AS BILLAMOUNT,ISNULL(H.KOTDETAILS,'') AS KOTDETAILS,ISNULL(D.BILLDETAILS,'') AS BILLDETAILS,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(H.TallyAddFlag,'')='Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY H.KOTDETAILS,D.BILLDETAILS,H.MCODE,H.MNAME,H.BILLAMOUNT"

            gconnection.getDataSet(sqlstring, "TALLY")
            If gdataset.Tables("TALLY").Rows.Count > 0 Then

                Call Randomize()
                AppPath = Application.StartupPath
                vOutfile = Mid("Bil" & (Rnd() * 800000), 1, 8)
                VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
                Filewrite = File.AppendText(VFilePath)
                printfile = VFilePath
                pageno = 1
                Filewrite.Write(Chr(15))

                Call PrintHeaderbill(dtp_Fromdate.Value, dtp_Todate.Value)

                Filewrite.WriteLine(Space(30) & "Yet to be Post")

                For rowi = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    With gdataset.Tables("TALLY").Rows(rowi)
                        Dim myconnection As New ADODB.Connection
                        myconnection.Open(gTallyDsn)
                        Dim vfill As New ADODB.Recordset
                        ssql = "Select * from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'COMPANYVOUCHERS' where $Reference = '" & Funapos(Funamp(Trim(.Item("KOTDETAILS")))) & "'"
                        vfill.Open(ssql, myconnection)
                        If vfill.EOF Then
                            If pagesize > 58 Then
                                Filewrite.Write(StrDup(40, "-"))
                                Filewrite.Write(Chr(12))
                                pageno = pageno + 1
                                Call PrintHeaderbill(dtp_Fromdate.Value, dtp_Todate.Value)
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If

                            Filewrite.WriteLine(.Item("KOTDETAILS") & " - " & .Item("billdetails"))
                            sqlstring = "UPDATE KOT_HDR SET TALLYADDFLAG='N' WHERE KOTDETAILS='" & .Item("KOTDETAILS") & "'"
                            gconnection.getDataSet(sqlstring, "TALLY1")
                            pagesize = pagesize + 1
                            tallybillerr = True

                        End If
                        vfill.Close()
                        myconnection = Nothing
                    End With
                Next

                Filewrite.WriteLine(Space(30) & "Already Posted Bills")

                For rowi = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    With gdataset.Tables("TALLY").Rows(rowi)
                        Dim myconnection As New ADODB.Connection
                        myconnection.Open(gTallyDsn)
                        Dim vfill As New ADODB.Recordset
                        ssql = "Select * from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'COMPANYVOUCHERS' where $Reference = '" & Funapos(Funamp(Trim(.Item("KOTDETAILS")))) & "'"
                        vfill.Open(ssql, myconnection)
                        If Not vfill.EOF Then
                            If pagesize > 58 Then
                                Filewrite.Write(StrDup(40, "-"))
                                Filewrite.Write(Chr(12))
                                pageno = pageno + 1
                                Call PrintHeaderbill(dtp_Fromdate.Value, dtp_Todate.Value)
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            Filewrite.WriteLine(.Item("KOTDETAILS") & " - " & .Item("billdetails"))
                            sqlstring = "UPDATE KOT_HDR SET TALLYADDFLAG='N' WHERE KOTDETAILS='" & .Item("KOTDETAILS") & "'"
                            gconnection.getDataSet(sqlstring, "TALLY1")
                            pagesize = pagesize + 1
                            tallybillerr = True
                        End If
                        vfill.Close()
                        myconnection = Nothing
                    End With
                Next

                Filewrite.WriteLine(Space(30) & "Recommented Deletion from Tally")

                For rowi = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    With gdataset.Tables("TALLY").Rows(rowi)
                        Dim myconnection As New ADODB.Connection
                        myconnection.Open(gTallyDsn)
                        Dim vfill As New ADODB.Recordset
                        ssql = "Select * from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'COMPANYVOUCHERS' where $Reference = '" & Funapos(Funamp(Trim(.Item("KOTDETAILS")))) & "'"
                        vfill.Open(ssql, myconnection)
                        If Not vfill.EOF Then
                            ssql = "Select * from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'COMPANYVOUCHERS' where $_GrossRevenue = '" & Funapos(Funamp(Trim(.Item("BILLAMOUNT")))) & "' and $Reference = '" & Funapos(Funamp(Trim(.Item("KOTDETAILS")))) & "'"
                            vfill.Open(ssql, myconnection)
                            If vfill.EOF Then
                                If pagesize > 58 Then
                                    Filewrite.Write(StrDup(40, "-"))
                                    Filewrite.Write(Chr(12))
                                    pageno = pageno + 1
                                    Call PrintHeaderbill(dtp_Fromdate.Value, dtp_Todate.Value)
                                    Filewrite.WriteLine()
                                    pagesize = pagesize + 1
                                End If
                                Filewrite.WriteLine(.Item("KOTDETAILS") & " - " & .Item("billdetails"))
                                sqlstring = "UPDATE KOT_HDR SET TALLYADDFLAG='N' WHERE KOTDETAILS='" & .Item("KOTDETAILS") & "'"
                                gconnection.getDataSet(sqlstring, "TALLY1")
                                pagesize = pagesize + 1
                                tallybillerr = True
                            End If
                        End If
                        vfill.Close()
                        myconnection = Nothing
                    End With
                Next

                Filewrite.Write(Chr(12))
                Filewrite.Close()
                gPrint = False
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            Else
                tallybillerr = False
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallybillerr : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call tallybillerr()
    End Sub
    Private Sub Cmd_View_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Try
            TallyMemberssgrid.ClearRange(1, 1, -1, -1, True)
            grp_Billposting.Top = 150
            grp_Billposting.Left = 296
            dtp_Fromdate.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error view click : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdDosView_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDosView.Click
        Try
            gPrint = False
            Call subAuditTrial()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Print_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        Try
            gPrint = True
            Call subAuditTrial()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdFillExport_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFillExport.Click
        Try
            Call ExportTo(GrdAuditTrail)
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Posted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Posted.Click
        Try
            Dim SQLSTRING, ACCOUNTCODE, SLCODE, strAccHead As String
            Dim MTOTAL, TTOTAL As Double
            Dim I, ROWCOUNT, J, K As Integer


            GrdAuditTrail.ClearRange(1, 1, -1, -1, True)

            If tallygrouperr() = False Then ' And tallyLedgererr() = False And tallyCosterr() = False And tallyStockGrouperr() = False And tallyUniterr() = False Then
                ROWCOUNT = 1
                If Mid(gTallyIntegration, 1, 1) = "Y" And Mid(gTallyBulkUpdateKOT, 1, 1) = "Y" Then
                    SQLSTRING = "SELECT ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
                    SQLSTRING = SQLSTRING & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE ISNULL(D.KotStatus,'N')='N' and ISNULL(D.DELFLAG,'')<>'Y' AND ISNULL(H.TALLYADDFLAG,'')<>'Y' AND CONVERT(CHAR(39),H.KOTDATE,106) BETWEEN '" & Format(dtp_Fromdate.Value, "dd MMM yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd MMM yyyy") & "' GROUP BY H.MCODE,H.MNAME"
                Else
                    SQLSTRING = "SELECT ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
                    SQLSTRING = SQLSTRING & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(D.DELFLAG,'')<>'Y' AND ISNULL(BILL_HDR.TallyAddFlag,'')<>'Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY H.MCODE,H.MNAME"
                End If
                gconnection.getDataSet(SQLSTRING, "ACCODE")
                With GrdAuditTrail
                    .Row = ROWCOUNT
                    .Col = 1
                    .Text = "MCODE"
                    .FontBold = True
                    .Col = 2
                    .Text = "MNAME"
                    .FontBold = True
                    .Col = 3
                    .Text = "BILLDETAILS"
                    .FontBold = True
                    .Col = 4
                    .Text = "BILLAMOUNT"
                    .FontBold = True
                End With
                If gdataset.Tables("ACCODE").Rows.Count > 0 Then
                    For I = 0 To gdataset.Tables("ACCODE").Rows.Count - 1
                        With GrdAuditTrail
                            .Row = ROWCOUNT
                            .Col = 1
                            .Text = Trim(gdataset.Tables("ACCODE").Rows(I).Item("Mcode"))
                            .Col = 2
                            .Text = Trim(gdataset.Tables("ACCODE").Rows(I).Item("MNAME"))

                            If Mid(gTallyIntegration, 1, 1) = "Y" And Mid(gTallyBulkUpdateKOT, 1, 1) = "Y" Then
                                SQLSTRING = "SELECT ISNULL(SUM(ISNULL(H.TOTAL,0)+ISNULL(H.TOTALTAX,0)),0) AS BILLAMT,ISNULL(H.KOTDETAILS,'') AS BILLDETAILS,ISNULL(H.KOTDATE,'') AS BILLDATE,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
                                SQLSTRING = SQLSTRING & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(D.DELFLAG,'')<>'Y' AND ISNULL(H.TallyAddFlag,'')<>'Y' and CONVERT(CHAR(39),KOTDATE,106) BETWEEN '" & Format(dtp_Fromdate.Value, "dd MMM yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd MMM yyyy") & "' AND H.MCODE = '" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("MCODE")) & "' GROUP BY H.KOTDETAILS,H.KOTDATE,H.MCODE,H.MNAME"
                            Else
                                SQLSTRING = "SELECT ISNULL(SUM(ISNULL(H.TOTAL,0)+ISNULL(H.TOTALTAX,0)),0) AS BILLAMT,ISNULL(BILL_HDR.BILLDETAILS,'') AS BILLDETAILS,ISNULL(BILL_HDR.BILLDATE,'') AS BILLDATE,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
                                SQLSTRING = SQLSTRING & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(D.DELFLAG,'')<>'Y' AND ISNULL(BILL_HDR.TallyAddFlag,'')<>'Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' AND H.MCODE = '" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("MCODE")) & "' GROUP BY BILL_HDR.BILLDETAILS,BILL_HDR.BILLDATE,H.MCODE,H.MNAME"
                            End If
                            gconnection.getDataSet(SQLSTRING, "SLCODE")
                            If gdataset.Tables("SLCODE").Rows.Count > 0 Then
                                For J = 0 To gdataset.Tables("SLCODE").Rows.Count - 1
                                    .Row = ROWCOUNT

                                    .Col = 3
                                    If Trim(gdataset.Tables("SLCODE").Rows(J).Item("BILLDETAILS")) <> "" Then
                                        .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("BILLDETAILS"))
                                    Else
                                        .Text = ""
                                    End If

                                    .Col = 4
                                    .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("BILLAMT"))

                                    MTOTAL = MTOTAL + Val(Trim(gdataset.Tables("SLCODE").Rows(J).Item("BILLAMT")))
                                    TTOTAL = TTOTAL + Val(Trim(gdataset.Tables("SLCODE").Rows(J).Item("BILLAMT")))
                                    ROWCOUNT = ROWCOUNT + 1
                                    .MaxRows = .MaxRows + 1
                                Next J
                            End If
                        End With
                    Next I
                    GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 1
                    ROWCOUNT = ROWCOUNT + 1
                    GrdAuditTrail.Row = ROWCOUNT
                    GrdAuditTrail.Col = 3
                    GrdAuditTrail.Text = "TOTAL"
                    GrdAuditTrail.Col = 4
                    GrdAuditTrail.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                    GrdAuditTrail.Text = MTOTAL
                    GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 2
                    ROWCOUNT = ROWCOUNT + 2
                End If
                GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 1
                ROWCOUNT = ROWCOUNT + 1
                GrdAuditTrail.Row = ROWCOUNT
                GrdAuditTrail.Col = 3
                GrdAuditTrail.Text = "GRAND TOTAL"
                GrdAuditTrail.Col = 4
                GrdAuditTrail.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                GrdAuditTrail.Text = TTOTAL
                GrdAuditTrail.MaxRows = GrdAuditTrail.MaxRows + 1
                ROWCOUNT = ROWCOUNT + 1

                Grp_TallyMember.Visible = True
                grp_Billposting.Visible = False
                GroupBox2.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error cmd_posted click : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Exit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Try
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Check The Error exit click : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Grp_TallyMember_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grp_TallyMember.Enter

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub grpPost_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpPost.Enter

    End Sub
End Class