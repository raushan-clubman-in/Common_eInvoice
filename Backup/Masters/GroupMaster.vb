'****************************************** Updated by Avinash 21/07/2006 *********************************************''
Imports System.Data.OleDb
Imports System.IO
Public Class GroupMaster
    Inherits System.Windows.Forms.Form
    Dim boolchk As Boolean
    Dim vseqno As String
    Dim sqlstring As String
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtGroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtGroupCode As System.Windows.Forms.TextBox
    Friend WithEvents cmdGroupCode As System.Windows.Forms.Button
    Friend WithEvents txtSname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GroupMaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtSname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdGroupCode = New System.Windows.Forms.Button
        Me.txtGroupDesc = New System.Windows.Forms.TextBox
        Me.txtGroupCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(224, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 168)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'txtSname
        '
        Me.txtSname.BackColor = System.Drawing.Color.White
        Me.txtSname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSname.Location = New System.Drawing.Point(512, 336)
        Me.txtSname.MaxLength = 9
        Me.txtSname.Name = "txtSname"
        Me.txtSname.Size = New System.Drawing.Size(136, 26)
        Me.txtSname.TabIndex = 2
        Me.txtSname.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(392, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "SHORT NAME "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdGroupCode
        '
        Me.cmdGroupCode.Image = CType(resources.GetObject("cmdGroupCode.Image"), System.Drawing.Image)
        Me.cmdGroupCode.Location = New System.Drawing.Point(696, 256)
        Me.cmdGroupCode.Name = "cmdGroupCode"
        Me.cmdGroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmdGroupCode.TabIndex = 11
        '
        'txtGroupDesc
        '
        Me.txtGroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txtGroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGroupDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupDesc.Location = New System.Drawing.Point(512, 296)
        Me.txtGroupDesc.MaxLength = 30
        Me.txtGroupDesc.Name = "txtGroupDesc"
        Me.txtGroupDesc.Size = New System.Drawing.Size(208, 26)
        Me.txtGroupDesc.TabIndex = 1
        Me.txtGroupDesc.Text = ""
        '
        'txtGroupCode
        '
        Me.txtGroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txtGroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGroupCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupCode.Location = New System.Drawing.Point(512, 256)
        Me.txtGroupCode.MaxLength = 4
        Me.txtGroupCode.Name = "txtGroupCode"
        Me.txtGroupCode.Size = New System.Drawing.Size(184, 26)
        Me.txtGroupCode.TabIndex = 0
        Me.txtGroupCode.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(272, 300)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "GROUP / MENU DESCRIPTION "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(333, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "GROUP / MENU CODE "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(392, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(304, 31)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "GROUP / MENU MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(16, 16)
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
        Me.Cmd_View.Location = New System.Drawing.Point(360, 16)
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
        Me.Cmd_Freeze.Location = New System.Drawing.Point(240, 16)
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
        Me.Cmd_Add.Location = New System.Drawing.Point(128, 16)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(492, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 4
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(608, 56)
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
        Me.lbl_Freeze.TabIndex = 15
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(720, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 22)
        Me.Label4.TabIndex = 12
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
        Me.Label5.TabIndex = 416
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'GroupMaster
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(958, 676)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtGroupDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGroupCode)
        Me.Controls.Add(Me.txtSname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdGroupCode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "GroupMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GROUP MASTER"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtGroupCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGroupCode.KeyPress
        'getNumeric(e)
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtGroupCode.Text) <> "" Then
                Call txtGroupCode_Validated(txtGroupCode, e)
            Else
                Call cmdGroupCode_Click(cmdGroupCode, e)
            End If
        End If
    End Sub
    Private Sub txtGroupDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGroupDesc.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If txtGroupDesc.Text <> "" Then
                txtSname.Focus()
            Else
                txtGroupDesc.Focus()
            End If
        End If
    End Sub
    Private Sub txtGroupCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGroupCode.Validated
        If Trim(txtGroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM GroupMaster WHERE GroupCode= '" & Trim(txtGroupCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "GroupMaster")
            If gdataset.Tables("GroupMaster").Rows.Count > 0 Then
                txtGroupDesc.Clear()
                txtSname.Clear()
                txtGroupDesc.Text = Trim(gdataset.Tables("GroupMaster").Rows(0).Item("Groupdesc"))
                txtSname.Text = Trim(gdataset.Tables("GroupMaster").Rows(0).Item("ShortName"))
                If gdataset.Tables("GroupMaster").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("GroupMaster").Rows(0).Item("AddDateTime")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                Me.txtGroupCode.ReadOnly = True
                Me.cmdGroupCode.Enabled = False
                Me.Cmd_Add.Text = "Update[F7]"
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
                txtGroupDesc.Focus()
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.Cmd_Add.Text = "Add [F7]"
                txtGroupCode.ReadOnly = False
                txtGroupDesc.Focus()
            End If
        Else
            txtGroupCode.Text = ""
            txtGroupDesc.Focus()
        End If
    End Sub

    Private Sub GroupMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
            Exit Sub
        End If
        'If e.KeyCode = Keys.F8 Then
        '    Call Cmd_Freeze_Click(Cmd_Freeze, e)
        '    Exit Sub
        'End If
        'If e.KeyCode = Keys.F7 Then
        '    Call Cmd_Add_Click(Cmd_Add, e)
        '    Exit Sub
        'End If
        'If e.KeyCode = Keys.F9 Then
        '    Call Cmd_View_Click(Cmd_View, e)
        '    Exit Sub
        'End If
        If e.KeyCode = Keys.F8 Then
            If Cmd_Freeze.Enabled = True Then
                Call Cmd_Freeze_Click(Cmd_Freeze, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F7 Then
            If Cmd_Add.Enabled = True Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F9 Then
            If Cmd_View.Enabled = True Then
                Call Cmd_View_Click(Cmd_View, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
            Exit Sub
        End If
    End Sub
    Private Sub GroupMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmdGroupCode.Enabled = True
        Me.txtGroupCode.ReadOnly = False
        GroupMasterbool = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txtGroupCode.Focus()
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
        Me.Cmd_View.Enabled = False
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
                If Right(x) = "S" Then
                    Me.Cmd_Add.Enabled = True
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
    Private Sub cmdGroupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGroupCode.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(GROUPDESC,'') AS GROUPDESC FROM groupmaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "GROUPCODE,GROUPDESC"
        vform.vFormatstring = "         GROUP CODE            |             GROUP DESCRIPTION                              "
        vform.vCaption = "GROUP MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtGroupCode.Text = Trim(vform.keyfield & "")
            Call txtGroupCode_Validated(txtGroupCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txtGroupCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtGroupCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmdGroupCode.Enabled = True Then
                Search = Trim(txtGroupCode.Text)
                Call cmdGroupCode_Click(txtGroupCode, e)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtSname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSname.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Cmd_Add.Focus()
        End If
    End Sub
    Private Sub GroupMaster_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        GroupMasterbool = False
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txtGroupCode.Enabled = True
        txtGroupCode.ReadOnly = False
        txtGroupDesc.ReadOnly = False
        cmdGroupCode.Enabled = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txtGroupCode.Focus()
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim strSQL As String
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            vseqno = GetSeqno(txtGroupCode.Text)
            strSQL = " INSERT INTO groupmaster (Groupcode,Groupseqno,Groupdesc,ShortName,Freeze,AddUserId,AddDateTime)"
            strSQL = strSQL & " VALUES ( '" & Trim(txtGroupCode.Text) & "'," & Val(vseqno) & ",'" & Replace(Trim(txtGroupDesc.Text), "'", "") & "',"
            strSQL = strSQL & "'" & Replace(Trim(txtSname.Text), "'", "") & "',"
            strSQL = strSQL & "'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
            gconnection.dataOperation(1, strSQL, "groupmaster")
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
            strSQL = "UPDATE  groupmaster "
            strSQL = strSQL & " SET Groupdesc='" & Replace(Trim(txtGroupDesc.Text), "'", "") & "',"
            strSQL = strSQL & " ShortName='" & Replace(Trim(txtSname.Text), "'", "") & "',"
            strSQL = strSQL & " AddUserId='" & Trim(gUsername) & "',AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',freeze='N'"
            strSQL = strSQL & " WHERE Groupcode = '" & Trim(txtGroupCode.Text) & "'"
            gconnection.dataOperation(2, strSQL, "groupmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  groupmaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUserId='" & gUsername & " ', AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Groupcode = '" & Trim(txtGroupCode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "groupmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  groupmaster "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUserId='" & gUsername & " ', AddDateTime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Groupcode = '" & Trim(txtGroupCode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "groupmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM GROUPMASTER"
        Gheader = "GROUP MASTER"
        FrReport.SsGridReport.SetText(2, 1, "GROUPCODE")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "GROUPDESC")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "SHORTNAME")
        FrReport.SsGridReport.SetText(3, 3, 10)
        FrReport.SsGridReport.SetText(2, 4, "ADDUSERID")
        FrReport.SsGridReport.SetText(3, 4, 15)
        FrReport.SsGridReport.SetText(2, 5, "FREEZE")
        FrReport.SsGridReport.SetText(3, 5, 6)
        FrReport.Show()
    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Dim Sqlstring, Update(0) As String
        Dim i, count As Integer

        Sqlstring = "SELECT * FROM ITEMMASTER"
        gconnection.getDataSet(Sqlstring, "ITEMMASTER")
        If gdataset.Tables("ITEMMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("ITEMMASTER").Rows.Count - 1
                vseqno = ""
                vseqno = GetSeqno(Trim(gdataset.Tables("ITEMMASTER").Rows(i).Item("ITEMCODE")))
                count = count + 1
                Sqlstring = "UPDATE posmenulink SET ITEMCODESEQNO  = " & (vseqno) & " WHERE ITEMCODE = '" & Trim(gdataset.Tables("ITEMMASTER").Rows(i).Item("ITEMCODE")) & "'"
                If count = 0 Then
                    Update(0) = Sqlstring
                Else
                    ReDim Preserve Update(Update.Length)
                    Update(Update.Length - 1) = Sqlstring
                End If

                Sqlstring = "UPDATE ratemaster SET ITEMCODESEQNO  = " & (vseqno) & " WHERE ITEMCODE = '" & Trim(gdataset.Tables("ITEMMASTER").Rows(i).Item("ITEMCODE")) & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = Sqlstring

                Sqlstring = "UPDATE ITEMMASTER SET ITEMCODESEQNO  = " & (vseqno) & " WHERE ITEMCODE = '" & Trim(gdataset.Tables("ITEMMASTER").Rows(i).Item("ITEMCODE")) & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = Sqlstring
            Next
        End If

        Sqlstring = "SELECT * FROM GROUPMASTER"
        gconnection.getDataSet(Sqlstring, "GROUPMASTER")
        If gdataset.Tables("GROUPMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("GROUPMASTER").Rows.Count - 1
                vseqno = GetSeqno(Trim(gdataset.Tables("GROUPMASTER").Rows(i).Item("GROUPCODE")))
                count = count + 1
                Sqlstring = "UPDATE GROUPMASTER SET GROUPSEQNO  = " & (vseqno) & " WHERE GROUPCODE = '" & Trim(gdataset.Tables("GROUPMASTER").Rows(i).Item("GROUPCODE")) & "'"
                If count = 0 Then
                    Update(0) = Sqlstring
                Else
                    ReDim Preserve Update(Update.Length)
                    Update(Update.Length - 1) = Sqlstring
                End If

                Sqlstring = "UPDATE itemmaster SET Groupseqno = " & (vseqno) & " WHERE GROUPCODE = '" & Trim(gdataset.Tables("GROUPMASTER").Rows(i).Item("GROUPCODE")) & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = Sqlstring
            Next
        End If


        Sqlstring = "SELECT * FROM UOMMASTER"
        gconnection.getDataSet(Sqlstring, "UOMMASTER")
        If gdataset.Tables("UOMMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("UOMMASTER").Rows.Count - 1
                vseqno = GetSeqno(Trim(gdataset.Tables("UOMMASTER").Rows(i).Item("UOMCODE")))
                count = count + 1
                Sqlstring = "UPDATE UOMMASTER SET Uomseqno  = " & (vseqno) & " WHERE UOMCODE = '" & Trim(gdataset.Tables("UOMMASTER").Rows(i).Item("UOMCODE")) & "'"
                If count = 0 Then
                    Update(0) = Sqlstring
                Else
                    ReDim Preserve Update(Update.Length)
                    Update(Update.Length - 1) = Sqlstring
                End If
            Next
        End If




        Sqlstring = "SELECT * FROM POSMASTER"
        gconnection.getDataSet(Sqlstring, "POSMASTER")
        If gdataset.Tables("POSMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("POSMASTER").Rows.Count - 1
                vseqno = GetSeqno(Trim(gdataset.Tables("POSMASTER").Rows(i).Item("POSCODE")))
                count = count + 1
                Sqlstring = "UPDATE POSMASTER SET POSSEQNO  = " & (vseqno) & " WHERE POSCODE = '" & Trim(gdataset.Tables("POSMASTER").Rows(i).Item("POSCODE")) & "'"
                If count = 0 Then
                    Update(0) = Sqlstring
                Else
                    ReDim Preserve Update(Update.Length)
                    Update(Update.Length - 1) = Sqlstring
                End If

                Sqlstring = "UPDATE POSMENULINK SET POSseqno = " & (vseqno) & " WHERE POS = '" & Trim(gdataset.Tables("POSMASTER").Rows(i).Item("POSCODE")) & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = Sqlstring
            Next
        End If
        Sqlstring = "SELECT * FROM ItemTypeMASTER"
        gconnection.getDataSet(Sqlstring, "ItemTypeMASTER")
        If gdataset.Tables("ItemTypeMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("ItemTypeMASTER").Rows.Count - 1
                vseqno = GetSeqno(Trim(gdataset.Tables("ItemTypeMASTER").Rows(i).Item("ItemTypeCODE")))
                count = count + 1
                Sqlstring = "UPDATE ItemTypeMASTER SET ItemTypeSEQNO  = " & (vseqno) & " WHERE ItemTypeCODE = '" & Trim(gdataset.Tables("ItemTypeMASTER").Rows(i).Item("ItemTypeCODE")) & "'"
                If count = 0 Then
                    Update(0) = Sqlstring
                Else
                    ReDim Preserve Update(Update.Length)
                    Update(Update.Length - 1) = Sqlstring
                End If
                Sqlstring = "UPDATE itemmaster SET ItemTypeSEQNO  = " & (vseqno) & " WHERE ItemTypeCODE = '" & Trim(gdataset.Tables("ItemTypeMASTER").Rows(i).Item("ItemTypeCODE")) & "'"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = Sqlstring
            Next
        End If
        gconnection.MoreTransold(Update)

        Me.Close()
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Store Code Can't be blank *********************'''
        If Trim(txtGroupCode.Text) = "" Then
            MessageBox.Show(" Group Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGroupCode.Focus()
            Exit Sub
        End If
        '''********** Check  Store desc Can't be blank *********************'''
        If Trim(txtGroupDesc.Text) = "" Then
            MessageBox.Show(" Group Description can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGroupDesc.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub txtGroupCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroupCode.TextChanged

    End Sub
End Class