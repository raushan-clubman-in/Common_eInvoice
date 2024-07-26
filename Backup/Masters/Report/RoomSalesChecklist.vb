Imports System.Data.SqlClient
Imports System.Data
Public Class RoomSalesChecklist
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chk_Servercode As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_POSlocation As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_POSLocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Chklist_Username As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chk_uname As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_Uname As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXT_FROMNO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_TONO As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(RoomSalesChecklist))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Chk_Servercode = New System.Windows.Forms.CheckBox
        Me.Chk_POSlocation = New System.Windows.Forms.CheckBox
        Me.Chklist_POSLocation = New System.Windows.Forms.CheckedListBox
        Me.Chklist_Username = New System.Windows.Forms.CheckedListBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.chk_uname = New System.Windows.Forms.CheckBox
        Me.Chklist_Uname = New System.Windows.Forms.CheckedListBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TXT_FROMNO = New System.Windows.Forms.TextBox
        Me.TXT_TONO = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 25)
        Me.Label1.TabIndex = 407
        Me.Label1.Text = "ROOM SALE REGISTER - CHECKINWISE"
        '
        'Chk_Servercode
        '
        Me.Chk_Servercode.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Servercode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Servercode.Location = New System.Drawing.Point(360, 72)
        Me.Chk_Servercode.Name = "Chk_Servercode"
        Me.Chk_Servercode.Size = New System.Drawing.Size(128, 24)
        Me.Chk_Servercode.TabIndex = 405
        Me.Chk_Servercode.Text = "SELECT ALL"
        '
        'Chk_POSlocation
        '
        Me.Chk_POSlocation.BackColor = System.Drawing.Color.Transparent
        Me.Chk_POSlocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_POSlocation.Location = New System.Drawing.Point(40, 72)
        Me.Chk_POSlocation.Name = "Chk_POSlocation"
        Me.Chk_POSlocation.Size = New System.Drawing.Size(136, 24)
        Me.Chk_POSlocation.TabIndex = 404
        Me.Chk_POSlocation.Text = "SELECT ALL "
        '
        'Chklist_POSLocation
        '
        Me.Chklist_POSLocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_POSLocation.Location = New System.Drawing.Point(40, 120)
        Me.Chklist_POSLocation.Name = "Chklist_POSLocation"
        Me.Chklist_POSLocation.Size = New System.Drawing.Size(288, 361)
        Me.Chklist_POSLocation.TabIndex = 401
        '
        'Chklist_Username
        '
        Me.Chklist_Username.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Username.Location = New System.Drawing.Point(360, 120)
        Me.Chklist_Username.Name = "Chklist_Username"
        Me.Chklist_Username.Size = New System.Drawing.Size(296, 361)
        Me.Chklist_Username.TabIndex = 402
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(208, 592)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 413
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(528, 592)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 410
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(696, 592)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 412
        Me.cmdexit.Text = "Exit[F11]"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label2)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(152, 512)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 411
        Me.grp_SalebillChecklist.TabStop = False
        Me.grp_SalebillChecklist.Visible = False
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
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(152, 512)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 408
        Me.GroupBox3.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(216, 24)
        Me.mskFromDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(104, 26)
        Me.mskFromDate.TabIndex = 0
        Me.mskFromDate.Value = New Date(2009, 5, 8, 0, 0, 0, 0)
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
        Me.mskToDate.Location = New System.Drawing.Point(544, 24)
        Me.mskToDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(104, 26)
        Me.mskToDate.TabIndex = 1
        Me.mskToDate.Value = New Date(2009, 5, 8, 0, 0, 0, 0)
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
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(368, 592)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 409
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(152, 576)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox4.TabIndex = 414
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
        Me.Label5.Location = New System.Drawing.Point(288, 640)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 415
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(40, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(288, 24)
        Me.Label6.TabIndex = 419
        Me.Label6.Text = "POS LOCATION :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(360, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(296, 24)
        Me.Label7.TabIndex = 420
        Me.Label7.Text = "SERVER NAME :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(688, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(280, 24)
        Me.Label8.TabIndex = 423
        Me.Label8.Text = "ROOM NO :"
        '
        'chk_uname
        '
        Me.chk_uname.BackColor = System.Drawing.Color.Transparent
        Me.chk_uname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_uname.Location = New System.Drawing.Point(688, 72)
        Me.chk_uname.Name = "chk_uname"
        Me.chk_uname.Size = New System.Drawing.Size(136, 24)
        Me.chk_uname.TabIndex = 422
        Me.chk_uname.Text = "SELECT ALL"
        '
        'Chklist_Uname
        '
        Me.Chklist_Uname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Uname.Location = New System.Drawing.Point(688, 120)
        Me.Chklist_Uname.Name = "Chklist_Uname"
        Me.Chklist_Uname.Size = New System.Drawing.Size(280, 361)
        Me.Chklist_Uname.TabIndex = 421
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(208, 488)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 23)
        Me.Label9.TabIndex = 424
        Me.Label9.Text = "FROM CHKNO"
        '
        'TXT_FROMNO
        '
        Me.TXT_FROMNO.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FROMNO.Location = New System.Drawing.Point(368, 488)
        Me.TXT_FROMNO.Name = "TXT_FROMNO"
        Me.TXT_FROMNO.Size = New System.Drawing.Size(112, 27)
        Me.TXT_FROMNO.TabIndex = 425
        Me.TXT_FROMNO.Text = ""
        '
        'TXT_TONO
        '
        Me.TXT_TONO.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TONO.Location = New System.Drawing.Point(688, 488)
        Me.TXT_TONO.Name = "TXT_TONO"
        Me.TXT_TONO.Size = New System.Drawing.Size(112, 27)
        Me.TXT_TONO.TabIndex = 427
        Me.TXT_TONO.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(552, 488)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 23)
        Me.Label10.TabIndex = 426
        Me.Label10.Text = "TO CHKNO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(208, 584)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 413
        Me.Button1.Text = "Clear[F6]"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.ForestGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(368, 584)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 409
        Me.Button2.Text = "View [F9]"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.ForestGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(528, 584)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 32)
        Me.Button3.TabIndex = 410
        Me.Button3.Text = " Print [F8]"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.ForestGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(696, 584)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 32)
        Me.Button4.TabIndex = 412
        Me.Button4.Text = "Exit[F11]"
        '
        'RoomSalesChecklist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(992, 686)
        Me.Controls.Add(Me.TXT_TONO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_FROMNO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chk_uname)
        Me.Controls.Add(Me.Chklist_Uname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Chk_Servercode)
        Me.Controls.Add(Me.Chk_POSlocation)
        Me.Controls.Add(Me.Chklist_POSLocation)
        Me.Controls.Add(Me.Chklist_Username)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "RoomSalesChecklist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROOM SALE REGISTER "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ssql As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Private Sub Reportsform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillPOSLocation()
        Call FillServerCode()
        Call FILLUSERNAME()
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
        grp_SalebillChecklist.Top = 1000
        TXT_FROMNO.Text = ""
        TXT_TONO.Text = ""
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
    Private Sub FILLUSERNAME()
        Chklist_Uname.Items.Clear()
        Dim i As Integer
        ssql = "SELECT DISTINCT ISNULL(ROOMNO,0) AS ROOMNO FROM  ROOMMASTER ORDER BY ROOMNO"
        vconn.getDataSet(ssql, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    Chklist_Uname.Items.Add(Trim(CStr(.Item("ROOMNO"))))
                End With
            Next
        End If
    End Sub
    Private Sub FillPOSLocation()
        Chklist_POSLocation.Items.Clear()
        Dim i As Integer
        ssql = "SELECT DISTINCT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER ORDER BY POSDESC "
        vconn.getDataSet(ssql, "POS")
        If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                With gdataset.Tables("POS").Rows(i)
                    Chklist_POSLocation.Items.Add(Trim(CStr(.Item("POSdesc"))))
                End With
            Next
        End If
    End Sub
    Private Sub FillServerCode()
        Dim i As Integer
        Chklist_Username.Items.Clear()
        ssql = "SELECT DISTINCT ISNULL(SERVERCODE,'') AS SERVERCODE,ISNULL(SERVERNAME,'') AS SERVERNAME FROM SERVERMASTER ORDER BY SERVERCODE"
        vconn.getDataSet(ssql, "servermaster")
        If gdataset.Tables("servermaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("servermaster").Rows.Count - 1
                With gdataset.Tables("servermaster").Rows(i)
                    Chklist_Username.Items.Add(Trim(.Item("SERVERNAME") & "==>" & .Item("SERVERCODE")))
                End With
            Next
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
            Call viewRoomSaleregister()
        End If
    End Sub
    Private Sub mskFromDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFromDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            mskToDate.Focus()
        End If
    End Sub

    Private Sub mskToDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskToDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmdView.Focus()
        End If
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Chklist_POSLocation.Items.Clear()
        Chklist_Username.Items.Clear()
        grp_SalebillChecklist.Top = 1000
        Chk_POSlocation.Checked = False
        Chk_Servercode.Checked = False
        chk_uname.Checked = False
        Call FillPOSLocation()
        Call FillServerCode()
        Call FILLUSERNAME()
        TXT_FROMNO.Text = ""
        TXT_TONO.Text = ""
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        If Chklist_POSLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If Chklist_Username.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        'grp_SalebillChecklist.Top = 536
        'grp_SalebillChecklist.Left = 192
        'Me.ProgressBar1.Value = 2
        'Me.Timer1.Interval = 100
        'Me.Timer1.Enabled = True
        Call viewRoomSaleregister()
    End Sub
    Public Sub viewRoomSaleregister()
        Dim i As Integer
        Dim SERVERCODE() As String
        Dim sqlstring = "SELECT * FROM VIEWROOMSALEREGISTERUSERWISE"
        If Chklist_POSLocation.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " WHERE POSDESC IN ("
            For i = 0 To Chklist_POSLocation.CheckedItems.Count - 1
                sqlstring = sqlstring & " '" & Chklist_POSLocation.CheckedItems(i) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        Else
            MessageBox.Show("Select the location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If Chklist_Username.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " AND SCODE IN ("
            For i = 0 To Chklist_Username.CheckedItems.Count - 1
                SERVERCODE = Split(Chklist_Username.CheckedItems(i), "==>")
                sqlstring = sqlstring & SERVERCODE(1) & ", "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        Else
            MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Chklist_Uname.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " AND ROOMNO IN ("
            For i = 0 To Chklist_Uname.CheckedItems.Count - 1
                sqlstring = sqlstring & " " & Chklist_Uname.CheckedItems(i) & ", "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        Else
            MessageBox.Show("Select the location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        ' If Val(TXT_FROMNO.Text) <> 0 And Val(TXT_TONO.Text) <> 0 Then
        'sqlstring = sqlstring & " AND CHKID BETWEEN "
        ' sqlstring = sqlstring & Val(TXT_FROMNO.Text) & " AND "
        ' sqlstring = sqlstring & Val(TXT_TONO.Text) & " "
        ' End If
        sqlstring = sqlstring & " AND CAST(CONVERT(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN '"
        sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        'sqlstring = sqlstring & " ORDER BY roomno"
        sqlstring = sqlstring & " ORDER BY billdate,billno"

        Dim columnheading() As String = {"BILL DATE", "BILL NUMBER", "BASIC", "SALES TAX", "NET AMOUNT", "PAID AMOUNT", "RECEIPT NO", "BAL AMOUNT", "SERVER NAME"}
        Dim pageheading() As String = {"CASH SALES REGISTER"}
        Dim colsize() As Integer = {14, 18, 8, 12, 12, 12, 15, 14, 30}
        Dim ObjCashSalesRegisterReport As New RoomSalesRegisterUser
        ObjCashSalesRegisterReport.Reportdetails(vconn.sqlconnection, sqlstring, pageheading, columnheading, colsize, mskFromDate.Value, mskToDate.Value)
    End Sub
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        If Chklist_POSLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If Chklist_Username.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = True
        Call viewRoomSaleregister()
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub Chk_POSlocation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_POSlocation.CheckedChanged
        Dim i As Integer
        If Chk_POSlocation.Checked = True Then
            For i = 0 To Chklist_POSLocation.Items.Count - 1
                Chklist_POSLocation.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_POSLocation.Items.Count - 1
                Chklist_POSLocation.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub Chk_Servercode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Servercode.CheckedChanged
        Dim i As Integer
        If Chk_Servercode.Checked = True Then
            For i = 0 To Chklist_Username.Items.Count - 1
                Chklist_Username.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_Username.Items.Count - 1
                Chklist_Username.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub CashSalesRegister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            For i = 0 To Chklist_POSLocation.Items.Count - 1
                Chklist_POSLocation.SetItemChecked(i, True)
            Next i
            Chk_POSlocation.Checked = True
            For i = 0 To Chklist_Username.Items.Count - 1
                Chklist_Username.SetItemChecked(i, True)
            Next i
            Chk_Servercode.Checked = True
            Me.mskFromDate.Focus()
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call CmdPrint_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call CmdView_Click(sender, e)
            Exit Sub
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
        End If
    End Sub
    Private Sub chk_uname_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_uname.CheckedChanged
        Dim i As Integer
        If chk_uname.Checked = True Then
            For i = 0 To Chklist_Uname.Items.Count - 1
                Chklist_Uname.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_Uname.Items.Count - 1
                Chklist_Uname.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub TXT_FROMNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_FROMNO.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            TXT_TONO.Focus()
        End If
    End Sub

    Private Sub TXT_TONO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_TONO.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            mskFromDate.Focus()
        End If
    End Sub
End Class
