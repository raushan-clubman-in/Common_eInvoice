Public Class frmCreditSalesregister
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
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_Membername As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_POSlocation As System.Windows.Forms.CheckBox
    Friend WithEvents chklist_POSlocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents chklist_Membername As System.Windows.Forms.CheckedListBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCreditSalesregister))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Chk_Membername = New System.Windows.Forms.CheckBox
        Me.Chk_POSlocation = New System.Windows.Forms.CheckBox
        Me.chklist_POSlocation = New System.Windows.Forms.CheckedListBox
        Me.chklist_Membername = New System.Windows.Forms.CheckedListBox
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 25)
        Me.Label3.TabIndex = 393
        Me.Label3.Text = "CREDIT SALE REGISTER"
        '
        'Chk_Membername
        '
        Me.Chk_Membername.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Membername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Membername.Location = New System.Drawing.Point(641, 80)
        Me.Chk_Membername.Name = "Chk_Membername"
        Me.Chk_Membername.Size = New System.Drawing.Size(141, 24)
        Me.Chk_Membername.TabIndex = 391
        Me.Chk_Membername.Text = "SELECT ALL"
        '
        'Chk_POSlocation
        '
        Me.Chk_POSlocation.BackColor = System.Drawing.Color.Transparent
        Me.Chk_POSlocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_POSlocation.Location = New System.Drawing.Point(154, 80)
        Me.Chk_POSlocation.Name = "Chk_POSlocation"
        Me.Chk_POSlocation.Size = New System.Drawing.Size(132, 24)
        Me.Chk_POSlocation.TabIndex = 390
        Me.Chk_POSlocation.Text = "SELECT ALL"
        '
        'chklist_POSlocation
        '
        Me.chklist_POSlocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_POSlocation.Location = New System.Drawing.Point(152, 128)
        Me.chklist_POSlocation.Name = "chklist_POSlocation"
        Me.chklist_POSlocation.Size = New System.Drawing.Size(336, 382)
        Me.chklist_POSlocation.TabIndex = 387
        '
        'chklist_Membername
        '
        Me.chklist_Membername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_Membername.Location = New System.Drawing.Point(640, 128)
        Me.chklist_Membername.Name = "chklist_Membername"
        Me.chklist_Membername.Size = New System.Drawing.Size(336, 382)
        Me.chklist_Membername.TabIndex = 388
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
        Me.CmdClear.TabIndex = 399
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
        Me.CmdPrint.TabIndex = 396
        Me.CmdPrint.Text = " Print [F8]"
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
        Me.cmdexit.TabIndex = 398
        Me.cmdexit.Text = "Exit[F11]"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(200, 552)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 397
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
        Me.GroupBox3.Location = New System.Drawing.Point(200, 552)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 394
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
        Me.CmdView.Location = New System.Drawing.Point(416, 632)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 395
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(200, 616)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox4.TabIndex = 400
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
        Me.Label5.Location = New System.Drawing.Point(200, 672)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 416
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(152, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 24)
        Me.Label2.TabIndex = 420
        Me.Label2.Text = "POS LOCATION :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(640, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 24)
        Me.Label4.TabIndex = 421
        Me.Label4.Text = "MEMBER NAME  :"
        '
        'frmCreditSalesregister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(992, 692)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Chk_Membername)
        Me.Controls.Add(Me.Chk_POSlocation)
        Me.Controls.Add(Me.chklist_POSlocation)
        Me.Controls.Add(Me.chklist_Membername)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmCreditSalesregister"
        Me.Text = "CREDIT SALE REGISTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            chklist_POSlocation.Items.Clear()
            chklist_Membername.Items.Clear()
            grp_SalebillChecklist.Top = 1000
            Chk_POSlocation.Checked = False
            Chk_Membername.Checked = False
            Call FillPOSLocation()
            Call FillMembername()
            If gUserCategory <> "S" Then
                Call GetRights()
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
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    '''******************************  To fill POS details from POSMaster  *******************************'''
    Private Sub FillPOSLocation()
        Try
            Dim i As Integer
            chklist_POSlocation.Items.Clear()
            sqlstring = "SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER ORDER BY POSDESC "
            vconn.getDataSet(sqlstring, "POS")
            If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                    With gdataset.Tables("POS").Rows(i)
                        chklist_POSlocation.Items.Add(Trim(.Item("POSdesc")))
                    End With
                Next i
            End If
            chklist_POSlocation.Sorted = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    '''*****************************  To fill Server details from ServerMaster  **************************'''
    Private Sub FillMembername()
        Try
            Dim i As Integer
            chklist_Membername.Items.Clear()
            sqlstring = "SELECT DISTINCT ISNULL(K.MCODE,'') AS MCODE,ISNULL(M.MNAME,'') AS MNAME FROM KOT_DET AS K INNER JOIN MEMBERMASTER AS M ON "
            sqlstring = sqlstring & " M.MCODE = K.MCODE WHERE ISNULL(MEMBERTYPECODE,'') <> 'EM' AND ISNULL(Freeze,'') <> 'Y'  "
            vconn.getDataSet(sqlstring, "MemberMaster")
            If gdataset.Tables("MemberMaster").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("MemberMaster").Rows.Count - 1
                    With gdataset.Tables("MemberMaster").Rows(i)
                        chklist_Membername.Items.Add(Trim(.Item("Mcode") & "->" & .Item("Mname")))
                    End With
                Next i
            End If
            chklist_Membername.Sorted = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            If chklist_POSlocation.CheckedItems.Count = 0 Then
                MessageBox.Show("Select the Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If chklist_Membername.CheckedItems.Count = 0 Then
                MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = False
            grp_SalebillChecklist.Top = 552
            grp_SalebillChecklist.Left = 200
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            If chklist_POSlocation.CheckedItems.Count = 0 Then
                MessageBox.Show("Select the Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If chklist_Membername.CheckedItems.Count = 0 Then
                MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = True
            grp_SalebillChecklist.Top = 552
            grp_SalebillChecklist.Left = 200
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
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

    Private Sub frmCreditSalesregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call FillPOSLocation()
            Call FillMembername()
            mskFromDate.Value = Now.Today
            mskToDate.Value = Now.Today
            grp_SalebillChecklist.Top = 1000
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
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
                Call viewCreditSaleregister()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub mskFromDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFromDate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                mskToDate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub mskToDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskToDate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                CmdView.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub viewCreditSaleregister()
        Try
            Dim POSdesc(), MemberCode() As String
            Dim i As Integer
            Dim SQLSTRING2 As String
            sqlstring = " SELECT * FROM VIEWCREDITSALEREGISTER"
            If chklist_POSlocation.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " WHERE POSDESC IN ("
                For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
                    sqlstring = sqlstring & "'" & chklist_POSlocation.CheckedItems(i) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If chklist_Membername.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " AND MCODE IN ("
                For i = 0 To chklist_Membername.CheckedItems.Count - 1
                    MemberCode = Split(chklist_Membername.CheckedItems(i), "->")
                    sqlstring = sqlstring & "'" & MemberCode(0) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            sqlstring = sqlstring & " AND BILLDATE BETWEEN '"
            sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
            sqlstring = sqlstring & "AND PAYMENTMODE = 'CREDIT' ORDER BY MCODE,POSDESC,BILLNO, BILLDATE"
            ''================================FOR DOCUMENT COUNT=======================================
            SQLSTRING2 = "select count(*) AS TOTDOC from VIEWCREDITSALEREGISTER_COUNT "
            ''SQLSTRING2 = SQLSTRING2 & " where mcode in("
            If chklist_Membername.CheckedItems.Count <> 0 Then
                SQLSTRING2 = SQLSTRING2 & " WHERE MCODE IN ("
                For i = 0 To chklist_Membername.CheckedItems.Count - 1
                    MemberCode = Split(chklist_Membername.CheckedItems(i), "->")
                    SQLSTRING2 = SQLSTRING2 & "'" & MemberCode(0) & "', "
                Next
                SQLSTRING2 = Mid(SQLSTRING2, 1, Len(SQLSTRING2) - 2)
                SQLSTRING2 = SQLSTRING2 & ")"
            Else
                MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            SQLSTRING2 = SQLSTRING2 & " AND BILLDATE BETWEEN '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND '" & Format(mskToDate.Value, "dd-MMM-yyyy") & "' AND "
            SQLSTRING2 = SQLSTRING2 & " PAYMENTMODE = 'CREDIT' "
            SQLSTRING2 = SQLSTRING2 & " group by mcode "
            SQLSTRING2 = SQLSTRING2 & " order by mcode"



            Dim heading() As String = {" CREDIT SALE REGISTER "}
            Dim Objcreditsaleregister As New CreditSaleRegister
            Objcreditsaleregister.Reportdetails(sqlstring, SQLSTRING2, heading, mskFromDate.Value, mskToDate.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_Membername_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Membername.CheckedChanged
        Try
            Dim i As Integer
            If Chk_Membername.Checked = True Then
                For i = 0 To chklist_Membername.Items.Count - 1
                    chklist_Membername.SetItemChecked(i, True)
                Next
            Else
                For i = 0 To chklist_Membername.Items.Count - 1
                    chklist_Membername.SetItemChecked(i, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_POSlocation_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_POSlocation.CheckedChanged
        Try
            Dim i As Integer
            If Chk_POSlocation.Checked = True Then
                For i = 0 To chklist_POSlocation.Items.Count - 1
                    chklist_POSlocation.SetItemChecked(i, True)
                Next
            Else
                For i = 0 To chklist_POSlocation.Items.Count - 1
                    chklist_POSlocation.SetItemChecked(i, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub frmCreditSalesregister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Dim i As Integer
            If e.KeyCode = Keys.F6 Then
                Call CmdClear_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                For i = 0 To chklist_POSlocation.Items.Count - 1
                    chklist_POSlocation.SetItemChecked(i, True)
                Next i
                Chk_POSlocation.Checked = True
                For i = 0 To chklist_Membername.Items.Count - 1
                    chklist_Membername.SetItemChecked(i, True)
                Next i
                Chk_Membername.Checked = True
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
                If chklist_Membername.SelectedIndex = 0 Then
                    Call Search_Item(chklist_Membername, Search)
                ElseIf chklist_POSlocation.SelectedIndex = 0 Then
                    Call Search_Item(chklist_POSlocation, Search)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub chklist_POSlocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklist_POSlocation.SelectedIndexChanged
        'Dim I, J As Integer
        'For J = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '    If chklist_POSlocation.GetItemChecked(J) = True Then
        '        chklist_Membername.Items.Clear()
        '        sqlstring = "SELECT DISTINCT ISNULL(K.MCODE,'') AS MCODE,ISNULL(M.MNAME,'') AS MNAME FROM KOT_DET AS K INNER JOIN MEMBERMASTER AS M ON "
        '        sqlstring = sqlstring & " M.MCODE = K.MCODE INNER JOIN POSMASTER AS P ON P.POSCODE = K.POSCODE "
        '        If chklist_POSlocation.CheckedItems.Count <> 0 Then
        '            sqlstring = sqlstring & " WHERE POSDESC IN ("
        '            For I = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '                sqlstring = sqlstring & " '" & chklist_POSlocation.CheckedItems(I) & "', "
        '            Next
        '            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
        '            sqlstring = sqlstring & ")"
        '        End If
        '        sqlstring = sqlstring & " AND MEMBERTYPECODE <> 'EM' ORDER BY MCODE"
        '        vconn.getDataSet(sqlstring, "MEMBERMASTER")
        '        If gdataset.Tables("MEMBERMASTER").Rows.Count - 1 >= 0 Then
        '            For I = 0 To gdataset.Tables("MEMBERMASTER").Rows.Count - 1
        '                With gdataset.Tables("MEMBERMASTER").Rows(I)
        '                    chklist_Membername.Items.Add(Trim(.Item("MCODE") & "->" & .Item("MNAME")))
        '                End With
        '            Next I
        '        End If
        '        chklist_Membername.Sorted = True
        '    End If
        'Next J
    End Sub
End Class
