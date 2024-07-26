Imports System.Data.SqlClient
Public Class SalesBillChecklist1
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
    Friend WithEvents LstPOS As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LstServer As System.Windows.Forms.CheckedListBox
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SalesBillChecklist1))
        Me.LstPOS = New System.Windows.Forms.CheckedListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LstServer = New System.Windows.Forms.CheckedListBox
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox
        Me.Chk_SelectAllServer = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstPOS
        '
        Me.LstPOS.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstPOS.Location = New System.Drawing.Point(128, 128)
        Me.LstPOS.Name = "LstPOS"
        Me.LstPOS.Size = New System.Drawing.Size(336, 409)
        Me.LstPOS.TabIndex = 347
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(480, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 22)
        Me.Label4.TabIndex = 350
        Me.Label4.Text = "Server Code :"
        '
        'LstServer
        '
        Me.LstServer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstServer.Location = New System.Drawing.Point(600, 128)
        Me.LstServer.Name = "LstServer"
        Me.LstServer.Size = New System.Drawing.Size(336, 409)
        Me.LstServer.TabIndex = 348
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(128, 96)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.TabIndex = 360
        Me.Chk_SelectAllPos.Text = "Select All"
        '
        'Chk_SelectAllServer
        '
        Me.Chk_SelectAllServer.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllServer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllServer.Location = New System.Drawing.Point(600, 104)
        Me.Chk_SelectAllServer.Name = "Chk_SelectAllServer"
        Me.Chk_SelectAllServer.TabIndex = 361
        Me.Chk_SelectAllServer.Text = "Select All"
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
        Me.CmdClear.Location = New System.Drawing.Point(197, 632)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 383
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(517, 632)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 380
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(685, 632)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 382
        Me.cmdexit.Text = "Exit[F11]"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(141, 552)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 381
        Me.grp_SalebillChecklist.TabStop = False
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(141, 552)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 378
        Me.GroupBox3.TabStop = False
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(400, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "To Date :"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "From Date :"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(357, 632)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 379
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(141, 616)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox4.TabIndex = 384
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 385
        Me.Label2.Text = "POS Location :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 25)
        Me.Label3.TabIndex = 386
        Me.Label3.Text = "SALE BILL CHECKLIST"
        '
        'SalesBillChecklist1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(994, 688)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Chk_SelectAllServer)
        Me.Controls.Add(Me.Chk_SelectAllPos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LstPOS)
        Me.Controls.Add(Me.LstServer)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "SalesBillChecklist1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SalesBillCheckList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim ds As DataSet
    Dim chkbool As Boolean
    Dim da As New SqlDataAdapter
    Dim vconn As New GlobalClass
    Public Myconn As New SqlConnection
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        LstPOS.Items.Clear()
        LstServer.Items.Clear()
        grp_SalebillChecklist.Top = 1000
        Chk_SelectAllPos.Checked = False
        Chk_SelectAllServer.Checked = False
        Call FillPOS()
        Call FillServer()
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    '''******************************  To fill POS details from POSMaster  *******************************'''
    Private Sub FillPOS()
        Dim i As Integer
        LstPOS.Items.Clear()
        sqlstring = "SELECT DISTINCT poscode,posdesc FROM posmaster WHERE ISNULL(Freeze,'')<>'Y' "
        vconn.getDataSet(sqlstring, "POS")
        If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                With gdataset.Tables("POS").Rows(i)
                    LstPOS.Items.Add(Trim(.Item("POSdesc")))
                End With
            Next i
        End If
        LstPOS.Sorted = True
    End Sub
    '''*****************************  To fill Server details from ServerMaster  **************************'''
    Private Sub FillServer()
        Dim i As Integer
        LstServer.Items.Clear()
        sqlstring = "SELECT DISTINCT servercode, servername FROM servermaster WHERE ISNULL(Freeze,'') <> 'Y' "
        vconn.getDataSet(sqlstring, "Server")
        If gdataset.Tables("Server").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("Server").Rows.Count - 1
                With gdataset.Tables("Server").Rows(i)
                    LstServer.Items.Add(Trim(.Item("ServerCode") & "->" & .Item("servername")))
                End With
            Next i
        End If
        LstServer.Sorted = True
    End Sub
    Private Sub SalesBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillPOS()
        Call FillServer()
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
        grp_SalebillChecklist.Top = 1000
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        grp_SalebillChecklist.Top = 552
        grp_SalebillChecklist.Left = 141
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 100
        Me.Timer1.Enabled = True
    End Sub

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

    Private Sub Chk_SelectAllServer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllServer.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllServer.Checked = True Then
            For i = 0 To LstServer.Items.Count - 1
                LstServer.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To LstServer.Items.Count - 1
                LstServer.SetItemChecked(i, False)
            Next
        End If

    End Sub
    Private Function validatedate()
        chkbool = False
        If Format(mskFromDate.Value, "MM-dd-yyyy") > Format(Now.Today, "MM-dd-yyyy") Then
            MsgBox("From Date should less than Today Date", MsgBoxStyle.Information)
            mskFromDate.Text = ""
            mskFromDate.Focus()
            Exit Function
        End If
        If Format(mskFromDate.Value, "MM-dd-yyyy") < Format(CDate("01-Apr-" & gFinancalyearStart), "MM-dd-yyyy") Then
            MsgBox("From Date should  be in the Finacial Year", MsgBoxStyle.Information)
            mskFromDate.Text = ""
            mskFromDate.Focus()
            Exit Function
        End If
        If Format(mskFromDate.Value, "MM-dd-yyyy") > Format(mskToDate.Value, "MM-dd-yyyy") Then
            MsgBox("From Date should be Less than To date", MsgBoxStyle.Information)
            Exit Function
        End If
        If Format(mskToDate.Value, "MM-dd-yyyy") > Format(Now.Today, "MM-dd-yyyy") Then
            MsgBox("To Date should less be than Today Date", MsgBoxStyle.Information)
            mskToDate.Text = ""
            mskToDate.Focus()
            Exit Function
        End If
        If Format(mskToDate.Value, "MM-dd-yyyy") > Format("31-Mar-07", "MM-dd-yyyy") Then
            MsgBox("To Date should not be less than Finacial Year", MsgBoxStyle.Information)
            mskToDate.Text = ""
            mskToDate.Focus()
            Exit Function
        End If
        If Format(mskFromDate.Value, "MM-dd-yyyy") > Format(mskToDate.Value, "MM-dd-yyyy") Then
            MsgBox("From Date should be Less than To date", MsgBoxStyle.Information)
            Exit Function
        End If
        CmdView.Focus()
        chkbool = True
    End Function
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        gPrint = True
        CmdView_Click(sender, e)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            Call viewsalebillchecklist()
        End If
    End Sub

    Private Sub mskFromDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            mskToDate.Focus()
        End If
    End Sub

    Private Sub mskToDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            CmdView.Focus()
        End If
    End Sub
    Public Sub Viewsalebillchecklist()
        Try
            gPrint = False
            Dim posdesc() As String
            Dim servercode() As String
            Dim i As Integer
            Call validatedate() '''--> Check Validation
            If chkbool = False Then Exit Sub
            sqlstring = " SELECT P.POSDESC,BH.BILLDATE,BH.BILLDETAILS,KH.SERVERCODE,KD.ITEMCODE,I.ITEMDESC,KD.QTY,KD.RATE,KD.AMOUNT,KH.TOTAL,BH.billamount"
            sqlstring = sqlstring & " FROM BILL_HDR BH INNER JOIN BILL_DET BD ON BH.BILLDETAILS = BD.BILLDETAILS"
            sqlstring = sqlstring & " INNER JOIN KOT_DET KD ON BD.KOTDETAILS = KD.KOTDETAILS INNER JOIN KOT_HDR KH ON KD.KOTDETAILS = KH.KOTDETAILS"
            sqlstring = sqlstring & " INNER JOIN POSMASTER P ON KD.POSCODE = P.POSCODE INNER JOIN ITEMMASTER I ON KD.ITEMCODE = I.ITEMCODE"
            If LstPOS.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " WHERE P.POSDESC IN ("
                For i = 0 To LstPOS.CheckedItems.Count - 1
                    sqlstring = sqlstring & " '" & LstPOS.CheckedItems(i) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the POS Location(s)", "Calcutta Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If LstServer.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND KH.SERVERCODE IN ("
                For i = 0 To LstServer.CheckedItems.Count - 1
                    servercode = Split(LstServer.CheckedItems(i), "->")
                    sqlstring = sqlstring & servercode(0) & ", "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the Server(s)", "Calcutta Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            sqlstring = sqlstring & "AND BH.BILLDATE BETWEEN '"
            sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
            sqlstring = sqlstring & " ORDER BY P.POSDesc,BH.BillDetails, BH.BillDate"
            Dim arraystring() As String = {"BILL DATE", "BILL NO", "BASIC", "SERVER", "NET AMOUNT", "ITEM CODE", "ITEM DESC", "QTY", "RATE", "AMOUNT"}
            Dim heading() As String = {"SALES BILL CHECKLIST "}
            Dim colsize() As Integer = {12, 15, 10, 10, 10, 12, 25, 10, 10, 10}
            ' Dim SalesBillChecklist1Report As New SalesBillChecklist1Report
            'SalesBillChecklist1Report.begin()
            ' SalesBillChecklist1Report.buttonclick(vconn.sqlconnection, sqlstring, arraystring, heading, colsize, LstPOS, LstServer, mskFromDate.Value, mskToDate.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, "Calcutta Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
End Class