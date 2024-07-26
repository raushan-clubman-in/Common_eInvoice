Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.IO
Public Class UOMMaster
    Inherits System.Windows.Forms.Form
    Dim vseqno As Double
    Dim boolchk As Boolean
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
    Friend WithEvents cmdUOMHelp As System.Windows.Forms.Button
    Friend WithEvents txtUOMDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtUOMCode As System.Windows.Forms.TextBox
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UOMMaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdUOMHelp = New System.Windows.Forms.Button
        Me.txtUOMDesc = New System.Windows.Forms.TextBox
        Me.txtUOMCode = New System.Windows.Forms.TextBox
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
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 144)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'cmdUOMHelp
        '
        Me.cmdUOMHelp.Image = CType(resources.GetObject("cmdUOMHelp.Image"), System.Drawing.Image)
        Me.cmdUOMHelp.Location = New System.Drawing.Point(552, 264)
        Me.cmdUOMHelp.Name = "cmdUOMHelp"
        Me.cmdUOMHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdUOMHelp.TabIndex = 1
        '
        'txtUOMDesc
        '
        Me.txtUOMDesc.BackColor = System.Drawing.Color.Wheat
        Me.txtUOMDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUOMDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUOMDesc.Location = New System.Drawing.Point(480, 304)
        Me.txtUOMDesc.MaxLength = 35
        Me.txtUOMDesc.Name = "txtUOMDesc"
        Me.txtUOMDesc.Size = New System.Drawing.Size(216, 26)
        Me.txtUOMDesc.TabIndex = 2
        Me.txtUOMDesc.Text = ""
        '
        'txtUOMCode
        '
        Me.txtUOMCode.BackColor = System.Drawing.Color.Wheat
        Me.txtUOMCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUOMCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUOMCode.Location = New System.Drawing.Point(480, 264)
        Me.txtUOMCode.MaxLength = 10
        Me.txtUOMCode.Name = "txtUOMCode"
        Me.txtUOMCode.Size = New System.Drawing.Size(72, 26)
        Me.txtUOMCode.TabIndex = 0
        Me.txtUOMCode.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "UOM DESCRIPTION "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "UOM CODE "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(392, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 31)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "UOM MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
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
        Me.Label4.Location = New System.Drawing.Point(576, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 22)
        Me.Label4.TabIndex = 85
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
        'UOMMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(934, 684)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtUOMDesc)
        Me.Controls.Add(Me.txtUOMCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdUOMHelp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "UOMMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UOM MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtUOMCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUOMCode.KeyPress
        Try
            ' getNumeric(e)
            If Asc(e.KeyChar) = 13 Then
                If Trim(txtUOMCode.Text) <> "" Then
                    Call txtUOMCode_Validated(txtUOMCode, e)
                    txtUOMDesc.Focus()
                Else
                    Call cmdUOMHelp_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txtUOMDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUOMDesc.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If txtUOMDesc.Text <> "" Then
                    Cmd_Add.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txtUOMCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUOMCode.Validated
        Try
            Dim Fre As String
            If Trim(txtUOMCode.Text) <> "" Then
                Dim ds As New DataSet
                vseqno = GetSeqno(txtUOMCode.Text)
                sqlstring = "SELECT * FROM UOMMaster WHERE UOMSeqno=" & Val(vseqno)
                gconnection.getDataSet(sqlstring, "UOMMaster")
                If gdataset.Tables("UOMMaster").Rows.Count > 0 Then
                    txtUOMDesc.Clear()
                    txtUOMDesc.Text = gdataset.Tables("UOMMaster").Rows(0).Item("UOMDesc")
                    If gdataset.Tables("UOMMaster").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = ""
                        Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("UOMMaster").Rows(0).Item("AddDateTime")), "dd-MMM-yyyy")
                        Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_Freeze.Text = "Freeze[F8]"
                    End If
                    Me.Cmd_Add.Text = "Update[F7]"
                    Me.txtUOMCode.ReadOnly = True
                    Me.cmdUOMHelp.Enabled = False
                    Me.txtUOMDesc.Focus()
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Add.Text = "Add [F7]"
                    txtUOMCode.ReadOnly = False
                    txtUOMDesc.Focus()
                End If
            Else
                txtUOMCode.Text = ""
                txtUOMDesc.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdUOMHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUOMHelp.Click
        Try
            Dim vform As New ListOperattion1
            gSQLString = "SELECT ISNULL(UOMCODE,'') AS UOMCODE,ISNULL(UOMDESC,'') AS UOMDESC FROM UOMMaster"
            If Trim(Search) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = ""
            End If
            vform.Field = "UOMCODE,UOMDESC"
            vform.vFormatstring = "            UOM CODE                 |                  UOM DESCRIPTION                             "
            vform.vCaption = "UOM MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txtUOMCode.Text = Trim(vform.keyfield & "")
                Call txtUOMCode_Validated(txtUOMCode, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub UOMMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
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
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub UOMMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtUOMCode.ReadOnly = False
            cmdUOMHelp.Enabled = True
            txtUOMCode.Focus()
            UOMMastbool = True
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
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
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txtUOMCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUOMCode.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If cmdUOMHelp.Enabled = True Then
                    Search = Trim(txtUOMCode.Text)
                    Call cmdUOMHelp_Click(txtUOMCode, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub UOMMaster_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            UOMMastbool = False
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Try
            Call clearform(Me)
            Me.lbl_Freeze.Visible = False
            Me.txtUOMCode.ReadOnly = False
            Me.lbl_Freeze.Text = "Record Freezed  On "
            Me.Cmd_Freeze.Text = "Freeze[F8]"
            Cmd_Add.Text = "Add [F7]"
            txtUOMCode.Enabled = True
            txtUOMCode.ReadOnly = False
            txtUOMDesc.ReadOnly = False
            cmdUOMHelp.Enabled = True
            txtUOMCode.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Try
            Dim strSQL As String
            If Cmd_Add.Text = "Add [F7]" Then
                Call checkValidation() '''--->Check Validation
                If boolchk = False Then Exit Sub
                vseqno = GetSeqno(txtUOMCode.Text)
                strSQL = " INSERT INTO UOMMaster (UOMCode,UOMDesc,UOMSeqno,Freeze,AddUser,AddDatetime)"
                strSQL = strSQL & " VALUES ( '" & Trim(txtUOMCode.Text) & "','" & Replace(Trim(txtUOMDesc.Text), "'", "") & "',"
                strSQL = strSQL & "" & Val(vseqno) & ","
                strSQL = strSQL & "'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "')"
                gconnection.dataOperation(1, strSQL, "UOMMaster")
                ' Me.Cmd_Clear_Click(sender, e)
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
                strSQL = "UPDATE  UOMMaster "
                strSQL = strSQL & " SET UOMDesc='" & Replace(Trim(txtUOMDesc.Text), "'", "") & "',"
                strSQL = strSQL & " AddUser='" & Trim(gUsername) & "',AddDatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "',freeze='N'"
                strSQL = strSQL & " WHERE UOMCode = '" & Trim(txtUOMCode.Text) & "'"
                gconnection.dataOperation(2, strSQL, "UOMMaster")
                'Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
            End If
            If Mid(gTallyIntegration, 1, 1) = "Y" Then
                Call tallyvalidate()
            End If
            Me.Cmd_Clear_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Try
            Call checkValidation() ''-->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
                sqlstring = "UPDATE  UOMMaster "
                sqlstring = sqlstring & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'"
                sqlstring = sqlstring & " WHERE UOMCode = '" & Trim(txtUOMCode.Text) & "'"
                gconnection.dataOperation(3, sqlstring, "UOMMaster")
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
            Else
                sqlstring = "UPDATE  UOMMaster "
                sqlstring = sqlstring & " SET Freeze= 'N',AddUser='" & gUsername & " ', AddDatetime='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "'"
                sqlstring = sqlstring & " WHERE UOMCode = '" & Trim(txtUOMCode.Text) & "'"
                gconnection.dataOperation(4, sqlstring, "UOMMaster")
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Try
            Dim FrReport As New ReportDesigner
            tables = " FROM Uommaster"
            Gheader = " UOM MASTER VIEW "
            FrReport.SsGridReport.SetText(2, 1, "UOMCODE")
            FrReport.SsGridReport.SetText(3, 1, 10)
            FrReport.SsGridReport.SetText(2, 2, "UOMDESC")
            FrReport.SsGridReport.SetText(3, 2, 35)
            FrReport.SsGridReport.SetText(2, 3, "FREEZE")
            FrReport.SsGridReport.SetText(3, 3, 6)
            FrReport.Show()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub checkValidation()
        Try
            boolchk = False
            '''********** Check  Store Code Can't be blank *********************'''
            If Trim(txtUOMCode.Text) = "" Then
                MessageBox.Show(" UOM Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUOMCode.Focus()
                Exit Sub
            End If
            '''********** Check  Store desc Can't be blank *********************'''
            If Trim(txtUOMDesc.Text) = "" Then
                MessageBox.Show(" UOM Description can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUOMDesc.Focus()
                Exit Sub
            End If
            boolchk = True
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Function tallyvalidate()
        Dim myconnection As New ADODB.Connection
        myconnection.Open(gTallyDsn)

        Dim vfill As New ADODB.Recordset
        Dim SerHttp As New MSXML2.ServerXMLHTTP30
        Dim strRequestXML As String
        Dim strstring, sqlstring, ssql As String
        Dim rowj As Integer

        'For uom

        sqlstring = "SELECT ISNULL(u.UOMCODE,'') AS UOMCODE,ISNULL(U.UOMDESC,'') AS UOMDESC"
        sqlstring = sqlstring & " FROM UOMMASTER U WHERE u.uomCODE='" & Trim(txtUOMCode.Text) & "'"
        gconnection.getDataSet(sqlstring, "TAX")
        If gdataset.Tables("TAX").Rows.Count > 0 Then
            For rowj = 0 To gdataset.Tables("TAX").Rows.Count - 1
                With gdataset.Tables("TAX").Rows(rowj)
                    ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'UNIT' where $name = '" & Trim(.Item("uomcode")) & "' or $name = '" & Trim(.Item("uomdesc")) & "'"
                    vfill.Open(ssql, myconnection)
                    If vfill.EOF Then

                        strRequestXML = ""
                        strRequestXML = strRequestXML & "<ENVELOPE>"
                        strRequestXML = strRequestXML & "<HEADER>"
                        strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                        strRequestXML = strRequestXML & "</HEADER>"
                        strRequestXML = strRequestXML & "<BODY>"
                        strRequestXML = strRequestXML & "<IMPORTDATA>"
                        strRequestXML = strRequestXML & "<REQUESTDESC>"
                        strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                        strRequestXML = strRequestXML & "<STATICVARIABLES>"
                        strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                        strRequestXML = strRequestXML & "</STATICVARIABLES>"

                        strRequestXML = strRequestXML & "</REQUESTDESC>"
                        strRequestXML = strRequestXML & "<REQUESTDATA>"
                        strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                        strRequestXML = strRequestXML & "<UNIT NAME='" & Trim(.Item("uomcode")) & "' ACTION='Create'>"
                        strRequestXML = strRequestXML & "<NAME>" & Trim(.Item("uomcode")) & "</NAME>"
                        strRequestXML = strRequestXML & "<ORIGINALNAME>" & Trim(.Item("uomdesc")) & " </ORIGINALNAME>"
                        strRequestXML = strRequestXML & "<ISSIMPLEUNIT>Yes</ISSIMPLEUNIT>"
                        strRequestXML = strRequestXML & "</UNIT>"
                        strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                        strRequestXML = strRequestXML & "</REQUESTDATA>"
                        strRequestXML = strRequestXML & "</IMPORTDATA>"
                        strRequestXML = strRequestXML & "</BODY>"
                        strRequestXML = strRequestXML & "</ENVELOPE>"

                        SerHttp.open("POST", gTallyOdbc & gTallyPort)
                        SerHttp.send(strRequestXML)
                    End If
                    vfill.Close()
                End With
            Next
        End If
    End Function

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class