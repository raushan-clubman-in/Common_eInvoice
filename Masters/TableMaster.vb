'V Mahendra 06/08/2006
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class TableMaster
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
    Friend WithEvents Lbl_TblMst As System.Windows.Forms.Label
    Friend WithEvents Grp_TblMst As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_TblName As System.Windows.Forms.Label
    Friend WithEvents Lbl_TblNo As System.Windows.Forms.Label
    Friend WithEvents txtTableName As System.Windows.Forms.TextBox
    Friend WithEvents txtTableNo As System.Windows.Forms.TextBox
    Friend WithEvents cmdTableHelp As System.Windows.Forms.Button
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TableMaster))
        Me.Lbl_TblMst = New System.Windows.Forms.Label
        Me.Grp_TblMst = New System.Windows.Forms.GroupBox
        Me.Lbl_TblNo = New System.Windows.Forms.Label
        Me.Lbl_TblName = New System.Windows.Forms.Label
        Me.cmdTableHelp = New System.Windows.Forms.Button
        Me.txtTableName = New System.Windows.Forms.TextBox
        Me.txtTableNo = New System.Windows.Forms.TextBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Grp_TblMst.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_TblMst
        '
        Me.Lbl_TblMst.AutoSize = True
        Me.Lbl_TblMst.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TblMst.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TblMst.ForeColor = System.Drawing.Color.Black
        Me.Lbl_TblMst.Location = New System.Drawing.Point(192, 8)
        Me.Lbl_TblMst.Name = "Lbl_TblMst"
        Me.Lbl_TblMst.Size = New System.Drawing.Size(204, 31)
        Me.Lbl_TblMst.TabIndex = 9
        Me.Lbl_TblMst.Text = "TABLE MASTER"
        Me.Lbl_TblMst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grp_TblMst
        '
        Me.Grp_TblMst.BackgroundImage = CType(resources.GetObject("Grp_TblMst.BackgroundImage"), System.Drawing.Image)
        Me.Grp_TblMst.Controls.Add(Me.Lbl_TblNo)
        Me.Grp_TblMst.Controls.Add(Me.Lbl_TblName)
        Me.Grp_TblMst.Location = New System.Drawing.Point(16, 40)
        Me.Grp_TblMst.Name = "Grp_TblMst"
        Me.Grp_TblMst.Size = New System.Drawing.Size(576, 160)
        Me.Grp_TblMst.TabIndex = 10
        Me.Grp_TblMst.TabStop = False
        '
        'Lbl_TblNo
        '
        Me.Lbl_TblNo.AutoSize = True
        Me.Lbl_TblNo.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TblNo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TblNo.Location = New System.Drawing.Point(64, 48)
        Me.Lbl_TblNo.Name = "Lbl_TblNo"
        Me.Lbl_TblNo.Size = New System.Drawing.Size(94, 21)
        Me.Lbl_TblNo.TabIndex = 11
        Me.Lbl_TblNo.Text = "TABLE NO :"
        '
        'Lbl_TblName
        '
        Me.Lbl_TblName.AutoSize = True
        Me.Lbl_TblName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TblName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TblName.Location = New System.Drawing.Point(40, 96)
        Me.Lbl_TblName.Name = "Lbl_TblName"
        Me.Lbl_TblName.Size = New System.Drawing.Size(118, 21)
        Me.Lbl_TblName.TabIndex = 12
        Me.Lbl_TblName.Text = "TABLE NAME :"
        '
        'cmdTableHelp
        '
        Me.cmdTableHelp.Image = CType(resources.GetObject("cmdTableHelp.Image"), System.Drawing.Image)
        Me.cmdTableHelp.Location = New System.Drawing.Point(408, 88)
        Me.cmdTableHelp.Name = "cmdTableHelp"
        Me.cmdTableHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdTableHelp.TabIndex = 1
        '
        'txtTableName
        '
        Me.txtTableName.BackColor = System.Drawing.Color.Wheat
        Me.txtTableName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTableName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableName.Location = New System.Drawing.Point(224, 128)
        Me.txtTableName.MaxLength = 35
        Me.txtTableName.Name = "txtTableName"
        Me.txtTableName.Size = New System.Drawing.Size(208, 26)
        Me.txtTableName.TabIndex = 2
        Me.txtTableName.Text = ""
        '
        'txtTableNo
        '
        Me.txtTableNo.BackColor = System.Drawing.Color.Wheat
        Me.txtTableNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTableNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTableNo.Location = New System.Drawing.Point(224, 88)
        Me.txtTableNo.MaxLength = 10
        Me.txtTableNo.Name = "txtTableNo"
        Me.txtTableNo.Size = New System.Drawing.Size(184, 26)
        Me.txtTableNo.TabIndex = 0
        Me.txtTableNo.Text = ""
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(472, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 4
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 56)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(208, 208)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 3
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "[F4]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 18)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'TableMaster
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(600, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Lbl_TblMst)
        Me.Controls.Add(Me.txtTableName)
        Me.Controls.Add(Me.txtTableNo)
        Me.Controls.Add(Me.cmdTableHelp)
        Me.Controls.Add(Me.Grp_TblMst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "TableMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TABLE MASTER"
        Me.Grp_TblMst.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    
    Private Sub txtTableNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTableNo.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtTableNo.Text) <> "" Then
                Call txtTableNo_Validated(txtTableNo, e)
                txtTableName.Focus()
            Else
                Call cmdTableHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txtTableName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTableName.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If txtTableName.Text <> "" Then
                Cmd_Add.Focus()
            End If
        End If
    End Sub

    Private Sub TableMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdTableHelp.Enabled = True
        txtTableNo.Focus()
        TableMastbool = True
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
    Private Sub TableMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub txtTableNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTableNo.Validated
        If Trim(txtTableNo.Text) <> "" Then
            vSeqNo = GetSeqno(txtTableNo.Text)
            sqlstring = "SELECT * FROM TableMaster WHERE TableNo = '" & Trim(txtTableNo.Text) & "'"
            gconnection.getDataSet(sqlstring, "TableMaster")
            If gdataset.Tables("TableMaster").Rows.Count > 0 Then
                txtTableName.Clear()
                txtTableName.Text = gdataset.Tables("TableMaster").Rows(0).Item("TableName")
                txtTableName.Focus()
                txtTableNo.ReadOnly = True
                Cmd_Add.Text = "Update[F7]"
                If gdataset.Tables("TableMaster").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("TableMaster").Rows(0).Item("Adddatetime")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                Me.Cmd_Add.Text = "Update[F7]"
                Me.txtTableNo.ReadOnly = True
                Me.cmdTableHelp.Enabled = False
                Me.txtTableName.Focus()
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.Cmd_Add.Text = "Add [F7]"
                txtTableNo.ReadOnly = False
                txtTableName.Focus()
            End If
        Else
            txtTableName.Text = ""
            txtTableName.Focus()
        End If
    End Sub

    Private Sub txtTableNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTableNo.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmdTableHelp.Enabled = True Then
                Search = Trim(txtTableNo.Text)
                Call cmdTableHelp_Click(txtTableNo, e)
            End If
        End If
    End Sub

    Private Sub cmdTableHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTableHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(TABLENO,'') AS TABLENO,ISNULL(TABLENAME,'') AS TABLENAME FROM TableMaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "TABLENO,TABLENAME"
        vform.vFormatstring = "            TABLE NO                |                        TABLE NAME                             "
        vform.vCaption = "TABLE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtTableNo.Text = Trim(vform.keyfield & "")
            Call txtTableNo_Validated(txtTableNo, e)
            txtTableNo.ReadOnly = True
            txtTableName.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub TableMaster_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TableMastbool = False
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txtTableNo.ReadOnly = False
        txtTableName.ReadOnly = False
        cmdTableHelp.Enabled = True
        Cmd_Add.Text = "Add [F7]"
        txtTableNo.Focus()
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            vSeqNo = GetSeqno(Val(txtTableNo.Text))
            sqlstring = " INSERT INTO TableMaster (TableNo,TableName,TableSeqNo,Freeze,AddUserId,Adddatetime)"
            sqlstring = sqlstring & " VALUES ( '" & Trim(txtTableNo.Text) & "','" & Replace(Trim(txtTableName.Text), "'", "") & "',"
            sqlstring = sqlstring & "" & Val(vSeqNo) & " ,"
            sqlstring = sqlstring & "'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "')"
            gconnection.dataOperation(1, sqlstring, "TableMaster")
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                    boolchk = False
                End If
            End If
            sqlstring = "UPDATE  TableMaster "
            sqlstring = sqlstring & " SET TableName='" & Replace(Trim(txtTableName.Text), "'", "") & "',"
            sqlstring = sqlstring & " AddUserId='" & Trim(gUsername) & "',Adddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "',freeze='N'"
            sqlstring = sqlstring & " WHERE TableNo = '" & Trim(txtTableNo.Text) & "'"
            gconnection.dataOperation(2, sqlstring, "TableMaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  Tablemaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUserId='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE TableNo = '" & Trim(txtTableNo.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "Tablemaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  Tablemaster "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUserId='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE TableNo = '" & Trim(txtTableNo.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "Tablemaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM Tablemaster"
        Gheader = "TABLE MASTER"
        FrReport.SsGridReport.SetText(2, 1, "TABLENO")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "TABLENAME")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "FREEZE")
        FrReport.SsGridReport.SetText(3, 3, 6)
        FrReport.Show()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Store Code Can't be blank *********************'''
        If Trim(txtTableNo.Text) = "" Then
            MessageBox.Show(" Table No. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTableNo.Focus()
            Exit Sub
        End If
        '''********** Check  Store desc Can't be blank *********************'''
        If Trim(txtTableName.Text) = "" Then
            MessageBox.Show(" Table Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTableName.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

End Class
