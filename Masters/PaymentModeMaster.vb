Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class PaymentModeMaster
    Inherits System.Windows.Forms.Form
    Dim boolchk As Boolean
    Dim sqlstring, PaymentType As String
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentcode As System.Windows.Forms.TextBox
    Friend WithEvents txtPaymentName As System.Windows.Forms.TextBox
    Friend WithEvents txtAccName As System.Windows.Forms.TextBox
    Friend WithEvents TxtAccIn As System.Windows.Forms.TextBox
    Friend WithEvents cmdAccinHelp As System.Windows.Forms.Button
    Friend WithEvents cmdPayment As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents lbl_PaymentName As System.Windows.Forms.Label
    Friend WithEvents lbl_Accountin As System.Windows.Forms.Label
    Friend WithEvents lbl_Paymentcode As System.Windows.Forms.Label
    Friend WithEvents lbl_Prefix As System.Windows.Forms.Label
    Friend WithEvents txt_Prefix As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Subpaymentmode As System.Windows.Forms.Label
    Friend WithEvents cbo_Subpaymentmode As System.Windows.Forms.ComboBox
    Friend WithEvents opt_Cheque As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Card As System.Windows.Forms.RadioButton
    Friend WithEvents opt_None As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_MemberCodeRequired As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PaymentModeMaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.opt_None = New System.Windows.Forms.RadioButton
        Me.opt_Card = New System.Windows.Forms.RadioButton
        Me.opt_Cheque = New System.Windows.Forms.RadioButton
        Me.lbl_PaymentName = New System.Windows.Forms.Label
        Me.txtAccName = New System.Windows.Forms.TextBox
        Me.cmdAccinHelp = New System.Windows.Forms.Button
        Me.TxtAccIn = New System.Windows.Forms.TextBox
        Me.txtPaymentName = New System.Windows.Forms.TextBox
        Me.cmdPayment = New System.Windows.Forms.Button
        Me.txtPaymentcode = New System.Windows.Forms.TextBox
        Me.lbl_Accountin = New System.Windows.Forms.Label
        Me.lbl_Paymentcode = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.lbl_Prefix = New System.Windows.Forms.Label
        Me.txt_Prefix = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_Subpaymentmode = New System.Windows.Forms.Label
        Me.cbo_Subpaymentmode = New System.Windows.Forms.ComboBox
        Me.cbo_MemberCodeRequired = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.opt_None)
        Me.GroupBox1.Controls.Add(Me.opt_Card)
        Me.GroupBox1.Controls.Add(Me.opt_Cheque)
        Me.GroupBox1.Location = New System.Drawing.Point(232, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 248)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'opt_None
        '
        Me.opt_None.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_None.Location = New System.Drawing.Point(432, 224)
        Me.opt_None.Name = "opt_None"
        Me.opt_None.Size = New System.Drawing.Size(72, 16)
        Me.opt_None.TabIndex = 27
        Me.opt_None.Text = "NONE"
        '
        'opt_Card
        '
        Me.opt_Card.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Card.Location = New System.Drawing.Point(208, 224)
        Me.opt_Card.Name = "opt_Card"
        Me.opt_Card.Size = New System.Drawing.Size(64, 16)
        Me.opt_Card.TabIndex = 26
        Me.opt_Card.Text = "CARD"
        '
        'opt_Cheque
        '
        Me.opt_Cheque.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Cheque.Location = New System.Drawing.Point(312, 224)
        Me.opt_Cheque.Name = "opt_Cheque"
        Me.opt_Cheque.Size = New System.Drawing.Size(88, 16)
        Me.opt_Cheque.TabIndex = 25
        Me.opt_Cheque.Text = "CHEQUE"
        '
        'lbl_PaymentName
        '
        Me.lbl_PaymentName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PaymentName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PaymentName.Location = New System.Drawing.Point(296, 144)
        Me.lbl_PaymentName.Name = "lbl_PaymentName"
        Me.lbl_PaymentName.Size = New System.Drawing.Size(144, 21)
        Me.lbl_PaymentName.TabIndex = 17
        Me.lbl_PaymentName.Text = "PAYMENT NAME "
        Me.lbl_PaymentName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtAccName
        '
        Me.txtAccName.BackColor = System.Drawing.Color.Wheat
        Me.txtAccName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccName.Location = New System.Drawing.Point(608, 272)
        Me.txtAccName.MaxLength = 35
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.ReadOnly = True
        Me.txtAccName.Size = New System.Drawing.Size(207, 26)
        Me.txtAccName.TabIndex = 5
        Me.txtAccName.Text = ""
        '
        'cmdAccinHelp
        '
        Me.cmdAccinHelp.Image = CType(resources.GetObject("cmdAccinHelp.Image"), System.Drawing.Image)
        Me.cmdAccinHelp.Location = New System.Drawing.Point(584, 272)
        Me.cmdAccinHelp.Name = "cmdAccinHelp"
        Me.cmdAccinHelp.Size = New System.Drawing.Size(27, 26)
        Me.cmdAccinHelp.TabIndex = 21
        '
        'TxtAccIn
        '
        Me.TxtAccIn.BackColor = System.Drawing.Color.Wheat
        Me.TxtAccIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAccIn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccIn.Location = New System.Drawing.Point(440, 272)
        Me.TxtAccIn.MaxLength = 10
        Me.TxtAccIn.Name = "TxtAccIn"
        Me.TxtAccIn.Size = New System.Drawing.Size(144, 26)
        Me.TxtAccIn.TabIndex = 4
        Me.TxtAccIn.Text = ""
        '
        'txtPaymentName
        '
        Me.txtPaymentName.BackColor = System.Drawing.Color.Wheat
        Me.txtPaymentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentName.Location = New System.Drawing.Point(440, 136)
        Me.txtPaymentName.MaxLength = 50
        Me.txtPaymentName.Name = "txtPaymentName"
        Me.txtPaymentName.Size = New System.Drawing.Size(248, 26)
        Me.txtPaymentName.TabIndex = 1
        Me.txtPaymentName.Text = ""
        '
        'cmdPayment
        '
        Me.cmdPayment.Image = CType(resources.GetObject("cmdPayment.Image"), System.Drawing.Image)
        Me.cmdPayment.Location = New System.Drawing.Point(584, 104)
        Me.cmdPayment.Name = "cmdPayment"
        Me.cmdPayment.Size = New System.Drawing.Size(27, 26)
        Me.cmdPayment.TabIndex = 15
        '
        'txtPaymentcode
        '
        Me.txtPaymentcode.BackColor = System.Drawing.Color.Wheat
        Me.txtPaymentcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentcode.Location = New System.Drawing.Point(440, 104)
        Me.txtPaymentcode.MaxLength = 15
        Me.txtPaymentcode.Name = "txtPaymentcode"
        Me.txtPaymentcode.Size = New System.Drawing.Size(144, 26)
        Me.txtPaymentcode.TabIndex = 0
        Me.txtPaymentcode.Text = ""
        '
        'lbl_Accountin
        '
        Me.lbl_Accountin.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Accountin.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Accountin.Location = New System.Drawing.Point(326, 275)
        Me.lbl_Accountin.Name = "lbl_Accountin"
        Me.lbl_Accountin.Size = New System.Drawing.Size(114, 21)
        Me.lbl_Accountin.TabIndex = 20
        Me.lbl_Accountin.Text = "ACCOUNT IN "
        Me.lbl_Accountin.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_Paymentcode
        '
        Me.lbl_Paymentcode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Paymentcode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Paymentcode.Location = New System.Drawing.Point(296, 104)
        Me.lbl_Paymentcode.Name = "lbl_Paymentcode"
        Me.lbl_Paymentcode.Size = New System.Drawing.Size(141, 21)
        Me.lbl_Paymentcode.TabIndex = 14
        Me.lbl_Paymentcode.Text = "PAYMENT CODE "
        Me.lbl_Paymentcode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(392, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(328, 31)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "PAYMENT MODE MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(16, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 0
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(358, 16)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 3
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(244, 16)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 2
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(130, 16)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 1
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(472, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 4
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 56)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(432, 552)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 23
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'lbl_Prefix
        '
        Me.lbl_Prefix.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Prefix.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Prefix.Location = New System.Drawing.Point(368, 176)
        Me.lbl_Prefix.Name = "lbl_Prefix"
        Me.lbl_Prefix.Size = New System.Drawing.Size(72, 21)
        Me.lbl_Prefix.TabIndex = 18
        Me.lbl_Prefix.Text = "PREFIX "
        Me.lbl_Prefix.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_Prefix
        '
        Me.txt_Prefix.BackColor = System.Drawing.Color.Wheat
        Me.txt_Prefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Prefix.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Prefix.Location = New System.Drawing.Point(440, 176)
        Me.txt_Prefix.MaxLength = 20
        Me.txt_Prefix.Name = "txt_Prefix"
        Me.txt_Prefix.Size = New System.Drawing.Size(248, 26)
        Me.txt_Prefix.TabIndex = 2
        Me.txt_Prefix.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(616, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "[F4]"
        '
        'lbl_Subpaymentmode
        '
        Me.lbl_Subpaymentmode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Subpaymentmode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Subpaymentmode.Location = New System.Drawing.Point(270, 240)
        Me.lbl_Subpaymentmode.Name = "lbl_Subpaymentmode"
        Me.lbl_Subpaymentmode.Size = New System.Drawing.Size(171, 21)
        Me.lbl_Subpaymentmode.TabIndex = 19
        Me.lbl_Subpaymentmode.Text = "SUBPAYMENTMODE "
        Me.lbl_Subpaymentmode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbo_Subpaymentmode
        '
        Me.cbo_Subpaymentmode.BackColor = System.Drawing.Color.Wheat
        Me.cbo_Subpaymentmode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Subpaymentmode.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbo_Subpaymentmode.Location = New System.Drawing.Point(440, 240)
        Me.cbo_Subpaymentmode.Name = "cbo_Subpaymentmode"
        Me.cbo_Subpaymentmode.Size = New System.Drawing.Size(120, 27)
        Me.cbo_Subpaymentmode.TabIndex = 3
        '
        'cbo_MemberCodeRequired
        '
        Me.cbo_MemberCodeRequired.BackColor = System.Drawing.Color.Wheat
        Me.cbo_MemberCodeRequired.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_MemberCodeRequired.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbo_MemberCodeRequired.Location = New System.Drawing.Point(440, 208)
        Me.cbo_MemberCodeRequired.Name = "cbo_MemberCodeRequired"
        Me.cbo_MemberCodeRequired.Size = New System.Drawing.Size(120, 27)
        Me.cbo_MemberCodeRequired.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "MEMBER CODE REQ "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 656)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 18)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(240, 344)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(576, 168)
        Me.ssGrid.TabIndex = 419
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Location = New System.Drawing.Point(232, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(592, 200)
        Me.GroupBox3.TabIndex = 420
        Me.GroupBox3.TabStop = False
        '
        'PaymentModeMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(990, 732)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbo_MemberCodeRequired)
        Me.Controls.Add(Me.cbo_Subpaymentmode)
        Me.Controls.Add(Me.ssGrid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Subpaymentmode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_Prefix)
        Me.Controls.Add(Me.lbl_Prefix)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbl_Accountin)
        Me.Controls.Add(Me.txtPaymentName)
        Me.Controls.Add(Me.txtPaymentcode)
        Me.Controls.Add(Me.lbl_PaymentName)
        Me.Controls.Add(Me.txtAccName)
        Me.Controls.Add(Me.lbl_Paymentcode)
        Me.Controls.Add(Me.TxtAccIn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdPayment)
        Me.Controls.Add(Me.cmdAccinHelp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "PaymentModeMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAYMENT MODE MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Function checkValidation()
        boolchk = False
        '''********** Check  Payment Code Can't be blank *********************'''
        If Trim(txtPaymentcode.Text) = "" Then
            MsgBox("Payment Code Can't Be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
            txtPaymentcode.Text = ""
            txtPaymentcode.Focus()
            checkValidation = False
        Else
            checkValidation = True
        End If
        '''********** Check  Payment desc Can't be blank *********************'''
        If Trim(txtPaymentName.Text) = "" Then
            MsgBox("Payment Name Can't Be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
            txtPaymentName.Text = ""
            txtPaymentName.Focus()
            checkValidation = False
        Else
            checkValidation = True
        End If
        '''********** Check  Prefix Can't be blank *********************'''
        If Trim(txt_Prefix.Text) = "" Then
            MsgBox("Prefix Can't Be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
            txt_Prefix.Text = ""
            txt_Prefix.Focus()
            checkValidation = False
        Else
            checkValidation = True
        End If
        '''********** Check PaymentType in PaymentMode *********************'''
        If opt_Card.Checked = True Then
            PaymentType = "CD"
        ElseIf opt_Cheque.Checked = True Then
            PaymentType = "CQ"
        Else
            PaymentType = "NO"
        End If
        '''********** Check  Account In Can't be blank *********************'''
        If Trim(cbo_Subpaymentmode.Text) = "NO" Then
            If Trim(TxtAccIn.Text) = "" Then
                MsgBox("Account In Can't Be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
                TxtAccIn.Text = ""
                TxtAccIn.Focus()
                checkValidation = False
            Else
                checkValidation = True
            End If
            '''********** Check  Account Name Can't be blank *********************'''
            If Trim(txtAccName.Text) = "" Then
                MsgBox("Account Name Can't be Blank", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, MyCompanyName)
                txtAccName.Text = ""
                txtAccName.Focus()
                checkValidation = False
            Else
                checkValidation = True
            End If
        End If
        boolchk = True
    End Function

    Private Sub cmdPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayment.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(PAYMENTCODE,'') AS  PAYMENTCODE,ISNULL(PAYMENTNAME,'') AS PAYMENTNAME FROM PaymentModeMaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "PAYMENTCODE,PAYMENTNAME"
        vform.vFormatstring = "              PAYMENT  CODE           |                  PAYMENT  NAME                             "
        vform.vCaption = "PAYMENT MASTER HELP "
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtPaymentcode.Text = Trim(vform.keyfield & "")
            Call txtPaymentcode_Validated(txtPaymentcode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmdAccinHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccinHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(ACCODE,'') AS ACCODE,ISNULL(ACDESC,'') AS ACDESC FROM Accountsglaccountmaster  "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(freezeflag,'') <> 'Y'"
        End If
        vform.Field = "ACCODE,ACDESC "
        vform.vFormatstring = "          ACCOUNT CODE              |                  ACCOUNT  DESCRIPTION                              "
        vform.vCaption = "ACCOUNT MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TxtAccIn.Text = Trim(vform.keyfield & "")
            Call TxtAccIn_Validated(TxtAccIn, e)
            txtAccName.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txtPaymentcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaymentcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtPaymentcode.Text) <> "" Then
                txtPaymentcode_Validated(txtPaymentcode, e)
            Else
                Call cmdPayment_Click(cmdPayment, e)
            End If
        End If
    End Sub
    Private Sub txtPaymentcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaymentcode.Validated
        Dim vstring As String
        If Trim(txtPaymentcode.Text) <> "" Then
            vSeqNo = GetSeqno(txtPaymentcode.Text)
            sqlstring = "SELECT PaymentCode,ISNULL(PaymentName,'') as PaymentName,ISNULL(AccountIn,'') AS AccountIn,ISNULL(Subpaystatus,'NO') AS subpaystatus,ISNULL(Prefix,'') AS Prefix,ISNULL(Freeze,'') AS Freeze,ISNULL(PaymentType,'') AS PaymentType,ISNULL(MemberStatus,'') AS MemberStatus,ISNULL(AddUserId,'') as AddUserId,AddDateTime FROM PaymentModeMaster WHERE paymentcode= '" & CStr(txtPaymentcode.Text) & "'"
            gconnection.getDataSet(sqlstring, "PaymentMode")
            If gdataset.Tables("PaymentMode").Rows.Count > 0 Then
                txtPaymentName.Clear()
                txtPaymentName.Text = Trim(CStr(gdataset.Tables("PaymentMode").Rows(0).Item("PaymentName")))
                txt_Prefix.Text = Trim(CStr(gdataset.Tables("PaymentMode").Rows(0).Item("Prefix")))
                cbo_Subpaymentmode.DropDownStyle = ComboBoxStyle.DropDown
                cbo_Subpaymentmode.Text = UCase(CStr(gdataset.Tables("PaymentMode").Rows(0).Item("Subpaystatus")))
                cbo_MemberCodeRequired.DropDownStyle = ComboBoxStyle.DropDown
                cbo_MemberCodeRequired.Text = UCase(CStr(gdataset.Tables("PaymentMode").Rows(0).Item("MemberStatus")))
                If Trim(cbo_Subpaymentmode.Text) = "NO" Then
                    TxtAccIn.Text = Trim(gdataset.Tables("PaymentMode").Rows(0).Item("Accountin") & "")
                    sqlstring = "SELECT ACDESC FROM accountsglaccountmaster WHERE ACCODE='" & Trim(TxtAccIn.Text) & "'"
                    vstring = gconnection.getvalue(sqlstring)
                    txtAccName.Text = vstring
                    lbl_Accountin.Visible = True
                    TxtAccIn.Visible = True
                    cmdAccinHelp.Visible = True
                    txtAccName.Visible = True
                    opt_Card.Top = 224
                    opt_Card.Left = 208
                    opt_Cheque.Top = 224
                    opt_Cheque.Left = 312
                    opt_None.Top = 224
                    opt_None.Left = 432
                Else
                    lbl_Accountin.Visible = False
                    TxtAccIn.Visible = False
                    cmdAccinHelp.Visible = False
                    txtAccName.Visible = False
                    opt_Card.Top = 200
                    opt_Card.Left = 208
                    opt_Cheque.Top = 202
                    opt_Cheque.Left = 312
                    opt_None.Top = 203
                    opt_None.Left = 432
                End If
                txtPaymentcode.ReadOnly = True
                txtPaymentName.Focus()
                If gdataset.Tables("PaymentMode").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PaymentMode").Rows(0).Item("AddDateTime")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                If gdataset.Tables("PaymentMode").Rows(0).Item("PaymentType") = "CD" Then
                    opt_Card.Checked = True
                ElseIf gdataset.Tables("PaymentMode").Rows(0).Item("PaymentType") = "CQ" Then
                    opt_Cheque.Checked = True
                Else
                    opt_None.Checked = True
                End If
                cmdPayment.Enabled = False
                Me.Cmd_Add.Text = "Update[F7]"
                Me.txtPaymentcode.ReadOnly = True
                Me.cmdPayment.Enabled = False
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
                Me.txtPaymentName.Focus()
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.Cmd_Add.Text = "Add [F7]"
                txtPaymentcode.ReadOnly = False
                txtPaymentName.Focus()
            End If

            Dim strsql As String
            Dim I As Integer
            strsql = "select * from POS_PAYMENTCONTROL WHERE PAYMENTCODE = '" & Trim(txtPaymentcode.Text) & "'"
            gconnection.getDataSet(strsql, "MEM")
            If gdataset.Tables("MEM").Rows.Count > 0 Then
                With ssGrid
                    For I = 0 To gdataset.Tables("MEM").Rows.Count - 1
                        .Col = 1
                        .Row = I + 1

                        .Text = Trim(gdataset.Tables("MEM").Rows(I).Item("POSCODE"))

                        sqlstring = "SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER"
                        sqlstring = sqlstring & " WHERE POSCODE="
                        sqlstring = sqlstring & " '" & Trim(gdataset.Tables("MEM").Rows(I).Item("POSCODE")) & "'"
                        gconnection.getDataSet(sqlstring, "TRANS")
                        If gdataset.Tables("TRANS").Rows.Count > 0 Then
                            .Col = 2
                            .Row = I + 1
                            .Text = Trim(gdataset.Tables("TRANS").Rows(0).Item("POSDESC"))
                        End If
                    Next
                    .SetActiveCell(1, 1)
                    .Focus()
                End With
            End If
        Else
            txtPaymentcode.Text = ""
            txtPaymentcode.Focus()
        End If
    End Sub
    Private Sub TxtAccIn_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAccIn.Validated
        If Trim(TxtAccIn.Text) <> "" Then
            sqlstring = "SELECT ACDESC FROM accountsglaccountmaster WHERE ACCODE='" & Trim(TxtAccIn.Text) & "'"
            gconnection.getDataSet(sqlstring, "accountsglaccountmaster")
            If gdataset.Tables("accountsglaccountmaster").Rows.Count > 0 Then
                txtAccName.Clear()
                txtAccName.Text = Trim(gdataset.Tables("accountsglaccountmaster").Rows(0).Item("ACDESC"))
                txtAccName.ReadOnly = True
                Cmd_Add.Focus()
            Else
                TxtAccIn.Clear()
                txtAccName.Clear()
                TxtAccIn.Focus()
                txtAccName.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub TxtAccIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAccIn.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            TxtAccIn_Validated(TxtAccIn, e)
            If TxtAccIn.Text <> "" Then
                Call TxtAccIn_Validated(TxtAccIn, e)
            Else
                Call cmdAccinHelp_Click(cmdAccinHelp, e)
            End If
        End If
    End Sub

    Private Sub TxtAccIn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAccIn.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(TxtAccIn.Text)
            Call cmdAccinHelp_Click(txtAccName, e)
        End If
    End Sub
    Private Sub txtPaymentcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaymentcode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmdPayment.Enabled = True Then
                Search = Trim(txtPaymentcode.Text)
                Call cmdPayment_Click(txtPaymentcode, e)
            End If
        End If
    End Sub
    Private Sub PaymentModeMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
            Exit Sub
        End If
        'If e.KeyCode = Keys.F8 Then
        '    Call Cmd_Freeze_Click(Cmd_Freeze, e)
        '    Exit Sub
        'End If
        'If e.KeyCode = Keys.F7 Then
        '    Call Cmd_Add_Click(Cmd_Add, e)
        '    Exit Sub
        'End If
        'If e.KeyCode = Keys.F9 Then
        '    Call Cmd_View_Click(Cmd_View, e)
        '    Exit Sub
        'End If

        If e.KeyCode = Keys.F8 Then
            If Cmd_Freeze.Enabled = True Then
                Call Cmd_Freeze_Click(Cmd_Freeze, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F7 Then
            If Cmd_Add.Enabled = True Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F9 Then
            If Cmd_View.Enabled = True Then
                Call Cmd_View_Click(Cmd_View, e)
                Exit Sub
            End If
        End If



        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
            Exit Sub
        End If
    End Sub
    Private Sub txtPaymentName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaymentName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_Prefix.Focus()
        End If
    End Sub
    Private Sub txtAccName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmd_Add.Focus()
        End If
    End Sub
    Private Sub PaymentModeMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbo_Subpaymentmode.SelectedIndex = 0
        cbo_MemberCodeRequired.SelectedIndex = 0
        opt_None.Checked = True
        TxtAccIn.Visible = False
        lbl_Accountin.Visible = False
        TxtAccIn.Visible = False
        cmdAccinHelp.Visible = False
        txtAccName.Visible = False
        TxtAccIn.Text = ""
        txtAccName.Text = ""
        opt_Card.Top = 200
        opt_Card.Left = 208
        opt_Cheque.Top = 202
        opt_Cheque.Left = 312
        opt_None.Top = 203
        opt_None.Left = 432
        Paymentmodebool = True
        cmdPayment.Enabled = True
        cmdPayment.Enabled = True
        ssGrid.ClearRange(1, 1, -1, -1, True)

        If gUserCategory <> "S" Then
            Call GetRights()
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
        Me.Cmd_Freeze.Enabled = False
        Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
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
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub PaymentModeMaster_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Paymentmodebool = False
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        lbl_Accountin.Visible = False
        TxtAccIn.Visible = False
        cmdAccinHelp.Visible = False
        txtAccName.Visible = False
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        cbo_Subpaymentmode.SelectedText = "YES"
        opt_Card.Top = 200
        opt_Card.Left = 208
        opt_Cheque.Top = 202
        opt_Cheque.Left = 312
        opt_None.Top = 203
        opt_None.Left = 432
        cmdPayment.Enabled = True
        txtPaymentcode.ReadOnly = False
        txtAccName.ReadOnly = False
        cmdPayment.Enabled = True
        ssGrid.ClearRange(1, 1, -1, -1, True)

        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txtPaymentcode.Focus()
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim SQL(0), TTYPE As String
        Dim I As Integer

        If Cmd_Add.Text = "Add [F7]" Then
            If checkValidation() Then
                If boolchk = False Then Exit Sub
                vSeqNo = GetSeqno(txtPaymentcode.Text)
                sqlstring = " INSERT INTO paymentmodemaster (PaymentCode,PaymentName,Paymentseqno,AccountIn,acctseqno,prefix,Subpaystatus,MemberStatus,Freeze,PaymentType,AddUserId,AddDateTime)"
                sqlstring = sqlstring & " VALUES ( '" & Trim(txtPaymentcode.Text) & "','" & Replace(Trim(txtPaymentName.Text), "'", "") & "',"
                sqlstring = sqlstring & " " & Val(vSeqNo) & " ,"
                sqlstring = sqlstring & "'" & Trim(CStr(TxtAccIn.Text)) & "',0,'" & Trim(CStr(txt_Prefix.Text)) & "','" & Trim(CStr(cbo_Subpaymentmode.Text)) & "','" & Trim(CStr(cbo_MemberCodeRequired.Text)) & "',"
                sqlstring = sqlstring & "'N','" & Trim(PaymentType) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                gconnection.dataOperation(1, sqlstring, "paymentmodemaster")
                '               Me.Cmd_Clear_Click(sender, e)
            End If
        ElseIf Cmd_Add.Text = "Update[F7]" Then
            If checkValidation() Then
                If boolchk = False Then Exit Sub
                If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                    If Me.lbl_Freeze.Visible = True Then
                        MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        boolchk = False
                        Exit Sub
                    End If
                End If
                sqlstring = "UPDATE  paymentmodemaster "
                sqlstring = sqlstring & " SET PaymentName='" & Replace(Trim(txtPaymentName.Text), "'", "") & "',AccountIn = '" & Trim(TxtAccIn.Text) & "',acctseqno =0,Subpaystatus ='" & Trim(CStr(cbo_Subpaymentmode.Text)) & "',MemberStatus = '" & Trim(CStr(cbo_MemberCodeRequired.Text)) & "' ,"
                sqlstring = sqlstring & " Prefix = '" & Trim(CStr(txt_Prefix.Text)) & "',PaymentType ='" & Trim(PaymentType) & "' ,AddUserId='" & Trim(gUsername) & "',AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',freeze='N'"
                sqlstring = sqlstring & " WHERE PaymentCode = '" & Trim(txtPaymentcode.Text) & "'"
                gconnection.dataOperation(2, sqlstring, "paymentmodemaster")
                '                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
            End If
        End If

        sqlstring = "DELETE FROM  POS_PAYMENTCONTROL WHERE PAYMENTCODE='" & Trim(txtPaymentcode.Text) & "'"

        ReDim Preserve SQL(SQL.Length)
        SQL(SQL.Length - 1) = sqlstring
        With ssGrid
            For I = 0 To ssGrid.DataRowCnt - 1
                .Row = I + 1
                .Col = 1
                TTYPE = .Text

                sqlstring = "INSERT INTO POS_PAYMENTCONTROL (PAYMENTCODE,POSCODE,ADDUSER,ADDDATE)"
                sqlstring = sqlstring & " VALUES ('" & Trim(txtPaymentcode.Text) & "','" & Trim(TTYPE) & "','" & gUsername & "','" & Format(Now(), "dd/MMM/yyyy HH:MM") & "')"

                ReDim Preserve SQL(SQL.Length)
                SQL(SQL.Length - 1) = sqlstring

            Next I
        End With
        gconnection.MoreTransold(SQL)
        Me.Cmd_Clear_Click(sender, e)

    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  PaymentModeMaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUserId='" & gUsername & " ', AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE PaymentCode = '" & Trim(txtPaymentcode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "PaymentModeMaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  PaymentModeMaster "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUserId='" & gUsername & " ', AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE PaymentCode = '" & Trim(txtPaymentcode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "PaymentModeMaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM PAYMENTMODEMASTER"
        Gheader = "PAYMENTMODE MASTER"
        FrReport.SsGridReport.SetText(2, 1, "PAYMENTCODE")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "PAYMENTNAME")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "ACCOUNTIN")
        FrReport.SsGridReport.SetText(3, 3, 10)
        FrReport.SsGridReport.SetText(2, 4, "FREEZE")
        FrReport.SsGridReport.SetText(3, 4, 6)
        FrReport.Show()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub txt_Prefix_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Prefix.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbo_MemberCodeRequired.Focus()
        End If
    End Sub

    Private Sub cbo_Subpaymentmode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Subpaymentmode.SelectedIndexChanged
        If cbo_Subpaymentmode.SelectedItem = "YES" Then
            lbl_Accountin.Visible = False
            TxtAccIn.Visible = False
            cmdAccinHelp.Visible = False
            txtAccName.Visible = False
            TxtAccIn.Text = ""
            txtAccName.Text = ""
            opt_Card.Top = 200
            opt_Card.Left = 208
            opt_Cheque.Top = 202
            opt_Cheque.Left = 312
            opt_None.Top = 203
            opt_None.Left = 432
        Else
            lbl_Accountin.Visible = True
            TxtAccIn.Visible = True
            cmdAccinHelp.Visible = True
            txtAccName.Visible = True
            TxtAccIn.Text = ""
            txtAccName.Text = ""
            opt_Card.Top = 224
            opt_Card.Left = 208
            opt_Cheque.Top = 224
            opt_Cheque.Left = 312
            opt_None.Top = 224
            opt_None.Left = 432
        End If
    End Sub

    Private Sub cbo_Subpaymentmode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Subpaymentmode.KeyPress
        Call Blank(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(cbo_Subpaymentmode.Text) = "NO" Then
                TxtAccIn.Focus()
            Else
                opt_Card.Focus()
            End If
        End If
    End Sub

    Private Sub opt_Card_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles opt_Card.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub cbo_MemberCodeRequired_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_MemberCodeRequired.KeyPress
        Call Blank(e)
        If Asc(e.KeyChar) = 13 Then
            cbo_Subpaymentmode.Focus()
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
                        sqlstring = "SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER"
                        sqlstring = sqlstring & " WHERE POSCODE="
                        .Col = 1
                        .Row = I
                        TRANS = .Text
                        sqlstring = sqlstring & " '" & TRANS & "'"
                        gconnection.getDataSet(sqlstring, "TRANS")
                        If gdataset.Tables("TRANS").Rows.Count > 0 Then
                            .Col = 1
                            .Row = I
                            .Text = gdataset.Tables("TRANS").Rows(0).Item("POSCODE")
                            .Col = 2
                            .Row = I
                            .Text = gdataset.Tables("TRANS").Rows(0).Item("POSDESC")
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
        gSQLString = "SELECT POSCODE,POSDESC FROM POSMASTER"
        M_WhereCondition = ""
        vform.Field = "POSCODE,POSDESC"
        vform.vFormatstring = "POSCODE      | POS DESC"
        vform.vCaption = "POS MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1

        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssGrid
                .Col = 1
                .Row = .ActiveRow
                .Text = Trim(vform.keyfield)
                .Col = 2
                .Row = .ActiveRow
                .Text = Trim(vform.keyfield1)
                .SetActiveCell(1, .ActiveRow)
            End With
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txtPaymentcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaymentcode.TextChanged

    End Sub
End Class