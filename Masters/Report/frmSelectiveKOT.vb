Imports System.Data.SqlClient
Imports System.io
Public Class frmSelectiveKOT
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
    Friend WithEvents lbl_Finalbill As System.Windows.Forms.Label
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Tobill As System.Windows.Forms.Label
    Friend WithEvents lbl_Frombill As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents Cmd_ToKot As System.Windows.Forms.Button
    Friend WithEvents Cmd_FromKot As System.Windows.Forms.Button
    Friend WithEvents txt_ToKot As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromKot As System.Windows.Forms.TextBox
    Friend WithEvents grp_FinalbillRegister As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSelectiveKOT))
        Me.lbl_Finalbill = New System.Windows.Forms.Label
        Me.CmdClear = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmd_ToKot = New System.Windows.Forms.Button
        Me.Cmd_FromKot = New System.Windows.Forms.Button
        Me.txt_ToKot = New System.Windows.Forms.TextBox
        Me.txt_FromKot = New System.Windows.Forms.TextBox
        Me.lbl_Tobill = New System.Windows.Forms.Label
        Me.lbl_Frombill = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.grp_FinalbillRegister = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp_FinalbillRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Finalbill
        '
        Me.lbl_Finalbill.AutoSize = True
        Me.lbl_Finalbill.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Finalbill.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Finalbill.Location = New System.Drawing.Point(128, 24)
        Me.lbl_Finalbill.Name = "lbl_Finalbill"
        Me.lbl_Finalbill.Size = New System.Drawing.Size(270, 25)
        Me.lbl_Finalbill.TabIndex = 7
        Me.lbl_Finalbill.Text = "SELECTIVE KOT'S REPORT"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Cmd_ToKot)
        Me.GroupBox1.Controls.Add(Me.Cmd_FromKot)
        Me.GroupBox1.Controls.Add(Me.txt_ToKot)
        Me.GroupBox1.Controls.Add(Me.txt_FromKot)
        Me.GroupBox1.Controls.Add(Me.lbl_Tobill)
        Me.GroupBox1.Controls.Add(Me.lbl_Frombill)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Cmd_ToKot
        '
        Me.Cmd_ToKot.Image = CType(resources.GetObject("Cmd_ToKot.Image"), System.Drawing.Image)
        Me.Cmd_ToKot.Location = New System.Drawing.Point(384, 72)
        Me.Cmd_ToKot.Name = "Cmd_ToKot"
        Me.Cmd_ToKot.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ToKot.TabIndex = 3
        '
        'Cmd_FromKot
        '
        Me.Cmd_FromKot.Image = CType(resources.GetObject("Cmd_FromKot.Image"), System.Drawing.Image)
        Me.Cmd_FromKot.Location = New System.Drawing.Point(384, 24)
        Me.Cmd_FromKot.Name = "Cmd_FromKot"
        Me.Cmd_FromKot.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_FromKot.TabIndex = 1
        '
        'txt_ToKot
        '
        Me.txt_ToKot.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToKot.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToKot.Location = New System.Drawing.Point(160, 72)
        Me.txt_ToKot.Name = "txt_ToKot"
        Me.txt_ToKot.Size = New System.Drawing.Size(224, 29)
        Me.txt_ToKot.TabIndex = 2
        Me.txt_ToKot.Text = ""
        '
        'txt_FromKot
        '
        Me.txt_FromKot.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromKot.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromKot.Location = New System.Drawing.Point(160, 24)
        Me.txt_FromKot.Name = "txt_FromKot"
        Me.txt_FromKot.Size = New System.Drawing.Size(224, 29)
        Me.txt_FromKot.TabIndex = 0
        Me.txt_FromKot.Text = ""
        '
        'lbl_Tobill
        '
        Me.lbl_Tobill.AutoSize = True
        Me.lbl_Tobill.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tobill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tobill.Location = New System.Drawing.Point(65, 72)
        Me.lbl_Tobill.Name = "lbl_Tobill"
        Me.lbl_Tobill.Size = New System.Drawing.Size(80, 22)
        Me.lbl_Tobill.TabIndex = 3
        Me.lbl_Tobill.Text = "TO KOT :"
        '
        'lbl_Frombill
        '
        Me.lbl_Frombill.AutoSize = True
        Me.lbl_Frombill.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Frombill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frombill.Location = New System.Drawing.Point(40, 24)
        Me.lbl_Frombill.Name = "lbl_Frombill"
        Me.lbl_Frombill.Size = New System.Drawing.Size(107, 22)
        Me.lbl_Frombill.TabIndex = 2
        Me.lbl_Frombill.Text = "FROM KOT :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdPrint)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
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
        Me.cmdexit.Location = New System.Drawing.Point(376, 16)
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
        Me.CmdView.Location = New System.Drawing.Point(136, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 1
        Me.CmdView.Text = "View [F9]"
        '
        'grp_FinalbillRegister
        '
        Me.grp_FinalbillRegister.BackgroundImage = CType(resources.GetObject("grp_FinalbillRegister.BackgroundImage"), System.Drawing.Image)
        Me.grp_FinalbillRegister.Controls.Add(Me.lbl_Wait)
        Me.grp_FinalbillRegister.Controls.Add(Me.ProgressBar1)
        Me.grp_FinalbillRegister.Location = New System.Drawing.Point(8, 85)
        Me.grp_FinalbillRegister.Name = "grp_FinalbillRegister"
        Me.grp_FinalbillRegister.Size = New System.Drawing.Size(496, 80)
        Me.grp_FinalbillRegister.TabIndex = 24
        Me.grp_FinalbillRegister.TabStop = False
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
        'frmSelectiveKOT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(512, 262)
        Me.Controls.Add(Me.grp_FinalbillRegister)
        Me.Controls.Add(Me.lbl_Finalbill)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectiveKOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECTIVE KOT'S REPORT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grp_FinalbillRegister.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim sqlstring As String
    Dim chkbool As Boolean

    Private Sub Cmd_FromKot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FromKot.Click
        Try
            Dim vform As New ListOperattion1
            gSQLString = "SELECT ISNULL(KOTDETAILS,'') AS KOTDETAILS,CONVERT(VARCHAR(12), KOTDATE,100),isnull(stcode,'') as stcode,isnull(servername,'') as servername FROM KOT_HDR "
            If Trim(Search) = "" Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " WHERE DOCTYPE = 'SALE'"
            End If
            vform.Field = " KOTDETAILS,KOTDATE,STCODE,SERVERNAME"
            vform.vFormatstring = "                 KOT NO                    |                      KOT DATE               |                      STCODE             |             STNAME   "
            vform.vCaption = "KOT DETAILS HELP"
            vform.KeyPos = 0
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_FromKot.Text = Trim(vform.keyfield & "")
                Call txt_FromKot_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
            gconnection.getDataSet(SQLSTRING, "USER")
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
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_ToKot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ToKot.Click
        Try
            Dim vform As New ListOperattion1
            gSQLString = "SELECT ISNULL(KOTDETAILS,'') AS KOTDETAILS,CONVERT(VARCHAR(12), KOTDATE,100),isnull(stcode,'') as stcode,isnull(sERVERname,'') as sERVERname FROM KOT_HDR "
            If Trim(Search) = "" Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " WHERE DOCTYPE = 'SALE'"
            End If
            vform.Field = " KOTDETAILS,KOTDATE,STCODE,SERVERNAME "
            vform.vFormatstring = "                 KOT NO                    |                      KOT DATE               |                      STCODE             |             STNAME   "
            vform.vCaption = "KOT DETAILS HELP"
            vform.KeyPos = 0
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_ToKot.Text = Trim(vform.keyfield & "")
                Call txt_ToKot_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            txt_FromKot.Text = ""
            txt_ToKot.Text = ""
            txt_FromKot.ReadOnly = False
            txt_ToKot.ReadOnly = False
            txt_FromKot.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            gPrint = False
            Call Validatedate()
            If chkbool = False Then Exit Sub
            grp_FinalbillRegister.Top = 85
            grp_FinalbillRegister.Left = 8
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            gPrint = True
            Call Validatedate()
            If chkbool = False Then Exit Sub
            grp_FinalbillRegister.Top = 85
            grp_FinalbillRegister.Left = 8
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
                Me.ProgressBar1.Value += 1
                Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
            Else
                Me.Timer1.Enabled = False
                Me.ProgressBar1.Value = 0
                Me.grp_FinalbillRegister.Top = 1000
                Call PrintOperation_MCC()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_FromKot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FromKot.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_FromKot.Text) = "" Then
                    Call Cmd_FromKot_Click(sender, e)
                Else
                    Call txt_FromKot_Validated(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_ToKot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ToKot.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_ToKot.Text) = "" Then
                    Call Cmd_ToKot_Click(sender, e)
                Else
                    Call txt_ToKot_Validated(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_FromKot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FromKot.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_FromKot.Enabled = True Then
                    Search = Trim(txt_FromKot.Text)
                    Call Cmd_FromKot_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_ToKot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ToKot.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_ToKot.Enabled = True Then
                    Search = Trim(txt_ToKot.Text)
                    Call Cmd_ToKot_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_FromKot_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FromKot.Validated
        Dim j, i As Integer
        Dim sqlstring As String
        Dim dt As New DataTable
        If Trim(txt_FromKot.Text) <> "" Then
            Try
                'Begin
                'sqlstring = "SELECT * FROM KOT_Hdr WHERE KOTNo='" & Trim(txt_FromKot.Text) & "' AND  DOCTYPE = 'SALES'OR KOTdetails='" & Trim(txt_FromKot.Text) & "' AND  DOCTYPE = 'SALES'"
                '04/05/2008
                sqlstring = "SELECT * FROM KOT_Hdr WHERE (KOTNo='" & Format(Val(Trim(txt_FromKot.Text)), "000000") & "' OR KOTdetails='" & Trim(txt_FromKot.Text) & "') AND DOCTYPE = 'SALE'"
                gconnection.getDataSet(sqlstring, "KOT_Hdr")
                If gdataset.Tables("KOT_Hdr").Rows.Count > 0 Then
                    txt_FromKot.Text = Trim(gdataset.Tables("KOT_Hdr").Rows(0).Item("KOTdetails") & "")
                    txt_FromKot.ReadOnly = True
                    txt_ToKot.Focus()
                Else
                    MsgBox("Sorry! No Matches Found!", MsgBoxStyle.OKOnly, "Info!")
                End If
                'End
            Catch ex As Exception
                MessageBox.Show("Enter valid KOT No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub txt_ToKot_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ToKot.Validated
        Dim j, i As Integer
        Dim sqlstring As String
        Dim dt As New DataTable
        If Trim(txt_ToKot.Text) <> "" Then
            Try
                'Begin
                'sqlstring = "SELECT * FROM Kot_Hdr WHERE KOTNo='" & Trim(txt_FromKot.Text) & "' AND  DOCTYPE = 'SALE' OR KOTdetails='" & Trim(txt_FromKot.Text) & "' AND  DOCTYPE = 'SALE'"
                sqlstring = "SELECT * FROM Kot_Hdr WHERE (KOTNo='" & Format(Val(Trim(txt_ToKot.Text)), "000000") & "' OR KOTdetails='" & Trim(txt_ToKot.Text) & "') AND  DOCTYPE = 'SALE'"
                gconnection.getDataSet(sqlstring, "KOT_Hdr")
                If gdataset.Tables("KOT_Hdr").Rows.Count > 0 Then
                    txt_ToKot.Text = Trim(gdataset.Tables("KOT_Hdr").Rows(0).Item("KOTDETAILS") & "")
                    txt_ToKot.ReadOnly = True
                    CmdView.Focus()
                Else
                    MsgBox("Sorry! No Matches Found!", MsgBoxStyle.OKOnly, "Info!")
                End If
                'End
            Catch ex As Exception
                MessageBox.Show("Enter valid KOT No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub frmSelectiveKOT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txt_FromKot.Text = ""
            txt_ToKot.Text = ""
            txt_FromKot.ReadOnly = False
            txt_ToKot.ReadOnly = False
            txt_FromKot.Focus()
            grp_FinalbillRegister.Top = 1000
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub Validatedate()
        Try
            chkbool = False
            If Trim(txt_FromKot.Text) = "" Then
                MessageBox.Show("From KOT No Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_FromKot.Text = ""
                txt_FromKot.Focus()
                Exit Sub
            End If
            If Trim(txt_ToKot.Text) = "" Then
                MessageBox.Show("To KOT No Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_ToKot.Text = ""
                txt_ToKot.Focus()
                Exit Sub
            End If
            chkbool = True
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub PrintOperation_MCC()
        Try
            Dim rowj, Loopindex, i, in1, CountItem, Fo As Integer
            Dim ssqlstring, vCaption, vPath, str, serverdetail, Fsize() As String
            Dim Forder(), vFilepath, vOutfile, vheader, vline, sqlstring, GROUPcode, KOTNO, REMARKS As String
            Dim Filewrite As StreamWriter
            Dim vpagenumber, Vrowcount, innercount As Long
            Dim addUser As String
            gCompanyname = MyCompanyName
            Gheader = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(3) & "K O T" & Chr(20) & Chr(27) & Chr(72) & Chr(18)
            vpagenumber = 1
            Call Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"

            sqlstring = "SELECT ISNULL(D.KOTDETAILS,'') AS KOTDETAILS,ISNULL(D.KOTDATE,GETDATE()) AS KOTDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE,isnull(h.roomno,'') as roomno,isnull(h.guest,'') as guest,ISNULL(paymenttype,'') as paymenttype,"
            sqlstring = sqlstring & " ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(D.POSCODE,'') AS POSCODE,ISNULL(D.GROUPCODE,'') AS GROUPCODE,ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,"
            sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.SERVERCODE,'') AS SERVERCODE,"
            sqlstring = sqlstring & " ISNULL(H.SERVERNAME,'') AS SERVERNAME,ISNULL(H.REMARKS,'') AS REMARKS, ISNULL(D.KOTSTATUS,'') AS KOTSTATUS, ISNULL(H.DELFLAG,'') AS DELFLAG,H.ADDUSERID AS USERID FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS WHERE H.KOTDETAILS between '" & Trim(Me.txt_FromKot.Text) & "' and '" & Trim(Me.txt_ToKot.Text) & "' ORDER BY KOTDETAILS,GROUPCODE"

            gconnection.getDataSet(sqlstring, "KOTHDR")
            If gdataset.Tables("KOTHDR").Rows.Count > 0 Then
                Filewrite = File.AppendText(vFilepath)
                vline = ""
                GROUPcode = gdataset.Tables("KOTHDR").Rows(0).Item("GROUPcode")
                addUser = gdataset.Tables("KOTHDR").Rows(0).Item("USERID")
                KOTNO = gdataset.Tables("KOTHDR").Rows(0).Item("KOTDETAILS")

                For rowj = 0 To gdataset.Tables("KOTHDR").Rows.Count - 1
                    CountItem = CountItem + 1
                    With gdataset.Tables("KOTHDR").Rows(rowj)
                        If GROUPcode <> .Item("GROUPCODE") Then
                            For i = 1 To 12 - innercount
                                Filewrite.WriteLine()
                            Next i
                            innercount = 0
                            Filewrite.WriteLine(StrDup(50, "-"))
                            Filewrite.WriteLine("{0,-6}{1,-10}{2,29}", "USER :", addUser, gCompanyname)
                            Filewrite.WriteLine("{0,-9}{1,-36}", "REMARKS :", Trim(Mid(.Item("REMARKS"), 1, 36)))

                            GROUPcode = .Item("GROUPCODE")

                            CountItem = 1
                            For i = 1 To 15
                                Filewrite.WriteLine("")
                            Next
                            Filewrite.WriteLine("")
                            vheader = Gheader
                            Filewrite.WriteLine(vheader)
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine("{0,-9}{1,-21}", "BILL :", Mid(Chr(14) & Chr(15) & Trim(.Item("KOTDETAILS")), 1, 21))
                            If Trim(UCase(.Item("paymenttype"))) = "ROOM" Then
                                Filewrite.WriteLine("{0,-9}{1,-21}", "ROOM NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("ROOMNO")) & "[ " & Trim(.Item("GUEST")) & " ]", 1, 21))
                            ElseIf Trim(UCase(.Item("paymenttype"))) = "R.MEMBER" Then
                                Filewrite.WriteLine("{0,-9}{1,-21}", "MEMB NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("PAYMENTTYPE")) & "[ " & Trim(.Item("PAYMENTTYPE")) & " ]", 1, 21))
                            Else
                                Filewrite.WriteLine("{0,-9}{1,-21}", "MEMB NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("MCODE")) & "[ " & Trim(.Item("MNAME")) & " ]", 1, 21))
                            End If
                            Filewrite.WriteLine("{0,-9}{1,-21}", "SERVER  :", Mid(Chr(14) & Chr(15) & Trim(.Item("SERVERCODE")) & " [ " & Trim(.Item("SERVERNAME")) & " ]", 1, 21))
                            Filewrite.WriteLine("{0,-9}{1,-11}{2,-6}{3,13}", "DATE    :", Format(.Item("KOTDATE"), "dd-MMM-yyyy"), "      TIME:", Format(.Item("KOTDATE"), "HH:MM"))
                            Filewrite.WriteLine(StrDup(50, "-"))
                            Filewrite.WriteLine("{0,-4}{1,-38}{2,-4}{3,4}", Chr(18) & Chr(15) & "SNO", "ITEM DESCRIPTION", "QTY", "UOM")
                            Filewrite.WriteLine(StrDup(50, "-"))
                            Filewrite.WriteLine("{0,-10}{1,-20}", "LOCATION:", Chr(14) & Chr(15) & gconnection.getvalue("SELECT SUBSTRING(ISNULL(GROUPDESC,''),1,20) AS GROUPDESC FROM GROUPMASTER WHERE GROUPCODE='" & GROUPcode & "'"))
                            Filewrite.WriteLine(StrDup(20, "-"))
                            Vrowcount = 18
                        End If


                        If KOTNO <> .Item("kotdetails") Then
                            For i = 1 To 12 - innercount
                                Filewrite.WriteLine()
                            Next i
                            innercount = 0
                            Filewrite.WriteLine(StrDup(50, "-"))
                            Filewrite.WriteLine("{0,-6}{1,-10}{2,29}", "USER :", addUser, gCompanyname)
                            Filewrite.WriteLine("{0,-9}{1,-36}", "REMARKS :", Trim(Mid(.Item("REMARKS"), 1, 36)))

                            KOTNO = .Item("KOTDETAILS")
                            REMARKS = .Item("REMARKS")


                            CountItem = 1
                            For i = 1 To 15
                                Filewrite.WriteLine("")
                            Next
                            Filewrite.WriteLine("")
                            vheader = Gheader
                            Filewrite.WriteLine(vheader)
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine("{0,-9}{1,-21}", "BILL :", Mid(Chr(14) & Chr(15) & Trim(.Item("KOTDETAILS")), 1, 21))
                            If Trim(UCase(.Item("paymenttype"))) = "ROOM" Then
                                Filewrite.WriteLine("{0,-9}{1,-21}", "ROOM NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("ROOMNO")) & "[ " & Trim(.Item("GUEST")) & " ]", 1, 21))
                            ElseIf Trim(UCase(.Item("paymenttype"))) = "R.MEMBER" Then
                                Filewrite.WriteLine("{0,-9}{1,-21}", "MEMB NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("PAYMENTTYPE")) & "[ " & Trim(.Item("PAYMENTTYPE")) & " ]", 1, 21))
                            Else
                                Filewrite.WriteLine("{0,-9}{1,-21}", "MEMB NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("MCODE")) & "[ " & Trim(.Item("MNAME")) & " ]", 1, 21))
                            End If
                            Filewrite.WriteLine("{0,-9}{1,-21}", "SERVER  :", Mid(Chr(14) & Chr(15) & Trim(.Item("SERVERCODE")) & " [ " & Trim(.Item("SERVERNAME")) & " ]", 1, 21))
                            Filewrite.WriteLine("{0,-9}{1,-11}{2,-6}{3,13}", "DATE    :", Format(.Item("KOTDATE"), "dd-MMM-yyyy"), "      TIME:", Format(.Item("KOTDATE"), "HH:MM"))
                            Filewrite.WriteLine(StrDup(50, "-"))
                            Filewrite.WriteLine("{0,-4}{1,-38}{2,-4}{3,4}", Chr(18) & Chr(15) & "SNO", "ITEM DESCRIPTION", "QTY", "UOM")
                            Filewrite.WriteLine(StrDup(50, "-"))
                            Filewrite.WriteLine("{0,-10}{1,-20}", "LOCATION:", Chr(14) & Chr(15) & gconnection.getvalue("SELECT SUBSTRING(ISNULL(GROUPDESC,''),1,20) AS GROUPDESC FROM GROUPMASTER WHERE GROUPCODE='" & GROUPcode & "'"))
                            Filewrite.WriteLine(StrDup(20, "-"))
                            Vrowcount = 18
                        End If

                    End With
                    With gdataset.Tables("KOTHDR").Rows(0)
                        If Vrowcount = 0 Then
                            Filewrite.WriteLine("")
                            vheader = Gheader
                            Filewrite.WriteLine(vheader)
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine("{0,-9}{1,-21}", "BILL :", Mid(Chr(14) & Chr(15) & Trim(.Item("KOTDETAILS")), 1, 21))
                            If Trim(UCase(.Item("paymenttype"))) = "ROOM" Then
                                Filewrite.WriteLine("{0,-9}{1,-21}", "ROOM NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("ROOMNO")) & "[ " & Trim(.Item("GUEST")) & " ]", 1, 21))
                            ElseIf Trim(UCase(.Item("paymenttype"))) = "R.MEMBER" Then
                                Filewrite.WriteLine("{0,-9}{1,-21}", "MEMB NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("PAYMENTTYPE")) & "[ " & Trim(.Item("PAYMENTTYPE")) & " ]", 1, 21))
                            Else
                                Filewrite.WriteLine("{0,-9}{1,-21}", "MEMB NO :", Mid(Chr(14) & Chr(15) & Trim(.Item("MCODE")) & "[ " & Trim(.Item("MNAME")) & " ]", 1, 21))
                            End If
                            Filewrite.WriteLine("{0,-9}{1,-21}", "SERVER  :", Mid(Chr(14) & Chr(15) & Trim(.Item("SERVERCODE")) & " [ " & Trim(.Item("SERVERNAME")) & " ]", 1, 21))
                            Filewrite.WriteLine("{0,-9}{1,-11}{2,-6}{3,13}", "DATE    :", Format(.Item("KOTDATE"), "dd-MMM-yyyy"), "      TIME:", Format(.Item("KOTDATE"), "HH:MM"))
                            Filewrite.WriteLine(StrDup(50, "-"))
                            Filewrite.WriteLine("{0,-4}{1,-38}{2,-4}{3,4}", Chr(18) & Chr(15) & "SNO", "ITEM DESCRIPTION", "QTY", "UOM")

                            'Filewrite.WriteLine("{0,-5}{2,-20}{3,-4}{4,-4}", "SNO", "ITEM DESCRIPTION", "QTY", "UOM")
                            Filewrite.WriteLine(StrDup(50, "-"))
                            Filewrite.WriteLine("{0,-10}{1,-20}", "LOCATION:", Chr(14) & Chr(15) & gconnection.getvalue("SELECT SUBSTRING(ISNULL(GROUPDESC,''),1,20) AS GROUPDESC FROM GROUPMASTER WHERE GROUPCODE='" & GROUPcode & "'"))
                            Filewrite.WriteLine(StrDup(20, "-"))
                            Vrowcount = 18
                        End If
                    End With
                    With gdataset.Tables("KOTHDR").Rows(rowj)

                        Filewrite.WriteLine("{0,-4}{1,-38}{2,-4}{3,-4}", Mid(CountItem, 1, 3) & ".", Mid(Trim(.Item("ITEMDESC") & "...................."), 1, 37) & " ", Mid(Trim(.Item("QTY")), 1, 3), Mid(Trim(.Item("UOM")), 1, 4))  ', IIf(.Item("KOTSTATUS") = "Y", Chr(18) & Chr(27) + "E" & "Cancel" & Chr(27) + "F" & Chr(15), "      " & Chr(18) & Chr(15)))
                        innercount = innercount + 1
                        Vrowcount = Vrowcount + 1
                    End With
                    If Vrowcount > 32 Then
                        Filewrite.WriteLine(StrDup(50, "-"))
                        Filewrite.WriteLine(Space(15) & "Continued....")
                        Filewrite.WriteLine("{0,-6}{1,-10}{2,36}", "USER :", addUser, gCompanyname)
                        For i = 1 To 15
                            Filewrite.WriteLine("")
                        Next
                        CountItem = 1
                        Vrowcount = 0
                        vpagenumber = Val(vpagenumber) + 1
                    End If
                Next rowj
                For i = 1 To 12 - innercount
                    Filewrite.WriteLine()
                Next i
                innercount = 0
                Filewrite.WriteLine(StrDup(50, "-"))
                Filewrite.WriteLine("{0,-6}{1,-10}{2,29}", "USER :", addUser, gCompanyname)
                Filewrite.WriteLine("{0,-9}{1,-36}", "REMARKS :", Trim(Mid(REMARKS, 1, 36)))
                For i = 1 To 15
                    Filewrite.WriteLine("")
                Next
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(vFilepath)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Public Sub PrintOperation()
        Try
            Dim rowj, Loopindex, i, in1, CountItem, Fo As Integer
            Dim ssqlstring, vCaption, vPath, str, serverdetail, Fsize() As String
            Dim Forder(), vFilepath, vOutfile, vheader, vline, sqlstring, poscode As String
            Dim USERNAME, REMARKS, KOTNO As String
            Dim Filewrite As StreamWriter
            Dim vpagenumber, Vrowcount, innercount As Long
            Dim addUser As String
            gCompanyname = MyCompanyName
            Gheader = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Space(2) & "KITCHEN ORDER TICKET" & Chr(20) & Chr(27) & Chr(72) & Chr(18)
            'Gheader = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & "KITCHEN ORDER TICKET"
            vpagenumber = 1
            '''************************************* Create .TXT file and write text *****************************'''
            Call Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
            '''**************************************** Select data from KOTDETAILS ******************************'''
            sqlstring = "SELECT ISNULL(D.KOTDETAILS,'') AS KOTDETAILS,ISNULL(D.KOTDATE,GETDATE()) AS KOTDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE,"
            sqlstring = sqlstring & " ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(D.POSCODE,'') AS POSCODE,ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,"
            sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.SERVERCODE,'') AS SERVERCODE,"
            sqlstring = sqlstring & " ISNULL(H.SERVERNAME,'') AS SERVERNAME,ISNULL(H.REMARKS,'') AS REMARKS, ISNULL(D.KOTSTATUS,'') AS KOTSTATUS, ISNULL(H.DELFLAG,'') AS DELFLAG,H.ADDUSERID AS USERID FROM KOT_DET AS D INNER JOIN KOT_HDR AS H ON D.KOTDETAILS = H.KOTDETAILS WHERE H.KOTDETAILS BETWEEN  '" & Trim(Me.txt_FromKot.Text) & "' "
            sqlstring = sqlstring & " AND  '" & Trim(Me.txt_ToKot.Text) & "' AND DOCTYPE = 'SALE' ORDER BY D.KOTDETAILS,D.POSCODE"
            gconnection.getDataSet(sqlstring, "KOTHDR")
            If gdataset.Tables("KOTHDR").Rows.Count > 0 Then
                Filewrite = File.AppendText(vFilepath)
                vline = ""
                poscode = gdataset.Tables("KOTHDR").Rows(0).Item("Poscode")
                addUser = gdataset.Tables("KOTHDR").Rows(0).Item("USERID")
                KOTNO = gdataset.Tables("KOTHDR").Rows(0).Item("KOTDETAILS")
                USERNAME = gdataset.Tables("KOTHDR").Rows(0).Item("USERID")
                REMARKS = gdataset.Tables("KOTHDR").Rows(0).Item("REMARKS")

                For rowj = 0 To gdataset.Tables("KOTHDR").Rows.Count - 1
                    CountItem = CountItem + 1
                    With gdataset.Tables("KOTHDR").Rows(rowj)
                        If poscode <> .Item("POSCODE") Then
                            For i = 1 To 12 - innercount
                                Filewrite.WriteLine()
                            Next i
                            innercount = 0
                            Filewrite.WriteLine(StrDup(79, "-"))
                            Filewrite.WriteLine("{0,-14}{1,-20}{2,25}", "PREPARED BY :", addUser, gCompanyname)
                            Filewrite.WriteLine("{0,-11}{1,-50}", "REMARKS  : ", Trim(.Item("REMARKS")))
                            poscode = .Item("POSCODE")
                            CountItem = 1
                            For i = 1 To 15
                                Filewrite.WriteLine("")
                            Next
                            Filewrite.WriteLine("")
                            vheader = Gheader
                            Filewrite.WriteLine(vheader)
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine("{0,-12}{1,-40}", "BILL     :", Mid(Chr(14) & Chr(15) & Trim(.Item("KOTDETAILS")), 1, 40))
                            Filewrite.WriteLine("{0,-12}{1,-40}", "MEMB NO  :", Mid(Chr(14) & Chr(15) & Trim(.Item("MCODE")) & "[ " & Trim(.Item("MNAME")) & " ]", 1, 40))
                            Filewrite.WriteLine("{0,-12}{1,-40}", "SERVER   :", Mid(Chr(14) & Chr(15) & Trim(.Item("SERVERCODE")) & " [ " & Trim(.Item("SERVERNAME")) & " ]", 1, 40))
                            Filewrite.WriteLine("{0,-12}{1,-25}{2,-35}{3,5}", "DATE     :", Mid(Trim(Format(.Item("kotdate"), "dd-MMM-yyyy")), 1, 15), "                         TIME     :", Mid(Trim(Format(.Item("kotdate"), "HH:MM")), 1, 5))
                            Filewrite.WriteLine(StrDup(79, "-"))
                            Filewrite.WriteLine("{0,-6}{1,-6}{2,-41}{3,-10}{4,-10}", Chr(18) & Chr(15) & "SLNO", "CODE", "ITEM DESCRIPTION", "QUANTITY", "UNIT")
                            Filewrite.WriteLine(StrDup(79, "-"))
                            Filewrite.WriteLine("{0,-12}{1,-40}", "LOCATION :", Chr(14) & Chr(15) & gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & poscode & "'"))
                            Filewrite.WriteLine(StrDup(20, "-"))
                            Vrowcount = 18
                            poscode = gdataset.Tables("KOTHDR").Rows(rowj).Item("Poscode")
                            addUser = gdataset.Tables("KOTHDR").Rows(rowj).Item("USERID")
                            KOTNO = gdataset.Tables("KOTHDR").Rows(rowj).Item("KOTDETAILS")
                            USERNAME = gdataset.Tables("KOTHDR").Rows(rowj).Item("USERID")
                            REMARKS = gdataset.Tables("KOTHDR").Rows(rowj).Item("REMARKS")
                        End If
                        If KOTNO <> .Item("KOTDETAILS") Then
                            For i = 1 To 12 - innercount
                                Filewrite.WriteLine()
                            Next i
                            innercount = 0
                            Filewrite.WriteLine(StrDup(79, "-"))
                            Filewrite.WriteLine("{0,-14}{1,-20}{2,25}", "PREPARED BY :", addUser, gCompanyname)
                            Filewrite.WriteLine("{0,-11}{1,-50}", "REMARKS  : ", Trim(.Item("REMARKS")))
                            poscode = .Item("POSCODE")
                            CountItem = 1
                            For i = 1 To 15
                                Filewrite.WriteLine("")
                            Next
                            Filewrite.WriteLine("")
                            vheader = Gheader
                            Filewrite.WriteLine(vheader)
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine("{0,-12}{1,-40}", "BILL     :", Mid(Chr(14) & Chr(15) & Trim(.Item("KOTDETAILS")), 1, 40))
                            Filewrite.WriteLine("{0,-12}{1,-40}", "MEMB NO  :", Mid(Chr(14) & Chr(15) & Trim(.Item("MCODE")) & "[ " & Trim(.Item("MNAME")) & " ]", 1, 40))
                            Filewrite.WriteLine("{0,-12}{1,-40}", "SERVER   :", Mid(Chr(14) & Chr(15) & Trim(.Item("SERVERCODE")) & " [ " & Trim(.Item("SERVERNAME")) & " ]", 1, 40))
                            Filewrite.WriteLine("{0,-12}{1,-25}{2,-35}{3,5}", "DATE     :", Mid(Trim(Format(.Item("kotdate"), "dd-MMM-yyyy")), 1, 15), "                         TIME     :", Mid(Trim(Format(.Item("kotdate"), "HH:MM")), 1, 5))
                            Filewrite.WriteLine(StrDup(79, "-"))
                            Filewrite.WriteLine("{0,-6}{1,-6}{2,-41}{3,-10}{4,-10}", Chr(18) & Chr(15) & "SLNO", "CODE", "ITEM DESCRIPTION", "QUANTITY", "UNIT")
                            Filewrite.WriteLine(StrDup(79, "-"))
                            Filewrite.WriteLine("{0,-12}{1,-40}", "LOCATION :", Chr(14) & Chr(15) & gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & poscode & "'"))
                            Filewrite.WriteLine(StrDup(20, "-"))
                            Vrowcount = 18
                            poscode = gdataset.Tables("KOTHDR").Rows(rowj).Item("Poscode")
                            addUser = gdataset.Tables("KOTHDR").Rows(rowj).Item("USERID")
                            KOTNO = gdataset.Tables("KOTHDR").Rows(rowj).Item("KOTDETAILS")
                            USERNAME = gdataset.Tables("KOTHDR").Rows(rowj).Item("USERID")
                            REMARKS = gdataset.Tables("KOTHDR").Rows(rowj).Item("REMARKS")
                        End If
                    End With

                    With gdataset.Tables("KOTHDR").Rows(rowj)
                        If Vrowcount = 0 Then
                            Filewrite.WriteLine("")
                            vheader = Gheader
                            Filewrite.WriteLine(vheader)
                            If gdataset.Tables("KOTHDR").Rows(0).Item("DELFLAG") = "Y" Then
                                Filewrite.WriteLine(Space(10) & Chr(27) + "E" & "D E L E T E D  V O U C H E R" & Chr(27) + "F")
                            Else
                                Filewrite.WriteLine("")
                            End If
                            Filewrite.WriteLine("{0,-12}{1,-40}", "BILL     :", Mid(Chr(14) & Chr(15) & Trim(.Item("KOTDETAILS")), 1, 40))
                            Filewrite.WriteLine("{0,-12}{1,-40}", "MEMB NO  :", Mid(Chr(14) & Chr(15) & Trim(.Item("MCODE")) & "[ " & Trim(.Item("MNAME")) & " ]", 1, 40))
                            Filewrite.WriteLine("{0,-12}{1,-40}", "SERVER   :", Mid(Chr(14) & Chr(15) & Trim(.Item("SERVERCODE")) & " [ " & Trim(.Item("SERVERNAME")) & " ]", 1, 40))
                            Filewrite.WriteLine("{0,-12}{1,-25}{2,-35}{3,5}", "DATE     :", Mid(Trim(Format(.Item("kotdate"), "dd-MMM-yyyy")), 1, 15), "                         TIME     :", Mid(Trim(Format(.Item("kotdate"), "HH:MM")), 1, 5))
                            'Filewrite.WriteLine("{0,-12}{1,-40}", "TIME     :", Mid(Trim(txt_KOTTime.Text), 1, 40))
                            Filewrite.WriteLine(StrDup(79, "-"))
                            Filewrite.WriteLine("{0,-6}{1,-6}{2,-41}{3,-10}{4,-10}", Chr(18) & Chr(15) & "SLNO", "CODE", "ITEM DESCRIPTION", "QUANTITY", "UNIT")
                            Filewrite.WriteLine(StrDup(79, "-"))
                            Filewrite.WriteLine("{0,-12}{1,-40}", "LOCATION :", Chr(14) & Chr(15) & gconnection.getvalue("SELECT ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE POSCODE='" & poscode & "'"))
                            Filewrite.WriteLine(StrDup(20, "-"))
                            Vrowcount = 18
                        End If
                    End With
                    With gdataset.Tables("KOTHDR").Rows(rowj)
                        Filewrite.WriteLine("{0,-6}{1,-6}{2,-41}{3,-10}{4,-10}{5,-6}", Mid(CountItem, 1, 5) & ".", Mid(Trim(.Item("ITEMCODE")), 1, 6), Mid(Trim(.Item("ITEMDESC") & "........................................"), 1, 40) & " ", Mid(Trim(.Item("QTY")), 1, 8), Mid(Trim(.Item("UOM")), 1, 8), IIf(.Item("KOTSTATUS") = "Y", Chr(18) & Chr(27) + "E" & "Cancel" & Chr(27) + "F" & Chr(15), "      " & Chr(18) & Chr(15)))
                        innercount = innercount + 1
                        Vrowcount = Vrowcount + 1
                    End With
                    If Vrowcount > 32 Then
                        Filewrite.WriteLine(StrDup(79, "-"))
                        Filewrite.WriteLine(Space(55) & "Continued....")
                        Filewrite.WriteLine("{0,-14}{1,-20}{2,25}", "PREPARED BY :", addUser, gCompanyname)
                        For i = 1 To 15
                            Filewrite.WriteLine("")
                        Next
                        CountItem = 1
                        Vrowcount = 0
                        vpagenumber = Val(vpagenumber) + 1
                    End If
                Next rowj
                For i = 1 To 12 - innercount
                    Filewrite.WriteLine()
                Next i
                innercount = 0
                Filewrite.WriteLine(StrDup(79, "-"))
                Filewrite.WriteLine("{0,-14}{1,-20}{2,25}", "PREPARED BY :", addUser, gCompanyname)
                Filewrite.WriteLine("{0,-11}{1,-50}", "REMARKS  : ", Trim(REMARKS))
                For i = 1 To 15
                    Filewrite.WriteLine("")
                Next
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(vFilepath)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub PrintOperationold()
        Randomize()
        Dim ds As New DataSet
        Dim Filewrite As StreamWriter
        Dim vCaption, vPath, Fsize(), Forder(), vFilepath, vOutfile, vheader, vline As String
        Dim vpagenumber, Vrowcount, innercount As Long
        Dim Loopindex, i, rowj, Fo, in1, CountItem As Integer
        Dim ssqlstring, str, serverdetail, sqlstring, POSCODE, USERNAME, REMARKS, KOTNO As String
        Try
            gCompanyname = MyCompanyName
            Gheader = "KITCHEN ORDER TICKET"
            vpagenumber = 1
            '''************************************* Create .TXT file and write text *****************************'''
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
            '''**************************************** Select data from KOTDETAILS ******************************'''
            sqlstring = " SELECT ISNULL(H.KOTDETAILS,'') AS KOTDETAILS,ISNULL(H.KOTDATE,'') AS KOTDATE,ISNULL(H.DOCTYPE,'') AS DOCTYPE,"
            sqlstring = sqlstring & " ISNULL(H.SLCODE,'') AS SLCODE,ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.STCODE,'') AS STCODE, "
            sqlstring = sqlstring & " ISNULL(H.SERVERNAME,'') AS SERVERNAME,ISNULL(H.REMARKS,'') AS REMARKS, ISNULL(D.ITEMCODE,'') AS ITEMCODE, "
            sqlstring = sqlstring & " ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(D.ITEMTYPE,'') AS ITEMTYPE,ISNULL(D.POSCODE,'') AS POSCODE,"
            sqlstring = sqlstring & " ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,ISNULL(D.AMOUNT,0) AS AMOUNT,"
            sqlstring = sqlstring & " ISNULL(H.ADDUSERID,'') AS ADDUSERID,ISNULL(H.ADDDATETIME,GETDATE()) AS ADDDATETIME"
            sqlstring = sqlstring & " FROM KOT_HDR AS H INNER JOIN KOT_DET AS D ON H.KOTDETAILS = D.KOTDETAILS"
            sqlstring = sqlstring & " WHERE H.KOTDETAILS BETWEEN  '" & Trim(Me.txt_FromKot.Text) & "' "
            sqlstring = sqlstring & " AND  '" & Trim(Me.txt_ToKot.Text) & "' AND DOCTYPE = 'SALE'"
            'End
            sqlstring = sqlstring & " ORDER BY KOTDETAILS,POSCODE,ITEMTYPE"
            gconnection.getDataSet(sqlstring, "KOTDETAILSREGISTER")
            If gdataset.Tables("KOTDETAILSREGISTER").Rows.Count > 0 Then
                Filewrite = File.AppendText(vFilepath)
                vline = ""
                POSCODE = gdataset.Tables("KOTDETAILSREGISTER").Rows(0).Item("POSCODE")
                KOTNO = gdataset.Tables("KOTDETAILSREGISTER").Rows(0).Item("KOTDETAILS")
                USERNAME = gdataset.Tables("KOTDETAILSREGISTER").Rows(0).Item("ADDUSERID")
                REMARKS = gdataset.Tables("KOTDETAILSREGISTER").Rows(0).Item("REMARKS")
                For rowj = 0 To gdataset.Tables("KOTDETAILSREGISTER").Rows.Count - 1
                    CountItem = CountItem + 1
                    If KOTNO <> gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("KOTDETAILS") Then
                        For i = 1 To 12 - innercount
                            Filewrite.WriteLine()
                        Next i
                        innercount = 0
                        Filewrite.WriteLine(StrDup(60, "-"))
                        Filewrite.Write("{0,-14}{1,-12}", "PREPARED BY :", CStr(USERNAME))
                        Filewrite.WriteLine("{0,8}{1,-14}", "FROM :", gCompanyname)
                        Filewrite.WriteLine("{0,-11}{1,-40}", "REMARKS  :", CStr(REMARKS))
                        Vrowcount = 0
                        CountItem = 1
                        Filewrite.WriteLine(Chr(12))
                        KOTNO = gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("KOTDETAILS")
                        POSCODE = gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("POSCODE")
                    ElseIf POSCODE <> gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("POSCODE") Then
                        For i = 1 To 12 - innercount
                            Filewrite.WriteLine()
                        Next i
                        innercount = 0
                        Filewrite.WriteLine(StrDup(60, "-"))
                        Filewrite.Write("{0,-14}{1,-12}", "PREPARED BY :", CStr(USERNAME))
                        Filewrite.WriteLine("{0,8}{1,-14}", "FROM :", gCompanyname)
                        Filewrite.WriteLine("{0,-11}{1,-40}", "REMARKS  :", CStr(REMARKS))
                        POSCODE = gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("POSCODE")
                        Vrowcount = 0
                        CountItem = 1
                        Filewrite.WriteLine(Chr(12))
                    End If

                    If Vrowcount = 0 Then
                        Filewrite.WriteLine("")
                        vheader = Chr(14) & Chr(15) & Gheader
                        Filewrite.WriteLine(vheader)
                        Filewrite.WriteLine("{0,-12}{1,-20}", "BILL     :", "" & Chr(14) & Chr(15) & Mid(gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("KOTDETAILS"), 1, 20))
                        Filewrite.WriteLine("{0,-12}{1,-20}", "MEMB NO  :", "" & Chr(14) & Chr(15) & Mid(gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("MCODE"), 1, 15))
                        Filewrite.WriteLine("{0,-12}{1,-20}", "SERVER   :", "" & Chr(14) & Chr(15) & gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("STCODE") & " " & "(" & gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("SERVERNAME") & ")")
                        Filewrite.WriteLine("{0,-12}{1,-20}", "DATE     :", Format(CDate(gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("ADDDATETIME")), "dd/MMM/yyyy"))
                        Filewrite.WriteLine("{0,-12}{1,-20}", "TIME     :", Format(CDate(gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj).Item("ADDDATETIME")), "HH:mm:ss"))
                        Filewrite.WriteLine(StrDup(60, "-"))
                        Filewrite.WriteLine("{0,-5}{1,-6}{2,-28}{3,-10}{4,-10}", "SLNO", "CODE", "ITEM DESCRIPTION", "QUANTITY", "UNIT" & Chr(18) & Chr(15))
                        Filewrite.WriteLine(StrDup(60, "-"))
                        Filewrite.WriteLine("{0,-12}{1,-25}", "LOCATION  :", "" & Chr(14) & Chr(15) & gconnection.getvalue("SELECT POSDESC FROM POSMASTER WHERE POSCODE='" & Trim(POSCODE) & "'"))
                        Filewrite.WriteLine(StrDup(30, "-"))
                        Vrowcount = 18
                    End If
                    With gdataset.Tables("KOTDETAILSREGISTER").Rows(rowj)
                        Filewrite.WriteLine("{0,-5}{1,-6}{2,-28}{3,-10}{4,-10}", Mid(CountItem, 1, 5) & ".", Mid(Trim(.Item("ITEMCODE")), 1, 6), Mid(Trim(.Item("ITEMDESC") & "........................."), 1, 25), Mid(Trim(.Item("QTY")), 1, 8), Mid(Trim(.Item("UOM")), 1, 8) & Chr(18) & Chr(15))
                        innercount = innercount + 1
                        Vrowcount = Vrowcount + 1
                    End With
                    If Vrowcount > 32 Then
                        Filewrite.WriteLine(Chr(12))
                        Vrowcount = 0
                        vpagenumber = Val(vpagenumber) + 1
                    End If
                Next rowj
                For i = 1 To 12 - innercount
                    Filewrite.WriteLine()
                Next i
                innercount = 0
                Filewrite.WriteLine(StrDup(60, "-"))
                Filewrite.Write("{0,-14}{1,-12}", "PREPARED BY :", CStr(USERNAME))
                Filewrite.WriteLine("{0,8}{1,-14}", "FROM :", gCompanyname)
                Filewrite.WriteLine("{0,-11}{1,-40}", "REMARKS  :", CStr(REMARKS))
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(vFilepath)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz. Check error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub frmSelectiveKOT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F9 Then
                Call CmdView_Click(sender, e)
            End If
            If e.KeyCode = Keys.F11 Then
                Me.Close()
            End If
            If e.KeyCode = Keys.F8 Then
                Call CmdPrint_Click(sender, e)
            End If
            If e.KeyCode = Keys.F6 Then
                Call CmdClear_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
End Class