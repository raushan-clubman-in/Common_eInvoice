Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.IO
Public Class ItemMaster
    Inherits System.Windows.Forms.Form
    Dim ssql, vPromUOM As String
    Dim vconn As New GlobalClass
    Dim promtbool As Boolean
    'Dim vseqno As Double
    Dim vseqno As String
    Dim i As Integer
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents FraRate As System.Windows.Forms.GroupBox
    Friend WithEvents FraGrid As System.Windows.Forms.GroupBox
    Friend WithEvents CmbUOm As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents AxfpSpread1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPROMOT As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OptNo As System.Windows.Forms.RadioButton
    Friend WithEvents optYes As System.Windows.Forms.RadioButton
    Friend WithEvents cmdItemHelp As System.Windows.Forms.Button
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LstPOScode As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtGroupDes As System.Windows.Forms.TextBox
    Friend WithEvents txtTypedes As System.Windows.Forms.TextBox
    Friend WithEvents txtItemType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGroupcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    Friend WithEvents FraPromt As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGroup As System.Windows.Forms.Button
    Friend WithEvents cmdType As System.Windows.Forms.Button
    Friend WithEvents txtBaseRate As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseQty As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseUOM As System.Windows.Forms.TextBox
    Friend WithEvents txtProItem As System.Windows.Forms.TextBox
    Friend WithEvents txtPromRate As System.Windows.Forms.TextBox
    Friend WithEvents txtPromQty As System.Windows.Forms.TextBox
    Friend WithEvents txtPromUOM As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseItem As System.Windows.Forms.TextBox
    Friend WithEvents cmbBaseUOM As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPromtUOM As System.Windows.Forms.ComboBox
    Friend WithEvents cmdPromhelp As System.Windows.Forms.Button
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_UOM As System.Windows.Forms.Label
    Friend WithEvents lbl_SaleRate As System.Windows.Forms.Label
    Friend WithEvents lbl_PurcahseRate As System.Windows.Forms.Label
    Friend WithEvents txtPurchaseRate As System.Windows.Forms.TextBox
    Friend WithEvents btnPromotionalView As System.Windows.Forms.Button
    Friend WithEvents lbl_BaseUOM As System.Windows.Forms.Label
    Friend WithEvents lbl_BaseRate As System.Windows.Forms.Label
    Friend WithEvents cbo_BaseUOM As System.Windows.Forms.ComboBox
    Friend WithEvents txt_BaseRate As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPromotDelete As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents ChkOPENITEMFACILITY As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAcctIn As System.Windows.Forms.TextBox
    Friend WithEvents txtAcctDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmdAccHelp As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TXT_LEDGER As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ItemMaster))
        Me.Label16 = New System.Windows.Forms.Label
        Me.FraRate = New System.Windows.Forms.GroupBox
        Me.txtPurchaseRate = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.CmbUOm = New System.Windows.Forms.ComboBox
        Me.lbl_PurcahseRate = New System.Windows.Forms.Label
        Me.lbl_SaleRate = New System.Windows.Forms.Label
        Me.lbl_UOM = New System.Windows.Forms.Label
        Me.FraGrid = New System.Windows.Forms.GroupBox
        Me.txt_BaseRate = New System.Windows.Forms.TextBox
        Me.cbo_BaseUOM = New System.Windows.Forms.ComboBox
        Me.lbl_BaseRate = New System.Windows.Forms.Label
        Me.lbl_BaseUOM = New System.Windows.Forms.Label
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.FraPromt = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtBaseItem = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtBaseRate = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtBaseQty = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbBaseUOM = New System.Windows.Forms.ComboBox
        Me.txtBaseUOM = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnPromotDelete = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmdPromhelp = New System.Windows.Forms.Button
        Me.cmbPromtUOM = New System.Windows.Forms.ComboBox
        Me.txtProItem = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtPromRate = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtPromQty = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtPromUOM = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXT_LEDGER = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtAcctIn = New System.Windows.Forms.TextBox
        Me.txtAcctDesc = New System.Windows.Forms.TextBox
        Me.cmdAccHelp = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtGroupDes = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtGroupcode = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtShort = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.ChkPROMOT = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.OptNo = New System.Windows.Forms.RadioButton
        Me.optYes = New System.Windows.Forms.RadioButton
        Me.cmdItemHelp = New System.Windows.Forms.Button
        Me.txtItemDesc = New System.Windows.Forms.TextBox
        Me.txtItemCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LstPOScode = New System.Windows.Forms.CheckedListBox
        Me.cmdGroup = New System.Windows.Forms.Button
        Me.cmdType = New System.Windows.Forms.Button
        Me.txtTypedes = New System.Windows.Forms.TextBox
        Me.txtItemType = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnPromotionalView = New System.Windows.Forms.Button
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Cmd_Delete = New System.Windows.Forms.Button
        Me.ChkOPENITEMFACILITY = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.FraRate.SuspendLayout()
        Me.FraGrid.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraPromt.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(432, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(186, 31)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "ITEM MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FraRate
        '
        Me.FraRate.BackColor = System.Drawing.Color.Transparent
        Me.FraRate.Controls.Add(Me.txtPurchaseRate)
        Me.FraRate.Controls.Add(Me.txtRate)
        Me.FraRate.Controls.Add(Me.CmbUOm)
        Me.FraRate.Controls.Add(Me.lbl_PurcahseRate)
        Me.FraRate.Controls.Add(Me.lbl_SaleRate)
        Me.FraRate.Controls.Add(Me.lbl_UOM)
        Me.FraRate.Location = New System.Drawing.Point(88, 440)
        Me.FraRate.Name = "FraRate"
        Me.FraRate.Size = New System.Drawing.Size(856, 88)
        Me.FraRate.TabIndex = 10
        Me.FraRate.TabStop = False
        '
        'txtPurchaseRate
        '
        Me.txtPurchaseRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurchaseRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPurchaseRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurchaseRate.Location = New System.Drawing.Point(192, 40)
        Me.txtPurchaseRate.MaxLength = 10
        Me.txtPurchaseRate.Name = "txtPurchaseRate"
        Me.txtPurchaseRate.Size = New System.Drawing.Size(136, 26)
        Me.txtPurchaseRate.TabIndex = 0
        Me.txtPurchaseRate.Text = ""
        Me.txtPurchaseRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.Wheat
        Me.txtRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(480, 40)
        Me.txtRate.MaxLength = 10
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(152, 26)
        Me.txtRate.TabIndex = 1
        Me.txtRate.Text = ""
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbUOm
        '
        Me.CmbUOm.BackColor = System.Drawing.Color.Wheat
        Me.CmbUOm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUOm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbUOm.Location = New System.Drawing.Point(712, 40)
        Me.CmbUOm.Name = "CmbUOm"
        Me.CmbUOm.Size = New System.Drawing.Size(136, 27)
        Me.CmbUOm.TabIndex = 2
        '
        'lbl_PurcahseRate
        '
        Me.lbl_PurcahseRate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PurcahseRate.ForeColor = System.Drawing.Color.Black
        Me.lbl_PurcahseRate.Location = New System.Drawing.Point(10, 40)
        Me.lbl_PurcahseRate.Name = "lbl_PurcahseRate"
        Me.lbl_PurcahseRate.Size = New System.Drawing.Size(183, 25)
        Me.lbl_PurcahseRate.TabIndex = 3
        Me.lbl_PurcahseRate.Text = "PURCHASE RATE "
        Me.lbl_PurcahseRate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_SaleRate
        '
        Me.lbl_SaleRate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SaleRate.ForeColor = System.Drawing.Color.Black
        Me.lbl_SaleRate.Location = New System.Drawing.Point(344, 40)
        Me.lbl_SaleRate.Name = "lbl_SaleRate"
        Me.lbl_SaleRate.Size = New System.Drawing.Size(136, 25)
        Me.lbl_SaleRate.TabIndex = 4
        Me.lbl_SaleRate.Text = "SALE RATE "
        Me.lbl_SaleRate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_UOM
        '
        Me.lbl_UOM.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UOM.ForeColor = System.Drawing.Color.Black
        Me.lbl_UOM.Location = New System.Drawing.Point(646, 40)
        Me.lbl_UOM.Name = "lbl_UOM"
        Me.lbl_UOM.Size = New System.Drawing.Size(66, 25)
        Me.lbl_UOM.TabIndex = 5
        Me.lbl_UOM.Text = "UOM "
        Me.lbl_UOM.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FraGrid
        '
        Me.FraGrid.BackColor = System.Drawing.Color.Transparent
        Me.FraGrid.Controls.Add(Me.txt_BaseRate)
        Me.FraGrid.Controls.Add(Me.cbo_BaseUOM)
        Me.FraGrid.Controls.Add(Me.lbl_BaseRate)
        Me.FraGrid.Controls.Add(Me.lbl_BaseUOM)
        Me.FraGrid.Controls.Add(Me.ssGrid)
        Me.FraGrid.Location = New System.Drawing.Point(88, 360)
        Me.FraGrid.Name = "FraGrid"
        Me.FraGrid.Size = New System.Drawing.Size(864, 216)
        Me.FraGrid.TabIndex = 9
        Me.FraGrid.TabStop = False
        Me.FraGrid.Visible = False
        '
        'txt_BaseRate
        '
        Me.txt_BaseRate.BackColor = System.Drawing.Color.Wheat
        Me.txt_BaseRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BaseRate.Location = New System.Drawing.Point(640, 16)
        Me.txt_BaseRate.MaxLength = 10
        Me.txt_BaseRate.Name = "txt_BaseRate"
        Me.txt_BaseRate.Size = New System.Drawing.Size(160, 26)
        Me.txt_BaseRate.TabIndex = 1
        Me.txt_BaseRate.Text = ""
        Me.txt_BaseRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbo_BaseUOM
        '
        Me.cbo_BaseUOM.BackColor = System.Drawing.Color.Wheat
        Me.cbo_BaseUOM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_BaseUOM.Location = New System.Drawing.Point(184, 17)
        Me.cbo_BaseUOM.Name = "cbo_BaseUOM"
        Me.cbo_BaseUOM.Size = New System.Drawing.Size(168, 27)
        Me.cbo_BaseUOM.TabIndex = 0
        '
        'lbl_BaseRate
        '
        Me.lbl_BaseRate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BaseRate.ForeColor = System.Drawing.Color.Black
        Me.lbl_BaseRate.Location = New System.Drawing.Point(496, 16)
        Me.lbl_BaseRate.Name = "lbl_BaseRate"
        Me.lbl_BaseRate.Size = New System.Drawing.Size(136, 25)
        Me.lbl_BaseRate.TabIndex = 2
        Me.lbl_BaseRate.Text = "BASE RATE "
        Me.lbl_BaseRate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_BaseUOM
        '
        Me.lbl_BaseUOM.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BaseUOM.ForeColor = System.Drawing.Color.Black
        Me.lbl_BaseUOM.Location = New System.Drawing.Point(48, 17)
        Me.lbl_BaseUOM.Name = "lbl_BaseUOM"
        Me.lbl_BaseUOM.Size = New System.Drawing.Size(124, 25)
        Me.lbl_BaseUOM.TabIndex = 1
        Me.lbl_BaseUOM.Text = "BASE UOM "
        Me.lbl_BaseUOM.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ssGrid
        '
        Me.ssGrid.ContainingControl = Me
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(16, 48)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(824, 156)
        Me.ssGrid.TabIndex = 2
        '
        'FraPromt
        '
        Me.FraPromt.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.FraPromt.BackgroundImage = CType(resources.GetObject("FraPromt.BackgroundImage"), System.Drawing.Image)
        Me.FraPromt.Controls.Add(Me.Label10)
        Me.FraPromt.Controls.Add(Me.mskToDate)
        Me.FraPromt.Controls.Add(Me.mskFromDate)
        Me.FraPromt.Controls.Add(Me.GroupBox5)
        Me.FraPromt.Controls.Add(Me.GroupBox3)
        Me.FraPromt.Controls.Add(Me.Label14)
        Me.FraPromt.Controls.Add(Me.Label13)
        Me.FraPromt.Controls.Add(Me.GroupBox4)
        Me.FraPromt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraPromt.Location = New System.Drawing.Point(80, 1000)
        Me.FraPromt.Name = "FraPromt"
        Me.FraPromt.Size = New System.Drawing.Size(872, 670)
        Me.FraPromt.TabIndex = 1
        Me.FraPromt.TabStop = False
        Me.FraPromt.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Maroon
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(872, 32)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "PROMOTIONAL DETAILS "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mskToDate
        '
        Me.mskToDate.CalendarMonthBackground = System.Drawing.Color.Wheat
        Me.mskToDate.CustomFormat = "dd-MM-yyyy"
        Me.mskToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskToDate.Location = New System.Drawing.Point(624, 152)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(152, 26)
        Me.mskToDate.TabIndex = 1
        '
        'mskFromDate
        '
        Me.mskFromDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(296, 152)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(144, 26)
        Me.mskFromDate.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.txtBaseItem)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txtBaseRate)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtBaseQty)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.cmbBaseUOM)
        Me.GroupBox5.Controls.Add(Me.txtBaseUOM)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(24, 256)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(408, 176)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "BASE DETAILS"
        '
        'txtBaseItem
        '
        Me.txtBaseItem.BackColor = System.Drawing.Color.Wheat
        Me.txtBaseItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBaseItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseItem.Location = New System.Drawing.Point(184, 24)
        Me.txtBaseItem.MaxLength = 10
        Me.txtBaseItem.Name = "txtBaseItem"
        Me.txtBaseItem.Size = New System.Drawing.Size(192, 26)
        Me.txtBaseItem.TabIndex = 0
        Me.txtBaseItem.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(24, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 25)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "ITEM CODE :"
        '
        'txtBaseRate
        '
        Me.txtBaseRate.BackColor = System.Drawing.Color.Wheat
        Me.txtBaseRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBaseRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseRate.Location = New System.Drawing.Point(184, 135)
        Me.txtBaseRate.MaxLength = 9
        Me.txtBaseRate.Name = "txtBaseRate"
        Me.txtBaseRate.Size = New System.Drawing.Size(192, 26)
        Me.txtBaseRate.TabIndex = 3
        Me.txtBaseRate.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(26, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 25)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "ITEM RATE :"
        '
        'txtBaseQty
        '
        Me.txtBaseQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBaseQty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseQty.Location = New System.Drawing.Point(184, 98)
        Me.txtBaseQty.MaxLength = 9
        Me.txtBaseQty.Name = "txtBaseQty"
        Me.txtBaseQty.Size = New System.Drawing.Size(192, 26)
        Me.txtBaseQty.TabIndex = 2
        Me.txtBaseQty.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(39, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 25)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "BASE QTY :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(37, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 25)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "BASE UOM :"
        '
        'cmbBaseUOM
        '
        Me.cmbBaseUOM.BackColor = System.Drawing.Color.Wheat
        Me.cmbBaseUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBaseUOM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBaseUOM.Location = New System.Drawing.Point(184, 62)
        Me.cmbBaseUOM.MaxLength = 20
        Me.cmbBaseUOM.Name = "cmbBaseUOM"
        Me.cmbBaseUOM.Size = New System.Drawing.Size(192, 27)
        Me.cmbBaseUOM.TabIndex = 2
        Me.cmbBaseUOM.Visible = False
        '
        'txtBaseUOM
        '
        Me.txtBaseUOM.BackColor = System.Drawing.Color.Wheat
        Me.txtBaseUOM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseUOM.Location = New System.Drawing.Point(184, 61)
        Me.txtBaseUOM.MaxLength = 10
        Me.txtBaseUOM.Name = "txtBaseUOM"
        Me.txtBaseUOM.ReadOnly = True
        Me.txtBaseUOM.Size = New System.Drawing.Size(192, 26)
        Me.txtBaseUOM.TabIndex = 1
        Me.txtBaseUOM.Text = ""
        Me.txtBaseUOM.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnPromotDelete)
        Me.GroupBox3.Controls.Add(Me.cmdOk)
        Me.GroupBox3.Controls.Add(Me.cmdCancel)
        Me.GroupBox3.Location = New System.Drawing.Point(256, 496)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 64)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'btnPromotDelete
        '
        Me.btnPromotDelete.BackColor = System.Drawing.Color.ForestGreen
        Me.btnPromotDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPromotDelete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromotDelete.ForeColor = System.Drawing.Color.White
        Me.btnPromotDelete.Image = CType(resources.GetObject("btnPromotDelete.Image"), System.Drawing.Image)
        Me.btnPromotDelete.Location = New System.Drawing.Point(144, 16)
        Me.btnPromotDelete.Name = "btnPromotDelete"
        Me.btnPromotDelete.Size = New System.Drawing.Size(104, 32)
        Me.btnPromotDelete.TabIndex = 322
        Me.btnPromotDelete.Text = " Delete [F2]"
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.Color.White
        Me.cmdOk.Image = CType(resources.GetObject("cmdOk.Image"), System.Drawing.Image)
        Me.cmdOk.Location = New System.Drawing.Point(24, 16)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(104, 32)
        Me.cmdOk.TabIndex = 323
        Me.cmdOk.Text = "Save [F10]"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.White
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(264, 16)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(104, 32)
        Me.cmdCancel.TabIndex = 321
        Me.cmdCancel.Text = "Exit[F12]"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(464, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 25)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "EFFECT TO :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(72, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(218, 25)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "WITH EFFECT FROM :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmdPromhelp)
        Me.GroupBox4.Controls.Add(Me.cmbPromtUOM)
        Me.GroupBox4.Controls.Add(Me.txtProItem)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtPromRate)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtPromQty)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.txtPromUOM)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(440, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 176)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PROMOTINAL DETAILS"
        '
        'cmdPromhelp
        '
        Me.cmdPromhelp.Image = CType(resources.GetObject("cmdPromhelp.Image"), System.Drawing.Image)
        Me.cmdPromhelp.Location = New System.Drawing.Point(360, 24)
        Me.cmdPromhelp.Name = "cmdPromhelp"
        Me.cmdPromhelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdPromhelp.TabIndex = 5
        '
        'cmbPromtUOM
        '
        Me.cmbPromtUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPromtUOM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPromtUOM.Location = New System.Drawing.Point(192, 57)
        Me.cmbPromtUOM.MaxLength = 20
        Me.cmbPromtUOM.Name = "cmbPromtUOM"
        Me.cmbPromtUOM.Size = New System.Drawing.Size(192, 27)
        Me.cmbPromtUOM.TabIndex = 2
        '
        'txtProItem
        '
        Me.txtProItem.BackColor = System.Drawing.Color.Wheat
        Me.txtProItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProItem.Location = New System.Drawing.Point(192, 24)
        Me.txtProItem.MaxLength = 10
        Me.txtProItem.Name = "txtProItem"
        Me.txtProItem.Size = New System.Drawing.Size(168, 26)
        Me.txtProItem.TabIndex = 0
        Me.txtProItem.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(16, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(160, 25)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "PROMT. CODE :"
        '
        'txtPromRate
        '
        Me.txtPromRate.BackColor = System.Drawing.Color.Wheat
        Me.txtPromRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPromRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromRate.Location = New System.Drawing.Point(192, 130)
        Me.txtPromRate.MaxLength = 9
        Me.txtPromRate.Name = "txtPromRate"
        Me.txtPromRate.Size = New System.Drawing.Size(192, 26)
        Me.txtPromRate.TabIndex = 4
        Me.txtPromRate.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(16, 135)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(160, 25)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "PROMT. RATE :"
        '
        'txtPromQty
        '
        Me.txtPromQty.BackColor = System.Drawing.Color.Wheat
        Me.txtPromQty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromQty.Location = New System.Drawing.Point(192, 95)
        Me.txtPromQty.MaxLength = 9
        Me.txtPromQty.Name = "txtPromQty"
        Me.txtPromQty.Size = New System.Drawing.Size(192, 26)
        Me.txtPromQty.TabIndex = 3
        Me.txtPromQty.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(28, 98)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(148, 25)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "PROMT. QTY :"
        '
        'txtPromUOM
        '
        Me.txtPromUOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPromUOM.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromUOM.Location = New System.Drawing.Point(192, 57)
        Me.txtPromUOM.MaxLength = 10
        Me.txtPromUOM.Name = "txtPromUOM"
        Me.txtPromUOM.Size = New System.Drawing.Size(192, 26)
        Me.txtPromUOM.TabIndex = 1
        Me.txtPromUOM.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(28, 61)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(148, 25)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "PROMT. UOM :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TXT_LEDGER)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtAcctIn)
        Me.GroupBox1.Controls.Add(Me.txtAcctDesc)
        Me.GroupBox1.Controls.Add(Me.cmdAccHelp)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtGroupDes)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtGroupcode)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 208)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'TXT_LEDGER
        '
        Me.TXT_LEDGER.BackColor = System.Drawing.Color.Wheat
        Me.TXT_LEDGER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_LEDGER.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LEDGER.Location = New System.Drawing.Point(184, 168)
        Me.TXT_LEDGER.MaxLength = 100
        Me.TXT_LEDGER.Name = "TXT_LEDGER"
        Me.TXT_LEDGER.Size = New System.Drawing.Size(200, 26)
        Me.TXT_LEDGER.TabIndex = 6
        Me.TXT_LEDGER.Text = ""
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(27, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(148, 25)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "ITEM CODE"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAcctIn
        '
        Me.txtAcctIn.BackColor = System.Drawing.Color.Wheat
        Me.txtAcctIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAcctIn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctIn.Location = New System.Drawing.Point(184, 170)
        Me.txtAcctIn.MaxLength = 10
        Me.txtAcctIn.Name = "txtAcctIn"
        Me.txtAcctIn.Size = New System.Drawing.Size(200, 26)
        Me.txtAcctIn.TabIndex = 6
        Me.txtAcctIn.Text = ""
        Me.txtAcctIn.Visible = False
        '
        'txtAcctDesc
        '
        Me.txtAcctDesc.BackColor = System.Drawing.Color.Wheat
        Me.txtAcctDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAcctDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcctDesc.Location = New System.Drawing.Point(625, 171)
        Me.txtAcctDesc.MaxLength = 35
        Me.txtAcctDesc.Name = "txtAcctDesc"
        Me.txtAcctDesc.ReadOnly = True
        Me.txtAcctDesc.Size = New System.Drawing.Size(223, 26)
        Me.txtAcctDesc.TabIndex = 30
        Me.txtAcctDesc.Text = ""
        Me.txtAcctDesc.Visible = False
        '
        'cmdAccHelp
        '
        Me.cmdAccHelp.Image = CType(resources.GetObject("cmdAccHelp.Image"), System.Drawing.Image)
        Me.cmdAccHelp.Location = New System.Drawing.Point(384, 169)
        Me.cmdAccHelp.Name = "cmdAccHelp"
        Me.cmdAccHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdAccHelp.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "GROUP CODE "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtGroupDes
        '
        Me.txtGroupDes.BackColor = System.Drawing.Color.Wheat
        Me.txtGroupDes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGroupDes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupDes.Location = New System.Drawing.Point(624, 132)
        Me.txtGroupDes.MaxLength = 50
        Me.txtGroupDes.Name = "txtGroupDes"
        Me.txtGroupDes.Size = New System.Drawing.Size(224, 26)
        Me.txtGroupDes.TabIndex = 6
        Me.txtGroupDes.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(456, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 25)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "DESCRIPTION "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtGroupcode
        '
        Me.txtGroupcode.BackColor = System.Drawing.Color.Wheat
        Me.txtGroupcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGroupcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupcode.Location = New System.Drawing.Point(184, 133)
        Me.txtGroupcode.MaxLength = 10
        Me.txtGroupcode.Name = "txtGroupcode"
        Me.txtGroupcode.Size = New System.Drawing.Size(104, 26)
        Me.txtGroupcode.TabIndex = 5
        Me.txtGroupcode.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(-10, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(184, 25)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "ACCT LEDGER"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(456, 173)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(160, 25)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "DESCRIPTION "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label18.Visible = False
        '
        'txtShort
        '
        Me.txtShort.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtShort.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShort.Location = New System.Drawing.Point(272, 80)
        Me.txtShort.MaxLength = 10
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(200, 26)
        Me.txtShort.TabIndex = 2
        Me.txtShort.Text = ""
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(115, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(148, 25)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "SHORT NAME "
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ChkPROMOT
        '
        Me.ChkPROMOT.BackColor = System.Drawing.Color.Transparent
        Me.ChkPROMOT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChkPROMOT.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPROMOT.ForeColor = System.Drawing.Color.Black
        Me.ChkPROMOT.Location = New System.Drawing.Point(336, 584)
        Me.ChkPROMOT.Name = "ChkPROMOT"
        Me.ChkPROMOT.Size = New System.Drawing.Size(112, 24)
        Me.ChkPROMOT.TabIndex = 11
        Me.ChkPROMOT.Text = "PROMOTIONAL "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.OptNo)
        Me.GroupBox2.Controls.Add(Me.optYes)
        Me.GroupBox2.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(608, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 72)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MULTI RATE STATUS "
        '
        'OptNo
        '
        Me.OptNo.BackColor = System.Drawing.Color.Transparent
        Me.OptNo.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptNo.ForeColor = System.Drawing.Color.Black
        Me.OptNo.Location = New System.Drawing.Point(128, 40)
        Me.OptNo.Name = "OptNo"
        Me.OptNo.Size = New System.Drawing.Size(56, 16)
        Me.OptNo.TabIndex = 1
        Me.OptNo.Text = "NO"
        '
        'optYes
        '
        Me.optYes.BackColor = System.Drawing.Color.Transparent
        Me.optYes.Checked = True
        Me.optYes.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optYes.ForeColor = System.Drawing.Color.Black
        Me.optYes.Location = New System.Drawing.Point(32, 40)
        Me.optYes.Name = "optYes"
        Me.optYes.Size = New System.Drawing.Size(64, 16)
        Me.optYes.TabIndex = 0
        Me.optYes.TabStop = True
        Me.optYes.Text = "YES"
        '
        'cmdItemHelp
        '
        Me.cmdItemHelp.Image = CType(resources.GetObject("cmdItemHelp.Image"), System.Drawing.Image)
        Me.cmdItemHelp.Location = New System.Drawing.Point(368, 40)
        Me.cmdItemHelp.Name = "cmdItemHelp"
        Me.cmdItemHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdItemHelp.TabIndex = 21
        '
        'txtItemDesc
        '
        Me.txtItemDesc.BackColor = System.Drawing.Color.Wheat
        Me.txtItemDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc.Location = New System.Drawing.Point(712, 40)
        Me.txtItemDesc.MaxLength = 50
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(224, 26)
        Me.txtItemDesc.TabIndex = 1
        Me.txtItemDesc.Text = ""
        '
        'txtItemCode
        '
        Me.txtItemCode.BackColor = System.Drawing.Color.Wheat
        Me.txtItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode.Location = New System.Drawing.Point(272, 40)
        Me.txtItemCode.MaxLength = 10
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(96, 26)
        Me.txtItemCode.TabIndex = 0
        Me.txtItemCode.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(544, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "DESCRIPTION "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(120, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(544, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 25)
        Me.Label7.TabIndex = 313
        Me.Label7.Text = "DESCRIPTION "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LstPOScode
        '
        Me.LstPOScode.BackColor = System.Drawing.Color.Wheat
        Me.LstPOScode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstPOScode.Location = New System.Drawing.Point(272, 256)
        Me.LstPOScode.Name = "LstPOScode"
        Me.LstPOScode.Size = New System.Drawing.Size(304, 106)
        Me.LstPOScode.TabIndex = 9
        '
        'cmdGroup
        '
        Me.cmdGroup.Image = CType(resources.GetObject("cmdGroup.Image"), System.Drawing.Image)
        Me.cmdGroup.Location = New System.Drawing.Point(376, 157)
        Me.cmdGroup.Name = "cmdGroup"
        Me.cmdGroup.Size = New System.Drawing.Size(23, 26)
        Me.cmdGroup.TabIndex = 27
        '
        'cmdType
        '
        Me.cmdType.Image = CType(resources.GetObject("cmdType.Image"), System.Drawing.Image)
        Me.cmdType.Location = New System.Drawing.Point(376, 120)
        Me.cmdType.Name = "cmdType"
        Me.cmdType.Size = New System.Drawing.Size(23, 26)
        Me.cmdType.TabIndex = 26
        '
        'txtTypedes
        '
        Me.txtTypedes.BackColor = System.Drawing.Color.Wheat
        Me.txtTypedes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTypedes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypedes.Location = New System.Drawing.Point(712, 117)
        Me.txtTypedes.MaxLength = 50
        Me.txtTypedes.Name = "txtTypedes"
        Me.txtTypedes.Size = New System.Drawing.Size(224, 26)
        Me.txtTypedes.TabIndex = 4
        Me.txtTypedes.Text = ""
        '
        'txtItemType
        '
        Me.txtItemType.BackColor = System.Drawing.Color.Wheat
        Me.txtItemType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemType.Location = New System.Drawing.Point(272, 120)
        Me.txtItemType.MaxLength = 10
        Me.txtItemType.Name = "txtItemType"
        Me.txtItemType.Size = New System.Drawing.Size(104, 26)
        Me.txtItemType.TabIndex = 3
        Me.txtItemType.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(160, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "POS CODE "
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(127, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "ITEM TYPE "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnPromotionalView
        '
        Me.btnPromotionalView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPromotionalView.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromotionalView.Location = New System.Drawing.Point(480, 584)
        Me.btnPromotionalView.Name = "btnPromotionalView"
        Me.btnPromotionalView.Size = New System.Drawing.Size(48, 24)
        Me.btnPromotionalView.TabIndex = 314
        Me.btnPromotionalView.Text = "view"
        Me.btnPromotionalView.Visible = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(568, 584)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 315
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(208, 624)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 321
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(544, 624)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 319
        Me.CmdView.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(432, 624)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 320
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'CmdAdd
        '
        Me.CmdAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.ForeColor = System.Drawing.Color.White
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.Location = New System.Drawing.Point(320, 624)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(104, 32)
        Me.CmdAdd.TabIndex = 318
        Me.CmdAdd.Text = "Add [F7]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(768, 624)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 317
        Me.cmdexit.Text = "Exit[F11]"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Location = New System.Drawing.Point(176, 608)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox6.TabIndex = 316
        Me.GroupBox6.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(392, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 22)
        Me.Label9.TabIndex = 322
        Me.Label9.Text = "[F4]"
        '
        'Cmd_Delete
        '
        Me.Cmd_Delete.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Delete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.Cmd_Delete.Image = CType(resources.GetObject("Cmd_Delete.Image"), System.Drawing.Image)
        Me.Cmd_Delete.Location = New System.Drawing.Point(656, 624)
        Me.Cmd_Delete.Name = "Cmd_Delete"
        Me.Cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Delete.TabIndex = 323
        Me.Cmd_Delete.Text = "Delete[F9]"
        '
        'ChkOPENITEMFACILITY
        '
        Me.ChkOPENITEMFACILITY.BackColor = System.Drawing.Color.Transparent
        Me.ChkOPENITEMFACILITY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ChkOPENITEMFACILITY.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkOPENITEMFACILITY.ForeColor = System.Drawing.Color.Black
        Me.ChkOPENITEMFACILITY.Location = New System.Drawing.Point(178, 584)
        Me.ChkOPENITEMFACILITY.Name = "ChkOPENITEMFACILITY"
        Me.ChkOPENITEMFACILITY.Size = New System.Drawing.Size(144, 24)
        Me.ChkOPENITEMFACILITY.TabIndex = 324
        Me.ChkOPENITEMFACILITY.Text = "OPEN ITEM FACILITY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(176, 672)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(656, 18)
        Me.Label6.TabIndex = 417
        Me.Label6.Text = "Press F4 for HELP / Press F3 for DELETE item in grid /Press ENTER key to navigate" & _
        ""
        '
        'ItemMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 18)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 702)
        Me.ControlBox = False
        Me.Controls.Add(Me.FraPromt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtItemType)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.txtTypedes)
        Me.Controls.Add(Me.txtShort)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ChkOPENITEMFACILITY)
        Me.Controls.Add(Me.Cmd_Delete)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.ChkPROMOT)
        Me.Controls.Add(Me.cmdItemHelp)
        Me.Controls.Add(Me.btnPromotionalView)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.FraRate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LstPOScode)
        Me.Controls.Add(Me.cmdGroup)
        Me.Controls.Add(Me.cmdType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FraGrid)
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.KeyPreview = True
        Me.Name = "ItemMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEM MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FraRate.ResumeLayout(False)
        Me.FraGrid.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraPromt.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Call clearform(Me) '''--> Clear All Form Object
        txtRate.Text = ""
        txtPurchaseRate.Text = ""
        TXT_LEDGER.Text = ""
        txtPromQty.Text = ""
        txtPromUOM.Text = ""
        txtBaseUOM.Text = ""
        txtBaseItem.Text = ""
        txtAcctDesc.Text = ""
        txtAcctIn.Text = ""
        txtProItem.Text = ""
        txt_BaseRate.Text = ""
        cmdItemHelp.Enabled = True
        txtItemType.ReadOnly = False
        txtItemCode.ReadOnly = False
        txtGroupcode.ReadOnly = False
        ChkPROMOT.Checked = False
        ChkOPENITEMFACILITY.Checked = False
        FraRate.Visible = False
        ssGrid.Visible = True
        FraGrid.Visible = True
        optYes.Checked = False
        OptNo.Checked = True
        CmbUOm.Items.Clear()
        LstPOScode.Items.Clear()
        cbo_BaseUOM.Items.Clear()
        cmbBaseUOM.Items.Clear()
        txtBaseQty.Text = 1
        txtBaseRate.Text = 0
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        CmdAdd.Text = "Add [F7]"
        ssGrid.SetActiveCell(1, 1)
        ssGrid.ClearRange(1, 1, -1, -1, True)
        Call FillPOS() '''--> Fill All POS Location
        Call FillUOM() ''' --> Fill All UOM 
        FraGrid.Visible = False
        FraRate.Visible = True
        cbo_BaseUOM.DropDownStyle = ComboBoxStyle.DropDownList
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txtItemCode.Focus()
    End Sub

    Private Sub ItemMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbo_BaseUOM.DropDownStyle = ComboBoxStyle.DropDownList
        itemmasterbool = True
        optYes.Checked = False
        OptNo.Checked = True
        FraGrid.Visible = True
        FraRate.Visible = False
        FraPromt.Visible = False
        ChkPROMOT.Checked = False
        ssGrid.SetActiveCell(1, 1)
        ChkOPENITEMFACILITY.Checked = False
        txtBaseUOM.BackColor = Color.White
        txtItemType.ReadOnly = False
        txtItemCode.ReadOnly = False
        txtGroupcode.ReadOnly = False
        cmdItemHelp.Enabled = True
        Call FillPOS() '''--> Fill All POS Location
        Call FillUOM() ''' --> Fill All UOM 
        FraGrid.Visible = False
        FraRate.Visible = True
        FraPromt.Top = 1000
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txtItemCode.Focus()
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='" & GModule & "' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        vconn.getDataSet(SQLSTRING, "USER")
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

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If MePromValidate() = False Then Exit Sub
        promtbool = True
        ChkPROMOT.Checked = True
        FraPromt.Visible = False
    End Sub
    Private Function MePromValidate() As Boolean
        MePromValidate = True
        If CDate(mskFromDate.Value) > CDate(mskToDate.Value) Then
            MePromValidate = False
            MsgBox("To Date should Greater than From Date ", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            mskToDate.Focus()
            Exit Function
        End If
        If Trim(txtBaseItem.Text) = "" Then
            MePromValidate = False
            MsgBox("Base Item Code Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            txtItemCode.Focus()
            Exit Function
        End If
        If Trim(txtProItem.Text) = "" Then
            MePromValidate = False
            MsgBox("Promotional Item Code Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            txtProItem.Focus()
            Exit Function
        End If
        If Val(txtPromQty.Text) = 0 Then
            MePromValidate = False
            MsgBox("Promotional Qty Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            txtPromQty.Focus()
            Exit Function
        End If
        If optYes.Checked = True Then
            If Trim(cmbBaseUOM.Text) = "" Then
                MePromValidate = False
                MsgBox("Base UOM Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                cmbBaseUOM.Focus()
                Exit Function
            End If
            If Val(txtBaseQty.Text) = 0 Then
                MePromValidate = False
                MsgBox("Base Qty Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                txtBaseQty.Focus()
                Exit Function
            End If
        Else
            If Trim(txtBaseUOM.Text) = "" Then
                MePromValidate = False
                MsgBox("Base UOM Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                txtBaseUOM.Focus()
                Exit Function
            End If
            If Val(txtBaseQty.Text) = 0 Then
                MePromValidate = False
                MsgBox("Base Qty Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                txtBaseQty.Focus()
                Exit Function
            End If
        End If
        If cmbPromtUOM.Visible = True Then
            If Trim(cmbPromtUOM.Text) = "" Then
                MePromValidate = False
                MsgBox("Promotional UOM Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                cmbPromtUOM.Focus()
                Exit Function
            End If
        Else
            If Trim(txtPromUOM.Text) = "" Then
                MePromValidate = False
                MsgBox("Promotional UOM Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                txtPromUOM.Focus()
                Exit Function
            End If
        End If
        If Val(txtPromQty.Text) = 0 Then
            MePromValidate = False
            MsgBox("Promotional Qty Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            txtPromQty.Focus()
            Exit Function
        End If
        'If Val(txtPromRate.Text) = 0 Then
        '    MePromValidate = False
        '    MsgBox("Promotional Rate Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
        '    txtPromRate.Focus()
        '    Exit Function
        'End If
    End Function

    Private Sub cmdItemHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdItemHelp.Click
        gSQLString = "SELECT  ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMDESC,'') FROM ITEMMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        Dim vform As New ListOperattion1
        vform.Field = "ITEMDESC,ITEMCODE"
        vform.vFormatstring = "  ITEM CODE         |                               ITEM DESCRIPTION                             "
        vform.vCaption = " ITEM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtItemCode.Text = Trim(vform.keyfield & "")
            Call txtItemCode_Validated(txtItemCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub cmdGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGroup.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(GROUPDESC,'') AS GROUPDESC FROM groupmaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(Freeze,'') <> 'Y'"
        End If
        vform.Field = "GROUPCODE,GROUPDESC"
        vform.vFormatstring = "   GROUPCODE        |                               GROUP DESCRIPTION                             "
        vform.vCaption = "GROUP MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtGroupcode.Text = Trim(vform.keyfield & "")
            Call txtGroupcode_Validated(txtGroupcode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txtItemType_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemType.Validated
        If txtItemType.Text <> "" Then
            ssql = "SELECT ItemTypeDesc FROM ItemTypeMaster WHERE ItemTypeCode='" & Trim(txtItemType.Text) & "' AND ISNULL(Freeze,'') <> 'Y'"
            vconn.getDataSet(ssql, "ItemTypeMaster")
            If gdataset.Tables("ItemTypeMaster").Rows.Count > 0 Then
                txtTypedes.Text = ""
                txtTypedes.Text = Trim(gdataset.Tables("ItemTypeMaster").Rows(0).Item("ItemTypeDesc"))
                txtTypedes.ReadOnly = True
                txtGroupcode.Focus()
            Else
                txtItemType.Clear()
                txtTypedes.Clear()
                txtItemType.Focus()
            End If
        Else
            txtTypedes.Clear()
        End If
    End Sub
    Private Sub txtItemCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemCode.Validated
        Dim vTypeseqno, vGroupseqno As Double
        Dim dt As DataTable
        Dim vString, VarPOSCODE() As String
        Dim j As Integer
        If Trim(txtItemCode.Text) <> "" Then
            vseqno = GetSeqno(Trim(txtItemCode.Text))
            '''******************* Fetch the ITEMMASTER *************************************************************''
            ssql = "SELECT ISNULL(LEDGERNAME,'') AS LEDGERNAME,ISNULL(ITEMDESC,'') AS ITEMDESC,ISNULL(SHORTNAME,'') AS SHORTNAME,ISNULL(ITEMTYPECODE,'') AS ITEMTYPECODE,ISNULL(BASEUOMSTD,'') as BASEUOMSTD,"
            ssql = ssql & " ISNULL(BASERATESTD,'0.00') as BASERATESTD,ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(FREEZE,'') AS FREEZE,ISNULL(ADDDATETIME,GETDATE()) AS ADDDATETIME,"
            ssql = ssql & " ISNULL(MULTIRATE,'') AS MULTIRATE,ISNULL(PROMOTIONAL,'') AS PROMOTIONAL,ISNULL(BASEUOM,'') AS BASEUOM,ISNULL(BASEQTY,0) AS BASEQTY,"
            ssql = ssql & " ISNULL(BASERATE,0) AS BASERATE,ISNULL(STARTINGDATE,GETDATE()) AS STARTINGDATE,ISNULL(ENDINGDATE,GETDATE()) AS ENDINGDATE,"
            ssql = ssql & " ISNULL(PROMUOM,'') AS PROMUOM,ISNULL(PROMQTY,0) AS PROMQTY,ISNULL(PROMRATE,0) AS PROMRATE,ISNULL(PROMITEMCODE,'') AS PROMITEMCODE,ISNULL(OPENFACILITY,'') AS OPENFACILITY,ISNULL(SALESACCTIN,'') AS SALESACCTIN "
            'ssql = ssql & " FROM ItemMaster WHERE ItemCodeSeqno=" & (vseqno)
            ssql = ssql & " FROM ItemMaster WHERE ItemCode='" & txtItemCode.Text & "'"

            vconn.getDataSet(ssql, "ItemMaster")
            If gdataset.Tables("ItemMaster").Rows.Count > 0 Then
                Call FillUOM() '''--> Fill All UOM 
                txtItemDesc.Text = ""
                txtItemDesc.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("ITEMDESC"))
                txtAcctIn.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("SALESACCTIN"))
                txtShort.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("SHORTNAME"))
                txtItemType.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("ITEMTYPECODE"))
                vTypeseqno = GetSeqno(txtItemType.Text)
                TXT_LEDGER.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("LEDGERNAME"))
                ssql = "SELECT ISNULL(ITEMTYPEDESC,'') AS ITEMTYPEDESC FROM ItemTypeMaster WHERE ItemTypeSeqno=" & Val(vTypeseqno)
                vString = ""
                vString = vconn.getvalue(ssql)
                txtTypedes.Text = Trim(vString)
                txtGroupcode.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("GROUPCODE"))
                vGroupseqno = GetSeqno(txtGroupcode.Text)
                ssql = "SELECT ISNULL(GROUPDESC,'') AS GROUPDESC FROM GroupMaster WHERE  GroupSeqno=" & Val(vGroupseqno)
                vString = ""
                vString = vconn.getvalue(ssql)
                txtGroupDes.Text = Trim(vString)
                If gdataset.Tables("ItemMaster").Rows(0).Item("FREEZE") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("ItemMaster").Rows(0).Item("ADDDATETIME")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                txtItemCode.ReadOnly = True
                txtTypedes.ReadOnly = True
                txtGroupDes.ReadOnly = True
                cmdItemHelp.Enabled = False
                CmdAdd.Text = "Update[F7]"
                '''******************** This is for POSMENULINK **********************************************************''
                ssql = "SELECT * FROM POSmenulink WHERE ItemcodE='" & txtItemCode.Text & "'"
                vconn.getDataSet(ssql, "POSMenuLink")
                If gdataset.Tables("PosMenuLink").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("PosMenuLink").Rows.Count - 1
                        For j = 0 To LstPOScode.Items.Count - 1
                            VarPOSCODE = Split(Trim(LstPOScode.Items(j)), "[")
                            If Trim(gdataset.Tables("PosMenuLink").Rows(i).Item("POS")) = Trim(VarPOSCODE(0)) Then
                                LstPOScode.SetItemChecked(j, True)
                                LstPOScode.SelectedItem = gdataset.Tables("PosMenuLink").Rows(0).Item("POS")
                            End If
                        Next j
                    Next
                End If
                '''****************** Fetch ITEMRATE form RATEMASTER if Multirate is Yes *****************************''
                If Trim(gdataset.Tables("ItemMaster").Rows(0).Item("MULTIRATE")) = "Y" Then
                    optYes.Checked = True
                    FraRate.Visible = False
                    FraGrid.Visible = True
                    cbo_BaseUOM.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_BaseUOM.Text = gdataset.Tables("ItemMaster").Rows(0).Item("BASEUOMSTD")
                    txt_BaseRate.Text = Format(Val(gdataset.Tables("ItemMaster").Rows(0).Item("BASERATESTD")), "0.00")
                    cbo_BaseUOM.DropDownStyle = ComboBoxStyle.DropDownList
                    With ssGrid
                        ssql = "SELECT ISNULL(UOM,'') AS UOM,ISNULL(ITEMRATE,0) AS ITEMRATE FROM RateMaster WHERE Itemcodeseqno=" & (vseqno) & " AND ISNULL(ENDINGDATE,'')='' "
                        vconn.getDataSet(ssql, "RateMaster")
                        If gdataset.Tables("RateMaster").Rows.Count > 0 Then
                            For i = 0 To gdataset.Tables("RateMaster").Rows.Count - 1
                                Call GridUOM(i + 1) '''---> Fill the UOM feild
                                .SetText(1, i + 1, Trim(txtItemCode.Text))
                                .SetText(2, i + 1, Trim(txtItemDesc.Text))
                                .SetText(3, i + 1, Trim(gdataset.Tables("RateMaster").Rows(i).Item("UOM")))
                                .SetText(4, i + 1, Val(gdataset.Tables("RateMaster").Rows(i).Item("ITEMRATE")))
                            Next
                        End If
                    End With
                Else
                    OptNo.Checked = True
                    FraGrid.Visible = False
                    FraRate.Visible = True
                    ssql = "SELECT ISNULL(UOM,'') AS UOM,ISNULL(ITEMRATE,0) AS ITEMRATE,ISNULL(PURCAHSERATE,0) AS PURCAHSERATE FROM RateMaster WHERE Itemcode='" & txtItemCode.Text & "' and ISNULL(ENDINGDATE,'')='' "
                    vconn.getDataSet(ssql, "RateMaster")
                    If gdataset.Tables("RateMaster").Rows.Count > 0 Then
                        txtPurchaseRate.Text = Format(Val(gdataset.Tables("RateMaster").Rows(0).Item("PURCAHSERATE")), "0.00")
                        txtRate.Text = Format(Val(gdataset.Tables("RateMaster").Rows(0).Item("ITEMRATE")), "0.00")
                        CmbUOm.Text = Trim(gdataset.Tables("RateMaster").Rows(0).Item("UOM"))
                    End If
                End If
                If Trim(gdataset.Tables("ItemMaster").Rows(0).Item("Openfacility")) = "Y" Then
                    ChkOPENITEMFACILITY.Checked = True
                Else
                    ChkOPENITEMFACILITY.Checked = False
                End If
                If Trim(gdataset.Tables("ItemMaster").Rows(0).Item("PROMOTIONAL")) = "Y" Then
                    ChkPROMOT.Checked = True
                    btnPromotionalView.Visible = True
                    ChkPROMOT.Checked = True
                    If Trim(gdataset.Tables("ItemMaster").Rows(0).Item("MULTIRATE")) = "Y" Then
                        cmbBaseUOM.Visible = True
                        txtPromUOM.Visible = False
                        cmbBaseUOM.DropDownStyle = ComboBoxStyle.DropDown
                        cmbBaseUOM.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("BASEUOM"))
                    Else
                        cmbBaseUOM.Visible = False
                        txtPromUOM.Visible = True
                        txtBaseUOM.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("BASEUOM"))
                    End If
                    mskFromDate.Value = CDate(gdataset.Tables("ItemMaster").Rows(0).Item("STARTINGDATE"))
                    mskToDate.Value = CDate(gdataset.Tables("ItemMaster").Rows(0).Item("ENDINGDATE"))
                    txtBaseQty.Text = Val(gdataset.Tables("ItemMaster").Rows(0).Item("BASEQTY"))
                    txtBaseRate.Text = Format(Val(gdataset.Tables("ItemMaster").Rows(0).Item("BASERATE")), "0.00")
                    txtProItem.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("PROMITEMCODE"))
                    ssql = "SELECT  ISNULL(MULTIRATE,'') AS MULTIRATE   FROM ItemMaster WHERE Itemcode='" & Trim(txtProItem.Text) & "'"
                    vconn.getDataSet(ssql, "ITEMMASTER1")
                    If gdataset.Tables("ITEMMASTER1").Rows.Count > 0 Then
                        If Trim(gdataset.Tables("ITEMMASTER1").Rows(0).Item("MULTIRATE")) = "Y" Then
                            txtPromUOM.Visible = False
                            cmbPromtUOM.Visible = True
                            cmbPromtUOM.DropDownStyle = ComboBoxStyle.DropDown
                            cmbPromtUOM.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("PROMUOM"))
                        Else
                            cmbPromtUOM.Visible = False
                            txtPromUOM.Visible = True
                            txtPromUOM.Text = Trim(gdataset.Tables("ItemMaster").Rows(0).Item("PROMUOM"))
                        End If
                        txtPromQty.Text = Val(gdataset.Tables("ItemMaster").Rows(0).Item("PROMQTY"))
                        txtPromRate.Text = Format(Val(gdataset.Tables("ItemMaster").Rows(0).Item("PROMRATE")), "0.00")
                    End If
                Else
                    ChkPROMOT.Checked = False
                End If
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
            Else
                txtItemDesc.Focus()
            End If
            txtItemDesc.Focus()
        Else
            txtItemCode.Text = ""
            txtItemCode.Focus()
        End If
    End Sub
    Private Sub txtGroupcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGroupcode.Validated
        If txtGroupcode.Text <> "" Then
            vseqno = GetSeqno(txtGroupcode.Text)
            ssql = "SELECT GroupDesc FROM GroupMaster WHERE ISNULL(Freeze,'') <> 'Y' AND groupseqno=" & Val(vseqno)
            vconn.getDataSet(ssql, "GroupMaster")
            If gdataset.Tables("GroupMaster").Rows.Count > 0 Then
                txtGroupDes.Text = ""
                txtGroupDes.Text = Trim(gdataset.Tables("GroupMaster").Rows(0).Item(0))
                txtGroupDes.ReadOnly = True
                'txtAcctIn.Focus()
                TXT_LEDGER.Focus()
            Else
                txtGroupcode.Clear()
                txtGroupDes.Clear()
                txtGroupcode.Focus()
            End If
        Else
            txtGroupDes.Clear()
        End If
    End Sub
    Private Sub cmdType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdType.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(ITEMTYPECODE,'') AS ITEMTYPECODE,ISNULL(ITEMTYPEDESC,'') AS ITEMTYPEDESC FROM ItemTypeMaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y'"
        End If
        vform.Field = "ITEMTYPECODE,ITEMTYPEDESC"
        vform.vFormatstring = "  ITEM TYPE CODE        |                             ITEM TYPE DESCRIPTION                             "
        vform.vCaption = "ITEM TYPE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtItemType.Text = Trim(vform.keyfield & "")
            Call txtItemType_Validated(txtItemType, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim vPromseqno, insert(0), VarPOSCODE() As String
        Dim vstring, vDate As Date
        Dim vPOSno As Double
        Dim count As Integer
        '''*********************************** Check Validation *******************************************************'''
        If MeValidate() = False Then Exit Sub
        '''*********************************** UPDATE RateMaster,ItemMaster *******************************************'''
        If Mid(CmdAdd.Text, 1, 1) = "U" Then
            vseqno = GetSeqno(txtItemCode.Text)
            ssql = "SELECT Startingdate FROM Ratemaster WHERE ItemCodeseqno=" & (vseqno) & ""
            ssql = ssql & " AND  ISNULL(endingdate,'') =''"
            vstring = vconn.getvalue(ssql)
            If IsDate(vstring) = False Then
                vstring = Format(Now, "dd-MMM-yyyy")
            End If
            ssql = "UPDATE Itemmaster SET ItemDesc = '" & Replace(Trim(txtItemDesc.Text), "'", " ") & "',"
            ssql = ssql & " ShortName = '" & Trim(txtShort.Text) & "',ItemTypeCode='" & Trim(txtItemType.Text) & "',"
            ssql = ssql & " GroupCode = '" & Trim(txtGroupcode.Text) & "',Freeze = 'N',"
            ssql = ssql & " SALESACCTIN = '" & Trim(txtAcctIn.Text) & "',"
            ssql = ssql & " ledgername = '" & Trim(TXT_LEDGER.Text) & "',"
            ssql = ssql & " Multirate = '" & IIf(optYes.Checked = True, "Y", "N") & "',"
            If OptNo.Checked = True Then
                ssql = ssql & " BaseUOMstd = '" & Trim(CmbUOm.Text) & "',BaseRatestd=" & Format(Val(txtRate.Text), "0.00") & ","
            Else
                ssql = ssql & " BaseUOMstd = '" & Trim(cbo_BaseUOM.Text) & "',BaseRatestd=" & Format(Val(txt_BaseRate.Text), "0.00") & ","
            End If
            ssql = ssql & " Promotional = '" & IIf(ChkPROMOT.Checked = True, "Y", "N") & "',Openfacility = '" & IIf(ChkOPENITEMFACILITY.Checked = True, "Y", "N") & "',"
            If ChkPROMOT.Checked = True Then
                If OptNo.Checked = True Then
                    ssql = ssql & " BaseUOM ='" & Trim(txtBaseUOM.Text) & "',"
                    ssql = ssql & " BaseQty = " & Format(Val(txtBaseQty.Text), "0.00") & ","
                    ssql = ssql & " BaseRate = " & Format(Val(txtBaseRate.Text), "0.00") & ","
                    ssql = ssql & " PromItemcode='" & Trim(txtProItem.Text) & "',"
                    vPromseqno = GetSeqno(txtProItem.Text)
                    ssql = ssql & " PromItemseqno=" & Val(vPromseqno) & ", "
                    If Trim(txtPromUOM.Text) <> "" Then
                        ssql = ssql & " PromUOM= '" & Trim(txtPromUOM.Text) & "',"
                    ElseIf Trim(cmbPromtUOM.Text) <> "" Then
                        ssql = ssql & " PromUOM= '" & Trim(cmbPromtUOM.Text) & "',"
                    End If
                    ssql = ssql & " PromQty = " & Format(Val(txtPromQty.Text), "0.00") & ", PromRate = " & Format(Val(txtPromRate.Text), "0.00") & " , "
                    ssql = ssql & " Startingdate = '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "',Endingdate = '" & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"
                Else
                    ssql = ssql & " BaseUOM ='" & Trim(cmbBaseUOM.Text) & "',"
                    ssql = ssql & " BaseQty = " & Format(Val(txtBaseQty.Text), "0.00") & ","
                    ssql = ssql & " BaseRate = " & Format(Val(txtBaseRate.Text), "0.00") & ","
                    ssql = ssql & " PromItemcode='" & Trim(txtProItem.Text) & "',"
                    vPromseqno = GetSeqno(txtProItem.Text)
                    ssql = ssql & " PromItemseqno=" & Val(vPromseqno) & ","
                    If Trim(txtPromUOM.Text) <> "" Then
                        ssql = ssql & " PromUOM= '" & Trim(txtPromUOM.Text) & "',"
                    ElseIf Trim(cmbPromtUOM.Text) <> "" Then
                        ssql = ssql & " PromUOM= '" & Trim(cmbPromtUOM.Text) & "',"
                    End If
                    ssql = ssql & " PromQty = " & Format(Val(txtPromQty.Text), "0.00") & ", PromRate = " & Format(Val(txtPromRate.Text), "0.00") & " , "
                    ssql = ssql & " Startingdate = '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "',Endingdate = '" & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"
                End If
            Else
                ssql = ssql & " BaseUOM ='',"
                ssql = ssql & " BaseQty = 0,BaseRate=0, PromItemcode='', "
                ssql = ssql & " PromItemseqno=0, "
                ssql = ssql & " PromUOM= '',"
                ssql = ssql & " PromQty = 0, PromRate = 0, "
                ssql = ssql & " Startingdate = '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "',Endingdate = '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "'"
            End If
            vseqno = GetSeqno(txtItemCode.Text)
            ssql = ssql & " WHERE ItemCodeseqno = " & (vseqno)
            insert(0) = ssql
            vseqno = GetSeqno(txtItemCode.Text)
            ssql = "DELETE FROM POSMenulink WHERE ItemCodeseqno=" & (vseqno)
            ReDim Preserve insert(insert.Length)
            insert(insert.Length - 1) = ssql
            vstring = Format(vstring, "dd-MMM-yyyy")
            If vstring = Format(Now, "dd-MMM-yyyy") Then
                vDate = DateAdd(DateInterval.Day, -1, Now)
                ssql = "UPDATE Ratemaster SET Endingdate='" & Format(vDate, "dd-MMM-yyyy") & "' where ItemCodeseqno=" & (vseqno) & " And EndingDate is Null "
            Else
                vDate = DateAdd(DateInterval.Day, -1, Now)
                ssql = "UPDATE Ratemaster SET Endingdate='" & Format(vDate, "dd-MMM-yyyy") & "' where ItemCodeseqno=" & (vseqno) & " And  EndingDate is Null  "
            End If
            ReDim Preserve insert(insert.Length)
            insert(insert.Length - 1) = ssql
        End If
        count = 1
        For i = 0 To LstPOScode.Items.Count - 1
            If LstPOScode.GetItemChecked(i) = True Then
                VarPOSCODE = Split(LstPOScode.Items(i), "[")
                ssql = " INSERT INTO POSMenulink (ItemCodeseqno,Itemcode,POS,POSseqno) "
                vseqno = GetSeqno(txtItemCode.Text)
                ssql = ssql & " VALUES(" & (vseqno) & ", '" & Trim(txtItemCode.Text) & "'"
                vPOSno = GetSeqno(VarPOSCODE(0))
                ssql = ssql & " ,'" & VarPOSCODE(0) & "' , " & Val(vPOSno) & ")"
                If Mid(CmdAdd.Text, 1, 1) = "U" Then
                    ReDim Preserve insert(insert.Length)
                    insert(insert.Length - 1) = ssql
                Else
                    If count > 1 Then
                        ReDim Preserve insert(insert.Length)
                    End If
                    insert(insert.Length - 1) = ssql
                    count = count + 1
                End If
            End If
        Next
        If OptNo.Checked = True Then
            Call InsertPromotional(insert)
        Else
            Call InsertGridYes(insert)
        End If
        Call CmdClear_Click(CmdClear, e)
    End Sub
    Private Sub InsertPromotional(ByVal Insert() As String)
        '''****************************************** IF MULTIRATE IS 'NO' *****************************************''''
        Dim vsql, vPromSeqno As String
        If ChkPROMOT.Checked = True Then
            '''******************************** $ IF MULTIRATE IS 'NO' AND PROMTIONAL IS 'YES' $ ***********************'''
            If Mid(CmdAdd.Text, 1, 1) = "A" Then
                vseqno = GetSeqno(txtItemCode.Text)
                ssql = "INSERT INTO ItemMaster(ItemCodeseqno,ItemCode,Shortname,ItemDesc,ItemTypeCode,ItemTypeseqno,GroupCode,"
                ssql = ssql & " groupseqno,Freeze,Multirate,Promotional,BaseUomStd,BaseRateStd,Openfacility,BaseRate,BaseUOM,BaseQty,PromItemseqno,"
                ssql = ssql & " PromItemCode,PromUOM,PromQty,PromRate,Startingdate,Endingdate,AddUserId,AddDateTime,SalesAcctin,ledgername)"
                ssql = ssql & " VALUES(" & (vseqno) & ","
                ssql = ssql & " '" & Trim(txtItemCode.Text) & "','" & Trim(txtShort.Text) & "',"
                ssql = ssql & " '" & Replace(Trim(txtItemDesc.Text), "'", "") & "','" & Trim(txtItemType.Text) & "',"
                vseqno = GetSeqno(txtItemType.Text)
                ssql = ssql & " " & (vseqno) & ","
                ssql = ssql & " '" & Trim(txtGroupcode.Text) & "',"
                vseqno = GetSeqno(txtGroupcode.Text)
                ssql = ssql & " " & (vseqno) & ",'N','N','Y',"
                If OptNo.Checked = True Then
                    ssql = ssql & " '" & Trim(CmbUOm.Text) & "'," & Format(Val(txtRate.Text), "0.00") & ","
                Else
                    ssql = ssql & " '" & Trim(cbo_BaseUOM.Text) & "'," & Format(Val(txt_BaseRate.Text), "0.00") & ","
                End If
                If ChkOPENITEMFACILITY.Checked = True Then
                    ssql = ssql & " 'Y',"
                Else
                    ssql = ssql & " 'N',"
                End If
                ssql = ssql & " " & Format(Val(txtBaseRate.Text), "0.00") & ","
                If OptNo.Checked = True Then
                    ssql = ssql & "'" & Trim(txtBaseUOM.Text) & "'," & Format(Val(txtBaseQty.Text), "0.00") & ","
                Else
                    ssql = ssql & "'" & Trim(cmbBaseUOM.Text) & "'," & Format(Val(txtBaseQty.Text), "0.00") & ","
                End If
                vPromSeqno = GetSeqno(txtProItem.Text)
                ssql = ssql & "" & Val(vPromSeqno) & ",'" & Trim(txtProItem.Text) & "',"
                If Trim(txtPromUOM.Text) <> "" Then
                    ssql = ssql & "'" & Trim(txtPromUOM.Text) & "'," & Format(Val(txtPromQty.Text), "0.00") & ","
                Else
                    ssql = ssql & "'" & Trim(cmbPromtUOM.Text) & "'," & Format(Val(txtPromQty.Text), "0.00") & ","
                End If
                ssql = ssql & "" & Val(txtPromRate.Text) & ","
                ssql = ssql & "'" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "',"
                ssql = ssql & "'" & Format(mskToDate.Value, "dd-MMM-yyyy") & "',"
                ssql = ssql & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & txtAcctIn.Text & "','" & TXT_LEDGER.Text & "')"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = ssql
            End If
            vseqno = GetSeqno(txtItemCode.Text)
            ssql = " INSERT INTO RateMaster(WithEffectFrom,ItemCodeseqno,ItemCode,UOM,ItemRate,purcahseRate,"
            ssql = ssql & " Startingdate,Freeze,AddUserId,AddDateTime)"
            ssql = ssql & " VALUES('" & Format(Now, "dd-MMM-yyyy") & "'," & (vseqno) & ","
            ssql = ssql & " '" & Trim(txtItemCode.Text) & "','" & Trim(CmbUOm.Text) & "',"
            ssql = ssql & " " & Format(Val(txtRate.Text), "0.00") & "," & Format(Val(txtPurchaseRate.Text), "0.00") & ","
            ssql = ssql & " '" & Format(Now, "dd-MMM-yyyy") & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = ssql
        Else
            '''******************************** $ IF MULTIRATE IS 'NO' AND PROMTIONAL IS 'NO' $ ***********************'''
            If Mid(CmdAdd.Text, 1, 1) = "A" Then
                vseqno = GetSeqno(txtItemCode.Text)
                ssql = "INSERT INTO ItemMaster(ItemCodeseqno,ItemCode,ShortName,ItemDesc,ItemTypeCode,ItemTypeseqno,GroupCode,Openfacility,Groupseqno,"
                ssql = ssql & " Freeze,Multirate,BaseUOMstd,BaseRatestd,Promotional,BaseRate,BaseUOM,BaseQty,StockControl,PromItemcode,"
                ssql = ssql & " PromItemseqno,PromUOM,PromQty,PromRate,AddUserId,AddDateTime,StartingDate,EndingDate,salesacctin,ledgername)"
                vseqno = GetSeqno(txtItemCode.Text)
                ssql = ssql & " VALUES(" & Trim(vseqno) & ","
                ssql = ssql & " '" & Trim(txtItemCode.Text) & "','" & Trim(txtShort.Text) & "',"
                ssql = ssql & " '" & Replace(Trim(txtItemDesc.Text), "'", "") & "','" & Trim(txtItemType.Text) & "',"
                vseqno = GetSeqno(txtItemType.Text)
                ssql = ssql & " " & Trim(vseqno) & ",'" & Trim(txtGroupcode.Text) & "',"
                If ChkOPENITEMFACILITY.Checked = True Then
                    ssql = ssql & " 'Y',"
                Else
                    ssql = ssql & " 'N',"
                End If
                vseqno = GetSeqno(txtGroupcode.Text)
                ssql = ssql & "" & Trim(vseqno) & ",'N','N',"
                If OptNo.Checked = True Then
                    ssql = ssql & " '" & Trim(CmbUOm.Text) & "'," & Format(Val(txtRate.Text), "0.00") & ","
                Else
                    ssql = ssql & " '" & Trim(cbo_BaseUOM.Text) & "'," & Format(Val(txt_BaseRate.Text), "0.00") & ","
                End If
                ssql = ssql & " 'N',0,'',0,'','',0,'',0,0,'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "','" & Format(Now, "dd-MMM-yyyy") & "',"
                ssql = ssql & " '" & Format(Now, "dd-MMM-yyyy") & "','" & txtAcctIn.Text & "','" & TXT_LEDGER.Text & "')"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = ssql
            End If
            vseqno = GetSeqno(txtItemCode.Text)
            ssql = "INSERT INTO RateMaster(WithEffectFrom,ItemCodeseqno,ItemCode,UOM,ItemRate,purcahseRate,"
            ssql = ssql & " Startingdate,Freeze,AddUserId,AddDateTime)"
            ssql = ssql & " VALUES('" & Format(Now, "dd-MMM-yyyy") & "'," & Trim(vseqno) & ","
            ssql = ssql & " '" & Trim(txtItemCode.Text) & "','" & Trim(CmbUOm.Text) & "',"
            ssql = ssql & " " & Format(Val(txtRate.Text), "0.00") & "," & Format(Val(txtPurchaseRate.Text), "0.00") & ","
            ssql = ssql & " '" & Format(Now, "dd-MMM-yyyy") & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = ssql
        End If
        vconn.MoreTransold(Insert)
    End Sub

    Private Sub InsertGridYes(ByVal Insert() As String)
        '''****************************************** IF MULTIRATE IS 'NO' *****************************************''''
        Dim vPromSeqno As Double
        Dim vUOM, vRate As String
        vseqno = GetSeqno(txtItemCode.Text)
        If ChkPROMOT.Checked = True Then
            '''******************************** $ IF MULTIRATE IS 'YES' AND PROMTIONAL IS 'YES' $ ***********************'''
            If Mid(CmdAdd.Text, 1, 1) = "A" Then
                vseqno = GetSeqno(txtItemCode.Text)
                ssql = " INSERT INTO ItemMaster(salesacctin,ledgername,ItemCodeseqno,ItemCode,Shortname,ItemDesc,ItemTypeCode,ItemTypeseqno,GroupCode"
                ssql = ssql & " ,groupseqno,Freeze,Multirate,BaseUOMstd,BaseRatestd,Promotional,BaseRate,BaseUOM,BaseQty,Openfacility,PromItemseqno"
                ssql = ssql & " ,PromItemCode,PromUOM,PromQty,PromRate,Startingdate,Endingdate,AddUserId,AddDateTime)"
                ssql = ssql & " VALUES('" & txtAcctIn.Text & "','" & TXT_LEDGER.Text & "'," & (vseqno) & ","
                ssql = ssql & " '" & Trim(txtItemCode.Text) & "','" & Trim(txtShort.Text) & "',"
                ssql = ssql & " '" & Replace(Trim(txtItemDesc.Text), "'", "") & "','" & Trim(txtItemType.Text) & "',"
                vseqno = GetSeqno(txtItemType.Text)
                ssql = ssql & " " & Val(vseqno) & ","
                ssql = ssql & " '" & Trim(txtGroupcode.Text) & "',"
                vseqno = GetSeqno(txtGroupcode.Text)
                ssql = ssql & " " & (vseqno) & ",'N','Y',"
                ssql = ssql & " '" & Trim(cbo_BaseUOM.Text) & "',"
                ssql = ssql & " " & Format(Val(txt_BaseRate.Text), "0.00") & ",'Y',"
                ssql = ssql & " " & Format(Val(txtBaseRate.Text), "0.00") & ","
                If txtBaseUOM.Visible = True Then
                    ssql = ssql & " '" & Trim(txtBaseUOM.Text) & "'," & Format(Val(txtBaseQty.Text), "0.00") & ","
                Else
                    ssql = ssql & " '" & Trim(cmbBaseUOM.Text) & "'," & Format(Val(txtBaseQty.Text), "0.00") & ","
                End If
                If ChkOPENITEMFACILITY.Checked = True Then
                    ssql = ssql & " 'Y',"
                Else
                    ssql = ssql & " 'N',"
                End If
                vPromSeqno = GetSeqno(txtProItem.Text)
                ssql = ssql & " " & Val(vPromSeqno) & ",'" & Trim(txtProItem.Text) & "',"
                If Trim(txtPromUOM.Text) = "" Then
                    ssql = ssql & " '" & Trim(cmbPromtUOM.Text) & "'," & Format(Val(txtPromQty.Text), "0.00") & ","
                Else
                    ssql = ssql & " '" & Trim(txtPromUOM.Text) & "'," & Format(Val(txtPromQty.Text), "0.00") & ","
                End If
                ssql = ssql & " " & Format(Val(txtPromRate.Text), "0.00") & ","
                ssql = ssql & " '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "',"
                ssql = ssql & " '" & Format(mskToDate.Value, "dd-MMM-yyyy") & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = ssql
            End If
            With ssGrid
                For i = 1 To .DataRowCnt
                    vseqno = GetSeqno(txtItemCode.Text)
                    ssql = "INSERT INTO RateMaster(WithEffectFrom,ItemCodeseqno,ItemCode,UOM,ItemRate,Startingdate,Freeze,"
                    ssql = ssql & " purcahseRate,AddUserId,AddDateTime)"
                    ssql = ssql & " VALUES('" & Format(Now, "dd-MMM-yyyy") & "'," & Trim(vseqno) & ","
                    ssql = ssql & " '" & txtItemCode.Text & "',"
                    .Row = i
                    .Col = 3
                    ssql = ssql & " '" & Trim(.Text) & "',"
                    .Col = 4
                    ssql = ssql & " " & Format(Val(.Text), "0.00") & ","
                    ssql = ssql & " '" & Format(Now, "dd-MMM-yyyy") & "','N',"
                    ssql = ssql & " 0,'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = ssql
                Next i
            End With
        ElseIf ChkPROMOT.Checked = False Then
            '''******************************** $ IF MULTIRATE IS 'YES' AND PROMTIONAL IS 'NO' $ ***********************'''
            If Mid(CmdAdd.Text, 1, 1) = "A" Then
                vseqno = GetSeqno(txtItemCode.Text)
                ssql = "INSERT INTO ItemMaster(salesacctin,ledgername,ItemCodeseqno,ItemCode,ShortName,ItemDesc,ItemTypeCode,ItemTypeseqno,GroupCode,Openfacility,Groupseqno,"
                ssql = ssql & " Freeze,MultiRate,BaseUOMstd,BaseRatestd,Promotional,BaseRate,BaseUOM,BaseQty,StockControl,PromItemcode,"
                ssql = ssql & " PromItemseqno,PromUOM,PromQty,PromRate,AddUserId,AddDateTime,StartingDate,EndingDate)"
                ssql = ssql & " VALUES('" & txtAcctIn.Text & "','" & TXT_LEDGER.Text & "'," & Trim(vseqno) & ",'" & Trim(txtItemCode.Text) & "','" & Trim(txtShort.Text) & "',"
                ssql = ssql & " '" & Replace(Trim(txtItemDesc.Text), "'", " ") & "','" & Trim(txtItemType.Text) & "',"
                vseqno = GetSeqno(txtItemType.Text)
                ssql = ssql & " " & Trim(vseqno) & ","
                ssql = ssql & " '" & Trim(txtGroupcode.Text) & "',"
                If ChkOPENITEMFACILITY.Checked = True Then
                    ssql = ssql & " 'Y',"
                Else
                    ssql = ssql & " 'N',"
                End If
                vseqno = GetSeqno(txtGroupcode.Text)
                ssql = ssql & " " & Trim(vseqno) & ","
                ssql = ssql & " 'N','Y','" & Trim(cbo_BaseUOM.Text) & "'," & Format(Val(txt_BaseRate.Text), "0.00") & ","
                ssql = ssql & " 'N',0,'',0,'','',0,'',0,0,'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "','" & Format(Now, "dd-MMM-yyyy") & "',"
                ssql = ssql & " '" & Format(Now, "dd-MMM-yyyy") & "')"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = ssql
            End If
            For i = 1 To ssGrid.DataRowCnt
                With ssGrid
                    vseqno = GetSeqno(txtItemCode.Text)
                    ssql = "INSERT INTO RateMaster(WithEffectFrom,ItemCodeseqno,ItemCode,UOM,ItemRate,Startingdate,Freeze,"
                    ssql = ssql & " purcahseRate,AddUserId,AddDateTime)"
                    ssql = ssql & " VALUES('" & Format(Now, "dd-MMM-yyyy") & "'," & Trim(vseqno) & ",'" & Trim(txtItemCode.Text) & "',"
                    .Row = i
                    .Col = 3
                    ssql = ssql & "'" & Trim(.Text) & "',"
                    .Col = 4
                    ssql = ssql & " " & Format(Val(.Text), "0.00") & ","
                    ssql = ssql & " '" & Format(Now, "dd-MMM-yyyy") & "','N',"
                    ssql = ssql & " 0,'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = ssql
                End With
            Next i
        End If
        vconn.MoreTransold(Insert)
    End Sub
    Private Function MeValidate() As Boolean
        MeValidate = True
        If CmdAdd.Text = "Add [F7]" Then
            MsgBox("You can Insert Only Update", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Function
        End If
        If Trim(txtItemCode.Text & "") = "" Then
            MeValidate = False
            MsgBox("Item Code Can't be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
            txtItemCode.Focus()
            Exit Function
        End If
        If Trim(TXT_LEDGER.Text & "") = "" Then
            MeValidate = False
            MsgBox("Ledger Can't be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
            txtAcctIn.Focus()
            Exit Function
        End If

        If Trim(txtItemDesc.Text & "") = "" Then
            MeValidate = False
            MsgBox("Item Code Description Can't be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
            txtItemDesc.Focus()
            Exit Function
        End If
        If Trim(txtItemType.Text & "") = "" Then
            MeValidate = False
            MsgBox("Item type Code Can't be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
            txtItemType.Focus()
            Exit Function
        End If
        If Trim(txtGroupcode.Text & "") = "" Then
            MeValidate = False
            MsgBox("Group Code Can't be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
            txtGroupcode.Focus()
            Exit Function
        End If
        If OptNo.Checked = True Then
            If Trim(txtRate.Text & "") = "" Then
                MeValidate = False
                MsgBox("Item Rate Can't be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
                txtRate.Focus()
                Exit Function
            End If
            If Trim(CmbUOm.Text & "") = "" Then
                MeValidate = False
                MsgBox("Item UOM Can't be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
                CmbUOm.Focus()
                Exit Function
            End If
        Else
            With ssGrid
                For i = 1 To .DataRowCnt
                    .Row = i
                    .Col = 1
                    If Trim(.Text) = "" Then
                        MeValidate = False
                        MsgBox("Item Code can't blank", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, MyCompanyName)
                        .SetActiveCell(1, ssGrid.ActiveRow)
                        .Focus()
                        Exit Function
                    End If
                    .Col = 2
                    If Trim(.Text) = "" Then
                        MeValidate = False
                        MsgBox("Item Description can't blank", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, MyCompanyName)
                        .SetActiveCell(2, ssGrid.ActiveRow)
                        .Focus()
                        Exit Function
                    End If
                    .Col = 3
                    If Trim(.Text) = "" Then
                        MeValidate = False
                        MsgBox("UOM can't blank", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, MyCompanyName)
                        .SetActiveCell(3, ssGrid.ActiveRow)
                        .Focus()
                        Exit Function
                    End If
                    .Col = 4
                    If Trim(.Text) = "" Then
                        MeValidate = False
                        MsgBox("Rate can't blank", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, MyCompanyName)
                        .SetActiveCell(4, ssGrid.ActiveRow)
                        .Focus()
                        Exit Function
                    End If
                Next
            End With
        End If
    End Function

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM ITEMMASTER I INNER JOIN RATEMASTER R ON I.ITEMCODE = R.ITEMCODE INNER JOIN GROUPMASTER G ON G.GROUPCODE = I.GROUPCODE WHERE ISNULL(R.ENDINGDATE,'') = '' "
        Gheader = "ITEM MASTER"
        FrReport.SsGridReport.SetText(2, 1, "I.ITEMCODE")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "I.ITEMDESC")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "I.SHORTNAME")
        FrReport.SsGridReport.SetText(3, 3, 5)
        FrReport.SsGridReport.SetText(2, 4, "I.ITEMTYPECODE")
        FrReport.SsGridReport.SetText(3, 4, 10)
        FrReport.SsGridReport.SetText(2, 5, "I.GROUPCODE")
        FrReport.SsGridReport.SetText(3, 5, 10)
        FrReport.SsGridReport.SetText(2, 6, "G.GROUPDESC")
        FrReport.SsGridReport.SetText(3, 6, 35)

        FrReport.SsGridReport.SetText(2, 7, "I.MULTIRATE")
        FrReport.SsGridReport.SetText(3, 7, 10)
        FrReport.SsGridReport.SetText(2, 8, "I.PROMOTIONAL")
        FrReport.SsGridReport.SetText(3, 8, 10)
        FrReport.SsGridReport.SetText(2, 9, "I.OPENFACILITY")
        FrReport.SsGridReport.SetText(3, 9, 10)
        FrReport.SsGridReport.SetText(2, 10, "I.FREEZE")
        FrReport.SsGridReport.SetText(3, 10, 6)
        FrReport.SsGridReport.SetText(2, 11, "R.ITEMRATE")
        FrReport.SsGridReport.SetText(3, 11, 10)
        FrReport.SsGridReport.SetText(2, 12, "R.PURCAHSERATE")
        FrReport.SsGridReport.SetText(3, 12, 10)
        FrReport.SsGridReport.SetText(2, 13, "R.UOM")
        FrReport.SsGridReport.SetText(3, 13, 10)
        FrReport.Show()
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub FillPOS()
        ssql = "SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(POSSEQNO,0) AS POSSEQNO FROM POSMaster WHERE ISNULL(Freeze,'') <> 'Y'"
        LstPOScode.Items.Clear()
        vconn.getDataSet(ssql, "POSMaster")
        If gdataset.Tables("POSMaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POSMaster").Rows.Count - 1
                With gdataset.Tables("POSMaster").Rows(i)
                    LstPOScode.Items.Add(Trim(.Item("POSCODE")) & " [ " & Trim(.Item("POSDESC")) & " ]")
                End With
            Next i
        End If
    End Sub
    Private Sub LstPOScode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstPOScode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CmdAdd.Text = "Add [F7]" Then
                optYes.Focus()
            ElseIf CmdAdd.Text = "Update[F7]" Then
                If optYes.Checked = True Then
                    ssGrid.Focus()
                    ssGrid.SetActiveCell(3, 1)
                Else
                    txtPurchaseRate.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub OptNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptNo.Click
        If OptNo.Checked = True Then
            FraGrid.Visible = False
            FraRate.Visible = True
            OptNo.Focus()
        End If
    End Sub
    Private Sub optYes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optYes.Click
        If optYes.Checked = True Then
            FraRate.Visible = False
            FraGrid.Visible = True
            Call GridUOM(ssGrid.ActiveRow) '''---> Fill the UOM feild
        End If
    End Sub
    Private Sub optYes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles optYes.KeyPress
        If Asc(e.KeyChar) = 13 Then
            FraRate.Visible = False
            FraGrid.Visible = True
            cbo_BaseUOM.Focus()
        End If
    End Sub
    Private Sub OptNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OptNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            FraRate.Visible = True
            FraGrid.Visible = False
            txtPurchaseRate.Focus()
        End If
    End Sub
    Private Sub txtItemType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemType.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtItemType.Text) <> "" Then
                Call txtItemType_Validated(txtItemType, e)
            Else
                Call cmdType_Click(cmdType, e)
            End If
        End If
    End Sub
    Private Sub txtItemCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmdItemHelp.Enabled = True Then
                Search = Trim(txtItemCode.Text)
                Call cmdItemHelp_Click(cmdItemHelp, e)
            End If
        End If
    End Sub
    Private Sub txtItemType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemType.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(txtItemType.Text)
            Call cmdType_Click(cmdType, e)
        End If
    End Sub
    Private Sub txtGroupcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGroupcode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(txtGroupcode.Text)
            Call cmdGroup_Click(cmdGroup, e)
        End If
    End Sub
    Private Sub txtGroupcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGroupcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtGroupcode.Text) <> "" Then
                Call txtGroupcode_Validated(txtGroupcode, e)
            Else
                Call cmdGroup_Click(cmdGroup, e)
            End If
        End If
    End Sub
    Private Sub ItemMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            If FraPromt.Visible = False Then
                Call CmdClear_Click(CmdClear, e)
            End If
        End If
        If e.KeyCode = Keys.F10 Then
            Call cmdOk_Click(sender, e)
        End If
        If e.KeyCode = Keys.F2 Then
            Call btnPromotDelete_Click(sender, e)
        End If
        If e.KeyCode = Keys.F12 Then
            Call cmdCancel_Click(sender, e)
        End If
        'If e.KeyCode = Keys.F7 Then
        '    If FraPromt.Visible = False Then
        '        Call CmdAdd_Click(CmdAdd, e)
        '    End If
        'End If
        'If e.KeyCode = Keys.F8 Then
        '    If FraPromt.Visible = False Then
        '        Call Cmd_Freeze_Click(Cmd_Freeze, e)
        '    End If
        'End If
        'If e.KeyCode = Keys.F9 Then
        '    Call CmdView_Click(CmdView, e)
        'End If
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
            If FraPromt.Top = 8 Then
                FraPromt.Top = 1000
            Else
                Me.Close()
            End If
        End If
    End Sub
    Private Sub txtItemCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtItemCode.Text) = "" Then
                Call cmdItemHelp_Click(cmdItemHelp, e)
            Else
                txtItemCode_Validated(txtItemCode, e)
            End If
        End If
    End Sub
    Private Sub txtItemDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemDesc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtShort.Focus()
        End If
    End Sub
    Private Sub txtShort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShort.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtItemType.Focus()
        End If
    End Sub
    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            CmbUOm.Focus()
        End If
    End Sub
    Private Sub CmbUOm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbUOm.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ChkPROMOT.Focus()
        End If
    End Sub
    Private Sub mskDateFrom_KeyPressEvent(ByVal sender As System.Object, ByVal e As AxMSMask.MaskEdBoxEvents_KeyPressEvent)
        If Asc(e.keyAscii) = 13 Then
            mskToDate.Focus()
        End If
    End Sub
    Private Sub txtBaseQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBaseQty.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txtProItem.Focus()
        End If
    End Sub
    Private Sub mskDateTo_KeyPressEvent(ByVal sender As System.Object, ByVal e As AxMSMask.MaskEdBoxEvents_KeyPressEvent)
        If e.keyAscii = 13 Then
            txtBaseUOM.Focus()
        End If
    End Sub
    Private Sub txtProItem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProItem.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtProItem.Text) <> "" Then
                Call txtProItem_Validated(txtProItem, e)
            Else
                Call cmdPromhelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub txtPromUOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPromUOM.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txtPromQty.Focus()
        End If
        Call NumberBoxCheck(txtPromUOM, e)
    End Sub
    Private Sub txtPromQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPromQty.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txtPromRate.Focus()
        End If
    End Sub
    Private Sub txtPromRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPromRate.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            cmdOk.Focus()
        End If
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        FraPromt.Visible = False
        If CmdAdd.Text = "Add [F7]" Then
            ChkPROMOT.Checked = False
            btnPromotionalView.Visible = False
        Else
            ssql = "SELECT Promotional FROM itemmaster WHERE ISNULL(Freeze,'') <> 'Y' AND itemcode = '" & Trim(txtBaseItem.Text) & "'"
            vconn.getDataSet(ssql, "itemmaster")
            If gdataset.Tables("itemmaster").Rows(0).Item(0) = "N" Then
                ChkPROMOT.Checked = False
                btnPromotionalView.Visible = False
            End If
        End If
        CmdAdd.Focus()
    End Sub
    Private Sub FillUOM() '''---> Fill All UOM From UOMMASTER
        ssql = "SELECT DISTINCT ISNULL(UOMDESC,'') AS UOMDESC FROM UOMMaster WHERE ISNULL(Freeze,'') <> 'Y' ORDER BY uomdesc ASC"
        vconn.getDataSet(ssql, "UOMMaster")
        CmbUOm.Items.Clear()
        cmbBaseUOM.Items.Clear()
        cmbPromtUOM.Items.Clear()
        cbo_BaseUOM.Items.Clear()
        If gdataset.Tables("UOMMaster").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("UOMMaster").Rows.Count - 1
                With gdataset.Tables("UOMMaster").Rows(i)
                    CmbUOm.Items.Add(Trim(.Item("UOMdesc")))
                    cbo_BaseUOM.Items.Add(Trim(.Item("UOMdesc")))
                    'cmbBaseUOM.Items.Add(Trim(.Item("UOMdesc") ))
                    'cmbPromtUOM.Items.Add(Trim(.Item("UOMdesc")))
                End With
            Next i
        End If
        cbo_BaseUOM.Sorted = True
        CmbUOm.Sorted = True
        'cmbBaseUOM.Sorted = True
        'cmbPromtUOM.Sorted = True
    End Sub
    Private Sub PromUOM(ByVal ITEMCODE As String)       '''--> To fill Promtional UOM 
        ssql = "SELECT SELECT DISTINCT ISNULL(UOM,'') AS UOM FROM RATEMASTER WHERE ITEMCODE = '" & Trim(ITEMCODE) & "' AND ISNULL(ENDINGDATE,'') = '' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY UOM"
        vconn.getDataSet(ssql, "RATEMASTER")
        cmbBaseUOM.Items.Clear()
        cmbPromtUOM.Items.Clear()
        If gdataset.Tables("RATEMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("RATEMASTER").Rows.Count - 1
                With gdataset.Tables("RATEMASTER").Rows(i)
                    cmbBaseUOM.Items.Add(Trim(.Item("UOM") & ""))
                    cmbPromtUOM.Items.Add(Trim(.Item("UOM") & ""))
                End With
            Next i
        End If
    End Sub
    Private Sub ssGrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssGrid.LeaveCell
        Dim vacctcode As String
        ssGrid.GetText(3, ssGrid.ActiveRow, vacctcode)
        If Trim(vacctcode & "") <> "" Then
            For i = 1 To ssGrid.DataRowCnt
                ssGrid.Row = i
                ssGrid.Col = 3
                If Trim(ssGrid.Text) <> "" Then
                    If Trim(ssGrid.Text) = Trim(vacctcode) And ssGrid.Row <> ssGrid.ActiveRow Then
                        ssGrid.Row = ssGrid.ActiveRow
                        ssGrid.ClearRange(1, ssGrid.ActiveRow, 11, ssGrid.ActiveRow, True)
                        MsgBox("UOM Code already Selected", vbInformation + MsgBoxStyle.OKOnly, MyCompanyName)
                        ssGrid.DeleteRows(ssGrid.ActiveRow, 1)
                        ssGrid.ActiveRow = ssGrid.Row - 1
                        ssGrid.ClearRange(ssGrid.ActiveCol, ssGrid.ActiveRow, ssGrid.ActiveCol, ssGrid.ActiveRow, False)
                        ssGrid.Col = 1
                        ssGrid.Row = ssGrid.ActiveRow
                        ssGrid.Focus()
                        Exit Sub
                    End If
                End If
            Next i
        End If
    End Sub
    Private Sub GridUOM(ByVal i As Integer)
        Dim j As Integer
        Dim sqlstring As String
        ssGrid.TypeComboBoxClear(3, i)
        sqlstring = " SELECT UOMdesc FROM UOMMaster WHERE ISNULL(Freeze,'') <> 'Y' ORDER BY uomdesc ASC "
        vconn.getDataSet(sqlstring, "UOMMaster1")
        If gdataset.Tables("UOMMaster1").Rows.Count > 0 Then
            For j = 0 To gdataset.Tables("UOMMaster1").Rows.Count - 1
                ssGrid.Col = 3
                ssGrid.Row = i
                ssGrid.TypeComboBoxString = Trim(gdataset.Tables("UOMMaster1").Rows(j).Item("UOMdesc"))
                ssGrid.TypeComboBoxIndex = j
            Next j
        End If
    End Sub
    Private Sub cmbBaseUOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbBaseUOM.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call cmbBaseUOM_Validated(cmbBaseUOM, e)
            txtBaseQty.Text = 1
            txtBaseQty.Focus()
        End If
    End Sub
    Private Sub cmbPromtUOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbPromtUOM.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPromQty.Focus()
        End If
    End Sub
    Private Sub cmbBaseUOM_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBaseUOM.Validated
        Dim vString As String
        If Trim(txtBaseItem.Text & "") <> "" Then
            ssql = "SELECT ItemRate FROM RateMaster WHERE ItemCode= '" & txtItemCode.Text & "'  AND UOM ='" & Trim(cmbBaseUOM.Text) & "'"
            vString = vconn.getvalue(ssql)
            If Trim(vString) <> "" Then
                txtBaseRate.Text = Format(Val(vString), "0.00")
                txtBaseQty.Text = 1
            Else
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Row = i
                    ssGrid.Col = 3
                    If Trim(cmbBaseUOM.Text) = Trim(ssGrid.Text) Then
                        ssGrid.Col = 4
                        txtBaseRate.Text = Format(Val(ssGrid.Text), "0.00")
                        Exit Sub
                    Else
                        txtBaseRate.Text = 1
                    End If
                Next i
                txtBaseRate.Text = 1
            End If
        End If
    End Sub
    Private Sub txtBaseItem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBaseItem.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If OptNo.Checked = True Then
                txtBaseUOM.Focus()
            ElseIf optYes.Checked = True Then
                cmbBaseUOM.Items.Clear()
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Col = 3
                    ssGrid.Row = i
                    cmbBaseUOM.Items.Add(Trim(ssGrid.Text))
                Next i
                cmbBaseUOM.SelectedIndex = 0
                cmbBaseUOM.Focus()
            End If
        End If
    End Sub
    Private Sub txtBaseQty_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBaseQty.Validated
        Dim vstring As String
        If OptNo.Checked = True Then
            If Trim(txtBaseItem.Text) <> "" And Trim(txtBaseUOM.Text) <> "" And Val(txtBaseQty.Text) <> 0 Then
                txtBaseRate.Text = Format(Val(txtBaseQty.Text) * Val(txtRate.Text), "0.00")
            End If
        Else
            If Trim(txtBaseItem.Text) <> "" And Trim(cmbBaseUOM.Text) <> "" And Val(txtBaseRate.Text) <> 0 Then
                vseqno = GetSeqno(txtItemCode.Text)
                ssql = "SELECT ItemRate FROM RateMaster WHERE ItemCodeSeqno= " & vseqno & "  AND UOM ='" & Trim(cmbBaseUOM.Text) & "'"
                vstring = vconn.getvalue(ssql)
                If Trim(vstring) <> "" Then
                    txtBaseRate.Text = Format(Val(txtBaseQty.Text) * Val(vstring), "0.00")
                Else
                    txtBaseRate.Text = Format(Val(txtBaseQty.Text) * Val(txtBaseRate.Text), "0.00")
                End If
            End If
        End If
    End Sub
    Private Sub cmdPromhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPromhelp.Click
        gSQLString = "SELECT ItemCode,ItemDesc FROM ItemMaster "
        M_WhereCondition = "WHERE ISNULL(Freeze,'')<> 'Y'"
        Dim vform As New ListOperattion1
        vform.Field = "ITEMCODE,ITEMDESC"
        vform.vFormatstring = "     ITEMCODE         |                             ITEM DESCRIPTION                             "
        vform.vCaption = "ITEM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtProItem.Text = Trim(vform.keyfield & "")
            Call txtProItem_Validated(txtProItem.Text, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txtProItem_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProItem.Validated
        Dim vString As String
        vseqno = GetSeqno(txtProItem.Text)
        ssql = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(MULTIRATE,'') AS MULTIRATE FROM ItemMaster WHERE ISNULL(Freeze,'') <> 'Y' AND ItemCodeseqno =" & (vseqno)
        vconn.getDataSet(ssql, "ITEMMASTER")
        If gdataset.Tables("ITEMMASTER").Rows.Count > 0 Then
            If gdataset.Tables("ITEMMASTER").Rows(0).Item("MULTIRATE") = "Y" Then
                ssql = "SELECT DISTINCT ISNULL(UOM,'') AS UOM FROM RATEMASTER WHERE ItemCodeseqno =" & (vseqno) & " AND ISNULL(ENDINGDATE,'') = '' AND ISNULL(FREEZE,'') <> 'Y'"
                vconn.getDataSet(ssql, "RATEMASTER")
                If gdataset.Tables("RATEMASTER").Rows.Count > 0 Then
                    cmbPromtUOM.Items.Clear()
                    cmbPromtUOM.Visible = True
                    txtPromUOM.Visible = False
                    For i = 0 To gdataset.Tables("RATEMASTER").Rows.Count - 1
                        cmbPromtUOM.Items.Add(Trim(gdataset.Tables("RATEMASTER").Rows(i).Item("UOM")))
                    Next
                    cmbPromtUOM.SelectedIndex = 0
                    cmbPromtUOM.Focus()
                End If
            Else
                ssql = "SELECT DISTINCT ISNULL(UOM,'') AS UOM FROM RATEMASTER WHERE ItemCodeseqno =" & (vseqno) & " AND ISNULL(ENDINGDATE,'') = '' AND ISNULL(FREEZE,'') <> 'Y'"
                vconn.getDataSet(ssql, "RATEMASTER")
                If gdataset.Tables("RATEMASTER").Rows.Count > 0 Then
                    cmbPromtUOM.Visible = False
                    txtPromUOM.Visible = True
                    txtPromUOM.Text = Trim(gdataset.Tables("RATEMASTER").Rows(0).Item("UOM"))
                    txtPromUOM.Focus()
                End If
            End If
        Else
            MessageBox.Show("Plz. Enter a Valid itemcode", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txtProItem.Text = ""
            txtPromUOM.Text = ""
            cmbPromtUOM.Items.Clear()
            txtPromUOM.Visible = True
            txtProItem.Focus()
        End If
    End Sub
    Private Sub txtProItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProItem.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmdPromhelp_Click(cmdPromhelp, e)
        End If
    End Sub
    Private Sub txtBaseUOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBaseUOM.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtBaseQty.Text = 1
            txtBaseQty.Focus()
        End If
    End Sub
    Private Sub ssGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssGrid.KeyDownEvent
        If e.keyCode = Keys.F3 Then
            ssGrid.Row = ssGrid.ActiveRow
            ssGrid.ClearRange(1, ssGrid.ActiveRow, 5, ssGrid.ActiveRow, True)
            ssGrid.DeleteRows(ssGrid.ActiveRow, 1)
            ssGrid.ActiveRow = ssGrid.Row - 1
            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
            ssGrid.Focus()
        End If
    End Sub
    Private Sub ItemMaster_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        itemmasterbool = False
    End Sub

    Private Sub mskFromDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFromDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            mskToDate.Focus()
        End If
    End Sub

    Private Sub mskToDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskToDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtBaseItem.Focus()
        End If
    End Sub
    Private Sub txtRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRate.LostFocus
        If Val(txtRate.Text) < 0 Then
            txtRate.Text = 0
        End If
        txtRate.Text = Format(Val(txtRate.Text), "0.00")
    End Sub
    Private Sub txtPurchaseRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPurchaseRate.LostFocus
        If Val(txtPurchaseRate.Text) < 0 Then
            txtPurchaseRate.Text = 0
        End If
        txtPurchaseRate.Text = Format(Val(txtPurchaseRate.Text), "0.00")
    End Sub

    Private Sub ChkPROMOT_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkPROMOT.CheckedChanged
        If ChkPROMOT.Checked = True And (Mid(CmdAdd.Text, 1, 1)) = "A" Then
            If Trim(txtItemCode.Text) <> "" And Val(txtRate.Text) <> 0 Or Trim(txtItemCode.Text) <> "" Then
                txtBaseItem.Text = Trim(txtItemCode.Text)
                If Mid(CmdAdd.Text, 1, 1) = "A" Then
                    txtBaseItem.ReadOnly = True
                    txtBaseRate.ReadOnly = True
                    txtBaseQty.Text = 1
                    If OptNo.Checked = True Then
                        txtBaseRate.Text = Format(Val(txtRate.Text), "0.00")
                    End If
                End If
                If OptNo.Checked = True Then
                    txtBaseUOM.Visible = True
                    cmbBaseUOM.Visible = False
                    txtBaseUOM.Text = CmbUOm.Text
                ElseIf optYes.Checked = True Then
                    txtBaseUOM.Visible = False
                    cmbBaseUOM.Visible = True
                    For i = 0 To cmbBaseUOM.Items.Count - 1
                        If CmbUOm.Text = cmbBaseUOM.Items.Item(i) Then
                            cmbBaseUOM.Text = cmbBaseUOM.Items.Item(i)
                            cmbBaseUOM.Items.Contains(cmbBaseUOM.Items.Item(i))
                            cmbBaseUOM.DroppedDown() = True
                        End If
                    Next i
                End If
                FraPromt.Visible = True
                FraPromt.Top = 0
                mskFromDate.Focus()
            End If
        ElseIf ChkPROMOT.Checked = True And Mid(CmdAdd.Text, 1, 1) = "U" Then
            btnPromotionalView.Visible = True
        Else
            btnPromotionalView.Visible = False
        End If
    End Sub

    Private Sub ssGrid_KeyPressEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyPressEvent) Handles ssGrid.KeyPressEvent
        If Asc(e.keyAscii) = 13 Or ssGrid.ActiveCol = 1 Then
            If optYes.Checked = True Then
                ssGrid.SetText(1, ssGrid.ActiveRow, Trim(txtItemCode.Text))
                ssGrid.SetText(2, ssGrid.ActiveRow, Trim(txtItemDesc.Text))
                Call GridUOM(ssGrid.ActiveRow)
            End If
        End If
    End Sub

    Private Sub btnPromotionalView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPromotionalView.Click
        If ChkPROMOT.Checked = True And Mid(CmdAdd.Text, 1, 1) = "U" Then
            If Trim(txtItemCode.Text) <> "" And Val(txtRate.Text) <> 0 Or Trim(txtItemCode.Text) <> "" Then
                txtBaseItem.Text = Trim(txtItemCode.Text)
                If Mid(CmdAdd.Text, 1, 1) = "A" Then
                    txtBaseItem.ReadOnly = True
                    txtBaseRate.ReadOnly = True
                    txtBaseQty.Text = 1
                    If OptNo.Checked = True Then
                        txtBaseRate.Text = Val(txtRate.Text)
                    End If
                End If
                If OptNo.Checked = True Then
                    txtBaseUOM.Visible = True
                    cmbBaseUOM.Visible = False
                    txtBaseUOM.Text = CmbUOm.Text
                ElseIf optYes.Checked = True Then
                    For i = 0 To cmbBaseUOM.Items.Count - 1
                        If CmbUOm.Text = cmbBaseUOM.Items.Item(i) Then
                            cmbBaseUOM.Text = cmbBaseUOM.Items.Item(i)
                            cmbBaseUOM.Items.Contains(cmbBaseUOM.Items.Item(i))
                            cmbBaseUOM.DroppedDown() = True
                        End If
                    Next i
                    txtBaseUOM.Visible = False
                    cmbBaseUOM.Visible = True
                End If
                FraPromt.Visible = True
                FraPromt.Top = 8
                FraPromt.Left = 80
                mskFromDate.Focus()
            End If
        End If
    End Sub

    Private Sub btnPromotDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPromotDelete.Click
        Dim sqlstring As String
        Dim delete(0) As String
        sqlstring = "UPDATE itemmaster SET Promotional='N' WHERE ItemCode='" & Trim(txtBaseItem.Text) & "'"
        delete(0) = sqlstring
        sqlstring = "UPDATE Itemmaster SET BaseRate= 0 ,BaseUOM = '',BaseQty=0,PromItemcode='',PromItemseqno=0,PromUOM='',PromQty=0,PromRate=0 WHERE ItemCode='" & Trim(txtBaseItem.Text) & "'"
        ReDim Preserve delete(delete.Length)
        delete(delete.Length - 1) = sqlstring
        vconn.MoreTransold(delete)
        txtBaseQty.Text = ""
        txtBaseUOM.Text = ""
        txtBaseRate.Text = ""
        txtProItem.Text = ""
        txtPromQty.Text = ""
        txtPromUOM.Text = ""
        txtPromRate.Text = ""
        txtBaseUOM.Visible = True
        txtPromUOM.Visible = True
        cmbBaseUOM.Visible = False
        cmbPromtUOM.Visible = False
        mskFromDate.Value = Format(Now, "dd-MMM-yyyy")
        mskToDate.Value = Format(Now, "dd-MMM-yyyy")
        cmbBaseUOM.Items.Clear()
        cmbPromtUOM.Items.Clear()
        mskFromDate.Focus()
    End Sub

    Private Sub txtPurchaseRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurchaseRate.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txtRate.Focus()
        End If
    End Sub

    Private Sub txtBaseRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBaseRate.LostFocus
        txtBaseRate.Text = Format(Val(txtBaseRate.Text), "0.00")
    End Sub

    Private Sub txtPromRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPromRate.LostFocus
        txtPromRate.Text = Format(Val(txtPromRate.Text), "0.00")
    End Sub

    Private Sub txt_BaseRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BaseRate.LostFocus
        txt_BaseRate.Text = Format(Val(txt_BaseRate.Text), "0.00")
    End Sub

    Private Sub cbo_BaseUOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_BaseUOM.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_BaseRate.Focus()
        End If
    End Sub

    Private Sub txt_BaseRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BaseRate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim sqlstring As String
            Dim dblrate As Double
            Dim i, j As Integer
            Dim vuom As String
            If CmdAdd.Text = "Update[F7]" Then
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Row = i
                    ssGrid.Col = 4
                    If Trim(txt_BaseRate.Text) <> Trim(ssGrid.Text) Then
                        ssGrid.SetText(4, i, Format(Val(txt_BaseRate.Text), "0.00"))
                    End If
                Next i
                For j = 1 To ssGrid.DataRowCnt
                    ssGrid.Col = 3
                    ssGrid.Row = j
                    vuom = ssGrid.Text
                    sqlstring = "SELECT * FROM UOMRELATION WHERE uom2='" & Trim(cbo_BaseUOM.Text) & "' "
                    sqlstring = sqlstring & " AND uom1='" & vuom & "' "
                    vconn.getDataSet(sqlstring, "UOMRELATION")
                    If gdataset.Tables("UOMRELATION").Rows.Count > 0 Then
                        dblrate = gdataset.Tables("UOMRELATION").Rows(0).Item("ratio2") * Val(txt_BaseRate.Text)
                        ssGrid.SetText(4, j, Format(Val(dblrate), "0.00"))
                    End If
                Next j
                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                ssGrid.Focus()
            Else
                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                ssGrid.Focus()
            End If
        End If
    End Sub

    Private Sub txt_BaseRate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BaseRate.TextChanged
        Dim sqlstring As String
        Dim dblrate As Double
        Dim i, j As Integer
        Dim vuom As String
        If CmdAdd.Text = "Update[F7]" Then
            For i = 1 To ssGrid.DataRowCnt
                ssGrid.Row = i
                ssGrid.Col = 4
                If Trim(txt_BaseRate.Text) <> Trim(ssGrid.Text) Then
                    ssGrid.SetText(4, i, Format(Val(txt_BaseRate.Text), "0.00"))
                End If
            Next i
            For j = 1 To ssGrid.DataRowCnt
                ssGrid.Col = 3
                ssGrid.Row = j
                vuom = ssGrid.Text
                sqlstring = "SELECT * FROM UOMRELATION WHERE uom2='" & Trim(cbo_BaseUOM.Text) & "' "
                sqlstring = sqlstring & " AND uom1='" & vuom & "' "
                vconn.getDataSet(sqlstring, "UOMRELATION")
                If gdataset.Tables("UOMRELATION").Rows.Count > 0 Then
                    dblrate = gdataset.Tables("UOMRELATION").Rows(0).Item("ratio2") * Val(txt_BaseRate.Text)
                    ssGrid.SetText(4, j, Format(Val(dblrate), "0.00"))
                End If
            Next j
        End If
    End Sub
    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Dim sqlstring As String
        Dim freeze(0) As String
        If MeValidate() = False Then Exit Sub ''-->Check Validation
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  ITEMMASTER "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUserId='" & gUsername & " ', AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Itemcode = '" & Trim(txtItemCode.Text) & "'"
            freeze(0) = sqlstring
            sqlstring = "UPDATE  RATEMASTER "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUserId='" & gUsername & " ', AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Itemcode = '" & Trim(txtItemCode.Text) & "'"
            ReDim Preserve freeze(freeze.Length)
            freeze(freeze.Length - 1) = sqlstring
            vconn.MoreTransold(freeze)
            Me.CmdClear_Click(sender, e)
            CmdAdd.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  ITEMMASTER "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUserId='" & gUsername & " ', AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Itemcode = '" & Trim(txtItemCode.Text) & "'"
            freeze(0) = sqlstring
            sqlstring = "UPDATE  RATEMASTER "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUserId='" & gUsername & " ', AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Itemcode = '" & Trim(txtItemCode.Text) & "'"
            ReDim Preserve freeze(freeze.Length)
            freeze(freeze.Length - 1) = sqlstring
            vconn.MoreTransold(freeze)
            Me.CmdClear_Click(sender, e)
            CmdAdd.Text = "Add [F7]"
        End If
    End Sub
    Private Sub ChkPROMOT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkPROMOT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmdAdd.Focus()
        End If
    End Sub

    Private Sub Cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Delete.Click
        Dim sqlstring As String
        Dim Delete(0) As String
        If MeValidate() = False Then Exit Sub ''-->Check Validation
        If Mid(Me.Cmd_Delete.Text, 1, 1) = "D" Then
            sqlstring = "DELETE FROM ITEMMASTER "
            sqlstring = sqlstring & " WHERE Itemcode = '" & Trim(txtItemCode.Text) & "'"
            Delete(0) = sqlstring
            sqlstring = "DELETE FROM  RATEMASTER "
            sqlstring = sqlstring & " WHERE Itemcode = '" & Trim(txtItemCode.Text) & "'"
            ReDim Preserve Delete(Delete.Length)
            Delete(Delete.Length - 1) = sqlstring
            sqlstring = "DELETE FROM  POSMENULINK "
            sqlstring = sqlstring & " WHERE Itemcode = '" & Trim(txtItemCode.Text) & "'"
            ReDim Preserve Delete(Delete.Length)
            Delete(Delete.Length - 1) = sqlstring
            vconn.MoreTransold(Delete)
            Me.CmdClear_Click(sender, e)
            CmdAdd.Text = "Add [F7]"
        End If
    End Sub

    Private Sub ChkOPENITEMFACILITY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkOPENITEMFACILITY.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmdAdd.Focus()
        End If
    End Sub

    Private Sub ssGrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssGrid.Advance

    End Sub

    Private Sub txtItemCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemCode.TextChanged

    End Sub

    Private Sub cbo_BaseUOM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_BaseUOM.SelectedIndexChanged

    End Sub

    Private Sub txtGroupcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroupcode.TextChanged

    End Sub

    Private Sub txtacctdesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtacctcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtacctcode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtPackingAcctin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cmdAccHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(LEDGERNAME,'') AS LEDGERNAME,'' AS  ACDESC FROM ITEMMASTER  "
        M_Groupby = " GROUP BY ISNULL(LEDGERNAME,'')"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(FREEZE,'N')<>'Y'"
        End If
        vform.Field = "LEDGERNAME"
        vform.vFormatstring = "             LEDGERNAME                  |              LEDGER CODE                                     "
        vform.vCaption = "ACCOUNT MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtAcctIn.Text = Trim(vform.keyfield & "")
            TXT_LEDGER.Text = Trim(vform.keyfield & "")
            'Call txtAcctIn_Validated(txtAcctIn, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txtAcctIn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAcctIn.TextChanged

    End Sub
    Private Sub txtAcctIn_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcctIn.Validated
        'Dim SQLSTRING As String
        'If Trim(txtAcctIn.Text) <> "" Then
        '    SQLSTRING = "SELECT acdesc  FROM Accountsglaccountmaster WHERE accode='" & Trim(txtAcctIn.Text) & "'"
        '    vconn.getDataSet(SQLSTRING, "Accountsglaccountmaster")
        '    If gdataset.Tables("Accountsglaccountmaster").Rows.Count > 0 Then
        '        txtAcctDesc.Text = ""
        '        txtAcctDesc.Text = Trim(gdataset.Tables("Accountsglaccountmaster").Rows(0).Item("acdesc"))
        '        txtAcctDesc.ReadOnly = True
        '        LstPOScode.Focus()
        '    Else
        '        txtAcctIn.Clear()
        '        txtAcctDesc.Clear()
        '        txtAcctIn.Focus()
        '    End If
        'Else
        '    txtAcctIn.Clear()
        '    txtAcctDesc.Clear()
        '    txtAcctIn.Focus()
        'End If
    End Sub
    Private Sub txtAcctIn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcctIn.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(txtAcctIn.Text)
            Call cmdAccHelp_Click(cmdAccHelp, e)
        End If
    End Sub
    Private Sub txtAcctIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAcctIn.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtAcctIn.Text) <> "" Then
                txtAcctIn_Validated(txtAcctIn, e)
            Else
                Call cmdAccHelp_Click(cmdAccHelp, e)
            End If
        End If
    End Sub

    Private Sub txtPurchaseRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPurchaseRate.TextChanged

    End Sub
    Private Sub txtPurchaseRate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPurchaseRate.KeyDown
        If Val(txtPurchaseRate.Text) < 0 Then
            txtPurchaseRate.Text = 0
        End If
    End Sub
    Private Sub txtRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.TextChanged
    End Sub
    Private Sub txtRate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRate.KeyDown
        If Val(txtRate.Text) < 0 Then
            txtRate.Text = 0
        End If
    End Sub

    Private Sub TXT_LEDGER_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_LEDGER.TextChanged

    End Sub
    Private Sub TXT_LEDGER_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_LEDGER.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(txtAcctIn.Text)
            Call cmdAccHelp_Click(cmdAccHelp, e)
        End If
    End Sub

    Private Sub optYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optYes.CheckedChanged

    End Sub

    Private Sub OptNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptNo.CheckedChanged

    End Sub
End Class