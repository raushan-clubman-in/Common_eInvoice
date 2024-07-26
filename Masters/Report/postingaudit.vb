Public Class postingaudit
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents grp_Billposting As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_head As System.Windows.Forms.Label
    Friend WithEvents Cmd_Fill As System.Windows.Forms.Button
    Friend WithEvents lbl_Fromdate As System.Windows.Forms.Label
    Friend WithEvents dtp_Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Todate As System.Windows.Forms.Label
    Friend WithEvents dtp_Todate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(postingaudit))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmd_clear = New System.Windows.Forms.Button
        Me.cmd_view = New System.Windows.Forms.Button
        Me.cmd_exit = New System.Windows.Forms.Button
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread
        Me.grp_Billposting = New System.Windows.Forms.GroupBox
        Me.lbl_Todate = New System.Windows.Forms.Label
        Me.dtp_Todate = New System.Windows.Forms.DateTimePicker
        Me.lbl_head = New System.Windows.Forms.Label
        Me.Cmd_Fill = New System.Windows.Forms.Button
        Me.lbl_Fromdate = New System.Windows.Forms.Label
        Me.dtp_Fromdate = New System.Windows.Forms.DateTimePicker
        Me.Panel1.SuspendLayout()
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Billposting.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.cmd_clear)
        Me.Panel1.Controls.Add(Me.cmd_view)
        Me.Panel1.Controls.Add(Me.cmd_exit)
        Me.Panel1.Location = New System.Drawing.Point(752, 168)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(96, 160)
        Me.Panel1.TabIndex = 6
        '
        'cmd_clear
        '
        Me.cmd_clear.BackgroundImage = CType(resources.GetObject("cmd_clear.BackgroundImage"), System.Drawing.Image)
        Me.cmd_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.Location = New System.Drawing.Point(8, 8)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(80, 40)
        Me.cmd_clear.TabIndex = 1
        Me.cmd_clear.Text = "Clear"
        '
        'cmd_view
        '
        Me.cmd_view.BackgroundImage = CType(resources.GetObject("cmd_view.BackgroundImage"), System.Drawing.Image)
        Me.cmd_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.Location = New System.Drawing.Point(8, 56)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(80, 40)
        Me.cmd_view.TabIndex = 1
        Me.cmd_view.Text = "View"
        '
        'cmd_exit
        '
        Me.cmd_exit.BackgroundImage = CType(resources.GetObject("cmd_exit.BackgroundImage"), System.Drawing.Image)
        Me.cmd_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit.Location = New System.Drawing.Point(8, 104)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(80, 40)
        Me.cmd_exit.TabIndex = 1
        Me.cmd_exit.Text = "Exit"
        '
        'ssgrid1
        '
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(16, 152)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(720, 432)
        Me.ssgrid1.TabIndex = 5
        '
        'grp_Billposting
        '
        Me.grp_Billposting.BackgroundImage = CType(resources.GetObject("grp_Billposting.BackgroundImage"), System.Drawing.Image)
        Me.grp_Billposting.Controls.Add(Me.lbl_Todate)
        Me.grp_Billposting.Controls.Add(Me.dtp_Todate)
        Me.grp_Billposting.Controls.Add(Me.lbl_head)
        Me.grp_Billposting.Controls.Add(Me.Cmd_Fill)
        Me.grp_Billposting.Controls.Add(Me.lbl_Fromdate)
        Me.grp_Billposting.Controls.Add(Me.dtp_Fromdate)
        Me.grp_Billposting.Location = New System.Drawing.Point(80, 8)
        Me.grp_Billposting.Name = "grp_Billposting"
        Me.grp_Billposting.Size = New System.Drawing.Size(648, 128)
        Me.grp_Billposting.TabIndex = 7
        Me.grp_Billposting.TabStop = False
        '
        'lbl_Todate
        '
        Me.lbl_Todate.AutoSize = True
        Me.lbl_Todate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Todate.Location = New System.Drawing.Point(344, 56)
        Me.lbl_Todate.Name = "lbl_Todate"
        Me.lbl_Todate.Size = New System.Drawing.Size(89, 22)
        Me.lbl_Todate.TabIndex = 9
        Me.lbl_Todate.Text = "TO DATE :"
        '
        'dtp_Todate
        '
        Me.dtp_Todate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Todate.Location = New System.Drawing.Point(440, 56)
        Me.dtp_Todate.Name = "dtp_Todate"
        Me.dtp_Todate.Size = New System.Drawing.Size(168, 26)
        Me.dtp_Todate.TabIndex = 8
        '
        'lbl_head
        '
        Me.lbl_head.BackColor = System.Drawing.Color.Maroon
        Me.lbl_head.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_head.ForeColor = System.Drawing.Color.White
        Me.lbl_head.Location = New System.Drawing.Point(112, 8)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(376, 24)
        Me.lbl_head.TabIndex = 7
        Me.lbl_head.Text = "AUDIT TRAIL CUMULATIVE"
        Me.lbl_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmd_Fill
        '
        Me.Cmd_Fill.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Fill.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Fill.ForeColor = System.Drawing.Color.White
        Me.Cmd_Fill.Image = CType(resources.GetObject("Cmd_Fill.Image"), System.Drawing.Image)
        Me.Cmd_Fill.Location = New System.Drawing.Point(264, 88)
        Me.Cmd_Fill.Name = "Cmd_Fill"
        Me.Cmd_Fill.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Fill.TabIndex = 2
        Me.Cmd_Fill.Text = "FILL"
        '
        'lbl_Fromdate
        '
        Me.lbl_Fromdate.AutoSize = True
        Me.lbl_Fromdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Fromdate.Location = New System.Drawing.Point(24, 56)
        Me.lbl_Fromdate.Name = "lbl_Fromdate"
        Me.lbl_Fromdate.Size = New System.Drawing.Size(116, 22)
        Me.lbl_Fromdate.TabIndex = 5
        Me.lbl_Fromdate.Text = "FROM DATE :"
        '
        'dtp_Fromdate
        '
        Me.dtp_Fromdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Fromdate.Location = New System.Drawing.Point(160, 56)
        Me.dtp_Fromdate.Name = "dtp_Fromdate"
        Me.dtp_Fromdate.Size = New System.Drawing.Size(168, 26)
        Me.dtp_Fromdate.TabIndex = 0
        '
        'postingaudit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(872, 598)
        Me.Controls.Add(Me.grp_Billposting)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ssgrid1)
        Me.Name = "postingaudit"
        Me.Text = "postingaudit"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Billposting.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Cmd_Audit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        Try
            Call ExportTo(ssgrid1)
        Catch ex As Exception
            MessageBox.Show("Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        ssgrid1.ClearRange(1, 1, -1, -1, True)
        Me.dtp_Fromdate.Value = Format(Now, "dd-MMM-yyyy")
        Me.dtp_Todate.Value = Format(Now, "dd-MMM-yyyy")
    End Sub

    Private Sub postingaudit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtp_Fromdate.Value = Format(Now, "dd-MMM-yyyy")
        Me.dtp_Todate.Value = Format(Now, "dd-MMM-yyyy")
    End Sub

    Private Sub Cmd_Fill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Fill.Click
        ssgrid1.ClearRange(1, 1, -1, -1, True)
        SQLSTRING = " EXEC POS_POSWISE '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' , '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
        gconnection.ExcuteStoreProcedure(SQLSTRING)
        Dim i As Integer
        SQLSTRING = "select accounthead,sum(credit)as credit ,sum(debit)as debit from view_tallypostauditnew where voucherdate between '" & Format(dtp_Fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' group by accounthead"
        gconnection.getDataSet(SQLSTRING, "cululative")
        If gdataset.Tables("cululative").Rows.Count > 0 Then
            With ssgrid1
                .Row = 1
                .Col = 1
                .Text = "ACCOUNTHEAD"
                .Row = 1
                .Col = 2
                .Text = "DEBIT"
                .Row = 1
                .Col = 3
                .Text = "CREDIT"

            End With
            For i = 0 To gdataset.Tables("cululative").Rows.Count - 1
                With ssgrid1
                    .Row = i + 2
                    .Col = 1
                    .Text = gdataset.Tables("cululative").Rows(i).Item("accounthead")
                    .Row = i + 2
                    .Col = 2
                    .Text = gdataset.Tables("cululative").Rows(i).Item("debit")
                    .Row = i + 2
                    .Col = 3
                    .Text = gdataset.Tables("cululative").Rows(i).Item("credit")

                End With
            Next
        End If
    End Sub

    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub
End Class
