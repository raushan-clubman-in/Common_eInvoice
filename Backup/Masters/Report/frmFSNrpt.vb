Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmFSN
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CMd_Excel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_FAST As System.Windows.Forms.TextBox
    Friend WithEvents TXT_SLOW As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFSN))
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.CMd_Excel = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.TXT_FAST = New System.Windows.Forms.TextBox
        Me.TXT_SLOW = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(400, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 31)
        Me.Label3.TabIndex = 433
        Me.Label3.Text = "FSN REPORT"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Controls.Add(Me.CmdPrint)
        Me.GroupBox4.Controls.Add(Me.cmdexit)
        Me.GroupBox4.Controls.Add(Me.CmdView)
        Me.GroupBox4.Controls.Add(Me.CMd_Excel)
        Me.GroupBox4.Location = New System.Drawing.Point(112, 344)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox4.TabIndex = 431
        Me.GroupBox4.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(60, 20)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 9
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(304, 20)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 11
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(576, 20)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 12
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(184, 20)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 10
        Me.CmdView.Text = "View [F9]"
        '
        'CMd_Excel
        '
        Me.CMd_Excel.BackColor = System.Drawing.Color.ForestGreen
        Me.CMd_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMd_Excel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMd_Excel.ForeColor = System.Drawing.Color.White
        Me.CMd_Excel.Image = CType(resources.GetObject("CMd_Excel.Image"), System.Drawing.Image)
        Me.CMd_Excel.Location = New System.Drawing.Point(432, 20)
        Me.CMd_Excel.Name = "CMd_Excel"
        Me.CMd_Excel.Size = New System.Drawing.Size(104, 32)
        Me.CMd_Excel.TabIndex = 434
        Me.CMd_Excel.Text = "Export[F10]"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(112, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox3.TabIndex = 430
        Me.GroupBox3.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(192, 20)
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
        Me.Label6.Location = New System.Drawing.Point(400, 20)
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
        Me.mskToDate.Location = New System.Drawing.Point(504, 20)
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
        Me.Label7.Location = New System.Drawing.Point(56, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'TXT_FAST
        '
        Me.TXT_FAST.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FAST.Location = New System.Drawing.Point(688, 224)
        Me.TXT_FAST.Name = "TXT_FAST"
        Me.TXT_FAST.TabIndex = 434
        Me.TXT_FAST.Text = "1000"
        '
        'TXT_SLOW
        '
        Me.TXT_SLOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SLOW.Location = New System.Drawing.Point(304, 224)
        Me.TXT_SLOW.Name = "TXT_SLOW"
        Me.TXT_SLOW.TabIndex = 435
        Me.TXT_SLOW.Text = "250"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 22)
        Me.Label1.TabIndex = 437
        Me.Label1.Text = " FAST MOVING"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 22)
        Me.Label2.TabIndex = 438
        Me.Label2.Text = "SLOW MOVING"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(112, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 88)
        Me.GroupBox1.TabIndex = 439
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criteria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(452, 16)
        Me.Label4.TabIndex = 440
        Me.Label4.Text = "SLOW MOVING -> Qty Less than fast moving & > Greater than GIVEN slow moving crite" & _
        "ria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 455)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 16)
        Me.Label5.TabIndex = 441
        Me.Label5.Text = "FAST MOVING ->    Qty Greater than GIVEN fast moving criteria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 471)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 16)
        Me.Label8.TabIndex = 442
        Me.Label8.Text = "NON MOVING ->   Qty Equal to Zero"
        '
        'frmFSN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(952, 502)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_SLOW)
        Me.Controls.Add(Me.TXT_FAST)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmFSN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FSN Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmFSN_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Call FillPOSLocation()
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
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub

            sqlstring = " ALTER VIEW VIEW_FSNrpt AS "
            sqlstring = sqlstring & " SELECT I.ItemCode, I.ItemDesc , SUM(K.QTY) QTY, 'FAST MOVING' FSNDESC , 1 ordno FROM ITEMMASTER I , KOT_DET k"
            sqlstring = sqlstring & " WHERE I.ITEMCODE = K.ITEMCODE"
            sqlstring = sqlstring & " AND ISNULL(K.DelFlag,'N') <> 'Y'"
            sqlstring = sqlstring & " AND CAST(CONVERT(CHAR(39),K.KOTDATE,106) AS DATETIME) BETWEEN ' " & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "' "
            sqlstring = sqlstring & " GROUP BY I.ITEMCODE , I.ITEMDESC"
            sqlstring = sqlstring & " HAVING SUM(QTY) >= " & Val(TXT_FAST.Text) & " "

            sqlstring = sqlstring & "             UNION ALL "

            sqlstring = sqlstring & "  SELECT I.ItemCode, I.ItemDesc , SUM(K.QTY) , 'SLOW MOVING' FSNDESC , 2 ordno  FROM ITEMMASTER I , KOT_DET k"
            sqlstring = sqlstring & " WHERE(I.ITEMCODE = K.ITEMCODE)"
            sqlstring = sqlstring & " AND ISNULL(K.DelFlag,'N') <> 'Y'"
            sqlstring = sqlstring & " AND CAST(CONVERT(CHAR(39),K.KOTDATE,106) AS DATETIME) BETWEEN ' " & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "' "
            sqlstring = sqlstring & " GROUP BY I.ITEMCODE , I.ITEMDESC"
            sqlstring = sqlstring & " HAVING SUM(QTY) >= " & Val(TXT_SLOW.Text) & " And SUM(QTY) < " & Val(TXT_FAST.Text) & " "

            sqlstring = sqlstring & " UNION ALL "

            sqlstring = sqlstring & " SELECT I.ItemCode, I.ItemDesc , 0 , 'NON MOVING' FSNDESC , 3 ordno FROM ITEMMASTER I "
            sqlstring = sqlstring & " WHERE I.ItemCode NOT IN ( SELECT ITEMCODE FROM KOT_DET "
            sqlstring = sqlstring & " WHERE CAST(CONVERT(CHAR(39),KOTDATE,106) AS DATETIME) BETWEEN ' " & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "' "
            sqlstring = sqlstring & " AND ISNULL(I.FREEZE,'N') <> 'Y') "
            vconn.ExcuteStoreProcedure(sqlstring)

            Call Viewsalesgroupsummary()
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub Viewsalesgroupsummary()
        Try

            

            Dim Viewer As New ReportViwer
            Dim r As New FSNrpt_cr
            Dim strDt As String

            sqlstring = "SELECT * FROM VIEW_FSNrpt ORDER BY ordno , ITEMCODE, QTY DESC "

            Viewer.ssql = sqlstring
            Viewer.Report = r
            Viewer.TableName = "FSNRPT"

            Dim txtobjCompany As TextObject
            txtobjCompany = r.ReportDefinition.ReportObjects("Text10")
            txtobjCompany.Text = MyCompanyName

            Dim txtobjUser As TextObject
            txtobjUser = r.ReportDefinition.ReportObjects("Text4")
            strDt = gUsername
            txtobjUser.Text = strDt

            Dim txtobjFrmdt As TextObject
            txtobjFrmdt = r.ReportDefinition.ReportObjects("Text13")
            strDt = Format(mskToDate.Value, "MMM dd,yyyy") & " To " & Format(mskToDate.Value, "MMM dd,yyyy")
            txtobjFrmdt.Text = strDt

            'Dim txtobjTodt As TextObject
            'txtobjTodt = r.ReportDefinition.ReportObjects("Text10")
            'txtobjTodt.Text = Format(dtp_Fromdate.Value, "mon dd,yyyy")

            Viewer.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Sub Viewsalesgroupsummary_excel()
        Try
            Dim servercode() As String
            Dim i As Integer
            'sqlstring = "SELECT POSDESC,LEDGERNAME,SUM(BILLAMOUNT) AS AMOUNT FROM MC_POS_GROUPSUMMARY"
            'sqlstring = "SELECT ISNULL(POSDESC,'')AS POSDESC,ISNULL(KOTTYPE,'')AS KOTTYPE,ISNULL(MCODE,'')AS MCODE,ISNULL(KOTDETAILS,'')AS KOTDETAILS,ISNULL(KOTDATE,'')AS KOTDATE,ISNULL(LEDGERNAME,'')AS LEDGERNAME,ISNULL(QTY,0)AS QTY,ISNULL(UOM,'')AS UOM,ISNULL(AMOUNT,0)AS AMOUNT,"
            'sqlstring = sqlstring & " ISNULL(TAXAMOUNT,0)AS TAXAMOUNT,ISNULL(PACKAMOUNT,0)AS PACKAMOUNT FROM KOT_DET K INNER JOIN POSMASTER P ON K.POSCODE = P.POSCODE INNER JOIN ITEMMASTER I ON K.ITEMCODE = I.ITEMCODE"
            sqlstring = "alter VIEW VIEW_EXCEL AS SELECT ISNULL(K.ITEMCODE,'')AS ITEMCODE,ISNULL(P.POSDESC,'')AS POSDESC,ISNULL(K.KOTTYPE,'')AS KOTTYPE,ISNULL(K.MCODE,'')AS MCODE,ISNULL(K.KOTDETAILS,'')AS KOTDETAILS,ISNULL(K.KOTDATE,'')AS KOTDATE,"
            sqlstring = sqlstring & "ISNULL(I.LEDGERNAME,'')AS LEDGERNAME,ISNULL(K.QTY,0)AS QTY,ISNULL(K.UOM,'')AS UOM,ISNULL(K.AMOUNT,0)AS AMOUNT, ISNULL(K.TAXAMOUNT,0)AS TAXAMOUNT,ISNULL(K.PACKAMOUNT,0)AS PACKAMOUNT,"
            sqlstring = sqlstring & "(ISNULL(K.AMOUNT,0)+ ISNULL(K.TAXAMOUNT,0) + ISNULL(K.PACKAMOUNT,0))AS totamount,"
            sqlstring = sqlstring & "H.LOCATIONCODE,H.SLIPNO,H.PAYMENTTYPE FROM KOT_DET K INNER JOIN POSMASTER P ON K.POSCODE = P.POSCODE INNER JOIN ITEMMASTER I ON K.ITEMCODE = I.ITEMCODE INNER JOIN KOT_HDR H on K.KOTDETAILS = H.KOTDETAILS"

            sqlstring = sqlstring & " AND CAST(CONVERT(CHAR(39),K.KOTDATE,106) AS DATETIME) BETWEEN '"
            sqlstring = sqlstring & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "' AND ISNULL(K.DELFLAG,'')<>'Y' AND ISNULL(K.KOTSTATUS,'')='N'"
            'sqlstring = sqlstring & " ORDER BY K.MCODE,H.SLIPNO,P.POSDESC,K.KOTDETAILS"
            gconnection.getDataSet(sqlstring, "view_EXCEL")
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal pageheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date, ByVal frm As Object)
        Dim docdate, changeno, billsdetails, servercode, billamount, totalamount, POSCode, Ledger, dblBasicamt, dblnetamt, TIME As String
        Dim amount, basic, discountamount, i, count, YAMT As Integer
        Dim GrandQty, GrandAmount, TAmount, MTotal, MTaxAmt, MPackAmt, MGTotal As Double
        Dim SSQL1, SSQL2, MCODE As String
        Dim CHECK As Boolean
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            'Filewrite.Write(Chr(15))
            Call ReportHeader(pageheading, mskfromdate, msktodate)
            gconnection.getDataSet(SQLSTRING, "LEDGERSUMMARY")
            rowtotal = gdataset.Tables("LEDGERSUMMARY").Rows.Count
            rowcount = 100 / rowtotal
            count = 0
            If gdataset.Tables("LEDGERSUMMARY").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                basic = 0
                amount = 0
                For Each dr In gdataset.Tables("LEDGERSUMMARY").Rows
                    If pagesize > 50 Then
                        Filewrite.WriteLine(StrDup(135, "-"))
                        pagesize = pagesize + 1
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(pageheading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If MCODE <> dr("MCODE") Then
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                        'Filewrite.WriteLine("{0,-25}", Chr(14) & Chr(15) & Mid(CStr(dr("MCODE")), 1, 25) & ":")
                        'pagesize = pagesize + 1
                        'Filewrite.WriteLine("{0,-25}", "-------------------------")
                        'pagesize = pagesize + 1
                        'POSCode = dr("POSDESC")
                        'MCODE = dr("MCODE")
                        'If POSCode <> dr("POSDESC") Then
                        'If MCODE <> dr("MCODE") Then
                        '    '    If count > 0 Then
                        '    '        Filewrite.WriteLine("{0,-90}{1,20}", "", "-------------------")
                        '    '        pagesize = pagesize + 1
                        '    '        Filewrite.WriteLine("{0,-89}{1,20}", "Sub Total", Format(Val(MTotal), "0.00"))
                        '    '        pagesize = pagesize + 1
                        '    '        Filewrite.WriteLine("{0,-90}{1,20}", "", "-------------------")
                        '    '        pagesize = pagesize + 1
                        '    '        Filewrite.WriteLine("{0,-89}{1,20}", "Vat @ 2% on", Format(Val(MTaxAmt), "0.00"))
                        '    '        pagesize = pagesize + 1
                        '    '        Filewrite.WriteLine("{0,-89}{1,20}", "Pack Amount", Format(Val(MPackAmt), "0.00"))
                        '    '        pagesize = pagesize + 1
                        '    '        MGTotal = MGTotal + MTotal + MTaxAmt + MPackAmt
                        '    '        Filewrite.WriteLine("{0,-89}{1,20}", "Total", Format(Val(MGTotal), "0.00"))
                        '    '        pagesize = pagesize + 1
                        '    '        Filewrite.WriteLine()
                        '    '    End If
                        '    '    MCODE = dr("MCODE")
                        '    '    MTotal = 0
                        '    '    MTaxAmt = 0
                        '    '    MPackAmt = 0
                        '    '    MGTotal = 0
                        '    '    count = count + 1
                        '    'End If
                        '    Filewrite.WriteLine()
                        '    pagesize = pagesize + 1
                        '    Filewrite.WriteLine("{0,-25}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 25) & ":")
                        '    pagesize = pagesize + 1
                        '    Filewrite.WriteLine("{0,-25}", "-------------------------")
                        '    pagesize = pagesize + 1
                        '    POSCode = dr("POSDESC")
                        '    MCODE = dr("MCODE")
                        'End If
                        'If MCODE <> dr("MCODE") Then
                        If Val(MTotal) > 0 Then
                            Filewrite.WriteLine("{0,-90}{1,20}", "", "-------------------")
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-89}{1,20}", "Sub Total", Format(Val(MTotal), "0.00"))
                            pagesize = pagesize + 1
                        End If
                        If Val(MTaxAmt) > 0 Then
                            Filewrite.WriteLine("{0,-90}{1,20}", "", "-------------------")
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-89}{1,20}", "Vat @ 2% on", Format(Val(MTaxAmt), "0.00"))
                            pagesize = pagesize + 1
                        End If
                        If Val(MPackAmt) > 0 Then
                            Filewrite.WriteLine("{0,-89}{1,20}", "Pack Amount", Format(Val(MPackAmt), "0.00"))
                            pagesize = pagesize + 1
                        End If
                        If CHECK = True Then
                            Filewrite.WriteLine("{0,-89}{1,20}", "YORK/BOUNCE Amount", Format(Val(YAMT), "0.00"))
                            pagesize = pagesize + 1
                        End If
                        MGTotal = MGTotal + MTotal + MTaxAmt + MPackAmt + YAMT
                        GrandAmount = GrandAmount + MGTotal
                        Filewrite.WriteLine("{0,-89}{1,20}", "Total", Format(Val(MGTotal), "0.00"))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                        'Filewrite.WriteLine("{0,-25}", Chr(14) & Chr(15) & Mid(CStr(dr("MCODE")), 1, 25) & ":")
                        Filewrite.WriteLine("{0,-25}", Chr(14) & Mid(CStr(dr("MCODE")), 1, 25) & ":")
                        pagesize = pagesize + 1
                        Filewrite.WriteLine("{0,-25}", "-------------------------")
                        pagesize = pagesize + 1
                        MCODE = dr("MCODE")
                        MTotal = 0
                        MTaxAmt = 0
                        MPackAmt = 0
                        MGTotal = 0
                        YAMT = 0
                        CHECK = False
                    End If
                    'Filewrite.Write("{0,-12}", Mid(CStr(dr("KOTTYPE")), 1, 12))
                    Filewrite.Write("{0,-12}", Mid(CStr(dr("LOCATIONCODE")), 1, 12))
                    Filewrite.Write("{0,-10}", Mid(CStr(dr("MCODE")), 1, 10))
                    Filewrite.Write("{0,-10}", Mid(CStr(dr("SLIPNO")), 1, 10))
                    Filewrite.Write("{0,-10}", Mid(CStr(dr("ITEMCODE")), 1, 10))
                    Filewrite.Write("{0,-30}", Mid(CStr(dr("ITEMdEsc")), 1, 30))
                    Filewrite.Write("{0,12}", Mid(CStr(dr("QTY")), 1, 12))
                    Filewrite.Write("{0,5}{1,-10}", "", Mid(CStr(dr("UOM")), 1, 5))
                    TIME = Format(dr("KOTDATE"), "hh:mm")
                    If Mid(Trim(dr("LOCATIONCODE")), 1, 3) = "YOR" Then
                        Filewrite.Write("{0,10}", Mid(CStr(dr("AMOUNT")), 1, 10) & "Y")
                        '                        CHECK = True
                        '                       YAMT = "10"
                    ElseIf Mid(Trim(dr("LOCATIONCODE")), 1, 3) = "BOU" Then
                        Filewrite.Write("{0,10}", Mid(CStr(dr("AMOUNT")), 1, 10) & "B")
                        '                      CHECK = True
                        '                     YAMT = "10"
                    ElseIf Mid(Trim(dr("PAYMENTTYPE")), 1, 4) = "CASH" Then
                        Filewrite.Write("{0,10}", Mid(CStr(dr("AMOUNT")), 1, 10) & "C")
                    Else
                        If TIME > "19:00" Then
                            Filewrite.Write("{0,10}", Mid(CStr(dr("AMOUNT")), 1, 10) & "D")
                        Else
                            Filewrite.Write("{0,10}", Mid(CStr(dr("AMOUNT")), 1, 10))
                        End If
                    End If
                    'If Mid(Trim(dr("PAYMENTTYPE")), 1, 4) = "CASH" Then
                    '    Filewrite.Write("{0,10}", Mid(CStr(dr("AMOUNT")), 1, 10) & "C")
                    'End If
                    MTotal = MTotal + dr("AMOUNT")
                    MTaxAmt = MTaxAmt + dr("TAXAMOUNT")
                    MPackAmt = MPackAmt + dr("PACKAMOUNT")
                    'GrandAmount = GrandAmount + dr("AMOUNT")
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
                If Val(MTotal) > 0 Then
                    Filewrite.WriteLine("{0,-90}{1,20}", "", "-------------------")
                    pagesize = pagesize + 1
                    Filewrite.WriteLine("{0,-89}{1,20}", "Sub Total", Format(Val(MTotal), "0.00"))
                    pagesize = pagesize + 1
                End If
                If Val(MTaxAmt) > 0 Then
                    Filewrite.WriteLine("{0,-90}{1,20}", "", "-------------------")
                    pagesize = pagesize + 1
                    Filewrite.WriteLine("{0,-89}{1,20}", "Vat @ 2% on", Format(Val(MTaxAmt), "0.00"))
                    pagesize = pagesize + 1
                End If
                If Val(MPackAmt) > 0 Then
                    Filewrite.WriteLine("{0,-89}{1,20}", "Pack Amount", Format(Val(MPackAmt), "0.00"))
                    pagesize = pagesize + 1
                End If
                If CHECK = True Then
                    Filewrite.WriteLine("{0,-89}{1,20}", "YORK/BOUNCE Amount", Format(Val(YAMT), "0.00"))
                    pagesize = pagesize + 1
                End If
                MGTotal = MGTotal + MTotal + MTaxAmt + MPackAmt + YAMT
                GrandAmount = GrandAmount + MGTotal
                Filewrite.WriteLine("{0,-89}{1,20}", "Total", Format(Val(MGTotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine()
                pagesize = pagesize + 1

                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-80}{1,30}", "GRAND TOTAL =====>", Format(Val(GrandAmount), "0.00"))
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
            'Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,58}{1,-10}", " ", "CHECK LIST")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            'Filewrite.Write("{0,-12}{1,-25}{2,-15}{3,-20}{4,-8){5,-10}{6,-10)", "LOCATION", "MEMBER ", "KOT NUMBER", "LEDGER NAME", "QTY", "UOM", "AMOUNT")
            'Filewrite.WriteLine("{0,-12}", "TYPE")
            'pagesize = pagesize + 1
            'Filewrite.WriteLine("{0,-12}{1,-20}{2,-20}{3,-30}{4,-8}{5,-15}{6,-18}", "LOCATION/", "MEMBER", "KOT NUMBER", "LEDGER NAME", "QTY", "UOM", "AMOUNT")
            Filewrite.WriteLine("{0,-12}{1,-10}{2,-10}{3,-10}{4,-40}{5,-8}{6,-13}{7,-18}", "LOCATION/", "MEMBER", "SLIP NO.", "ITEM CODE", "ITEM DESC", "QTY", "UOM", "AMOUNT")
            'Filewrite.WriteLine("{0,-10}{1,-25}{2,8}{3,10}{4,10}", "ITEM", "ITEM", "QTY", "RATE", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-12}{1,-20}{2,-6}{3,12}{4,12}{5,-5}", "KOT TYPE", "", "", "", "", "")
            'Filewrite.WriteLine("{0,-10}{1,-25}{2,8}{3,10}{4,10}", "CODE", "DESCRIPTION", " ", " ", " ")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = True
            Call Viewsalesgroupsummary()
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub CMd_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMd_Excel.Click
        Dim _export As New EXPORT
        _export.TABLENAME = "VIEW_EXCEL"
        Call Viewsalesgroupsummary_excel()
        sqlstring = "select * from view_EXCEL ORDER BY MCODE,SLIPNO,POSDESC,KOTDETAILS"
        Call _export.export_excel(sqlstring)
        _export.Show()
        Exit Sub
    End Sub

    Private Sub mskFromDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskFromDate.ValueChanged

    End Sub

    Private Sub mskFromDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFromDate.KeyPress
        
    End Sub
End Class
