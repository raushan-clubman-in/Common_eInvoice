Public Class ACCOUNTScateitemTAGGING

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
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Audit As System.Windows.Forms.Button
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ACCOUNTScateitemTAGGING))
        Me.cmd_clear = New System.Windows.Forms.Button
        Me.cmd_view = New System.Windows.Forms.Button
        Me.cmd_update = New System.Windows.Forms.Button
        Me.cmd_exit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmd_export = New System.Windows.Forms.Button
        Me.Cmd_Audit = New System.Windows.Forms.Button
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread
        Me.Panel1.SuspendLayout()
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_clear
        '
        Me.cmd_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.Location = New System.Drawing.Point(24, 8)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(80, 40)
        Me.cmd_clear.TabIndex = 1
        Me.cmd_clear.Text = "Clear"
        '
        'cmd_view
        '
        Me.cmd_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.Location = New System.Drawing.Point(136, 8)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(80, 40)
        Me.cmd_view.TabIndex = 1
        Me.cmd_view.Text = "View"
        '
        'cmd_update
        '
        Me.cmd_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_update.Location = New System.Drawing.Point(240, 8)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(88, 40)
        Me.cmd_update.TabIndex = 1
        Me.cmd_update.Text = "Update"
        '
        'cmd_exit
        '
        Me.cmd_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit.Location = New System.Drawing.Point(568, 8)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(88, 40)
        Me.cmd_exit.TabIndex = 1
        Me.cmd_exit.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmd_export)
        Me.Panel1.Controls.Add(Me.Cmd_Audit)
        Me.Panel1.Controls.Add(Me.cmd_clear)
        Me.Panel1.Controls.Add(Me.cmd_view)
        Me.Panel1.Controls.Add(Me.cmd_update)
        Me.Panel1.Controls.Add(Me.cmd_exit)
        Me.Panel1.Location = New System.Drawing.Point(208, 592)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 56)
        Me.Panel1.TabIndex = 2
        '
        'cmd_export
        '
        Me.cmd_export.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_export.Location = New System.Drawing.Point(464, 8)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(80, 40)
        Me.cmd_export.TabIndex = 3
        Me.cmd_export.Text = "Export"
        '
        'Cmd_Audit
        '
        Me.Cmd_Audit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Audit.Location = New System.Drawing.Point(352, 8)
        Me.Cmd_Audit.Name = "Cmd_Audit"
        Me.Cmd_Audit.Size = New System.Drawing.Size(80, 40)
        Me.Cmd_Audit.TabIndex = 2
        Me.Cmd_Audit.Text = "Audit"
        '
        'ssgrid1
        '
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(24, 119)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(1024, 432)
        Me.ssgrid1.TabIndex = 3
        '
        'ACCOUNTScateitemTAGGING
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1072, 670)
        Me.Controls.Add(Me.ssgrid1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ACCOUNTScateitemTAGGING"
        Me.Text = "ACCOUNTScateitemTAGGING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ACCOUNTScateitemTAGGING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        SQLSTRING = "select a.itemcode,a.itemdesc ,isnull(a.groupcode,'') as groupcode,isnull(c.groupdesc,'') as groupdesc,isnull(a.LedgerName,'') as LedgerName,ISNULL(A.COSTCENTER,'')AS COSTCENTER  from itemmaster a left outer join accountsglaccountmaster b on a.salesacctin=b.accode left outer join groupmaster c on a.groupcode=c.groupcode order by b.acdesc,a.itemcode "
        Vconn.getDataSet(SQLSTRING, "acctag")
        If gdataset.Tables("acctag").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("acctag").Rows.Count - 1
                j = i + 1
                With ssgrid1
                    .Row = j

                    .Col = 1
                    .Text = gdataset.Tables("acctag").Rows(i).Item("itemcode")
                    .Col = 2
                    .Text = gdataset.Tables("acctag").Rows(i).Item("itemdesc")
                    .Col = 3
                    .Text = gdataset.Tables("acctag").Rows(i).Item("groupcode")
                    .Col = 4
                    .Text = gdataset.Tables("acctag").Rows(i).Item("groupdesc")

                    .Col = 5
                    .Text = gdataset.Tables("acctag").Rows(i).Item("LedgerName")
                    .Col = 6
                    .Text = gdataset.Tables("acctag").Rows(i).Item("COSTCENTER")
                End With
                ssgrid1.MaxRows = ssgrid1.MaxRows + 1
            Next
        End If
    End Sub
    Private Sub cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub
    Private Sub ssgrid1_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent)
        If e.keyCode = Keys.Enter Then
            With ssgrid1
                If .ActiveCol = 3 Then
                    .Row = .ActiveRow
                    If .Text = "" Then
                        Call FillGroup()
                    End If
                End If
                If .ActiveCol = 5 Then
                    .Row = .ActiveRow
                    If .Text = "" Then
                        Call FillMenu()
                    End If
                End If
                If .ActiveCol = 6 Then
                    .Row = .ActiveRow
                    .Col = .ActiveCol
                    If .Text = "" Then
                        Call FillMenuCOST()
                    End If
                End If
            End With
        End If
    End Sub
    Private Sub FillMenuCOST()
        Dim vform As New ListOperattion1
        Dim ssql As String
        gSQLString = "select DISTINCT COSTCENTER from ITEMMASTER "
        vform.Field = "COSTCENTER"
        vform.vFormatstring = "COSTCENTER"
        vform.vCaption = "COSTCENTER NAME HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                .Col = 6
                .Row = .ActiveRow
                .Text = vform.keyfield
            End With
        Else
            ssgrid1.SetActiveCell(0, ssgrid1.ActiveRow)
            Exit Sub
        End If
    End Sub
    Private Sub FillMenu()
        Dim vform As New ListOperattion1
        Dim ssql As String
        gSQLString = "select DISTINCT LEDGERNAME from ITEMMASTER "
        vform.Field = "LEDGERNAME"
        vform.vFormatstring = "LEDGERNAME"
        vform.vCaption = "LEDGER NAME HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                .Col = 5
                .Row = .ActiveRow
                .Text = vform.keyfield
            End With
        Else
            ssgrid1.SetActiveCell(0, ssgrid1.ActiveRow)
            Exit Sub
        End If
    End Sub
    Private Sub FillGroup()
        Dim vform As New ListOperattion1
        Dim ssql As String
        gSQLString = "select DISTINCT GROUPCODE,GROUPDESC from GROUPMASTER "
        vform.Field = "GROUPCODE,GROUPDESC"
        vform.vFormatstring = "GROUPCODE   |GROUPDESC "
        vform.vCaption = "GROUP MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                .Col = 3
                .Row = .ActiveRow
                .Text = vform.keyfield

                .Col = 4
                .Row = .ActiveRow
                .Text = vform.keyfield1

            End With
        Else
            ssgrid1.SetActiveCell(0, ssgrid1.ActiveRow)
            Exit Sub
        End If
    End Sub

    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        Dim i, j As Integer
        Dim itemcd, acccd, ssql, Insert(0), groupcd, MsgResult, GroupDesc, COSTCD As String

        If ssgrid1.DataRowCnt <= 0 Then
            MsgBox("NO RECORD TO SAVE")
            Exit Sub
        End If

        j = 0
        With ssgrid1
            For i = 0 To ssgrid1.DataRowCnt - 1
                .Row = i + 1
                .Col = 3
                groupcd = .Text
                .Col = 4
                GroupDesc = .Text

                SQLSTRING = "select groupcode from groupmaster where groupcode='" & groupcd & "'"
                Vconn.getDataSet(SQLSTRING, "acctag")
                If gdataset.Tables("acctag").Rows.Count <= 0 Then
                    MsgResult = "Groupcode not in Groupmaster.........Please Note it down " & groupcd & " " & GroupDesc
                    MsgBox(MsgResult)
                    j = j + 1
                End If
            Next
        End With

        If j >= 1 Then
            Exit Sub
        End If

        With ssgrid1
            For i = 0 To ssgrid1.DataRowCnt - 1
                .Row = i + 1
                .Col = 1
                itemcd = .Text
                .Col = 5
                acccd = .Text

                .Col = 3
                groupcd = .Text

                .Col = 6
                COSTCD = .Text

                ssql = "update itemmaster set LEDGERNAME='" & acccd & "',GROUPCODE='" & groupcd & "',COSTCENTER='" & COSTCD & "' where itemcode='" & itemcd & "'"
                '                Vconn.dataOperation(6, ssql, "item")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = ssql
            Next
            Vconn.MORETRANS(Insert)

        End With
        '        MessageBox.Show("Record Saved Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        ssgrid1.ClearRange(1, 1, ssgrid1.DataColCnt, ssgrid1.DataRowCnt, False)
        Call ACCOUNTScateitemTAGGING_Load(sender, e)
    End Sub
    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        Try
            Call ExportTo(ssgrid1)
        Catch ex As Exception
            MessageBox.Show("Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Audit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Audit.Click
        Try
            Dim sqlstring As String
            Dim _export As New EXPORT
            _export.TABLENAME = "Tally_ItemMaster"
            sqlstring = "SELECT * FROM Tally_ItemMaster"
            Call _export.export_excel(sqlstring)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MsgBox("Sorry!, Export to Excel is Terminated Abnormally, Bcoz " & ex.Message.ToString(), MsgBoxStyle.OKOnly, "Error!")
        End Try
    End Sub
    Private Sub cmd_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_export.Click
        Try
            Dim sqlstring As String
            Dim _export As New EXPORT

            sqlstring = "drop view vw_tally_groupledger "
            Vconn.getDataSet(sqlstring, "acctag")

            sqlstring = "create view vw_tally_groupledger as select a.itemcode,a.itemdesc,a.groupcode,b.groupdesc,ledgername from itemmaster a,groupmaster b where a.groupcode=b.groupcode group by a.itemcode,a.itemdesc,a.groupcode,b.groupdesc,ledgername"
            Vconn.getDataSet(sqlstring, "acctag")

            _export.TABLENAME = "vw_tally_groupledger"
            sqlstring = "SELECT * FROM vw_tally_groupledger order by groupcode,ledgername"
            Call _export.export_excel(sqlstring)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MsgBox("Sorry!, Export to Excel is Terminated Abnormally, Bcoz " & ex.Message.ToString(), MsgBoxStyle.OKOnly, "Error!")
        End Try
    End Sub

    Private Sub ssgrid1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent)

    End Sub
End Class
