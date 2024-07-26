Public Class DEBIT_CARD_TRANSACTION
    Inherits System.Windows.Forms.Form
    Dim boolchk As Boolean
    Dim vseqno As Double
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Dim INSERT(0) As String

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Validfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmb_Validto As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_validfrom As System.Windows.Forms.Label
    Friend WithEvents Cmb_TimeFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmb_TimeTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grp_DC_trans As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmb_Duration As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_POSNAME As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Membercode As System.Windows.Forms.Label
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MemberName As System.Windows.Forms.Label
    Friend WithEvents Txt_holder_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_Holder_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmd_BillNoHelp As System.Windows.Forms.Button
    Friend WithEvents lbl_BillNo As System.Windows.Forms.Label
    Friend WithEvents txt_BillNo As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Dcard_Title As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DEBIT_CARD_TRANSACTION))
        Me.grp_DC_trans = New System.Windows.Forms.GroupBox
        Me.Cmb_Duration = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Cmb_TimeTo = New System.Windows.Forms.DateTimePicker
        Me.Cmb_TimeFrom = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cmb_Validfrom = New System.Windows.Forms.DateTimePicker
        Me.Cmb_Validto = New System.Windows.Forms.DateTimePicker
        Me.lbl_validfrom = New System.Windows.Forms.Label
        Me.Lbl_Dcard_Title = New System.Windows.Forms.Label
        Me.lbl_POSNAME = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_Membercode = New System.Windows.Forms.Label
        Me.txt_MemberName = New System.Windows.Forms.TextBox
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.lbl_MemberName = New System.Windows.Forms.Label
        Me.Txt_holder_name = New System.Windows.Forms.TextBox
        Me.txt_Holder_Code = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmd_BillNoHelp = New System.Windows.Forms.Button
        Me.lbl_BillNo = New System.Windows.Forms.Label
        Me.txt_BillNo = New System.Windows.Forms.TextBox
        Me.grp_DC_trans.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_DC_trans
        '
        Me.grp_DC_trans.BackgroundImage = CType(resources.GetObject("grp_DC_trans.BackgroundImage"), System.Drawing.Image)
        Me.grp_DC_trans.Controls.Add(Me.Cmb_Duration)
        Me.grp_DC_trans.Controls.Add(Me.GroupBox3)
        Me.grp_DC_trans.Controls.Add(Me.Label4)
        Me.grp_DC_trans.Controls.Add(Me.Cmb_TimeTo)
        Me.grp_DC_trans.Controls.Add(Me.Cmb_TimeFrom)
        Me.grp_DC_trans.Controls.Add(Me.Label2)
        Me.grp_DC_trans.Controls.Add(Me.Label3)
        Me.grp_DC_trans.Controls.Add(Me.Label1)
        Me.grp_DC_trans.Controls.Add(Me.Cmb_Validfrom)
        Me.grp_DC_trans.Controls.Add(Me.Cmb_Validto)
        Me.grp_DC_trans.Controls.Add(Me.lbl_validfrom)
        Me.grp_DC_trans.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_DC_trans.Location = New System.Drawing.Point(112, 360)
        Me.grp_DC_trans.Name = "grp_DC_trans"
        Me.grp_DC_trans.Size = New System.Drawing.Size(792, 288)
        Me.grp_DC_trans.TabIndex = 573
        Me.grp_DC_trans.TabStop = False
        '
        'Cmb_Duration
        '
        Me.Cmb_Duration.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Duration.CalendarMonthBackground = System.Drawing.Color.White
        Me.Cmb_Duration.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.Cmb_Duration.CustomFormat = "hh:mm"
        Me.Cmb_Duration.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Duration.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Cmb_Duration.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Cmb_Duration.Location = New System.Drawing.Point(184, 208)
        Me.Cmb_Duration.Name = "Cmb_Duration"
        Me.Cmb_Duration.ShowUpDown = True
        Me.Cmb_Duration.Size = New System.Drawing.Size(60, 26)
        Me.Cmb_Duration.TabIndex = 5
        Me.Cmb_Duration.Value = New Date(2008, 3, 29, 2, 0, 0, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.Cmd_Add)
        Me.GroupBox3.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(432, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 64)
        Me.GroupBox3.TabIndex = 591
        Me.GroupBox3.TabStop = False
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(56, 21)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 6
        Me.Cmd_Add.Text = "SAVE [ F7 ]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(56, 21)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 7
        Me.Cmd_Exit.Text = "Exit"
        Me.Cmd_Exit.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 18)
        Me.Label4.TabIndex = 587
        Me.Label4.Text = "DURATION"
        '
        'Cmb_TimeTo
        '
        Me.Cmb_TimeTo.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_TimeTo.CalendarMonthBackground = System.Drawing.Color.White
        Me.Cmb_TimeTo.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.Cmb_TimeTo.CustomFormat = "hh:mm"
        Me.Cmb_TimeTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_TimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Cmb_TimeTo.Location = New System.Drawing.Point(552, 128)
        Me.Cmb_TimeTo.Name = "Cmb_TimeTo"
        Me.Cmb_TimeTo.Size = New System.Drawing.Size(112, 26)
        Me.Cmb_TimeTo.TabIndex = 4
        Me.Cmb_TimeTo.Value = New Date(2008, 6, 1, 23, 0, 0, 0)
        '
        'Cmb_TimeFrom
        '
        Me.Cmb_TimeFrom.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_TimeFrom.CalendarMonthBackground = System.Drawing.Color.White
        Me.Cmb_TimeFrom.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.Cmb_TimeFrom.CustomFormat = "hh:mm"
        Me.Cmb_TimeFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_TimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Cmb_TimeFrom.Location = New System.Drawing.Point(552, 48)
        Me.Cmb_TimeFrom.Name = "Cmb_TimeFrom"
        Me.Cmb_TimeFrom.Size = New System.Drawing.Size(112, 26)
        Me.Cmb_TimeFrom.TabIndex = 2
        Me.Cmb_TimeFrom.Value = New Date(2008, 6, 1, 6, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(440, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 580
        Me.Label2.Text = "TIME TO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(440, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 579
        Me.Label3.Text = "TIME FROM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 578
        Me.Label1.Text = "VALID TO"
        '
        'Cmb_Validfrom
        '
        Me.Cmb_Validfrom.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Validfrom.CalendarMonthBackground = System.Drawing.Color.White
        Me.Cmb_Validfrom.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.Cmb_Validfrom.CustomFormat = "dd/MM/yyyy"
        Me.Cmb_Validfrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Validfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_Validfrom.Location = New System.Drawing.Point(184, 48)
        Me.Cmb_Validfrom.Name = "Cmb_Validfrom"
        Me.Cmb_Validfrom.Size = New System.Drawing.Size(104, 26)
        Me.Cmb_Validfrom.TabIndex = 1
        '
        'Cmb_Validto
        '
        Me.Cmb_Validto.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Validto.CalendarMonthBackground = System.Drawing.Color.White
        Me.Cmb_Validto.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.Cmb_Validto.CustomFormat = "dd/MM/yyyy"
        Me.Cmb_Validto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Validto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_Validto.Location = New System.Drawing.Point(184, 128)
        Me.Cmb_Validto.Name = "Cmb_Validto"
        Me.Cmb_Validto.Size = New System.Drawing.Size(104, 26)
        Me.Cmb_Validto.TabIndex = 3
        '
        'lbl_validfrom
        '
        Me.lbl_validfrom.AutoSize = True
        Me.lbl_validfrom.BackColor = System.Drawing.Color.Transparent
        Me.lbl_validfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_validfrom.Location = New System.Drawing.Point(80, 52)
        Me.lbl_validfrom.Name = "lbl_validfrom"
        Me.lbl_validfrom.Size = New System.Drawing.Size(89, 18)
        Me.lbl_validfrom.TabIndex = 575
        Me.lbl_validfrom.Text = "VALID FROM"
        '
        'Lbl_Dcard_Title
        '
        Me.Lbl_Dcard_Title.AutoSize = True
        Me.Lbl_Dcard_Title.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Dcard_Title.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Dcard_Title.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Dcard_Title.Location = New System.Drawing.Point(248, 24)
        Me.Lbl_Dcard_Title.Name = "Lbl_Dcard_Title"
        Me.Lbl_Dcard_Title.Size = New System.Drawing.Size(396, 35)
        Me.Lbl_Dcard_Title.TabIndex = 574
        Me.Lbl_Dcard_Title.Text = "DEBIT CARD TRANSACTION"
        Me.Lbl_Dcard_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_POSNAME
        '
        Me.lbl_POSNAME.AutoSize = True
        Me.lbl_POSNAME.BackColor = System.Drawing.Color.Transparent
        Me.lbl_POSNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POSNAME.ForeColor = System.Drawing.Color.Red
        Me.lbl_POSNAME.Location = New System.Drawing.Point(600, 88)
        Me.lbl_POSNAME.Name = "lbl_POSNAME"
        Me.lbl_POSNAME.Size = New System.Drawing.Size(0, 25)
        Me.lbl_POSNAME.TabIndex = 580
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(440, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 25)
        Me.Label5.TabIndex = 581
        Me.Label5.Text = "POS NAME :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.lbl_Membercode)
        Me.GroupBox1.Controls.Add(Me.txt_MemberName)
        Me.GroupBox1.Controls.Add(Me.txt_MemberCode)
        Me.GroupBox1.Controls.Add(Me.lbl_MemberName)
        Me.GroupBox1.Controls.Add(Me.Txt_holder_name)
        Me.GroupBox1.Controls.Add(Me.txt_Holder_Code)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(120, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 152)
        Me.GroupBox1.TabIndex = 593
        Me.GroupBox1.TabStop = False
        '
        'lbl_Membercode
        '
        Me.lbl_Membercode.AutoSize = True
        Me.lbl_Membercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Membercode.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_Membercode.Location = New System.Drawing.Point(8, 95)
        Me.lbl_Membercode.Name = "lbl_Membercode"
        Me.lbl_Membercode.Size = New System.Drawing.Size(207, 25)
        Me.lbl_Membercode.TabIndex = 604
        Me.lbl_Membercode.Text = "MEMBER CODE     :"
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BackColor = System.Drawing.Color.Wheat
        Me.txt_MemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(576, 94)
        Me.txt_MemberName.MaxLength = 50
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.ReadOnly = True
        Me.txt_MemberName.Size = New System.Drawing.Size(200, 29)
        Me.txt_MemberName.TabIndex = 603
        Me.txt_MemberName.Text = ""
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(216, 94)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.ReadOnly = True
        Me.txt_MemberCode.Size = New System.Drawing.Size(136, 29)
        Me.txt_MemberCode.TabIndex = 602
        Me.txt_MemberCode.Text = ""
        '
        'lbl_MemberName
        '
        Me.lbl_MemberName.AutoSize = True
        Me.lbl_MemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberName.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_MemberName.Location = New System.Drawing.Point(376, 97)
        Me.lbl_MemberName.Name = "lbl_MemberName"
        Me.lbl_MemberName.Size = New System.Drawing.Size(207, 25)
        Me.lbl_MemberName.TabIndex = 605
        Me.lbl_MemberName.Text = "MEMBER NAME     :"
        '
        'Txt_holder_name
        '
        Me.Txt_holder_name.BackColor = System.Drawing.Color.Wheat
        Me.Txt_holder_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_holder_name.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_holder_name.Location = New System.Drawing.Point(576, 30)
        Me.Txt_holder_name.MaxLength = 50
        Me.Txt_holder_name.Name = "Txt_holder_name"
        Me.Txt_holder_name.ReadOnly = True
        Me.Txt_holder_name.Size = New System.Drawing.Size(200, 29)
        Me.Txt_holder_name.TabIndex = 599
        Me.Txt_holder_name.Text = ""
        '
        'txt_Holder_Code
        '
        Me.txt_Holder_Code.BackColor = System.Drawing.Color.Wheat
        Me.txt_Holder_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Holder_Code.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Holder_Code.Location = New System.Drawing.Point(216, 30)
        Me.txt_Holder_Code.MaxLength = 15
        Me.txt_Holder_Code.Name = "txt_Holder_Code"
        Me.txt_Holder_Code.ReadOnly = True
        Me.txt_Holder_Code.Size = New System.Drawing.Size(136, 29)
        Me.txt_Holder_Code.TabIndex = 598
        Me.txt_Holder_Code.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(207, 25)
        Me.Label6.TabIndex = 600
        Me.Label6.Text = "CARD HOLDER CODE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(352, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 25)
        Me.Label7.TabIndex = 601
        Me.Label7.Text = " CARD HOLDER NAME :"
        '
        'cmd_BillNoHelp
        '
        Me.cmd_BillNoHelp.Image = CType(resources.GetObject("cmd_BillNoHelp.Image"), System.Drawing.Image)
        Me.cmd_BillNoHelp.Location = New System.Drawing.Point(864, 304)
        Me.cmd_BillNoHelp.Name = "cmd_BillNoHelp"
        Me.cmd_BillNoHelp.Size = New System.Drawing.Size(32, 32)
        Me.cmd_BillNoHelp.TabIndex = 596
        '
        'lbl_BillNo
        '
        Me.lbl_BillNo.AutoSize = True
        Me.lbl_BillNo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillNo.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillNo.Location = New System.Drawing.Point(432, 312)
        Me.lbl_BillNo.Name = "lbl_BillNo"
        Me.lbl_BillNo.Size = New System.Drawing.Size(113, 25)
        Me.lbl_BillNo.TabIndex = 595
        Me.lbl_BillNo.Text = "BILL NO :"
        '
        'txt_BillNo
        '
        Me.txt_BillNo.BackColor = System.Drawing.Color.White
        Me.txt_BillNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BillNo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BillNo.ForeColor = System.Drawing.Color.Blue
        Me.txt_BillNo.Location = New System.Drawing.Point(592, 304)
        Me.txt_BillNo.Name = "txt_BillNo"
        Me.txt_BillNo.Size = New System.Drawing.Size(272, 32)
        Me.txt_BillNo.TabIndex = 594
        Me.txt_BillNo.Text = ""
        '
        'DEBIT_CARD_TRANSACTION
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1030, 748)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmd_BillNoHelp)
        Me.Controls.Add(Me.lbl_BillNo)
        Me.Controls.Add(Me.txt_BillNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Lbl_Dcard_Title)
        Me.Controls.Add(Me.lbl_POSNAME)
        Me.Controls.Add(Me.grp_DC_trans)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DEBIT_CARD_TRANSACTION"
        Me.Text = "DEBIT CARD TRANSACTION"
        Me.grp_DC_trans.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub checkValidation()
        boolchk = False
        '''********** Check  time_from  Can't be blank *********************'''
        If Trim(Cmb_TimeFrom.Text) = "" Then
            MessageBox.Show(" Time From Cannot Be Blank ", "SMART CARD ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cmb_TimeFrom.Focus()
            Exit Sub
        End If
        '''********** Check  time_to  Can't be blank *********************'''
        If Trim(Cmb_TimeTo.Text) = "" Then
            MessageBox.Show(" Time To Cannot Be Blank ", "SMART CARD ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cmb_TimeFrom.Focus()
            Exit Sub
        End If
        '''********** Check  valid_from  Can't be blank *********************'''
        If Trim(Cmb_Validfrom.Text) = "" Then
            MessageBox.Show(" Valid From Cannot Be Blank ", "SMART CARD ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cmb_Validfrom.Focus()
            Exit Sub
        End If
        '''********** Check  valiad_to  Can't be blank *********************'''
        If Trim(Cmb_Validto.Text) = "" Then
            MessageBox.Show(" Valid To Cannot Be Blank ", "SMART CARD ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cmb_Validto.Focus()
            Exit Sub
        End If
        '''********** Check  DURATION  Can't be blank *********************'''
        If Trim(Cmb_Duration.Text) = "" Then
            MessageBox.Show(" Duration Cannot Be Blank ", "SMART CARD ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cmb_Duration.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub Cmb_Validfrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_Validfrom.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Cmb_Validto.Focus()
        End If
    End Sub
    Private Sub Cmb_Validto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_Validto.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Cmb_TimeFrom.Focus()
        End If
    End Sub
    Private Sub Cmb_TimeFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_TimeFrom.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Cmb_TimeTo.Focus()
        End If
    End Sub
    Private Sub Txt_TimeTo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Cmd_Add.Focus()
        End If
    End Sub
    Private Sub cmd_Clear_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Cmd_Exit.Focus()
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Cmb_TimeTo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_TimeTo.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Cmb_Duration.Focus()
        End If
    End Sub

    Private Sub txt_Duration_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Cmd_Add.Focus()
        End If
    End Sub
    Private Sub Cmd_Exit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        If MsgBox("TRANSACTION WILL NOT BE SAVED! QUIT WITHOUT SAVING", MsgBoxStyle.YesNo, "NOT SAVED ! QUIT") = MsgBoxResult.OK Then
            Me.Close()
        Else
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub Debit_Card_Transaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_BillNo.Text = Trim(KOT_NO_GBL)
        lbl_POSNAME.Text = POSNAME_GBL
        If D_CARDUPDATE = True Then
            Lbl_Dcard_Title.Text = Lbl_Dcard_Title.Text & "  [ AMENDMENTS ]  "
            Cmd_Add.Text = "UPDATE [ F7 ]"
        Else
            Lbl_Dcard_Title.Text = Lbl_Dcard_Title.Text
            Cmd_Add.Text = "SAVE [ F7 ]"
        End If
        Call txt_BillNo_Validated(sender, e)
    End Sub

    Private Sub txt_BillNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_BillNo.Validated
        'Dim sqlstring As String
        'Dim SQLSTRINGS As String
        'If txt_BillNo.Text = "" Then
        '    Exit Sub
        'End If
        'SQLSTRINGS = "SELECT * FROM KOT_HDR WHERE KOTDETAILS='" & Trim(txt_BillNo.Text) & "'"
        'gconnection.getDataSet(SQLSTRINGS, "KOT_HDR")
        'If gdataset.Tables("KOT_HDR").Rows.Count > 0 Then
        '    txt_Holder_Code.Text = gdataset.Tables("KOT_HDR").Rows(0).Item("CARDHOLDERCODE")
        '    Txt_holder_name.Text = gdataset.Tables("KOT_HDR").Rows(0).Item("CARDHOLDERNAME")
        '    txt_MemberCode.Text = gdataset.Tables("KOT_HDR").Rows(0).Item("MCODE")
        '    txt_MemberName.Text = gdataset.Tables("KOT_HDR").Rows(0).Item("MNAME")
        '    Lbl_Dcard_Title.Text = Lbl_Dcard_Title.Text & " AMENDMENTS"
        '    Cmd_Add.Text = "Update[F7]"
        'End If


        Dim sqlstring As String
        Dim SQLSTRINGS As String
        If txt_BillNo.Text = "" Then
            Exit Sub
        End If
        SQLSTRINGS = "SELECT * FROM KOT_HDR WHERE KOTDETAILS='" & Trim(txt_BillNo.Text) & "'"
        gconnection.getDataSet(SQLSTRINGS, "KOT_HDR")

        If gdataset.Tables("KOT_HDR").Rows.Count > 0 Then
            txt_Holder_Code.Text = gdataset.Tables("KOT_HDR").Rows(0).Item("CARDHOLDERCODE")
            Txt_holder_name.Text = gdataset.Tables("KOT_HDR").Rows(0).Item("CARDHOLDERNAME")
            txt_MemberCode.Text = gdataset.Tables("KOT_HDR").Rows(0).Item("MCODE")
            txt_MemberName.Text = gdataset.Tables("KOT_HDR").Rows(0).Item("MNAME")
        Else
            MsgBox("BILL DETAILS NOT AVALIABLE", MsgBoxStyle.Critical, "WRONG BILL NO")
            Exit Sub
        End If
        'SQLSTRINGS = "SELECT * FROM SM_POSTRANSACTION P INNER JOIN POSMASTER H ON P.POSCODE = H.POSCODE WHERE P.BILL_NO ='" & Trim(txt_BillNo.Text & "") & "' AND STORESTATUS = 'F'"
        'gconnection.getDataSet(SQLSTRINGS, "STORESTATUS")
        'If gdataset.Tables("STORESTATUS").Rows.Count > 0 Then
        'Else
        '    MsgBox("SORRY, FACILITIES TRANSACTIONS ONLY CAN BE MODIFIED...")
        '    Cmd_Add.Hide()
        '    Cmd_Exit.Show()
        '    txt_BillNo.Text = ""
        '    Txt_Mcode.Text = ""
        '    Txt_Mname.Text = ""
        '    txt_card_id.Clear()
        '    txt_card_id.Focus()
        '    Exit Sub
        'End If

        sqlstring = "SELECT P.CARDCODE,NAME,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION FROM SM_POSTRANSACTION P INNER JOIN SM_CARDFILE_HDR C ON P.CARDCODE = C.CARDCODE WHERE P.BILL_NO = '" & Trim(txt_BillNo.Text & "") & "'"
        'sqlstring = "SELECT CARDCODE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION FROM SM_POSTRANSACTION WHERE BILL_NO='" & Trim(txt_BillNo.Text & "") & "'"
        gconnection.getDataSet(sqlstring, "bill")
        If gdataset.Tables("bill").Rows.Count > 0 Then
            'KARTHI JUN 2
            'Txt_Mcode.Text = gdataset.Tables("bill").Rows(0).Item("cardcode")
            'Txt_Mname.Text = gdataset.Tables("bill").Rows(0).Item("name")
            Cmb_Validfrom.Value = gdataset.Tables("bill").Rows(0).Item("from_date")
            Cmb_Validto.Value = gdataset.Tables("bill").Rows(0).Item("to_date")
            Cmb_Duration.Value = gdataset.Tables("bill").Rows(0).Item("duration")
            Cmb_TimeFrom.Value = gdataset.Tables("bill").Rows(0).Item("from_time")
            Cmb_TimeTo.Value = gdataset.Tables("bill").Rows(0).Item("to_time")
            Cmd_Add.Text = "Update[F7]"
        End If

    End Sub

    Private Sub Cmb_Duration_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_Duration.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub Debit_Card_Transaction_NOR_NEED_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim strSQL As String
        Dim cc As New ManualBilling(POSNAME_GBL, StrPOSCODE)
        If Mid(Cmd_Add.Text, 1, 1) = "S" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            strSQL = " UPDATE SM_CARDFILE_HDR SET UPDATEUSER='" & Trim(gUsername) & "',UPDATEDATETIME='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "' WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "'"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(0) = strSQL

            'COPY CURRENT DATE AND TIME TO CARDFILEDET_ IMG
            strSQL = " DELETE FROM SM_CARDFILE_DET_IMG WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(1) = strSQL

            strSQL = " INSERT INTO sm_cardfile_det_IMG (CARDCODE, POSCODE, POS_ACCESS,POS_VALID_FROM, "
            strSQL = strSQL & " POS_VALID_TO, TIME_FROM, TIME_TO, DURATION) SELECT CARDCODE,POSCODE,POS_ACCESS,POS_VALID_FROM,POS_VALID_TO,TIME_FROM,TIME_TO,DURATION FROM SM_CARDFILE_DET "
            strSQL = strSQL & " WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(2) = strSQL


            'save duration as 12 hr format
            strSQL = " UPDATE SM_CARDFILE_DET SET POS_VALID_FROM='" & Format(Cmb_Validfrom.Value, "dd/MMM/yyyy") & "',POS_VALID_TO='" & Format(Cmb_Validto.Value, "dd/MMM/yyyy") & "',TIME_FROM='" & Format(Cmb_TimeFrom.Value, "HH:MM") & "', TIME_TO='" & Format(Cmb_TimeTo.Value, "HH:MM") & "',DURATION='" & Format(Cmb_Duration.Value, "hh:mm") & "', HOURLY_BILL=" & POS_RATE_GBL & ", PERIOD_TO_DATE_USAGE=" & POS_AMT_GBL & " WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(3) = strSQL
            Dim MABILL As New ManualBilling(DOCTYPE_GBL, POSCODE_GBL)


            strSQL = " INSERT INTO SM_POSTRANSACTION (CARDCODE,POSCODE,POSDATE,FROM_DATE,TO_DATE,FROM_TIME,TO_TIME,DURATION,BILL_NO,BILL_AMOUNT,ADDDATETIME,ADDUSERID,VOID,REMARKS) VALUES ( '" & Trim(txt_Holder_Code.Text) & "','" & StrPOSCODE & "','" & Format(MABILL.dtp_KOTdate.Value, "dd-MMM-yyyy") & "','" & Format(Cmb_Validfrom.Value, "dd/MMM/yyyy") & "','" & Format(Cmb_Validto.Value, "dd/MMM/yyyy") & "','" & Format(Cmb_TimeFrom.Value, "HH:MM") & "','" & Format(Cmb_TimeTo.Value, "HH:MM") & "','" & Format(Cmb_Duration.Value, "hh:mm") & "','" & KOT_NO_GBL & "'," & BILLAMT_GBL & ",'" & Format(Now, "dd/MMM/yyyy") & "','" & Trim(gUsername) & "','N','" & Trim(MABILL.Txt_Remarks.Text) & "')"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(4) = strSQL

            If PAYMENTMODE_GBL = "SMART CARD" Then
                strSQL = " UPDATE SM_CARDFILE_HDR SET BALANCE = BALANCE - " & BILLAMT_GBL & " WHERE CARDCODE='" & Trim(txt_Holder_Code.Text) & "'"
                ReDim Preserve INSERT(INSERT.Length)
                INSERT(5) = strSQL
            End If
            gconnection.MoreTrans(INSERT)
            'SMART CARD*******************************************************************
        Else ' for update
            strSQL = " UPDATE SM_CARDFILE_HDR SET UPDATEUSER='" & Trim(gUsername) & "',UPDATEDATETIME='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "' WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "'"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(0) = strSQL
            'ONLY STORE PREVOIUSE DATE VALKUES IN ADD NOT IN UPDATE

            ''COPY CURRENT DATE AND TIME TO CARDFILEDET_ IMG
            'strSQL = " DELETE FROM SM_CARDFILE_DET_IMG WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE=" & POSCODE_GBL
            'ReDim Preserve INSERT(INSERT.Length)
            'INSERT(1) = strSQL

            'strSQL = " INSERT INTO sm_cardfile_det_IMG (CARDCODE, POSCODE, POS_ACCESS,POS_VALID_FROM, "
            'strSQL = strSQL & " POS_VALID_TO, TIME_FROM, TIME_TO, DURATION) SELECT CARDCODE,POSCODE,POS_ACCESS,POS_VALID_FROM,POS_VALID_TO,TIME_FROM,TIME_TO,DURATION FROM SM_CARDFILE_DET "
            'strSQL = strSQL & " WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE=" & POSCODE_GBL
            'ReDim Preserve INSERT(INSERT.Length)
            'INSERT(2) = strSQL


            strSQL = " UPDATE SM_CARDFILE_DET SET POS_VALID_FROM='" & Format(Cmb_Validfrom.Value, "dd/MMM/yyyy") & "',POS_VALID_TO='" & Format(Cmb_Validto.Value, "dd/MMM/yyyy") & "',TIME_FROM='" & Format(Cmb_TimeFrom.Value, "HH:MM") & "', TIME_TO='" & Format(Cmb_TimeTo.Value, "HH:MM") & "',DURATION='" & Format(Cmb_Duration.Value, "hh:mm") & "', HOURLY_BILL=" & POS_RATE_GBL & ", PERIOD_TO_DATE_USAGE=" & POS_AMT_GBL & " WHERE CARDCODE = '" & Trim(txt_Holder_Code.Text) & "' AND POSCODE='" & StrPOSCODE & "'"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(2) = strSQL
            gconnection.MoreTrans(INSERT)
        End If
        PAYMENTMODE_GBL = ""
        MNAME_GBL = ""
        MCODE_GBL = ""
        cardcode = ""
        NAME_GBL = ""
        dc_trans_closed = True
        'cc.cmd_Clear_Click(sender, e)
        'DEC 11
        Dim objmanualbill As New ManualBilling(Trim(DOCTYPE_GBL), Trim(StrPOSCODE))
        Me.Close()
        objmanualbill.FormBorderStyle = FormBorderStyle.FixedDialog
        objmanualbill.MdiParent = MDIParentobj
        Me.Close()
        objmanualbill.Show()
        'DEC 11
    End Sub
End Class
