Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web

Public Class postingaudittraildet
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents grp_Billposting As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_head As System.Windows.Forms.Label
    Friend WithEvents Cmd_Fill As System.Windows.Forms.Button
    Friend WithEvents lbl_Fromdate As System.Windows.Forms.Label
    Friend WithEvents dtp_Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Todate As System.Windows.Forms.Label
    Friend WithEvents dtp_Todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Comb_MD As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(postingaudittraildet))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.cmd_view = New System.Windows.Forms.Button()
        Me.cmd_exit = New System.Windows.Forms.Button()
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread()
        Me.grp_Billposting = New System.Windows.Forms.GroupBox()
        Me.lbl_Todate = New System.Windows.Forms.Label()
        Me.dtp_Todate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_head = New System.Windows.Forms.Label()
        Me.Cmd_Fill = New System.Windows.Forms.Button()
        Me.lbl_Fromdate = New System.Windows.Forms.Label()
        Me.dtp_Fromdate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Comb_MD = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Billposting.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmd_clear)
        Me.Panel1.Controls.Add(Me.cmd_view)
        Me.Panel1.Controls.Add(Me.cmd_exit)
        Me.Panel1.Location = New System.Drawing.Point(856, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 430)
        Me.Panel1.TabIndex = 6
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(8, 356)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(143, 33)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Final Workings"
        Me.Button8.Visible = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(8, 317)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(143, 33)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Workings"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(8, 278)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(143, 33)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Bar Sales"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(8, 238)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 34)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Charge Account"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(8, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 32)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Subscription"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(8, 160)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(146, 34)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Non Ac/Payee"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(8, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Guest Charges"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Entrance Fee"
        '
        'cmd_clear
        '
        Me.cmd_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.Location = New System.Drawing.Point(8, 8)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(139, 30)
        Me.cmd_clear.TabIndex = 1
        Me.cmd_clear.Text = "Clear"
        '
        'cmd_view
        '
        Me.cmd_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.Location = New System.Drawing.Point(8, 44)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(139, 31)
        Me.cmd_view.TabIndex = 1
        Me.cmd_view.Text = "Export"
        '
        'cmd_exit
        '
        Me.cmd_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit.Location = New System.Drawing.Point(8, 395)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(139, 29)
        Me.cmd_exit.TabIndex = 1
        Me.cmd_exit.Text = "Exit"
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(14, 93)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(831, 431)
        Me.ssgrid.TabIndex = 5
        '
        'grp_Billposting
        '
        Me.grp_Billposting.Controls.Add(Me.lbl_Todate)
        Me.grp_Billposting.Controls.Add(Me.dtp_Todate)
        Me.grp_Billposting.Controls.Add(Me.lbl_head)
        Me.grp_Billposting.Controls.Add(Me.Cmd_Fill)
        Me.grp_Billposting.Controls.Add(Me.lbl_Fromdate)
        Me.grp_Billposting.Controls.Add(Me.dtp_Fromdate)
        Me.grp_Billposting.Controls.Add(Me.Label2)
        Me.grp_Billposting.Controls.Add(Me.Comb_MD)
        Me.grp_Billposting.Location = New System.Drawing.Point(16, 8)
        Me.grp_Billposting.Name = "grp_Billposting"
        Me.grp_Billposting.Size = New System.Drawing.Size(872, 80)
        Me.grp_Billposting.TabIndex = 7
        Me.grp_Billposting.TabStop = False
        '
        'lbl_Todate
        '
        Me.lbl_Todate.AutoSize = True
        Me.lbl_Todate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Todate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Todate.Location = New System.Drawing.Point(208, 40)
        Me.lbl_Todate.Name = "lbl_Todate"
        Me.lbl_Todate.Size = New System.Drawing.Size(67, 15)
        Me.lbl_Todate.TabIndex = 9
        Me.lbl_Todate.Text = "TO DATE :"
        '
        'dtp_Todate
        '
        Me.dtp_Todate.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_Todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Todate.Location = New System.Drawing.Point(280, 40)
        Me.dtp_Todate.Name = "dtp_Todate"
        Me.dtp_Todate.Size = New System.Drawing.Size(96, 26)
        Me.dtp_Todate.TabIndex = 8
        '
        'lbl_head
        '
        Me.lbl_head.BackColor = System.Drawing.Color.Maroon
        Me.lbl_head.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_head.ForeColor = System.Drawing.Color.White
        Me.lbl_head.Location = New System.Drawing.Point(112, 8)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(376, 24)
        Me.lbl_head.TabIndex = 7
        Me.lbl_head.Text = "GST DETAILS REPORT"
        Me.lbl_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmd_Fill
        '
        Me.Cmd_Fill.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Fill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fill.ForeColor = System.Drawing.Color.White
        Me.Cmd_Fill.Location = New System.Drawing.Point(392, 40)
        Me.Cmd_Fill.Name = "Cmd_Fill"
        Me.Cmd_Fill.Size = New System.Drawing.Size(72, 32)
        Me.Cmd_Fill.TabIndex = 2
        Me.Cmd_Fill.Text = "FILL"
        Me.Cmd_Fill.UseVisualStyleBackColor = False
        '
        'lbl_Fromdate
        '
        Me.lbl_Fromdate.AutoSize = True
        Me.lbl_Fromdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fromdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fromdate.Location = New System.Drawing.Point(8, 40)
        Me.lbl_Fromdate.Name = "lbl_Fromdate"
        Me.lbl_Fromdate.Size = New System.Drawing.Size(86, 15)
        Me.lbl_Fromdate.TabIndex = 5
        Me.lbl_Fromdate.Text = "FROM DATE :"
        '
        'dtp_Fromdate
        '
        Me.dtp_Fromdate.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_Fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Fromdate.Location = New System.Drawing.Point(104, 40)
        Me.dtp_Fromdate.Name = "dtp_Fromdate"
        Me.dtp_Fromdate.Size = New System.Drawing.Size(96, 26)
        Me.dtp_Fromdate.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(488, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "MODULE"
        '
        'Comb_MD
        '
        Me.Comb_MD.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comb_MD.Items.AddRange(New Object() {"ALL", "ACCOUNTS", "ALLSALE", "ALLSALEGST", "ALLSALENONGST", "ALLRECIPTS", "ALLPURCHASE", "VOUCHERCONTROL", "HSN SUMMARY", "SUMMARY FOR B2CS", "NIL RATED, EXEMPTED AND NON GST SUPPLIES", "GSTR3B", "OUTWORDSALES", "INVENTORY", "B2BREPORT"})
        Me.Comb_MD.Location = New System.Drawing.Point(560, 24)
        Me.Comb_MD.Name = "Comb_MD"
        Me.Comb_MD.Size = New System.Drawing.Size(304, 31)
        Me.Comb_MD.TabIndex = 176
        '
        'postingaudittraildet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.grp_Billposting)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ssgrid)
        Me.Name = "postingaudittraildet"
        Me.Text = "postingaudittraildet"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Billposting.ResumeLayout(False)
        Me.grp_Billposting.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Cmd_Audit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        Try


            Call ExportTo(ssgrid)

        Catch ex As Exception
            MessageBox.Show("Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        ssgrid.ClearRange(1, 1, -1, -1, True)
        Me.dtp_Fromdate.Value = Format(Now, "dd-MMM-yyyy")
        Me.dtp_Todate.Value = Format(Now, "dd-MMM-yyyy")
    End Sub

    Private Sub postingaudittraildet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtp_Fromdate.Value = Format(Now, "dd-MMM-yyyy")
        Me.dtp_Todate.Value = Format(Now, "dd-MMM-yyyy")
        'If Mid(UCase(MyCompanyName), 1, 6) = "KARNAT" Then
        '    ComboBox1.Items.Clear()
        '    ComboBox1.Items.Add("DAILY")
        '    ComboBox1.Items.Add("MONTHLY")
        '    ComboBox1.Items.Add("POS")
        'End If
    End Sub

    Private Sub Cmd_Fill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Fill.Click
        ssgrid.ClearRange(1, 1, -1, -1, True)
        Dim ssql As String
        Dim AMOUNT, IGST, SGST, CGST, CESS, ADDCESS, EXEMPTED As Double
        'myconnection.Open(gTallyDsn)

        'If Format(dtp_Fromdate.Value, "MM/dd/yyyy") < "07/01/2017" Then
        '    MsgBox("From Date can't be less than the 01/JUL/2017...!!!")
        '    Exit Sub
        'End If

     

        Dim SQLSTRING As String
        SQLSTRING = "  SELECT * FROM sysobjects  WHERE type='V' and name = 'rpt_revenue_viewgstrnew'"
        gconnection.getDataSet(SQLSTRING, "sys")
        If gdataset.Tables("sys").Rows.Count > 0 Then
        Else
            MsgBox("view not created kindly check..")
            Exit Sub
        End If
        SQLSTRING = "  SELECT * FROM sysobjects  WHERE type='U' and name = 'GSTREVENUE'"
        gconnection.getDataSet(SQLSTRING, "sys")
        If gdataset.Tables("sys").Rows.Count > 0 Then
            SQLSTRING = " SELECT * FROM GSTREVENUE WHERE MONTH(BILLDATE)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') "
            gconnection.getDataSet(SQLSTRING, "DATA")
            If gdataset.Tables("DATA").Rows.Count > 0 Then
                If MsgBox("DATA IS CREATED FOR THE MONTH DO YOU WANT TO DOWNLOAD IT ONE MORE TIME IF ANY UPDATE HAPPENED IN EDIT MODE WILL ERASE", MsgBoxStyle.YesNo, "Clubman Accounts") = MsgBoxResult.Yes Then
                    SQLSTRING = " DELETE FROM GSTREVENUE WHERE MONTH(BILLDATE)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')"
                    gconnection.ExcuteStoreProcedure(SQLSTRING)
                    Dim CODESC As String
                    Dim N As Integer
                    SQLSTRING = " SELECT TOP 1 * FROM rpt_revenue_viewgstrnew  "
                    gconnection.getDataSet(SQLSTRING, "DATA1")
                    If gdataset.Tables("DATA1").Rows.Count > 0 Then
                        For N = 0 To gdataset.Tables("DATA1").Columns.Count - 1
                            If UCase(gdataset.Tables("DATA1").Columns(N).ColumnName) <> "ROWID" Then
                                If N = 0 Then
                                    CODESC = "[" & gdataset.Tables("DATA1").Columns(N).ColumnName & "]"
                                Else
                                    CODESC = CODESC & ",[" & gdataset.Tables("DATA1").Columns(N).ColumnName & "]"
                                End If
                            End If
                        Next
                    End If
                    SQLSTRING = " INSERT INTO GSTREVENUE(" & CODESC & ")  SELECT " & CODESC & " FROM rpt_revenue_viewgstrnew WHERE MONTH(BILLDATE)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')"
                    gconnection.ExcuteStoreProcedure(SQLSTRING)
                    'SQLSTRING = " ALTER TABLE GSTREVENUE ADD ROWID NUMERIC(18,0) IDENTITY(1,1) PRIMARY KEY"
                    'gconnection.ExcuteStoreProcedure(SQLSTRING)
                    MsgBox("DATA SYNCED")

                End If
            Else
                Dim CODESC As String
                Dim N As Integer
                SQLSTRING = " SELECT TOP 1 * FROM rpt_revenue_viewgstrnew  "
                gconnection.getDataSet(SQLSTRING, "DATA1")
                If gdataset.Tables("DATA1").Rows.Count > 0 Then
                    For N = 0 To gdataset.Tables("DATA1").Columns.Count - 1
                        If UCase(gdataset.Tables("DATA1").Columns(N).ColumnName) <> "ROWID" Then
                            If N = 0 Then
                                CODESC = "[" & gdataset.Tables("DATA1").Columns(N).ColumnName & "]"
                            Else
                                CODESC = CODESC & ",[" & gdataset.Tables("DATA1").Columns(N).ColumnName & "]"
                            End If
                        End If
                    Next
                End If
                SQLSTRING = " INSERT INTO GSTREVENUE(" & CODESC & ")  SELECT " & CODESC & " FROM rpt_revenue_viewgstrnew WHERE MONTH(BILLDATE)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')"
                gconnection.ExcuteStoreProcedure(SQLSTRING)
                MsgBox("DATA SYNCED")
            End If

        Else
            SQLSTRING = " SELECT * INTO GSTREVENUE FROM rpt_revenue_viewgstrnew WHERE MONTH(BILLDATE)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')"
            gconnection.ExcuteStoreProcedure(SQLSTRING)
            SQLSTRING = " ALTER TABLE GSTREVENUE ADD ROWID NUMERIC(18,0) IDENTITY(1,1)  PRIMARY KEY"
            gconnection.ExcuteStoreProcedure(SQLSTRING)
        End If
        If MsgBox("DO YOU WAND EDIT MODE TO ENABLE.. ", MsgBoxStyle.YesNo, "Clubman Accounts") = MsgBoxResult.Yes Then
            GSTSQL = " SELECT * FROM GSTREVENUE  WHERE MONTH(BILLDATE)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')"
            Dim GSTUP As New GSTRUPDATE
            GSTUP.Show()
            Exit Sub
        End If
        Dim I, ROWCOUNT, J, K, CNT As Integer

        Dim strstring, sqlstring1, LEDGER As String


        ''B2BREPORT
        If Comb_MD.Text = "B2BREPORT" Then

            Try

                Dim cmdText As String
                Dim duedate, membertype, TYPE(0), bildt1, BILLDT2, MONTH2, BILDT3, BILLDT4 As String
                '   Dim opl, i As Integer
                ''  Call Validation()
                'If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : MONTH = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : MONTH2 = "04" : BILLDT2 = "30/apr/" & gFinancalyearStart : BILDT3 = "01/04/" & gFinancalyearStart : BILLDT4 = "30/04/" & gFinancalyearStart
                'If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : MONTH = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : MONTH2 = "05" : BILLDT2 = "31/may/" & gFinancalyearStart : BILDT3 = "01/05/" & gFinancalyearStart : BILLDT4 = "31/05/" & gFinancalyearStart
                'If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : MONTH = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : MONTH2 = "06" : BILLDT2 = "30/jun/" & gFinancalyearStart : BILDT3 = "01/06/" & gFinancalyearStart : BILLDT4 = "30/06/" & gFinancalyearStart
                'If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : MONTH = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : MONTH2 = "07" : BILLDT2 = "31/jul/" & gFinancalyearStart : BILDT3 = "01/07/" & gFinancalyearStart : BILLDT4 = "31/07/" & gFinancalyearStart
                'If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : MONTH = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : MONTH2 = "08" : BILLDT2 = "31/aug/" & gFinancalyearStart : BILDT3 = "01/08/" & gFinancalyearStart : BILLDT4 = "31/08/" & gFinancalyearStart
                'If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : MONTH = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : MONTH2 = "09" : BILLDT2 = "30/sep/" & gFinancalyearStart : BILDT3 = "01/09/" & gFinancalyearStart : BILLDT4 = "30/09/" & gFinancalyearStart
                'If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : MONTH = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : MONTH2 = "10" : BILLDT2 = "31/oct/" & gFinancalyearStart : BILDT3 = "01/10/" & gFinancalyearStart : BILLDT4 = "31/10/" & gFinancalyearStart
                'If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : MONTH = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : MONTH2 = "11" : BILLDT2 = "30/nov/" & gFinancalyearStart : BILDT3 = "01/11/" & gFinancalyearStart : BILLDT4 = "30/11/" & gFinancalyearStart
                'If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : MONTH = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : MONTH2 = "12" : BILLDT2 = "31/dec/" & gFinancalyearStart : BILDT3 = "01/12/" & gFinancalyearStart : BILLDT4 = "31/12/" & gFinancalyearStart
                'If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : MONTH = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialYearEnd : MONTH2 = "01" : BILLDT2 = "31/jan/" & gFinancialYearEnd : BILDT3 = "01/01/" & gFinancialYearEnd : BILLDT4 = "31/01/" & gFinancialYearEnd
                ''If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : MONTH = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : MONTH2 = "02" : BILLDT2 = "28/feb/" & gFinancialyearEnd : BILDT3 = "01/02/" & gFinancialyearEnd : BILLDT4 = "28/02/" & gFinancialyearEnd
                'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then
                '    MNTH2 = gFinancialYearEnd Mod 4
                '    month1 = 2
                '    MONTH = "FEB"
                '    MONTH2 = "02"
                '    If MNTH2 = 0 Then
                '        noofdays = 29
                '        bildt = "01/feb/" & gFinancialYearEnd
                '        BILLDT2 = "29/feb/" & gFinancialYearEnd
                '    Else
                '        noofdays = 28
                '        bildt = "01/feb/" & gFinancialYearEnd
                '        BILLDT2 = "28/feb/" & gFinancialYearEnd
                '    End If
                'End If
                'If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : MONTH = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialYearEnd : MONTH2 = "03" : BILLDT2 = "31/mar/" & gFinancialYearEnd : BILDT3 = "01/03/" & gFinancialYearEnd : BILLDT4 = "31/03/" & gFinancialYearEnd


                Dim MONTH3 As String
                ''  DATE1 = Format(dtp_Fromdate.Value, "dd/MMM/yyyy")
                ' MONTH2 = MONTH(DATE1)

                MONTH3 = Month(Format(dtp_Fromdate.Value, "dd/MMM/yyyy"))

                SQLSTRING = "exec PROC_mem_consum_GST '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' "
                gconnection.dataOperation(7, SQLSTRING, "BILL1")


                Dim Viewer As New ReportViwer
                '  If Rad_GSTINNO.Checked = True Then
                '' Dim r As New Cry_Det
                Dim r As New Cry_GSTINNO


                sqlstring1 = "select TAXCODE,sum(amount) amount,sum(SGST) SGST,SUM(CGST)CGST,SUM(CES) CES ,SUM(TOTAL) TOTAL , TaxPercentage,C.MCODE,ISNULL(C.Abillno ,'')Abillno,C.BILLDate from mem_consumGST C,membermaster m where C.mcode=m.mcode  group by TAXCODE, TaxPercentage,C.MCODE,Abillno,BILLDate "


                '  End If


                Call Viewer.GetDetails1(sqlstring1, "mem_consumGST", r)
                'Call Viewer.GetDetails1(sqlstring, "member_consumption_det", r)
                'Dim txtobj15 As TextObject
                Dim txtobj19 As TextObject
                'Dim txtobj20 As TextObject
                'Dim TXTOBJ21 As TextObject
                'Dim TXTOBJ22 As TextObject
                'Dim TXTOBJ23 As TextObject
                'Dim TXTOBJ24 As TextObject

                'txtobj19 = r.ReportDefinition.ReportObjects("Text27")
                'txtobj19.Text = MONTH & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

                txtobj19 = r.ReportDefinition.ReportObjects("Text2")
                txtobj19.Text = MONTH3



                Viewer.Show()
                '  End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
        If Comb_MD.Text = "GSTR3B" Then
            strstring = " EXEC PROC_GSTR3B31   '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' , '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' "
            gconnection.ExcuteStoreProcedure(strstring)

            strstring = " SELECT ISNULL(GSTR3B,'')GSTR3B , ISNULL(NATUREOFSUPPLY,'')NATUREOFSUPPLY ,ISNULL(SUM(TAXABLEVALUE),0)TAXABLEVALUE,ISNULL(SUM(INTEGRATEDTAX),0)INTEGRATEDTAX,"
            strstring = strstring & " ISNULL(SUM(CENTRALTAX),0)CENTRALTAX,ISNULL(SUM(STATEUTTAX),0)STATEUTTAX,ISNULL(SUM(CESSAMOUNT),0)CESSAMOUNT FROM GSTR3B31"
            strstring = strstring & "  GROUP BY GSTR3B,NATUREOFSUPPLY"
            gconnection.getDataSet(strstring, "GSTR3B1")
            If gdataset.Tables("GSTR3B1").Rows.Count > 0 Then
                ssgrid.ClearRange(1, 1, -1, -1, True)
                I = 0
                With ssgrid
                    .Col = 1
                    .Row = I + 1
                    .Text = "GSTR3B"
                    .Col = 2
                    .Row = I + 1
                    .Text = "NATURE OF SUPPLY"
                    .Col = 3
                    .Row = I + 1
                    .Text = "TOTAL TAXABLE VALUE"
                    .Col = 4
                    .Row = I + 1
                    .Text = "INTEGRATED TAX "
                    .Col = 5
                    .Row = I + 1
                    .Text = "CENTRAL TAX"
                    .Col = 6
                    .Row = I + 1
                    .Text = " STATE/UT TAX"
                    .Col = 7
                    .Row = I + 1
                    .Text = "CESS "
                End With
            End If
            If gdataset.Tables("GSTR3B1").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("GSTR3B1").Rows.Count - 1
                    With ssgrid
                        .Col = 1
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("GSTR3B1").Rows(I).Item("GSTR3B"))
                        .Col = 2
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("GSTR3B1").Rows(I).Item("NATUREOFSUPPLY"))

                        .Col = 3
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("GSTR3B1").Rows(I).Item("TAXABLEVALUE"))

                        .Col = 4
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("GSTR3B1").Rows(I).Item("INTEGRATEDTAX"))
                        .Col = 5
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("GSTR3B1").Rows(I).Item("CENTRALTAX"))

                        .Col = 6
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("GSTR3B1").Rows(I).Item("STATEUTTAX"))
                        .Col = 7
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("GSTR3B1").Rows(I).Item("CESSAMOUNT"))
                    End With
                Next
            End If

            J = gdataset.Tables("GSTR3B1").Rows.Count + 3
            CNT = gdataset.Tables("GSTR3B1").Rows.Count + 3

            strstring = " EXEC PROC_GSTR3B32   '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' , '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' "
            gconnection.ExcuteStoreProcedure(strstring)

            strstring = " SELECT ISNULL(GSTR3B,'')GSTR3B,ISNULL(NATUREOFSUPPLY,'')NATUREOFSUPPLY,ISNULL(PLACEOFSUPPLY,'')PLACEOFSUPPLY,ISNULL(SUM(TAXABLEVALUE),0)TAXABLEVALUE,"
            strstring = strstring & " ISNULL(SUM(IGSTAMOUNT),0)IGSTAMOUNT FROM GSTR3B32 GROUP BY GSTR3B,PLACEOFSUPPLY,NATUREOFSUPPLY"
            gconnection.getDataSet(strstring, "GSTR3B2")
            If gdataset.Tables("GSTR3B2").Rows.Count > 0 Then
                '' ssgrid.ClearRange(1, 1, -1, -1, True)
                I = J
                With ssgrid
                    .Col = 1
                    .Row = I + 1
                    .Text = "GSTR3B"
                    .Col = 2
                    .Row = I + 1
                    .Text = "NATURE OF SUPPLY"
                    .Col = 3
                    .Row = I + 1
                    .Text = "PLACE OF SUPPLY STATE/UT"
                    .Col = 4
                    .Row = I + 1
                    .Text = "TOTAL TAXABLE VALUE "
                    .Col = 5
                    .Row = I + 1
                    .Text = "AMOUNT OF IGST"

                End With
            End If
            If gdataset.Tables("GSTR3B2").Rows.Count > 0 Then

                For K = 0 To gdataset.Tables("GSTR3B2").Rows.Count - 1
                    With ssgrid

                        .Col = 1
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3B2").Rows(K).Item("GSTR3B"))
                        .Col = 2
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3B2").Rows(K).Item("NATUREOFSUPPLY"))

                        .Col = 3
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3B2").Rows(K).Item("PLACEOFSUPPLY"))

                        .Col = 4
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3B2").Rows(K).Item("TAXABLEVALUE"))
                        .Col = 5
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3B2").Rows(K).Item("IGSTAMOUNT"))
                        CNT = CNT + 1
                    End With
                Next
            End If

            ''''''''''''''''ITC ELIGIBLE'''''''''''''''''
            J = J + gdataset.Tables("GSTR3B2").Rows.Count + 3
            CNT = J
            strstring = " EXEC PROC_GSTR3BITC   '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' , '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' "
            gconnection.ExcuteStoreProcedure(strstring)


            strstring = " SELECT ISNULL(GSTR3B,'')GSTR3B,ISNULL(DETAILS,'')DETAILS,ISNULL(SUM(IGST),0)IGST,ISNULL(SUM(CGST),0)CGST,ISNULL(SUM(SGST_UTGST),0)SGST_UTGST,ISNULL(SUM(CESS),0)CESS"
            strstring = strstring & " FROM GSTR3BITCELIGIBLE GROUP BY GSTR3B,DETAILS"

            gconnection.getDataSet(strstring, "GSTR3BITC")
            If gdataset.Tables("GSTR3BITC").Rows.Count > 0 Then
                '' ssgrid.ClearRange(1, 1, -1, -1, True)
                I = J
                With ssgrid
                    .Col = 1
                    .Row = I + 1
                    .Text = "GSTR3B"
                    .Col = 2
                    .Row = I + 1
                    .Text = "DETAIL"
                    .Col = 3
                    .Row = I + 1
                    .Text = "IGST"
                    .Col = 4
                    .Row = I + 1
                    .Text = "CGST"
                    .Col = 5
                    .Row = I + 1
                    .Text = "SGST/UTGST "
                    .Col = 6
                    .Row = I + 1
                    .Text = "CESS"

                End With
            End If

            If gdataset.Tables("GSTR3BITC").Rows.Count > 0 Then

                For K = 0 To gdataset.Tables("GSTR3BITC").Rows.Count - 1
                    With ssgrid

                        .Col = 1
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BITC").Rows(K).Item("GSTR3B"))
                        .Col = 2
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BITC").Rows(K).Item("DETAILS"))

                        .Col = 3
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BITC").Rows(K).Item("IGST"))

                        .Col = 4
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BITC").Rows(K).Item("CGST"))
                        .Col = 5
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BITC").Rows(K).Item("SGST_UTGST"))
                        .Col = 6
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BITC").Rows(K).Item("CESS"))
                        CNT = CNT + 1
                    End With
                Next
            End If




            ''''''''''''''''NIL RATED , EXEMPTED NON GST SUPPLIES'''''''''''''''''
            J = J + gdataset.Tables("GSTR3BITC").Rows.Count + 3
            CNT = J
            strstring = " EXEC PROC_NILEXEMNONGST   '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' , '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' "
            gconnection.ExcuteStoreProcedure(strstring)

            strstring = " SELECT ISNULL(GSTR3B,'')GSTR3B , ISNULL(NATUREOFSUPPLY,'')NATUREOFSUPPLY ,ISNULL(SUM(INTRASTATE),0)INTRASTATE,ISNULL(SUM(INTERSTATE),0)INTERSTATE FROM GSTR3BNILEXEMNONGST"
            strstring = strstring & " GROUP BY GSTR3B,NATUREOFSUPPLY"

            gconnection.getDataSet(strstring, "GSTR3BNIL")
            If gdataset.Tables("GSTR3BNIL").Rows.Count > 0 Then
                '' ssgrid.ClearRange(1, 1, -1, -1, True)
                I = J
                With ssgrid
                    .Col = 1
                    .Row = I + 1
                    .Text = "GSTR3B"
                    .Col = 2
                    .Row = I + 1
                    .Text = "NATURE OF SUPPLIES"
                    .Col = 3
                    .Row = I + 1
                    .Text = "INTER STATE SUPPLIES"
                    .Col = 4
                    .Row = I + 1
                    .Text = "INTRA STATE SUPPLIES"


                End With
            End If

            If gdataset.Tables("GSTR3BNIL").Rows.Count > 0 Then

                For K = 0 To gdataset.Tables("GSTR3BNIL").Rows.Count - 1
                    With ssgrid

                        .Col = 1
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BNIL").Rows(K).Item("GSTR3B"))
                        .Col = 2
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BNIL").Rows(K).Item("NATUREOFSUPPLY"))

                        .Col = 3
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BNIL").Rows(K).Item("INTERSTATE"))

                        .Col = 4
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BNIL").Rows(K).Item("INTRASTATE"))
                        CNT = CNT + 1
                    End With
                Next
            End If

            ''''''''''''''''PAYMENT OF TAX'''''''''''''''''
            J = J + gdataset.Tables("GSTR3BNIL").Rows.Count + 3
            CNT = J
            strstring = " EXEC PROC_GSTR3BPAYMENT  "
            gconnection.ExcuteStoreProcedure(strstring)

            strstring = " SELECT ISNULL(GSTR3B,'')GSTR3B ,ISNULL(DESCRIPTION,'')DESCRIPTION,ISNULL(SUM(TAXPAYBLE),0)TAXPAYBLE,ISNULL(SUM(IGST),0)IGST,ISNULL(SUM(CGST),0)CGST,ISNULL(SUM(SGST_UTGST),0)SGST_UTGST,ISNULL(SUM(CESS),0)CESS"
            strstring = strstring & "   ,ISNULL(SUM(TAXPAIDTDS_TCS),0)TAXPAIDTDS_TCS,ISNULL(SUM(TAXCESS_PAIDCASH),0)TAXCESS_PAIDCASH,ISNULL(SUM(INTEREST),0)INTEREST,ISNULL(SUM(LATE_FEE),0)LATE_FEE FROM GSTR3BPAYMENT"
            strstring = strstring & "  GROUP BY GSTR3B,DESCRIPTION"

            gconnection.getDataSet(strstring, "GSTR3BPAYMENT")
            If gdataset.Tables("GSTR3BPAYMENT").Rows.Count > 0 Then
                '' ssgrid.ClearRange(1, 1, -1, -1, True)
                I = J
                With ssgrid
                    .Col = 1
                    .Row = I + 1
                    .Text = "GSTR3B"
                    .Col = 2
                    .Row = I + 1
                    .Text = "DESCRIPTION"
                    .Col = 3
                    .Row = I + 1
                    .Text = "TAX PAYABLE"
                    .Col = 4
                    .Row = I + 1
                    .Text = "IGST"
                    .Col = 5
                    .Row = I + 1
                    .Text = "CGST"
                    .Col = 6
                    .Row = I + 1
                    .Text = "SGST/UTGST"
                    .Col = 7
                    .Row = I + 1
                    .Text = "CESS"
                    .Col = 8
                    .Row = I + 1
                    .Text = "TAX PAID TDS/TCS"
                    .Col = 9
                    .Row = I + 1
                    .Text = "TAX/CESS PAID IN CASH"
                    .Col = 10
                    .Row = I + 1
                    .Text = "INTEREST"
                    .Col = 11
                    .Row = I + 1
                    .Text = "LATE FEE"


                End With
            End If

            If gdataset.Tables("GSTR3BPAYMENT").Rows.Count > 0 Then

                For K = 0 To gdataset.Tables("GSTR3BPAYMENT").Rows.Count - 1
                    With ssgrid

                        .Col = 1
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("GSTR3B"))
                        .Col = 2
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("DESCRIPTION"))

                        .Col = 3
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("TAXPAYBLE"))

                        .Col = 4
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("IGST"))

                        .Col = 5
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("CGST"))
                        .Col = 6
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("SGST_UTGST"))

                        .Col = 7
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("CESS"))

                        .Col = 8
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("TAXPAIDTDS_TCS"))


                        .Col = 9
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("TAXCESS_PAIDCASH"))

                        .Col = 10
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("INTEREST"))
                        .Col = 11
                        .Row = CNT + 3
                        .Text = Trim(gdataset.Tables("GSTR3BPAYMENT").Rows(K).Item("LATE_FEE"))
                        CNT = CNT + 1
                    End With
                Next
            End If



        End If

        If Comb_MD.Text = "NIL RATED, EXEMPTED AND NON GST SUPPLIES" Then

            strstring = " EXEC NILLEXEMNONGSTSUP   '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' , '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' "
            gconnection.ExcuteStoreProcedure(strstring)

            strstring = " SELECT  ISNULL(DESCRIPTION,'')DESCRIPTION ,ISNULL(SUM(NILLRATED),0)NILLRATED,ISNULL(SUM(EXEMPTED),0)EXEMPTED FROM NILRATEDEXEMPTEDNONGSTSUPPLIES   GROUP BY DESCRIPTION"
            gconnection.getDataSet(strstring, "Voucher")
            If gdataset.Tables("Voucher").Rows.Count > 0 Then
                ssgrid.ClearRange(1, 1, -1, -1, True)
                I = 0
                With ssgrid
                    .Col = 1
                    .Row = I + 1
                    .Text = "DESCRIPTION"
                    .Col = 2
                    .Row = I + 1
                    .Text = "NIL RATED SUPPLIES"
                    .Col = 3
                    .Row = I + 1
                    .Text = "EXEMPTED (Other than nil rated/Non GST supply)"
                    .Col = 4
                    .Row = I + 1
                    .Text = "NON GST Supplies "
                End With
            End If
            If gdataset.Tables("Voucher").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("Voucher").Rows.Count - 1
                    With ssgrid
                        .Col = 1
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("DESCRIPTION"))
                        .Col = 2
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("NILLRATED"))
                        AMOUNT = Trim(gdataset.Tables("Voucher").Rows(I).Item("NILLRATED"))
                        .Col = 3
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("EXEMPTED"))
                        EXEMPTED = Trim(gdataset.Tables("Voucher").Rows(I).Item("EXEMPTED"))

                        .Col = 4
                        .Row = I + 3
                        .Text = AMOUNT + EXEMPTED


                    End With
                Next
            End If


        End If

        If Comb_MD.Text = "SUMMARY FOR B2CS" Then


            strstring = " IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'SUMMARYB2CS')"
            strstring = strstring & " Begin  CREATE TABLE SUMMARYB2CS ("
            strstring = strstring & " AUTOID INT IDENTITY (1,1),"
            strstring = strstring & " TYPE VARCHAR(50) NOT NULL,"
            strstring = strstring & " PLACEOFSUPPLY VARCHAR(100),"
            strstring = strstring & " RATE NUMERIC(18,2) NOT NULL,"
            strstring = strstring & " TAXABLEVALUE NUMERIC (18,2) NOT NULL,"
            strstring = strstring & " CESSAMOUNT NUMERIC (18,2) NOT NULL,"
            strstring = strstring & " ECOMMERCE_GSTIN VARCHAR(25) ) END "
            gconnection.ExcuteStoreProcedure(strstring)

            strstring = " EXEC SUMMARYB2CSDETAILS   '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' , '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' "
            gconnection.ExcuteStoreProcedure(strstring)



            strstring = " SELECT ISNULL(type,'')type ,ISNULL(PLACEOFSUPPLY,'')PLACEOFSUPPLY,ISNULL(RATE,0)RATE,ISNULL(SUM(TAXABLEVALUE),0)TAXABLEVALUE,ISNULL(SUM(CESSAMOUNT),0)CESSAMOUNT ,"
            strstring = strstring & " ISNULL(ECOMMERCE_GSTIN,'')ECOMMERCE_GSTIN FROM  SUMMARYB2CS"
            strstring = strstring & " GROUP BY type,PLACEOFSUPPLY,ECOMMERCE_GSTIN,RATE "

            gconnection.getDataSet(strstring, "Voucher")
            If gdataset.Tables("Voucher").Rows.Count > 0 Then
                ssgrid.ClearRange(1, 1, -1, -1, True)
                I = 0
                With ssgrid
                    .Col = 1
                    .Row = I + 1
                    .Text = "TYPE"
                    .Col = 2
                    .Row = I + 1
                    .Text = "PLACE OF SUPPLY"

                    .Col = 3
                    .Row = I + 1
                    .Text = "RATE"
                    .Col = 4
                    .Row = I + 1
                    .Text = "TAXABLE VALUE"
                    .Col = 5
                    .Row = I + 1
                    .Text = "CESS AMOUNT"
                    .Col = 6
                    .Row = I + 1
                    .Text = "E COMMERECE GSTIN"


                End With

            End If
            For I = 0 To gdataset.Tables("Voucher").Rows.Count - 1
                With ssgrid
                    .Col = 1
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("type"))
                    .Col = 2
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("PLACEOFSUPPLY"))

                    .Col = 3
                    .Row = I + 3S
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("RATE"))
                    .Col = 4
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("TAXABLEVALUE"))
                    .Col = 5
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("CESSAMOUNT"))
                    .Col = 6
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("ECOMMERCE_GSTIN"))

                End With
            Next

        End If

        ''
        ''INVENTORY()

        If Comb_MD.Text = "INVENTORY" Then
            strstring = " SELECT 'Intra State Supplier to Registered Person' AS transaccounttype,ISNULL(GSTPER,0)GSTPER,SUM(ISNULL(AMOUNT,0))AS TAXABLE_VALUE,"

            strstring = strstring & " SUM(ISNULL(CGST,0))AS CENTRAL_TAX_AMOUNT,SUM(ISNULL(SGST,0))AS [STATE/UT_TAX_AMOUNT],SUM(ISNULL(CESS,0)+ISNULL(ADCESS,0))AS CESS_AMOUNT,"
            strstring = strstring & " SUM(ISNULL(AMOUNT,0)+ISNULL(CGST,0)+ISNULL(SGST,0)+ISNULL(CESS,0)+ISNULL(ADCESS,0))AS TOTAL_VALUE"
            strstring = strstring & " FROM INV_GSTREVENUE  where  cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' and mcode in (select slcode from ACCOUNTSSUBLEDGERMASTER where sltype ='SUPPLIER' AND  ISNULL(VENDORTYPE,'')='REGISTERED') "
            ''  If gCompName = "BCL" Then
            strstring = strstring & " GROUP BY GSTPER,ISNULL(transaccounttype,'') "


            strstring = strstring & "  UNION ALL "

            strstring = strstring & "  SELECT 'Intra State Supplier to UnRegistered Person' AS transaccounttype,ISNULL(GSTPER,0)GSTPER,SUM(ISNULL(AMOUNT,0))AS TAXABLE_VALUE,"

            strstring = strstring & " SUM(ISNULL(CGST,0))AS CENTRAL_TAX_AMOUNT,SUM(ISNULL(SGST,0))AS [STATE/UT_TAX_AMOUNT],SUM(ISNULL(CESS,0)+ISNULL(ADCESS,0))AS CESS_AMOUNT,"
            strstring = strstring & " SUM(ISNULL(AMOUNT,0)+ISNULL(CGST,0)+ISNULL(SGST,0)+ISNULL(CESS,0)+ISNULL(ADCESS,0))AS TOTAL_VALUE"
            strstring = strstring & " FROM INV_GSTREVENUE where    cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' and mcode in (select slcode from ACCOUNTSSUBLEDGERMASTER where sltype ='SUPPLIER' AND  ( ISNULL(VENDORTYPE,'')='UNREGISTERED')  OR ISNULL(VENDORTYPE,'')=''  )"
            ''If gCompName = "BCL" Then
            strstring = strstring & " GROUP BY GSTPER,ISNULL(transaccounttype,'') order by  ISNULL(GSTPER,0)"



            gconnection.getDataSet(strstring, "Voucher")
            If gdataset.Tables("Voucher").Rows.Count > 0 Then
                ssgrid.ClearRange(1, 1, -1, -1, True)
                I = 0
                With ssgrid
                    ' If gCompName = "BCL" Then
                    .Col = 1
                    .Row = I + 1
                    .Text = "SUPPLIER "

                    .Col = 2
                    .Row = I + 1
                    .Text = "Per"


                    .Col = 3
                    .Row = I + 1
                    .Text = "AMOUNT"
                    .Col = 4
                    .Row = I + 1
                    .Text = "CGST"
                    .Col = 5
                    .Row = I + 1
                    .Text = "SGST"
                    .Col = 6
                    .Row = I + 1
                    .Text = "CESS"
                    .Col = 7
                    .Row = I + 1
                    .Text = "Invoice Value"

                    '  End If

                End With

            End If
            For I = 0 To gdataset.Tables("Voucher").Rows.Count - 1
                With ssgrid
                    '  If gCompName = "BCL" Then
                    .Col = 1
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("transaccounttype"))

                    .Col = 2
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("GSTPER"))

                    .Col = 3
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("TAXABLE_VALUE"))
                    AMOUNT = Trim(gdataset.Tables("Voucher").Rows(I).Item("TAXABLE_VALUE"))
                    .Col = 4
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("CENTRAL_TAX_AMOUNT"))
                    CGST = Trim(gdataset.Tables("Voucher").Rows(I).Item("CENTRAL_TAX_AMOUNT"))
                    .Col = 5
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("STATE/UT_TAX_AMOUNT"))
                    SGST = Trim(gdataset.Tables("Voucher").Rows(I).Item("STATE/UT_TAX_AMOUNT"))
                    .Col = 6
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("CESS_AMOUNT"))
                    CESS = Trim(gdataset.Tables("Voucher").Rows(I).Item("CESS_AMOUNT"))
                    .Col = 7
                    .Row = I + 3
                    .Text = AMOUNT + SGST + CGST + CESS




                    ' End If

                End With
            Next
        End If






        If Comb_MD.Text = "OUTWORDSALES" Then

            strstring = " SELECT ISNULL(transaccounttype,'') AS transaccounttype,ISNULL(GSTPER,0)GSTPER,SUM(ISNULL(AMOUNT,0))AS TAXABLE_VALUE,"

            strstring = strstring & " SUM(ISNULL(CGST,0))AS CENTRAL_TAX_AMOUNT,SUM(ISNULL(SGST,0))AS [STATE/UT_TAX_AMOUNT],SUM(ISNULL(CESS,0)+ISNULL(ADCESS,0))AS CESS_AMOUNT,"
            strstring = strstring & " SUM(ISNULL(AMOUNT,0)+ISNULL(CGST,0)+ISNULL(SGST,0)+ISNULL(CESS,0)+ISNULL(ADCESS,0))AS TOTAL_VALUE"
            strstring = strstring & " FROM GSTREVENUE A where module='ALLSALE' AND cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' "
            ''  If gCompName = "BCL" Then
            strstring = strstring & " GROUP BY GSTPER,ISNULL(transaccounttype,'') "


            strstring = strstring & "  UNION ALL "

            strstring = strstring & "  SELECT ISNULL(transaccounttype,'') AS transaccounttype,ISNULL(GSTPER,0)GSTPER,SUM(ISNULL(AMOUNT,0))AS TAXABLE_VALUE,"

            strstring = strstring & " SUM(ISNULL(CGST,0))AS CENTRAL_TAX_AMOUNT,SUM(ISNULL(SGST,0))AS [STATE/UT_TAX_AMOUNT],SUM(ISNULL(CESS,0)+ISNULL(ADCESS,0))AS CESS_AMOUNT,"
            strstring = strstring & " SUM(ISNULL(AMOUNT,0)+ISNULL(CGST,0)+ISNULL(SGST,0)+ISNULL(CESS,0)+ISNULL(ADCESS,0))AS TOTAL_VALUE"
            strstring = strstring & " FROM GSTREVENUE where module='ACCOUNTS' AND CLUBMAN_INCOME_HEAD='INVOICE' AND   cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' "
            ''If gCompName = "BCL" Then
            strstring = strstring & " GROUP BY GSTPER,ISNULL(transaccounttype,'') order by  ISNULL(GSTPER,0)"



            gconnection.getDataSet(strstring, "Voucher")
            If gdataset.Tables("Voucher").Rows.Count > 0 Then
                ssgrid.ClearRange(1, 1, -1, -1, True)
                I = 0
                With ssgrid
                    If gCompName = "BCL" Then
                        .Col = 1
                        .Row = I + 1
                        .Text = "OUTWORD SALES"

                        .Col = 2
                        .Row = I + 1
                        .Text = "Per"


                        .Col = 3
                        .Row = I + 1
                        .Text = "AMOUNT"
                        .Col = 4
                        .Row = I + 1
                        .Text = "CGST"
                        .Col = 5
                        .Row = I + 1
                        .Text = "SGST"
                        .Col = 6
                        .Row = I + 1
                        .Text = "CESS"

                    End If

                End With

            End If
            For I = 0 To gdataset.Tables("Voucher").Rows.Count - 1
                With ssgrid
                    If gCompName = "BCL" Then
                        .Col = 1
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("transaccounttype"))

                        .Col = 2
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("GSTPER"))

                        .Col = 3
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("TAXABLE_VALUE"))
                        AMOUNT = Trim(gdataset.Tables("Voucher").Rows(I).Item("TAXABLE_VALUE"))
                        .Col = 4
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("CENTRAL_TAX_AMOUNT"))
                        CGST = Trim(gdataset.Tables("Voucher").Rows(I).Item("CENTRAL_TAX_AMOUNT"))
                        .Col = 5
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("STATE/UT_TAX_AMOUNT"))
                        SGST = Trim(gdataset.Tables("Voucher").Rows(I).Item("STATE/UT_TAX_AMOUNT"))
                        .Col = 6
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("CESS_AMOUNT"))
                        CESS = Trim(gdataset.Tables("Voucher").Rows(I).Item("CESS_AMOUNT"))
                        '.Col = 5
                        '.Row = I + 3
                        '.Text = AMOUNT + SGST + CGST + CESS + IGST




                    End If

                End With
            Next
        End If

        If Comb_MD.Text = "HSN SUMMARY" Then

            If gCompName = "BCL" Then
                strstring = " SELECT ISNULL(HSNNO,'') AS HSN,ISNULL(GSTPER,0)GSTPER,SUM(ISNULL(QTY,0))AS TOTAL_QUALITY,SUM(ISNULL(AMOUNT,0))AS TAXABLE_VALUE,"
            Else
                strstring = " SELECT ISNULL(HSNNO,'') AS HSN,ISNULL(ITEMDESC,'') AS DESCRIPTION,ISNULL(UOM,'')+'-'+ISNULL((SELECT TOP 1 UOMDESC FROM UOMMASTER B WHERE ISNULL(A.UOM,'')=B.UOMCODE),'')AS UQC,SUM(ISNULL(QTY,0))AS TOTAL_QUALITY,SUM(ISNULL(AMOUNT,0))AS TAXABLE_VALUE,SUM(ISNULL(IGST,0))AS INTEGRATED_TAX_AMOUNT,"
            End If
            strstring = strstring & " SUM(ISNULL(CGST,0))AS CENTRAL_TAX_AMOUNT,SUM(ISNULL(SGST,0))AS [STATE/UT_TAX_AMOUNT],SUM(ISNULL(CESS,0)+ISNULL(ADCESS,0))AS CESS_AMOUNT,"
            strstring = strstring & " SUM(ISNULL(AMOUNT,0)+ISNULL(CGST,0)+ISNULL(SGST,0)+ISNULL(CESS,0)+ISNULL(ADCESS,0))AS TOTAL_VALUE"
            strstring = strstring & " FROM GSTREVENUE A where module='ALLSALE' AND cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "'  AND ISNULL(HSNNO,'')<>'' "
            If gCompName = "BCL" Then
                strstring = strstring & " GROUP BY ISNULL(HSNNO,''),GSTPER "
            Else
                strstring = strstring & " GROUP BY ISNULL(HSNNO,''),ISNULL(ITEMDESC,''),ISNULL(UOM,'')"
            End If

            strstring = strstring & "  UNION ALL "
            If gCompName = "BCL" Then
                strstring = strstring & "  SELECT ISNULL(HSNNO,'') AS HSN,ISNULL(GSTPER,0)GSTPER,SUM(ISNULL(QTY,0))AS TOTAL_QUALITY,SUM(ISNULL(AMOUNT,0))AS TAXABLE_VALUE,"
            Else
                strstring = strstring & "  SELECT ISNULL(HSNNO,'') AS HSN,ISNULL(ITEMDESC,'') AS DESCRIPTION,ISNULL(UOM,'')AS UQC,SUM(ISNULL(QTY,0))AS TOTAL_QUALITY,SUM(ISNULL(AMOUNT,0))AS TAXABLE_VALUE,SUM(ISNULL(IGST,0))AS INTEGRATED_TAX_AMOUNT,"
            End If
            strstring = strstring & " SUM(ISNULL(CGST,0))AS CENTRAL_TAX_AMOUNT,SUM(ISNULL(SGST,0))AS [STATE/UT_TAX_AMOUNT],SUM(ISNULL(CESS,0)+ISNULL(ADCESS,0))AS CESS_AMOUNT,"
            strstring = strstring & " SUM(ISNULL(AMOUNT,0)+ISNULL(CGST,0)+ISNULL(SGST,0)+ISNULL(CESS,0)+ISNULL(ADCESS,0))AS TOTAL_VALUE"
            strstring = strstring & " FROM GSTREVENUE where module='ACCOUNTS' AND CLUBMAN_INCOME_HEAD='INVOICE' AND   cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "'  AND   ISNULL(HSNNO,'')<>''"
            If gCompName = "BCL" Then
                strstring = strstring & " GROUP BY ISNULL(HSNNO,''),GSTPER order by  ISNULL(GSTPER,0)"
            Else
                strstring = strstring & " GROUP BY ISNULL(HSNNO,''),ISNULL(ITEMDESC,''),ISNULL(UOM,'') order by ISNULL(HSNNO,'')"
            End If


            gconnection.getDataSet(strstring, "Voucher")
            If gdataset.Tables("Voucher").Rows.Count > 0 Then
                ssgrid.ClearRange(1, 1, -1, -1, True)
                I = 0
                With ssgrid
                    If gCompName = "BCL" Then
                        .Col = 1
                        .Row = I + 1
                        .Text = "HSN NO"

                        .Col = 2
                        .Row = I + 1
                        .Text = "Per"
                        .Col = 3
                        .Row = I + 1
                        .Text = "QTY"

                        .Col = 4
                        .Row = I + 1
                        .Text = "AMOUNT"
                        .Col = 5
                        .Row = I + 1
                        .Text = "CGST"
                        .Col = 6
                        .Row = I + 1
                        .Text = "SGST"
                        .Col = 7
                        .Row = I + 1
                        .Text = "CESS"

                    Else
                        .Col = 1
                        .Row = I + 1
                        .Text = "HSN NO"
                        .Col = 2
                        .Row = I + 1
                        .Text = "DESCRIPTION"
                        .Col = 3
                        .Row = I + 1
                        .Text = "UQC"
                        .Col = 4
                        .Row = I + 1
                        .Text = "TOTAL QTY"
                        .Col = 5
                        .Row = I + 1
                        .Text = "TOTAL VALUE"
                        .Col = 6
                        .Row = I + 1
                        .Text = "TAXABLE VALUE"
                        .Col = 7
                        .Row = I + 1
                        .Text = "INTEGRATED TAX"
                        .Col = 8
                        .Row = I + 1
                        .Text = "CENTRAL TAX"
                        .Col = 9
                        .Row = I + 1
                        .Text = "STATE/UT TAX AMOUNT"
                        .Col = 10
                        .Row = I + 1
                        .Text = "CESS AMOUNT"
                    End If

                End With

            End If
            For I = 0 To gdataset.Tables("Voucher").Rows.Count - 1
                With ssgrid
                    If gCompName = "BCL" Then
                        .Col = 1
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("HSN"))

                        .Col = 2
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("GSTPER"))
                        .Col = 3
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("TOTAL_QUALITY"))

                        .Col = 4
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("TAXABLE_VALUE"))
                        AMOUNT = Trim(gdataset.Tables("Voucher").Rows(I).Item("TAXABLE_VALUE"))
                        .Col = 5
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("CENTRAL_TAX_AMOUNT"))
                        CGST = Trim(gdataset.Tables("Voucher").Rows(I).Item("CENTRAL_TAX_AMOUNT"))
                        .Col = 6
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("STATE/UT_TAX_AMOUNT"))
                        SGST = Trim(gdataset.Tables("Voucher").Rows(I).Item("STATE/UT_TAX_AMOUNT"))
                        .Col = 7
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("CESS_AMOUNT"))
                        CESS = Trim(gdataset.Tables("Voucher").Rows(I).Item("CESS_AMOUNT"))
                        '.Col = 5
                        '.Row = I + 3
                        '.Text = AMOUNT + SGST + CGST + CESS + IGST

                    Else
                        .Col = 1
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("HSN"))

                        If gCompName = "BCL" Then
                            .Col = 2
                            .Row = I + 3
                            .Text = ""
                        Else
                            .Col = 2
                            .Row = I + 3
                            .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("DESCRIPTION"))
                        End If


                        .Col = 3
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("UQC"))
                        .Col = 4
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("TOTAL_QUALITY"))

                        .Col = 6
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("TAXABLE_VALUE"))
                        AMOUNT = Trim(gdataset.Tables("Voucher").Rows(I).Item("TAXABLE_VALUE"))

                        .Col = 7
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("INTEGRATED_TAX_AMOUNT"))
                        IGST = Trim(gdataset.Tables("Voucher").Rows(I).Item("INTEGRATED_TAX_AMOUNT"))
                        .Col = 8
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("CENTRAL_TAX_AMOUNT"))
                        CGST = Trim(gdataset.Tables("Voucher").Rows(I).Item("CENTRAL_TAX_AMOUNT"))
                        .Col = 9
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("STATE/UT_TAX_AMOUNT"))
                        SGST = Trim(gdataset.Tables("Voucher").Rows(I).Item("STATE/UT_TAX_AMOUNT"))
                        .Col = 10
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("CESS_AMOUNT"))
                        CESS = Trim(gdataset.Tables("Voucher").Rows(I).Item("CESS_AMOUNT"))
                        .Col = 5
                        .Row = I + 3
                        .Text = AMOUNT + SGST + CGST + CESS + IGST

                    End If

                End With
            Next
        End If

        If Comb_MD.Text = "VOUCHERCONTROL" Then
            strstring = "  SELECT DISTINCT  TYPE_OF_DOC+ ' '+DOCTYPE AS NATURE_OF_DOCUMENT,"
            strstring = strstring & " (SELECT MIN(BILLDETAILS) FROM GST_VOUCHERCONTROL B  WHERE A.TYPE_OF_DOC=B.TYPE_OF_DOC AND A.DOCTYPE=B.DOCTYPE AND  "
            strstring = strstring & " CAST(CONVERT(VARCHAR(11),BILLDATE ,106)AS DATETIME) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' GROUP BY TYPE_OF_DOC+ ' '+DOCTYPE) AS SR_NO_FROM,"
            strstring = strstring & "(SELECT MAX(BILLDETAILS) FROM GST_VOUCHERCONTROL B  WHERE A.TYPE_OF_DOC=B.TYPE_OF_DOC AND A.DOCTYPE=B.DOCTYPE AND  "
            strstring = strstring & " CAST(CONVERT(VARCHAR(11),BILLDATE ,106)AS DATETIME) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "'   GROUP BY TYPE_OF_DOC+ ' '+DOCTYPE) AS SR_NO_TO,"
            strstring = strstring & " (SELECT COUNT(BILLDETAILS) FROM GST_VOUCHERCONTROL B  WHERE A.TYPE_OF_DOC=B.TYPE_OF_DOC AND A.DOCTYPE=B.DOCTYPE AND  "
            strstring = strstring & " CAST(CONVERT(VARCHAR(11),BILLDATE ,106)AS DATETIME) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "'   GROUP BY TYPE_OF_DOC+ ' '+DOCTYPE) AS TOTAL_NUMBER,"
            strstring = strstring & " ISNULL((SELECT COUNT(BILLDETAILS) FROM GST_VOUCHERCONTROL B  WHERE A.TYPE_OF_DOC=B.TYPE_OF_DOC AND A.DOCTYPE=B.DOCTYPE AND  "
            strstring = strstring & " CAST(CONVERT(VARCHAR(11),BILLDATE ,106)AS DATETIME) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "'  AND ISNULL(delflag,'')='Y' GROUP BY TYPE_OF_DOC+ ' '+DOCTYPE),0) AS  CANCELLED"
            strstring = strstring & " FROM GST_VOUCHERCONTROL A WHERE CAST(CONVERT(VARCHAR(11),BILLDATE ,106)AS DATETIME) BETWEEN '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "'   and isnull(TYPE_OF_DOC+ ' '+DOCTYPE ,'')<>'' "
            strstring = strstring & " ORDER BY TYPE_OF_DOC+ ' '+DOCTYPE"

            gconnection.getDataSet(strstring, "Voucher")
            If gdataset.Tables("Voucher").Rows.Count > 0 Then
                ssgrid.ClearRange(1, 1, -1, -1, True)
                I = 0
                With ssgrid
                    .Col = 1
                    .Row = I + 1
                    .Text = "Nature Of Document"
                    .Col = 2
                    .Row = I + 1
                    .Text = "Sr.No.From"

                    .Col = 3
                    .Row = I + 1
                    .Text = "Sr.No.To"
                    .Col = 4
                    .Row = I + 1
                    .Text = "Total Number"
                    .Col = 5
                    .Row = I + 1
                    .Text = "Cancelled"
                End With

            End If
            For I = 0 To gdataset.Tables("Voucher").Rows.Count - 1
                With ssgrid
                    .Col = 1
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("NATURE_OF_DOCUMENT"))
                    .Col = 2
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("SR_NO_FROM"))

                    .Col = 3
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("SR_NO_TO"))
                    .Col = 4
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("TOTAL_NUMBER"))
                    .Col = 5
                    .Row = I + 3
                    .Text = Trim(gdataset.Tables("Voucher").Rows(I).Item("CANCELLED"))
                End With
            Next




        End If





        If Comb_MD.Text = "ALLPURCHASE" Then

            strstring = "SELECT ISNULL(BILLNO ,'') BILLNO,ISNULL(BILLDATE ,'')BILLDATE,ISNULL(AMOUNT ,0) AS AMOUNT,ISNULL(CGST,0)CGST,ISNULL(SGST ,0)SGST,ISNULL(CESS ,0)CESS,ISNULL(ADCESS ,0)ADCESS,"
            strstring = strstring & "ISNULL(transaccounttype ,'') transaccounttype  ,ISNULL(REVERSE ,'')REVERSE,ISNULL(INPUTCREDIT ,'')INPUTCREDIT,ISNULL(GST,'')GST,ISNULL(ECOMMERCE,'')ECOMMERCE,ISNULL(CATSERGOODS ,'')CATSERGOODS,ISNULL(COMP,'')COMP,  "
            strstring = strstring & "ISNULL(Clubman_Income_Head,'')Clubman_Income_Head ,ISNULL(MCODE,'') AS MCODE,ISNULL(NAME_CUST,'')NAME_CUST,ISNULL(ADDRESS,'') ADDRESS,ISNULL(STATE,'')STATE"
            strstring = strstring & ",ISNULL(COUNTRY ,'')COUNTRY,ISNULL(MEMPAN,'')MEMPAN,ISNULL(GST_NO ,'')GST_NO,ISNULL(HSNNO,'')HSNNO,ISNULL(ITEMDESC,'')ITEMDESC,ISNULL(IGST,0)IGST,ISNULL(UOM,'')UOM,ISNULL(QTY,0)AS QTY,"
            strstring = strstring & "ISNULL(GSTPER,0) AS GSTPER,ISNULL(CESSPER,0) AS CESSPER,ISNULL(AMOUNT ,0)AMOUNT"
            strstring = strstring & " FROM GSTREVENUE WHERE cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN  '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' and module ='" & Trim(Comb_MD.Text) & "' "

            strstring = strstring & " UNION ALL "
            strstring = strstring & " SELECT ISNULL(BILLNO ,'') BILLNO,ISNULL(BILLDATE ,'')BILLDATE,ISNULL(AMOUNT ,0) AS AMOUNT,ISNULL(CGST,0)CGST,ISNULL(SGST ,0)SGST,ISNULL(CESS ,0)CESS,ISNULL(ADCESS ,0)ADCESS,"
            strstring = strstring & "ISNULL(transaccounttype ,'') transaccounttype  ,ISNULL(REVERSE ,'')REVERSE,ISNULL(INPUTCREDIT ,'')INPUTCREDIT,ISNULL(GST,'')GST,ISNULL(ECOMMERCE,'')ECOMMERCE,ISNULL(CATSERGOODS ,'')CATSERGOODS,ISNULL(COMP,'')COMP,  "
            strstring = strstring & "ISNULL(Clubman_Income_Head,'')Clubman_Income_Head ,ISNULL(MCODE,'') AS MCODE,ISNULL(NAME_CUST,'')NAME_CUST,ISNULL(ADDRESS,'') ADDRESS,ISNULL(STATE,'')STATE"
            strstring = strstring & ",ISNULL(COUNTRY ,'')COUNTRY,ISNULL(MEMPAN,'')MEMPAN,ISNULL(GST_NO ,'')GST_NO,ISNULL(HSNNO,'')HSNNO,ISNULL(ITEMDESC,'')ITEMDESC,ISNULL(IGST,0)IGST,ISNULL(UOM,'')UOM,ISNULL(QTY,0)AS QTY,"
            strstring = strstring & "ISNULL(GSTPER,0) AS GSTPER,ISNULL(CESSPER,0) AS CESSPER,ISNULL(AMOUNT ,0)AMOUNT"
            strstring = strstring & " FROM GSTREVENUE WHERE cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN  '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' and module ='ACCOUNTS' AND Clubman_Income_Head='PURCHASE DIRECT' order by CATSERGOODS ,mcode, billdate "


            gconnection.getDataSet(strstring, "rpt_revenue_viewgst")
            If gdataset.Tables("rpt_revenue_viewgst").Rows.Count > 0 Then
                ssgrid.ClearRange(1, 1, -1, -1, True)
                I = 0
                With ssgrid
                    .Col = 1
                    .Row = I + 1
                    .Text = "INVOICEDATE"
                    .Col = 2
                    .Row = I + 1
                    .Text = "SUPPLER NAME"

                    .Col = 3
                    .Row = I + 1
                    .Text = "ADDRESS"
                    .Col = 4
                    .Row = I + 1
                    .Text = "PAYMENT DUEDATE"

                    .Col = 5
                    .Row = I + 1
                    .Text = "PAYMENT DATE"
                    .Col = 6
                    .Row = I + 1
                    .Text = "INVOICEDATE"

                    .Col = 7
                    .Row = I + 1
                    .Text = "PAN"

                    .Col = 8
                    .Row = I + 1
                    .Text = "GSTIN"

                    .Col = 9
                    .Row = I + 1
                    .Text = "HSN NO"
                    .Col = 10
                    .Row = I + 1
                    .Text = "DESCRIPTION"

                    .Col = 11
                    .Row = I + 1
                    .Text = "UOM"

                    .Col = 12
                    .Row = I + 1
                    .Text = "QTY"

                    .Col = 13
                    .Row = I + 1
                    .Text = "TOTAL INVOICE VALUE"
                    .Col = 14
                    .Row = I + 1
                    .Text = "TAXBLE VALUE"

                    .Col = 15
                    .Row = I + 1
                    .Text = "GST%"
                    .Col = 16
                    .Row = I + 1
                    .Text = "IGST"


                    .Col = 17
                    .Row = I + 1
                    .Text = "SGST"
                    .Col = 18
                    .Row = I + 1
                    .Text = "CGST"

                    .Col = 19
                    .Row = I + 1
                    .Text = "CESS"

                    .Col = 20
                    .Row = I + 1
                    .Text = "ADDL.CESS"




                    .Col = 21
                    .Row = I + 1
                    .Text = "PLACE OF SUPPLY(Name of State)"

                    .Col = 22
                    .Row = I + 1
                    .Text = "Wheather input or inputservice/Goods/ITC"


                    .Col = 23
                    .Row = I + 1
                    .Text = "IGST"


                    .Col = 24
                    .Row = I + 1
                    .Text = "SGST"
                    .Col = 25
                    .Row = I + 1
                    .Text = "CGST"

                    .Col = 26
                    .Row = I + 1
                    .Text = "CESS"

                    .Col = 27
                    .Row = I + 1
                    .Text = "ADDL.CESS"


                    '' ,0 ,0 AS ,0 AS 
                    .Col = 28
                    .Row = I + 1
                    .Text = "Whether Direct/Common/RCM/Import"
                End With
                For I = 0 To gdataset.Tables("rpt_revenue_viewgst").Rows.Count - 1
                    With ssgrid
                        .Col = 1
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("BILLDATE"))
                        .Col = 2
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("mcode"))

                        .Col = 3
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ADDRESS"))
                        .Col = 4
                        .Row = I + 3
                        .Text = ""
                        .Col = 5
                        .Row = I + 3
                        .Text = ""
                        .Col = 6
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("billno"))

                        .Col = 7
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("MEMPAN"))

                        .Col = 8
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("GST_NO"))

                        .Col = 9
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("HSNNO"))
                        .Col = 10
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ITEMDESC"))

                        .Col = 11
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("UOM"))

                        .Col = 12
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("QTY"))

                        '.Col = 13
                        '.Row = I + 3
                        '.Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item(""))
                        .Col = 14
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("AMOUNT"))
                        AMOUNT = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("AMOUNT"))

                        .Col = 15
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("GSTPER"))


                        ''ISNULL(GSTPER,0) AS GSTPER,ISNULL(,0) AS CESSPER,

                        .Col = 16
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("IGST"))
                        IGST = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("IGST"))
                        .Col = 17
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("SGST"))
                        SGST = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("SGST"))
                        '' ,0 CESS,0 AS ADCESS,0 AS 
                        .Col = 18
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CGST"))
                        CGST = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CGST"))

                        .Col = 19
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CESS"))
                        CESS = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CESS"))

                        .Col = 20
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ADCESS"))
                        ADDCESS = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ADCESS"))



                        .Col = 13
                        .Row = I + 3
                        .Text = AMOUNT + IGST + CGST + SGST + CESS + ADDCESS

                        .Col = 21
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("STATE"))

                        ''Clubman_Income_Head,NAME_CUST,NAME_CUST,,COUNTRY
                        .Col = 22
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("transaccounttype"))



                        .Col = 23
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("IGST"))
                        IGST = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("IGST"))
                        .Col = 24
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("SGST"))
                        SGST = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("SGST"))
                        '' ,0 CESS,0 AS ADCESS,0 AS 
                        .Col = 25
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CGST"))
                        CGST = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CGST"))

                        .Col = 267
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CESS"))
                        CESS = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CESS"))

                        .Col = 27
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ADCESS"))
                        ADDCESS = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ADCESS"))



                        .Col = 28
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CATSERGOODS"))
                        .MaxRows = .MaxRows + 1

                    End With


                Next
            End If

        End If

        If Comb_MD.Text = "ALL" Or Comb_MD.Text = "ALLSALE" Or Comb_MD.Text = "ALLSALEGST" Or Comb_MD.Text = "ALLSALENONGST" Or Comb_MD.Text = "ACCOUNTS" Or Comb_MD.Text = "ALLRECIPTS" Then
            strstring = "SELECT ISNULL(BILLNO ,'') BILLNO,ISNULL(BILLDATE ,'')BILLDATE,ISNULL(AMOUNT ,0) AS AMOUNT,ISNULL(CGST,0)CGST,ISNULL(SGST ,0)SGST,ISNULL(CESS ,0)CESS,ISNULL(ADCESS ,0)ADCESS,"
            strstring = strstring & "ISNULL(transaccounttype ,'') transaccounttype  ,ISNULL(REVERSE ,'')REVERSE,ISNULL(INPUTCREDIT ,'')INPUTCREDIT,ISNULL(GST,'')GST,ISNULL(ECOMMERCE,'')ECOMMERCE,ISNULL(CATSERGOODS ,'')CATSERGOODS,ISNULL(COMP,'')COMP,  "
            strstring = strstring & "ISNULL(Clubman_Income_Head,'')Clubman_Income_Head ,ISNULL(MCODE,'') AS MCODE,ISNULL(NAME_CUST,'')NAME_CUST,ISNULL(ADDRESS,'') ADDRESS,ISNULL(STATE,'')STATE"
            strstring = strstring & ",ISNULL(COUNTRY ,'')COUNTRY,ISNULL(MEMPAN,'')MEMPAN,ISNULL(GST_NO ,'')GST_NO,ISNULL(HSNNO,'')HSNNO,ISNULL(ITEMDESC,'')ITEMDESC,ISNULL(IGST,0)IGST,ISNULL(UOM,'')UOM,ISNULL(QTY,0)AS QTY,"
            strstring = strstring & "ISNULL(GSTPER,0) AS GSTPER,ISNULL(CESSPER,0) AS CESSPER,ISNULL(AMOUNT ,0)AMOUNT"
            If Comb_MD.Text = "ALL" Then
                strstring = strstring & " FROM GSTREVENUE WHERE  cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN  '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "'  "
            ElseIf Comb_MD.Text = "ALLSALEGST" Then
                strstring = strstring & " FROM GSTREVENUE WHERE  cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN  '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' and module='ALLSALE'  AND  TAXCODE IN (SELECT ITEMTYPECODE FROM VW_TAXITEMLINK_GST WHERE TAXCODE IN (SELECT TAXCODE FROM ACCOUNTSTAXMASTER WHERE typeoftax  IN ('SGST','CGST','CGST CESS','SGST CESS')))"
            ElseIf Comb_MD.Text = "ALLSALENONGST" Then
                strstring = strstring & " FROM GSTREVENUE WHERE  cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN  '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' and module='ALLSALE'   AND TAXCODE IN (SELECT ITEMTYPECODE FROM VW_TAXITEMLINK_NGST WHERE TAXCODE IN (SELECT TAXCODE FROM ACCOUNTSTAXMASTER WHERE typeoftax NOT  IN ('SGST','CGST','CGST CESS','SGST CESS')))"
            Else
                strstring = strstring & " FROM GSTREVENUE WHERE  cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN  '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' and module='" & Trim(Comb_MD.Text) & "' "
            End If
            If Comb_MD.Text = "ALLSALE" Or Comb_MD.Text = "ALLSALEGST" Then
                strstring = strstring & " UNION ALL "
                strstring = strstring & " SELECT ISNULL(BILLNO ,'') BILLNO,ISNULL(BILLDATE ,'')BILLDATE,ISNULL(AMOUNT ,0) AS AMOUNT,ISNULL(CGST,0)CGST,ISNULL(SGST ,0)SGST,ISNULL(CESS ,0)CESS,ISNULL(ADCESS ,0)ADCESS,"
                strstring = strstring & "ISNULL(transaccounttype ,'') transaccounttype  ,ISNULL(REVERSE ,'')REVERSE,ISNULL(INPUTCREDIT ,'')INPUTCREDIT,ISNULL(GST,'')GST,ISNULL(ECOMMERCE,'')ECOMMERCE,ISNULL(CATSERGOODS ,'')CATSERGOODS,ISNULL(COMP,'')COMP,  "
                strstring = strstring & "ISNULL(Clubman_Income_Head,'')Clubman_Income_Head ,ISNULL(MCODE,'') AS MCODE,ISNULL(NAME_CUST,'')NAME_CUST,ISNULL(ADDRESS,'') ADDRESS,ISNULL(STATE,'')STATE"
                strstring = strstring & ",ISNULL(COUNTRY ,'')COUNTRY,ISNULL(MEMPAN,'')MEMPAN,ISNULL(GST_NO ,'')GST_NO,ISNULL(HSNNO,'')HSNNO,ISNULL(ITEMDESC,'')ITEMDESC,ISNULL(IGST,0)IGST,ISNULL(UOM,'')UOM,ISNULL(QTY,0)AS QTY,"
                strstring = strstring & "ISNULL(GSTPER,0) AS GSTPER,ISNULL(CESSPER,0) AS CESSPER,ISNULL(AMOUNT ,0)AMOUNT"
                strstring = strstring & " FROM GSTREVENUE WHERE cast(convert(varchar(11),BILLDATE,106)as datetime) BETWEEN  '" & Format(CDate(dtp_Fromdate.Text), "dd/MMM/yyyy") & "' AND '" & Format(CDate(dtp_Todate.Text), "dd/MMM/yyyy") & "' and module ='ACCOUNTS' AND Clubman_Income_Head='INVOICE'   "

            End If
            gconnection.getDataSet(strstring, "rpt_revenue_viewgst")
            If gdataset.Tables("rpt_revenue_viewgst").Rows.Count > 0 Then
                ssgrid.ClearRange(1, 1, -1, -1, True)
                I = 0
                With ssgrid
                    .Col = 1
                    .Row = I + 1
                    .Text = "INVOICENO"
                    .Col = 2
                    .Row = I + 1
                    .Text = "INVOICEDATE"

                    .Col = 3
                    .Row = I + 1
                    .Text = "OUTLET "
                    .Col = 4
                    .Row = I + 1
                    .Text = "MEM_NO"

                    .Col = 5
                    .Row = I + 1
                    .Text = "MEM_NAME"
                    .Col = 6
                    .Row = I + 1
                    .Text = "ADDRESS"

                    .Col = 7
                    .Row = I + 1
                    .Text = "STATE"

                    .Col = 8
                    .Row = I + 1
                    .Text = "COUNTRY"

                    .Col = 9
                    .Row = I + 1
                    .Text = "MEMPAN"
                    .Col = 10
                    .Row = I + 1
                    .Text = "GST_NO"

                    .Col = 11
                    .Row = I + 1
                    .Text = "ITEM_HSNNO"

                    .Col = 12
                    .Row = I + 1
                    .Text = "ITEM_ITEMDESC"

                    .Col = 13
                    .Row = I + 1
                    .Text = "UOM"
                    .Col = 14
                    .Row = I + 1
                    .Text = "QTY"

                    '.Col = 15
                    '.Row = I + 1
                    '.Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("UOM"))
                    .Col = 16
                    .Row = I + 1
                    .Text = "TAXBLE VALUE"


                    .Col = 17
                    .Row = I + 1
                    .Text = "GST%"
                    .Col = 18
                    .Row = I + 1
                    .Text = "CESS%"

                    .Col = 19
                    .Row = I + 1
                    .Text = "IGST"

                    .Col = 20
                    .Row = I + 1
                    .Text = "SGST"




                    .Col = 21
                    .Row = I + 1
                    .Text = "CGST"

                    .Col = 22
                    .Row = I + 1
                    .Text = "CESS"

                    '' ,0 ,0 AS ,0 AS 
                    .Col = 23
                    .Row = I + 1
                    .Text = "ADCESS"

                    .Col = 24
                    .Row = I + 1
                    .Text = "REVERSE CHARGE SUPPLIES"



                    .Col = 15
                    .Row = I + 1
                    .Text = "TOTAL INVOICE VALUE"

                    .Col = 25
                    .Row = I + 1
                    .Text = "INVOICE TYPE"
                    '' ,0 ,0 AS ,0 AS 
                    .Col = 26
                    .Row = I + 1
                    .Text = "ECOMMERCE"
                    .Col = 27
                    .Row = I + 1
                    .Text = "CATEGORY OF SERVICE/GOODS"

                End With
                For I = 0 To gdataset.Tables("rpt_revenue_viewgst").Rows.Count - 1
                    With ssgrid
                        .Col = 1
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("BILLNO"))
                        .Col = 2
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("BILLDATE"))

                        .Col = 3
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("Clubman_Income_Head"))
                        .Col = 4
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("MCODE"))

                        .Col = 5
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("NAME_CUST"))
                        .Col = 6
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ADDRESS"))

                        .Col = 7
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("STATE"))

                        .Col = 8
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("COUNTRY"))

                        .Col = 9
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("MEMPAN"))
                        .Col = 10
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("GST_NO"))

                        .Col = 11
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("HSNNO"))

                        .Col = 12
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ITEMDESC"))

                        .Col = 13
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("UOM"))
                        .Col = 14
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("QTY"))

                        '.Col = 15
                        '.Row = I + 3
                        '.Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("UOM"))
                        .Col = 16
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("AMOUNT"))
                        AMOUNT = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("AMOUNT"))
                        ''ISNULL(GSTPER,0) AS GSTPER,ISNULL(,0) AS CESSPER,

                        .Col = 17
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("GSTPER"))
                        .Col = 18
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CESSPER"))
                        '' ,0 CESS,0 AS ADCESS,0 AS 
                        .Col = 19
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("IGST"))
                        IGST = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("IGST"))
                        .Col = 20
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("SGST"))
                        SGST = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("SGST"))



                        .Col = 21
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CGST"))
                        CGST = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CGST"))
                        .Col = 22
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CESS"))
                        CESS = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CESS"))
                        '' ,0 ,0 AS ,0 AS 
                        .Col = 23
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ADCESS"))
                        ADDCESS = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ADCESS"))
                        .Col = 24
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("REVERSE"))



                        .Col = 15
                        .Row = I + 3
                        .Text = AMOUNT + IGST + CGST + SGST + CESS + ADDCESS

                        .Col = 25
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("transaccounttype"))
                        '' ,0 ,0 AS ,0 AS 
                        .Col = 26
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("ECOMMERCE"))
                        .Col = 27
                        .Row = I + 3
                        .Text = Trim(gdataset.Tables("rpt_revenue_viewgst").Rows(I).Item("CATSERGOODS"))
                        .MaxRows = .MaxRows + 1

                    End With


                Next
            End If




        End If


    End Sub

    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub

    Private Sub Comb_MD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Comb_MD.SelectedIndexChanged

    End Sub

    Private Sub dtp_Fromdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Fromdate.ValueChanged

    End Sub

    Private Sub dtp_Fromdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Fromdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_Todate.Focus()
        End If
    End Sub

    Private Sub dtp_Todate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Todate.ValueChanged

    End Sub

    Private Sub dtp_Todate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Todate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Comb_MD.Focus()
        End If
    End Sub

    Private Sub Comb_MD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Comb_MD.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmd_Fill.Focus()
        End If
    End Sub



    Private Sub CMD_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ssqlsum As String
        SQLSTRING = "select applncode Code,MAPPLNO [Register No.],applnname [Applicant Name],docno [Doc No.],docdate [Doc Date],paymentmode [Payment Mode],(select appldate from MEMBER_APPLICATION_MASTER a where a.APPLNO=b.ApplnCode )[Application Date],Amount,totalamount -Amount [Tax Amount],totalamount [Total Amount] from EntranceFee_Receipts b WHERE MONTH(docdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(docdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and isnull(freeze,'')<>'Y' and totalamount -Amount <>0"
        ssqlsum = "select '' Code,'' [Register No.],'TOTAL' [Applicant Name],'' [Doc No.],'' [Doc Date],'' [Payment Mode],'' [Application Date],sum(Amount) as Amount,sum(totalamount -Amount) [Tax Amount],sum(totalamount) [Total Amount] from EntranceFee_Receipts b WHERE MONTH(docdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(docdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')and isnull(freeze,'')<>'Y'  and totalamount -Amount <>0"

        Call loadgrid(SQLSTRING, "ENT", ssqlsum)
    End Sub
    Public Sub loadgrid(ByVal sqlstring As String, ByVal ent As String, ByVal ssqlsum As String)
        Dim k As Integer
        k = 1
        ssgrid.ClearRange(1, 1, -1, -1, False)
        If sqlstring <> "" Then
            gconnection.getDataSet(sqlstring, "alldata")
            If gdataset.Tables("alldata").Rows.Count > 0 Then
                ssgrid.ClearRange(1, 1, -1, -1, False)
                For i = 0 To gdataset.Tables("alldata").Columns.Count - 1
                    ssgrid.Row = k
                    ssgrid.Col = i + 1
                    ssgrid.Text = gdataset.Tables("alldata").Columns(i).ColumnName
                Next
                k = k + 1
                For i = 0 To gdataset.Tables("alldata").Rows.Count - 1
                    For j = 0 To gdataset.Tables("alldata").Columns.Count - 1
                        ssgrid.Row = k
                        ssgrid.Col = j + 1
                        ssgrid.Text = gdataset.Tables("alldata").Rows(i).Item(j)
                    Next
                    k = k + 1
                Next
                If ent = "ENT" Then
                    If ssqlsum <> "" Then
                        gconnection.getDataSet(ssqlsum, "alldatasum")
                        If gdataset.Tables("alldatasum").Rows.Count > 0 Then
                            k = k + 1
                            For i = 0 To gdataset.Tables("alldatasum").Rows.Count - 1
                                For j = 0 To gdataset.Tables("alldatasum").Columns.Count - 1
                                    ssgrid.Row = k
                                    ssgrid.Col = j + 1
                                    ssgrid.Text = gdataset.Tables("alldatasum").Rows(i).Item(j)
                                Next
                                k = k + 1
                            Next
                        End If
                    End If
                End If
            Else
                MsgBox("no data to display")
            End If
        Else
            MsgBox("no data to display")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ssqlsum As String
        SQLSTRING = " select TYPE,[ITEM DESCRIPTION],	sum(AMOUNT) as AMOUNT,	sum(CGST) as CGST,sum(SGST)as SGST,sum(TOTALAMOUNT)as TOTALAMOUNT from ( select case when  isnull((select top 1 paymentmode from GR_BILL_HDR where BILL_NO=a.billno),'SMART CARD')<>'SMART CARD' then 'CREDIT' else 'SMART CARD' end as TYPE  ,itemdesc as [ITEM DESCRIPTION],	AMOUNT as AMOUNT,	CGST as CGST,	SGST as SGST,AMOUNT+CGST+SGST	TOTALAMOUNT  from GSTREVENUE a where Clubman_Income_Head='guest entry' and MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "'))t group by TYPE, [ITEM DESCRIPTION] order by type  "
        ssqlsum = "select '' as TYPE  ,'TOTAL' as [ITEM DESCRIPTION],	sum(AMOUNT) as AMOUNT,	sum(CGST)as CGST,	sum(SGST)as SGST,sum(AMOUNT+CGST+SGST)	TOTALAMOUNT  from GSTREVENUE where Clubman_Income_Head='guest entry'and MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')"

        Call loadgrid(SQLSTRING, "ENT", ssqlsum)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        
             Dim ssqlsum As String
        SQLSTRING = "   select BILLNO,BILLDATE,itemdesc as [ITEM DESCRIPTION],sum(AMOUNT) as AMOUNT,	sum(CGST) as CGST,sum(SGST)as SGST, sum(amount+cgst+sgst) as TOTALAMOUNT from GSTREVENUE where  transaccounttype in('RECEIPT','DEBIT NOTE','CREDIT NOTE') and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')   and isnull(cgst,0)<>0 group by billno,billdate,itemdesc order by billdate,billno  "
        ssqlsum = "select   ''billno,''billdate,'TOTAL'itemdesc,sum(AMOUNT) as AMOUNT,	sum(CGST) as CGST,sum(SGST)as SGST, sum(amount+cgst+sgst) as TOTALAMOUNT from GSTREVENUE where  transaccounttype in('RECEIPT','DEBIT NOTE','CREDIT NOTE') and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')   and isnull(cgst,0)<>0 "

        Call loadgrid(SQLSTRING, "ENT", ssqlsum)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ssqlsum As String
        SQLSTRING = "   select itemdesc as [ITEM DESCRIPTION],sum(AMOUNT) as AMOUNT,	sum(CGST) as CGST,sum(SGST)as SGST, sum(amount+cgst+sgst) as TOTALAMOUNT from GSTREVENUE where    Clubman_Income_Head in('SUBSCRIPTION','SURCHARGE ON ARREARS','POSTAL CHARGES') and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')   and isnull(cgst,0)<>0 group by itemdesc order by itemdesc  "
        ssqlsum = "select   'TOTAL'itemdesc,sum(AMOUNT) as AMOUNT,	sum(CGST) as CGST,sum(SGST)as SGST, sum(amount+cgst+sgst) as TOTALAMOUNT from GSTREVENUE where    Clubman_Income_Head in('SUBSCRIPTION','SURCHARGE ON ARREARS','POSTAL CHARGES') and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')   and isnull(cgst,0)<>0 "

        Call loadgrid(SQLSTRING, "ENT", ssqlsum)
          
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ssqlsum As String
        SQLSTRING = "   select Clubman_Income_Head as POSDESC,ITEMDESC,UOM,sum(case when qty=0 then 1 else qty end) as QTY,amount/(case when qty=0 then 1 else qty end) rate,sum(AMOUNT)as AMOUNT,sum(CGST)as CGST,sum(SGST)as SGST,sum(CESS)as CESS,sum(AMOUNT+CGST+SGST+CESS) TOTAL from gstrevenue  where transaccounttype not in('RECEIPT','DEBIT NOTE','CREDIT NOTE','INWARD') and Clubman_Income_Head not in('SUBSCRIPTION','SURCHARGE ON ARREARS','POSTAL CHARGES','guest entry') and Clubman_Income_Head not like '%BAR%'and isnull(cgst,0)<>0 and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') group by Clubman_Income_Head,ITEMDESC,UOM,amount/(case when qty=0 then 1 else qty end) order by Clubman_Income_Head,ITEMDESC  "
        ssqlsum = "select '' as POSDESC,'TOTAL' ITEMDESC,''UOM,'' as QTY,'' rate,sum(AMOUNT)as AMOUNT,sum(CGST)as CGST,sum(SGST)as SGST,sum(CESS)as CESS,sum(AMOUNT+CGST+SGST+CESS) TOTAL from gstrevenue  where transaccounttype not in('RECEIPT','DEBIT NOTE','CREDIT NOTE','INWARD') and Clubman_Income_Head not in('SUBSCRIPTION','SURCHARGE ON ARREARS','POSTAL CHARGES','guest entry') and Clubman_Income_Head not like '%BAR%'and isnull(cgst,0)<>0 and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')  "

        Call loadgrid(SQLSTRING, "ENT", ssqlsum)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ssqlsum As String
        SQLSTRING = "   select Clubman_Income_Head as POSDESC,ITEMDESC,UOM,sum(case when qty=0 then 1 else qty end) as QTY,amount/(case when qty=0 then 1 else qty end) rate,sum(AMOUNT)as AMOUNT,sum(CGST)as CGST,sum(SGST)as SGST,sum(CESS)as CESS,sum(AMOUNT+CGST+SGST+CESS) TOTAL from gstrevenue  where transaccounttype not in('RECEIPT','DEBIT NOTE','CREDIT NOTE','INWARD') and Clubman_Income_Head not in('SUBSCRIPTION','SURCHARGE ON ARREARS','POSTAL CHARGES','guest entry') and Clubman_Income_Head  like '%BAR%'and isnull(cgst,0)<>0 and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') group by Clubman_Income_Head,ITEMDESC,UOM,amount/(case when qty=0 then 1 else qty end) order by Clubman_Income_Head,ITEMDESC  "
        ssqlsum = "select '' as POSDESC,'TOTAL' ITEMDESC,''UOM,'' as QTY,'' rate,sum(AMOUNT)as AMOUNT,sum(CGST)as CGST,sum(SGST)as SGST,sum(CESS)as CESS,sum(AMOUNT+CGST+SGST+CESS) TOTAL from gstrevenue  where transaccounttype not in('RECEIPT','DEBIT NOTE','CREDIT NOTE','INWARD') and Clubman_Income_Head not in('SUBSCRIPTION','SURCHARGE ON ARREARS','POSTAL CHARGES','guest entry') and Clubman_Income_Head  like '%BAR%'and isnull(cgst,0)<>0 and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')  "

        Call loadgrid(SQLSTRING, "ENT", ssqlsum)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ssqlsum As String
        SQLSTRING = "    select 1 as orderno, module,GSTPER,Clubman_Income_Head,''itemdesc,sum(AMOUNT)as AMOUNT,sum(CGST)as CGST,sum(SGST)as SGST,sum(CESS)as CESS,sum(isnull(igst,0)) as IGST,sum(AMOUNT+CGST+SGST+CESS) TOTAL from gstrevenue where  module  in('ALLSALE') and Clubman_Income_Head not in('DEBIT NOTE','CREDIT NOTE') and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') group by module,GSTPER,Clubman_Income_Head        union all  select 1 as orderno, module,GSTPER,Clubman_Income_Head,''itemdesc,sum(AMOUNT)as AMOUNT,sum(CGST)as CGST,sum(SGST)as SGST,sum(CESS)as CESS,sum(isnull(igst,0)) as IGST,sum(AMOUNT+CGST+SGST+CESS) TOTAL from gstrevenue where  module  in('ALLSALE') and Clubman_Income_Head  in('DEBIT NOTE','CREDIT NOTE')and isnull(cgst,0)<>0 and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')  group by module,GSTPER,Clubman_Income_Head         union all  select 2 as orderno,'' module,'0'GSTPER,''Clubman_Income_Head,'TOTAL OUTPUT'itemdesc,sum(AMOUNT)as AMOUNT,sum(CGST)as CGST,sum(SGST)as SGST,sum(CESS)as CESS,sum(isnull(igst,0)) as IGST,sum(AMOUNT+CGST+SGST+CESS) TOTAL from gstrevenue where (( module  in('ALLSALE')) or ( Clubman_Income_Head  in('DEBIT NOTE','CREDIT NOTE')and isnull(cgst,0)<>0)) and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')          union all  select 3 as orderno, module,GSTPER,Clubman_Income_Head,''itemdesc,sum(AMOUNT)as AMOUNT,sum(CGST)as CGST,sum(SGST)as SGST,sum(CESS)as CESS,sum(isnull(igst,0)) as IGST,sum(AMOUNT+CGST+SGST+CESS) TOTAL from gstrevenue where  module   in('ALLPURCHASE') and Clubman_Income_Head not in('DEBIT NOTE','CREDIT NOTE') and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') group by module,GSTPER,Clubman_Income_Head         union all  select 4 as orderno,'' module,'0'GSTPER,''Clubman_Income_Head,'TOTAL input'itemdesc,sum(AMOUNT)as AMOUNT,sum(CGST)as CGST,sum(SGST)as SGST,sum(CESS)as CESS,sum(isnull(igst,0)) as IGST,sum(AMOUNT+CGST+SGST+CESS) TOTAL from gstrevenue where  module   in('ALLPURCHASE') and Clubman_Income_Head not in('DEBIT NOTE','CREDIT NOTE') and   MONTH(billdate)=MONTH('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "') and  YEAR(billdate)=YEAR('" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "')    order by orderno,module,GSTPER "
        ssqlsum = " "

        Call loadgrid(SQLSTRING, "ENT", ssqlsum)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class
