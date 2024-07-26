Public Class SaleRegisterVoucherwise12
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
    Friend WithEvents Chk_PAYMENTMODE As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CHKLIST_PAYMENTMODE As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cbo_Details As System.Windows.Forms.ComboBox
    Friend WithEvents Chk_SelectAllPos As System.Windows.Forms.CheckBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Chklist_POSlocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chklist_POSdocument As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Chklist_Servercode As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Details As System.Windows.Forms.Label
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Chk_SelectAllServer As System.Windows.Forms.CheckBox
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SaleRegisterVoucherwise12))
        Me.Chk_PAYMENTMODE = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CHKLIST_PAYMENTMODE = New System.Windows.Forms.CheckedListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Cbo_Details = New System.Windows.Forms.ComboBox
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Chklist_POSlocation = New System.Windows.Forms.CheckedListBox
        Me.Chklist_POSdocument = New System.Windows.Forms.CheckedListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Chklist_Servercode = New System.Windows.Forms.CheckedListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbl_Details = New System.Windows.Forms.Label
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Chk_SelectAllServer = New System.Windows.Forms.CheckBox
        Me.CmdView = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chk_PAYMENTMODE
        '
        Me.Chk_PAYMENTMODE.BackColor = System.Drawing.Color.Transparent
        Me.Chk_PAYMENTMODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_PAYMENTMODE.Location = New System.Drawing.Point(652, -2)
        Me.Chk_PAYMENTMODE.Name = "Chk_PAYMENTMODE"
        Me.Chk_PAYMENTMODE.Size = New System.Drawing.Size(132, 24)
        Me.Chk_PAYMENTMODE.TabIndex = 470
        Me.Chk_PAYMENTMODE.Text = "SELECT ALL"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(652, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 23)
        Me.Label9.TabIndex = 469
        Me.Label9.Text = "PAYMENTMODE:"
        '
        'CHKLIST_PAYMENTMODE
        '
        Me.CHKLIST_PAYMENTMODE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CHKLIST_PAYMENTMODE.Location = New System.Drawing.Point(652, 46)
        Me.CHKLIST_PAYMENTMODE.Name = "CHKLIST_PAYMENTMODE"
        Me.CHKLIST_PAYMENTMODE.Size = New System.Drawing.Size(216, 382)
        Me.CHKLIST_PAYMENTMODE.TabIndex = 468
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(108, 606)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 461
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(372, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(272, 24)
        Me.Label8.TabIndex = 467
        Me.Label8.Text = "USER  NAME :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, -42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 25)
        Me.Label3.TabIndex = 458
        Me.Label3.Text = "VOUCHER SALE REPORT"
        '
        'Cbo_Details
        '
        Me.Cbo_Details.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Details.Items.AddRange(New Object() {"YES", "NO"})
        Me.Cbo_Details.Location = New System.Drawing.Point(276, 446)
        Me.Cbo_Details.Name = "Cbo_Details"
        Me.Cbo_Details.Size = New System.Drawing.Size(168, 21)
        Me.Cbo_Details.TabIndex = 460
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(60, -2)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllPos.TabIndex = 457
        Me.Chk_SelectAllPos.Text = "SELECT ALL "
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(164, 558)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 454
        Me.CmdClear.Text = "Clear[F6]"
        '
        'Chklist_POSlocation
        '
        Me.Chklist_POSlocation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_POSlocation.Location = New System.Drawing.Point(60, 46)
        Me.Chklist_POSlocation.Name = "Chklist_POSlocation"
        Me.Chklist_POSlocation.Size = New System.Drawing.Size(304, 382)
        Me.Chklist_POSlocation.TabIndex = 456
        '
        'Chklist_POSdocument
        '
        Me.Chklist_POSdocument.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_POSdocument.Location = New System.Drawing.Point(116, 46)
        Me.Chklist_POSdocument.Name = "Chklist_POSdocument"
        Me.Chklist_POSdocument.Size = New System.Drawing.Size(304, 382)
        Me.Chklist_POSdocument.TabIndex = 463
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(116, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(296, 24)
        Me.Label2.TabIndex = 464
        Me.Label2.Text = "POS DOCUMENT :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Location = New System.Drawing.Point(108, 542)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox4.TabIndex = 455
        Me.GroupBox4.TabStop = False
        '
        'Chklist_Servercode
        '
        Me.Chklist_Servercode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Chklist_Servercode.Location = New System.Drawing.Point(372, 46)
        Me.Chklist_Servercode.Name = "Chklist_Servercode"
        Me.Chklist_Servercode.Size = New System.Drawing.Size(272, 382)
        Me.Chklist_Servercode.TabIndex = 466
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(60, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 24)
        Me.Label4.TabIndex = 462
        Me.Label4.Text = "POS LOCATION :"
        '
        'lbl_Details
        '
        Me.lbl_Details.AutoSize = True
        Me.lbl_Details.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Details.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Details.Location = New System.Drawing.Point(116, 446)
        Me.lbl_Details.Name = "lbl_Details"
        Me.lbl_Details.Size = New System.Drawing.Size(143, 22)
        Me.lbl_Details.TabIndex = 459
        Me.lbl_Details.Text = "MEMBER CODE :"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(484, 558)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 451
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(652, 558)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 453
        Me.cmdexit.Text = "Exit[F11]"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(108, 478)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 452
        Me.grp_SalebillChecklist.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(360, 24)
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
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'Chk_SelectAllServer
        '
        Me.Chk_SelectAllServer.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllServer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllServer.Location = New System.Drawing.Point(372, -2)
        Me.Chk_SelectAllServer.Name = "Chk_SelectAllServer"
        Me.Chk_SelectAllServer.TabIndex = 465
        Me.Chk_SelectAllServer.Text = "SELECT ALL"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(324, 558)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 450
        Me.CmdView.Text = "View [F9]"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(108, 478)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 449
        Me.GroupBox3.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(184, 24)
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
        Me.Label6.Location = New System.Drawing.Point(400, 24)
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
        Me.mskToDate.Location = New System.Drawing.Point(504, 24)
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
        Me.Label7.Location = New System.Drawing.Point(56, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'SaleRegisterVoucherwise12
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 582)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CHKLIST_PAYMENTMODE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cbo_Details)
        Me.Controls.Add(Me.Chk_SelectAllPos)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.Chklist_POSlocation)
        Me.Controls.Add(Me.Chklist_POSdocument)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Chklist_Servercode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_Details)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.Chk_SelectAllServer)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Chk_PAYMENTMODE)
        Me.Name = "SaleRegisterVoucherwise12"
        Me.Text = "SaleRegisterVoucherwise12"
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SaleRegisterVoucherwise12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
