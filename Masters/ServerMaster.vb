Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class ServerMaster
    Inherits System.Windows.Forms.Form
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim vSeqNo As Double
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_SerCode As System.Windows.Forms.Label
    Friend WithEvents txtServerName As System.Windows.Forms.TextBox
    Friend WithEvents txtServerCode As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_SerName As System.Windows.Forms.Label
    Friend WithEvents cmdServerHelp As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents opt_stewart As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Waiter As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ServerMaster))
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.opt_stewart = New System.Windows.Forms.RadioButton
        Me.Opt_Waiter = New System.Windows.Forms.RadioButton
        Me.txtServerName = New System.Windows.Forms.TextBox
        Me.cmdServerHelp = New System.Windows.Forms.Button
        Me.txtServerCode = New System.Windows.Forms.TextBox
        Me.Lbl_SerName = New System.Windows.Forms.Label
        Me.Lbl_SerCode = New System.Windows.Forms.Label
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(344, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(368, 31)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "WAITER / STEWARD MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.opt_stewart)
        Me.GroupBox1.Controls.Add(Me.Opt_Waiter)
        Me.GroupBox1.Controls.Add(Me.txtServerName)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(224, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 168)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'opt_stewart
        '
        Me.opt_stewart.BackColor = System.Drawing.Color.Transparent
        Me.opt_stewart.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_stewart.Location = New System.Drawing.Point(312, 128)
        Me.opt_stewart.Name = "opt_stewart"
        Me.opt_stewart.Size = New System.Drawing.Size(104, 16)
        Me.opt_stewart.TabIndex = 9
        Me.opt_stewart.Text = "STEWART"
        '
        'Opt_Waiter
        '
        Me.Opt_Waiter.BackColor = System.Drawing.Color.Transparent
        Me.Opt_Waiter.Checked = True
        Me.Opt_Waiter.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Waiter.Location = New System.Drawing.Point(192, 128)
        Me.Opt_Waiter.Name = "Opt_Waiter"
        Me.Opt_Waiter.Size = New System.Drawing.Size(88, 16)
        Me.Opt_Waiter.TabIndex = 8
        Me.Opt_Waiter.TabStop = True
        Me.Opt_Waiter.Text = "WAITER"
        '
        'txtServerName
        '
        Me.txtServerName.BackColor = System.Drawing.Color.Wheat
        Me.txtServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtServerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerName.Location = New System.Drawing.Point(200, 88)
        Me.txtServerName.MaxLength = 50
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(232, 26)
        Me.txtServerName.TabIndex = 2
        Me.txtServerName.Text = ""
        '
        'cmdServerHelp
        '
        Me.cmdServerHelp.Image = CType(resources.GetObject("cmdServerHelp.Image"), System.Drawing.Image)
        Me.cmdServerHelp.Location = New System.Drawing.Point(512, 256)
        Me.cmdServerHelp.Name = "cmdServerHelp"
        Me.cmdServerHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdServerHelp.TabIndex = 1
        '
        'txtServerCode
        '
        Me.txtServerCode.BackColor = System.Drawing.Color.Wheat
        Me.txtServerCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtServerCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerCode.Location = New System.Drawing.Point(424, 256)
        Me.txtServerCode.MaxLength = 15
        Me.txtServerCode.Name = "txtServerCode"
        Me.txtServerCode.Size = New System.Drawing.Size(88, 26)
        Me.txtServerCode.TabIndex = 0
        Me.txtServerCode.Text = ""
        '
        'Lbl_SerName
        '
        Me.Lbl_SerName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SerName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SerName.Location = New System.Drawing.Point(360, 306)
        Me.Lbl_SerName.Name = "Lbl_SerName"
        Me.Lbl_SerName.Size = New System.Drawing.Size(62, 21)
        Me.Lbl_SerName.TabIndex = 12
        Me.Lbl_SerName.Text = "NAME "
        Me.Lbl_SerName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Lbl_SerCode
        '
        Me.Lbl_SerCode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SerCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SerCode.Location = New System.Drawing.Point(360, 261)
        Me.Lbl_SerCode.Name = "Lbl_SerCode"
        Me.Lbl_SerCode.Size = New System.Drawing.Size(59, 21)
        Me.Lbl_SerCode.TabIndex = 11
        Me.Lbl_SerCode.Text = "CODE "
        Me.Lbl_SerCode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(8, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 0
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(352, 16)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 3
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(232, 16)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 2
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(120, 16)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 1
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(464, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 4
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 56)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(432, 488)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 78
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(536, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 22)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "[F4]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 656)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 18)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'ServerMaster
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(990, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtServerCode)
        Me.Controls.Add(Me.Lbl_SerName)
        Me.Controls.Add(Me.Lbl_SerCode)
        Me.Controls.Add(Me.cmdServerHelp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "ServerMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WAITER/STEWARD MASTER "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtServerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtServerCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmdServerHelp.Enabled = True Then
                Search = Trim(txtServerCode.Text)
                Call cmdServerHelp_Click(cmdServerHelp, e)
            End If
        End If
    End Sub
    Private Sub txtServerCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServerCode.KeyPress
        '   getNumeric(e)
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If txtServerCode.Text <> "" Then
                Call txtServerCode_Validated(txtServerCode.Text, e)
                txtServerName.Focus()
            Else
                Call cmdServerHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub ServerMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F8 Then
            Call Cmd_Freeze_Click(Cmd_Freeze, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F7 Then
            Call Cmd_Add_Click(Cmd_Add, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(Cmd_View, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
            Exit Sub
        End If
    End Sub

    Private Sub txtServerCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtServerCode.Validated
        If Trim(txtServerCode.Text) <> "" Then
            vSeqNo = Getseqno(txtServerCode.Text)
            sqlstring = "SELECT * FROM ServerMaster WHERE ServerSeqNo=" & Trim(vSeqNo)
            gconnection.getDataSet(sqlstring, "ServerMaster")
            If gdataset.Tables("ServerMaster").Rows.Count > 0 Then
                txtServerName.Clear()
                txtServerName.Text = gdataset.Tables("ServerMaster").Rows(0).Item("ServerName")
                txtServerCode.ReadOnly = True
                txtServerName.Focus()
                If gdataset.Tables("ServerMaster").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("ServerMaster").Rows(0).Item("Adddatetime")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                If IsDBNull(gdataset.Tables("ServerMaster").Rows(0).Item("Codetype")) = False Then
                    If gdataset.Tables("ServerMaster").Rows(0).Item("Codetype") = "W" Then
                        Opt_Waiter.Checked = True
                    Else
                        opt_stewart.Checked = True
                    End If
                End If
                Me.Cmd_Add.Text = "Update[F7]"
                Me.txtServerCode.ReadOnly = True
                Me.cmdServerHelp.Enabled = False
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
                Me.txtServerName.Focus()
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.Cmd_Add.Text = "Add [F7]"
                txtServerCode.ReadOnly = False
                txtServerName.Focus()
        End If
        Else
        txtServerCode.Text = ""
        txtServerName.Focus()
        End If
    End Sub
    Private Sub txtServerName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServerName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtServerName.Text <> "" Then
                Cmd_Add.Focus()
            End If
        End If
    End Sub

    Private Sub cmdServerHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdServerHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(SERVERCODE,'') AS SERVERCODE, ISNULL(SERVERNAME,'') AS SERVERNAME FROM ServerMaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "SERVERCODE, SERVERNAME"
        vform.vFormatstring = "         SERVER CODE                      |                             SERVER NAME                     "
        vform.vCaption = "SERVER MASTER HELP "
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtServerCode.Text = Trim(vform.keyfield & "")
            Call txtServerCode_Validated(txtServerCode, e)
            txtServerCode.ReadOnly = True
            txtServerName.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub ServerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdServerHelp.Enabled = True
        txtServerCode.Focus()
        ServerMastbool = True
        If gUserCategory <> "S" Then
            Call GetRights()
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
        Me.Cmd_Add.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub ServerMaster_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ServerMastbool = False
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txtServerCode.ReadOnly = False
        txtServerName.ReadOnly = False
        cmdServerHelp.Enabled = True
        Cmd_Add.Text = "Add [F7]"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txtServerCode.Focus()
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            vSeqNo = GetSeqno(txtServerCode.Text)
            sqlstring = " INSERT INTO ServerMaster (ServerCode,ServerName,ServerSeqno,Codetype,Freeze,Adduser,Adddatetime)"
            sqlstring = sqlstring & " VALUES ( '" & Trim(txtServerCode.Text) & "','" & Replace(Trim(txtServerName.Text), "'", "") & "',"
            sqlstring = sqlstring & " " & Val(vSeqNo) & " ,"

            If Opt_Waiter.Checked = True Then
                sqlstring = sqlstring & "'W',"
            Else
                sqlstring = sqlstring & "'S',"
            End If
            sqlstring = sqlstring & "'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "')"
            gconnection.dataOperation(1, sqlstring, "ServerMaster")
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F7]" Then
                Call checkValidation() '''--->Check Validation
                If boolchk = False Then Exit Sub
                If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                    If Me.lbl_Freeze.Visible = True Then
                        MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        boolchk = False
                        Exit Sub
                    End If
                End If
                sqlstring = "UPDATE  ServerMaster "
                sqlstring = sqlstring & " SET ServerName='" & Replace(Trim(txtServerName.Text), "'", "") & "',"
            sqlstring = sqlstring & " Adduser='" & Trim(gUsername) & "',Adddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "',freeze='N',"
            sqlstring = sqlstring & " Codetype="
            If Opt_Waiter.Checked = True Then
                sqlstring = sqlstring & "'W'"
            Else
                sqlstring = sqlstring & "'S'"
            End If
            sqlstring = sqlstring & " WHERE ServerCode = '" & Trim(txtServerCode.Text) & "'"
            gconnection.dataOperation(2, sqlstring, "ServerMaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
            End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  ServerMaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE ServerCode = '" & Trim(txtServerCode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "ServerMaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  ServerMaster "
            sqlstring = sqlstring & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE ServerCode = '" & Trim(txtServerCode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "ServerMaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM servermaster"
        Gheader = " SERVER MASTER VIEW "
        FrReport.SsGridReport.SetText(2, 1, "SERVERCODE")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "SERVERNAME")
        FrReport.SsGridReport.SetText(3, 2, 35)

        FrReport.SsGridReport.SetText(2, 3, "Codetype")
        FrReport.SsGridReport.SetText(3, 3, 6)

        FrReport.SsGridReport.SetText(2, 4, "FREEZE")
        FrReport.SsGridReport.SetText(3, 4, 6)

        FrReport.Show()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Server Code Can't be blank *********************'''
        If Trim(txtServerCode.Text) = "" Then
            MessageBox.Show(" Server Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtServerCode.Focus()
            Exit Sub
        End If
        '''********** Check  Server desc Can't be blank *********************'''
        If Trim(txtServerName.Text) = "" Then
            MessageBox.Show(" Server Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtServerName.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub txtServerCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServerCode.TextChanged

    End Sub
End Class
