Imports System.Data
Imports System.Data.SqlClient
Public Class BILLING_CLOSING
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim ssql As String
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Posted As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmdDosView As System.Windows.Forms.Button
    Friend WithEvents cmdFillExport As System.Windows.Forms.Button
    Friend WithEvents dtpfromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RDB_KOTCLOSING As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_BILLCLOSING As System.Windows.Forms.RadioButton
    Friend WithEvents CMD_UNLOCK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BILLING_CLOSING))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtpfromdate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtptodate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CMD_UNLOCK = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Posted = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.cmdDosView = New System.Windows.Forms.Button
        Me.cmdFillExport = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.RDB_KOTCLOSING = New System.Windows.Forms.RadioButton
        Me.RDB_BILLCLOSING = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BILL  CLOSING DAILY / MONTHLY"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.dtpfromdate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtptodate)
        Me.Panel1.Location = New System.Drawing.Point(8, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 40)
        Me.Panel1.TabIndex = 1
        '
        'dtpfromdate
        '
        Me.dtpfromdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfromdate.Location = New System.Drawing.Point(124, 7)
        Me.dtpfromdate.Name = "dtpfromdate"
        Me.dtpfromdate.Size = New System.Drawing.Size(128, 26)
        Me.dtpfromdate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "From Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "To Date :"
        '
        'dtptodate
        '
        Me.dtptodate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptodate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtptodate.Location = New System.Drawing.Point(376, 8)
        Me.dtptodate.Name = "dtptodate"
        Me.dtptodate.Size = New System.Drawing.Size(120, 26)
        Me.dtptodate.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CMD_UNLOCK)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Posted)
        Me.GroupBox2.Controls.Add(Me.Cmd_Print)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Controls.Add(Me.cmdDosView)
        Me.GroupBox2.Controls.Add(Me.cmdFillExport)
        Me.GroupBox2.Location = New System.Drawing.Point(208, 544)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 56)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        '
        'CMD_UNLOCK
        '
        Me.CMD_UNLOCK.BackColor = System.Drawing.Color.Transparent
        Me.CMD_UNLOCK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMD_UNLOCK.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_UNLOCK.ForeColor = System.Drawing.Color.White
        Me.CMD_UNLOCK.Image = CType(resources.GetObject("CMD_UNLOCK.Image"), System.Drawing.Image)
        Me.CMD_UNLOCK.Location = New System.Drawing.Point(216, 16)
        Me.CMD_UNLOCK.Name = "CMD_UNLOCK"
        Me.CMD_UNLOCK.Size = New System.Drawing.Size(112, 32)
        Me.CMD_UNLOCK.TabIndex = 170
        Me.CMD_UNLOCK.Text = "UNLOCK [F10]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.Enabled = False
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(112, 96)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 3
        Me.Cmd_View.Text = "Fill View [F9]"
        '
        'Cmd_Posted
        '
        Me.Cmd_Posted.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Posted.Enabled = False
        Me.Cmd_Posted.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Posted.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Posted.ForeColor = System.Drawing.Color.White
        Me.Cmd_Posted.Image = CType(resources.GetObject("Cmd_Posted.Image"), System.Drawing.Image)
        Me.Cmd_Posted.Location = New System.Drawing.Point(496, 96)
        Me.Cmd_Posted.Name = "Cmd_Posted"
        Me.Cmd_Posted.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Posted.TabIndex = 1
        Me.Cmd_Posted.Text = "Audit Trial[F6]"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.Enabled = False
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(240, 96)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 2
        Me.Cmd_Print.Text = "Print [F12]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(416, 15)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 4
        Me.Cmd_Exit.Text = "Exit [F11]"
        '
        'cmdDosView
        '
        Me.cmdDosView.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdDosView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDosView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDosView.ForeColor = System.Drawing.Color.White
        Me.cmdDosView.Image = CType(resources.GetObject("cmdDosView.Image"), System.Drawing.Image)
        Me.cmdDosView.Location = New System.Drawing.Point(8, 16)
        Me.cmdDosView.Name = "cmdDosView"
        Me.cmdDosView.Size = New System.Drawing.Size(104, 32)
        Me.cmdDosView.TabIndex = 130
        Me.cmdDosView.Text = "LOCK  [F9]"
        '
        'cmdFillExport
        '
        Me.cmdFillExport.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdFillExport.Enabled = False
        Me.cmdFillExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFillExport.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFillExport.ForeColor = System.Drawing.Color.White
        Me.cmdFillExport.Image = CType(resources.GetObject("cmdFillExport.Image"), System.Drawing.Image)
        Me.cmdFillExport.Location = New System.Drawing.Point(384, 96)
        Me.cmdFillExport.Name = "cmdFillExport"
        Me.cmdFillExport.Size = New System.Drawing.Size(104, 32)
        Me.cmdFillExport.TabIndex = 169
        Me.cmdFillExport.Text = "Export[F2]"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(208, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 56)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(112, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Fill View [F9]"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.ForestGreen
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(496, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Audit Trial[F6]"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.ForestGreen
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(240, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Print [F12]"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.ForestGreen
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(384, 96)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 32)
        Me.Button6.TabIndex = 169
        Me.Button6.Text = "Export[F2]"
        '
        'RDB_KOTCLOSING
        '
        Me.RDB_KOTCLOSING.Checked = True
        Me.RDB_KOTCLOSING.Enabled = False
        Me.RDB_KOTCLOSING.Location = New System.Drawing.Point(18, 20)
        Me.RDB_KOTCLOSING.Name = "RDB_KOTCLOSING"
        Me.RDB_KOTCLOSING.Size = New System.Drawing.Size(224, 24)
        Me.RDB_KOTCLOSING.TabIndex = 82
        Me.RDB_KOTCLOSING.TabStop = True
        Me.RDB_KOTCLOSING.Text = "KOT CLOSING DAILY"
        '
        'RDB_BILLCLOSING
        '
        Me.RDB_BILLCLOSING.Enabled = False
        Me.RDB_BILLCLOSING.Location = New System.Drawing.Point(296, 16)
        Me.RDB_BILLCLOSING.Name = "RDB_BILLCLOSING"
        Me.RDB_BILLCLOSING.Size = New System.Drawing.Size(232, 32)
        Me.RDB_BILLCLOSING.TabIndex = 83
        Me.RDB_BILLCLOSING.Text = "MONTHLY  KOT/BILL CLOSING"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.RDB_KOTCLOSING)
        Me.GroupBox3.Controls.Add(Me.RDB_BILLCLOSING)
        Me.GroupBox3.Location = New System.Drawing.Point(200, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(536, 56)
        Me.GroupBox3.TabIndex = 84
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'BILLING_CLOSING
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 708)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "BILLING_CLOSING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BILLING_CLOSING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Hide()
    End Sub
    Private Sub cmdDosView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDosView.Click
        Try
            'If RDB_KOTCLOSING.Checked = True Then
            Checkdaterangevalidate(dtpfromdate.Value, dtptodate.Value)
            If chkdatevalidate = False Then Exit Sub

            ssql = " Update KOT_HDR  set postingstatus ='Y' where CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) Between '" & Format(dtpfromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtptodate.Value, "dd/MMM/yyyy") & "'"
            gconnection.dataOperation(2, ssql, "Billhdr")
            'Else
            ssql = " Update BILL_HDR  set ACCOUNTFLAG ='Y' where  CAST(CONVERT(VARCHAR(11),BILLDATE,6) AS DATETIME) Between '" & Format(dtpfromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtptodate.Value, "dd/MMM/yyyy") & "'"
            gconnection.dataOperation(2, ssql, "Billhdr")
            'End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BILLING_CLOSING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetRights()
        CMD_UNLOCK.Enabled = False
        cmdDosView.Enabled = False

        If gUserCategory = "S" Then
            CMD_UNLOCK.Enabled = True
            cmdDosView.Enabled = True
        End If
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='ACCOUNTS INTEGRATION' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.cmdDosView.Enabled = True
        Me.Cmd_View.Enabled = False
        Me.Cmd_Print.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmdDosView.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Me.Cmd_Print.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmdDosView.Text, 1, 1)) = "U" Then
                    If Right(x) = "S" Then
                        Me.cmdDosView.Enabled = True
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub BILLING_CLOSING_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(sender, e)
        ElseIf e.KeyCode = Keys.F9 Then
            Call cmdDosView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F10 Then
            Call Button4_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_UNLOCK.Click
        Try
            Checkdaterangevalidate(dtpfromdate.Value, dtptodate.Value)
            If chkdatevalidate = False Then Exit Sub
            ssql = " Update KOT_HDR  set postingstatus ='N' where CAST(CONVERT(VARCHAR(11),KOTDATE,6) AS DATETIME) Between '" & Format(dtpfromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtptodate.Value, "dd/MMM/yyyy") & "'"
            gconnection.dataOperation(2, ssql, "Billhdr")

            'Else

            ssql = " Update BILL_HDR  set ACCOUNTFLAG ='N' where  CAST(CONVERT(VARCHAR(11),BILLDATE,6) AS DATETIME) Between '" & Format(dtpfromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtptodate.Value, "dd/MMM/yyyy") & "'"
            gconnection.dataOperation(2, ssql, "Billhdr")

            'End If
        Catch ex As Exception
        End Try

    End Sub
End Class
