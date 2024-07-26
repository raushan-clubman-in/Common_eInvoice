Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class CrptSalesBillChecklist
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
    Friend WithEvents crptSalesBill As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crptSalesBill = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crptSalesBill
        '
        Me.crptSalesBill.ActiveViewIndex = -1
        Me.crptSalesBill.DisplayGroupTree = False
        Me.crptSalesBill.Location = New System.Drawing.Point(16, 8)
        Me.crptSalesBill.Name = "crptSalesBill"
        Me.crptSalesBill.ReportSource = Nothing
        Me.crptSalesBill.Size = New System.Drawing.Size(992, 704)
        Me.crptSalesBill.TabIndex = 0
        '
        'CrptSalesBillChecklist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1022, 723)
        Me.Controls.Add(Me.crptSalesBill)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "CrptSalesBillChecklist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CrptSalesBillChecklist"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim crs As New ReportDocument
    Private Sub CrptSalesBillChecklist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        crs.Load(Application.StartupPath & "\Reports\SalesBillChecklist.rpt")
        crptSalesBill.ReportSource = crs
    End Sub
End Class
