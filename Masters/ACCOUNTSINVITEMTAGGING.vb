
Public Class ACCOUNTSINVITEMTAGGING

    Inherits System.Windows.Forms.Form
    Dim Vconn As New GlobalClass
    Friend WithEvents SSMatching As AxFPSpreadADO.AxfpSpread
    Dim SQLSTRING, str, str1 As String
    Dim OLDNEW As Boolean = False
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ACCOUNTSINVITEMTAGGING))
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmd_update = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmd_view = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssgrid1
        '
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(176, 120)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(672, 408)
        Me.ssgrid1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Clear"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(856, 568)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "View"
        Me.Button2.Visible = False
        '
        'cmd_update
        '
        Me.cmd_update.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_update.ForeColor = System.Drawing.Color.Black
        Me.cmd_update.Image = CType(resources.GetObject("cmd_update.Image"), System.Drawing.Image)
        Me.cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_update.Location = New System.Drawing.Point(8, 104)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(120, 40)
        Me.cmd_update.TabIndex = 1
        Me.cmd_update.Text = "Update"
        Me.cmd_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(8, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 40)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Exit"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.cmd_update)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.cmd_view)
        Me.Panel1.Location = New System.Drawing.Point(864, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 352)
        Me.Panel1.TabIndex = 2
        '
        'cmd_view
        '
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.Image = CType(resources.GetObject("cmd_view.Image"), System.Drawing.Image)
        Me.cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_view.Location = New System.Drawing.Point(8, 64)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(120, 40)
        Me.cmd_view.TabIndex = 4
        Me.cmd_view.Text = "View"
        Me.cmd_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ACCOUNTS INVENTORY ITEM TAGGING"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(664, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Press F8 for Search"
        '
        'ACCOUNTSINVITEMTAGGING
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1040, 670)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ssgrid1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "ACCOUNTSINVITEMTAGGING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNTSINVITEMTAGGING"
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ACCOUNTSINVITEMTAGGING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer

        'str1 = "alter table inventoryitemmaster add Ledger varchar(50)"
        'Vconn.dataOperation1(6, str1, "item")
        Try
            SQLSTRING = "SELECT *  FROM SYSOBJECTS WHERE  NAME = 'CLOSINGQTY'"
            ''       BEGIN ALTER TABLE [dbo].[INV_inventoryitemmaster] ADD HSNNO varchar(20)        End"
            Vconn.getDataSet(SQLSTRING, "ABC")
            If gdataset.Tables("ABC").Rows.Count > 0 Then
                SQLSTRING = "SELECT * FROM CLOSINGQTY"
                ''       BEGIN ALTER TABLE [dbo].[INV_inventoryitemmaster] ADD HSNNO varchar(20)        End"
                Vconn.getDataSet(SQLSTRING, "ABC")
                If gdataset.Tables("ABC").Rows.Count > 0 Then
                    OLDNEW = True
                Else
                    OLDNEW = False
                End If
            Else
                OLDNEW = False
            End If
        Catch
        End Try
        If OLDNEW = True Then
            SQLSTRING = "select a.itemcode,a.itemname ,isnull(a.groupcode,'') as groupcode,ISNULL((SELECT isnull(B.groupDESC,'') FROM INVENTORYGROUPMASTER B WHERE B.GROUPCODE=A.GROUPCODE),'') as groupname,isnull(a.TAXTYPE,'') as Ledger,isnull(a.HSNNO,'')AS COSTCENTER ,'' AS TAXGROUPCODE from INV_inventoryitemmaster a WHERE ISNULL(VOID,'')<>'Y'  order by A.TAXTYPE,a.itemcode "
        Else
            SQLSTRING = "select DISTINCT  a.itemcode,a.itemname ,isnull(a.groupcode,'') as groupcode,isnull(a.groupname,'') as groupname,isnull(a.TAXTYPE,'') as Ledger,isnull(a.HSNNO,'')AS COSTCENTER,ISNULL(TAXGROUPCODE,'')AS TAXGROUPCODE from view_inventoryitemmaster a left outer join accountsglaccountmaster b on a.ledger=b.accode "
        End If
        Vconn.getDataSet(SQLSTRING, "acctag")
        If gdataset.Tables("acctag").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("acctag").Rows.Count - 1
                j = i + 1
                With ssgrid1
                    .Row = j
                    .Col = 1
                    .Text = gdataset.Tables("acctag").Rows(i).Item("itemcode")
                    .Col = 2
                    .Text = gdataset.Tables("acctag").Rows(i).Item("itemname")
                    .Col = 3
                    .Text = gdataset.Tables("acctag").Rows(i).Item("groupcode")
                    .Col = 4
                    .Text = gdataset.Tables("acctag").Rows(i).Item("groupname")
                    .Col = 5
                    .Text = gdataset.Tables("acctag").Rows(i).Item("Ledger")
                    .Col = 6
                    .Text = gdataset.Tables("acctag").Rows(i).Item("COSTCENTER")
                    .Col = 7
                    .Text = gdataset.Tables("acctag").Rows(i).Item("TAXGROUPCODE")
                    If OLDNEW = True Then
                        .Col = 7
                        .ColHidden = True
                    End If
                End With
                
                ssgrid1.MaxRows = ssgrid1.MaxRows + 1
            Next
        End If
    End Sub
    Private Sub SSMatching_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles SSMatching.DblClick



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub ssgrid1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid1.Advance

    End Sub

    'Private Sub ssgrid1_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles ssgrid1.DblClick
    '    Dim ssql As String
    '    Dim itemcode, itemdesc As String

    '    With ssgrid1
    '        .Col = 1
    '        .Row = .ActiveRow
    '        itemcode = .Text
    '        .Col = 2
    '        .Row = .ActiveRow
    '        itemdesc = .Text
    '    End With
    '    SQLSTRING = "select a.itemcode,a.itemdesc ,isnull(a.salesacctin,'') as accode,isnull(b.acdesc,'') as acdesc  from itemmaster a left outer join accountsglaccountmaster b on a.salesacctin=b.accode where isnull(a.freeze,'')<>'Y' and isnull(b.freezeflag,'')<>'Y' order by b.acdesc,a.itemcode "
    '    Vconn.getDataSet(SQLSTRING, "acctag")

    '    If gdataset.Tables("acctag").Rows.Count = 0 Then
    '        Exit Sub
    '    End If
    '    If gdataset.Tables("acctag").Rows.Count > 1 Then
    '        Exit Sub
    '    End If
    'End Sub
    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        If e.keyCode = Keys.Enter Then
            With ssgrid1
                If .ActiveCol = 3 Then
                    .Row = .ActiveRow
                    If .Text = "" Then
                        Call FillMenu()
                    End If
                End If
                If .Col = 4 Then
                    .Row = .ActiveRow
                    If .Text = "" Then
                        Call FillMenu()
                    End If
                End If
            End With
        End If
        If e.keyCode = Keys.F8 Then
            Dim search As New frmSearch
            search.farPoint = ssgrid1
            search.Text = "Item Search"
            search.ShowDialog(Me)
            Exit Sub
        End If
    End Sub
    Private Sub FillMenu()
        Dim vform As New ListOperattion1
        Dim ssql As String
        gSQLString = "select accode,acdesc from accountsglaccountmaster "
        If Trim(Search) = " " Then
            M_WhereCondition = "WHERE   category in ('I') and ISNULL(FREEZEFLAG,'') <>'Y'"
        Else
            M_WhereCondition = " WHERE (accode LIKE '%" & Search & "%' OR acdesc LIKE '%" & Search & "%') AND category in ('I') and  ISNULL(FREEZEFLAG,'') <>'Y' "
        End If
        vform.Field = "ACDESC,ACCODE"
        vform.vFormatstring = "ACCODE     |ACDESC                        "
        vform.vCaption = "ITEM CODE HELP"
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
        Dim i As Integer
        Dim itemcd, acccd, ssql, COSTCENTER, tg As String
        If ssgrid1.DataRowCnt <= 1 Then
            MsgBox("NO RECORD TO SAVE")
            Exit Sub
        End If
        With ssgrid1
            For i = 0 To ssgrid1.DataRowCnt - 1
                .Row = i + 1
                .Col = 1
                itemcd = .Text
                .Col = 5
                acccd = .Text
                .Col = 6
                COSTCENTER = .Text
                .Col = 7
                tg = .Text
                If OLDNEW = False Then
                    ssql = "update inventoryitemmaster set TAXTYPE='" & acccd & "',HSNNO='" & COSTCENTER & "',TAXGROUPCODE='" & tg & "' where itemcode='" & itemcd & "'"
                Else
                    ssql = "update INV_inventoryitemmaster set TAXTYPE='" & acccd & "',HSNNO='" & COSTCENTER & "' where itemcode='" & itemcd & "'"

                End If
                Vconn.dataOperation(6, ssql, "item")

            Next
        End With
        MessageBox.Show("Record Saved Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ssgrid1.ClearRange(1, 1, ssgrid1.DataColCnt, ssgrid1.DataRowCnt, False)
        Call ACCOUNTSINVITEMTAGGING_Load(sender, e)
    End Sub
    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        Try
            Call ExportTo(ssgrid1)
        Catch ex As Exception
            MessageBox.Show("Tally " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
End Class
