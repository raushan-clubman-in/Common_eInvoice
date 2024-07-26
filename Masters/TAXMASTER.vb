Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Text.RegularExpressions

Public Class FRM_BC_TAXMASTER
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_TaxCode As System.Windows.Forms.TextBox
    Friend WithEvents Txt_TaxPercentage As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_TypeofTax As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_GLAcIn As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_GLAcHelp As System.Windows.Forms.Button
    Friend WithEvents Txt_GLAcDesc As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_SubledgerCode As System.Windows.Forms.Label
    Friend WithEvents Cmd_SlCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Txt_SlDesc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_SlCode As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Cmd_TaxCodeHelp As System.Windows.Forms.Button
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents CmdFreeze As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_TaxDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmdexport As System.Windows.Forms.Button
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cmd_inputSlCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Txt_inputSlDesc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_inputSlCode As System.Windows.Forms.TextBox
    Friend WithEvents Txt_inputGLAcDesc As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_inputGLAcHelp As System.Windows.Forms.Button
    Friend WithEvents Txt_inputGLAcIn As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdcrystal As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_BC_TAXMASTER))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txt_TaxCode = New System.Windows.Forms.TextBox
        Me.Txt_TaxPercentage = New System.Windows.Forms.TextBox
        Me.Cmb_TypeofTax = New System.Windows.Forms.ComboBox
        Me.Txt_GLAcIn = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Cmd_inputSlCodeHelp = New System.Windows.Forms.Button
        Me.Txt_inputSlDesc = New System.Windows.Forms.TextBox
        Me.Txt_inputSlCode = New System.Windows.Forms.TextBox
        Me.Txt_inputGLAcDesc = New System.Windows.Forms.TextBox
        Me.Cmd_inputGLAcHelp = New System.Windows.Forms.Button
        Me.Txt_inputGLAcIn = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_TaxDesc = New System.Windows.Forms.TextBox
        Me.Lbl_SubledgerCode = New System.Windows.Forms.Label
        Me.Cmd_SlCodeHelp = New System.Windows.Forms.Button
        Me.Txt_SlDesc = New System.Windows.Forms.TextBox
        Me.Txt_SlCode = New System.Windows.Forms.TextBox
        Me.Cmd_TaxCodeHelp = New System.Windows.Forms.Button
        Me.Txt_GLAcDesc = New System.Windows.Forms.TextBox
        Me.Cmd_GLAcHelp = New System.Windows.Forms.Button
        Me.Lbl_Freeze = New System.Windows.Forms.Label
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.btn_browse = New System.Windows.Forms.Button
        Me.cmdcrystal = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.CmdFreeze = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexport = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.frmbut.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAX MASTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TAX CODE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TAX PERCENTAGE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TYPE OF TAX :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "TAX ACCT IN :"
        '
        'Txt_TaxCode
        '
        Me.Txt_TaxCode.BackColor = System.Drawing.Color.Wheat
        Me.Txt_TaxCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_TaxCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TaxCode.Location = New System.Drawing.Point(162, 24)
        Me.Txt_TaxCode.MaxLength = 15
        Me.Txt_TaxCode.Name = "Txt_TaxCode"
        Me.Txt_TaxCode.Size = New System.Drawing.Size(112, 21)
        Me.Txt_TaxCode.TabIndex = 6
        Me.Txt_TaxCode.Text = ""
        '
        'Txt_TaxPercentage
        '
        Me.Txt_TaxPercentage.BackColor = System.Drawing.Color.Wheat
        Me.Txt_TaxPercentage.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TaxPercentage.Location = New System.Drawing.Point(161, 88)
        Me.Txt_TaxPercentage.MaxLength = 6
        Me.Txt_TaxPercentage.Name = "Txt_TaxPercentage"
        Me.Txt_TaxPercentage.Size = New System.Drawing.Size(80, 21)
        Me.Txt_TaxPercentage.TabIndex = 8
        Me.Txt_TaxPercentage.Text = ""
        '
        'Cmb_TypeofTax
        '
        Me.Cmb_TypeofTax.BackColor = System.Drawing.Color.Wheat
        Me.Cmb_TypeofTax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_TypeofTax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_TypeofTax.Items.AddRange(New Object() {"VAT", "SERVICE TAX", "LUXURY TAX", "CGST", "SGST", "CGST CESS", "SGST CESS"})
        Me.Cmb_TypeofTax.Location = New System.Drawing.Point(161, 120)
        Me.Cmb_TypeofTax.Name = "Cmb_TypeofTax"
        Me.Cmb_TypeofTax.Size = New System.Drawing.Size(136, 23)
        Me.Cmb_TypeofTax.TabIndex = 9
        '
        'Txt_GLAcIn
        '
        Me.Txt_GLAcIn.BackColor = System.Drawing.Color.Wheat
        Me.Txt_GLAcIn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_GLAcIn.Location = New System.Drawing.Point(163, 152)
        Me.Txt_GLAcIn.MaxLength = 10
        Me.Txt_GLAcIn.Name = "Txt_GLAcIn"
        Me.Txt_GLAcIn.Size = New System.Drawing.Size(136, 21)
        Me.Txt_GLAcIn.TabIndex = 10
        Me.Txt_GLAcIn.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Cmd_inputSlCodeHelp)
        Me.GroupBox1.Controls.Add(Me.Txt_inputSlDesc)
        Me.GroupBox1.Controls.Add(Me.Txt_inputSlCode)
        Me.GroupBox1.Controls.Add(Me.Txt_inputGLAcDesc)
        Me.GroupBox1.Controls.Add(Me.Cmd_inputGLAcHelp)
        Me.GroupBox1.Controls.Add(Me.Txt_inputGLAcIn)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_TaxDesc)
        Me.GroupBox1.Controls.Add(Me.Lbl_SubledgerCode)
        Me.GroupBox1.Controls.Add(Me.Cmd_SlCodeHelp)
        Me.GroupBox1.Controls.Add(Me.Txt_SlDesc)
        Me.GroupBox1.Controls.Add(Me.Txt_SlCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_TaxCode)
        Me.GroupBox1.Controls.Add(Me.Cmd_TaxCodeHelp)
        Me.GroupBox1.Controls.Add(Me.Txt_TaxPercentage)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Cmb_TypeofTax)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_GLAcDesc)
        Me.GroupBox1.Controls.Add(Me.Cmd_GLAcHelp)
        Me.GroupBox1.Controls.Add(Me.Txt_GLAcIn)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(218, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 303)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 17)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "INPUT SUBLEDGER CODE :"
        Me.Label7.Visible = False
        '
        'Cmd_inputSlCodeHelp
        '
        Me.Cmd_inputSlCodeHelp.BackgroundImage = CType(resources.GetObject("Cmd_inputSlCodeHelp.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_inputSlCodeHelp.Location = New System.Drawing.Point(303, 243)
        Me.Cmd_inputSlCodeHelp.Name = "Cmd_inputSlCodeHelp"
        Me.Cmd_inputSlCodeHelp.Size = New System.Drawing.Size(40, 23)
        Me.Cmd_inputSlCodeHelp.TabIndex = 124
        Me.Cmd_inputSlCodeHelp.Visible = False
        '
        'Txt_inputSlDesc
        '
        Me.Txt_inputSlDesc.BackColor = System.Drawing.Color.Wheat
        Me.Txt_inputSlDesc.Enabled = False
        Me.Txt_inputSlDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_inputSlDesc.Location = New System.Drawing.Point(349, 243)
        Me.Txt_inputSlDesc.MaxLength = 50
        Me.Txt_inputSlDesc.Name = "Txt_inputSlDesc"
        Me.Txt_inputSlDesc.Size = New System.Drawing.Size(184, 21)
        Me.Txt_inputSlDesc.TabIndex = 123
        Me.Txt_inputSlDesc.Text = ""
        Me.Txt_inputSlDesc.Visible = False
        '
        'Txt_inputSlCode
        '
        Me.Txt_inputSlCode.BackColor = System.Drawing.Color.Wheat
        Me.Txt_inputSlCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_inputSlCode.Location = New System.Drawing.Point(164, 243)
        Me.Txt_inputSlCode.MaxLength = 10
        Me.Txt_inputSlCode.Name = "Txt_inputSlCode"
        Me.Txt_inputSlCode.Size = New System.Drawing.Size(136, 21)
        Me.Txt_inputSlCode.TabIndex = 122
        Me.Txt_inputSlCode.Text = ""
        Me.Txt_inputSlCode.Visible = False
        '
        'Txt_inputGLAcDesc
        '
        Me.Txt_inputGLAcDesc.BackColor = System.Drawing.Color.Wheat
        Me.Txt_inputGLAcDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_inputGLAcDesc.Location = New System.Drawing.Point(349, 211)
        Me.Txt_inputGLAcDesc.Name = "Txt_inputGLAcDesc"
        Me.Txt_inputGLAcDesc.Size = New System.Drawing.Size(184, 21)
        Me.Txt_inputGLAcDesc.TabIndex = 120
        Me.Txt_inputGLAcDesc.Text = ""
        '
        'Cmd_inputGLAcHelp
        '
        Me.Cmd_inputGLAcHelp.BackgroundImage = CType(resources.GetObject("Cmd_inputGLAcHelp.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_inputGLAcHelp.Location = New System.Drawing.Point(302, 211)
        Me.Cmd_inputGLAcHelp.Name = "Cmd_inputGLAcHelp"
        Me.Cmd_inputGLAcHelp.Size = New System.Drawing.Size(40, 23)
        Me.Cmd_inputGLAcHelp.TabIndex = 121
        '
        'Txt_inputGLAcIn
        '
        Me.Txt_inputGLAcIn.BackColor = System.Drawing.Color.Wheat
        Me.Txt_inputGLAcIn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_inputGLAcIn.Location = New System.Drawing.Point(164, 211)
        Me.Txt_inputGLAcIn.MaxLength = 10
        Me.Txt_inputGLAcIn.Name = "Txt_inputGLAcIn"
        Me.Txt_inputGLAcIn.Size = New System.Drawing.Size(136, 21)
        Me.Txt_inputGLAcIn.TabIndex = 119
        Me.Txt_inputGLAcIn.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 17)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "INPUT TAX ACCT IN :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "TAX DESCRIPTION :"
        '
        'Txt_TaxDesc
        '
        Me.Txt_TaxDesc.BackColor = System.Drawing.Color.Wheat
        Me.Txt_TaxDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_TaxDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TaxDesc.Location = New System.Drawing.Point(162, 56)
        Me.Txt_TaxDesc.MaxLength = 50
        Me.Txt_TaxDesc.Name = "Txt_TaxDesc"
        Me.Txt_TaxDesc.Size = New System.Drawing.Size(344, 21)
        Me.Txt_TaxDesc.TabIndex = 117
        Me.Txt_TaxDesc.Text = ""
        '
        'Lbl_SubledgerCode
        '
        Me.Lbl_SubledgerCode.AutoSize = True
        Me.Lbl_SubledgerCode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SubledgerCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SubledgerCode.Location = New System.Drawing.Point(19, 184)
        Me.Lbl_SubledgerCode.Name = "Lbl_SubledgerCode"
        Me.Lbl_SubledgerCode.Size = New System.Drawing.Size(129, 17)
        Me.Lbl_SubledgerCode.TabIndex = 115
        Me.Lbl_SubledgerCode.Text = "SUBLEDGER CODE :"
        Me.Lbl_SubledgerCode.Visible = False
        '
        'Cmd_SlCodeHelp
        '
        Me.Cmd_SlCodeHelp.BackgroundImage = CType(resources.GetObject("Cmd_SlCodeHelp.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_SlCodeHelp.Location = New System.Drawing.Point(302, 184)
        Me.Cmd_SlCodeHelp.Name = "Cmd_SlCodeHelp"
        Me.Cmd_SlCodeHelp.Size = New System.Drawing.Size(40, 23)
        Me.Cmd_SlCodeHelp.TabIndex = 110
        Me.Cmd_SlCodeHelp.Visible = False
        '
        'Txt_SlDesc
        '
        Me.Txt_SlDesc.BackColor = System.Drawing.Color.Wheat
        Me.Txt_SlDesc.Enabled = False
        Me.Txt_SlDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SlDesc.Location = New System.Drawing.Point(348, 184)
        Me.Txt_SlDesc.MaxLength = 50
        Me.Txt_SlDesc.Name = "Txt_SlDesc"
        Me.Txt_SlDesc.Size = New System.Drawing.Size(184, 21)
        Me.Txt_SlDesc.TabIndex = 109
        Me.Txt_SlDesc.Text = ""
        Me.Txt_SlDesc.Visible = False
        '
        'Txt_SlCode
        '
        Me.Txt_SlCode.BackColor = System.Drawing.Color.Wheat
        Me.Txt_SlCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_SlCode.Location = New System.Drawing.Point(163, 184)
        Me.Txt_SlCode.MaxLength = 10
        Me.Txt_SlCode.Name = "Txt_SlCode"
        Me.Txt_SlCode.Size = New System.Drawing.Size(136, 21)
        Me.Txt_SlCode.TabIndex = 108
        Me.Txt_SlCode.Text = ""
        Me.Txt_SlCode.Visible = False
        '
        'Cmd_TaxCodeHelp
        '
        Me.Cmd_TaxCodeHelp.BackgroundImage = CType(resources.GetObject("Cmd_TaxCodeHelp.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_TaxCodeHelp.Location = New System.Drawing.Point(281, 24)
        Me.Cmd_TaxCodeHelp.Name = "Cmd_TaxCodeHelp"
        Me.Cmd_TaxCodeHelp.Size = New System.Drawing.Size(40, 23)
        Me.Cmd_TaxCodeHelp.TabIndex = 83
        '
        'Txt_GLAcDesc
        '
        Me.Txt_GLAcDesc.BackColor = System.Drawing.Color.Wheat
        Me.Txt_GLAcDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_GLAcDesc.Location = New System.Drawing.Point(348, 152)
        Me.Txt_GLAcDesc.Name = "Txt_GLAcDesc"
        Me.Txt_GLAcDesc.Size = New System.Drawing.Size(184, 21)
        Me.Txt_GLAcDesc.TabIndex = 40
        Me.Txt_GLAcDesc.Text = ""
        '
        'Cmd_GLAcHelp
        '
        Me.Cmd_GLAcHelp.BackgroundImage = CType(resources.GetObject("Cmd_GLAcHelp.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_GLAcHelp.Location = New System.Drawing.Point(301, 152)
        Me.Cmd_GLAcHelp.Name = "Cmd_GLAcHelp"
        Me.Cmd_GLAcHelp.Size = New System.Drawing.Size(40, 23)
        Me.Cmd_GLAcHelp.TabIndex = 41
        '
        'Lbl_Freeze
        '
        Me.Lbl_Freeze.AutoSize = True
        Me.Lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Freeze.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Freeze.Location = New System.Drawing.Point(590, 38)
        Me.Lbl_Freeze.Name = "Lbl_Freeze"
        Me.Lbl_Freeze.Size = New System.Drawing.Size(197, 31)
        Me.Lbl_Freeze.TabIndex = 86
        Me.Lbl_Freeze.Text = "RECORD FREEZED"
        Me.Lbl_Freeze.Visible = False
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.btn_browse)
        Me.frmbut.Controls.Add(Me.cmdcrystal)
        Me.frmbut.Controls.Add(Me.cmdexit)
        Me.frmbut.Controls.Add(Me.CmdView)
        Me.frmbut.Controls.Add(Me.CmdFreeze)
        Me.frmbut.Controls.Add(Me.CmdAdd)
        Me.frmbut.Controls.Add(Me.CmdClear)
        Me.frmbut.Location = New System.Drawing.Point(860, 102)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(147, 402)
        Me.frmbut.TabIndex = 87
        Me.frmbut.TabStop = False
        '
        'btn_browse
        '
        Me.btn_browse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Image = CType(resources.GetObject("btn_browse.Image"), System.Drawing.Image)
        Me.btn_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_browse.Location = New System.Drawing.Point(5, 286)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(137, 50)
        Me.btn_browse.TabIndex = 160
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdcrystal
        '
        Me.cmdcrystal.BackColor = System.Drawing.Color.Transparent
        Me.cmdcrystal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcrystal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcrystal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdcrystal.Image = CType(resources.GetObject("cmdcrystal.Image"), System.Drawing.Image)
        Me.cmdcrystal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdcrystal.Location = New System.Drawing.Point(5, 232)
        Me.cmdcrystal.Name = "cmdcrystal"
        Me.cmdcrystal.Size = New System.Drawing.Size(137, 50)
        Me.cmdcrystal.TabIndex = 25
        Me.cmdcrystal.Text = "&Crystal"
        Me.cmdcrystal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Transparent
        Me.cmdexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdexit.Location = New System.Drawing.Point(8, 336)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(137, 50)
        Me.cmdexit.TabIndex = 21
        Me.cmdexit.Text = "&Exit [F11]"
        Me.cmdexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.Transparent
        Me.CmdView.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdView.Location = New System.Drawing.Point(5, 178)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(137, 50)
        Me.CmdView.TabIndex = 20
        Me.CmdView.Text = "&View[F9]"
        Me.CmdView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdFreeze
        '
        Me.CmdFreeze.BackColor = System.Drawing.Color.Transparent
        Me.CmdFreeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdFreeze.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdFreeze.Image = CType(resources.GetObject("CmdFreeze.Image"), System.Drawing.Image)
        Me.CmdFreeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdFreeze.Location = New System.Drawing.Point(5, 124)
        Me.CmdFreeze.Name = "CmdFreeze"
        Me.CmdFreeze.Size = New System.Drawing.Size(137, 50)
        Me.CmdFreeze.TabIndex = 19
        Me.CmdFreeze.Text = "&Freeze[F8]"
        Me.CmdFreeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdAdd
        '
        Me.CmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.CmdAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdd.Location = New System.Drawing.Point(5, 70)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(137, 50)
        Me.CmdAdd.TabIndex = 17
        Me.CmdAdd.Text = "&Add [F7]"
        Me.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.Transparent
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdClear.Location = New System.Drawing.Point(5, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(137, 50)
        Me.CmdClear.TabIndex = 18
        Me.CmdClear.Text = "&Clear [F6]"
        Me.CmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdexport
        '
        Me.cmdexport.BackColor = System.Drawing.Color.Transparent
        Me.cmdexport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdexport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdexport.Location = New System.Drawing.Point(864, -18)
        Me.cmdexport.Name = "cmdexport"
        Me.cmdexport.Size = New System.Drawing.Size(137, 50)
        Me.cmdexport.TabIndex = 23
        Me.cmdexport.Text = "&Export[F12]"
        Me.cmdexport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdexport.Visible = False
        '
        'FRM_BC_TAXMASTER
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.ControlBox = False
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.cmdexport)
        Me.Controls.Add(Me.Lbl_Freeze)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "FRM_BC_TAXMASTER"
        Me.Text = "TAX MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.frmbut.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim vconn As New GlobalClass
    Dim Gr As String
    Dim slcodestatus, inputslcodestatus As Boolean
    Dim costcentercodestatus As Boolean
    Private Sub TAXMASTER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cmb_TypeofTax.SelectedIndex = 0
        Me.CmdFreeze.Enabled = False
        Txt_TaxCode.Focus()
        CmdFreeze.Text = "Freeze[F8]"
    End Sub


    Private Sub Txt_TaxCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_TaxCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If (Trim(Txt_TaxCode.Text)) <> "" Then
                Txt_TaxCode_Validated(sender, e)
            Else
                Call Me.Cmd_TaxCodeHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub Txt_TaxPercentage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_TaxPercentage.KeyPress
        'getNumeric(e)
        'If e.KeyChar <> ChrW(Keys.Back) Then
        '    If Char.IsNumber(e.KeyChar) Then
        '    Else
        '        e.Handled = True
        '        'MsgBox(" Numbers only ")
        '    End If
        'End If
        If Asc(e.KeyChar) = 13 Then

            If Val(Txt_TaxPercentage.Text) > 100 Then
                MsgBox("Percentage Should be Less than 100", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Me.Text)
                Txt_TaxPercentage.Text = ""
                Txt_TaxPercentage.Focus()
                Exit Sub
            End If
            Cmb_TypeofTax.Focus()
        End If
    End Sub

    Private Sub Cmb_TypeofTax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_TypeofTax.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Txt_GLAcIn.Focus()
        End If
    End Sub

    Private Sub Txt_GLAcIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_GLAcIn.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(Me.Txt_GLAcIn.Text) <> "" Then
                Txt_GlAcin_Validated(sender, e)
            Else
                Call Cmd_GLAcHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub Txt_SlCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_SlCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Txt_SlCode_Validated(sender, e)
        End If
    End Sub

    Private Sub Txt_TaxCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_TaxCode.Validated
        Dim sqlstring As String
        If Trim(Me.Txt_TaxCode.Text) = "" Then
            Me.Txt_TaxCode.Focus()
            Exit Sub
        End If
        sqlstring = "select ISNULL(freezeflag,'N') AS freezeflag ,ISNULL(INPUTTAXACCOUNTIN,'') AS INPUTTAXACCOUNTIN ,ISNULL(inputtaxaccountinDESC,'') AS inputtaxaccountinDESC ,ISNULL(taxcode,'') AS taxcode,ISNULL(TaxPercentage,0) AS TaxPercentage,ISNULL(Taxdesc,'') AS Taxdesc ,ISNULL(typeoftax,'') AS typeoftax,ISNULL(GlAccountin,'') AS GlAccountin,ISNULL(GLAccountDesc,'') AS GLAccountDesc,ISNULL(SUBLEDGERCODE,'') AS SUBLEDGERCODE ,ISNULL(SUBLEDGERDESC,'') AS SUBLEDGERDESC  from accountstaxmaster where taxcode = '" & Trim(Txt_TaxCode.Text) & "'"
        vconn.getDataSet(sqlstring, "accountstaxmaster")
        If gdataset.Tables("accountstaxmaster").Rows.Count > 0 Then
            Txt_TaxCode.Text = Trim(UCase(gdataset.Tables("accountstaxmaster").Rows(0).Item("taxcode")))
            Txt_TaxPercentage.Text = Trim(gdataset.Tables("accountstaxmaster").Rows(0).Item("TaxPercentage"))
            Txt_TaxDesc.Text = Trim(gdataset.Tables("accountstaxmaster").Rows(0).Item("Taxdesc"))
            Cmb_TypeofTax.Text = Trim(gdataset.Tables("accountstaxmaster").Rows(0).Item("typeoftax"))
            Txt_GLAcIn.Text = Trim(UCase(gdataset.Tables("accountstaxmaster").Rows(0).Item("GlAccountin")))
            Txt_GLAcDesc.Text = Trim(UCase(gdataset.Tables("accountstaxmaster").Rows(0).Item("GLAccountDesc")))
            Txt_inputGLAcIn.Text = Trim(UCase(gdataset.Tables("accountstaxmaster").Rows(0).Item("INPUTTAXACCOUNTIN")))
            Txt_inputGLAcDesc.Text = Trim(UCase(gdataset.Tables("accountstaxmaster").Rows(0).Item("inputtaxaccountinDESC")))
            If Trim(UCase(gdataset.Tables("accountstaxmaster").Rows(0).Item("SUBLEDGERCODE"))) <> "" Then
                Txt_SlCode.Visible = True
                Txt_SlDesc.Visible = True
                Cmd_SlCodeHelp.Visible = True
                Lbl_SubledgerCode.Visible = True
                Txt_SlCode.Text = Trim(UCase(gdataset.Tables("accountstaxmaster").Rows(0).Item("SUBLEDGERCODE")))
                Txt_SlDesc.Text = Trim(UCase(gdataset.Tables("accountstaxmaster").Rows(0).Item("SUBLEDGERDESC")))
            Else
                Txt_SlCode.Visible = False
                Txt_SlDesc.Visible = False
                Cmd_SlCodeHelp.Visible = False
                Lbl_SubledgerCode.Visible = False
            End If

            If gdataset.Tables("accountstaxmaster").Rows(0).Item("freezeflag") = "Y" Then
                Lbl_Freeze.Visible = True
                CmdFreeze.Text = "&Unfreeze[F8]"
                Me.CmdAdd.Enabled = False
            Else
                Lbl_Freeze.Visible = False
            End If
            Txt_TaxCode.Enabled = False
            Txt_TaxPercentage.Focus()
            CmdAdd.Text = "&Update[F7]"
            CmdFreeze.Enabled = True
            Me.Txt_TaxPercentage.Focus()
        Else
            Me.Txt_TaxDesc.Focus()
        End If
    End Sub
    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim sqlstring As String
        If Mevalidate() = False Then Exit Sub
        If CmdAdd.Text = "&Add [F7]" Then
            sqlstring = "INSERT INTO accountstaxmaster(taxcode, TaxDesc,taxpercentage, typeoftax, glaccountin,glaccountdesc, "
            sqlstring = sqlstring & "SUBLEDGERCODE,SUBLEDGERDESC,COSTCENTERCODE,COSTCENTERDESC, "
            sqlstring = sqlstring & " adduserid, adddatetime, updateuserid, updatedatetime, "
            sqlstring = sqlstring & " freezeflag, "
            sqlstring = sqlstring & " freezeuserid, freezedatetime ,INPUTTAXACCOUNTIN,inputtaxaccountinDESC,INPUTTAXSLCODEIN,inputtaxSLDESC) "
            sqlstring = sqlstring & " values ('" & Trim(Txt_TaxCode.Text) & "','" & Trim(Me.Txt_TaxDesc.Text) & "'," & Trim(Txt_TaxPercentage.Text) & ", '" & Trim(Cmb_TypeofTax.Text) & "','"
            sqlstring = sqlstring & Txt_GLAcIn.Text & "', '" & Txt_GLAcDesc.Text & "','" & Txt_SlCode.Text & "', '" & Txt_SlDesc.Text & "','', '','"
            sqlstring = sqlstring & gUsername & "', '" & Format(DateValue(Now), "dd-MMM-yyyy") & "', '', '', "
            sqlstring = sqlstring & "'N','','','" & Trim(Me.Txt_inputGLAcIn.Text) & "','" & Trim(Me.Txt_inputGLAcDesc.Text) & "','" & Trim(Me.Txt_inputSlCode.Text) & "','" & Trim(Me.Txt_inputSlDesc.Text) & "' )"
            vconn.dataOperation(1, sqlstring)
        Else
            sqlstring = "update accountstaxmaster set  taxcode = '" & Trim(Txt_TaxCode.Text) & "',"
            sqlstring = sqlstring & " taxpercentage = " & Txt_TaxPercentage.Text & ", typeoftax = '" & Trim(Cmb_TypeofTax.Text) & "', glaccountin= '" & Trim(Txt_GLAcIn.Text) & "', glaccountdesc = '" & Txt_GLAcDesc.Text & "', Taxdesc='" & Trim(Me.Txt_TaxDesc.Text) & "',"
            sqlstring = sqlstring & " SUBLEDGERCODE = '" & Txt_SlCode.Text & "', SUBLEDGERDESC = '" & Txt_SlDesc.Text & "', COSTCENTERCODE = ' ', COSTCENTERDESC='', "
            sqlstring = sqlstring & "adduserid ='',adddatetime ='', updateuserid ='" & gUsername & "', updatedatetime = '" & Format(DateValue(Now), "dd-MMM-yyyy") & "'"
            sqlstring = sqlstring & ", freezeflag = 'N', freezeuserid = '', freezedatetime = ''"
            sqlstring = sqlstring & ",INPUTTAXACCOUNTIN='" & Trim(Me.Txt_inputGLAcIn.Text) & "',inputtaxaccountinDESC='" & Trim(Me.Txt_inputGLAcDesc.Text) & "',INPUTTAXSLCODEIN='" & Trim(Me.Txt_inputSlCode.Text) & "',inputtaxSLDESC='" & Trim(Me.Txt_inputSlDesc.Text) & "'"
            sqlstring = sqlstring & " where taxcode = '" & Trim(Txt_TaxCode.Text) & "'"
            vconn.dataOperation(2, sqlstring)

            'LOG TABLE
            sqlstring = "INSERT INTO accountstaxmaster_LOG(taxcode, TaxDesc,taxpercentage, typeoftax, glaccountin,glaccountdesc, "
            sqlstring = sqlstring & "SUBLEDGERCODE,SUBLEDGERDESC,COSTCENTERCODE,COSTCENTERDESC, "
            sqlstring = sqlstring & " adduserid, adddatetime, updateuserid, updatedatetime, "
            sqlstring = sqlstring & " freezeflag, "
            sqlstring = sqlstring & " freezeuserid, freezedatetime,INPUTTAXACCOUNTIN,inputtaxaccountinDESC,INPUTTAXSLCODEIN,inputtaxSLDESC ) "
            sqlstring = sqlstring & " values ('" & Trim(Txt_TaxCode.Text) & "','" & Trim(Me.Txt_TaxDesc.Text) & "'," & Trim(Txt_TaxPercentage.Text) & ", '" & Trim(Cmb_TypeofTax.Text) & "','"
            sqlstring = sqlstring & Txt_GLAcIn.Text & "', '" & Txt_GLAcDesc.Text & "','" & Txt_SlCode.Text & "', '" & Txt_SlDesc.Text & "','', '','"
            sqlstring = sqlstring & gUsername & "', '" & Format(DateValue(Now), "dd-MMM-yyyy") & "', '" & gUsername & "', '" & Format(DateValue(Now), "dd-MMM-yyyy") & "', "
            sqlstring = sqlstring & "'N','','' ,'" & Trim(Me.Txt_inputGLAcIn.Text) & "','" & Trim(Me.Txt_inputGLAcDesc.Text) & "','" & Trim(Me.Txt_inputSlCode.Text) & "','" & Trim(Me.Txt_inputSlDesc.Text) & "')"
            vconn.dataOperation(2, sqlstring)



            MessageBox.Show("Record Updated Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Call CmdClear_Click(sender, e)
        Txt_TaxCode.Enabled = True
        Txt_TaxCode.Focus()
    End Sub

    Private Function Mevalidate() As Boolean
        Mevalidate = True
        If Trim(Txt_TaxCode.Text) = "" Then
            Mevalidate = False
            MsgBox("Tax Code cannot be blank", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, Me.Text)
            Txt_TaxCode.Focus()
            Exit Function
        End If
        If Trim(Txt_TaxDesc.Text) = "" Then
            Mevalidate = False
            MsgBox("Tax Description cannot be blank", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, Me.Text)
            Txt_TaxDesc.Focus()
            Exit Function
        End If
        'Mohan Hided 29072013
        'If Val(Txt_TaxPercentage.Text) = 0 Then
        '    Mevalidate = False
        '    MsgBox("Tax Percentage cannot be blank", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, Me.Text)
        '    Txt_TaxPercentage.Focus()
        '    Exit Function
        'End If

        'Mohan Write 29072013
        If Val(Txt_TaxPercentage.Text) < 0 Then
            Mevalidate = False
            MsgBox("Tax Percentage cannot be blank", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Me.Text)
            Txt_TaxPercentage.Focus()
            Exit Function
        End If

        If Trim(Txt_GLAcIn.Text) = "" Then
            Mevalidate = False
            MsgBox("GLAcin cannot be blank", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, Me.Text)
            Txt_GLAcIn.Focus()
            Exit Function
        End If
        If Trim(Txt_SlCode.Text) = "" And slcodestatus = True Then
            Mevalidate = False
            MsgBox("SLCODE cannot be blank", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, Me.Text)
            Txt_GLAcIn.Focus()
            Exit Function
        End If
    End Function
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Txt_TaxCode.Text = ""
        Txt_TaxCode.Enabled = True
        Cmb_TypeofTax.SelectedIndex = 0
        Txt_TaxPercentage.Text = 0
        Txt_GLAcIn.Text = ""
        Me.Cmb_TypeofTax.Enabled = True
        Txt_GLAcDesc.Text = ""
        Txt_inputGLAcIn.Text = ""
        Txt_inputGLAcDesc.Text = ""
        Me.Txt_TaxDesc.Text = ""
        Txt_SlCode.Text = ""
        Txt_SlDesc.Text = ""
        Txt_TaxCode.Focus()
        Lbl_Freeze.Visible = False
        CmdAdd.Text = "&Add [F7]"
        Lbl_SubledgerCode.Visible = False
        Txt_SlCode.Visible = False
        Cmd_SlCodeHelp.Visible = False
        Txt_SlDesc.Visible = False
        CmdFreeze.Enabled = False
        Me.CmdAdd.Enabled = True
        slcodestatus = False
        CmdFreeze.Text = "Freeze[F8]"
        Txt_TaxCode.Focus()
    End Sub
    Private Sub CmdFreeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFreeze.Click
        Dim status As Integer
        Dim sqlstring As String
        If Mevalidate() = False Then Exit Sub
        Dim ssql As String
        If CmdFreeze.Text = "Freeze[F8]" Then
            status = MsgBox("Are You Sure to Freeze the Record", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, Me.Text)
            If status = 1 Then
                sqlstring = "update accountstaxmaster set freezeflag = 'Y',FreezeUserId='" & gUsername & "',FreezeDateTime='" & Format(DateValue(Now), "dd-MMM-yyyy") & "' where taxcode = '" & Trim(Txt_TaxCode.Text) & "'"
                vconn.dataOperation(2, sqlstring)
                Lbl_Freeze.Text = "RECORD FREEZED"
                Lbl_Freeze.Visible = True
                CmdFreeze.Text = "&Unfreeze[F8]"
                Me.CmdAdd.Enabled = False
                MessageBox.Show("Record Freezed Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Exit Sub
            End If
        Else
            status = MsgBox("Are You Sure to UnFreeze the Record", MsgBoxStyle.OkCancel + MsgBoxStyle.Information, Me.Text)
            If status = 1 Then
                sqlstring = "update accountstaxmaster set freezeflag ='N',FreezeDateTime='' where taxcode = '" & Trim(Txt_TaxCode.Text) & "'"
                vconn.dataOperation(2, sqlstring)
                Lbl_Freeze.Text = "RECORD UNFREEZED"
                Lbl_Freeze.Visible = False
                CmdFreeze.Text = "&Freeze[F8]"
                Me.CmdAdd.Enabled = True
                MessageBox.Show("Record UnFreezed Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Exit Sub
            End If
        End If
        Call CmdClear_Click(sender, e)
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM accountstaxmaster"
        Gheader = "TAX MASTER"
        FrReport.SsGridReport.SetText(2, 1, "Taxcode")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(4, 1, "Code")
        FrReport.SsGridReport.SetText(8, 1, "S")

        FrReport.SsGridReport.SetText(2, 2, "TaxPercentage")
        FrReport.SsGridReport.SetText(3, 2, 6)
        FrReport.SsGridReport.SetText(4, 2, "Perc")
        FrReport.SsGridReport.SetText(8, 2, "N")

        FrReport.SsGridReport.SetText(2, 3, "TypeofTax")
        FrReport.SsGridReport.SetText(3, 3, 20)
        FrReport.SsGridReport.SetText(4, 3, "TaxType")
        FrReport.SsGridReport.SetText(8, 3, "S")

        FrReport.SsGridReport.SetText(2, 4, "GlAccountin")
        FrReport.SsGridReport.SetText(3, 4, 10)
        FrReport.SsGridReport.SetText(4, 4, "AcCode")
        FrReport.SsGridReport.SetText(8, 4, "S")

        FrReport.SsGridReport.SetText(2, 5, "GlaccountDesc")
        FrReport.SsGridReport.SetText(3, 5, 35)
        FrReport.SsGridReport.SetText(4, 5, "Description")
        FrReport.SsGridReport.SetText(8, 5, "S")

        FrReport.SsGridReport.SetText(2, 6, "SubledgerCode")
        FrReport.SsGridReport.SetText(3, 6, 10)
        FrReport.SsGridReport.SetText(4, 6, "LedCode")
        FrReport.SsGridReport.SetText(8, 6, "S")

        FrReport.SsGridReport.SetText(2, 7, "SubLedgerDesc")
        FrReport.SsGridReport.SetText(3, 7, 35)
        FrReport.SsGridReport.SetText(4, 7, "LedDescription")
        FrReport.SsGridReport.SetText(8, 7, "S")

        FrReport.SsGridReport.SetText(2, 8, "CostCenterCode")
        FrReport.SsGridReport.SetText(3, 8, 10)
        FrReport.SsGridReport.SetText(4, 8, "CC_Code")
        FrReport.SsGridReport.SetText(8, 8, "S")

        FrReport.SsGridReport.SetText(2, 9, "CostCenterDesc")
        FrReport.SsGridReport.SetText(3, 9, 35)
        FrReport.SsGridReport.SetText(4, 9, "CC_Description")
        FrReport.SsGridReport.SetText(8, 9, "S")

        FrReport.Show()
    End Sub

    Private Sub Txt_TaxCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_TaxCode.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If Txt_TaxCode.Text = "" Then
        '        Call Me.Cmd_TaxCodeHelp_Click(sender, e)
        '    End If
        'End If
        If e.KeyCode = Keys.F4 Then
            Call Cmd_TaxCodeHelp_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub Txt_GlAcin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_GLAcIn.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If Txt_GLAcIn.Text = "" Then
        '        Call Cmd_GLAcHelp_Click(sender, e)
        '    End If
        'End If

        If e.KeyCode = Keys.F4 Then
            Call Cmd_GLAcHelp_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub Txt_SlCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_SlCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call Cmd_SlCodeHelp_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub Cmd_TaxCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_TaxCodeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT TaxCode,TypeOfTax,taxdesc,cast(taxpercentage as varchar(10)) as taxpercaentage FROM accountstaxmaster"
        M_WhereCondition = ""
        vform.Field = "TaxCode,TypeOfTax,taxdesc"
        'vform.vFormatstring = " TAXCODE                       |TAX TYPE                  |TAX DESC                  |TAX PERCENTAGE "
        vform.vCaption = "TAX MASTER HELP"
        'vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_TaxCode.Text = Trim(vform.keyfield & "")
            Txt_TaxCode_Validated(sender, e)
            Txt_TaxDesc.Focus()
        Else
            Me.Txt_TaxCode.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub Txt_GlAcin_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_GLAcIn.Validated
        Dim sqlstring As String
        If Trim(Me.Txt_GLAcIn.Text) = "" Then
            Txt_GLAcIn.Text = ""
            Txt_GLAcDesc.Text = ""
            Txt_GLAcIn.Text = ""
            Txt_GLAcDesc.Text = ""
            Lbl_SubledgerCode.Visible = False
            Txt_SlCode.Visible = False
            Txt_SlCode.Text = ""
            Cmd_SlCodeHelp.Visible = False
            Txt_SlDesc.Visible = False
            Txt_SlDesc.Text = ""
            slcodestatus = False
            Me.Txt_GLAcIn.Focus()
            Me.Txt_GLAcDesc.Text = ""
        End If
        sqlstring = "select accode, acdesc,Isnull(SubLedgerFlag,'N') as SubledgerFlag from accountsglaccountmaster where accode = '" & Trim(Txt_GLAcIn.Text) & "'"
        vconn.getDataSet(sqlstring, "accountsglaccountmaster")
        If gdataset.Tables("accountsglaccountmaster").Rows.Count > 0 Then
            Txt_GLAcDesc.Text = Trim(UCase(gdataset.Tables("accountsglaccountmaster").Rows(0).Item("acdesc")))
            If Trim(UCase(gdataset.Tables("accountsglaccountmaster").Rows(0).Item("SubLedgerFlag"))) = "Y" Then
                Lbl_SubledgerCode.Visible = True
                Txt_SlCode.Visible = True
                Txt_SlCode.Text = ""
                Cmd_SlCodeHelp.Visible = True
                Txt_SlDesc.Visible = True
                Txt_SlDesc.Text = ""
                slcodestatus = True
                Txt_SlCode.Focus()
            Else
                Lbl_SubledgerCode.Visible = False
                Txt_SlCode.Visible = False
                Txt_SlCode.Text = ""
                Cmd_SlCodeHelp.Visible = False
                Txt_SlDesc.Visible = False
                Txt_SlDesc.Text = ""
                slcodestatus = False
                Me.CmdAdd.Focus()
            End If

        Else
            Txt_GLAcIn.Text = ""
            Txt_GLAcDesc.Text = ""
            Txt_GLAcIn.Text = ""
            Txt_GLAcDesc.Text = ""
            Lbl_SubledgerCode.Visible = False
            Txt_SlCode.Visible = False
            Txt_SlCode.Text = ""
            Cmd_SlCodeHelp.Visible = False
            Txt_SlDesc.Visible = False
            Txt_SlDesc.Text = ""
            slcodestatus = False
            Me.Txt_GLAcIn.Focus()
            Me.Txt_GLAcDesc.Text = ""
            Exit Sub
        End If
        gdataset.Tables("accountsglaccountmaster").Dispose()
        glaccountvalidate()
    End Sub
    Private Sub glaccountvalidate()
        Dim sqlstring As String
        sqlstring = "select slcode,slname from accountssubledgermaster where accode = '" & Trim(Txt_GLAcIn.Text) & "' AND iSNULL(FreezeFlag,'') <> 'Y' "
        vconn.getDataSet(sqlstring, "accountssubledgermaster")
        If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
            Txt_GLAcDesc.ReadOnly = True
            Lbl_SubledgerCode.Visible = True
            Txt_SlCode.Visible = True
            Txt_SlCode.Text = ""
            Cmd_SlCodeHelp.Visible = True
            Txt_SlDesc.Visible = True
            Txt_SlDesc.Text = ""
            slcodestatus = True
            Txt_SlCode.Focus()
        Else
            Txt_GLAcDesc.ReadOnly = True
            Lbl_SubledgerCode.Visible = False
            Txt_SlCode.Visible = False
            Cmd_SlCodeHelp.Visible = False
            Txt_SlDesc.Visible = False
            slcodestatus = False
            CmdAdd.Focus()
        End If
        gdataset.Tables("accountssubledgermaster").Dispose()
    End Sub


    Private Sub Cmd_GLAcHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_GLAcHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT accode,acdesc,SubLEdgerFlag FROM accountsglaccountmaster"
        M_WhereCondition = " Where Isnull(FreezeFlag,'')<>'Y'"
        vform.Field = "accode,acDesc"
        'vform.vFormatstring = "  ACCOUNT CODE|ACCOUNT DESC                                                               "
        vform.vCaption = "GENERAL LEDGER MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_GLAcIn.Text = Trim(vform.keyfield & "")
            Txt_GLAcDesc.Text = Trim(vform.keyfield1 & "")
            glaccountvalidate()
        Else
            Me.Txt_GLAcIn.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub Cmd_SlCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_SlCodeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT slcode,sldesc FROM accountssubledgermaster"
        M_WhereCondition = " where accode = '" & Trim(Txt_GLAcIn.Text) & "' and Isnull(FreezeFlag,'') <> 'Y'"
        vform.Field = "slcode,sldesc"
        'vform.vFormatstring = "  slcode|sldesc                                "
        vform.vCaption = "SUB LEDGER MASTER HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_SlCode.Text = Trim(vform.keyfield & "")
            Txt_SlDesc.Text = Trim(vform.keyfield1 & "")
            Me.CmdAdd.Focus()
        Else
            Me.Txt_GLAcIn.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub



    Private Sub Txt_SlCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_SlCode.Validated
        Dim sqlstring As String
        sqlstring = "select slcode, sldesc from accountssubledgermaster where accode = '" & Trim(Txt_GLAcIn.Text) & "' and slcode = '" & Trim(Txt_SlCode.Text) & "'"
        vconn.getDataSet(sqlstring, "accountssubledgermaster")
        If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
            Txt_SlDesc.Text = Trim(UCase(gdataset.Tables("accountssubledgermaster").Rows(0).Item("sldesc")))
            Me.CmdAdd.Focus()
        Else
            Txt_SlCode.Text = ""
            Txt_SlDesc.Text = ""
        End If
        gdataset.Tables("accountssubledgermaster").Dispose()
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        'If MsgBox("Close this form", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Me.Close()
        'Else
        'Txt_TaxCode.Focus()
        'End If
    End Sub
    Private Sub Txt_TaxDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_TaxDesc.KeyPress
        If Trim(Me.Txt_TaxDesc.Text) <> "" Then
            If Asc(e.KeyChar) = 13 Then
                Me.Txt_TaxPercentage.Focus()
            End If
        End If
    End Sub
    Private Sub TAXMASTER_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 And CmdClear.Visible Then
            Call Me.CmdClear_Click(sender, e)
        End If
        If e.KeyCode = Keys.F7 And CmdAdd.Visible Then
            Call Me.CmdAdd_Click(sender, e)
        End If
        If (e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape) And cmdexit.Visible Then
            Call Me.cmdexit_Click(sender, e)
        End If
        If e.KeyCode = Keys.F9 And CmdView.Visible Then
            Call Me.CmdView_Click(sender, e)
        End If
        If e.KeyCode = Keys.F8 And CmdFreeze.Visible Then
            Call Me.CmdFreeze_Click(sender, e)
        End If
        If e.KeyCode = Keys.F2 Then
            Me.Txt_TaxCode.Focus()
        End If
        If e.KeyCode = Keys.F12 Then
            Call Me.cmdexport_Click(sender, e)
        End If
    End Sub

    Private Sub cmdexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexport.Click
        Try
            Dim sqlstring As String
            Dim _export As New EXPORT
            _export.TABLENAME = "accountstaxmaster"
            sqlstring = "SELECT * FROM accountstaxmaster order by taxcode"
            Call _export.export_excel(sqlstring)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MsgBox("Sorry!, Export to Excel is Terminated Abnormally, Bcoz " & ex.Message.ToString(), MsgBoxStyle.OKOnly, "Error!")
        End Try

    End Sub
    Private Sub print_windows()
        Dim str As String
        Dim Viewer As New ReportViwer
        Dim r As New Rpt_AccountsTaxMaster

        str = "SELECT * FROM ACCOUNTSTAXMASTER"

        Viewer.ssql = str
        Viewer.Report = r
        Viewer.TableName = "ACCOUNTSTAXMASTER"

        Dim TXTOBJ10 As TextObject
        TXTOBJ10 = r.ReportDefinition.ReportObjects("TEXT10")
        TXTOBJ10.Text = gCompanyname

        Dim TXTOBJ11 As TextObject
        TXTOBJ11 = r.ReportDefinition.ReportObjects("TEXT11")
        TXTOBJ11.Text = gCompanyAddress(0)

        Dim TXTOBJ21 As TextObject
        TXTOBJ21 = r.ReportDefinition.ReportObjects("TEXT21")
        TXTOBJ21.Text = gCompanyAddress(1)

        Dim TXTOBJ12 As TextObject
        TXTOBJ12 = r.ReportDefinition.ReportObjects("TEXT12")
        TXTOBJ12.Text = gCompanyAddress(2)

        Dim TXTOBJ16 As TextObject
        TXTOBJ16 = r.ReportDefinition.ReportObjects("TEXT16")
        TXTOBJ16.Text = gCompanyAddress(3)


        Dim TXTOBJ17 As TextObject
        TXTOBJ17 = r.ReportDefinition.ReportObjects("TEXT17")
        TXTOBJ17.Text = gCompanyAddress(6)

        Dim TXTOBJ18 As TextObject
        TXTOBJ18 = r.ReportDefinition.ReportObjects("TEXT18")
        TXTOBJ18.Text = gCompanyAddress(4)

        Dim TXTOBJ13 As TextObject
        TXTOBJ13 = r.ReportDefinition.ReportObjects("TEXT13")
        TXTOBJ13.Text = "User Name : " & gUsername

        Dim TXTOBJ14 As TextObject
        TXTOBJ14 = r.ReportDefinition.ReportObjects("TEXT14")
        TXTOBJ14.Text = "Accounting Period : " & Format(gFinancialyearStart, "dd-MM-yyyy") & " - " & Format(gFinancialyearEnding, "dd-MM-yyyy")

        Viewer.Show()

    End Sub


    Private Sub cmdcrystal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcrystal.Click
        print_windows()
    End Sub

    Private Sub Txt_TaxCode_TextChanged(sender As Object, e As EventArgs) Handles Txt_TaxCode.TextChanged

    End Sub

    Private Sub Txt_TaxDesc_TextChanged(sender As Object, e As EventArgs) Handles Txt_TaxDesc.TextChanged

    End Sub

    Private Sub Txt_TaxPercentage_TextChanged(sender As Object, e As EventArgs) Handles Txt_TaxPercentage.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_TaxPercentage.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_TaxPercentage.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Cmb_TypeofTax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_TypeofTax.SelectedIndexChanged

    End Sub

    Private Sub Txt_GLAcIn_TextChanged(sender As Object, e As EventArgs) Handles Txt_GLAcIn.TextChanged

    End Sub

    Private Sub Txt_SlCode_TextChanged(sender As Object, e As EventArgs) Handles Txt_SlCode.TextChanged

    End Sub

    'Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
    '    brows = True
    '    Dim VIEW1 As New VIEWHDR
    '    VIEW1.Show()
    '    VIEW1.DTGRDHDR.DataSource = Nothing
    '    VIEW1.DTGRDHDR.Rows.Clear()
    '    Dim STRQUERY As String
    '    STRQUERY = "SELECT * FROM accountstaxmaster"
    '    vconn.getDataSet(STRQUERY, "authorize")

    '    Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, "", "SELECT * FROM accountstaxmaster", "TAXCODE", 1, Me.Txt_TaxCode)

    'End Sub

    'Private Sub btn_authorize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim SSQLSTR, SSQLSTR2 As String
    '    Dim USERT As Integer
    '    gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "')"
    '    vconn.getDataSet(gSQLString, "AUTHORIZELUSER")
    '    If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
    '        USERT = 1
    '    End If
    '    gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "')"
    '    vconn.getDataSet(gSQLString, "AUTHORIZELUSER")
    '    If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
    '        USERT = 2
    '    End If
    '    gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "')"
    '    vconn.getDataSet(gSQLString, "AUTHORIZELUSER")
    '    If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
    '        USERT = 3
    '    End If
    '    If USERT = 1 Then
    '        SSQLSTR2 = " SELECT * FROM accountstaxmaster  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
    '        vconn.getDataSet(SSQLSTR2, "AUTHORIZEL")
    '        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
    '            gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "')"
    '            vconn.getDataSet(gSQLString, "AUTHORIZE")
    '            If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
    '                SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
    '                vconn.getDataSet(gSQLString, "AUTHORIZELEVEL")
    '                If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
    '                    SSQLSTR2 = " SELECT * FROM accountstaxmaster  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
    '                    vconn.getDataSet(SSQLSTR2, "AUTHORIZEL")
    '                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
    '                        Dim VIEW1 As New AUTHORISATION
    '                        VIEW1.Show()
    '                        VIEW1.DTAUTH.DataSource = Nothing
    '                        VIEW1.DTAUTH.Rows.Clear()


    '                        Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE accountstaxmaster  set  ", "TAXCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 0)
    '                    End If
    '                Else
    '                    MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
    '                End If
    '            End If
    '        End If
    '    ElseIf USERT = 2 Then
    '        SSQLSTR2 = " SELECT * FROM accountstaxmaster  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
    '        vconn.getDataSet(SSQLSTR2, "AUTHORIZEL")
    '        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
    '            gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "')"
    '            vconn.getDataSet(gSQLString, "AUTHORIZE1")
    '            If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
    '                SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "'"
    '                vconn.getDataSet(gSQLString, "AUTHORIZELEVEL")
    '                If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
    '                    SSQLSTR2 = " SELECT * FROM accountstaxmaster  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
    '                    vconn.getDataSet(SSQLSTR2, "AUTHORIZEL")
    '                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
    '                        Dim VIEW1 As New AUTHORISATION
    '                        VIEW1.Show()
    '                        VIEW1.DTAUTH.DataSource = Nothing
    '                        VIEW1.DTAUTH.Rows.Clear()


    '                        Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE accountstaxmaster  set  ", "TAXCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 0)
    '                    End If
    '                End If
    '            End If
    '        End If
    '    ElseIf USERT = 3 Then
    '        SSQLSTR2 = " SELECT * FROM accountstaxmaster  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
    '        vconn.getDataSet(SSQLSTR2, "AUTHORIZEL")
    '        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
    '            gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "')"
    '            vconn.getDataSet(gSQLString, "AUTHORIZE2")
    '            If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
    '                SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='ACCOUNTS' AND FORMNAME='" & GmoduleName & "'"
    '                vconn.getDataSet(gSQLString, "AUTHORIZELEVEL")
    '                If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
    '                    SSQLSTR2 = " SELECT * FROM accountstaxmaster  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
    '                    vconn.getDataSet(SSQLSTR2, "AUTHORIZEL")
    '                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
    '                        Dim VIEW1 As New AUTHORISATION
    '                        VIEW1.Show()
    '                        VIEW1.DTAUTH.DataSource = Nothing
    '                        VIEW1.DTAUTH.Rows.Clear()
    '                        Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE accountstaxmaster  set  ", "TAXCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 0)
    '                    End If
    '                End If
    '            End If
    '        Else
    '            MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
    '        End If
    '    End If
    'End Sub

    Private Sub Cmd_inputGLAcHelp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cmd_inputGLAcHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT accode,acdesc,SubLEdgerFlag FROM accountsglaccountmaster"
        M_WhereCondition = " Where Isnull(FreezeFlag,'')<>'Y'"
        vform.Field = "accode,acDesc"
        'vform.vFormatstring = "  ACCOUNT CODE|ACCOUNT DESC                                                               "
        vform.vCaption = "GENERAL LEDGER MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_inputGLAcIn.Text = Trim(vform.keyfield & "")
            Txt_inputGLAcDesc.Text = Trim(vform.keyfield1 & "")
            Inputglaccountvalidate()
        Else
            Me.Txt_inputGLAcIn.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub Inputglaccountvalidate()
        Dim sqlstring As String
        sqlstring = "select slcode,slname from accountssubledgermaster where accode = '" & Trim(Txt_inputGLAcIn.Text) & "' AND iSNULL(FreezeFlag,'') <> 'Y' "
        vconn.getDataSet(sqlstring, "accountssubledgermaster")
        If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
            Txt_inputGLAcDesc.ReadOnly = True
            Lbl_SubledgerCode.Visible = True
            Txt_inputSlCode.Visible = True
            Txt_SlCode.Text = ""
            Cmd_inputSlCodeHelp.Visible = True
            Txt_inputSlDesc.Visible = True
            Txt_inputSlDesc.Text = ""
            inputslcodestatus = True
            Txt_inputSlCode.Focus()
        Else
            Txt_inputGLAcDesc.ReadOnly = True
            Label7.Visible = False
            Txt_inputSlCode.Visible = False
            Cmd_inputSlCodeHelp.Visible = False
            Txt_inputSlDesc.Visible = False
            inputslcodestatus = False
            CmdAdd.Focus()
        End If
        gdataset.Tables("accountssubledgermaster").Dispose()
    End Sub

    Private Sub Cmd_inputSlCodeHelp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cmd_inputSlCodeHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT slcode,sldesc FROM accountssubledgermaster"
        M_WhereCondition = " where accode = '" & Trim(Txt_inputGLAcIn.Text) & "' and Isnull(FreezeFlag,'') <> 'Y'"
        vform.Field = "slcode,sldesc"
        'vform.vFormatstring = "  slcode|sldesc                                "
        vform.vCaption = "SUB LEDGER MASTER HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_inputSlCode.Text = Trim(vform.keyfield & "")
            Txt_inputSlDesc.Text = Trim(vform.keyfield1 & "")
            Me.CmdAdd.Focus()
        Else
            Me.Txt_inputGLAcIn.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
End Class
