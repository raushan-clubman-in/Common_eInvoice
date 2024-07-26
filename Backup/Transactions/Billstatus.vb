Public Class Billstatus
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
    Friend WithEvents grp_ssgrid As System.Windows.Forms.GroupBox
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_heading As System.Windows.Forms.Label
    Friend WithEvents grp_Billposting As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_head As System.Windows.Forms.Label
    Friend WithEvents Cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents Cmd_Fill As System.Windows.Forms.Button
    Friend WithEvents lbl_Fromdate As System.Windows.Forms.Label
    Friend WithEvents dtp_Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_searchtext As System.Windows.Forms.Label
    Friend WithEvents Opt_billnowise As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_mcodewise As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_scodewise As System.Windows.Forms.RadioButton
    Friend WithEvents txt_searchtext As System.Windows.Forms.TextBox
    Friend WithEvents grp_searchfield As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Billstatus))
        Me.grp_ssgrid = New System.Windows.Forms.GroupBox
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_heading = New System.Windows.Forms.Label
        Me.grp_Billposting = New System.Windows.Forms.GroupBox
        Me.lbl_head = New System.Windows.Forms.Label
        Me.Cmd_Cancel = New System.Windows.Forms.Button
        Me.Cmd_Fill = New System.Windows.Forms.Button
        Me.lbl_Fromdate = New System.Windows.Forms.Label
        Me.dtp_Fromdate = New System.Windows.Forms.DateTimePicker
        Me.grp_searchfield = New System.Windows.Forms.GroupBox
        Me.txt_searchtext = New System.Windows.Forms.TextBox
        Me.Opt_scodewise = New System.Windows.Forms.RadioButton
        Me.Opt_mcodewise = New System.Windows.Forms.RadioButton
        Me.Opt_billnowise = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_searchtext = New System.Windows.Forms.Label
        Me.grp_ssgrid.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Billposting.SuspendLayout()
        Me.grp_searchfield.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_ssgrid
        '
        Me.grp_ssgrid.BackColor = System.Drawing.Color.Transparent
        Me.grp_ssgrid.Controls.Add(Me.ssgrid)
        Me.grp_ssgrid.Location = New System.Drawing.Point(48, 32)
        Me.grp_ssgrid.Name = "grp_ssgrid"
        Me.grp_ssgrid.Size = New System.Drawing.Size(928, 560)
        Me.grp_ssgrid.TabIndex = 5
        Me.grp_ssgrid.TabStop = False
        '
        'ssgrid
        '
        Me.ssgrid.ContainingControl = Me
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(8, 16)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(912, 536)
        Me.ssgrid.TabIndex = 370
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.Location = New System.Drawing.Point(296, 608)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 397
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.Color.White
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.Location = New System.Drawing.Point(536, 608)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.cmd_View.TabIndex = 400
        Me.cmd_View.Text = " View[F9]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(416, 608)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 398
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(656, 608)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 402
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(280, 592)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox2.TabIndex = 403
        Me.GroupBox2.TabStop = False
        '
        'lbl_heading
        '
        Me.lbl_heading.AutoSize = True
        Me.lbl_heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_heading.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_heading.Location = New System.Drawing.Point(464, 8)
        Me.lbl_heading.Name = "lbl_heading"
        Me.lbl_heading.Size = New System.Drawing.Size(149, 28)
        Me.lbl_heading.TabIndex = 404
        Me.lbl_heading.Text = "BILL STATUS"
        '
        'grp_Billposting
        '
        Me.grp_Billposting.BackgroundImage = CType(resources.GetObject("grp_Billposting.BackgroundImage"), System.Drawing.Image)
        Me.grp_Billposting.Controls.Add(Me.lbl_head)
        Me.grp_Billposting.Controls.Add(Me.Cmd_Cancel)
        Me.grp_Billposting.Controls.Add(Me.Cmd_Fill)
        Me.grp_Billposting.Controls.Add(Me.lbl_Fromdate)
        Me.grp_Billposting.Controls.Add(Me.dtp_Fromdate)
        Me.grp_Billposting.Location = New System.Drawing.Point(49, 1000)
        Me.grp_Billposting.Name = "grp_Billposting"
        Me.grp_Billposting.Size = New System.Drawing.Size(384, 184)
        Me.grp_Billposting.TabIndex = 405
        Me.grp_Billposting.TabStop = False
        '
        'lbl_head
        '
        Me.lbl_head.BackColor = System.Drawing.Color.Maroon
        Me.lbl_head.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_head.ForeColor = System.Drawing.Color.White
        Me.lbl_head.Location = New System.Drawing.Point(5, 9)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(376, 24)
        Me.lbl_head.TabIndex = 7
        Me.lbl_head.Text = "BILL STATUS"
        Me.lbl_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmd_Cancel
        '
        Me.Cmd_Cancel.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Cancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Cancel.ForeColor = System.Drawing.Color.White
        Me.Cmd_Cancel.Image = CType(resources.GetObject("Cmd_Cancel.Image"), System.Drawing.Image)
        Me.Cmd_Cancel.Location = New System.Drawing.Point(200, 136)
        Me.Cmd_Cancel.Name = "Cmd_Cancel"
        Me.Cmd_Cancel.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Cancel.TabIndex = 3
        Me.Cmd_Cancel.Text = "Cancel [F10]"
        '
        'Cmd_Fill
        '
        Me.Cmd_Fill.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Fill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fill.ForeColor = System.Drawing.Color.White
        Me.Cmd_Fill.Image = CType(resources.GetObject("Cmd_Fill.Image"), System.Drawing.Image)
        Me.Cmd_Fill.Location = New System.Drawing.Point(72, 136)
        Me.Cmd_Fill.Name = "Cmd_Fill"
        Me.Cmd_Fill.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Fill.TabIndex = 2
        Me.Cmd_Fill.Text = "Fill [F8]"
        '
        'lbl_Fromdate
        '
        Me.lbl_Fromdate.AutoSize = True
        Me.lbl_Fromdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fromdate.Location = New System.Drawing.Point(40, 72)
        Me.lbl_Fromdate.Name = "lbl_Fromdate"
        Me.lbl_Fromdate.Size = New System.Drawing.Size(105, 22)
        Me.lbl_Fromdate.TabIndex = 5
        Me.lbl_Fromdate.Text = "BILL DATE :"
        '
        'dtp_Fromdate
        '
        Me.dtp_Fromdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Fromdate.Location = New System.Drawing.Point(160, 72)
        Me.dtp_Fromdate.Name = "dtp_Fromdate"
        Me.dtp_Fromdate.Size = New System.Drawing.Size(168, 26)
        Me.dtp_Fromdate.TabIndex = 0
        '
        'grp_searchfield
        '
        Me.grp_searchfield.BackgroundImage = CType(resources.GetObject("grp_searchfield.BackgroundImage"), System.Drawing.Image)
        Me.grp_searchfield.Controls.Add(Me.txt_searchtext)
        Me.grp_searchfield.Controls.Add(Me.Opt_scodewise)
        Me.grp_searchfield.Controls.Add(Me.Opt_mcodewise)
        Me.grp_searchfield.Controls.Add(Me.Opt_billnowise)
        Me.grp_searchfield.Controls.Add(Me.Label1)
        Me.grp_searchfield.Controls.Add(Me.lbl_searchtext)
        Me.grp_searchfield.Location = New System.Drawing.Point(352, 1000)
        Me.grp_searchfield.Name = "grp_searchfield"
        Me.grp_searchfield.Size = New System.Drawing.Size(367, 134)
        Me.grp_searchfield.TabIndex = 406
        Me.grp_searchfield.TabStop = False
        '
        'txt_searchtext
        '
        Me.txt_searchtext.BackColor = System.Drawing.Color.Wheat
        Me.txt_searchtext.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_searchtext.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchtext.Location = New System.Drawing.Point(144, 84)
        Me.txt_searchtext.MaxLength = 20
        Me.txt_searchtext.Name = "txt_searchtext"
        Me.txt_searchtext.Size = New System.Drawing.Size(216, 29)
        Me.txt_searchtext.TabIndex = 11
        Me.txt_searchtext.Text = ""
        '
        'Opt_scodewise
        '
        Me.Opt_scodewise.BackColor = System.Drawing.Color.Transparent
        Me.Opt_scodewise.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_scodewise.Location = New System.Drawing.Point(264, 48)
        Me.Opt_scodewise.Name = "Opt_scodewise"
        Me.Opt_scodewise.Size = New System.Drawing.Size(112, 16)
        Me.Opt_scodewise.TabIndex = 10
        Me.Opt_scodewise.Text = "SCODE WISE"
        '
        'Opt_mcodewise
        '
        Me.Opt_mcodewise.BackColor = System.Drawing.Color.Transparent
        Me.Opt_mcodewise.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_mcodewise.Location = New System.Drawing.Point(140, 48)
        Me.Opt_mcodewise.Name = "Opt_mcodewise"
        Me.Opt_mcodewise.Size = New System.Drawing.Size(116, 16)
        Me.Opt_mcodewise.TabIndex = 9
        Me.Opt_mcodewise.Text = "MCODE WISE"
        '
        'Opt_billnowise
        '
        Me.Opt_billnowise.BackColor = System.Drawing.Color.Transparent
        Me.Opt_billnowise.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_billnowise.Location = New System.Drawing.Point(8, 48)
        Me.Opt_billnowise.Name = "Opt_billnowise"
        Me.Opt_billnowise.Size = New System.Drawing.Size(120, 16)
        Me.Opt_billnowise.TabIndex = 8
        Me.Opt_billnowise.Text = "BILL NO WISE"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SEARCH FIELDS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_searchtext
        '
        Me.lbl_searchtext.AutoSize = True
        Me.lbl_searchtext.BackColor = System.Drawing.Color.Transparent
        Me.lbl_searchtext.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_searchtext.Location = New System.Drawing.Point(8, 88)
        Me.lbl_searchtext.Name = "lbl_searchtext"
        Me.lbl_searchtext.Size = New System.Drawing.Size(133, 22)
        Me.lbl_searchtext.TabIndex = 5
        Me.lbl_searchtext.Text = "SEARCH TEXT :"
        '
        'Billstatus
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 699)
        Me.Controls.Add(Me.grp_searchfield)
        Me.Controls.Add(Me.grp_Billposting)
        Me.Controls.Add(Me.lbl_heading)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_View)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grp_ssgrid)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Billstatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BILL STATUS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_ssgrid.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Billposting.ResumeLayout(False)
        Me.grp_searchfield.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public gconnection As New GlobalClass
    Dim accountcode As String
    Dim chkbool As Boolean
    Private Sub Cmd_Fill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Fill.Click
        Call fillbillstatus("BILLDETAILS")
        grp_Billposting.Top = 1000
        Cmd_Add.Focus()
    End Sub

    Private Sub Cmd_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Cancel.Click
        grp_Billposting.Top = 1000
        cmd_View.Focus()
    End Sub

    Private Sub Billstatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Billstatusbool = True
        grp_Billposting.Top = 1000
    End Sub

    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        ssgrid.ClearRange(1, 1, -1, -1, True)
        ssgrid.SetActiveCell(1, 1)
        Call clearform(Me)
    End Sub

    Private Sub dtp_Fromdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Fromdate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmd_Fill.Focus()
        End If
    End Sub
    Public Sub fillbillstatus(ByVal ORDERBY As String)
        Dim sqlstring As String
        Dim i, j As Integer
        sqlstring = "SELECT B.BILLDATE AS BILLDATE, ISNULL(B.BILLDETAILS,'') AS BILLDETAILS,ISNULL(B.MCODE,'') AS MCODE,ISNULL(B.MNAME,'') AS MNAME, "
        sqlstring = sqlstring & " ISNULL(B.SCODE,'') AS SCODE,ISNULL(B.SNAME,'') AS SNAME,ISNULL(B.REMARKS,'') AS REMARKS,ISNULL(B.TOTALAMOUNT,0) AS TOTALAMOUNT,"
        sqlstring = sqlstring & " ISNULL(B.PAYMENTMODE,'') AS PAYMENTMODE,ISNULL(B.DELFLAG,'') AS DELFLAG,ISNULL(H.BILLSTATUS,'') AS BILLSTATUS "
        sqlstring = sqlstring & " FROM BILL_HDR AS B INNER JOIN KOT_HDR AS H ON B.BILLDETAILS = H.KOTDETAILS"
        sqlstring = sqlstring & " WHERE BILLDATE ='" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ISNULL(B.DELFLAG,'') <> 'Y' "
        sqlstring = sqlstring & " GROUP BY B.BILLDATE,B.BILLDETAILS,B.MCODE,B.MNAME,B.SCODE,B.SNAME,B.PAYMENTMODE,B.REMARKS,B.TOTALAMOUNT,B.DELFLAG,H.BILLSTATUS"
        sqlstring = sqlstring & " ORDER BY " & ORDERBY
        'sqlstring = sqlstring & " AND ISNULL(H.BILLSTATUS,'') = 'PO' AND ISNULL(B.PAYMENTMODE,'') = 'PENDING'"
        ssgrid.ClearRange(1, 1, -1, -1, True)
        gconnection.getDataSet(sqlstring, "BILL_HDR")
        If gdataset.Tables("BILL_HDR").Rows.Count > 0 Then
            For i = 1 To gdataset.Tables("BILL_HDR").Rows.Count
                Call GridPaymentmode(i) '''---> FILL GRID PAYMENTMODE
                ssgrid.Col = 1
                ssgrid.Row = i
                ssgrid.BackColor = Color.White
                ssgrid.ForeColor = Color.Black
                ssgrid.SetText(1, i, Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("BILLDETAILS")))
                ssgrid.Col = 2
                ssgrid.Row = i
                ssgrid.BackColor = Color.White
                ssgrid.ForeColor = Color.Black
                ssgrid.SetText(2, i, Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("MCODE")))
                ssgrid.Col = 3
                ssgrid.Row = i
                ssgrid.BackColor = Color.White
                ssgrid.ForeColor = Color.Black
                ssgrid.SetText(3, i, Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("MNAME")))
                ssgrid.Col = 4
                ssgrid.Row = i
                ssgrid.BackColor = Color.White
                ssgrid.ForeColor = Color.Black
                ssgrid.SetText(4, i, Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("SCODE")))
                ssgrid.Col = 5
                ssgrid.Row = i
                ssgrid.BackColor = Color.White
                ssgrid.ForeColor = Color.Black
                ssgrid.SetText(5, i, Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("REMARKS")))
                ssgrid.Col = 6
                ssgrid.Row = i
                ssgrid.BackColor = Color.White
                ssgrid.ForeColor = Color.Black
                ssgrid.SetText(6, i, Format(Val(gdataset.Tables("BILL_HDR").Rows(j).Item("TOTALAMOUNT")), "0.000"))
                ssgrid.Col = 7
                ssgrid.Row = i
                ssgrid.BackColor = Color.White
                ssgrid.ForeColor = Color.Black
                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("PAYMENTMODE"))
                ssgrid.Text = Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("PAYMENTMODE"))
                ssgrid.Col = 8
                ssgrid.Row = i
                ssgrid.BackColor = Color.White
                ssgrid.ForeColor = Color.Black
                ssgrid.SetText(8, i, Trim(gdataset.Tables("BILL_HDR").Rows(j).Item("SNAME")))
                j = j + 1
            Next
        End If

    End Sub
    Private Sub GridPaymentmode(ByVal i As Integer)
        Dim j As Integer
        Dim sqlstring As String
        ssgrid.TypeComboBoxClear(7, i)
        sqlstring = "SELECT ISNULL(PAYMENTCODE,'') AS PAYMENTCODE FROM PAYMENTMODEMASTER WHERE ISNULL(FREEZE,'') <> 'Y' AND ISNULL(MEMBERSTATUS,'') = 'YES' AND PAYMENTCODE <> 'ROOM'"
        gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
        If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
            For j = 0 To gdataset.Tables("PAYMENTMODEMASTER").Rows.Count - 1
                ssgrid.Col = 7
                ssgrid.Row = i
                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(j).Item("PAYMENTCODE"))
                ssgrid.Text = Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(j).Item("PAYMENTCODE"))
            Next j
        End If
    End Sub

    Private Sub Billstatus_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Billstatusbool = False
    End Sub

    Private Sub cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_View.Click
        ssgrid.ClearRange(1, 1, -1, -1, True)
        grp_Billposting.Top = 80
        grp_Billposting.Left = 296
        dtp_Fromdate.Focus()
    End Sub
    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim Update(0), sqlstring, paymentaccountcode, Subpaymentaccountcode, SubpaymentMode As String
        Dim BoolUpdate As Boolean = False
        Dim i, j As Integer
        Call checkvalidate() '''---> Check Validation
        If chkbool = False Then Exit Sub
        For i = 1 To ssgrid.DataRowCnt
            ssgrid.Col = 7
            ssgrid.Row = i
            '''******************************************* $ FIND OUT PAYMENTMODE ACCOUNTCODE $  *****************************'''
            sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN,ISNULL(SUBPAYSTATUS,'') AS SUBPAYSTATUS FROM PAYMENTMODEMASTER WHERE PAYMENTCODE ='" & Trim(ssgrid.Text) & "' AND ISNULL(Freeze,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "PAYMENTMODEMASTER")
            If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                If Mid(Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("SUBPAYSTATUS")), 1, 1) = "N" Then
                    paymentaccountcode = Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("ACCOUNTIN"))
                ElseIf Mid(Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("SUBPAYSTATUS")), 1, 1) = "Y" Then
                    sqlstring = "SELECT ISNULL(ACCOUNTIN,'') AS ACCOUNTIN,ISNULL(SUBPAYMENTCODE,'') AS SUBPAYMENTCODE FROM SUBPAYMENTMODE WHERE PAYMENTCODE ='" & Trim(ssgrid.Text) & "' AND ISNULL(Freeze,'')<>'Y'"
                    gconnection.getDataSet(sqlstring, "SUBPAYMENTMODE")
                    If gdataset.Tables("SUBPAYMENTMODE").Rows.Count > 0 Then
                        SubpaymentMode = Trim(gdataset.Tables("SUBPAYMENTMODE").Rows(0).Item("SUBPAYMENTCODE"))
                        Subpaymentaccountcode = Trim(gdataset.Tables("SUBPAYMENTMODE").Rows(0).Item("ACCOUNTIN"))
                    End If
                End If
            Else
                MessageBox.Show("Assign a AccountCode For Specified PAYMENTMODE", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                paymentaccountcode = ""
                Subpaymentaccountcode = ""
                SubpaymentMode = ""
                Exit Sub
            End If
            ''********************************************* $ ASSIGN ACCOUNT CODE VALUE $ **********************************************'''
            ssgrid.Col = 7
            ssgrid.Row = i
            If Trim(ssgrid.Text) = "ROOM" Then
                accountcode = "RMLDGR"
            ElseIf Trim(ssgrid.Text) = "CREDIT" Then
                accountcode = Trim(gDebitors)
            Else
                accountcode = ""
            End If

            ssgrid.Col = 7
            ssgrid.Row = i
            ''**********************************************************$ UPDATE KOT_HDR TABLE $*********************************************************'''
            If ssgrid.Text = "PENDING" Then
                sqlstring = "UPDATE KOT_HDR SET AccountCode='" & Trim(accountcode) & "',"
                ssgrid.Col = 7
                ssgrid.Row = i
                sqlstring = sqlstring & " PaymentType='" & Trim(ssgrid.Text) & "',SubPaymentMode='" & Trim(SubpaymentMode) & "',BillStatus = 'PO',"
                ssgrid.Col = 2
                ssgrid.Row = i
                sqlstring = sqlstring & " Paymodeaccountcode = '" & Trim(gDebitors) & " ',subpaymentaccountcode = '" & Trim(ssgrid.Text) & "', "
                sqlstring = sqlstring & " upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'"
                ssgrid.Col = 1
                ssgrid.Row = i
                sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(ssgrid.Text)) & "' "
            ElseIf ssgrid.Text = "CREDIT" Then
                sqlstring = "UPDATE KOT_HDR SET AccountCode='" & Trim(accountcode) & "',"
                ssgrid.Col = 7
                ssgrid.Row = i
                sqlstring = sqlstring & " PaymentType='" & Trim(ssgrid.Text) & "',SubPaymentMode='" & Trim(SubpaymentMode) & "',BillStatus = 'PO',"
                ssgrid.Col = 2
                ssgrid.Row = i
                sqlstring = sqlstring & " Paymodeaccountcode = '" & Trim(gDebitors) & " ',subpaymentaccountcode = '" & Trim(ssgrid.Text) & "', "
                sqlstring = sqlstring & " upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'"
                ssgrid.Col = 1
                ssgrid.Row = i
                sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(ssgrid.Text)) & "' "
            Else
                sqlstring = "UPDATE KOT_HDR SET AccountCode='" & Trim(accountcode) & "',"
                ssgrid.Col = 2
                ssgrid.Row = i
                sqlstring = sqlstring & " SLCode='" & Trim(ssgrid.Text) & "',MCode='" & Trim(ssgrid.Text) & "',"
                ssgrid.Col = 3
                ssgrid.Row = i
                sqlstring = sqlstring & " Mname='" & Trim(ssgrid.Text) & "',"
                ssgrid.Col = 4
                ssgrid.Row = i
                sqlstring = sqlstring & " STCode='" & Trim(ssgrid.Text) & "',ServerCode='" & Trim(ssgrid.Text) & "',"
                ssgrid.Col = 8
                ssgrid.Row = i
                sqlstring = sqlstring & " ServerName='" & Trim(ssgrid.Text) & "',"
                ssgrid.Col = 7
                ssgrid.Row = i
                sqlstring = sqlstring & " PaymentType='" & Trim(ssgrid.Text) & "',SubPaymentMode='" & Trim(SubpaymentMode) & "',BillStatus = 'PO',"
                sqlstring = sqlstring & " Paymodeaccountcode = '" & Trim(paymentaccountcode) & " ',subpaymentaccountcode = '" & Trim(Subpaymentaccountcode) & " ',"
                sqlstring = sqlstring & " upduserid='" & Trim(gUsername) & "',upddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'"
                ssgrid.Col = 1
                ssgrid.Row = i
                sqlstring = sqlstring & " WHERE Kotdetails='" & Trim(CStr(ssgrid.Text)) & "' "
            End If
            If BoolUpdate = False Then
                Update(0) = sqlstring
                BoolUpdate = True
            Else
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = sqlstring
            End If

            '''********************************************************$ UPDATE BILL_HDR TABLE $********************************'''

            ssgrid.Col = 7
            ssgrid.Row = i
            If Trim(ssgrid.Text) = "CREDIT" Then
                ssgrid.Col = 7
                ssgrid.Row = i
                sqlstring = "UPDATE BILL_HDR SET PayMentmode= '" & Trim(ssgrid.Text) & "' ,Paymentaccountcode= '" & Trim(gDebitors) & "' ,"
                ssgrid.Col = 2
                ssgrid.Row = i
                sqlstring = sqlstring & " SubPaymentMode='" & Trim(SubpaymentMode) & "',Subpaymentaccountcode='" & Trim(ssgrid.Text) & "',"
                sqlstring = sqlstring & " Upduserid='" & Trim(gUsername) & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "' "
                ssgrid.Col = 1
                ssgrid.Row = i
                sqlstring = sqlstring & " WHERE Billdetails = '" & Trim(CStr(ssgrid.Text)) & "' "
            Else
                ssgrid.Col = 7
                ssgrid.Row = i
                sqlstring = "UPDATE BILL_HDR SET PayMentmode= '" & Trim(ssgrid.Text) & "' ,Paymentaccountcode= '" & Trim(gDebitors) & "' ,"
                ssgrid.Col = 2
                ssgrid.Row = i
                sqlstring = sqlstring & " SubPaymentMode='" & Trim(SubpaymentMode) & "',Subpaymentaccountcode='" & Trim(ssgrid.Text) & "',"
                sqlstring = sqlstring & " Upduserid='" & Trim(gUsername) & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "' "
                ssgrid.Col = 1
                ssgrid.Row = i
                sqlstring = sqlstring & " WHERE Billdetails = '" & Trim(CStr(ssgrid.Text)) & "' "
            End If
            ReDim Preserve Update(Update.Length)
            Update(Update.Length - 1) = sqlstring

            '''---------------------room ledger ROOM TO CASH

            ssgrid.Col = 7
            ssgrid.Row = i
            sqlstring = "UPDATE ROOMLEDGER SET PayMentmode= '" & Trim(ssgrid.Text) & "' ,accountcode= '" & Trim(gDebitors) & "' ,"
            sqlstring = sqlstring & " Upduserid='" & Trim(gUsername) & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "' "
            ssgrid.Col = 1
            ssgrid.Row = i
            sqlstring = sqlstring & " WHERE Billdetails = '" & Trim(CStr(ssgrid.Text)) & "' "
            ReDim Preserve Update(Update.Length)
            Update(Update.Length - 1) = sqlstring

            '''----------------ROOM LEDGER CASH TO ROOM PENDING



            '''********************************************************$ UPDATE INTO  BILLSETTLEMENT $**********************************'''
            ssgrid.Col = 1
            ssgrid.Row = i
            sqlstring = " SELECT COUNT(*) FROM BILLSETTLEMENT WHERE BILLNO ='" & Trim(ssgrid.Text) & "'"
            gconnection.getDataSet(sqlstring, "BILLSETTLEMENT")
            If gdataset.Tables("BILLSETTLEMENT").Rows.Count > 0 Then
                ssgrid.Col = 7
                ssgrid.Row = i
                sqlstring = "UPDATE BILLSETTLEMENT SET PaymentMode = '" & Trim(ssgrid.Text) & "',PaymentAccountCode = '" & Trim(paymentaccountcode) & "',"
                sqlstring = sqlstring & " UpdateUserid='" & Trim(gUsername) & "',Updatedatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "' "
                ssgrid.Col = 1
                ssgrid.Row = i
                sqlstring = sqlstring & " WHERE BillNo = '" & Trim(ssgrid.Text) & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = sqlstring
            End If
            '''********************************************************$ UPDATE INTO  KOT_DET $**********************************'''

            ssgrid.Col = 7
            ssgrid.Row = i
            sqlstring = "UPDATE KOT_DET SET PaymentMode = '" & Trim(ssgrid.Text) & "',"
            sqlstring = sqlstring & " UpdUserid='" & Trim(gUsername) & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "' "
            ssgrid.Col = 1
            ssgrid.Row = i
            sqlstring = sqlstring & " WHERE Billdetails = '" & Trim(ssgrid.Text) & "'"
            ReDim Preserve Update(Update.Length)
            Update(Update.Length - 1) = sqlstring
        Next i
        gconnection.MoreTransold(Update)
        Call cmd_Clear_Click(sender, e)
    End Sub
    Private Sub checkvalidate()
        chkbool = False
        '''********************************************* Check ssgrid value can't be blank ********************************************'''
        If ssgrid.DataRowCnt = 0 Then
            MessageBox.Show("!! Sorry !!There is no BILL NO to be saved", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ssgrid.SetActiveCell(1, 1)
            ssgrid.Focus()
            Exit Sub
        End If
        '''********************************************* Check ssgrid value can't be blank ********************************************'''
        chkbool = True
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grp_searchfield.Enter

    End Sub

    Private Sub txt_searchtext_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_searchtext.KeyPress
        Dim Varsearchtext As String
        Dim I, J As Integer
        If Asc(e.KeyChar) = 13 Then
            If ssgrid.DataRowCnt = 0 Then
                MessageBox.Show("!! Sorry !!There is no BILL NO search", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssgrid.SetActiveCell(1, 1)
                ssgrid.Focus()
                Exit Sub
            End If
            If Trim(txt_searchtext.Text) <> "" Then
                If Opt_billnowise.Checked = True Then
                    Varsearchtext = Trim(txt_searchtext.Text)
                    Call fillbillstatus("BILLDETAILS")
                    For I = 1 To ssgrid.DataRowCnt
                        ssgrid.Col = 1
                        ssgrid.Row = I
                        If Trim(ssgrid.Text) = Trim(Varsearchtext) Then
                            ssgrid.BackColor = Color.White
                            ssgrid.ForeColor = Color.Blue
                            ssgrid.SetActiveCell(1, I)
                            grp_searchfield.Top = 1000
                            ssgrid.Focus()
                        End If
                    Next I
                ElseIf Opt_mcodewise.Checked = True Then
                    Varsearchtext = Trim(txt_searchtext.Text)
                    Call fillbillstatus("MCODE")
                    For I = 1 To ssgrid.DataRowCnt
                        ssgrid.Col = 2
                        ssgrid.Row = I
                        If Trim(ssgrid.Text) = Trim(Varsearchtext) Then
                            ssgrid.BackColor = Color.White
                            ssgrid.ForeColor = Color.Blue
                            ssgrid.SetActiveCell(2, I)
                            grp_searchfield.Top = 1000
                            ssgrid.Focus()
                        End If
                    Next I
                ElseIf Opt_scodewise.Checked = True Then
                    Varsearchtext = Trim(txt_searchtext.Text)
                    Call fillbillstatus("SCODE")
                    For I = 1 To ssgrid.DataRowCnt
                        ssgrid.Col = 4
                        ssgrid.Row = I
                        If Trim(ssgrid.Text) = Trim(Varsearchtext) Then
                            ssgrid.BackColor = Color.White
                            ssgrid.ForeColor = Color.Blue
                            ssgrid.SetActiveCell(4, I)
                            grp_searchfield.Top = 1000
                            ssgrid.Focus()
                        End If
                    Next I
                End If
            Else
                Call fillbillstatus("BILLDETAILS")
                ssgrid.SetActiveCell(1, 1)
                ssgrid.Focus()
                grp_searchfield.Top = 1000
            End If
        End If
    End Sub

    Private Sub Billstatus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            grp_searchfield.Top = 256
            grp_searchfield.Left = 352
            Opt_billnowise.Checked = True
            txt_searchtext.Text = ""
            txt_searchtext.Focus()
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F7 Then
            If Cmd_Add.Enabled = True Then
                Call Cmd_Add_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            Call cmd_View_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Then
            Call cmd_Exit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Then
            If grp_searchfield.Top = 256 Then
                grp_searchfield.Top = 1000
                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                Exit Sub
            ElseIf grp_Billposting.Top = 80 Then
                grp_Billposting.Top = 1000
                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                Exit Sub
            Else
                Call cmd_Exit_Click(sender, e)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Opt_billnowise_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Opt_billnowise.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_searchtext.Focus()
        End If
    End Sub

    Private Sub Opt_mcodewise_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Opt_mcodewise.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_searchtext.Focus()
        End If
    End Sub

    Private Sub Opt_scodewise_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Opt_scodewise.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_searchtext.Focus()
        End If
    End Sub
End Class
