Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.IO
Public Class POSMaster
    Inherits System.Windows.Forms.Form
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim vSeqNo As Double
    Dim gconnection As New GlobalClass
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdPOSHelp As System.Windows.Forms.Button
    Friend WithEvents txtPOSDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPOSCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_GLAccount As System.Windows.Forms.Label
    Friend WithEvents txtAcctIn As System.Windows.Forms.TextBox
    Friend WithEvents txtAcctDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmdAccHelp As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents opt_Facility As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Store As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_PackingCharge As System.Windows.Forms.Label
    Friend WithEvents txt_PackingPercent As System.Windows.Forms.TextBox
    Friend WithEvents txtPackingAcctdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPackingAcctin As System.Windows.Forms.TextBox
    Friend WithEvents cmdPackingAcctin As System.Windows.Forms.Button
    Friend WithEvents lbl_PackingAcctin As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_COSTCENTER As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CMD_COST As System.Windows.Forms.Button
    Friend WithEvents TXT_COST_DESC As System.Windows.Forms.TextBox
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(POSMaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TXT_COSTCENTER = New System.Windows.Forms.TextBox
        Me.CMD_COST = New System.Windows.Forms.Button
        Me.TXT_COST_DESC = New System.Windows.Forms.TextBox
        Me.cmdPOSHelp = New System.Windows.Forms.Button
        Me.txtPOSDesc = New System.Windows.Forms.TextBox
        Me.txtPOSCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lbl_GLAccount = New System.Windows.Forms.Label
        Me.txtAcctIn = New System.Windows.Forms.TextBox
        Me.txtAcctDesc = New System.Windows.Forms.TextBox
        Me.cmdAccHelp = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.opt_Facility = New System.Windows.Forms.RadioButton
        Me.opt_Store = New System.Windows.Forms.RadioButton
        Me.lbl_PackingCharge = New System.Windows.Forms.Label
        Me.txt_PackingPercent = New System.Windows.Forms.TextBox
        Me.txtPackingAcctdesc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPackingAcctin = New System.Windows.Forms.TextBox
        Me.cmdPackingAcctin = New System.Windows.Forms.Button
        Me.lbl_PackingAcctin = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_COSTCENTER)
        Me.GroupBox1.Controls.Add(Me.CMD_COST)
        Me.GroupBox1.Controls.Add(Me.TXT_COST_DESC)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 288)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(304, 244)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(264, 32)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(80, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 21)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "COSTCENTER ACCTOUNT IN"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_COSTCENTER
        '
        Me.TXT_COSTCENTER.BackColor = System.Drawing.Color.Wheat
        Me.TXT_COSTCENTER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_COSTCENTER.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_COSTCENTER.Location = New System.Drawing.Point(304, 144)
        Me.TXT_COSTCENTER.MaxLength = 10
        Me.TXT_COSTCENTER.Name = "TXT_COSTCENTER"
        Me.TXT_COSTCENTER.Size = New System.Drawing.Size(120, 26)
        Me.TXT_COSTCENTER.TabIndex = 2
        Me.TXT_COSTCENTER.Text = ""
        '
        'CMD_COST
        '
        Me.CMD_COST.Image = CType(resources.GetObject("CMD_COST.Image"), System.Drawing.Image)
        Me.CMD_COST.Location = New System.Drawing.Point(424, 144)
        Me.CMD_COST.Name = "CMD_COST"
        Me.CMD_COST.Size = New System.Drawing.Size(23, 26)
        Me.CMD_COST.TabIndex = 17
        '
        'TXT_COST_DESC
        '
        Me.TXT_COST_DESC.BackColor = System.Drawing.Color.Wheat
        Me.TXT_COST_DESC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_COST_DESC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_COST_DESC.Location = New System.Drawing.Point(448, 144)
        Me.TXT_COST_DESC.MaxLength = 35
        Me.TXT_COST_DESC.Name = "TXT_COST_DESC"
        Me.TXT_COST_DESC.ReadOnly = True
        Me.TXT_COST_DESC.Size = New System.Drawing.Size(192, 26)
        Me.TXT_COST_DESC.TabIndex = 3
        Me.TXT_COST_DESC.Text = ""
        '
        'cmdPOSHelp
        '
        Me.cmdPOSHelp.Image = CType(resources.GetObject("cmdPOSHelp.Image"), System.Drawing.Image)
        Me.cmdPOSHelp.Location = New System.Drawing.Point(496, 64)
        Me.cmdPOSHelp.Name = "cmdPOSHelp"
        Me.cmdPOSHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdPOSHelp.TabIndex = 13
        '
        'txtPOSDesc
        '
        Me.txtPOSDesc.BackColor = System.Drawing.Color.Wheat
        Me.txtPOSDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPOSDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOSDesc.Location = New System.Drawing.Point(376, 104)
        Me.txtPOSDesc.MaxLength = 50
        Me.txtPOSDesc.Name = "txtPOSDesc"
        Me.txtPOSDesc.Size = New System.Drawing.Size(336, 26)
        Me.txtPOSDesc.TabIndex = 1
        Me.txtPOSDesc.Text = ""
        '
        'txtPOSCode
        '
        Me.txtPOSCode.BackColor = System.Drawing.Color.Wheat
        Me.txtPOSCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPOSCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOSCode.Location = New System.Drawing.Point(376, 64)
        Me.txtPOSCode.MaxLength = 15
        Me.txtPOSCode.Name = "txtPOSCode"
        Me.txtPOSCode.Size = New System.Drawing.Size(120, 26)
        Me.txtPOSCode.TabIndex = 0
        Me.txtPOSCode.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(224, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "POS DESCRIPTION "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "POS CODE "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(424, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(169, 31)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "POS MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_GLAccount
        '
        Me.lbl_GLAccount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GLAccount.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GLAccount.ForeColor = System.Drawing.Color.Black
        Me.lbl_GLAccount.Location = New System.Drawing.Point(200, 144)
        Me.lbl_GLAccount.Name = "lbl_GLAccount"
        Me.lbl_GLAccount.Size = New System.Drawing.Size(174, 21)
        Me.lbl_GLAccount.TabIndex = 16
        Me.lbl_GLAccount.Text = " SALES  ACCOUNT IN "
        Me.lbl_GLAccount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAcctIn
        '
        Me.txtAcctIn.BackColor = System.Drawing.Color.Wheat
        Me.txtAcctIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAcctIn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctIn.Location = New System.Drawing.Point(376, 144)
        Me.txtAcctIn.MaxLength = 10
        Me.txtAcctIn.Name = "txtAcctIn"
        Me.txtAcctIn.Size = New System.Drawing.Size(120, 26)
        Me.txtAcctIn.TabIndex = 2
        Me.txtAcctIn.Text = ""
        '
        'txtAcctDesc
        '
        Me.txtAcctDesc.BackColor = System.Drawing.Color.Wheat
        Me.txtAcctDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAcctDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctDesc.Location = New System.Drawing.Point(520, 144)
        Me.txtAcctDesc.MaxLength = 35
        Me.txtAcctDesc.Name = "txtAcctDesc"
        Me.txtAcctDesc.ReadOnly = True
        Me.txtAcctDesc.Size = New System.Drawing.Size(192, 26)
        Me.txtAcctDesc.TabIndex = 3
        Me.txtAcctDesc.Text = ""
        '
        'cmdAccHelp
        '
        Me.cmdAccHelp.Image = CType(resources.GetObject("cmdAccHelp.Image"), System.Drawing.Image)
        Me.cmdAccHelp.Location = New System.Drawing.Point(496, 144)
        Me.cmdAccHelp.Name = "cmdAccHelp"
        Me.cmdAccHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdAccHelp.TabIndex = 17
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(16, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 0
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(352, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 3
        Me.CmdView.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(240, 16)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 2
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'CmdAdd
        '
        Me.CmdAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.ForeColor = System.Drawing.Color.White
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.Location = New System.Drawing.Point(128, 16)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(104, 32)
        Me.CmdAdd.TabIndex = 1
        Me.CmdAdd.Text = "Add [F7]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(464, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 4
        Me.cmdexit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.CmdAdd)
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 56)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(440, 561)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 22
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(520, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "[F4]"
        '
        'opt_Facility
        '
        Me.opt_Facility.BackColor = System.Drawing.Color.Transparent
        Me.opt_Facility.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Facility.Location = New System.Drawing.Point(392, 296)
        Me.opt_Facility.Name = "opt_Facility"
        Me.opt_Facility.Size = New System.Drawing.Size(88, 16)
        Me.opt_Facility.TabIndex = 7
        Me.opt_Facility.Text = "FACILITY"
        '
        'opt_Store
        '
        Me.opt_Store.BackColor = System.Drawing.Color.Transparent
        Me.opt_Store.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Store.Location = New System.Drawing.Point(576, 296)
        Me.opt_Store.Name = "opt_Store"
        Me.opt_Store.Size = New System.Drawing.Size(56, 16)
        Me.opt_Store.TabIndex = 8
        Me.opt_Store.Text = "POS"
        '
        'lbl_PackingCharge
        '
        Me.lbl_PackingCharge.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PackingCharge.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PackingCharge.ForeColor = System.Drawing.Color.Black
        Me.lbl_PackingCharge.Location = New System.Drawing.Point(160, 219)
        Me.lbl_PackingCharge.Name = "lbl_PackingCharge"
        Me.lbl_PackingCharge.Size = New System.Drawing.Size(217, 21)
        Me.lbl_PackingCharge.TabIndex = 18
        Me.lbl_PackingCharge.Text = "PACKING/SERV./SURCHR %"
        Me.lbl_PackingCharge.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_PackingPercent
        '
        Me.txt_PackingPercent.BackColor = System.Drawing.Color.White
        Me.txt_PackingPercent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PackingPercent.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PackingPercent.Location = New System.Drawing.Point(376, 216)
        Me.txt_PackingPercent.MaxLength = 5
        Me.txt_PackingPercent.Name = "txt_PackingPercent"
        Me.txt_PackingPercent.Size = New System.Drawing.Size(55, 26)
        Me.txt_PackingPercent.TabIndex = 4
        Me.txt_PackingPercent.Text = ""
        Me.txt_PackingPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPackingAcctdesc
        '
        Me.txtPackingAcctdesc.BackColor = System.Drawing.Color.White
        Me.txtPackingAcctdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPackingAcctdesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackingAcctdesc.Location = New System.Drawing.Point(520, 256)
        Me.txtPackingAcctdesc.MaxLength = 35
        Me.txtPackingAcctdesc.Name = "txtPackingAcctdesc"
        Me.txtPackingAcctdesc.ReadOnly = True
        Me.txtPackingAcctdesc.Size = New System.Drawing.Size(192, 26)
        Me.txtPackingAcctdesc.TabIndex = 6
        Me.txtPackingAcctdesc.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 19)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "%"
        '
        'txtPackingAcctin
        '
        Me.txtPackingAcctin.BackColor = System.Drawing.Color.White
        Me.txtPackingAcctin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPackingAcctin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackingAcctin.Location = New System.Drawing.Point(376, 256)
        Me.txtPackingAcctin.MaxLength = 10
        Me.txtPackingAcctin.Name = "txtPackingAcctin"
        Me.txtPackingAcctin.Size = New System.Drawing.Size(120, 26)
        Me.txtPackingAcctin.TabIndex = 5
        Me.txtPackingAcctin.Text = ""
        '
        'cmdPackingAcctin
        '
        Me.cmdPackingAcctin.Image = CType(resources.GetObject("cmdPackingAcctin.Image"), System.Drawing.Image)
        Me.cmdPackingAcctin.Location = New System.Drawing.Point(496, 256)
        Me.cmdPackingAcctin.Name = "cmdPackingAcctin"
        Me.cmdPackingAcctin.Size = New System.Drawing.Size(23, 26)
        Me.cmdPackingAcctin.TabIndex = 21
        '
        'lbl_PackingAcctin
        '
        Me.lbl_PackingAcctin.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PackingAcctin.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PackingAcctin.ForeColor = System.Drawing.Color.Black
        Me.lbl_PackingAcctin.Location = New System.Drawing.Point(160, 260)
        Me.lbl_PackingAcctin.Name = "lbl_PackingAcctin"
        Me.lbl_PackingAcctin.Size = New System.Drawing.Size(216, 21)
        Me.lbl_PackingAcctin.TabIndex = 20
        Me.lbl_PackingAcctin.Text = "PACK./SERV./S.C.  ACCT IN "
        Me.lbl_PackingAcctin.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 656)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(383, 18)
        Me.Label3.TabIndex = 417
        Me.Label3.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(368, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 26)
        Me.Button1.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(192, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(592, 280)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(200, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = " SALES  ACCOUNT IN :"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Wheat
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(240, 144)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 26)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(208, 344)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(568, 208)
        Me.ssGrid.TabIndex = 418
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(72, 328)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(856, 232)
        Me.GroupBox4.TabIndex = 419
        Me.GroupBox4.TabStop = False
        '
        'POSMaster
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1016, 686)
        Me.ControlBox = False
        Me.Controls.Add(Me.ssGrid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_PackingAcctin)
        Me.Controls.Add(Me.txtPackingAcctin)
        Me.Controls.Add(Me.lbl_PackingCharge)
        Me.Controls.Add(Me.txt_PackingPercent)
        Me.Controls.Add(Me.txtPackingAcctdesc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.lbl_GLAccount)
        Me.Controls.Add(Me.txtAcctIn)
        Me.Controls.Add(Me.txtAcctDesc)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtPOSCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPOSDesc)
        Me.Controls.Add(Me.cmdPackingAcctin)
        Me.Controls.Add(Me.opt_Store)
        Me.Controls.Add(Me.opt_Facility)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdAccHelp)
        Me.Controls.Add(Me.cmdPOSHelp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "POSMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtPOSCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPOSCode.KeyPress
        ' getNumeric(e)
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If txtPOSCode.Text <> "" Then
                txtPOSCode_Validated(txtPOSCode, e)
                txtPOSDesc.Focus()
            Else
                Call cmdPOSHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub txtPOSDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPOSDesc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtPOSDesc.Text <> "" Then
                txtAcctIn.Focus()
            End If
        End If
    End Sub
    Private Sub txtPOSCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPOSCode.Validated
        Dim strStatus As Integer
        If Trim(txtPOSCode.Text) <> "" Then
            vSeqNo = GetSeqno(txtPOSCode.Text)
            sqlstring = " SELECT ISNULL(COSTCODE,'') AS COSTCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(SALESACCTIN,'') AS SALESACCTIN,ISNULL(SALESACCTDESC,'') AS SALESACCTDESC,ISNULL(FREEZE,'') AS FREEZE ,ADDDATETIME,ISNULL(STORESTATUS,'') AS STORESTATUS "
            sqlstring = sqlstring & ",ISNULL(PACKINGPERCENT,0) AS PACKINGPERCENT,ISNULL(PACKINGACCTIN,'') AS PACKINGACCTIN,ISNULL(PACKINGDESC,'') AS PACKINGDESC  FROM POSMASTER WHERE POSSEQNO = " & Trim(vSeqNo)
            gconnection.getDataSet(sqlstring, "POSMASTER")
            If gdataset.Tables("POSMASTER").Rows.Count > 0 Then
                txtPOSDesc.Clear()
                txtPOSDesc.Text = Trim(gdataset.Tables("POSMASTER").Rows(0).Item("POSDESC"))
                txtAcctIn.Text = Trim(gdataset.Tables("POSMASTER").Rows(0).Item("SALESACCTIN"))
                txtAcctDesc.Text = Trim(gdataset.Tables("POSMASTER").Rows(0).Item("SALESACCTDESC"))
                TXT_COSTCENTER.Text = Trim(gdataset.Tables("POSMASTER").Rows(0).Item("COSTCODE"))
                Call TXT_COSTCENTER_Validated(sender, e)
                txt_PackingPercent.Text = Format(Val(gdataset.Tables("POSMASTER").Rows(0).Item("PACKINGPERCENT")), "0.00")

                'If Val(txt_PackingPercent.Text) <= 0 Then
                '    lbl_PackingAcctin.Enabled = False
                '    txtPackingAcctin.Enabled = False
                '    cmdPackingAcctin.Enabled = False
                '    txtPackingAcctdesc.Enabled = False
                'Else
                '    lbl_PackingAcctin.Enabled = True
                '    txtPackingAcctin.Enabled = True
                '    cmdPackingAcctin.Enabled = True
                '    txtPackingAcctdesc.Enabled = True
                'End If

                txtPackingAcctin.Text = Trim(gdataset.Tables("POSMASTER").Rows(0).Item("PACKINGACCTIN"))
                txtPackingAcctdesc.Text = Trim(gdataset.Tables("POSMASTER").Rows(0).Item("PACKINGDESC"))
                txtPOSCode.ReadOnly = True
                txtPOSDesc.Focus()
                If gdataset.Tables("POSMASTER").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("POSMASTER").Rows(0).Item("AddDateTime")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                strStatus = StrComp(Trim(gdataset.Tables("POSMASTER").Rows(0).Item("STORESTATUS")), "F", CompareMethod.Text)

                If strStatus = 0 Then
                    opt_Facility.Checked = True
                Else
                    opt_Store.Checked = True
                End If
                Me.CmdAdd.Text = "Update[F7]"
                Me.cmdPOSHelp.Enabled = False
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.CmdAdd.Text = "Add [F7]"
                txtPOSCode.ReadOnly = False
                txtPOSDesc.Focus()
            End If

            Dim strsql As String
            Dim I As Integer

            strsql = "select * from POS_USERCONTROL WHERE POSCODE = '" & Trim(txtPOSCode.Text) & "'  "
            gconnection.getDataSet(strsql, "MEM")
            If gdataset.Tables("MEM").Rows.Count > 0 Then
                With ssGrid
                    For I = 0 To gdataset.Tables("MEM").Rows.Count - 1
                        .Col = 1
                        .Row = I + 1
                        .Text = Trim(gdataset.Tables("MEM").Rows(I).Item("USERNAME"))
                    Next
                    .SetActiveCell(1, 1)
                    .Focus()
                End With
            End If
        Else
            txtPOSCode.Text = ""
            txtPOSDesc.Focus()
        End If
    End Sub

    Private Sub cmdPOSHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPOSHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "POSCODE,POSDESC"
        vform.vFormatstring = "                 POS CODE              |                   POS DESCRIPTION                           "
        vform.vCaption = "POS MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtPOSCode.Text = Trim(vform.keyfield & "")
            Call txtPOSCode_Validated(txtPOSCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub POSMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F8 Then
            If Cmd_Freeze.Enabled = True Then
                Call Cmd_Freeze_Click(Cmd_Freeze, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F7 Then
            If CmdAdd.Enabled = True Then
                Call CmdAdd_Click(CmdAdd, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F9 Then
            If CmdView.Enabled = True Then
                Call CmdView_Click(CmdView, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmdexit_Click(cmdexit, e)
            Exit Sub
        End If
    End Sub
    Private Sub GroupMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPOSCode.Focus()
        POSMastbool = True
        CmdAdd.Text = "Add [F7]"
        txtPOSCode.ReadOnly = False
        txtPOSDesc.ReadOnly = False
        opt_Facility.Checked = True
        lbl_PackingAcctin.Enabled = True
        txtPackingAcctin.Enabled = True
        cmdPackingAcctin.Enabled = True
        txtPackingAcctdesc.Enabled = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        ssGrid.ClearRange(1, 1, -1, -1, True)

        txtPOSCode.Focus()
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='ACCOUNTS INTEGRATION' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.CmdAdd.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        CmdView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdAdd.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.CmdView.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.CmdAdd.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.CmdAdd.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.CmdAdd.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        CmdAdd.Text = "Add [F7]"
        cmdPOSHelp.Enabled = True
        txtPOSCode.ReadOnly = False
        txtPOSDesc.ReadOnly = False
        opt_Facility.Checked = True
        TXT_COST_DESC.Text = ""
        TXT_COSTCENTER.Text = ""
        lbl_PackingAcctin.Enabled = True
        txtPackingAcctin.Enabled = True
        cmdPackingAcctin.Enabled = True
        txtPackingAcctdesc.Enabled = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        ssGrid.ClearRange(1, 1, -1, -1, True)

        txtPOSCode.Focus()
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM POSMASTER"
        Gheader = "POS MASTER"
        FrReport.SsGridReport.SetText(2, 1, "POSCODE")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "POSDESC")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "PACKINGPERCENT")
        FrReport.SsGridReport.SetText(3, 3, 15)
        FrReport.SsGridReport.SetText(2, 4, "PACKINGACCTIN")
        FrReport.SsGridReport.SetText(3, 4, 15)
        FrReport.SsGridReport.SetText(2, 5, "SALESACCTIN")
        FrReport.SsGridReport.SetText(3, 5, 15)
        FrReport.SsGridReport.SetText(2, 6, "STORESTATUS")
        FrReport.SsGridReport.SetText(3, 6, 10)
        FrReport.SsGridReport.SetText(2, 7, "ADDUSERID")
        FrReport.SsGridReport.SetText(3, 7, 10)
        FrReport.SsGridReport.SetText(2, 8, "FREEZE")
        FrReport.SsGridReport.SetText(3, 8, 10)
        FrReport.Show()
    End Sub
    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim SQL(0), TTYPE As String
        Dim I As Integer
        If CmdAdd.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            vSeqNo = GetSeqno(txtPOSCode.Text)
            sqlstring = " INSERT INTO POSMASTER (POSseqno,COSTCODE,Poscode,PosDesc,SalesAcctin,SalesAcctdesc,PackingPercent,PackingAcctin,Packingdesc,Freeze,StoreStatus,AddUSerId,AddDateTime)"
            sqlstring = sqlstring & " VALUES ( " & Val(vSeqNo) & ",'" & TXT_COSTCENTER.Text & "','" & Trim(txtPOSCode.Text) & "','" & Replace(Trim(txtPOSDesc.Text), "'", "") & "',"
            sqlstring = sqlstring & " '" & Trim(txtAcctIn.Text) & "','" & Replace(Trim(txtAcctDesc.Text), "'", "") & "',"
            sqlstring = sqlstring & " " & Val(txt_PackingPercent.Text) & ",'" & Trim(txtPackingAcctin.Text) & "','" & Replace(Trim(txtPackingAcctdesc.Text), "'", "") & "',"
            If opt_Facility.Checked = True Then
                sqlstring = sqlstring & " 'N','F',"
            Else
                sqlstring = sqlstring & " 'N','S',"
            End If
            sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
            gconnection.dataOperation(1, sqlstring, "POSMASTER")


            '            Me.CmdClear_Click(sender, e)
        ElseIf CmdAdd.Text = "Update[F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.CmdAdd.Text, 1, 1) = "U" Then
                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                    Exit Sub
                End If
            End If
            sqlstring = "UPDATE  POSMASTER "
            sqlstring = sqlstring & " SET POSdesc='" & Replace(Trim(txtPOSDesc.Text), "'", "") & "',"
            sqlstring = sqlstring & " COSTCODE='" & Trim(TXT_COSTCENTER.Text) & "',"
            sqlstring = sqlstring & " SalesAcctin='" & Trim(txtAcctIn.Text) & "',SalesAcctdesc='" & Replace(Trim(txtAcctDesc.Text), "'", "") & "',"
            sqlstring = sqlstring & " PackingPercent = " & Val(txt_PackingPercent.Text) & ", PackingAcctin='" & Trim(txtPackingAcctin.Text) & "',Packingdesc='" & Replace(Trim(txtPackingAcctdesc.Text), "'", "") & "',"
            sqlstring = sqlstring & " AddUSerId='" & Trim(gUsername) & "',AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Freeze='N',"
            If opt_Facility.Checked = True Then
                sqlstring = sqlstring & " StoreStatus = 'F'"
            Else
                sqlstring = sqlstring & " StoreStatus = 'S'"
            End If
            sqlstring = sqlstring & " WHERE Poscode = '" & Trim(txtPOSCode.Text) & "'"
            gconnection.dataOperation(2, sqlstring, "POSMASTER")
            CmdAdd.Text = "Add [F7]"
        End If

        sqlstring = "DELETE FROM  POS_USERCONTROL WHERE POSCODE='" & Trim(txtPOSCode.Text) & "'"

        ReDim Preserve SQL(SQL.Length)
        SQL(SQL.Length - 1) = sqlstring
        With ssGrid
            For I = 0 To ssGrid.DataRowCnt - 1
                .Row = I + 1
                .Col = 1
                TTYPE = .Text

                sqlstring = "INSERT INTO POS_USERCONTROL (POSCODE,USERNAME,ADDUSER,ADDDATE)"
                sqlstring = sqlstring & " VALUES ('" & Trim(txtPOSCode.Text) & "','" & Trim(TTYPE) & "','" & gUsername & "','" & Format(Now(), "dd/MMM/yyyy HH:MM") & "')"

                ReDim Preserve SQL(SQL.Length)
                SQL(SQL.Length - 1) = sqlstring

            Next I
        End With
        gconnection.MoreTransold(SQL)
        Me.CmdClear_Click(sender, e)

    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  POS CODE Can't be blank *********************'''
        If Trim(txtPOSCode.Text) = "" Then
            MessageBox.Show("POS Code Can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPOSCode.Focus()
            Exit Sub
        End If
        '''********** Check  POS DESC Can't be blank *********************'''
        If Trim(txtPOSDesc.Text) = "" Then
            MessageBox.Show("POS Description Can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPOSDesc.Focus()
            Exit Sub
        End If
        '''********** Check  ACCOUNT IN Can't be blank *********************'''
        If Trim(Me.txtAcctIn.Text) = "" And Trim(Me.txtAcctDesc.Text) = "" Then
            MessageBox.Show("Account In Can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.txtAcctIn.Text = ""
            Me.txtAcctDesc.Text = ""
            Me.txtAcctIn.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub
    Private Sub txtPOSCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPOSCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmdPOSHelp.Enabled = True Then
                Search = Trim(txtPOSCode.Text)
                Call cmdPOSHelp_Click(txtPOSCode, e)
            End If
        End If
    End Sub
    Private Sub POSMaster_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        POSMastbool = False
    End Sub
    Private Sub cmdAccHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(ACCODE,'') AS ACCODE,ISNULL(ACDESC,'') AS ACDESC FROM Accountsglaccountmaster  "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(freezeflag,'') <> 'Y'"
        End If
        vform.Field = "ACCODE,ACDESC"
        vform.vFormatstring = "             ACCOUNT CODE                |              ACCOUNT DESCRIPTION                             "
        vform.vCaption = "ACCOUNT MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtAcctIn.Text = Trim(vform.keyfield & "")
            Call txtAcctIn_Validated(txtAcctIn, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txtAcctIn_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcctIn.Validated
        If Trim(txtAcctIn.Text) <> "" Then
            sqlstring = "SELECT acdesc  FROM Accountsglaccountmaster WHERE accode='" & Trim(txtAcctIn.Text) & "'"
            gconnection.getDataSet(sqlstring, "Accountsglaccountmaster")
            If gdataset.Tables("Accountsglaccountmaster").Rows.Count > 0 Then
                txtAcctDesc.Text = ""
                txtAcctDesc.Text = Trim(gdataset.Tables("Accountsglaccountmaster").Rows(0).Item("acdesc"))
                txtAcctDesc.ReadOnly = True
                TXT_COSTCENTER.Focus()
            Else
                txtAcctIn.Clear()
                txtAcctDesc.Clear()
                txtAcctIn.Focus()
            End If
        Else
            txtAcctIn.Clear()
            txtAcctDesc.Clear()
            txtAcctIn.Focus()
        End If
    End Sub

    Private Sub txtAcctIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAcctIn.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtAcctIn.Text) = "" Then
                Call cmdAccHelp_Click(sender, e)
            Else
                Call txtAcctIn_Validated(sender, e)
                TXT_COSTCENTER.Focus()
            End If
        End If
    End Sub

    Private Sub txtAcctIn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcctIn.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(txtAcctIn.Text)
            Call cmdAccHelp_Click(sender, e)
        End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  POSMASTER "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUSerId='" & gUsername & " ', AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE POSCode = '" & Trim(CStr(txtPOSCode.Text)) & "'"
            gconnection.dataOperation(3, sqlstring, "POSMASTER")
            Me.CmdClear_Click(sender, e)
            CmdAdd.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  POSMASTER "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUSerId='" & gUsername & " ', AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE POSCode = '" & Trim(CStr(txtPOSCode.Text)) & "'"
            gconnection.dataOperation(4, sqlstring, "POSMASTER")
            Me.CmdClear_Click(sender, e)
            CmdAdd.Text = "Add [F7]"
        End If

    End Sub

    Private Sub opt_Facility_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opt_Facility.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmdAdd.Focus()
        End If
    End Sub

    Private Sub opt_Store_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opt_Store.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmdAdd.Focus()
        End If
    End Sub

    Private Sub cmdPackingAcctin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPackingAcctin.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(ACCODE,'') AS ACCODE,ISNULL(ACDESC,'') AS ACDESC FROM Accountsglaccountmaster  "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(freezeflag,'') <> 'Y'"
        End If
        vform.Field = "ACCODE,ACDESC"
        vform.vFormatstring = "             ACCOUNT CODE                |              ACCOUNT DESCRIPTION                             "
        vform.vCaption = "ACCOUNT MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtPackingAcctin.Text = Trim(vform.keyfield & "")
            Call txtPackingAcctin_Validated(txtPackingAcctin, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_PackingPercent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PackingPercent.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            'If Val(txt_PackingPercent.Text) <= 0 Then
            '    lbl_PackingAcctin.Enabled = False
            '    txtPackingAcctin.Text = ""
            '    txtPackingAcctin.Enabled = False
            '    cmdPackingAcctin.Enabled = False
            '    txtPackingAcctdesc.Text = ""
            '    txtPackingAcctdesc.Enabled = False
            '    opt_Facility.Focus()
            'Else
            '    lbl_PackingAcctin.Enabled = True
            '    txtPackingAcctin.Enabled = True
            '    cmdPackingAcctin.Enabled = True
            '    txtPackingAcctdesc.Enabled = True
            'End If
            txtPackingAcctin.Focus()
        End If
    End Sub

    Private Sub txtPackingAcctin_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPackingAcctin.Validated
        If Trim(txtPackingAcctin.Text) <> "" Then
            sqlstring = "SELECT acdesc  FROM Accountsglaccountmaster WHERE accode='" & Trim(txtPackingAcctin.Text) & "'"
            gconnection.getDataSet(sqlstring, "Accountsglaccountmaster")
            If gdataset.Tables("Accountsglaccountmaster").Rows.Count > 0 Then
                txtPackingAcctdesc.Text = ""
                txtPackingAcctdesc.Text = Trim(gdataset.Tables("Accountsglaccountmaster").Rows(0).Item("acdesc"))
                txtPackingAcctdesc.ReadOnly = True
                opt_Facility.Focus()
            Else
                txtPackingAcctin.Clear()
                txtPackingAcctdesc.Clear()
                txtPackingAcctin.Focus()
            End If
        Else
            txtPackingAcctin.Clear()
            txtPackingAcctdesc.Clear()
        End If
    End Sub

    Private Sub txtPackingAcctin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPackingAcctin.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(txtPackingAcctin.Text)
            Call cmdPackingAcctin_Click(sender, e)
        End If
    End Sub

    Private Sub txtPackingAcctin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPackingAcctin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtPackingAcctin.Text) = "" Then
                Call cmdPackingAcctin_Click(sender, e)
            Else
                Call txtPackingAcctin_Validated(sender, e)
                opt_Facility.Focus()
            End If
        End If
    End Sub

    Private Sub CMD_COST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_COST.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(COSTCENTERCODE,'')AS COSTCODE,ISNULL(COSTCENTERDESC,'') AS COSTDESC FROM AccountsCostCenterMaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(freezeflag,'') <> 'Y'"
        End If
        vform.Field = "COSTCENTERCODE,COSTCENTERDESC"
        vform.vFormatstring = "             COSTCENTER CODE             |              COSTCENTER DESC                                 "
        vform.vCaption = "COSTCENTER MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXT_COSTCENTER.Text = Trim(vform.keyfield & "")
            Call txtAcctIn_Validated(txtAcctIn, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub TXT_COSTCENTER_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_COSTCENTER.Validated
        If Trim(TXT_COSTCENTER.Text) <> "" Then
            sqlstring = "SELECT ISNULL(COSTCENTERCODE,'')AS COSTCODE,ISNULL(COSTCENTERDESC,'') AS COSTDESC FROM AccountsCostCenterMaster WHERE ISNULL(COSTCENTERCODE,'')='" & Trim(TXT_COSTCENTER.Text) & "'"
            gconnection.getDataSet(sqlstring, "Accountsglaccountmaster")
            If gdataset.Tables("Accountsglaccountmaster").Rows.Count > 0 Then
                TXT_COST_DESC.Text = ""
                TXT_COST_DESC.Text = Trim(gdataset.Tables("Accountsglaccountmaster").Rows(0).Item("COSTDESC"))
                TXT_COST_DESC.ReadOnly = True
                txt_PackingPercent.Focus()
            Else
                TXT_COSTCENTER.Text = ""
                TXT_COST_DESC.Clear()
                'TXT_COSTCENTER.Focus()
            End If
        Else
            TXT_COSTCENTER.Clear()
            TXT_COST_DESC.Clear()
            'TXT_COSTCENTER.Focus()
        End If
    End Sub
    Private Sub TXT_COSTCENTER_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_COSTCENTER.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(TXT_COSTCENTER.Text) = "" Then
                Call CMD_COST_Click(sender, e)
                txt_PackingPercent.Focus()
            Else
                txt_PackingPercent.Focus()
            End If
        End If
    End Sub
    Private Sub ssGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssGrid.KeyDownEvent
        Dim I As Integer
        Dim DEPT, TRANS As String
        Dim DOB As Date
        With ssGrid
            If e.keyCode = Keys.Enter Then
                I = .ActiveRow
                If .ActiveCol = 1 Then
                    .Row = I
                    .Col = 1
                    If Trim(.Text) = "" Then
                        Call fillTrans()
                    Else
                        sqlstring = "SELECT ISNULL(USERNAME,'') AS USERNAME FROM POS_VIEW_USERADMIN"
                        sqlstring = sqlstring & " WHERE USERNAME="
                        .Col = 1
                        .Row = I
                        TRANS = .Text
                        sqlstring = sqlstring & " '" & TRANS & "'"
                        gconnection.getDataSet(sqlstring, "TRANS")
                        If gdataset.Tables("TRANS").Rows.Count > 0 Then
                            .Col = 1
                            .Row = I
                            .Text = gdataset.Tables("TRANS").Rows(0).Item("USERNAME")

                            .SetActiveCell(1, I + 1)
                        Else
                            MsgBox("NO SUCH ITEM FOUND")
                            .Text = ""
                            .SetActiveCell(1, I)
                        End If
                    End If
                End If
            End If
            If e.keyCode = Keys.F3 Then
                .DeleteRows(.ActiveRow, 1)
                .SetActiveCell(1, I)
                .Focus()
            End If
        End With

    End Sub
    Private Sub fillTrans()

        Dim sqlstring As String
        Dim vform As New ListOperattion1
        gSQLString = "SELECT USERNAME FROM POS_VIEW_USERADMIN"
        M_WhereCondition = ""
        vform.Field = "USERNAME"
        vform.vFormatstring = "USERNAME                                         "

        vform.vCaption = "USER NAME HELP"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssGrid
                .Col = 1
                .Row = .ActiveRow
                .Text = Trim(vform.keyfield1)
                .SetActiveCell(1, .ActiveRow)
            End With
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub ssGrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssGrid.Advance

    End Sub

    Private Sub TXT_COSTCENTER_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_COSTCENTER.TextChanged

    End Sub
End Class