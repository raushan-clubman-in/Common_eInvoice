Public Class CashSales
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_Membername As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_POSlocation As System.Windows.Forms.CheckBox
    Friend WithEvents chklist_POSlocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents chklist_Membername As System.Windows.Forms.CheckedListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Chk_PAYMENTMODE As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CHKLIST_PAYMENTMODE As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHK_CRO As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_BILLSUMMARY As System.Windows.Forms.CheckBox
    Friend WithEvents chk_uncro As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_Servercode As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllServer As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CashSales))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Chk_Membername = New System.Windows.Forms.CheckBox
        Me.Chk_POSlocation = New System.Windows.Forms.CheckBox
        Me.chklist_POSlocation = New System.Windows.Forms.CheckedListBox
        Me.chklist_Membername = New System.Windows.Forms.CheckedListBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Chk_PAYMENTMODE = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CHKLIST_PAYMENTMODE = New System.Windows.Forms.CheckedListBox
        Me.CHK_CRO = New System.Windows.Forms.CheckBox
        Me.CHK_BILLSUMMARY = New System.Windows.Forms.CheckBox
        Me.chk_uncro = New System.Windows.Forms.CheckBox
        Me.Chklist_Servercode = New System.Windows.Forms.CheckedListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Chk_SelectAllServer = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(456, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 25)
        Me.Label3.TabIndex = 393
        Me.Label3.Text = "CASH SALE REGISTER"
        '
        'Chk_Membername
        '
        Me.Chk_Membername.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Membername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Membername.Location = New System.Drawing.Point(448, 72)
        Me.Chk_Membername.Name = "Chk_Membername"
        Me.Chk_Membername.Size = New System.Drawing.Size(141, 24)
        Me.Chk_Membername.TabIndex = 391
        Me.Chk_Membername.Text = "SELECT ALL"
        '
        'Chk_POSlocation
        '
        Me.Chk_POSlocation.BackColor = System.Drawing.Color.Transparent
        Me.Chk_POSlocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_POSlocation.Location = New System.Drawing.Point(160, 72)
        Me.Chk_POSlocation.Name = "Chk_POSlocation"
        Me.Chk_POSlocation.Size = New System.Drawing.Size(132, 24)
        Me.Chk_POSlocation.TabIndex = 390
        Me.Chk_POSlocation.Text = "SELECT ALL"
        '
        'chklist_POSlocation
        '
        Me.chklist_POSlocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_POSlocation.Location = New System.Drawing.Point(160, 120)
        Me.chklist_POSlocation.Name = "chklist_POSlocation"
        Me.chklist_POSlocation.Size = New System.Drawing.Size(272, 340)
        Me.chklist_POSlocation.TabIndex = 387
        '
        'chklist_Membername
        '
        Me.chklist_Membername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_Membername.Location = New System.Drawing.Point(448, 120)
        Me.chklist_Membername.Name = "chklist_Membername"
        Me.chklist_Membername.Size = New System.Drawing.Size(248, 130)
        Me.chklist_Membername.TabIndex = 388
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(256, 608)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 399
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(576, 608)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 396
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(744, 608)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 398
        Me.cmdexit.Text = "Exit[F11]"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(200, 520)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 397
        Me.grp_SalebillChecklist.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(360, 24)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 18)
        Me.lbl_Wait.TabIndex = 387
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 40)
        Me.ProgressBar1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(200, 520)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 394
        Me.GroupBox3.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(184, 24)
        Me.mskFromDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(144, 26)
        Me.mskFromDate.TabIndex = 0
        Me.mskFromDate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(400, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TO DATE :"
        '
        'mskToDate
        '
        Me.mskToDate.CustomFormat = "dd-MM-yyyy"
        Me.mskToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskToDate.Location = New System.Drawing.Point(504, 24)
        Me.mskToDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(144, 26)
        Me.mskToDate.TabIndex = 1
        Me.mskToDate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(416, 608)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 395
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(200, 592)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox4.TabIndex = 400
        Me.GroupBox4.TabStop = False
        '
        'Timer1
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(344, 656)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 416
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(160, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 24)
        Me.Label2.TabIndex = 420
        Me.Label2.Text = "POS LOCATION :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(448, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 24)
        Me.Label4.TabIndex = 421
        Me.Label4.Text = "USER NAME  :"
        '
        'Chk_PAYMENTMODE
        '
        Me.Chk_PAYMENTMODE.BackColor = System.Drawing.Color.Transparent
        Me.Chk_PAYMENTMODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_PAYMENTMODE.Location = New System.Drawing.Point(450, 248)
        Me.Chk_PAYMENTMODE.Name = "Chk_PAYMENTMODE"
        Me.Chk_PAYMENTMODE.Size = New System.Drawing.Size(134, 16)
        Me.Chk_PAYMENTMODE.TabIndex = 457
        Me.Chk_PAYMENTMODE.Text = "SELECT ALL"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(450, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(246, 23)
        Me.Label9.TabIndex = 456
        Me.Label9.Text = "PAYMENTMODE:"
        '
        'CHKLIST_PAYMENTMODE
        '
        Me.CHKLIST_PAYMENTMODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CHKLIST_PAYMENTMODE.Location = New System.Drawing.Point(376, 240)
        Me.CHKLIST_PAYMENTMODE.Name = "CHKLIST_PAYMENTMODE"
        Me.CHKLIST_PAYMENTMODE.Size = New System.Drawing.Size(248, 172)
        Me.CHKLIST_PAYMENTMODE.TabIndex = 455
        '
        'CHK_CRO
        '
        Me.CHK_CRO.BackColor = System.Drawing.Color.Transparent
        Me.CHK_CRO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_CRO.Location = New System.Drawing.Point(184, 473)
        Me.CHK_CRO.Name = "CHK_CRO"
        Me.CHK_CRO.Size = New System.Drawing.Size(160, 24)
        Me.CHK_CRO.TabIndex = 458
        Me.CHK_CRO.Text = "Cro Settled"
        Me.CHK_CRO.Visible = False
        '
        'CHK_BILLSUMMARY
        '
        Me.CHK_BILLSUMMARY.BackColor = System.Drawing.Color.Transparent
        Me.CHK_BILLSUMMARY.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_BILLSUMMARY.Location = New System.Drawing.Point(352, 8)
        Me.CHK_BILLSUMMARY.Name = "CHK_BILLSUMMARY"
        Me.CHK_BILLSUMMARY.Size = New System.Drawing.Size(160, 24)
        Me.CHK_BILLSUMMARY.TabIndex = 459
        Me.CHK_BILLSUMMARY.Text = "Bill Summary"
        '
        'chk_uncro
        '
        Me.chk_uncro.BackColor = System.Drawing.Color.Transparent
        Me.chk_uncro.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_uncro.Location = New System.Drawing.Point(504, 473)
        Me.chk_uncro.Name = "chk_uncro"
        Me.chk_uncro.Size = New System.Drawing.Size(160, 24)
        Me.chk_uncro.TabIndex = 460
        Me.chk_uncro.Text = "Cro Un Settled"
        Me.chk_uncro.Visible = False
        '
        'Chklist_Servercode
        '
        Me.Chklist_Servercode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Servercode.Location = New System.Drawing.Point(632, 72)
        Me.Chklist_Servercode.Name = "Chklist_Servercode"
        Me.Chklist_Servercode.Size = New System.Drawing.Size(256, 340)
        Me.Chklist_Servercode.TabIndex = 461
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(704, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(256, 24)
        Me.Label8.TabIndex = 463
        Me.Label8.Text = "SERVER NAME :"
        '
        'Chk_SelectAllServer
        '
        Me.Chk_SelectAllServer.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllServer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllServer.Location = New System.Drawing.Point(704, 72)
        Me.Chk_SelectAllServer.Name = "Chk_SelectAllServer"
        Me.Chk_SelectAllServer.Size = New System.Drawing.Size(136, 24)
        Me.Chk_SelectAllServer.TabIndex = 462
        Me.Chk_SelectAllServer.Text = "SELECT ALL"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Chklist_Servercode)
        Me.GroupBox1.Controls.Add(Me.CHKLIST_PAYMENTMODE)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 472)
        Me.GroupBox1.TabIndex = 464
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CHK_BILLSUMMARY)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(80, 416)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 40)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'CashSales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(992, 692)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Chk_SelectAllServer)
        Me.Controls.Add(Me.chk_uncro)
        Me.Controls.Add(Me.CHK_CRO)
        Me.Controls.Add(Me.Chk_PAYMENTMODE)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Chk_Membername)
        Me.Controls.Add(Me.Chk_POSlocation)
        Me.Controls.Add(Me.chklist_POSlocation)
        Me.Controls.Add(Me.chklist_Membername)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "CashSales"
        Me.Text = "CASH SALE REGISTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        chklist_POSlocation.Items.Clear()
        chklist_Membername.Items.Clear()
        grp_SalebillChecklist.Top = 1000
        Chk_POSlocation.Checked = False
        Chk_Membername.Checked = False
        CHK_CRO.Checked = False
        chk_uncro.Checked = False
        Chk_SelectAllServer.Checked = False
        CHK_BILLSUMMARY.Checked = False
        Call FillPOSLocation()
        Call FillMembername()
        Call FillPaymentmode()
        Call FillServerName()
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
        vconn.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.CmdView.Enabled = False
        Me.CmdPrint.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdView.Enabled = True
                    Me.CmdPrint.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                    Me.CmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub
    '''******************************  To fill POS details from POSMaster  *******************************'''
    Private Sub FillPOSLocation()
        Dim i As Integer
        chklist_POSlocation.Items.Clear()
        sqlstring = "SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER ORDER BY POSDESC "
        vconn.getDataSet(sqlstring, "POS")
        If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                With gdataset.Tables("POS").Rows(i)
                    chklist_POSlocation.Items.Add(Trim(.Item("POSdesc")))
                End With
            Next i
        End If
        chklist_POSlocation.Sorted = True
    End Sub
    '''*****************************  To fill Server details from ServerMaster  **************************'''
    Private Sub FillMembername()
        Dim i As Integer
        chklist_Membername.Items.Clear()
        sqlstring = "SELECT USERNAME FROM USERADMIN GROUP BY USERNAME"
        vconn.getDataSet(sqlstring, "SERVERMASTER")
        If gdataset.Tables("SERVERMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("SERVERMASTER").Rows.Count - 1
                With gdataset.Tables("SERVERMASTER").Rows(i)
                    chklist_Membername.Items.Add(Trim(.Item("USERNAME")))
                End With
            Next i
        End If
        chklist_Membername.Sorted = True
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        If chklist_POSlocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If chklist_Membername.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        grp_SalebillChecklist.Top = 520
        grp_SalebillChecklist.Left = 200
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 30
        Me.Timer1.Enabled = True
    End Sub
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        If chklist_POSlocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If chklist_Membername.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = True
        grp_SalebillChecklist.Top = 520
        grp_SalebillChecklist.Left = 200
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 30
        Me.Timer1.Enabled = True
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub FillPaymentmode()
        Dim sqlstring As String
        Dim i As Integer
        CHKLIST_PAYMENTMODE.Items.Clear()
        sqlstring = "select paymentcode from PaymentModeMaster where isnull(freeze,'')<>'Y'"
        vconn.getDataSet(sqlstring, "POS")
        If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                With gdataset.Tables("POS").Rows(i)
                    CHKLIST_PAYMENTMODE.Items.Add(Trim(.Item("paymentcode")))
                End With
            Next i
        End If
    End Sub
    Private Sub FillServerName()
        Dim i As Integer
        Chklist_Servercode.Items.Clear()
        sqlstring = "SELECT ISNULL(SERVERCODE,'') AS SERVERCODE,ISNULL(SERVERNAME,'') AS SERVERNAME FROM SERVERMASTER ORDER BY SERVERCODE"
        vconn.getDataSet(sqlstring, "SERVERMASTER")
        If gdataset.Tables("SERVERMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("SERVERMASTER").Rows.Count - 1
                With gdataset.Tables("SERVERMASTER").Rows(i)
                    Chklist_Servercode.Items.Add(Trim(.Item("servername")) & Space(60) & ":" & .Item("servercode"))
                End With
            Next i
        End If
        Chklist_Servercode.Sorted = True
    End Sub

    Private Sub frmCreditSalesregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillPOSLocation()
        Call FillMembername()
        Call FillPaymentmode()
        Call FillServerName()
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
        grp_SalebillChecklist.Top = 1000
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            Call viewCreditSaleregister()
        End If
    End Sub
    Private Sub mskFromDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFromDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            mskToDate.Focus()
        End If
    End Sub

    Private Sub mskToDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskToDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmdView.Focus()
        End If
    End Sub
    Public Sub viewCreditSaleregister()
        Try
            Dim POSdesc(), MemberCode(), PAYTYPE, SCODE(), insert(0), POSNAME As String
            Dim i As Integer
            Dim SQLSTRING2, SQL, ssql As String

            ssql = " update bill_hdr  set scode=b.scode "
            ssql = ssql & " from bill_hdr a,kot_det b where a.billdetails=b.billdetails and isnull(a.scode,'')=''"
            insert(0) = ssql

            ssql = " update bill_hdr  set sname=b.servername"
            ssql = ssql & " from bill_hdr a,servermaster b where a.scode=b.servercode and isnull(a.sname,'')=''"

            ReDim Preserve insert(insert.Length)
            insert(insert.Length - 1) = ssql
            vconn.MoreTransold1(insert)

            If CHK_CRO.Checked = True Or CHK_BILLSUMMARY.Checked = True Or chk_uncro.Checked = True Then
                sqlstring = "SELECT ISNULL(REMARKS,'') AS REMARKS,isnull(a.scode,'') as scode,isnull(a.sname,'') as sname,A.BILLDATE,A.BILLDETAILS,A.TOTALAMOUNT+A.ROUNDOFF AS TOTALAMOUNT,A.MCODE,A.PAYMENTMODE,A.CROSTATUS,ISNULL(B.CRONO,'') AS CRONO,"
                sqlstring = sqlstring & "ISNULL(B.Userdatetime,'') AS CRODATE FROM BILL_HDR A left outer JOIN RECEIPT_DETAILS B ON A.BILLDETAILS = B.BILLNO AND ISNULL(B.DELFLAG,'') <> 'Y' "
                POSNAME = "("
                If chklist_POSlocation.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE BILLDETAILS IN(SELECT ISNULL(A.BILLDETAILS,'') FROM KOT_DET A,POSMASTER B"
                    sqlstring = sqlstring & " WHERE A.POSCODE=B.POSCODE AND ISNULL(A.BILLDETAILS,'')<>'' "
                    sqlstring = sqlstring & " AND B.POSDESC IN ("
                    For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & chklist_POSlocation.CheckedItems(i) & "', "
                        POSNAME = POSNAME & " " & chklist_POSlocation.CheckedItems(i) & ", "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & "))"

                    POSNAME = Mid(POSNAME, 1, Len(POSNAME) - 2)
                    POSNAME = POSNAME & ")"


                Else
                    MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If chklist_Membername.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND A.ADDUSERID IN ("
                    For i = 0 To chklist_Membername.CheckedItems.Count - 1
                        MemberCode = Split(chklist_Membername.CheckedItems(i), "->")
                        sqlstring = sqlstring & "'" & MemberCode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the USER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                PAYTYPE = ""

                If CHKLIST_PAYMENTMODE.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND A.PAYMENTMODE IN ("
                    PAYTYPE = "("
                    For i = 0 To CHKLIST_PAYMENTMODE.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & CHKLIST_PAYMENTMODE.CheckedItems(i) & "', "
                        PAYTYPE = PAYTYPE & CHKLIST_PAYMENTMODE.CheckedItems(i) & ", "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"

                    PAYTYPE = Mid(PAYTYPE, 1, Len(PAYTYPE) - 2)
                    PAYTYPE = PAYTYPE & ")"

                Else
                    MsgBox("Select the Paymentmode", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                    Exit Sub
                End If
                If Chklist_Servercode.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND BILLDETAILS IN(SELECT ISNULL(BILLDETAILS,'') FROM KOT_DET "
                    sqlstring = sqlstring & " WHERE ISNULL(BILLDETAILS,'')<>'' "
                    sqlstring = sqlstring & " AND SCODE IN ("
                    For i = 0 To Chklist_Servercode.CheckedItems.Count - 1
                        SCODE = Split(Chklist_Servercode.CheckedItems(i), ":")
                        sqlstring = sqlstring & " '" & SCODE(1) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & "))"
                Else
                    MsgBox("Select the ServerMaster", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                    Exit Sub
                End If
                sqlstring = sqlstring & " AND CAST(CONVERT(CHAR(39),A.BILLDATE,106)AS DATETIME)  BETWEEN '"
                sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "' AND ISNULL(B.DELFLAG,'')<>'Y' and  ISNULL(A.DELFLAG,'')<>'Y' "
                If CHK_CRO.Checked = True Then
                    sqlstring = sqlstring & " AND CROSTATUS='Y'"
                ElseIf chk_uncro.Checked = True Then
                    sqlstring = sqlstring & " AND CROSTATUS<>'Y'"
                End If
                sqlstring = sqlstring & " ORDER BY a.scode,A.BILLDATE,A.BILLNO,A.MCODE "

                Dim Objcreditsaleregister As New BILLREG
                If CHK_CRO.Checked = True Then
                    Dim heading() As String = {"CASH SALE REGISTER-(SETTLED)   " & POSNAME}
                    Objcreditsaleregister.Reportdetails(PAYTYPE, POSNAME, sqlstring, SQLSTRING2, heading, mskFromDate.Value, mskToDate.Value)
                ElseIf chk_uncro.Checked = True Then
                    Dim heading() As String = {"SALE REGISTER-(UNSETTLED)  " & ""}
                    Objcreditsaleregister.Reportdetails(PAYTYPE, POSNAME, sqlstring, SQLSTRING2, heading, mskFromDate.Value, mskToDate.Value)
                Else
                    Dim heading() As String = {"SALE REGISTER-SUMMARY"}
                    Objcreditsaleregister.Reportdetails(PAYTYPE, POSNAME, sqlstring, SQLSTRING2, heading, mskFromDate.Value, mskToDate.Value)
                End If
            Else
                sqlstring = " SELECT * FROM VIEWCASHSALEREGISTERUSERWISE"
                If chklist_POSlocation.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE POSDESC IN ("
                    For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & chklist_POSlocation.CheckedItems(i) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If chklist_Membername.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND USERNAME IN ("
                    For i = 0 To chklist_Membername.CheckedItems.Count - 1
                        MemberCode = Split(chklist_Membername.CheckedItems(i), "->")
                        sqlstring = sqlstring & "'" & MemberCode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the USER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If CHKLIST_PAYMENTMODE.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND PAYMENTMODE IN ("
                    PAYTYPE = "("
                    For i = 0 To CHKLIST_PAYMENTMODE.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & CHKLIST_PAYMENTMODE.CheckedItems(i) & "', "
                        PAYTYPE = PAYTYPE & CHKLIST_PAYMENTMODE.CheckedItems(i) & ", "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"

                    PAYTYPE = Mid(PAYTYPE, 1, Len(PAYTYPE) - 2)
                    PAYTYPE = PAYTYPE & ")"

                Else
                    MsgBox("Select the Paymentmode", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                    Exit Sub
                End If

                sqlstring = sqlstring & " AND BILLDATE BETWEEN '"
                sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                sqlstring = sqlstring & " ORDER BY MCODE,POSDESC,BILLNO, BILLDATE"
                'Dim heading() As String

                Dim heading() As String = {"SALE REGISTER-(SUMMARY)"}
                Dim Objcreditsaleregister As New CASHSaleReg
                Objcreditsaleregister.Reportdetails(PAYTYPE, sqlstring, SQLSTRING2, heading, mskFromDate.Value, mskToDate.Value)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub Chk_Membername_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Membername.CheckedChanged
        Dim i As Integer
        If Chk_Membername.Checked = True Then
            For i = 0 To chklist_Membername.Items.Count - 1
                chklist_Membername.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_Membername.Items.Count - 1
                chklist_Membername.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub Chk_POSlocation_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_POSlocation.CheckedChanged
        Dim i As Integer
        If Chk_POSlocation.Checked = True Then
            For i = 0 To chklist_POSlocation.Items.Count - 1
                chklist_POSlocation.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_POSlocation.Items.Count - 1
                chklist_POSlocation.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub frmCreditSalesregister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            For i = 0 To chklist_POSlocation.Items.Count - 1
                chklist_POSlocation.SetItemChecked(i, True)
            Next i
            Chk_POSlocation.Checked = True
            For i = 0 To chklist_Membername.Items.Count - 1
                chklist_Membername.SetItemChecked(i, True)
            Next i
            Chk_Membername.Checked = True
            Me.mskFromDate.Focus()

            Chk_Membername.Checked = True
            For i = 0 To chklist_Membername.Items.Count - 1
                chklist_Membername.SetItemChecked(i, True)
            Next
            Chk_SelectAllServer.Checked = True
            For i = 0 To Chklist_Servercode.Items.Count - 1
                Chklist_Servercode.SetItemChecked(i, True)
            Next i
            Chk_PAYMENTMODE.Checked = True
            For i = 0 To CHKLIST_PAYMENTMODE.Items.Count - 1
                CHKLIST_PAYMENTMODE.SetItemChecked(i, True)
            Next
            Exit Sub

            'ElseIf e.KeyCode = Keys.F8 Then
            '    Call CmdPrint_Click(sender, e)
            '    Exit Sub
            'ElseIf e.KeyCode = Keys.F9 Then
            '    Call CmdView_Click(sender, e)
            '    Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            If CmdPrint.Enabled = True Then
                Call CmdPrint_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If CmdView.Enabled = True Then
                Call CmdView_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F11 Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.F Then
            Me.mskFromDate.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.T Then
            Me.mskToDate.Focus()
            Exit Sub
        ElseIf e.KeyCode = Keys.F7 Then
            Search = InputBox("ENTER TEXT", "SEARCH")
            If chklist_Membername.SelectedIndex = 0 Then
                Call Search_Item(chklist_Membername, Search)
            ElseIf chklist_POSlocation.SelectedIndex = 0 Then
                Call Search_Item(chklist_POSlocation, Search)
            End If
        End If
    End Sub


    Private Sub Chk_POSlocation_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_POSlocation.LostFocus

    End Sub


    Private Sub chklist_POSlocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklist_POSlocation.SelectedIndexChanged
        'Dim I, J As Integer
        'For J = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '    If chklist_POSlocation.GetItemChecked(J) = True Then
        '        chklist_Membername.Items.Clear()
        '        sqlstring = "SELECT DISTINCT ISNULL(K.MCODE,'') AS MCODE,ISNULL(M.MNAME,'') AS MNAME FROM KOT_DET AS K INNER JOIN MEMBERMASTER AS M ON "
        '        sqlstring = sqlstring & " M.MCODE = K.MCODE INNER JOIN POSMASTER AS P ON P.POSCODE = K.POSCODE "
        '        If chklist_POSlocation.CheckedItems.Count <> 0 Then
        '            sqlstring = sqlstring & " WHERE POSDESC IN ("
        '            For I = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '                sqlstring = sqlstring & " '" & chklist_POSlocation.CheckedItems(I) & "', "
        '            Next
        '            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
        '            sqlstring = sqlstring & ")"
        '        End If
        '        sqlstring = sqlstring & " AND MEMBERTYPECODE <> 'EM' ORDER BY MCODE"
        '        vconn.getDataSet(sqlstring, "MEMBERMASTER")
        '        If gdataset.Tables("MEMBERMASTER").Rows.Count - 1 >= 0 Then
        '            For I = 0 To gdataset.Tables("MEMBERMASTER").Rows.Count - 1
        '                With gdataset.Tables("MEMBERMASTER").Rows(I)
        '                    chklist_Membername.Items.Add(Trim(.Item("MCODE") & "->" & .Item("MNAME")))
        '                End With
        '            Next I
        '        End If
        '        chklist_Membername.Sorted = True
        '    End If
        'Next J
    End Sub
    Private Sub Chk_PAYMENTMODE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_PAYMENTMODE.CheckedChanged
        Dim i As Integer
        If Chk_PAYMENTMODE.Checked = True Then
            For i = 0 To CHKLIST_PAYMENTMODE.Items.Count - 1
                CHKLIST_PAYMENTMODE.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To CHKLIST_PAYMENTMODE.Items.Count - 1
                CHKLIST_PAYMENTMODE.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub Chk_SelectAllServer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllServer.CheckedChanged
        Try
            Dim i As Integer
            If Chk_SelectAllServer.Checked = True Then
                For i = 0 To Chklist_Servercode.Items.Count - 1
                    Chklist_Servercode.SetItemChecked(i, True)
                Next i
            Else
                For i = 0 To Chklist_Servercode.Items.Count - 1
                    Chklist_Servercode.SetItemChecked(i, False)
                Next i
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mskToDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskToDate.ValueChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
End Class
