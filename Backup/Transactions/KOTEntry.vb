Imports System.Data.SqlClient
Imports System.IO
Public Class KOTEntry
    Inherits System.Windows.Forms.Form
    Public billno As String
#Region " Windows Form Designer generated code "

    Public Sub New(ByVal billdetails As String)
        MyBase.New()
        billno = billdetails
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
    Friend WithEvents cbo_PaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_PaymentMode As System.Windows.Forms.Label
    Friend WithEvents lbl_Exemption As System.Windows.Forms.Label
    Friend WithEvents txt_Exemption As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ServerName As System.Windows.Forms.Label
    Friend WithEvents cmd_ServerCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_ServerName As System.Windows.Forms.TextBox
    Friend WithEvents txt_ServerCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Servercode As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberName As System.Windows.Forms.Label
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Membercode As System.Windows.Forms.Label
    Friend WithEvents lbl_BillAmount As System.Windows.Forms.Label
    Friend WithEvents txt_BillAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt_TaxValue As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TaxValue As System.Windows.Forms.Label
    Friend WithEvents txt_TotalValue As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TotalValue As System.Windows.Forms.Label
    Friend WithEvents lbl_KOTdate As System.Windows.Forms.Label
    Friend WithEvents lbl_KOTno As System.Windows.Forms.Label
    Friend WithEvents lbl_Covers As System.Windows.Forms.Label
    Friend WithEvents txt_Cover As System.Windows.Forms.TextBox
    Friend WithEvents cmd_TablenoHelp As System.Windows.Forms.Button
    Friend WithEvents txt_TableNo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Tableno As System.Windows.Forms.Label
    Friend WithEvents cmd_RoomQuery As System.Windows.Forms.Button
    Friend WithEvents cmd_LocalSetting As System.Windows.Forms.Button
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents dtp_KOTdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp_ssgrid As System.Windows.Forms.GroupBox
    Friend WithEvents grp_Memberdetails As System.Windows.Forms.GroupBox
    Friend WithEvents grp_KOTdetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_KOTnoHelp As System.Windows.Forms.Button
    Friend WithEvents grp_Tabledetails As System.Windows.Forms.GroupBox
    Friend WithEvents txt_KOTno As System.Windows.Forms.TextBox
    Friend WithEvents grp_Itemdetails As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Itemdetails As System.Windows.Forms.Label
    Friend WithEvents ssgrid_Itemdetails As AxFPSpreadADO.AxfpSpread
    Friend WithEvents txt_KOTTime As System.Windows.Forms.TextBox
    Friend WithEvents KOT_Timer As System.Windows.Forms.Timer
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents pnl_POSCode As System.Windows.Forms.Panel
    Friend WithEvents pnl_UOMCode As System.Windows.Forms.Panel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvw_Uom As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lbl_Bill As System.Windows.Forms.Label
    Friend WithEvents cbo_SubPaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_SubPaymentMode As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents Txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblBillno1 As System.Windows.Forms.Label
    Friend WithEvents lblBillno2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lvw_POSCode As System.Windows.Forms.ListView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_LOCATIONCODE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_LOCATIONNAME As System.Windows.Forms.TextBox
    Friend WithEvents CMD_LOCHELP As System.Windows.Forms.Button
    Friend WithEvents lab_outstanding As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CMB_BTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Pic_Member As System.Windows.Forms.PictureBox
    Friend WithEvents txt_card_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_SwipeCard As System.Windows.Forms.Button
    Friend WithEvents txt_lastbillamount As System.Windows.Forms.TextBox
    Friend WithEvents txt_lostcardcode As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_DC_Update As System.Windows.Forms.Button
    Friend WithEvents Txt_holder_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_Holder_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CHK_PRINT As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer_Delay As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_ShowBill As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LAB_CARDBAL As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(KOTEntry))
        Me.grp_ssgrid = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.grp_Memberdetails = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Txt_holder_name = New System.Windows.Forms.TextBox
        Me.txt_Holder_Code = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXT_LOCATIONNAME = New System.Windows.Forms.TextBox
        Me.CMD_LOCHELP = New System.Windows.Forms.Button
        Me.txt_LOCATIONCODE = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_ServerName = New System.Windows.Forms.TextBox
        Me.cbo_PaymentMode = New System.Windows.Forms.ComboBox
        Me.lbl_PaymentMode = New System.Windows.Forms.Label
        Me.lbl_Exemption = New System.Windows.Forms.Label
        Me.txt_Exemption = New System.Windows.Forms.TextBox
        Me.lbl_ServerName = New System.Windows.Forms.Label
        Me.cmd_ServerCodeHelp = New System.Windows.Forms.Button
        Me.txt_ServerCode = New System.Windows.Forms.TextBox
        Me.lbl_Servercode = New System.Windows.Forms.Label
        Me.lbl_MemberName = New System.Windows.Forms.Label
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.txt_MemberName = New System.Windows.Forms.TextBox
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.lbl_Membercode = New System.Windows.Forms.Label
        Me.lbl_BillAmount = New System.Windows.Forms.Label
        Me.txt_BillAmount = New System.Windows.Forms.TextBox
        Me.txt_TaxValue = New System.Windows.Forms.TextBox
        Me.lbl_TaxValue = New System.Windows.Forms.Label
        Me.txt_TotalValue = New System.Windows.Forms.TextBox
        Me.lbl_TotalValue = New System.Windows.Forms.Label
        Me.grp_KOTdetails = New System.Windows.Forms.GroupBox
        Me.Pic_Member = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmd_KOTnoHelp = New System.Windows.Forms.Button
        Me.txt_KOTno = New System.Windows.Forms.TextBox
        Me.lbl_KOTdate = New System.Windows.Forms.Label
        Me.lbl_KOTno = New System.Windows.Forms.Label
        Me.grp_Tabledetails = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CMB_BTYPE = New System.Windows.Forms.ComboBox
        Me.cmd_TablenoHelp = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_Covers = New System.Windows.Forms.Label
        Me.txt_Cover = New System.Windows.Forms.TextBox
        Me.txt_TableNo = New System.Windows.Forms.TextBox
        Me.lbl_Tableno = New System.Windows.Forms.Label
        Me.cmd_RoomQuery = New System.Windows.Forms.Button
        Me.cmd_LocalSetting = New System.Windows.Forms.Button
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.dtp_KOTdate = New System.Windows.Forms.DateTimePicker
        Me.grp_Itemdetails = New System.Windows.Forms.GroupBox
        Me.ssgrid_Itemdetails = New AxFPSpreadADO.AxfpSpread
        Me.lbl_Itemdetails = New System.Windows.Forms.Label
        Me.txt_KOTTime = New System.Windows.Forms.TextBox
        Me.KOT_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.pnl_POSCode = New System.Windows.Forms.Panel
        Me.lvw_POSCode = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.pnl_UOMCode = New System.Windows.Forms.Panel
        Me.lvw_Uom = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Lbl_Bill = New System.Windows.Forms.Label
        Me.cbo_SubPaymentMode = New System.Windows.Forms.ComboBox
        Me.lbl_SubPaymentMode = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PictureBox7 = New System.Windows.Forms.PictureBox
        Me.PictureBox6 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.Txt_Remarks = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblBillno1 = New System.Windows.Forms.Label
        Me.lblBillno2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lab_outstanding = New System.Windows.Forms.Label
        Me.txt_card_id = New System.Windows.Forms.TextBox
        Me.lbl_SwipeCard = New System.Windows.Forms.Button
        Me.txt_lastbillamount = New System.Windows.Forms.TextBox
        Me.txt_lostcardcode = New System.Windows.Forms.TextBox
        Me.Cmd_DC_Update = New System.Windows.Forms.Button
        Me.CHK_PRINT = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Delay = New System.Windows.Forms.Timer(Me.components)
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.cmd_View = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_ShowBill = New System.Windows.Forms.Button
        Me.LAB_CARDBAL = New System.Windows.Forms.Label
        Me.grp_Memberdetails.SuspendLayout()
        Me.grp_KOTdetails.SuspendLayout()
        Me.grp_Tabledetails.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Itemdetails.SuspendLayout()
        CType(Me.ssgrid_Itemdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_POSCode.SuspendLayout()
        Me.pnl_UOMCode.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_ssgrid
        '
        Me.grp_ssgrid.BackColor = System.Drawing.Color.Transparent
        Me.grp_ssgrid.Location = New System.Drawing.Point(72, 328)
        Me.grp_ssgrid.Name = "grp_ssgrid"
        Me.grp_ssgrid.Size = New System.Drawing.Size(880, 208)
        Me.grp_ssgrid.TabIndex = 22
        Me.grp_ssgrid.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(432, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(176, 35)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "KOT ENTRY"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_Memberdetails
        '
        Me.grp_Memberdetails.BackColor = System.Drawing.Color.Transparent
        Me.grp_Memberdetails.Controls.Add(Me.Label9)
        Me.grp_Memberdetails.Controls.Add(Me.Txt_holder_name)
        Me.grp_Memberdetails.Controls.Add(Me.txt_Holder_Code)
        Me.grp_Memberdetails.Controls.Add(Me.Label8)
        Me.grp_Memberdetails.Controls.Add(Me.TXT_LOCATIONNAME)
        Me.grp_Memberdetails.Controls.Add(Me.CMD_LOCHELP)
        Me.grp_Memberdetails.Controls.Add(Me.txt_LOCATIONCODE)
        Me.grp_Memberdetails.Controls.Add(Me.Label5)
        Me.grp_Memberdetails.Controls.Add(Me.Label6)
        Me.grp_Memberdetails.Controls.Add(Me.txt_ServerName)
        Me.grp_Memberdetails.Location = New System.Drawing.Point(72, 137)
        Me.grp_Memberdetails.Name = "grp_Memberdetails"
        Me.grp_Memberdetails.Size = New System.Drawing.Size(880, 192)
        Me.grp_Memberdetails.TabIndex = 12
        Me.grp_Memberdetails.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(445, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(207, 25)
        Me.Label9.TabIndex = 605
        Me.Label9.Text = "CARD HOLDER NAME"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_holder_name
        '
        Me.Txt_holder_name.BackColor = System.Drawing.Color.Wheat
        Me.Txt_holder_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_holder_name.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_holder_name.Location = New System.Drawing.Point(656, 80)
        Me.Txt_holder_name.MaxLength = 50
        Me.Txt_holder_name.Name = "Txt_holder_name"
        Me.Txt_holder_name.ReadOnly = True
        Me.Txt_holder_name.Size = New System.Drawing.Size(200, 29)
        Me.Txt_holder_name.TabIndex = 603
        Me.Txt_holder_name.Text = ""
        '
        'txt_Holder_Code
        '
        Me.txt_Holder_Code.BackColor = System.Drawing.Color.Wheat
        Me.txt_Holder_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Holder_Code.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Holder_Code.Location = New System.Drawing.Point(224, 80)
        Me.txt_Holder_Code.MaxLength = 15
        Me.txt_Holder_Code.Name = "txt_Holder_Code"
        Me.txt_Holder_Code.ReadOnly = True
        Me.txt_Holder_Code.Size = New System.Drawing.Size(168, 29)
        Me.txt_Holder_Code.TabIndex = 602
        Me.txt_Holder_Code.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(17, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 25)
        Me.Label8.TabIndex = 604
        Me.Label8.Text = "CARD HOLDER CODE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_LOCATIONNAME
        '
        Me.TXT_LOCATIONNAME.BackColor = System.Drawing.Color.Wheat
        Me.TXT_LOCATIONNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_LOCATIONNAME.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_LOCATIONNAME.Location = New System.Drawing.Point(656, 153)
        Me.TXT_LOCATIONNAME.MaxLength = 50
        Me.TXT_LOCATIONNAME.Name = "TXT_LOCATIONNAME"
        Me.TXT_LOCATIONNAME.ReadOnly = True
        Me.TXT_LOCATIONNAME.Size = New System.Drawing.Size(200, 29)
        Me.TXT_LOCATIONNAME.TabIndex = 21
        Me.TXT_LOCATIONNAME.Text = ""
        '
        'CMD_LOCHELP
        '
        Me.CMD_LOCHELP.Enabled = False
        Me.CMD_LOCHELP.Image = CType(resources.GetObject("CMD_LOCHELP.Image"), System.Drawing.Image)
        Me.CMD_LOCHELP.Location = New System.Drawing.Point(392, 155)
        Me.CMD_LOCHELP.Name = "CMD_LOCHELP"
        Me.CMD_LOCHELP.Size = New System.Drawing.Size(23, 29)
        Me.CMD_LOCHELP.TabIndex = 18
        '
        'txt_LOCATIONCODE
        '
        Me.txt_LOCATIONCODE.BackColor = System.Drawing.Color.Wheat
        Me.txt_LOCATIONCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_LOCATIONCODE.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LOCATIONCODE.Location = New System.Drawing.Point(224, 154)
        Me.txt_LOCATIONCODE.MaxLength = 15
        Me.txt_LOCATIONCODE.Name = "txt_LOCATIONCODE"
        Me.txt_LOCATIONCODE.Size = New System.Drawing.Size(168, 29)
        Me.txt_LOCATIONCODE.TabIndex = 16
        Me.txt_LOCATIONCODE.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(52, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "LOCATION CODE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(494, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 25)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "WAITER NAME "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_ServerName
        '
        Me.txt_ServerName.BackColor = System.Drawing.Color.Wheat
        Me.txt_ServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerName.Location = New System.Drawing.Point(656, 117)
        Me.txt_ServerName.MaxLength = 50
        Me.txt_ServerName.Name = "txt_ServerName"
        Me.txt_ServerName.ReadOnly = True
        Me.txt_ServerName.Size = New System.Drawing.Size(200, 29)
        Me.txt_ServerName.TabIndex = 5
        Me.txt_ServerName.Text = ""
        '
        'cbo_PaymentMode
        '
        Me.cbo_PaymentMode.BackColor = System.Drawing.Color.Wheat
        Me.cbo_PaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_PaymentMode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_PaymentMode.Location = New System.Drawing.Point(296, 144)
        Me.cbo_PaymentMode.Name = "cbo_PaymentMode"
        Me.cbo_PaymentMode.Size = New System.Drawing.Size(168, 30)
        Me.cbo_PaymentMode.TabIndex = 0
        '
        'lbl_PaymentMode
        '
        Me.lbl_PaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PaymentMode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PaymentMode.ForeColor = System.Drawing.Color.Black
        Me.lbl_PaymentMode.Location = New System.Drawing.Point(122, 147)
        Me.lbl_PaymentMode.Name = "lbl_PaymentMode"
        Me.lbl_PaymentMode.Size = New System.Drawing.Size(171, 25)
        Me.lbl_PaymentMode.TabIndex = 13
        Me.lbl_PaymentMode.Text = "PAYMENT MODE "
        Me.lbl_PaymentMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Exemption
        '
        Me.lbl_Exemption.AutoSize = True
        Me.lbl_Exemption.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Exemption.Location = New System.Drawing.Point(16, 5000)
        Me.lbl_Exemption.Name = "lbl_Exemption"
        Me.lbl_Exemption.Size = New System.Drawing.Size(95, 19)
        Me.lbl_Exemption.TabIndex = 26
        Me.lbl_Exemption.Text = "Exemption :"
        '
        'txt_Exemption
        '
        Me.txt_Exemption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Exemption.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Exemption.Location = New System.Drawing.Point(112, 5000)
        Me.txt_Exemption.MaxLength = 50
        Me.txt_Exemption.Name = "txt_Exemption"
        Me.txt_Exemption.Size = New System.Drawing.Size(72, 21)
        Me.txt_Exemption.TabIndex = 5
        Me.txt_Exemption.Text = ""
        '
        'lbl_ServerName
        '
        Me.lbl_ServerName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ServerName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ServerName.ForeColor = System.Drawing.Color.Black
        Me.lbl_ServerName.Location = New System.Drawing.Point(543, 292)
        Me.lbl_ServerName.Name = "lbl_ServerName"
        Me.lbl_ServerName.Size = New System.Drawing.Size(183, 25)
        Me.lbl_ServerName.TabIndex = 20
        Me.lbl_ServerName.Text = "LOCATION NAME"
        Me.lbl_ServerName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmd_ServerCodeHelp
        '
        Me.cmd_ServerCodeHelp.Image = CType(resources.GetObject("cmd_ServerCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_ServerCodeHelp.Location = New System.Drawing.Point(464, 256)
        Me.cmd_ServerCodeHelp.Name = "cmd_ServerCodeHelp"
        Me.cmd_ServerCodeHelp.Size = New System.Drawing.Size(23, 29)
        Me.cmd_ServerCodeHelp.TabIndex = 17
        '
        'txt_ServerCode
        '
        Me.txt_ServerCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_ServerCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerCode.Location = New System.Drawing.Point(296, 255)
        Me.txt_ServerCode.MaxLength = 15
        Me.txt_ServerCode.Name = "txt_ServerCode"
        Me.txt_ServerCode.Size = New System.Drawing.Size(168, 29)
        Me.txt_ServerCode.TabIndex = 4
        Me.txt_ServerCode.Text = ""
        '
        'lbl_Servercode
        '
        Me.lbl_Servercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Servercode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Servercode.ForeColor = System.Drawing.Color.Black
        Me.lbl_Servercode.Location = New System.Drawing.Point(136, 259)
        Me.lbl_Servercode.Name = "lbl_Servercode"
        Me.lbl_Servercode.Size = New System.Drawing.Size(160, 25)
        Me.lbl_Servercode.TabIndex = 15
        Me.lbl_Servercode.Text = "WAITER CODE "
        Me.lbl_Servercode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_MemberName
        '
        Me.lbl_MemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberName.ForeColor = System.Drawing.Color.Black
        Me.lbl_MemberName.Location = New System.Drawing.Point(564, 185)
        Me.lbl_MemberName.Name = "lbl_MemberName"
        Me.lbl_MemberName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_MemberName.TabIndex = 19
        Me.lbl_MemberName.Text = "MEMBER NAME "
        Me.lbl_MemberName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(464, 181)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(23, 29)
        Me.cmd_MemberCodeHelp.TabIndex = 16
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BackColor = System.Drawing.Color.Wheat
        Me.txt_MemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(728, 182)
        Me.txt_MemberName.MaxLength = 50
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.ReadOnly = True
        Me.txt_MemberName.Size = New System.Drawing.Size(200, 29)
        Me.txt_MemberName.TabIndex = 3
        Me.txt_MemberName.Text = ""
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(296, 181)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(168, 29)
        Me.txt_MemberCode.TabIndex = 2
        Me.txt_MemberCode.Text = ""
        '
        'lbl_Membercode
        '
        Me.lbl_Membercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Membercode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Membercode.ForeColor = System.Drawing.Color.Black
        Me.lbl_Membercode.Location = New System.Drawing.Point(136, 182)
        Me.lbl_Membercode.Name = "lbl_Membercode"
        Me.lbl_Membercode.Size = New System.Drawing.Size(160, 25)
        Me.lbl_Membercode.TabIndex = 14
        Me.lbl_Membercode.Text = "MEMBER CODE "
        Me.lbl_Membercode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_BillAmount
        '
        Me.lbl_BillAmount.AutoSize = True
        Me.lbl_BillAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillAmount.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillAmount.ForeColor = System.Drawing.Color.Black
        Me.lbl_BillAmount.Location = New System.Drawing.Point(576, 587)
        Me.lbl_BillAmount.Name = "lbl_BillAmount"
        Me.lbl_BillAmount.Size = New System.Drawing.Size(148, 25)
        Me.lbl_BillAmount.TabIndex = 27
        Me.lbl_BillAmount.Text = "BILL AMOUNT "
        '
        'txt_BillAmount
        '
        Me.txt_BillAmount.BackColor = System.Drawing.Color.Wheat
        Me.txt_BillAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BillAmount.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BillAmount.Location = New System.Drawing.Point(712, 587)
        Me.txt_BillAmount.Name = "txt_BillAmount"
        Me.txt_BillAmount.Size = New System.Drawing.Size(240, 29)
        Me.txt_BillAmount.TabIndex = 28
        Me.txt_BillAmount.Text = ""
        Me.txt_BillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TaxValue
        '
        Me.txt_TaxValue.BackColor = System.Drawing.Color.Wheat
        Me.txt_TaxValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TaxValue.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TaxValue.Location = New System.Drawing.Point(880, 549)
        Me.txt_TaxValue.Name = "txt_TaxValue"
        Me.txt_TaxValue.Size = New System.Drawing.Size(72, 29)
        Me.txt_TaxValue.TabIndex = 26
        Me.txt_TaxValue.Text = ""
        Me.txt_TaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_TaxValue
        '
        Me.lbl_TaxValue.AutoSize = True
        Me.lbl_TaxValue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TaxValue.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TaxValue.ForeColor = System.Drawing.Color.Black
        Me.lbl_TaxValue.Location = New System.Drawing.Point(784, 552)
        Me.lbl_TaxValue.Name = "lbl_TaxValue"
        Me.lbl_TaxValue.Size = New System.Drawing.Size(105, 22)
        Me.lbl_TaxValue.TabIndex = 25
        Me.lbl_TaxValue.Text = "TAX VALUE "
        '
        'txt_TotalValue
        '
        Me.txt_TotalValue.BackColor = System.Drawing.Color.Wheat
        Me.txt_TotalValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TotalValue.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalValue.Location = New System.Drawing.Point(712, 549)
        Me.txt_TotalValue.Name = "txt_TotalValue"
        Me.txt_TotalValue.Size = New System.Drawing.Size(72, 29)
        Me.txt_TotalValue.TabIndex = 24
        Me.txt_TotalValue.Text = ""
        Me.txt_TotalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_TotalValue
        '
        Me.lbl_TotalValue.AutoSize = True
        Me.lbl_TotalValue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TotalValue.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TotalValue.ForeColor = System.Drawing.Color.Black
        Me.lbl_TotalValue.Location = New System.Drawing.Point(576, 552)
        Me.lbl_TotalValue.Name = "lbl_TotalValue"
        Me.lbl_TotalValue.Size = New System.Drawing.Size(148, 25)
        Me.lbl_TotalValue.TabIndex = 23
        Me.lbl_TotalValue.Text = "TOTAL VALUE "
        '
        'grp_KOTdetails
        '
        Me.grp_KOTdetails.BackColor = System.Drawing.Color.Transparent
        Me.grp_KOTdetails.Controls.Add(Me.Pic_Member)
        Me.grp_KOTdetails.Controls.Add(Me.PictureBox1)
        Me.grp_KOTdetails.Location = New System.Drawing.Point(488, 56)
        Me.grp_KOTdetails.Name = "grp_KOTdetails"
        Me.grp_KOTdetails.Size = New System.Drawing.Size(464, 88)
        Me.grp_KOTdetails.TabIndex = 38
        Me.grp_KOTdetails.TabStop = False
        '
        'Pic_Member
        '
        Me.Pic_Member.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic_Member.Location = New System.Drawing.Point(382, 6)
        Me.Pic_Member.Name = "Pic_Member"
        Me.Pic_Member.Size = New System.Drawing.Size(72, 80)
        Me.Pic_Member.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Member.TabIndex = 591
        Me.Pic_Member.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(176, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'cmd_KOTnoHelp
        '
        Me.cmd_KOTnoHelp.Image = CType(resources.GetObject("cmd_KOTnoHelp.Image"), System.Drawing.Image)
        Me.cmd_KOTnoHelp.Location = New System.Drawing.Point(848, 64)
        Me.cmd_KOTnoHelp.Name = "cmd_KOTnoHelp"
        Me.cmd_KOTnoHelp.Size = New System.Drawing.Size(23, 32)
        Me.cmd_KOTnoHelp.TabIndex = 9
        '
        'txt_KOTno
        '
        Me.txt_KOTno.BackColor = System.Drawing.Color.Wheat
        Me.txt_KOTno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_KOTno.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_KOTno.ForeColor = System.Drawing.Color.Blue
        Me.txt_KOTno.Location = New System.Drawing.Point(680, 64)
        Me.txt_KOTno.MaxLength = 17
        Me.txt_KOTno.Name = "txt_KOTno"
        Me.txt_KOTno.Size = New System.Drawing.Size(168, 32)
        Me.txt_KOTno.TabIndex = 8
        Me.txt_KOTno.Text = ""
        '
        'lbl_KOTdate
        '
        Me.lbl_KOTdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_KOTdate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_KOTdate.ForeColor = System.Drawing.Color.Black
        Me.lbl_KOTdate.Location = New System.Drawing.Point(552, 104)
        Me.lbl_KOTdate.Name = "lbl_KOTdate"
        Me.lbl_KOTdate.Size = New System.Drawing.Size(124, 25)
        Me.lbl_KOTdate.TabIndex = 40
        Me.lbl_KOTdate.Text = "KOT DATE "
        Me.lbl_KOTdate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_KOTno
        '
        Me.lbl_KOTno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_KOTno.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_KOTno.ForeColor = System.Drawing.Color.Black
        Me.lbl_KOTno.Location = New System.Drawing.Point(528, 64)
        Me.lbl_KOTno.Name = "lbl_KOTno"
        Me.lbl_KOTno.Size = New System.Drawing.Size(148, 25)
        Me.lbl_KOTno.TabIndex = 39
        Me.lbl_KOTno.Text = "KOT NUMBER "
        Me.lbl_KOTno.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'grp_Tabledetails
        '
        Me.grp_Tabledetails.BackColor = System.Drawing.Color.Transparent
        Me.grp_Tabledetails.Controls.Add(Me.Label10)
        Me.grp_Tabledetails.Controls.Add(Me.CMB_BTYPE)
        Me.grp_Tabledetails.Controls.Add(Me.cmd_TablenoHelp)
        Me.grp_Tabledetails.Controls.Add(Me.Label7)
        Me.grp_Tabledetails.Location = New System.Drawing.Point(72, 56)
        Me.grp_Tabledetails.Name = "grp_Tabledetails"
        Me.grp_Tabledetails.Size = New System.Drawing.Size(416, 88)
        Me.grp_Tabledetails.TabIndex = 34
        Me.grp_Tabledetails.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(96, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 25)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "FLASH CARD"
        '
        'CMB_BTYPE
        '
        Me.CMB_BTYPE.BackColor = System.Drawing.Color.Wheat
        Me.CMB_BTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_BTYPE.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_BTYPE.Location = New System.Drawing.Point(224, 48)
        Me.CMB_BTYPE.Name = "CMB_BTYPE"
        Me.CMB_BTYPE.Size = New System.Drawing.Size(168, 30)
        Me.CMB_BTYPE.TabIndex = 38
        '
        'cmd_TablenoHelp
        '
        Me.cmd_TablenoHelp.Image = CType(resources.GetObject("cmd_TablenoHelp.Image"), System.Drawing.Image)
        Me.cmd_TablenoHelp.Location = New System.Drawing.Point(32, 8)
        Me.cmd_TablenoHelp.Name = "cmd_TablenoHelp"
        Me.cmd_TablenoHelp.Size = New System.Drawing.Size(23, 29)
        Me.cmd_TablenoHelp.TabIndex = 37
        Me.cmd_TablenoHelp.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(96, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 25)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "KOT TYPE "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Covers
        '
        Me.lbl_Covers.AutoSize = True
        Me.lbl_Covers.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Covers.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Covers.ForeColor = System.Drawing.Color.Black
        Me.lbl_Covers.Location = New System.Drawing.Point(64, 64)
        Me.lbl_Covers.Name = "lbl_Covers"
        Me.lbl_Covers.Size = New System.Drawing.Size(89, 25)
        Me.lbl_Covers.TabIndex = 36
        Me.lbl_Covers.Text = "COVERS "
        Me.lbl_Covers.Visible = False
        '
        'txt_Cover
        '
        Me.txt_Cover.BackColor = System.Drawing.Color.White
        Me.txt_Cover.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Cover.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cover.Location = New System.Drawing.Point(72, -32)
        Me.txt_Cover.MaxLength = 9
        Me.txt_Cover.Name = "txt_Cover"
        Me.txt_Cover.Size = New System.Drawing.Size(136, 29)
        Me.txt_Cover.TabIndex = 42
        Me.txt_Cover.Text = ""
        Me.txt_Cover.Visible = False
        '
        'txt_TableNo
        '
        Me.txt_TableNo.BackColor = System.Drawing.Color.White
        Me.txt_TableNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TableNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TableNo.Location = New System.Drawing.Point(72, 64)
        Me.txt_TableNo.MaxLength = 10
        Me.txt_TableNo.Name = "txt_TableNo"
        Me.txt_TableNo.Size = New System.Drawing.Size(56, 29)
        Me.txt_TableNo.TabIndex = 41
        Me.txt_TableNo.Text = ""
        Me.txt_TableNo.Visible = False
        '
        'lbl_Tableno
        '
        Me.lbl_Tableno.AutoSize = True
        Me.lbl_Tableno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tableno.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tableno.ForeColor = System.Drawing.Color.Black
        Me.lbl_Tableno.Location = New System.Drawing.Point(-64, -32)
        Me.lbl_Tableno.Name = "lbl_Tableno"
        Me.lbl_Tableno.Size = New System.Drawing.Size(113, 25)
        Me.lbl_Tableno.TabIndex = 35
        Me.lbl_Tableno.Text = "TABLE NO "
        Me.lbl_Tableno.Visible = False
        '
        'cmd_RoomQuery
        '
        Me.cmd_RoomQuery.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.cmd_RoomQuery.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_RoomQuery.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_RoomQuery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_RoomQuery.Location = New System.Drawing.Point(1008, 608)
        Me.cmd_RoomQuery.Name = "cmd_RoomQuery"
        Me.cmd_RoomQuery.Size = New System.Drawing.Size(48, 40)
        Me.cmd_RoomQuery.TabIndex = 32
        Me.cmd_RoomQuery.Text = "Room Query"
        Me.cmd_RoomQuery.Visible = False
        '
        'cmd_LocalSetting
        '
        Me.cmd_LocalSetting.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.cmd_LocalSetting.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_LocalSetting.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_LocalSetting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_LocalSetting.Location = New System.Drawing.Point(960, 608)
        Me.cmd_LocalSetting.Name = "cmd_LocalSetting"
        Me.cmd_LocalSetting.Size = New System.Drawing.Size(48, 40)
        Me.cmd_LocalSetting.TabIndex = 31
        Me.cmd_LocalSetting.Text = "Local Settle"
        Me.cmd_LocalSetting.Visible = False
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(73, 336)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(872, 200)
        Me.ssGrid.TabIndex = 6
        '
        'dtp_KOTdate
        '
        Me.dtp_KOTdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_KOTdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_KOTdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_KOTdate.Location = New System.Drawing.Point(680, 104)
        Me.dtp_KOTdate.Name = "dtp_KOTdate"
        Me.dtp_KOTdate.Size = New System.Drawing.Size(96, 26)
        Me.dtp_KOTdate.TabIndex = 10
        '
        'grp_Itemdetails
        '
        Me.grp_Itemdetails.Controls.Add(Me.ssgrid_Itemdetails)
        Me.grp_Itemdetails.Controls.Add(Me.lbl_Itemdetails)
        Me.grp_Itemdetails.Location = New System.Drawing.Point(104, 5000)
        Me.grp_Itemdetails.Name = "grp_Itemdetails"
        Me.grp_Itemdetails.Size = New System.Drawing.Size(600, 384)
        Me.grp_Itemdetails.TabIndex = 344
        Me.grp_Itemdetails.TabStop = False
        '
        'ssgrid_Itemdetails
        '
        Me.ssgrid_Itemdetails.ContainingControl = Me
        Me.ssgrid_Itemdetails.DataSource = Nothing
        Me.ssgrid_Itemdetails.Location = New System.Drawing.Point(24, 5)
        Me.ssgrid_Itemdetails.Name = "ssgrid_Itemdetails"
        Me.ssgrid_Itemdetails.OcxState = CType(resources.GetObject("ssgrid_Itemdetails.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_Itemdetails.Size = New System.Drawing.Size(552, 312)
        Me.ssgrid_Itemdetails.TabIndex = 23
        '
        'lbl_Itemdetails
        '
        Me.lbl_Itemdetails.AutoSize = True
        Me.lbl_Itemdetails.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Itemdetails.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbl_Itemdetails.Location = New System.Drawing.Point(208, 16)
        Me.lbl_Itemdetails.Name = "lbl_Itemdetails"
        Me.lbl_Itemdetails.Size = New System.Drawing.Size(154, 35)
        Me.lbl_Itemdetails.TabIndex = 22
        Me.lbl_Itemdetails.Text = "Item Details"
        Me.lbl_Itemdetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_KOTTime
        '
        Me.txt_KOTTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_KOTTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_KOTTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_KOTTime.Location = New System.Drawing.Point(776, 104)
        Me.txt_KOTTime.Name = "txt_KOTTime"
        Me.txt_KOTTime.ReadOnly = True
        Me.txt_KOTTime.Size = New System.Drawing.Size(96, 26)
        Me.txt_KOTTime.TabIndex = 11
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
        Me.lbl_Status.Location = New System.Drawing.Point(200, 560)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(0, 25)
        Me.lbl_Status.TabIndex = 29
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_POSCode
        '
        Me.pnl_POSCode.BackgroundImage = CType(resources.GetObject("pnl_POSCode.BackgroundImage"), System.Drawing.Image)
        Me.pnl_POSCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_POSCode.Controls.Add(Me.lvw_POSCode)
        Me.pnl_POSCode.Location = New System.Drawing.Point(64, 104)
        Me.pnl_POSCode.Name = "pnl_POSCode"
        Me.pnl_POSCode.Size = New System.Drawing.Size(432, 232)
        Me.pnl_POSCode.TabIndex = 346
        '
        'lvw_POSCode
        '
        Me.lvw_POSCode.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader5})
        Me.lvw_POSCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw_POSCode.FullRowSelect = True
        Me.lvw_POSCode.GridLines = True
        Me.lvw_POSCode.HideSelection = False
        Me.lvw_POSCode.HoverSelection = True
        Me.lvw_POSCode.Location = New System.Drawing.Point(8, 0)
        Me.lvw_POSCode.Name = "lvw_POSCode"
        Me.lvw_POSCode.Size = New System.Drawing.Size(432, 224)
        Me.lvw_POSCode.TabIndex = 0
        Me.lvw_POSCode.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "POS Code"
        Me.ColumnHeader1.Width = 198
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "POS Desc"
        Me.ColumnHeader3.Width = 232
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Account In"
        Me.ColumnHeader5.Width = 110
        '
        'pnl_UOMCode
        '
        Me.pnl_UOMCode.BackgroundImage = CType(resources.GetObject("pnl_UOMCode.BackgroundImage"), System.Drawing.Image)
        Me.pnl_UOMCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_UOMCode.Controls.Add(Me.lvw_Uom)
        Me.pnl_UOMCode.Location = New System.Drawing.Point(568, 104)
        Me.pnl_UOMCode.Name = "pnl_UOMCode"
        Me.pnl_UOMCode.Size = New System.Drawing.Size(376, 192)
        Me.pnl_UOMCode.TabIndex = 347
        '
        'lvw_Uom
        '
        Me.lvw_Uom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader4})
        Me.lvw_Uom.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvw_Uom.FullRowSelect = True
        Me.lvw_Uom.GridLines = True
        Me.lvw_Uom.HoverSelection = True
        Me.lvw_Uom.Location = New System.Drawing.Point(8, 0)
        Me.lvw_Uom.Name = "lvw_Uom"
        Me.lvw_Uom.Size = New System.Drawing.Size(784, 200)
        Me.lvw_Uom.TabIndex = 0
        Me.lvw_Uom.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "UOM Code"
        Me.ColumnHeader2.Width = 161
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "UOM Rate"
        Me.ColumnHeader4.Width = 209
        '
        'Lbl_Bill
        '
        Me.Lbl_Bill.AutoSize = True
        Me.Lbl_Bill.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Bill.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bill.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_Bill.Location = New System.Drawing.Point(200, 584)
        Me.Lbl_Bill.Name = "Lbl_Bill"
        Me.Lbl_Bill.Size = New System.Drawing.Size(0, 25)
        Me.Lbl_Bill.TabIndex = 30
        Me.Lbl_Bill.Visible = False
        '
        'cbo_SubPaymentMode
        '
        Me.cbo_SubPaymentMode.BackColor = System.Drawing.Color.Wheat
        Me.cbo_SubPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SubPaymentMode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SubPaymentMode.Location = New System.Drawing.Point(728, 146)
        Me.cbo_SubPaymentMode.Name = "cbo_SubPaymentMode"
        Me.cbo_SubPaymentMode.Size = New System.Drawing.Size(200, 30)
        Me.cbo_SubPaymentMode.TabIndex = 1
        Me.cbo_SubPaymentMode.Visible = False
        '
        'lbl_SubPaymentMode
        '
        Me.lbl_SubPaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubPaymentMode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubPaymentMode.ForeColor = System.Drawing.Color.Black
        Me.lbl_SubPaymentMode.Location = New System.Drawing.Point(504, 148)
        Me.lbl_SubPaymentMode.Name = "lbl_SubPaymentMode"
        Me.lbl_SubPaymentMode.Size = New System.Drawing.Size(218, 25)
        Me.lbl_SubPaymentMode.TabIndex = 18
        Me.lbl_SubPaymentMode.Text = "SUB PAYMENT MODE "
        Me.lbl_SubPaymentMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lbl_SubPaymentMode.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 612)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(912, 48)
        Me.GroupBox2.TabIndex = 348
        Me.GroupBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(595, 16)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(464, 16)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(727, 16)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(336, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(200, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(64, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.ForeColor = System.Drawing.Color.Black
        Me.lbl_Remarks.Location = New System.Drawing.Point(96, 552)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(101, 25)
        Me.lbl_Remarks.TabIndex = 355
        Me.lbl_Remarks.Text = "REMARKS "
        '
        'Txt_Remarks
        '
        Me.Txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Remarks.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Remarks.Location = New System.Drawing.Point(200, 545)
        Me.Txt_Remarks.MaxLength = 100
        Me.Txt_Remarks.Multiline = True
        Me.Txt_Remarks.Name = "Txt_Remarks"
        Me.Txt_Remarks.Size = New System.Drawing.Size(368, 39)
        Me.Txt_Remarks.TabIndex = 356
        Me.Txt_Remarks.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(16, 664)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(960, 32)
        Me.Label3.TabIndex = 357
        Me.Label3.Text = "F4-->Help  F2-->Kot No   F3-->Delete Item  Alt+C-->Flash  Card   Alt+P--> Payment" & _
        " Mode   Alt+B--> Member Code  Alt+S--> Server Code Alt+G-->Focus on Grid Alt+K->" & _
        " Remarks   Alt+D ->Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Red
        Me.lblUser.Location = New System.Drawing.Point(8, 8)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(216, 32)
        Me.lblUser.TabIndex = 358
        '
        'lblBillno1
        '
        Me.lblBillno1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.lblBillno1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillno1.Location = New System.Drawing.Point(736, 4)
        Me.lblBillno1.Name = "lblBillno1"
        Me.lblBillno1.Size = New System.Drawing.Size(208, 24)
        Me.lblBillno1.TabIndex = 359
        Me.lblBillno1.Visible = False
        '
        'lblBillno2
        '
        Me.lblBillno2.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(128, Byte))
        Me.lblBillno2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillno2.Location = New System.Drawing.Point(736, 32)
        Me.lblBillno2.Name = "lblBillno2"
        Me.lblBillno2.Size = New System.Drawing.Size(208, 24)
        Me.lblBillno2.TabIndex = 360
        Me.lblBillno2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(608, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 22)
        Me.Label1.TabIndex = 361
        Me.Label1.Text = "BILL NO(S) "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(424, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 35)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "KOT ENTRY"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(-24, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 32)
        Me.Label4.TabIndex = 358
        '
        'lab_outstanding
        '
        Me.lab_outstanding.AutoSize = True
        Me.lab_outstanding.BackColor = System.Drawing.Color.Transparent
        Me.lab_outstanding.Font = New System.Drawing.Font("Courier New", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_outstanding.ForeColor = System.Drawing.Color.Blue
        Me.lab_outstanding.Location = New System.Drawing.Point(80, 608)
        Me.lab_outstanding.Name = "lab_outstanding"
        Me.lab_outstanding.Size = New System.Drawing.Size(0, 34)
        Me.lab_outstanding.TabIndex = 355
        Me.lab_outstanding.Visible = False
        '
        'txt_card_id
        '
        Me.txt_card_id.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txt_card_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_card_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_card_id.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_card_id.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_card_id.Location = New System.Drawing.Point(296, 64)
        Me.txt_card_id.MaxLength = 25
        Me.txt_card_id.Name = "txt_card_id"
        Me.txt_card_id.PasswordChar = Microsoft.VisualBasic.ChrW(88)
        Me.txt_card_id.Size = New System.Drawing.Size(168, 34)
        Me.txt_card_id.TabIndex = 604
        Me.txt_card_id.Text = ""
        '
        'lbl_SwipeCard
        '
        Me.lbl_SwipeCard.BackColor = System.Drawing.Color.ForestGreen
        Me.lbl_SwipeCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_SwipeCard.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SwipeCard.ForeColor = System.Drawing.Color.White
        Me.lbl_SwipeCard.Image = CType(resources.GetObject("lbl_SwipeCard.Image"), System.Drawing.Image)
        Me.lbl_SwipeCard.Location = New System.Drawing.Point(72, -32)
        Me.lbl_SwipeCard.Name = "lbl_SwipeCard"
        Me.lbl_SwipeCard.Size = New System.Drawing.Size(104, 32)
        Me.lbl_SwipeCard.TabIndex = 605
        Me.lbl_SwipeCard.Text = "FLASH CARD"
        Me.lbl_SwipeCard.Visible = False
        '
        'txt_lastbillamount
        '
        Me.txt_lastbillamount.BackColor = System.Drawing.Color.White
        Me.txt_lastbillamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_lastbillamount.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lastbillamount.Location = New System.Drawing.Point(8, 584)
        Me.txt_lastbillamount.MaxLength = 50
        Me.txt_lastbillamount.Name = "txt_lastbillamount"
        Me.txt_lastbillamount.Size = New System.Drawing.Size(72, 39)
        Me.txt_lastbillamount.TabIndex = 611
        Me.txt_lastbillamount.Text = ""
        Me.txt_lastbillamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_lastbillamount.Visible = False
        '
        'txt_lostcardcode
        '
        Me.txt_lostcardcode.BackColor = System.Drawing.SystemColors.Info
        Me.txt_lostcardcode.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lostcardcode.Location = New System.Drawing.Point(456, 584)
        Me.txt_lostcardcode.Name = "txt_lostcardcode"
        Me.txt_lostcardcode.Size = New System.Drawing.Size(104, 21)
        Me.txt_lostcardcode.TabIndex = 610
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
        Me.Cmd_DC_Update.Location = New System.Drawing.Point(-16, 568)
        Me.Cmd_DC_Update.Name = "Cmd_DC_Update"
        Me.Cmd_DC_Update.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_DC_Update.TabIndex = 609
        Me.Cmd_DC_Update.Text = "DC Update[F4]"
        Me.Cmd_DC_Update.Visible = False
        '
        'CHK_PRINT
        '
        Me.CHK_PRINT.BackColor = System.Drawing.Color.Transparent
        Me.CHK_PRINT.Checked = True
        Me.CHK_PRINT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK_PRINT.Location = New System.Drawing.Point(8, 72)
        Me.CHK_PRINT.Name = "CHK_PRINT"
        Me.CHK_PRINT.Size = New System.Drawing.Size(56, 24)
        Me.CHK_PRINT.TabIndex = 612
        Me.CHK_PRINT.Text = "Print"
        Me.CHK_PRINT.Visible = False
        '
        'Timer1
        '
        '
        'Timer_Delay
        '
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(713, 624)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(101, 32)
        Me.Cmd_Print.TabIndex = 830
        Me.Cmd_Print.Text = "Print[F10]"
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.Location = New System.Drawing.Point(584, 624)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.cmd_View.TabIndex = 829
        Me.cmd_View.Text = " View[F9]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(840, 624)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 831
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(184, 624)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 832
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmd_Delete.Image = CType(resources.GetObject("cmd_Delete.Image"), System.Drawing.Image)
        Me.cmd_Delete.Location = New System.Drawing.Point(455, 624)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 828
        Me.cmd_Delete.Text = "Delete[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(320, 624)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 826
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_ShowBill
        '
        Me.Cmd_ShowBill.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_ShowBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_ShowBill.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ShowBill.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Cmd_ShowBill.Image = CType(resources.GetObject("Cmd_ShowBill.Image"), System.Drawing.Image)
        Me.Cmd_ShowBill.Location = New System.Drawing.Point(48, 624)
        Me.Cmd_ShowBill.Name = "Cmd_ShowBill"
        Me.Cmd_ShowBill.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_ShowBill.TabIndex = 833
        Me.Cmd_ShowBill.Text = "Bill[F12]"
        '
        'LAB_CARDBAL
        '
        Me.LAB_CARDBAL.AutoSize = True
        Me.LAB_CARDBAL.BackColor = System.Drawing.Color.Transparent
        Me.LAB_CARDBAL.Font = New System.Drawing.Font("Courier New", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_CARDBAL.ForeColor = System.Drawing.Color.Blue
        Me.LAB_CARDBAL.Location = New System.Drawing.Point(160, 32)
        Me.LAB_CARDBAL.Name = "LAB_CARDBAL"
        Me.LAB_CARDBAL.Size = New System.Drawing.Size(0, 28)
        Me.LAB_CARDBAL.TabIndex = 834
        Me.LAB_CARDBAL.Visible = False
        '
        'KOTEntry
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 740)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_POSCode)
        Me.Controls.Add(Me.LAB_CARDBAL)
        Me.Controls.Add(Me.pnl_UOMCode)
        Me.Controls.Add(Me.txt_BillAmount)
        Me.Controls.Add(Me.txt_card_id)
        Me.Controls.Add(Me.txt_lastbillamount)
        Me.Controls.Add(Me.txt_lostcardcode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Remarks)
        Me.Controls.Add(Me.lbl_Remarks)
        Me.Controls.Add(Me.txt_KOTTime)
        Me.Controls.Add(Me.lbl_BillAmount)
        Me.Controls.Add(Me.txt_TaxValue)
        Me.Controls.Add(Me.lbl_TaxValue)
        Me.Controls.Add(Me.txt_TotalValue)
        Me.Controls.Add(Me.lbl_TotalValue)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbl_Tableno)
        Me.Controls.Add(Me.txt_Cover)
        Me.Controls.Add(Me.lbl_Covers)
        Me.Controls.Add(Me.txt_TableNo)
        Me.Controls.Add(Me.txt_KOTno)
        Me.Controls.Add(Me.txt_ServerCode)
        Me.Controls.Add(Me.txt_Exemption)
        Me.Controls.Add(Me.lbl_Exemption)
        Me.Controls.Add(Me.txt_MemberName)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CHK_PRINT)
        Me.Controls.Add(Me.Cmd_ShowBill)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.cmd_View)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.lbl_SwipeCard)
        Me.Controls.Add(Me.lbl_SubPaymentMode)
        Me.Controls.Add(Me.lbl_KOTno)
        Me.Controls.Add(Me.lbl_KOTdate)
        Me.Controls.Add(Me.lbl_Servercode)
        Me.Controls.Add(Me.lbl_ServerName)
        Me.Controls.Add(Me.lbl_Membercode)
        Me.Controls.Add(Me.lbl_PaymentMode)
        Me.Controls.Add(Me.lbl_MemberName)
        Me.Controls.Add(Me.Cmd_DC_Update)
        Me.Controls.Add(Me.lblBillno2)
        Me.Controls.Add(Me.lblBillno1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbo_SubPaymentMode)
        Me.Controls.Add(Me.Lbl_Bill)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.grp_Itemdetails)
        Me.Controls.Add(Me.dtp_KOTdate)
        Me.Controls.Add(Me.ssGrid)
        Me.Controls.Add(Me.cmd_RoomQuery)
        Me.Controls.Add(Me.cmd_LocalSetting)
        Me.Controls.Add(Me.grp_ssgrid)
        Me.Controls.Add(Me.grp_Tabledetails)
        Me.Controls.Add(Me.cmd_KOTnoHelp)
        Me.Controls.Add(Me.grp_KOTdetails)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.cmd_ServerCodeHelp)
        Me.Controls.Add(Me.cbo_PaymentMode)
        Me.Controls.Add(Me.grp_Memberdetails)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lab_outstanding)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KOTEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KOT ENTRY "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_Memberdetails.ResumeLayout(False)
        Me.grp_KOTdetails.ResumeLayout(False)
        Me.grp_Tabledetails.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Itemdetails.ResumeLayout(False)
        CType(Me.ssgrid_Itemdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_POSCode.ResumeLayout(False)
        Me.pnl_UOMCode.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public vseqno As Double
    Dim PHOTOFILENAME As String
    Dim itembool, chkbool, smartcardbool, boolPromotional As Boolean
    Dim dd, serverdate As DateTime
    Dim TotalItemCount As Integer
    Dim gconnection As New GlobalClass
    Dim posstring As String
    Dim vsearch, vitem, accountcode, KOTno(), loccode, stosql, servicelocation As String
    Dim BillNontaxamount, BillNontotalamount, Billtaxamount, Billtotalamount, MemberOutstand As Double
    Dim duplicateflag As Boolean = False
    '----SMART CARD
    Public BALANCE_HDR As Double
    Public MIN_USAGE_BALANCE_HDR As Double
    Dim count As Integer = 1
    Dim GADDDATETIME As Date
    Dim strPhotoFilePath As String
    Public foto As New GlobalClass
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
                CMB_BTYPE.SelectedIndex = 0
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
    Private Sub KOTEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            vCardcode = ""
            'smartdeviceportcount = 0
            If gReaderType_code = 2 Then
                Timer1.Enabled = True
            End If
            'Timer1.Enabled = True
            KOT_Timer.Enabled = True
            KOT_Timer.Interval = 100
            LAB_CARDBAL.Text = ""
            Call SetDateTime()
            Call SYS_DATE_TIME()
            MNAME_GBL = ""
            MCODE_GBL = ""

            Call KOTTYPE()
            Call Enabledcontrol()
            Call autogenerate()
            Call ShowBillno()
            Call GRIDLOCK()
            itembool = False
            pnl_POSCode.Top = 1000
            pnl_UOMCode.Top = 1000
            KOT_Timer.Enabled = True
            KOT_Timer.Interval = 100
            kotentrybool = True

            '*******************SMART CARD START
            Dim ssqqll As String
            ssqqll = "SELECT  ISNULL(ACCESS_CHECK,'N') AS ACCESS_CHECK FROM SM_ACCESSCONTROL_MASTER"
            gconnection.getDataSet(ssqqll, "SM_ACCESSCONTROL_MASTER")
            If Trim(gdataset.Tables("SM_ACCESSCONTROL_MASTER").Rows(0).Item("ACCESS_CHECK")) = "Y" Then
                ACCESS_CHECK_GBL = True
            Else
                ACCESS_CHECK_GBL = False
            End If

            '*******************SMART CARD START
            If MCODE_GBL <> "" Then
                lbl_SwipeCard.Visible = False
                txt_MemberCode.Text = MCODE_GBL
                'txt_card_id.Visible = False
                txt_MemberName.Text = NAME_GBL

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
                MCODE_GBL = ""
                Name = ""
                ACC_ENTRY = False
                cbo_PaymentMode.Focus()
                Show()
                'txt_card_id.Focus()
                'lbl_SwipeCard.Focus()
            End If

            txt_MemberName.ReadOnly = False
            txt_ServerName.ReadOnly = False
            txt_TotalValue.ReadOnly = True
            txt_TaxValue.ReadOnly = True
            txt_BillAmount.ReadOnly = True
            ssGrid.ClearRange(1, 1, -1, -1, True)
            Me.cmd_KOTnoHelp.Enabled = True
            cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
            'cbo_PaymentMode.Focus()
            txt_KOTno.Focus()
            Call SetDateTime()
            Call SYS_DATE_TIME()
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Call cmd_Clear_Click(sender, e)
            txt_card_id.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
        gSQLString = "SELECT Tableno FROM Tablemaster"
        M_WhereCondition = " WHERE ISNULL(Freeze,'') <> 'Y'"
        vform.Field = "TABLENO"
        vform.vFormatstring = "                  TABLENO                               "
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
        Try
            Dim vform As New ListOperattion1
            'If Trim(txt_MemberCode.Text) <> "" Then
            If cbo_PaymentMode.SelectedItem = "ROOM" Then
                gSQLString = "SELECT roomno,guest,docno FROM roomcheckin "
                M_WhereCondition = "WHERE ISNULL(checkout,'') <> 'Y' AND roomstatus='occupied'"
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
                        ssGrid.Focus()
                    Else
                        txt_ServerCode.Focus()
                    End If
                End If
                vform.Close()
                vform = Nothing
                'club
                '03/05/2008
            ElseIf cbo_PaymentMode.SelectedItem = "CLUB" Then
                gSQLString = "SELECT slcode,slname FROM accountssubledgermaster "
                M_WhereCondition = ""
                vform.Field = " SLCODE,SLNAME "
                vform.vFormatstring = "     SLCODE                  |                     SL NAME                    "
                vform.vCaption = "ACCOUNT MASTER HELP"
                vform.KeyPos = 0
                vform.KeyPos1 = 1
                vform.ShowDialog(Me)
                If Trim(vform.keyfield & "") <> "" Then
                    txt_MemberCode.Text = Trim(vform.keyfield & "")
                    txt_MemberName.Text = Trim(vform.keyfield1 & "")
                    txt_MemberCode.Tag = Trim(vform.keyfield & "")
                    txt_ServerCode.Focus()
                End If
                vform.Close()
                vform = Nothing
            Else
                gSQLString = "SELECT mcode,mname FROM Membermaster "
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
                    'txt_MemberCode_Validated(sender, e)
                    If txt_MemberCode.Text <> "" Then
                        txt_ServerCode.Focus()
                    Else
                        txt_MemberCode.Focus()
                    End If
                End If
                vform.Close()
                vform = Nothing
            End If
            '  End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cmd_ServerCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ServerCodeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT Servercode, Servername FROM servermaster"
        M_WhereCondition = " WHERE ISNULL(FREEZE,'') <>'Y'"
        vform.Field = " SERVERCODE, SERVERNAME "
        vform.vFormatstring = "         SERVER CODE            |                       SERVERNAME                               "
        vform.vCaption = "SERVER MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_ServerCode.Text = Trim(vform.keyfield & "")
            txt_ServerName.Text = Trim(vform.keyfield1 & "")
            If txt_LOCATIONCODE.Text <> "" Then
                ssGrid.Focus()
                ssGrid.SetActiveCell(1, 1)
            Else
                txt_LOCATIONCODE.Focus()
            End If
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub Cmd_Add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub cmd_Clear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub cmd_Delete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub DeleteOperation()
        MessageBox.Show("Particular KOT's Can't be deleted", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub
    End Sub
    Private Sub cmd_View1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub Cmd_Print1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub cmd_Exit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub fillPayment_Mode()
        Dim sqlstring As String
        Dim index As Integer
        Dim i As Integer
        Try
            Call FillDefaultPayment()
            'Modified on 18 Mar'08
            'Mk Kannan
            'Begin
            'sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Paymentcode NOT IN ('CLUB')AND Isnull(Freeze,'')<>'Y'"
            'sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Isnull(Freeze,'')<>'Y'"

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
            'End

            gconnection.getDataSet(sqlstring, "paymentmodemaster")
            If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("paymentmodemaster").Rows.Count - 1
                    cbo_PaymentMode.Items.Add(gdataset.Tables("paymentmodemaster").Rows(i).Item("Paymentcode"))
                Next i
                cbo_PaymentMode.SelectedIndex = 0
            Else
                '                MessageBox.Show("Plz Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Function CHECK_KOTEXIST(ByVal KOTNO As String) As Boolean
        Dim SSQL As String
        If Trim(KOTNO) <> "" Then

            SSQL = "SELECT * FROM KOT_HDR WHERE ltrim(rtrim(KOTNO))='" & Trim(KOTNO) & "'"
            gconnection.getDataSet(SSQL, "kot_hdr")
            If gdataset.Tables("kot_hdr").Rows.Count > 0 Then
                CHECK_KOTEXIST = True
                duplicateflag = True
                Exit Function
            Else
                duplicateflag = False
                CHECK_KOTEXIST = False
            End If
            If CHECK_KOTEXIST = False Then
                SSQL = "select * from kot_hdr where kotdetails not in(select kotdetails from kot_det) and ltrim(rtrim(KOTNO))='" & Trim(KOTNO) & "'"
                gconnection.getDataSet(SSQL, "kot_hdr")
                If gdataset.Tables("kot_hdr").Rows.Count > 0 Then
                    CHECK_KOTEXIST = True
                    Exit Function
                Else
                    CHECK_KOTEXIST = False
                End If
            End If
            If CHECK_KOTEXIST = False Then
                SSQL = "SELECT KOTDETAILS ,KOTDATE FROM KOT_DET  WHERE  KOTDETAILS NOT IN (SELECT KOTDETAILS FROM KOT_HDR) and ltrim(rtrim(KOTNO))='" & Trim(KOTNO) & "'"
                gconnection.getDataSet(SSQL, "kot_hdr")
                If gdataset.Tables("kot_hdr").Rows.Count > 0 Then
                    CHECK_KOTEXIST = True
                    Exit Function
                Else
                    CHECK_KOTEXIST = False
                End If
            End If


            ''''sqlstring = "SELECT DISTINCT isnull(BILLDETAILS,'') as billdetails FROM KOT_DET WHERE KOTNO= " & Trim(KOTNO)
            ''''gconnection.getDataSet(sqlstring, "KOT_DET")
            ''''If gdataset.Tables("KOT_DET").Rows.Count > 0 Then
            ''''    For i = 0 To gdataset.Tables("KOT_DET").Rows.Count - 1
            ''''        If Trim(STRBILLNO) = "" Then
            ''''            STRBILLNO = Trim(gdataset.Tables("KOT_DET").Rows(i).Item("BILLDETAILS"))

            ''''        Else
            ''''            strbillno2 = Trim(gdataset.Tables("KOT_DET").Rows(i).Item("BILLDETAILS"))

            ''''        End If
            ''''    Next

        End If
    End Function


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
                'txt_MemberCode_Validated(sender, e)
                If txt_ServerCode.Text <> "" Then
                    ssGrid.Focus()
                Else
                    txt_ServerCode.Focus()
                End If
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
        getAlphanumeric(e)
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

    Private Sub txt_Exemption_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Exemption.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ssGrid.Focus()
            ssGrid.SetActiveCell(1, 1)
        End If
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

            'If cbo_PaymentMode.Text = "R.MEMBER" Or cbo_PaymentMode.Text = "COUPON" Then
            '    txt_ServerCode.Focus()
            'ElseIf cbo_SubPaymentMode.Visible = True Then
            '    cbo_SubPaymentMode.Focus()
            'Else
            '    txt_MemberCode.Focus()
            'End If
            'End
        End If
    End Sub
    Private Sub cmd_KOTnoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_KOTnoHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT Kotdetails,ServerCode,total,Convert(varchar, kotdate,100) FROM KOT_HDR "
        M_WhereCondition = "WHERE DocType ='SALE' and BTYPE='" & CMB_BTYPE.Text & "'"
        vform.Field = " KOTDETAILS,SERVERCODE,AMOUNT,KOTDATE "
        vform.vFormatstring = "            KOT NO              |     SERVER CODE    |       AMOUNT     |       KOT DATE           |                               "
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
            'txt_BillAmount.Text = Format(Math.Round(Val(txt_BillAmount.Text)), "0.00")
            txt_BillAmount.Text = Format(Val(txt_BillAmount.Text), "0.00")
        Else
            txt_BillAmount.Text = Format(Val(txt_BillAmount.Text), "0.00")
        End If
    End Sub

    Private Sub txt_TableNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_TableNo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_TablenoHelp_Click(sender, e)
        End If
    End Sub
    Private Sub txt_KOTno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_KOTno.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_KOTnoHelp_Click(sender, e)
        End If
    End Sub

    Private Sub txt_KOTno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_KOTno.KeyPress
        Call getAlphanumeric(e)
        'Call getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_KOTno.Text) = "" Then
                Call cmd_KOTnoHelp_Click(cmd_KOTnoHelp, e)
            Else
                'cbo_PaymentMode.Focus()
                'txt_MemberCode.Focus()
                txt_ServerCode.Focus()

            End If
        End If
    End Sub
    Private Sub dtp_KOTdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_KOTdate.KeyPress
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
            If Me.cmd_ServerCodeHelp.Enabled = True Then
                Call cmd_ServerCodeHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub KOTEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
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
        ElseIf e.KeyCode = Keys.F12 Then
            If Cmd_Print.Enabled = True Then
                Call Cmd_ShowBill_Click(sender, e)
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

    Private Sub autogenerate()
        Dim sqlstring, financalyear As String
        Try
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            sqlstring = "SELECT Isnull(DocNo,0) FROM PoSKotDoc Where DocType = 'KOT'"
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_KOTno.Text = "KOT/000001/" & financalyear
                    'txt_KOTno.Text = gPoSUsername & "/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_KOTno.Text = "KOT/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    'txt_KOTno.Text = gPoSUsername & "/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_KOTno.Text = "KOT/000001/" & financalyear
                'txt_KOTno.Text = gPoSUsername & "/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
            'End
        Catch ex As Exception
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub
    Private Sub autogenerate_add()
        Dim sqlstring, financalyear, sqlstring_upd As String
        Try
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)

BEGIN:
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            sqlstring = "SELECT Isnull(DocNo,0),ISNULL(DOCFLAG,'') AS DOCFLAG FROM PoSKotDoc with(rowlock,holdlock) Where DocType = 'KOT'"
            'gconnection.getDataSet(sqlstring, "POSKOT")
            'If gdataset.Tables("POSKOT").Rows.Count > 0 Then
            'If gdataset.Tables("POSKOT").Rows(0).Item("DOCFLAG") = "N" Then
            'sqlstring_upd = "UPDATE POSKOTDOC SET DOCFLAG='Y' WHERE DOCFLAG='N' and doctype='KOT'"
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
                    txt_KOTno.Text = "KOT/000001/" & financalyear
                    'txt_KOTno.Text = gPoSUsername & "/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_KOTno.Text = "KOT/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    'txt_KOTno.Text = gPoSUsername & "/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_KOTno.Text = "KOT/000001/" & financalyear
                'txt_KOTno.Text = gPoSUsername & "/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
            'End
        Catch ex As Exception
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub
    Private Sub autogenerate1()
        Dim sqlstring, financalyear As String
        Try
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            'Modified on 06 Apr'08 for Generating Usernamewise KOT
            'Advised by :- Sandeep after having discussion with him at 06 Apr'08 Mid Night 11.30 P.M
            'Mk Kannan
            'Begin
            'sqlstring = "SELECT MAX(Cast(SUBSTRING(KOTno,1,6) As Numeric)) FROM KOT_HDR WHERE DocType ='SALE'"
            ' Call UserValidation()
            sqlstring = "SELECT Isnull(DocNo,0) FROM PoSKotDoc Where DocType = 'KOT'"
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_KOTno.Text = "KOT/000001/" & financalyear
                    'txt_KOTno.Text = gPoSUsername & "/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_KOTno.Text = "KOT/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    'txt_KOTno.Text = gPoSUsername & "/" & Format(gdreader(0) + 2, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_KOTno.Text = "KOT/000001/" & financalyear
                'txt_KOTno.Text = gPoSUsername & "/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
            KOTno = Split(Trim(txt_KOTno.Text), "/")
            'End
        Catch ex As Exception
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub
    Private Sub ssGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssGrid.KeyDownEvent
        Dim Sqlstring, Itemcode, Itemdesc, Promtcode As String
        Dim PROQTY_GRID As Double
        Dim varitemcode, varitemdesc, varposcode, varuom As String
        Dim i, j As Integer
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
                            Call FillMenu()
                            'Call FillMenuItem()
                        ElseIf Trim(ssGrid.Text) <> "" Then
                            If Trim(varitemdesc) = "" And Trim(varposcode) = "" Then
                                Itemcode = Trim(ssGrid.Text)
                                ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                                Sqlstring = "SELECT DISTINCT I.ITEMDESC,I.ITEMCODE,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE,"
                                Sqlstring = Sqlstring & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,I.PROMOTIONAL,I.PROMITEMCODE,I.OPENFACILITY,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN,isnull(I.PROMTYPE,'') AS PROMTYPE FROM ITEMMASTER AS I"
                                Sqlstring = Sqlstring & " INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "
                                Sqlstring = Sqlstring & " WHERE I.ITEMCODE = '" & Trim(Itemcode) & "' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE  AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y'"
                                gconnection.getDataSet(Sqlstring, "ITEMCODE")
                                If gdataset.Tables("ITEMCODE").Rows.Count > 0 Then
                                    ssGrid.SetText(1, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMCODE")) & "")
                                    ssGrid.SetText(2, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMDESC")) & "")
                                    ssGrid.SetText(9, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMTYPECODE")) & "")
                                    ssGrid.SetText(10, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXCODE")) & "")
                                    ssGrid.SetText(11, i, Val(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXPERCENTAGE")))
                                    ssGrid.SetText(13, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ACCOUNTCODE")))
                                    ssGrid.SetText(14, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("SALESACCTIN")))
                                    ssGrid.SetText(15, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("GROUPCODE")))
                                    ssGrid.SetText(19, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")))
                                    If Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")) = "Y" Then
                                        ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                    Else
                                        ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                                    End If

                                    '''*************************** $ PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                    '''''''If Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("Promotional")) = "Y" Then
                                    '''''''    Promtcode = Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PromItemcode"))

                                    '''''''    'Modified on 14 Mar'08
                                    '''''''    'Mk Kannan
                                    '''''''    'Begin
                                    '''''''    'Sqlstring = "SELECT I.PROMQTY, I.ITEMCODE,I.PROMITEMCODE,I.ITEMDESC,I.ITEMTYPECODE, P.POSCODE, P.POSDESC,I.STARTINGDATE,I.ENDINGDATE,"
                                    '''''''    'Sqlstring = Sqlstring & " I.PROMUOM, I.PROMQTY, I.PROMRATE FROM ITEMMASTER AS I INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN"
                                    '''''''    'Sqlstring = Sqlstring & " POSMASTER AS P ON PL.POS = P.POSCODE "                                        
                                    '''''''    'Sqlstring = Sqlstring & " WHERE (I.PROMOTIONAL = 'Y') AND (I.PROMITEMCODE = '" & Promtcode & "') AND (I.ITEMCODE = '" & Itemcode & "') AND ISNULL(I.FREEZE,'') <>'Y' "
                                    '''''''    Sqlstring = "SELECT I.PROMQTY, I.ITEMCODE,I.PROMITEMCODE, IM.ITEMDESC, IM.GROUPCODE, I.ITEMTYPECODE, P.POSCODE, P.POSDESC,I.STARTINGDATE,I.ENDINGDATE,"
                                    '''''''    Sqlstring = Sqlstring & " I.PROMUOM, I.PROMQTY, I.PROMRATE FROM ITEMMASTER AS I INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN"
                                    '''''''    Sqlstring = Sqlstring & " POSMASTER AS P ON PL.POS = P.POSCODE "
                                    '''''''    Sqlstring = Sqlstring & " INNER JOIN ITEMMASTER AS IM ON IM.ITEMCODE=I.PROMITEMCODE"
                                    '''''''    Sqlstring = Sqlstring & " WHERE (I.PROMOTIONAL = 'Y') AND (I.PROMITEMCODE = '" & Promtcode & "') AND (I.ITEMCODE = '" & Itemcode & "') AND ISNULL(I.FREEZE,'') <>'Y' "
                                    '''''''    'End
                                    '''''''    gconnection.getDataSet(Sqlstring, "PROMOTIONAL")
                                    '''''''    If gdataset.Tables("PROMOTIONAL").Rows.Count > 0 Then
                                    '''''''        If MessageBox.Show("Promotional available for this Itemcode!", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                                    '''''''            'If CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("EndingDate")) <= CDate(serverdate.Today) And CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("StartingDate")) >= CDate(serverdate.Today) Then
                                    '''''''            If CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("StartingDate")) <= CDate(serverdate.Today) And CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("EndingDate")) >= CDate(serverdate.Today) Then
                                    '''''''                ssGrid.SetText(1, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMITEMCODE")) & "")
                                    '''''''                ssGrid.SetText(2, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMDESC")) & "")
                                    '''''''                ssGrid.SetText(3, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("POSCODE")) & "")
                                    '''''''                ssGrid.SetText(4, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMUOM")) & "")
                                    '''''''                ssGrid.SetText(5, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMQTY")) & "")
                                    '''''''                ssGrid.SetText(6, i + 1, 0.0)
                                    '''''''                ssGrid.SetText(7, i + 1, 0.0)
                                    '''''''                ssGrid.SetText(8, i + 1, 0.0)
                                    '''''''                ssGrid.SetText(9, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMTYPECODE")) & "")
                                    '''''''                'Modified on 14 Mar'08
                                    '''''''                'Mk Kannan
                                    '''''''                'Begin
                                    '''''''                ssGrid.SetText(11, i + 1, 0.0)
                                    '''''''                ssGrid.SetText(15, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("GROUPCODE")) & "")
                                    '''''''                ssGrid.SetText(17, i + 1, "Y")
                                    '''''''                boolPromotional = True
                                    '''''''                'End
                                    '''''''            End If
                                    '''''''        End If
                                    '''''''    End If
                                    '''''''End If
                                    '''*************************** $ COMPLETE PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                    '''****************************** TO FILL POSCODE **********************************************************************'''
                                    Sqlstring = " SELECT M.POSCODE,M.POSDESC,N.SALESACCTIN FROM POSMENULINK P INNER JOIN POSMASTER M ON P.POS=M.POSCODE INNER JOIN ITEMMASTER N ON P.ITEMCODE=N.ITEMCODE WHERE P.ITEMCODE='" & Trim(Itemcode) & "'AND ISNULL(M.FREEZE,'')<>'Y' ORDER BY M.POSCODE"
                                    'Sqlstring = "SELECT POSCODE,POSDESC,SALESACCTIN FROM POSMENULINK P INNER Join POSMASTER M On P.POS=M.POSCODE WHERE P.ITEMCODE ='" & Trim(Itemcode) & "' AND ISNULL(M.FREEZE,'') <>'Y' ORDER BY POSCODE"
                                    gconnection.getDataSet(Sqlstring, "PosMenuLink")
                                    If gdataset.Tables("PosMenuLink").Rows.Count = 1 Then
                                        ssGrid.Col = 3
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE")
                                        If IsDBNull(gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN")) = False Then
                                            If Trim((gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN"))) <> "" Then
                                                'Sqlstring = "SELECT ACCOUNTSGLACCOUNTMASTER WHERE ACCODE='" & Trim((gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN"))) & "'AND isnull(FREEZEFLAG,'')='Y'"
                                                'gconnection.getDataSet(Sqlstring, "VOID")
                                                'If gdataset.Tables("VOID").Rows.Count = 1 Then
                                                '    MsgBox("Account Code is FREEZED,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                                                '    ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                                '    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                                'End If

                                                'Sqlstring = "SELECT ACCOUNTSGLACCOUNTMASTER WHERE ACCODE<>'" & Trim((gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN"))) & "'"
                                                'gconnection.getDataSet(Sqlstring, "VOID")
                                                'If gdataset.Tables("VOID").Rows.Count = 0 Then
                                                '    MsgBox("Account Code is FREEZED,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                                                '    ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                                '    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                                'End If

                                                ssGrid.Col = 14
                                                ssGrid.Row = ssGrid.ActiveRow
                                                'ssGrid.Text = gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN")
                                            Else
                                                MsgBox("Account Code For The Location  " & gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE") & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                                                ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                                Exit Sub
                                            End If
                                        Else
                                            MsgBox("Account Code For The Location  " & gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE") & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                                            ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                            Exit Sub
                                        End If
                                        '''****************************** To FILL UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                                        Sqlstring = "SELECT R.UOM, R.ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                                        Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(Itemcode) & "' ) ORDER BY R.ITEMRATE,R.UOM"
                                        gconnection.getDataSet(Sqlstring, "ITEMRATE")
                                        If gdataset.Tables("ITEMRATE").Rows.Count = 1 Then
                                            ssGrid.Col = 4
                                            ssGrid.Row = ssGrid.ActiveRow
                                            ssGrid.Text = CStr(gdataset.Tables("ITEMRATE").Rows(0).Item("UOM")) & ""
                                            ssGrid.Col = 6
                                            ssGrid.Row = ssGrid.ActiveRow
                                            ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE")) & ""
                                            ''ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
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
                                            '''ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
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
                                        '''******************************  SHOW A POPUP FOR POS LOCATION ***********************''
                                        Call FillPosList(gdataset.Tables("PosMenuLink"))
                                        Me.lvw_POSCode.FullRowSelect = True
                                        pnl_POSCode.Top = 50
                                        lvw_POSCode.Focus()
                                    End If
                                    '''****************************** COMPLETE FILLING TO FILL POSCODE ******************************************************'''
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
                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                                Sqlstring = "SELECT DISTINCT I.ITEMDESC,I.ITEMCODE,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE,ISNULL(I.OPENFACILITY,'') AS OPENFACILITY,"
                                Sqlstring = Sqlstring & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,I.PROMOTIONAL,I.PROMITEMCODE FROM ITEMMASTER AS I"
                                Sqlstring = Sqlstring & " INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "
                                'Sqlstring = Sqlstring & " WHERE I.ITEMDESC = '" & Trim(Itemdesc) & "' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y'"
                                Sqlstring = Sqlstring & " WHERE I.ITEMDESC = '" & Trim(Itemdesc) & "' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE  AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y'"
                                gconnection.getDataSet(Sqlstring, "ITEMCODE")
                                If gdataset.Tables("ITEMCODE").Rows.Count > 0 Then
                                    ssGrid.SetText(1, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMCODE")) & "")
                                    Itemcode = Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMDESC")) & ""
                                    ssGrid.SetText(2, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMDESC")) & "")
                                    ssGrid.SetText(9, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMTYPECODE")) & "")
                                    ssGrid.SetText(10, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXCODE")) & "")
                                    ssGrid.SetText(11, i, Val(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXPERCENTAGE")))
                                    ssGrid.SetText(13, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ACCOUNTCODE")))
                                    ssGrid.SetText(15, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("GROUPCODE")))
                                    ssGrid.SetText(19, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")))
                                    If Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")) = "Y" Then
                                        ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                    Else
                                        ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                                    End If
                                    '''*************************** $ PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                    If Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("Promotional")) = "Y" Then

                                        Promtcode = Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PromItemcode"))

                                        'Modified on 14 Mar'08
                                        'Mk Kannan
                                        'Begin
                                        'Sqlstring = "SELECT I.PROMQTY, I.ITEMCODE,I.PROMITEMCODE, I.ITEMDESC,I.ITEMTYPECODE, P.POSCODE, P.POSDESC,I.STARTINGDATE,I.ENDINGDATE,"
                                        'Sqlstring = Sqlstring & " I.PROMUOM, I.PROMQTY, I.PROMRATE FROM ITEMMASTER AS I INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN"
                                        'Sqlstring = Sqlstring & " POSMASTER AS P ON PL.POS = P.POSCODE WHERE (I.PROMOTIONAL = 'Y') AND (I.PROMITEMCODE = '" & Promtcode & "') AND (I.ITEMCODE = '" & Itemcode & "') AND ISNULL(I.FREEZE,'') <>'Y' "
                                        Sqlstring = "SELECT I.PROMQTY, I.ITEMCODE,I.PROMITEMCODE, IM.ITEMDESC,I.ITEMTYPECODE, P.POSCODE, P.POSDESC,I.STARTINGDATE,I.ENDINGDATE,"
                                        Sqlstring = Sqlstring & " I.PROMUOM, I.PROMQTY, I.PROMRATE FROM ITEMMASTER AS I INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN"
                                        Sqlstring = Sqlstring & " POSMASTER AS P ON PL.POS = P.POSCODE "
                                        Sqlstring = Sqlstring & " INNER JOIN ITEMMASTER AS IM ON IM.ITEMCODE=I.PROMITEMCODE"
                                        Sqlstring = Sqlstring & " WHERE (I.PROMOTIONAL = 'Y') AND (I.PROMITEMCODE = '" & Promtcode & "') AND (I.ITEMCODE = '" & Itemcode & "') AND ISNULL(I.FREEZE,'') <>'Y' "
                                        'End

                                        gconnection.getDataSet(Sqlstring, "PROMOTIONAL")
                                        If CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("EndingDate")) <= CDate(serverdate.Today) And CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("StartingDate")) >= CDate(serverdate.Today) Then
                                            If gdataset.Tables("PROMOTIONAL").Rows.Count > 0 Then
                                                If MessageBox.Show("Promotional available for this ITEMCODE ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                                                    'If CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("EndingDate")) <= CDate(serverdate.Today) And CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("StartingDate")) >= CDate(serverdate.Today) Then
                                                    If CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("StartingDate")) <= CDate(serverdate.Today) And CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("EndingDate")) >= CDate(serverdate.Today) Then
                                                        ssGrid.SetText(1, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMITEMCODE")) & "")
                                                        ssGrid.SetText(2, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMDESC")) & "")
                                                        ssGrid.SetText(3, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("POSCODE")) & "")
                                                        ssGrid.SetText(4, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMUOM")) & "")
                                                        ssGrid.SetText(5, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMQTY")) & "")
                                                        ssGrid.SetText(6, i + 1, 0.0)
                                                        ssGrid.SetText(7, i + 1, 0.0)
                                                        ssGrid.SetText(8, i + 1, 0.0)
                                                        ssGrid.SetText(9, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMTYPECODE")) & "")
                                                        'Modified on 14 Mar'08
                                                        'Mk Kannan
                                                        'Begin
                                                        ssGrid.SetText(11, i + 1, 0.0)
                                                        ssGrid.SetText(17, i + 1, "Y")
                                                        boolPromotional = True
                                                        'End
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                    '''*************************** $ COMPLETE PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                    '''****************************** TO FILL POSCODE **********************************************************************'''
                                    Sqlstring = "SELECT POSCODE,POSDESC,SALESACCTIN FROM POSMENULINK P INNER Join POSMASTER M On P.POS=M.POSCODE WHERE P.ITEMCODE ='" & Trim(Itemcode) & "' AND ISNULL(M.FREEZE,'') <>'Y' ORDER BY POSCODE"
                                    gconnection.getDataSet(Sqlstring, "PosMenuLink")
                                    If gdataset.Tables("PosMenuLink").Rows.Count = 1 Then
                                        ssGrid.Col = 3
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE")
                                        If IsDBNull(gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN")) = False Then
                                            If Trim((gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN"))) <> "" Then
                                                ssGrid.Col = 14
                                                ssGrid.Row = ssGrid.ActiveRow
                                                'ssGrid.Text = gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN")
                                            Else
                                                MsgBox("Account Code For The Location  " & gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE") & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                                                ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                                Exit Sub
                                            End If
                                        Else
                                            MsgBox("Account Code For The Location  " & gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE") & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                                            ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                            Exit Sub
                                        End If
                                        '''****************************** To FILL UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                                        Sqlstring = "SELECT R.UOM, R.ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                                        Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(Itemcode) & "' ) ORDER BY R.ITEMRATE,R.UOM"
                                        gconnection.getDataSet(Sqlstring, "ITEMRATE")
                                        If gdataset.Tables("ITEMRATE").Rows.Count = 1 Then
                                            ssGrid.Col = 4
                                            ssGrid.Row = ssGrid.ActiveRow
                                            ssGrid.Text = CStr(gdataset.Tables("ITEMRATE").Rows(0).Item("UOM")) & ""
                                            ssGrid.Col = 6
                                            ssGrid.Row = ssGrid.ActiveRow
                                            ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE")) & ""
                                            ''ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                            ssGrid.Col = 19
                                            ssGrid.Row = ssGrid.ActiveRow
                                            If Trim(ssGrid.Text) = "Y" Then
                                                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                            Else
                                                ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                            End If
                                        Else
                                            ssGrid.Col = 4
                                            ssGrid.Col = 6
                                            ssGrid.Text = "0.00"
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
                                        '''******************************  SHOW A POPUP FOR POS LOCATION ***********************''
                                        Call FillPosList(gdataset.Tables("PosMenuLink"))
                                        Me.lvw_POSCode.FullRowSelect = True
                                        pnl_POSCode.Top = 50
                                        lvw_POSCode.Focus()
                                    End If
                                    '''****************************** COMPLETE FILLING TO FILL POSCODE ******************************************************'''
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
                        ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                        Exit Sub
                    Else
                        If ssGrid.Lock = False Then
                            ssGrid.Col = 1
                            varitemcode = Trim(ssGrid.Text)
                            ssGrid.Col = 3
                            varposcode = Trim(ssGrid.Text)
                            If Trim(varposcode) = "" Then
                                ssGrid.Text = ""
                                ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                                ssGrid.Focus()
                                Sqlstring = "SELECT POSCODE,POSDESC,SALESACCTIN FROM POSMENULINK P INNER Join POSMASTER M On P.POS=M.POSCODE WHERE P.ITEMCODE ='" & Trim(varitemcode) & "' AND ISNULL(M.FREEZE,'') <>'Y' ORDER BY POSCODE"
                                gconnection.getDataSet(Sqlstring, "PosMenuLink")
                                If gdataset.Tables("PosMenuLink").Rows.Count > 1 Then
                                    '''******************************  SHOW A POPUP FOR POS LOCATION ***********************''
                                    Call FillPosList(gdataset.Tables("PosMenuLink"))
                                    Me.lvw_POSCode.FullRowSelect = True
                                    pnl_POSCode.Top = 50
                                    lvw_POSCode.Focus()
                                End If
                                '''****************************** SHOW COMPLETE FOR POS LOCATION ***********************''
                                Exit Sub
                            ElseIf Trim(varposcode) <> "" Then
                                Sqlstring = "SELECT POSCODE,POSDESC,SALESACCTIN FROM POSMENULINK P INNER JOIN POSMASTER M On P.POS=M.POSCODE WHERE P.ITEMCODE ='" & Trim(varitemcode) & "' AND ISNULL(M.FREEZE,'') <>'Y' AND POSCODE = '" & Trim(CStr(varposcode)) & "' ORDER BY POSCODE"
                                gconnection.getDataSet(Sqlstring, "POSMASTER")
                                If gdataset.Tables("POSMASTER").Rows.Count = 1 Then
                                    ssGrid.Col = 3
                                    ssGrid.Row = ssGrid.ActiveRow
                                    ssGrid.Text = gdataset.Tables("POSMASTER").Rows(0).Item("POSCODE")
                                    If IsDBNull(gdataset.Tables("POSMASTER").Rows(0).Item("SALESACCTIN")) = False Then
                                        If Trim((gdataset.Tables("POSMASTER").Rows(0).Item("SALESACCTIN"))) <> "" Then
                                            ssGrid.Col = 14
                                            ssGrid.Row = ssGrid.ActiveRow
                                            'ssGrid.Text = gdataset.Tables("POSMASTER").Rows(0).Item("SALESACCTIN")
                                        Else
                                            MsgBox("Account Code For The Location  " & gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE") & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                                            ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                            Exit Sub
                                        End If
                                    Else
                                        MsgBox("Account Code For The Location  " & gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE") & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                                        ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                        ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                        Exit Sub
                                    End If
                                Else
                                    MessageBox.Show("!! Oop's specified POSCODE is not valid ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                    ssGrid.Text = ""
                                    ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                                    ssGrid.Focus()
                                    Sqlstring = "SELECT POSCODE,POSDESC,SALESACCTIN FROM POSMENULINK P INNER Join POSMASTER M On P.POS=M.POSCODE WHERE P.ITEMCODE ='" & Trim(varitemcode) & "' AND ISNULL(M.FREEZE,'') <>'Y' ORDER BY POSCODE"
                                    gconnection.getDataSet(Sqlstring, "PosMenuLink")
                                    If gdataset.Tables("PosMenuLink").Rows.Count > 1 Then
                                        '''******************************  SHOW A POPUP FOR POS LOCATION ***********************''
                                        Call FillPosList(gdataset.Tables("PosMenuLink"))
                                        Me.lvw_POSCode.FullRowSelect = True
                                        pnl_POSCode.Top = 50
                                        lvw_POSCode.Focus()
                                    End If
                                    '''****************************** SHOW COMPLETE FOR POS LOCATION ***********************''
                                    Exit Sub
                                End If
                            End If
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
                                Sqlstring = "SELECT R.UOM, R.ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                                Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(varitemcode) & "' ) ORDER BY R.ITEMRATE,R.UOM"
                                gconnection.getDataSet(Sqlstring, "ITEMRATE")
                                If gdataset.Tables("ITEMRATE").Rows.Count = 1 Then
                                    ssGrid.Col = 4
                                    ssGrid.Row = ssGrid.ActiveRow
                                    ssGrid.Text = CStr(gdataset.Tables("ITEMRATE").Rows(0).Item("UOM")) & ""
                                    ''ssGrid.Col = 6
                                    ''ssGrid.Row = ssGrid.ActiveRow
                                    ''ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE")) & ""
                                    ''ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                    ssGrid.Col = 19
                                    ssGrid.Row = ssGrid.ActiveRow
                                    If Trim(ssGrid.Text) = "Y" Then
                                        ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                    Else
                                        ssGrid.Col = 6
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE")) & ""
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
                                ssGrid.Col = 17
                                ssGrid.Row = ssGrid.ActiveRow()
                                If (ssGrid.Text) <> "Y" Then
                                    Sqlstring = "SELECT R.UOM, R.ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                                    Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(varitemcode) & "' ) AND R.ITEMRATE = " & Val(varitemrate) & " ORDER BY R.ITEMRATE,R.UOM"
                                    gconnection.getDataSet(Sqlstring, "RATEMASTER")
                                    If gdataset.Tables("RATEMASTER").Rows.Count > 0 Then
                                        If gdataset.Tables("RATEMASTER").Rows.Count = 1 Then
                                            ssGrid.Col = 4
                                            ssGrid.Row = ssGrid.ActiveRow
                                            ssGrid.Text = CStr(gdataset.Tables("RATEMASTER").Rows(0).Item("UOM")) & ""
                                            'ssGrid.Col = 6
                                            'ssGrid.Row = ssGrid.ActiveRow
                                            'ssGrid.Text = Val(gdataset.Tables("RATEMASTER").Rows(0).Item("ITEMRATE")) & ""
                                            'ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                            ssGrid.Col = 19
                                            ssGrid.Row = ssGrid.ActiveRow
                                            If Trim(ssGrid.Text) = "Y" Then
                                                ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                            Else
                                                ssGrid.Col = 6
                                                ssGrid.Row = ssGrid.ActiveRow
                                                ssGrid.Text = Val(gdataset.Tables("RATEMASTER").Rows(0).Item("ITEMRATE")) & ""
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
                    End If
                ElseIf ssGrid.ActiveCol = 5 Then
                    Dim ITEMQTY As Integer
                    Dim PROMAMT As Double
                    Dim CHECK_AVAILABILITY As Integer
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
                                        'GPS  PROMOTIONAL
                                        '''*************************** $ PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                        ssGrid.Col = 1
                                        ssGrid.Row = ssGrid.ActiveRow
                                        Itemcode = Trim(ssGrid.Text)
                                        Sqlstring = " SELECT ISNULL(Promotional,'') AS Promotional FROM ITEMMASTER WHERE ITEMCODE='" & Itemcode & "'"
                                        gconnection.getDataSet(Sqlstring, "ITEMCODE1")
                                        If gdataset.Tables("ITEMCODE1").Rows.Count > 0 Then
                                            If Trim(gdataset.Tables("ITEMCODE1").Rows(j).Item("Promotional")) = "Y" Then
                                                ssGrid.Col = 1
                                                ssGrid.Row = i
                                                Itemcode = Trim(ssGrid.Text)


                                                Sqlstring = "SELECT DISTINCT I.ITEMDESC,I.ITEMCODE,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE,ISNULL(I.OPENFACILITY,'') AS OPENFACILITY,"
                                                Sqlstring = Sqlstring & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,I.PROMOTIONAL,I.PROMITEMCODE FROM ITEMMASTER AS I"
                                                Sqlstring = Sqlstring & " INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "
                                                Sqlstring = Sqlstring & " WHERE I.ITEMDESC = '" & Trim(Itemdesc) & "' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y'"
                                                gconnection.getDataSet(Sqlstring, "ITEMCODE")
                                                If gdataset.Tables("ITEMCODE").Rows.Count > 0 Then
                                                    Promtcode = Trim(gdataset.Tables("ITEMCODE").Rows(0).Item("PromItemcode"))
                                                End If
                                                ssGrid.Row = ssGrid.ActiveRow
                                                ssGrid.Col = 1
                                                Itemcode = Trim(ssGrid.Text)
                                                'Modified on 14 Mar'08
                                                'Mk Kannan
                                                'Begin
                                                'Sqlstring = "SELECT I.PROMQTY, I.ITEMCODE,I.PROMITEMCODE,I.ITEMDESC,I.ITEMTYPECODE, P.POSCODE, P.POSDESC,I.STARTINGDATE,I.ENDINGDATE,"
                                                'Sqlstring = Sqlstring & " I.PROMUOM, I.PROMQTY, I.PROMRATE FROM ITEMMASTER AS I INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN"
                                                'Sqlstring = Sqlstring & " POSMASTER AS P ON PL.POS = P.POSCODE "                                        
                                                'Sqlstring = Sqlstring & " WHERE (I.PROMOTIONAL = 'Y') AND (I.PROMITEMCODE = '" & Promtcode & "') AND (I.ITEMCODE = '" & Itemcode & "') AND ISNULL(I.FREEZE,'') <>'Y' "
                                                Sqlstring = "SELECT I.PROMQTY, I.ITEMCODE,I.PROMITEMCODE, IM.ITEMDESC, IM.GROUPCODE, I.ITEMTYPECODE, P.POSCODE, P.POSDESC,I.STARTINGDATE,I.ENDINGDATE,ISNULL(I.PROMTYPE,'') AS PROMTYPE,"
                                                Sqlstring = Sqlstring & " I.PROMUOM, I.PROMQTY,I.BASEQTY , I.PROMRATE FROM ITEMMASTER AS I INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN"
                                                Sqlstring = Sqlstring & " POSMASTER AS P ON PL.POS = P.POSCODE "
                                                Sqlstring = Sqlstring & " INNER JOIN ITEMMASTER AS IM ON IM.ITEMCODE=I.PROMITEMCODE"
                                                Sqlstring = Sqlstring & " WHERE (I.PROMOTIONAL = 'Y') AND (I.PROMITEMCODE = '" & Promtcode & "') AND (I.ITEMCODE = '" & Itemcode & "') AND ISNULL(I.FREEZE,'') <>'Y' "
                                                Sqlstring = Sqlstring & " AND  '" & Format(CDate(serverdate), "dd/MMM/yyyy") & "' BETWEEN I.StartingDate AND I.EndingDate "
                                                'CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("StartingDate")) <= CDate(serverdate.Today) And CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("EndingDate")) >= CDate(serverdate.Today)
                                                'End
                                                gconnection.getDataSet(Sqlstring, "PROMOTIONAL")
                                                ssGrid.Row = ssGrid.ActiveRow
                                                ssGrid.Col = 5
                                                Trim(ssGrid.Text)
                                                'If Trim(ssGrid.Text) = Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("BASEQTY")) Then
                                                'PROQTY_GRID = Val(Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMQTY")))
                                                If gdataset.Tables("PROMOTIONAL").Rows.Count > 0 Then
                                                    If Val(Trim(ssGrid.Text)) >= Val(Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("BASEQTY"))) Then
                                                        PROQTY_GRID = Val(Math.Floor(Trim(ssGrid.Text) / Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("BASEQTY"))) * Val(Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMQTY"))))
                                                        If gdataset.Tables("PROMOTIONAL").Rows.Count > 0 Then
                                                            If MessageBox.Show("Promotional available for this Itemcode!", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                                                                'If Format(CDate(serverdate), "dd/MM/yyyy") = Format(CDate(dtp_KOTdate.Value), "dd/MM/yyyy") Then
                                                                If CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("StartingDate")) <= CDate(serverdate.Today) And CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("EndingDate")) >= CDate(serverdate.Today) Then
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
                                                                    If Trim(UCase(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMTYPE"))) = "RATE" Then
                                                                        ssGrid.SetText(6, i, Val(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMRATE")))
                                                                        ssGrid.Row = i
                                                                        ssGrid.Col = 5
                                                                        If Val(ssGrid.Text) > 0 Then
                                                                            ITEMQTY = Val(ssGrid.Text)
                                                                            PROMAMT = Val((ITEMQTY * Val(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMRATE"))))
                                                                            ssGrid.SetText(8, i, PROMAMT)
                                                                            ssGrid.SetText(17, i, "Y")
                                                                            boolPromotional = True
                                                                            Call Calculate()
                                                                        End If
                                                                    Else
                                                                        ssGrid.SetText(1, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMITEMCODE")) & "")
                                                                        ssGrid.SetText(2, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMDESC")) & "")
                                                                        ssGrid.SetText(3, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("POSCODE")) & "")
                                                                        ssGrid.SetText(4, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMUOM")) & "")
                                                                        'ssGrid.SetText(5, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMQTY")) & "")
                                                                        ssGrid.SetText(5, i + 1, Val(PROQTY_GRID))
                                                                        ssGrid.SetText(6, i + 1, 0.0)
                                                                        ssGrid.SetText(7, i + 1, 0.0)
                                                                        ssGrid.SetText(8, i + 1, 0.0)
                                                                        ssGrid.SetText(9, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMTYPECODE")) & "")
                                                                        ssGrid.SetText(11, i + 1, 0.0)
                                                                        ssGrid.SetText(15, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("GROUPCODE")) & "")
                                                                        ssGrid.SetText(17, i + 1, "Y")
                                                                        boolPromotional = True
                                                                    End If
                                                                    'Modified on 14 Mar'08
                                                                    'Mk Kannan
                                                                    'Begin
                                                                    'End
                                                                End If
                                                                'End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
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
                                        If boolPromotional = True Then
                                            ssGrid.Row = ssGrid.ActiveRow + 1
                                        Else
                                            ssGrid.Row = ssGrid.ActiveRow + 1
                                        End If
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
                                        If boolPromotional = True Then
                                            If PROMAMT > 0 Then
                                                ssGrid.SetActiveCell(0, ssGrid.ActiveRow)
                                            Else
                                                ssGrid.SetActiveCell(0, ssGrid.ActiveRow + 1)
                                            End If
                                        Else
                                            ssGrid.SetActiveCell(0, ssGrid.ActiveRow + 1)
                                        End If
                                        'boolPromotional = False
                                    End If
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
                'ElseIf e.keyCode = Keys.F3 And Mid(Cmd_Add.Text, 1, 3) = "Add" Then
            ElseIf e.keyCode = Keys.F3 Then
                ssGrid.Col = 3
                ssGrid.Row = ssGrid.ActiveRow
                If ssGrid.ActiveCol = 3 Then
                    If ssGrid.Lock = False Then
                        Itemcode = Nothing
                        i = ssGrid.ActiveRow
                        ssGrid.Col = 1
                        ssGrid.Row = i
                        Itemcode = Trim(ssGrid.Text)
                        Sqlstring = "SELECT POSCODE,POSDESC,SALESACCTIN FROM POSMENULINK P INNER JOIN POSMASTER M ON P.POS=M.POSCODE WHERE P.ITEMCODE='" & Trim(Itemcode) & "' ORDER BY POSCODE"
                        gconnection.getDataSet(Sqlstring, "POSMENULINK")
                        If gdataset.Tables("POSMENULINK").Rows.Count > 0 Then
                            If gdataset.Tables("POSMENULINK").Rows.Count > 1 Then
                                ssGrid.Col = 3
                                ssGrid.Row = i
                                Call FillPosList(gdataset.Tables("PosMenuLink"))
                                Me.lvw_POSCode.FullRowSelect = True
                                pnl_POSCode.Top = 50
                                pnl_POSCode.Focus()
                                lvw_POSCode.Focus()
                            Else
                                ssGrid.Col = 3
                                ssGrid.Row = ssGrid.ActiveRow
                                ssGrid.Text = gdataset.Tables("POSMENULINK").Rows(0).Item("POSCODE")
                                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                            End If
                        Else
                            ssGrid.Col = 1
                            ssGrid.Row = ssGrid.ActiveRow
                            ssGrid.Focus()
                        End If
                    End If
                ElseIf ssGrid.ActiveCol = 4 Then
                    ssGrid.Col = 4
                    ssGrid.Row = ssGrid.ActiveRow
                    If ssGrid.Lock = False Then
                        Itemcode = Nothing
                        i = ssGrid.ActiveRow
                        ssGrid.Col = 1
                        ssGrid.Row = i
                        Itemcode = Trim(ssGrid.Text)
                        Sqlstring = "SELECT R.UOM, R.ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                        Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(Itemcode) & "' ) ORDER BY R.ITEMRATE,R.UOM"
                        gconnection.getDataSet(Sqlstring, "ITEMRATE")
                        If gdataset.Tables("ITEMRATE").Rows.Count > 0 Then
                            If gdataset.Tables("ITEMRATE").Rows.Count > 1 Then
                                ssGrid.Col = 4
                                ssGrid.Row = i
                                Call FillUomList(gdataset.Tables("ITEMRATE"))
                                Me.lvw_Uom.FullRowSelect = True
                                pnl_UOMCode.Top = 50
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
                ElseIf ssGrid.ActiveCol = 1 Then
                    'End If

                    'AS PER SIVAJI REQUIREMENT  ON 05/05/2008 WE ARE BLOCKING THEIS FUNCTION
                    ' ElseIf e.keyCode = Keys.F12 Then
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
                If boolPromotional = True Then
                    ssGrid.Col = 1
                    ssGrid.Row = ssGrid.ActiveRow
                    ssGrid.Focus()
                End If
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
        Try
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
                    strstring = "Select roomno,guest,docno From roomcheckin Where isnull(checkout,'') <> 'Y' and roomstatus='occupied' AND RoomNo='" & Trim(txt_MemberCode.Text) & "'"
                    gconnection.getDataSet(strstring, "RoomCheckin")
                    If gdataset.Tables("RoomCheckin").Rows.Count > 0 Then
                        txt_MemberCode.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("RoomNo")
                        txt_MemberName.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("Guest")
                        txt_MemberCode.Tag = gdataset.Tables("RoomCheckin").Rows(0).Item("docno")
                        txt_ServerCode.Focus()
                    Else
                        txt_MemberCode.Text = ""
                        ''txt_MemberCode.Focus()
                    End If
                    'club
                    '03/05/2008
                ElseIf cbo_PaymentMode.Text = "CLUB" Then
                    strstring = "SELECT slcode,slname FROM accountssubledgermaster WHERE SLCODE='" & Trim(txt_MemberCode.Text) & "'"
                    gconnection.getDataSet(strstring, "RoomCheckin")
                    If gdataset.Tables("RoomCheckin").Rows.Count > 0 Then
                        txt_MemberCode.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("slcode")
                        txt_MemberName.Text = gdataset.Tables("RoomCheckin").Rows(0).Item("slname")
                        txt_MemberCode.Tag = gdataset.Tables("RoomCheckin").Rows(0).Item("slcode")
                        If txt_ServerCode.Text <> "" Then
                            ssGrid.Focus()
                        Else
                            txt_ServerCode.Focus()
                        End If
                    Else
                        txt_MemberCode.Text = ""
                        txt_MemberName.Text = ""
                        '''txt_MemberCode.Focus()
                    End If
                Else
                    'PHOTOFILENAME = STRPHOTOPATH & "\" & Mid(Trim(txt_MemberCode.Text), 1, Len(Trim(txt_MemberCode.Text))) & ".jpg"
                    'PHOTOFILENAME = Replace(PHOTOFILENAME, " ", "")
                    'If File.Exists(PHOTOFILENAME) Then
                    '    Pic_Member.Image = New Bitmap(PHOTOFILENAME)
                    'Else
                    '    Pic_Member.Image = Nothing
                    'End If
                    strstring = "SELECT * FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' AND CURENTSTATUS='LIVE'"
                    gconnection.getDataSet(strstring, "membermaster")
                    If gdataset.Tables("membermaster").Rows.Count > 0 Then
                        txt_MemberCode.Text = gdataset.Tables("membermaster").Rows(0).Item("MCODE")
                        txt_MemberName.Text = gdataset.Tables("membermaster").Rows(0).Item("MNAME")
                        txt_ServerCode.Focus()
                        If Cmd_Add.Text = "Add [F7]" And txt_MemberCode.Text <> "" Then
                            Call outstanding()
                        End If
                    Else
                        txt_MemberCode.Text = ""
                        'txt_MemberCode.Focus()
                    End If
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
                        cmd_Clear_Click(sender, e)
                        Exit Sub
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function outstanding()
        Try
            lab_outstanding.Text = "0.00"
            MemberOutstand = 0
            'If Trim(CMB_BTYPE.Text) = "RES" Then
            '    SQLSTRING = " SELECT SLCODE,ISNULL((SUM(DR)-SUM(CR)) - SUM(BALANCE),0) AS AMOUNT FROM VW_CLOSINGBALANCE_BARBALANCE  "
            '    SQLSTRING = SQLSTRING & " WHERE SLCODE='" & Trim(txt_MemberCode.Text) & "'"
            '    SQLSTRING = SQLSTRING & " GROUP BY SLCODE HAVING(((SUM(DR)-SUM(CR)) - SUM(BALANCE))>0)"
            'Else
            '    SQLSTRING = " SELECT  ISNULL(SUM(ISNULL(BALANCE,0)),0) AS AMOUNT FROM CREDIT_LIMIT WHERE SLCODE='" & txt_MemberCode.Text & "' AND VOUCHERTYPE='BAR' --and voucherdate<='" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "'"
            'End If
            'gconnection.getDataSet(SQLSTRING, "Outstand")
            'If gdataset.Tables("Outstand").Rows.Count > 0 Then
            '    lab_outstanding.Text = "MEMBER OUTSTANDING :" & Format(Val(gdataset.Tables("outstand").Rows(0).Item("amount")), "0.00")
            '    MemberOutstand = Val(gdataset.Tables("outstand").Rows(0).Item("amount"))
            'End If

            'SQLSTRING = " SELECT SLCODE,ISNULL(SUM(DRAMOUNT-CRAMOUNT),0) AS AMOUNT FROM credit_limit WHERE SLCODE='" & txt_MemberCode.Text & "' GROUP BY SLCODE "
            'gconnection.getDataSet(SQLSTRING, "Outstand")
            'If gdataset.Tables("Outstand").Rows.Count > 0 Then
            '    lab_outstanding.Text = "MEMBER OUTSTANDING :" & Format(Val(gdataset.Tables("outstand").Rows(0).Item("amount")), "0.00")
            '    MemberOutstand = Val(gdataset.Tables("outstand").Rows(0).Item("amount"))
            'End If
        Catch ex As Exception
        End Try
    End Function
    Private Sub txt_ServerCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ServerCode.Validated
        Dim strstring, strsql As String
        Dim I As Integer
        If Trim(txt_ServerCode.Text) <> "" Then

            'strsql = "SELECT * FROM KOT_HDR WHERE KOTDETAILS='" & Trim(txt_KOTno.Text) & "'"
            'gconnection.getDataSet(STRSQL, "KOTNO")
            'If gdataset.Tables("KOTNO").Rows.Count = 0 Then

            strstring = "SELECT * FROM servermaster WHERE ServerCode='" & Trim(txt_ServerCode.Text) & "'AND ISNULL(Freeze,'')<>'Y'"

            gconnection.getDataSet(strstring, "servermaster")

            If gdataset.Tables("servermaster").Rows.Count > 0 Then
                txt_ServerCode.Text = gdataset.Tables("servermaster").Rows(0).Item("ServerCode")
                txt_ServerName.Text = gdataset.Tables("servermaster").Rows(0).Item("ServerName")
                If txt_LOCATIONCODE.Text <> "" Then
                    ssGrid.SetActiveCell(1, 1)
                    ssGrid.Focus()
                Else
                    txt_LOCATIONCODE.Focus()
                End If
            Else
                txt_ServerCode.Text = ""
                txt_ServerCode.Focus()
            End If
            'End If
        Else
            'txt_ServerCode.Focus()
        End If
    End Sub
    Private Sub FillMenu()
        Dim vform As New ListOperattion1
        Dim ssql As String
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = "SELECT DISTINCT I.ITEMCODE,I.ITEMDESC,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE, ISNULL(TL.ACCOUNTCODE,'') "
        gSQLString = gSQLString & " AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN FROM ITEMMASTER AS I INNER "
        gSQLString = gSQLString & " JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE  AND ISNULL(I.FREEZE,'') <>'Y'"

        'gSQLString = "SELECT DISTINCT I.ITEMDESC,I.ITEMCODE,I.BASERATESTD,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE, ISNULL(TL.ACCOUNTCODE,'') "
        'gSQLString = gSQLString & " AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.OPENFACILITY,'') AS OPENFACILITY,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN FROM ITEMMASTER AS I INNER "
        'gSQLString = gSQLString & " JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "

        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Search & "%' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE AND ISNULL(TL.ENDINGDATE,getdate()) AND ISNULL(I.FREEZE,'') <>'Y' "
        End If
        vform.Field = "ITEMCODE,ITEMDESC"
        vform.vFormatstring = "  ITEMCODE           |                 ITEMDESC                         |  ITEMTYPE  |  TAXCODE  | TAXPERCENTAGE | ACCOUNTCODE |  GROUPCODE  |SALESACCTIN|"
        vform.vCaption = "ITEM CODE HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.Keypos3 = 3
        vform.keypos4 = 4
        vform.Keypos5 = 5
        vform.Keypos6 = 6
        vform.Keypos7 = 7
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssGrid
                .Col = 1
                .Row = .ActiveRow
                .Text = vform.keyfield
                .Col = 2
                .Row = .ActiveRow
                .Text = vform.keyfield1
                .Col = 9
                .Row = .ActiveRow
                .Text = vform.keyfield2
                .Col = 10
                .Row = .ActiveRow
                .Text = vform.keyfield3
                .Col = 11
                .Row = .ActiveRow
                .Text = vform.keyfield4
                .Col = 13
                .Row = .ActiveRow
                .Text = vform.keyfield5

                .Col = 14
                .Row = .ActiveRow
                .Text = vform.keyfield7

                .Col = 15
                .Row = .ActiveRow
                .Text = vform.keyfield6
            End With
        Else
            ssGrid.SetActiveCell(0, ssGrid.ActiveRow)
            Exit Sub
        End If
        If Trim(vform.keyfield) <> "" Then
            '''*********************************************** $ FILL POSCODE INTO SSGRID $ *********************************************'''
            ssql = "SELECT M.POSCODE,M.POSDESC,N.SALESACCTIN FROM POSMENULINK P INNER JOIN POSMASTER M ON P.POS=M.POSCODE INNER JOIN ITEMMASTER N ON P.ITEMCODE=N.ITEMCODE WHERE P.ITEMCODE='" & vform.keyfield & "'AND ISNULL(M.FREEZE,'')<>'Y' ORDER BY M.POSCODE"
            gconnection.getDataSet(ssql, "PosMenuLink")
            If gdataset.Tables("PosMenuLink").Rows.Count > 1 Then
                '''***************************************** $ SHOW POPUP FOR VARIOUS UOM $ ******************************************************''
                Call FillPosList(gdataset.Tables("PosMenuLink"))
                Me.lvw_POSCode.FullRowSelect = True
                pnl_POSCode.Top = 50
                lvw_POSCode.Focus()
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
            Else
                ssGrid.Col = 3
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Text = gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE")
                If IsDBNull(gdataset.Tables("PosMenuLink").Rows(0).Item(2)) = False Then
                    If Trim((gdataset.Tables("PosMenuLink").Rows(0).Item(2))) <> "" Then
                        ssGrid.Col = 14
                        ssGrid.Row = ssGrid.ActiveRow
                        ssGrid.Text = gdataset.Tables("PosMenuLink").Rows(0).Item(2)
                    Else
                        MsgBox("Account Code For The Location  " & gdataset.Tables("PosMenuLink").Rows(0).Item(0) & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                        ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                        ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                        Exit Sub
                    End If
                Else
                    MsgBox("Account Code For The Location  " & gdataset.Tables("PosMenuLink").Rows(0).Item(0) & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                    ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                    Exit Sub
                End If
                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
            End If
            '''************************************************* $ FILL UOM , RATE INTO SSGRID $ **************************************************'''
            gSQLString = "SELECT ISNULL(R.UOM,'') AS UOM, ISNULL(R.ITEMRATE,0) AS ITEMRATE "
            gSQLString = gSQLString & " FROM ITEMMASTER AS I INNER JOIN "
            gSQLString = gSQLString & " RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
            gSQLString = gSQLString & "WHERE (R.ENDINGDATE IS NULL) AND (I.ITEMCODE = '" & Trim(vform.keyfield) & "' ) ORDER BY R.ITEMRATE,R.UOM"
            gconnection.getDataSet(gSQLString, "ITEMRATE")
            If gdataset.Tables("ITEMRATE").Rows.Count > 1 Then
                Call FillUomList(gdataset.Tables("ITEMRATE"))
                If ssGrid.ActiveCol = 5 Then
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
                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
            End If
            '''**************************************************** $ PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''

            gSQLString = "SELECT promitemcode,itemmaster.itemdesc,promotional,promuom,promqty,promrate, "
            gSQLString = gSQLString & "posmenulink.pos FROM itemmaster INNER JOIN posmenulink on itemmaster.itemcode=posmenulink.itemcode "
            gSQLString = gSQLString & "WHERE itemmaster.itemcode='" & vform.keyfield & "' "
            gconnection.getDataSet(gSQLString, "Promotional")

            If Trim(gdataset.Tables("Promotional").Rows(0).Item("Promotional")) = "Y" Then

                'Modified on 14 Mar'08
                'Mk Kannan
                'Begin
                gSQLString = "SELECT I.PROMQTY, I.ITEMCODE,I.PROMITEMCODE, IM.ITEMDESC,I.ITEMTYPECODE, P.POSCODE, P.POSDESC,I.STARTINGDATE,I.ENDINGDATE,"
                gSQLString = gSQLString & " I.PROMUOM, I.PROMQTY, I.PROMRATE FROM ITEMMASTER AS I INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN"
                gSQLString = gSQLString & " POSMASTER AS P ON PL.POS = P.POSCODE "
                gSQLString = gSQLString & " INNER JOIN ITEMMASTER AS IM ON IM.ITEMCODE=I.PROMITEMCODE"
                gSQLString = gSQLString & " WHERE (I.PROMOTIONAL = 'Y') AND (I.PROMITEMCODE = '" & gdataset.Tables("Promotional").Rows(0).Item("promitemcode") & "') AND (I.ITEMCODE = '" & vform.keyfield & "') AND ISNULL(I.FREEZE,'') <>'Y' "
                'gSQLString = "SELECT dbo.ItemMaster.PromQty, dbo.ItemMaster.ItemCode,dbo.ItemMaster.PromItemcode, dbo.ItemMaster.ItemDesc,dbo.ItemMaster.ItemTypecode, dbo.POSMaster.POSCode, dbo.POSMaster.POSDesc,dbo.ItemMaster.StartingDate,dbo.ItemMaster.EndingDate,"
                'gSQLString = gSQLString & " dbo.ItemMaster.PromUOM, dbo.ItemMaster.PromQty, dbo.ItemMaster.PromRate FROM dbo.ItemMaster INNER JOIN dbo.POSMenulink ON dbo.ItemMaster.ItemCode = dbo.POSMenulink.ItemCode INNER JOIN"
                'gSQLString = gSQLString & " dbo.POSMaster ON dbo.POSMenulink.Pos = dbo.POSMaster.POSCode WHERE (dbo.ItemMaster.Promotional = 'Y') AND (dbo.ItemMaster.PromItemcode = '" & gdataset.Tables("Promotional").Rows(0).Item("promitemcode") & "') AND (dbo.ItemMaster.itemcode = '" & vform.keyfield & "') "
                'End

                gconnection.getDataSet(gSQLString, "Promotional")
                If gdataset.Tables("Promotional").Rows.Count > 0 Then
                    If MessageBox.Show("Promotional available for this ITEMCODE ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                        If CDate(gdataset.Tables("Promotional").Rows(0).Item("EndingDate")) <= CDate(serverdate.Today) And CDate(gdataset.Tables("Promotional").Rows(0).Item("StartingDate")) >= CDate(serverdate.Today) Then
                            ssGrid.SetText(1, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("PromItemcode")) & "")
                            ssGrid.SetText(2, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("ItemDesc")) & "")
                            ssGrid.SetText(3, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("POSCode")) & "")
                            ssGrid.SetText(4, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("PromUOM")) & "")
                            ssGrid.SetText(5, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("PromQty")) & "")
                            ssGrid.SetText(6, ssGrid.ActiveRow + 1, 0.0)
                            ssGrid.SetText(7, ssGrid.ActiveRow + 1, 0.0)
                            ssGrid.SetText(8, ssGrid.ActiveRow + 1, 0.0)
                            ssGrid.SetText(9, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("ItemTypecode")) & "")
                            'Modified on 14 Mar'08
                            'Mk Kannan
                            'Begin
                            ssGrid.SetText(11, ssGrid.ActiveRow + 1, 0.0)
                            boolPromotional = True
                            ssGrid.SetText(17, ssGrid.ActiveRow + 1, "Y")
                            'End
                        End If
                    End If
                End If
            End If
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub FillMenuItem()
        Dim vform As New ListOperattion1
        Dim ssql As String
        '''******************************************************** $ FILL THE ITEMDESC,ITEMCODE INTO SSGRID ********** 
        gSQLString = "SELECT DISTINCT I.ITEMDESC,I.ITEMCODE,I.BASERATESTD,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE, ISNULL(TL.ACCOUNTCODE,'') "
        gSQLString = gSQLString & " AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.OPENFACILITY,'') AS OPENFACILITY,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN FROM ITEMMASTER AS I INNER "
        gSQLString = gSQLString & " JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE  AND ISNULL(I.FREEZE,'') <>'Y' "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE I.ITEMDESC LIKE '%" & Search & "%' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE AND ISNULL(TL.ENDINGDATE,getdate()) AND ISNULL(I.FREEZE,'') <>'Y'"
        End If
        vform.Field = "ITEMDESC,ITEMCODE"
        vform.vFormatstring = "                     ITEMDESC                          |      ITEMCODE        | RATE    |  ITEMTYPE  |  TAXCODE  | TAXPERCENTAGE | TAX.ACCOUNTCODE |  GROUPCODE   | OPENFACILITY | SALESACCTIN|"
        vform.vCaption = "ITEM DESC HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 3
        vform.Keypos3 = 4
        vform.keypos4 = 5
        vform.Keypos5 = 6
        vform.Keypos6 = 7
        vform.Keypos7 = 8
        vform.Keypos8 = 9
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssGrid
                .Col = 2
                .Row = .ActiveRow
                .Text = CStr(vform.keyfield)
                .Col = 1
                .Row = .ActiveRow
                .Text = CStr(vform.keyfield1)
                .Col = 9
                .Row = .ActiveRow
                .Text = vform.keyfield2
                .Col = 10
                .Row = .ActiveRow
                .Text = vform.keyfield3
                'Moified on 07 Apr'08 for avoiding wrongly Tax Percentage
                'Mk Kannan
                'Begin
                '.Col = 11
                '.Row = .ActiveRow
                '.Text = vform.keyfield6
                '.Col = 13
                '.Row = .ActiveRow
                '.Text = vform.keyfield4
                '.Col = 15
                '.Row = .ActiveRow
                '.Text = vform.keyfield5
                .Col = 19
                .Row = .ActiveRow
                .Text = vform.keyfield7

                .Col = 11
                .Row = .ActiveRow
                .Text = vform.keyfield4
                .Col = 13
                .Row = .ActiveRow
                .Text = vform.keyfield5
                .Col = 14
                .Row = .ActiveRow
                .Text = vform.keyfield8
                .Col = 15
                .Row = .ActiveRow
                .Text = vform.keyfield6

                If Trim(CStr(vform.keyfield7)) = "Y" Then
                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                Else
                    ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                End If
                'End
            End With
        Else
            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
            Exit Sub
        End If
        If Trim(vform.keyfield1) <> "" Then
            '''*********************************************** $ FILL POSCODE INTO SSGRID $ ********************************************************'''
            'ssql = "SELECT POSCODE,POSDESC,SALESACCTIN FROM POSMENULINK P INNER JOIN POSMASTER M ON P.POS=M.POSCODE WHERE ITEMCODE='" & vform.keyfield1 & "'AND ISNULL(M.FREEZE,'')<>'Y' ORDER BY POSCODE"
            ssql = "SELECT M.POSCODE,M.POSDESC,N.SALESACCTIN FROM POSMENULINK P INNER JOIN POSMASTER M ON P.POS=M.POSCODE INNER JOIN ITEMMASTER N ON P.ITEMCODE=N.ITEMCODE WHERE P.ITEMCODE='" & vform.keyfield1 & "'AND ISNULL(M.FREEZE,'')<>'Y' ORDER BY M.POSCODE"
            gconnection.getDataSet(ssql, "POSMENULINK")
            If gdataset.Tables("PosMenuLink").Rows.Count > 1 Then
                '''***************************************** $ SHOW POPUP FOR VARIOUS POS LOC $ ******************************************************''
                Call FillPosList(gdataset.Tables("POSMENULINK"))
                Me.lvw_POSCode.FullRowSelect = True
                pnl_POSCode.Top = 50
                lvw_POSCode.Focus()
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
            Else
                ssGrid.Col = 3
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Text = gdataset.Tables("POSMENULINK").Rows(0).Item("POSCODE")
                If IsDBNull(gdataset.Tables("POSMENULINK").Rows(0).Item(2)) = False Then
                    If Trim((gdataset.Tables("POSMENULINK").Rows(0).Item(2))) <> "" Then
                        ssGrid.Col = 14
                        ssGrid.Row = ssGrid.ActiveRow
                        ssGrid.Text = gdataset.Tables("POSMENULINK").Rows(0).Item(2)
                        ssGrid.Text = vform.keyfield8
                    Else
                        MsgBox("Account Code For The Location  " & gdataset.Tables("POSMENULINK").Rows(0).Item(0) & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                        ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                        ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                        Exit Sub
                    End If
                Else
                    MsgBox("Account Code For The Location  " & gdataset.Tables("POSMENULINK").Rows(0).Item(0) & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                    ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                    Exit Sub
                End If
                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
            End If
            '''************************************************* $ FILL UOM , RATE INTO SSGRID $ **************************************************'''
            gSQLString = "SELECT R.UOM, R.ItemRate "
            gSQLString = gSQLString & "FROM ItemMaster AS I INNER JOIN "
            gSQLString = gSQLString & "RateMaster AS R ON I.ItemCode = R.ItemCode "
            gSQLString = gSQLString & "WHERE (R.EndingDate IS NULL) AND (I.ItemCode = '" & Trim(vform.keyfield1) & "' ) AND ISNULL(I.freeze,'')<>'Y' ORDER BY R.ITEMRATE,R.UOM"
            gconnection.getDataSet(gSQLString, "ItemRate")
            If gdataset.Tables("ItemRate").Rows.Count > 1 Then
                Call FillUomList(gdataset.Tables("ItemRate"))
                If ssGrid.ActiveCol = 5 Then
                    '''***************************************** $ SHOW POPUP FOR VARIOUS UOM $ ******************************************************''
                    Me.lvw_Uom.FullRowSelect = True
                    pnl_UOMCode.Top = 50
                    Me.lvw_Uom.Focus()
                End If
            Else
                ssGrid.Col = 4
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Text = gdataset.Tables("ItemRate").Rows(0).Item("UOM")
                ssGrid.Col = 6
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Text = gdataset.Tables("ItemRate").Rows(0).Item("ItemRate")
                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
            End If
            '''**************************************************** $ PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
            gSQLString = "SELECT promitemcode,itemmaster.itemdesc,promotional,promuom,promqty,promrate, "
            gSQLString = gSQLString & " posmenulink.pos FROM itemmaster INNER JOIN posmenulink on itemmaster.itemcode=posmenulink.itemcode "
            gSQLString = gSQLString & "WHERE itemmaster.itemcode='" & vform.keyfield1 & "' AND ISNULL(ItemMaster.freeze,'')<>'Y'"
            gconnection.getDataSet(gSQLString, "Promotional")
            If Trim(gdataset.Tables("Promotional").Rows(0).Item("Promotional")) = "Y" Then

                'Modified on 14 Mar'08
                'Mk Kannan
                'Begin
                gSQLString = "SELECT I.PROMQTY, I.ITEMCODE,I.PROMITEMCODE, IM.ITEMDESC,I.ITEMTYPECODE, P.POSCODE, P.POSDESC,I.STARTINGDATE,I.ENDINGDATE,"
                gSQLString = gSQLString & " I.PROMUOM, I.PROMQTY, I.PROMRATE FROM ITEMMASTER AS I INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN"
                gSQLString = gSQLString & " POSMASTER AS P ON PL.POS = P.POSCODE "
                gSQLString = gSQLString & " INNER JOIN ITEMMASTER AS IM ON IM.ITEMCODE=I.PROMITEMCODE"
                gSQLString = gSQLString & " WHERE (I.PROMOTIONAL = 'Y') AND (I.PROMITEMCODE = '" & gdataset.Tables("Promotional").Rows(0).Item("promitemcode") & "') AND (I.ITEMCODE = '" & vform.keyfield & "') AND ISNULL(I.FREEZE,'') <>'Y' "
                'gSQLString = "SELECT dbo.ItemMaster.PromQty, dbo.ItemMaster.ItemCode,dbo.ItemMaster.PromItemcode, dbo.ItemMaster.ItemDesc,dbo.ItemMaster.ItemTypecode, dbo.POSMaster.POSCode, dbo.POSMaster.POSDesc,dbo.ItemMaster.StartingDate,dbo.ItemMaster.EndingDate,"
                'gSQLString = gSQLString & " dbo.ItemMaster.PromUOM, dbo.ItemMaster.PromQty, dbo.ItemMaster.PromRate FROM dbo.ItemMaster INNER JOIN dbo.POSMenulink ON dbo.ItemMaster.ItemCode = dbo.POSMenulink.ItemCode INNER JOIN"
                'gSQLString = gSQLString & " dbo.POSMaster ON dbo.POSMenulink.Pos = dbo.POSMaster.POSCode WHERE (dbo.ItemMaster.Promotional = 'Y') AND (dbo.ItemMaster.PromItemcode = '" & gdataset.Tables("Promotional").Rows(0).Item("promitemcode") & "') AND (dbo.ItemMaster.itemcode = '" & vform.keyfield & "') "
                'End

                gconnection.getDataSet(gSQLString, "Promotional")
                If gdataset.Tables("Promotional").Rows.Count > 0 Then
                    If MessageBox.Show("Promotional available for this ITEMCODE ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                        If CDate(gdataset.Tables("Promotional").Rows(0).Item("EndingDate")) <= CDate(serverdate.Today) And CDate(gdataset.Tables("Promotional").Rows(0).Item("StartingDate")) >= CDate(serverdate.Today) Then
                            ssGrid.SetText(1, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("PromItemcode")) & "")
                            ssGrid.SetText(2, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("ItemDesc")) & "")
                            ssGrid.SetText(3, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("POSCode")) & "")
                            ssGrid.SetText(4, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("PromUOM")) & "")
                            ssGrid.SetText(5, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("PromQty")) & "")
                            ssGrid.SetText(6, ssGrid.ActiveRow + 1, 0.0)
                            ssGrid.SetText(7, ssGrid.ActiveRow + 1, 0.0)
                            ssGrid.SetText(8, ssGrid.ActiveRow + 1, 0.0)
                            ssGrid.SetText(9, ssGrid.ActiveRow + 1, Trim(gdataset.Tables("Promotional").Rows(0).Item("ItemTypecode")) & "")
                            'Modified on 14 Mar'08
                            'Mk Kannan
                            'Begin
                            ssGrid.SetText(11, ssGrid.ActiveRow + 1, 0.0)
                            ssGrid.SetText(17, ssGrid.ActiveRow + 1, "Y")
                            boolPromotional = True
                            'End
                        End If
                    End If
                End If
            End If
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub ssGrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssGrid.LeaveCell
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
                ssGrid.Col = 1
                ssGrid.Row = i
                If ssGrid.Lock = False Then
                    If Trim(ssGrid.Text) <> "" Then
                        ssGrid.Col = 3
                        ssGrid.Row = i
                        If Trim(ssGrid.Text) = "" Then
                            ssGrid.Row = i
                            ssGrid.Col = 2
                            varitemdesc = Trim(ssGrid.Text)
                            ssGrid.Col = 3
                            varposcode = Trim(ssGrid.Text)
                            ssGrid.Col = 1
                            Itemcode = Trim(ssGrid.Text)
                            If Trim(varitemdesc) = "" And Trim(varposcode) = "" Then
                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                                Sqlstring = "SELECT DISTINCT I.ITEMDESC,I.ITEMCODE,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE,"
                                Sqlstring = Sqlstring & " ISNULL(TL.ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,I.PROMOTIONAL,I.PROMITEMCODE,I.OPENFACILITY,ISNULL(I.salesacctin,'') AS salesacctin FROM ITEMMASTER AS I"
                                Sqlstring = Sqlstring & " INNER JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "
                                Sqlstring = Sqlstring & " WHERE I.ITEMCODE = '" & Trim(Itemcode) & "' AND '" & Format(DateValue(dtp_KOTdate.Value), "dd-MMM-yyyy") & "' BETWEEN TL.STARTINGDATE AND ISNULL(TL.ENDINGDATE,getdate())  AND ISNULL(I.FREEZE,'') <>'Y'"
                                gconnection.getDataSet(Sqlstring, "ITEMCODE")
                                If gdataset.Tables("ITEMCODE").Rows.Count > 0 Then
                                    ssGrid.SetText(1, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMCODE")) & "")
                                    ssGrid.SetText(2, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMDESC")) & "")
                                    ssGrid.SetText(9, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ITEMTYPECODE")) & "")
                                    ssGrid.SetText(10, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("TAXCODE")) & "")
                                    ssGrid.SetText(11, i, Val(gdataset.Tables("ITE2MCODE").Rows(j).Item("TAXPERCENTAGE")))
                                    ssGrid.SetText(13, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("ACCOUNTCODE")))
                                    ssGrid.SetText(14, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("salesacctin")))
                                    ssGrid.SetText(15, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("GROUPCODE")))
                                    ssGrid.SetText(19, i, Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")))
                                    If Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("OPENFACILITY")) = "Y" Then
                                        ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                                    Else
                                        ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                    End If
                                    '''*************************** $ PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                    If Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("Promotional")) = "Y" Then
                                        Promtcode = Trim(gdataset.Tables("ITEMCODE").Rows(j).Item("PromItemcode"))

                                        'Modified on 14 Mar'08
                                        'Mk Kannan
                                        'Begin
                                        'Sqlstring = "SELECT I.PROMQTY, I.ITEMCODE,I.PROMITEMCODE, I.ITEMDESC,I.ITEMTYPECODE, P.POSCODE, P.POSDESC,I.STARTINGDATE,I.ENDINGDATE,"
                                        'Sqlstring = Sqlstring & " I.PROMUOM, I.PROMQTY, I.PROMRATE FROM ITEMMASTER AS I INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN"
                                        'Sqlstring = Sqlstring & " POSMASTER AS P ON PL.POS = P.POSCODE WHERE (I.PROMOTIONAL = 'Y') AND (I.PROMITEMCODE = '" & Promtcode & "') AND (I.ITEMCODE = '" & Itemcode & "') AND ISNULL(I.FREEZE,'') <>'Y' "
                                        Sqlstring = "SELECT I.PROMQTY, I.ITEMCODE,I.PROMITEMCODE, IM.ITEMDESC,I.ITEMTYPECODE, P.POSCODE, P.POSDESC,I.STARTINGDATE,I.ENDINGDATE,"
                                        Sqlstring = Sqlstring & " I.PROMUOM, I.PROMQTY, I.PROMRATE FROM ITEMMASTER AS I INNER JOIN POSMENULINK AS PL ON I.ITEMCODE = PL.ITEMCODE INNER JOIN"
                                        Sqlstring = Sqlstring & " POSMASTER AS P ON PL.POS = P.POSCODE "
                                        Sqlstring = Sqlstring & " INNER JOIN ITEMMASTER AS IM ON IM.ITEMCODE=I.PROMITEMCODE"
                                        Sqlstring = Sqlstring & " WHERE (I.PROMOTIONAL = 'Y') AND (I.PROMITEMCODE = '" & Promtcode & "') AND (I.ITEMCODE = '" & Itemcode & "') AND ISNULL(I.FREEZE,'') <>'Y' "
                                        'End

                                        gconnection.getDataSet(Sqlstring, "PROMOTIONAL")
                                        If gdataset.Tables("PROMOTIONAL").Rows.Count > 0 Then
                                            If MessageBox.Show("Promotional available for this ITEMCODE ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                                                If CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("EndingDate")) <= CDate(serverdate.Today) And CDate(gdataset.Tables("PROMOTIONAL").Rows(j).Item("StartingDate")) >= CDate(serverdate.Today) Then
                                                    ssGrid.SetText(1, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMITEMCODE")) & "")
                                                    ssGrid.SetText(2, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMDESC")) & "")
                                                    ssGrid.SetText(3, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("POSCODE")) & "")
                                                    ssGrid.SetText(4, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMUOM")) & "")
                                                    ssGrid.SetText(5, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("PROMQTY")) & "")
                                                    ssGrid.SetText(6, i + 1, 0.0)
                                                    ssGrid.SetText(7, i + 1, 0.0)
                                                    ssGrid.SetText(8, i + 1, 0.0)
                                                    ssGrid.SetText(9, i + 1, Trim(gdataset.Tables("PROMOTIONAL").Rows(j).Item("ITEMTYPECODE")) & "")
                                                    'Modified on 14 Mar'08
                                                    'Mk Kannan
                                                    'Begin
                                                    ssGrid.SetText(11, i + 1, 0.0)
                                                    ssGrid.SetText(17, i + 1, "Y")
                                                    boolPromotional = True
                                                    'End
                                                End If
                                            End If
                                        End If
                                    End If
                                    '''*************************** $ COMPLETE PROMOTIONAL DETAILS OF PARTICULAR ITEMCODE $ **************************************************'''
                                    '''****************************** TO FILL POSCODE **********************************************************************'''
                                    Sqlstring = "SELECT POSCODE,POSDESC,SALESACCTIN FROM POSMENULINK P INNER Join POSMASTER M On P.POS=M.POSCODE WHERE P.ITEMCODE ='" & Trim(Itemcode) & "' AND ISNULL(M.FREEZE,'') <>'Y' ORDER BY POSCODE"
                                    gconnection.getDataSet(Sqlstring, "PosMenuLink")
                                    If gdataset.Tables("PosMenuLink").Rows.Count = 1 Then
                                        ssGrid.Col = 3
                                        ssGrid.Row = ssGrid.ActiveRow
                                        ssGrid.Text = gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE")
                                        If IsDBNull(gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN")) = False Then
                                            If Trim((gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN"))) <> "" Then
                                                ssGrid.Col = 14
                                                ssGrid.Row = ssGrid.ActiveRow
                                                ' ssGrid.Text = gdataset.Tables("PosMenuLink").Rows(0).Item("SALESACCTIN")
                                            Else
                                                MsgBox("Account Code For The Location  " & gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE") & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                                                ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                                Exit Sub
                                            End If
                                        Else
                                            MsgBox("Account Code For The Location  " & gdataset.Tables("PosMenuLink").Rows(0).Item("POSCODE") & "  Not Defined,Pls Contact Your System Administrator", MsgBoxStyle.Critical, MyCompanyName)
                                            ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                            Exit Sub
                                        End If
                                        '''****************************** To FILL UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                                        Sqlstring = "SELECT R.UOM, R.ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                                        Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(Itemcode) & "' ) ORDER BY R.ITEMRATE,R.UOM"
                                        gconnection.getDataSet(Sqlstring, "ITEMRATE")
                                        If gdataset.Tables("ITEMRATE").Rows.Count = 1 Then
                                            ssGrid.Col = 4
                                            ssGrid.Row = ssGrid.ActiveRow
                                            ssGrid.Text = CStr(gdataset.Tables("ITEMRATE").Rows(0).Item("UOM")) & ""
                                            ssGrid.Col = 6
                                            ssGrid.Row = ssGrid.ActiveRow
                                            ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE")) & ""
                                            ''ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                            ssGrid.Col = 19
                                            ssGrid.Row = ssGrid.ActiveRow
                                            If Trim(ssGrid.Text) = "Y" Then
                                                ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                                            Else
                                                ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                                            End If
                                        Else
                                            ssGrid.Col = 6
                                            ssGrid.Text = "0.00"
                                            ssGrid.Col = 4
                                            ''ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
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
                                        '''******************************  SHOW A POPUP FOR POS LOCATION ***********************''
                                        Call FillPosList(gdataset.Tables("PosMenuLink"))
                                        Me.lvw_POSCode.FullRowSelect = True
                                        pnl_POSCode.Top = 50
                                        lvw_POSCode.Focus()
                                    End If
                                    '''****************************** COMPLETE FILLING TO FILL POSCODE ******************************************************'''
                                Else
                                    MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    ssGrid.ClearRange(1, ssGrid.ActiveRow, 15, ssGrid.ActiveRow, True)
                                    ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                                    ssGrid.Lock = False
                                    ssGrid.Focus()
                                    Exit Sub
                                End If
                            End If
                        End If
                    End If
                End If
            ElseIf ssGrid.ActiveCol = 3 Then
                'ssGrid.Col = 3
                'ssGrid.Row = ssGrid.ActiveRow
                'If ssGrid.Lock = False Then
                '    If Trim(ssGrid.Text) = "" Then
                '        'ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                '        Exit Sub
                '    End If
                'End If
            ElseIf ssGrid.ActiveCol = 4 Then
                ssGrid.Col = 4
                ssGrid.Row = ssGrid.ActiveRow
                If ssGrid.Lock = False Then
                    If Trim(ssGrid.Text) = "" Then
                        ssGrid.Col = 1
                        ssGrid.Row = ssGrid.ActiveRow
                        Itemcode = Trim(ssGrid.Text)
                        '''****************************** To FILL UOM and RATE FOR THAT PARTICULAR ITEMCODE CODE*********************************'''
                        Sqlstring = "SELECT R.UOM, R.ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                        Sqlstring = Sqlstring & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(Itemcode) & "' ) ORDER BY R.ITEMRATE,R.UOM"
                        gconnection.getDataSet(Sqlstring, "ITEMRATE")
                        If gdataset.Tables("ITEMRATE").Rows.Count = 1 Then
                            ssGrid.Col = 4
                            ssGrid.Row = ssGrid.ActiveRow
                            ssGrid.Text = CStr(gdataset.Tables("ITEMRATE").Rows(0).Item("UOM")) & ""
                            ssGrid.Col = 6
                            ssGrid.Row = ssGrid.ActiveRow
                            ssGrid.Text = Val(gdataset.Tables("ITEMRATE").Rows(0).Item("ITEMRATE")) & ""
                            ''ssGrid.SetActiveCell(4, ssGrid.ActiveRow)

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
                            '' Call Calculate()
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
                                'ssGrid.SetActiveCell(1, ssGrid.ActiveRow + 1)
                            End If
                            '''ssGrid.Col = 1
                            '''ssGrid.Lock = False
                            '''ssGrid.Col = 2
                            '''ssGrid.Lock = False
                            '''ssGrid.Col = 3
                            '''ssGrid.Lock = False
                            '''ssGrid.Col = 4
                            '''ssGrid.Lock = False
                            '''ssGrid.Col = 5
                            '''ssGrid.Lock = False

                            'Added on 14 Mar'08
                            'Mk Kannan
                            'Begin
                            'ssGrid.SetActiveCell(1, ssGrid.ActiveRow + 1)
                            If boolPromotional = True Then
                                ssGrid.SetActiveCell(0, ssGrid.ActiveRow + 1)
                            Else
                                ssGrid.SetActiveCell(0, ssGrid.ActiveRow + 1)
                            End If
                            'boolPromotional = False
                            'End                            
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

            If boolPromotional = True Then
                ssGrid.Col = 1
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Focus()
                boolPromotional = False
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub Calculate()
        Dim qty, taxperc, cancel, kotstatus, rate As String
        Dim total, Taxamount, cancelamt, canceltax, Billamount As Double
        Dim i As Integer
        With ssGrid
            If .ActiveCol = 5 Or .ActiveCol = 4 Or .ActiveCol = 1 Then
                Me.txt_TaxValue.Text = "0.00"
                Me.txt_TotalValue.Text = "0.00"
                Me.txt_BillAmount.Text = "0.00"
                For i = 1 To .DataRowCnt
                    .Col = 12
                    .Row = i
                    kotstatus = .Text
                    If Val(kotstatus) = 0 Then
                        .Col = 5
                        .Row = i
                        qty = .Text
                        .Col = 6
                        .Row = i
                        rate = .Text
                        .Col = 11
                        .Row = i
                        taxperc = .Text
                        total = Val(qty) * Val(rate)
                        Taxamount = (total * taxperc) / 100
                        .SetText(8, i, total)
                        .SetText(7, i, Taxamount)
                        Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(total), "0.00")
                        Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(Taxamount), "0.00")
                        Billamount = Format(Val(Me.txt_TaxValue.Text) + Val(Me.txt_TotalValue.Text), "0.00")
                        If BILLROUNDYESNO = "YES" Then
                            'Me.txt_BillAmount.Text = Format(Math.Round(Billamount), "0.00")
                            Me.txt_BillAmount.Text = Format(Billamount, "0.00")
                        Else
                            Me.txt_BillAmount.Text = Format(Billamount, "0.00")
                        End If
                    End If
                Next i
            End If
        End With
        i = i - 1
    End Sub

    Private Sub FillPosList(ByVal PosTable As DataTable)
        Dim lvw As New ListViewItem
        Dim i As Integer
        lvw_POSCode.Items.Clear()
        For i = 0 To PosTable.Rows.Count - 1
            lvw = lvw_POSCode.Items.Add(PosTable.Rows(i).Item(0))
            lvw.SubItems.Add(PosTable.Rows(i).Item(1))
            lvw.SubItems.Add(PosTable.Rows(i).Item(2))
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
    'Private Sub cbo_PaymentMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_PaymentMode.SelectedIndexChanged
    '    'Modified on 15 Mar'09
    '    'Mk Kannan
    '    'Begin
    '    'If cbo_PaymentMode.SelectedItem = "ROOM" Then
    '    '    txt_MemberCode.Visible = True
    '    '    txt_MemberName.Visible = True
    '    '    lbl_Membercode.Visible = True
    '    '    lbl_MemberName.Visible = True
    '    '    cmd_MemberCodeHelp.Visible = True
    '    '    txt_MemberCode.Text = ""
    '    '    txt_MemberName.Text = ""
    '    '    lbl_Membercode.Text = "ROOM NO.   :"
    '    '    lbl_MemberName.Text = "GUEST NAME :"
    '    'ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
    '    '    txt_MemberCode.Visible = False
    '    '    txt_MemberName.Visible = False
    '    '    lbl_Membercode.Visible = False
    '    '    lbl_MemberName.Visible = False
    '    '    cmd_MemberCodeHelp.Visible = False
    '    'ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
    '    '    txt_MemberCode.Visible = False
    '    '    txt_MemberName.Visible = False
    '    '    lbl_Membercode.Visible = False
    '    '    lbl_MemberName.Visible = False
    '    '    cmd_MemberCodeHelp.Visible = False
    '    'Else
    '    '    txt_MemberCode.Visible = True
    '    '    txt_MemberName.Visible = True
    '    '    lbl_Membercode.Visible = True
    '    '    lbl_MemberName.Visible = True
    '    '    cmd_MemberCodeHelp.Visible = True
    '    '    txt_MemberCode.Text = ""
    '    '    txt_MemberName.Text = ""
    '    '    lbl_Membercode.Text = "MEMBER CODE :"
    '    '    lbl_MemberName.Text = "MEMBER NAME :"
    '    'End If
    '    gSQLString = "Select Isnull(MemberStatus,'') as MemberStatus From PaymentModeMaster Where Isnull(Freeze,'') <> 'Y' and Isnull(PaymentCode,'') = '" & cbo_PaymentMode.Text & "'"
    '    gconnection.getDataSet(gSQLString, "PaymentModeMaster")
    '    If gdataset.Tables("PaymentModeMaster").Rows.Count > 0 Then
    '        If Trim(gdataset.Tables("PaymentModeMaster").Rows(0).Item(0)) = "YES" Then
    '            txt_MemberCode.Visible = True
    '            txt_MemberName.Visible = True
    '            lbl_Membercode.Visible = True
    '            lbl_MemberName.Visible = True
    '            cmd_MemberCodeHelp.Visible = True
    '            cbo_SubPaymentMode.Visible = False
    '            lbl_SubPaymentMode.Visible = False
    '            txt_MemberCode.Text = ""
    '            txt_MemberName.Text = ""
    '            If cbo_PaymentMode.Text = "ROOM" Then
    '                lbl_Membercode.Text = "ROOM NO.   :"
    '                lbl_MemberName.Text = "GUEST NAME :"
    '            Else
    '                lbl_Membercode.Text = "MEMBER CODE :"
    '                lbl_MemberName.Text = "MEMBER NAME :"
    '            End If
    '        Else
    '            txt_MemberCode.Visible = False
    '            txt_MemberName.Visible = False
    '            lbl_Membercode.Visible = False
    '            lbl_MemberName.Visible = False
    '            cmd_MemberCodeHelp.Visible = False
    '            ' cbo_SubPaymentMode.Visible = False
    '            'lbl_SubPaymentMode.Visible = False

    '            txt_MemberCode.Text = ""
    '            txt_MemberName.Text = ""
    '        End If
    '    End If
    '    'End
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
    '            If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) = "NO" Then
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
    '                lbl_Membercode.Text = "MEMBER CODE :"

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
    '                        lbl_Membercode.Text = "CLUB CODE   :"
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
        LAB_CARDBAL.Visible = False
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
                        'txt_MemberCode.Text = ""
                        'txt_MemberName.Text = ""
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
                                LAB_CARDBAL.Visible = False
                            Else
                                'txt_card_id.Focus()
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
                'If cbo_PaymentMode.SelectedItem = "SMART CARD" Then
                '    LAB_CARDBAL.Visible = True
                'Else
                '    LAB_CARDBAL.Visible = False
                'End If
            Catch ex As Exception
                MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
        Call FillSubPaymentMode(Trim(Me.cbo_PaymentMode.Text))
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
    Private Sub checkvalidate()
        Try
            Dim i As Integer
            Dim j As Integer
            Dim sql As String
            Dim dt As New DataTable
            Dim a, B As Integer
            Dim STRSQL, strstring As String
            Dim icode, icode1, uom, uom1 As String
            Dim taxcode, sqlstring, itemcode, itemdesc As String
            chkbool = False
            ''***************************************** Assign Account Code Value **********************************************'''
            Dim msgres As String
            If txt_card_id.Text <> "" Then
                strstring = " SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE]='" & txt_card_id.Text & "' AND CARDCODE='" & txt_Holder_Code.Text & "'  AND  MEMBERCODE='" & txt_MemberCode.Text & "' AND CAST(CONVERT(CHAR(11),VALID_TO,106) AS DATETIME)>='" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "'"
                gconnection.getDataSet(strstring, "CHK")
                If gdataset.Tables("CHK").Rows.Count <= 0 Then
                    MessageBox.Show("PLEASE! CHECK YOUR CARD", "SMART CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If
            msgres = creditstop(txt_MemberCode.Text)
            If Cmd_Add.Text = "Add [F7]" Then
                If (Trim(txt_card_id.Text) = "") Then
                    MessageBox.Show(" PLEASE SWIPE THE CARD ", "SMART CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txt_card_id.Focus()
                    chkbool = False
                    Exit Sub
                End If
            End If
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

            If txt_ServerCode.Text <> "" And txt_KOTno.Text <> "" Then
                STRSQL = "SELECT * FROM KOT_HDR WHERE KOTDETAILS='" & txt_KOTno.Text & "'"
                gconnection.getDataSet(STRSQL, "KOTNO")
                If gdataset.Tables("KOTNO").Rows.Count = 0 Then
                    STRSQL = " Select * From Kotbook Where "
                    STRSQL = STRSQL & "Convert(Int," & Val(txt_KOTno.Text) & ")  BetWeen convert(int,SnoFrom) AND convert(int,SnoTO) And SERVERCODE='" & txt_ServerCode.Text & "' --and prefix='" & Mid(txt_KOTno.Text, 1, 3) & "'"
                    gconnection.getDataSet(STRSQL, "servermaster")
                    If gdataset.Tables("servermaster").Rows.Count = 0 Then
                        ' MessageBox.Show(" KOTNO MISMATCH FOR THIS USER,KINDLY CHECK IT", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        'txt_KOTno.Text = ""
                        'txt_ServerCode.Text = ""
                        'txt_KOTno.Focus()
                        ' Exit Sub
                    End If
                Else
                    'MessageBox.Show("THIS KOT ALREADY ENTERED,KINDLY CONFORM YOUR SYSTEM INCHARGE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    'txt_KOTno.Focus()
                    'Exit Sub
                End If
            End If
            If Cmd_Add.Text = "Add [F7]" Then
                STRSQL = " SELECT * FROM KOT_HDR WHERE KOTDETAILS='" & txt_KOTno.Text & "'"
                gconnection.getDataSet(STRSQL, "KOTSTATUS")
                If gdataset.Tables("KOTSTATUS").Rows.Count > 0 Then
                    MessageBox.Show("THIS KOT ALREADY ENTERED,KINDLY CONFORM YOUR SYSTEM INCHARGE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If
            '' FOR KOT SHOULD NOT ENTER IF PREVIOUS 
            'a = (Mid(Trim(txt_KOTno.Text), 4, 9) - 1)

            'B = Month(Trim(dtp_KOTdate.Text))

            'sql = "SELECT * FROM KOT_DET WHERE SUBSTRING(KOTDETAILS,4,9) =  '" & Val(a) & "' AND month(KOTDATE) = " & Val(a) & " "
            'gconnection.getDataSet(sql, "KOT_DET")
            'If gdataset.Tables("KOT_DET").Rows.Count < 0 Then
            '    MessageBox.Show("THIS KOT SHOULD BE ENTERED BECAUSE PREVIOUS KOT IS NOT ENTERED", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    Exit Sub
            'End If

            If MemberOutstand + Val(txt_BillAmount.Text) > 10000 Then
                'MessageBox.Show("CREDIT LIMIT EXPIRED", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                'Exit Sub
            End If

            If cbo_PaymentMode.SelectedItem = "ROOM" Then
                accountcode = "RMLDGR"
            Else
                accountcode = "SDRS"
            End If

            '''**************************************** Check Tableno can't be blank *******************************************'''
            'If Trim(txt_TableNo.Text) = "" Then
            '    MessageBox.Show("Table No. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    txt_TableNo.Focus()
            '    Exit Sub
            'End If
            '''**************************************** Check Payment Mode can't be blank *******************************************''
            If Trim(cbo_PaymentMode.Text) = "" Then
                MessageBox.Show("Payment Mode Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                cbo_PaymentMode.Focus()
                Exit Sub
            End If
            If Trim(txt_LOCATIONCODE.Text) = "" Then
                MessageBox.Show("Location Code Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                TXT_LOCATIONNAME.Text = ""
                txt_LOCATIONCODE.Focus()
                Exit Sub
            End If
            '''**************************************** Check Room No and Member Code can't be blank *******************************************''
            If Trim(txt_MemberCode.Text) = "" Then
                If cbo_PaymentMode.Text = "ROOM" Then
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
            If txt_KOTno.Text = "" Then
                MessageBox.Show("KOT NO Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_KOTno.Focus()
                Exit Sub
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
            '''**************************************** Check Server Name can't be blank *******************************************''
            If Trim(txt_ServerName.Text) = "" Then
                MessageBox.Show("Server Name Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_ServerName.Focus()
                Exit Sub
            End If

            If Trim(dtp_KOTdate.Text) > serverdate Then
                MessageBox.Show("KOT DATE SHOULD NOT BE GREATER THAN CURRENTDATE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            sql = "SELECT * FROM kot_hdr WHERE CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) ='" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy") & "' AND postingstatus = 'Y'"
            gconnection.getDataSet(sql, "kot_hdr")
            If gdataset.Tables("kot_hdr").Rows.Count > 0 Then
                Cmd_Add.Enabled = False
                cmd_Delete.Enabled = False
                MessageBox.Show("NO KOT SHOULD BE ENTERED/UPDATED FOR BILL CLOSED DATE:" & Format(dtp_KOTdate.Value, "dd/MMM/yyyy"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            a = Month(Trim(dtp_KOTdate.Text))
            sql = "SELECT * FROM bill_hdr WHERE month(billdate) = " & Val(a) & " AND ACCOUNTFLAG = 'Y'"
            gconnection.getDataSet(sql, "bill_hdr")
            If gdataset.Tables("bill_hdr").Rows.Count > 0 Then
                Cmd_Add.Enabled = False
                cmd_Delete.Enabled = False
                MessageBox.Show("NO KOT SHOULD BE ENTERED FOR MEMBER BILL GENERATED MONTH", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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

                    .Row = i
                    .Col = 1
                    itemcode = Trim(CStr(ssGrid.Text))
                    .Row = i
                    .Col = 2
                    itemdesc = Trim(CStr(ssGrid.Text))
                    If i = 1 Then
                        .Row = i
                        .Col = 3
                        loccode = Trim(.Text)
                    End If
                    ' sqlstring = "SELECT ITEMCODE,ITEMDESC,ISNULL(OPENFACILITY,'') AS OPENFACILITY FROM ITEMMASTER WHERE Itemcode = '" & Trim(itemcode) & "' AND ISNULL(OPENFACILITY,'')='Y'"
                    'gconnection.getDataSet(Trim(sqlstring), "OPEN")
                    'If gdataset.Tables("OPEN").Rows.Count = 0 Then
                    sqlstring = "SELECT ITEMCODE,ITEMDESC,ISNULL(OPENFACILITY,'') AS OPENFACILITY FROM ITEMMASTER WHERE Itemcode = '" & Trim(itemcode) & "'--AND Itemdesc = '" & Trim(itemdesc) & "'"
                    gconnection.getDataSet(Trim(sqlstring), "ITEMMASTER")
                    If gdataset.Tables("ITEMMASTER").Rows.Count > 0 Then
                        .Row = i
                        .Col = 1
                        ssGrid.Text = Trim(CStr(gdataset.Tables("ITEMMASTER").Rows(0).Item("ITEMCODE")))
                        .Row = i
                        .Col = 2
                        If Trim(CStr(gdataset.Tables("ITEMMASTER").Rows(0).Item("OPENFACILITY"))) <> "Y" Then
                            'ssGrid.Text = Trim(CStr(gdataset.Tables("ITEMMASTER").Rows(0).Item("ITEMDESC")))
                        End If
                    Else
                        MessageBox.Show("!!Warning!! Itemcode : " & Trim(itemcode) & " And Itemdesc : " & Trim(itemdesc) & " is not valid ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ssGrid.Focus()
                        ssGrid.SetActiveCell(1, i)
                        Exit Sub
                    End If
                    'End If
                Next
            End With
            With ssGrid
                For i = 1 To .DataRowCnt
                    .Row = i
                    .Col = 17
                    If UCase(Trim(.Text)) <> "Y" Then
                        .Row = i
                        .Col = 1

                        If Trim(.Text) = "" Then
                            MessageBox.Show("Item Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            .SetActiveCell(1, i)
                            .Focus()
                            Exit Sub
                        End If
                        .Col = 2
                        If Trim(.Text) = "" Then
                            MessageBox.Show("Item Description can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            .SetActiveCell(2, i)
                            .Focus()
                            Exit Sub
                        End If
                        .Col = 3
                        If Trim(.Text) = "" Then
                            MessageBox.Show("POS Location can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            .SetActiveCell(3, i)
                            .Focus()
                            Exit Sub
                        End If
                        .Col = 4
                        If Trim(.Text) = "" Then
                            MessageBox.Show("UOM can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            .SetActiveCell(4, i)
                            .Focus()
                            Exit Sub
                        End If
                        .Col = 5
                        If Val(.Text) = 0 Then
                            MessageBox.Show("Quantity can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            .SetActiveCell(5, i)
                            .Focus()
                            Exit Sub
                        End If
                        ' .Col = 17
                        ' If Trim(.Text) <> "Y" Then
                        .Col = 6
                        If Val(.Text) = 0 Then
                            .Col = 1
                            If Mid(Trim(ssGrid.Text), Len(Trim(ssGrid.Text)), 1) <> "A" Then
                                MessageBox.Show("Rate can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                .SetActiveCell(6, i)
                                .Focus()
                                Exit Sub
                            End If
                        End If
                        If Val(.Text) = 0 Then
                            If Mid(Trim(ssGrid.Text), Len(Trim(ssGrid.Text)), 1) <> "A" Then
                                MessageBox.Show("Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                                .SetActiveCell(8, i)
                                .Focus()
                                Exit Sub
                            End If
                        End If
                        .Col = 9
                        If Trim(.Text) = "" Then
                            MessageBox.Show("Item Type can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            .SetActiveCell(9, i)
                            .Focus()
                            Exit Sub
                        End If
                        .Col = 14
                        If Trim(.Text) = "" Then
                            MsgBox("Sales Account can't blank", MsgBoxStyle.Information, MyCompanyName)
                            .SetActiveCell(11, i)
                            .Focus()
                            Exit Sub
                        End If
                        'End If
                    End If
                Next
            End With
            For i = 1 To ssGrid.DataRowCnt
                ssGrid.Col = 10
                If Trim(ssGrid.Text) <> "" Then
                    If Trim(taxcode) = "" Then
                        taxcode = ssGrid.Text
                    Else
                        If Trim(taxcode) <> Trim(ssGrid.Text) Then
                            MessageBox.Show("Different tax code items can not be in a single kot", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                            Exit Sub
                        End If
                    End If
                End If
            Next i
            If Cmd_Add.Text = "Update[F7]" And Me.Lbl_Bill.Text = "B I L L  G E N E R A T E D" Then
                If Me.ssGrid.DataRowCnt > TotalItemCount Then
                    MessageBox.Show("Bill Has Been Generated You Can Not Add More Item,Plz Generate Another KOT ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If
            chkbool = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txt_KOTno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_KOTno.Validated
        Try
            Dim vTypeseqno, vGroupseqno As Double
            Dim vString, sqlstring, STRSQL As String
            Dim dt As New DataTable
            Dim j, i As Integer
            If Trim(txt_KOTno.Text) <> "" Then
                STRSQL = "SELECT * FROM KOT_HDR WHERE KOTDETAILS='" & txt_KOTno.Text & "'"
                gconnection.getDataSet(STRSQL, "KOTNO")
                If gdataset.Tables("KOTNO").Rows.Count = 0 Then
                    STRSQL = " Select isnull(Prefix,'') as Prefix,isnull(Servercode,'') as Servercode From Kotbook "
                    STRSQL = STRSQL & "  Where  " & IIf(Val(txt_KOTno.Text) > 0, Val(txt_KOTno.Text), 0) & " between snofrom and  snoto "
                    gconnection.getDataSet(STRSQL, "servermaster")
                    If gdataset.Tables("servermaster").Rows.Count > 0 Then
                        txt_ServerCode.Text = gdataset.Tables("servermaster").Rows(0).Item("Servercode")
                        txt_ServerCode_Validated(sender, e)
                        'cbo_PaymentMode.Focus()
                        txt_MemberCode.Focus()
                    Else
                        ' MessageBox.Show("Kindly Register This Kotbook in System,Thanking You", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ' txt_KOTno.Text = ""
                        'txt_KOTno.Focus()
                        'Exit Sub
                    End If
                End If
                Call KOTNoValidate(Trim(txt_KOTno.Text))
                'Call txt_ServerCode_Validated(sender, e)
                'cbo_PaymentMode.Focus()
                CMD_LOCK()
                txt_MemberCode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub KOT_Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles KOT_Timer.Tick
        Try
            txt_KOTTime.Text = serverdate.ToLongTimeString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
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

    Public Function SetDateTime()
        Dim Insert(0)
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
    Private Sub ShowBillno()
        Dim sqlstring, financalyear As String
        Try
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            'Modified on 06 Apr'08 for Generating Usernamewise KOT
            'Advised by :- Sandeep after having discussion with him at 06 Apr'08 Mid Night 11.30 P.M
            'Mk Kannan
            'Begin           
            'sqlstring = "SELECT MAX(Cast(SUBSTRING(KOTno,1,6) As Numeric)) FROM KOT_HDR WHERE DocType ='SALE'"
            Call UserValidation()
            sqlstring = " SELECT Isnull(DocNo,0) FROM PoSKotDoc Where DocType = 'KOT' "
            gconnection.openConnection()
            gcommand = New SqlCommand(sqlstring, gconnection.Myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is DBNull.Value Then
                    lbl_Status.Visible = True
                    lbl_Status.Text = "FIRST KOTNO :"
                Else
                    lbl_Status.Visible = True
                    lbl_Status.Text = "LAST KOTNO :" & "KOT" & "/" & Format(Val(gdreader(0)), "000000") & "/" & financalyear
                    'lbl_Status.Text = "LAST KOTNO :" & gPoSUsername & "/" & Format(Val(gdreader(0)), "000000") & "/" & financalyear
                    'End
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
            MessageBox.Show("Check The Error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub
    Private Sub lvw_POSCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lvw_POSCode.KeyPress
        Try
            Dim strSQL, ITEMCODE As String
            Dim posloc As String
            Dim acctin As String
            If Asc(e.KeyChar) = 13 Then
                Try
                    posloc = Trim(lvw_POSCode.SelectedItems(0).SubItems(0).Text)
                    acctin = Trim(lvw_POSCode.SelectedItems(0).SubItems(2).Text)
                Catch ex As Exception
                    posloc = Trim(lvw_POSCode.Items(0).SubItems(0).Text)
                    acctin = Trim(lvw_POSCode.Items(0).SubItems(2).Text)
                Finally
                    If Trim(acctin) <> "" Then
                        ssGrid.SetText(3, ssGrid.ActiveRow, posloc)
                        ''ssGrid.SetText(14, ssGrid.ActiveRow, acctin)
                        ssGrid.GetText(1, ssGrid.ActiveRow, ITEMCODE)
                        pnl_POSCode.Top = 1000
                        ssGrid.Focus()
                        SQLSTRING = "SELECT R.UOM, R.ITEMRATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
                        SQLSTRING = SQLSTRING & " WHERE (R.ENDINGDATE IS  NULL) AND (I.ITEMCODE = '" & Trim(ITEMCODE) & "' ) ORDER BY R.ITEMRATE,R.UOM"
                        gconnection.getDataSet(SQLSTRING, "ITEMRATE1")
                        If gdataset.Tables("ITEMRATE1").Rows.Count = 1 Then

                            ssGrid.Col = 4
                            ssGrid.Row = ssGrid.ActiveRow
                            ssGrid.Text = CStr(gdataset.Tables("ITEMRATE1").Rows(0).Item("UOM")) & ""

                            ssGrid.Col = 6
                            ssGrid.Row = ssGrid.ActiveRow
                            ssGrid.Text = CStr(gdataset.Tables("ITEMRATE1").Rows(0).Item("ITEMRATE")) & ""

                        End If
                        ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                    Else
                        MsgBox("Sales Account In Not Defined", MsgBoxStyle.Critical)
                    End If
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(EX.Message)
        End Try
    End Sub
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
    Public Sub PrintOperation()
        Try
            Dim rowj, Loopindex, i, in1, CountItem, Fo As Integer
            Dim ssqlstring, ssql, Servicecode, vCaption, vPath, str, serverdetail, Fsize(), INSERT(0) As String
            Dim Forder(), vFilepath, vOutfile, vheader, vline, sqlstring, poscode As String
            Dim USERNAME, REMARKS, KOTNO As String
            Dim Filewrite As StreamWriter
            Dim vpagenumber, Vrowcount, innercount As Long
            Dim addUser As String
            gCompanyname = MyCompanyName
            Gheader = Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Chr(15) & Mid(gCompanyname, 1, 35) & Space(35 - Len(Mid(gCompanyname, 1, 35))) & Chr(20) & Chr(27) & Chr(72)
            vpagenumber = 1
            '''************************************* Create .TXT file and write text *****************************'''
            Call Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
            '''**************************************** Select data from KOTDETAILS ******************************'''
            sqlstring = " SELECT ISNULL(D.KOTDETAILS,'') AS KOTDETAILS,ISNULL(D.KOTDATE,GETDATE()) AS KOTDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE,isnull(h.roomno,'') as roomno,isnull(h.guest,'') as guest,ISNULL(paymenttype,'') as paymenttype,isnull(H.servicelocation,'') as servicelocation,"
            sqlstring = sqlstring & " ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(D.POSCODE,'') AS POSCODE,ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,"
            sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(H.PRINTFLAG,'') PRINTFLAG,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.SERVERCODE,'') AS SERVERCODE,"
            sqlstring = sqlstring & " ISNULL(H.SERVERNAME,'') AS SERVERNAME,ISNULL(H.REMARKS,'') AS REMARKS, ISNULL(D.KOTSTATUS,'') AS KOTSTATUS, ISNULL(H.DELFLAG,'') AS DELFLAG,H.ADDUSERID AS USERID FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS WHERE H.KOTDETAILS='" & Trim(Me.txt_KOTno.Text) & "' ORDER BY POSCODE"
            gconnection.getDataSet(sqlstring, "KOTHDR")
            If gdataset.Tables("KOTHDR").Rows.Count > 0 Then
                Filewrite = File.AppendText(vFilepath)
                vline = ""
                servicelocation = gdataset.Tables("KOTHDR").Rows(0).Item("servicelocation")
                poscode = gdataset.Tables("KOTHDR").Rows(0).Item("Poscode")
                addUser = gdataset.Tables("KOTHDR").Rows(0).Item("USERID")
                KOTNO = gdataset.Tables("KOTHDR").Rows(0).Item("KOTDETAILS")
                USERNAME = gdataset.Tables("KOTHDR").Rows(0).Item("USERID")
                REMARKS = gdataset.Tables("KOTHDR").Rows(0).Item("REMARKS")
                Filewrite.WriteLine(Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Chr(18) & Chr(20) & Chr(27) & Chr(72))
                For rowj = 0 To gdataset.Tables("KOTHDR").Rows.Count - 1
                    CountItem = CountItem + 1
                    With gdataset.Tables("KOTHDR").Rows(rowj)
                        If poscode <> .Item("POSCODE") Then
                            innercount = 0
                            Filewrite.WriteLine(StrDup(39, "-"))
                            Filewrite.WriteLine("{0,-5}{1,-5}", "PREPARED BY :", addUser)
                            Filewrite.WriteLine("{0,-10}{1,-20}", "REMARKS  : ", Trim(Txt_Remarks.Text))
                            poscode = .Item("POSCODE")
                            CountItem = 1
                            For i = 1 To 15
                                Filewrite.WriteLine("")
                            Next
                            Filewrite.WriteLine(Gheader)
                            'Filewrite.WriteLine(Space(11) & Chr(14) & Chr(15) & "KITCHEN ORDER TICKET")
                            If gdataset.Tables("KOTHDR").Rows(0).Item("DELFLAG") = "Y" Then
                                Filewrite.WriteLine("")
                                Filewrite.WriteLine(Space(10) & Chr(27) + "E" & "D E L E T E D  V O U C H E R" & Chr(27) + "F")
                            Else
                                If gdataset.Tables("KOTHDR").Rows(0).Item("PRINTFLAG") = "Y" Then
                                    Filewrite.WriteLine("")
                                    Filewrite.WriteLine(Space(6) & Chr(18) & Chr(14) & "D U P L I C A T E")
                                End If
                            End If
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine("{0,-6}{1,-25}", Chr(14) & Chr(15) & "KOT NO :", Mid(Trim(.Item("KOTDETAILS")), 1, 25))
                            If .Item("ROOMNO") = "" Then
                                Filewrite.WriteLine("{0,-12}{1,-25}", Trim("MEMB NO :"), Mid(Chr(14) & Chr(15) & Trim(.Item("MCODE")) & " [" & Trim(.Item("MNAME")) & "]", 1, 35))
                            Else
                                Filewrite.WriteLine("{0,-12}{1,-35}", "ROOM NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("ROOMNO")) & "[" & Trim(.Item("GUEST")) & "]", 1, 35))
                            End If
                            Filewrite.WriteLine("{0,-10}{1,-20}", "BEARER  :", Mid(Chr(14) & Chr(15) & Trim(.Item("SERVERCODE")) & " [ " & Trim(.Item("SERVERNAME")) & " ]", 1, 20) & Chr(18))
                            Filewrite.WriteLine("{0,-6}{1,-15}{2,-3}{3,10}", "DATE  :", Mid(Trim(Format(dtp_KOTdate.Value, "dd-MMM-yyyy")), 1, 15), "TIME:", Mid(Trim(txt_KOTTime.Text), 1, 10))
                            Filewrite.WriteLine(StrDup(40, "-"))
                            Filewrite.WriteLine("SLNO ITEM DESCRIPTION       UOM    QTY")
                            Filewrite.WriteLine(StrDup(40, "-"))
                            Filewrite.WriteLine("{0,-12}{1,-20}", "KITCHEN :", Chr(14) & Chr(15) & gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & poscode & "'"))
                            Filewrite.WriteLine(StrDup(20, "-"))
                            Vrowcount = 12
                            poscode = gdataset.Tables("KOTHDR").Rows(rowj).Item("Poscode")
                            addUser = gdataset.Tables("KOTHDR").Rows(rowj).Item("USERID")
                            KOTNO = gdataset.Tables("KOTHDR").Rows(rowj).Item("KOTDETAILS")
                            USERNAME = gdataset.Tables("KOTHDR").Rows(rowj).Item("USERID")
                            REMARKS = gdataset.Tables("KOTHDR").Rows(rowj).Item("REMARKS")
                        End If
                        If KOTNO <> .Item("KOTDETAILS") Then
                            'For i = 1 To 12 - innercount
                            '    Filewrite.WriteLine()
                            'Next i
                            innercount = 0
                            Filewrite.WriteLine(StrDup(40, "-"))
                            Filewrite.WriteLine("{0,-5}{1,-5}", "PREPARED BY :", addUser)
                            Filewrite.WriteLine("{0,-10}{1,-20}", "REMARKS  : ", Trim(Txt_Remarks.Text))
                            poscode = .Item("POSCODE")
                            CountItem = 1
                            For i = 1 To 15
                                Filewrite.WriteLine()
                            Next i

                            Filewrite.WriteLine(Gheader)
                            Filewrite.WriteLine(Space(11) & Chr(14) & Chr(15) & "KITCHEN ORDER TICKET")
                            If gdataset.Tables("KOTHDR").Rows(0).Item("DELFLAG") = "Y" Then
                                Filewrite.WriteLine("")
                                Filewrite.WriteLine(Space(10) & Chr(27) + "E" & "D E L E T E D  V O U C H E R" & Chr(27) + "F")
                            Else
                                If gdataset.Tables("KOTHDR").Rows(0).Item("PRINTFLAG") = "Y" Then
                                    Filewrite.WriteLine("")
                                    Filewrite.WriteLine(Space(6) & Chr(18) & Chr(14) & "D U P L I C A T E")
                                End If
                            End If
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine("{0,-6}{1,-25}", "KOT NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("KOTDETAILS")), 1, 40) & Chr(18))
                            If .Item("ROOMNO") = "" Then
                                Filewrite.WriteLine("{0,-12}{1,-32}", Trim("MEMB NO:"), Mid(Chr(14) & Chr(15) & Trim(.Item("MCODE")) & " [" & Trim(.Item("MNAME")) & "]", 1, 32))
                            Else
                                Filewrite.WriteLine("{0,-12}{1,-32}", "ROOM NO:", Mid(Chr(14) & Chr(15) & Trim(.Item("ROOMNO")) & "[" & Trim(.Item("GUEST")) & "]", 1, 32))
                            End If
                            Filewrite.WriteLine("{0,-10}{1,-20}", "BEARER:", Mid(Chr(14) & Chr(15) & Trim(.Item("SERVERCODE")) & " [ " & Trim(.Item("SERVERNAME")) & " ]", 1, 20))
                            Filewrite.WriteLine("{0,-6}{1,-15}{2,-3}{3,10}", "DATE  :", Mid(Trim(Format(dtp_KOTdate.Value, "dd-MMM-yyyy")), 1, 15), "TIME:", Mid(Trim(txt_KOTTime.Text), 1, 10))
                            Filewrite.WriteLine(StrDup(40, "-"))
                            Filewrite.WriteLine("SLNO ITEM DESCRIPTION       UOM    QTY")
                            Filewrite.WriteLine(StrDup(40, "-"))
                            Filewrite.WriteLine("{0,-12}{1,-20}", "KITCHEN :", Chr(14) & Chr(15) & gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & poscode & "'"))
                            Filewrite.WriteLine(StrDup(20, "-"))
                            Filewrite.WriteLine("")

                            Vrowcount = 12
                            poscode = gdataset.Tables("KOTHDR").Rows(rowj).Item("Poscode")
                            addUser = gdataset.Tables("KOTHDR").Rows(rowj).Item("USERID")
                            KOTNO = gdataset.Tables("KOTHDR").Rows(rowj).Item("KOTDETAILS")
                            USERNAME = gdataset.Tables("KOTHDR").Rows(rowj).Item("USERID")
                            REMARKS = gdataset.Tables("KOTHDR").Rows(rowj).Item("REMARKS")
                        End If
                    End With
                    With gdataset.Tables("KOTHDR").Rows(rowj)
                        If Vrowcount = 0 Then
                            vheader = Gheader
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine(Gheader)
                            Filewrite.WriteLine(Space(11) & Chr(14) & Chr(15) & "KITCHEN ORDER TICKET")
                            If gdataset.Tables("KOTHDR").Rows(0).Item("DELFLAG") = "Y" Then
                                Filewrite.WriteLine("")
                                Filewrite.WriteLine(Space(10) & Chr(27) + "E" & "D E L E T E D  V O U C H E R" & Chr(27) + "F")
                                Filewrite.WriteLine("")
                            Else
                                If gdataset.Tables("KOTHDR").Rows(0).Item("PRINTFLAG") = "Y" Then
                                    Filewrite.WriteLine("")
                                    Filewrite.WriteLine(Space(6) & Chr(18) & Chr(14) & "D U P L I C A T E")
                                    Filewrite.WriteLine("")
                                End If
                            End If
                            Filewrite.WriteLine("{0,-6}{1,-40}", "KOT NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("KOTDETAILS")), 1, 40))
                            If .Item("ROOMNO") = "" Then
                                Filewrite.WriteLine("{0,-12}{1,-32}", Trim("MEMB NO:"), Mid(Chr(14) & Chr(15) & Trim(.Item("MCODE")) & " [" & Trim(.Item("MNAME")) & "]", 1, 32))
                            Else
                                Filewrite.WriteLine("{0,-12}{1,-32}", "ROOM NO:", Mid(Chr(14) & Chr(15) & Trim(.Item("ROOMNO")) & "[" & Trim(.Item("GUEST")) & "]", 1, 32))
                            End If
                            Filewrite.WriteLine("{0,-10}{1,-20}", "BEARER:", Mid(Chr(14) & Chr(15) & Trim(.Item("SERVERCODE")) & " [ " & Trim(.Item("SERVERNAME")) & " ]", 1, 20) & Chr(18))
                            Filewrite.WriteLine("{0,-6}{1,-15}{2,-3}{3,10}", "DATE  :", Mid(Trim(Format(dtp_KOTdate.Value, "dd-MMM-yyyy")), 1, 15), "TIME:", Mid(Trim(txt_KOTTime.Text), 1, 10))
                            Filewrite.WriteLine(StrDup(40, "-"))
                            Filewrite.WriteLine("SLNO ITEM DESCRIPTION       UOM    QTY")
                            Filewrite.WriteLine(StrDup(40, "-"))
                            Filewrite.WriteLine("{0,-12}{1,-20}", "KITCHEN :", Chr(14) & Chr(15) & gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & poscode & "'"))
                            Filewrite.WriteLine(StrDup(25, "-"))
                            Filewrite.WriteLine("")
                            Vrowcount = 12
                        End If
                    End With
                    With gdataset.Tables("KOTHDR").Rows(rowj)
                        Filewrite.Write(Chr(18) & "{0,-3}{1,-24}{2,8}{3,5}", Mid(CountItem, 1, 2) & ".", Mid(Trim(.Item("ITEMDESC") & ""), 1, 23) & Space(23 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 23))), Mid(Trim(.Item("uom") & ""), 1, 8) & Space(8 - Len(Mid(Trim(.Item("uom") & ""), 1, 8))), Format(Val(.Item("QTY")), "0.00"))
                        Filewrite.WriteLine("")
                        innercount = innercount + 1
                        Vrowcount = Vrowcount + 1
                    End With
                Next rowj
                innercount = 0
                Filewrite.WriteLine(StrDup(40, "-"))
                Filewrite.WriteLine("AREA        :" & Trim(TXT_LOCATIONNAME.Text))
                Filewrite.WriteLine("{0,-5}{1,-5}", "PREPARED BY :", addUser)
                Filewrite.WriteLine("{0,-10}{1,-20}", "REMARKS     : ", Trim(Txt_Remarks.Text))
                For i = 1 To 12
                    Filewrite.WriteLine("")
                Next
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    INSERT(0) = "UPDATE KOT_HDR SET PRINTFLAG='Y' WHERE KOTDETAILS='" & Trim(txt_KOTno.Text) & "'"
                    gconnection.MoreTransold1(INSERT)

                    PrintTextFile1(vFilepath)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BillingUpdation()
        Dim sql, taxcode, cancel As String
        Dim i, x, y As Integer
        For i = 1 To ssGrid.DataRowCnt
            ssGrid.Col = 10
            ssGrid.Row = i
            taxcode = Trim(ssGrid.Text)
            ssGrid.Col = 12
            ssGrid.Row = i
            cancel = Trim(ssGrid.Text)
            If Val(cancel) = 0 Then
                x = Nothing
                y = Nothing
                If Trim(taxcode) = "" Then
                    ssGrid.Col = 8
                    ssGrid.Row = i
                    x = Trim(ssGrid.Text)
                    BillNontaxamount = 0
                    BillNontotalamount = BillNontotalamount + Val(x)
                Else
                    ssGrid.Col = 7
                    ssGrid.Row = i
                    y = Trim(ssGrid.Text)
                    ssGrid.Col = 8
                    ssGrid.Row = i
                    x = Trim(ssGrid.Text)
                    Billtaxamount = Billtaxamount + Val(y)
                    Billtotalamount = Billtotalamount + Val(x)
                End If
            End If
        Next i
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
    Private Sub KOTEntry_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        kotentrybool = False
        If kotupdate = True Then
            Dim objfinalbill As New KOT_Billing
            'objfinalbill.FormBorderStyle = FormBorderStyle.FixedDialog
            objfinalbill.Show()
            objfinalbill.MdiParent = MDIParentobj
            objfinalbill.BillValidate(Trim(billno))
        End If
    End Sub

    Private Sub GridLockValidations(ByVal RowCount As Integer)
        Dim i, j As Integer
        For i = 1 To 100
            For j = 1 To 5
                ssGrid.Col = j
                ssGrid.Row = i
                ssGrid.Lock = False
            Next j
        Next i
        For i = RowCount To 100
            For j = 1 To 5
                ssGrid.Col = j
                ssGrid.Row = i
                ssGrid.Lock = True
            Next j
        Next i
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
    Private Sub GridColUnLock(ByVal ColNo As Integer)
        Dim i, j As Integer
        For i = 1 To 100
            'For j = 1 To 5
            ssGrid.Col = ColNo
            ssGrid.Row = i
            ssGrid.Lock = False
            'Next j
        Next i
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
    Private Sub Enabledcontrol()
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
    Private Sub gridlock_new()
        Dim Row, Col As Integer
        For Row = 1 To 100
            For Col = 1 To 18
                ssGrid.Row = Row
                ssGrid.Col = Col
                ssGrid.Lock = True
            Next
        Next Row
    End Sub
    Public Sub KOTNoValidate(ByVal KOTNO As String)
        Dim vTypeseqno, vGroupseqno As Double
        Dim vString, sqlstring As String
        Dim a As System.EventArgs
        Dim dt As New DataTable
        Dim j, i As Integer
        Dim STRBILLNO, strbillno2 As String
        Try
            If Trim(KOTNO) <> "" Then
                sqlstring = "SELECT DISTINCT isnull(BILLDETAILS,'') as billdetails FROM KOT_DET WHERE KOTDETAILS='" & Trim(KOTNO) & "'"
                gconnection.getDataSet(sqlstring, "KOT_DET")
                If gdataset.Tables("KOT_DET").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("KOT_DET").Rows.Count - 1
                        If Trim(STRBILLNO) = "" Then
                            STRBILLNO = Trim(gdataset.Tables("KOT_DET").Rows(i).Item("BILLDETAILS"))
                        Else
                            strbillno2 = Trim(gdataset.Tables("KOT_DET").Rows(i).Item("BILLDETAILS"))
                        End If
                    Next
                    ' lblBillno1.Text = STRBILLNO
                    If STRBILLNO <> "" Then
                        STRBILLNO = Trim(STRBILLNO)
                        lblBillno1.Visible = True
                        lblBillno1.Text = STRBILLNO
                    End If
                    If strbillno2 <> "" Then
                        strbillno2 = Trim(strbillno2)
                        lblBillno2.Visible = True
                        lblBillno2.Text = strbillno2
                    End If
                End If
                sqlstring = "SELECT ISNULL(BTYPE,0) AS BTYPE1,ISNULL(PACKAMT,0) as PACKAMT,ISNULL(DISCOUNTAMT,0) as DISCOUNTAMT,ISNULL(REMARKS,'') AS REMARKS,ISNULL(MCode,'') AS MCode,ISNULL(MNAME,'') AS MNAME,* FROM KOT_HDR "
                'sqlstring = sqlstring & " WHERE KOTNO='" & Format(Val(KOTNO), "000000") & "'  AND DOCTYPE ='SALE' OR KOTDETAILS='" & Trim(KOTNO) & "' AND DOCTYPE ='SALE'"
                sqlstring = sqlstring & " WHERE KOTNO='" & KOTNO & "'  --AND DOCTYPE ='SALE' OR KOTDETAILS='" & Trim(KOTNO) & "' AND DOCTYPE ='SALE'"
                gconnection.getDataSet(sqlstring, "KOT_HDR")
                '''************************************************* SELECT record from KOT_HDR *********************************************''''                
                If gdataset.Tables("KOT_HDR").Rows.Count > 0 Then
                    ''===============
                    Call GridUnLock()
                    ''===============
                    ''Call CROGRIDLOCK()
                    'ssGrid.Col = 12

                    ''Call GridColUnLock(9)
                    ssGrid.ClearRange(1, 1, -1, -1, True)
                    Cmd_Add.Text = "Update[F7]"
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
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
                                Me.Lbl_Bill.Text = "B I L L  G E N E R A T E D"
                                Call disablecontrols()
                            Else
                                If Trim(gdataset.Tables("Kot_Hdr").Rows(0).Item("CroStatus")) = "N" Then
                                    Me.Lbl_Bill.Text = "B I L L  G E N E R A T E D"
                                    Call disablecontrols()
                                Else
                                    Me.Lbl_Bill.Text = "C R O G E N E R A T E D"
                                    Call disablecontrols()
                                    Call CROGRIDLOCK()
                                End If
                            End If
                        Else
                            Me.Lbl_Bill.Visible = True
                            Me.Lbl_Bill.Text = "B I L L NOT G E N E R A T E D"
                        End If
                    Else
                        Me.Lbl_Bill.Visible = True
                        Me.Lbl_Bill.Text = "B I L L NOT G E N E R A T E D"
                    End If
                    If gdataset.Tables("KOT_HDR").Rows(0).IsNull("delflag") = False Then
                        If Trim(gdataset.Tables("Kot_Hdr").Rows(0).Item("delflag")) = "Y" Then
                            Me.Cmd_Add.Enabled = False
                            Me.cmd_Delete.Enabled = False
                            Call disablecontrols()
                            Call CROGRIDLOCK()
                            Me.Lbl_Bill.Text = "K O T   D E L E T E D"
                            Lbl_Bill.ForeColor = Color.Red
                            'SHAN0505
                        End If
                    End If
                    KOT_Timer.Enabled = False
                    txt_KOTno.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("Kotdetails") & "")
                    dtp_KOTdate.Value = Format(CDate(gdataset.Tables("KOT_HDR").Rows(0).Item("Kotdate")), "dd-MMM-yy")
                    txt_KOTTime.Text = Format(CDate(gdataset.Tables("KOT_HDR").Rows(0).Item("Kotdate")), "hh:mm:ss")
                    'txt_KOTTime.Text = DateAdd(DateInterval.Minute, (-65 - gdataset.Tables("KOT_HDR").Rows(0).Item("Kotdate").Minute), serverdate).ToLongTimeString
                    txt_TableNo.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("tableno") & "")
                    txt_Cover.Text = Val(gdataset.Tables("KOT_HDR").Rows(0).Item("Covers"))
                    txt_ServerCode.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("ServerCode") & "")
                    txt_ServerName.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("ServerName") & "")
                    'smart card
                    txt_Holder_Code.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("CARDHOLDERCODE") & "")
                    Txt_holder_name.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("CARDHOLDERNAME") & "")
                    cardcode = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("CARDHOLDERCODE") & "")
                    txt_card_id.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("16_digit_code") & "")

                    txt_LOCATIONCODE.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("SERVICELOCATION") & "")
                    txt_TotalValue.Text = Format(Val(gdataset.Tables("KOT_HDR").Rows(0).Item("Total")), "0.00")
                    txt_TaxValue.Text = Format(Val(gdataset.Tables("KOT_HDR").Rows(0).Item("TotalTax")), "0.00")
                    txt_BillAmount.Text = Format(Val(gdataset.Tables("KOT_HDR").Rows(0).Item("BillAmount")), "0.00")
                    cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_PaymentMode.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("PaymentType") & "")
                    CMB_BTYPE.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("BTYPE1") & "")

                    'Call txt_LOCATIONCODE_Validated()
                    If Me.Lbl_Bill.Text = "B I L L  G E N E R A T E D" Then
                        'Modified on 18 Mar'08
                        'Mk Kannan
                        'Begin
                        Me.Cmd_Add.Enabled = False
                        Me.cmd_Delete.Enabled = False
                        'End
                        cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDown
                        If Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("PaymentType")) = "CLUB" Then
                            txt_MemberCode.Visible = False
                            txt_MemberName.Visible = False
                            lbl_Membercode.Visible = False
                            lbl_MemberName.Visible = False
                            cmd_MemberCodeHelp.Visible = False
                        End If
                    Else
                        cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
                    End If
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
                        lbl_Membercode.Text = "ROOM NO"
                        lbl_MemberName.Text = "GUEST NAME"
                        'Modified on 15 Mar'08
                        'Mk Kannan
                        'Begin
                        'ElseIf Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("PaymentType")) = "R.MEMBER" Or Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("PaymentType")) = "COUPON" Then
                        'txt_MemberCode.Visible = False
                        'txt_MemberName.Visible = False
                        'lbl_Membercode.Visible = False
                        'lbl_MemberName.Visible = False
                        'cmd_MemberCodeHelp.Visible = False
                        'txt_MemberCode.Text = ""
                        'txt_MemberName.Text = ""
                    Else

                        If Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("MCode")) & "" <> "" And Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("Mname")) & "" <> "" Then
                            txt_MemberCode.Visible = True
                            txt_MemberName.Visible = True
                            lbl_Membercode.Visible = True
                            lbl_MemberName.Visible = True
                            cmd_MemberCodeHelp.Visible = True
                            lbl_Membercode.Text = "MEMBER CODE"
                            lbl_MemberName.Text = "MEMBER NAME"
                            txt_MemberCode.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("MCode")) & ""
                            txt_MemberName.Text = Trim(gdataset.Tables("KOT_HDR").Rows(0).Item("Mname")) & ""
                        Else
                            txt_MemberCode.Visible = False
                            txt_MemberName.Visible = False
                            lbl_Membercode.Visible = False
                            lbl_MemberName.Visible = False
                            cmd_MemberCodeHelp.Visible = False
                            txt_MemberCode.Text = ""
                            txt_MemberName.Text = ""
                        End If
                    End If
                    '''************************************************* SELECT record from KOT_DET *********************************************''''                
                    sqlstring = "SELECT ISNULL(SALESACCOUNTCODE,0) AS SALESACCOUNTCODE,ISNULL(TAXACCOUNTCODE,0) AS TAXACCOUNTCODE,ISNULL(GROUPCODE,0) AS GROUPCODE,* FROM KOT_DET WHERE  KOTdetails='" & Trim(txt_KOTno.Text) & "' ORDER BY Autoid "
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
                            'REFERINVENTORY***********************************************************************
                            ssGrid.SetText(18, i, Val(gdataset.Tables("KOT_DET").Rows(j).Item("Qty")))
                            '*************************************************************************************
                            If CStr(gdataset.Tables("KOT_DET").Rows(j).Item("KOTStatus") & "") = "Y" Then
                                ssGrid.SetText(12, i, 1)
                            Else
                                ssGrid.SetText(12, i, 0)
                            End If
                            j = j + 1
                        Next
                    End If
                    'Call GridLockValidations(ssGrid.DataRowCnt)
                    'modify  by saran
                    'Call gridlock_new()
                    'Call GridColUnLock(12)
                    'end
                    TotalItemCount = gdataset.Tables("KOT_DET").Rows.Count
                    'ssGrid.SetActiveCell(1, 1)
                    'cbo_PaymentMode.Focus()
                    txt_MemberCode.Focus()
                    cmd_KOTnoHelp.Enabled = False
                Else
                    'MessageBox.Show("Enter valid KOT No ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    'Call cmd_Clear_Click(cmd_Clear, a)
                End If
                'cbo_PaymentMode.Focus()
                txt_MemberCode.Focus()
                cmd_KOTnoHelp.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Enter valid KOT No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Call cmd_Clear_Click(cmd_Clear, a)
            Exit Sub
        End Try
    End Sub
    Private Function LessStockBalance(ByVal Itemcode As String, ByVal Poscode As String, ByVal Uom As String, ByVal Qty As Integer, ByVal Operation As String) As String()
        Dim Gitemcode, Guom, Stockuom As String
        Dim Ratio, Eoq, Stockqty, doubleuom As Double
        Dim ssql, Update() As String
        Dim Updatebool As Boolean
        Dim Gqty As Double
        Dim i As Integer
        ssql = "SELECT Itemcode,ItemUom FROM cocktailratio_hdr WHERE='" & Trim(Itemcode) & "'" 'PosItem
        gconnection.getDataSet(ssql, "CockTail")
        If gdataset.Tables("Cocktail").Rows.Count > 0 Then
            ssql = "SELECT * FROM UOMRelation WHERE Uom1='" & Uom & "' AND Uom2 ='" & gdataset.Tables("CockTail").Rows(0).Item(1) & "'"
            gconnection.getDataSet(ssql, "UOM")
            If gdataset.Tables("UOM").Rows.Count > 0 Then
                Ratio = gdataset.Tables("UOM").Rows(0).Item("Ratio2")
                Qty = Val(Qty) * Val(Ratio)
            Else
                MessageBox.Show("Uom Relations not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If
            ssql = "SELECT Eoq,GitemCode,Guom,Gqty FROM cocktailratio_Det WHERE='" & Trim(Itemcode) & "'"
            gconnection.getDataSet(ssql, "CockDet")
            If gdataset.Tables("Cocktail").Rows.Count > 0 Then
                Eoq = Val(gdataset.Tables("CockDet").Rows(0).Item("Eoq"))
                For i = 0 To gdataset.Tables("Cockdet").Rows.Count - 1
                    Gqty = Val(gdataset.Tables("CockDet").Rows(0).Item("Gqty"))
                    Gqty = Val(Gqty) / Val(Eoq)
                    Gitemcode = Val(gdataset.Tables("CockDet").Rows(0).Item("GitemCode"))
                    Guom = Val(gdataset.Tables("CockDet").Rows(0).Item("Guom"))
                    ssql = "SELECT  StockUom,ConvValue FROM InventoryItemMaster WHERE Itemcode='" & Gitemcode & "'"
                    gconnection.getDataSet(ssql, "InventoryItemMaster")
                    Stockuom = gdataset.Tables("InventoryItemMaster").Rows(0).Item("StockUom")
                    doubleuom = Val(Qty) * Val(Gqty)
                    Stockqty = Val(doubleuom) / Val(gdataset.Tables("InventoryItemMaster").Rows(0).Item("ConvValue"))
                    If Operation = "ADD/UPDATE" Then
                        If Poscode = "01" Then
                            ssql = "UPDATE OpeningStock SET "
                            ssql = ssql & " bar1doublevalue = bar1doublevalue + (" & Format(Val(doubleuom), "0.000") & " * HIGHRATIO ),"
                            ssql = ssql & " bar1clstock =  bar1clstock + " & Format(Val(Stockqty), "0.000") & " ,"
                            ssql = ssql & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssql = ssql & " WHERE Itemcode='" & Trim(Gitemcode) & "' "
                            If Updatebool = True Then
                                ReDim Preserve Update(Update.Length)
                                Update(Update.Length - 1) = ssql
                            Else
                                Update(0) = ssql
                                Updatebool = True
                            End If
                        ElseIf Poscode = "02" Then
                            ssql = "UPDATE OpeningStock SET "
                            ssql = ssql & " bar2doublevalue = bar2doublevalue + (" & Format(Val(doubleuom), "0.000") & " * HIGHRATIO ),"
                            ssql = ssql & " bar2clstock =  bar2clstock + " & Format(Val(Stockqty), "0.000") & " ,"
                            ssql = ssql & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssql = ssql & " WHERE Itemcode='" & Trim(Gitemcode) & "' "
                            If Updatebool = True Then
                                ReDim Preserve Update(Update.Length)
                                Update(Update.Length - 1) = ssql
                            Else
                                Update(0) = ssql
                                Updatebool = True
                            End If
                        ElseIf Poscode = "03" Then
                            ssql = "UPDATE OpeningStock SET "
                            ssql = ssql & " bar3doublevalue = bar3doublevalue + (" & Format(Val(doubleuom), "0.000") & " * HIGHRATIO ),"
                            ssql = ssql & " bar3clstock =  bar3clstock + " & Format(Val(Stockqty), "0.000") & " ,"
                            ssql = ssql & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssql = ssql & " WHERE Itemcode='" & Trim(Gitemcode) & "' "
                            If Updatebool = True Then
                                ReDim Preserve Update(Update.Length)
                                Update(Update.Length - 1) = ssql
                            Else
                                Update(0) = ssql
                                Updatebool = True
                            End If
                        End If
                    ElseIf Operation = "DET" Then
                        If Poscode = "01" Then
                            ssql = "UPDATE OpeningStock SET "
                            ssql = ssql & " bar1doublevalue = bar1doublevalue - (" & Format(Val(doubleuom), "0.000") & " * HIGHRATIO ),"
                            ssql = ssql & " bar1clstock =  bar1clstock - " & Format(Val(Stockqty), "0.000") & " ,"
                            ssql = ssql & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssql = ssql & " WHERE Itemcode='" & Trim(Gitemcode) & "' "
                            If Updatebool = True Then
                                ReDim Preserve Update(Update.Length)
                                Update(Update.Length - 1) = ssql
                            Else
                                Update(0) = ssql
                                Updatebool = True
                            End If
                        ElseIf Poscode = "02" Then
                            ssql = "UPDATE OpeningStock SET "
                            ssql = ssql & " bar2doublevalue = bar2doublevalue - (" & Format(Val(doubleuom), "0.000") & " * HIGHRATIO ),"
                            ssql = ssql & " bar2clstock =  bar2clstock - " & Format(Val(Stockqty), "0.000") & " ,"
                            ssql = ssql & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssql = ssql & " WHERE Itemcode='" & Trim(Gitemcode) & "' "
                            If Updatebool = True Then
                                ReDim Preserve Update(Update.Length)
                                Update(Update.Length - 1) = ssql
                            Else
                                Update(0) = ssql
                                Updatebool = True
                            End If
                        ElseIf Poscode = "03" Then
                            ssql = "UPDATE OpeningStock SET "
                            ssql = ssql & " bar3doublevalue = bar3doublevalue - (" & Format(Val(doubleuom), "0.000") & " * HIGHRATIO ),"
                            ssql = ssql & " bar3clstock =  bar3clstock - " & Format(Val(Stockqty), "0.000") & " ,"
                            ssql = ssql & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssql = ssql & " WHERE Itemcode='" & Trim(Gitemcode) & "' "
                            If Updatebool = True Then
                                ReDim Preserve Update(Update.Length)
                                Update(Update.Length - 1) = ssql
                            Else
                                Update(0) = ssql
                                Updatebool = True
                            End If
                        End If
                    End If
                Next
            End If
        End If
        Return Update
    End Function
    Private Sub FillDefaultPayment()
        Dim Sqlstring As String
        Dim index As Integer
        Sqlstring = "SELECT ISNULL(BillPaymentMode,'') AS BillPaymentMode, ISNULL(BILLROUNDOFF,'') AS BILLROUNDOFF FROM POSSETUP"
        gconnection.getDataSet(Sqlstring, "POSSETUP")
        If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
            DefaultPayment = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPaymentMode"))
            BILLROUNDYESNO = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BILLROUNDOFF"))
            index = cbo_PaymentMode.FindString(DefaultPayment)
            cbo_PaymentMode.SelectedIndex = index
        Else
            DefaultPayment = "CREDIT"
        End If
    End Sub
    Private Sub UserValidation()
        'Added on 06 Apr'08 for Generating Usernamewise KOT
        'Advised by :- Sandeep after having discussion with him at 06 Apr'08 Mid Night 11.30 P.M
        'Mk Kannan
        'Begin
        'Dim sqlstring As String
        'sqlstring = "Select * from PosKotDoc Where UserName = '" & gUsername & "'"
        'gconnection.getDataSet(sqlstring, "PosKotDoc")
        'If gdataset.Tables("PosKotDoc").Rows.Count = 0 Then
        '    lbl_Status.Text = ""
        '    lblUser.Text = "User Name is not Authorised!"
        '    Cmd_Add.Enabled = False
        'Else
        '    lblUser.Visible = False
        'End If
        'End
    End Sub
    Private Sub RateCalculate()
        Dim i As Integer
        Dim cancel, kotstatus As String
        Dim dblTotalamount, dblTaxamount, cancelamt, canceltax As Double
        Dim Billamount, dblCalqty, dblTaxperc, dblCalRate, dblPackPercent, dblPackAmount As Double
        ssGrid.Col = 19
        ssGrid.Row = ssGrid.ActiveRow
        If Trim(ssGrid.Text) = "Y" Then
            If ssGrid.ActiveCol = 6 Or ssGrid.ActiveCol = 5 Or ssGrid.ActiveCol = 2 Or ssGrid.ActiveCol = 1 Then
                Me.txt_TaxValue.Text = "0.00"
                Me.txt_TotalValue.Text = "0.00"
                'Me.txt_PackingCharge.Text = "0.00"
                Me.txt_BillAmount.Text = "0.00"
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Col = 12
                    ssGrid.Row = i
                    kotstatus = ssGrid.Text
                    If Val(kotstatus) = 0 Then
                        ssGrid.Col = 5
                        ssGrid.Row = i
                        dblCalqty = Val(ssGrid.Text)
                        ssGrid.Col = 6
                        ssGrid.Row = i
                        dblCalRate = Val(ssGrid.Text)
                        ssGrid.Col = 11
                        ssGrid.Row = i
                        dblTaxperc = Val(ssGrid.Text)
                        ssGrid.Col = 17
                        ssGrid.Row = i
                        dblPackPercent = Val(ssGrid.Text)
                        dblTotalamount = Val(dblCalqty) * Val(dblCalRate)
                        dblTaxamount = (dblTotalamount * dblTaxperc) / 100
                        dblPackAmount = ((Val(dblTotalamount) + Val(dblTaxamount)) * dblPackPercent) / 100
                        ssGrid.SetText(8, i, dblTotalamount)
                        ssGrid.SetText(7, i, dblTaxamount)
                        ssGrid.SetText(18, i, dblPackAmount)
                        If BILLROUNDYESNO = "YES" Then
                            'Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Math.Round(Val(dblTotalamount)), "0.00")
                            'Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Math.Round(Val(dblTaxamount)), "0.00")
                            'Billamount = Format(Val(Me.txt_TaxValue.Text) + Math.Round(Val(Me.txt_TotalValue.Text)), "0.00")
                            'Me.txt_BillAmount.Text = Format(Billamount, "0.00")

                            Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(dblTotalamount), "0.00")
                            Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(dblTaxamount), "0.00")
                            Billamount = Format(Val(Me.txt_TaxValue.Text) + Val(Me.txt_TotalValue.Text), "0.00")
                            Me.txt_BillAmount.Text = Format(Billamount, "0.00")

                        Else
                            Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(dblTotalamount), "0.00")
                            Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(dblTaxamount), "0.00")
                            Billamount = Format(Val(Me.txt_TaxValue.Text) + Val(Me.txt_TotalValue.Text), "0.00")
                            Me.txt_BillAmount.Text = Format(Billamount, "0.00")
                        End If
                    End If
                Next i
            End If
            i = i - 1
        End If
    End Sub
    Private Sub ssGrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssGrid.Advance

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub txt_BillAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_BillAmount.TextChanged

    End Sub

    Private Sub txt_ServerCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ServerCode.TextChanged

    End Sub

    Private Sub lblUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUser.Click

    End Sub

    Private Sub ssGrid_KeyPressEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyPressEvent) Handles ssGrid.KeyPressEvent

    End Sub
    Private Sub txt_KOTno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_KOTno.TextChanged

    End Sub
    Private Sub lvw_POSCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvw_POSCode.SelectedIndexChanged
    End Sub
    Private Sub txt_MemberCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MemberCode.TextChanged

    End Sub
    Private Sub ssGrid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssGrid.Leave

    End Sub

    Private Sub grp_Memberdetails_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grp_Memberdetails.Enter

    End Sub
    Private Sub CMD_LOCHELP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_LOCHELP.Click
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
            txt_LOCATIONCODE.Text = Trim(vform.keyfield & "")
            TXT_LOCATIONNAME.Text = Trim(vform.keyfield1 & "")
            ssGrid.Focus()
            ssGrid.SetActiveCell(1, 1)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_LOCATIONCODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_LOCATIONCODE.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Me.cmd_ServerCodeHelp.Enabled = True Then
                Call CMD_LOCHELP_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub txt_LOCATIONCODE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_LOCATIONCODE.Validated
        Dim strstring As String
        Dim I As Integer
        If Trim(txt_LOCATIONCODE.Text) <> "" Then
            If Trim(txt_LOCATIONCODE.Text) <> "" Then
                strstring = "SELECT isnull(poscode,'') as poscode,isnull(posdesc,'') as posname FROM POSMASTER WHERE POSCODE='" & Trim(txt_LOCATIONCODE.Text) & "'AND ISNULL(Freeze,'')<>'Y'"
                gconnection.getDataSet(strstring, "LOCmaster")
                If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
                    txt_LOCATIONCODE.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
                    TXT_LOCATIONNAME.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosName")
                    ssGrid.SetActiveCell(1, 1)
                    ssGrid.Focus()
                Else
                    txt_LOCATIONCODE.Text = ""
                    TXT_LOCATIONNAME.Focus()
                End If
            Else
                txt_LOCATIONCODE.Focus()
            End If
        End If
    End Sub
    Private Sub txt_LOCATIONCODE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_LOCATIONCODE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_LOCATIONCODE.Text) <> "" Then
                txt_LOCATIONCODE_Validated(sender, e)
            Else
                Call CMD_LOCHELP_Click(CMD_LOCHELP, e)
            End If
        End If
    End Sub
    Private Sub txt_LOCATIONCODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_LOCATIONCODE.TextChanged
        'Dim strstring As String
        'Dim I As Integer
        'If Trim(txt_LOCATIONCODE.Text) <> "" Then
        '    If Trim(txt_LOCATIONCODE.Text) <> "" Then
        '        strstring = "SELECT isnull(poscode,'') as poscode,isnull(posdesc,'') as posname FROM POSMASTER WHERE POSCODE='" & Trim(txt_LOCATIONCODE.Text) & "'AND ISNULL(Freeze,'')<>'Y'"
        '        gconnection.getDataSet(strstring, "LOCmaster")
        '        If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
        '            txt_LOCATIONCODE.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
        '            TXT_LOCATIONNAME.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosName")
        '            ssGrid.SetActiveCell(1, 1)
        '            ssGrid.Focus()
        '        Else
        '            txt_LOCATIONCODE.Text = ""
        '            TXT_LOCATIONNAME.Focus()
        '        End If
        '    Else
        '        txt_LOCATIONCODE.Focus()
        '    End If
        'End If
    End Sub
    Private Sub txt_LOCATIONCODE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_LOCATIONCODE.LostFocus
        Dim strstring As String
        Dim I As Integer
        Try

            If Trim(txt_LOCATIONCODE.Text) <> "" Then
                If Trim(txt_LOCATIONCODE.Text) <> "" Then
                    strstring = "SELECT isnull(poscode,'') as poscode,isnull(posdesc,'') as posname FROM POSMASTER WHERE POSCODE='" & Trim(txt_LOCATIONCODE.Text) & "'AND ISNULL(Freeze,'')<>'Y'"
                    gconnection.getDataSet(strstring, "LOCmaster")
                    If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
                        txt_LOCATIONCODE.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
                        TXT_LOCATIONNAME.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosName")
                        ssGrid.SetActiveCell(1, 1)
                        ssGrid.Focus()
                    Else
                        txt_LOCATIONCODE.Text = ""
                        TXT_LOCATIONNAME.Focus()
                    End If
                Else
                    txt_LOCATIONCODE.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txt_MemberCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.LostFocus
        ''Call outstanding()
    End Sub
    Private Sub txt_ServerCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ServerCode.LostFocus
        'Dim STRSQL As String
        'Dim chkno1 As Integer
        'Try
        '    If txt_ServerCode.Text <> "" And txt_KOTno.Text <> "" Then
        '        STRSQL = " Select * From Kotbook Where "
        '        STRSQL = STRSQL & "Convert(Int," & Val(txt_KOTno.Text) & ")  BetWeen convert(int,SnoFrom) AND convert(int,SnoTO) And SERVERCODE='" & txt_ServerCode.Text & "'  and isnull(delflag,'') <> 'Y' "
        '        gconnection.getDataSet(STRSQL, "servermaster")
        '        If gdataset.Tables("servermaster").Rows.Count = 0 Then
        '            MessageBox.Show(" KOTNO MISMATCH FOR THIS USER,KINDLY CHECK IT", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '            txt_KOTno.Text = ""
        '            txt_ServerCode.Text = ""
        '            txt_KOTno.Focus()
        '        Else
        '            'txt_KOTno.Text = Mid(txt_KOTno.Text, 1, 3) & CStr(Val(Mid(txt_KOTno.Text, 4, 10)))
        '            txt_KOTno.Text = CStr(Val(txt_KOTno.Text))
        '            '==========
        '            'STRSQL = " Select * From Kotbook Where SNOFROM=" & CStr(Val(Mid(txt_KOTno.Text, 4, 10)))
        '            'STRSQL = STRSQL & " AND prefix='" & Mid(txt_KOTno.Text, 1, 3) & "'"
        '            'gconnection.getDataSet(STRSQL, "BOOKMST")
        '            'If gdataset.Tables("BOOKMST").Rows.Count = 0 Then
        '            '    STRSQL = " SELECT * FROM KOT_DET WHERE ISNULL(KOTDETAILS,'')='" & Mid(txt_KOTno.Text, 1, 3) & CStr(Val(Mid(txt_KOTno.Text, 4, 10))) - 1 & "'"
        '            '    gconnection.getDataSet(STRSQL, "KOTMST")
        '            '    If gdataset.Tables("KOTMST").Rows.Count = 0 Then
        '            '        MessageBox.Show("PLEASE ENTER THE PREVIOUS KOTNO,THANKING YOU!", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '            '        txt_KOTno.Text = ""
        '            '        txt_ServerCode.Text = ""
        '            '        txt_KOTno.Focus()
        '            '    End If
        '            'End If
        '            '=================
        '        End If
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub
    Private Sub CMB_BTYPE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMB_BTYPE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_KOTno.Focus()
        End If
    End Sub
    Private Sub CMB_BTYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_BTYPE.SelectedIndexChanged
        Dim LOC, strstring As String
        LOC = Trim(CMB_BTYPE.Text)
        strstring = " SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS PosName,ISNULL(DOCTYPE,'')  AS DOCTYPE  FROM  POSDOCUMENT WHERE ISNULL(FREEZE,'')<>'Y'  AND ISNULL(DOCTYPE,'')='" & Trim(LOC) & "'"
        gconnection.getDataSet(strstring, "LOCmaster")
        If gdataset.Tables("LOCmaster").Rows.Count > 0 Then
            txt_LOCATIONCODE.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosCode")
            TXT_LOCATIONNAME.Text = gdataset.Tables("Locmaster").Rows(0).Item("PosName")
            ssGrid.SetActiveCell(1, 1)
            ssGrid.Focus()
        Else
            txt_LOCATIONCODE.Text = ""
            TXT_LOCATIONNAME.Focus()
        End If
    End Sub
    Private Sub txt_KOTno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_KOTno.LostFocus
        Try
            Dim STRSQL As String
            If Trim(txt_KOTno.Text) <> "" Then
                STRSQL = "SELECT * FROM KOT_HDR WHERE KOTDETAILS='" & txt_KOTno.Text & "'"
                gconnection.getDataSet(STRSQL, "KOTNO")
                If gdataset.Tables("KOTNO").Rows.Count = 0 Then
                    STRSQL = " Select isnull(Prefix,'') as Prefix,isnull(Servercode,'') as Servercode From Kotbook "
                    STRSQL = STRSQL & "  Where  " & IIf(Val(txt_KOTno.Text) > 0, Val(txt_KOTno.Text), 0) & " between snofrom and  snoto "
                    gconnection.getDataSet(STRSQL, "servermaster")
                    If gdataset.Tables("servermaster").Rows.Count > 0 Then
                        txt_ServerCode.Text = gdataset.Tables("servermaster").Rows(0).Item("Servercode")
                        txt_ServerCode_Validated(sender, e)
                    End If
                End If
                Call CMD_LOCK()
            End If
            If txt_MemberCode.Text = "" Then
                txt_MemberCode.Focus()
            Else
                txt_ServerCode.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Cmd_ShowBill1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub CMB_BTYPE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles CMB_BTYPE.Validated
        'Call fillPayment_Mode()
        'Call FillDefaultPayment()
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
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
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
    Private Sub txt_card_id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_card_id.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(cbo_PaymentMode.Text) = "SMART CARD" Then
                Call txt_card_id_Validated(txt_card_id, e)
            Else
                'MsgBox("SELECT CORRECT PAYMENTMODE", MsgBoxStyle.Information)
                'txt_card_id.Text = ""
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
        Try


            'If Trim(txt_Holder_Code.Text) = "" Then
            '    Timer1.Enabled = False
            '    Exit Sub
            'End If
            If Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
                MessageBox.Show("PLEASE! SWIPE YOUR CARD", "CARD NOT SWIPED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = True
                txt_card_id.Focus()
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
                        LAB_CARDBAL.Text = ""
                        LAB_CARDBAL.Visible = False
                        txt_card_id.Focus()
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
                        '                    lbl_SwipeCard.Focus()
                        LAB_CARDBAL.Text = ""
                        LAB_CARDBAL.Visible = False
                        Exit Sub
                    End If
                    'DISPLAY BALNACE AMOUNT
                    BALANCE_HDR = Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00")
                    LAB_CARDBAL.Text = "CARD BALANCE :" & Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("BALANCE")), "0.00")

                    If Trim(cbo_PaymentMode.Text) = "SMART CARD" Then
                        LAB_CARDBAL.Visible = True
                    Else
                        LAB_CARDBAL.Visible = False
                    End If
                    'MIN_USAGE_BALANCE_HDR = Format(Val(gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("MIN_USG_BALANCE")), "0.00")
                Else
                    If txt_card_id.Text <> "" Then
                        MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txt_card_id.Text = ""
                        txt_card_id.Focus()
                    End If
                    LAB_CARDBAL.Text = ""
                    LAB_CARDBAL.Visible = False
                    'MessageBox.Show("Sorry! CARD EXPIRED " & ControlChars.CrLf & "Contact Smart Card Administration", "Validity Expires", MessageBoxButtons.OK)
                End If

                '''''''''SQLSTRING = " SELECT * FROM SYSDATA "
                '''''''''gconnection.getDataSet(SQLSTRING, "SYSDATA")
                '''''''''If gdataset.Tables("SYSDATA").Rows.Count > 0 Then
                '''''''''    If gdataset.Tables("SYSDATA").Rows.Count > 0 And Trim(txt_card_id.Text) <> "" Then
                '''''''''        If gdataset.Tables("SYSDATA").Rows(0).Item("OPPORTUNITY") <> Trim(Fast_Read_Card(4, 18)) Then
                '''''''''            MsgBox("INVALID CARD SECRET CODE ", MsgBoxStyle.Exclamation)
                '''''''''            txt_card_id.Clear()
                '''''''''            txt_card_id.Text = ""
                '''''''''            ' txt_card_id.Visible = False
                '''''''''            cbo_PaymentMode.Focus()
                '''''''''            Exit Sub
                '''''''''        End If
                '''''''''    End If
                '''''''''Else
                '''''''''    MsgBox("SECRET CODE NOT DEFINED")
                '''''''''End If
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
                If txt_card_id.Text <> "" Then
                    txt_MemberCode_Validated(sender, e)
                    '//txt_KOTno.Focus()
                    If txt_KOTno.Text <> "" Then
                        txt_ServerCode.Focus()
                    Else
                        txt_KOTno.ReadOnly = False
                        txt_KOTno.Focus()
                    End If
                End If
                'End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
            If gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("MEMBERSUBCODE") = "TE" Then
                Dim index As Integer
                index = cbo_PaymentMode.FindString("ROOM")
                cbo_PaymentMode.SelectedIndex = index
            End If
            'CHECKING ACTIVATION FLAG IS 'Y' OR 'N'
            Dim temp_flag As Char
            temp_flag = ""
            temp_flag = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ACTIVATION_FLAG")
            If temp_flag <> "Y" Then
                If cbo_PaymentMode.Text = "SMART CARD" Then
                    MessageBox.Show("SORRY! CARD IS DEACTIVATED", "CARD DEACTIVATED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    lbl_SwipeCard.Visible = True
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
                lbl_SwipeCard.Visible = True
                txt_card_id.Clear()
                txt_card_id.Focus()
                LAB_CARDBAL.Text = ""
                LAB_CARDBAL.Visible = False
                '                lbl_SwipeCard.Focus()
                Exit Function
            End If
            Dim ACCESS_CTL As String
            Dim strsql, STRSQL2 As String
            strsql = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & cardcode & "' AND POSCODE='" & StrPOSCODE & "'"
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
                    LAB_CARDBAL.Text = ""
                    LAB_CARDBAL.Visible = False
                    Exit Function
                End If
            Else
                MessageBox.Show(" PLEASE GET POS VALIDITY", "NO RIGHTS FOR POS USAGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_card_id.Clear()
                txt_card_id.Focus()
                '                lbl_SwipeCard.Focus()
                LAB_CARDBAL.Text = ""
                LAB_CARDBAL.Visible = False
                Exit Function
            End If
            'CHECKING ACTIVATION FLAG ENDS
            txt_MemberCode.Text = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("MEMBERCODE")
            If txt_MemberCode.Text <> "" Then
                txt_MemberCode.ReadOnly = True
            End If
            MCODE_GBL = Trim(txt_MemberCode.Text)
            'txt_MemberName.Text = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("NAME")
            NAME_GBL = gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("NAME")
            gconnection.getDataSet("SELECT MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(MCODE_GBL) & "'", "MEMBERMASTER")
            If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                MNAME_GBL = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MNAME")
                txt_MemberName.Text = MNAME_GBL
            End If

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



            'KARTHI JUNE 13
            'KARTHI JUNE 13
            If gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "MEM" Or gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TE" Then
                gconnection.getDataSet("SELECT MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(MCODE_GBL) & "'", "MEMBERMASTER")
                If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                    MNAME_GBL = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MNAME")
                    txt_MemberName.Text = MNAME_GBL
                End If
            ElseIf gdataset.Tables("SM_CARDFILE_HDR").Rows(0).Item("ISSUETYPE") = "TA" Then
                lbl_Membercode.Text = "CLUB CODE"
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
                ''KARTHI HIDE ACCESS CHECK AT RECEPTION 
                SQLSTRING = "SELECT CARDCODE FROM SM_MEMBERENTRY_LOG WHERE CARDCODE='" & Trim(txt_Holder_Code.Text) & "' AND CAST(CONVERT(VARCHAR(11),DATETIME,6) AS DATETIME ) = '" & Format(Date.Now, "dd/MMM/yyyy") & "'"
                gconnection.getDataSet(SQLSTRING, "SM_MEMBERENTRY_LOG")
                If gdataset.Tables("SM_MEMBERENTRY_LOG").Rows.Count = 0 Then
                    MessageBox.Show("SORRY! GET ACCESS AT RECEPTION", "GET ACCESS AT RECEPTION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    LAB_CARDBAL.Text = ""
                    LAB_CARDBAL.Visible = False
                    txt_card_id.Clear()
                    txt_card_id.Focus()
                    txt_MemberCode.Clear()
                    txt_MemberName.Clear()
                    Txt_holder_name.Clear()
                    txt_Holder_Code.Clear()
                    Pic_Member.Image = New Bitmap(AppPath & "\IMAGE.Jpg")
                    LAB_CARDBAL.Text = ""
                    LAB_CARDBAL.Visible = False
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
            If txt_KOTno.Text <> "" Then
                txt_ServerCode.Focus()
            Else
                txt_KOTno.ReadOnly = False
                txt_KOTno.Focus()
            End If
            'SQLSTRING = "SELECT * FROM SM_CARDFILE_HDR WHERE MEMBERSUBCODE='TE' AND [16_DIGIT_CODE]='" & Trim(txt_card_id.Text) & "'"
            'gconnection.getDataSet(SQLSTRING, "ROOMTYPE")
            'If gdataset.Tables("ROOMTYPE").Rows.Count > 0 Then
            '    Dim index As Integer
            '    index = cbo_PaymentMode.FindString("ROOM")
            '    cbo_PaymentMode.SelectedIndex = index
            'End If
        Else
            If cbo_PaymentMode.Text = "SMART CARD" Then
                MessageBox.Show("SORRY! CARD IS NOT VALID", "NOT A VALID CARD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = True
                txt_card_id.Clear()
                LAB_CARDBAL.Text = ""
                LAB_CARDBAL.Visible = False
                'txt_card_id.Focus()
                cbo_PaymentMode.Focus()
                'lbl_SwipeCard.Focus()
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
            MsgBox("Smart Card Please......" & EX.Message)
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
        Pic_Member.Left = 400
        Pic_Member.Top = 5
        Pic_Member.Height = 180
        Pic_Member.Width = 250
        Pic_Member.BringToFront()

        Dim file As New OpenFileDialog
        file.Filter = " Jpg(*.Jpg) | *.jpg"
        If Trim(txt_card_id.Text) <> "" Then
            If file.ShowDialog = DialogResult.OK Then
                Pic_Member.Image = New Bitmap(file.FileName)
                strPhotoFilePath = file.FileName
            End If
        End If
    End Sub
    Private Sub cbo_PaymentMode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_PaymentMode.Validated
        If txt_card_id.Text <> "" Then
            Call cbo_PaymentMode_SelectedIndexChanged(sender, e)
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

    Private Sub txt_card_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_card_id.TextChanged

    End Sub

    Private Sub CHK_PRINT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_PRINT.CheckedChanged

    End Sub
    Private Sub Cmd_ShowBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ShowBill.Click
        Dim OBJBill As New KOT_Billing
        GmoduleName = "Billing"
        Me.Hide()
        OBJBill.FormBorderStyle = FormBorderStyle.FixedDialog
        OBJBill.MdiParent = MDIParentobj
        BOOLCHECKKOT = True
        Me.Close()
        '        StrPOSCODE = Trim(POScode)
        'Added on 31 Oct 07
        'Mk Kannan
        'Begin

        'gSQLString = "SELECT ISNULL(DOCTYPE,'') AS DOCTYPE FROM POSDOCUMENT WHERE POSCODE = '" & Trim(StrPOSCODE) & "'"
        'gconnection.getDataSet(gSQLString, "GETPOSDOCTYPE")
        'If gdataset.Tables("GETPOSDOCTYPE").Rows.Count > 0 Then
        '    strDocType = gdataset.Tables("GETPOSDOCTYPE").Rows(0).Item(0)
        'Else
        '    MsgBox("Sorry, Document Type was Not Found...", MsgBoxStyle.OKOnly, MyCompanyName)
        '    Exit Sub
        'End If
        ''End
        OBJBill.Show()
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Try

            GBL_SMARTCARDSNO = ""
            vCardcode = ""
            LAB_CARDBAL.Text = ""
            LAB_CARDBAL.Visible = False
            Dim index As Integer
            ssGrid.ClearRange(1, 1, -1, -1, True)
            cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
            ssGrid.SetActiveCell(1, 1)
            lab_outstanding.Text = ""
            'Call clearform(Me)
            'Call autogenerate()
            txt_BillAmount.Text = ""
            Pic_Member.Image = Nothing
            txt_TaxValue.Text = ""
            txt_TotalValue.Text = ""
            txt_KOTno.Text = ""
            txt_MemberCode.Text = ""
            txt_ServerCode.Text = ""
            Txt_Remarks.Text = ""
            txt_MemberName.Text = ""
            txt_ServerName.Text = ""
            'txt_LOCATIONCODE.Text = ""
            txt_ServerName.Text = ""
            txt_MemberCode.Text = ""
            txt_MemberName.Text = ""
            txt_Holder_Code.Text = ""
            Txt_holder_name.Text = ""
            MCODE_GBL = ""
            MNAME_GBL = ""
            Call ShowBillno()
            Call GRIDLOCK()
            Call Enabledcontrol()
            Call fillPayment_Mode()

            index = cbo_PaymentMode.FindString(DefaultPayment)
            cbo_PaymentMode.SelectedIndex = index
            txt_KOTno.Text = ""
            pnl_POSCode.Top = 1000
            pnl_UOMCode.Top = 1000
            txt_MemberCode.Tag = ""
            Cmd_Add.Text = "Add [F7]"
            cbo_PaymentMode.Focus()
            KOT_Timer.Enabled = True
            Me.Lbl_Bill.Visible = False
            TotalItemCount = 0
            txt_ServerCode.ReadOnly = False
            txt_KOTno.ReadOnly = False
            txt_MemberName.ReadOnly = False
            txt_ServerName.ReadOnly = False
            Call txt_LOCATIONCODE_Validated(sender, e)
            Me.Cmd_Add.Enabled = True
            Me.cmd_Delete.Enabled = True
            Me.lbl_SubPaymentMode.Visible = False
            Me.cbo_SubPaymentMode.Visible = False
            Me.cmd_KOTnoHelp.Enabled = True
            BillNontaxamount = 0 : BillNontotalamount = 0 : Billtaxamount = 0 : Billtotalamount = 0
            Lbl_Bill.ForeColor = Color.Blue
            Call UserValidation()
            Call SetDateTime()
            MNAME_GBL = ""
            MCODE_GBL = ""
            txt_MemberCode.Text = ""
            txt_MemberName.Text = ""
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            ''txt_KOTno.Focus()
            txt_LOCATIONCODE.Enabled = False
            TXT_LOCATIONNAME.Enabled = False
            txt_card_id.Text = ""
            txt_card_id.Select()
            smartdeviceportcount = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim Totalamount, Taxamount, Calamount, Caltax, CalBilamount, calhighratio, CardAmount, Billroundoff As Double
        Dim cancelamt, canceltax, cancel, SubpaymentMode(), paymentaccountcode, Subpaymentaccountcode, ITEMCODE As String
        Dim x, y, _itemcode, costinguom, Billdetails As String
        Dim kotupd() As String
        Dim sqlstring, varchk, SelectedAutoid As String
        Dim Insert(0), caldoublevalue, VARSQL As String
        Dim i, j, Z As Integer
        Dim Gridbool As Boolean
        'REFERINVENTORY**********************************************************************************************
        Dim POSLOCATION, POSITEMCODE, POSITEMUOM As String
        Dim AVGRATE, AVGQUANTITY, dblCalqty As Double
        Dim K As Integer
        '************************************************************************************************************
        Call checkvalidate() '''---> Check Validation
        If chkbool = False Then Exit Sub
        '''*********************************************************** Case-1 : Add [F7] *******************************************'''
        If Mid(CStr(Cmd_Add.Text), 1, 1) = "A" Then
            dblMsg = 0
            Me.txt_TotalValue.Text = 0
            Me.txt_TaxValue.Text = 0
            For i = 1 To ssGrid.DataRowCnt
                cancel = Nothing
                x = Nothing
                y = Nothing
                ssGrid.GetText(12, i, cancel)
                If Val(cancel) = 0 Then
                    ssGrid.GetText(7, i, x)
                    ssGrid.GetText(8, i, y)
                    Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(y), "0.00")
                    Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(x), "0.00")
                End If
            Next i
            Billroundoff = Val(Me.txt_TaxValue.Text) + Val(Me.txt_TotalValue.Text)
            If BILLROUNDYESNO = "YES" Then
                'Me.txt_BillAmount.Text = Format(Math.Round(Billroundoff), "0.00")
                Me.txt_BillAmount.Text = Format(Billroundoff, "0.00")
            Else
                Me.txt_BillAmount.Text = Format(Billroundoff, "0.00")
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
            sqlstring = "SELECT Accountin FROM Paymentmodemaster WHERE Paymentcode ='" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(Freeze,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "Paymentmodemaster")
            If gdataset.Tables("Paymentmodemaster").Rows.Count > 0 Then
                paymentaccountcode = Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin") & "")
            Else
                MessageBox.Show("Assign a AccountCode For Specified PAYMENTMODE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                paymentaccountcode = ""
                Exit Sub
            End If


            '*********************SMART CARD CARD
            'WITH MIN USAGE
            BILLAMT_GBL = Val(txt_BillAmount.Text)
            If cbo_PaymentMode.Text = "SMART CARD" Then
                If (MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL < Val(txt_BillAmount.Text) Then
                    MsgBox("SUFFICIENT BALANCE NOT AVAILABLE", MsgBoxStyle.Critical)
                    Exit Sub
                Else
                    ' Txt_Remarks.Text = "OpBal : " & Format((MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL, "0.00") & " Trans Amt : " & Format(Val(txt_BillAmount.Text), "0.00") & "   ClsBal : " & Format(((MIN_USAGE_BALANCE_HDR + BALANCE_HDR) - MIN_BALANCE_GBL) - Val(txt_BillAmount.Text), "0.00")
                End If
            End If

            ''*********************SMART CARD CARD AMOUNT
            ''BEGIN SMART CARD  WRITE BALANCE
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




            '''*********************************************************** COMPLETE ************************************************************'''
            'Modified on 15 Mar'08
            'Mk Kannan
            'Begin
            'If CHECK_KOTEXIST(Trim(KOTno(1))) = False Then
            If cbo_PaymentMode.SelectedItem = "ROOM" Then
                sqlstring = "INSERT INTO KOT_HDR(BTYPE,KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,Slcode,Mcode,Mname,RoomNo,Guest,checkin,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,Total,TotalTax,BillAmount,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                sqlstring = sqlstring & "Receiptstatus,Roundoff,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,subpaymentaccountcode,Remarks,Manualbillstatus,delflag,Voucherno,servicelocation,locationcode,[16_digit_code],cardholdercode,cardholdername) "
                ''sqlstring = sqlstring & " VALUES ('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'SALE','SALE','" & accountcode & "','','','','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & " VALUES ('" & CMB_BTYPE.Text & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & " " & Format(CDate(txt_KOTTime.Text), "hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'SALE','SALE','" & accountcode & "','','','','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & "'" & Trim(txt_MemberName.Text) & "','" & Trim(txt_MemberCode.Tag) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                If BILLROUNDYESNO = "YES" Then
                    'sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                    sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                Else
                    sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                End If
                sqlstring = sqlstring & "'N'," & Math.Round(Val(txt_BillAmount.Text)) & ",0,'','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(paymentaccountcode) & " ','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Txt_Remarks.Text) & "','N','N','','" & txt_LOCATIONCODE.Text & "','" & txt_LOCATIONCODE.Text & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
            ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then

                sqlstring = "INSERT INTO KOT_HDR(BTYPE,KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,Slcode,Mcode,Mname,RoomNo,Guest,checkin,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,Total,TotalTax,BillAmount,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                sqlstring = sqlstring & "Receiptstatus,Roundoff,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,subpaymentaccountcode,Remarks,Manualbillstatus,delflag,Voucherno,servicelocation,locationcode,[16_digit_code],cardholdercode,cardholdername)"
                'sqlstring = sqlstring & " VALUES ('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'SALE','SALE','" & accountcode & "','" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "','', "
                sqlstring = sqlstring & " VALUES ('" & CMB_BTYPE.Text & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & " " & Format(CDate(txt_KOTTime.Text), "hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'SALE','SALE','" & accountcode & "','" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "','', "

                sqlstring = sqlstring & "'','','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                If BILLROUNDYESNO = "YES" Then
                    sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                    'sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                Else
                    sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                End If
                sqlstring = sqlstring & "'N'," & Math.Round(Val(txt_BillAmount.Text)) & ",0,'','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(paymentaccountcode) & " ','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Txt_Remarks.Text) & "','N','N','','" & txt_LOCATIONCODE.Text & "','" & txt_LOCATIONCODE.Text & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
            ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                sqlstring = "INSERT INTO KOT_HDR(BTYPE,KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,Slcode,Mcode,Mname,RoomNo,Guest,checkin,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,Total,TotalTax,BillAmount,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                sqlstring = sqlstring & "Receiptstatus,Roundoff,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,subpaymentaccountcode,Remarks,Manualbillstatus,delflag,Voucherno,servicelocation,locationcode,[16_digit_code],cardholdercode,cardholdername)"
                'sqlstring = sqlstring & " VALUES ('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'SALE','SALE','" & accountcode & "','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & " VALUES ('" & CMB_BTYPE.Text & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & " " & Format(CDate(txt_KOTTime.Text), "hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'SALE','SALE','" & accountcode & "','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "','','','','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                'sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                If BILLROUNDYESNO = "YES" Then
                    'sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                    sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                Else
                    sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                End If
                sqlstring = sqlstring & "'N'," & Math.Round(Val(txt_BillAmount.Text)) & ",0,'','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','SDRS ','" & Trim(txt_MemberCode.Text) & "','" & Trim(Txt_Remarks.Text) & "','N','N','','" & txt_LOCATIONCODE.Text & "','" & txt_LOCATIONCODE.Text & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
            Else
                sqlstring = "INSERT INTO KOT_HDR(BTYPE,KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,SLCode,MCode,Mname,RoomNo,Guest,checkin,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,Total,TotalTax,BillAmount,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                sqlstring = sqlstring & "Receiptstatus,Roundoff,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,subpaymentaccountcode,Remarks,Manualbillstatus,delflag,Voucherno,servicelocation,locationcode,[16_digit_code],cardholdercode,cardholdername)"
                ''sqlstring = sqlstring & " VALUES ('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'SALE','SALE','" & accountcode & "','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & " VALUES ('" & CMB_BTYPE.Text & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & " " & Format(CDate(txt_KOTTime.Text), "hh:mm:ss") & "','" & Trim(txt_TableNo.Text) & "'," & Val(txt_Cover.Text) & ",'SALE','SALE','" & accountcode & "','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "','','','','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                If BILLROUNDYESNO = "YES" Then
                    'sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Math.Round(Val(txt_BillAmount.Text)) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                    sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                Else
                    sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                End If
                'sqlstring = sqlstring & "'SALE','AUTO'," & Val(txt_TotalValue.Text) & "," & Val(txt_TaxValue.Text) & "," & Val(txt_BillAmount.Text) & ",'PO','" & Trim(gUsername) & "','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(SubpaymentMode(0)) & "',"
                sqlstring = sqlstring & "'N'," & Math.Round(Val(txt_BillAmount.Text)) & ",0,'','" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "','N','" & Trim(paymentaccountcode) & " ','" & Trim(Subpaymentaccountcode) & " ','" & Trim(Txt_Remarks.Text) & "','N','N','','" & txt_LOCATIONCODE.Text & "','" & txt_LOCATIONCODE.Text & "','" & txt_card_id.Text & "','" & txt_Holder_Code.Text & "','" & Txt_holder_name.Text & "')"
            End If
            Insert(0) = sqlstring

            '''******************************************************** Insert into KOT_DET **********************************'''
            For i = 1 To ssGrid.DataRowCnt
                sqlstring = "INSERT INTO KOT_DET(KotNo,KOTdetails,KotDate,KotType,PaymentMode,Mcode,Scode,Covers,TableNo,TotAmt,TaxAmt,BillAmt,ChkId,ItemCode,Itemdesc,Poscode,Uom,Qty,Rate,Taxamount,Amount,ItemType,TaxCode,TaxPerc,TaxAccountCode,SalesAccountCode,GroupCode,"
                sqlstring = sqlstring & "Taxtype,Alcholst,Adduserid,Adddatetime,Upduserid,Upddatetime,KOTStatus,delflag) "

                ''sqlstring = sqlstring & "VALUES('" & Trim(CStr(KOTno(1))) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "','SALE','" & Trim(cbo_PaymentMode.Text) & "',"
                sqlstring = sqlstring & "VALUES('" & Trim(CStr(txt_KOTno.Text)) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & " " & Format(CDate(txt_KOTTime.Text), "hh:mm:ss") & "','SALE','" & Trim(cbo_PaymentMode.Text) & "',"

                If BILLROUNDYESNO = "YES" Then
                    'sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & "," & Val(Me.txt_MemberCode.Tag) & ""
                    sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Val(Me.txt_BillAmount.Text) & "," & Val(Me.txt_MemberCode.Tag) & ""
                Else
                    sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Val(Me.txt_BillAmount.Text) & "," & Val(Me.txt_MemberCode.Tag) & ""
                End If
                ssGrid.Row = i
                ssGrid.Col = 1
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                ssGrid.Col = 2
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                ssGrid.Col = 3
                sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
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
                'ssGrid.Row = i
                'ssGrid.Col = 1
                '_itemcode = Trim(ssGrid.Text)
                'sqlstring = "SELECT ISNULL(STORECODE,'') AS STORECODE,STOREDESC FROM STOREMASTER WHERE STORECODE =(SELECT STORECODE FROM ITEMMASTER "
                'sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(_itemcode) & "' AND ISNULL(STORECODE,'')<>''"
                'sqlstring = sqlstring & " AND ISNULL(FREEZE,'') <> 'Y')"
                'gconnection.getDataSet(sqlstring, "ITEMMASTER")
                'POSLOCATION = gdataset.Tables("ITEMMASTER").Rows(0).Item("STORECODE")
                ''REFERINVENTORY*************************UPDATING STOCK***********************************************
                'Trim(POSLOCATION)
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
                            sqlstring = sqlstring & " VALUES ('" & Trim(CStr(txt_KOTno.Text)) & "','" & Trim(CStr(txt_KOTno.Text)) & "',"
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
                        sqlstring = sqlstring & " WHERE I.ITEMCODE='" & POSITEMCODE & "' AND I.STOCKUOM='" & POSITEMUOM & "' AND ISNULL(FREEZE,'') <> 'Y' and i.storecode='" & POSLOCATION & "'"
                        gconnection.getDataSet(sqlstring, "DIRECT_STOCK")
                        If gdataset.Tables("DIRECT_STOCK").Rows.Count > 0 Then
                            sqlstring = "INSERT INTO SUBSTORECONSUMPTIONDETAIL(Docno,Docdetails,Docdate,Storelocationcode,STORELOCATIONNAME,"
                            sqlstring = sqlstring & " Itemcode,Itemname,Uom,Qty,Rate,Amount,"
                            sqlstring = sqlstring & " Dblamt,Highratio,Groupcode,Subgroupcode,Void,Adduser,adddatetime,Updateuser,Updatetime)"
                            sqlstring = sqlstring & " VALUES ('" & Trim(CStr(txt_KOTno.Text)) & "','" & Trim(CStr(txt_KOTno.Text)) & "',"
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
            Next i
            sqlstring = "UPDATE KOT_DET SET COSTCODE=ISNULL(B.COSTCODE,'') FROM  KOT_DET A,POSMASTER B WHERE  A.POSCODE=B.POSCODE AND A.KOTDETAILS='" & Trim(txt_KOTno.Text) & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring


            'If Trim(cbo_PaymentMode.Text) <> "ROOM" Then
            If UCase(Trim(CMB_BTYPE.Text)) = "NIA" Or UCase(Trim(CMB_BTYPE.Text)) = "CKA" Or UCase(Trim(CMB_BTYPE.Text)) = "ACH" Then
                sqlstring = "update kot_det  set PACKPERCENT=5,Packamount=(isnull(amount,0) *5/100) Where  kotdetails='" & txt_KOTno.Text & "' and isnull(poscode,'') not in('12','13')"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
            End If
            'End If

            sqlstring = "update kot_det  set  packamt=b.packamount from kot_det a, view_kot  b "
            sqlstring = sqlstring & "where a.kotdetails=b.kotdetails and a.kotdetails='" & txt_KOTno.Text & "' "
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring


            'sqlstring = "update kot_det  set ser_chg=(isnull(amount,0) *5.15/100) Where  kotdetails='" & txt_KOTno.Text & "' and isnull(poscode,'') IN('ACHF','NCHF')"
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

            'KOTno = Nothing
            'KOTno = Split(Trim(txt_KOTno.Text), "/")
            'sqlstring = "Update PoSKotDoc Set DocNo = " & KOTno(1) & ",DOCFLAG='N' Where DocType = 'KOT'"
            'ReDim Preserve Insert(Insert.Length)
            'Insert(Insert.Length - 1) = sqlstring
            'sqlstring = "select * from kot_det where kotdetails='" & txt_KOTno.Text & "'"
            'gconnection.getDataSet(sqlstring, "kotno")
            'If gdataset.Tables("kotno").Rows.Count > 0 Then
            '    sqlstring = "SELECT MAX(KOTNO)  AS KNO FROM KOT_DET WHERE SUBSTRING(KOTDETAILS,1,3)='KOT' "
            '    gconnection.getDataSet(sqlstring, "KNO")
            '    If gdataset.Tables("KNO").Rows.Count > 0 Then
            '        sqlstring = "Update PoSKotDoc Set DocNo = " & gdataset.Tables("KNO").Rows(0).Item("KNO") & " WHERE DOCFLAG='N' And DocType = 'KOT'"
            '        'kotupd = kotupd & " WHERE DOCFLAG='N' And DocType = 'KOT'"
            '        gconnection.dataOperation(9, sqlstring, "upd")
            '        Call Cmd_Add_Click(sender, e)
            '    End If
            'Else

            If KOTLEVELDEDUCT <> "Y" Then
                gconnection.MoreTransold(Insert)
            Else
                'CSC SMARTCARD
                '****************SHOW SMART CARD CARD TRANSACTION*****************
                Dim STRSQL2, SSTR As String
                STRSQL2 = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & cardcode & "' AND POSCODE='" & StrPOSCODE & "'"
                gconnection.getDataSet(STRSQL2, "SM_CARDFILE_DET")
                If gdataset.Tables("SM_CARDFILE_DET").Rows.Count > 0 Then
                    POS_AMT_GBL = Val(txt_TotalValue.Text)
                    STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'FF' "
                    gconnection.getDataSet(STRSQL2, "FACILITY")
                    If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                        'ONCE FACILITY 
                        KOT_NO_GBL = Trim(txt_KOTno.Text)
                        gconnection.MoreTransold(Insert)
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
                            If MIN_USAGE_BALANCE_HDR >= Val(txt_BillAmount.Text) Then

                                STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ('" & txt_card_id.Text & "', '" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & Val(txt_BillAmount.Text) & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FM')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL

                                STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & Val(txt_BillAmount.Text) & " WHERE CARDCODE='" & cardcode & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL


                            ElseIf MIN_USAGE_BALANCE_HDR <= 0 Then
                                'DEDUCT AMOUNT ONLY FROM CARD

                                Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                                DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR
                                DEDUCT_FROM_CARD = Val(txt_BillAmount.Text) - MIN_USAGE_BALANCE_HDR

                                'FOR BALANCE
                                STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & cardcode & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL

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
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL
                                'END

                                STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FC')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL

                            ElseIf MIN_USAGE_BALANCE_HDR > 0 And MIN_USAGE_BALANCE_HDR < Val(txt_BillAmount.Text) Then

                                Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                                DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR
                                DEDUCT_FROM_CARD = Val(txt_BillAmount.Text) - MIN_USAGE_BALANCE_HDR

                                STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_MINUSAGE & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HM')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL


                                STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HC')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL


                                STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & DEDUCT_FROM_MINUSAGE & " WHERE CARDCODE='" & cardcode & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL

                                STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & cardcode & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL

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
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL
                                'END

                            End If
                            'Else
                            '   STRSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & cardcode & "','" & StrPOSCODE & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & Val(txt_BillAmount.Text) & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','O')"
                            '  ReDim Preserve Insert(Insert.Length)
                            ' Insert(Insert.Length - 1) = STRSQL
                        End If
                        gconnection.MoreTransold(Insert)

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
                    End If
                End If
            End If



            If dblMsg <> 1 Then
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call Cmd_Print_Click(cmd_View, e)
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
            Else
                Cmd_Add.Focus()
            End If
            'End If
            'Else
            'MsgBox("!!!!.........................!!!!!!!!")
            'End If
            '''*********************************************************** Case-2 : Update [F7] *******************************************'''
        ElseIf Mid(CStr(Cmd_Add.Text), 1, 1) = "U" Then

            If Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
                MessageBox.Show("PLEASE! SWIPE YOUR CARD", "CARD NOT SWIPED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                lbl_SwipeCard.Visible = True
                txt_card_id.Focus()
                '                lbl_SwipeCard.Focus()
                Exit Sub
            Else
                If cbo_PaymentMode.Text = "SMART CARD" Then
                    Call cardcheck()
                End If
            End If

            KOTno = Split(Trim(txt_KOTno.Text), "/")
            Me.txt_TotalValue.Text = 0
            Me.txt_TaxValue.Text = 0
            For i = 1 To ssGrid.DataRowCnt
                cancel = Nothing
                x = Nothing
                y = Nothing
                ssGrid.GetText(12, i, cancel)
                If Val(cancel) = 0 Then
                    ssGrid.GetText(7, i, x)
                    ssGrid.GetText(8, i, y)
                    Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(y), "0.00")
                    Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(x), "0.00")
                End If
            Next i
            Billroundoff = Val(Me.txt_TaxValue.Text) + Val(Me.txt_TotalValue.Text)
            If BILLROUNDYESNO = "YES" Then
                'Me.txt_BillAmount.Text = Format(Math.Round(Billroundoff), "0.00")
                Me.txt_BillAmount.Text = Format(Billroundoff, "0.00")
            Else
                Me.txt_BillAmount.Text = Format(Billroundoff, "0.00")
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
            sqlstring = "SELECT Accountin FROM Paymentmodemaster WHERE Paymentcode ='" & Trim(cbo_PaymentMode.Text) & "' AND ISNULL(Freeze,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "Paymentmodemaster")
            If gdataset.Tables("Paymentmodemaster").Rows.Count > 0 Then
                paymentaccountcode = Trim(gdataset.Tables("Paymentmodemaster").Rows(0).Item("Accountin") & "")
            Else
                MessageBox.Show("Assign a AccountCode For Specified PAYMENTMODE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                paymentaccountcode = ""
                Exit Sub
            End If
            '''*********************************************************** COMPLETE ************************************************************'''
            '''********************************************************** UPDATE KOT_HDR *********************************************************'''

            'Modified on 15 Mar'08
            'Mk Kannan
            'Begin
            If cbo_PaymentMode.SelectedItem = "ROOM" Then
                sqlstring = "SELECT ISNULL(CHECKOUT,'N') AS CHECKOUT,ISNULL(ROOMNO,0)AS ROOMNO FROM Roomcheckin WHERE roomstatus = 'occupied' and docno = " & Val(txt_MemberCode.Tag) & ""
                gconnection.getDataSet(sqlstring, "Roomcheckin")
                If gdataset.Tables("Roomcheckin").Rows.Count > 0 Then
                    If Trim(CStr(gdataset.Tables("Roomcheckin").Rows(0).Item("CHECKOUT"))) = "Y" Then
                        MessageBox.Show("Bill Can't be updated " & vbCrLf & " as GUEST  had been checkout from RoomNo" & ": " & gdataset.Tables("ROOMLEDGER").Rows(0).Item("ROOMNO"), MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Call cmd_Clear_Click(cmd_Clear, e)
                        Cmd_Add.Enabled = True
                        Exit Sub
                    End If
                End If
                sqlstring = "UPDATE KOT_HDR SET BTYPE='" & CMB_BTYPE.Text & "',KOTDATE ='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "',TableNo='" & Trim(txt_TableNo.Text) & "',Covers=" & Val(txt_Cover.Text) & ",DocType='SALE',SaleType='SALE',AccountCode='" & accountcode & "',"
                sqlstring = sqlstring & " Slcode = '',Mcode= '',Mname= '',RoomNo='" & Trim(txt_MemberCode.Text) & "',Guest='" & Trim(txt_MemberName.Text) & "',checkin='" & Trim(txt_MemberCode.Tag) & "',STCode='" & Trim(txt_ServerCode.Text) & "',ServerCode='" & Trim(txt_ServerCode.Text) & "',ServerName='" & Trim(txt_ServerName.Text) & "',"
                If BILLROUNDYESNO = "YES" Then
                    'sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                Else
                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                End If
                sqlstring = sqlstring & " SubPaymentMode='" & SubpaymentMode(0) & "',Roundoff=" & Math.Round(Val(txt_BillAmount.Text)) & ",upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Paymodeaccountcode = '" & Trim(paymentaccountcode) & " ',subpaymentaccountcode = '" & Trim(Subpaymentaccountcode) & " ' "
                sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
            ElseIf cbo_PaymentMode.SelectedItem = "R.MEMBER" Then
                sqlstring = "UPDATE KOT_HDR SET BTYPE='" & CMB_BTYPE.Text & "', Kotdate='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "',TableNo='" & Trim(txt_TableNo.Text) & "',Covers=" & Val(txt_Cover.Text) & ",DocType='SALE',SaleType='SALE',AccountCode='" & accountcode & "',"
                sqlstring = sqlstring & " Slcode = '" & Trim(txt_MemberCode.Text) & "',Mcode= '" & Trim(txt_MemberCode.Text) & "',Mname= '" & Trim(txt_MemberName.Text) & "',RoomNo='',Guest='',checkin='',STCode='" & Trim(txt_ServerCode.Text) & "',ServerCode='" & Trim(txt_ServerCode.Text) & "',ServerName='" & Trim(txt_ServerName.Text) & "',"
                If BILLROUNDYESNO = "YES" Then
                    'sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                Else
                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                End If
                sqlstring = sqlstring & " SubPaymentMode='" & SubpaymentMode(0) & "',Roundoff=" & Math.Round(Val(txt_BillAmount.Text)) & ",upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Paymodeaccountcode = '" & Trim(paymentaccountcode) & " ',subpaymentaccountcode = '" & Trim(Subpaymentaccountcode) & " ' "
                sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
                'ElseIf cbo_PaymentMode.SelectedItem = "COUPON" Then
                '    sqlstring = "UPDATE KOT_HDR SET Kotdate='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "',TableNo='" & Trim(txt_TableNo.Text) & "',Covers=" & Val(txt_Cover.Text) & ",DocType='SALE',SaleType='SALE',AccountCode='" & accountcode & "',"
                '    sqlstring = sqlstring & " Slcode = '',Mcode= '',Mname= '',RoomNo='',Guest='',checkin='',STCode='" & Trim(txt_ServerCode.Text) & "',ServerCode='" & Trim(txt_ServerCode.Text) & "',ServerName='" & Trim(txt_ServerName.Text) & "',"
                '    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                '    sqlstring = sqlstring & " SubPaymentMode='" & SubpaymentMode(0) & "',Roundoff=" & Math.Round(Val(txt_BillAmount.Text)) & ",upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Paymodeaccountcode = '" & Trim(paymentaccountcode) & " ',subpaymentaccountcode = '" & Trim(Subpaymentaccountcode) & " ' "
                '    sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
            ElseIf cbo_PaymentMode.SelectedItem = "CREDIT" Then
                sqlstring = "UPDATE KOT_HDR SET BTYPE='" & CMB_BTYPE.Text & "',Kotdate='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "',TableNo='" & Trim(txt_TableNo.Text) & "',Covers=" & Val(txt_Cover.Text) & ",DocType='SALE',SaleType='SALE',AccountCode='" & accountcode & "',"
                sqlstring = sqlstring & " Slcode = '" & Trim(txt_MemberCode.Text) & "',Mcode= '" & Trim(txt_MemberCode.Text) & "',Mname= '" & Trim(txt_MemberName.Text) & "',RoomNo='',Guest='',checkin='',STCode='" & Trim(txt_ServerCode.Text) & "',ServerCode='" & Trim(txt_ServerCode.Text) & "',ServerName='" & Trim(txt_ServerName.Text) & "',"
                'sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                If BILLROUNDYESNO = "YES" Then
                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                    'sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                Else
                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                End If
                sqlstring = sqlstring & " SubPaymentMode='" & SubpaymentMode(0) & "',Roundoff=" & Math.Round(Val(txt_BillAmount.Text)) & ",upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Paymodeaccountcode = 'SDRS ',subpaymentaccountcode = '" & Trim(txt_MemberCode.Text) & "' "
                sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
            Else
                sqlstring = "UPDATE KOT_HDR SET BTYPE='" & CMB_BTYPE.Text & "',Kotdate='" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "',TableNo='" & Trim(txt_TableNo.Text) & "',Covers=" & Val(txt_Cover.Text) & ",DocType='SALE',SaleType='SALE',AccountCode='" & accountcode & "',"
                sqlstring = sqlstring & " SLCode='" & Trim(txt_MemberCode.Text) & "',MCode='" & Trim(txt_MemberCode.Text) & "',Mname='" & Trim(txt_MemberName.Text) & "',STCode='" & Trim(txt_ServerCode.Text) & "',ServerCode='" & Trim(txt_ServerCode.Text) & "',ServerName='" & Trim(txt_ServerName.Text) & "',"
                If BILLROUNDYESNO = "YES" Then
                    'sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Math.Round(Val(txt_BillAmount.Text)) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                Else
                    sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                End If
                'sqlstring = sqlstring & " PaymentType='" & Trim(cbo_PaymentMode.Text) & "',ServiceType ='SALE',Postingtype ='AUTO',Total =" & Val(txt_TotalValue.Text) & ",TotalTax =" & Val(txt_TaxValue.Text) & ",BillAmount =" & Val(txt_BillAmount.Text) & ",Remarks = '" & Trim(Txt_Remarks.Text) & "',"
                sqlstring = sqlstring & " SubPaymentMode='" & SubpaymentMode(0) & "',Roundoff=" & Math.Round(Val(txt_BillAmount.Text)) & ",upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(serverdate, "dd-MMM-yyyy hh:mm:ss") & "',Paymodeaccountcode = '" & Trim(paymentaccountcode) & " ',subpaymentaccountcode = '" & Trim(Subpaymentaccountcode) & " ' "
                sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(txt_KOTno.Text)) & "' "
            End If
            Insert(0) = sqlstring
            If Me.Lbl_Bill.Visible = True And Me.Lbl_Bill.Text = "B I L L  G E N E R A T E D" Then
                '''******************************************* $ CHECK IF THAT MEMBER HAV THE FACILITY OF USING CARD OR NOT      $ *********************'''
                'If Trim(cbo_PaymentMode.Text) = "CARD" Then
                '    sqlstring = "SELECT * FROM SMARTCARDDETAILS WHERE MCODE ='" & Trim(CStr(txt_MemberCode.Text)) & "' "
                '    gconnection.getDataSet(sqlstring, "SMARTCARDDETAILS")
                '    If gdataset.Tables("SMARTCARDDETAILS").Rows.Count > 0 Then
                '        smartcardbool = True
                '    Else
                '        MessageBox.Show("Sorry this member don't hav card facility", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                '        txt_MemberCode.Focus()
                '        smartcardbool = False
                '        Exit Sub
                '    End If
                'End If
                '''******************************************* $ CHECK COMPLETED  $ ********************************************************************'''
                VARSQL = " SELECT Autoid AS Autoid,Kotdetails AS Kotdetails,Kotdate AS Kotdate,ISNULL(Billdetails,'') AS Billdetails,Taxcode,Itemcode FROM KOT_DET WHERE KOTDETAILS  = '" & Trim(txt_KOTno.Text) & "'"
                gconnection.getDataSet(VARSQL, "TEMPKOTDET")
                If gdataset.Tables("TEMPKOTDET").Rows.Count > 0 Then
                    For Z = 0 To gdataset.Tables("TEMPKOTDET").Rows.Count - 1
                        For i = 1 To ssGrid.DataRowCnt
                            ssGrid.Row = i
                            ssGrid.Col = 16
                            If Val(ssGrid.Text) = Val(gdataset.Tables("TEMPKOTDET").Rows(Z).Item("Autoid")) Then
                                '''******************************************************** UPDATE INTO KOT_DET ******************************************************'''
                                sqlstring = "UPDATE KOT_DET SET KotDate = '" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "',KotType = 'SALE',PaymentMode= '" & Trim(cbo_PaymentMode.Text) & "' ,"
                                sqlstring = sqlstring & " Mcode = '" & Trim(txt_MemberCode.Text) & "',Scode = '" & Trim(txt_ServerCode.Text) & "',Covers = " & Val(Me.txt_Cover.Text) & ",TableNo = " & Val(Me.txt_TableNo.Text) & ","
                                If BILLROUNDYESNO = "YES" Then
                                    'sqlstring = sqlstring & " TotAmt= " & Val(Me.txt_TotalValue.Text) & ",TaxAmt= " & Val(Me.txt_TaxValue.Text) & ",BillAmt= " & Math.Round(Val(Me.txt_BillAmount.Text)) & ",ChkId= " & Val(Me.txt_MemberCode.Tag) & " "
                                    sqlstring = sqlstring & " TotAmt= " & Val(Me.txt_TotalValue.Text) & ",TaxAmt= " & Val(Me.txt_TaxValue.Text) & ",BillAmt= " & Val(Me.txt_BillAmount.Text) & ",ChkId= " & Val(Me.txt_MemberCode.Tag) & " "
                                Else
                                    sqlstring = sqlstring & " TotAmt= " & Val(Me.txt_TotalValue.Text) & ",TaxAmt= " & Val(Me.txt_TaxValue.Text) & ",BillAmt= " & Val(Me.txt_BillAmount.Text) & ",ChkId= " & Val(Me.txt_MemberCode.Tag) & " "
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
                                Gridbool = True
                                Exit For
                            Else
                                Gridbool = False
                            End If
                        Next i
                        If Gridbool = False Then
                            sqlstring = "DELETE FROM KOT_DET WHERE autoid= " & Val(gdataset.Tables("TEMPKOTDET").Rows(Z).Item("Autoid")) & " "
                            ReDim Preserve Insert(Insert.Length)
                            Insert(Insert.Length - 1) = sqlstring
                        End If
                        '''******************************************************** COMPLETE KOT_DET *********************************************************'''
                    Next Z
                End If
                Dim dt As DataTable
                Call BillingUpdation() '''--->Billing Updation
                '''****************************************** $ FOR NON TAXABLE ITEMS $ *************************************
                dt = gconnection.GetValues("SELECT Billdetails,Kotamount FROM Bill_Det WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "' AND Isnull(Taxamount,0)=0")
                If dt.Rows.Count > 0 Then
                    sqlstring = "UPDATE Bill_Det SET KotAmount=" & Val(BillNontotalamount) & " ,TaxAmount= " & Val(BillNontaxamount) & " Where KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "' AND Isnull(Taxamount,0)=0"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                    sqlstring = "UPDATE Bill_Hdr SET BillAmount= Billamount - " & Val(dt.Rows(0).Item("kotamount")) & " Where BillDetails='" & Trim(dt.Rows(0).Item("BillDetails")) & "' AND Isnull(Taxamount,0)=0"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                    sqlstring = "UPDATE Bill_Hdr SET BillAmount= Billamount + " & Val(BillNontotalamount) & " ,TaxAmount= TaxAmount +  " & Val(BillNontaxamount) & " WHERE BillDetails='" & Trim(dt.Rows(0).Item("BillDetails")) & "' AND Isnull(Taxamount,0)=0"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                    '''************************************************** $ IF PAYMENTMODE IS "CARD"  $ ********************************************'''
                    If CStr(cbo_PaymentMode.Text) = "CARD" Then
                        If smartcardbool = True Then
                            sqlstring = "SELECT Minimumusage,CardAmount FROM Bill_Hdr WHERE BILLDETAILS ='" & Trim(dt.Rows(0).Item("BillDetails")) & "' "
                            gconnection.getDataSet(sqlstring, "CardBill_Hdr")
                            If gdataset.Tables("CardBill_Hdr").Rows.Count > 0 Then
                                If Val(gdataset.Tables("CardBill_Hdr").Rows(0).Item("Minimumusage")) > 0 Then
                                    sqlstring = "UPDATE MEMBERMASTER SET CardAmt = CardAmt - " & Format(Val(CardAmount), "0.00") & " WHERE MCODE = '" & Trim(CStr(txt_MemberCode.Text)) & "'"
                                    ReDim Preserve Insert(Insert.Length)
                                    Insert(Insert.Length - 1) = sqlstring
                                ElseIf Val(gdataset.Tables("CardBill_Hdr").Rows(0).Item("Minimumusage")) = 0 Then

                                ElseIf Val(gdataset.Tables("CardBill_Hdr").Rows(0).Item("CardAmount")) > 0 Then

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
                    '''************************************************** $ IF TAX ITEM IS INSERTED  $ ********************************************'''
                End If
                '''****************************************************** $ FOR TAXABLE ITEMS $  **********************************************
                dt = gconnection.GetValues("SELECT Billdetails,Kotamount,TaxAmount FROM Bill_Det WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "' AND Isnull(Taxamount,0)> 0")
                If dt.Rows.Count > 0 Then
                    sqlstring = "UPDATE Bill_Det SET KotAmount=" & Val(Billtotalamount) & ",TaxAmount= " & Val(Billtaxamount) & " WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "' AND Isnull(Taxamount,0) > 0"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                    sqlstring = "UPDATE Bill_Hdr SET BillAmount= BillAmount - " & Val(dt.Rows(0).Item("kotamount")) & ", TaxAmount = TaxAmount - " & Val(dt.Rows(0).Item("TaxAmount")) & " WHERE BillDetails='" & Trim(dt.Rows(0).Item("BillDEtails")) & "'"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                    sqlstring = "UPDATE Bill_Hdr SET BillAmount= BillAmount + " & Val(Billtotalamount) & ",TaxAmount= TaxAmount + " & Val(Billtaxamount) & " WHERE BillDetails='" & Trim(dt.Rows(0).Item("BillDetails")) & "'"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                    '''************************************************** $ IF PAYMENTMODE IS "CARD"  $ ********************************************'''
                    If CStr(cbo_PaymentMode.Text) = "CARD" Then
                        If smartcardbool = True Then
                            sqlstring = "SELECT Minimumusage,CardAmount FROM Bill_Hdr WHERE BILLDETAILS ='" & Trim(dt.Rows(0).Item("BillDetails")) & "' "
                            gconnection.getDataSet(sqlstring, "Bill_Hdr")
                            If gdataset.Tables("Bill_Hdr").Rows.Count > 0 Then

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
            ElseIf Me.Lbl_Bill.Visible = True And Me.Lbl_Bill.Text = "C R O  G E N E R A T E D" Then
                MessageBox.Show("As CRO is generated so KOT Can't be modified", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Call cmd_Clear_Click(cmd_Clear, e)
                Exit Sub
            Else
                'REFERINVENTORY
                'VARSQL = " SELECT Autoid AS Autoid,Kotdetails AS Kotdetails,Kotdate AS Kotdate,ISNULL(Billdetails,'') AS Billdetails,Taxcode,Itemcode FROM KOT_DET WHERE KOTDETAILS  = '" & Trim(txt_KOTno.Text) & "'"
                VARSQL = " SELECT Autoid AS Autoid,Kotdetails AS Kotdetails,Kotdate AS Kotdate,ISNULL(Billdetails,'') AS Billdetails,Taxcode,Itemcode,isnull(qty,0) qty FROM KOT_DET WHERE KOTDETAILS  = '" & Trim(txt_KOTno.Text) & "'"
                gconnection.getDataSet(VARSQL, "TEMPKOTDET")
                If gdataset.Tables("TEMPKOTDET").Rows.Count > 0 Then
                    For Z = 0 To gdataset.Tables("TEMPKOTDET").Rows.Count - 1
                        For i = 1 To ssGrid.DataRowCnt
                            ssGrid.Row = i
                            ssGrid.Col = 16
                            If Val(ssGrid.Text) = Val(gdataset.Tables("TEMPKOTDET").Rows(Z).Item("Autoid")) Then
                                '''******************************************************** UPDATE INTO KOT_DET ******************************************************'''
                                sqlstring = "UPDATE KOT_DET SET KotDate = '" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "',KotType = 'SALE',PaymentMode= '" & Trim(cbo_PaymentMode.Text) & "' ,"
                                sqlstring = sqlstring & " Mcode = '" & Trim(txt_MemberCode.Text) & "',Scode = '" & Trim(txt_ServerCode.Text) & "',Covers = " & Val(Me.txt_Cover.Text) & ",TableNo = " & Val(Me.txt_TableNo.Text) & ","
                                If BILLROUNDYESNO = "YES" Then
                                    'sqlstring = sqlstring & " TotAmt= " & Val(Me.txt_TotalValue.Text) & ",TaxAmt= " & Val(Me.txt_TaxValue.Text) & ",BillAmt= " & Math.Round(Val(Me.txt_BillAmount.Text)) & ",ChkId= " & Val(Me.txt_MemberCode.Tag) & " "
                                    sqlstring = sqlstring & " TotAmt= " & Val(Me.txt_TotalValue.Text) & ",TaxAmt= " & Val(Me.txt_TaxValue.Text) & ",BillAmt= " & Val(Me.txt_BillAmount.Text) & ",ChkId= " & Val(Me.txt_MemberCode.Tag) & " "
                                Else
                                    sqlstring = sqlstring & " TotAmt= " & Val(Me.txt_TotalValue.Text) & ",TaxAmt= " & Val(Me.txt_TaxValue.Text) & ",BillAmt= " & Val(Me.txt_BillAmount.Text) & ",ChkId= " & Val(Me.txt_MemberCode.Tag) & " "
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
                                            'REFERCSC
                                            'ssGrid.Col = 22
                                            ssGrid.Col = 18
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
                                            'REFERCSC
                                            ssGrid.Col = 18
                                            sqlstring = sqlstring & " AND QTY=" & Val(ssGrid.Text)

                                            ReDim Preserve Insert(Insert.Length)
                                            Insert(Insert.Length - 1) = sqlstring
                                        End If
                                    End If
                                End If
                                '*********************************************************************************************

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
                        End If
                        '''******************************************************** COMPLETE KOT_DET *********************************************************'''
                    Next Z
                End If
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Row = i
                    ssGrid.Col = 16
                    If Val(ssGrid.Text) = 0 Then
                        sqlstring = "INSERT INTO KOT_DET(KotNo,KOTdetails,KotDate,KotType,PaymentMode,Mcode,Scode,Covers,TableNo,TotAmt,TaxAmt,BillAmt,ChkId,ItemCode,Itemdesc,Poscode,Uom,Qty,Rate,Taxamount,Amount,ItemType,TaxCode,TaxPerc,TaxAccountCode,SalesAccountCode,GroupCode,"
                        sqlstring = sqlstring & "Taxtype,Alcholst,Adduserid,Adddatetime,Upduserid,Upddatetime,KOTStatus,delflag) "
                        sqlstring = sqlstring & "VALUES('" & Trim(CStr(txt_KOTno.Text)) & "','" & Trim(CStr(txt_KOTno.Text)) & "','" & Format(CDate(dtp_KOTdate.Value), "dd-MMM-yyyy hh:mm:ss") & "','SALE','" & Trim(cbo_PaymentMode.Text) & "',"
                        If BILLROUNDYESNO = "YES" Then
                            'sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & "," & Val(Me.txt_MemberCode.Tag) & ""
                            sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Val(Me.txt_BillAmount.Text) & "," & Val(Me.txt_MemberCode.Tag) & ""
                        Else
                            sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Val(Me.txt_BillAmount.Text) & "," & Val(Me.txt_MemberCode.Tag) & ""
                        End If
                        'sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_ServerCode.Text) & "'," & Val(Me.txt_Cover.Text) & "," & Val(Me.txt_TableNo.Text) & "," & Val(Me.txt_TotalValue.Text) & "," & Val(Me.txt_TaxValue.Text) & "," & Math.Round(Val(Me.txt_BillAmount.Text)) & "," & Val(Me.txt_MemberCode.Tag) & ""
                        ssGrid.Row = i
                        ssGrid.Col = 1
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                        ssGrid.Col = 2
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                        ssGrid.Col = 3
                        sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
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
                                    sqlstring = sqlstring & " VALUES ('" & Trim(CStr(txt_KOTno.Text)) & "','" & Trim(CStr(txt_KOTno.Text)) & "',"
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
                                    'sqlstring = sqlstring & " VALUES ('" & CStr(KOTno(1)) & "','" & Trim(CStr(txt_KOTno.Text)) & "',"
                                    sqlstring = sqlstring & " VALUES ('" & CStr(txt_KOTno.Text) & "','" & Trim(CStr(txt_KOTno.Text)) & "',"
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
            End If
            sqlstring = "UPDATE KOT_DET SET COSTCODE=ISNULL(B.COSTCODE,'') FROM  KOT_DET A,POSMASTER B WHERE  A.POSCODE=B.POSCODE AND A.KOTDETAILS='" & Trim(txt_KOTno.Text) & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            'If Trim(cbo_PaymentMode.Text) <> "ROOM" Then
            If UCase(Trim(CMB_BTYPE.Text)) = "NIA" Or UCase(Trim(CMB_BTYPE.Text)) = "CKA" Or UCase(Trim(CMB_BTYPE.Text)) = "ACH" Then
                sqlstring = "update kot_det  set PACKPERCENT=5,Packamount=(isnull(amount,0) *5/100) Where  kotdetails='" & txt_KOTno.Text & "' and isnull(poscode,'') not in('12','13')"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
            End If
            'End If

            'sqlstring = "update kot_det  set PACKPERCENT=5.15 ,Packamount=((isnull(amount,0)*75/100) *(5.15/100)) Where  kotdetails='" & txt_KOTno.Text & "' and isnull(poscode,'') IN('ACHF','NCHF')"
            'ReDim Preserve Insert(Insert.Length)
            'Insert(Insert.Length - 1) = sqlstring

            sqlstring = "update kot_det  set  packamt=b.packamount from kot_det a, view_kot  b "
            sqlstring = sqlstring & "where a.kotdetails=b.kotdetails and a.kotdetails='" & txt_KOTno.Text & "' "
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring

            'sqlstring = "update kot_det  set ser_chg=(isnull(amount,0) *5.15/100) Where  kotdetails='" & txt_KOTno.Text & "' and isnull(poscode,'') IN('ACHF','NCHF')"
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


            If KOTLEVELDEDUCT <> "Y" Then
                gconnection.MoreTransold(Insert)
            Else
                'CSC SMARTCARD
                'karthi july 08 
                If Trim(txt_card_id.Text) = "" And cbo_PaymentMode.Text = "SMART CARD" Then
                    MessageBox.Show("PLEASE! SWIPE YOUR CARD", "CARD NOT SWIPED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    lbl_SwipeCard.Visible = True
                    txt_card_id.Focus()
                    '                lbl_SwipeCard.Focus()
                    Exit Sub
                Else
                    If cbo_PaymentMode.Text = "SMART CARD" Then
                        Call cardcheck()
                    End If
                End If

                Dim STRSQL2 As String
                STRSQL2 = " SELECT * FROM SM_CARDFILE_DET WHERE CARDCODE='" & cardcode & "' AND POSCODE='" & StrPOSCODE & "'"
                gconnection.getDataSet(STRSQL2, "SM_CARDFILE_DET")
                If gdataset.Tables("SM_CARDFILE_DET").Rows.Count > 0 Then
                    POS_AMT_GBL = Val(txt_TotalValue.Text)
                    STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'FF' "
                    gconnection.getDataSet(STRSQL2, "FACILITY")
                    If gdataset.Tables("FACILITY").Rows.Count > 0 Then
                        'ONCE FACILITY 
                        KOT_NO_GBL = Trim(txt_KOTno.Text)
                        gconnection.MoreTransold(Insert)
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
                            If MIN_USAGE_BALANCE_HDR >= Val(txt_BillAmount.Text) Then
                                STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & "01" & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & Val(txt_BillAmount.Text) & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FM')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL

                                STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & Val(txt_BillAmount.Text) & " WHERE CARDCODE='" & cardcode & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL
                            ElseIf MIN_USAGE_BALANCE_HDR <= 0 Then
                                'DEDUCT AMOUNT ONLY FROM CARD

                                Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                                DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR
                                'to be test
                                '29/06/2010

                                DEDUCT_FROM_CARD = Val(txt_BillAmount.Text) - (MIN_USAGE_BALANCE_HDR + Val(txt_lastbillamount.Text))

                                STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & cardcode & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL

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
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL
                                'END


                                STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & "01" & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','FC')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = sTRSQL

                            ElseIf MIN_USAGE_BALANCE_HDR > 0 And MIN_USAGE_BALANCE_HDR < Val(txt_BillAmount.Text) Then

                                Dim DEDUCT_FROM_MINUSAGE, DEDUCT_FROM_CARD As Double
                                DEDUCT_FROM_MINUSAGE = MIN_USAGE_BALANCE_HDR

                                'to be test
                                '29/06/2010
                                DEDUCT_FROM_CARD = Val(txt_BillAmount.Text) - (MIN_USAGE_BALANCE_HDR + Val(txt_lastbillamount.Text))

                                'DEDUCT_FROM_CARD = Val(txt_BillAmount.Text) - MIN_USAGE_BALANCE_HDR

                                STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & "01" & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_MINUSAGE & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HM')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL


                                STRSQL = " INSERT INTO SM_POSTRANSACTION ([16_DIGIT_CODE],CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS,DEDUCT_TYPE) VALUES ( '" & txt_card_id.Text & "','" & cardcode & "','" & "01" & "','" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "','','','','','','" & Trim(txt_KOTno.Text) & "'," & DEDUCT_FROM_CARD & ",'" & Format(Now, "dd/MMM/yyy HH:mm") & "','" & Trim(gUsername) & "','N','" & Trim(Txt_Remarks.Text) & "','HC')"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL

                                STRSQL = " UPDATE SM_CARDFILE_HDR SET MIN_USG_BALANCE = MIN_USG_BALANCE -" & DEDUCT_FROM_MINUSAGE & " WHERE CARDCODE='" & cardcode & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL

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
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL
                                'END

                                STRSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE-" & DEDUCT_FROM_CARD & " WHERE CARDCODE='" & cardcode & "'"
                                ReDim Preserve Insert(Insert.Length)
                                Insert(Insert.Length - 1) = STRSQL
                            End If
                            'CARD
                            gconnection.MoreTransold(Insert)
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
                            gconnection.MoreTransold(Insert)
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
                    gconnection.MoreTransold(Insert)
                    If CHK_PRINT.Checked = True Then
                        Call Cmd_Print_Click(Cmd_Print, e)
                        Call cmd_Clear_Click(sender, e)
                    Else
                        Call cmd_Clear_Click(sender, e)
                    End If
                End If

                'sqlstring = "Insert into MemberIntime Values('" & Trim(txt_MemberCode.Text) & "','" & Format(Now, "dd/MMM/yyyy HH:mm:ss") & "')"
                'gconnection.dataOperation(6, sqlstring, "MemberInTime")
                Call txt_MemberCode_Validated(sender, e)

            End If

            If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Call Cmd_Print_Click(cmd_View, e)
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
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Call checkvalidate() '''---> Check Validation
        If chkbool = False Then Exit Sub
        Dim sqlstring, Delete(0) As String
        Dim dt As New DataTable

        If MsgBox("Do You Want To Delete", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Else
            Exit Sub
        End If



        sqlstring = "SELECT ISNULL(BillStatus,'PO') As BillStatus,ISNULL(Crostatus,'N') As Crostatus,ISNULL(PostingStatus,'N') as PostingStatus FROM Kot_Hdr WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
        dt = gconnection.GetValues(sqlstring)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("PostingStatus") = "Y" Then
                If MsgBox("The KotAmount Is Already Posted To Accounts,Deleting This Kot Also Reflects In Accounts,Are U Sure To Delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '                    Call DeleteOperation()
                    Exit Sub
                Else
                    Call cmd_Clear_Click(cmd_Clear, e)
                    Exit Sub
                End If
            ElseIf dt.Rows(0).Item("CRostatus") = "Y" Then
                If MsgBox("The KotAmount Is Already Posted To Cro,Deleting This Kot Also Reflects In Cro,Are U Sure To Delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '                    Call DeleteOperation()
                    Exit Sub
                Else
                    Call cmd_Clear_Click(cmd_Clear, e)
                    Exit Sub
                End If
            ElseIf dt.Rows(0).Item("BillStatus") = "ST" Then
                If MsgBox("The KotAmount Is Already Posted To Final Bill,Deleting This Kot Also Reflects In Final Bill,Are U Sure To Delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
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
                sqlstring = " UPDATE KOT_DET SET DELFLAG = 'Y',kotstatus='Y' WHERE KotDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring
                '''************************************************* COMPLETE KOT_HDR ***************************************************'''
                'REFERINVENTORY************************************* UPDATING STOCK FOR KOT DELETION **************************************
                sqlstring = " UPDATE SUBSTORECONSUMPTIONDETAIL SET VOID = 'Y' WHERE DOCDetails='" & Trim(CStr(Me.txt_KOTno.Text)) & "'"
                ReDim Preserve Delete(Delete.Length)
                Delete(Delete.Length - 1) = sqlstring
                '***************************************************************************************************************************

                'smart card

                If cbo_PaymentMode.Text = "SMART CARD" Then
                    sqlstring = " UPDATE SM_POSTRANSACTION SET VOID ='Y', VOIDUSER='" & gUsername & "' WHERE BILL_NO='" & Trim(txt_KOTno.Text) & "'"
                    ReDim Preserve Delete(Delete.Length)
                    Delete(Delete.Length - 1) = sqlstring

                    sqlstring = "SELECT * FROM  SM_POSTRANSACTION WHERE BILL_NO ='" & Trim(txt_KOTno.Text) & "'"
                    gconnection.getDataSet(sqlstring, "SM_POSTRANSACTION")
                    If gdataset.Tables("SM_POSTRANSACTION").Rows.Count > 0 Then
                        sqlstring = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE +" & Val(txt_BillAmount.Text) & " WHERE CARDCODE='" & Trim(txt_Holder_Code.Text) & "'"
                        ReDim Preserve Delete(Delete.Length)
                        Delete(Delete.Length - 1) = sqlstring

                        'FOR EBALANCE

                        Dim BALstr, EBAL As String
                        Dim BALnum As Double
                        sqlstring = " SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] = '" & Trim(txt_card_id.Text) & "' "
                        gconnection.getDataSet(sqlstring, "CARDFILE_HDR_BAL")
                        If gdataset.Tables("CARDFILE_HDR_BAL").Rows.Count > 0 Then
                            If IsDBNull(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) = False Then
                                BALnum = abcdMINUS(gdataset.Tables("CARDFILE_HDR_BAL").Rows(0)("EBALANCE")) + Val(txt_BillAmount.Text)
                            Else '--for zero
                                BALnum = 0 - Val(txt_BillAmount.Text)
                            End If
                        End If
                        EBAL = abcdADD(BALnum)

                        sqlstring = " UPDATE SM_CARDFILE_HDR SET EBALANCE = '" & Trim(EBAL) & "' WHERE CARDCODE='" & cardcode & "'"
                        ReDim Preserve Delete(Delete.Length)
                        Delete(Delete.Length - 1) = sqlstring
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
                    POS_AMT_GBL = Val(txt_TotalValue.Text)
                    STRSQL2 = " SELECT * FROM POSMASTER WHERE POSCODE='" & StrPOSCODE & "' AND STORESTATUS = 'FF' "
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


                gconnection.MoreTransold(Delete)

                If rac < 1 Then
                    Call cmd_Clear_Click(cmd_Clear, e)
                End If
            End If
        Else
            MessageBox.Show("Plz Enter a Valid KOTno", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Call cmd_Clear_Click(cmd_Clear, e)
            Exit Sub
        End If
        Call cmd_Clear_Click(cmd_Clear, e)
    End Sub
    Private Sub cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_View.Click
        gPrint = False
        txt_LOCATIONCODE_Validated(sender, e)
        Call PrintOperation()
    End Sub
    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        txt_LOCATIONCODE_Validated(sender, e)
        Call PrintOperation()
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        smartdeviceportcount = 0
        Me.Close()
    End Sub
    Private Sub lbl_SwipeCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_SwipeCard.Click

    End Sub
    Private Sub pnl_POSCode_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnl_POSCode.Paint

    End Sub
    Private Sub KOTEntry_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        'txt_card_id.Focus()
    End Sub

    Private Sub txt_card_id_GiveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles txt_card_id.GiveFeedback

    End Sub
End Class