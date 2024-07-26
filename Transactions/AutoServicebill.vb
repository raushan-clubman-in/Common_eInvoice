Imports System.Data.SqlClient
Imports System.IO
Public Class AutoServicebill
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
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents txt_KOTTime As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents txt_ServerCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MemberName As System.Windows.Forms.Label
    Friend WithEvents txt_ServerName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ServerCode As System.Windows.Forms.Label
    Friend WithEvents lbl_ServerName As System.Windows.Forms.Label
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_PaymentMode As System.Windows.Forms.Label
    Friend WithEvents lbl_BillNo As System.Windows.Forms.Label
    Friend WithEvents lbl_BillDate As System.Windows.Forms.Label
    Friend WithEvents txt_BillNo As System.Windows.Forms.TextBox
    Friend WithEvents dtp_BillDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FraGrid As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_ServerCodeHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents cbo_PaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_BillNoHelp As System.Windows.Forms.Button
    Friend WithEvents GrpBill As System.Windows.Forms.GroupBox
    Friend WithEvents GraMem As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents Lbl_Bill As System.Windows.Forms.Label
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents Cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_BillAmount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_BillAmount As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Taxamount As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Totalamount As System.Windows.Forms.TextBox
    Friend WithEvents KOT_Timer As System.Windows.Forms.Timer
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAdmAmount As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AutoServicebill))
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.txt_KOTTime = New System.Windows.Forms.TextBox
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.txt_ServerCode = New System.Windows.Forms.TextBox
        Me.lbl_MemberName = New System.Windows.Forms.Label
        Me.txt_ServerName = New System.Windows.Forms.TextBox
        Me.lbl_ServerCode = New System.Windows.Forms.Label
        Me.lbl_ServerName = New System.Windows.Forms.Label
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.lbl_MemberCode = New System.Windows.Forms.Label
        Me.txt_MemberName = New System.Windows.Forms.TextBox
        Me.lbl_PaymentMode = New System.Windows.Forms.Label
        Me.lbl_BillNo = New System.Windows.Forms.Label
        Me.lbl_BillDate = New System.Windows.Forms.Label
        Me.txt_BillNo = New System.Windows.Forms.TextBox
        Me.dtp_BillDate = New System.Windows.Forms.DateTimePicker
        Me.FraGrid = New System.Windows.Forms.GroupBox
        Me.Cmd_ServerCodeHelp = New System.Windows.Forms.Button
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.cbo_PaymentMode = New System.Windows.Forms.ComboBox
        Me.cmd_BillNoHelp = New System.Windows.Forms.Button
        Me.GrpBill = New System.Windows.Forms.GroupBox
        Me.GraMem = New System.Windows.Forms.GroupBox
        Me.Txt_Remarks = New System.Windows.Forms.TextBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.Lbl_Bill = New System.Windows.Forms.Label
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Delete = New System.Windows.Forms.Button
        Me.Cmd_AddNew = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Txt_BillAmount = New System.Windows.Forms.TextBox
        Me.lbl_BillAmount = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Txt_Taxamount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txt_Totalamount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.KOT_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAdmAmount = New System.Windows.Forms.TextBox
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Status.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Status.Location = New System.Drawing.Point(97, 80)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(0, 25)
        Me.lbl_Status.TabIndex = 57
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_KOTTime
        '
        Me.txt_KOTTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_KOTTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_KOTTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_KOTTime.Location = New System.Drawing.Point(841, 104)
        Me.txt_KOTTime.Name = "txt_KOTTime"
        Me.txt_KOTTime.ReadOnly = True
        Me.txt_KOTTime.Size = New System.Drawing.Size(88, 26)
        Me.txt_KOTTime.TabIndex = 46
        Me.txt_KOTTime.Text = ""
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.Black
        Me.lbl_Heading.Location = New System.Drawing.Point(328, 8)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(346, 35)
        Me.lbl_Heading.TabIndex = 58
        Me.lbl_Heading.Text = "AUTO SERVICE BILLING"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_ServerCode
        '
        Me.txt_ServerCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_ServerCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerCode.Location = New System.Drawing.Point(273, 222)
        Me.txt_ServerCode.MaxLength = 10
        Me.txt_ServerCode.Name = "txt_ServerCode"
        Me.txt_ServerCode.Size = New System.Drawing.Size(168, 29)
        Me.txt_ServerCode.TabIndex = 41
        Me.txt_ServerCode.Text = ""
        '
        'lbl_MemberName
        '
        Me.lbl_MemberName.AutoSize = True
        Me.lbl_MemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberName.Location = New System.Drawing.Point(555, 182)
        Me.lbl_MemberName.Name = "lbl_MemberName"
        Me.lbl_MemberName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_MemberName.TabIndex = 54
        Me.lbl_MemberName.Text = "MEMBER NAME :"
        '
        'txt_ServerName
        '
        Me.txt_ServerName.BackColor = System.Drawing.Color.Wheat
        Me.txt_ServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerName.Location = New System.Drawing.Point(729, 222)
        Me.txt_ServerName.MaxLength = 35
        Me.txt_ServerName.Name = "txt_ServerName"
        Me.txt_ServerName.ReadOnly = True
        Me.txt_ServerName.Size = New System.Drawing.Size(192, 29)
        Me.txt_ServerName.TabIndex = 42
        Me.txt_ServerName.Text = ""
        '
        'lbl_ServerCode
        '
        Me.lbl_ServerCode.AutoSize = True
        Me.lbl_ServerCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ServerCode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ServerCode.Location = New System.Drawing.Point(105, 222)
        Me.lbl_ServerCode.Name = "lbl_ServerCode"
        Me.lbl_ServerCode.Size = New System.Drawing.Size(160, 25)
        Me.lbl_ServerCode.TabIndex = 50
        Me.lbl_ServerCode.Text = "SERVER CODE :"
        '
        'lbl_ServerName
        '
        Me.lbl_ServerName.AutoSize = True
        Me.lbl_ServerName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ServerName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ServerName.Location = New System.Drawing.Point(555, 222)
        Me.lbl_ServerName.Name = "lbl_ServerName"
        Me.lbl_ServerName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_ServerName.TabIndex = 55
        Me.lbl_ServerName.Text = "SERVER NAME :"
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(273, 182)
        Me.txt_MemberCode.MaxLength = 10
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(168, 29)
        Me.txt_MemberCode.TabIndex = 39
        Me.txt_MemberCode.Text = ""
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.AutoSize = True
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.Location = New System.Drawing.Point(105, 182)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(160, 25)
        Me.lbl_MemberCode.TabIndex = 49
        Me.lbl_MemberCode.Text = "MEMBER CODE :"
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BackColor = System.Drawing.Color.Wheat
        Me.txt_MemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(729, 182)
        Me.txt_MemberName.MaxLength = 35
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.ReadOnly = True
        Me.txt_MemberName.Size = New System.Drawing.Size(192, 29)
        Me.txt_MemberName.TabIndex = 40
        Me.txt_MemberName.Text = ""
        '
        'lbl_PaymentMode
        '
        Me.lbl_PaymentMode.AutoSize = True
        Me.lbl_PaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PaymentMode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PaymentMode.Location = New System.Drawing.Point(94, 142)
        Me.lbl_PaymentMode.Name = "lbl_PaymentMode"
        Me.lbl_PaymentMode.Size = New System.Drawing.Size(171, 25)
        Me.lbl_PaymentMode.TabIndex = 48
        Me.lbl_PaymentMode.Text = "PAYMENT MODE :"
        '
        'lbl_BillNo
        '
        Me.lbl_BillNo.AutoSize = True
        Me.lbl_BillNo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillNo.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillNo.Location = New System.Drawing.Point(581, 64)
        Me.lbl_BillNo.Name = "lbl_BillNo"
        Me.lbl_BillNo.Size = New System.Drawing.Size(113, 25)
        Me.lbl_BillNo.TabIndex = 60
        Me.lbl_BillNo.Text = "BILL NO :"
        '
        'lbl_BillDate
        '
        Me.lbl_BillDate.AutoSize = True
        Me.lbl_BillDate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillDate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillDate.Location = New System.Drawing.Point(561, 104)
        Me.lbl_BillDate.Name = "lbl_BillDate"
        Me.lbl_BillDate.Size = New System.Drawing.Size(136, 25)
        Me.lbl_BillDate.TabIndex = 61
        Me.lbl_BillDate.Text = "BILL DATE :"
        '
        'txt_BillNo
        '
        Me.txt_BillNo.BackColor = System.Drawing.Color.Wheat
        Me.txt_BillNo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BillNo.ForeColor = System.Drawing.Color.Blue
        Me.txt_BillNo.Location = New System.Drawing.Point(713, 64)
        Me.txt_BillNo.Name = "txt_BillNo"
        Me.txt_BillNo.Size = New System.Drawing.Size(192, 32)
        Me.txt_BillNo.TabIndex = 44
        Me.txt_BillNo.Text = ""
        '
        'dtp_BillDate
        '
        Me.dtp_BillDate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_BillDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_BillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_BillDate.Location = New System.Drawing.Point(713, 104)
        Me.dtp_BillDate.Name = "dtp_BillDate"
        Me.dtp_BillDate.Size = New System.Drawing.Size(128, 26)
        Me.dtp_BillDate.TabIndex = 45
        '
        'FraGrid
        '
        Me.FraGrid.BackColor = System.Drawing.Color.Transparent
        Me.FraGrid.Location = New System.Drawing.Point(81, 255)
        Me.FraGrid.Name = "FraGrid"
        Me.FraGrid.Size = New System.Drawing.Size(864, 185)
        Me.FraGrid.TabIndex = 43
        Me.FraGrid.TabStop = False
        '
        'Cmd_ServerCodeHelp
        '
        Me.Cmd_ServerCodeHelp.Image = CType(resources.GetObject("Cmd_ServerCodeHelp.Image"), System.Drawing.Image)
        Me.Cmd_ServerCodeHelp.Location = New System.Drawing.Point(441, 222)
        Me.Cmd_ServerCodeHelp.Name = "Cmd_ServerCodeHelp"
        Me.Cmd_ServerCodeHelp.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ServerCodeHelp.TabIndex = 52
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(441, 182)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(23, 29)
        Me.cmd_MemberCodeHelp.TabIndex = 51
        '
        'cbo_PaymentMode
        '
        Me.cbo_PaymentMode.BackColor = System.Drawing.Color.Wheat
        Me.cbo_PaymentMode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_PaymentMode.Location = New System.Drawing.Point(273, 142)
        Me.cbo_PaymentMode.Name = "cbo_PaymentMode"
        Me.cbo_PaymentMode.Size = New System.Drawing.Size(192, 30)
        Me.cbo_PaymentMode.TabIndex = 37
        '
        'cmd_BillNoHelp
        '
        Me.cmd_BillNoHelp.Image = CType(resources.GetObject("cmd_BillNoHelp.Image"), System.Drawing.Image)
        Me.cmd_BillNoHelp.Location = New System.Drawing.Point(905, 64)
        Me.cmd_BillNoHelp.Name = "cmd_BillNoHelp"
        Me.cmd_BillNoHelp.Size = New System.Drawing.Size(23, 32)
        Me.cmd_BillNoHelp.TabIndex = 62
        '
        'GrpBill
        '
        Me.GrpBill.BackColor = System.Drawing.Color.Transparent
        Me.GrpBill.Location = New System.Drawing.Point(553, 36)
        Me.GrpBill.Name = "GrpBill"
        Me.GrpBill.Size = New System.Drawing.Size(392, 96)
        Me.GrpBill.TabIndex = 59
        Me.GrpBill.TabStop = False
        '
        'GraMem
        '
        Me.GraMem.BackColor = System.Drawing.Color.Transparent
        Me.GraMem.Location = New System.Drawing.Point(81, 129)
        Me.GraMem.Name = "GraMem"
        Me.GraMem.Size = New System.Drawing.Size(864, 127)
        Me.GraMem.TabIndex = 47
        Me.GraMem.TabStop = False
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
        Me.Txt_Remarks.TabIndex = 371
        Me.Txt_Remarks.Text = ""
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(96, 568)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(113, 25)
        Me.lbl_Remarks.TabIndex = 370
        Me.lbl_Remarks.Text = "REMARKS :"
        '
        'Lbl_Bill
        '
        Me.Lbl_Bill.AutoSize = True
        Me.Lbl_Bill.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Bill.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Bill.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_Bill.Location = New System.Drawing.Point(40, 584)
        Me.Lbl_Bill.Name = "Lbl_Bill"
        Me.Lbl_Bill.Size = New System.Drawing.Size(0, 25)
        Me.Lbl_Bill.TabIndex = 369
        Me.Lbl_Bill.Visible = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(656, 624)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 368
        Me.Cmd_Print.Text = "Print[F9]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(160, 624)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 367
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(528, 624)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 365
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Delete
        '
        Me.Cmd_Delete.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Delete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.Cmd_Delete.Image = CType(resources.GetObject("Cmd_Delete.Image"), System.Drawing.Image)
        Me.Cmd_Delete.Location = New System.Drawing.Point(408, 624)
        Me.Cmd_Delete.Name = "Cmd_Delete"
        Me.Cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Delete.TabIndex = 366
        Me.Cmd_Delete.Text = "Delete[F8]"
        '
        'Cmd_AddNew
        '
        Me.Cmd_AddNew.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_AddNew.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_AddNew.ForeColor = System.Drawing.Color.White
        Me.Cmd_AddNew.Image = CType(resources.GetObject("Cmd_AddNew.Image"), System.Drawing.Image)
        Me.Cmd_AddNew.Location = New System.Drawing.Point(280, 624)
        Me.Cmd_AddNew.Name = "Cmd_AddNew"
        Me.Cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_AddNew.TabIndex = 364
        Me.Cmd_AddNew.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(776, 624)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 363
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(120, 608)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 56)
        Me.GroupBox2.TabIndex = 362
        Me.GroupBox2.TabStop = False
        '
        'Txt_BillAmount
        '
        Me.Txt_BillAmount.BackColor = System.Drawing.Color.Wheat
        Me.Txt_BillAmount.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_BillAmount.Location = New System.Drawing.Point(752, 576)
        Me.Txt_BillAmount.MaxLength = 12
        Me.Txt_BillAmount.Name = "Txt_BillAmount"
        Me.Txt_BillAmount.ReadOnly = True
        Me.Txt_BillAmount.Size = New System.Drawing.Size(192, 29)
        Me.Txt_BillAmount.TabIndex = 361
        Me.Txt_BillAmount.Text = ""
        Me.Txt_BillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_BillAmount
        '
        Me.lbl_BillAmount.AutoSize = True
        Me.lbl_BillAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillAmount.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillAmount.Location = New System.Drawing.Point(591, 576)
        Me.lbl_BillAmount.Name = "lbl_BillAmount"
        Me.lbl_BillAmount.Size = New System.Drawing.Size(160, 25)
        Me.lbl_BillAmount.TabIndex = 360
        Me.lbl_BillAmount.Text = "BILL AMOUNT :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(56, 672)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(912, 16)
        Me.Label1.TabIndex = 359
        Me.Label1.Text = "F4-->Help  F2-->Bill No   F3-->Delete Item  Alt+P--> Payment Mode   Alt+M--> Memb" & _
        "er Code  Alt+S--> Server Code Alt+G-->Focus on Grid"
        '
        'Txt_Taxamount
        '
        Me.Txt_Taxamount.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Taxamount.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Taxamount.Location = New System.Drawing.Point(752, 536)
        Me.Txt_Taxamount.MaxLength = 12
        Me.Txt_Taxamount.Name = "Txt_Taxamount"
        Me.Txt_Taxamount.ReadOnly = True
        Me.Txt_Taxamount.Size = New System.Drawing.Size(192, 29)
        Me.Txt_Taxamount.TabIndex = 373
        Me.Txt_Taxamount.Text = ""
        Me.Txt_Taxamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(578, 536)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 372
        Me.Label2.Text = "S.TAX AMOUNT :"
        '
        'Txt_Totalamount
        '
        Me.Txt_Totalamount.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Totalamount.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Totalamount.Location = New System.Drawing.Point(752, 451)
        Me.Txt_Totalamount.MaxLength = 12
        Me.Txt_Totalamount.Name = "Txt_Totalamount"
        Me.Txt_Totalamount.ReadOnly = True
        Me.Txt_Totalamount.Size = New System.Drawing.Size(192, 29)
        Me.Txt_Totalamount.TabIndex = 375
        Me.Txt_Totalamount.Text = ""
        Me.Txt_Totalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(576, 452)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 25)
        Me.Label3.TabIndex = 374
        Me.Label3.Text = "TOTAL AMOUNT :"
        '
        'KOT_Timer
        '
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(88, 262)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(840, 170)
        Me.ssGrid.TabIndex = 376
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(518, 491)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(230, 25)
        Me.Label4.TabIndex = 377
        Me.Label4.Text = "ADMIN CHG. AMOUNT :"
        '
        'txtAdmAmount
        '
        Me.txtAdmAmount.BackColor = System.Drawing.Color.Wheat
        Me.txtAdmAmount.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmAmount.Location = New System.Drawing.Point(752, 491)
        Me.txtAdmAmount.MaxLength = 12
        Me.txtAdmAmount.Name = "txtAdmAmount"
        Me.txtAdmAmount.ReadOnly = True
        Me.txtAdmAmount.Size = New System.Drawing.Size(192, 29)
        Me.txtAdmAmount.TabIndex = 378
        Me.txtAdmAmount.Text = ""
        Me.txtAdmAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AutoServicebill
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 708)
        Me.Controls.Add(Me.txtAdmAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ssGrid)
        Me.Controls.Add(Me.Txt_Totalamount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Taxamount)
        Me.Controls.Add(Me.Label2)
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
        Me.Controls.Add(Me.Txt_BillAmount)
        Me.Controls.Add(Me.lbl_BillAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.txt_KOTTime)
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
        Me.Controls.Add(Me.dtp_BillDate)
        Me.Controls.Add(Me.FraGrid)
        Me.Controls.Add(Me.Cmd_ServerCodeHelp)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.cbo_PaymentMode)
        Me.Controls.Add(Me.cmd_BillNoHelp)
        Me.Controls.Add(Me.GrpBill)
        Me.Controls.Add(Me.GraMem)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "AutoServicebill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AUTO SERVICE BILLING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Billno(), BillDetails, KotDetails, billstatus As String
    Dim Billtotal, AdmChg, sTax, TotAmount, bTot As Double
    Dim itembool, chkbool, smartcardbool As Boolean
    Dim gconnection As New GlobalClass
    Dim totRow As Integer
    Dim i As Integer
    Private Sub autogenerate()
        Dim sqlstring, financalyear As String
        Try
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            sqlstring = "SELECT MAX(cast(SUBSTRING(BillNo,1,6) as numeric)) AS BillNo FROM BILL_HDR WHERE SUBSTRING(BILLDETAILS,1,3) = 'SVC'"
            gconnection.getDataSet(sqlstring, "Bill_hdr")
            If gdataset.Tables("Bill_hdr").Rows(0).IsNull("BillNo") = True Then
                txt_BillNo.Text = "SVC/000001/" & financalyear
            Else
                If gdataset.Tables("Bill_hdr").Rows.Count > 0 Then
                    txt_BillNo.Text = "SVC/" & Format(Val(gdataset.Tables("Bill_hdr").Rows(0).Item("BillNo")) + 1, "000000") & "/" & financalyear
                Else
                    txt_BillNo.Text = "SVC/000001/" & financalyear
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub ShowBillno()
        Dim sqlstring, financalyear As String
        Try
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            sqlstring = "SELECT MAX(cast(SUBSTRING(BillNo,1,6) as numeric)) AS BillNo FROM BILL_hdr WHERE SUBSTRING(BILLDETAILS,1,3) = 'SVC'"
            gconnection.openConnection()
            gcommand = New SqlCommand(sqlstring, gconnection.Myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is DBNull.Value Then
                    lbl_Status.Visible = True
                    lbl_Status.Text = " FIRST BILL NO "
                Else
                    lbl_Status.Visible = True
                    lbl_Status.Text = " PREVIOUS BILL NO :" & "SVC/" & Format(Val(gdreader(0)), "000000") & "/" & financalyear
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
    Private Sub fillPayment_Mode()
        Dim sqlstring As String
        Dim index As Integer
        Dim i As Integer
        Try
            If Mid(Trim(Cmd_AddNew.Text), 1, 1) = "A" Then
                sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Paymentcode  IN ('PARTY')AND ISNULL(Freeze,'N')='N'"
                cbo_PaymentMode.Items.Clear()
                gconnection.getDataSet(sqlstring, "paymentmodemaster")
                If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("paymentmodemaster").Rows.Count - 1
                        cbo_PaymentMode.Items.Add(gdataset.Tables("paymentmodemaster").Rows(i).Item("Paymentcode"))
                    Next i
                    index = cbo_PaymentMode.FindString("PARTY")
                    cbo_PaymentMode.SelectedIndex = index
                Else
                    MessageBox.Show("Plz. Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            Else
                sqlstring = " SELECT Paymentcode FROM paymentmodemaster WHERE Paymentcode  IN ('PARTY') AND ISNULL(Freeze,'N')='N'"
                cbo_PaymentMode.Items.Clear()
                gconnection.getDataSet(sqlstring, "paymentmodemaster")
                If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("paymentmodemaster").Rows.Count - 1
                        cbo_PaymentMode.Items.Add(gdataset.Tables("paymentmodemaster").Rows(i).Item("Paymentcode"))
                    Next i
                    index = cbo_PaymentMode.FindString("PARTY")
                    cbo_PaymentMode.SelectedIndex = index
                Else
                    MessageBox.Show("Plz. Enter various payment mode into payment master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
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
    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        Call clearform(Me)
        Call fillPayment_Mode()
        Call GridUnLocking()
        Call autogenerate()
        Call ShowBillno()
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
        Me.KOT_Timer.Enabled = True
        Me.cmd_BillNoHelp.Enabled = True
        Me.Cmd_AddNew.Enabled = True
        Me.txt_BillNo.ReadOnly = False
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub AutoServicebill_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
        Call fillPayment_Mode()
        Call GridUnLocking()
        Call autogenerate()
        Call ShowBillno()
        itembool = False
        cmd_BillNoHelp.Enabled = True
        KOT_Timer.Enabled = True
        KOT_Timer.Interval = 100
        Txt_BillAmount.ReadOnly = True
        ssGrid.ClearRange(1, 1, -1, -1, True)
        ssGrid.BackColor = Color.White
        ssGrid.ForeColor = Color.Black
        cbo_PaymentMode.Focus()
        kotupdate = False
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
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT mcode,mname FROM Membermaster"
        M_WhereCondition = " WHERE FREEZE='N'"
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
    End Sub
    Private Sub txt_ServerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ServerCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Me.Cmd_ServerCodeHelp.Enabled = True Then
                Call Cmd_ServerCodeHelp_Click(sender, e)
            End If
        End If
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
            ssGrid.SetActiveCell(1, 1)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Dim strstring As String
        Try
            If Trim(txt_MemberCode.Text) <> "" Then
                strstring = "SELECT * FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                gconnection.getDataSet(strstring, "MEMBERMASTER")
                If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                    txt_MemberCode.Text = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MCODE")
                    txt_MemberName.Text = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MNAME")
                    txt_ServerCode.Focus()
                Else
                    txt_MemberCode.Text = ""
                    txt_MemberCode.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Invalid Entry Plz try once again", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_MemberCode.Focus()
            Exit Sub
        End Try
    End Sub
    Private Sub txt_ServerCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ServerCode.Validated
        Dim strstring As String
        Try
            If Trim(txt_ServerCode.Text) <> "" Then
                strstring = "SELECT * FROM SERVERMASTER WHERE ServerCode='" & Trim(txt_ServerCode.Text) & "'AND Freeze='N'"
                gconnection.getDataSet(strstring, "SERVERMASTER")
                If gdataset.Tables("SERVERMASTER").Rows.Count > 0 Then
                    txt_ServerCode.Text = gdataset.Tables("SERVERMASTER").Rows(0).Item("ServerCode")
                    txt_ServerName.Text = gdataset.Tables("SERVERMASTER").Rows(0).Item("ServerName")
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

    Private Sub txt_BillNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_BillNo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_BillNoHelp_Click(cmd_BillNoHelp, e)
        End If
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
            sqlstring = "SELECT Billdetails,Billdate,BILLTIME,SCODE,SNAME,MCODE,MNAME,PAYMENTMODE,round(TOTALAMOUNT,0) as TOTALAMOUNT,CROSTATUS,BillAmount,ISNULL(Sbillstatus,'') AS Sbillstatus, Isnull(Remarks,'') as Remarks FROM Bill_Hdr WHERE SBILLDETAILS='" & Trim(billdetails) & "'   AND "
            sqlstring = sqlstring & " isnull(sBillstatus,'')='Y' And isnull(DELFLAG,'') <> 'Y' AND ISNULL(PAYMENTMODE,'')='PARTY' AND SUBSTRING(BILLDETAILS,1,3)<>'SVC' "
            ssGrid.ClearRange(1, 1, -1, -1, True)
            gconnection.getDataSet(sqlstring, "BILL_HDR")
            '''************************************************* SELECT record from KOT_HDR *********************************************''''                
            If gdataset.Tables("BILL_HDR").Rows.Count > 0 Then
                Cmd_AddNew.Text = "Update[F7]"
                Me.txt_BillNo.ReadOnly = True
                Me.cmd_BillNoHelp.Enabled = False
                KOT_Timer.Enabled = False
                Call fillPayment_Mode()
                'txt_BillNo.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("BILLDETAILS"))
                dtp_BillDate.Value = Format(CDate(gdataset.Tables("BILL_HDR").Rows(0).Item("BILLDATE")), "dd-MMM-yy")
                txt_KOTTime.Text = Format(CDate(gdataset.Tables("BILL_HDR").Rows(0).Item("BILLTIME")), "HH:mm:ss")
                txt_ServerCode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("SCODE"))
                txt_ServerName.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("SNAME"))
                txt_MemberCode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("MCODE"))
                txt_MemberName.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("MNAME"))
                Txt_BillAmount.Text = Format(Val(gdataset.Tables("BILL_HDR").Rows(0).Item("TOTALAMOUNT") & ""), "0.00")
                cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDown
                cbo_PaymentMode.Text = Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("PAYMENTMODE") & "")
                cbo_PaymentMode.DropDownStyle = ComboBoxStyle.DropDownList
                If gdataset.Tables("BILL_HDR").Rows(0).IsNull("CroStatus") = True Then
                    Me.Lbl_Bill.Visible = False
                    Cmd_AddNew.Enabled = True
                Else
                    If Trim(gdataset.Tables("BILL_HDR").Rows(0).Item("CroStatus")) <> "N" Then
                        Me.Lbl_Bill.Text = "C R O G E N E R A T E D"
                        Me.Lbl_Bill.Visible = True
                        Cmd_AddNew.Enabled = False
                    End If
                End If
                totRow = gdataset.Tables("BILL_HDR").Rows.Count
                With ssGrid
                    If gdataset.Tables("BILL_HDR").Rows.Count > 0 Then
                        Txt_Remarks.Text = Nothing
                        For i = 1 To gdataset.Tables("BILL_HDR").Rows.Count
                            .SetText(1, i, Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Billdetails")) & "")
                            If Trim(KotDetails) = "" Then
                                KotDetails = "'" & Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Billdetails")) & "'"
                            Else
                                KotDetails = KotDetails & ",'" & Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Billdetails")) & "'"
                            End If
                            .SetText(2, i, gdataset.Tables("BILL_HDR").Rows(j).Item("Billdate"))
                            .SetText(3, i, Format(Val(gdataset.Tables("BILL_HDR").Rows(j).Item("TOTALAMOUNT")), "0.00"))
                            Billtotal = Billtotal + Val(gdataset.Tables("BILL_HDR").Rows(j).Item("TOTALAMOUNT"))
                            .SetText(5, i, gdataset.Tables("BILL_HDR").Rows(j).Item("sBillStatus"))
                            If gdataset.Tables("BILL_HDR").Rows(j).Item("SBillStatus") = "Y" Then
                                .SetText(4, i, 1)
                            Else
                                .SetText(4, i, 1)
                            End If
                            If Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Remarks")) <> "" Then
                                If j = 0 Then
                                    Txt_Remarks.Text = Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Remarks"))
                                Else
                                    If Len(Txt_Remarks.Text) > 0 Then
                                        Txt_Remarks.Text = Txt_Remarks.Text & "," & Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Remarks"))
                                    Else
                                        Txt_Remarks.Text = Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Remarks"))
                                    End If
                                End If
                            End If
                            j = j + 1
                        Next
                    End If
                    Me.Txt_Totalamount.Text = Format(Val(Billtotal), "0.00")
                    AdmChg = (Val(Billtotal) * 10) / 100
                    Me.txtAdmAmount.Text = Format(AdmChg, "0.00")
                    sTax = (AdmChg * 12.36) / 100
                    Me.Txt_Taxamount.Text = Format(Val(sTax), "0.00")
                    TotAmount = Val(AdmChg) + Val(sTax)
                    Me.Txt_BillAmount.Text = Format(Val(TotAmount), "0.00")
                    .Focus()
                    .SetActiveCell(4, .ActiveRow)
                End With
            Else
                        txt_BillNo.Text = ""
                        txt_BillNo.Focus()
            End If
        End If
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

    Private Sub cbo_PaymentMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_PaymentMode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbo_PaymentMode.Text <> "" Then
                txt_MemberCode.Focus()
            End If
        End If
    End Sub

    Private Sub txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_MemberCode.Text) <> "" Then
                txt_MemberCode_Validated(sender, e)
            Else
                Call cmd_MemberCodeHelp_Click(cmd_MemberCodeHelp, e)
            End If
        End If
    End Sub

    Private Sub txt_ServerCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ServerCode.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_ServerCode.Text) <> "" Then
                txt_ServerCode_Validated(sender, e)
                If Me.Cmd_AddNew.Text = "Add [F7]" Then
                    Call FILLPARTYDETAILS()
                End If
                ssGrid.Focus()
            Else
                Call Cmd_ServerCodeHelp_Click(Cmd_ServerCodeHelp, e)
                Call FILLPARTYDETAILS()
            End If
        End If
    End Sub
    Private Sub FILLPARTYDETAILS()
        Dim sqlstring, Subpaymentmode() As String
        Dim Billtotal, AdmChg, sTax, TotAmount As Double
        KotDetails = ""
        Dim i, j As Integer
        Try
            sqlstring = "SELECT Billdetails,Billdate,ROUND(TOTALAmount,0) AS TOTALAMOUNT,ISNULL(Sbillstatus,'') AS Sbillstatus, Isnull(Remarks,'') as Remarks FROM Bill_Hdr WHERE Mcode='" & Trim(txt_MemberCode.Text) & "'   AND "
            sqlstring = sqlstring & " isnull(sBillstatus,'')<>'Y' And isnull(DELFLAG,'') <> 'Y' AND ISNULL(PAYMENTMODE,'')='PARTY' AND CAST(Convert(varchar(11),BILLDATE,6) AS DATETIME) = '" & Format(CDate(dtp_BillDate.Value), "yyyy-MM-dd") & "' "


            sqlstring = sqlstring & " ORDER BY Billdetails,Billdate"
            gconnection.getDataSet(sqlstring, "BILL_HDR")
            totRow = gdataset.Tables("BILL_HDR").Rows.Count
            With ssGrid
                If gdataset.Tables("BILL_HDR").Rows.Count > 0 Then
                    Txt_Remarks.Text = Nothing
                    For i = 1 To gdataset.Tables("BILL_HDR").Rows.Count
                        .SetText(1, i, Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Billdetails")) & "")
                        If Trim(KotDetails) = "" Then
                            KotDetails = "'" & Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Billdetails")) & "'"
                        Else
                            KotDetails = KotDetails & ",'" & Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Billdetails")) & "'"
                        End If
                        .SetText(2, i, gdataset.Tables("BILL_HDR").Rows(j).Item("Billdate"))
                        .SetText(3, i, Format(Val(gdataset.Tables("BILL_HDR").Rows(j).Item("TOTALAmount")), "0.00"))
                        Billtotal = Billtotal + Val(gdataset.Tables("BILL_HDR").Rows(j).Item("TOTALAmount"))
                        .SetText(5, i, gdataset.Tables("BILL_HDR").Rows(j).Item("sBillStatus"))
                        If gdataset.Tables("BILL_HDR").Rows(j).Item("SBillStatus") = "Y" Then
                            .SetText(4, i, 1)
                        Else
                            .SetText(4, i, 1)
                        End If
                        If Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Remarks")) <> "" Then
                            If j = 0 Then
                                Txt_Remarks.Text = Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Remarks"))
                            Else
                                If Len(Txt_Remarks.Text) > 0 Then
                                    Txt_Remarks.Text = Txt_Remarks.Text & "," & Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Remarks"))
                                Else
                                    Txt_Remarks.Text = Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("Remarks"))
                                End If
                            End If
                        End If
                        j = j + 1
                    Next
                    Me.Txt_Totalamount.Text = Format(Val(Billtotal), "0.00")
                    AdmChg = (Val(Billtotal) * 10) / 100
                    Me.txtAdmAmount.Text = Format(AdmChg, "0.00")
                    sTax = (AdmChg * 12.36) / 100
                    Me.Txt_Taxamount.Text = Format(Val(sTax), "0.00")
                    TotAmount = Val(AdmChg) + Val(sTax)
                    Me.Txt_BillAmount.Text = Format(Val(TotAmount), "0.00")
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
    Private Sub txt_MemberName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_ServerCode.Focus()
        End If
    End Sub

    Private Sub txt_ServerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ServerName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ssGrid.Focus()
            ssGrid.SetActiveCell(1, 1)
        End If
    End Sub
    Private Sub KOT_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KOT_Timer.Tick
        txt_KOTTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        gPrint = False
        Call BillPrintOperation() '''---> Call Print Funtion
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        Call BillPrintOperation() '''---> Call Print Funtion
    End Sub

    Private Sub Cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Delete.Click
        MessageBox.Show("!! OOPS !! Bill Can't be deleted ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Exit Sub
    End Sub
    Public Sub BillPrintOperation()
        Randomize()
        Dim vOutfile, vheader, vFilepath, vline, Kot, Bill, amtword, paymentmode, rupeesword As String
        Dim ssql, vCaption, vPath, str, Sqlstring, billdetails, Fsize(), Forder(), Round, Roundedvalue(), Rowprint As String
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
        billdetails = "'" & Trim(txt_BillNo.Text) & "'"
        paymentmode = Trim(cbo_PaymentMode.Text)
        Sqlstring = " SELECT ISNULL(D.KOTNO,'') AS KOTNO,ISNULL(D.BILLDETAILS,'') AS BILLDETAILS,ISNULL(D.KOTDETAILS,'') AS KOTDETAILS, "
        Sqlstring = Sqlstring & " D.KOTDATE AS KOTDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE,ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(D.POSCODE,'') AS POSCODE,"
        Sqlstring = Sqlstring & " ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(D.TAXTYPE,'') AS TAXTYPE, ISNULL(D.TAXPERC,0) AS TAXPERC,"
        Sqlstring = Sqlstring & " ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXAMOUNT,0) AS TAXAMOUNT,ISNULL(D.ITEMTYPE,'') AS ITEMTYPE,ISNULL(H.MCODE,'') AS MCODE,"
        Sqlstring = Sqlstring & " ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.STCODE,'') AS STCODE,ISNULL(H.SERVERNAME,'') AS SERVERNAME,ISNULL(H.PAYMENTTYPE,'') AS PAYMENTTYPE,ISNULL(H.GUEST,'') AS GUEST,"
        Sqlstring = Sqlstring & " ISNULL(H.ROOMNO,'') AS ROOMNO,ISNULL(H.DISCOUNTAMT,0) AS DISCOUNTAMT,ISNULL(H.PACKAMT,0) AS PACKAMT,ISNULL(H.TOTAL,0) AS TOTAL,ISNULL(H.TOTALTAX,0) AS TOTALTAX,"
        Sqlstring = Sqlstring & " ISNULL(H.BILLAMOUNT,0) AS BILLAMOUNT,ISNULL(H.ROUNDOFF,0) AS ROUNDOFF,ISNULL(H.ADDUSERID,'') AS ADDUSERID,ISNULL(H.REMARKS,'') AS REMARKS,H.ADDDATETIME AS ADDDATETIME,"
        Sqlstring = Sqlstring & " ISNULL(H.DELFLAG,'') AS DELFLAG FROM KOT_HDR AS H INNER JOIN KOT_DET AS D ON H.KOTDETAILS = D.KOTDETAILS "
        Sqlstring = Sqlstring & " WHERE BILLDETAILS = '" & Trim(txt_BillNo.Text) & "' ORDER BY BILLDETAILS,ITEMCODE"
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

                    Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(10, "-"))
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
                    Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(10, "-"))
                    Vrowcount = Vrowcount + 1
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
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine(StrDup(79, "-"))
                    Vrowcount = Vrowcount + 1
                    rupeesword = ConvertRupees(Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                    Filewrite.Write("{0,-69}", Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))
                    'Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00"))

                    Rowprint = Chr(18) & Chr(27) + "E" & Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00") & Chr(27) + "F" & Chr(15)
                    Filewrite.WriteLine("{0,10}", Rowprint)

                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine(StrDup(79, "-"))
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
                If (Vrowcount = 0 Or Vrowcount >= 17) Then
                    'If Vrowcount = 0 Then
                    If Vrowcount >= 17 Then
                        Vrowcount = 0
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
                            If Len(Rowprint) < 45 Then
                                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                                Filewrite.WriteLine()
                            Else
                                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                                Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                            End If
                            Vrowcount = Vrowcount + 2
                        End If


                        'Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(10, "-"))
                        'Filewrite.WriteLine("")
                        'Vrowcount = Vrowcount + 1
                        'Filewrite.WriteLine("{0,-69}{1,10}", "", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")), "0.00"))
                        'Filewrite.WriteLine("")
                        'Vrowcount = Vrowcount + 1
                        Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("TAXCODE")) & "' "
                        gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
                        If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                            Sqlstring = "SELECT ISNULL(DATAFILE,'') FROM MASTER..CLUBMASTER WHERE DATAFILE = '" & gDatabase & "'"
                            gconnection.getDataSet(Sqlstring, "CLUBMASTER")
                            If gdataset.Tables("CLUBMASTER").Rows.Count > 0 Then
                                'Filewrite.Write("{0,-31}{1,38}", "BILL PAYABLE ON PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                                'Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                            Else
                                'Filewrite.Write("{0,-31}{1,38}", "", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                                'Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                            End If
                            Filewrite.WriteLine("")
                            Vrowcount = Vrowcount + 1
                        End If
                        If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT")) > 0 Then
                            'Filewrite.Write("{0,69}", "                                      PACKING CHARGES @ 5% :")
                            'Filewrite.WriteLine("{0,10}", Format((Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                            Filewrite.WriteLine("")
                            Vrowcount = Vrowcount + 1
                        End If
                        If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")) > 0 Then
                            'Filewrite.Write("{0,69}", "                                       DISCOUNT PERCENTAGE :")
                            'Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                            Filewrite.WriteLine("")
                            Vrowcount = Vrowcount + 1
                        End If
                        Filewrite.WriteLine("")
                        'Filewrite.WriteLine("{0,-79}", "")
                        Vrowcount = Vrowcount + 1

                        'Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(10, "-"))
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1

                        'Filewrite.Write("{0,-50}{1,19}", "", "TOTAL :")
                        'Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                        Filewrite.WriteLine("")
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
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        'Filewrite.WriteLine(StrDup(79, "-"))
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        'rupeesword = ConvertRupees(Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
                        'Filewrite.Write("{0,-69}", Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))
                        'Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00"))
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        'Filewrite.WriteLine(StrDup(79, "-"))
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        Filewrite.Write("{0,-14}{1,-16}", "PREPARED BY:", Mid(UCase(gUsername), 1, 16))
                        Filewrite.WriteLine("{0,-40}", Mid(MyCompanyName, 1, 40))
                        Vrowcount = Vrowcount + 1
                        'Filewrite.WriteLine("{0,-14}{1,-20}", "REMARKS :   ", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("REMARKS"), 1, 20))
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
                        'Vrowcount = Vrowcount + 1

                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(Space(65) & "Continued....")
                        Vrowcount = Vrowcount + 2

                        If Vrowcount <= 24 Then
                            For i = 1 To 24 - Vrowcount
                                Filewrite.WriteLine("")
                            Next
                        End If
                        'End
                    End If

                    Vrowcount = 0
                    Sqlstring = "SELECT ISNULL(BillPrintHeader,'') AS BillPrintHeader FROM POSSETUP"
                    gconnection.getDataSet(Sqlstring, "POSSETUP")
                    If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                        If Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPrintHeader")) = "YES" Then
                            vheader = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(2) & gCompanyname & Chr(20) & Chr(27) & Chr(72)
                            'vheader = Space((65 - Len(gCompanyname)) / 2) & Chr(14) & Chr(15) & gCompanyname & Chr(18)
                            Filewrite.WriteLine(vheader)
                            vheader = Space(13) & gCompanyAddress(0)
                            'vheader = Space((65 - Len(Trim(gCompanyAddress(0)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(0) & Chr(18)
                            Filewrite.WriteLine(vheader)
                            vheader = Space(13) & gCompanyAddress(1)
                            'vheader = Space((65 - Len(Trim(gCompanyAddress(1)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(1) & Chr(18)
                            Filewrite.WriteLine(vheader)
                            Vrowcount = 3
                        End If
                    End If
                    Filewrite.WriteLine("")
                    Vrowcount = Vrowcount + 1
                    If gdataset.Tables("Manualbilldetails").Rows(0).Item("DELFLAG") <> "Y" Then
                        vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                    Else
                        vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & " V O U C H E R [D E L E T E D]"
                    End If
                    Filewrite.WriteLine("")
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine(vheader)
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("{0,-12}{1,-24}{2,-24}", Mid("BILL   NO:", 1, 10), Mid(Bill, 1, 18), "")
                    Filewrite.WriteLine("{0,-8}{1,-10}", "TIME   :", Format(gdataset.Tables("Manualbilldetails").Rows(0).Item("ADDDATETIME"), "HH:mm:ss"))
                    Vrowcount = Vrowcount + 1
                    Filewrite.Write("{0,-12}{1,-24}{2,-24}", Mid("SERVER NO:", 1, 10), Mid(CStr(gdataset.Tables("Manualbilldetails").Rows(0).Item("SERVERNAME")) & "   [" & CStr(gdataset.Tables("Manualbilldetails").Rows(0).Item("STCODE")) & "]", 1, 24), "")
                    Filewrite.WriteLine("{0,-8}{1,-10}", "DATE   :", Format(CDate(gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTDATE")), "dd/MM/yyyy"))
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine(StrDup(79, "-"))
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine("{0,-6}{1,-6}{2,-36}{3,-8}{4,-8}{5,-8}{6,-10}", "SLNO", "CODE", "ITEM DESCRIPTION", "QTY", "UOM", "RATE", "AMOUNT")
                    Vrowcount = Vrowcount + 1
                    Filewrite.WriteLine(StrDup(79, "-"))
                    Vrowcount = Vrowcount + 1
                End If
                With gdataset.Tables("Manualbilldetails").Rows(rowj)
                    Filewrite.Write("{0,-6}{1,-6}", Mid(CountItem & ".", 1, 5), Mid(Trim(.Item("ITEMCODE")), 1, 6))

                    'Modified on 06 Apr 08 for CSC Temporary Purpose
                    'Mk Kannan
                    'Begin
                    If Trim(.Item("POSCODE")) = "54" Then
                        Filewrite.Write("{0,-36}{1,-8}{2,-8}", Mid(Mid(Trim(.Item("ITEMDESC")), 1, Len(Trim(.Item("ITEMDESC"))) - 6) & Trim(".............................."), 1, 36), Mid(Format(Val(.Item("QTY")), "0.00"), 1, 8), Mid(Trim(.Item("UOM")), 1, 8))
                    Else
                        Filewrite.Write("{0,-36}{1,-8}{2,-8}", Mid(Trim(.Item("ITEMDESC")) & Trim(".............................."), 1, 36), Mid(Format(Val(.Item("QTY")), "0.00"), 1, 8), Mid(Trim(.Item("UOM")), 1, 8))
                    End If
                    'End
                    Filewrite.WriteLine("{0,-8}{1,-10}", Mid(Format(Val(.Item("RATE")), "0.00"), 1, 8), Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                    Vrowcount = Vrowcount + 1
                End With
                'If Vrowcount > 32 Then
                'Vrowcount = 0
                'vpagenumber = Val(vpagenumber) + 1
                'End If
            Next rowj
            If Vrowcount <= 17 Then
                For i = 1 To 17 - Vrowcount
                    Filewrite.WriteLine("")
                Next
            End If
            'If Vrowcount <= 16 Then
            '    For i = 1 To 16 - Vrowcount
            '        Filewrite.WriteLine("")
            '    Next
            'ElseIf Vrowcount > 16 Then
            '    Filewrite.WriteLine(StrDup(79, "-"))
            '    Filewrite.WriteLine("{0,79}", "Contd....")
            '    For i = 1 To 38 - Vrowcount + 1
            '        Filewrite.WriteLine("")
            '    Next
            '    Vrowcount = 6
            'End If
            Vrowcount = 0
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
                Rowprint = gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE")
                Rowprint = Rowprint & ":" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]"
                'Filewrite.Write("{0,-20}", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE"), 1, 20))
                'Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & "       [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]", 1, 45))
                If Len(Rowprint) < 45 Then
                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                    Filewrite.WriteLine()
                Else
                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                End If
            End If



            Vrowcount = Vrowcount + 2
            Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(10, "-"))
            Vrowcount = Vrowcount + 1
            Filewrite.WriteLine("{0,-69}{1,10}", "", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")), "0.00"))
            Vrowcount = Vrowcount + 1
            Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("Manualbilldetails").Rows(0).Item("TAXCODE")) & "' "
            gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
            If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                Filewrite.Write("{0,-31}{1,38}", "BILL PAYBLE ON PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
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
            Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(10, "-"))
            Vrowcount = Vrowcount + 1
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
            Vrowcount = Vrowcount + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            Vrowcount = Vrowcount + 1
            rupeesword = ConvertRupees(Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMT"))), "0.00"))
            Filewrite.Write("{0,-69}", Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))
            'Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00"))
            Rowprint = Chr(18) & Chr(27) + "E" & Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00") & Chr(27) + "F" & Chr(15)
            Filewrite.WriteLine("{0,10}", Rowprint)
            Vrowcount = Vrowcount + 1
            Filewrite.WriteLine(StrDup(79, "-"))
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
        End If
    End Sub
    Public Sub BillPrintOperation_OLD()
        Randomize()
        Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
        Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword As String
        Dim BillNo, sql, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno As String
        Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage As Double
        Dim ds As New DataSet
        Dim Otherbool As Boolean
        Dim Filewrite As StreamWriter
        Dim vpagenumber, Vrowcount As Long
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
                If Trim(BillNo) <> Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")) Then
                    Rowprint = Mid(Trim(cbo_PaymentMode.Text), 1, 10) & Space(27 - Len(Mid(Trim(cbo_PaymentMode.Text), 1, 10)))
                    Filewrite.Write(Chr(14) & Rowprint)
                    Rowprint = Chr(15) & ":" & Space(4) & "Mr." & Mid(Trim(Me.txt_MemberName.Text & "(" & Trim(Me.txt_MemberCode.Text) & ")"), 1, 25) & Space(40 - Len(Mid(Trim(Me.txt_MemberName.Text & "(" & Trim(Me.txt_MemberCode.Text) & ")"), 1, 40)))
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = Space(70) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = Space(74) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
                    Filewrite.WriteLine(Rowprint)
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
                    Else
                        Rowprint = "Bills Payable On Presentation"
                    End If
                    Rowprint = Rowprint & Space(74 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
                    Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                    Filewrite.WriteLine("N O  T I P P I N G")
                    Rowprint = Space(70) & "----------"
                    Filewrite.WriteLine(Rowprint)
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Rowprint = "Our VAT No : 19450049091                         Total :"
                    ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                        Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
                    Else
                        Rowprint = "                                                 Total :"
                    End If
                    Rowprint = Rowprint & Space(74 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
                    Filewrite.WriteLine(Rowprint)
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
                    Rowprint = Rowprint & Space(74 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
                    Filewrite.WriteLine(Rowprint)
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    rupeesword = ConvertRupees(Format(TaxAmount + TotalAmount, "0.00"))
                    Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 70) & Space(72 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 70)))
                    Rowprint = Rowprint & Format(Math.Round(TaxAmount + TotalAmount), "0.00")
                    Filewrite.WriteLine(Rowprint)
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine("")
                    Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                    Filewrite.WriteLine(Rowprint)
                    BillNo = gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")
                    Kot = ""
                    TotalAmount = 0
                    TaxAmount = 0
                    taxpercentage = Val(gdataset.Tables("ReportTable").Rows(rowj).Item("TaxPerc"))
                    Vrowcount = 0
                    CountItem = 1
                    Filewrite.WriteLine(Chr(12))
                End If
                If Kot <> gdataset.Tables("ReportTable").Rows(0).Item("Kotno") Then
                    If Trim(Kot) <> "" Then
                        Kot = Kot & "," & gdataset.Tables("ReportTable").Rows(0).Item("Kotno")
                    Else
                        Kot = gdataset.Tables("ReportTable").Rows(0).Item("Kotno")
                    End If
                End If
                If Vrowcount = 0 Then
                    Rowprint = Chr(14) & Chr(15) & Space((40 / 2) - (Len(gCompanyname) / 2)) & gCompanyname
                    Filewrite.WriteLine(Rowprint)
                    Filewrite.WriteLine("")
                    Rowprint = Space((80 / 2) - (Len(gCompanyAddress(0)) / 2)) & gCompanyAddress(0)
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = Space((80 / 2) - (Len(gCompanyAddress(1)) / 2)) & gCompanyAddress(1)
                    Filewrite.WriteLine(Rowprint)
                    If Format(Val(taxpercentage), "0.00") = "12.50" Then
                        Gheader = " TAX  INVOICE "
                    Else
                        Gheader = " CREDIT  MEMO "
                    End If
                    Filewrite.WriteLine("")
                    Rowprint = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "BILL NO  :" & Space(10 - Len(Mid("BILL NO   :", 1, 10)))
                    Rowprint = Rowprint & Chr(14) & Trim(BillNo)
                    Filewrite.Write(Rowprint)
                    Rowprint = Chr(15) & Space(15 - Len(Mid(Trim(BillNo), 1, 15))) & Space(37)
                    Rowprint = Rowprint & "TIME  :" & Space(8 - Len(Mid(Trim("TIME  :"), 1, 8)))
                    Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "HH:mm:ss")
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "SERVER   :" & Space(10 - Len(Mid("SERVER   :", 1, 10)))
                    Rowprint = Rowprint & Chr(14) & Trim(Me.txt_ServerCode.Text)
                    Filewrite.Write(Rowprint)
                    Rowprint = Chr(15) & "(" & Me.txt_ServerName.Text & ")" & Space(20 - Len(Mid(Trim(Me.txt_ServerCode.Text & "(" & Me.txt_ServerName.Text & ")"), 1, 20))) & Space(32)
                    'Rowprint = Rowprint & Trim(Me.txt_ServerCode.Text & "(" & Me.txt_ServerName.Text & ")") & Space(20 - Len(Mid(Trim(Me.txt_ServerCode.Text & "(" & Me.txt_ServerName.Text & ")"), 1, 20))) & Space(32)
                    Rowprint = Rowprint & "DATE  :" & Space(8 - Len(Mid(Trim("DATE  :"), 1, 8)))
                    Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy")
                    Filewrite.WriteLine(Rowprint)
                    Pagesize = Pagesize + 1
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    Rowprint = "SLNo  CODE  ITEM DESCRIPTION                      QUANTITY   RATE      AMOUNT  "
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    For i = 0 To 78
                        Filewrite.Write("-")
                    Next
                    Filewrite.WriteLine()
                    Vrowcount = 18
                End If
                With gdataset.Tables("ReportTable").Rows(rowj)
                    Rowprint = ""
                    Rowprint = Mid(CountItem, 1, 5) & "." & Space(5 - Len(Mid(CountItem, 1, 5)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMCODE") & ""), 1, 6) & Space(6 - Len(Mid(Trim(.Item("ITEMCODE") & ""), 1, 6)))
                    Rowprint = Rowprint & Mid(Trim(.Item("ITEMDESC") & ""), 1, 38) & Mid(Trim(".............................."), 1, 38 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 38)))
                    Rowprint = Rowprint & Mid(Val(.Item("QTY") & ""), 1, 2) & Space(2 - Len(Mid(Trim(.Item("QTY") & ""), 1, 2))) & Space(1)
                    Rowprint = Rowprint & Mid(Trim(.Item("UOM") & ""), 1, 5) & Space(5 - Len(Mid(Trim(.Item("UOM") & ""), 1, 5)))
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 10))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 10)
                    Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8)
                    TotalAmount = TotalAmount + Val(.Item("Amount"))
                    TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                    Filewrite.WriteLine(Rowprint & Chr(15))
                    Vrowcount = Vrowcount + 1
                End With
                If Vrowcount > 32 Then
                    Filewrite.WriteLine(vline & Chr(12))
                    Vrowcount = 0
                    vpagenumber = Val(vpagenumber) + 1
                End If
            Next rowj
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Rowprint = Mid(Trim(cbo_PaymentMode.Text), 1, 10) & Space(27 - Len(Mid(Trim(cbo_PaymentMode.Text), 1, 10)))
            Filewrite.Write(Chr(14) & Chr(15) & Rowprint)
            Rowprint = Chr(15) & ":" & Space(4) & "Mr." & Mid(Trim(Me.txt_MemberName.Text & "(" & Trim(Me.txt_MemberCode.Text) & ")"), 1, 25) & Space(40 - Len(Mid(Trim(Me.txt_MemberName.Text & "(" & Trim(Me.txt_MemberCode.Text) & ")"), 1, 40)))
            Filewrite.WriteLine(Rowprint)
            Rowprint = Space(70) & "----------"
            Filewrite.WriteLine(Rowprint)
            Rowprint = Space(74) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
            Filewrite.WriteLine(Rowprint)
            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                Rowprint = "Bills Payable On Presentation             Add VAT @ 12.50%"
            ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                Rowprint = "Bills Payable On Presentation     Add Service Tax @ 12.24%"
            Else
                Rowprint = "Bills Payable On Presentation"
            End If
            Rowprint = Rowprint & Space(74 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
            Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
            Filewrite.WriteLine("N O  T I P P I N G")
            Rowprint = Space(70) & "----------"
            Filewrite.WriteLine(Rowprint)
            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                Rowprint = "Our VAT No : 19450049091                         Total :"
            ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                Rowprint = "Our Service Tax No : 1072MCASB KOL, 05-06        Total :"
            Else
                Rowprint = "                                                 Total :"
            End If
            Rowprint = Rowprint & Space(74 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
            Filewrite.WriteLine(Rowprint)
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
            Rowprint = Rowprint & Space(74 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")
            Filewrite.WriteLine(Rowprint)
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            rupeesword = ConvertRupees(Format(Math.Round(TaxAmount + TotalAmount), "0.00"))
            Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 70) & Space(72 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 70)))
            Rowprint = Rowprint & Format(Math.Round(TaxAmount + TotalAmount), "0.00")
            Filewrite.WriteLine(Rowprint)
            For i = 0 To 78
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine("")
            Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
            Filewrite.WriteLine(Rowprint)
            Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
            Filewrite.WriteLine(Rowprint)
            Filewrite.WriteLine(Trim(Txt_Remarks.Text))
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
    Private Sub ssGrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssGrid.LeaveCell
        Call ssGridTotal()
    End Sub
    Private Function ssGridTotal()
        Dim chk As String
        Dim i, j As Integer
        Billtotal = 0
        AdmChg = 0
        sTax = 0
        TotAmount = 0
        bTot = 0
        With ssGrid
            For i = 1 To gdataset.Tables("BILL_HDR").Rows.Count
                .Col = 4
                .Row = i
                chk = ""
                chk = .Text
                If Val(chk & "") = 1 Then
                    .Col = 3
                    .Row = i
                    bTot = .Text
                    Billtotal = Billtotal + Val(bTot & "")
                End If
                j = j + 1
            Next
            Me.Txt_Totalamount.Text = Format(Val(Billtotal), "0.00")
            AdmChg = (Val(Billtotal) * 10) / 100
            Me.txtAdmAmount.Text = Format(AdmChg, "0.00")
            sTax = (AdmChg * 12.36) / 100
            Me.Txt_Taxamount.Text = Format(Val(sTax), "0.00")
            TotAmount = Val(AdmChg) + Val(sTax)
            Me.Txt_BillAmount.Text = Format(Val(TotAmount), "0.00")
        End With
    End Function

    Private Sub Cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_AddNew.Click
        Dim insert(0) As String
        Dim sqlstring, PmAccountcode, accountcode, itemdesc, roundaccountcode As String
        Dim chk, msg As String
        accountcode = ""
        roundaccountcode = "III001"
        If Val(Txt_BillAmount.Text) > 0 Then
            If Mid(CStr(Cmd_AddNew.Text), 1, 1) = "A" Then
                Call autogenerate() '''---> AUTO GENERATE 
                Billno = Split(Trim(txt_BillNo.Text), "/")

                sqlstring = "SELECT ACCOUNTIN FROM PAYMENTMODEMASTER WHERE PAYMENTCODE='" & cbo_PaymentMode.Text & "' AND ISNULL(FREEZE,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "ACCODE")
                PmAccountcode = gdataset.Tables("ACCODE").Rows(0).Item(0)
                '============================
                sqlstring = "INSERT INTO KOT_HDR(KotNo,Kotdetails,Kotdate,TableNo,Covers,DocType,SaleType,AccountCode,SLCode,MCode,Mname,RoomNo,Guest,checkin,STCode,ServerCode,ServerName,PaymentType,ServiceType,Postingtype,DiscountAmt,PackAmt,Total,TotalTax,BillAmount,RoundOff,BillStatus,Adduserid,Adddatetime,Crostatus,SubPaymentMode,"
                sqlstring = sqlstring & " Receiptstatus,Partyorderno,upduserid,upddatetime,postingstatus,Paymodeaccountcode,Remarks,Manualbillstatus,delflag,Voucherno) "
                sqlstring = sqlstring & " VALUES ('" & Trim(CStr(Billno(1))) & "','" & Trim(CStr(txt_BillNo.Text)) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy HH:mm:ss") & "',1,1,'SVC','SALES','" & Trim(accountcode) & "','" & Trim(txt_MemberCode.Text) & "', "
                sqlstring = sqlstring & " '" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_MemberName.Text) & "','','','','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerCode.Text) & "','" & Trim(txt_ServerName.Text) & "','" & Trim(cbo_PaymentMode.Text) & "',"
                sqlstring = sqlstring & " 'SALES','AUTO',0,0," & Val(txtAdmAmount.Text) & "," & Val(Txt_Taxamount.Text) & "," & Math.Round(Val(Txt_BillAmount.Text)) & ",0,'ST','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "','N','',"
                sqlstring = sqlstring & " 'N',0,'','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "','N','" & Trim(PmAccountcode) & " ','" & Trim(Txt_Remarks.Text) & "','Y','N','')"
                insert(0) = sqlstring
                ''====================KOT DET
                sqlstring = "SELECT ISNULL(ITEMDESC,'') AS ITEMDESC,ISNULL(ITEMCODE,'') AS ITEMCODE FROM ITEMMASTER WHERE ITEMCODE='882' "
                gconnection.getDataSet(sqlstring, "ITEMMASTER")
                itemdesc = gdataset.Tables("itemmaster").Rows(0).Item(0)

                sqlstring = "INSERT INTO KOT_DET(KotNo," & _
                            "KotDetails,KotDate," & _
                            "BillDetails,KotType," & _
                            "PaymentMode,Mcode," & _
                            "Scode,Covers," & _
                            "TableNo,TotAmt," & _
                            "TaxAmt,PackAmt," & _
                            "DiscAmt,BillAmt," & _
                            "ChkId,ItemCode," & _
                            "itemdesc,Poscode," & _
                            "Uom,Qty,Rate," & _
                            "Taxamount,Amount," & _
                            "ItemType,TaxCode," & _
                            "TaxPerc,TaxAccountCode," & _
                            "SalesAccountCode,GroupCode,PackPercent," & _
                            "PackAmount,Openfacilityst," & _
                            "Promotionalst,Packaccountcode," & _
                            "Taxtype,Alcholst," & _
                            "Adduserid,Adddatetime," & _
                            "KOTStatus,Delflag) " & _
                            "VALUES('" & Trim(CStr(Billno(1))) & "'," & _
                            "'" & Trim(CStr(txt_BillNo.Text)) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy HH:mm:ss") & "'," & _
                            "'" & Trim(CStr(txt_BillNo.Text)) & "','SVC'," & _
                            "'" & Trim(cbo_PaymentMode.Text) & "','" & Trim(txt_MemberCode.Text) & "'," & _
                            "'" & Trim(txt_ServerCode.Text) & "',1," & _
                            "1," & Val(txtAdmAmount.Text) & "," & _
                            "" & Val(Txt_Taxamount.Text) & ",0," & _
                            "0," & Math.Round(Val(Txt_BillAmount.Text)) & "," & _
                            "0,882," & _
                            "'" & itemdesc & "',20," & _
                            "'MISC.',1," & Val(txtAdmAmount.Text) & "," & _
                            "" & Val(Txt_Taxamount.Text) & "," & Val(txtAdmAmount.Text) & "," & _
                            "'NFD','SVC'," & _
                            "12.36,'LSC006'," & _
                            "'IOI003',18,0," & _
                            "0,'N'," & _
                            "'N',''," & _
                            "'SALES','N'," & _
                            "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'," & _
                            "'N','N')"

                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = sqlstring
                ''===================BILL HDR
                sqlstring = "INSERT INTO BILL_HDR(Billno," & _
                            "BillDetails,BillDate," & _
                            "BillTime,DiscountAmount," & _
                            "PackAmount,TaxAmount," & _
                            "BillAmount,Roundoff," & _
                            "Roundoffaccountcode,PayMentmode," & _
                            "Paymentaccountcode,SubPaymentMode," & _
                            "Subpaymentaccountcode,Mcode," & _
                            "Mname,Scode,sname," & _
                            "CroStatus,Roomno,ChkId," & _
                            "Guest,AddUserId,AddDatetime," & _
                            "Upduserid,Upddatetime," & _
                            "Adjflag,Adjdate," & _
                            "Minimumusage,CardAmount,remarks,SBILLSTATUS,SBILLDETAILS) VALUES" & _
                            "('" & Trim(CStr(Billno(1))) & "'," & _
                            "'" & Trim(CStr(txt_BillNo.Text)) & "','" & Format(dtp_BillDate.Value, "dd-MMM-yyyy ") & "'," & _
                            "'" & Format(Now, "HH:mm:ss") & "',0," & _
                            "0," & Val(Txt_Taxamount.Text) & "," & _
                            "" & Val(txtAdmAmount.Text) & ",0," & _
                            "'" & Trim(roundaccountcode) & " ','" & Trim(Me.cbo_PaymentMode.Text) & "'," & _
                            "'" & Trim(PmAccountcode) & " ',''," & _
                            "'','" & Trim(txt_MemberCode.Text) & "'," & _
                            "'" & Trim(Me.txt_MemberName.Text) & "','" & Trim(Me.txt_ServerCode.Text) & "'," & _
                            "'" & Trim(Me.txt_ServerName.Text) & "','N'," & _
                            "0,0,0,'" & gUsername & "','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'," & _
                            "'','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'," & _
                            "'N','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'," & _
                            "0,0,'" & Trim(CStr(Txt_Remarks.Text)) & "','Y','" & Trim(CStr(txt_BillNo.Text)) & "')"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = sqlstring
                ''====================BILLDET
                sqlstring = " INSERT INTO Bill_Det(Billno," & _
                            "BillDetails,BillDate," & _
                            "KotDetails,TaxAmount," & _
                            "Packamount,Discountamount," & _
                            "KotAmount,Roundoff," & _
                            "OthBillDetails,KotDate," & _
                            "TaxCode) VALUES (" & _
                            "'" & Trim(CStr(Billno(1))) & "'," & _
                            "'" & Trim(CStr(txt_BillNo.Text)) & "','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "'," & _
                            "'" & Trim(CStr(txt_BillNo.Text)) & "'," & Val(Txt_Taxamount.Text) & "," & _
                            "0,0," & _
                            "" & Val(txtAdmAmount.Text) & ",0," & _
                            "'','" & Format(CDate(Me.dtp_BillDate.Value), "dd-MMM-yyyy") & "','SVC')"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = sqlstring
                With ssGrid
                    For i = 1 To totRow
                        .Col = 4
                        .Row = i
                        chk = ""
                        chk = .Text
                        If Val(chk & "") = 1 Then
                            .Col = 1
                            .Row = i
                            sqlstring = " UPDATE BILL_HDR SET SBILLSTATUS='Y',SBILLDETAILS='" & Trim(CStr(txt_BillNo.Text)) & "' WHERE BILLDETAILS= '" & .Text & "'"
                            ReDim Preserve insert(insert.Length)
                            insert(insert.Length - 1) = sqlstring
                        End If
                    Next
                End With
                gconnection.MoreTransold(insert)
                'Cmd_Clear_Click(sender, e)
                insert.Clear(insert, 0, insert.Length)
                If MessageBox.Show("Do You Want to Print it Now", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = MsgBoxResult.OK Then
                    Call Cmd_Print_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                Else
                    Call Cmd_Clear_Click(sender, e)
                End If

            ElseIf UCase(Mid(CStr(Cmd_AddNew.Text), 1, 1)) = "U" Then

                sqlstring = "UPDATE BILL_HDR SET TAXAMOUNT=" & Txt_Taxamount.Text & ",BILLAMOUNT=" & txtAdmAmount.Text & " WHERE BILLDETAILS='" & txt_BillNo.Text & "'"
                insert(0) = sqlstring
                sqlstring = "UPDATE KOT_HDR SET TOTALTAX=" & Val(Txt_Taxamount.Text) & ",TOTAL=" & txtAdmAmount.Text & " WHERE KOTDETAILS='" & txt_BillNo.Text & "'"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = sqlstring
                sqlstring = "UPDATE KOT_DET SET TAXAMT=" & Val(Txt_Taxamount.Text) & ",TOTAMT=" & Val(txtAdmAmount.Text) & ",AMOUNT=" & Val(txtAdmAmount.Text) & ",RATE= " & txtAdmAmount.Text & " WHERE KOTDETAILS='" & txt_BillNo.Text & "'"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = sqlstring
                ''===============================================
                With ssGrid
                    For i = 1 To totRow
                        .Col = 4
                        .Row = i
                        chk = ""
                        chk = .Text
                        If Val(chk & "") = 0 Then
                            .Col = 1
                            .Row = i
                            sqlstring = " UPDATE BILL_HDR SET SBILLSTATUS='',SBILLDETAILS='' WHERE BILLDETAILS= '" & .Text & "'"
                            ReDim Preserve insert(insert.Length)
                            insert(insert.Length - 1) = sqlstring
                        End If
                    Next
                End With
                gconnection.MoreTransold(insert)
                Cmd_Clear_Click(sender, e)
                ''===============================================
            End If
        Else
            MsgBox("Bill Amount must be greater than zero", MsgBoxStyle.Critical)
        End If
    End Sub


End Class
