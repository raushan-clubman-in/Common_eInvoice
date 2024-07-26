Imports System.Data.SqlClient
Imports System.IO
Public Class rptmanualadjustmentbills
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DTPSTARTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DTPBILLSTARTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPBILLENDDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPENDDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptmanualadjustmentbills))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DTPSTARTDATE = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.DTPBILLSTARTDATE = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DTPBILLENDDATE = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTPENDDATE = New System.Windows.Forms.DateTimePicker
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DTPSTARTDATE)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.DTPBILLSTARTDATE)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.DTPBILLENDDATE)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.DTPENDDATE)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(632, 96)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'DTPSTARTDATE
        '
        Me.DTPSTARTDATE.CustomFormat = "dd-MM-yyyy"
        Me.DTPSTARTDATE.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPSTARTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSTARTDATE.Location = New System.Drawing.Point(159, 24)
        Me.DTPSTARTDATE.MaxDate = New Date(2010, 8, 14, 0, 0, 0, 0)
        Me.DTPSTARTDATE.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.DTPSTARTDATE.Name = "DTPSTARTDATE"
        Me.DTPSTARTDATE.Size = New System.Drawing.Size(112, 22)
        Me.DTPSTARTDATE.TabIndex = 0
        Me.DTPSTARTDATE.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(304, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "ENTER START BILL DATE :"
        '
        'DTPBILLSTARTDATE
        '
        Me.DTPBILLSTARTDATE.CustomFormat = "dd-MM-yyyy"
        Me.DTPBILLSTARTDATE.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPBILLSTARTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBILLSTARTDATE.Location = New System.Drawing.Point(488, 24)
        Me.DTPBILLSTARTDATE.MaxDate = New Date(2010, 8, 14, 0, 0, 0, 0)
        Me.DTPBILLSTARTDATE.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.DTPBILLSTARTDATE.Name = "DTPBILLSTARTDATE"
        Me.DTPBILLSTARTDATE.Size = New System.Drawing.Size(112, 22)
        Me.DTPBILLSTARTDATE.TabIndex = 2
        Me.DTPBILLSTARTDATE.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "ENTER START DATE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(319, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ENTER END BILL DATE :"
        '
        'DTPBILLENDDATE
        '
        Me.DTPBILLENDDATE.CustomFormat = "dd-MM-yyyy"
        Me.DTPBILLENDDATE.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPBILLENDDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBILLENDDATE.Location = New System.Drawing.Point(489, 56)
        Me.DTPBILLENDDATE.MaxDate = New Date(2010, 8, 14, 0, 0, 0, 0)
        Me.DTPBILLENDDATE.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.DTPBILLENDDATE.Name = "DTPBILLENDDATE"
        Me.DTPBILLENDDATE.Size = New System.Drawing.Size(112, 22)
        Me.DTPBILLENDDATE.TabIndex = 3
        Me.DTPBILLENDDATE.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ENTER END DATE :"
        '
        'DTPENDDATE
        '
        Me.DTPENDDATE.CustomFormat = "dd-MM-yyyy"
        Me.DTPENDDATE.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPENDDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPENDDATE.Location = New System.Drawing.Point(160, 56)
        Me.DTPENDDATE.MaxDate = New Date(2010, 8, 14, 0, 0, 0, 0)
        Me.DTPENDDATE.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.DTPENDDATE.Name = "DTPENDDATE"
        Me.DTPENDDATE.Size = New System.Drawing.Size(112, 22)
        Me.DTPENDDATE.TabIndex = 1
        Me.DTPENDDATE.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(16, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 0
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(264, 16)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 2
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(384, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 3
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(144, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 1
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CmdView)
        Me.GroupBox4.Controls.Add(Me.cmdexit)
        Me.GroupBox4.Controls.Add(Me.CmdPrint)
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Location = New System.Drawing.Point(56, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(512, 56)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Blue
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(144, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "MANUAL ADJUSTMENT BILL REPORT"
        '
        'rptmanualadjustmentbills
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(648, 230)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "rptmanualadjustmentbills"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MANUAL BILL ADJUSTMENT "
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconn As New GlobalClass
    Dim vchk As Boolean
    Private Sub checkvalidation()
        vchk = False
        If DateDiff(DateInterval.Day, DTPSTARTDATE.Value, DTPENDDATE.Value) < 0 Then
            MsgBox("FROMDATE  Cannot be Greater than TODATE", MsgBoxStyle.Exclamation, Me.OwnedForms)
            vchk = True
            Exit Sub
        End If
        If DateDiff(DateInterval.Day, DTPENDDATE.Value, CDate(Now)) < 0 Then
            MsgBox("TODATE  Cannot be Greater than SYSTEMDATE", MsgBoxStyle.Exclamation, Me.OwnedForms)
            vchk = True
            DTPENDDATE.Focus()
            Exit Sub
        End If
        If DateDiff(DateInterval.Day, DTPBILLSTARTDATE.Value, DTPBILLENDDATE.Value) < 0 Then
            MsgBox("FROMDATE  Cannot be Greater than TODATE", MsgBoxStyle.Exclamation, Me.OwnedForms)
            vchk = True
            Exit Sub
        End If
        If DateDiff(DateInterval.Day, DTPBILLENDDATE.Value, CDate(Now)) < 0 Then
            MsgBox("TODATE  Cannot be Greater than SYSTEMDATE", MsgBoxStyle.Exclamation, Me.OwnedForms)
            vchk = True
            DTPBILLENDDATE.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub DTPSTARTDATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPSTARTDATE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DTPENDDATE.Focus()
        End If
    End Sub
    Private Sub DTPENDDATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPENDDATE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DTPBILLSTARTDATE.Focus()
        End If
    End Sub
    Private Sub DTPBILLSTARTDATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPBILLSTARTDATE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DTPBILLENDDATE.Focus()
        End If
    End Sub
    Private Sub DTPBILLENDDATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPBILLENDDATE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmdView.Focus()
        End If
    End Sub
    Private Sub rptmanualadjustmentbills_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTPBILLSTARTDATE.Focus()
    End Sub
    Private Sub rptmanualadjustmentbills_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
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
        End If
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        DTPSTARTDATE.Focus()
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        gPrint = False
        Call VIEWOPERATION()
    End Sub
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Dim SSQL As String
        gPrint = True
        SSQL = "SELECT * FROM VIEWMANUALADJUSTMENTLIST WHERE BILLDATE > = '" & Format(DTPSTARTDATE.Value, "dd/MMM/yyyy") & "'"
        SSQL = SSQL & " AND BILLDATE <= '" & Format(DTPENDDATE.Value, "dd/MMM/yyyy") & "'"
        SSQL = SSQL & " AND ADJDATE > = '" & Format(DTPBILLSTARTDATE.Value, "dd/MMM/yyyy") & "'"
        SSQL = SSQL & " AND ADJDATE <= '" & Format(DTPBILLENDDATE.Value, "dd/MMM/yyyy") & "'"
        Dim columnheading() As String = {"BILL DETAILS", "BILL DATE", "ADJUST DATE", "PAYMENT MODE", "CODE", "AMOUNT"}
        Dim pageheading() As String = {"MANUAL ADJUSTMENT BILL REPORT"}
        Dim colsize() As Integer = {16, 12, 12, 16, 12, 12}
        Dim OBJMANUALADJUSTMENTBILL As New ManualAdjustmentBill
        OBJMANUALADJUSTMENTBILL.Reportdetails(gconn.sqlconnection, SSQL, pageheading, columnheading, colsize, DTPBILLSTARTDATE.Value, DTPENDDATE.Value, DTPBILLSTARTDATE.Value, DTPBILLENDDATE.Value)
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub VIEWOPERATION()
        Dim SSQL As String
        gPrint = False
        SSQL = "SELECT * FROM VIEWMANUALADJUSTMENTLIST WHERE BILLDATE > = '" & Format(DTPSTARTDATE.Value, "dd/MMM/yyyy") & "'"
        SSQL = SSQL & " AND BILLDATE <= '" & Format(DTPENDDATE.Value, "dd/MMM/yyyy") & "'"
        SSQL = SSQL & " AND ADJDATE > = '" & Format(DTPBILLSTARTDATE.Value, "dd/MMM/yyyy") & "'"
        SSQL = SSQL & " AND ADJDATE <= '" & Format(DTPBILLENDDATE.Value, "dd/MMM/yyyy") & "'"
        Dim columnheading() As String = {"BILL DETAILS", "BILL DATE", "ADJUST DATE", "PAYMENT MODE", "CODE", "AMOUNT"}
        Dim pageheading() As String = {"MANUAL ADJUSTMENT BILL REPORT"}
        Dim colsize() As Integer = {16, 12, 12, 16, 12, 12}
        Dim OBJMANUALADJUSTMENTBILL As New ManualAdjustmentBill
        OBJMANUALADJUSTMENTBILL.Reportdetails(gconn.sqlconnection, SSQL, pageheading, columnheading, colsize, DTPBILLSTARTDATE.Value, DTPENDDATE.Value, DTPBILLSTARTDATE.Value, DTPBILLENDDATE.Value)
    End Sub
End Class