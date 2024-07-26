Imports System.Data.SqlClient
Public Class SubPaymentMode
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdPayment As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAccName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAccinHelp As System.Windows.Forms.Button
    Friend WithEvents TxtAccIn As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentCode As System.Windows.Forms.TextBox
    Friend WithEvents txtSubPaymentcode As System.Windows.Forms.TextBox
    Friend WithEvents txtSubPaymentName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Frez As System.Windows.Forms.Label
    Friend WithEvents cmdpaymentcodeHelp As System.Windows.Forms.Button
    Friend WithEvents txtPaymentname As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SubPaymentMode))
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPaymentCode = New System.Windows.Forms.TextBox
        Me.cmdPayment = New System.Windows.Forms.Button
        Me.txtSubPaymentcode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAccName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdAccinHelp = New System.Windows.Forms.Button
        Me.TxtAccIn = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSubPaymentName = New System.Windows.Forms.TextBox
        Me.lbl_Frez = New System.Windows.Forms.Label
        Me.cmdpaymentcodeHelp = New System.Windows.Forms.Button
        Me.txtPaymentname = New System.Windows.Forms.TextBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(112, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(383, 31)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "SUB PAYMENT MODE MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ACCOUNT IN :"
        '
        'txtPaymentCode
        '
        Me.txtPaymentCode.BackColor = System.Drawing.Color.Wheat
        Me.txtPaymentCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentCode.Location = New System.Drawing.Point(208, 152)
        Me.txtPaymentCode.MaxLength = 15
        Me.txtPaymentCode.Name = "txtPaymentCode"
        Me.txtPaymentCode.Size = New System.Drawing.Size(136, 26)
        Me.txtPaymentCode.TabIndex = 2
        Me.txtPaymentCode.Text = ""
        '
        'cmdPayment
        '
        Me.cmdPayment.Image = CType(resources.GetObject("cmdPayment.Image"), System.Drawing.Image)
        Me.cmdPayment.Location = New System.Drawing.Point(344, 72)
        Me.cmdPayment.Name = "cmdPayment"
        Me.cmdPayment.Size = New System.Drawing.Size(23, 26)
        Me.cmdPayment.TabIndex = 15
        '
        'txtSubPaymentcode
        '
        Me.txtSubPaymentcode.BackColor = System.Drawing.Color.Wheat
        Me.txtSubPaymentcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubPaymentcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubPaymentcode.Location = New System.Drawing.Point(208, 72)
        Me.txtSubPaymentcode.MaxLength = 15
        Me.txtSubPaymentcode.Name = "txtSubPaymentcode"
        Me.txtSubPaymentcode.Size = New System.Drawing.Size(136, 26)
        Me.txtSubPaymentcode.TabIndex = 0
        Me.txtSubPaymentcode.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "SUB PAYMENT NAME :"
        '
        'txtAccName
        '
        Me.txtAccName.BackColor = System.Drawing.Color.Wheat
        Me.txtAccName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAccName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccName.Location = New System.Drawing.Point(368, 192)
        Me.txtAccName.MaxLength = 50
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.ReadOnly = True
        Me.txtAccName.Size = New System.Drawing.Size(207, 26)
        Me.txtAccName.TabIndex = 5
        Me.txtAccName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "SUB PAYMENT CODE :"
        '
        'cmdAccinHelp
        '
        Me.cmdAccinHelp.Image = CType(resources.GetObject("cmdAccinHelp.Image"), System.Drawing.Image)
        Me.cmdAccinHelp.Location = New System.Drawing.Point(344, 192)
        Me.cmdAccinHelp.Name = "cmdAccinHelp"
        Me.cmdAccinHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdAccinHelp.TabIndex = 20
        '
        'TxtAccIn
        '
        Me.TxtAccIn.BackColor = System.Drawing.Color.Wheat
        Me.TxtAccIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAccIn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccIn.Location = New System.Drawing.Point(208, 192)
        Me.TxtAccIn.MaxLength = 15
        Me.TxtAccIn.Name = "TxtAccIn"
        Me.TxtAccIn.Size = New System.Drawing.Size(136, 26)
        Me.TxtAccIn.TabIndex = 4
        Me.TxtAccIn.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 176)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 21)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "PAYMENT CODE :"
        '
        'txtSubPaymentName
        '
        Me.txtSubPaymentName.BackColor = System.Drawing.Color.Wheat
        Me.txtSubPaymentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubPaymentName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubPaymentName.Location = New System.Drawing.Point(208, 112)
        Me.txtSubPaymentName.MaxLength = 50
        Me.txtSubPaymentName.Name = "txtSubPaymentName"
        Me.txtSubPaymentName.Size = New System.Drawing.Size(240, 26)
        Me.txtSubPaymentName.TabIndex = 1
        Me.txtSubPaymentName.Text = ""
        '
        'lbl_Frez
        '
        Me.lbl_Frez.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Frez.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frez.ForeColor = System.Drawing.Color.Red
        Me.lbl_Frez.Location = New System.Drawing.Point(136, 240)
        Me.lbl_Frez.Name = "lbl_Frez"
        Me.lbl_Frez.Size = New System.Drawing.Size(328, 25)
        Me.lbl_Frez.TabIndex = 21
        Me.lbl_Frez.Text = "Record Freezed  On "
        Me.lbl_Frez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Frez.Visible = False
        '
        'cmdpaymentcodeHelp
        '
        Me.cmdpaymentcodeHelp.Image = CType(resources.GetObject("cmdpaymentcodeHelp.Image"), System.Drawing.Image)
        Me.cmdpaymentcodeHelp.Location = New System.Drawing.Point(344, 152)
        Me.cmdpaymentcodeHelp.Name = "cmdpaymentcodeHelp"
        Me.cmdpaymentcodeHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdpaymentcodeHelp.TabIndex = 19
        '
        'txtPaymentname
        '
        Me.txtPaymentname.BackColor = System.Drawing.Color.Wheat
        Me.txtPaymentname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaymentname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentname.Location = New System.Drawing.Point(368, 152)
        Me.txtPaymentname.MaxLength = 35
        Me.txtPaymentname.Name = "txtPaymentname"
        Me.txtPaymentname.Size = New System.Drawing.Size(208, 26)
        Me.txtPaymentname.TabIndex = 3
        Me.txtPaymentname.Text = ""
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
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 56)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(368, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 22)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "[F4]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(383, 18)
        Me.Label6.TabIndex = 417
        Me.Label6.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'SubPaymentMode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(600, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtPaymentname)
        Me.Controls.Add(Me.cmdpaymentcodeHelp)
        Me.Controls.Add(Me.lbl_Frez)
        Me.Controls.Add(Me.txtSubPaymentName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPaymentCode)
        Me.Controls.Add(Me.cmdPayment)
        Me.Controls.Add(Me.txtSubPaymentcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAccName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdAccinHelp)
        Me.Controls.Add(Me.TxtAccIn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "SubPaymentMode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUB PAYMENT MODE"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Private Sub SubPaymentMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSubPaymentcode.ReadOnly = False
        cmdPayment.Enabled = True
        subpaymentmodebool = True
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
                    Cmd_View.Enabled = True
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

    Private Sub txtSubPaymentcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubPaymentcode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtSubPaymentcode.Text) <> "" Then
                Call txtSubPaymentcode_Validated(sender, e)
            Else
                Call cmdPayment_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txtSubPaymentName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubPaymentName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPaymentCode.Focus()
        End If
    End Sub

    Private Sub txtPaymentCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaymentCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtPaymentCode.Text) <> "" Then
                txtPaymentCode_Validated(txtPaymentCode, e)
            Else
                Call cmdpaymentcodeHelp_Click(cmdPayment, e)
            End If
        End If
    End Sub

    Private Sub TxtAccIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAccIn.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(TxtAccIn.Text) <> "" Then
                TxtAccIn_Validated(TxtAccIn, e)
            Else
                Call cmdAccinHelp_Click(cmdPayment, e)
            End If
        End If
    End Sub

    Private Sub txtAccName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccName.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub cmdPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayment.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(SUBPAYMENTCODE,'') AS SUBPAYMENTCODE,ISNULL(SUBPAYMENTNAME,'') AS SUBPAYMENTNAME FROM SubPaymentMode"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " "
        End If
        vform.Field = "SUBPAYMENTCODE,SUBPAYMENTNAME"
        vform.vFormatstring = "                   SUBPAYMENT CODE             |               SUBPAYMENT NAME                             "
        vform.vCaption = "SUBPAYMENT MODE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtSubPaymentcode.Text = Trim(vform.keyfield & "")
            Call txtSubPaymentcode_Validated(txtPaymentCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmdAccinHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccinHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(ACCODE,'') AS ACCODE,ISNULL(ACDESC,'') AS ACDESC FROM Accountsglaccountmaster  "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(freezeflag,'') <> 'Y'"
        End If
        vform.Field = "ACCODE,ACDESC "
        vform.vFormatstring = "                   ACCODE                 |                  ACDESC                        "
        vform.vCaption = "ACCOUNT MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TxtAccIn.Text = Trim(vform.keyfield & "")
            Call TxtAccIn_Validated(TxtAccIn, e)
            txtAccName.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub TxtAccIn_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAccIn.Validated
        If Trim(TxtAccIn.Text) <> "" Then
            sqlstring = "SELECT ACDESC FROM accountsglaccountmaster WHERE ACCODE = '" & Trim(TxtAccIn.Text) & "'"
            gconnection.getDataSet(sqlstring, "accountsglaccountmaster")
            If gdataset.Tables("accountsglaccountmaster").Rows.Count > 0 Then
                txtAccName.Clear()
                txtAccName.Text = Trim(gdataset.Tables("accountsglaccountmaster").Rows(0).Item("ACDESC"))
                txtAccName.ReadOnly = True
                Cmd_Add.Focus()
            Else
                TxtAccIn.Clear()
                txtAccName.Clear()
                TxtAccIn.Focus()
                txtAccName.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub txtSubPaymentcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubPaymentcode.Validated
        Dim vstring As String
        If Trim(txtSubPaymentcode.Text) <> "" Then
            sqlstring = "SELECT * FROM subPaymentMode WHERE Subpaymentcode= '" & Trim(txtSubPaymentcode.Text) & "'"
            gconnection.getDataSet(sqlstring, "subPaymentMode")
            If gdataset.Tables("subPaymentMode").Rows.Count > 0 Then
                txtSubPaymentName.Clear()
                txtSubPaymentName.Text = Replace(Trim(gdataset.Tables("subPaymentMode").Rows(0).Item("Subpaymentname")), "", "'")
                txtPaymentCode.Text = Trim(gdataset.Tables("subPaymentMode").Rows(0).Item("paymentcode"))
                txtPaymentname.Text = Trim(gdataset.Tables("subPaymentMode").Rows(0).Item("paymentname"))
                TxtAccIn.Text = Trim(gdataset.Tables("subPaymentMode").Rows(0).Item("Accountin"))
                sqlstring = "SELECT ACDESC FROM accountsglaccountmaster WHERE  ACCODE='" & TxtAccIn.Text & "'"
                vstring = gconnection.getvalue(sqlstring)
                txtAccName.Text = Replace(vstring, "", "'")
                Cmd_Add.Text = "Update [F7]"
                txtSubPaymentName.Focus()
                If gdataset.Tables("subPaymentMode").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Frez.Visible = True
                    Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(gdataset.Tables("subPaymentMode").Rows(0).Item("AddDate"), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Frez.Visible = False
                    Me.lbl_Frez.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                Me.Cmd_Add.Text = "Update[F7]"
                Me.txtSubPaymentcode.ReadOnly = True
                Me.cmdPayment.Enabled = False
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
                Me.txtSubPaymentName.Focus()
            Else
                Me.lbl_Frez.Visible = False
                Me.lbl_Frez.Text = "Record Freezed  On "
                Me.Cmd_Add.Text = "Add [F7]"
                txtSubPaymentcode.ReadOnly = False
                txtSubPaymentName.Focus()
            End If
        Else
            txtSubPaymentcode.Text = ""
            txtSubPaymentName.Focus()
        End If
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check Sub Payment Code is blank
        If Trim(txtSubPaymentcode.Text) = "" Then
            MessageBox.Show(" SubPayment Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSubPaymentcode.Focus()
            Exit Sub
        End If
        '''********** Check Sub Payment Name is blank
        If Trim(txtSubPaymentName.Text) = "" Then
            MessageBox.Show(" SubPayment Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSubPaymentName.Focus()
            Exit Sub
        End If
        '''********** Check Account In is blank
        If Trim(TxtAccIn.Text) = "" Then
            MessageBox.Show(" Account In field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtAccIn.Focus()
            Exit Sub
        End If
        '''********** Check PaymentCode is blank
        If Trim(txtPaymentCode.Text) = "" Then
            MessageBox.Show(" PaymentCode field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPaymentCode.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub txtSubPaymentcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSubPaymentcode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmdPayment.Enabled = True Then
                Search = Trim(txtSubPaymentcode.Text)
                Call cmdPayment_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub TxtAccIn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAccIn.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(TxtAccIn.Text)
            Call cmdAccinHelp_Click(sender, e)
        End If
    End Sub

    Private Sub SubPaymentMode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(sender, e)
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

    Private Sub SubPaymentMode_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        subpaymentmodebool = False
    End Sub

    Private Sub txtPaymentCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaymentCode.Validated
        If Trim(txtPaymentCode.Text) <> "" Then
            sqlstring = "SELECT paymentname FROM paymentmodemaster WHERE PaymentCode= '" & Trim(txtPaymentCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "paymentmodemaster")
            If gdataset.Tables("paymentmodemaster").Rows.Count > 0 Then
                txtPaymentname.Clear()
                txtPaymentname.Text = Trim(gdataset.Tables("paymentmodemaster").Rows(0).Item("paymentname"))
                txtPaymentname.ReadOnly = True
                TxtAccIn.Focus()
            Else
                txtPaymentCode.Clear()
                txtPaymentname.Clear()
                txtPaymentCode.Focus()
                txtPaymentname.ReadOnly = False
            End If
        End If
    End Sub


    Private Sub txtPaymentname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaymentname.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtAccIn.Focus()
        End If
    End Sub

    Private Sub txtPaymentCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaymentCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Search = Trim(txtPaymentCode.Text)
            Call cmdpaymentcodeHelp_Click(sender, e)
        End If
    End Sub

    Private Sub cmdpaymentcodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpaymentcodeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(PAYMENTCODE,'') AS  PAYMENTCODE,ISNULL(PAYMENTNAME,'') AS PAYMENTNAME FROM PaymentModeMaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(Subpaystatus,'') = 'YES'"
        End If
        vform.Field = "PAYMENTCODE,PAYMENTNAME"
        vform.vFormatstring = "            PAYMENT CODE            |                  PAYMENT NAME                             "
        vform.vCaption = "PAYMENT MODE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtPaymentCode.Text = Trim(vform.keyfield & "")
            Call txtPaymentCode_Validated(txtPaymentCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.lbl_Frez.Visible = False
        Me.lbl_Frez.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze [F8]"
        Cmd_Add.Text = "Add [F7]"
        txtSubPaymentcode.ReadOnly = False
        cmdPayment.Enabled = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txtSubPaymentcode.Focus()
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim strSQL As String
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            strSQL = " INSERT INTO subpaymentmode (Subpaymentcode,Subpaymentname,paymentcode,PaymentName,accountin,accountdesc,freeze,adduser,adddate)"
            strSQL = strSQL & "VALUES ( '" & Trim(txtSubPaymentcode.Text) & "','" & Replace(Trim(txtSubPaymentName.Text), "'", "") & "','" & Trim(txtPaymentCode.Text) & "','" & Trim(txtPaymentname.Text) & "',"
            strSQL = strSQL & "'" & Trim(TxtAccIn.Text) & "','" & Replace(Trim(txtAccName.Text), "'", "") & "','N','" & Trim(gUsername) & "','" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "')"
            gconnection.dataOperation(1, strSQL, "subpaymentmode")
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                If Me.lbl_Frez.Visible = True Then
                    MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                End If
            End If
            If boolchk = False Then Exit Sub
            strSQL = "UPDATE  subpaymentmode "
            strSQL = strSQL & " SET Subpaymentname='" & Replace(Trim(txtSubPaymentName.Text), "'", "") & "',paymentcode='" & Trim(txtPaymentCode.Text) & "',PaymentName='" & Trim(txtPaymentname.Text) & "',accountin= '" & Trim(TxtAccIn.Text) & "',"
            strSQL = strSQL & "accountdesc='" & Replace(Trim(txtAccName.Text), "'", "") & "',adduser='" & Trim(gUsername) & "',adddate='" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "',freeze='N'"
            strSQL = strSQL & " WHERE Subpaymentcode = '" & Trim(txtSubPaymentcode.Text) & "'"
            gconnection.dataOperation(2, strSQL, "subpaymentmode")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  subpaymentmode "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "'"
            sqlstring = sqlstring & " WHERE Subpaymentcode = '" & Trim(txtSubPaymentcode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "subpaymentmode")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  subpaymentmode "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "'"
            sqlstring = sqlstring & " WHERE Subpaymentcode = '" & Trim(txtSubPaymentcode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "subpaymentmode")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " From Subpaymentmode"
        Gheader = "SUBPAYMENTMODE MASTER"
        FrReport.SsGridReport.SetText(2, 1, "SUBPAYMENTCODE")
        FrReport.SsGridReport.SetText(3, 1, 15)
        FrReport.SsGridReport.SetText(2, 2, "SUBPAYMENTNAME")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "PAYMENTCODE")
        FrReport.SsGridReport.SetText(3, 3, 15)
        FrReport.SsGridReport.SetText(2, 4, "PAYMENTNAME")
        FrReport.SsGridReport.SetText(3, 4, 35)
        FrReport.SsGridReport.SetText(2, 5, "ACCOUNTIN")
        FrReport.SsGridReport.SetText(3, 5, 15)
        FrReport.SsGridReport.SetText(2, 6, "ACCOUNTDESC")
        FrReport.SsGridReport.SetText(3, 6, 35)
        FrReport.SsGridReport.SetText(2, 7, "FREEZE")
        FrReport.SsGridReport.SetText(3, 7, 5)
        FrReport.Show()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
End Class
