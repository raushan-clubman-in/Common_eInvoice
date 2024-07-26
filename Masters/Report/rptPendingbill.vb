Imports System.Data.SqlClient
Public Class rptPendingbill
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents opt_Details As System.Windows.Forms.RadioButton
    Friend WithEvents opt_summary As System.Windows.Forms.RadioButton
    Friend WithEvents optAsOn As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstPayMode As System.Windows.Forms.CheckedListBox
    Friend WithEvents chkPayMode As System.Windows.Forms.CheckBox
    Friend WithEvents dtpAson As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptPendingbill))
        Me.Label7 = New System.Windows.Forms.Label
        Me.Chk_Servercode = New System.Windows.Forms.CheckBox
        Me.Chklist_ServerCode = New System.Windows.Forms.CheckedListBox
        Me.Label5 = New System.Windows.Forms.Label
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.opt_Details = New System.Windows.Forms.RadioButton
        Me.opt_summary = New System.Windows.Forms.RadioButton
        Me.optAsOn = New System.Windows.Forms.RadioButton
        Me.lstPayMode = New System.Windows.Forms.CheckedListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.chkPayMode = New System.Windows.Forms.CheckBox
        Me.dtpAson = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(368, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(336, 24)
        Me.Label7.TabIndex = 423
        Me.Label7.Text = "SERVER NAME :"
        '
        'Chk_Servercode
        '
        Me.Chk_Servercode.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Servercode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Servercode.Location = New System.Drawing.Point(368, 73)
        Me.Chk_Servercode.Name = "Chk_Servercode"
        Me.Chk_Servercode.Size = New System.Drawing.Size(128, 24)
        Me.Chk_Servercode.TabIndex = 422
        Me.Chk_Servercode.Text = "SELECT ALL"
        '
        'Chklist_ServerCode
        '
        Me.Chklist_ServerCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_ServerCode.Location = New System.Drawing.Point(368, 121)
        Me.Chklist_ServerCode.Name = "Chklist_ServerCode"
        Me.Chklist_ServerCode.Size = New System.Drawing.Size(336, 382)
        Me.Chklist_ServerCode.TabIndex = 421
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 656)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 431
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(224, 608)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 429
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(544, 608)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 426
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(712, 608)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 428
        Me.cmdexit.Text = "Exit[F11]"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label2)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(168, 528)
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
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 19)
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
        Me.GroupBox3.Location = New System.Drawing.Point(168, 528)
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
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(384, 608)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 425
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(168, 592)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox4.TabIndex = 430
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 25)
        Me.Label1.TabIndex = 432
        Me.Label1.Text = "PENDING BILL  REGISTER"
        '
        'Timer1
        '
        '
        'opt_Details
        '
        Me.opt_Details.BackColor = System.Drawing.Color.Transparent
        Me.opt_Details.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Details.Location = New System.Drawing.Point(384, 504)
        Me.opt_Details.Name = "opt_Details"
        Me.opt_Details.Size = New System.Drawing.Size(136, 24)
        Me.opt_Details.TabIndex = 433
        Me.opt_Details.Text = "DETAILS"
        '
        'opt_summary
        '
        Me.opt_summary.BackColor = System.Drawing.Color.Transparent
        Me.opt_summary.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_summary.Location = New System.Drawing.Point(488, 504)
        Me.opt_summary.Name = "opt_summary"
        Me.opt_summary.TabIndex = 434
        Me.opt_summary.Text = "SUMMARY"
        '
        'optAsOn
        '
        Me.optAsOn.BackColor = System.Drawing.Color.Transparent
        Me.optAsOn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAsOn.Location = New System.Drawing.Point(584, 504)
        Me.optAsOn.Name = "optAsOn"
        Me.optAsOn.TabIndex = 435
        Me.optAsOn.Text = "AS ON"
        '
        'lstPayMode
        '
        Me.lstPayMode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPayMode.Items.AddRange(New Object() {"CASH", "N.CREDIT", "PARTY", "R.MEMBER", "ROOM"})
        Me.lstPayMode.Location = New System.Drawing.Point(723, 416)
        Me.lstPayMode.Name = "lstPayMode"
        Me.lstPayMode.Size = New System.Drawing.Size(157, 89)
        Me.lstPayMode.TabIndex = 436
        Me.lstPayMode.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(723, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 24)
        Me.Label6.TabIndex = 437
        Me.Label6.Text = "PAYMENT MODE :"
        Me.Label6.Visible = False
        '
        'chkPayMode
        '
        Me.chkPayMode.BackColor = System.Drawing.Color.Transparent
        Me.chkPayMode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPayMode.Location = New System.Drawing.Point(724, 367)
        Me.chkPayMode.Name = "chkPayMode"
        Me.chkPayMode.Size = New System.Drawing.Size(128, 24)
        Me.chkPayMode.TabIndex = 438
        Me.chkPayMode.Text = "SELECT ALL"
        Me.chkPayMode.Visible = False
        '
        'dtpAson
        '
        Me.dtpAson.CustomFormat = "dd-MM-yyyy"
        Me.dtpAson.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAson.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAson.Location = New System.Drawing.Point(725, 335)
        Me.dtpAson.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.dtpAson.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.dtpAson.Name = "dtpAson"
        Me.dtpAson.Size = New System.Drawing.Size(152, 26)
        Me.dtpAson.TabIndex = 439
        Me.dtpAson.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        Me.dtpAson.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(724, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 22)
        Me.Label8.TabIndex = 440
        Me.Label8.Text = "AS ON DATE :"
        Me.Label8.Visible = False
        '
        'rptPendingbill
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(990, 684)
        Me.Controls.Add(Me.dtpAson)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkPayMode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstPayMode)
        Me.Controls.Add(Me.optAsOn)
        Me.Controls.Add(Me.opt_summary)
        Me.Controls.Add(Me.opt_Details)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Chk_Servercode)
        Me.Controls.Add(Me.Chklist_ServerCode)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "rptPendingbill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PENDING BILL REGISTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ssql As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    '''*****************************  To fill Server details from ServerMaster  **************************'''
    Private Sub FillServerCode()
        Try
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
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub GetRights()
        Try
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
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub rptPendingbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call FillServerCode()
            mskFromDate.Value = Now.Today
            mskToDate.Value = Now.Today
            dtpAson.Value = Now.Today
            opt_Details.Checked = True
            grp_SalebillChecklist.Top = 1000
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub mskFromDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskFromDate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                mskToDate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub mskToDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskToDate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                CmdView.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            Chklist_ServerCode.Items.Clear()
            grp_SalebillChecklist.Top = 1000
            Chk_Servercode.Checked = False
            opt_Details.Checked = True
            Call FillServerCode()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
                Me.ProgressBar1.Value += 1
                Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
            Else
                Me.Timer1.Enabled = False
                Me.ProgressBar1.Value = 0
                Me.grp_SalebillChecklist.Top = 1000
                Call ViewPendingBillRegister()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chklist_ServerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chklist_ServerCode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                mskFromDate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub ViewPendingBillRegister()
        Try
            Dim i, flag As Integer
            Dim sqlstring, SQLSTRING2, sName, scode(), paymode(0) As String
            If opt_Details.Checked = True Then
                '''****************************************************** PENDING BILL [DETAILS] *******************************************'''
                sqlstring = "SELECT * FROM BILL_HDR WHERE CAST(CONVERT(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                sqlstring = sqlstring & " AND PAYMENTMODE NOT IN('CLUB','CREDIT') AND ISNULL(DELFLAG,'') <>'Y' AND BILLDETAILS NOT IN (SELECT BILLNO FROM RECEIPT_DETAILS) AND SCODE IN ("

                If Chklist_ServerCode.CheckedItems.Count <> 0 Then
                    For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
                        scode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
                        sqlstring = sqlstring & "'" & scode(1) & "',"
                    Next
                Else
                    MsgBox("Please select server(S) code")
                    Exit Sub
                End If
                sqlstring = Mid(sqlstring, 1, (Len(sqlstring) - 1))
                sqlstring = sqlstring & ")"
                sqlstring = sqlstring & " ORDER BY SCODE"
                ''GROUP TOTAL==========================
                SQLSTRING2 = "SELECT PAYMENTMODE,SUM(ISNULL(TOTALAMOUNT ,0)) AS AMOUNT "
                SQLSTRING2 = SQLSTRING2 & " FROM BILL_HDR WHERE PAYMENTMODE NOT IN('CLUB','CREDIT') AND CAST(CONVERT(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN "
                SQLSTRING2 = SQLSTRING2 & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                SQLSTRING2 = SQLSTRING2 & " AND PAYMENTMODE NOT IN('CLUB','CREDIT') AND ISNULL(DELFLAG,'') <>'Y' AND "
                SQLSTRING2 = SQLSTRING2 & " ISNULL(CROSTATUS,'')<>'Y' AND BILLDETAILS NOT IN (SELECT BILLNO FROM RECEIPT_DETAILS) "
                SQLSTRING2 = SQLSTRING2 & " AND SCODE IN ("
                If Chklist_ServerCode.CheckedItems.Count <> 0 Then
                    For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
                        scode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
                        SQLSTRING2 = SQLSTRING2 & "'" & scode(1) & "',"
                    Next
                Else
                    MsgBox("Please select server(S) code")
                    Exit Sub
                End If
                SQLSTRING2 = Mid(SQLSTRING2, 1, (Len(SQLSTRING2) - 1))
                SQLSTRING2 = SQLSTRING2 & ")"
                SQLSTRING2 = SQLSTRING2 & " GROUP BY PAYMENTMODE"
                ''=====================================
                Dim ReportHeading() As String = {"Unrealised Bill Register"}
                Dim objUnrealisedbill As New rptServerwisePendingregister
                objUnrealisedbill.Detailsection(sqlstring, SQLSTRING2, reportheading, mskFromDate.Value, mskToDate.Value)


            ElseIf opt_summary.Checked = True Then
                '''****************************************************** PENDING BILL [SUMMARY] *******************************************'''
                flag = 0
                sqlstring = " SELECT * FROM FINANLVSCRO"
                sqlstring = sqlstring & " WHERE CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                sqlstring = sqlstring & " ORDER BY KOTDATE,KOTDETAILS"
                Dim ReportHeading() As String = {"PENDING BILL REGISTER"}
                Dim ObjPendingbillsummary As New rptPendingbillsummary
                ObjPendingbillsummary.Detailsection(sqlstring, ReportHeading, mskFromDate.Value, mskToDate.Value)
            ElseIf optAsOn.Checked = True Then
                sqlstring = "SELECT CRODATE,CROSTATUS,CRONO,H.BILLDATE,* FROM BILL_HDR H "
                sqlstring = sqlstring & "LEFT OUTER JOIN RECEIPT_DETAILS R"
                sqlstring = sqlstring & " ON H.BILLDETAILS=R.BILLNO"
                sqlstring = sqlstring & " WHERE ISNULL(H.DELFLAG,'')<>'Y' AND H.BILLDATE BETWEEN '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                sqlstring = sqlstring & "  AND (ISNULL(CRODATE,'')>'" & Format(dtpAson.Value, "yyyy-MM-dd") & "' OR CROSTATUS='N')"
                sqlstring = sqlstring & " AND PAYMENTMODE IN("
                Dim j As Integer
                j = 0
                If lstPayMode.CheckedItems.Count <> 0 Then
                    For i = 0 To lstPayMode.CheckedItems.Count - 1
                        paymode(paymode.Length - 1) = CStr(lstPayMode.CheckedItems(i))
                        sqlstring = sqlstring & "'" & CStr(lstPayMode.CheckedItems(i)) & "'" & ","
                        ReDim Preserve paymode(paymode.Length)
                        j = j + 1
                    Next
                Else
                    MsgBox("Please select paymentmode(S) ")
                    Exit Sub
                End If
                sqlstring = Mid(sqlstring, 1, (Len(sqlstring) - 1))
                sqlstring = sqlstring & ")"
                sqlstring = sqlstring & " AND SCODE IN( "
                If Chklist_ServerCode.CheckedItems.Count <> 0 Then
                    For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
                        scode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
                        sqlstring = sqlstring & "'" & scode(1) & "',"
                    Next
                Else
                    MsgBox("Please select server(S) code")
                    Exit Sub
                End If
                sqlstring = Mid(sqlstring, 1, (Len(sqlstring) - 1))

                sqlstring = sqlstring & ")"
                sqlstring = sqlstring & " ORDER BY SCODE"
                ''========================================TOTAL AMOUNT :PAYMENTMODE WISE=================
                SQLSTRING2 = "SELECT PAYMENTMODE,SUM(TOTALAMOUNT) AS AMOUNT"
                SQLSTRING2 = SQLSTRING2 & " FROM BILL_HDR H LEFT OUTER JOIN RECEIPT_DETAILS R ON H.BILLDETAILS=R.BILLNO"
                SQLSTRING2 = SQLSTRING2 & " WHERE ISNULL(H.DELFLAG,'')<>'Y' AND H.BILLDATE BETWEEN '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                SQLSTRING2 = SQLSTRING2 & " AND (ISNULL(CRODATE,'')>'" & Format(dtpAson.Value, "yyyy-MM-dd") & "' OR CROSTATUS='N') "
                SQLSTRING2 = SQLSTRING2 & " AND PAYMENTMODE IN( "
                If lstPayMode.CheckedItems.Count <> 0 Then
                    For i = 0 To lstPayMode.CheckedItems.Count - 1
                        paymode(paymode.Length - 1) = CStr(lstPayMode.CheckedItems(i))
                        SQLSTRING2 = SQLSTRING2 & "'" & CStr(lstPayMode.CheckedItems(i)) & "'" & ","
                        ReDim Preserve paymode(paymode.Length)
                        j = j + 1
                    Next
                Else
                    MsgBox("Please select paymentmode(S) ")
                    Exit Sub
                End If
                SQLSTRING2 = Mid(SQLSTRING2, 1, (Len(SQLSTRING2) - 1))
                SQLSTRING2 = SQLSTRING2 & ")"
                SQLSTRING2 = SQLSTRING2 & " AND SCODE IN( "
                If Chklist_ServerCode.CheckedItems.Count <> 0 Then
                    For i = 0 To Chklist_ServerCode.CheckedItems.Count - 1
                        scode = Split(Chklist_ServerCode.CheckedItems(i), "==>")
                        SQLSTRING2 = SQLSTRING2 & "'" & scode(1) & "',"
                    Next
                Else
                    MsgBox("Please select server(S) code")
                    Exit Sub
                End If
                SQLSTRING2 = Mid(SQLSTRING2, 1, (Len(SQLSTRING2) - 1))

                SQLSTRING2 = SQLSTRING2 & ")"
                SQLSTRING2 = SQLSTRING2 & " GROUP BY PAYMENTMODE"
                ''SQLSTRING2 = SQLSTRING2 & " ORDER BY SCODE"
                ''=============================================================================================

                Dim ReportHeading() As String = {"Unrealised Bill Register"}
                Dim objUnrealisedbill As New rptServerwisePendingregister
                objUnrealisedbill.Ason_Section(sqlstring, SQLSTRING2, reportheading, mskFromDate.Value, mskToDate.Value, paymode, dtpAson.Value)
            Else
                sqlstring = "SELECT * FROM BILL_HDR WHERE PAYMENTMODE NOT IN('CLUB','CREDIT') AND ISNULL(DELFLAG,'N') <>'Y' AND BILLDETAILS NOT IN (SELECT BILLNO FROM RECEIPT_DETAILS)"
                Dim ReportHeading() As String = {"Unrealised Bill Register"}
                Dim objUnrealisedbill As New rptServerwisePendingregister
                objUnrealisedbill.Detailsection(sqlstring, SQLSTRING2, reportheading, mskFromDate.Value, mskToDate.Value)

            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            If Chklist_ServerCode.CheckedItems.Count = 0 Then
                MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = False
            grp_SalebillChecklist.Top = 528
            grp_SalebillChecklist.Left = 168
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_Servercode_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Servercode.CheckedChanged
        Try
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
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub rptPendingbill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Dim i As Integer
            If e.KeyCode = Keys.F6 Then
                Call CmdClear_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                For i = 0 To Chklist_ServerCode.Items.Count - 1
                    Chklist_ServerCode.SetItemChecked(i, True)
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
            ElseIf e.KeyCode = Keys.F7 Then
                Search = InputBox("ENTER TEXT", "SEARCH")
                Call Search_Item(Chklist_ServerCode, Search)
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            If Chklist_ServerCode.CheckedItems.Count = 0 Then
                MessageBox.Show("Select the Server(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = True
            grp_SalebillChecklist.Top = 528
            grp_SalebillChecklist.Left = 168
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub chkPayMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPayMode.CheckedChanged
        Try
            Dim i As Integer
            If chkPayMode.Checked = True Then
                For i = 0 To lstPayMode.Items.Count - 1
                    lstPayMode.SetItemChecked(i, True)
                Next
            Else
                For i = 0 To lstPayMode.Items.Count - 1
                    lstPayMode.SetItemChecked(i, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub optAsOn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optAsOn.Click
        Try
            Label8.Visible = True
            Label6.Visible = True
            lstPayMode.Visible = True
            dtpAson.Visible = True
            chkPayMode.Visible = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub optAsOn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAsOn.CheckedChanged
        Try
            Dim i
            Label8.Visible = False
            Label6.Visible = False
            lstPayMode.Visible = False
            dtpAson.Visible = False
            chkPayMode.Visible = False
            For i = 0 To lstPayMode.Items.Count - 1
                lstPayMode.SetItemChecked(i, False)
            Next
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
End Class
