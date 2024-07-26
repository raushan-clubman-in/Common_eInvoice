Imports System.Data.SqlClient
Imports System.IO
Public Class KOT_Billing
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
    Friend WithEvents FraGrid As System.Windows.Forms.GroupBox
    Friend WithEvents GraMem As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBill As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents cbo_PaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_PaymentMode As System.Windows.Forms.Label
    Friend WithEvents txt_ServerName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ServerName As System.Windows.Forms.Label
    Friend WithEvents Cmd_ServerCodeHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_ServerCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ServerCode As System.Windows.Forms.Label
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MemberName As System.Windows.Forms.Label
    Friend WithEvents cmd_BillNoHelp As System.Windows.Forms.Button
    Friend WithEvents txt_BillNo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_BillNo As System.Windows.Forms.Label
    Friend WithEvents lbl_BillDate As System.Windows.Forms.Label
    Friend WithEvents lbl_BillAmount As System.Windows.Forms.Label
    Friend WithEvents txt_BillAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtp_BillDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_KOTTime As System.Windows.Forms.TextBox
    Friend WithEvents KOT_Timer As System.Windows.Forms.Timer
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents Lbl_OtherBill As System.Windows.Forms.Label
    Friend WithEvents lbl_SubPaymentMode As System.Windows.Forms.Label
    Friend WithEvents cbo_SubPaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents ssGrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Bill As System.Windows.Forms.Label
    Friend WithEvents Txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents grp_Paymentmodeselection As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Paymentmodeselection As System.Windows.Forms.Label
    Friend WithEvents grp_Carddetails As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Carddetails As System.Windows.Forms.Label
    Friend WithEvents lbl_Expirydate As System.Windows.Forms.Label
    Friend WithEvents lbl_Cardno As System.Windows.Forms.Label
    Friend WithEvents lbl_Typeofcard As System.Windows.Forms.Label
    Friend WithEvents lbl_cardholdername As System.Windows.Forms.Label
    Friend WithEvents txt_Typeofcard As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cardno As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Expirydate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Cardholdername As System.Windows.Forms.TextBox
    Friend WithEvents grp_Chequedetails As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Draweebank As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Chequedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Chequeno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Draweebank As System.Windows.Forms.Label
    Friend WithEvents lbl_Chequedate As System.Windows.Forms.Label
    Friend WithEvents lbl_Chequeno As System.Windows.Forms.Label
    Friend WithEvents lbl_Typeofcheque As System.Windows.Forms.Label
    Friend WithEvents lbl_Chequedetails As System.Windows.Forms.Label
    Friend WithEvents cbo_Typeofcheque As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_Back As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_PartialPayment As System.Windows.Forms.TextBox
    Friend WithEvents lbl_PartialPayment As System.Windows.Forms.Label
    Friend WithEvents cmd_Save As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDeleted As System.Windows.Forms.Label
    Friend WithEvents lblCro1 As System.Windows.Forms.Label
    Friend WithEvents lblCro2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdMcodeUpd As System.Windows.Forms.Button
    Friend WithEvents grpNewMcode As System.Windows.Forms.GroupBox
    Friend WithEvents txtNmcode As System.Windows.Forms.TextBox
    Friend WithEvents txtNmname As System.Windows.Forms.TextBox
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents grpPassword As System.Windows.Forms.GroupBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents ssgridPayment As AxFPSpreadADO.AxfpSpread
    Friend WithEvents grpPass As System.Windows.Forms.GroupBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCro As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GRP_SETTLEMENT As System.Windows.Forms.GroupBox
    Friend WithEvents SETLEMENT_GROUP As System.Windows.Forms.GroupBox
    Friend WithEvents DomainUpDown1 As System.Windows.Forms.DomainUpDown
    Friend WithEvents ssgrid_settlement As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LAB_BALANCEAMT As System.Windows.Forms.Label
    Friend WithEvents CMD_SETTLEMENT As System.Windows.Forms.Button
    Friend WithEvents LAB_SPILTMEMBER As System.Windows.Forms.Label
    Friend WithEvents CMB_SPILTMEMBER As System.Windows.Forms.ComboBox
    Friend WithEvents CHKALL As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CMB_BTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Pic_Member As System.Windows.Forms.PictureBox
    Friend WithEvents lab_outstanding As System.Windows.Forms.Label
    Friend WithEvents Timer_Delay As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CHK_PRINT As System.Windows.Forms.CheckBox
    Friend WithEvents txt_card_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_SwipeCard As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_lastbillamount As System.Windows.Forms.TextBox
    Friend WithEvents txt_lostcardcode As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_DC_Update As System.Windows.Forms.Button
    Friend WithEvents Txt_holder_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_Holder_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents cmd_BillSettlement As System.Windows.Forms.Button
    Friend WithEvents LAB_CARDBAL As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(KOT_Billing))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.FraGrid = New System.Windows.Forms.GroupBox
        Me.ssGrid1 = New AxFPSpreadADO.AxfpSpread
        Me.GraMem = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Txt_holder_name = New System.Windows.Forms.TextBox
        Me.txt_Holder_Code = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GRP_SETTLEMENT = New System.Windows.Forms.GroupBox
        Me.lbl_SubPaymentMode = New System.Windows.Forms.Label
        Me.cbo_SubPaymentMode = New System.Windows.Forms.ComboBox
        Me.cbo_PaymentMode = New System.Windows.Forms.ComboBox
        Me.lbl_PaymentMode = New System.Windows.Forms.Label
        Me.txt_ServerName = New System.Windows.Forms.TextBox
        Me.lbl_ServerName = New System.Windows.Forms.Label
        Me.Cmd_ServerCodeHelp = New System.Windows.Forms.Button
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.txt_ServerCode = New System.Windows.Forms.TextBox
        Me.lbl_ServerCode = New System.Windows.Forms.Label
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.lbl_MemberCode = New System.Windows.Forms.Label
        Me.txt_MemberName = New System.Windows.Forms.TextBox
        Me.lbl_MemberName = New System.Windows.Forms.Label
        Me.GrpBill = New System.Windows.Forms.GroupBox
        Me.Pic_Member = New System.Windows.Forms.PictureBox
        Me.CMB_BTYPE = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_BillNo = New System.Windows.Forms.TextBox
        Me.cmd_BillNoHelp = New System.Windows.Forms.Button
        Me.lbl_BillNo = New System.Windows.Forms.Label
        Me.lbl_BillDate = New System.Windows.Forms.Label
        Me.lbl_BillAmount = New System.Windows.Forms.Label
        Me.txt_BillAmount = New System.Windows.Forms.TextBox
        Me.dtp_BillDate = New System.Windows.Forms.DateTimePicker
        Me.txt_KOTTime = New System.Windows.Forms.TextBox
        Me.KOT_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.Lbl_OtherBill = New System.Windows.Forms.Label
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Lbl_Bill = New System.Windows.Forms.Label
        Me.Txt_Remarks = New System.Windows.Forms.TextBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.grp_Paymentmodeselection = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmd_Save = New System.Windows.Forms.Button
        Me.cmd_Cancel = New System.Windows.Forms.Button
        Me.cmd_Back = New System.Windows.Forms.Button
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
        Me.txt_PartialPayment = New System.Windows.Forms.TextBox
        Me.lbl_PartialPayment = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDeleted = New System.Windows.Forms.Label
        Me.lblCro1 = New System.Windows.Forms.Label
        Me.lblCro2 = New System.Windows.Forms.Label
        Me.grpNewMcode = New System.Windows.Forms.GroupBox
        Me.cmdCro = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNmcode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNmname = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdMcodeUpd = New System.Windows.Forms.Button
        Me.grpPassword = New System.Windows.Forms.GroupBox
        Me.grpPass = New System.Windows.Forms.GroupBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.ssgridPayment = New AxFPSpreadADO.AxfpSpread
        Me.SETLEMENT_GROUP = New System.Windows.Forms.GroupBox
        Me.CMD_SETTLEMENT = New System.Windows.Forms.Button
        Me.LAB_BALANCEAMT = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ssgrid_settlement = New AxFPSpreadADO.AxfpSpread
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown
        Me.LAB_SPILTMEMBER = New System.Windows.Forms.Label
        Me.CMB_SPILTMEMBER = New System.Windows.Forms.ComboBox
        Me.CHKALL = New System.Windows.Forms.CheckBox
        Me.lab_outstanding = New System.Windows.Forms.Label
        Me.Timer_Delay = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CHK_PRINT = New System.Windows.Forms.CheckBox
        Me.txt_card_id = New System.Windows.Forms.TextBox
        Me.lbl_SwipeCard = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txt_lastbillamount = New System.Windows.Forms.TextBox
        Me.txt_lostcardcode = New System.Windows.Forms.TextBox
        Me.Cmd_DC_Update = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.cmd_View = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.cmd_BillSettlement = New System.Windows.Forms.Button
        Me.LAB_CARDBAL = New System.Windows.Forms.Label
        CType(Me.ssGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GraMem.SuspendLayout()
        Me.GrpBill.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grp_Paymentmodeselection.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp_Chequedetails.SuspendLayout()
        Me.grp_Carddetails.SuspendLayout()
        Me.grpNewMcode.SuspendLayout()
        Me.grpPass.SuspendLayout()
        CType(Me.ssgridPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SETLEMENT_GROUP.SuspendLayout()
        CType(Me.ssgrid_settlement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.Black
        Me.lbl_Heading.Location = New System.Drawing.Point(304, 8)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(222, 35)
        Me.lbl_Heading.TabIndex = 18
        Me.lbl_Heading.Text = "FINAL BILLING"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FraGrid
        '
        Me.FraGrid.BackColor = System.Drawing.Color.Transparent
        Me.FraGrid.Location = New System.Drawing.Point(80, 304)
        Me.FraGrid.Name = "FraGrid"
        Me.FraGrid.Size = New System.Drawing.Size(864, 240)
        Me.FraGrid.TabIndex = 6
        Me.FraGrid.TabStop = False
        '
        'ssGrid1
        '
        Me.ssGrid1.ContainingControl = Me
        Me.ssGrid1.DataSource = Nothing
        Me.ssGrid1.Location = New System.Drawing.Point(13, 13)
        Me.ssGrid1.Name = "ssGrid1"
        Me.ssGrid1.OcxState = CType(resources.GetObject("ssGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid1.Size = New System.Drawing.Size(608, 228)
        Me.ssGrid1.TabIndex = 0
        '
        'GraMem
        '
        Me.GraMem.BackColor = System.Drawing.Color.Transparent
        Me.GraMem.Controls.Add(Me.Label9)
        Me.GraMem.Controls.Add(Me.Txt_holder_name)
        Me.GraMem.Controls.Add(Me.txt_Holder_Code)
        Me.GraMem.Controls.Add(Me.Label5)
        Me.GraMem.Controls.Add(Me.GRP_SETTLEMENT)
        Me.GraMem.Location = New System.Drawing.Point(80, 136)
        Me.GraMem.Name = "GraMem"
        Me.GraMem.Size = New System.Drawing.Size(864, 168)
        Me.GraMem.TabIndex = 25
        Me.GraMem.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(434, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(207, 25)
        Me.Label9.TabIndex = 608
        Me.Label9.Text = "CARD HOLDER NAME"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_holder_name
        '
        Me.Txt_holder_name.BackColor = System.Drawing.Color.Wheat
        Me.Txt_holder_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_holder_name.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_holder_name.Location = New System.Drawing.Point(648, 88)
        Me.Txt_holder_name.MaxLength = 50
        Me.Txt_holder_name.Name = "Txt_holder_name"
        Me.Txt_holder_name.ReadOnly = True
        Me.Txt_holder_name.Size = New System.Drawing.Size(192, 29)
        Me.Txt_holder_name.TabIndex = 606
        Me.Txt_holder_name.Text = ""
        '
        'txt_Holder_Code
        '
        Me.txt_Holder_Code.BackColor = System.Drawing.Color.Wheat
        Me.txt_Holder_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Holder_Code.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Holder_Code.Location = New System.Drawing.Point(191, 88)
        Me.txt_Holder_Code.MaxLength = 15
        Me.txt_Holder_Code.Name = "txt_Holder_Code"
        Me.txt_Holder_Code.ReadOnly = True
        Me.txt_Holder_Code.Size = New System.Drawing.Size(192, 29)
        Me.txt_Holder_Code.TabIndex = 605
        Me.txt_Holder_Code.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(43, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 25)
        Me.Label5.TabIndex = 607
        Me.Label5.Text = "CARD HOLDER"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GRP_SETTLEMENT
        '
        Me.GRP_SETTLEMENT.BackColor = System.Drawing.Color.Transparent
        Me.GRP_SETTLEMENT.Location = New System.Drawing.Point(8, 168)
        Me.GRP_SETTLEMENT.Name = "GRP_SETTLEMENT"
        Me.GRP_SETTLEMENT.Size = New System.Drawing.Size(864, 336)
        Me.GRP_SETTLEMENT.TabIndex = 370
        Me.GRP_SETTLEMENT.TabStop = False
        '
        'lbl_SubPaymentMode
        '
        Me.lbl_SubPaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubPaymentMode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubPaymentMode.ForeColor = System.Drawing.Color.Black
        Me.lbl_SubPaymentMode.Location = New System.Drawing.Point(502, 146)
        Me.lbl_SubPaymentMode.Name = "lbl_SubPaymentMode"
        Me.lbl_SubPaymentMode.Size = New System.Drawing.Size(218, 25)
        Me.lbl_SubPaymentMode.TabIndex = 27
        Me.lbl_SubPaymentMode.Text = "SUB PAYMENT MODE "
        Me.lbl_SubPaymentMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_SubPaymentMode.Visible = False
        '
        'cbo_SubPaymentMode
        '
        Me.cbo_SubPaymentMode.BackColor = System.Drawing.Color.White
        Me.cbo_SubPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SubPaymentMode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SubPaymentMode.Location = New System.Drawing.Point(728, 144)
        Me.cbo_SubPaymentMode.Name = "cbo_SubPaymentMode"
        Me.cbo_SubPaymentMode.Size = New System.Drawing.Size(192, 30)
        Me.cbo_SubPaymentMode.TabIndex = 1
        Me.cbo_SubPaymentMode.Visible = False
        '
        'cbo_PaymentMode
        '
        Me.cbo_PaymentMode.BackColor = System.Drawing.Color.White
        Me.cbo_PaymentMode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_PaymentMode.Location = New System.Drawing.Point(272, 144)
        Me.cbo_PaymentMode.Name = "cbo_PaymentMode"
        Me.cbo_PaymentMode.Size = New System.Drawing.Size(192, 30)
        Me.cbo_PaymentMode.TabIndex = 0
        '
        'lbl_PaymentMode
        '
        Me.lbl_PaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PaymentMode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PaymentMode.ForeColor = System.Drawing.Color.Black
        Me.lbl_PaymentMode.Location = New System.Drawing.Point(97, 148)
        Me.lbl_PaymentMode.Name = "lbl_PaymentMode"
        Me.lbl_PaymentMode.Size = New System.Drawing.Size(171, 25)
        Me.lbl_PaymentMode.TabIndex = 26
        Me.lbl_PaymentMode.Text = "PAYMENT MODE "
        Me.lbl_PaymentMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_ServerName
        '
        Me.txt_ServerName.BackColor = System.Drawing.Color.White
        Me.txt_ServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerName.Enabled = False
        Me.txt_ServerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerName.Location = New System.Drawing.Point(728, 265)
        Me.txt_ServerName.MaxLength = 35
        Me.txt_ServerName.Name = "txt_ServerName"
        Me.txt_ServerName.ReadOnly = True
        Me.txt_ServerName.Size = New System.Drawing.Size(192, 29)
        Me.txt_ServerName.TabIndex = 5
        Me.txt_ServerName.Text = ""
        '
        'lbl_ServerName
        '
        Me.lbl_ServerName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ServerName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ServerName.ForeColor = System.Drawing.Color.Black
        Me.lbl_ServerName.Location = New System.Drawing.Point(537, 266)
        Me.lbl_ServerName.Name = "lbl_ServerName"
        Me.lbl_ServerName.Size = New System.Drawing.Size(183, 25)
        Me.lbl_ServerName.TabIndex = 33
        Me.lbl_ServerName.Text = "LOCATION NAME "
        Me.lbl_ServerName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Cmd_ServerCodeHelp
        '
        Me.Cmd_ServerCodeHelp.Enabled = False
        Me.Cmd_ServerCodeHelp.Image = CType(resources.GetObject("Cmd_ServerCodeHelp.Image"), System.Drawing.Image)
        Me.Cmd_ServerCodeHelp.Location = New System.Drawing.Point(442, 265)
        Me.Cmd_ServerCodeHelp.Name = "Cmd_ServerCodeHelp"
        Me.Cmd_ServerCodeHelp.Size = New System.Drawing.Size(23, 32)
        Me.Cmd_ServerCodeHelp.TabIndex = 32
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(440, 184)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(23, 29)
        Me.cmd_MemberCodeHelp.TabIndex = 29
        '
        'txt_ServerCode
        '
        Me.txt_ServerCode.BackColor = System.Drawing.Color.White
        Me.txt_ServerCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerCode.Enabled = False
        Me.txt_ServerCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerCode.Location = New System.Drawing.Point(272, 265)
        Me.txt_ServerCode.MaxLength = 10
        Me.txt_ServerCode.Name = "txt_ServerCode"
        Me.txt_ServerCode.Size = New System.Drawing.Size(168, 29)
        Me.txt_ServerCode.TabIndex = 4
        Me.txt_ServerCode.Text = ""
        '
        'lbl_ServerCode
        '
        Me.lbl_ServerCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ServerCode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ServerCode.ForeColor = System.Drawing.Color.Black
        Me.lbl_ServerCode.Location = New System.Drawing.Point(88, 265)
        Me.lbl_ServerCode.Name = "lbl_ServerCode"
        Me.lbl_ServerCode.Size = New System.Drawing.Size(183, 25)
        Me.lbl_ServerCode.TabIndex = 31
        Me.lbl_ServerCode.Text = "LOCATION CODE "
        Me.lbl_ServerCode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.White
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(272, 184)
        Me.txt_MemberCode.MaxLength = 10
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(192, 29)
        Me.txt_MemberCode.TabIndex = 2
        Me.txt_MemberCode.Text = ""
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.ForeColor = System.Drawing.Color.Black
        Me.lbl_MemberCode.Location = New System.Drawing.Point(110, 184)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(160, 25)
        Me.lbl_MemberCode.TabIndex = 28
        Me.lbl_MemberCode.Text = "MEMBER CODE "
        Me.lbl_MemberCode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BackColor = System.Drawing.Color.White
        Me.txt_MemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(728, 184)
        Me.txt_MemberName.MaxLength = 35
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.ReadOnly = True
        Me.txt_MemberName.Size = New System.Drawing.Size(192, 29)
        Me.txt_MemberName.TabIndex = 3
        Me.txt_MemberName.Text = ""
        '
        'lbl_MemberName
        '
        Me.lbl_MemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberName.ForeColor = System.Drawing.Color.Black
        Me.lbl_MemberName.Location = New System.Drawing.Point(560, 186)
        Me.lbl_MemberName.Name = "lbl_MemberName"
        Me.lbl_MemberName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_MemberName.TabIndex = 30
        Me.lbl_MemberName.Text = "MEMBER NAME "
        Me.lbl_MemberName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GrpBill
        '
        Me.GrpBill.BackColor = System.Drawing.Color.Transparent
        Me.GrpBill.Controls.Add(Me.Pic_Member)
        Me.GrpBill.Controls.Add(Me.CMB_BTYPE)
        Me.GrpBill.Controls.Add(Me.Label7)
        Me.GrpBill.Controls.Add(Me.txt_BillNo)
        Me.GrpBill.Location = New System.Drawing.Point(528, 8)
        Me.GrpBill.Name = "GrpBill"
        Me.GrpBill.Size = New System.Drawing.Size(416, 128)
        Me.GrpBill.TabIndex = 20
        Me.GrpBill.TabStop = False
        '
        'Pic_Member
        '
        Me.Pic_Member.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic_Member.Location = New System.Drawing.Point(341, 44)
        Me.Pic_Member.Name = "Pic_Member"
        Me.Pic_Member.Size = New System.Drawing.Size(71, 80)
        Me.Pic_Member.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Member.TabIndex = 591
        Me.Pic_Member.TabStop = False
        '
        'CMB_BTYPE
        '
        Me.CMB_BTYPE.BackColor = System.Drawing.Color.Wheat
        Me.CMB_BTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_BTYPE.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_BTYPE.Location = New System.Drawing.Point(128, 14)
        Me.CMB_BTYPE.Name = "CMB_BTYPE"
        Me.CMB_BTYPE.Size = New System.Drawing.Size(184, 30)
        Me.CMB_BTYPE.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(11, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 25)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "BILLTYPE"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_BillNo
        '
        Me.txt_BillNo.BackColor = System.Drawing.Color.Wheat
        Me.txt_BillNo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BillNo.ForeColor = System.Drawing.Color.Blue
        Me.txt_BillNo.Location = New System.Drawing.Point(128, 48)
        Me.txt_BillNo.Name = "txt_BillNo"
        Me.txt_BillNo.Size = New System.Drawing.Size(184, 32)
        Me.txt_BillNo.TabIndex = 15
        Me.txt_BillNo.Text = ""
        '
        'cmd_BillNoHelp
        '
        Me.cmd_BillNoHelp.Image = CType(resources.GetObject("cmd_BillNoHelp.Image"), System.Drawing.Image)
        Me.cmd_BillNoHelp.Location = New System.Drawing.Point(843, 56)
        Me.cmd_BillNoHelp.Name = "cmd_BillNoHelp"
        Me.cmd_BillNoHelp.Size = New System.Drawing.Size(23, 32)
        Me.cmd_BillNoHelp.TabIndex = 22
        '
        'lbl_BillNo
        '
        Me.lbl_BillNo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillNo.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillNo.ForeColor = System.Drawing.Color.Black
        Me.lbl_BillNo.Location = New System.Drawing.Point(539, 61)
        Me.lbl_BillNo.Name = "lbl_BillNo"
        Me.lbl_BillNo.Size = New System.Drawing.Size(113, 25)
        Me.lbl_BillNo.TabIndex = 21
        Me.lbl_BillNo.Text = "BILL NO "
        Me.lbl_BillNo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_BillDate
        '
        Me.lbl_BillDate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillDate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillDate.ForeColor = System.Drawing.Color.Black
        Me.lbl_BillDate.Location = New System.Drawing.Point(528, 96)
        Me.lbl_BillDate.Name = "lbl_BillDate"
        Me.lbl_BillDate.Size = New System.Drawing.Size(124, 25)
        Me.lbl_BillDate.TabIndex = 23
        Me.lbl_BillDate.Text = "BILL DATE"
        Me.lbl_BillDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_BillAmount
        '
        Me.lbl_BillAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillAmount.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillAmount.ForeColor = System.Drawing.Color.Black
        Me.lbl_BillAmount.Location = New System.Drawing.Point(584, 557)
        Me.lbl_BillAmount.Name = "lbl_BillAmount"
        Me.lbl_BillAmount.Size = New System.Drawing.Size(160, 25)
        Me.lbl_BillAmount.TabIndex = 37
        Me.lbl_BillAmount.Text = "BILL AMOUNT "
        Me.lbl_BillAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_BillAmount
        '
        Me.txt_BillAmount.BackColor = System.Drawing.Color.White
        Me.txt_BillAmount.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BillAmount.Location = New System.Drawing.Point(752, 552)
        Me.txt_BillAmount.MaxLength = 12
        Me.txt_BillAmount.Name = "txt_BillAmount"
        Me.txt_BillAmount.ReadOnly = True
        Me.txt_BillAmount.Size = New System.Drawing.Size(192, 29)
        Me.txt_BillAmount.TabIndex = 38
        Me.txt_BillAmount.Text = ""
        Me.txt_BillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtp_BillDate
        '
        Me.dtp_BillDate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_BillDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_BillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_BillDate.Location = New System.Drawing.Point(656, 96)
        Me.dtp_BillDate.Name = "dtp_BillDate"
        Me.dtp_BillDate.Size = New System.Drawing.Size(104, 26)
        Me.dtp_BillDate.TabIndex = 16
        Me.dtp_BillDate.Value = New Date(2010, 5, 13, 0, 0, 0, 0)
        '
        'txt_KOTTime
        '
        Me.txt_KOTTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_KOTTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_KOTTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_KOTTime.Location = New System.Drawing.Point(760, 96)
        Me.txt_KOTTime.Name = "txt_KOTTime"
        Me.txt_KOTTime.ReadOnly = True
        Me.txt_KOTTime.Size = New System.Drawing.Size(104, 26)
        Me.txt_KOTTime.TabIndex = 17
        Me.txt_KOTTime.Text = ""
        '
        'KOT_Timer
        '
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Status.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Status.Location = New System.Drawing.Point(88, 48)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(0, 25)
        Me.lbl_Status.TabIndex = 19
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_OtherBill
        '
        Me.Lbl_OtherBill.BackColor = System.Drawing.Color.DarkMagenta
        Me.Lbl_OtherBill.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_OtherBill.ForeColor = System.Drawing.Color.White
        Me.Lbl_OtherBill.Location = New System.Drawing.Point(-448, 72)
        Me.Lbl_OtherBill.Name = "Lbl_OtherBill"
        Me.Lbl_OtherBill.Size = New System.Drawing.Size(448, 24)
        Me.Lbl_OtherBill.TabIndex = 24
        Me.Lbl_OtherBill.Text = "OTHER BILLNO :"
        Me.Lbl_OtherBill.Visible = False
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(80, 312)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(856, 232)
        Me.ssGrid.TabIndex = 34
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
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(976, 56)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(286, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(704, 14)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.TabIndex = 19
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(568, 14)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.TabIndex = 18
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(840, 14)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(429, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(145, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Lbl_Bill
        '
        Me.Lbl_Bill.AutoSize = True
        Me.Lbl_Bill.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Bill.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bill.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_Bill.Location = New System.Drawing.Point(8, 584)
        Me.Lbl_Bill.Name = "Lbl_Bill"
        Me.Lbl_Bill.Size = New System.Drawing.Size(0, 25)
        Me.Lbl_Bill.TabIndex = 36
        Me.Lbl_Bill.Visible = False
        '
        'Txt_Remarks
        '
        Me.Txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Remarks.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Remarks.Location = New System.Drawing.Point(240, 552)
        Me.Txt_Remarks.MaxLength = 100
        Me.Txt_Remarks.Multiline = True
        Me.Txt_Remarks.Name = "Txt_Remarks"
        Me.Txt_Remarks.Size = New System.Drawing.Size(328, 32)
        Me.Txt_Remarks.TabIndex = 7
        Me.Txt_Remarks.Text = ""
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.ForeColor = System.Drawing.Color.Black
        Me.lbl_Remarks.Location = New System.Drawing.Point(96, 558)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(113, 25)
        Me.lbl_Remarks.TabIndex = 35
        Me.lbl_Remarks.Text = "REMARKS "
        Me.lbl_Remarks.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grp_Paymentmodeselection
        '
        Me.grp_Paymentmodeselection.BackgroundImage = CType(resources.GetObject("grp_Paymentmodeselection.BackgroundImage"), System.Drawing.Image)
        Me.grp_Paymentmodeselection.Controls.Add(Me.GroupBox1)
        Me.grp_Paymentmodeselection.Controls.Add(Me.grp_Chequedetails)
        Me.grp_Paymentmodeselection.Controls.Add(Me.grp_Carddetails)
        Me.grp_Paymentmodeselection.Controls.Add(Me.lbl_Paymentmodeselection)
        Me.grp_Paymentmodeselection.Controls.Add(Me.txt_PartialPayment)
        Me.grp_Paymentmodeselection.Controls.Add(Me.lbl_PartialPayment)
        Me.grp_Paymentmodeselection.Location = New System.Drawing.Point(80, 304)
        Me.grp_Paymentmodeselection.Name = "grp_Paymentmodeselection"
        Me.grp_Paymentmodeselection.Size = New System.Drawing.Size(864, 240)
        Me.grp_Paymentmodeselection.TabIndex = 360
        Me.grp_Paymentmodeselection.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.cmd_Save)
        Me.GroupBox1.Controls.Add(Me.cmd_Cancel)
        Me.GroupBox1.Controls.Add(Me.cmd_Back)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 232)
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
        Me.cmd_Save.ForeColor = System.Drawing.Color.Black
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
        Me.cmd_Cancel.ForeColor = System.Drawing.Color.Black
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
        Me.cmd_Back.ForeColor = System.Drawing.Color.Black
        Me.cmd_Back.Image = CType(resources.GetObject("cmd_Back.Image"), System.Drawing.Image)
        Me.cmd_Back.Location = New System.Drawing.Point(24, 14)
        Me.cmd_Back.Name = "cmd_Back"
        Me.cmd_Back.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Back.TabIndex = 0
        Me.cmd_Back.Text = "BACK"
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
        Me.lbl_Paymentmodeselection.Location = New System.Drawing.Point(0, 16)
        Me.lbl_Paymentmodeselection.Name = "lbl_Paymentmodeselection"
        Me.lbl_Paymentmodeselection.Size = New System.Drawing.Size(851, 24)
        Me.lbl_Paymentmodeselection.TabIndex = 5
        Me.lbl_Paymentmodeselection.Text = "PAYMENT MODE SELECTION :"
        '
        'txt_PartialPayment
        '
        Me.txt_PartialPayment.BackColor = System.Drawing.Color.White
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
        Me.lbl_PartialPayment.ForeColor = System.Drawing.Color.Brown
        Me.lbl_PartialPayment.Location = New System.Drawing.Point(496, 256)
        Me.lbl_PartialPayment.Name = "lbl_PartialPayment"
        Me.lbl_PartialPayment.Size = New System.Drawing.Size(160, 25)
        Me.lbl_PartialPayment.TabIndex = 38
        Me.lbl_PartialPayment.Text = "BILL AMOUNT :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(16, 640)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(968, 16)
        Me.Label3.TabIndex = 361
        Me.Label3.Text = "F4-->Help  F2-->Bill No  Flash Card Alt+C  Alt+P--> Payment Mode   Alt+B--> Membe" & _
        "r Code  Alt+S--> Server Code Alt+G-->Focus on Grid   Alt+K-> Remarks   Alt+D ->D" & _
        "ate"
        '
        'lblDeleted
        '
        Me.lblDeleted.BackColor = System.Drawing.Color.Transparent
        Me.lblDeleted.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeleted.ForeColor = System.Drawing.Color.Red
        Me.lblDeleted.Location = New System.Drawing.Point(80, 16)
        Me.lblDeleted.Name = "lblDeleted"
        Me.lblDeleted.Size = New System.Drawing.Size(176, 23)
        Me.lblDeleted.TabIndex = 362
        Me.lblDeleted.Text = "DELETED BILL"
        Me.lblDeleted.Visible = False
        '
        'lblCro1
        '
        Me.lblCro1.BackColor = System.Drawing.Color.Transparent
        Me.lblCro1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCro1.ForeColor = System.Drawing.Color.Black
        Me.lblCro1.Location = New System.Drawing.Point(107, 16)
        Me.lblCro1.Name = "lblCro1"
        Me.lblCro1.Size = New System.Drawing.Size(72, 16)
        Me.lblCro1.TabIndex = 363
        Me.lblCro1.Text = "CRO NO. "
        Me.lblCro1.Visible = False
        '
        'lblCro2
        '
        Me.lblCro2.BackColor = System.Drawing.Color.Transparent
        Me.lblCro2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCro2.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblCro2.Location = New System.Drawing.Point(168, 16)
        Me.lblCro2.Name = "lblCro2"
        Me.lblCro2.Size = New System.Drawing.Size(349, 16)
        Me.lblCro2.TabIndex = 364
        Me.lblCro2.Visible = False
        '
        'grpNewMcode
        '
        Me.grpNewMcode.BackColor = System.Drawing.Color.Pink
        Me.grpNewMcode.Controls.Add(Me.cmdCro)
        Me.grpNewMcode.Controls.Add(Me.Button2)
        Me.grpNewMcode.Controls.Add(Me.cmdUpdate)
        Me.grpNewMcode.Controls.Add(Me.Label1)
        Me.grpNewMcode.Controls.Add(Me.txtNmcode)
        Me.grpNewMcode.Controls.Add(Me.Label2)
        Me.grpNewMcode.Controls.Add(Me.txtNmname)
        Me.grpNewMcode.Controls.Add(Me.Button1)
        Me.grpNewMcode.ForeColor = System.Drawing.Color.Maroon
        Me.grpNewMcode.Location = New System.Drawing.Point(81, 304)
        Me.grpNewMcode.Name = "grpNewMcode"
        Me.grpNewMcode.Size = New System.Drawing.Size(864, 160)
        Me.grpNewMcode.TabIndex = 366
        Me.grpNewMcode.TabStop = False
        Me.grpNewMcode.Text = "NEW MEMBER CODE [ TO MEMBER ]"
        Me.grpNewMcode.Visible = False
        '
        'cmdCro
        '
        Me.cmdCro.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(64, Byte))
        Me.cmdCro.ForeColor = System.Drawing.Color.White
        Me.cmdCro.Location = New System.Drawing.Point(320, 136)
        Me.cmdCro.Name = "cmdCro"
        Me.cmdCro.Size = New System.Drawing.Size(232, 24)
        Me.cmdCro.TabIndex = 368
        Me.cmdCro.Text = "<<  CRO RELEASE  >>"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.ForestGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(448, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Cancel[F10]"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.Location = New System.Drawing.Point(320, 93)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(104, 32)
        Me.cmdUpdate.TabIndex = 36
        Me.cmdUpdate.Text = "Update [F12]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(474, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "MEMBER NAME :"
        '
        'txtNmcode
        '
        Me.txtNmcode.BackColor = System.Drawing.Color.Wheat
        Me.txtNmcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNmcode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmcode.Location = New System.Drawing.Point(200, 32)
        Me.txtNmcode.MaxLength = 10
        Me.txtNmcode.Name = "txtNmcode"
        Me.txtNmcode.Size = New System.Drawing.Size(168, 29)
        Me.txtNmcode.TabIndex = 31
        Me.txtNmcode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(24, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "MEMBER CODE :"
        '
        'txtNmname
        '
        Me.txtNmname.BackColor = System.Drawing.Color.Wheat
        Me.txtNmname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNmname.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmname.Location = New System.Drawing.Point(648, 41)
        Me.txtNmname.MaxLength = 35
        Me.txtNmname.Name = "txtNmname"
        Me.txtNmname.ReadOnly = True
        Me.txtNmname.Size = New System.Drawing.Size(192, 29)
        Me.txtNmname.TabIndex = 32
        Me.txtNmname.Text = ""
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(360, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 29)
        Me.Button1.TabIndex = 34
        '
        'cmdMcodeUpd
        '
        Me.cmdMcodeUpd.BackColor = System.Drawing.Color.LightSeaGreen
        Me.cmdMcodeUpd.ForeColor = System.Drawing.Color.White
        Me.cmdMcodeUpd.Location = New System.Drawing.Point(376, 662)
        Me.cmdMcodeUpd.Name = "cmdMcodeUpd"
        Me.cmdMcodeUpd.Size = New System.Drawing.Size(440, 24)
        Me.cmdMcodeUpd.TabIndex = 367
        Me.cmdMcodeUpd.Text = "<<  Member Code Updation  >>"
        Me.cmdMcodeUpd.Visible = False
        '
        'grpPassword
        '
        Me.grpPassword.BackColor = System.Drawing.Color.LightPink
        Me.grpPassword.ForeColor = System.Drawing.Color.Black
        Me.grpPassword.Location = New System.Drawing.Point(320, 152)
        Me.grpPassword.Name = "grpPassword"
        Me.grpPassword.Size = New System.Drawing.Size(320, 144)
        Me.grpPassword.TabIndex = 40
        Me.grpPassword.TabStop = False
        Me.grpPassword.Text = "GroupBox3"
        '
        'grpPass
        '
        Me.grpPass.BackColor = System.Drawing.Color.Pink
        Me.grpPass.Controls.Add(Me.cmdOk)
        Me.grpPass.Controls.Add(Me.txtPass)
        Me.grpPass.Location = New System.Drawing.Point(373, 480)
        Me.grpPass.Name = "grpPass"
        Me.grpPass.Size = New System.Drawing.Size(280, 128)
        Me.grpPass.TabIndex = 368
        Me.grpPass.TabStop = False
        Me.grpPass.Text = "               ENTER PASSWORD"
        Me.grpPass.Visible = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOk.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.ForeColor = System.Drawing.Color.Black
        Me.cmdOk.Image = CType(resources.GetObject("cmdOk.Image"), System.Drawing.Image)
        Me.cmdOk.Location = New System.Drawing.Point(88, 80)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(104, 32)
        Me.cmdOk.TabIndex = 10
        Me.cmdOk.Text = "Add [F7]"
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(24, 40)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Microsoft.VisualBasic.ChrW(64)
        Me.txtPass.Size = New System.Drawing.Size(233, 22)
        Me.txtPass.TabIndex = 2
        Me.txtPass.Text = ""
        '
        'ssgridPayment
        '
        Me.ssgridPayment.ContainingControl = Me
        Me.ssgridPayment.DataSource = Nothing
        Me.ssgridPayment.Location = New System.Drawing.Point(80, 312)
        Me.ssgridPayment.Name = "ssgridPayment"
        Me.ssgridPayment.OcxState = CType(resources.GetObject("ssgridPayment.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgridPayment.Size = New System.Drawing.Size(840, 224)
        Me.ssgridPayment.TabIndex = 369
        '
        'SETLEMENT_GROUP
        '
        Me.SETLEMENT_GROUP.BackColor = System.Drawing.Color.Transparent
        Me.SETLEMENT_GROUP.Controls.Add(Me.CMD_SETTLEMENT)
        Me.SETLEMENT_GROUP.Controls.Add(Me.LAB_BALANCEAMT)
        Me.SETLEMENT_GROUP.Controls.Add(Me.Label4)
        Me.SETLEMENT_GROUP.Controls.Add(Me.ssgrid_settlement)
        Me.SETLEMENT_GROUP.Location = New System.Drawing.Point(24, 712)
        Me.SETLEMENT_GROUP.Name = "SETLEMENT_GROUP"
        Me.SETLEMENT_GROUP.Size = New System.Drawing.Size(856, 512)
        Me.SETLEMENT_GROUP.TabIndex = 370
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
        'DomainUpDown1
        '
        Me.DomainUpDown1.Location = New System.Drawing.Point(80, 296)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.TabIndex = 371
        Me.DomainUpDown1.Text = "DomainUpDown1"
        '
        'LAB_SPILTMEMBER
        '
        Me.LAB_SPILTMEMBER.AccessibleDescription = "2"
        Me.LAB_SPILTMEMBER.AutoSize = True
        Me.LAB_SPILTMEMBER.BackColor = System.Drawing.Color.Transparent
        Me.LAB_SPILTMEMBER.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_SPILTMEMBER.ForeColor = System.Drawing.Color.Brown
        Me.LAB_SPILTMEMBER.Location = New System.Drawing.Point(-216, 72)
        Me.LAB_SPILTMEMBER.Name = "LAB_SPILTMEMBER"
        Me.LAB_SPILTMEMBER.Size = New System.Drawing.Size(218, 25)
        Me.LAB_SPILTMEMBER.TabIndex = 373
        Me.LAB_SPILTMEMBER.Text = "SPLIT BILL MEMBER:"
        Me.LAB_SPILTMEMBER.Visible = False
        '
        'CMB_SPILTMEMBER
        '
        Me.CMB_SPILTMEMBER.BackColor = System.Drawing.Color.White
        Me.CMB_SPILTMEMBER.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_SPILTMEMBER.Location = New System.Drawing.Point(296, 104)
        Me.CMB_SPILTMEMBER.Name = "CMB_SPILTMEMBER"
        Me.CMB_SPILTMEMBER.Size = New System.Drawing.Size(88, 30)
        Me.CMB_SPILTMEMBER.TabIndex = 372
        Me.CMB_SPILTMEMBER.Visible = False
        '
        'CHKALL
        '
        Me.CHKALL.BackColor = System.Drawing.Color.Transparent
        Me.CHKALL.ForeColor = System.Drawing.Color.Black
        Me.CHKALL.Location = New System.Drawing.Point(296, 112)
        Me.CHKALL.Name = "CHKALL"
        Me.CHKALL.Size = New System.Drawing.Size(88, 16)
        Me.CHKALL.TabIndex = 374
        Me.CHKALL.Text = "ALL MEMBER"
        Me.CHKALL.Visible = False
        '
        'lab_outstanding
        '
        Me.lab_outstanding.AutoSize = True
        Me.lab_outstanding.BackColor = System.Drawing.Color.Transparent
        Me.lab_outstanding.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_outstanding.ForeColor = System.Drawing.Color.Blue
        Me.lab_outstanding.Location = New System.Drawing.Point(16, 544)
        Me.lab_outstanding.Name = "lab_outstanding"
        Me.lab_outstanding.Size = New System.Drawing.Size(0, 34)
        Me.lab_outstanding.TabIndex = 375
        Me.lab_outstanding.Visible = False
        '
        'Timer_Delay
        '
        '
        'Timer1
        '
        '
        'CHK_PRINT
        '
        Me.CHK_PRINT.BackColor = System.Drawing.Color.Transparent
        Me.CHK_PRINT.Checked = True
        Me.CHK_PRINT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK_PRINT.Location = New System.Drawing.Point(-64, 16)
        Me.CHK_PRINT.Name = "CHK_PRINT"
        Me.CHK_PRINT.Size = New System.Drawing.Size(64, 24)
        Me.CHK_PRINT.TabIndex = 617
        Me.CHK_PRINT.Text = "Print"
        Me.CHK_PRINT.Visible = False
        '
        'txt_card_id
        '
        Me.txt_card_id.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txt_card_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_card_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_card_id.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_card_id.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_card_id.Location = New System.Drawing.Point(272, 104)
        Me.txt_card_id.MaxLength = 25
        Me.txt_card_id.Name = "txt_card_id"
        Me.txt_card_id.PasswordChar = Microsoft.VisualBasic.ChrW(88)
        Me.txt_card_id.Size = New System.Drawing.Size(192, 34)
        Me.txt_card_id.TabIndex = 615
        Me.txt_card_id.Text = ""
        '
        'lbl_SwipeCard
        '
        Me.lbl_SwipeCard.BackColor = System.Drawing.Color.ForestGreen
        Me.lbl_SwipeCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_SwipeCard.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SwipeCard.ForeColor = System.Drawing.Color.White
        Me.lbl_SwipeCard.Image = CType(resources.GetObject("lbl_SwipeCard.Image"), System.Drawing.Image)
        Me.lbl_SwipeCard.Location = New System.Drawing.Point(-104, 64)
        Me.lbl_SwipeCard.Name = "lbl_SwipeCard"
        Me.lbl_SwipeCard.Size = New System.Drawing.Size(104, 32)
        Me.lbl_SwipeCard.TabIndex = 616
        Me.lbl_SwipeCard.Text = "SWIPE CARD"
        Me.lbl_SwipeCard.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(-112, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Microsoft.VisualBasic.ChrW(64)
        Me.TextBox1.Size = New System.Drawing.Size(109, 22)
        Me.TextBox1.TabIndex = 618
        Me.TextBox1.Text = ""
        Me.TextBox1.Visible = False
        '
        'txt_lastbillamount
        '
        Me.txt_lastbillamount.BackColor = System.Drawing.Color.White
        Me.txt_lastbillamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_lastbillamount.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lastbillamount.Location = New System.Drawing.Point(384, 704)
        Me.txt_lastbillamount.MaxLength = 50
        Me.txt_lastbillamount.Name = "txt_lastbillamount"
        Me.txt_lastbillamount.Size = New System.Drawing.Size(72, 39)
        Me.txt_lastbillamount.TabIndex = 621
        Me.txt_lastbillamount.Text = ""
        Me.txt_lastbillamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_lastbillamount.Visible = False
        '
        'txt_lostcardcode
        '
        Me.txt_lostcardcode.BackColor = System.Drawing.SystemColors.Info
        Me.txt_lostcardcode.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lostcardcode.Location = New System.Drawing.Point(712, 720)
        Me.txt_lostcardcode.Name = "txt_lostcardcode"
        Me.txt_lostcardcode.Size = New System.Drawing.Size(104, 21)
        Me.txt_lostcardcode.TabIndex = 620
        Me.txt_lostcardcode.Text = ""
        Me.txt_lostcardcode.Visible = False
        '
        'Cmd_DC_Update
        '
        Me.Cmd_DC_Update.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_DC_Update.Enabled = False
        Me.Cmd_DC_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_DC_Update.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_DC_Update.ForeColor = System.Drawing.Color.White
        Me.Cmd_DC_Update.Image = CType(resources.GetObject("Cmd_DC_Update.Image"), System.Drawing.Image)
        Me.Cmd_DC_Update.Location = New System.Drawing.Point(272, 712)
        Me.Cmd_DC_Update.Name = "Cmd_DC_Update"
        Me.Cmd_DC_Update.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_DC_Update.TabIndex = 619
        Me.Cmd_DC_Update.Text = "DC Update[F4]"
        Me.Cmd_DC_Update.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(120, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 25)
        Me.Label6.TabIndex = 622
        Me.Label6.Text = "FLASH CARD"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(752, 600)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 836
        Me.Cmd_Print.Text = "Print[F10]"
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.Location = New System.Drawing.Point(616, 600)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.cmd_View.TabIndex = 835
        Me.cmd_View.Text = " View[F9]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(888, 600)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 837
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(56, 600)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 838
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_Delete.Image = CType(resources.GetObject("cmd_Delete.Image"), System.Drawing.Image)
        Me.cmd_Delete.Location = New System.Drawing.Point(479, 600)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 834
        Me.cmd_Delete.Text = "Delete[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(196, 600)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 833
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'cmd_BillSettlement
        '
        Me.cmd_BillSettlement.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_BillSettlement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_BillSettlement.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_BillSettlement.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_BillSettlement.Image = CType(resources.GetObject("cmd_BillSettlement.Image"), System.Drawing.Image)
        Me.cmd_BillSettlement.Location = New System.Drawing.Point(337, 600)
        Me.cmd_BillSettlement.Name = "cmd_BillSettlement"
        Me.cmd_BillSettlement.Size = New System.Drawing.Size(104, 32)
        Me.cmd_BillSettlement.TabIndex = 839
        Me.cmd_BillSettlement.Text = "Bill Settle [F5]"
        '
        'LAB_CARDBAL
        '
        Me.LAB_CARDBAL.AutoSize = True
        Me.LAB_CARDBAL.BackColor = System.Drawing.Color.Lime
        Me.LAB_CARDBAL.Font = New System.Drawing.Font("Courier New", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_CARDBAL.ForeColor = System.Drawing.Color.Blue
        Me.LAB_CARDBAL.Location = New System.Drawing.Point(144, 72)
        Me.LAB_CARDBAL.Name = "LAB_CARDBAL"
        Me.LAB_CARDBAL.Size = New System.Drawing.Size(0, 27)
        Me.LAB_CARDBAL.TabIndex = 840
        '
        'KOT_Billing
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 732)
        Me.ControlBox = False
        Me.Controls.Add(Me.LAB_CARDBAL)
        Me.Controls.Add(Me.cmd_BillSettlement)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.cmd_View)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_SwipeCard)
        Me.Controls.Add(Me.txt_lastbillamount)
        Me.Controls.Add(Me.txt_lostcardcode)
        Me.Controls.Add(Me.txt_card_id)
        Me.Controls.Add(Me.txt_KOTTime)
        Me.Controls.Add(Me.txt_BillAmount)
        Me.Controls.Add(Me.txt_ServerCode)
        Me.Controls.Add(Me.txt_ServerName)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.txt_MemberName)
        Me.Controls.Add(Me.Txt_Remarks)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LAB_SPILTMEMBER)
        Me.Controls.Add(Me.CHK_PRINT)
        Me.Controls.Add(Me.lbl_BillAmount)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_MemberName)
        Me.Controls.Add(Me.lbl_ServerCode)
        Me.Controls.Add(Me.lbl_ServerName)
        Me.Controls.Add(Me.lbl_MemberCode)
        Me.Controls.Add(Me.lbl_PaymentMode)
        Me.Controls.Add(Me.lbl_BillNo)
        Me.Controls.Add(Me.lbl_BillDate)
        Me.Controls.Add(Me.lbl_SubPaymentMode)
        Me.Controls.Add(Me.lbl_Remarks)
        Me.Controls.Add(Me.Cmd_DC_Update)
        Me.Controls.Add(Me.lab_outstanding)
        Me.Controls.Add(Me.CHKALL)
        Me.Controls.Add(Me.SETLEMENT_GROUP)
        Me.Controls.Add(Me.CMB_SPILTMEMBER)
        Me.Controls.Add(Me.ssGrid)
        Me.Controls.Add(Me.cmdMcodeUpd)
        Me.Controls.Add(Me.lblCro2)
        Me.Controls.Add(Me.lblCro1)
        Me.Controls.Add(Me.lblDeleted)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_Bill)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Lbl_OtherBill)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.dtp_BillDate)
        Me.Controls.Add(Me.FraGrid)
        Me.Controls.Add(Me.Cmd_ServerCodeHelp)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.cbo_PaymentMode)
        Me.Controls.Add(Me.cmd_BillNoHelp)
        Me.Controls.Add(Me.GrpBill)
        Me.Controls.Add(Me.cbo_SubPaymentMode)
        Me.Controls.Add(Me.grpNewMcode)
        Me.Controls.Add(Me.grp_Paymentmodeselection)
        Me.Controls.Add(Me.grpPass)
        Me.Controls.Add(Me.GraMem)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "KOT_Billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FINAL BILLING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ssGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GraMem.ResumeLayout(False)
        Me.GrpBill.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.grp_Paymentmodeselection.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grp_Chequedetails.ResumeLayout(False)
        Me.grp_Carddetails.ResumeLayout(False)
        Me.grpNewMcode.ResumeLayout(False)
        Me.grpPass.ResumeLayout(False)
        CType(Me.ssgridPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SETLEMENT_GROUP.ResumeLayout(False)
        CType(Me.ssgrid_settlement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim Amt, AMT1, MemberOutstand, RNDOFF As Double
    Dim i, J, K As Integer
    Dim dd, serverdate As DateTime
    Dim PHOTOFILENAME As String
    Public Billno() As String
    Dim strAccountIn, strSaleCostAccountIn, strSaleCostAccountInDesc, strBatchNo, strAccountDesc, STMcode As String
    Dim txt_creditfacility, SEC, roomchkno As String
    Dim BillDetails, CHKINNO As String
    Dim gconnection As New GlobalClass
    Dim DT As New DataSet
    Dim posstring As String
    Dim itembool, chkbool, smartcardbool As Boolean
    Dim KotDetails, BillMcode, BillMname, loccode, ssql, seccode, HNAME() As String
    Public dblBillTotalAmount, dblBillNonTotalAmount, dblBillTaxTotal, dblBillNonTaxtotal, gridRow, Jnltaxamount, Jnlamount, _Billamount As Double
    Public billstatus, BillTaxBillno, BillTaxBilldetails, BillNonTaxBilldetails, BillNonTaxBillno As String
    Dim duplicateflag As Boolean = False
    '----SMART CARD
    Dim strPhotoFilePath As String
    Public foto As New GlobalClass
    Public BALANCE_HDR, _BILLAMT As Double
    Public MIN_USAGE_BALANCE_HDR As Double
    Dim count As Integer = 1
    Dim GADDDATETIME As Date

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
    Private Sub Cmd_Clear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub Cmd_Exit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    'Private Sub KOTTYPE()
    '    Try
    '        Dim LOC, strstring As String
    '        Dim I As Integer
    '        CMB_BTYPE.Items.Clear()
    '        If gUserCategory = "S" Then
    '            strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y' "
    '        Else
    '            If gPosUserControl = "Y" Then
    '                strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y' AND POSCODE IN (SELECT POSCODE FROM POS_USERCONTROL WHERE USERNAME='" & Trim(gUsername) & "')"
    '            Else
    '                strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y' "
    '            End If
    '        End If
    '        gconnection.getDataSet(strstring, "LOCmaster")
    '        If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
    '            For I = 0 To gdataset.Tables("LOCmaster").Rows.Count - 1
    '                CMB_BTYPE.Items.Add(gdataset.Tables("LOCmaster").Rows(I).Item("DOCTYPE"))
    '                posstring = posstring & "'" & gdataset.Tables("LOCmaster").Rows(I).Item("POSCODE") & "', "
    '            Next
    '            posstring = Mid(posstring, 1, Len(posstring) - 2)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Private Function KOTTYPE() As Boolean
        Try
            Dim LOC, strstring As String
            Dim I As Integer
            CMB_BTYPE.Items.Clear()
            posstring = ""
            If gUserCategory = "S" Then
                strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y' "
            Else
                If gPosUserControl = "Y" Then
                    strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y' AND POSCODE IN (SELECT POSCODE FROM POS_USERCONTROL WHERE USERNAME='" & Trim(gUsername) & "')"
                Else
                    strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y' "
                End If
            End If
            gconnection.getDataSet(strstring, "LOCmaster")
            If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
                StrPOSCODE = gdataset.Tables("LOCmaster").Rows(0).Item("POSCODE")
                For I = 0 To gdataset.Tables("LOCmaster").Rows.Count - 1
                    CMB_BTYPE.Items.Add(gdataset.Tables("LOCmaster").Rows(I).Item("DOCTYPE"))
                    posstring = posstring & "'" & gdataset.Tables("LOCmaster").Rows(I).Item("POSCODE") & "', "
                Next
                posstring = Mid(posstring, 1, Len(posstring) - 2)
                'CMB_BTYPE.SelectedIndex = 0
                KOTTYPE = True
            Else
                posstring = ""
                MsgBox("U R Not Allowed to Use this Option... Please contact Administrator...", MsgBoxStyle.Information, "Info")
                KOTTYPE = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Function DLLCONNECT() As Boolean
        Try
            G_rHandle = ACR120U.ACR120_Open(ACR120U.PORTS.ACR120_USB1)
            If G_rHandle < 0 Then
                G_retcode = ACR120U.ACR120_Close(G_rHandle)
                Return False
                Exit Function
            End If
            Return True
        Catch ex As Exception
            Return False
            Exit Function
        End Try
    End Function
    Private Function DLLCLOSE() As Boolean
        Try
            G_retcode = ACR120U.ACR120_Close(G_rHandle)
            If G_retcode < 0 Then
                '  MsgBox("PROBLEM IN SMART CARD DEVICE CONNECTION", MsgBoxStyle.Critical, "NOT CLOSE")
                Return False
                Exit Function
            End If

            Return True
            Exit Function

        Catch ex As Exception
            'MessageBox.Show(Err.Description, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
            Exit Function
        End Try
    End Function
    Private Sub KOT_Billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_SubPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        LAB_CARDBAL.Text = ""
        Timer1.Enabled = True
        vCardcode = ""
        Call KOTTYPE()
        Call PaymentGridLocking()
        Call FillBillPrefix()
        Call GridUnLocking()
        Call autogenerate()
        Call ShowBillno()
        Call SYS_DATE_TIME()
        finalbillbool = True
        CMB_BTYPE.SelectedIndex = 0
        kotupdate = False
        itembool = False
        KotDetails = ""
        cmd_BillSettlement.Enabled = False
        cbo_Typeofcheque.SelectedIndex = 0
        KOT_Timer.Enabled = True
        KOT_Timer.Interval = 100
        txt_BillAmount.ReadOnly = True
        cmd_BillNoHelp.Enabled = True
        grp_Paymentmodeselection.Top = 1000
        ssGrid.ClearRange(1, 1, -1, -1, True)
        ssGrid.BackColor = Color.White
        ssGrid.ForeColor = Color.Black
        cbo_PaymentMode.Focus()
        'Modified on 18 Mar'08
        'Mk Kannan
        'Begin
        lblDeleted.Visible = False
        'End
        'dtp_BillDate.Value = serverdate
        Call SetDateTime()
        If gUserCategory <> "S" Then
            Call GetRights()
            'If Trim(cbo_PaymentMode.Text) = "CASH" Then
            'Cmd_Add.Enabled = False
            'Cmd_Delete.Enabled = False
            'CMD_SETTLEMENT.Enabled = False
            'End If
        End If
        Cmd_Clear_Click(Cmd_Clear, e)
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
    Private Sub KOT_Billing_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call cmd_BillSettlement_Click(cmd_BillSettlement, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            txt_BillNo.Text = ""
            txt_BillNo.Focus()
            'ElseIf e.KeyCode = Keys.F7 Then
            '    If Cmd_Add.Enabled = True Then
            '        Call Cmd_Add_Click(sender, e)
            '        Exit Sub
            '    End If

            'ElseIf e.KeyCode = Keys.F8 Then
            '    Call Cmd_Delete_Click(sender, e)
            '    Exit Sub

            'ElseIf e.KeyCode = Keys.F9 Then
            '    Call Cmd_View_Click(sender, e)
            '    Exit Sub

            'ElseIf e.KeyCode = Keys.F10 Then
            '    Call Cmd_Print_Click(sender, e)
            '    Exit Sub


        ElseIf e.KeyCode = Keys.F8 Then
            If Cmd_Delete.Enabled = True Then
                Call Cmd_Delete_Click(Cmd_Delete, e)
                Exit Sub
            End If

        ElseIf e.KeyCode = Keys.F7 Then
            If Cmd_Add.Enabled = True Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If Cmd_View.Enabled = True Then
                Call Cmd_View_Click(Cmd_View, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F12 Then
            ''If cbo_PaymentMode.SelectedItem <> "ROOM" Then
            'If SMENTTYPE = "YES" Then
            '    If ssGrid.DataRowCnt > 0 Then
            '        SETLEMENT_GROUP.Visible = True
            '        SpiltBill()
            '        SETLEMENT_GROUP.Top = 40
            '        SETLEMENT_GROUP.Left = 85
            '        ssgrid_settlement.SetActiveCell(1, 1)
            '        ssgrid_settlement.Focus()
            '    End If
            'End If
            'End If
        ElseIf e.KeyCode = Keys.F10 Then
            If Cmd_Print.Enabled = True Then
                Call Cmd_Print_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            If grp_Carddetails.Top = 24 Then
                grp_Carddetails.Top = 1000
                ssgridPayment.SetActiveCell(3, gridRow)
                ssgridPayment.Focus()
            ElseIf grp_Chequedetails.Top = 24 Then
                grp_Chequedetails.Top = 1000
                ssgridPayment.SetActiveCell(3, gridRow)
                ssgridPayment.Focus()
            ElseIf grp_Paymentmodeselection.Top = 296 Then
                grp_Paymentmodeselection.Top = 1000
            Else
                Call Cmd_Exit_Click(sender, e)
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
        ElseIf e.Alt = True And e.KeyCode = Keys.C Then
            Me.txt_card_id.Focus()
            Exit Sub

        ElseIf e.Alt = True And e.KeyCode = Keys.P Then
            Me.cbo_PaymentMode.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.G Then
            Me.ssGrid.Focus()
            Me.ssGrid.SetActiveCell(1, 1)
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.D Then
            Me.dtp_BillDate.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub fillPayment_Mode()
        Dim sqlstring As String
        Dim index As Integer
        Dim i As Integer
        Try
            If Mid(Trim(Cmd_Add.Text), 1, 1) = "A" Then
                Call FillDefaultPayment()
                'Modified on 18 Mar'08
                'Mk Kannan
                'Begin
                'sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Paymentcode NOT IN ('CLUB')AND Isnull(Freeze,'N')='N'"
                '                sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'N')='N'"

                cbo_PaymentMode.Items.Clear()
                If gUserCategory = "S" Then
                    sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'')<>'Y'"
                Else
                    If gPosUserControl = "Y" Then
                        'sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'')<>'Y' AND PAYMENTCODE IN (SELECT PAYMENTCODE FROM POS_PAYMENTCONTROL WHERE POSCODE IN(" & Trim(posstring) & "))"
                        sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'')<>'Y' AND PAYMENTCODE IN (SELECT PAYMENTCODE FROM POS_PAYMENTCONTROL WHERE POSCODE IN (SELECT POSCODE FROM POSDOCUMENT WHERE DOCTYPE='" & Trim(CMB_BTYPE.Text) & "'))"
                    Else
                        sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'')<>'Y'"
                    End If
                End If

                gconnection.getDataSet(sqlstring, "paymentmodemaster")
                If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("paymentmodemaster").Rows.Count - 1
                        cbo_PaymentMode.Items.Add(gdataset.Tables("paymentmodemaster").Rows(i).Item("Paymentcode"))
                    Next i
                    index = cbo_PaymentMode.FindString(DefaultPayment)
                    cbo_PaymentMode.SelectedIndex = index
                    Call FillSubPaymentMode(DefaultPayment)
                Else
                    MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            Else
                Call FillDefaultPayment()
                'sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'N')='N'"

                If gUserCategory = "S" Then
                    sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'')<>'Y'"
                Else
                    If gPosUserControl = "Y" Then
                        sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'')<>'Y' AND PAYMENTCODE IN (SELECT PAYMENTCODE FROM POS_PAYMENTCONTROL WHERE POSCODE IN(" & Trim(posstring) & "))"
                    Else
                        sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'')<>'Y'"
                    End If
                End If
                'End


                cbo_PaymentMode.Items.Clear()
                gconnection.getDataSet(sqlstring, "paymentmodemaster")
                If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("paymentmodemaster").Rows.Count - 1
                        cbo_PaymentMode.Items.Add(gdataset.Tables("paymentmodemaster").Rows(i).Item("Paymentcode"))
                    Next i
                    index = cbo_PaymentMode.FindString(DefaultPayment)
                    cbo_PaymentMode.SelectedIndex = index
                    Call FillSubPaymentMode(DefaultPayment)
                Else
                    MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
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
                    txt_BillNo.Text = Trim(BillPrefix) & "/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_BillNo.Text = Trim(BillPrefix) & "/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_BillNo.Text = Trim(BillPrefix) & "/000001/" & financalyear
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
    'Begin     Change on 28.05.08
    '============================
    Private Sub autogenerate_add()
        Dim sqlstring, financalyear, sqlstring_upd As String
        Try
            'BEGIN:
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            sqlstring = "SELECT Isnull(DocNo,0),DOCFLAG FROM PoSKotDoc with(rowlock,holdlock) Where DocType = '" & Trim(BillPrefix) & "'"
            gconnection.getDataSet(sqlstring, "POSKOTDOC")

            'If gdataset.Tables("poskotdoc").Rows.Count > 0 Then
            'If gdataset.Tables("POSKOTDOC").Rows(0).Item("DOCFLAG") = "N" Then
            'sqlstring_upd = "UPDATE POSKOTDOC SET DOCFLAG='Y' WHERE DOCFLAG='N' and doctype='CSC'"
            'gconnection.dataOperation(7, sqlstring_upd)
            'Else
            'GoTo BEGIN
            'End If
            'Else
            'GoTo BEGIN
            'End If
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_BillNo.Text = Trim(BillPrefix) & "/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_BillNo.Text = Trim(BillPrefix) & "/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If

            Else
                txt_BillNo.Text = Trim(BillPrefix) & "/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
                'GoTo BEGIN
            End If
        Catch ex As Exception
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub
    'end ======================================
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperattion1
        If cbo_PaymentMode.SelectedItem = "ROOM" Then
            gSQLString = "SELECT roomno,guest,docno FROM roomcheckin "
            M_WhereCondition = "WHERE ISNULL(checkout,'') <> 'Y' AND roomstatus='occupied'"
            'M_WhereCondition = ""
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
                If txt_ServerCode.Text <> "" Then
                    ssGrid.SetActiveCell(1, 1)
                    ssGrid.Focus()
                Else
                    txt_ServerCode.Focus()
                End If
                'txt_ServerCode.Focus()
            End If
            vform.Close()
            vform = Nothing
        Else
            gSQLString = "SELECT mcode,mname FROM Membermaster"
            M_WhereCondition = " Where CURENTSTATUS='LIVE' "
            vform.Field = " MCODE,MNAME "
            vform.vFormatstring = "                 MEMBER CODE            |                 MEMBER NAME                                "
            vform.vCaption = "MEMBER MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_MemberCode.Text = Trim(vform.keyfield & "")
                txt_MemberName.Text = Trim(vform.keyfield1 & "")
                If txt_ServerCode.Text <> "" Then
                    ssGrid.SetActiveCell(1, 1)
                    ssGrid.Focus()
                Else
                    txt_ServerCode.Focus()
                End If
                'txt_ServerCode.Focus()
            End If
            vform.Close()
            vform = Nothing
        End If
    End Sub
    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Dim strstring As String
        Try
            If Trim(txt_MemberCode.Text) <> "" Then
                strstring = " SELECT * FROM SM_CARDFILE_HDR WHERE MEMBERCODE='" & txt_MemberCode.Text & "' AND CAST(CONVERT(CHAR(11),VALID_TO,106) AS DATETIME)>='" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "'"
                gconnection.getDataSet(strstring, "CHK")
                If gdataset.Tables("CHK").Rows.Count <= 0 Then
                    'MessageBox.Show("Member Card Having,Please Flash the Card", "CARD STATUS", "you can not entry", "CARD STATUS")
                    MessageBox.Show("PLEASE!FLASH YOUR CARD", "CARD NOT FLASH", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'txt_MemberCode.Text = ""
                    'txt_MemberCode.Focus()
                    'Exit Sub
                End If

                If cbo_PaymentMode.Text = "ROOM" Then
                    strstring = "SELECT roomno,guest,docno FROM roomcheckin WHERE isnull(checkout,'') <> 'Y' and roomstatus='occupied' AND RoomNo='" & Trim(txt_MemberCode.Text) & "'"
                    'strstring = "SELECT roomno,guest,docno FROM roomcheckin WHERE RoomNo='" & Trim(txt_MemberCode.Text) & "'"
                    gconnection.getDataSet(strstring, "RoomCheckin")
                    If gdataset.Tables("RoomCheckin").Rows.Count > 0 Then
                        txt_MemberCode.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("RoomNo")
                        txt_MemberName.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("Guest")
                        txt_MemberCode.Tag = gdataset.Tables("RoomCheckin").Rows(0).Item("docno")
                        If txt_ServerCode.Text <> "" Then
                            ssGrid.Focus()
                            ssGrid.SetActiveCell(1, 1)
                        Else
                            txt_ServerCode.Focus()
                        End If
                    Else
                        txt_MemberCode.Text = ""
                        txt_MemberCode.Focus()
                    End If
                Else
                    'PHOTOFILENAME = STRPHOTOPATH & "\" & Mid(Trim(txt_MemberCode.Text), 1, Len(Trim(txt_MemberCode.Text))) & ".jpg"
                    'PHOTOFILENAME = Replace(PHOTOFILENAME, " ", "")
                    'If File.Exists(PHOTOFILENAME) Then
                    '    Pic_Member.Image = New Bitmap(PHOTOFILENAME)
                    'Else
                    '    Pic_Member.Image = Nothing
                    'End If
                    strstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CRIDITNUMBER,'') AS CRIDITNUMBER FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' AND CURENTSTATUS='LIVE' "
                    gconnection.getDataSet(strstring, "membermaster")
                    If gdataset.Tables("membermaster").Rows.Count > 0 Then
                        txt_MemberCode.Text = gdataset.Tables("membermaster").Rows(0).Item("MCODE")
                        txt_MemberName.Text = gdataset.Tables("membermaster").Rows(0).Item("MNAME")
                        txt_creditfacility = gdataset.Tables("membermaster").Rows(0).Item("CRIDITNUMBER")
                        If txt_ServerCode.Text <> "" Then
                            ssGrid.SetActiveCell(1, 1)
                            ssGrid.Focus()
                        Else
                            txt_ServerCode.Focus()
                        End If

                        'txt_ServerCode.Focus()
                    Else
                        txt_MemberCode.Text = ""
                        txt_MemberCode.Focus()
                    End If
                    'Call outstanding()
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
                If Me.Cmd_Add.Text = "Add [F7]" Then
                    Call FillKOTdetails() '''*********************** Fill all KOT'S in that grid ***************
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Entry Plz try once again", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_MemberCode.Focus()
            Exit Sub
        End Try
    End Sub
    Private Sub txt_NEW_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Dim strstring As String
        Try
            If Trim(txt_MemberCode.Text) <> "" Then
                If cbo_PaymentMode.Text = "ROOM" Then
                    strstring = "SELECT roomno,guest,docno FROM roomcheckin WHERE isnull(checkout,'') <> 'Y' and roomstatus='occupied' AND RoomNo='" & Trim(txt_MemberCode.Text) & "'"
                    gconnection.getDataSet(strstring, "RoomCheckin")
                    If gdataset.Tables("RoomCheckin").Rows.Count > 0 Then
                        txt_MemberCode.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("RoomNo")
                        txt_MemberName.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("Guest")
                        txt_MemberCode.Tag = gdataset.Tables("RoomCheckin").Rows(0).Item("docno")
                        roomchkno = gdataset.Tables("RoomCheckin").Rows(0).Item("docno")
                        If txt_ServerCode.Text <> "" Then
                            ssGrid.SetActiveCell(1, 1)
                            ssGrid.Focus()
                        Else
                            txt_ServerCode.Focus()
                        End If
                    Else
                        txt_MemberCode.Text = ""
                        txt_MemberCode.Focus()
                    End If
                Else
                    'PHOTOFILENAME = STRPHOTOPATH & "\" & Mid(Trim(txt_MemberCode.Text), 1, Len(Trim(txt_MemberCode.Text))) & ".jpg"
                    'PHOTOFILENAME = Replace(PHOTOFILENAME, " ", "")
                    'If File.Exists(PHOTOFILENAME) Then
                    '    Pic_Member.Image = New Bitmap(PHOTOFILENAME)
                    'Else
                    '    Pic_Member.Image = Nothing
                    'End If
                    strstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CRIDITNUMBER,'') AS CRIDITNUMBER FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                    gconnection.getDataSet(strstring, "membermaster")
                    If gdataset.Tables("membermaster").Rows.Count > 0 Then
                        txt_MemberCode.Text = gdataset.Tables("membermaster").Rows(0).Item("MCODE")
                        txt_MemberName.Text = gdataset.Tables("membermaster").Rows(0).Item("MNAME")
                        txt_creditfacility = gdataset.Tables("membermaster").Rows(0).Item("CRIDITNUMBER")
                        If txt_ServerCode.Text <> "" Then
                            ssGrid.SetActiveCell(1, 1)
                            ssGrid.Focus()
                        Else
                            txt_ServerCode.Focus()
                        End If
                        'txt_ServerCode.Focus()
                    Else
                        txt_MemberCode.Text = ""
                        lab_outstanding.Text = ""
                        txt_MemberCode.Focus()
                    End If
                    '' Call outstanding()
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
                        Cmd_Clear_Click(sender, e)
                        Exit Sub
                    End If

                End If
                If Me.Cmd_Add.Text = "Add [F7]" Then
                    Call FillKOTdetails() '''*********************** Fill all KOT'S in that grid ***************
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Entry Plz try once again", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_MemberCode.Focus()
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_ServerCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ServerCodeHelp.Click
        'Dim vform As New ListOperattion1
        'gSQLString = "SELECT Servercode, Servername FROM servermaster"
        'M_WhereCondition = " WHERE FREEZE='N'"
        'vform.Field = " SERVERCODE, SERVERNAME "
        'vform.vFormatstring = "         SERVER CODE            |                       SERVERNAME                               "
        'vform.vCaption = "SERVER MASTER HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        'vform.ShowDialog(Me)
        'If Trim(vform.keyfield & "") <> "" Then
        '    txt_ServerCode.Text = Trim(vform.keyfield & "")
        '    txt_ServerName.Text = Trim(vform.keyfield1 & "")
        '    ssGrid.Focus()
        '    txt_ServerCode_Validated(sender, e)
        '    ssGrid.SetActiveCell(1, 1)
        'End If
        'vform.Close()
        'vform = Nothing

        Dim vform As New ListOperattion1
        gSQLString = "SELECT POSCODE,POSDESC FROM POSMASTER "
        M_WhereCondition = " WHERE ISNULL(FREEZE,'') <>'Y'"
        vform.Field = " POSCODE, POSDESC"
        vform.vFormatstring = "         LOCATION CODE            |                       LOCATIONNAME                               "
        vform.vCaption = "LOCATION MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_ServerCode.Text = Trim(vform.keyfield & "")
            txt_ServerName.Text = Trim(vform.keyfield1 & "")
            ssGrid.Focus()
            txt_ServerCode_Validated(sender, e)
            ssGrid.SetActiveCell(1, 1)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_ServerCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ServerCode.Validated
        'Dim strstring As String
        'Try
        '    If Trim(txt_ServerCode.Text) <> "" Then
        '        strstring = "SELECT * FROM servermaster WHERE ServerCode='" & Trim(txt_ServerCode.Text) & "'AND Freeze='N'"
        '        gconnection.getDataSet(strstring, "servermaster")
        '        If gdataset.Tables("servermaster").Rows.Count > 0 Then
        '            txt_ServerCode.Text = gdataset.Tables("servermaster").Rows(0).Item("ServerCode")
        '            txt_ServerName.Text = gdataset.Tables("servermaster").Rows(0).Item("ServerName")
        '            txt_ServerCode.ReadOnly = True
        '            'If Me.Cmd_Add.Text = "Add [F7]" Then
        '            Call FillKOTdetails() '''*********************** Fill all KOT'S in that grid ***************
        '            'End If
        '            ssGrid.Focus()
        '        Else
        '            If Mid(Cmd_Add.Text, 1, 1) = "A" Then
        '                txt_ServerCode.Text = ""
        '                txt_ServerCode.Focus()
        '            Else
        '                ssGrid.Focus()
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
        Try
            Dim strstring As String
            Dim I As Integer
            If Trim(txt_ServerCode.Text) <> "" Then
                '    If Trim(txt_ServerCode.Text) <> "" Then
                strstring = "SELECT isnull(poscode,'') as poscode,isnull(posdesc,'') as posname FROM POSMASTER WHERE POSCODE='" & Trim(txt_ServerCode.Text) & "'AND ISNULL(Freeze,'')<>'Y'"
                gconnection.getDataSet(strstring, "LOCmaster")
                If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
                    txt_ServerCode.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
                    txt_ServerName.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosName")
                    '            'If Me.Cmd_Add.Text = "Add [F7]" Then
                    '            '    Call FillKOTdetails() '''*********************** Fill all KOT'S in that grid ***************
                    '            'End If
                    '            ssGrid.Focus()
                    '        Else
                    '            If Mid(Cmd_Add.Text, 1, 1) = "A" Then
                    '                txt_ServerCode.Text = ""
                    '                txt_ServerCode.Focus()
                    '            Else
                    '                ssGrid.Focus()
                    '            End If
                    '        End If
                    '    Else
                    '        txt_ServerCode.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_PaymentMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_PaymentMode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'Modified on 18 Mar'08
            'Mk Kannan
            'Begin
            If cbo_SubPaymentMode.Visible = True Then
                cbo_SubPaymentMode.Focus()
            ElseIf txt_MemberCode.Visible = True Then
                txt_MemberCode.Focus()
            Else
                txt_ServerCode.Focus()
            End If
            'If cbo_PaymentMode.Text = "R.MEMBER" Or cbo_PaymentMode.Text = "CLUB" And cbo_SubPaymentMode.Visible = False Then
            '    txt_ServerCode.Focus()
            'ElseIf cbo_SubPaymentMode.Visible = True Then
            '    cbo_SubPaymentMode.Focus()
            'Else
            '    txt_MemberCode.Focus()
            'End If
            'End
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
                '                If Me.Cmd_Add.Text = "Add [F7]" Then
                Call FillKOTdetails() '''*********************** Fill all KOT'S in that grid ***************
                '            End If
                ssGrid.Focus()
            Else
                Call Cmd_ServerCodeHelp_Click(Cmd_ServerCodeHelp, e)
            End If
        End If
    End Sub

    Private Sub txt_ServerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ServerName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ssGrid.Focus()
            ssGrid.SetActiveCell(1, 1)
        End If
    End Sub
    Private Sub checkvalidate()
        Try
            Dim sqlstring, SQL, KOTno, KOTdate As String
            Dim i As Integer
            chkbool = False
            Call bill_roundoff()
            Call SetDateTime()
            If Cmd_Add.Text = "Add [F7]" Then
                Call autogenerate()
                If (Trim(txt_card_id.Text) = "") Then
                    MessageBox.Show(" PLEASE SWIPE THE CARD ", "SMART CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_card_id.Focus()
                    chkbool = False
                    Exit Sub
                End If
            End If

            '''**************************************** Check Payment Mode can't be blank *******************************************''


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
                Exit Sub
            End If
            If SMENTTYPE = "YES" Then
                If cbo_PaymentMode.SelectedItem <> "ROOM" Then
                    If SETLEMENT_GROUP.Visible = True Then
                        MessageBox.Show("Please Close the Settlement Screen.", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ssgrid_settlement.Focus()
                        Exit Sub
                    End If
                End If
            End If
            If Trim(cbo_PaymentMode.Text) = "" Then
                MessageBox.Show("Payment Mode Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                cbo_PaymentMode.Focus()
                Exit Sub
            End If
            If Me.cbo_SubPaymentMode.Visible = True Then
                If Trim(cbo_SubPaymentMode.Text) = "" Then
                    MessageBox.Show("Sub Payment Mode Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    cbo_PaymentMode.Focus()
                    Exit Sub
                End If
            End If
            '''**************************************** Check Room No and Member Code can't be blank *******************************************''
            '    sqlstring = " SELECT * FROM BILL_HDR WHERE BILLDETAILS='" & txt_BillNo.Text & "'"
            '    gconnection.getDataSet(sqlstring, "KOTSTATUS")
            '    If gdataset.Tables("KOTSTATUS").Rows.Count > 0 Then
            '        MessageBox.Show("THIS BILLNO ALREADY ENTERED,KINDLY CONFORM YOUR SYSTEM INCHARGE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '        Exit Sub
            '    End If
            'End If

            'sqlstring = "select * from BILL_HDR where BILLdetails='" & txt_BillNo.Text & "'"
            'gconnection.getDataSet(sqlstring, "BILLNO")
            'If gdataset.Tables("BILLNO").Rows.Count > 0 Then
            '    sqlstring = "SELECT MAX(BILLNO)  AS BNO FROM BILL_HDR WHERE SUBSTRING(BILLDETAILS,1,3)='SVS' "
            '    gconnection.getDataSet(sqlstring, "BNO")
            '    If gdataset.Tables("BNO").Rows.Count > 0 Then
            '        sqlstring = "Update PoSKotDoc Set DocNo = " & gdataset.Tables("BNO").Rows(0).Item("BNO") & " WHERE DOCFLAG='N' And DocType = 'SVS'"
            '        gconnection.dataOperation(9, sqlstring, "upd")
            '        Call autogenerate()
            '    End If
            'End If

            sqlstring = "SELECT * FROM BILL_HDR WHERE BILLDETAILS = '" & Trim(txt_BillNo.Text) & "' AND ISNULL(crostatus,'N')='Y' "
            gconnection.getDataSet(sqlstring, "CRO")
            If gdataset.Tables("CRO").Rows.Count > 0 Then
                MsgBox("Sorry, Settlement Was Already Made, You Can't Delete/Update....")
                Exit Sub
            End If



            sqlstring = "SELECT * FROM MATCHING WHERE VOUCHERNO = '" & Trim(txt_BillNo.Text) & "' AND VOUCHERDATE = '" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "'"
            gconnection.getDataSet(sqlstring, "MATCHING")
            If gdataset.Tables("MATCHING").Rows.Count > 0 Then
                MsgBox("Sorry, Bill Matching Was Already Made, You Can't Delete/Update....")
                'Call Cmd_Clear_Click(Cmd_Clear, e)
                Exit Sub
            End If

            If Trim(txt_MemberCode.Text) = "" Then
                If cbo_PaymentMode.Text = "CREDIT" And Len(Trim(txt_creditfacility)) = 0 Then
                    'MessageBox.Show("This member is Not entitled for Credit facility", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    'txt_MemberCode.Focus()
                    'Exit Sub
                    'ElseIf cbo_PaymentMode.Text = "N.CREDIT" And Len(Trim(txt_creditfacility)) > 0 Then
                    '    MessageBox.Show("This member has the credit Facility. Kindly change the mode of payment", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    '    txt_MemberCode.Focus()
                    '    Exit Sub
                ElseIf cbo_PaymentMode.Text = "ROOM" Then
                    MessageBox.Show("Room No Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    txt_MemberCode.Focus()
                    Exit Sub
                ElseIf cbo_PaymentMode.Text = "R.MEMBER" Then
                    cbo_PaymentMode.Text = "R.MEMBER"
                ElseIf cbo_PaymentMode.Text = "COUPON" Then
                    cbo_PaymentMode.Text = "COUPON"
                ElseIf cbo_PaymentMode.Text = "CLUB" Then
                    cbo_PaymentMode.Text = "CLUB"
                Else
                    MessageBox.Show("Member Code Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    txt_MemberCode.Focus()
                    Exit Sub
                End If
            End If
            '''**************************************** Check Guest Name and Member Name can't be blank *******************************************''
            If Trim(txt_MemberName.Text) = "" Then
                If cbo_PaymentMode.Text = "ROOM" Then
                    MessageBox.Show("Guest Name Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    txt_MemberName.Focus()
                    Exit Sub
                ElseIf cbo_PaymentMode.Text = "R.MEMBER" Then
                    cbo_PaymentMode.Text = "R.MEMBER"
                ElseIf cbo_PaymentMode.Text = "COUPON" Then
                    cbo_PaymentMode.Text = "COUPON"
                ElseIf cbo_PaymentMode.Text = "CLUB" Then
                    cbo_PaymentMode.Text = "CLUB"
                Else
                    MessageBox.Show("Member Name Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    txt_MemberName.Focus()
                    Exit Sub
                End If
            End If
            '''**************************************** Check Server Code can't be blank *******************************************''
            If Trim(txt_ServerCode.Text) = "" Then
                MessageBox.Show("Location Code. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_ServerCode.Focus()
                Exit Sub
            End If
            'If cbo_PaymentMode.Text = "CREDIT" And Len(Trim(txt_creditfacility)) = 0 Then
            '    MessageBox.Show("This member is not not entitled for Credit facility", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    txt_MemberCode.Focus()
            '    Exit Sub
            'ElseIf cbo_PaymentMode.Text = "N.CREDIT" And Len(Trim(txt_creditfacility)) > 0 Then
            '    MessageBox.Show("This member has the credit Facility. Kindly change the mode of payment", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    txt_MemberCode.Focus()
            '    Exit Sub
            'End If
            '''**************************************** Check Server Name can't be blank *******************************************''
            If Trim(txt_ServerName.Text) = "" Then
                'MessageBox.Show("Server Name Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                'txt_ServerName.Focus()
                'Exit Sub
            End If
            '''**************************************** Check Bill Amount can't be blank **************************************************'''
            If Val(txt_BillAmount.Text) = 0 Then
                MessageBox.Show("Bill Amount Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_BillAmount.Focus()
                Exit Sub
            End If
            '''********************************************* Check ssgrid value can't be blank ********************************************'''
            For i = 1 To ssGrid.DataRowCnt
                ssGrid.Row = i
                ssGrid.Col = 1
                If Trim(ssGrid.Text) = "" Then
                    MessageBox.Show("KOT No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                    ssGrid.Focus()
                    Exit Sub
                End If
                ssGrid.Col = 2
                If Trim(ssGrid.Text) = "" Then
                    MessageBox.Show("KOT Date can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                    ssGrid.Focus()
                    Exit Sub
                End If
                ssGrid.Col = 3
                If Trim(ssGrid.Text) = "" Then
                    MessageBox.Show("KOT Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                    ssGrid.Focus()
                    Exit Sub
                End If
            Next i
            If Trim(dtp_BillDate.Text) > serverdate Then
                MessageBox.Show("KOT DATE SHOULD NOT BE GREATER THAN CURRENTDATE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            '  for not accupting the kot for posted month
            Dim A As Integer


            SQL = "SELECT * FROM kot_hdr WHERE CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) ='" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "' AND postingstatus = 'Y'"
            gconnection.getDataSet(SQL, "kot_hdr")
            If gdataset.Tables("kot_hdr").Rows.Count > 0 Then
                Cmd_Add.Enabled = False
                cmd_Delete.Enabled = False
                MessageBox.Show("NO KOT SHOULD BE ENTERED/UPDATED FOR BILL CLOSED DATE:" & Format(dtp_BillDate.Value, "dd/MMM/yyyy"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            'A = Month(Trim(dtp_BillDate.Text))
            'SQL = "SELECT * FROM bill_hdr WHERE month(billdate) = " & Val(A) & " AND ACCOUNTFLAG = 'Y'"
            'gconnection.getDataSet(SQL, "bill_hdr")
            'If gdataset.Tables("bill_hdr").Rows.Count > 0 Then
            '    Cmd_Add.Enabled = False
            '    Cmd_Delete.Enabled = False
            '    MessageBox.Show("NO KOT SHOULD BE ENTERED FOR MEMBER BILL GENERATED MONTH", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    Exit Sub
            'End If



            '''********************************************** Check The status of that particular grid **********************************'''
            If Mid(Trim(Cmd_Add.Text), 1, 1) = "A" Then
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Row = i
                    ssGrid.Col = 1
                    KOTno = Trim(ssGrid.Text)
                    If Trim(ssGrid.Text) <> "" Then
                        ssGrid.Row = i
                        ssGrid.Col = 2
                        KOTdate = Trim(ssGrid.Text)
                        sqlstring = "SELECT Billstatus FROM KOT_HDR WHERE KOTDETAILS ='" & Trim(KOTno) & "' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(dtp_BillDate.Value, "yyyy-MM-dd") & "' "
                        gconnection.getDataSet(sqlstring, "KOT_HDR")
                        If gdataset.Tables("KOT_HDR").Rows.Count > 0 Then
                            If gdataset.Tables("KOT_HDR").Rows(0).Item("Billstatus") <> "PO" Then
                                MessageBox.Show("!! Warning !!KOTNO :" & KOTdate & " " & "already adjusted in a bill", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                ssGrid.Focus()
                                Exit Sub
                            End If
                        End If
                        'BAR /RES
                        sqlstring = "SELECT ISNULL(BTYPE,'') AS BTYPE FROM KOT_HDR WHERE KOTDETAILS ='" & Trim(KOTno) & "'"
                        gconnection.getDataSet(sqlstring, "KOT_HDR")
                        If gdataset.Tables("KOT_HDR").Rows.Count > 0 Then
                            If gdataset.Tables("KOT_HDR").Rows(0).Item("BTYPE") <> Trim(CMB_BTYPE.Text) Then
                                MessageBox.Show("!! Warning !! Please Change Bill Type To " & gdataset.Tables("KOT_HDR").Rows(0).Item("BTYPE"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                CMB_BTYPE.Enabled = True
                                CMB_BTYPE.Focus()
                                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                ssGrid.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                Next i
            End If
            chkbool = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Private Sub cbo_PaymentMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_PaymentMode.SelectedIndexChanged
    '    If cbo_PaymentMode.SelectedItem = "ROOM" Then
    '        txt_MemberCode.Visible = True
    '        txt_MemberName.Visible = True
    '        lbl_MemberCode.Visible = True
    '        lbl_MemberName.Visible = True
    '        cbo_SubPaymentMode.Visible = False
    '        lbl_SubPaymentMode.Visible = False

    '        cmd_MemberCodeHelp.Visible = True
    '        txt_MemberCode.Text = ""
    '        txt_MemberName.Text = ""
    '        lbl_MemberCode.Text = "ROOM NO.   :"
    '        lbl_MemberName.Text = "GUEST NAME :"
    '        'Modified on 15 Mar'08
    '        'Kannan
    '        'Begin
    '        'ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
    '        'txt_MemberCode.Visible = False
    '        'txt_MemberName.Visible = False
    '        'lbl_MemberCode.Visible = False
    '        'lbl_MemberName.Visible = False
    '        'cmd_MemberCodeHelp.Visible = False
    '        'ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
    '        'txt_MemberCode.Visible = False
    '        'txt_MemberName.Visible = False
    '        'lbl_MemberCode.Visible = False
    '        'lbl_MemberName.Visible = False
    '        'cmd_MemberCodeHelp.Visible = False
    '        'End
    '        'ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
    '        '    txt_MemberCode.Visible = False
    '        '    txt_MemberName.Visible = False
    '        '    lbl_MemberCode.Visible = False
    '        '    lbl_MemberName.Visible = False
    '        '    cmd_MemberCodeHelp.Visible = False
    '    Else
    '        'Modified on 15 Mar'09
    '        'Mk Kannan
    '        'Begin
    '        gSQLString = "Select Isnull(MemberStatus,'') as MemberStatus From PaymentModeMaster Where Isnull(Freeze,'') <> 'Y' and Isnull(PaymentCode,'') = '" & cbo_PaymentMode.Text & "'"
    '        gconnection.getDataSet(gSQLString, "PaymentModeMaster")
    '        If gdataset.Tables("PaymentModeMaster").Rows.Count > 0 Then
    '            If Trim(gdataset.Tables("PaymentModeMaster").Rows(0).Item(0)) = "YES" Then
    '                txt_MemberCode.Visible = True
    '                txt_MemberName.Visible = True
    '                lbl_MemberCode.Visible = True
    '                lbl_MemberName.Visible = True
    '                cmd_MemberCodeHelp.Visible = True
    '                cbo_SubPaymentMode.Visible = False
    '                lbl_SubPaymentMode.Visible = False

    '                '28/04/2008
    '                'txt_MemberCode.Text = ""
    '                'txt_MemberName.Text = ""
    '                lbl_MemberCode.Text = "MEMBER CODE :"
    '                lbl_MemberName.Text = "MEMBER NAME :"
    '            Else
    '                txt_MemberCode.Visible = False
    '                txt_MemberName.Visible = False
    '                lbl_MemberCode.Visible = False
    '                lbl_MemberName.Visible = False
    '                cmd_MemberCodeHelp.Visible = False
    '                'cbo_SubPaymentMode.Visible = False
    '                'lbl_SubPaymentMode.Visible = False

    '                '28/04/2008
    '                'txt_MemberCode.Text = ""
    '                'txt_MemberName.Text = ""
    '            End If
    '        End If
    '        'End
    '    End If
    '    Call FillSubPaymentMode(Me.cbo_PaymentMode.Text)
    'End Sub
    'Private Sub cbo_PaymentMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_PaymentMode.SelectedIndexChanged
    '    Dim sqlstring As String
    '    'CSC SMARTCARD
    '    Try
    '        PAYMENTMODE_GBL = cbo_PaymentMode.Text

    '        sqlstring = " SELECT ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
    '        sqlstring = sqlstring & "WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
    '        gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
    '        If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
    '            If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) = "YES" Then
    '                lbl_SwipeCard.Visible = False
    '                txt_card_id.Visible = False
    '                Label3.Visible = False
    '                Label4.Visible = False
    '                txt_Holder_Code.Visible = False
    '                Txt_holder_name.Visible = False
    '                txt_card_id.Text = ""
    '                txt_Holder_Code.Text = ""
    '                Txt_holder_name.Text = ""

    '                txt_MemberName.Enabled = True
    '                txt_MemberCode.Enabled = True
    '                cmd_MemberCodeHelp.Enabled = True
    '                lbl_Membercode.Visible = True

    '                txt_MemberName.Visible = True
    '                txt_MemberCode.Visible = True
    '                cmd_MemberCodeHelp.Visible = True
    '                lbl_Membercode.Visible = True
    '            Else
    '                lbl_SwipeCard.Visible = True
    '                txt_card_id.Visible = True

    '                Label3.Visible = True
    '                Label4.Visible = True
    '                txt_Holder_Code.Visible = True
    '                Txt_holder_name.Visible = True

    '                txt_MemberCode.Enabled = False
    '                txt_MemberName.Enabled = False

    '                txt_Holder_Code.Enabled = False
    '                cmd_MemberCodeHelp.Enabled = False
    '                Txt_holder_name.Enabled = False

    '                lbl_SubPaymentMode.Visible = False
    '                cbo_SubPaymentMode.Visible = False
    '                cmd_MemberCodeHelp.Visible = False

    '                '***************** CSC SMARTCARD

    '                txt_MemberCode.ReadOnly = True
    '                txt_MemberName.ReadOnly = True
    '                cmd_MemberCodeHelp.Visible = False


    '                txt_MemberName.Text = ""
    '                txt_MemberCode.Text = ""
    '                txt_Holder_Code.Text = ""
    '                Txt_holder_name.Text = ""

    '                txt_MemberCode.Text = MCODE_GBL
    '                txt_MemberName.Text = MNAME_GBL


    '                If Mid(CStr(Cmd_Add.Text), 1, 1) = "A" Then
    '                    '*****************'CSC SMARTCARD
    '                    txt_MemberCode.Text = MCODE_GBL
    '                    txt_MemberName.Text = MNAME_GBL
    '                End If

    '                cmd_MemberCodeHelp.Visible = False
    '                lbl_MemberCode.Text = "MEMBER CODE :"

    '                Call GetSmartId()


    '                sqlstring = "SELECT * FROM SM_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
    '                sqlstring = sqlstring & " UNION SELECT * FROM SM_AFF_TEMP_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
    '                gconnection.getDataSet(sqlstring, "SM_MEM_LINKAGE")
    '                'CHECKING IN GLOBAL FUNCTION (DD,MM,YYYY REMOVE AND CHECK IN txt_card_id)
    '                Call CardIdValidate(Trim(txt_card_id.Text))
    '                If gdataset.Tables("SM_MEM_LINKAGE").Rows.Count > 0 Then
    '                    cardcode = gdataset.Tables("SM_MEM_LINKAGE").Rows(0).Item("CARDCODE")
    '                ElseIf Cardidcheck = True Then
    '                    cardcode = Trim(vCardcode)
    '                    vCardcode = ""
    '                Else
    '                    MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                    lbl_SwipeCard.Visible = True
    '                    txt_card_id.Clear()
    '                    'txt_card_id.Focus()
    '                    cbo_PaymentMode.Focus()

    '                    '                                lbl_SwipeCard.Focus()
    '                    Exit Sub
    '                End If

    '                sqlstring = "SELECT isnull(MEMBERCODE,'') AS MEMBERCODE, ISNULL(MEMBERSUBCODE,'') AS  MEMBERSUBCODE, ISNULL(CARDCODE,'')AS CARDCODE, ISNULL(FANCYCODE,'')AS FANCYCODE,ISNULL(PASSWORD,'')AS PASSWORD, "
    '                sqlstring = sqlstring & " ISNULL(ACTIVATION_FLAG,'')AS ACTIVATION_FLAG, ISNULL(ISSUETYPE,'')AS ISSUETYPE,ISNULL(VALID_FROM,'')AS VALID_FROM,ISNULL(VALID_TO,'')AS VALID_TO,ISNULL(NAME,'')AS NAME, ISNULL(CARDHOLDERNAME,'')AS CARDHOLDERNAME, ISNULL(AGE,0)AS AGE, ISNULL(DOB,'')AS DOB, ISNULL(TRANSACTION_TYPE,'')AS TRANSACTION_TYPE, ISNULL(AMOUNT,0)AS AMOUNT, ISNULL(BALANCE,0)AS BALANCE "
    '                sqlstring = sqlstring & " FROM SM_CARDFILE_HDR WHERE CARDCODE='" & cardcode & "'"
    '                gconnection.getDataSet(sqlstring, "SM_CARDFILE_HDR")
    '                If gdataset.Tables("SM_CARDFILE_HDR").Rows.Count > 0 Then
    '                    If gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "MEM" Or gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TE" Then
    '                        gconnection.getDataSet("SELECT MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(MCODE_GBL) & "'", "MEMBERMASTER")
    '                        If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
    '                            MNAME_GBL = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MNAME")
    '                            Txt_Remarks.Text = "Current Card Balance : " & Trim(Format(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE"), "0.00"))
    '                            txt_MemberName.Text = MNAME_GBL
    '                        End If
    '                    ElseIf gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TA" Then
    '                        lbl_MemberCode.Text = "CLUB CODE   :"
    '                        '   lbl_MemberName.Text = "CLUB NAME   :"
    '                        gconnection.getDataSet("SELECT CLUBNAME FROM AFFILIATEDCLUBDETAILS WHERE CLUBCODE='" & Trim(MCODE_GBL) & "'", "AFFILIATEDCLUBDETAILS")
    '                        If gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows.Count > 0 Then
    '                            MNAME_GBL = gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CLUBNAME")
    '                            txt_MemberName.Text = MNAME_GBL
    '                        End If
    '                    End If
    '                End If
    '            End If

    '            'If cbo_PaymentMode.SelectedItem = "SMART CARD" Then
    '            '    If txt_card_id.Text = "" Then
    '            '        txt_card_id.Focus()
    '            '    Else
    '            '        txt_MemberCode.Focus()
    '            '    End If
    '            'End If
    '        Else
    '            MsgBox("Please select a valid payment mode.........")
    '            cbo_PaymentMode.Focus()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    '        Exit Sub
    '    End Try
    '    Call FillSubPaymentMode(Trim(Me.cbo_PaymentMode.Text))
    'End Sub

    Private Sub cbo_PaymentMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_PaymentMode.SelectedIndexChanged
        Dim sqlstring As String

        If gUserCategory = "S" Then
            sqlstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y' AND DOCTYPE='" & Trim(cbo_PaymentMode.Text) & "'"
        Else
            If gPosUserControl = "Y" Then
                sqlstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE DOCTYPE='" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(FREEZE,'')<>'Y' AND POSCODE IN (SELECT POSCODE FROM POS_USERCONTROL WHERE USERNAME='" & Trim(gUsername) & "')"
            Else
                sqlstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y'  AND DOCTYPE='" & Trim(cbo_PaymentMode.Text) & "'"
            End If
        End If
        gconnection.getDataSet(sqlstring, "LOCmaster")
        If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
            StrPOSCODE = gdataset.Tables("LOCmaster").Rows(0).Item("POSCODE")
        End If

        If cbo_PaymentMode.SelectedItem = "ROOM" Then
            txt_MemberCode.Visible = True
            txt_MemberName.Visible = True
            lbl_MemberCode.Visible = True
            lbl_MemberName.Visible = True
            cmd_MemberCodeHelp.Visible = True
            txt_MemberCode.Text = ""
            txt_MemberName.Text = ""
            lbl_MemberCode.Text = "ROOM NO"
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
                        lbl_MemberCode.Visible = False
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
                        lbl_MemberCode.Visible = True
                        lbl_MemberName.Visible = True
                        cmd_MemberCodeHelp.Visible = True
                        lbl_SubPaymentMode.Visible = False
                        cbo_SubPaymentMode.Visible = False

                        'txt_MemberCode.Text = ""
                        'txt_MemberName.Text = ""

                        lbl_MemberCode.Text = "MEMBER CODE"
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
                        lbl_MemberCode.Text = "MEMBER CODE"
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
                                cardcode = gdataset.Tables("SM_MEM_LINKAGE").Rows(0).Item("CARDCODE")
                            ElseIf Cardidcheck = True Then
                                cardcode = Trim(vCardcode)
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
                            sqlstring = sqlstring & " FROM SM_CARDFILE_HDR WHERE CARDCODE='" & cardcode & "'"
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
                                    lbl_MemberCode.Text = "CLUB CODE"
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
                                LAB_CARDBAL.Visible = False
                            Else
                                LAB_CARDBAL.Visible = True
                                txt_MemberCode.Focus()
                            End If
                        Else
                            LAB_CARDBAL.Visible = False
                        End If
                        'CSC SMARTCARD
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

    Private Sub txt_BillNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BillNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_BillNo.Text) = "" Then
                Call cmd_Clear_Click(sender, e)
            Else
                Call txt_BillNo_Validated(txt_BillNo, e)
                cbo_PaymentMode.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_BillDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_BillDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbo_PaymentMode.Focus()
        End If
    End Sub
    Private Sub txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If txt_MemberCode.ReadOnly = False Then
                If Me.cmd_MemberCodeHelp.Enabled = True Then
                    Call cmd_MemberCodeHelp_Click(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub txt_ServerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ServerCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Me.Cmd_ServerCodeHelp.Enabled = True Then
                Call Cmd_ServerCodeHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub FillKOTdetails()
        Dim sqlstring, Subpaymentmode() As String
        Dim Billtotal As Double
        KotDetails = ""
        Dim i, j As Integer
        Try
            If (Trim(txt_MemberCode.Text) <> "" Or Trim(cbo_PaymentMode.Text) = "CLUB") Then

                If cbo_PaymentMode.Text = "ROOM" Then
                    sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks,servicelocation,ISNULL(SERVERNAME,'') AS SNAME FROM Kot_Hdr WHERE RoomNo='" & Trim(txt_MemberCode.Text) & "' AND  PAYMENTTYPE='" & cbo_PaymentMode.Text & "'  AND "
                    sqlstring = sqlstring & " Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' AND ISNULL(Manualbillstatus,'')<>'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "'"

                ElseIf cbo_PaymentMode.Text = "CLUB" Then
                    sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks,servicelocation,ISNULL(SERVERNAME,'') AS SNAME FROM Kot_Hdr WHERE  Mcode='" & Trim(txt_MemberCode.Text) & "' AND PAYMENTTYPE='" & cbo_PaymentMode.Text & "'  AND "
                    sqlstring = sqlstring & " Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And ISNULL(Manualbillstatus,'')<> 'Y'AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "

                    'ElseIf cbo_PaymentMode.Text = "COUPON" Then
                    '    sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks,servicelocation FROM Kot_Hdr WHERE  Mcode='" & Trim(txt_MemberCode.Text) & "' AND  PAYMENTTYPE='" & cbo_PaymentMode.Text & "'  AND BTYPE='" & CMB_BTYPE.Text & "' AND "
                    '    sqlstring = sqlstring & " Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And ISNULL(Manualbillstatus,'')<> 'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) <= '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "
                    'ElseIf cbo_PaymentMode.Text = "CASH" Then
                    '    sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks,servicelocation FROM Kot_Hdr WHERE  Mcode='" & Trim(txt_MemberCode.Text) & "' AND  PAYMENTTYPE='" & cbo_PaymentMode.Text & "'  AND BTYPE='" & CMB_BTYPE.Text & "' AND "
                    '    sqlstring = sqlstring & " Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And ISNULL(Manualbillstatus,'')<> 'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME)<= '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "
                    'ElseIf cbo_PaymentMode.Text = "PARTY" Then
                    '    sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks,servicelocation FROM Kot_Hdr WHERE Mcode='" & Trim(txt_MemberCode.Text) & "' AND  PAYMENTTYPE='" & cbo_PaymentMode.Text & "' AND BTYPE='" & CMB_BTYPE.Text & "' AND "
                    '    sqlstring = sqlstring & "Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And ISNULL(Manualbillstatus,'')<> 'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) <= '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "
                Else

                    sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks,servicelocation,ISNULL(SERVERNAME,'') AS SNAME FROM Kot_Hdr WHERE Mcode='" & Trim(txt_MemberCode.Text) & "' AND "
                    sqlstring = sqlstring & "Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And ISNULL(Manualbillstatus,'')<> 'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME)= '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "

                End If
                If Me.cbo_SubPaymentMode.Visible = True Then
                    Subpaymentmode = Split(Trim(Me.cbo_SubPaymentMode.Text), "-")
                    sqlstring = sqlstring & " and SubPaymentMode='" & Trim(Subpaymentmode(0)) & "' "
                End If
                sqlstring = sqlstring & " ORDER BY Kotdetails,Kotdate"
                gconnection.getDataSet(sqlstring, "KOT_HDR")
                With ssGrid
                    gconnection.getDataSet(sqlstring, "KOT_HDR1")
                    .ClearRange(1, 1, -1, -1, True)
                    If gdataset.Tables("KOT_HDR1").Rows.Count > 0 Then
                        Txt_Remarks.Text = Nothing
                        CMB_BTYPE.Enabled = False
                        .ClearRange(1, 1, -1, -1, True)
                        For i = 1 To gdataset.Tables("Kot_Hdr1").Rows.Count
                            .SetText(1, i, Trim(gdataset.Tables("Kot_Hdr1").Rows(j).Item("Kotdetails")) & "")
                            If Trim(KotDetails) = "" Then
                                KotDetails = "'" & Trim(gdataset.Tables("Kot_Hdr1").Rows(j).Item("Kotdetails")) & "'"
                            Else
                                KotDetails = KotDetails & ",'" & Trim(gdataset.Tables("Kot_Hdr1").Rows(j).Item("Kotdetails")) & "'"
                            End If
                            .SetText(2, i, gdataset.Tables("KOT_HDR1").Rows(j).Item("Kotdate"))
                            .SetText(3, i, Format(Val(gdataset.Tables("KOT_HDR1").Rows(j).Item("BillAmount")), "0.00"))
                            Billtotal = Billtotal + Val(gdataset.Tables("KOT_HDR1").Rows(j).Item("BillAmount"))
                            .SetText(5, i, Trim(gdataset.Tables("KOT_HDR1").Rows(j).Item("BillStatus")))
                            If Trim(gdataset.Tables("KOT_HDR1").Rows(j).Item("BillStatus")) = "ST" Then
                                .SetText(4, i, 1)
                            Else
                                .SetText(4, i, 1)
                            End If
                            .SetText(6, i, Trim(gdataset.Tables("KOT_HDR1").Rows(j).Item("SNAME")))

                            If Trim(gdataset.Tables("KOT_HDR1").Rows(j).Item("Remarks")) <> "" Then
                                If j = 0 Then
                                    Txt_Remarks.Text = Trim(gdataset.Tables("KOT_HDR1").Rows(j).Item("Remarks"))
                                Else
                                    If Len(Txt_Remarks.Text) > 0 Then
                                        Txt_Remarks.Text = Txt_Remarks.Text & "," & Trim(gdataset.Tables("KOT_HDR1").Rows(j).Item("Remarks"))
                                    Else
                                        Txt_Remarks.Text = Trim(gdataset.Tables("KOT_HDR1").Rows(j).Item("Remarks"))
                                    End If
                                End If
                            End If
                            If j = 0 Then
                                loccode = Trim(gdataset.Tables("KOT_HDR1").Rows(j).Item("servicelocation"))
                            End If
                            j = j + 1
                        Next
                        If BILLROUNDYESNO = "YES" Then
                            'Me.txt_BillAmount.Text = Format(Math.Round(Val(Billtotal)), "0.00")
                            Me.txt_BillAmount.Text = Format(Val(Billtotal), "0.00")
                        Else
                            Me.txt_BillAmount.Text = Format(Val(Billtotal), "0.00")
                        End If
                        .Focus()
                        .SetActiveCell(4, .ActiveRow)

                        If Trim(txt_ServerCode.Text) = "" Then
                            txt_ServerCode.Focus()
                        Else
                            ssGrid.Focus()
                            ssGrid.SetActiveCell(1, 1)
                        End If

                    Else
                        'MessageBox.Show("Plz enter a Valid Combination", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ssGrid.ClearRange(-1, -1, 1, 1, True)
                        'txt_ServerCode.Focus()
                        txt_MemberCode.Focus()
                    End If
                End With
                '----------------------------------------
                'SETTLEMENT
                'BEGIN
                With ssgrid_settlement
                    If ssgrid_settlement.DataRowCnt = 0 Then
                        .SetActiveCell(1, 1)
                        .Row = 1
                        .Col = 1
                        .Text = Trim(txt_MemberCode.Text)
                        .Col = 2
                        .Text = Trim(txt_BillAmount.Text)
                    End If
                End With
                '----------------------------------------
                'SETTLEMENT
            End If
            Call bill_roundoff()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub KOT_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KOT_Timer.Tick
        Try
            txt_KOTTime.Text = serverdate.ToLongTimeString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txt_BillNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BillNo.Validated
        Try
            If Trim(txt_BillNo.Text) <> "" Then
                Call BillValidate(Trim(txt_BillNo.Text))
                Call txt_ServerCode_Validated(sender, e)
                CMD_LOCK()
                '''Call CMB_BTYPE_SelectedIndexChanged(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid Billno :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub BillValidate(ByVal billdetails As String)
        Dim j, i As Integer
        Dim vString, sqlstring As String
        Dim vTypeseqno As Double
        Dim vGroupseqno As Double
        Dim other As Boolean
        Dim dt As New DataTable
        Dim A As Integer
        other = False
        If Trim(billdetails) <> "" Then
            sqlstring = "SELECT ISNULL(H.BTYPE,'') AS BTYPE,ISNULL(B.BILLNO,'') AS BILLNO,ISNULL(B.BILLDETAILS,'') AS BILLDETAILS,ISNULL(OTHBILLDETAILS,'') AS OTHBILLDETAILS,ISNULL(H.servicelocation,'') AS servicelocation,"
            sqlstring = sqlstring & " B.BILLDATE AS BILLDATE,ISNULL(AMOUNT,0) AS TOTALAMT,ISNULL(B.KOTDETAILS,'') AS KOTDETAILS,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.SCODE,'') AS SCODE, "
            sqlstring = sqlstring & " ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.SNAME,'') AS SNAME,H.BILLTIME AS BILLTIME,  ISNULL(H.TOTALAMOUNT,0) AS TOTALAMOUNT,"
            sqlstring = sqlstring & " ISNULL(N.SERVERNAME,'') AS SERVERNAME,ISNULL(H.PAYMENTMODE,'') AS PAYMENTMODE,ISNULL(H.CROSTATUS,'') AS CROSTATUS,B.KOTDATE AS KOTDATE,ISNULL(H.GUEST,'') AS GUEST,"
            sqlstring = sqlstring & " ISNULL(H.ROOMNO,0) AS ROOMNO,ISNULL(H.CHKID,0) AS CHKID,ISNULL(H.SUBPAYMENTMODE,'') AS SUBPAYMENTMODE, ISNULL(H.DELFLAG,'') AS DELFLAG, ISNULL(H.REMARKS,'') AS REMARKS,ISNULL(SBILLFLAG,'') AS SBILLFLAG "
            sqlstring = sqlstring & " FROM BILL_HDR AS H INNER JOIN BILL_DET AS B ON H.BILLDETAILS = B.BILLDETAILS"
            sqlstring = sqlstring & " INNER JOIN KOT_HDR AS N ON N.KOTDETAILS=B.KOTDETAILS "
            sqlstring = sqlstring & " INNER JOIN VIEW_KOTVAT AS D ON D.BILLDETAILS=B.BILLDETAILS AND D.TAXCODE=B.TAXCODE and d.kotdetails=b.kotdetails"
            sqlstring = sqlstring & " WHERE  B.BILLNO ='" & Format(Val(billdetails), "000000") & "' AND  SUBSTRING(B.BILLDETAILS,1,3) = '" & Trim(BillPrefix) & "' OR B.BILLDETAILS = '" & Trim(billdetails) & "' AND  SUBSTRING(B.BILLDETAILS,1,3) = '" & Trim(BillPrefix) & "'"
            ssGrid.ClearRange(1, 1, -1, -1, True)
            gconnection.getDataSet(sqlstring, "BILL_HDR")
            '''************************************************* SELECT record from KOT_HDR *********************************************''''                
            If gdataset.Tables("BILL_HDR").Rows.Count > 0 Then
                'Modified on 18 Mar'08
                'Mk Kannan
                'Begin
                loccode = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("servicelocation") & "")
                If Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("DelFlag") & "") = "Y" Then
                    lblDeleted.Visible = True
                    Cmd_Add.Enabled = False
                    cmd_Delete.Enabled = False
                Else
                    lblDeleted.Visible = False
                    '==========
                    Cmd_Add.Enabled = True
                    cmd_Delete.Enabled = True
                End If
                'End
                ''*************************TO SHOW THE CRO NO IN THE BILL*******************************************
                sqlstring = "SELECT CRONO,USERID FROM RECEIPT_DETAILS WHERE BILLNO='" & billdetails & "'"
                gconnection.getDataSet(sqlstring, "CRO")
                If gdataset.Tables("CRO").Rows.Count > 0 Then
                    lblCro1.Visible = True
                    lblCro2.Visible = True
                    lblCro2.Text = Trim(gdataset.Tables("CRO").Rows(0).Item(0)) & " -> " & Trim(gdataset.Tables("CRO").Rows(0).Item(1))
                End If
                ''***************************************************************************************************
                Cmd_Add.Text = "Update[F7]"
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
                Me.CMB_BTYPE.Enabled = False
                Me.txt_BillNo.ReadOnly = True
                Me.cmd_BillNoHelp.Enabled = False
                KOT_Timer.Enabled = False
                Call fillPayment_Mode()
                txt_BillNo.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Billdetails") & "")
                dtp_BillDate.Value = Format(CDate(gdataset.Tables("BILL_HDR").Rows(0).Item("BillDate")), "dd-MMM-yy")
                txt_KOTTime.Text = Format(CDate(gdataset.Tables("BILL_HDR").Rows(0).Item("BillTime")), "hh:mm:ss")
                txt_ServerCode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("servicelocation") & "")
                txt_ServerName.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Sname") & "")
                txt_BillAmount.Text = Format(Val(gdataset.Tables("BILL_HDR").Rows(0).Item("TotalAmount") & ""), "0.00")
                cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDown
                cbo_PaymentMode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("PaymentMode") & "")
                CMB_BTYPE.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("BTYPE") & "")
                Txt_Remarks.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Remarks") & "")
                cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
                dtp_BillDate.Enabled = False
                If gdataset.Tables("BILL_HDR").Rows(0).IsNull("CroStatus") = True Then
                    Me.Lbl_Bill.Visible = False
                    Cmd_Add.Enabled = True
                Else
                    If Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("CroStatus")) <> "N" Then
                        Me.Lbl_Bill.Text = "C R O G E N E R A T E D"
                        Me.Lbl_Bill.Visible = True
                        Cmd_Add.Enabled = False
                        cmd_Delete.Enabled = False
                    End If
                End If
                Call GridLocking()
                If Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Subpaymentmode") & "") <> "" Then
                    Call FillSubPaymentMode(Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("PaymentMode") & ""))
                    sqlstring = "SELECT SUBPAYMENTNAME,SUBPAYMENTCODE FROM SUBPAYMENTMODE WHERE SUBPAYMENTCODE = '" & Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Subpaymentmode")) & "' "
                    gconnection.getDataSet(sqlstring, "SUBPAYMENTMODE")
                    If gdataset.Tables("SUBPAYMENTMODE").Rows.Count = 1 Then
                        cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDown
                        Me.cbo_SubPaymentMode.Text = Trim(gdataset.Tables("SUBPAYMENTMODE").Rows(0).Item("SUBPAYMENTCODE") & "-" & Trim(gdataset.Tables("SUBPAYMENTMODE").Rows(0).Item("SUBPAYMENTNAME")))
                        cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
                    End If
                End If
                If Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Paymentmode")) = "ROOM" Then
                    txt_MemberCode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("ROOMNO")) & ""
                    txt_MemberName.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("GUEST")) & ""
                    sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CRIDITNUMBER,'') AS CRIDITNUMBER FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                    gconnection.getDataSet(sqlstring, "membermaster")
                    If gdataset.Tables("membermaster").Rows.Count > 0 Then
                        txt_creditfacility = gdataset.Tables("membermaster").Rows(0).Item("CRIDITNUMBER")
                    End If
                    txt_MemberCode.Tag = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("CHKID")) & ""
                Else
                    If Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("MCode")) & "" <> "" And Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Mname")) & "" <> "" Then
                        txt_MemberCode.Visible = True
                        txt_MemberName.Visible = True
                        lbl_MemberCode.Visible = True
                        lbl_MemberName.Visible = True
                        cmd_MemberCodeHelp.Visible = True
                        txt_MemberCode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("MCode")) & ""
                        txt_MemberName.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Mname")) & ""
                        sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CRIDITNUMBER,'') AS CRIDITNUMBER FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                        gconnection.getDataSet(sqlstring, "membermaster")
                        If gdataset.Tables("membermaster").Rows.Count > 0 Then
                            txt_creditfacility = gdataset.Tables("membermaster").Rows(0).Item("CRIDITNUMBER")
                        End If
                    Else
                        txt_MemberCode.Visible = False
                        txt_MemberName.Visible = False
                        lbl_MemberCode.Visible = False
                        lbl_MemberName.Visible = False
                        cmd_MemberCodeHelp.Visible = False
                        txt_MemberCode.Text = ""
                        txt_MemberName.Text = ""
                    End If
                End If
                If Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("OthBilldetails")) = "" Then
                    other = False
                Else
                    sqlstring = "select Bill_det.BillDetails,Isnull(OthBilldetails,'') As OthBilldetails,Bill_det.BillDate,TotalAmt,Kotdetails,mcode,scode,mname,sname,KotDetails,BillTime,totalamount,PayMentMode,KotDate,Guest,RoomNo,chkid"
                    sqlstring = sqlstring & " from Bill_Hdr Inner Join Bill_Det On Bill_Hdr.BillDetails=Bill_det.BillDetails  "
                    sqlstring = sqlstring & " WHERE  Bill_det.Billdetails='" & Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("OthBilldetails")) & "'"
                    gconnection.getDataSet(sqlstring, "OTHERBILLDETAILS")
                    other = True
                End If
                With ssGrid
                    For i = 1 To gdataset.Tables("BILL_HDR").Rows.Count
                        .SetText(1, i, Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Kotdetails")) & "")
                        .SetText(2, i, gdataset.Tables("BILL_HDR").Rows(j).Item("Kotdate"))
                        .SetText(3, i, Format(Val(gdataset.Tables("BILL_HDR").Rows(j).Item("TotalAmt")), "0.00"))
                        .SetText(5, i, Trim("ST"))
                        .SetText(4, i, 1)
                        .SetText(6, i, Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("SERVERNAME")) & "")
                        j = j + 1
                    Next i
                    If other = True Then
                        If gdataset.Tables("OTHERBILLDETAILS").Rows.Count > 0 Then
                            j = i
                            Me.Lbl_OtherBill.Visible = True
                            Me.Lbl_OtherBill.Text = "Other Bill No :" & Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("OthBilldetails"))
                            For i = 0 To gdataset.Tables("OTHERBILLDETAILS").Rows.Count - 1
                                .Row = j
                                .Col = 1
                                .BackColor = Color.DarkMagenta
                                .ForeColor = Color.White
                                .SetText(1, j, Trim(gdataset.Tables("OTHERBILLDETAILS").Rows(i).Item("Kotdetails")) & "")
                                .SetText(2, j, gdataset.Tables("OTHERBILLDETAILS").Rows(i).Item("Kotdate"))
                                .SetText(3, j, Format(Val(gdataset.Tables("OTHERBILLDETAILS").Rows(i).Item("TotalAmt")), "0.00"))
                                .SetText(5, j, Trim("ST"))
                                .SetText(4, j, 1)
                                j = j + 1
                            Next
                        End If
                    End If
                End With
                Call Fillsettlement()
                bill_closing()
                Call bill_roundoff()
            Else
                ' txt_BillNo.Text = ""
                ' txt_BillNo.Focus()
            End If
        End If
    End Sub
    Private Sub bill_closing()
        ssql = "select isnull(accountflag,'')  as Aflag from bill_hdr where billdetails='" & txt_BillNo.Text & "'"
        gconnection.getDataSet(ssql, "Bill")
        'If cbo_PaymentMode.SelectedItem <> "ROOM" Then
        If gdataset.Tables("Bill").Rows.Count > 0 Then
            If Trim(gdataset.Tables("Bill").Rows(0).Item("Aflag")) = "Y" Then
                Cmd_Add.Enabled = False
                cmd_Delete.Enabled = False
                cmd_Delete.Enabled = False
                cmd_BillSettlement.Enabled = False
            End If
        End If
    End Sub

    Private Sub Calculate()
        Dim Varchk As String
        Dim total As Double
        If Cmd_Add.Text = "Add [F7]" Then
            If ssGrid.ActiveCol = 5 Or ssGrid.ActiveCol = 4 Then
                Me.txt_BillAmount.Text = 0.0
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Row = i
                    ssGrid.Col = 4
                    Varchk = ""
                    Varchk = ssGrid.Text
                    If Trim(Varchk & "") = "1" Then
                        ssGrid.Col = 3
                        total = Val(ssGrid.Text)
                        Me.txt_BillAmount.Text = Format(Val(Me.txt_BillAmount.Text) + Val(total), "0.00")
                    End If
                Next i
            End If
        End If
        i = i - 1
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
    Private Sub SYS_DATE_TIME()
        Dim sqlstring, financalyear, Insert(0) As String
        Try
            'sqlstring = " SELECT TOP 1 CAST(CONVERT(CHAR(11),KOTDATE,6) AS DATETIME) AS KOTDATE FROM KOT_HDR WHERE  ISNULL(DELFLAG,'')<>'Y'  AND ISNULL(POSTINGSTATUS,'')<>'Y' "
            'sqlstring = sqlstring & " ORDER BY CAST(CONVERT(CHAR(11),KOTDATE,6) AS DATETIME) "
            'gconnection.getDataSet(sqlstring, "PENINGKOT")
            'If gdataset.Tables("PENINGKOT").Rows.Count > 0 Then
            '    dtp_BillDate.Value = gdataset.Tables("PENINGKOT").Rows(0).Item("KOTDATE")
            'Else
            sqlstring = "SELECT SERVERDATE,SERVERTIME FROM VIEW_SERVER_DATETIME "
            gconnection.getDataSet(sqlstring, "SERVERDATE")
            If gdataset.Tables("SERVERDATE").Rows.Count > 0 Then
                dtp_BillDate.Value = gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERDATE")
            End If
            'End If
            dtp_BillDate.Enabled = True
            CMD_LOCK()
        Catch ex As Exception
            MessageBox.Show("Enter a valid datetime :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Function CMD_LOCK()
        Try
            SQLSTRING = " SELECT *  FROM KOT_HDR WHERE   ISNULL(POSTINGSTATUS,'')='Y' AND CAST(CONVERT(CHAR(11),KOTDATE,6) AS DATETIME)='" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "' "
            gconnection.getDataSet(SQLSTRING, "PENINGKOT")
            If gdataset.Tables("PENINGKOT").Rows.Count > 0 Then
                Cmd_Add.Enabled = False
                cmd_Delete.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub cmd_BillNoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BillNoHelp.Click
        Try
            Dim vform As New ListOperattion1
            gSQLString = "SELECT Billdetails,Convert(varchar, BillDate,100) FROM BILL_HDR"
            M_WhereCondition = " WHERE SUBSTRING(BILLDETAILS,1,3) = '" & Trim(BillPrefix) & "' AND BTYPE='" & Trim(CMB_BTYPE.Text) & "'"
            vform.Field = " BILLDETAILS,BILLDATE "
            vform.vFormatstring = "                    BILL NO                         |                    BILL DATE               |"
            vform.vCaption = "Bill Details Help"
            vform.KeyPos = 0
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_BillNo.Text = Trim(vform.keyfield & "")
                Call txt_BillNo_Validated(sender, e)
                cbo_PaymentMode.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Public Sub BillPrintOperation_temp1()
        Randomize()
        Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
        Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword As String
        Dim BillNo, sql, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage As Double
        Dim ds As New DataSet
        Dim Otherbool, boolOtherBill As Boolean
        Dim Filewrite As StreamWriter
        Dim vpagenumber, Vrowcount As Long
        Dim headercount As Double

        Dim SSQLROOM As String

        gCompanyname = MyCompanyName
        gCompanyAddress(0) = Address1
        gCompanyAddress(1) = Address2
        Gheader = "TAX  INVOICE"
        vpagenumber = 1
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
            Otherbool = True
        Else
            Otherbool = False
        End If
        If Otherbool = True Then
            billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_BillNo.Text) & "'"
        Else
            billdetails = "'" & Trim(Me.txt_BillNo.Text) & "'"
        End If
        ''sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid "
        ''sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' ORDER BY D.BillDetails "
        'sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,ISNULL(CHKID,'') AS CHKID,ISNULL(ROOMNO,'') AS ROOMNO,ISNULL(GUEST,'') AS GUEST "
        'sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' ORDER BY D.BillDetails "

        sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,"
        sql = sql & "D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,"
        sql = sql & "D.RATE,AMOUNT,TAXTYPE,ISNULL(TAXPERC,0) AS TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,"
        sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,"
        sql = sql & "ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
        sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
        sql = sql & " WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' "
        sql = sql & " ORDER BY D.BillDetails"




        gconnection.getDataSet(sql, "ReportTable")
        Dim adduserid As String
        adduserid = ""
        If gdataset.Tables("ReportTable").Rows.Count > 0 Then
            adduserid = Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID"))
            Filewrite = File.AppendText(vFilepath)
            vline = ""
            BillNo = Trim(gdataset.Tables("ReportTable").Rows(0).Item("BillDetails"))
            taxpercentage = Val(gdataset.Tables("ReportTable").Rows(0).Item("TaxPerc"))
            Kot = ""
            For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                CountItem = CountItem + 1
                boolOtherBill = False
                headercount = 1

                If Trim(BillNo) <> Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")) Then
                    '***********change on 140508****************************
                    'Begin=======
                    'If Vrowcount <= 17 Then
                    'For i = 1 To 17 - Vrowcount
                    'Filewrite.WriteLine("")
                    'Next
                    'End========
                    If Vrowcount <= 20 Then
                        For i = 1 To 20 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If
                    '*******************************************************
                    Vrowcount = 0
                    If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "ROOM" Then
                        Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                        Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("GUEST") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("ROOMNO")) & ")")
                    Else
                        Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                        Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE")) & ")")
                    End If
                    If Len(Rowprint) < 45 Then
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine()
                    Else
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                    End If
                    Vrowcount = Vrowcount + 2
                    Rowprint = Space(66) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    Rowprint = Space(68) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    '4
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
                    Else
                        Rowprint = "Bills Payable On Presentation"
                    End If
                    Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
                    Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                    '5
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("N O  T I P P I N G")
                    Rowprint = Space(48) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    '6
                    Vrowcount = Vrowcount + 1
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Our VAT No : 19450049091                         Total :"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
                    Else
                        Rowprint = "                                                 Total :"
                    End If
                    Rowprint = Rowprint & Space(67 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
                    Filewrite.WriteLine(Rowprint)
                    '7
                    Vrowcount = Vrowcount + 1
                    RoundOff = Val(TaxAmount + TotalAmount)
                    round = CStr(RoundOff)
                    If round.IndexOf(".") <= 0 Then
                        round = round.Insert(round.Length - 1, ".00")
                    End If
                    If Val(Split(round, ".")(1)) >= 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    Else
                        RoundOff = Math.Floor(RoundOff)
                    End If
                    If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                        RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                        Rowprint = "                                           Rounded Off :(+)"
                    Else
                        RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                        Rowprint = "                                           Rounded Off :(-)"
                    End If
                    Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
                    Filewrite.WriteLine(Rowprint)
                    '8
                    Vrowcount = Vrowcount + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    '9
                    Vrowcount = Vrowcount + 1
                    rupeesword = ConvertRupees(Format(TaxAmount + TotalAmount, "0.00"))
                    Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(Math.Round(TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
                    Filewrite.WriteLine(Rowprint)
                    '10
                    Vrowcount = Vrowcount + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine("")
                    '11
                    Vrowcount = Vrowcount + 1
                    Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
                    Filewrite.WriteLine(Rowprint)
                    '12
                    Vrowcount = Vrowcount + 1
                    Dim ssql As String
                    ssql = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
                    ssql = ssql & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
                    ssql = ssql & " WHERE D.Billdetails = '" & BillNo & "' "
                    ssql = ssql & " AND ISNULL(KotStatus,'N')='N'"
                    ssql = ssql & " order by d.billdetails"
                    gconnection.getDataSet(ssql, "rTable")
                    For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                        Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
                    Next
                    If Len(Kot) < 31 Then
                        Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                        Filewrite.WriteLine(Rowprint)
                        Filewrite.WriteLine()
                        Vrowcount = Vrowcount + 2
                    Else
                        Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 2
                    End If
                    '14
                    Kot = ""
                    If Trim(Txt_Remarks.Text) <> "" Then
                        If Len(Trim(Txt_Remarks.Text)) < 65 Then
                            Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                            Filewrite.WriteLine()
                            Vrowcount = Vrowcount + 2
                        Else
                            Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                            Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                            Vrowcount = Vrowcount + 2
                        End If
                    End If
                    '16
                    If Vrowcount <= 24 Then
                        For i = 1 To 24 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If
                    BillNo = gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")
                    Kot = ""
                    TotalAmount = 0
                    TaxAmount = 0
                    taxpercentage = Val(gdataset.Tables("ReportTable").Rows(rowj).Item("TaxPerc"))
                    Vrowcount = 0
                    boolOtherBill = True
                    CountItem = 1
                End If

                '24+17 = total length
                'changable one

                If (Vrowcount = 0 Or Vrowcount >= 20) Then
                    'If Vrowcount >= 17 Then
                    If Vrowcount >= 20 Then
                        headercount = 1
                        Vrowcount = 0
                        'Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                        'Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE")) & ")")

                        If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "ROOM" Then
                            Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                            Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("GUEST") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("ROOMNO")) & ")")
                        Else
                            Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                            Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE")) & ")")
                        End If

                        If Len(Rowprint) < 45 Then
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                            Filewrite.WriteLine()
                        Else
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                        End If
                        Vrowcount = Vrowcount + 2
                        If Format(Val(taxpercentage), "0.00") = "12.50" Then
                            Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
                        ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                            Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
                        Else
                            Rowprint = "Bills Payable On Presentation"
                        End If
                        Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                        Vrowcount = Vrowcount + 1
                        Filewrite.Write("N O  T I P P I N G")
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        If Format(Val(taxpercentage), "0.00") = "12.50" Then
                            Rowprint = "Our VAT No : 19450049091                                "
                        ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                            Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06               "
                        Else
                            Rowprint = "                                                        "
                        End If
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1
                        RoundOff = Val(TaxAmount + TotalAmount)
                        round = CStr(RoundOff)
                        If round.IndexOf(".") <= 0 Then
                            round = round.Insert(round.Length - 1, ".00")
                        End If
                        If Val(Split(round, ".")(1)) >= 50 Then
                            RoundOff = Math.Ceiling(RoundOff)
                        Else
                            RoundOff = Math.Floor(RoundOff)
                        End If
                        If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                            RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                            Rowprint = "                                           Rounded Off :(+)"
                        Else
                            RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                            Rowprint = "                                           Rounded Off :(-)"
                        End If
                        Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        rupeesword = ConvertRupees(Format(TaxAmount + TotalAmount, "0.00"))
                        Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
                        Rowprint = Rowprint & Format(Math.Round(TaxAmount + TotalAmount), "0.00")
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        For i = 0 To 78
                            Filewrite.Write("-")
                        Next
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        'Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
                        Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1
                        If Len(Kot) < 31 Then
                            Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                            Filewrite.WriteLine(" ")
                            Vrowcount = Vrowcount + 1
                        Else
                            Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                            Filewrite.WriteLine(" ")
                            Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                            Filewrite.WriteLine(" ")
                            Vrowcount = Vrowcount + 2
                        End If
                        If Trim(Txt_Remarks.Text) <> "" Then
                            If Len(Trim(Txt_Remarks.Text)) < 65 Then
                                Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                                Vrowcount = Vrowcount + 1
                            Else
                                Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                                Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                                Vrowcount = Vrowcount + 2
                            End If
                        End If
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(Space(65) & "Continued....")
                        headercount = headercount + 1
                        Vrowcount = Vrowcount + 2
                        '**************************Change on 140508*******************************

                        If Vrowcount <= 20 Then
                            For i = 1 To 20 - Vrowcount
                                Filewrite.WriteLine("")
                            Next
                        End If
                        '**************************************************************************
                    End If

                    If headercount = 1 Then
                        ''change===31.05
                        'Rowprint = Space(16) & Chr(27) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & gCompanyname & Chr(20) & Chr(27) & Chr(72)
                        ''End===========
                        Rowprint = Space(16) & Chr(18) & Chr(27) + "E" & gCompanyname & Chr(27) + "F" & Chr(15)
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(13) & gCompanyAddress(0)
                        Filewrite.WriteLine(Rowprint)
                        ''Change===31.05 Begin
                        ''Rowprint = Space(13) & gCompanyAddress(1)
                        ''Filewrite.WriteLine(Rowprint)
                        ''End=================
                    Else
                        '''''''Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(1) & Chr(20) & Chr(27) & Chr(72)
                        '''''''Filewrite.WriteLine(Rowprint)
                        '''''''Rowprint = Space(1)
                        '''''''Filewrite.WriteLine(Rowprint)
                        '''''''Rowprint = Space(1)
                        '''''''Filewrite.WriteLine(Rowprint)
                        ''change 3105=====begin
                        Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(1) & Chr(20) & Chr(27) & Chr(72)
                        'End==============
                        'Rowprint = Space(16) & Chr(18) & Chr(27) + "E" & gCompanyname & Chr(27) + "F" & Chr(15)
                        Filewrite.WriteLine(Rowprint)
                        'Rowprint = Space(1)
                        'Filewrite.WriteLine(Rowprint)
                        'Rowprint = Space(1)
                        'Filewrite.WriteLine(Rowprint)
                    End If
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Gheader = " TAX  INVOICE "
                    Else
                        Gheader = " CREDIT  MEMO "
                    End If
                    'Change 31.05 begin
                    'Filewrite.WriteLine("")
                    'end
                    Rowprint = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = Space(16) & "BILL NO :"
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(BillNo) & Chr(27) + "F" & Chr(18)
                    Filewrite.Write(Rowprint)
                    Rowprint = Chr(15) & Space(40 - Len(Trim(BillNo)))
                    Rowprint = Rowprint & "TIME  :"
                    Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "hh:mm:ss")
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = Space(16) & "SERVER  :"
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE"))
                    Filewrite.Write(Rowprint)
                    Rowprint = "(" & Mid(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME"), 1, 25) & ")" & Space(30 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME") & "(" & gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME") & ")"), 1, 30))) & Chr(27) + "F" & Chr(15)
                    Rowprint = Rowprint & "DATE  :"
                    Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy")
                    Filewrite.WriteLine(Rowprint)
                    Pagesize = Pagesize + 1

                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    Rowprint = "SLNo  CODE  ITEM DESCRIPTION                      QUANTITY   RATE   AMOUNT  "
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    'Vrowcount = 9
                    Vrowcount = 8
                End If

                With gdataset.Tables("ReportTable").Rows(rowj)
                    Rowprint = ""
                    Rowprint = Mid(CountItem, 1, 5) & "." & Space(5 - Len(Mid(CountItem, 1, 5)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMCODE") & ""), 1, 6) & Space(6 - Len(Mid(Trim(.Item("ITEMCODE") & ""), 1, 6)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMDESC") & ""), 1, 38) & Mid(Trim(".............................."), 1, 38 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 38)))
                    Rowprint = Rowprint & Mid(Val(.Item("QTY") & ""), 1, 3) & Space(3 - Len(Mid(Trim(.Item("QTY") & ""), 1, 3))) & Space(1)
                    Rowprint = Rowprint & Mid(Trim(.Item("UOM") & ""), 1, 5) & Space(5 - Len(Mid(Trim(.Item("UOM") & ""), 1, 5)))
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8)
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8)
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    Vrowcount = Vrowcount + 1
                End With
            Next rowj

            '*********************Change on 150408***********************
            '========change===31.05  begin
            '''If Vrowcount <= 17 Then
            '''    For i = 1 To 17 - Vrowcount
            '''        Filewrite.WriteLine("")
            '''    Next
            '''End If
            'end=====
            '************************************************************
            If Vrowcount <= 20 Then
                For i = 1 To 20 - Vrowcount
                    Filewrite.WriteLine("")
                Next
            End If

            Vrowcount = 0
            'Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10)))
            'Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MCODE")) & ")")
            If Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) = "ROOM" Then
                Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10)))
                Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("ROOMNO") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("GUEST")) & ")")
            Else
                Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10)))
                Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MCODE")) & ")")
            End If
            If Len(Rowprint) < 45 Then
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                Filewrite.WriteLine()
            Else
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
            End If
            Vrowcount = Vrowcount + 2
            '2
            Rowprint = Space(66) & "----------"
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            '3
            Rowprint = Space(69) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            '4
            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
            ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
            Else
                Rowprint = "Bills Payable On Presentation"
            End If
            Rowprint = Rowprint & Space(70 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
            Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
            Vrowcount = Vrowcount + 1
            '5
            Filewrite.Write("N O  T I P P I N G")
            'Vrowcount = Vrowcount + 1
            Rowprint = Space(48) & "----------"
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            '6
            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                Rowprint = "Our VAT No : 19450049091                         Total :"
            ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
            Else
                Rowprint = "                                                 Total :"
            End If
            Rowprint = Rowprint & Space(68 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            '7
            RoundOff = Val(TaxAmount + TotalAmount)
            round = CStr(RoundOff)
            If round.IndexOf(".") <= 0 Then
                round = round.Insert(round.Length - 1, ".00")
            End If
            If Val(Split(round, ".")(1)) >= 50 Then
                RoundOff = Math.Ceiling(RoundOff)
            Else
                RoundOff = Math.Floor(RoundOff)
            End If
            If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                Rowprint = "                                           Rounded Off :(+)"
            Else
                RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                Rowprint = "                                           Rounded Off :(-)"
            End If
            Rowprint = Rowprint & Space(70 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            '8
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Vrowcount = Vrowcount + 1
            '9
            rupeesword = ConvertRupees(Format(TaxAmount + TotalAmount, "0.00"))

            Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
            Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(Math.Round(TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            '10
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine("")
            Vrowcount = Vrowcount + 1
            '11

            '            Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
            Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname

            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            '12

            Dim sstring As String
            sstring = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
            sstring = sstring & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
            sstring = sstring & " WHERE D.Billdetails = '" & BillNo & "' "
            sstring = sstring & " AND ISNULL(KotStatus,'N')='N'"
            sstring = sstring & " order by d.billdetails"
            gconnection.getDataSet(sstring, "rTable")
            For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
            Next
            If Len(Kot) < 31 Then
                Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
                '13
            Else
                Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                Filewrite.WriteLine(Rowprint)
                Rowprint = "             " & Mid(Kot, 31, 30) & "."
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 2

            End If

            If Trim(Txt_Remarks.Text) <> "" Then
                If Len(Trim(Txt_Remarks.Text)) < 65 Then
                    Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                    Vrowcount = Vrowcount + 1
                    '14
                Else
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                    Vrowcount = Vrowcount + 2
                End If
            End If
            ''If Vrowcount <= 24 Then
            ''    For i = 1 To 24 - Vrowcount
            ''        Filewrite.WriteLine("")
            ''    Next
            ''End If
            For i = 1 To 2
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
    Public Sub BillPrintOperation()
        Randomize()
        Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
        Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword As String
        Dim BillNo, sql, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage As Double
        Dim ds As New DataSet
        Dim Otherbool, boolOtherBill As Boolean
        Dim Filewrite As StreamWriter
        Dim vpagenumber, Vrowcount As Long
        Dim headercount As Double

        Dim SSQLROOM As String

        gCompanyname = MyCompanyName
        gCompanyAddress(0) = Address1
        gCompanyAddress(1) = Address2
        Gheader = "TAX  INVOICE"
        vpagenumber = 1
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
            Otherbool = True
        Else
            Otherbool = False
        End If
        If Otherbool = True Then
            billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_BillNo.Text) & "'"
        Else
            billdetails = "'" & Trim(Me.txt_BillNo.Text) & "'"
        End If
        ''sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid "
        ''sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' ORDER BY D.BillDetails "
        'sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,ISNULL(CHKID,'') AS CHKID,ISNULL(ROOMNO,'') AS ROOMNO,ISNULL(GUEST,'') AS GUEST "
        'sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' ORDER BY D.BillDetails "

        sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,"
        sql = sql & "D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,"
        sql = sql & "D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,"
        sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,"
        sql = sql & "ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
        sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
        sql = sql & " WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' "
        sql = sql & " ORDER BY D.BillDetails"

        gconnection.getDataSet(sql, "ReportTable")
        Dim adduserid As String
        adduserid = ""
        If gdataset.Tables("ReportTable").Rows.Count > 0 Then
            adduserid = Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID"))
            Filewrite = File.AppendText(vFilepath)
            vline = ""
            BillNo = Trim(gdataset.Tables("ReportTable").Rows(0).Item("BillDetails"))
            taxpercentage = Val(gdataset.Tables("ReportTable").Rows(0).Item("TaxPerc"))
            Kot = ""
            For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                CountItem = CountItem + 1
                boolOtherBill = False
                headercount = 1
                ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                If Trim(BillNo) <> Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")) Then
                    If Vrowcount <= 17 Then
                        For i = 1 To 17 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If
                    Vrowcount = 0
                    If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "ROOM" Then
                        Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                        Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("GUEST") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("ROOMNO")) & ")")
                    Else
                        Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                        Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE")) & ")")
                    End If
                    If Len(Rowprint) < 45 Then
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine()
                    Else
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                    End If
                    Vrowcount = Vrowcount + 2
                    Rowprint = Space(66) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    Rowprint = Space(68) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    '4
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
                    Else
                        Rowprint = "Bills Payable On Presentation"
                    End If
                    Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
                    Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                    '5
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("N O  T I P P I N G")
                    Rowprint = Space(48) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    '6
                    Vrowcount = Vrowcount + 1
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Our VAT No : 19450049091                         Total :"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
                    Else
                        Rowprint = "                                                 Total :"
                    End If
                    Rowprint = Rowprint & Space(67 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
                    Filewrite.WriteLine(Rowprint)
                    '7
                    Vrowcount = Vrowcount + 1
                    RoundOff = Val(TaxAmount + TotalAmount)
                    round = CStr(RoundOff)
                    If round.IndexOf(".") <= 0 Then
                        round = round.Insert(round.Length - 1, ".00")
                    End If
                    If Val(Split(round, ".")(1)) >= 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    Else
                        RoundOff = Math.Floor(RoundOff)
                    End If
                    If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                        RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                        Rowprint = "                                           Rounded Off :(+)"
                    Else
                        RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                        Rowprint = "                                           Rounded Off :(-)"
                    End If
                    Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
                    Filewrite.WriteLine(Rowprint)
                    '8
                    Vrowcount = Vrowcount + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    '9
                    Vrowcount = Vrowcount + 1
                    rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))
                    Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(Math.Round(TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
                    Filewrite.WriteLine(Rowprint)
                    '10
                    Vrowcount = Vrowcount + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine("")
                    '11
                    Vrowcount = Vrowcount + 1
                    Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
                    Filewrite.WriteLine(Rowprint)
                    '12
                    Vrowcount = Vrowcount + 1
                    Dim ssql As String
                    ssql = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
                    ssql = ssql & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
                    ssql = ssql & " WHERE D.Billdetails = '" & BillNo & "' "
                    ssql = ssql & " AND ISNULL(KotStatus,'N')='N'"
                    ssql = ssql & " order by d.billdetails"
                    gconnection.getDataSet(ssql, "rTable")
                    For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                        Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
                    Next
                    If Len(Kot) < 31 Then
                        Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                        Filewrite.WriteLine(Rowprint)
                        Filewrite.WriteLine()
                        Vrowcount = Vrowcount + 2
                    Else
                        Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 2
                    End If
                    '14
                    Kot = ""
                    If Trim(Txt_Remarks.Text) <> "" Then
                        If Len(Trim(Txt_Remarks.Text)) < 65 Then
                            Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                            Filewrite.WriteLine()
                            Vrowcount = Vrowcount + 2
                        Else
                            Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                            Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                            Vrowcount = Vrowcount + 2
                        End If
                    End If
                    '16
                    If Vrowcount <= 24 Then
                        For i = 1 To 24 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If
                    BillNo = gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")
                    Kot = ""
                    TotalAmount = 0
                    TaxAmount = 0
                    taxpercentage = Val(gdataset.Tables("ReportTable").Rows(rowj).Item("TaxPerc"))
                    Vrowcount = 0
                    boolOtherBill = True
                    CountItem = 1
                End If
                ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                '24+17 = total length
                'changable one

                If (Vrowcount = 0 Or Vrowcount >= 17) Then
                    If Vrowcount >= 17 Then
                        headercount = 1
                        Vrowcount = 0
                        'Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                        'Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE")) & ")")

                        If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "ROOM" Then
                            Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                            Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("GUEST") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("ROOMNO")) & ")")
                        Else
                            Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                            Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE")) & ")")
                        End If

                        If Len(Rowprint) < 45 Then
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                            Filewrite.WriteLine()
                        Else
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                        End If
                        Vrowcount = Vrowcount + 2
                        If Format(Val(taxpercentage), "0.00") = "12.50" Then
                            Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
                        ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                            Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
                        Else
                            Rowprint = "Bills Payable On Presentation"
                        End If
                        Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                        Vrowcount = Vrowcount + 1
                        Filewrite.Write("N O  T I P P I N G")
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        If Format(Val(taxpercentage), "0.00") = "12.50" Then
                            Rowprint = "Our VAT No : 19450049091                                "
                        ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                            Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06               "
                        Else
                            Rowprint = "                                                        "
                        End If
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1
                        RoundOff = Val(TaxAmount + TotalAmount)
                        round = CStr(RoundOff)
                        If round.IndexOf(".") <= 0 Then
                            round = round.Insert(round.Length - 1, ".00")
                        End If
                        If Val(Split(round, ".")(1)) >= 50 Then
                            RoundOff = Math.Ceiling(RoundOff)
                        Else
                            RoundOff = Math.Floor(RoundOff)
                        End If
                        If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                            RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                            Rowprint = "                                           Rounded Off :(+)"
                        Else
                            RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                            Rowprint = "                                           Rounded Off :(-)"
                        End If
                        Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))
                        Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
                        Rowprint = Rowprint & Format(Math.Round(TaxAmount + TotalAmount), "0.00")
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        For i = 0 To 78
                            Filewrite.Write("-")
                        Next
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        'Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
                        Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1
                        If Len(Kot) < 31 Then
                            Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                            Filewrite.WriteLine(" ")
                            Vrowcount = Vrowcount + 1
                        Else
                            Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                            Filewrite.WriteLine(" ")
                            Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                            Filewrite.WriteLine(" ")
                            Vrowcount = Vrowcount + 2
                        End If
                        If Trim(Txt_Remarks.Text) <> "" Then
                            If Len(Trim(Txt_Remarks.Text)) < 65 Then
                                Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                                Vrowcount = Vrowcount + 1
                            Else
                                Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                                Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                                Vrowcount = Vrowcount + 2
                            End If
                        End If
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(Space(65) & "Continued....")
                        headercount = headercount + 1
                        Vrowcount = Vrowcount + 2
                        If Vrowcount <= 24 Then
                            For i = 1 To 24 - Vrowcount
                                Filewrite.WriteLine("")
                            Next
                        End If
                    End If

                    ''Hedwe printing
                    ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                    If headercount = 1 Then
                        'Initial heading printing
                        '========================
                        Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & gCompanyname & Chr(20) & Chr(27) & Chr(72)
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(13) & gCompanyAddress(0)
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(13) & gCompanyAddress(1)
                        Filewrite.WriteLine(Rowprint)
                    Else
                        Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(1) & Chr(20) & Chr(27) & Chr(72)
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(1)
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(1)
                        Filewrite.WriteLine(Rowprint)
                    End If
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Gheader = " TAX  INVOICE "
                    Else
                        Gheader = " CREDIT  MEMO "
                    End If

                    Filewrite.WriteLine("")
                    Rowprint = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "BILL NO :"
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(BillNo) & Chr(27) + "F" & Chr(18)
                    Filewrite.Write(Rowprint)
                    Rowprint = Chr(15) & Space(40 - Len(Trim(BillNo)))
                    Rowprint = Rowprint & "TIME  :"
                    'Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "hh:mm:ss")
                    Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "T")
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "SERVER  :"
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE"))
                    Filewrite.Write(Rowprint)
                    Rowprint = "(" & Mid(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME"), 1, 25) & ")" & Space(30 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME") & "(" & gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME") & ")"), 1, 30))) & Chr(27) + "F" & Chr(15)
                    Rowprint = Rowprint & "DATE  :"
                    Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy")
                    Filewrite.WriteLine(Rowprint)
                    Pagesize = Pagesize + 1

                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    Rowprint = "SLNo  CODE  ITEM DESCRIPTION                      QUANTITY   RATE   AMOUNT  "
                    Filewrite.WriteLine(Rowprint & Chr(15))

                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    '''End of Header Printing
                    '''&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                    Vrowcount = 9
                End If

                With gdataset.Tables("ReportTable").Rows(rowj)
                    Rowprint = ""
                    Rowprint = Mid(CountItem, 1, 5) & "." & Space(5 - Len(Mid(CountItem, 1, 5)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMCODE") & ""), 1, 6) & Space(6 - Len(Mid(Trim(.Item("ITEMCODE") & ""), 1, 6)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMDESC") & ""), 1, 38) & Mid(Trim(".............................."), 1, 38 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 38)))
                    Rowprint = Rowprint & Mid(Val(.Item("QTY") & ""), 1, 3) & Space(3 - Len(Mid(Trim(.Item("QTY") & ""), 1, 3))) & Space(1)
                    Rowprint = Rowprint & Mid(Trim(.Item("UOM") & ""), 1, 5) & Space(5 - Len(Mid(Trim(.Item("UOM") & ""), 1, 5)))
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8)
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8)
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    Vrowcount = Vrowcount + 1
                End With
            Next rowj

            If Vrowcount <= 17 Then
                For i = 1 To 17 - Vrowcount
                    Filewrite.WriteLine("")
                Next
            End If

            Vrowcount = 0
            'Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10)))
            'Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MCODE")) & ")")
            If Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) = "ROOM" Then
                Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10)))
                Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("ROOMNO") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("GUEST")) & ")")
            Else
                Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10)))
                Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MCODE")) & ")")
            End If
            If Len(Rowprint) < 45 Then
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                Filewrite.WriteLine()
            Else
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
            End If
            Vrowcount = Vrowcount + 2
            Rowprint = Space(66) & "----------"
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            Rowprint = Space(69) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
            ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
            Else
                Rowprint = "Bills Payable On Presentation"
            End If
            Rowprint = Rowprint & Space(70 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
            Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
            Vrowcount = Vrowcount + 1
            Filewrite.Write("N O  T I P P I N G")
            'Vrowcount = Vrowcount + 1
            Rowprint = Space(48) & "----------"
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                Rowprint = "Our VAT No : 19450049091                         Total :"
            ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
            Else
                Rowprint = "                                                 Total :"
            End If
            Rowprint = Rowprint & Space(68 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            RoundOff = Val(TaxAmount + TotalAmount)
            round = CStr(RoundOff)
            If round.IndexOf(".") <= 0 Then
                round = round.Insert(round.Length - 1, ".00")
            End If
            If Val(Split(round, ".")(1)) >= 50 Then
                RoundOff = Math.Ceiling(RoundOff)
            Else
                RoundOff = Math.Floor(RoundOff)
            End If
            If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                Rowprint = "                                           Rounded Off :(+)"
            Else
                RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                Rowprint = "                                           Rounded Off :(-)"
            End If
            Rowprint = Rowprint & Space(70 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Vrowcount = Vrowcount + 1
            rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))

            Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
            Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(Math.Round(TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine("")
            Vrowcount = Vrowcount + 1
            '            Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
            Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname

            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            Dim sstring As String
            sstring = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
            sstring = sstring & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
            sstring = sstring & " WHERE D.Billdetails = '" & BillNo & "' "
            sstring = sstring & " AND ISNULL(KotStatus,'N')='N'"
            sstring = sstring & " order by d.billdetails"
            gconnection.getDataSet(sstring, "rTable")
            For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
            Next
            If Len(Kot) < 31 Then
                Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
            Else
                Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                Filewrite.WriteLine(Rowprint)
                Rowprint = "             " & Mid(Kot, 31, 30) & "."
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 2
            End If
            If Trim(Txt_Remarks.Text) <> "" Then
                If Len(Trim(Txt_Remarks.Text)) < 65 Then
                    Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                    Vrowcount = Vrowcount + 1
                Else
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                    Vrowcount = Vrowcount + 2
                End If
            End If
            If Vrowcount <= 24 Then
                For i = 1 To 24 - Vrowcount
                    Filewrite.WriteLine("")
                Next
            End If
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
    Public Sub BillPrintOperation_Alokesh()
        Randomize()
        Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
        Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword As String
        Dim BillNo, sql, sqlstring, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage As Double
        Dim ds As New DataSet
        Dim Otherbool, boolOtherBill As Boolean
        Dim Filewrite As StreamWriter
        Dim vpagenumber, Vrowcount, innercount, taxcount As Long
        Dim headercount As Double
        Dim SSQLROOM, poscode As String
        gCompanyname = MyCompanyName
        gCompanyAddress(0) = Address1
        gCompanyAddress(1) = Address2
        Gheader = "TAX  INVOICE"
        vpagenumber = 1
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
            Otherbool = True
        Else
            Otherbool = False
        End If
        If Otherbool = True Then
            billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_BillNo.Text) & "'"
        Else
            billdetails = "'" & Trim(Me.txt_BillNo.Text) & "'"
        End If
        sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,"
        sql = sql & "D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,"
        sql = sql & "D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,"
        sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,"
        sql = sql & "ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
        sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
        sql = sql & " WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' "
        sql = sql & " ORDER BY D.BillDetails"
        gconnection.getDataSet(sql, "ReportTable")
        Dim adduserid As String
        adduserid = ""
        If gdataset.Tables("ReportTable").Rows.Count > 0 Then
            poscode = Trim(gdataset.Tables("ReportTable").Rows(0).Item("poscode"))
            adduserid = Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID"))
            Filewrite = File.AppendText(vFilepath)
            vline = ""
            BillNo = Trim(gdataset.Tables("ReportTable").Rows(0).Item("BillDetails"))
            taxpercentage = Val(gdataset.Tables("ReportTable").Rows(0).Item("TaxPerc"))
            Kot = ""
            ''FOR LOOP START
            ''==============
            For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                CountItem = CountItem + 1
                boolOtherBill = False
                headercount = 1
                If Trim(BillNo) <> Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")) Then
                    If Vrowcount <= 32 Then
                        For i = 1 To 17 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If

                    'Vrowcount = 0
                    If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "ROOM" Then
                        Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                        Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("GUEST") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("ROOMNO")) & ")")
                    Else
                        Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                        Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE")) & ")")
                    End If

                    If Len(Rowprint) < 45 Then
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine()
                        Vrowcount = Vrowcount + 2
                    Else
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                        Vrowcount = Vrowcount + 2
                    End If
                    Vrowcount = Vrowcount + 2
                    Rowprint = Space(66) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    Rowprint = Space(68) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    '4
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
                    Else
                        Rowprint = "Bills Payable On Presentation"
                    End If
                    Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
                    Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                    '5
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("N O  T I P P I N G")
                    Rowprint = Space(48) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    '6
                    Vrowcount = Vrowcount + 1
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Our VAT No : 19450049091                         Total :"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
                    Else
                        Rowprint = "                                                 Total :"
                    End If
                    Rowprint = Rowprint & Space(67 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
                    Filewrite.WriteLine(Rowprint)
                    '7
                    Vrowcount = Vrowcount + 1
                    RoundOff = Val(TaxAmount + TotalAmount)
                    round = CStr(RoundOff)
                    If round.IndexOf(".") <= 0 Then
                        round = round.Insert(round.Length - 1, ".00")
                    End If
                    If Val(Split(round, ".")(1)) >= 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    Else
                        RoundOff = Math.Floor(RoundOff)
                    End If
                    If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                        RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                        Rowprint = "                                           Rounded Off :(+)"
                    Else
                        RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                        Rowprint = "                                           Rounded Off :(-)"
                    End If
                    'modify by saran
                    'begin()
                    ''Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
                    ''Filewrite.WriteLine(Rowprint)
                    'end
                    '8

                    Vrowcount = Vrowcount + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    '9
                    Vrowcount = Vrowcount + 1
                    'modify by saran
                    'begin()
                    'with rounding
                    'rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))
                    'Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
                    'Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(Math.Round(TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
                    'with out rounding
                    rupeesword = ConvertRupees(Format(TaxAmount + TotalAmount, "0.00"))
                    Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(TaxAmount + TotalAmount, "0.00") & Chr(27) + "F" & Chr(15)
                    Filewrite.WriteLine(Rowprint)
                    'end
                    '10
                    Vrowcount = Vrowcount + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine("")
                    '11
                    Vrowcount = Vrowcount + 1
                    Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
                    Filewrite.WriteLine(Rowprint)
                    '12
                    Vrowcount = Vrowcount + 1
                    Dim ssql As String
                    ssql = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
                    ssql = ssql & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
                    ssql = ssql & " WHERE D.Billdetails = '" & BillNo & "' "
                    ssql = ssql & " AND ISNULL(KotStatus,'N')='N'"
                    ssql = ssql & " order by d.billdetails"
                    gconnection.getDataSet(ssql, "rTable")
                    For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                        Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
                    Next
                    If Len(Kot) < 31 Then
                        Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                        Filewrite.WriteLine(Rowprint)
                        Filewrite.WriteLine()
                        Vrowcount = Vrowcount + 1
                    Else
                        Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1
                    End If
                    '14
                    Kot = ""
                    If Trim(Txt_Remarks.Text) <> "" Then
                        If Len(Trim(Txt_Remarks.Text)) < 65 Then
                            Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                            Filewrite.WriteLine()
                            Vrowcount = Vrowcount + 1
                        Else
                            Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                            Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                            Vrowcount = Vrowcount + 1
                        End If
                    End If
                    '16
                    If Vrowcount > 32 Then
                        For i = 1 To 77 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If

                    If Vrowcount <= 32 Then
                        For i = 1 To 8
                            Filewrite.WriteLine("")
                        Next
                    End If

                    BillNo = gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")
                    Kot = ""
                    TotalAmount = 0
                    TaxAmount = 0
                    taxpercentage = Val(gdataset.Tables("ReportTable").Rows(rowj).Item("TaxPerc"))
                    Vrowcount = 0
                    boolOtherBill = True
                    CountItem = 1
                End If
                ',Madras club
                ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                ''''''''''    ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                If Vrowcount = 0 Then
                    If headercount = 1 Then
                        'Initial heading printing
                        '========================
                        headercount = 2
                        For i = 0 To 2
                            Filewrite.WriteLine("")
                        Next
                        Vrowcount = Vrowcount + 3
                        Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & gCompanyname & Chr(20) & Chr(27) & Chr(72)
                        Filewrite.WriteLine(Rowprint)
                        '1
                        Vrowcount = Vrowcount + 1
                        'Rowprint = Space(13) & gCompanyAddress(0)
                        Rowprint = gCompanyAddress(0)
                        Filewrite.WriteLine(Rowprint)
                        '2
                        Vrowcount = Vrowcount + 1
                        'Rowprint = Space(13) & gCompanyAddress(1)
                        Rowprint = gCompanyAddress(1)
                        Filewrite.WriteLine(Rowprint)
                        '3
                        Vrowcount = Vrowcount + 1
                        ''======================================
                        'If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        '    Gheader = " TAX  INVOICE "
                        'Else
                        Gheader = " CREDIT  MEMO "
                        'End If
                        Filewrite.WriteLine("")
                        '4
                        Vrowcount = Vrowcount + 1
                        Rowprint = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        Rowprint = "BILL NO :"
                        Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(BillNo) & Chr(27) + "F" & Chr(18)
                        Filewrite.Write(Rowprint)
                        Vrowcount = Vrowcount + 1
                        Rowprint = Chr(15) & Space(40 - Len(Trim(BillNo)))
                        Rowprint = Rowprint & "TIME  :"
                        'Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "hh:mm:ss")
                        Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "T")
                        Filewrite.WriteLine(Rowprint)
                        '5
                        Vrowcount = Vrowcount + 1
                        Rowprint = "USER    :"
                        'Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE")), 1, 10) & space(
                        Filewrite.Write(Rowprint)
                        Rowprint = Chr(18) & Chr(27) + "E"
                        Rowprint = Rowprint & Trim(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE"))) & "(" & Mid(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME"), 1, 25) & ")" & Space(30 - Len(Trim(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE"))) & "(" & Mid(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME"), 1, 25) & ")")) & Chr(27) + "F" & Chr(15)
                        Rowprint = Rowprint & "DATE  :"
                        Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy")
                        Filewrite.WriteLine(Rowprint)
                        '6
                        Vrowcount = Vrowcount + 1
                        Pagesize = Pagesize + 1

                        For i = 0 To 78
                            Filewrite.Write("-")
                        Next
                        Filewrite.WriteLine()
                        '7
                        Vrowcount = Vrowcount + 1
                        Rowprint = "SLNo  CODE     ITEM DESCRIPTION                       QUANTITY   RATE   AMOUNT  "
                        Filewrite.WriteLine(Rowprint & Chr(15))
                        '8
                        Vrowcount = Vrowcount + 1
                        For i = 0 To 78
                            Filewrite.Write("-")
                        Next
                        Filewrite.WriteLine()
                        '9
                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine("{0,-12}{1,-40}", "LOCATION :", Chr(14) & Chr(15) & gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & poscode & "'"))
                        Filewrite.WriteLine(StrDup(20, "-"))
                        Vrowcount = Vrowcount + 2
                    End If
                End If
                With gdataset.Tables("ReportTable").Rows(rowj)
                    Rowprint = ""
                    Rowprint = Mid(CountItem, 1, 5) & "." & Space(5 - Len(Mid(CountItem, 1, 5)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMCODE") & ""), 1, 8) & Space(8 - Len(Mid(Trim(.Item("ITEMCODE") & ""), 1, 8))) & Space(1)
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMDESC") & "........................................"), 1, 38) & Space(38 - Len(Mid(Trim(.Item("ITEMDESC") & "........................................"), 1, 38)))
                    Rowprint = Rowprint & Mid(Val(.Item("QTY") & ""), 1, 3) & Space(3 - Len(Mid(Trim(.Item("QTY") & ""), 1, 3))) & Space(1)
                    Rowprint = Rowprint & Mid(Trim(.Item("UOM") & ""), 1, 5) & Space(5 - Len(Mid(Trim(.Item("UOM") & ""), 1, 5)))
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8)
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8)
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    Vrowcount = Vrowcount + 1
                    innercount = innercount + 1
                    If Vrowcount > 32 Then
                        Filewrite.WriteLine(StrDup(79, "-"))
                        Filewrite.WriteLine(Space(55) & "Continued....")
                        Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
                        Filewrite.WriteLine(Rowprint & Chr(15))
                        For i = 1 To 19
                            Filewrite.WriteLine("")
                        Next
                        innercount = 0
                        Vrowcount = 0
                        vpagenumber = Val(vpagenumber) + 1
                    End If
                End With
            Next rowj
            For i = 1 To 15 - innercount
                Filewrite.WriteLine()
            Next i
            ''If Vrowcount <= 32 Then
            ''    For i = 1 To 17 - Vrowcount
            ''        Filewrite.WriteLine("")
            ''    Next
            ''End If
            'Vrowcount = 0
            taxcount = 0
            Rowprint = Space(68) & "----------"
            Filewrite.WriteLine(Rowprint)
            taxcount = taxcount + 1
            Vrowcount = Vrowcount + 1
            Rowprint = Space(70) & Space(8 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 8)
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            taxcount = taxcount + 1
            sqlstring = "select isnull(sum(a.taxamount),0) as Taxamount,a.taxcode,b.itemtypedesc from kot_det a,"
            sqlstring = sqlstring & "itemtypemaster b where a.taxcode=b.itemtypecode and isnull(a.delflag,'')<>'Y' AND "
            sqlstring = sqlstring & " a.taxamount>0 AND a.billdetails='" & Trim(txt_BillNo.Text) & "'"
            sqlstring = sqlstring & "  group by a.taxcode,b.itemtypedesc"
            gconnection.getDataSet(sqlstring, "TaxDet")
            ''taxcount = 0
            For i = 0 To gdataset.Tables("TaxDet").Rows.Count - 1
                If i = 0 Then
                    Rowprint = "Bills Payable On Presentation                          "
                Else
                    Rowprint = Space(55)
                End If
                Rowprint = Rowprint & Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15)
                Rowprint = Rowprint & Space(15 - Len(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15)))
                Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 8))) & Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 8)

                Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                taxcount = taxcount + 1
                Vrowcount = Vrowcount + 1
            Next
            Rowprint = Space(68) & "----------"
            Filewrite.WriteLine(Rowprint)
            taxcount = taxcount + 1
            Vrowcount = Vrowcount + 1
            Rowprint = "                                                Total :"
            Rowprint = Rowprint & Space(70 - Len(Rowprint)) & Space(8 - Len(Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8)

            Filewrite.WriteLine(Rowprint)
            taxcount = taxcount + 1
            Vrowcount = Vrowcount + 1
            Rowprint = Space(68) & "----------"
            Filewrite.WriteLine(Rowprint)
            taxcount = taxcount + 1
            Vrowcount = Vrowcount + 1
            'member NAME
            If Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) = "ROOM" Then
                Rowprint = Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) & ":"
                Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("ROOMNO") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("GUEST")) & ")")
            Else
                Rowprint = Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) & ":"
                Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MCODE")) & ")")
            End If
            'If Len(Rowprint) < 50 Then
            '    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
            '    Filewrite.WriteLine()
            'Else
            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 60) & Chr(27) + "F" & Chr(15))
            'Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
            'End If

            taxcount = taxcount + 1
            Vrowcount = Vrowcount + 1
            Rowprint = Chr(15) & Chr(27) + "E" & RupeesToWord(Val(Format(TaxAmount + TotalAmount, "0.00"))) & Chr(27) + "F" & Chr(15)
            Filewrite.WriteLine(UCase(Rowprint))
            Vrowcount = Vrowcount + 1
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            taxcount = taxcount + 1
            Vrowcount = Vrowcount + 1
            Rowprint = Mid("BILL AMOUNT:", 1, 65) & Space(65 - Len(Mid("BILL AMOUNT:", 1, 65)))
            Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(TaxAmount + TotalAmount, "0.00") & Chr(27) + "F" & Chr(15)
            Filewrite.WriteLine(Rowprint)
            taxcount = taxcount + 1
            Vrowcount = Vrowcount + 1
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine("")
            Vrowcount = Vrowcount + 1
            taxcount = taxcount + 1
            Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            taxcount = taxcount + 1
            Dim sstring As String
            sstring = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
            sstring = sstring & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
            sstring = sstring & " WHERE D.Billdetails = '" & BillNo & "' "
            sstring = sstring & " AND ISNULL(KotStatus,'N')='N'"
            sstring = sstring & " order by d.billdetails"
            gconnection.getDataSet(sstring, "rTable")
            For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
            Next
            If Len(Kot) < 31 Then
                Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
                taxcount = taxcount + 1
            Else
                Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                Filewrite.WriteLine(Rowprint)
                Rowprint = "             " & Mid(Kot, 31, 30) & "."
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 2
                taxcount = taxcount + 2
            End If
            If Trim(Txt_Remarks.Text) <> "" Then
                If Len(Trim(Txt_Remarks.Text)) < 65 Then
                    Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                    Vrowcount = Vrowcount + 1
                    taxcount = taxcount + 1
                Else
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                    Vrowcount = Vrowcount + 2
                    taxcount = taxcount + 2
                End If
            End If
            For i = 1 To 23 - taxcount
                Filewrite.WriteLine("")
            Next

            'If Vrowcount <= 32 Then
            '    For i = 1 To 10
            '        Filewrite.WriteLine("")
            '    Next
            'End If
            'If Vrowcount > 32 Then
            '    For i = 1 To 77 - Vrowcount
            '        Filewrite.WriteLine("")
            '    Next
            'End If
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
    Public Sub billprint_new()
        Randomize()
        Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
        Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword As String
        Dim BillNo, sql, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage As Double
        Dim ds As New DataSet
        Dim Otherbool, boolOtherBill As Boolean
        Dim Filewrite As StreamWriter
        Dim vpagenumber, Vrowcount, vrowcount_page As Long
        Dim headercount As Double
        Dim SSQLROOM As String
        gCompanyname = MyCompanyName
        gCompanyAddress(0) = Address1
        gCompanyAddress(1) = Address2
        Gheader = "TAX  INVOICE"
        vpagenumber = 1
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
            Otherbool = True
        Else
            Otherbool = False
        End If
        If Otherbool = True Then
            billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_BillNo.Text) & "'"
        Else
            billdetails = "'" & Trim(Me.txt_BillNo.Text) & "'"
        End If
        ''sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid "
        ''sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' ORDER BY D.BillDetails "
        'sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,ISNULL(CHKID,'') AS CHKID,ISNULL(ROOMNO,'') AS ROOMNO,ISNULL(GUEST,'') AS GUEST "
        'sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' ORDER BY D.BillDetails "

        sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,"
        sql = sql & "D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,"
        sql = sql & "D.RATE,AMOUNT,TAXTYPE,ISNULL(TAXPERC,0) AS TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,"
        sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,"
        sql = sql & "ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
        sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
        sql = sql & " WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' "
        sql = sql & " ORDER BY D.BillDetails"
        gconnection.getDataSet(sql, "ReportTable")
        Dim adduserid As String
        adduserid = ""
        If gdataset.Tables("ReportTable").Rows.Count > 0 Then
            adduserid = Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID"))
            Filewrite = File.AppendText(vFilepath)
            vline = ""
            BillNo = Trim(gdataset.Tables("ReportTable").Rows(0).Item("BillDetails"))
            taxpercentage = Val(gdataset.Tables("ReportTable").Rows(0).Item("TaxPerc"))
            Kot = ""
            For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                CountItem = CountItem + 1
                boolOtherBill = False
                headercount = 1
                If Trim(BillNo) <> Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")) Then
                    '***********change on 140508****************************
                    If Vrowcount > 31 Then
                        'vrowcount_page = Vrowcount - ((Int(Vrowcount / 40)) * 40)

                        'If vrowcount_page <= 40 Then
                        'For i = 1 To 40 - vrowcount_page
                        'Filewrite.WriteLine("")
                        'Next
                        'End If
                    Else
                        If Vrowcount < 18 Then
                            For i = 1 To 17 - Vrowcount
                                Filewrite.WriteLine("")
                            Next
                            Vrowcount = 17
                        End If

                    End If
                    '*******************************************************
                    '   Vrowcount = 0
                    If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "ROOM" Then
                        Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                        Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("GUEST") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("ROOMNO")) & ")")
                    Else
                        Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                        Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE")) & ")")
                    End If
                    If Len(Rowprint) < 45 Then
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                        ' Filewrite.WriteLine()
                    Else
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                        '   Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                    End If
                    Vrowcount = Vrowcount + 1
                    Rowprint = Space(66) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    Rowprint = Space(68) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    '3
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
                    Else
                        Rowprint = "Bills Payable On Presentation"
                    End If
                    Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
                    Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                    '4
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("N O  T I P P I N G")
                    Rowprint = Space(48) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    '5
                    Vrowcount = Vrowcount + 1
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Our VAT No : 19450049091                         Total :"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
                    Else
                        Rowprint = "                                                 Total :"
                    End If
                    Rowprint = Rowprint & Space(67 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
                    Filewrite.WriteLine(Rowprint)
                    '6
                    Vrowcount = Vrowcount + 1
                    RoundOff = Val(TaxAmount + TotalAmount)
                    round = CStr(RoundOff)
                    If round.IndexOf(".") <= 0 Then
                        round = round.Insert(round.Length - 1, ".00")
                    End If
                    If Val(Split(round, ".")(1)) >= 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    Else
                        RoundOff = Math.Floor(RoundOff)
                    End If
                    If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                        RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                        Rowprint = "                                           Rounded Off :(+)"
                    Else
                        RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                        Rowprint = "                                           Rounded Off :(-)"
                    End If
                    Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
                    Filewrite.WriteLine(Rowprint)
                    '7
                    Vrowcount = Vrowcount + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    '8
                    Vrowcount = Vrowcount + 1
                    rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))
                    Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(Math.Round(TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
                    Filewrite.WriteLine(Rowprint)
                    '9
                    Vrowcount = Vrowcount + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine("")
                    '10
                    Vrowcount = Vrowcount + 1
                    Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
                    Filewrite.WriteLine(Rowprint)
                    '11
                    Vrowcount = Vrowcount + 1
                    'Dim ssql As String
                    sql = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
                    sql = sql & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
                    sql = sql & " WHERE D.Billdetails = '" & BillNo & "' "
                    sql = sql & " AND ISNULL(KotStatus,'N')='N'"
                    sql = sql & " order by d.billdetails"
                    gconnection.getDataSet(sql, "rTable")
                    For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                        Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
                    Next
                    If Len(Kot) < 31 Then
                        Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                        Filewrite.WriteLine(Rowprint)
                        Filewrite.WriteLine()
                        Vrowcount = Vrowcount + 2
                    Else
                        Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 2
                    End If
                    '13
                    Kot = ""
                    'If Trim(Txt_Remarks.Text) <> "" Then
                    If Len(Trim(Txt_Remarks.Text)) < 65 Then
                        Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                        Filewrite.WriteLine()
                        Vrowcount = Vrowcount + 2
                    Else
                        Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                        Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                        Vrowcount = Vrowcount + 2
                    End If
                    'End If
                    '15
                    'sandy
                    If Vrowcount > 33 Then
                        vrowcount_page = Vrowcount - ((Int(Vrowcount / 33)) * 33)
                    Else
                        vrowcount_page = Vrowcount
                    End If

                    If vrowcount_page <= 33 Then
                        For i = 1 To 33 - vrowcount_page
                            Filewrite.WriteLine("")
                        Next
                    End If
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    'Filewrite.WriteLine("")
                    'Filewrite.WriteLine("")
                    'Filewrite.WriteLine("")
                    'Filewrite.WriteLine("")
                    'Filewrite.WriteLine("")

                    BillNo = gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")
                    Kot = ""
                    TotalAmount = 0
                    TaxAmount = 0
                    taxpercentage = Val(gdataset.Tables("ReportTable").Rows(rowj).Item("TaxPerc"))
                    Vrowcount = 0
                    boolOtherBill = True
                    CountItem = 1
                End If

                '24+17 = total length
                'changable one

                ''change on 31.05 begin
                If (Vrowcount = 0) Then


                    If headercount = 1 Then

                        Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(15) & Chr(27) & Chr(71) & Space(6) & gCompanyname & Chr(20) & Chr(27) & Chr(72)
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(13) & gCompanyAddress(0)
                        Filewrite.WriteLine(Rowprint)
                        'Rowprint = Space(13) & gCompanyAddress(1)
                        'Filewrite.WriteLine(Rowprint)
                    Else
                        '''''''Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(1) & Chr(20) & Chr(27) & Chr(72)
                        '''''''Filewrite.WriteLine(Rowprint)
                        '''''''Rowprint = Space(1)
                        '''''''Filewrite.WriteLine(Rowprint)
                        '''''''Rowprint = Space(1)
                        '''''''Filewrite.WriteLine(Rowprint)
                        Filewrite.WriteLine(" ")
                        Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(15) & Chr(27) & Chr(71) & Space(1) & Chr(20) & Chr(27) & Chr(72)
                        Filewrite.WriteLine(Rowprint)
                        'Rowprint = Space(1)
                        'Filewrite.WriteLine(Rowprint)
                        'Rowprint = Space(1)
                        'Filewrite.WriteLine(Rowprint)
                    End If
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Gheader = " TAX  INVOICE "
                    Else
                        Gheader = " CREDIT  MEMO "
                    End If

                    'Filewrite.WriteLine("")
                    Rowprint = Chr(18) & Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "BILL NO :"
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(BillNo) & Chr(27) + "F" & Chr(18)
                    Filewrite.Write(Rowprint)
                    Rowprint = Chr(15) & Space(38 - Len(Trim(BillNo)))
                    Rowprint = Rowprint & "  TIME  :"
                    'Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "hh:mm:ss")
                    Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "T")
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "SERVER  :"
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE"))
                    Filewrite.Write(Rowprint)
                    Rowprint = "(" & Mid(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME"), 1, 30) & ")" & Space(30 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE") & "(" & gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME") & ")"), 1, 25))) & Chr(27) + "F" & Chr(15)
                    Rowprint = Rowprint & "DATE  :"
                    Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy")
                    Filewrite.WriteLine(Rowprint)
                    Pagesize = Pagesize + 1

                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    Rowprint = "SLNo  CODE  ITEM DESCRIPTION                      QUANTITY   RATE   AMOUNT  "
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    Vrowcount = 9
                End If

                With gdataset.Tables("ReportTable").Rows(rowj)
                    Rowprint = ""
                    Rowprint = Mid(CountItem, 1, 5) & "." & Space(5 - Len(Mid(CountItem, 1, 5)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMCODE") & ""), 1, 6) & Space(6 - Len(Mid(Trim(.Item("ITEMCODE") & ""), 1, 6)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMDESC") & ""), 1, 38) & Mid(Trim(".............................."), 1, 38 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 38)))
                    Rowprint = Rowprint & Mid(Val(.Item("QTY") & ""), 1, 3) & Space(3 - Len(Mid(Trim(.Item("QTY") & ""), 1, 3))) & Space(1)
                    Rowprint = Rowprint & Mid(Trim(.Item("UOM") & ""), 1, 5) & Space(5 - Len(Mid(Trim(.Item("UOM") & ""), 1, 5)))
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8)
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8)
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    Vrowcount = Vrowcount + 1
                End With
            Next rowj

            '*********************Change on 150408***********************
            If Vrowcount > 32 Then
                vrowcount_page = Vrowcount - ((Int(Vrowcount / 32)) * 32)

                If vrowcount_page <= 32 Then
                    For i = 1 To 32 - vrowcount_page
                        Filewrite.WriteLine("")
                    Next
                End If
            Else
                If Vrowcount <= 17 Then
                    For i = 1 To 17 - Vrowcount
                        Filewrite.WriteLine("")
                    Next
                    Vrowcount = 17
                End If

            End If
            '************************************************************
            If Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) = "ROOM" Then
                Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10)))
                Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("GUEST") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("ROOMNO")) & ")")
            Else
                Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10)))
                Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MCODE")) & ")")
            End If
            If Len(Rowprint) < 45 Then
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                ' Filewrite.WriteLine()
            Else
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                '   Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
            End If
            Vrowcount = Vrowcount + 1
            Rowprint = Space(66) & "----------"
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            Rowprint = Space(68) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            '3
            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
            ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
            Else
                Rowprint = "Bills Payable On Presentation"
            End If
            Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
            Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
            '4
            Vrowcount = Vrowcount + 1
            Filewrite.Write("N O  T I P P I N G")
            Rowprint = Space(48) & "----------"
            Filewrite.WriteLine(Rowprint)
            '5
            Vrowcount = Vrowcount + 1
            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                Rowprint = "Our VAT No : 19450049091                         Total :"
            ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
            Else
                Rowprint = "                                                 Total :"
            End If
            Rowprint = Rowprint & Space(67 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
            Filewrite.WriteLine(Rowprint)
            '6
            Vrowcount = Vrowcount + 1
            RoundOff = Val(TaxAmount + TotalAmount)
            round = CStr(RoundOff)
            If round.IndexOf(".") <= 0 Then
                round = round.Insert(round.Length - 1, ".00")
            End If
            If Val(Split(round, ".")(1)) >= 50 Then
                RoundOff = Math.Ceiling(RoundOff)
            Else
                RoundOff = Math.Floor(RoundOff)
            End If
            If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                Rowprint = "                                           Rounded Off :(+)"
            Else
                RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                Rowprint = "                                           Rounded Off :(-)"
            End If
            Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
            Filewrite.WriteLine(Rowprint)
            '7
            Vrowcount = Vrowcount + 1
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            '8
            Vrowcount = Vrowcount + 1
            rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))
            Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
            Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(Math.Round(TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
            Filewrite.WriteLine(Rowprint)
            '9
            Vrowcount = Vrowcount + 1
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine("")
            '10
            Vrowcount = Vrowcount + 1
            Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
            Filewrite.WriteLine(Rowprint)
            '11
            Vrowcount = Vrowcount + 1
            Dim ssql As String
            ssql = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
            ssql = ssql & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
            ssql = ssql & " WHERE D.Billdetails = '" & BillNo & "' "
            ssql = ssql & " AND ISNULL(KotStatus,'N')='N'"
            ssql = ssql & " order by d.billdetails"
            gconnection.getDataSet(ssql, "rTable")
            For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
            Next
            If Len(Kot) < 31 Then
                Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                Filewrite.WriteLine(Rowprint)
                Filewrite.WriteLine()
                Vrowcount = Vrowcount + 2
            Else
                Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                Filewrite.WriteLine(Rowprint)
                Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 2
            End If
            '13
            Kot = ""
            If Trim(Txt_Remarks.Text) <> "" Then
                If Len(Trim(Txt_Remarks.Text)) < 65 Then
                    Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                    Filewrite.WriteLine()
                    Vrowcount = Vrowcount + 2
                Else
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                    Vrowcount = Vrowcount + 2
                End If
            End If
            '15
            'sandy
            If Vrowcount > 32 Then
                Vrowcount = Vrowcount - ((Int(Vrowcount / 32)) * 32)

            End If
            If Vrowcount < 32 Then
                For i = 1 To 32 - Vrowcount
                    Filewrite.WriteLine("")
                Next
            End If
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
            Filewrite.WriteLine("")
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

    Public Sub BillPrintOperationold()
        Randomize()
        Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
        Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword As String
        Dim BillNo, sql, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage As Double
        Dim ds As New DataSet
        Dim Otherbool, boolOtherBill As Boolean
        Dim Filewrite As StreamWriter
        Dim vpagenumber, Vrowcount As Long
        Dim headercount As Double
        gCompanyname = MyCompanyName
        gCompanyAddress(0) = Address1
        gCompanyAddress(1) = Address2
        Gheader = "TAX  INVOICE"
        vpagenumber = 1
        vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
            Otherbool = True
        Else
            Otherbool = False
        End If
        If Otherbool = True Then
            billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_BillNo.Text) & "'"
        Else
            billdetails = "'" & Trim(Me.txt_BillNo.Text) & "'"
        End If
        sql = "SELECT D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,ITEMTYPE,BILLDATE,BILLTIME "
        sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' ORDER BY D.BillDetails "
        gconnection.getDataSet(sql, "ReportTable")
        If gdataset.Tables("ReportTable").Rows.Count > 0 Then
            Filewrite = File.AppendText(vFilepath)
            vline = ""
            BillNo = Trim(gdataset.Tables("ReportTable").Rows(0).Item("BillDetails"))
            taxpercentage = Val(gdataset.Tables("ReportTable").Rows(0).Item("TaxPerc"))
            Kot = ""
            For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                CountItem = CountItem + 1
                boolOtherBill = False
                headercount = 1
                If Trim(BillNo) <> Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")) Then
                    'Modified on 21 Mar'08
                    'Mk Kannan
                    'Begin
                    If Vrowcount <= 17 Then
                        For i = 1 To 17 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If

                    Vrowcount = 0

                    Rowprint = Mid(Trim(cbo_PaymentMode.Text), 1, 10) & ":" & Space(11 - Len(Mid(Trim(cbo_PaymentMode.Text), 1, 10)))
                    Rowprint = Rowprint & Trim(Me.txt_MemberName.Text & "(" & Trim(Me.txt_MemberCode.Text) & ")")
                    If Len(Rowprint) < 45 Then
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine()
                    Else
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                    End If
                    Vrowcount = Vrowcount + 2
                    'End

                    'Begin 21 Mar'08

                    Rowprint = Space(66) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    Rowprint = Space(68) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
                    Else
                        Rowprint = "Bills Payable On Presentation"
                    End If
                    Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
                    Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("N O  T I P P I N G")
                    Rowprint = Space(48) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Our VAT No : 19450049091                         Total :"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
                    Else
                        Rowprint = "                                                 Total :"
                    End If
                    Rowprint = Rowprint & Space(67 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    RoundOff = Val(TaxAmount + TotalAmount)
                    round = CStr(RoundOff)
                    If round.IndexOf(".") <= 0 Then
                        round = round.Insert(round.Length - 1, ".00")
                    End If
                    If Val(Split(round, ".")(1)) >= 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    Else
                        RoundOff = Math.Floor(RoundOff)
                    End If
                    If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                        RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                        Rowprint = "                                           Rounded Off :(+)"
                    Else
                        RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                        Rowprint = "                                           Rounded Off :(-)"
                    End If
                    Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    Vrowcount = Vrowcount + 1
                    rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))

                    Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
                    'Rowprint = Rowprint & Format(Math.Round(TaxAmount + TotalAmount), "0.00")

                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(Math.Round(TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine("")
                    Vrowcount = Vrowcount + 1
                    Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1


                    Dim ssql As String
                    'Dim i As Integer
                    ssql = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
                    ssql = ssql & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
                    ssql = ssql & " WHERE D.Billdetails = '" & BillNo & "' "
                    ssql = ssql & " AND ISNULL(KotStatus,'N')='N'"
                    ssql = ssql & " order by d.billdetails"
                    gconnection.getDataSet(ssql, "rTable")
                    For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                        Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
                    Next


                    'printing kot
                    '===============




                    If Len(Kot) < 31 Then
                        Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1
                    Else
                        Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 2
                    End If
                    Kot = ""

                    'Modified on 21 Mar'08
                    'MK Kannan
                    'Begin
                    'Filewrite.WriteLine(Trim(Txt_Remarks.Text))
                    If Trim(Txt_Remarks.Text) <> "" Then
                        If Len(Trim(Txt_Remarks.Text)) < 65 Then
                            Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                            Vrowcount = Vrowcount + 1
                        Else
                            Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                            Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                            Vrowcount = Vrowcount + 2
                        End If
                    End If
                    'End

                    'Modified on 21 Mar'08
                    'MK Kannan
                    'Begin
                    If Vrowcount <= 24 Then
                        For i = 1 To 24 - Vrowcount
                            Filewrite.WriteLine("")
                        Next
                    End If
                    'End

                    'End 21 Mar'08

                    'Rowprint = Space(70) & "----------"
                    'Filewrite.WriteLine(Rowprint)
                    'Rowprint = Space(74) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
                    'Filewrite.WriteLine(Rowprint)
                    'If Format(Val(taxpercentage), "0.00") = "12.50" Then
                    '    Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
                    'ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                    '    Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
                    'Else
                    '    Rowprint = "Bills Payable On Presentation"
                    'End If
                    'Rowprint = Rowprint & Space(74 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
                    'Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                    'Filewrite.WriteLine("N O  T I P P I N G")
                    'Rowprint = Space(70) & "----------"
                    'Filewrite.WriteLine(Rowprint)
                    'If Format(Val(taxpercentage), "0.00") = "12.50" Then
                    '    Rowprint = "Our VAT No : 19450049091                         Total :"
                    'ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                    '    Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
                    'Else
                    '    Rowprint = "                                                 Total :"
                    'End If
                    'Rowprint = Rowprint & Space(74 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
                    'Filewrite.WriteLine(Rowprint)
                    'RoundOff = Val(TaxAmount + TotalAmount)
                    'round = CStr(RoundOff)
                    'If round.IndexOf(".") <= 0 Then
                    '    round = round.Insert(round.Length - 1, ".00")
                    'End If
                    'If Val(Split(round, ".")(1)) >= 50 Then
                    '    RoundOff = Math.Ceiling(RoundOff)
                    'Else
                    '    RoundOff = Math.Floor(RoundOff)
                    'End If
                    'If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                    '    RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                    '    Rowprint = "                                           Rounded Off :(+)"
                    'Else
                    '    RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                    '    Rowprint = "                                           Rounded Off :(-)"
                    'End If
                    'Rowprint = Rowprint & Space(74 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
                    'Filewrite.WriteLine(Rowprint)
                    'For i = 0 To 78
                    '    Filewrite.Write("-")
                    'Next
                    'Filewrite.WriteLine()
                    'rupeesword = ConvertRupees(Format(TaxAmount + TotalAmount, "0.00"))
                    'Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 70) & Space(72 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 70)))
                    'Rowprint = Rowprint & Format(Math.Round(TaxAmount + TotalAmount), "0.00")
                    'Filewrite.WriteLine(Rowprint)
                    'For i = 0 To 78
                    '    Filewrite.Write("-")
                    'Next
                    'Filewrite.WriteLine("")
                    'Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
                    'Filewrite.WriteLine(Rowprint)
                    'Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                    'Filewrite.WriteLine(Rowprint)
                    BillNo = gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")
                    Kot = ""
                    TotalAmount = 0
                    TaxAmount = 0
                    taxpercentage = Val(gdataset.Tables("ReportTable").Rows(rowj).Item("TaxPerc"))
                    Vrowcount = 0
                    boolOtherBill = True
                    CountItem = 1
                End If
                'Concatinating kot's
                '===================

                ''''If Kot <> gdataset.Tables("ReportTable").Rows(rowj).Item("Kotno") Then
                ''''    If Trim(Kot) <> "" Then
                ''''        Kot = Kot & "," & gdataset.Tables("ReportTable").Rows(rowj).Item("Kotno")
                ''''    Else
                ''''        Kot = gdataset.Tables("ReportTable").Rows(rowj).Item("Kotno")
                ''''    End If
                ''''End If



                If (Vrowcount = 0 Or Vrowcount >= 17) Then
                    If Vrowcount >= 17 Then
                        'Begin 22 Mar'08
                        headercount = 1
                        Vrowcount = 0
                        Rowprint = Mid(Trim(cbo_PaymentMode.Text), 1, 10) & ":" & Space(11 - Len(Mid(Trim(cbo_PaymentMode.Text), 1, 10)))
                        Rowprint = Rowprint & Trim(Me.txt_MemberName.Text & "(" & Trim(Me.txt_MemberCode.Text) & ")")
                        If Len(Rowprint) < 45 Then
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                            Filewrite.WriteLine()
                        Else
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                        End If
                        'End
                        Vrowcount = Vrowcount + 2
                        'Begin 21 Mar'08

                        'Rowprint = Space(66) & "----------"
                        'Filewrite.WriteLine(Rowprint)
                        'Vrowcount = Vrowcount + 1
                        'Rowprint = Space(67) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
                        'Filewrite.WriteLine("")
                        'Vrowcount = Vrowcount + 1
                        If Format(Val(taxpercentage), "0.00") = "12.50" Then
                            Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
                        ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                            Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
                        Else
                            Rowprint = "Bills Payable On Presentation"
                        End If
                        'Rowprint = Rowprint & Space(67 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
                        Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                        Vrowcount = Vrowcount + 1
                        Filewrite.Write("N O  T I P P I N G")
                        'Rowprint = Space(48) & "----------"
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        If Format(Val(taxpercentage), "0.00") = "12.50" Then
                            Rowprint = "Our VAT No : 19450049091                                "
                        ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                            Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06               "
                        Else
                            Rowprint = "                                                        "
                        End If
                        'Rowprint = Rowprint & Space(67 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1
                        RoundOff = Val(TaxAmount + TotalAmount)
                        round = CStr(RoundOff)
                        If round.IndexOf(".") <= 0 Then
                            round = round.Insert(round.Length - 1, ".00")
                        End If
                        If Val(Split(round, ".")(1)) >= 50 Then
                            RoundOff = Math.Ceiling(RoundOff)
                        Else
                            RoundOff = Math.Floor(RoundOff)
                        End If
                        If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                            RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                            Rowprint = "                                           Rounded Off :(+)"
                        Else
                            RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                            Rowprint = "                                           Rounded Off :(-)"
                        End If
                        Rowprint = Rowprint & Space(69 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
                        'Filewrite.WriteLine(Rowprint)
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        For i = 0 To 78
                            'Filewrite.Write("-")
                        Next
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))

                        Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
                        Rowprint = Rowprint & Format(Math.Round(TaxAmount + TotalAmount), "0.00")
                        'Filewrite.WriteLine(Rowprint)
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        For i = 0 To 78
                            Filewrite.Write("-")
                        Next
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1

                        ''=====================================================
                        '''' change today
                        '''''If Len(Kot) < 31 Then
                        '''''    Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                        '''''    Filewrite.WriteLine(Rowprint)
                        '''''    Vrowcount = Vrowcount + 1
                        '''''Else
                        '''''    Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                        '''''    Filewrite.WriteLine(Rowprint)
                        '''''    Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                        '''''    Filewrite.WriteLine(Rowprint)
                        '''''    Vrowcount = Vrowcount + 2
                        '''''End If

                        If Len(Kot) < 31 Then
                            Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                            Filewrite.WriteLine(" ")
                            Vrowcount = Vrowcount + 1
                        Else
                            Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                            Filewrite.WriteLine(" ")
                            Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                            Filewrite.WriteLine(" ")
                            Vrowcount = Vrowcount + 2
                        End If
                        '=======================================================
                        'Modified on 21 Mar'08
                        'MK Kannan
                        'Begin
                        'Filewrite.WriteLine(Trim(Txt_Remarks.Text))
                        If Trim(Txt_Remarks.Text) <> "" Then
                            If Len(Trim(Txt_Remarks.Text)) < 65 Then
                                Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                                Vrowcount = Vrowcount + 1
                            Else
                                Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                                Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                                Vrowcount = Vrowcount + 2
                            End If
                        End If
                        'End

                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(Space(65) & "Continued....")
                        headercount = headercount + 1
                        Vrowcount = Vrowcount + 2
                        'Modified on 21 Mar'08
                        'MK Kannan
                        'Begin
                        If Vrowcount <= 24 Then
                            For i = 1 To 24 - Vrowcount
                                Filewrite.WriteLine("")
                            Next
                        End If
                        'End If
                        'End

                        'End 22 Mar'08
                    End If
                    If headercount = 1 Then
                        'vheader = Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(10) & Gheader & Chr(20) & Chr(27) & Chr(72)
                        Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & gCompanyname & Chr(20) & Chr(27) & Chr(72)
                        'Rowprint = Chr(14) & Chr(15) & Space((40 / 2) - (Len(gCompanyname) / 2)) & gCompanyname
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(13) & gCompanyAddress(0)
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(13) & gCompanyAddress(1)
                        Filewrite.WriteLine(Rowprint)
                    Else
                        'vheader = Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(10) & Gheader & Chr(20) & Chr(27) & Chr(72)
                        Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(1) & Chr(20) & Chr(27) & Chr(72)
                        'Rowprint = Chr(14) & Chr(15) & Space((40 / 2) - (Len(gCompanyname) / 2)) & gCompanyname
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(1)
                        Filewrite.WriteLine(Rowprint)
                        Rowprint = Space(1)
                        Filewrite.WriteLine(Rowprint)
                    End If
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Gheader = " TAX  INVOICE "
                    Else
                        Gheader = " CREDIT  MEMO "
                    End If
                    Filewrite.WriteLine("")
                    Rowprint = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                    Filewrite.WriteLine(Rowprint)
                    'Modified on 16 Mar'08
                    'MK Kannan
                    'Begin
                    'Rowprint = "BILL NO  :" & Space(10 - Len(Mid("BILL NO   :", 1, 10)))
                    Rowprint = "BILL NO :"
                    'Rowprint = Rowprint & Chr(14) & Trim(BillNo)
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(BillNo) & Chr(27) + "F" & Chr(18)
                    Filewrite.Write(Rowprint)
                    'Rowprint = Chr(15) & Space(15 - Len(Trim(BillNo))) & Space(37)
                    Rowprint = Chr(15) & Space(40 - Len(Trim(BillNo)))
                    'Rowprint = Rowprint & "TIME  :" & Space(8 - Len(Mid(Trim("TIME  :"), 1, 8)))
                    Rowprint = Rowprint & "TIME  :"
                    Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "hh:mm:ss")
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "SERVER  :"
                    'Rowprint = Rowprint & Chr(14) & Trim(Me.txt_ServerCode.Text)
                    Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(Me.txt_ServerCode.Text)
                    Filewrite.Write(Rowprint)
                    'Rowprint = Chr(15) & "(" & Me.txt_ServerName.Text & ")" & Space(20 - Len(Mid(Trim(Me.txt_ServerCode.Text & "(" & Me.txt_ServerName.Text & ")"), 1, 20))) & Space(32)
                    Rowprint = "(" & Mid(Me.txt_ServerName.Text, 1, 25) & ")" & Space(30 - Len(Mid(Trim(Me.txt_ServerCode.Text & "(" & Me.txt_ServerName.Text & ")"), 1, 30))) & Chr(27) + "F" & Chr(15)
                    'Rowprint = Rowprint & "DATE  :" & Space(8 - Len(Mid(Trim("DATE  :"), 1, 8)))
                    Rowprint = Rowprint & "DATE  :"
                    Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy")
                    Filewrite.WriteLine(Rowprint)
                    Pagesize = Pagesize + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    Rowprint = "SLNo  CODE  ITEM DESCRIPTION                      QUANTITY   RATE   AMOUNT  "
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    Vrowcount = 9
                End If
                With gdataset.Tables("ReportTable").Rows(rowj)
                    Rowprint = ""
                    Rowprint = Mid(CountItem, 1, 5) & "." & Space(5 - Len(Mid(CountItem, 1, 5)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMCODE") & ""), 1, 6) & Space(6 - Len(Mid(Trim(.Item("ITEMCODE") & ""), 1, 6)))
                    'Modified on 06 Apr 08 for CSC Temporary Purpose
                    'Mk Kannan
                    'Begin
                    'If Trim(.Item("POSCODE")) = "54" Then
                    'Rowprint = Rowprint & Mid(Mid(Trim(.Item("ITEMDESC") & ""), 1, Len(Trim(.Item("itemdesc"))) - 6), 1, 38) & Mid(Trim(".............................."), 1, 38 - Len(Mid(Mid(Trim(.Item("ITEMDESC") & ""), 1, Len(Trim(.Item("itemdesc"))) - 6), 1, 38)))
                    'Else
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMDESC") & ""), 1, 38) & Mid(Trim(".............................."), 1, 38 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 38)))
                    'End If
                    'End
                    Rowprint = Rowprint & Mid(Val(.Item("QTY") & ""), 1, 3) & Space(3 - Len(Mid(Trim(.Item("QTY") & ""), 1, 3))) & Space(1)
                    Rowprint = Rowprint & Mid(Trim(.Item("UOM") & ""), 1, 5) & Space(5 - Len(Mid(Trim(.Item("UOM") & ""), 1, 5)))
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8)
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8)
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    Vrowcount = Vrowcount + 1
                End With
                'Modified on 21 Mar'08
                'Mk Kannan
                'Begin
                'If Vrowcount > 32 Then
                '    Filewrite.WriteLine(vline & Chr(12))
                '    Vrowcount = 0
                '    vpagenumber = Val(vpagenumber) + 1
                'End If
                'End
            Next rowj
            'Modified on 21 Mar'08
            'Mk Kannan
            'Begin
            If Vrowcount <= 17 Then
                For i = 1 To 17 - Vrowcount
                    Filewrite.WriteLine("")
                Next
            End If
            'Filewrite.WriteLine()
            'Filewrite.WriteLine()
            'Filewrite.WriteLine()
            'Filewrite.WriteLine()
            'Filewrite.WriteLine()
            'End

            Vrowcount = 0
            'Modified on 16 Mar'08
            'MK Kannan
            'Begin
            Rowprint = Mid(Trim(cbo_PaymentMode.Text), 1, 10) & ":" & Space(11 - Len(Mid(Trim(cbo_PaymentMode.Text), 1, 10)))
            Rowprint = Rowprint & Trim(Me.txt_MemberName.Text & "(" & Trim(Me.txt_MemberCode.Text) & ")")
            If Len(Rowprint) < 45 Then
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                Filewrite.WriteLine()
            Else
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
            End If
            Vrowcount = Vrowcount + 2
            'Rowprint = Mid(Trim(cbo_PaymentMode.Text), 1, 10) & Space(27 - Len(Mid(Trim(cbo_PaymentMode.Text), 1, 10)))
            'Filewrite.Write(Chr(14) & Chr(15) & Rowprint)
            'Rowprint = Chr(15) & ":" & Space(4) & "Mr." & Mid(Trim(Me.txt_MemberName.Text & "(" & Trim(Me.txt_MemberCode.Text) & ")"), 1, 25) & Space(40 - Len(Mid(Trim(Me.txt_MemberName.Text & "(" & Trim(Me.txt_MemberCode.Text) & ")"), 1, 40)))
            'Filewrite.WriteLine(Rowprint)
            'End
            Rowprint = Space(66) & "----------"
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            Rowprint = Space(69) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
            ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
            Else
                Rowprint = "Bills Payable On Presentation"
            End If
            Rowprint = Rowprint & Space(70 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
            Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
            Vrowcount = Vrowcount + 1
            Filewrite.Write("N O  T I P P I N G")
            'Vrowcount = Vrowcount + 1
            Rowprint = Space(48) & "----------"
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                Rowprint = "Our VAT No : 19450049091                         Total :"
            ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
            Else
                Rowprint = "                                                 Total :"
            End If
            Rowprint = Rowprint & Space(68 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            RoundOff = Val(TaxAmount + TotalAmount)
            round = CStr(RoundOff)
            If round.IndexOf(".") <= 0 Then
                round = round.Insert(round.Length - 1, ".00")
            End If
            If Val(Split(round, ".")(1)) >= 50 Then
                RoundOff = Math.Ceiling(RoundOff)
            Else
                RoundOff = Math.Floor(RoundOff)
            End If
            If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                Rowprint = "                                           Rounded Off :(+)"
            Else
                RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                Rowprint = "                                           Rounded Off :(-)"
            End If
            Rowprint = Rowprint & Space(70 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            Vrowcount = Vrowcount + 1
            rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))

            Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 65) & Space(65 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 65)))
            'Chr(18) & Chr(27) + "E" & Format(Math.Round(TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(18)
            Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(Math.Round(TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine("")
            Vrowcount = Vrowcount + 1
            Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
            Filewrite.WriteLine(Rowprint)
            Vrowcount = Vrowcount + 1
            Dim sstring As String
            sstring = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
            sstring = sstring & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
            sstring = sstring & " WHERE D.Billdetails = '" & BillNo & "' "
            sstring = sstring & " AND ISNULL(KotStatus,'N')='N'"
            sstring = sstring & " order by d.billdetails"
            gconnection.getDataSet(sstring, "rTable")

            For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
            Next

            If Len(Kot) < 31 Then
                Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
            Else
                Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                Filewrite.WriteLine(Rowprint)
                Rowprint = "             " & Mid(Kot, 31, 30) & "."
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 2
            End If
            'Modified on 21 Mar'08
            'MK Kannan
            'Begin
            'Filewrite.WriteLine(Trim(Txt_Remarks.Text))
            If Trim(Txt_Remarks.Text) <> "" Then
                If Len(Trim(Txt_Remarks.Text)) < 65 Then
                    Filewrite.WriteLine("             " & Trim(Txt_Remarks.Text))
                    Vrowcount = Vrowcount + 1
                Else
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                    Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                    Vrowcount = Vrowcount + 2
                End If
            End If
            'End

            'Modified on 21 Mar'08
            'MK Kannan
            'Begin
            If Vrowcount <= 24 Then
                For i = 1 To 24 - Vrowcount
                    Filewrite.WriteLine("")
                Next
            End If
            'End
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
    Private Sub cbo_SubPaymentMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_SubPaymentMode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txt_MemberCode.Visible = False Then
                txt_ServerCode.Focus()
            Else
                txt_MemberCode.Focus()
            End If
        End If
    End Sub
    Private Sub txt_BillAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BillAmount.LostFocus
        'Dim ROUNDOFF, AMT As Double
        'Dim ROUND As String
        'txt_BillAmount.Text = Format(Val(txt_BillAmount.Text), "0.00")
        'ROUNDOFF = txt_BillAmount.Text
        'ROUND = CStr(ROUNDOFF)
        'If ROUND.IndexOf(".") <= 0 Then
        '    ROUND = ROUND.Insert(ROUND.Length - 1, ".00")
        'End If
        'If Val(Split(ROUND, ".")(1)) >= 36 And Val(Split(ROUND, ".")(1)) <= 75 Then
        '    AMT = 0.5
        'ElseIf Val(Split(ROUND, ".")(1)) >= 0 And Val(Split(ROUND, ".")(1)) <= 35 Then
        '    AMT = 0.0
        'ElseIf Val(Split(ROUND, ".")(1)) >= 76 And Val(Split(ROUND, ".")(1)) <= 99 Then
        '    AMT = 1
        'End If
        'txt_BillAmount.Text = Format((Val(Split(txt_BillAmount.Text, ".")(0)) + Val(AMT)), "0.00")

    End Sub
    Function bill_roundoff()
        Dim ROUNDOFF As Double
        Dim ROUND As String
        txt_BillAmount.Text = Format(Val(txt_BillAmount.Text), "0.00")
        ROUNDOFF = Format(Val(txt_BillAmount.Text), "0.00")
        ROUND = CStr(Format(Val(ROUNDOFF), "0.00"))
        If Val(Mid(Split(ROUND, ".")(1), 2, 1)) > 0 And Val(Mid(Split(ROUND, ".")(1), 2, 1)) < 5 Then
            RNDOFF = 0
            AMT1 = 0.0
            Amt = 0
            Amt = Format(Val(AMT1) - (Format(Val(Mid(Split(ROUND, ".")(1), 2, 1)), "0.00") / 100), "0.00")
            RNDOFF = Amt
            txt_BillAmount.Text = Format(Val(txt_BillAmount.Text) + Amt, "0.00")
        ElseIf Val(Mid(Split(ROUND, ".")(1), 2, 1)) > 5 Then
            RNDOFF = 0
            AMT1 = IIf((10 - Val(Mid(Split(ROUND, ".")(1), 2, 1))) = 0, 1 + Val(Mid(Split(ROUND, ".")(1), 2, 1)), (10 - Val(Mid(Split(ROUND, ".")(1), 2, 1))) + Val(Mid(Split(ROUND, ".")(1), 2, 1)))
            AMT1 = AMT1 + (Val(Mid(Split(ROUND, ".")(1), 1, 1)) * 10)
            AMT1 = Format((AMT1 / 100), "0.00")
            Amt = Format(Val(AMT1) - (Format(Val(Split(txt_BillAmount.Text, ".")(1)), "0.00") / 100), "0.00")
            RNDOFF = Amt
            txt_BillAmount.Text = Format(Val(txt_BillAmount.Text) + Amt, "0.00")
        End If
        Exit Function

        'If ROUND.IndexOf(".") <= 0 Then
        '    ROUND = ROUND.Insert(ROUND.Length - 1, ".00")
        'End If
        'If Val(Split(ROUND, ".")(1)) >= 36 And Val(Split(ROUND, ".")(1)) <= 75 Then
        '    AMT1 = 0.5
        'ElseIf Val(Split(ROUND, ".")(1)) >= 0 And Val(Split(ROUND, ".")(1)) <= 35 Then
        '    AMT1 = 0.0
        'ElseIf Val(Split(ROUND, ".")(1)) >= 76 And Val(Split(ROUND, ".")(1)) <= 99 Then
        '    AMT1 = 1
        'End If
        'Amt = Format(Val(AMT1) - (Format(Val(Split(txt_BillAmount.Text, ".")(1)), "0.00") / 100), "0.00")

        Amt = 0

    End Function
    Private Sub KOT_Billing_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        finalbillbool = False
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
        ''For Loopindex = 0 To 3
        ''    locNumber = (AbsValue - (AbsValue Mod (10 ^ NumArray(Loopindex)))) / (10 ^ NumArray(Loopindex))
        ''    If locNumber > 99 Then
        ''        strText = strText & ConvertRupees(locNumber) & TxtArray(Loopindex)
        ''        AbsValue = AbsValue - (locNumber * (10 ^ NumArray(Loopindex)))
        ''    Else
        ''        If locNumber <> 0 Then
        ''            If locNumber > 19 Then
        ''                strText = strText & NumValString(((locNumber - (locNumber Mod 10)) / 10) * 10) & NumValString(locNumber Mod 10) & TxtArray(Loopindex)
        ''            Else
        ''                strText = strText & NumValString(locNumber) & TxtArray(Loopindex)
        ''            End If
        ''            AbsValue = AbsValue - (locNumber * (10 ^ NumArray(Loopindex)))
        ''        End If
        ''    End If
        ''Next Loopindex
        ''If AbsValue <> 0 Then
        ''    If AbsValue > 19 Then
        ''        strText = strText & NumValString(((AbsValue - (AbsValue Mod 10)) / 10) * 10) & NumValString(AbsValue Mod 10) & TxtArray(Loopindex)
        ''    Else
        ''        strText = strText & NumValString(AbsValue)
        ''    End If
        ''End If
        'If AbsValue <> 0 Then

        ConvertRupees = NumValString(AbsValue)
        End
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
    Private Sub ssGrid_LeaveCellEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssGrid.LeaveCell
        ssGrid.Row = ssGrid.ActiveRow
        ssGrid.Col = ssGrid.ActiveCol
        ssGrid.CellBorderColor = Color.White
        If ssGrid.ActiveCol = 4 Then
            Call Calculate()
        End If
    End Sub
    Private Sub ssGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssGrid.KeyDownEvent
        If e.keyCode = Keys.F3 And billstatus <> "ST" Then
            ssGrid.DeleteRows(ssGrid.ActiveRow, 1)
        ElseIf e.keyCode = Keys.Enter Then
            If ssGrid.ActiveCol = 1 Then
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
            ElseIf ssGrid.ActiveCol = 2 Then
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
            ElseIf ssGrid.ActiveCol = 3 Then
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
            ElseIf ssGrid.ActiveCol = 4 Then
                Call Calculate()
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow + 1)
            ElseIf ssGrid.ActiveCol = 5 Then
                Call Calculate()
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow + 1)
            End If
        End If
    End Sub
    Private Sub txt_BillNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BillNo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_BillNoHelp_Click(cmd_BillNoHelp, e)
        End If
    End Sub
    Private Sub GridLocking()
        Dim Row, Col As Integer
        ssGrid.Col = 15
        ssGrid.Row = ssGrid.ActiveRow
        For Row = 1 To 100
            For Col = 1 To 5
                ssGrid.Row = Row
                ssGrid.Col = 4
                ssGrid.Lock = True
            Next
        Next Row
    End Sub
    Private Sub PaymentGridLocking()
        '''Dim Row, Col As Integer
        '''ssgridPayment.Col = 6
        '''ssgridPayment.Row = ssgridPayment.ActiveRow
        '''For Row = 1 To 20
        '''    For Col = 3 To 4
        '''        ssgridPayment.Row = Row
        '''        ssgridPayment.Col = Col
        '''        ssgridPayment.Lock = True
        '''    Next
        '''Next Row
        '''ssgridPayment.Row = 1
        '''For Col = 3 To 4
        '''    ssgridPayment.Col = Col
        '''    ssgridPayment.Lock = False
        '''Next
    End Sub
    Private Sub GridUnLocking()
        Dim i, j As Integer
        For i = 1 To 100
            For j = 1 To 5
                ssGrid.Col = 4
                ssGrid.Row = i
                ssGrid.Lock = False
            Next j
        Next i
    End Sub

    Private Sub ssGrid_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles ssGrid.DblClick
        ssGrid.Col = 1
        ssGrid.Row = ssGrid.ActiveRow
        KotDetails = ""
        If Trim(ssGrid.Text) <> "" Then
            KotDetails = Trim(ssGrid.Text)
            Dim Kotentry As New KOTEntry(Trim(txt_BillNo.Text))
            Kotentry.FormBorderStyle = FormBorderStyle.FixedDialog
            Kotentry.MdiParent = MDIParentobj
            Me.Close()
            Kotentry.Show()
            Kotentry.KOTNoValidate(Trim(KotDetails))
            kotupdate = True
        Else
            kotupdate = False
        End If
    End Sub

    Private Sub ssGrid_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssGrid.Enter
        ssGrid.Row = ssGrid.ActiveRow
        ssGrid.Col = ssGrid.ActiveCol
        ssGrid.CellBorderColor = Color.Green
    End Sub

    Private Sub cmd_Back_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_Back.Click
        grp_Paymentmodeselection.Top = 1000
        grp_Carddetails.Top = 1000
        grp_Chequedetails.Top = 1000
    End Sub

    Private Sub cmd_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancel.Click
        '' ssgridPayment.ClearRange(1, 1, -1, -1, True)
        ''ssgridPayment.SetActiveCell(1, 1)
        txt_Cardholdername.Text = ""
        txt_PartialPayment.Text = ""
        txt_Chequeno.Text = ""
        txt_Draweebank.Text = ""
        txt_Typeofcard.Text = ""
        txt_Cardno.Text = ""
        'Call cmd_BillSettlement_Click(sender, e)
    End Sub
    Private Sub cmd_BillSettlement1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub ssgridPayment_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent)
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
                                If Val(Me.ssgridPayment.Text) = 0 Then
                                    If Trim(BillNonTaxBilldetails) <> "" Then
                                        Billdetailswise = BillNonTaxBilldetails
                                        If Trim(ssgridPayment.Text) = Trim(Billdetailswise) Then
                                            ssgridPayment.Col = 8
                                            ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                            ssgridPayment.Text = Format(Val(dblAmount1) - Val(dblAmount3), "0.00")
                                        Else
                                            ssgridPayment.Col = 8
                                            ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                            ssgridPayment.Text = Format(Val(dblBillNonTotalAmount), "0.00")
                                        End If
                                        ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                        ssgridPayment.Col = 8
                                        If Val(Me.ssgridPayment.Text) = 0 Then
                                            Exit Sub
                                        Else
                                            ssgridPayment.Col = 1
                                            ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                            ssgridPayment.Text = Trim(Billdetailswise)
                                            ssgridPayment.Col = 2
                                            ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                            ssgridPayment.Text = Format(CDate(dtp_BillDate.Value), "dd/MMM/yyyy")
                                            ssgridPayment.Col = 5
                                            ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                            ssgridPayment.Text = Trim(BillMcode)
                                            ssgridPayment.Col = 6
                                            ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                            ssgridPayment.Text = Trim(BillMname)
                                            ssgridPayment.Col = 7
                                            ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                            ssgridPayment.Text = Format(Val(dblBillNonTotalAmount), "0.00")
                                            ssgridPayment.Col = 1
                                            ssgridPayment.Row = ssgridPayment.ActiveRow
                                            Me.txt_PartialPayment.Text = Format(Val(dblBillNonTotalAmount), "0.00")
                                            Call FillPaymentmodeSettlement(ssgridPayment.ActiveRow + 1)
                                            ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                            ssgridPayment.Col = 3
                                            ssgridPayment.Lock = False
                                            ssgridPayment.Col = 4
                                            ssgridPayment.Lock = False
                                            BillNonTaxBilldetails = ""
                                            ssgridPayment.SetActiveCell(2, ssgridPayment.ActiveRow + 1)
                                            ssgridPayment.Focus()
                                        End If
                                    End If
                                Else
                                    ssgridPayment.Col = 8
                                    ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                    ssgridPayment.Text = Format(Val(dblAmount1) - Val(dblAmount3), "0.00")
                                    ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                    ssgridPayment.Col = 8
                                    If Val(Me.ssgridPayment.Text) = 0 Then
                                        cmd_Save.Focus()
                                        Exit Sub
                                    Else
                                        ssgridPayment.Col = 1
                                        ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                        ssgridPayment.Text = Trim(Billdetailswise)
                                        ssgridPayment.Col = 2
                                        ssgridPayment.Row = ssgridPayment.ActiveRow + 1
                                        ssgridPayment.Text = Format(CDate(dtp_BillDate.Value), "dd/MMM/yyyy")
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

    Private Sub ssgridPayment_LeaveCell(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent)
        Dim varPaymentMode, VarKotdetails As String
        ssgridPayment.Col = 3
        ssgridPayment.Row = ssGrid.ActiveRow
        If Trim(ssgridPayment.Text) <> "" Then
            For i = 1 To ssgridPayment.DataRowCnt
                ssgridPayment.ActiveCol = 1
                ssgridPayment.Row = ssGrid.ActiveRow
                VarKotdetails = Trim(ssgridPayment.Text)
                ssgridPayment.ActiveCol = 3
                ssgridPayment.Row = ssGrid.ActiveRow
                varPaymentMode = Trim(ssgridPayment.Text)
                ssgridPayment.ActiveCol = 3
                ssgridPayment.Row = ssGrid.ActiveRow
                If Trim(ssGrid.Text) = Trim(VarKotdetails) And ssGrid.Row <> ssGrid.ActiveRow Then
                    If Trim(ssGrid.Text) = Trim(varPaymentMode) And ssGrid.Row <> ssGrid.ActiveRow Then
                        ssGrid.Row = ssGrid.ActiveRow
                        ssGrid.ClearRange(1, ssGrid.ActiveRow, 7, ssGrid.ActiveRow, True)
                        MsgBox("PaymentMode already Selected", vbInformation + MsgBoxStyle.OKOnly, MyCompanyName)
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
    Private Sub FillDefaultPayment()
        'Dim Sqlstring As String
        'Sqlstring = "SELECT ISNULL(BillPaymentMode,'') AS BillPaymentMode FROM POSSETUP"
        'gconnection.getDataSet(Sqlstring, "POSSETUP")
        'If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
        '    DefaultPayment = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPaymentMode"))
        'Else
        '    DefaultPayment = "CREDIT"
        'End If
        Dim Sqlstring As String
        Sqlstring = "SELECT ISNULL(BillPaymentMode,'') AS BillPaymentMode, ISNULL(BILLROUNDOFF,'') AS BILLROUNDOFF,ISNULL(SETTLEMENT,'') AS SETTLEMENT FROM POSSETUP"
        gconnection.getDataSet(Sqlstring, "POSSETUP")
        If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
            DefaultPayment = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPaymentMode"))
            BILLROUNDYESNO = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BILLROUNDOFF"))
            SMENTTYPE = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("SETTLEMENT"))
        Else
            DefaultPayment = "CREDIT"
        End If
    End Sub
    Private Function CHECK_BILLEXIST(ByVal BILLNO As String) As Boolean
        Dim SSQL As String
        If Trim(BILLNO) <> "" Then
            SSQL = "SELECT * FROM BILL_HDR WHERE ltrim(rtrim(BILLNO))='" & Trim(BILLNO) & "'"
            gconnection.getDataSet(SSQL, "BILL_hdr")
            If gdataset.Tables("BILL_hdr").Rows.Count > 0 Then
                CHECK_BILLEXIST = True
                duplicateflag = True
                'If MsgBox("Do You Want Update Kotposdoc.......", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
                '    SSQL = "SELECT MAX(BILLNO) AS BILLNO FROM BILL_HDR"
                '    gconnection.getDataSet(SSQL, "BILL_hdr1")
                '    If gdataset.Tables("BILL_hdr1").Rows.Count > 0 Then
                '        SSQL = "Update PoSKotDoc Set DocNo = " & Val(gdataset.Tables("BILL_hdr1").Rows(0).Item("BILLNO")) & " Where DocType = 'CSC'"
                '        gconnection.dataOperation(6, SSQL, "PosKotDoc")
                '    End If
                'End If
                Exit Function
            Else
                duplicateflag = False
                CHECK_BILLEXIST = False
            End If
            SSQL = "SELECT * FROM BILL_DET WHERE ltrim(rtrim(BILLNO))='" & Trim(BILLNO) & "'"
            gconnection.getDataSet(SSQL, "BILL_DET")
            If gdataset.Tables("BILL_DET").Rows.Count > 0 Then
                CHECK_BILLEXIST = True
                duplicateflag = True
                Exit Function
            Else
                duplicateflag = False
                CHECK_BILLEXIST = False
            End If

            If CHECK_BILLEXIST = False Then
                SSQL = "select * from BILL_hdr where BILLdetails not in(select BILLdetails from BILL_det) and ltrim(rtrim(BILLNO))='" & Trim(BILLNO) & "'"
                gconnection.getDataSet(SSQL, "BILL_hdr")
                If gdataset.Tables("BILL_hdr").Rows.Count > 0 Then
                    CHECK_BILLEXIST = True
                    Exit Function
                Else
                    CHECK_BILLEXIST = False
                End If
            End If

            If CHECK_BILLEXIST = False Then
                SSQL = "SELECT BILLDETAILS ,BILLDATE FROM BILL_DET  WHERE  BILLDETAILS NOT IN (SELECT BILLDETAILS FROM BILL_HDR) and ltrim(rtrim(BILLNO))='" & Trim(BILLNO) & "'"
                gconnection.getDataSet(SSQL, "BILL_hdr")
                If gdataset.Tables("BILL_hdr").Rows.Count > 0 Then
                    CHECK_BILLEXIST = True
                    Exit Function
                Else
                    CHECK_BILLEXIST = False
                End If
            End If
        End If
    End Function
    Private Sub cmdMcodeUpd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMcodeUpd.Click
        grpPass.Visible = True
        txtPass.Focus()
        'grpNewMcode.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
            txtNmcode.Text = Trim(vform.keyfield & "")
            txtNmname.Text = Trim(vform.keyfield1 & "")
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim sql, otherbillno, SQLSTRING, STRKOTDETAILS As String
        Dim OTHERBOOL As Boolean
        Dim VCTR As Integer
        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            If gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") <> "" Then
                otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
                OTHERBOOL = True
            End If
        Else
            OTHERBOOL = False
        End If
        If OTHERBOOL = True Then
            BillDetails = Trim(otherbillno) & "'" & "," & "'" & Trim(Me.txt_BillNo.Text)
        Else
            BillDetails = Trim(Me.txt_BillNo.Text)
        End If
        SQLSTRING = "SELECT DISTINCT KOTDETAILS FROM KOT_DET WHERE BILLDETAILS in ('" & Trim(BillDetails) & "'" & ")"
        gconnection.getDataSet(SQLSTRING, "KOT_DET")
        If gdataset.Tables("KOT_DET").Rows.Count > 0 Then
            For VCTR = 0 To gdataset.Tables("KOT_DET").Rows.Count - 1
                If Trim(STRKOTDETAILS) = "" Then
                    STRKOTDETAILS = "'" & Trim(gdataset.Tables("KOT_DET").Rows(VCTR).Item("KOTDETAILS")) & "',"
                Else
                    STRKOTDETAILS = STRKOTDETAILS & "'" & Trim(gdataset.Tables("KOT_DET").Rows(VCTR).Item("KOTDETAILS")) & "',"
                End If
            Next
            STRKOTDETAILS = Mid(STRKOTDETAILS, 1, Len(STRKOTDETAILS) - 1)
        End If
        ''===============UPDATION OF MEMBERCODE==============
        sql = "UPDATE BILL_HDR SET MCODE = ' " & txtNmcode.Text & "',MNAME ='" & txtNmname.Text & "' WHERE BILLDETAILS IN ( '" & BillDetails & "')"
        gconnection.dataOperation(7, sql)
        sql = "UPDATE KOT_HDR SET MCODE = ' " & txtNmcode.Text & "',MNAME ='" & txtNmname.Text & "',SLCODE='" & txtNmcode.Text & "' WHERE KOTDETAILS IN ( " & STRKOTDETAILS & ")"
        gconnection.dataOperation(1, sql)
        grpNewMcode.Visible = False
        txtNmcode.Text = ""
        txtNmname.Text = ""
        Call cmd_Clear_Click(sender, e)

    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            gconnection.getDataSet("SELECT ISNULL(PASSWORD,'') AS PASSWORD FROM PASSWORD", "PASSWORD")
            If gdataset.Tables("PASSWORD").Rows(0).Item(0) = GetPassword(UCase(Trim(txtPass.Text))) Then
                grpPass.Visible = False
                txtPass.Text = ""
                grpNewMcode.Visible = True
                txtNmcode.Focus()
            Else
                MsgBox("UNAUTHERISED ACCESS...", MsgBoxStyle.Critical)
                txtPass.Text = ""
                grpPass.Visible = False
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmdOk.Focus()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        grpNewMcode.Visible = False
        txtNmcode.Text = ""
        txtNmname.Text = ""
    End Sub
    Private Sub txtNmcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNmcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_MemberCode.Text) <> "" Then
                txt_NEW_MemberCode_Validated(sender, e)
            Else
                Call cmd_MemberCodeHelp_Click(cmd_MemberCodeHelp, e)
            End If
        End If
    End Sub
    Private Sub cmdCro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCro.Click
        Dim msg As Double
        msg = MsgBox("Are you sure yo want to relese this bill", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
        If msg = MsgBoxResult.Yes Then
            Dim sql, otherbillno, SQLSTRING, STRKOTDETAILS, UPDATE(0) As String
            Dim OTHERBOOL As Boolean
            Dim VCTR As Integer
            sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
            gconnection.getDataSet(sql, "Bill_det")
            If gdataset.Tables("Bill_det").Rows.Count > 0 Then
                If gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") <> "" Then
                    otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
                    OTHERBOOL = True
                End If
            Else
                OTHERBOOL = False
            End If
            If OTHERBOOL = True Then
                BillDetails = Trim(otherbillno) & "'" & "," & "'" & Trim(Me.txt_BillNo.Text)
            Else
                BillDetails = Trim(Me.txt_BillNo.Text)
            End If
            SQLSTRING = "SELECT DISTINCT KOTDETAILS FROM KOT_DET WHERE BILLDETAILS in ('" & Trim(BillDetails) & "'" & ")"
            gconnection.getDataSet(SQLSTRING, "KOT_DET")
            If gdataset.Tables("KOT_DET").Rows.Count > 0 Then
                For VCTR = 0 To gdataset.Tables("KOT_DET").Rows.Count - 1
                    If Trim(STRKOTDETAILS) = "" Then
                        STRKOTDETAILS = "'" & Trim(gdataset.Tables("KOT_DET").Rows(VCTR).Item("KOTDETAILS")) & "',"
                    Else
                        STRKOTDETAILS = STRKOTDETAILS & "'" & Trim(gdataset.Tables("KOT_DET").Rows(VCTR).Item("KOTDETAILS")) & "',"
                    End If
                Next
                STRKOTDETAILS = Mid(STRKOTDETAILS, 1, Len(STRKOTDETAILS) - 1)
            End If
            SQLSTRING = "DELETE FROM RECEIPT_DETAILS WHERE BILLNO='" & Trim(txt_BillNo.Text) & "'"
            UPDATE(0) = SQLSTRING
            SQLSTRING = "UPDATE BILL_HDR SET CROSTATUS='N' WHERE BILLDETAILS='" & Trim(txt_BillNo.Text) & "'"
            ReDim Preserve UPDATE(UPDATE.Length)
            UPDATE(UPDATE.Length - 1) = SQLSTRING
            SQLSTRING = "UPDATE KOT_HDR SET CROSTATUS='N' WHERE KOTDETAILS IN ( " & STRKOTDETAILS & " )"
            ReDim Preserve UPDATE(UPDATE.Length)
            UPDATE(UPDATE.Length - 1) = SQLSTRING
            gconnection.MoreTransold(UPDATE)
        Else
            Exit Sub
        End If
    End Sub
    Private Function SpiltBill()
        Dim tempamt As Double
        Dim mcode As String
        LAB_BALANCEAMT.Text = "BALANCE AMOUNT:"
        Try
            With ssgrid_settlement
                tempamt = 0.0
                For i = 1 To ssgrid_settlement.DataRowCnt
                    .Col = 2
                    .Row = i
                    tempamt = tempamt + Val(.Text)
                Next
            End With
            LAB_BALANCEAMT.Text = LAB_BALANCEAMT.Text & Format(Math.Round(Val(txt_BillAmount.Text - tempamt), 2), "0.00")
            If Math.Round(Val(tempamt), 2) <> Math.Round(Val(txt_BillAmount.Text), 2) Then
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
                        For i = 1 To ssgrid_settlement.DataRowCnt
                            .Col = 1
                            .Row = i
                            MCODE = Trim(.Text)
                            For J = 1 To ssgrid_settlement.DataRowCnt
                                .Col = 1
                                .Row = J
                                If MCODE = Trim(.Text) And i <> J Then
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
            txt_MemberCode.Focus()
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
        KotDetails = ""
        CMB_SPILTMEMBER.Items.Clear()
        Dim i, j As Integer
        Try
            sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(BILLDETAILS,'') AS BILLDETAILS,ISNULL(DESCRIPTION,'') AS DESCRIPTION "
            sqlstring = sqlstring & " FROM SETTLEMENT WHERE BILLDETAILS='" & Trim(txt_BillNo.Text) & "' --AND ISNULL(DELETEFLAG,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "SETTLE")
            'If cbo_PaymentMode.SelectedItem <> "ROOM" Then
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
                        CMB_SPILTMEMBER.Items.Add(gdataset.Tables("SETTLE").Rows(i).Item("MCODE"))
                    Next
                End With
                'End If
            End If
            If gdataset.Tables("SETTLE").Rows.Count > 1 Then
                LAB_SPILTMEMBER.Visible = True
                CMB_SPILTMEMBER.Visible = True
                CHKALL.Visible = True
                CMB_SPILTMEMBER.SelectedIndex = 0
            Else
                LAB_SPILTMEMBER.Visible = False
                CMB_SPILTMEMBER.Visible = False
                CHKALL.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Sub txt_BillAmount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BillAmount.Validated
        'SETTLEMENT
        'BEGIN
        'If cbo_PaymentMode.SelectedItem <> "ROOM" Then
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
            'End If
            'SETTLEMENT
            'END
        End If
    End Sub
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
    Private Sub txt_ServerCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ServerCode.TextChanged
    End Sub
    Private Sub txt_BillNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BillNo.TextChanged
    End Sub
    Private Sub txt_BillAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BillAmount.TextChanged
    End Sub

    Private Sub lblCro2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCro2.Click

    End Sub

    Private Sub ssGrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssGrid.Advance

    End Sub
    Private Sub txt_MemberCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MemberCode.TextChanged
    End Sub
    Public Sub SPILTBILL_PRINT()
        Randomize()
        Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
        Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword, splmember As String
        Dim BillNo, sql, sqlstring, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno As String
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
        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
            Otherbool = True
        Else
            Otherbool = False
        End If
        If Otherbool = True Then
            billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_BillNo.Text) & "'"
        Else
            billdetails = "'" & Trim(Me.txt_BillNo.Text) & "'"
        End If
        sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,"
        sql = sql & "D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,"
        sql = sql & "D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,"
        sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,"
        sql = sql & "ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
        sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
        sql = sql & " WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' "
        sql = sql & " ORDER BY D.BillDetails"
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
            For J = 1 To ssgrid_settlement.DataRowCnt
                ssgrid_settlement.Col = 1
                ssgrid_settlement.Row = J
                splmember = splmember & (ssgrid_settlement.Text) & ","
            Next
            ssgrid_settlement.SetActiveCell(1, 1)
            For J = 1 To ssgrid_settlement.DataRowCnt
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
                adduserid = Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID"))
                CountItem = 0
                ''FOR LOOP START
                ''==============
                For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                    CountItem = CountItem + 1
                    boolOtherBill = False
                    headercount = 1
                    ',Madras club
                    ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                    ''''''''''    ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                    If Vrowcount = 0 Then
                        If headercount = 1 Then
                            'Initial heading printing
                            '========================
                            headercount = 2
                            For i = 1 To 2
                                Filewrite.WriteLine("")
                            Next
                            Vrowcount = 2
                            '3
                            Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & gCompanyname & Chr(20) & Chr(27) & Chr(72)
                            Filewrite.WriteLine(Rowprint)
                            '4
                            Vrowcount = Vrowcount + 1
                            'Rowprint = Space(13) & gCompanyAddress(0)
                            Rowprint = gCompanyAddress(0)
                            Filewrite.WriteLine(Rowprint)
                            '5
                            Vrowcount = Vrowcount + 1
                            'Rowprint = Space(13) & gCompanyAddress(1)
                            Rowprint = gCompanyAddress(1)
                            Filewrite.WriteLine(Rowprint)
                            '6
                            Vrowcount = Vrowcount + 1
                            ''======================================
                            'If Format(Val(taxpercentage), "0.00") = "12.50" Then
                            '    Gheader = " TAX  INVOICE "
                            'Else
                            Gheader = " CREDIT  MEMO "
                            'End If
                            Filewrite.WriteLine("")
                            '7
                            Vrowcount = Vrowcount + 1
                            Rowprint = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                            Filewrite.WriteLine(Rowprint)
                            '8
                            Vrowcount = Vrowcount + 1
                            Filewrite.WriteLine("")
                            '9
                            Vrowcount = Vrowcount + 1
                            Rowprint = "BILL NO :"
                            Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(BillNo) & Chr(27) + "F" & Chr(18)
                            Filewrite.Write(Rowprint)
                            Rowprint = Chr(15) & Space(40 - Len(Trim(BillNo)))
                            Rowprint = Rowprint & "TIME  :"
                            'Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "hh:mm:ss")
                            Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "T")

                            Filewrite.WriteLine(Rowprint)
                            '10
                            Vrowcount = Vrowcount + 1
                            Rowprint = "USER    :"
                            'Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE")), 1, 10) & space(
                            Filewrite.Write(Rowprint)
                            Rowprint = Chr(18) & Chr(27) + "E"
                            Rowprint = Rowprint & Trim(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE"))) & "(" & Mid(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME"), 1, 25) & ")" & Space(30 - Len(Trim(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE"))) & "(" & Mid(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME"), 1, 25) & ")")) & Chr(27) + "F" & Chr(15)
                            Rowprint = Rowprint & "DATE  :"
                            Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy")
                            '11
                            Filewrite.WriteLine(Rowprint)
                            Vrowcount = Vrowcount + 1
                            Pagesize = Pagesize + 1
                            For i = 0 To 78
                                Filewrite.Write("-")
                            Next
                            Filewrite.WriteLine()
                            '12
                            Vrowcount = Vrowcount + 1
                            Rowprint = "SLNo  CODE     ITEM DESCRIPTION                       QUANTITY   RATE   AMOUNT  "
                            Filewrite.WriteLine(Rowprint & Chr(15))
                            '13
                            Vrowcount = Vrowcount + 1
                            For i = 0 To 78
                                Filewrite.Write("-")
                            Next
                            Filewrite.WriteLine()
                            '14
                            Vrowcount = Vrowcount + 1
                            Filewrite.WriteLine("{0,-12}{1,-40}", "LOCATION :", Chr(14) & Chr(15) & gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & poscode & "'"))
                            '15
                            Vrowcount = Vrowcount + 1
                            Filewrite.WriteLine(StrDup(20, "-"))
                            '16
                            Vrowcount = Vrowcount + 1
                        End If
                    End If
                    With gdataset.Tables("ReportTable").Rows(rowj)
                        Rowprint = ""
                        Rowprint = Mid(CountItem, 1, 5) & "." & Space(5 - Len(Mid(CountItem, 1, 5)))
                        Rowprint = Rowprint & Mid(Trim(.Item("ITEMCODE") & ""), 1, 8) & Space(8 - Len(Mid(Trim(.Item("ITEMCODE") & ""), 1, 8))) & Space(1)
                        Rowprint = Rowprint & Mid(Trim(.Item("ITEMDESC") & "........................................"), 1, 38) & Space(38 - Len(Mid(Trim(.Item("ITEMDESC") & "........................................"), 1, 38)))
                        Rowprint = Rowprint & Mid(Val(.Item("QTY") & ""), 1, 3) & Space(3 - Len(Mid(Trim(.Item("QTY") & ""), 1, 3))) & Space(1)
                        Rowprint = Rowprint & Mid(Trim(.Item("UOM") & ""), 1, 5) & Space(5 - Len(Mid(Trim(.Item("UOM") & ""), 1, 5)))
                        Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8)
                        Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8)
                        TotalAmount = TotalAmount + Val(.Item("Amount"))
                        TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                        Filewrite.WriteLine(Rowprint & Chr(15))
                        Vrowcount = Vrowcount + 1
                        innercount = innercount + 1
                        If Vrowcount > 31 Then
                            Filewrite.WriteLine(StrDup(79, "-"))
                            Filewrite.WriteLine(Space(55) & "Continued....")
                            Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
                            Filewrite.WriteLine(Rowprint & Chr(15))
                            For i = 1 To 19
                                Filewrite.WriteLine("")
                            Next
                            innercount = 0
                            Vrowcount = 0
                            vpagenumber = Val(vpagenumber) + 1
                        End If
                    End With
                Next rowj
                For i = 1 To 15 - innercount
                    Filewrite.WriteLine()
                Next i
                taxcount = 0
                Rowprint = Space(68) & "----------"
                Filewrite.WriteLine(Rowprint)
                '1
                taxcount = taxcount + 1
                Vrowcount = Vrowcount + 1
                Rowprint = Space(70) & Space(8 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 8)
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
                '2
                taxcount = taxcount + 1
                sqlstring = "select isnull(sum(a.taxamount),0) as Taxamount,a.taxcode,b.itemtypedesc from Bill_det a,"
                sqlstring = sqlstring & "itemtypemaster b where a.taxcode=b.taxcode and isnull(a.delflag,'')<>'Y' AND "
                sqlstring = sqlstring & " a.taxamount>0 AND a.billdetails='" & Trim(txt_BillNo.Text) & "'"
                sqlstring = sqlstring & "  group by a.taxcode,b.itemtypedesc"
                gconnection.getDataSet(sqlstring, "TaxDet")

                For i = 0 To gdataset.Tables("TaxDet").Rows.Count - 1
                    If i = 0 Then
                        Rowprint = "Bills Payable On Presentation                          "
                    Else
                        Rowprint = Space(55)
                    End If
                    Rowprint = Rowprint & Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15)
                    Rowprint = Rowprint & Space(15 - Len(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15)))
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 8))) & Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 8)

                    Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                    '3
                    taxcount = taxcount + 1
                    Vrowcount = Vrowcount + 1
                Next
                Rowprint = Space(68) & "----------"
                '4
                Filewrite.WriteLine(Rowprint)
                taxcount = taxcount + 1
                Vrowcount = Vrowcount + 1
                Rowprint = "SIGNATURE:                                      Total :"
                Rowprint = Rowprint & Space(70 - Len(Rowprint)) & Space(8 - Len(Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8)


                Filewrite.WriteLine(Rowprint)
                '5
                taxcount = taxcount + 1
                Vrowcount = Vrowcount + 1
                Rowprint = Space(68) & "----------"
                Filewrite.WriteLine(Rowprint)
                '6
                taxcount = taxcount + 1
                Vrowcount = Vrowcount + 1
                'member NAME
                If Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) = "ROOM" Then
                    Rowprint = Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) & ":"
                    Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("ROOMNO") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("GUEST")) & ")")
                Else
                    If CHKALL.Checked = False And CHKALL.Visible = True Then
                        SETMCODE = Trim(CMB_SPILTMEMBER.Text)
                        For K = 1 To ssgrid_settlement.DataRowCnt
                            ssgrid_settlement.Col = 1
                            ssgrid_settlement.Row = K
                            If SETMCODE = Trim(ssgrid_settlement.Text) Then
                                ssgrid_settlement.Col = 2
                                ssgrid_settlement.Row = K
                                SETAMOUNT = Format(Val(ssgrid_settlement.Text), "0.00")
                            End If
                        Next
                    End If
                    sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE, ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER WHERE MCODE='" & SETMCODE & "'"
                    gconnection.getDataSet(sqlstring, "MEM")
                    If Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) = "CREDIT" Then
                        Rowprint = "MEMBER:"
                    Else
                        Rowprint = Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) & ":"
                    End If
                    'Rowprint = Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) & ":"
                    If gdataset.Tables("MEM").Rows.Count > 0 Then
                        Rowprint = Rowprint & Trim(gdataset.Tables("MEM").Rows(0).Item("MNAME")) & "(" & Trim(gdataset.Tables("MEM").Rows(0).Item("MCODE")) & ")"
                    End If
                End If
                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 60) & " SETTLEMENT :" & SETAMOUNT & Chr(27) + "F" & Chr(15))
                '7
                taxcount = taxcount + 1
                Vrowcount = Vrowcount + 1
                Rowprint = Chr(15) & Chr(27) + "E" & RupeesToWord(Val(Format(TaxAmount + TotalAmount, "0.00"))) & Chr(27) + "F" & Chr(15)
                Filewrite.WriteLine(UCase(Rowprint))
                '8
                taxcount = taxcount + 1
                Vrowcount = Vrowcount + 1
                For i = 0 To 78
                    Filewrite.Write("-")
                Next
                Filewrite.WriteLine()
                '9
                taxcount = taxcount + 1
                Vrowcount = Vrowcount + 1
                Rowprint = Mid("BILL AMOUNT:", 1, 65) & Space(65 - Len(Mid("BILL AMOUNT:", 1, 65)))
                Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(TaxAmount + TotalAmount, "0.00") & Chr(27) + "F" & Chr(15)
                Filewrite.WriteLine(Rowprint)
                '10
                taxcount = taxcount + 1
                Vrowcount = Vrowcount + 1
                For i = 0 To 78
                    Filewrite.Write("-")
                Next
                Filewrite.WriteLine()
                Vrowcount = Vrowcount + 1
                '11
                taxcount = taxcount + 1
                Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
                '12
                taxcount = taxcount + 1
                Dim sstring As String
                sstring = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
                sstring = sstring & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
                sstring = sstring & " WHERE D.Billdetails = '" & BillNo & "' "
                sstring = sstring & " AND ISNULL(KotStatus,'N')='N'"
                sstring = sstring & " order by d.billdetails"
                gconnection.getDataSet(sstring, "rTable")
                For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                    Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
                Next
                If Len(Kot) < 31 Then
                    Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    taxcount = taxcount + 1
                    '13
                Else
                    Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "             " & Mid(Kot, 31, 30) & "."
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 2
                    taxcount = taxcount + 2
                    '14
                End If

                If Trim(Txt_Remarks.Text) <> "" Then
                    If Len(Trim(Txt_Remarks.Text)) < 65 Then
                        Filewrite.Write("             " & Trim(Txt_Remarks.Text))
                        Vrowcount = Vrowcount + 1
                        taxcount = taxcount + 1
                        '14
                    Else
                        Filewrite.WriteLine("             " & Mid(Trim(Txt_Remarks.Text), 1, 65))
                        Filewrite.Write("             " & Mid(Trim(Txt_Remarks.Text), 66, 65))
                        Vrowcount = Vrowcount + 2
                        taxcount = taxcount + 2
                        '15
                    End If
                    Filewrite.WriteLine(" " & splmember)
                Else
                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & "SETTLEMENT MEMBERS :(" & splmember & ")" & Chr(27) + "F" & Chr(15))
                    Vrowcount = Vrowcount + 1
                    taxcount = taxcount + 1
                    '14
                End If
                For i = 1 To 25 - taxcount
                    Filewrite.WriteLine("")
                Next
                If CHKALL.Checked = False And CHKALL.Visible = True Then
                    Exit For
                End If
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
    Public Sub SVSC_PRINT()
        Try
            Randomize()
            Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
            Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword, splmember, servicelocation, INSERT(0) As String
            Dim BillNo, sql, sqlstring, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno, SNAME, _BILLDETAILS As String
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

            ssql = " update bill_hdr  set scode=b.scode "
            ssql = ssql & " from bill_hdr a,kot_det b where a.billdetails=b.billdetails and isnull(a.scode,'')=''"
            INSERT(0) = ssql

            ssql = " update bill_hdr  set sname=b.servername"
            ssql = ssql & " from bill_hdr a,servermaster b where a.scode=b.servercode and isnull(a.sname,'')=''"

            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = ssql
            gconnection.MoreTransold1(INSERT)

            sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
            gconnection.getDataSet(sql, "Bill_det")
            If gdataset.Tables("Bill_det").Rows.Count > 0 Then
                Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
                Otherbool = True
            Else
                Otherbool = False
            End If
            If Otherbool = True Then
                billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_BillNo.Text) & "'"
            Else
                billdetails = "'" & Trim(Me.txt_BillNo.Text) & "'"
            End If
            Call bill_roundoff()
            Call outstanding()
            sql = " SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,isnull(D.SCODE,'') as scode,isnull(E.SERVERNAME,'') AS SNAME,ISNULL(PRINTFLAG,'') AS PRINTFLAG,ISNULL(BILL_HDR.DELFLAG,'') AS DELFLAG,"
            sql = sql & "D.BILLDETAILS,ITEMCODE,ITEMDESC,D.POSCODE,D.UOM,sum(D.QTY) as QTY,"
            sql = sql & "D.RATE,sum(AMOUNT) as amount,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(sum(D.TAXAMOUNT),0) as TAXAMOUNT,"
            sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,ISNULL(BILL_HDR.servicelocation,'') AS servicelocation,F.POSDESC,"
            sql = sql & " ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
            sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
            sql = sql & " INNER JOIN SERVERMASTER E  ON E.SERVERCODE=D.SCODE  "
            sql = sql & " INNER JOIN POSMASTER F  ON F.POSCODE=D.POSCODE  "
            sql = sql & " WHERE D.Billdetails IN ( " & Trim(billdetails) & ") AND ISNULL(KotStatus,'N')='N' "
            sql = sql & " group by F.POSDESC,BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,D.SCODE,E.SERVERNAME,PRINTFLAG,BILL_HDR.DELFLAG, "
            sql = sql & " D.BILLDETAILS,ITEMCODE,ITEMDESC,D.POSCODE,D.UOM,D.RATE, "
            sql = sql & " TAXTYPE,TAXPERC,TAXCODE,ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid,BILL_HDR.servicelocation,"
            sql = sql & "GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),''),ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'')"
            sql = sql & " --ORDER BY D.KOTDETAILS --D.BillDetails "
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
                Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Chr(18) & Chr(20) & Chr(27) & Chr(72))
                Gheader = Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Chr(15) & Mid(gCompanyname, 1, 35) & Space(35 - Len(Mid(gCompanyname, 1, 35))) & Chr(20) & Chr(27) & Chr(72)
                Filewrite.WriteLine(Gheader)
                Filewrite.WriteLine(Chr(18) & Chr(14) & Chr(15) & Space(15) & Trim(cbo_PaymentMode.Text) & "-RECEIPT")
                If gdataset.Tables("ReportTable").Rows(0).Item("DELFLAG") = "Y" Then
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine(Space(10) & Chr(27) + "E" & "D E L E T E D  V O U C H E R" & Chr(27) + "F")
                    Filewrite.WriteLine("")
                Else
                    If gdataset.Tables("ReportTable").Rows(0).Item("PRINTFLAG") = "Y" Then
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(Space(6) & Chr(18) & Chr(14) & "D U P L I C A T E")
                        Filewrite.WriteLine("")
                    End If
                End If
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
                    End If
                    Rowprint = Rowprint & Space(1) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE"))
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "NAME:" & Space(1) & Chr(18) & Chr(14) & Chr(15) & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME"))
                End If
                Filewrite.WriteLine(Chr(18) & Chr(14) & Chr(15) & Rowprint & Chr(18) & Chr(14) & Chr(15))
                Filewrite.WriteLine("")
                Rowprint = "Waiter :" & Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("sname")), 1, 25)
                Rowprint = Rowprint & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("scode")) & ")"

                Filewrite.WriteLine(Chr(18) & Chr(14) & Chr(15) & Rowprint & Chr(18) & Chr(14) & Chr(15))

                Rowprint = "LOCATION:" & Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("POSDESC")), 1, 13)
                Rowprint = Rowprint & Space(13 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("POSDESC")), 1, 13)))
                Rowprint = Rowprint & "Tm:" & Trim(Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "T"))
                Filewrite.WriteLine(Chr(18) & Chr(14) & Chr(15) & Rowprint & Chr(18) & Chr(14) & Chr(15))
                _BILLDETAILS = Chr(15) & Chr(14) & "B.NO:" & Trim(BillNo)
                _BILLDETAILS = _BILLDETAILS & Chr(15) & " DT:" & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy")
                Filewrite.WriteLine(_BILLDETAILS & Chr(18))
                For i = 0 To 40
                    Filewrite.Write("-")
                Next
                Filewrite.WriteLine()
                Filewrite.WriteLine(Chr(18) & "SLNO ITEM              QTY   RATE AMOUNT")
                For i = 0 To 40
                    Filewrite.Write("-")
                Next
                Filewrite.WriteLine()
                TotalAmount = 0 : TaxAmount = 0
                CountItem = 0
                For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                    CountItem = CountItem + 1
                    With gdataset.Tables("ReportTable").Rows(rowj)
                        Filewrite.Write(Chr(18) & Mid(Format(CountItem, "0") & ".", 1, 3) & Space(3 - Len(Mid(Format(CountItem, "0" & "."), 1, 3))))
                        Filewrite.Write(Mid(Trim(.Item("ITEMDESC") & ""), 1, 17) & Space(17 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 17))))
                        Filewrite.Write(Space(1) & Space(4 - Len(Mid(Format(Val(.Item("QTY") & ""), "0.00"), 1, 4))) & Mid(Format(Val(.Item("QTY") & ""), "0.00"), 1, 4))
                        Filewrite.Write(Space(1) & Space(6 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 6))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 6))
                        Filewrite.WriteLine(Space(8 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))
                        TotalAmount = TotalAmount + Val(.Item("Amount"))
                        TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                    End With
                Next rowj
                For i = 0 To 40
                    Filewrite.Write("-")
                Next
                Filewrite.WriteLine(Chr(18))
                Rowprint = "Total" & Chr(14) & Chr(15) & Space(23) & Space(8 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 8)
                sqlstring = "select isnull(sum(a.taxamount),0) as Taxamount,a.taxcode,b.itemtypedesc from kot_det a,"
                sqlstring = sqlstring & "itemtypemaster b where a.taxcode=b.taxcode and isnull(a.delflag,'')<>'Y' AND "
                sqlstring = sqlstring & " a.taxamount>0 AND a.billdetails='" & Trim(txt_BillNo.Text) & "'"
                sqlstring = sqlstring & "  group by a.taxcode,b.itemtypedesc"
                gconnection.getDataSet(sqlstring, "TaxDet")
                If gdataset.Tables("TaxDet").Rows.Count > 0 Then
                    Filewrite.WriteLine(Rowprint & Chr(18))
                    For i = 0 To gdataset.Tables("TaxDet").Rows.Count - 1
                        Filewrite.Write(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15) & Space(21 - Len(Mid(gdataset.Tables("TaxDet").Rows(i).Item("ItemtypeDesc"), 1, 15))))
                        Rowprint = Chr(14) & Chr(15) & Space(11) & Space(6 - Len(Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 6))) & Mid(Format(Val(gdataset.Tables("TaxDet").Rows(i).Item("taxamount") & ""), "0.00"), 1, 6)
                        Filewrite.WriteLine(Rowprint & Chr(18))
                    Next
                    For i = 0 To 40
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine("")
                End If
                If i = 0 Then
                    Rowprint = Chr(18) & "Net Amount"
                Else
                    Rowprint = Chr(18) & Space(11)
                End If
                If Amt <> 0 Then
                    Rowprint = "Net Amount" & Space(7) & Space(27 - Len(Rowprint)) & Chr(14) & Chr(15) & Space(8 - Len(Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8))) & Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 8)
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = Chr(18) & "Round Off" & Space(23) & Chr(14) & Chr(15) & Space(8 - Len(Mid(Trim(Format(Amt, "0.00")), 1, 8))) & Mid(Trim(Format(Amt, "0.00")), 1, 8) & Chr(18)
                    Filewrite.WriteLine(Rowprint & Chr(18))
                    For i = 0 To 40
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                End If

                Rowprint = Mid(Chr(18) & "BILL AMOUNT :", 1, 21) & Space(25 - Len(Mid("BILL AMOUNT:", 1, 25))) & Space(8)
                If Amt < 0 Then
                    Rowprint = Rowprint & Chr(14) & Chr(15) & Format(Val((TaxAmount + TotalAmount)) - Val(Amt * -1), "0.00")
                Else
                    Rowprint = Rowprint & Chr(14) & Chr(15) & Format(Val((TaxAmount + TotalAmount)) + Val(Amt), "0.00")
                End If
                Filewrite.WriteLine(Rowprint & Chr(18))
                For i = 0 To 40
                    Filewrite.Write("-")
                Next
                Filewrite.WriteLine()
                Rowprint = Chr(15) & Chr(27) + "E" & RupeesToWord(Val(Format(TaxAmount + TotalAmount, "0.00"))) & Chr(27) + "F" & Chr(15)
                If Trim(UCase(Rowprint)) <> "" Then
                    If Len(Trim(UCase(Rowprint))) < 72 Then
                        Filewrite.WriteLine(Trim(Rowprint))
                    Else
                        Filewrite.WriteLine(Mid(Trim(Trim(Rowprint)), 1, 72))
                        Filewrite.WriteLine(Mid(Trim(Trim(Rowprint)), 73, 72))
                    End If
                End If
                Filewrite.Write(Chr(18))
                For i = 0 To 40
                    Filewrite.Write("-")
                Next
                Filewrite.WriteLine()
                Dim sstring As String
                sstring = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
                sstring = sstring & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
                sstring = sstring & " WHERE D.Billdetails = '" & txt_BillNo.Text & "' "
                sstring = sstring & " AND ISNULL(KotStatus,'N')='N'"
                sstring = sstring & " order by d.billdetails"
                gconnection.getDataSet(sstring, "rTable")
                Kot = "("
                For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                    Kot = Kot & gdataset.Tables("rTable").Rows(i).Item("Kotno") & ","
                Next
                Kot = Mid(Kot, 1, Len(Kot) - 1)
                Kot = Kot & ")"
                Filewrite.Write(Chr(15) & Chr(27) + "E")

                If Len(Kot) < 57 Then
                    Rowprint = "Ref. KOT NO.(s) -" & Kot
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                    taxcount = taxcount + 1
                    '13
                Else
                    Rowprint = "Ref. KOT NO.(s) -" & Mid(Kot, 1, 57) & "-"
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "             " & Mid(Kot, 58, 57)
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 2
                    taxcount = taxcount + 2
                    '14
                End If

                If Trim(Txt_Remarks.Text) <> "" Then
                    If Len(Trim(Txt_Remarks.Text)) < 60 Then
                        Filewrite.WriteLine("Remarks     :" & Trim(Txt_Remarks.Text))
                        Vrowcount = Vrowcount + 1
                        taxcount = taxcount + 1
                    Else
                        Filewrite.WriteLine("Remarks     :" & Mid(Trim(Txt_Remarks.Text), 1, 60))
                        Filewrite.Write("             " & Mid(Trim(Txt_Remarks.Text), 61, 60))
                        Vrowcount = Vrowcount + 2
                        taxcount = taxcount + 2
                    End If
                End If
                Filewrite.Write(Chr(27) + "F" & Chr(18))
                taxcount = taxcount + 1
                Vrowcount = Vrowcount + 1
                CLBAL = 0
                If UCase(Trim(cbo_PaymentMode.Text)) = "CREDIT" Then
                    If Amt < 0 Then
                        CLBAL = MemberOutstand + (Val((TaxAmount + TotalAmount)) - Val(Amt * -1))
                    Else
                        CLBAL = MemberOutstand + (Val((TaxAmount + TotalAmount)) + Val(Amt))
                    End If
                End If
                Filewrite.WriteLine("")
                Filewrite.WriteLine("")
                Filewrite.WriteLine("")
                Filewrite.WriteLine(Chr(18) & "Signature                                 ")
                Filewrite.WriteLine("Prepared By :" & Trim(adduserid))
                Filewrite.WriteLine("")
                Filewrite.WriteLine("                 THANK YOU VISIT AGAIN")
                Filewrite.WriteLine("")
                For i = 0 To 11
                    Filewrite.WriteLine("")
                Next
                Filewrite.WriteLine(Chr(18))
                Filewrite.Close()

                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    INSERT(0) = "UPDATE BILL_HDR SET PRINTFLAG='Y' WHERE BILLDETAILS='" & Trim(txt_BillNo.Text) & "'"
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
    Private Sub CMB_BTYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_BTYPE.SelectedIndexChanged
        Try
            If txt_card_id.Text <> "" Then
                txt_card_id.Text = ""
                cmd_Clear_Click(sender, e)
            End If
            Call FillBillPrefix()
            Call FillDefaultPayment()
            Call PaymentGridLocking()
            Call fillPayment_Mode()
            Call GridUnLocking()
            Call autogenerate()
            Call ShowBillno()
            ssGrid.ClearRange(1, 1, -1, -1, True)
            Dim LOC, strstring As String
            LOC = Trim(CMB_BTYPE.Text)




            'strstring = "SELECT isnull(poscode,'') as poscode,isnull(posdesc,'') as posname FROM POSMASTER WHERE POSCODE='" & Trim(LOC) & "'AND ISNULL(Freeze,'')<>'Y'"
            strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y'  AND ISNULL(DOCTYPE,'')='" & Trim(LOC) & "'"
            gconnection.getDataSet(strstring, "LOCmaster")
            If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
                txt_ServerCode.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
                txt_ServerName.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosName")
            Else
                txt_ServerCode.Text = ""
                txt_ServerCode.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CMB_BTYPE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_BTYPE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_BillNo.Focus()
        End If
    End Sub
    Private Sub txt_KOTTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_KOTTime.TextChanged

    End Sub
    Function outstanding()
        Try
            'lab_outstanding.Text = "0.00"
            'MemberOutstand = 0
            'If Trim(CMB_BTYPE.Text) = "RES" Then
            '    SQLSTRING = " SELECT SLCODE,ISNULL((SUM(DR)-SUM(CR)) - SUM(BALANCE),0) AS AMOUNT  FROM VW_CLOSINGBALANCE_BARBALANCE  "
            '    SQLSTRING = SQLSTRING & " WHERE SLCODE='" & Trim(txt_MemberCode.Text) & "'"
            '    SQLSTRING = SQLSTRING & " GROUP BY SLCODE HAVING(((SUM(DR)-SUM(CR)) - SUM(BALANCE))>0)"

            '    'SQLSTRING = " SELECT  ISNULL(SUM(ISNULL(BALANCE,0)),0) AS AMOUNT FROM CREDIT_LIMIT WHERE SLCODE='" & txt_MemberCode.Text & "' AND VOUCHERTYPE<>'BAR' --and voucherdate<='" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "'"
            'Else
            '    SQLSTRING = " SELECT  ISNULL(SUM(ISNULL(BALANCE,0)),0) AS AMOUNT FROM CREDIT_LIMIT WHERE SLCODE='" & txt_MemberCode.Text & "' AND VOUCHERTYPE='BAR' --and voucherdate<='" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "'"
            'End If
            'SQLSTRING = " SELECT SLCODE,ISNULL(SUM(DRAMOUNT-CRAMOUNT),0) AS AMOUNT FROM credit_limit WHERE SLCODE='" & txt_MemberCode.Text & "' GROUP BY SLCODE "
            'gconnection.getDataSet(SQLSTRING, "Outstand")
            'If gdataset.Tables("Outstand").Rows.Count > 0 Then
            '    lab_outstanding.Text = "MEMBER OUTSTANDING :" & Format(Val(gdataset.Tables("outstand").Rows(0).Item("amount")), "0.00")
            '    MemberOutstand = Val(gdataset.Tables("outstand").Rows(0).Item("amount"))
            'End If
            'gconnection.getDataSet(SQLSTRING, "Outstand")
            'If gdataset.Tables("Outstand").Rows.Count > 0 Then
            '    lab_outstanding.Text = "OUTSTANDING AMOUNT:" & Format(Val(gdataset.Tables("outstand").Rows(0).Item("amount")), "0.00")
            '    If UCase(Trim(cbo_PaymentMode.Text)) = "CREDIT" Then
            '        MemberOutstand = Format(Val(gdataset.Tables("outstand").Rows(0).Item("amount")) - Val(txt_BillAmount.Text) , "0.00")
            '    Else
            '        MemberOutstand = Format(Val(gdataset.Tables("outstand").Rows(0).Item("amount")))
            '    End If
            'End If
        Catch ex As Exception
        End Try
    End Function
    Private Sub txt_MemberCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.LostFocus
        'outstanding()
    End Sub
    Private Sub cbo_SubPaymentMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_SubPaymentMode.SelectedIndexChanged
        If Me.Cmd_Add.Text = "Add [F7]" Then
            Call FillKOTdetails() '''*********************** Fill all KOT'S in that grid ***************
        End If
    End Sub
    Private Sub txt_BillNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BillNo.LostFocus
        CMD_LOCK()
    End Sub
    Public Sub HEADER()
        Dim Rowprint As String
        '------------------------------------------------HEADING BEGIN----------------------------------------------------------------------------------
        For i = 1 To 2
            Filewrite.WriteLine("")
        Next
        Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Chr(18) & Chr(20) & Chr(27) & Chr(72))
        Gheader = Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Chr(15) & Mid(gCompanyname, 1, 35) & Space(35 - Len(Mid(gCompanyname, 1, 35))) & Chr(20) & Chr(27) & Chr(72)
        Filewrite.WriteLine(Gheader)
        Filewrite.WriteLine(Chr(15) & Trim(cbo_PaymentMode.Text) & Space(10) & "* COPY *" & Space(10) & "OPl.Bal :")

        If gdataset.Tables("ReportTable").Rows(0).Item("DELFLAG") = "Y" Then
            Filewrite.WriteLine(Space(10) & Chr(27) + "E" & "D E L E T E D  V O U C H E R" & Chr(27) + "F")
        Else
            If gdataset.Tables("ReportTable").Rows(0).Item("PRINTFLAG") = "Y" Then
                Filewrite.WriteLine(Space(6) & Chr(18) & Chr(14) & "D U P L I C A T E")
            End If
        End If
        If Trim(gdataset.Tables("ReportTable").Rows(0).Item("PAYMENTMODE")) = "ROOM" Then

            Rowprint = Chr(15) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 10) & Space(10 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 10))) & Space(20)
            Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20)))
            Filewrite.WriteLine(Rowprint)
            Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("GUEST")), 1, 35) & Space(35 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ROOMNO")), 1, 35))) & Space(10)
            Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
            Filewrite.WriteLine(Rowprint)

        ElseIf Trim(gdataset.Tables("ReportTable").Rows(0).Item("PAYMENTMODE")) = "CLUB" Then

            HNAME = Split(cbo_SubPaymentMode.Text, "-")
            Rowprint = Rowprint & Chr(14) & Chr(15) & Trim(HNAME(1)) & "(" & Trim(HNAME(0)) & ")"
            Rowprint = Chr(15) & Mid(HNAME(0), 1, 10) & Space(10 - Len(Mid(HNAME(0), 1, 10))) & Space(20)
            Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20)))
            Filewrite.WriteLine(Rowprint)
            Rowprint = Rowprint & Chr(14) & Chr(15) & Mid(Trim(HNAME(1)), 1, 35) & "(" & Mid(Trim(HNAME(1)), 1, 35)
            Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
            Filewrite.WriteLine(Rowprint)

        Else

            Rowprint = Chr(15) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MCODE")), 1, 10) & Space(10 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MCODE")), 1, 10))) & Space(20)
            Rowprint = Rowprint & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20)))
            Filewrite.WriteLine(Rowprint)
            Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MNAME")), 1, 35) & Space(35 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("MNAME")), 1, 35))) & Space(10)
            Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10) & Space(10 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BILLDATE"), "dd/MM/yyyy") & ""), 1, 10)))
            Filewrite.WriteLine(Rowprint)

        End If

        Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20)) & Space(10))
        Rowprint = Rowprint & Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BillTime"), "T") & ""), 1, 8) & Space(8 - Len(Mid(Trim(Format(gdataset.Tables("ReportTable").Rows(0).Item("BillTime"), "T") & ""), 1, 8)))
        Filewrite.WriteLine(Rowprint)

        Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("SNAME") & ""), 1, 20)) & Space(20))
        Rowprint = Rowprint & Mid(Trim(CMB_BTYPE.Text), 1, 3) & Space(3 - Len(Mid(Trim(CMB_BTYPE.Text), 1, 3)))
        Filewrite.WriteLine(Rowprint)

        '------------------------------------------------HEADING END----------------------------------------------------------------------------------
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

            sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
            gconnection.getDataSet(sql, "Bill_det")
            If gdataset.Tables("Bill_det").Rows.Count > 0 Then
                Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
                Otherbool = True
            Else
                Otherbool = False
            End If
            If Otherbool = True Then
                billdetails = "'" & Trim(Otherbillno) & "','" & Trim(Me.txt_BillNo.Text) & "'"
            Else
                billdetails = "'" & Trim(Me.txt_BillNo.Text) & "'"
            End If
            Call bill_roundoff()
            'Call outstanding()
            sql = " SELECT  sum(ISNULL(BILL_HDR.ROUNDOFF,0))AS ROUNDOFF,sum(ISNULL(BILL_HDR.TOTALAMOUNT,0))AS TOTALAMOUNT,sum(ISNULL(BILL_HDR.SER_CHG,0)) AS SER_CHG,sum(ISNULL(D.PACKAMOUNT,0)) AS PACKAMOUNT,BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,isnull(D.SCODE,'') as scode,isnull(E.SERVERNAME,'') AS SNAME,ISNULL(PRINTFLAG,'') AS PRINTFLAG,ISNULL(BILL_HDR.DELFLAG,'') AS DELFLAG,"
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
                Filewrite = File.AppendText(vFilepath)
                vline = ""
                RoundOff = Format(gdataset.Tables("ReportTable").Rows(0).Item("ROUNDOFF"))
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
                Rowprint = Space(55) '& Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("BILLDETAILS") & ""), 1, 20))) & Space(25)

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
                sqlstring = sqlstring & " a.taxamount>0 AND a.billdetails='" & Trim(txt_BillNo.Text) & "'"
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
                    ''SNO = SNO + 1
                End If
                If SNO < 9 Then
                    For J = SNO To 9
                        Filewrite.WriteLine("")
                    Next
                End If

                Filewrite.WriteLine(Space(15) & Space(3 - Len(Mid(SNO - i, 1, 3))) & Chr(14) & Chr(15) & Mid(SNO - i, 1, 3) & Space(19) & Format(Val((TaxAmount + TotalAmount + RoundOff)), "0.00") & Chr(15))
                'Filewrite.WriteLine(Space(18) & Space(44) & Format(Val((TaxAmount + TotalAmount + RoundOff)), "0.00"))
                For J = 1 To 1
                    Filewrite.WriteLine("")
                Next
                Filewrite.WriteLine(Space(15) & Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID")), 1, 20) & Space(20 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID")), 1, 20))))
                Filewrite.Write(Space(15) & "Cls.Bal:" & Format(Math.Abs(Val((MemberOutstand))), "0.00") & IIf(Val(MemberOutstand + RoundOff) > 0, " Dr.", " Cr."))
                If Trim(cbo_PaymentMode.Text) = "SMART CARD" Then
                    sqlstring = "SELECT * FROM SM_CARDFILE_HDR WHERE CARDCODE='" & cardcode & "' "
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
                    INSERT(0) = "UPDATE BILL_HDR SET PRINTFLAG='Y' WHERE BILLDETAILS='" & Trim(txt_BillNo.Text) & "'"
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

    Private Sub CMB_BTYPE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMB_BTYPE.Validated
        Call FillDefaultPayment()
        Call fillPayment_Mode()
    End Sub
    Function cardcheck()
        Dim SQLSTRING As String
        SQLSTRING = "SELECT * FROM SM_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
        SQLSTRING = SQLSTRING & " UNION SELECT * FROM SM_AFF_TEMP_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
        gconnection.getDataSet(SQLSTRING, "SM_MEM_LINKAGE")
        'CHECKING IN GLOBAL FUNCTION (DD,MM,YYYY REMOVE AND CHECK IN txt_card_id)
        Call CardIdValidate(Trim(txt_card_id.Text))
        If gdataset.Tables("SM_MEM_LINKAGE").Rows.Count > 0 Then
            cardcode = gdataset.Tables("SM_MEM_LINKAGE").Rows(0).Item("CARDCODE")
        ElseIf Cardidcheck = True Then
            cardcode = Trim(vCardcode)
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

        SQLSTRING = "SELECT * FROM SM_CARDFILE_HDR WHERE CARDCODE='" & cardcode & "' "
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
            ''2511
            ' MIN_USAGE_BALANCE_HDR = Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("MIN_USG_BALANCE")), "0.00")

        Else
            MessageBox.Show("Sorry! CARD EXPIRED " & ControlChars.CrLf & "Contact Smart Card Administration", "Validity Expires", MessageBoxButtons.OK)
        End If
        'KARTHI CHECK IF SWIPED IN RECEPTION, ALLOW ONLY IF SWIPED MAY 31
        '2511
        SQLSTRING = "SELECT CARDCODE FROM SM_MEMBERENTRY_LOG WHERE CARDCODE='" & cardcode & "' AND CAST(CONVERT(VARCHAR(11),DATETIME,6) AS DATETIME ) = '" & Format(Date.Now, "dd/MMM/yyyy") & "'"
        gconnection.getDataSet(SQLSTRING, "SM_MEMBERENTRY_LOG")
        If gdataset.Tables("SM_MEMBERENTRY_LOG").Rows.Count = 0 Then
            MessageBox.Show("SORRY! GET ACCESS AT RECEPTION", "GET ACCESS AT RECEPTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_card_id.Clear()
            'txt_card_id.Focus()
            lbl_SwipeCard.Focus()
            Exit Function
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
            SSTR = "SELECT * FROM SM_POSTRANSACTION WHERE BILL_NO='" & Trim(txt_BillNo.Text) & "' AND ISNULL(VOID,'N')<>'Y' "
            gconnection.getDataSet(SSTR, "SM_POSTRANSACTION")
            KOT_NO_GBL = Trim(txt_BillNo.Text)
            StrPOSCODE = Trim(StrPOSCODE)
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
        Dim INDEX As Integer
        'If cbo_PaymentMode.Text = "SMART CARD" Then
        '    If ttime = 0 Or ttime <> 2 Then
        '        '    Lbl_SwipeCard.Visible = False
        '        ttime = 2
        '    ElseIf ttime = 2 And Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
        '        'lbl_SwipeCard.Visible = True
        '        txt_card_id.Focus()
        '        '                GetSMART_CARDID()
        '        ' DLLSELECT()
        '        txt_card_id.Text = Trim(GBL_SMARTCARDSNO)
        '        If txt_card_id.Text <> "" Then
        '            Call txt_card_id_Validated(sender, e)
        '            ttime = 0
        '        Else
        '            INDEX = cbo_PaymentMode.FindString(DefaultPayment)
        '            cbo_PaymentMode.SelectedIndex = INDEX
        '        End If
        '    End If
        'End If
        Try
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
        'If txt_card_id.Text = "" And cbo_PaymentMode.Text = "SMART CARD" Then
        '    If MessageBox.Show(" PLEASE SWIPE THE CARD ", "SMART CARD", MessageBoxButtons.OKCancel + MessageBoxDefaultButton.Button2, MessageBoxIcon.Exclamation) = DialogResult.OK Then
        '        txt_card_id.Focus()
        '    Else
        '        cbo_PaymentMode.Focus()
        '    End If
        '    '            lbl_SwipeCard.Focus()
        'End If
    End Sub
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
    Private Sub txt_card_id_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_card_id.GotFocus
        '        Call DLLCONNECT()
    End Sub
    'SMART CARD*******************************************************************
    'CSC SMARTCARD
    Private Sub txt_card_id_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_card_id.Validated
        Dim SQLSTRING As String
        If Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
            MessageBox.Show("PLEASE! SWIPE YOUR CARD", "CARD NOT SWIPED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lbl_SwipeCard.Visible = False
            txt_card_id.Focus()
            LAB_CARDBAL.Text = ""
            LAB_CARDBAL.Visible = False
            Exit Sub
        Else
            SQLSTRING = "SELECT * FROM SM_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
            SQLSTRING = SQLSTRING & " UNION SELECT * FROM SM_AFF_TEMP_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
            gconnection.getDataSet(SQLSTRING, "SM_MEM_LINKAGE")
            'CHECKING IN GLOBAL FUNCTION (DD,MM,YYYY REMOVE AND CHECK IN txt_card_id)
            Call CardIdValidate(Trim(txt_card_id.Text))
            If gdataset.Tables("SM_MEM_LINKAGE").Rows.Count > 0 Then
                cardcode = gdataset.Tables("SM_MEM_LINKAGE").Rows(0).Item("CARDCODE")
            ElseIf Cardidcheck = True Then
                cardcode = Trim(vCardcode)
                vCardcode = ""
            Else
                If cbo_PaymentMode.Text = "SMART CARD" Then
                    MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    lbl_SwipeCard.Visible = False
                    txt_card_id.Focus()
                    LAB_CARDBAL.Text = ""
                    LAB_CARDBAL.Visible = False
                    Exit Sub
                End If
            End If

            SQLSTRING = "SELECT * FROM SM_CARDFILE_HDR WHERE CARDCODE='" & cardcode & "' "
            gconnection.getDataSet(SQLSTRING, "SM_CARDFILE_HDR")
            If gdataset.Tables("SM_CARDFILE_HDR").Rows.Count > 0 Then
                'CHECKING ACTIVATION FLAG IS 'Y' OR 'N'
                Dim temp_flag As Char
                temp_flag = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ACTIVATION_FLAG")
                If temp_flag <> "Y" Then
                    MessageBox.Show("Sorry!  Your Card Not Activated. " & ControlChars.CrLf & "Contact Smart Card Administration", "Validity Expires", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    txt_card_id.Clear()
                    txt_card_id.Focus()
                    LAB_CARDBAL.Text = ""
                    LAB_CARDBAL.Visible = False
                    '                    lbl_SwipeCard.Focus()
                    Exit Sub
                End If
                'DISPLAY BALNACE AMOUNT
                BALANCE_HDR = Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00")
                'LAB_CARDBAL.Text = "CARD BALANCE :" & Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00")
                ''2511
                'MIN_USAGE_BALANCE_HDR = Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("MIN_USG_BALANCE")), "0.00")
                LAB_CARDBAL.Text = "CARD BALANCE :" & Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00")
                If Trim(cbo_PaymentMode.Text) = "SMART CARD" Then
                    LAB_CARDBAL.Visible = True
                Else
                    LAB_CARDBAL.Visible = False
                End If
            Else
                'MessageBox.Show("Sorry! CARD EXPIRED " & ControlChars.CrLf & "Contact Smart Card Administration", "Validity Expires", MessageBoxButtons.OK)
                If txt_card_id.Text <> "" Then
                    MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_card_id.Text = ""
                    txt_card_id.Focus()
                End If

            End If

            '''''''SQLSTRING = " SELECT * FROM SYSDATA "
            '''''''gconnection.getDataSet(SQLSTRING, "SYSDATA")
            '''''''If gdataset.Tables("SYSDATA").Rows.Count > 0 Then
            '''''''    If gdataset.Tables("SYSDATA").Rows.Count > 0 And Trim(txt_card_id.Text) <> "" Then
            '''''''        If gdataset.Tables("SYSDATA").Rows(0).Item("OPPORTUNITY") <> Trim(Fast_Read_Card(4, 18)) Then
            '''''''            MsgBox("INVALID CARD SECRET CODE ", MsgBoxStyle.Exclamation)
            '''''''            txt_card_id.Clear()
            '''''''            txt_card_id.Text = ""
            '''''''            ' txt_card_id.Visible = False
            '''''''            cbo_PaymentMode.Focus()
            '''''''            Exit Sub
            '''''''        End If
            '''''''    End If
            '''''''Else
            '''''''    MsgBox("SECRET CODE NOT DEFINED")
            '''''''End If

            'Show PHOTOS
            If gFoto = "Y" Then
                gconnection.LoadFoto_DB(txt_card_id, Pic_Member)
            Else
                If gShortName = "MCC" Then
                    gconnection.FOTO_LOAD_MCC(txt_Holder_Code, Pic_Member)
                ElseIf gShortName = "NIZAM" Then
                    gconnection.Foto_LOAD_NIZAM(txt_Holder_Code, Pic_Member)
                Else
                    gconnection.Foto_LOAD(txt_Holder_Code, Pic_Member)
                End If
            End If
            'Show PHOTO ENDS
            Call DISPLAYINF()
            txt_MemberCode_Validated(sender, e)
            'End If
        End If
    End Sub
    Public Function DISPLAYINF()
        Dim i As Integer
        Dim sqlstring1, sqlstring2, SQLSTRING, subcode, mcode As String
        'CHECKING AND DISPLAYING RECORDS FROM SM_CARDFILE_HDR
        SQLSTRING = "SELECT isnull(MEMBERCODE,'') AS MEMBERCODE, ISNULL(MEMBERSUBCODE,'') AS  MEMBERSUBCODE, ISNULL(CARDCODE,'')AS CARDCODE, ISNULL(FANCYCODE,'')AS FANCYCODE,ISNULL(PASSWORD,'')AS PASSWORD, "
        SQLSTRING = SQLSTRING & " ISNULL(ACTIVATION_FLAG,'')AS ACTIVATION_FLAG, ISNULL(ISSUETYPE,'')AS ISSUETYPE,ISNULL(VALID_FROM,'')AS VALID_FROM,ISNULL(VALID_TO,'')AS VALID_TO,ISNULL(NAME,'')AS NAME,  ISNULL(CARDHOLDERNAME,'')AS CARDHOLDERNAME, ISNULL(AGE,0)AS AGE, ISNULL(DOB,'')AS DOB, ISNULL(TRANSACTION_TYPE,'')AS TRANSACTION_TYPE, ISNULL(AMOUNT,0)AS AMOUNT, ISNULL(BALANCE,0)AS BALANCE "
        SQLSTRING = SQLSTRING & " FROM SM_CARDFILE_HDR WHERE CARDCODE='" & cardcode & "'"
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
                    LAB_CARDBAL.Text = ""
                    LAB_CARDBAL.Visible = False
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
                'lbl_SwipeCard.Focus()
                LAB_CARDBAL.Text = ""
                LAB_CARDBAL.Visible = False
                LAB_CARDBAL.Text = ""
                LAB_CARDBAL.Visible = False
                Exit Function
            End If
            '''''''''''Dim ACCESS_CTL As String
            '''''''''''Dim strsql, STRSQL2 As String
            '''''''''''strsql = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & cardcode & "' AND POSCODE='" & StrPOSCODE & "'"
            '''''''''''gconnection.getDataSet(strsql, "SM_CARDFILE_DET")
            '''''''''''If gdataset.Tables("SM_CARDFILE_DET").Rows.Count > 0 Then
            '''''''''''    STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "'"
            '''''''''''    gconnection.getDataSet(STRSQL2, "POSMASTER")
            '''''''''''    If gdataset.Tables("POSMASTER").Rows.Count > 0 Then
            '''''''''''        POSNAME_GBL = gdataset.Tables("POSMASTER").Rows(0).Item("POSDESC")
            '''''''''''    End If
            '''''''''''    ACCESS_CTL = gdataset.Tables("SM_CARDFILE_DET").Rows(0).Item("POS_ACCESS")
            '''''''''''    If ACCESS_CTL = "N" Then
            '''''''''''        MessageBox.Show("SORRY! YOU HAVE NO RIGHTS TO USE THE POS FACILITY", "ACCESS BLOCKED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '''''''''''        txt_card_id.Clear()
            '''''''''''        txt_card_id.Focus()
            '''''''''''        '                    lbl_SwipeCard.Focus()
            '''''''''''        Exit Function
            '''''''''''    End If
            '''''''''''Else
            '''''''''''    MessageBox.Show(" PLEASE GET POS VALIDITY", "NO RIGHTS FOR POS USAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '''''''''''    txt_card_id.Clear()
            '''''''''''    txt_card_id.Focus()
            '''''''''''    '                lbl_SwipeCard.Focus()
            '''''''''''    Exit Function
            '''''''''''End If
            'CHECKING ACTIVATION FLAG ENDS
            txt_MemberCode.Text = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("MEMBERCODE")
            txt_MemberCode.ReadOnly = True
            MCODE_GBL = Trim(txt_MemberCode.Text)
            'txt_MemberName.Text = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("NAME")
            NAME_GBL = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("NAME")

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
                End If
            ElseIf gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TA" Then
                lbl_MemberCode.Text = "CLUB CODE"
                '                lbl_MemberName.Text = "CLUB NAME   :"
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
                '2511
                'KARTHI HIDE ACCESS CHECK AT RECEPTION 
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
                    gconnection.FOTO_LOAD_MCC(txt_Holder_Code, Pic_Member)
                ElseIf gShortName = "NIZAM" Then
                    gconnection.Foto_LOAD_NIZAM(txt_Holder_Code, Pic_Member)
                Else
                    gconnection.Foto_LOAD(txt_Holder_Code, Pic_Member)
                End If
            End If
            'Show PHOTO ENDS

            'If File.Exists("\\" & gserver & "\Photos\P" & Trim(txt_MemberCode.Text) & ".Jpg") Then
            '    Pic_Member.Image = New Bitmap("\\" & gserver & "\Photos\P" & Trim(txt_MemberCode.Text) & ".Jpg")
            'ElseIf File.Exists("\\" & gserver & "\Photos\P" & Trim(txt_MemberCode.Text) & ".GIF") Then
            '    Pic_Member.Image = New Bitmap("\\" & gserver & "\Photos\P" & Trim(txt_MemberCode.Text) & ".GIF")
            'ElseIf File.Exists("\\" & gserver & "\Photos\Image.Jpg") Then
            '    Pic_Member.Image = New Bitmap("\\" & gserver & "\Photos\Image.Jpg")
            'End If
            'If File.Exists("\\" & gserver & "\Photos\S" & Trim(txt_MemberCode.Text) & ".Jpg") Then
            '    Pic_Sign.Image = New Bitmap("\\" & gserver & "\Photos\S" & Trim(txt_MemberCode.Text) & ".Jpg")
            'ElseIf File.Exists("\\" & gserver & "\Photos\S" & Trim(txt_MemberCode.Text) & ".GIF") Then
            '    Pic_Sign.Image = New Bitmap("\\" & gserver & "\Photos\S" & Trim(txt_MemberCode.Text) & ".GIF")
            'ElseIf File.Exists("\\" & gserver & "\Photos\Image.Jpg") Then
            '    Pic_Sign.Image = New Bitmap("\\" & gserver & "\Photos\Image.Jpg")
            'End If
            'If File.Exists("\\" & gserver & "\Photos\SS" & Trim(txt_MemberCode.Text) & ".Jpg") Then
            '    Pic_Spouse.Image = New Bitmap("\\" & gserver & "\Photos\SS" & Trim(txt_MemberCode.Text) & ".Jpg")
            'ElseIf File.Exists("\\" & gserver & "\Photos\SS" & Trim(txt_MemberCode.Text) & ".GIF") Then
            '    Pic_Spouse.Image = New Bitmap("\\" & gserver & "\Photos\SS" & Trim(txt_MemberCode.Text) & ".GIF")
            'ElseIf File.Exists("\\" & gserver & "\Photos\Image.Jpg") Then
            '    Pic_Spouse.Image = New Bitmap("\\" & gserver & "\Photos\Image.Jpg")
            'End If

            'cbo_PaymentMode.Focus()
            txt_ServerCode.Focus()

            If Me.Cmd_Add.Text = "Add [F7]" And txt_MemberCode.Text <> "" Then
                Call FillKOTdetails() '''*********************** Fill all KOT'S in that grid ***************
            End If
        Else
            If cbo_PaymentMode.Text = "SMART CARD" Then
                MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = False
                txt_card_id.Clear()
                LAB_CARDBAL.Text = ""
                LAB_CARDBAL.Visible = False
                '            txt_card_id.Focus()
                cbo_PaymentMode.Focus()

                '            lbl_SwipeCard.Focus()
            End If
        End If

    End Function
    Private Sub Txt_CardID_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_card_id.GotFocus
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
    Private Sub Txt_Card_ID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_card_id.LostFocus
        If gReaderType_code = 2 Then
            Call CloseSmartDevicePort()
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub GetSmartId()
        Try
            Dim sender As Object, e As System.EventArgs
            If Request_Card() = True Then
                Timer_Delay.Stop()
                If AntiCollu_Card() = "" Then
                    MsgBox("AntiCollusion Failed , CARD NOT VALID / DAMAGED ", MsgBoxStyle.Information, "SMARTCARD")
                    Timer_Delay.Start()
                    txt_card_id.Focus()
                    Exit Sub
                Else
                    txt_card_id.Text = GBL_SmartCardID
                    Call Reset_Card()
                    txt_card_id_Validated(sender, e)
                End If
            Else
                Timer_Delay.Start()
                txt_card_id.Focus()
                Exit Sub
            End If
        Catch EX As Exception
            MsgBox("Samrt Card Please......" & EX.Message)
        End Try
    End Sub
    Private Sub txt_lostcardcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_lostcardcode.KeyPress
        Dim Sqlstring As String
        If Asc(e.KeyChar) = 13 Then
            Try
                If Trim(txt_lostcardcode.Text) <> "" Then
                    Dim CARDCODE1 As String
                    Sqlstring = "SELECT ISNULL([16_DIGIT_CODE],'') AS ID FROM SM_MEM_LINKAGE WHERE CARDCODE='" & Trim(txt_lostcardcode.Text) & "'"
                    gconnection.getDataSet(Sqlstring, "CARDCODE1")
                    If gdataset.Tables("CARDCODE1").Rows.Count > 0 Then
                        txt_card_id.Text = Trim(gdataset.Tables("CARDCODE1").Rows(0).Item("ID"))
                        txt_card_id.Focus()
                    End If
                End If
            Catch EX As Exception
                MsgBox(EX.Message)
            End Try
        End If
    End Sub
    Private Sub Pic_Member_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pic_Member.Click
        Dim file As New OpenFileDialog
        file.Filter = " Jpg(*.Jpg) | *.jpg"
        If Trim(txt_card_id.Text) <> "" Then
            If file.ShowDialog = DialogResult.OK Then
                Pic_Member.Image = New Bitmap(file.FileName)
                strPhotoFilePath = file.FileName
            End If
        End If
    End Sub

    Private Sub Timer_Delay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Delay.Tick
        'count = count + 1
        'If count Mod GBL_ReadDelay = 0 And Trim(txt_card_id.Text) = "" Then
        '    Timer_Delay.Start()
        '    Call GetSmartId()
        'End If
    End Sub
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
            lab_outstanding.Text = gdataset.Tables("CP_CRLIMIT").Rows(0).Item("USAGE")
        Else
            crstop = 0
            '           prvbal = 0
            flag = ""
            MemberOutstand = 0
            lab_outstanding.Text = "0.00"
        End If
        'If crstop > 0 Then
        '    creditstop = "DEFAULTER"
        'End If
        'If prvbal > 0 Then
        '    creditstop = "CREDIT STOP"
        'End If
        'If crstop > 0 And prvbal > 0 Then
        '    creditstop = "CREDIT STOP AND DEFAULTER"
        'End If
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

    Private Sub txt_card_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_card_id.TextChanged

    End Sub

    Private Sub CHK_PRINT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_PRINT.CheckedChanged

    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Call CloseSmartDevicePort()
        smartdeviceportcount = 0
        _BILLAMT = 0
        Amt = 0
        AMT1 = 0
        vCardcode = ""
        LAB_CARDBAL.Text = ""
        LAB_CARDBAL.Visible = False
        cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_SubPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        txt_BillAmount.Text = ""
        txt_BillNo.Text = ""
        txt_MemberCode.Text = ""
        dtp_BillDate.Enabled = True
        Txt_Remarks.Text = ""
        txt_MemberName.Text = ""
        lab_outstanding.Text = ""
        Amt = 0
        Call autogenerate()
        Call fillPayment_Mode()
        Call GridUnLocking()
        Cmd_Add.Enabled = True
        cmd_Delete.Enabled = True
        Pic_Member.Image = Nothing
        txt_card_id.Text = ""
        txt_Holder_Code.Text = ""
        Txt_holder_name.Text = ""
        MCODE_GBL = ""
        MNAME_GBL = ""
        txt_MemberCode.Text = ""
        txt_MemberName.Text = ""
        txt_MemberCode.Tag = ""
        Cmd_Add.Text = "Add [F7]"
        cbo_PaymentMode.Focus()
        For i = 0 To ssGrid.MaxRows
            ssGrid.Row = i
            ssGrid.Col = 1
            ssGrid.BackColor = Color.White
            ssGrid.ForeColor = Color.Black
        Next
        ssGrid.ClearRange(1, 1, -1, -1, True)
        ssGrid.SetActiveCell(1, 1)
        KotDetails = ""
        Me.KOT_Timer.Enabled = True
        Me.cmd_BillNoHelp.Enabled = True
        Me.Lbl_OtherBill.Visible = False
        Me.Cmd_Add.Enabled = True
        Me.txt_BillNo.ReadOnly = False
        cbo_SubPaymentMode.Visible = False
        lbl_SubPaymentMode.Visible = False
        lblCro1.Visible = False
        lblCro2.Visible = False
        Lbl_Bill.Text = ""
        Call cmd_Cancel_Click(sender, e)
        'Modified on 18 Mar'08
        'Mk Kannan
        'Begin
        lblDeleted.Visible = False
        'End
        LAB_SPILTMEMBER.Visible = False
        CMB_SPILTMEMBER.Visible = False
        grpPass.Visible = False
        grpNewMcode.Visible = False
        SETLEMENT_GROUP.Visible = True
        ssgrid_settlement.ClearRange(1, 1, -1, -1, True)
        ssgrid_settlement.SetActiveCell(1, 1)
        SETLEMENT_GROUP.Visible = False
        CHKALL.Checked = False
        CHKALL.Visible = False
        Call SetDateTime()
        'on may13
        'Call SYS_DATE_TIME()
        'Call txt_ServerCode_Validated(sender, e)
        CMB_BTYPE_SelectedIndexChanged(sender, e)
        Me.CMB_BTYPE.Enabled = True
        txt_ServerCode.ReadOnly = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_card_id.Focus()
    End Sub
    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Try
            Dim taxbilldetails, taxbillno, nontaxbilldetails, nontaxbillno, Otherbillno, poscode, jrnsql, jrnsql1 As String
            Dim Oldtaxbilldetails, Oldtaxbillno, Oldnontaxbilldetails, Oldnontaxbillno, OldOtherbillno, DESC As String
            Dim sqlstring, Varchk, SubpaymentMode(), paymentaccountcode, Subpaymentaccountcode As String
            Dim TotalAmount, TaxTotal, total, size, CardAmount, i, j, Z, dblCard, dblMinimum As Double
            Dim TaxApp, NoTax, Otherbool As Boolean
            Dim ttotal, tntotal, ttaxtotal, tntaxtotal As Double
            Dim Kot_Bill As New DataTable
            Dim Taxdr(), NoTaxDr() As DataRow
            Dim Update1(0) As String
            Dim Update2(0) As String
            Dim financalyear As String
            Dim DELSQL, sqlstringRoom As String
            TaxApp = False
            NoTax = False
            Call Randomize()
            vOutfile = Mid("jrnl" & (Rnd() * 800000), 1, 8)
            Update2(0) = " Exec Jrn_Kot_Det '" & vOutfile & "'"
            Call checkvalidate() '''---> Check Validation

            If chkbool = False Then Exit Sub
            ''''************************************************* Case-1:ADD [F7] ***********************************'''
            If Mid(CStr(Cmd_Add.Text), 1, 1) = "A" Then
                dblMsg = 0

                '*********************SMART CARD CARD
                'WITH MIN USAGE
                BILLAMT_GBL = Val(txt_BillAmount.Text)
                If cbo_PaymentMode.Text = "SMART CARD" Then
                    If (MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL < Val(txt_BillAmount.Text) Then
                        MsgBox("SUFFICIENT BALANCE NOT AVAILABLE", MsgBoxStyle.Critical)
                        Exit Sub
                    Else
                        'Txt_Remarks.Text = "OpBal : " & Format((MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL, "0.00") & " Trans Amt : " & Format(Val(txt_BillAmount.Text + Amt), "0.00") & "   ClsBal : " & Format(((MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL) - Val(txt_BillAmount.Text + Amt), "0.00")

                    End If
                End If

                '*********************SMART CARD CARD AMOUNT
                'BEGIN SMART CARD  WRITE BALANCE
                'If cbo_PaymentMode.Text = "SMART CARD" Then
                '    Dim CARDWRITEBALANCE As String
                '    CARDWRITEBALANCE = Trim(CStr((MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL + Val(txt_BillAmount.Text)))
                '    sqlstring = " SELECT * FROM SYSDATA "
                '    gconnection.getDataSet(sqlstring, "SYSDATA")
                '    If gdataset.Tables("SYSDATA").Rows.Count > 0 Then
                '        If Fast_Write_Card(5, 22, CARDWRITEBALANCE) = False Then
                '            MsgBox("CARD WRITE FAILED , CARD NOT ISSUED", MsgBoxStyle.Information)
                '            Exit Sub
                '        End If
                '    Else
                '        MsgBox("SECRET CODE NOT DEFINED")
                '    End If
                'End If

                Call autogenerate_add()

                KotDetails = ""
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Row = i
                    ssGrid.Col = 4
                    Varchk = ""
                    Varchk = ssGrid.Text
                    If Trim(Varchk & "") = "1" Then
                        ssGrid.Col = 1
                        If KotDetails = "" Then
                            KotDetails = "'" & Trim(ssGrid.Text) & "'"
                        Else
                            KotDetails = KotDetails & ",'" & Trim(ssGrid.Text) & "'"
                        End If
                    End If
                Next i
                If Trim(KotDetails) = "" Then
                    MessageBox.Show("Plz Select The Kots To Generate The Bill", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                '''******************************************* $ Find Out Paymentmode Accountcode and Subpaymentmode Accountcode $ *********************'''
                '''******************************************* $ CHECK IF THAT MEMBER HAV THE FACILITY OF USING CARD OR NOT      $ *********************'''
                If Trim(cbo_PaymentMode.Text) = "CARD" Then
                    sqlstring = "SELECT * FROM SMARTCARDDETAILS WHERE MCODE ='" & Trim(CStr(txt_MemberCode.Text)) & "' "
                    gconnection.getDataSet(sqlstring, "SMARTCARDDETAILS")
                    If gdataset.Tables("SMARTCARDDETAILS").Rows.Count > 0 Then
                        smartcardbool = True
                    Else
                        MessageBox.Show("Sorry this member don't hav card facility", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        txt_MemberCode.Focus()
                        smartcardbool = False
                        Exit Sub
                    End If
                End If
                '''************************************************** $ CHECK COMPLETED  $ ********************************************************************'''
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
                sqlstring = "SELECT Accountin FROM Paymentmodemaster WHERE Paymentcode ='" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(Freeze,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "Paymentmodemaster")
                If gdataset.Tables("Paymentmodemaster").Rows.Count > 0 Then
                    paymentaccountcode = Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin") & "")
                Else
                    MessageBox.Show("Assign a AccountCode For Specified PAYMENTMODE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    paymentaccountcode = ""
                    Exit Sub
                End If
                '''****************************************** $ In KotBill Table I am Storing The Kotdetails according to taxcode $ ******************'''
                sqlstring = "SELECT KOTDATE,KOTDetails,Isnull(TAxcode,'') AS Taxcode ,SUM(Amount) AS Amount,SUM(TaxAmount) AS TaxAmount FROM Kot_det WHERE Isnull(KotStatus,'') <> 'Y' AND Kotdetails IN( " & KotDetails & " ) GROUP BY KOTDATE,Taxcode,KotDetails ORDER BY Taxcode,KotDetails"
                Kot_Bill = gconnection.GetValues(sqlstring)
                '''****************************************** $ TaxDr Contains The Taxable Items $ ***********************************************'''
                Taxdr = Kot_Bill.Select("TaxCode <> ''")
                '''****************************************** $ NoTaxdr Contains The NonTaxable Items $ *****************************************'''
                NoTaxDr = Kot_Bill.Select("TaxCode = ''")
                If Taxdr.Length > 0 Then
                    size = (Taxdr.Length * 3)
                    TaxApp = True
                End If
                If NoTaxDr.Length > 0 Then
                    If Val(size) > 0 Then
                        size = size + (NoTaxDr.Length * 3)
                    Else
                        size = (NoTaxDr.Length * 3)
                    End If
                    NoTax = True
                End If
                Dim Update(size + 2) As String
                Billno = Split(Trim(txt_BillNo.Text), "/")
                BillDetails = Trim(Me.txt_BillNo.Text)
                If ssGrid.ActiveCol = 5 Or ssGrid.ActiveCol = 4 Then
                    Me.txt_BillAmount.Text = 0.0
                    For i = 1 To ssGrid.DataRowCnt
                        ssGrid.Row = i
                        ssGrid.Col = 4
                        Varchk = ""
                        Varchk = ssGrid.Text
                        If Trim(Varchk & "") = "1" Then
                            ssGrid.Col = 3
                            total = Val(ssGrid.Text)
                            Me.txt_BillAmount.Text = Format(Val(Me.txt_BillAmount.Text) + Val(total), "0.00")
                        End If
                    Next i
                End If
                If TaxApp = True Then
                    Dim x, y As String
                    taxbillno = Billno(1)
                    taxbilldetails = Trim(Me.txt_BillNo.Text)
                    If NoTax = True Then
                        Billno(1) = Convert.ToString(Val(Billno(1)) + 1)
                        Billno(1) = Format(Val(Billno(1)), "000000")
                        ' x = Trim(Me.txt_BillNo.Text).Substring(4, 6)
                        'X = gPoSUsername & "/" & Format(Billno(1), "000000") & "/" & Microsoft.VisualBasic.Right(Trim(txt_BillNo.Text), 5)
                        x = Trim(BillPrefix) & "/" & Billno(1) & "/" & Microsoft.VisualBasic.Right(Trim(txt_BillNo.Text), 5)
                        ' y = CStr(Val(x) + 1)
                        ' nontaxbilldetails = Trim(Me.txt_BillNo.Text).Replace(x, Format(Val(y), "000000"))
                        nontaxbilldetails = x
                        nontaxbillno = Billno(1)
                    Else
                        nontaxbilldetails = ""
                        nontaxbillno = ""
                    End If
                Else
                    taxbillno = ""
                    taxbilldetails = ""
                    nontaxbillno = Billno(1)
                    nontaxbilldetails = Trim(Me.txt_BillNo.Text)
                End If
                Oldtaxbillno = taxbillno
                Oldnontaxbillno = nontaxbillno
                Oldtaxbilldetails = taxbilldetails
                Oldnontaxbilldetails = nontaxbilldetails

                'SHAN
                '02/05/2008
                ''If NoTaxDr.Length > 0 And Taxdr.Length > 0 Then
                'If CHECK_BILLEXIST(nontaxbillno) = True Then
                'Exit Sub
                'End If
                'If CHECK_BILLEXIST(taxbillno) = True Then
                'Exit Sub
                'End If
                'ElseIf Taxdr.Length > 0 Then
                'If CHECK_BILLEXIST(taxbillno) = True Then
                'Exit Sub
                'End If
                'ElseIf NoTaxDr.Length > 0 Then
                'If CHECK_BILLEXIST(nontaxbillno) = True Then
                'Exit Sub
                'End If
                'End If

                If Taxdr.Length > 0 Then
                    TaxTotal = 0
                    TotalAmount = 0
                    j = 0
                    jrnsql1 = ""
                    For i = 0 To Taxdr.Length - 1
                        sqlstring = " INSERT INTO Bill_Det(Billno,BillDetails,BillDate,KotDetails,TaxAmount,KotAmount,OthBillDetails,KotDate,TaxCode) VALUES ("
                        sqlstring = sqlstring & "'" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Trim(CStr(Taxdr(i).Item("KotDetails"))) & "',"
                        sqlstring = sqlstring & "" & Val(Taxdr(i).Item("TaxAmount")) & "," & Val(Taxdr(i).Item("Amount")) & ",'" & Trim(CStr(nontaxbilldetails)) & "',"
                        sqlstring = sqlstring & "'" & Format(CDate(Taxdr(i).Item("KotDate")), "dd-MMM-yyyy") & "','" & Trim(Taxdr(i).Item("TaxCode")) & "')"
                        Update(j) = sqlstring
                        billstatus = "ST"
                        sqlstring = "UPDATE KOT_HDR SET "
                        sqlstring = sqlstring & "BillStatus='" & billstatus & "',Crostatus='N',PaymentType ='" & Trim(Me.cbo_PaymentMode.Text) & "',Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ',"
                        sqlstring = sqlstring & " SubPaymentMode ='" & Trim(SubpaymentMode(0)) & "',subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ' WHERE Kotdetails='" & Trim(CStr(Taxdr(i).Item("KotDetails"))) & "'"
                        j = j + 1
                        Update(j) = sqlstring
                        If i = 0 Then
                            jrnsql = ""
                            jrnsql = " Select *  into " & vOutfile & "  From kot_det where kotdetails in('" & Trim(CStr(Taxdr(i).Item("KotDetails")))
                        Else
                            jrnsql = jrnsql & "','" & Trim(CStr(Taxdr(i).Item("KotDetails")))
                        End If
                        jrnsql1 = jrnsql1 & " UPDATE " & vOutfile & " SET BillDetails='" & Trim(taxbilldetails) & "',PAYMENTMODE='" & Trim(Me.cbo_PaymentMode.Text) & "' "
                        jrnsql1 = jrnsql1 & " WHERE Kotdetails='" & Trim(CStr(Taxdr(i).Item("KotDetails"))) & "' and Isnull(Taxcode,'')<> '' "
                        sqlstring = " UPDATE KOT_DET SET BillDetails='" & Trim(taxbilldetails) & "',PAYMENTMODE='" & Trim(Me.cbo_PaymentMode.Text) & "' "
                        sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(Taxdr(i).Item("KotDetails"))) & "' and Isnull(Taxcode,'')<> ''"
                        j = j + 1
                        Update(j) = sqlstring
                        j = j + 1
                        TaxTotal = TaxTotal + Val(Taxdr(i).Item("TaxAmount"))
                        TotalAmount = TotalAmount + Val(Taxdr(i).Item("Amount"))
                    Next i
                    jrnsql = jrnsql & "')"
                    jrnsql = jrnsql & " AND isnull(delflag,'')<>'Y' AND ISNULL(KOTSTATUS,'')<>'Y' "
                    ReDim Preserve Update2(Update2.Length)
                    Update2(Update2.Length - 1) = jrnsql
                    ReDim Preserve Update2(Update2.Length)
                    Update2(Update2.Length - 1) = jrnsql1
                    If cbo_PaymentMode.SelectedItem = "ROOM" Then
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks,SECCODE,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & TaxTotal & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','','','" & Trim(Me.txt_ServerCode.Text) & "','','N'," & Val(Me.txt_MemberCode.Text) & ","
                        sqlstring = sqlstring & "" & Val(Me.txt_MemberCode.Tag) & ",'" & Trim(Me.txt_MemberName.Text) & "','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & seccode & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks,SECCODE,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        'sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & txt_MemberCode.Text & "','" & txt_MemberName.Text & "','" & Trim(Me.txt_ServerCode.Text) & "','','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & seccode & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"

                    ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks,SECCODE,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        'sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & txt_MemberCode.Text & "','" & txt_MemberName.Text & "','" & Trim(Me.txt_ServerCode.Text) & "','','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & seccode & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks,SECCODE,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        'sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & seccode & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks,SECCODE,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        'sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","

                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "( '" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & seccode & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
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
                                            If Val(gdataset.Tables("CardAmtMaster").Rows(0).Item("CardAmt")) >= Val(txt_BillAmount.Text) Then
                                                sqlstring = "UPDATE MEMBERMASTER SET CardAmt = CardAmt - " & Math.Round(Val(TotalAmount)) & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                                dblCard = Math.Round(Val(TotalAmount))
                                                dblMinimum = 0
                                                ReDim Preserve Update(Update.Length)
                                                Update(Update.Length - 1) = sqlstring
                                            Else
                                                MessageBox.Show("!!! Warning !!! Refill your CARD before using ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                cbo_PaymentMode.Focus()
                                                Exit Sub
                                            End If
                                        End If
                                    ElseIf Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) >= Val(TotalAmount) Then
                                        sqlstring = "UPDATE MEMBERMASTER SET Minimumusage = Minimumusage - " & Math.Round(Val(TotalAmount)) & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                        ReDim Preserve Update(Update.Length)
                                        Update(Update.Length - 1) = sqlstring
                                        dblCard = 0
                                        dblMinimum = Math.Round(Val(TotalAmount))
                                    ElseIf Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) <= Val(TotalAmount) And Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) > 0 Then
                                        sqlstring = "UPDATE MEMBERMASTER SET Minimumusage = 0 WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                        ReDim Preserve Update(Update.Length)
                                        Update(Update.Length - 1) = sqlstring
                                        dblMinimum = Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage"))
                                        CardAmount = Math.Round(Val(TotalAmount)) - Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage"))
                                        sqlstring = "SELECT CardAmt FROM MEMBERMASTER WHERE MCODE ='" & Trim(CStr(txt_MemberCode.Text)) & "' "
                                        gconnection.getDataSet(sqlstring, "CardAmtMaster")
                                        If gdataset.Tables("CardAmtMaster").Rows.Count > 0 Then
                                            If Val(gdataset.Tables("CardAmtMaster").Rows(0).Item("CardAmt")) >= Val(TotalAmount) Then
                                                sqlstring = "UPDATE MEMBERMASTER SET CardAmt = CardAmt - " & Format(Val(CardAmount), "0.00") & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                                ReDim Preserve Update(Update.Length)
                                                Update(Update.Length - 1) = sqlstring
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
                        '''***************************************************** $ COMPLETE CALCULATION FOR CARD PAYMENTMODE **********************************************************************'''
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,SECCODE,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        'sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'," & Format(Val(dblMinimum), "0.00") & "," & Format(Val(dblCard), "0.00") & ",'" & Trim(CStr(Txt_Remarks.Text)) & "','" & seccode & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    Else
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        'sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "',"
                        sqlstring = sqlstring & "'','N',0,0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    End If
                    Update(j) = sqlstring
                    TaxApp = True
                    ttaxtotal = TaxTotal
                    ttotal = TotalAmount
                End If
                If NoTaxDr.Length > 0 Then
                    TaxTotal = 0
                    TotalAmount = 0
                    '''************************************************** $ IF TAX ITEM IS INSERTED  $ ********************************************'''
                    If Val(j) > 0 Then
                        j = j + 1
                    End If
                    For i = 0 To NoTaxDr.Length - 1
                        sqlstring = " INSERT INTO Bill_Det(Billno,BillDetails,BillDate,KotDetails,TaxAmount,KotAmount,OthBilldetails,KotDate,TaxCode) VALUES("
                        sqlstring = sqlstring & "'" & Trim(CStr(nontaxbillno)) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Trim(CStr(NoTaxDr(i).Item("KotDetails"))) & "',"
                        sqlstring = sqlstring & "" & Val(NoTaxDr(i).Item("TaxAmount")) & "," & Val(NoTaxDr(i).Item("Amount")) & ",'" & Trim(taxbilldetails) & "','" & Format(CDate(NoTaxDr(i).Item("KotDate")), "dd-MMM-yyyy") & "','" & Val(NoTaxDr(i).Item("Taxcode")) & "')"
                        Update(j) = sqlstring

                        billstatus = "ST"
                        sqlstring = "UPDATE KOT_HDR SET "
                        sqlstring = sqlstring & "BillStatus='" & billstatus & "',Crostatus='N',PaymentType ='" & Trim(Me.cbo_PaymentMode.Text) & "',Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ',"
                        sqlstring = sqlstring & "SubPaymentMode ='" & Trim(SubpaymentMode(0)) & "',subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ' WHERE Kotdetails='" & Trim(CStr(NoTaxDr(i).Item("KotDetails"))) & "'"
                        j = j + 1
                        Update(j) = sqlstring



                        sqlstring = "UPDATE KOT_DET SET BillDetails='" & Trim(nontaxbilldetails) & "',PAYMENTMODE='" & Trim(Me.cbo_PaymentMode.Text) & "' "
                        sqlstring = sqlstring & "WHERE Kotdetails='" & Trim(CStr(NoTaxDr(i).Item("KotDetails"))) & "'and Isnull(Taxcode,'')='' "

                        j = j + 1
                        Update(j) = sqlstring
                        j = j + 1
                        TaxTotal = TaxTotal + Val(NoTaxDr(i).Item("TaxAmount"))
                        TotalAmount = TotalAmount + Val(NoTaxDr(i).Item("Amount"))
                    Next

                    If cbo_PaymentMode.SelectedItem = "ROOM" Then
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','','','" & Trim(Me.txt_ServerCode.Text) & "','','N'," & Val(Me.txt_MemberCode.Text) & ","
                        sqlstring = sqlstring & "" & Val(Me.txt_MemberCode.Tag) & ",'" & Trim(Me.txt_MemberName.Text) & "','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        'sqlstring = sqlstring & "('" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & txt_MemberCode.Text & "','" & txt_MemberName.Text & "','" & Trim(Me.txt_ServerCode.Text) & "','','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        'sqlstring = sqlstring & "('" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & txt_MemberCode.Text & "','" & txt_MemberName.Text & "','" & Trim(Me.txt_ServerCode.Text) & "','','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        'sqlstring = sqlstring & "('" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & txt_MemberCode.Text & "','" & txt_MemberName.Text & "','" & Trim(Me.txt_ServerCode.Text) & "','','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        'sqlstring = sqlstring & "('" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
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
                                            If Val(gdataset.Tables("CardAmtMaster").Rows(0).Item("CardAmt")) >= Val(txt_BillAmount.Text) Then
                                                sqlstring = "UPDATE MEMBERMASTER SET CardAmt = CardAmt - " & Math.Round(Val(TotalAmount)) & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                                dblCard = Math.Round(Val(TotalAmount))
                                                dblMinimum = 0
                                                ReDim Preserve Update(Update.Length)
                                                Update(Update.Length - 1) = sqlstring
                                            Else
                                                MessageBox.Show("!!! Warning !!! Refill your CARD before using ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                                cbo_PaymentMode.Focus()
                                                Exit Sub
                                            End If
                                        End If
                                    ElseIf Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) >= Val(TotalAmount) Then
                                        sqlstring = "UPDATE MEMBERMASTER SET Minimumusage = Minimumusage - " & Math.Round(Val(TotalAmount)) & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                        ReDim Preserve Update(Update.Length)
                                        Update(Update.Length - 1) = sqlstring
                                        dblCard = 0
                                        dblMinimum = Math.Round(Val(TotalAmount))
                                    ElseIf Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) <= Val(TotalAmount) And Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage")) > 0 Then
                                        sqlstring = "UPDATE MEMBERMASTER SET Minimumusage = 0 WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                        ReDim Preserve Update(Update.Length)
                                        Update(Update.Length - 1) = sqlstring
                                        dblMinimum = Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage"))
                                        CardAmount = Math.Round(Val(TotalAmount)) - Val(gdataset.Tables("MinimumusageMaster").Rows(0).Item("Minimumusage"))
                                        sqlstring = "SELECT CardAmt FROM MEMBERMASTER WHERE MCODE ='" & Trim(CStr(txt_MemberCode.Text)) & "' "
                                        gconnection.getDataSet(sqlstring, "CardAmtMaster")
                                        If gdataset.Tables("CardAmtMaster").Rows.Count > 0 Then
                                            If Val(gdataset.Tables("CardAmtMaster").Rows(0).Item("CardAmt")) >= Val(TotalAmount) Then
                                                sqlstring = "UPDATE MEMBERMASTER SET CardAmt = CardAmt - " & Format(Val(CardAmount), "0.00") & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                                ReDim Preserve Update(Update.Length)
                                                Update(Update.Length - 1) = sqlstring
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
                        '''***************************************************** $ COMPLETE CALCULATION FOR CARD PAYMENTMODE **********************************************************************'''
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(nontaxbillno)) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(nontaxbillno)) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & Trim(CStr(nontaxbillno)) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'," & Format(Val(dblMinimum), "0.00") & "," & Format(Val(dblCard), "0.00") & ",'" & Trim(CStr(Txt_Remarks.Text)) & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    Else
                        sqlstring = "INSERT INTO Bill_Hdr(BTYPE,Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,servicelocation,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks,[16_digit_code],cardholdercode,cardholdername) VALUES"
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Math.Round(Val(TotalAmount)) & "," & Amt & ","
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        Else
                            sqlstring = sqlstring & "('" & CMB_BTYPE.Text & "','" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(serverdate, "T") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & ","
                        End If
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "',"
                        sqlstring = sqlstring & "'','N',0,0,'','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
                    End If
                    j = j + 1
                    Update(j) = sqlstring
                    tntaxtotal = TaxTotal
                    tntotal = TotalAmount
                End If
                '''************************************************** $ IF TAX ITEM IS INSERTED  $ ********************************************'''
                '''''************************************************** $ BILL SETTLEMENT IF ANY   $ ********************************************'''

                'If NoTaxDr.Length > 0 And Taxdr.Length > 0 Then
                'If CHECK_BILLEXIST(nontaxbillno) = True Then
                'Exit Sub
                'End If
                'If CHECK_BILLEXIST(taxbillno) = True Then
                'Exit Sub
                'End If
                'ElseIf Taxdr.Length > 0 Then
                'If CHECK_BILLEXIST(taxbillno) = True Then
                'Exit Sub
                'End If
                'ElseIf NoTaxDr.Length > 0 Then
                'If CHECK_BILLEXIST(nontaxbillno) = True Then
                'Exit Sub
                'End If
                'End If
                'gconnection.MoreTransold(Update)

                'If NoTaxDr.Length > 0 And Taxdr.Length > 0 Then
                '    sqlstring = "Update PoSKotDoc Set DocNo = " & Val(nontaxbillno) & ",DOCFLAG='N' Where DocType = '" & Trim(BillPrefix) & "'"
                'ElseIf Taxdr.Length > 0 Then
                '    sqlstring = "Update PoSKotDoc Set DocNo = " & Val(taxbillno) & " ,DOCFLAG='N' Where DocType = '" & Trim(BillPrefix) & "'"
                'ElseIf NoTaxDr.Length > 0 Then
                '    sqlstring = "Update PoSKotDoc Set DocNo = " & Val(nontaxbillno) & " ,DOCFLAG='N' Where DocType = '" & Trim(BillPrefix) & "'"
                'End If
                'billno update

                sqlstring = "Update PoSKotDoc Set DocNo = " & Val(Mid(txt_BillNo.Text, 5, 6)) & ",DOCFLAG='N' Where DocType = '" & Trim(CMB_BTYPE.Text) & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = sqlstring


                'sqlstring = "SELECT MAX(BILLNO)  AS BNO FROM BILL_HDR WHERE SUBSTRING(BILLDETAILS,1,3)='" & Trim(CMB_BTYPE.Text) & "'"
                'gconnection.getDataSet(sqlstring, "BNO")
                'If gdataset.Tables("BNO").Rows.Count > 0 Then
                '    sqlstring = "Update PoSKotDoc Set DOCFLAG='N',DocNo = " & gdataset.Tables("BNO").Rows(0).Item("BNO") & " WHERE DocType = '" & Trim(CMB_BTYPE.Text) & "'"
                '    ReDim Preserve Update(Update.Length)
                '    Update(Update.Length - 1) = sqlstring
                'Else
                '    Exit Sub
                'End If

                ''============================================================================
                'If Len(Oldtaxbillno) > 0 Then
                ''**************************Inserting Data into ROOM LEDGER table **************************************

                If cbo_PaymentMode.SelectedItem = "ROOM" Then
                    If Len(Oldtaxbillno) > 0 Then
                        sqlstring = "INSERT INTO ROOMLEDGER(CHKNO,DOCNO,DOCDATE,DOCTYPE,FOLIONO,AMOUNT,POSCODE,"
                        sqlstring = sqlstring & "ROOMNO,REFNO,CREDITDEBIT,PAYMENTMODE,VOUCHERTYPE,VOUCHERCATEGORY,KOTNO)"
                        sqlstring = sqlstring & " Values('" & txt_MemberCode.Tag & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','SALES',1," & Math.Round(Val(ttotal) + Val(ttaxtotal)) & ","
                        sqlstring = sqlstring & "'" & loccode & "'," & Val(Me.txt_MemberCode.Text) & ",'" & txt_MemberCode.Tag & "','DEBIT','ROOM','RM','RM',1)"
                        ReDim Preserve Update(Update.Length)
                        Update(Update.Length - 1) = sqlstring
                        'gconnection.dataOperation(6, sqlstring, "ROOMLEDGER")
                    End If
                    If Len(Oldnontaxbillno) > 0 Then
                        sqlstring = "INSERT INTO ROOMLEDGER(CHKNO,DOCNO,DOCDATE,DOCTYPE,FOLIONO,AMOUNT,POSCODE,"
                        sqlstring = sqlstring & "ROOMNO,REFNO,CREDITDEBIT,PAYMENTMODE,VOUCHERTYPE,VOUCHERCATEGORY,KOTNO)"
                        sqlstring = sqlstring & " Values('" & txt_MemberCode.Tag & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','SALES',1," & Math.Round(Val(tntaxtotal) + Val(tntotal)) & ","
                        sqlstring = sqlstring & "'" & loccode & "'," & Val(Me.txt_MemberCode.Text) & ",'" & txt_MemberCode.Tag & "','DEBIT','ROOM','RM','RM',1)"
                        'gconnection.dataOperation(1, sqlstring, "ROOMLEDGER")
                        ReDim Preserve Update(Update.Length)
                        Update(Update.Length - 1) = sqlstring
                    End If
                End If
                '---------------------
                'Settlement 
                'begin
                With ssgrid_settlement
                    'If cbo_PaymentMode.SelectedItem <> "ROOM" Then
                    If .DataRowCnt = 1 Or .DataRowCnt = 0 Then
                        sqlstring = "INSERT INTO SETTLEMENT(BILLDETAILS,BILLDATE,MCODE,AMOUNT,DESCRIPTION,deleteflag,SBILLFLAG) "
                        sqlstring = sqlstring & "VALUES('" & txt_BillNo.Text & "','" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "',"
                        sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "'," & txt_BillAmount.Text & ",'','N','N')"
                        ReDim Preserve Update(Update.Length)
                        Update(Update.Length - 1) = sqlstring

                        sqlstring = "UPDATE BILL_HDR SET SBILLFLAG='N' WHERE BILLDETAILS='" & txt_BillNo.Text & "'"
                        ReDim Preserve Update(Update.Length)
                        Update(Update.Length - 1) = sqlstring
                    Else
                        For i = 1 To .DataRowCnt
                            sqlstring = "INSERT INTO SETTLEMENT(BILLDETAILS,BILLDATE,MCODE,AMOUNT,DESCRIPTION,DELETEFLAG,SBILLFLAG) "
                            sqlstring = sqlstring & "VALUES('" & txt_BillNo.Text & "','" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "',"
                            .Col = 1
                            .Row = i
                            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                            .Col = 2
                            .Row = i
                            sqlstring = sqlstring & Math.Round(Val(Trim(.Text)), 2) & ","
                            .Col = 3
                            .Row = i
                            sqlstring = sqlstring & "'" & Trim(.Text) & "','N','Y')"
                            ReDim Preserve Update(Update.Length)
                            Update(Update.Length - 1) = sqlstring
                        Next
                        sqlstring = "UPDATE BILL_HDR SET SBILLFLAG='Y' WHERE BILLDETAILS='" & txt_BillNo.Text & "'"
                        ReDim Preserve Update(Update.Length)
                        Update(Update.Length - 1) = sqlstring
                    End If
                End With
                '---------------------
                'Settlement 
                'end
                'journalentry 
                'begin
                'journalentry 
                'begin
                'If Trim(CMB_BTYPE.Text) = "BAR" Then
                DESC = txt_ServerName.Text
                'Else
                '   DESC = "RESTAURANT"
                'End If


                ''''''gconnection.MoreTransold1(Update2)
                ''''''If Trim(cbo_PaymentMode.Text) = "CREDIT" Then
                ''''''    sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' And ISNULL(SUBPAYSTATUS,'')<>'Y'"
                ''''''    gconnection.getDataSet(sqlstring, "AccountIn")
                ''''''    If (gdataset.Tables("AccountIn").Rows.Count > 0) Then
                ''''''        strSaleCostAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERCODE"))
                ''''''        strSaleCostAccountInDesc = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERDESC"))
                ''''''        strAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("AccountIn"))
                ''''''    Else
                ''''''        sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "'ISNULL(SUBPAYSTATUS,'')='N'"
                ''''''        strAccountIn = ""
                ''''''        strSaleCostAccountIn = ""
                ''''''        strSaleCostAccountInDesc = ""
                ''''''    End If
                ''''''Else
                ''''''    sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' And ISNULL(SUBPAYSTATUS,'')<>'Y'"
                ''''''    gconnection.getDataSet(sqlstring, "AccountIn")
                ''''''    If (gdataset.Tables("AccountIn").Rows.Count > 0) Then
                ''''''        strAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("AccountIn"))
                ''''''        strSaleCostAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERCODE"))
                ''''''        strSaleCostAccountInDesc = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERDESC"))
                ''''''    Else
                ''''''        sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "'ISNULL(SUBPAYSTATUS,'')='N'"
                ''''''        strAccountIn = ""
                ''''''        strSaleCostAccountIn = ""
                ''''''        strSaleCostAccountInDesc = ""
                ''''''    End If
                ''''''End If

                ''''''sqlstring = "select isnull(roundacctin,'') as rndoff_acode,isnull(roundacctdesc,'') as rndoff_desc  from  possetup "
                ''''''sqlstring = sqlstring & " where isnull(BILLROUNDOFF,'')='YES'"
                ''''''gconnection.getDataSet(sqlstring, "Rndoff")
                ''''''If (gdataset.Tables("Rndoff").Rows.Count > 0) Then
                ''''''    rndoff_acode = gdataset.Tables("Rndoff").Rows(0).Item("rndoff_acode")
                ''''''    rndoff_desc = gdataset.Tables("Rndoff").Rows(0).Item("rndoff_desc")
                ''''''Else
                ''''''    rndoff_acode = ""
                ''''''    rndoff_desc = ""
                ''''''End If

                ''''''If Me.cbo_SubPaymentMode.Visible = True Then
                ''''''    strAccountIn = Subpaymentaccountcode
                ''''''End If

                ''''''sqlstring = "SELECT ISNULL(MAX(ISNULL(BATCHNO,0)),0) AS BATCHNO FROM JOURNALENTRY"
                ''''''gconnection.getDataSet(sqlstring, "BatchNo")
                ''''''If (gdataset.Tables("BatchNo").Rows.Count > 0) Then
                ''''''    strBatchNo = Trim(gdataset.Tables("BatchNo").Rows(0).Item("BATCHNO"))
                ''''''Else
                ''''''    strBatchNo = ""
                ''''''End If
                ''''''Subledger_flag = ""
                ''''''If (strAccountIn <> "") Then
                ''''''    sqlstring = "SELECT ISNULL(ACDESC,'') AS ACDESC,isnull(subledgerflag,'') as subflg FROM ACCOUNTSGLACCOUNTMASTER WHERE ACCODE = '" & strAccountIn & "'"
                ''''''    gconnection.getDataSet(sqlstring, "AccountDesc")
                ''''''    If (gdataset.Tables("AccountDesc").Rows.Count > 0) Then
                ''''''        strAccountDesc = Trim(gdataset.Tables("AccountDesc").Rows(0).Item("ACDESC"))
                ''''''        Subledger_flag = Trim(gdataset.Tables("AccountDesc").Rows(0).Item("subflg"))
                ''''''    Else
                ''''''        strAccountDesc = ""
                ''''''        Subledger_flag = ""
                ''''''    End If

                ''''''End If

                ''''''sqlstring = " Delete from  Journalentry Where voucherno='" & txt_BillNo.Text & "'"
                ''''''ReDim Preserve Update(Update.Length)
                ''''''Update(Update.Length - 1) = sqlstring

                '''''''sqlstring = " UPDATE  OUTSTANDING SET VOID='Y' Where voucherno='" & txt_BillNo.Text & "'"
                '''''''ReDim Preserve Update(Update.Length)
                '''''''Update(Update.Length - 1) = sqlstring


                '''''''TAXCODE WISE INSERT IN JOURNALENTRY - CREDIT PART
                ''''''sqlstring = "Select Isnull(A.Billdetails,'') as Billdetails,Isnull(sum(A.TaxAMOUNT),0) as Amount,Isnull(B.Acdesc,'') as Acdesc,"
                ''''''sqlstring = sqlstring & "Isnull(A.Taxaccountcode,'') as Acctcode From " & vOutfile & "  A,Accountsglaccountmaster B "
                ''''''sqlstring = sqlstring & "Where Isnull(delFlag,'')<>'Y'  And A.TAXAccountcode=b.Accode "
                ''''''sqlstring = sqlstring & "And Isnull(Billdetails,'')='" & txt_BillNo.Text & "' "
                ''''''sqlstring = sqlstring & "Group by A.Taxaccountcode,A.billdetails,B.Acdesc "
                ''''''gconnection.getDataSet(sqlstring, "JrnTax")
                ''''''Jnltaxamount = 0
                ''''''If (gdataset.Tables("JrnTax").Rows.Count > 0) Then
                ''''''    For K = 0 To gdataset.Tables("JrnTax").Rows.Count - 1
                ''''''        strBatchNo = strBatchNo + 1
                ''''''        sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SlCode,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description,cashbank,instrumentdate,instrumenttype,instrumentno,bankname,bankplace,oppaccountcode) "
                ''''''        sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & Trim(gdataset.Tables("JrnTax").Rows(K).Item("Acctcode")) & "',''," & Trim(gdataset.Tables("Jrntax").Rows(K).Item("Amount")) & ",'CREDIT','" & Trim(gdataset.Tables("Jrntax").Rows(K).Item("Acdesc")) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                ''''''        sqlstring = sqlstring & strBatchNo & ",'" & DESC & "',"

                ''''''        If UCase(cbo_PaymentMode.Text) = "CASH" Then
                ''''''            sqlstring = sqlstring & "'CASH','','CASH','','','','" & strAccountIn & "')"

                ''''''            'ElseIf UCase(cbo_PaymentMode.Text) = "CARD" Or UCase(cbo_PaymentMode.Text) = "CHEQUE" Then
                ''''''            '    sqlstring = sqlstring & "'BANK','" & Format(DTP_CHKDATE.Value, "dd/MMM/yyyy") & "',"
                ''''''            '    sqlstring = sqlstring & "'BANK','" & Txt_InstNo.Text & "','" & Txt_DrawebankName.Text & "',"
                ''''''            '    sqlstring = sqlstring & "'" & Txt_BankPlace.Text & "','" & TXT_ACCTCODE.Text & "')"
                ''''''        Else
                ''''''            sqlstring = sqlstring & "'','','','','','','')"
                ''''''        End If


                ''''''        Jnltaxamount = Jnltaxamount + Val(gdataset.Tables("Jrntax").Rows(K).Item("Amount"))
                ''''''        ReDim Preserve Update(Update.Length)
                ''''''        Update(Update.Length - 1) = sqlstring

                ''''''        'If UCase(Subledger_flag) = "Y" Then
                ''''''        '    sqlstring = "Insert into outstanding(VoucherNo,VoucherDate,VoucherType,VoucherCategory,AccountCode,"
                ''''''        '    sqlstring = sqlstring & "SLCode,Amount,Description,CreditDebit,Void,AddUserId,AddDatetime)"
                ''''''        '    sqlstring = sqlstring & " Values ('" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & Trim(CMB_BTYPE.Text) & "','SALE',"
                ''''''        '    sqlstring = sqlstring & "'" & strAccountIn & "','" & txt_MemberCode.Text & "'," & Trim(gdataset.Tables("Jrntax").Rows(K).Item("Amount")) & ","
                ''''''        '    sqlstring = sqlstring & "'" & Trim(gdataset.Tables("JrnTAX").Rows(K).Item("Acdesc")) & "',','DEBIT','N','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "')"
                ''''''        '    ReDim Preserve Update(Update.Length)
                ''''''        '    Update1(Update1.Length - 1) = sqlstring
                ''''''        'End If
                ''''''    Next
                ''''''End If
                '''''''ACCOUNTS CODE WISE INSERT IN JOURNALENTRY - CREDIT PART
                ''''''sqlstring = "select Isnull(A.Billdetails,'') as Billdetails,Isnull(sum(A.AMOUNT),0) as Amount,ISNULL(A.COSTCODE,'') AS COSTCODE,"
                ''''''sqlstring = sqlstring & "Isnull(A.SalesAccountcode,'') as AcctCode,Isnull(B.Acdesc,'') as Acdesc From  " & vOutfile & " A, "
                ''''''sqlstring = sqlstring & "Accountsglaccountmaster B Where Isnull(A.delFlag,'')<>'Y' "
                ''''''sqlstring = sqlstring & "And Isnull(A.billdetails,'')='" & txt_BillNo.Text & "'  And A.SalesAccountcode=B.Accode "
                ''''''sqlstring = sqlstring & "Group by A.COSTCODE,A.SalesAccountcode,A.billdetails,B.Acdesc "
                ''''''gconnection.getDataSet(sqlstring, "JrnAcct")
                ''''''If (gdataset.Tables("JrnAcct").Rows.Count > 0) Then
                ''''''    Jnlamount = 0
                ''''''    For K = 0 To gdataset.Tables("JrnAcct").Rows.Count - 1
                ''''''        strBatchNo = strBatchNo + 1
                ''''''        sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,COSTCENTERCODE,SlCode,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description,cashbank,instrumentdate,instrumenttype,instrumentno,bankname,bankplace,oppaccountcode) "
                ''''''        sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & Trim(gdataset.Tables("JrnAcct").Rows(K).Item("Acctcode")) & "','" & Trim(gdataset.Tables("JrnAcct").Rows(K).Item("COSTCODE")) & "',''," & Trim(gdataset.Tables("JrnAcct").Rows(K).Item("Amount")) & ",'CREDIT','" & Trim(gdataset.Tables("JrnAcct").Rows(K).Item("Acdesc")) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                ''''''        sqlstring = sqlstring & strBatchNo & ",'" & DESC & "',"

                ''''''        If UCase(cbo_PaymentMode.Text) = "CASH" Then
                ''''''            sqlstring = sqlstring & "'CASH','','CASH','','','','" & strAccountIn & "')"

                ''''''            'ElseIf UCase(cbo_PaymentMode.Text) = "CARD" Or UCase(cbo_PaymentMode.Text) = "CHEQUE" Then
                ''''''            '    sqlstring = sqlstring & "'BANK','" & Format(DTP_CHKDATE.Value, "dd/MMM/yyyy") & "',"
                ''''''            '    sqlstring = sqlstring & "'BANK','" & Txt_InstNo.Text & "','" & Txt_DrawebankName.Text & "',"
                ''''''            '    sqlstring = sqlstring & "'" & Txt_BankPlace.Text & "','" & TXT_ACCTCODE.Text & "')"
                ''''''        Else
                ''''''            sqlstring = sqlstring & "'','','','','','','')"
                ''''''        End If

                ''''''        Jnlamount = Jnlamount + Val(gdataset.Tables("JrnAcct").Rows(K).Item("Amount"))
                ''''''        ReDim Preserve Update(Update.Length)
                ''''''        Update(Update.Length - 1) = sqlstring

                ''''''        'If UCase(Subledger_flag) = "Y" Then
                ''''''        '    sqlstring = "Insert into outstanding(VoucherNo,VoucherDate,VoucherType,VoucherCategory,AccountCode,"
                ''''''        '    sqlstring = sqlstring & "SLCode,Amount,Description,CreditDebit,Void,AddUserId,AddDatetime)"
                ''''''        '    sqlstring = sqlstring & " Values ('" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & Trim(CMB_BTYPE.Text) & "','SALE',"
                ''''''        '    sqlstring = sqlstring & "'" & strAccountIn & "','" & txt_MemberCode.Text & "'," & Trim(gdataset.Tables("JrnAcct").Rows(K).Item("Amount")) & ","
                ''''''        '    sqlstring = sqlstring & "'" & Trim(gdataset.Tables("JrnAcct").Rows(K).Item("Acdesc")) & "','DEBIT','N','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "')"
                ''''''        '    ReDim Preserve Update(Update.Length)
                ''''''        '    Update1(Update1.Length - 1) = sqlstring
                ''''''        'End If

                ''''''    Next
                ''''''End If
                '''''''MEMBER CODE WISE INSERT IN JOURNALENTRY - DEBIT PART
                '''''''MEMBER CODE WISE INSERT IN JOURNALENTRY - DEBIT PART
                ''''''With ssgrid_settlement
                ''''''    If .DataRowCnt > 1 Then
                ''''''        .SetActiveCell(1, 1)
                ''''''        For K = 1 To .DataRowCnt
                ''''''            STMcode = ""
                ''''''            _Billamount = 0.0
                ''''''            .Row = K
                ''''''            .Col = 1
                ''''''            STMcode = .Text
                ''''''            .Row = K
                ''''''            .Col = 2
                ''''''            _Billamount = .Text
                ''''''            strBatchNo = strBatchNo + 1

                ''''''            If cbo_PaymentMode.Text = "CARD" Or cbo_PaymentMode.Text = "CASH" Then
                ''''''                sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SLCODE,SlDesc,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                ''''''                sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','','',"
                ''''''                'sqlstring = sqlstring & Trim(STMcode) & "','',"
                ''''''                sqlstring = sqlstring & Format(Val(_Billamount), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                ''''''                sqlstring = sqlstring & strBatchNo & ",'" & DESC & "')"
                ''''''            ElseIf cbo_PaymentMode.Text = "ROOM" Then
                ''''''                sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,ROOMNO,SlDesc,REF_NO,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                ''''''                sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','"
                ''''''                sqlstring = sqlstring & Trim(STMcode) & "','','" & Val(roomchkno) & "',"
                ''''''                sqlstring = sqlstring & Format(Val(_Billamount), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                ''''''                sqlstring = sqlstring & strBatchNo & ",'" & DESC & "')"
                ''''''            Else
                ''''''                sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SlCode,SlDesc,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                ''''''                sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','"
                ''''''                sqlstring = sqlstring & Trim(STMcode) & "','',"
                ''''''                sqlstring = sqlstring & Format(Val(_Billamount), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                ''''''                sqlstring = sqlstring & strBatchNo & ",'" & DESC & "')"
                ''''''            End If

                ''''''            ReDim Preserve Update(Update.Length)
                ''''''            Update(Update.Length - 1) = sqlstring
                ''''''        Next
                ''''''    Else
                ''''''        strBatchNo = strBatchNo + 1

                ''''''        If UCase(cbo_PaymentMode.Text) = "CARD" Or UCase(cbo_PaymentMode.Text) = "CASH" Or UCase(cbo_PaymentMode.Text) = "CHEQUE" Then

                ''''''            sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SLCODE,SlDesc,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description,cashbank,instrumentdate,instrumenttype,instrumentno,bankname,bankplace,oppaccountcode) "
                ''''''            sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','','',"
                ''''''            'sqlstring = sqlstring & Trim(STMcode) & "','',"
                ''''''            sqlstring = sqlstring & Format(Val(Jnltaxamount + Jnlamount + Amt), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                ''''''            sqlstring = sqlstring & strBatchNo & ",'" & DESC & "',"
                ''''''            If UCase(cbo_PaymentMode.Text) = "CASH" Then
                ''''''                sqlstring = sqlstring & "'CASH','','CASH','','','','')"
                ''''''                'ElseIf UCase(cbo_PaymentMode.Text) = "CARD" Or UCase(cbo_PaymentMode.Text) = "CHEQUE" Then
                ''''''                '    sqlstring = sqlstring & "'BANK','" & Format(DTP_CHKDATE.Value, "dd/MMM/yyyy") & "',"
                ''''''                '    sqlstring = sqlstring & "'bank','" & Txt_InstNo.Text & "','" & Txt_DrawebankName.Text & "',"
                ''''''                '    sqlstring = sqlstring & "'" & Txt_BankPlace.Text & "','')"
                ''''''            Else
                ''''''                sqlstring = sqlstring & "'','','','','','','')"
                ''''''            End If

                ''''''        ElseIf cbo_PaymentMode.Text = "ROOM" Then
                ''''''            sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,ROOMNO,SlDesc,REF_NO,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                ''''''            sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','"
                ''''''            sqlstring = sqlstring & Trim(txt_MemberCode.Text) & "','','" & Val(roomchkno) & "',"
                ''''''            sqlstring = sqlstring & Format(Val(Jnltaxamount + Jnlamount + Amt), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                ''''''            sqlstring = sqlstring & strBatchNo & ",'" & DESC & "')"
                ''''''        Else
                ''''''            sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SlCode,SlDesc,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                ''''''            sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','"
                ''''''            sqlstring = sqlstring & Trim(txt_MemberCode.Text) & "','',"
                ''''''            sqlstring = sqlstring & Format(Val(Jnltaxamount + Jnlamount + Amt), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                ''''''            sqlstring = sqlstring & strBatchNo & ",'" & DESC & "')"
                ''''''        End If
                ''''''        'sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SlCode,SlDesc,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                ''''''        'sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','" & Trim(CMB_BTYPE.Text) & "','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','"
                ''''''        'sqlstring = sqlstring & Trim(txt_MemberCode.Text) & "','" & txt_MemberName.Text & "',"
                ''''''        'sqlstring = sqlstring & Format(Val(Jnltaxamount + Jnlamount), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                ''''''        'sqlstring = sqlstring & strBatchNo & ",'POSTING FROM POS - " & Trim(CMB_BTYPE.Text) & "')"

                ''''''        ReDim Preserve Update(Update.Length)
                ''''''        Update(Update.Length - 1) = sqlstring
                ''''''    End If
                ''''''End With
                '''''''----round off posting
                ''''''If Amt <> 0 And Trim(rndoff_acode) <> "" Then
                ''''''    strBatchNo = strBatchNo + 1
                ''''''    sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SlCode,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description,cashbank,instrumentdate,instrumenttype,instrumentno,bankname,bankplace,oppaccountcode) "
                ''''''    sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & Trim(rndoff_acode) & "',''," & Math.Abs(Amt) & ",'" & IIf(Amt > 0, "CREDIT", "DEBIT") & "','" & Trim(rndoff_desc) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                ''''''    sqlstring = sqlstring & strBatchNo & ",'" & DESC & "',"
                ''''''    If Amt > 0 Then
                ''''''        If UCase(cbo_PaymentMode.Text) = "CASH" Then
                ''''''            sqlstring = sqlstring & "'CASH','','CASH','','','','" & strAccountIn & "')"

                ''''''            'ElseIf UCase(cbo_PaymentMode.Text) = "CARD" Or UCase(cbo_PaymentMode.Text) = "CHEQUE" Then
                ''''''            '    sqlstring = sqlstring & "'BANK','" & Format(DTP_CHKDATE.Value, "dd/MMM/yyyy") & "',"
                ''''''            '    sqlstring = sqlstring & "'BANK','" & Txt_InstNo.Text & "','" & Txt_DrawebankName.Text & "',"
                ''''''            '    sqlstring = sqlstring & "'" & Txt_BankPlace.Text & "','" & TXT_ACCTCODE.Text & "')"
                ''''''        Else
                ''''''            sqlstring = sqlstring & "'','','','','','','')"
                ''''''        End If
                ''''''    Else
                ''''''        sqlstring = sqlstring & "'','','','','','','')"
                ''''''    End If
                ''''''    ReDim Preserve Update(Update.Length)
                ''''''    Update(Update.Length - 1) = sqlstring
                ''''''End If
                'sqlstring = " Drop Table  " & vOutfile

                sqlstring = " Exec Jrn_Kot_Det '" & vOutfile & "'"

                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = sqlstring
                sqlstring = " UPDATE BILL_HDR SET PACKAMOUNT=ISNULL(PACKAMOUNT,0) WHERE BILLDETAILS='" & txt_BillNo.Text & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = sqlstring
                sqlstring = " update Bill_hdr set packamount=isnull(b.packamount,0),Ser_Chg=isnull(b.Ser_chg,0)  from bill_hdr a, view_kot  b "
                sqlstring = sqlstring & " where a.billdetails=b.billdetails and a.billdetails='" & txt_BillNo.Text & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = sqlstring

                sqlstring = " UPDATE ROOMLEDGER SET AMOUNT=ISNULL(B.TOTALAMOUNT,0)+ISNULL(B.ROUNDOFF,0) FROM  ROOMLEDGER A,BILL_HDR B WHERE B.BILLDETAILS=A.DOCNO AND  A.DOCNO='" & txt_BillNo.Text & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = sqlstring

                sqlstring = "select * from BILL_HDR where BILLdetails='" & txt_BillNo.Text & "'"
                'ReDim Preserve Update(Update.Length)
                'Update(Update.Length - 1) = sqlstring
                gconnection.getDataSet(sqlstring, "BILLNO")
                If gdataset.Tables("BILLNO").Rows.Count > 0 Then
                    sqlstring = "SELECT MAX(BILLNO)  AS BNO FROM BILL_HDR WHERE SUBSTRING(BILLDETAILS,1,3)='" & Trim(CMB_BTYPE.Text) & "'"
                    gconnection.getDataSet(sqlstring, "BNO")
                    If gdataset.Tables("BNO").Rows.Count > 0 Then
                        sqlstring = "Update PoSKotDoc Set DocNo = " & gdataset.Tables("BNO").Rows(0).Item("BNO") & " WHERE  DocType = '" & Trim(CMB_BTYPE.Text) & "'"
                        gconnection.dataOperation(9, sqlstring, "upd")
                        Call Cmd_Add_Click(sender, e)
                    End If
                Else

                    'gconnection.MoreTransold(Update)
                    'CSC SMARTCARD
                    '****************SHOW SMART CARD CARD TRANSACTION*****************

                    Dim STRSQL2, SSTR As String
                    'STRSQL2 = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & cardcode & "' AND POSCODE='" & StrPOSCODE & "'"
                    STRSQL2 = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & cardcode & "' "
                    gconnection.getDataSet(STRSQL2, "SM_CARDFILE_DET")
                    If gdataset.Tables("SM_CARDFILE_DET").Rows.Count > 0 Then
                        POS_AMT_GBL = Val(txt_BillAmount.Text)
                        STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'FF' "
                        gconnection.getDataSet(STRSQL2, "FACILITY")
                        If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                            'ONCE FACILITY 
                            KOT_NO_GBL = Trim(txt_BillNo.Text)
                            gconnection.MoreTransold(Update)
                            If CHK_PRINT.Checked = True Then
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
                            Call autogenerate_add()

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
                                If MIN_USAGE_BALANCE_HDR >= Val(txt_BillAmount.Text) Then

                                    STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ('" & txt_card_id.Text & "', '" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_BillNo.Text) & "'," & Val(txt_BillAmount.Text) & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FM')"
                                    ReDim Preserve Update(Update.Length)
                                    Update(Update.Length - 1) = STRSQL

                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & Val(txt_BillAmount.Text) & " WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update(Update.Length)
                                    Update(Update.Length - 1) = STRSQL


                                ElseIf MIN_USAGE_BALANCE_HDR <= 0 Then
                                    'DEDUCT AMOUNT ONLY FROM CARD

                                    Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                                    DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR
                                    DEDUCT_FROM_CARD = Val(txt_BillAmount.Text) - MIN_USAGE_BALANCE_HDR

                                    'FOR BALANCE
                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update(Update.Length)
                                    Update(Update.Length - 1) = STRSQL

                                    'FOR EBALANCE

                                    Dim BALstr, EBAL As String
                                    Dim BALnum As Double
                                    sqlstring = " SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] = '" & Trim(txt_card_id.Text) & "' "
                                    gconnection.getDataSet(sqlstring, "CARDFILE_HDR_BAL")
                                    If gdataset.Tables("CARDFILE_HDR_BAL").Rows.Count > 0 Then
                                        If IsDBNull(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) = False Then
                                            BALnum = abcdMINUS(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) - Val(DEDUCT_FROM_CARD)
                                        Else '--for zero
                                            BALnum = 0 - Val(DEDUCT_FROM_CARD)
                                        End If
                                    End If
                                    EBAL = abcdADD(BALnum)

                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET EBALANCE = '" & Trim(EBAL) & "' WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update(Update.Length)
                                    Update(Update.Length - 1) = STRSQL
                                    'END

                                    STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_BillNo.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FC')"
                                    ReDim Preserve Update(Update.Length)
                                    Update(Update.Length - 1) = STRSQL

                                ElseIf MIN_USAGE_BALANCE_HDR > 0 And MIN_USAGE_BALANCE_HDR < Val(txt_BillAmount.Text) Then

                                    Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                                    DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR
                                    DEDUCT_FROM_CARD = Val(txt_BillAmount.Text) - MIN_USAGE_BALANCE_HDR

                                    STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_BillNo.Text) & "'," & DEDUCT_FROM_MINUSAGE & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HM')"
                                    ReDim Preserve Update(Update.Length)
                                    Update(Update.Length - 1) = STRSQL


                                    STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_BillNo.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HC')"
                                    ReDim Preserve Update(Update.Length)
                                    Update(Update.Length - 1) = STRSQL


                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & DEDUCT_FROM_MINUSAGE & " WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update(Update.Length)
                                    Update(Update.Length - 1) = STRSQL

                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update(Update.Length)
                                    Update(Update.Length - 1) = STRSQL

                                    'FOR EBALANCE

                                    Dim BALstr, EBAL As String
                                    Dim BALnum As Double
                                    sqlstring = " SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] = '" & Trim(txt_card_id.Text) & "' "
                                    gconnection.getDataSet(sqlstring, "CARDFILE_HDR_BAL")
                                    If gdataset.Tables("CARDFILE_HDR_BAL").Rows.Count > 0 Then
                                        If IsDBNull(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) = False Then
                                            BALnum = abcdMINUS(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) - Val(DEDUCT_FROM_CARD)
                                        Else '--for zero
                                            BALnum = 0 - Val(DEDUCT_FROM_CARD)
                                        End If
                                    End If
                                    EBAL = abcdADD(BALnum)
                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET EBALANCE = '" & Trim(EBAL) & "' WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update(Update.Length)
                                    Update(Update.Length - 1) = STRSQL
                                    'END

                                End If
                                'Else
                                '   STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(TXT_BILLNO.Text) & "'," & Val(txt_BillAmount.Text) & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','O')"
                                '  ReDim Preserve Insert(Insert.Length)
                                ' Insert(Insert.Length - 1) = STRSQL
                            End If
                            gconnection.MoreTransold(Update)
                            If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                                Call Cmd_Print_Click(cmd_View, e)
                                Call cmd_Clear_Click(sender, e)
                                '***********CHANGE
                                MNAME_GBL = ""
                                MCODE_GBL = ""
                                cardcode = ""
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
                            'If CHK_PRINT.Checked = True Then
                            '    Call Cmd_Print_Click(Cmd_Print, e)
                            '    Call cmd_Clear_Click(sender, e)
                            'Else
                            '    Call cmd_Clear_Click(sender, e)
                            'End If
                        End If
                    Else
                        gconnection.MoreTransold(Update)
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

                Call txt_MemberCode_Validated(sender, e)


                If gFoto = "Y" Then
                    Call foto.SaveFoto(strPhotoFilePath, Trim(txt_card_id.Text))
                End If


                If dblMsg <> 1 Then
                    If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Call Cmd_Print_Click(cmd_View, e)
                        Call cmd_Clear_Click(sender, e)
                    Else
                        Call cmd_Clear_Click(sender, e)
                    End If
                Else
                    Cmd_Add.Focus()
                End If

            ElseIf Mid(CStr(Cmd_Add.Text), 1, 1) = "U" Then
                dblMsg = 0

                '''******************************************* $ Find Out Paymentmode Accountcode and Subpaymentmode Accountcode $ *********************'''
                'Added on 18 Mar'08
                'Bill Matching Validation
                'Mk Kannan
                'Begin
                'gconnection.getDataSet("select mcode from kot_det where mcode='" & Me.txt_MemberCode.Text & "' and billdetails='" & Me.txt_BillNo.Text & "'", "CHKMCODE")

                'If gdataset.Tables("CHKMCODE").Rows.Count = 0 Then
                '    MessageBox.Show("This is not a valid combination", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    Exit Sub
                'End If


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



                If ssGrid.DataRowCnt = 0 Then
                    MessageBox.Show("Details is not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
                Dim dt As New DataTable
                sqlstring = "SELECT * FROM MATCHING WHERE VOUCHERNO = '" & Trim(txt_BillNo.Text) & "' AND VOUCHERDATE = '" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "'"
                dt = gconnection.GetValues(sqlstring)
                If (dt.Rows.Count > 0) Then
                    MsgBox("Sorry, Bill Matching Was Already Made, You Can't Update....")
                    Call cmd_Clear_Click(cmd_Clear, e)
                    Exit Sub
                End If
                'End
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
                sqlstring = "SELECT Accountin FROM Paymentmodemaster WHERE Paymentcode ='" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(Freeze,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "Paymentmodemaster")
                If gdataset.Tables("Paymentmodemaster").Rows.Count > 0 Then
                    paymentaccountcode = Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin") & "")
                Else
                    MessageBox.Show("Assign a AccountCode For Specified PAYMENTMODE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    paymentaccountcode = ""
                    Exit Sub
                End If
                If Me.Lbl_Bill.Visible = True And Me.Lbl_Bill.Text = "C R O  G E N E R A T E D" Then
                    MessageBox.Show("As CRO is generated so Bill Can't be modified", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Call cmd_Clear_Click(cmd_Clear, e)
                    Cmd_Add.Enabled = True
                    Exit Sub
                Else
                    If cbo_PaymentMode.SelectedItem = "ROOM" Then
                        sqlstring = "SELECT ISNULL(CHECKOUT,'N') AS CHECKOUT,ISNULL(ROOMNO,0)AS ROOMNO FROM Roomcheckin WHERE docno = " & Val(txt_MemberCode.Tag) & ""
                        gconnection.getDataSet(sqlstring, "Roomcheckin")
                        If gdataset.Tables("Roomcheckin").Rows.Count > 0 Then
                            If Trim(CStr(gdataset.Tables("Roomcheckin").Rows(0).Item("CHECKOUT"))) = "Y" Then
                                MessageBox.Show("Bill Can't be updated " & vbCrLf & " as GUEST  has been checkout from RoomNo" & ": " & gdataset.Tables("ROOMLEDGER").Rows(0).Item("ROOMNO"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                                Call cmd_Clear_Click(cmd_Clear, e)
                                Cmd_Add.Enabled = True
                                Exit Sub
                            End If
                        End If
                        sqlstring = "UPDATE Bill_Hdr SET BTYPE='" & CMB_BTYPE.Text & "',PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                        ''sqlstring = sqlstring & "servicelocation='" & loccode & "',"
                        sqlstring = sqlstring & "Mcode='',Mname='',SERVICELOCATION='" & Trim(Me.txt_ServerCode.Text) & "',sname='',Roomno=" & Val(Me.txt_MemberCode.Text) & ",ChkId=" & Val(Me.txt_MemberCode.Tag) & ",Guest='" & Trim(Me.txt_MemberName.Text) & "',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then

                        sqlstring = "UPDATE Bill_Hdr SET BTYPE='" & CMB_BTYPE.Text & "',PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                        ''sqlstring = sqlstring & "servicelocation='" & loccode & "',"
                        sqlstring = sqlstring & "Mcode='" & txt_MemberCode.Text & "',Mname='" & txt_MemberName.Text & "',SERVICELOCATION='" & Trim(Me.txt_ServerCode.Text) & "',sname='',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                        sqlstring = "UPDATE Bill_Hdr SET BTYPE='" & CMB_BTYPE.Text & "',PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                        ''sqlstring = sqlstring & "servicelocation='" & loccode & "',"

                        sqlstring = sqlstring & "Mcode='" & txt_MemberCode.Text & "',Mname='" & txt_MemberName.Text & "',SERVICELOCATION='" & Trim(Me.txt_ServerCode.Text) & "',sname='',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                        sqlstring = "UPDATE Bill_Hdr SET BTYPE='" & CMB_BTYPE.Text & "',PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                        ''sqlstring = sqlstring & "servicelocation='" & loccode & "',"

                        sqlstring = sqlstring & "Mcode='" & txt_MemberCode.Text & "',Mname='" & txt_MemberName.Text & "',SERVICELOCATION='" & Trim(Me.txt_ServerCode.Text) & "',sname='',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                        sqlstring = "UPDATE Bill_Hdr SET BTYPE='" & CMB_BTYPE.Text & "',PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"

                        ''sqlstring = sqlstring & "servicelocation='" & loccode & "',"
                        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',SERVICELOCATION='" & Trim(Me.txt_ServerCode.Text) & "',sname='',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "N.CREDIT" Then
                        sqlstring = "UPDATE Bill_Hdr SET BTYPE='" & CMB_BTYPE.Text & "',PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"
                        '' sqlstring = sqlstring & "servicelocation='" & loccode & "',"
                        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',SERVICELOCATION='" & Trim(Me.txt_ServerCode.Text) & "',sname='',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "PARTY" Then
                        sqlstring = "UPDATE Bill_Hdr SET BTYPE='" & CMB_BTYPE.Text & "',PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"
                        ''sqlstring = sqlstring & "servicelocation='" & loccode & "',"
                        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',SERVICELOCATION='" & Trim(Me.txt_ServerCode.Text) & "',sname='',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    Else
                        sqlstring = "UPDATE Bill_Hdr SET BTYPE='" & CMB_BTYPE.Text & "',PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                        ''sqlstring = sqlstring & "servicelocation='" & loccode & "',"
                        sqlstring = sqlstring & "BILLDATE='" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "',"
                        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',SERVICELOCATION='" & Trim(Me.txt_ServerCode.Text) & "',sname='',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                        DELSQL = " DELETE FROM ROOMLEDGER WHERE DOCNO = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                        '=========================================
                        ''sqlstringRoom = "SELECT ISNULL(CHECKOUT,'N') AS CHECKOUT,ISNULL(ROOMNO,0)AS ROOMNO FROM Roomcheckin WHERE docno = " & Val(txt_MemberCode.Tag) & ""
                        ''gconnection.getDataSet(sqlstringRoom, "Roomcheckin")
                        ''If gdataset.Tables("Roomcheckin").Rows.Count > 0 Then
                        ''    If Trim(CStr(gdataset.Tables("Roomcheckin").Rows(0).Item("CHECKOUT"))) = "Y" Then
                        ''        'MessageBox.Show("Bill Can't be updated " & vbCrLf & " as GUEST  has been checkout from RoomNo" & ": " & gdataset.Tables("ROOMLEDGER").Rows(0).Item("ROOMNO"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        ''        MessageBox.Show("Bill Can't be updated  as GUEST  has been checked out from Room: ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        ''        Call Cmd_Clear_Click(Cmd_Clear, e)
                        ''        Cmd_Add.Enabled = True
                        ''        Exit Sub
                        ''    End If
                        ''End If
                        '=========================================
                    End If
                    Update1(0) = sqlstring
                    ReDim Preserve Update1(Update1.Length)
                    Update1(Update1.Length - 1) = DELSQL

                    '''************************************* FIND IF THAT PARTICULAR BILL HAVE OTHER BILL OR NOT *****************'''
                    ''Chenging on 17.08.2008
                    ''======================
                    'sqlstring = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    'gconnection.getDataSet(sqlstring, "Bill_det")
                    'If gdataset.Tables("Bill_det").Rows.Count > 0 Then
                    '    Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
                    '    Otherbool = True
                    'Else
                    '    Otherbool = False
                    'End If

                    'If Otherbool = True Then
                    '    If cbo_PaymentMode.SelectedItem = "ROOM" Then
                    '        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                    '        sqlstring = sqlstring & "Mcode='',Mname='',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=" & Val(Me.txt_MemberCode.Text) & ",ChkId=" & Val(Me.txt_MemberCode.Tag) & ",Guest='" & Trim(Me.txt_MemberName.Text) & "',"
                    '        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                    '    ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
                    '        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                    '        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                    '        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                    '    ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                    '        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                    '        sqlstring = sqlstring & "Mcode='" & txt_MemberCode.Text & "',Mname='" & txt_MemberName.Text & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                    '        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                    '    ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                    '        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                    '        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                    '        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                    '    ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                    '        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"
                    '        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                    '        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                    '    ElseIf cbo_PaymentMode.SelectedItem = "N.CREDIT" Then
                    '        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"
                    '        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                    '        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                    '    Else
                    '        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                    '        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                    '        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                    '        DELSQL = " DELETE FROM ROOMLEDGER WHERE DOCNO = '" & Trim(CStr(Otherbillno)) & "'"
                    '    End If
                    '    ReDim Preserve Update1(Update1.Length)
                    '    Update1(Update1.Length - 1) = sqlstring
                    '    ReDim Preserve Update1(Update1.Length)
                    '    Update1(Update1.Length - 1) = DELSQL
                    'End If
                    ''===========================================End of changing

                    '''************************************************************* COMPLETE UPDATE FOR OTHERBILL **************************
                    '''************************************************************* UPDATEING KOT_HDR  *************************************
                    If cbo_PaymentMode.SelectedItem = "ROOM" Then
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '' ,Mcode ='' ,Mname ='',"
                            sqlstring = sqlstring & " Roomno='" & Trim(Me.txt_MemberCode.Text) & "',checkin='" & Trim(Me.txt_MemberCode.Tag) & "',"
                            sqlstring = sqlstring & "servicelocation='" & txt_ServerCode.Text & "',"
                            sqlstring = sqlstring & "Guest='" & Trim(Me.txt_MemberName.Text) & "' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ' ,"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "',"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '' ,Mcode ='" & Trim(Me.txt_MemberCode.Text) & "' ,Mname ='" & Trim(txt_MemberName.Text) & "',"
                            sqlstring = sqlstring & "servicelocation='" & loccode & "',"
                            sqlstring = sqlstring & " roomno='' ,checkin='',"
                            sqlstring = sqlstring & "Guest='' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ',"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            ''sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' , PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '" & txt_MemberCode.Text & "' ,Mcode ='" & txt_MemberCode.Text & "' ,Mname ='" & txt_MemberName.Text & "',"
                            sqlstring = sqlstring & "servicelocation='" & txt_ServerCode.Text & "',"
                            sqlstring = sqlstring & "roomno='' ,checkin='' ,"
                            sqlstring = sqlstring & "Guest='' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ' ,"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            ''sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' , PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '' ,Mcode ='" & Trim(Me.txt_MemberCode.Text) & "' ,Mname ='" & Trim(txt_MemberName.Text) & "' ,STcode = '" & Trim(Me.txt_ServerCode.Text) & "',Servercode ='" & Trim(Me.txt_ServerCode.Text) & "' ,"
                            sqlstring = sqlstring & "servicelocation='" & txt_ServerCode.Text & "',"
                            sqlstring = sqlstring & "roomno='' ,checkin='' ,"
                            sqlstring = sqlstring & "Guest='' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ' ,"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' , PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            ''sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '" & Trim(txt_MemberCode.Text) & "' ,Mcode ='" & Trim(txt_MemberCode.Text) & "' ,Mname ='" & Trim(txt_MemberName.Text) & "',"
                            sqlstring = sqlstring & "servicelocation='" & txt_ServerCode.Text & "',"
                            sqlstring = sqlstring & " roomno='' ,checkin='' ,"
                            sqlstring = sqlstring & "Guest='' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode = 'SDRS',"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            ''sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' , PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "' ,"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    Else
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '" & Trim(txt_MemberCode.Text) & "' ,Mcode ='" & Trim(txt_MemberCode.Text) & "' ,Mname ='" & Trim(txt_MemberName.Text) & "' ,"
                            sqlstring = sqlstring & "servicelocation='" & txt_ServerCode.Text & "',"
                            sqlstring = sqlstring & " roomno='' ,checkin='' ,"
                            sqlstring = sqlstring & "Guest='' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode = '" & Trim(paymentaccountcode) & " ',"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            ''sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' , PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "',"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    End If
                    '---------------------
                    'Settlement 
                    'begin

                    sqlstring = "delete from settlement where billdetails='" & txt_BillNo.Text & "'"
                    ReDim Preserve Update1(Update1.Length)
                    Update1(Update1.Length - 1) = sqlstring
                    With ssgrid_settlement
                        If .DataRowCnt = 1 Or .DataRowCnt = 0 Then
                            sqlstring = "INSERT INTO SETTLEMENT(BILLDETAILS,BILLDATE,MCODE,AMOUNT,DESCRIPTION,deleteflag,SBILLFLAG) "
                            sqlstring = sqlstring & "VALUES('" & txt_BillNo.Text & "','" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "',"
                            sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "'," & txt_BillAmount.Text & ",'','N','N')"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring

                            sqlstring = "UPDATE BILL_HDR SET SBILLFLAG='N' WHERE BILLDETAILS='" & txt_BillNo.Text & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Else
                            For i = 1 To .DataRowCnt
                                sqlstring = "INSERT INTO SETTLEMENT(BILLDETAILS,BILLDATE,MCODE,AMOUNT,DESCRIPTION,DELETEFLAG,SBILLFLAG) "
                                sqlstring = sqlstring & "VALUES('" & txt_BillNo.Text & "','" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "',"
                                .Col = 1
                                .Row = i
                                sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                                .Col = 2
                                .Row = i
                                sqlstring = sqlstring & Math.Round(Val(Trim(.Text)), 2) & ","
                                .Col = 3
                                .Row = i
                                sqlstring = sqlstring & "'" & Trim(.Text) & "','N','Y')"
                                ReDim Preserve Update1(Update1.Length)
                                Update1(Update1.Length - 1) = sqlstring
                            Next
                            sqlstring = "UPDATE BILL_HDR SET SBILLFLAG='Y' WHERE BILLDETAILS='" & txt_BillNo.Text & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        End If
                    End With
                    '---------------------
                    'Settlement 
                    'end
                    'journalentry 
                    'begin
                    'gconnection.MoreTransold1(Update2)
                    'journalentry 
                    'begin

                    'If Trim(CMB_BTYPE.Text) = "BAR" Then
                    DESC = txt_ServerName.Text
                    'Else
                    'DESC = "RESTAURANT"
                    'End If
                    '''''gconnection.MoreTransold1(Update2)
                    '''''If Trim(cbo_PaymentMode.Text) = "CREDIT" Then
                    '''''    sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' And ISNULL(SUBPAYSTATUS,'')<>'Y'"
                    '''''    gconnection.getDataSet(sqlstring, "AccountIn")
                    '''''    If (gdataset.Tables("AccountIn").Rows.Count > 0) Then
                    '''''        strSaleCostAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERCODE"))
                    '''''        strSaleCostAccountInDesc = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERDESC"))
                    '''''        'If Trim(CMB_BTYPE.Text) = "BAR" Then
                    '''''        '    strAccountIn = "SDRSB"
                    '''''        'Else
                    '''''        strAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("AccountIn"))
                    '''''        ' End If
                    '''''    Else
                    '''''        sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "'ISNULL(SUBPAYSTATUS,'')='N'"
                    '''''        strAccountIn = ""
                    '''''        strSaleCostAccountIn = ""
                    '''''        strSaleCostAccountInDesc = ""
                    '''''    End If
                    '''''Else

                    '''''    sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "' And ISNULL(SUBPAYSTATUS,'')<>'Y'"
                    '''''    gconnection.getDataSet(sqlstring, "AccountIn")
                    '''''    If (gdataset.Tables("AccountIn").Rows.Count > 0) Then
                    '''''        strAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("AccountIn"))
                    '''''        strSaleCostAccountIn = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERCODE"))
                    '''''        strSaleCostAccountInDesc = Trim(gdataset.Tables("AccountIn").Rows(0).Item("SALECOSTCENTERDESC"))
                    '''''    Else
                    '''''        sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN, ISNULL(SALECOSTCENTERCODE,'') AS         SALECOSTCENTERCODE, ISNULL(SALECOSTCENTERDESC,'') AS SALECOSTCENTERDESC FROM PAYMENTMODEMASTER WHERE PAYMENTCODE = '" & Trim(cbo_PaymentMode.Text) & "'ISNULL(SUBPAYSTATUS,'')='N'"
                    '''''        strAccountIn = ""
                    '''''        strSaleCostAccountIn = ""
                    '''''        strSaleCostAccountInDesc = ""
                    '''''    End If
                    '''''End If

                    '''''sqlstring = "select isnull(roundacctin,'') as rndoff_acode,isnull(roundacctdesc,'') as rndoff_desc  from  possetup "
                    '''''sqlstring = sqlstring & " where isnull(BILLROUNDOFF,'')='YES'"
                    '''''gconnection.getDataSet(sqlstring, "Rndoff")
                    '''''If (gdataset.Tables("Rndoff").Rows.Count > 0) Then
                    '''''    rndoff_acode = gdataset.Tables("Rndoff").Rows(0).Item("rndoff_acode")
                    '''''    rndoff_desc = gdataset.Tables("Rndoff").Rows(0).Item("rndoff_desc")
                    '''''Else
                    '''''    rndoff_acode = ""
                    '''''    rndoff_desc = ""
                    '''''End If



                    '''''If Me.cbo_SubPaymentMode.Visible = True Then
                    '''''    strAccountIn = Subpaymentaccountcode
                    '''''End If
                    '''''sqlstring = "SELECT ISNULL(MAX(ISNULL(BATCHNO,0)),0) AS BATCHNO FROM JOURNALENTRY"
                    '''''gconnection.getDataSet(sqlstring, "BatchNo")
                    '''''If (gdataset.Tables("BatchNo").Rows.Count > 0) Then
                    '''''    strBatchNo = Trim(gdataset.Tables("BatchNo").Rows(0).Item("BATCHNO"))
                    '''''Else
                    '''''    strBatchNo = ""
                    '''''End If
                    '''''Subledger_flag = ""
                    '''''If (strAccountIn <> "") Then
                    '''''    sqlstring = "SELECT ISNULL(ACDESC,'') AS ACDESC,isnull(subledgerflag,'') as subflg FROM ACCOUNTSGLACCOUNTMASTER WHERE ACCODE = '" & strAccountIn & "'"
                    '''''    gconnection.getDataSet(sqlstring, "AccountDesc")
                    '''''    If (gdataset.Tables("AccountDesc").Rows.Count > 0) Then
                    '''''        strAccountDesc = Trim(gdataset.Tables("AccountDesc").Rows(0).Item("ACDESC"))
                    '''''        Subledger_flag = Trim(gdataset.Tables("AccountDesc").Rows(0).Item("subflg"))
                    '''''    Else
                    '''''        strAccountDesc = ""
                    '''''        Subledger_flag = ""
                    '''''    End If
                    '''''End If
                    '''''sqlstring = " delete from  Journalentry Where voucherno='" & txt_BillNo.Text & "'"
                    '''''ReDim Preserve Update1(Update1.Length)
                    '''''Update1(Update1.Length - 1) = sqlstring


                    ''''''sqlstring = " UPDATE  OUTSTANDING SET VOID='Y' Where voucherno='" & txt_BillNo.Text & "'"
                    ''''''ReDim Preserve Update1(Update1.Length)
                    ''''''Update1(Update1.Length - 1) = sqlstring
                    ''''''sqlstring = " Delete From  Journalentry Where voucherno='" & txt_BillNo.Text & "'"
                    ''''''ReDim Preserve Update1(Update1.Length)
                    ''''''Update1(Update1.Length - 1) = sqlstring
                    ''''''TAXCODE WISE INSERT IN JOURNALENTRY - CREDIT PART

                    '''''sqlstring = "Select Isnull(A.Billdetails,'') as Billdetails,Isnull(sum(A.TaxAMOUNT),0) as Amount,Isnull(B.Acdesc,'') as Acdesc,"
                    '''''sqlstring = sqlstring & "Isnull(A.Taxaccountcode,'') as Acctcode From Kot_Det  A,Accountsglaccountmaster B "
                    '''''sqlstring = sqlstring & "Where Isnull(delFlag,'')<>'Y'  And A.TAXAccountcode=b.Accode "
                    '''''sqlstring = sqlstring & "And Isnull(Billdetails,'')='" & txt_BillNo.Text & "' "
                    '''''sqlstring = sqlstring & "Group by A.Taxaccountcode,A.billdetails,B.Acdesc "
                    '''''gconnection.getDataSet(sqlstring, "JrnTax")
                    '''''Jnltaxamount = 0
                    '''''If (gdataset.Tables("JrnTax").Rows.Count > 0) Then
                    '''''    For K = 0 To gdataset.Tables("JrnTax").Rows.Count - 1

                    '''''        strBatchNo = strBatchNo + 1
                    '''''        sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SlCode,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description,cashbank,instrumentdate,instrumenttype,instrumentno,bankname,bankplace,oppaccountcode) "
                    '''''        sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & Trim(gdataset.Tables("JrnTax").Rows(K).Item("Acctcode")) & "',''," & Trim(gdataset.Tables("Jrntax").Rows(K).Item("Amount")) & ",'CREDIT','" & Trim(gdataset.Tables("Jrntax").Rows(K).Item("Acdesc")) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                    '''''        sqlstring = sqlstring & strBatchNo & ",'" & DESC & "',"
                    '''''        If UCase(cbo_PaymentMode.Text) = "CASH" Then
                    '''''            sqlstring = sqlstring & "'CASH','','CASH','','','','" & strAccountIn & "')"

                    '''''            'ElseIf UCase(cbo_PaymentMode.Text) = "CARD" Or UCase(cbo_PaymentMode.Text) = "CHEQUE" Then
                    '''''            '    sqlstring = sqlstring & "'BANK','" & Format(DTP_CHKDATE.Value, "dd/MMM/yyyy") & "',"
                    '''''            '    sqlstring = sqlstring & "'BANK','" & Txt_InstNo.Text & "','" & Txt_DrawebankName.Text & "',"
                    '''''            '    sqlstring = sqlstring & "'" & Txt_BankPlace.Text & "','" & TXT_ACCTCODE.Text & "')"
                    '''''        Else
                    '''''            sqlstring = sqlstring & "'','','','','','','')"
                    '''''        End If

                    '''''        Jnltaxamount = Jnltaxamount + Val(gdataset.Tables("Jrntax").Rows(K).Item("Amount"))
                    '''''        ReDim Preserve Update1(Update1.Length)
                    '''''        Update1(Update1.Length - 1) = sqlstring

                    '''''        'If UCase(Subledger_flag) = "Y" Then
                    '''''        '    sqlstring = "Insert into outstanding(VoucherNo,VoucherDate,VoucherType,VoucherCategory,AccountCode,"
                    '''''        '    sqlstring = sqlstring & "SLCode,Amount,Description,CreditDebit,Void,AddUserId,AddDatetime)"
                    '''''        '    sqlstring = sqlstring & " Values ('" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & Trim(CMB_BTYPE.Text) & "','SALE',"
                    '''''        '    sqlstring = sqlstring & "'" & strAccountIn & "','" & txt_MemberCode.Text & "'," & Trim(gdataset.Tables("Jrntax").Rows(K).Item("Amount")) & ","
                    '''''        '    sqlstring = sqlstring & "'" & Trim(gdataset.Tables("JrnTAX").Rows(K).Item("Acdesc")) & "','DEBIT','N','" & gUsername & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "')"
                    '''''        '    ReDim Preserve Update1(Update1.Length)
                    '''''        '    Update1(Update1.Length - 1) = sqlstring
                    '''''        'End If

                    '''''    Next
                    '''''End If
                    ''''''ACCOUNTS CODE WISE INSERT IN JOURNALENTRY - CREDIT PART
                    '''''sqlstring = "select Isnull(A.Billdetails,'') as Billdetails,Isnull(sum(A.AMOUNT),0) as Amount,ISNULL(A.COSTCODE,'') AS COSTCODE,"
                    '''''sqlstring = sqlstring & "Isnull(A.SalesAccountcode,'') as AcctCode,Isnull(B.Acdesc,'') as Acdesc From  Kot_Det A, "
                    '''''sqlstring = sqlstring & "Accountsglaccountmaster B Where Isnull(A.delFlag,'')<>'Y' "
                    '''''sqlstring = sqlstring & "And Isnull(A.billdetails,'')='" & txt_BillNo.Text & "'  And A.SalesAccountcode=B.Accode "
                    '''''sqlstring = sqlstring & "Group by A.COSTCODE,A.SalesAccountcode,A.billdetails,B.Acdesc "
                    '''''gconnection.getDataSet(sqlstring, "JrnAcct")
                    '''''If (gdataset.Tables("JrnAcct").Rows.Count > 0) Then
                    '''''    Jnlamount = 0
                    '''''    For K = 0 To gdataset.Tables("JrnAcct").Rows.Count - 1
                    '''''        strBatchNo = strBatchNo + 1
                    '''''        sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,COSTCENTERCODE,SlCode,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description,cashbank,instrumentdate,instrumenttype,instrumentno,bankname,bankplace,oppaccountcode) "
                    '''''        sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & Trim(gdataset.Tables("JrnAcct").Rows(K).Item("Acctcode")) & "','" & Trim(gdataset.Tables("JrnAcct").Rows(K).Item("COSTCODE")) & "',''," & Trim(gdataset.Tables("JrnAcct").Rows(K).Item("Amount")) & ",'CREDIT','" & Trim(gdataset.Tables("JrnAcct").Rows(K).Item("Acdesc")) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                    '''''        sqlstring = sqlstring & strBatchNo & ",'" & DESC & "',"

                    '''''        If UCase(cbo_PaymentMode.Text) = "CASH" Then
                    '''''            sqlstring = sqlstring & "'CASH','','CASH','','','','" & strAccountIn & "')"

                    '''''            'ElseIf UCase(cbo_PaymentMode.Text) = "CARD" Or UCase(cbo_PaymentMode.Text) = "CHEQUE" Then
                    '''''            '    sqlstring = sqlstring & "'BANK','" & Format(DTP_CHKDATE.Value, "dd/MMM/yyyy") & "',"
                    '''''            '    sqlstring = sqlstring & "'BANK','" & Txt_InstNo.Text & "','" & Txt_DrawebankName.Text & "',"
                    '''''            '    sqlstring = sqlstring & "'" & Txt_BankPlace.Text & "','" & TXT_ACCTCODE.Text & "')"
                    '''''        Else
                    '''''            sqlstring = sqlstring & "'','','','','','','')"
                    '''''        End If

                    '''''        Jnlamount = Jnlamount + Val(gdataset.Tables("JrnAcct").Rows(K).Item("Amount"))
                    '''''        ReDim Preserve Update1(Update1.Length)
                    '''''        Update1(Update1.Length - 1) = sqlstring
                    '''''    Next
                    '''''End If
                    '''''With ssgrid_settlement
                    '''''    If .DataRowCnt > 1 Then
                    '''''        .SetActiveCell(1, 1)
                    '''''        For K = 1 To .DataRowCnt
                    '''''            STMcode = ""
                    '''''            _Billamount = 0.0
                    '''''            .Row = K
                    '''''            .Col = 1
                    '''''            STMcode = .Text
                    '''''            .Row = K
                    '''''            .Col = 2
                    '''''            _Billamount = .Text
                    '''''            strBatchNo = strBatchNo + 1
                    '''''            If cbo_PaymentMode.Text = "CARD" Or cbo_PaymentMode.Text = "CASH" Then
                    '''''                sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SLCODE,SlDesc,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                    '''''                sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','','',"
                    '''''                'sqlstring = sqlstring & Trim(STMcode) & "','',"
                    '''''                sqlstring = sqlstring & Format(Val(_Billamount), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                    '''''                sqlstring = sqlstring & strBatchNo & ",'" & DESC & "')"
                    '''''            ElseIf cbo_PaymentMode.Text = "ROOM" Then
                    '''''                sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,ROOMNO,SlDesc,REF_NO,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                    '''''                sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','"
                    '''''                sqlstring = sqlstring & Trim(STMcode) & "','','" & roomchkno & "',"
                    '''''                sqlstring = sqlstring & Format(Val(_Billamount), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                    '''''                sqlstring = sqlstring & strBatchNo & ",'" & DESC & "')"
                    '''''            Else
                    '''''                sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SlCode,SlDesc,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                    '''''                sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','"
                    '''''                sqlstring = sqlstring & Trim(STMcode) & "','',"
                    '''''                sqlstring = sqlstring & Format(Val(_Billamount), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                    '''''                sqlstring = sqlstring & strBatchNo & ",'" & DESC & "')"
                    '''''            End If
                    '''''            ReDim Preserve Update1(Update1.Length)
                    '''''            Update1(Update1.Length - 1) = sqlstring
                    '''''        Next
                    '''''    Else
                    '''''        strBatchNo = strBatchNo + 1
                    '''''        If UCase(cbo_PaymentMode.Text) = "CARD" Or UCase(cbo_PaymentMode.Text) = "CASH" Or UCase(cbo_PaymentMode.Text) = "CHEQUE" Then
                    '''''            sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SLCODE,SlDesc,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description,cashbank,instrumentdate,instrumenttype,instrumentno,bankname,bankplace,oppaccountcode) "
                    '''''            sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','','',"
                    '''''            'sqlstring = sqlstring & Trim(STMcode) & "','',"
                    '''''            sqlstring = sqlstring & Format(Val(Format(Val(Jnltaxamount + Jnlamount + Amt), "0.00")), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                    '''''            sqlstring = sqlstring & strBatchNo & ",'" & DESC & "',"

                    '''''            If UCase(cbo_PaymentMode.Text) = "CASH" Then
                    '''''                sqlstring = sqlstring & "'CASH','','CASH','','','','')"
                    '''''                'ElseIf UCase(cbo_PaymentMode.Text) = "CARD" Or UCase(cbo_PaymentMode.Text) = "CHEQUE" Then
                    '''''                '    sqlstring = sqlstring & "'BANK','" & Format(DTP_CHKDATE.Value, "dd/MMM/yyyy") & "',"
                    '''''                '    sqlstring = sqlstring & "'bank','" & Txt_InstNo.Text & "','" & Txt_DrawebankName.Text & "',"
                    '''''                '    sqlstring = sqlstring & "'" & Txt_BankPlace.Text & "','')"
                    '''''            Else
                    '''''                sqlstring = sqlstring & "'','','','','','','')"
                    '''''            End If

                    '''''        ElseIf cbo_PaymentMode.Text = "ROOM" Then
                    '''''            sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,ROOMNO,SlDesc,REF_NO,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                    '''''            sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','"
                    '''''            sqlstring = sqlstring & Trim(txt_MemberCode.Text) & "','','" & roomchkno & "',"
                    '''''            sqlstring = sqlstring & Format(Val(Format(Val(Jnltaxamount + Jnlamount + Amt), "0.00")), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                    '''''            sqlstring = sqlstring & strBatchNo & ",'" & DESC & "')"
                    '''''        Else
                    '''''            sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SlCode,SlDesc,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description) "
                    '''''            sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & strAccountIn & "','"
                    '''''            sqlstring = sqlstring & Trim(txt_MemberCode.Text) & "','',"
                    '''''            sqlstring = sqlstring & Format(Val(Jnltaxamount + Jnlamount + Amt), "0.00") & ",'DEBIT','" & strAccountDesc & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                    '''''            sqlstring = sqlstring & strBatchNo & ",'" & DESC & "')"
                    '''''        End If
                    '''''        ReDim Preserve Update1(Update1.Length)
                    '''''        Update1(Update1.Length - 1) = sqlstring
                    '''''    End If
                    '''''End With
                    '''''''----round off posting
                    '''''If Amt <> 0 And Trim(rndoff_acode) <> "" Then
                    '''''    strBatchNo = strBatchNo + 1
                    '''''    sqlstring = "INSERT INTO JOURNALENTRY(VoucherType,VoucherCategory,VoucherNo,VoucherDate,Accountcode,SlCode,Amount,CreditDebit,AccountCodeDesc,AddUserId,BatchNo,Description,cashbank,instrumentdate,instrumenttype,instrumentno,bankname,bankplace,oppaccountcode) "
                    '''''    sqlstring = sqlstring & " Values ('" & Trim(CMB_BTYPE.Text) & "','SALE','" & Trim(txt_BillNo.Text) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','" & Trim(rndoff_acode) & "',''," & Math.Abs(Amt) & ",'" & IIf(Amt > 0, "CREDIT", "DEBIT") & "','" & Trim(rndoff_desc) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',"
                    '''''    sqlstring = sqlstring & strBatchNo & ",'" & DESC & "',"
                    '''''    If Amt > 0 Then
                    '''''        If UCase(cbo_PaymentMode.Text) = "CASH" Then
                    '''''            sqlstring = sqlstring & "'CASH','','CASH','','','','" & strAccountIn & "')"

                    '''''            'ElseIf UCase(cbo_PaymentMode.Text) = "CARD" Or UCase(cbo_PaymentMode.Text) = "CHEQUE" Then
                    '''''            '    sqlstring = sqlstring & "'BANK','" & Format(DTP_CHKDATE.Value, "dd/MMM/yyyy") & "',"
                    '''''            '    sqlstring = sqlstring & "'BANK','" & Txt_InstNo.Text & "','" & Txt_DrawebankName.Text & "',"
                    '''''            '    sqlstring = sqlstring & "'" & Txt_BankPlace.Text & "','" & TXT_ACCTCODE.Text & "')"
                    '''''        Else
                    '''''            sqlstring = sqlstring & "'','','','','','','')"
                    '''''        End If
                    '''''    Else
                    '''''        sqlstring = sqlstring & "'','','','','','','')"
                    '''''    End If
                    '''''    ReDim Preserve Update1(Update1.Length)
                    '''''    Update1(Update1.Length - 1) = sqlstring
                    '''''End If

                    sqlstring = " UPDATE BILL_HDR SET PACKAMOUNT=ISNULL(PACKAMOUNT,0) WHERE BILLDETAILS='" & txt_BillNo.Text & "'"
                    ReDim Preserve Update1(Update1.Length)
                    Update1(Update1.Length - 1) = sqlstring

                    sqlstring = " update Bill_hdr set packamount=isnull(b.packamount,0),Ser_Chg=isnull(b.Ser_chg,0)  from bill_hdr a, view_kot  b "
                    sqlstring = sqlstring & " where a.billdetails=b.billdetails and a.billdetails='" & txt_BillNo.Text & "'"
                    ReDim Preserve Update1(Update1.Length)
                    Update1(Update1.Length - 1) = sqlstring

                    sqlstring = " UPDATE ROOMLEDGER SET AMOUNT=ISNULL(B.TOTALAMOUNT,0)+ISNULL(B.ROUNDOFF,0) FROM  ROOMLEDGER A,BILL_HDR B WHERE B.BILLDETAILS=A.DOCNO AND  A.DOCNO='" & txt_BillNo.Text & "'"
                    ReDim Preserve Update1(Update1.Length)
                    Update1(Update1.Length - 1) = sqlstring


                    'saran
                    'CSC SMARTCARD
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

                    Dim STRSQL2 As String
                    ' STRSQL2 = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & cardcode & "' AND POSCODE='" & StrPOSCODE & "'"
                    STRSQL2 = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & cardcode & "'"
                    gconnection.getDataSet(STRSQL2, "SM_CARDFILE_DET")
                    If gdataset.Tables("SM_CARDFILE_DET").Rows.Count > 0 Then
                        POS_AMT_GBL = Val(txt_BillAmount.Text)
                        STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'FF' "
                        gconnection.getDataSet(STRSQL2, "FACILITY")
                        If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                            'ONCE FACILITY 
                            KOT_NO_GBL = Trim(txt_BillNo.Text)
                            gconnection.MoreTransold(Update1)
                            If CHK_PRINT.Checked = True Then
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
                            SSTR = "SELECT * FROM SM_POSTRANSACTION WHERE BILL_NO='" & Trim(txt_BillNo.Text) & "'"
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
                                If MIN_USAGE_BALANCE_HDR >= Val(txt_BillAmount.Text) Then
                                    STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & "01" & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_BillNo.Text) & "'," & Val(txt_BillAmount.Text) & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FM')"
                                    ReDim Preserve Update1(Update1.Length)
                                    Update1(Update1.Length - 1) = STRSQL

                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & Val(txt_BillAmount.Text) & " WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update1(Update1.Length)
                                    Update1(Update1.Length - 1) = STRSQL
                                ElseIf MIN_USAGE_BALANCE_HDR <= 0 Then
                                    'DEDUCT AMOUNT ONLY FROM CARD

                                    Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                                    DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR
                                    'to be test
                                    '29/06/2010

                                    DEDUCT_FROM_CARD = Val(txt_BillAmount.Text) - (MIN_USAGE_BALANCE_HDR + Val(txt_lastbillamount.Text))

                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update1(Update1.Length)
                                    Update1(Update1.Length - 1) = STRSQL

                                    'FOR EBALANCE

                                    Dim BALstr, EBAL As String
                                    Dim BALnum As Double
                                    sqlstring = " SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] = '" & Trim(txt_card_id.Text) & "' "
                                    gconnection.getDataSet(sqlstring, "CARDFILE_HDR_BAL")
                                    If gdataset.Tables("CARDFILE_HDR_BAL").Rows.Count > 0 Then
                                        If IsDBNull(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) = False Then
                                            BALnum = abcdMINUS(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) - Val(DEDUCT_FROM_CARD)
                                        Else '--for zero
                                            BALnum = 0 - Val(DEDUCT_FROM_CARD)
                                        End If
                                    End If
                                    EBAL = abcdADD(BALnum)

                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET EBALANCE = '" & Trim(EBAL) & "' WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update1(Update1.Length)
                                    Update1(Update1.Length - 1) = STRSQL
                                    'END


                                    STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & "01" & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_BillNo.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FC')"
                                    ReDim Preserve Update1(Update1.Length)
                                    Update1(Update1.Length - 1) = sTRSQL

                                ElseIf MIN_USAGE_BALANCE_HDR > 0 And MIN_USAGE_BALANCE_HDR < Val(txt_BillAmount.Text) Then

                                    Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                                    DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR

                                    'to be test
                                    '29/06/2010
                                    DEDUCT_FROM_CARD = Val(txt_BillAmount.Text) - (MIN_USAGE_BALANCE_HDR + Val(txt_lastbillamount.Text))

                                    'DEDUCT_FROM_CARD = Val(txt_BillAmount.Text) - MIN_USAGE_BALANCE_HDR

                                    STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & "01" & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_BillNo.Text) & "'," & DEDUCT_FROM_MINUSAGE & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HM')"
                                    ReDim Preserve Update1(Update1.Length)
                                    Update1(Update1.Length - 1) = STRSQL


                                    STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & "01" & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_BillNo.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HC')"
                                    ReDim Preserve Update1(Update1.Length)
                                    Update1(Update1.Length - 1) = STRSQL

                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & DEDUCT_FROM_MINUSAGE & " WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update1(Update1.Length)
                                    Update1(Update1.Length - 1) = STRSQL

                                    'FOR EBALANCE

                                    Dim BALstr, EBAL As String
                                    Dim BALnum As Double
                                    sqlstring = " SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] = '" & Trim(txt_card_id.Text) & "' "
                                    gconnection.getDataSet(sqlstring, "CARDFILE_HDR_BAL")
                                    If gdataset.Tables("CARDFILE_HDR_BAL").Rows.Count > 0 Then
                                        If IsDBNull(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) = False Then
                                            BALnum = abcdMINUS(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) - Val(DEDUCT_FROM_CARD)
                                        Else '--for zero
                                            BALnum = 0 - Val(DEDUCT_FROM_CARD)
                                        End If
                                    End If
                                    EBAL = abcdADD(BALnum)

                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET EBALANCE = '" & Trim(EBAL) & "' WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update1(Update1.Length)
                                    Update1(Update1.Length - 1) = STRSQL
                                    'END

                                    STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & cardcode & "'"
                                    ReDim Preserve Update1(Update1.Length)
                                    Update1(Update1.Length - 1) = STRSQL
                                End If
                                'CARD
                                gconnection.MoreTransold(Update1)
                                If CHK_PRINT.Checked = True Then
                                    Call Cmd_Print_Click(Cmd_Print, e)
                                    Call cmd_Clear_Click(sender, e)
                                    '***********CHANGE
                                    MNAME_GBL = ""
                                    MCODE_GBL = ""
                                    cardcode = ""
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
                                gconnection.MoreTransold(Update1)
                                If CHK_PRINT.Checked = True Then
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
                        gconnection.MoreTransold(Update1)
                        'If CHK_PRINT.Checked = True Then
                        '    Call Cmd_Print_Click(Cmd_Print, e)
                        '    Call cmd_Clear_Click(sender, e)
                        'Else
                        '    Call cmd_Clear_Click(sender, e)
                        'End If
                        If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                            Call Cmd_Print_Click(cmd_View, e)
                            Call cmd_Clear_Click(sender, e)
                            Exit Sub
                        Else
                            Call cmd_Clear_Click(sender, e)
                        End If
                    End If

                    'sqlstring = "Insert into MemberIntime Values('" & Trim(txt_MemberCode.Text) & "','" & Format(Now, "dd/MMM/yyyy HH:mm:ss") & "')"
                    'gconnection.dataOperation(6, sqlstring, "MemberInTime")
                    Call txt_MemberCode_Validated(sender, e)

                End If

                If dblMsg <> 1 Then
                    If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Call Cmd_Print_Click(cmd_View, e)
                        Call cmd_Clear_Click(sender, e)
                    Else
                        Call cmd_Clear_Click(sender, e)
                    End If
                Else
                    Cmd_Add.Focus()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(" Try Again,Thanking you " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Dim SQLSTRING, DELETE(0), STRKOTDETAILS As String
        Dim VCTR As Integer
        Dim dt As New DataTable
        Dim sql, Otherbillno, SSQL As String
        Dim otherbool As Boolean
        Dim vDocno
        Dim i, A, B As Integer
        Call SetDateTime()
        Call bill_roundoff()
        If MsgBox("Do You Want To Delete", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Else
            Exit Sub
        End If

        SQLSTRING = "SELECT * FROM BILL_HDR WHERE BILLDETAILS = '" & Trim(txt_BillNo.Text) & "' AND ISNULL(crostatus,'N')='Y' "
        gconnection.getDataSet(SQLSTRING, "CRO")
        If gdataset.Tables("CRO").Rows.Count > 0 Then
            MsgBox("Sorry, Settlement Was Already Made, You Can't Delete/Update....")
            Exit Sub
        End If


        SQLSTRING = "SELECT * FROM MATCHING WHERE VOUCHERNO = '" & Trim(txt_BillNo.Text) & "' AND VOUCHERDATE = '" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "'"
        gconnection.getDataSet(SQLSTRING, "MATCHING")
        If gdataset.Tables("MATCHING").Rows.Count > 0 Then
            MsgBox("Sorry, Bill Matching Was Already Made, You Can't Delete....")
            Call cmd_Clear_Click(cmd_Clear, e)
            Exit Sub
        End If
        dt = New DataTable

        sql = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
        gconnection.getDataSet(sql, "Bill_det")
        If gdataset.Tables("Bill_det").Rows.Count > 0 Then
            If gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") <> "" Then
                Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
                otherbool = True
            End If
        Else
            otherbool = False
        End If
        If otherbool = True Then
            BillDetails = Trim(Otherbillno) & "'" & "," & "'" & Trim(Me.txt_BillNo.Text)
        Else
            BillDetails = Trim(Me.txt_BillNo.Text)
        End If


        sql = "SELECT * FROM kot_hdr WHERE CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) ='" & Format(dtp_BillDate.Value, "dd/MMM/yyyy") & "' AND postingstatus = 'Y'"
        gconnection.getDataSet(sql, "kot_hdr")
        If gdataset.Tables("kot_hdr").Rows.Count > 0 Then
            Cmd_Add.Enabled = False
            cmd_Delete.Enabled = False
            MessageBox.Show("NO KOT SHOULD BE ENTERED/UPDATED FOR BILL CLOSED DATE:" & Format(dtp_BillDate.Value, "dd/MMM/yyyy"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        A = Month(Trim(dtp_BillDate.Text))
        sql = "SELECT * FROM bill_hdr WHERE month(billdate) = " & Val(A) & " AND ACCOUNTFLAG = 'Y'"
        gconnection.getDataSet(sql, "bill_hdr")
        If gdataset.Tables("bill_hdr").Rows.Count > 0 Then
            Cmd_Add.Enabled = False
            cmd_Delete.Enabled = False
            MessageBox.Show("NO KOT SHOULD BE ENTERED FOR MEMBER BILL GENERATED MONTH", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If







        SQLSTRING = "SELECT KOTDETAILS FROM KOT_DET WHERE BILLDETAILS in ('" & Trim(BillDetails) & "'" & ")"
        gconnection.getDataSet(SQLSTRING, "KOT_DET")
        If gdataset.Tables("KOT_DET").Rows.Count > 0 Then
            For VCTR = 0 To gdataset.Tables("KOT_DET").Rows.Count - 1
                If Trim(STRKOTDETAILS) = "" Then
                    STRKOTDETAILS = "'" & Trim(gdataset.Tables("KOT_DET").Rows(VCTR).Item("KOTDETAILS")) & "',"
                Else
                    STRKOTDETAILS = STRKOTDETAILS & "'" & Trim(gdataset.Tables("KOT_DET").Rows(VCTR).Item("KOTDETAILS")) & "',"
                End If
            Next
            SQLSTRING = "UPDATE KOT_HDR SET "
            SQLSTRING = SQLSTRING & " BILLSTATUS ='PO' "
            SQLSTRING = SQLSTRING & " WHERE KOTDETAILS IN(" & Mid(Trim(STRKOTDETAILS), 1, Len(Trim(STRKOTDETAILS)) - 1) & ")"
            DELETE(0) = SQLSTRING

            SQLSTRING = "UPDATE KOT_DET SET "
            SQLSTRING = SQLSTRING & " BILLDETAILS =''"
            SQLSTRING = SQLSTRING & " WHERE KOTDETAILS IN(" & Mid(Trim(STRKOTDETAILS), 1, Len(Trim(STRKOTDETAILS)) - 1) & ")"
            ReDim Preserve DELETE(DELETE.Length)
            DELETE(DELETE.Length - 1) = SQLSTRING

            SQLSTRING = " UPDATE BILL_DET SET DELFLAG = 'Y' WHERE BILLDETAILS in ('" & Trim(BillDetails) & "'" & ")"
            ReDim Preserve DELETE(DELETE.Length)

            SQLSTRING = " UPDATE BILL_HDR SET DELFLAG = 'Y' WHERE BILLDETAILS in ('" & Trim(BillDetails) & "'" & ")"
            ReDim Preserve DELETE(DELETE.Length)
            DELETE(DELETE.Length - 1) = SQLSTRING

            SQLSTRING = " UPDATE JOURNALENTRY SET VOID = 'Y' WHERE VOUCHERNO  in ('" & Trim(BillDetails) & "'" & ")"
            ReDim Preserve DELETE(DELETE.Length)
            DELETE(DELETE.Length - 1) = SQLSTRING

            SQLSTRING = " UPDATE OUTSTANDING  SET VOID = 'Y' WHERE VOUCHERNO  in ('" & Trim(BillDetails) & "'" & ")"
            ReDim Preserve DELETE(DELETE.Length)
            DELETE(DELETE.Length - 1) = SQLSTRING


            'smart card

            If cbo_PaymentMode.Text = "SMART CARD" Then
                SQLSTRING = " UPDATE SM_POSTRANSACTION SET VOID ='Y', VOIDUSER='" & gUsername & "' WHERE BILL_NO='" & Trim(txt_BillNo.Text) & "'"
                ReDim Preserve DELETE(DELETE.Length)
                DELETE(DELETE.Length - 1) = SQLSTRING

                SQLSTRING = "SELECT * FROM  SM_POSTRANSACTION WHERE BILL_NO ='" & Trim(txt_BillNo.Text) & "'"
                gconnection.getDataSet(SQLSTRING, "SM_POSTRANSACTION")
                If gdataset.Tables("SM_POSTRANSACTION").Rows.Count > 0 Then
                    SQLSTRING = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE +" & Val(txt_BillAmount.Text) & " WHERE CARDCODE='" & Trim(txt_Holder_Code.Text) & "'"
                    ReDim Preserve DELETE(DELETE.Length)
                    DELETE(DELETE.Length - 1) = SQLSTRING

                    'FOR EBALANCE

                    Dim BALstr, EBAL As String
                    Dim BALnum As Double
                    SQLSTRING = " SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] = '" & Trim(txt_card_id.Text) & "' "
                    gconnection.getDataSet(SQLSTRING, "CARDFILE_HDR_BAL")
                    If gdataset.Tables("CARDFILE_HDR_BAL").Rows.Count > 0 Then
                        If IsDBNull(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) = False Then
                            BALnum = abcdMINUS(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) + Val(txt_BillAmount.Text)
                        Else '--for zero
                            BALnum = 0 - Val(txt_BillAmount.Text)
                        End If
                    End If
                    EBAL = abcdADD(BALnum)

                    SQLSTRING = " UPDATE SM_CARDFILE_HDR SET EBALANCE = '" & Trim(EBAL) & "' WHERE CARDCODE='" & cardcode & "'"
                    ReDim Preserve DELETE(DELETE.Length)
                    DELETE(DELETE.Length - 1) = SQLSTRING
                    'END
                End If
            End If
            'karthi 

            'UPDATE POSVALID DATE TO NULL
            'CANT TRACK BEFORE
            'WANT TO BE DONE BY ADMIN
            Dim STRSQL2 As String
            STRSQL2 = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"
            'STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'FF' "
            gconnection.getDataSet(STRSQL2, "SM_CARDFILE_DET")
            If gdataset.Tables("SM_CARDFILE_DET").Rows.Count > 0 Then
                POS_AMT_GBL = Val(txt_BillAmount.Text)
                STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'FF' "
                gconnection.getDataSet(STRSQL2, "FACILITY")
                If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                    'ONCE FACILITY 
                    SQLSTRING = " UPDATE SM_CARDFILE_HDR SET UPDATEUSER='" & Trim(gUsername) & "',UPDATEDATETIME='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "' WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "'"
                    ReDim Preserve DELETE(DELETE.Length)
                    DELETE(DELETE.Length - 1) = SQLSTRING
                    'sqlstring = " UPDATE SM_CARDFILE_DET SET POS_VALID_FROM='" & Format(Cmb_Validfrom.Value, "dd/MMM/yyyy") & "',POS_VALID_TO='" & Format(Cmb_Validto.Value, "dd/MMM/yyyy") & "',TIME_FROM='" & Format(Cmb_TimeFrom.Value, "HH:MM") & "', TIME_TO='" & Format(Cmb_TimeTo.Value, "HH:MM") & "',DURATION='" & Format(Cmb_Duration.Value, "hh:mm") & "', HOURLY_BILL=" & POS_RATE_GBL & ", PERIOD_TO_DATE_USAGE=" & POS_AMT_GBL & " WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"

                    SQLSTRING = " SELECT POS_ACCESS, isNULL(POS_VALID_FROM,'01/01/1900') AS POS_VALID_FROM, ISNULL(POS_VALID_TO,'01/01/1900')AS POS_VALID_TO, ISNULL(TIME_FROM,'01/01/1900 00:00') AS TIME_FROM, ISNULL(TIME_TO,'01/01/1900 00:00') AS TIME_TO, ISNULL(DURATION,'01/01/1900 00:00')AS DURATION  FROM SM_CARDFILE_DET_IMG WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"
                    gconnection.getDataSet(SQLSTRING, "SM_CARDFILE_DET_IMG")
                    If gdataset.Tables("SM_CARDFILE_DET_IMG").Rows.Count > 0 Then
                        Dim POS_ACCESS As String
                        Dim POS_VALID_FROM, POS_VALID_TO, TIME_FROM, TIME_TO, DURATION As DateTime
                        POS_ACCESS = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("POS_ACCESS")
                        POS_VALID_FROM = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("POS_VALID_FROM")
                        POS_VALID_TO = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("POS_VALID_TO")
                        TIME_FROM = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("TIME_FROM")
                        TIME_TO = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("TIME_TO")
                        DURATION = gdataset.Tables("SM_CARDFILE_DET_IMG").Rows(0).Item("DURATION")
                        SQLSTRING = " UPDATE SM_CARDFILE_DET SET POS_ACCESS='" & POS_ACCESS & "',POS_VALID_FROM ='" & Format(POS_VALID_FROM, "dd/MMM/yyyy") & "',POS_VALID_TO='" & Format(POS_VALID_TO, "dd/MMM/yyyy") & "',TIME_FROM='" & Format(TIME_FROM, "HH:MM") & "',TIME_TO='" & Format(TIME_TO, "HH:MM") & "',DURATION='" & Format(DURATION, "HH:MM") & "' WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"
                        ReDim Preserve DELETE(DELETE.Length)
                        DELETE(DELETE.Length - 1) = SQLSTRING
                    End If
                End If
            End If


            ''================================Cancel at Roomledger==============================================
            SQLSTRING = "SELECT ISNULL(CHECKOUT,'N') AS CHECKOUT,ISNULL(ROOMNO,0)AS ROOMNO FROM Roomcheckin WHERE docno = " & Val(txt_MemberCode.Tag) & " and isnull(roomstatus,'') = 'occupied'"
            gconnection.getDataSet(SQLSTRING, "Roomcheckin")
            If gdataset.Tables("Roomcheckin").Rows.Count > 0 Then
                If Trim(CStr(gdataset.Tables("Roomcheckin").Rows(0).Item("CHECKOUT"))) = "Y" Then
                    MessageBox.Show("Bill Can't be updated " & vbCrLf & " as GUEST  has been checkout from RoomNo" & ": " & gdataset.Tables("ROOMcheckin").Rows(0).Item("ROOMNO"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call cmd_Clear_Click(cmd_Clear, e)
                    Cmd_Add.Enabled = True
                    Exit Sub
                End If
            End If

            vDocno = getVoucherno("CANCEL", "GUEST ROOM")

            SSQL = "Select * From Roomledger where  Doctype = 'SALES' And Docno IN ('" & Trim(BillDetails) & "') and isnull(Cancel,'')<>'Y' "
            gconnection.getDataSet(SSQL, "ROOMLEDGER")
            If gdataset.Tables("RoomLedger").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("roomledger").Rows.Count - 1
                    SSQL = "Insert into RoomLedger(Chkno,Docno,DocDate,Doctype,poscode,Amount,Roomno,Refno,AddUserid,AddDatetime,Description,Creditdebit,foliono,Accountcode,slcode,Paymentmode,Angcode,Billhold,Checkout,Partyname,Vouchertype,Vouchercategory,Cancel,OldDocType,VOIDSTATUS)"
                    SSQL = SSQL & " values(" & Val(gdataset.Tables("RoomLedger").Rows(i).Item("chkno")) & ", " & vDocno & ",'" & Format(gdataset.Tables("RoomLedger").Rows(i).Item("DocDate"), "dd-MMM-yyyy") & "',"
                    SSQL = SSQL & "'CANCEL','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("PosCode")) & "'," & Val(gdataset.Tables("RoomLedger").Rows(i).Item("Amount") & "") & ","
                    SSQL = SSQL & " " & Val(gdataset.Tables("RoomLedger").Rows(i).Item("RoomNo") & "") & ",'" & Val(gdataset.Tables("RoomLedger").Rows(i).Item("Refno") & "") & "',"
                    SSQL = SSQL & " '" & Trim(gUsername & "") & "','" & Format(serverdate, "dd-MMM-yyyy") & "',"
                    SSQL = SSQL & " '" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("DocType") & "") & "CANCELLED - " & gdataset.Tables("RoomLedger").Rows(i).Item("docNo") & " dt." & Format(gdataset.Tables("RoomLedger").Rows(i).Item("Docdate"), "dd-MMM-yyyy") & "','Credit',1,'" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("Accountcode") & "") & "','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("slcode") & "") & "'"
                    SSQL = SSQL & ",'" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("Paymentmode") & "") & "','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("AngCode") & "") & "','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("BillHold") & "") & "','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("checkout") & "") & "','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("Partyname") & "") & "','CANCEL','GUEST ROOM','Y','" & gdataset.Tables("RoomLedger").Rows(i).Item("DocType") & "','Y')"

                    ReDim Preserve DELETE(DELETE.Length)
                    DELETE(DELETE.Length - 1) = SSQL

                    SSQL = " UPDATE ROOMLEDGER SET CANCEL='Y',VOIDSTATUS='Y' WHERE CHKNO =" & Val(gdataset.Tables("RoomLedger").Rows(0).Item("chkno")) & " "
                    SSQL = SSQL & " AND DOCTYPE='SALES' AND DOCNO in ('" & Trim(BillDetails) & "')"

                    ReDim Preserve DELETE(DELETE.Length)
                    DELETE(DELETE.Length - 1) = SSQL
                Next
            End If
            ''=============================Updation of roomledger complete=========================================
            SQLSTRING = " UPDATE SETTLEMENT SET DELETEFLAG = 'Y' WHERE BILLDETAILS='" & txt_BillNo.Text & "'"
            ReDim Preserve DELETE(DELETE.Length)
            DELETE(DELETE.Length - 1) = SQLSTRING



            gconnection.MoreTransold(DELETE)
            MsgBox("Bill is Deleted Successfully!", MsgBoxStyle.OKOnly, "Info!")
            Call cmd_Clear_Click(cmd_Clear, e)
        Else
            MessageBox.Show("!! OOPS !! Bill Can't be deleted ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        'MessageBox.Show("!! OOPS !! Bill Can't be deleted ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        'Exit Sub
        'End
    End Sub
    Private Sub cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_View.Click
        gPrint = False
        'Call BillPrintOperation_Alokesh()
        'If ssgrid_settlement.DataRowCnt > 1 Then
        '    SETLEMENT_GROUP.Visible = True
        '    ssgrid_settlement.SetActiveCell(1, 1)
        '    SETLEMENT_GROUP.Visible = False
        '    Call SPILTBILL_PRINT()
        'Else
        'Call BillPrintOperation_Alokesh()
        'Call SVSC_PRINT()
        Call GNC_PRINT()
        'End If
    End Sub
    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        'If ssgrid_settlement.DataRowCnt > 1 Then
        '    SETLEMENT_GROUP.Visible = True
        '    ssgrid_settlement.SetActiveCell(1, 1)
        '    SETLEMENT_GROUP.Visible = False
        '    Call SPILTBILL_PRINT()
        'Else
        '    'Call BillPrintOperation_Alokesh()
        Call GNC_PRINT()
        'End If
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        'Me.Close()
        smartdeviceportcount = 0
        Me.Close()
        If BOOLCHECKKOT = True Then
            Dim Kotentry As New KOTEntry("")
            Me.Hide()
            Kotentry.FormBorderStyle = FormBorderStyle.FixedDialog
            Kotentry.MdiParent = MDIParentobj
            Me.Close()
            StrPOSCODE = ""
            Kotentry.Show()
        End If
    End Sub
    Private Sub cmd_BillSettlement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BillSettlement.Click
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
                KotDetails = ""
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Row = i
                    ssGrid.Col = 4
                    Varchk = ""
                    Varchk = ssGrid.Text
                    If Trim(Varchk & "") = "1" Then
                        ssGrid.Col = 1
                        If KotDetails = "" Then
                            KotDetails = "'" & Trim(ssGrid.Text) & "'"
                        Else
                            KotDetails = KotDetails & ",'" & Trim(ssGrid.Text) & "'"
                        End If
                    End If
                Next i
                If Trim(KotDetails) = "" Then
                    MessageBox.Show("Plz Select The Kots To Generate The Bill", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                '''****************************************** $ In KotBill Table I am Storing The Kotdetails according to taxcode $ ******************'''
                sqlstring = "SELECT KOTDATE,KOTDETAILS,ISNULL(TAXCODE,'') AS TAXCODE ,SUM(AMOUNT) AS AMOUNT,ISNULL(SUM(TAXAMOUNT),0) AS TAXAMOUNT FROM KOT_DET WHERE ISNULL(KOTSTATUS,'') <> 'Y' AND KOTDETAILS IN( " & KotDetails & " )GROUP BY TAXCODE,KOTDETAILS,KOTDATE ORDER BY TAXCODE,KOTDETAILS"
                Kot_Bill = gconnection.GetValues(sqlstring)
                '''****************************************** $ TaxDr Contains The Taxable Items $ ***********************************************'''
                Taxdr = Kot_Bill.Select("TAXCODE <> ''")
                '''****************************************** $ NoTaxdr Contains The NonTaxable Items $ *****************************************'''
                NoTaxDr = Kot_Bill.Select("TAXCODE = ''")
                If Taxdr.Length > 0 Then
                    size = (Taxdr.Length * 3)
                    TaxApp = True
                End If
                If NoTaxDr.Length > 0 Then
                    If Val(size) > 0 Then
                        size = size + (NoTaxDr.Length * 3)
                    Else
                        size = (NoTaxDr.Length * 3)
                    End If
                    NoTax = True
                End If
                Billno = Split(Trim(txt_BillNo.Text), "/")
                BillDetails = Trim(Me.txt_BillNo.Text)
                ''' ************************************************ $ TAX BILLDETAILS GENERATION $ ***************************'''
                If TaxApp = True Then
                    Dim varStr1, varStr2 As String
                    BillTaxBillno = Billno(1)
                    BillTaxBilldetails = Trim(Me.txt_BillNo.Text)
                    ''' ************************************************ $ NONTAX BILLDETAILS GENERATION $ ***************************'''
                    If NoTax = True Then
                        Billno(1) = Convert.ToString(Val(Billno(1)) + 1)
                        Billno(1) = Format(Val(Billno(1)), "000000")
                        varStr1 = Trim(Me.txt_BillNo.Text).Substring(4, 6)
                        varStr2 = CStr(Val(varStr1) + 1)
                        BillNonTaxBilldetails = Trim(Me.txt_BillNo.Text).Replace(varStr1, Format(Val(varStr2), "000000"))
                        BillNonTaxBillno = Billno(1)
                    Else
                        BillNonTaxBilldetails = ""
                        BillNonTaxBillno = ""
                    End If
                Else
                    BillTaxBillno = ""
                    BillTaxBilldetails = ""
                    BillNonTaxBillno = Billno(1)
                    BillNonTaxBilldetails = Trim(Me.txt_BillNo.Text)
                End If
                ''' ************************************************ $  TAXTOTAL AND TOTALAMOUNT GENERATION $ ***************************'''
                If Taxdr.Length > 0 Then
                    dblBillTaxTotal = 0
                    dblBillTotalAmount = 0
                    For i = 0 To Taxdr.Length - 1
                        dblBillTaxTotal = dblBillTaxTotal + Val(Taxdr(i).Item("TaxAmount"))
                        dblBillTotalAmount = dblBillTaxTotal + dblBillTotalAmount + Val(Taxdr(i).Item("Amount"))
                    Next i
                    TaxApp = True
                End If
                ''' ************************************************ $  NONTAXTOTAL AND NONTOTALAMOUNT GENERATION $ ***************************'''
                If NoTaxDr.Length > 0 Then
                    dblBillNonTaxtotal = 0
                    dblBillNonTotalAmount = 0
                    For i = 0 To NoTaxDr.Length - 1
                        dblBillNonTaxtotal = dblBillNonTaxtotal + Val(NoTaxDr(i).Item("TaxAmount"))
                        dblBillNonTotalAmount = dblBillNonTaxtotal + dblBillNonTotalAmount + Val(NoTaxDr(i).Item("Amount"))
                    Next i
                End If
                BillMcode = Trim(txt_MemberCode.Text)
                BillMname = Trim(txt_MemberName.Text)
                ssgridPayment.Col = 1
                ssgridPayment.Row = 1
                ssgridPayment.Text = Trim(BillTaxBilldetails)
                ssgridPayment.Col = 2
                ssgridPayment.Row = 1
                ssgridPayment.Text = Format(CDate(dtp_BillDate.Value), "dd/MMM/yyyy")
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
                Me.txt_PartialPayment.Text = Format(Val(dblBillTotalAmount), "0.00")
                Call FillPaymentmodeSettlement(1)
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
    Private Sub KOT_Billing_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        txt_card_id.Focus()
    End Sub

    Private Sub lbl_SwipeCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_SwipeCard.Click

    End Sub
End Class