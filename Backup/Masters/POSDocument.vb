Imports System.Data.SqlClient
Public Class POSDocument
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_POSCode As System.Windows.Forms.Label
    Friend WithEvents txt_POSCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_POSDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmd_POSCodeHelp As System.Windows.Forms.Button
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents txt_DocType As System.Windows.Forms.TextBox
    Friend WithEvents lbl_DocType As System.Windows.Forms.Label
    Friend WithEvents cmd_DocTypeHelp As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_DocName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(POSDocument))
        Me.lbl_POSCode = New System.Windows.Forms.Label
        Me.txt_POSCode = New System.Windows.Forms.TextBox
        Me.txt_POSDesc = New System.Windows.Forms.TextBox
        Me.cmd_POSCodeHelp = New System.Windows.Forms.Button
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.txt_DocType = New System.Windows.Forms.TextBox
        Me.lbl_DocType = New System.Windows.Forms.Label
        Me.cmd_DocTypeHelp = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.txt_DocName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_POSCode
        '
        Me.lbl_POSCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_POSCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POSCode.ForeColor = System.Drawing.Color.Black
        Me.lbl_POSCode.Location = New System.Drawing.Point(320, 346)
        Me.lbl_POSCode.Name = "lbl_POSCode"
        Me.lbl_POSCode.Size = New System.Drawing.Size(93, 21)
        Me.lbl_POSCode.TabIndex = 14
        Me.lbl_POSCode.Text = "POS CODE "
        Me.lbl_POSCode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txt_POSCode
        '
        Me.txt_POSCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_POSCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_POSCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POSCode.Location = New System.Drawing.Point(416, 344)
        Me.txt_POSCode.MaxLength = 10
        Me.txt_POSCode.Name = "txt_POSCode"
        Me.txt_POSCode.Size = New System.Drawing.Size(144, 26)
        Me.txt_POSCode.TabIndex = 2
        Me.txt_POSCode.Text = ""
        '
        'txt_POSDesc
        '
        Me.txt_POSDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_POSDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_POSDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POSDesc.Location = New System.Drawing.Point(584, 344)
        Me.txt_POSDesc.MaxLength = 35
        Me.txt_POSDesc.Name = "txt_POSDesc"
        Me.txt_POSDesc.ReadOnly = True
        Me.txt_POSDesc.Size = New System.Drawing.Size(168, 26)
        Me.txt_POSDesc.TabIndex = 3
        Me.txt_POSDesc.Text = ""
        '
        'cmd_POSCodeHelp
        '
        Me.cmd_POSCodeHelp.Image = CType(resources.GetObject("cmd_POSCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_POSCodeHelp.Location = New System.Drawing.Point(560, 344)
        Me.cmd_POSCodeHelp.Name = "cmd_POSCodeHelp"
        Me.cmd_POSCodeHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmd_POSCodeHelp.TabIndex = 15
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.Black
        Me.lbl_Heading.Location = New System.Drawing.Point(392, 32)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(210, 31)
        Me.lbl_Heading.TabIndex = 9
        Me.lbl_Heading.Text = "POS DOCUMENT"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_DocType
        '
        Me.txt_DocType.BackColor = System.Drawing.Color.Wheat
        Me.txt_DocType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_DocType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DocType.Location = New System.Drawing.Point(416, 264)
        Me.txt_DocType.MaxLength = 4
        Me.txt_DocType.Name = "txt_DocType"
        Me.txt_DocType.Size = New System.Drawing.Size(144, 26)
        Me.txt_DocType.TabIndex = 0
        Me.txt_DocType.Text = ""
        '
        'lbl_DocType
        '
        Me.lbl_DocType.BackColor = System.Drawing.Color.Transparent
        Me.lbl_DocType.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DocType.Location = New System.Drawing.Point(264, 266)
        Me.lbl_DocType.Name = "lbl_DocType"
        Me.lbl_DocType.Size = New System.Drawing.Size(151, 21)
        Me.lbl_DocType.TabIndex = 11
        Me.lbl_DocType.Text = "DOCUMENT TYPE "
        Me.lbl_DocType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmd_DocTypeHelp
        '
        Me.cmd_DocTypeHelp.Image = CType(resources.GetObject("cmd_DocTypeHelp.Image"), System.Drawing.Image)
        Me.cmd_DocTypeHelp.Location = New System.Drawing.Point(560, 264)
        Me.cmd_DocTypeHelp.Name = "cmd_DocTypeHelp"
        Me.cmd_DocTypeHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmd_DocTypeHelp.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(224, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 200)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
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
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Location = New System.Drawing.Point(224, 584)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 56)
        Me.GroupBox2.TabIndex = 4
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
        Me.lbl_Freeze.TabIndex = 16
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'txt_DocName
        '
        Me.txt_DocName.BackColor = System.Drawing.Color.Wheat
        Me.txt_DocName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_DocName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DocName.Location = New System.Drawing.Point(416, 304)
        Me.txt_DocName.MaxLength = 35
        Me.txt_DocName.Name = "txt_DocName"
        Me.txt_DocName.Size = New System.Drawing.Size(336, 26)
        Me.txt_DocName.TabIndex = 1
        Me.txt_DocName.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "DOCUMENT NAME "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(584, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 22)
        Me.Label4.TabIndex = 18
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
        'POSDocument
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(950, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_DocName)
        Me.Controls.Add(Me.lbl_POSCode)
        Me.Controls.Add(Me.txt_POSCode)
        Me.Controls.Add(Me.txt_POSDesc)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.txt_DocType)
        Me.Controls.Add(Me.lbl_DocType)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmd_POSCodeHelp)
        Me.Controls.Add(Me.cmd_DocTypeHelp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "POSDocument"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS DOCUMENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim vSeqno As Double
    Dim gconnection As New GlobalClass
    Private Sub POSDocument_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd_DocTypeHelp.Enabled = True
        txt_DocType.ReadOnly = False
        txt_POSCode.ReadOnly = False
        txt_DocType.Enabled = True
        posdocumentbool = True
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
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  DocType Code is blank
        If Trim(txt_DocType.Text) = "" Then
            MessageBox.Show(" Doctype can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_DocType.Focus()
            Exit Sub
        End If
        '''********** Check  POSCode is blank
        If Trim(txt_POSCode.Text) = "" Then
            MessageBox.Show(" POSCode can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_POSCode.Focus()
            Exit Sub
        End If
        '''********** Check POSDesc is blank
        If Trim(txt_POSDesc.Text) = "" Then
            MessageBox.Show(" POSDesc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_POSDesc.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub txt_DocType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DocType.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txt_DocType.Text <> "" Then
                Call txt_DocType_Validated(txt_DocType, e)
            Else
                Call cmd_DocTypeHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_POSCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_POSCode.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If txt_POSCode.Text <> "" Then
                Call txt_POSCode_Validated(txt_POSCode, e)
            Else
                Call cmd_POSCodeHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_POSDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_POSDesc.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub cmd_DocTypeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_DocTypeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(DOCTYPE,'') AS DOCTYPE,ISNULL(POSCODE,'') AS POSCODE FROM POSDOCUMENT "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y'"
        End If
        vform.Field = "DOCTYPE,POSCODE"
        vform.vFormatstring = "     DOC TYPE               |                          POS CODE                                "
        vform.vCaption = "POS DOCUMENT MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_DocType.Text = Trim(vform.keyfield & "")
            Call txt_DocType_Validated(txt_DocType, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmd_POSCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_POSCodeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y'"
        End If
        vform.Field = "POSCODE,POSDESC"
        vform.vFormatstring = "                 POS CODE              |                   POS DESCRIPTION                           "
        vform.vCaption = "POS MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_POSCode.Text = Trim(vform.keyfield & "")
            Call txt_POSCode_Validated(txt_POSCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_POSCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_POSCode.Validated
        If Trim(txt_POSCode.Text) <> "" Then
            sqlstring = "SELECT * FROM POSMaster WHERE POSCode='" & Trim(txt_POSCode.Text) & "' AND ISNULL(Freeze,'') <>'Y' "
            gconnection.getDataSet(sqlstring, "POSMaster")
            If gdataset.Tables("POSMaster").Rows.Count > 0 Then
                txt_POSDesc.Clear()
                txt_POSDesc.Text = Trim(gdataset.Tables("POSMaster").Rows(0).Item("POSDesc"))
                Cmd_Add.Focus()
                txt_POSCode.ReadOnly = True
            Else
                txt_POSDesc.Clear()
                txt_POSCode.Clear()
                txt_POSCode.Focus()
            End If
        Else
            txt_POSCode.Text = ""
            txt_POSCode.Focus()
        End If
    End Sub

    Private Sub txt_DocType_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_DocType.Validated
        If Trim(txt_DocType.Text) <> "" Then
            sqlstring = "SELECT * FROM POSDocument WHERE Doctype='" & Trim(txt_DocType.Text) & "'"
            gconnection.getDataSet(sqlstring, "POSDocument")
            If gdataset.Tables("POSDocument").Rows.Count > 0 Then
                txt_DocName.Text = Trim(gdataset.Tables("POSDocument").Rows(0).Item("Docname"))
                txt_POSCode.Text = Trim(gdataset.Tables("POSDocument").Rows(0).Item("Poscode"))
                txt_POSDesc.Text = Trim(gdataset.Tables("POSDocument").Rows(0).Item("Posdesc"))
                txt_DocName.Focus()
                txt_DocType.ReadOnly = True
                If gdataset.Tables("POSDocument").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(gdataset.Tables("POSDocument").Rows(0).Item("adddate"), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                Me.Cmd_Add.Text = "Update[F7]"
                Me.txt_DocType.ReadOnly = True
                Me.cmd_DocTypeHelp.Enabled = False
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
                Me.txt_DocName.Focus()
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.Cmd_Add.Text = "Add [F7]"
                txt_DocType.ReadOnly = False
                txt_DocName.Focus()
            End If
        Else
            txt_DocType.Text = ""
            txt_DocName.Focus()
        End If
    End Sub

    Private Sub POSDocument_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub txt_DocType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_DocType.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmd_DocTypeHelp.Enabled = True Then
                Search = Trim(txt_DocType.Text)
                Call cmd_DocTypeHelp_Click(sender, e)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txt_POSCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_POSCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(txt_POSCode.Text)
            Call cmd_POSCodeHelp_Click(sender, e)
        End If
    End Sub

    Private Sub POSDocument_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        posdocumentbool = False
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txt_DocType.Enabled = True
        txt_DocType.ReadOnly = False
        txt_POSCode.ReadOnly = False
        cmd_DocTypeHelp.Enabled = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_DocType.Focus()
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim strSQL, Update(0) As String
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            strSQL = " INSERT INTO POSDocument (Doctype,Docname,Poscode,Posdesc,freeze,adduser,adddate)"
            strSQL = strSQL & "VALUES ( '" & Trim(txt_DocType.Text) & "','" & Trim(txt_DocName.Text) & "','" & Trim(txt_POSCode.Text) & "',"
            strSQL = strSQL & "'" & Trim(txt_POSDesc.Text) & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
            Update(0) = strSQL
            strSQL = " INSERT INTO PoSKotDoc(DOCTYPE, DOCNO,DOCFLAG) "
            strSQL = strSQL & "VALUES('" & Trim(txt_DocType.Text) & "',0,'Y')"
            ReDim Preserve Update(Update.Length)
            Update(Update.Length - 1) = strSQL
            gconnection.MoreTransold(Update)
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
            strSQL = "UPDATE  POSDocument "
            strSQL = strSQL & " SET Docname = '" & Replace(Trim(txt_DocName.Text), "'", "") & "',"
            strSQL = strSQL & " Poscode='" & Replace(Trim(txt_POSCode.Text), "'", "") & "',Posdesc='" & Trim(txt_POSDesc.Text) & "',"
            strSQL = strSQL & " adduser='" & Trim(gUsername) & "',adddate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',freeze='N'"
            strSQL = strSQL & " WHERE Doctype = '" & Trim(txt_DocType.Text) & "'"
            gconnection.dataOperation(2, strSQL, "POSDocument")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  POSDocument "
            sqlstring = sqlstring & " SET Freeze= 'Y',adduser='" & gUsername & " ', adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Doctype = '" & Trim(txt_DocType.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "POSDocument")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  POSDocument "
            sqlstring = sqlstring & " SET Freeze= 'N',adduser='" & gUsername & " ', adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE Doctype = '" & Trim(txt_DocType.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "POSDocument")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " From POSDocument"
        Gheader = "POSDOCUMENT MASTER VIEW "
        FrReport.SsGridReport.SetText(2, 1, "DOCTYPE")
        FrReport.SsGridReport.SetText(3, 1, 15)
        FrReport.SsGridReport.SetText(2, 2, "DOCNAME")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "POSCODE")
        FrReport.SsGridReport.SetText(3, 3, 35)
        FrReport.SsGridReport.SetText(2, 4, "POSDESC")
        FrReport.SsGridReport.SetText(3, 4, 35)
        FrReport.SsGridReport.SetText(2, 5, "FREEZE")
        FrReport.SsGridReport.SetText(3, 5, 5)
        FrReport.Show()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub txt_DocName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_DocName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_POSCode.Focus()
        End If
    End Sub

    Private Sub lbl_Heading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Heading.Click

    End Sub
End Class
