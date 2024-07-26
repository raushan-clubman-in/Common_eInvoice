Imports System.Data.SqlClient
Public Class frmServerwisePendingKotRegister
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Chk_Servercode As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_ServerCode As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Chk_PAYMENTMODE As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CHKLIST_PAYMENTMODE As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Chklist_POSLocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_SelectAllPos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CHKSUMMARY As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmServerwisePendingKotRegister))
        Me.Label7 = New System.Windows.Forms.Label
        Me.Chk_Servercode = New System.Windows.Forms.CheckBox
        Me.Chklist_ServerCode = New System.Windows.Forms.CheckedListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Chk_PAYMENTMODE = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CHKLIST_PAYMENTMODE = New System.Windows.Forms.CheckedListBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Chklist_POSLocation = New System.Windows.Forms.CheckedListBox
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CHKSUMMARY = New System.Windows.Forms.CheckBox
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(168, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(336, 24)
        Me.Label7.TabIndex = 423
        Me.Label7.Text = "SERVER NAME :"
        '
        'Chk_Servercode
        '
        Me.Chk_Servercode.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Servercode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Servercode.Location = New System.Drawing.Point(168, 40)
        Me.Chk_Servercode.Name = "Chk_Servercode"
        Me.Chk_Servercode.Size = New System.Drawing.Size(128, 24)
        Me.Chk_Servercode.TabIndex = 422
        Me.Chk_Servercode.Text = "SELECT ALL"
        '
        'Chklist_ServerCode
        '
        Me.Chklist_ServerCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_ServerCode.Location = New System.Drawing.Point(168, 88)
        Me.Chklist_ServerCode.Name = "Chklist_ServerCode"
        Me.Chklist_ServerCode.Size = New System.Drawing.Size(336, 172)
        Me.Chklist_ServerCode.TabIndex = 421
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 696)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 431
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label2)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(168, 552)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 427
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 18)
        Me.Label2.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 18)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(168, 552)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 424
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "TO DATE :"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FROM DATE :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Controls.Add(Me.CmdPrint)
        Me.GroupBox4.Controls.Add(Me.cmdexit)
        Me.GroupBox4.Controls.Add(Me.CmdView)
        Me.GroupBox4.Location = New System.Drawing.Point(168, 624)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox4.TabIndex = 430
        Me.GroupBox4.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(60, 15)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 433
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(380, 15)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 431
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(548, 15)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 432
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(220, 15)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 430
        Me.CmdView.Text = "View [F9]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 25)
        Me.Label1.TabIndex = 432
        Me.Label1.Text = "PENDING KOT  REGISTER"
        '
        'Timer1
        '
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(520, 40)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(128, 24)
        Me.CheckBox2.TabIndex = 439
        Me.CheckBox2.Text = "SELECT ALL "
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckedListBox1.Location = New System.Drawing.Point(520, 88)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(312, 172)
        Me.CheckedListBox1.TabIndex = 440
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(520, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 24)
        Me.Label6.TabIndex = 441
        Me.Label6.Text = "USER LIST :"
        '
        'Chk_PAYMENTMODE
        '
        Me.Chk_PAYMENTMODE.BackColor = System.Drawing.Color.Transparent
        Me.Chk_PAYMENTMODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_PAYMENTMODE.Location = New System.Drawing.Point(520, 261)
        Me.Chk_PAYMENTMODE.Name = "Chk_PAYMENTMODE"
        Me.Chk_PAYMENTMODE.Size = New System.Drawing.Size(132, 24)
        Me.Chk_PAYMENTMODE.TabIndex = 445
        Me.Chk_PAYMENTMODE.Text = "SELECT ALL"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(520, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(320, 23)
        Me.Label8.TabIndex = 444
        Me.Label8.Text = "PAYMENTMODE:"
        '
        'CHKLIST_PAYMENTMODE
        '
        Me.CHKLIST_PAYMENTMODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CHKLIST_PAYMENTMODE.Location = New System.Drawing.Point(520, 312)
        Me.CHKLIST_PAYMENTMODE.Name = "CHKLIST_PAYMENTMODE"
        Me.CHKLIST_PAYMENTMODE.Size = New System.Drawing.Size(320, 193)
        Me.CHKLIST_PAYMENTMODE.TabIndex = 443
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(168, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(312, 24)
        Me.Label9.TabIndex = 448
        Me.Label9.Text = "POS LOCATION :"
        '
        'Chklist_POSLocation
        '
        Me.Chklist_POSLocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chklist_POSLocation.Location = New System.Drawing.Point(168, 312)
        Me.Chklist_POSLocation.Name = "Chklist_POSLocation"
        Me.Chklist_POSLocation.Size = New System.Drawing.Size(312, 193)
        Me.Chklist_POSLocation.TabIndex = 446
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(168, 261)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.Size = New System.Drawing.Size(136, 24)
        Me.Chk_SelectAllPos.TabIndex = 447
        Me.Chk_SelectAllPos.Text = "SELECT ALL"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(72, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(848, 480)
        Me.GroupBox1.TabIndex = 449
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(200, 520)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(160, 24)
        Me.CheckBox1.TabIndex = 450
        Me.CheckBox1.Text = "SERVER CODE"
        '
        'CHKSUMMARY
        '
        Me.CHKSUMMARY.BackColor = System.Drawing.Color.Transparent
        Me.CHKSUMMARY.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKSUMMARY.Location = New System.Drawing.Point(696, 520)
        Me.CHKSUMMARY.Name = "CHKSUMMARY"
        Me.CHKSUMMARY.Size = New System.Drawing.Size(160, 24)
        Me.CHKSUMMARY.TabIndex = 451
        Me.CHKSUMMARY.Text = "SUMMARY"
        '
        'frmServerwisePendingKotRegister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(990, 716)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CHKSUMMARY)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Chklist_POSLocation)
        Me.Controls.Add(Me.Chk_SelectAllPos)
        Me.Controls.Add(Me.Chk_PAYMENTMODE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CHKLIST_PAYMENTMODE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Chk_Servercode)
        Me.Controls.Add(Me.Chklist_ServerCode)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmServerwisePendingKotRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PENDING BILL REGISTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ssql As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    '''*****************************  To fill Server details from ServerMaster  **************************'''
    Private Sub FillServerCode()
        Dim i As Integer
        Chklist_ServerCode.Items.Clear()
        ssql = "SELECT ISNULL(SERVERCODE,'') AS SERVERCODE,ISNULL(SERVERNAME,'') AS SERVERNAME FROM SERVERMASTER ORDER BY SERVERCODE"
        vconn.getDataSet(ssql, "servermaster")
        If gdataset.Tables("servermaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("servermaster").Rows.Count - 1
                With gdataset.Tables("servermaster").Rows(i)
                    Chklist_ServerCode.Items.Add(Trim(.Item("SERVERNAME") & "==>" & .Item("SERVERCODE")))
                End With
            Next
        End If
        CheckedListBox1.Items.Clear()
        ssql = "select USERNAME from USERADMIN GROUP BY USERNAME ORDER BY USERNAME"
        vconn.getDataSet(ssql, "USERmaster")
        If gdataset.Tables("USERmaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USERmaster").Rows.Count - 1
                With gdataset.Tables("USERmaster").Rows(i)
                    CheckedListBox1.Items.Add(Trim(.Item("username") & ""))
                End With
            Next
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
                    Me.CmdView.Enabled = False
                    Me.CmdPrint.Enabled = False
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = False
                    Me.CmdPrint.Enabled = False
                End If
            Next
        End If
    End Sub
    Private Sub FillPOSLocation()
        Dim i As Integer
        Chklist_POSLocation.Items.Clear()
        sqlstring = "SELECT DISTINCT poscode,posdesc FROM posmaster WHERE ISNULL(Freeze,'')<>'Y' "
        vconn.getDataSet(sqlstring, "POS")
        If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                With gdataset.Tables("POS").Rows(i)
                    Chklist_POSLocation.Items.Add(Trim(.Item("POSdesc")))
                End With
            Next i
        End If
        Chklist_POSLocation.Sorted = True
    End Sub

    Private Sub rptPendingbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillServerCode()
        Call FillPOSLocation()
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
        'opt_Details.Checked = True
        grp_SalebillChecklist.Top = 1000
        FillPaymentmode()
    End Sub
    Private Sub mskFromDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskFromDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            mskToDate.Focus()
        End If
    End Sub

    Private Sub mskToDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskToDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmdView.Focus()
        End If
    End Sub

    '''Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '''    Chklist_ServerCode.Items.Clear()
    '''    grp_SalebillChecklist.Top = 1000
    '''    Chk_Servercode.Checked = False
    '''    ''opt_Details.Checked = True
    '''    Call FillServerCode()
    '''End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            If CHKSUMMARY.Checked = True Then
                Call KOT_PENDING()
            Else
                Call ViewPendingBillRegister()
            End If
        End If
    End Sub

    Private Sub Chklist_ServerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chklist_ServerCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            mskFromDate.Focus()
        End If
    End Sub
    Private Sub ViewPendingBillRegister()
        Dim i As Integer
        Dim sqlstring As String
        Dim ServerCode() As String
        Dim strServer As String
        ' If Val(Chklist_ServerCode.CheckedItems.Count) = 1 Then
        'strServer = Chklist_ServerCode.CheckedItems(0)
        'Else
        For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
            ServerCode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
            strServer = strServer & " '" & ServerCode(0) & "', "
        Next
        'End If
        strServer = Mid(strServer, 1, Len(strServer) - 2)

        'If opt_Details.Checked = True Then
        '''****************************************************** PENDING BILL [DETAILS] *******************************************'''

        sqlstring = " SELECT * FROM PENDINGKOTREGISTER"
        If Chklist_POSLocation.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " WHERE POSDESC IN ("
            For i = 0 To Chklist_POSLocation.CheckedItems.Count - 1
                sqlstring = sqlstring & " '" & Chklist_POSLocation.CheckedItems(i) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        Else
            MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Chklist_ServerCode.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " and  SERVERNAME IN ("
            For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
                ServerCode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
                sqlstring = sqlstring & " '" & ServerCode(0) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        Else
            MsgBox("Select the SERVER CODE", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If


        If CheckedListBox1.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " and  ADDUSERID IN ("
            For i = 0 To CheckedListBox1.CheckedItems.Count - 1
                ServerCode = Split(CheckedListBox1.CheckedItems(i), "==>")
                sqlstring = sqlstring & " '" & ServerCode(0) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"

        Else
            MsgBox("Select the SERVER CODE", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub

        End If

        If CHKLIST_PAYMENTMODE.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " and  PAYMENTTYPE IN ("
            For i = 0 To CHKLIST_PAYMENTMODE.CheckedItems.Count - 1
                ServerCode = Split(CHKLIST_PAYMENTMODE.CheckedItems(i), "==>")
                sqlstring = sqlstring & " '" & ServerCode(0) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        Else
            MsgBox("Select the PAYMENT MODE", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        sqlstring = sqlstring & " AND CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        sqlstring = sqlstring & " and  SERVERNAME IN (" & strServer & ")"
        If CheckBox1.Checked = True Then
            sqlstring = sqlstring & " ORDER BY SERVERNAME,MCODE,KOTDATE,KOTDETAILS "
        Else
            sqlstring = sqlstring & " ORDER BY MCODE,SERVERNAME,KOTDATE,KOTDETAILS "
        End If
        Dim ReportHeading() As String = {"PENDING KOT REGISTER"}
        Dim ObjPendingKOTRegisterReport As New PendingKOTRegisterReport
        ObjPendingKOTRegisterReport.Detailsection(sqlstring, ReportHeading, mskFromDate.Value, mskToDate.Value)
    End Sub

    ''Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    ''''If Chklist_ServerCode.CheckedItems.Count = 0 Then
    ''    ''''    MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    ''    ''''    Exit Sub
    ''    ''''End If
    ''    ''''Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
    ''    ''''If chkdatevalidate = False Then Exit Sub
    ''    ''''gPrint = False
    ''    ''''grp_SalebillChecklist.Top = 528
    ''    ''''grp_SalebillChecklist.Left = 168
    ''    ''''Me.ProgressBar1.Value = 2
    ''    ''''Me.Timer1.Interval = 100
    ''    ''''Me.Timer1.Enabled = True
    ''End Sub

    Private Sub Chk_Servercode_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Servercode.CheckedChanged
        Dim i As Integer
        If Chk_Servercode.Checked = True Then
            For i = 0 To Chklist_ServerCode.Items.Count - 1
                Chklist_ServerCode.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_ServerCode.Items.Count - 1
                Chklist_ServerCode.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub rptPendingbill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            For i = 0 To Chklist_ServerCode.Items.Count - 1
                Chklist_ServerCode.SetItemChecked(i, True)
            Next i
            Chk_Servercode.Checked = True
            CheckBox2.Checked = True
            For i = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(i, True)
            Next
            Chk_SelectAllPos.Checked = True
            For i = 0 To Chklist_POSLocation.Items.Count - 1
                Chklist_POSLocation.SetItemChecked(i, True)
            Next
            Chk_PAYMENTMODE.Checked = True
            For i = 0 To CHKLIST_PAYMENTMODE.Items.Count - 1
                CHKLIST_PAYMENTMODE.SetItemChecked(i, True)
            Next
            Me.mskFromDate.Focus()
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
            Call Search_Item(Chklist_ServerCode, Search)
        End If
    End Sub

    '''''Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '''''    If Chklist_ServerCode.CheckedItems.Count = 0 Then
    '''''        MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '''''        Exit Sub
    '''''    End If
    '''''    Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
    '''''    If chkdatevalidate = False Then Exit Sub
    '''''    gPrint = True
    '''''    grp_SalebillChecklist.Top = 528
    '''''    grp_SalebillChecklist.Left = 168
    '''''    Me.ProgressBar1.Value = 2
    '''''    Me.Timer1.Interval = 100
    '''''    Me.Timer1.Enabled = True
    '''''End Sub



    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        If Chklist_ServerCode.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        grp_SalebillChecklist.Top = 552
        grp_SalebillChecklist.Left = 168

        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 30
        Me.Timer1.Enabled = True
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        If Chklist_ServerCode.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = True
        grp_SalebillChecklist.Top = 552
        grp_SalebillChecklist.Left = 168
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 30
        Me.Timer1.Enabled = True
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Chk_Servercode.Checked = False
        CheckBox2.Checked = False
        Chk_SelectAllPos.Checked = False
        Chk_PAYMENTMODE.Checked = False

        Chklist_ServerCode.Items.Clear()
        grp_SalebillChecklist.Top = 1000
        Chk_Servercode.Checked = False
        ''opt_Details.Checked = True
        Call FillServerCode()
        FillPaymentmode()


    End Sub
    Sub PENDING_KOT()
        Dim i As Integer
        Dim sqlstring As String
        Dim ServerCode() As String
        Dim strServer As String
        ' If Val(Chklist_ServerCode.CheckedItems.Count) = 1 Then
        'strServer = Chklist_ServerCode.CheckedItems(0)
        'Else
        For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
            ServerCode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
            strServer = strServer & " '" & ServerCode(0) & "', "
        Next
        'End If
        strServer = Mid(strServer, 1, Len(strServer) - 2)

        'If opt_Details.Checked = True Then
        '''****************************************************** PENDING BILL [DETAILS] *******************************************'''

        sqlstring = " SELECT * FROM PENDINGKOTREGISTER"
        sqlstring = sqlstring & " WHERE CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        sqlstring = sqlstring & " and  SERVERNAME IN (" & strServer & ")"

        If CheckBox1.Checked = True Then
            sqlstring = sqlstring & " ORDER BY SERVERNAME,MCODE,KOTDATE,KOTDETAILS "
        Else
            sqlstring = sqlstring & " ORDER BY MCODE,SERVERNAME,KOTDATE,KOTDETAILS "
        End If

        Dim ReportHeading() As String = {"PENDING KOT REGISTER"}
        Dim ObjPendingKOTRegisterReport As New PendingKOTRegisterReport
        ObjPendingKOTRegisterReport.Detailsection(sqlstring, ReportHeading, mskFromDate.Value, mskToDate.Value)
        '''''ElseIf opt_summary.Checked = True Then
        '''''    '''****************************************************** PENDING BILL [SUMMARY] *******************************************'''
        '''''    sqlstring = " SELECT * FROM PENDINGKOTREGISTER"
        '''''    sqlstring = sqlstring & " WHERE CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        '''''    sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        '''''    sqlstring = sqlstring & " ORDER BY KOTDETAILS,KOTDATE "
        '''''    Dim ReportHeading() As String = {"PENDING KOT REGISTER"}
        '''''    Dim ObjPendingbillsummary As New rptPendingbillsummary
        '''''    ObjPendingbillsummary.Detailsection(sqlstring, ReportHeading, mskFromDate.Value, mskToDate.Value)
        '''''End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Dim I As New Integer
        If CheckBox2.Checked = True Then
            For I = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(I, True)
            Next
        Else
            For I = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(I, False)
            Next
        End If
    End Sub
    Private Sub KOT_PENDING()
        Dim i As Integer
        Dim sqlstring As String
        Dim ServerCode() As String
        Dim strServer, USERNAME, PAY As String
        If Chklist_ServerCode.CheckedItems.Count <> 0 Then
            For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
                ServerCode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
                strServer = strServer & " '" & ServerCode(0) & "', "
            Next
            strServer = Mid(strServer, 1, Len(strServer) - 2)
        Else
            MsgBox("Select the SERVER CODE", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If


        If CheckedListBox1.CheckedItems.Count <> 0 Then
            For i = 0 To CheckedListBox1.CheckedItems.Count - 1
                ServerCode = Split(CheckedListBox1.CheckedItems(i), "==>")
                USERNAME = USERNAME & " '" & ServerCode(0) & "', "
            Next
            USERNAME = Mid(USERNAME, 1, Len(USERNAME) - 2)

        Else
            MsgBox("Select the SERVER CODE", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub

        End If

        If CHKLIST_PAYMENTMODE.CheckedItems.Count <> 0 Then
            For i = 0 To CHKLIST_PAYMENTMODE.CheckedItems.Count - 1
                ServerCode = Split(CHKLIST_PAYMENTMODE.CheckedItems(i), "==>")
                PAY = PAY & " '" & ServerCode(0) & "', "
            Next
            PAY = Mid(PAY, 1, Len(PAY) - 2)

        Else
            MsgBox("Select the PAYMENT MODE", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        sqlstring = "SELECT SERVERCODE,SERVERNAME,ADDUSERID,KOTDETAILS,KOTDATE,ISNULL(SUM(AMOUNT+TAXAMOUNT+PACKAMOUNT+SER_CHG),0) AS TOTALAMOUNT,PAYMENTTYPE FROM PENDINGKOTREGISTER "
        If Chklist_POSLocation.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " WHERE POSDESC IN ("
            For i = 0 To Chklist_POSLocation.CheckedItems.Count - 1
                sqlstring = sqlstring & " '" & Chklist_POSLocation.CheckedItems(i) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        Else
            MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        sqlstring = sqlstring & " AND  CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "' "
        sqlstring = sqlstring & " and  SERVERNAME IN (" & strServer & ")"
        sqlstring = sqlstring & " and  ADDUSERID IN (" & USERNAME & ")"
        sqlstring = sqlstring & " and  PAYMENTTYPE IN (" & PAY & ")"
        sqlstring = sqlstring & " GROUP BY SERVERCODE,SERVERNAME,ADDUSERID,KOTDETAILS,KOTDATE,PAYMENTTYPE"
        sqlstring = sqlstring & " ORDER BY SERVERCODE,ADDUSERID,PAYMENTTYPE,KOTDETAILS,KOTDATE "
        Dim ReportHeading() As String = {"PENDING KOT REGISTER"}
        Dim ObjPendingKOTRegisterReport As New pendingkot
        ObjPendingKOTRegisterReport.Detailsection(sqlstring, ReportHeading, mskFromDate.Value, mskToDate.Value)
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

    Private Sub CHKLIST_PAYMENTMODE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKLIST_PAYMENTMODE.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
    Private Sub Chk_SelectAllPos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllPos.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllPos.Checked = True Then
            For i = 0 To Chklist_POSLocation.Items.Count - 1
                Chklist_POSLocation.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_POSLocation.Items.Count - 1
                Chklist_POSLocation.SetItemChecked(i, False)
            Next
        End If

    End Sub

    Private Sub CHKSUMMARY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
