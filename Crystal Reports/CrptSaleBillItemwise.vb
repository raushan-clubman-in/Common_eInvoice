Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class CrptSaleBillItemwise
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
    Friend WithEvents lbl_POSCode As System.Windows.Forms.Label
    Friend WithEvents cbo_POSCode As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_FromDate As System.Windows.Forms.Label
    Friend WithEvents lbl_ToDate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crptSalesBill = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.lbl_POSCode = New System.Windows.Forms.Label
        Me.cbo_POSCode = New System.Windows.Forms.ComboBox
        Me.lbl_FromDate = New System.Windows.Forms.Label
        Me.lbl_ToDate = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'crptSalesBill
        '
        Me.crptSalesBill.ActiveViewIndex = -1
        Me.crptSalesBill.DisplayGroupTree = False
        Me.crptSalesBill.Location = New System.Drawing.Point(16, 40)
        Me.crptSalesBill.Name = "crptSalesBill"
        Me.crptSalesBill.ReportSource = Nothing
        Me.crptSalesBill.Size = New System.Drawing.Size(760, 512)
        Me.crptSalesBill.TabIndex = 3
        '
        'lbl_POSCode
        '
        Me.lbl_POSCode.AutoSize = True
        Me.lbl_POSCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_POSCode.Location = New System.Drawing.Point(48, 8)
        Me.lbl_POSCode.Name = "lbl_POSCode"
        Me.lbl_POSCode.Size = New System.Drawing.Size(121, 21)
        Me.lbl_POSCode.TabIndex = 4
        Me.lbl_POSCode.Text = "Select POSCode :"
        '
        'cbo_POSCode
        '
        Me.cbo_POSCode.Location = New System.Drawing.Point(184, 8)
        Me.cbo_POSCode.Name = "cbo_POSCode"
        Me.cbo_POSCode.Size = New System.Drawing.Size(136, 21)
        Me.cbo_POSCode.TabIndex = 0
        '
        'lbl_FromDate
        '
        Me.lbl_FromDate.AutoSize = True
        Me.lbl_FromDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromDate.Location = New System.Drawing.Point(360, 8)
        Me.lbl_FromDate.Name = "lbl_FromDate"
        Me.lbl_FromDate.Size = New System.Drawing.Size(86, 21)
        Me.lbl_FromDate.TabIndex = 5
        Me.lbl_FromDate.Text = "From Date :"
        '
        'lbl_ToDate
        '
        Me.lbl_ToDate.AutoSize = True
        Me.lbl_ToDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToDate.Location = New System.Drawing.Point(568, 8)
        Me.lbl_ToDate.Name = "lbl_ToDate"
        Me.lbl_ToDate.Size = New System.Drawing.Size(67, 21)
        Me.lbl_ToDate.TabIndex = 6
        Me.lbl_ToDate.Text = "To Date :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(448, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(648, 8)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(112, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'CrptSaleBillItemwise
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(822, 587)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_ToDate)
        Me.Controls.Add(Me.lbl_FromDate)
        Me.Controls.Add(Me.cbo_POSCode)
        Me.Controls.Add(Me.lbl_POSCode)
        Me.Controls.Add(Me.crptSalesBill)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "CrptSaleBillItemwise"
        Me.Text = "CrptSaleBillItemwise"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim crs As New ReportDocument
    Dim gconnection As New GlobalClass
    Private Sub CrptSaleBillItemwise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'crs.Load(Application.StartupPath & "\Reports\SaleItemwiseRegister1.rpt")
        'crptSalesBill.ReportSource = crs
        Call FillPOS()
    End Sub

    Private Sub cbo_POSCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_POSCode.KeyPress
        Dim servername As String = "cscserver"
        '''************************ Objects used to set the parameters in the report ***************************''
        Dim pvCollection As New CrystalDecisions.Shared.ParameterValues
        Dim pdvposcode As New CrystalDecisions.Shared.ParameterDiscreteValue
        ''''************************ Objects used to set the proper database connection information ************''
        Dim tbCurrent As CrystalDecisions.CrystalReports.Engine.Table
        Dim tliCurrent As CrystalDecisions.Shared.TableLogOnInfo
        '''************************* Create a report document instance to hold the report **********************''
        Try
            '''********************* Load the report ***********************************************************''
            crs.Load(Application.StartupPath & "\Reports\SaleItemwiseRegister1.rpt")
            pdvposcode.Value = cbo_POSCode.Text
            '''******************** Add it to the parameter collection.*****************************************''
            pvCollection.Add(pdvposcode)
            '''******************** Apply the current parameter values. ****************************************''
            crs.DataDefinition.ParameterFields("@posdesc").ApplyCurrentValues(pvCollection)
            '''******************** Hide group tree for this report ********************************************''
            crptSalesBill.DisplayGroupTree = False
            '''******************** Set the report source for the crystal reports viewer to the ****************''
            '''******************** Report instance. ***********************************************************''
            crptSalesBill.ReportSource = crs
            '''******************** Zoom viewer to fit to the whole page so the user can see the report ********''
        Catch Exp As LoadSaveReportException
            MsgBox("Incorrect path for loading report.", _
                    MsgBoxStyle.Critical, "Load Report Error")
            Exit Sub
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
            Exit Sub
        End Try
        gconnection.closeConnection()
    End Sub
    Private Sub FillPOS()
        Dim ssql As String
        Dim i As Int16
        ssql = "SELECT POScode,Posseqno FROM POSMaster"
        cbo_POSCode.Items.Clear()
        gconnection.getDataSet(ssql, "POSMaster")
        If gdataset.Tables("POSMaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POSMaster").Rows.Count - 1
                With gdataset.Tables("POSMaster").Rows(i)
                    cbo_POSCode.Items.Add(Trim(.Item("POSCode")))
                End With
            Next i
        End If
    End Sub
End Class
