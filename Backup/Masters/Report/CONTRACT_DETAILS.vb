Imports System.Data.SqlClient
Imports System.IO
Public Class CONTRACT_DETAILS
    Inherits System.Windows.Forms.Form
    Public vseqno As Double
    Dim PHOTOFILENAME As String
    Dim itembool, chkbool, smartcardbool, boolPromotional As Boolean
    Dim dd, serverdate As DateTime
    Dim TotalItemCount As Integer
    Dim gconnection As New GlobalClass
    Dim vsearch, vitem, accountcode, KOTno(), loccode, stosql, servicelocation As String
    Dim BillNontaxamount, BillNontotalamount, Billtaxamount, Billtotalamount, MemberOutstand As Double
    Dim duplicateflag As Boolean = False
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
    Friend WithEvents lbl_CashReceipt As System.Windows.Forms.Label
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SSGRID1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents DTP_FROMDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_TODATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_PaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_TDSPRC As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CONTRACT_DETAILS))
        Me.lbl_CashReceipt = New System.Windows.Forms.Label
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DTP_TODATE = New System.Windows.Forms.DateTimePicker
        Me.DTP_FROMDATE = New System.Windows.Forms.DateTimePicker
        Me.SSGRID1 = New AxFPSpreadADO.AxfpSpread
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbo_PaymentMode = New System.Windows.Forms.ComboBox
        Me.TXT_TDSPRC = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SSGRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_CashReceipt
        '
        Me.lbl_CashReceipt.AutoSize = True
        Me.lbl_CashReceipt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CashReceipt.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CashReceipt.ForeColor = System.Drawing.Color.Black
        Me.lbl_CashReceipt.Location = New System.Drawing.Point(400, 72)
        Me.lbl_CashReceipt.Name = "lbl_CashReceipt"
        Me.lbl_CashReceipt.Size = New System.Drawing.Size(242, 35)
        Me.lbl_CashReceipt.TabIndex = 364
        Me.lbl_CashReceipt.Text = "CONTRACT BILL"
        Me.lbl_CashReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ssGrid
        '
        Me.ssGrid.ContainingControl = Me
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(144, 152)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(10, 1)
        Me.ssGrid.TabIndex = 365
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Controls.Add(Me.CmdPrint)
        Me.GroupBox4.Controls.Add(Me.cmdexit)
        Me.GroupBox4.Controls.Add(Me.CmdView)
        Me.GroupBox4.Location = New System.Drawing.Point(144, 560)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 48)
        Me.GroupBox4.TabIndex = 367
        Me.GroupBox4.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(60, 12)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 7
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(380, 12)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 6
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(548, 12)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 8
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(220, 12)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 5
        Me.CmdView.Text = "View [F9]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TO DATE :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DTP_TODATE)
        Me.GroupBox3.Controls.Add(Me.DTP_FROMDATE)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(240, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(552, 48)
        Me.GroupBox3.TabIndex = 366
        Me.GroupBox3.TabStop = False
        '
        'DTP_TODATE
        '
        Me.DTP_TODATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_TODATE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_TODATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_TODATE.Location = New System.Drawing.Point(432, 14)
        Me.DTP_TODATE.Name = "DTP_TODATE"
        Me.DTP_TODATE.Size = New System.Drawing.Size(112, 26)
        Me.DTP_TODATE.TabIndex = 1
        '
        'DTP_FROMDATE
        '
        Me.DTP_FROMDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_FROMDATE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FROMDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_FROMDATE.Location = New System.Drawing.Point(120, 15)
        Me.DTP_FROMDATE.Name = "DTP_FROMDATE"
        Me.DTP_FROMDATE.Size = New System.Drawing.Size(112, 26)
        Me.DTP_FROMDATE.TabIndex = 0
        '
        'SSGRID1
        '
        Me.SSGRID1.DataSource = Nothing
        Me.SSGRID1.Location = New System.Drawing.Point(104, 240)
        Me.SSGRID1.Name = "SSGRID1"
        Me.SSGRID1.OcxState = CType(resources.GetObject("SSGRID1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID1.Size = New System.Drawing.Size(798, 280)
        Me.SSGRID1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 22)
        Me.Label1.TabIndex = 369
        Me.Label1.Text = "OUT LET :"
        '
        'cbo_PaymentMode
        '
        Me.cbo_PaymentMode.BackColor = System.Drawing.Color.Wheat
        Me.cbo_PaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_PaymentMode.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_PaymentMode.Location = New System.Drawing.Point(360, 185)
        Me.cbo_PaymentMode.Name = "cbo_PaymentMode"
        Me.cbo_PaymentMode.Size = New System.Drawing.Size(248, 30)
        Me.cbo_PaymentMode.TabIndex = 2
        '
        'TXT_TDSPRC
        '
        Me.TXT_TDSPRC.BackColor = System.Drawing.Color.Wheat
        Me.TXT_TDSPRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_TDSPRC.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TDSPRC.Location = New System.Drawing.Point(672, 184)
        Me.TXT_TDSPRC.MaxLength = 5
        Me.TXT_TDSPRC.Name = "TXT_TDSPRC"
        Me.TXT_TDSPRC.Size = New System.Drawing.Size(88, 29)
        Me.TXT_TDSPRC.TabIndex = 3
        Me.TXT_TDSPRC.Text = ""
        Me.TXT_TDSPRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 371
        Me.Label2.Text = "TDS %"
        '
        'CONTRACT_DETAILS
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_TDSPRC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_CashReceipt)
        Me.Controls.Add(Me.cbo_PaymentMode)
        Me.Controls.Add(Me.SSGRID1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "CONTRACT_DETAILS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTRACT_DETAILS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.SSGRID1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ssGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssGrid.KeyDownEvent
        Try
            Dim I As Integer
            If e.keyCode = Keys.Enter Then
                I = ssGrid.ActiveRow
                If ssGrid.ActiveCol = 2 Then
                    SSGRID1.Col = 2
                    SSGRID1.Row = I
                    If Trim(SSGRID1.Text) = "" Then
                        Call FillMenu()
                    End If
                End If
            End If
            If e.keyCode = Keys.F4 Then
                I = ssGrid.ActiveRow
                If ssGrid.ActiveCol = 2 Then
                    SSGRID1.Col = 2
                    SSGRID1.Row = I
                    If Trim(SSGRID1.Text) = "" Then
                        Call FillMenu()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SSGRID1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSGRID1.Advance
        Me.Hide()
    End Sub
    Private Sub FillMenu()
        Dim vform As New ListOperattion1
        Dim ssql As String
        gSQLString = " SELECT ISNULL(DETAILS,'') AS DETAILS,ISNULL(AMOUNT,0) FROM CONTRACT_DETAILS "
        vform.Field = "DETAILS,AMOUNT"
        vform.vFormatstring = "                                 DESCRIPTION                                        | AMOUNT    |"
        vform.vCaption = "ITEM CODE HELP"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With SSGRID1
                .Col = 2
                .Row = .ActiveRow
                .Text = vform.keyfield
                .Col = 3
                .Focus()
            End With
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub SSGRID1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSGRID1.KeyDownEvent
        Try
            Dim I As Integer
            If e.keyCode = Keys.Enter Then
                I = SSGRID1.ActiveRow
                If SSGRID1.ActiveCol = 2 Then
                    SSGRID1.Col = 2
                    SSGRID1.Row = I
                    If Trim(SSGRID1.Text) = "" Then
                        Call FillMenu()
                    End If
                End If
            End If
            If e.keyCode = Keys.F4 Then
                I = SSGRID1.ActiveRow
                If SSGRID1.ActiveCol = 2 Then
                    SSGRID1.Col = 2
                    SSGRID1.Row = I
                    If Trim(SSGRID1.Text) = "" Then
                        Call FillMenu()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            Dim rowj, Loopindex, i, in1, CountItem, Fo As Integer
            Dim ssqlstring, ssql, Servicecode, vCaption, vPath, str, serverdetail, Fsize(), INSERT(0) As String
            Dim Forder(), vFilepath, vOutfile, vheader, vline, sqlstring, SQLSTRING2, poscode As String
            Dim USERNAME, REMARKS, KOTNO As String
            Dim Filewrite As StreamWriter
            Dim vpagenumber, Vrowcount, innercount As Long
            Dim addUser As String

            '''************************************* Create .TXT file and write text *****************************'''
            sqlstring = "DELETE FROM CONTRACT_DETAILS WHERE CAST(CONVERT(CHAR(11),FROMDATE,6)  AS DATETIME)<='" & Format(DTP_FROMDATE.Value, "dd/MMM/yyyy") & "' and outlet='" & Trim(cbo_PaymentMode.Text) & "'"
            sqlstring = sqlstring & " AND CAST(CONVERT(CHAR(11),FROMDATE,6) AS DATETIME)<='" & Format(DTP_FROMDATE.Value, "dd/MMM/yyyy") & "'"
            INSERT(0) = sqlstring

            With SSGRID1
                For i = 1 To .DataRowCnt
                    .Row = i
                    .Col = 2
                    If Trim(.Text) <> "" Then
                        sqlstring = "Insert Into CONTRACT_DETAILS(Sno,TYPE,DETAILS,PERCENTAGE,AMOUNT,FROMDATE,TODATE,OUTLET,TDS)"
                        .Row = i
                        .Col = 1
                        sqlstring = sqlstring & "VALUES(" & i & ",'" & Trim(.Text) & "',"
                        .Row = i
                        .Col = 2
                        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                        .Row = i
                        .Col = 3
                        sqlstring = sqlstring & IIf(Val(Trim(.Text)) > 0, Val(Trim(.Text)), 0) & ","
                        .Row = i
                        .Col = 4
                        sqlstring = sqlstring & IIf(Val(Trim(.Text)) > 0, Val(Trim(.Text)), 0) & ","
                        sqlstring = sqlstring & "'" & Format(DTP_FROMDATE.Value, "dd/MMM/yyyy") & "',"
                        sqlstring = sqlstring & "'" & Format(DTP_TODATE.Value, "dd/MMM/yyyy") & "',"
                        sqlstring = sqlstring & "'" & Trim(cbo_PaymentMode.Text) & "'," & IIf(Val(TXT_TDSPRC.Text) > 0, Val(TXT_TDSPRC.Text), 0) & ")"
                        ReDim Preserve INSERT(INSERT.Length)
                        INSERT(INSERT.Length - 1) = sqlstring
                        sqlstring = ""
                    End If
                Next
            End With
            gconnection.MoreTransold1(INSERT)
            sqlstring = " Select  BILLDATE,BILLAMOUNT,TAXAMOUNT,ROUNDOFF,TOTALAMOUNT from VIEW_CONTRACT_DETAILS WHERE OUTLET='" & cbo_PaymentMode.Text & "'"
            sqlstring = sqlstring & " AND BILLDATE BETWEEN '" & Format(DTP_FROMDATE.Value, "dd/MMM/yyyy") & "' and  '" & Format(DTP_TODATE.Value, "dd/MMM/yyyy") & "'"

            SQLSTRING2 = "SELECT isnull(details,'') as Details,isnull(percentage,0) as percentage,isnull(amount,0) as amount FROM CONTRACT_DETAILS "
            SQLSTRING2 = SQLSTRING2 & " Where CAST(CONVERT(CHAR(11),fromdate,6) AS DATETIME) ='" & Format(DTP_FROMDATE.Value, "dd/MMM/yyyy") & "' and CAST(CONVERT(CHAR(11),todate,6) AS DATETIME)='" & Format(DTP_TODATE.Value, "dd/MMM/yyyy") & "' AND RTRIM(LTRIM(OUTLET))='" & Trim(cbo_PaymentMode.Text) & "' ORDER BY SNO"
            Dim heading() As String = {" CONTRACT DETAILS "}
            Dim Objcreditsaleregister As New contract_details1
            Objcreditsaleregister.Reportdetails(sqlstring, SQLSTRING2, heading, DTP_FROMDATE.Value, DTP_TODATE.Value, cbo_PaymentMode.Text, Format(Val(TXT_TDSPRC.Text), "0.00"))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub OUTLET()
        Dim sqlstring As String
        Dim index As Integer
        Dim i As Integer
        Try
            sqlstring = " SELECT POSDESC FROM POSMASTER "
            cbo_PaymentMode.Items.Clear()
            gconnection.getDataSet(sqlstring, "paymentmodemaster")
            If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("paymentmodemaster").Rows.Count - 1
                    cbo_PaymentMode.Items.Add(gdataset.Tables("paymentmodemaster").Rows(i).Item("POSDESC"))
                Next i
                cbo_PaymentMode.SelectedIndex = 0
            Else
                MessageBox.Show("Plz Select Outlet", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CONTRACT_DETAILS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OUTLET()
        DTP_FROMDATE.Value = Format(Now(), "dd/MM/yyyy")
        DTP_TODATE.Value = Format(Now(), "dd/MM/yyyy")
        SSGRID1.ClearRange(1, 1, -1, -1, True)
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        DTP_FROMDATE.Value = Format(Now(), "dd/MM/yyyy")
        DTP_TODATE.Value = Format(Now(), "dd/MM/yyyy")
        SSGRID1.ClearRange(1, 1, -1, -1, True)
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
    End Sub
    Private Sub cbo_PaymentMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_PaymentMode.SelectedIndexChanged
        Try
            Dim INSERT(0) As String
            Dim I As Integer
            SSGRID1.ClearRange(1, 1, -1, -1, True)
            SSGRID1.SetActiveCell(1, 1)
            SQLSTRING = "select ISNULL(TYPE,'') AS TYPE,ISNULL(DETAILS,'') AS DETAILS,ISNULL(PERCENTAGE,0) AS PERCENTAGE,ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(TDS,0) AS TDS from CONTRACT_DETAILS"
            SQLSTRING = SQLSTRING & " WHERE CAST(CONVERT(CHAR(11),FROMDATE,6) AS DATETIME) ='" & Format(DTP_FROMDATE.Value, "dd/MMM/yyyy") & "' "
            SQLSTRING = SQLSTRING & " AND CAST(CONVERT(CHAR(11),TODATE,6) AS DATETIME)='" & Format(DTP_TODATE.Value, "dd/MMM/yyyy") & "' AND OUTLET='" & Trim(cbo_PaymentMode.Text) & "'"
            gconnection.getDataSet(SQLSTRING, "paymentmodemaster")
            If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                TXT_TDSPRC.Text = gdataset.Tables("paymentmodemaster").Rows(I).Item("TDS")
                With SSGRID1
                    For I = 0 To gdataset.Tables("paymentmodemaster").Rows.Count - 1
                        .Row = .ActiveRow
                        .Col = 2
                        .Text = gdataset.Tables("paymentmodemaster").Rows(I).Item("DETAILS")
                        .Row = .ActiveRow
                        .Col = 3
                        .Row = .ActiveRow
                        .Text = gdataset.Tables("paymentmodemaster").Rows(I).Item("PERCENTAGE")
                        .Col = 4
                        .Row = .ActiveRow
                        .Text = gdataset.Tables("paymentmodemaster").Rows(I).Item("AMOUNT")
                        .SetActiveCell(1, .ActiveRow + 1)
                    Next
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cbo_PaymentMode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_PaymentMode.LostFocus
        cbo_PaymentMode_SelectedIndexChanged(sender, e)
    End Sub
End Class
