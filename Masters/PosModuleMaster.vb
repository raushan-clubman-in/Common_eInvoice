Public Class PosModuleMaster
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbockot As System.Windows.Forms.ComboBox
    Friend WithEvents txtKPrifix As System.Windows.Forms.TextBox
    Friend WithEvents cboprint As System.Windows.Forms.ComboBox
    Friend WithEvents cbokno As System.Windows.Forms.ComboBox
    Friend WithEvents cboCbill As System.Windows.Forms.ComboBox
    Friend WithEvents txtBPrifix As System.Windows.Forms.TextBox
    Friend WithEvents txtBAuto As System.Windows.Forms.TextBox
    Friend WithEvents txtKAuto As System.Windows.Forms.TextBox
    Friend WithEvents cboBprint As System.Windows.Forms.ComboBox
    Friend WithEvents cboRoff As System.Windows.Forms.ComboBox
    Friend WithEvents cboBNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtCROprifix As System.Windows.Forms.TextBox
    Friend WithEvents cboCRObno As System.Windows.Forms.ComboBox
    Friend WithEvents txtCROauto As System.Windows.Forms.TextBox
    Friend WithEvents cboClimit As System.Windows.Forms.ComboBox
    Friend WithEvents txtClimit As System.Windows.Forms.TextBox
    Friend WithEvents cboGroom As System.Windows.Forms.ComboBox
    Friend WithEvents cboPar As System.Windows.Forms.ComboBox
    Friend WithEvents cboAcc As System.Windows.Forms.ComboBox
    Friend WithEvents cboinv As System.Windows.Forms.ComboBox
    Friend WithEvents cboMem As System.Windows.Forms.ComboBox
    Friend WithEvents lblK_PREFIIX As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PosModuleMaster))
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdView = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbockot = New System.Windows.Forms.ComboBox
        Me.lblK_PREFIIX = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtKPrifix = New System.Windows.Forms.TextBox
        Me.cboprint = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtKAuto = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbokno = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cboBprint = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboCbill = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtBPrifix = New System.Windows.Forms.TextBox
        Me.cboRoff = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBAuto = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboBNo = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtCROprifix = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCROauto = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cboCRObno = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtClimit = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cboClimit = New System.Windows.Forms.ComboBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cboGroom = New System.Windows.Forms.ComboBox
        Me.cboPar = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cboAcc = New System.Windows.Forms.ComboBox
        Me.cboinv = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.cboMem = New System.Windows.Forms.ComboBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 728)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(383, 18)
        Me.Label3.TabIndex = 441
        Me.Label3.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.CmdAdd)
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Location = New System.Drawing.Point(163, 664)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 56)
        Me.GroupBox2.TabIndex = 427
        Me.GroupBox2.TabStop = False
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(352, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 3
        Me.CmdView.Text = " View[F9]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(16, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 0
        Me.CmdClear.Text = "Clear[F6]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(464, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 4
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdAdd
        '
        Me.CmdAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.ForeColor = System.Drawing.Color.White
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.Location = New System.Drawing.Point(128, 16)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(104, 32)
        Me.CmdAdd.TabIndex = 1
        Me.CmdAdd.Text = "Add [F7]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(240, 16)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 2
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(248, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(292, 31)
        Me.Label16.TabIndex = 428
        Me.Label16.Text = "POS  MODULE MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbockot)
        Me.GroupBox1.Controls.Add(Me.lblK_PREFIIX)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKPrifix)
        Me.GroupBox1.Controls.Add(Me.cboprint)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtKAuto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbokno)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 150)
        Me.GroupBox1.TabIndex = 429
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 21)
        Me.Label2.TabIndex = 443
        Me.Label2.Text = "KOT NUMBER :"
        '
        'cbockot
        '
        Me.cbockot.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbockot.Location = New System.Drawing.Point(216, 16)
        Me.cbockot.Name = "cbockot"
        Me.cbockot.Size = New System.Drawing.Size(144, 21)
        Me.cbockot.TabIndex = 439
        '
        'lblK_PREFIIX
        '
        Me.lblK_PREFIIX.AutoSize = True
        Me.lblK_PREFIIX.BackColor = System.Drawing.Color.Transparent
        Me.lblK_PREFIIX.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblK_PREFIIX.ForeColor = System.Drawing.Color.Black
        Me.lblK_PREFIIX.Location = New System.Drawing.Point(408, 16)
        Me.lblK_PREFIIX.Name = "lblK_PREFIIX"
        Me.lblK_PREFIIX.Size = New System.Drawing.Size(80, 21)
        Me.lblK_PREFIIX.TabIndex = 442
        Me.lblK_PREFIIX.Text = " PREFIX  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 21)
        Me.Label1.TabIndex = 441
        Me.Label1.Text = "CENTRALIZED KOT :"
        '
        'txtKPrifix
        '
        Me.txtKPrifix.BackColor = System.Drawing.Color.Wheat
        Me.txtKPrifix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKPrifix.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKPrifix.Location = New System.Drawing.Point(504, 16)
        Me.txtKPrifix.MaxLength = 50
        Me.txtKPrifix.Name = "txtKPrifix"
        Me.txtKPrifix.Size = New System.Drawing.Size(176, 26)
        Me.txtKPrifix.TabIndex = 440
        Me.txtKPrifix.Text = ""
        '
        'cboprint
        '
        Me.cboprint.Items.AddRange(New Object() {"KITCHEN WISE", "POS WISE"})
        Me.cboprint.Location = New System.Drawing.Point(216, 104)
        Me.cboprint.Name = "cboprint"
        Me.cboprint.Size = New System.Drawing.Size(144, 21)
        Me.cboprint.TabIndex = 438
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(96, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 21)
        Me.Label6.TabIndex = 437
        Me.Label6.Text = "KOT PRINT  :"
        '
        'txtKAuto
        '
        Me.txtKAuto.BackColor = System.Drawing.Color.Wheat
        Me.txtKAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKAuto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKAuto.Location = New System.Drawing.Point(504, 64)
        Me.txtKAuto.MaxLength = 50
        Me.txtKAuto.Name = "txtKAuto"
        Me.txtKAuto.Size = New System.Drawing.Size(176, 26)
        Me.txtKAuto.TabIndex = 436
        Me.txtKAuto.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(424, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 21)
        Me.Label4.TabIndex = 435
        Me.Label4.Text = " AUTO :"
        '
        'cbokno
        '
        Me.cbokno.Items.AddRange(New Object() {"AUTO", "MANUAL"})
        Me.cbokno.Location = New System.Drawing.Point(216, 64)
        Me.cbokno.Name = "cbokno"
        Me.cbokno.Size = New System.Drawing.Size(144, 21)
        Me.cbokno.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cboBprint)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cboCbill)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtBPrifix)
        Me.GroupBox3.Controls.Add(Me.cboRoff)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtBAuto)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cboBNo)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 216)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(728, 176)
        Me.GroupBox3.TabIndex = 442
        Me.GroupBox3.TabStop = False
        '
        'cboBprint
        '
        Me.cboBprint.Items.AddRange(New Object() {"TAXABLE/NONTAXABLE", "BOTH"})
        Me.cboBprint.Location = New System.Drawing.Point(240, 136)
        Me.cboBprint.Name = "cboBprint"
        Me.cboBprint.Size = New System.Drawing.Size(144, 21)
        Me.cboBprint.TabIndex = 445
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(120, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 21)
        Me.Label11.TabIndex = 444
        Me.Label11.Text = "BILL PRINT  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 21)
        Me.Label5.TabIndex = 443
        Me.Label5.Text = "BILL NUMBER :"
        '
        'cboCbill
        '
        Me.cboCbill.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboCbill.Location = New System.Drawing.Point(240, 16)
        Me.cboCbill.Name = "cboCbill"
        Me.cboCbill.Size = New System.Drawing.Size(144, 21)
        Me.cboCbill.TabIndex = 439
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(424, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 442
        Me.Label7.Text = " PREFIX  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 21)
        Me.Label8.TabIndex = 441
        Me.Label8.Text = "CENTRALIZED BILL :"
        '
        'txtBPrifix
        '
        Me.txtBPrifix.BackColor = System.Drawing.Color.Wheat
        Me.txtBPrifix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBPrifix.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBPrifix.Location = New System.Drawing.Point(528, 16)
        Me.txtBPrifix.MaxLength = 50
        Me.txtBPrifix.Name = "txtBPrifix"
        Me.txtBPrifix.Size = New System.Drawing.Size(176, 26)
        Me.txtBPrifix.TabIndex = 440
        Me.txtBPrifix.Text = ""
        '
        'cboRoff
        '
        Me.cboRoff.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboRoff.Location = New System.Drawing.Point(240, 96)
        Me.cboRoff.Name = "cboRoff"
        Me.cboRoff.Size = New System.Drawing.Size(144, 21)
        Me.cboRoff.TabIndex = 438
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 21)
        Me.Label9.TabIndex = 437
        Me.Label9.Text = "ROUND OFF (ONE RUPEE)  :"
        '
        'txtBAuto
        '
        Me.txtBAuto.BackColor = System.Drawing.Color.Wheat
        Me.txtBAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBAuto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBAuto.Location = New System.Drawing.Point(528, 64)
        Me.txtBAuto.MaxLength = 50
        Me.txtBAuto.Name = "txtBAuto"
        Me.txtBAuto.Size = New System.Drawing.Size(176, 26)
        Me.txtBAuto.TabIndex = 436
        Me.txtBAuto.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(432, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 21)
        Me.Label10.TabIndex = 435
        Me.Label10.Text = " AUTO  :"
        '
        'cboBNo
        '
        Me.cboBNo.Items.AddRange(New Object() {"AUTO", "MANUAL"})
        Me.cboBNo.Location = New System.Drawing.Point(240, 56)
        Me.cboBNo.Name = "cboBNo"
        Me.cboBNo.Size = New System.Drawing.Size(144, 21)
        Me.cboBNo.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtCROprifix)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtCROauto)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.cboCRObno)
        Me.GroupBox4.Location = New System.Drawing.Point(32, 400)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(728, 104)
        Me.GroupBox4.TabIndex = 443
        Me.GroupBox4.TabStop = False
        '
        'txtCROprifix
        '
        Me.txtCROprifix.BackColor = System.Drawing.Color.Wheat
        Me.txtCROprifix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCROprifix.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCROprifix.Location = New System.Drawing.Point(208, 16)
        Me.txtCROprifix.MaxLength = 50
        Me.txtCROprifix.Name = "txtCROprifix"
        Me.txtCROprifix.Size = New System.Drawing.Size(176, 26)
        Me.txtCROprifix.TabIndex = 444
        Me.txtCROprifix.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(72, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 21)
        Me.Label12.TabIndex = 443
        Me.Label12.Text = "BILL NUMBER  :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(128, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 21)
        Me.Label14.TabIndex = 441
        Me.Label14.Text = "PREFIX  :"
        '
        'txtCROauto
        '
        Me.txtCROauto.BackColor = System.Drawing.Color.Wheat
        Me.txtCROauto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCROauto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCROauto.Location = New System.Drawing.Point(496, 64)
        Me.txtCROauto.MaxLength = 50
        Me.txtCROauto.Name = "txtCROauto"
        Me.txtCROauto.Size = New System.Drawing.Size(176, 26)
        Me.txtCROauto.TabIndex = 436
        Me.txtCROauto.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(424, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 21)
        Me.Label17.TabIndex = 435
        Me.Label17.Text = " AUTO :"
        '
        'cboCRObno
        '
        Me.cboCRObno.Items.AddRange(New Object() {"AUTO", "MANUAL"})
        Me.cboCRObno.Location = New System.Drawing.Point(216, 64)
        Me.cboCRObno.Name = "cboCRObno"
        Me.cboCRObno.Size = New System.Drawing.Size(144, 21)
        Me.cboCRObno.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtClimit)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.cboClimit)
        Me.GroupBox5.Location = New System.Drawing.Point(32, 512)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(728, 48)
        Me.GroupBox5.TabIndex = 444
        Me.GroupBox5.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(72, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 21)
        Me.Label15.TabIndex = 441
        Me.Label15.Text = "CREDIT LIMIT  :"
        '
        'txtClimit
        '
        Me.txtClimit.BackColor = System.Drawing.Color.Wheat
        Me.txtClimit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClimit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClimit.Location = New System.Drawing.Point(600, 16)
        Me.txtClimit.MaxLength = 50
        Me.txtClimit.Name = "txtClimit"
        Me.txtClimit.Size = New System.Drawing.Size(120, 26)
        Me.txtClimit.TabIndex = 436
        Me.txtClimit.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(392, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(204, 21)
        Me.Label18.TabIndex = 435
        Me.Label18.Text = " CREDIT LIMIT AMOUNT :"
        '
        'cboClimit
        '
        Me.cboClimit.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboClimit.Location = New System.Drawing.Point(216, 16)
        Me.cboClimit.Name = "cboClimit"
        Me.cboClimit.Size = New System.Drawing.Size(144, 21)
        Me.cboClimit.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.cboGroom)
        Me.GroupBox6.Controls.Add(Me.cboPar)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.cboAcc)
        Me.GroupBox6.Controls.Add(Me.cboinv)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.cboMem)
        Me.GroupBox6.Location = New System.Drawing.Point(32, 560)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(920, 104)
        Me.GroupBox6.TabIndex = 445
        Me.GroupBox6.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(624, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(124, 21)
        Me.Label22.TabIndex = 449
        Me.Label22.Text = " GUEST ROOM :"
        '
        'cboGroom
        '
        Me.cboGroom.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboGroom.Location = New System.Drawing.Point(768, 16)
        Me.cboGroom.Name = "cboGroom"
        Me.cboGroom.Size = New System.Drawing.Size(144, 21)
        Me.cboGroom.TabIndex = 448
        '
        'cboPar
        '
        Me.cboPar.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboPar.Location = New System.Drawing.Point(448, 64)
        Me.cboPar.Name = "cboPar"
        Me.cboPar.Size = New System.Drawing.Size(144, 21)
        Me.cboPar.TabIndex = 447
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(328, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(105, 21)
        Me.Label21.TabIndex = 446
        Me.Label21.Text = " ACCOUNTS :"
        '
        'cboAcc
        '
        Me.cboAcc.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboAcc.Location = New System.Drawing.Point(448, 16)
        Me.cboAcc.Name = "cboAcc"
        Me.cboAcc.Size = New System.Drawing.Size(144, 21)
        Me.cboAcc.TabIndex = 445
        '
        'cboinv
        '
        Me.cboinv.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboinv.Location = New System.Drawing.Point(160, 16)
        Me.cboinv.Name = "cboinv"
        Me.cboinv.Size = New System.Drawing.Size(144, 21)
        Me.cboinv.TabIndex = 444
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(56, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 21)
        Me.Label13.TabIndex = 443
        Me.Label13.Text = "MEMBER  :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(40, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 21)
        Me.Label19.TabIndex = 441
        Me.Label19.Text = "INVENTORY  :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(360, 64)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 21)
        Me.Label20.TabIndex = 435
        Me.Label20.Text = " PARTY :"
        '
        'cboMem
        '
        Me.cboMem.Items.AddRange(New Object() {"YES", "NO"})
        Me.cboMem.Location = New System.Drawing.Point(160, 64)
        Me.cboMem.Name = "cboMem"
        Me.cboMem.Size = New System.Drawing.Size(144, 21)
        Me.cboMem.TabIndex = 1
        '
        'PosModuleMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(960, 742)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PosModuleMaster"
        Me.Text = "PosModuleMaster"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub PosModuleMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblK_PREFIIX.Visible = False
        Label4.Visible = False
        txtKPrifix.Visible = False
        txtKAuto.Visible = False
        txtBPrifix.Visible = False
        txtBAuto.Visible = False
        txtCROauto.Visible = False
        Label7.Visible = False
        Label10.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        txtClimit.Visible = False
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        txtKPrifix.Text = ""
        txtKAuto.Text = ""
        txtBPrifix.Text = ""
        txtBAuto.Text = ""
        txtCROprifix.Text = ""
        txtCROauto.Text = ""
        txtClimit.Text = ""
        cbockot.Text = ""
        cbokno.Text = ""
        cboprint.Text = ""
        cboCbill.Text = ""
        cboBNo.Text = ""
        cboRoff.Text = ""
        cboBprint.Text = ""
        cboCRObno.Text = ""
        cboClimit.Text = ""
        cboinv.Text = ""
        cboMem.Text = ""
        cboAcc.Text = ""
        cboGroom.Text = ""
        cboPar.Text = ""
        Call PosModuleMaster_Load(sender, e)
    End Sub

    Private Sub cbockot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbockot.SelectedIndexChanged
        If cbockot.Text = "YES" Then
            lblK_PREFIIX.Visible = True
            txtKPrifix.Visible = True
            txtKPrifix.Focus()
        ElseIf cbockot.Text = "NO" Or cbockot.Text = "" Then
            lblK_PREFIIX.Visible = False
            txtKPrifix.Visible = False
        End If

    End Sub

    Private Sub cbockot_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbockot.LostFocus
        If cbockot.Text = "YES" Then
            lblK_PREFIIX.Visible = True
            txtKPrifix.Visible = True
            txtKPrifix.Focus()
        ElseIf cbockot.Text = "NO" Or cbockot.Text = "" Then
            lblK_PREFIIX.Visible = False
            txtKPrifix.Visible = False
        End If

    End Sub

    Private Sub cbockot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbockot.KeyPress
        If cbockot.Text = "YES" Then
            lblK_PREFIIX.Visible = True
            txtKPrifix.Visible = True
            txtKPrifix.Focus()
        ElseIf cbockot.Text = "NO" Or cbockot.Text = "" Then
            lblK_PREFIIX.Visible = False
            txtKPrifix.Visible = False
        End If

    End Sub

    Private Sub cbokno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbokno.SelectedIndexChanged
        If cbokno.Text = "AUTO" Then
            Label4.Visible = True
            txtKAuto.Visible = True
            txtKAuto.Focus()
        ElseIf cbokno.Text = "MANUAL" Or cbokno.Text = "" Then
            Label4.Visible = False
            txtKAuto.Visible = False
        End If
    End Sub

    Private Sub cbokno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbokno.LostFocus
        If cbokno.Text = "AUTO" Then
            Label4.Visible = True
            txtKAuto.Visible = True
            txtKAuto.Focus()
        ElseIf cbokno.Text = "MANUAL" Or cbokno.Text = "" Then
            Label4.Visible = False
            txtKAuto.Visible = False
        End If
    End Sub

    Private Sub cbokno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbokno.KeyPress
        If cbokno.Text = "AUTO" Then
            Label4.Visible = True
            txtKAuto.Visible = True
            txtKAuto.Focus()
        ElseIf cbokno.Text = "MANUAL" Or cbokno.Text = "" Then
            Label4.Visible = False
            txtKAuto.Visible = False
        End If
    End Sub

    Private Sub cboprint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboprint.SelectedIndexChanged

    End Sub

    Private Sub cboprint_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboprint.LostFocus

    End Sub

    Private Sub cboprint_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboprint.KeyPress

    End Sub

    Private Sub cboCbill_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCbill.SelectedIndexChanged
        If cboCbill.Text = "YES" Then
            txtBPrifix.Visible = True
            Label7.Visible = True
            txtBPrifix.Focus()
        ElseIf cbockot.Text = "NO" Or cbockot.Text = "" Then
            txtBPrifix.Visible = False
            Label7.Visible = False
        End If


    End Sub

    Private Sub cboCbill_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCbill.LostFocus
        If cboCbill.Text = "YES" Then
            txtBPrifix.Visible = True
            Label7.Visible = True
            txtBPrifix.Focus()
        ElseIf cbockot.Text = "NO" Or cbockot.Text = "" Then
            txtBPrifix.Visible = False
            Label7.Visible = False
        End If
    End Sub

    Private Sub cboCbill_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCbill.KeyPress
        If cboCbill.Text = "YES" Then
            txtBPrifix.Visible = True
            Label7.Visible = True
            txtBPrifix.Focus()
        ElseIf cboCbill.Text = "NO" Or cboCbill.Text = "" Then
            txtBPrifix.Visible = False
            Label7.Visible = False
        End If
    End Sub

    Private Sub cboBNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBNo.SelectedIndexChanged
        If cboBNo.Text = "AUTO" Then
            Label10.Visible = True
            txtBAuto.Visible = True
            txtBAuto.Focus()
        ElseIf cboBNo.Text = "MANUAL" Or cboBNo.Text = "" Then
            Label10.Visible = False
            txtBAuto.Visible = False
        End If
    End Sub

    Private Sub cboBNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBNo.LostFocus
        If cboBNo.Text = "AUTO" Then
            Label10.Visible = True
            txtBAuto.Visible = True
            txtBAuto.Focus()
        ElseIf cboBNo.Text = "MANUAL" Or cboBNo.Text = "" Then
            Label10.Visible = False
            txtBAuto.Visible = False
        End If
    End Sub

    Private Sub cboBNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboBNo.KeyPress
        If cboBNo.Text = "AUTO" Then
            Label10.Visible = True
            txtBAuto.Visible = True
            txtBAuto.Focus()
        ElseIf cboBNo.Text = "MANUAL" Or cboBNo.Text = "" Then
            Label10.Visible = False
            txtBAuto.Visible = False
        End If
    End Sub

    Private Sub cboBprint_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBprint.SelectedIndexChanged

    End Sub

    Private Sub cboBprint_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBprint.LostFocus

    End Sub

    Private Sub cboBprint_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboBprint.KeyPress

    End Sub

    Private Sub cboCRObno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCRObno.SelectedIndexChanged
        If cboCRObno.Text = "AUTO" Then
            Label17.Visible = True
            txtCROauto.Visible = True
            txtCROauto.Focus()
        ElseIf cboCRObno.Text = "MANUAL" Or cboCRObno.Text = "" Then
            Label17.Visible = False
            txtCROauto.Visible = False
        End If
    End Sub

    Private Sub cboCRObno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCRObno.LostFocus
        If cboCRObno.Text = "AUTO" Then
            Label17.Visible = True
            txtCROauto.Visible = True
            txtCROauto.Focus()
        ElseIf cboCRObno.Text = "MANUAL" Or cboCRObno.Text = "" Then
            Label17.Visible = False
            txtCROauto.Visible = False
        End If

    End Sub

    Private Sub cboCRObno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCRObno.KeyPress
        If cboCRObno.Text = "AUTO" Then
            Label17.Visible = True
            txtCROauto.Visible = True
            txtCROauto.Focus()
        ElseIf cboCRObno.Text = "MANUAL" Or cboCRObno.Text = "" Then
            Label17.Visible = False
            txtCROauto.Visible = False
        End If

    End Sub

    Private Sub cboClimit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClimit.SelectedIndexChanged
        If cboClimit.Text = "YES" Then
            txtClimit.Visible = True
            Label18.Visible = True
            txtClimit.Focus()
        ElseIf cboClimit.Text = "NO" Or cboClimit.Text = "" Then
            txtClimit.Visible = False
            Label18.Visible = False
        End If
    End Sub

    Private Sub cboClimit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClimit.LostFocus
        If cboClimit.Text = "YES" Then
            txtClimit.Visible = True
            Label18.Visible = True
            txtClimit.Focus()
        ElseIf cboClimit.Text = "NO" Or cboClimit.Text = "" Then
            txtClimit.Visible = False
            Label18.Visible = False
        End If

    End Sub

    Private Sub cboClimit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboClimit.KeyPress
        If cboClimit.Text = "YES" Then
            txtClimit.Visible = True
            Label18.Visible = True
            txtClimit.Focus()
        ElseIf cboClimit.Text = "NO" Or cboClimit.Text = "" Then
            txtClimit.Visible = False
            Label18.Visible = False
        End If

    End Sub
End Class
