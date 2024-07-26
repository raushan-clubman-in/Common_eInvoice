Imports System.Data.SqlClient
Public Class SaleBillItemwiseRegister
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LstPOS As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents grp_Salebillitemwise As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents chkItemwiseregister As System.Windows.Forms.CheckBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_SelectAllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents LstGroup As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_Group As System.Windows.Forms.Label
    Friend WithEvents Lstitemcode As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chkitemcode As System.Windows.Forms.CheckBox
    Friend WithEvents grp_itemcode As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SaleBillItemwiseRegister))
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LstPOS = New System.Windows.Forms.CheckedListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.grp_Salebillitemwise = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.chkItemwiseregister = New System.Windows.Forms.CheckBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Chkitemcode = New System.Windows.Forms.CheckBox
        Me.Chk_SelectAllGroup = New System.Windows.Forms.CheckBox
        Me.LstGroup = New System.Windows.Forms.CheckedListBox
        Me.lbl_Group = New System.Windows.Forms.Label
        Me.Lstitemcode = New System.Windows.Forms.CheckedListBox
        Me.grp_itemcode = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.grp_Salebillitemwise.SuspendLayout()
        Me.grp_itemcode.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(168, 96)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.TabIndex = 0
        Me.Chk_SelectAllPos.Text = "Select All"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From Date :"
        '
        'LstPOS
        '
        Me.LstPOS.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstPOS.Location = New System.Drawing.Point(168, 128)
        Me.LstPOS.Name = "LstPOS"
        Me.LstPOS.Size = New System.Drawing.Size(328, 361)
        Me.LstPOS.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "POS Location :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mskFromDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mskToDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(200, 552)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(184, 24)
        Me.mskFromDate.MaxDate = New Date(2010, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(144, 26)
        Me.mskFromDate.TabIndex = 0
        Me.mskFromDate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "To Date :"
        '
        'mskToDate
        '
        Me.mskToDate.CustomFormat = "dd-MM-yyyy"
        Me.mskToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskToDate.Location = New System.Drawing.Point(504, 24)
        Me.mskToDate.MaxDate = New Date(2010, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(144, 26)
        Me.mskToDate.TabIndex = 1
        Me.mskToDate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'grp_Salebillitemwise
        '
        Me.grp_Salebillitemwise.BackgroundImage = CType(resources.GetObject("grp_Salebillitemwise.BackgroundImage"), System.Drawing.Image)
        Me.grp_Salebillitemwise.Controls.Add(Me.lbl_Wait)
        Me.grp_Salebillitemwise.Controls.Add(Me.ProgressBar1)
        Me.grp_Salebillitemwise.Location = New System.Drawing.Point(200, 552)
        Me.grp_Salebillitemwise.Name = "grp_Salebillitemwise"
        Me.grp_Salebillitemwise.Size = New System.Drawing.Size(712, 64)
        Me.grp_Salebillitemwise.TabIndex = 10
        Me.grp_Salebillitemwise.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(376, 24)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 18)
        Me.lbl_Wait.TabIndex = 0
        '
        'chkItemwiseregister
        '
        Me.chkItemwiseregister.BackColor = System.Drawing.Color.Transparent
        Me.chkItemwiseregister.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItemwiseregister.Location = New System.Drawing.Point(464, 512)
        Me.chkItemwiseregister.Name = "chkItemwiseregister"
        Me.chkItemwiseregister.Size = New System.Drawing.Size(128, 24)
        Me.chkItemwiseregister.TabIndex = 4
        Me.chkItemwiseregister.Text = "Costing [Y/N]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(256, 632)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 11
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(576, 632)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 9
        Me.CmdPrint.Text = " Print [F8]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(416, 632)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 8
        Me.CmdView.Text = "View [F9]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(744, 632)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 10
        Me.cmdexit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(200, 616)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SALE KOT REGISTER [ ITEM WISE ]"
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(200, 512)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(128, 24)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Details [Y/N]"
        '
        'Chkitemcode
        '
        Me.Chkitemcode.BackColor = System.Drawing.Color.Transparent
        Me.Chkitemcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkitemcode.Location = New System.Drawing.Point(728, 512)
        Me.Chkitemcode.Name = "Chkitemcode"
        Me.Chkitemcode.Size = New System.Drawing.Size(160, 24)
        Me.Chkitemcode.TabIndex = 6
        Me.Chkitemcode.Text = "Item Code Wise"
        '
        'Chk_SelectAllGroup
        '
        Me.Chk_SelectAllGroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllGroup.Location = New System.Drawing.Point(632, 96)
        Me.Chk_SelectAllGroup.Name = "Chk_SelectAllGroup"
        Me.Chk_SelectAllGroup.TabIndex = 2
        Me.Chk_SelectAllGroup.Text = "Select All"
        '
        'LstGroup
        '
        Me.LstGroup.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstGroup.Location = New System.Drawing.Point(632, 128)
        Me.LstGroup.Name = "LstGroup"
        Me.LstGroup.Size = New System.Drawing.Size(296, 361)
        Me.LstGroup.TabIndex = 3
        '
        'lbl_Group
        '
        Me.lbl_Group.AutoSize = True
        Me.lbl_Group.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Group.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Group.Location = New System.Drawing.Point(512, 136)
        Me.lbl_Group.Name = "lbl_Group"
        Me.lbl_Group.Size = New System.Drawing.Size(99, 22)
        Me.lbl_Group.TabIndex = 15
        Me.lbl_Group.Text = "Group Desc :"
        '
        'Lstitemcode
        '
        Me.Lstitemcode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lstitemcode.Location = New System.Drawing.Point(16, 24)
        Me.Lstitemcode.Name = "Lstitemcode"
        Me.Lstitemcode.Size = New System.Drawing.Size(296, 412)
        Me.Lstitemcode.TabIndex = 16
        '
        'grp_itemcode
        '
        Me.grp_itemcode.BackgroundImage = CType(resources.GetObject("grp_itemcode.BackgroundImage"), System.Drawing.Image)
        Me.grp_itemcode.Controls.Add(Me.Lstitemcode)
        Me.grp_itemcode.Location = New System.Drawing.Point(344, 88)
        Me.grp_itemcode.Name = "grp_itemcode"
        Me.grp_itemcode.Size = New System.Drawing.Size(336, 456)
        Me.grp_itemcode.TabIndex = 17
        Me.grp_itemcode.TabStop = False
        '
        'SaleBillItemwiseRegister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(990, 684)
        Me.ControlBox = False
        Me.Controls.Add(Me.grp_itemcode)
        Me.Controls.Add(Me.Chk_SelectAllGroup)
        Me.Controls.Add(Me.LstGroup)
        Me.Controls.Add(Me.lbl_Group)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chkitemcode)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.chkItemwiseregister)
        Me.Controls.Add(Me.grp_Salebillitemwise)
        Me.Controls.Add(Me.Chk_SelectAllPos)
        Me.Controls.Add(Me.LstPOS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "SaleBillItemwiseRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaleBillItemwiseRegister"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.grp_Salebillitemwise.ResumeLayout(False)
        Me.grp_itemcode.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ssql As String
    Public Myconn As New SqlConnection
    Dim ds As DataSet
    Dim chkbool As Boolean
    Dim da As New SqlDataAdapter
    Dim vconn As New GlobalClass
   
    Private Sub FillPOS()   '''***************************** To fill POS details from POSMaster  *****************'''
        LstPOS.Items.Clear()
        Dim i As Integer
        ssql = "SELECT DISTINCT poscode,posdesc FROM PosMaster "
        vconn.getDataSet(ssql, "Pos")
        If gdataset.Tables("Pos").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("Pos").Rows.Count - 1
                With gdataset.Tables("Pos").Rows(i)
                    LstPOS.Items.Add(Trim(.Item("POSdesc")))
                End With
            Next i
        End If
        LstPOS.Sorted = True
    End Sub
    Private Sub FillGroup()   '''***************************** To fill Group details from GroupMaster  *****************'''
        LstGroup.Items.Clear()
        Dim i As Integer
        ssql = "SELECT DISTINCT Groupcode,Groupdesc FROM GroupMaster "
        vconn.getDataSet(ssql, "GroupMaster")
        If gdataset.Tables("GroupMaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("GroupMaster").Rows.Count - 1
                With gdataset.Tables("GroupMaster").Rows(i)
                    LstGroup.Items.Add(Trim(.Item("Groupcode") & "-->" & .Item("Groupdesc")))
                End With
            Next
        End If
    End Sub

    Private Function validatedate()
        chkbool = False
        If Format(mskFromDate.Value, "MM-dd-yyyy") > Format(Now.Today, "MM-dd-yyyy") Then
            MsgBox("From Date should less than Today Date", MsgBoxStyle.Information, "Calcutta Swimming Club")
            mskFromDate.Text = ""
            mskFromDate.Focus()
            Exit Function
        End If
        If Format(mskFromDate.Value, "MM-dd-yyyy") < Format(CDate("01-Apr-" & gFinancalyearStart), "MM-dd-yyyy") Then
            MsgBox("From Date should  be in the Finacial Year", MsgBoxStyle.Information, "Calcutta Swimming Club")
            mskFromDate.Text = ""
            mskFromDate.Focus()
            Exit Function
        End If
        If Format(mskFromDate.Value, "MM-dd-yyyy") > Format(mskToDate.Value, "MM-dd-yyyy") Then
            MsgBox("From Date should be Less than To date", MsgBoxStyle.Information, "Calcutta Swimming Club")
            Exit Function
        End If
        If Format(mskToDate.Value, "MM-dd-yyyy") > Format(Now.Today, "MM-dd-yyyy") Then
            MsgBox("To Date should less be than Today Date", MsgBoxStyle.Information, "Calcutta Swimming Club")
            mskToDate.Text = ""
            mskToDate.Focus()
            Exit Function
        End If
        If Format(mskToDate.Value, "MM-dd-yyyy") > Format("31-Mar-07", "MM-dd-yyyy") Then
            MsgBox("To Date should not be less than Finacial Year", MsgBoxStyle.Information, "Calcutta Swimming Club")
            mskToDate.Text = ""
            mskToDate.Focus()
            Exit Function
        End If
        If Format(mskFromDate.Value, "MM-dd-yyyy") > Format(mskToDate.Value, "MM-dd-yyyy") Then
            MsgBox("From Date should be Less than To date", MsgBoxStyle.Information, "Calcutta Swimming Club")
            Exit Function
        End If
        CmdView.Focus()
        chkbool = True
    End Function
    Private Sub Chk_SelectAllPos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllPos.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllPos.Checked = True Then
            For i = 0 To LstPOS.Items.Count - 1
                LstPOS.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To LstPOS.Items.Count - 1
                LstPOS.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub SaleBillItemwiseRegister_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlstring As String
        Dim x As String
        Call FillPOS()
        Call FillGroup()
        grp_Salebillitemwise.Top = 1000
        mskFromDate.Value = Format(Now, "dd-MM-yyyy")
        mskToDate.Value = Format(Now, "dd-MM-yyyy")
        grp_itemcode.Top = 1000
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_Salebillitemwise.Top = 1000
            Call itemwisesaleregister()
        End If
    End Sub
    Private Sub itemwisesaleregister()
        Dim i As Integer
        Dim posdesc(), groupcode(), itemcode(), sqlstring As String
        Call validatedate() '''--> Check Validation
        If chkbool = False Then Exit Sub
        If Chkitemcode.Checked = True Then
            If chkItemwiseregister.Checked = True Then
                sqlstring = " SELECT G.GROUPDESC AS GROUPDESC,K.ITEMCODE ,I.ITEMDESC ,ISNULL(R.PURCAHSERATE,0) AS PURCHASERATE,"
                sqlstring = sqlstring & " P.POSDESC AS POSDESC,SUM(K.QTY) AS QTY,K.UOM  FROM KOT_DET AS K"
                sqlstring = sqlstring & " INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = K.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = K.GROUPCODE "
                sqlstring = sqlstring & " INNER JOIN RATEMASTER AS R ON R.ITEMCODE = K.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = K.POSCODE "
                If LstPOS.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE P.POSDESC IN ("
                    For i = 0 To LstPOS.CheckedItems.Count - 1
                        posdesc = Split(LstPOS.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & posdesc(0) & "', "
                    Next i
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                    Exit Sub
                End If
                If LstGroup.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND K.GROUPCODE IN ("
                    For i = 0 To LstGroup.CheckedItems.Count - 1
                        groupcode = Split(LstGroup.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & groupcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                    Exit Sub
                End If
                If Lstitemcode.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND K.ITEMCODE IN ("
                    For i = 0 To Lstitemcode.CheckedItems.Count - 1
                        itemcode = Split(Lstitemcode.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & itemcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the ItemCode(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                    Exit Sub
                End If
                sqlstring = sqlstring & " AND ISNULL(R.ENDINGDATE,'')='' AND CAST(Convert(varchar(11),K.KOTDATE,6) AS DATETIME) BETWEEN '"
                sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                sqlstring = sqlstring & " GROUP BY GROUPDESC,I.ITEMDESC,K.ITEMCODE,R.PURCAHSERATE,POSDESC,K.UOM ORDER BY GROUPDESC,I.ITEMDESC "
                Dim arraystring() As String = {"GROUP/ITEM/", "LOCATION", "PURCHASE", "TOTAL"}
                Dim heading() As String = {"SALES KOT REGISTER [ITEM WISE]", posdesc(0)}
                Dim colsize() As Integer = {20, 20, 20, 20}
                Dim SalepurchaserateReport As New SaleItemwiseRegisterpurchaserate
                SalepurchaserateReport.begin()
                SalepurchaserateReport.buttonclick(vconn.sqlconnection, sqlstring, heading, arraystring, colsize, LstPOS, mskFromDate.Value, mskToDate.Value)
            Else
                sqlstring = " SELECT K.KOTDETAILS AS KOTDETAILS, K.KOTDATE AS KOTDATE, K.ITEMCODE AS ITEMCODE, I.ITEMDESC AS ITEMDESC,"
                sqlstring = sqlstring & " K.UOM AS UOM,K.POSCODE AS POSCODE,K.QTY AS QTY,K.RATE AS RATE,K.AMOUNT AS AMOUNT,"
                sqlstring = sqlstring & " G.GROUPDESC AS GROUPDESC,P.POSDESC AS POSDESC FROM  KOT_DET AS K INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = K.ITEMCODE"
                sqlstring = sqlstring & " INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = K.GROUPCODE INNER JOIN  POSMASTER AS P ON  P.POSCODE= K.POSCODE "
                If LstPOS.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE P.POSDESC IN ("
                    For i = 0 To LstPOS.CheckedItems.Count - 1
                        posdesc = Split(LstPOS.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & posdesc(0) & "', "
                    Next i
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                    Exit Sub
                End If
                If LstGroup.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND G.GROUPCODE IN ("
                    For i = 0 To LstGroup.CheckedItems.Count - 1
                        groupcode = Split(LstGroup.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & groupcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                    Exit Sub
                End If
                If Lstitemcode.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND K.ITEMCODE IN ("
                    For i = 0 To Lstitemcode.CheckedItems.Count - 1
                        itemcode = Split(Lstitemcode.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & itemcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the ItemCode(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                    Exit Sub
                End If
                sqlstring = sqlstring & "AND CAST(Convert(varchar(11),K.KOTDATE,6) AS DATETIME) BETWEEN '"
                sqlstring = sqlstring & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"
                sqlstring = sqlstring & "GROUP BY P.POSDESC,G.GROUPDESC,I.ITEMDESC,K.KOTDETAILS,K.KOTDATE,K.ITEMCODE,K.UOM,K.POSCODE,K.QTY,K.RATE,K.AMOUNT "
                sqlstring = sqlstring & "ORDER BY G.GROUPDESC, K.ITEMDESC,K.KOTDETAILS"
                Dim arraystring() As String = {"GROUP/ITEM/", " KOT ", "QTY", "UOM", "RATE", " NET ", "LOCATION", "DATE", "NUMBER", "AMOUNT"}
                Dim heading() As String = {"SALES KOT REGISTER [ITEM WISE]", posdesc(0)}
                Dim colsize() As Integer = {15, 10, 15, 10, 10, 10, 10}
                Dim SalesItemwiseRegisterReport As New SaleItemwiseRegister2
                SalesItemwiseRegisterReport.begin()
                SalesItemwiseRegisterReport.buttonclick(vconn.sqlconnection, sqlstring, arraystring, heading, colsize, LstPOS, mskFromDate.Value, mskToDate.Value)
            End If
        Else
            If chkItemwiseregister.Checked = True Then
                sqlstring = " SELECT G.GROUPDESC AS GROUPDESC,K.ITEMCODE ,I.ITEMDESC ,ISNULL(R.PURCAHSERATE,0) AS PURCHASERATE,"
                sqlstring = sqlstring & " P.POSDESC AS POSDESC,SUM(K.QTY) AS QTY,K.UOM  FROM KOT_DET AS K"
                sqlstring = sqlstring & " INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = K.ITEMCODE INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = K.GROUPCODE "
                sqlstring = sqlstring & " INNER JOIN RATEMASTER AS R ON R.ITEMCODE = K.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = K.POSCODE "
                If LstPOS.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE P.POSDESC IN ("
                    For i = 0 To LstPOS.CheckedItems.Count - 1
                        posdesc = Split(LstPOS.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & posdesc(0) & "', "
                    Next i
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                    Exit Sub
                End If
                If LstGroup.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND K.GROUPCODE IN ("
                    For i = 0 To LstGroup.CheckedItems.Count - 1
                        groupcode = Split(LstGroup.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & groupcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                    Exit Sub
                End If
                sqlstring = sqlstring & " AND ISNULL(R.ENDINGDATE,'')='' AND CAST(Convert(varchar(11),K.KOTDATE,6) AS DATETIME) BETWEEN '"
                sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                sqlstring = sqlstring & " GROUP BY GROUPDESC,I.ITEMDESC,K.ITEMCODE,R.PURCAHSERATE,POSDESC,K.UOM ORDER BY GROUPDESC,I.ITEMDESC "
                Dim arraystring() As String = {"GROUP/ITEM/", "LOCATION", "PURCHASE", "TOTAL"}
                Dim heading() As String = {"SALES KOT REGISTER [ITEM WISE]", posdesc(0)}
                Dim colsize() As Integer = {20, 20, 20, 20}
                Dim SalepurchaserateReport As New SaleItemwiseRegisterpurchaserate
                SalepurchaserateReport.begin()
                SalepurchaserateReport.buttonclick(vconn.sqlconnection, sqlstring, heading, arraystring, colsize, LstPOS, mskFromDate.Value, mskToDate.Value)
            Else
                sqlstring = " SELECT K.KOTDETAILS AS KOTDETAILS, K.KOTDATE AS KOTDATE, K.ITEMCODE AS ITEMCODE, I.ITEMDESC AS ITEMDESC,"
                sqlstring = sqlstring & " K.UOM AS UOM,K.POSCODE AS POSCODE,K.QTY AS QTY,K.RATE AS RATE,K.AMOUNT AS AMOUNT,"
                sqlstring = sqlstring & " G.GROUPDESC AS GROUPDESC,P.POSDESC AS POSDESC FROM  KOT_DET AS K INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = K.ITEMCODE"
                sqlstring = sqlstring & " INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = K.GROUPCODE INNER JOIN  POSMASTER AS P ON  P.POSCODE= K.POSCODE "
                If LstPOS.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE P.POSDESC IN ("
                    For i = 0 To LstPOS.CheckedItems.Count - 1
                        posdesc = Split(LstPOS.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & posdesc(0) & "', "
                    Next i
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                    Exit Sub
                End If
                If LstGroup.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " AND G.GROUPCODE IN ("
                    For i = 0 To LstGroup.CheckedItems.Count - 1
                        groupcode = Split(LstGroup.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & groupcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                    Exit Sub
                End If
                sqlstring = sqlstring & "AND CAST(Convert(varchar(11),K.KOTDATE,6) AS DATETIME) BETWEEN '"
                sqlstring = sqlstring & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"
                sqlstring = sqlstring & "GROUP BY P.POSDESC,G.GROUPDESC,I.ITEMDESC,K.KOTDETAILS,K.KOTDATE,K.ITEMCODE,K.UOM,K.POSCODE,K.QTY,K.RATE,K.AMOUNT "
                sqlstring = sqlstring & "ORDER BY G.GROUPDESC, K.ITEMDESC,K.KOTDETAILS"
                Dim arraystring() As String = {"GROUP/ITEM/", " KOT ", "QTY", "UOM", "RATE", " NET ", "LOCATION", "DATE", "NUMBER", "AMOUNT"}
                Dim heading() As String = {"SALES KOT REGISTER [ITEM WISE]", posdesc(0)}
                Dim colsize() As Integer = {15, 10, 15, 10, 10, 10, 10}
                Dim SalesItemwiseRegisterReport As New SaleItemwiseRegister2
                SalesItemwiseRegisterReport.begin()
                SalesItemwiseRegisterReport.buttonclick(vconn.sqlconnection, sqlstring, arraystring, heading, colsize, LstPOS, mskFromDate.Value, mskToDate.Value)
            End If
        End If
       
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        LstPOS.Items.Clear()
        LstGroup.Items.Clear()
        Lstitemcode.Items.Clear()
        Chkitemcode.Checked = False
        grp_itemcode.Top = 1000
        Call FillGroup()
        Call FillPOS()
        mskFromDate.Value = Format(Now, "dd-MM-yyyy")
        mskToDate.Value = Format(Now, "dd-MM-yyyy")
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Call validatedate() '''--> Check Validation
        If chkbool = False Then Exit Sub
        grp_itemcode.Top = 1000
        grp_Salebillitemwise.Top = 552
        grp_Salebillitemwise.Left = 200
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 100
        Me.Timer1.Enabled = True
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        gPrint = True
        Call CmdView_Click(sender, e)
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub LstPOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstPOS.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Chk_SelectAllGroup.Focus()
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

    Private Sub Chk_SelectAllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllGroup.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllGroup.Checked = True Then
            For i = 0 To LstGroup.Items.Count - 1
                LstGroup.SetItemChecked(i, True)
            Next i
        Else
            For i = 0 To LstGroup.Items.Count - 1
                LstGroup.SetItemChecked(i, False)
            Next i
        End If
    End Sub

    Private Sub Chk_SelectAllPos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Chk_SelectAllPos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            LstPOS.Focus()
        End If
    End Sub

    Private Sub Chk_SelectAllGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Chk_SelectAllGroup.KeyPress
        If Asc(e.KeyChar) = 13 Then
            LstGroup.Focus()
        End If
    End Sub

    Private Sub LstGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstGroup.KeyPress
        If Asc(e.KeyChar) = 13 Then
            mskFromDate.Focus()
        End If
    End Sub

   
    Private Sub Chkitemcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkitemcode.CheckedChanged
        If Chkitemcode.Checked = True Then
            Dim groupcode(), posdesc() As String
            Dim i As Integer
            Lstitemcode.Items.Clear()
            grp_itemcode.Top = 88
            grp_itemcode.Left = 344
            ssql = "SELECT DISTINCT I.ITEMCODE,I.ITEMDESC FROM ITEMMASTER AS I"
            ssql = ssql & " INNER JOIN POSMENULINK P ON I.ITEMCODE = P.ITEMCODE"
            ssql = ssql & " INNER JOIN POSMASTER M ON M.POSCODE = P.POS WHERE "
            If LstGroup.CheckedItems.Count <> 0 Then
                ssql = ssql & " I.GROUPCODE IN ("
                For i = 0 To LstGroup.CheckedItems.Count - 1
                    groupcode = Split(LstGroup.CheckedItems(i), "-->")
                    ssql = ssql & " '" & groupcode(0) & "', "
                Next
                ssql = Mid(ssql, 1, Len(ssql) - 2)
                ssql = ssql & ")"
            Else
                MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                Exit Sub
            End If
            If LstPOS.CheckedItems.Count <> 0 Then
                ssql = ssql & " AND M.POSDESC IN ("
                For i = 0 To LstPOS.CheckedItems.Count - 1
                    posdesc = Split(LstPOS.CheckedItems(i), "-->")
                    ssql = ssql & " '" & posdesc(0) & "', "
                Next i
                ssql = Mid(ssql, 1, Len(ssql) - 2)
                ssql = ssql & ")"
            Else
                MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "Calcutta Swimming Club")
                Exit Sub
            End If
            vconn.getDataSet(ssql, "Itemmaster")
            If gdataset.Tables("Itemmaster").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("Itemmaster").Rows.Count - 1
                    With gdataset.Tables("Itemmaster").Rows(i)
                        Lstitemcode.Items.Add(Trim(.Item("ITEMCODE") & "-->" & .Item("ITEMDESC")))
                    End With
                Next i
            End If
            Lstitemcode.Sorted = True
        End If
    End Sub
End Class
