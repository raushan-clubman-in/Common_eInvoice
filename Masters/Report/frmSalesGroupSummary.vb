Imports System.Data.SqlClient
Imports System.IO
Public Class frmSalesGroupSummary
    Inherits System.Windows.Forms.Form
    Dim sqlstring, ssql As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Dim dr, dr1 As DataRow
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim rowcount, rowtotal
    Dim TYPE() As String
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Chklist_POSLocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Chk_SelectAllPos As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSalesGroupSummary))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Chklist_POSLocation = New System.Windows.Forms.CheckedListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(328, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 24)
        Me.Label2.TabIndex = 423
        Me.Label2.Text = "POS LOCATION :"
        '
        'Chklist_POSLocation
        '
        Me.Chklist_POSLocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_POSLocation.Location = New System.Drawing.Point(328, 168)
        Me.Chklist_POSLocation.Name = "Chklist_POSLocation"
        Me.Chklist_POSLocation.Size = New System.Drawing.Size(264, 298)
        Me.Chklist_POSLocation.TabIndex = 422
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(120, 472)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 48)
        Me.GroupBox3.TabIndex = 424
        Me.GroupBox3.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(184, 14)
        Me.mskFromDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(104, 26)
        Me.mskFromDate.TabIndex = 0
        Me.mskFromDate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TO DATE "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'mskToDate
        '
        Me.mskToDate.CustomFormat = "dd-MM-yyyy"
        Me.mskToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskToDate.Location = New System.Drawing.Point(504, 13)
        Me.mskToDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(104, 26)
        Me.mskToDate.TabIndex = 1
        Me.mskToDate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(72, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Controls.Add(Me.CmdPrint)
        Me.GroupBox4.Controls.Add(Me.cmdexit)
        Me.GroupBox4.Controls.Add(Me.CmdView)
        Me.GroupBox4.Location = New System.Drawing.Point(120, 608)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 40)
        Me.GroupBox4.TabIndex = 425
        Me.GroupBox4.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CmdClear.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(64, 8)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 9
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CmdPrint.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(384, 8)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 11
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmdexit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(552, 8)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 12
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CmdView.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(224, 8)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 10
        Me.CmdView.Text = "View [F9]"
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(336, 112)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.TabIndex = 426
        Me.Chk_SelectAllPos.Text = "SELECT ALL "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(320, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(254, 25)
        Me.Label3.TabIndex = 427
        Me.Label3.Text = "SALES GROUP SUMMARY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(240, 648)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 428
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'frmSalesGroupSummary
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 742)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chk_SelectAllPos)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Chklist_POSLocation)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesGroupSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSalesGroupSummary"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmSalesGroupSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call FillPOSLocation()
            mskFromDate.Value = Now.Today
            mskToDate.Value = Now.Today
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillPOSLocation()
        Try
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
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            If Chklist_POSLocation.CheckedItems.Count = 0 Then
                MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = False
            Call Viewsalesgroupsummary()
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub Viewsalesgroupsummary()
        Try
            Dim servercode() As String
            Dim i As Integer
            sqlstring = "SELECT POSDESC,LEDGERNAME,SUM(BILLAMOUNT) AS AMOUNT FROM MC_POS_GROUPSUMMARY"
            ssql = "SELECT POSDESC,SUM(BILLAMOUNT)AS POSAMOUNT FROM MC_POS_GROUPSUMMARY "
            If Chklist_POSLocation.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " WHERE POSDESC IN ("
                ssql = ssql & " WHERE POSDESC IN ("
                For i = 0 To Chklist_POSLocation.CheckedItems.Count - 1
                    sqlstring = sqlstring & "'" & Chklist_POSLocation.CheckedItems(i) & "', "
                    ssql = ssql & "'" & Chklist_POSLocation.CheckedItems(i) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ",'VAT','PACK')"
                ssql = Mid(ssql, 1, Len(ssql) - 2)
                ssql = ssql & ",'VAT','PACK')"
            Else
                MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            sqlstring = sqlstring & " AND KOTDATE BETWEEN '"
            ssql = ssql & " AND KOTDATE BETWEEN '"
            sqlstring = sqlstring & Format(mskFromDate.Value, "dd MMM yyyy") & "' AND '" & Format(mskToDate.Value, "dd MMM yyyy") & "'"
            ssql = ssql & Format(mskFromDate.Value, "dd MMM yyyy") & "' AND '" & Format(mskToDate.Value, "dd MMM yyyy") & "'"
            sqlstring = sqlstring & " GROUP BY LEDGERNAME,POSDESC ORDER BY POSDESC,LEDGERNAME"
            ssql = ssql & " GROUP BY POSDESC ORDER BY POSDESC"
            Dim heading() As String = {"SALES ACCOUNT GROUP SUMMARY"}
            Call ReportDetails(sqlstring, heading, mskFromDate.Value, mskToDate.Value, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal pageheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date, ByVal frm As Object)
        Dim docdate, changeno, billsdetails, servercode, billamount, totalamount, POSCode, Ledger, dblBasicamt, dblnetamt As String
        Dim amount, basic, discountamount, i As Integer
        Dim GrandQty, GrandAmount, TAmount As Double
        Dim SSQL1, SSQL2 As String
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call ReportHeader(pageheading, mskfromdate, msktodate)
            gconnection.getDataSet(SQLSTRING, "GROUPSUMMARY")
            gconnection.getDataSet(ssql, "POSAmount")
            rowtotal = gdataset.Tables("GROUPSUMMARY").Rows.Count
            rowcount = 100 / rowtotal

            If gdataset.Tables("GROUPSUMMARY").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                basic = 0
                amount = 0
                For Each dr In gdataset.Tables("GROUPSUMMARY").Rows
                    If pagesize > 58 Then
                        Filewrite.WriteLine(StrDup(135, "-"))
                        pagesize = pagesize + 1
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(pageheading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If

                    If POSCode <> dr("POSDESC") Then
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                        For Each dr1 In gdataset.Tables("POSAmount").Rows
                            If dr1("POSDESC") = dr("POSDESC") Then
                                TAmount = dr1("POSAMOUNT")
                            End If
                        Next
                        Filewrite.WriteLine("{0,-85}{1,30}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 25) & ":", TAmount)
                        pagesize = pagesize + 1
                        Filewrite.WriteLine("{0,-85}{1,30}", "-------------------------", "------------")
                        pagesize = pagesize + 1
                        POSCode = dr("POSDESC")
                    End If
                    Filewrite.Write("{0,-85}", Mid(CStr(dr("LEDGERNAME")), 1, 50))
                    Filewrite.Write("{0,30}", Mid(CStr(dr("AMOUNT")), 1, 25))
                    GrandAmount = GrandAmount + dr("AMOUNT")
                    'Filewrite.Write("{0,8}", Mid(Format(Val(dr("QTY")), "0.00"), 1, 8))
                    'Filewrite.Write("{0,10}", Mid(Format(Val(dr("RATE")), "0.00"), 1, 10))
                    'Filewrite.Write("{0,10}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 10))
                    'GrandAmount = GrandAmount + Format(Val(dr("AMOUNT")), "0.00")
                    'GrandQty = GrandQty + Format(Val(dr("QTY")), "0.00")
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1

                    'frm.ProgressBar1.Value += rowcount
                    'frm.lbl_Wait.Text = frm.ProgressBar1.Value & "%"

                Next dr
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-85}{1,30}", "GRAND TOTAL =====>", Format(Val(GrandAmount), "0.00"))
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
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
    Private Function ReportHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("                                                                                   |          Closing | Balance          |")
            pagesize = pagesize + 1
            Filewrite.WriteLine("                                                                                   |-------------------------------------|")
            pagesize = pagesize + 1
            Filewrite.WriteLine("                                                                                   |     Debit        |        Credit    |")
            pagesize = pagesize + 1
            'Filewrite.Write("{0,-12}{1,-20}{2,-6}{3,12}{4,12}{5,-5}", "BILL", "BILL", "SERVER", "BASIC", "NET", "")
            'Filewrite.WriteLine("{0,-10}{1,-25}{2,8}{3,10}{4,10}", "ITEM", "ITEM", "QTY", "RATE", "AMOUNT")
            'pagesize = pagesize + 1
            'Filewrite.Write("{0,-12}{1,-20}{2,-6}{3,12}{4,12}{5,-5}", "DATE", "NUMBER", "CODE", "AMOUNT", "AMOUNT", "")
            'Filewrite.WriteLine("{0,-10}{1,-25}{2,8}{3,10}{4,10}", "CODE", "DESCRIPTION", " ", " ", " ")
            'pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    Private Sub Chk_SelectAllPos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllPos.CheckedChanged
        Try
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
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            If Chklist_POSLocation.CheckedItems.Count = 0 Then
                MessageBox.Show("Select the POS Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = True
            Call Viewsalesgroupsummary()
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            Chk_SelectAllPos.Checked = False
            Chklist_POSLocation.Items.Clear()
            Call FillPOSLocation()
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub frmSalesGroupSummary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        Chk_SelectAllPos.Checked = True
        For i = 0 To Chklist_POSLocation.Items.Count - 1
            Chklist_POSLocation.SetItemChecked(i, True)
        Next
        If e.KeyCode = Keys.Escape Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call CmdView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F10 Then
            Call CmdPrint_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        End If
    End Sub
End Class
