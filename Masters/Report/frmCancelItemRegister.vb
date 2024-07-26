Imports System.Data.SqlClient
Imports System.IO
Public Class frmCancelItemRegister
    Inherits System.Windows.Forms.Form
    Dim pageno As Integer
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCancelItemRegister))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdView = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdExit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.cmdView)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 48)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Transparent
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(320, 11)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(104, 32)
        Me.cmdExit.TabIndex = 19
        Me.cmdExit.Text = "Exit[F11]"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(168, 11)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 18
        Me.cmdPrint.Text = " Print [F8]"
        '
        'cmdView
        '
        Me.cmdView.BackColor = System.Drawing.Color.Transparent
        Me.cmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.ForeColor = System.Drawing.Color.White
        Me.cmdView.Image = CType(resources.GetObject("cmdView.Image"), System.Drawing.Image)
        Me.cmdView.Location = New System.Drawing.Point(16, 11)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(104, 32)
        Me.cmdView.TabIndex = 17
        Me.cmdView.Text = "View [F9]"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mskFromDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mskToDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 40)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(117, 10)
        Me.mskFromDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(99, 26)
        Me.mskFromDate.TabIndex = 0
        Me.mskFromDate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "TO DATE  :"
        '
        'mskToDate
        '
        Me.mskToDate.CustomFormat = "dd-MM-yyyy"
        Me.mskToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskToDate.Location = New System.Drawing.Point(352, 9)
        Me.mskToDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(100, 26)
        Me.mskToDate.TabIndex = 1
        Me.mskToDate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FROM DATE :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(352, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 25)
        Me.Label3.TabIndex = 394
        Me.Label3.Text = "CANCEL KOT/BILL REGISTER"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Location = New System.Drawing.Point(208, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 32)
        Me.GroupBox3.TabIndex = 395
        Me.GroupBox3.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(112, 8)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(56, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "BILL"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(8, 8)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(56, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "KOT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 640)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 18)
        Me.Label1.TabIndex = 418
        Me.Label1.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(216, 192)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(576, 200)
        Me.GroupBox4.TabIndex = 419
        Me.GroupBox4.TabStop = False
        '
        'frmCancelItemRegister
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 740)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmCancelItemRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CANCEL ITEM : : REGISTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Function printoperation_KOT()
        Dim heading As String
        Dim rowcount, TotalDoc As Integer
        Try
            'Dim Filewrite As StreamWriter
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Cro" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            heading = "CANCEL ITEM REGISTER"

            Filewrite.Write(Chr(15))
            PrintHeader(heading, mskFromDate.Value, mskToDate.Value)
            ''========================================================================
            Dim vString, sqlstring, ssql As String
            Dim vTypeseqno As Double
            Dim vGroupseqno As Double
            Dim totQty As Double
            Dim dt As New DataTable
            Dim i, j As Integer
            ssql = "SELECT * FROM KOT_DET WHERE KOTSTATUS='Y' AND ISNULL(DELFLAG,'')='Y' and cast(convert(varchar(11),KOTDATE,6) as DATETIME) BETWEEN '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND '" & Format(mskToDate.Value, "dd-MMM-yyyy") & "' order by kotno "
            gconnection.getDataSet(ssql, "cancel_item")
            If gdataset.Tables("cancel_item").Rows.Count > 0 Then
                Filewrite.Write(Chr(18))
                rowcount = 9
                For i = 0 To gdataset.Tables("cancel_item").Rows.Count - 1
                    sqlstring = Format(gdataset.Tables("cancel_item").Rows(i).Item("KOTDATE"), "dd-MMM-yyyy") & Space(1)
                    sqlstring = sqlstring & Trim(gdataset.Tables("cancel_item").Rows(i).Item("KOTDETAILS")) & Space(20 - Len(Trim(gdataset.Tables("cancel_item").Rows(i).Item("KOTDETAILS"))))
                    sqlstring = sqlstring & Trim(gdataset.Tables("cancel_item").Rows(i).Item("ITEMCODE")) & Space(9 - Len(Trim(gdataset.Tables("cancel_item").Rows(i).Item("ITEMCODE"))))
                    sqlstring = sqlstring & Trim(Mid(gdataset.Tables("cancel_item").Rows(i).Item("ITEMDESC"), 1, 28)) & Space(28 - Len(Trim(Mid(gdataset.Tables("cancel_item").Rows(i).Item("ITEMDESC"), 1, 28))))
                    sqlstring = sqlstring & Trim(gdataset.Tables("cancel_item").Rows(i).Item("SCODE")) & Space(4 - Len(Trim(gdataset.Tables("cancel_item").Rows(i).Item("SCODE"))))
                    sqlstring = sqlstring & Space(1) & Mid(Trim(gdataset.Tables("cancel_item").Rows(i).Item("ADDUSERID")), 1, 5)  '& Space(9 - Len(Mid(Trim(gdataset.Tables("cancel_item").Rows(i).Item("ADDUSERID")), 1, 7)))
                    Filewrite.WriteLine(sqlstring)
                    rowcount = rowcount + 1
                    TotalDoc = TotalDoc + 1
                    If rowcount >= 60 Then
                        Filewrite.WriteLine(StrDup(81, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        PrintHeader(heading, mskFromDate.Value, mskToDate.Value)
                        rowcount = 9
                    End If
                Next
                Filewrite.WriteLine(StrDup(81, "-"))
                Filewrite.WriteLine("Total Document(S)    : " & TotalDoc)
                Filewrite.WriteLine(StrDup(81, "-"))
                Filewrite.Write(Chr(12))
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            Else
                MessageBox.Show("No Records To Display", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid Billno :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        Finally
        End Try
    End Function
    Private Function printoperation_Bill()
        Dim heading As String
        Dim rowcount, TotalDoc As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Cro" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            heading = "CANCEL BILL REGISTER"

            Filewrite.Write(Chr(15))
            PrintHeader_BILL(heading, mskFromDate.Value, mskToDate.Value)

            ''========================================================================

            Dim vString, sqlstring, ssql As String
            Dim vTypeseqno As Double
            Dim vGroupseqno As Double
            Dim totQty As Double
            Dim dt As New DataTable
            Dim i, j As Integer
            ssql = "SELECT * FROM BILL_HDR WHERE  ISNULL(DELFLAG,'')='Y' and cast(convert(varchar(11),BILLDATE,6) as DATETIME) BETWEEN '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND '" & Format(mskToDate.Value, "dd-MMM-yyyy") & "' order by BILLNO "
            gconnection.getDataSet(ssql, "cancel_item")
            If gdataset.Tables("cancel_item").Rows.Count > 0 Then
                Filewrite.Write(Chr(18))
                rowcount = 9
                For i = 0 To gdataset.Tables("cancel_item").Rows.Count - 1
                    sqlstring = Format(gdataset.Tables("cancel_item").Rows(i).Item("BILLDATE"), "dd-MMM-yyyy") & Space(1)
                    sqlstring = sqlstring & Trim(gdataset.Tables("cancel_item").Rows(i).Item("BILLDETAILS")) & Space(20 - Len(Trim(gdataset.Tables("cancel_item").Rows(i).Item("BILLDETAILS"))))
                    sqlstring = sqlstring & Space(10 - Len(Mid(Trim(gdataset.Tables("cancel_item").Rows(i).Item("TOTALAMOUNT")), 1, 10))) & Trim(gdataset.Tables("cancel_item").Rows(i).Item("TOTALAMOUNT")) & Space(10)
                    sqlstring = sqlstring & Mid(Trim(gdataset.Tables("cancel_item").Rows(i).Item("ADDUSERID")), 1, 15) & Space(15 - Len(Mid(Trim(gdataset.Tables("cancel_item").Rows(i).Item("ADDUSERID")), 1, 15)))
                    Filewrite.WriteLine(sqlstring)
                    rowcount = rowcount + 1
                    TotalDoc = TotalDoc + 1
                    If rowcount >= 60 Then
                        Filewrite.WriteLine(StrDup(81, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        PrintHeader_BILL(heading, mskFromDate.Value, mskToDate.Value)
                        rowcount = 9
                    End If
                Next
                Filewrite.WriteLine(StrDup(81, "-"))
                Filewrite.WriteLine("Total Document(S)    : " & TotalDoc)
                Filewrite.WriteLine(StrDup(81, "-"))
                Filewrite.Write(Chr(12))
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            Else
                MessageBox.Show("No Records To Display", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid Billno :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        Finally
        End Try
    End Function

    Private Function PrintHeader(ByVal HEADING As String, ByVal fDATE As Date, ByVal tDate As Date)
        Dim I As Integer
        Dim sstring As String
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(18) & Chr(27) + "E")
            Filewrite.WriteLine(Mid(MyCompanyName, 1, 30) & Chr(27) + "F")
            Filewrite.Write(Chr(18))
            Filewrite.WriteLine("CANCEL KOT REGISTER FROM:" & Format(mskFromDate.Value, "dd/MM/yyyy") & " TO:" & Format(mskFromDate.Value, "dd/MM/yyyy") & Space(10) & "PRINTED ON :" & Format(SYSDATE, "dd/MM/yyyy"))
            Filewrite.WriteLine(StrDup(81, "-"))
            sstring = "KOTDATE     KOTNO            ITEMCODE    ITEMDESCRIPTION              SCODE  USER   "
            Filewrite.WriteLine(sstring)
            Filewrite.WriteLine(StrDup(81, "-"))
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function PrintHeader_BILL(ByVal HEADING As String, ByVal fDATE As Date, ByVal tDate As Date)
        Dim I As Integer
        Dim sstring As String
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(18) & Chr(27) + "E")
            Filewrite.WriteLine(Mid(MyCompanyName, 1, 30) & Chr(27) + "F")
            Filewrite.Write(Chr(18))
            Filewrite.WriteLine("CANCEL BILL REGISTER FROM:" & Format(mskFromDate.Value, "dd/MM/yyyy") & " TO:" & Format(mskFromDate.Value, "dd/MM/yyyy") & Space(10) & "PRINTED ON :" & Format(SYSDATE, "dd/MM/yyyy"))
            Filewrite.WriteLine(StrDup(81, "-"))
            sstring = "KOTDATE     KOTNO            ITEMCODE    ITEMDESCRIPTION              SCODE  USER   "
            Filewrite.WriteLine(sstring)
            Filewrite.WriteLine(StrDup(81, "-"))
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    'Private Function PrintHeader(ByVal HEADING As String, ByVal fDATE As Date, ByVal tDate As Date)
    '    Dim I As Integer
    '    Dim sstring As String
    '    Try
    '        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
    '        Filewrite.Write(Chr(18) & Chr(27) + "E" & Chr(27) + "F")
    '        Filewrite.WriteLine("{0,23}{1,20}{2,11}{3,25}", "", gUsername, " ", "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
    '        Filewrite.Write(Chr(15))
    '        Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
    '        Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
    '        Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING)), "-"), 1, 30))
    '        Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
    '        Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
    '        Filewrite.WriteLine("{0,-30}{1,-30}", "From : " & Format(mskFromDate.Value, "MMM dd,yyyy"), "To : " & Format(mskToDate.Value, "MMM dd,yyyy"))
    '        Filewrite.Write(Chr(18))
    '        Filewrite.WriteLine(StrDup(79, "-"))
    '        sstring = "KOTDATE     KOTNO            ITEMCODE ITEMDESCRIPTION            SCODE  USER   "
    '        Filewrite.WriteLine(sstring)
    '        Filewrite.WriteLine(StrDup(79, "-"))

    '        '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
    '    Catch ex As Exception
    '        Exit Function
    '    End Try
    'End Function

    Private Sub frmCancelItemRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mskFromDate.Value = Now.Today
        mskToDate.Value = Now.Today
    End Sub
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        gPrint = False
        If RadioButton1.Checked = True Then
            Call printoperation_KOT()
        Else
            printoperation_Bill()
        End If
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        gPrint = True
        If RadioButton1.Checked = True Then
            Call printoperation_KOT()
        Else
            printoperation_Bill()
        End If
    End Sub
    Private Sub frmCancelItemRegister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F8 Then
            If cmdPrint.Enabled = True Then
                Call cmdPrint_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If cmdView.Enabled = True Then
                Call cmdView_Click(sender, e)
                Exit Sub
            End If
        End If
    End Sub
End Class
