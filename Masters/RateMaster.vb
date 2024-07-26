Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.IO
Public Class RateMaster
    Inherits System.Windows.Forms.Form
    Dim vconn As New GlobalClass
    Dim ssql, vPOint, vGroup As String
    Dim i As Integer
    Dim boolmask As Boolean = False
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdDateHelp As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OptNearest As System.Windows.Forms.RadioButton
    Friend WithEvents OptNone As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OptPercentage As System.Windows.Forms.RadioButton
    Friend WithEvents OptValue As System.Windows.Forms.RadioButton
    Friend WithEvents txtChangeValue As System.Windows.Forms.TextBox
    Friend WithEvents LstGroup As System.Windows.Forms.CheckedListBox
    Friend WithEvents LstPOS As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmdRoundoff As System.Windows.Forms.Button
    Friend WithEvents cmdValueby As System.Windows.Forms.Button
    Friend WithEvents chkFreeze As System.Windows.Forms.CheckBox
    Friend WithEvents mskdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(RateMaster))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdDateHelp = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkFreeze = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdValueby = New System.Windows.Forms.Button
        Me.OptPercentage = New System.Windows.Forms.RadioButton
        Me.OptValue = New System.Windows.Forms.RadioButton
        Me.txtChangeValue = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdRoundoff = New System.Windows.Forms.Button
        Me.OptNearest = New System.Windows.Forms.RadioButton
        Me.OptNone = New System.Windows.Forms.RadioButton
        Me.LstGroup = New System.Windows.Forms.CheckedListBox
        Me.LstPOS = New System.Windows.Forms.CheckedListBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.mskdate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.ssGrid)
        Me.GroupBox4.Location = New System.Drawing.Point(72, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(888, 224)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'ssGrid
        '
        Me.ssGrid.ContainingControl = Me
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(8, 16)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(872, 200)
        Me.ssGrid.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(424, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(189, 31)
        Me.Label16.TabIndex = 324
        Me.Label16.Text = "RATE MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 21)
        Me.Label1.TabIndex = 298
        Me.Label1.Text = "WITH EFFECT FROM :"
        '
        'cmdDateHelp
        '
        Me.cmdDateHelp.Image = CType(resources.GetObject("cmdDateHelp.Image"), System.Drawing.Image)
        Me.cmdDateHelp.Location = New System.Drawing.Point(632, 56)
        Me.cmdDateHelp.Name = "cmdDateHelp"
        Me.cmdDateHelp.Size = New System.Drawing.Size(23, 22)
        Me.cmdDateHelp.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chkFreeze)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LstGroup)
        Me.GroupBox1.Controls.Add(Me.LstPOS)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(888, 240)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'chkFreeze
        '
        Me.chkFreeze.ForeColor = System.Drawing.Color.Maroon
        Me.chkFreeze.Location = New System.Drawing.Point(568, 16)
        Me.chkFreeze.Name = "chkFreeze"
        Me.chkFreeze.Size = New System.Drawing.Size(72, 24)
        Me.chkFreeze.TabIndex = 348
        Me.chkFreeze.Text = "FREEZE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdValueby)
        Me.GroupBox3.Controls.Add(Me.OptPercentage)
        Me.GroupBox3.Controls.Add(Me.OptValue)
        Me.GroupBox3.Controls.Add(Me.txtChangeValue)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(176, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 88)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CHANGE EFFECT IN"
        '
        'cmdValueby
        '
        Me.cmdValueby.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdValueby.ForeColor = System.Drawing.Color.Blue
        Me.cmdValueby.Location = New System.Drawing.Point(208, 16)
        Me.cmdValueby.Name = "cmdValueby"
        Me.cmdValueby.Size = New System.Drawing.Size(48, 40)
        Me.cmdValueby.TabIndex = 3
        Me.cmdValueby.Text = "Value Chg"
        '
        'OptPercentage
        '
        Me.OptPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptPercentage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptPercentage.Location = New System.Drawing.Point(10, 56)
        Me.OptPercentage.Name = "OptPercentage"
        Me.OptPercentage.Size = New System.Drawing.Size(102, 16)
        Me.OptPercentage.TabIndex = 2
        Me.OptPercentage.Text = "PERCENTAGE"
        '
        'OptValue
        '
        Me.OptValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptValue.Location = New System.Drawing.Point(10, 24)
        Me.OptValue.Name = "OptValue"
        Me.OptValue.Size = New System.Drawing.Size(80, 16)
        Me.OptValue.TabIndex = 1
        Me.OptValue.Text = "VALUE"
        '
        'txtChangeValue
        '
        Me.txtChangeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChangeValue.Location = New System.Drawing.Point(120, 56)
        Me.txtChangeValue.MaxLength = 10
        Me.txtChangeValue.Name = "txtChangeValue"
        Me.txtChangeValue.Size = New System.Drawing.Size(84, 21)
        Me.txtChangeValue.TabIndex = 3
        Me.txtChangeValue.Text = ""
        Me.txtChangeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdRoundoff)
        Me.GroupBox2.Controls.Add(Me.OptNearest)
        Me.GroupBox2.Controls.Add(Me.OptNone)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(568, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 83)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ROUNDED OFF"
        '
        'cmdRoundoff
        '
        Me.cmdRoundoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRoundoff.ForeColor = System.Drawing.Color.Blue
        Me.cmdRoundoff.Location = New System.Drawing.Point(192, 16)
        Me.cmdRoundoff.Name = "cmdRoundoff"
        Me.cmdRoundoff.Size = New System.Drawing.Size(56, 39)
        Me.cmdRoundoff.TabIndex = 2
        Me.cmdRoundoff.Text = "Round Off"
        '
        'OptNearest
        '
        Me.OptNearest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptNearest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNearest.Location = New System.Drawing.Point(24, 48)
        Me.OptNearest.Name = "OptNearest"
        Me.OptNearest.Size = New System.Drawing.Size(104, 16)
        Me.OptNearest.TabIndex = 2
        Me.OptNearest.Text = "NEAREST RS."
        '
        'OptNone
        '
        Me.OptNone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptNone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNone.Location = New System.Drawing.Point(24, 18)
        Me.OptNone.Name = "OptNone"
        Me.OptNone.Size = New System.Drawing.Size(88, 16)
        Me.OptNone.TabIndex = 1
        Me.OptNone.Text = "NONE"
        '
        'LstGroup
        '
        Me.LstGroup.BackColor = System.Drawing.Color.Wheat
        Me.LstGroup.Location = New System.Drawing.Point(568, 43)
        Me.LstGroup.Name = "LstGroup"
        Me.LstGroup.Size = New System.Drawing.Size(264, 100)
        Me.LstGroup.TabIndex = 3
        '
        'LstPOS
        '
        Me.LstPOS.BackColor = System.Drawing.Color.Wheat
        Me.LstPOS.Location = New System.Drawing.Point(176, 43)
        Me.LstPOS.Name = "LstPOS"
        Me.LstPOS.Size = New System.Drawing.Size(264, 100)
        Me.LstPOS.TabIndex = 2
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.Wheat
        Me.txtRate.Location = New System.Drawing.Point(176, 16)
        Me.txtRate.MaxLength = 20
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(264, 21)
        Me.txtRate.TabIndex = 1
        Me.txtRate.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(440, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 21)
        Me.Label4.TabIndex = 346
        Me.Label4.Text = "FOR GROUP :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 345
        Me.Label3.Text = "FOR POS :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 21)
        Me.Label7.TabIndex = 344
        Me.Label7.Text = "RATE CHARGE BY :"
        '
        'mskdate
        '
        Me.mskdate.CustomFormat = "dd/MMM/yyyy"
        Me.mskdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskdate.Location = New System.Drawing.Point(496, 56)
        Me.mskdate.Name = "mskdate"
        Me.mskdate.Size = New System.Drawing.Size(136, 22)
        Me.mskdate.TabIndex = 1
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(408, 576)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 335
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(224, 624)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 330
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(568, 624)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 333
        Me.CmdView.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(448, 624)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 332
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'CmdAdd
        '
        Me.CmdAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.ForeColor = System.Drawing.Color.White
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.Location = New System.Drawing.Point(336, 624)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(104, 32)
        Me.CmdAdd.TabIndex = 331
        Me.CmdAdd.Text = "Add [F7]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(680, 624)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 334
        Me.cmdexit.Text = "Exit[F11]"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Location = New System.Drawing.Point(208, 608)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(592, 56)
        Me.GroupBox5.TabIndex = 336
        Me.GroupBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(656, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 22)
        Me.Label2.TabIndex = 337
        Me.Label2.Text = "[F4]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 18)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'RateMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 670)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.mskdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdDateHelp)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "RateMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RATE MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub RateMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillPOS()
        Call FillGroup()
        Call FillItems()
        OptNone.Checked = True
        OptValue.Checked = True
        RateMastbool = True
        mskdate.Focus()
        CmdAdd.Text = "Update[F7]"
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
        Me.CmdAdd.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        CmdView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdAdd.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.CmdView.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.CmdAdd.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.CmdAdd.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.CmdAdd.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub ClearOperation()
        ssGrid.ClearRange(1, 1, -1, -1, True)
        OptNone.Checked = True
        OptValue.Checked = True
        LstPOS.Items.Clear()
        LstGroup.Items.Clear()
        txtRate.Text = ""
        txtChangeValue.Text = ""
        txtChangeValue.MaxLength = 10
        txtRate.MaxLength = 50
        CmdAdd.Text = "Update[F7]"
        Call FillPOS()
        Call FillGroup()
        Call FillItems()
        mskdate.Focus()
    End Sub
    Private Sub FillItems()
        ssql = " SELECT I.ITEMCODE AS ITEMCODE ,I.ITEMDESC AS ITEMDESC,I.ITEMTYPECODE AS ITEMTYPECODE ,I.GROUPCODE AS GROUPCODE,"
        ssql = ssql & " R.UOM AS UOM,ISNULL(R.PURCAHSERATE,0) AS PURCAHSERATE ,R.ITEMRATE AS ITEMRATE,P.POS AS POS,R.STARTINGDATE AS STARTINGDATE"
        ssql = ssql & " FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE"
        ssql = ssql & " INNER JOIN POSMENULINK AS P ON I.ITEMCODE = P.ITEMCODE WHERE R.STARTINGDATE IN (SELECT MAX(STARTINGDATE) FROM RATEMASTER) AND ISNULL(R.ENDINGDATE,'') = ''"
        ssql = ssql & " GROUP BY I.ITEMCODE,I.ITEMDESC,I.ITEMTYPECODE,I.GROUPCODE,R.UOM,R.PURCAHSERATE,R.ITEMRATE,P.POS,R.STARTINGDATE  "
        ssql = ssql & " ORDER BY ITEMCODE,ITEMDESC"
        vconn.getDataSet(ssql, "ITEMMASTER")
        ssGrid.ClearRange(1, 1, -1, -1, True)
        If gdataset.Tables("ITEMMASTER").Rows.Count > 0 Then
            For i = 1 To gdataset.Tables("ITEMMASTER").Rows.Count
                If gdataset.Tables("ITEMMASTER").Rows.Count >= 500 Then
                    ssGrid.MaxRows = ssGrid.Row + 500
                End If
                With ssGrid
                    .Row = i
                    .Col = 1
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMCODE"))
                    .Col = 2
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMDESC"))
                    .Col = 3
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("UOM"))
                    .Col = 5
                    .Text = Format(Val(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("PURCAHSERATE")), "0.00")
                    .Col = 6
                    .Text = Format(Val(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMRATE")), "0.00")
                    .Col = 7
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMTYPECODE"))
                    .Col = 8
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("GROUPCODE"))
                    .Col = 9
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("POS"))
                End With
                mskdate.Value = Format(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("STARTINGDATE"), "dd/MMM/yyyy")
            Next
        End If
    End Sub
    Private Sub RateMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call ClearOperation()
        End If
        If e.KeyCode = Keys.F7 Then
            Call CmdAdd_Click(CmdAdd, e)
        End If
        If e.KeyCode = Keys.F9 Then

        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmdexit_Click(cmdexit, e)
        End If
        If e.KeyCode = Keys.F4 And boolmask = True Then
            Call cmdDateHelp_Click(sender, e)
        End If
    End Sub
    Private Sub FillPOS()
        LstGroup.Items.Clear()
        ssql = "SELECT POSCODE,POSSEQNO FROM POSMaster  WHERE ISNULL(Freeze,'') <> 'Y' ORDER BY POSCODE"
        vconn.getDataSet(ssql, "POSMASTER")
        If gdataset.Tables("POSMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POSMASTER").Rows.Count - 1
                With gdataset.Tables("POSMASTER").Rows(i)
                    LstPOS.Items.Add(Trim(.Item("POSCODE") & ""))
                End With
            Next i
        End If
    End Sub
    Private Sub FillGroup()
        LstGroup.Items.Clear()
        ssql = "SELECT GROUPCODE,GROUPSEQNO FROM GroupMaster  WHERE ISNULL(Freeze,'') <> 'Y' ORDER BY GROUPCODE"
        vconn.getDataSet(ssql, "GROUPMASTER")
        If gdataset.Tables("GROUPMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("GROUPMASTER").Rows.Count - 1
                With gdataset.Tables("GROUPMASTER").Rows(i)
                    LstGroup.Items.Add(Trim(.Item("GROUPCODE") & ""))
                End With
            Next i
        End If
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub cmdRoundoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRoundoff.Click
        'Dim vRoundoff As Double
        'If OptNearest.Checked = True Then
        '    If ssGrid.DataRowCnt = 0 Then Exit Sub
        '    For i = 1 To ssGrid.DataRowCnt
        '        ssGrid.Row = i
        '        ssGrid.Col = 6
        '        vRoundoff = Math.Ceiling(ssGrid.Text)
        '        ssGrid.SetText(6, i, Format(Val(vRoundoff), "0.00"))
        '    Next i
        'End If
    End Sub
    Private Sub txtChangeValue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtChangeValue.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            cmdValueby.Focus()
        End If
    End Sub
    Private Sub OptValue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OptValue.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtChangeValue.Text = ""
            txtChangeValue.MaxLength = 10
            txtChangeValue.Focus()
        End If
    End Sub
    Private Sub OptPercentage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OptPercentage.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtChangeValue.Text = ""
            txtChangeValue.Focus()
            txtChangeValue.MaxLength = 2
        End If
    End Sub
    Private Sub OptNone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OptNone.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmdRoundoff.Focus()
        End If
    End Sub
    Private Sub OptNearest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OptNearest.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmdRoundoff.Focus()
        End If
    End Sub
    Private Sub cmdValueby_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdValueby.Click
        Dim vRate
        If OptValue.Checked = True Then
            If Val(txtChangeValue.Text) > 0 Then
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Row = i
                    ssGrid.Col = 6
                    vRate = Val(ssGrid.Text)
                    vRate = Val(vRate) + Val(txtChangeValue.Text)
                    ssGrid.SetText(6, i, vRate)
                Next
            End If
        End If
        If OptPercentage.Checked = True Then
            If Val(txtChangeValue.Text) > 0 Then
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Row = i
                    ssGrid.Col = 6
                    vRate = Val(ssGrid.Text)
                    vRate = Val(vRate) + Val(vRate * (Val(txtChangeValue.Text) / 100))
                    ssGrid.SetText(6, i, vRate)
                Next
            End If
        End If
    End Sub
    Private Sub txtRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            LstPOS.Focus()
        End If
    End Sub
    Private Sub LstPOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstPOS.KeyPress
        If Asc(e.KeyChar) = 13 Then
            LstPOS_DoubleClick(LstPOS, e)
            LstGroup.Focus()
        End If
    End Sub
    Private Sub LstGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstGroup.KeyPress
        If Asc(e.KeyChar) = 13 Then
            LstGroup_DoubleClick(LstGroup, e)
            OptValue.Focus()
        End If
    End Sub
    Private Sub LstPOS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LstPOS.KeyDown
        Dim Loopindex As Integer
        If e.KeyCode = Keys.F2 Then
            For Loopindex = 0 To LstPOS.Items.Count - 1
                LstPOS.SetItemChecked(Loopindex, True)
            Next
        End If
        If e.KeyCode = Keys.F3 Then
            For Loopindex = 0 To LstPOS.Items.Count - 1
                LstPOS.SetItemChecked(Loopindex, False)
            Next
        End If
    End Sub
    Private Sub LstGroup_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LstGroup.KeyDown
        Dim Loopindex As Integer
        If e.KeyCode = Keys.F2 Then
            For Loopindex = 0 To LstPOS.Items.Count - 1
                LstGroup.SetItemChecked(Loopindex, True)
            Next
        End If
        If e.KeyCode = Keys.F3 Then
            For Loopindex = 0 To LstPOS.Items.Count - 1
                LstGroup.SetItemChecked(Loopindex, False)
            Next
        End If
    End Sub

    Private Sub cmdDateHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDateHelp.Click
        gSQLString = "SELECT DISTINCT CONVERT(DATETIME,Startingdate,103) AS STARTINGDATE FROM RateMaster "
        M_WhereCondition = " WHERE  ISNULL(Endingdate,'') = ''"
        Dim vform As New ListOperattion1
        vform.Field = "STARTINGDATE"
        vform.vFormatstring = "                       WITH EFFECT FROM                     "
        vform.vCaption = "RATE MASTER HELP"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            mskdate.Value = Format(CDate(vform.keyfield), "dd/MMM/yyyy")
            Call mskdate_Validated(mskdate, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Call ClearOperation()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim insert(0) As String
        Dim vDate, vUOM, vRate, vItem, vSeqno, vCode
        Dim GRate As Double
        Dim vCheck As String
        If chkFreeze.Checked = True Then
            vCheck = "Y"
        Else
            vCheck = "N"
        End If
        If Mid(CmdAdd.Text, 1, 1) = "U" Then
            For i = 1 To ssGrid.DataRowCnt
                ssGrid.Row = i
                ssGrid.Col = 1
                vCode = Trim(CStr(ssGrid.Text))
                ssGrid.Col = 3
                vUOM = Trim(CStr(ssGrid.Text))
                ssGrid.Col = 6
                vRate = Format(Val(ssGrid.Text), "0.00")
                ssql = "UPDATE RateMaster SET ITEMRATE = " & Val(vRate) & " , FREEZE= '" & Trim(vCheck) & "',STARTINGDATE = '" & Format(mskdate.Value, "dd-MMM-yyyy") & "'"
                ssql = ssql & " WHERE ItemCode='" & CStr(vCode) & "' AND UOM='" & Trim(vUOM) & "' AND ISNULL(Endingdate,'') = ''"
                ssql = ssql & " "
                If i = 1 Then
                    insert(insert.Length - 1) = ssql
                Else
                    ReDim Preserve insert(insert.Length)
                    insert(insert.Length - 1) = ssql
                End If
            Next
            'For i = 1 To ssGrid.DataRowCnt
            '    ssql = "INSERT INTO RateMaster(WitheffectFrom,ItemCode,ItemCodeseqno,UOM,Freeze,ItemRate,Startingdate) "
            '    ssql = ssql & " VALUES ("
            '    ssql = ssql & "'" & Format(mskdate.Value, "dd-MMM-yyyy") & "',"
            '    ssGrid.Col = 1
            '    ssGrid.Row = i
            '    ssql = ssql & "'" & Trim(ssGrid.Text) & "',"
            '    ssGrid.Col = 1
            '    ssGrid.Row = i
            '    vSeqno = GetSeqno(ssGrid.Text)
            '    ssql = ssql & "'" & vSeqno & "',"
            '    ssGrid.Col = 3
            '    ssGrid.Row = i
            '    ssql = ssql & "'" & Trim(ssGrid.Text) & "',"
            '    ssGrid.Col = 5
            '    ssGrid.Row = i
            '    ssql = ssql & "'N',"
            '    ssql = ssql & "" & Format(Val(ssGrid.Text), "0.00") & ","
            '    ssql = ssql & "'" & Format(mskdate.Value, "dd-MMM-yyyy") & "')"
            '    If i = 1 Then
            '        insert(insert.Length - 1) = ssql
            '    Else
            '        ReDim Preserve insert(insert.Length)
            '        insert(insert.Length - 1) = ssql
            '    End If
            'Next
        End If
        vconn.MORETRANSOLD(insert)
    End Sub
    Private Sub LstPOS_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstPOS.LostFocus
        Call LstPOS_SelectedValueChanged(LstPOS, e)
    End Sub
    Private Sub LstGroup_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstGroup.LostFocus
        Call LstGroup_SelectedValueChanged(LstGroup, e)
    End Sub
    Private Sub LstPOS_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstPOS.SelectedValueChanged

    End Sub
    Private Sub OptPercentage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptPercentage.Click
        txtChangeValue.Text = ""
        txtChangeValue.MaxLength = 2
    End Sub
    Private Sub OptValue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptValue.CheckedChanged
        txtChangeValue.Text = ""
        txtChangeValue.MaxLength = 10
    End Sub
    Private Sub LstGroup_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstGroup.SelectedValueChanged

    End Sub
    Private Sub mskDate_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxMSMask.MaskEdBoxEvents_KeyDownEvent)
        boolmask = True
    End Sub

    Private Sub RateMaster_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        RateMastbool = False
    End Sub

    Private Sub mskdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskdate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtRate.Focus()
        End If
    End Sub

    Private Sub LstGroup_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstGroup.DoubleClick
        Dim j As Integer
        vGroup = ""
        For j = 0 To LstGroup.Items.Count - 1
            If LstGroup.GetItemChecked(j) = True Then
                If Trim(vGroup) = "" Then
                    vGroup = " '" & LstGroup.Items.Item(j) & "'"
                Else
                    vGroup = vGroup & ",'" & LstGroup.Items.Item(j) & "'"
                End If
            End If
        Next j
        ssGrid.ClearRange(1, 1, -1, -1, True)
        ssql = "SELECT I.ITEMCODE AS ITEMCODE ,I.ITEMDESC AS ITEMDESC,I.ITEMTYPECODE AS ITEMTYPECODE ,I.GROUPCODE AS GROUPCODE,"
        ssql = ssql & " R.UOM AS UOM,ISNULL(R.PURCAHSERATE,0) AS PURCAHSERATE ,R.ITEMRATE AS ITEMRATE,P.POS AS POS,R.STARTINGDATE AS STARTINGDATE "
        ssql = ssql & " FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE INNER JOIN POSMENULINK AS P ON I.ITEMCODE = P.ITEMCODE WHERE R.STARTINGDATE ='" & Format(mskdate.Value, "dd-MMM-yyyy") & "' AND ISNULL(R.ENDINGDATE,'') = ''  "
        If Trim(vPOint & "") <> "" Then
            ssql = ssql & " AND P.POS IN (" & vPOint & ")"
        End If
        If Trim(vGroup & "") <> "" Then
            ssql = ssql & " AND I.GROUPCODE IN (" & vGroup & ")"
        End If
        ssql = ssql & " ORDER BY ITEMCODE"
        vconn.getDataSet(ssql, "ITEMMASTER")
        If gdataset.Tables("ITEMMASTER").Rows.Count > 0 Then
            For i = 1 To gdataset.Tables("ITEMMASTER").Rows.Count
                With ssGrid
                    .Row = i
                    .Col = 1
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMCODE"))
                    .Col = 2
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMDESC"))
                    .Col = 3
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("UOM"))
                    .Col = 5
                    .Text = Format(Val(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("PURCAHSERATE")), "0.00")
                    .Col = 6
                    .Text = Format(Val(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMRATE")), "0.00")
                    .Col = 7
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMTYPECODE"))
                    .Col = 8
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("GROUPCODE"))
                    .Col = 9
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("POS"))
                End With
            Next i
        Else
            MessageBox.Show(" Specified Group Code is not avaliable", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            For i = 0 To LstPOS.Items.Count - 1
                LstPOS.SetItemChecked(i, False)
            Next
            Call FillItems()
            Exit Sub
        End If
    End Sub

    Private Sub LstPOS_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstPOS.DoubleClick
        Dim j As Integer
        vPOint = ""
        For j = 0 To LstPOS.Items.Count - 1
            If LstPOS.GetItemChecked(j) = True Then
                If Trim(vPOint) = "" Then
                    vPOint = "'" & LstPOS.Items.Item(j) & "'"
                Else
                    vPOint = vPOint & ",'" & LstPOS.Items.Item(j) & "'"
                End If
            End If
        Next j
        ssGrid.ClearRange(1, 1, -1, -1, True)
        ssql = "SELECT I.ITEMCODE AS ITEMCODE ,I.ITEMDESC AS ITEMDESC,I.ITEMTYPECODE AS ITEMTYPECODE ,I.GROUPCODE AS GROUPCODE,"
        ssql = ssql & " R.UOM AS UOM,ISNULL(R.PURCAHSERATE,0) AS PURCAHSERATE ,R.ITEMRATE AS ITEMRATE,P.POS AS POS,R.STARTINGDATE AS STARTINGDATE "
        ssql = ssql & " FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE INNER JOIN POSMENULINK AS P ON I.ITEMCODE = P.ITEMCODE WHERE R.STARTINGDATE ='" & Format(mskdate.Value, "dd-MMM-yyyy") & "' AND ISNULL(R.ENDINGDATE,'') = ''  "
        If Trim(vPOint & "") <> "" Then
            ssql = ssql & " AND P.POS IN (" & vPOint & ")"
        End If
        If Trim(vGroup & "") <> "" Then
            ssql = ssql & " AND I.GROUPCODE IN (" & vGroup & ")"
        End If
        ssql = ssql & " ORDER BY ITEMCODE"
        vconn.getDataSet(ssql, "ITEMMASTER")
        If gdataset.Tables("ITEMMASTER").Rows.Count > 0 Then
            For i = 1 To gdataset.Tables("ITEMMASTER").Rows.Count
                With ssGrid
                    .Row = i
                    .Col = 1
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMCODE"))
                    .Col = 2
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMDESC"))
                    .Col = 3
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("UOM"))
                    .Col = 5
                    .Text = Format(Val(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("PURCAHSERATE")), "0.00")
                    .Col = 6
                    .Text = Format(Val(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMRATE")), "0.00")
                    .Col = 7
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("ITEMTYPECODE"))
                    .Col = 8
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("GROUPCODE"))
                    .Col = 9
                    .Text = CStr(gdataset.Tables("ITEMMASTER").Rows(i - 1).Item("POS"))
                End With
            Next i
        Else
            MessageBox.Show(" Specified POS Code is not avaliable", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            For i = 0 To LstPOS.Items.Count - 1
                LstPOS.SetItemChecked(i, False)
            Next
            Call FillItems()
            Exit Sub
        End If
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click

    End Sub

    Private Sub mskdate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskdate.Validated
        Dim vDate As Date
        Dim vpurchaserate, vRate As Double
        If IsDate(mskdate.Value) = False Then
            Call FillItems()
            mskdate.Focus()
            Exit Sub
        End If
        ssql = " SELECT I.ITEMCODE ,I.ITEMDESC,I.ITEMTYPECODE,I.GROUPCODE,I.FREEZE,R.UOM,ISNULL(R.PURCAHSERATE,0) AS PURCAHSERATE,ISNULL(R.ITEMRATE,0) AS ITEMRATE,"
        ssql = ssql & " P.POS,R.STARTINGDATE,R.ENDINGDATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON I.ITEMCODE = R.ITEMCODE "
        ssql = ssql & " INNER JOIN POSMENULINK AS P ON I.ITEMCODE = P.ITEMCODE"
        ssql = ssql & " WHERE R.STARTINGDATE = '" & Format(mskdate.Value, "dd-MMM-yyyy") & "' AND ISNULL(R.ENDINGDATE,'') = '' "
        ssql = ssql & " GROUP BY I.ITEMCODE ,I.ITEMDESC,I.ITEMTYPECODE,I.GROUPCODE,I.FREEZE,R.UOM,R.PURCAHSERATE,R.ITEMRATE, "
        ssql = ssql & " P.POS,R.STARTINGDATE,R.ENDINGDATE "
        ssql = ssql & " ORDER BY I.ITEMCODE ,I.ITEMDESC"
        vconn.getDataSet(ssql, "RateMaster")
        If gdataset.Tables("RateMaster").Rows.Count > 0 Then
            CmdAdd.Text = "Update[F7]"
            For i = 1 To gdataset.Tables("RateMaster").Rows.Count
                If gdataset.Tables("RateMaster").Rows(i - 1).Item("Freeze") = "Y" Then
                    chkFreeze.Checked = True
                End If
                With ssGrid
                    .Row = i
                    .Col = 1
                    .Text = gdataset.Tables("RateMaster").Rows(i - 1).Item("ITEMCODE")
                    .Col = 2
                    .Text = gdataset.Tables("RateMaster").Rows(i - 1).Item("ITEMDESC")
                    .Col = 3
                    .Text = gdataset.Tables("RateMaster").Rows(i - 1).Item("UOM")
                    .Col = 5
                    .Text = Format(Val(gdataset.Tables("RateMaster").Rows(i - 1).Item("PURCAHSERATE")), "0.00")
                    .Col = 6
                    .Text = Format(Val(gdataset.Tables("RateMaster").Rows(i - 1).Item("ITEMRATE")), "0.00")
                    .Col = 7
                    .Text = gdataset.Tables("RateMaster").Rows(i - 1).Item("ITEMTYPECODE")
                    .Col = 8
                    .Text = gdataset.Tables("RateMaster").Rows(i - 1).Item("GROUPCODE")
                    .Col = 9
                    .Text = gdataset.Tables("RateMaster").Rows(i - 1).Item("POS")
                End With
            Next
        Else
            CmdAdd.Text = "Add [F7]"
            ssGrid.ClearRange(1, 1, -1, -1, True)
        End If
    End Sub

    Private Sub mskdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskdate.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmdDateHelp_Click(cmdDateHelp, e)
        End If
    End Sub
End Class