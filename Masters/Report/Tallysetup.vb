Public Class Tallysetup
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CMBMEMR As System.Windows.Forms.ComboBox
    Friend WithEvents CMBMEMRVT As System.Windows.Forms.ComboBox
    Friend WithEvents CMBMEMRCST As System.Windows.Forms.ComboBox
    Friend WithEvents CMBMEMSCST As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CMBMEMSVT As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CMBMEMS As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CMBPOSCST As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CMBPOSVT As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CMBPOS As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CMBGURCST As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CMBGURVT As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CMBGUR As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CMBGRCST As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CMBGRVT As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CMBGR As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CMBEVCST As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CMBEVVT As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CMBEV As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CMBCSCST As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CMBCSVT As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CMBCS As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CMBLIBCST As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CMBLIBVT As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents CMBLIB As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CMBMAPPCST As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents CMBMAPPVT As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CMBMAPP As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CMBMEMR = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CMBMEMRVT = New System.Windows.Forms.ComboBox
        Me.CMBMEMRCST = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CMBMEMSCST = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CMBMEMSVT = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CMBMEMS = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CMBPOSCST = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CMBPOSVT = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CMBPOS = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CMBGURCST = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.CMBGURVT = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.CMBGUR = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.CMBGRCST = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.CMBGRVT = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.CMBGR = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.CMBEVCST = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.CMBEVVT = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.CMBEV = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.CMBCSCST = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.CMBCSVT = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CMBCS = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.CMBLIBCST = New System.Windows.Forms.ComboBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.CMBLIBVT = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.CMBLIB = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CMBMAPPCST = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.CMBMAPPVT = New System.Windows.Forms.ComboBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.CMBMAPP = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tally Setup"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(216, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 40)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CMBMAPPCST)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.CMBMAPPVT)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.CMBMAPP)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.CMBLIBCST)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.CMBLIBVT)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.CMBLIB)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.CMBCSCST)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.CMBCSVT)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.CMBCS)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.CMBEVCST)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.CMBEVVT)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.CMBEV)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.CMBGRCST)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.CMBGRVT)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.CMBGR)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.CMBGURCST)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.CMBGURVT)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.CMBGUR)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.CMBPOSCST)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.CMBPOSVT)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CMBPOS)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.CMBMEMSCST)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CMBMEMSVT)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CMBMEMS)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CMBMEMRCST)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CMBMEMRVT)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.CMBMEMR)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 320)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Elements to be posted"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Member Receipts :"
        '
        'CMBMEMR
        '
        Me.CMBMEMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMEMR.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBMEMR.Location = New System.Drawing.Point(152, 32)
        Me.CMBMEMR.Name = "CMBMEMR"
        Me.CMBMEMR.Size = New System.Drawing.Size(56, 23)
        Me.CMBMEMR.TabIndex = 2
        Me.CMBMEMR.Text = "YES"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(216, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Voucher Type :"
        '
        'CMBMEMRVT
        '
        Me.CMBMEMRVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMEMRVT.Items.AddRange(New Object() {"INDIVIDUAL", "PERIODICAL"})
        Me.CMBMEMRVT.Location = New System.Drawing.Point(312, 32)
        Me.CMBMEMRVT.Name = "CMBMEMRVT"
        Me.CMBMEMRVT.Size = New System.Drawing.Size(104, 23)
        Me.CMBMEMRVT.TabIndex = 4
        Me.CMBMEMRVT.Text = "INDIVIDUAL"
        '
        'CMBMEMRCST
        '
        Me.CMBMEMRCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMEMRCST.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBMEMRCST.Location = New System.Drawing.Point(576, 32)
        Me.CMBMEMRCST.Name = "CMBMEMRCST"
        Me.CMBMEMRCST.Size = New System.Drawing.Size(56, 23)
        Me.CMBMEMRCST.TabIndex = 6
        Me.CMBMEMRCST.Text = "YES"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(440, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Apply Cost Center :"
        '
        'CMBMEMSCST
        '
        Me.CMBMEMSCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMEMSCST.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBMEMSCST.Location = New System.Drawing.Point(576, 64)
        Me.CMBMEMSCST.Name = "CMBMEMSCST"
        Me.CMBMEMSCST.Size = New System.Drawing.Size(56, 23)
        Me.CMBMEMSCST.TabIndex = 12
        Me.CMBMEMSCST.Text = "YES"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(440, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Apply Cost Center :"
        '
        'CMBMEMSVT
        '
        Me.CMBMEMSVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMEMSVT.Items.AddRange(New Object() {"INDIVIDUAL", "PERIODICAL"})
        Me.CMBMEMSVT.Location = New System.Drawing.Point(312, 64)
        Me.CMBMEMSVT.Name = "CMBMEMSVT"
        Me.CMBMEMSVT.Size = New System.Drawing.Size(104, 23)
        Me.CMBMEMSVT.TabIndex = 10
        Me.CMBMEMSVT.Text = "INDIVIDUAL"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(216, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Voucher Type :"
        '
        'CMBMEMS
        '
        Me.CMBMEMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMEMS.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBMEMS.Location = New System.Drawing.Point(152, 64)
        Me.CMBMEMS.Name = "CMBMEMS"
        Me.CMBMEMS.Size = New System.Drawing.Size(56, 23)
        Me.CMBMEMS.TabIndex = 8
        Me.CMBMEMS.Text = "YES"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Member Subscription :"
        '
        'CMBPOSCST
        '
        Me.CMBPOSCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBPOSCST.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBPOSCST.Location = New System.Drawing.Point(576, 96)
        Me.CMBPOSCST.Name = "CMBPOSCST"
        Me.CMBPOSCST.Size = New System.Drawing.Size(56, 23)
        Me.CMBPOSCST.TabIndex = 18
        Me.CMBPOSCST.Text = "YES"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(440, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 23)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Apply Cost Center :"
        '
        'CMBPOSVT
        '
        Me.CMBPOSVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBPOSVT.Items.AddRange(New Object() {"INDIVIDUAL", "PERIODICAL"})
        Me.CMBPOSVT.Location = New System.Drawing.Point(312, 96)
        Me.CMBPOSVT.Name = "CMBPOSVT"
        Me.CMBPOSVT.Size = New System.Drawing.Size(104, 23)
        Me.CMBPOSVT.TabIndex = 16
        Me.CMBPOSVT.Text = "INDIVIDUAL"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(216, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Voucher Type :"
        '
        'CMBPOS
        '
        Me.CMBPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBPOS.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBPOS.Location = New System.Drawing.Point(152, 96)
        Me.CMBPOS.Name = "CMBPOS"
        Me.CMBPOS.Size = New System.Drawing.Size(56, 23)
        Me.CMBPOS.TabIndex = 14
        Me.CMBPOS.Text = "YES"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 23)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Pos Bills :"
        '
        'CMBGURCST
        '
        Me.CMBGURCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBGURCST.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBGURCST.Location = New System.Drawing.Point(576, 128)
        Me.CMBGURCST.Name = "CMBGURCST"
        Me.CMBGURCST.Size = New System.Drawing.Size(56, 23)
        Me.CMBGURCST.TabIndex = 24
        Me.CMBGURCST.Text = "YES"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(440, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 23)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Apply Cost Center :"
        '
        'CMBGURVT
        '
        Me.CMBGURVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBGURVT.Items.AddRange(New Object() {"INDIVIDUAL", "PERIODICAL"})
        Me.CMBGURVT.Location = New System.Drawing.Point(312, 128)
        Me.CMBGURVT.Name = "CMBGURVT"
        Me.CMBGURVT.Size = New System.Drawing.Size(104, 23)
        Me.CMBGURVT.TabIndex = 22
        Me.CMBGURVT.Text = "INDIVIDUAL"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(216, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 16)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Voucher Type :"
        '
        'CMBGUR
        '
        Me.CMBGUR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBGUR.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBGUR.Location = New System.Drawing.Point(152, 128)
        Me.CMBGUR.Name = "CMBGUR"
        Me.CMBGUR.Size = New System.Drawing.Size(56, 23)
        Me.CMBGUR.TabIndex = 20
        Me.CMBGUR.Text = "YES"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 23)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Guest Room Vouchers  :"
        '
        'CMBGRCST
        '
        Me.CMBGRCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBGRCST.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBGRCST.Location = New System.Drawing.Point(576, 160)
        Me.CMBGRCST.Name = "CMBGRCST"
        Me.CMBGRCST.Size = New System.Drawing.Size(56, 23)
        Me.CMBGRCST.TabIndex = 30
        Me.CMBGRCST.Text = "YES"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(440, 160)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 23)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Apply Cost Center :"
        '
        'CMBGRVT
        '
        Me.CMBGRVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBGRVT.Items.AddRange(New Object() {"INDIVIDUAL", "PERIODICAL"})
        Me.CMBGRVT.Location = New System.Drawing.Point(312, 160)
        Me.CMBGRVT.Name = "CMBGRVT"
        Me.CMBGRVT.Size = New System.Drawing.Size(104, 23)
        Me.CMBGRVT.TabIndex = 28
        Me.CMBGRVT.Text = "INDIVIDUAL"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(216, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 16)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Voucher Type :"
        '
        'CMBGR
        '
        Me.CMBGR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBGR.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBGR.Location = New System.Drawing.Point(152, 160)
        Me.CMBGR.Name = "CMBGR"
        Me.CMBGR.Size = New System.Drawing.Size(56, 23)
        Me.CMBGR.TabIndex = 26
        Me.CMBGR.Text = "YES"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 23)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Guest Registration :"
        '
        'CMBEVCST
        '
        Me.CMBEVCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBEVCST.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBEVCST.Location = New System.Drawing.Point(576, 192)
        Me.CMBEVCST.Name = "CMBEVCST"
        Me.CMBEVCST.Size = New System.Drawing.Size(56, 23)
        Me.CMBEVCST.TabIndex = 36
        Me.CMBEVCST.Text = "YES"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(440, 192)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 23)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Apply Cost Center :"
        '
        'CMBEVVT
        '
        Me.CMBEVVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBEVVT.Items.AddRange(New Object() {"INDIVIDUAL", "PERIODICAL"})
        Me.CMBEVVT.Location = New System.Drawing.Point(312, 192)
        Me.CMBEVVT.Name = "CMBEVVT"
        Me.CMBEVVT.Size = New System.Drawing.Size(104, 23)
        Me.CMBEVVT.TabIndex = 34
        Me.CMBEVVT.Text = "INDIVIDUAL"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(216, 192)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 16)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Voucher Type :"
        '
        'CMBEV
        '
        Me.CMBEV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBEV.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBEV.Location = New System.Drawing.Point(152, 192)
        Me.CMBEV.Name = "CMBEV"
        Me.CMBEV.Size = New System.Drawing.Size(56, 23)
        Me.CMBEV.TabIndex = 32
        Me.CMBEV.Text = "YES"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 192)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(136, 23)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Events :"
        '
        'CMBCSCST
        '
        Me.CMBCSCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCSCST.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBCSCST.Location = New System.Drawing.Point(576, 224)
        Me.CMBCSCST.Name = "CMBCSCST"
        Me.CMBCSCST.Size = New System.Drawing.Size(56, 23)
        Me.CMBCSCST.TabIndex = 42
        Me.CMBCSCST.Text = "YES"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(440, 224)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(128, 23)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Apply Cost Center :"
        '
        'CMBCSVT
        '
        Me.CMBCSVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCSVT.Items.AddRange(New Object() {"INDIVIDUAL", "PERIODICAL"})
        Me.CMBCSVT.Location = New System.Drawing.Point(312, 224)
        Me.CMBCSVT.Name = "CMBCSVT"
        Me.CMBCSVT.Size = New System.Drawing.Size(104, 23)
        Me.CMBCSVT.TabIndex = 40
        Me.CMBCSVT.Text = "INDIVIDUAL"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(216, 224)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 16)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Voucher Type :"
        '
        'CMBCS
        '
        Me.CMBCS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCS.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBCS.Location = New System.Drawing.Point(152, 224)
        Me.CMBCS.Name = "CMBCS"
        Me.CMBCS.Size = New System.Drawing.Size(56, 23)
        Me.CMBCS.TabIndex = 38
        Me.CMBCS.Text = "YES"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 224)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(136, 23)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Car Sticker :"
        '
        'CMBLIBCST
        '
        Me.CMBLIBCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBLIBCST.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBLIBCST.Location = New System.Drawing.Point(576, 256)
        Me.CMBLIBCST.Name = "CMBLIBCST"
        Me.CMBLIBCST.Size = New System.Drawing.Size(56, 23)
        Me.CMBLIBCST.TabIndex = 48
        Me.CMBLIBCST.Text = "YES"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(440, 256)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(128, 23)
        Me.Label24.TabIndex = 47
        Me.Label24.Text = "Apply Cost Center :"
        '
        'CMBLIBVT
        '
        Me.CMBLIBVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBLIBVT.Items.AddRange(New Object() {"INDIVIDUAL", "PERIODICAL"})
        Me.CMBLIBVT.Location = New System.Drawing.Point(312, 256)
        Me.CMBLIBVT.Name = "CMBLIBVT"
        Me.CMBLIBVT.Size = New System.Drawing.Size(104, 23)
        Me.CMBLIBVT.TabIndex = 46
        Me.CMBLIBVT.Text = "INDIVIDUAL"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(216, 256)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(100, 16)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Voucher Type :"
        '
        'CMBLIB
        '
        Me.CMBLIB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBLIB.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBLIB.Location = New System.Drawing.Point(152, 256)
        Me.CMBLIB.Name = "CMBLIB"
        Me.CMBLIB.Size = New System.Drawing.Size(56, 23)
        Me.CMBLIB.TabIndex = 44
        Me.CMBLIB.Text = "YES"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 256)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(136, 23)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "Library :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(176, 376)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 48)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(56, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ADD"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(176, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "VIEW"
        '
        'CMBMAPPCST
        '
        Me.CMBMAPPCST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMAPPCST.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBMAPPCST.Location = New System.Drawing.Point(576, 288)
        Me.CMBMAPPCST.Name = "CMBMAPPCST"
        Me.CMBMAPPCST.Size = New System.Drawing.Size(56, 23)
        Me.CMBMAPPCST.TabIndex = 54
        Me.CMBMAPPCST.Text = "YES"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(440, 288)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(128, 23)
        Me.Label27.TabIndex = 53
        Me.Label27.Text = "Apply Cost Center :"
        '
        'CMBMAPPVT
        '
        Me.CMBMAPPVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMAPPVT.Items.AddRange(New Object() {"INDIVIDUAL", "PERIODICAL"})
        Me.CMBMAPPVT.Location = New System.Drawing.Point(312, 288)
        Me.CMBMAPPVT.Name = "CMBMAPPVT"
        Me.CMBMAPPVT.Size = New System.Drawing.Size(104, 23)
        Me.CMBMAPPVT.TabIndex = 52
        Me.CMBMAPPVT.Text = "INDIVIDUAL"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(216, 288)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(100, 16)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "Voucher Type :"
        '
        'CMBMAPP
        '
        Me.CMBMAPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMAPP.Items.AddRange(New Object() {"YES", "NO"})
        Me.CMBMAPP.Location = New System.Drawing.Point(152, 288)
        Me.CMBMAPP.Name = "CMBMAPP"
        Me.CMBMAPP.Size = New System.Drawing.Size(56, 23)
        Me.CMBMAPP.TabIndex = 50
        Me.CMBMAPP.Text = "YES"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 288)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(136, 23)
        Me.Label29.TabIndex = 49
        Me.Label29.Text = "Member Application :"
        '
        'Tallysetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 434)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Tallysetup"
        Me.Text = "Tallysetup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
