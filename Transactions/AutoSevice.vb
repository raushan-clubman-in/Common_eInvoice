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
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents Cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
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
    Friend WithEvents cmd_BillSettlement As System.Windows.Forms.Button
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(KOT_Billing))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.FraGrid = New System.Windows.Forms.GroupBox
        Me.ssGrid1 = New AxFPSpreadADO.AxfpSpread
        Me.GraMem = New System.Windows.Forms.GroupBox
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
        Me.cmd_BillNoHelp = New System.Windows.Forms.Button
        Me.txt_BillNo = New System.Windows.Forms.TextBox
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
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Delete = New System.Windows.Forms.Button
        Me.Cmd_AddNew = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Lbl_Bill = New System.Windows.Forms.Label
        Me.Txt_Remarks = New System.Windows.Forms.TextBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.cmd_BillSettlement = New System.Windows.Forms.Button
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
        CType(Me.ssGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Paymentmodeselection.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp_Chequedetails.SuspendLayout()
        Me.grp_Carddetails.SuspendLayout()
        Me.grpNewMcode.SuspendLayout()
        Me.grpPass.SuspendLayout()
        CType(Me.ssgridPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.Black
        Me.lbl_Heading.Location = New System.Drawing.Point(400, 8)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(222, 35)
        Me.lbl_Heading.TabIndex = 18
        Me.lbl_Heading.Text = "FINAL BILLING"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FraGrid
        '
        Me.FraGrid.BackColor = System.Drawing.Color.Transparent
        Me.FraGrid.Location = New System.Drawing.Point(80, 272)
        Me.FraGrid.Name = "FraGrid"
        Me.FraGrid.Size = New System.Drawing.Size(864, 272)
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
        Me.GraMem.Location = New System.Drawing.Point(80, 136)
        Me.GraMem.Name = "GraMem"
        Me.GraMem.Size = New System.Drawing.Size(864, 136)
        Me.GraMem.TabIndex = 25
        Me.GraMem.TabStop = False
        '
        'lbl_SubPaymentMode
        '
        Me.lbl_SubPaymentMode.AutoSize = True
        Me.lbl_SubPaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubPaymentMode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubPaymentMode.Location = New System.Drawing.Point(496, 152)
        Me.lbl_SubPaymentMode.Name = "lbl_SubPaymentMode"
        Me.lbl_SubPaymentMode.Size = New System.Drawing.Size(218, 25)
        Me.lbl_SubPaymentMode.TabIndex = 27
        Me.lbl_SubPaymentMode.Text = "SUB PAYMENT MODE :"
        Me.lbl_SubPaymentMode.Visible = False
        '
        'cbo_SubPaymentMode
        '
        Me.cbo_SubPaymentMode.BackColor = System.Drawing.Color.Wheat
        Me.cbo_SubPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SubPaymentMode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SubPaymentMode.Location = New System.Drawing.Point(728, 152)
        Me.cbo_SubPaymentMode.Name = "cbo_SubPaymentMode"
        Me.cbo_SubPaymentMode.Size = New System.Drawing.Size(192, 30)
        Me.cbo_SubPaymentMode.TabIndex = 1
        Me.cbo_SubPaymentMode.Visible = False
        '
        'cbo_PaymentMode
        '
        Me.cbo_PaymentMode.BackColor = System.Drawing.Color.Wheat
        Me.cbo_PaymentMode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_PaymentMode.Location = New System.Drawing.Point(272, 152)
        Me.cbo_PaymentMode.Name = "cbo_PaymentMode"
        Me.cbo_PaymentMode.Size = New System.Drawing.Size(192, 30)
        Me.cbo_PaymentMode.TabIndex = 0
        '
        'lbl_PaymentMode
        '
        Me.lbl_PaymentMode.AutoSize = True
        Me.lbl_PaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PaymentMode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PaymentMode.Location = New System.Drawing.Point(93, 152)
        Me.lbl_PaymentMode.Name = "lbl_PaymentMode"
        Me.lbl_PaymentMode.Size = New System.Drawing.Size(171, 25)
        Me.lbl_PaymentMode.TabIndex = 26
        Me.lbl_PaymentMode.Text = "PAYMENT MODE :"
        '
        'txt_ServerName
        '
        Me.txt_ServerName.BackColor = System.Drawing.Color.Wheat
        Me.txt_ServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerName.Location = New System.Drawing.Point(728, 232)
        Me.txt_ServerName.MaxLength = 35
        Me.txt_ServerName.Name = "txt_ServerName"
        Me.txt_ServerName.ReadOnly = True
        Me.txt_ServerName.Size = New System.Drawing.Size(192, 29)
        Me.txt_ServerName.TabIndex = 5
        Me.txt_ServerName.Text = ""
        '
        'lbl_ServerName
        '
        Me.lbl_ServerName.AutoSize = True
        Me.lbl_ServerName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ServerName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ServerName.Location = New System.Drawing.Point(554, 232)
        Me.lbl_ServerName.Name = "lbl_ServerName"
        Me.lbl_ServerName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_ServerName.TabIndex = 33
        Me.lbl_ServerName.Text = "SERVER NAME :"
        '
        'Cmd_ServerCodeHelp
        '
        Me.Cmd_ServerCodeHelp.Image = CType(resources.GetObject("Cmd_ServerCodeHelp.Image"), System.Drawing.Image)
        Me.Cmd_ServerCodeHelp.Location = New System.Drawing.Point(440, 232)
        Me.Cmd_ServerCodeHelp.Name = "Cmd_ServerCodeHelp"
        Me.Cmd_ServerCodeHelp.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ServerCodeHelp.TabIndex = 32
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(440, 192)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(23, 29)
        Me.cmd_MemberCodeHelp.TabIndex = 29
        '
        'txt_ServerCode
        '
        Me.txt_ServerCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_ServerCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerCode.Location = New System.Drawing.Point(272, 232)
        Me.txt_ServerCode.MaxLength = 10
        Me.txt_ServerCode.Name = "txt_ServerCode"
        Me.txt_ServerCode.Size = New System.Drawing.Size(168, 29)
        Me.txt_ServerCode.TabIndex = 4
        Me.txt_ServerCode.Text = ""
        '
        'lbl_ServerCode
        '
        Me.lbl_ServerCode.AutoSize = True
        Me.lbl_ServerCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ServerCode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ServerCode.Location = New System.Drawing.Point(104, 232)
        Me.lbl_ServerCode.Name = "lbl_ServerCode"
        Me.lbl_ServerCode.Size = New System.Drawing.Size(160, 25)
        Me.lbl_ServerCode.TabIndex = 31
        Me.lbl_ServerCode.Text = "SERVER CODE :"
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(272, 192)
        Me.txt_MemberCode.MaxLength = 10
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(168, 29)
        Me.txt_MemberCode.TabIndex = 2
        Me.txt_MemberCode.Text = ""
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.AutoSize = True
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.Location = New System.Drawing.Point(104, 192)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(160, 25)
        Me.lbl_MemberCode.TabIndex = 28
        Me.lbl_MemberCode.Text = "MEMBER CODE :"
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BackColor = System.Drawing.Color.Wheat
        Me.txt_MemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(728, 192)
        Me.txt_MemberName.MaxLength = 35
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.ReadOnly = True
        Me.txt_MemberName.Size = New System.Drawing.Size(192, 29)
        Me.txt_MemberName.TabIndex = 3
        Me.txt_MemberName.Text = ""
        '
        'lbl_MemberName
        '
        Me.lbl_MemberName.AutoSize = True
        Me.lbl_MemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberName.Location = New System.Drawing.Point(554, 192)
        Me.lbl_MemberName.Name = "lbl_MemberName"
        Me.lbl_MemberName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_MemberName.TabIndex = 30
        Me.lbl_MemberName.Text = "MEMBER NAME :"
        '
        'GrpBill
        '
        Me.GrpBill.BackColor = System.Drawing.Color.Transparent
        Me.GrpBill.Location = New System.Drawing.Point(552, 40)
        Me.GrpBill.Name = "GrpBill"
        Me.GrpBill.Size = New System.Drawing.Size(392, 96)
        Me.GrpBill.TabIndex = 20
        Me.GrpBill.TabStop = False
        '
        'cmd_BillNoHelp
        '
        Me.cmd_BillNoHelp.Image = CType(resources.GetObject("cmd_BillNoHelp.Image"), System.Drawing.Image)
        Me.cmd_BillNoHelp.Location = New System.Drawing.Point(904, 56)
        Me.cmd_BillNoHelp.Name = "cmd_BillNoHelp"
        Me.cmd_BillNoHelp.Size = New System.Drawing.Size(23, 32)
        Me.cmd_BillNoHelp.TabIndex = 22
        '
        'txt_BillNo
        '
        Me.txt_BillNo.BackColor = System.Drawing.Color.Wheat
        Me.txt_BillNo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BillNo.ForeColor = System.Drawing.Color.Blue
        Me.txt_BillNo.Location = New System.Drawing.Point(712, 56)
        Me.txt_BillNo.Name = "txt_BillNo"
        Me.txt_BillNo.Size = New System.Drawing.Size(192, 32)
        Me.txt_BillNo.TabIndex = 15
        Me.txt_BillNo.Text = ""
        '
        'lbl_BillNo
        '
        Me.lbl_BillNo.AutoSize = True
        Me.lbl_BillNo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillNo.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillNo.Location = New System.Drawing.Point(580, 61)
        Me.lbl_BillNo.Name = "lbl_BillNo"
        Me.lbl_BillNo.Size = New System.Drawing.Size(113, 25)
        Me.lbl_BillNo.TabIndex = 21
        Me.lbl_BillNo.Text = "BILL NO :"
        '
        'lbl_BillDate
        '
        Me.lbl_BillDate.AutoSize = True
        Me.lbl_BillDate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillDate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillDate.Location = New System.Drawing.Point(560, 96)
        Me.lbl_BillDate.Name = "lbl_BillDate"
        Me.lbl_BillDate.Size = New System.Drawing.Size(136, 25)
        Me.lbl_BillDate.TabIndex = 23
        Me.lbl_BillDate.Text = "BILL DATE :"
        '
        'lbl_BillAmount
        '
        Me.lbl_BillAmount.AutoSize = True
        Me.lbl_BillAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillAmount.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillAmount.Location = New System.Drawing.Point(584, 557)
        Me.lbl_BillAmount.Name = "lbl_BillAmount"
        Me.lbl_BillAmount.Size = New System.Drawing.Size(160, 25)
        Me.lbl_BillAmount.TabIndex = 37
        Me.lbl_BillAmount.Text = "BILL AMOUNT :"
        '
        'txt_BillAmount
        '
        Me.txt_BillAmount.BackColor = System.Drawing.Color.Wheat
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
        Me.dtp_BillDate.Location = New System.Drawing.Point(712, 96)
        Me.dtp_BillDate.Name = "dtp_BillDate"
        Me.dtp_BillDate.Size = New System.Drawing.Size(128, 26)
        Me.dtp_BillDate.TabIndex = 16
        '
        'txt_KOTTime
        '
        Me.txt_KOTTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_KOTTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_KOTTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_KOTTime.Location = New System.Drawing.Point(840, 96)
        Me.txt_KOTTime.Name = "txt_KOTTime"
        Me.txt_KOTTime.ReadOnly = True
        Me.txt_KOTTime.Size = New System.Drawing.Size(88, 26)
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
        Me.lbl_Status.Location = New System.Drawing.Point(96, 72)
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
        Me.Lbl_OtherBill.Location = New System.Drawing.Point(88, 112)
        Me.Lbl_OtherBill.Name = "Lbl_OtherBill"
        Me.Lbl_OtherBill.Size = New System.Drawing.Size(440, 24)
        Me.Lbl_OtherBill.TabIndex = 24
        Me.Lbl_OtherBill.Text = "OTHER BILLNO :"
        Me.Lbl_OtherBill.Visible = False
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(96, 288)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(840, 248)
        Me.ssGrid.TabIndex = 34
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(88, 616)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 8
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(588, 616)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 12
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Delete
        '
        Me.Cmd_Delete.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Delete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.Cmd_Delete.Image = CType(resources.GetObject("Cmd_Delete.Image"), System.Drawing.Image)
        Me.Cmd_Delete.Location = New System.Drawing.Point(463, 616)
        Me.Cmd_Delete.Name = "Cmd_Delete"
        Me.Cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Delete.TabIndex = 11
        Me.Cmd_Delete.Text = "Delete[F8]"
        '
        'Cmd_AddNew
        '
        Me.Cmd_AddNew.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_AddNew.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_AddNew.ForeColor = System.Drawing.Color.White
        Me.Cmd_AddNew.Image = CType(resources.GetObject("Cmd_AddNew.Image"), System.Drawing.Image)
        Me.Cmd_AddNew.Location = New System.Drawing.Point(213, 616)
        Me.Cmd_AddNew.Name = "Cmd_AddNew"
        Me.Cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_AddNew.TabIndex = 9
        Me.Cmd_AddNew.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(838, 616)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 14
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(80, 600)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(872, 56)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(713, 616)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 13
        Me.Cmd_Print.Text = "Print[F10]"
        '
        'Lbl_Bill
        '
        Me.Lbl_Bill.AutoSize = True
        Me.Lbl_Bill.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Bill.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bill.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_Bill.Location = New System.Drawing.Point(40, 576)
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
        Me.Txt_Remarks.Size = New System.Drawing.Size(328, 48)
        Me.Txt_Remarks.TabIndex = 7
        Me.Txt_Remarks.Text = ""
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(96, 558)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(113, 25)
        Me.lbl_Remarks.TabIndex = 35
        Me.lbl_Remarks.Text = "REMARKS :"
        '
        'cmd_BillSettlement
        '
        Me.cmd_BillSettlement.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_BillSettlement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_BillSettlement.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_BillSettlement.ForeColor = System.Drawing.Color.White
        Me.cmd_BillSettlement.Image = CType(resources.GetObject("cmd_BillSettlement.Image"), System.Drawing.Image)
        Me.cmd_BillSettlement.Location = New System.Drawing.Point(344, 616)
        Me.cmd_BillSettlement.Name = "cmd_BillSettlement"
        Me.cmd_BillSettlement.Size = New System.Drawing.Size(104, 32)
        Me.cmd_BillSettlement.TabIndex = 10
        Me.cmd_BillSettlement.Text = "Bill Settle [F5]"
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
        Me.grp_Paymentmodeselection.Location = New System.Drawing.Point(80, 280)
        Me.grp_Paymentmodeselection.Name = "grp_Paymentmodeselection"
        Me.grp_Paymentmodeselection.Size = New System.Drawing.Size(864, 312)
        Me.grp_Paymentmodeselection.TabIndex = 360
        Me.grp_Paymentmodeselection.TabStop = False
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(80, 685)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(920, 16)
        Me.Label3.TabIndex = 361
        Me.Label3.Text = "F4-->Help  F2-->Bill No    Alt+P--> Payment Mode   Alt+B--> Member Code  Alt+S-->" & _
        " Server Code Alt+G-->Focus on Grid"
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
        Me.lblCro1.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lblCro1.Location = New System.Drawing.Point(107, 46)
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
        Me.lblCro2.Location = New System.Drawing.Point(179, 46)
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
        Me.grpNewMcode.Location = New System.Drawing.Point(81, 232)
        Me.grpNewMcode.Name = "grpNewMcode"
        Me.grpNewMcode.Size = New System.Drawing.Size(864, 176)
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
        Me.txtNmcode.Location = New System.Drawing.Point(191, 39)
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
        Me.Label2.Location = New System.Drawing.Point(24, 40)
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
        Me.cmdMcodeUpd.Location = New System.Drawing.Point(293, 662)
        Me.cmdMcodeUpd.Name = "cmdMcodeUpd"
        Me.cmdMcodeUpd.Size = New System.Drawing.Size(440, 24)
        Me.cmdMcodeUpd.TabIndex = 367
        Me.cmdMcodeUpd.Text = "<<  Member Code Updation  >>"
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
        Me.grpPass.Location = New System.Drawing.Point(373, 432)
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
        Me.cmdOk.ForeColor = System.Drawing.Color.White
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
        Me.ssgridPayment.DataSource = Nothing
        Me.ssgridPayment.Location = New System.Drawing.Point(96, 288)
        Me.ssgridPayment.Name = "ssgridPayment"
        Me.ssgridPayment.OcxState = CType(resources.GetObject("ssgridPayment.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgridPayment.Size = New System.Drawing.Size(840, 248)
        Me.ssgridPayment.TabIndex = 369
        '
        'KOT_Billing
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpPass)
        Me.Controls.Add(Me.grpNewMcode)
        Me.Controls.Add(Me.ssGrid)
        Me.Controls.Add(Me.cmdMcodeUpd)
        Me.Controls.Add(Me.lblCro2)
        Me.Controls.Add(Me.lblCro1)
        Me.Controls.Add(Me.lblDeleted)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmd_BillSettlement)
        Me.Controls.Add(Me.txt_KOTTime)
        Me.Controls.Add(Me.txt_BillAmount)
        Me.Controls.Add(Me.lbl_BillAmount)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.txt_ServerCode)
        Me.Controls.Add(Me.lbl_MemberName)
        Me.Controls.Add(Me.txt_ServerName)
        Me.Controls.Add(Me.lbl_ServerCode)
        Me.Controls.Add(Me.lbl_ServerName)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.lbl_MemberCode)
        Me.Controls.Add(Me.txt_MemberName)
        Me.Controls.Add(Me.lbl_PaymentMode)
        Me.Controls.Add(Me.lbl_BillNo)
        Me.Controls.Add(Me.lbl_BillDate)
        Me.Controls.Add(Me.txt_BillNo)
        Me.Controls.Add(Me.lbl_SubPaymentMode)
        Me.Controls.Add(Me.Txt_Remarks)
        Me.Controls.Add(Me.lbl_Remarks)
        Me.Controls.Add(Me.Lbl_Bill)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Delete)
        Me.Controls.Add(Me.Cmd_AddNew)
        Me.Controls.Add(Me.Cmd_Exit)
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
        Me.Controls.Add(Me.GraMem)
        Me.Controls.Add(Me.grp_Paymentmodeselection)
        Me.Controls.Add(Me.ssgridPayment)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "KOT_Billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FINAL BILLING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ssGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Paymentmodeselection.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grp_Chequedetails.ResumeLayout(False)
        Me.grp_Carddetails.ResumeLayout(False)
        Me.grpNewMcode.ResumeLayout(False)
        Me.grpPass.ResumeLayout(False)
        CType(Me.ssgridPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim i As Integer
    Public Billno() As String
    Dim txt_creditfacility As String
    Dim BillDetails As String
    Dim gconnection As New GlobalClass
    Dim itembool, chkbool, smartcardbool As Boolean
    Dim KotDetails, BillMcode, BillMname As String
    Public dblBillTotalAmount, dblBillNonTotalAmount, dblBillTaxTotal, dblBillNonTaxtotal, gridRow As Double
    Public billstatus, BillTaxBillno, BillTaxBilldetails, BillNonTaxBilldetails, BillNonTaxBillno As String
    Dim duplicateflag As Boolean = False
    Private Sub FillBillPrefix()
        Dim Sqlstring As String
        Sqlstring = "SELECT ISNULL(BillPrefix,'') AS BillPrefix FROM POSSETUP"
        gconnection.getDataSet(Sqlstring, "POSSETUP")
        If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
            BillPrefix = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPrefix"))
        Else
            BillPrefix = Mid(MyCompanyName, 1, 3)
        End If
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

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_SubPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        Call clearform(Me)
        Call autogenerate()
        Call ShowBillno()
        Call fillPayment_Mode()
        Call GridUnLocking()
        txt_MemberCode.Tag = ""
        Cmd_AddNew.Text = "Add [F7]"
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
        Me.Cmd_AddNew.Enabled = True
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
        grpPass.Visible = False
        grpNewMcode.Visible = False

        Call SetDateTime()

    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub KOT_Billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_SubPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        Call FillDefaultPayment()
        Call PaymentGridLocking()
        Call FillBillPrefix()
        Call fillPayment_Mode()
        Call GridUnLocking()
        Call autogenerate()
        Call ShowBillno()
        finalbillbool = True
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
        'dtp_BillDate.Value = Now
        Call SetDateTime()
    End Sub
    Public Function SetDateTime()
        If Val(Now.Hour) >= 0 And Val(Now.Hour) <= 5 Then
            dtp_BillDate.Value = DateAdd(DateInterval.Day, -1, Now)
            KOT_Timer.Enabled = False
            Select Case Val(Now.Hour)
                Case 1
                    txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-65 - Now.Minute), Now).ToLongTimeString
                Case 2
                    txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-125 - Now.Minute), Now).ToLongTimeString
                Case 3
                    txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-185 - Now.Minute), Now).ToLongTimeString
                Case 4
                    txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-245 - Now.Minute), Now).ToLongTimeString
                Case 5
                    txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-305 - Now.Minute), Now).ToLongTimeString
                Case 0
                    txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-5 - Now.Minute), Now).ToLongTimeString
            End Select
        Else
            KOT_Timer.Enabled = True
            txt_KOTTime.Text = Now.ToLongTimeString
            dtp_BillDate.Value = Now.Date
        End If

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
        ElseIf e.KeyCode = Keys.F7 Then
            If Cmd_AddNew.Enabled = True Then
                Call Cmd_AddNew_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            Call Cmd_Delete_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F10 Then
            Call Cmd_Print_Click(sender, e)
            Exit Sub
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
        ElseIf e.Alt = True And e.KeyCode = Keys.P Then
            Me.cbo_PaymentMode.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.G Then
            Me.ssGrid.Focus()
            Me.ssGrid.SetActiveCell(1, 1)
            Exit Sub
        End If
    End Sub
    Private Sub fillPayment_Mode()
        Dim sqlstring As String
        Dim index As Integer
        Dim i As Integer
        Try
            If Mid(Trim(Cmd_AddNew.Text), 1, 1) = "A" Then
                Call FillDefaultPayment()

                'Modified on 18 Mar'08
                'Mk Kannan
                'Begin
                'sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Paymentcode NOT IN ('CLUB')AND Isnull(Freeze,'N')='N'"

                sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'N')='N'"
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
            Else
                Call FillDefaultPayment()
                sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'N')='N'"
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
        '''''''''Try
        ''''''financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
        ''''''sqlstring = "SELECT MAX(cast(SUBSTRING(BillNo,1,6) as numeric)) AS BillNo FROM BILL_hdr WHERE SUBSTRING(BILLDETAILS,1,3) = '" & BillPrefix & "'"
        ''''''gconnection.getDataSet(sqlstring, "Bill_hdr")
        ''''''If gdataset.Tables("Bill_hdr").Rows(0).IsNull("BillNo") = True Then
        ''''''    txt_BillNo.Text = BillPrefix & "/000001/" & financalyear
        ''''''Else
        ''''''    If gdataset.Tables("Bill_hdr").Rows.Count > 0 Then
        ''''''        txt_BillNo.Text = BillPrefix & "/" & Format(Val(gdataset.Tables("Bill_hdr").Rows(0).Item("BillNo")) + 1, "000000") & "/" & financalyear
        ''''''    Else
        ''''''        txt_BillNo.Text = BillPrefix & "/000001/" & financalyear
        ''''''    End If
        ''''''End If


        'Catch ex As Exception
        '    MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try


        Try
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)

            'Modified on 06 Apr'08 for Generating Usernamewise KOT
            'Advised by :- Sandeep after having discussion with him at 06 Apr'08 Mid Night 11.30 P.M
            'Mk Kannan
            'Begin
            'sqlstring = "SELECT MAX(Cast(SUBSTRING(KOTno,1,6) As Numeric)) FROM KOT_HDR WHERE DocType ='SALE'"
            ' Call UserValidation()

            'Begin
            'End

            sqlstring = "SELECT Isnull(DocNo,0) FROM PoSKotDoc with(rowlock,holdlock) Where DocType = 'CSC'"
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader


            If gdreader.Read Then

                If gdreader(0) Is System.DBNull.Value Then
                    txt_BillNo.Text = "CSC/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_BillNo.Text = "CSC/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_BillNo.Text = "CSC/000001/" & financalyear
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
BEGIN:
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            sqlstring = "SELECT Isnull(DocNo,0),DOCFLAG FROM PoSKotDoc with(rowlock,holdlock) Where DocType = 'CSC'"
            gconnection.getDataSet(sqlstring, "POSKOTDOC")
            If gdataset.Tables("poskotdoc").Rows.Count > 0 Then
                If gdataset.Tables("POSKOTDOC").Rows(0).Item("DOCFLAG") = "N" Then
                    sqlstring_upd = "UPDATE POSKOTDOC SET DOCFLAG='Y' WHERE DOCFLAG='N' and doctype='CSC'"
                    gconnection.dataOperation(7, sqlstring_upd)
                Else
                    GoTo BEGIN
                End If
            Else
                GoTo BEGIN
            End If

            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader

            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_BillNo.Text = "CSC/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_BillNo.Text = "CSC/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If

            Else
                txt_BillNo.Text = "CSC/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
                GoTo BEGIN
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
                txt_ServerCode.Focus()
            End If
            vform.Close()
            vform = Nothing
        Else
            gSQLString = "SELECT mcode,mname FROM Membermaster"
            M_WhereCondition = ""
            vform.Field = " MCODE,MNAME "
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
    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Dim strstring As String
        Try
            If Trim(txt_MemberCode.Text) <> "" Then
                If cbo_PaymentMode.Text = "ROOM" Then
                    strstring = "SELECT roomno,guest,docno FROM roomcheckin WHERE isnull(checkout,'') <> 'Y' and roomstatus='occupied' AND RoomNo='" & Trim(txt_MemberCode.Text) & "'"
                    '                    strstring = "SELECT roomno,guest,docno FROM roomcheckin WHERE RoomNo='" & Trim(txt_MemberCode.Text) & "'"
                    gconnection.getDataSet(strstring, "RoomCheckin")
                    If gdataset.Tables("RoomCheckin").Rows.Count > 0 Then
                        txt_MemberCode.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("RoomNo")
                        txt_MemberName.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("Guest")
                        txt_MemberCode.Tag = gdataset.Tables("RoomCheckin").Rows(0).Item("docno")
                        txt_ServerCode.Focus()
                    Else
                        txt_MemberCode.Text = ""
                        txt_MemberCode.Focus()
                    End If
                Else
                    strstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CREDITNO,'') AS CREDITNO FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                    gconnection.getDataSet(strstring, "membermaster")
                    If gdataset.Tables("membermaster").Rows.Count > 0 Then
                        txt_MemberCode.Text = gdataset.Tables("membermaster").Rows(0).Item("MCODE")
                        txt_MemberName.Text = gdataset.Tables("membermaster").Rows(0).Item("MNAME")
                        txt_creditfacility = gdataset.Tables("membermaster").Rows(0).Item("CREDITNO")
                        txt_ServerCode.Focus()
                    Else
                        txt_MemberCode.Text = ""
                        txt_MemberCode.Focus()
                    End If
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
                strstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CREDITNO,'') AS CREDITNO FROM membermaster WHERE MCODE='" & Trim(txtNmcode.Text) & "'"
                gconnection.getDataSet(strstring, "membermaster")
                If gdataset.Tables("membermaster").Rows.Count > 0 Then
                    txtNmcode.Text = gdataset.Tables("membermaster").Rows(0).Item("MCODE")
                    txtNmname.Text = gdataset.Tables("membermaster").Rows(0).Item("MNAME")
                Else
                    txtNmcode.Text = ""
                    cmdUpdate.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Entry Plz try once again", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_MemberCode.Focus()
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_ServerCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ServerCodeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT Servercode, Servername FROM servermaster"
        M_WhereCondition = " WHERE FREEZE='N'"
        vform.Field = " SERVERCODE, SERVERNAME "
        vform.vFormatstring = "         SERVER CODE            |                       SERVERNAME                               "
        vform.vCaption = "SERVER MASTER HELP"
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
        Dim strstring As String
        Try
            If Trim(txt_ServerCode.Text) <> "" Then
                strstring = "SELECT * FROM servermaster WHERE ServerCode='" & Trim(txt_ServerCode.Text) & "'AND Freeze='N'"
                gconnection.getDataSet(strstring, "servermaster")
                If gdataset.Tables("servermaster").Rows.Count > 0 Then
                    txt_ServerCode.Text = gdataset.Tables("servermaster").Rows(0).Item("ServerCode")
                    txt_ServerName.Text = gdataset.Tables("servermaster").Rows(0).Item("ServerName")
                    txt_ServerCode.ReadOnly = True
                    'If Me.Cmd_AddNew.Text = "Add [F7]" Then
                    Call FillKOTdetails() '''*********************** Fill all KOT'S in that grid ***************
                    'End If
                    ssGrid.Focus()
                Else
                    If Mid(Cmd_AddNew.Text, 1, 1) = "A" Then
                        txt_ServerCode.Text = ""
                        txt_ServerCode.Focus()
                    Else
                        ssGrid.Focus()
                    End If
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
                '                If Me.Cmd_AddNew.Text = "Add [F7]" Then
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
        Dim sqlstring, KOTno, KOTdate As String
        Dim i As Integer
        chkbool = False
        '''**************************************** Check Payment Mode can't be blank *******************************************''
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
        If Trim(txt_MemberCode.Text) = "" Then
            If cbo_PaymentMode.Text = "CREDIT" And Len(Trim(txt_creditfacility)) = 0 Then
                MessageBox.Show("This member is Not entitled for Credit facility", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_MemberCode.Focus()
                Exit Sub
            ElseIf cbo_PaymentMode.Text = "N.CREDIT" And Len(Trim(txt_creditfacility)) > 0 Then
                MessageBox.Show("This member has the credit Facility. Kindly change the mode of payment", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_MemberCode.Focus()
                Exit Sub
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
            MessageBox.Show("Server Code. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_ServerCode.Focus()
            Exit Sub
        End If
        If cbo_PaymentMode.Text = "CREDIT" And Len(Trim(txt_creditfacility)) = 0 Then
            MessageBox.Show("This member is not not entitled for Credit facility", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_MemberCode.Focus()
            Exit Sub
        ElseIf cbo_PaymentMode.Text = "N.CREDIT" And Len(Trim(txt_creditfacility)) > 0 Then
            MessageBox.Show("This member has the credit Facility. Kindly change the mode of payment", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_MemberCode.Focus()
            Exit Sub
        End If
        '''**************************************** Check Server Name can't be blank *******************************************''
        If Trim(txt_ServerName.Text) = "" Then
            MessageBox.Show("Server Name Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_ServerName.Focus()
            Exit Sub
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
        '''********************************************** Check The status of that particular grid **********************************'''
        If Mid(Trim(Cmd_AddNew.Text), 1, 1) = "A" Then
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
                End If
            Next i
        End If
        chkbool = True
    End Sub
    Private Sub Cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_AddNew.Click
        Dim taxbilldetails, taxbillno, nontaxbilldetails, nontaxbillno, Otherbillno As String
        Dim Oldtaxbilldetails, Oldtaxbillno, Oldnontaxbilldetails, Oldnontaxbillno, OldOtherbillno As String
        Dim sqlstring, Varchk, SubpaymentMode(), paymentaccountcode, Subpaymentaccountcode As String
        Dim TotalAmount, TaxTotal, total, size, CardAmount, i, j, Z, dblCard, dblMinimum As Double
        Dim TaxApp, NoTax, Otherbool As Boolean
        Dim ttotal, tntotal, ttaxtotal, tntaxtotal As Double
        Dim Kot_Bill As New DataTable
        Dim Taxdr(), NoTaxDr() As DataRow
        Dim Update1(0) As String
        Dim financalyear As String
        Dim DELSQL, sqlstringRoom As String
        TaxApp = False
        NoTax = False

        Try
            Call checkvalidate() '''---> Check Validation
            If chkbool = False Then Exit Sub
            ''''************************************************* Case-1:ADD [F7] ***********************************'''
            If Mid(CStr(Cmd_AddNew.Text), 1, 1) = "A" Then
                Call autogenerate_add()

                'Validating the Document
                'Kannan.Mk()
                'Begin 26.05.08
                'BEGIN:
                '                Call autogenerate()
                '                sqlstring = "Exec SP_POSKOTDOCROWCOUNT"
                '                gconnection.ExcuteStoreProcedure(sqlstring)
                '                sqlstring = "SELECT NOOFROWEFFECTED FROM TBL_ROWCOUNT"
                '                gconnection.getDataSet(sqlstring, "NOOFROWEFFECT")
                '                If gdataset.Tables("NOOFROWEFFECT").Rows.Count > 0 Then
                '                    If Val(gdataset.Tables("NOOFROWEFFECT").Rows(0).Item(0)) = 0 Then
                '                        GoTo BEGIN
                '                    End If
                '                Else
                '                    GoTo BEGIN
                '                End If
                '                'End
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
                        x = "CSC/" & Billno(1) & "/" & Microsoft.VisualBasic.Right(Trim(txt_BillNo.Text), 5)
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

                If NoTaxDr.Length > 0 And Taxdr.Length > 0 Then
                    If CHECK_BILLEXIST(nontaxbillno) = True Then
                        Exit Sub
                    End If
                    If CHECK_BILLEXIST(taxbillno) = True Then
                        Exit Sub
                    End If
                ElseIf Taxdr.Length > 0 Then
                    If CHECK_BILLEXIST(taxbillno) = True Then
                        Exit Sub
                    End If
                ElseIf NoTaxDr.Length > 0 Then
                    If CHECK_BILLEXIST(nontaxbillno) = True Then
                        Exit Sub
                    End If
                End If

                If Taxdr.Length > 0 Then
                    TaxTotal = 0
                    TotalAmount = 0
                    j = 0
                    For i = 0 To Taxdr.Length - 1
                        sqlstring = " INSERT INTO Bill_Det(Billno,BillDetails,BillDate,KotDetails,TaxAmount,KotAmount,OthBillDetails,KotDate,TaxCode) VALUES ("
                        sqlstring = sqlstring & "'" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Trim(CStr(Taxdr(i).Item("KotDetails"))) & "',"
                        sqlstring = sqlstring & "" & Val(Taxdr(i).Item("TaxAmount")) & "," & Val(Taxdr(i).Item("Amount")) & ",'" & Trim(CStr(nontaxbilldetails)) & "',"
                        sqlstring = sqlstring & "'" & Format(CDate(Taxdr(i).Item("KotDate")), "dd-MMM-yyyy") & "','" & Trim(Taxdr(i).Item("TaxCode")) & "')"
                        Update(j) = sqlstring

                        billstatus = "ST"
                        sqlstring = "UPDATE KOT_HDR SET "
                        sqlstring = sqlstring & "BillStatus='" & billstatus & "',Crostatus='N',PaymentType ='" & Trim(Me.cbo_PaymentMode.Text) & "',Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ',"
                        sqlstring = sqlstring & "SubPaymentMode ='" & Trim(SubpaymentMode(0)) & "',subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ' WHERE Kotdetails='" & Trim(CStr(Taxdr(i).Item("KotDetails"))) & "'"

                        j = j + 1
                        Update(j) = sqlstring

                        sqlstring = "UPDATE KOT_DET SET BillDetails='" & Trim(taxbilldetails) & "'"
                        sqlstring = sqlstring & "WHERE Kotdetails='" & Trim(CStr(Taxdr(i).Item("KotDetails"))) & "' and Isnull(Taxcode,'')<> ''"

                        j = j + 1
                        Update(j) = sqlstring

                        j = j + 1
                        TaxTotal = TaxTotal + Val(Taxdr(i).Item("TaxAmount"))
                        TotalAmount = TotalAmount + Val(Taxdr(i).Item("Amount"))
                    Next i
                    If cbo_PaymentMode.SelectedItem = "ROOM" Then
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks) VALUES"
                        sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','','','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N'," & Val(Me.txt_MemberCode.Text) & ","
                        sqlstring = sqlstring & "" & Val(Me.txt_MemberCode.Tag) & ",'" & Trim(Me.txt_MemberName.Text) & "','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks) VALUES"
                        sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & txt_MemberCode.Text & "','" & txt_MemberName.Text & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks) VALUES"
                        sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & txt_MemberCode.Text & "','" & txt_MemberName.Text & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks) VALUES"
                        sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,remarks) VALUES"
                        sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
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
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks) VALUES"
                        sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Format(Val(dblMinimum), "0.00") & "," & Format(Val(dblCard), "0.00") & ",'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    Else
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks) VALUES"
                        sqlstring = sqlstring & "('" & Trim(CStr(taxbillno)) & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "',"
                        sqlstring = sqlstring & "'" & Trim(Me.txt_ServerName.Text) & "','N',0,0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
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

                        sqlstring = "UPDATE KOT_DET SET BillDetails='" & Trim(nontaxbilldetails) & "'"
                        sqlstring = sqlstring & "WHERE Kotdetails='" & Trim(CStr(NoTaxDr(i).Item("KotDetails"))) & "'and Isnull(Taxcode,'')='' "

                        j = j + 1
                        Update(j) = sqlstring
                        j = j + 1
                        TaxTotal = TaxTotal + Val(NoTaxDr(i).Item("TaxAmount"))
                        TotalAmount = TotalAmount + Val(NoTaxDr(i).Item("Amount"))
                    Next
                    If cbo_PaymentMode.SelectedItem = "ROOM" Then
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks) VALUES"
                        sqlstring = sqlstring & "('" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','','','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N'," & Val(Me.txt_MemberCode.Text) & ","
                        sqlstring = sqlstring & "" & Val(Me.txt_MemberCode.Tag) & ",'" & Trim(Me.txt_MemberName.Text) & "','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks) VALUES"
                        sqlstring = sqlstring & "('" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & txt_MemberCode.Text & "','" & txt_MemberName.Text & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks) VALUES"
                        sqlstring = sqlstring & "('" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & txt_MemberCode.Text & "','" & txt_MemberName.Text & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks) VALUES"
                        sqlstring = sqlstring & "('" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & txt_MemberCode.Text & "','" & txt_MemberName.Text & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks) VALUES"
                        sqlstring = sqlstring & "('" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
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
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks) VALUES"
                        sqlstring = sqlstring & "('" & Trim(CStr(nontaxbillno)) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "','" & Trim(Me.txt_ServerName.Text) & "','N',0,"
                        sqlstring = sqlstring & " 0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Format(Val(dblMinimum), "0.00") & "," & Format(Val(dblCard), "0.00") & ",'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    Else
                        sqlstring = "INSERT INTO Bill_Hdr(Billno,BillDetails,BillDate,BillTime,TaxAmount,BillAmount,Roundoff,PayMentmode,Paymentaccountcode,SubPaymentMode,Subpaymentaccountcode,Mcode,Mname,Scode,sname,CroStatus,Roomno,ChkId,Guest,AddUserId,AddDatetime,Upduserid,Upddatetime,Adjflag,Adjdate,Minimumusage,CardAmount,Remarks) VALUES"
                        sqlstring = sqlstring & "('" & CStr(nontaxbillno) & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','" & Format(Now, "hh:mm:ss") & "'," & Val(TaxTotal) & "," & Val(TotalAmount) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & ","
                        sqlstring = sqlstring & "'" & Trim(Me.cbo_PaymentMode.Text) & "','" & Trim(paymentaccountcode) & " ','" & Trim(SubpaymentMode(0)) & "','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Me.txt_MemberCode.Text) & "','" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "',"
                        sqlstring = sqlstring & "'" & Trim(Me.txt_ServerName.Text) & "','N',0,0,'','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "')"
                    End If
                    j = j + 1
                    Update(j) = sqlstring
                    tntaxtotal = TaxTotal
                    tntotal = TotalAmount
                End If
                '''************************************************** $ IF TAX ITEM IS INSERTED  $ ********************************************'''
                '''''************************************************** $ BILL SETTLEMENT IF ANY   $ ********************************************'''
                'For Z = 1 To ssgridPayment.DataRowCnt
                '    ssgridPayment.Col = 1
                '    ssgridPayment.Row = Z
                '    If Trim(ssgridPayment.Text) <> "" Then
                '        ssgridPayment.Col = 3
                '        ssgridPayment.Row = Z
                '        sqlstring = " SELECT ISNULL(Paymentcode,'') AS Paymentcode,ISNULL(paymentType,'') AS paymentType  FROM paymentmodemaster WHERE Paymentcode = '" & Trim(ssgridPayment.Text) & "' AND ISNULL(Freeze,'')='N'"
                '        gconnection.getDataSet(sqlstring, "paymentmodemaster")
                '        If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                '            If Trim(ssgridPayment.Text) = Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("Paymentcode")) And Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentType")) = "CD" Then
                '                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,Bankname,ReceivedName,Payamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime ) VALUES ("
                '                ssgridPayment.Row = Z
                '                ssgridPayment.Col = 1
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                ssgridPayment.Col = 2
                '                sqlstring = sqlstring & "'" & Format(CDate(ssGrid.Text), "dd-MMM-yyyy") & "',"
                '                ssgridPayment.Col = 3
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                ssgridPayment.Col = 5
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                ssgridPayment.Col = 6
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                sqlstring = sqlstring & "'" & Trim(txt_Typeofcard.Text) & "','" & Trim(txt_Cardno.Text) & "','" & Format(dtp_Expirydate.Value, "dd-MMM-yyyy") & "','','" & Trim(txt_Cardholdername.Text) & "',"
                '                ssgridPayment.Col = 4
                '                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                '                sqlstring = sqlstring & "'" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                '                ReDim Preserve Update(Update.Length)
                '                Update(Update.Length - 1) = sqlstring
                '            ElseIf Trim(ssgridPayment.Text) = Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("Paymentcode")) And Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentType")) = "CQ" Then
                '                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,Bankname,ReceivedName,Payamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime ) VALUES ("
                '                ssgridPayment.Row = Z
                '                ssgridPayment.Col = 1
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                ssgridPayment.Col = 2
                '                sqlstring = sqlstring & "'" & Format(CDate(ssGrid.Text), "dd-MMM-yyyy") & "',"
                '                ssgridPayment.Col = 3
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                ssgridPayment.Col = 4
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                ssgridPayment.Col = 5
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                sqlstring = sqlstring & "'" & Trim(cbo_Typeofcheque.Text) & "','" & Trim(txt_Chequeno.Text) & "','" & Format(dtp_Chequedate.Value, "dd-MMM-yyyy") & "','" & Trim(txt_Draweebank.Text) & "','',"
                '                ssgridPayment.Col = 4
                '                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                '                sqlstring = sqlstring & "'" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                '                ReDim Preserve Update(Update.Length)
                '                Update(Update.Length - 1) = sqlstring
                '            Else
                '                sqlstring = "INSERT INTO BILLSETTLEMENT (Billno,Billdate,PaymentMode,PaymentAccountCode,Mcode,Mname,CardType, Instrumentno,Instrumentdate,Bankname,ReceivedName,Payamount,AddUserid,Adddatetime,UpdateUserid,Updatedatetime ) VALUES ("
                '                ssgridPayment.Row = Z
                '                ssgridPayment.Col = 1
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                ssgridPayment.Col = 2
                '                sqlstring = sqlstring & "'" & Format(CDate(ssGrid.Text), "dd-MMM-yyyy") & "',"
                '                ssgridPayment.Col = 3
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                ssgridPayment.Col = 4
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                ssgridPayment.Col = 5
                '                sqlstring = sqlstring & "'" & Trim(ssGrid.Text) & "',"
                '                sqlstring = sqlstring & "'','','" & Format(Now, "dd-MMM-yyyy") & "','','',"
                '                ssgridPayment.Col = 4
                '                sqlstring = sqlstring & "" & Format(Val(ssgridPayment.Text), "0.00") & ","
                '                sqlstring = sqlstring & "'" & gUsername & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                '                ReDim Preserve Update(Update.Length)
                '                Update(Update.Length - 1) = sqlstring
                '            End If
                '        End If
                '    End If
                'Next Z
                ''''************************************************** $ BILL SETTLEMENT COMPLETE   $ ********************************************'''

                If NoTaxDr.Length > 0 And Taxdr.Length > 0 Then
                    If CHECK_BILLEXIST(nontaxbillno) = True Then
                        Exit Sub
                    End If
                    If CHECK_BILLEXIST(taxbillno) = True Then
                        Exit Sub
                    End If
                ElseIf Taxdr.Length > 0 Then
                    If CHECK_BILLEXIST(taxbillno) = True Then
                        Exit Sub
                    End If
                ElseIf NoTaxDr.Length > 0 Then
                    If CHECK_BILLEXIST(nontaxbillno) = True Then
                        Exit Sub
                    End If
                End If
                gconnection.MoreTransold(Update)

                'BEGIN

                ''===================================
                ''Changed on 16th apr
                'Dim Billno() As String

                'gcommand = New SqlCommand
                'financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
                'sqlstring = "SELECT Isnull(DocNo,0) FROM PoSKotDoc Where DocType = 'CSC'"
                'gconnection.openConnection()
                'gcommand.CommandText = sqlstring
                'gcommand.CommandType = CommandType.Text
                'gcommand.Connection = gconnection.Myconn
                'gdreader = gcommand.ExecuteReader
                'If gdreader.Read Then
                '    If gdreader(0) Is System.DBNull.Value Then
                '        txt_BillNo.Text = "CSC/000001/" & financalyear
                '        'txt_KOTno.Text = gPoSUsername & "/000001/" & financalyear
                '        gdreader.Close()
                '        gcommand.Dispose()
                '        gconnection.closeConnection()
                '    Else
                '        txt_BillNo.Text = "CSC/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                '        'txt_KOTno.Text = gPoSUsername & "/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                '        gdreader.Close()
                '        gcommand.Dispose()
                '        gconnection.closeConnection()
                '    End If
                'Else
                '    txt_BillNo.Text = "CSC/000001/" & financalyear
                '    'txt_KOTno.Text = gPoSUsername & "/000001/" & financalyear
                '    gdreader.Close()
                '    gcommand.Dispose()
                '    gconnection.closeConnection()
                'End If

                ''End
                'gdreader.Close()
                'gcommand.Dispose()
                'gconnection.closeConnection()

                'Billno = Nothing
                'Billno = Split(Trim(txt_BillNo.Text), "/")

                'If TaxApp = True Then
                '    Dim x, y As String
                '    taxbillno = Billno(1)
                '    taxbilldetails = Trim(Me.txt_BillNo.Text)
                '    If NoTax = True Then
                '        Billno(1) = Convert.ToString(Val(Billno(1)) + 1)
                '        Billno(1) = Format(Val(Billno(1)), "000000")
                '        x = Trim(Me.txt_BillNo.Text).Substring(4, 6)
                '        y = CStr(Val(x) + 1)
                '        nontaxbilldetails = Trim(Me.txt_BillNo.Text).Replace(x, Format(Val(y), "000000"))
                '        nontaxbillno = Billno(1)
                '    Else
                '        nontaxbilldetails = ""
                '        nontaxbillno = ""
                '    End If
                'Else
                '    taxbillno = ""
                '    taxbilldetails = ""
                '    nontaxbillno = Billno(1)
                '    nontaxbilldetails = Trim(Me.txt_BillNo.Text)
                'End If


                'COMMENT ON 02/05/2008
                'END

                If NoTaxDr.Length > 0 And Taxdr.Length > 0 Then
                    sqlstring = "Update PoSKotDoc Set DocNo = " & Val(nontaxbillno) & ",DOCFLAG='N' Where DocType = 'CSC'"
                ElseIf Taxdr.Length > 0 Then
                    sqlstring = "Update PoSKotDoc Set DocNo = " & Val(taxbillno) & " ,DOCFLAG='N' Where DocType = 'CSC'"
                ElseIf NoTaxDr.Length > 0 Then
                    sqlstring = "Update PoSKotDoc Set DocNo = " & Val(nontaxbillno) & " ,DOCFLAG='N' Where DocType = 'CSC'"
                Else
                    'Added on 20 May'08                    
                    'Kannan.M
                    'Begin
                    'Description :  Sometimes PosKotDoc table is not getting updated with Maximum Billno,
                    '               so to find out the problem and to update the current maximum billno, the
                    '               following coding has written
                    MsgBox("Thank You! Kindly Inform to Your System Admin about this Problem", MsgBoxStyle.Critical, "Info!")
                    Dim strBNo As String
                    sqlstring = "SELECT MAX(cast(SUBSTRING(BillNo,1,6) as numeric)) AS BillNo FROM BILL_hdr WHERE SUBSTRING(BILLDETAILS,1,3) = '" & Trim(BillPrefix) & "'"
                    gconnection.getDataSet(sqlstring, "MaxBNo")
                    If gdataset.Tables("MaxBNo").Rows.Count > 0 Then
                        strBNo = gdataset.Tables("MaxBNo").Rows(0).Item(0)
                        sqlstring = "Insert InTo DBS_Control(BillNo, NonTaxBillNo, TaxBillNo, UserName, AddDate) Values('" & strBNo & "','" & nontaxbilldetails & "','" & taxbilldetails & "','" & gUsername & "','" & Now.ToString & "')"
                        gconnection.dataOperation(6, sqlstring, "DBS_Control")
                        sqlstring = "Update PoSKotDoc Set DocNo = " & Val(strBNo) & ",DOCFLAG='N' Where DocType = 'CSC'"
                    End If
                    'End
                End If
                gconnection.dataOperation(7, sqlstring, "PosKotDoc")
                'gcommand.Dispose()
                'gconnection.closeConnection()

                'If Len(Oldtaxbillno) > 0 Then
                '    sqlstring = "Update BILL_HDR Set BILLNo = '" & taxbillno & "', BillDetails = '" & Trim(txt_BillNo.Text) & "' Where  BillDetails Like '" & Oldtaxbilldetails & "%'"
                '    gconnection.dataOperation(6, sqlstring, "BillHdr")
                '    sqlstring = "Update bill_DET Set billno = '" & taxbillno & "', billdetails = '" & Trim(txt_BillNo.Text) & "' Where  billdetails Like '" & Oldtaxbilldetails & "%'"
                '    gconnection.dataOperation(6, sqlstring, "KotDet")
                '    If Len(Oldnontaxbillno) > 0 Then
                '        sqlstring = "Update bill_DET Set othbilldetails = '" & nontaxbilldetails & "' Where  othbilldetails Like '" & Oldnontaxbilldetails & "%'"
                '        gconnection.dataOperation(6, sqlstring, "KotDet")
                '    End If

                '    sqlstring = "Update kot_det Set  BillDetails = '" & taxbilldetails & "' Where  BillDetails Like '" & Oldtaxbilldetails & "%'"
                '    gconnection.dataOperation(6, sqlstring, "BillHdr")
                'End If

                'If Len(Oldnontaxbillno) > 0 Then
                '    sqlstring = "Update BILL_HDR Set BILLNo = '" & nontaxbillno & "', BillDetails = '" & nontaxbilldetails & "' Where  BillDetails Like '" & Oldnontaxbilldetails & "%'"
                '    gconnection.dataOperation(6, sqlstring, "BillHdr")
                '    sqlstring = "Update bill_DET Set billno = '" & nontaxbillno & "', billdetails = '" & nontaxbilldetails & "' Where  billdetails Like '" & Oldnontaxbilldetails & "%'"
                '    gconnection.dataOperation(6, sqlstring, "KotDet")
                '    If Len(Oldtaxbillno) > 0 Then
                '        sqlstring = "Update bill_DET Set othbilldetails = '" & taxbilldetails & "' Where  othbilldetails Like '" & Oldtaxbilldetails & "%'"
                '        gconnection.dataOperation(6, sqlstring, "KotDet")
                '    End If

                '    sqlstring = "Update kot_det Set  BillDetails = '" & nontaxbilldetails & "' Where  BillDetails Like '" & Oldnontaxbilldetails & "%'"
                '    gconnection.dataOperation(6, sqlstring, "BillHdr")

                'End If



                ''============================================================================
                'If Len(Oldtaxbillno) > 0 Then

                ''**************************Inserting Data into ROOM LEDGER table **************************************

                If cbo_PaymentMode.SelectedItem = "ROOM" Then
                    If Len(Oldtaxbillno) > 0 Then
                        sqlstring = "INSERT INTO ROOMLEDGER(CHKNO,DOCNO,DOCDATE,DOCTYPE,FOLIONO,AMOUNT,POSCODE,"
                        sqlstring = sqlstring & "ROOMNO,REFNO,CREDITDEBIT,PAYMENTMODE,VOUCHERTYPE,VOUCHERCATEGORY,KOTNO)"
                        sqlstring = sqlstring & " Values('" & txt_MemberCode.Tag & "','" & Trim(CStr(taxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','SALES',1," & Math.Round(Val(ttotal) + Val(ttaxtotal)) & ","
                        sqlstring = sqlstring & "55," & Val(Me.txt_MemberCode.Text) & ",'" & txt_MemberCode.Tag & "','DEBIT','ROOM','RM','RM',1)"
                        gconnection.dataOperation(6, sqlstring, "ROOMLEDGER")
                    End If

                    If Len(Oldnontaxbillno) > 0 Then
                        sqlstring = "INSERT INTO ROOMLEDGER(CHKNO,DOCNO,DOCDATE,DOCTYPE,FOLIONO,AMOUNT,POSCODE,"
                        sqlstring = sqlstring & "ROOMNO,REFNO,CREDITDEBIT,PAYMENTMODE,VOUCHERTYPE,VOUCHERCATEGORY,KOTNO)"
                        sqlstring = sqlstring & " Values('" & txt_MemberCode.Tag & "','" & Trim(CStr(nontaxbilldetails)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','SALES',1," & Math.Round(Val(tntaxtotal) + Val(tntotal)) & ","
                        sqlstring = sqlstring & "55," & Val(Me.txt_MemberCode.Text) & ",'" & txt_MemberCode.Tag & "','DEBIT','ROOM','RM','RM',1)"
                        gconnection.dataOperation(1, sqlstring, "ROOMLEDGER")
                    End If
                End If


                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call Cmd_Print_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                Else
                    Call Cmd_Clear_Click(sender, e)
                End If


            ElseIf Mid(CStr(Cmd_AddNew.Text), 1, 1) = "U" Then
                '''******************************************* $ Find Out Paymentmode Accountcode and Subpaymentmode Accountcode $ *********************'''

                'Added on 18 Mar'08
                'Bill Matching Validation
                'Mk Kannan
                'Begin
                Dim dt As New DataTable
                sqlstring = "SELECT * FROM MATCHING WHERE VOUCHERNO = '" & Trim(txt_BillNo.Text) & "' AND VOUCHERDATE = '" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "'"
                dt = gconnection.GetValues(sqlstring)
                If (dt.Rows.Count > 0) Then
                    MsgBox("Sorry, Bill Matching Was Already Made, You Can't Update....")
                    Call Cmd_Clear_Click(Cmd_Clear, e)
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
                    Call Cmd_Clear_Click(Cmd_Clear, e)
                    Cmd_AddNew.Enabled = True
                    Exit Sub
                Else
                    If cbo_PaymentMode.SelectedItem = "ROOM" Then
                        sqlstring = "SELECT ISNULL(CHECKOUT,'N') AS CHECKOUT,ISNULL(ROOMNO,0)AS ROOMNO FROM Roomcheckin WHERE docno = " & Val(txt_MemberCode.Tag) & ""
                        gconnection.getDataSet(sqlstring, "Roomcheckin")
                        If gdataset.Tables("Roomcheckin").Rows.Count > 0 Then
                            If Trim(CStr(gdataset.Tables("Roomcheckin").Rows(0).Item("CHECKOUT"))) = "Y" Then
                                MessageBox.Show("Bill Can't be updated " & vbCrLf & " as GUEST  has been checkout from RoomNo" & ": " & gdataset.Tables("ROOMLEDGER").Rows(0).Item("ROOMNO"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                                Call Cmd_Clear_Click(Cmd_Clear, e)
                                Cmd_AddNew.Enabled = True
                                Exit Sub
                            End If
                        End If
                        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                        sqlstring = sqlstring & "Mcode='',Mname='',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=" & Val(Me.txt_MemberCode.Text) & ",ChkId=" & Val(Me.txt_MemberCode.Tag) & ",Guest='" & Trim(Me.txt_MemberName.Text) & "',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"


                    ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
                        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                        sqlstring = sqlstring & "Mcode='" & txt_MemberCode.Text & "',Mname='" & txt_MemberName.Text & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                        sqlstring = sqlstring & "Mcode='" & txt_MemberCode.Text & "',Mname='" & txt_MemberName.Text & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                        sqlstring = sqlstring & "Mcode='" & txt_MemberCode.Text & "',Mname='" & txt_MemberName.Text & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"
                        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "N.CREDIT" Then
                        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"
                        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    ElseIf cbo_PaymentMode.SelectedItem = "PARTY" Then
                        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"
                        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    Else
                        sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                        sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                        sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                        DELSQL = " DELETE FROM ROOMLEDGER WHERE DOCNO = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                        '=========================================
                        ''sqlstringRoom = "SELECT ISNULL(CHECKOUT,'N') AS CHECKOUT,ISNULL(ROOMNO,0)AS ROOMNO FROM Roomcheckin WHERE docno = " & Val(txt_MemberCode.Tag) & ""
                        ''gconnection.getDataSet(sqlstringRoom, "Roomcheckin")
                        ''If gdataset.Tables("Roomcheckin").Rows.Count > 0 Then
                        ''    If Trim(CStr(gdataset.Tables("Roomcheckin").Rows(0).Item("CHECKOUT"))) = "Y" Then
                        ''        'MessageBox.Show("Bill Can't be updated " & vbCrLf & " as GUEST  has been checkout from RoomNo" & ": " & gdataset.Tables("ROOMLEDGER").Rows(0).Item("ROOMNO"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        ''        MessageBox.Show("Bill Can't be updated  as GUEST  has been checked out from Room: ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        ''        Call Cmd_Clear_Click(Cmd_Clear, e)
                        ''        Cmd_AddNew.Enabled = True
                        ''        Exit Sub
                        ''    End If
                        ''End If
                        '=========================================
                    End If
                    Update1(0) = sqlstring
                    ReDim Preserve Update1(Update1.Length)
                    Update1(Update1.Length - 1) = DELSQL
                    '''************************************* FIND IF THAT PARTICULAR BILL HAVE OTHER BILL OR NOT *****************'''
                    sqlstring = "SELECT OthbillDetails FROM Bill_det WHERE Billdetails = '" & Trim(CStr(txt_BillNo.Text)) & "'"
                    gconnection.getDataSet(sqlstring, "Bill_det")
                    If gdataset.Tables("Bill_det").Rows.Count > 0 Then
                        Otherbillno = Trim(gdataset.Tables("Bill_det").Rows(0).Item("OthbillDetails") & "")
                        Otherbool = True
                    Else
                        Otherbool = False
                    End If
                    If Otherbool = True Then
                        If cbo_PaymentMode.SelectedItem = "ROOM" Then
                            sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                            sqlstring = sqlstring & "Mcode='',Mname='',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=" & Val(Me.txt_MemberCode.Text) & ",ChkId=" & Val(Me.txt_MemberCode.Tag) & ",Guest='" & Trim(Me.txt_MemberName.Text) & "',"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                        ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
                            sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                            sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                        ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                            sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                            sqlstring = sqlstring & "Mcode='" & txt_MemberCode.Text & "',Mname='" & txt_MemberName.Text & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                        ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                            sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                            sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                        ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                            sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"
                            sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                        ElseIf cbo_PaymentMode.SelectedItem = "N.CREDIT" Then
                            sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & "' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',"
                            sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                        Else
                            sqlstring = "UPDATE Bill_Hdr SET PayMentmode= '" & Trim(Me.cbo_PaymentMode.Text) & "' ,Paymentaccountcode= '" & Trim(paymentaccountcode) & " ' ,SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',"
                            sqlstring = sqlstring & "Mcode='" & Trim(Me.txt_MemberCode.Text) & "',Mname='" & Trim(Me.txt_MemberName.Text) & "',Scode='" & Trim(Me.txt_ServerCode.Text) & "',sname='" & Trim(Me.txt_ServerName.Text) & "',Roomno=0,ChkId=0,Guest='',"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',Remarks = '" & Trim(CStr(Txt_Remarks.Text)) & "' WHERE Billdetails = '" & Trim(CStr(Otherbillno)) & "'"
                            DELSQL = " DELETE FROM ROOMLEDGER WHERE DOCNO = '" & Trim(CStr(Otherbillno)) & "'"
                        End If
                        ReDim Preserve Update1(Update1.Length)
                        Update1(Update1.Length - 1) = sqlstring
                        ReDim Preserve Update1(Update1.Length)
                        Update1(Update1.Length - 1) = DELSQL
                    End If
                    '''************************************************************* COMPLETE UPDATE FOR OTHERBILL **************************
                    '''************************************************************* UPDATEING KOT_HDR  *************************************
                    If cbo_PaymentMode.SelectedItem = "ROOM" Then
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '' ,Mcode ='' ,Mname ='' ,STcode = '" & Trim(Me.txt_ServerCode.Text) & "',Servercode ='" & Trim(Me.txt_ServerCode.Text) & "' ,"
                            sqlstring = sqlstring & "Servername ='" & Trim(Me.txt_ServerName.Text) & "' ,Roomno='" & Trim(Me.txt_MemberCode.Text) & "',checkin='" & Trim(Me.txt_MemberCode.Tag) & "',"
                            sqlstring = sqlstring & "Guest='" & Trim(Me.txt_MemberName.Text) & "' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ' ,"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '' ,Mcode ='" & Trim(Me.txt_MemberCode.Text) & "' ,Mname ='" & Trim(txt_MemberName.Text) & "' ,STcode = '" & Trim(Me.txt_ServerCode.Text) & "',Servercode ='" & Trim(Me.txt_ServerCode.Text) & "' ,"
                            sqlstring = sqlstring & "Servername ='" & Trim(Me.txt_ServerName.Text) & "' ,roomno='' ,checkin='' ,"
                            sqlstring = sqlstring & "Guest='' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ' ,"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '" & txt_MemberCode.Text & "' ,Mcode ='" & txt_MemberCode.Text & "' ,Mname ='" & txt_MemberName.Text & "' ,STcode = '" & Trim(Me.txt_ServerCode.Text) & "',Servercode ='" & Trim(Me.txt_ServerCode.Text) & "' ,"
                            sqlstring = sqlstring & "Servername ='" & Trim(Me.txt_ServerName.Text) & "' ,roomno='' ,checkin='' ,"
                            sqlstring = sqlstring & "Guest='' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ' ,"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '' ,Mcode ='" & Trim(Me.txt_MemberCode.Text) & "' ,Mname ='" & Trim(txt_MemberName.Text) & "' ,STcode = '" & Trim(Me.txt_ServerCode.Text) & "',Servercode ='" & Trim(Me.txt_ServerCode.Text) & "' ,"
                            sqlstring = sqlstring & "Servername ='" & Trim(Me.txt_ServerName.Text) & "' ,roomno='' ,checkin='' ,"
                            sqlstring = sqlstring & "Guest='' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode ='" & Trim(paymentaccountcode) & " ' ,"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '" & Trim(txt_MemberCode.Text) & "' ,Mcode ='" & Trim(txt_MemberCode.Text) & "' ,Mname ='" & Trim(txt_MemberName.Text) & "' ,STcode = '" & Trim(Me.txt_ServerCode.Text) & "',Servercode ='" & Trim(Me.txt_ServerCode.Text) & "' ,"
                            sqlstring = sqlstring & "Servername ='" & Trim(Me.txt_ServerName.Text) & "' ,roomno='' ,checkin='' ,"
                            sqlstring = sqlstring & "Guest='' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode = 'SDRS',"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(txt_MemberCode.Text) & "',Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    Else
                        For i = 1 To ssGrid.DataRowCnt
                            sqlstring = "UPDATE  KOT_HDR SET Slcode = '" & Trim(txt_MemberCode.Text) & "' ,Mcode ='" & Trim(txt_MemberCode.Text) & "' ,Mname ='" & Trim(txt_MemberName.Text) & "' ,STcode = '" & Trim(Me.txt_ServerCode.Text) & "',Servercode ='" & Trim(Me.txt_ServerCode.Text) & "' ,"
                            sqlstring = sqlstring & "Servername ='" & Trim(Me.txt_ServerName.Text) & "' ,roomno='' ,checkin='' ,"
                            sqlstring = sqlstring & "Guest='' ,PaymentType ='" & Trim(cbo_PaymentMode.Text) & "' ,Paymodeaccountcode = '" & Trim(paymentaccountcode) & " ',"
                            sqlstring = sqlstring & "SubPaymentMode='" & Trim(SubpaymentMode(0)) & "',Subpaymentaccountcode='" & Trim(Subpaymentaccountcode) & " ',Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                            '''*********************************************************** UPDATING  KOT_DET ******************************************''''
                            sqlstring = "UPDATE  KOT_DET SET MCODE ='" & Trim(Me.txt_MemberCode.Text) & "' ,SCODE ='" & Trim(Me.txt_ServerCode.Text) & "', PAYMENTMODE = '" & Trim(cbo_PaymentMode.Text) & "'  ,"
                            sqlstring = sqlstring & "Upduserid='" & gUsername & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & "WHERE Kotdetails = '" & Trim(ssGrid.Text) & "'"
                            ReDim Preserve Update1(Update1.Length)
                            Update1(Update1.Length - 1) = sqlstring
                        Next i
                    End If
                    gconnection.MoreTransold(Update1)
                    Call Cmd_Clear_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Delete.Click
        'Added on 18 Mar'08
        'Mk Kannan
        'Begin
        Dim SQLSTRING, DELETE(0), STRKOTDETAILS As String
        Dim VCTR As Integer
        Dim dt As New DataTable
        Dim sql, Otherbillno, SSQL As String
        Dim otherbool As Boolean
        Dim vDocno
        Dim i As Integer


        SQLSTRING = "SELECT * FROM MATCHING WHERE VOUCHERNO = '" & Trim(txt_BillNo.Text) & "' AND VOUCHERDATE = '" & Format(dtp_BillDate.Value, "dd-MMM-yyyy") & "'"
        dt = gconnection.GetValues(SQLSTRING)
        If (dt.Rows.Count > 0) Then
            MsgBox("Sorry, Bill Matching Was Already Made, You Can't Delete....")
            Call Cmd_Clear_Click(Cmd_Clear, e)
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



        'SQLSTRING = "SELECT KOTDETAILS FROM KOT_DET WHERE BILLDETAILS='" & Trim(txt_BillNo.Text) & "'"
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
            ''==change on 03052008 Begin

            ''SQLSTRING = "UPDATE KOT_HDR SET "
            ''SQLSTRING = SQLSTRING & " BILLSTATUS ='PO',DELFLAG='Y' "
            ''SQLSTRING = SQLSTRING & " WHERE KOTDETAILS IN(" & Mid(Trim(STRKOTDETAILS), 1, Len(Trim(STRKOTDETAILS)) - 1) & ")"
            ''DELETE(0) = SQLSTRING
            SQLSTRING = "UPDATE KOT_HDR SET "
            SQLSTRING = SQLSTRING & " BILLSTATUS ='PO' "
            SQLSTRING = SQLSTRING & " WHERE KOTDETAILS IN(" & Mid(Trim(STRKOTDETAILS), 1, Len(Trim(STRKOTDETAILS)) - 1) & ")"
            DELETE(0) = SQLSTRING

            '''************************************** UPDATING KOT_DET
            ''SQLSTRING = "UPDATE KOT_DET SET "
            ''SQLSTRING = SQLSTRING & " BILLDETAILS ='',kotstatus='Y'"
            ''SQLSTRING = SQLSTRING & " WHERE KOTDETAILS IN(" & Mid(Trim(STRKOTDETAILS), 1, Len(Trim(STRKOTDETAILS)) - 1) & ")"
            ''ReDim Preserve DELETE(DELETE.Length)
            ''DELETE(DELETE.Length - 1) = SQLSTRING
            SQLSTRING = "UPDATE KOT_DET SET "
            SQLSTRING = SQLSTRING & " BILLDETAILS =''"
            SQLSTRING = SQLSTRING & " WHERE KOTDETAILS IN(" & Mid(Trim(STRKOTDETAILS), 1, Len(Trim(STRKOTDETAILS)) - 1) & ")"
            ReDim Preserve DELETE(DELETE.Length)
            DELETE(DELETE.Length - 1) = SQLSTRING

            ''==End

            '''************************************************* COMPLETE KOT_HDR ***************************************************'''
            '''************************************** Deleting KOTDETAILS Permently from KOT_DET ************************************'''
            'SQLSTRING = " UPDATE BILL_DET SET DELFLAG = 'Y' WHERE BILLDETAILS='" & Trim(CStr(Me.txt_BillNo.Text)) & "'"
            SQLSTRING = " UPDATE BILL_DET SET DELFLAG = 'Y' WHERE BILLDETAILS in ('" & Trim(BillDetails) & "'" & ")"

            ReDim Preserve DELETE(DELETE.Length)
            DELETE(DELETE.Length - 1) = SQLSTRING
            '''************************************************* COMPLETE KOT_HDR ***************************************************'''
            'SQLSTRING = " UPDATE BILL_HDR SET DELFLAG = 'Y' WHERE BILLDETAILS='" & Trim(CStr(Me.txt_BillNo.Text)) & "'"
            SQLSTRING = " UPDATE BILL_HDR SET DELFLAG = 'Y' WHERE BILLDETAILS in ('" & Trim(BillDetails) & "'" & ")"

            ReDim Preserve DELETE(DELETE.Length)
            DELETE(DELETE.Length - 1) = SQLSTRING
            'SQLSTRING = " UPDATE JOURNALENTRY SET VOID = 'Y' WHERE VOUCHERNO='" & Trim(CStr(Me.txt_BillNo.Text)) & "'"
            'SQLSTRING = " UPDATE JOURNALENTRY SET VOID = 'Y' WHERE VOUCHERNO in ('" & Trim(BillDetails) & "'" & ")"
            'ReDim Preserve DELETE(DELETE.Length)
            'DELETE(DELETE.Length - 1) = SQLSTRING
            'SQLSTRING = " UPDATE OUTSTANDING SET VOID = 'Y' WHERE VOUCHERNO='" & Trim(CStr(Me.txt_BillNo.Text)) & "'"
            'SQLSTRING = " UPDATE ROOMLEDGER SET "
            SQLSTRING = " UPDATE OUTSTANDING SET VOID = 'Y' WHERE VOUCHERNO in ('" & Trim(BillDetails) & "'" & ")"
            ReDim Preserve DELETE(DELETE.Length)
            DELETE(DELETE.Length - 1) = SQLSTRING


            ''================================Cancel at Roomledger==============================================
            SQLSTRING = "SELECT ISNULL(CHECKOUT,'N') AS CHECKOUT,ISNULL(ROOMNO,0)AS ROOMNO FROM Roomcheckin WHERE docno = " & Val(txt_MemberCode.Tag) & ""
            gconnection.getDataSet(SQLSTRING, "Roomcheckin")
            If gdataset.Tables("Roomcheckin").Rows.Count > 0 Then
                If Trim(CStr(gdataset.Tables("Roomcheckin").Rows(0).Item("CHECKOUT"))) = "Y" Then
                    MessageBox.Show("Bill Can't be updated " & vbCrLf & " as GUEST  has been checkout from RoomNo" & ": " & gdataset.Tables("ROOMcheckin").Rows(0).Item("ROOMNO"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Call Cmd_Clear_Click(Cmd_Clear, e)
                    Cmd_AddNew.Enabled = True
                    Exit Sub
                End If
            End If

            vDocno = getVoucherno("CANCEL", "GUEST ROOM")

            SSQL = "Select * From Roomledger where  Doctype = 'SALES' And Docno IN ('" & Trim(BillDetails) & "') and isnull(Cancel,'')<>'Y' "
            gconnection.getDataSet(SSQL, "ROOMLEDGER")
            If gdataset.Tables("RoomLedger").Rows.Count > 0 Then

                For i = 0 To gdataset.Tables("roomledger").Rows.Count - 1
                    SSQL = "Insert into RoomLedger(Chkno,Docno,DocDate,Doctype,poscode,Amount,Roomno,Refno,AddUserid,AddDatetime,Description,Creditdebit,foliono,Accountcode,slcode,Paymentmode,Angcode,Billhold,Checkout,Partyname,Vouchertype,Vouchercategory,Cancel,OldDocType)"
                    SSQL = SSQL & " values(" & Val(gdataset.Tables("RoomLedger").Rows(i).Item("chkno")) & ", " & vDocno & ",'" & Format(gdataset.Tables("RoomLedger").Rows(i).Item("DocDate"), "dd-MMM-yyyy") & "',"
                    SSQL = SSQL & "'CANCEL','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("PosCode")) & "'," & Val(gdataset.Tables("RoomLedger").Rows(i).Item("Amount") & "") & ","
                    SSQL = SSQL & " " & Val(gdataset.Tables("RoomLedger").Rows(i).Item("RoomNo") & "") & ",'" & Val(gdataset.Tables("RoomLedger").Rows(i).Item("Refno") & "") & "',"
                    SSQL = SSQL & " '" & Trim(gUsername & "") & "','" & Format(Now, "dd-MMM-yyyy") & "',"
                    SSQL = SSQL & " '" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("DocType") & "") & "CANCELLED - " & gdataset.Tables("RoomLedger").Rows(i).Item("docNo") & " dt." & Format(gdataset.Tables("RoomLedger").Rows(i).Item("Docdate"), "dd-MMM-yyyy") & "','Credit',1,'" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("Accountcode") & "") & "','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("slcode") & "") & "'"
                    SSQL = SSQL & ",'" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("Paymentmode") & "") & "','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("AngCode") & "") & "','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("BillHold") & "") & "','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("checkout") & "") & "','" & Trim(gdataset.Tables("RoomLedger").Rows(i).Item("Partyname") & "") & "','CANCEL','GUEST ROOM','Y','" & gdataset.Tables("RoomLedger").Rows(i).Item("DocType") & "')"

                    ReDim Preserve DELETE(DELETE.Length)
                    DELETE(DELETE.Length - 1) = SSQL

                    SSQL = " UPDATE ROOMLEDGER SET CANCEL='Y' WHERE CHKNO =" & Val(gdataset.Tables("RoomLedger").Rows(0).Item("chkno")) & " "
                    SSQL = SSQL & " AND DOCTYPE='SALES' AND DOCNO in ('" & Trim(BillDetails) & "')"

                    ReDim Preserve DELETE(DELETE.Length)
                    DELETE(DELETE.Length - 1) = SSQL
                Next
            End If

            ''=============================Updation of roomledger complete=========================================

            gconnection.MoreTransold(DELETE)
            MsgBox("Bill is Deleted Successfully!", MsgBoxStyle.OKOnly, "Info!")
            Call Cmd_Clear_Click(Cmd_Clear, e)
        Else
            MessageBox.Show("!! OOPS !! Bill Can't be deleted ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        'MessageBox.Show("!! OOPS !! Bill Can't be deleted ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        'Exit Sub
        'End
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        gPrint = False
        'Call billprint_new() '''---> Call Print Funtion
        Call BillPrintOperation_Alokesh()
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        'Call billprint_new() '''---> Call Print Funtion
        Call BillPrintOperation_Alokesh()
    End Sub

    Private Sub cbo_PaymentMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_PaymentMode.SelectedIndexChanged
        If cbo_PaymentMode.SelectedItem = "ROOM" Then
            txt_MemberCode.Visible = True
            txt_MemberName.Visible = True
            lbl_MemberCode.Visible = True
            lbl_MemberName.Visible = True
            cmd_MemberCodeHelp.Visible = True
            txt_MemberCode.Text = ""
            txt_MemberName.Text = ""
            lbl_MemberCode.Text = "ROOM NO.   :"
            lbl_MemberName.Text = "GUEST NAME :"
            'Modified on 15 Mar'08
            'Kannan
            'Begin
            'ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
            'txt_MemberCode.Visible = False
            'txt_MemberName.Visible = False
            'lbl_MemberCode.Visible = False
            'lbl_MemberName.Visible = False
            'cmd_MemberCodeHelp.Visible = False
            'ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
            'txt_MemberCode.Visible = False
            'txt_MemberName.Visible = False
            'lbl_MemberCode.Visible = False
            'lbl_MemberName.Visible = False
            'cmd_MemberCodeHelp.Visible = False
            'End
            'ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
            '    txt_MemberCode.Visible = False
            '    txt_MemberName.Visible = False
            '    lbl_MemberCode.Visible = False
            '    lbl_MemberName.Visible = False
            '    cmd_MemberCodeHelp.Visible = False
        Else
            'Modified on 15 Mar'09
            'Mk Kannan
            'Begin
            gSQLString = "Select Isnull(MemberStatus,'') as MemberStatus From PaymentModeMaster Where Isnull(Freeze,'') <> 'Y' and Isnull(PaymentCode,'') = '" & cbo_PaymentMode.Text & "'"
            gconnection.getDataSet(gSQLString, "PaymentModeMaster")
            If gdataset.Tables("PaymentModeMaster").Rows.Count > 0 Then
                If Trim(gdataset.Tables("PaymentModeMaster").Rows(0).Item(0)) = "YES" Then
                    txt_MemberCode.Visible = True
                    txt_MemberName.Visible = True
                    lbl_MemberCode.Visible = True
                    lbl_MemberName.Visible = True
                    cmd_MemberCodeHelp.Visible = True
                    '28/04/2008
                    'txt_MemberCode.Text = ""
                    'txt_MemberName.Text = ""
                    lbl_MemberCode.Text = "MEMBER CODE :"
                    lbl_MemberName.Text = "MEMBER NAME :"
                Else
                    txt_MemberCode.Visible = False
                    txt_MemberName.Visible = False
                    lbl_MemberCode.Visible = False
                    lbl_MemberName.Visible = False
                    cmd_MemberCodeHelp.Visible = False
                    '28/04/2008
                    'txt_MemberCode.Text = ""
                    'txt_MemberName.Text = ""
                End If
            End If
            'End
        End If
        Call FillSubPaymentMode(Me.cbo_PaymentMode.Text)
    End Sub

    Private Sub txt_BillNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_BillNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_BillNo.Text) = "" Then
                Call Cmd_Clear_Click(sender, e)
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
            If Me.cmd_MemberCodeHelp.Enabled = True Then
                Call cmd_MemberCodeHelp_Click(sender, e)
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
            If cbo_PaymentMode.Text = "ROOM" Then
                sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks FROM Kot_Hdr WHERE RoomNo='" & Trim(txt_MemberCode.Text) & "' AND "
                'Modified on 18 Mar'08
                'Mk Kannan
                'Begin
                'sqlstring = sqlstring & "ServerCode= '" & Trim(txt_ServerCode.Text) & "'  AND Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And PaymentType='ROOM' AND ISNULL(Manualbillstatus,'')<>'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' ORDER BY Kotdetails,Kotdate"
                sqlstring = sqlstring & "ServerCode= '" & Trim(txt_ServerCode.Text) & "'  AND Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' AND ISNULL(Manualbillstatus,'')<>'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "'"
                'End
            ElseIf cbo_PaymentMode.Text = "R.MEMBER" Then
                sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks FROM Kot_Hdr WHERE  Mcode='" & Trim(txt_MemberCode.Text) & "' AND "
                'Modified on 18 Mar'08
                'Mk Kannan
                'Begin
                'sqlstring = sqlstring & " ServerCode= '" & Trim(txt_ServerCode.Text) & "' AND Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And PaymentType='R.MEMBER' AND ISNULL(Manualbillstatus,'')<> 'Y'AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "
                sqlstring = sqlstring & " ServerCode= '" & Trim(txt_ServerCode.Text) & "' AND Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' AND ISNULL(Manualbillstatus,'')<> 'Y'AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "
                'End
            ElseIf cbo_PaymentMode.Text = "COUPON" Then
                sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks FROM Kot_Hdr WHERE  Mcode='" & Trim(txt_MemberCode.Text) & "' AND "
                'Modified on 18 Mar'08
                'Mk Kannan
                'Begin
                'sqlstring = sqlstring & " ServerCode= '" & Trim(txt_ServerCode.Text) & "' AND Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And PaymentType='COUPON' AND ISNULL(Manualbillstatus,'')<> 'Y'AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "
                sqlstring = sqlstring & " ServerCode= '" & Trim(txt_ServerCode.Text) & "' AND Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And ISNULL(Manualbillstatus,'')<> 'Y'AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "
                'End
            ElseIf cbo_PaymentMode.Text = "CLUB" Then
                sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks FROM Kot_Hdr WHERE  Mcode='" & Trim(txt_MemberCode.Text) & "' AND "
                'Modified on 18 Mar'08
                'Mk Kannan
                'Begin
                'sqlstring = sqlstring & " ServerCode= '" & Trim(txt_ServerCode.Text) & "' AND Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And PaymentType='CLUB' AND ISNULL(Manualbillstatus,'')<> 'Y'AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' ORDER BY Kotdetails,Kotdate"
                sqlstring = sqlstring & " ServerCode= '" & Trim(txt_ServerCode.Text) & "' AND Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And ISNULL(Manualbillstatus,'')<> 'Y'AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "
                'End
            Else
                'sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks FROM Kot_Hdr WHERE Mcode='" & Trim(txt_MemberCode.Text) & "'  or ROOMNO='" & Trim(txt_MemberCode.Text) & "' AND "
                sqlstring = "SELECT Kotdetails,Kotdate,BillAmount,BillStatus, Isnull(Remarks,'') as Remarks FROM Kot_Hdr WHERE Mcode='" & Trim(txt_MemberCode.Text) & "'   AND "
                'Modified on 18 Mar'08
                'Mk Kannan
                'Begin
                'sqlstring = sqlstring & "ServerCode= '" & Trim(txt_ServerCode.Text) & "' AND Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And PaymentType='" & Trim(Me.cbo_PaymentMode.Text) & "'  AND ISNULL(Manualbillstatus,'')<> 'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' ORDER BY Kotdetails,Kotdate"
                sqlstring = sqlstring & "ServerCode= '" & Trim(txt_ServerCode.Text) & "' AND Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And ISNULL(Manualbillstatus,'')<> 'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "
                'End
            End If
            'Modified on 21 Mar'08
            'Mk Kannan
            'Begin
            If Me.cbo_SubPaymentMode.Visible = True Then
                Subpaymentmode = Split(Trim(Me.cbo_SubPaymentMode.Text), "-")
                'sqlstring = sqlstring & " and SubPaymentMode='" & Trim(Subpaymentmode(0)) & "' "
            End If
            sqlstring = sqlstring & " ORDER BY Kotdetails,Kotdate"
            'End
            gconnection.getDataSet(sqlstring, "KOT_HDR")
            With ssGrid
                gconnection.getDataSet(sqlstring, "KOT_HDR1")
                If gdataset.Tables("KOT_HDR1").Rows.Count > 0 Then
                    Txt_Remarks.Text = Nothing
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
                        j = j + 1
                    Next
                    Me.txt_BillAmount.Text = Format(Val(Billtotal), "0.00")
                    .Focus()
                    .SetActiveCell(4, .ActiveRow)
                Else
                    MessageBox.Show("Plz enter a Valid Combination", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssGrid.ClearRange(-1, -1, 1, 1, True)
                    txt_ServerCode.Focus()
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub KOT_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KOT_Timer.Tick
        txt_KOTTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub txt_BillNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BillNo.Validated
        Try
            If Trim(txt_BillNo.Text) <> "" Then
                Call BillValidate(Trim(txt_BillNo.Text))
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
        other = False
        If Trim(billdetails) <> "" Then
            sqlstring = "SELECT ISNULL(B.BILLNO,'') AS BILLNO,ISNULL(B.BILLDETAILS,'') AS BILLDETAILS,ISNULL(OTHBILLDETAILS,'') AS OTHBILLDETAILS,"
            sqlstring = sqlstring & " B.BILLDATE AS BILLDATE,ISNULL(B.TOTALAMT,0) AS TOTALAMT,ISNULL(B.KOTDETAILS,'') AS KOTDETAILS,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.SCODE,'') AS SCODE, "
            sqlstring = sqlstring & " ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.SNAME,'') AS SNAME,H.BILLTIME AS BILLTIME,ISNULL(H.TOTALAMOUNT,0) AS TOTALAMOUNT,"
            sqlstring = sqlstring & " ISNULL(H.PAYMENTMODE,'') AS PAYMENTMODE,ISNULL(H.CROSTATUS,'') AS CROSTATUS,B.KOTDATE AS KOTDATE,ISNULL(H.GUEST,'') AS GUEST,"
            sqlstring = sqlstring & " ISNULL(H.ROOMNO,0) AS ROOMNO,ISNULL(H.CHKID,0) AS CHKID,ISNULL(H.SUBPAYMENTMODE,'') AS SUBPAYMENTMODE, ISNULL(H.DELFLAG,'') AS DELFLAG, ISNULL(H.REMARKS,'') AS REMARKS"
            sqlstring = sqlstring & " FROM BILL_HDR AS H INNER JOIN BILL_DET AS B ON H.BILLDETAILS = B.BILLDETAILS"
            sqlstring = sqlstring & " WHERE  B.BILLNO ='" & Format(Val(billdetails), "000000") & "' AND  SUBSTRING(B.BILLDETAILS,1,3) = '" & Trim(BillPrefix) & "' OR B.BILLDETAILS = '" & Trim(billdetails) & "' AND  SUBSTRING(B.BILLDETAILS,1,3) = '" & Trim(BillPrefix) & "'"
            ssGrid.ClearRange(1, 1, -1, -1, True)
            gconnection.getDataSet(sqlstring, "BILL_HDR")
            '''************************************************* SELECT record from KOT_HDR *********************************************''''                
            If gdataset.Tables("BILL_HDR").Rows.Count > 0 Then
                'Modified on 18 Mar'08
                'Mk Kannan
                'Begin
                If Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("DelFlag") & "") = "Y" Then
                    lblDeleted.Visible = True
                    Cmd_AddNew.Enabled = False
                    Cmd_Delete.Enabled = False
                Else
                    lblDeleted.Visible = False
                    Cmd_AddNew.Enabled = True
                    Cmd_Delete.Enabled = True
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


                Cmd_AddNew.Text = "Update[F7]"
                Me.txt_BillNo.ReadOnly = True
                Me.cmd_BillNoHelp.Enabled = False
                KOT_Timer.Enabled = False
                Call fillPayment_Mode()
                txt_BillNo.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Billdetails") & "")
                dtp_BillDate.Value = Format(CDate(gdataset.Tables("BILL_HDR").Rows(0).Item("BillDate")), "dd-MMM-yy")
                txt_KOTTime.Text = Format(CDate(gdataset.Tables("BILL_HDR").Rows(0).Item("BillTime")), "hh:mm:ss")
                txt_ServerCode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Scode") & "")
                txt_ServerName.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Sname") & "")
                txt_BillAmount.Text = Format(Val(gdataset.Tables("BILL_HDR").Rows(0).Item("TotalAmount") & ""), "0.00")
                cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDown
                cbo_PaymentMode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("PaymentMode") & "")

                'Modified on 18 Mar'08
                'Mk Kannan
                'Begin
                Txt_Remarks.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Remarks") & "")
                'End

                cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
                If gdataset.Tables("BILL_HDR").Rows(0).IsNull("CroStatus") = True Then
                    Me.Lbl_Bill.Visible = False
                    Cmd_AddNew.Enabled = True
                Else
                    If Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("CroStatus")) <> "N" Then
                        Me.Lbl_Bill.Text = "C R O G E N E R A T E D"
                        Me.Lbl_Bill.Visible = True
                        Cmd_AddNew.Enabled = False
                        Cmd_Delete.Enabled = False
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
                    sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CREDITNO,'') AS CREDITNO FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                    gconnection.getDataSet(sqlstring, "membermaster")
                    If gdataset.Tables("membermaster").Rows.Count > 0 Then
                        txt_creditfacility = gdataset.Tables("membermaster").Rows(0).Item("CREDITNO")
                    End If

                    'Modified on 18 Mar'08
                    'Mk Kannan
                    'Begin
                    txt_MemberCode.Tag = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("CHKID")) & ""
                Else
                    'Modified on 18 Mar'08
                    'Mk Kannan
                    'Begin
                    If Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("MCode")) & "" <> "" And Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Mname")) & "" <> "" Then
                        txt_MemberCode.Visible = True
                        txt_MemberName.Visible = True
                        lbl_MemberCode.Visible = True
                        lbl_MemberName.Visible = True
                        cmd_MemberCodeHelp.Visible = True
                        txt_MemberCode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("MCode")) & ""
                        txt_MemberName.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Mname")) & ""

                        sqlstring = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CREDITNO,'') AS CREDITNO FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                        gconnection.getDataSet(sqlstring, "membermaster")
                        If gdataset.Tables("membermaster").Rows.Count > 0 Then
                            txt_creditfacility = gdataset.Tables("membermaster").Rows(0).Item("CREDITNO")
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
                    'txt_MemberCode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("MCode")) & ""
                    'txt_MemberName.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("Mname")) & ""
                    'End
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
            Else
                txt_BillNo.Text = ""
                txt_BillNo.Focus()
            End If
        End If
    End Sub

    Private Sub Calculate()
        Dim Varchk As String
        Dim total As Double
        If Cmd_AddNew.Text = "Add [F7]" Then
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

    Private Sub cmd_BillNoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_BillNoHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT Billdetails,Convert(varchar, BillDate,100) FROM BILL_HDR"
        M_WhereCondition = " WHERE SUBSTRING(BILLDETAILS,1,3) = '" & Trim(BillPrefix) & "'"
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
            rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))

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
                ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                ''''''''''    ''$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                If Vrowcount = 0 Then
                    If headercount = 1 Then
                        'Initial heading printing
                        '========================
                        headercount = 2
                        Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & gCompanyname & Chr(20) & Chr(27) & Chr(72)
                        Filewrite.WriteLine(Rowprint)
                        '1
                        Vrowcount = Vrowcount + 1
                        Rowprint = Space(13) & gCompanyAddress(0)
                        Filewrite.WriteLine(Rowprint)
                        '2
                        Vrowcount = Vrowcount + 1
                        Rowprint = Space(13) & gCompanyAddress(1)
                        Filewrite.WriteLine(Rowprint)
                        '3
                        Vrowcount = Vrowcount + 1
                        ''======================================
                        If Format(Val(taxpercentage), "0.00") = "12.50" Then
                            Gheader = " TAX  INVOICE "
                        Else
                            Gheader = " CREDIT  MEMO "
                        End If
                        Filewrite.WriteLine("")
                        '4
                        Vrowcount = Vrowcount + 1
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
                        '5
                        Vrowcount = Vrowcount + 1
                        Rowprint = "SERVER  :"
                        Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE"))
                        Filewrite.Write(Rowprint)
                        Rowprint = "(" & Mid(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME"), 1, 25) & ")" & Space(30 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME") & "(" & gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME") & ")"), 1, 30))) & Chr(27) + "F" & Chr(15)
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
                        Rowprint = "SLNo  CODE  ITEM DESCRIPTION                      QUANTITY   RATE   AMOUNT  "
                        Filewrite.WriteLine(Rowprint & Chr(15))
                        '8
                        Vrowcount = Vrowcount + 1
                        For i = 0 To 78
                            Filewrite.Write("-")
                        Next
                        Filewrite.WriteLine()
                        '9
                        Vrowcount = Vrowcount + 1
                    End If
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
            If Vrowcount <= 32 Then
                For i = 1 To 17 - Vrowcount
                    Filewrite.WriteLine("")
                Next
            End If

            'Vrowcount = 0
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

            If Vrowcount <= 32 Then
                For i = 1 To 10
                    Filewrite.WriteLine("")
                Next
            End If
            If Vrowcount > 32 Then
                For i = 1 To 77 - Vrowcount
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
        txt_BillAmount.Text = Format(Val(txt_BillAmount.Text), "0.00")
    End Sub

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
        Dim Row, Col As Integer
        ssgridPayment.Col = 6
        ssgridPayment.Row = ssgridPayment.ActiveRow
        For Row = 1 To 20
            For Col = 3 To 4
                ssgridPayment.Row = Row
                ssgridPayment.Col = Col
                ssgridPayment.Lock = True
            Next
        Next Row
        ssgridPayment.Row = 1
        For Col = 3 To 4
            ssgridPayment.Col = Col
            ssgridPayment.Lock = False
        Next
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
            If Mid(CStr(Cmd_AddNew.Text), 1, 1) = "A" Then
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
        Dim Sqlstring As String
        Sqlstring = "SELECT ISNULL(BillPaymentMode,'') AS BillPaymentMode FROM POSSETUP"
        gconnection.getDataSet(Sqlstring, "POSSETUP")
        If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
            DefaultPayment = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPaymentMode"))
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
        Call Cmd_Clear_Click(sender, e)

    End Sub


    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
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
End Class