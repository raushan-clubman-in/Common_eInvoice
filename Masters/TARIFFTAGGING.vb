Public Class TARIFFTAGGING
    Inherits System.Windows.Forms.Form
    Dim Vconn As New GlobalClass
    Friend WithEvents SSMatching As AxFPSpreadADO.AxfpSpread
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
    Friend WithEvents Cmd_Audit As System.Windows.Forms.Button
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TARIFFTAGGING))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Cmd_Audit = New System.Windows.Forms.Button
        Me.cmd_clear = New System.Windows.Forms.Button
        Me.cmd_view = New System.Windows.Forms.Button
        Me.cmd_update = New System.Windows.Forms.Button
        Me.cmd_exit = New System.Windows.Forms.Button
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Cmd_Audit)
        Me.Panel1.Controls.Add(Me.cmd_clear)
        Me.Panel1.Controls.Add(Me.cmd_view)
        Me.Panel1.Controls.Add(Me.cmd_update)
        Me.Panel1.Controls.Add(Me.cmd_exit)
        Me.Panel1.Location = New System.Drawing.Point(864, 168)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 280)
        Me.Panel1.TabIndex = 4
        '
        'Cmd_Audit
        '
        Me.Cmd_Audit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Audit.Image = CType(resources.GetObject("Cmd_Audit.Image"), System.Drawing.Image)
        Me.Cmd_Audit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Audit.Location = New System.Drawing.Point(8, 176)
        Me.Cmd_Audit.Name = "Cmd_Audit"
        Me.Cmd_Audit.Size = New System.Drawing.Size(120, 40)
        Me.Cmd_Audit.TabIndex = 3
        Me.Cmd_Audit.Text = "Audit"
        Me.Cmd_Audit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_clear
        '
        Me.cmd_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.Image = CType(resources.GetObject("cmd_clear.Image"), System.Drawing.Image)
        Me.cmd_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_clear.Location = New System.Drawing.Point(8, 8)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(120, 40)
        Me.cmd_clear.TabIndex = 1
        Me.cmd_clear.Text = "Clear"
        Me.cmd_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_view
        '
        Me.cmd_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.Image = CType(resources.GetObject("cmd_view.Image"), System.Drawing.Image)
        Me.cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_view.Location = New System.Drawing.Point(8, 64)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(120, 40)
        Me.cmd_view.TabIndex = 1
        Me.cmd_view.Text = "View"
        Me.cmd_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_update
        '
        Me.cmd_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_update.Image = CType(resources.GetObject("cmd_update.Image"), System.Drawing.Image)
        Me.cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_update.Location = New System.Drawing.Point(8, 120)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(120, 40)
        Me.cmd_update.TabIndex = 1
        Me.cmd_update.Text = "Update"
        Me.cmd_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_exit
        '
        Me.cmd_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit.Image = CType(resources.GetObject("cmd_exit.Image"), System.Drawing.Image)
        Me.cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exit.Location = New System.Drawing.Point(8, 232)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(120, 40)
        Me.cmd_exit.TabIndex = 1
        Me.cmd_exit.Text = "Exit"
        Me.cmd_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ssgrid1
        '
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(184, 112)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(664, 432)
        Me.ssgrid1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(184, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PARTY TARRIF LEDGER TAGGING"
        '
        'TARIFFTAGGING
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1024, 586)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ssgrid1)
        Me.Name = "TARIFFTAGGING"
        Me.Text = "TARIFFTAGGING"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TARIFFTAGGING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        SQLSTRING = "select a.TARIFFCODE,a.tariffdesc ,isnull(a.TAXTYPE,'') as LedgerName,isnull(a.SACNO,'') as costcenter  from PARTY_TARIFFHDR a   order by a.TARIFFCODE "
        Vconn.getDataSet(SQLSTRING, "acctag")
        If gdataset.Tables("acctag").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("acctag").Rows.Count - 1
                j = i + 1
                With ssgrid1
                    .Row = j
                    .Col = 1
                    .Text = gdataset.Tables("acctag").Rows(i).Item("TARIFFCODE")
                    .Col = 2
                    .Text = gdataset.Tables("acctag").Rows(i).Item("tariffdesc")
                    .Col = 3
                    .Text = gdataset.Tables("acctag").Rows(i).Item("LedgerName")
                    .Col = 4
                    .Text = gdataset.Tables("acctag").Rows(i).Item("costcenter")

                End With
                ssgrid1.MaxRows = ssgrid1.MaxRows + 1
            Next
        End If
    End Sub

    Private Sub ssgrid1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid1.Advance

    End Sub

    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        With ssgrid1
            If .ActiveCol = 3 Then
                .Row = .ActiveRow
                .Col = 3
                If .Text = "" Then
                    Call FillMenu()
                End If
            End If
        End With
    End Sub
    Private Sub FillMenu()
        Dim vform As New ListOperattion1
        Dim ssql As String
        gSQLString = "select  LEDGERNAME from ACCOUNTSGLACCOUNTMASTER "
        vform.Field = "LEDGERNAME"
        vform.vFormatstring = "accountin"
        vform.vCaption = "LEDGER NAME HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                .Col = 3
                .Row = .ActiveRow
                .Text = vform.keyfield
            End With
        Else
            ssgrid1.SetActiveCell(0, ssgrid1.ActiveRow)
            Exit Sub
        End If
    End Sub
    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        ssgrid1.ClearRange(1, 1, ssgrid1.DataColCnt, ssgrid1.DataRowCnt, False)
        Call Me.TARIFFTAGGING_Load(sender, e)
    End Sub

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        Try
            Call ExportTo(ssgrid1)
        Catch ex As Exception
            MessageBox.Show("Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        Dim i As Integer
        Dim itemcd, acccd, ssql, cc As String
        If ssgrid1.DataRowCnt <= 0 Then
            MsgBox("NO RECORD TO SAVE")
            Exit Sub
        End If
        With ssgrid1
            For i = 0 To ssgrid1.DataRowCnt - 1
                .Row = i + 1
                .Col = 1
                itemcd = .Text
                .Col = 3
                acccd = .Text

                .Col = 4
                cc = .Text

                ssql = "update PARTY_TARIFFHDR set TAXTYPE='" & acccd & "',SACNO='" & cc & "' where TARIFFCODE='" & itemcd & "'"
                Vconn.dataOperation(6, ssql, "item")

            Next
        End With
        MessageBox.Show("Record Saved Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Cmd_Audit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Audit.Click
        Try
            Dim sqlstring As String
            Dim _export As New EXPORT
            _export.TABLENAME = "Tally_PaymentModeMaster"
            sqlstring = "SELECT * FROM Tally_PaymentModeMaster"
            Call _export.export_excel(sqlstring)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MsgBox("Sorry!, Export to Excel is Terminated Abnormally, Bcoz " & ex.Message.ToString(), MsgBoxStyle.OKOnly, "Error!")
        End Try
    End Sub

    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub
End Class
