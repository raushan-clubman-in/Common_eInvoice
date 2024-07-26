Imports System.Data.SqlClient
Imports Excel
Public Class frmPartySaleregisterdatewise
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
    Friend WithEvents Chk_POSlocation As System.Windows.Forms.CheckBox
    Friend WithEvents Chklist_POSLocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chklist_membername As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_Selectmembername As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPartySaleregisterdatewise))
        Me.Chk_POSlocation = New System.Windows.Forms.CheckBox
        Me.Chklist_POSLocation = New System.Windows.Forms.CheckedListBox
        Me.Chklist_membername = New System.Windows.Forms.CheckedListBox
        Me.Chk_Selectmembername = New System.Windows.Forms.CheckBox
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chk_POSlocation
        '
        Me.Chk_POSlocation.BackColor = System.Drawing.Color.Transparent
        Me.Chk_POSlocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_POSlocation.Location = New System.Drawing.Point(625, 64)
        Me.Chk_POSlocation.Name = "Chk_POSlocation"
        Me.Chk_POSlocation.Size = New System.Drawing.Size(136, 27)
        Me.Chk_POSlocation.TabIndex = 14
        Me.Chk_POSlocation.Text = "SELECT ALL "
        '
        'Chklist_POSLocation
        '
        Me.Chklist_POSLocation.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chklist_POSLocation.Location = New System.Drawing.Point(625, 112)
        Me.Chklist_POSLocation.Name = "Chklist_POSLocation"
        Me.Chklist_POSLocation.Size = New System.Drawing.Size(344, 424)
        Me.Chklist_POSLocation.TabIndex = 15
        '
        'Chklist_membername
        '
        Me.Chklist_membername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chklist_membername.Location = New System.Drawing.Point(177, 112)
        Me.Chklist_membername.Name = "Chklist_membername"
        Me.Chklist_membername.Size = New System.Drawing.Size(344, 424)
        Me.Chklist_membername.TabIndex = 13
        '
        'Chk_Selectmembername
        '
        Me.Chk_Selectmembername.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Selectmembername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Selectmembername.Location = New System.Drawing.Point(179, 64)
        Me.Chk_Selectmembername.Name = "Chk_Selectmembername"
        Me.Chk_Selectmembername.Size = New System.Drawing.Size(128, 27)
        Me.Chk_Selectmembername.TabIndex = 12
        Me.Chk_Selectmembername.Text = "SELECT ALL "
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.Location = New System.Drawing.Point(353, 24)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(374, 25)
        Me.lbl_Heading.TabIndex = 16
        Me.lbl_Heading.Text = "PARTY SALE  REGISTER [DATE WISE ]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(256, 640)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 20
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(576, 640)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 22
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(744, 640)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 23
        Me.cmdexit.Text = "Exit[F11]"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(200, 560)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 19
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
        Me.CmdView.Location = New System.Drawing.Point(416, 640)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 21
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(200, 624)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        '
        'Timer1
        '
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(141, 1000)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 422
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(200, 680)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 423
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(176, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 24)
        Me.Label2.TabIndex = 424
        Me.Label2.Text = "MEMBER NAME  :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(624, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 24)
        Me.Label3.TabIndex = 425
        Me.Label3.Text = "POS LOCATION :"
        '
        'frmPartySaleregisterdatewise
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(994, 702)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Chk_POSlocation)
        Me.Controls.Add(Me.Chklist_POSLocation)
        Me.Controls.Add(Me.Chklist_membername)
        Me.Controls.Add(Me.Chk_Selectmembername)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmPartySaleregisterdatewise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PARTY SALE REGISTER DATE WISE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    '''******************************  To fill -->Call Fill Memberdetails from Membermaster  *******************************'''
    Private Sub FillMemberMaster()
        Dim i As Integer
        Dim sqlstring As String
        Chklist_membername.Items.Clear()
        'sqlstring = "SELECT DISTINCT MCODE,MNAME FROM MEMBERMASTER WHERE ISNULL(FREEZE,'')<>'Y' AND ISNULL(CRIDITNUMBER,'') = ''"
        sqlstring = "SELECT DISTINCT MCODE,MNAME FROM MEMBERMASTER WHERE ISNULL(MEMBERTYPECODE,'') <> 'EM'"
        vconn.getDataSet(sqlstring, "MEMBERMASTER")
        If gdataset.Tables("MEMBERMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("MEMBERMASTER").Rows.Count - 1
                With gdataset.Tables("MEMBERMASTER").Rows(i)
                    Chklist_membername.Items.Add(Trim(.Item("MNAME")) & "==>" & Trim(.Item("MCODE")))
                End With
            Next i
            Chklist_membername.Sorted = True
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

    Private Sub frmPartySaleregisterdatewise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillPOSLocation()
        Call FillMemberMaster()
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
        grp_SalebillChecklist.Top = 1000
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Chklist_POSLocation.Items.Clear()
        Chklist_membername.Items.Clear()
        grp_SalebillChecklist.Top = 1000
        Chk_POSlocation.Checked = False
        Chk_Selectmembername.Checked = False
        Call FillPOSLocation()
        Call FillMemberMaster()
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        If Chklist_membername.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Chklist_POSLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        grp_SalebillChecklist.Top = 560
        grp_SalebillChecklist.Left = 200
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 30
        Me.Timer1.Enabled = True
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        If Chklist_membername.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Chklist_POSLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = True
        grp_SalebillChecklist.Top = 568
        grp_SalebillChecklist.Left = 200
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 30
        Me.Timer1.Enabled = True
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


    Private Sub Chk_Selectmembername_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Selectmembername.CheckedChanged
        Dim i As Integer
        If Chk_Selectmembername.Checked = True Then
            For i = 0 To Chklist_membername.Items.Count - 1
                Chklist_membername.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_membername.Items.Count - 1
                Chklist_membername.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub ViewPartySaleregisterdatewise()
        Dim MemberCode() As String
        Dim i As Integer
        Dim SQLSTRING2 As String
        Try
            Dim sqlstring = "SELECT * FROM VIEWPARTYSALEREPORT_DATEWISE"
            If Chklist_membername.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " WHERE MCODE IN ("
                For i = 0 To Chklist_membername.CheckedItems.Count - 1
                    MemberCode = Split(Chklist_membername.CheckedItems(i), "==>")
                    sqlstring = sqlstring & "'" & MemberCode(1) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            '===========================
            ''If Chklist_POSLocation.CheckedItems.Count <> 0 Then
            ''    sqlstring = sqlstring & " AND POSDESC IN ("
            ''    For i = 0 To Chklist_POSLocation.CheckedItems.Count - 1
            ''        sqlstring = sqlstring & " '" & Chklist_POSLocation.CheckedItems(i) & "', "
            ''    Next
            ''    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            ''    sqlstring = sqlstring & ")"
            ''Else
            ''    MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ''    Exit Sub
            ''End If
            '===========================
            ''sqlstring = sqlstring & " AND PAYMENTMODE ='PARTY' AND CAST(Convert(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN "
            sqlstring = sqlstring & "  AND CAST(Convert(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN "
            sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"
            sqlstring = sqlstring & " ORDER BY BILLDATE,MCODE,MNAME,BILLDETAILS"
            ''=======TOTAL CALCULATION==========
            ''SQLSTRING2 = "SELECT BILLDATE,SUM(BASIC) AS BASICTOT,SUM(TAXAMOUNT) AS TAXTOT,SUM(NETAMOUNT) AS NETTOT,SUM(PAIDAMT) AS PAIDAMTTOT FROM VIEWPARTYSALEREPORT_DATEWISE"
            ''''''SQLSTRING2 = "SELECT A.BILLDATE,SUM(A.BASIC) AS BASICTOT,SUM(A.TAXAMOUNT) AS TAXTOT,SUM(A.NETAMOUNT) AS NETAMOUNT"
            ''''''SQLSTRING2 = SQLSTRING2 & " FROM  (SELECT DISTINCT MCODE,BILLDATE,BILLDETAILS,BASIC,TAXAMOUNT,NETAMOUNT"
            ''''''SQLSTRING2 = SQLSTRING2 & " FROM VIEWPARTYSALEREPORT_DATEWISE) A "

            ''If Chklist_membername.CheckedItems.Count <> 0 Then
            ''    SQLSTRING2 = SQLSTRING2 & " WHERE A.MCODE IN ("
            ''    For i = 0 To Chklist_membername.CheckedItems.Count - 1
            ''        MemberCode = Split(Chklist_membername.CheckedItems(i), "==>")
            ''        SQLSTRING2 = SQLSTRING2 & " '" & MemberCode(1) & "', "
            ''    Next
            ''    SQLSTRING2 = Mid(SQLSTRING2, 1, Len(SQLSTRING2) - 2)
            ''    SQLSTRING2 = SQLSTRING2 & ")"
            ''Else
            ''    MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ''    Exit Sub
            ''End If
            ''SQLSTRING2 = SQLSTRING2 & "  AND CAST(Convert(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN "
            ''SQLSTRING2 = SQLSTRING2 & " '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"
            ''SQLSTRING2 = SQLSTRING2 & " GROUP BY A.BILLDATE,A.MCODE"
            ''SQLSTRING2 = SQLSTRING2 & " ORDER BY A.BILLDATE"
            ''==================================
            Dim pageheading() As String = {"DATEWISE PARTY SALES REPORT"}
            Dim objrptPartysaleregisterdatewise As New rptPartysaleregisterdatewise
            objrptPartysaleregisterdatewise.Reportdetails(sqlstring, SQLSTRING2, pageheading, mskFromDate.Value, mskToDate.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            Call ViewPartySaleregisterdatewise()
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

    Private Sub frmPartySaleregisterdatewise_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        Dim Search As String
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            For i = 0 To Chklist_membername.Items.Count - 1
                Chklist_membername.SetItemChecked(i, True)
            Next i
            Chk_Selectmembername.Checked = True
            For i = 0 To Chklist_POSLocation.Items.Count - 1
                Chklist_POSLocation.SetItemChecked(i, True)
            Next i
            Chk_POSlocation.Checked = True
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
            If Chklist_membername.SelectedIndex = 0 Then
                Call Search_Item(Chklist_membername, Search)
            ElseIf Chklist_POSLocation.SelectedIndex = 0 Then
                Call Search_Item(Chklist_POSLocation, Search)
            End If
        End If
    End Sub
    Private Sub Chk_Selectmembername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_Selectmembername.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chklist_membername.Focus()
        End If
    End Sub

    Private Sub Chklist_membername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chklist_membername.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chk_POSlocation.Focus()
        End If
    End Sub

    Private Sub Chk_POSlocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_POSlocation.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chklist_POSLocation.Focus()
        End If
    End Sub

    Private Sub Chklist_POSLocation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chklist_POSLocation.KeyDown
        If e.KeyCode = Keys.Enter Then
            mskFromDate.Focus()
        End If
    End Sub
End Class
