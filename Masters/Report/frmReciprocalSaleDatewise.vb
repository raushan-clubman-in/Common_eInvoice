Public Class frmReciprocalSaleDatewise
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
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReciprocalSaleDatewise))
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(16, 216)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 406
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(240, 216)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 403
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(352, 216)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 405
        Me.cmdexit.Text = "Exit[F11]"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(48, 1000)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(360, 64)
        Me.grp_SalebillChecklist.TabIndex = 404
        Me.grp_SalebillChecklist.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(168, 24)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 18)
        Me.lbl_Wait.TabIndex = 387
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(336, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(48, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(360, 104)
        Me.GroupBox3.TabIndex = 401
        Me.GroupBox3.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(160, 24)
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
        Me.Label6.Location = New System.Drawing.Point(48, 64)
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
        Me.mskToDate.Location = New System.Drawing.Point(160, 64)
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
        Me.Label7.Location = New System.Drawing.Point(22, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(128, 216)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 402
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(10, 203)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(453, 56)
        Me.GroupBox4.TabIndex = 407
        Me.GroupBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(332, 25)
        Me.Label3.TabIndex = 408
        Me.Label3.Text = "RECIPROCAL SALE [ DATE WISE ]"
        '
        'Timer1
        '
        '
        'frmReciprocalSaleDatewise
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(470, 273)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmReciprocalSaleDatewise"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECIPROCAL SALE [ DATE WISE ]"
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Private Sub frmReciprocalSaleDatewise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mskFromDate.Value = Now.Today
            mskToDate.Value = Now.Today
            grp_SalebillChecklist.Top = 1000
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            grp_SalebillChecklist.Top = 1000
            mskFromDate.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = False
            grp_SalebillChecklist.Top = 96
            grp_SalebillChecklist.Left = 48
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = True
            grp_SalebillChecklist.Top = 96
            grp_SalebillChecklist.Left = 48
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
                Me.ProgressBar1.Value += 1
                Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
            Else
                Me.Timer1.Enabled = False
                Me.ProgressBar1.Value = 0
                Me.grp_SalebillChecklist.Top = 1000
                Call ViewReciprocalSaleDATEWISE()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub mskFromDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFromDate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                mskToDate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub mskToDate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskToDate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                CmdView.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub frmReciprocalSaleDatewise_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
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
            ElseIf e.Alt = True And e.KeyCode = Keys.F Then
                Me.mskFromDate.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.T Then
                Me.mskToDate.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub ViewReciprocalSaleDATEWISE()
        Try
            Dim i As Integer
            Dim sqlstring = "SELECT * FROM VIEWRECIPROCALSALE"
            sqlstring = sqlstring & " WHERE PAYMENTMODE = 'R.MEMBER' AND CAST(Convert(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN "
            sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"
            sqlstring = sqlstring & " ORDER BY BILLDATE, BILLDETAILS"
            Dim pageheading() As String = {"RECIPROCAL SALE REGISTER"}
            Dim ObjReciprocalSaleRegister As New rptReciprocalSaleRegister
            ObjReciprocalSaleRegister.Reportdetails(sqlstring, pageheading, mskFromDate.Value, mskToDate.Value)
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try

    End Sub
End Class
