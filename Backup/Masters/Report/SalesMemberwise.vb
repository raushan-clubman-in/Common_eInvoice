Imports System.Data.SqlClient
Imports System.io
Public Class SalesMemberwise
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
    Friend WithEvents TXT_MCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmd_MCode As System.Windows.Forms.Button
    Friend WithEvents LBL_MNAME As System.Windows.Forms.Label
    Friend WithEvents Chk_All As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SalesMemberwise))
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.TXT_MCODE = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cmd_MCode = New System.Windows.Forms.Button
        Me.LBL_MNAME = New System.Windows.Forms.Label
        Me.Chk_All = New System.Windows.Forms.CheckBox
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 25)
        Me.Label1.TabIndex = 407
        Me.Label1.Text = "SALE REGISTER - MEMBERWISE"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(32, 16)
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
        Me.CmdPrint.Location = New System.Drawing.Point(352, 16)
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
        Me.cmdexit.Location = New System.Drawing.Point(520, 16)
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
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(216, 336)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(672, 64)
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
        Me.GroupBox3.Location = New System.Drawing.Point(216, 336)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(672, 64)
        Me.GroupBox3.TabIndex = 408
        Me.GroupBox3.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(152, 20)
        Me.mskFromDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(144, 26)
        Me.mskFromDate.TabIndex = 0
        Me.mskFromDate.Value = New Date(2009, 4, 11, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(368, 24)
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
        Me.mskToDate.Location = New System.Drawing.Point(472, 20)
        Me.mskToDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(144, 26)
        Me.mskToDate.TabIndex = 1
        Me.mskToDate.Value = New Date(2009, 4, 11, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 24)
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
        Me.CmdView.Location = New System.Drawing.Point(192, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 409
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Controls.Add(Me.CmdPrint)
        Me.GroupBox4.Controls.Add(Me.cmdexit)
        Me.GroupBox4.Controls.Add(Me.CmdView)
        Me.GroupBox4.Location = New System.Drawing.Point(224, 584)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(664, 56)
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
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 23)
        Me.Label5.TabIndex = 415
        Me.Label5.Text = "MEMBER CODE :"
        '
        'TXT_MCODE
        '
        Me.TXT_MCODE.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MCODE.Location = New System.Drawing.Point(456, 232)
        Me.TXT_MCODE.Name = "TXT_MCODE"
        Me.TXT_MCODE.Size = New System.Drawing.Size(184, 27)
        Me.TXT_MCODE.TabIndex = 416
        Me.TXT_MCODE.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(664, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 22)
        Me.Label6.TabIndex = 418
        Me.Label6.Text = "[F4]"
        '
        'Cmd_MCode
        '
        Me.Cmd_MCode.Image = CType(resources.GetObject("Cmd_MCode.Image"), System.Drawing.Image)
        Me.Cmd_MCode.Location = New System.Drawing.Point(640, 232)
        Me.Cmd_MCode.Name = "Cmd_MCode"
        Me.Cmd_MCode.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_MCode.TabIndex = 417
        '
        'LBL_MNAME
        '
        Me.LBL_MNAME.AutoSize = True
        Me.LBL_MNAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_MNAME.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_MNAME.ForeColor = System.Drawing.Color.IndianRed
        Me.LBL_MNAME.Location = New System.Drawing.Point(432, 136)
        Me.LBL_MNAME.Name = "LBL_MNAME"
        Me.LBL_MNAME.Size = New System.Drawing.Size(0, 23)
        Me.LBL_MNAME.TabIndex = 419
        '
        'Chk_All
        '
        Me.Chk_All.BackColor = System.Drawing.Color.Transparent
        Me.Chk_All.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_All.Location = New System.Drawing.Point(16, 288)
        Me.Chk_All.Name = "Chk_All"
        Me.Chk_All.Size = New System.Drawing.Size(160, 24)
        Me.Chk_All.TabIndex = 425
        Me.Chk_All.Text = "MISSING"
        Me.Chk_All.Visible = False
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Status.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Status.Location = New System.Drawing.Point(472, 223)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(0, 22)
        Me.lbl_Status.TabIndex = 426
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(336, 656)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(383, 18)
        Me.Label7.TabIndex = 429
        Me.Label7.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'SalesMemberwise
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(944, 694)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_MCODE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.Chk_All)
        Me.Controls.Add(Me.LBL_MNAME)
        Me.Controls.Add(Me.Cmd_MCode)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "SalesMemberwise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALE REGISTER "
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
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr, DR1, DR2 As DataRow
    Dim dblBasic, dblTax, dblNet, dblPaid As Double
    Private Sub Reportsform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
        grp_SalebillChecklist.Top = 1000
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        TXT_MCODE.Focus()
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
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            Call viewCashSaleregister()
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
        grp_SalebillChecklist.Top = 1000
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
        TXT_MCODE.Text = ""
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        TXT_MCODE.Focus()
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        If Chk_All.Checked = False Then
            Call viewCashSaleregister()
        Else
            Call viewCashSaleregister_MISSING()
        End If
    End Sub
    Public Sub viewCashSaleregister()
        Dim i As Integer
        Dim sqlstring = "SELECT isnull(kotno,'')as kotno,isnull(kotdate,'')as kotdate,isnull(itemcode,'')as itemcode,isnull(itemdesc,'')as itemdesc,isnull(qty,0)as qty,isnull(rate,0)as rate,isnull(amount,0)as amount,isnull(taxamt,0)as taxamt,isnull(totalamount,0)as totalamount,Ser_chg,packamount,isnull(mcode,'')as mcode,isnull(mname,'')as mname,isnull(scode,'') as scode FROM VIEWSALESMEMBERWISE WHERE MCODE = '" & Trim(TXT_MCODE.Text) & "' "
        sqlstring = sqlstring & " AND CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN '"
        sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND '" & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        sqlstring = sqlstring & " ORDER BY MCODE,kotno"
        Dim columnheading() As String = {"BILL DATE", "BILL NUMBER", "BASIC", "SALES TAX", "NET AMOUNT", "PAID AMOUNT", "RECEIPT NO", "BAL AMOUNT", "SERVER NAME"}
        Dim pageheading() As String = {"SALES REGISTER MEMBERWISE"}
        Dim colsize() As Integer = {14, 18, 8, 12, 12, 12, 15, 14, 30}
        Dim ObjCashSalesRegisterReport As New SalesMember
        ObjCashSalesRegisterReport.Reportdetails(vconn.sqlconnection, sqlstring, pageheading, columnheading, colsize, mskFromDate.Value, mskToDate.Value)
    End Sub
    Public Sub viewCashSaleregister_MISSING()
        Dim i As Integer
        '        Dim sqlstring = "SELECT * FROM POS_KOT_MISSING WHERE"
        '       sqlstring = sqlstring & " CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN '"
        '      sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND '" & Format(mskToDate.Value, "yyyy-MM-dd") & "' "
        '     sqlstring = sqlstring & " ORDER BY kot"

        Dim sqlstring = "SELECT KOT FROM POS_KOT_MISSING WHERE CAST(CONVERT(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN '"
        sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND '" & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        sqlstring = sqlstring & " GROUP BY kot"

        Dim columnheading() As String = {"BILL DATE", "BILL NUMBER", "BASIC", "SALES TAX", "NET AMOUNT", "PAID AMOUNT", "RECEIPT NO", "BAL AMOUNT", "SERVER NAME"}
        Dim pageheading() As String = {"MISSING KOTS"}
        Dim colsize() As Integer = {14, 18, 8, 12, 12, 12, 15, 14, 30}
        '        Dim ObjCashSalesRegisterReport As New MISSINGKOT
        Reportdetails(vconn.sqlconnection, sqlstring, pageheading, columnheading, colsize, mskFromDate.Value, mskToDate.Value)
    End Sub
    Public Function Reportdetails(ByVal CONN As String, ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal COLUMNHEAD() As String, ByVal SIZE() As Integer, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I, C, cc As Integer
        Dim STRSTRING As String
        Dim SQLSTR As String
        Dim NC As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Dim FROMNO As Integer
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "CREDITSALEREGISTER")
            If gdataset.Tables("CREDITSALEREGISTER").Rows.Count > 0 Then
                If pagesize > 58 Then
                    Filewrite.Write(StrDup(78, "-"))
                    Filewrite.Write(Chr(12))
                    pageno = pageno + 1
                    Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
                End If
                C = 0
                For Each dr In gdataset.Tables("CREDITSALEREGISTER").Rows
                    C = C + 1
                    SQLSTRING = "SELECT ISNULL(MIN(RIGHT(ISNULL(KOTDETAILS,''),2)),'') AS MINNO,ISNULL(MAX(RIGHT(ISNULL(KOTDETAILS,''),2)),'') AS MAXNO FROM KOT_HDR WHERE"
                    SQLSTRING = SQLSTRING & " KOTDETAILS LIKE '" & dr("KOT") & "%'"
                    gconnection.getDataSet(SQLSTRING, "LOOP1")
                    lbl_Status.Text = "Records...." & Trim(gdataset.Tables("CREDITSALEREGISTER").Rows.Count) & " / " & Trim(C) & "--->" & Trim(dr("KOT"))
                    lbl_Status.Refresh()
                    If Trim(gdataset.Tables("LOOP1").Rows(0).Item("MINNO")) <> "" Then
                        FROMNO = Val(gdataset.Tables("LOOP1").Rows(0).Item("MINNO"))
                        cc = 0
                        For I = Val(gdataset.Tables("LOOP1").Rows(0).Item("MINNO")) To Val(gdataset.Tables("LOOP1").Rows(0).Item("MAXNO"))
                            SQLSTRING = "SELECT KOTDETAILS AS KOTDETAILS FROM KOT_HDR WHERE"
                            SQLSTRING = SQLSTRING & " LTRIM(RTRIM(KOTDETAILS)) = '" & Trim(dr("KOT")) & Trim(Format(FROMNO, "00")) & "'"
                            'AND CAST(RIGHT(LTRIM(RTRIM(KOTDETAILS)),2) AS NUMERIC)=" & FROMNO
                            SQLSTRING = SQLSTRING & " ORDER BY kotDETAILS"
                            gconnection.getDataSet(SQLSTRING, "LOOP2")
                            If gdataset.Tables("LOOP2").Rows.Count <= 0 Then
                                NC = NC + 1
                                If NC <= 7 Then
                                    SQLSTR = SQLSTR & Space(1) & Mid(Trim(dr("KOT")) & Trim(Format(FROMNO, "00")), 1, 10) & Space(10 - Len(Mid(Trim(dr("KOT")) & Trim(Format(FROMNO, "00")), 1, 10)))
                                Else
                                    Filewrite.WriteLine(SQLSTR)
                                    pagesize = pagesize + 1
                                    SQLSTR = ""
                                    NC = 0
                                End If
                                cc = cc + 1
                                If pagesize > 58 Then
                                    Filewrite.Write(StrDup(78, "-"))
                                    Filewrite.Write(Chr(12))
                                    pageno = pageno + 1
                                    Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
                                End If
                            End If
                            FROMNO = FROMNO + 1
                        Next
                        If cc > 0 Then
                            NC = 0
                            If Trim(SQLSTR) <> "" Then
                                Filewrite.WriteLine(SQLSTR)
                                SQLSTR = ""
                                pagesize = pagesize + 1
                            End If
                            Filewrite.WriteLine()
                            pagesize = pagesize + 1
                        End If
                    End If
                Next dr
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If


            If gdataset.Tables("CREDITSALEREGISTER").Rows.Count > 0 Then
                C = 0
                Filewrite.WriteLine()
                Filewrite.WriteLine("SINGLE OCCURANCE.........")
                Filewrite.WriteLine()
                pagesize = pagesize + 3

                For Each DR2 In gdataset.Tables("CREDITSALEREGISTER").Rows
                    C = C + 1
                    lbl_Status.Text = "Records...." & Trim(gdataset.Tables("CREDITSALEREGISTER").Rows.Count) & " / " & Trim(C) & "--->" & Trim(DR2("KOT"))
                    lbl_Status.Refresh()
                    SQLSTRING = "SELECT KOTDETAILS FROM KOT_HDR WHERE"
                    SQLSTRING = SQLSTRING & " KOTDETAILS LIKE '" & DR2("KOT") & "%' group by kotdetails"
                    gconnection.getDataSet(SQLSTRING, "LOOP3")
                    If gdataset.Tables("LOOP3").Rows.Count <= 2 Then
                        NC = NC + 1
                        If NC <= 9 Then
                            SQLSTR = SQLSTR & Space(1) & Trim(DR2("KOT"))
                        Else
                            Filewrite.WriteLine(SQLSTR)
                            pagesize = pagesize + 1
                            SQLSTR = ""
                            NC = 0
                        End If
                        If pagesize > 58 Then
                            Filewrite.Write(StrDup(78, "-"))
                            Filewrite.Write(Chr(12))
                            pageno = pageno + 1
                            Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
                        End If
                    End If
                Next
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If

            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function PrintHeader(ByVal Heading() As String, ByVal colsize() As Integer, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            If pageno <= 1 Then
                Filewrite.WriteLine(Chr(18) & "{0,10}{1,15}{2,10}", " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-30}{1,17}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", " ")
                pagesize = pagesize + 1
            End If
            Filewrite.WriteLine(Chr(18) & "MISSING KOTS/SINGLE OCCURANCE                PAGE : " & Format(pageno, "000"))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("KOT NUMBER")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = True
        If Chk_All.Checked = False Then
            Call viewCashSaleregister()
        Else
            Call viewCashSaleregister_MISSING()
        End If
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub CashSalesRegister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
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
    Private Sub cmd_MCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_MCode.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT DISTINCT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "    MEMBER CODE     |             MEMBER NAME     "
        vform.vCaption = "MEMBER MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXT_MCODE.Text = Trim(vform.keyfield & "")
            Call TXT_MCODE_Validated(TXT_MCODE, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub TXT_MCODE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_MCODE.Validated
        If Trim(TXT_MCODE.Text) <> "" Then
            ssql = "SELECT ISNULL(MCODE,'')AS MCODE,ISNULL(MNAME,'')AS MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(TXT_MCODE.Text) & "'"
            vconn.getDataSet(ssql, "MEMBERMASTER")
            If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                TXT_MCODE.Text = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MCODE")
                LBL_MNAME.Text = gdataset.Tables("MEMBERMASTER").Rows(0).Item("MNAME")
                mskFromDate.Focus()
            Else
                MsgBox("NO MEMBER AVAILABLE")
            End If
        End If
    End Sub
    Private Sub TXT_MCODE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_MCODE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(TXT_MCODE.Text) = "" Then
                Call cmd_MCode_Click(sender, e)
            Else
                Call TXT_MCODE_Validated(TXT_MCODE, e)
            End If
        End If
    End Sub
End Class
