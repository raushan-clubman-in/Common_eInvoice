Imports System.Data.SqlClient
Imports Excel
Public Class SaleBillItemwiseRegister
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
    Friend WithEvents Chk_SelectAllPos As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LstPOS As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents grp_Salebillitemwise As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents chkItemwiseregister As System.Windows.Forms.CheckBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents LstGroup As System.Windows.Forms.CheckedListBox
    Friend WithEvents Lstitemcode As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chkitemcode As System.Windows.Forms.CheckBox
    Friend WithEvents grp_itemcode As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_details As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_SelectAllItem As System.Windows.Forms.CheckBox
    Friend WithEvents grp_PaymentModeSelection As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_Exporttoexcel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SaleBillItemwiseRegister))
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LstPOS = New System.Windows.Forms.CheckedListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.grp_Salebillitemwise = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.chkItemwiseregister = New System.Windows.Forms.CheckBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Chk_details = New System.Windows.Forms.CheckBox
        Me.Chkitemcode = New System.Windows.Forms.CheckBox
        Me.Chk_SelectAllGroup = New System.Windows.Forms.CheckBox
        Me.LstGroup = New System.Windows.Forms.CheckedListBox
        Me.Lstitemcode = New System.Windows.Forms.CheckedListBox
        Me.grp_itemcode = New System.Windows.Forms.GroupBox
        Me.Chk_SelectAllItem = New System.Windows.Forms.CheckBox
        Me.grp_PaymentModeSelection = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_Exporttoexcel = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.grp_Salebillitemwise.SuspendLayout()
        Me.grp_itemcode.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(168, 80)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllPos.TabIndex = 0
        Me.Chk_SelectAllPos.Text = "SELECT ALL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FROM DATE :"
        '
        'LstPOS
        '
        Me.LstPOS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LstPOS.Location = New System.Drawing.Point(168, 128)
        Me.LstPOS.Name = "LstPOS"
        Me.LstPOS.Size = New System.Drawing.Size(312, 361)
        Me.LstPOS.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mskFromDate)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.mskToDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(200, 552)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "TO DATE :"
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
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 18)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'grp_Salebillitemwise
        '
        Me.grp_Salebillitemwise.BackgroundImage = CType(resources.GetObject("grp_Salebillitemwise.BackgroundImage"), System.Drawing.Image)
        Me.grp_Salebillitemwise.Controls.Add(Me.lbl_Wait)
        Me.grp_Salebillitemwise.Controls.Add(Me.ProgressBar1)
        Me.grp_Salebillitemwise.Location = New System.Drawing.Point(200, 448)
        Me.grp_Salebillitemwise.Name = "grp_Salebillitemwise"
        Me.grp_Salebillitemwise.Size = New System.Drawing.Size(712, 64)
        Me.grp_Salebillitemwise.TabIndex = 10
        Me.grp_Salebillitemwise.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(376, 24)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 18)
        Me.lbl_Wait.TabIndex = 0
        '
        'chkItemwiseregister
        '
        Me.chkItemwiseregister.BackColor = System.Drawing.Color.Transparent
        Me.chkItemwiseregister.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItemwiseregister.Location = New System.Drawing.Point(464, 512)
        Me.chkItemwiseregister.Name = "chkItemwiseregister"
        Me.chkItemwiseregister.Size = New System.Drawing.Size(160, 24)
        Me.chkItemwiseregister.TabIndex = 4
        Me.chkItemwiseregister.Text = "COSTING [ Y/N ]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(224, 632)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 11
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(504, 632)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 9
        Me.CmdPrint.Text = " Print [F8]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(364, 632)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 8
        Me.CmdView.Text = "View [F9]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(784, 632)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 10
        Me.cmdexit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(199, 616)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SALE KOT REGISTER [ ITEM WISE ]"
        '
        'Chk_details
        '
        Me.Chk_details.BackColor = System.Drawing.Color.Transparent
        Me.Chk_details.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_details.Location = New System.Drawing.Point(200, 512)
        Me.Chk_details.Name = "Chk_details"
        Me.Chk_details.Size = New System.Drawing.Size(160, 24)
        Me.Chk_details.TabIndex = 5
        Me.Chk_details.Text = "DETAILS [ Y/N ]"
        '
        'Chkitemcode
        '
        Me.Chkitemcode.BackColor = System.Drawing.Color.Transparent
        Me.Chkitemcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkitemcode.Location = New System.Drawing.Point(728, 512)
        Me.Chkitemcode.Name = "Chkitemcode"
        Me.Chkitemcode.Size = New System.Drawing.Size(216, 24)
        Me.Chkitemcode.TabIndex = 6
        Me.Chkitemcode.Text = "ITEM CODE WISE [Y/N]"
        '
        'Chk_SelectAllGroup
        '
        Me.Chk_SelectAllGroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllGroup.Location = New System.Drawing.Point(632, 80)
        Me.Chk_SelectAllGroup.Name = "Chk_SelectAllGroup"
        Me.Chk_SelectAllGroup.Size = New System.Drawing.Size(136, 24)
        Me.Chk_SelectAllGroup.TabIndex = 2
        Me.Chk_SelectAllGroup.Text = "SELECT ALL "
        '
        'LstGroup
        '
        Me.LstGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LstGroup.Location = New System.Drawing.Point(632, 128)
        Me.LstGroup.Name = "LstGroup"
        Me.LstGroup.Size = New System.Drawing.Size(320, 361)
        Me.LstGroup.TabIndex = 3
        '
        'Lstitemcode
        '
        Me.Lstitemcode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lstitemcode.Location = New System.Drawing.Point(16, 56)
        Me.Lstitemcode.Name = "Lstitemcode"
        Me.Lstitemcode.Size = New System.Drawing.Size(296, 412)
        Me.Lstitemcode.TabIndex = 16
        '
        'grp_itemcode
        '
        Me.grp_itemcode.BackgroundImage = CType(resources.GetObject("grp_itemcode.BackgroundImage"), System.Drawing.Image)
        Me.grp_itemcode.Controls.Add(Me.Chk_SelectAllItem)
        Me.grp_itemcode.Controls.Add(Me.Lstitemcode)
        Me.grp_itemcode.Location = New System.Drawing.Point(344, 1000)
        Me.grp_itemcode.Name = "grp_itemcode"
        Me.grp_itemcode.Size = New System.Drawing.Size(336, 494)
        Me.grp_itemcode.TabIndex = 17
        Me.grp_itemcode.TabStop = False
        '
        'Chk_SelectAllItem
        '
        Me.Chk_SelectAllItem.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllItem.Location = New System.Drawing.Point(16, 24)
        Me.Chk_SelectAllItem.Name = "Chk_SelectAllItem"
        Me.Chk_SelectAllItem.Size = New System.Drawing.Size(136, 24)
        Me.Chk_SelectAllItem.TabIndex = 17
        Me.Chk_SelectAllItem.Text = "SELECT ALL "
        '
        'grp_PaymentModeSelection
        '
        Me.grp_PaymentModeSelection.BackgroundImage = CType(resources.GetObject("grp_PaymentModeSelection.BackgroundImage"), System.Drawing.Image)
        Me.grp_PaymentModeSelection.Location = New System.Drawing.Point(327, 95)
        Me.grp_PaymentModeSelection.Name = "grp_PaymentModeSelection"
        Me.grp_PaymentModeSelection.Size = New System.Drawing.Size(336, 494)
        Me.grp_PaymentModeSelection.TabIndex = 18
        Me.grp_PaymentModeSelection.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 672)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(423, 18)
        Me.Label4.TabIndex = 416
        Me.Label4.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(168, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 24)
        Me.Label6.TabIndex = 420
        Me.Label6.Text = "POS LOCATION :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(632, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(320, 24)
        Me.Label7.TabIndex = 421
        Me.Label7.Text = "GROUP DESCRIPTION :"
        '
        'btn_Exporttoexcel
        '
        Me.btn_Exporttoexcel.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_Exporttoexcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Exporttoexcel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exporttoexcel.ForeColor = System.Drawing.Color.White
        Me.btn_Exporttoexcel.Image = CType(resources.GetObject("btn_Exporttoexcel.Image"), System.Drawing.Image)
        Me.btn_Exporttoexcel.Location = New System.Drawing.Point(648, 632)
        Me.btn_Exporttoexcel.Name = "btn_Exporttoexcel"
        Me.btn_Exporttoexcel.Size = New System.Drawing.Size(104, 32)
        Me.btn_Exporttoexcel.TabIndex = 422
        Me.btn_Exporttoexcel.Text = "Grid View"
        '
        'SaleBillItemwiseRegister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(990, 692)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Exporttoexcel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grp_itemcode)
        Me.Controls.Add(Me.Chk_SelectAllGroup)
        Me.Controls.Add(Me.LstGroup)
        Me.Controls.Add(Me.Chkitemcode)
        Me.Controls.Add(Me.Chk_details)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.chkItemwiseregister)
        Me.Controls.Add(Me.grp_Salebillitemwise)
        Me.Controls.Add(Me.Chk_SelectAllPos)
        Me.Controls.Add(Me.LstPOS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmdView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "SaleBillItemwiseRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALE BILL REGISTER [ITEM WISE ]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.grp_Salebillitemwise.ResumeLayout(False)
        Me.grp_itemcode.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ssql As String
    Public Myconn As New SqlConnection
    Dim ds As DataSet
    Dim chkbool As Boolean
    Dim da As New SqlDataAdapter
    Dim vconn As New GlobalClass
    Private Sub FillPOS()   '''***************************** To fill POS details from POSMaster  *****************'''
        Try
            LstPOS.Items.Clear()
            Dim i As Integer
            ssql = "SELECT DISTINCT POScode,POSdesc FROM POSMaster "
            vconn.getDataSet(ssql, "POS")
            If gdataset.Tables("POS").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("POS").Rows.Count - 1
                    With gdataset.Tables("POS").Rows(i)
                        LstPOS.Items.Add(Trim(.Item("POSdesc")))
                    End With
                Next i
            End If
            LstPOS.Sorted = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
            vconn.getDataSet(SQLSTRING, "USER")
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
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillGroup()   '''***************************** To fill Group details from GroupMaster  *****************'''
        Try
            LstGroup.Items.Clear()
            Dim i As Integer
            ssql = "SELECT DISTINCT Groupcode,Groupdesc FROM GroupMaster "
            vconn.getDataSet(ssql, "GroupMaster")
            If gdataset.Tables("GroupMaster").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("GroupMaster").Rows.Count - 1
                    With gdataset.Tables("GroupMaster").Rows(i)
                        LstGroup.Items.Add(Trim(.Item("Groupcode") & "-->" & .Item("Groupdesc")))
                    End With
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_SelectAllPos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllPos.CheckedChanged
        Try
            Dim i As Integer
            If Chk_SelectAllPos.Checked = True Then
                For i = 0 To LstPOS.Items.Count - 1
                    LstPOS.SetItemChecked(i, True)
                Next
            Else
                For i = 0 To LstPOS.Items.Count - 1
                    LstPOS.SetItemChecked(i, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub SaleBillItemwiseRegister_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim sqlstring As String
            Dim x As String
            Call FillPOS()
            Call FillGroup()
            grp_Salebillitemwise.Top = 1000
            mskFromDate.Value = Now.Today
            mskToDate.Value = Now.Today
            grp_itemcode.Top = 1000
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
                Me.grp_Salebillitemwise.Top = 1000
                Call itemwisesaleregister()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub itemwisesaleregister()
        Try
            Dim i As Integer
            Dim posdesc(), groupcode(), itemcode(), sqlstring As String
            Dim POSDESC2(), GROUPDESC2() As String

            Dim sqlstringCancel As String
            If Chk_details.Checked = True Then
                posdesc = Split(LstPOS.CheckedItems(i), "-->")
                sqlstring = " SELECT GROUPCODE,GROUPDESC,ITEMCODE,ITEMDESC,baseuomstd,SUM(QTY) AS QTY,RATE,ISNULL(UOM,'') AS UOM FROM VIEWITEMWISESALESUMMARY"
                '                If LstPOS.CheckedItems.Count <> 0 Then
                '    sqlstring = sqlstring & " WHERE POSDESC IN ("
                '    For i = 0 To LstPOS.CheckedItems.Count - 1
                '        posdesc = Split(LstPOS.CheckedItems(i), "-->")
                '        sqlstring = sqlstring & "'" & posdesc(0) & "', "
                '    Next i
                '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                '    sqlstring = sqlstring & ")"
                'Else
                '    MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                '    Exit Sub
                'End If
                If LstGroup.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE GROUPCODE IN ("
                    For i = 0 To LstGroup.CheckedItems.Count - 1
                        groupcode = Split(LstGroup.CheckedItems(i), "-->")
                        sqlstring = sqlstring & "'" & groupcode(0) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                    Exit Sub
                End If
                'shan
                '06/05/2008
                'sqlstring = sqlstring & " AND ISNULL(DELFLAG,'') <> 'Y' AND ISNULL(KOTSTATUS,'') = 'N' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " AND ISNULL(DELFLAG,'') <> 'Y' and CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                sqlstring = sqlstring & " GROUP BY GROUPCODE,GROUPDESC,ITEMCODE,ITEMDESC,baseuomstd,UOM,RATE ORDER BY GROUPCODE,GROUPDESC,ITEMCODE,ITEMDESC,UOM "
                Dim heading() As String = {"SALES REGISTER [ITEM WISE]", posdesc(0)}
                Dim objSaleregistersummary As New rptSaleregistersummary
                objSaleregistersummary.Detailsection(sqlstring, heading, mskFromDate.Value, mskToDate.Value)
            Else
                If Chkitemcode.Checked = True Then
                    If chkItemwiseregister.Checked = True Then
                        ''COSTING SECTION START
                        ''=====================================================
                        sqlstring = " SELECT * FROM PURCHASEREGISTERITEMWISE1"
                        If LstPOS.CheckedItems.Count <> 0 Then
                            sqlstring = sqlstring & " WHERE POSDESC IN ("
                            For i = 0 To LstPOS.CheckedItems.Count - 1
                                posdesc = Split(LstPOS.CheckedItems(i), "-->")
                                sqlstring = sqlstring & "'" & posdesc(0) & "', "
                            Next i
                            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                            sqlstring = sqlstring & ")"
                        Else
                            MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                            Exit Sub
                        End If
                        If LstGroup.CheckedItems.Count <> 0 Then
                            sqlstring = sqlstring & " AND GROUPCODE IN ("
                            For i = 0 To LstGroup.CheckedItems.Count - 1
                                groupcode = Split(LstGroup.CheckedItems(i), "-->")
                                sqlstring = sqlstring & "'" & groupcode(0) & "', "
                            Next
                            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                            sqlstring = sqlstring & ")"
                        Else
                            MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                            Exit Sub
                        End If
                        If Lstitemcode.CheckedItems.Count <> 0 Then
                            sqlstring = sqlstring & " AND ITEMCODE IN ("
                            For i = 0 To Lstitemcode.CheckedItems.Count - 1
                                itemcode = Split(Lstitemcode.CheckedItems(i), "-->")
                                sqlstring = sqlstring & "'" & itemcode(0) & "', "
                            Next
                            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                            sqlstring = sqlstring & ")"
                        Else
                            MsgBox("Select the ItemCode(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                            Exit Sub
                        End If
                        'shan
                        '06/05/2008
                        'sqlstring = sqlstring & " AND ISNULL(DELFLAG,'') <> 'Y' AND ISNULL(KOTSTATUS,'') = 'N' AND ISNULL(ENDINGDATE,'')='' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                        sqlstring = sqlstring & " AND ISNULL(DELFLAG,'') <> 'Y' AND ISNULL(ENDINGDATE,'')='' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                        sqlstring = sqlstring & " ORDER BY GROUPDESC,ITEMDESC "
                        'Dim heading() As String = {"SALES KOT REGISTER [ITEM WISE]", posdesc(0)}
                        Dim heading() As String = {"SALES KOT REGISTER [ITEM WISE]"}
                        Dim SalepurchaserateReport As New SaleItemwiseRegisterpurchaserate
                        SalepurchaserateReport.Detailsection(sqlstring, heading, mskFromDate.Value, mskToDate.Value)

                        ''END OF THE COSTING SECTION.
                        ''==================================
                    Else
                        sqlstring = " SELECT * FROM SALEREGISTERITEMWISE1"
                        If LstPOS.CheckedItems.Count <> 0 Then
                            sqlstring = sqlstring & " WHERE POSDESC IN ("
                            For i = 0 To LstPOS.CheckedItems.Count - 1
                                posdesc = Split(LstPOS.CheckedItems(i), "-->")
                                sqlstring = sqlstring & "'" & posdesc(0) & "', "
                            Next i
                            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                            sqlstring = sqlstring & ")"
                        Else
                            MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                            Exit Sub
                        End If
                        If LstGroup.CheckedItems.Count <> 0 Then
                            sqlstring = sqlstring & " AND GROUPCODE IN ("
                            For i = 0 To LstGroup.CheckedItems.Count - 1
                                groupcode = Split(LstGroup.CheckedItems(i), "-->")
                                sqlstring = sqlstring & "'" & groupcode(0) & "', "
                            Next
                            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                            sqlstring = sqlstring & ")"
                        Else
                            MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                            Exit Sub
                        End If
                        If Lstitemcode.CheckedItems.Count <> 0 Then
                            sqlstring = sqlstring & " AND ITEMCODE IN ("
                            For i = 0 To Lstitemcode.CheckedItems.Count - 1
                                itemcode = Split(Lstitemcode.CheckedItems(i), "-->")
                                sqlstring = sqlstring & "'" & itemcode(0) & "', "
                            Next
                            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                            sqlstring = sqlstring & ")"
                        Else
                            MsgBox("Select the ItemCode(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                            Exit Sub
                        End If
                        sqlstring = sqlstring & "AND ISNULL(DELFLAG,'') <> 'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"
                        sqlstring = sqlstring & "ORDER BY GROUPDESC, ITEMDESC,KOTDETAILS"
                        Dim heading() As String = {"SALES KOT REGISTER [ITEM WISE]", posdesc(0)}
                        Dim SalesItemwiseRegisterReport As New SaleItemwiseRegister2
                        SalesItemwiseRegisterReport.printdata(sqlstring, heading, mskFromDate.Value, mskToDate.Value, sqlstringCancel)
                    End If
                Else
                    If chkItemwiseregister.Checked = True Then
                        sqlstring = " SELECT * FROM PURCHASEREGISTERITEMWISE1"
                        If LstPOS.CheckedItems.Count <> 0 Then
                            sqlstring = sqlstring & " WHERE POSDESC IN ("
                            For i = 0 To LstPOS.CheckedItems.Count - 1
                                posdesc = Split(LstPOS.CheckedItems(i), "-->")
                                sqlstring = sqlstring & "'" & posdesc(0) & "', "
                            Next i
                            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                            sqlstring = sqlstring & ")"
                        Else
                            MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                            Exit Sub
                        End If
                        If LstGroup.CheckedItems.Count <> 0 Then
                            sqlstring = sqlstring & " AND GROUPCODE IN ("
                            For i = 0 To LstGroup.CheckedItems.Count - 1
                                groupcode = Split(LstGroup.CheckedItems(i), "-->")
                                sqlstring = sqlstring & "'" & groupcode(0) & "', "
                            Next
                            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                            sqlstring = sqlstring & ")"
                        Else
                            MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                            Exit Sub
                        End If
                        'shan
                        '06/05/2008
                        'sqlstring = sqlstring & " AND ISNULL(DELFLAG,'') <> 'Y' AND ISNULL(KOTSTATUS,'') = 'N' AND ISNULL(ENDINGDATE,'')='' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                        sqlstring = sqlstring & " AND ISNULL(DELFLAG,'') <> 'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
                        sqlstring = sqlstring & " ORDER BY GROUPDESC,ITEMDESC "
                        Dim heading() As String = {"SALES KOT REGISTER [ITEM WISE]", posdesc(0)}
                        Dim SalepurchaserateReport As New SaleItemwiseRegisterpurchaserate
                        SalepurchaserateReport.Detailsection(sqlstring, heading, mskFromDate.Value, mskToDate.Value)
                    Else
                        sqlstring = " SELECT * FROM SALEREGISTERITEMWISE1"
                        If LstPOS.CheckedItems.Count <> 0 Then
                            sqlstring = sqlstring & " WHERE POSDESC IN ("
                            For i = 0 To LstPOS.CheckedItems.Count - 1
                                posdesc = Split(LstPOS.CheckedItems(i), "-->")
                                sqlstring = sqlstring & "'" & posdesc(0) & "', "
                            Next i
                            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                            sqlstring = sqlstring & ")"
                        Else
                            MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                            Exit Sub
                        End If
                        If LstGroup.CheckedItems.Count <> 0 Then
                            sqlstring = sqlstring & " AND GROUPCODE IN ("
                            For i = 0 To LstGroup.CheckedItems.Count - 1
                                groupcode = Split(LstGroup.CheckedItems(i), "-->")
                                sqlstring = sqlstring & "'" & groupcode(0) & "', "
                            Next
                            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                            sqlstring = sqlstring & ")"
                        Else
                            MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                            Exit Sub
                        End If
                        '''sqlstring = sqlstring & " AND ISNULL(DELFLAG,'') <> 'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                        '''sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"
                        '''sqlstring = sqlstring & " ORDER BY GROUPDESC, ITEMDESC,KOTDETAILS"
                        ''=======================================
                        sqlstring = sqlstring & " AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                        sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"
                        sqlstring = sqlstring & " ORDER BY GROUPDESC, ITEMDESC,KOTDETAILS"

                        '************sql string for cancel items*********************************
                        sqlstringCancel = " SELECT K.KOTDETAILS AS KOTDETAILS, K.KOTDATE AS KOTDATE, K.ITEMCODE AS ITEMCODE, I.ITEMDESC AS ITEMDESC,I.BaseUOMstd,"
                        sqlstringCancel = sqlstringCancel & "K.UOM AS UOM,K.POSCODE AS POSCODE,K.QTY  as QTY ,CASE K.UOM WHEN 'F.PEG' THEN K.QTY*2 "
                        sqlstringCancel = sqlstringCancel & " WHEN 'FULL'  THEN K.QTY*2 "
                        sqlstringCancel = sqlstringCancel & " ELSE K.QTY END AS PQTY, "
                        sqlstringCancel = sqlstringCancel & "K.RATE AS RATE,K.AMOUNT AS AMOUNT,ISNULL(K.GROUPCODE,'') AS GROUPCODE,"
                        sqlstringCancel = sqlstringCancel & "G.GROUPDESC AS GROUPDESC,P.POSDESC AS POSDESC,ISNULL(K.KOTSTATUS,'') AS KOTSTATUS,ISNULL(K.DELFLAG,'') AS DELFLAG"
                        sqlstringCancel = sqlstringCancel & " FROM  KOT_DET AS K"
                        sqlstringCancel = sqlstringCancel & " INNER JOIN ITEMMASTER AS I ON I.ITEMCODE = K.ITEMCODE "
                        sqlstringCancel = sqlstringCancel & " INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = K.GROUPCODE "
                        sqlstringCancel = sqlstringCancel & " INNER JOIN  POSMASTER AS P ON  P.POSCODE= K.POSCODE "
                        sqlstringCancel = sqlstringCancel & " WHERE (ISNULL(K.KOTSTATUS,'') = 'Y')"
                        sqlstringCancel = sqlstringCancel & " AND  CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
                        sqlstringCancel = sqlstringCancel & " '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(mskToDate.Value, "dd-MMM-yyyy") & "'"

                        sqlstringCancel = sqlstringCancel & " AND POSDESC IN ("
                        For i = 0 To LstPOS.CheckedItems.Count - 1
                            POSDESC2 = Split(LstPOS.CheckedItems(i), "-->")
                            sqlstringCancel = sqlstringCancel & "'" & POSDESC2(0) & "', "
                        Next i
                        sqlstringCancel = Mid(sqlstringCancel, 1, Len(sqlstringCancel) - 2)
                        sqlstringCancel = sqlstringCancel & ")"

                        sqlstringCancel = sqlstringCancel & " AND K.GROUPCODE IN ("
                        For i = 0 To LstGroup.CheckedItems.Count - 1
                            GROUPDESC2 = Split(LstGroup.CheckedItems(i), "-->")
                            sqlstringCancel = sqlstringCancel & "'" & GROUPDESC2(0) & "', "
                        Next
                        sqlstringCancel = Mid(sqlstringCancel, 1, Len(sqlstringCancel) - 2)
                        sqlstringCancel = sqlstringCancel & ")"

                        sqlstringCancel = sqlstringCancel & " ORDER BY POSDESC "
                        '************************************************************************


                        Dim heading() As String = {"SALES KOT REGISTER [ITEM WISE]", posdesc(0)}
                        Dim SalesItemwiseRegisterReport As New SaleItemwiseRegister2
                        SalesItemwiseRegisterReport.printdata(sqlstring, heading, mskFromDate.Value, mskToDate.Value, sqlstringCancel)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            LstPOS.Items.Clear()
            LstGroup.Items.Clear()
            Lstitemcode.Items.Clear()
            Chkitemcode.Checked = False
            Chk_SelectAllGroup.Checked = False
            Chk_SelectAllPos.Checked = False
            chkItemwiseregister.Checked = False
            Chk_details.Checked = False
            grp_itemcode.Top = 1000
            Call FillGroup()
            Call FillPOS()
            mskFromDate.Value = Now.Today
            mskToDate.Value = Now.Today
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            If LstPOS.CheckedItems.Count = 0 Then
                MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            If LstGroup.CheckedItems.Count = 0 Then
                MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = False
            grp_itemcode.Top = 1000
            grp_Salebillitemwise.Top = 552
            grp_Salebillitemwise.Left = 200
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            If LstPOS.CheckedItems.Count = 0 Then
                MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            If LstGroup.CheckedItems.Count = 0 Then
                MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            Checkdaterangevalidate(mskFromDate.Value, mskToDate.Value)
            If chkdatevalidate = False Then Exit Sub
            gPrint = True
            grp_itemcode.Top = 1000
            grp_Salebillitemwise.Top = 552
            grp_Salebillitemwise.Left = 200
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub LstPOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstPOS.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Chk_SelectAllGroup.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub mskFromDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFromDate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                mskToDate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub mskToDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskToDate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                CmdView.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_SelectAllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllGroup.CheckedChanged
        Try
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
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_SelectAllPos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Chk_SelectAllPos.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                LstPOS.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_SelectAllGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Chk_SelectAllGroup.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                LstGroup.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub LstGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstGroup.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                mskFromDate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chkitemcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkitemcode.CheckedChanged
        Try
            If Chkitemcode.Checked = True Then
                Dim groupcode(), posdesc() As String
                Dim i As Integer
                Lstitemcode.Items.Clear()
                grp_itemcode.Top = 88
                grp_itemcode.Left = 344
                ssql = "SELECT DISTINCT I.ITEMCODE,I.ITEMDESC FROM ITEMMASTER AS I"
                ssql = ssql & " INNER JOIN POSMENULINK P ON I.ITEMCODE = P.ITEMCODE"
                ssql = ssql & " INNER JOIN POSMASTER M ON M.POSCODE = P.POS WHERE "
                If LstGroup.CheckedItems.Count <> 0 Then
                    ssql = ssql & " I.GROUPCODE IN ("
                    For i = 0 To LstGroup.CheckedItems.Count - 1
                        groupcode = Split(LstGroup.CheckedItems(i), "-->")
                        ssql = ssql & " '" & groupcode(0) & "', "
                    Next
                    ssql = Mid(ssql, 1, Len(ssql) - 2)
                    ssql = ssql & ")"
                Else
                    MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                    Exit Sub
                End If
                If LstPOS.CheckedItems.Count <> 0 Then
                    ssql = ssql & " AND M.POSDESC IN ("
                    For i = 0 To LstPOS.CheckedItems.Count - 1
                        posdesc = Split(LstPOS.CheckedItems(i), "-->")
                        ssql = ssql & " '" & posdesc(0) & "', "
                    Next i
                    ssql = Mid(ssql, 1, Len(ssql) - 2)
                    ssql = ssql & ")"
                Else
                    MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                    Exit Sub
                End If
                vconn.getDataSet(ssql, "Itemmaster")
                If gdataset.Tables("Itemmaster").Rows.Count - 1 >= 0 Then
                    For i = 0 To gdataset.Tables("Itemmaster").Rows.Count - 1
                        With gdataset.Tables("Itemmaster").Rows(i)
                            Lstitemcode.Items.Add(Trim(.Item("ITEMCODE") & "-->" & .Item("ITEMDESC")))
                        End With
                    Next i
                End If
                Lstitemcode.Sorted = True

            Else
                grp_itemcode.Top = 1000
                Chkitemcode.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub SaleBillItemwiseRegister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Dim i As Integer
            If e.KeyCode = Keys.F6 Then
                Call CmdClear_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                For i = 0 To LstPOS.Items.Count - 1
                    LstPOS.SetItemChecked(i, True)
                Next i
                Chk_SelectAllPos.Checked = True
                For i = 0 To LstGroup.Items.Count - 1
                    LstGroup.SetItemChecked(i, True)
                Next i
                Chk_SelectAllGroup.Checked = True
                Me.mskFromDate.Focus()
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 Then
                Call CmdPrint_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F9 Then
                Call CmdView_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F11 Then
                Call cmdexit_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.Escape Then
                If grp_itemcode.Top = 88 Then
                    grp_itemcode.Top = 1000
                    Chkitemcode.Checked = False
                Else
                    Call cmdexit_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.Alt = True And e.KeyCode = Keys.F Then
                Me.mskFromDate.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.T Then
                Me.mskToDate.Focus()
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                Search = InputBox("ENTER TEXT", "SEARCH")
                If LstPOS.SelectedIndex = 0 Then
                    Call Search_Item(LstPOS, Search)
                ElseIf LstGroup.SelectedIndex = 0 Then
                    Call Search_Item(LstGroup, Search)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_SelectAllItem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_SelectAllItem.CheckedChanged
        Try
            Dim i As Integer
            If Chk_SelectAllItem.Checked = True Then
                For i = 0 To Lstitemcode.Items.Count - 1
                    Lstitemcode.SetItemChecked(i, True)
                Next
            Else
                For i = 0 To Lstitemcode.Items.Count - 1
                    Lstitemcode.SetItemChecked(i, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub btn_Exporttoexcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exporttoexcel.Click
        Try
            Dim SQLSTRING, POSDESC(), GROUPCODE() As String
            Dim I As Integer

            SQLSTRING = " SELECT ITEMCODE,ITEMDESC,SUM(QTY) AS QTY,RATE FROM VIEWITEMWISESALESUMMARY"
            If LstPOS.CheckedItems.Count <> 0 Then
                SQLSTRING = SQLSTRING & " WHERE POSDESC IN ("
                For I = 0 To LstPOS.CheckedItems.Count - 1
                    POSDESC = Split(LstPOS.CheckedItems(I), "-->")
                    SQLSTRING = SQLSTRING & " '" & POSDESC(0) & "', "
                Next I
                SQLSTRING = Mid(SQLSTRING, 1, Len(SQLSTRING) - 2)
                SQLSTRING = SQLSTRING & ")"
            Else
                MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            If LstGroup.CheckedItems.Count <> 0 Then
                SQLSTRING = SQLSTRING & " AND GROUPCODE IN ("
                For I = 0 To LstGroup.CheckedItems.Count - 1
                    GROUPCODE = Split(LstGroup.CheckedItems(I), "-->")
                    SQLSTRING = SQLSTRING & " '" & GROUPCODE(0) & "', "
                Next
                SQLSTRING = Mid(SQLSTRING, 1, Len(SQLSTRING) - 2)
                SQLSTRING = SQLSTRING & ")"
            Else
                MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            SQLSTRING = SQLSTRING & " AND ISNULL(DELFLAG,'') <> 'Y' AND ISNULL(KOTSTATUS,'') = 'N' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) BETWEEN "
            SQLSTRING = SQLSTRING & " '" & Format(mskFromDate.Value, "yyyy-MM-dd") & "' AND ' " & Format(mskToDate.Value, "yyyy-MM-dd") & "'"
            SQLSTRING = SQLSTRING & " GROUP BY ITEMCODE,ITEMDESC,RATE ORDER BY ITEMCODE,ITEMDESC "
            vconn.getDataSet(SQLSTRING, "GRIDVIEW")
            gridviewstatus = "ITEMWISESALEREGISTER"
            POSDESC = Split(LstPOS.CheckedItems(0), "-->")
            gridviewHeading(0) = POSDESC(0)
            gridviewHeading(1) = Format(mskFromDate.Value, "dd/MMM/yyyy")
            gridviewHeading(2) = Format(mskToDate.Value, "dd/MMM/yyyy")
            Dim griddesign As New GridDesign
            griddesign.FormBorderStyle = FormBorderStyle.FixedDialog
            griddesign.MdiParent = MDIParentobj
            Me.Close()
            griddesign.Show()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try

    End Sub
End Class
