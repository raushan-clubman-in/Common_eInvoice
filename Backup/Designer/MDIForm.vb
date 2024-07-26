Public Class MDIForm
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents mnu_Exit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Administrator As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MDIForm))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.mnu_Administrator = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem67 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.mnu_Exit = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem10, Me.mnu_Administrator, Me.MenuItem66, Me.mnu_Exit, Me.MenuItem12})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem68, Me.MenuItem4, Me.MenuItem51, Me.MenuItem18, Me.MenuItem62, Me.MenuItem16, Me.MenuItem21, Me.MenuItem71, Me.MenuItem22, Me.MenuItem29, Me.MenuItem15, Me.MenuItem33, Me.MenuItem32, Me.MenuItem40, Me.MenuItem30, Me.MenuItem46, Me.MenuItem39, Me.MenuItem48, Me.MenuItem47, Me.MenuItem65, Me.MenuItem49, Me.MenuItem50, Me.MenuItem52, Me.MenuItem53, Me.MenuItem37, Me.MenuItem61, Me.MenuItem63, Me.MenuItem64, Me.MenuItem70})
        Me.MenuItem1.Text = "&Masters"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 0
        Me.MenuItem68.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem69, Me.MenuItem7, Me.MenuItem8, Me.MenuItem14, Me.MenuItem57, Me.MenuItem60})
        Me.MenuItem68.Text = "POS SALES"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 0
        Me.MenuItem69.Text = "Item Hsn Mapping"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "Payment Ledger Mapping"
        Me.MenuItem7.Visible = False
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Text = "&Item Master"
        Me.MenuItem8.Visible = False
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "ItemType Ledger Mapping"
        Me.MenuItem14.Visible = False
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 4
        Me.MenuItem57.Text = "Categorywise Item Ledger Mapping"
        Me.MenuItem57.Visible = False
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 5
        Me.MenuItem60.Text = "Sub Payment Ledger Mapping"
        Me.MenuItem60.Visible = False
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 2
        Me.MenuItem51.Shortcut = System.Windows.Forms.Shortcut.CtrlT
        Me.MenuItem51.Text = "Item Master  - Import From Tally"
        Me.MenuItem51.Visible = False
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 3
        Me.MenuItem18.Text = "-"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 4
        Me.MenuItem62.Text = "Cash Bank Ledger Mapping"
        Me.MenuItem62.Visible = False
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 5
        Me.MenuItem16.Text = "Subscription Ledger Mapping"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 6
        Me.MenuItem21.Text = "-"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 7
        Me.MenuItem71.Text = "Other Sub Ledger Mapping"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 8
        Me.MenuItem22.Text = "Member Master Mapping"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 9
        Me.MenuItem29.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 10
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem23})
        Me.MenuItem15.Text = "INVENTORY"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 0
        Me.MenuItem19.Text = "Inventory Item Master"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "Vendor Ledger Mapping"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 11
        Me.MenuItem33.Text = "-"
        Me.MenuItem33.Visible = False
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 12
        Me.MenuItem32.Text = "Tally Setup"
        Me.MenuItem32.Visible = False
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 13
        Me.MenuItem40.Text = "-"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 14
        Me.MenuItem30.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem34, Me.MenuItem35, Me.MenuItem36, Me.MenuItem59})
        Me.MenuItem30.Text = "PARTY"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 0
        Me.MenuItem34.Text = "Party Hall Ledger Mapping"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 1
        Me.MenuItem35.Text = "Party Receipt Head Mapping"
        Me.MenuItem35.Visible = False
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 2
        Me.MenuItem36.Text = "Party Item Ledger Mapping"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 3
        Me.MenuItem59.Text = "Party Tarriff  Ledger Mapping"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 15
        Me.MenuItem46.Text = "-"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 16
        Me.MenuItem39.Text = "Event Master Mapping"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 17
        Me.MenuItem48.Text = "-"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 18
        Me.MenuItem47.Text = "Chargecode Mapping"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 19
        Me.MenuItem65.Text = "-"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 20
        Me.MenuItem49.Text = "Event Master Mapping"
        Me.MenuItem49.Visible = False
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 21
        Me.MenuItem50.Text = "-"
        Me.MenuItem50.Visible = False
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 22
        Me.MenuItem52.Text = "Guest Entry Mapping"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 23
        Me.MenuItem53.Text = "-"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 24
        Me.MenuItem37.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem41, Me.MenuItem44, Me.MenuItem45, Me.MenuItem54, Me.MenuItem55, Me.MenuItem56})
        Me.MenuItem37.Text = "GOLF"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 0
        Me.MenuItem41.Text = "Green Fee Mapping"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 1
        Me.MenuItem44.Text = "Golf Ball Mapping"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 2
        Me.MenuItem45.Text = "Golf Hiring Mapping"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 3
        Me.MenuItem54.Text = "Camp Tagging"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 4
        Me.MenuItem55.Text = "Cart Tagging"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 5
        Me.MenuItem56.Text = "Tournament Tagging"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 25
        Me.MenuItem61.Text = "Guest Room Mapping"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 26
        Me.MenuItem63.Text = "Guest Room Payment Mapping"
        Me.MenuItem63.Visible = False
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 27
        Me.MenuItem64.Text = "Tax Master"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 28
        Me.MenuItem70.Text = "Tax Group Master"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem20, Me.MenuItem42, Me.MenuItem25, Me.MenuItem43, Me.MenuItem2, Me.MenuItem6, Me.MenuItem5, Me.MenuItem13, Me.MenuItem9, Me.MenuItem26, Me.MenuItem24, Me.MenuItem28, Me.MenuItem27, Me.MenuItem31, Me.MenuItem38})
        Me.MenuItem10.Text = "&Transactions"
        Me.MenuItem10.Visible = False
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 0
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.MenuItem20.Text = "&Accounts Tally - Import - Members Vouchers"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 1
        Me.MenuItem42.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 2
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MenuItem25.Text = "Accounts Tally - &Export MEMBER BILL"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 3
        Me.MenuItem43.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 4
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlB
        Me.MenuItem2.Text = "&Billing Tally - Export- Smart KOT"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "Party Bill "
        Me.MenuItem5.Visible = False
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 7
        Me.MenuItem13.Text = "-"
        Me.MenuItem13.Visible = False
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 8
        Me.MenuItem9.Text = "Guest Bill"
        Me.MenuItem9.Visible = False
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 9
        Me.MenuItem26.Text = "-"
        Me.MenuItem26.Visible = False
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 10
        Me.MenuItem24.Text = "&Accounts Tally - Import - Audit"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 11
        Me.MenuItem28.Text = "-"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 12
        Me.MenuItem27.Text = "Accounts Tally - Export GRN"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 13
        Me.MenuItem31.Text = "Accounts Tally - Export RECEIPTS"
        Me.MenuItem31.Visible = False
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 14
        Me.MenuItem38.Text = "Accounts Tally - Export All  Except Pos/Inv"
        '
        'mnu_Administrator
        '
        Me.mnu_Administrator.Index = 2
        Me.mnu_Administrator.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem3})
        Me.mnu_Administrator.Text = "&Administrator"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Text = "Select Company"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Export To Excel"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 3
        Me.MenuItem66.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem67, Me.MenuItem58})
        Me.MenuItem66.Text = "Report"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 0
        Me.MenuItem67.Text = "Posting Audit Trail"
        Me.MenuItem67.Visible = False
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 1
        Me.MenuItem58.Text = "GST DETAIL REPORT"
        '
        'mnu_Exit
        '
        Me.mnu_Exit.Index = 4
        Me.mnu_Exit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11})
        Me.mnu_Exit.Text = "&Exit"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "Close"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 5
        Me.MenuItem12.Text = ""
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database L" & _
        "ocking Mode=1;Data Source=""E:\KAMAL\POS\DBS_Key.mdb"";Mode=Share Deny None;Jet OL" & _
        "EDB:Engine Type=5;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;" & _
        "Jet OLEDB:SFP=False;persist security info=False;Extended Properties=;Jet OLEDB:C" & _
        "ompact Without Replica Repair=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:C" & _
        "reate System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;User ID" & _
        "=Admin;Jet OLEDB:Global Bulk Transactions=1"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(856, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(168, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'MDIForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 723)
        Me.Controls.Add(Me.PictureBox3)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MDIForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub MDIForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIParentobj = Me
        'version control
        'begin
        Dim Vers As Boolean = False

        If Vers = True Then
            Dim sql As String
            sql = "select * FROM Master..CLUBMANVERSION Where ModuleName='" & GModule & "' AND DATEOFVERSION>'" & Format(dtLastWriteTime, "dd/MMM/yyyy hh:mm:ss") & "'"
            gconnection.getDataSet(sql, "FileValidate")
            If gdataset.Tables("FileValidate").Rows.Count > 0 Then
                MsgBox("You are Using Older Version, Kindly Update New Version with the help of System Admin...", MsgBoxStyle.OKOnly, "Version Change")
            End If
            'end
        End If

        AppPath = Application.StartupPath
        If Dir(AppPath & "\Reports", FileAttribute.Directory) = "" Then
            MkDir(AppPath & "\Reports")
        End If
        Call Clearfiles()
        Call GetFotoSetup()
        Call FillCompanyinfo()
        Call GetAccountcode()
        Call Activateuseradmin()
        SYS_DATE_TIME()

        Dim sqlstring As String
        sqlstring = "select Isnull(COMPNAME,'') As CompName from POSSETUP "
        gconnection.getDataSet(sqlstring, "POSSETUP")
        If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
            gCompName = gdataset.Tables("POSSETUP").Rows(0).Item("CompName")
        End If
        'If Mid(UCase(MyCompanyName), 1, 6) = "KARNAT" Then
        '    Call updateitemledger()
        'End If
        updatetables2000new()
        CtrlAltX = False
        If CtrlAltX = False Then
            '            MenuItem2.Visible = False
        End If
        Me.IsMdiContainer = True
        MIN_BALANCE_GBL = 0 'DEPOSIT AMOUNT FOR CARD
    End Sub
    Private Sub updatetables2000new()
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='itemmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='itemmaster' AND column_name = 'HSNNO')        BEGIN ALTER TABLE dbo.itemmaster ADD HSNNO varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='itemmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='itemmaster' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.itemmaster ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='subscriptionmast') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='subscriptionmast' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.subscriptionmast ADD SACNO varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='MEMBERMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='MEMBERMASTER' AND column_name = 'GSTINNO')        BEGIN ALTER TABLE dbo.MEMBERMASTER ADD GSTINNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try

        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='subscriptionmast') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='subscriptionmast' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.subscriptionmast ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='inventoryitemmaster' AND column_name = 'HSNNO')        BEGIN ALTER TABLE dbo.inventoryitemmaster ADD HSNNO varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='inventoryitemmaster' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.inventoryitemmaster ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='INV_inventoryitemmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='INV_inventoryitemmaster' AND column_name = 'HSNNO')        BEGIN ALTER TABLE dbo.INV_inventoryitemmaster ADD HSNNO varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='INV_inventoryitemmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='INV_inventoryitemmaster' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.INV_inventoryitemmaster ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSSUBLEDGERMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSSUBLEDGERMASTER' AND column_name = 'VENDORTYPE')        BEGIN ALTER TABLE dbo.ACCOUNTSSUBLEDGERMASTER ADD VENDORTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSSUBLEDGERMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSSUBLEDGERMASTER' AND column_name = 'GSTINNO')        BEGIN ALTER TABLE dbo.ACCOUNTSSUBLEDGERMASTER ADD GSTINNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='party_hallmaster_HDR') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='party_hallmaster_HDR' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.party_hallmaster_HDR ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='party_hallmaster_HDR') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='party_hallmaster_HDR' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.party_hallmaster_HDR ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_itemmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='PARTY_itemmaster' AND column_name = 'HSNNO')        BEGIN ALTER TABLE dbo.PARTY_itemmaster ADD HSNNO varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_itemmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='PARTY_itemmaster' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.PARTY_itemmaster ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_TARIFFHDR') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='PARTY_TARIFFHDR' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.PARTY_TARIFFHDR ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_TARIFFHDR') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='PARTY_TARIFFHDR' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.PARTY_TARIFFHDR ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='EV_EVENTS_HDR') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='EV_EVENTS_HDR' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.EV_EVENTS_HDR ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='EV_EVENTS_HDR') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='EV_EVENTS_HDR' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.EV_EVENTS_HDR ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='CHARGEMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='CHARGEMASTER' AND column_name = 'TYPEOFTAX')        BEGIN ALTER TABLE dbo.CHARGEMASTER ADD TYPEOFTAX varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='CHARGEMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='CHARGEMASTER' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.CHARGEMASTER ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='gr_locationmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='gr_locationmaster' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.gr_locationmaster ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='gr_locationmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='gr_locationmaster' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.gr_locationmaster ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_GREENFEEMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_GREENFEEMASTER' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.GMS_GREENFEEMASTER ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_GREENFEEMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_GREENFEEMASTER' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.GMS_GREENFEEMASTER ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_BALLRATEMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_BALLRATEMASTER' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.GMS_BALLRATEMASTER ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_BALLRATEMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_BALLRATEMASTER' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.GMS_BALLRATEMASTER ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_SALEITEMMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_SALEITEMMASTER' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.GMS_SALEITEMMASTER ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_SALEITEMMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_SALEITEMMASTER' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.GMS_SALEITEMMASTER ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CAMPMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_CAMPMASTER' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.GMS_CAMPMASTER ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CAMPMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_CAMPMASTER' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.GMS_CAMPMASTER ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CARTFEEMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_CARTFEEMASTER' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.GMS_CARTFEEMASTER ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CARTFEEMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_CARTFEEMASTER' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.GMS_CARTFEEMASTER ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_TOURNAMENTMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_TOURNAMENTMASTER' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.GMS_TOURNAMENTMASTER ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_TOURNAMENTMASTER') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='GMS_TOURNAMENTMASTER' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.GMS_TOURNAMENTMASTER ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='RoomAccountPostingSetupMaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='RoomAccountPostingSetupMaster' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.RoomAccountPostingSetupMaster ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='RoomAccountPostingSetupMaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='RoomAccountPostingSetupMaster' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.RoomAccountPostingSetupMaster ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ROOM_Accounts_SETUP') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ROOM_Accounts_SETUP' AND column_name = 'TAXTYPE')        BEGIN ALTER TABLE dbo.ROOM_Accounts_SETUP ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ROOM_Accounts_SETUP') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ROOM_Accounts_SETUP' AND column_name = 'SACNO')        BEGIN ALTER TABLE dbo.ROOM_Accounts_SETUP ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='inventoryitemmaster' AND column_name = 'TAXGROUPCODE')        BEGIN ALTER TABLE dbo.inventoryitemmaster ADD TAXGROUPCODE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster'"
            gconnection.getDataSet(SQLSTRING, "INV")
            If gdataset.Tables("INV").Rows.Count > 0 Then
                SQLSTRING = "SELECT 1 FROM SYSOBJECTS WHERE NAME ='view_inventoryitemmaster'"
                gconnection.getDataSet(SQLSTRING, "INV1")
                If gdataset.Tables("INV1").Rows.Count > 0 Then
                Else
                    SQLSTRING = " CREATE view dbo.view_inventoryitemmaster  as  select * from INVENTORYItemmaster WHERE STORECODE in(SELECT STORECODE FROM STOREMASTER WHERE Storestatus='M')     "
                    gconnection.dataOperation1(1, SQLSTRING)
                End If
            End If

        Catch
        End Try
        SQLSTRING = "SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER'"
        gconnection.getDataSet(SQLSTRING, "INV")
        If gdataset.Tables("INV").Rows.Count > 0 Then
        Else
            SQLSTRING = " CREATE TABLE dbo.ACCOUNTSTAXGROUPMASTER(	AUTOID int IDENTITY(1,1) NOT NULL,	GROUPCODE varchar(15) NULL,	GROUPNAME varchar(50) NULL,	TAXCODE varchar(20) NULL,	TAXDESC varchar(100) NULL,	TAXpercentage numeric(18, 2) NULL,	typeoftax varchar(30) NULL,	ADDUSERID varchar(30) NULL,	ADDDATE datetime NULL,	VOID varchar(1) NULL,	VOIDUSER varchar(25) NULL,	VOIDDATE datetime NULL,	AUTHTHORISEUSER1 varchar(20) NULL,	AUTHORISED varchar(2) NULL,	AUTHORISE_LEVEL1 varchar(2) NULL,	AUTHORISE_USER1 varchar(20) NULL,	AUTHORISE_DATE1 datetime NULL,	AUTHORISE_LEVEL2 varchar(2) NULL,	AUTHORISE_USER2 varchar(20) NULL,	AUTHORISE_DATE2 datetime NULL,	AUTHORISE_LEVEL3 varchar(2) NULL,	AUTHORISE_USER3 varchar(20) NULL,	AUTHORISE_DATE3 datetime NULL )"
            gconnection.dataOperation1(1, SQLSTRING)
        End If
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTOID')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTOID intEGER IDENTITY(1,1)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'GROUPCODE')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD GROUPCODE varchar(15)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'GROUPNAME')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD GROUPNAME varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'TAXCODE')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD TAXCODE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'TAXDESC')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD TAXDESC varchar(100)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'TAXpercentage')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD TAXpercentage numeric(18,2)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'typeoftax')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD typeoftax varchar(30)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'ADDUSERID')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD ADDUSERID varchar(30)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'ADDDATE')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD ADDDATE datetime       End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'VOID')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD VOID varchar(1)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'VOIDUSER')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD VOIDUSER varchar(25)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'VOIDDATE')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD VOIDDATE datetime       End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHTHORISEUSER1')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHTHORISEUSER1 varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHORISED')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHORISED varchar(2)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHORISE_LEVEL1')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHORISE_LEVEL1 varchar(2)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHORISE_USER1')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHORISE_USER1 varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHORISE_DATE1')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHORISE_DATE1 datetime        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHORISE_LEVEL2')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHORISE_LEVEL2 varchar(2)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHORISE_USER2')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHORISE_USER2 varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHORISE_DATE2')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHORISE_DATE2 datetime      End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHORISE_LEVEL3')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHORISE_LEVEL3 varchar(2)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHORISE_USER3')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHORISE_USER3 varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXGROUPMASTER' AND column_name = 'AUTHORISE_DATE3')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXGROUPMASTER ADD AUTHORISE_DATE3 datetime        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        SQLSTRING = "SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG'"
        gconnection.getDataSet(SQLSTRING, "INV")
        If gdataset.Tables("INV").Rows.Count > 0 Then
        Else
            SQLSTRING = "  CREATE TABLE dbo.accountstaxmaster_LOG(	taxcode varchar(10) NOT NULL,	taxdesc varchar(50) NULL,	taxpercentage numeric(10, 2) NULL,	typeoftax varchar(20) NULL,	glaccountin varchar(10) NULL,	glaccountdesc varchar(50) NULL,	subledgercode varchar(10) NULL,	subledgerdesc varchar(50) NULL,	costcentercode varchar(10) NULL,	costcenterdesc varchar(50) NULL,	adduserid varchar(50) NULL,	adddatetime datetime NULL,	updateuserid varchar(50) NULL,	updatedatetime datetime NULL,	freezeflag varchar(1) NULL,	freezeuserid varchar(50) NULL,	freezedatetime datetime NULL,	ADD_DATE datetime NULL,ADD_USER varchar(50) NULL, UPD_USER varchar(9) NULL,UPD_DATE datetime NULL, VOID varchar(9) NULL,VOIDUSER varchar(9) NULL,	VOIDDATE datetime NULL,AUTHORISED varchar(2) NULL,AUTHORISE_LEVEL1 varchar(2) NULL,AUTHORISE_USER1 varchar(20) NULL,AUTHORISE_DATE1 datetime NULL, AUTHORISE_LEVEL2 varchar(2) NULL,AUTHORISE_USER2 varchar(20) NULL,AUTHORISE_DATE2 datetime NULL, AUTHORISE_LEVEL3 varchar(2) NULL,AUTHORISE_USER3 varchar(20) NULL,AUTHORISE_DATE3 datetime NULL,INPUTTAXACCOUNTIN varchar(50) NULL,inputtaxaccountinDESC varchar(50) NULL, INPUTTAXSLCODEIN varchar(50) NULL, inputtaxSLDESC varchar(100) NULL ) "
            gconnection.dataOperation1(1, SQLSTRING)
        End If
        SQLSTRING = "SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster'"
        gconnection.getDataSet(SQLSTRING, "INV")
        If gdataset.Tables("INV").Rows.Count > 0 Then
        Else
            SQLSTRING = "  CREATE TABLE dbo.accountstaxmaster(	taxcode varchar(10) NOT NULL,	taxdesc varchar(50) NULL,	taxpercentage numeric(10, 2) NULL,	typeoftax varchar(20) NULL,	glaccountin varchar(10) NULL,	glaccountdesc varchar(50) NULL,	subledgercode varchar(10) NULL,	subledgerdesc varchar(50) NULL,	costcentercode varchar(10) NULL,	costcenterdesc varchar(50) NULL,	adduserid varchar(50) NULL,	adddatetime datetime NULL,	updateuserid varchar(50) NULL,	updatedatetime datetime NULL,	freezeflag varchar(1) NULL,	freezeuserid varchar(50) NULL,	freezedatetime datetime NULL,	ADD_DATE datetime NULL,ADD_USER varchar(50) NULL, UPD_USER varchar(9) NULL,UPD_DATE datetime NULL, VOID varchar(9) NULL,VOIDUSER varchar(9) NULL,	VOIDDATE datetime NULL,AUTHORISED varchar(2) NULL,AUTHORISE_LEVEL1 varchar(2) NULL,AUTHORISE_USER1 varchar(20) NULL,AUTHORISE_DATE1 datetime NULL, AUTHORISE_LEVEL2 varchar(2) NULL,AUTHORISE_USER2 varchar(20) NULL,AUTHORISE_DATE2 datetime NULL, AUTHORISE_LEVEL3 varchar(2) NULL,AUTHORISE_USER3 varchar(20) NULL,AUTHORISE_DATE3 datetime NULL,INPUTTAXACCOUNTIN varchar(50) NULL,inputtaxaccountinDESC varchar(50) NULL, INPUTTAXSLCODEIN varchar(50) NULL, inputtaxSLDESC varchar(100) NULL ) "
            gconnection.dataOperation1(1, SQLSTRING)
        End If

        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'taxcode')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD taxcode varchar(10)        END "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'taxdesc')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD taxdesc varchar(50)        END  "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'taxpercentage')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD taxpercentage numeric(18,2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'typeoftax')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD typeoftax varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'glaccountin')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD glaccountin varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'glaccountdesc')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD glaccountdesc varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'subledgercode')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD subledgercode varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'subledgerdesc')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD subledgerdesc varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'costcentercode')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD costcentercode varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'costcenterdesc')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD costcenterdesc varchar(50)        END   "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'adduserid')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD adduserid varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'adddatetime')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD adddatetime datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'updateuserid')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD updateuserid varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'updatedatetime')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD updatedatetime datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try

            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'freezeflag')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD freezeflag varchar(1)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'freezeuserid')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD freezeuserid varchar(50)        END   "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'freezedatetime')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD freezedatetime datetime        END"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'ADD_DATE')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD ADD_DATE datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'ADD_USER')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD ADD_USER varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'UPD_USER')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD UPD_USER varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'UPD_DATE')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD UPD_DATE datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        'Try
        '    SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'VOID')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD VOID varchar(9)        END    "
        '    gconnection.dataOperation1(1, SQLSTRING)
        'Catch
        'End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'VOIDUSER')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD VOIDUSER varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'VOIDDATE')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD VOIDDATE datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'AUTHORISED')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD AUTHORISED varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'AUTHORISE_LEVEL1')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD AUTHORISE_LEVEL1 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'AUTHORISE_USER1')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD AUTHORISE_USER1 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'AUTHORISE_DATE1')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD AUTHORISE_DATE1 datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try

        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'AUTHORISE_LEVEL2')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD AUTHORISE_LEVEL2 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'AUTHORISE_USER2')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD AUTHORISE_USER2 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'AUTHORISE_DATE2')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD AUTHORISE_DATE2 datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'AUTHORISE_LEVEL3')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD AUTHORISE_LEVEL3 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'AUTHORISE_USER3')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD AUTHORISE_USER3 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'AUTHORISE_DATE3')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD AUTHORISE_DATE3 datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'INPUTTAXACCOUNTIN')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD INPUTTAXACCOUNTIN varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'inputtaxaccountinDESC')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD inputtaxaccountinDESC varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'INPUTTAXSLCODEIN')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD INPUTTAXSLCODEIN varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='ACCOUNTSTAXMASTER' AND column_name = 'inputtaxSLDESC')        BEGIN ALTER TABLE dbo.ACCOUNTSTAXMASTER ADD inputtaxSLDESC varchar(100)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'taxcode')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD taxcode varchar(10)        END "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'taxdesc')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD taxdesc varchar(50)        END  "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'taxpercentage')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD taxpercentage numeric(18,2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'typeoftax')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD typeoftax varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'glaccountin')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD glaccountin varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'glaccountdesc')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD glaccountdesc varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'subledgercode')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD subledgercode varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'subledgerdesc')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD subledgerdesc varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'costcentercode')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD costcentercode varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'costcenterdesc')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD costcenterdesc varchar(50)        END   "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'adduserid')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD adduserid varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'adddatetime')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD adddatetime datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'updateuserid')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD updateuserid varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'updatedatetime')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD updatedatetime datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try

            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'freezeflag')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD freezeflag varchar(1)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'freezeuserid')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD freezeuserid varchar(50)        END   "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'freezedatetime')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD freezedatetime datetime        END"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'ADD_DATE')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD ADD_DATE datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'ADD_USER')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD ADD_USER varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'UPD_USER')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD UPD_USER varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'UPD_DATE')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD UPD_DATE datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'VOID')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD VOID varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'VOIDUSER')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD VOIDUSER varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'VOIDDATE')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD VOIDDATE datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'AUTHORISED')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD AUTHORISED varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'AUTHORISE_LEVEL1')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD AUTHORISE_LEVEL1 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'AUTHORISE_USER1')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD AUTHORISE_USER1 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'AUTHORISE_DATE1')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD AUTHORISE_DATE1 datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try

        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'AUTHORISE_LEVEL2')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD AUTHORISE_LEVEL2 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'AUTHORISE_USER2')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD AUTHORISE_USER2 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'AUTHORISE_DATE2')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD AUTHORISE_DATE2 datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'AUTHORISE_LEVEL3')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD AUTHORISE_LEVEL3 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'AUTHORISE_USER3')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD AUTHORISE_USER3 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'AUTHORISE_DATE3')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD AUTHORISE_DATE3 datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'INPUTTAXACCOUNTIN')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD INPUTTAXACCOUNTIN varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'inputtaxaccountinDESC')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD inputtaxaccountinDESC varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'INPUTTAXSLCODEIN')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD INPUTTAXSLCODEIN varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='accountstaxmaster_LOG' AND column_name = 'inputtaxSLDESC')        BEGIN ALTER TABLE dbo.accountstaxmaster_LOG ADD inputtaxSLDESC varchar(100)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
    End Sub
    '  Private Sub updatetables2000()

    'IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='itemmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[itemmaster]' AND column_name = 'TAXTYPE'      ))begin ALTER TABLE [dbo].[itemmaster] ADD TAXTYPE varchar(20)  end      



    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='itemmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[itemmaster]' AND column_name = 'TAXTYPE'      ))begin ALTER TABLE [dbo].[itemmaster] ADD TAXTYPE varchar(20)  end      




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='subscriptionmast' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[subscriptionmast]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[subscriptionmast] ADD SACNO varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='subscriptionmast' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[subscriptionmast]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[subscriptionmast] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[inventoryitemmaster]' and column_name= 'HSNNO'      )) begin ALTER TABLE [dbo].[inventoryitemmaster] ADD HSNNO varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[inventoryitemmaster]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[inventoryitemmaster] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='INV_inventoryitemmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[INV_inventoryitemmaster]' and column_name= 'HSNNO'      )) begin ALTER TABLE [dbo].[INV_inventoryitemmaster] ADD HSNNO varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='INV_inventoryitemmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[INV_inventoryitemmaster]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[INV_inventoryitemmaster] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSSUBLEDGERMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSSUBLEDGERMASTER]' and column_name= 'VORTYPE'      )) begin ALTER TABLE [dbo].[ACCOUNTSSUBLEDGERMASTER] ADD VORTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSSUBLEDGERMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSSUBLEDGERMASTER]' and column_name= 'GSTINNO'      )) begin ALTER TABLE [dbo].[ACCOUNTSSUBLEDGERMASTER] ADD GSTINNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='party_hallmaster_HDR' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[party_hallmaster_HDR]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[party_hallmaster_HDR] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='party_hallmaster_HDR' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[party_hallmaster_HDR]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[party_hallmaster_HDR] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_itemmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[PARTY_itemmaster]' and column_name= 'HSNNO'      )) begin ALTER TABLE [dbo].[PARTY_itemmaster] ADD HSNNO varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_itemmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[PARTY_itemmaster]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[PARTY_itemmaster] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_TARIFFHDR' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[PARTY_TARIFFHDR]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[PARTY_TARIFFHDR] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_TARIFFHDR' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[PARTY_TARIFFHDR]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[PARTY_TARIFFHDR] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='EV_EVENTS_HDR' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[EV_EVENTS_HDR]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[EV_EVENTS_HDR] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='EV_EVENTS_HDR' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[EV_EVENTS_HDR]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[EV_EVENTS_HDR] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='CHARGEMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[CHARGEMASTER]' and column_name= 'TYPEOFTAX'      )) begin ALTER TABLE [dbo].[CHARGEMASTER] ADD TYPEOFTAX varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='CHARGEMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[CHARGEMASTER]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[CHARGEMASTER] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='gr_locationmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[gr_locationmaster]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[gr_locationmaster] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='gr_locationmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[gr_locationmaster]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[gr_locationmaster] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_GREENFEEMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_GREENFEEMASTER]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[GMS_GREENFEEMASTER] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_GREENFEEMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_GREENFEEMASTER]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[GMS_GREENFEEMASTER] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_BALLRATEMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_BALLRATEMASTER]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[GMS_BALLRATEMASTER] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_BALLRATEMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_BALLRATEMASTER]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[GMS_BALLRATEMASTER] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_SALEITEMMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_SALEITEMMASTER]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[GMS_SALEITEMMASTER] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_SALEITEMMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_SALEITEMMASTER]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[GMS_SALEITEMMASTER] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CAMPMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_CAMPMASTER]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[GMS_CAMPMASTER] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CAMPMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_CAMPMASTER]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[GMS_CAMPMASTER] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CARTFEEMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_CARTFEEMASTER]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[GMS_CARTFEEMASTER] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CARTFEEMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_CARTFEEMASTER]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[GMS_CARTFEEMASTER] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_TOURNAMENTMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_TOURNAMENTMASTER]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[GMS_TOURNAMENTMASTER] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_TOURNAMENTMASTER' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[GMS_TOURNAMENTMASTER]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[GMS_TOURNAMENTMASTER] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='RoomAccountPostingSetupMaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[RoomAccountPostingSetupMaster]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[RoomAccountPostingSetupMaster] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='RoomAccountPostingSetupMaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[RoomAccountPostingSetupMaster]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[RoomAccountPostingSetupMaster] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ROOM_Accounts_SETUP' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ROOM_Accounts_SETUP]' and column_name= 'TAXTYPE'      )) begin ALTER TABLE [dbo].[ROOM_Accounts_SETUP] ADD TAXTYPE varchar(20)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ROOM_Accounts_SETUP' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ROOM_Accounts_SETUP]' and column_name= 'SACNO'      )) begin ALTER TABLE [dbo].[ROOM_Accounts_SETUP] ADD SACNO varchar(50)       end




    '         IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster' AND NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[inventoryitemmaster]' and column_name= 'TAXGROUPCODE'      )) begin ALTER TABLE [dbo].[inventoryitemmaster] ADD TAXGROUPCODE varchar(20)       end




    '                                                                                                                                                                  go()

    '                  CREATE view [dbo].[view_inventoryitemmaster]  as  select * from INVENTORYItemmaster WHERE STORECODE in(SELECT STORECODE FROM STOREMASTER WHERE Storestatus='M'    )



    '                                                                                                                                                                  go()

    '          CREATE TABLE [dbo].[ACCOUNTSTAXGROUPMASTER](	[AUTOID] [int] IDENTITY(1,1) NOT NULL,	[GROUPCODE] [varchar](15) NULL,	[GROUPNAME] [varchar](50) NULL,	[TAXCODE] [varchar](20) NULL,	[TAXDESC] [varchar](100) NULL,	[TAXpercentage] [numeric](18, 2) NULL,	[typeoftax] [varchar](30) NULL,	[ADDUSERID] [varchar](30) NULL,	[ADDDATE] [datetime] NULL,	[VOID] [varchar](1) NULL,	[VOIDUSER] [varchar](25) NULL,	[VOIDDATE] [datetime] NULL,	[AUTHTHORISEUSER1] [varchar](20) NULL,	[AUTHORISED] [varchar](2) NULL,	[AUTHORISE_LEVEL1] [varchar](2) NULL,	[AUTHORISE_USER1] [varchar](20) NULL,	[AUTHORISE_DATE1] [datetime] NULL,	[AUTHORISE_LEVEL2] [varchar](2) NULL,	[AUTHORISE_USER2] [varchar](20) NULL,	[AUTHORISE_DATE2] [datetime] NULL,	[AUTHORISE_LEVEL3] [varchar](2) NULL,	[AUTHORISE_USER3] [varchar](20) NULL,	[AUTHORISE_DATE3] [datetime] NULL )


    '                                                                                                                                                                  go()

    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTOID'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTOID intEGER IDENTITY(1,1)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'GROUPCODE'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD GROUPCODE varchar(15)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'GROUPNAME'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD GROUPNAME varchar(50)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'TAXCODE'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD TAXCODE varchar(20)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'TAXDESC'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD TAXDESC varchar(100)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'TAXpercentage'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD TAXpercentage numeric(18,2)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'typeoftax'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD typeoftax varchar(30)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'ADDUSERID'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD ADDUSERID varchar(30)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'ADDDATE'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD ADDDATE datetime      end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'VOID'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD VOID varchar(1)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'VOIDUSER'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD VOIDUSER varchar(25)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'VOIDDATE'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD VOIDDATE datetime      end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHTHORISEUSER1'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHTHORISEUSER1 varchar(20)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHORISED'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISED varchar(2)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHORISE_LEVEL1'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_LEVEL1 varchar(2)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHORISE_USER1'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_USER1 varchar(20)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHORISE_DATE1'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_DATE1 datetime       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHORISE_LEVEL2'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_LEVEL2 varchar(2)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHORISE_USER2'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_USER2 varchar(20)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHORISE_DATE2'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_DATE2 datetime     end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHORISE_LEVEL3'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_LEVEL3 varchar(2)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHORISE_USER3'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_USER3 varchar(20)       end




    '          IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXGROUPMASTER]' and column_name= 'AUTHORISE_DATE3'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_DATE3 datetime       end




    '           CREATE TABLE [dbo].[accountstaxmaster_LOG](	[taxcode] [varchar](10) NOT NULL,	[taxdesc] [varchar](50) NULL,	[taxpercentage] [numeric](10, 2) NULL,	[typeoftax] [varchar](20) NULL,	[glaccountin] [varchar](10) NULL,	[glaccountdesc] [varchar](50) NULL,	[subledgercode] [varchar](10) NULL,	[subledgerdesc] [varchar](50) NULL,	[costcentercode] [varchar](10) NULL,	[costcenterdesc] [varchar](50) NULL,	[adduserid] [varchar](50) NULL,	[adddatetime] [datetime] NULL,	[updateuserid] [varchar](50) NULL,	[updatedatetime] [datetime] NULL,	[freezeflag] [varchar](1) NULL,	[freezeuserid] [varchar](50) NULL,	[freezedatetime] [datetime] NULL,	[ADD_DATE] [datetime] NULL,[ADD_USER] [varchar](50) NULL, [UPD_USER] [varchar](9) NULL,[UPD_DATE] [datetime] NULL, [VOID] [varchar](9) NULL,[VOIDUSER] [varchar](9) NULL,	[VOIDDATE] [datetime] NULL,[AUTHORISED] [varchar](2) NULL,[AUTHORISE_LEVEL1] [varchar](2) NULL,[AUTHORISE_USER1] [varchar](20) NULL,[AUTHORISE_DATE1] [datetime] NULL, [AUTHORISE_LEVEL2] [varchar](2) NULL,[AUTHORISE_USER2] [varchar](20) NULL,[AUTHORISE_DATE2] [datetime] NULL, [AUTHORISE_LEVEL3] [varchar](2) NULL,[AUTHORISE_USER3] [varchar](20) NULL,[AUTHORISE_DATE3] [datetime] NULL,[INPUTTAXACCOUNTIN] [varchar](50) NULL,[inputtaxaccountinDESC] [varchar](50) NULL, [INPUTTAXSLCODEIN] [varchar](50) NULL, [inputtaxSLDESC] [varchar](100) NULL )



    '           CREATE TABLE [dbo].[accountstaxmaster](	[taxcode] [varchar](10) NOT NULL,	[taxdesc] [varchar](50) NULL,	[taxpercentage] [numeric](10, 2) NULL,	[typeoftax] [varchar](20) NULL,	[glaccountin] [varchar](10) NULL,	[glaccountdesc] [varchar](50) NULL,	[subledgercode] [varchar](10) NULL,	[subledgerdesc] [varchar](50) NULL,	[costcentercode] [varchar](10) NULL,	[costcenterdesc] [varchar](50) NULL,	[adduserid] [varchar](50) NULL,	[adddatetime] [datetime] NULL,	[updateuserid] [varchar](50) NULL,	[updatedatetime] [datetime] NULL,	[freezeflag] [varchar](1) NULL,	[freezeuserid] [varchar](50) NULL,	[freezedatetime] [datetime] NULL,	[ADD_DATE] [datetime] NULL,[ADD_USER] [varchar](50) NULL, [UPD_USER] [varchar](9) NULL,[UPD_DATE] [datetime] NULL, [VOID] [varchar](9) NULL,[VOIDUSER] [varchar](9) NULL,	[VOIDDATE] [datetime] NULL,[AUTHORISED] [varchar](2) NULL,[AUTHORISE_LEVEL1] [varchar](2) NULL,[AUTHORISE_USER1] [varchar](20) NULL,[AUTHORISE_DATE1] [datetime] NULL, [AUTHORISE_LEVEL2] [varchar](2) NULL,[AUTHORISE_USER2] [varchar](20) NULL,[AUTHORISE_DATE2] [datetime] NULL, [AUTHORISE_LEVEL3] [varchar](2) NULL,[AUTHORISE_USER3] [varchar](20) NULL,[AUTHORISE_DATE3] [datetime] NULL,[INPUTTAXACCOUNTIN] [varchar](50) NULL,[inputtaxaccountinDESC] [varchar](50) NULL, [INPUTTAXSLCODEIN] [varchar](50) NULL, [inputtaxSLDESC] [varchar](100) NULL )




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'taxcode'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD taxcode varchar(10)        end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'taxdesc'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD taxdesc varchar(50)         end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'taxpercentage'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD taxpercentage numeric(18,2)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'typeoftax'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD typeoftax varchar(20)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'glaccountin'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD glaccountin varchar(10)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'glaccountdesc'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD glaccountdesc varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'subledgercode'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD subledgercode varchar(10)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'subledgerdesc'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD subledgerdesc varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'costcentercode'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD costcentercode varchar(10)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'costcenterdesc'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD costcenterdesc varchar(50)          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'adduserid'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD adduserid varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'adddatetime'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD adddatetime datetime          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'updateuserid'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD updateuserid varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'updatedatetime'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD updatedatetime datetime           end





    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'freezeflag'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD freezeflag varchar(1)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'freezeuserid'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD freezeuserid varchar(50)          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'freezedatetime'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD freezedatetime datetime       end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'ADD_DATE'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD ADD_DATE datetime           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'ADD_USER'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD ADD_USER varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'UPD_USER'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD UPD_USER varchar(9)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'UPD_DATE'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD UPD_DATE datetime          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'VOID'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD VOID varchar(9)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'VOIDUSER'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD VOIDUSER varchar(9)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'VOIDDATE'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD VOIDDATE datetime          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'AUTHORISED'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISED varchar(2)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'AUTHORISE_LEVEL1'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_LEVEL1 varchar(2)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'AUTHORISE_USER1'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_USER1 varchar(20)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'AUTHORISE_DATE1'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_DATE1 datetime           end





    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'AUTHORISE_LEVEL2'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_LEVEL2 varchar(2)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'AUTHORISE_USER2'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_USER2 varchar(20)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'AUTHORISE_DATE2'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_DATE2 datetime          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'AUTHORISE_LEVEL3'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_LEVEL3 varchar(2)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'AUTHORISE_USER3'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_USER3 varchar(20)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'AUTHORISE_DATE3'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_DATE3 datetime           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'INPUTTAXACCOUNTIN'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD INPUTTAXACCOUNTIN varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'inputtaxaccountinDESC'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD inputtaxaccountinDESC varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'INPUTTAXSLCODEIN'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD INPUTTAXSLCODEIN varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[ACCOUNTSTAXMASTER]' and column_name= 'inputtaxSLDESC'      )) begin ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD inputtaxSLDESC varchar(100)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'taxcode'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD taxcode varchar(10)        end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'taxdesc'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD taxdesc varchar(50)         end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'taxpercentage'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD taxpercentage numeric(18,2)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'typeoftax'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD typeoftax varchar(20)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'glaccountin'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD glaccountin varchar(10)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'glaccountdesc'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD glaccountdesc varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'subledgercode'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD subledgercode varchar(10)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'subledgerdesc'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD subledgerdesc varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'costcentercode'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD costcentercode varchar(10)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'costcenterdesc'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD costcenterdesc varchar(50)          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'adduserid'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD adduserid varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'adddatetime'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD adddatetime datetime          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'updateuserid'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD updateuserid varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'updatedatetime'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD updatedatetime datetime           end





    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'freezeflag'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD freezeflag varchar(1)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'freezeuserid'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD freezeuserid varchar(50)          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'freezedatetime'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD freezedatetime datetime       end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'ADD_DATE'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD ADD_DATE datetime           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'ADD_USER'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD ADD_USER varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'UPD_USER'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD UPD_USER varchar(9)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'UPD_DATE'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD UPD_DATE datetime          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'VOID'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD VOID varchar(9)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'VOIDUSER'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD VOIDUSER varchar(9)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'VOIDDATE'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD VOIDDATE datetime          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'AUTHORISED'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISED varchar(2)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'AUTHORISE_LEVEL1'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_LEVEL1 varchar(2)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'AUTHORISE_USER1'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_USER1 varchar(20)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'AUTHORISE_DATE1'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_DATE1 datetime           end





    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'AUTHORISE_LEVEL2'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_LEVEL2 varchar(2)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'AUTHORISE_USER2'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_USER2 varchar(20)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'AUTHORISE_DATE2'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_DATE2 datetime          end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'AUTHORISE_LEVEL3'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_LEVEL3 varchar(2)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'AUTHORISE_USER3'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_USER3 varchar(20)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'AUTHORISE_DATE3'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_DATE3 datetime           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'INPUTTAXACCOUNTIN'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD INPUTTAXACCOUNTIN varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'inputtaxaccountinDESC'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD inputtaxaccountinDESC varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'INPUTTAXSLCODEIN'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD INPUTTAXSLCODEIN varchar(50)           end




    '          IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG' AND  NOT EXISTS (SELECT 1  FROM information_schema.COLUMNS WHERE  table_name='[accountstaxmaster_LOG]' and column_name= 'inputtaxSLDESC'      )) begin ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD inputtaxSLDESC varchar(100)           end



    '  End Sub
    Private Sub UPDATETABLES()
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='itemmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[itemmaster]') AND name = 'HSNNO')        BEGIN ALTER TABLE [dbo].[itemmaster] ADD HSNNO varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='itemmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[itemmaster]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[itemmaster] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='subscriptionmast') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[subscriptionmast]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[subscriptionmast] ADD SACNO varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='subscriptionmast') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[subscriptionmast]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[subscriptionmast] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[inventoryitemmaster]') AND name = 'HSNNO')        BEGIN ALTER TABLE [dbo].[inventoryitemmaster] ADD HSNNO varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[inventoryitemmaster]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[inventoryitemmaster] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='INV_inventoryitemmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[INV_inventoryitemmaster]') AND name = 'HSNNO')        BEGIN ALTER TABLE [dbo].[INV_inventoryitemmaster] ADD HSNNO varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='INV_inventoryitemmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[INV_inventoryitemmaster]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[INV_inventoryitemmaster] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSSUBLEDGERMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSSUBLEDGERMASTER]') AND name = 'VENDORTYPE')        BEGIN ALTER TABLE [dbo].[ACCOUNTSSUBLEDGERMASTER] ADD VENDORTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSSUBLEDGERMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSSUBLEDGERMASTER]') AND name = 'GSTINNO')        BEGIN ALTER TABLE [dbo].[ACCOUNTSSUBLEDGERMASTER] ADD GSTINNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='party_hallmaster_HDR') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[party_hallmaster_HDR]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[party_hallmaster_HDR] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='party_hallmaster_HDR') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[party_hallmaster_HDR]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[party_hallmaster_HDR] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_itemmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[PARTY_itemmaster]') AND name = 'HSNNO')        BEGIN ALTER TABLE [dbo].[PARTY_itemmaster] ADD HSNNO varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_itemmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[PARTY_itemmaster]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[PARTY_itemmaster] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_TARIFFHDR') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[PARTY_TARIFFHDR]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[PARTY_TARIFFHDR] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='PARTY_TARIFFHDR') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[PARTY_TARIFFHDR]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[PARTY_TARIFFHDR] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='EV_EVENTS_HDR') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[EV_EVENTS_HDR]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[EV_EVENTS_HDR] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='EV_EVENTS_HDR') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[EV_EVENTS_HDR]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[EV_EVENTS_HDR] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='CHARGEMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[CHARGEMASTER]') AND name = 'TYPEOFTAX')        BEGIN ALTER TABLE [dbo].[CHARGEMASTER] ADD TYPEOFTAX varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='CHARGEMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[CHARGEMASTER]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[CHARGEMASTER] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='gr_locationmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[gr_locationmaster]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[gr_locationmaster] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='gr_locationmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[gr_locationmaster]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[gr_locationmaster] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_GREENFEEMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_GREENFEEMASTER]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[GMS_GREENFEEMASTER] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_GREENFEEMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_GREENFEEMASTER]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[GMS_GREENFEEMASTER] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_BALLRATEMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_BALLRATEMASTER]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[GMS_BALLRATEMASTER] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_BALLRATEMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_BALLRATEMASTER]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[GMS_BALLRATEMASTER] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_SALEITEMMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_SALEITEMMASTER]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[GMS_SALEITEMMASTER] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_SALEITEMMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_SALEITEMMASTER]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[GMS_SALEITEMMASTER] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CAMPMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_CAMPMASTER]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[GMS_CAMPMASTER] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CAMPMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_CAMPMASTER]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[GMS_CAMPMASTER] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CARTFEEMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_CARTFEEMASTER]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[GMS_CARTFEEMASTER] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_CARTFEEMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_CARTFEEMASTER]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[GMS_CARTFEEMASTER] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_TOURNAMENTMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_TOURNAMENTMASTER]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[GMS_TOURNAMENTMASTER] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='GMS_TOURNAMENTMASTER') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[GMS_TOURNAMENTMASTER]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[GMS_TOURNAMENTMASTER] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='RoomAccountPostingSetupMaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[RoomAccountPostingSetupMaster]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[RoomAccountPostingSetupMaster] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='RoomAccountPostingSetupMaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[RoomAccountPostingSetupMaster]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[RoomAccountPostingSetupMaster] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ROOM_Accounts_SETUP') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ROOM_Accounts_SETUP]') AND name = 'TAXTYPE')        BEGIN ALTER TABLE [dbo].[ROOM_Accounts_SETUP] ADD TAXTYPE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ROOM_Accounts_SETUP') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ROOM_Accounts_SETUP]') AND name = 'SACNO')        BEGIN ALTER TABLE [dbo].[ROOM_Accounts_SETUP] ADD SACNO varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster') AND NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[inventoryitemmaster]') AND name = 'TAXGROUPCODE')        BEGIN ALTER TABLE [dbo].[inventoryitemmaster] ADD TAXGROUPCODE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = "SELECT 1 FROM SYSOBJECTS WHERE NAME ='inventoryitemmaster'"
            gconnection.getDataSet(SQLSTRING, "INV")
            If gdataset.Tables("INV").Rows.Count > 0 Then
                SQLSTRING = "SELECT 1 FROM SYSOBJECTS WHERE NAME ='view_inventoryitemmaster'"
                gconnection.getDataSet(SQLSTRING, "INV1")
                If gdataset.Tables("INV1").Rows.Count > 0 Then
                Else
                    SQLSTRING = " CREATE view [dbo].[view_inventoryitemmaster]  as  select * from INVENTORYItemmaster WHERE STORECODE in(SELECT STORECODE FROM STOREMASTER WHERE Storestatus='M')     "
                    gconnection.dataOperation1(1, SQLSTRING)
                End If
            End If

        Catch
        End Try
        SQLSTRING = "SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER'"
        gconnection.getDataSet(SQLSTRING, "INV")
        If gdataset.Tables("INV").Rows.Count > 0 Then
        Else
            SQLSTRING = " CREATE TABLE [dbo].[ACCOUNTSTAXGROUPMASTER](	[AUTOID] [int] IDENTITY(1,1) NOT NULL,	[GROUPCODE] [varchar](15) NULL,	[GROUPNAME] [varchar](50) NULL,	[TAXCODE] [varchar](20) NULL,	[TAXDESC] [varchar](100) NULL,	[TAXpercentage] [numeric](18, 2) NULL,	[typeoftax] [varchar](30) NULL,	[ADDUSERID] [varchar](30) NULL,	[ADDDATE] [datetime] NULL,	[VOID] [varchar](1) NULL,	[VOIDUSER] [varchar](25) NULL,	[VOIDDATE] [datetime] NULL,	[AUTHTHORISEUSER1] [varchar](20) NULL,	[AUTHORISED] [varchar](2) NULL,	[AUTHORISE_LEVEL1] [varchar](2) NULL,	[AUTHORISE_USER1] [varchar](20) NULL,	[AUTHORISE_DATE1] [datetime] NULL,	[AUTHORISE_LEVEL2] [varchar](2) NULL,	[AUTHORISE_USER2] [varchar](20) NULL,	[AUTHORISE_DATE2] [datetime] NULL,	[AUTHORISE_LEVEL3] [varchar](2) NULL,	[AUTHORISE_USER3] [varchar](20) NULL,	[AUTHORISE_DATE3] [datetime] NULL )"
            gconnection.dataOperation1(1, SQLSTRING)
        End If
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTOID')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTOID intEGER IDENTITY(1,1)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'GROUPCODE')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD GROUPCODE varchar(15)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'GROUPNAME')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD GROUPNAME varchar(50)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'TAXCODE')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD TAXCODE varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'TAXDESC')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD TAXDESC varchar(100)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'TAXpercentage')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD TAXpercentage numeric(18,2)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'typeoftax')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD typeoftax varchar(30)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'ADDUSERID')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD ADDUSERID varchar(30)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'ADDDATE')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD ADDDATE datetime       End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'VOID')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD VOID varchar(1)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'VOIDUSER')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD VOIDUSER varchar(25)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'VOIDDATE')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD VOIDDATE datetime       End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHTHORISEUSER1')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHTHORISEUSER1 varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHORISED')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISED varchar(2)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHORISE_LEVEL1')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_LEVEL1 varchar(2)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHORISE_USER1')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_USER1 varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHORISE_DATE1')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_DATE1 datetime        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHORISE_LEVEL2')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_LEVEL2 varchar(2)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHORISE_USER2')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_USER2 varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHORISE_DATE2')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_DATE2 datetime      End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHORISE_LEVEL3')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_LEVEL3 varchar(2)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHORISE_USER3')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_USER3 varchar(20)        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXGROUPMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXGROUPMASTER]') AND name = 'AUTHORISE_DATE3')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXGROUPMASTER] ADD AUTHORISE_DATE3 datetime        End"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        SQLSTRING = "SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG'"
        gconnection.getDataSet(SQLSTRING, "INV")
        If gdataset.Tables("INV").Rows.Count > 0 Then
        Else
            SQLSTRING = "  CREATE TABLE [dbo].[accountstaxmaster_LOG](	[taxcode] [varchar](10) NOT NULL,	[taxdesc] [varchar](50) NULL,	[taxpercentage] [numeric](10, 2) NULL,	[typeoftax] [varchar](20) NULL,	[glaccountin] [varchar](10) NULL,	[glaccountdesc] [varchar](50) NULL,	[subledgercode] [varchar](10) NULL,	[subledgerdesc] [varchar](50) NULL,	[costcentercode] [varchar](10) NULL,	[costcenterdesc] [varchar](50) NULL,	[adduserid] [varchar](50) NULL,	[adddatetime] [datetime] NULL,	[updateuserid] [varchar](50) NULL,	[updatedatetime] [datetime] NULL,	[freezeflag] [varchar](1) NULL,	[freezeuserid] [varchar](50) NULL,	[freezedatetime] [datetime] NULL,	[ADD_DATE] [datetime] NULL,[ADD_USER] [varchar](50) NULL, [UPD_USER] [varchar](9) NULL,[UPD_DATE] [datetime] NULL, [VOID] [varchar](9) NULL,[VOIDUSER] [varchar](9) NULL,	[VOIDDATE] [datetime] NULL,[AUTHORISED] [varchar](2) NULL,[AUTHORISE_LEVEL1] [varchar](2) NULL,[AUTHORISE_USER1] [varchar](20) NULL,[AUTHORISE_DATE1] [datetime] NULL, [AUTHORISE_LEVEL2] [varchar](2) NULL,[AUTHORISE_USER2] [varchar](20) NULL,[AUTHORISE_DATE2] [datetime] NULL, [AUTHORISE_LEVEL3] [varchar](2) NULL,[AUTHORISE_USER3] [varchar](20) NULL,[AUTHORISE_DATE3] [datetime] NULL,[INPUTTAXACCOUNTIN] [varchar](50) NULL,[inputtaxaccountinDESC] [varchar](50) NULL, [INPUTTAXSLCODEIN] [varchar](50) NULL, [inputtaxSLDESC] [varchar](100) NULL ) "
            gconnection.dataOperation1(1, SQLSTRING)
        End If
        SQLSTRING = "SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster'"
        gconnection.getDataSet(SQLSTRING, "INV")
        If gdataset.Tables("INV").Rows.Count > 0 Then
        Else
            SQLSTRING = "  CREATE TABLE [dbo].[accountstaxmaster](	[taxcode] [varchar](10) NOT NULL,	[taxdesc] [varchar](50) NULL,	[taxpercentage] [numeric](10, 2) NULL,	[typeoftax] [varchar](20) NULL,	[glaccountin] [varchar](10) NULL,	[glaccountdesc] [varchar](50) NULL,	[subledgercode] [varchar](10) NULL,	[subledgerdesc] [varchar](50) NULL,	[costcentercode] [varchar](10) NULL,	[costcenterdesc] [varchar](50) NULL,	[adduserid] [varchar](50) NULL,	[adddatetime] [datetime] NULL,	[updateuserid] [varchar](50) NULL,	[updatedatetime] [datetime] NULL,	[freezeflag] [varchar](1) NULL,	[freezeuserid] [varchar](50) NULL,	[freezedatetime] [datetime] NULL,	[ADD_DATE] [datetime] NULL,[ADD_USER] [varchar](50) NULL, [UPD_USER] [varchar](9) NULL,[UPD_DATE] [datetime] NULL, [VOID] [varchar](9) NULL,[VOIDUSER] [varchar](9) NULL,	[VOIDDATE] [datetime] NULL,[AUTHORISED] [varchar](2) NULL,[AUTHORISE_LEVEL1] [varchar](2) NULL,[AUTHORISE_USER1] [varchar](20) NULL,[AUTHORISE_DATE1] [datetime] NULL, [AUTHORISE_LEVEL2] [varchar](2) NULL,[AUTHORISE_USER2] [varchar](20) NULL,[AUTHORISE_DATE2] [datetime] NULL, [AUTHORISE_LEVEL3] [varchar](2) NULL,[AUTHORISE_USER3] [varchar](20) NULL,[AUTHORISE_DATE3] [datetime] NULL,[INPUTTAXACCOUNTIN] [varchar](50) NULL,[inputtaxaccountinDESC] [varchar](50) NULL, [INPUTTAXSLCODEIN] [varchar](50) NULL, [inputtaxSLDESC] [varchar](100) NULL ) "
            gconnection.dataOperation1(1, SQLSTRING)
        End If

        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'taxcode')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD taxcode varchar(10)        END "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'taxdesc')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD taxdesc varchar(50)        END  "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'taxpercentage')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD taxpercentage numeric(18,2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'typeoftax')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD typeoftax varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'glaccountin')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD glaccountin varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'glaccountdesc')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD glaccountdesc varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'subledgercode')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD subledgercode varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'subledgerdesc')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD subledgerdesc varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'costcentercode')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD costcentercode varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'costcenterdesc')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD costcenterdesc varchar(50)        END   "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'adduserid')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD adduserid varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'adddatetime')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD adddatetime datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'updateuserid')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD updateuserid varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'updatedatetime')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD updatedatetime datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try

            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'freezeflag')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD freezeflag varchar(1)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'freezeuserid')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD freezeuserid varchar(50)        END   "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'freezedatetime')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD freezedatetime datetime        END"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'ADD_DATE')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD ADD_DATE datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'ADD_USER')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD ADD_USER varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'UPD_USER')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD UPD_USER varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'UPD_DATE')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD UPD_DATE datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'VOID')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD VOID varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'VOIDUSER')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD VOIDUSER varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'VOIDDATE')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD VOIDDATE datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'AUTHORISED')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISED varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'AUTHORISE_LEVEL1')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_LEVEL1 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'AUTHORISE_USER1')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_USER1 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'AUTHORISE_DATE1')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_DATE1 datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try

        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'AUTHORISE_LEVEL2')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_LEVEL2 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'AUTHORISE_USER2')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_USER2 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'AUTHORISE_DATE2')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_DATE2 datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'AUTHORISE_LEVEL3')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_LEVEL3 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'AUTHORISE_USER3')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_USER3 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'AUTHORISE_DATE3')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD AUTHORISE_DATE3 datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'INPUTTAXACCOUNTIN')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD INPUTTAXACCOUNTIN varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'inputtaxaccountinDESC')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD inputtaxaccountinDESC varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'INPUTTAXSLCODEIN')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD INPUTTAXSLCODEIN varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='ACCOUNTSTAXMASTER') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[ACCOUNTSTAXMASTER]') AND name = 'inputtaxSLDESC')        BEGIN ALTER TABLE [dbo].[ACCOUNTSTAXMASTER] ADD inputtaxSLDESC varchar(100)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'taxcode')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD taxcode varchar(10)        END "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'taxdesc')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD taxdesc varchar(50)        END  "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'taxpercentage')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD taxpercentage numeric(18,2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'typeoftax')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD typeoftax varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'glaccountin')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD glaccountin varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'glaccountdesc')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD glaccountdesc varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'subledgercode')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD subledgercode varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'subledgerdesc')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD subledgerdesc varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'costcentercode')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD costcentercode varchar(10)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'costcenterdesc')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD costcenterdesc varchar(50)        END   "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'adduserid')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD adduserid varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'adddatetime')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD adddatetime datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'updateuserid')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD updateuserid varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'updatedatetime')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD updatedatetime datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try

            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'freezeflag')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD freezeflag varchar(1)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'freezeuserid')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD freezeuserid varchar(50)        END   "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'freezedatetime')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD freezedatetime datetime        END"
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'ADD_DATE')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD ADD_DATE datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'ADD_USER')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD ADD_USER varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'UPD_USER')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD UPD_USER varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'UPD_DATE')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD UPD_DATE datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'VOID')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD VOID varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'VOIDUSER')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD VOIDUSER varchar(9)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'VOIDDATE')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD VOIDDATE datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'AUTHORISED')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISED varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'AUTHORISE_LEVEL1')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_LEVEL1 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'AUTHORISE_USER1')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_USER1 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'AUTHORISE_DATE1')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_DATE1 datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try

        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'AUTHORISE_LEVEL2')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_LEVEL2 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'AUTHORISE_USER2')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_USER2 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'AUTHORISE_DATE2')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_DATE2 datetime       END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'AUTHORISE_LEVEL3')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_LEVEL3 varchar(2)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'AUTHORISE_USER3')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_USER3 varchar(20)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'AUTHORISE_DATE3')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD AUTHORISE_DATE3 datetime        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'INPUTTAXACCOUNTIN')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD INPUTTAXACCOUNTIN varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'inputtaxaccountinDESC')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD inputtaxaccountinDESC varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'INPUTTAXSLCODEIN')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD INPUTTAXSLCODEIN varchar(50)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        Try
            SQLSTRING = " IF  EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='accountstaxmaster_LOG') AND  NOT EXISTS (SELECT 1  FROM SYS.COLUMNS WHERE  OBJECT_ID = OBJECT_ID(N'[dbo].[accountstaxmaster_LOG]') AND name = 'inputtaxSLDESC')        BEGIN ALTER TABLE [dbo].[accountstaxmaster_LOG] ADD inputtaxSLDESC varchar(100)        END    "
            gconnection.dataOperation1(1, SQLSTRING)
        Catch
        End Try
        '  ,isnull(a.TAXTYPE,'') as LedgerName,ISNULL(SACNO,'')AS SACNO  from party_hallmaster_HDR 
        'isnull(a.,'') as LedgerName,ISNULL(,'')
    End Sub

    Private Sub updateitemledger()
        SQLSTRING = "update itemmaster set  ledgername=a.ledgername from categorywiseitemledgermapping a,itemledgercheck b where itemmaster.itemcode=b.itemcode  and a.poscode+a.category=b.poscode+b.category "
        gconnection.dataOperation1(1, SQLSTRING)
    End Sub
    '    
    'kga (16:21):
    'select  distinct poscode,posdesc,category, ledgername from itemledgercheck order by posdesc,category,ledgername,poscode
    Private Sub SYS_DATE_TIME()
        Dim sqlstring As String
        Try
            sqlstring = "SELECT SERVERDATE,SERVERTIME FROM VIEW_SERVER_DATETIME "
            gconnection.getDataSet(sqlstring, "SERVERDATE")
            If gdataset.Tables("SERVERDATE").Rows.Count > 0 Then
                SYSDATE = Format(gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERDATE"), "dd/MM/yyyy")
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid datetime :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Function GetFotoSetup()
        gconnection.getDataSet(" SELECT * FROM SM_FOTO_SETUP", "FOTO_SETUP")
        If gdataset.Tables("FOTO_SETUP").Rows.Count > 0 Then
            gFoto = gdataset.Tables("FOTO_SETUP").Rows(0).Item("STORE_IN_DB")
        Else
            gFoto = "N"
        End If
    End Function
    Public Sub Clearfiles()
        AppPath = Application.StartupPath
        Shell("CLEAR.BAT", AppWinStyle.Hide)
    End Sub
    Private Sub Activateuseradmin()
        Dim totmenu As Integer = 0
        Dim i, j, k, ckhmn, ckhmn1 As Integer
        Call menublock()
        For i = 0 To MainMenu1.MenuItems.Count - 2
            ckhmn1 = MainMenu1.MenuItems(i).MenuItems.Count()
            If ckhmn1 <> 0 Then
                For j = 0 To MainMenu1.MenuItems(i).MenuItems.Count() - 1
                    ckhmn = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count()
                    If ckhmn <> 0 Then
                        For k = 0 To MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count() - 1
                            totmenu = totmenu + 1
                        Next
                    Else
                        totmenu = totmenu + 1
                    End If
                Next
            Else
                totmenu = totmenu + 1
            End If
        Next
        gconnection.getDataSet("SELECT COUNT(*) FROM  modulemaster WHERE PackageName='ACCOUNTS INTEGRATION'", "chk")
        If gdataset.Tables("chk").Rows.Count <> totmenu Then
            gconnection.ExcuteStoreProcedure("DELETE FROM modulemaster WHERE PackageName='ACCOUNTS INTEGRATION'")
            Call checkmenulist()
        End If
        If gUserCategory = "S" Or gUserCategory = "A" Then
            Call menuclear()
        Else
            Call relemenu()
        End If
    End Sub
    Sub menuclear()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        vmain = MainMenu1.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = MainMenu1.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = True
                        Next
                    Else
                        MainMenu1.MenuItems(i).MenuItems(j).Enabled = True
                    End If
                Next
            Else
                MainMenu1.MenuItems(i).Enabled = True
            End If
        Next
    End Sub
    Sub menublock()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        vmain = MainMenu1.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = MainMenu1.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = False
                        Next
                    Else
                        MainMenu1.MenuItems(i).MenuItems(j).Enabled = False
                    End If
                Next
            Else
                MainMenu1.MenuItems(i).Enabled = False
            End If
        Next
    End Sub
    Sub relemenu()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql As String
        Dim ds As New DataSet
        Dim chstr As String
        gconnection.getDataSet("SELECT * FROM USERADMIN WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='ACCOUNTS INTEGRATION'", "user")
        If gdataset.Tables("user").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("user").Rows.Count - 1
                With gdataset.Tables("user").Rows(i)
                    If Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" And Trim(.Item("ssubmoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).MenuItems(Val(.Item("submoduleid"))).MenuItems(Val(.Item("ssubmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).MenuItems(Val(.Item("submoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    End If
                End With
            Next
        End If
    End Sub
    Public Sub checkmenulist()
        Dim i, j, k, x As Integer
        Dim vsql() As String
        Dim vmain, vsmod, vssmod As Long
        x = 0
        ReDim vsql(x)
        vmain = MainMenu1.MenuItems.Count
        If vmain <> 0 Then
            For i = 0 To vmain - 2
                vsmod = MainMenu1.MenuItems(i).MenuItems.Count
                If vsmod <> 0 Then
                    For j = 0 To vsmod - 1
                        vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                        If vssmod <> 0 Then
                            For k = 0 To vssmod - 1
                                vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & k & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Text.Replace("&", "") & "") & "','ACCOUNTS INTEGRATION')"
                                ReDim Preserve vsql(vsql.Length)
                            Next
                        Else
                            vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName ) values "
                            vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                            vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                            vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','ACCOUNTS INTEGRATION')"
                            ReDim Preserve vsql(vsql.Length)
                        End If
                    Next
                Else
                    vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','',"
                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','ACCOUNTS INTEGRATION')"
                    ReDim Preserve vsql(vsql.Length)
                End If
            Next
            ReDim Preserve vsql(vsql.Length - 2)
            gconnection.MoreTrans1(vsql)
        End If
    End Sub
    Private Sub GetAccountcode()
        Dim sqlstring As String
        sqlstring = "SELECT ISNULL(SDRSCODE,'') AS SDRSCODE,ISNULL(SCRSCODE,'') AS SCRSCODE FROM ACCOUNTSSETUP "
        gconnection.getDataSet(sqlstring, "ACCOUNTSSETUP")
        If gdataset.Tables("ACCOUNTSSETUP").Rows.Count > 0 Then
            gDebitors = Trim(UCase(gdataset.Tables("ACCOUNTSSETUP").Rows(0).Item("SDRSCODE")))
            gCreditors = Trim(UCase(gdataset.Tables("ACCOUNTSSETUP").Rows(0).Item("SCRSCODE")))
        Else
            gDebitors = ""
            gCreditors = ""
        End If
    End Sub
    Public Sub FillCompanyinfo()
        Dim sqlstring As String
        Try
            If Trim(gDatabase) <> "" Then
                sqlstring = " SELECT ISNULL(CompanyName,'') AS CompanyName,ISNULL(Fromdate,getdate()) AS Fromdate,ISNULL(Todate,getdate()) AS Todate,ISNULL(Add1,'') AS Add1,ISNULL(Add2,'') AS Add2,"
                sqlstring = sqlstring & " ISNULL(City,'') AS City,ISNULL(State,'') AS State,ISNULL(Pincode,'') AS Pincode,ISNULL(Datafile,'') AS Datafile FROM ClubMaster WHERE DATAFILE = '" & Trim(gDatabase) & "'"
            Else
                sqlstring = " SELECT ISNULL(CompanyName,'') AS CompanyName,ISNULL(Fromdate,getdate()) AS Fromdate,ISNULL(Todate,getdate()) AS Todate,ISNULL(Add1,'') AS Add1,ISNULL(Add2,'') AS Add2,"
                sqlstring = sqlstring & " ISNULL(City,'') AS City,ISNULL(State,'') AS State,ISNULL(Pincode,'') AS Pincode,ISNULL(Datafile,'') AS Datafile FROM ClubMaster "
            End If
            gconnection.getCompanyinfo(sqlstring, "ClubMaster")
            If gdataset.Tables("ClubMaster").Rows.Count > 0 Then
                MyCompanyName = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("CompanyName")))
                Address1 = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Add1")))
                Address2 = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Add2")))
                gCity = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("City")))
                gState = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("State")))
                gPincode = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Pincode")))
                gDatabase = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Datafile")))
                Me.Text = MyCompanyName & " [" & "POS" & " ] " & Trim(gUsername) & " " & Trim(gFinancalyearStart) & "-" & Trim(gFinancialYearEnd) & " ] Last Updated " & Format(dtCreationDate, "dd/MMM/yyyy HH:mm:ss") & " Size " & CStr(FileSize)
                'Me.Text = MyCompanyName & " [" & "POS" & " ]"
                If Mid(MyCompanyName, 1, 3) = "HIN" Then
                    PrintTaxheading1 = "C.F"
                    PrintTaxheading2 = "CHARGES"
                Else
                    PrintTaxheading1 = "VAT"
                    PrintTaxheading2 = ""
                End If
            Else
                MessageBox.Show("Plz. Contact to your Computer Administrator ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub MenuItem1_Select(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem1.Select
        'If itemmasterbool = False Then
        '    submnu_Itemmaster.Checked = False
        'End If
    End Sub

    Private Sub submnu_Calculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell(Environment.SystemDirectory & "\calc.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub submnu_Notepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Shell(Environment.SystemDirectory & "\notepad.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub submnu_Horizontal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub mnu_Exit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Exit.Click
    End Sub
    Private Sub submnu_Vertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub submnu_Cascade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub


    Private Sub submnu_Ratemaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Ratemaster As New RateMaster
        GmoduleName = "Rate Master"
        If RateMastbool = False Then
            Ratemaster.FormBorderStyle = FormBorderStyle.FixedDialog
            Ratemaster.MdiParent = Me
            Ratemaster.Show()
            Exit Sub
        End If
        Ratemaster.FormBorderStyle = FormBorderStyle.FixedDialog
        Ratemaster.MdiParent = Me
        Ratemaster.Show()
    End Sub


    Private Sub submnu_Tablemaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TableMaster As New TableMaster
        GmoduleName = "Table Master"
        If TableMastbool = False Then
            TableMaster.FormBorderStyle = FormBorderStyle.FixedDialog
            TableMaster.MdiParent = Me
            TableMaster.Show()
            Exit Sub
        End If
        TableMaster.FormBorderStyle = FormBorderStyle.FixedDialog
        TableMaster.MdiParent = Me
        TableMaster.Show()
    End Sub

    Private Sub submnu_POSdocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim POSDocument As New POSDocument
        GmoduleName = "POS Document"
        If posdocumentbool = False Then
            POSDocument.FormBorderStyle = FormBorderStyle.FixedDialog
            POSDocument.MdiParent = Me
            POSDocument.Show()
            Exit Sub
        End If
        POSDocument.FormBorderStyle = FormBorderStyle.FixedDialog
        POSDocument.MdiParent = Me
        POSDocument.Show()
    End Sub

    Private Sub submnu_UOMsalerelation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim UOMRealation As New SalesUOMRelation
        GmoduleName = "UOM Sale Relation"
        If UOMRelabool = False Then
            UOMRealation.FormBorderStyle = FormBorderStyle.FixedDialog
            UOMRealation.MdiParent = Me
            UOMRealation.Show()
            Exit Sub
        End If
        UOMRealation.FormBorderStyle = FormBorderStyle.FixedDialog
        UOMRealation.MdiParent = Me
        UOMRealation.Show()
    End Sub

    Private Sub submnu_Paymentmode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Paymentmode As New PaymentModeMaster
        GmoduleName = "Payment Mode Master"
        If Paymentmodebool = False Then
            Paymentmode.FormBorderStyle = FormBorderStyle.FixedDialog
            Paymentmode.MdiParent = Me
            Paymentmode.Show()
            Exit Sub
        End If
        Paymentmode.FormBorderStyle = FormBorderStyle.FixedDialog
        Paymentmode.MdiParent = Me
        Paymentmode.Show()
    End Sub

    Private Sub submnu_SubPaymentmode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim subpaymentmode As New SubPaymentMode
        GmoduleName = "Sub Payment Mode Master"
        If subpaymentmodebool = False Then
            subpaymentmode.FormBorderStyle = FormBorderStyle.FixedDialog
            subpaymentmode.MdiParent = Me
            subpaymentmode.Show()
            Exit Sub
        End If
        subpaymentmode.FormBorderStyle = FormBorderStyle.FixedDialog
        subpaymentmode.MdiParent = Me
        subpaymentmode.Show()
    End Sub
    Private Sub submnu_FinalBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Bill As New KOT_Billing
        GmoduleName = "Final Bill"
        If finalbillbool = False Then
            Bill.FormBorderStyle = FormBorderStyle.FixedDialog
            Bill.MdiParent = Me
            Bill.Show()
            Exit Sub
        End If
        Bill.FormBorderStyle = FormBorderStyle.FixedDialog
        Bill.MdiParent = Me
        Bill.Show()
    End Sub
    Private Sub submnu_ManualBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Billing"
        Dim DOCSelection As New DOCSelection
        DOCSelection.MdiParent = Me
        DOCSelection.Show()
    End Sub

    Private Sub submnu_CashReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Receipt As New CashReceipt
        GmoduleName = "Cash Receipt"
        If cashreceiptbool = False Then
            Receipt.FormBorderStyle = FormBorderStyle.FixedDialog
            Receipt.MdiParent = Me
            Receipt.Show()
            Exit Sub
        End If
        Receipt.FormBorderStyle = FormBorderStyle.FixedDialog
        Receipt.MdiParent = Me
        Receipt.Show()
    End Sub

    Private Sub Submnu_Datewisesales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GmoduleName = "Datewise Sales"
        'Dim ObjSalesRegisterDatewise As New SalesRegisterDatewise
        'ObjSalesRegisterDatewise.MdiParent = Me
        'ObjSalesRegisterDatewise.Show()
    End Sub




    Private Sub Submnu_Entrycontrols_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Entry Controls"
    End Sub


    Private Sub Submnu_Unrealisedasondate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "As on date"
    End Sub

    Private Sub Submnu_Unrealisedexcesslist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Excess List"
    End Sub

    Private Sub Submnu_Unrealisedbillshortlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Short List"
    End Sub





    Private Sub Submnu_SelectiveCROreceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim ObjSelectiveKOTReport As New frmSelectiveKOT
        'ObjSelectiveKOTReport.MdiParent = Me
        'ObjSelectiveKOTReport.Show()
    End Sub

    Private Sub Submnu_Selectiveroombill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub submnu_Accountposting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Objaccountposting As New Accountposting
        GmoduleName = "Account Posting"
        If Accountpostingbool = False Then
            Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
            Objaccountposting.MdiParent = Me
            Objaccountposting.Show()
            Exit Sub
        End If
        Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
        Objaccountposting.MdiParent = Me
        Objaccountposting.Show()
    End Sub

    Private Sub submnu_AutoServicebill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ObjAutoServiceBill As New AutoServicebill
        GmoduleName = "Auto Service Bill"
        If AutoServicebillbool = False Then
            ObjAutoServiceBill.FormBorderStyle = FormBorderStyle.FixedDialog
            ObjAutoServiceBill.MdiParent = Me
            ObjAutoServiceBill.Show()
            Exit Sub
        End If
        ObjAutoServiceBill.FormBorderStyle = FormBorderStyle.FixedDialog
        ObjAutoServiceBill.MdiParent = Me
        ObjAutoServiceBill.Show()
    End Sub

    Private Sub Submenu_SettlementReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Settlement Report"
        Dim objSelectivepaymentmode As New frmSelectivepaymentmode
        objSelectivepaymentmode.MdiParent = Me
        objSelectivepaymentmode.Show()
    End Sub


    Private Sub sub_mnupossetupmaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objPOSSETUPMASTER As New POSSETUPMASTER
        GmoduleName = "Pos Setup Master"
        If Possetupbool = False Then
            objPOSSETUPMASTER.FormBorderStyle = FormBorderStyle.FixedDialog
            objPOSSETUPMASTER.MdiParent = Me
            objPOSSETUPMASTER.Show()
            Exit Sub
        End If
        objPOSSETUPMASTER.FormBorderStyle = FormBorderStyle.FixedDialog
        objPOSSETUPMASTER.MdiParent = Me
        objPOSSETUPMASTER.Show()
    End Sub

    Private Sub submnu_Useradmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Uadmin As New UserAdmin
        If Me.DuplicateForm(Uadmin.Name) = False Then
            Uadmin.MdiParent = Me
            Uadmin.Show()
        End If
    End Sub
    Private Function DuplicateForm(ByVal FormName As String) As Boolean
        DuplicateForm = False
        Dim i As Integer
        If Me.MdiChildren Is Nothing Then
            Exit Function
        End If
        For i = 0 To Me.MdiChildren.Length - 1
            If Me.MdiChildren(i).Name = FormName Then
                GmoduleName = FormName
                DuplicateForm = True
                Exit Function
            End If
        Next i
    End Function

    Private Sub MDIForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'If e.KeyCode = Keys.F1 Then
        '    Dim objmemberhelp As New Memberhelp1
        '    objmemberhelp.MdiParent = Me
        '    objmemberhelp.Show()
        'End If
        'If e.Control = True AndAlso e.Alt = True And e.KeyCode = Keys.X Then
        '    If CtrlAltX = False Then
        '        CtrlAltX = True
        '        MenuItem2.Visible = True
        '    Else
        '        CtrlAltX = False
        '        MenuItem2.Visible = False
        '    End If

        'End If


    End Sub

    Private Sub Submnu_Itemmasterprinting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Submnu_pendingbill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Pending Bill"
        Dim ObjPendingBillRegister As New rptPendingbill
        ObjPendingBillRegister.MdiParent = Me
        ObjPendingBillRegister.Show()
    End Sub

    Private Sub submnu_Billstatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ObjBillstatus As New Billstatus
        GmoduleName = "BILL STATUS"
        If Billstatusbool = False Then
            ObjBillstatus.FormBorderStyle = FormBorderStyle.FixedDialog
            ObjBillstatus.MdiParent = Me
            ObjBillstatus.Show()
            Exit Sub
        End If
        ObjBillstatus.FormBorderStyle = FormBorderStyle.FixedDialog
        ObjBillstatus.MdiParent = Me
        ObjBillstatus.Show()
    End Sub

    Private Sub SubStoreItemMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Sub Store Item Master"
        Dim substoreitemmaster As New SUBSTORE_Item_Master
        substoreitemmaster.FormBorderStyle = FormBorderStyle.FixedDialog
        substoreitemmaster.MdiParent = Me
        substoreitemmaster.Show()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Bill OF Material Master"
        Dim BillOfMaterial As New BOM
        BillOfMaterial.FormBorderStyle = FormBorderStyle.FixedDialog
        BillOfMaterial.MdiParent = Me
        BillOfMaterial.Show()
    End Sub


    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Pending Bill"
        Dim ObjPendingBillRegister As New frmServerwisePendingKotRegister
        ObjPendingBillRegister.MdiParent = Me
        ObjPendingBillRegister.Show()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Cancel Item Register"
        Dim objcancelitemReg As New frmCancelItemRegister
        objcancelitemReg.MdiParent = Me
        objcancelitemReg.Show()
    End Sub
    Private Sub MDIForm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        '        Shell("CLEAR.BAT", AppWinStyle.Hide)
        End
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim Objaccountposting As New Accountpostingold
        Dim Objaccountposting As New Accountposting
        GmoduleName = "AccountPosting"
        If Accountpostingbool = False Then
            Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
            Objaccountposting.MdiParent = Me
            Objaccountposting.Show()
            Exit Sub
        End If
        Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
        Objaccountposting.MdiParent = Me
        Objaccountposting.Show()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ObjItemwisereport As New frmItemwisereport
        ObjItemwisereport.MdiParent = Me
        ObjItemwisereport.Show()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Kot Print Pos Wise"
        Dim Kotentry As New KOTPOSWISE("")
        Kotentry.Show()
    End Sub
    Private Sub MenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ObjServerwiseMember As New frmServerWiseMember
        ObjServerwiseMember.MdiParent = Me
        ObjServerwiseMember.Show()

    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objVatServicetax As New frmVatServiceTaxreport
        objVatServicetax.MdiParent = Me
        objVatServicetax.Show()
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Party Bill Posting (Party)"
        Dim objParty As New Accountposting_Party
        objParty.MdiParent = Me
        objParty.Show()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Club Account Posting (Club)"
        Dim objParty As New Accountposting_Submode
        objParty.MdiParent = Me
        objParty.Show()
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Others Posting"
        Dim objParty As New Accountposting_Others
        objParty.MdiParent = Me
        objParty.Show()
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Password"
        Dim objpassword As New frmPassword
        objpassword.MdiParent = Me
        objpassword.Show()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Autoservicebill"
        Dim objAutoservicebill As New AutoServicebill
        objAutoservicebill.MdiParent = Me
        objAutoservicebill.Show()

    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        MDIForm.ActiveForm.Visible = False
        Dim cmp As New CompanyList1
        cmp.Show()
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim PMODULEMASTER As New PosModuleMaster
        PMODULEMASTER.Show()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim COMPANYMASTER As New COMPANYMASTER

        COMPANYMASTER.Show()

    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If gTallyIntegration = "Y" Then
            Dim Objaccountposting As New Tallyposting
            GmoduleName = "Tally Posting"
            If Accountpostingbool = False Then
                Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
                Objaccountposting.MdiParent = Me
                Objaccountposting.Show()
                Exit Sub
            End If
            Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
            Objaccountposting.MdiParent = Me
            Objaccountposting.Show()
        Else
            MsgBox("Tally Integration option is not enabled......", MsgBoxStyle.OKOnly, "CLUBMAN")
        End If
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Sales Account Group Summary"
        Dim salesg As New frmSalesGroupSummary
        salesg.MdiParent = Me
        salesg.Show()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Ledger Account"
        Dim Laccount As New frmLedgeraccount
        Laccount.MdiParent = Me
        Laccount.Show()
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Smart Card Sales"
        Dim ObjSMartCardRegister As New SmartCardSalesRegister
        ObjSMartCardRegister.MdiParent = Me
        ObjSMartCardRegister.Show()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Sales Memberwise"
        Dim cash_userwise As New SalesMemberwise
        cash_userwise.MdiParent = Me
        cash_userwise.Show()
    End Sub
    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Final Billing"
        Dim objmanualbill As New KOT_Billing
        'Me.Hide()
        objmanualbill.FormBorderStyle = FormBorderStyle.FixedDialog
        objmanualbill.MdiParent = MDIParentobj
        ' Me.Close()
        objmanualbill.Show()
    End Sub
    Private Sub MenuItem8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "FSN Report"
        Dim fsn As New frmFSN
        fsn.MdiParent = Me
        fsn.Show()
    End Sub
    Private Sub MenuItem11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        If MsgBox("U Want Close this Module", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1, "EXIT") = MsgBoxResult.OK Then
            Me.Hide()
            End
        End If
    End Sub
    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Kotentry As New KOTEntry("")
        GmoduleName = "KOT Entry"
        If kotentrybool = False Then
            Kotentry.FormBorderStyle = FormBorderStyle.FixedDialog
            Kotentry.MdiParent = Me
            Kotentry.Show()
            Exit Sub
        End If
        Kotentry.FormBorderStyle = FormBorderStyle.FixedDialog
        Kotentry.MdiParent = Me
        Kotentry.Show()
        'submnu_KOTEntry.Checked = True
    End Sub
    Private Sub MenuItem3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Final Bill"
        Dim Bill As New KOT_Billing
        Bill.Show()
        Bill.MdiParent = Me
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Direct Bill"
        Dim DOCSelection1 As New ManualBilling("", "")
        DOCSelection1.Show()
        DOCSelection1.MdiParent = Me
    End Sub
    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If gUserCategory = "S" Then
            GmoduleName = "BILLING_CLOSING"
            Dim SELECTCOMPANY As New BILLING_CLOSING
            SELECTCOMPANY.MdiParent = Me
            SELECTCOMPANY.Show()
        End If
    End Sub
    Private Sub MenuItem2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Kotentry As New KOTEntry("")
        GmoduleName = "Kot Entry"
        If kotentrybool = False Then
            Kotentry.FormBorderStyle = FormBorderStyle.FixedDialog
            Kotentry.MdiParent = Me
            Kotentry.Show()
            Exit Sub
        End If
        Kotentry.FormBorderStyle = FormBorderStyle.FixedDialog
        Kotentry.MdiParent = Me
        Kotentry.Show()
    End Sub
    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Kot Entry"
        Dim Kotentry As New KOTEntry("")
        Kotentry.Show()
        Kotentry.MdiParent = Me
    End Sub
    Private Sub MenuItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim POSDocument As New POSDocument
        GmoduleName = "POS Document"
        If posdocumentbool = False Then
            POSDocument.FormBorderStyle = FormBorderStyle.FixedDialog
            POSDocument.MdiParent = Me
            POSDocument.Show()
            Exit Sub
        End If
        POSDocument.FormBorderStyle = FormBorderStyle.FixedDialog
        POSDocument.MdiParent = Me
        POSDocument.Show()
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If gUserCategory = "S" Then
            GmoduleName = "Kot Book Issue"
            Dim SELECTCOMPANY As New KOTBOOK
            SELECTCOMPANY.MdiParent = Me
            SELECTCOMPANY.Show()
        End If
    End Sub
    Private Sub MenuItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If gUserCategory = "S" Then
            GmoduleName = "Pos Setup Mast&er"
            Dim SELECTCOMPANY As New POSSETUPMASTER
            SELECTCOMPANY.MdiParent = Me
            SELECTCOMPANY.Show()
        End If
    End Sub
    Private Sub MenuItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If gUserCategory = "S" Then
            GmoduleName = "Payment Mode Master"
            Dim SELECTCOMPANY As New PaymentModeMaster
            SELECTCOMPANY.MdiParent = Me
            SELECTCOMPANY.Show()
        End If
    End Sub
    Private Sub MenuItem20_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        If gTallyIntegration = "Y" Then
            Dim Objaccountposting As New TallyImport
            GmoduleName = "Accounts Tally - Import - Members Vouchers"
            If Accountpostingbool = False Then
                Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
                Objaccountposting.MdiParent = Me
                Objaccountposting.Show()
                Exit Sub
            End If
            Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
            Objaccountposting.MdiParent = Me
            Objaccountposting.Show()
        Else
            MsgBox("Tally Integration option is not enabled......", MsgBoxStyle.OKOnly, "CLUBMAN")
        End If
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If gTallyIntegration = "Y" Then
            Dim Objaccountposting As New TallyExport
            GmoduleName = "Accounts Tally - Export MEMBER BILL"
            If Accountpostingbool = False Then
                Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
                Objaccountposting.MdiParent = Me
                Objaccountposting.Show()
                Exit Sub
            End If
            Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
            Objaccountposting.MdiParent = Me
            Objaccountposting.Show()
        Else
            MsgBox("Tally Integration option is not enabled......", MsgBoxStyle.OKOnly, "CLUBMAN")
        End If
    End Sub
    Private Sub MenuItem2_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        If gTallyIntegration = "Y" Then
            Dim Objaccountposting As New Tallyposting
            GmoduleName = "Billing Tally - Export- Smart KOT"
            If Accountpostingbool = False Then
                Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
                Objaccountposting.MdiParent = Me
                Objaccountposting.Show()
                Exit Sub
            End If
            Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
            Objaccountposting.MdiParent = Me
            Objaccountposting.Show()
        Else
            MsgBox("Tally Integration option is not enabled......", MsgBoxStyle.OKOnly, "CLUBMAN")
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Credit Stop List"
        Dim objmanualbill As New CREDITSTOP
        'Me.Hide()
        objmanualbill.FormBorderStyle = FormBorderStyle.FixedDialog
        objmanualbill.MdiParent = MDIParentobj
        ' Me.Close()
        objmanualbill.Show()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub MenuItem27_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Receipt As New CashReceipt
        GmoduleName = "CashReceipt"
        If cashreceiptbool = False Then
            Receipt.FormBorderStyle = FormBorderStyle.FixedDialog
            Receipt.MdiParent = Me
            Receipt.Show()
            Exit Sub
        End If
        Receipt.FormBorderStyle = FormBorderStyle.FixedDialog
        Receipt.MdiParent = Me
        Receipt.Show()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Item Master  - Import From Tally"
        Dim Receipt As New Tallytest
        If cashreceiptbool = False Then
            Receipt.FormBorderStyle = FormBorderStyle.FixedDialog
            Receipt.MdiParent = Me
            Receipt.Show()
            Exit Sub
        End If
        Receipt.FormBorderStyle = FormBorderStyle.FixedDialog
        Receipt.MdiParent = Me
        Receipt.Show()
    End Sub
    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Settlement wise Sales"
        Dim ObjCashSalesRegister As New CashSales
        ObjCashSalesRegister.MdiParent = Me
        ObjCashSalesRegister.Show()
    End Sub
    Private Sub MenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Group Wise Sales"
        Dim PARTY_BILL As New CashSalesGroup
        PARTY_BILL.MdiParent = Me
        PARTY_BILL.Show()
    End Sub
    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Room Wise"
        Dim ObjSalesReportRoom As New SalesReportRoom
        ObjSalesReportRoom.MdiParent = Me
        ObjSalesReportRoom.Show()
    End Sub
    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Date Wise Room Sales"
        Dim ObjRoomsaleregisterdatewise As New frmRoomsaleregisterdatewise
        ObjRoomsaleregisterdatewise.MdiParent = Me
        ObjRoomsaleregisterdatewise.Show()
    End Sub
    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Room Sales Check List"
        Dim PARTY_BILL As New RoomSalesChecklist
        PARTY_BILL.MdiParent = Me
        PARTY_BILL.Show()
    End Sub
    Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Room Sales checkin"
        Dim ObjCashSalesRegister As New RoomSalesCheckin
        ObjCashSalesRegister.MdiParent = Me
        ObjCashSalesRegister.Show()
    End Sub
    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Contract Details"
        Dim ObjSalesBillChecklist1 As New SalesCheck
        ObjSalesBillChecklist1.MdiParent = Me
        ObjSalesBillChecklist1.Show()
    End Sub
    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GmoduleName = "Contract Details"
        Dim ObjSalesBillChecklist1 As New BOM
        ObjSalesBillChecklist1.MdiParent = Me
        ObjSalesBillChecklist1.Show()
    End Sub
    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        GmoduleName = "Item Master  - Import From Tally"
        Dim Receipt As New Tallytest
        If cashreceiptbool = False Then
            Receipt.FormBorderStyle = FormBorderStyle.FixedDialog
            Receipt.MdiParent = Me
            Receipt.Show()
            Exit Sub
        End If
        Receipt.FormBorderStyle = FormBorderStyle.FixedDialog
        Receipt.MdiParent = Me
        Receipt.Show()
    End Sub
    Private Sub MenuItem3_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        MDIForm.ActiveForm.Visible = False
        Dim cmp As New ExporttoExcel
        cmp.Show()
    End Sub

    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If gTallyIntegration = "Y" Then
            Dim Objaccountposting As New TallyExport_Party
            GmoduleName = "Party bill"
            If Accountpostingbool = False Then
                Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
                Objaccountposting.MdiParent = Me
                Objaccountposting.Show()
                Exit Sub
            End If
            Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
            Objaccountposting.MdiParent = Me
            Objaccountposting.Show()
        Else
            MsgBox("Tally Integration option is not enabled......", MsgBoxStyle.OKOnly, "CLUBMAN")
        End If
    End Sub
    Private Sub MenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem14_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        GmoduleName = "Subscription Ledger Mapping"
        Dim ACCOUNTSITEMTAGGING As New ACCOUNTSSUBSPOSTINGTAGGING
        ACCOUNTSITEMTAGGING.MdiParent = Me
        ACCOUNTSITEMTAGGING.Show()
    End Sub

    Private Sub MenuItem19_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem22_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        'If gTallyIntegration = "Y" Then
        Dim Objaccountposting As New VENDORLEDGERmember
        GmoduleName = "Member Master Mapping"
        Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
        Objaccountposting.MdiParent = Me
        Objaccountposting.Show()
        'Else
        'MsgBox("Tally Integration option is not enabled......", MsgBoxStyle.OKOnly, "CLUBMAN")
        'End If
    End Sub

    Private Sub MenuItem24_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        If gTallyIntegration = "Y" Then
            Dim Objaccountposting As New TallyImport_Audit
            GmoduleName = "Accounts Tally - Import - Audit"
            If Accountpostingbool = False Then
                Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
                Objaccountposting.MdiParent = Me
                Objaccountposting.Show()
                Exit Sub
            End If
            Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
            Objaccountposting.MdiParent = Me
            Objaccountposting.Show()
        Else
            MsgBox("Tally Integration option is not enabled......", MsgBoxStyle.OKOnly, "CLUBMAN")
        End If
    End Sub

    Private Sub MenuItem27_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        If gTallyIntegration = "Y" Then
            Dim Objaccountposting As New TallyExport_GRN
            GmoduleName = "Accounts Tally - Export GRN"
            If Accountpostingbool = False Then
                Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
                Objaccountposting.MdiParent = Me
                Objaccountposting.Show()
                Exit Sub
            End If
            Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
            Objaccountposting.MdiParent = Me
            Objaccountposting.Show()
        Else
            MsgBox("Tally Integration option is not enabled......", MsgBoxStyle.OKOnly, "CLUBMAN")
        End If
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        GmoduleName = "receipt post"
        Dim recp As New TALLYPOSTINGTOTAL
        recp.MdiParent = Me
        recp.Show()
    End Sub


    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        GmoduleName = "Accounts Tally - Export All  Except Pos/Inv"
        Dim TALL As New TallyExport_OTHERS
        TALL.MdiParent = Me
        TALL.Show()
    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        GmoduleName = "ACCOUNTSEVENTTAGGING"
        Dim EV As New ACCOUNTSEVENTTAGGING
        EV.MdiParent = Me
        EV.Show()
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        GmoduleName = "TOURNAMENTTAGGING"
        Dim EV As New TOURNAMENTTAGGING
        EV.MdiParent = Me
        EV.Show()
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        GmoduleName = "ACCOUNTSEVENTTAGGING"
        Dim EV As New ACCOUNTSEVENTTAGGING
        EV.MdiParent = Me
        EV.Show()
    End Sub

    'Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click

    'End Sub

    'Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click

    'End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        GmoduleName = "guestregtagging"
        Dim gr As New guestregtagging
        gr.MdiParent = Me
        gr.Show()

    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem67.Click
        GmoduleName = " postingaudit"
        Dim gr As New postingaudit
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem69_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem69.Click
        GmoduleName = "Item Ledger Mapping"
        Dim ACCOUNTSITEMTAGGING As New ACCOUNTSITEMTAGGING
        ACCOUNTSITEMTAGGING.MdiParent = Me
        ACCOUNTSITEMTAGGING.Show()
    End Sub

    Private Sub MenuItem7_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GmoduleName = "Payment Ledger Mapping"
        Dim ACCOUNTSITEMTAGGING As New ACCOUNTSPAYMENTTAGGING
        ACCOUNTSITEMTAGGING.MdiParent = Me
        ACCOUNTSITEMTAGGING.Show()
    End Sub

    Private Sub MenuItem8_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim itemmaster As New ItemMaster
        GmoduleName = "Item Master"
        itemmaster.FormBorderStyle = FormBorderStyle.FixedDialog
        itemmaster.MdiParent = Me
        itemmaster.Show()
        ' submnu_Itemmaster.Checked = True
    End Sub

    Private Sub MenuItem14_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        GmoduleName = "ItemType Ledger Mapping"
        Dim ACCOUNTSITEMTAGGING As New ACCOUNTSITEMTYPETAGGING
        ACCOUNTSITEMTAGGING.MdiParent = Me
        ACCOUNTSITEMTAGGING.Show()
    End Sub

    Private Sub MenuItem19_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        GmoduleName = "Inventory Item Master"
        Dim ACCOUNTSITEMTAGGING As New ACCOUNTSINVITEMTAGGING
        ACCOUNTSITEMTAGGING.MdiParent = Me
        ACCOUNTSITEMTAGGING.Show()
    End Sub

    Private Sub MenuItem23_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        GmoduleName = "VENDORLEDGER"
        Dim recp As New VENDORLEDGER
        recp.MdiParent = Me
        recp.Show()
    End Sub

    Private Sub MenuItem34_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        GmoduleName = "HALLLEDGER"
        Dim HALL As New HALLLEDGER
        HALL.MdiParent = Me
        HALL.Show()
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        GmoduleName = "PARTYRECEIPTHEAD"
        Dim REC As New PARTYRECEIPTHEAD
        REC.MdiParent = Me
        REC.Show()
    End Sub

    Private Sub MenuItem36_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        GmoduleName = "PARTYITEMTAGGING"
        Dim PI As New PARTYITEMTAGGING
        PI.MdiParent = Me
        PI.Show()
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        GmoduleName = "GREENFEETAGGING"
        Dim gr As New GREENFEETAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        GmoduleName = "BALLTAGGING"
        Dim gr As New BALLTAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        GmoduleName = "GOLFSALEITEMTAGGING"
        Dim gr As New GOLFSALEITEMTAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        GmoduleName = "CAMPTAGGING"
        Dim gr As New CAMPTAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        GmoduleName = "CARTTAGGING"
        Dim gr As New CARTTAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        GmoduleName = "TOURNAMENTTAGGINGTOUR"
        Dim gr As New TOURNAMENTTAGGINGTOUR
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        GmoduleName = "Categorywise Item Ledger Mapping"
        Dim gr As New ACCOUNTScateitemTAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem58_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        GmoduleName = "GST DETAIL REPORT"
        Dim gr As New postingaudittraildet
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click
        GmoduleName = "Party Tarriff  Ledger Mapping"
        Dim gr As New TARIFFTAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        GmoduleName = "Sub Payment Ledger Mapping"
        Dim gr As New SUBPAYMENTTAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub


    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        GmoduleName = "Guest Room Mapping"
        Dim gr As New GUESTROOMTAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem62_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        GmoduleName = "Cash Bank Ledger Mapping"
        Dim gr As New CASHBANKTAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        GmoduleName = "Guest Room Payment Mapping"
        Dim gr As New GUESTROOMPAYMODETAGGING
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem64_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        GmoduleName = "Tax Master"
        Dim gr As New FRM_BC_TAXMASTER
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem70.Click
        GmoduleName = "Tax Group Master"
        Dim gr As New TAXGROUPMASTER
        gr.MdiParent = Me
        gr.Show()
    End Sub

    Private Sub MenuItem68_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click

    End Sub

    Private Sub MenuItem71_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        Dim Objaccountposting As New VENDORLEDGERsubledger
        GmoduleName = "Other Sub Ledger Mapping"
        Objaccountposting.FormBorderStyle = FormBorderStyle.FixedDialog
        Objaccountposting.MdiParent = Me
        Objaccountposting.Show()
    End Sub
End Class