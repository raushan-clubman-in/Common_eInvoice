Imports System.IO
Imports System.Data.SqlClient
Public Class ExporttoExcel
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpYEC As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtsysobject As System.Windows.Forms.TextBox
    Friend WithEvents cmdexport As System.Windows.Forms.Button
    Friend WithEvents Cmd_sysobjectHelp As System.Windows.Forms.Button
    Friend WithEvents Cmdclear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ExporttoExcel))
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtsysobject = New System.Windows.Forms.TextBox
        Me.grpYEC = New System.Windows.Forms.GroupBox
        Me.Cmd_sysobjectHelp = New System.Windows.Forms.Button
        Me.cmdexport = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Cmdclear = New System.Windows.Forms.Button
        Me.grpYEC.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sysobject Name"
        '
        'txtsysobject
        '
        Me.txtsysobject.Location = New System.Drawing.Point(192, 40)
        Me.txtsysobject.Name = "txtsysobject"
        Me.txtsysobject.Size = New System.Drawing.Size(240, 20)
        Me.txtsysobject.TabIndex = 0
        Me.txtsysobject.Text = ""
        '
        'grpYEC
        '
        Me.grpYEC.BackColor = System.Drawing.Color.Transparent
        Me.grpYEC.Controls.Add(Me.Cmdclear)
        Me.grpYEC.Controls.Add(Me.Cmd_sysobjectHelp)
        Me.grpYEC.Controls.Add(Me.cmdexport)
        Me.grpYEC.Controls.Add(Me.Label4)
        Me.grpYEC.Controls.Add(Me.txtsysobject)
        Me.grpYEC.Controls.Add(Me.btnExit)
        Me.grpYEC.Location = New System.Drawing.Point(240, 120)
        Me.grpYEC.Name = "grpYEC"
        Me.grpYEC.Size = New System.Drawing.Size(512, 208)
        Me.grpYEC.TabIndex = 9
        Me.grpYEC.TabStop = False
        '
        'Cmd_sysobjectHelp
        '
        Me.Cmd_sysobjectHelp.Image = CType(resources.GetObject("Cmd_sysobjectHelp.Image"), System.Drawing.Image)
        Me.Cmd_sysobjectHelp.Location = New System.Drawing.Point(440, 40)
        Me.Cmd_sysobjectHelp.Name = "Cmd_sysobjectHelp"
        Me.Cmd_sysobjectHelp.Size = New System.Drawing.Size(16, 16)
        Me.Cmd_sysobjectHelp.TabIndex = 135
        '
        'cmdexport
        '
        Me.cmdexport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexport.Location = New System.Drawing.Point(264, 136)
        Me.cmdexport.Name = "cmdexport"
        Me.cmdexport.TabIndex = 4
        Me.cmdexport.Text = "Export"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(360, 136)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(408, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Export To Excel"
        '
        'Cmdclear
        '
        Me.Cmdclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmdclear.Location = New System.Drawing.Point(176, 136)
        Me.Cmdclear.Name = "Cmdclear"
        Me.Cmdclear.TabIndex = 136
        Me.Cmdclear.Text = "Clear"
        '
        'ExporttoExcel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 694)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grpYEC)
        Me.Name = "ExporttoExcel"
        Me.Text = "ExporttoExcel"
        Me.grpYEC.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim vconn As New GlobalClass
    Dim strSql, SSql(1) As String
    Dim sqlCmd As New SqlCommand
    Dim sqlCon As New SqlConnection
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub ExporttoExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtsysobject.Focus()
    End Sub
    Private Sub cmdexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexport.Click
        Try
            Dim sqlstring As String
            Dim _export As New EXPORT
            _export.TABLENAME = txtsysobject.Text
            sqlstring = "SELECT * FROM " & Trim(txtsysobject.Text)
            Call _export.export_excel(sqlstring)
            _export.Show()
            Exit Sub
        Catch ex As Exception
            MsgBox("Sorry!, Export to Excel is Terminated Abnormally, Bcoz " & ex.Message.ToString(), MsgBoxStyle.OKOnly, "Error!")
        End Try
    End Sub

    Private Sub Cmd_sysobjectHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_sysobjectHelp.Click
        Dim vform As New ListOperattion1
        gSQLString = "select name from sysobjects "
        M_WhereCondition = " where type IN ('U','V') "
        vform.Field = "NAME"
        vform.vFormatstring = "    NAME                             "
        vform.vCaption = "SYS OBJECT NAME HELP"
        vform.KeyPos = 0
        'vform.KeyPos1 = 1
        vform.keyfield = 0
        'vform.keyfield1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtsysobject.Text = Trim(vform.keyfield & "")
            cmdexport.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txtsysobject_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsysobject.Validated
        Dim sqlstring As String
        sqlstring = "select name from sysobjects where type IN ('U','V') AND name = '" & Trim(txtsysobject.Text) & "'"
        vconn.getDataSet(sqlstring, "SYSOBJ")
        If gdataset.Tables("SYSOBJ").Rows.Count > 0 Then
            txtsysobject.Text = Trim(UCase(gdataset.Tables("SYSOBJ").Rows(0).Item("name")))

        Else
            txtsysobject.Focus()
        End If
    End Sub

    Private Sub Cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdclear.Click
        txtsysobject.Text = ""
        '        txtsysobject.Focus()
    End Sub
End Class