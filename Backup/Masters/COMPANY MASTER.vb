Public Class COMPANYMASTER
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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBPrifix As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBAuto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdItemHelp As System.Windows.Forms.Button
    Friend WithEvents lbl_GLAccount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKPrifix As System.Windows.Forms.TextBox
    Friend WithEvents txtKAuto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(COMPANYMASTER))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtBPrifix = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBAuto = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdItemHelp = New System.Windows.Forms.Button
        Me.lbl_GLAccount = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtKPrifix = New System.Windows.Forms.TextBox
        Me.txtKAuto = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.TextBox11)
        Me.GroupBox5.Controls.Add(Me.TextBox12)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.TextBox15)
        Me.GroupBox5.Controls.Add(Me.TextBox16)
        Me.GroupBox5.Controls.Add(Me.TextBox17)
        Me.GroupBox5.Controls.Add(Me.TextBox18)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.TextBox19)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.TextBox20)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Location = New System.Drawing.Point(40, 480)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(856, 183)
        Me.GroupBox5.TabIndex = 446
        Me.GroupBox5.TabStop = False
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Wheat
        Me.TextBox11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(648, 136)
        Me.TextBox11.MaxLength = 50
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(176, 26)
        Me.TextBox11.TabIndex = 457
        Me.TextBox11.Text = ""
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Wheat
        Me.TextBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(648, 96)
        Me.TextBox12.MaxLength = 50
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(176, 26)
        Me.TextBox12.TabIndex = 456
        Me.TextBox12.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(424, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(207, 21)
        Me.Label18.TabIndex = 454
        Me.Label18.Text = "PRINTER SHARER NAME  :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(496, 96)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(137, 21)
        Me.Label19.TabIndex = 453
        Me.Label19.Text = "SQL PASSWORD :"
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.Wheat
        Me.TextBox15.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(224, 136)
        Me.TextBox15.MaxLength = 50
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(176, 26)
        Me.TextBox15.TabIndex = 450
        Me.TextBox15.Text = ""
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.Wheat
        Me.TextBox16.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(224, 56)
        Me.TextBox16.MaxLength = 50
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(176, 26)
        Me.TextBox16.TabIndex = 449
        Me.TextBox16.Text = ""
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.Color.Wheat
        Me.TextBox17.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(224, 96)
        Me.TextBox17.MaxLength = 50
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(176, 26)
        Me.TextBox17.TabIndex = 448
        Me.TextBox17.Text = ""
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.Color.Wheat
        Me.TextBox18.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(224, 16)
        Me.TextBox18.MaxLength = 50
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(176, 26)
        Me.TextBox18.TabIndex = 445
        Me.TextBox18.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 136)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(206, 21)
        Me.Label22.TabIndex = 444
        Me.Label22.Text = "PRINTER SYSTEM NAME  :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(64, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(150, 21)
        Me.Label23.TabIndex = 443
        Me.Label23.Text = "DATABASE NAME :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(520, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 21)
        Me.Label24.TabIndex = 442
        Me.Label24.Text = "IP ADDRESS  :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(24, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(196, 21)
        Me.Label25.TabIndex = 441
        Me.Label25.Text = "SERVER SYSTEM NAME :"
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.Color.Wheat
        Me.TextBox19.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(648, 16)
        Me.TextBox19.MaxLength = 50
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(176, 26)
        Me.TextBox19.TabIndex = 440
        Me.TextBox19.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(72, 96)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(142, 21)
        Me.Label26.TabIndex = 437
        Me.Label26.Text = "SQL USER NAME :"
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.Color.Wheat
        Me.TextBox20.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(648, 56)
        Me.TextBox20.MaxLength = 50
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(176, 26)
        Me.TextBox20.TabIndex = 436
        Me.TextBox20.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(488, 56)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(144, 21)
        Me.Label27.TabIndex = 435
        Me.Label27.Text = "PRODUCT KEY     :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 304)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(383, 18)
        Me.Label17.TabIndex = 417
        Me.Label17.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox6.Controls.Add(Me.Cmd_Add)
        Me.GroupBox6.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox6.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox6.Controls.Add(Me.Cmd_View)
        Me.GroupBox6.Location = New System.Drawing.Point(96, 672)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(712, 56)
        Me.GroupBox6.TabIndex = 447
        Me.GroupBox6.TabStop = False
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(240, 12)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 7
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(128, 12)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 6
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(576, 12)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 9
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(16, 12)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 5
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(352, 12)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 8
        Me.Cmd_View.Text = " View[F9]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 416)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(768, 56)
        Me.GroupBox2.TabIndex = 448
        Me.GroupBox2.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(656, 18)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker2.TabIndex = 444
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(248, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 443
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(448, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(201, 21)
        Me.Label13.TabIndex = 442
        Me.Label13.Text = "FINANCE ENDING DATE  :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 21)
        Me.Label14.TabIndex = 441
        Me.Label14.Text = "FINANCE STARTING DATE  :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtBPrifix)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtBAuto)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(40, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(768, 256)
        Me.GroupBox3.TabIndex = 449
        Me.GroupBox3.TabStop = False
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Wheat
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(576, 176)
        Me.TextBox9.MaxLength = 50
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(176, 26)
        Me.TextBox9.TabIndex = 458
        Me.TextBox9.Text = ""
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Wheat
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(576, 136)
        Me.TextBox8.MaxLength = 50
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(176, 26)
        Me.TextBox8.TabIndex = 457
        Me.TextBox8.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Wheat
        Me.TextBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(576, 96)
        Me.TextBox7.MaxLength = 50
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(176, 26)
        Me.TextBox7.TabIndex = 456
        Me.TextBox7.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(448, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 21)
        Me.Label12.TabIndex = 455
        Me.Label12.Text = " WEB   :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(448, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 21)
        Me.Label6.TabIndex = 454
        Me.Label6.Text = " MOBILE NO :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(456, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 21)
        Me.Label4.TabIndex = 453
        Me.Label4.Text = "PHONE NO :"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Wheat
        Me.TextBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(176, 216)
        Me.TextBox6.MaxLength = 50
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(176, 26)
        Me.TextBox6.TabIndex = 452
        Me.TextBox6.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Wheat
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(176, 176)
        Me.TextBox5.MaxLength = 50
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(176, 26)
        Me.TextBox5.TabIndex = 451
        Me.TextBox5.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Wheat
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(176, 136)
        Me.TextBox4.MaxLength = 50
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 26)
        Me.TextBox4.TabIndex = 450
        Me.TextBox4.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Wheat
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(176, 56)
        Me.TextBox3.MaxLength = 50
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(176, 26)
        Me.TextBox3.TabIndex = 449
        Me.TextBox3.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Wheat
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(176, 96)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 26)
        Me.TextBox2.TabIndex = 448
        Me.TextBox2.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 447
        Me.Label3.Text = "EMAIL  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 446
        Me.Label2.Text = "STATE   :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Wheat
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(176, 16)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 26)
        Me.TextBox1.TabIndex = 445
        Me.TextBox1.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(96, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 21)
        Me.Label11.TabIndex = 444
        Me.Label11.Text = "CITY  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 21)
        Me.Label5.TabIndex = 443
        Me.Label5.Text = "ADDRESS2 :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(456, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 442
        Me.Label7.Text = " COUNTRY  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 21)
        Me.Label8.TabIndex = 441
        Me.Label8.Text = "ADDRESS1 :"
        '
        'txtBPrifix
        '
        Me.txtBPrifix.BackColor = System.Drawing.Color.Wheat
        Me.txtBPrifix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBPrifix.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBPrifix.Location = New System.Drawing.Point(576, 16)
        Me.txtBPrifix.MaxLength = 50
        Me.txtBPrifix.Name = "txtBPrifix"
        Me.txtBPrifix.Size = New System.Drawing.Size(176, 26)
        Me.txtBPrifix.TabIndex = 440
        Me.txtBPrifix.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(56, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 21)
        Me.Label9.TabIndex = 437
        Me.Label9.Text = "ADDRESS3  :"
        '
        'txtBAuto
        '
        Me.txtBAuto.BackColor = System.Drawing.Color.Wheat
        Me.txtBAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBAuto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBAuto.Location = New System.Drawing.Point(576, 56)
        Me.txtBAuto.MaxLength = 50
        Me.txtBAuto.Name = "txtBAuto"
        Me.txtBAuto.Size = New System.Drawing.Size(176, 26)
        Me.txtBAuto.TabIndex = 436
        Me.txtBAuto.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(456, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 21)
        Me.Label10.TabIndex = 435
        Me.Label10.Text = " PINCODE   :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.cmdItemHelp)
        Me.GroupBox1.Controls.Add(Me.lbl_GLAccount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKPrifix)
        Me.GroupBox1.Controls.Add(Me.txtKAuto)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 56)
        Me.GroupBox1.TabIndex = 450
        Me.GroupBox1.TabStop = False
        '
        'cmdItemHelp
        '
        Me.cmdItemHelp.Image = CType(resources.GetObject("cmdItemHelp.Image"), System.Drawing.Image)
        Me.cmdItemHelp.Location = New System.Drawing.Point(352, 15)
        Me.cmdItemHelp.Name = "cmdItemHelp"
        Me.cmdItemHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdItemHelp.TabIndex = 443
        '
        'lbl_GLAccount
        '
        Me.lbl_GLAccount.AutoSize = True
        Me.lbl_GLAccount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GLAccount.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GLAccount.ForeColor = System.Drawing.Color.Black
        Me.lbl_GLAccount.Location = New System.Drawing.Point(416, 16)
        Me.lbl_GLAccount.Name = "lbl_GLAccount"
        Me.lbl_GLAccount.Size = New System.Drawing.Size(154, 21)
        Me.lbl_GLAccount.TabIndex = 442
        Me.lbl_GLAccount.Text = " COMPANY NAME  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 21)
        Me.Label1.TabIndex = 441
        Me.Label1.Text = "COMPANY CODE  :"
        '
        'txtKPrifix
        '
        Me.txtKPrifix.BackColor = System.Drawing.Color.Wheat
        Me.txtKPrifix.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKPrifix.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKPrifix.Location = New System.Drawing.Point(576, 16)
        Me.txtKPrifix.MaxLength = 50
        Me.txtKPrifix.Name = "txtKPrifix"
        Me.txtKPrifix.Size = New System.Drawing.Size(176, 26)
        Me.txtKPrifix.TabIndex = 440
        Me.txtKPrifix.Text = ""
        '
        'txtKAuto
        '
        Me.txtKAuto.BackColor = System.Drawing.Color.Wheat
        Me.txtKAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKAuto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKAuto.Location = New System.Drawing.Point(176, 16)
        Me.txtKAuto.MaxLength = 50
        Me.txtKAuto.Name = "txtKAuto"
        Me.txtKAuto.Size = New System.Drawing.Size(176, 26)
        Me.txtKAuto.TabIndex = 436
        Me.txtKAuto.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(320, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(256, 31)
        Me.Label16.TabIndex = 451
        Me.Label16.Text = "COMPANY  MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(464, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Print[F10]"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(96, 736)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(383, 18)
        Me.Label15.TabIndex = 452
        Me.Label15.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'COMPANYMASTER
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 746)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "COMPANYMASTER"
        Me.Text = "COMPANY MASTER"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        TextBox1.Text = ""
        txtKAuto.Text = ""
        txtKPrifix.Text = ""
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        txtBPrifix.Text = ""
        txtBAuto.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox18.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox15.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox12.Text = ""
        TextBox11.Text = ""
    End Sub
End Class
