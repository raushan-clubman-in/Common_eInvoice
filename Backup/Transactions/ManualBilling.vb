Imports System.Data.SqlClient
Imports System.IO
Public Class ManualBilling
    Inherits System.Windows.Forms.Form
    Dim doctype, POScode As String
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal doctypebill As String, ByVal POScodeloc As String)

        MyBase.New()
        doctype = doctypebill
        POScode = POScodeloc
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
    Friend WithEvents lbl_SubPaymentMode As System.Windows.Forms.Label
    Friend WithEvents cbo_SubPaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents txt_KOTTime As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_Tableno As System.Windows.Forms.Label
    Friend WithEvents txt_Cover As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Covers As System.Windows.Forms.Label
    Friend WithEvents txt_TableNo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_KOTno As System.Windows.Forms.Label
    Friend WithEvents txt_KOTno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_KOTdate As System.Windows.Forms.Label
    Friend WithEvents lbl_Servercode As System.Windows.Forms.Label
    Friend WithEvents txt_ServerCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_ServerName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ServerName As System.Windows.Forms.Label
    Friend WithEvents lbl_Membercode As System.Windows.Forms.Label
    Friend WithEvents lbl_PaymentMode As System.Windows.Forms.Label
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MemberName As System.Windows.Forms.Label
    Friend WithEvents dtp_KOTdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp_ssgrid As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_TablenoHelp As System.Windows.Forms.Button
    Friend WithEvents grp_Tabledetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_KOTnoHelp As System.Windows.Forms.Button
    Friend WithEvents grp_KOTdetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_ServerCodeHelp As System.Windows.Forms.Button
    Friend WithEvents cbo_PaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents grp_Memberdetails As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Bill As System.Windows.Forms.Label
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents lbl_BillAmount As System.Windows.Forms.Label
    Friend WithEvents txt_BillAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt_TaxValue As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TaxValue As System.Windows.Forms.Label
    Friend WithEvents txt_TotalValue As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TotalValue As System.Windows.Forms.Label
    Friend WithEvents pnl_UOMCode As System.Windows.Forms.Panel
    Friend WithEvents lvw_Uom As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnl_POSCode As System.Windows.Forms.Panel
    Friend WithEvents lvw_POSCode As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents KOT_Timer As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents cmd_BillSettlement As System.Windows.Forms.Button
    Friend WithEvents lbl_Discount As System.Windows.Forms.Label
    Friend WithEvents txt_Discount As System.Windows.Forms.TextBox
    Friend WithEvents txt_PackingCharge As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Packingcharge As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grp_Paymentmodeselection As System.Windows.Forms.GroupBox
    Friend WithEvents txt_PartialPayment As System.Windows.Forms.TextBox
    Friend WithEvents lbl_PartialPayment As System.Windows.Forms.Label
    Friend WithEvents grp_Chequedetails As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Typeofcheque As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Draweebank As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Chequedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Chequeno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Draweebank As System.Windows.Forms.Label
    Friend WithEvents lbl_Chequedate As System.Windows.Forms.Label
    Friend WithEvents lbl_Chequeno As System.Windows.Forms.Label
    Friend WithEvents lbl_Typeofcheque As System.Windows.Forms.Label
    Friend WithEvents lbl_Chequedetails As System.Windows.Forms.Label
    Friend WithEvents grp_Carddetails As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Cardholdername As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Expirydate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Cardno As System.Windows.Forms.TextBox
    Friend WithEvents txt_Typeofcard As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cardholdername As System.Windows.Forms.Label
    Friend WithEvents lbl_Expirydate As System.Windows.Forms.Label
    Friend WithEvents lbl_Cardno As System.Windows.Forms.Label
    Friend WithEvents lbl_Typeofcard As System.Windows.Forms.Label
    Friend WithEvents lbl_Carddetails As System.Windows.Forms.Label
    Friend WithEvents lbl_Paymentmodeselection As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_Save As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_Back As System.Windows.Forms.Button
    Friend WithEvents ssgridPayment As AxFPSpreadADO.AxfpSpread
    Friend WithEvents grp_Memberfacility As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_FacilityMemberCode As System.Windows.Forms.Label
    Friend WithEvents txt_FacilityMemberName As System.Windows.Forms.TextBox
    Friend WithEvents txt_FacilityMemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FacilityMemberName As System.Windows.Forms.Label
    Friend WithEvents btn_FacilityMemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Facilityssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents lblCro As System.Windows.Forms.Label
    Friend WithEvents lblCro1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SETLEMENT_GROUP As System.Windows.Forms.GroupBox
    Friend WithEvents CMD_SETTLEMENT As System.Windows.Forms.Button
    Friend WithEvents LAB_BALANCEAMT As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ssgrid_settlement As AxFPSpreadADO.AxfpSpread
    Friend WithEvents CMB_BTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Pic_Member As System.Windows.Forms.PictureBox
    Friend WithEvents LOC_TXT As System.Windows.Forms.Label
    Friend WithEvents lab_servicename As System.Windows.Forms.Label
    Friend WithEvents LAB_MSTATUS As System.Windows.Forms.Label
    Friend WithEvents txt_card_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_SwipeCard As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Holder_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_holder_name As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_SwipeHelp As System.Windows.Forms.Button
    Friend WithEvents LBL_CARD_BALANCE As System.Windows.Forms.Label
    Friend WithEvents Pic_Spouse As System.Windows.Forms.PictureBox
    Friend WithEvents Pic_Sign As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Cmd_DC_Update As System.Windows.Forms.Button
    Friend WithEvents PNL_FACILITY As System.Windows.Forms.Panel
    Friend WithEvents SSGRIND1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents grp_facility As System.Windows.Forms.GroupBox
    Friend WithEvents ssgrid_Fac As AxFPSpreadADO.AxfpSpread
    Friend WithEvents lab_outstanding As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents CMD_FACILITY As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_recall As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents LAB_CARDBAL As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ManualBilling))
        Me.lbl_SubPaymentMode = New System.Windows.Forms.Label
        Me.cbo_SubPaymentMode = New System.Windows.Forms.ComboBox
        Me.txt_KOTTime = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.lbl_Tableno = New System.Windows.Forms.Label
        Me.txt_Cover = New System.Windows.Forms.TextBox
        Me.lbl_Covers = New System.Windows.Forms.Label
        Me.txt_TableNo = New System.Windows.Forms.TextBox
        Me.lbl_KOTno = New System.Windows.Forms.Label
        Me.txt_KOTno = New System.Windows.Forms.TextBox
        Me.lbl_KOTdate = New System.Windows.Forms.Label
        Me.lbl_Servercode = New System.Windows.Forms.Label
        Me.txt_ServerCode = New System.Windows.Forms.TextBox
        Me.txt_ServerName = New System.Windows.Forms.TextBox
        Me.lbl_ServerName = New System.Windows.Forms.Label
        Me.lbl_Membercode = New System.Windows.Forms.Label
        Me.lbl_PaymentMode = New System.Windows.Forms.Label
        Me.txt_MemberName = New System.Windows.Forms.TextBox
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.lbl_MemberName = New System.Windows.Forms.Label
        Me.dtp_KOTdate = New System.Windows.Forms.DateTimePicker
        Me.grp_ssgrid = New System.Windows.Forms.GroupBox
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.grp_facility = New System.Windows.Forms.GroupBox
        Me.ssgrid_Fac = New AxFPSpreadADO.AxfpSpread
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmd_TablenoHelp = New System.Windows.Forms.Button
        Me.grp_Tabledetails = New System.Windows.Forms.GroupBox
        Me.LAB_MSTATUS = New System.Windows.Forms.Label
        Me.LOC_TXT = New System.Windows.Forms.Label
        Me.CMB_BTYPE = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lab_servicename = New System.Windows.Forms.Label
        Me.cmd_KOTnoHelp = New System.Windows.Forms.Button
        Me.grp_KOTdetails = New System.Windows.Forms.GroupBox
        Me.Pic_Member = New System.Windows.Forms.PictureBox
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.cmd_ServerCodeHelp = New System.Windows.Forms.Button
        Me.cbo_PaymentMode = New System.Windows.Forms.ComboBox
        Me.grp_Memberdetails = New System.Windows.Forms.GroupBox
        Me.Txt_holder_name = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_Holder_Code = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Lbl_Bill = New System.Windows.Forms.Label
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.lbl_BillAmount = New System.Windows.Forms.Label
        Me.txt_BillAmount = New System.Windows.Forms.TextBox
        Me.txt_TaxValue = New System.Windows.Forms.TextBox
        Me.lbl_TaxValue = New System.Windows.Forms.Label
        Me.txt_TotalValue = New System.Windows.Forms.TextBox
        Me.lbl_TotalValue = New System.Windows.Forms.Label
        Me.pnl_UOMCode = New System.Windows.Forms.Panel
        Me.lvw_Uom = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.pnl_POSCode = New System.Windows.Forms.Panel
        Me.lvw_POSCode = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.KOT_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_Remarks = New System.Windows.Forms.TextBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.cmd_BillSettlement = New System.Windows.Forms.Button
        Me.txt_Discount = New System.Windows.Forms.TextBox
        Me.lbl_Discount = New System.Windows.Forms.Label
        Me.txt_PackingCharge = New System.Windows.Forms.TextBox
        Me.lbl_Packingcharge = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grp_Paymentmodeselection = New System.Windows.Forms.GroupBox
        Me.txt_PartialPayment = New System.Windows.Forms.TextBox
        Me.lbl_PartialPayment = New System.Windows.Forms.Label
        Me.grp_Chequedetails = New System.Windows.Forms.GroupBox
        Me.cbo_Typeofcheque = New System.Windows.Forms.ComboBox
        Me.txt_Draweebank = New System.Windows.Forms.TextBox
        Me.dtp_Chequedate = New System.Windows.Forms.DateTimePicker
        Me.txt_Chequeno = New System.Windows.Forms.TextBox
        Me.lbl_Draweebank = New System.Windows.Forms.Label
        Me.lbl_Chequedate = New System.Windows.Forms.Label
        Me.lbl_Chequeno = New System.Windows.Forms.Label
        Me.lbl_Typeofcheque = New System.Windows.Forms.Label
        Me.lbl_Chequedetails = New System.Windows.Forms.Label
        Me.grp_Carddetails = New System.Windows.Forms.GroupBox
        Me.txt_Cardholdername = New System.Windows.Forms.TextBox
        Me.dtp_Expirydate = New System.Windows.Forms.DateTimePicker
        Me.txt_Cardno = New System.Windows.Forms.TextBox
        Me.txt_Typeofcard = New System.Windows.Forms.TextBox
        Me.lbl_cardholdername = New System.Windows.Forms.Label
        Me.lbl_Expirydate = New System.Windows.Forms.Label
        Me.lbl_Cardno = New System.Windows.Forms.Label
        Me.lbl_Typeofcard = New System.Windows.Forms.Label
        Me.lbl_Carddetails = New System.Windows.Forms.Label
        Me.lbl_Paymentmodeselection = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmd_Save = New System.Windows.Forms.Button
        Me.cmd_Cancel = New System.Windows.Forms.Button
        Me.cmd_Back = New System.Windows.Forms.Button
        Me.ssgridPayment = New AxFPSpreadADO.AxfpSpread
        Me.grp_Memberfacility = New System.Windows.Forms.GroupBox
        Me.Facilityssgrid = New AxFPSpreadADO.AxfpSpread
        Me.lbl_FacilityMemberCode = New System.Windows.Forms.Label
        Me.txt_FacilityMemberName = New System.Windows.Forms.TextBox
        Me.txt_FacilityMemberCode = New System.Windows.Forms.TextBox
        Me.lbl_FacilityMemberName = New System.Windows.Forms.Label
        Me.btn_FacilityMemberCodeHelp = New System.Windows.Forms.Button
        Me.lblCro = New System.Windows.Forms.Label
        Me.lblCro1 = New System.Windows.Forms.Label
        Me.SETLEMENT_GROUP = New System.Windows.Forms.GroupBox
        Me.CMD_SETTLEMENT = New System.Windows.Forms.Button
        Me.LAB_BALANCEAMT = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ssgrid_settlement = New AxFPSpreadADO.AxfpSpread
        Me.txt_card_id = New System.Windows.Forms.TextBox
        Me.lbl_SwipeCard = New System.Windows.Forms.Button
        Me.Cmd_SwipeHelp = New System.Windows.Forms.Button
        Me.LBL_CARD_BALANCE = New System.Windows.Forms.Label
        Me.Pic_Spouse = New System.Windows.Forms.PictureBox
        Me.Pic_Sign = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cmd_DC_Update = New System.Windows.Forms.Button
        Me.PNL_FACILITY = New System.Windows.Forms.Panel
        Me.SSGRIND1 = New AxFPSpreadADO.AxfpSpread
        Me.lab_outstanding = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.CMD_FACILITY = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_recall = New System.Windows.Forms.Button
        Me.PictureBox8 = New System.Windows.Forms.PictureBox
        Me.LAB_CARDBAL = New System.Windows.Forms.Label
        Me.grp_ssgrid.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_facility.SuspendLayout()
        CType(Me.ssgrid_Fac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Tabledetails.SuspendLayout()
        Me.grp_KOTdetails.SuspendLayout()
        Me.grp_Memberdetails.SuspendLayout()
        Me.pnl_UOMCode.SuspendLayout()
        Me.pnl_POSCode.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp_Paymentmodeselection.SuspendLayout()
        Me.grp_Chequedetails.SuspendLayout()
        Me.grp_Carddetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ssgridPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Memberfacility.SuspendLayout()
        CType(Me.Facilityssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SETLEMENT_GROUP.SuspendLayout()
        CType(Me.ssgrid_settlement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_FACILITY.SuspendLayout()
        CType(Me.SSGRIND1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_SubPaymentMode
        '
        Me.lbl_SubPaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubPaymentMode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_SubPaymentMode.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_SubPaymentMode.Location = New System.Drawing.Point(519, 142)
        Me.lbl_SubPaymentMode.Name = "lbl_SubPaymentMode"
        Me.lbl_SubPaymentMode.Size = New System.Drawing.Size(218, 25)
        Me.lbl_SubPaymentMode.TabIndex = 36
        Me.lbl_SubPaymentMode.Text = "SUB PAYMENT MODE "
        Me.lbl_SubPaymentMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_SubPaymentMode.Visible = False
        '
        'cbo_SubPaymentMode
        '
        Me.cbo_SubPaymentMode.BackColor = System.Drawing.Color.White
        Me.cbo_SubPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SubPaymentMode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SubPaymentMode.Location = New System.Drawing.Point(744, 139)
        Me.cbo_SubPaymentMode.Name = "cbo_SubPaymentMode"
        Me.cbo_SubPaymentMode.Size = New System.Drawing.Size(200, 30)
        Me.cbo_SubPaymentMode.TabIndex = 1
        Me.cbo_SubPaymentMode.Visible = False
        '
        'txt_KOTTime
        '
        Me.txt_KOTTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_KOTTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_KOTTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_KOTTime.Location = New System.Drawing.Point(760, 91)
        Me.txt_KOTTime.Name = "txt_KOTTime"
        Me.txt_KOTTime.ReadOnly = True
        Me.txt_KOTTime.Size = New System.Drawing.Size(120, 26)
        Me.txt_KOTTime.TabIndex = 30
        Me.txt_KOTTime.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label16.Location = New System.Drawing.Point(392, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 35)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "BILLING"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Tableno
        '
        Me.lbl_Tableno.AutoSize = True
        Me.lbl_Tableno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tableno.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_Tableno.ForeColor = System.Drawing.Color.Brown
        Me.lbl_Tableno.Location = New System.Drawing.Point(272, 8)
        Me.lbl_Tableno.Name = "lbl_Tableno"
        Me.lbl_Tableno.Size = New System.Drawing.Size(124, 25)
        Me.lbl_Tableno.TabIndex = 23
        Me.lbl_Tableno.Text = "TABLE NO :"
        Me.lbl_Tableno.Visible = False
        '
        'txt_Cover
        '
        Me.txt_Cover.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Cover.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cover.Location = New System.Drawing.Point(392, 0)
        Me.txt_Cover.MaxLength = 9
        Me.txt_Cover.Name = "txt_Cover"
        Me.txt_Cover.Size = New System.Drawing.Size(56, 29)
        Me.txt_Cover.TabIndex = 15
        Me.txt_Cover.Text = ""
        Me.txt_Cover.Visible = False
        '
        'lbl_Covers
        '
        Me.lbl_Covers.AutoSize = True
        Me.lbl_Covers.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Covers.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_Covers.ForeColor = System.Drawing.Color.Brown
        Me.lbl_Covers.Location = New System.Drawing.Point(320, 8)
        Me.lbl_Covers.Name = "lbl_Covers"
        Me.lbl_Covers.Size = New System.Drawing.Size(101, 25)
        Me.lbl_Covers.TabIndex = 24
        Me.lbl_Covers.Text = "COVERS :"
        Me.lbl_Covers.Visible = False
        '
        'txt_TableNo
        '
        Me.txt_TableNo.BackColor = System.Drawing.Color.White
        Me.txt_TableNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TableNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TableNo.Location = New System.Drawing.Point(288, 8)
        Me.txt_TableNo.MaxLength = 10
        Me.txt_TableNo.Name = "txt_TableNo"
        Me.txt_TableNo.Size = New System.Drawing.Size(61, 29)
        Me.txt_TableNo.TabIndex = 14
        Me.txt_TableNo.Text = ""
        Me.txt_TableNo.Visible = False
        '
        'lbl_KOTno
        '
        Me.lbl_KOTno.AutoSize = True
        Me.lbl_KOTno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_KOTno.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_KOTno.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_KOTno.Location = New System.Drawing.Point(519, 56)
        Me.lbl_KOTno.Name = "lbl_KOTno"
        Me.lbl_KOTno.Size = New System.Drawing.Size(148, 25)
        Me.lbl_KOTno.TabIndex = 27
        Me.lbl_KOTno.Text = "MANUAL BILL "
        '
        'txt_KOTno
        '
        Me.txt_KOTno.BackColor = System.Drawing.Color.Wheat
        Me.txt_KOTno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_KOTno.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_KOTno.Location = New System.Drawing.Point(664, 51)
        Me.txt_KOTno.Name = "txt_KOTno"
        Me.txt_KOTno.Size = New System.Drawing.Size(192, 32)
        Me.txt_KOTno.TabIndex = 12
        Me.txt_KOTno.Text = ""
        '
        'lbl_KOTdate
        '
        Me.lbl_KOTdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_KOTdate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_KOTdate.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_KOTdate.Location = New System.Drawing.Point(523, 91)
        Me.lbl_KOTdate.Name = "lbl_KOTdate"
        Me.lbl_KOTdate.Size = New System.Drawing.Size(136, 25)
        Me.lbl_KOTdate.TabIndex = 28
        Me.lbl_KOTdate.Text = "BILL DATE "
        Me.lbl_KOTdate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Servercode
        '
        Me.lbl_Servercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Servercode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_Servercode.ForeColor = System.Drawing.Color.Black
        Me.lbl_Servercode.Location = New System.Drawing.Point(112, 248)
        Me.lbl_Servercode.Name = "lbl_Servercode"
        Me.lbl_Servercode.Size = New System.Drawing.Size(160, 25)
        Me.lbl_Servercode.TabIndex = 34
        Me.lbl_Servercode.Text = "SERVER CODE "
        Me.lbl_Servercode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_ServerCode
        '
        Me.txt_ServerCode.BackColor = System.Drawing.Color.White
        Me.txt_ServerCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerCode.Location = New System.Drawing.Point(280, 248)
        Me.txt_ServerCode.MaxLength = 15
        Me.txt_ServerCode.Name = "txt_ServerCode"
        Me.txt_ServerCode.Size = New System.Drawing.Size(168, 29)
        Me.txt_ServerCode.TabIndex = 3
        Me.txt_ServerCode.Text = ""
        '
        'txt_ServerName
        '
        Me.txt_ServerName.BackColor = System.Drawing.Color.White
        Me.txt_ServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerName.Location = New System.Drawing.Point(744, 248)
        Me.txt_ServerName.MaxLength = 50
        Me.txt_ServerName.Name = "txt_ServerName"
        Me.txt_ServerName.ReadOnly = True
        Me.txt_ServerName.Size = New System.Drawing.Size(200, 29)
        Me.txt_ServerName.TabIndex = 20
        Me.txt_ServerName.Text = ""
        '
        'lbl_ServerName
        '
        Me.lbl_ServerName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ServerName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_ServerName.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_ServerName.Location = New System.Drawing.Point(576, 251)
        Me.lbl_ServerName.Name = "lbl_ServerName"
        Me.lbl_ServerName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_ServerName.TabIndex = 40
        Me.lbl_ServerName.Text = "SERVER NAME "
        Me.lbl_ServerName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Membercode
        '
        Me.lbl_Membercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Membercode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_Membercode.ForeColor = System.Drawing.Color.Black
        Me.lbl_Membercode.Location = New System.Drawing.Point(112, 175)
        Me.lbl_Membercode.Name = "lbl_Membercode"
        Me.lbl_Membercode.Size = New System.Drawing.Size(160, 25)
        Me.lbl_Membercode.TabIndex = 33
        Me.lbl_Membercode.Text = "MEMBER CODE "
        Me.lbl_Membercode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_PaymentMode
        '
        Me.lbl_PaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PaymentMode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_PaymentMode.ForeColor = System.Drawing.Color.Black
        Me.lbl_PaymentMode.Location = New System.Drawing.Point(104, 139)
        Me.lbl_PaymentMode.Name = "lbl_PaymentMode"
        Me.lbl_PaymentMode.Size = New System.Drawing.Size(171, 25)
        Me.lbl_PaymentMode.TabIndex = 32
        Me.lbl_PaymentMode.Text = "PAYMENT MODE"
        Me.lbl_PaymentMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BackColor = System.Drawing.Color.White
        Me.txt_MemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(744, 177)
        Me.txt_MemberName.MaxLength = 50
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.ReadOnly = True
        Me.txt_MemberName.Size = New System.Drawing.Size(200, 29)
        Me.txt_MemberName.TabIndex = 19
        Me.txt_MemberName.Text = ""
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.White
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(280, 175)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(168, 29)
        Me.txt_MemberCode.TabIndex = 2
        Me.txt_MemberCode.Text = ""
        '
        'lbl_MemberName
        '
        Me.lbl_MemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_MemberName.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_MemberName.Location = New System.Drawing.Point(576, 177)
        Me.lbl_MemberName.Name = "lbl_MemberName"
        Me.lbl_MemberName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_MemberName.TabIndex = 39
        Me.lbl_MemberName.Text = "MEMBER NAME "
        Me.lbl_MemberName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtp_KOTdate
        '
        Me.dtp_KOTdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_KOTdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_KOTdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_KOTdate.Location = New System.Drawing.Point(664, 91)
        Me.dtp_KOTdate.Name = "dtp_KOTdate"
        Me.dtp_KOTdate.Size = New System.Drawing.Size(96, 26)
        Me.dtp_KOTdate.TabIndex = 13
        '
        'grp_ssgrid
        '
        Me.grp_ssgrid.BackColor = System.Drawing.Color.Transparent
        Me.grp_ssgrid.Controls.Add(Me.ssGrid)
        Me.grp_ssgrid.Location = New System.Drawing.Point(72, 288)
        Me.grp_ssgrid.Name = "grp_ssgrid"
        Me.grp_ssgrid.Size = New System.Drawing.Size(880, 224)
        Me.grp_ssgrid.TabIndex = 4
        Me.grp_ssgrid.TabStop = False
        '
        'ssGrid
        '
        Me.ssGrid.ContainingControl = Me
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(0, 8)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(1088, 216)
        Me.ssGrid.TabIndex = 0
        '
        'grp_facility
        '
        Me.grp_facility.BackColor = System.Drawing.Color.Transparent
        Me.grp_facility.Controls.Add(Me.ssgrid_Fac)
        Me.grp_facility.Controls.Add(Me.Button1)
        Me.grp_facility.Location = New System.Drawing.Point(72, 296)
        Me.grp_facility.Name = "grp_facility"
        Me.grp_facility.Size = New System.Drawing.Size(888, 216)
        Me.grp_facility.TabIndex = 592
        Me.grp_facility.TabStop = False
        '
        'ssgrid_Fac
        '
        Me.ssgrid_Fac.ContainingControl = Me
        Me.ssgrid_Fac.DataSource = Nothing
        Me.ssgrid_Fac.Location = New System.Drawing.Point(0, 12)
        Me.ssgrid_Fac.Name = "ssgrid_Fac"
        Me.ssgrid_Fac.OcxState = CType(resources.GetObject("ssgrid_Fac.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_Fac.Size = New System.Drawing.Size(888, 204)
        Me.ssgrid_Fac.TabIndex = 591
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(0, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 825
        Me.Button1.Text = "Clear[F6]"
        Me.Button1.Visible = False
        '
        'cmd_TablenoHelp
        '
        Me.cmd_TablenoHelp.Image = CType(resources.GetObject("cmd_TablenoHelp.Image"), System.Drawing.Image)
        Me.cmd_TablenoHelp.Location = New System.Drawing.Point(352, 8)
        Me.cmd_TablenoHelp.Name = "cmd_TablenoHelp"
        Me.cmd_TablenoHelp.Size = New System.Drawing.Size(23, 29)
        Me.cmd_TablenoHelp.TabIndex = 25
        Me.cmd_TablenoHelp.Visible = False
        '
        'grp_Tabledetails
        '
        Me.grp_Tabledetails.BackColor = System.Drawing.Color.Transparent
        Me.grp_Tabledetails.Controls.Add(Me.LAB_MSTATUS)
        Me.grp_Tabledetails.Controls.Add(Me.LOC_TXT)
        Me.grp_Tabledetails.Controls.Add(Me.CMB_BTYPE)
        Me.grp_Tabledetails.Controls.Add(Me.Label7)
        Me.grp_Tabledetails.Controls.Add(Me.cmd_TablenoHelp)
        Me.grp_Tabledetails.Controls.Add(Me.lab_servicename)
        Me.grp_Tabledetails.Controls.Add(Me.txt_TableNo)
        Me.grp_Tabledetails.Controls.Add(Me.lbl_Tableno)
        Me.grp_Tabledetails.Controls.Add(Me.lbl_Covers)
        Me.grp_Tabledetails.Location = New System.Drawing.Point(72, 35)
        Me.grp_Tabledetails.Name = "grp_Tabledetails"
        Me.grp_Tabledetails.Size = New System.Drawing.Size(424, 88)
        Me.grp_Tabledetails.TabIndex = 22
        Me.grp_Tabledetails.TabStop = False
        '
        'LAB_MSTATUS
        '
        Me.LAB_MSTATUS.AutoSize = True
        Me.LAB_MSTATUS.BackColor = System.Drawing.Color.Transparent
        Me.LAB_MSTATUS.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_MSTATUS.ForeColor = System.Drawing.Color.Black
        Me.LAB_MSTATUS.Location = New System.Drawing.Point(204, 16)
        Me.LAB_MSTATUS.Name = "LAB_MSTATUS"
        Me.LAB_MSTATUS.Size = New System.Drawing.Size(0, 25)
        Me.LAB_MSTATUS.TabIndex = 379
        Me.LAB_MSTATUS.Visible = False
        '
        'LOC_TXT
        '
        Me.LOC_TXT.AutoSize = True
        Me.LOC_TXT.BackColor = System.Drawing.Color.Transparent
        Me.LOC_TXT.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LOC_TXT.ForeColor = System.Drawing.Color.Black
        Me.LOC_TXT.Location = New System.Drawing.Point(208, 64)
        Me.LOC_TXT.Name = "LOC_TXT"
        Me.LOC_TXT.Size = New System.Drawing.Size(0, 25)
        Me.LOC_TXT.TabIndex = 378
        Me.LOC_TXT.Visible = False
        '
        'CMB_BTYPE
        '
        Me.CMB_BTYPE.BackColor = System.Drawing.Color.Wheat
        Me.CMB_BTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_BTYPE.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_BTYPE.Location = New System.Drawing.Point(209, 16)
        Me.CMB_BTYPE.Name = "CMB_BTYPE"
        Me.CMB_BTYPE.Size = New System.Drawing.Size(167, 30)
        Me.CMB_BTYPE.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(104, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 25)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Loc.Type"
        '
        'lab_servicename
        '
        Me.lab_servicename.AutoSize = True
        Me.lab_servicename.BackColor = System.Drawing.Color.Transparent
        Me.lab_servicename.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_servicename.ForeColor = System.Drawing.Color.Black
        Me.lab_servicename.Location = New System.Drawing.Point(216, 56)
        Me.lab_servicename.Name = "lab_servicename"
        Me.lab_servicename.Size = New System.Drawing.Size(0, 25)
        Me.lab_servicename.TabIndex = 41
        '
        'cmd_KOTnoHelp
        '
        Me.cmd_KOTnoHelp.Image = CType(resources.GetObject("cmd_KOTnoHelp.Image"), System.Drawing.Image)
        Me.cmd_KOTnoHelp.Location = New System.Drawing.Point(856, 51)
        Me.cmd_KOTnoHelp.Name = "cmd_KOTnoHelp"
        Me.cmd_KOTnoHelp.Size = New System.Drawing.Size(23, 32)
        Me.cmd_KOTnoHelp.TabIndex = 29
        '
        'grp_KOTdetails
        '
        Me.grp_KOTdetails.BackColor = System.Drawing.Color.Transparent
        Me.grp_KOTdetails.Controls.Add(Me.Pic_Member)
        Me.grp_KOTdetails.Location = New System.Drawing.Point(496, 35)
        Me.grp_KOTdetails.Name = "grp_KOTdetails"
        Me.grp_KOTdetails.Size = New System.Drawing.Size(456, 88)
        Me.grp_KOTdetails.TabIndex = 26
        Me.grp_KOTdetails.TabStop = False
        '
        'Pic_Member
        '
        Me.Pic_Member.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic_Member.Location = New System.Drawing.Point(384, 8)
        Me.Pic_Member.Name = "Pic_Member"
        Me.Pic_Member.Size = New System.Drawing.Size(71, 80)
        Me.Pic_Member.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Member.TabIndex = 593
        Me.Pic_Member.TabStop = False
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(448, 176)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(23, 29)
        Me.cmd_MemberCodeHelp.TabIndex = 35
        '
        'cmd_ServerCodeHelp
        '
        Me.cmd_ServerCodeHelp.Image = CType(resources.GetObject("cmd_ServerCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_ServerCodeHelp.Location = New System.Drawing.Point(448, 248)
        Me.cmd_ServerCodeHelp.Name = "cmd_ServerCodeHelp"
        Me.cmd_ServerCodeHelp.Size = New System.Drawing.Size(23, 29)
        Me.cmd_ServerCodeHelp.TabIndex = 37
        '
        'cbo_PaymentMode
        '
        Me.cbo_PaymentMode.BackColor = System.Drawing.Color.White
        Me.cbo_PaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_PaymentMode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_PaymentMode.Location = New System.Drawing.Point(280, 136)
        Me.cbo_PaymentMode.Name = "cbo_PaymentMode"
        Me.cbo_PaymentMode.Size = New System.Drawing.Size(168, 30)
        Me.cbo_PaymentMode.TabIndex = 0
        '
        'grp_Memberdetails
        '
        Me.grp_Memberdetails.BackColor = System.Drawing.Color.Transparent
        Me.grp_Memberdetails.Controls.Add(Me.Txt_holder_name)
        Me.grp_Memberdetails.Controls.Add(Me.Label6)
        Me.grp_Memberdetails.Controls.Add(Me.txt_Holder_Code)
        Me.grp_Memberdetails.Controls.Add(Me.Label5)
        Me.grp_Memberdetails.Location = New System.Drawing.Point(72, 120)
        Me.grp_Memberdetails.Name = "grp_Memberdetails"
        Me.grp_Memberdetails.Size = New System.Drawing.Size(880, 168)
        Me.grp_Memberdetails.TabIndex = 38
        Me.grp_Memberdetails.TabStop = False
        '
        'Txt_holder_name
        '
        Me.Txt_holder_name.BackColor = System.Drawing.Color.Wheat
        Me.Txt_holder_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_holder_name.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_holder_name.Location = New System.Drawing.Point(672, 88)
        Me.Txt_holder_name.MaxLength = 50
        Me.Txt_holder_name.Name = "Txt_holder_name"
        Me.Txt_holder_name.ReadOnly = True
        Me.Txt_holder_name.Size = New System.Drawing.Size(200, 29)
        Me.Txt_holder_name.TabIndex = 609
        Me.Txt_holder_name.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label6.Location = New System.Drawing.Point(504, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 25)
        Me.Label6.TabIndex = 608
        Me.Label6.Text = "CARD HOLDER "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_Holder_Code
        '
        Me.txt_Holder_Code.BackColor = System.Drawing.Color.Wheat
        Me.txt_Holder_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Holder_Code.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Holder_Code.Location = New System.Drawing.Point(208, 90)
        Me.txt_Holder_Code.MaxLength = 15
        Me.txt_Holder_Code.Name = "txt_Holder_Code"
        Me.txt_Holder_Code.ReadOnly = True
        Me.txt_Holder_Code.Size = New System.Drawing.Size(168, 29)
        Me.txt_Holder_Code.TabIndex = 607
        Me.txt_Holder_Code.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(40, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 25)
        Me.Label5.TabIndex = 606
        Me.Label5.Text = "CARD CODE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lbl_Bill
        '
        Me.Lbl_Bill.AutoSize = True
        Me.Lbl_Bill.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Bill.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bill.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_Bill.Location = New System.Drawing.Point(96, 552)
        Me.Lbl_Bill.Name = "Lbl_Bill"
        Me.Lbl_Bill.Size = New System.Drawing.Size(0, 28)
        Me.Lbl_Bill.TabIndex = 42
        Me.Lbl_Bill.Visible = False
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Status.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Status.Location = New System.Drawing.Point(96, 579)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(0, 25)
        Me.lbl_Status.TabIndex = 43
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_BillAmount
        '
        Me.lbl_BillAmount.AutoSize = True
        Me.lbl_BillAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillAmount.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillAmount.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_BillAmount.Location = New System.Drawing.Point(784, 554)
        Me.lbl_BillAmount.Name = "lbl_BillAmount"
        Me.lbl_BillAmount.Size = New System.Drawing.Size(85, 18)
        Me.lbl_BillAmount.TabIndex = 46
        Me.lbl_BillAmount.Text = "BILL VALUE"
        Me.lbl_BillAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_BillAmount
        '
        Me.txt_BillAmount.BackColor = System.Drawing.Color.White
        Me.txt_BillAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BillAmount.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BillAmount.Location = New System.Drawing.Point(872, 552)
        Me.txt_BillAmount.MaxLength = 50
        Me.txt_BillAmount.Name = "txt_BillAmount"
        Me.txt_BillAmount.Size = New System.Drawing.Size(80, 22)
        Me.txt_BillAmount.TabIndex = 18
        Me.txt_BillAmount.Text = ""
        Me.txt_BillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TaxValue
        '
        Me.txt_TaxValue.BackColor = System.Drawing.Color.White
        Me.txt_TaxValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TaxValue.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TaxValue.Location = New System.Drawing.Point(872, 520)
        Me.txt_TaxValue.MaxLength = 50
        Me.txt_TaxValue.Name = "txt_TaxValue"
        Me.txt_TaxValue.Size = New System.Drawing.Size(80, 22)
        Me.txt_TaxValue.TabIndex = 17
        Me.txt_TaxValue.Text = ""
        Me.txt_TaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_TaxValue
        '
        Me.lbl_TaxValue.AutoSize = True
        Me.lbl_TaxValue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TaxValue.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TaxValue.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_TaxValue.Location = New System.Drawing.Point(793, 522)
        Me.lbl_TaxValue.Name = "lbl_TaxValue"
        Me.lbl_TaxValue.Size = New System.Drawing.Size(85, 18)
        Me.lbl_TaxValue.TabIndex = 45
        Me.lbl_TaxValue.Text = "TAX VALUE "
        '
        'txt_TotalValue
        '
        Me.txt_TotalValue.BackColor = System.Drawing.Color.White
        Me.txt_TotalValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TotalValue.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalValue.Location = New System.Drawing.Point(711, 519)
        Me.txt_TotalValue.MaxLength = 50
        Me.txt_TotalValue.Name = "txt_TotalValue"
        Me.txt_TotalValue.Size = New System.Drawing.Size(73, 22)
        Me.txt_TotalValue.TabIndex = 16
        Me.txt_TotalValue.Text = ""
        Me.txt_TotalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_TotalValue
        '
        Me.lbl_TotalValue.AutoSize = True
        Me.lbl_TotalValue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TotalValue.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalValue.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_TotalValue.Location = New System.Drawing.Point(592, 522)
        Me.lbl_TotalValue.Name = "lbl_TotalValue"
        Me.lbl_TotalValue.Size = New System.Drawing.Size(101, 18)
        Me.lbl_TotalValue.TabIndex = 44
        Me.lbl_TotalValue.Text = "TOTAL VALUE "
        '
        'pnl_UOMCode
        '
        Me.pnl_UOMCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_UOMCode.Controls.Add(Me.lvw_Uom)
        Me.pnl_UOMCode.Location = New System.Drawing.Point(496, 1000)
        Me.pnl_UOMCode.Name = "pnl_UOMCode"
        Me.pnl_UOMCode.Size = New System.Drawing.Size(396, 224)
        Me.pnl_UOMCode.TabIndex = 394
        '
        'lvw_Uom
        '
        Me.lvw_Uom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader4})
        Me.lvw_Uom.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw_Uom.FullRowSelect = True
        Me.lvw_Uom.GridLines = True
        Me.lvw_Uom.HoverSelection = True
        Me.lvw_Uom.Location = New System.Drawing.Point(8, 8)
        Me.lvw_Uom.Name = "lvw_Uom"
        Me.lvw_Uom.Size = New System.Drawing.Size(376, 208)
        Me.lvw_Uom.TabIndex = 0
        Me.lvw_Uom.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "UOM Code"
        Me.ColumnHeader2.Width = 173
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "UOM Rate"
        Me.ColumnHeader4.Width = 199
        '
        'pnl_POSCode
        '
        Me.pnl_POSCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_POSCode.Controls.Add(Me.lvw_POSCode)
        Me.pnl_POSCode.Location = New System.Drawing.Point(80, 1000)
        Me.pnl_POSCode.Name = "pnl_POSCode"
        Me.pnl_POSCode.Size = New System.Drawing.Size(416, 224)
        Me.pnl_POSCode.TabIndex = 395
        '
        'lvw_POSCode
        '
        Me.lvw_POSCode.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3})
        Me.lvw_POSCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw_POSCode.FullRowSelect = True
        Me.lvw_POSCode.GridLines = True
        Me.lvw_POSCode.HideSelection = False
        Me.lvw_POSCode.HoverSelection = True
        Me.lvw_POSCode.Location = New System.Drawing.Point(8, 8)
        Me.lvw_POSCode.Name = "lvw_POSCode"
        Me.lvw_POSCode.Scrollable = False
        Me.lvw_POSCode.Size = New System.Drawing.Size(400, 200)
        Me.lvw_POSCode.TabIndex = 0
        Me.lvw_POSCode.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "POS Code"
        Me.ColumnHeader1.Width = 165
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "POS Desc"
        Me.ColumnHeader3.Width = 230
        '
        'KOT_Timer
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.cmd_Clear)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(967, 56)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(290, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(720, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.TabIndex = 12
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(576, 12)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(864, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(435, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(150, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(16, 13)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 825
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(-8, 640)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1072, 16)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "F4-->Help  F2-->Kot No   F3-->Delete Item  Alt+C-->Flash Card  Alt+P--> Payment M" & _
        "ode   Alt+B--> Member Code  Alt+S--> Server Code Alt+G-->Focus on Grid Alt+K-> R" & _
        "emarks   Alt+D ->Date"
        '
        'Txt_Remarks
        '
        Me.Txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Remarks.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Remarks.Location = New System.Drawing.Point(208, 521)
        Me.Txt_Remarks.Name = "Txt_Remarks"
        Me.Txt_Remarks.Size = New System.Drawing.Size(368, 29)
        Me.Txt_Remarks.TabIndex = 5
        Me.Txt_Remarks.Text = ""
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(88, 524)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(113, 25)
        Me.lbl_Remarks.TabIndex = 41
        Me.lbl_Remarks.Text = "REMARKS "
        Me.lbl_Remarks.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmd_BillSettlement
        '
        Me.cmd_BillSettlement.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_BillSettlement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_BillSettlement.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_BillSettlement.ForeColor = System.Drawing.Color.Black
        Me.cmd_BillSettlement.Image = CType(resources.GetObject("cmd_BillSettlement.Image"), System.Drawing.Image)
        Me.cmd_BillSettlement.Location = New System.Drawing.Point(240, -16)
        Me.cmd_BillSettlement.Name = "cmd_BillSettlement"
        Me.cmd_BillSettlement.Size = New System.Drawing.Size(104, 32)
        Me.cmd_BillSettlement.TabIndex = 396
        Me.cmd_BillSettlement.Text = "Bill Settle [F5]"
        Me.cmd_BillSettlement.Visible = False
        '
        'txt_Discount
        '
        Me.txt_Discount.BackColor = System.Drawing.Color.White
        Me.txt_Discount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Discount.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Discount.Location = New System.Drawing.Point(904, 504)
        Me.txt_Discount.MaxLength = 2
        Me.txt_Discount.Name = "txt_Discount"
        Me.txt_Discount.Size = New System.Drawing.Size(80, 22)
        Me.txt_Discount.TabIndex = 397
        Me.txt_Discount.Text = ""
        Me.txt_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Discount.Visible = False
        '
        'lbl_Discount
        '
        Me.lbl_Discount.AutoSize = True
        Me.lbl_Discount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Discount.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Discount.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_Discount.Location = New System.Drawing.Point(832, 504)
        Me.lbl_Discount.Name = "lbl_Discount"
        Me.lbl_Discount.Size = New System.Drawing.Size(85, 18)
        Me.lbl_Discount.TabIndex = 398
        Me.lbl_Discount.Text = "DISCOUNT :"
        Me.lbl_Discount.Visible = False
        '
        'txt_PackingCharge
        '
        Me.txt_PackingCharge.BackColor = System.Drawing.Color.White
        Me.txt_PackingCharge.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PackingCharge.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PackingCharge.Location = New System.Drawing.Point(712, 552)
        Me.txt_PackingCharge.MaxLength = 50
        Me.txt_PackingCharge.Name = "txt_PackingCharge"
        Me.txt_PackingCharge.Size = New System.Drawing.Size(72, 22)
        Me.txt_PackingCharge.TabIndex = 399
        Me.txt_PackingCharge.Text = ""
        Me.txt_PackingCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Packingcharge
        '
        Me.lbl_Packingcharge.AutoSize = True
        Me.lbl_Packingcharge.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Packingcharge.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Packingcharge.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbl_Packingcharge.Location = New System.Drawing.Point(522, 555)
        Me.lbl_Packingcharge.Name = "lbl_Packingcharge"
        Me.lbl_Packingcharge.Size = New System.Drawing.Size(182, 18)
        Me.lbl_Packingcharge.TabIndex = 400
        Me.lbl_Packingcharge.Text = "PACKING/SERV./SUR CHRG"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(984, 512)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 401
        Me.Label1.Text = "%"
        Me.Label1.Visible = False
        '
        'grp_Paymentmodeselection
        '
        Me.grp_Paymentmodeselection.BackgroundImage = CType(resources.GetObject("grp_Paymentmodeselection.BackgroundImage"), System.Drawing.Image)
        Me.grp_Paymentmodeselection.Controls.Add(Me.txt_PartialPayment)
        Me.grp_Paymentmodeselection.Controls.Add(Me.lbl_PartialPayment)
        Me.grp_Paymentmodeselection.Controls.Add(Me.grp_Chequedetails)
        Me.grp_Paymentmodeselection.Controls.Add(Me.grp_Carddetails)
        Me.grp_Paymentmodeselection.Controls.Add(Me.lbl_Paymentmodeselection)
        Me.grp_Paymentmodeselection.Controls.Add(Me.GroupBox1)
        Me.grp_Paymentmodeselection.Controls.Add(Me.ssgridPayment)
        Me.grp_Paymentmodeselection.Location = New System.Drawing.Point(81, 1000)
        Me.grp_Paymentmodeselection.Name = "grp_Paymentmodeselection"
        Me.grp_Paymentmodeselection.Size = New System.Drawing.Size(864, 304)
        Me.grp_Paymentmodeselection.TabIndex = 402
        Me.grp_Paymentmodeselection.TabStop = False
        '
        'txt_PartialPayment
        '
        Me.txt_PartialPayment.BackColor = System.Drawing.Color.Wheat
        Me.txt_PartialPayment.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartialPayment.Location = New System.Drawing.Point(663, 256)
        Me.txt_PartialPayment.MaxLength = 12
        Me.txt_PartialPayment.Name = "txt_PartialPayment"
        Me.txt_PartialPayment.ReadOnly = True
        Me.txt_PartialPayment.Size = New System.Drawing.Size(192, 29)
        Me.txt_PartialPayment.TabIndex = 39
        Me.txt_PartialPayment.Text = ""
        Me.txt_PartialPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_PartialPayment
        '
        Me.lbl_PartialPayment.AutoSize = True
        Me.lbl_PartialPayment.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PartialPayment.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PartialPayment.Location = New System.Drawing.Point(496, 256)
        Me.lbl_PartialPayment.Name = "lbl_PartialPayment"
        Me.lbl_PartialPayment.Size = New System.Drawing.Size(160, 25)
        Me.lbl_PartialPayment.TabIndex = 38
        Me.lbl_PartialPayment.Text = "BILL AMOUNT :"
        '
        'grp_Chequedetails
        '
        Me.grp_Chequedetails.BackgroundImage = CType(resources.GetObject("grp_Chequedetails.BackgroundImage"), System.Drawing.Image)
        Me.grp_Chequedetails.Controls.Add(Me.cbo_Typeofcheque)
        Me.grp_Chequedetails.Controls.Add(Me.txt_Draweebank)
        Me.grp_Chequedetails.Controls.Add(Me.dtp_Chequedate)
        Me.grp_Chequedetails.Controls.Add(Me.txt_Chequeno)
        Me.grp_Chequedetails.Controls.Add(Me.lbl_Draweebank)
        Me.grp_Chequedetails.Controls.Add(Me.lbl_Chequedate)
        Me.grp_Chequedetails.Controls.Add(Me.lbl_Chequeno)
        Me.grp_Chequedetails.Controls.Add(Me.lbl_Typeofcheque)
        Me.grp_Chequedetails.Controls.Add(Me.lbl_Chequedetails)
        Me.grp_Chequedetails.Location = New System.Drawing.Point(355, 1000)
        Me.grp_Chequedetails.Name = "grp_Chequedetails"
        Me.grp_Chequedetails.Size = New System.Drawing.Size(370, 164)
        Me.grp_Chequedetails.TabIndex = 1
        Me.grp_Chequedetails.TabStop = False
        '
        'cbo_Typeofcheque
        '
        Me.cbo_Typeofcheque.BackColor = System.Drawing.Color.Wheat
        Me.cbo_Typeofcheque.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Typeofcheque.Items.AddRange(New Object() {"PO", "DD", "CHEQUE"})
        Me.cbo_Typeofcheque.Location = New System.Drawing.Point(184, 38)
        Me.cbo_Typeofcheque.Name = "cbo_Typeofcheque"
        Me.cbo_Typeofcheque.Size = New System.Drawing.Size(168, 25)
        Me.cbo_Typeofcheque.TabIndex = 0
        '
        'txt_Draweebank
        '
        Me.txt_Draweebank.BackColor = System.Drawing.Color.Wheat
        Me.txt_Draweebank.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Draweebank.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Draweebank.Location = New System.Drawing.Point(184, 126)
        Me.txt_Draweebank.MaxLength = 20
        Me.txt_Draweebank.Name = "txt_Draweebank"
        Me.txt_Draweebank.Size = New System.Drawing.Size(168, 25)
        Me.txt_Draweebank.TabIndex = 3
        Me.txt_Draweebank.Text = ""
        '
        'dtp_Chequedate
        '
        Me.dtp_Chequedate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Chequedate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Chequedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Chequedate.Location = New System.Drawing.Point(184, 96)
        Me.dtp_Chequedate.Name = "dtp_Chequedate"
        Me.dtp_Chequedate.Size = New System.Drawing.Size(168, 25)
        Me.dtp_Chequedate.TabIndex = 2
        '
        'txt_Chequeno
        '
        Me.txt_Chequeno.BackColor = System.Drawing.Color.Wheat
        Me.txt_Chequeno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Chequeno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Chequeno.Location = New System.Drawing.Point(184, 66)
        Me.txt_Chequeno.MaxLength = 20
        Me.txt_Chequeno.Name = "txt_Chequeno"
        Me.txt_Chequeno.Size = New System.Drawing.Size(168, 25)
        Me.txt_Chequeno.TabIndex = 1
        Me.txt_Chequeno.Text = ""
        '
        'lbl_Draweebank
        '
        Me.lbl_Draweebank.AutoSize = True
        Me.lbl_Draweebank.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Draweebank.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Draweebank.Location = New System.Drawing.Point(40, 127)
        Me.lbl_Draweebank.Name = "lbl_Draweebank"
        Me.lbl_Draweebank.Size = New System.Drawing.Size(126, 20)
        Me.lbl_Draweebank.TabIndex = 8
        Me.lbl_Draweebank.Text = "DRAWEE BANK :"
        '
        'lbl_Chequedate
        '
        Me.lbl_Chequedate.AutoSize = True
        Me.lbl_Chequedate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Chequedate.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Chequedate.Location = New System.Drawing.Point(40, 98)
        Me.lbl_Chequedate.Name = "lbl_Chequedate"
        Me.lbl_Chequedate.Size = New System.Drawing.Size(126, 20)
        Me.lbl_Chequedate.TabIndex = 7
        Me.lbl_Chequedate.Text = "CHEQUE DATE :"
        '
        'lbl_Chequeno
        '
        Me.lbl_Chequeno.AutoSize = True
        Me.lbl_Chequeno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Chequeno.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Chequeno.Location = New System.Drawing.Point(59, 69)
        Me.lbl_Chequeno.Name = "lbl_Chequeno"
        Me.lbl_Chequeno.Size = New System.Drawing.Size(107, 20)
        Me.lbl_Chequeno.TabIndex = 6
        Me.lbl_Chequeno.Text = "CHEQUE NO :"
        '
        'lbl_Typeofcheque
        '
        Me.lbl_Typeofcheque.AutoSize = True
        Me.lbl_Typeofcheque.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Typeofcheque.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Typeofcheque.Location = New System.Drawing.Point(12, 40)
        Me.lbl_Typeofcheque.Name = "lbl_Typeofcheque"
        Me.lbl_Typeofcheque.Size = New System.Drawing.Size(154, 20)
        Me.lbl_Typeofcheque.TabIndex = 5
        Me.lbl_Typeofcheque.Text = "TYPE OF CHEQUE :"
        '
        'lbl_Chequedetails
        '
        Me.lbl_Chequedetails.BackColor = System.Drawing.Color.Maroon
        Me.lbl_Chequedetails.ForeColor = System.Drawing.Color.White
        Me.lbl_Chequedetails.Location = New System.Drawing.Point(0, 8)
        Me.lbl_Chequedetails.Name = "lbl_Chequedetails"
        Me.lbl_Chequedetails.Size = New System.Drawing.Size(368, 24)
        Me.lbl_Chequedetails.TabIndex = 4
        Me.lbl_Chequedetails.Text = "CHEQUE DETAILS :"
        '
        'grp_Carddetails
        '
        Me.grp_Carddetails.BackgroundImage = CType(resources.GetObject("grp_Carddetails.BackgroundImage"), System.Drawing.Image)
        Me.grp_Carddetails.Controls.Add(Me.txt_Cardholdername)
        Me.grp_Carddetails.Controls.Add(Me.dtp_Expirydate)
        Me.grp_Carddetails.Controls.Add(Me.txt_Cardno)
        Me.grp_Carddetails.Controls.Add(Me.txt_Typeofcard)
        Me.grp_Carddetails.Controls.Add(Me.lbl_cardholdername)
        Me.grp_Carddetails.Controls.Add(Me.lbl_Expirydate)
        Me.grp_Carddetails.Controls.Add(Me.lbl_Cardno)
        Me.grp_Carddetails.Controls.Add(Me.lbl_Typeofcard)
        Me.grp_Carddetails.Controls.Add(Me.lbl_Carddetails)
        Me.grp_Carddetails.Location = New System.Drawing.Point(344, 1000)
        Me.grp_Carddetails.Name = "grp_Carddetails"
        Me.grp_Carddetails.Size = New System.Drawing.Size(368, 160)
        Me.grp_Carddetails.TabIndex = 0
        Me.grp_Carddetails.TabStop = False
        '
        'txt_Cardholdername
        '
        Me.txt_Cardholdername.BackColor = System.Drawing.Color.Wheat
        Me.txt_Cardholdername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Cardholdername.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cardholdername.Location = New System.Drawing.Point(184, 126)
        Me.txt_Cardholdername.MaxLength = 35
        Me.txt_Cardholdername.Name = "txt_Cardholdername"
        Me.txt_Cardholdername.Size = New System.Drawing.Size(168, 25)
        Me.txt_Cardholdername.TabIndex = 3
        Me.txt_Cardholdername.Text = ""
        '
        'dtp_Expirydate
        '
        Me.dtp_Expirydate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Expirydate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Expirydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Expirydate.Location = New System.Drawing.Point(184, 96)
        Me.dtp_Expirydate.Name = "dtp_Expirydate"
        Me.dtp_Expirydate.Size = New System.Drawing.Size(168, 25)
        Me.dtp_Expirydate.TabIndex = 2
        '
        'txt_Cardno
        '
        Me.txt_Cardno.BackColor = System.Drawing.Color.Wheat
        Me.txt_Cardno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Cardno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cardno.Location = New System.Drawing.Point(184, 66)
        Me.txt_Cardno.MaxLength = 20
        Me.txt_Cardno.Name = "txt_Cardno"
        Me.txt_Cardno.Size = New System.Drawing.Size(168, 25)
        Me.txt_Cardno.TabIndex = 1
        Me.txt_Cardno.Text = ""
        '
        'txt_Typeofcard
        '
        Me.txt_Typeofcard.BackColor = System.Drawing.Color.Wheat
        Me.txt_Typeofcard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Typeofcard.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Typeofcard.Location = New System.Drawing.Point(184, 37)
        Me.txt_Typeofcard.MaxLength = 20
        Me.txt_Typeofcard.Name = "txt_Typeofcard"
        Me.txt_Typeofcard.Size = New System.Drawing.Size(168, 25)
        Me.txt_Typeofcard.TabIndex = 0
        Me.txt_Typeofcard.Text = ""
        '
        'lbl_cardholdername
        '
        Me.lbl_cardholdername.AutoSize = True
        Me.lbl_cardholdername.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cardholdername.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cardholdername.Location = New System.Drawing.Point(8, 128)
        Me.lbl_cardholdername.Name = "lbl_cardholdername"
        Me.lbl_cardholdername.Size = New System.Drawing.Size(172, 20)
        Me.lbl_cardholdername.TabIndex = 8
        Me.lbl_cardholdername.Text = "CARD HOLDER NAME :"
        '
        'lbl_Expirydate
        '
        Me.lbl_Expirydate.AutoSize = True
        Me.lbl_Expirydate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Expirydate.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Expirydate.Location = New System.Drawing.Point(54, 102)
        Me.lbl_Expirydate.Name = "lbl_Expirydate"
        Me.lbl_Expirydate.Size = New System.Drawing.Size(126, 20)
        Me.lbl_Expirydate.TabIndex = 7
        Me.lbl_Expirydate.Text = "EXPIRY DATE :"
        '
        'lbl_Cardno
        '
        Me.lbl_Cardno.AutoSize = True
        Me.lbl_Cardno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Cardno.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cardno.Location = New System.Drawing.Point(91, 71)
        Me.lbl_Cardno.Name = "lbl_Cardno"
        Me.lbl_Cardno.Size = New System.Drawing.Size(89, 20)
        Me.lbl_Cardno.TabIndex = 6
        Me.lbl_Cardno.Text = "CARD NO :"
        '
        'lbl_Typeofcard
        '
        Me.lbl_Typeofcard.AutoSize = True
        Me.lbl_Typeofcard.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Typeofcard.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Typeofcard.Location = New System.Drawing.Point(45, 40)
        Me.lbl_Typeofcard.Name = "lbl_Typeofcard"
        Me.lbl_Typeofcard.Size = New System.Drawing.Size(135, 20)
        Me.lbl_Typeofcard.TabIndex = 5
        Me.lbl_Typeofcard.Text = "TYPE OF CARD :"
        '
        'lbl_Carddetails
        '
        Me.lbl_Carddetails.BackColor = System.Drawing.Color.Maroon
        Me.lbl_Carddetails.ForeColor = System.Drawing.Color.White
        Me.lbl_Carddetails.Location = New System.Drawing.Point(0, 8)
        Me.lbl_Carddetails.Name = "lbl_Carddetails"
        Me.lbl_Carddetails.Size = New System.Drawing.Size(368, 24)
        Me.lbl_Carddetails.TabIndex = 4
        Me.lbl_Carddetails.Text = "CARD DETAILS :"
        '
        'lbl_Paymentmodeselection
        '
        Me.lbl_Paymentmodeselection.BackColor = System.Drawing.Color.Maroon
        Me.lbl_Paymentmodeselection.ForeColor = System.Drawing.Color.White
        Me.lbl_Paymentmodeselection.Location = New System.Drawing.Point(5, 10)
        Me.lbl_Paymentmodeselection.Name = "lbl_Paymentmodeselection"
        Me.lbl_Paymentmodeselection.Size = New System.Drawing.Size(851, 24)
        Me.lbl_Paymentmodeselection.TabIndex = 5
        Me.lbl_Paymentmodeselection.Text = "PAYMENT MODE SELECTION :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.cmd_Save)
        Me.GroupBox1.Controls.Add(Me.cmd_Cancel)
        Me.GroupBox1.Controls.Add(Me.cmd_Back)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 53)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'cmd_Save
        '
        Me.cmd_Save.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Save.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Save.ForeColor = System.Drawing.Color.White
        Me.cmd_Save.Image = CType(resources.GetObject("cmd_Save.Image"), System.Drawing.Image)
        Me.cmd_Save.Location = New System.Drawing.Point(144, 16)
        Me.cmd_Save.Name = "cmd_Save"
        Me.cmd_Save.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Save.TabIndex = 1
        Me.cmd_Save.Text = "SAVE"
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Cancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Cancel.ForeColor = System.Drawing.Color.White
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.Location = New System.Drawing.Point(264, 16)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Cancel.TabIndex = 2
        Me.cmd_Cancel.Text = "CLEAR"
        '
        'cmd_Back
        '
        Me.cmd_Back.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Back.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Back.ForeColor = System.Drawing.Color.White
        Me.cmd_Back.Image = CType(resources.GetObject("cmd_Back.Image"), System.Drawing.Image)
        Me.cmd_Back.Location = New System.Drawing.Point(24, 14)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Back.TabIndex = 0
        Me.cmd_Back.Text = "BACK"
        '
        'ssgridPayment
        '
        Me.ssgridPayment.ContainingControl = Me
        Me.ssgridPayment.DataSource = Nothing
        Me.ssgridPayment.Location = New System.Drawing.Point(8, 41)
        Me.ssgridPayment.Name = "ssgridPayment"
        Me.ssgridPayment.OcxState = CType(resources.GetObject("ssgridPayment.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgridPayment.Size = New System.Drawing.Size(848, 200)
        Me.ssgridPayment.TabIndex = 37
        '
        'grp_Memberfacility
        '
        Me.grp_Memberfacility.BackgroundImage = CType(resources.GetObject("grp_Memberfacility.BackgroundImage"), System.Drawing.Image)
        Me.grp_Memberfacility.Controls.Add(Me.Facilityssgrid)
        Me.grp_Memberfacility.Controls.Add(Me.lbl_FacilityMemberCode)
        Me.grp_Memberfacility.Controls.Add(Me.txt_FacilityMemberName)
        Me.grp_Memberfacility.Controls.Add(Me.txt_FacilityMemberCode)
        Me.grp_Memberfacility.Controls.Add(Me.lbl_FacilityMemberName)
        Me.grp_Memberfacility.Controls.Add(Me.btn_FacilityMemberCodeHelp)
        Me.grp_Memberfacility.Location = New System.Drawing.Point(72, 1000)
        Me.grp_Memberfacility.Name = "grp_Memberfacility"
        Me.grp_Memberfacility.Size = New System.Drawing.Size(880, 344)
        Me.grp_Memberfacility.TabIndex = 403
        Me.grp_Memberfacility.TabStop = False
        '
        'Facilityssgrid
        '
        Me.Facilityssgrid.ContainingControl = Me
        Me.Facilityssgrid.DataSource = Nothing
        Me.Facilityssgrid.Location = New System.Drawing.Point(24, 72)
        Me.Facilityssgrid.Name = "Facilityssgrid"
        Me.Facilityssgrid.OcxState = CType(resources.GetObject("Facilityssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Facilityssgrid.Size = New System.Drawing.Size(840, 264)
        Me.Facilityssgrid.TabIndex = 45
        '
        'lbl_FacilityMemberCode
        '
        Me.lbl_FacilityMemberCode.AutoSize = True
        Me.lbl_FacilityMemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FacilityMemberCode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_FacilityMemberCode.Location = New System.Drawing.Point(24, 24)
        Me.lbl_FacilityMemberCode.Name = "lbl_FacilityMemberCode"
        Me.lbl_FacilityMemberCode.Size = New System.Drawing.Size(160, 25)
        Me.lbl_FacilityMemberCode.TabIndex = 42
        Me.lbl_FacilityMemberCode.Text = "MEMBER CODE :"
        '
        'txt_FacilityMemberName
        '
        Me.txt_FacilityMemberName.BackColor = System.Drawing.Color.Wheat
        Me.txt_FacilityMemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_FacilityMemberName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FacilityMemberName.Location = New System.Drawing.Point(648, 24)
        Me.txt_FacilityMemberName.MaxLength = 50
        Me.txt_FacilityMemberName.Name = "txt_FacilityMemberName"
        Me.txt_FacilityMemberName.ReadOnly = True
        Me.txt_FacilityMemberName.Size = New System.Drawing.Size(200, 29)
        Me.txt_FacilityMemberName.TabIndex = 41
        Me.txt_FacilityMemberName.Text = ""
        '
        'txt_FacilityMemberCode
        '
        Me.txt_FacilityMemberCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_FacilityMemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_FacilityMemberCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FacilityMemberCode.Location = New System.Drawing.Point(208, 24)
        Me.txt_FacilityMemberCode.MaxLength = 15
        Me.txt_FacilityMemberCode.Name = "txt_FacilityMemberCode"
        Me.txt_FacilityMemberCode.ReadOnly = True
        Me.txt_FacilityMemberCode.Size = New System.Drawing.Size(168, 29)
        Me.txt_FacilityMemberCode.TabIndex = 40
        Me.txt_FacilityMemberCode.Text = ""
        '
        'lbl_FacilityMemberName
        '
        Me.lbl_FacilityMemberName.AutoSize = True
        Me.lbl_FacilityMemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FacilityMemberName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_FacilityMemberName.Location = New System.Drawing.Point(464, 24)
        Me.lbl_FacilityMemberName.Name = "lbl_FacilityMemberName"
        Me.lbl_FacilityMemberName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_FacilityMemberName.TabIndex = 44
        Me.lbl_FacilityMemberName.Text = "MEMBER NAME :"
        '
        'btn_FacilityMemberCodeHelp
        '
        Me.btn_FacilityMemberCodeHelp.Image = CType(resources.GetObject("btn_FacilityMemberCodeHelp.Image"), System.Drawing.Image)
        Me.btn_FacilityMemberCodeHelp.Location = New System.Drawing.Point(376, 24)
        Me.btn_FacilityMemberCodeHelp.Name = "btn_FacilityMemberCodeHelp"
        Me.btn_FacilityMemberCodeHelp.Size = New System.Drawing.Size(23, 29)
        Me.btn_FacilityMemberCodeHelp.TabIndex = 43
        '
        'lblCro
        '
        Me.lblCro.BackColor = System.Drawing.Color.Transparent
        Me.lblCro.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCro.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblCro.Location = New System.Drawing.Point(189, 8)
        Me.lblCro.Name = "lblCro"
        Me.lblCro.Size = New System.Drawing.Size(214, 16)
        Me.lblCro.TabIndex = 405
        Me.lblCro.Visible = False
        '
        'lblCro1
        '
        Me.lblCro1.BackColor = System.Drawing.Color.Transparent
        Me.lblCro1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCro1.ForeColor = System.Drawing.Color.Brown
        Me.lblCro1.Location = New System.Drawing.Point(72, 8)
        Me.lblCro1.Name = "lblCro1"
        Me.lblCro1.Size = New System.Drawing.Size(120, 16)
        Me.lblCro1.TabIndex = 404
        Me.lblCro1.Text = "MRP/CRO NO : "
        Me.lblCro1.Visible = False
        '
        'SETLEMENT_GROUP
        '
        Me.SETLEMENT_GROUP.BackColor = System.Drawing.Color.Transparent
        Me.SETLEMENT_GROUP.Controls.Add(Me.CMD_SETTLEMENT)
        Me.SETLEMENT_GROUP.Controls.Add(Me.LAB_BALANCEAMT)
        Me.SETLEMENT_GROUP.Controls.Add(Me.Label4)
        Me.SETLEMENT_GROUP.Controls.Add(Me.ssgrid_settlement)
        Me.SETLEMENT_GROUP.Controls.Add(Me.cmd_BillSettlement)
        Me.SETLEMENT_GROUP.Location = New System.Drawing.Point(112, 704)
        Me.SETLEMENT_GROUP.Name = "SETLEMENT_GROUP"
        Me.SETLEMENT_GROUP.Size = New System.Drawing.Size(856, 512)
        Me.SETLEMENT_GROUP.TabIndex = 406
        Me.SETLEMENT_GROUP.TabStop = False
        '
        'CMD_SETTLEMENT
        '
        Me.CMD_SETTLEMENT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_SETTLEMENT.ForeColor = System.Drawing.Color.Yellow
        Me.CMD_SETTLEMENT.Image = CType(resources.GetObject("CMD_SETTLEMENT.Image"), System.Drawing.Image)
        Me.CMD_SETTLEMENT.Location = New System.Drawing.Point(304, 368)
        Me.CMD_SETTLEMENT.Name = "CMD_SETTLEMENT"
        Me.CMD_SETTLEMENT.Size = New System.Drawing.Size(160, 48)
        Me.CMD_SETTLEMENT.TabIndex = 6
        Me.CMD_SETTLEMENT.Text = "SETTLEMENT"
        '
        'LAB_BALANCEAMT
        '
        Me.LAB_BALANCEAMT.AutoSize = True
        Me.LAB_BALANCEAMT.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_BALANCEAMT.ForeColor = System.Drawing.Color.Brown
        Me.LAB_BALANCEAMT.Location = New System.Drawing.Point(304, 312)
        Me.LAB_BALANCEAMT.Name = "LAB_BALANCEAMT"
        Me.LAB_BALANCEAMT.Size = New System.Drawing.Size(185, 23)
        Me.LAB_BALANCEAMT.TabIndex = 5
        Me.LAB_BALANCEAMT.Text = "BALANCE AMOUNT:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(272, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SETTLEMENT"
        '
        'ssgrid_settlement
        '
        Me.ssgrid_settlement.ContainingControl = Me
        Me.ssgrid_settlement.DataSource = Nothing
        Me.ssgrid_settlement.Location = New System.Drawing.Point(88, 80)
        Me.ssgrid_settlement.Name = "ssgrid_settlement"
        Me.ssgrid_settlement.OcxState = CType(resources.GetObject("ssgrid_settlement.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_settlement.Size = New System.Drawing.Size(632, 208)
        Me.ssgrid_settlement.TabIndex = 3
        '
        'txt_card_id
        '
        Me.txt_card_id.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txt_card_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_card_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_card_id.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_card_id.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_card_id.Location = New System.Drawing.Point(664, 6)
        Me.txt_card_id.MaxLength = 25
        Me.txt_card_id.Name = "txt_card_id"
        Me.txt_card_id.PasswordChar = Microsoft.VisualBasic.ChrW(88)
        Me.txt_card_id.Size = New System.Drawing.Size(192, 34)
        Me.txt_card_id.TabIndex = 597
        Me.txt_card_id.Text = ""
        '
        'lbl_SwipeCard
        '
        Me.lbl_SwipeCard.BackColor = System.Drawing.Color.ForestGreen
        Me.lbl_SwipeCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_SwipeCard.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SwipeCard.ForeColor = System.Drawing.Color.White
        Me.lbl_SwipeCard.Image = CType(resources.GetObject("lbl_SwipeCard.Image"), System.Drawing.Image)
        Me.lbl_SwipeCard.Location = New System.Drawing.Point(536, 7)
        Me.lbl_SwipeCard.Name = "lbl_SwipeCard"
        Me.lbl_SwipeCard.Size = New System.Drawing.Size(104, 32)
        Me.lbl_SwipeCard.TabIndex = 602
        Me.lbl_SwipeCard.Text = "FLASH CARD"
        Me.lbl_SwipeCard.Visible = False
        '
        'Cmd_SwipeHelp
        '
        Me.Cmd_SwipeHelp.Image = CType(resources.GetObject("Cmd_SwipeHelp.Image"), System.Drawing.Image)
        Me.Cmd_SwipeHelp.Location = New System.Drawing.Point(856, 8)
        Me.Cmd_SwipeHelp.Name = "Cmd_SwipeHelp"
        Me.Cmd_SwipeHelp.Size = New System.Drawing.Size(24, 32)
        Me.Cmd_SwipeHelp.TabIndex = 810
        Me.Cmd_SwipeHelp.Visible = False
        '
        'LBL_CARD_BALANCE
        '
        Me.LBL_CARD_BALANCE.BackColor = System.Drawing.Color.Lime
        Me.LBL_CARD_BALANCE.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CARD_BALANCE.ForeColor = System.Drawing.Color.Blue
        Me.LBL_CARD_BALANCE.Location = New System.Drawing.Point(64, 8)
        Me.LBL_CARD_BALANCE.Name = "LBL_CARD_BALANCE"
        Me.LBL_CARD_BALANCE.Size = New System.Drawing.Size(232, 23)
        Me.LBL_CARD_BALANCE.TabIndex = 811
        Me.LBL_CARD_BALANCE.Text = "CARD BALANCE : "
        Me.LBL_CARD_BALANCE.Visible = False
        '
        'Pic_Spouse
        '
        Me.Pic_Spouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Spouse.Location = New System.Drawing.Point(952, 40)
        Me.Pic_Spouse.Name = "Pic_Spouse"
        Me.Pic_Spouse.Size = New System.Drawing.Size(68, 78)
        Me.Pic_Spouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Spouse.TabIndex = 812
        Me.Pic_Spouse.TabStop = False
        Me.Pic_Spouse.Visible = False
        '
        'Pic_Sign
        '
        Me.Pic_Sign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic_Sign.Location = New System.Drawing.Point(880, 120)
        Me.Pic_Sign.Name = "Pic_Sign"
        Me.Pic_Sign.Size = New System.Drawing.Size(72, 8)
        Me.Pic_Sign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Sign.TabIndex = 813
        Me.Pic_Sign.TabStop = False
        Me.Pic_Sign.Visible = False
        '
        'Timer1
        '
        '
        'Cmd_DC_Update
        '
        Me.Cmd_DC_Update.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_DC_Update.Enabled = False
        Me.Cmd_DC_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_DC_Update.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_DC_Update.ForeColor = System.Drawing.Color.White
        Me.Cmd_DC_Update.Image = CType(resources.GetObject("Cmd_DC_Update.Image"), System.Drawing.Image)
        Me.Cmd_DC_Update.Location = New System.Drawing.Point(-40, 536)
        Me.Cmd_DC_Update.Name = "Cmd_DC_Update"
        Me.Cmd_DC_Update.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_DC_Update.TabIndex = 815
        Me.Cmd_DC_Update.Text = "DC Update[F4]"
        Me.Cmd_DC_Update.Visible = False
        '
        'PNL_FACILITY
        '
        Me.PNL_FACILITY.BackgroundImage = CType(resources.GetObject("PNL_FACILITY.BackgroundImage"), System.Drawing.Image)
        Me.PNL_FACILITY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNL_FACILITY.Controls.Add(Me.SSGRIND1)
        Me.PNL_FACILITY.Location = New System.Drawing.Point(80, 96)
        Me.PNL_FACILITY.Name = "PNL_FACILITY"
        Me.PNL_FACILITY.Size = New System.Drawing.Size(320, 184)
        Me.PNL_FACILITY.TabIndex = 816
        Me.PNL_FACILITY.Visible = False
        '
        'SSGRIND1
        '
        Me.SSGRIND1.ContainingControl = Me
        Me.SSGRIND1.DataSource = Nothing
        Me.SSGRIND1.Location = New System.Drawing.Point(5, 0)
        Me.SSGRIND1.Name = "SSGRIND1"
        Me.SSGRIND1.OcxState = CType(resources.GetObject("SSGRIND1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRIND1.Size = New System.Drawing.Size(312, 184)
        Me.SSGRIND1.TabIndex = 590
        '
        'lab_outstanding
        '
        Me.lab_outstanding.AutoSize = True
        Me.lab_outstanding.BackColor = System.Drawing.Color.Transparent
        Me.lab_outstanding.Font = New System.Drawing.Font("Courier New", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_outstanding.ForeColor = System.Drawing.Color.Blue
        Me.lab_outstanding.Location = New System.Drawing.Point(320, 555)
        Me.lab_outstanding.Name = "lab_outstanding"
        Me.lab_outstanding.Size = New System.Drawing.Size(0, 26)
        Me.lab_outstanding.TabIndex = 817
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label2.Location = New System.Drawing.Point(532, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 818
        Me.Label2.Text = "FLASH CARD"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(168, 596)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 819
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'CMD_FACILITY
        '
        Me.CMD_FACILITY.BackColor = System.Drawing.Color.ForestGreen
        Me.CMD_FACILITY.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMD_FACILITY.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_FACILITY.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.CMD_FACILITY.Image = CType(resources.GetObject("CMD_FACILITY.Image"), System.Drawing.Image)
        Me.CMD_FACILITY.Location = New System.Drawing.Point(304, 596)
        Me.CMD_FACILITY.Name = "CMD_FACILITY"
        Me.CMD_FACILITY.Size = New System.Drawing.Size(112, 32)
        Me.CMD_FACILITY.TabIndex = 820
        Me.CMD_FACILITY.Text = "FACILITY_PRN"
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_Delete.Image = CType(resources.GetObject("cmd_Delete.Image"), System.Drawing.Image)
        Me.cmd_Delete.Location = New System.Drawing.Point(456, 596)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 821
        Me.cmd_Delete.Text = "Delete[F8]"
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.Location = New System.Drawing.Point(600, 596)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.cmd_View.TabIndex = 822
        Me.cmd_View.Text = " View[F9]"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(744, 596)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 823
        Me.Cmd_Print.Text = "Print[F10]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(872, 596)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 824
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_recall
        '
        Me.cmd_recall.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_recall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_recall.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_recall.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_recall.Image = CType(resources.GetObject("cmd_recall.Image"), System.Drawing.Image)
        Me.cmd_recall.Location = New System.Drawing.Point(40, 504)
        Me.cmd_recall.Name = "cmd_recall"
        Me.cmd_recall.Size = New System.Drawing.Size(104, 32)
        Me.cmd_recall.TabIndex = 814
        Me.cmd_recall.Text = "Clear[F6]"
        Me.cmd_recall.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(26, 598)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.TabIndex = 825
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'LAB_CARDBAL
        '
        Me.LAB_CARDBAL.AutoSize = True
        Me.LAB_CARDBAL.BackColor = System.Drawing.Color.Transparent
        Me.LAB_CARDBAL.Font = New System.Drawing.Font("Courier New", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_CARDBAL.ForeColor = System.Drawing.Color.Blue
        Me.LAB_CARDBAL.Location = New System.Drawing.Point(64, 8)
        Me.LAB_CARDBAL.Name = "LAB_CARDBAL"
        Me.LAB_CARDBAL.Size = New System.Drawing.Size(0, 28)
        Me.LAB_CARDBAL.TabIndex = 835
        Me.LAB_CARDBAL.Visible = False
        '
        'ManualBilling
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 708)
        Me.Controls.Add(Me.LAB_CARDBAL)
        Me.Controls.Add(Me.PNL_FACILITY)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.txt_BillAmount)
        Me.Controls.Add(Me.txt_KOTno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_card_id)
        Me.Controls.Add(Me.txt_PackingCharge)
        Me.Controls.Add(Me.lbl_Packingcharge)
        Me.Controls.Add(Me.txt_Discount)
        Me.Controls.Add(Me.lbl_Discount)
        Me.Controls.Add(Me.Txt_Remarks)
        Me.Controls.Add(Me.lbl_BillAmount)
        Me.Controls.Add(Me.txt_TaxValue)
        Me.Controls.Add(Me.lbl_TaxValue)
        Me.Controls.Add(Me.txt_TotalValue)
        Me.Controls.Add(Me.lbl_TotalValue)
        Me.Controls.Add(Me.txt_KOTTime)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbl_KOTno)
        Me.Controls.Add(Me.txt_ServerCode)
        Me.Controls.Add(Me.txt_ServerName)
        Me.Controls.Add(Me.txt_MemberName)
        Me.Controls.Add(Me.txt_Cover)
        Me.Controls.Add(Me.lbl_KOTdate)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.cmd_View)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.CMD_FACILITY)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.grp_facility)
        Me.Controls.Add(Me.lab_outstanding)
        Me.Controls.Add(Me.grp_Tabledetails)
        Me.Controls.Add(Me.Cmd_DC_Update)
        Me.Controls.Add(Me.cmd_recall)
        Me.Controls.Add(Me.Pic_Sign)
        Me.Controls.Add(Me.Pic_Spouse)
        Me.Controls.Add(Me.LBL_CARD_BALANCE)
        Me.Controls.Add(Me.Cmd_SwipeHelp)
        Me.Controls.Add(Me.lbl_Remarks)
        Me.Controls.Add(Me.lbl_SubPaymentMode)
        Me.Controls.Add(Me.lbl_Servercode)
        Me.Controls.Add(Me.lbl_ServerName)
        Me.Controls.Add(Me.lbl_Membercode)
        Me.Controls.Add(Me.lbl_PaymentMode)
        Me.Controls.Add(Me.lbl_MemberName)
        Me.Controls.Add(Me.lbl_SwipeCard)
        Me.Controls.Add(Me.SETLEMENT_GROUP)
        Me.Controls.Add(Me.lblCro)
        Me.Controls.Add(Me.lblCro1)
        Me.Controls.Add(Me.grp_ssgrid)
        Me.Controls.Add(Me.grp_Memberfacility)
        Me.Controls.Add(Me.pnl_POSCode)
        Me.Controls.Add(Me.pnl_UOMCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_Bill)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.cbo_SubPaymentMode)
        Me.Controls.Add(Me.dtp_KOTdate)
        Me.Controls.Add(Me.cmd_KOTnoHelp)
        Me.Controls.Add(Me.grp_KOTdetails)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.cmd_ServerCodeHelp)
        Me.Controls.Add(Me.cbo_PaymentMode)
        Me.Controls.Add(Me.grp_Memberdetails)
        Me.Controls.Add(Me.grp_Paymentmodeselection)
        Me.Controls.Add(Me.PictureBox8)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "ManualBilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " BILLING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_ssgrid.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_facility.ResumeLayout(False)
        CType(Me.ssgrid_Fac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Tabledetails.ResumeLayout(False)
        Me.grp_KOTdetails.ResumeLayout(False)
        Me.grp_Memberdetails.ResumeLayout(False)
        Me.pnl_UOMCode.ResumeLayout(False)
        Me.pnl_POSCode.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grp_Paymentmodeselection.ResumeLayout(False)
        Me.grp_Chequedetails.ResumeLayout(False)
        Me.grp_Carddetails.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ssgridPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Memberfacility.ResumeLayout(False)
        CType(Me.Facilityssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SETLEMENT_GROUP.ResumeLayout(False)
        CType(Me.ssgrid_settlement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_FACILITY.ResumeLayout(False)
        CType(Me.SSGRIND1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim PHOTOFILENAME, CARDCODE, TYPE1 As String
    Dim itembool, chkbool, smartcardbool, boolPromotional As Boolean
    Dim Qty, fmth, mth, _year As Integer
    Dim Amt, AMT1, MemberOutstand As Double
    Dim vsplit(), Str, type(), _TYPE, _DNAME, _FCODE, strSQL As String
    Dim frmdate As Date, todate As Date
    Dim _frmdate As Date, _todate As Date
    Public dblBillTotalAmount, dblBillNonTotalAmount, dblBillTaxTotal, dblBillNonTaxtotal, gridRow As Double
    Dim dd, serverdate As DateTime
    Public BillTaxBillno, BillTaxBilldetails, BillNonTaxBilldetails, BillNonTaxBillno, BillMcode, BillMname, loccode As String
    Dim BillNontaxamount, BillNontotalamount, Billtaxamount, Billtotalamount As Double
    Dim dbldicountAmount, dblGrossAmount, dbldicountPack, dblGrossPack As Double
    Dim dbldicountTax, dblGrossTax, dblDicountBillAmount, Gridbillamount As Double
    Dim txt_creditfacility, costcode, roomchkno As String
    Dim I, J As Long
    Dim vsearch, vitem, accountcode, Billno(), SSQL As String
    Public KOTno(), billstatus, BillDetails, desc, HNAME() As String
    Dim gconnection As New GlobalClass
    Dim TotalItemCount As Integer
    Dim strAccountIn, strSaleCostAccountIn, strSaleCostAccountInDesc, strBatchNo, strAccountDesc, STMcode As String
    Public vseqno, Jnltaxamount, Jnlamount, _Billamount As Double
    '----SMART CARD
    Public BALANCE_HDR As Double
    Public MIN_USAGE_BALANCE_HDR As Double

    '---DLL VERSION BEGIN
    Public Shared G_Cancel As Boolean
    Public Shared G_vKeyType As Byte
    Public Shared G_StoredNum As Integer
    Public Shared G_pKey(5) As Byte
    Public Shared G_PhysicalSector As Integer
    Public Shared G_BlockNum As Byte
    Public Shared G_ReadType As String
    Public Shared G_dout(15) As Byte
    '---DLL VERSION END
    Private Function CMD_LOCK()
        Try
            SQLSTRING = " SELECT *  FROM KOT_HDR WHERE   ISNULL(POSTINGSTATUS,'')='Y' AND CAST(CONVERT(CHAR(11),KOTDATE,6) AS DATETIME)='" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "' "
            gconnection.getDataSet(SQLSTRING, "PENINGKOT")
            If gdataset.Tables("PENINGKOT").Rows.Count > 0 Then
                Cmd_Add.Enabled = False
                cmd_Delete.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub KOTTYPE()
        Try
            Dim LOC, strstring As String
            Dim I As Integer
            strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y' "
            gconnection.getDataSet(strstring, "LOCmaster")
            If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("LOCmaster").Rows.Count - 1
                    CMB_BTYPE.Items.Add(gdataset.Tables("LOCmaster").Rows(I).Item("DOCTYPE"))

                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FillBillPrefix()
        Dim Sqlstring As String
        'Sqlstring = "SELECT ISNULL(BillPrefix,'') AS BillPrefix FROM POSSETUP"
        'gconnection.getDataSet(Sqlstring, "POSSETUP")
        'If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
        '    BillPrefix = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPrefix"))
        'Else
        '    BillPrefix = Mid(MyCompanyName, 1, 3)
        'End If
        BillPrefix = Trim(CMB_BTYPE.Text)
    End Sub
    Private Sub ManualBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            smartdeviceportcount = 0
            Timer1.Enabled = True
            Call KOTTYPE()
            CARDCODE = POScode
            'TYPE1 = doctype
            vCardcode = ""
            doctype = Trim(CMB_BTYPE.Text)
            'TYPE1 = "FACILITY"
            CMB_BTYPE.Enabled = True
            CMB_BTYPE_SelectedIndexChanged(sender, e)
            Call FillBillPrefix()
            Call FacilityValidation()
            Call FillDefaultPayment()
            Call fillPayment_Mode()
            Call autogenerate()
            Call ShowBillno()
            Call GRIDLOCK()
            Pic_Member.Image = Nothing
            itembool = False
            pnl_UOMCode.Top = 1000
            CMB_BTYPE.SelectedIndex = 0
            KOT_Timer.Enabled = True
            KOT_Timer.Interval = 100
            txt_MemberName.ReadOnly = True
            txt_ServerName.ReadOnly = True
            txt_TotalValue.ReadOnly = True
            txt_TaxValue.ReadOnly = True
            txt_PackingCharge.ReadOnly = True
            txt_BillAmount.ReadOnly = True
            Me.cmd_BillSettlement.Enabled = True
            cbo_Typeofcheque.SelectedIndex = 0
            grp_Paymentmodeselection.Top = 1000
            ssGrid.ClearRange(1, 1, -1, -1, True)
            Me.cmd_KOTnoHelp.Enabled = True
            Me.cmd_Delete.Enabled = True
            cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
            Call SetDateTime()
            Call SYS_DATE_TIME()
            MNAME_GBL = ""
            MCODE_GBL = ""
            lab_servicename.Text = ""
            LOC_TXT.Text = ""
            CMB_BTYPE.SelectedIndex = 0
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            cbo_PaymentMode.Focus()

            '*******************SMART CARD START
            If MCODE_GBL <> "" Then
                lbl_SwipeCard.Visible = False
                txt_MemberCode.Text = MCODE_GBL
                'txt_card_id.Visible = False
                txt_MemberName.Text = NAME_GBL
                If gFoto = "Y" Then
                    gconnection.LoadFoto_DB(txt_card_id, Pic_Member)
                Else
                    If gShortName = "MCC" Then
                        gconnection.FOTO_LOAD_MCC(txt_card_id, Pic_Member)
                    ElseIf gShortName = "NIZAM" Then
                        gconnection.Foto_LOAD_NIZAM(txt_card_id, Pic_Member)
                    Else
                        gconnection.Foto_LOAD(txt_card_id, Pic_Member)
                    End If
                End If
                MCODE_GBL = ""
                Name = ""
                ACC_ENTRY = False
                cbo_PaymentMode.Focus()
                Show()
            End If
            ssGrid.ClearRange(1, 1, -1, -1, True)
            ssgrid_Fac.ClearRange(1, 1, -1, -1, True)
            SSGRIND1.ClearRange(1, 1, -1, -1, True)
            ssgrid_Fac.SetActiveCell(1, 1)
            SSGRIND1.SetActiveCell(1, 1)
            PNL_FACILITY.Visible = False
            grp_facility.Visible = False
            CMD_FACILITY.Enabled = False
            Call cmd_Clear_Click(sender, e)
            txt_card_id.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Private Function CMD_LOCK()
    '    Try
    '        SQLSTRING = " SELECT *  FROM KOT_HDR WHERE   ISNULL(POSTINGSTATUS,'')='Y' AND CAST(CONVERT(CHAR(11),KOTDATE,6) AS DATETIME)='" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "' "
    '        gconnection.getDataSet(SQLSTRING, "PENINGKOT")
    '        If gdataset.Tables("PENINGKOT").Rows.Count > 0 Then
    '            Cmd_Add.Enabled = False
    '            cmd_Delete.Enabled = False
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Function
    Private Sub SYS_DATE_TIME()
        Dim sqlstring, financalyear, Insert(0) As String
        Try
            'sqlstring = " SELECT TOP 1 CAST(CONVERT(CHAR(11),KOTDATE,6) AS DATETIME) AS KOTDATE FROM KOT_HDR WHERE  ISNULL(DELFLAG,'')<>'Y'  AND ISNULL(POSTINGSTATUS,'')<>'Y' "
            'sqlstring = sqlstring & " ORDER BY CAST(CONVERT(CHAR(11),KOTDATE,6) AS DATETIME) "
            'gconnection.getDataSet(sqlstring, "PENINGKOT")
            'If gdataset.Tables("PENINGKOT").Rows.Count > 0 Then
            '    dtp_KOTdate.Value = gdataset.Tables("PENINGKOT").Rows(0).Item("KOTDATE")
            'Else
                sqlstring = "SELECT SERVERDATE,SERVERTIME FROM VIEW_SERVER_DATETIME "
                gconnection.getDataSet(sqlstring, "SERVERDATE")
                If gdataset.Tables("SERVERDATE").Rows.Count > 0 Then
                    dtp_KOTdate.Value = gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERDATE")
                End If
            'End If

            dtp_KOTdate.Enabled = True
            CMD_LOCK()
        Catch ex As Exception
            MessageBox.Show("Enter a valid datetime :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FacilityValidation()
        Dim Sqlstring As String
        Sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM POSMASTER WHERE POSCODE = '" & Trim(POScode) & "'"
        gconnection.getDataSet(Sqlstring, "POSMASTER")
        If gdataset.Tables("POSMASTER").Rows.Count > 0 Then
            If Trim(gdataset.Tables("POSMASTER").Rows(0).Item("STORESTATUS")) = "F" Then
                lbl_Tableno.Enabled = False
                lbl_Covers.Enabled = False
                txt_TableNo.Enabled = False
                txt_Cover.Enabled = False
                cmd_TablenoHelp.Enabled = False
                grp_Tabledetails.Enabled = True
            Else
                lbl_Tableno.Enabled = True
                lbl_Covers.Enabled = True
                txt_TableNo.Enabled = True
                txt_Cover.Enabled = True
                cmd_TablenoHelp.Enabled = True
                grp_Tabledetails.Enabled = True
            End If
        Else
            lbl_Tableno.Enabled = True
            lbl_Covers.Enabled = True
            txt_TableNo.Enabled = True
            txt_Cover.Enabled = True
            cmd_TablenoHelp.Enabled = True
            grp_Tabledetails.Enabled = True
        End If
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
        Me.Cmd_Add.Enabled = False
        Me.cmd_Delete.Enabled = False
        Me.cmd_View.Enabled = False
        Me.Cmd_Print.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.cmd_Delete.Enabled = True
                    Me.cmd_View.Enabled = True
                    Me.Cmd_Print.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.cmd_Delete.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmd_View.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.Cmd_Print.Enabled = True
                End If
            Next
        End If
    End Sub


    Private Sub cmd_TablenoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_TablenoHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(TABLENAME,'') AS TABLENAME FROM Tablemaster"
        M_WhereCondition = " WHERE ISNULL(Freeze,'') <> 'Y'"
        vform.Field = "TABLENAME"
        vform.vFormatstring = "                  TABLE NAME                               "
        vform.vCaption = "TABLE MASTER HELP"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_TableNo.Text = Trim(vform.keyfield & "")
            txt_Cover.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim sqlstring As String
        Dim vform As New ListOperattion1
        If cbo_PaymentMode.SelectedItem = "ROOM" Then
            gSQLString = "SELECT ISNULL(ROOMNO,0) AS ROOMNO,ISNULL(GUEST,'') AS GUEST,ISNULL(DOCNO,0) AS DOCNO FROM Roomcheckin "
            If Trim(Search) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " WHERE ISNULL(checkout,'') <> 'Y' AND Roomstatus='occupied'"
            End If
            vform.Field = " ROOMNO,GUEST,DOCNO "
            vform.vFormatstring = "     ROOM NO                  |                     GUEST NAME                    |              DOC NO               "
            vform.vCaption = "ROOM MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 2
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_MemberCode.Text = Trim(vform.keyfield & "")
                txt_MemberName.Text = Trim(vform.keyfield1 & "")
                txt_MemberCode.Tag = Trim(vform.keyfield2 & "")
                txt_ServerCode.Focus()
            End If
            vform.Close()
            vform = Nothing
        Else
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM Membermaster"
            If Trim(Search) = " " Then
                M_WhereCondition = " WHERE CURENTSTATUS='LIVE' "
            Else
                'M_WhereCondition = ""
                M_WhereCondition = " WHERE CURENTSTATUS='LIVE' "
            End If
            vform.Field = " MNAME,MCODE "
            vform.vFormatstring = "                 MEMBER CODE            |                 MEMBER NAME                                "
            vform.vCaption = "MEMBER MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_MemberCode.Text = Trim(vform.keyfield & "")
                txt_MemberName.Text = Trim(vform.keyfield1 & "")
                txt_ServerCode.Focus()
            End If
            vform.Close()
            vform = Nothing
        End If
    End Sub
    Private Sub cmd_ServerCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ServerCodeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(SERVERCODE,'') AS SERVERCODE, ISNULL(SERVERNAME,'') AS SERVERNAME FROM servermaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <>'Y' "
        End If
        vform.Field = " SERVERCODE,SERVERNAME "
        vform.vFormatstring = "         SERVER CODE            |                       SERVERNAME                               "
        vform.vCaption = "SERVER MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_ServerCode.Text = Trim(vform.keyfield & "")
            txt_ServerName.Text = Trim(vform.keyfield1 & "")
            ssGrid.Focus()
            ssGrid.SetActiveCell(1, 1)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub cmd_Clear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub BillingUpdation()
        Dim sql, taxcode, cancel, x, y As String
        Dim i As Integer
        For i = 1 To ssGrid.DataRowCnt
            taxcode = Nothing
            cancel = Nothing
            With ssGrid
                .GetText(10, i, taxcode)
                .GetText(12, i, cancel)
                If Val(cancel) = 0 Then
                    x = Nothing
                    y = Nothing
                    If Trim(taxcode) = "" Then
                        .GetText(8, i, x)
                        BillNontaxamount = 0
                        BillNontotalamount = Val(BillNontotalamount) + Val(x)
                    Else
                        .GetText(7, i, y)
                        .GetText(8, i, x)
                        Billtaxamount = Val(Billtaxamount) + Val(y)
                        Billtotalamount = Val(Billtotalamount) + Val(x)
                    End If
                End If
            End With
        Next
    End Sub
    Private Sub cbo_SubPaymentMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_SubPaymentMode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_MemberCode.Focus()
        End If
    End Sub
    Public Sub BillPrintOperation24Mar08()
        Randomize()
        Dim vOutfile, vheader, vFilepath, vline, Kot, Bill, amtword, paymentmode, rupeesword As String
        Dim ssql, vCaption, vPath, str, Sqlstring, billdetails, Fsize(), Forder(), Round, Roundedvalue() As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, Taxpercentage, RoundOff1 As Double
        Dim Loopindex, i, Fo, in1, CountItem, rowj As Integer
        Dim Vrowcount, vpagenumber As Long
        Dim Filewrite As StreamWriter
        gCompanyname = MyCompanyName
        gCompanyAddress(0) = Address1
        gCompanyAddress(1) = Address2
        Gheader = " V O U C H E R "
        vpagenumber = 1
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
        billdetails = "'" & Trim(txt_KOTno.Text) & "'"
        paymentmode = Trim(cbo_PaymentMode.Text)
        Sqlstring = " SELECT ISNULL(D.KOTNO,'') AS KOTNO,ISNULL(D.BILLDETAILS,'') AS BILLDETAILS,ISNULL(D.KOTDETAILS,'') AS KOTDETAILS, "
        Sqlstring = Sqlstring & " D.KOTDATE AS KOTDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE,ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(D.POSCODE,'') AS POSCODE,"
        Sqlstring = Sqlstring & " ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(D.TAXTYPE,'') AS TAXTYPE, ISNULL(D.TAXPERC,0) AS TAXPERC,"
        Sqlstring = Sqlstring & " ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXAMOUNT,0) AS TAXAMOUNT,ISNULL(D.ITEMTYPE,'') AS ITEMTYPE,ISNULL(H.MCODE,'') AS MCODE,"
        Sqlstring = Sqlstring & " ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.STCODE,'') AS STCODE,ISNULL(H.SERVERNAME,'') AS SERVERNAME,ISNULL(H.PAYMENTTYPE,'') AS PAYMENTTYPE,ISNULL(H.GUEST,'') AS GUEST,"
        Sqlstring = Sqlstring & " ISNULL(H.ROOMNO,'') AS ROOMNO,ISNULL(H.DISCOUNTAMT,0) AS DISCOUNTAMT,ISNULL(H.PACKAMT,0) AS PACKAMT,ISNULL(H.TOTAL,0) AS TOTAL,ISNULL(H.TOTALTAX,0) AS TOTALTAX,"
        Sqlstring = Sqlstring & " ISNULL(H.BILLAMOUNT,0) AS BILLAMOUNT,ISNULL(H.ROUNDOFF,0) AS ROUNDOFF,ISNULL(H.ADDUSERID,'') AS ADDUSERID,ISNULL(H.REMARKS,'') AS REMARKS,H.ADDDATETIME AS ADDDATETIME,"
        Sqlstring = Sqlstring & " ISNULL(H.DELFLAG,'') AS DELFLAG FROM KOT_HDR AS H INNER JOIN KOT_DET AS D ON H.KOTDETAILS = D.KOTDETAILS "
        Sqlstring = Sqlstring & " WHERE BILLDETAILS = '" & Trim(txt_KOTno.Text) & "' ORDER BY BILLDETAILS,ITEMCODE"
        gconnection.getDataSet(Sqlstring, "Manualbilldetails")
        If gdataset.Tables("Manualbilldetails").Rows.Count > 0 Then
            Filewrite = File.AppendText(vFilepath)
            vline = "" : Kot = "" : Bill = "" : Taxpercentage = 0
            Bill = Trim(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLDETAILS"))
            Taxpercentage = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TAXPERC"))
            For rowj = 0 To gdataset.Tables("Manualbilldetails").Rows.Count - 1
                CountItem = CountItem + 1
                If Trim(Bill) <> Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("BillDetails")) Then
                    If Vrowcount <= 16 Then
                        For i = 1 To 16 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If
                    If gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "ROOM" Then
                        Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 20))
                        Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("GUEST") & "       [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("ROOMNO") & "]", 1, 45))
                    ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "CREDIT" Then
                        Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 20))
                        Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]", 1, 45))
                    ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "COUPON" Then
                        Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 20))
                        Filewrite.WriteLine("{0,-45}", ":")
                    ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "R.MEMBER" Then
                        Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 20))
                        Filewrite.WriteLine("{0,-45}", Mid(":" & "RECIPROCAL MEMBER", 1, 45))
                    ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "PENDING" Then
                        Filewrite.Write("{0,-20}", "MEMEBER NAME :")
                        Filewrite.WriteLine("{0,-45}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]", 1, 45))
                    Else
                        Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 20))
                        Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]", 1, 45))
                    End If
                    Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(12, "-"))
                    Filewrite.WriteLine("{0,-69}{1,10}", "", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")), "0.00"))
                    Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("TAXCODE")) & "' "
                    gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
                    If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                        Sqlstring = "SELECT ISNULL(DATAFILE,'') FROM MASTER..CLUBMASTER WHERE DATAFILE = 'CLUB2007'"
                        gconnection.getDataSet(Sqlstring, "CLUBMASTER")
                        If gdataset.Tables("CLUBMASTER").Rows.Count > 0 Then
                            Filewrite.Write("{0,-31}{1,38}", "BILL PAYBLE ON PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                            Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                        Else
                            Filewrite.Write("{0,-31}{1,38}", "", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                            Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                        End If
                    End If
                    If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")) > 0 Then
                        Filewrite.Write("{0,69}", "                                      PACKING CHARGES @ 5% :")
                        Filewrite.WriteLine("{0,10}", Format((Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                    End If
                    If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")) > 0 Then
                        Filewrite.Write("{0,69}", "                                       DISCOUNT PERCENTAGE :")
                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                    End If
                    Filewrite.WriteLine("{0,-79}", "")
                    Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(12, "-"))
                    Filewrite.Write("{0,-50}{1,19}", "", "TOTAL :")
                    Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                    RoundOff = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")))
                    Round = CStr(RoundOff)
                    'If Round.IndexOf(".") <= 0 Then
                    '    Round = Round.Insert(Round.Length - 1, ".00")
                    'End If
                    'Roundedvalue = Split(Round, ".")
                    'If Format(Val(Roundedvalue(1)), "00") = 50 Then
                    '    RoundOff = Math.Ceiling(RoundOff)
                    'ElseIf Format(Val(Roundedvalue(1)), "00") > 50 Then
                    '    RoundOff = Math.Ceiling(RoundOff)
                    'Else
                    '    RoundOff = Math.Floor(RoundOff)
                    'End If
                    RoundOff1 = Mid(Format(Val(RoundOff), "0.00"), Len(Format(Val(RoundOff), "0.00")) - 1, Len(Format(Val(RoundOff), "0.00")))
                    If Format(Val(RoundOff1), "00") = 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    ElseIf Format(Val(RoundOff1), "00") > 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    Else
                        RoundOff = Math.Floor(RoundOff)
                    End If
                    If Val(RoundOff) > Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))) Then
                        RoundDiff = RoundOff - (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")))
                        Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(+):")
                    Else
                        RoundDiff = (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))) - RoundOff
                        Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(-):")
                    End If
                    Filewrite.WriteLine("{0,10}", Format(Val(RoundDiff), "0.00"))
                    Filewrite.WriteLine(StrDup(81, "-"))
                    rupeesword = ConvertRupees(Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                    Filewrite.Write("{0,-69}", Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))
                    Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00"))
                    Filewrite.WriteLine(StrDup(81, "-"))
                    Filewrite.Write("{0,-14}{1,-46}", "PREPARED BY:", Mid(UCase(gUsername), 1, 40))
                    Filewrite.WriteLine("{0,-20}", Mid(MyCompanyName, 1, 20))
                    Filewrite.WriteLine("{0,-14}{1,-20}", "REMARKS :   ", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("REMARKS"), 1, 20))
                    Kot = ""
                    Bill = gdataset.Tables("ReportTable").Rows(rowj).Item("BILLDETAILS")
                    Taxpercentage = Val(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("TAXPERC"))
                    TotalAmount = 0 : TaxAmount = 0 : Vrowcount = 0 : CountItem = 1
                    Filewrite.WriteLine(Chr(12))
                End If
                If Kot <> gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTNO") Then
                    If Trim(Kot) <> "" Then
                        Kot = Kot & "," & gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTNO")
                    Else
                        Kot = gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTNO")
                    End If
                End If
                If Vrowcount = 0 Then
                    Sqlstring = "SELECT ISNULL(BillPrintHeader,'') AS BillPrintHeader FROM POSSETUP"
                    gconnection.getDataSet(Sqlstring, "POSSETUP")
                    If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                        If Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPrintHeader")) = "YES" Then
                            vheader = Space((65 - Len(gCompanyname)) / 2) & Chr(14) & Chr(15) & gCompanyname & Chr(18)
                            Filewrite.WriteLine(vheader)
                            vheader = Space((65 - Len(Trim(gCompanyAddress(0)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(0) & Chr(18)
                            Filewrite.WriteLine(vheader)
                            vheader = Space((65 - Len(Trim(gCompanyAddress(1)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(1) & Chr(18)
                            Filewrite.WriteLine(vheader)
                        End If
                    End If
                    Filewrite.WriteLine("")
                    If gdataset.Tables("Manualbilldetails").Rows(0).Item("DELFLAG") <> "Y" Then
                        vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                    Else
                        vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & " V O U C H E R [D E L E T E D]"
                    End If
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine(vheader)
                    Filewrite.Write("{0,-12}{1,-24}{2,-24}", Mid("BILL   NO:", 1, 10), Mid(Bill, 1, 18), "")
                    Filewrite.WriteLine("{0,-8}{1,-10}", "TIME   :", Format(gdataset.Tables("Manualbilldetails").Rows(0).Item("ADDDATETIME"), "hh:mm:ss"))
                    Filewrite.Write("{0,-12}{1,-24}{2,-24}", Mid("SERVER NO:", 1, 10), Mid(CStr(gdataset.Tables("Manualbilldetails").Rows(0).Item("SERVERNAME")) & "   [" & CStr(gdataset.Tables("Manualbilldetails").Rows(0).Item("STCODE")) & "]", 1, 24), "")
                    Filewrite.WriteLine("{0,-8}{1,-10}", "DATE   :", Format(CDate(gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTDATE")), "dd/MM/yyyy"))
                    Filewrite.WriteLine(StrDup(81, "-"))
                    Filewrite.WriteLine("{0,-6}{1,-6}{2,-36}{3,-8}{4,-8}{5,-8}{6,-10}", "SLNO", "CODE", "ITEM DESCRIPTION", "QTY", "UOM", "RATE", "AMOUNT")
                    Filewrite.WriteLine(StrDup(81, "-"))
                    Vrowcount = 8
                End If
                With gdataset.Tables("Manualbilldetails").Rows(rowj)
                    Filewrite.Write("{0,-6}{1,-6}", Mid(CountItem & ".", 1, 5), Mid(Trim(.Item("ITEMCODE")), 1, 6))
                    'Modified on 06 Apr 08 for CSC Temporary Purpose
                    'Mk Kannan
                    'Begin
                    'If Trim(.Item("POSCODE")) = "54" Then
                    ' Filewrite.Write("{0,-36}{1,-8}{2,-8}", Mid(Mid(Trim(.Item("ITEMDESC")), 1, Len(Trim(.Item("ITEMDESC"))) - 6) & Trim(".............................."), 1, 36), Mid(Format(Val(.Item("QTY")), "0.00"), 1, 8), Mid(Trim(.Item("UOM")), 1, 8))
                    'Else
                    Filewrite.Write("{0,-36}{1,-8}{2,-8}", Mid(Trim(.Item("ITEMDESC")) & Trim(".............................."), 1, 36), Mid(Format(Val(.Item("QTY")), "0.00"), 1, 8), Mid(Trim(.Item("UOM")), 1, 8))
                    'End If
                    'End
                    Filewrite.WriteLine("{0,-8}{1,-10}", Mid(Format(Val(.Item("RATE")), "0.00"), 1, 8), Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                    Vrowcount = Vrowcount + 1
                End With
                If Vrowcount > 32 Then
                    Vrowcount = 0
                    vpagenumber = Val(vpagenumber) + 1
                End If
            Next rowj
            If Vrowcount <= 16 Then
                For i = 1 To 16 - Vrowcount
                    Filewrite.WriteLine("")
                Next
            ElseIf Vrowcount > 16 Then
                Filewrite.WriteLine(StrDup(81, "-"))
                Filewrite.WriteLine("{0,79}", "Contd....")
                For i = 1 To 38 - Vrowcount + 1
                    Filewrite.WriteLine("")
                Next
                Vrowcount = 6
            End If
            If gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "ROOM" Then
                Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(0).Item("GUEST") & "       [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("ROOMNO") & "]", 1, 45))
            ElseIf gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "CREDIT" Then
                Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]", 1, 45))
            ElseIf gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "COUPON" Then
                Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                Filewrite.WriteLine("{0,-45}", ":")
            ElseIf gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "R.MEMBER" Then
                Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                Filewrite.WriteLine("{0,-45}", Mid(":" & "RECIPROCAL MEMBER", 1, 45))
            ElseIf gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "PENDING" Then
                Filewrite.Write("{0,-20}", "MEMEBER NAME :")
                Filewrite.WriteLine("{0,-45}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]", 1, 45))
            Else
                Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]", 1, 45))
            End If
            Vrowcount = Vrowcount + 1
            Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(12, "-"))
            Filewrite.WriteLine("{0,-69}{1,10}", "", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")), "0.00"))
            Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("Manualbilldetails").Rows(0).Item("TAXCODE")) & "' "
            gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
            If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                Filewrite.Write("{0,-31}{1,38}", "BILL PAYBLE ON PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
            End If
            If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")) > 0 Then
                Filewrite.Write("{0,69}", "                                      PACKING CHARGES @ 5% :")
                Filewrite.WriteLine("{0,10}", Format((Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                Vrowcount = Vrowcount + 1
            End If
            Vrowcount = Vrowcount + 3
            If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")) > 0 Then
                Filewrite.Write("{0,69}", "                                       DISCOUNT PERCENTAGE :")
                Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                Vrowcount = Vrowcount + 1
            End If
            Filewrite.WriteLine("{0,-79}", "")
            Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(12, "-"))
            Vrowcount = Vrowcount + 2
            Filewrite.Write("{0,-50}{1,19}", "", "TOTAL :")
            Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
            Vrowcount = Vrowcount + 1
            RoundOff = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")))
            Round = CStr(RoundOff)
            'If Round.IndexOf(".") <= 0 Then
            '    Round = Round.Insert(Round.Length - 1, ".00")
            'End If
            'Roundedvalue = Split(Round, ".")
            'If Format(Val(Roundedvalue(1)), "00") = 50 Then
            '    RoundOff = Math.Ceiling(RoundOff)
            'ElseIf Format(Val(Roundedvalue(1)), "00") > 50 Then
            '    RoundOff = Math.Ceiling(RoundOff)
            'Else
            '    RoundOff = Math.Floor(RoundOff)
            'End If
            RoundOff1 = Mid(Format(Val(RoundOff), "0.00"), Len(Format(Val(RoundOff), "0.00")) - 1, Len(Format(Val(RoundOff), "0.00")))
            If Format(Val(RoundOff1), "00") = 50 Then
                RoundOff = Math.Ceiling(RoundOff)
            ElseIf Format(Val(RoundOff1), "00") > 50 Then
                RoundOff = Math.Ceiling(RoundOff)
            Else
                RoundOff = Math.Floor(RoundOff)
            End If
            If Val(RoundOff) > Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))) Then
                RoundDiff = RoundOff - (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")))
                Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(+):")
            Else
                RoundDiff = (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))) - RoundOff
                Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(-):")
            End If
            Filewrite.WriteLine("{0,10}", Format(Val(RoundDiff), "0.00"))
            Filewrite.WriteLine(StrDup(81, "-"))
            rupeesword = ConvertRupees(Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
            Filewrite.Write("{0,-69}", Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))
            Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00"))
            Filewrite.WriteLine(StrDup(81, "-"))
            Filewrite.Write("{0,-14}{1,-46}", "PREPARED BY:", Mid(UCase(gUsername), 1, 40))
            Filewrite.WriteLine("{0,-20}", Mid(MyCompanyName, 1, 20))
            Filewrite.WriteLine("{0,-14}{1,-20}", "REMARKS :   ", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("REMARKS"), 1, 20))
            Vrowcount = Vrowcount + 6
            If Vrowcount <= 32 Then
                For i = 1 To 32 - Vrowcount
                    Filewrite.WriteLine("")
                Next
            End If
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(vFilepath)
            End If
        End If
    End Sub
    Public Sub BillPrintOperation()
        Randomize()
        Call SetDateTime()
        Dim vOutfile, vheader, vFilepath, vline, Kot, Bill, amtword, paymentmode, rupeesword As String
        Dim ssql, vCaption, vPath, str, Sqlstring, billdetails, Fsize(), Forder(), Round, Roundedvalue(), Rowprint As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, Taxpercentage, RoundOff1 As Double
        Dim Loopindex, i, Fo, in1, CountItem, rowj As Integer
        'Dim Vrowcount, vpagenumber As Long
        Dim Filewrite As StreamWriter
        Dim vpagenumber, Vrowcount, innercount As Long
        gCompanyname = MyCompanyName
        gCompanyAddress(0) = Address1
        gCompanyAddress(1) = Address2
        'Gheader = " V O U C H E R "
        Gheader = " BILL "
        vpagenumber = 1
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
        billdetails = "'" & Trim(txt_KOTno.Text) & "'"
        paymentmode = Trim(cbo_PaymentMode.Text)
        Sqlstring = " SELECT ISNULL(D.KOTNO,'') AS KOTNO,ISNULL(D.BILLDETAILS,'') AS BILLDETAILS,ISNULL(D.KOTDETAILS,'') AS KOTDETAILS, "
        Sqlstring = Sqlstring & " D.KOTDATE AS KOTDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE,ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(D.POSCODE,'') AS POSCODE,"
        Sqlstring = Sqlstring & " ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(D.TAXTYPE,'') AS TAXTYPE, ISNULL(D.TAXPERC,0) AS TAXPERC,"
        Sqlstring = Sqlstring & " ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXAMOUNT,0) AS TAXAMOUNT,ISNULL(D.ITEMTYPE,'') AS ITEMTYPE,ISNULL(H.MCODE,'') AS MCODE,"
        Sqlstring = Sqlstring & " ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.STCODE,'') AS STCODE,ISNULL(H.SERVERNAME,'') AS SERVERNAME,ISNULL(H.PAYMENTTYPE,'') AS PAYMENTTYPE,ISNULL(H.GUEST,'') AS GUEST,"
        Sqlstring = Sqlstring & " ISNULL(H.ROOMNO,'') AS ROOMNO,ISNULL(H.DISCOUNTAMT,0) AS DISCOUNTAMT,ISNULL(H.PACKAMT,0) AS PACKAMT,ISNULL(H.TOTAL,0) AS TOTAL,ISNULL(H.TOTALTAX,0) AS TOTALTAX,"
        Sqlstring = Sqlstring & " ISNULL(H.BILLAMOUNT,0) AS BILLAMOUNT,ISNULL(H.ROUNDOFF,0) AS ROUNDOFF,ISNULL(H.ADDUSERID,'') AS ADDUSERID,ISNULL(H.REMARKS,'') AS REMARKS,H.ADDDATETIME AS ADDDATETIME,"
        Sqlstring = Sqlstring & " ISNULL(H.DELFLAG,'') AS DELFLAG FROM KOT_HDR AS H INNER JOIN KOT_DET AS D ON H.KOTDETAILS = D.KOTDETAILS "
        Sqlstring = Sqlstring & " WHERE BILLDETAILS = '" & Trim(txt_KOTno.Text) & "' ORDER BY BILLDETAILS,ITEMCODE"
        gconnection.getDataSet(Sqlstring, "Manualbilldetails")
        If gdataset.Tables("Manualbilldetails").Rows.Count > 0 Then
            Filewrite = File.AppendText(vFilepath)
            vline = "" : Kot = "" : Bill = "" : Taxpercentage = 0
            Bill = Trim(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLDETAILS"))
            Taxpercentage = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TAXPERC"))
            For rowj = 0 To gdataset.Tables("Manualbilldetails").Rows.Count - 1
                CountItem = CountItem + 1
                If Trim(Bill) <> Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("BillDetails")) Then
                    'Modified on 21 Mar'08
                    'Mk Kannan
                    'Begin
                    If Vrowcount <= 17 Then
                        For i = 1 To 17 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If

                    Vrowcount = 0

                    'If Vrowcount <= 16 Then
                    '    For i = 1 To 16 - Vrowcount
                    '        Filewrite.WriteLine("")
                    '    Next
                    'End If

                    If gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "ROOM" Then
                        Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                        Rowprint = Rowprint & " : " & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("GUEST") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("ROOMNO") & "]"
                        'Filewrite.Write("{0,-11}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 10))
                        'Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("GUEST") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("ROOMNO") & "]", 1, 45))
                        'ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "CREDIT" Then
                        '    Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 20))
                        '    Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]", 1, 45))
                        'ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "COUPON" Then
                        '    Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 20))
                        '    Filewrite.WriteLine("{0,-45}", ":")
                    ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "R.MEMBER" Then
                        Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                        Rowprint = Rowprint & " : " & "RECIPROCAL MEMBER"
                        'Filewrite.Write("{0,-11}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 10))
                        'Filewrite.WriteLine("{0,-45}", Mid(":" & "RECIPROCAL MEMBER", 1, 45))
                    ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "PENDING" Then
                        Rowprint = "MEMEBER NAME :"
                        Rowprint = Rowprint & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]"
                        'Filewrite.Write("{0,-20}", "MEMEBER NAME :")
                        'Filewrite.WriteLine("{0,-45}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]", 1, 45))
                    Else
                        Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                        Rowprint = Rowprint & ":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]"
                        'Filewrite.Write("{0,-11}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 10))
                        'Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]", 1, 45))
                    End If

                    If Len(Rowprint) < 45 Then
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine()
                    Else
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                    End If
                    Vrowcount = Vrowcount + 2

                    Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(12, "-"))
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine("{0,-69}{1,10}", "", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")), "0.00"))
                    Vrowcount = Vrowcount + 1
                    Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("TAXCODE")) & "' "
                    gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
                    If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                        Sqlstring = "SELECT ISNULL(DATAFILE,'') FROM MASTER..CLUBMASTER WHERE DATAFILE = '" & gDatabase & "'"
                        gconnection.getDataSet(Sqlstring, "CLUBMASTER")
                        If gdataset.Tables("CLUBMASTER").Rows.Count > 0 Then
                            Filewrite.Write("{0,-31}{1,38}", "BILL PAYABLE ON PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                            Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                        Else
                            Filewrite.Write("{0,-31}{1,38}", "", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                            Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                        End If
                        Vrowcount = Vrowcount + 1
                    End If
                    If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")) > 0 Then
                        Filewrite.Write("{0,69}", "                                      PACKING CHARGES @ 5% :")
                        Filewrite.WriteLine("{0,10}", Format((Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                        Vrowcount = Vrowcount + 1
                    End If
                    If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")) > 0 Then
                        Filewrite.Write("{0,69}", "                                       DISCOUNT PERCENTAGE :")
                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                        Vrowcount = Vrowcount + 1
                    End If
                    Filewrite.WriteLine("{0,-79}", "")
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(12, "-"))
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("{0,-50}{1,19}", "", "TOTAL :")
                    Filewrite.WriteLine("{0,12}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                    Vrowcount = Vrowcount + 1
                    RoundOff = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")))
                    Round = CStr(RoundOff)
                    'If Round.IndexOf(".") <= 0 Then
                    '    Round = Round.Insert(Round.Length - 1, ".00")
                    'End If
                    'Roundedvalue = Split(Round, ".")
                    'If Format(Val(Roundedvalue(1)), "00") = 50 Then
                    '    RoundOff = Math.Ceiling(RoundOff)
                    'ElseIf Format(Val(Roundedvalue(1)), "00") > 50 Then
                    '    RoundOff = Math.Ceiling(RoundOff)
                    'Else
                    '    RoundOff = Math.Floor(RoundOff)
                    'End If
                    RoundOff1 = Mid(Format(Val(RoundOff), "0.00"), Len(Format(Val(RoundOff), "0.00")) - 1, Len(Format(Val(RoundOff), "0.00")))
                    If Format(Val(RoundOff1), "00") = 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    ElseIf Format(Val(RoundOff1), "00") > 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    Else
                        RoundOff = Math.Floor(RoundOff)
                    End If
                    If Val(RoundOff) > Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))) Then
                        RoundDiff = RoundOff - (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")))
                        Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(+):")
                    Else
                        RoundDiff = (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))) - RoundOff
                        Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(-):")
                    End If
                    Filewrite.WriteLine("{0,10}", Format(Val(RoundDiff), "0.00"))
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine(StrDup(81, "-"))
                    Vrowcount = Vrowcount + 1
                    rupeesword = ConvertRupees(Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                    Filewrite.Write("{0,-69}", Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))
                    'Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00"))

                    Rowprint = Chr(18) & Chr(27) + "E" & Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00") & Chr(27) + "F" & Chr(15)
                    Filewrite.WriteLine("{0,10}", Rowprint)

                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine(StrDup(81, "-"))
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("{0,-14}{1,-16}", "PREPARED BY:", Mid(UCase(gUsername), 1, 16))
                    Filewrite.WriteLine("{0,-40}", Mid(MyCompanyName, 1, 40))
                    Vrowcount = Vrowcount + 1

                    If Trim(Txt_Remarks.Text) <> "" Then
                        If Len(Trim(Txt_Remarks.Text)) < 65 Then
                            Filewrite.WriteLine("Remarks : " & Trim(Txt_Remarks.Text))
                            Vrowcount = Vrowcount + 1
                        Else
                            Filewrite.WriteLine("Remarks : " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                            Filewrite.WriteLine("          " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                            Vrowcount = Vrowcount + 2
                        End If
                    End If
                    'Filewrite.WriteLine("{0,-14}{1,-20}", "REMARKS :   ", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("REMARKS"), 1, 20))
                    'Vrowcount = Vrowcount + 1

                    'Modified on 21 Mar'08
                    'MK Kannan
                    'Begin
                    If Vrowcount <= 24 Then
                        For i = 1 To 24 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If
                    'End

                    Kot = ""
                    Bill = gdataset.Tables("ReportTable").Rows(rowj).Item("BILLDETAILS")
                    Taxpercentage = Val(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("TAXPERC"))
                    TotalAmount = 0 : TaxAmount = 0 : Vrowcount = 0 : CountItem = 1
                    'Filewrite.WriteLine(Chr(12))
                End If
                If Kot <> gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTNO") Then
                    If Trim(Kot) <> "" Then
                        Kot = Kot & "," & gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTNO")
                    Else
                        Kot = gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTNO")
                    End If
                End If

                'Modified on 24 Mar'08
                'MK Kannan
                'Begin
                If (Vrowcount = 0) Then
                    'If Vrowcount = 0 Then
                    ''If Vrowcount >= 17 Then
                    ''    Vrowcount = 0
                    ''    If gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "ROOM" Then
                    ''        Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                    ''        Rowprint = Rowprint & " : " & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("GUEST") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("ROOMNO") & "]"
                    ''        'Filewrite.Write("{0,-11}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 10))
                    ''        'Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("GUEST") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("ROOMNO") & "]", 1, 45))
                    ''        'ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "CREDIT" Then
                    ''        '    Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 20))
                    ''        '    Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]", 1, 45))
                    ''        'ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "COUPON" Then
                    ''        '    Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 20))
                    ''        '    Filewrite.WriteLine("{0,-45}", ":")
                    ''    ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "R.MEMBER" Then
                    ''        Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                    ''        Rowprint = Rowprint & " : " & "RECIPROCAL MEMBER"
                    ''        'Filewrite.Write("{0,-11}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 10))
                    ''        'Filewrite.WriteLine("{0,-45}", Mid(":" & "RECIPROCAL MEMBER", 1, 45))
                    ''    ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "PENDING" Then
                    ''        Rowprint = "MEMEBER NAME :"
                    ''        Rowprint = Rowprint & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]"
                    ''        'Filewrite.Write("{0,-20}", "MEMEBER NAME :")
                    ''        'Filewrite.WriteLine("{0,-45}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]", 1, 45))
                    ''    Else
                    ''        Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                    ''        Rowprint = Rowprint & ":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]"
                    ''        'Filewrite.Write("{0,-11}", Mid(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"), 1, 10))
                    ''        'Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]", 1, 45))
                    ''        If Len(Rowprint) < 45 Then
                    ''            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                    ''            Filewrite.WriteLine()
                    ''        Else
                    ''            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                    ''            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                    ''        End If
                    ''        Vrowcount = Vrowcount + 2
                    ''    End If
                    ''    'Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(12, "-"))
                    ''    'Filewrite.WriteLine("")
                    ''    'Vrowcount = Vrowcount + 1
                    ''    'Filewrite.WriteLine("{0,-69}{1,10}", "", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")), "0.00"))
                    ''    'Filewrite.WriteLine("")
                    ''    'Vrowcount = Vrowcount + 1
                    ''    Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("TAXCODE")) & "' "
                    ''    gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
                    ''    If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                    ''        Sqlstring = "SELECT ISNULL(DATAFILE,'') FROM MASTER..CLUBMASTER WHERE DATAFILE = '" & gDatabase & "'"
                    ''        gconnection.getDataSet(Sqlstring, "CLUBMASTER")
                    ''        If gdataset.Tables("CLUBMASTER").Rows.Count > 0 Then
                    ''            'Filewrite.Write("{0,-31}{1,38}", "BILL PAYABLE ON PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                    ''            'Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                    ''        Else
                    ''            'Filewrite.Write("{0,-31}{1,38}", "", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                    ''            'Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                    ''        End If
                    ''        Filewrite.WriteLine("")
                    ''        Vrowcount = Vrowcount + 1
                    ''    End If
                    ''    If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")) > 0 Then
                    ''        'Filewrite.Write("{0,69}", "                                      PACKING CHARGES @ 5% :")
                    ''        'Filewrite.WriteLine("{0,10}", Format((Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                    ''        Filewrite.WriteLine("")
                    ''        Vrowcount = Vrowcount + 1
                    ''    End If
                    ''    If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")) > 0 Then
                    ''        'Filewrite.Write("{0,69}", "                                       DISCOUNT PERCENTAGE :")
                    ''        'Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                    ''        Filewrite.WriteLine("")
                    ''        Vrowcount = Vrowcount + 1
                    ''    End If
                    ''    Filewrite.WriteLine("")
                    ''    'Filewrite.WriteLine("{0,-79}", "")
                    ''    Vrowcount = Vrowcount + 1

                    ''    'Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(12, "-"))
                    ''    Filewrite.WriteLine("")
                    ''    Vrowcount = Vrowcount + 1

                    ''    'Filewrite.Write("{0,-50}{1,19}", "", "TOTAL :")
                    ''    'Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                    ''    Filewrite.WriteLine("")
                    ''    Vrowcount = Vrowcount + 1
                    ''    RoundOff = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")))
                    ''    Round = CStr(RoundOff)
                    ''    'If Round.IndexOf(".") <= 0 Then
                    ''    '    Round = Round.Insert(Round.Length - 1, ".00")
                    ''    'End If
                    ''    'Roundedvalue = Split(Round, ".")
                    ''    'If Format(Val(Roundedvalue(1)), "00") = 50 Then
                    ''    '    RoundOff = Math.Ceiling(RoundOff)
                    ''    'ElseIf Format(Val(Roundedvalue(1)), "00") > 50 Then
                    ''    '    RoundOff = Math.Ceiling(RoundOff)
                    ''    'Else
                    ''    '    RoundOff = Math.Floor(RoundOff)
                    ''    'End If
                    ''    RoundOff1 = Mid(Format(Val(RoundOff), "0.00"), Len(Format(Val(RoundOff), "0.00")) - 1, Len(Format(Val(RoundOff), "0.00")))
                    ''    If Format(Val(RoundOff1), "00") = 50 Then
                    ''        RoundOff = Math.Ceiling(RoundOff)
                    ''    ElseIf Format(Val(RoundOff1), "00") > 50 Then
                    ''        RoundOff = Math.Ceiling(RoundOff)
                    ''    Else
                    ''        RoundOff = Math.Floor(RoundOff)
                    ''    End If
                    ''    If Val(RoundOff) > Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))) Then
                    ''        RoundDiff = RoundOff - (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")))
                    ''        'Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(+):")
                    ''    Else
                    ''        RoundDiff = (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))) - RoundOff
                    ''        'Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(-):")
                    ''    End If
                    ''    'Filewrite.WriteLine("{0,10}", Format(Val(RoundDiff), "0.00"))
                    ''    Filewrite.WriteLine("")
                    ''    Vrowcount = Vrowcount + 1
                    ''    'Filewrite.WriteLine(StrDup(81, "-"))
                    ''    Filewrite.WriteLine("")
                    ''    Vrowcount = Vrowcount + 1
                    ''    'rupeesword = ConvertRupees(Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                    ''    'Filewrite.Write("{0,-69}", Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))
                    ''    'Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00"))
                    ''    Filewrite.WriteLine("")
                    ''    Vrowcount = Vrowcount + 1
                    ''    'Filewrite.WriteLine(StrDup(81, "-"))
                    ''    Filewrite.WriteLine("")
                    ''    Vrowcount = Vrowcount + 1
                    ''    Filewrite.Write("{0,-14}{1,-16}", "PREPARED BY:", Mid(UCase(gUsername), 1, 16))
                    ''    Filewrite.WriteLine("{0,-40}", Mid(MyCompanyName, 1, 40))
                    ''    Vrowcount = Vrowcount + 1
                    ''    'Filewrite.WriteLine("{0,-14}{1,-20}", "REMARKS :   ", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("REMARKS"), 1, 20))
                    ''    If Trim(Txt_Remarks.Text) <> "" Then
                    ''        If Len(Trim(Txt_Remarks.Text)) < 65 Then
                    ''            Filewrite.WriteLine("Remarks : " & Trim(Txt_Remarks.Text))
                    ''            Vrowcount = Vrowcount + 1
                    ''        Else
                    ''            Filewrite.WriteLine("Remarks : " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                    ''            Filewrite.WriteLine("          " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                    ''            Vrowcount = Vrowcount + 2
                    ''        End If
                    ''    End If
                    ''    'Vrowcount = Vrowcount + 1
                    ''    Filewrite.WriteLine("")
                    ''    Filewrite.WriteLine(Space(65) & "Continued....")
                    ''    Vrowcount = Vrowcount + 2
                    ''    If Vrowcount <= 24 Then
                    ''        For i = 1 To 24 - Vrowcount
                    ''            Filewrite.WriteLine("")
                    ''        Next
                    ''    End If
                    ''    'End
                    ''End If
                    '''----------------------
                    Vrowcount = 0
                    Sqlstring = "SELECT ISNULL(BillPrintHeader,'') AS BillPrintHeader FROM POSSETUP"
                    gconnection.getDataSet(Sqlstring, "POSSETUP")
                    If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                        For i = 0 To 2
                            Filewrite.WriteLine("")
                        Next
                        Vrowcount = Vrowcount + 3
                        If Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPrintHeader")) = "YES" Then
                            vheader = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Chr(20) & Chr(27) & Chr(72)
                            Filewrite.WriteLine(vheader)
                            Filewrite.WriteLine(vheader)
                            vheader = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(2) & gCompanyname & Chr(20) & Chr(27) & Chr(72)
                            Filewrite.WriteLine(vheader)

                            'vheader = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(2) & gCompanyname & Chr(20) & Chr(27) & Chr(72)
                            'vheader = Space((65 - Len(gCompanyname)) / 2) & Chr(14) & Chr(15) & gCompanyname & Chr(18)
                            'Filewrite.WriteLine(vheader)
                            'vheader = Space(13) & gCompanyAddress(0)
                            vheader = gCompanyAddress(0)
                            'vheader = Space((65 - Len(Trim(gCompanyAddress(0)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(0) & Chr(18)
                            Filewrite.WriteLine(vheader)
                            'vheader = Space(13) & gCompanyAddress(1)
                            vheader = gCompanyAddress(1)
                            'vheader = Space((65 - Len(Trim(gCompanyAddress(1)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(1) & Chr(18)
                            Filewrite.WriteLine(vheader)
                            Vrowcount = Vrowcount + 3
                        End If
                    End If
                    'Filewrite.WriteLine("")
                    'Vrowcount = Vrowcount + 1
                    If gdataset.Tables("Manualbilldetails").Rows(0).Item("DELFLAG") <> "Y" Then
                        vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                    Else
                        'vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & " V O U C H E R [D E L E T E D]"
                        vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & "[D E L E T E D]"
                    End If
                    Filewrite.WriteLine("")
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine(vheader)
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine("")
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("{0,-12}{1,-24}{2,-24}", Mid("BILL   NO:", 1, 10), Mid(Bill, 1, 18), "")
                    Filewrite.WriteLine("{0,-8}{1,-10}", "TIME   :", Format(gdataset.Tables("Manualbilldetails").Rows(0).Item("ADDDATETIME"), "hh:mm:ss"))
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("{0,-12}{1,-24}{2,-24}", Mid("SERVER NO:", 1, 10), Mid(CStr(gdataset.Tables("Manualbilldetails").Rows(0).Item("SERVERNAME")) & "   [" & CStr(gdataset.Tables("Manualbilldetails").Rows(0).Item("STCODE")) & "]", 1, 24), "")
                    Filewrite.WriteLine("{0,-8}{1,-10}", "DATE   :", Format(CDate(gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTDATE")), "dd/MM/yyyy"))
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine(StrDup(81, "-"))
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine("{0,-6}{1,-9}{2,-36}{3,-8}{4,-8}{5,-8}{6,-10}", "SLNO", "CODE", "ITEM DESCRIPTION", "QTY", "UOM", "RATE", "AMOUNT")
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine(StrDup(81, "-"))
                    Vrowcount = Vrowcount + 1
                End If
                With gdataset.Tables("Manualbilldetails").Rows(rowj)
                    Rowprint = ""
                    Rowprint = Mid(CountItem, 1, 5) & "." & Space(5 - Len(Mid(CountItem, 1, 5)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMCODE") & ""), 1, 8) & Space(8 - Len(Mid(Trim(.Item("ITEMCODE") & ""), 1, 8))) & Space(1)
                    'Rowprint = Rowprint & Mid(Trim(.Item("ITEMDESC") & ""), 1, 38) & Mid(Trim(".............................."), 1, 38 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 38)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMDESC") & "........................................"), 1, 38) & Space(38 - Len(Mid(Trim(.Item("ITEMDESC") & "........................................"), 1, 38)))
                    Rowprint = Rowprint & Mid(Val(.Item("QTY") & ""), 1, 3) & Space(3 - Len(Mid(Trim(.Item("QTY") & ""), 1, 3))) & Space(1)
                    Rowprint = Rowprint & Mid(Trim(.Item("UOM") & ""), 1, 7) & Space(7 - Len(Mid(Trim(.Item("UOM") & ""), 1, 7)))
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8)
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8)
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    Vrowcount = Vrowcount + 1
                    innercount = innercount + 1
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                    Vrowcount = Vrowcount + 1
                    If Vrowcount > 32 Then
                        Filewrite.WriteLine(StrDup(79, "-"))
                        Filewrite.WriteLine(Space(55) & "Continued....")
                        Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
                        Filewrite.WriteLine(Rowprint & Chr(15))
                        For i = 1 To 17
                            Filewrite.WriteLine("")
                        Next
                        innercount = 0
                        Vrowcount = 0
                        vpagenumber = Val(vpagenumber) + 1
                    End If
                End With
            Next rowj
            For i = 1 To 20 - innercount
                Filewrite.WriteLine()
            Next i
            Vrowcount = 0
            Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(12, "-"))
            Vrowcount = Vrowcount + 1
            Filewrite.WriteLine("{0,-69}{1,12}", "", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")), "0.00"))
            Vrowcount = Vrowcount + 1
            Sqlstring = " SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("Manualbilldetails").Rows(0).Item("TAXCODE")) & "' "
            gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
            If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                Filewrite.Write("{0,-31}{1,38}", "BILL PAYBLE ON PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                Filewrite.WriteLine("{0,12}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                Vrowcount = Vrowcount + 1
            End If
            If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")) > 0 Then
                Filewrite.Write("{0,69}", "                                      PACKING CHARGES @ 5% :")
                Filewrite.WriteLine("{0,12}", Format((Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                Vrowcount = Vrowcount + 1
            End If
            If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")) > 0 Then
                Filewrite.Write("{0,69}", "                                       DISCOUNT PERCENTAGE :")
                Filewrite.WriteLine("{0,12}", Mid(Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                Vrowcount = Vrowcount + 1
            End If
            Filewrite.WriteLine("{0,-79}", "")
            Vrowcount = Vrowcount + 1
            Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(12, "-"))
            Vrowcount = Vrowcount + 1
            Filewrite.Write("{0,10}{1,-40}{2,19}", "SIGNATURE:", "", "TOTAL :")
            Filewrite.WriteLine("{0,12}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
            Vrowcount = Vrowcount + 1
            RoundOff = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")))
            Round = CStr(RoundOff)
            'If Round.IndexOf(".") <= 0 Then
            '    Round = Round.Insert(Round.Length - 1, ".00")
            'End If
            'Roundedvalue = Split(Round, ".")
            'If Format(Val(Roundedvalue(1)), "00") = 50 Then
            '    RoundOff = Math.Ceiling(RoundOff)
            'ElseIf Format(Val(Roundedvalue(1)), "00") > 50 Then
            '    RoundOff = Math.Ceiling(RoundOff)
            'Else
            '    RoundOff = Math.Floor(RoundOff)
            'End If
            RoundOff1 = Mid(Format(Val(RoundOff), "0.00"), Len(Format(Val(RoundOff), "0.00")) - 1, Len(Format(Val(RoundOff), "0.00")))
            If Format(Val(RoundOff1), "00") = 50 Then
                RoundOff = Math.Ceiling(RoundOff)
            ElseIf Format(Val(RoundOff1), "00") > 50 Then
                RoundOff = Math.Ceiling(RoundOff)
            Else
                RoundOff = Math.Floor(RoundOff)
            End If
            If Val(RoundOff) > Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))) Then
                RoundDiff = RoundOff - (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")))
                'Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(+):")
            Else
                RoundDiff = (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))) - RoundOff
                'Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(-):")
            End If
            'Filewrite.WriteLine("{0,10}", Format(Val(RoundDiff), "0.00"))
            'Vrowcount = Vrowcount + 1
            '-----------MNAME BEGIN
            If gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "ROOM" Then
                Rowprint = gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE")
                Rowprint = Rowprint & " : " & gdataset.Tables("Manualbilldetails").Rows(0).Item("GUEST") & " [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("ROOMNO") & "]"
                'Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                'Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(0).Item("GUEST") & "       [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("ROOMNO") & "]", 1, 45))
                'ElseIf gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "CREDIT" Then
                '    Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                '    Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]", 1, 45))
                'ElseIf gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "COUPON" Then
                '    Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                '    Filewrite.WriteLine("{0,-45}", ":")
            ElseIf gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "R.MEMBER" Then
                Rowprint = gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE")
                Rowprint = Rowprint & " : " & "RECIPROCAL MEMBER"
                'Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                'Filewrite.WriteLine("{0,-45}", Mid(":" & "RECIPROCAL MEMBER", 1, 45))
            ElseIf gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "PENDING" Then
                Rowprint = "MEMEBER NAME :"
                Rowprint = Rowprint & gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]"
                'Filewrite.Write("{0,-20}", "MEMEBER NAME :")
                'Filewrite.WriteLine("{0,-45}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]", 1, 45))
            Else
                If Trim(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE")) = "CREDIT" Then
                    Rowprint = "MEMBER"
                Else
                    Rowprint = gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE")
                End If
                Rowprint = Rowprint & ":" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]"
                'Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                'Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]", 1, 45))
                If Len(Rowprint) < 50 Then
                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                    Filewrite.WriteLine()
                Else
                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                End If
            End If
            '-----------MNAME END
            Vrowcount = Vrowcount + 2
            Filewrite.WriteLine()
            Vrowcount = Vrowcount + 1
            Filewrite.WriteLine(StrDup(81, "-"))
            Vrowcount = Vrowcount + 1
            'rupeesword = ConvertRupees(Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))

            rupeesword = RupeesToWord(Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")), 2), "0.00"))

            Filewrite.Write("{0,-69}", Mid(Trim("RUPEES " & rupeesword & ""), 1, 69))
            'Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00"))
            'Rowprint = Chr(18) & Chr(27) + "E" & Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00") & Chr(27) + "F" & Chr(15)
            Rowprint = Chr(18) & Chr(27) + "E" & Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT")), "0.00") & Chr(27) + "F" & Chr(15)
            Filewrite.WriteLine("{0,14}", Rowprint)
            Vrowcount = Vrowcount + 1
            Filewrite.WriteLine(StrDup(81, "-"))
            Vrowcount = Vrowcount + 1
            Filewrite.Write("{0,-14}{1,-16}", "PREPARED BY:", Mid(UCase(gUsername), 1, 16))
            Filewrite.WriteLine("{0,-40}", Mid(MyCompanyName, 1, 40))
            Vrowcount = Vrowcount + 1

            If Trim(Txt_Remarks.Text) <> "" Then
                If Len(Trim(Txt_Remarks.Text)) < 65 Then
                    Filewrite.WriteLine("Remarks : " & Trim(Txt_Remarks.Text))
                    Vrowcount = Vrowcount + 1
                Else
                    Filewrite.WriteLine("Remarks : " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                    Filewrite.WriteLine("          " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                    Vrowcount = Vrowcount + 2
                End If
            End If            'Filewrite.WriteLine("{0,-14}{1,-20}", "REMARKS :   ", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("REMARKS"), 1, 20))
            'If Vrowcount <= 32 Then
            '    For i = 1 To 32 - Vrowcount
            '        Filewrite.WriteLine("")
            '    Next
            'End If
            'If Vrowcount <= 24 Then
            '    For i = 1 To 24 - Vrowcount
            '        Filewrite.WriteLine("")
            '    Next
            'End If
            For i = 1 To 7
                Filewrite.WriteLine("")
            Next

            For i = 1 To 8
                Filewrite.WriteLine("")
            Next


            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(vFilepath)
            End If
        End If
    End Sub
    Public Function ConvertRupees(ByVal Value As Double) As String
        Dim strText, TempString, TxtArray(5) As String
        Dim locNumber, AbsValue, DecimalValue, NumArray(5), Remain, Loopindex As Double
        NumArray(0) = 7
        NumArray(1) = 5
        NumArray(2) = 3
        NumArray(3) = 2
        TxtArray(0) = " CRORE"
        TxtArray(1) = " LAKH(S)"
        TxtArray(2) = " THOUSAND"
        TxtArray(3) = " HUNDRED"
        AbsValue = Value
        For Loopindex = 0 To 3
            locNumber = (AbsValue - (AbsValue Mod (10 ^ NumArray(Loopindex)))) / (10 ^ NumArray(Loopindex))
            If locNumber > 99 Then
                strText = strText & ConvertRupees(locNumber) & TxtArray(Loopindex)
                AbsValue = AbsValue - (locNumber * (10 ^ NumArray(Loopindex)))
            Else
                If locNumber <> 0 Then
                    If locNumber > 19 Then
                        strText = strText & NumValString(((locNumber - (locNumber Mod 10)) / 10) * 10) & NumValString(locNumber Mod 10) & TxtArray(Loopindex)
                    Else
                        strText = strText & NumValString(locNumber) & TxtArray(Loopindex)
                    End If
                    AbsValue = AbsValue - (locNumber * (10 ^ NumArray(Loopindex)))
                End If
            End If
        Next Loopindex
        If AbsValue <> 0 Then
            If AbsValue > 19 Then
                strText = strText & NumValString(((AbsValue - (AbsValue Mod 10)) / 10) * 10) & NumValString(AbsValue Mod 10) & TxtArray(Loopindex)
            Else
                strText = strText & NumValString(AbsValue)
            End If
        End If
        ConvertRupees = strText
    End Function
    Private Function NumValString(ByVal Value As Double)
        Select Case Value
            Case 1
                NumValString = " ONE"
            Case 2
                NumValString = " TWO"
            Case 3
                NumValString = " THREE"
            Case 4
                NumValString = " FOUR"
            Case 5
                NumValString = " FIVE"
            Case 6
                NumValString = " SIX"
            Case 7
                NumValString = " SEVEN"
            Case 8
                NumValString = " EIGHT"
            Case 9
                NumValString = " NINE"
            Case 10
                NumValString = " TEN"
            Case 11
                NumValString = " ELEVEN"
            Case 12
                NumValString = " TWELVE"
            Case 13
                NumValString = " THIRTEEN"
            Case 14
                NumValString = " FOURTEEN"
            Case 15
                NumValString = " FIFTEEN"
            Case 16
                NumValString = " SIXTEEN"
            Case 17
                NumValString = " SEVENTEEN"
            Case 18
                NumValString = " EIGHTEEN"
            Case 19
                NumValString = " NINETEEN"
            Case 20
                NumValString = " TWENTY"
            Case 30
                NumValString = " THIRTY"
            Case 40
                NumValString = " FOURTY"
            Case 50
                NumValString = " FIFTY"
            Case 60
                NumValString = " SIXTY"
            Case 70
                NumValString = " SEVENTY"
            Case 80
                NumValString = " EIGHTY"
            Case 90
                NumValString = " NINETY"
            Case Else
                NumValString = ""
        End Select
    End Function

    Private Sub lvw_Uom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvw_Uom.KeyPress
        Dim strSQL As String
        Dim uomcode, uomrate As String
        If Asc(e.KeyChar) = 13 Then
            Try
                uomcode = Trim(lvw_Uom.SelectedItems(0).SubItems(0).Text)
                uomrate = Trim(lvw_Uom.SelectedItems(0).SubItems(1).Text)
            Catch ex As Exception
                uomcode = Trim(lvw_Uom.Items(0).SubItems(0).Text)
                uomrate = Trim(lvw_Uom.Items(0).SubItems(1).Text)
            Finally
                ssGrid.SetText(4, ssGrid.ActiveRow, uomcode)
                ssGrid.SetText(6, ssGrid.ActiveRow, uomrate)
                pnl_UOMCode.Top = 1000
                ssGrid.Focus()
                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
            End Try
        End If
    End Sub
    Private Sub lvw_POSCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvw_POSCode.KeyPress
        Dim strSQL As String
        Dim posloc As String
        If Asc(e.KeyChar) = 13 Then
            Try
                posloc = Trim(lvw_POSCode.SelectedItems(0).SubItems(0).Text)
            Catch ex As Exception
                posloc = Trim(lvw_POSCode.Items(0).SubItems(0).Text)
            Finally
                ssGrid.SetText(3, ssGrid.ActiveRow, posloc)
                pnl_POSCode.Top = 1000
                ssGrid.Focus()
                ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
            End Try
        End If
    End Sub
    Public Function SetDateTime()
        Try
            SQLSTRING = "SELECT SERVERDATE,SERVERTIME FROM VIEW_SERVER_DATETIME "
            gconnection.getDataSet(SQLSTRING, "SERVERDATE")
            If gdataset.Tables("SERVERDATE").Rows.Count > 0 Then
                dd = gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERTIME")
                serverdate = gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERTIME")
            End If
            If Val(dd.Hour) >= 0 And Val(dd.Hour) <= 5 Then
                'dtp_BillDate.Value = DateAdd(DateInterval.Day, -1, serverdate)
                KOT_Timer.Enabled = False
                Select Case Val(dd.Hour)
                    Case 1
                        txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-65 - dd.Minute), dd).ToLongTimeString
                    Case 2
                        txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-125 - dd.Minute), dd).ToLongTimeString
                    Case 3
                        txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-185 - dd.Minute), dd).ToLongTimeString
                    Case 4
                        txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-245 - dd.Minute), dd).ToLongTimeString
                    Case 5
                        txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-305 - dd.Minute), dd).ToLongTimeString
                    Case 0
                        txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-5 - dd.Minute), dd).ToLongTimeString
                End Select
            Else
                KOT_Timer.Enabled = True
                txt_KOTTime.Text = dd.ToLongTimeString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub autogenerate()
        Dim sqlstring, financalyear As String
        Try
            sqlstring = "EXEC BILL_MAXNO "
            gconnection.dataOperation(6, sqlstring, "PosKotDoc")
            Call ShowBillno()
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            sqlstring = "SELECT Isnull(DocNo,0) FROM PoSKotDoc with(rowlock,holdlock) Where DocType = '" & Trim(CMB_BTYPE.Text) & "'"
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_KOTno.Text = Trim(BillPrefix) & "/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_KOTno.Text = Trim(BillPrefix) & "/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_KOTno.Text = Trim(BillPrefix) & "/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub
    Private Sub ShowBillno()
        Dim sqlstring, financalyear As String
        Try
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            sqlstring = "SELECT MAX(cast(SUBSTRING(BillNo,1,6) as numeric)) AS BillNo FROM BILL_hdr WHERE SUBSTRING(BILLDETAILS,1,3) = '" & Trim(BillPrefix) & "'"
            gconnection.openConnection()
            gcommand = New SqlCommand(sqlstring, gconnection.Myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is DBNull.Value Then
                    lbl_Status.Visible = True
                    lbl_Status.Text = " FIRST BILL NO "
                Else
                    lbl_Status.Visible = True
                    lbl_Status.Text = " PREVIOUS BILL NO : " & BillPrefix & "/" & Format(Val(gdreader(0)), "000000") & "/" & financalyear
                End If
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            Else
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid Billno :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub KOT_Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles KOT_Timer.Tick
        txt_KOTTime.Text = serverdate.ToLongTimeString
    End Sub
    Private Sub GridUnLock()
        Dim i, j As Integer
        For i = 1 To 100
            For j = 1 To 5
                ssGrid.Col = j
                ssGrid.Row = i
                ssGrid.Lock = False
            Next j
        Next i
    End Sub
    Private Sub txt_KOTno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_KOTno.Validated
        Dim j, i As Integer
        Dim vString, sqlstring, STRSQL As String
        Dim vTypeseqno As Double
        Dim vGroupseqno As Double
        Dim dt As New DataTable
        If Trim(txt_KOTno.Text) <> "" Then
            Try
                'STRSQL = "SELECT * FROM KOT_HDR WHERE KOTDETAILS='" & txt_KOTno.Text & "'"
                'sqlstring = "SELECT ISNULL(PACKAMT,0) as PACKAMT,ISNULL(DISCOUNTAMT,0) as DISCOUNTAMT,* FROM KOT_HDR "
                ''sqlstring = sqlstring & "WHERE KOTNO='" & Format(Val(txt_KOTno.Text), "000000") & "'  AND DOCTYPE ='" & Trim(doctype) & "' OR KOTDETAILS='" & Trim(txt_KOTno.Text) & "' AND SUBSTRING(KOTDETAILS,1,3) ='" & Trim(doctype) & "'"
                ''gconnection.getDataSet(STRSQL, "KOTNO")
                ''sqlstring = "SELECT isnull([16_digit_code],'') as [16_digit_code],ISNULL(PACKAMT,0) as PACKAMT,ISNULL(DISCOUNTAMT,0) as DISCOUNTAMT,ISNULL(MR_FLAG,'') AS MR_FLAG,* "
                ''sqlstring = sqlstring & " FROM KOT_HDR H"
                ''sqlstring = sqlstring & " LEFT OUTER JOIN  RECEIPT_DETAILS R"
                ''sqlstring = sqlstring & " ON H.KOTDETAILS=R.BILLNO  WHERE H.KOTDETAILS='" & txt_KOTno.Text & "'"
                ' sqlstring = sqlstring & " ON H.KOTDETAILS=R.BILLNO  WHERE H.KOTNO='" & Format(Val(txt_KOTno.Text), "000000") & "'  AND H.DOCTYPE ='" & Trim(doctype) & "' OR H.KOTDETAILS='" & Trim(txt_KOTno.Text) & "' AND H.DOCTYPE ='" & Trim(doctype) & "'"

                sqlstring = "SELECT ISNULL(PACKAMT,0) as PACKAMT,ISNULL(DISCOUNTAMT,0) as DISCOUNTAMT,ISNULL(MR_FLAG,'') AS MR_FLAG,* "
                sqlstring = sqlstring & " FROM KOT_HDR H"
                sqlstring = sqlstring & " LEFT OUTER JOIN  RECEIPT_DETAILS R"
                sqlstring = sqlstring & " ON H.KOTDETAILS=R.BILLNO  WHERE H.KOTNO='" & Format(Val(txt_KOTno.Text), "000000") & "'  AND SUBSTRING(KOTDETAILS,1,3) ='" & Trim(BillPrefix) & "' OR H.KOTDETAILS='" & Trim(txt_KOTno.Text) & "' AND SUBSTRING(H.KOTDETAILS,1,3) ='" & Trim(BillPrefix) & "'"
                gconnection.getDataSet(sqlstring, "KOT_HDR")

                'gconnection.getDataSet(sqlstring, "KOT_HDR")
                '''************************************************* SELECT record from KOT_HDR *********************************************''''                
                If gdataset.Tables("KOT_HDR").Rows.Count > 0 Then
                    Call GridUnLock()
                    Cmd_Add.Text = "Update[F7]"
                    Me.txt_KOTno.ReadOnly = True
                    If gdataset.Tables("Kot_Hdr").Rows(0).IsNull("CroStatus") = False Then
                        If Trim(gdataset.Tables("Kot_Hdr").Rows(0).Item("CroStatus")) = "Y" Then
                            Me.Cmd_Add.Enabled = False
                        End If
                    End If
                    If gdataset.Tables("Kot_Hdr").Rows(0).IsNull("BillStatus") = False Then
                        If Trim(gdataset.Tables("Kot_Hdr").Rows(0).Item("BillStatus")) = "ST" Then
                            Me.Lbl_Bill.Visible = True
                            If gdataset.Tables("Kot_Hdr").Rows(0).IsNull("CroStatus") = True Then
                                Me.Lbl_Bill.Text = "BILL GENERATED"
                            Else
                                If Trim(gdataset.Tables("Kot_Hdr").Rows(0).Item("CroStatus")) = "N" Then
                                    Me.Lbl_Bill.Text = "BILL GENERATED"
                                Else
                                    Me.Lbl_Bill.Text = "MRP/CRO GENERATED"
                                    lblCro.Visible = True
                                    lblCro1.Visible = True
                                    Me.lblCro.Text = Trim(gdataset.Tables("Kot_Hdr").Rows(0).Item("CroNO"))
                                    Call disablecontrols()
                                    Call CROGRIDLOCK()
                                End If
                            End If
                        Else
                            Me.Lbl_Bill.Visible = True
                            Me.Lbl_Bill.Text = "BILL GENERATED"
                        End If
                    Else
                        Me.Lbl_Bill.Visible = True
                        Me.Lbl_Bill.Text = "BILL GENERATED"
                    End If
                    If Trim(gdataset.Tables("Kot_Hdr").Rows(0).Item("DELFLAG")) = "Y" Then
                        Me.Lbl_Bill.Text = "BILL DELETED"
                        Call disablecontrols()
                        Call CROGRIDLOCK()
                        Me.Cmd_Add.Enabled = False
                        Me.cmd_Delete.Enabled = False
                        Me.cmd_BillSettlement.Enabled = False
                    End If
                    KOT_Timer.Enabled = False

                    dtp_KOTdate.Value = Format(CDate(gdataset.Tables("KOT_HDR").Rows(0).Item("KOTDATE")), "dd-MMM-yy")
                    txt_KOTTime.Text = Format(gdataset.Tables("KOT_HDR").Rows(0).Item("KOTDATE"), "hh:mm:ss")
                    txt_KOTno.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("KOTDETAILS") & "")
                    txt_TableNo.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("tableno") & "")

                    txt_card_id.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("16_digit_code") & "")

                    txt_Cover.Text = Val(gdataset.Tables("KOT_HDR").Rows(0).Item("Covers"))
                    txt_ServerCode.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("ServerCode") & "")
                    txt_ServerName.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("ServerName") & "")

                    txt_TotalValue.Text = Format(Val(gdataset.Tables("KOT_HDR").Rows(0).Item("Total")), "0.00")
                    txt_TaxValue.Text = Format(Val(gdataset.Tables("KOT_HDR").Rows(0).Item("TotalTax")), "0.00")
                    txt_PackingCharge.Text = Format(Val(gdataset.Tables("KOT_HDR").Rows(0).Item("PackAmt")), "0.00")
                    txt_Discount.Text = Format(Val(gdataset.Tables("KOT_HDR").Rows(0).Item("DiscountAmt")), "0")
                    txt_BillAmount.Text = Format(Val(gdataset.Tables("KOT_HDR").Rows(0).Item("BillAmount")), "0.00")

                    cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_PaymentMode.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("PaymentType") & "")
                    Txt_Remarks.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("Remarks") & "")
                    If gdataset.Tables("KOT_HDR").Rows(0).IsNull("Subpaymentmode") = False Then
                        If Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("Subpaymentmode") & "") <> "" Then
                            Call FillSubPaymentMode(Trim(gdataset.Tables("KOt_HDR").Rows(0).Item("PaymentType") & ""))
                            sqlstring = "SELECT SUBPAYMENTNAME,SUBPAYMENTCODE FROM SUBPAYMENTMODE WHERE SUBPAYMENTCODE = '" & Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("Subpaymentmode")) & "' "
                            gconnection.getDataSet(sqlstring, "SUBPAYMENTMODE")
                            If gdataset.Tables("SUBPAYMENTMODE").Rows.Count = 1 Then
                                cbo_SubPaymentMode.DropDownStyle = ComboBoxStyle.DropDown
                                Me.cbo_SubPaymentMode.Text = Trim(gdataset.Tables("SUBPAYMENTMODE").Rows(0).Item("SUBPAYMENTCODE") & "-" & Trim(gdataset.Tables("SUBPAYMENTMODE").Rows(0).Item("SUBPAYMENTNAME")))
                                cbo_SubPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
                            End If
                        End If
                    End If
                    If Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("PaymentType")) = "ROOM" Then
                        txt_MemberCode.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("ROOMNO")) & ""
                        txt_MemberName.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("GUEST")) & ""
                        txt_MemberCode.Tag = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("CHECKIN")) & ""
                    Else
                        Try
                            sqlstring = " SELECT ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
                            sqlstring = sqlstring & "WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
                            gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
                            If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                                If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) = "NO" Then
                                    txt_MemberCode.Visible = False
                                    txt_MemberName.Visible = False
                                    lbl_Membercode.Visible = False
                                    lbl_MemberName.Visible = False
                                    cmd_MemberCodeHelp.Visible = False
                                    txt_MemberCode.Text = ""
                                    txt_MemberName.Text = ""
                                Else
                                    txt_MemberCode.Visible = True
                                    txt_MemberName.Visible = True
                                    lbl_Membercode.Visible = True
                                    lbl_MemberName.Visible = True
                                    cmd_MemberCodeHelp.Visible = True
                                    lbl_Membercode.Text = "MEMBER CODE"
                                    lbl_MemberName.Text = "MEMBER NAME"
                                    txt_MemberCode.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("MCode")) & ""
                                    txt_MemberName.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("Mname")) & ""
                                    txt_Holder_Code.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("cardholdercode")) & ""
                                    Txt_holder_name.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("cardholdername")) & ""
                                    txt_MemberCode_Validated(sender, e)



                                    'If txt_MemberCode.Text <> "" Then
                                    '    PHOTOFILENAME = STRPHOTOPATH & "\" & Mid(Trim(txt_MemberCode.Text), 1, Len(Trim(txt_MemberCode.Text))) & ".jpg"
                                    '    PHOTOFILENAME = Replace(PHOTOFILENAME, " ", "")
                                    '    If File.Exists(PHOTOFILENAME) Then
                                    '        Pic_Member.Image = New Bitmap(PHOTOFILENAME)
                                    '    Else
                                    '        Pic_Member.Image = Nothing
                                    '    End If
                                    'End If
                                End If
                            Else
                                MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            End If
                        Catch ex As Exception
                            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                            Exit Sub
                        End Try
                    End If
                    '''************************************************* SELECT record from KOT_DET *********************************************''''                
                    sqlstring = "SELECT ISNULL(SALESACCOUNTCODE,0) AS SALESACCOUNTCODE,ISNULL(TAXACCOUNTCODE,0) AS TAXACCOUNTCODE,ISNULL(GROUPCODE,0) AS GROUPCODE,ISNULL(PACKPERCENT,0) AS PACKPERCENT,"
                    sqlstring = sqlstring & " ISNULL(PACKAMOUNT,0) AS PACKAMOUNT,ISNULL(OPENFACILITYST,0) AS OPENFACILITYST,ISNULL(PROMOTIONALST,0) AS PROMOTIONALST,ISNULL(PACKACCOUNTCODE,'') AS PACKACCOUNTCODE,* FROM KOT_DET WHERE  KOTDETAILS='" & Trim(txt_KOTno.Text) & "' ORDER BY AUTOID "
                    gconnection.getDataSet(sqlstring, "KOT_DET")
                    If gdataset.Tables("KOT_DET").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("KOT_DET").Rows.Count
                            ssGrid.SetText(1, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("ItemCode")) & "")
                            ssGrid.SetText(2, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("itemdesc")) & "")
                            ssGrid.SetText(3, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("poscode")))
                            ssGrid.SetText(4, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("UOM")))
                            ssGrid.SetText(5, i, Val(gdataset.Tables("KOT_DET").Rows(j).Item("Qty")))
                            ssGrid.SetText(6, i, Format(Val(gdataset.Tables("KOT_DET").Rows(j).Item("Rate")), "0.00"))
                            ssGrid.SetText(7, i, Format(Val(gdataset.Tables("KOT_DET").Rows(j).Item("Taxamount")), "0.00"))
                            ssGrid.SetText(8, i, Format(Val(gdataset.Tables("KOT_DET").Rows(j).Item("Amount")), "0.00"))
                            ssGrid.SetText(9, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("ItemType")) & "")
                            ssGrid.SetText(10, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("TaxCode")) & "")
                            ssGrid.SetText(11, i, Val(gdataset.Tables("KOT_DET").Rows(j).Item("TaxPerc")))
                            ssGrid.SetText(13, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("TaxAccountCode")))
                            ssGrid.SetText(14, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("SalesAccountCode")))
                            ssGrid.SetText(15, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("GroupCode")))
                            ssGrid.SetText(16, i, Val(gdataset.Tables("KOT_DET").Rows(j).Item("Autoid")))
                            ssGrid.SetText(17, i, Val(gdataset.Tables("KOT_DET").Rows(j).Item("PackPercent")))
                            ssGrid.SetText(18, i, Val(gdataset.Tables("KOT_DET").Rows(j).Item("PackAmount")))
                            ssGrid.SetText(19, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("Openfacilityst")))
                            ssGrid.SetText(20, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("Promotionalst")))
                            ssGrid.SetText(21, i, Trim(gdataset.Tables("KOT_DET").Rows(j).Item("Packaccountcode")))
                            'REFERINVENTORY***********************************************************************
                            ssGrid.SetText(22, i, Val(gdataset.Tables("KOT_DET").Rows(j).Item("Qty")))
                            '*************************************************************************************
                            If CStr(gdataset.Tables("KOT_DET").Rows(j).Item("KOTStatus") & "") = "Y" Then
                                ssGrid.SetText(12, i, 1)
                            Else
                                ssGrid.SetText(12, i, 0)
                            End If
                            j = j + 1
                        Next
                    End If
                    '''************************************************* SELECT record from BILLSETTLEMENT  *********************************************''''                
                    sqlstring = "SELECT ISNULL(BILLNO,'') AS BILLNO,BILLDATE,ISNULL(PAYMENTMODE,'') AS PAYMENTMODE,ISNULL(PAYMENTACCOUNTCODE,'') AS PAYMENTACCOUNTCODE,"
                    sqlstring = sqlstring & " ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CARDTYPE,'') AS CARDTYPE,ISNULL(INSTRUMENTNO,'') AS INSTRUMENTNO,INSTRUMENTDATE,"
                    sqlstring = sqlstring & " ISNULL(BANKNAME,'') AS BANKNAME,ISNULL(RECEIVEDNAME,'') AS RECEIVEDANAME,ISNULL(PAYAMOUNT,0) AS PAYAMOUNT,ISNULL(BILLAMOUNT,0) AS BILLAMOUNT,"
                    sqlstring = sqlstring & " ISNULL(BALANCEAMOUNT,0) AS BALANCEAMOUNT  FROM BILLSETTLEMENT WHERE BILLNO = '" & Trim(txt_KOTno.Text) & "' ORDER BY PAYMENTMODE"
                    gconnection.getDataSet(sqlstring, "BILLSETTLEMENT")
                    If gdataset.Tables("BILLSETTLEMENT").Rows.Count > 0 Then
                        j = 0
                        For i = 1 To gdataset.Tables("BILLSETTLEMENT").Rows.Count
                            ssgridPayment.SetText(1, i, Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("BILLNO")) & "")
                            ssgridPayment.SetText(2, i, Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("BILLDATE")) & "")
                            Call FillPaymentmodeSettlement(i)
                            ssgridPayment.SetText(3, i, Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("PAYMENTMODE")))
                            ssgridPayment.SetText(5, i, Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("MCODE")))
                            ssgridPayment.SetText(6, i, Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("MNAME")))
                            ssgridPayment.SetText(4, i, Format(Val(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("PAYAMOUNT")), "0.00"))
                            ssgridPayment.SetText(7, i, Format(Val(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("BILLAMOUNT")), "0.00"))
                            ssgridPayment.SetText(8, i, Format(Val(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("BALANCEAMOUNT")), "0.00"))
                            ssgridPayment.Col = 3
                            ssgridPayment.Row = i
                            sqlstring = " SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE,ISNULL(PAYMENTTYPE,'') AS PAYMENTTYPE  FROM paymentmodemaster WHERE Paymentcode = '" & Trim(ssgridPayment.Text) & "' AND ISNULL(Freeze,'')='N'"
                            gconnection.getDataSet(sqlstring, "paymentmodemaster")
                            If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                                If Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentType")) = "CD" Then
                                    txt_Typeofcard.Text = Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("CARDTYPE"))
                                    txt_Cardno.Text = Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("INSTRUMENTNO"))
                                    dtp_Expirydate.Value = Format(CDate(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("INSTRUMENTDATE")), "dd-MMM-yyyy")
                                    txt_Cardholdername.Text = Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("PAYMENTMODE"))
                                ElseIf Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentType")) = "CQ" Then
                                    cbo_Typeofcheque.Text = Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("CARDTYPE"))
                                    txt_Chequeno.Text = Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("INSTRUMENTNO"))
                                    dtp_Chequedate.Value = Format(CDate(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("INSTRUMENTDATE")), "dd-MMM-yyyy")
                                    txt_Draweebank.Text = Trim(gdataset.Tables("BILLSETTLEMENT").Rows(j).Item("BANKNAME"))
                                End If
                            End If
                            j = j + 1
                        Next
                    Else
                        ssgridPayment.ClearRange(1, 1, -1, -1, True)
                    End If
                    TotalItemCount = gdataset.Tables("KOT_DET").Rows.Count
                    Call Fillsettlement()
                    Call fac_det()
                    ssGrid.SetActiveCell(1, 1)
                    cbo_PaymentMode.Focus()
                    cmd_KOTnoHelp.Enabled = False
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                Else
                    Call cmd_Clear_Click(cmd_Clear, e)
                    cbo_PaymentMode.Focus()

                    'dtp_KOTdate.Focus()
                    ''If gdataset.Tables("KOTNO").Rows.Count = 0 Then
                    ''    STRSQL = " Select isnull(Prefix,'') as Prefix,isnull(Servercode,'') as Servercode From Kotbook "
                    ''    STRSQL = STRSQL & "  Where  " & IIf(Val(txt_KOTno.Text) > 0, Val(txt_KOTno.Text), 0) & " between snofrom and  snoto "
                    ''    gconnection.getDataSet(STRSQL, "servermaster")
                    ''    If gdataset.Tables("servermaster").Rows.Count > 0 Then
                    ''        txt_ServerCode.Text = gdataset.Tables("servermaster").Rows(0).Item("Servercode")
                    ''        txt_ServerCode_Validated(sender, e)
                    ''        cbo_PaymentMode.Focus()
                    ''        'txt_MemberCode.Focus()
                    ''    Else
                    ''        ' MessageBox.Show("Kindly Register This Kotbook in System,Thanking You", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ''        ' txt_KOTno.Text = ""
                    ''        'txt_KOTno.Focus()
                    ''        'Exit Sub
                    ''    End If
                    ''End If


                End If
                Calculate()
                Call CMD_LOCK()
            Catch ex As Exception
                MessageBox.Show("Enter valid Bill No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_KOTno.Text = ""
                txt_KOTno.Focus()
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub bill_closing()
        Dim ssql As String
        ssql = "select isnull(accountflag,'')  as Aflag from bill_hdr where billdetails='" & txt_KOTno.Text & "'"
        gconnection.getDataSet(ssql, "Bill")
        If gdataset.Tables("Bill").Rows.Count > 0 Then
            If Trim(gdataset.Tables("Bill").Rows(0).Item("Aflag")) = "Y" Then
                Cmd_Add.Enabled = False
                cmd_Delete.Enabled = False
                cmd_Delete.Enabled = False
                cmd_BillSettlement.Enabled = False
            End If
        End If
    End Sub

    Private Sub disablecontrols()
        txt_TableNo.ReadOnly = True
        txt_Cover.ReadOnly = True
        txt_MemberCode.ReadOnly = True
        txt_MemberName.ReadOnly = True
        txt_ServerCode.ReadOnly = True
        txt_ServerName.ReadOnly = True
        dtp_KOTdate.Enabled = False
        cbo_PaymentMode.Enabled = False
        cbo_SubPaymentMode.Enabled = False
        cmd_MemberCodeHelp.Enabled = False
        cmd_ServerCodeHelp.Enabled = False
        cmd_TablenoHelp.Enabled = False
    End Sub
    Private Sub enablecontrols()
        txt_TableNo.ReadOnly = False
        txt_Cover.ReadOnly = False
        txt_MemberCode.ReadOnly = False
        txt_MemberName.ReadOnly = False
        txt_ServerCode.ReadOnly = False
        txt_ServerName.ReadOnly = False
        dtp_KOTdate.Enabled = True
        cbo_PaymentMode.Enabled = True
        cbo_SubPaymentMode.Enabled = True
        cmd_MemberCodeHelp.Enabled = True
        cmd_ServerCodeHelp.Enabled = True
        cmd_TablenoHelp.Enabled = True
    End Sub
    Private Sub CROGRIDLOCK()
        Dim Row, Col As Integer
        ssGrid.Col = 15
        ssGrid.Row = ssGrid.ActiveRow
        For Row = 1 To 100
            For Col = 1 To 15
                ssGrid.Row = Row
                ssGrid.Col = Col
                ssGrid.Lock = True
            Next
        Next Row
    End Sub
    Private Sub checkvalidate()
        Dim icode, icode1, uom, uom1, Fstart, Fend As String
        Dim taxcode, sqlstring, itemcode, itemdesc, SQL As String
        Dim i, j As Integer
        Dim a, B As Integer
        chkbool = False
        Call SetDateTime()
        Call bill_roundoff()
        If Cmd_Add.Text = "Add [F7]" Then
            Call autogenerate()

            If (Trim(txt_card_id.Text) = "") Then
                MessageBox.Show(" PLEASE SWIPE THE CARD ", "SMART CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_card_id.Focus()
                chkbool = False
                Exit Sub
            End If
        End If
        ''***************************************** Assign Account Code Value **********************************************'''
        'SMART CARD VALIDATE
        'BEGIN



        Dim msgres As String
        msgres = creditstop(txt_MemberCode.Text)
        If Mid(msgres, 1, 1) = "C" Then
            If cbo_PaymentMode.Text = "CREDIT" Or cbo_PaymentMode.Text = "PARTY" Then
                MsgBox("Current Status is " & msgres & ",Kindly Use Cash/SmartCard", MsgBoxStyle.Information, "Info")
                cbo_PaymentMode.Focus()
                Exit Sub
            End If
        ElseIf Mid(msgres, 1, 1) = "D" Then
            MsgBox("Current Status is " & msgres & ",Sorry You Can Not Make Any Kot", MsgBoxStyle.Information, "Info")
            Exit Sub
        End If


        If txt_card_id.Text <> "" Then
            If Trim(txt_Holder_Code.Text) <> "" Or Trim(Txt_holder_name.Text) <> "" Or Trim(txt_card_id.Text) <> "" Then
                If Trim(Txt_holder_name.Text) = "" Then
                    MessageBox.Show("Card Holder Name Can't be blank, Pls Swipe Card", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    txt_card_id.Clear()
                    txt_card_id.Focus()
                    Exit Sub
                End If
                If Trim(txt_Holder_Code.Text) = "" Then
                    MessageBox.Show("Card Holder Code Can't be blank, Pls Swipe Card", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    txt_card_id.Clear()
                    txt_card_id.Focus()
                    Exit Sub
                End If
                If Trim(txt_card_id.Text) = "" Then
                    MessageBox.Show("Card Id Can't be blank, Pls Swipe Card", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    txt_card_id.Clear()
                    txt_card_id.Focus()
                    Exit Sub
                End If
            End If
            BILLAMT_GBL = Val(txt_BillAmount.Text)
            If cbo_PaymentMode.Text = "SMART CARD" Then
                If (MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL < Val(txt_BillAmount.Text) Then
                    MsgBox("BALANCE NOT AVAILABLE", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                sqlstring = "SELECT * FROM SM_CARDFILE_HDR WHERE CARDCODE ='" & Trim(CStr(txt_Holder_Code.Text)) & "' "
                gconnection.getDataSet(sqlstring, "SM_CARDFILE_HDR ")
                If gdataset.Tables("SM_CARDFILE_HDR ").Rows.Count > 0 Then
                    'TO BE CHANGE
                    '                    smartcardbool = True
                    smartcardbool = False

                Else
                    MessageBox.Show("Sorry this member don't hav card facility", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    txt_MemberCode.Focus()
                    smartcardbool = False
                    Exit Sub
                End If
            End If
        End If
        'SMART CARD VALIDATE
        'END
        If cbo_PaymentMode.Text <> "ROOM" And cbo_PaymentMode.Text <> "CLUB" Then
            sqlstring = "SELECT ISNULL(CURENTSTATUS,'') AS MEMSTATUS,ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CRIDITNUMBER,'') AS CRIDITNUMBER FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
            gconnection.getDataSet(sqlstring, "membermaster")
            If gdataset.Tables("membermaster").Rows.Count > 0 Then
                LAB_MSTATUS.Text = "MEMBER STATUS:" & UCase(gdataset.Tables("membermaster").Rows(0).Item("MEMSTATUS"))
                If UCase(gdataset.Tables("membermaster").Rows(0).Item("MEMSTATUS")) <> "LIVE" Then
                    MessageBox.Show("Member is:" & UCase(gdataset.Tables("membermaster").Rows(0).Item("MEMSTATUS")) & ",you can not entry", "MEMBER STATUS")
                    Cmd_Add.Enabled = True
                    cmd_Delete.Enabled = True
                    txt_MemberCode.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("MemberShipno not found in Database", "MEMBER STATUS")
                txt_MemberCode.Text = ""
                lab_outstanding.Text = ""
                txt_MemberCode.Focus()
                LAB_MSTATUS.Text = ""
                Exit Sub
            End If
        End If
        sqlstring = "SELECT * FROM BILL_HDR WHERE BILLDETAILS = '" & Trim(txt_KOTno.Text) & "' AND ISNULL(crostatus,'N')='Y' "
        gconnection.getDataSet(sqlstring, "CRO")
        If gdataset.Tables("CRO").Rows.Count > 0 Then
            MsgBox("Sorry, Settlement Was Already Made, You Can't Delete/Update....")
            Exit Sub
        End If
        sqlstring = "SELECT * FROM MATCHING WHERE VOUCHERNO = '" & Trim(txt_KOTno.Text) & "' AND VOUCHERDATE = '" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "'"
        gconnection.getDataSet(sqlstring, "MATCHING")
        If gdataset.Tables("MATCHING").Rows.Count > 0 Then
            MsgBox("Sorry, Bill Matching Was Already Made, You Can't Delete/Update....")
            Exit Sub
        End If

        If txt_KOTno.Text = "" Then
            MessageBox.Show("Please Entry the Kotno.", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_KOTno.Focus()
            Exit Sub
        End If
        If SMENTTYPE = "YES" Then
            If SETLEMENT_GROUP.Visible = True Then
                MessageBox.Show("Please Close the Settlement Screen.", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssgrid_settlement.Focus()
                Exit Sub
            End If
        End If

        SQL = "SELECT * FROM kot_hdr WHERE CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) ='" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "' AND postingstatus = 'Y'"
        gconnection.getDataSet(SQL, "kot_hdr")
        If gdataset.Tables("kot_hdr").Rows.Count > 0 Then
            Cmd_Add.Enabled = False
            cmd_Delete.Enabled = False
            MessageBox.Show("NO KOT SHOULD BE ENTERED/UPDATED FOR BILL CLOSED DATE:" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        a = Month(Trim(dtp_KOTdate.Text))
        SQL = "SELECT * FROM bill_hdr WHERE month(billdate) = " & Val(a) & " AND ACCOUNTFLAG = 'Y'"
        gconnection.getDataSet(SQL, "bill_hdr")
        If gdataset.Tables("bill_hdr").Rows.Count > 0 Then
            Cmd_Add.Enabled = False
            cmd_Delete.Enabled = False
            MessageBox.Show("NO KOT SHOULD BE ENTERED FOR MEMBER BILL GENERATED MONTH", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If



        If cbo_PaymentMode.SelectedItem = "ROOM" Then
            accountcode = "RMLDGR"
        ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
            accountcode = Trim(gDebitors)
        Else
            accountcode = ""
        End If
        '''**************************************** Check Tableno can't be blank *******************************************'''
        'If Trim(txt_TableNo.Text) = "" Then
        '    MessageBox.Show("Table No. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_TableNo.Focus()
        '    Exit Sub
        'End If
        '''**************************************** Check Payment Mode can't be blank *******************************************''
        Fstart = "01-APR-" & Trim(gFinancalyearStart)
        Fend = "31-MAR-" & Trim(gFinancialYearEnd)
        If DateDiff(DateInterval.Day, Me.dtp_KOTdate.Value, serverdate) < 0 Then
            Me.dtp_KOTdate.Focus()
            MessageBox.Show("Billdate can't be greater then today's date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If (Format(Me.dtp_KOTdate.Value, "dd-MMM-yyyy") > Format(Fstart, "dd-MMM-yyyy")) And (Format(Me.dtp_KOTdate.Value, "dd-MMM-yyyy") < Format(Fend, "dd-MMM-yyyy")) Then
            Me.dtp_KOTdate.Focus()
            MessageBox.Show("Voucher Date Should Be Within The Financial Year", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If Trim(cbo_PaymentMode.Text) = "" Then
            MessageBox.Show("Payment Mode Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            cbo_PaymentMode.Focus()
            Exit Sub
        End If

        '''**************************************** Check Room No and Member Code can't be blank *******************************************''
        If Trim(txt_MemberCode.Text) = "" Then
            If cbo_PaymentMode.Text = "ROOM" Then
                MessageBox.Show("Room No Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_MemberCode.Focus()
                Exit Sub
            Else
                Try
                    sqlstring = " SELECT ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
                    sqlstring = sqlstring & "WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
                    gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
                    If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                        If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) <> "NO" Then
                            MessageBox.Show("Member Code Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            txt_MemberCode.Focus()
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                Catch ex As Exception
                    MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End Try
            End If
        End If
        '''**************************************** Check Guest Name and Member Name can't be blank *******************************************''
        If Trim(txt_MemberName.Text) = "" Then
            If cbo_PaymentMode.Text = "ROOM" Then
                MessageBox.Show("Guest Name Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_MemberName.Focus()
                Exit Sub
            Else
                Try
                    sqlstring = " SELECT ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
                    sqlstring = sqlstring & "WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
                    gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
                    If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                        If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) <> "NO" Then
                            MessageBox.Show("Member Name Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            txt_MemberName.Focus()
                            Exit Sub
                        End If
                    Else
                        MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                Catch ex As Exception
                    MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End Try
            End If
        End If
        '''**************************************** Check Server Code can't be blank *******************************************''


        'If cbo_PaymentMode.Text = "CREDIT" And Len(Trim(txt_creditfacility)) = 0 Then
        '    MessageBox.Show("This member is not not entitled for Credit facility", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_MemberCode.Focus()
        '    Exit Sub
        'ElseIf cbo_PaymentMode.Text = "N.CREDIT" And Len(Trim(txt_creditfacility)) > 0 Then
        '    MessageBox.Show("This member has the credit Facility. Kindly change the mode of payment", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    txt_MemberCode.Focus()
        '    Exit Sub
        'End If

        If Trim(txt_ServerCode.Text) = "" Then
            MessageBox.Show("Server Code. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_ServerCode.Focus()
            Exit Sub
        End If
        '''**************************************** Check Server Name can't be blank *******************************************''
        If Trim(txt_ServerName.Text) = "" Then
            MessageBox.Show("Server Name Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_ServerName.Focus()
            Exit Sub
        End If
        '''********************************************* Check ssgrid value can't be blank ********************************************'''
        If ssGrid.DataRowCnt = 0 Then
            MessageBox.Show("!! Sorry !!There is no KOT DETAILS part to be saved", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ssGrid.Focus()
            ssGrid.SetActiveCell(1, 1)
            Exit Sub
        End If
        With ssGrid
            For i = 1 To .DataRowCnt
                If i = 1 Then
                    .Col = 3
                    .Row = i
                    loccode = Trim(.Text)
                End If
                .Col = 19
                .Row = i
                If Trim(.Text) <> "Y" Then
                    .Row = i
                    .Col = 1
                    itemcode = Trim(CStr(ssGrid.Text))
                    .Row = i
                    .Col = 2
                    itemdesc = Trim(CStr(ssGrid.Text))
                    sqlstring = "SELECT ITEMCODE,ITEMDESC FROM ITEMMASTER WHERE Itemcode = '" & Trim(itemcode) & "' AND Itemdesc = '" & Trim(itemdesc) & "'"
                    gconnection.getDataSet(sqlstring, "ITEMMASTER")
                    If gdataset.Tables("ITEMMASTER").Rows.Count > 0 Then
                        .Row = i
                        .Col = 1
                        ssGrid.Text = Trim(CStr(gdataset.Tables("ITEMMASTER").Rows(0).Item("ITEMCODE")))
                        .Row = i
                        .Col = 2
                        ssGrid.Text = Trim(CStr(gdataset.Tables("ITEMMASTER").Rows(0).Item("ITEMDESC")))
                    Else
                        MessageBox.Show("!!Warning!! Itemcode : " & Trim(itemcode) & " And Itemdesc : " & Trim(itemdesc) & " is not valid ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ssGrid.Focus()
                        ssGrid.SetActiveCell(1, i)
                        Exit Sub
                    End If
                End If
            Next
        End With
        For i = 1 To ssGrid.DataRowCnt
            ssGrid.Row = i
            ssGrid.Col = 1
            If Trim(ssGrid.Text) = "" Then
                MessageBox.Show("Item Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(1, i)
                ssGrid.Focus()
                Exit Sub
            End If
            ssGrid.Col = 2
            If Trim(ssGrid.Text) = "" Then
                MessageBox.Show("Item Description can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(2, i)
                ssGrid.Focus()
                Exit Sub
            End If
            ssGrid.Col = 3
            If (ssGrid.Text) = "" Then
                MessageBox.Show("POS Location can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(3, i)
                ssGrid.Focus()
                Exit Sub
            End If
            ssGrid.Col = 4
            If Trim(ssGrid.Text) = "" Then
                MessageBox.Show("UOM can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(4, i)
                ssGrid.Focus()
                Exit Sub
            End If
            ssGrid.Col = 5
            If Val(ssGrid.Text) = 0 Then
                MessageBox.Show("Quantity can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(5, i)
                ssGrid.Focus()
                Exit Sub
            End If
            ssGrid.Col = 6
            If Val(ssGrid.Text) = 0 Then
                ssGrid.Col = 20
                ssGrid.Row = i - 1
                If POScode <> 24 Then
                    If Trim(ssGrid.Text) <> "Y" Then
                        MessageBox.Show("Rate can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ssGrid.SetActiveCell(6, i)
                        ssGrid.Focus()
                        Exit Sub
                    Else
                        ssGrid.Col = 1
                        ssGrid.Row = i
                        If Mid(Trim(ssGrid.Text), Len(Trim(ssGrid.Text)), 1) <> "A" Then
                            MessageBox.Show("Rate can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            ssGrid.SetActiveCell(6, i)
                            ssGrid.Focus()
                            Exit Sub
                        End If
                    End If
                End If
            End If
            ssGrid.Col = 8
            If Val(ssGrid.Text) = 0 Then
                ssGrid.Col = 20
                ssGrid.Row = i - 1
                If POScode <> 24 Then
                    If Trim(ssGrid.Text) <> "Y" Then
                        MessageBox.Show("Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ssGrid.SetActiveCell(8, i)
                        ssGrid.Focus()
                        Exit Sub
                    Else
                        ssGrid.Col = 1
                        ssGrid.Row = i
                        If Mid(Trim(ssGrid.Text), Len(Trim(ssGrid.Text)), 1) <> "A" Then
                            MessageBox.Show("Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            ssGrid.SetActiveCell(8, i)
                            ssGrid.Focus()
                            Exit Sub
                        End If
                    End If
                End If
            End If
            ssGrid.Col = 9
            If Trim(ssGrid.Text) = "" Then
                MessageBox.Show("Item Type can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(9, i)
                ssGrid.Focus()
                Exit Sub
            End If
            ssGrid.Col = 14
            If Trim(ssGrid.Text) = "" Then
                MessageBox.Show("Sales Account can't blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(11, i)
                ssGrid.Focus()
                Exit Sub
            End If
        Next i
        If Cmd_Add.Text = "Update[F7]" And Me.Lbl_Bill.Text = "CRO GENERATED" Then
            If Me.ssGrid.DataRowCnt > TotalItemCount Then
                MessageBox.Show("Specified Billno has been deposited in CRO Counter", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        chkbool = True
    End Sub
    Private Sub FillSubPaymentMode(ByVal Paymode As String)
        Dim sql As String
        Dim i As Integer
        Dim dt As New DataTable
        sql = "SELECT ISNULL(SUBPAYSTATUS,'') AS SUBPAYSTATUS FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(Paymode) & "'"
        gconnection.getDataSet(sql, "PAYMENTMODEMASTER")
        If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
            If gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("SUBPAYSTATUS") = "YES" Then
                sql = "SELECT subpaymentcode + '-' + SubPaymentname FROM SubpaymentMode WHERE Paymentcode='" & Trim(Paymode) & "' AND ISNULL(Freeze,'')<>'Y'"
                Me.cbo_SubPaymentMode.Items.Clear()
                dt = gconnection.GetValues(sql)
                If dt.Rows.Count > 0 Then
                    Me.cbo_SubPaymentMode.Visible = True
                    lbl_SubPaymentMode.Visible = True
                    For i = 0 To dt.Rows.Count - 1
                        Me.cbo_SubPaymentMode.Items.Add(dt.Rows(i).Item(0))
                    Next i
                    Me.cbo_PaymentMode.Focus()
                    Me.cbo_SubPaymentMode.SelectedIndex = 0
                Else
                    cbo_SubPaymentMode.Visible = False
                    lbl_SubPaymentMode.Visible = False
                End If
            End If
        End If
    End Sub
    Private Sub ssGrid_LeaveCell(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssGrid.LeaveCell
        Dim Sqlstring, Itemcode, Itemdesc, Promtcode As String
        Dim varitemcode, varitemdesc, varposcode As String
        Dim i, j As Integer
        Dim qty As String
        Call Calculate()
        Try
            i = ssGrid.ActiveRow
            If ssGrid.ActiveCol = 1 Then
                ssGrid.Col = 1
                ssGrid.Row = i
                If ssGrid.Lock = False Then
                    If Trim(ssGrid.Text) <> "" Then

                    End If
                End If
            ElseIf ssGrid.ActiveCol = 2 Then
                ssGrid.Col = 2
                ssGrid.Row = i
                If ssGrid.Lock = False Then
                    If Trim(ssGrid.Text) <> "" Then
                        ssGrid.Col = 3
                        ssGrid.Row = i
                        If Trim(ssGrid.Text) = "" Then
                            ssGrid.Row = i
                            ssGrid.Col = 2
                            varitemdesc = Trim(ssGrid.Text)
                            If Trim(varitemdesc) <> "" Then
                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                                Sqlstring = "SELECT DISTINCT ISNULL(I.ITEMDESC,'') AS ITEMDESC,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMTYPECODE,'') AS ITEMTYPECODE,ISNULL(PL.POS,'') AS POS,ISNULL(TL.TAXCODE,'') AS TAXCODE,ISNULL(TL.TAXPERCENTAGE,0) AS TAXPERCENTAGE,"
                                Sqlstring = Sqlstring & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.PROMOTIONAL,'') AS PROMOTIONAL ,ISNULL(I.PROMITEMCODE,'') AS PROMITEMCODE,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN,"
                                Sqlstring = Sqlstring & " ISNULL(P.PACKINGPERCENT,0) AS PACKINGPERCENT, ISNULL(OPENFACILITY,'') AS OPENFACILITY,ISNULL(P.PACKINGACCTIN,'') AS PACKINGACCTIN "
                                Sqlstring = Sqlstring & "  FROM ITEMMASTER AS I INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "
                                Sqlstring = Sqlstring & " INNER JOIN POSMENULINK AS PL ON PL.ITEMCODE = I.ITEMCODE INNER JOIN POSMASTER AS P ON PL.POS = P.POSCODE "
                                Sqlstring = Sqlstring & " WHERE I.ITEMDESC = '" & Trim(varitemdesc) & "' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE  AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y' --AND POSCODE = '" & Trim(POScode) & "' "
                                gconnection.getDataSet(Sqlstring, "ITEMCODE")
                                If gdataset.Tables("ITEMCODE").Rows.Count > 0 Then
                                    ssGrid.SetText(1, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMCODE")))
                                    ssGrid.SetText(2, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMDESC")))
                                    ssGrid.SetText(3, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("POS")))
                                    ssGrid.SetText(9, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMTYPECODE")))
                                    ssGrid.SetText(10, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXCODE")))
                                    ssGrid.SetText(11, i, Val(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXPERCENTAGE")))
                                    ssGrid.SetText(13, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ACCOUNTCODE")))
                                    ssGrid.SetText(14, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("SALESACCTIN")))
                                    ssGrid.SetText(15, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("GROUPCODE")))
                                    ssGrid.SetText(17, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PACKINGPERCENT")))
                                    ssGrid.SetText(19, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")))
                                    ssGrid.SetText(20, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PROMOTIONAL")))
                                    ssGrid.SetText(21, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PACKINGACCTIN")))
                                    If Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")) = "Y" Then
                                        ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                                    Else
                                        ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                    End If
                                    '''*************************** $ PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                    If Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("Promotional")) = "Y" Then
                                        Promtcode = Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PROMITEMCODE"))
                                        Sqlstring = " SELECT ISNULL(I.PROMITEMCODE,'') AS PROMITEMCODE,ISNULL(I.ITEMDESC,'') AS ITEMDESC,ISNULL(I.ITEMTYPECODE,'') AS ITEMTYPECODE,ISNULL(P.POSCODE,'') AS POSCODE,I.STARTINGDATE,I.ENDINGDATE,"
                                        Sqlstring = Sqlstring & " ISNULL(I.PROMUOM,'') AS PROMUOM,ISNULL(I.PROMQTY,0) AS PROMQTY,ISNULL(I.PROMRATE,0) AS PROMRATE,ISNULL(TL.TAXCODE,'') AS TAXCODE,ISNULL(TL.TAXPERCENTAGE,0) AS TAXPERCENTAGE,"
                                        Sqlstring = Sqlstring & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(P.SALESACCTIN,'') AS SALESACCTIN FROM ITEMMASTER AS I INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE"
                                        Sqlstring = Sqlstring & " INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN POSMASTER AS P ON PL.POS = P.POSCODE"
                                        Sqlstring = Sqlstring & " WHERE (I.PROMOTIONAL = 'Y') AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE  AND ISNULL(TL.ENDINGDATE,getdate()) AND (I.PROMITEMCODE = '" & Trim(Promtcode) & "') "
                                        Sqlstring = Sqlstring & " AND (I.ITEMCODE = '" & Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMCODE")) & "') AND ISNULL(I.FREEZE,'') <>'Y' ---AND POSCODE = '" & Trim(POScode) & "' "
                                        gconnection.getDataSet(Sqlstring, "PROMOTIONAL")
                                        If gdataset.Tables("PROMOTIONAL").Rows.Count > 0 Then
                                            MessageBox.Show("Promotional available for this ITEMCODE ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                                            If DialogResult.OK = 1 Then
                                                If DateValue(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ENDINGDATE")) <= DateValue(serverdate) And CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("STARTINGDATE")) >= DateValue(serverdate) Then
                                                    ssGrid.SetText(1, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMITEMCODE")))
                                                    ssGrid.SetText(2, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMDESC")))
                                                    ssGrid.SetText(3, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("POSCODE")))
                                                    ssGrid.SetText(4, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMUOM")))
                                                    ssGrid.SetText(5, i + 1, Val(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMQTY")))
                                                    ssGrid.SetText(6, i + 1, 0.0)
                                                    ssGrid.SetText(7, i + 1, 0.0)
                                                    ssGrid.SetText(8, i + 1, 0.0)
                                                    ssGrid.SetText(9, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMTYPECODE")))
                                                    ssGrid.SetText(10, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("TAXCODE")))
                                                    ssGrid.SetText(11, i + 1, Val(gdataset.Tables("PROMOTIONAL").Rows(j).Item("TAXPERCENTAGE")))
                                                    ssGrid.SetText(13, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ACCOUNTCODE")))
                                                    ssGrid.SetText(14, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("SALESACCTIN")))
                                                    ssGrid.SetText(15, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("GROUPCODE")))
                                                    ssGrid.SetActiveCell(5, i)
                                                    ssGrid.Focus()
                                                End If
                                            Else
                                                ssGrid.SetActiveCell(4, i)
                                                ssGrid.Focus()
                                            End If
                                        End If
                                    End If
                                    '''*************************** $ COMPLETE PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                    '''****************************** To FILL UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*************************************************'''
                                    ssGrid.Col = 1
                                    ssGrid.Row = ssGrid.ActiveRow
                                    Sqlstring = "SELECT ISNULL(R.UOM,'') AS UOM, ISNULL(R.ITEMRATE,0) AS ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                                    Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(ssGrid.Text) & "' ) ORDER BY R.UOM"
                                    gconnection.getDataSet(Sqlstring, "ITEMRATE")
                                    If gdataset.Tables("ITEMRATE").Rows.Count = 1 Then
                                        ssGrid.Col = 4
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = CStr(gdataset.Tables("ITEMRATE").Rows(0).Item("UOM"))
                                        ssGrid.Col = 6
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE"))
                                        ssGrid.Col = 19
                                        ssGrid.Row = ssGrid.ActiveRow
                                        If Trim(ssGrid.Text) = "Y" Then
                                            ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                                        Else
                                            ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                                        End If
                                    Else
                                        ssGrid.Col = 6
                                        ssGrid.Text = "0.00"
                                        ssGrid.Col = 4
                                        ssGrid.Col = 19
                                        ssGrid.Row = ssGrid.ActiveRow
                                        If Trim(ssGrid.Text) = "Y" Then
                                            ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                                        Else
                                            ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                        End If
                                    End If
                                    '''****************************** COMPLETE FILLING UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                                Else
                                    MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                    ssGrid.Lock = False
                                    ssGrid.Focus()
                                    Exit Sub
                                End If
                            End If
                        Else
                            ssGrid.Col = 19
                            ssGrid.Row = ssGrid.ActiveRow
                            If Trim(ssGrid.Text) = "Y" Then
                                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                                ssGrid.Focus()
                            End If
                        End If
                    End If
                End If
            ElseIf ssGrid.ActiveCol = 3 Then
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Col = 1
                varitemcode = Trim(ssGrid.Text)
                ssGrid.Col = 2
                varitemdesc = Trim(ssGrid.Text)
                ssGrid.Col = 3
                If Trim(varitemcode) = "" And Trim(varitemdesc) = "" Then
                    ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                    Exit Sub
                Else
                    ssGrid.Col = 1
                    varitemcode = Trim(ssGrid.Text)
                    ssGrid.Col = 3
                    varposcode = Trim(ssGrid.Text)
                    If Trim(varposcode) = "" Then
                        ssGrid.Text = ""
                        ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                        ssGrid.Focus()
                    ElseIf Trim(varposcode) <> "" Then
                        ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                    End If
                End If
            ElseIf ssGrid.ActiveCol = 4 Then
                ssGrid.Col = 4
                ssGrid.Row = ssGrid.ActiveRow
                If ssGrid.Lock = False Then
                    If Trim(ssGrid.Text) = "" Then
                        ssGrid.Col = 1
                        ssGrid.Row = ssGrid.ActiveRow
                        Itemcode = Trim(ssGrid.Text)
                        '''****************************** To FILL UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                        Sqlstring = "SELECT ISNULL(R.UOM,'') AS UOM, ISNULL(R.ITEMRATE,0) AS ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                        Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(Itemcode) & "' ) ORDER BY R.UOM"
                        gconnection.getDataSet(Sqlstring, "ITEMRATE")
                        If gdataset.Tables("ITEMRATE").Rows.Count = 1 Then
                            ssGrid.Col = 4
                            ssGrid.Row = ssGrid.ActiveRow
                            ssGrid.Text = CStr(gdataset.Tables("ITEMRATE").Rows(0).Item("UOM"))
                            ssGrid.Col = 19
                            ssGrid.Row = ssGrid.ActiveRow
                            If Trim(ssGrid.Text) = "Y" Then
                                ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                            Else
                                ssGrid.Col = 6
                                ssGrid.Row = ssGrid.ActiveRow
                                ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE"))
                                ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                            End If
                        ElseIf gdataset.Tables("ITEMRATE").Rows.Count > 1 Then
                            ssGrid.Col = 4
                            Call FillUomList(gdataset.Tables("ITEMRATE"))
                            Me.lvw_Uom.FullRowSelect = True
                            pnl_UOMCode.Top = 50
                            Me.lvw_Uom.Focus()
                        Else
                            ssGrid.Col = 1
                            ssGrid.Row = ssGrid.ActiveRow
                            If Trim(ssGrid.Text) <> "" Then
                                ssGrid.Col = 4
                                ssGrid.Text = ""
                                ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                            End If
                        End If
                        '''****************************** COMPLETE FILLING UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                    End If
                End If
            ElseIf ssGrid.ActiveCol = 5 Then
                ssGrid.Col = 5
                ssGrid.Row = ssGrid.ActiveRow
                If ssGrid.Lock = False Then
                    ssGrid.Col = 1
                    ssGrid.Row = ssGrid.ActiveRow
                    If Trim(ssGrid.Text) <> "" Then
                        ssGrid.Col = 5
                        ssGrid.Row = ssGrid.ActiveRow
                        If Val(ssGrid.Text) = 0 Then
                            ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                            Exit Sub
                        Else
                            ssGrid.Col = 19
                            ssGrid.Row = ssGrid.ActiveRow
                            If Trim(ssGrid.Text) = "Y" Then
                                ssGrid.Col = 6
                                ssGrid.Lock = False
                                ssGrid.SetActiveCell(6, ssGrid.ActiveRow)
                                Exit Sub
                            Else
                                Call Calculate()
                                ssGrid.Row = ssGrid.ActiveRow + 1
                                ssGrid.Col = 1
                                ssGrid.Lock = False
                                ssGrid.Col = 2
                                ssGrid.Lock = False
                                ssGrid.Col = 3
                                ssGrid.Lock = False
                                ssGrid.Col = 4
                                ssGrid.Lock = False
                                ssGrid.Col = 5
                                ssGrid.Lock = False
                                ssGrid.SetActiveCell(1, ssGrid.ActiveRow + 1)
                            End If
                        End If
                    End If
                End If
            ElseIf ssGrid.ActiveCol = 6 Then
                ssGrid.Col = 6
                ssGrid.Row = ssGrid.ActiveRow
                If ssGrid.Lock = False Then
                    ssGrid.Col = 1
                    ssGrid.Row = ssGrid.ActiveRow
                    If Trim(ssGrid.Text) <> "" Then
                        ssGrid.Col = 6
                        ssGrid.Row = ssGrid.ActiveRow
                        If Val(ssGrid.Text) = 0 Then
                            ssGrid.SetActiveCell(6, ssGrid.ActiveRow)
                            Exit Sub
                        Else
                            Call RateCalculate()
                            ssGrid.Row = ssGrid.ActiveRow + 1
                            ssGrid.Col = 1
                            ssGrid.Lock = False
                            ssGrid.Col = 2
                            ssGrid.Lock = False
                            ssGrid.Col = 3
                            ssGrid.Lock = False
                            ssGrid.Col = 4
                            ssGrid.Lock = False
                            ssGrid.Col = 5
                            ssGrid.Lock = False
                            ssGrid.SetActiveCell(1, ssGrid.ActiveRow + 1)
                        End If
                    End If
                End If
            ElseIf ssGrid.ActiveCol = 12 Then
                ssGrid.Col = 12
                ssGrid.Row = ssGrid.ActiveRow
                If Val(ssGrid.Text) = 0 Then
                    Call Calculate()
                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow + 1)
                    Exit Sub
                Else
                    Call Calculate()
                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow + 1)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub RateCalculate()
        Try
            Dim dblTotalamount, dblTaxamount, cancelamt, canceltax, Billamount As Double
            Dim dblCalqty, dblTaxperc, dblCalRate, dblPackPercent, dblPackAmount, Roundoff, Roundoff1, amount As Double
            Dim cancel, kotstatus, Round, Roundedvalue(), poscode As String
            Dim i As Integer
            If ssGrid.ActiveCol = 5 Or ssGrid.ActiveCol = 4 Or ssGrid.ActiveCol = 1 Or ssGrid.ActiveCol = 12 Then
                Me.txt_TaxValue.Text = "0.00"
                Me.txt_TotalValue.Text = "0.00"
                Me.txt_PackingCharge.Text = "0.00"
                Me.txt_BillAmount.Text = "0.00"
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Col = 12
                    ssGrid.Row = i
                    kotstatus = ssGrid.Text
                    If Val(kotstatus) = 0 Then
                        ssGrid.Col = 3
                        ssGrid.Row = i
                        poscode = ssGrid.Text
                        ssGrid.Col = 5
                        ssGrid.Row = i
                        dblCalqty = Val(ssGrid.Text)
                        ssGrid.Col = 6
                        ssGrid.Row = i
                        dblCalRate = Val(ssGrid.Text)
                        ssGrid.Col = 8
                        ssGrid.Row = i
                        amount = Val(ssGrid.Text)

                        ssGrid.Col = 11
                        ssGrid.Row = i
                        dblTaxperc = Val(ssGrid.Text)
                        ssGrid.Col = 17
                        ssGrid.Row = i
                        dblPackPercent = Val(ssGrid.Text)
                        dblTotalamount = Val(dblCalqty) * Val(dblCalRate)
                        dblTaxamount = (dblTotalamount * dblTaxperc) / 100
                        dblPackAmount = ((Val(dblTotalamount) + Val(dblTaxamount)) * dblPackPercent) / 100
                        dblPackAmount = 0
                        ssGrid.SetText(8, i, dblTotalamount)
                        ssGrid.SetText(7, i, dblTaxamount)
                        ssGrid.SetText(18, i, dblPackAmount)
                        Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(dblTotalamount), "0.00")
                        Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(dblTaxamount), "0.00")
                        Me.txt_PackingCharge.Text = Format(Val(Me.txt_PackingCharge.Text) + Val(dblPackAmount), "0.00")
                        Roundoff = Val(Me.txt_TotalValue.Text) + Val(Me.txt_TaxValue.Text) + Val(Me.txt_PackingCharge.Text)
                        Round = CStr(Roundoff)

                        If UCase(Trim(CMB_BTYPE.Text)) = "NIA" Or UCase(Trim(CMB_BTYPE.Text)) = "CKA" Or UCase(Trim(CMB_BTYPE.Text)) = "ACH" Then
                            Me.txt_PackingCharge.Text = Format(Val(Me.txt_PackingCharge.Text) + ((amount * 5) / 100), "0.00")
                        End If

                        If UCase(Trim(poscode)) = "ACH" Or UCase(Trim(poscode)) = "NCH" Then
                            Me.txt_PackingCharge.Text = Format(Val(Me.txt_PackingCharge.Text) + (((amount * 75 / 100) * 5.15) / 100), "0.00")
                        End If

                        Me.txt_BillAmount.Text = Format(Val(txt_TotalValue.Text) + Val(txt_TaxValue.Text) + Val(txt_PackingCharge.Text), "0.00")

                        Call bill_roundoff()

                        'If BILLROUNDYESNO = "YES" Then
                        '    If Round.IndexOf(".") <= 0 Then
                        '        Round = Round.Insert(Round.Length - 1, ".00")
                        '    End If
                        '    Roundedvalue = Split(Round, ".")
                        '    Roundoff1 = Mid(Format(Val(Roundoff), "0.00"), Len(Format(Val(Roundoff), "0.00")) - 1, Len(Format(Val(Roundoff), "0.00")))
                        '    If Format(Val(Roundoff1), "00") = 50 Then
                        '        Roundoff = Math.Ceiling(Roundoff)
                        '    ElseIf Format(Val(Roundoff1), "00") > 50 Then
                        '        Roundoff = Math.Ceiling(Roundoff)
                        '    Else
                        '        Roundoff = Math.Floor(Roundoff)
                        '    End If
                        '    Me.txt_BillAmount.Text = Format(Val(Roundoff), "0.00")
                        'Else
                        '    Roundoff1 = Mid(Format(Val(Roundoff), "0.00"), Len(Format(Val(Roundoff), "0.00")) - 1, Len(Format(Val(Roundoff), "0.00")))
                        '    Me.txt_BillAmount.Text = Format(Val(Roundoff), "0.00")
                        'End If
                    End If
                Next i
                i = i - 1
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Calculate()
        Try
            Dim dblTotalamount, dblTaxamount, cancelamt, canceltax, Billamount As Double
            Dim dblCalqty, dblTaxperc, dblCalRate, dblPackPercent, dblPackAmount, Roundoff, Roundoff1, amount As Double
            Dim cancel, kotstatus, Round, Roundedvalue(), poscode As String
            Dim i As Integer
            If ssGrid.ActiveCol = 5 Or ssGrid.ActiveCol = 4 Or ssGrid.ActiveCol = 1 Or ssGrid.ActiveCol = 12 Then
                Me.txt_TaxValue.Text = "0.00"
                Me.txt_TotalValue.Text = "0.00"
                Me.txt_PackingCharge.Text = "0.00"
                Me.txt_BillAmount.Text = "0.00"
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Col = 12
                    ssGrid.Row = i
                    kotstatus = ssGrid.Text
                    If Val(kotstatus) = 0 Then
                        ssGrid.Col = 3
                        ssGrid.Row = i
                        poscode = ssGrid.Text
                        ssGrid.Col = 5
                        ssGrid.Row = i
                        dblCalqty = Val(ssGrid.Text)
                        ssGrid.Col = 6
                        ssGrid.Row = i
                        dblCalRate = Val(ssGrid.Text)
                        ssGrid.Col = 8
                        ssGrid.Row = i
                        amount = Val(ssGrid.Text)

                        ssGrid.Col = 11
                        ssGrid.Row = i
                        dblTaxperc = Val(ssGrid.Text)
                        ssGrid.Col = 17
                        ssGrid.Row = i
                        dblPackPercent = Val(ssGrid.Text)
                        dblTotalamount = Val(dblCalqty) * Val(dblCalRate)
                        dblTaxamount = (dblTotalamount * dblTaxperc) / 100
                        dblPackAmount = ((Val(dblTotalamount) + Val(dblTaxamount)) * dblPackPercent) / 100
                        dblPackAmount = 0
                        ssGrid.SetText(8, i, dblTotalamount)
                        ssGrid.SetText(7, i, dblTaxamount)
                        ssGrid.SetText(18, i, dblPackAmount)
                        Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(dblTotalamount), "0.00")
                        Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(dblTaxamount), "0.00")
                        Me.txt_PackingCharge.Text = Format(Val(Me.txt_PackingCharge.Text) + Val(dblPackAmount), "0.00")
                        Roundoff = Val(Me.txt_TotalValue.Text) + Val(Me.txt_TaxValue.Text) + Val(Me.txt_PackingCharge.Text)
                        Round = CStr(Roundoff)


                        If UCase(Trim(CMB_BTYPE.Text)) = "NIA" Or UCase(Trim(CMB_BTYPE.Text)) = "CKA" Or UCase(Trim(CMB_BTYPE.Text)) = "ACH" Then
                            Me.txt_PackingCharge.Text = Format(Val(Me.txt_PackingCharge.Text) + ((amount * 5) / 100), "0.00")
                        End If

                        If UCase(Trim(poscode)) = "ACH" Or UCase(Trim(poscode)) = "NCH" Then
                            Me.txt_PackingCharge.Text = Format(Val(Me.txt_PackingCharge.Text) + (((amount * 75 / 100) * 5.15) / 100), "0.00")
                        End If

                        Me.txt_BillAmount.Text = Format(Val(txt_TotalValue.Text) + Val(txt_TaxValue.Text) + Val(txt_PackingCharge.Text), "0.00")

                        Call bill_roundoff()

                        'If BILLROUNDYESNO = "YES" Then
                        '    If Round.IndexOf(".") <= 0 Then
                        '        Round = Round.Insert(Round.Length - 1, ".00")
                        '    End If
                        '    Roundedvalue = Split(Round, ".")
                        '    Roundoff1 = Mid(Format(Val(Roundoff), "0.00"), Len(Format(Val(Roundoff), "0.00")) - 1, Len(Format(Val(Roundoff), "0.00")))
                        '    If Format(Val(Roundoff1), "00") = 50 Then
                        '        Roundoff = Math.Ceiling(Roundoff)
                        '    ElseIf Format(Val(Roundoff1), "00") > 50 Then
                        '        Roundoff = Math.Ceiling(Roundoff)
                        '    Else
                        '        Roundoff = Math.Floor(Roundoff)
                        '    End If
                        '    Me.txt_BillAmount.Text = Format(Val(Roundoff), "0.00")
                        'Else
                        '    Roundoff1 = Mid(Format(Val(Roundoff), "0.00"), Len(Format(Val(Roundoff), "0.00")) - 1, Len(Format(Val(Roundoff), "0.00")))
                        '    Me.txt_BillAmount.Text = Format(Val(Roundoff), "0.00")
                        'End If
                    End If
                Next i
                i = i - 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FillPosList(ByVal PosTable As DataTable)
        Dim lvw As New ListViewItem
        Dim i As Integer
        lvw_POSCode.Items.Clear()
        For i = 0 To PosTable.Rows.Count - 1
            lvw = lvw_POSCode.Items.Add(PosTable.Rows(i).Item(0))
            lvw.SubItems.Add(PosTable.Rows(i).Item(1))
        Next i
    End Sub
    Private Sub FillUomList(ByVal UomTable As DataTable)
        Dim lvw As New ListViewItem
        Dim i As Integer
        lvw_Uom.Items.Clear()
        For i = 0 To UomTable.Rows.Count - 1
            lvw = lvw_Uom.Items.Add(UomTable.Rows(i).Item("UOM"))
            lvw.SubItems.Add(UomTable.Rows(i).Item("ITEMRATE"))
        Next i
    End Sub
    Private Sub cbo_PaymentMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_PaymentMode.SelectedIndexChanged
        Dim sqlstring As String
        If cbo_PaymentMode.SelectedItem = "ROOM" Then
            txt_MemberCode.Visible = True
            txt_MemberName.Visible = True
            lbl_Membercode.Visible = True
            lbl_MemberName.Visible = True
            cmd_MemberCodeHelp.Visible = True
            txt_MemberCode.Text = ""
            txt_MemberName.Text = ""
            lbl_Membercode.Text = "ROOM NO"
            lbl_MemberName.Text = "GUEST NAME"
        Else
            Try
                sqlstring = " SELECT ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
                sqlstring = sqlstring & "WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
                If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                    If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) = "NO" Then
                        txt_MemberCode.Visible = False
                        txt_MemberName.Visible = False
                        lbl_Membercode.Visible = False
                        lbl_MemberName.Visible = False
                        lbl_SubPaymentMode.Visible = False
                        cbo_SubPaymentMode.Visible = False
                        '***************** CSC SMARTCARD
                        txt_MemberCode.ReadOnly = True
                        txt_MemberName.ReadOnly = True
                        'CSC SMARTCARD
                        'txt_MemberCode.Text = ""
                        'txt_MemberName.Text = ""
                        'cmd_MemberCodeHelp.Visible = False
                        cmd_MemberCodeHelp.Visible = False
                        txt_MemberCode.Text = MCODE_GBL
                        txt_MemberName.Text = MNAME_GBL
                        'txt_MemberCode.Text = ""
                        'txt_MemberName.Text = ""
                        cmd_MemberCodeHelp.Visible = False
                        '*****************smart card 
                    Else
                        txt_MemberCode.Visible = True
                        txt_MemberName.Visible = True
                        lbl_Membercode.Visible = True
                        lbl_MemberName.Visible = True
                        cmd_MemberCodeHelp.Visible = True
                        lbl_SubPaymentMode.Visible = False
                        cbo_SubPaymentMode.Visible = False
                        ' txt_MemberCode.Text = ""
                        ' txt_MemberName.Text = ""
                        lbl_Membercode.Text = "MEMBER CODE"
                        lbl_MemberName.Text = "MEMBER NAME"
                        'CSC SMARTCARD PAYMENT MODE UPDTE MCODE NOT CHANGED 
                        If Mid(CStr(Cmd_Add.Text), 1, 1) = "A" Then
                            '*****************'CSC SMARTCARD
                            If MCODE_GBL <> "" Then
                                txt_MemberCode.Text = MCODE_GBL
                                txt_MemberName.Text = MNAME_GBL
                            End If
                        End If
                        cmd_MemberCodeHelp.Visible = False
                        lbl_Membercode.Text = "MEMBER CODE"
                        lbl_MemberName.Text = "MEMBER NAME"
                        '*****************smart card 
                        'KARTHI JUNE 13

                        '                        If txt_card_id.Text <> "" And cbo_PaymentMode.Text = "SMART CARD" Then
                        If txt_card_id.Text <> "" Then
                            '  If cbo_PaymentMode.Text = "SMART CARD" Then
                            sqlstring = "SELECT * FROM SM_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
                            sqlstring = sqlstring & " UNION SELECT * FROM SM_AFF_TEMP_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
                            gconnection.getDataSet(sqlstring, "SM_MEM_LINKAGE")
                            'CHECKING IN GLOBAL FUNCTION (DD,MM,YYYY REMOVE AND CHECK IN txt_card_id)
                            Call CardIdValidate(Trim(txt_card_id.Text))
                            If gdataset.Tables("SM_MEM_LINKAGE").Rows.Count > 0 Then
                                CARDCODE = gdataset.Tables("SM_MEM_LINKAGE").Rows(0).Item("CARDCODE")
                            ElseIf Cardidcheck = True Then
                                CARDCODE = Trim(vCardcode)
                                vCardcode = ""
                            Else
                                MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                lbl_SwipeCard.Visible = False
                                txt_card_id.Clear()
                                'txt_card_id.Focus()
                                cbo_PaymentMode.Focus()
                                '                                lbl_SwipeCard.Focus()
                                Exit Sub
                            End If
                            '   End If

                            sqlstring = "SELECT isnull(MEMBERCODE,'') AS MEMBERCODE, ISNULL(MEMBERSUBCODE,'') AS  MEMBERSUBCODE, ISNULL(CARDCODE,'')AS CARDCODE, ISNULL(FANCYCODE,'')AS FANCYCODE,ISNULL(PASSWORD,'')AS PASSWORD, "
                            sqlstring = sqlstring & " ISNULL(ACTIVATION_FLAG,'')AS ACTIVATION_FLAG, ISNULL(ISSUETYPE,'')AS ISSUETYPE,ISNULL(VALID_FROM,'')AS VALID_FROM,ISNULL(VALID_TO,'')AS VALID_TO,ISNULL(NAME,'')AS NAME, ISNULL(CARDHOLDERNAME,'')AS CARDHOLDERNAME, ISNULL(AGE,0)AS AGE, ISNULL(DOB,'')AS DOB, ISNULL(TRANSACTION_TYPE,'')AS TRANSACTION_TYPE, ISNULL(AMOUNT,0)AS AMOUNT, ISNULL(BALANCE,0)AS BALANCE "
                            sqlstring = sqlstring & " FROM SM_CARDFILE_HDR WHERE CARDCODE='" & CARDCODE & "'"
                            gconnection.getDataSet(sqlstring, "SM_CARDFILE_HDR")
                            If gdataset.Tables("SM_CARDFILE_HDR").Rows.Count > 0 Then
                                If gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "MEM" Or gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TE" Then
                                    gconnection.getDataSet("SELECT MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(MCODE_GBL) & "'", "MEMBERMASTER")
                                    If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                                        MNAME_GBL = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MNAME")
                                        'Txt_Remarks.Text = "Current Card Balance : " & Trim(Format(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE"), "0.00"))
                                        txt_MemberName.Text = MNAME_GBL
                                    End If
                                ElseIf gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TA" Then
                                    lbl_Membercode.Text = "CLUB CODE"
                                    lbl_MemberName.Text = "CLUB NAME"
                                    gconnection.getDataSet("SELECT CLUBNAME FROM AFFILIATEDCLUBDETAILS WHERE CLUBCODE='" & Trim(MCODE_GBL) & "'", "AFFILIATEDCLUBDETAILS")
                                    If gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows.Count > 0 Then
                                        MNAME_GBL = gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CLUBNAME")
                                        txt_MemberName.Text = MNAME_GBL
                                    End If
                                End If
                            End If
                        End If
                        If cbo_PaymentMode.SelectedItem = "SMART CARD" Then
                            If txt_card_id.Text = "" Then
                                txt_card_id.Focus()
                                'LAB_CARDBAL.Visible = False
                                LBL_CARD_BALANCE.Visible = False
                            Else
                                'txt_card_id.Focus()
                                'LAB_CARDBAL.Visible = True
                                LBL_CARD_BALANCE.Visible = True
                                txt_MemberCode.Focus()
                            End If
                        Else
                            LAB_CARDBAL.Visible = False
                            LBL_CARD_BALANCE.Visible = False
                        End If

                    End If
                Else
                    MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
            Catch ex As Exception
                MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
        Call FillSubPaymentMode(Trim(Me.cbo_PaymentMode.Text))
    End Sub
    Private Sub FillMenu()
        Dim vform As New ListOperattion1
        Dim promitemcode As String
        Dim ssql As String
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMDESC,'') AS ITEMDESC,ISNULL(PL.POS,'') AS POS,ISNULL(I.ITEMTYPECODE,'') AS ITEMTYPECODE,ISNULL(TL.TAXCODE,'') AS TAXCODE,ISNULL(TL.TAXPERCENTAGE,0) AS TAXPERCENTAGE,"
        gSQLString = gSQLString & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.PROMITEMCODE,'') AS PROMITEMCODE,"
        gSQLString = gSQLString & " ISNULL(P.PACKINGPERCENT,0) AS PACKINGPERCENT, ISNULL(OPENFACILITY,'') AS OPENFACILITY,ISNULL(I.PROMOTIONAL,'') AS PROMOTIONAL ,ISNULL(P.PACKINGACCTIN,'') AS PACKINGACCTIN "
        gSQLString = gSQLString & " FROM ITEMMASTER AS I INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE INNER JOIN POSMENULINK AS PL ON PL.ITEMCODE = I.ITEMCODE INNER JOIN POSMASTER AS P ON PL.POS = P.POSCODE  AND ISNULL(I.FREEZE,'') <>'Y' "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(Search) & "%' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE  AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y'"
            'AND POSCODE = '" & Trim(POScode) & "'
        End If
        vform.Field = "I.ITEMCODE,I.ITEMDESC"
        vform.vFormatstring = "  ITEMCODE           |                 ITEMDESC                  |  POSCODE     |  ITEMTYPECODE  |  TAXCODE  | TAXPERCENTAGE | ACCOUNTCODE | SALESACCTIN |  GROUPCODE | PROMITEMCODE | PACKINGPERCENT "
        vform.vCaption = "ITEM CODE HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.Keypos3 = 3
        vform.keypos4 = 4
        vform.Keypos5 = 5
        vform.Keypos6 = 6
        vform.Keypos7 = 7
        vform.Keypos8 = 8
        vform.keypos9 = 9
        vform.Keypos10 = 10
        vform.Keypos11 = 11
        vform.Keypos12 = 12
        vform.Keypos13 = 13
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssGrid
                .Col = 1
                .Row = .ActiveRow
                .Text = vform.keyfield
                .Col = 2
                .Row = .ActiveRow
                .Text = vform.keyfield1
                .Col = 3
                .Row = .ActiveRow
                .Text = vform.keyfield2
                .Col = 9
                .Row = .ActiveRow
                .Text = vform.keyfield3
                .Col = 10
                .Row = .ActiveRow
                .Text = vform.keyfield4
                .Col = 11
                .Row = .ActiveRow
                .Text = vform.keyfield5
                .Col = 13
                .Row = .ActiveRow
                .Text = vform.keyfield6
                .Col = 14
                .Row = .ActiveRow
                .Text = vform.keyfield7
                .Col = 15
                .Row = .ActiveRow
                .Text = vform.keyfield8
                promitemcode = vform.keyfield9
                .Col = 17
                .Row = .ActiveRow
                .Text = vform.keyfield10
                .Col = 19
                .Row = .ActiveRow
                .Text = Trim(CStr(vform.keyfield11))
                .Col = 20
                .Row = .ActiveRow
                .Text = Trim(CStr(vform.keyfield12))
                .Col = 21
                .Row = .ActiveRow
                .Text = Trim(CStr(vform.keyfield13))
                If Trim(CStr(vform.keyfield11)) = "Y" Then
                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                Else
                    ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                End If
            End With
        Else
            ssGrid.SetActiveCell(0, ssGrid.ActiveRow)
            Exit Sub
        End If
        If Trim(vform.keyfield) <> "" Then
            '''************************************************* $ FILL UOM , RATE INTO SSGRID $ **************************************************'''
            gSQLString = "SELECT ISNULL(R.UOM,'') AS UOM, ISNULL(R.ITEMRATE,0) AS ITEMRATE "
            gSQLString = gSQLString & " FROM ITEMMASTER AS I INNER JOIN "
            gSQLString = gSQLString & " RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
            gSQLString = gSQLString & " WHERE(R.ENDINGDATE IS NULL) AND (I.ITEMCODE = '" & Trim(vform.keyfield) & "' ) ORDER BY R.UOM"
            gconnection.getDataSet(gSQLString, "ITEMRATE")
            If gdataset.Tables("ITEMRATE").Rows.Count > 1 Then
                Call FillUomList(gdataset.Tables("ITEMRATE"))
                If ssGrid.ActiveCol = 4 Then
                    '''***************************************** $ SHOW POPUP FOR VARIOUS UOM $ ******************************************************''
                    Me.lvw_Uom.FullRowSelect = True
                    pnl_UOMCode.Top = 50
                    Me.lvw_Uom.Focus()
                    '''***************************************** $ COMPLETE POPUP FOR VARIOUS UOM $ ******************************************************''
                End If
            Else
                ssGrid.Col = 4
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Text = gdataset.Tables("ITEMRATE").Rows(0).Item("UOM")
                ssGrid.Col = 6
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Text = gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE")
                If Trim(CStr(vform.keyfield11)) = "Y" Then
                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                Else
                    ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                End If
            End If
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub FillMenuItem()
        Dim vform As New ListOperattion1
        Dim promitemcode As String
        Dim ssql As String
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = "SELECT DISTINCT ISNULL(I.ITEMDESC,'') AS ITEMDESC,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.BASERATESTD,0) AS RATE,ISNULL(PL.POS,'') AS POS,ISNULL(I.ITEMTYPECODE,'') AS ITEMTYPECODE,ISNULL(TL.TAXCODE,'') AS TAXCODE,ISNULL(TL.TAXPERCENTAGE,0) AS TAXPERCENTAGE,"
        gSQLString = gSQLString & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.PROMITEMCODE,'') AS PROMITEMCODE,"
        gSQLString = gSQLString & " ISNULL(P.PACKINGPERCENT,0) AS PACKINGPERCENT, ISNULL(OPENFACILITY,'') AS OPENFACILITY,ISNULL(I.PROMOTIONAL,'') AS PROMOTIONAL ,ISNULL(P.PACKINGACCTIN,'') AS PACKINGACCTIN "
        gSQLString = gSQLString & " FROM ITEMMASTER AS I INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE INNER JOIN POSMENULINK AS PL ON PL.ITEMCODE = I.ITEMCODE INNER JOIN POSMASTER AS P ON PL.POS = P.POSCODE  AND ISNULL(I.FREEZE,'') <>'Y'"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE I.ITEMDESC LIKE '" & Trim(Search) & "%' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE  AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y' "
            'AND POSCODE = '" & Trim(POScode) & "'"
        End If
        vform.Field = "I.ITEMDESC,I.ITEMCODE"
        vform.vFormatstring = "                ITEMDESC                  |        ITEMCODE      |  RATE       |  POSCODE     |  ITEMTYPECODE  |  TAXCODE  | TAXPERCENTAGE | ACCOUNTCODE | SALESACCTIN |  GROUPCODE  | PROMITEMCODE | PACKINGPERCENT "
        vform.vCaption = "ITEM CODE HELP"
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 

        ''''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        'gSQLString = "SELECT DISTINCT ISNULL(I.ITEMDESC,'') AS ITEMDESC,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(PL.POS,'') AS POS,ISNULL(I.ITEMTYPECODE,'') AS ITEMTYPECODE,ISNULL(TL.TAXCODE,'') AS TAXCODE,ISNULL(TL.TAXPERCENTAGE,0) AS TAXPERCENTAGE,"
        'gSQLString = gSQLString & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(P.SALESACCTIN,'') AS SALESACCTIN,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.PROMITEMCODE,'') AS PROMITEMCODE,"
        'gSQLString = gSQLString & " ISNULL(P.PACKINGPERCENT,0) AS PACKINGPERCENT, ISNULL(OPENFACILITY,'') AS OPENFACILITY,ISNULL(I.PROMOTIONAL,'') AS PROMOTIONAL ,ISNULL(P.PACKINGACCTIN,'') AS PACKINGACCTIN "
        'gSQLString = gSQLString & " FROM ITEMMASTER AS I INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE INNER JOIN POSMENULINK AS PL ON PL.ITEMCODE = I.ITEMCODE INNER JOIN POSMASTER AS P ON PL.POS = P.POSCODE "
        'If Trim(Search) = " " Then
        '    M_WhereCondition = ""
        'Else
        '    M_WhereCondition = " WHERE I.ITEMDESC LIKE '" & Trim(Search) & "%' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE  AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y' AND POSCODE = '" & Trim(POScode) & "'"
        'End If
        'vform.Field = "I.ITEMDESC,I.ITEMCODE"
        'vform.vFormatstring = "                ITEMDESC                  |        ITEMCODE      |  POSCODE     |  ITEMTYPECODE  |  TAXCODE  | TAXPERCENTAGE | ACCOUNTCODE | SALESACCTIN |  GROUPCODE  | PROMITEMCODE | PACKINGPERCENT "
        'vform.vCaption = "ITEM CODE HELP"

        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 3
        vform.Keypos3 = 4
        vform.keypos4 = 5
        vform.Keypos5 = 6
        vform.Keypos6 = 7
        vform.Keypos7 = 8
        vform.Keypos8 = 9
        vform.keypos9 = 10
        vform.Keypos10 = 11
        vform.Keypos11 = 12
        vform.Keypos12 = 13
        vform.Keypos13 = 14
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssGrid
                .Col = 1
                .Row = .ActiveRow
                .Text = vform.keyfield1
                .Col = 2
                .Row = .ActiveRow
                .Text = vform.keyfield
                .Col = 3
                .Row = .ActiveRow
                .Text = vform.keyfield2
                .Col = 9
                .Row = .ActiveRow
                .Text = vform.keyfield3
                .Col = 10
                .Row = .ActiveRow
                .Text = vform.keyfield4
                .Col = 11
                .Row = .ActiveRow
                .Text = vform.keyfield5
                .Col = 13
                .Row = .ActiveRow
                .Text = vform.keyfield6
                .Col = 14
                .Row = .ActiveRow
                .Text = vform.keyfield7
                .Col = 15
                .Row = .ActiveRow
                .Text = vform.keyfield8
                promitemcode = vform.keyfield9
                .Col = 17
                .Row = .ActiveRow
                .Text = vform.keyfield10
                .Col = 19
                .Row = .ActiveRow
                .Text = vform.keyfield11
                .Col = 20
                .Row = .ActiveRow
                .Text = vform.keyfield12
                .Col = 21
                .Row = .ActiveRow
                .Text = vform.keyfield13
                If Trim(CStr(vform.keyfield11)) = "Y" Then
                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                Else
                    ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                End If
            End With
        Else
            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
            Exit Sub
        End If
        If Trim(vform.keyfield) <> "" Then
            '''************************************************* $ FILL UOM , RATE INTO SSGRID $ **************************************************'''
            gSQLString = "SELECT ISNULL(R.UOM,'') AS UOM, ISNULL(R.ITEMRATE,0) AS ITEMRATE "
            gSQLString = gSQLString & " FROM ITEMMASTER AS I INNER JOIN "
            gSQLString = gSQLString & " RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
            gSQLString = gSQLString & "WHERE (R.ENDINGDATE IS NULL) AND (I.ITEMCODE = '" & Trim(vform.keyfield1) & "' ) ORDER BY R.UOM"
            gconnection.getDataSet(gSQLString, "ITEMRATE")
            If gdataset.Tables("ITEMRATE").Rows.Count > 1 Then
                Call FillUomList(gdataset.Tables("ITEMRATE"))
                If ssGrid.ActiveCol = 4 Then
                    '''***************************************** $ SHOW POPUP FOR VARIOUS UOM $ ******************************************************''
                    Me.lvw_Uom.FullRowSelect = True
                    pnl_UOMCode.Top = 50
                    Me.lvw_Uom.Focus()
                    '''***************************************** $ COMPLETE POPUP FOR VARIOUS UOM $ ******************************************************''
                End If
            Else
                ssGrid.Col = 4
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Text = gdataset.Tables("ITEMRATE").Rows(0).Item("UOM")
                ssGrid.Col = 6
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Text = gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE")
                If Trim(CStr(vform.keyfield11)) = "Y" Then
                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                Else
                    ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                End If
            End If
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub cmd_Delete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub DeleteOperation()
        MessageBox.Show("Particular KOT's Can't be deleted", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
    End Sub
    Private Sub cmd_View1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Public Sub GNC_PRINT()
        Try
            Randomize()
            Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
            Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword, splmember, servicelocation, INSERT(0), SSQL As String
            Dim BillNo, sql, sqlstring, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno, SNAME, _BILLDETAILS As String
            Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage, CLBAL, txtpack As Double
            Dim ds As New DataSet
            Dim Otherbool, boolOtherBill As Boolean
            Dim Filewrite As StreamWriter
            Call creditstop(txt_MemberCode.Text)
            gCompanyname = MyCompanyName
            gCompanyAddress(0) = Address1
            gCompanyAddress(1) = Address2
            Gheader = "TAX  INVOICE"
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"

            SSQL = " update bill_hdr  set scode=b.scode "
            SSQL = SSQL & " from bill_hdr a,kot_det b where a.billdetails=b.billdetails and isnull(a.scode,'')=''"

            INSERT(0) = SSQL
            SSQL = " update bill_hdr  set sname=b.servername"
            SSQL = SSQL & " from bill_hdr a,servermaster b where a.scode=b.servercode and isnull(a.sname,'')=''"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = SSQL

            SSQL = " update kot_hdr set SLIPNO=KOTDETAILS"
            SSQL = SSQL & " Where isnull(SLIPNO,'')=''"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = SSQL

            gconnection.MoreTransold1(INSERT)

            sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_KOTno.Text)) & "'"
            gconnection.getDataSet(sql, "Bill_det")
            If gdataset.Tables("Bill_det").Rows.Count > 0 Then
                Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
                Otherbool = True
            Else
                Otherbool = False
            End If
            If Otherbool = True Then
                billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_KOTno.Text) & "'"
            Else
                billdetails = "'" & Trim(Me.txt_KOTno.Text) & "'"
            End If
            Call bill_roundoff()
            'Call outstanding()

            sql = " SELECT sum(ISNULL(BILL_HDR.ROUNDOFF,0))AS ROUNDOFF,SUM(ISNULL(BILL_HDR.TOTALAMOUNT,0)) AS TOTALAMOUNT,sum(ISNULL(BILL_HDR.SER_CHG,0)) AS SER_CHG,sum(ISNULL(D.PACKAMOUNT,0)) AS PACKAMOUNT,BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,isnull(D.SCODE,'') as scode,isnull(E.SERVERNAME,'') AS SNAME,ISNULL(PRINTFLAG,'') AS PRINTFLAG,ISNULL(BILL_HDR.DELFLAG,'') AS DELFLAG,"
            sql = sql & "D.BILLDETAILS,ITEMCODE,ITEMDESC,D.POSCODE,D.UOM,sum(D.QTY) as QTY,"
            sql = sql & "D.RATE,sum(AMOUNT) as amount,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(sum(D.TAXAMOUNT),0) as TAXAMOUNT,"
            sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,ISNULL(BILL_HDR.servicelocation,'') AS servicelocation,F.POSDESC,"
            sql = sql & " ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
            sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
            sql = sql & " INNER JOIN SERVERMASTER E  ON E.SERVERCODE=D.SCODE  "
            sql = sql & " INNER JOIN POSMASTER F  ON F.POSCODE=D.POSCODE  "
            sql = sql & " WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' "
            sql = sql & " group by F.POSDESC,BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,D.SCODE,E.SERVERNAME,PRINTFLAG,BILL_HDR.DELFLAG,"
            sql = sql & " D.BILLDETAILS,ITEMCODE,ITEMDESC,D.POSCODE,D.UOM,D.RATE,"
            sql = sql & " TAXTYPE,TAXPERC,TAXCODE,ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid,BILL_HDR.servicelocation,"
            sql = sql & "GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),''),ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'')"
            sql = sql & " --ORDER BY D.KOTDETAILS --D.BillDetails "
            gconnection.getDataSet(sql, "ReportTable")
            Dim adduserid As String
            adduserid = ""
            If gdataset.Tables("ReportTable").Rows.Count > 0 Then
                RoundOff = Format(gdataset.Tables("ReportTable").Rows(0).Item("ROUNDOFF"))
                Filewrite = File.AppendText(vFilepath)
                vline = ""
                BillNo = Trim(gdataset.Tables("ReportTable").Rows(0).Item("BillDetails"))
                taxpercentage = Val(gdataset.Tables("ReportTable").Rows(0).Item("TaxPerc"))
                Kot = ""
                ssgrid_settlement.SetActiveCell(1, 1)
                splmember = ""
                ssgrid_settlement.SetActiveCell(1, 1)
                TaxAmount = 0
                TotalAmount = 0
                Dim SETMCODE As String
                Dim SETAMOUNT As Double
                Dim vpagenumber, Vrowcount, innercount, taxcount As Long
                Dim headercount As Double
                Dim SSQLROOM, poscode As String
                innercount = 0
                Vrowcount = 0
                vpagenumber = 1
                SETMCODE = ""
                SETAMOUNT = 0
                ssgrid_settlement.Col = 1
                ssgrid_settlement.Row = J
                SETMCODE = (ssgrid_settlement.Text)
                ssgrid_settlement.Col = 2
                ssgrid_settlement.Row = J
                SETAMOUNT = Format(Val(ssgrid_settlement.Text), "0.00")
                poscode = Trim(gdataset.Tables("ReportTable").Rows(0).Item("poscode"))
                servicelocation = Trim(gdataset.Tables("ReportTable").Rows(0).Item("servicelocation"))
                adduserid = Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID"))
                SNAME = Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME"))
                CountItem = 0
                For i = 1 To 2
                    Filewrite.WriteLine("")
                Next
                Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) + "E" & Chr(14) & Chr(27) & Chr(71) & "" & Chr(20) & Chr(27) & Chr(72))
                Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) + "E" & Chr(14) & Chr(27) & Chr(71) & "" & Chr(20) & Chr(27) & Chr(72))
                Gheader = Space(6) & Chr(18) & Chr(27) + "E" & Mid(txt_ServerName.Text, 1, 35) & Space(35 - Len(Mid(txt_ServerName.Text, 1, 35))) & Chr(27) + "F"
                Filewrite.WriteLine(Gheader)
                If gdataset.Tables("ReportTable").Rows(0).Item("DELFLAG") = "Y" Then
                    Filewrite.WriteLine(Space(7) & Chr(27) + "E" & "D E L E T E D - V O U C H E R" & Chr(27) + "F")
                Else
                    If gdataset.Tables("ReportTable").Rows(0).Item("PRINTFLAG") = "Y" Then
                        Filewrite.WriteLine(Space(7) & Chr(27) + "E" & "D U P L I C A T E - V O U C H E R" & Chr(27) + "F")
                    Else
                        Filewrite.WriteLine("")
                    End If
                End If
                If Trim(cbo_PaymentMode.Text) = "CREDIT" Or Trim(cbo_PaymentMode.Text) = "PARTY" Then
                    'Filewrite.WriteLine(Chr(15) & Space(10) & Trim(cbo_PaymentMode.Text) & Space(10) & "* COPY *" & Space(10) & "OPl.Bal :" & Math.Abs(MemberOutstand - Val(txt_BillAmount.Text)) & IIf(MemberOutstand - Val(txt_BillAmount.Text) > 0, " Dr.", " Cr."))
                    'Filewrite.WriteLine(Chr(15) & Space(10) & Trim(cbo_PaymentMode.Text) & Space(10) & "* COPY *" & Space(10) & "OPl.Bal :" & Math.Abs(MemberOutstand - Val(gdataset.Tables("ReportTable").Rows(0).Item("TOTALAMOUNT"))) & IIf(MemberOutstand - Val(gdataset.Tables("ReportTable").Rows(0).Item("TOTALAMOUNT")) > 0, " Dr.", " Cr."))


                    Filewrite.WriteLine(Chr(15) & Space(10) & Trim(cbo_PaymentMode.Text) & Space(10) & "* COPY *" & Space(10) & "OPl.Bal :" & Math.Abs(MemberOutstand - (Val(gdataset.Tables("ReportTable").Rows(0).Item("TOTALAMOUNT") + RoundOff))) & IIf(MemberOutstand - (Val(gdataset.Tables("ReportTable").Rows(0).Item("TOTALAMOUNT") + RoundOff)) > 0, " Dr.", " Cr."))


                Else
                    Filewrite.WriteLine(Chr(15) & Space(10) & Trim(cbo_PaymentMode.Text) & Space(10) & "* COPY *" & Space(10) & "OPl.Bal :" & Math.Abs(MemberOutstand) & IIf(MemberOutstand > 0, " Dr.", " Cr."))
                End If
                For i = 1 To 1
                    '   Filewrite.WriteLine("")
                Next
                If Trim(gdataset.Tables("ReportTable").Rows(0).Item("PAYMENTMODE")) = "ROOM" Then
                    Rowprint = Chr(15) & Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 10) & Space(10 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 10))) & Space(24)
                    Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20)))
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("GUEST")), 1, 35) & Space(35 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 35))) & Space(10)
                    Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
                    Filewrite.WriteLine(Rowprint)
                ElseIf Trim(gdataset.Tables("ReportTable").Rows(0).Item("PAYMENTMODE")) = "CLUB" Then
                    HNAME = Split(cbo_SubPaymentMode.Text, "-")
                    Rowprint = Chr(15) & Space(10) & Mid(HNAME(0), 1, 10) & Space(10 - Len(Mid(HNAME(0), 1, 10))) & Space(20)
                    Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 24)))
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = Space(10) & Mid(Trim(HNAME(1)), 1, 35) & "(" & Mid(Trim(HNAME(1)), 1, 35)
                    Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
                    Filewrite.WriteLine(Rowprint)
                Else
                    Rowprint = Chr(15) & Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MCODE")), 1, 10) & Space(10 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MCODE")), 1, 10))) & Space(34)
                    Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20)))
                    Filewrite.WriteLine(Rowprint)

                    Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MNAME")), 1, 35) & Space(35 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MNAME")), 1, 35))) & Space(10)
                    Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
                    Filewrite.WriteLine(Rowprint)
                End If
                Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20))) & Space(25)
                Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BillTime"), "T") & ""), 1, 8) & Space(8 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BillTime"), "T") & ""), 1, 8)))
                Filewrite.WriteLine(Rowprint)
                Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME") & ""), 1, 20))) & Space(25)
                Rowprint = Rowprint & Mid(Trim(CMB_BTYPE.Text), 1, 3) & Space(3 - Len(Mid(Trim(CMB_BTYPE.Text), 1, 3)))
                Filewrite.WriteLine(Rowprint)
                '------------------------------------------------HEADING END----------------------------------------------------------------------------------
                Vrowcount = 10
                '------------------------------------------------TRANSACTION BEGIN----------------------------------------------------------------------------
                For i = 1 To 3
                    Filewrite.WriteLine("")
                Next
                Vrowcount = Vrowcount + 2 'NO OF ROWS
                TotalAmount = 0 : TaxAmount = 0 : txtpack = 0
                CountItem = 0
                Dim SNO As Integer
                SNO = 0
                For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                    CountItem = CountItem + 1
                    SNO = SNO + 1
                    With gdataset.Tables("ReportTable").Rows(rowj)
                        Filewrite.Write(Mid(Format(CountItem, "0") & ".", 1, 3) & Space(3 - Len(Mid(Format(CountItem, "0" & "."), 1, 3))))
                        Filewrite.Write(Space(1) & Mid(Trim(.Item("ITEMCODE") & ""), 1, 7) & Space(7 - Len(Mid(Trim(.Item("ITEMCODE") & ""), 1, 7))))
                        Filewrite.Write(Space(1) & Mid(Trim(.Item("ITEMDESC") & ""), 1, 21) & Space(21 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 21))))
                        Filewrite.Write(Space(1) & Space(5 - Len(Mid(Format(Val(.Item("QTY") & ""), "0.00"), 1, 5))) & Mid(Format(Val(.Item("QTY") & ""), "0.00"), 1, 5))
                        Filewrite.Write(Space(1) & Mid(Trim(.Item("UOM") & ""), 1, 10) & Space(10 - Len(Mid(Trim(.Item("UOM") & ""), 1, 10))))
                        Filewrite.Write(Space(1) & Space(7 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 7))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 7))
                        Filewrite.WriteLine(Space(9 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 9))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 9))
                        TotalAmount = TotalAmount + Val(.Item("Amount"))
                        TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                        Vrowcount = Vrowcount + 2 'NO OF ROWS
                        txtpack = txtpack + Val(.Item("packAmount"))

                    End With
                    If SNO >= 9 Then
                        Filewrite.WriteLine(Space(25) & "Continued....")
                        Filewrite.WriteLine(Space(15) & Mid(SNO, 1, 3))
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(Space(15) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID")), 1, 20))
                        For i = 1 To 7
                            Filewrite.WriteLine("")
                        Next
                        SNO = 0
                        '--------------HEADING BEGIN------------------------ 
                        ' Call HEADER()
                        Filewrite.WriteLine(Gheader)
                        Filewrite.WriteLine(Chr(15) & Space(10) & Trim(cbo_PaymentMode.Text) & Space(10) & "* COPY *" & Space(11) & "OPl.Bal :" & Format(MemberOutstand - Val(txt_BillAmount.Text), "0.00"))
                        If gdataset.Tables("ReportTable").Rows(0).Item("DELFLAG") = "Y" Then
                            Filewrite.WriteLine(Space(7) & Chr(27) + "E" & "D E L E T E D - V O U C H E R" & Chr(27) + "F")
                        Else
                            If gdataset.Tables("ReportTable").Rows(0).Item("PRINTFLAG") = "Y" Then
                                Filewrite.WriteLine(Space(7) & Chr(27) + "E" & "D U P L I C A T E - V O U C H E R" & Chr(27) + "F")
                            Else
                                Filewrite.WriteLine("")
                            End If
                        End If
                        For i = 1 To 1
                            '   Filewrite.WriteLine("")
                        Next
                        If Trim(gdataset.Tables("ReportTable").Rows(0).Item("PAYMENTMODE")) = "ROOM" Then
                            Rowprint = Chr(15) & Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 10) & Space(10 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 10))) & Space(24)
                            Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20)))
                            Filewrite.WriteLine(Rowprint)
                            Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("GUEST")), 1, 35) & Space(35 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 35))) & Space(10)
                            Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
                            Filewrite.WriteLine(Rowprint)
                        ElseIf Trim(gdataset.Tables("ReportTable").Rows(0).Item("PAYMENTMODE")) = "CLUB" Then
                            HNAME = Split(cbo_SubPaymentMode.Text, "-")
                            Rowprint = Chr(15) & Space(10) & Mid(HNAME(0), 1, 10) & Space(10 - Len(Mid(HNAME(0), 1, 10))) & Space(20)
                            Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 24)))
                            Filewrite.WriteLine(Rowprint)
                            Rowprint = Space(10) & Mid(Trim(HNAME(1)), 1, 35) & "(" & Mid(Trim(HNAME(1)), 1, 35)
                            Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
                            Filewrite.WriteLine(Rowprint)
                        Else
                            Rowprint = Chr(15) & Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MCODE")), 1, 10) & Space(10 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MCODE")), 1, 10))) & Space(34)
                            Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20)))
                            Filewrite.WriteLine(Rowprint)

                            Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MNAME")), 1, 35) & Space(35 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MNAME")), 1, 35))) & Space(10)
                            Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
                            Filewrite.WriteLine(Rowprint)
                        End If

                        Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20))) & Space(25)
                        Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BillTime"), "T") & ""), 1, 8) & Space(8 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BillTime"), "T") & ""), 1, 8)))
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME") & ""), 1, 20))) & Space(25)
                        Rowprint = Rowprint & Mid(Trim(CMB_BTYPE.Text), 1, 3) & Space(3 - Len(Mid(Trim(CMB_BTYPE.Text), 1, 3)))
                        Filewrite.WriteLine(Rowprint)
                        '------------------------------------------------HEADING END----------------------------------------------------------------------------------
                        Vrowcount = 10
                        '--------------HEADING END------------------------ 
                        For i = 1 To 3
                            Filewrite.WriteLine("")
                        Next
                    End If
                Next rowj
                TotalAmount = TotalAmount + txtpack
                TotalAmount = TotalAmount + Val(gdataset.Tables("ReportTable").Rows(0).Item("SER_CHG"))
                '---------TAX PRINT ----------------------
                sqlstring = "select isnull(sum(a.taxamount),0) as Taxamount,a.taxcode,b.itemtypedesc from kot_det a,"
                sqlstring = sqlstring & "itemtypemaster b where a.taxcode=b.taxcode and isnull(a.delflag,'')<>'Y' AND "
                sqlstring = sqlstring & " a.taxamount>0 AND a.billdetails='" & Trim(txt_KOTno.Text) & "'"
                sqlstring = sqlstring & "  group by a.taxcode,b.itemtypedesc"
                gconnection.getDataSet(sqlstring, "TaxDet")
                If gdataset.Tables("TaxDet").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("TaxDet").Rows.Count - 1
                        If SNO > 9 Then
                            Filewrite.WriteLine(Space(25) & "Continued....")
                            Filewrite.WriteLine(Space(15) & Mid(SNO, 1, 3))
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine(Space(15) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID")), 1, 20))
                            For J = 1 To 8
                                Filewrite.WriteLine("")
                            Next
                            SNO = 0
                            '--------------HEADING BEGIN---------------------- 
                            'Call HEADER()
                            Filewrite.WriteLine(Gheader)
                            Filewrite.WriteLine(Chr(15) & Space(10) & Trim(cbo_PaymentMode.Text) & Space(10) & "* COPY *" & Space(10) & "OPl.Bal :")
                            If gdataset.Tables("ReportTable").Rows(0).Item("DELFLAG") = "Y" Then
                                Filewrite.WriteLine(Space(7) & Chr(27) + "E" & "D E L E T E D - V O U C H E R" & Chr(27) + "F")
                            Else
                                If gdataset.Tables("ReportTable").Rows(0).Item("PRINTFLAG") = "Y" Then
                                    Filewrite.WriteLine(Space(7) & Chr(27) + "E" & "D U P L I C A T E - V O U C H E R" & Chr(27) + "F")
                                Else
                                    Filewrite.WriteLine("")
                                End If
                            End If

                            For J = 1 To 1
                                '   Filewrite.WriteLine("")
                            Next
                            If Trim(gdataset.Tables("ReportTable").Rows(0).Item("PAYMENTMODE")) = "ROOM" Then
                                Rowprint = Chr(15) & Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 10) & Space(10 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 10))) & Space(24)
                                Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20)))
                                Filewrite.WriteLine(Rowprint)
                                Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("GUEST")), 1, 35) & Space(35 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 35))) & Space(10)
                                Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
                                Filewrite.WriteLine(Rowprint)
                            ElseIf Trim(gdataset.Tables("ReportTable").Rows(0).Item("PAYMENTMODE")) = "CLUB" Then
                                HNAME = Split(cbo_SubPaymentMode.Text, "-")
                                Rowprint = Chr(15) & Space(10) & Mid(HNAME(0), 1, 10) & Space(10 - Len(Mid(HNAME(0), 1, 10))) & Space(20)
                                Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 24)))
                                Filewrite.WriteLine(Rowprint)
                                Rowprint = Space(10) & Mid(Trim(HNAME(1)), 1, 35) & "(" & Mid(Trim(HNAME(1)), 1, 35)
                                Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
                                Filewrite.WriteLine(Rowprint)
                            Else
                                Rowprint = Chr(15) & Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MCODE")), 1, 10) & Space(10 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MCODE")), 1, 10))) & Space(34)
                                Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20)))
                                Filewrite.WriteLine(Rowprint)

                                Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MNAME")), 1, 35) & Space(35 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MNAME")), 1, 35))) & Space(10)
                                Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
                                Filewrite.WriteLine(Rowprint)
                            End If

                            Rowprint = Space(55) '& Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20))) & Space(25)
                            Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BillTime"), "T") & ""), 1, 8) & Space(8 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BillTime"), "T") & ""), 1, 8)))
                            Filewrite.WriteLine(Rowprint)
                            Rowprint = Space(10) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME") & ""), 1, 20))) & Space(25)
                            Rowprint = Rowprint & Mid(Trim(CMB_BTYPE.Text), 1, 3) & Space(3 - Len(Mid(Trim(CMB_BTYPE.Text), 1, 3)))
                            Filewrite.WriteLine(Rowprint)
                            '------------------------------------------------HEADING END----------------------------------------------------------------------------------
                            For J = 1 To 3
                                Filewrite.WriteLine("")
                            Next
                            Vrowcount = 10
                            '--------------HEADING END------------------------ 
                        Else
                            SNO = SNO + 1
                        End If
                        Filewrite.Write(Space(43) & Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15) & Space(15 - Len(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15))))
                        Rowprint = Space(4) & Space(6 - Len(Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 6))) & Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 6)
                        Filewrite.WriteLine(Rowprint)
                    Next
                Else
                    i = 0
                End If
                If Val(txtpack) > 0 Then
                    Filewrite.WriteLine(Space(43) & "AC CHARGE        " & Space(8 - Len(Mid(Format(Val(txtpack), "0.00"), 1, 8))) & Mid(Format(Val(txtpack), "0.00"), 1, 8))
                    'SNO = SNO + 1
                End If

                If Val(gdataset.Tables("ReportTable").Rows(0).Item("SER_CHG")) > 0 Then
                    Filewrite.WriteLine(Space(43) & "OUT KITCHEN STAX    " & Space(5 - Len(Mid(Format(Val(Trim(gdataset.Tables("ReportTable").Rows(0).Item("SER_CHG"))), "0.00"), 1, 5))) & Mid(Format(Val(gdataset.Tables("ReportTable").Rows(0).Item("SER_CHG")), "0.00"), 1, 5))
                    'SNO = SNO + 1
                End If
                If SNO < 9 Then
                    For J = SNO To 9
                        Filewrite.WriteLine("")
                    Next
                End If
                'Filewrite.WriteLine(Space(15) & Space(3 - Len(Mid(SNO - i, 1, 3))) & Mid(SNO - i, 1, 3) & Space(44) & Format(Val((TaxAmount + TotalAmount + Amt)), "0.00"))
                Filewrite.WriteLine(Space(15) & Space(3 - Len(Mid(SNO - i, 1, 3))) & Chr(14) & Chr(15) & Mid(SNO - i, 1, 3) & Space(19) & Format(Val((TaxAmount + TotalAmount + RoundOff)), "0.00") & Chr(15))
                'Filewrite.WriteLine(Space(18) & Space(44) & Format(Val((TaxAmount + TotalAmount + RoundOff)), "0.00"))
                For J = 1 To 1
                    Filewrite.WriteLine("")
                Next
                Filewrite.WriteLine(Space(15) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID")), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID")), 1, 20))))
                '+ RoundOff
                If Trim(cbo_PaymentMode.Text) = "CREDIT" Then
                    Filewrite.Write(Space(15) & "Cls.Bal:" & Format(Math.Abs(Val((MemberOutstand + RoundOff))), "0.00") & IIf(MemberOutstand + RoundOff > 0, " Dr.", " Cr."))
                Else
                    Filewrite.Write(Space(15) & "Cls.Bal:" & Format(Math.Abs(Val((MemberOutstand))), "0.00") & IIf(MemberOutstand > 0, " Dr.", " Cr."))
                End If

                If Trim(cbo_PaymentMode.Text) = "SMART CARD" Then
                    sqlstring = "SELECT * FROM SM_CARDFILE_HDR WHERE CARDCODE='" & CARDCODE & "' "
                    sqlstring = sqlstring & " AND [16_DIGIT_CODE] = '" & Trim(txt_card_id.Text) & "' "
                    gconnection.getDataSet(sqlstring, "SM_CARDFILE_HDR")
                    If gdataset.Tables("SM_CARDFILE_HDR").Rows.Count > 0 Then
                        Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00")
                        Filewrite.WriteLine(Space(10) & "Smt.Card.Bal:" & Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00"))
                    End If
                Else
                    Filewrite.WriteLine()
                End If
                If Trim(Txt_Remarks.Text) <> "" Then
                    If Len(Trim(Txt_Remarks.Text)) < 65 Then
                        Filewrite.WriteLine("Guest.Name:" & Trim(Txt_Remarks.Text))
                        Vrowcount = Vrowcount + 1
                        taxcount = taxcount + 1
                    Else
                        Filewrite.WriteLine("Guest.Name:" & Mid(Trim(Txt_Remarks.Text), 1, 65))
                        Filewrite.WriteLine("          " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                        Vrowcount = Vrowcount + 2
                        taxcount = taxcount + 2
                    End If
                End If

                For i = 1 To 16
                    Filewrite.WriteLine("")
                Next
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    INSERT(0) = "UPDATE BILL_HDR SET PRINTFLAG='Y' WHERE BILLDETAILS='" & Trim(txt_KOTno.Text) & "'"
                    gconnection.MoreTransold1(INSERT)
                    PrintTextFile1(vFilepath)
                End If
            Else
                MessageBox.Show("Invalid BillNo or Bill is not Yet generated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub KEA_PRINT()
        Randomize()
        Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
        Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword, splmember, servicelocation As String
        Dim BillNo, sql, sqlstring, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno, SNAME As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage, CLBAL As Double
        Dim ds As New DataSet
        Dim Otherbool, boolOtherBill As Boolean
        Dim Filewrite As StreamWriter
        gCompanyname = MyCompanyName
        gCompanyAddress(0) = Address1
        gCompanyAddress(1) = Address2
        Gheader = "TAX  INVOICE"
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_KOTno.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
            Otherbool = True
        Else
            Otherbool = False
        End If
        If Otherbool = True Then
            billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_KOTno.Text) & "'"
        Else
            billdetails = "'" & Trim(Me.txt_KOTno.Text) & "'"
        End If
        Call bill_roundoff()
        '        Call outstanding()

        sql = " SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,D.SCODE,E.SERVERNAME AS SNAME,"
        sql = sql & "D.BILLDETAILS,ISNULL(D.KOTNO,'') AS KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,"
        sql = sql & "D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,"
        sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,ISNULL(BILL_HDR.servicelocation,'') AS servicelocation,"
        sql = sql & "ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
        sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
        sql = sql & " INNER JOIN SERVERMASTER E  ON E.SERVERCODE=D.SCODE  "
        sql = sql & " WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' "
        sql = sql & " ORDER BY D.KOTDETAILS --D.BillDetails "
        gconnection.getDataSet(sql, "ReportTable")
        Dim adduserid As String
        adduserid = ""
        If gdataset.Tables("ReportTable").Rows.Count > 0 Then
            Filewrite = File.AppendText(vFilepath)
            vline = ""
            BillNo = Trim(gdataset.Tables("ReportTable").Rows(0).Item("BillDetails"))
            taxpercentage = Val(gdataset.Tables("ReportTable").Rows(0).Item("TaxPerc"))
            Kot = ""
            ssgrid_settlement.SetActiveCell(1, 1)
            splmember = ""
            ssgrid_settlement.SetActiveCell(1, 1)
            TaxAmount = 0
            TotalAmount = 0
            Dim SETMCODE As String
            Dim SETAMOUNT As Double
            Dim vpagenumber, Vrowcount, innercount, taxcount As Long
            Dim headercount As Double
            Dim SSQLROOM, poscode As String
            innercount = 0
            Vrowcount = 0
            vpagenumber = 1
            SETMCODE = ""
            SETAMOUNT = 0
            ssgrid_settlement.Col = 1
            ssgrid_settlement.Row = J
            SETMCODE = (ssgrid_settlement.Text)
            ssgrid_settlement.Col = 2
            ssgrid_settlement.Row = J
            SETAMOUNT = Format(Val(ssgrid_settlement.Text), "0.00")
            poscode = Trim(gdataset.Tables("ReportTable").Rows(0).Item("poscode"))
            servicelocation = Trim(gdataset.Tables("ReportTable").Rows(0).Item("servicelocation"))
            adduserid = Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID"))
            SNAME = Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME"))
            CountItem = 0
            '---HEADERING
            'BEGIN
            For i = 1 To 2
                Filewrite.WriteLine("")
            Next
            Vrowcount = 2
            Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & "" & Chr(20) & Chr(27) & Chr(72))
            Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & gCompanyname & Chr(20) & Chr(27) & Chr(72))
            'Rowprint = gCompanyAddress(1)
            'Filewrite.WriteLine(Space(12) & Rowprint)
            Filewrite.WriteLine()
            Filewrite.WriteLine(Chr(18) & Chr(14) & Chr(15) & Space(12) & Trim(cbo_PaymentMode.Text) & "-BILL")
            'Filewrite.WriteLine()
            If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "ROOM" Then
                Rowprint = Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) & ":"
                Rowprint = Rowprint & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("ROOMNO") & "-")
                Rowprint = Rowprint & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("GUEST") & "")
            ElseIf Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "CLUB" Then
                Rowprint = Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) & ":"
                HNAME = Split(cbo_SubPaymentMode.Text, "-")
                Rowprint = Rowprint & Chr(14) & Chr(15) & Trim(HNAME(1)) & "(" & Trim(HNAME(0)) & ")"
            Else
                If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "CREDIT" Then
                    Rowprint = Chr(18) & Chr(14) & Chr(15) & "M.No :"
                Else
                    Rowprint = Chr(18) & Chr(14) & Chr(15) & "M.No:"
                    'Rowprint = Chr(18) & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) & ":"
                End If
                Rowprint = Rowprint & Space(1) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE"))
                Filewrite.WriteLine(Rowprint)
                Rowprint = "NAME:" & Space(1) & Chr(18) & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME"))
            End If

            Filewrite.WriteLine(Chr(18) & Chr(14) & Chr(15) & Rowprint & Chr(18) & Chr(14) & Chr(15))
            ''Filewrite.WriteLine("{0,-12}{1,-20}", Chr(14) & Chr(15) & "LOCATION :", gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & servicelocation & "'") & Space(10) & "OP.BAL:" & CStr(Format(Val(MemberOutstand), "0.00")))
            Filewrite.WriteLine("{0,-12}{1,-20}", Chr(14) & Chr(15) & "LOCATION :", gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & servicelocation & "'"))
            ' Filewrite.WriteLine("{0,-12}{1,-20}", Chr(14) & Chr(15) & "LOCATION :", gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & servicelocation & "'"))
            Filewrite.WriteLine()
            Filewrite.Write(Chr(18) & Chr(14) & Chr(15) & "B.NO:" & Trim(BillNo))
            Filewrite.Write(" DT:" & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy"))

            Filewrite.WriteLine(Chr(15) & "/" & Trim(Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "T")) & Chr(18))
            For i = 0 To 50
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Filewrite.WriteLine(Chr(18) & "SLNO KOTNO ITEM                 QTY RATE   AMOUNT")
            For i = 0 To 50
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            'HEADING END
            TotalAmount = 0 : TaxAmount = 0
            CountItem = 0
            For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                CountItem = CountItem + 1
                With gdataset.Tables("ReportTable").Rows(rowj)
                    Filewrite.Write(Chr(18) & Space(3 - Len(Mid(Format(CountItem, "0"), 1, 3))) & Mid(Format(CountItem, "0"), 1, 3))
                    Filewrite.Write(Space(1) & Mid(Trim(.Item("KOTNO") & ""), 1, 7) & Space(7 - Len(Mid(Trim(.Item("KOTNO") & ""), 1, 7))))
                    Filewrite.Write(Mid(Trim(.Item("ITEMDESC") & ""), 1, 20) & Space(20 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 20))))
                    Filewrite.Write(Space(1) & Space(3 - Len(Mid(Format(Val(.Item("QTY") & ""), "0"), 1, 3))) & Mid(Format(Val(.Item("QTY") & ""), "0"), 1, 3))
                    Filewrite.Write(Space(1) & Space(5 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 5))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 5))
                    Filewrite.WriteLine(Space(1) & Space(7 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 7))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 7))
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                End With
            Next rowj
            For i = 0 To 50
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine(Chr(18))
            Rowprint = "Total" & Chr(14) & Chr(15) & Space(30) & Space(8 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 8)
            Filewrite.WriteLine(Rowprint & Chr(18))
            sqlstring = "select isnull(sum(a.taxamount),0) as Taxamount,a.taxcode,b.itemtypedesc from kot_det a,"
            sqlstring = sqlstring & "itemtypemaster b where a.taxcode=b.taxcode and isnull(a.delflag,'')<>'Y' AND "
            sqlstring = sqlstring & " a.taxamount>0 AND a.billdetails='" & Trim(txt_KOTno.Text) & "'"
            sqlstring = sqlstring & "  group by a.taxcode,b.itemtypedesc"
            gconnection.getDataSet(sqlstring, "TaxDet")
            'TAX PRINT
            For i = 0 To gdataset.Tables("TaxDet").Rows.Count - 1
                Filewrite.Write(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15) & Space(21 - Len(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15))))
                Rowprint = Chr(14) & Chr(15) & Space(18) & Space(6 - Len(Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 6))) & Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 6)
                Filewrite.WriteLine(Rowprint & Chr(18))
            Next
            For i = 0 To 50
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine("")

            If i = 0 Then
                Rowprint = Chr(18) & "Net Amount"
            Else
                Rowprint = Chr(18) & Space(11)
            End If
            Rowprint = "Net Amount" & Space(15) & Space(27 - Len(Rowprint)) & Chr(14) & Chr(15) & Space(8 - Len(Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8)
            Filewrite.WriteLine(Rowprint)

            Rowprint = Chr(18) & "Round Off" & Space(31) & Chr(14) & Chr(15) & Space(8 - Len(Mid(Trim(Format(Amt, "0.00")), 1, 8))) & Mid(Trim(Format(Amt, "0.00")), 1, 8) & Chr(18)
            'If Amt <> 0 Then
            Filewrite.WriteLine(Rowprint)
            'End If
            'Filewrite.Write(Chr(45))
            'Filewrite.Write(Chr(18))

            For i = 0 To 50
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Rowprint = Mid(Chr(18) & "BILL AMOUNT :", 1, 21) & Space(25 - Len(Mid("BILL AMOUNT:", 1, 25))) & Space(17)
            If Amt < 0 Then
                Rowprint = Rowprint & Chr(14) & Chr(15) & Format(Val((TaxAmount + TotalAmount)) - Val(Amt * -1), "0.00")
            Else
                Rowprint = Rowprint & Chr(14) & Chr(15) & Format(Val((TaxAmount + TotalAmount)) + Val(Amt), "0.00")
            End If
            Filewrite.WriteLine(Rowprint)
            For i = 0 To 50
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Rowprint = Chr(15) & Chr(27) + "E" & RupeesToWord(Val(Format(TaxAmount + TotalAmount + Amt, "0.00"))) & Chr(27) + "F" & Chr(15)
            'Filewrite.WriteLine(UCase(Rowprint))
            If Trim(UCase(Rowprint)) <> "" Then
                If Len(Trim(UCase(Rowprint))) < 40 Then
                    Filewrite.WriteLine(Trim(Rowprint))
                Else
                    Filewrite.WriteLine(Mid(Trim(Trim(Rowprint)), 1, 40))
                    Filewrite.WriteLine(Mid(Trim(Trim(Rowprint)), 41, 40))
                End If
            End If

            taxcount = taxcount + 1
            Vrowcount = Vrowcount + 1
            Filewrite.Write(Chr(18))
            CLBAL = 0
            If UCase(Trim(cbo_PaymentMode.Text)) = "CREDIT" Then
                If Amt < 0 Then
                    CLBAL = MemberOutstand + (Val((TaxAmount + TotalAmount)) - Val(Amt * -1))
                Else
                    CLBAL = MemberOutstand + (Val((TaxAmount + TotalAmount)) + Val(Amt))
                End If
                '                Filewrite.WriteLine(Space(34) & Chr(18) & "CL.BAL :" & Chr(14) & Chr(15) & CStr(Format(Val(CLBAL), "0.00N")) & Chr(18))
            End If
            Dim sstring As String
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine(Chr(18) & "Members Sign                                 ")
            'Filewrite.WriteLine(Space(35) & Mid(Trim(LTrim(SNAME)), 1, 15) & Space(15 - Len(Mid(Trim(LTrim(SNAME)), 1, 15))))
            'Filewrite.WriteLine("Prepared By :" & Space(10 - Len(Mid(adduserid, 1, 10))) & Mid(Trim(adduserid), 1, 10))
            Filewrite.WriteLine("Prepared By :" & Trim(adduserid))
            Filewrite.WriteLine("")
            Filewrite.WriteLine("                 THANK YOU VISIT AGAIN")
            Filewrite.WriteLine("")
            If Trim(Txt_Remarks.Text) <> "" Then
                If Len(Trim(Txt_Remarks.Text)) < 65 Then
                    Filewrite.Write("             " & Trim(Txt_Remarks.Text))
                    Vrowcount = Vrowcount + 1
                    taxcount = taxcount + 1
                Else
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                    Filewrite.Write("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                    Vrowcount = Vrowcount + 2
                    taxcount = taxcount + 2
                End If
            Else
            End If
            For i = 0 To 11
                Filewrite.WriteLine("")
            Next
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(vFilepath)
            End If
        Else
            MessageBox.Show("Invalid BillNo or Bill is not Yet generated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
    End Sub

    Private Sub Cmd_Print1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cmd_Exit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub FillDefaultPayment()
        Dim Sqlstring As String
        'Sqlstring = "SELECT ISNULL(BillPaymentMode,'') AS BillPaymentMode FROM POSSETUP"
        'gconnection.getDataSet(Sqlstring, "POSSETUP")
        'If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
        '    DefaultPayment = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPaymentMode"))
        'Else
        '    DefaultPayment = "CREDIT"
        'End If
        '' Dim Sqlstring As String

        Sqlstring = "SELECT ISNULL(BillPaymentMode,'') AS BillPaymentMode, ISNULL(BILLROUNDOFF,'') AS BILLROUNDOFF,ISNULL(SETTLEMENT,'') AS SETTLEMENT FROM POSSETUP"
        gconnection.getDataSet(Sqlstring, "POSSETUP")
        If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
            DefaultPayment = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPaymentMode"))
            BILLROUNDYESNO = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BILLROUNDOFF"))
            BILLROUNDYESNO = "NO"
            SMENTTYPE = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("SETTLEMENT"))
        Else
            DefaultPayment = "CREDIT"
        End If
    End Sub
    Private Sub fillPayment_Mode()
        Dim sqlstring As String
        Dim index As Integer
        Dim i As Integer
        Try
            Call FillDefaultPayment()
            sqlstring = " SELECT PaymentCode FROM paymentmodemaster WHERE ISNULL(freeze,'')<>'Y'"
            cbo_PaymentMode.Items.Clear()
            gconnection.getDataSet(sqlstring, "paymentmodemaster")
            If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("paymentmodemaster").Rows.Count - 1
                    cbo_PaymentMode.Items.Add(gdataset.Tables("paymentmodemaster").Rows(i).Item("PaymentCode"))
                Next i
                index = cbo_PaymentMode.FindString(DefaultPayment)
                cbo_PaymentMode.SelectedIndex = index
                Call FillSubPaymentMode(DefaultPayment)
            Else
                MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_TableNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_TableNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_TableNo.Text) <> "" Then
                txt_TableNo_Validated(sender, e)
                txt_Cover.Focus()
            Else
                Call cmd_TablenoHelp_Click(cmd_TablenoHelp, e)
            End If
        End If
    End Sub

    Private Sub txt_Cover_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cover.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            cbo_PaymentMode.Focus()
        End If
    End Sub

    Private Sub txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        If cbo_PaymentMode.SelectedItem = "ROOM" Then
            getNumeric(e)
        End If
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_MemberCode.Text) <> "" Then
                txt_MemberCode_Validated(sender, e)
            Else
                Call cmd_MemberCodeHelp_Click(cmd_MemberCodeHelp, e)
            End If
        End If
    End Sub

    Private Sub txt_MemberName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_ServerCode.Focus()
        End If
    End Sub

    Private Sub txt_ServerCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ServerCode.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_ServerCode.Text) <> "" Then
                txt_ServerCode_Validated(sender, e)
            Else
                Call cmd_ServerCodeHelp_Click(cmd_ServerCodeHelp, e)
            End If
        End If
    End Sub

    Private Sub txt_ServerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ServerName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ssGrid.Focus()
            ssGrid.SetActiveCell(1, 1)
        End If
    End Sub

    Private Sub cbo_PaymentMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_PaymentMode.KeyPress
        Dim sqlstring As String
        If Asc(e.KeyChar) = 13 Then
            Try
                sqlstring = " SELECT ISNULL(SUBPAYSTATUS,'') AS SUBPAYSTATUS,ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
                sqlstring = sqlstring & "WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
                If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                    If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("SUBPAYSTATUS")) = "YES" Then
                        cbo_SubPaymentMode.Focus()
                    ElseIf Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) = "NO" Then
                        txt_ServerCode.Focus()
                    Else
                        txt_MemberCode.Focus()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub cmd_KOTnoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_KOTnoHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(KOTDETAILS,'') AS KOTDETAILS,ISNULL(MCODE,'') AS MCODE,ISNULL(SERVERCODE,'') AS SERVERCODE,ISNULL(SERVERNAME,'') AS SERVERNAME,ISNULL(MNAME,'') AS MNAME,Convert(varchar, KOTDATE,100) AS KOTDATE,ISNULL(REMARKS,'') AS REMARKS  FROM KOT_HDR "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = "WHERE DOCTYPE = '" & Trim(doctype) & "'"
        End If
        vform.Field = " KOTDETAILS,MCODE,SERVERCODE,KOTDATE "
        vform.vFormatstring = "            BILL NO            |  MCODE   | SERVER CODE |    SERVER NAME      |    MNAME           |      KOT DATE     |   REMARKS    | "
        vform.vCaption = "KOT DETAILS HELP"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_KOTno.Text = Trim(vform.keyfield & "")
            Call txt_KOTno_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_TotalValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_TotalValue.LostFocus
        txt_TotalValue.Text = Format(Val(txt_TotalValue.Text), "0.00")
    End Sub
    Private Sub txt_TaxValue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_TaxValue.LostFocus
        txt_TaxValue.Text = Format(Val(txt_TaxValue.Text), "0.00")
    End Sub
    Private Sub txt_BillAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BillAmount.LostFocus
        If BILLROUNDYESNO = "YES" Then
            txt_BillAmount.Text = Format(Math.Round(Val(txt_BillAmount.Text), 2), "0.00")
        Else
            txt_BillAmount.Text = Format(Val(txt_BillAmount.Text), "0.00")
        End If
    End Sub
    Private Sub txt_TableNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_TableNo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_TablenoHelp_Click(sender, e)
        End If
    End Sub
    Private Sub txt_KOTno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_KOTno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_KOTno.Text) = "" Then
                Call cmd_KOTnoHelp_Click(cmd_KOTnoHelp, e)
            Else
                Call txt_KOTno_Validated(sender, e)
                Me.cbo_PaymentMode.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_KOTdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_KOTdate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbo_PaymentMode.Focus()
        End If
    End Sub
    Private Sub txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberCode.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If txt_MemberCode.ReadOnly = False Then
                    If Me.cmd_MemberCodeHelp.Enabled = True Then
                        Search = Trim(txt_MemberCode.Text)
                        Call cmd_MemberCodeHelp_Click(sender, e)
                    End If
                End If
            ElseIf e.KeyCode = Keys.F12 Then
                If Trim(txt_MemberCode.Text) <> "" Then
                    txt_FacilityMemberCode.Text = Trim(txt_MemberCode.Text)
                    Call txt_FacilityMemberCode_Validated(sender, e)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt_ServerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ServerCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Me.cmd_ServerCodeHelp.Enabled = True Then
                Search = Trim(txt_ServerCode.Text)
                Call cmd_ServerCodeHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub KOTEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call cmd_BillSettlement_Click(cmd_BillSettlement, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            txt_KOTno.Text = ""
            txt_KOTno.Focus()
            Exit Sub
            'ElseIf e.KeyCode = Keys.F7 Then
            '    If Cmd_Add.Enabled = True Then
            '        Call Cmd_Add_Click(sender, e)
            '        Exit Sub
            '    End If
            'ElseIf e.KeyCode = Keys.F8 Then
            '    If cmd_Delete.Enabled = True Then
            '        Call cmd_Delete_Click(sender, e)
            '        Exit Sub
            '    End If
            'ElseIf e.KeyCode = Keys.F9 Then
            '    Call cmd_View_Click(sender, e)
            '    Exit Sub
            'ElseIf e.KeyCode = Keys.F10 Then
            '    Call Cmd_Print_Click(sender, e)
            '    Exit Sub
        ElseIf e.KeyCode = Keys.F12 Then
            ' If TYPE1 = "FACILITY" Then
            'CMD_FACILITY_Click(sender, e)
            '   FACILITY()
            '   Exit Sub
            ' End If

            'ElseIf e.KeyCode = Keys.F12 Then
            '    If SMENTTYPE = "YES" Then
            '        If ssGrid.DataRowCnt > 0 Then
            '            SETLEMENT_GROUP.Visible = True
            '            SpiltBill()
            '            SETLEMENT_GROUP.Top = 40
            '            SETLEMENT_GROUP.Left = 85
            '            ssgrid_settlement.SetActiveCell(1, 1)
            '            ssgrid_settlement.Focus()
            '        End If
            '    End If
            'ElseIf e.KeyCode = Keys.F12 Then
            '    Timer1.Start()
            '    'SMART CARD
            '    'CSC CMARTCARD

        ElseIf e.KeyCode = Keys.F8 Then
            If cmd_Delete.Enabled = True Then
                Call cmd_Delete_Click(cmd_Delete, e)
                Exit Sub
            End If

        ElseIf e.KeyCode = Keys.F7 Then
            If Cmd_Add.Enabled = True Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            End If

        ElseIf e.KeyCode = Keys.F9 Then
            If cmd_View.Enabled = True Then
                Call cmd_View_Click(cmd_View, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F10 Then
            If Cmd_Print.Enabled = True Then
                Call Cmd_Print_Click(sender, e)
                Exit Sub
            End If

        ElseIf e.KeyCode = Keys.F11 Then
            Call cmd_Exit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Then
            If pnl_POSCode.Top = 50 Then
                pnl_POSCode.Top = 1000
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                Exit Sub
            ElseIf pnl_UOMCode.Top = 50 Then
                pnl_UOMCode.Top = 1000
                ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                Exit Sub
            ElseIf grp_Carddetails.Top = 24 Then
                grp_Carddetails.Top = 1000
                ssgridPayment.SetActiveCell(3, gridRow)
                ssgridPayment.Focus()
            ElseIf grp_Chequedetails.Top = 24 Then
                grp_Chequedetails.Top = 1000
                ssgridPayment.SetActiveCell(3, gridRow)
                ssgridPayment.Focus()
            ElseIf grp_Paymentmodeselection.Top = 296 Then
                grp_Paymentmodeselection.Top = 1000
            ElseIf grp_Memberfacility.Top = 128 Then
                grp_Memberfacility.Top = 1000
                txt_MemberCode.Focus()
            Else
                Call cmd_Exit_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.Alt = True And e.KeyCode = Keys.K Then
            Me.Txt_Remarks.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.S Then
            Me.txt_ServerCode.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.B Then
            Me.txt_MemberCode.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.P Then
            Me.cbo_PaymentMode.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.C Then
            Me.txt_card_id.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.G Then
            Me.ssGrid.Focus()
            Me.ssGrid.SetActiveCell(1, 1)
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.D Then
            Me.dtp_KOTdate.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub autogenerate111111()
        Dim sqlstring, financalyear As String
        financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
        Try
            sqlstring = "SELECT MAX(Cast(SUBSTRING(KOTno,1,6) As Numeric)) FROM KOT_HDR  WHERE SUBSTRING(KOTDETAILS,1,3) ='" & Trim(BillPrefix) & "'"
            gconnection.openConnection()
            gcommand = New SqlCommand(sqlstring, gconnection.Myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_KOTno.Text = BillPrefix & "/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_KOTno.Text = BillPrefix & "/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_KOTno.Text = BillPrefix & "/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub
    Private Sub ssGrid_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssGrid.KeyDownEvent
        Dim Sqlstring, Itemcode, Itemdesc, Promtcode As String
        Dim varitemcode, varitemdesc, varposcode, varuom As String
        Dim i, j, K As Integer
        Dim varitemrate As Double
        Try
            If e.keyCode = Keys.Enter Then
                i = ssGrid.ActiveRow
                If ssGrid.ActiveCol = 1 Then
                    ssGrid.Row = i
                    ssGrid.Col = 2
                    varitemdesc = Trim(ssGrid.Text)
                    ssGrid.Col = 3
                    varposcode = Trim(ssGrid.Text)
                    ssGrid.Col = 1
                    If ssGrid.Lock = False Then
                        If Trim(ssGrid.Text) = "" Then
                            Call FillMenu() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                            'Call FillMenuItem() ''' IT WILL SHOW A POPUP MENU FOR ITEM DESC
                        ElseIf Trim(ssGrid.Text) <> "" Then
                            If Trim(varitemdesc) = "" And Trim(varposcode) = "" Then
                                Itemcode = Trim(ssGrid.Text)
                                ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                                Sqlstring = "SELECT DISTINCT ISNULL(I.ITEMDESC,'') AS ITEMDESC,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMTYPECODE,'') AS ITEMTYPECODE,ISNULL(PL.POS,'') AS POS,ISNULL(TL.TAXCODE,'') AS TAXCODE,ISNULL(TL.TAXPERCENTAGE,0) AS TAXPERCENTAGE,"
                                Sqlstring = Sqlstring & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.PROMOTIONAL,'') AS PROMOTIONAL ,ISNULL(I.PROMITEMCODE,'') AS PROMITEMCODE,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN,"
                                Sqlstring = Sqlstring & " ISNULL(P.PACKINGPERCENT,0) AS PACKINGPERCENT, ISNULL(OPENFACILITY,'') AS OPENFACILITY,ISNULL(P.PACKINGACCTIN,'') AS PACKINGACCTIN "
                                Sqlstring = Sqlstring & " FROM ITEMMASTER AS I INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "
                                Sqlstring = Sqlstring & " INNER JOIN POSMENULINK AS PL ON PL.ITEMCODE = I.ITEMCODE INNER JOIN POSMASTER AS P ON PL.POS = P.POSCODE "
                                Sqlstring = Sqlstring & " WHERE I.ITEMCODE = '" & Trim(Itemcode) & "' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE  AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y' --AND POSCODE = '" & Trim(POScode) & "' "
                                gconnection.getDataSet(Sqlstring, "ITEMCODE")
                                If gdataset.Tables("ITEMCODE").Rows.Count > 0 Then
                                    ssGrid.SetText(1, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMCODE")))
                                    ssGrid.SetText(2, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMDESC")))
                                    ssGrid.SetText(3, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("POS")))
                                    ssGrid.SetText(9, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMTYPECODE")))
                                    ssGrid.SetText(10, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXCODE")))
                                    ssGrid.SetText(11, i, Val(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXPERCENTAGE")))
                                    ssGrid.SetText(13, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ACCOUNTCODE")))
                                    ssGrid.SetText(14, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("SALESACCTIN")))
                                    ssGrid.SetText(15, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("GROUPCODE")))
                                    ssGrid.SetText(17, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PACKINGPERCENT")))
                                    ssGrid.SetText(19, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")))
                                    ssGrid.SetText(20, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PROMOTIONAL")))
                                    ssGrid.SetText(21, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PACKINGACCTIN")))
                                    If Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")) = "Y" Then
                                        ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                    Else
                                        ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                                    End If
                                    '''****************************** To FILL UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                                    Sqlstring = "SELECT ISNULL(R.UOM,'') AS UOM, ISNULL(R.ITEMRATE,0) AS ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                                    Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(Itemcode) & "' ) ORDER BY R.UOM"
                                    gconnection.getDataSet(Sqlstring, "ITEMRATE")
                                    If gdataset.Tables("ITEMRATE").Rows.Count = 1 Then
                                        ssGrid.Col = 4
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = CStr(gdataset.Tables("ITEMRATE").Rows(0).Item("UOM"))
                                        ssGrid.Col = 6
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE"))
                                        ssGrid.Col = 19
                                        ssGrid.Row = ssGrid.ActiveRow
                                        If Trim(ssGrid.Text) = "Y" Then
                                            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                        Else
                                            ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                        End If
                                    Else
                                        ssGrid.Col = 6
                                        ssGrid.Text = "0.00"
                                        ssGrid.Col = 4
                                        ssGrid.Col = 19
                                        ssGrid.Row = ssGrid.ActiveRow
                                        If Trim(ssGrid.Text) = "Y" Then
                                            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                        Else
                                            ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                                        End If
                                    End If
                                    '''****************************** COMPLETE FILLING UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                                Else
                                    MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                    ssGrid.SetActiveCell(0, ssGrid.ActiveRow)
                                    ssGrid.Lock = False
                                    ssGrid.Focus()
                                    Exit Sub
                                End If
                            End If
                        End If
                    End If
                ElseIf ssGrid.ActiveCol = 2 Then
                    ssGrid.Row = i
                    ssGrid.Col = 3
                    varposcode = Trim(ssGrid.Text)
                    ssGrid.Col = 1
                    ssGrid.Col = 2
                    ssGrid.Row = ssGrid.ActiveRow
                    If ssGrid.Lock = False Then
                        If Trim(ssGrid.Text) = "" Then
                            Call FillMenuItem() ''' IT WILL SHOW A POPUP MENU FOR ITEM DESC
                        Else
                            If Trim(varposcode) = "" Then
                                Itemdesc = Trim(ssGrid.Text)
                                ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                Itemcode = Trim(ssGrid.Text)
                                ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                                Sqlstring = "SELECT DISTINCT ISNULL(I.ITEMDESC,'') AS ITEMDESC,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMTYPECODE,'') AS ITEMTYPECODE,ISNULL(PL.POS,'') AS POS,ISNULL(TL.TAXCODE,'') AS TAXCODE,ISNULL(TL.TAXPERCENTAGE,0) AS TAXPERCENTAGE,"
                                Sqlstring = Sqlstring & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.PROMOTIONAL,'') AS PROMOTIONAL ,ISNULL(I.PROMITEMCODE,'') AS PROMITEMCODE,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN,"
                                Sqlstring = Sqlstring & " ISNULL(P.PACKINGPERCENT,0) AS PACKINGPERCENT, ISNULL(OPENFACILITY,'') AS OPENFACILITY,ISNULL(P.PACKINGACCTIN,'') AS PACKINGACCTIN "
                                Sqlstring = Sqlstring & " FROM ITEMMASTER AS I INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "
                                Sqlstring = Sqlstring & " INNER JOIN POSMENULINK AS PL ON PL.ITEMCODE = I.ITEMCODE INNER JOIN POSMASTER AS P ON PL.POS = P.POSCODE "
                                Sqlstring = Sqlstring & " WHERE I.ITEMDESC = '" & Trim(Itemdesc) & "' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE  AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y' --AND POSCODE = '" & Trim(POScode) & "' "
                                gconnection.getDataSet(Sqlstring, "ITEMCODE")
                                If gdataset.Tables("ITEMCODE").Rows.Count > 0 Then
                                    ssGrid.SetText(1, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMCODE")))
                                    ssGrid.SetText(2, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMDESC")))
                                    ssGrid.SetText(3, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("POS")))
                                    ssGrid.SetText(9, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMTYPECODE")))
                                    ssGrid.SetText(10, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXCODE")))
                                    ssGrid.SetText(11, i, Val(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXPERCENTAGE")))
                                    ssGrid.SetText(13, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ACCOUNTCODE")))
                                    ssGrid.SetText(14, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("SALESACCTIN")))
                                    ssGrid.SetText(15, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("GROUPCODE")))
                                    ssGrid.SetText(17, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PACKINGPERCENT")))
                                    ssGrid.SetText(19, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")))
                                    ssGrid.SetText(20, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PROMOTIONAL")))
                                    ssGrid.SetText(21, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PACKINGACCTIN")))
                                    If Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")) = "Y" Then
                                        ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                    Else
                                        ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                                    End If
                                    '''****************************** To FILL UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                                    Sqlstring = "SELECT ISNULL(R.UOM,'') AS UOM, ISNULL(R.ITEMRATE,0) AS ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                                    Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMCODE")) & "' ) ORDER BY R.UOM"
                                    gconnection.getDataSet(Sqlstring, "ITEMRATE")
                                    If gdataset.Tables("ITEMRATE").Rows.Count = 1 Then
                                        ssGrid.Col = 4
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = CStr(gdataset.Tables("ITEMRATE").Rows(0).Item("UOM"))
                                        ssGrid.Col = 6
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE"))
                                        ssGrid.Col = 19
                                        ssGrid.Row = ssGrid.ActiveRow
                                        If Trim(ssGrid.Text) = "Y" Then
                                            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                        Else
                                            ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                        End If
                                    Else
                                        ssGrid.Col = 6
                                        ssGrid.Text = "0.00"
                                        ssGrid.Col = 4
                                        ssGrid.Col = 19
                                        ssGrid.Row = ssGrid.ActiveRow
                                        If Trim(ssGrid.Text) = "Y" Then
                                            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                        Else
                                            ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                                        End If
                                    End If
                                    '''****************************** COMPLETE FILLING UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                                Else
                                    MessageBox.Show("Specified ITEM DESC not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                    ssGrid.Lock = False
                                    ssGrid.Focus()
                                    Exit Sub
                                End If
                            Else
                                ssGrid.Col = 19
                                ssGrid.Row = ssGrid.ActiveRow
                                If Trim(ssGrid.Text) = "Y" Then
                                    ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                    ssGrid.Focus()
                                End If
                            End If
                        End If
                    End If
                ElseIf ssGrid.ActiveCol = 3 Then
                    ssGrid.Row = ssGrid.ActiveRow
                    ssGrid.Row = ssGrid.ActiveRow
                    ssGrid.Col = 1
                    varitemcode = Trim(ssGrid.Text)
                    ssGrid.Col = 2
                    varitemdesc = Trim(ssGrid.Text)
                    ssGrid.Col = 3
                    If Trim(varitemcode) = "" And Trim(varitemdesc) = "" Then
                        ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                        Exit Sub
                    Else
                        ssGrid.Col = 1
                        varitemcode = Trim(ssGrid.Text)
                        ssGrid.Col = 3
                        varposcode = Trim(ssGrid.Text)
                        If Trim(varposcode) = "" Then
                            ssGrid.Text = ""
                            ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                            ssGrid.Focus()
                        ElseIf Trim(varposcode) <> "" Then
                            ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                        End If
                    End If
                ElseIf ssGrid.ActiveCol = 4 Then
                    ssGrid.Row = ssGrid.ActiveRow
                    ssGrid.Row = ssGrid.ActiveRow
                    ssGrid.Col = 1
                    varitemcode = Trim(ssGrid.Text)
                    ssGrid.Col = 2
                    varitemdesc = Trim(ssGrid.Text)
                    ssGrid.Col = 3
                    varposcode = Trim(ssGrid.Text)
                    ssGrid.Col = 4
                    If Trim(varitemcode) = "" And Trim(varitemdesc) = "" And Trim(varposcode) = "" Then
                        ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                        Exit Sub
                    Else
                        If ssGrid.Lock = False Then
                            ssGrid.Col = 1
                            varitemcode = Trim(ssGrid.Text)
                            ssGrid.Col = 3
                            varposcode = Trim(ssGrid.Text)
                            ssGrid.Col = 6
                            varitemrate = Val(ssGrid.Text)
                            ssGrid.Col = 4
                            If Trim(ssGrid.Text) = "" Then
                                '''****************************** To FILL UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                                Sqlstring = "SELECT ISNULL(R.UOM,'') AS UOM, ISNULL(R.ITEMRATE,0) AS ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                                Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(varitemcode) & "' ) ORDER BY R.UOM"
                                gconnection.getDataSet(Sqlstring, "ITEMRATE")
                                If gdataset.Tables("ITEMRATE").Rows.Count = 1 Then
                                    ssGrid.Col = 4
                                    ssGrid.Row = ssGrid.ActiveRow
                                    ssGrid.Text = CStr(gdataset.Tables("ITEMRATE").Rows(0).Item("UOM"))
                                    ssGrid.Col = 19
                                    ssGrid.Row = ssGrid.ActiveRow
                                    If Trim(ssGrid.Text) = "Y" Then
                                        ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                    Else
                                        ssGrid.Col = 6
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE"))
                                        ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                    End If
                                ElseIf gdataset.Tables("ITEMRATE").Rows.Count > 1 Then
                                    ssGrid.Col = 4
                                    Call FillUomList(gdataset.Tables("ITEMRATE"))
                                    Me.lvw_Uom.FullRowSelect = True
                                    pnl_UOMCode.Top = 50
                                    Me.lvw_Uom.Focus()
                                Else
                                    ssGrid.Col = 1
                                    ssGrid.Row = ssGrid.ActiveRow
                                    If Trim(ssGrid.Text) <> "" Then
                                        ssGrid.Col = 4
                                        ssGrid.Text = ""
                                        ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                    End If
                                End If
                                '''****************************** COMPLETE FILLING UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                            ElseIf Trim(ssGrid.Text) <> "" Then
                                Sqlstring = "SELECT ISNULL(R.UOM,'') AS UOM, ISNULL(R.ITEMRATE,0) AS ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                                Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(varitemcode) & "' ) AND R.ITEMRATE = " & Val(varitemrate) & " ORDER BY R.UOM"
                                gconnection.getDataSet(Sqlstring, "RATEMASTER")
                                If gdataset.Tables("RATEMASTER").Rows.Count > 0 Then
                                    If gdataset.Tables("RATEMASTER").Rows.Count = 1 Then
                                        ssGrid.Col = 4
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = CStr(gdataset.Tables("RATEMASTER").Rows(0).Item("UOM"))
                                        ssGrid.Col = 19
                                        ssGrid.Row = ssGrid.ActiveRow
                                        If Trim(ssGrid.Text) = "Y" Then
                                            ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                        Else
                                            ssGrid.Col = 6
                                            ssGrid.Row = ssGrid.ActiveRow
                                            ssGrid.Text = Val(gdataset.Tables("RATEMASTER").Rows(0).Item("ITEMRATE"))
                                            ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                        End If
                                    Else
                                        ssGrid.Col = 4
                                        ssGrid.Col = 6
                                        ssGrid.Text = "0.00"
                                    End If
                                Else
                                    MessageBox.Show("!! Oop's specified ITEM UOM is not valid ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    ssGrid.Col = 4
                                    ssGrid.Row = ssGrid.ActiveRow
                                    ssGrid.Text = ""
                                    ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                                End If
                            End If
                        End If
                    End If
                ElseIf ssGrid.ActiveCol = 5 Then
                    ssGrid.Row = ssGrid.ActiveRow
                    ssGrid.Col = 1
                    varitemcode = Trim(ssGrid.Text)
                    ssGrid.Col = 2
                    varitemdesc = Trim(ssGrid.Text)
                    ssGrid.Col = 3
                    varposcode = Trim(ssGrid.Text)
                    ssGrid.Col = 5
                    If Trim(varitemcode) = "" And Trim(varitemdesc) = "" And Trim(varposcode) = "" Then
                        ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                        Exit Sub
                    Else
                        If ssGrid.Lock = False Then
                            ssGrid.Col = 1
                            ssGrid.Row = ssGrid.ActiveRow
                            If Trim(ssGrid.Text) <> "" Then
                                ssGrid.Col = 5
                                ssGrid.Row = ssGrid.ActiveRow
                                If Val(ssGrid.Text) = 0 Then
                                    ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                    Exit Sub
                                Else
                                    ssGrid.Col = 19
                                    ssGrid.Row = ssGrid.ActiveRow
                                    If Trim(ssGrid.Text) = "Y" Then
                                        ssGrid.Col = 6
                                        ssGrid.Lock = False
                                        ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                                        Exit Sub
                                    Else
                                        '''REFERINVENTORY****************************CHECKING FOR THE STOCK AVAILABILITY*******************
                                        Dim CHECK_AVAILABILITY As Integer
                                        CHECK_AVAILABILITY = STOCKAVAILABILITY(ssGrid, i)
                                        If CHECK_AVAILABILITY = 0 Then
                                            ssGrid.ClearRange(1, i, ssGrid.MaxCols, i, True)
                                            ssGrid.Focus()
                                            ssGrid.SetActiveCell(0, i)
                                            Exit Sub
                                        ElseIf CHECK_AVAILABILITY = 1 Then
                                            ssGrid.Col = 4
                                            ssGrid.Text = ""
                                            ssGrid.SetActiveCell(4, i)
                                            ssGrid.Focus()
                                            Exit Sub
                                        End If
                                        '''************************************************************************************************
                                        Call Calculate()
                                        ssGrid.Col = 20
                                        ssGrid.Row = ssGrid.ActiveRow
                                        If Trim(ssGrid.Text) = "Y" Then
                                            '''*************************** $ PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                            Promtcode = Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PROMITEMCODE"))
                                            Sqlstring = " SELECT ISNULL(I.PROMOTIONAL,'') AS PROMOTIONAL,ISNULL(I.PROMITEMCODE,'') AS PROMITEMCODE,ISNULL(I.PROMUOM,'') AS PROMUOM,"
                                            Sqlstring = Sqlstring & " ISNULL(I.PROMQTY,0) AS PROMQTY,ISNULL(I.PROMRATE,0) AS PROMRATE FROM ITEMMASTER AS I WHERE I.ITEMCODE= '" & Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMCODE")) & "'AND ISNULL(I.FREEZE,'') <>'Y' "
                                            gconnection.getDataSet(Sqlstring, "ITEMMASTER")
                                            If gdataset.Tables("ITEMMASTER").Rows.Count > 0 Then
                                                Promtcode = Trim(gdataset.Tables("ITEMMASTER").Rows(j).Item("PROMITEMCODE"))
                                                Sqlstring = " SELECT ISNULL(I.ITEMCODE,'') AS PROMITEMCODE,ISNULL(I.ITEMDESC,'') AS ITEMDESC,ISNULL(I.ITEMTYPECODE,'') AS ITEMTYPECODE,ISNULL(P.POSCODE,'') AS POSCODE,"
                                                Sqlstring = Sqlstring & " I.STARTINGDATE,I.ENDINGDATE,ISNULL(TL.TAXCODE,'') AS TAXCODE,ISNULL(TL.TAXPERCENTAGE,0) AS TAXPERCENTAGE,ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,"
                                                Sqlstring = Sqlstring & " ISNULL(P.SALESACCTIN,'') AS SALESACCTIN FROM ITEMMASTER AS I INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE"
                                                Sqlstring = Sqlstring & " INNER JOIN POSMASTER AS P ON PL.POS = P.POSCODE WHERE  '13-Apr-2007' BETWEEN TL.STARTINGDATE  AND ISNULL(TL.ENDINGDATE,getdate()) AND (I.ITEMCODE = '" & Trim(Promtcode) & "') AND ISNULL(I.FREEZE,'') <>'Y' AND POSCODE = '01'"
                                                gconnection.getDataSet(Sqlstring, "PROMOTIONAL")
                                                If gdataset.Tables("PROMOTIONAL").Rows.Count > 0 Then
                                                    K = MessageBox.Show("Promotional available for this ITEMCODE ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                                                    If K = 1 Then
                                                        ssGrid.Row = ssGrid.ActiveRow + 1
                                                        ssGrid.Col = 1
                                                        ssGrid.Lock = False
                                                        ssGrid.Col = 2
                                                        ssGrid.Lock = False
                                                        ssGrid.Col = 3
                                                        ssGrid.Lock = False
                                                        ssGrid.Col = 4
                                                        ssGrid.Lock = False
                                                        ssGrid.Col = 5
                                                        ssGrid.Lock = False
                                                        ssGrid.SetText(1, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMITEMCODE")))
                                                        ssGrid.SetText(2, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMDESC")))
                                                        ssGrid.SetText(3, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("POSCODE")))
                                                        ssGrid.SetText(4, i + 1, Trim(gdataset.Tables("ITEMMASTER").Rows(j).Item("PROMUOM")))
                                                        ssGrid.SetText(5, i + 1, Val(gdataset.Tables("ITEMMASTER").Rows(j).Item("PROMQTY")))
                                                        ssGrid.SetText(6, i + 1, 0.0)
                                                        ssGrid.SetText(7, i + 1, 0.0)
                                                        ssGrid.SetText(8, i + 1, 0.0)
                                                        ssGrid.SetText(9, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMTYPECODE")))
                                                        ssGrid.SetText(10, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("TAXCODE")))
                                                        ssGrid.SetText(11, i + 1, Val(gdataset.Tables("PROMOTIONAL").Rows(j).Item("TAXPERCENTAGE")))
                                                        ssGrid.SetText(13, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ACCOUNTCODE")))
                                                        ssGrid.SetText(14, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("SALESACCTIN")))
                                                        ssGrid.SetText(15, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("GROUPCODE")))
                                                        ssGrid.SetText(17, i + 1, 0)
                                                        ssGrid.SetText(18, i + 1, 0)
                                                        ssGrid.SetText(19, i + 1, "N")
                                                        ssGrid.SetText(20, i + 1, "N")
                                                        ssGrid.SetActiveCell(4, i + 1)
                                                        ssGrid.Focus()
                                                    Else
                                                        ssGrid.SetActiveCell(0, i + 1)
                                                        ssGrid.Focus()
                                                    End If
                                                End If
                                            Else
                                                ssGrid.Row = ssGrid.ActiveRow + 1
                                                ssGrid.Col = 1
                                                ssGrid.Lock = False
                                                ssGrid.Col = 2
                                                ssGrid.Lock = False
                                                ssGrid.Col = 3
                                                ssGrid.Lock = False
                                                ssGrid.Col = 4
                                                ssGrid.Lock = False
                                                ssGrid.Col = 5
                                                ssGrid.Lock = False
                                                ssGrid.SetActiveCell(0, ssGrid.ActiveRow + 1)
                                            End If
                                            '''*************************** $ COMPLETE PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                        Else
                                            ssGrid.Row = ssGrid.ActiveRow + 1
                                            ssGrid.Col = 1
                                            ssGrid.Lock = False
                                            ssGrid.Col = 2
                                            ssGrid.Lock = False
                                            ssGrid.Col = 3
                                            ssGrid.Lock = False
                                            ssGrid.Col = 4
                                            ssGrid.Lock = False
                                            ssGrid.Col = 5
                                            ssGrid.Lock = False
                                            ssGrid.SetActiveCell(0, ssGrid.ActiveRow + 1)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        Call Calculate()
                    End If
                ElseIf ssGrid.ActiveCol = 6 Then
                    ssGrid.Col = 6
                    ssGrid.Row = ssGrid.ActiveRow
                    If ssGrid.Lock = False Then
                        ssGrid.Col = 1
                        ssGrid.Row = ssGrid.ActiveRow
                        If Trim(ssGrid.Text) <> "" Then
                            ssGrid.Col = 6
                            ssGrid.Row = ssGrid.ActiveRow
                            If Val(ssGrid.Text) = 0 Then
                                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                                Exit Sub
                            Else
                                Call RateCalculate()
                                ssGrid.Row = ssGrid.ActiveRow + 1
                                ssGrid.Col = 1
                                ssGrid.Lock = False
                                ssGrid.Col = 2
                                ssGrid.Lock = False
                                ssGrid.Col = 3
                                ssGrid.Lock = False
                                ssGrid.Col = 4
                                ssGrid.Lock = False
                                ssGrid.Col = 5
                                ssGrid.Lock = False
                                ssGrid.SetActiveCell(0, ssGrid.ActiveRow + 1)
                            End If
                        End If
                    End If
                ElseIf ssGrid.ActiveCol = 12 Then
                    ssGrid.Col = 12
                    ssGrid.Row = ssGrid.ActiveRow
                    If Val(ssGrid.Text) = 0 Then
                        Call Calculate()
                        ssGrid.SetActiveCell(0, ssGrid.ActiveRow + 1)
                        Exit Sub
                    Else
                        Call Calculate()
                        ssGrid.SetActiveCell(0, ssGrid.ActiveRow + 1)
                        Exit Sub
                    End If
                End If
            ElseIf e.keyCode = Keys.F4 Then
                If ssGrid.ActiveCol = 1 Then
                    ssGrid.Col = 1
                    ssGrid.Row = ssGrid.ActiveRow
                    If ssGrid.Lock = False Then
                        ssGrid.Col = 1
                        ssGrid.Row = ssGrid.ActiveRow
                        Search = Trim(ssGrid.Text)
                        'Call FillMenu()
                        Call FillMenuItem() ''' IT WILL SHOW A POPUP MENU FOR ITEM DESC
                    End If
                ElseIf ssGrid.ActiveCol = 2 Then
                    ssGrid.Col = 2
                    ssGrid.Row = ssGrid.ActiveRow
                    If ssGrid.Lock = False Then
                        ssGrid.Col = 2
                        ssGrid.Row = ssGrid.ActiveRow
                        Search = Trim(ssGrid.Text)
                        Call FillMenuItem()
                    End If
                End If
            ElseIf e.keyCode = Keys.F12 Then
                ssGrid.Col = 3
                ssGrid.Row = ssGrid.ActiveRow
                If ssGrid.ActiveCol = 4 Then
                    ssGrid.Col = 4
                    ssGrid.Row = ssGrid.ActiveRow

                    If ssGrid.Lock = False Then
                        Itemcode = Nothing
                        i = ssGrid.ActiveRow
                        ssGrid.Col = 1
                        ssGrid.Row = i
                        Itemcode = Trim(ssGrid.Text)
                        Sqlstring = "SELECT ISNULL(R.UOM,'') AS UOM, ISNULL(R.ITEMRATE,0) AS ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                        Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(Itemcode) & "' ) ORDER BY R.UOM"
                        gconnection.getDataSet(Sqlstring, "ITEMRATE")
                        If gdataset.Tables("ITEMRATE").Rows.Count > 0 Then
                            If gdataset.Tables("ITEMRATE").Rows.Count > 1 Then
                                ssGrid.Col = 4
                                ssGrid.Row = i
                                Call FillUomList(gdataset.Tables("ITEMRATE"))
                                Me.lvw_Uom.FullRowSelect = True
                                pnl_UOMCode.Top = 50
                                pnl_UOMCode.Focus()
                                Me.lvw_Uom.Focus()
                            Else
                                ssGrid.Col = 4
                                ssGrid.Row = ssGrid.ActiveRow
                                ssGrid.Text = gdataset.Tables("ITEMRATE").Rows(0).Item("UOM")
                                ssGrid.Col = 6
                                ssGrid.Row = ssGrid.ActiveRow
                                ssGrid.Text = gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE")
                                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                            End If
                        Else
                            ssGrid.Col = 1
                            ssGrid.Row = ssGrid.ActiveRow
                            ssGrid.Focus()
                        End If
                    End If
                End If
            ElseIf e.keyCode = Keys.F3 Then
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                ssGrid.DeleteRows(ssGrid.ActiveRow, 1)
                Call Calculate()
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Col = 1
                ssGrid.Lock = False
                ssGrid.Col = 2
                ssGrid.Lock = False
                ssGrid.Col = 3
                ssGrid.Lock = False
                ssGrid.Col = 4
                ssGrid.Lock = False
                ssGrid.Col = 5
                ssGrid.Lock = False
                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_TableNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_TableNo.Validated
        Dim strstring As String
        If Trim(txt_TableNo.Text) <> "" Then
            strstring = "SELECT * FROM Tablemaster WHERE tableno='" & Trim(txt_TableNo.Text) & "'"
            gconnection.getDataSet(strstring, "Tablemaster")
            If gdataset.Tables("Tablemaster").Rows.Count > 0 Then
                txt_TableNo.Text = gdataset.Tables("Tablemaster").Rows(0).Item("tableno")
                txt_Cover.Focus()
            Else
                txt_TableNo.Text = ""
                txt_TableNo.Focus()
            End If
        End If
    End Sub
    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Dim strstring As String
        If Trim(txt_MemberCode.Text) <> "" Then
            strstring = " SELECT * FROM SM_CARDFILE_HDR WHERE MEMBERCODE='" & txt_MemberCode.Text & "' AND CAST(CONVERT(CHAR(11),VALID_TO,106) AS DATETIME)>='" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "'"
            gconnection.getDataSet(strstring, "CHK")

            'If gdataset.Tables("CHK").Rows.Count <= 0 And Mid(Cmd_Add.Text, 1, 1) = "A" Then
            '    MessageBox.Show("PLEASE! FLASH YOUR CARD", "CARD NOT FLASH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    'txt_MemberCode.Text = ""
            '    'txt_MemberCode.Focus()
            '    'Exit Sub
            'End If

            If cbo_PaymentMode.Text = "ROOM" Then
                strstring = "SELECT roomno,guest,docno FROM roomcheckin WHERE isnull(checkout,'') <> 'Y' and roomstatus='occupied' AND RoomNo='" & Trim(txt_MemberCode.Text) & "' "
                gconnection.getDataSet(strstring, "RoomCheckin")
                If gdataset.Tables("RoomCheckin").Rows.Count > 0 Then
                    txt_MemberCode.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("RoomNo")
                    txt_MemberName.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("Guest")
                    txt_MemberCode.Tag = gdataset.Tables("RoomCheckin").Rows(0).Item("docno")
                    roomchkno = gdataset.Tables("RoomCheckin").Rows(0).Item("docno")
                    txt_ServerCode.Focus()
                Else
                    txt_MemberCode.Text = ""
                    txt_MemberCode.Focus()
                End If
            Else

                'Show PHOTOS
                If gFoto = "Y" Then
                    If txt_card_id.Text <> "" Then
                        gconnection.LoadFoto_DB(txt_card_id, Pic_Member)
                    Else
                        gconnection.LoadFoto_DB(txt_MemberCode, Pic_Member)
                    End If
                Else
                    If gShortName = "MCC" Then
                        gconnection.FOTO_LOAD_MCC(txt_card_id, Pic_Member)
                    ElseIf gShortName = "NIZAM" Then
                        gconnection.Foto_LOAD_NIZAM(txt_card_id, Pic_Member)
                    ElseIf gShortName = "GNC" Then
                        PHOTOFILENAME = STRPHOTOPATH & "\" & Mid(Trim(txt_MemberCode.Text), 1, Len(Trim(txt_MemberCode.Text))) & ".jpg"
                        PHOTOFILENAME = Replace(PHOTOFILENAME, " ", "")
                        If File.Exists(PHOTOFILENAME) Then
                            Pic_Member.Image = New Bitmap(PHOTOFILENAME)
                        Else
                            Pic_Member.Image = Nothing
                        End If
                    Else
                        gconnection.Foto_LOAD(txt_card_id, Pic_Member)
                    End If
                End If
                'AND CURENTSTATUS='LIVE'
                strstring = "SELECT ISNULL(CURENTSTATUS,'') AS MEMSTATUS,ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CRIDITNUMBER,'') AS CRIDITNUMBER FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
                gconnection.getDataSet(strstring, "membermaster")
                If gdataset.Tables("membermaster").Rows.Count > 0 Then
                    txt_MemberCode.Text = gdataset.Tables("membermaster").Rows(0).Item("MCODE")
                    txt_MemberName.Text = gdataset.Tables("membermaster").Rows(0).Item("MNAME")
                    txt_creditfacility = gdataset.Tables("membermaster").Rows(0).Item("CRIDITNUMBER")
                    LAB_MSTATUS.Text = "MEMBER STATUS:" & UCase(gdataset.Tables("membermaster").Rows(0).Item("MEMSTATUS"))
                    txt_ServerCode.Focus()
                    If UCase(gdataset.Tables("membermaster").Rows(0).Item("MEMSTATUS")) <> "LIVE" Then
                        MessageBox.Show("Member is:" & UCase(gdataset.Tables("membermaster").Rows(0).Item("MEMSTATUS")) & ",you can not entry", "MEMBER STATUS")
                        Cmd_Add.Enabled = True
                        cmd_Delete.Enabled = True
                    End If
                Else
                    txt_MemberCode.Text = ""
                    lab_outstanding.Text = ""
                    txt_MemberCode.Focus()
                    LAB_MSTATUS.Text = ""
                End If
                'Call outstanding()
                'Call fac_det()
                'If txt_card_id.Text = "" And Mid(Cmd_Add.Text, 1, 1) = "A" Then

                Dim msgres As String
                msgres = creditstop(txt_MemberCode.Text)
                If Mid(msgres, 1, 1) = "C" Then
                    If cbo_PaymentMode.Text = "CREDIT" Or cbo_PaymentMode.Text = "PARTY" Then
                        MsgBox("Current Status is " & msgres & ",Kindly Use Cash/SmartCard", MsgBoxStyle.Information, "Info")
                        cbo_PaymentMode.Focus()
                        Exit Sub
                    End If
                ElseIf Mid(msgres, 1, 1) = "D" Then
                    MsgBox("Current Status is " & msgres & ",Sorry You Can Not Make Any Kot(s)", MsgBoxStyle.Information, "Info")
                    cmd_Clear_Click(sender, e)
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub txt_ServerCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ServerCode.Validated
        Dim strstring As String
        Dim I As Integer
        If Trim(txt_ServerCode.Text) <> "" Then
            If Trim(txt_ServerCode.Text) <> "" Then
                strstring = "SELECT * FROM servermaster WHERE ServerCode='" & Trim(txt_ServerCode.Text) & "'AND ISNULL(Freeze,'')<>'Y'"
                gconnection.getDataSet(strstring, "servermaster")
                If gdataset.Tables("servermaster").Rows.Count > 0 Then
                    txt_ServerCode.Text = gdataset.Tables("servermaster").Rows(0).Item("ServerCode")
                    txt_ServerName.Text = gdataset.Tables("servermaster").Rows(0).Item("ServerName")
                    ssGrid.SetActiveCell(1, 1)
                    ssGrid.Focus()
                Else
                    txt_ServerCode.Text = ""
                    txt_ServerCode.Focus()
                End If
            Else
                txt_ServerCode.Focus()
            End If
            If cbo_PaymentMode.Text = "SMART CARD" Then
                Call balance()
            End If
        End If
    End Sub
    Private Sub Cmd_Add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub GRIDLOCK()
        Dim Row, Col As Integer
        ssGrid.Col = 15
        ssGrid.Row = ssGrid.ActiveRow
        For Row = 1 To 100
            For Col = 1 To 5
                ssGrid.Row = Row
                ssGrid.Col = Col
                ssGrid.Lock = True
            Next
        Next
        ssGrid.Row = 1
        For Col = 1 To 5
            ssGrid.Col = Col
            ssGrid.Lock = False
        Next
    End Sub

    Private Sub txt_KOTno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_KOTno.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmd_KOTnoHelp.Enabled = True Then
                Search = Trim(txt_KOTno.Text)
                Call cmd_KOTnoHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_Discount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Discount.KeyPress
        Dim Taxamt, Totalamt, Packamt, cancel As String
        Dim i As Integer
        If Asc(e.KeyChar) = 13 Then
            If Val(txt_Discount.Text) > 0 Then
                Me.txt_TotalValue.Text = 0
                Me.txt_TaxValue.Text = 0
                Me.txt_PackingCharge.Text = 0
                For i = 1 To ssGrid.DataRowCnt
                    cancel = Nothing
                    Taxamt = Nothing
                    Totalamt = Nothing
                    Packamt = Nothing
                    ssGrid.GetText(12, i, cancel)
                    If Val(cancel) = 0 Then
                        ssGrid.GetText(7, i, Taxamt)
                        ssGrid.GetText(8, i, Totalamt)
                        ssGrid.GetText(18, i, Packamt)
                        Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(Totalamt), "0.00")
                        Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(Taxamt), "0.00")
                        Me.txt_PackingCharge.Text = Format(Val(Me.txt_PackingCharge.Text) + Val(Packamt), "0.00")
                    End If
                Next i
                dbldicountAmount = (Val(txt_TotalValue.Text) * Val(txt_Discount.Text)) / 100
                dblGrossAmount = Val(txt_TotalValue.Text) - Val(dbldicountAmount)
                dbldicountTax = (Val(txt_TaxValue.Text) * Val(txt_Discount.Text)) / 100
                dblGrossTax = Val(txt_TaxValue.Text) - Val(dbldicountTax)
                dbldicountPack = (Val(txt_PackingCharge.Text) * Val(txt_Discount.Text)) / 100
                dblGrossPack = Val(txt_PackingCharge.Text) - Val(dbldicountPack)
                dblDicountBillAmount = dblGrossAmount + dblGrossTax + dblGrossPack
                Me.txt_TotalValue.Text = Format(Val(dblGrossAmount), "0.00")
                Me.txt_TaxValue.Text = Format(Val(dblGrossTax), "0.00")
                Me.txt_PackingCharge.Text = Format(Val(dblGrossPack), "0.00")
                If BILLROUNDYESNO = "YES" Then
                    Me.txt_BillAmount.Text = Format(Math.Round(Val(dblDicountBillAmount), 2), "0.00")
                Else
                    Me.txt_BillAmount.Text = Format(Val(dblDicountBillAmount), "0.00")
                End If
                Cmd_Add.Focus()
            End If
        End If
    End Sub
    Private Sub cmd_BillSettlement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BillSettlement.Click
        'Added on 18 Mar'08
        'Mk Kannan
        'Begin
        MsgBox("Please Contact System Admin!", MsgBoxStyle.OKOnly, "Info!")
        Exit Sub
        'End
        Dim sqlstring, Varchk, SubpaymentMode(), paymentaccountcode, Subpaymentaccountcode As String
        Dim TotalAmount, TaxTotal, total, size, i, j As Double
        Dim TaxApp, NoTax, Otherbool As Boolean
        Dim Kot_Bill As New DataTable
        Dim Taxdr(), NoTaxDr() As DataRow
        Try
            'Call checkvalidate() '''---> Check Validation
            'If chkbool = False Then Exit Sub
            ''''************************************************* Case-1:ADD [F7] ***********************************'''
            If Mid(CStr(Cmd_Add.Text), 1, 1) = "A" Then
                BillTaxBilldetails = Trim(Me.txt_KOTno.Text)
                BillNonTaxBilldetails = ""
                dblBillTaxTotal = Val(txt_TaxValue.Text)
                dblBillTotalAmount = Val(txt_BillAmount.Text)
                dblBillNonTaxtotal = 0
                dblBillNonTotalAmount = 0
                BillMcode = Trim(txt_MemberCode.Text)
                BillMname = Trim(txt_MemberName.Text)
                ssgridPayment.Col = 1
                ssgridPayment.Row = 1
                ssgridPayment.Text = Trim(BillTaxBilldetails)
                ssgridPayment.Col = 2
                ssgridPayment.Row = 1
                ssgridPayment.Text = Format(dtp_KOTdate.Value, "dd/MM/yyyy")
                ssgridPayment.Col = 5
                ssgridPayment.Row = 1
                ssgridPayment.Text = Trim(BillMcode)
                ssgridPayment.Col = 6
                ssgridPayment.Row = 1
                ssgridPayment.Text = Trim(BillMname)
                ssgridPayment.Col = 7
                ssgridPayment.Row = 1
                ssgridPayment.Text = Format(Val(dblBillTotalAmount), "0.00")
                ssgridPayment.Col = 8
                ssgridPayment.Row = 1
                ssgridPayment.Text = Format(Val(dblBillTotalAmount), "0.00")
                Gridbillamount = Format(Val(dblBillTotalAmount), "0.00")
                Me.txt_PartialPayment.Text = Format(Val(dblBillTotalAmount), "0.00")
                Call FillPaymentmodeSettlement(1)
                grp_Paymentmodeselection.Top = 296
                grp_Paymentmodeselection.Left = 80
                ssgridPayment.SetActiveCell(3, 1)
                ssgridPayment.Focus()
            Else
                grp_Paymentmodeselection.Top = 296
                grp_Paymentmodeselection.Left = 80
                ssgridPayment.SetActiveCell(3, 1)
                ssgridPayment.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgridPayment_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgridPayment.KeyDownEvent
        Dim Sqlstring, Itemcode, Itemdesc, Promtcode, Billdetailswise As String
        Dim varBillCode, varBillDate, varPaymentMode, varMcode, varMName As String
        Dim dblBillamount, dblAmount1, dblAmount2, dblAmount3 As Decimal
        Dim i, j, count As Integer
        Try
            If e.keyCode = Keys.Enter Then
                i = ssgridPayment.ActiveRow
                If ssgridPayment.ActiveCol = 1 Then
                    ssgridPayment.Row = ssgridPayment.ActiveRow
                    ssgridPayment.Col = 1
                    If Trim(ssgridPayment.Text) = "" Then
                        ssgridPayment.SetActiveCell(2, ssgridPayment.ActiveRow)
                        ssgridPayment.Focus()
                    ElseIf Trim(ssgridPayment.Text) <> "" Then
                        ssgridPayment.SetActiveCell(2, ssgridPayment.ActiveRow)
                        ssgridPayment.Focus()
                    End If
                ElseIf ssgridPayment.ActiveCol = 2 Then
                    ssgridPayment.Row = ssgridPayment.ActiveRow
                    ssgridPayment.Col = 2
                    If Trim(ssgridPayment.Text) = "" Then
                        ssgridPayment.SetActiveCell(2, ssgridPayment.ActiveRow)
                        ssgridPayment.Focus()
                    ElseIf Trim(ssgridPayment.Text) <> "" Then
                        ssgridPayment.SetActiveCell(2, ssgridPayment.ActiveRow)
                        ssgridPayment.Focus()
                    End If
                ElseIf ssgridPayment.ActiveCol = 3 Then
                    ssgridPayment.Row = ssgridPayment.ActiveRow
                    ssgridPayment.Col = 3
                    If ssgridPayment.Lock = False Then
                        ssgridPayment.Col = 3
                        ssgridPayment.Row = ssgridPayment.ActiveRow
                        If Trim(ssgridPayment.Text) = "" Then
                            ssgridPayment.SetActiveCell(2, ssgridPayment.ActiveRow)
                        Else
                            Sqlstring = " SELECT ISNULL(Paymentcode,'') AS Paymentcode,ISNULL(paymentType,'') AS paymentType  FROM paymentmodemaster WHERE Paymentcode = '" & Trim(ssgridPayment.Text) & "' AND ISNULL(Freeze,'')='N'"
                            gconnection.getDataSet(Sqlstring, "paymentmodemaster")
                            If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                                If Trim(ssgridPayment.Text) = Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("Paymentcode")) And Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentType")) = "CD" Then
                                    gridRow = 0
                                    gridRow = ssgridPayment.ActiveRow
                                    grp_Carddetails.Top = 24
                                    grp_Carddetails.Left = 344
                                    grp_Carddetails.Focus()
                                    txt_Typeofcard.Focus()
                                ElseIf Trim(ssgridPayment.Text) = Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("Paymentcode")) And Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentType")) = "CQ" Then
                                    gridRow = 0
                                    gridRow = ssgridPayment.ActiveRow
                                    grp_Chequedetails.Top = 24
                                    grp_Chequedetails.Left = 344
                                    grp_Chequedetails.Focus()
                                    cbo_Typeofcheque.SelectedIndex = 0
                                    cbo_Typeofcheque.Focus()
                                Else
                                    ssgridPayment.SetActiveCell(3, ssgridPayment.ActiveRow)
                                    ssgridPayment.Focus()
                                End If
                            Else
                                ssgridPayment.SetActiveCell(3, ssgridPayment.ActiveRow)
                                ssgridPayment.Focus()
                            End If
                        End If
                    End If
                ElseIf ssgridPayment.ActiveCol = 4 Then
                    ssgridPayment.Row = ssgridPayment.ActiveRow
                    ssgridPayment.Col = 1
                    Billdetailswise = Trim(ssgridPayment.Text)
                    ssgridPayment.Row = ssgridPayment.ActiveRow
                    ssgridPayment.Col = 4
                    If ssgridPayment.Lock = False Then
                        ssgridPayment.Row = ssgridPayment.ActiveRow
                        ssgridPayment.Col = 4
                        If Val(ssgridPayment.Text) = 0 Then
                            ssgridPayment.SetActiveCell(3, ssgridPayment.ActiveRow)
                            ssgridPayment.Focus()
                        ElseIf Val(ssgridPayment.Text) <> 0 Then
                            For i = 1 To ssgridPayment.DataRowCnt
                                ssgridPayment.Col = 1
                                ssgridPayment.Row = i
                                If ssgridPayment.Text = Billdetailswise Then
                                    ssgridPayment.Col = 4
                                    ssgridPayment.Row = i
                                    dblAmount3 = dblAmount3 + Val(ssgridPayment.Text)
                                End If
                            Next
                            ssgridPayment.Row = ssgridPayment.ActiveRow
                            ssgridPayment.Col = 7
                            dblAmount1 = Val(ssgridPayment.Text)
                            ssgridPayment.Row = ssgridPayment.ActiveRow
                            ssgridPayment.Col = 4
                            dblAmount2 = Val(ssgridPayment.Text)
                            If Val(dblAmount3) <= Val(dblAmount1) Then
                                txt_PartialPayment.Text = Format(Val(dblAmount1) - Val(dblAmount3), "0.00")
                                ssgridPayment.Row = ssgridPayment.ActiveRow
                                ssgridPayment.Col = 8
                                If Val(Gridbillamount) <> 0 Then
                                    ssgridPayment.Col = 8
                                    ssgridPayment.Row = ssgridPayment.ActiveRow
                                    ssgridPayment.Text = Format(Val(dblAmount1) - Val(dblAmount3), "0.00")
                                    Gridbillamount = Format(Val(dblAmount1) - Val(dblAmount3), "0.00")
                                    If Val(Gridbillamount) = 0 Then
                                        ssgridPayment.SetActiveCell(3, ssgridPayment.ActiveRow)
                                        cmd_Save.Focus()
                                        Exit Sub
                                    Else
                                        ssgridPayment.Col = 1
                                        ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                        ssgridPayment.Text = Trim(Billdetailswise)
                                        ssgridPayment.Col = 2
                                        ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                        ssgridPayment.Text = Format(CDate(dtp_KOTdate.Value), "dd/MMM/yyyy")
                                        ssgridPayment.Col = 5
                                        ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                        ssgridPayment.Text = Trim(BillMcode)
                                        ssgridPayment.Col = 6
                                        ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                        ssgridPayment.Text = Trim(BillMname)
                                        ssgridPayment.Col = 7
                                        ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                        ssgridPayment.Text = Format(Val(dblBillTotalAmount), "0.00")
                                        ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                        ssgridPayment.Col = 3
                                        ssgridPayment.Lock = False
                                        ssgridPayment.Col = 4
                                        ssgridPayment.Lock = False
                                        Call FillPaymentmodeSettlement(ssgridPayment.ActiveRow + 1)
                                        ssgridPayment.SetActiveCell(2, ssgridPayment.ActiveRow + 1)
                                        ssgridPayment.Focus()
                                    End If
                                End If
                            Else
                                MessageBox.Show("You Can't enter more amount then Billamount", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                ssgridPayment.Col = 4
                                ssgridPayment.Row = ssgridPayment.ActiveRow
                                ssgridPayment.Text = ""
                                ssgridPayment.SetActiveCell(3, ssgridPayment.ActiveRow)
                                ssgridPayment.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                ElseIf ssgridPayment.ActiveCol = 5 Then
                    ssgridPayment.Row = ssgridPayment.ActiveRow
                    ssgridPayment.Col = 5
                    If Trim(ssgridPayment.Text) = "" Then
                        ssgridPayment.SetActiveCell(4, i)
                        ssgridPayment.Focus()
                    ElseIf Trim(ssgridPayment.Text) <> "" Then
                        ssgridPayment.SetActiveCell(2, ssgridPayment.ActiveRow + 1)
                        ssgridPayment.Focus()
                    End If
                ElseIf ssgridPayment.ActiveCol = 6 Then
                    ssgridPayment.Row = ssgridPayment.ActiveRow
                    ssgridPayment.Col = 6
                    If Trim(ssgridPayment.Text) = "" Then
                        ssgridPayment.SetActiveCell(5, i)
                        ssgridPayment.Focus()
                    ElseIf Trim(ssgridPayment.Text) <> "" Then
                        ssgridPayment.SetActiveCell(2, ssgridPayment.ActiveRow + 1)
                        ssgridPayment.Focus()
                    End If
                End If
            End If
        Catch EX As Exception
            Exit Sub
        End Try
    End Sub
    Public Sub FillPaymentmodeSettlement(ByVal i As Integer)
        Dim sqlstring As String
        Dim j As Integer
        Try
            ssgridPayment.TypeComboBoxClear(3, i)
            sqlstring = "SELECT Paymentcode FROM paymentmodemaster WHERE  Paymentcode <> 'ROOM' AND Isnull(Freeze,'')='N'"
            gconnection.getDataSet(sqlstring, "paymentmodemaster")
            If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                For j = 0 To gdataset.Tables("paymentmodemaster").Rows.Count - 1
                    ssgridPayment.Col = 3
                    ssgridPayment.Row = i
                    ssgridPayment.TypeComboBoxString = Trim(gdataset.Tables("paymentmodemaster").Rows(j).Item("Paymentcode"))
                    ssgridPayment.Text = Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("Paymentcode"))
                Next j
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmd_Back_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_Back.Click
        grp_Paymentmodeselection.Top = 1000
        grp_Carddetails.Top = 1000
        grp_Chequedetails.Top = 1000
    End Sub
    Private Sub cmd_Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_Cancel.Click
        ssgridPayment.ClearRange(1, 1, -1, -1, True)
        ssgridPayment.SetActiveCell(1, 1)
        txt_Cardholdername.Text = ""
        txt_PartialPayment.Text = ""
        txt_Chequeno.Text = ""
        txt_Draweebank.Text = ""
        txt_Typeofcard.Text = ""
        txt_Cardno.Text = ""
        'Call cmd_BillSettlement_Click(sender, e)
    End Sub
    Private Sub txt_Typeofcard_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Typeofcard.KeyPress
        Call getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Cardno.Focus()
        End If
    End Sub

    Private Sub txt_Cardno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cardno.KeyPress
        Call getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            dtp_Expirydate.Focus()
        End If
    End Sub

    Private Sub dtp_Expirydate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Expirydate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_Cardholdername.Focus()
        End If
    End Sub

    Private Sub txt_Cardholdername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Cardholdername.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ssgridPayment.SetActiveCell(4, gridRow)
            ssgridPayment.Focus()
            grp_Carddetails.Top = 1000
        End If
    End Sub

    Private Sub cbo_Typeofcheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Typeofcheque.KeyPress
        Call Blank(e)
        If Asc(e.KeyChar) = 13 Then
            txt_Chequeno.Focus()
        End If
    End Sub

    Private Sub txt_Chequeno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Chequeno.KeyPress
        Call getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            dtp_Chequedate.Focus()
        End If
    End Sub

    Private Sub dtp_Chequedate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Chequedate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_Draweebank.Focus()
        End If
    End Sub

    Private Sub txt_Draweebank_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Draweebank.KeyPress
        Call getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            ssgridPayment.SetActiveCell(4, gridRow)
            ssgridPayment.Focus()
            grp_Chequedetails.Top = 1000
        End If
    End Sub

    Private Sub cmd_Save_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_Save.Click
        grp_Paymentmodeselection.Top = 1000
        Cmd_Add.Focus()
    End Sub

    Private Sub Txt_Remarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Remarks.KeyDown
        'If e.KeyCode = Keys.K Then
        '    'Txt_Remarks.Text = "OT NO :"
        'End If
    End Sub

    Private Sub Txt_Remarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Remarks.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub cbo_PaymentMode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_PaymentMode.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(cmd_Clear, e)
        End If
    End Sub

    Private Sub txt_FacilityMemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FacilityMemberCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Me.cmd_MemberCodeHelp.Enabled = True Then
                Search = Trim(txt_MemberCode.Text)
                Call cmd_MemberCodeHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_FacilityMemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FacilityMemberCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_FacilityMemberCode.Text) <> "" Then
                txt_FacilityMemberCode_Validated(sender, e)
            Else
                Call btn_FacilityMemberCodeHelp_Click(btn_FacilityMemberCodeHelp, e)
            End If
        End If
    End Sub
    Private Sub txt_FacilityMemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FacilityMemberCode.Validated
        Try
            Dim strstring As String
            Dim I, J As Integer
            If Trim(txt_FacilityMemberCode.Text) <> "" Then
                strstring = "SELECT * FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_FacilityMemberCode.Text) & "'"
                gconnection.getDataSet(strstring, "MEMBERMASTER")
                If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                    txt_FacilityMemberCode.Text = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MCODE")
                    txt_FacilityMemberName.Text = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MNAME")
                    Facilityssgrid.Focus()
                Else
                    txt_FacilityMemberCode.Text = ""
                    txt_FacilityMemberName.Focus()
                End If
                strstring = "SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMDESC,'') AS ITEMDESC,ISNULL(POSTING1,'') AS POSTING1,"
                strstring = strstring & "ISNULL(POSTING2,'') AS POSTING2,ISNULL(POSTING3,'') AS POSTING3,ISNULL(POSTING4,'') AS POSTING4 FROM MemberFacilityMaster WHERE MCODE='" & Trim(Me.txt_FacilityMemberCode.Text) & "'"
                gconnection.getDataSet(strstring, "MemberFacilityMaster")
                If gdataset.Tables("MemberFacilityMaster").Rows.Count > 0 Then
                    For I = 1 To gdataset.Tables("MemberFacilityMaster").Rows.Count
                        Facilityssgrid.SetText(1, I, Trim(gdataset.Tables("MemberFacilityMaster").Rows(J).Item("POSDESC")))
                        Facilityssgrid.SetText(2, I, Trim(gdataset.Tables("MemberFacilityMaster").Rows(J).Item("ITEMCODE")))
                        Facilityssgrid.SetText(3, I, Trim(gdataset.Tables("MemberFacilityMaster").Rows(J).Item("ITEMDESC")))
                        Facilityssgrid.SetText(4, I, Val(gdataset.Tables("MemberFacilityMaster").Rows(J).Item("POSTING1")))
                        Facilityssgrid.SetText(5, I, Val(gdataset.Tables("MemberFacilityMaster").Rows(J).Item("POSTING2")))
                        Facilityssgrid.SetText(6, I, Val(gdataset.Tables("MemberFacilityMaster").Rows(J).Item("POSTING2")))
                        Facilityssgrid.SetText(7, I, Val(gdataset.Tables("MemberFacilityMaster").Rows(J).Item("POSTING3")))
                        Facilityssgrid.SetText(8, I, Val(gdataset.Tables("MemberFacilityMaster").Rows(J).Item("POSTING4")))
                        Facilityssgrid.SetText(9, I, Trim(gdataset.Tables("MemberFacilityMaster").Rows(J).Item("POSCODE")))
                        J = J + 1
                    Next I
                    grp_Memberfacility.Top = 128
                    grp_Memberfacility.Left = 72
                Else
                    MessageBox.Show("Facility is not added in Member Facility", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    grp_Memberfacility.Top = 1000
                    txt_ServerCode.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_FacilityMemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FacilityMemberCodeHelp.Click
        Dim sqlstring As String
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM Membermaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = " MNAME,MCODE "
        vform.vFormatstring = "                 MEMBER CODE            |                 MEMBER NAME                                "
        vform.vCaption = "MEMBER MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_FacilityMemberCode.Text = Trim(vform.keyfield & "")
            txt_FacilityMemberName.Text = Trim(vform.keyfield1 & "")
            Facilityssgrid.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Function SpiltBill()
        Dim tempamt As Double
        Dim mcode As String
        LAB_BALANCEAMT.Text = "BALANCE AMOUNT:"
        Try
            With ssgrid_settlement
                tempamt = 0.0
                For I = 1 To ssgrid_settlement.DataRowCnt
                    .Col = 2
                    .Row = I
                    tempamt = tempamt + Val(.Text)
                Next
            End With
            LAB_BALANCEAMT.Text = LAB_BALANCEAMT.Text & Format(Math.Round(Val(txt_BillAmount.Text - tempamt), 2), "0.00")
            If tempamt <> Val(txt_BillAmount.Text) Then
                Return "True"
            Else
                Return "False"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Function MEMBER_VALIDACTION()
        Dim strstring, MCODE As String
        Dim J As Int16
        Try
            With ssgrid_settlement
                .Row = .ActiveRow
                .Col = 1
                If Trim(.Text) <> "" Then
                    strstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CRIDITNUMBER,'') AS CRIDITNUMBER FROM membermaster WHERE MCODE='" & Trim(.Text) & "'"
                    gconnection.getDataSet(strstring, "membermaster")
                    If gdataset.Tables("membermaster").Rows.Count = 0 Then
                        Return "True"
                    Else
                        For I = 1 To ssgrid_settlement.DataRowCnt
                            .Col = 1
                            .Row = I
                            MCODE = Trim(.Text)
                            For J = 1 To ssgrid_settlement.DataRowCnt
                                .Col = 1
                                .Row = J
                                If MCODE = Trim(.Text) And I <> J Then
                                    ssgrid_settlement.Row = ssgrid_settlement.ActiveRow
                                    ssgrid_settlement.DeleteRows(ssgrid_settlement.ActiveRow, 1)
                                    Call SpiltBill()
                                End If
                            Next
                        Next
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            'txt_MemberCode.Focus()
            Exit Function
        End Try
    End Function
    Private Function member_help()
        Dim vform As New ListOperattion1
        gSQLString = "SELECT mcode,mname FROM Membermaster"
        M_WhereCondition = ""
        vform.Field = " MCODE,MNAME "
        vform.vFormatstring = "                 MEMBER CODE            |                 MEMBER NAME                                "
        vform.vCaption = "MEMBER MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            If ssgrid_settlement.ActiveCol = 1 Then
                ssgrid_settlement.Col = 1
                ssgrid_settlement.Row = ssgrid_settlement.ActiveRow
                ssgrid_settlement.Text = Trim(vform.keyfield & "")
                ssgrid_settlement.SetActiveCell(1, ssgrid_settlement.ActiveRow)
            End If
        End If
        vform.Close()
        vform = Nothing
    End Function
    Private Sub ssgrid_settlement_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid_settlement.KeyDownEvent
        If e.keyCode = Keys.F3 Then
            ssgrid_settlement.Row = ssgrid_settlement.ActiveRow
            ssgrid_settlement.DeleteRows(ssgrid_settlement.ActiveRow, 1)
            Call SpiltBill()
        End If
        If e.keyCode = Keys.Enter Then
            With ssgrid_settlement
                .Row = .ActiveRow
                .Col = 1
                If .ActiveCol = 1 And Trim(.Text) = "" Then
                    Call member_help()
                End If
                If MEMBER_VALIDACTION() = "True" Then
                    .Col = 1
                    .Text = ""
                    MessageBox.Show("Invalid Member Code Plz try once again", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    .Focus()
                End If

                .Col = 2
                If .ActiveCol = 2 And Val(Trim(.Text)) > 0 Then
                    Call SpiltBill()
                End If
            End With
        End If
        If e.keyCode = Keys.F4 Then
            If ssgrid_settlement.ActiveCol = 1 Then
                Call member_help()
            End If
        End If
    End Sub
    Private Sub ssgrid_settlement_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid_settlement.LeaveCell
        With ssgrid_settlement
            .Row = .ActiveRow
            .Col = 1
            If .ActiveCol = 1 Then
            End If
            .Row = .ActiveRow
            .Col = 2
            If .ActiveCol = 2 Then
                SpiltBill()
            End If
        End With
    End Sub
    Private Function Fillsettlement()
        Dim sqlstring, Subpaymentmode() As String
        Dim Billtotal As Double
        kotdetails = ""
        Dim i, j As Integer
        Try
            sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(BILLDETAILS,'') AS BILLDETAILS,ISNULL(DESCRIPTION,'') AS DESCRIPTION "
            sqlstring = sqlstring & " FROM SETTLEMENT WHERE BILLDETAILS='" & Trim(txt_KOTno.Text) & "' --AND ISNULL(DELETEFLAG,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "SETTLE")
            If gdataset.Tables("SETTLE").Rows.Count > 0 Then
                With ssgrid_settlement
                    ssgrid_settlement.ClearRange(1, 1, -1, -1, True)
                    ssgrid_settlement.SetActiveCell(1, 1)
                    For i = 0 To gdataset.Tables("SETTLE").Rows.Count - 1
                        .Row = i + 1
                        .Col = 1
                        .Text = gdataset.Tables("SETTLE").Rows(i).Item("MCODE")
                        .Col = 2
                        .Text = Format(Val(gdataset.Tables("SETTLE").Rows(i).Item("AMOUNT")), "0.00")
                        .Col = 3
                        .Text = gdataset.Tables("SETTLE").Rows(i).Item("DESCRIPTION")
                    Next
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Sub CMD_SETTLEMENT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_SETTLEMENT.Click
        If ssGrid.DataRowCnt > 0 Then
            If SpiltBill() = "True" Then
                MessageBox.Show("Settlement Amount Not Tallyed :", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                SETLEMENT_GROUP.Visible = True
                ssgrid_settlement.Focus()
            Else
                SETLEMENT_GROUP.Visible = False
            End If
        End If
    End Sub
    Private Sub txt_BillAmount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BillAmount.Validated
        'SETTLEMENT
        'BEGIN
        If Val(Trim(txt_BillAmount.Text)) > 0 Then
            With ssgrid_settlement
                If ssgrid_settlement.DataRowCnt = 1 Then
                    .Col = 1
                    .Row = 1
                    .Text = ""
                    .Text = Trim(txt_MemberCode.Text)
                    .Col = 2
                    .Row = 1
                    .Text = ""
                    .Text = Trim(txt_BillAmount.Text)
                    'End If
                End If
            End With
        End If
        'SETTLEMENT
        'END
    End Sub

    Private Sub txt_ServerCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ServerCode.TextChanged

    End Sub

    Private Sub txt_KOTno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_KOTno.TextChanged

    End Sub

    Private Sub txt_BillAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BillAmount.TextChanged

    End Sub

    Private Sub ssGrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssGrid.Advance

    End Sub

    Private Sub txt_MemberCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MemberCode.TextChanged

    End Sub
    Private Sub Txt_Remarks_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Remarks.TextChanged

    End Sub
    Public Sub SVSC_PRINT()
        Randomize()
        Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
        Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword, splmember, servicelocation As String
        Dim BillNo, sql, sqlstring, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno, SNAME As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage As Double
        Dim ds As New DataSet
        Dim Otherbool, boolOtherBill As Boolean
        Dim Filewrite As StreamWriter
        gCompanyname = MyCompanyName
        gCompanyAddress(0) = Address1
        gCompanyAddress(1) = Address2
        Gheader = "TAX  INVOICE"
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_KOTno.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
            Otherbool = True
        Else
            Otherbool = False
        End If
        If Otherbool = True Then
            billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_KOTno.Text) & "'"
        Else
            billdetails = "'" & Trim(Me.txt_KOTno.Text) & "'"
        End If

        '        Call outstanding()

        sql = " SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,D.SCODE,E.SERVERNAME AS SNAME,"
        sql = sql & "D.BILLDETAILS,ISNULL(D.KOTNO,'') AS KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,"
        sql = sql & "D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,"
        sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,ISNULL(BILL_HDR.servicelocation,'') AS servicelocation,"
        sql = sql & "ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
        sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
        sql = sql & " INNER JOIN SERVERMASTER E  ON E.SERVERCODE=D.SCODE  "
        sql = sql & " WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' "
        sql = sql & " ORDER BY D.KOTDETAILS --D.BillDetails "
        gconnection.getDataSet(sql, "ReportTable")
        Dim adduserid As String
        adduserid = ""
        If gdataset.Tables("ReportTable").Rows.Count > 0 Then
            Filewrite = File.AppendText(vFilepath)
            vline = ""
            BillNo = Trim(gdataset.Tables("ReportTable").Rows(0).Item("BillDetails"))
            taxpercentage = Val(gdataset.Tables("ReportTable").Rows(0).Item("TaxPerc"))
            Kot = ""
            ssgrid_settlement.SetActiveCell(1, 1)
            splmember = ""
            ssgrid_settlement.SetActiveCell(1, 1)
            TaxAmount = 0
            TotalAmount = 0
            Dim SETMCODE As String
            Dim SETAMOUNT As Double
            Dim vpagenumber, Vrowcount, innercount, taxcount As Long
            Dim headercount As Double
            Dim SSQLROOM, poscode As String
            innercount = 0
            Vrowcount = 0
            vpagenumber = 1
            SETMCODE = ""
            SETAMOUNT = 0
            ssgrid_settlement.Col = 1
            ssgrid_settlement.Row = J
            SETMCODE = (ssgrid_settlement.Text)
            ssgrid_settlement.Col = 2
            ssgrid_settlement.Row = J
            SETAMOUNT = Format(Val(ssgrid_settlement.Text), "0.00")
            poscode = Trim(gdataset.Tables("ReportTable").Rows(0).Item("poscode"))
            servicelocation = Trim(gdataset.Tables("ReportTable").Rows(0).Item("servicelocation"))
            adduserid = Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID"))
            SNAME = Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME"))
            CountItem = 0
            '---HEADERING
            'BEGIN
            For i = 1 To 2
                Filewrite.WriteLine("")
            Next
            Vrowcount = 2
            Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & "" & Chr(20) & Chr(27) & Chr(72))
            Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & gCompanyname & Chr(20) & Chr(27) & Chr(72))
            Rowprint = gCompanyAddress(1)
            Filewrite.WriteLine(Space(12) & Rowprint)
            Filewrite.WriteLine()
            Filewrite.WriteLine(Chr(18) & Chr(14) & Chr(15) & Space(12) & Trim(cbo_PaymentMode.Text) & "-BILL")
            Filewrite.WriteLine()
            If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "ROOM" Then
                Rowprint = Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) & ":"
                Rowprint = Rowprint & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("ROOMNO") & "-")
                Rowprint = Rowprint & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("GUEST") & "")
            ElseIf Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "CLUB" Then
                Rowprint = Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) & ":"
                HNAME = Split(cbo_SubPaymentMode.Text, "-")
                Rowprint = Rowprint & Chr(14) & Chr(15) & Trim(HNAME(1)) & "(" & Trim(HNAME(0)) & ")"
            Else
                If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "CREDIT" Then
                    Rowprint = Chr(18) & "MCODE:"
                Else
                    Rowprint = Chr(18) & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) & ":"
                End If
                Rowprint = Rowprint & Space(1) & Chr(18) & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE"))
                Filewrite.WriteLine(Rowprint)
                Rowprint = "NAME:" & Space(1) & Chr(18) & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME"))
            End If
            Filewrite.WriteLine(Chr(18) & Chr(14) & Chr(15) & Rowprint & Chr(18) & Chr(14) & Chr(15))
            Filewrite.WriteLine("{0,-12}{1,-20}", Chr(14) & Chr(15) & "LOCATION :", gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & servicelocation & "'") & Space(10) & "OP.BAL:" & MemberOutstand)
            Filewrite.Write(Chr(18) & "BILLNO:" & Trim(BillNo))
            Filewrite.Write(" DATE:" & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy"))
            Filewrite.WriteLine(Chr(15) & " TIME:" & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "T") & Chr(18))
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Filewrite.WriteLine(Chr(18) & "SLNO KOTNO   ITEM DESCRIPTION     QTY   RATE   AMOUNT")
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            'HEADING END
            TotalAmount = 0 : TaxAmount = 0
            CountItem = 0
            For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                CountItem = CountItem + 1
                With gdataset.Tables("ReportTable").Rows(rowj)
                    Filewrite.Write(Chr(18) & Space(3 - Len(Mid(Format(CountItem, "0"), 1, 3))) & Mid(Format(CountItem, "0"), 1, 3))
                    Filewrite.Write(Space(1) & Mid(Trim(.Item("KOTNO") & ""), 1, 8) & Space(8 - Len(Mid(Trim(.Item("KOTNO") & ""), 1, 8))))
                    Filewrite.Write(Space(1) & Mid(Trim(.Item("ITEMDESC") & ""), 1, 20) & Space(20 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 20))))
                    Filewrite.Write(Space(1) & Space(3 - Len(Mid(Format(Val(.Item("QTY") & ""), "0"), 1, 3))) & Mid(Format(Val(.Item("QTY") & ""), "0"), 1, 3))
                    Filewrite.Write(Space(1) & Space(7 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 7))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 7))
                    Filewrite.WriteLine(Space(1) & Space(7 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 7))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 7))
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                End With
            Next rowj
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine(Chr(18))
            Rowprint = "Total" & Chr(14) & Chr(15) & Space(33) & Space(8 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 8)
            Filewrite.WriteLine(Rowprint & Chr(18))
            sqlstring = "select isnull(sum(a.taxamount),0) as Taxamount,a.taxcode,b.itemtypedesc from bill_det a,"
            sqlstring = sqlstring & "itemtypemaster b where a.taxcode=b.taxcode and isnull(a.delflag,'')<>'Y' AND "
            sqlstring = sqlstring & " a.taxamount>0 AND a.billdetails='" & Trim(txt_KOTno.Text) & "'"
            sqlstring = sqlstring & "  group by a.taxcode,b.itemtypedesc"
            gconnection.getDataSet(sqlstring, "TaxDet")
            'TAX PRINT
            For i = 0 To gdataset.Tables("TaxDet").Rows.Count - 1
                Filewrite.Write(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15) & Space(21 - Len(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15))))
                Rowprint = Chr(14) & Chr(15) & Space(21) & Space(6 - Len(Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 6))) & Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 6)
                Filewrite.WriteLine(Rowprint & Chr(18))
            Next
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine("")

            If i = 0 Then
                Rowprint = Chr(18) & "Net Amount"
            Else
                Rowprint = Chr(18) & Space(11)
            End If
            Rowprint = "Net Amount" & Space(15) & Space(31 - Len(Rowprint)) & Chr(14) & Chr(15) & Space(8 - Len(Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8)
            Filewrite.WriteLine(Rowprint)
            Call bill_roundoff()
            Rowprint = Chr(18) & "Round Off" & Space(35) & Chr(14) & Chr(15) & Space(8 - Len(Mid(Trim(Format(Amt, "0.00")), 1, 8))) & Mid(Trim(Format(Amt, "0.00")), 1, 8) & Chr(18)
            'If Amt <> 0 Then
            Filewrite.WriteLine(Rowprint)
            'End If
            'Filewrite.Write(Chr(45))
            'Filewrite.Write(Chr(18))
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Rowprint = Mid(Chr(18) & "BILL AMOUNT:", 1, 25) & Space(25 - Len(Mid("BILL AMOUNT:", 1, 25))) & Space(20)
            If Amt < 0 Then
                Rowprint = Rowprint & Chr(14) & Chr(15) & Format(Val((TaxAmount + TotalAmount)) - Val(Amt * -1), "0.00")
            Else
                Rowprint = Rowprint & Chr(14) & Chr(15) & Format(Val((TaxAmount + TotalAmount)) + Val(Amt), "0.00")
            End If
            Filewrite.WriteLine(Rowprint)
            taxcount = taxcount + 1
            Vrowcount = Vrowcount + 1
            Filewrite.Write(Chr(18))
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Dim sstring As String
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine(Chr(18) & "Members Sign                      Bearer Sign")
            Filewrite.WriteLine(Space(35) & Mid(Trim(LTrim(SNAME)), 1, 15) & Space(15 - Len(Mid(Trim(LTrim(SNAME)), 1, 15))))
            Filewrite.WriteLine("Prepared By :" & Space(10 - Len(Mid(adduserid, 1, 10))) & Mid(Trim(adduserid), 1, 10))
            Filewrite.WriteLine("")
            Filewrite.WriteLine("                 THANK YOU VISIT AGAIN")
            If Trim(Txt_Remarks.Text) <> "" Then
                If Len(Trim(Txt_Remarks.Text)) < 65 Then
                    Filewrite.Write("             " & Trim(Txt_Remarks.Text))
                    Vrowcount = Vrowcount + 1
                    taxcount = taxcount + 1
                Else
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                    Filewrite.Write("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                    Vrowcount = Vrowcount + 2
                    taxcount = taxcount + 2
                End If
            Else
            End If
            For i = 0 To 10
                Filewrite.WriteLine("")
            Next
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(vFilepath)
            End If
        Else
            MessageBox.Show("Invalid BillNo or Bill is not Yet generated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
    End Sub
    Function outstanding1()
        Try
            lab_outstanding.Text = "0.00"
            MemberOutstand = 0
            SQLSTRING = " SELECT SLCODE,ISNULL(SUM(DRAMOUNT-CRAMOUNT),0) AS AMOUNT FROM credit_limit WHERE SLCODE='" & txt_MemberCode.Text & "' GROUP BY SLCODE "
            gconnection.getDataSet(SQLSTRING, "Outstand")
            If gdataset.Tables("Outstand").Rows.Count > 0 Then
                lab_outstanding.Text = "MEMBER OUTSTANDING :" & Format(Val(gdataset.Tables("outstand").Rows(0).Item("amount")), "0.00")
                MemberOutstand = Val(gdataset.Tables("outstand").Rows(0).Item("amount"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Function outstanding()
        Try
            'And Mid(gClosingBalanceFlag, 1, 1) = "Y" 
            'lab_outstanding.Text = "0.00"
            'MemberOutstand = 0
            'If Mid(gTallyIntegration, 1, 1) = "Y" And Mid(gTallyKotFlag, 1, 1) = "Y" And Trim(txt_MemberCode.Text) <> "" Then
            '    Dim myconnection As New ADODB.Connection
            '    Dim ssql As String
            '    Dim vfill As New ADODB.Recordset
            '    myconnection.Open(gTallyDsn)
            '    ssql = "Select $Name,$ClosingBalance from '" & gTallymonthbill & "'.'" & gTallyUser & "'.'Ledger' where $$IsBelongsTo:$$GroupSundryDebtors and ($Name='" & Funapos(Funamp(Trim(txt_MemberCode.Text))) & "' OR $Name='" & Funapos(Funamp(Trim(txt_MemberName.Text))) & "')"
            '    'ssql = "Select $Name,$ClosingBalance from Ledger where $$IsBelongsTo:$$GroupSundryDebtors and ($Name='" & Trim(txt_MemberCode.Text) & "' OR $Name='" & Trim(txt_MemberName.Text) & "')"
            '    vfill.Open(ssql, myconnection)
            '    If Not vfill.EOF Then
            '        If IsDBNull(vfill.Fields.Item("$ClosingBalance").Value) = False Then
            '            If vfill.Fields.Item("$ClosingBalance").Value < 0 Then
            '                lab_outstanding.Text = "Closing Balance : Cr " & Format(vfill.Fields.Item("$ClosingBalance").Value, "0.00")
            '            Else
            '                lab_outstanding.Text = "Closing Balance : Dr " & Format(vfill.Fields.Item("$ClosingBalance").Value, "0.00")
            '            End If
            '            'MsgBox(Trim(lab_outstanding.Text), MsgBoxStyle.OKOnly, Trim(txt_MemberCode.Text))
            '            txt_ServerCode.Focus()
            '        End If
            '    End If
            '    vfill.Close()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Function bill_roundoff()
        Dim ROUNDOFF As Double
        Dim ROUND As String

        txt_BillAmount.Text = Format(Val(txt_BillAmount.Text), "0.00")
        ROUNDOFF = Format(Val(txt_BillAmount.Text), "0.00")
        ROUND = CStr(Format(Val(ROUNDOFF), "0.00"))


        If Val(Mid(Split(ROUND, ".")(1), 2, 1)) = 0 Then
            AMT1 = 0.0
            Amt = 0
            ' Amt = Format(Val(AMT1) - (Format(Val(Split(txt_BillAmount.Text, ".")(1)), "0.00") / 100), "0.00")
        Else
            AMT1 = IIf((10 - Val(Mid(Split(ROUND, ".")(1), 2, 1))) = 0, 1 + Val(Mid(Split(ROUND, ".")(1), 2, 1)), (10 - Val(Mid(Split(ROUND, ".")(1), 2, 1))) + Val(Mid(Split(ROUND, ".")(1), 2, 1)))
            AMT1 = AMT1 + (Val(Mid(Split(ROUND, ".")(1), 1, 1)) * 10)
            AMT1 = Format((AMT1 / 100), "0.00")
            Amt = Format(Val(AMT1) - (Format(Val(Split(txt_BillAmount.Text, ".")(1)), "0.00") / 100), "0.00")
        End If
        Exit Function

        If Val(Split(ROUND, ".")(1)) >= 36 And Val(Split(ROUND, ".")(1)) <= 75 Then
            AMT1 = 0.5
        ElseIf Val(Split(ROUND, ".")(1)) >= 0 And Val(Split(ROUND, ".")(1)) <= 35 Then
            AMT1 = 0.0
        ElseIf Val(Split(ROUND, ".")(1)) >= 76 And Val(Split(ROUND, ".")(1)) <= 99 Then
            AMT1 = 1
        End If
        Amt = Format(Val(AMT1) - (Format(Val(Split(txt_BillAmount.Text, ".")(1)), "0.00") / 100), "0.00")
    End Function
    Public Sub SVSC_PRINT1()
        Randomize()
        Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
        Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword, splmember, servicelocation As String
        Dim BillNo, sql, sqlstring, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno, SNAME As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage As Double
        Dim ds As New DataSet
        Dim Otherbool, boolOtherBill As Boolean
        Dim Filewrite As StreamWriter
        gCompanyname = MyCompanyName
        gCompanyAddress(0) = Address1
        gCompanyAddress(1) = Address2
        Gheader = "TAX  INVOICE"
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_KOTno.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
            Otherbool = True
        Else
            Otherbool = False
        End If
        If Otherbool = True Then
            billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_KOTno.Text) & "'"
        Else
            billdetails = "'" & Trim(Me.txt_KOTno.Text) & "'"
        End If

        Call outstanding()

        sql = " SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,D.SCODE,E.SERVERNAME AS SNAME,"
        sql = sql & "D.BILLDETAILS,ISNULL(D.KOTNO,'') AS KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,"
        sql = sql & "D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,"
        sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,ISNULL(BILL_HDR.servicelocation,'') AS servicelocation,"
        sql = sql & "ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
        sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
        sql = sql & " INNER JOIN SERVERMASTER E  ON E.SERVERCODE=D.SCODE  "
        sql = sql & " WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' "
        sql = sql & " ORDER BY D.KOTDETAILS --D.BillDetails "
        gconnection.getDataSet(sql, "ReportTable")
        Dim adduserid As String
        adduserid = ""
        If gdataset.Tables("ReportTable").Rows.Count > 0 Then
            Filewrite = File.AppendText(vFilepath)
            vline = ""
            BillNo = Trim(gdataset.Tables("ReportTable").Rows(0).Item("BillDetails"))
            taxpercentage = Val(gdataset.Tables("ReportTable").Rows(0).Item("TaxPerc"))
            Kot = ""
            ssgrid_settlement.SetActiveCell(1, 1)
            splmember = ""
            ssgrid_settlement.SetActiveCell(1, 1)
            TaxAmount = 0
            TotalAmount = 0
            Dim SETMCODE As String
            Dim SETAMOUNT As Double
            Dim vpagenumber, Vrowcount, innercount, taxcount As Long
            Dim headercount As Double
            Dim SSQLROOM, poscode As String
            innercount = 0
            Vrowcount = 0
            vpagenumber = 1
            SETMCODE = ""
            SETAMOUNT = 0
            ssgrid_settlement.Col = 1
            ssgrid_settlement.Row = J
            SETMCODE = (ssgrid_settlement.Text)
            ssgrid_settlement.Col = 2
            ssgrid_settlement.Row = J
            SETAMOUNT = Format(Val(ssgrid_settlement.Text), "0.00")
            poscode = Trim(gdataset.Tables("ReportTable").Rows(0).Item("poscode"))
            servicelocation = Trim(gdataset.Tables("ReportTable").Rows(0).Item("servicelocation"))
            adduserid = Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID"))
            SNAME = Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME"))
            CountItem = 0
            '---HEADERING
            'BEGIN
            For i = 1 To 2
                Filewrite.WriteLine("")
            Next
            Vrowcount = 2
            Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & "" & Chr(20) & Chr(27) & Chr(72))
            Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & gCompanyname & Chr(20) & Chr(27) & Chr(72))
            Rowprint = gCompanyAddress(1)
            Filewrite.WriteLine(Space(12) & Rowprint)
            Filewrite.WriteLine()
            Filewrite.WriteLine(Chr(18) & Chr(14) & Chr(15) & Space(12) & Trim(cbo_PaymentMode.Text) & "-BILL")
            Filewrite.WriteLine()
            If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "ROOM" Then
                Rowprint = Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) & ":"
                Rowprint = Rowprint & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("ROOMNO") & "-")
                Rowprint = Rowprint & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("GUEST") & "")
            ElseIf Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "CLUB" Then
                Rowprint = Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) & ":"
                HNAME = Split(cbo_SubPaymentMode.Text, "-")
                Rowprint = Rowprint & Chr(14) & Chr(15) & Trim(HNAME(1)) & "(" & Trim(HNAME(0)) & ")"
            Else
                If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "CREDIT" Then
                    Rowprint = Chr(18) & "MCODE:"
                Else
                    Rowprint = Chr(18) & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) & ":"
                End If
                Rowprint = Rowprint & Space(1) & Chr(18) & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE"))
                Filewrite.WriteLine(Rowprint)
                Rowprint = "NAME:" & Space(1) & Chr(18) & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME"))
            End If
            Filewrite.WriteLine(Chr(18) & Chr(14) & Chr(15) & Rowprint & Chr(18) & Chr(14) & Chr(15))
            Filewrite.WriteLine("{0,-12}{1,-20}", Chr(14) & Chr(15) & "LOCATION :", gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & servicelocation & "'") & Space(10) & "OP.BAL:" & MemberOutstand)
            Filewrite.Write(Chr(18) & "BILLNO:" & Trim(BillNo))
            Filewrite.Write(" DATE:" & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy"))
            Filewrite.WriteLine(Chr(15) & " TIME:" & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "T") & Chr(18))
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Filewrite.WriteLine(Chr(18) & "SLNO KOTNO   ITEM DESCRIPTION     QTY   RATE   AMOUNT")
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            'HEADING END
            TotalAmount = 0 : TaxAmount = 0
            CountItem = 0
            For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                CountItem = CountItem + 1
                With gdataset.Tables("ReportTable").Rows(rowj)
                    Filewrite.Write(Chr(18) & Space(3 - Len(Mid(Format(CountItem, "0"), 1, 3))) & Mid(Format(CountItem, "0"), 1, 3))
                    Filewrite.Write(Space(1) & Mid(Trim(.Item("KOTNO") & ""), 1, 8) & Space(8 - Len(Mid(Trim(.Item("KOTNO") & ""), 1, 8))))
                    Filewrite.Write(Space(1) & Mid(Trim(.Item("ITEMDESC") & ""), 1, 20) & Space(20 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 20))))
                    Filewrite.Write(Space(1) & Space(3 - Len(Mid(Format(Val(.Item("QTY") & ""), "0"), 1, 3))) & Mid(Format(Val(.Item("QTY") & ""), "0"), 1, 3))
                    Filewrite.Write(Space(1) & Space(7 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 7))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 7))
                    Filewrite.WriteLine(Space(1) & Space(7 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 7))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 7))
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                End With
            Next rowj
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine(Chr(18))
            Rowprint = "Total" & Chr(14) & Chr(15) & Space(33) & Space(8 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 8)
            Filewrite.WriteLine(Rowprint & Chr(18))
            sqlstring = "select isnull(sum(a.taxamount),0) as Taxamount,a.taxcode,b.itemtypedesc from bill_det a,"
            sqlstring = sqlstring & "itemtypemaster b where a.taxcode=b.taxcode and isnull(a.delflag,'')<>'Y' AND "
            sqlstring = sqlstring & " a.taxamount>0 AND a.billdetails='" & Trim(txt_KOTno.Text) & "'"
            sqlstring = sqlstring & "  group by a.taxcode,b.itemtypedesc"
            gconnection.getDataSet(sqlstring, "TaxDet")
            'TAX PRINT
            For i = 0 To gdataset.Tables("TaxDet").Rows.Count - 1
                Filewrite.Write(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15) & Space(21 - Len(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15))))
                Rowprint = Chr(14) & Chr(15) & Space(21) & Space(6 - Len(Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 6))) & Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 6)
                Filewrite.WriteLine(Rowprint & Chr(18))
            Next
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine("")

            If i = 0 Then
                Rowprint = Chr(18) & "Net Amount"
            Else
                Rowprint = Chr(18) & Space(11)
            End If
            Rowprint = "Net Amount" & Space(15) & Space(31 - Len(Rowprint)) & Chr(14) & Chr(15) & Space(8 - Len(Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8)
            Filewrite.WriteLine(Rowprint)
            Call bill_roundoff()
            Rowprint = Chr(18) & "Round Off" & Space(35) & Chr(14) & Chr(15) & Space(8 - Len(Mid(Trim(Format(Amt, "0.00")), 1, 8))) & Mid(Trim(Format(Amt, "0.00")), 1, 8) & Chr(18)
            'If Amt <> 0 Then
            Filewrite.WriteLine(Rowprint)
            'End If
            'Filewrite.Write(Chr(45))
            'Filewrite.Write(Chr(18))
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Rowprint = Mid(Chr(18) & "BILL AMOUNT:", 1, 25) & Space(25 - Len(Mid("BILL AMOUNT:", 1, 25))) & Space(20)
            If Amt < 0 Then
                Rowprint = Rowprint & Chr(14) & Chr(15) & Format(Val((TaxAmount + TotalAmount)) - Val(Amt * -1), "0.00")
            Else
                Rowprint = Rowprint & Chr(14) & Chr(15) & Format(Val((TaxAmount + TotalAmount)) + Val(Amt), "0.00")
            End If
            Filewrite.WriteLine(Rowprint)
            taxcount = taxcount + 1
            Vrowcount = Vrowcount + 1
            Filewrite.Write(Chr(18))
            For i = 0 To 54
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Dim sstring As String
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine(Chr(18) & "Members Sign                      Bearer Sign")
            Filewrite.WriteLine(Space(35) & Mid(Trim(LTrim(SNAME)), 1, 15) & Space(15 - Len(Mid(Trim(LTrim(SNAME)), 1, 15))))
            Filewrite.WriteLine("Prepared By :" & Space(10 - Len(Mid(adduserid, 1, 10))) & Mid(Trim(adduserid), 1, 10))
            Filewrite.WriteLine("")
            Filewrite.WriteLine("                 THANK YOU VISIT AGAIN")
            If Trim(Txt_Remarks.Text) <> "" Then
                If Len(Trim(Txt_Remarks.Text)) < 65 Then
                    Filewrite.Write("             " & Trim(Txt_Remarks.Text))
                    Vrowcount = Vrowcount + 1
                    taxcount = taxcount + 1
                Else
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                    Filewrite.Write("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                    Vrowcount = Vrowcount + 2
                    taxcount = taxcount + 2
                End If
            Else
            End If
            For i = 0 To 10
                Filewrite.WriteLine("")
            Next
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(vFilepath)
            End If
        Else
            MessageBox.Show("Invalid BillNo or Bill is not Yet generated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
    End Sub
    Private Sub txt_KOTno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_KOTno.LostFocus
        Try
            Dim STRSQL As String
            Call CMD_LOCK()
            'If Trim(txt_KOTno.Text) <> "" Then
            '    STRSQL = "SELECT * FROM KOT_HDR WHERE KOTDETAILS='" & txt_KOTno.Text & "'"
            '    gconnection.getDataSet(STRSQL, "KOTNO")
            '    If gdataset.Tables("KOTNO").Rows.Count = 0 Then
            '        STRSQL = " Select isnull(Prefix,'') as Prefix,isnull(Servercode,'') as Servercode From Kotbook "
            '        STRSQL = STRSQL & "  Where  " & IIf(Val(txt_KOTno.Text) > 0, Val(txt_KOTno.Text), 0) & " between snofrom and  snoto "
            '        gconnection.getDataSet(STRSQL, "servermaster")
            '        If gdataset.Tables("servermaster").Rows.Count > 0 Then
            '            txt_ServerCode.Text = gdataset.Tables("servermaster").Rows(0).Item("Servercode")
            '            txt_ServerCode_Validated(sender, e)
            '        End If
            '    End If
            '    Call CMD_LOCK()
            '    txt_MemberCode.Focus()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CMB_BTYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_BTYPE.SelectedIndexChanged
        Dim LOC, strstring As String
        LOC = Trim(CMB_BTYPE.Text)
        strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y'  AND ISNULL(DOCTYPE,'')='" & Trim(LOC) & "'"
        gconnection.getDataSet(strstring, "LOCmaster")
        If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
            LOC_TXT.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
            lab_servicename.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosName")
            POScode = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
            StrPOSCODE = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
            ssGrid.SetActiveCell(1, 1)
            ssGrid.Focus()
            FillBillPrefix()
            Call autogenerate()
            Call ShowBillno()
        Else
            lab_servicename.Text = ""
            LOC_TXT.Text = ""
            POScode = ""
            StrPOSCODE = ""
        End If
    End Sub
    Private Sub cmd_recall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_recall.Click
        If UCase(Trim(gUsername)) = "ADMIN" Then
            chkbool = True
            If chkbool = False Then Exit Sub
            Dim sqlstring, Delete(0) As String
            Dim dt As New DataTable
            sqlstring = "SELECT ISNULL(BillStatus,'PO') As BillStatus,ISNULL(Crostatus,'N') As Crostatus,ISNULL(PostingStatus,'N') as PostingStatus FROM Kot_Hdr WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
            dt = gconnection.GetValues(sqlstring)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("PostingStatus") = "Y" Then
                    If MsgBox("The KotAmount Is Already Posted To Accounts,Deleting This Kot Also Reflects In Accounts,Are U Sure To Delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Call DeleteOperation()
                        Exit Sub
                    Else
                        Call cmd_Clear_Click(cmd_Clear, e)
                        Exit Sub
                    End If
                ElseIf dt.Rows(0).Item("CRostatus") = "Y" Then
                    If MsgBox("The KotAmount Is Already Posted To Cro,Deleting This Kot Also Reflects In Cro,Are U Sure To Delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Call DeleteOperation()
                        Exit Sub
                    Else
                        Call cmd_Clear_Click(cmd_Clear, e)
                        Exit Sub
                    End If
                Else

                    sqlstring = " UPDATE KOT_HDR SET DELFLAG = 'N' WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    Delete(0) = sqlstring
                    sqlstring = " UPDATE KOT_DET SET DELFLAG = 'N' WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring

                    sqlstring = " UPDATE SUBSTORECONSUMPTIONDETAIL SET VOID = 'N' WHERE DOCDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring

                    sqlstring = " UPDATE BILL_HDR SET DELFLAG = 'N' WHERE BILLDETAILS='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring

                    sqlstring = " UPDATE BILL_DET SET DELFLAG = 'N' WHERE BILLDETAILS='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring

                    sqlstring = " UPDATE BILLSETTLEMENT SET DELFLAG = 'N' WHERE BILLNO='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring

                    sqlstring = "SELECT ISNULL(KOTDETAILS,'') AS KOTDETAILS,KOTDATE,ISNULL(VOUCHERNO,'') AS VOUCHERNO,ISNULL(POSTINGSTATUS,'') As POSTINGSTATUS FROM KOT_HDR  WHERE KOTDETAILS='" & Trim(CStr(Me.txt_KOTno.Text)) & "' AND PAYMENTTYPE <> 'CREDIT'"
                    gconnection.getDataSet(sqlstring, "KOTHDR")
                    If gdataset.Tables("KOTHDR").Rows.Count > 0 Then
                        sqlstring = " UPDATE KOT_HDR SET VOUCHERNO = '',POSTINGSTATUS = 'N' WHERE KOTDETAILS='" & Trim(CStr(gdataset.Tables("KOTHDR").Rows(0).Item("VOUCHERNO"))) & "'"
                        ReDim Preserve Delete(Delete.Length)
                        Delete(Delete.Length - 1) = sqlstring
                        sqlstring = " UPDATE JOURNALENTRY SET VOID = 'Y' WHERE VOUCHERNO='" & Trim(CStr(gdataset.Tables("KOTHDR").Rows(0).Item("VOUCHERNO"))) & "'"
                        ReDim Preserve Delete(Delete.Length)
                        Delete(Delete.Length - 1) = sqlstring
                        sqlstring = " UPDATE OUTSTANDING SET VOID = 'Y' WHERE VOUCHERNO='" & Trim(CStr(gdataset.Tables("KOTHDR").Rows(0).Item("VOUCHERNO"))) & "'"
                        ReDim Preserve Delete(Delete.Length)
                        Delete(Delete.Length - 1) = sqlstring
                    End If
                    gconnection.MORETRANS(Delete)

                    sqlstring = " UPDATE JOURNALENTRY SET VOID = 'N' WHERE VOUCHERNO='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring
                    sqlstring = " UPDATE OUTSTANDING SET VOID = 'N' WHERE VOUCHERNO='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring

                    gconnection.MORETRANS(Delete)
                    Call txt_MemberCode_Validated(sender, e)

                    Call cmd_Clear_Click(cmd_Clear, e)
                End If
            Else
                MessageBox.Show("Plz Enter a Valid KOTno", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Call cmd_Clear_Click(cmd_Clear, e)
                Exit Sub
            End If
        Else
            MsgBox("Not allowed to recall pls contact concern people....")
        End If
    End Sub
    'CSC CMARTCARD
    Private Sub lbl_SwipeCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_SwipeCard.Click
        Dim CARDID As Object
        txt_card_id.Text = CARDID
        Call txt_card_id_Validated(sender, e)
    End Sub
    'CSC CMARTCARD
    Private Sub txt_card_id_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_card_id.Validated
        Dim SQLSTRING As String
        If Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
            MessageBox.Show("PLEASE! SWIPE YOUR CARD", "CARD NOT SWIPED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lbl_SwipeCard.Visible = False
            txt_card_id.Focus()
            'LAB_CARDBAL.Text = ""
            ' LAB_CARDBAL.Visible = False
            'lbl_SwipeCard.Focus()
            Exit Sub
        Else
            SQLSTRING = "SELECT * FROM SM_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
            SQLSTRING = SQLSTRING & " UNION SELECT * FROM SM_AFF_TEMP_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL'"
            gconnection.getDataSet(SQLSTRING, "SM_MEM_LINKAGE")

            'CHECKING IN GLOBAL FUNCTION (DD,MM,YYYY REMOVE AND CHECK IN txt_card_id)

            Call CardIdValidate(Trim(txt_card_id.Text))
            If gdataset.Tables("SM_MEM_LINKAGE").Rows.Count > 0 Then
                CARDCODE = gdataset.Tables("SM_MEM_LINKAGE").Rows(0).Item("CARDCODE")
            ElseIf Cardidcheck = True Then
                CARDCODE = Trim(vCardcode)
                vCardcode = ""
            Else
                If cbo_PaymentMode.Text = "SMART CARD" Then
                    MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    lbl_SwipeCard.Visible = False
                    txt_card_id.Focus()
                    '                    lbl_SwipeCard.Focus()
                    Exit Sub
                End If
            End If

            SQLSTRING = "SELECT * FROM SM_CARDFILE_HDR WHERE CARDCODE='" & CARDCODE & "' "
            gconnection.getDataSet(SQLSTRING, "SM_CARDFILE_HDR")
            If gdataset.Tables("SM_CARDFILE_HDR").Rows.Count > 0 Then
                'CHECKING ACTIVATION FLAG IS 'Y' OR 'N'
                Dim temp_flag As Char
                temp_flag = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ACTIVATION_FLAG")
                If temp_flag <> "Y" Then
                    MessageBox.Show("Sorry!  Your Card Not Activated. " & ControlChars.CrLf & "Contact Smart Card Administration", "Validity Expires", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    txt_card_id.Clear()
                    txt_card_id.Focus()
                    '                    lbl_SwipeCard.Focus()
                    Exit Sub
                End If
                'DISPLAY BALNACE AMOUNT
                BALANCE_HDR = Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00")
                LAB_CARDBAL.Text = "CARD BALANCE :" & Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00")
                LBL_CARD_BALANCE.Text = "CARD BALANCE :" & Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00")

                'MIN_USAGE_BALANCE_HDR = Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("MIN_USG_BALANCE")), "0.00")
            Else
                'MessageBox.Show("Sorry! CARD EXPIRED " & ControlChars.CrLf & "Contact Smart Card Administration", "Validity Expires", MessageBoxButtons.OK)
                If txt_card_id.Text <> "" Then
                    MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_card_id.Text = ""
                    txt_card_id.Focus()
                End If
            End If
            'GNC
            'KARTHI CHECK IF SWIPED IN RECEPTION, ALLOW ONLY IF SWIPED MAY 31
            SQLSTRING = "SELECT CARDCODE FROM SM_MEMBERENTRY_LOG WHERE CARDCODE='" & CARDCODE & "' AND CAST(CONVERT(VARCHAR(11),DATETIME,6) AS DATETIME ) = '" & Format(Date.Now, "dd/MMM/yyyy") & "'"
            gconnection.getDataSet(SQLSTRING, "SM_MEMBERENTRY_LOG")
            If gdataset.Tables("SM_MEMBERENTRY_LOG").Rows.Count = 0 Then
                'If MessageBox.Show("SORRY! GET ACCESS AT RECEPTION", "GET ACCESS AT RECEPTION", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                '    txt_card_id.Clear()
                '    lbl_SwipeCard.Focus()
                '    Exit Sub
                'End If
            End If

            'If cardcode = "FORGOTTEN" Then

            'End If
            'If cbo_PaymentMode.Text = "SMART CARD" Then
            Call DISPLAYINF()
            If txt_card_id.Text <> "" Then
                txt_MemberCode_Validated(sender, e)
                '//txt_KOTno.Focus()
                If cbo_PaymentMode.Text = "ROOM" Then
                    txt_ServerCode.Focus()
                Else
                    cbo_PaymentMode.Focus()
                End If
            End If

            'End If
        End If
    End Sub
    Public Function DISPLAYINF()
        Dim i As Integer
        Dim sqlstring1, sqlstring2, SQLSTRING, subcode, mcode As String
        'CHECKING AND DISPLAYING RECORDS FROM SM_CARDFILE_HDR
        SQLSTRING = "SELECT isnull(MEMBERCODE,'') AS MEMBERCODE, ISNULL(MEMBERSUBCODE,'') AS  MEMBERSUBCODE, ISNULL(CARDCODE,'')AS CARDCODE, ISNULL(FANCYCODE,'')AS FANCYCODE,ISNULL(PASSWORD,'')AS PASSWORD, "
        SQLSTRING = SQLSTRING & " ISNULL(ACTIVATION_FLAG,'')AS ACTIVATION_FLAG, ISNULL(ISSUETYPE,'')AS ISSUETYPE,ISNULL(VALID_FROM,'')AS VALID_FROM,ISNULL(VALID_TO,'')AS VALID_TO,ISNULL(NAME,'')AS NAME,  ISNULL(CARDHOLDERNAME,'')AS CARDHOLDERNAME, ISNULL(AGE,0)AS AGE, ISNULL(DOB,'')AS DOB, ISNULL(TRANSACTION_TYPE,'')AS TRANSACTION_TYPE, ISNULL(AMOUNT,0)AS AMOUNT, ISNULL(BALANCE,0)AS BALANCE "
        SQLSTRING = SQLSTRING & " FROM SM_CARDFILE_HDR WHERE CARDCODE='" & CARDCODE & "'"
        gconnection.getDataSet(SQLSTRING, "SM_CARDFILE_HDR")
        If gdataset.Tables("SM_CARDFILE_HDR").Rows.Count > 0 Then
            'CHECKING ACTIVATION FLAG IS 'Y' OR 'N'
            If gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("MEMBERSUBCODE") = "TE" Then
                Dim index As Integer
                index = cbo_PaymentMode.FindString("ROOM")
                cbo_PaymentMode.SelectedIndex = index
            End If

            Dim temp_flag As Char
            temp_flag = ""
            temp_flag = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ACTIVATION_FLAG")
            If temp_flag <> "Y" Then
                If cbo_PaymentMode.Text = "SMART CARD" Then
                    MessageBox.Show("SORRY! CARD IS DEACTIVATED", "CARD DEACTIVATED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    lbl_SwipeCard.Visible = False
                    txt_card_id.Clear()
                    txt_card_id.Focus()
                    '                    lbl_SwipeCard.Focus()
                    Exit Function
                End If
            End If
            Dim todate As DateTime
            todate = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("VALID_TO")
            If Date.Today > todate Then
                MessageBox.Show("SORRY! CARD IS OUT OF VALIDITY DATE", "CARD EXPIRED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = False
                txt_card_id.Clear()
                txt_card_id.Focus()
                '                lbl_SwipeCard.Focus()
                Exit Function
            End If
            Dim ACCESS_CTL As String
            Dim strsql, STRSQL2 As String
            strsql = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & CARDCODE & "' AND POSCODE='" & StrPOSCODE & "'"
            gconnection.getDataSet(strsql, "SM_CARDFILE_DET")
            If gdataset.Tables("SM_CARDFILE_DET").Rows.Count > 0 Then
                STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "'"
                gconnection.getDataSet(STRSQL2, "POSMASTER")
                If gdataset.Tables("POSMASTER").Rows.Count > 0 Then
                    POSNAME_GBL = gdataset.Tables("POSMASTER").Rows(0).Item("POSDESC")
                End If
                ACCESS_CTL = gdataset.Tables("SM_CARDFILE_DET").Rows(0).Item("POS_ACCESS")
                If ACCESS_CTL = "N" Then
                    MessageBox.Show("SORRY! YOU HAVE NO RIGHTS TO USE THE POS FACILITY", "ACCESS BLOCKED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_card_id.Clear()
                    txt_card_id.Focus()
                    '                    lbl_SwipeCard.Focus()
                    Exit Function
                End If
            Else
                MessageBox.Show(" PLEASE GET POS VALIDITY", "NO RIGHTS FOR POS USAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_card_id.Clear()
                txt_card_id.Focus()
                '                lbl_SwipeCard.Focus()
                Exit Function
            End If
            'CHECKING ACTIVATION FLAG ENDS

            txt_MemberCode.Text = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("MEMBERCODE")
            txt_MemberCode.ReadOnly = True
            MCODE_GBL = Trim(txt_MemberCode.Text)
            'txt_MemberName.Text = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("NAME")
            NAME_GBL = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("NAME")

            gconnection.getDataSet("SELECT MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(MCODE_GBL) & "'", "MEMBERMASTER")
            If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                MNAME_GBL = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MNAME")
                txt_MemberName.Text = MNAME_GBL
            End If
            'KARTHI JUNE 13
            'KARTHI JUNE 13
            If gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "MEM" Or gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TE" Then
                gconnection.getDataSet("SELECT MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(MCODE_GBL) & "'", "MEMBERMASTER")
                If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                    MNAME_GBL = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MNAME")
                    txt_MemberName.Text = MNAME_GBL
                    Dim msgres As String
                    msgres = creditstop(txt_MemberCode.Text)
                    If txt_card_id.Text <> "" And txt_MemberCode.Text <> "" Then
                        If Mid(msgres, 1, 1) = "C" Then
                            If cbo_PaymentMode.Text = "CREDIT" Or cbo_PaymentMode.Text = "PARTY" Then
                                MsgBox("Current Status is " & msgres & ",Kindly Use Cash/SmartCard", MsgBoxStyle.Information, "Info")
                                cbo_PaymentMode.Focus()
                                Exit Function
                            End If
                        ElseIf Mid(msgres, 1, 1) = "D" Then
                            MsgBox("Current Status is " & msgres & ",Sorry You Can Not Make Any Kot", MsgBoxStyle.Information, "Info")

                            Exit Function
                        End If
                    End If


                End If
            ElseIf gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TA" Then
                lbl_Membercode.Text = "CLUB CODE"
                lbl_MemberName.Text = "CLUB NAME"
                gconnection.getDataSet("SELECT CLUBNAME FROM AFFILIATEDCLUBDETAILS WHERE CLUBCODE='" & Trim(MCODE_GBL) & "'", "AFFILIATEDCLUBDETAILS")
                If gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows.Count > 0 Then
                    MNAME_GBL = gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CLUBNAME")
                    txt_MemberName.Text = MNAME_GBL
                End If
            End If
            'karthi jun2
            txt_Holder_Code.Text = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("cardcode")
            'karthi NOV 08
            'Txt_holder_name.Text = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("name")
            'CARDHOLDER NAME 
            Txt_holder_name.Text = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("CARDHOLDERNAME")
            'karthi NOV 08
            lbl_SwipeCard.Visible = False
            If ACCESS_CHECK_GBL = True Then
                ''KARTHI HIDE ACCESS CHECK AT RECEPTION 
                SQLSTRING = "SELECT CARDCODE FROM SM_MEMBERENTRY_LOG WHERE CARDCODE='" & Trim(txt_Holder_Code.Text) & "' AND CAST(CONVERT(VARCHAR(11),DATETIME,6) AS DATETIME ) = '" & Format(Date.Now, "dd/MMM/yyyy") & "'"
                gconnection.getDataSet(SQLSTRING, "SM_MEMBERENTRY_LOG")
                If gdataset.Tables("SM_MEMBERENTRY_LOG").Rows.Count = 0 Then
                    MessageBox.Show("SORRY! GET ACCESS AT RECEPTION", "GET ACCESS AT RECEPTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_card_id.Clear()
                    txt_card_id.Focus()
                    txt_MemberCode.Clear()
                    txt_MemberName.Clear()
                    Txt_holder_name.Clear()
                    txt_Holder_Code.Clear()
                    Exit Function
                End If
            End If
            ''CHECKING AND DISPLAYING RECORDS FROM MEMBERMASTER
            Dim PHOTOFILENAME As String
            If Mid(Trim(txt_Holder_Code.Text), Len(Trim(txt_Holder_Code.Text)) - 1, 2) = "00" Then
                '                PHOTOFILENAME = STRPHOTOPATH & "\" & Mid(Trim(txt_Holder_Code.Text), 1, Len(Trim(txt_Holder_Code.Text)) - 3) & ".jpg"
                '               PHOTOFILENAME = Replace(PHOTOFILENAME, " ", "")

                '                If File.Exists(PHOTOFILENAME) Then
                '               Pic_Member.Image = New Bitmap(PHOTOFILENAME)
                '          Else
                '             Pic_Member.Image = New Bitmap(AppPath & "\IMAGE.Jpg")
                '        End If
            Else
                '            PHOTOFILENAME = STRPHOTOPATH & "\" & Trim(txt_Holder_Code.Text) & ".jpg"
                '            PHOTOFILENAME = Replace(PHOTOFILENAME, " ", "")

                '                If File.Exists(PHOTOFILENAME) Then
                '                Pic_Member.Image = New Bitmap(PHOTOFILENAME)
                '                Else
                '                    Pic_Member.Image = New Bitmap(AppPath & "\IMAGE.Jpg")
                '                End If
            End If

            'Show PHOTOS
            If gFoto = "Y" Then
                gconnection.LoadFoto_DB(txt_card_id, Pic_Member)
            Else
                If gShortName = "MCC" Then
                    gconnection.FOTO_LOAD_MCC(txt_card_id, Pic_Member)
                ElseIf gShortName = "NIZAM" Then
                    gconnection.Foto_LOAD_NIZAM(txt_card_id, Pic_Member)
                Else
                    gconnection.Foto_LOAD(txt_card_id, Pic_Member)
                End If

            End If

            'cbo_PaymentMode.Focus()
            txt_ServerCode.Focus()
        Else
            If cbo_PaymentMode.Text = "SMART CARD" Then
                MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = False
                txt_card_id.Clear()
                '            txt_card_id.Focus()
                cbo_PaymentMode.Focus()
                '            lbl_SwipeCard.Focus()
            End If
        End If
    End Function
    Private Sub Cmd_DC_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_DC_Update.Click
        'SMART CARD JUNE 10
        'SMART CARD KARTHI JUNE 3
        Dim sqlstring, SSTR As String
        sqlstring = "SELECT * FROM POSMASTER WHERE POSCODE='" & Trim(StrPOSCODE) & "' AND STORESTATUS='F' "
        gconnection.getDataSet(sqlstring, "POSMASTER")
        If gdataset.Tables("POSMASTER").Rows.Count > 0 Then
            POSNAME_GBL = gdataset.Tables("POSMASTER").Rows(0).Item("POSDESC")
            SSTR = "SELECT * FROM SM_POSTRANSACTION WHERE BILL_NO='" & Trim(txt_KOTno.Text) & "' AND ISNULL(VOID,'N')<>'Y' "
            gconnection.getDataSet(SSTR, "SM_POSTRANSACTION")
            KOT_NO_GBL = Trim(txt_KOTno.Text)
            POScode = Trim(POScode)
            PAYMENTMODE_GBL = cbo_PaymentMode.Text
            If gdataset.Tables("SM_POSTRANSACTION").Rows.Count > 0 Then
                Dim DE_TRA_AMEND As New DEBIT_CARD_TRANSACTION
                D_CARDUPDATE = True
                DE_TRA_AMEND.Show()
            Else
                Dim DE_TRA As New DEBIT_CARD_TRANSACTION
                D_CARDUPDATE = False
                DE_TRA.Show()
                Exit Sub
            End If
        End If
        'SMART CARD 
    End Sub
    Private Sub Cmd_DC_Update_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmd_DC_Update.KeyDown
        Call Cmd_DC_Update_Click(sender, e)
    End Sub
    'CSC SMARTCARD
    ' karthi oct 23
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Dim INDEX As Integer
        ''        If cbo_PaymentMode.Text = "SMART CARD" Then
        'If ttime = 0 Or ttime <> 2 Then
        '    '    Lbl_SwipeCard.Visible = False
        '    ttime = 2
        '    '            ElseIf ttime = 2 And Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
        'ElseIf ttime = 2 And Trim(txt_card_id.Text) = "" Then
        '    'lbl_SwipeCard.Visible = FALSE
        '    txt_card_id.Focus()
        '    '                GetSMART_CARDID()
        '    DLLSELECT()
        '    txt_card_id.Text = Trim(GBL_SMARTCARDSNO)
        '    If txt_card_id.Text <> "" Then
        '        Call txt_card_id_Validated(sender, e)
        '        ttime = 0
        '    Else
        '        INDEX = cbo_PaymentMode.FindString(DefaultPayment)
        '        cbo_PaymentMode.SelectedIndex = INDEX
        '    End If
        'End If
        ''       End If

        Try
            Dim INDEX As Integer
            If ttime = 0 Or ttime <> 2 Then
                '    Lbl_SwipeCard.Visible = False
                ttime = 2
            ElseIf ttime = 2 And Trim(txt_card_id.Text) = "" Then
                '   Lbl_SwipeCard.Visible = True
                txt_card_id.Focus()
                GetSMART_CARDID()
                txt_card_id.Text = Trim(GBL_SMARTCARDSNO)
                If txt_card_id.Text <> "" Then
                    Call txt_card_id_Validated(sender, e)
                    ttime = 0
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txt_MemberCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.GotFocus
        If txt_card_id.Text = "" And cbo_PaymentMode.Text = "SMART CARD" Then
            If MessageBox.Show(" PLEASE SWIPE THE CARD ", "SMART CARD", MessageBoxButtons.OKCancel + MessageBoxDefaultButton.Button2, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                txt_card_id.Focus()
            Else
                cbo_PaymentMode.Focus()
            End If
            '            lbl_SwipeCard.Focus()
        End If
    End Sub
    Private Sub cbo_PaymentMode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_PaymentMode.LostFocus
        'Dim INDEX As Integer
        'If Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
        '    txt_card_id.Focus()
        '    GetSMART_CARDID()
        '    txt_card_id.Text = Trim(GBL_SMARTCARDSNO)
        '    If txt_card_id.Text <> "" Then
        '        Call txt_card_id_Validated(sender, e)
        '        ttime = 0
        '    Else
        '        INDEX = cbo_PaymentMode.FindString(DefaultPayment)
        '        cbo_PaymentMode.SelectedIndex = INDEX
        '    End If
        'End If
    End Sub
    Private Sub balance()
        Dim sqlstring As String
        sqlstring = "SELECT isnull(MEMBERCODE,'') AS MEMBERCODE, ISNULL(MEMBERSUBCODE,'') AS  MEMBERSUBCODE, ISNULL(CARDCODE,'')AS CARDCODE, ISNULL(FANCYCODE,'')AS FANCYCODE,ISNULL(PASSWORD,'')AS PASSWORD, "
        sqlstring = sqlstring & " ISNULL(ACTIVATION_FLAG,'')AS ACTIVATION_FLAG, ISNULL(ISSUETYPE,'')AS ISSUETYPE,ISNULL(VALID_FROM,'')AS VALID_FROM,ISNULL(VALID_TO,'')AS VALID_TO,ISNULL(NAME,'')AS NAME, ISNULL(CARDHOLDERNAME,'')AS CARDHOLDERNAME, ISNULL(AGE,0)AS AGE, ISNULL(DOB,'')AS DOB, ISNULL(TRANSACTION_TYPE,'')AS TRANSACTION_TYPE, ISNULL(AMOUNT,0)AS AMOUNT, ISNULL(BALANCE,0)AS BALANCE "
        sqlstring = sqlstring & " FROM SM_CARDFILE_HDR WHERE CARDCODE='" & CARDCODE & "'"
        gconnection.getDataSet(sqlstring, "SM_CARDFILE_HDR")
        If gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "MEM" Or gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TE" Then
            gconnection.getDataSet("SELECT MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(MCODE_GBL) & "'", "MEMBERMASTER")
            If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                MNAME_GBL = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MNAME")
                Label5.Text = "Current Card Balance : " & Trim(Format(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE"), "0.00"))
                txt_MemberName.Text = MNAME_GBL
            End If
        ElseIf gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TA" Then
            lbl_Membercode.Text = "CLUB CODE"
            lbl_MemberName.Text = "CLUB NAME"
            gconnection.getDataSet("SELECT CLUBNAME FROM AFFILIATEDCLUBDETAILS WHERE CLUBCODE='" & Trim(MCODE_GBL) & "'", "AFFILIATEDCLUBDETAILS")
            If gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows.Count > 0 Then
                MNAME_GBL = gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CLUBNAME")
                txt_MemberName.Text = MNAME_GBL
            End If
        End If
    End Sub

    Private Sub Cmd_SwipeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_SwipeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = " select ISNULL(E.CARDCODE,'') CARDHOLDERCODE , ISNULL(CARDHOLDERNAME,'') CARDHOLDERNAME from sm_memberentry_log E ,SM_CARDFILE_HDR H "
        M_WhereCondition = " WHERE E.CARDCODE=H.CARDCODE AND CAST(Convert(varchar(11),DATETIME,6) AS DATETIME)='" & Format(CDate(dtp_KOTdate.Value), "yyyy-MM-dd") & "' "
        vform.Field = " E.CARDCODE,CARDHOLDERNAME "
        vform.vFormatstring = "     CARDHOLDERCODE                      |               CARDHOLDERNAME                          "
        vform.vCaption = "SWIPE CARD HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Holder_Code.Text = Trim(vform.keyfield & "")
            Call txt_Holder_Code_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_Holder_Code_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Holder_Code.Validated
        SQLSTRING = "SELECT  * from SM_ALLCARDS_VIEW WHERE CARDCODE='" & Trim(txt_Holder_Code.Text) & "'"
        gconnection.getDataSet(SQLSTRING, "SM_ALLCARDS_VIEW")
        If gdataset.Tables("SM_ALLCARDS_VIEW").Rows.Count > 0 Then
            txt_card_id.Text = Trim(gdataset.Tables("SM_ALLCARDS_VIEW").Rows(0).Item("16_DIGIT_CODE"))
            txt_card_id.Focus()
        End If
    End Sub
    Function cardcheck()
        Dim SQLSTRING As String
        SQLSTRING = "SELECT * FROM SM_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
        SQLSTRING = SQLSTRING & " UNION SELECT * FROM SM_AFF_TEMP_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
        gconnection.getDataSet(SQLSTRING, "SM_MEM_LINKAGE")
        'CHECKING IN GLOBAL FUNCTION (DD,MM,YYYY REMOVE AND CHECK IN txt_card_id)
        Call CardIdValidate(Trim(txt_card_id.Text))
        If gdataset.Tables("SM_MEM_LINKAGE").Rows.Count > 0 Then
            CARDCODE = gdataset.Tables("SM_MEM_LINKAGE").Rows(0).Item("CARDCODE")
        ElseIf Cardidcheck = True Then
            CARDCODE = Trim(vCardcode)
            vCardcode = ""
        Else
            If cbo_PaymentMode.Text = "SMART CARD" Then
                MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = False
                txt_card_id.Focus()
                '                lbl_SwipeCard.Focus()
                Exit Function
            End If
        End If

        SQLSTRING = "SELECT * FROM SM_CARDFILE_HDR WHERE CARDCODE='" & CARDCODE & "' "
        gconnection.getDataSet(SQLSTRING, "SM_CARDFILE_HDR")
        If gdataset.Tables("SM_CARDFILE_HDR").Rows.Count > 0 Then
            'CHECKING ACTIVATION FLAG IS 'Y' OR 'N'
            Dim temp_flag As Char
            temp_flag = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ACTIVATION_FLAG")
            If temp_flag <> "Y" Then
                MessageBox.Show("Sorry!  Your Card Not Activated. " & ControlChars.CrLf & "Contact Smart Card Administration", "Validity Expires", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                txt_card_id.Clear()
                txt_card_id.Focus()
                '                lbl_SwipeCard.Focus()
                Exit Function
            End If
            'DISPLAY BALNACE AMOUNT
            BALANCE_HDR = Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00")
            ' MIN_USAGE_BALANCE_HDR = Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("MIN_USG_BALANCE")), "0.00")

        Else
            MessageBox.Show("Sorry! CARD EXPIRED " & ControlChars.CrLf & "Contact Smart Card Administration", "Validity Expires", MessageBoxButtons.OK)
        End If
        'KARTHI CHECK IF SWIPED IN RECEPTION, ALLOW ONLY IF SWIPED MAY 31
        'SQLSTRING = "SELECT CARDCODE FROM SM_MEMBERENTRY_LOG WHERE CARDCODE='" & cardcode & "' AND CAST(CONVERT(VARCHAR(11),DATETIME,6) AS DATETIME ) = '" & Format(Date.Now, "dd/MMM/yyyy") & "'"
        'gconnection.getDataSet(SQLSTRING, "SM_MEMBERENTRY_LOG")
        'If gdataset.Tables("SM_MEMBERENTRY_LOG").Rows.Count = 0 Then
        '    MessageBox.Show("SORRY! GET ACCESS AT RECEPTION", "GET ACCESS AT RECEPTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_card_id.Clear()
        '    'txt_card_id.Focus()
        '    lbl_SwipeCard.Focus()
        '    Exit Function
        'End If
    End Function
    Private Sub txt_card_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_card_id.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(cbo_PaymentMode.Text) = "SMART CARD" Then
                Call txt_card_id_Validated(txt_card_id, e)
            Else
                'MsgBox("SELECT CORRECT PAYMENTMODE", MsgBoxStyle.Information)
                txt_card_id.Text = ""
                cbo_PaymentMode.Focus()
            End If
        End If
    End Sub
    Private Sub GetSmartId()
        Try
            Dim sender As Object, e As System.EventArgs
            If Request_Card() = True Then
                'Timer_Delay.Stop()
                If AntiCollu_Card() = "" Then
                    MsgBox("AntiCollusion Failed , CARD NOT VALID / DAMAGED ", MsgBoxStyle.Information, "SMARTCARD")
                    '   Timer_Delay.Start()
                    txt_card_id.Focus()
                    Exit Sub
                Else
                    txt_card_id.Text = GBL_SmartCardID
                    Call Reset_Card()
                    txt_card_id_Validated(sender, e)
                End If
            Else
                'Timer_Delay.Start()
                txt_card_id.Focus()
                Exit Sub
            End If
        Catch EX As Exception
            MsgBox("Smart Card Please......" & EX.Message)
        End Try
    End Sub
    Private Sub txt_card_id_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_card_id.GotFocus
        Try
            If gReaderType_code = 2 Then
                Timer1.Enabled = True
                Call GetSMARTDEVICEPORT()
            ElseIf gReaderType_code = 3 Then
                If Trim(txt_card_id.Text) = "" Then
                    Call GetSmartId()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_card_id_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_card_id.LostFocus
        If gReaderType_code = 2 Then
            Call CloseSmartDevicePort()
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub FACILITY()
        Try
            If grp_facility.Visible = False And txt_MemberCode.Text <> "" Then
                grp_facility.Visible = True
                CMD_FACILITY.Enabled = True
                Call fac_det()
                ssgrid_Fac.Focus()
            Else
                grp_facility.Visible = False
                ssGrid.Focus()
                CMD_FACILITY.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CMD_FACILITY1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub Facility_Print()
        Try
            Dim Sqlstring, GroupCode() As String
            Dim i, J As Integer
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            With ssgrid_Fac
                ' For i = 1 To ssgrid_Fac.DataRowCnt
                .Col = 2
                .Row = .ActiveRow
                If (.Text) <> "" Then
                    .Col = 5
                    .Row = .ActiveRow
                    ' If Val(.Text) > 0 Then
                    If gPrint = True Then
                        Filewrite.WriteLine(Chr(14) & Chr(27) + "E" & UCase(MyCompanyName) & Chr(27) + "F" & Chr(18))
                    Else
                        Filewrite.WriteLine(UCase(MyCompanyName))
                    End If
                    Filewrite.WriteLine(StrDup(40, "-"))
                    Filewrite.WriteLine("Date:" & Format(Now(), "dd/MM/yyyy") & "     Time:" & Format(Now(), "T"))
                    'Filewrite.WriteLine(Chr(15) & "/" & Trim(Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "T")) & Chr(18))
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("Mcode:" & Trim(txt_MemberCode.Text) & Space(1))
                    .Col = 2
                    .Row = .ActiveRow
                    If (.Text) <> "" Then
                        Filewrite.WriteLine("")
                        .Col = 1
                        .Row = .ActiveRow
                        If Trim(.Text) = "MM" Then
                            .Col = 2
                            .Row = .ActiveRow
                            Filewrite.WriteLine("M.NAME:" & Trim(.Text))
                        ElseIf Trim(.Text) = "SP" Then
                            .Col = 2
                            .Row = .ActiveRow
                            Filewrite.WriteLine("SPOUSE:" & Trim(.Text))
                        ElseIf Trim(.Text) = "SN" Then
                            .Col = 2
                            .Row = .ActiveRow
                            Filewrite.WriteLine("SON:" & Trim(.Text))
                        ElseIf Trim(.Text) = "DR" Then
                            .Col = 2
                            .Row = .ActiveRow
                            Filewrite.WriteLine("DAUGHTER:" & Trim(.Text))
                        ElseIf Trim(.Text) = "GT" Then
                            .Col = 2
                            .Row = .ActiveRow
                            Filewrite.WriteLine("GUEST:" & Trim(.Text))
                        End If
                    End If
                    Filewrite.WriteLine("")
                    '    End If
                    .Col = 4
                    .Row = .ActiveRow
                    If (.Text) <> "" Then
                        If gPrint = True Then
                            Filewrite.WriteLine("Facility:" & Chr(14) & Chr(27) + "E" & UCase(Trim(.Text)) & Chr(27) + "F" & Chr(18))
                            Filewrite.WriteLine(Space(10) & Chr(14) & Chr(27) + "E" & UCase("Member Admitted") & Chr(27) + "F" & Chr(18))
                        Else
                            Filewrite.WriteLine("Facility:" & UCase(Trim(.Text)))
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine(Space(10) & UCase("Member Admitted"))
                        End If
                    End If
                    Filewrite.WriteLine(StrDup(40, "-"))
                    For J = 0 To 5
                        Filewrite.WriteLine("")
                    Next
                End If
                ' Next
            End With
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(vOutfile)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ssgrid_Fac_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid_Fac.Advance

    End Sub
    Private Sub ssgrid_Fac_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid_Fac.KeyDownEvent
        Try
            Dim ssql, TYPE, name As String
            Dim I As Integer
            If e.keyCode = Keys.F3 Then
                SSGRIND1.ClearRange(1, 1, -1, -1, True)
                PNL_FACILITY.Visible = False
                ssgrid_Fac.Row = ssgrid_Fac.ActiveRow
                ssgrid_Fac.ClearRange(1, ssgrid_Fac.ActiveRow, 1, ssgrid_Fac.ActiveRow, True)
                ssgrid_Fac.DeleteRows(ssgrid_Fac.ActiveRow, 1)
                'If ssgrid_Fac.Row > 1 Then
                '   ssgrid_Fac.ActiveRow = ssgrid_Fac.Row - 1
                ssgrid_Fac.SetActiveCell(1, ssgrid_Fac.ActiveRow)
                'End If
                ssgrid_Fac.Focus()
            End If
            If e.keyCode = Keys.Enter Then
                With ssgrid_Fac
                    If .ActiveCol = 1 Then
                        .Col = 1
                        .Row = .ActiveRow
                        TYPE = .Text
                        If Trim(.Text) = "" Then
                            Call FILLTYPE()
                        Else
                            ssql = "SELECT FCODE,FNAME FROM FACILITYTYPE WHERE FCODE='" & Trim(.Text) & "'"
                            gconnection.getDataSet(ssql, "FTYPE")
                            If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                                MessageBox.Show("MISMATCH FACILITY CODE,KINDLY CHECK.", gCompanyname, MessageBoxButtons.OK)
                                .Text = ""
                                .Col = 1
                                .Row = .ActiveRow
                                .Focus()
                                Exit Sub
                            Else
                                ssql = "SELECT CNAME FROM FACILITY_MEMDET WHERE MCODE='" & txt_MemberCode.Text & "' AND TYPE='" & TYPE & "'"
                                gconnection.getDataSet(ssql, "FTYPE")
                                SSGRIND1.ClearRange(1, 1, -1, -1, True)
                                SSGRIND1.SetActiveCell(1, 1)
                                If gdataset.Tables("FTYPE").Rows.Count > 1 Then
                                    For I = 0 To gdataset.Tables("FTYPE").Rows.Count - 1
                                        With SSGRIND1
                                            .Col = 1
                                            .Row = I + 1
                                            .Text = gdataset.Tables("FTYPE").Rows(I).Item("CNAME")
                                        End With
                                    Next
                                    PNL_FACILITY.Visible = True
                                    SSGRIND1.SetActiveCell(1, 1)
                                    SSGRIND1.Focus()
                                ElseIf gdataset.Tables("FTYPE").Rows.Count = 1 Then
                                    ssgrid_Fac.Col = 2
                                    ssgrid_Fac.Row = .ActiveRow
                                    ssgrid_Fac.Text = gdataset.Tables("FTYPE").Rows(0).Item("CNAME")
                                End If
                            End If
                            If (.Text) = "GT" Then
                                .Col = 2
                                .Row = .ActiveRow
                                .Lock = False
                                .Focus()
                            Else
                                .Col = 2
                                .Row = .ActiveRow
                                .Lock = True
                                ssgrid_Fac.Focus()
                                If PNL_FACILITY.Visible = True Then
                                    SSGRIND1.Focus()
                                End If
                            End If
                        End If
                    ElseIf .ActiveCol = 2 Then
                        .Col = 1
                        .Row = .ActiveRow
                        TYPE = Trim(.Text)
                        .Col = 2
                        .Row = .ActiveRow
                        If Trim(.Text) = "" Then
                            Call FILLDEPT(TYPE)
                        Else
                            If TYPE <> "GT" Then
                                ssql = "SELECT CNAME,RELATION FROM FACILITY_MEMDET WHERE CNAME='" & Trim(.Text) & "'"
                                gconnection.getDataSet(ssql, "FTYPE")
                                If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                                    MessageBox.Show("MISMATCH NAME,KINDLY CHECK.", gCompanyname, MessageBoxButtons.OK)
                                    .Text = ""
                                    .Col = 2
                                    .Row = .ActiveRow
                                    .Focus()
                                    Exit Sub
                                End If
                            End If
                        End If
                        .Col = 1
                        .Row = .ActiveRow
                        If (.Text) = "GT" Then
                            ssgrid_Fac.SetActiveCell(2, ssgrid_Fac.ActiveRow)
                            ssgrid_Fac.Lock = False
                            ssgrid_Fac.Focus()
                        Else
                            .Col = 2
                            .Row = .ActiveRow
                            'ssgrid_Fac.SetActiveCell(2, ssgrid_Fac.ActiveRow)
                            ssgrid_Fac.Lock = True
                        End If
                    ElseIf .ActiveCol = 3 Then
                        .Col = 2
                        .Row = .ActiveRow
                        name = Trim(.Text)
                        .Col = 3
                        .Row = .ActiveRow
                        If Trim(.Text) = "" And name <> "" Then
                            Call FACILITY(name)
                        Else
                            If name <> "" Then
                                ssql = "SELECT ISNULL(SUBSDESC,'') AS SUBSDESC FROM SUBSCRIPTIONMAST WHERE SUBSCODE='" & Trim(.Text) & "'"
                                gconnection.getDataSet(ssql, "FTYPE")
                                If gdataset.Tables("FTYPE").Rows.Count <= 0 Then
                                    MessageBox.Show("MISMATCH FACILITY CODE,KINDLY CHECK.", gCompanyname, MessageBoxButtons.OK)
                                    .Col = 3
                                    .Row = .ActiveRow
                                    .Text = ""
                                    .Focus()
                                    Exit Sub
                                Else
                                    .Col = 4
                                    .Row = .ActiveRow
                                    .Text = gdataset.Tables("FTYPE").Rows(0).Item("SUBSDESC")
                                End If
                            Else
                                .Col = 3
                                .Row = .ActiveRow
                                .Text = ""
                                .Focus()
                            End If
                        End If
                    ElseIf .ActiveCol = 5 Then
                        .Col = 5
                        .Row = .ActiveRow
                        .Focus()
                    End If
                End With
            End If
            If e.keyCode = Keys.F4 Then
                With ssgrid_Fac
                    If .ActiveCol = 2 Then
                        .Col = 1
                        .Row = .ActiveRow
                        TYPE = Trim(.Text)
                        .Col = 2
                        Call FILLDEPT(TYPE)
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FILLDEPT(ByVal TYPE As String)
        Try
            Dim vform As New ListOperattion1
            Dim ssql As String
            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
            gSQLString = "SELECT CNAME,RELATION FROM FACILITY_MEMDET  "
            If Trim(Search) = " " Then
                M_WhereCondition = " WHERE MCODE='" & txt_MemberCode.Text & "' AND TYPE='" & TYPE & "'"
            Else
                M_WhereCondition = " WHERE MCODE='" & txt_MemberCode.Text & "' AND TYPE='" & TYPE & "'"
            End If
            vform.Field = "CNAME,RELATION"
            vform.vFormatstring = "                    NAME                                  |                   RELATION                         | "
            vform.vCaption = "NAME  HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                With ssgrid_Fac
                    .Col = 2
                    .Row = .ActiveRow
                    .Text = vform.keyfield
                End With
            Else
                ssgrid_Fac.SetActiveCell(0, ssgrid_Fac.ActiveRow)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FILLTYPE()
        Try
            Dim vform As New ListOperattion1
            Dim ssql As String
            Dim i As Integer
            gSQLString = "SELECT FCODE,FNAME FROM FACILITYTYPE  "
            If Trim(Search) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = ""
            End If
            vform.Field = "FCODE,FNAME"
            vform.vFormatstring = "                     CODE                 |                      NAME                           |"
            vform.vCaption = "NAME  HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                With ssgrid_Fac
                    .Col = 1
                    .Row = .ActiveRow
                    .Text = vform.keyfield
                    If (.Text) = "GT" Then
                        .Lock = False
                    Else
                        .Lock = True
                    End If

                    ssql = "SELECT CNAME FROM FACILITY_MEMDET WHERE MCODE='" & txt_MemberCode.Text & "' AND TYPE='" & vform.keyfield & "'"
                    gconnection.getDataSet(ssql, "FTYPE")
                    SSGRIND1.ClearRange(1, 1, -1, -1, True)
                    SSGRIND1.SetActiveCell(1, 1)
                    If gdataset.Tables("FTYPE").Rows.Count > 1 Then
                        For i = 0 To gdataset.Tables("FTYPE").Rows.Count - 1
                            With SSGRIND1
                                .Col = 1
                                .Row = i + 1
                                .Text = gdataset.Tables("FTYPE").Rows(i).Item("CNAME")
                            End With
                        Next
                        PNL_FACILITY.Visible = True
                        SSGRIND1.SetActiveCell(1, 1)
                        SSGRIND1.Focus()
                    ElseIf gdataset.Tables("FTYPE").Rows.Count = 1 Then
                        ssgrid_Fac.Col = 2
                        ssgrid_Fac.Row = .ActiveRow
                        ssgrid_Fac.Text = gdataset.Tables("FTYPE").Rows(0).Item("CNAME")
                        ssgrid_Fac.Focus()
                    End If

                End With
            Else
                ssgrid_Fac.SetActiveCell(0, ssgrid_Fac.ActiveRow)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FACILITY(ByVal name As String)
        Try
            Dim vform As New ListOperattion1
            Dim ssql As String
            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
            gSQLString = " SELECT ISNULL(SUBSDESC,'') AS SUBSDESC,ISNULL(SUBSCODE,'') AS SUBSCODE,ISNULL(TOTAL,0) AS AMOUNT FROM SUBSCRIPTIONMAST "
            If Trim(Search) = " " Then
                M_WhereCondition = " WHERE FACILITY_FLG='F'"
            Else
                M_WhereCondition = " WHERE FACILITY_FLG='F'"
            End If
            vform.Field = "SUBSDESC,SUBSCODE"
            vform.vFormatstring = "     FACILITY                      |      FACILITY CODE                     |       AMOUNT        |"
            vform.vCaption = "NAME  HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                With ssgrid_Fac
                    .Col = 3
                    .Row = .ActiveRow
                    .Text = vform.keyfield1
                    .Col = 4
                    .Row = .ActiveRow
                    .Text = vform.keyfield
                End With
            Else
                ssgrid_Fac.SetActiveCell(0, ssgrid_Fac.ActiveRow)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LBL_CARD_BALANCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_CARD_BALANCE.Click

    End Sub

    Private Sub SSGRIND1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSGRIND1.Advance

    End Sub
    Private Sub SSGRIND1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSGRIND1.KeyDownEvent
        Try
            Dim SSQL, PNAME As String
            With SSGRIND1
                If e.keyCode = Keys.Enter Then
                    If .ActiveCol = 1 Then
                        .Col = 1
                        .Row = .ActiveRow
                        PNAME = Trim(.Text)
                        If PNAME <> "" Then
                            With ssgrid_Fac
                                .Col = 2
                                .Row = .ActiveRow
                                .Text = PNAME
                                .Focus()
                            End With
                            PNL_FACILITY.Visible = False
                        End If
                    End If
                ElseIf e.keyCode = Keys.Escape Then
                    SSGRIND1.ClearRange(1, 1, -1, -1, True)
                    PNL_FACILITY.Visible = False
                    ssgrid_Fac.SetActiveCell(2, ssgrid_Fac.ActiveRow)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function fac_det()
        Try
            If Trim(txt_MemberCode.Text) <> "" Then

                'SQLSTRING = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(TYPE,'') AS TYPE,ISNULL(DNAME,'') AS DNAME,ISNULL(FCODE,'') AS FCODE,ISNULL(FROMDATE,'') AS FROMDATE,ISNULL(TODATE,'') AS TODATE,ISNULL(ACT_FLAG,'') AS ACTFLAG FROM facility_HDR WHERE MCODE='" & txt_MemberCode.Text & "' and billdetails='" & Trim(txt_KOTno.Text) & "' And cast(convert(char(11),billdate,6) as datetime)='" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "'"

                SQLSTRING = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(TYPE,'') AS TYPE,ISNULL(DNAME,'') AS DNAME,ISNULL(FCODE,'') AS FCODE,ISNULL(FROMDATE,'') AS FROMDATE,ISNULL(TODATE,'') AS TODATE,ISNULL(ACT_FLAG,'') AS ACTFLAG FROM facility_HDR WHERE MCODE='" & txt_MemberCode.Text & "'  AND ISNULL(FTYPE,'')<>'D'"
                gconnection.getDataSet(SQLSTRING, "FACILITY")
                If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                    ssgrid_Fac.ClearRange(1, 1, -1, 1 - 1, True)
                    SSGRIND1.ClearRange(1, 1, -1, 1 - 1, True)
                    ssgrid_Fac.SetActiveCell(1, 1)
                    ssgrid_Fac.Focus()
                    With ssgrid_Fac
                        For J = 0 To gdataset.Tables("FACILITY").Rows.Count - 1
                            .Col = 1
                            .Row = J + 1
                            .Text = gdataset.Tables("FACILITY").Rows(J).Item("TYPE")
                            .Col = 2
                            .Row = J + 1
                            .Text = gdataset.Tables("FACILITY").Rows(J).Item("DNAME")
                            .Col = 3
                            .Row = J + 1
                            .Text = gdataset.Tables("FACILITY").Rows(J).Item("FCODE")

                            SQLSTRING = "SELECT ISNULL(SUBSCODE,'') AS SUBSCODE,ISNULL(SUBSDESC,'') AS SUBSDESC  FROM SUBSCRIPTIONMAST WHERE SUBSCODE='" & gdataset.Tables("FACILITY").Rows(J).Item("FCODE") & "'"
                            gconnection.getDataSet(SQLSTRING, "FDESC")
                            If gdataset.Tables("FDESC").Rows.Count > 0 Then
                                .Col = 4
                                .Row = J + 1
                                .Text = Trim(gdataset.Tables("FDESC").Rows(0).Item("SUBSDESC"))
                                ' .Text = gdataset.Tables("FACILITY").Rows(J).Item("FCODE")
                            End If
                            '.Col = 5
                            '.Row = J + 1
                            '.Text = Format(CDate(gdataset.Tables("FACILITY").Rows(J).Item("FROMDATE")), "dd/MM/yyy")
                            '.Col = 6
                            '.Row = J + 1
                            '.Text = Format(CDate(gdataset.Tables("FACILITY").Rows(J).Item("TODATE")), "dd/MM/yyy")
                            '.Col = 5
                            '.Row = J + 1
                            '.Text = IIf(gdataset.Tables("FACILITY").Rows(J).Item("ACTFLAG") = "Y", 1, 0)
                        Next
                    End With
                    CMD_FACILITY.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Function creditstop(ByVal MEMBERCODE As String) As String
        lab_outstanding.Text = "0.00"
        MemberOutstand = 0
        Dim sqlstring As String
        Dim prvbal, crstop, present, rcd, clsbal, asonbal, SHOP As Double
        Dim flag As String
        sqlstring = "exec cp_creditlimit '" & Format(Now, "dd MMM yyyy") & "','SDRS','" & Trim(MEMBERCODE) & "'"
        gconnection.getDataSet(sqlstring, "CP_CREDIT")
        sqlstring = "select ISNULL(FLAG,'') AS FLAG,ISNULL(SUM(ISNULL(CDR,0)),0)-ISNULL(SUM(ISNULL(CCR,0)),0) AS CAMOUNT,ISNULL(SUM(USAGE),0) AS USAGE from CREDITSTOP_MCODE WHERE MCODE='" & Trim(MEMBERCODE) & "' GROUP BY FLAG"
        gconnection.getDataSet(sqlstring, "CP_CRLIMIT")
        If gdataset.Tables("CP_CRLIMIT").Rows.Count > 0 Then
            flag = gdataset.Tables("CP_CRLIMIT").Rows(0).Item("FLAG")
            If flag = "D" Then
                crstop = gdataset.Tables("CP_CRLIMIT").Rows(0).Item("CAMOUNT")
            Else
                crstop = gdataset.Tables("CP_CRLIMIT").Rows(0).Item("USAGE")
            End If
            MemberOutstand = gdataset.Tables("CP_CRLIMIT").Rows(0).Item("USAGE")
            lab_outstanding.Text = "MEM.BAL:" & gdataset.Tables("CP_CRLIMIT").Rows(0).Item("USAGE")
        Else
            crstop = 0
            '           prvbal = 0
            flag = ""
            MemberOutstand = 0
            lab_outstanding.Text = "MEM.BAL:0.00"
        End If
        flag = Trim(flag)
        If flag = "C" Then
            creditstop = "CREDIT STOP"
        End If
        If flag = "D" Then
            creditstop = "DEFAULTER"
        End If
        If flag = "A" Then
            creditstop = "ACTIVE"
        End If
        Return creditstop
    End Function
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Try
            vCardcode = ""
            smartdeviceportcount = 0
            ssGrid.ClearRange(1, 1, -1, -1, True)
            cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
            ssGrid.SetActiveCell(1, 1)
            Call clearform(Me)
            lab_outstanding.Text = ""
            lab_servicename.Text = ""
            CMB_BTYPE_SelectedIndexChanged(sender, e)
            txt_card_id_Validated(sender, e)
            Call FillBillPrefix()
            Call autogenerate()
            Call ShowBillno()
            Call GRIDLOCK()
            Call enablecontrols()
            Call fillPayment_Mode()
            Call FacilityValidation()
            Pic_Member.Image = New Bitmap(AppPath & "\Image.Jpg")
            cmd_Delete.Enabled = True
            txt_Holder_Code.Clear()
            Txt_holder_name.Clear()
            LBL_CARD_BALANCE.Visible = False
            LBL_CARD_BALANCE.Text = "CARD BALANCE :"
            pnl_POSCode.Top = 1000
            pnl_UOMCode.Top = 1000
            txt_MemberCode.Tag = ""
            Cmd_Add.Text = "Add [F7]"
            cbo_PaymentMode.Focus()
            KOT_Timer.Enabled = True
            Me.Lbl_Bill.Visible = False
            TotalItemCount = 0
            txt_KOTno.ReadOnly = False
            Me.cmd_Delete.Enabled = True
            txt_MemberName.ReadOnly = False
            txt_ServerName.ReadOnly = False
            Me.Cmd_Add.Enabled = True
            Me.lbl_SubPaymentMode.Visible = False
            Me.cbo_SubPaymentMode.Visible = False
            Me.cmd_BillSettlement.Enabled = True
            Me.cmd_KOTnoHelp.Enabled = True
            lblCro1.Visible = False
            lblCro.Visible = False
            SETLEMENT_GROUP.Visible = True
            ssgrid_settlement.ClearRange(1, 1, -1, -1, True)
            ssgrid_settlement.SetActiveCell(1, 1)
            SETLEMENT_GROUP.Visible = False
            LOC_TXT.Text = ""
            Pic_Member.Image = Nothing
            'facility
            'begin()
            ssgrid_Fac.ClearRange(1, 1, -1, -1, True)
            SSGRIND1.ClearRange(1, 1, -1, -1, True)
            PNL_FACILITY.Visible = False
            grp_facility.Visible = False
            ssgrid_Fac.SetActiveCell(1, 1)
            SSGRIND1.SetActiveCell(1, 1)
            'end
            MNAME_GBL = ""
            MCODE_GBL = ""
            txt_MemberCode.Text = ""
            txt_MemberName.Text = ""
            Call SetDateTime()
            ' Call SYS_DATE_TIME()
            'Me.dtp_KOTdate.Value = Format(serverdate, "dd/MM/yyyy")
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            BillNontaxamount = 0 : BillNontotalamount = 0 : Billtaxamount = 0 : Billtotalamount = 0
            txt_KOTno.Focus()
            Dim LOC, strstring As String
            LOC = Trim(CMB_BTYPE.Text)
            strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y'  AND ISNULL(DOCTYPE,'')='" & Trim(LOC) & "'"
            gconnection.getDataSet(strstring, "LOCmaster")
            If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
                LOC_TXT.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
                POScode = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
                lab_servicename.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosName")
                ssGrid.SetActiveCell(1, 1)
                ssGrid.Focus()
            Else
                LAB_MSTATUS.Text = ""
                LOC_TXT.Text = ""
                POScode = ""
            End If
            cbo_PaymentMode.Focus()
            txt_card_id.Focus()
            CMD_FACILITY.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim Totalamount, Taxamount, Calamount, Caltax, CalBilamount, calhighratio, CardAmount, Billroundoff, dblCard, dblMinimum, Roundoff1 As Double
        Dim cancelamt, canceltax, cancel, SubpaymentMode(), paymentaccountcode, Roundaccountcode, Subpaymentaccountcode, Round, jrnsql, jrnsql1 As String
        Dim Taxamt, Totalamt, Packamt, DiscAmt, itemcode, costinguom, Billdetails, Roundedvalue() As String
        Dim Oldtaxbilldetails, Oldtaxbillno, Oldnontaxbilldetails, Oldnontaxbillno, OldOtherbillno As String
        Dim TaxTotal, total, size, i, j, Z As Double
        Dim TaxApp, NoTax, Otherbool As Boolean
        Dim Taxdr(), NoTaxDr() As DataRow
        Dim Kot_Bill As New DataTable
        Dim taxbilldetails, taxbillno, nontaxbilldetails, nontaxbillno, Otherbillno, poscode As String
        Dim sqlstring, varchk, VarSql As String
        Dim Insert(0), Update2(0), caldoublevalue As String
        Dim Gridbool As Boolean
        'REFERINVENTORY**********************************************************************************************
        Dim POSLOCATION, POSITEMCODE, POSITEMUOM As String
        Dim AVGRATE, AVGQUANTITY, dblCalqty As Double
        Dim K As Integer
        '************************************************************************************************************
        loccode = ""
        Call Randomize()
        vOutfile = Mid("jrnl" & (Rnd() * 800000), 1, 8)
        Update2(0) = " Exec Jrn_Kot_Det '" & vOutfile & "'"
        Call checkvalidate() '''---> Check Validation
        If chkbool = False Then Exit Sub
        ssGrid.Row = 1
        ssGrid.Col = 3
        POSLOCATION = Trim(ssGrid.Text)
        sqlstring = "select poscode,isnull(costcode,'') as costcode from posmaster where poscode='" & POSLOCATION & "' group by poscode,costcode"
        gconnection.getDataSet(sqlstring, "RoomCheckin")
        If gdataset.Tables("RoomCheckin").Rows.Count <> 0 Then
            costcode = gdataset.Tables("RoomCheckin").Rows(0).Item("costcode")
        End If
        If Mid(CStr(Cmd_Add.Text), 1, 1) = "A" Then
            ReDim Preserve Update2(Update2.Length)
            Update2(Update2.Length - 1) = " SELECT * INTO " & vOutfile & " FROM KOT_DET WHERE 1<0 "
            '================================
            'CSC SMART CARD CARD
            'karthi july 08 
            If Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
                MessageBox.Show("PLEASE! SWIPE YOUR CARD", "CARD NOT SWIPED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = False
                txt_card_id.Focus()
                '                lbl_SwipeCard.Focus()
                Exit Sub
            Else
                If cbo_PaymentMode.Text = "SMART CARD" Then
                    Call cardcheck()
                End If
            End If

            Call autogenerate() '''---> AUTO GENERATE 
            'SARAN

            '*********************CSC SMART CARD CARD
            'WITH MIN USAGE
            BILLAMT_GBL = Val(txt_BillAmount.Text + Amt)
            If cbo_PaymentMode.Text = "SMART CARD" Then
                If (MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL < Val(txt_BillAmount.Text + Amt) Then
                    MsgBox("SUFFICIENT BALANCE NOT AVAILABLE", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    'Txt_Remarks.Text = "Op Bal: " & Trim(Format((MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL, "0.00")) & "   Cur Bal: " & Trim(Format(Val(txt_BillAmount.Text + Amt), "0.00")) & "   Cl.Bal: " & Trim(Format(((MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL) - Val(txt_BillAmount.Text + Amt), "0.00"))
                End If
            End If
            '*********************CSC SMART CARD CARD AMOUNT
            'BEGIN CARD  WRITE BALANCE
            If cbo_PaymentMode.Text = "SMART CARD" Then
                Dim CARDWRITEBALANCE As String
                Dim LENCARDWRITEBALANCE As Integer

                CARDWRITEBALANCE = Trim(CStr((MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL + Val(txt_BillAmount.Text + Amt)))
                'MsgBox(CARDWRITEBALANCE)
                Dim TXT1, TXT2, TXT3, TXT4, TXT5, TXT6, TXT7, TXT8, TXT9, TXT10, TXT11, TXT12, TXT13, TXT14, TXT15, TXT16 As String
                LENCARDWRITEBALANCE = Len(CARDWRITEBALANCE)
                For i = 1 To LENCARDWRITEBALANCE
                    Select Case i
                        Case 1
                            TXT1 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 2
                            TXT2 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 3
                            TXT3 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 4
                            TXT4 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 5
                            TXT5 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 6
                            TXT6 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 7
                            TXT7 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 8
                            TXT8 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 9
                            TXT9 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 10
                            TXT10 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 11
                            TXT11 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 12
                            TXT12 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 13
                            TXT13 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 14
                            TXT14 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 15
                            TXT15 = Mid(CARDWRITEBALANCE, i, 1)
                        Case 16
                            TXT16 = Mid(CARDWRITEBALANCE, i, 1)
                    End Select
                Next

                For i = LENCARDWRITEBALANCE + 1 To 16
                    Select Case i
                        Case 1
                            TXT1 = "FF"
                        Case 2
                            TXT2 = "FF"
                        Case 3
                            TXT3 = "FF"
                        Case 4
                            TXT4 = "FF"
                        Case 5
                            TXT5 = "FF"
                        Case 6
                            TXT6 = "FF"
                        Case 7
                            TXT7 = "FF"
                        Case 8
                            TXT8 = "FF"
                        Case 9
                            TXT9 = "FF"
                        Case 10
                            TXT10 = "FF"
                        Case 11
                            TXT11 = "FF"
                        Case 12
                            TXT12 = "FF"
                        Case 13
                            TXT13 = "FF"
                        Case 14
                            TXT14 = "FF"
                        Case 15
                            TXT15 = "FF"
                        Case 16
                            TXT16 = "FF"
                    End Select
                Next

                '                Call DLLCONNECT()
                '                Call DLLSELECT()
                '                Call dlllogin(23)
                '                Call DLLREAD()
                '                Call DLLWRITE(TXT1, TXT2, TXT3, TXT4, TXT5, TXT6, TXT7, TXT8, TXT9, TXT10, TXT11, TXT12, TXT13, TXT14, TXT15, TXT16)

                '        Call DLLWRITE("FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF", "FF")

                'END CARD WRITE BALANCE
            End If

            KOTno = Split(Trim(txt_KOTno.Text), "/")
            '    KOTno = txt_KOTno.Text

            Me.txt_TotalValue.Text = 0
            Me.txt_TaxValue.Text = 0
            Me.txt_PackingCharge.Text = 0
            For i = 1 To ssGrid.DataRowCnt
                cancel = Nothing
                Taxamt = Nothing
                Totalamt = Nothing
                Packamt = Nothing
                ssGrid.GetText(12, i, cancel)
                If Val(cancel) = 0 Then
                    ssGrid.GetText(7, i, Taxamt)
                    ssGrid.GetText(8, i, Totalamt)
                    ssGrid.GetText(18, i, Packamt)
                    Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(Totalamt), "0.00")
                    Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(Taxamt), "0.00")
                    Me.txt_PackingCharge.Text = Format(Val(Me.txt_PackingCharge.Text) + Val(Packamt), "0.00")
                End If
            Next i
            If Val(txt_Discount.Text) = 0 Then
                Billroundoff = Val(Me.txt_TotalValue.Text) + Val(Me.txt_TaxValue.Text) + Val(Me.txt_PackingCharge.Text)
                Round = CStr(Billroundoff)
                If BILLROUNDYESNO = "YES" Then
                    If Round.IndexOf(".") <= 0 Then
                        Round = Round.Insert(Round.Length - 1, ".00")
                    End If
                    Roundedvalue = Split(Round, ".")
                    If Format(Val(Roundedvalue(1)), "00") = 50 Then
                        Billroundoff = Math.Ceiling(Billroundoff)
                    ElseIf Format(Val(Roundedvalue(1)), "00") > 50 Then
                        Billroundoff = Math.Ceiling(Billroundoff)
                    Else
                        Billroundoff = Math.Floor(Billroundoff)
                    End If
                    Roundoff1 = Mid(Format(Val(Billroundoff), "0.00"), Len(Format(Val(Billroundoff), "0.00")) - 1, Len(Format(Val(Billroundoff), "0.00")))
                    If Format(Val(Roundoff1), "00") = 50 Then
                        Billroundoff = Math.Ceiling(Billroundoff)
                    ElseIf Format(Val(Roundoff1), "00") > 50 Then
                        Billroundoff = Math.Ceiling(Billroundoff)
                    Else
                        Billroundoff = Math.Floor(Billroundoff)
                    End If
                    'Me.txt_BillAmount.Text = Format(Val(Billroundoff), "0.00")
                Else
                    Roundoff1 = Mid(Format(Val(Billroundoff), "0.00"), Len(Format(Val(Billroundoff), "0.00")) - 1, Len(Format(Val(Billroundoff), "0.00")))
                    'Me.txt_BillAmount.Text = Format(Val(Billroundoff), "0.00")
                End If
            Else
                dbldicountAmount = (Val(txt_TotalValue.Text) * Val(txt_Discount.Text)) / 100
                dblGrossAmount = Val(txt_TotalValue.Text) - Val(dbldicountAmount)
                dbldicountTax = (Val(txt_TaxValue.Text) * Val(txt_Discount.Text)) / 100
                dblGrossTax = Val(txt_TaxValue.Text) - Val(dbldicountTax)
                dbldicountPack = (Val(txt_PackingCharge.Text) * Val(txt_Discount.Text)) / 100
                dblGrossPack = Val(txt_PackingCharge.Text) - Val(dbldicountPack)
                dblDicountBillAmount = dblGrossAmount + dblGrossTax + dblGrossPack
                Me.txt_TotalValue.Text = Format(Val(dblGrossAmount), "0.00")
                Me.txt_TaxValue.Text = Format(Val(dblGrossTax), "0.00")
                Me.txt_PackingCharge.Text = Format(Val(dblGrossPack), "0.00")
                Round = CStr(dblDicountBillAmount)
                If BILLROUNDYESNO = "YES" Then
                    If Round.IndexOf(".") <= 0 Then
                        Round = Round.Insert(Round.Length - 1, ".00")
                    End If
                    Roundedvalue = Split(Round, ".")
                    If Format(Val(Roundedvalue(1)), "00") = 50 Then
                        Billroundoff = Math.Ceiling(dblDicountBillAmount)
                    ElseIf Format(Val(Roundedvalue(1)), "00") > 50 Then
                        Billroundoff = Math.Ceiling(dblDicountBillAmount)
                    Else
                        Billroundoff = Math.Floor(dblDicountBillAmount)
                    End If
                    Roundoff1 = Mid(Format(Val(dblDicountBillAmount), "0.00"), Len(Format(Val(dblDicountBillAmount), "0.00")) - 1, Len(Format(Val(dblDicountBillAmount), "0.00")))
                    If Format(Val(Roundoff1), "00") = 50 Then
                        dblDicountBillAmount = Math.Ceiling(dblDicountBillAmount)
                    ElseIf Format(Val(Roundoff1), "00") > 50 Then
                        dblDicountBillAmount = Math.Ceiling(dblDicountBillAmount)
                    Else
                        dblDicountBillAmount = Math.Floor(dblDicountBillAmount)
                    End If
                    'Me.txt_BillAmount.Text = Format(Math.Round(Val(dblDicountBillAmount)), "0.00")
                Else
                    Roundoff1 = Mid(Format(Val(dblDicountBillAmount), "0.00"), Len(Format(Val(dblDicountBillAmount), "0.00")) - 1, Len(Format(Val(dblDicountBillAmount), "0.00")))
                    'Me.txt_BillAmount.Text = Format(Val(dblDicountBillAmount), "0.00")
                End If
            End If
            '''******************************************* Find Out Paymentmode Accountcode and Subpaymentmode Accountcode *********************'''
            If Me.cbo_SubPaymentMode.Visible = True Then
                SubpaymentMode = Split(Trim(Me.cbo_SubPaymentMode.Text), "-")
                sqlstring = "SELECT Accountin FROM subpaymentmode WHERE Subpaymentcode ='" & Trim(SubpaymentMode(0)) & "' AND ISNULL(Freeze,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "subpaymentmode")
                If gdataset.Tables("subpaymentmode").Rows.Count > 0 Then
                    Subpaymentaccountcode = Trim(gdataset.Tables("subpaymentmode").Rows(0).Item("Accountin") & "")
                End If
            Else
                ReDim Preserve SubpaymentMode(1)
                SubpaymentMode(0) = ""
                Subpaymentaccountcode = ""
            End If
            '''************************************************************* PAYMENT MODE ACCT IN *******************'''
            sqlstring = "SELECT Accountin FROM Paymentmodemaster WHERE Paymentcode ='" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(Freeze,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "Paymentmodemaster")
            If gdataset.Tables("Paymentmodemaster").Rows.Count > 0 Then
                paymentaccountcode = Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin") & "")
            Else
                MessageBox.Show("Assign a AccountCode For Specified PAYMENTMODE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                paymentaccountcode = ""
                Exit Sub
            End If
            '''************************************************************* ROUND OFF ACCT IN *******************'''
            sqlstring = "SELECT ISNULL(ROUNDACCTIN,'') AS ROUNDACCTIN FROM POSSETUP WHERE ISNULL(ROUNDACCTIN,'') <> ''"
            gconnection.getDataSet(sqlstring, "POSSETUP")
            If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                Roundaccountcode = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("ROUNDACCTIN") & "")
            Else
                MessageBox.Show("Assign a AccountCode For Specified ROUNDOFF VALUE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Roundaccountcode = ""
                Exit Sub
            End If
            '''***************************************************************** INSERT INTO KOT_HDR ********************************************************************************************************'''
            If cbo_PaymentMode.SelectedItem = "ROOM" Then
                sqlstring = "INSERT INTO KOT_HDR(BTYPE,KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,Slcode,Mcode,Mname,RoomNo,Guest,checkin,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,DiscountAmt,PackAmt,Total,TotalTax,BillAmount,RoundOff,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                sqlstring = sqlstring & " Receiptstatus,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,subpaymentaccountcode,Roundoffaccountcode,Remarks,Manualbillstatus,delflag,Voucherno,servicelocation,locationcode,CARDHOLDERCODE,CARDHOLDERNAME,[16_digit_code]) "
                sqlstring = sqlstring & " VALUES ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'" & Trim(doctype) & "','SALE','" & Trim(accountcode) & "','','','','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & " '" & Trim(txt_MemberName.Text) & "','" & Trim(txt_MemberCode.Tag) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                'sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                If BILLROUNDYESNO = "YES" Then
                    sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                Else
                    sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                End If
                sqlstring = sqlstring & " 'N',0,'','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(paymentaccountcode) & " ','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Roundaccountcode) & " ','" & Trim(Txt_Remarks.Text) & "','Y','N','','" & loccode & "','" & loccode & "','" & Trim(Me.txt_Holder_Code.Text) & "','" & Trim(Me.Txt_holder_name.Text) & "','" & Trim(Me.txt_card_id.Text) & "')"

            ElseIf cbo_PaymentMode.SelectedItem = "SMART CARD" Then
                sqlstring = "INSERT INTO KOT_HDR(KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,SLCode,MCode,Mname,RoomNo,Guest,checkin,CARDHOLDERCODE,CARDHOLDERNAME,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,Total,TotalTax,BillAmount,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                sqlstring = sqlstring & "Receiptstatus,Roundoff,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,subpaymentaccountcode,Remarks,Manualbillstatus,delflag,Voucherno,slipno,locationcode,PACKAMT,[16_digit_code]) "
                sqlstring = sqlstring & " VALUES ('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy HH:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'SALE','SALE','" & accountcode & "','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Replace(Trim(txt_MemberName.Text), "'", "") & "','','','','" & Trim(txt_Holder_Code.Text) & "','" & Trim(Txt_holder_name.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & IIf(gRoundOffFlag = True, Math.Round(Val(txt_BillAmount.Text)), Val(txt_BillAmount.Text)) & ",'ST','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                sqlstring = sqlstring & "'N'," & Math.Round(Val(txt_BillAmount.Text)) & ",0,'','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "','N','" & Trim(paymentaccountcode) & " ','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Txt_Remarks.Text) & "','N','N','','" & Trim(txt_KOTno.Text) & "','" & Trim(loccode) & "'," & Val(txt_PackingCharge.Text) & ",'" & Trim(txt_card_id.Text) & "')"
                'SMART CARD


            ElseIf cbo_PaymentMode.SelectedItem = "PENDING" Then
                sqlstring = "INSERT INTO KOT_HDR(BTYPE,KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,Slcode,Mcode,Mname,RoomNo,Guest,checkin,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,DiscountAmt,PackAmt,Total,TotalTax,BillAmount,RoundOff,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                sqlstring = sqlstring & " Receiptstatus,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,subpaymentaccountcode,Roundoffaccountcode,Remarks,Manualbillstatus,delflag,Voucherno,servicelocation,locationcode,CARDHOLDERCODE,CARDHOLDERNAME,[16_digit_code]) "
                sqlstring = sqlstring & " VALUES ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'" & Trim(doctype) & "','SALE','" & Trim(accountcode) & "','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & " '" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "','','','','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                'sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                If BILLROUNDYESNO = "YES" Then
                    sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                Else
                    sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                End If
                sqlstring = sqlstring & " 'N',0,'','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(gDebitors) & "','" & Trim(txt_MemberCode.Text) & "','" & Trim(Roundaccountcode) & " ','" & Trim(Txt_Remarks.Text) & "','Y','N','','" & loccode & "','" & loccode & "','" & Trim(Me.txt_Holder_Code.Text) & "','" & Trim(Me.Txt_holder_name.Text) & "','" & Trim(txt_card_id.Text) & "')"
            ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                sqlstring = "INSERT INTO KOT_HDR(BTYPE,KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,Slcode,Mcode,Mname,RoomNo,Guest,checkin,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,DiscountAmt,PackAmt,Total,TotalTax,BillAmount,RoundOff,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                sqlstring = sqlstring & " Receiptstatus,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,subpaymentaccountcode,Roundoffaccountcode,Remarks,Manualbillstatus,delflag,Voucherno,servicelocation,locationcode,CARDHOLDERCODE,CARDHOLDERNAME,[16_digit_code]) "
                sqlstring = sqlstring & " VALUES ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'" & Trim(doctype) & "','SALE','" & Trim(accountcode) & "','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & " '" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "','','','','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                'sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                If BILLROUNDYESNO = "YES" Then
                    sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                Else
                    sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                End If
                sqlstring = sqlstring & " 'N',0,'','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(gDebitors) & "','" & Trim(txt_MemberCode.Text) & "','" & Trim(Roundaccountcode) & " ','" & Trim(Txt_Remarks.Text) & "','Y','N','','" & loccode & "','" & loccode & "','" & Trim(Me.txt_Holder_Code.Text) & "','" & Trim(Me.Txt_holder_name.Text) & "','" & Trim(txt_card_id.Text) & "')"
            Else
                Try
                    sqlstring = " SELECT ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
                    sqlstring = sqlstring & "WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
                    gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
                    If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                        If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) = "NO" Then
                            sqlstring = "INSERT INTO KOT_HDR(BTYPE,KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,Slcode,Mcode,Mname,RoomNo,Guest,checkin,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,DiscountAmt,PackAmt,Total,TotalTax,BillAmount,RoundOff,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                            sqlstring = sqlstring & " Receiptstatus,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,subpaymentaccountcode,Roundoffaccountcode,Remarks,Manualbillstatus,delflag,Voucherno,servicelocation,locationcode,CARDHOLDERCODE,CARDHOLDERNAME,[16_digit_code]) "
                            sqlstring = sqlstring & " VALUES ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'" & Trim(doctype) & "','SALE','" & Trim(accountcode) & "','','','','', "
                            sqlstring = sqlstring & " '','','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                            'sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                            If BILLROUNDYESNO = "YES" Then
                                sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                            Else
                                sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                            End If
                            sqlstring = sqlstring & " 'N',0,'','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(paymentaccountcode) & " ','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Roundaccountcode) & " ','" & Trim(Txt_Remarks.Text) & "','Y','N','','" & loccode & "','" & loccode & "','" & Trim(Me.txt_Holder_Code.Text) & "','" & Trim(Me.Txt_holder_name.Text) & "','" & Trim(txt_card_id.Text) & "')"
                        Else
                            sqlstring = "INSERT INTO KOT_HDR(BTYPE,KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,SLCode,MCode,Mname,RoomNo,Guest,checkin,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,DiscountAmt,PackAmt,Total,TotalTax,BillAmount,RoundOff,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                            sqlstring = sqlstring & " Receiptstatus,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,subpaymentaccountcode,Roundoffaccountcode,Remarks,Manualbillstatus,delflag,Voucherno,servicelocation,locationcode,CARDHOLDERCODE,CARDHOLDERNAME,[16_digit_code]) "
                            sqlstring = sqlstring & " VALUES ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'" & Trim(doctype) & "','SALE','" & Trim(accountcode) & "','" & Trim(txt_MemberCode.Text) & "', "
                            sqlstring = sqlstring & " '" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "','','','','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                            'sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                            If BILLROUNDYESNO = "YES" Then
                                sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                            Else
                                sqlstring = sqlstring & " 'SALE','AUTO'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'ST','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                            End If
                            sqlstring = sqlstring & " 'N',0,'','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(paymentaccountcode) & " ','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Roundaccountcode) & " ','" & Trim(Txt_Remarks.Text) & "','Y','N','','" & loccode & "','" & loccode & "','" & Trim(Me.txt_Holder_Code.Text) & "','" & Trim(Me.Txt_holder_name.Text) & "','" & Trim(txt_card_id.Text) & "')"
                        End If
                    Else
                        MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                Catch ex As Exception
                    MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End Try
            End If
            Insert(0) = sqlstring

            'SARAN
            sqlstring = "Update PoSKotDoc Set DocNo = " & Val(Mid(txt_KOTno.Text, 5, 6)) & ",DOCFLAG='N' Where DocType = '" & Trim(BillPrefix) & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring



            '''******************************************************** Insert into KOT_DET **********************************'''
            For i = 1 To ssGrid.DataRowCnt
                sqlstring = "INSERT INTO KOT_DET(KotNo,KOTdetails,KotDate,Billdetails,KotType,PaymentMode,Mcode,Scode,Covers,TableNo,TotAmt,TaxAmt,PackAmt,DiscAmt,BillAmt,ChkId,ItemCode,Itemdesc,Poscode,costcode,Uom,Qty,Rate,Taxamount,Amount,ItemType,TaxCode,TaxPerc,TaxAccountCode,SalesAccountCode,GroupCode,"
                sqlstring = sqlstring & " PackPercent,PackAmount,Openfacilityst,Promotionalst,Packaccountcode,Taxtype,Alcholst,Adduserid,Adddatetime,Upduserid,Upddatetime,KOTStatus,Delflag) "
                sqlstring = sqlstring & " VALUES('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & doctype & "','" & Trim(cbo_PaymentMode.Text) & "',"
                If BILLROUNDYESNO = "YES" Then
                    sqlstring = sqlstring & " '" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Val(Me.txt_PackingCharge.Text) & "," & Val(Me.txt_Discount.Text) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & "," & Val(Me.txt_MemberCode.Tag) & ""
                Else
                    sqlstring = sqlstring & " '" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Val(Me.txt_PackingCharge.Text) & "," & Val(Me.txt_Discount.Text) & "," & Val(Me.txt_BillAmount.Text) & "," & Val(Me.txt_MemberCode.Tag) & ""
                End If
                ssGrid.Row = i
                ssGrid.Col = 1
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                ssGrid.Col = 2
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                ssGrid.Col = 3
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                sqlstring = sqlstring & ",'" & costcode & "'"
                ssGrid.Col = 4
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                ssGrid.Col = 5
                sqlstring = sqlstring & "," & Val(ssGrid.Text) & ""
                ssGrid.Col = 6
                sqlstring = sqlstring & "," & Val(ssGrid.Text) & ""
                ssGrid.Col = 7
                sqlstring = sqlstring & "," & Val(ssGrid.Text) & ""
                ssGrid.Col = 8
                sqlstring = sqlstring & "," & Val(ssGrid.Text) & ""
                ssGrid.Col = 9
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                ssGrid.Col = 10
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                ssGrid.Col = 11
                sqlstring = sqlstring & "," & Val(ssGrid.Text) & " "
                ssGrid.Col = 13
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                ssGrid.Col = 14
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                ssGrid.Col = 15
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                ssGrid.Col = 17
                sqlstring = sqlstring & "," & Val(ssGrid.Text) & " "
                ssGrid.Col = 18
                sqlstring = sqlstring & "," & Val(ssGrid.Text) & " "
                ssGrid.Col = 19
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                ssGrid.Col = 20
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                ssGrid.Col = 21
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                ssGrid.Col = 9
                If Trim(ssGrid.Text) = "BAR" Then
                    sqlstring = sqlstring & ",'','Y'"
                ElseIf Trim(ssGrid.Text) = "SD" Then
                    sqlstring = sqlstring & ",'SALES','S'"
                Else
                    sqlstring = sqlstring & ",'SALES','N'"
                End If
                sqlstring = sqlstring & ",'" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                ssGrid.Col = 12
                If Trim(ssGrid.Text) = "1" Then
                    sqlstring = sqlstring & ",'Y','N')"
                Else
                    sqlstring = sqlstring & ",'N','N')"
                End If
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring

                ReDim Preserve Update2(Update2.Length)
                Update2(Update2.Length - 1) = Replace(sqlstring, "KOT_DET", " " & vOutfile & " ")
                ''REFERINVENTORY*************************UPDATING STOCK***********************************************
                ssGrid.Row = i
                ssGrid.Col = 3
                POSLOCATION = Trim(ssGrid.Text)

                sqlstring = "SELECT STOREDESC FROM STOREMASTER WHERE STORECODE='" & POSLOCATION & "' AND ISNULL(FREEZE,'') <> 'Y'"
                gconnection.getDataSet(sqlstring, "STOREMASTER1")
                If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                    ssGrid.Row = i
                    ssGrid.Col = 1
                    POSITEMCODE = Trim(ssGrid.Text)

                    ssGrid.Row = i
                    ssGrid.Col = 4
                    POSITEMUOM = Trim(ssGrid.Text)

                    'AVGRATE = CalAverageRate(Trim(ssGrid.Text))
                    'AVGQUANTITY = CalAverageQuantity(Trim(ssGrid.Text))
                    sqlstring = "SELECT GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID FROM BOM_DET WHERE"
                    sqlstring = sqlstring & " ITEMCODE='" & POSITEMCODE & "' AND ITEMUOM='" & POSITEMUOM & "' AND ISNULL(VOID,'') <> 'Y'"
                    gconnection.getDataSet(sqlstring, "BOM")
                    If gdataset.Tables("BOM").Rows.Count > 0 Then
                        For K = 0 To gdataset.Tables("BOM").Rows.Count - 1
                            sqlstring = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                            sqlstring = sqlstring & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                            sqlstring = sqlstring & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                            sqlstring = sqlstring & " VALUES ('" & txt_KOTno.Text & "','" & Trim(CStr(txt_KOTno.Text)) & "',"
                            sqlstring = sqlstring & " '" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy") & "',"
                            sqlstring = sqlstring & " '" & Trim(POSLOCATION) & "',"
                            sqlstring = sqlstring & " '" & Trim(STORELOCATION(POSLOCATION)) & "',"
                            sqlstring = sqlstring & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "',"
                            sqlstring = sqlstring & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMNAME") & "") & "',"
                            sqlstring = sqlstring & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "',"
                            ssGrid.Col = 5
                            ssGrid.Row = i
                            dblCalqty = Val(ssGrid.Text)
                            sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) & ","
                            AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""))
                            'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                            sqlstring = sqlstring & AVGRATE & ","
                            sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) * AVGRATE & ","
                            'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                            sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GDBLAMT")) & ","
                            sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GHIGHRATIO")) & ","
                            sqlstring = sqlstring & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GGROUPCODE") & "") & "',"
                            sqlstring = sqlstring & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GSUBGROUPCODE") & "") & "',"
                            sqlstring = sqlstring & "'N'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                            sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                            sqlstring = sqlstring & " ' ','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "')"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = sqlstring
                        Next K
                    Else
                        sqlstring = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, ISNULL(I.PURCHASERATE,0.00) AS PURCHASERATE,"
                        sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                        sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "
                        sqlstring = sqlstring & " WHERE I.ITEMCODE='" & POSITEMCODE & "' AND I.STOCKUOM='" & POSITEMUOM & "' AND ISNULL(FREEZE,'') <> 'Y'"
                        gconnection.getDataSet(sqlstring, "DIRECT_STOCK")
                        If gdataset.Tables("DIRECT_STOCK").Rows.Count > 0 Then
                            sqlstring = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                            sqlstring = sqlstring & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                            sqlstring = sqlstring & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                            sqlstring = sqlstring & " VALUES ('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "',"
                            sqlstring = sqlstring & " '" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy") & "',"
                            sqlstring = sqlstring & " '" & Trim(POSLOCATION) & "',"
                            sqlstring = sqlstring & " '" & Trim(STORELOCATION(POSLOCATION)) & "',"
                            sqlstring = sqlstring & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & "") & "',"
                            sqlstring = sqlstring & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMNAME") & "") & "',"
                            sqlstring = sqlstring & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("STOCKUOM") & "") & "',"
                            ssGrid.Col = 5
                            ssGrid.Row = i
                            dblCalqty = Val(ssGrid.Text)
                            sqlstring = sqlstring & dblCalqty & ","
                            AVGRATE = CalAverageRate(Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & ""))
                            'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                            sqlstring = sqlstring & AVGRATE & ","
                            sqlstring = sqlstring & dblCalqty * AVGRATE & ","
                            'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                            sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ","
                            sqlstring = sqlstring & Val(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ","
                            sqlstring = sqlstring & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("GROUPCODE") & "") & "',"
                            sqlstring = sqlstring & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("SUBGROUPCODE") & "") & "',"
                            sqlstring = sqlstring & "'N'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                            sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                            sqlstring = sqlstring & " ' ','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "')"

                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = sqlstring

                            ReDim Preserve Update2(Update2.Length)
                            Update2(Update2.Length - 1) = Replace(sqlstring, "kot_det", " " & vOutfile & " ")
                        End If
                    End If
                End If
                '******************************************************************************************************
            Next i


            '''********************************************************* INSERT INTO BILL_HDR TABLE ********************************************************************************************************************************************************************************************************************************************'''

            If cbo_PaymentMode.SelectedItem = "ROOM" Then
                sqlstring = "INSERT INTO BILL_HDR(BTYPE,Billno,BillDetails,BillDate,BillTime,DiscountAmount,PackAmount,TaxAmount,BillAmount,Roundoff,Roundoffaccountcode,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks,servicelocation) VALUES"
                sqlstring = sqlstring & " ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "','" & Format(serverdate, "hh:mm:ss") & "'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_TotalValue.Text) & "," & Format(Amt, "0.00") & ",'" & Trim(Roundaccountcode) & " ',"
                sqlstring = sqlstring & " '" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','','','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N'," & Val(Me.txt_MemberCode.Text) & ","
                sqlstring = sqlstring & " " & Val(Me.txt_MemberCode.Tag) & ",'" & Trim(Me.txt_MemberName.Text) & "','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & loccode & "')"
            ElseIf cbo_PaymentMode.SelectedItem = "SMART CARD" Then
                '''************************************************** $ IF PAYMENTMODE IS "CARD"  $ ********************************************'''
                If CStr(cbo_PaymentMode.Text) = "SMART CARD" Then
                    If smartcardbool = True Then
                        sqlstring = "SELECT ISNULL(Minimumusage,0) AS Minimumusage FROM MEMBERMASTER WHERE MCODE ='" & Trim(CStr(txt_MemberCode.Text)) & "' "
                        gconnection.getDataSet(sqlstring, "MinimumusageMaster")
                        If gdataset.Tables("MinimumusageMaster").Rows.Count > 0 Then
                            If Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) = 0 Then
                                sqlstring = "SELECT ISNULL(CardAmt,0) AS CardAmt FROM MEMBERMASTER WHERE MCODE ='" & Trim(CStr(txt_MemberCode.Text)) & "' "
                                gconnection.getDataSet(sqlstring, "CardAmtMaster")
                                If gdataset.Tables("CardAmtMaster").Rows.Count > 0 Then
                                    If Val(gdataset.Tables("CardAmtMaster").Rows(0).Item("CardAmt")) >= Val(txt_BillAmount.Text + Amt) Then
                                        sqlstring = "UPDATE MEMBERMASTER SET CardAmt = CardAmt - " & Math.Round(Val(Totalamount)) & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                        dblCard = Math.Round(Val(Totalamount))
                                        dblMinimum = 0
                                        ReDim Preserve Insert(Insert.Length)
                                        Insert(Insert.Length - 1) = sqlstring
                                    Else
                                        MessageBox.Show("!!! Warning !!! Refill your CARD before using ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                        cbo_PaymentMode.Focus()
                                        Exit Sub
                                    End If
                                End If
                            ElseIf Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) >= Val(Totalamount) Then
                                sqlstring = "UPDATE MEMBERMASTER SET Minimumusage = Minimumusage - " & Math.Round(Val(Totalamount)) & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                                dblCard = 0
                                dblMinimum = Math.Round(Val(Totalamount))
                            ElseIf Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) <= Val(Totalamount) And Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) > 0 Then
                                sqlstring = "UPDATE MEMBERMASTER SET Minimumusage = 0 WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                                dblMinimum = Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage"))
                                CardAmount = Math.Round(Val(Totalamount)) - Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage"))
                                sqlstring = "SELECT CardAmt FROM MEMBERMASTER WHERE MCODE ='" & Trim(CStr(txt_MemberCode.Text)) & "' "
                                gconnection.getDataSet(sqlstring, "CardAmtMaster")
                                If gdataset.Tables("CardAmtMaster").Rows.Count > 0 Then
                                    If Val(gdataset.Tables("CardAmtMaster").Rows(0).Item("CardAmt")) >= Val(Totalamount) Then
                                        sqlstring = "UPDATE MEMBERMASTER SET CardAmt = CardAmt - " & Format(Val(CardAmount), "0.00") & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                        ReDim Preserve Insert(Insert.Length)
                                        Insert(Insert.Length - 1) = sqlstring
                                        dblCard = Format(Val(CardAmount), "0.00")
                                    Else
                                        MessageBox.Show("!!! Warning !!! Refill your CARD before using ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                        cbo_PaymentMode.Focus()
                                        Exit Sub
                                    End If
                                End If
                            Else
                                MessageBox.Show("!!! Warning !!! Recharge your CARD before using ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                cbo_PaymentMode.Focus()
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("!!! Sorry !!! Transaction can't be proceed ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Exit Sub
                        End If
                    End If
                End If
                '''***************************************************** $ COMPLETE CALCULATION FOR CARD PAYMENTMODE ********************************************************************************'''
                'CSC SMARTCARD ADD 2 COLUMNS

                sqlstring = "INSERT INTO BILL_HDR(BTYPE,Billno,BillDetails,BillDate,BillTime,DiscountAmount,PackAmount,TaxAmount,BillAmount,Roundoff,Roundoffaccountcode,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,CARDHOLDERCODE,CARDHOLDERNAME,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks) VALUES"
                sqlstring = sqlstring & " ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(Me.dtp_KOTdate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "HH:mm:ss") & "',0," & Val(txt_PackingCharge.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_TotalValue.Text) & "," & Format(Val(Amt), "0.00") & ",'',"
                sqlstring = sqlstring & " '" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(txt_Holder_Code.Text) & "','" & Trim(Txt_holder_name.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"

            ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                sqlstring = "INSERT INTO BILL_HDR(BTYPE,Billno,BillDetails,BillDate,BillTime,DiscountAmount,PackAmount,TaxAmount,BillAmount,Roundoff,Roundoffaccountcode,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks,servicelocation,CARDHOLDERCODE,CARDHOLDERNAME) VALUES"
                sqlstring = sqlstring & " ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "','" & Format(serverdate, "hh:mm:ss") & "'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_TotalValue.Text) & "," & Format(Val(Amt), "0.00") & ",'" & Trim(Roundaccountcode) & " ',"
                sqlstring = sqlstring & " '" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(gDebitors) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Me.txt_MemberCode.Text) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & loccode & "','" & Trim(txt_Holder_Code.Text) & "','" & Trim(Txt_holder_name.Text) & "')"
            ElseIf cbo_PaymentMode.SelectedItem = "CARD" Then
                '''************************************************** $ IF PAYMENTMODE IS "CARD"  $ ********************************************'''
                If CStr(cbo_PaymentMode.Text) = "CARD" Then
                    If smartcardbool = True Then
                        sqlstring = "SELECT Minimumusage FROM MEMBERMASTER WHERE MCODE ='" & Trim(CStr(txt_MemberCode.Text)) & "' "
                        gconnection.getDataSet(sqlstring, "MinimumusageMaster")
                        If gdataset.Tables("MinimumusageMaster").Rows.Count > 0 Then
                            If Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) = 0 Then
                                sqlstring = "SELECT CardAmt FROM MEMBERMASTER WHERE MCODE ='" & Trim(CStr(txt_MemberCode.Text)) & "' "
                                gconnection.getDataSet(sqlstring, "CardAmtMaster")
                                If gdataset.Tables("CardAmtMaster").Rows.Count > 0 Then
                                    If Val(gdataset.Tables("CardAmtMaster").Rows(0).Item("CardAmt")) >= Val(txt_BillAmount.Text + Amt) Then
                                        sqlstring = "UPDATE MEMBERMASTER SET CardAmt = CardAmt - " & Math.Round(Val(Totalamount)) & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                        dblCard = Math.Round(Val(Totalamount))
                                        dblMinimum = 0
                                        ReDim Preserve Insert(Insert.Length)
                                        Insert(Insert.Length - 1) = sqlstring
                                    Else
                                        MessageBox.Show("!!! Warning !!! Refill your CARD before using ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                        cbo_PaymentMode.Focus()
                                        Exit Sub
                                    End If
                                End If
                            ElseIf Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) >= Val(Totalamount) Then
                                sqlstring = "UPDATE MEMBERMASTER SET Minimumusage = Minimumusage - " & Math.Round(Val(Totalamount)) & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                                dblCard = 0
                                dblMinimum = Math.Round(Val(Totalamount))
                            ElseIf Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) <= Val(Totalamount) And Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) > 0 Then
                                sqlstring = "UPDATE MEMBERMASTER SET Minimumusage = 0 WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                                dblMinimum = Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage"))
                                CardAmount = Math.Round(Val(Totalamount)) - Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage"))
                                sqlstring = "SELECT CardAmt FROM MEMBERMASTER WHERE MCODE ='" & Trim(CStr(txt_MemberCode.Text)) & "' "
                                gconnection.getDataSet(sqlstring, "CardAmtMaster")
                                If gdataset.Tables("CardAmtMaster").Rows.Count > 0 Then
                                    If Val(gdataset.Tables("CardAmtMaster").Rows(0).Item("CardAmt")) >= Val(Totalamount) Then
                                        sqlstring = "UPDATE MEMBERMASTER SET CardAmt = CardAmt - " & Format(Val(CardAmount), "0.00") & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                        ReDim Preserve Insert(Insert.Length)
                                        Insert(Insert.Length - 1) = sqlstring
                                        dblCard = Format(Val(CardAmount), "0.00")
                                    Else
                                        MessageBox.Show("!!! Warning !!! Refill your CARD before using ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                        cbo_PaymentMode.Focus()
                                        Exit Sub
                                    End If
                                End If
                            Else
                                MessageBox.Show("!!! Warning !!! Recharge your CARD before using ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                cbo_PaymentMode.Focus()
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("!!! Sorry !!! Transaction can't be proceed ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Exit Sub
                        End If
                    End If
                End If
                '''***************************************************** $ COMPLETE CALCULATION FOR CARD PAYMENTMODE ********************************************************************************'''
                sqlstring = "INSERT INTO BILL_HDR(BTYPE,Billno,BillDetails,BillDate,BillTime,DiscountAmount,PackAmount,TaxAmount,BillAmount,Roundoff,Roundoffaccountcode,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,servicelocation,CARDHOLDERCODE,CARDHOLDERNAME) VALUES"
                sqlstring = sqlstring & " ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(Me.dtp_KOTdate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "hh:mm:ss") & "'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_TotalValue.Text) & "," & Format(Val(Amt), "0.00") & ",'" & Trim(Roundaccountcode) & " ',"
                sqlstring = sqlstring & " '" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'," & Format(Val(dblMinimum), "0.00") & "," & Format(Val(dblCard), "0.00") & ",'" & Trim(CStr(Txt_Remarks.Text)) & "','" & loccode & "','" & Trim(txt_Holder_Code.Text) & "','" & Trim(Txt_holder_name.Text) & "')"
            Else
                Try
                    sqlstring = " SELECT ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
                    sqlstring = sqlstring & "WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
                    gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
                    If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                        If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) = "NO" Then
                            sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,DiscountAmount,PackAmount,TaxAmount,BillAmount,Roundoff,Roundoffaccountcode,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks,servicelocation,CARDHOLDERCODE,CARDHOLDERNAME) VALUES"
                            sqlstring = sqlstring & " ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(Me.dtp_KOTdate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "hh:mm:ss") & "'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_TotalValue.Text) & "," & Format(Val(Amt), "0.00") & ",'" & Trim(Roundaccountcode) & " ',"
                            sqlstring = sqlstring & " '" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','','','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                            sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & loccode & "','" & Trim(txt_Holder_Code.Text) & "','" & Trim(Txt_holder_name.Text) & "')"
                        Else
                            sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,DiscountAmount,PackAmount,TaxAmount,BillAmount,Roundoff,Roundoffaccountcode,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,servicelocation,CARDHOLDERCODE,CARDHOLDERNAME) VALUES"
                            sqlstring = sqlstring & " ('" & CMB_BTYPE.Text & "','" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(Me.dtp_KOTdate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "hh:mm:ss") & "'," & Val(txt_Discount.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_TotalValue.Text) & "," & Format(Val(Amt), "0.00") & ",'" & Trim(Roundaccountcode) & " ',"
                            sqlstring = sqlstring & " '" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "',"
                            sqlstring = sqlstring & " '" & Trim(Me.txt_ServerName.Text) & "','N',0,0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & loccode & "','" & Trim(txt_Holder_Code.Text) & "','" & Trim(Txt_holder_name.Text) & "')"
                        End If
                    Else
                        MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    End If
                Catch ex As Exception
                    MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End Try
            End If
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring
            '''*********************************************************** COMPLETE INSERTING BILL_HDR ***********************************************************************************************'''
            '''*********************************************************** INSERT INTO BILL_DET ******************************************************************************************************'''
            sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE  FROM TAXITEMLINK WHERE ITEMTYPECODE IN (SELECT ISNULL(ITEMTYPECODE,'') AS ITEMTYPECODE FROM ITEMMASTER INNER JOIN POSMENULINK ON "
            sqlstring = sqlstring & " ITEMMASTER.ITEMCODE = POSMENULINK.ITEMCODE WHERE POS= '" & Trim(POSLOCATION) & "') "
            gconnection.getDataSet(sqlstring, "ITEMMASTER")
            If gdataset.Tables("ITEMMASTER").Rows.Count > 0 Then
                sqlstring = " INSERT INTO Bill_Det(Billno,BillDetails,BillDate,KotDetails,TaxAmount,Packamount,Discountamount,KotAmount,Roundoff,OthBillDetails,KotDate,TaxCode) VALUES ("
                sqlstring = sqlstring & " '" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(Me.dtp_KOTdate.Value), "dd-MMM-yyyy") & "','" & Trim(CStr(txt_KOTno.Text)) & "',"
                sqlstring = sqlstring & " " & Val(txt_TaxValue.Text) & "," & Val(txt_PackingCharge.Text) & "," & Val(txt_Discount.Text) & "," & Val(txt_TotalValue.Text) & "," & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",'',"
                sqlstring = sqlstring & " '" & Format(CDate(Me.dtp_KOTdate.Value), "dd-MMM-yyyy") & "','" & Trim(gdataset.Tables("ITEMMASTER").Rows(0).Item("TAXCODE")) & "')"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring

                'billstatus = "ST"
                'sqlstring = "UPDATE KOT_HDR SET "
                'sqlstring = sqlstring & " BillStatus='" & Trim(billstatus) & "',Crostatus='N',PaymentType ='" & Trim(Me.cbo_PaymentMode.Text) & "',Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ',"
                'sqlstring = sqlstring & " SubPaymentMode ='" & Trim(SubpaymentMode(0)) & "',subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ' WHERE Kotdetails= '" & Trim(CStr(txt_KOTno.Text)) & "'"
                'ReDim Preserve Insert(Insert.Length)
                'Insert(Insert.Length - 1) = sqlstring
                sqlstring = "UPDATE KOT_HDR SET "
                sqlstring = sqlstring & " Crostatus='N',PaymentType ='" & Trim(Me.cbo_PaymentMode.Text) & "',Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ',"
                sqlstring = sqlstring & " SubPaymentMode ='" & Trim(SubpaymentMode(0)) & "',subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ' WHERE Kotdetails= '" & Trim(CStr(txt_KOTno.Text)) & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring

                sqlstring = "UPDATE KOT_DET SET BillDetails='" & Trim(CStr(txt_KOTno.Text)) & "'"
                sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
            End If
            '''*********************************************************** COMPLETE INSERTING BILL_DET ***********************************************************************************************'''
            ''''************************************************** $ BILL SETTLEMENT IF ANY   $ ********************************************'''
            If ssgridPayment.DataRowCnt = 0 Then
                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,Poscode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,Bankname,ReceivedName,Payamount,Billamount,Balanceamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime,Delflag ) VALUES ("
                sqlstring = sqlstring & " '" & Trim(CStr(KOTno(1))) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "','" & Trim(cbo_PaymentMode.Text) & "','" & Trim(POSLOCATION) & "','" & Trim(paymentaccountcode) & "','" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "', "
                sqlstring = sqlstring & " '','','" & Format(serverdate, "dd-MMM-yyyy") & "','',''," & Format(Val(txt_BillAmount.Text), "0.00") & ", " & Format(Val(txt_BillAmount.Text), "0.00") & ",0,'" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N') "
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
            Else
                For Z = 1 To ssgridPayment.DataRowCnt
                    ssgridPayment.Col = 1
                    ssgridPayment.Row = Z
                    If Trim(ssgridPayment.Text) <> "" Then
                        ssgridPayment.Col = 3
                        ssgridPayment.Row = Z
                        sqlstring = " SELECT ISNULL(Accountin,'') AS ACCOUNTIN,ISNULL(Paymentcode,'') AS Paymentcode,ISNULL(paymentType,'') AS paymentType  FROM paymentmodemaster WHERE Paymentcode = '" & Trim(ssgridPayment.Text) & "' AND ISNULL(Freeze,'')='N'"
                        gconnection.getDataSet(sqlstring, "paymentmodemaster")
                        If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                            If Trim(ssgridPayment.Text) = Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("Paymentcode")) And Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentType")) = "CD" Then
                                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,Poscode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,"
                                sqlstring = sqlstring & "Bankname,ReceivedName,Payamount,Billamount,Balanceamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime,Delflag ) VALUES ("
                                ssgridPayment.Row = Z
                                ssgridPayment.Col = 1
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 2
                                sqlstring = sqlstring & "'" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "',"
                                ssgridPayment.Col = 3
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "','" & Trim(POSLOCATION) & "',"
                                sqlstring = sqlstring & "'" & Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin")) & "',"
                                ssgridPayment.Col = 5
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 6
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                sqlstring = sqlstring & "'" & Trim(txt_Typeofcard.Text) & "','" & Trim(txt_Cardno.Text) & "','" & Format(dtp_Expirydate.Value, "dd-MMM-yyyy") & "','','" & Trim(txt_Cardholdername.Text) & "',"
                                ssgridPayment.Col = 4
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 7
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 8
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                sqlstring = sqlstring & "'" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                            ElseIf Trim(ssgridPayment.Text) = Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("Paymentcode")) And Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentType")) = "CQ" Then
                                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,Poscode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,"
                                sqlstring = sqlstring & "Bankname,ReceivedName,Payamount,Billamount,Balanceamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime,Delflag ) VALUES ("
                                ssgridPayment.Row = Z
                                ssgridPayment.Col = 1
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 2
                                sqlstring = sqlstring & "'" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "',"
                                ssgridPayment.Col = 3
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "','" & Trim(POSLOCATION) & "',"
                                sqlstring = sqlstring & "'" & Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin")) & "',"
                                ssgridPayment.Col = 5
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 6
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                sqlstring = sqlstring & "'" & Trim(cbo_Typeofcheque.Text) & "','" & Trim(txt_Chequeno.Text) & "','" & Format(dtp_Chequedate.Value, "dd-MMM-yyyy") & "','" & Trim(txt_Draweebank.Text) & "','',"
                                ssgridPayment.Col = 4
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 7
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 8
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                sqlstring = sqlstring & "'" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                            Else
                                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,Poscode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,"
                                sqlstring = sqlstring & "Bankname,ReceivedName,Payamount,Billamount,Balanceamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime,Delflag ) VALUES ("
                                ssgridPayment.Row = Z
                                ssgridPayment.Col = 1
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 2
                                sqlstring = sqlstring & "'" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "',"
                                ssgridPayment.Col = 3
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "','" & Trim(POSLOCATION) & "',"
                                sqlstring = sqlstring & "'" & Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin")) & "',"
                                ssgridPayment.Col = 5
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 6
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                sqlstring = sqlstring & "'','','" & Format(serverdate, "dd-MMM-yyyy") & "','','',"
                                ssgridPayment.Col = 4
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 7
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 8
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                sqlstring = sqlstring & "'" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                            End If
                        End If
                    End If
                Next Z
            End If
            '''''************************************************** $ BILL SETTLEMENT COMPLETE   $ ********************************************'''
            '''*********************************************************** COMPLETE ******************************************************************************************************************'''
            '---------------------
            'If Len(Oldtaxbillno) > 0 Then
            ''**************************Inserting Data into ROOM LEDGER table **************************************
            If cbo_PaymentMode.SelectedItem = "ROOM" Then
                sqlstring = "INSERT INTO ROOMLEDGER(CHKNO,DOCNO,DOCDATE,DOCTYPE,FOLIONO,AMOUNT,POSCODE,"
                sqlstring = sqlstring & "ROOMNO,REFNO,CREDITDEBIT,PAYMENTMODE,VOUCHERTYPE,VOUCHERCATEGORY,KOTNO)"
                sqlstring = sqlstring & " Values('" & txt_MemberCode.Tag & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(Me.dtp_KOTdate.Value), "dd-MMM-yyyy") & "','SALES',1," & Val(txt_BillAmount.Text) & ","
                sqlstring = sqlstring & "'" & loccode & "'," & Val(Me.txt_MemberCode.Text) & ",'" & txt_MemberCode.Tag & "','DEBIT','ROOM','RM','RM',1)"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
            End If
            '--------------------
            'Settlement 
            'begin
            'If cbo_PaymentMode.SelectedItem <> "ROOM" Then
            With ssgrid_settlement
                If .DataRowCnt = 1 Or .DataRowCnt = 0 Then
                    sqlstring = "INSERT INTO SETTLEMENT(BILLDETAILS,BILLDATE,MCODE,AMOUNT,DESCRIPTION,deleteflag,SBILLFLAG) "
                    sqlstring = sqlstring & "VALUES('" & txt_KOTno.Text & "','" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "',"
                    sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "'," & txt_BillAmount.Text & ",'','N','N')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring

                    sqlstring = "UPDATE BILL_HDR SET SBILLFLAG='N' WHERE BILLDETAILS='" & txt_KOTno.Text & "'"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                Else
                    For i = 1 To .DataRowCnt
                        sqlstring = "INSERT INTO SETTLEMENT(BILLDETAILS,BILLDATE,MCODE,AMOUNT,DESCRIPTION,DELETEFLAG,SBILLFLAG) "
                        sqlstring = sqlstring & "VALUES('" & txt_KOTno.Text & "','" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "',"
                        .Col = 1
                        .Row = i
                        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                        .Col = 2
                        .Row = i
                        sqlstring = sqlstring & Math.Round(Val(Trim(.Text)), 2) & ","
                        .Col = 3
                        .Row = i
                        sqlstring = sqlstring & "'" & Trim(.Text) & "','N','Y')"
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = sqlstring
                    Next
                    sqlstring = "UPDATE BILL_HDR SET SBILLFLAG='Y' WHERE BILLDETAILS='" & txt_KOTno.Text & "'"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                End If
            End With
            sqlstring = " SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & POSLOCATION & "'"
            gconnection.getDataSet(sqlstring, "AccountIn")
            If (gdataset.Tables("AccountIn").Rows.Count > 0) Then
                desc = gdataset.Tables("AccountIn").Rows(0).Item("POSDESC")
            Else
                desc = ""
            End If
            'End If
            gconnection.MoreTransold1(Update2)
            If Trim(cbo_PaymentMode.Text) = "CREDIT" Then
                sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' And ISNULL(SUBPAYSTATUS,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "AccountIn")
                If (gdataset.Tables("AccountIn").Rows.Count > 0) Then
                    strSaleCostAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERCODE"))
                    strSaleCostAccountInDesc = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERDESC"))
                    'If Trim(CMB_BTYPE.Text) = "BAR" Then
                    '    strAccountIn = "SDRSB"
                    'Else
                    strAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("AccountIn"))
                    'End If
                Else
                    sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "'ISNULL(SUBPAYSTATUS,'')='N'"
                    strAccountIn = ""
                    strSaleCostAccountIn = ""
                    strSaleCostAccountInDesc = ""
                End If
            Else
                sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' And ISNULL(SUBPAYSTATUS,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "AccountIn")
                If (gdataset.Tables("AccountIn").Rows.Count > 0) Then
                    strAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("AccountIn"))
                    strSaleCostAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERCODE"))
                    strSaleCostAccountInDesc = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERDESC"))
                Else
                    sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "'ISNULL(SUBPAYSTATUS,'')='N'"
                    strAccountIn = ""
                    strSaleCostAccountIn = ""
                    strSaleCostAccountInDesc = ""
                End If
            End If
            sqlstring = "select isnull(roundacctin,'') as rndoff_acode,isnull(roundacctdesc,'') as rndoff_desc  from  possetup "
            sqlstring = sqlstring & " where isnull(BILLROUNDOFF,'')='YES'"
            gconnection.getDataSet(sqlstring, "Rndoff")
            If (gdataset.Tables("Rndoff").Rows.Count > 0) Then
                rndoff_acode = gdataset.Tables("Rndoff").Rows(0).Item("rndoff_acode")
                rndoff_desc = gdataset.Tables("Rndoff").Rows(0).Item("rndoff_desc")
            Else
                rndoff_acode = ""
                rndoff_desc = ""
            End If



            If Me.cbo_SubPaymentMode.Visible = True Then
                strAccountIn = Subpaymentaccountcode
            End If

            sqlstring = "SELECT ISNULL(MAX(ISNULL(BATCHNO,0)),0) AS BATCHNO FROM JOURNALENTRY"
            gconnection.getDataSet(sqlstring, "BatchNo")
            If (gdataset.Tables("BatchNo").Rows.Count > 0) Then
                strBatchNo = Trim(gdataset.Tables("BatchNo").Rows(0).Item("BATCHNO"))
            Else
                strBatchNo = ""
            End If
            Subledger_flag = ""
            If (strAccountIn <> "") Then
                sqlstring = "SELECT ISNULL(ACDESC,'') AS ACDESC,isnull(subledgerflag,'') as subflg FROM ACCOUNTSGLACCOUNTMASTER WHERE ACCODE = '" & strAccountIn & "'"
                gconnection.getDataSet(sqlstring, "AccountDesc")
                If (gdataset.Tables("AccountDesc").Rows.Count > 0) Then
                    strAccountDesc = Trim(gdataset.Tables("AccountDesc").Rows(0).Item("ACDESC"))
                    Subledger_flag = Trim(gdataset.Tables("AccountDesc").Rows(0).Item("subflg"))
                Else
                    strAccountDesc = ""
                    Subledger_flag = ""
                End If
            End If
            sqlstring = " Delete from  Journalentry Where voucherno='" & txt_KOTno.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring


            If UCase(Trim(CMB_BTYPE.Text)) = "NIA" Or UCase(Trim(CMB_BTYPE.Text)) = "CKA" Or UCase(Trim(CMB_BTYPE.Text)) = "ACH" Then
                sqlstring = "update kot_det  set PACKPERCENT=5,Packamount=(isnull(amount,0) *5/100) Where  kotdetails='" & txt_KOTno.Text & "' and isnull(poscode,'') not in('12','13')"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
            End If

            sqlstring = " Update kot_det  set  packamt=b.packamount from kot_det a, view_kot  b "
            sqlstring = sqlstring & "where a.kotdetails=b.kotdetails and a.kotdetails='" & txt_KOTno.Text & "' "
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring


            sqlstring = "update kot_det  set ser_chg=((isnull(amount,0)*75/100) *(5.15/100)) Where  kotdetails='" & txt_KOTno.Text & "' and isnull(poscode,'') IN('ACH','NCH')"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring


            sqlstring = " update kot_hdr set packamt=isnull(b.packamount,0),SER_CHG=isnull(b.SER_CHG,0)  from kot_hdr a, view_kot  b "
            sqlstring = sqlstring & " where a.kotdetails=b.kotdetails and a.kotdetails='" & txt_KOTno.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            sqlstring = " update kot_hdr set billamount=ISNULL(packamt+totaltax + total+SER_CHG,0)  from kot_hdr where kotdetails='" & txt_KOTno.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            sqlstring = " update Bill_hdr set packamount=isnull(b.packamount,0),Ser_Chg=isnull(b.Ser_chg,0) from bill_hdr a, view_kot  b "
            sqlstring = sqlstring & " where a.billdetails=b.billdetails and a.billdetails='" & txt_KOTno.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            sqlstring = " UPDATE ROOMLEDGER SET AMOUNT=ISNULL(B.TOTALAMOUNT,0)+ISNULL(B.ROUNDOFF,0) FROM  ROOMLEDGER A,BILL_HDR B WHERE B.BILLDETAILS=A.DOCNO AND  A.DOCNO='" & txt_KOTno.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            sqlstring = " Drop Table  " & vOutfile
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            '-----------------------------------------------JOURNAL END
            'ALL RECORD INSERTING HERE
            '            gconnection.MoreTransold(Insert)
            '----------- facility insert query begin
            If ssgrid_Fac.DataRowCnt > 0 Then
                strSQL = "delete FROM facility_HDR where  billdetails='" & Trim(txt_KOTno.Text) & "'  --and mcode='" & txt_MemberCode.Text & "' And cast(convert(char(11),Billdate,6) as datetime)='" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = strSQL

                strSQL = "delete FROM facility_det where  billdetails='" & Trim(txt_KOTno.Text) & "' "

                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = strSQL

                For i = 1 To ssgrid_Fac.DataRowCnt Step 1
                    strSQL = "INSERT INTO facility_HDR(BILLDETAILS,Billdate,MCODE,TYPE,DNAME,FCODE,FREEZE,FTYPE)"
                    strSQL = strSQL & " VALUES ( '" & Trim(txt_KOTno.Text) & "',"
                    strSQL = strSQL & " '" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "',"

                    strSQL = strSQL & " '" & Trim(txt_MemberCode.Text) & "','"
                    ssgrid_Fac.Col = 1
                    ssgrid_Fac.Row = i
                    strSQL = strSQL & Trim(ssgrid_Fac.Text) & "','"
                    _TYPE = Trim(ssgrid_Fac.Text)

                    ssgrid_Fac.Col = 2
                    ssgrid_Fac.Row = i
                    strSQL = strSQL & Trim(ssgrid_Fac.Text) & "','"
                    _DNAME = Trim(ssgrid_Fac.Text)

                    ssgrid_Fac.Col = 3
                    ssgrid_Fac.Row = i
                    strSQL = strSQL & Trim(ssgrid_Fac.Text) & "','Y','D')"
                    _FCODE = Trim(ssgrid_Fac.Text)

                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = strSQL
                Next i
            End If
            '----------- facility insert query end
            '--------------------
            'CSC SMARTCARD
            '****************SHOW SMART CARD CARD TRANSACTION*****************
            Dim STRSQL2, SSTR As String
            STRSQL2 = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & CARDCODE & "' AND POSCODE='" & StrPOSCODE & "'"
            'STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'F' "
            gconnection.getDataSet(STRSQL2, "SM_CARDFILE_DET")
            If gdataset.Tables("SM_CARDFILE_DET").Rows.Count > 0 Then
                POS_AMT_GBL = Val(txt_TotalValue.Text)
                STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'F' "
                gconnection.getDataSet(STRSQL2, "FACILITY")
                If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                    'ONCE FACILITY 
                    KOT_NO_GBL = Trim(txt_KOTno.Text)
                    gconnection.MORETRANS(Insert)
                    If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Call Cmd_Print_Click(Cmd_Print, e)
                        Call cmd_Clear_Click(sender, e)
                        If kotupdate = True Then
                            Me.Close()
                        End If
                    Else
                        Call cmd_Clear_Click(sender, e)
                        If kotupdate = True Then
                            Me.Close()
                        Else
                            Me.Close()
                        End If
                        txt_MemberCode.Focus()
                    End If


                    SSTR = "SELECT * FROM SM_POSTRANSACTION WHERE BILL_NO='" & Trim(KOT_NO_GBL) & "'"
                    gconnection.getDataSet(SSTR, "SM_POSTRANSACTION")
                    If gdataset.Tables("SM_POSTRANSACTION").Rows.Count > 0 Then
                        Dim DE_TRA_AMEND As New DEBIT_CARD_TRANSACTION
                        D_CARDUPDATE = True
                        DE_TRA_AMEND.Show()
                    Else
                        Dim DE_TRA As New DEBIT_CARD_TRANSACTION
                        D_CARDUPDATE = False
                        DE_TRA.Show()
                    End If
                    Call autogenerate()

                    'Dim dc_tra As New DEBIT_CARD_TRANSACTION
                    'dc_tra.FormBorderStyle = FormBorderStyle.FixedToolWindow
                    'dc_tra.MdiParent = MDIParentobj
                    'dc_tra.Show()

                    Exit Sub
                Else
                    'CSC SMART CARD CARD
                    '****************SHOW SMART CARD CARD TRANSACTION*****************
                    Dim STRSQL As String
                    If cbo_PaymentMode.Text = "SMART CARD" Then
                        'SALE SMARTCARD 
                        'POSCODE GBL  HARDCODE TO KITCHEN 
                        'KARTHI CHECK MIN BALANCE AND PROCEED FOR CARD BALANCE
                        'NOV 14
                        If MIN_USAGE_BALANCE_HDR >= Val(txt_BillAmount.Text + Amt) Then

                            STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & CARDCODE & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & Val(txt_BillAmount.Text + Amt) & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FM')"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL

                            STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & Val(txt_BillAmount.Text + Amt) & " WHERE CARDCODE='" & CARDCODE & "'"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL


                        ElseIf MIN_USAGE_BALANCE_HDR <= 0 Then
                            'DEDUCT AMOUNT ONLY FROM CARD

                            Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                            DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR
                            DEDUCT_FROM_CARD = Val(txt_BillAmount.Text + Amt) - MIN_USAGE_BALANCE_HDR


                            STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & CARDCODE & "'"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL


                            STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & CARDCODE & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FC')"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL

                        ElseIf MIN_USAGE_BALANCE_HDR > 0 And MIN_USAGE_BALANCE_HDR < Val(txt_BillAmount.Text + Amt) Then

                            Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                            DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR
                            DEDUCT_FROM_CARD = Val(txt_BillAmount.Text + Amt) - MIN_USAGE_BALANCE_HDR

                            STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & CARDCODE & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_MINUSAGE & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HM')"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL


                            STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & CARDCODE & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HC')"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL


                            STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & DEDUCT_FROM_MINUSAGE & " WHERE CARDCODE='" & CARDCODE & "'"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL

                            STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & CARDCODE & "'"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL
                        End If
                        'Else
                        '   STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & Val(txt_BillAmount.Text) & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','O')"
                        '  ReDim Preserve Insert(Insert.Length)
                        ' Insert(Insert.Length - 1) = STRSQL
                    End If
                    gconnection.MoreTransold(Insert)
                    If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Call Cmd_Print_Click(Cmd_Print, e)
                        Call cmd_Clear_Click(sender, e)
                        '***********CHANGE
                        MNAME_GBL = ""
                        MCODE_GBL = ""
                        CARDCODE = ""
                        NAME_GBL = ""
                        '***********CHANGE
                        If kotupdate = True Then
                            Me.Close()
                        End If
                    Else

                        Call cmd_Clear_Click(sender, e)
                        If kotupdate = True Then
                            Me.Close()
                        End If
                    End If
                    Exit Sub
                End If
            Else
                gconnection.MoreTransold(Insert)
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call Cmd_Print_Click(Cmd_Print, e)
                    Call cmd_Clear_Click(sender, e)
                    If kotupdate = True Then
                        Me.Close()
                    End If
                Else
                    Call cmd_Clear_Click(sender, e)
                    If kotupdate = True Then
                        Me.Close()
                    End If
                End If
            End If

            '================================
            'CSC SMART CARD CARD
            'karthi july 08 
            If Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
                MessageBox.Show("PLEASE! SWIPE YOUR CARD", "CARD NOT SWIPED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = False
                txt_card_id.Focus()
                '                lbl_SwipeCard.Focus()
                Exit Sub
            Else
                If cbo_PaymentMode.Text = "SMART CARD" Then
                    Call cardcheck()
                End If
            End If

            '****************SMART CARD CARD*****************
            'KARTHI SMART CARD CARD JUNE 3
            'CSC SMART CARD CARD KARTHI JUNE 3

            'If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            '    Call Cmd_Print_Click(Cmd_Print, e)
            '    Call cmd_Clear_Click(sender, e)
            '    If kotupdate = True Then
            '        Me.Close()
            '    End If
            'Else
            '    Call cmd_Clear_Click(sender, e)
            '    If kotupdate = True Then
            '        Me.Close()
            '    End If
            'End If


            Call cmd_Clear_Click(sender, e)
            Call txt_MemberCode_Validated(sender, e)

            '''*********************************************************** Case-2 : Update [F7] *******************************************'''
        Else ' UPDATE  "U"

            'CSC SMART CARD CARD
            'karthi july 08 
            If Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
                MessageBox.Show("PLEASE! SWIPE YOUR CARD", "CARD NOT SWIPED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = False
                txt_card_id.Focus()
                '                lbl_SwipeCard.Focus()
                Exit Sub
            Else
                If cbo_PaymentMode.Text = "SMART CARD" Then
                    Call cardcheck()
                End If
            End If
            ReDim Preserve Update2(Update2.Length)
            Update2(Update2.Length - 1) = " SELECT * INTO " & vOutfile & " FROM KOT_DET WHERE KOTDETAILS='" & txt_KOTno.Text & "'"
            KOTno = Split(Trim(txt_KOTno.Text), "/")
            Me.txt_TotalValue.Text = 0
            Me.txt_TaxValue.Text = 0
            Me.txt_PackingCharge.Text = 0
            For i = 1 To ssGrid.DataRowCnt
                cancel = Nothing
                Taxamt = Nothing
                Totalamt = Nothing
                Packamt = Nothing
                ssGrid.GetText(12, i, cancel)
                If Val(cancel) = 0 Then
                    ssGrid.GetText(7, i, Taxamt)
                    ssGrid.GetText(8, i, Totalamt)
                    ssGrid.GetText(18, i, Packamt)
                    Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(Totalamt), "0.00")
                    Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(Taxamt), "0.00")
                    Me.txt_PackingCharge.Text = Format(Val(Me.txt_PackingCharge.Text) + Val(Packamt), "0.00")
                End If
            Next i
            If Val(txt_Discount.Text) = 0 Then
                Billroundoff = Val(Me.txt_TotalValue.Text) + Val(Me.txt_TaxValue.Text) + Val(Me.txt_PackingCharge.Text)
                Round = CStr(Billroundoff)

                'If BILLROUNDYESNO = "YES" Then
                '    If Round.IndexOf(".") <= 0 Then
                '        Round = Round.Insert(Round.Length - 1, ".00")
                '    End If
                '    Roundedvalue = Split(Round, ".")
                '    If Format(Val(Roundedvalue(1)), "00") = 50 Then
                '        Billroundoff = Math.Ceiling(Billroundoff)
                '    ElseIf Format(Val(Roundedvalue(1)), "00") > 50 Then
                '        Billroundoff = Math.Ceiling(Billroundoff)
                '    Else
                '        Billroundoff = Math.Floor(Billroundoff)
                '    End If
                '    Roundoff1 = Mid(Format(Val(Billroundoff), "0.00"), Len(Format(Val(Billroundoff), "0.00")) - 1, Len(Format(Val(Billroundoff), "0.00")))
                '    If Format(Val(Roundoff1), "00") = 50 Then
                '        Billroundoff = Math.Ceiling(Billroundoff)
                '    ElseIf Format(Val(Roundoff1), "00") > 50 Then
                '        Billroundoff = Math.Ceiling(Billroundoff)
                '    Else
                '        Billroundoff = Math.Floor(Billroundoff)
                '    End If
                '    Me.txt_BillAmount.Text = Format(Val(Billroundoff), "0.00")
                'Else
                '    Roundoff1 = Mid(Format(Val(Billroundoff), "0.00"), Len(Format(Val(Billroundoff), "0.00")) - 1, Len(Format(Val(Billroundoff), "0.00")))
                '    Me.txt_BillAmount.Text = Format(Val(Billroundoff), "0.00")
                'End If
            Else
                dbldicountAmount = (Val(txt_TotalValue.Text) * Val(txt_Discount.Text)) / 100
                dblGrossAmount = Val(txt_TotalValue.Text) - Val(dbldicountAmount)
                dbldicountTax = (Val(txt_TaxValue.Text) * Val(txt_Discount.Text)) / 100
                dblGrossTax = Val(txt_TaxValue.Text) - Val(dbldicountTax)
                dbldicountPack = (Val(txt_PackingCharge.Text) * Val(txt_Discount.Text)) / 100
                dblGrossPack = Val(txt_PackingCharge.Text) - Val(dbldicountPack)
                dblDicountBillAmount = dblGrossAmount + dblGrossTax + dblGrossPack
                Me.txt_TotalValue.Text = Format(Val(dblGrossAmount), "0.00")
                Me.txt_TaxValue.Text = Format(Val(dblGrossTax), "0.00")
                Me.txt_PackingCharge.Text = Format(Val(dblGrossPack), "0.00")
                Round = CStr(dblDicountBillAmount)
                If BILLROUNDYESNO = "YES" Then
                    If Round.IndexOf(".") <= 0 Then
                        Round = Round.Insert(Round.Length - 1, ".00")
                    End If
                    Roundedvalue = Split(Round, ".")
                    If Format(Val(Roundedvalue(1)), "00") = 50 Then
                        Billroundoff = Math.Ceiling(dblDicountBillAmount)
                    ElseIf Format(Val(Roundedvalue(1)), "00") > 50 Then
                        Billroundoff = Math.Ceiling(dblDicountBillAmount)
                    Else
                        Billroundoff = Math.Floor(dblDicountBillAmount)
                    End If
                    Roundoff1 = Mid(Format(Val(dblDicountBillAmount), "0.00"), Len(Format(Val(dblDicountBillAmount), "0.00")) - 1, Len(Format(Val(dblDicountBillAmount), "0.00")))
                    If Format(Val(Roundoff1), "00") = 50 Then
                        dblDicountBillAmount = Math.Ceiling(dblDicountBillAmount)
                    ElseIf Format(Val(Roundoff1), "00") > 50 Then
                        dblDicountBillAmount = Math.Ceiling(dblDicountBillAmount)
                    Else
                        dblDicountBillAmount = Math.Floor(dblDicountBillAmount)
                    End If
                    'Me.txt_BillAmount.Text = Format(Math.Round(Val(dblDicountBillAmount)), "0.00")
                    'Me.txt_BillAmount.Text = Format(Val(dblDicountBillAmount), "0.00")
                Else
                    Roundoff1 = Mid(Format(Val(dblDicountBillAmount), "0.00"), Len(Format(Val(dblDicountBillAmount), "0.00")) - 1, Len(Format(Val(dblDicountBillAmount), "0.00")))
                    'Me.txt_BillAmount.Text = Format(Val(dblDicountBillAmount), "0.00")
                End If
            End If
            '''******************************************* Find Out Subpaymentmode Accountcode *****************************'''
            If Me.cbo_SubPaymentMode.Visible = True Then
                SubpaymentMode = Split(Trim(Me.cbo_SubPaymentMode.Text), "-")
                sqlstring = "SELECT Accountin FROM subpaymentmode WHERE Subpaymentcode ='" & Trim(SubpaymentMode(0)) & "' AND ISNULL(Freeze,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "subpaymentmode")
                If gdataset.Tables("subpaymentmode").Rows.Count > 0 Then
                    Subpaymentaccountcode = Trim(gdataset.Tables("subpaymentmode").Rows(0).Item("Accountin") & "")
                End If
            Else
                ReDim Preserve SubpaymentMode(1)
                SubpaymentMode(0) = ""
                Subpaymentaccountcode = ""
            End If
            '''******************************************* Find Out Paymentmode Accountcode  *****************************'''
            sqlstring = "SELECT Accountin FROM Paymentmodemaster WHERE Paymentcode ='" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(Freeze,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "Paymentmodemaster")
            If gdataset.Tables("Paymentmodemaster").Rows.Count > 0 Then
                paymentaccountcode = Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin") & "")
            Else
                MessageBox.Show("Assign a AccountCode For Specified PAYMENTMODE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                paymentaccountcode = ""
                Exit Sub
            End If
            '''************************************************************* ROUND OFF ACCT IN *******************'''
            sqlstring = "SELECT ISNULL(ROUNDACCTIN,'') AS ROUNDACCTIN FROM POSSETUP WHERE ISNULL(ROUNDACCTIN,'') <> ''"
            gconnection.getDataSet(sqlstring, "POSSETUP")
            If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                Roundaccountcode = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("ROUNDACCTIN") & "")
            Else
                MessageBox.Show("Assign a AccountCode For Specified ROUNDOFF VALUE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Roundaccountcode = ""
                Exit Sub
            End If
            If Me.Lbl_Bill.Visible = True And Me.Lbl_Bill.Text = "CRO GENERATED" Then
                MessageBox.Show("As CRO is generated so Bill Can't be modified", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Call cmd_Clear_Click(cmd_Clear, e)
                Cmd_Add.Enabled = True
                Exit Sub
            ElseIf Me.Lbl_Bill.Visible = True And Trim(Me.Lbl_Bill.Text) = "BILL GENERATED" Then
                '''********************************************************** UPDATE KOT_HDR *********************************************************'''
                If cbo_PaymentMode.SelectedItem = "ROOM" Then
                    sqlstring = "SELECT ISNULL(CHECKOUT,'N') AS CHECKOUT,ISNULL(ROOMNO,0)AS ROOMNO FROM ROOMCHECKIN WHERE DOCNO = " & Val(txt_MemberCode.Tag) & ""
                    gconnection.getDataSet(sqlstring, "Roomcheckin")
                    If gdataset.Tables("Roomcheckin").Rows.Count > 0 Then
                        If Trim(CStr(gdataset.Tables("Roomcheckin").Rows(0).Item("CHECKOUT"))) = "Y" Then
                            MessageBox.Show("Bill Can't be updated " & " as GUEST  had been checkout from RoomNo" & ": " & gdataset.Tables("Roomcheckin").Rows(0).Item("ROOMNO"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                            Call cmd_Clear_Click(cmd_Clear, e)
                            Cmd_Add.Enabled = True
                            Exit Sub
                        End If
                    End If
                    sqlstring = "UPDATE KOT_HDR SET [16_digit_code]='" & Trim(txt_card_id.Text) & "',kotdate='" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "',TableNo='" & Trim(txt_TableNo.Text) & "',Covers=" & Val(txt_Cover.Text) & ",DocType='" & Trim(doctype) & "',SaleType='SALE',AccountCode='" & Trim(accountcode) & "',"
                    sqlstring = sqlstring & " Slcode = '',Mcode= '',Mname= '',RoomNo='" & Trim(txt_MemberCode.Text) & "',Guest='" & Trim(txt_MemberName.Text) & "',checkin='" & Trim(txt_MemberCode.Tag) & "',STCode='" & Trim(txt_ServerCode.Text) & "',ServerCode='" & Trim(txt_ServerCode.Text) & "',ServerName='" & Trim(txt_ServerName.Text) & "',"
                    If BILLROUNDYESNO = "YES" Then
                        sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ", PackAmt =" & Val(txt_PackingCharge.Text) & ", Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                    Else
                        sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ", PackAmt =" & Val(txt_PackingCharge.Text) & ", Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                    End If
                    sqlstring = sqlstring & " SubPaymentMode='" & SubpaymentMode(0) & "',Roundoffaccountcode='" & Trim(Roundaccountcode) & "',upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Paymodeaccountcode = '" & Trim(paymentaccountcode) & " ',subpaymentaccountcode = '" & Trim(Subpaymentaccountcode) & " ' "
                    sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
                ElseIf cbo_PaymentMode.SelectedItem = "PENDING" Then
                    sqlstring = "UPDATE KOT_HDR SET [16_digit_code]='" & Trim(txt_card_id.Text) & "',Kotdate='" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "',TableNo='" & Trim(txt_TableNo.Text) & "',Covers=" & Val(txt_Cover.Text) & ",DocType='" & Trim(doctype) & "',SaleType='SALE',AccountCode='" & Trim(accountcode) & "',"
                    sqlstring = sqlstring & " Slcode = '" & Trim(txt_MemberCode.Text) & "',Mcode= '" & Trim(txt_MemberCode.Text) & "',Mname= '" & Trim(txt_MemberName.Text) & "',RoomNo='',Guest='',checkin='',STCode='" & Trim(txt_ServerCode.Text) & "',ServerCode='" & Trim(txt_ServerCode.Text) & "',ServerName='" & Trim(txt_ServerName.Text) & "',"
                    If BILLROUNDYESNO = "YES" Then
                        sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ",PackAmt =" & Val(txt_PackingCharge.Text) & ",Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                    Else
                        sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ",PackAmt =" & Val(txt_PackingCharge.Text) & ",Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                    End If
                    sqlstring = sqlstring & " SubPaymentMode='" & SubpaymentMode(0) & "',Roundoffaccountcode='" & Trim(Roundaccountcode) & "',upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Paymodeaccountcode = '" & Trim(gDebitors) & " ',subpaymentaccountcode = '" & Trim(txt_MemberCode.Text) & "' "
                    sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
                ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                    sqlstring = "UPDATE KOT_HDR SET [16_digit_code]='" & Trim(txt_card_id.Text) & "',Kotdate='" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "',TableNo='" & Trim(txt_TableNo.Text) & "',Covers=" & Val(txt_Cover.Text) & ",DocType='" & Trim(doctype) & "',SaleType='SALE',AccountCode='" & Trim(accountcode) & "',"
                    sqlstring = sqlstring & " Slcode = '" & Trim(txt_MemberCode.Text) & "',Mcode= '" & Trim(txt_MemberCode.Text) & "',Mname= '" & Trim(txt_MemberName.Text) & "',RoomNo='',Guest='',checkin='',STCode='" & Trim(txt_ServerCode.Text) & "',ServerCode='" & Trim(txt_ServerCode.Text) & "',ServerName='" & Trim(txt_ServerName.Text) & "',"
                    If BILLROUNDYESNO = "YES" Then
                        sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ",PackAmt =" & Val(txt_PackingCharge.Text) & ",Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                    Else
                        sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ",PackAmt =" & Val(txt_PackingCharge.Text) & ",Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                    End If
                    sqlstring = sqlstring & " SubPaymentMode='" & SubpaymentMode(0) & "',Roundoffaccountcode='" & Trim(Roundaccountcode) & "',upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Paymodeaccountcode = '" & Trim(gDebitors) & " ',subpaymentaccountcode = '" & Trim(txt_MemberCode.Text) & "' "
                    sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
                Else
                    Try
                        sqlstring = " SELECT ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
                        sqlstring = sqlstring & "WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
                        gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
                        If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                            If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) = "NO" Then
                                sqlstring = "UPDATE KOT_HDR SET [16_digit_code]='" & Trim(txt_card_id.Text) & "',Kotdate='" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "',TableNo='" & Trim(txt_TableNo.Text) & "',Covers=" & Val(txt_Cover.Text) & ",DocType='" & Trim(doctype) & "',SaleType='SALE',AccountCode='" & accountcode & "',"
                                sqlstring = sqlstring & " Slcode = '',Mcode= '',Mname= '',RoomNo='',Guest='',checkin='',STCode='" & Trim(txt_ServerCode.Text) & "',ServerCode='" & Trim(txt_ServerCode.Text) & "',ServerName='" & Trim(txt_ServerName.Text) & "',"
                                'sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ",PackAmt =" & Val(txt_PackingCharge.Text) & ",Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                                If BILLROUNDYESNO = "YES" Then
                                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ",PackAmt =" & Val(txt_PackingCharge.Text) & ",Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                                Else
                                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ",PackAmt =" & Val(txt_PackingCharge.Text) & ",Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                                End If
                                sqlstring = sqlstring & " SubPaymentMode='" & SubpaymentMode(0) & "',Roundoffaccountcode='" & Trim(Roundaccountcode) & "',upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Paymodeaccountcode = '" & Trim(paymentaccountcode) & " ',subpaymentaccountcode = '" & Trim(Subpaymentaccountcode) & " ' "
                                sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
                            Else
                                sqlstring = "UPDATE KOT_HDR SET [16_digit_code]='" & Trim(txt_card_id.Text) & "',Kotdate='" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "',TableNo='" & Trim(txt_TableNo.Text) & "',Covers=" & Val(txt_Cover.Text) & ",DocType='" & Trim(doctype) & "',SaleType='SALE',AccountCode='" & accountcode & "',"
                                sqlstring = sqlstring & " SLCode='" & Trim(txt_MemberCode.Text) & "',MCode='" & Trim(txt_MemberCode.Text) & "',Mname='" & Trim(txt_MemberName.Text) & "',STCode='" & Trim(txt_ServerCode.Text) & "',ServerCode='" & Trim(txt_ServerCode.Text) & "',ServerName='" & Trim(txt_ServerName.Text) & "',"
                                If BILLROUNDYESNO = "YES" Then
                                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ",PackAmt =" & Val(txt_PackingCharge.Text) & ",Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                                Else
                                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',DiscountAmt =" & Val(txt_Discount.Text) & ",PackAmt =" & Val(txt_PackingCharge.Text) & ",Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Roundoff = " & Format((Val(txt_BillAmount.Text)) - (Val(txt_TotalValue.Text) + Val(txt_PackingCharge.Text) + Val(txt_TaxValue.Text)), "0.00") & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                                End If
                                sqlstring = sqlstring & " SubPaymentMode='" & SubpaymentMode(0) & "',Roundoffaccountcode='" & Trim(Roundaccountcode) & "',upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Paymodeaccountcode = '" & Trim(paymentaccountcode) & " ',subpaymentaccountcode = '" & Trim(Subpaymentaccountcode) & " ' "
                                sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
                            End If
                        Else
                            MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End Try
                End If

                Insert(0) = sqlstring
                '''********************************************************** UPDATE BILL_HDR *********************************************************'''
                If cbo_PaymentMode.SelectedItem = "ROOM" Then
                    sqlstring = "UPDATE BILL_HDR SET Billdate='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy ") & "',BillTime = '" & Format(serverdate, "hh:mm:ss") & "',DiscountAmount =" & Val(txt_Discount.Text) & ",PackAmount = " & Format(Val(txt_PackingCharge.Text), "0.00") & ",TaxAmount = " & Format(Val(txt_TaxValue.Text), "0.00") & ",BillAmount = " & Format(Val(txt_TotalValue.Text), "0.00") & ",PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                    sqlstring = sqlstring & "Mcode='',Mname='',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=" & Val(Me.txt_MemberCode.Text) & ",ChkId=" & Val(Me.txt_MemberCode.Tag) & ",Guest='" & Trim(Me.txt_MemberName.Text) & "',Roundoff = " & Amt & ",Roundoffaccountcode='" & Trim(Roundaccountcode) & "',"
                    sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_KOTno.Text)) & "'"
                ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                    sqlstring = "UPDATE BILL_HDR SET Billdate='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy ") & "',BillTime = '" & Format(serverdate, "hh:mm:ss") & "',DiscountAmount =" & Val(txt_Discount.Text) & ",PackAmount = " & Format(Val(txt_PackingCharge.Text), "0.00") & ",TaxAmount = " & Format(Val(txt_TaxValue.Text), "0.00") & ",BillAmount = " & Format(Val(txt_TotalValue.Text), "0.00") & ",PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(gDebitors) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"
                    sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',Roundoff = " & Amt & ",Roundoffaccountcode='" & Trim(Roundaccountcode) & "',"
                    sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_KOTno.Text)) & "'"
                Else
                    Try
                        sqlstring = " SELECT ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
                        sqlstring = sqlstring & "WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
                        gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
                        If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                            If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) = "NO" Then
                                sqlstring = "UPDATE BILL_HDR SET Billdate='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy ") & "',BillTime = '" & Format(serverdate, "hh:mm:ss") & "',DiscountAmount =" & Val(txt_Discount.Text) & ",PackAmount = " & Format(Val(txt_PackingCharge.Text), "0.00") & ",TaxAmount = " & Format(Val(txt_TaxValue.Text), "0.00") & ",BillAmount = " & Format(Val(txt_TotalValue.Text), "0.00") & ",PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                                sqlstring = sqlstring & "Mcode='',Mname='',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',Roundoff = " & Amt & ",Roundoffaccountcode='" & Trim(Roundaccountcode) & "',"
                                sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_KOTno.Text)) & "'"
                            Else
                                sqlstring = "UPDATE BILL_HDR SET Billdate='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy ") & "',BillTime = '" & Format(serverdate, "hh:mm:ss") & "',DiscountAmount =" & Val(txt_Discount.Text) & ",PackAmount = " & Format(Val(txt_PackingCharge.Text), "0.00") & ",TaxAmount = " & Format(Val(txt_TaxValue.Text), "0.00") & ",BillAmount = " & Format(Val(txt_TotalValue.Text), "0.00") & ",PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                                sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',Roundoff = " & Format(Val(Amt), "0.00") & ",Roundoffaccountcode='" & Trim(Roundaccountcode) & "',"
                                sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_KOTno.Text)) & "'"
                            End If
                        Else
                            MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End Try
                End If
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                '''*********************************************************** COMPLETE ************************************************************'''
                'REFERINVENTORY
                'VarSql = " SELECT Autoid AS Autoid,Kotdetails AS Kotdetails,Kotdate AS Kotdate,ISNULL(Billdetails,'') AS Billdetails,Taxcode,Itemcode FROM KOT_DET WHERE KOTDETAILS  = '" & Trim(txt_KOTno.Text) & "'"
                VarSql = " SELECT Autoid AS Autoid,Kotdetails AS Kotdetails,Kotdate AS Kotdate,ISNULL(Billdetails,'') AS Billdetails,Taxcode,Itemcode,ISNULL(QTY,0) QTY FROM KOT_DET WHERE KOTDETAILS  = '" & Trim(txt_KOTno.Text) & "'"
                gconnection.getDataSet(VarSql, "TEMPKOTDET")
                If gdataset.Tables("TEMPKOTDET").Rows.Count > 0 Then
                    For Z = 0 To gdataset.Tables("TEMPKOTDET").Rows.Count - 1
                        For i = 1 To ssGrid.DataRowCnt
                            ssGrid.Row = i
                            ssGrid.Col = 16
                            If Val(ssGrid.Text) = Val(gdataset.Tables("TEMPKOTDET").Rows(Z).Item("Autoid")) Then
                                '''******************************************************** UPDATE INTO KOT_DET ******************************************************'''
                                sqlstring = "UPDATE KOT_DET SET KotDate = '" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "',KotType = '" & Trim(doctype) & "',PaymentMode= '" & Trim(cbo_PaymentMode.Text) & "' ,"
                                sqlstring = sqlstring & " Mcode = '" & Trim(txt_MemberCode.Text) & "',Scode = '" & Trim(txt_ServerCode.Text) & "',Covers = " & Val(Me.txt_Cover.Text) & ",TableNo = " & Val(Me.txt_TableNo.Text) & ","
                                If BILLROUNDYESNO = "YES" Then
                                    sqlstring = sqlstring & " TotAmt= " & Val(Me.txt_TotalValue.Text) & ",PackAmt = " & Val(Me.txt_PackingCharge.Text) & " ,TaxAmt= " & Val(Me.txt_TaxValue.Text) & ",DiscAmt =" & Val(Me.txt_Discount.Text) & ", BillAmt= " & Math.Round(Val(Me.txt_BillAmount.Text)) & ",ChkId= " & Val(Me.txt_MemberCode.Tag) & " "
                                Else
                                    sqlstring = sqlstring & " TotAmt= " & Val(Me.txt_TotalValue.Text) & ",PackAmt = " & Val(Me.txt_PackingCharge.Text) & " ,TaxAmt= " & Val(Me.txt_TaxValue.Text) & ",DiscAmt =" & Val(Me.txt_Discount.Text) & ", BillAmt= " & Val(Me.txt_BillAmount.Text) & ",ChkId= " & Val(Me.txt_MemberCode.Tag) & " "
                                End If
                                ssGrid.Row = i
                                ssGrid.Col = 1
                                sqlstring = sqlstring & ",ItemCode='" & Trim(ssGrid.Text) & "'"
                                ssGrid.Col = 2
                                sqlstring = sqlstring & ",Itemdesc='" & Trim(ssGrid.Text) & "'"
                                ssGrid.Col = 3
                                sqlstring = sqlstring & ",Poscode='" & Trim(ssGrid.Text) & "'"
                                ssGrid.Col = 4
                                sqlstring = sqlstring & ",Uom= '" & Trim(ssGrid.Text) & "'"
                                ssGrid.Col = 5
                                sqlstring = sqlstring & ",Qty= " & Val(ssGrid.Text) & ""
                                ssGrid.Col = 6
                                sqlstring = sqlstring & ",Rate= " & Val(ssGrid.Text) & ""
                                ssGrid.Col = 7
                                sqlstring = sqlstring & ",Taxamount= " & Val(ssGrid.Text) & ""
                                ssGrid.Col = 8
                                sqlstring = sqlstring & ",Amount = " & Val(ssGrid.Text) & ""
                                ssGrid.Col = 9
                                sqlstring = sqlstring & ",ItemType ='" & Trim(ssGrid.Text) & "'"
                                ssGrid.Col = 10
                                sqlstring = sqlstring & ",TaxCode='" & Trim(ssGrid.Text) & "'"
                                ssGrid.Col = 11
                                sqlstring = sqlstring & ",TaxPerc =" & Val(ssGrid.Text) & " "
                                ssGrid.Col = 13
                                sqlstring = sqlstring & ",TaxAccountCode = '" & Trim(ssGrid.Text) & "' "
                                ssGrid.Col = 14
                                sqlstring = sqlstring & ",SalesAccountCode = '" & Trim(ssGrid.Text) & "' "
                                ssGrid.Col = 15
                                sqlstring = sqlstring & ",GroupCode = '" & Trim(ssGrid.Text) & "' "
                                ssGrid.Col = 17
                                sqlstring = sqlstring & ",PackPercent =" & Val(ssGrid.Text) & " "
                                ssGrid.Col = 18
                                sqlstring = sqlstring & ",PackAmount =" & Val(ssGrid.Text) & " "
                                ssGrid.Col = 19
                                sqlstring = sqlstring & ",Openfacilityst ='" & Trim(ssGrid.Text) & "' "
                                ssGrid.Col = 20
                                sqlstring = sqlstring & ",Promotionalst ='" & Trim(ssGrid.Text) & "' "
                                ssGrid.Col = 21
                                sqlstring = sqlstring & ",Packaccountcode ='" & Trim(ssGrid.Text) & "' "
                                ssGrid.Col = 9
                                If Trim(ssGrid.Text) = "BAR" Then
                                    sqlstring = sqlstring & ",Taxtype = '',Alcholst = 'Y'"
                                ElseIf Trim(ssGrid.Text) = "SD" Then
                                    sqlstring = sqlstring & ",Taxtype = 'SALES',Alcholst ='S'"
                                Else
                                    sqlstring = sqlstring & ",Taxtype = 'SALES',Alcholst ='N'"
                                End If
                                sqlstring = sqlstring & ",Upduserid = '" & Trim(gUsername) & "',Upddatetime = '" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                                ssGrid.Col = 12
                                If Trim(ssGrid.Text) = "1" Then
                                    sqlstring = sqlstring & "KOTStatus='Y',DELFLAG = 'N'"
                                Else
                                    sqlstring = sqlstring & "KOTStatus='N',DELFLAG = 'N'"
                                End If
                                sqlstring = sqlstring & " WHERE  AUTOID = " & Val(gdataset.Tables("TEMPKOTDET").Rows(Z).Item("AUTOID")) & ""
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring

                                ReDim Preserve Update2(Update2.Length)
                                Update2(Update2.Length - 1) = Replace(sqlstring, "KOT_DET", " " & vOutfile & " ")

                                'REFERINVENTORY******************************* CHANGING THE QUANTITY OF ITEM *****************
                                ssGrid.Row = i
                                ssGrid.Col = 3
                                POSLOCATION = Trim(ssGrid.Text)

                                sqlstring = "SELECT STOREDESC FROM STOREMASTER WHERE STORECODE='" & POSLOCATION & "' AND ISNULL(FREEZE,'') <> 'Y'"
                                gconnection.getDataSet(sqlstring, "STOREMASTER1")
                                If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                                    ssGrid.Row = i
                                    ssGrid.Col = 1
                                    POSITEMCODE = Trim(ssGrid.Text)

                                    ssGrid.Row = i
                                    ssGrid.Col = 4
                                    POSITEMUOM = Trim(ssGrid.Text)

                                    sqlstring = "SELECT GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID FROM BOM_DET WHERE"
                                    sqlstring = sqlstring & " ITEMCODE='" & POSITEMCODE & "' AND ITEMUOM='" & POSITEMUOM & "' AND ISNULL(VOID,'') <> 'Y'"
                                    gconnection.getDataSet(sqlstring, "BOM")
                                    If gdataset.Tables("BOM").Rows.Count > 0 Then
                                        For K = 0 To gdataset.Tables("BOM").Rows.Count - 1
                                            sqlstring = "UPDATE SUBSTORECONSUMPTIONDETAIL SET DOCDate = '" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "'"
                                            ssGrid.Row = i
                                            ssGrid.Col = 3
                                            sqlstring = sqlstring & ",STORELOCATIONcode='" & Trim(ssGrid.Text) & "'"
                                            sqlstring = sqlstring & ",STORELOCATIONNAME='" & STORELOCATION(Trim(ssGrid.Text)) & "'"
                                            sqlstring = sqlstring & ",ItemCode='" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "'"
                                            sqlstring = sqlstring & ",ItemNAME='" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMNAME") & "") & "'"
                                            sqlstring = sqlstring & ",Uom= '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "'"
                                            ssGrid.Col = 5
                                            sqlstring = sqlstring & ",Qty= " & (Val(ssGrid.Text) * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY"))) & ""
                                            AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""))
                                            'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                                            sqlstring = sqlstring & ",RATE= " & AVGRATE & ""
                                            ssGrid.Col = 5
                                            ssGrid.Row = i
                                            dblCalqty = Val(ssGrid.Text)
                                            sqlstring = sqlstring & ",AMOUNT= " & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) * AVGRATE & ""
                                            'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                            sqlstring = sqlstring & ",DBLAmt = " & (Val(ssGrid.Text) * CDbl(gdataset.Tables("BOM").Rows(K).Item("GDBLAMT"))) & ""
                                            sqlstring = sqlstring & ",HIGHRATIO = " & Val(gdataset.Tables("BOM").Rows(K).Item("GHIGHRATIO")) & ""
                                            sqlstring = sqlstring & ",GROUPCODE= '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GGROUPCODE") & "") & "'"
                                            sqlstring = sqlstring & ",SUBGROUPCODE= '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GSUBGROUPCODE") & "") & "'"
                                            ssGrid.Col = 12
                                            If Trim(ssGrid.Text) = "1" Then
                                                sqlstring = sqlstring & ",VOID='Y'"
                                            Else
                                                sqlstring = sqlstring & ",VOID='N'"
                                            End If
                                            sqlstring = sqlstring & ",UpdATEuser = '" & Trim(gUsername) & "',Updatetime = '" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "' "
                                            sqlstring = sqlstring & " WHERE DOCDETAILS='" & Trim(txt_KOTno.Text) & "' AND STORELOCATIONCODE='" & POSLOCATION & "' "
                                            sqlstring = sqlstring & " AND ITEMCODE='" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "'"
                                            sqlstring = sqlstring & " AND UOM='" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "'"
                                            ssGrid.Row = i
                                            ssGrid.Col = 22
                                            sqlstring = sqlstring & " AND QTY='" & Val(ssGrid.Text) * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) & "'"

                                            ReDim Preserve Insert(Insert.Length)
                                            Insert(Insert.Length - 1) = sqlstring
                                        Next K
                                    Else
                                        sqlstring = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, ISNULL(I.PURCHASERATE,0.00) AS PURCHASERATE,"
                                        sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                                        sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "
                                        sqlstring = sqlstring & " WHERE I.ITEMCODE='" & POSITEMCODE & "' AND I.STOCKUOM='" & POSITEMUOM & "' AND ISNULL(FREEZE,'') <> 'Y'"
                                        gconnection.getDataSet(sqlstring, "DIRECT_STOCK")
                                        If gdataset.Tables("DIRECT_STOCK").Rows.Count > 0 Then
                                            sqlstring = "UPDATE SUBSTORECONSUMPTIONDETAIL SET DOCDate = '" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "'"
                                            ssGrid.Row = i
                                            ssGrid.Col = 3
                                            sqlstring = sqlstring & ",STORELOCATIONcode='" & Trim(ssGrid.Text) & "'"
                                            sqlstring = sqlstring & ",STORELOCATIONNAME='" & STORELOCATION(Trim(ssGrid.Text)) & "'"
                                            sqlstring = sqlstring & ",ItemCode='" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & "") & "'"
                                            sqlstring = sqlstring & ",ItemNAME='" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMNAME") & "") & "'"
                                            sqlstring = sqlstring & ",Uom= '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("STOCKUOM") & "") & "'"
                                            ssGrid.Col = 5
                                            sqlstring = sqlstring & ",Qty= " & Val(ssGrid.Text) & ""
                                            AVGRATE = CalAverageRate(Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & ""))
                                            'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                                            sqlstring = sqlstring & ",RATE= " & AVGRATE & ""
                                            ssGrid.Col = 5
                                            ssGrid.Row = i
                                            dblCalqty = Val(ssGrid.Text)
                                            sqlstring = sqlstring & ",AMOUNT= " & dblCalqty * AVGRATE & ""
                                            'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                            sqlstring = sqlstring & ",DBLAmt = " & (Val(ssGrid.Text) * CDbl(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO"))) & ""
                                            sqlstring = sqlstring & ",HIGHRATIO = " & Val(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ""
                                            sqlstring = sqlstring & ",GROUPCODE= '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("GROUPCODE") & "") & "'"
                                            sqlstring = sqlstring & ",SUBGROUPCODE= '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("SUBGROUPCODE") & "") & "'"
                                            ssGrid.Col = 12
                                            If Trim(ssGrid.Text) = "1" Then
                                                sqlstring = sqlstring & ",VOID='Y'"
                                            Else
                                                sqlstring = sqlstring & ",VOID='N'"
                                            End If

                                            sqlstring = sqlstring & ",UpdATEuser = '" & Trim(gUsername) & "',Updatetime = '" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "' "
                                            sqlstring = sqlstring & " WHERE DOCDETAILS='" & Trim(txt_KOTno.Text) & "' AND STORELOCATIONCODE='" & POSLOCATION & "' "
                                            sqlstring = sqlstring & " AND ITEMCODE='" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & "") & "'"
                                            sqlstring = sqlstring & " AND UOM='" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("STOCKUOM") & "") & "'"
                                            ssGrid.Row = i
                                            ssGrid.Col = 22
                                            sqlstring = sqlstring & " AND QTY=" & Val(ssGrid.Text)

                                            ReDim Preserve Insert(Insert.Length)
                                            Insert(Insert.Length - 1) = sqlstring
                                        End If
                                    End If
                                End If
                                '********************************************************************************************
                                Gridbool = True
                                Exit For
                            Else
                                Gridbool = False
                            End If
                        Next i
                        If Gridbool = False Then
                            'REFERINVENTORY******************UPDATING STOCK FOR DELETION*****************************
                            Dim KOTDETAILS_DEL, ITEMCODE_DEL, UOM_DEL, POSCODE_DEL As String
                            sqlstring = "SELECT KOTDETAILS,ITEMCODE,UOM,POSCODE FROM KOT_DET WHERE AUTOID=" & Val(gdataset.Tables("TEMPKOTDET").Rows(Z).Item("AUTOID")) & " "
                            gconnection.getDataSet(sqlstring, "KOTDETAILS")
                            If gdataset.Tables("KOTDETAILS").Rows.Count > 0 Then
                                KOTDETAILS_DEL = gdataset.Tables("KOTDETAILS").Rows(0).Item("kotdetails")
                                ITEMCODE_DEL = gdataset.Tables("KOTDETAILS").Rows(0).Item("ITEMCODE")
                                UOM_DEL = gdataset.Tables("KOTDETAILS").Rows(0).Item("UOM")
                                POSCODE_DEL = gdataset.Tables("KOTDETAILS").Rows(0).Item("POSCODE")
                            End If

                            sqlstring = "SELECT STOREDESC FROM STOREMASTER WHERE STORECODE='" & POSCODE_DEL & "' AND ISNULL(FREEZE,'') <> 'Y'"
                            gconnection.getDataSet(sqlstring, "STOREMASTER1")
                            If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                                sqlstring = "SELECT GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID FROM BOM_DET WHERE"
                                sqlstring = sqlstring & " ITEMCODE='" & ITEMCODE_DEL & "' AND ITEMUOM='" & UOM_DEL & "' AND ISNULL(VOID,'') <> 'Y'"
                                gconnection.getDataSet(sqlstring, "BOM")
                                If gdataset.Tables("BOM").Rows.Count > 0 Then
                                    For K = 0 To gdataset.Tables("BOM").Rows.Count - 1
                                        sqlstring = "DELETE FROM SUBSTORECONSUMPTIONDETAIL WHERE "
                                        sqlstring = sqlstring & " DOCDETAILS='" & KOTDETAILS_DEL & "'"
                                        sqlstring = sqlstring & " AND ITEMCODE='" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "'"
                                        sqlstring = sqlstring & " AND UOM='" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "'"
                                        sqlstring = sqlstring & " AND STORELOCATIONCODE='" & POSCODE_DEL & "'"
                                        sqlstring = sqlstring & " AND QTY=" & (CDbl(gdataset.Tables("TEMPKOTDET").Rows(Z).Item("QTY")) * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")))
                                        ReDim Preserve Insert(Insert.Length)
                                        Insert(Insert.Length - 1) = sqlstring
                                    Next K
                                Else
                                    sqlstring = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, ISNULL(I.PURCHASERATE,0.00) AS PURCHASERATE,"
                                    sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                                    sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "
                                    sqlstring = sqlstring & " WHERE I.ITEMCODE='" & ITEMCODE_DEL & "' AND I.STOCKUOM='" & UOM_DEL & "' AND ISNULL(FREEZE,'') <> 'Y'"
                                    gconnection.getDataSet(sqlstring, "DIRECT_STOCK")
                                    If gdataset.Tables("DIRECT_STOCK").Rows.Count > 0 Then
                                        sqlstring = "DELETE FROM SUBSTORECONSUMPTIONDETAIL WHERE "
                                        sqlstring = sqlstring & " DOCDETAILS='" & KOTDETAILS_DEL & "'"
                                        sqlstring = sqlstring & " AND ITEMCODE='" & ITEMCODE_DEL & "'"
                                        sqlstring = sqlstring & " AND UOM='" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("STOCKUOM") & "") & "'"
                                        sqlstring = sqlstring & " AND STORELOCATIONCODE='" & POSCODE_DEL & "'"
                                        sqlstring = sqlstring & " AND QTY=" & CDbl(gdataset.Tables("TEMPKOTDET").Rows(Z).Item("QTY"))
                                        ReDim Preserve Insert(Insert.Length)
                                        Insert(Insert.Length - 1) = sqlstring
                                    End If
                                End If
                            End If
                            '****************************************************************************************
                            sqlstring = "DELETE FROM KOT_DET WHERE autoid= " & Val(gdataset.Tables("TEMPKOTDET").Rows(Z).Item("Autoid")) & " "
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = sqlstring

                            ReDim Preserve Update2(Update2.Length)
                            Update2(Update2.Length - 1) = Replace(sqlstring, "KOT_DET", " " & vOutfile & " ")


                        End If
                        '''******************************************************** COMPLETE KOT_DET *********************************************************'''
                    Next Z

                End If
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Row = i
                    ssGrid.Col = 16
                    If Val(ssGrid.Text) = 0 Then
                        sqlstring = "INSERT INTO KOT_DET(KotNo,KOTdetails,KotDate,Billdetails,KotType,PaymentMode,Mcode,Scode,Covers,TableNo,TotAmt,TaxAmt,PackAmt,DiscAmt,BillAmt,ChkId,ItemCode,Itemdesc,Poscode,costcode,Uom,Qty,Rate,Taxamount,Amount,ItemType,TaxCode,TaxPerc,TaxAccountCode,SalesAccountCode,GroupCode,"
                        sqlstring = sqlstring & " PackPercent,PackAmount,Openfacilityst,Promotionalst,Packaccountcode,Taxtype,Alcholst,Adduserid,Adddatetime,Upduserid,Upddatetime,KOTStatus,Delflag) "
                        sqlstring = sqlstring & " VALUES('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Trim(doctype) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                        If BILLROUNDYESNO = "YES" Then
                            sqlstring = sqlstring & " '" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Val(Me.txt_PackingCharge.Text) & "," & Val(Me.txt_Discount.Text) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & "," & Val(Me.txt_MemberCode.Tag) & ""
                        Else
                            sqlstring = sqlstring & " '" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Val(Me.txt_PackingCharge.Text) & "," & Val(Me.txt_Discount.Text) & "," & Val(Me.txt_BillAmount.Text) & "," & Val(Me.txt_MemberCode.Tag) & ""
                        End If
                        ssGrid.Row = i
                        ssGrid.Col = 1
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                        ssGrid.Col = 2
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                        ssGrid.Col = 3
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                        sqlstring = sqlstring & ",'" & costcode & "'"

                        ssGrid.Col = 4
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                        ssGrid.Col = 5
                        sqlstring = sqlstring & "," & Val(ssGrid.Text) & ""
                        ssGrid.Col = 6
                        sqlstring = sqlstring & "," & Val(ssGrid.Text) & ""
                        ssGrid.Col = 7
                        sqlstring = sqlstring & "," & Val(ssGrid.Text) & ""
                        ssGrid.Col = 8
                        sqlstring = sqlstring & "," & Val(ssGrid.Text) & ""
                        ssGrid.Col = 9
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                        ssGrid.Col = 10
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                        ssGrid.Col = 11
                        sqlstring = sqlstring & "," & Val(ssGrid.Text) & " "
                        ssGrid.Col = 13
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                        ssGrid.Col = 14
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                        ssGrid.Col = 15
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                        ssGrid.Col = 17
                        sqlstring = sqlstring & "," & Val(ssGrid.Text) & " "
                        ssGrid.Col = 18
                        sqlstring = sqlstring & "," & Val(ssGrid.Text) & " "
                        ssGrid.Col = 19
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                        ssGrid.Col = 20
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                        ssGrid.Col = 21
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "' "
                        ssGrid.Col = 9
                        If Trim(ssGrid.Text) = "BAR" Then
                            sqlstring = sqlstring & ",'','Y'"
                        ElseIf Trim(ssGrid.Text) = "SD" Then
                            sqlstring = sqlstring & ",'SALES','S'"
                        Else
                            sqlstring = sqlstring & ",'SALES','N'"
                        End If
                        sqlstring = sqlstring & ",'" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                        ssGrid.Col = 12
                        If Trim(ssGrid.Text) = "1" Then
                            sqlstring = sqlstring & ",'Y','N')"
                        Else
                            sqlstring = sqlstring & ",'N','N')"
                        End If
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = sqlstring

                        ReDim Preserve Update2(Update2.Length)
                        Update2(Update2.Length - 1) = Replace(sqlstring, "KOT_DET", " " & vOutfile & " ")


                        ''REFERINVENTORY*************************UPDATING STOCK***********************************************

                        ssGrid.Row = i
                        ssGrid.Col = 3
                        POSLOCATION = Trim(ssGrid.Text)

                        sqlstring = "SELECT STOREDESC FROM STOREMASTER WHERE STORECODE='" & POSLOCATION & "' AND ISNULL(FREEZE,'') <> 'Y'"
                        gconnection.getDataSet(sqlstring, "STOREMASTER1")
                        If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            POSITEMCODE = Trim(ssGrid.Text)

                            ssGrid.Row = i
                            ssGrid.Col = 4
                            POSITEMUOM = Trim(ssGrid.Text)

                            'AVGRATE = CalAverageRate(Trim(ssGrid.Text))
                            'AVGQUANTITY = CalAverageQuantity(Trim(ssGrid.Text))
                            sqlstring = "SELECT GITEMCODE,GITEMNAME,GUOM,GQTY,GRATE,GAMOUNT,GDBLAMT,GHIGHRATIO,GGROUPCODE,GSUBGROUPCODE,VOID FROM BOM_DET WHERE"
                            sqlstring = sqlstring & " ITEMCODE='" & POSITEMCODE & "' AND ITEMUOM='" & POSITEMUOM & "' AND ISNULL(VOID,'') <> 'Y'"
                            gconnection.getDataSet(sqlstring, "BOM")
                            If gdataset.Tables("BOM").Rows.Count > 0 Then
                                For K = 0 To gdataset.Tables("BOM").Rows.Count - 1
                                    sqlstring = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                    sqlstring = sqlstring & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                    sqlstring = sqlstring & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                    sqlstring = sqlstring & " VALUES ('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "',"
                                    sqlstring = sqlstring & " '" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy") & "',"
                                    sqlstring = sqlstring & " '" & Trim(POSLOCATION) & "',"
                                    sqlstring = sqlstring & " '" & Trim(STORELOCATION(POSLOCATION)) & "',"
                                    sqlstring = sqlstring & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "',"
                                    sqlstring = sqlstring & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMNAME") & "") & "',"
                                    sqlstring = sqlstring & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GUOM") & "") & "',"
                                    ssGrid.Col = 5
                                    ssGrid.Row = i
                                    dblCalqty = Val(ssGrid.Text)
                                    sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) & ","
                                    AVGRATE = CalAverageRate(Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & ""))
                                    'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                                    sqlstring = sqlstring & AVGRATE & ","
                                    sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY")) * AVGRATE & ","
                                    'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                    sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GDBLAMT")) & ","
                                    sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GHIGHRATIO")) & ","
                                    sqlstring = sqlstring & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GGROUPCODE") & "") & "',"
                                    sqlstring = sqlstring & " '" & Trim(gdataset.Tables("BOM").Rows(K).Item("GSUBGROUPCODE") & "") & "',"
                                    sqlstring = sqlstring & "'N'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                                    sqlstring = sqlstring & " ' ','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "')"
                                    ReDim Preserve Insert(Insert.Length)
                                    Insert(Insert.Length - 1) = sqlstring
                                Next K
                            Else
                                sqlstring = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, ISNULL(I.PURCHASERATE,0.00) AS PURCHASERATE,"
                                sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                                sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "
                                sqlstring = sqlstring & " WHERE I.ITEMCODE='" & POSITEMCODE & "' AND I.STOCKUOM='" & POSITEMUOM & "' AND ISNULL(FREEZE,'') <> 'Y'"
                                gconnection.getDataSet(sqlstring, "DIRECT_STOCK")
                                If gdataset.Tables("DIRECT_STOCK").Rows.Count > 0 Then
                                    sqlstring = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                                    sqlstring = sqlstring & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                                    sqlstring = sqlstring & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                                    sqlstring = sqlstring & " VALUES ('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "',"
                                    sqlstring = sqlstring & " '" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy") & "',"
                                    sqlstring = sqlstring & " '" & Trim(POSLOCATION) & "',"
                                    sqlstring = sqlstring & " '" & Trim(STORELOCATION(POSLOCATION)) & "',"
                                    sqlstring = sqlstring & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & "") & "',"
                                    sqlstring = sqlstring & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMNAME") & "") & "',"
                                    sqlstring = sqlstring & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("STOCKUOM") & "") & "',"
                                    ssGrid.Col = 5
                                    ssGrid.Row = i
                                    dblCalqty = Val(ssGrid.Text)
                                    sqlstring = sqlstring & dblCalqty & ","
                                    AVGRATE = CalAverageRate(Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("ITEMCODE") & ""))
                                    'sqlstring = sqlstring & Val(gdataset.Tables("BOM").Rows(K).Item("GRATE")) & ","
                                    sqlstring = sqlstring & AVGRATE & ","
                                    sqlstring = sqlstring & dblCalqty * AVGRATE & ","
                                    'sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("BOM").Rows(K).Item("GAMOUNT")) & ","
                                    sqlstring = sqlstring & dblCalqty * CDbl(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ","
                                    sqlstring = sqlstring & Val(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("HIGHRATIO")) & ","
                                    sqlstring = sqlstring & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("GROUPCODE") & "") & "',"
                                    sqlstring = sqlstring & " '" & Trim(gdataset.Tables("DIRECT_STOCK").Rows(0).Item("SUBGROUPCODE") & "") & "',"
                                    sqlstring = sqlstring & "'N'," '& Format(Val(AVGQUANTITY), "0.000") & "," & Format(Val(AVGRATE), "0.00") & ","
                                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                                    sqlstring = sqlstring & " ' ','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "')"
                                    ReDim Preserve Insert(Insert.Length)
                                    Insert(Insert.Length - 1) = sqlstring
                                End If
                            End If
                        End If
                        '******************************************************************************************************
                    End If
                Next i
                sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE FROM KOT_DET WHERE KOTDETAILS = '" & Trim(CStr(txt_KOTno.Text)) & "' "
                gconnection.getDataSet(sqlstring, "KOT_DET")
                If gdataset.Tables("KOT_DET").Rows.Count > 0 Then
                    sqlstring = "UPDATE BILL_DET SET Billdate='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy ") & "',Kotdate='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy ") & "',TaxCode = '" & gdataset.Tables("KOT_DET").Rows(0).Item("TAXCODE") & "',TaxAmount= " & Val(txt_TaxValue.Text) & ",Packamount = " & Val(txt_PackingCharge.Text) & ",Discountamount = " & Val(txt_Discount.Text) & ",KotAmount= " & Val(txt_TotalValue.Text) & ",Roundoff =" & Amt & " WHERE KotDetails='" & Trim(Me.txt_KOTno.Text) & "' "
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                End If
            End If
            ''''************************************************** $ BILL SETTLEMENT IF ANY   $ ********************************************'''
            If ssgridPayment.DataRowCnt = 0 Then
                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,Poscode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,Bankname,ReceivedName,Payamount,Billamount,Balanceamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime,Delflag ) VALUES ("
                sqlstring = sqlstring & " '" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "','" & Trim(cbo_PaymentMode.Text) & "','" & Trim(POSLOCATION) & "','" & Trim(paymentaccountcode) & "','" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "', "
                sqlstring = sqlstring & " '','','" & Format(serverdate, "dd-MMM-yyyy") & "','',''," & Format(Val(txt_BillAmount.Text), "0.00") & ", " & Format(Val(txt_BillAmount.Text), "0.00") & ",0,'" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N') "
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
            ElseIf ssgridPayment.DataRowCnt = 1 Then
                sqlstring = "UPDATE BILLSETTLEMENT SET Billdate ='" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "',PaymentMode = '" & Trim(cbo_PaymentMode.Text) & "',poscode = '" & Trim(POSLOCATION) & "',PaymentAccountCode = '" & Trim(paymentaccountcode) & "',Mcode = '" & Trim(txt_MemberCode.Text) & "',Mname = '" & Trim(txt_MemberName.Text) & "',"
                sqlstring = sqlstring & " CardType = '', Instrumentno = '',Instrumentdate = '" & Format(serverdate, "dd-MMM-yyyy") & "',Bankname = '',ReceivedName = '',Payamount= " & Format(Val(txt_BillAmount.Text), "0.00") & ",Billamount = " & Format(Val(txt_BillAmount.Text), "0.00") & ",Balanceamount = 0,UpdateUserid='" & Trim(gUsername) & "',Updatedatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "' "
                sqlstring = sqlstring & " WHERE BillNo = '" & Trim(txt_KOTno.Text) & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
            Else
                '''**********************************************  $ DELETE FROM BILLSETTLEMENT $ *****************************************'''
                sqlstring = "DELETE FROM  BILLSETTLEMENT WHERE BILLNO =  '" & Trim(CStr(txt_KOTno.Text)) & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                '''**********************************************  $ COMPLETE DELETE BILLSETTLEMENT $ *****************************************'''
                For Z = 1 To ssgridPayment.DataRowCnt
                    ssgridPayment.Col = 1
                    ssgridPayment.Row = Z
                    If Trim(ssgridPayment.Text) <> "" Then
                        ssgridPayment.Col = 3
                        ssgridPayment.Row = Z
                        sqlstring = " SELECT ISNULL(Accountin,'') AS ACCOUNTIN,ISNULL(Paymentcode,'') AS Paymentcode,ISNULL(paymentType,'') AS paymentType  FROM paymentmodemaster WHERE Paymentcode = '" & Trim(ssgridPayment.Text) & "' AND ISNULL(Freeze,'')='N'"
                        gconnection.getDataSet(sqlstring, "paymentmodemaster")
                        If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                            If Trim(ssgridPayment.Text) = Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("Paymentcode")) And Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentType")) = "CD" Then
                                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,Poscode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,"
                                sqlstring = sqlstring & "Bankname,ReceivedName,Payamount,Billamount,Balanceamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime,Delflag ) VALUES ("
                                ssgridPayment.Row = Z
                                ssgridPayment.Col = 1
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 2
                                sqlstring = sqlstring & "'" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "',"
                                ssgridPayment.Col = 3
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "','" & Trim(POSLOCATION) & "',"
                                sqlstring = sqlstring & "'" & Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin")) & "',"
                                ssgridPayment.Col = 5
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 6
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                sqlstring = sqlstring & "'" & Trim(txt_Typeofcard.Text) & "','" & Trim(txt_Cardno.Text) & "','" & Format(dtp_Expirydate.Value, "dd-MMM-yyyy") & "','','" & Trim(txt_Cardholdername.Text) & "',"
                                ssgridPayment.Col = 4
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 7
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 8
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                sqlstring = sqlstring & "'" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                            ElseIf Trim(ssgridPayment.Text) = Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("Paymentcode")) And Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentType")) = "CQ" Then
                                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,Poscode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,"
                                sqlstring = sqlstring & "Bankname,ReceivedName,Payamount,Billamount,Balanceamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime,Delflag ) VALUES ("
                                ssgridPayment.Row = Z
                                ssgridPayment.Col = 1
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 2
                                sqlstring = sqlstring & "'" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "',"
                                ssgridPayment.Col = 3
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "','" & Trim(POSLOCATION) & "',"
                                sqlstring = sqlstring & "'" & Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin")) & "',"
                                ssgridPayment.Col = 5
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 6
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                sqlstring = sqlstring & "'" & Trim(cbo_Typeofcheque.Text) & "','" & Trim(txt_Chequeno.Text) & "','" & Format(dtp_Chequedate.Value, "dd-MMM-yyyy") & "','" & Trim(txt_Draweebank.Text) & "','',"
                                ssgridPayment.Col = 4
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 7
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 8
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                sqlstring = sqlstring & "'" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                            Else
                                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,Poscode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,"
                                sqlstring = sqlstring & "Bankname,ReceivedName,Payamount,Billamount,Balanceamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime,Delflag ) VALUES ("
                                ssgridPayment.Row = Z
                                ssgridPayment.Col = 1
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 2
                                sqlstring = sqlstring & "'" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy ") & "',"
                                ssgridPayment.Col = 3
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "','" & Trim(POSLOCATION) & "',"
                                sqlstring = sqlstring & "'" & Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin")) & "',"
                                ssgridPayment.Col = 5
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                ssgridPayment.Col = 6
                                sqlstring = sqlstring & "'" & Trim(ssgridPayment.Text) & "',"
                                sqlstring = sqlstring & "'','','" & Format(serverdate, "dd-MMM-yyyy") & "','','',"
                                ssgridPayment.Col = 4
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 7
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                ssgridPayment.Col = 8
                                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                                sqlstring = sqlstring & "'" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sqlstring
                            End If
                        End If
                    End If
                Next Z
            End If

            '''''************************************************** $ BILL SETTLEMENT COMPLETE   $ ********************************************'''
            sqlstring = "SELECT ISNULL(KOTDETAILS,'') AS KOTDETAILS,KOTDATE,ISNULL(VOUCHERNO,'') AS VOUCHERNO,ISNULL(POSTINGSTATUS,'') As POSTINGSTATUS FROM KOT_HDR  WHERE KOTDETAILS='" & Trim(CStr(Me.txt_KOTno.Text)) & "' AND PAYMENTTYPE <> 'CREDIT'"
            gconnection.getDataSet(sqlstring, "KOTHDR")
            If gdataset.Tables("KOTHDR").Rows.Count > 0 Then
                sqlstring = " UPDATE KOT_HDR SET VOUCHERNO = '',POSTINGSTATUS = 'N' WHERE KOTDETAILS='" & Trim(CStr(gdataset.Tables("KOTHDR").Rows(0).Item("KOTDETAILS"))) & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                sqlstring = " UPDATE JOURNALENTRY SET VOID = 'Y' WHERE VOUCHERNO='" & Trim(CStr(gdataset.Tables("KOTHDR").Rows(0).Item("VOUCHERNO"))) & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                sqlstring = " UPDATE OUTSTANDING SET VOID = 'Y' WHERE VOUCHERNO='" & Trim(CStr(gdataset.Tables("KOTHDR").Rows(0).Item("VOUCHERNO"))) & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
            End If
            sqlstring = "delete from settlement where billdetails='" & txt_KOTno.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            '---------------------
            'Settlement 
            'begin
            'If cbo_PaymentMode.SelectedItem <> "ROOM" Then
            With ssgrid_settlement
                sqlstring = "delete from settlement where billdetails='" & txt_KOTno.Text & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                If .DataRowCnt = 1 Or .DataRowCnt = 0 Then
                    sqlstring = "INSERT INTO SETTLEMENT(BILLDETAILS,BILLDATE,MCODE,AMOUNT,DESCRIPTION,deleteflag,SBILLFLAG) "
                    sqlstring = sqlstring & "VALUES('" & txt_KOTno.Text & "','" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "',"
                    sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "'," & txt_BillAmount.Text & ",'','N','N')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring

                    sqlstring = "UPDATE BILL_HDR SET SBILLFLAG='N' WHERE BILLDETAILS='" & txt_KOTno.Text & "'"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                Else
                    For i = 1 To .DataRowCnt
                        sqlstring = "INSERT INTO SETTLEMENT(BILLDETAILS,BILLDATE,MCODE,AMOUNT,DESCRIPTION,DELETEFLAG,SBILLFLAG) "
                        sqlstring = sqlstring & "VALUES('" & txt_KOTno.Text & "','" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "',"
                        .Col = 1
                        .Row = i
                        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                        .Col = 2
                        .Row = i
                        sqlstring = sqlstring & Math.Round(Val(Trim(.Text)), 2) & ","
                        .Col = 3
                        .Row = i
                        sqlstring = sqlstring & "'" & Trim(.Text) & "','N','Y')"
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = sqlstring
                    Next
                    sqlstring = "UPDATE BILL_HDR SET SBILLFLAG='Y' WHERE BILLDETAILS='" & txt_KOTno.Text & "'"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                End If
            End With
            'End If
            '---------------------
            'Settlement 
            'end

            '-----------------------------------------JOURNAL BEGIN
            'journalentry 
            'begin
            sqlstring = " SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & POSLOCATION & "'"
            gconnection.getDataSet(sqlstring, "AccountIn")
            If (gdataset.Tables("AccountIn").Rows.Count > 0) Then
                desc = gdataset.Tables("AccountIn").Rows(0).Item("POSDESC")
            Else
                desc = ""
            End If
            'End If
            gconnection.MoreTransold1(Update2)
            If Trim(cbo_PaymentMode.Text) = "CREDIT" Then
                sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' And ISNULL(SUBPAYSTATUS,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "AccountIn")
                If (gdataset.Tables("AccountIn").Rows.Count > 0) Then
                    strSaleCostAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERCODE"))
                    strSaleCostAccountInDesc = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERDESC"))
                    'If Trim(CMB_BTYPE.Text) = "BAR" Then
                    '    strAccountIn = "SDRSB"
                    'Else
                    strAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("AccountIn"))
                    ' End If
                Else
                    sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "'ISNULL(SUBPAYSTATUS,'')='N'"
                    strAccountIn = ""
                    strSaleCostAccountIn = ""
                    strSaleCostAccountInDesc = ""
                End If
            Else

                sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' And ISNULL(SUBPAYSTATUS,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "AccountIn")
                If (gdataset.Tables("AccountIn").Rows.Count > 0) Then
                    strAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("AccountIn"))
                    strSaleCostAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERCODE"))
                    strSaleCostAccountInDesc = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERDESC"))
                Else
                    sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "'ISNULL(SUBPAYSTATUS,'')='N'"
                    strAccountIn = ""
                    strSaleCostAccountIn = ""
                    strSaleCostAccountInDesc = ""
                End If
            End If

            sqlstring = "select isnull(roundacctin,'') as rndoff_acode,isnull(roundacctdesc,'') as rndoff_desc  from  possetup "
            sqlstring = sqlstring & " where isnull(BILLROUNDOFF,'')='YES'"
            gconnection.getDataSet(sqlstring, "Rndoff")
            If (gdataset.Tables("Rndoff").Rows.Count > 0) Then
                rndoff_acode = gdataset.Tables("Rndoff").Rows(0).Item("rndoff_acode")
                rndoff_desc = gdataset.Tables("Rndoff").Rows(0).Item("rndoff_desc")
            Else
                rndoff_acode = ""
                rndoff_desc = ""
            End If

            If Me.cbo_SubPaymentMode.Visible = True Then
                strAccountIn = Subpaymentaccountcode
            End If





            If UCase(Trim(CMB_BTYPE.Text)) = "NIA" Or UCase(Trim(CMB_BTYPE.Text)) = "CKA" Or UCase(Trim(CMB_BTYPE.Text)) = "ACH" Then
                sqlstring = "update kot_det  set PACKPERCENT=5,Packamount=(isnull(amount,0) *5/100) Where  kotdetails='" & txt_KOTno.Text & "' and isnull(poscode,'') not in('12','13')"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
            End If

            sqlstring = " update kot_det  set  packamt=b.packamount from kot_det a, view_kot  b "
            sqlstring = sqlstring & "where a.kotdetails=b.kotdetails and a.kotdetails='" & txt_KOTno.Text & "' "
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            sqlstring = " update kot_det  set ser_chg=((isnull(amount,0)*75/100) *(5.15/100)) Where  kotdetails='" & txt_KOTno.Text & "' and isnull(poscode,'') IN('ACH','NCH') "
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            sqlstring = " update kot_hdr set packamt=isnull(b.packamount,0),SER_CHG=isnull(b.SER_CHG,0)  from kot_hdr a, view_kot  b "
            sqlstring = sqlstring & " where a.kotdetails=b.kotdetails and a.kotdetails='" & txt_KOTno.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            sqlstring = " update kot_hdr set billamount=ISNULL(packamt+totaltax + total+SER_CHG,0)  from kot_hdr where kotdetails='" & txt_KOTno.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            sqlstring = " update Bill_hdr set packamount=isnull(b.packamount,0),Ser_Chg=isnull(b.Ser_chg,0)  from bill_hdr a, view_kot  b "
            sqlstring = sqlstring & " where a.billdetails=b.billdetails and a.billdetails='" & txt_KOTno.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            sqlstring = " Drop Table  " & vOutfile
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            sqlstring = " UPDATE ROOMLEDGER SET AMOUNT=ISNULL(B.TOTALAMOUNT,0)+ISNULL(B.ROUNDOFF,0) FROM  ROOMLEDGER A,BILL_HDR B WHERE B.BILLDETAILS=A.DOCNO AND  A.DOCNO='" & txt_KOTno.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring





            If Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
                MessageBox.Show("PLEASE! SWIPE YOUR CARD", "CARD NOT SWIPED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = False
                txt_card_id.Focus()
                '                lbl_SwipeCard.Focus()
                Exit Sub
            Else
                If cbo_PaymentMode.Text = "SMART CARD" Then
                    Call cardcheck()
                End If
            End If
            Dim STRSQL2 As String
            STRSQL2 = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & CARDCODE & "' AND POSCODE='" & StrPOSCODE & "'"
            'STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & POSCODE & "' AND STORESTATUS = 'F' "
            gconnection.getDataSet(STRSQL2, "SM_CARDFILE_DET")
            If gdataset.Tables("SM_CARDFILE_DET").Rows.Count > 0 Then
                POS_AMT_GBL = Val(txt_TotalValue.Text)
                STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'F' "
                gconnection.getDataSet(STRSQL2, "FACILITY")
                If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                    'ONCE FACILITY 
                    KOT_NO_GBL = Trim(txt_KOTno.Text)
                    gconnection.MORETRANS(Insert)
                    If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Call Cmd_Print_Click(Cmd_Print, e)
                        Call cmd_Clear_Click(sender, e)
                        If kotupdate = True Then
                            Me.Close()
                        End If
                    Else
                        Call cmd_Clear_Click(sender, e)
                        If kotupdate = True Then
                            Me.Close()
                        End If
                    End If
                    Dim SSTR As String
                    SSTR = "SELECT * FROM SM_POSTRANSACTION WHERE BILL_NO='" & Trim(txt_KOTno.Text) & "'"
                    gconnection.getDataSet(SSTR, "SM_POSTRANSACTION")
                    If gdataset.Tables("SM_POSTRANSACTION").Rows.Count > 0 Then
                        Dim DE_TRA_AMEND As New DEBIT_CARD_TRANSACTION
                        D_CARDUPDATE = True
                        DE_TRA_AMEND.Show()
                    Else
                        Dim DE_TRA As New DEBIT_CARD_TRANSACTION
                        D_CARDUPDATE = False
                        DE_TRA.Show()
                    End If
                    Call autogenerate()

                Else
                    If cbo_PaymentMode.Text = "SMART CARD" Then
                        Dim STRSQL As String

                        'KARTHI CHECK MIN BALANCE AND PROCEED FOR CARD BALANCE
                        'NOV 14
                        If MIN_USAGE_BALANCE_HDR >= Val(txt_BillAmount.Text + Amt) Then
                            STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & CARDCODE & "','" & "01" & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & Val(txt_BillAmount.Text + Amt) & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FM')"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL

                            STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & Val(txt_BillAmount.Text + Amt) & " WHERE CARDCODE='" & CARDCODE & "'"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL
                        ElseIf MIN_USAGE_BALANCE_HDR <= 0 Then
                            'DEDUCT AMOUNT ONLY FROM CARD

                            Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                            DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR
                            DEDUCT_FROM_CARD = Val(txt_BillAmount.Text + Amt) - MIN_USAGE_BALANCE_HDR

                            STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & CARDCODE & "'"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL

                            STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & CARDCODE & "','" & "01" & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FC')"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = sTRSQL
                        ElseIf MIN_USAGE_BALANCE_HDR > 0 And MIN_USAGE_BALANCE_HDR < Val(txt_BillAmount.Text + Amt) Then

                            Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                            DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR
                            DEDUCT_FROM_CARD = Val(txt_BillAmount.Text + Amt) - MIN_USAGE_BALANCE_HDR

                            STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & CARDCODE & "','" & "01" & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_MINUSAGE & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HM')"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL


                            STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & CARDCODE & "','" & "01" & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HC')"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL

                            STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & DEDUCT_FROM_MINUSAGE & " WHERE CARDCODE='" & CARDCODE & "'"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL

                            STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & CARDCODE & "'"
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = STRSQL
                        End If
                        'CARD
                        gconnection.MoreTransold(Insert)
                        If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                            Call Cmd_Print_Click(Cmd_Print, e)
                            Call cmd_Clear_Click(sender, e)
                            '***********CHANGE
                            MNAME_GBL = ""
                            MCODE_GBL = ""
                            CARDCODE = ""
                            NAME_GBL = ""
                            '***********CHANGE
                            If kotupdate = True Then
                                Me.Close()
                            End If
                        Else
                            Call cmd_Clear_Click(sender, e)
                            If kotupdate = True Then
                                Me.Close()
                            End If
                        End If
                        Exit Sub
                    Else
                        gconnection.MoreTransold(Insert)
                        If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                            Call Cmd_Print_Click(Cmd_Print, e)
                            Call cmd_Clear_Click(sender, e)
                        Else
                            Call cmd_Clear_Click(sender, e)
                        End If
                    End If
                    'Exit Sub
                End If
                'CSC SMARTCARD
            Else
                gconnection.MoreTransold(Insert)
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call Cmd_Print_Click(Cmd_Print, e)
                    Call cmd_Clear_Click(sender, e)
                Else
                    Call cmd_Clear_Click(sender, e)
                End If
            End If
            Call txt_MemberCode_Validated(sender, e)
            Call cmd_Clear_Click(sender, e)

            'If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            '    Call Cmd_Print_Click(Cmd_Print, e)
            '    Call cmd_Clear_Click(sender, e)
            'Else
            '    Call cmd_Clear_Click(sender, e)
            'End If
        End If
    End Sub
    Private Sub CMD_FACILITY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_FACILITY.Click
        Try
            'If grp_facility.Visible = False And txt_MemberCode.Text <> "" Then
            '    grp_facility.Visible = True
            '    'ssgrid_Fac.SetActiveCell(1, 1)
            '    ssgrid_Fac.Focus()
            'Else
            '    grp_facility.Visible = False
            '    'ssGrid.SetActiveCell(1, 1)
            '    ssGrid.Focus()
            'End If

            If MessageBox.Show("Do You Want View it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                gPrint = False
            Else
                gPrint = True
            End If

            Facility_Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Call checkvalidate() '''---> Check Validation
        If chkbool = False Then Exit Sub
        Dim sqlstring, Delete(0), SQL As String
        Dim dt As New DataTable
        Dim A, B As Integer
        Call SetDateTime()
        'Added on 18 Mar'08
        'Bill Matching Validation
        'Mk Kannan
        'Begin
        sqlstring = "SELECT * FROM BILL_HDR WHERE BILLDETAILS = '" & Trim(txt_KOTno.Text) & "' AND ISNULL(crostatus,'N')='Y' "
        gconnection.getDataSet(sqlstring, "CRO")
        If gdataset.Tables("CRO").Rows.Count > 0 Then
            MsgBox("Sorry, Settlement Was Already Made, You Can't Delete/Update....")
            Exit Sub
        End If


        sqlstring = "SELECT * FROM MATCHING WHERE VOUCHERNO = '" & Trim(txt_KOTno.Text) & "' AND VOUCHERDATE = '" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "'"
        dt = gconnection.GetValues(sqlstring)
        If (dt.Rows.Count > 0) Then
            MsgBox("Sorry, Bill Matching Was Already Made, You Can't Delete....")
            ''Call cmd_Clear_Click(cmd_Clear, e)
            Exit Sub
        End If
        'End

        SQL = "SELECT * FROM kot_hdr WHERE CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) ='" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "' AND postingstatus = 'Y'"
        gconnection.getDataSet(SQL, "kot_hdr")
        If gdataset.Tables("kot_hdr").Rows.Count > 0 Then
            Cmd_Add.Enabled = False
            cmd_Delete.Enabled = False
            MessageBox.Show("NO KOT SHOULD BE ENTERED/UPDATED FOR BILL CLOSED DATE:" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        A = Month(Trim(dtp_KOTdate.Text))
        SQL = "SELECT * FROM bill_hdr WHERE month(billdate) = " & Val(A) & " AND ACCOUNTFLAG = 'Y'"
        gconnection.getDataSet(SQL, "bill_hdr")
        If gdataset.Tables("bill_hdr").Rows.Count > 0 Then
            Cmd_Add.Enabled = False
            cmd_Delete.Enabled = False
            MessageBox.Show("NO KOT SHOULD BE ENTERED FOR MEMBER BILL GENERATED MONTH", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If



        sqlstring = "SELECT ISNULL(BillStatus,'PO') As BillStatus,ISNULL(Crostatus,'N') As Crostatus,ISNULL(PostingStatus,'N') as PostingStatus FROM Kot_Hdr WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
        dt = gconnection.GetValues(sqlstring)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("PostingStatus") = "Y" Then
                If MsgBox("The KotAmount Is Already Posted To Accounts,Deleting This Kot Also Reflects In Accounts,Are U Sure To Delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call DeleteOperation()
                    Exit Sub
                Else
                    Call cmd_Clear_Click(cmd_Clear, e)
                    Exit Sub
                End If
            ElseIf dt.Rows(0).Item("CRostatus") = "Y" Then
                If MsgBox("The KotAmount Is Already Posted To Cro,Deleting This Kot Also Reflects In Cro,Are U Sure To Delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call DeleteOperation()
                    Exit Sub
                Else
                    Call cmd_Clear_Click(cmd_Clear, e)
                    Exit Sub
                End If
            Else
                '''************************************** Deleting KOTDETAILS Permently from KOT_HDR ************************************'''
                sqlstring = " UPDATE KOT_HDR SET DELFLAG = 'Y' WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                Delete(0) = sqlstring
                '''************************************************* COMPLETE KOT_HDR ***************************************************'''
                '''************************************** Deleting KOTDETAILS Permently from KOT_DET ************************************'''
                sqlstring = " UPDATE KOT_DET SET DELFLAG = 'Y' WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring

                'REFERINVENTORY************************************* UPDATING STOCK FOR KOT DELETION **************************************
                sqlstring = " UPDATE SUBSTORECONSUMPTIONDETAIL SET VOID = 'Y' WHERE DOCDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring
                '***************************************************************************************************************************
                '''************************************************* COMPLETE KOT_HDR ***************************************************'''

                sqlstring = " UPDATE BILL_HDR SET DELFLAG = 'Y' WHERE BILLDETAILS='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring

                '''************************************************* COMPLETE KOT_HDR ***************************************************'''
                sqlstring = " UPDATE BILL_DET SET DELFLAG = 'Y' WHERE BILLDETAILS='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring

                '''************************************************* COMPLETE BILLSETTLEMENT ***************************************************'''
                sqlstring = " UPDATE BILLSETTLEMENT SET DELFLAG = 'Y' WHERE BILLNO='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring

                sqlstring = " UPDATE KOT_HDR SET VOUCHERNO = '',POSTINGSTATUS = 'N' WHERE KOTDETAILS='" & txt_KOTno.Text & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring

                '''************************************************* COMPLETE KOT_HDR ***************************************************'''
                sqlstring = "SELECT ISNULL(KOTDETAILS,'') AS KOTDETAILS,KOTDATE,ISNULL(VOUCHERNO,'') AS VOUCHERNO,ISNULL(POSTINGSTATUS,'') As POSTINGSTATUS FROM KOT_HDR  WHERE KOTDETAILS='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                gconnection.getDataSet(sqlstring, "KOTHDR")
                If gdataset.Tables("KOTHDR").Rows.Count > 0 Then

                    sqlstring = " UPDATE KOT_HDR SET VOUCHERNO = '',POSTINGSTATUS = 'N' WHERE KOTDETAILS='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring
                    sqlstring = " UPDATE JOURNALENTRY SET VOID = 'Y' WHERE VOUCHERNO='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring
                    sqlstring = " UPDATE OUTSTANDING SET VOID = 'Y' WHERE VOUCHERNO='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring
                End If
                sqlstring = " UPDATE SETTLEMENT SET DELETEFLAG = 'Y' WHERE BILLDETAILS='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring
                sqlstring = " UPDATE ROOMLEDGER SET CANCEL='Y',VOIDSTATUS='Y' WHERE ROOMNO =" & Val(txt_MemberCode.Text) & " "
                sqlstring = sqlstring & " AND DOCTYPE='SALES' AND DOCNO in ('" & Trim(txt_KOTno.Text) & "')"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring

                'gconnection.MoreTrans(Delete)
                'karthi 
                'FOR DELETE OPTION
                'dec 11

                If cbo_PaymentMode.Text = "SMART CARD" Then
                    sqlstring = " UPDATE SM_POSTRANSACTION SET VOID ='Y', VOIDUSER='" & gUsername & "' WHERE BILL_NO='" & Trim(txt_KOTno.Text) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring

                    sqlstring = "SELECT * FROM  SM_POSTRANSACTION WHERE BILL_NO ='" & Trim(txt_KOTno.Text) & "'"
                    gconnection.getDataSet(sqlstring, "SM_POSTRANSACTION")
                    If gdataset.Tables("SM_POSTRANSACTION").Rows.Count > 0 Then
                        sqlstring = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE +" & Val(txt_BillAmount.Text + Amt) & " WHERE CARDCODE='" & Trim(txt_Holder_Code.Text) & "'"
                        ReDim Preserve Delete(Delete.Length)
                        Delete(Delete.Length - 1) = sqlstring
                    End If
                End If

                'karthi 
                'UPDATE POSVALID DATE TO NULL
                'CANT TRACK BEFORE
                'WANT TO BE DONE BY ADMIN
                Dim STRSQL2 As String
                STRSQL2 = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"
                'STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'F' "
                gconnection.getDataSet(STRSQL2, "SM_CARDFILE_DET")
                If gdataset.Tables("SM_CARDFILE_DET").Rows.Count > 0 Then
                    POS_AMT_GBL = Val(txt_TotalValue.Text)
                    STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'F' "
                    gconnection.getDataSet(STRSQL2, "FACILITY")
                    If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                        'ONCE FACILITY 
                        sqlstring = " UPDATE SM_CARDFILE_HDR SET UPDATEUSER='" & Trim(gUsername) & "',UPDATEDATETIME='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "' WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "'"
                        ReDim Preserve Delete(Delete.Length)
                        Delete(Delete.Length - 1) = sqlstring
                        'sqlstring = " UPDATE SM_CARDFILE_DET SET POS_VALID_FROM='" & Format(Cmb_Validfrom.Value, "dd/MMM/yyyy") & "',POS_VALID_TO='" & Format(Cmb_Validto.Value, "dd/MMM/yyyy") & "',TIME_FROM='" & Format(Cmb_TimeFrom.Value, "HH:MM") & "', TIME_TO='" & Format(Cmb_TimeTo.Value, "HH:MM") & "',DURATION='" & Format(Cmb_Duration.Value, "hh:mm") & "', HOURLY_BILL=" & POS_RATE_GBL & ", PERIOD_TO_DATE_USAGE=" & POS_AMT_GBL & " WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"

                        sqlstring = " SELECT POS_ACCESS, isNULL(POS_VALID_FROM,'01/01/1900') AS POS_VALID_FROM, ISNULL(POS_VALID_TO,'01/01/1900')AS POS_VALID_TO, ISNULL(TIME_FROM,'01/01/1900 00:00') AS TIME_FROM, ISNULL(TIME_TO,'01/01/1900 00:00') AS TIME_TO, ISNULL(DURATION,'01/01/1900 00:00')AS DURATION  FROM SM_CARDFILE_DET_IMG WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"
                        gconnection.getDataSet(sqlstring, "SM_CARDFILE_DET_IMG")
                        If gdataset.Tables("SM_CARDFILE_DET_IMG").Rows.Count > 0 Then
                            Dim POS_ACCESS As String
                            Dim POS_VALID_FROM, POS_VALID_TO, TIME_FROM, TIME_TO, DURATION As DateTime
                            POS_ACCESS = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("POS_ACCESS")
                            POS_VALID_FROM = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("POS_VALID_FROM")
                            POS_VALID_TO = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("POS_VALID_TO")
                            TIME_FROM = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("TIME_FROM")
                            TIME_TO = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("TIME_TO")
                            DURATION = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("DURATION")
                            sqlstring = " UPDATE SM_CARDFILE_DET SET POS_ACCESS='" & POS_ACCESS & "',POS_VALID_FROM ='" & Format(POS_VALID_FROM, "dd/MMM/yyyy") & "',POS_VALID_TO='" & Format(POS_VALID_TO, "dd/MMM/yyyy") & "',TIME_FROM='" & Format(TIME_FROM, "HH:MM") & "',TIME_TO='" & Format(TIME_TO, "HH:MM") & "',DURATION='" & Format(DURATION, "HH:MM") & "' WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"
                            ReDim Preserve Delete(Delete.Length)
                            Delete(Delete.Length - 1) = sqlstring
                        End If
                    End If
                End If
                sqlstring = " UPDATE JOURNALENTRY SET VOID = 'Y' WHERE VOUCHERNO='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring
                sqlstring = " UPDATE OUTSTANDING SET VOID = 'Y' WHERE VOUCHERNO='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring

                gconnection.MORETRANS(Delete)
                Call txt_MemberCode_Validated(sender, e)
                '                gconnection.MoreTransold(Delete)
                Call cmd_Clear_Click(cmd_Clear, e)
            End If
        Else
            MessageBox.Show("Plz Enter a Valid KOTno", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Call cmd_Clear_Click(cmd_Clear, e)
            Exit Sub
        End If
    End Sub
    Private Sub cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_View.Click
        gPrint = False
        Call GNC_PRINT()
    End Sub
    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        Call GNC_PRINT()
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        smartdeviceportcount = 0
        Me.Close()
    End Sub

    Private Sub txt_card_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_card_id.TextChanged

    End Sub

    Private Sub txt_card_id_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_card_id.Validating

    End Sub
End Class


