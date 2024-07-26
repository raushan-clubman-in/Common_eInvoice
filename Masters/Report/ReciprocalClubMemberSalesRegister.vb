Imports System.Data.SqlClient
Public Class ReciprocalClubMemberSalesRegister
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
    Friend WithEvents Chk_SelectAllServer As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_SelectAllPos As System.Windows.Forms.CheckBox
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LstPOS As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LstServer As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReciprocalClubMemberSalesRegister))
        Me.Chk_SelectAllServer = New System.Windows.Forms.CheckBox
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.LstPOS = New System.Windows.Forms.CheckedListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LstServer = New System.Windows.Forms.CheckedListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.frmbut.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chk_SelectAllServer
        '
        Me.Chk_SelectAllServer.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllServer.Location = New System.Drawing.Point(472, 16)
        Me.Chk_SelectAllServer.Name = "Chk_SelectAllServer"
        Me.Chk_SelectAllServer.Size = New System.Drawing.Size(104, 16)
        Me.Chk_SelectAllServer.TabIndex = 385
        Me.Chk_SelectAllServer.Text = "Select All"
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(104, 16)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.Size = New System.Drawing.Size(104, 16)
        Me.Chk_SelectAllPos.TabIndex = 384
        Me.Chk_SelectAllPos.Text = "Select All"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.CmdPrint)
        Me.frmbut.Controls.Add(Me.CmdClear)
        Me.frmbut.Controls.Add(Me.cmdexit)
        Me.frmbut.Controls.Add(Me.CmdView)
        Me.frmbut.Location = New System.Drawing.Point(160, 296)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(480, 54)
        Me.frmbut.TabIndex = 383
        Me.frmbut.TabStop = False
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.CmdPrint.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdPrint.Location = New System.Drawing.Point(248, 16)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(79, 23)
        Me.CmdPrint.TabIndex = 1
        Me.CmdPrint.Text = "Print "
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.CmdClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdClear.Location = New System.Drawing.Point(43, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(74, 23)
        Me.CmdClear.TabIndex = 0
        Me.CmdClear.Text = "Clear [F6]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.cmdexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdexit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdexit.Location = New System.Drawing.Point(353, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(78, 23)
        Me.cmdexit.TabIndex = 3
        Me.cmdexit.Text = "Exit [F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.CmdView.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdView.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdView.Location = New System.Drawing.Point(142, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(79, 23)
        Me.CmdView.TabIndex = 2
        Me.CmdView.Text = "View[F9]"
        '
        'mskToDate
        '
        Me.mskToDate.CustomFormat = "dd-MM-yy"
        Me.mskToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskToDate.Location = New System.Drawing.Point(520, 256)
        Me.mskToDate.MaxDate = New Date(2010, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(96, 20)
        Me.mskToDate.TabIndex = 381
        Me.mskToDate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 382
        Me.Label5.Text = "To Date :"
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yy"
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(280, 256)
        Me.mskFromDate.MaxDate = New Date(2010, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(96, 20)
        Me.mskFromDate.TabIndex = 379
        Me.mskFromDate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 380
        Me.Label2.Text = "From Date :"
        '
        'LstPOS
        '
        Me.LstPOS.Location = New System.Drawing.Point(104, 40)
        Me.LstPOS.Name = "LstPOS"
        Me.LstPOS.Size = New System.Drawing.Size(248, 184)
        Me.LstPOS.TabIndex = 375
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(368, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 378
        Me.Label4.Text = "Server Code :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 377
        Me.Label3.Text = "POS Loc :"
        '
        'LstServer
        '
        Me.LstServer.Location = New System.Drawing.Point(472, 40)
        Me.LstServer.Name = "LstServer"
        Me.LstServer.Size = New System.Drawing.Size(248, 184)
        Me.LstServer.TabIndex = 376
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(136, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 56)
        Me.GroupBox1.TabIndex = 386
        Me.GroupBox1.TabStop = False
        '
        'ReciprocalClubMemberSalesRegister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(744, 374)
        Me.Controls.Add(Me.Chk_SelectAllServer)
        Me.Controls.Add(Me.Chk_SelectAllPos)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.mskToDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mskFromDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LstPOS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LstServer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ReciprocalClubMemberSalesRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReciprocalClubMemberSalesRegister"
        Me.frmbut.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim ssql As String
    Public Myconn As New SqlConnection
    Dim ds As DataSet
    Dim chkbool As Boolean
    Dim da As New SqlDataAdapter
    Dim vconn As New GlobalClass

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        LstPOS.Items.Clear()
        LstServer.Items.Clear()
        Call FillPOS()
        Call FillServer()
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub FillPOS()   ' To fill POS details from POSMaster 
        LstPOS.Items.Clear()
        Dim i As Integer
        ssql = "select distinct poscode,posdesc from posmaster "
        vconn.getDataSet(ssql, "POS")
        If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                With gdataset.Tables("POS").Rows(i)
                    LstPOS.Items.Add(Trim(.Item("POScode") & "->" & .Item("POSdesc")))
                End With
            Next
        End If
    End Sub
    Private Sub FillServer()   ' To fill Server details from ServerMaster
        LstServer.Items.Clear()
        Dim i As Integer
        ssql = "select distinct servercode, servername from servermaster "
        vconn.getDataSet(ssql, "Server")
        If gdataset.Tables("Server").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("Server").Rows.Count - 1
                With gdataset.Tables("Server").Rows(i)
                    LstServer.Items.Add(Trim(.Item("ServerCode") & "->" & .Item("servername")))
                End With
            Next
        End If
    End Sub
    Private Sub SalesBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlstring As String
        Dim x As String
        Call FillPOS()
        Call FillServer()
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Dim posdesc() As String
        Dim servercode() As String
        Dim i As Integer
        validatedate()
        Dim sqlstring = "SELECT distinct dbo.POSMaster.POSDesc, dbo.Bill_Hdr.BillDate, dbo.Bill_Hdr.BillDetails,  "
        sqlstring = sqlstring & "   ISNULL(dbo.Bill_Hdr.BillAmount,0) AS BILLAMOUNT, ISNULL(dbo.Bill_Hdr.TaxAmount,0) AS TAXAMOUNT, "
        sqlstring = sqlstring & "   ISNULL(dbo.Bill_Hdr.TotalAmount,0) AS TOTALAMOUNT,dbo.Bill_Hdr.Receiptdetails ,dbo.Bill_Hdr.ReceiptDate ,ISNULL(dbo.Bill_Hdr.ReceiptAmount,0) AS ReceiptAmount , dbo.Bill_Hdr.Scode FROM dbo.bill_hdr "
        sqlstring = sqlstring & "   INNER JOIN dbo.Bill_Det ON dbo.Bill_Hdr.BillDetails = dbo.Bill_Det.BillDetails  "
        sqlstring = sqlstring & "   INNER JOIN dbo.KOT_DET ON dbo.Bill_Det.KotDetails = dbo.KOT_DET.KOTDETAILS "
        sqlstring = sqlstring & "   INNER JOIN dbo.KOT_HDR ON dbo.KOT_DET.KOTDETAILS = dbo.KOT_HDR.Kotdetails "
        sqlstring = sqlstring & "   INNER JOIN dbo.POSMaster ON dbo.KOT_DET.POSCODE = dbo.POSMaster.POSCode"
        If LstPOS.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " where dbo.posmaster.posdesc in ("
            For i = 0 To LstPOS.CheckedItems.Count - 1
                posdesc = Split(LstPOS.CheckedItems(i), "->")
                sqlstring = sqlstring & " '" & posdesc(1) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ") "
        Else
            MsgBox("select the location(s)")
            Exit Sub
        End If

        If LstServer.CheckedItems.Count <> 0 Then
            sqlstring = sqlstring & " and dbo.kot_hdr.servercode in ("
            For i = 0 To LstServer.CheckedItems.Count - 1
                servercode = Split(LstServer.CheckedItems(i), "->")
                sqlstring = sqlstring & servercode(0) & ", "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"
        Else
            MsgBox("select the server(s)")
            Exit Sub
        End If
        sqlstring = sqlstring & "and dbo.Bill_Hdr.BillDate between '"
        sqlstring = sqlstring & Format(mskFromDate.Value, "yyyy-MM-dd") & "' and ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        sqlstring = sqlstring & "  ORDER BY dbo.POSMaster.POSDesc, dbo.Bill_Hdr.BillDate, dbo.Bill_Hdr.BillDetails"
        'MsgBox(sqlstring)
        Dim columnheading() As String = {"Bill Date", "Bill No", "Basic", "Sales Tax", "Net Amt", "Paid Amt", "Rcpt No", "Rcpt Date", "Bal Amt", "Server"}
        Dim pageheading() As String = {"RECIPROCAL CLUB MEMBER SALES REGISTER"}
        Dim colsize() As Integer = {12, 18, 10, 12, 12, 12, 15, 12, 10, 10}
        Dim total() As Integer = {2, 4, 5, 7, 9}
        Dim SalesRegisterReport As New SalesRegisterReport
        SalesRegisterReport.begin()
        SalesRegisterReport.buttonclick(vconn.sqlconnection, sqlstring, pageheading, columnheading, colsize, LstPOS, mskFromDate.Value, mskToDate.Value, total)
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
            For i = 0 To LstPOS.Items.Count - 1
                LstServer.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To LstPOS.Items.Count - 1
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
        'MsgBox("printed")
        CmdView_Click(sender, e)
    End Sub
End Class
