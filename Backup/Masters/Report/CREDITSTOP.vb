Imports System.Data.SqlClient
Imports System.io
Public Class CREDITSTOP
    Inherits System.Windows.Forms.Form
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Dim ssql As String
    Dim chkbool As Boolean
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
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RND_DEFAULTER As System.Windows.Forms.RadioButton
    Friend WithEvents RND_CREDITSTOP As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_BILLDATE As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CREDITSTOP))
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RND_DEFAULTER = New System.Windows.Forms.RadioButton
        Me.RND_CREDITSTOP = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTP_BILLDATE = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(416, 25)
        Me.Label2.TabIndex = 408
        Me.Label2.Text = "CREDIT STOP LIST  AND DEFAULTER LIST"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(184, 480)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 418
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(504, 480)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 416
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(672, 480)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 417
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(344, 480)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 415
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(128, 464)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox4.TabIndex = 419
        Me.GroupBox4.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DTP_BILLDATE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RND_DEFAULTER)
        Me.GroupBox1.Controls.Add(Me.RND_CREDITSTOP)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 160)
        Me.GroupBox1.TabIndex = 420
        Me.GroupBox1.TabStop = False
        '
        'RND_DEFAULTER
        '
        Me.RND_DEFAULTER.Checked = True
        Me.RND_DEFAULTER.Location = New System.Drawing.Point(120, 32)
        Me.RND_DEFAULTER.Name = "RND_DEFAULTER"
        Me.RND_DEFAULTER.Size = New System.Drawing.Size(120, 24)
        Me.RND_DEFAULTER.TabIndex = 1
        Me.RND_DEFAULTER.TabStop = True
        Me.RND_DEFAULTER.Text = "DEFAULTER"
        '
        'RND_CREDITSTOP
        '
        Me.RND_CREDITSTOP.Location = New System.Drawing.Point(368, 32)
        Me.RND_CREDITSTOP.Name = "RND_CREDITSTOP"
        Me.RND_CREDITSTOP.Size = New System.Drawing.Size(152, 24)
        Me.RND_CREDITSTOP.TabIndex = 0
        Me.RND_CREDITSTOP.Text = "CREDIT STOP"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(168, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BILL DATE :"
        '
        'DTP_BILLDATE
        '
        Me.DTP_BILLDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_BILLDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_BILLDATE.Location = New System.Drawing.Point(272, 96)
        Me.DTP_BILLDATE.Name = "DTP_BILLDATE"
        Me.DTP_BILLDATE.Size = New System.Drawing.Size(88, 22)
        Me.DTP_BILLDATE.TabIndex = 3
        '
        'CREDITSTOP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 558)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "CREDITSTOP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREDITSTOP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        gPrint = False
        gconnection.ExcuteStoreProcedure("EXEC cp_creditlimit_REP  '" & Format(DTP_BILLDATE.Value, "dd/MMM/yyyy") & "'")
        CREDITSTOP()
    End Sub
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        gPrint = False
        gconnection.ExcuteStoreProcedure("EXEC cp_creditlimit_REP  '" & Format(DTP_BILLDATE.Value, "dd/MMM/yyyy") & "'")
        CREDITSTOP()
    End Sub
    Private Sub CREDITSTOP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CREDITSTOP()
        Try
            Dim i As Integer
            Dim SERVERCODE(), POSCODE() As String
            Dim AMOUNT, dblTax, dblNet, dblPaid As Double
            Dim ddblBasic, ddblTax, ddblNet, ddblPaid As Double
            Dim POSGrand, POSCount, POSTOTAL As Double
            Dim POSBool As Boolean
            Dim POSDESC As String
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            pagesize = 0


            Dim sqlstring = "select mcode,mname,isnull(cdr,0)-isnull(cCr,0) as amount from CREDITSTOP_MCODE_REP  WHERE "
            If RND_CREDITSTOP.Checked = True Then
                sqlstring = sqlstring & " ISNULL(FLAG,'')='C' "
            Else
                sqlstring = sqlstring & " ISNULL(FLAG,'')='D' "
            End If
            gconnection.getDataSet(sqlstring, "CASHSALEREGISTER")
            If gdataset.Tables("CASHSALEREGISTER").Rows.Count > 0 Then
                pagesize = pagesize + 1
                Filewrite.WriteLine(UCase(MyCompanyName))

                If RND_CREDITSTOP.Checked = True Then
                    Filewrite.WriteLine("CREDIT STOP LIST                                  Page No:" & pageno)
                Else
                    Filewrite.WriteLine("DEFAULTER LIST                                    Page No:" & pageno)
                End If

                Filewrite.WriteLine(StrDup(80, "="))
                Filewrite.WriteLine("MCODE     MNAME                                      AMOUNT")
                Filewrite.WriteLine(StrDup(80, "="))
                For Each dr In gdataset.Tables("CASHSALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.WriteLine(StrDup(80, "="))
                        Filewrite.Write(Chr(12))

                        Filewrite.WriteLine(UCase(MyCompanyName))
                        If RND_CREDITSTOP.Checked = True Then
                            Filewrite.WriteLine("CREDIT STOP LIST                                  Page No:" & pageno)
                        Else
                            Filewrite.WriteLine("DEFAULTER LIST                                    Page No:" & pageno)
                        End If
                        Filewrite.WriteLine(StrDup(80, "="))
                        Filewrite.WriteLine("MCODE     MNAME                                      AMOUNT")
                        Filewrite.WriteLine(StrDup(80, "="))
                        pageno = pageno + 1
                        pagesize = 0
                    End If
                    Filewrite.Write("{0,-10}", Mid(Trim(CStr(dr("MCODE"))), 1, 10))
                    Filewrite.Write("{0,-40}", Mid((dr("MNAME")), 1, 40))
                    Filewrite.WriteLine("{0,8}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 8))
                    pagesize = pagesize + 1
                    POSCount = POSCount + 1
                    POSGrand = POSGrand + 1
                    AMOUNT = AMOUNT + Val(dr("AMOUNT"))
                Next dr
                Filewrite.WriteLine(StrDup(80, "="))
                Filewrite.WriteLine("{0,-10}{1,40}{2,8}", "", "Grand Total =====>", Format(Val(AMOUNT), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(80, "="))
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub


    Private Sub CREDITSTOP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Dim i As Integer
            If e.KeyCode = Keys.F8 Then
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
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub


End Class
