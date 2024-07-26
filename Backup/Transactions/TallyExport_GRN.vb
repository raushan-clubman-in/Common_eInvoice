Imports System.Data.SqlClient
Imports System.IO
Imports System.Math
Public Class TallyExport_GRN
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
    Friend WithEvents lbl_head As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents Tallypostingssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Grp_TallyPosting As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_vouchertype As System.Windows.Forms.TextBox
    Friend WithEvents GrpPeriod As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_paymentmode As System.Windows.Forms.ComboBox
    Friend WithEvents GrdAuditTrail1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GrdAuditTrail As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CHKSUPP As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CHKBILLS As System.Windows.Forms.CheckedListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TallyExport_GRN))
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
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CHKBILLS = New System.Windows.Forms.CheckedListBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CHKSUPP = New System.Windows.Forms.CheckedListBox
        Me.lbl_head = New System.Windows.Forms.Label
        Me.Cmd_Cancel = New System.Windows.Forms.Button
        Me.Cmd_Fill = New System.Windows.Forms.Button
        Me.Tallypostingssgrid = New AxFPSpreadADO.AxfpSpread
        Me.GrpPeriod = New System.Windows.Forms.GroupBox
        Me.cmdDosView = New System.Windows.Forms.Button
        Me.cmdFillExport = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grp_TallyPosting = New System.Windows.Forms.GroupBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GrdAuditTrail = New AxFPSpreadADO.AxfpSpread
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpPost = New System.Windows.Forms.GroupBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPost = New System.Windows.Forms.Button
        Me.cmdView = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdExport = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.cbo_paymentmode = New System.Windows.Forms.ComboBox
        Me.GrdAuditTrail1 = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.txt_vouchertype = New System.Windows.Forms.TextBox
        Me.grp_Billposting.SuspendLayout()
        CType(Me.Tallypostingssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPeriod.SuspendLayout()
        Me.Grp_TallyPosting.SuspendLayout()
        CType(Me.GrdAuditTrail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPost.SuspendLayout()
        CType(Me.GrdAuditTrail1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_heading.Location = New System.Drawing.Point(344, 32)
        Me.lbl_heading.Name = "lbl_heading"
        Me.lbl_heading.Size = New System.Drawing.Size(295, 28)
        Me.lbl_heading.TabIndex = 5
        Me.lbl_heading.Text = "Accounts Tally - Export - GRN"
        '
        'Cmd_Posted
        '
        Me.Cmd_Posted.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Posted.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Posted.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Posted.ForeColor = System.Drawing.Color.White
        Me.Cmd_Posted.Image = CType(resources.GetObject("Cmd_Posted.Image"), System.Drawing.Image)
        Me.Cmd_Posted.Location = New System.Drawing.Point(496, 64)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(456, 16)
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
        Me.Cmd_Print.Location = New System.Drawing.Point(256, 64)
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
        Me.Cmd_View.Location = New System.Drawing.Point(16, 16)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 3
        Me.Cmd_View.Text = "Period [F9]"
        '
        'grp_Billposting
        '
        Me.grp_Billposting.BackgroundImage = CType(resources.GetObject("grp_Billposting.BackgroundImage"), System.Drawing.Image)
        Me.grp_Billposting.Controls.Add(Me.CheckBox2)
        Me.grp_Billposting.Controls.Add(Me.CHKBILLS)
        Me.grp_Billposting.Controls.Add(Me.CheckBox1)
        Me.grp_Billposting.Controls.Add(Me.CHKSUPP)
        Me.grp_Billposting.Controls.Add(Me.lbl_head)
        Me.grp_Billposting.Controls.Add(Me.Cmd_Cancel)
        Me.grp_Billposting.Controls.Add(Me.Cmd_Fill)
        Me.grp_Billposting.Controls.Add(Me.lbl_Fromdate)
        Me.grp_Billposting.Controls.Add(Me.dtp_Fromdate)
        Me.grp_Billposting.Controls.Add(Me.lbl_Todate)
        Me.grp_Billposting.Controls.Add(Me.dtp_Todate)
        Me.grp_Billposting.Location = New System.Drawing.Point(80, 160)
        Me.grp_Billposting.Name = "grp_Billposting"
        Me.grp_Billposting.Size = New System.Drawing.Size(856, 312)
        Me.grp_Billposting.TabIndex = 0
        Me.grp_Billposting.TabStop = False
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Location = New System.Drawing.Point(592, 16)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "SELECT ALL"
        '
        'CHKBILLS
        '
        Me.CHKBILLS.Location = New System.Drawing.Point(592, 40)
        Me.CHKBILLS.Name = "CHKBILLS"
        Me.CHKBILLS.Size = New System.Drawing.Size(192, 244)
        Me.CHKBILLS.TabIndex = 10
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(392, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "SELECT ALL"
        '
        'CHKSUPP
        '
        Me.CHKSUPP.Location = New System.Drawing.Point(392, 40)
        Me.CHKSUPP.Name = "CHKSUPP"
        Me.CHKSUPP.Size = New System.Drawing.Size(192, 244)
        Me.CHKSUPP.TabIndex = 8
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
        Me.lbl_head.Text = "GRN POSTING"
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
        Me.Cmd_Fill.Text = "FILL"
        '
        'Tallypostingssgrid
        '
        Me.Tallypostingssgrid.DataSource = Nothing
        Me.Tallypostingssgrid.Location = New System.Drawing.Point(40, 120)
        Me.Tallypostingssgrid.Name = "Tallypostingssgrid"
        Me.Tallypostingssgrid.OcxState = CType(resources.GetObject("Tallypostingssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Tallypostingssgrid.Size = New System.Drawing.Size(944, 432)
        Me.Tallypostingssgrid.TabIndex = 6
        '
        'GrpPeriod
        '
        Me.GrpPeriod.BackColor = System.Drawing.Color.Transparent
        Me.GrpPeriod.Controls.Add(Me.Cmd_View)
        Me.GrpPeriod.Controls.Add(Me.Cmd_Posted)
        Me.GrpPeriod.Controls.Add(Me.Cmd_Print)
        Me.GrpPeriod.Controls.Add(Me.Cmd_Exit)
        Me.GrpPeriod.Controls.Add(Me.cmdDosView)
        Me.GrpPeriod.Controls.Add(Me.cmdFillExport)
        Me.GrpPeriod.Location = New System.Drawing.Point(192, 584)
        Me.GrpPeriod.Name = "GrpPeriod"
        Me.GrpPeriod.Size = New System.Drawing.Size(624, 56)
        Me.GrpPeriod.TabIndex = 79
        Me.GrpPeriod.TabStop = False
        '
        'cmdDosView
        '
        Me.cmdDosView.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdDosView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDosView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDosView.ForeColor = System.Drawing.Color.White
        Me.cmdDosView.Image = CType(resources.GetObject("cmdDosView.Image"), System.Drawing.Image)
        Me.cmdDosView.Location = New System.Drawing.Point(136, 64)
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
        Me.cmdFillExport.Location = New System.Drawing.Point(376, 64)
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
        Me.Label1.Visible = False
        '
        'Grp_TallyPosting
        '
        Me.Grp_TallyPosting.BackColor = System.Drawing.Color.Transparent
        Me.Grp_TallyPosting.Controls.Add(Me.ComboBox2)
        Me.Grp_TallyPosting.Controls.Add(Me.Label2)
        Me.Grp_TallyPosting.Controls.Add(Me.ComboBox1)
        Me.Grp_TallyPosting.Controls.Add(Me.GrdAuditTrail)
        Me.Grp_TallyPosting.Controls.Add(Me.Label3)
        Me.Grp_TallyPosting.Controls.Add(Me.grpPost)
        Me.Grp_TallyPosting.Controls.Add(Me.Button1)
        Me.Grp_TallyPosting.Controls.Add(Me.Label16)
        Me.Grp_TallyPosting.Controls.Add(Me.cbo_paymentmode)
        Me.Grp_TallyPosting.Location = New System.Drawing.Point(8, 8)
        Me.Grp_TallyPosting.Name = "Grp_TallyPosting"
        Me.Grp_TallyPosting.Size = New System.Drawing.Size(1008, 640)
        Me.Grp_TallyPosting.TabIndex = 129
        Me.Grp_TallyPosting.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"Sales"})
        Me.ComboBox2.Location = New System.Drawing.Point(888, 56)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(96, 24)
        Me.ComboBox2.TabIndex = 371
        Me.ComboBox2.Text = "Sales"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(640, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 370
        Me.Label2.Text = "MODULE"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"INVENTORY"})
        Me.ComboBox1.Location = New System.Drawing.Point(720, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 24)
        Me.ComboBox1.TabIndex = 369
        Me.ComboBox1.Text = "INVENTORY"
        '
        'GrdAuditTrail
        '
        Me.GrdAuditTrail.ContainingControl = Me
        Me.GrdAuditTrail.DataSource = Nothing
        Me.GrdAuditTrail.Location = New System.Drawing.Point(120, 132)
        Me.GrdAuditTrail.Name = "GrdAuditTrail"
        Me.GrdAuditTrail.OcxState = CType(resources.GetObject("GrdAuditTrail.OcxState"), System.Windows.Forms.AxHost.State)
        Me.GrdAuditTrail.Size = New System.Drawing.Size(768, 376)
        Me.GrdAuditTrail.TabIndex = 368
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(432, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 34)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "Audit Trial"
        '
        'grpPost
        '
        Me.grpPost.Controls.Add(Me.cmdexit)
        Me.grpPost.Controls.Add(Me.cmdPost)
        Me.grpPost.Controls.Add(Me.cmdView)
        Me.grpPost.Controls.Add(Me.cmdPrint)
        Me.grpPost.Controls.Add(Me.cmdExport)
        Me.grpPost.Location = New System.Drawing.Point(184, 576)
        Me.grpPost.Name = "grpPost"
        Me.grpPost.Size = New System.Drawing.Size(616, 48)
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
        Me.cmdexit.Location = New System.Drawing.Point(496, 11)
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
        Me.cmdPost.Location = New System.Drawing.Point(376, 11)
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
        Me.cmdView.Location = New System.Drawing.Point(16, 11)
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
        Me.cmdPrint.Location = New System.Drawing.Point(136, 11)
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
        Me.cmdExport.Location = New System.Drawing.Point(256, 11)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(104, 32)
        Me.cmdExport.TabIndex = 135
        Me.cmdExport.Text = "Export[F5]"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(840, 592)
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
        'cbo_paymentmode
        '
        Me.cbo_paymentmode.BackColor = System.Drawing.Color.Wheat
        Me.cbo_paymentmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_paymentmode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_paymentmode.Location = New System.Drawing.Point(8, 552)
        Me.cbo_paymentmode.Name = "cbo_paymentmode"
        Me.cbo_paymentmode.Size = New System.Drawing.Size(160, 30)
        Me.cbo_paymentmode.TabIndex = 367
        Me.cbo_paymentmode.Visible = False
        '
        'GrdAuditTrail1
        '
        Me.GrdAuditTrail1.ContainingControl = Me
        Me.GrdAuditTrail1.DataSource = Nothing
        Me.GrdAuditTrail1.Location = New System.Drawing.Point(32, 112)
        Me.GrdAuditTrail1.Name = "GrdAuditTrail1"
        Me.GrdAuditTrail1.OcxState = CType(resources.GetObject("GrdAuditTrail1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.GrdAuditTrail1.Size = New System.Drawing.Size(944, 432)
        Me.GrdAuditTrail1.TabIndex = 128
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
        'txt_vouchertype
        '
        Me.txt_vouchertype.Location = New System.Drawing.Point(16, 656)
        Me.txt_vouchertype.Name = "txt_vouchertype"
        Me.txt_vouchertype.Size = New System.Drawing.Size(64, 21)
        Me.txt_vouchertype.TabIndex = 170
        Me.txt_vouchertype.Text = "GRN"
        '
        'TallyExport_GRN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 699)
        Me.Controls.Add(Me.txt_vouchertype)
        Me.Controls.Add(Me.lbl_heading)
        Me.Controls.Add(Me.GrpPeriod)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_Billposting)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tallypostingssgrid)
        Me.Controls.Add(Me.Grp_TallyPosting)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "TallyExport_GRN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts Tally - Export - GRN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_Billposting.ResumeLayout(False)
        CType(Me.Tallypostingssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPeriod.ResumeLayout(False)
        Me.Grp_TallyPosting.ResumeLayout(False)
        CType(Me.GrdAuditTrail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPost.ResumeLayout(False)
        CType(Me.GrdAuditTrail1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private Sub TallyExport_GRN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Tallypostingbool = True
            Tallypostingssgrid.MaxRows = 999999
            fillPayment_Mode()

            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            grp_Billposting.Top = 1000
        Catch ex As Exception
            MessageBox.Show("Check The Error Load : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Try
            Call FILLSUPPLIER()
            Tallypostingssgrid.ClearRange(1, 1, -1, -1, True)
            grp_Billposting.Top = 150
            grp_Billposting.Left = 296
            dtp_Fromdate.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error view click : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FILLSUPPLIER()
        Dim I As Integer
        SQLSTRING = "SELECT DISTINCT SUPPLIERCODE,SUPPLIERNAME FROM GRN_HEADER WHERE CAST(CONVERT(VARCHAR(11),GRNDATE,106)AS DATETIME) BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(SQLSTRING, "SUUPLIER")
        If gdataset.Tables("SUUPLIER").Rows.Count > 0 Then
            Me.CHKSUPP.Items.Clear()
            For I = 0 To gdataset.Tables("SUUPLIER").Rows.Count - 1
                CHKSUPP.Items.Add(gdataset.Tables("SUUPLIER").Rows(I).Item("SUPPLIERNAME") & "->" & gdataset.Tables("SUUPLIER").Rows(I).Item("SUPPLIERCODE"))
            Next
        End If
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

            sqlstring = "SELECT ISNULL(H.SLIPNO,'') AS SLIPNO,ISNULL(D.BILLDETAILS,'') AS BILLDETAILS,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(BILL_HDR.TallyAddFlag,'')='Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY H.SLIPNO,D.BILLDETAILS,H.MCODE,H.MNAME"
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
                        ssql = "Select * from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'COMPANYVOUCHERS' where $Reference = '" & Funapos(Funamp(Trim(.Item("SLIPNO")))) & "'"
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
                            Filewrite.WriteLine(.Item("SLIPNO") & " - " & .Item("billdetails"))
                            sqlstring = "UPDATE KOT_HDR SET TALLYADDFLAG='N' WHERE SLIPNO='" & .Item("SLIPNO") & "'"
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
            Dim KOTDETAILS, MCODE, MNAME As String
            Dim taxapplicable As String = "Y"

            sqlstring = "SELECT ISNULL(H.SLIPNO,'') AS SLIPNO,ISNULL(H.KOTDETAILS,'') AS KOTDETAILS,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE ISNULL(D.KotStatus,'N')='N' and isnull(d.delflag,'')<>'Y' and CONVERT(CHAR(39),H.KOTDATE,106) BETWEEN '" & Format(dtp_Fromdate.Value, "dd MMM yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd MMM yyyy") & "' AND ISNULL(H.TALLYADDFLAG,'')<>'Y' GROUP BY h.slipno,H.KOTDETAILS,H.MCODE,H.MNAME"
            gconnection.getDataSet(sqlstring, "TALLY")

            If gdataset.Tables("TALLY").Rows.Count > 0 Then
                For ROWI = 0 To gdataset.Tables("TALLY").Rows.Count - 1
                    With gdataset.Tables("TALLY").Rows(ROWI)
                        KOTDETAILS = "'" & Trim(.Item("KOTDETAILS")) & "'"
                        MCODE = .Item("MCODE")
                        MNAME = .Item("MNAME")

                        'FOR GROUP
                        strstring = "SELECT ISNULL(A.TAXFLAG,'Y') as taxflag,a.membertypecode as membertypecode,b.membertype as typedesc,a.mcode as mcode,a.mname as mname,a.padd1 as padd1,a.padd2 as padd2,a.padd3 as padd3,a.pcity as pcity,a.pstate as pstate,a.ppin as ppin,a.pcountry as pcountry,a.pemail as pemail,a.pphone1 as pphone1, a.pphone2 as pphone2, a.pcell as pcell, a.creditlimit as creditlimit from membermaster a,membertype b WHERE a.MCODE='" & Trim(MCODE) & "' and a.membertypecode=b.typedesc"
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
                            strstring = "SELECT ISNULL(A.TAXFLAG,'Y') AS TAXFLAG,a.membertypecode as membertypecode,b.membertype as typedesc,isnull(a.mcode,'') as mcode,isnull(a.mname,'') as mname,isnull(a.padd1,'') as padd1,isnull(a.padd2,'') as padd2,isnull(a.padd3,'') as padd3,isnull(a.pcity,'') as pcity,isnull(a.pstate,'') as pstate,isnull(a.ppin,'') as ppin,isnull(a.pcountry,'') as pcountry,isnull(a.pemail,'') as pemail,isnull(a.pphone1,'') as pphone1, isnull(a.pphone2,'') as pphone2, isnull(a.pcell,'') as pcell, isnull(a.creditlimit,0) as creditlimit from membermaster a,membertype b WHERE a.MCODE='" & Trim(MCODE) & "' and a.membertypecode=b.typedesc"
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
                            End If
                        Else
                            taxapplicable = "Y"
                        End If
                        vfill.Close()

                        'for cost centre
                        sqlstring = "SELECT ISNULL(SUM(ISNULL(D.TAXAMOUNT,0)),0) AS TAXAMOUNT,ISNULL(T.ITEMTYPEDESC,'') AS ITEMTYPEDESC,ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXPERC,0) AS TAXPERC,ISNULL(D.POSCODE,'') AS POSCODE,ISNULL(P.POSDESC,'') AS POSDESC"
                        sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE H.KOTdetails IN (" & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY T.ITEMTYPEDESC,D.TAXCODE,D.TAXPERC,D.POSCODE,P.POSDESC ORDER BY P.POSDESC"
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
                        sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY D.GROUPCODE,G.GROUPDESC"
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
                        sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN UOMMASTER U ON U.UOMCODE = D.UOM WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY D.UOM,U.UOMDESC"
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
                        sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' GROUP BY I.itemcode,I.itemdesc,I.baseuomstd,I.baseqty,I.groupcode"
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

                        sqlstring = "SELECT ISNULL(H.SLIPNO,'') AS SLIPNO,ISNULL(H.TOTAL,0)+ISNULL(H.TOTALTAX,0) AS BILLAMT,ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXPERC,0) AS TAXPERC,ISNULL(H.PAYMENTTYPE,'') AS PAYMENTTYPE,isnull(h.total,0) as TOTAL,isnull(h.roundoff,0) as roundoff,isnull(H.TOTALTAX,0) AS TOTALTAX,ISNULL(H.ADDUSERID,'') AS ADDUSERID,ISNULL(H.KOTNO,'') AS KOTNO,ISNULL(D.KOTDETAILS,'') AS KOTDETAILS,convert(char(39),ISNULL(D.KOTDATE,GETDATE()),112) AS KOTDATE,isnull(D.billdetails,'') as billdetails,ISNULL(D.ITEMCODE,'') AS ITEMCODE,"
                        sqlstring = sqlstring & " ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(I.LEDGERNAME,'') AS LEDGERNAME,ISNULL(PP.POSDESC,'') AS STORENAME,ISNULL(D.POSCODE,'') AS POSCODE,ISNULL(P.POSDESC,'') AS POSDESC,ISNULL(P.PACKINGPERCENT,0) AS PACKINGPERCENT,ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,"
                        sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.SERVERCODE,'') AS SERVERCODE,ISNULL(H.BILLAMOUNT,0) AS BILLAMOUNT,"
                        sqlstring = sqlstring & " ISNULL(H.SERVERNAME,'') AS SERVERNAME,ISNULL(H.REMARKS,'') AS REMARKS  FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE  INNER JOIN POSMASTER AS PP ON PP.POSCODE = D.POSCODE WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' ORDER BY POSCODE"
                        gconnection.getDataSet(sqlstring, "KOTHDR")
                        If gdataset.Tables("KOTHDR").Rows.Count > 0 Then
                            If taxapplicable = "Y" Then
                                Select Case Trim(gdataset.Tables("KOTHDR").Rows(0).Item("PAYMENTTYPE"))
                                    Case "CASH"
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='CASH COUPON' ACTION='Create'>"       ' for create / update / delete
                                    Case "R.MEMBER" 'CASH COUPON 
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='CASH COUPON' ACTION='Create'>"       ' for create / update / delete
                                    Case "COUPON" 'CASH COUPON - CNOTE
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='CASH COUPON - C NOTE' ACTION='Create'>"       ' for create / update / delete
                                    Case "PARTY" 'DINNER
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='DINNER' ACTION='Create'>"       ' for create / update / delete
                                    Case "SMART CARD"
                                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='CASH COUPON' ACTION='Create'>"       ' for create / update / delete
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
                                    Case "R.MEMBER"  'CASH COUPON 
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>CASH COUPON</VOUCHERTYPENAME>"
                                    Case "COUPON" 'CASH COUPON - CNOTE
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>CASH COUPON - C NOTE</VOUCHERTYPENAME>"
                                    Case "PARTY" 'DINNER
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>DINNER</VOUCHERTYPENAME>"
                                    Case Else '"CREDIT" 'KOT
                                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>K O T</VOUCHERTYPENAME>"
                                End Select
                            Else
                                strRequestXML = strRequestXML & "<VOUCHERTYPENAME>DNR-KOT</VOUCHERTYPENAME>"
                            End If

                            strRequestXML = strRequestXML & "<VOUCHERNUMBER>" & Trim(gdataset.Tables("KOTHDR").Rows(0).Item("SLIPNO")) & "</VOUCHERNUMBER>"
                            strRequestXML = strRequestXML & "<REFERENCE>" & Trim(gdataset.Tables("KOTHDR").Rows(0).Item("SLIPNO")) & "</REFERENCE>" 'kotno

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
                            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N'"
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
                            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' AND ISNULL(D.TAXAMOUNT,0)>0 GROUP BY T.ITEMTYPEDESC,D.TAXCODE,D.TAXPERC,H.LOCATIONCODE,P.POSDESC ORDER BY P.POSDESC"

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
                            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE H.KOTdetails IN ( " & Trim(KOTDETAILS) & ") AND ISNULL(KotStatus,'N')='N' AND ISNULL(D.PACKAMOUNT,0)>0 GROUP BY H.LOCATIONCODE,P.POSDESC ORDER BY P.POSDESC"
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

                        sqlstring = "UPDATE KOT_HDR SET TALLYADDFLAG='Y' WHERE KOTdetails IN ( '" & Trim(.Item("KOTDETAILS")) & "')"
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
                                SQLSTRING = "SELECT ISNULL(SUM(ISNULL(H.TOTAL,0)+ISNULL(H.TOTALTAX,0)),0) AS BILLAMT,ISNULL(H.SLIPNO,'') AS BILLDETAILS,ISNULL(H.KOTDATE,'') AS BILLDATE,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
                                SQLSTRING = SQLSTRING & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(D.DELFLAG,'')<>'Y' AND ISNULL(H.TallyAddFlag,'')<>'Y' and CONVERT(CHAR(39),KOTDATE,106) BETWEEN '" & Format(dtp_Fromdate.Value, "dd MMM yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd MMM yyyy") & "' AND H.MCODE = '" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("MCODE")) & "' GROUP BY H.SLIPNO,H.KOTDATE,H.MCODE,H.MNAME"
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

                Grp_TallyPosting.Visible = True
                grp_Billposting.Visible = False
                GrpPeriod.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error cmd_posted click : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Check The Error exit click : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Fill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Fill.Click
        Try
            'new import
            Call FillTallypostingdetails()
            grp_Billposting.Top = 1000
            '            Call TallyExport_GRN()
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
    Private Sub TallyExport_GRN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
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
                Me.Tallypostingssgrid.Focus()
                Me.Tallypostingssgrid.SetActiveCell(1, 1)
                Exit Sub
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

    Private Sub TallyExport_GRN_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            Tallypostingbool = False
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillTallypostingdetails()
        Try
            Dim myconnection As New ADODB.Connection
            Dim ssql As String
            Dim sval1 As Double
            'myconnection.Open(gTallyDsn)

            Dim SQLSTRING, ACCOUNTCODE, SLCODE, strAccHead As String
            Dim MTOTAL, TTOTAL As Double
            Dim I, ROWCOUNT, J, K As Integer

            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30
            Dim strRequestXML As String
            Dim strstring, LEDGER As String
            Dim sql As String
            Dim otherbillno As String
            Dim otherbool As Boolean
            Dim ROWJ, ROWI, ROWJJ As Integer
            Dim MCODE, MNAME As String
            Dim AMOUNT As Double
            Dim taxapplicable As String = "Y"


            SQLSTRING = "TRUNCATE TABLE Tally_JournalEntry_Tmp "
            gconnection.getDataSet(SQLSTRING, "TALLYMST")
            Dim BILLS As String
            SQLSTRING = "DROP TABLE TMP_MONTHBILL "
            gconnection.getDataSet(SQLSTRING, "TALLYMST")

            SQLSTRING = "select * into TMP_MONTHBILL from VIEW_OTHERS_BILL A WHERE A.VOUCHERDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' AND MODULE='INVENTORY' AND VOUCHERNO IN('"
            If Me.CHKBILLS.CheckedItems.Count > 0 Then
                For I = 0 To CHKBILLS.CheckedItems.Count - 1
                    BILLS = ""
                    BILLS = Trim(CHKBILLS.CheckedItems(I))
                    'If SPCODE1 <> "" Then
                    '    SPCODE = Nothing
                    '    SPCODE = Split(SPCODE1, "->")
                    SQLSTRING = SQLSTRING & BILLS & "','"
                    ' End If


                Next
                SQLSTRING = Mid(SQLSTRING, 1, Len(SQLSTRING) - 2)
                SQLSTRING = SQLSTRING & ")"
            End If
            gconnection.getDataSet(SQLSTRING, "TALLYMST")


            SQLSTRING = "insert into Tally_JournalEntry_Tmp (VoucherNo,VoucherDate,VoucherCategory,VoucherType,AccountCode,AccountcodeDesc,SLCode,SLDesc,CreditDebit,Amount,Description,Void) (select VoucherNo,VoucherDate,VoucherCategory,VoucherType,AccountCode,AccountcodeDesc,SLCode,SLDesc,CreditDebit,Amount,Description,Void from tmp_monthbill)"
            gconnection.getDataSet(SQLSTRING, "TALLYMST")



            GrdAuditTrail.ClearRange(1, 1, -1, -1, True)

            'SQLSTRING = "Update Tally_Journalentry_tmp set void='Y' where vouchercategory='PBILL' and month(voucherdate)=" & Month(dtp_Todate.Value) & " and slcode+vouchertype+vouchercategory in (select slcode+vouchertype+vouchercategory from Tally_journalentry WHERE month(voucherdate)=" & Month(dtp_Todate.Value) & " and vouchercategory='PBILL')"
            'gconnection.getDataSet(SQLSTRING, "ACCODE")

            'SQLSTRING = "Update Tally_Journalentry_tmp set void='N' where vouchercategory='PBILL' and month(voucherdate)=" & Month(dtp_Todate.Value) & " and slcode+vouchertype+vouchercategory not in (select slcode+vouchertype+vouchercategory from Tally_journalentry WHERE month(voucherdate)=" & Month(dtp_Todate.Value) & " and vouchercategory='PBILL')"
            'gconnection.getDataSet(SQLSTRING, "ACCODE")

            SQLSTRING = "SELECT D.VOUCHERDATE"
            SQLSTRING = SQLSTRING & " FROM Tally_Journalentry_tmp AS D WHERE  CONVERT(CHAR(39),D.VOUCHERDATE,106) BETWEEN '" & Format(dtp_Fromdate.Value, "dd MMM yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd MMM yyyy") & "' GROUP BY D.VOUCHERDATE ORDER BY D.VOUCHERDATE"

            gconnection.getDataSet(SQLSTRING, "ACCODE")
            With GrdAuditTrail
                .Row = ROWCOUNT
                .Col = 1
                .Text = "SLCODE"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit

                .FontBold = True
                .Col = 2
                .Text = "SLNAME"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit

                .FontBold = True
                .Col = 3
                .Text = "VOUCHERNO"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                .FontBold = True

                .Col = 4
                .Text = "VOUCHERDATE"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                .FontBold = True

                .Col = 5
                .Text = "VOUCHERTYPE"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                .FontBold = True


                .Col = 6
                .Text = "AMOUNT"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                .FontBold = True

                .Col = 7
                .Text = "Exist"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                .FontBold = True

            End With

            ROWCOUNT = ROWCOUNT + 2
            If gdataset.Tables("ACCODE").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("ACCODE").Rows.Count - 1
                    With Tallypostingssgrid

                        SQLSTRING = "SELECT isnull(void,'') as void,isnull(vouchertype,'') as vouchertype,ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT,ISNULL(VOUCHERNO,'') AS VOUCHERNO,ISNULL(VOUCHERDATE,'') AS VOUCHERDATE,ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLDESC,'') AS SLDESC"
                        SQLSTRING = SQLSTRING & " FROM Tally_Journalentry_tmp where creditdebit='DEBIT' and isnull(void,'')='Y' and CONVERT(CHAR(39),voucherDATE,106) = '" & Format(gdataset.Tables("ACCODE").Rows(I).Item("VOUCHERDATE"), "dd MMM yyyy") & "' GROUP BY VOUCHERNO,VOUCHERDATE,SLCODE,SLDESC,vouchertype,void ORDER BY VoucherDate,Void,Vouchertype,slcode"
                        gconnection.getDataSet(SQLSTRING, "SLCODE")
                        If gdataset.Tables("SLCODE").Rows.Count > 0 Then
                            .Row = ROWCOUNT
                            .Col = 2
                            .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                            .Text = "POSTED VOUCHERS"
                            ROWCOUNT = ROWCOUNT + 1
                            For J = 0 To gdataset.Tables("SLCODE").Rows.Count - 1

                                .Row = ROWCOUNT

                                .Col = 1
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLcode"))
                                .Col = 2
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLDesc"))

                                .Col = 3
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERNO")) <> "" Then
                                    .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERNO"))
                                Else
                                    .Text = ""
                                End If


                                .Col = 4
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERDATE")) <> "" Then
                                    .Text = CDate(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERDATE"))
                                Else
                                    .Text = ""
                                End If

                                .Col = 5
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERTYPE")) <> "" Then
                                    .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERTYPE"))
                                Else
                                    .Text = ""
                                End If

                                .Col = 6
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("AMOUNT"))


                                .Col = 7
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("void")) = "Y" Then
                                    .Text = "YES"
                                Else
                                    .Text = "NO"
                                End If


                                MTOTAL = MTOTAL + Val(Trim(gdataset.Tables("SLCODE").Rows(J).Item("AMOUNT")))
                                TTOTAL = TTOTAL + Val(Trim(gdataset.Tables("SLCODE").Rows(J).Item("AMOUNT")))
                                ROWCOUNT = ROWCOUNT + 1
                                .MaxRows = .MaxRows + 1
                            Next J
                            Tallypostingssgrid.MaxRows = Tallypostingssgrid.MaxRows + 1
                            ROWCOUNT = ROWCOUNT + 1
                            Tallypostingssgrid.Row = ROWCOUNT
                            Tallypostingssgrid.Col = 3
                            Tallypostingssgrid.Text = "TOTAL"
                            Tallypostingssgrid.Col = 6
                            Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                            Tallypostingssgrid.Text = MTOTAL
                            Tallypostingssgrid.MaxRows = Tallypostingssgrid.MaxRows + 2
                            ROWCOUNT = ROWCOUNT + 2
                            MTOTAL = 0
                        End If

                        SQLSTRING = "SELECT isnull(void,'') as void,isnull(vouchertype,'') as vouchertype,ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT,ISNULL(VOUCHERNO,'') AS VOUCHERNO,ISNULL(VOUCHERDATE,'') AS VOUCHERDATE,ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLDESC,'') AS SLDESC"
                        SQLSTRING = SQLSTRING & " FROM Tally_Journalentry_tmp where creditdebit='DEBIT' and isnull(void,'')='N' and CONVERT(CHAR(39),voucherDATE,106) = '" & Format(gdataset.Tables("ACCODE").Rows(I).Item("VOUCHERDATE"), "dd MMM yyyy") & "' GROUP BY VOUCHERNO,VOUCHERDATE,SLCODE,SLDESC,vouchertype,void ORDER BY VoucherDate,Void,Vouchertype,slcode"
                        gconnection.getDataSet(SQLSTRING, "SLCODE")
                        If gdataset.Tables("SLCODE").Rows.Count > 0 Then
                            .Row = ROWCOUNT
                            .Col = 2
                            .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                            .Text = "YET TO BE POST - PENDING VOUCHERS"
                            ROWCOUNT = ROWCOUNT + 1
                            For J = 0 To gdataset.Tables("SLCODE").Rows.Count - 1

                                .Row = ROWCOUNT

                                .Col = 1
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLcode"))
                                .Col = 2
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLDesc"))

                                .Col = 3
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERNO")) <> "" Then
                                    .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERNO"))
                                Else
                                    .Text = ""
                                End If

                                .Col = 4
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERDATE")) <> "" Then
                                    .Text = CDate(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERDATE"))
                                Else
                                    .Text = ""
                                End If

                                .Col = 5
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERTYPE")) <> "" Then
                                    .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERTYPE"))
                                Else
                                    .Text = ""
                                End If

                                .Col = 6
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("AMOUNT"))


                                .Col = 7
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("void")) = "Y" Then
                                    .Text = "YES"
                                Else
                                    .Text = "NO"
                                End If


                                MTOTAL = MTOTAL + Val(Trim(gdataset.Tables("SLCODE").Rows(J).Item("AMOUNT")))
                                TTOTAL = TTOTAL + Val(Trim(gdataset.Tables("SLCODE").Rows(J).Item("AMOUNT")))
                                ROWCOUNT = ROWCOUNT + 1
                                .MaxRows = .MaxRows + 1
                            Next J
                            Tallypostingssgrid.MaxRows = Tallypostingssgrid.MaxRows + 1
                            ROWCOUNT = ROWCOUNT + 1
                            Tallypostingssgrid.Row = ROWCOUNT
                            Tallypostingssgrid.Col = 3
                            Tallypostingssgrid.Text = "TOTAL"
                            Tallypostingssgrid.Col = 6
                            Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                            Tallypostingssgrid.Text = MTOTAL
                            Tallypostingssgrid.MaxRows = Tallypostingssgrid.MaxRows + 2
                            ROWCOUNT = ROWCOUNT + 2
                            MTOTAL = 0
                        End If

                    End With
                Next I
            End If
            Tallypostingssgrid.MaxRows = Tallypostingssgrid.MaxRows + 1
            ROWCOUNT = ROWCOUNT + 1
            Tallypostingssgrid.Row = ROWCOUNT
            Tallypostingssgrid.Col = 3
            Tallypostingssgrid.Text = "GRAND TOTAL"
            Tallypostingssgrid.Col = 6
            Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
            Tallypostingssgrid.Text = TTOTAL
            Tallypostingssgrid.MaxRows = GrdAuditTrail.MaxRows + 1
            ROWCOUNT = ROWCOUNT + 1

            Tallypostingssgrid.Visible = True
            grpPost.Visible = True
            GrdAuditTrail.Visible = False
            GrpPeriod.Visible = False
            grpPost.Visible = True
        Catch ex As Exception
            MessageBox.Show("Tally " & ex.Message.ToString, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillTallypostingdetailsOLD()
        Try
            Dim myconnection As New ADODB.Connection
            Dim ssql As String
            Dim sval1 As Double
            myconnection.Open(gTallyDsn)

            Dim SQLSTRING, ACCOUNTCODE, SLCODE, strAccHead As String
            Dim MTOTAL, TTOTAL As Double
            Dim CRMTOTAL, CRTTOTAL As Double
            Dim I, ROWCOUNT, J, K As Integer

            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30
            Dim strRequestXML As String
            Dim strstring, LEDGER As String
            Dim sql As String
            Dim otherbillno As String
            Dim otherbool As Boolean
            Dim ROWJ, ROWI, ROWJJ As Integer
            Dim MCODE, MNAME, VOUCHERTYPE As String
            Dim AMOUNT As Double
            Dim taxapplicable As String = "Y"

            Dim GRNDETAILS As String


            SQLSTRING = "TRUNCATE TABLE Tally_JournalEntry_Tmp "
            gconnection.getDataSet(SQLSTRING, "TALLYMST")

            SQLSTRING = "DROP TABLE TMP_GRN "
            gconnection.getDataSet(SQLSTRING, "TALLYMST")

            SQLSTRING = "select * into TMP_GRN from VIEW_GRN_TALLY A WHERE A.GRNDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
            gconnection.getDataSet(SQLSTRING, "TALLYMST")

            SQLSTRING = "SELECT A.GRNDETAILS,A.GRNDATE,A.CRCODE AS CRCODE,A.CRNAME AS CRNAME,ISNULL(SUM(ISNULL(A.BILLAMOUNT,0)),0) AS AMOUNT FROM TMP_GRN A GROUP BY A.GRNDETAILS,A.GRNDATE,A.CRCODE,A.CRNAME ORDER BY A.CRCODE"
            gconnection.getDataSet(SQLSTRING, "TALLYMST")
            If gdataset.Tables("TALLYMST").Rows.Count > 0 Then
                For ROWI = 0 To gdataset.Tables("TALLYMST").Rows.Count - 1
                    With gdataset.Tables("TALLYMST").Rows(ROWI)
                        MCODE = .Item("CRCODE")
                        MNAME = .Item("CRNAME")
                        AMOUNT = .Item("AMOUNT")
                        GRNDETAILS = .Item("GRNDETAILS")

                        'SUPPLIER AMOUNT - BILLAMOUNT
                        SQLSTRING = "insert into Tally_JournalEntry_Tmp (VoucherNo,VoucherDate,VoucherCategory,VoucherType,CashBank,AccountCode,AccountcodeDesc,SLCode,SLDesc,CreditDebit,Amount,Description,Void)"
                        SQLSTRING = SQLSTRING & " VALUES ('" & .Item("GRNDETAILS") & "',"
                        SQLSTRING = SQLSTRING & " '" & Format(.Item("GRNDATE"), "dd-MMM-yyyy") & "',"
                        SQLSTRING = SQLSTRING & " 'GRN',"
                        SQLSTRING = SQLSTRING & " '" & txt_vouchertype.Text & "','',"
                        SQLSTRING = SQLSTRING & " 'SCRS','SUNDRY CREDITORS',"
                        SQLSTRING = SQLSTRING & " '" & Funapos(Funamp(MCODE)) & "',"
                        SQLSTRING = SQLSTRING & " '" & Funapos(Funamp(MNAME)) & "',"
                        SQLSTRING = SQLSTRING & " 'CREDIT'," & AMOUNT & ","
                        SQLSTRING = SQLSTRING & " 'GRN POSTING FROM CLUBMAN','N')"
                        gconnection.getDataSet(SQLSTRING, "TALLY")

                        ROWJJ = 0
                        'PURCHASE LEDGER AMOUNT
                        SQLSTRING = "SELECT A.GRNDETAILS,A.GRNDATE,A.LEDGER AS LEDGER,ISNULL(SUM(ISNULL(A.AMOUNT,0)),0) AS AMOUNT FROM TMP_GRN A WHERE A.GRNDETAILS='" & GRNDETAILS & "' GROUP BY A.GRNDETAILS,A.GRNDATE,A.LEDGER ORDER BY A.LEDGER"
                        gconnection.getDataSet(SQLSTRING, "TALLYMM")
                        If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
                            For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
                                LEDGER = ""
                                AMOUNT = 0

                                SQLSTRING = "insert into Tally_JournalEntry_Tmp (VoucherNo,VoucherDate,VoucherCategory,VoucherType,CashBank,AccountCode,AccountcodeDesc,SLCode,SLDesc,CreditDebit,Amount,Description,Void)"
                                SQLSTRING = SQLSTRING & " VALUES ('" & .Item("GRNDETAILS") & "',"
                                SQLSTRING = SQLSTRING & " '" & Format(.Item("GRNDATE"), "dd-MMM-yyyy") & "',"
                                SQLSTRING = SQLSTRING & " 'GRN',"
                                SQLSTRING = SQLSTRING & " '" & txt_vouchertype.Text & "','',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "',"
                                SQLSTRING = SQLSTRING & " '',"
                                SQLSTRING = SQLSTRING & " '',"
                                SQLSTRING = SQLSTRING & " 'DEBIT'," & gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") & ","
                                SQLSTRING = SQLSTRING & " 'GRN POSTING FROM CLUBMAN','N')"
                                gconnection.getDataSet(SQLSTRING, "TALLY")

                            Next

                        End If

                        ROWJJ = 0
                        'TAX LEDGER AMOUNT
                        SQLSTRING = "SELECT A.GRNDETAILS,A.GRNDATE,A.TAXLEDGER AS LEDGER,ISNULL(SUM(ISNULL(A.TAXAMOUNT,0)),0) AS AMOUNT FROM TMP_GRN A WHERE A.GRNDETAILS='" & GRNDETAILS & "' GROUP BY A.GRNDETAILS,A.GRNDATE,A.TAXLEDGER ORDER BY A.TAXLEDGER"
                        gconnection.getDataSet(SQLSTRING, "TALLYMM")
                        If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
                            For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
                                LEDGER = ""
                                AMOUNT = 0

                                SQLSTRING = "insert into Tally_JournalEntry_Tmp (VoucherNo,VoucherDate,VoucherCategory,VoucherType,CashBank,AccountCode,AccountcodeDesc,SLCode,SLDesc,CreditDebit,Amount,Description,Void)"
                                SQLSTRING = SQLSTRING & " VALUES ('" & .Item("GRNDETAILS") & "',"
                                SQLSTRING = SQLSTRING & " '" & Format(.Item("GRNDATE"), "dd-MMM-yyyy") & "',"
                                SQLSTRING = SQLSTRING & " 'GRN',"
                                SQLSTRING = SQLSTRING & " '" & txt_vouchertype.Text & "','',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "',"
                                SQLSTRING = SQLSTRING & " '',"
                                SQLSTRING = SQLSTRING & " '',"
                                SQLSTRING = SQLSTRING & " 'DEBIT'," & gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") & ","
                                SQLSTRING = SQLSTRING & " 'GRN POSTING FROM CLUBMAN','N')"
                                gconnection.getDataSet(SQLSTRING, "TALLY")

                            Next

                        End If


                        ROWJJ = 0
                        'DISCOUNT LEDGER AMOUNT
                        SQLSTRING = "SELECT A.GRNDETAILS,A.GRNDATE,A.DiscountLedger AS LEDGER,ISNULL(SUM(ISNULL(A.Discount,0)),0) AS AMOUNT FROM TMP_GRN A WHERE A.GRNDETAILS='" & GRNDETAILS & "' GROUP BY A.GRNDETAILS,A.GRNDATE,A.DISCOUNTLEDGER ORDER BY A.DISCOUNTLEDGER"
                        gconnection.getDataSet(SQLSTRING, "TALLYMM")
                        If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
                            For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
                                LEDGER = ""
                                AMOUNT = 0

                                SQLSTRING = "insert into Tally_JournalEntry_Tmp (VoucherNo,VoucherDate,VoucherCategory,VoucherType,CashBank,AccountCode,AccountcodeDesc,SLCode,SLDesc,CreditDebit,Amount,Description,Void)"
                                SQLSTRING = SQLSTRING & " VALUES ('" & .Item("GRNDETAILS") & "',"
                                SQLSTRING = SQLSTRING & " '" & Format(.Item("GRNDATE"), "dd-MMM-yyyy") & "',"
                                SQLSTRING = SQLSTRING & " 'GRN',"
                                SQLSTRING = SQLSTRING & " '" & txt_vouchertype.Text & "','',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "',"
                                SQLSTRING = SQLSTRING & " '',"
                                SQLSTRING = SQLSTRING & " '',"

                                If gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") > 0 Then
                                    SQLSTRING = SQLSTRING & " 'CREDIT'," & gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") & ","
                                Else
                                    SQLSTRING = SQLSTRING & " 'DEBIT'," & gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") & ","
                                End If

                                SQLSTRING = SQLSTRING & " 'GRN POSTING FROM CLUBMAN','N')"
                                gconnection.getDataSet(SQLSTRING, "TALLY")

                            Next

                        End If

                        ROWJJ = 0
                        'OTHCHARGE LEDGER AMOUNT
                        SQLSTRING = "SELECT A.GRNDETAILS,A.GRNDATE,A.OtherLedger AS LEDGER,ISNULL(SUM(ISNULL(A.OTHCHARGE,0)),0) AS AMOUNT FROM TMP_GRN A WHERE A.GRNDETAILS='" & GRNDETAILS & "' GROUP BY A.GRNDETAILS,A.GRNDATE,A.OtherLedger ORDER BY A.OtherLedger"
                        gconnection.getDataSet(SQLSTRING, "TALLYMM")
                        If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
                            For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
                                LEDGER = ""
                                AMOUNT = 0

                                SQLSTRING = "insert into Tally_JournalEntry_Tmp (VoucherNo,VoucherDate,VoucherCategory,VoucherType,CashBank,AccountCode,AccountcodeDesc,SLCode,SLDesc,CreditDebit,Amount,Description,Void)"
                                SQLSTRING = SQLSTRING & " VALUES ('" & .Item("GRNDETAILS") & "',"
                                SQLSTRING = SQLSTRING & " '" & Format(.Item("GRNDATE"), "dd-MMM-yyyy") & "',"
                                SQLSTRING = SQLSTRING & " 'GRN',"
                                SQLSTRING = SQLSTRING & " '" & txt_vouchertype.Text & "','',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "',"
                                SQLSTRING = SQLSTRING & " '',"
                                SQLSTRING = SQLSTRING & " '',"
                                If gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") > 0 Then
                                    SQLSTRING = SQLSTRING & " 'DEBIT'," & gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") & ","
                                Else
                                    SQLSTRING = SQLSTRING & " 'CREDIT'," & gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") & ","
                                End If
                                SQLSTRING = SQLSTRING & " 'GRN POSTING FROM CLUBMAN','N')"
                                gconnection.getDataSet(SQLSTRING, "TALLY")

                            Next

                        End If


                        ROWJJ = 0
                        'OverallLedger LEDGER AMOUNT
                        SQLSTRING = "SELECT A.GRNDETAILS,A.GRNDATE,A.OverallLedger AS LEDGER,ISNULL(SUM(ISNULL(A.OverallDiscount,0)),0) AS AMOUNT FROM TMP_GRN A WHERE A.GRNDETAILS='" & GRNDETAILS & "' GROUP BY A.GRNDETAILS,A.GRNDATE,A.OverallLedger ORDER BY A.OverallLedger"
                        gconnection.getDataSet(SQLSTRING, "TALLYMM")
                        If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
                            For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
                                LEDGER = ""
                                AMOUNT = 0

                                SQLSTRING = "insert into Tally_JournalEntry_Tmp (VoucherNo,VoucherDate,VoucherCategory,VoucherType,CashBank,AccountCode,AccountcodeDesc,SLCode,SLDesc,CreditDebit,Amount,Description,Void)"
                                SQLSTRING = SQLSTRING & " VALUES ('" & .Item("GRNDETAILS") & "',"
                                SQLSTRING = SQLSTRING & " '" & Format(.Item("GRNDATE"), "dd-MMM-yyyy") & "',"
                                SQLSTRING = SQLSTRING & " 'GRN',"
                                SQLSTRING = SQLSTRING & " '" & txt_vouchertype.Text & "','',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "',"
                                SQLSTRING = SQLSTRING & " '" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "',"
                                SQLSTRING = SQLSTRING & " '',"
                                SQLSTRING = SQLSTRING & " '',"

                                If gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") > 0 Then
                                    SQLSTRING = SQLSTRING & " 'CREDIT'," & gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") & ","
                                Else
                                    SQLSTRING = SQLSTRING & " 'DEBIT'," & gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT") & ","
                                End If

                                SQLSTRING = SQLSTRING & " 'GRN POSTING FROM CLUBMAN','N')"
                                gconnection.getDataSet(SQLSTRING, "TALLY")
                            Next
                        End If
                    End With
                Next

                '      ssql = "Cp_Journalentry '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "','" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                '     gconnection.dataOperation1(2, ssql, "Billhdr")

            Else
                MsgBox("There is no record(s) to Post.......", MsgBoxStyle.OKOnly, "Month Bill Posted to Accounts Tally")
            End If


            '     GrdAuditTrail.ClearRange(1, 1, -1, -1, True)

            SQLSTRING = "Update Tally_Journalentry_tmp set void='Y' where vouchercategory='MBILL' and month(voucherdate)=" & Month(dtp_Todate.Value) & " and slcode+vouchertype+voucherno+vouchercategory in (select slcode+vouchertype+voucherno+vouchercategory from Tally_journalentry WHERE month(voucherdate)=" & Month(dtp_Todate.Value) & ")"
            gconnection.getDataSet(SQLSTRING, "ACCODE")

            SQLSTRING = "Update Tally_Journalentry_tmp set void='N' where vouchercategory='MBILL' and month(voucherdate)=" & Month(dtp_Todate.Value) & " and slcode+vouchertype+voucherno+vouchercategory not in (select slcode+vouchertype+voucherno+vouchercategory from Tally_journalentry WHERE month(voucherdate)=" & Month(dtp_Todate.Value) & ")"
            gconnection.getDataSet(SQLSTRING, "ACCODE")

            SQLSTRING = "SELECT D.VOUCHERNO"
            SQLSTRING = SQLSTRING & " FROM Tally_Journalentry_tmp AS D WHERE  CONVERT(CHAR(39),D.VOUCHERDATE,106) BETWEEN '" & Format(dtp_Fromdate.Value, "dd MMM yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd MMM yyyy") & "' GROUP BY D.VOUCHERNO ORDER BY D.VOUCHERNO"

            gconnection.getDataSet(SQLSTRING, "ACCODE")
            With GrdAuditTrail
                .Row = ROWCOUNT

                .Col = 1
                .Text = "ACCODE"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit

                .FontBold = True
                .Col = 2
                .Text = "ACDESC"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit

                .Col = 3
                .Text = "SLCODE"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit

                .FontBold = True
                .Col = 4
                .Text = "SLNAME"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit

                .FontBold = True
                .Col = 5
                .Text = "VOUCHERNO"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                .FontBold = True

                .Col = 6
                .Text = "VOUCHERDATE"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                .FontBold = True

                .Col = 7
                .Text = "VOUCHERTYPE"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                .FontBold = True


                .Col = 8
                .Text = "DrAMOUNT"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                .FontBold = True


                .Col = 9
                .Text = "CrAMOUNT"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                .FontBold = True

                .Col = 10
                .Text = "Exist"
                Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                .FontBold = True

            End With

            ROWCOUNT = ROWCOUNT + 2
            If gdataset.Tables("ACCODE").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("ACCODE").Rows.Count - 1
                    With Tallypostingssgrid

                        SQLSTRING = "SELECT isnull(void,'') as void,isnull(vouchertype,'') as vouchertype,case when creditdebit='DEBIT' then ISNULL(SUM(ISNULL(AMOUNT,0)),0) else 0 end AS DRAMOUNT,case when creditdebit<>'DEBIT' then ISNULL(SUM(ISNULL(AMOUNT,0)),0) else 0 end AS CRAMOUNT,ISNULL(VOUCHERNO,'') AS VOUCHERNO,ISNULL(VOUCHERDATE,'') AS VOUCHERDATE,ISNULL(ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(ACCOUNTCODEDESC,'') AS ACCOUNTCODEDESC,ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLDESC,'') AS SLDESC"
                        SQLSTRING = SQLSTRING & " FROM Tally_Journalentry_tmp where isnull(amount,0)<>0 and isnull(void,'')='Y' and voucherNO = '" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("VOUCHERNO")) & "' GROUP BY VOUCHERNO,VOUCHERDATE,ACCOUNTCODE,ACCOUNTCODEDESC,SLCODE,SLDESC,vouchertype,void,creditdebit ORDER BY VoucherDate,Void,Vouchertype,creditdebit,ACCOUNTCODE,slcode"
                        gconnection.getDataSet(SQLSTRING, "SLCODE")
                        If gdataset.Tables("SLCODE").Rows.Count > 0 Then
                            .Row = ROWCOUNT
                            .Col = 2
                            .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                            .Text = "POSTED VOUCHERS"
                            ROWCOUNT = ROWCOUNT + 1
                            For J = 0 To gdataset.Tables("SLCODE").Rows.Count - 1
                                .Row = ROWCOUNT


                                .Col = 1
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("ACCOUNTcode"))
                                .Col = 2
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("ACCOUNTCODEDesc"))

                                .Col = 3
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLcode"))
                                .Col = 4
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLDesc"))

                                .Col = 5
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERNO")) <> "" Then
                                    .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERNO"))
                                Else
                                    .Text = ""
                                End If


                                .Col = 6
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERDATE")) <> "" Then
                                    .Text = CDate(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERDATE"))
                                Else
                                    .Text = ""
                                End If

                                .Col = 7
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERTYPE")) <> "" Then
                                    .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERTYPE"))
                                Else
                                    .Text = ""
                                End If

                                .Col = 8
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("DRAMOUNT"))


                                .Col = 9
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("CRAMOUNT"))


                                .Col = 10
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("void")) = "Y" Then
                                    .Text = "YES"
                                Else
                                    .Text = "NO"
                                End If

                                MTOTAL = MTOTAL + gdataset.Tables("SLCODE").Rows(J).Item("DRAMOUNT")
                                TTOTAL = TTOTAL + gdataset.Tables("SLCODE").Rows(J).Item("DRAMOUNT")
                                CRMTOTAL = CRMTOTAL + gdataset.Tables("SLCODE").Rows(J).Item("CRAMOUNT")
                                CRTTOTAL = CRTTOTAL + gdataset.Tables("SLCODE").Rows(J).Item("CRAMOUNT")

                                ROWCOUNT = ROWCOUNT + 1
                                .MaxRows = .MaxRows + 1
                            Next J
                            Tallypostingssgrid.MaxRows = Tallypostingssgrid.MaxRows + 1
                            ROWCOUNT = ROWCOUNT + 1
                            Tallypostingssgrid.Row = ROWCOUNT
                            Tallypostingssgrid.Col = 3
                            Tallypostingssgrid.Text = "TOTAL"

                            Tallypostingssgrid.Col = 8
                            Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                            Tallypostingssgrid.Text = MTOTAL

                            Tallypostingssgrid.Col = 9
                            Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                            Tallypostingssgrid.Text = CRMTOTAL

                            Tallypostingssgrid.MaxRows = Tallypostingssgrid.MaxRows + 2
                            ROWCOUNT = ROWCOUNT + 2
                            MTOTAL = 0
                            CRMTOTAL = 0
                        End If

                        SQLSTRING = "SELECT isnull(creditdebit,'') as creditdebit,isnull(void,'') as void,isnull(vouchertype,'') as vouchertype,ISNULL(SUM(ISNULL(AMOUNT,0)),0) AS AMOUNT,ISNULL(VOUCHERNO,'') AS VOUCHERNO,ISNULL(VOUCHERDATE,'') AS VOUCHERDATE,ISNULL(ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(ACCOUNTCODEDESC,'') AS ACCOUNTCODEDESC,ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLDESC,'') AS SLDESC"
                        SQLSTRING = SQLSTRING & " FROM Tally_Journalentry_tmp where isnull(amount,0)<>0 and isnull(void,'')='N' and voucherNO = '" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("VOUCHERNO")) & "' GROUP BY VOUCHERNO,VOUCHERDATE,ACCOUNTCODE,ACCOUNTCODEDESC,SLCODE,SLDESC,vouchertype,void,creditdebit ORDER BY VoucherDate,creditdebit,Void,Vouchertype,slcode"

                        SQLSTRING = "SELECT isnull(void,'') as void,isnull(vouchertype,'') as vouchertype,case when creditdebit='DEBIT' then ISNULL(SUM(ISNULL(AMOUNT,0)),0) else 0 end AS DRAMOUNT,case when creditdebit<>'DEBIT' then ISNULL(SUM(ISNULL(AMOUNT,0)),0) else 0 end AS CRAMOUNT,ISNULL(VOUCHERNO,'') AS VOUCHERNO,ISNULL(VOUCHERDATE,'') AS VOUCHERDATE,ISNULL(ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(ACCOUNTCODEDESC,'') AS ACCOUNTCODEDESC,ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLDESC,'') AS SLDESC"
                        SQLSTRING = SQLSTRING & " FROM Tally_Journalentry_tmp where isnull(amount,0)<>0 and isnull(void,'')<>'Y' and voucherNO = '" & Trim(gdataset.Tables("ACCODE").Rows(I).Item("VOUCHERNO")) & "' GROUP BY VOUCHERNO,VOUCHERDATE,ACCOUNTCODE,ACCOUNTCODEDESC,SLCODE,SLDESC,vouchertype,void,creditdebit ORDER BY VoucherDate,Void,Vouchertype,creditdebit,ACCOUNTCODE,slcode"

                        gconnection.getDataSet(SQLSTRING, "SLCODE")

                        If gdataset.Tables("SLCODE").Rows.Count > 0 Then
                            .Row = ROWCOUNT
                            .Col = 2
                            .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                            .Text = "YET TO BE POST - PENDING VOUCHERS"
                            ROWCOUNT = ROWCOUNT + 1
                            For J = 0 To gdataset.Tables("SLCODE").Rows.Count - 1

                                .Row = ROWCOUNT

                                .Col = 1
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("ACCOUNTcode"))
                                .Col = 2
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("ACCOUNTCODEDesc"))

                                .Col = 3
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLcode"))
                                .Col = 4
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("SLDesc"))

                                .Col = 5
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERNO")) <> "" Then
                                    .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERNO"))
                                Else
                                    .Text = ""
                                End If

                                .Col = 6
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERDATE")) <> "" Then
                                    .Text = CDate(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERDATE"))
                                Else
                                    .Text = ""
                                End If

                                .Col = 7
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERTYPE")) <> "" Then
                                    .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("VOUCHERTYPE"))
                                Else
                                    .Text = ""
                                End If


                                .Col = 8
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("DRAMOUNT"))


                                .Col = 9
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                                .Text = Trim(gdataset.Tables("SLCODE").Rows(J).Item("CRAMOUNT"))


                                .Col = 10
                                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                                If Trim(gdataset.Tables("SLCODE").Rows(J).Item("void")) = "Y" Then
                                    .Text = "YES"
                                Else
                                    .Text = "NO"
                                End If
                                MTOTAL = MTOTAL + gdataset.Tables("SLCODE").Rows(J).Item("DRAMOUNT")
                                TTOTAL = TTOTAL + gdataset.Tables("SLCODE").Rows(J).Item("DRAMOUNT")
                                CRMTOTAL = CRMTOTAL + gdataset.Tables("SLCODE").Rows(J).Item("CRAMOUNT")
                                CRTTOTAL = CRTTOTAL + gdataset.Tables("SLCODE").Rows(J).Item("CRAMOUNT")

                                ROWCOUNT = ROWCOUNT + 1
                                .MaxRows = .MaxRows + 1
                            Next J
                            Tallypostingssgrid.MaxRows = Tallypostingssgrid.MaxRows + 1
                            ROWCOUNT = ROWCOUNT + 1
                            Tallypostingssgrid.Row = ROWCOUNT
                            Tallypostingssgrid.Col = 3
                            Tallypostingssgrid.Text = "TOTAL"

                            Tallypostingssgrid.Col = 8
                            Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                            Tallypostingssgrid.Text = MTOTAL

                            Tallypostingssgrid.Col = 9
                            Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                            Tallypostingssgrid.Text = CRMTOTAL

                            Tallypostingssgrid.MaxRows = Tallypostingssgrid.MaxRows + 2
                            ROWCOUNT = ROWCOUNT + 2
                            MTOTAL = 0
                            CRMTOTAL = 0
                        End If

                    End With
                Next I
            End If
            Tallypostingssgrid.MaxRows = Tallypostingssgrid.MaxRows + 1
            ROWCOUNT = ROWCOUNT + 1
            Tallypostingssgrid.Row = ROWCOUNT
            Tallypostingssgrid.Col = 3
            Tallypostingssgrid.Text = "GRAND TOTAL"

            Tallypostingssgrid.Col = 8
            Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
            Tallypostingssgrid.Text = TTOTAL

            Tallypostingssgrid.Col = 9
            Tallypostingssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
            Tallypostingssgrid.Text = CRTTOTAL

            Tallypostingssgrid.MaxRows = GrdAuditTrail.MaxRows + 1
            ROWCOUNT = ROWCOUNT + 1

            Tallypostingssgrid.Visible = True
            grpPost.Visible = True
            GrdAuditTrail.Visible = False
            GrpPeriod.Visible = False
            grpPost.Visible = True
        Catch ex As Exception
            MessageBox.Show("Tally " & ex.Message.ToString, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
            Grp_TallyPosting.Visible = False
            Tallypostingssgrid.Visible = True
            GrpPeriod.Visible = True
            grpPost.Visible = False
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
                'new import
                '                Call tallyvalidate_kot()
                '                Call tallyvoucherImport()
                If UCase(Mid(MyCompanyName, 1, 6)) = "MADRAS" Then
                    Call TallyExport_OTHERSMGC()
                Else
                    Call TallyExport_OTHERS()
                End If


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
            Call ExportTo(Tallypostingssgrid)
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
            strColumnHead = "|  SLCODE  | SLDESC                        | VOUCHERNO   | VOUCHERDATE   | VOUCHERTYPE   |Amount     |Exist|"
            With Tallypostingssgrid
                If .DataRowCnt > 3 Then
                    For I = 3 To .DataRowCnt
                        .Row = I
                        .Col = 1
                        strCol1 = Mid(Trim(.Text), 1, 10)

                        .Col = 2
                        strCol2 = Mid(Trim(.Text), 1, 30)

                        .Col = 3
                        strCol3 = Mid(Trim(.Text), 1, 10)

                        .Col = 4
                        strCol4 = Mid(Trim(.Text), 1, 11)

                        .Col = 5
                        strCol5 = Mid(Trim(.Text), 1, 20)

                        .Col = 6
                        strCol6 = Mid(Trim(.Text), 1, 12)

                        .Col = 7
                        strCol7 = Mid(Trim(.Text), 1, 3)

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
                            Filewrite.WriteLine(Chr(15) & "|" & Space(91) & strCol6 & "|")
                            intRowCount = intRowCount + 1
                            boolPrintNext = True
                        End If

                        If strCol3.ToUpper = "GRAND TOTAL" Then
                            Filewrite.WriteLine(Chr(15) & "|" & Space(85) & strCol6 & "|")
                            intRowCount = intRowCount + 1
                            boolPrintNext = True
                        End If

                        SSQL = "|" & strCol1 & Space(10 - Len(strCol1))
                        SSQL = SSQL & "|" & strCol2 & Space(30 - Len(strCol2))
                        SSQL = SSQL & "|" & strCol3 & Space(10 - Len(strCol3))
                        SSQL = SSQL & "|" & strCol4 & Space(11 - Len(strCol4))
                        SSQL = SSQL & "|" & strCol5 & Space(20 - Len(strCol5))
                        SSQL = SSQL & "|" & strCol6 & Space(12 - Len(strCol6))
                        SSQL = SSQL & "|" & Space(3 - Len(strCol7)) & strCol7 & "|"

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
    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
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
    Private Sub cmdDosView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDosView.Click
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
            GroupBox1.Top = 1000
            Tallypostingssgrid.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub subSearch()
        Try
            If Len(Trim(txtSearch.Text)) = 0 Then
                MsgBox("Search Text Can't Be Blank....", MsgBoxStyle.OKOnly, Application.ProductName)
                Tallypostingssgrid.Focus()
                Exit Sub
            End If
            Dim i, j, intStringLength, intRow As Int16
            If Tallypostingssgrid.DataRowCnt > 2 Then
                boolSearchResult = False
                If boolSearchNext = False Then
                    intRow = 1
                Else
                    intRow = Me.Tallypostingssgrid.ActiveRow + 1
                End If
                For i = intRow To Tallypostingssgrid.DataRowCnt
                    Me.Tallypostingssgrid.Row = i
                    Me.Tallypostingssgrid.Col = Me.Tallypostingssgrid.ActiveCol
                    intStringLength = Me.Tallypostingssgrid.Text.Length
                    For j = 1 To intStringLength
                        If intStringLength - j >= Len(Trim(txtSearch.Text)) Then
                            If UCase(Mid(Trim(Me.Tallypostingssgrid.Text), j, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                                Me.Tallypostingssgrid.SetActiveCell(Me.Tallypostingssgrid.ActiveCol, i)
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
            Tallypostingssgrid.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error subserach : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Tallypostingssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles Tallypostingssgrid.KeyDownEvent
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

    Private Sub cmdFillExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFillExport.Click
        Try
            Call ExportTo(Tallypostingssgrid)
            'Call TallyExport_GRN()
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

            sqlstring = "SELECT ISNULL(H.BILLAMOUNT,0) AS BILLAMOUNT,ISNULL(H.SLIPNO,'') AS SLIPNO,ISNULL(D.BILLDETAILS,'') AS BILLDETAILS,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME"
            sqlstring = sqlstring & " FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = D.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = H.LOCATIONCODE INNER JOIN ITEMTYPEMASTER AS T ON T.ITEMTYPECODE = D.TAXCODE INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE ISNULL(D.KotStatus,'N')='N' AND ISNULL(H.TallyAddFlag,'')='Y' and BILL_HDR.BILLDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY H.SLIPNO,D.BILLDETAILS,H.MCODE,H.MNAME,H.BILLAMOUNT"
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
                        ssql = "Select * from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'COMPANYVOUCHERS' where $Reference = '" & Funapos(Funamp(Trim(.Item("SLIPNO")))) & "'"
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
                            Filewrite.WriteLine(.Item("SLIPNO") & " - " & .Item("billdetails"))
                            sqlstring = "UPDATE KOT_HDR SET TALLYADDFLAG='N' WHERE SLIPNO='" & .Item("SLIPNO") & "'"
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
                        ssql = "Select * from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'COMPANYVOUCHERS' where $Reference = '" & Funapos(Funamp(Trim(.Item("SLIPNO")))) & "'"
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
                            Filewrite.WriteLine(.Item("SLIPNO") & " - " & .Item("billdetails"))
                            sqlstring = "UPDATE KOT_HDR SET TALLYADDFLAG='N' WHERE SLIPNO='" & .Item("SLIPNO") & "'"
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
                        ssql = "Select * from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'COMPANYVOUCHERS' where $Reference = '" & Funapos(Funamp(Trim(.Item("SLIPNO")))) & "'"
                        vfill.Open(ssql, myconnection)
                        If Not vfill.EOF Then
                            ssql = "Select * from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'COMPANYVOUCHERS' where $_GrossRevenue = '" & Funapos(Funamp(Trim(.Item("BILLAMOUNT")))) & "' and $Reference = '" & Funapos(Funamp(Trim(.Item("SLIPNO")))) & "'"
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
                                Filewrite.WriteLine(.Item("SLIPNO") & " - " & .Item("billdetails"))
                                sqlstring = "UPDATE KOT_HDR SET TALLYADDFLAG='N' WHERE SLIPNO='" & .Item("SLIPNO") & "'"
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
    Private Function tallyvoucherImport()
        Try
            Dim ssql As String
            Dim VoucherNo, VoucherCategory, VoucherType, CashBank, AccountCode, AccountcodeDesc, SLCode, SLDesc, CostCenterCode, CostCenterDesc, CreditDebit, Description, InstrumentType, Instrumentno, BankName, BankPlace As String
            Dim VoucherDate, InstrumentDate As Date
            Dim Amount As Double
            Dim myconnection As New ADODB.Connection
            myconnection.Open(gTallyDsn)
            Dim vfill As New ADODB.Recordset
            ssql = "Select $VoucherNumber,$Date,$VoucherTypeName,$MemCode,$LedgerName,$Narration,$DrCr,$Amount,$PymtType,$ChequeNo,$ChequeDate,$BankName,$BankPlace from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'MCCCOLLECTION' where $Date>='" & Format(dtp_Fromdate.Value, "yyyyMMdd") & "' and $Date<= '" & Format(dtp_Todate.Value, "yyyyMMdd") & "'"

            'ssql = "Select $VoucherNumber,$Date,$VoucherTypeName,$MemCode,$LedgerName,$Narration,$DrCr,$Amount,$PymtType,$ChequeNo,$ChequeDate,$BankName,$BankPlace from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'MCCCOLLECTION'"
            vfill.Open(ssql, myconnection)
            If Not vfill.EOF Then
                Do While Not vfill.EOF
                    VoucherNo = Trim(vfill("$VoucherNumber").Value)
                    If IsDBNull(vfill("$VoucherTypeName").Value) = False Then
                        VoucherCategory = Trim(vfill("$VoucherTypeName").Value)
                    Else
                        VoucherCategory = ""
                    End If
                    If IsDBNull(vfill("$VoucherTypeName").Value) = False Then
                        VoucherType = Trim(vfill("$VoucherTypeName").Value)
                    Else
                        VoucherType = ""
                    End If
                    If IsDBNull(vfill("$PymtType").Value) = False Then
                        CashBank = Trim(vfill("$PymtType").Value)
                    Else
                        CashBank = ""
                    End If

                    If IsDBNull(vfill("$MemCode").Value) = False Then
                        AccountCode = Trim(Replace(vfill("$MemCode").Value, "'", ""))
                    Else
                        AccountCode = ""
                    End If
                    If IsDBNull(vfill("$LedgerName").Value) = False Then
                        AccountcodeDesc = Trim(Replace(vfill("$LedgerName").Value, "'", ""))
                    Else
                        AccountcodeDesc = ""
                    End If
                    If IsDBNull(vfill("$DrCr").Value) = False Then
                        If Trim(vfill("$DrCr").Value) = "Dr" Then
                            CreditDebit = "Debit"
                        Else
                            CreditDebit = "Credit"
                        End If
                    Else
                        CreditDebit = ""
                    End If

                    If IsDBNull(vfill("$Narration").Value) = False Then
                        Description = Trim(Replace(vfill("$Narration").Value, "'", ""))
                    Else
                        Description = ""
                    End If
                    If IsDBNull(vfill("$ChequeDate").Value) = False Then
                        InstrumentDate = CDate(vfill("$ChequeDate").Value)
                    Else
                        InstrumentDate = Now
                    End If
                    InstrumentType = "CHEQUE"
                    If IsDBNull(vfill("$ChequeNo").Value) = False Then
                        Instrumentno = Trim(vfill("$ChequeNo").Value)
                    Else
                        Instrumentno = ""
                    End If
                    If IsDBNull(vfill("$BankName").Value) = False Then
                        BankName = Trim(Replace(vfill("$BankName").Value, "'", ""))
                    Else
                        BankName = ""
                    End If
                    If IsDBNull(vfill("$BankPlace").Value) = False Then
                        BankPlace = Trim(Replace(vfill("$BankPlace").Value, "'", ""))
                    Else
                        BankPlace = ""
                    End If
                    If IsDBNull(vfill("$Date").Value) = False Then
                        VoucherDate = CDate(vfill("$Date").Value)
                    Else
                        VoucherDate = Now
                    End If
                    If IsDBNull(vfill("$Amount").Value) = False Then
                        If vfill("$Amount").Value < 0 Then
                            Amount = Format(vfill("$Amount").Value * -1, "0.00")
                        Else
                            Amount = Format(vfill("$Amount").Value, "0.00")
                        End If
                    Else
                        Amount = 0
                    End If
                    ssql = "INSERT INTO JOURNALENTRY (VoucherNo,voucherdate,VoucherCategory,VoucherType,CashBank,AccountCode,AccountcodeDesc,CreditDebit,Amount,Description,InstrumentDate,InstrumentType,Instrumentno,BankName,BankPlace) VALUES('" & VoucherNo & "','" & Format(VoucherDate, "dd/MMM/yyyy") & "','" & VoucherCategory & "','" & VoucherType & "','" & CashBank & "','" & AccountCode & "','" & AccountcodeDesc & "','" & CreditDebit & "'," & Format(Amount, "0.00") & ",'" & Description & " ','" & Format(InstrumentDate, "dd/MMM/yyyy") & "','" & InstrumentType & "','" & Instrumentno & "','" & BankName & " ','" & BankPlace & "')"
                    'gcommand = New SqlClient.SqlCommand(ssql, gconnection.Myconn)
                    'gcommand.CommandTimeout = 1000000
                    'gconnection.openConnection()
                    'gcommand.ExecuteNonQuery()
                    'gconnection.closeConnection()
                    gconnection.getDataSet(ssql, "TALLY")
                    vfill.MoveNext()
                    If vfill.EOF Then
                        Exit Do
                    End If
                Loop
            End If
            vfill = Nothing
            ssql = "exec cp_journalentry"
            'gcommand = New SqlClient.SqlCommand(ssql, gconnection.Myconn)
            'gconnection.openConnection()
            'gcommand.ExecuteNonQuery()
            'gconnection.closeConnection()

            gconnection.getDataSet(ssql, "TALLY")

            Exit Function
        Catch ex As Exception
            MessageBox.Show("Check The Error tallystockitemerr : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Function TallyExport_OTHERSMGC()
        Dim myconnection As New ADODB.Connection
        Dim ssql As String
        Dim sval1 As Double
        Try

            'myconnection.Open(gTallyDsn)
            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30
            Dim strRequestXML As String
            Dim strstring, sqlstring, LEDGER As String
            Dim sql As String
            Dim otherbillno As String
            Dim otherbool As Boolean
            Dim ROWJ, ROWI, ROWJJ As Integer
            Dim MCODE, MNAME As String
            Dim AMOUNT As Double
            Dim taxapplicable As String = "Y"

            Dim VOUCHERNO As String
            If ComboBox1.Text = "PARTY" Then
                sqlstring = " EXEC POS_POSWISE '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' , '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                gconnection.ExcuteStoreProcedure(sqlstring)
            End If

            Dim I As Integer
            sqlstring = "DROP TABLE TMP_MONTHBILL "
            gconnection.getDataSet(sqlstring, "TALLYMST")
            Dim BILLS As String

            sqlstring = "select * into TMP_MONTHBILL from VIEW_OTHERS_BILL A WHERE A.VOUCHERDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'AND MODULE='" & ComboBox1.Text & "'AND MODULE='INVENTORY' AND VOUCHERNO IN('"
            If Me.CHKBILLS.CheckedItems.Count > 0 Then
                For I = 0 To CHKBILLS.CheckedItems.Count - 1
                    BILLS = ""
                    BILLS = Trim(CHKBILLS.CheckedItems(I))
                    'If SPCODE1 <> "" Then
                    '    SPCODE = Nothing
                    '    SPCODE = Split(SPCODE1, "->")
                    sqlstring = sqlstring & BILLS & "','"
                    ' End If


                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            End If
            gconnection.getDataSet(sqlstring, "TALLYMST")

            sqlstring = "SELECT VOUCHERNO FROM TMP_MONTHBILL WHERE VOUCHERDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY VOUCHERNO ORDER BY VOUCHERNO"
            gconnection.getDataSet(sqlstring, "TALLYMST")
            If gdataset.Tables("TALLYMST").Rows.Count > 0 Then
                For ROWI = 0 To gdataset.Tables("TALLYMST").Rows.Count - 1
                    With gdataset.Tables("TALLYMST").Rows(ROWI)

                        VOUCHERNO = .Item("VOUCHERNO")

                        'for MONTH BILL create


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
                        strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallymonthbill) & "</SVCURRENTCOMPANY>"
                        strRequestXML = strRequestXML & "</STATICVARIABLES>"
                        strRequestXML = strRequestXML & "</REQUESTDESC>"
                        strRequestXML = strRequestXML & "<REQUESTDATA>"
                        strRequestXML = strRequestXML & "<TALLYMESSAGE>"
                        'If ComboBox1.Text = "PARTY" Then
                        'strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='Sales' ACTION='Create'>"

                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='" & Me.ComboBox2.Text & "' ACTION='Create'>"
                        'Else
                        '    strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='Receipt' ACTION='Create'>"
                        'End If

                        If UCase(Me.ComboBox2.Text) = "SALES" Then
                            sqlstring = "SELECT * FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "' ORDER BY CREDITDEBIT DESC"
                        Else
                            sqlstring = "SELECT * FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "' ORDER BY CREDITDEBIT asc"
                        End If
                        gconnection.getDataSet(sqlstring, "TALLYMST1")
                        If gdataset.Tables("TALLYMST1").Rows.Count > 0 Then
                            strRequestXML = strRequestXML & "<DATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</DATE>" ' kotdate
                            strRequestXML = strRequestXML & "<NARRATION>" & Trim(gdataset.Tables("TALLYMST1").Rows(0).Item("DESCRIPTION")) & " </NARRATION>"
                            strRequestXML = strRequestXML & "<VOUCHERTYPENAME>" & Trim(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERTYPE")) & "</VOUCHERTYPENAME>"

                            strRequestXML = strRequestXML & "<VOUCHERNUMBER>" & gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERNO") & "</VOUCHERNUMBER>"
                            If UCase(Me.ComboBox2.Text) <> "SALES" Then
                                sqlstring = "SELECT * FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "' ORDER BY CREDITDEBIT desc"
                                gconnection.getDataSet(sqlstring, "TALLYMST2")
                                If gdataset.Tables("TALLYMST2").Rows.Count > 0 Then
                                    strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST2").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYLEDGERNAME>"
                                    strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST2").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYNAME>"
                                Else
                                    strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYLEDGERNAME>"
                                    strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYNAME>"
                                End If
                            Else
                                strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYLEDGERNAME>"
                                strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYNAME>"

                            End If
                            strRequestXML = strRequestXML & "<EFFECTIVEDATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</EFFECTIVEDATE>" ' kotdate
                            If ComboBox1.Text = "INVENTORY" Then
                                strRequestXML = strRequestXML & "<REFERENCE>" & gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERCATEGORY") & "</REFERENCE>" 'kotno
                                'ElseIf ComboBox1.Text = "DAILY" And Trim(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERtype")) = "PURCHASE" Then
                                '    strRequestXML = strRequestXML & "<REFERENCE>" & gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERCATEGORY") & "</REFERENCE>" 'kotno
                                'ElseIf ComboBox1.Text = "DAILY" And Trim(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERtype")) = "JOURNAL" Then
                                '    strRequestXML = strRequestXML & "<REFERENCE>" & gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERCATEGORY") & "</REFERENCE>" 'kotno
                            Else
                                strRequestXML = strRequestXML & "<REFERENCE>" & gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERNO") & "</REFERENCE>" 'kotno
                            End If

                            For ROWJ = 0 To gdataset.Tables("TALLYMST1").Rows.Count - 1
                                'With gdataset.Tables("TALLYMST1").Rows(ROWJ)
                                '    strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                                '    strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("ACCOUNTCODE"))) & "</LEDGERNAME>"
                                '    strRequestXML = strRequestXML & "<GSTCLASS/>"
                                '    strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                                '    strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                '    strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                '    strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"

                                '    If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                '        strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                '    Else
                                '        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                '    End If 
                                'For ROWJ = 0 To gdataset.Tables("TALLYMST1").Rows.Count - 1
                                With gdataset.Tables("TALLYMST1").Rows(ROWJ)
                                    If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("COSTCENTER") = "" Then
                                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                                        If ComboBox1.Text = "INVENTORY" Then
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") <> "CREDIT" Then
                                                sqlstring = "SELECT ISNULL(ACCOUNTCODEDESC,'')AS ACCOUNTCODE FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "'  AND ACCOUNTCODEDESC LIKE '%Input VAT%' "
                                                gconnection.getDataSet(sqlstring, "TALLYMST222")
                                                If gdataset.Tables("TALLYMST222").Rows.Count > 0 Then
                                                    strRequestXML = strRequestXML & "<TAXCLASSIFICATIONNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST222").Rows(0).Item("ACCOUNTCODE"))) & "</TAXCLASSIFICATIONNAME> "
                                                End If
                                            End If
                                        End If
                                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("ACCOUNTCODE"))) & "</LEDGERNAME>"
                                        strRequestXML = strRequestXML & "<GSTCLASS/>"
                                        If UCase(Me.ComboBox2.Text) = "SALES" Then
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>NO</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                            Else
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                If ComboBox1.Text = "INVENTORY" Then
                                                    If UCase(Mid(Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("ACCOUNTCODE")), 1, 3)) = "VAT" Then
                                                        sqlstring = "SELECT ISNULL(ACCOUNTCODEDESC,'')AS ACCOUNTCODE FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "'  AND ACCOUNTCODEDESC LIKE '%Input VAT%' "
                                                        gconnection.getDataSet(sqlstring, "TALLYMST233")
                                                        If gdataset.Tables("TALLYMST233").Rows.Count > 0 Then
                                                            'sqlstring = "SELECT ISNULL(amount,0)AS amount FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "'  AND creditdebit='debit' order by amount desc "
                                                            'gconnection.getDataSet(sqlstring, "TALLYMST244")
                                                            'If gdataset.Tables("TALLYMST244").Rows.Count > 0 Then
                                                            strRequestXML = strRequestXML & "<VATASSESSABLEVALUE>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("slcode")) & "</VATASSESSABLEVALUE> "
                                                            'End If
                                                        End If
                                                    End If
                                                End If
                                                'If ComboBox1.Text = "PARTY" Then
                                                '    sqlstring = "SELECT * FROM party_receipt_DET WHERE BOOKINGNO='" & VOUCHERNO & "'  and ISNULL(INSTNO,'')<>''"
                                                '    gconnection.getDataSet(sqlstring, "TALLYMST15")
                                                '    If gdataset.Tables("TALLYMST15").Rows.Count > 0 Then
                                                '        strRequestXML = strRequestXML & "<BANKALLOCATIONS.LIST>"
                                                '        strRequestXML = strRequestXML & "<DATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</DATE>"
                                                '        strRequestXML = strRequestXML & "<INSTRUMENTDATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</INSTRUMENTDATE>"
                                                '        strRequestXML = strRequestXML & "<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>"
                                                '        'strRequestXML = strRequestXML & "<PAYMENTFAVOURING>Member Control Account</PAYMENTFAVOURING>"
                                                '        'strRequestXML = strRequestXML & "<UNIQUEREFERENCENUMBER>39jXfdX9i8fcv3v9</UNIQUEREFERENCENUMBER>"
                                                '        strRequestXML = strRequestXML & " <STATUS>No</STATUS>"
                                                '        strRequestXML = strRequestXML & " <AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                '        strRequestXML = strRequestXML & "</BANKALLOCATIONS.LIST>"
                                                '    End If

                                                'End If
                                            End If
                                        Else
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>NO</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>NO</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                If ComboBox1.Text = "MEMBER" Then
                                                    sqlstring = "SELECT ISNULL(INSTRUMENTNO,'111')AS INSTRUMENTNO FROM journalentry WHERE VOUCHERNO='" & VOUCHERNO & "' AND VOUCHERTYPE IN('DBN') AND ACCOUNTCODE<>'BCN' AND ACCOUNTCODEDESC LIKE '%BANK%' "
                                                    gconnection.getDataSet(sqlstring, "TALLYMST15")
                                                    If gdataset.Tables("TALLYMST15").Rows.Count > 0 Then
                                                        strRequestXML = strRequestXML & "<BANKALLOCATIONS.LIST>"
                                                        strRequestXML = strRequestXML & "<DATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</DATE>"
                                                        strRequestXML = strRequestXML & "<INSTRUMENTDATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</INSTRUMENTDATE>"
                                                        strRequestXML = strRequestXML & "<NAME>" & VOUCHERNO & "</NAME>"
                                                        strRequestXML = strRequestXML & "<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>"
                                                        strRequestXML = strRequestXML & "<INSTRUMENTNUMBER> " & gdataset.Tables("TALLYMST15").Rows(0).Item("INSTRUMENTNO") & "</INSTRUMENTNUMBER> "
                                                        'strRequestXML = strRequestXML & "<PAYMENTFAVOURING>Member Control Account</PAYMENTFAVOURING>"
                                                        'strRequestXML = strRequestXML & "<UNIQUEREFERENCENUMBER>39jXfdX9i8fcv3v9</UNIQUEREFERENCENUMBER>"
                                                        strRequestXML = strRequestXML & " <STATUS>No</STATUS>"
                                                        strRequestXML = strRequestXML & "<PAYMENTMODE>Transacted</PAYMENTMODE>"
                                                        strRequestXML = strRequestXML & "<ISCONNECTEDPAYMENT>No</ISCONNECTEDPAYMENT>"
                                                        strRequestXML = strRequestXML & "<ISSPLIT>No</ISSPLIT>"
                                                        strRequestXML = strRequestXML & "<ISCONTRACTUSED>No</ISCONTRACTUSED>"
                                                        strRequestXML = strRequestXML & " <AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                        'strRequestXML = strRequestXML & "CONTRACTDETAILS.LIST /> "
                                                        strRequestXML = strRequestXML & "</BANKALLOCATIONS.LIST>"
                                                        ''''''''''''''''''''''''''''''''''''
                                                        '<DATE>20140801</DATE>  
                                                        ' <INSTRUMENTDATE>20140630</INSTRUMENTDATE>   
                                                        '<NAME>Name : $$MakeUniqueID</NAME>   
                                                        '<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>   
                                                        '<STATUS>No</STATUS>   
                                                        '<PAYMENTMODE>Transacted</PAYMENTMODE>   
                                                        '<ISCONNECTEDPAYMENT>No</ISCONNECTEDPAYMENT>   
                                                        '<ISSPLIT>No</ISSPLIT>   
                                                        '<ISCONTRACTUSED>No</ISCONTRACTUSED>   
                                                        '<AMOUNT>-12000.00</AMOUNT>   
                                                        '<CONTRACTDETAILS.LIST /> 
                                                        '<BANKALLOCATIONS.LIST>
                                                        '        <DATE>20101201</DATE>
                                                        '        <INSTRUMENTDATE>20101201</INSTRUMENTDATE>
                                                        '        <BANKERSDATE>20101204</BANKERSDATE> ;reconcil date
                                                        '        <NAME>9972528c-0b71-4a81-a3a7-8f9478d50261</NAME> ; unique name
                                                        '        <TRANSACTIONTYPE>Others</TRANSACTIONTYPE>
                                                        '        <PAYMENTFAVOURING>Office Rent</PAYMENTFAVOURING>
                                                        '        <STATUS>No</STATUS>
                                                        '        <PAYMENTMODE>Transacted</PAYMENTMODE>
                                                        '        <BANKPARTYNAME>Office Rent</BANKPARTYNAME>
                                                        '        <CHEQUEPRINTED> 1</CHEQUEPRINTED>
                                                        '        <AMOUNT>2500.00</AMOUNT>
                                                        '       </BANKALLOCATIONS.LIST>

                                                        'Name	: $$MakeUniqueID

                                                        ''''''''''''''''''''''''''''''''
                                                    End If

                                                End If
                                            Else
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                If ComboBox1.Text = "MEMBER" Then
                                                    sqlstring = "SELECT ISNULL(INSTRUMENTNO,'')AS INSTRUMENTNO FROM journalentry WHERE VOUCHERNO='" & VOUCHERNO & "' and cashbank='BANK' and creditdebit='DEBIT' UNION ALL SELECT ISNULL(INSTRUMENTNO,'')AS INSTRUMENTNO FROM journalentry WHERE VOUCHERNO='" & VOUCHERNO & "' AND VOUCHERTYPE IN('CRN','DBN') AND ACCOUNTCODE<>'BCN' AND ACCOUNTCODEDESC LIKE '%BANK%' "
                                                    gconnection.getDataSet(sqlstring, "TALLYMST15")
                                                    If gdataset.Tables("TALLYMST15").Rows.Count > 0 Then
                                                        strRequestXML = strRequestXML & "<BANKALLOCATIONS.LIST>"
                                                        strRequestXML = strRequestXML & "<DATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</DATE>"
                                                        strRequestXML = strRequestXML & "<INSTRUMENTDATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</INSTRUMENTDATE>"
                                                        strRequestXML = strRequestXML & "<NAME>" & VOUCHERNO & "</NAME>"
                                                        strRequestXML = strRequestXML & "<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>"
                                                        strRequestXML = strRequestXML & "<INSTRUMENTNUMBER> " & gdataset.Tables("TALLYMST15").Rows(0).Item("INSTRUMENTNO") & "</INSTRUMENTNUMBER> "
                                                        'strRequestXML = strRequestXML & "<PAYMENTFAVOURING>Member Control Account</PAYMENTFAVOURING>"
                                                        'strRequestXML = strRequestXML & "<UNIQUEREFERENCENUMBER>39jXfdX9i8fcv3v9</UNIQUEREFERENCENUMBER>"
                                                        strRequestXML = strRequestXML & " <STATUS>No</STATUS>"
                                                        strRequestXML = strRequestXML & "<PAYMENTMODE>Transacted</PAYMENTMODE>"
                                                        strRequestXML = strRequestXML & "<ISCONNECTEDPAYMENT>No</ISCONNECTEDPAYMENT>"
                                                        strRequestXML = strRequestXML & "<ISSPLIT>No</ISSPLIT>"
                                                        strRequestXML = strRequestXML & "<ISCONTRACTUSED>No</ISCONTRACTUSED>"
                                                        strRequestXML = strRequestXML & " <AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                        'strRequestXML = strRequestXML & "CONTRACTDETAILS.LIST /> "
                                                        strRequestXML = strRequestXML & "</BANKALLOCATIONS.LIST>"
                                                        ''''''''''''''''''''''''''''''''''''
                                                        '<DATE>20140801</DATE>  
                                                        ' <INSTRUMENTDATE>20140630</INSTRUMENTDATE>   
                                                        '<NAME>Name : $$MakeUniqueID</NAME>   
                                                        '<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>   
                                                        '<STATUS>No</STATUS>   
                                                        '<PAYMENTMODE>Transacted</PAYMENTMODE>   
                                                        '<ISCONNECTEDPAYMENT>No</ISCONNECTEDPAYMENT>   
                                                        '<ISSPLIT>No</ISSPLIT>   
                                                        '<ISCONTRACTUSED>No</ISCONTRACTUSED>   
                                                        '<AMOUNT>-12000.00</AMOUNT>   
                                                        '<CONTRACTDETAILS.LIST /> 
                                                        '<BANKALLOCATIONS.LIST>
                                                        '        <DATE>20101201</DATE>
                                                        '        <INSTRUMENTDATE>20101201</INSTRUMENTDATE>
                                                        '        <BANKERSDATE>20101204</BANKERSDATE> ;reconcil date
                                                        '        <NAME>9972528c-0b71-4a81-a3a7-8f9478d50261</NAME> ; unique name
                                                        '        <TRANSACTIONTYPE>Others</TRANSACTIONTYPE>
                                                        '        <PAYMENTFAVOURING>Office Rent</PAYMENTFAVOURING>
                                                        '        <STATUS>No</STATUS>
                                                        '        <PAYMENTMODE>Transacted</PAYMENTMODE>
                                                        '        <BANKPARTYNAME>Office Rent</BANKPARTYNAME>
                                                        '        <CHEQUEPRINTED> 1</CHEQUEPRINTED>
                                                        '        <AMOUNT>2500.00</AMOUNT>
                                                        '       </BANKALLOCATIONS.LIST>

                                                        'Name	: $$MakeUniqueID

                                                        ''''''''''''''''''''''''''''''''
                                                    End If

                                                End If
                                                'If ComboBox1.Text = "PARTY" Then
                                                '    sqlstring = "SELECT * FROM party_receipt_DET WHERE BOOKINGNO='" & VOUCHERNO & "'  and ISNULL(INSTNO,'')<>''"
                                                '    gconnection.getDataSet(sqlstring, "TALLYMST15")
                                                '    If gdataset.Tables("TALLYMST15").Rows.Count > 0 Then
                                                '        strRequestXML = strRequestXML & "<BANKALLOCATIONS.LIST>"
                                                '        strRequestXML = strRequestXML & "<DATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</DATE>"
                                                '        strRequestXML = strRequestXML & "<INSTRUMENTDATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</INSTRUMENTDATE>"
                                                '        strRequestXML = strRequestXML & "<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>"
                                                '        'strRequestXML = strRequestXML & "<PAYMENTFAVOURING>Member Control Account</PAYMENTFAVOURING>"
                                                '        'strRequestXML = strRequestXML & "<UNIQUEREFERENCENUMBER>39jXfdX9i8fcv3v9</UNIQUEREFERENCENUMBER>"
                                                '        strRequestXML = strRequestXML & " <STATUS>No</STATUS>"
                                                '        strRequestXML = strRequestXML & " <AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                '        strRequestXML = strRequestXML & "</BANKALLOCATIONS.LIST>"
                                                '    End If

                                                'End If

                                            End If
                                        End If
                                    Else
                                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("ACCOUNTCODE"))) & "</LEDGERNAME>"
                                        strRequestXML = strRequestXML & "<GSTCLASS/>"

                                        If UCase(Me.ComboBox2.Text) = "SALES" Then
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>NO</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                            Else
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                            End If
                                        Else
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>NO</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                            Else
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                            End If
                                        End If
                                        strRequestXML = strRequestXML & "<CATEGORYALLOCATIONS.LIST>" + Environment.NewLine
                                        strRequestXML = strRequestXML & "<CATEGORY>" & Funapos(Funamp(Trim(.Item("COSTCENTECODE")))) & "</CATEGORY>" + Environment.NewLine
                                        strRequestXML = strRequestXML & "<COSTCENTREALLOCATIONS.LIST>" + Environment.NewLine
                                        strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("COSTCENTER")))) & "</NAME>" + Environment.NewLine 'CLARIFICATION REQUIRED
                                        'strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT"), "0.00")) & "</AMOUNT>" + Environment.NewLine 'taxamount
                                        If UCase(Me.ComboBox2.Text) = "SALES" Then
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT"), "0.00")) & "</AMOUNT>" + Environment.NewLine 'taxamount
                                            Else
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(Format(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT"), "0.00")) & "</AMOUNT>" + Environment.NewLine 'taxamount
                                            End If
                                        Else
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT"), "0.00")) & "</AMOUNT>" + Environment.NewLine 'taxamount
                                            Else
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(Format(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT"), "0.00")) & "</AMOUNT>" + Environment.NewLine 'taxamount
                                            End If
                                        End If
                                        strRequestXML = strRequestXML & "</COSTCENTREALLOCATIONS.LIST>" + Environment.NewLine
                                        strRequestXML = strRequestXML & "</CATEGORYALLOCATIONS.LIST>" + Environment.NewLine
                                    End If


                                    'strRequestXML = strRequestXML & "<BILLALLOCATIONS.LIST>"
                                    'strRequestXML = strRequestXML & "<NAME>BILL</NAME>"
                                    'strRequestXML = strRequestXML & "<BILLCREDITPERIOD>45 Days</BILLCREDITPERIOD>"
                                    'strRequestXML = strRequestXML & "<BILLTYPE>New Ref</BILLTYPE>"

                                    'If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                    '    strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                    'Else
                                    '    strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"

                                    'End If
                                    'strRequestXML = strRequestXML & "</BILLALLOCATIONS.LIST>"
                                    strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"

                                End With
                            Next
                        End If



                        strRequestXML = strRequestXML & "</VOUCHER>"
                        strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                        strRequestXML = strRequestXML & "</REQUESTDATA>"
                        strRequestXML = strRequestXML & "</IMPORTDATA>"
                        strRequestXML = strRequestXML & "</BODY>"
                        strRequestXML = strRequestXML & "</ENVELOPE>"
                        SerHttp.open("POST", gTallyOdbc & gTallyPort)
                        SerHttp.send(strRequestXML)

                        'for tally error
                        'new for tally xml error
                        'begin

                        Dim resstr, errorstr, j
                        Dim errmsg As Boolean = False
                        resstr = SerHttp.responseText
                        ' MsgBox(resstr)
                        xmlDom.loadXML(resstr)

                    End With
                Next

                Dim insert(1) As String

                'ssql = " Update KOT_HDR  set postingstatus ='Y' where CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) Between '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                'gconnection.dataOperation1(2, ssql, "Billhdr")

                'ssql = " Update BILL_HDR  set ACCOUNTFLAG ='Y' where CAST(CONVERT(VARCHAR(11),BILLDATE,6) AS DATETIME) Between '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                'gconnection.dataOperation1(2, ssql, "Billhdr")

                'ssql = "Cp_Journalentry '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "','" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                'gconnection.dataOperation1(2, ssql, "Billhdr")

                ssql = "INSERT INTO TallY_JournalEntry (VoucherNo,voucherdate,VoucherCategory,VoucherType,CashBank,SLCODE,SLDESC,CreditDebit,Amount,Description,InstrumentDate,InstrumentType,Instrumentno,BankName,BankPlace) (select VoucherNo,voucherdate,VoucherCategory,VoucherType,CashBank,SLCODE,SLDESC,CreditDebit,Amount,Description,InstrumentDate,InstrumentType,Instrumentno,BankName,BankPlace from Tally_JournalEntry_Tmp where isnull(void,'')='N')"
                insert(0) = ssql

                gconnection.MoreTransold(insert)

                '                MsgBox("Successcully Created", vbInformation, "Month Bill Posted to Accounts Tally")

                GrpPeriod.Visible = True

            Else
                MsgBox("There is no record(s) to Post.......", MsgBoxStyle.OKOnly, "Month Bill Posted to Accounts Tally")
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallyvalidate : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function

    Private Function TallyExport_OTHERS()
        Dim myconnection As New ADODB.Connection
        Dim ssql As String
        Dim sval1 As Double
        Try

            'myconnection.Open(gTallyDsn)
            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30
            Dim strRequestXML As String
            Dim strstring, sqlstring, LEDGER As String
            Dim sql As String
            Dim otherbillno As String
            Dim otherbool As Boolean
            Dim ROWJ, ROWI, ROWJJ As Integer
            Dim MCODE, MNAME As String
            Dim AMOUNT As Double
            Dim taxapplicable As String = "Y"

            Dim VOUCHERNO As String
            Dim I As Integer
            sqlstring = "DROP TABLE TMP_MONTHBILL "
            gconnection.getDataSet(sqlstring, "TALLYMST")
            Dim BILLS As String
            sqlstring = "select * into TMP_MONTHBILL from VIEW_OTHERS_BILL A WHERE A.VOUCHERDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'AND MODULE='" & ComboBox1.Text & "'AND MODULE='INVENTORY' AND VOUCHERNO IN('"
            If Me.CHKBILLS.CheckedItems.Count > 0 Then
                For I = 0 To CHKBILLS.CheckedItems.Count - 1
                    BILLS = ""
                    BILLS = Trim(CHKBILLS.CheckedItems(I))
                    'If SPCODE1 <> "" Then
                    '    SPCODE = Nothing
                    '    SPCODE = Split(SPCODE1, "->")
                    sqlstring = sqlstring & BILLS & "','"
                    ' End If


                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            End If
            gconnection.getDataSet(sqlstring, "TALLYMST")

            sqlstring = "SELECT VOUCHERNO FROM TMP_MONTHBILL WHERE VOUCHERDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' GROUP BY VOUCHERNO ORDER BY VOUCHERNO"
            gconnection.getDataSet(sqlstring, "TALLYMST")
            If gdataset.Tables("TALLYMST").Rows.Count > 0 Then
                For ROWI = 0 To gdataset.Tables("TALLYMST").Rows.Count - 1
                    With gdataset.Tables("TALLYMST").Rows(ROWI)

                        VOUCHERNO = .Item("VOUCHERNO")

                        'for MONTH BILL create


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
                        strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallymonthbill) & "</SVCURRENTCOMPANY>"
                        strRequestXML = strRequestXML & "</STATICVARIABLES>"
                        strRequestXML = strRequestXML & "</REQUESTDESC>"
                        strRequestXML = strRequestXML & "<REQUESTDATA>"
                        strRequestXML = strRequestXML & "<TALLYMESSAGE>"
                        'If ComboBox1.Text = "PARTY" Then
                        'strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='Sales' ACTION='Create'>"

                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='" & Me.ComboBox2.Text & "' ACTION='Create'>"
                        'Else
                        '    strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='Receipt' ACTION='Create'>"
                        'End If

                        If UCase(Me.ComboBox2.Text) = "SALES" Then
                            sqlstring = "SELECT * FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "' ORDER BY CREDITDEBIT DESC"
                        Else
                            sqlstring = "SELECT * FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "' ORDER BY CREDITDEBIT asc"
                        End If
                        gconnection.getDataSet(sqlstring, "TALLYMST1")
                        If gdataset.Tables("TALLYMST1").Rows.Count > 0 Then
                            strRequestXML = strRequestXML & "<DATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</DATE>" ' kotdate
                            strRequestXML = strRequestXML & "<NARRATION>" & Trim(gdataset.Tables("TALLYMST1").Rows(0).Item("DESCRIPTION")) & " </NARRATION>"
                            strRequestXML = strRequestXML & "<VOUCHERTYPENAME>" & Trim(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERTYPE")) & "</VOUCHERTYPENAME>"

                            strRequestXML = strRequestXML & "<VOUCHERNUMBER>" & gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERNO") & "</VOUCHERNUMBER>"
                            If UCase(Me.ComboBox2.Text) <> "SALES" Then
                                sqlstring = "SELECT * FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "' ORDER BY CREDITDEBIT desc"
                                gconnection.getDataSet(sqlstring, "TALLYMST2")
                                If gdataset.Tables("TALLYMST2").Rows.Count > 0 Then
                                    strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST2").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYLEDGERNAME>"
                                    strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST2").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYNAME>"
                                Else
                                    strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYLEDGERNAME>"
                                    strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYNAME>"
                                End If
                            Else
                                strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYLEDGERNAME>"
                                strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(0).Item("ACCOUNTCODE"))) & "</PARTYNAME>"

                            End If
                            strRequestXML = strRequestXML & "<EFFECTIVEDATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</EFFECTIVEDATE>" ' kotdate
                            If ComboBox1.Text = "INVENTORY" Then
                                strRequestXML = strRequestXML & "<REFERENCE>" & gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERCATEGORY") & "</REFERENCE>" 'kotno
                                'ElseIf ComboBox1.Text = "DAILY" And Trim(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERtype")) = "PURCHASE" Then
                                '    strRequestXML = strRequestXML & "<REFERENCE>" & gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERCATEGORY") & "</REFERENCE>" 'kotno
                                'ElseIf ComboBox1.Text = "DAILY" And Trim(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERtype")) = "JOURNAL" Then
                                '    strRequestXML = strRequestXML & "<REFERENCE>" & gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERCATEGORY") & "</REFERENCE>" 'kotno
                            Else
                                strRequestXML = strRequestXML & "<REFERENCE>" & gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERNO") & "</REFERENCE>" 'kotno
                            End If

                            For ROWJ = 0 To gdataset.Tables("TALLYMST1").Rows.Count - 1
                                'With gdataset.Tables("TALLYMST1").Rows(ROWJ)
                                '    strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                                '    strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("ACCOUNTCODE"))) & "</LEDGERNAME>"
                                '    strRequestXML = strRequestXML & "<GSTCLASS/>"
                                '    strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                                '    strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                '    strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                '    strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"

                                '    If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                '        strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                '    Else
                                '        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                '    End If 
                                'For ROWJ = 0 To gdataset.Tables("TALLYMST1").Rows.Count - 1
                                With gdataset.Tables("TALLYMST1").Rows(ROWJ)
                                    If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("COSTCENTER") = "" Then
                                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                                        'If ComboBox1.Text = "INVENTORY" Then
                                        '    If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") <> "CREDIT" Then
                                        '        sqlstring = "SELECT ISNULL(ACCOUNTCODEDESC,'')AS ACCOUNTCODE FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "'  AND ACCOUNTCODEDESC LIKE '%Input VAT%' "
                                        '        gconnection.getDataSet(sqlstring, "TALLYMST222")
                                        '        If gdataset.Tables("TALLYMST222").Rows.Count > 0 Then
                                        '            strRequestXML = strRequestXML & "<TAXCLASSIFICATIONNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST222").Rows(0).Item("ACCOUNTCODE"))) & "</TAXCLASSIFICATIONNAME> "
                                        '        End If
                                        '    End If
                                        'End If
                                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("ACCOUNTCODE"))) & "</LEDGERNAME>"
                                        strRequestXML = strRequestXML & "<GSTCLASS/>"
                                        If UCase(Me.ComboBox2.Text) = "SALES" Then
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>NO</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                            Else
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                'If ComboBox1.Text = "INVENTORY" Then
                                                '    If UCase(Mid(Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("ACCOUNTCODE")), 1, 3)) = "VAT" Then
                                                '        sqlstring = "SELECT ISNULL(ACCOUNTCODEDESC,'')AS ACCOUNTCODE FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "'  AND ACCOUNTCODEDESC LIKE '%Input VAT%' "
                                                '        gconnection.getDataSet(sqlstring, "TALLYMST233")
                                                '        If gdataset.Tables("TALLYMST233").Rows.Count > 0 Then
                                                '            'sqlstring = "SELECT ISNULL(amount,0)AS amount FROM TMP_MONTHBILL WHERE VOUCHERNO='" & VOUCHERNO & "'  AND creditdebit='debit' order by amount desc "
                                                '            'gconnection.getDataSet(sqlstring, "TALLYMST244")
                                                '            'If gdataset.Tables("TALLYMST244").Rows.Count > 0 Then
                                                '            strRequestXML = strRequestXML & "<VATASSESSABLEVALUE>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("slcode")) & "</VATASSESSABLEVALUE> "
                                                '            'End If
                                                '        End If
                                                '    End If
                                                'End If
                                                'If ComboBox1.Text = "PARTY" Then
                                                '    sqlstring = "SELECT * FROM party_receipt_DET WHERE BOOKINGNO='" & VOUCHERNO & "'  and ISNULL(INSTNO,'')<>''"
                                                '    gconnection.getDataSet(sqlstring, "TALLYMST15")
                                                '    If gdataset.Tables("TALLYMST15").Rows.Count > 0 Then
                                                '        strRequestXML = strRequestXML & "<BANKALLOCATIONS.LIST>"
                                                '        strRequestXML = strRequestXML & "<DATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</DATE>"
                                                '        strRequestXML = strRequestXML & "<INSTRUMENTDATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</INSTRUMENTDATE>"
                                                '        strRequestXML = strRequestXML & "<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>"
                                                '        'strRequestXML = strRequestXML & "<PAYMENTFAVOURING>Member Control Account</PAYMENTFAVOURING>"
                                                '        'strRequestXML = strRequestXML & "<UNIQUEREFERENCENUMBER>39jXfdX9i8fcv3v9</UNIQUEREFERENCENUMBER>"
                                                '        strRequestXML = strRequestXML & " <STATUS>No</STATUS>"
                                                '        strRequestXML = strRequestXML & " <AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                '        strRequestXML = strRequestXML & "</BANKALLOCATIONS.LIST>"
                                                '    End If

                                                'End If
                                            End If
                                        Else
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>NO</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>NO</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                If ComboBox1.Text = "MEMBER" Then
                                                    sqlstring = "SELECT ISNULL(INSTRUMENTNO,'111')AS INSTRUMENTNO FROM journalentry WHERE VOUCHERNO='" & VOUCHERNO & "' AND VOUCHERTYPE IN('DBN') AND ACCOUNTCODE<>'BCN' AND ACCOUNTCODEDESC LIKE '%BANK%' "
                                                    gconnection.getDataSet(sqlstring, "TALLYMST15")
                                                    If gdataset.Tables("TALLYMST15").Rows.Count > 0 Then
                                                        strRequestXML = strRequestXML & "<BANKALLOCATIONS.LIST>"
                                                        strRequestXML = strRequestXML & "<DATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</DATE>"
                                                        strRequestXML = strRequestXML & "<INSTRUMENTDATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</INSTRUMENTDATE>"
                                                        strRequestXML = strRequestXML & "<NAME>" & VOUCHERNO & "</NAME>"
                                                        strRequestXML = strRequestXML & "<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>"
                                                        strRequestXML = strRequestXML & "<INSTRUMENTNUMBER> " & gdataset.Tables("TALLYMST15").Rows(0).Item("INSTRUMENTNO") & "</INSTRUMENTNUMBER> "
                                                        'strRequestXML = strRequestXML & "<PAYMENTFAVOURING>Member Control Account</PAYMENTFAVOURING>"
                                                        'strRequestXML = strRequestXML & "<UNIQUEREFERENCENUMBER>39jXfdX9i8fcv3v9</UNIQUEREFERENCENUMBER>"
                                                        strRequestXML = strRequestXML & " <STATUS>No</STATUS>"
                                                        strRequestXML = strRequestXML & "<PAYMENTMODE>Transacted</PAYMENTMODE>"
                                                        strRequestXML = strRequestXML & "<ISCONNECTEDPAYMENT>No</ISCONNECTEDPAYMENT>"
                                                        strRequestXML = strRequestXML & "<ISSPLIT>No</ISSPLIT>"
                                                        strRequestXML = strRequestXML & "<ISCONTRACTUSED>No</ISCONTRACTUSED>"
                                                        strRequestXML = strRequestXML & " <AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                        'strRequestXML = strRequestXML & "CONTRACTDETAILS.LIST /> "
                                                        strRequestXML = strRequestXML & "</BANKALLOCATIONS.LIST>"
                                                        ''''''''''''''''''''''''''''''''''''
                                                        '<DATE>20140801</DATE>  
                                                        ' <INSTRUMENTDATE>20140630</INSTRUMENTDATE>   
                                                        '<NAME>Name : $$MakeUniqueID</NAME>   
                                                        '<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>   
                                                        '<STATUS>No</STATUS>   
                                                        '<PAYMENTMODE>Transacted</PAYMENTMODE>   
                                                        '<ISCONNECTEDPAYMENT>No</ISCONNECTEDPAYMENT>   
                                                        '<ISSPLIT>No</ISSPLIT>   
                                                        '<ISCONTRACTUSED>No</ISCONTRACTUSED>   
                                                        '<AMOUNT>-12000.00</AMOUNT>   
                                                        '<CONTRACTDETAILS.LIST /> 
                                                        '<BANKALLOCATIONS.LIST>
                                                        '        <DATE>20101201</DATE>
                                                        '        <INSTRUMENTDATE>20101201</INSTRUMENTDATE>
                                                        '        <BANKERSDATE>20101204</BANKERSDATE> ;reconcil date
                                                        '        <NAME>9972528c-0b71-4a81-a3a7-8f9478d50261</NAME> ; unique name
                                                        '        <TRANSACTIONTYPE>Others</TRANSACTIONTYPE>
                                                        '        <PAYMENTFAVOURING>Office Rent</PAYMENTFAVOURING>
                                                        '        <STATUS>No</STATUS>
                                                        '        <PAYMENTMODE>Transacted</PAYMENTMODE>
                                                        '        <BANKPARTYNAME>Office Rent</BANKPARTYNAME>
                                                        '        <CHEQUEPRINTED> 1</CHEQUEPRINTED>
                                                        '        <AMOUNT>2500.00</AMOUNT>
                                                        '       </BANKALLOCATIONS.LIST>

                                                        'Name	: $$MakeUniqueID

                                                        ''''''''''''''''''''''''''''''''
                                                    End If

                                                End If
                                            Else
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                If ComboBox1.Text = "MEMBER" Then
                                                    sqlstring = "SELECT ISNULL(INSTRUMENTNO,'')AS INSTRUMENTNO FROM journalentry WHERE VOUCHERNO='" & VOUCHERNO & "' and cashbank='BANK' and creditdebit='DEBIT' UNION ALL SELECT ISNULL(INSTRUMENTNO,'')AS INSTRUMENTNO FROM journalentry WHERE VOUCHERNO='" & VOUCHERNO & "' AND VOUCHERTYPE IN('CRN','DBN') AND ACCOUNTCODE<>'BCN' AND ACCOUNTCODEDESC LIKE '%BANK%' "
                                                    gconnection.getDataSet(sqlstring, "TALLYMST15")
                                                    If gdataset.Tables("TALLYMST15").Rows.Count > 0 Then
                                                        strRequestXML = strRequestXML & "<BANKALLOCATIONS.LIST>"
                                                        strRequestXML = strRequestXML & "<DATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</DATE>"
                                                        strRequestXML = strRequestXML & "<INSTRUMENTDATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</INSTRUMENTDATE>"
                                                        strRequestXML = strRequestXML & "<NAME>" & VOUCHERNO & "</NAME>"
                                                        strRequestXML = strRequestXML & "<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>"
                                                        strRequestXML = strRequestXML & "<INSTRUMENTNUMBER> " & gdataset.Tables("TALLYMST15").Rows(0).Item("INSTRUMENTNO") & "</INSTRUMENTNUMBER> "
                                                        'strRequestXML = strRequestXML & "<PAYMENTFAVOURING>Member Control Account</PAYMENTFAVOURING>"
                                                        'strRequestXML = strRequestXML & "<UNIQUEREFERENCENUMBER>39jXfdX9i8fcv3v9</UNIQUEREFERENCENUMBER>"
                                                        strRequestXML = strRequestXML & " <STATUS>No</STATUS>"
                                                        strRequestXML = strRequestXML & "<PAYMENTMODE>Transacted</PAYMENTMODE>"
                                                        strRequestXML = strRequestXML & "<ISCONNECTEDPAYMENT>No</ISCONNECTEDPAYMENT>"
                                                        strRequestXML = strRequestXML & "<ISSPLIT>No</ISSPLIT>"
                                                        strRequestXML = strRequestXML & "<ISCONTRACTUSED>No</ISCONTRACTUSED>"
                                                        strRequestXML = strRequestXML & " <AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                        'strRequestXML = strRequestXML & "CONTRACTDETAILS.LIST /> "
                                                        strRequestXML = strRequestXML & "</BANKALLOCATIONS.LIST>"
                                                        ''''''''''''''''''''''''''''''''''''
                                                        '<DATE>20140801</DATE>  
                                                        ' <INSTRUMENTDATE>20140630</INSTRUMENTDATE>   
                                                        '<NAME>Name : $$MakeUniqueID</NAME>   
                                                        '<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>   
                                                        '<STATUS>No</STATUS>   
                                                        '<PAYMENTMODE>Transacted</PAYMENTMODE>   
                                                        '<ISCONNECTEDPAYMENT>No</ISCONNECTEDPAYMENT>   
                                                        '<ISSPLIT>No</ISSPLIT>   
                                                        '<ISCONTRACTUSED>No</ISCONTRACTUSED>   
                                                        '<AMOUNT>-12000.00</AMOUNT>   
                                                        '<CONTRACTDETAILS.LIST /> 
                                                        '<BANKALLOCATIONS.LIST>
                                                        '        <DATE>20101201</DATE>
                                                        '        <INSTRUMENTDATE>20101201</INSTRUMENTDATE>
                                                        '        <BANKERSDATE>20101204</BANKERSDATE> ;reconcil date
                                                        '        <NAME>9972528c-0b71-4a81-a3a7-8f9478d50261</NAME> ; unique name
                                                        '        <TRANSACTIONTYPE>Others</TRANSACTIONTYPE>
                                                        '        <PAYMENTFAVOURING>Office Rent</PAYMENTFAVOURING>
                                                        '        <STATUS>No</STATUS>
                                                        '        <PAYMENTMODE>Transacted</PAYMENTMODE>
                                                        '        <BANKPARTYNAME>Office Rent</BANKPARTYNAME>
                                                        '        <CHEQUEPRINTED> 1</CHEQUEPRINTED>
                                                        '        <AMOUNT>2500.00</AMOUNT>
                                                        '       </BANKALLOCATIONS.LIST>

                                                        'Name	: $$MakeUniqueID

                                                        ''''''''''''''''''''''''''''''''
                                                    End If

                                                End If
                                                'If ComboBox1.Text = "PARTY" Then
                                                '    sqlstring = "SELECT * FROM party_receipt_DET WHERE BOOKINGNO='" & VOUCHERNO & "'  and ISNULL(INSTNO,'')<>''"
                                                '    gconnection.getDataSet(sqlstring, "TALLYMST15")
                                                '    If gdataset.Tables("TALLYMST15").Rows.Count > 0 Then
                                                '        strRequestXML = strRequestXML & "<BANKALLOCATIONS.LIST>"
                                                '        strRequestXML = strRequestXML & "<DATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</DATE>"
                                                '        strRequestXML = strRequestXML & "<INSTRUMENTDATE>" & Format(gdataset.Tables("TALLYMST1").Rows(0).Item("VOUCHERDATE"), "yyyyMMdd") & "</INSTRUMENTDATE>"
                                                '        strRequestXML = strRequestXML & "<TRANSACTIONTYPE>Cheque/DD</TRANSACTIONTYPE>"
                                                '        'strRequestXML = strRequestXML & "<PAYMENTFAVOURING>Member Control Account</PAYMENTFAVOURING>"
                                                '        'strRequestXML = strRequestXML & "<UNIQUEREFERENCENUMBER>39jXfdX9i8fcv3v9</UNIQUEREFERENCENUMBER>"
                                                '        strRequestXML = strRequestXML & " <STATUS>No</STATUS>"
                                                '        strRequestXML = strRequestXML & " <AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                                '        strRequestXML = strRequestXML & "</BANKALLOCATIONS.LIST>"
                                                '    End If

                                                'End If

                                            End If
                                        End If
                                    Else
                                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("ACCOUNTCODE"))) & "</LEDGERNAME>"
                                        strRequestXML = strRequestXML & "<GSTCLASS/>"

                                        If UCase(Me.ComboBox2.Text) = "SALES" Then
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>NO</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                            Else
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                            End If
                                        Else
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>NO</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                            Else
                                                strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                                                strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                                                strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                                                strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                            End If
                                        End If
                                        strRequestXML = strRequestXML & "<CATEGORYALLOCATIONS.LIST>" + Environment.NewLine
                                        strRequestXML = strRequestXML & "<CATEGORY>" & Funapos(Funamp(Trim(.Item("COSTCENTER")))) & "</CATEGORY>" + Environment.NewLine
                                        strRequestXML = strRequestXML & "<COSTCENTREALLOCATIONS.LIST>" + Environment.NewLine
                                        strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(.Item("COSTCENTER")))) & "</NAME>" + Environment.NewLine 'CLARIFICATION REQUIRED
                                        'strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT"), "0.00")) & "</AMOUNT>" + Environment.NewLine 'taxamount
                                        If UCase(Me.ComboBox2.Text) = "SALES" Then
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT"), "0.00")) & "</AMOUNT>" + Environment.NewLine 'taxamount
                                            Else
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(Format(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT"), "0.00")) & "</AMOUNT>" + Environment.NewLine 'taxamount
                                            End If
                                        Else
                                            If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                                strRequestXML = strRequestXML & "<AMOUNT>" & Trim(Format(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT"), "0.00")) & "</AMOUNT>" + Environment.NewLine 'taxamount
                                            Else
                                                strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(Format(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT"), "0.00")) & "</AMOUNT>" + Environment.NewLine 'taxamount
                                            End If
                                        End If
                                        strRequestXML = strRequestXML & "</COSTCENTREALLOCATIONS.LIST>" + Environment.NewLine
                                        strRequestXML = strRequestXML & "</CATEGORYALLOCATIONS.LIST>" + Environment.NewLine
                                    End If


                                    'strRequestXML = strRequestXML & "<BILLALLOCATIONS.LIST>"
                                    'strRequestXML = strRequestXML & "<NAME>BILL</NAME>"
                                    'strRequestXML = strRequestXML & "<BILLCREDITPERIOD>45 Days</BILLCREDITPERIOD>"
                                    'strRequestXML = strRequestXML & "<BILLTYPE>New Ref</BILLTYPE>"

                                    'If gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("CREDITDEBIT") = "CREDIT" Then
                                    '    strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"
                                    'Else
                                    '    strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST1").Rows(ROWJ).Item("AMOUNT")) & "</AMOUNT>"

                                    'End If
                                    'strRequestXML = strRequestXML & "</BILLALLOCATIONS.LIST>"
                                    strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"

                                End With
                            Next
                        End If



                        strRequestXML = strRequestXML & "</VOUCHER>"
                        strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                        strRequestXML = strRequestXML & "</REQUESTDATA>"
                        strRequestXML = strRequestXML & "</IMPORTDATA>"
                        strRequestXML = strRequestXML & "</BODY>"
                        strRequestXML = strRequestXML & "</ENVELOPE>"
                        SerHttp.open("POST", gTallyOdbc & gTallyPort)
                        SerHttp.send(strRequestXML)

                        'for tally error
                        'new for tally xml error
                        'begin

                        Dim resstr, errorstr, j
                        Dim errmsg As Boolean = False
                        resstr = SerHttp.responseText
                        ' MsgBox(resstr)
                        xmlDom.loadXML(resstr)

                    End With
                Next

                Dim insert(1) As String

                'ssql = " Update KOT_HDR  set postingstatus ='Y' where CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) Between '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                'gconnection.dataOperation1(2, ssql, "Billhdr")

                'ssql = " Update BILL_HDR  set ACCOUNTFLAG ='Y' where CAST(CONVERT(VARCHAR(11),BILLDATE,6) AS DATETIME) Between '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                'gconnection.dataOperation1(2, ssql, "Billhdr")

                'ssql = "Cp_Journalentry '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "','" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                'gconnection.dataOperation1(2, ssql, "Billhdr")

                ssql = "INSERT INTO TallY_JournalEntry (VoucherNo,voucherdate,VoucherCategory,VoucherType,CashBank,SLCODE,SLDESC,CreditDebit,Amount,Description,InstrumentDate,InstrumentType,Instrumentno,BankName,BankPlace) (select VoucherNo,voucherdate,VoucherCategory,VoucherType,CashBank,SLCODE,SLDESC,CreditDebit,Amount,Description,InstrumentDate,InstrumentType,Instrumentno,BankName,BankPlace from Tally_JournalEntry_Tmp where isnull(void,'')='N')"
                insert(0) = ssql

                gconnection.MoreTransold(insert)

                '                MsgBox("Successcully Created", vbInformation, "Month Bill Posted to Accounts Tally")

                GrpPeriod.Visible = True

            Else
                MsgBox("There is no record(s) to Post.......", MsgBoxStyle.OKOnly, "Month Bill Posted to Accounts Tally")
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallyvalidate : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Function TallyExport_GRN()
        Dim myconnection As New ADODB.Connection
        Dim ssql As String
        Dim sval1 As Double
        Try
            myconnection.Open(gTallyDsn)
            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30
            Dim strRequestXML As String
            Dim strstring, sqlstring, LEDGER As String
            Dim sql As String
            Dim otherbillno As String
            Dim otherbool As Boolean
            Dim ROWJ, ROWI, ROWJJ As Integer
            Dim MCODE, MNAME, VOUCHERTYPE As String
            Dim AMOUNT As Double
            Dim taxapplicable As String = "Y"

            Dim GRNDETAILS As String

            sqlstring = "DROP TABLE TMP_GRN "
            gconnection.getDataSet(sqlstring, "TALLYMST")

            sqlstring = "select * into TMP_GRN from VIEW_GRN_TALLY A WHERE A.GRNDATE BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
            gconnection.getDataSet(sqlstring, "TALLYMST")
            sqlstring = "SELECT A.GRNDETAILS,A.GRNDATE,A.CRCODE AS CRCODE,A.CRNAME AS CRNAME,ISNULL(SUM(ISNULL(A.BILLAMOUNT,0)),0) AS AMOUNT FROM TMP_GRN A GROUP BY A.GRNDETAILS,A.GRNDATE,A.CRCODE,A.CRNAME ORDER BY A.CRCODE"
            gconnection.getDataSet(sqlstring, "TALLYMST")
            If gdataset.Tables("TALLYMST").Rows.Count > 0 Then
                For ROWI = 0 To gdataset.Tables("TALLYMST").Rows.Count - 1
                    With gdataset.Tables("TALLYMST").Rows(ROWI)
                        MCODE = .Item("CRCODE")
                        MNAME = .Item("CRNAME")
                        AMOUNT = .Item("AMOUNT")
                        GRNDETAILS = .Item("GRNDETAILS")

                        'for MONTH BILL create

                        ROWJJ = 0
                        strRequestXML = ""
                        strRequestXML = strRequestXML & "<ENVELOPE>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<HEADER>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>" + Environment.NewLine
                        strRequestXML = strRequestXML & "</HEADER>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<BODY>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<IMPORTDATA>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<REQUESTDESC>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<REPORTNAME>Vouchers</REPORTNAME>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<STATICVARIABLES>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallymonthbill) & "</SVCURRENTCOMPANY>" + Environment.NewLine
                        strRequestXML = strRequestXML & "</STATICVARIABLES>" + Environment.NewLine
                        strRequestXML = strRequestXML & "</REQUESTDESC>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<REQUESTDATA>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<TALLYMESSAGE>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='Purchase' ACTION='Create'>" + Environment.NewLine

                        ' for create /
                        ' update / delete

                        strRequestXML = strRequestXML & "<DATE>" & Format(.Item("grndate"), "yyyyMMdd") & "</DATE>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<NARRATION>" & .Item("GRNDETAILS") & " Bill</NARRATION>" + Environment.NewLine

                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>" & txt_vouchertype.Text & "</VOUCHERTYPENAME>" + Environment.NewLine

                        strRequestXML = strRequestXML & "<VOUCHERNUMBER>" & .Item("GRNDETAILS") & "</VOUCHERNUMBER>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(MCODE)) & "</PARTYLEDGERNAME>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(MCODE)) & "</PARTYNAME>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<EFFECTIVEDATE>" & Format(.Item("GRNDATE"), "yyyyMMdd") & "</EFFECTIVEDATE>" + Environment.NewLine

                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(MCODE)) & "</LEDGERNAME>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<GSTCLASS/>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST").Rows(ROWI).Item("AMOUNT")) & "</AMOUNT>" + Environment.NewLine

                        strRequestXML = strRequestXML & "<BILLALLOCATIONS.LIST>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<NAME>BILL</NAME>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<BILLCREDITPERIOD>45 Days</BILLCREDITPERIOD>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<BILLTYPE>New Ref</BILLTYPE>" + Environment.NewLine
                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMST").Rows(ROWI).Item("AMOUNT")) & "</AMOUNT>" + Environment.NewLine
                        strRequestXML = strRequestXML & "</BILLALLOCATIONS.LIST>" + Environment.NewLine
                        strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>" + Environment.NewLine

                        'PURCHASE LEDGER AMOUNT
                        sqlstring = "SELECT A.GRNDETAILS,A.GRNDATE,A.LEDGER AS LEDGER,ISNULL(SUM(ISNULL(A.AMOUNT,0)),0) AS AMOUNT FROM TMP_GRN A WHERE A.GRNDETAILS='" & GRNDETAILS & "' AND ISNULL(AMOUNT,0)<>0 GROUP BY A.GRNDETAILS,A.GRNDATE,A.LEDGER ORDER BY A.LEDGER"
                        gconnection.getDataSet(sqlstring, "TALLYMM")
                        If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
                            For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
                                LEDGER = ""
                                AMOUNT = 0
                                With gdataset.Tables("TALLYMM").Rows(ROWJJ)
                                    strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<LEDGERNAME>" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "</LEDGERNAME>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<GSTCLASS/>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) & "</AMOUNT>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                                End With
                            Next

                        End If


                        sqlstring = "SELECT A.GRNDETAILS,A.GRNDATE,A.TAXLEDGER AS LEDGER,ISNULL(SUM(ISNULL(A.TAXAMOUNT,0)),0) AS AMOUNT FROM TMP_GRN A WHERE A.GRNDETAILS='" & GRNDETAILS & "' AND ISNULL(TAXAMOUNT,0)<>0 GROUP BY A.GRNDETAILS,A.GRNDATE,A.TAXLEDGER ORDER BY A.TAXLEDGER"
                        gconnection.getDataSet(sqlstring, "TALLYMM")
                        If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
                            For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
                                LEDGER = ""
                                AMOUNT = 0
                                With gdataset.Tables("TALLYMM").Rows(ROWJJ)
                                    strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<LEDGERNAME>" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "</LEDGERNAME>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<GSTCLASS/>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) & "</AMOUNT>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                                End With
                            Next
                        End If

                        'DICOUNT


                        sqlstring = "SELECT A.GRNDETAILS,A.GRNDATE,A.DiscountLedger AS LEDGER,ISNULL(SUM(ISNULL(A.Discount,0)),0) AS AMOUNT FROM TMP_GRN A WHERE A.GRNDETAILS='" & GRNDETAILS & "' AND ISNULL(Discount,0)<>0 GROUP BY A.GRNDETAILS,A.GRNDATE,A.DiscountLedger ORDER BY A.DiscountLedger"
                        gconnection.getDataSet(sqlstring, "TALLYMM")
                        If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
                            For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
                                LEDGER = ""
                                AMOUNT = 0
                                With gdataset.Tables("TALLYMM").Rows(ROWJJ)
                                    strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<LEDGERNAME>" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "</LEDGERNAME>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<GSTCLASS/>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>" + Environment.NewLine

                                    If Val(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) > 0 Then
                                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) & "</AMOUNT>" + Environment.NewLine
                                    Else
                                        strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) & "</AMOUNT>" + Environment.NewLine
                                    End If
                                    strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                                End With
                            Next
                        End If

                        'OTHCHARGE LEDGER AMOUNT
                        sqlstring = "SELECT A.GRNDETAILS,A.GRNDATE,A.OtherLedger AS LEDGER,ISNULL(SUM(ISNULL(A.OTHCHARGE,0)),0) AS AMOUNT FROM TMP_GRN A WHERE A.GRNDETAILS='" & GRNDETAILS & "' AND ISNULL(OTHCHARGE,0)<>0 GROUP BY A.GRNDETAILS,A.GRNDATE,A.OtherLedger ORDER BY A.OtherLedger"
                        gconnection.getDataSet(sqlstring, "TALLYMM")
                        If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
                            For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
                                LEDGER = ""
                                AMOUNT = 0
                                With gdataset.Tables("TALLYMM").Rows(ROWJJ)
                                    strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<LEDGERNAME>" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "</LEDGERNAME>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<GSTCLASS/>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>" + Environment.NewLine

                                    If Val(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) > 0 Then
                                        strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) & "</AMOUNT>" + Environment.NewLine
                                    Else
                                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) & "</AMOUNT>" + Environment.NewLine
                                    End If
                                    strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                                End With
                            Next
                        End If

                        'OVERALL DICOUNT
                        'OverallLedger LEDGER AMOUNT
                        sqlstring = "SELECT A.GRNDETAILS,A.GRNDATE,A.OverallLedger AS LEDGER,ISNULL(SUM(ISNULL(A.OverallDiscount,0)),0) AS AMOUNT FROM TMP_GRN A WHERE A.GRNDETAILS='" & GRNDETAILS & "' AND ISNULL(OverallDiscount,0)<>0 GROUP BY A.GRNDETAILS,A.GRNDATE,A.OverallLedger ORDER BY A.OverallLedger"
                        gconnection.getDataSet(sqlstring, "TALLYMM")
                        If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
                            For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
                                LEDGER = ""
                                AMOUNT = 0
                                With gdataset.Tables("TALLYMM").Rows(ROWJJ)
                                    strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<LEDGERNAME>" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("LEDGER")) & "</LEDGERNAME>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<GSTCLASS/>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>" + Environment.NewLine
                                    strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>" + Environment.NewLine

                                    If Val(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) > 0 Then
                                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) & "</AMOUNT>" + Environment.NewLine
                                    Else
                                        strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) & "</AMOUNT>" + Environment.NewLine
                                    End If
                                    strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>" + Environment.NewLine
                                End With
                            Next
                        End If

                        strRequestXML = strRequestXML & "</VOUCHER>" + Environment.NewLine
                        strRequestXML = strRequestXML & "</TALLYMESSAGE>" + Environment.NewLine
                        strRequestXML = strRequestXML & "</REQUESTDATA>" + Environment.NewLine
                        strRequestXML = strRequestXML & "</IMPORTDATA>" + Environment.NewLine
                        strRequestXML = strRequestXML & "</BODY>" + Environment.NewLine
                        strRequestXML = strRequestXML & "</ENVELOPE>" + Environment.NewLine
                        SerHttp.open("POST", gTallyOdbc & gTallyPort)
                        SerHttp.send(strRequestXML)

                        Dim resstr, errorstr, j
                        Dim errmsg As Boolean = False
                        resstr = SerHttp.responseText
                        xmlDom.loadXML(resstr)

                    End With
                Next

                Dim insert(1) As String

                'ssql = " Update KOT_HDR  set postingstatus ='Y' where CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) Between '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                'gconnection.dataOperation1(2, ssql, "Billhdr")

                'ssql = " Update BILL_HDR  set ACCOUNTFLAG ='Y' where CAST(CONVERT(VARCHAR(11),BILLDATE,6) AS DATETIME) Between '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                'gconnection.dataOperation1(2, ssql, "Billhdr")

                'ssql = "Cp_Journalentry '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "','" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
                'gconnection.dataOperation1(2, ssql, "Billhdr")

                ssql = "INSERT INTO TallY_JournalEntry (VoucherNo,voucherdate,VoucherCategory,VoucherType,CashBank,SLCODE,SLDESC,CreditDebit,Amount,Description,InstrumentDate,InstrumentType,Instrumentno,BankName,BankPlace) (select VoucherNo,voucherdate,VoucherCategory,VoucherType,CashBank,SLCODE,SLDESC,CreditDebit,Amount,Description,InstrumentDate,InstrumentType,Instrumentno,BankName,BankPlace from Tally_JournalEntry_Tmp where isnull(void,'')='N')"
                insert(0) = ssql

                gconnection.MoreTransold(insert)

                MsgBox("Successcully Created", vbInformation, "Month Bill Posted to Accounts Tally")

                GrpPeriod.Visible = True

            Else
                MsgBox("There is no record(s) to Post.......", MsgBoxStyle.OKOnly, "Month Bill Posted to Accounts Tally")
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error tallyvalidate : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Sub fillPayment_Mode()
        Dim sqlstring As String
        Dim index As Integer
        Dim i As Integer
        Try
            sqlstring = " SELECT PaymentCode FROM paymentmodemaster WHERE ISNULL(freeze,'')<>'Y'"
            cbo_paymentmode.Items.Clear()
            gconnection.getDataSet(sqlstring, "paymentmodemaster")
            If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("paymentmodemaster").Rows.Count - 1
                    cbo_paymentmode.Items.Add(gdataset.Tables("paymentmodemaster").Rows(i).Item("PaymentCode"))
                Next i
                '                index = cbo_paymentmode.FindString(DefaultPayment)
                '               cbo_PaymentMode.SelectedIndex = index
            Else
                MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_paymentmode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_paymentmode.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim I As Integer
        If Me.CheckBox1.Checked = True Then
            For I = 0 To CHKSUPP.Items.Count - 1
                CHKSUPP.SetItemChecked(I, True)
            Next
        Else
            For I = 0 To CHKSUPP.Items.Count - 1
                CHKSUPP.SetItemChecked(I, True)
            Next
        End If
    End Sub

    Private Sub CHKSUPP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKSUPP.SelectedIndexChanged
        Me.CHKBILLS.Items.Clear()
        Dim I As Integer
        Dim SPCODE As String()
        Dim SPCODE1 As String
        SQLSTRING = "SELECT GRNDETAILS FROM  GRN_HEADER WHERE CAST(CONVERT(VARCHAR(11),GRNDATE,106)AS DATETIME) BETWEEN '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' AND ISNULL(VOID,'')<>'Y' AND SUPPLIERCODE IN('"
        If Me.CHKSUPP.CheckedItems.Count > 0 Then
            For I = 0 To CHKSUPP.CheckedItems.Count - 1
                SPCODE1 = ""
                SPCODE1 = Trim(CHKSUPP.CheckedItems(I))
                If SPCODE1 <> "" Then
                    SPCODE = Nothing
                    SPCODE = Split(SPCODE1, "->")
                    SQLSTRING = SQLSTRING & SPCODE(1) & "','"
                End If


            Next
            SQLSTRING = Mid(SQLSTRING, 1, Len(SQLSTRING) - 2)
            SQLSTRING = SQLSTRING & ")"
            gconnection.getDataSet(SQLSTRING, "BILLS")
            If gdataset.Tables("BILLS").Rows.Count > 0 Then
                Me.CHKBILLS.Items.Clear()
                For I = 0 To gdataset.Tables("BILLS").Rows.Count - 1
                    CHKBILLS.Items.Add(gdataset.Tables("BILLS").Rows(I).Item("GRNDETAILS"))
                    ''& "->" & gdataset.Tables("SUUPLIER").Rows(I).Item("SUPPLIERCODE"))
                Next
            End If

            ' SQLSTRING = "SELECT GRNDETAILS FROM GRN_HEADER WHERE "
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim I As Integer
        If Me.CheckBox1.Checked = True Then
            For I = 0 To CHKBILLS.Items.Count - 1
                CHKBILLS.SetItemChecked(I, True)
            Next
        Else
            For I = 0 To CHKBILLS.Items.Count - 1
                CHKBILLS.SetItemChecked(I, True)
            Next
        End If
    End Sub

    Private Sub dtp_Todate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Todate.ValueChanged
        Call FILLSUPPLIER()
    End Sub
End Class