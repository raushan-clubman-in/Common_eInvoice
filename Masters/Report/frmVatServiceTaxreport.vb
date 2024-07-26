Imports System.Data.SqlClient
Imports System.IO
Public Class frmVatServiceTaxreport
    Inherits System.Windows.Forms.Form
    Dim pageno As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mskTodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbStax As System.Windows.Forms.RadioButton
    Friend WithEvents rdbVat As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chklist_Type As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_Taxtype As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents LstGroup As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_itemwise As System.Windows.Forms.CheckBox
    Friend WithEvents CHKBILLDETAILS As System.Windows.Forms.CheckBox
    Friend WithEvents chklist_POSlocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chk_POSlocation As System.Windows.Forms.CheckBox
    Friend WithEvents cmdexport As System.Windows.Forms.Button
    Friend WithEvents GROUPWISE As System.Windows.Forms.CheckBox
    Friend WithEvents CHKLIST_PAYMENTMODE As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Chk_PAYMENTMODE As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Chk_Membername As System.Windows.Forms.CheckBox
    Friend WithEvents chklist_Membername As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVatServiceTaxreport))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdexport = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.mskFromdate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.mskTodate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rdbStax = New System.Windows.Forms.RadioButton
        Me.rdbVat = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Chk_Taxtype = New System.Windows.Forms.CheckBox
        Me.chklist_Type = New System.Windows.Forms.CheckedListBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Chk_SelectAllGroup = New System.Windows.Forms.CheckBox
        Me.LstGroup = New System.Windows.Forms.CheckedListBox
        Me.Chk_itemwise = New System.Windows.Forms.CheckBox
        Me.CHKBILLDETAILS = New System.Windows.Forms.CheckBox
        Me.chklist_POSlocation = New System.Windows.Forms.CheckedListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Chk_POSlocation = New System.Windows.Forms.CheckBox
        Me.GROUPWISE = New System.Windows.Forms.CheckBox
        Me.Chk_PAYMENTMODE = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Chk_Membername = New System.Windows.Forms.CheckBox
        Me.chklist_Membername = New System.Windows.Forms.CheckedListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CHKLIST_PAYMENTMODE = New System.Windows.Forms.CheckedListBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdexport)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.CmdPrint)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Location = New System.Drawing.Point(80, 496)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(648, 40)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'cmdexport
        '
        Me.cmdexport.BackColor = System.Drawing.Color.Transparent
        Me.cmdexport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexport.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexport.ForeColor = System.Drawing.Color.White
        Me.cmdexport.Image = CType(resources.GetObject("cmdexport.Image"), System.Drawing.Image)
        Me.cmdexport.Location = New System.Drawing.Point(392, 8)
        Me.cmdexport.Name = "cmdexport"
        Me.cmdexport.Size = New System.Drawing.Size(104, 32)
        Me.cmdexport.TabIndex = 16
        Me.cmdexport.Text = "Export[F10]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.Transparent
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(24, 8)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 15
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.Transparent
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(272, 8)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 13
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Transparent
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(520, 8)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 14
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.Transparent
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(144, 8)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 12
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mskFromdate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mskTodate)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 456)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 40)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'mskFromdate
        '
        Me.mskFromdate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromdate.Location = New System.Drawing.Point(160, 10)
        Me.mskFromdate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskFromdate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromdate.Name = "mskFromdate"
        Me.mskFromdate.Size = New System.Drawing.Size(109, 26)
        Me.mskFromdate.TabIndex = 18
        Me.mskFromdate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(376, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 22)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "TO DATE       :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "FROM DATE :"
        '
        'mskTodate
        '
        Me.mskTodate.CustomFormat = "dd-MM-yyyy"
        Me.mskTodate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskTodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskTodate.Location = New System.Drawing.Point(504, 10)
        Me.mskTodate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskTodate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskTodate.Name = "mskTodate"
        Me.mskTodate.Size = New System.Drawing.Size(112, 26)
        Me.mskTodate.TabIndex = 19
        Me.mskTodate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rdbStax)
        Me.GroupBox3.Controls.Add(Me.rdbVat)
        Me.GroupBox3.Location = New System.Drawing.Point(920, 656)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 32)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'rdbStax
        '
        Me.rdbStax.BackColor = System.Drawing.Color.Transparent
        Me.rdbStax.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbStax.Location = New System.Drawing.Point(168, 8)
        Me.rdbStax.Name = "rdbStax"
        Me.rdbStax.Size = New System.Drawing.Size(136, 24)
        Me.rdbStax.TabIndex = 22
        Me.rdbStax.Text = "SERVICE TAX"
        '
        'rdbVat
        '
        Me.rdbVat.BackColor = System.Drawing.Color.Transparent
        Me.rdbVat.Checked = True
        Me.rdbVat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbVat.Location = New System.Drawing.Point(48, 8)
        Me.rdbVat.Name = "rdbVat"
        Me.rdbVat.Size = New System.Drawing.Size(56, 24)
        Me.rdbVat.TabIndex = 21
        Me.rdbVat.TabStop = True
        Me.rdbVat.Text = "VAT"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 24)
        Me.Label4.TabIndex = 424
        Me.Label4.Text = "TAX TYPE  :"
        '
        'Chk_Taxtype
        '
        Me.Chk_Taxtype.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Taxtype.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Taxtype.Location = New System.Drawing.Point(16, 48)
        Me.Chk_Taxtype.Name = "Chk_Taxtype"
        Me.Chk_Taxtype.Size = New System.Drawing.Size(128, 16)
        Me.Chk_Taxtype.TabIndex = 423
        Me.Chk_Taxtype.Text = "SELECT ALL"
        '
        'chklist_Type
        '
        Me.chklist_Type.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_Type.Location = New System.Drawing.Point(16, 96)
        Me.chklist_Type.Name = "chklist_Type"
        Me.chklist_Type.Size = New System.Drawing.Size(168, 151)
        Me.chklist_Type.TabIndex = 422
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(192, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 24)
        Me.Label7.TabIndex = 427
        Me.Label7.Text = "GROUP DESCRIPTION :"
        '
        'Chk_SelectAllGroup
        '
        Me.Chk_SelectAllGroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllGroup.Location = New System.Drawing.Point(192, 48)
        Me.Chk_SelectAllGroup.Name = "Chk_SelectAllGroup"
        Me.Chk_SelectAllGroup.Size = New System.Drawing.Size(152, 16)
        Me.Chk_SelectAllGroup.TabIndex = 425
        Me.Chk_SelectAllGroup.Text = "SELECT ALL "
        '
        'LstGroup
        '
        Me.LstGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LstGroup.Location = New System.Drawing.Point(192, 96)
        Me.LstGroup.Name = "LstGroup"
        Me.LstGroup.Size = New System.Drawing.Size(184, 151)
        Me.LstGroup.TabIndex = 426
        '
        'Chk_itemwise
        '
        Me.Chk_itemwise.BackColor = System.Drawing.Color.Transparent
        Me.Chk_itemwise.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_itemwise.Location = New System.Drawing.Point(48, 430)
        Me.Chk_itemwise.Name = "Chk_itemwise"
        Me.Chk_itemwise.Size = New System.Drawing.Size(160, 24)
        Me.Chk_itemwise.TabIndex = 428
        Me.Chk_itemwise.Text = "ITEMWISE [Y/N]"
        '
        'CHKBILLDETAILS
        '
        Me.CHKBILLDETAILS.BackColor = System.Drawing.Color.Transparent
        Me.CHKBILLDETAILS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKBILLDETAILS.Location = New System.Drawing.Point(328, 430)
        Me.CHKBILLDETAILS.Name = "CHKBILLDETAILS"
        Me.CHKBILLDETAILS.Size = New System.Drawing.Size(160, 24)
        Me.CHKBILLDETAILS.TabIndex = 429
        Me.CHKBILLDETAILS.Text = "BILL WISE  [Y/N]"
        '
        'chklist_POSlocation
        '
        Me.chklist_POSlocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_POSlocation.Location = New System.Drawing.Point(384, 96)
        Me.chklist_POSlocation.Name = "chklist_POSlocation"
        Me.chklist_POSlocation.Size = New System.Drawing.Size(192, 340)
        Me.chklist_POSlocation.TabIndex = 430
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(384, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 23)
        Me.Label1.TabIndex = 432
        Me.Label1.Text = "POS DESCRIPTION :"
        '
        'Chk_POSlocation
        '
        Me.Chk_POSlocation.BackColor = System.Drawing.Color.Transparent
        Me.Chk_POSlocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_POSlocation.Location = New System.Drawing.Point(384, 48)
        Me.Chk_POSlocation.Name = "Chk_POSlocation"
        Me.Chk_POSlocation.Size = New System.Drawing.Size(132, 21)
        Me.Chk_POSlocation.TabIndex = 433
        Me.Chk_POSlocation.Text = "SELECT ALL"
        '
        'GROUPWISE
        '
        Me.GROUPWISE.BackColor = System.Drawing.Color.Transparent
        Me.GROUPWISE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GROUPWISE.Location = New System.Drawing.Point(592, 429)
        Me.GROUPWISE.Name = "GROUPWISE"
        Me.GROUPWISE.Size = New System.Drawing.Size(184, 24)
        Me.GROUPWISE.TabIndex = 429
        Me.GROUPWISE.Text = "GROUP WISE [Y/N]"
        '
        'Chk_PAYMENTMODE
        '
        Me.Chk_PAYMENTMODE.BackColor = System.Drawing.Color.Transparent
        Me.Chk_PAYMENTMODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_PAYMENTMODE.Location = New System.Drawing.Point(16, 248)
        Me.Chk_PAYMENTMODE.Name = "Chk_PAYMENTMODE"
        Me.Chk_PAYMENTMODE.Size = New System.Drawing.Size(132, 16)
        Me.Chk_PAYMENTMODE.TabIndex = 436
        Me.Chk_PAYMENTMODE.Text = "SELECT ALL"
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(192, 248)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(160, 16)
        Me.CheckBox1.TabIndex = 437
        Me.CheckBox1.Text = "SELECT ALL "
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(584, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 24)
        Me.Label8.TabIndex = 442
        Me.Label8.Text = "MEMBER NAME  :"
        '
        'Chk_Membername
        '
        Me.Chk_Membername.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Membername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Membername.Location = New System.Drawing.Point(584, 48)
        Me.Chk_Membername.Name = "Chk_Membername"
        Me.Chk_Membername.Size = New System.Drawing.Size(141, 21)
        Me.Chk_Membername.TabIndex = 441
        Me.Chk_Membername.Text = "SELECT ALL"
        '
        'chklist_Membername
        '
        Me.chklist_Membername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_Membername.Location = New System.Drawing.Point(584, 96)
        Me.chklist_Membername.Name = "chklist_Membername"
        Me.chklist_Membername.Size = New System.Drawing.Size(192, 340)
        Me.chklist_Membername.TabIndex = 440
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(192, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 24)
        Me.Label6.TabIndex = 439
        Me.Label6.Text = "USER  DESCRIPTION :"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CheckedListBox1.Location = New System.Drawing.Point(192, 288)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(184, 151)
        Me.CheckedListBox1.TabIndex = 438
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 23)
        Me.Label3.TabIndex = 435
        Me.Label3.Text = "PAYMENTMODE:"
        '
        'CHKLIST_PAYMENTMODE
        '
        Me.CHKLIST_PAYMENTMODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CHKLIST_PAYMENTMODE.Location = New System.Drawing.Point(16, 288)
        Me.CHKLIST_PAYMENTMODE.Name = "CHKLIST_PAYMENTMODE"
        Me.CHKLIST_PAYMENTMODE.Size = New System.Drawing.Size(168, 151)
        Me.CHKLIST_PAYMENTMODE.TabIndex = 434
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(232, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(234, 25)
        Me.Label9.TabIndex = 443
        Me.Label9.Text = "GROUP  WISE  DETAILS"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(776, 424)
        Me.GroupBox4.TabIndex = 444
        Me.GroupBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(184, 544)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(423, 18)
        Me.Label10.TabIndex = 445
        Me.Label10.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'frmVatServiceTaxreport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(968, 676)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Chk_Membername)
        Me.Controls.Add(Me.chklist_Membername)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Chk_PAYMENTMODE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CHKLIST_PAYMENTMODE)
        Me.Controls.Add(Me.Chk_POSlocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chklist_POSlocation)
        Me.Controls.Add(Me.CHKBILLDETAILS)
        Me.Controls.Add(Me.Chk_itemwise)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Chk_SelectAllGroup)
        Me.Controls.Add(Me.LstGroup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chk_Taxtype)
        Me.Controls.Add(Me.chklist_Type)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GROUPWISE)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmVatServiceTaxreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vat and ServiceTaxreport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        gPrint = False
        If Chk_itemwise.Checked = True Then
            itemwisesaleregister()
        ElseIf CHKBILLDETAILS.Checked = True Then
            itemwisesaleregister_BILL()
        ElseIf GROUPWISE.Checked = True Then
            itemwisesaleregister_GROUP()
        Else
            Printoperation_Vat()
        End If
    End Sub
    Private Sub itemwisesaleregister()
        Dim i As Integer
        Dim SSQL, TYPE(), HNAME As String
        Dim posdesc(), groupcode(), itemcode(), sqlstring, membercode() As String
        Dim POSDESC2(), GROUPDESC2() As String
        Dim sqlstringCancel As String
        SSQL = "SELECT ITEMCODE,ITEMDESC,SUM(QTY) AS QTY,SUM(AMOUNT) AS AMOUNT,SUM(TAXAMOUNT)AS TAXAMOUNT,SUM(PACKAMOUNT) AS PACKAMOUNT,SUM(SER_CHG) AS SER_CHG,"
        SSQL = SSQL & "SUM(BILLAMOUNT) AS BILLAMOUNT,ISNULL(RATE,0) AS RATE,isnull(groupcode,'') as GROUPCODE,ISNULL(GROUPNAME,'') AS GROUPNAME FROM VIEWITEMWISESALESUMMARY_TAXWISE "
        SSQL = SSQL & " WHERE CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        SSQL = SSQL & " '" & Format(mskFromdate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskTodate.Value, "yyyy-MM-dd") & "'"
        If chklist_Type.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " and  TAXCODE IN("
            For i = 0 To chklist_Type.CheckedItems.Count - 1
                TYPE = Split(chklist_Type.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & TYPE(1) & "', "
                HNAME = HNAME & " " & Trim(TYPE(0))
                'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MessageBox.Show("Select the TaxType Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If LstGroup.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND GROUPCODE IN ("
            For i = 0 To LstGroup.CheckedItems.Count - 1
                TYPE = Split(LstGroup.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & TYPE(1) & "', "

            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MsgBox("Select the GROUP", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        '====
        If CheckedListBox1.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND USERNAME IN ("
            For i = 0 To CheckedListBox1.CheckedItems.Count - 1
                TYPE = Split(CheckedListBox1.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & CheckedListBox1.CheckedItems(i) & "', "
            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MsgBox("Select the User", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        '========
        If chklist_POSlocation.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND POSCODE IN ("
            For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
                TYPE = Split(chklist_POSlocation.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & TYPE(1) & "', "

            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MsgBox("Select the POS(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        If CHKLIST_PAYMENTMODE.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND PAYMENTMODE IN ("
            HNAME = "("

            For i = 0 To CHKLIST_PAYMENTMODE.CheckedItems.Count - 1
                SSQL = SSQL & " '" & CHKLIST_PAYMENTMODE.CheckedItems(i) & "', "
                HNAME = HNAME & CHKLIST_PAYMENTMODE.CheckedItems(i) & ", "
            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
            HNAME = Mid(HNAME, 1, Len(HNAME) - 2)
            HNAME = HNAME & ")"
        Else
            MsgBox("Select the Paymentmode", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If


        '''If chklist_Membername.CheckedItems.Count <> 0 Then
        '''    SSQL = SSQL & " AND MCODE IN ("
        '''    For i = 0 To chklist_Membername.CheckedItems.Count - 1
        '''        membercode = Split(chklist_Membername.CheckedItems(i), "-->")
        '''        SSQL = SSQL & "'" & membercode(0) & "', "
        '''    Next
        '''    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '''    SSQL = SSQL & ")"
        '''Else
        '''    MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '''    Exit Sub
        '''End If

        '        SSQL = SSQL & "GROUP BY ITEMCODE,ITEMDESC,ISNULL(RATE,0) "
        SSQL = SSQL & "GROUP BY GROUPNAME,GROUPCODE,ITEMCODE,ITEMDESC,ISNULL(RATE,0) "
        Dim heading() As String = {"SALES REGISTER [ITEM WISE]", "ALL"}
        Dim objSaleregistersummary As New rptSaleregistersummary_TAXTYPE
        objSaleregistersummary.Detailsection(SSQL, heading, HNAME, mskFromdate.Value, mskTodate.Value)
    End Sub
    Private Sub itemwisesaleregister_BILL()
        Dim i As Integer
        Dim SSQL, TYPE(), HNAME As String
        Dim posdesc(), groupcode(), itemcode(), sqlstring, membercode() As String
        Dim POSDESC2(), GROUPDESC2() As String
        Dim sqlstringCancel As String

        SSQL = "SELECT ITEMCODE,ITEMDESC,QTY AS QTY,AMOUNT AS AMOUNT,TAXAMOUNT,PACKAMOUNT,SER_CHG,POSCODE,GROUPCODE,KOTDATE,TAXCODE,KOTDETAILS,RATE,mcode,"
        SSQL = SSQL & "BILLAMOUNT AS BILLAMOUNT FROM VIEWITEMWISESALESUMMARY_TAXWISE "
        SSQL = SSQL & " WHERE CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        SSQL = SSQL & " '" & Format(mskFromdate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskTodate.Value, "yyyy-MM-dd") & "'"
        If chklist_Type.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " and  TAXCODE IN("
            For i = 0 To chklist_Type.CheckedItems.Count - 1
                TYPE = Split(chklist_Type.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & TYPE(1) & "', "
                HNAME = HNAME & " " & Trim(TYPE(0))
                'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MessageBox.Show("Select the TaxType Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If LstGroup.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND GROUPCODE IN ("
            For i = 0 To LstGroup.CheckedItems.Count - 1
                TYPE = Split(LstGroup.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & TYPE(1) & "', "

            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        If chklist_POSlocation.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND POSCODE IN ("
            For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
                TYPE = Split(chklist_POSlocation.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & TYPE(1) & "', "

            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MsgBox("Select the POS(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        '====
        If CheckedListBox1.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND USERNAME IN ("
            For i = 0 To CheckedListBox1.CheckedItems.Count - 1
                TYPE = Split(CheckedListBox1.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & CheckedListBox1.CheckedItems(i) & "', "

            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MsgBox("Select the User", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        '========
        If CHKLIST_PAYMENTMODE.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND PAYMENTMODE IN ("
            HNAME = "("

            For i = 0 To CHKLIST_PAYMENTMODE.CheckedItems.Count - 1
                SSQL = SSQL & " '" & CHKLIST_PAYMENTMODE.CheckedItems(i) & "', "
                HNAME = HNAME & CHKLIST_PAYMENTMODE.CheckedItems(i) & ", "
            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
            HNAME = Mid(HNAME, 1, Len(HNAME) - 2)
            HNAME = HNAME & ")"
        Else
            MsgBox("Select the Paymentmode", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If


        '''  If chklist_Membername.CheckedItems.Count <> 0 Then
        '''SSQL = SSQL & " AND mcode IN ("
        ''' For i = 0 To chklist_Membername.CheckedItems.Count - 1
        '''   SSQL = SSQL & " '" & chklist_Membername.CheckedItems(i) & "', "
        'SSQL = SSQL & " '" & TYPE(1) & "', "

        '''  Next
        '''   SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '''   SSQL = SSQL & ") order by mcode"
        '''   Else
        '''   MsgBox("Select the MCODE", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
        '''   Exit Sub
        '''   End If


        ''''If chklist_Membername.CheckedItems.Count <> 0 Then
        ''''    SSQL = SSQL & " AND MCODE IN ("
        ''''    For i = 0 To chklist_Membername.CheckedItems.Count - 1
        ''''        membercode = Split(chklist_Membername.CheckedItems(i), "-->")
        ''''        SSQL = SSQL & "'" & membercode(0) & "', "
        ''''    Next
        ''''    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        ''''    SSQL = SSQL & ") order by mcode"
        ''''Else
        ''''    MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ''''    Exit Sub
        ''''End If




        'SSQL = SSQL & "GROUP BY ITEMCODE,ITEMDESC "
        Dim heading() As String = {"SALES REGISTER [ITEM WISE]", "ALL"}
        Dim objSaleregistersummary As New BILLWISE_TAX
        objSaleregistersummary.Detailsection(SSQL, heading, HNAME, mskFromdate.Value, mskTodate.Value)
    End Sub
    Private Sub itemwisesaleregister_Group()
        Dim i As Integer
        Dim SSQL, TYPE(), HNAME As String
        Dim posdesc(), groupcode(), itemcode(), sqlstring, membercode() As String
        Dim POSDESC2(), GROUPDESC2() As String
        Dim sqlstringCancel As String

        SSQL = "SELECT GROUPNAME,SUM(BILLAMOUNT) AS TOTALAMOUNT, ISNULL(SUM(TAXAMOUNT),0) AS TAXAMOUNT,ISNULL(SUM(PACKAMOUNT),0) AS PACKAMOUNT,ISNULL(SUM(SER_CHG),0) AS SER_CHG,ISNULL(SUM(AMOUNT),0) AS AMOUNT,ISNULL(SUM(QTY),0)  AS QTY FROM VIEWITEMWISESALESUMMARY_TAXWISE "
        SSQL = SSQL & " WHERE CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        SSQL = SSQL & " '" & Format(mskFromdate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskTodate.Value, "yyyy-MM-dd") & "'"
        If chklist_Type.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " and  TAXCODE IN("
            For i = 0 To chklist_Type.CheckedItems.Count - 1
                TYPE = Split(chklist_Type.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & TYPE(1) & "', "
                HNAME = HNAME & " " & Trim(TYPE(0))
                'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MessageBox.Show("Select the TaxType Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If LstGroup.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND GROUPCODE IN ("
            For i = 0 To LstGroup.CheckedItems.Count - 1
                TYPE = Split(LstGroup.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & TYPE(1) & "', "

            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        If chklist_POSlocation.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND POSCODE IN ("
            For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
                TYPE = Split(chklist_POSlocation.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & TYPE(1) & "', "

            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MsgBox("Select the POS(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        '====

        If CheckedListBox1.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND USERNAME IN ("
            For i = 0 To CheckedListBox1.CheckedItems.Count - 1
                TYPE = Split(CheckedListBox1.CheckedItems(i), "-->")
                SSQL = SSQL & " '" & CheckedListBox1.CheckedItems(i) & "', "
            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
        Else
            MsgBox("Select the User", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If

        '========
        If CHKLIST_PAYMENTMODE.CheckedItems.Count <> 0 Then
            SSQL = SSQL & " AND PAYMENTMODE IN ("
            HNAME = "("
            For i = 0 To CHKLIST_PAYMENTMODE.CheckedItems.Count - 1
                SSQL = SSQL & " '" & CHKLIST_PAYMENTMODE.CheckedItems(i) & "', "
                HNAME = HNAME & CHKLIST_PAYMENTMODE.CheckedItems(i) & ", "
            Next
            SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            SSQL = SSQL & ")"
            HNAME = Mid(HNAME, 1, Len(HNAME) - 2)
            HNAME = HNAME & ")"
        Else
            MsgBox("Select the Paymentmode", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Exit Sub
        End If
        '''If chklist_Membername.CheckedItems.Count <> 0 Then
        '''    SSQL = SSQL & " AND MCODE IN ("
        '''    For i = 0 To chklist_Membername.CheckedItems.Count - 1
        '''        membercode = Split(chklist_Membername.CheckedItems(i), "-->")
        '''        SSQL = SSQL & "'" & membercode(0) & "', "
        '''    Next
        '''    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '''    SSQL = SSQL & ")"
        '''Else
        '''    MessageBox.Show("Select the MEMBER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '''    Exit Sub
        '''End If


        SSQL = SSQL & " GROUP BY GROUPNAME "
        Dim heading() As String = {"SALES REGISTER [ITEM WISE]", "ALL"}
        Dim objSaleregistersummary As New ITEMGROUPWISE
        objSaleregistersummary.Detailsection(SSQL, heading, HNAME, mskFromdate.Value, mskTodate.Value)
    End Sub
    Private Sub Printoperation_Vat()
        Dim sqlstring, SSQL As String
        Dim TYPE(), HNAME As String
        Dim heading, MEMBERCODE() As String
        Dim rowcount, TotalDoc, pageno As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Cro" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            ''========================================================================
            Dim vTypeseqno As Double
            Dim vGroupseqno As Double
            Dim totQty, totAmount, totTax, gtotal, TOTPACK, kichamt, Roundoff As Double
            Dim dt As New DataTable
            Dim i, j As Integer
            SSQL = "Select d.servicelocation,p.posdesc as POS,isnull(sum(isnull(d.billamount,0)),0) as amount,isnull(sum(isnull(d.taxamount,0)),0) as taxamount,isnull(sum(isnull(d.packamount,0)),0) as Packamount,isnull(sum(d.Ser_chg),0) as Ser_chg,"
            SSQL = SSQL & " isnull(ROUND(SUM(isnull(d.billamount,0)+isnull(d.taxamount,0)+isnull(d.packamount,0)+isnull(d.ser_chg,0)),2),0) as totalamount,sum(isnull(d.Roundoff,0)) as Roundoff "
            SSQL = SSQL & " From BILL_HDR D,Posmaster P "
            SSQL = SSQL & " where d.servicelocation = p.poscode "
            SSQL = SSQL & " and isnull(d.delflag,'')<>'Y' "
            SSQL = SSQL & " and cast(convert(varchar(11),d.billdate,6) as datetime) between "
            SSQL = SSQL & "'" & Format(mskFromdate.Value, "dd-MMM-yyyy") & "' and '" & Format(mskTodate.Value, "dd-MMM-yyyy") & "'"

            'and D.KOTNO=E.KOTNO AND D.POSCODE=E.SERVICELOCATION AND D.MCODE=E.MCODE 
            'and isnull(kotstatus,'')<>'Y'"
            'If chklist_Type.CheckedItems.Count <> 0 Then
            '    SSQL = SSQL & " and  TAXCODE IN("
            '    For i = 0 To chklist_Type.CheckedItems.Count - 1
            '        TYPE = Split(chklist_Type.CheckedItems(i), "-->")
            '        SSQL = SSQL & " '" & TYPE(1) & "', "
            '        'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
            '    Next
            '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            '    SSQL = SSQL & ")"
            'Else
            '    MessageBox.Show("Select the TaxType Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
            'End If
            'If CHKLIST_PAYMENTMODE.CheckedItems.Count <> 0 Then
            '    SSQL = SSQL & " AND PAYMENTMODE IN ("
            '    HNAME = "("
            '    For i = 0 To CHKLIST_PAYMENTMODE.CheckedItems.Count - 1
            '        SSQL = SSQL & " '" & CHKLIST_PAYMENTMODE.CheckedItems(i) & "', "
            '        HNAME = HNAME & CHKLIST_PAYMENTMODE.CheckedItems(i) & ", "
            '    Next
            '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            '    SSQL = SSQL & ")"
            '    HNAME = Mid(HNAME, 1, Len(HNAME) - 2)
            '    HNAME = HNAME & ")"
            'Else
            '    MsgBox("Select the Paymentmode", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            '    Exit Sub
            'End If
            'If LstGroup.CheckedItems.Count <> 0 Then
            '    SSQL = SSQL & " AND GROUPCODE IN ("
            '    For i = 0 To LstGroup.CheckedItems.Count - 1
            '        TYPE = Split(LstGroup.CheckedItems(i), "-->")
            '        SSQL = SSQL & " '" & TYPE(1) & "', "
            '    Next
            '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            '    SSQL = SSQL & ")"
            'Else
            '    MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            '    Exit Sub
            'End If
            'If chklist_POSlocation.CheckedItems.Count <> 0 Then
            '    SSQL = SSQL & " AND d.POSCODE IN ("
            '    For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
            '        TYPE = Split(chklist_POSlocation.CheckedItems(i), "-->")
            '        SSQL = SSQL & " '" & TYPE(1) & "', "

            '    Next
            '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
            '    SSQL = SSQL & ")"
            'Else
            '    MsgBox("Select the POS(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            '    Exit Sub
            'End If

            'If CheckedListBox1.CheckedItems.Count <> 0 Then
            '    sqlstring = sqlstring & " AND USERNAME IN ("
            '    For i = 0 To CheckedListBox1.CheckedItems.Count - 1
            '        MEMBERCODE = Split(CheckedListBox1.CheckedItems(i), "->")
            '        sqlstring = sqlstring & "'" & MEMBERCODE(0) & "', "
            '    Next
            '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            '    sqlstring = sqlstring & ")"
            'Else
            '    MessageBox.Show("Select the USER NAME(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
            'End If

            PrintHeader(HNAME, mskFromdate.Value, mskTodate.Value, pageno)
            SSQL = SSQL & " group by d.servicelocation,p.posdesc order by posdesc "
            gconnection.getDataSet(SSQL, "VAT")
            If gdataset.Tables("VAT").Rows.Count > 0 Then
                Filewrite.Write(Chr(18))
                rowcount = 9
                For Each dr In gdataset.Tables("VAT").Rows
                    'For Each dr In gdataset.Tables("SALEREGISTERSUMMARY").Rows
                    Filewrite.Write("{0,-29}", Mid(Trim(dr("POS")), 1, 27))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("PACKAMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("SER_CHG")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("Roundoff")), "0.00"), 1, 10))
                    Filewrite.WriteLine("{0,13}", Mid(Format(Val(dr("TOTALAMOUNT")) + Val(dr("Roundoff")), "0.00"), 1, 13))

                    ''Filewrite.Write(Mid(Trim(gdataset.Tables("VAT").Rows(i).Item("POS")), 1, 29) & Space(29 - Len(Mid(Trim(gdataset.Tables("VAT").Rows(i).Item("POS")), 1, 29))))
                    ''Filewrite.Write(Format(gdataset.Tables("VAT").Rows(i).Item("AMOUNT"), "0.00"))
                    ''Filewrite.Write(Space(10 - Len(CStr(Format(Mid(gdataset.Tables("VAT").Rows(i).Item("AMOUNT"), 1, 10), "0.00")))) & Format(gdataset.Tables("VAT").Rows(i).Item("AMOUNT"), "0.00"))
                    ''Filewrite.Write(Space(10 - Len(CStr(Format(Mid(gdataset.Tables("VAT").Rows(i).Item("TAXAMOUNT"), 1, 10), "0.00")))) & Format(gdataset.Tables("VAT").Rows(i).Item("TAXAMOUNT"), "0.00"))
                    ''Filewrite.Write(Space(10 - Len(CStr(Format(Mid(gdataset.Tables("VAT").Rows(i).Item("PACKAMOUNT"), 1, 10), "0.00")))) & Format(gdataset.Tables("VAT").Rows(i).Item("PACKAMOUNT"), "0.00"))
                    ''Filewrite.Write(Space(10 - Len(CStr(Format(Mid(gdataset.Tables("VAT").Rows(i).Item("ser_chg"), 1, 10), "0.00")))) & Format(gdataset.Tables("VAT").Rows(i).Item("ser_chg"), "0.00"))
                    ''Filewrite.WriteLine(Space(12 - Len(CStr(Format(Mid(gdataset.Tables("VAT").Rows(i).Item("TOTALAMOUNT"), 1, 10), "0.00")))) & Format(gdataset.Tables("VAT").Rows(i).Item("TOTALAMOUNT"), "0.00"))
                    '''Filewrite.WriteLine(sqlstring)
                    rowcount = rowcount + 1
                    TotalDoc = TotalDoc + 1
                    Format(Val(dr("PACKAMOUNT")), "0.00")
                    totAmount = totAmount + Format(Val(dr("amount")), "0.00")
                    totTax = totTax + Format(Val(dr("taxamount")), "0.00")
                    TOTPACK = TOTPACK + Format(Val(dr("PACKAMOUNT")), "0.00")
                    kichamt = kichamt + Format(Val(dr("SER_CHG")), "0.00")
                    Roundoff = Roundoff + Format(Val(dr("Roundoff")), "0.00")
                    gtotal = gtotal + Format(Val(dr("TOTALAMOUNT")), "0.00") + Format(Val(dr("Roundoff")), "0.00")
                    If rowcount >= 60 Then
                        Filewrite.WriteLine(StrDup(98, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        PrintHeader(heading, mskFromdate.Value, mskTodate.Value, pageno)
                        rowcount = 9
                    End If
                Next
                Filewrite.WriteLine(StrDup(98, "="))
                sqlstring = "Total :" & Space(22) & Space(12 - Len(Trim(Mid(Format(totAmount, "0.00"), 1, 12)))) & Format(totAmount, "0.00")
                sqlstring = sqlstring & Space(10 - Len(Trim(CStr(Format(totTax, "0.00"))))) & Format(totTax, "0.00")
                sqlstring = sqlstring & Space(10 - Len(Trim(CStr(Format(TOTPACK, "0.00"))))) & Format(TOTPACK, "0.00")
                sqlstring = sqlstring & Space(10 - Len(Trim(CStr(Format(kichamt, "0.00"))))) & Format(kichamt, "0.00")
                sqlstring = sqlstring & Space(10 - Len(Trim(CStr(Format(Roundoff, "0.00"))))) & Format(Roundoff, "0.00")
                sqlstring = sqlstring & Space(12 - Len(Trim(CStr(Format(gtotal, "0.00"))))) & Format(gtotal, "0.00")
                Filewrite.WriteLine(sqlstring)
                Filewrite.WriteLine(StrDup(98, "="))
                Filewrite.WriteLine("Total Document(S)    : " & TotalDoc)
                Filewrite.WriteLine(StrDup(98, "="))
                Filewrite.Write(Chr(12))
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid Billno :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        Finally
        End Try
    End Sub
    Private Function PrintOperation_Stax()
        Dim sqlstring, SSQL As String
        Dim heading As String
        Dim rowcount, TotalDoc, pageno As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Cro" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            heading = "SERVICE TAX REPORT REGISTER"
            Filewrite.Write(Chr(15))
            PrintHeader_Stax(heading, mskFromdate.Value, mskTodate.Value, pageno)

            ''========================================================================
            Dim vTypeseqno As Double
            Dim vGroupseqno As Double
            Dim totQty, totAmount, totTax, gtotal, totPACK As Double
            Dim dt As New DataTable
            Dim i, j As Integer
            SSQL = "SELECT H.BILLDETAILS,H.BILLDATE AS BILLDATE,H.TAXAMOUNT AS TAXAMOUNT,H.PACKAMOUNT,"
            SSQL = SSQL & "H.BILLAMOUNT AS BILLAMOUNT,ROUND(H.TOTALAMOUNT,0) AS TOTALAMOUNT"
            SSQL = SSQL & " FROM BILL_HDR H INNER JOIN BILL_DET D ON D.BILLNO=H.BILLNO "
            SSQL = SSQL & "WHERE H.BILLDATE  BETWEEN "
            SSQL = SSQL & "'" & Format(mskFromdate.Value, "dd-MMM-yyyy") & "' and '" & Format(mskTodate.Value, "dd-MMM-yyyy") & "'"
            SSQL = SSQL & " and  Taxcode IN(SELECT TAXCODE FROM ACCOUNTSTAXMASTER WHERE TYPEOFTAX='SERVICE TAX')  AND ISNULL(H.DELFLAG,'')<>'Y' ORDER BY H.BILLDETAILS"

            gconnection.getDataSet(SSQL, "STAX")
            If gdataset.Tables("STAX").Rows.Count > 0 Then
                Filewrite.Write(Chr(18))
                rowcount = 9
                For i = 0 To gdataset.Tables("STAX").Rows.Count - 1
                    sqlstring = Mid(Trim(gdataset.Tables("STAX").Rows(i).Item("BILLDETAILS")), 1, 16) & Space(18 - Len(Mid(Trim(gdataset.Tables("STAX").Rows(i).Item("BILLDETAILS")), 1, 16))) & Mid(Trim(gdataset.Tables("STAX").Rows(i).Item("BILLDATE")), 1, 10) & Space(10 - Len(Mid(Trim(gdataset.Tables("STAX").Rows(i).Item("BILLDATE")), 1, 10)))
                    sqlstring = sqlstring & Space(13 - Len(Trim(CStr(gdataset.Tables("STAX").Rows(i).Item("BILLAMOUNT"))))) & Trim(gdataset.Tables("STAX").Rows(i).Item("BILLAMOUNT"))
                    sqlstring = sqlstring & Space(12 - Len(Trim(CStr(gdataset.Tables("STAX").Rows(i).Item("TAXAMOUNT"))))) & Trim(Mid(gdataset.Tables("STAX").Rows(i).Item("TAXAMOUNT"), 1, 12))
                    sqlstring = sqlstring & Space(12 - Len(Trim(CStr(gdataset.Tables("STAX").Rows(i).Item("PACKAMOUNT"))))) & Trim(Mid(gdataset.Tables("STAX").Rows(i).Item("PACKAMOUNT"), 1, 12))
                    sqlstring = sqlstring & Space(14 - Len(Trim(CStr(gdataset.Tables("STAX").Rows(i).Item("TOTALAMOUNT"))))) & Trim(gdataset.Tables("STAX").Rows(i).Item("TOTALAMOUNT"))
                    Filewrite.WriteLine(sqlstring)
                    rowcount = rowcount + 1
                    TotalDoc = TotalDoc + 1
                    totAmount = totAmount + Val(gdataset.Tables("STAX").Rows(i).Item("BILLAMOUNT"))
                    totTax = totTax + Val(gdataset.Tables("STAX").Rows(i).Item("TAXAMOUNT"))
                    totPACK = totPACK + Val(gdataset.Tables("STAX").Rows(i).Item("PACKAMOUNT"))
                    gtotal = gtotal + Val(gdataset.Tables("STAX").Rows(i).Item("TOTALAMOUNT"))
                    If rowcount >= 60 Then
                        Filewrite.WriteLine(StrDup(79, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        PrintHeader_Stax(heading, mskFromdate.Value, mskTodate.Value, pageno)
                        rowcount = 9
                    End If
                Next
                Filewrite.WriteLine(StrDup(79, "="))
                sqlstring = "Total :" & Space(19) & Space(12 - Len(Trim(Mid(Format(totAmount, "0.00"), 1, 12)))) & Format(totAmount, "0.00")
                sqlstring = sqlstring & Space(12 - Len(Trim(CStr(Format(totTax, "0.00"))))) & Format(totTax, "0.00")
                sqlstring = sqlstring & Space(12 - Len(Trim(CStr(Format(totPACK, "0.00"))))) & Format(totPACK, "0.00")
                sqlstring = sqlstring & Space(14 - Len(Trim(CStr(Format(gtotal, "0.00"))))) & Format(gtotal, "0.00")
                Filewrite.WriteLine(sqlstring)
                Filewrite.WriteLine(StrDup(79, "="))
                Filewrite.WriteLine("Total Document(S)    : " & TotalDoc)
                Filewrite.WriteLine(StrDup(79, "="))
                Filewrite.Write(Chr(12))
                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(VFilePath)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid Billno :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        Finally
        End Try
    End Function
    Private Function PrintHeader(ByVal HEADING As String, ByVal fDATE As Date, ByVal tDate As Date, ByVal pageno As Integer)
        Dim I As Integer
        Dim sstring As String
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine(Mid(MyCompanyName, 1, 60))
            Filewrite.WriteLine("BILLING TYPE:" & Trim(HEADING))
            Filewrite.WriteLine("LOCATION WISE SUMMARY FROM:" & Format(mskFromdate.Value, "dd/MM/yyyy") & " T0 :" & Format(mskTodate.Value, "dd/MM/yyyy") & Space(20) & "PAGE : " & pageno)
            Filewrite.WriteLine(StrDup(98, "="))
            sstring = "POSLOCATION                    BILLAMOUNT   TAXAMOUNT  A.C CHG   KICH.CHG Round.Off TOTALAMOUNT"
            Filewrite.WriteLine(sstring)
            Filewrite.WriteLine(StrDup(98, "="))
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Function
        End Try
    End Function
    Private Function PrintHeader_Stax(ByVal HEADING As String, ByVal fDATE As Date, ByVal tDate As Date, ByVal pageno As Integer)
        Dim I As Integer
        Dim sstring As String
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(18) & Chr(27) + "E" & Chr(27) + "F")
            Filewrite.WriteLine("{0,23}{1,20}{2,11}{3,25}", "", gUsername, " ", "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING)), "-"), 1, 30))
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            Filewrite.WriteLine("{0,-30}{1,-30}", "From : " & Format(mskFromdate.Value, "MMM dd,yyyy"), "To : " & Format(mskTodate.Value, "MMM dd,yyyy"))
            Filewrite.Write(Chr(18))
            Filewrite.WriteLine(StrDup(79, "="))
            sstring = "BILLNO            BILLDATE     BILLAMOUNT   TAXAMOUNT   TOTALAMOUNT"
            Filewrite.WriteLine(sstring)
            Filewrite.WriteLine(StrDup(79, "="))

            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Sub frmVatServiceTaxreport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mskFromdate.Value = Format(Now, "dd-MMM-yyyy")
        mskTodate.Value = Format(Now, "dd-MMM-yyyy")
        FILLTAXTYPE()
        FillGroup()
        FILLSERVER()
        FillPOSLocation()
        FillPaymentmode()
        FillMembername()

    End Sub
    Private Sub FillMembername()
        Dim i As Integer
        chklist_Membername.Items.Clear()
        SQLSTRING = "SELECT DISTINCT ISNULL(K.MCODE,'') AS MCODE,ISNULL(M.MNAME,'') AS MNAME FROM KOT_DET AS K INNER JOIN MEMBERMASTER AS M ON "
        SQLSTRING = SQLSTRING & " M.MCODE = K.MCODE WHERE ISNULL(MEMBERTYPECODE,'') <> 'EM' AND ISNULL(Freeze,'') <> 'Y'  "
        gconnection.getDataSet(SQLSTRING, "MemberMaster")
        If gdataset.Tables("MemberMaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("MemberMaster").Rows.Count - 1
                With gdataset.Tables("MemberMaster").Rows(i)
                    chklist_Membername.Items.Add(Trim(.Item("Mcode") & "-->" & .Item("Mname")))
                End With
            Next i
        End If
        SQLSTRING = "SELECT ROOMNO,ROOMTYPECODE FROM ROOMMASTER"
        gconnection.getDataSet(SQLSTRING, "ROOMNO")
        If gdataset.Tables("ROOMNO").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("ROOMNO").Rows.Count - 1
                With gdataset.Tables("ROOMNO").Rows(i)
                    chklist_Membername.Items.Add(Trim(.Item("ROOMNO") & "-->" & .Item("ROOMTYPECODE")))
                End With
            Next i
        End If
        chklist_Membername.Sorted = True
    End Sub
    Private Sub FillPOSLocation()
        Dim sqlstring As String
        Dim i As Integer
        chklist_POSlocation.Items.Clear()
        sqlstring = "SELECT DISTINCT poscode,posdesc FROM posmaster WHERE ISNULL(Freeze,'')<>'Y' "
        gconnection.getDataSet(sqlstring, "POS")
        If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                With gdataset.Tables("POS").Rows(i)
                    'chklist_POSlocation.Items.Add(Trim(.Item("POSdesc")))
                    chklist_POSlocation.Items.Add(Trim(.Item("POSDESC")) & Space(100) & "-->" & Trim(.Item("POSCode")))
                End With
            Next i
        End If
    End Sub
    Private Sub FILLSERVER()
        Dim sqlstring As String
        Dim i As Integer

        'CheckedListBox1.Items.Clear()
        'sqlstring = "SELECT DISTINCT SERVERCODE,SERVERNAME FROM SERVERMASTER WHERE ISNULL(Freeze,'')<>'Y' "
        'gconnection.getDataSet(sqlstring, "POS")
        'If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
        '    For i = 0 To gdataset.Tables("POS").Rows.Count - 1
        '        With gdataset.Tables("POS").Rows(i)
        '            'chklist_POSlocation.Items.Add(Trim(.Item("POSdesc")))
        '            CheckedListBox1.Items.Add(Trim(.Item("SERVERNAME")) & Space(100) & "-->" & Trim(.Item("SERVERCODE")))
        '        End With
        '    Next i
        'End If

        CheckedListBox1.Items.Clear()
        sqlstring = "SELECT USERNAME FROM USERADMIN GROUP BY USERNAME"
        gconnection.getDataSet(sqlstring, "SERVERMASTER")
        If gdataset.Tables("SERVERMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("SERVERMASTER").Rows.Count - 1
                With gdataset.Tables("SERVERMASTER").Rows(i)
                    CheckedListBox1.Items.Add(Trim(.Item("USERNAME")))
                End With
            Next i
        End If
        CheckedListBox1.Sorted = True
    End Sub
    Private Sub FillPaymentmode()
        Dim sqlstring As String
        Dim i As Integer
        CHKLIST_PAYMENTMODE.Items.Clear()
        sqlstring = "select paymentcode from PaymentModeMaster where isnull(freeze,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "POS")
        If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                With gdataset.Tables("POS").Rows(i)
                    CHKLIST_PAYMENTMODE.Items.Add(Trim(.Item("paymentcode")))
                End With
            Next i
        End If
    End Sub
    Private Sub FillGroup()   '''***************************** To fill Group details from GroupMaster  *****************'''
        Dim sqlstring As String
        LstGroup.Items.Clear()
        Dim i As Integer
        sqlstring = "SELECT DISTINCT Groupcode,Groupdesc FROM GroupMaster "
        gconnection.getDataSet(sqlstring, "GroupMaster")
        If gdataset.Tables("GroupMaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("GroupMaster").Rows.Count - 1
                With gdataset.Tables("GroupMaster").Rows(i)
                    LstGroup.Items.Add(Trim(.Item("GroupDESC")) & Space(100) & "-->" & Trim(.Item("GroupCode")))
                    'chklist_Type.Items.Add(Trim(.Item("TaxDesc")) & Space(100) & "-->" & Trim(.Item("TaxCode")))
                End With
            Next
        End If
    End Sub

    Private Sub FILLTAXTYPE()
        Dim i As Integer
        Dim sqlstring As String
        chklist_Type.Items.Clear()
        sqlstring = "select ISNULL(Taxcode,'') as TaxCode,isnull(taxdesc,'') as TaxDesc from accountstaxmaster"
        gconnection.getDataSet(sqlstring, "tax")
        If gdataset.Tables("tax").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("Tax").Rows.Count - 1
                With gdataset.Tables("Tax").Rows(i)
                    chklist_Type.Items.Add(Trim(.Item("TaxDesc")) & Space(100) & "-->" & Trim(.Item("TaxCode")))
                End With
            Next i
        End If
        'chklist_POSlocation.Sorted = True
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        gPrint = True
        If Chk_itemwise.Checked = True Then
            itemwisesaleregister()
        Else
            Printoperation_Vat()
        End If
    End Sub
    Private Sub frmVatServiceTaxreport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        If e.KeyCode = Keys.F8 Then
            If CmdPrint.Enabled = True Then
                Call CmdPrint_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If CmdView.Enabled = True Then
                Call CmdView_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            If CmdView.Enabled = True Then
                Call CmdClear_Click(sender, e)
                Exit Sub
            End If

        ElseIf e.KeyCode = Keys.F11 Then
            If CmdView.Enabled = True Then
                Call CmdClear_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F2 Then

            Chk_Taxtype.Checked = True
            For i = 0 To chklist_Type.Items.Count - 1
                chklist_Type.SetItemChecked(i, True)
            Next
            Chk_SelectAllGroup.Checked = True
            For i = 0 To LstGroup.Items.Count - 1
                LstGroup.SetItemChecked(i, True)
            Next i

            Chk_POSlocation.Checked = True
            For i = 0 To chklist_POSlocation.Items.Count - 1
                chklist_POSlocation.SetItemChecked(i, True)
            Next

            Chk_Membername.Checked = True
            For i = 0 To chklist_Membername.Items.Count - 1
                chklist_Membername.SetItemChecked(i, True)
            Next

            Chk_PAYMENTMODE.Checked = True
            For i = 0 To CHKLIST_PAYMENTMODE.Items.Count - 1
                CHKLIST_PAYMENTMODE.SetItemChecked(i, True)
            Next
            CheckBox1.Checked = True
            For i = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(i, True)
            Next i
        ElseIf e.KeyCode = Keys.Escape Then
            Call cmdexit_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub Chk_Taxtype_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Taxtype.CheckedChanged
        Dim i As Integer
        If Chk_Taxtype.Checked = True Then
            For i = 0 To chklist_Type.Items.Count - 1
                chklist_Type.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_Type.Items.Count - 1
                chklist_Type.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub Chk_SelectAllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllGroup.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllGroup.Checked = True Then
            For i = 0 To LstGroup.Items.Count - 1
                LstGroup.SetItemChecked(i, True)
            Next i
        Else
            For i = 0 To LstGroup.Items.Count - 1
                LstGroup.SetItemChecked(i, False)
            Next i
        End If
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Dim I As Long
        For I = 0 To chklist_Type.Items.Count - 1
            chklist_Type.SetItemChecked(I, False)
        Next
        For I = 0 To LstGroup.Items.Count - 1
            LstGroup.SetItemChecked(I, False)
        Next I

        For I = 0 To chklist_POSlocation.Items.Count - 1
            chklist_POSlocation.SetItemChecked(I, False)
        Next
        For I = 0 To CHKLIST_PAYMENTMODE.Items.Count - 1
            CHKLIST_PAYMENTMODE.SetItemChecked(I, False)
        Next
        For I = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(I, False)
        Next
        For I = 0 To chklist_Membername.Items.Count - 1
            chklist_Membername.SetItemChecked(I, False)
        Next
        Chk_itemwise.Checked = False
        Chk_Taxtype.Checked = False
        CHKBILLDETAILS.Checked = False
        Chk_SelectAllGroup.Checked = False
        Chk_PAYMENTMODE.Checked = False
        CheckBox1.Checked = False
        Chk_Membername.Checked = False
        GROUPWISE.Checked = False
        CHKBILLDETAILS.Checked = False
        Chk_POSlocation.Checked = False
        mskFromdate.Value = Format(Now, "dd-MMM-yyyy")
        mskTodate.Value = Format(Now, "dd-MMM-yyyy")
    End Sub
    Private Sub Chk_POSlocation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_POSlocation.CheckedChanged
        Dim i As Integer

        If Chk_POSlocation.Checked = True Then
            For i = 0 To chklist_POSlocation.Items.Count - 1
                chklist_POSlocation.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_POSlocation.Items.Count - 1
                chklist_POSlocation.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub cmdexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexport.Click
        'Dim SSQL, TYPE(), HNAME As String
        'Dim I As Integer
        'Dim posdesc(), groupcode(), itemcode(), sqlstring As String
        'Dim POSDESC2(), GROUPDESC2() As String
        'Dim _export As New EXPORT
        '_export.TABLENAME = "VIEW_POS"
        'If Chk_itemwise.Checked = True Then
        '    SSQL = "ALTER VIEW VIEW_POS AS SELECT ITEMCODE,ITEMDESC,SUM(QTY) AS QTY,SUM(AMOUNT) AS AMOUNT,SUM(TAXAMOUNT)AS TAXAMOUNT,"
        '    SSQL = SSQL & "SUM(BILLAMOUNT) AS BILLAMOUNT FROM VIEWITEMWISESALESUMMARY_TAXWISE "
        '    SSQL = SSQL & " WHERE CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        '    SSQL = SSQL & " '" & Format(mskFromdate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskTodate.Value, "yyyy-MM-dd") & "'"
        '    If chklist_Type.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " and  TAXCODE IN("
        '        For i = 0 To chklist_Type.CheckedItems.Count - 1
        '            Type = Split(chklist_Type.CheckedItems(i), "-->")
        '            SSQL = SSQL & " '" & Type(1) & "', "
        '            HNAME = HNAME & " " & Trim(Type(0))
        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ")"
        '    Else
        '        MessageBox.Show("Select the TaxType Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Sub
        '    End If
        '    If LstGroup.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " AND GROUPCODE IN ("
        '        For i = 0 To LstGroup.CheckedItems.Count - 1
        '            Type = Split(LstGroup.CheckedItems(i), "-->")
        '            SSQL = SSQL & " '" & Type(1) & "', "
        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ")"
        '    Else
        '        MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
        '        Exit Sub
        '    End If
        '    If chklist_POSlocation.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " AND POSCODE IN ("
        '        For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '            Type = Split(chklist_POSlocation.CheckedItems(i), "-->")
        '            SSQL = SSQL & " '" & Type(1) & "', "
        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ")"
        '    Else
        '        MsgBox("Select the POS(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
        '        Exit Sub
        '    End If
        '    SSQL = SSQL & "GROUP BY ITEMCODE,ITEMDESC "
        '    gconnection.getDataSet(SSQL, "view_pos")

        '    SSQL = "select * from view_pos"
        '    Call _export.export_excel(SSQL)
        '    _export.Show()
        '    Exit Sub
        'ElseIf CHKBILLDETAILS.Checked = True Then
        '    Dim sqlstringCancel As String
        '    SSQL = "ALTER VIEW VIEW_POS AS SELECT ITEMCODE,ITEMDESC,QTY AS QTY,AMOUNT AS AMOUNT,TAXAMOUNT,POSCODE,GROUPCODE,KOTDATE,TAXCODE,KOTDETAILS,RATE,"
        '    SSQL = SSQL & "BILLAMOUNT AS BILLAMOUNT FROM VIEWITEMWISESALESUMMARY_TAXWISE "
        '    SSQL = SSQL & " WHERE CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
        '    SSQL = SSQL & " '" & Format(mskFromdate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskTodate.Value, "yyyy-MM-dd") & "'"
        '    If chklist_Type.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " and  TAXCODE IN("
        '        For i = 0 To chklist_Type.CheckedItems.Count - 1
        '            TYPE = Split(chklist_Type.CheckedItems(i), "-->")
        '            SSQL = SSQL & " '" & TYPE(1) & "', "
        '            HNAME = HNAME & " " & Trim(TYPE(0))
        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ")"
        '    Else
        '        MessageBox.Show("Select the TaxType Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Sub
        '    End If
        '    If LstGroup.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " AND GROUPCODE IN ("
        '        For i = 0 To LstGroup.CheckedItems.Count - 1
        '            TYPE = Split(LstGroup.CheckedItems(i), "-->")
        '            SSQL = SSQL & " '" & TYPE(1) & "', "
        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ")"
        '    Else
        '        MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
        '        Exit Sub
        '    End If
        '    If chklist_POSlocation.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " AND POSCODE IN ("
        '        For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '            TYPE = Split(chklist_POSlocation.CheckedItems(i), "-->")
        '            SSQL = SSQL & " '" & TYPE(1) & "', "
        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ")"
        '    Else
        '        MsgBox("Select the POS(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
        '        Exit Sub
        '    End If
        '    gconnection.getDataSet(SSQL, "view_pos")

        '    SSQL = "select * from view_pos"
        '    Call _export.export_excel(SSQL)
        '    _export.Show()
        '    Exit Sub
        'Else
        '    SSQL = "ALTER VIEW VIEW_POS AS select d.poscode,p.posdesc as POS,isnull(sum(amount),0) as amount,isnull(sum(taxamount),0) as taxamount,"
        '    SSQL = SSQL & " isnull(ROUND(SUM(amount+taxamount),0),2) as totalamount "
        '    SSQL = SSQL & " from kot_det d ,posmaster p"
        '    SSQL = SSQL & " where(p.poscode = d.poscode)"
        '    SSQL = SSQL & " and isnull(delflag,'')<>'Y' and isnull(kotstatus,'')<>'Y'"
        '    SSQL = SSQL & " and cast(convert(varchar(11),d.kotdate,6) as datetime) between "
        '    SSQL = SSQL & "'" & Format(mskFromdate.Value, "dd-MMM-yyyy") & "' and '" & Format(mskTodate.Value, "dd-MMM-yyyy") & "'"

        '    If chklist_Type.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " and  TAXCODE IN("
        '        For I = 0 To chklist_Type.CheckedItems.Count - 1
        '            TYPE = Split(chklist_Type.CheckedItems(I), "-->")
        '            SSQL = SSQL & " '" & TYPE(1) & "', "
        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ")"
        '    Else
        '        MessageBox.Show("Select the TaxType Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Sub
        '    End If
        '    If LstGroup.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " AND GROUPCODE IN ("
        '        For I = 0 To LstGroup.CheckedItems.Count - 1
        '            TYPE = Split(LstGroup.CheckedItems(I), "-->")
        '            SSQL = SSQL & " '" & TYPE(1) & "', "
        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ")"
        '    Else
        '        MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
        '        Exit Sub
        '    End If
        '    If chklist_POSlocation.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " AND D.POSCODE IN ("
        '        For I = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '            TYPE = Split(chklist_POSlocation.CheckedItems(I), "-->")
        '            SSQL = SSQL & " '" & TYPE(1) & "', "

        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ")"
        '    Else
        '        MsgBox("Select the POS(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
        '        Exit Sub
        '    End If

        '    SSQL = SSQL & " group by d.poscode,p.posdesc "
        '    gconnection.getDataSet(SSQL, "VIEW_POS")

        '    SSQL = "SELECT * FROM VIEW_POS order by posdesc"
        '    Call _export.export_excel(SSQL)
        '    _export.Show()
        '    Exit Sub
        'End If
    End Sub

    Private Sub mskFromdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskFromdate.ValueChanged

    End Sub
    Private Sub mskFromdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFromdate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            mskTodate.Focus()
        End If
    End Sub
    Private Sub mskTodate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskTodate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CmdView.Focus()
        End If
    End Sub
    Private Sub Chk_PAYMENTMODE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_PAYMENTMODE.CheckedChanged
        Dim i As Integer
        If Chk_PAYMENTMODE.Checked = True Then
            For i = 0 To CHKLIST_PAYMENTMODE.Items.Count - 1
                CHKLIST_PAYMENTMODE.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To CHKLIST_PAYMENTMODE.Items.Count - 1
                CHKLIST_PAYMENTMODE.SetItemChecked(i, False)
            Next
        End If

    End Sub

    Private Sub LstGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstGroup.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim i As Integer
        If CheckBox1.Checked = True Then
            For i = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(i, True)
            Next i
        Else
            For i = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(i, False)
            Next i
        End If
    End Sub

    Private Sub Chk_Membername_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Membername.CheckedChanged
        Dim i As Integer

        If Chk_Membername.Checked = True Then
            For i = 0 To chklist_Membername.Items.Count - 1
                chklist_Membername.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklist_Membername.Items.Count - 1
                chklist_Membername.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub chklist_Membername_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklist_Membername.SelectedIndexChanged

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
End Class
