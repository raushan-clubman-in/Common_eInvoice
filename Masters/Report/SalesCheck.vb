Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports CrystalDecisions.reportsource
Imports CrystalDecisions.shared
Imports CrystalDecisions.web

Public Class SalesCheck
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
    Friend WithEvents Chk_SelectAllPos As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_SelectAllServer As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents Chklist_POSLocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chklist_Servercode As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RAD_BOTH As System.Windows.Forms.RadioButton
    Friend WithEvents RAD_POOLCAFE As System.Windows.Forms.RadioButton
    Friend WithEvents RAD_MCLUB As System.Windows.Forms.RadioButton
    Friend WithEvents Chk_PAYMENTMODE As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CHKLIST_PAYMENTMODE As System.Windows.Forms.CheckedListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SalesCheck))
        Me.Chklist_POSLocation = New System.Windows.Forms.CheckedListBox
        Me.Chklist_Servercode = New System.Windows.Forms.CheckedListBox
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox
        Me.Chk_SelectAllServer = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RAD_BOTH = New System.Windows.Forms.RadioButton
        Me.RAD_POOLCAFE = New System.Windows.Forms.RadioButton
        Me.RAD_MCLUB = New System.Windows.Forms.RadioButton
        Me.Chk_PAYMENTMODE = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CHKLIST_PAYMENTMODE = New System.Windows.Forms.CheckedListBox
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chklist_POSLocation
        '
        Me.Chklist_POSLocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_POSLocation.Location = New System.Drawing.Point(128, 128)
        Me.Chklist_POSLocation.Name = "Chklist_POSLocation"
        Me.Chklist_POSLocation.Size = New System.Drawing.Size(264, 361)
        Me.Chklist_POSLocation.TabIndex = 1
        '
        'Chklist_Servercode
        '
        Me.Chklist_Servercode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Servercode.Location = New System.Drawing.Point(400, 128)
        Me.Chklist_Servercode.Name = "Chklist_Servercode"
        Me.Chklist_Servercode.Size = New System.Drawing.Size(264, 361)
        Me.Chklist_Servercode.TabIndex = 3
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(128, 80)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.TabIndex = 0
        Me.Chk_SelectAllPos.Text = "SELECT ALL "
        '
        'Chk_SelectAllServer
        '
        Me.Chk_SelectAllServer.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllServer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllServer.Location = New System.Drawing.Point(400, 80)
        Me.Chk_SelectAllServer.Name = "Chk_SelectAllServer"
        Me.Chk_SelectAllServer.TabIndex = 2
        Me.Chk_SelectAllServer.Text = "SELECT ALL"
        '
        'Timer1
        '
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(232, 600)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 5
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(552, 600)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 7
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(720, 600)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 8
        Me.cmdexit.Text = "Exit[F11]"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(176, 520)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 12
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
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(176, 520)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 4
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
        Me.CmdView.Location = New System.Drawing.Point(392, 600)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 6
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(176, 584)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SALE BILL CHECKLIST"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(176, 640)
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
        Me.Label2.Location = New System.Drawing.Point(128, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 24)
        Me.Label2.TabIndex = 421
        Me.Label2.Text = "POS LOCATION :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(400, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 24)
        Me.Label4.TabIndex = 422
        Me.Label4.Text = "SERVER NAME :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RAD_BOTH)
        Me.GroupBox1.Controls.Add(Me.RAD_POOLCAFE)
        Me.GroupBox1.Controls.Add(Me.RAD_MCLUB)
        Me.GroupBox1.Location = New System.Drawing.Point(-200, 512)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 40)
        Me.GroupBox1.TabIndex = 423
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'RAD_BOTH
        '
        Me.RAD_BOTH.Checked = True
        Me.RAD_BOTH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_BOTH.Location = New System.Drawing.Point(16, 17)
        Me.RAD_BOTH.Name = "RAD_BOTH"
        Me.RAD_BOTH.Size = New System.Drawing.Size(96, 15)
        Me.RAD_BOTH.TabIndex = 0
        Me.RAD_BOTH.TabStop = True
        Me.RAD_BOTH.Text = "BOTH"
        '
        'RAD_POOLCAFE
        '
        Me.RAD_POOLCAFE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_POOLCAFE.Location = New System.Drawing.Point(112, 16)
        Me.RAD_POOLCAFE.Name = "RAD_POOLCAFE"
        Me.RAD_POOLCAFE.Size = New System.Drawing.Size(96, 15)
        Me.RAD_POOLCAFE.TabIndex = 0
        Me.RAD_POOLCAFE.Text = "POOL CAFE"
        '
        'RAD_MCLUB
        '
        Me.RAD_MCLUB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAD_MCLUB.Location = New System.Drawing.Point(233, 16)
        Me.RAD_MCLUB.Name = "RAD_MCLUB"
        Me.RAD_MCLUB.Size = New System.Drawing.Size(96, 15)
        Me.RAD_MCLUB.TabIndex = 0
        Me.RAD_MCLUB.Text = " M.CLUB"
        Me.RAD_MCLUB.Visible = False
        '
        'Chk_PAYMENTMODE
        '
        Me.Chk_PAYMENTMODE.BackColor = System.Drawing.Color.Transparent
        Me.Chk_PAYMENTMODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_PAYMENTMODE.Location = New System.Drawing.Point(677, 80)
        Me.Chk_PAYMENTMODE.Name = "Chk_PAYMENTMODE"
        Me.Chk_PAYMENTMODE.Size = New System.Drawing.Size(132, 24)
        Me.Chk_PAYMENTMODE.TabIndex = 445
        Me.Chk_PAYMENTMODE.Text = "SELECT ALL"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(677, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 23)
        Me.Label9.TabIndex = 444
        Me.Label9.Text = "PAYMENTMODE:"
        '
        'CHKLIST_PAYMENTMODE
        '
        Me.CHKLIST_PAYMENTMODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CHKLIST_PAYMENTMODE.Location = New System.Drawing.Point(677, 128)
        Me.CHKLIST_PAYMENTMODE.Name = "CHKLIST_PAYMENTMODE"
        Me.CHKLIST_PAYMENTMODE.Size = New System.Drawing.Size(216, 361)
        Me.CHKLIST_PAYMENTMODE.TabIndex = 443
        '
        'SalesCheck
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(994, 696)
        Me.ControlBox = False
        Me.Controls.Add(Me.Chk_PAYMENTMODE)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CHKLIST_PAYMENTMODE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Chk_SelectAllServer)
        Me.Controls.Add(Me.Chk_SelectAllPos)
        Me.Controls.Add(Me.Chklist_POSLocation)
        Me.Controls.Add(Me.Chklist_Servercode)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "SalesCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALE BILL CHECKLIST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim vconn As New GlobalClass
    Dim sqlstring As String
    Dim ds As DataSet
    Dim chkbool As Boolean
    Dim da As New SqlDataAdapter
    Public Myconn As New SqlConnection
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
    '''*****************************  To fill Server details from SERVERMASTER  **************************'''
    Private Sub FillServerName()
        Dim i As Integer
        Chklist_Servercode.Items.Clear()
        sqlstring = "SELECT ISNULL(SERVERCODE,'') AS SERVERCODE,ISNULL(SERVERNAME,'') AS SERVERNAME FROM SERVERMASTER ORDER BY SERVERCODE"
        vconn.getDataSet(sqlstring, "SERVERMASTER")
        If gdataset.Tables("SERVERMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("SERVERMASTER").Rows.Count - 1
                With gdataset.Tables("SERVERMASTER").Rows(i)
                    Chklist_Servercode.Items.Add(Trim(.Item("servercode")) & "==>" & .Item("servername"))
                End With
            Next i
        End If
        Chklist_Servercode.Sorted = True
    End Sub
    Private Sub SalesBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillPOSLocation()
        Call FillServerName()
        Call FillPaymentmode()
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
        grp_SalebillChecklist.Top = 1000
        If gUserCategory <> "S" Then
            Call GetRights()
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
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Chklist_POSLocation.Items.Clear()
        Chklist_Servercode.Items.Clear()
        grp_SalebillChecklist.Top = 1000
        Chk_SelectAllPos.Checked = False
        Chk_SelectAllServer.Checked = False
        Chk_PAYMENTMODE.Checked = False
        Call FillPOSLocation()
        Call FillServerName()
        Call FillPaymentmode()
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            If MessageBox.Show("Do You Want Windows Print ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then


                Dim sqlstring, bildt, mthyar As String
                Dim MONTH1, Noofdays As Integer
                Dim Viewer As New ReportViwer
                Dim txtobj1 As TextObject
                Dim txtobj2 As TextObject
                Dim txtobj3 As TextObject
                Dim txtobj4 As TextObject
                Dim txtobj5 As TextObject
                Dim r As New Cry_summary
                mthyar = "SALES BILL CHECKLIST :" & Format(mskFromDate.Value, "dd/MM/yyyy") & " TO " & Format(mskToDate.Value, "dd/MM/yyyy")
                sqlstring = " SELECT * FROM view_billsummary "
                sqlstring = sqlstring & " WHERE  CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) between '" & Format(mskFromDate.Value, "dd/MMM/yyyy") & "' and '" & Format(mskToDate.Value, "dd/MMM/yyyy") & "' order by posdesc,kotno,kotdate "
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                txtobj2 = r.ReportDefinition.ReportObjects("Text6")
                'txtobj3 = r.ReportDefinition.ReportObjects("Text18")
                txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                txtobj5 = r.ReportDefinition.ReportObjects("Text2")
                Call Viewer.GetDetails1(sqlstring, "view_billsummary", r)
                txtobj1.Text = UCase(gMAINCompanyname)
                txtobj2.Text = Format(SYSDATE, "dd/MM/yyyy")
                'txtobj3.Text = Mid(gFinancalyearStart, 7, 4) & " - " & Mid(gFinancialYearEnd, 7, 4)
                txtobj4.Text = UCase(gUsername)
                txtobj5.Text = mthyar
                Viewer.Show()
                Exit Sub
            Else
                If Chklist_POSLocation.CheckedItems.Count = 0 Then
                    MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If Chklist_Servercode.CheckedItems.Count = 0 Then
                    MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
                If chkdatevalidate = False Then Exit Sub
                gPrint = False
                grp_SalebillChecklist.Top = 520
                grp_SalebillChecklist.Left = 176
                Me.ProgressBar1.Value = 2
                Me.Timer1.Interval = 30
                Me.Timer1.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        If Chklist_POSLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Chklist_Servercode.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = True
        grp_SalebillChecklist.Top = 520
        grp_SalebillChecklist.Left = 176
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 30
        Me.Timer1.Enabled = True
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

    Private Sub Chk_SelectAllServer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllServer.CheckedChanged
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

    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            Call Viewsalebillchecklist()
        End If
        'Me.grp_SalebillChecklist.Top = 1000
        'Call Viewsalebillchecklist()
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
    Public Sub Viewsalebillchecklist()
        Dim RSNO
        Try
            Dim servercode() As String
            Dim i As Integer
            sqlstring = "SELECT * FROM VIEWSALEBILLCHECKLIST_KOT"
            'sqlstring = "SELECT * FROM VIEWSALEBILLCHECKLIST"
            RSNO = 1
            'End If
            If Chklist_POSLocation.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " WHERE POSDESC IN ("
                For i = 0 To Chklist_POSLocation.CheckedItems.Count - 1
                    sqlstring = sqlstring & " '" & Chklist_POSLocation.CheckedItems(i) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If Chklist_Servercode.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND SERVERCODE IN ("
                For i = 0 To Chklist_Servercode.CheckedItems.Count - 1
                    servercode = Split(Chklist_Servercode.CheckedItems(i), "==>")
                    sqlstring = sqlstring & " '" & servercode(0) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            sqlstring = sqlstring & " AND BILLDATE BETWEEN '"
            sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"

            If CHKLIST_PAYMENTMODE.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND PAYMENTMODE IN ("
                For i = 0 To CHKLIST_PAYMENTMODE.CheckedItems.Count - 1
                    sqlstring = sqlstring & " '" & CHKLIST_PAYMENTMODE.CheckedItems(i) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MsgBox("Select the Paymentmode", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If

            sqlstring = sqlstring & " ORDER BY POSDESC,kotdetails,BILLDATE "
            Dim heading() As String = {"SALES BILL CHECKLIST "}
            Dim ObjSalesBillChecklist1Report As New SalesChecklist1
            ObjSalesBillChecklist1Report.ReportDetails(sqlstring, heading, mskFromDate.Value, mskToDate.Value, RSNO, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub SalesBillChecklist1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then

            For i = 0 To Chklist_POSLocation.Items.Count - 1
                Chklist_POSLocation.SetItemChecked(i, True)
            Next i
            Chk_SelectAllPos.Checked = True
            For i = 0 To Chklist_Servercode.Items.Count - 1
                Chklist_Servercode.SetItemChecked(i, True)
            Next i
            Chk_PAYMENTMODE.Checked = True
            For i = 0 To CHKLIST_PAYMENTMODE.Items.Count - 1
                CHKLIST_PAYMENTMODE.SetItemChecked(i, True)
            Next
            Chk_SelectAllServer.Checked = True
            Me.mskFromDate.Focus()
            Exit Sub
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
        End If
    End Sub

    Private Sub Chklist_POSLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chklist_POSLocation.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chk_SelectAllServer.Focus()
        End If
    End Sub

    Private Sub Chklist_Servercode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chklist_Servercode.KeyDown
        If e.KeyCode = Keys.Enter Then
            mskFromDate.Focus()
        End If
    End Sub

    Private Sub Chk_SelectAllPos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_SelectAllPos.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chklist_POSLocation.Focus()
        End If
    End Sub
    Private Sub Chk_SelectAllServer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_SelectAllServer.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chklist_Servercode.Focus()
        End If
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
End Class