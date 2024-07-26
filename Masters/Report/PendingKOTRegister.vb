Imports System.Data.SqlClient
Public Class PendingKOTRegister
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
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grp_Salebillitemwise As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PendingKOTRegister))
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grp_Salebillitemwise = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp_Salebillitemwise.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(24, 192)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 16
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(256, 16)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 14
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(376, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 15
        Me.cmdexit.Text = "Exit[F11]"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mskFromDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mskToDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 104)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(216, 24)
        Me.mskFromDate.MaxDate = New Date(2010, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(144, 26)
        Me.mskFromDate.TabIndex = 0
        Me.mskFromDate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "To Date :"
        '
        'mskToDate
        '
        Me.mskToDate.CustomFormat = "dd-MM-yyyy"
        Me.mskToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskToDate.Location = New System.Drawing.Point(216, 64)
        Me.mskToDate.MaxDate = New Date(2010, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(144, 26)
        Me.mskToDate.TabIndex = 1
        Me.mskToDate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From Date :"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(136, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 13
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Controls.Add(Me.CmdPrint)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "PENDING KOT REGISTER"
        '
        'grp_Salebillitemwise
        '
        Me.grp_Salebillitemwise.BackgroundImage = CType(resources.GetObject("grp_Salebillitemwise.BackgroundImage"), System.Drawing.Image)
        Me.grp_Salebillitemwise.Controls.Add(Me.lbl_Wait)
        Me.grp_Salebillitemwise.Controls.Add(Me.ProgressBar1)
        Me.grp_Salebillitemwise.Location = New System.Drawing.Point(8, 1000)
        Me.grp_Salebillitemwise.Name = "grp_Salebillitemwise"
        Me.grp_Salebillitemwise.Size = New System.Drawing.Size(496, 80)
        Me.grp_Salebillitemwise.TabIndex = 19
        Me.grp_Salebillitemwise.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(256, 32)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 18)
        Me.lbl_Wait.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 24)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(464, 40)
        Me.ProgressBar1.TabIndex = 0
        '
        'Timer1
        '
        '
        'PendingKOTRegister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(526, 244)
        Me.ControlBox = False
        Me.Controls.Add(Me.grp_Salebillitemwise)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "PendingKOTRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PendingKOTRegister"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grp_Salebillitemwise.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim chkbool As Boolean
    Dim gconnetion As New GlobalClass

    Private Sub PendingKOTRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grp_Salebillitemwise.Top = 1000
        mskFromDate.Value = Format(Now, "dd-MM-yyyy")
        mskToDate.Value = Format(Now, "dd-MM-yyyy")
        mskFromDate.Focus()
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        mskFromDate.Value = Format(Now, "dd-MM-yyyy")
        mskToDate.Value = Format(Now, "dd-MM-yyyy")
        mskFromDate.Focus()
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Call Validatedate() '''--> Check Validation
        If chkbool = False Then Exit Sub
        grp_Salebillitemwise.Top = 72
        grp_Salebillitemwise.Left = 8
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 100
        Me.Timer1.Enabled = True
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        gPrint = True
        Call CmdView_Click(sender, e)
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Function Validatedate()
        chkbool = False
        If Format(mskFromDate.Value, "MM-dd-yyyy") > Format(Now.Today, "MM-dd-yyyy") Then
            MsgBox("From Date Should Less Than Today Date", MsgBoxStyle.Information, "Calcutta Swimming Club")
            mskFromDate.Text = ""
            mskFromDate.Focus()
            Exit Function
        End If
        If Format(mskFromDate.Value, "MM-dd-yyyy") < Format(CDate("01-Apr-" & gFinancalyearStart), "MM-dd-yyyy") Then
            MsgBox("From Date Should  Be In The Finacial Year", MsgBoxStyle.Information, "Calcutta Swimming Club")
            mskFromDate.Text = ""
            mskFromDate.Focus()
            Exit Function
        End If
        If Format(mskFromDate.Value, "MM-dd-yyyy") > Format(mskToDate.Value, "MM-dd-yyyy") Then
            MsgBox("From Date Should Be Less Than To Date", MsgBoxStyle.Information, "Calcutta Swimming Club")
            Exit Function
        End If
        If Format(mskToDate.Value, "MM-dd-yyyy") > Format(Now.Today, "MM-dd-yyyy") Then
            MsgBox("To Date Should Less Be Than Today Date", MsgBoxStyle.Information, "Calcutta Swimming Club")
            mskToDate.Text = ""
            mskToDate.Focus()
            Exit Function
        End If
        If Format(mskToDate.Value, "MM-dd-yyyy") > Format("31-Mar-07", "MM-dd-yyyy") Then
            MsgBox("To Date Should Not Be Less Than Finacial Year", MsgBoxStyle.Information, "Calcutta Swimming Club")
            mskToDate.Text = ""
            mskToDate.Focus()
            Exit Function
        End If
        If Format(mskFromDate.Value, "MM-dd-yyyy") > Format(mskToDate.Value, "MM-dd-yyyy") Then
            MsgBox("From Date Should Be Less Than To Date", MsgBoxStyle.Information, "Calcutta Swimming Club")
            Exit Function
        End If
        CmdView.Focus()
        chkbool = True
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_Salebillitemwise.Top = 1000
            Call PendingKOTRegister()
        End If
    End Sub
    Private Sub PendingKOTRegister()
        Dim i As Integer
        Dim sqlstring As String
        Call Validatedate() '''--> Check Validation
        If chkbool = False Then Exit Sub
        sqlstring = " SELECT ISNULL(K.SERVERNAME,'') AS SERVERNAME,ISNULL(K.SERVERCODE,'') AS SERVERCODE,ISNULL(K.MCODE,'') AS MCODE,ISNULL(K.ADDUSERID,'') AS ADDUSERID,K.ADDDATETIME,K.KOTDATE,K.KOTDETAILS,"
        sqlstring = sqlstring & " D.ITEMCODE,D.ITEMDESC,D.QTY,D.UOM,D.RATE,D.TAXAMOUNT,D.AMOUNT,D.KOTSTATUS "
        sqlstring = sqlstring & " FROM KOT_HDR AS K INNER JOIN KOT_DET AS D ON K.KOTDETAILS = D.KOTDETAILS "
        sqlstring = sqlstring & " WHERE CAST(CONVERT(varchar(11),K.KOTDATE,6) AS DATETIME) BETWEEN "
        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
        sqlstring = sqlstring & " ORDER BY K.SERVERNAME,K.KOTDETAILS "
        Dim ColumnHeading() As String = {"SERVER/", "BILL DATE", "BILL", "NUMBER", "ITEM", "CODE", "DESCRIPTION", "QTY", "UOM", "RATE", "TAX", "AMOUNT"}
        Dim ReportHeading() As String = {"PENDING KOT REGISTER"}
        Dim ColumnSize() As Integer = {17, 20, 14, 25, 10, 10, 10, 8, 8}
        Dim ObjPendingKOTRegisterReport As New PendingKOTRegisterReport
        ObjPendingKOTRegisterReport.begin()
        ObjPendingKOTRegisterReport.buttonclick(gconnetion.sqlconnection, sqlstring, ReportHeading, ColumnHeading, ColumnSize, mskFromDate.Value, mskToDate.Value)
    End Sub

    Private Sub mskFromDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFromDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            mskToDate.Focus()
        End If
    End Sub

    Private Sub mskToDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskToDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmdView.Focus()
        End If
    End Sub
End Class
