Public Class POSSETUPMASTER
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents Txt_BillPrefix As System.Windows.Forms.TextBox
    Friend WithEvents lbl_PaymentMode As System.Windows.Forms.Label
    Friend WithEvents Txt_PaymentMode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_BillPrefix As System.Windows.Forms.Label
    Friend WithEvents lbl_BillPrint As System.Windows.Forms.Label
    Friend WithEvents Cbo_BillPrint As System.Windows.Forms.ComboBox
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRoundoffacctin As System.Windows.Forms.TextBox
    Friend WithEvents cmdRoundoffacctin As System.Windows.Forms.Button
    Friend WithEvents txtRoundoffacctdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMB_ROUNDOFF As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMB_SETTLEMNT As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MSK_BILLDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXT_CREDITSTOP As System.Windows.Forms.TextBox
    Friend WithEvents TXT_DFAULTER As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(POSSETUPMASTER))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.Txt_BillPrefix = New System.Windows.Forms.TextBox
        Me.lbl_PaymentMode = New System.Windows.Forms.Label
        Me.Txt_PaymentMode = New System.Windows.Forms.TextBox
        Me.lbl_BillPrefix = New System.Windows.Forms.Label
        Me.lbl_BillPrint = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TXT_DFAULTER = New System.Windows.Forms.TextBox
        Me.MSK_BILLDATE = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.TXT_CREDITSTOP = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CMB_ROUNDOFF = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CMB_SETTLEMNT = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Cbo_BillPrint = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtRoundoffacctin = New System.Windows.Forms.TextBox
        Me.cmdRoundoffacctin = New System.Windows.Forms.Button
        Me.txtRoundoffacctdesc = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(376, 72)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(149, 31)
        Me.lbl_Heading.TabIndex = 4
        Me.lbl_Heading.Text = "POS SETUP "
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_BillPrefix
        '
        Me.Txt_BillPrefix.BackColor = System.Drawing.Color.Wheat
        Me.Txt_BillPrefix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_BillPrefix.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_BillPrefix.Location = New System.Drawing.Point(592, 224)
        Me.Txt_BillPrefix.MaxLength = 30
        Me.Txt_BillPrefix.Name = "Txt_BillPrefix"
        Me.Txt_BillPrefix.Size = New System.Drawing.Size(152, 26)
        Me.Txt_BillPrefix.TabIndex = 1
        Me.Txt_BillPrefix.Text = ""
        '
        'lbl_PaymentMode
        '
        Me.lbl_PaymentMode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PaymentMode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PaymentMode.ForeColor = System.Drawing.Color.Black
        Me.lbl_PaymentMode.Location = New System.Drawing.Point(196, 267)
        Me.lbl_PaymentMode.Name = "lbl_PaymentMode"
        Me.lbl_PaymentMode.Size = New System.Drawing.Size(395, 21)
        Me.lbl_PaymentMode.TabIndex = 8
        Me.lbl_PaymentMode.Text = "WHAT WILL BE YOUR DEFAULT PAYMENT MODE "
        Me.lbl_PaymentMode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Txt_PaymentMode
        '
        Me.Txt_PaymentMode.BackColor = System.Drawing.Color.White
        Me.Txt_PaymentMode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_PaymentMode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PaymentMode.Location = New System.Drawing.Point(592, 264)
        Me.Txt_PaymentMode.MaxLength = 9
        Me.Txt_PaymentMode.Name = "Txt_PaymentMode"
        Me.Txt_PaymentMode.Size = New System.Drawing.Size(152, 26)
        Me.Txt_PaymentMode.TabIndex = 2
        Me.Txt_PaymentMode.Text = ""
        '
        'lbl_BillPrefix
        '
        Me.lbl_BillPrefix.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillPrefix.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillPrefix.ForeColor = System.Drawing.Color.Black
        Me.lbl_BillPrefix.Location = New System.Drawing.Point(305, 227)
        Me.lbl_BillPrefix.Name = "lbl_BillPrefix"
        Me.lbl_BillPrefix.Size = New System.Drawing.Size(285, 21)
        Me.lbl_BillPrefix.TabIndex = 7
        Me.lbl_BillPrefix.Text = "WHAT WILL BE YOUR BILL PREFIX "
        Me.lbl_BillPrefix.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_BillPrint
        '
        Me.lbl_BillPrint.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillPrint.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillPrint.ForeColor = System.Drawing.Color.Black
        Me.lbl_BillPrint.Location = New System.Drawing.Point(203, 188)
        Me.lbl_BillPrint.Name = "lbl_BillPrint"
        Me.lbl_BillPrint.Size = New System.Drawing.Size(390, 21)
        Me.lbl_BillPrint.TabIndex = 6
        Me.lbl_BillPrint.Text = "DO YOU WANT TO PRINT HEADER IN BILL PRINT "
        Me.lbl_BillPrint.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 56)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(244, 17)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 4
        Me.Cmd_View.Text = " View[F9]"
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(358, 17)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 2
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TXT_DFAULTER)
        Me.GroupBox1.Controls.Add(Me.MSK_BILLDATE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_CREDITSTOP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CMB_ROUNDOFF)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CMB_SETTLEMNT)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(176, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 288)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'TXT_DFAULTER
        '
        Me.TXT_DFAULTER.BackColor = System.Drawing.Color.White
        Me.TXT_DFAULTER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_DFAULTER.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DFAULTER.Location = New System.Drawing.Point(416, 192)
        Me.TXT_DFAULTER.MaxLength = 9
        Me.TXT_DFAULTER.Name = "TXT_DFAULTER"
        Me.TXT_DFAULTER.Size = New System.Drawing.Size(152, 26)
        Me.TXT_DFAULTER.TabIndex = 2
        Me.TXT_DFAULTER.Text = ""
        '
        'MSK_BILLDATE
        '
        Me.MSK_BILLDATE.CustomFormat = "dd/MM/yyyy"
        Me.MSK_BILLDATE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSK_BILLDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MSK_BILLDATE.Location = New System.Drawing.Point(416, 232)
        Me.MSK_BILLDATE.Name = "MSK_BILLDATE"
        Me.MSK_BILLDATE.Size = New System.Drawing.Size(144, 26)
        Me.MSK_BILLDATE.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(283, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "DFAUlTER DAYS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TXT_CREDITSTOP
        '
        Me.TXT_CREDITSTOP.BackColor = System.Drawing.Color.White
        Me.TXT_CREDITSTOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CREDITSTOP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CREDITSTOP.Location = New System.Drawing.Point(416, 152)
        Me.TXT_CREDITSTOP.MaxLength = 9
        Me.TXT_CREDITSTOP.Name = "TXT_CREDITSTOP"
        Me.TXT_CREDITSTOP.Size = New System.Drawing.Size(152, 26)
        Me.TXT_CREDITSTOP.TabIndex = 31
        Me.TXT_CREDITSTOP.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(258, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "CREDITSTOP_DAYS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(288, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 21)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "SETTLEMENT:"
        Me.Label2.Visible = False
        '
        'CMB_ROUNDOFF
        '
        Me.CMB_ROUNDOFF.BackColor = System.Drawing.Color.Wheat
        Me.CMB_ROUNDOFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_ROUNDOFF.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_ROUNDOFF.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMB_ROUNDOFF.Location = New System.Drawing.Point(184, 336)
        Me.CMB_ROUNDOFF.Name = "CMB_ROUNDOFF"
        Me.CMB_ROUNDOFF.Size = New System.Drawing.Size(96, 27)
        Me.CMB_ROUNDOFF.TabIndex = 28
        Me.CMB_ROUNDOFF.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 21)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "BILL  ROUNDOF (Y/N)"
        Me.Label1.Visible = False
        '
        'CMB_SETTLEMNT
        '
        Me.CMB_SETTLEMNT.BackColor = System.Drawing.Color.Wheat
        Me.CMB_SETTLEMNT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_SETTLEMNT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_SETTLEMNT.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMB_SETTLEMNT.Location = New System.Drawing.Point(408, 336)
        Me.CMB_SETTLEMNT.Name = "CMB_SETTLEMNT"
        Me.CMB_SETTLEMNT.Size = New System.Drawing.Size(160, 27)
        Me.CMB_SETTLEMNT.TabIndex = 28
        Me.CMB_SETTLEMNT.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(285, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 21)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "LAST BILLDATE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Cbo_BillPrint
        '
        Me.Cbo_BillPrint.BackColor = System.Drawing.Color.Wheat
        Me.Cbo_BillPrint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_BillPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_BillPrint.Items.AddRange(New Object() {"YES", "NO"})
        Me.Cbo_BillPrint.Location = New System.Drawing.Point(592, 184)
        Me.Cbo_BillPrint.Name = "Cbo_BillPrint"
        Me.Cbo_BillPrint.Size = New System.Drawing.Size(152, 27)
        Me.Cbo_BillPrint.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(184, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 21)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "ROUND OFF ACCT IN :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label6.Visible = False
        '
        'txtRoundoffacctin
        '
        Me.txtRoundoffacctin.BackColor = System.Drawing.Color.White
        Me.txtRoundoffacctin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoundoffacctin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoundoffacctin.Location = New System.Drawing.Point(360, 432)
        Me.txtRoundoffacctin.MaxLength = 10
        Me.txtRoundoffacctin.Name = "txtRoundoffacctin"
        Me.txtRoundoffacctin.Size = New System.Drawing.Size(96, 26)
        Me.txtRoundoffacctin.TabIndex = 26
        Me.txtRoundoffacctin.Text = ""
        Me.txtRoundoffacctin.Visible = False
        '
        'cmdRoundoffacctin
        '
        Me.cmdRoundoffacctin.Image = CType(resources.GetObject("cmdRoundoffacctin.Image"), System.Drawing.Image)
        Me.cmdRoundoffacctin.Location = New System.Drawing.Point(456, 432)
        Me.cmdRoundoffacctin.Name = "cmdRoundoffacctin"
        Me.cmdRoundoffacctin.Size = New System.Drawing.Size(23, 26)
        Me.cmdRoundoffacctin.TabIndex = 28
        Me.cmdRoundoffacctin.Visible = False
        '
        'txtRoundoffacctdesc
        '
        Me.txtRoundoffacctdesc.BackColor = System.Drawing.Color.White
        Me.txtRoundoffacctdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRoundoffacctdesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoundoffacctdesc.Location = New System.Drawing.Point(552, 432)
        Me.txtRoundoffacctdesc.MaxLength = 35
        Me.txtRoundoffacctdesc.Name = "txtRoundoffacctdesc"
        Me.txtRoundoffacctdesc.ReadOnly = True
        Me.txtRoundoffacctdesc.Size = New System.Drawing.Size(192, 26)
        Me.txtRoundoffacctdesc.TabIndex = 29
        Me.txtRoundoffacctdesc.Text = ""
        Me.txtRoundoffacctdesc.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(272, 648)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(383, 18)
        Me.Label7.TabIndex = 418
        Me.Label7.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'POSSETUPMASTER
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(910, 692)
        Me.ControlBox = False
        Me.Controls.Add(Me.Txt_PaymentMode)
        Me.Controls.Add(Me.Cbo_BillPrint)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRoundoffacctin)
        Me.Controls.Add(Me.txtRoundoffacctdesc)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.Txt_BillPrefix)
        Me.Controls.Add(Me.lbl_PaymentMode)
        Me.Controls.Add(Me.lbl_BillPrefix)
        Me.Controls.Add(Me.lbl_BillPrint)
        Me.Controls.Add(Me.cmdRoundoffacctin)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "POSSETUPMASTER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS SETUP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim vseqno As Double
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Private Sub POSSETUPMASTER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cbo_BillPrint.SelectedIndex = 0
        Cbo_BillPrint.Focus()
        Cmd_Add.Enabled = True
        Call addActivation()
        GroupMasterbool = True
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
        Me.Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
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
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Txt_BillPrefix.Text = ""
        Txt_PaymentMode.Text = ""
        txtRoundoffacctin.Text = ""
        txtRoundoffacctdesc.Text = ""
        TXT_DFAULTER.Text = ""
        TXT_CREDITSTOP.Text = ""
        MSK_BILLDATE.Value = Format(Now(), "dd/MM/yyyy")
        Cbo_BillPrint.SelectedIndex = 0
        Cmd_Add.Enabled = True
        Call addActivation()
        Cmd_Add.Text = "Add [F7]"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Cbo_BillPrint.Focus()
    End Sub
    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            sqlstring = " INSERT INTO POSSETUP (BillPreFix,BillPaymentmode,BillPrintHeader,Roundacctin,Roundacctdesc,BILLROUNDOFF,SETTLEMENT,AddUserId,Adddatetime)"
            sqlstring = sqlstring & " VALUES ( '" & Trim(Txt_BillPrefix.Text) & "','" & Trim(Txt_PaymentMode.Text) & "',"
            sqlstring = sqlstring & " '" & Trim(Cbo_BillPrint.Text) & "',"
            sqlstring = sqlstring & " '" & Trim(txtRoundoffacctin.Text) & "','" & Trim(txtRoundoffacctdesc.Text) & "',"
            sqlstring = sqlstring & " '" & Trim(CMB_ROUNDOFF.Text) & "',"
            sqlstring = sqlstring & " '" & Trim(CMB_SETTLEMNT.Text) & "',"
            sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
            gconnection.dataOperation(1, sqlstring, "POSSETUP")
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            sqlstring = "UPDATE  POSSETUP "
            sqlstring = sqlstring & " SET BillPreFix='" & Trim(Txt_BillPrefix.Text) & "',"
            sqlstring = sqlstring & " BillPaymentmode='" & Trim(Txt_PaymentMode.Text) & "',"
            sqlstring = sqlstring & " BillPrintHeader='" & Trim(Cbo_BillPrint.Text) & "',"
            '            sqlstring = sqlstring & " BILLROUNDOFF='" & Trim(CMB_ROUNDOFF.Text) & "',"
            sqlstring = sqlstring & " BILLDATE ='" & Format(MSK_BILLDATE.Value, "dd/MMM/yyyy") & "',"
            sqlstring = sqlstring & " DEFAULTER =" & Format(Val(TXT_DFAULTER.Text), "0") & ","
            sqlstring = sqlstring & " CREDITSTOP =" & Format(Val(TXT_CREDITSTOP.Text), "0") & ","
            'sqlstring = sqlstring & " Roundacctin = '" & Trim(txtRoundoffacctin.Text) & "',Roundacctdesc = '" & Trim(txtRoundoffacctdesc.Text) & "',"
            sqlstring = sqlstring & " AddUserId = '" & Trim(gUsername) & "',Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            gconnection.dataOperation(2, sqlstring, "POSSETUP")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Txt_BillPrefix_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_BillPrefix.KeyPress
        Call getCharater(e)
        If Asc(e.KeyChar) = Keys.Enter Then
            Txt_PaymentMode.Focus()
        End If
    End Sub

    Private Sub Cbo_BillPrint_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbo_BillPrint.KeyPress
        'Call Blank(e)
        If Asc(e.KeyChar) = Keys.Enter Then
            Txt_BillPrefix.Focus()
        End If
    End Sub
    Private Sub Txt_PaymentMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PaymentMode.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtRoundoffacctin.Enabled <> True Then
                TXT_CREDITSTOP.Focus()
            Else
                txtRoundoffacctin.Focus()
            End If
        End If
    End Sub

    Private Sub POSSETUPMASTER_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        GroupMasterbool = False
    End Sub

    Private Sub POSSETUPMASTER_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
            Exit Sub
        End If
        'If e.KeyCode = Keys.F7 Then
        '    Call Cmd_Add_Click(Cmd_Add, e)
        '    Exit Sub
        'End If
        'If e.KeyCode = Keys.F9 Then
        '    Call Cmd_View_Click(Cmd_View, e)
        '    Exit Sub
        'End If
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
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Try
            sqlstring = "SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(CREDITSTOP,0) AS CREDITSTOP,ISNULL(DEFAULTER,0) AS DEFAULTER,ISNULL(BillPrintHeader,'') AS BillPrintHeader,ISNULL(BillPreFix,'') AS BillPreFix,"
            sqlstring = sqlstring & "ISNULL(BillPaymentmode,'') AS BillPaymentmode,ISNULL(Roundacctin,'') AS Roundacctin,ISNULL(Roundacctdesc,'') AS Roundacctdesc FROM POSSETUP "
            gconnection.getDataSet(sqlstring, "POSSETUP")
            If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                Cbo_BillPrint.Text = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPrintHeader"))
                Txt_BillPrefix.Text = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPreFix"))
                Txt_PaymentMode.Text = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPaymentmode"))
                txtRoundoffacctin.Text = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("Roundacctin"))
                txtRoundoffacctdesc.Text = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("Roundacctdesc"))
                TXT_DFAULTER.Text = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("DEFAULTER"))
                TXT_CREDITSTOP.Text = Trim(gdataset.Tables("POSSETUP").Rows(0).Item("CREDITSTOP"))
                MSK_BILLDATE.Value = Format(gdataset.Tables("POSSETUP").Rows(0).Item("BILLDATE"), "dd/MM/yyyy")
                If Format(MSK_BILLDATE.Value, "dd/MM/yyyy") = "01/01/1900" Then
                    MSK_BILLDATE.Value = Format(Now(), "dd/MM/yyyy")
                End If
                Me.Cmd_Add.Text = "Update[F7]"
                Me.Cmd_Add.Enabled = True
                If Trim(gdataset.Tables("POSSETUP").Rows(0).Item("Roundacctin")) <> "" Then
                    Me.txtRoundoffacctin.Enabled = False
                    Me.txtRoundoffacctdesc.Enabled = False
                    Me.cmdRoundoffacctin.Enabled = False
                Else
                    Me.txtRoundoffacctin.Enabled = True
                    Me.txtRoundoffacctdesc.Enabled = True
                    Me.cmdRoundoffacctin.Enabled = True
                End If
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
                Cbo_BillPrint.Focus()
            Else
                MessageBox.Show("!!! ACTIVATE  !!!Till Now POS SETUP is not yet activated ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Cbo_BillPrint.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Bill Header Print Can't be blank *********************'''
        If Trim(Cbo_BillPrint.Text) = "" Then
            MessageBox.Show("Bill Header Print can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cbo_BillPrint.Focus()
            Exit Sub
        End If
        '''********** Check  Bill Prefix Can't be blank *********************'''
        If Trim(Txt_BillPrefix.Text) = "" Then
            MessageBox.Show("Bill Prefix can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_BillPrefix.Focus()
            Exit Sub
        End If
        '''********** Check  Bill Default PaymentMode Can't be blank *********************'''
        If Trim(Txt_PaymentMode.Text) = "" Then
            MessageBox.Show("Bill Default PaymentMode can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_PaymentMode.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub
    Public Sub addActivation()
        sqlstring = "SELECT ISNULL(BillPrintHeader,'') AS BillPrintHeader,ISNULL(BillPreFix,'') AS BillPreFix,ISNULL(BILLROUNDOFF,'') AS BILLROUNDOFF,"
        sqlstring = sqlstring & "ISNULL(BillPaymentmode,'') AS BillPaymentmode,ISNULL(Roundacctin,'') AS Roundacctin,ISNULL(Roundacctdesc,'') AS Roundacctdesc FROM POSSETUP "
        gconnection.getDataSet(sqlstring, "POSSETUP")
        If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
            txtRoundoffacctin.Enabled = False
            txtRoundoffacctdesc.Enabled = False
            cmdRoundoffacctin.Enabled = False
            Cmd_Add.Enabled = True
            Exit Sub
        Else
            txtRoundoffacctin.Enabled = True
            txtRoundoffacctdesc.Enabled = True
            cmdRoundoffacctin.Enabled = True
            Cmd_Add.Enabled = True
            Exit Sub
        End If
    End Sub
    Private Sub cmdRoundoffacctin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRoundoffacctin.Click
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
            txtRoundoffacctin.Text = Trim(vform.keyfield & "")
            Call txtRoundoffacctin_Validated(txtRoundoffacctin, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txtRoundoffacctin_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRoundoffacctin.Validated
        If Trim(txtRoundoffacctin.Text) <> "" Then
            sqlstring = "SELECT acdesc  FROM Accountsglaccountmaster WHERE accode='" & Trim(txtRoundoffacctin.Text) & "'"
            gconnection.getDataSet(sqlstring, "Accountsglaccountmaster")
            If gdataset.Tables("Accountsglaccountmaster").Rows.Count > 0 Then
                txtRoundoffacctdesc.Text = ""
                txtRoundoffacctdesc.Text = Trim(gdataset.Tables("Accountsglaccountmaster").Rows(0).Item("acdesc"))
                txtRoundoffacctdesc.ReadOnly = True
                Cmd_Add.Focus()
            Else
                txtRoundoffacctin.Clear()
                txtRoundoffacctdesc.Clear()
                txtRoundoffacctin.Focus()
            End If
        Else
            txtRoundoffacctin.Clear()
            txtRoundoffacctdesc.Clear()
        End If
    End Sub

    Private Sub txtRoundoffacctin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRoundoffacctin.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(txtRoundoffacctin.Text)
            Call cmdRoundoffacctin_Click(sender, e)
        End If
    End Sub
    Private Sub txtRoundoffacctin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRoundoffacctin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtRoundoffacctin.Text) = "" Then
                Call cmdRoundoffacctin_Click(sender, e)
            Else
                Call txtRoundoffacctin_Validated(sender, e)
                Cmd_Add.Focus()
            End If
        End If
    End Sub

    Private Sub Txt_PaymentMode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_PaymentMode.TextChanged

    End Sub

    Private Sub TXT_CREDITSTOP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CREDITSTOP.TextChanged

    End Sub
    Private Sub TXT_CREDITSTOP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CREDITSTOP.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = Keys.Enter Then
            TXT_DFAULTER.Focus()
        End If
    End Sub
    Private Sub TXT_DFAULTER_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DFAULTER.TextChanged

    End Sub
    Private Sub TXT_DFAULTER_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_DFAULTER.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = Keys.Enter Then
            MSK_BILLDATE.Focus()
        End If
    End Sub
    Private Sub MSK_BILLDATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MSK_BILLDATE.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Cmd_Add.Focus()
        End If
    End Sub
End Class
