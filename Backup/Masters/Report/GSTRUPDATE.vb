Imports System.Data.SqlClient
Public Class GSTRUPDATE
    Inherits System.Windows.Forms.Form
    Dim cn As New SqlConnection
     Dim cmd As SQLCommand
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cmd_UPDATE As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.cmd_UPDATE = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AccessibleName = "DataGrid"
        Me.DataGrid1.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(1064, 456)
        Me.DataGrid1.TabIndex = 0
        '
        'cmd_UPDATE
        '
        Me.cmd_UPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_UPDATE.Location = New System.Drawing.Point(360, 512)
        Me.cmd_UPDATE.Name = "cmd_UPDATE"
        Me.cmd_UPDATE.Size = New System.Drawing.Size(88, 40)
        Me.cmd_UPDATE.TabIndex = 2
        Me.cmd_UPDATE.Text = "UPDATE"
        '
        'GSTRUPDATE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1104, 569)
        Me.Controls.Add(Me.cmd_UPDATE)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "GSTRUPDATE"
        Me.Text = "GSTRUPDATE"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GSTRUPDATE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=" & gserver & ";Persist Security Info=False;User ID=" & gSqlUserName & ";Password=" & gSqlUserPassword & ";Initial Catalog= " & gDatabase & ";"
        cn.Open()
        cmd = New SqlCommand(GSTSQL, cn)
        adp = New SqlDataAdapter(cmd)
        adp.Fill(ds, "GSTREVENUE")
        Me.DataGrid1.DataSource = ds
        Me.DataGrid1.DataMember = "GSTREVENUE"
    End Sub
    Private Sub cmd_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_UPDATE.Click
        Dim cmdbuilder As New SqlCommandBuilder(adp)
        Dim i As Integer
        Try
            i = adp.Update(ds, "GSTREVENUE")
            MsgBox("Records Updated= " & i)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GSTRUPDATE_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'cn.ConnectionString = "Data Source=" & gserver & ";Persist Security Info=False;User ID=" & gSqlUserName & ";Password=" & gSqlUserPassword & ";Initial Catalog= " & gDatabase & ";"
        cn.Close()
    End Sub
End Class
  