Imports System.Data.SqlClient
Public Class frmServerWiseMember
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents mskFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents mskToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents cmdShow As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmServerWiseMember))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.mskFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.mskToDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.cmdShow = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.mskFromDate)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.mskToDate)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(552, 64)
        Me.GroupBox3.TabIndex = 425
        Me.GroupBox3.TabStop = False
        '
        'mskFromDate
        '
        Me.mskFromDate.CustomFormat = "dd-MM-yyyy"
        Me.mskFromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskFromDate.Location = New System.Drawing.Point(136, 24)
        Me.mskFromDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskFromDate.Name = "mskFromDate"
        Me.mskFromDate.Size = New System.Drawing.Size(144, 26)
        Me.mskFromDate.TabIndex = 0
        Me.mskFromDate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "TO DATE :"
        '
        'mskToDate
        '
        Me.mskToDate.CustomFormat = "dd-MM-yyyy"
        Me.mskToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.mskToDate.Location = New System.Drawing.Point(400, 24)
        Me.mskToDate.MaxDate = New Date(2100, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.MinDate = New Date(2005, 8, 14, 0, 0, 0, 0)
        Me.mskToDate.Name = "mskToDate"
        Me.mskToDate.Size = New System.Drawing.Size(144, 26)
        Me.mskToDate.TabIndex = 1
        Me.mskToDate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FROM DATE :"
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(16, 112)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(552, 296)
        Me.ssGrid.TabIndex = 426
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Location = New System.Drawing.Point(55, 418)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 56)
        Me.GroupBox2.TabIndex = 427
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(352, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Clear"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "PRINT [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Transparent
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(242, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 13
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.Transparent
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(128, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 11
        Me.CmdView.Text = "ToExcel [F9]"
        '
        'cmdShow
        '
        Me.cmdShow.BackColor = System.Drawing.Color.Green
        Me.cmdShow.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdShow.Location = New System.Drawing.Point(16, 80)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(552, 24)
        Me.cmdShow.TabIndex = 428
        Me.cmdShow.Text = "<<       SHOW      >>"
        '
        'frmServerWiseMember
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(584, 486)
        Me.Controls.Add(Me.cmdShow)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ssGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.KeyPreview = True
        Me.Name = "frmServerWiseMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmServerWiseMember"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShow.Click
        Try
            Call show_details()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub show_details()
        Try
            Dim sSql, sName As String
            Dim i, count As Integer
            count = 1
            sSql = "Select * from VWSERVERWISEMEMBER WHERE BILLDATE BETWEEN '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' And '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' "
            sSql = sSql & " and isnull(mcode,'')<>'' "
            sSql = sSql & " Order by sName"
            gconnection.getDataSet(sSql, "serverreport")
            If gdataset.Tables("serverreport").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("serverreport").Rows.Count - 1
                    If sName <> gdataset.Tables("serverreport").Rows(i).Item("Sname") Then
                        ssGrid.Row = count
                        ssGrid.FontBold = True
                        ssGrid.BackColor = Color.SkyBlue
                        ssGrid.SetText(1, count, gdataset.Tables("serverreport").Rows(i).Item("SCODE"))
                        ssGrid.SetText(2, count, gdataset.Tables("serverreport").Rows(i).Item("SNAME"))
                        sName = gdataset.Tables("serverreport").Rows(i).Item("Sname")
                        count = count + 1
                    End If
                    ssGrid.SetText(3, count, gdataset.Tables("serverreport").Rows(i).Item("mcode"))
                    ssGrid.SetText(4, count, gdataset.Tables("serverreport").Rows(i).Item("mNAME"))
                    ssGrid.SetText(5, count, gdataset.Tables("serverreport").Rows(i).Item("billdetails"))
                    count = count + 1
                Next
            End If
        Catch ex As Exception
            MsgBox("Please check the entry", ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            'gPrint = False   
            'Call show_details()
            'printoperation()
            ExportTo(ssGrid)
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    '''Private Sub printoperation()
    '''    Dim sSql As String
    '''    Dim strOutFile As String
    '''    Dim clsGReport As New Report.Report

    '''    AppPath = Application.StartupPath
    '''    vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
    '''    VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"

    '''    fdataset.Clear()
    '''    gconnection.FillDataSet("Select Max(Len(Scode)), Max(Len(SName)), Max(Len(MCode)), Max(Len(MName)) From VWSERVERWISEMEMBER WHERE BILLDATE BETWEEN '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' And '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "'", "tblReportLen")
    '''    gconnection.FillDataSet("Select Isnull(Scode,'') as Scode, Isnull(SName,'') as SName, Isnull(Mcode,'') as Mcode, Isnull(MName,'') as MName from VWSERVERWISEMEMBER WHERE BILLDATE BETWEEN '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' And '" & Format(mskFromDate.Value, "dd-MMM-yyyy") & "' Order by sname", "tblReport")

    '''    gCompanyAddresses(0) = gCompanyname
    '''    gCompanyAddresses(1) = "No.1, Strand Road"
    '''    gCompanyAddresses(2) = "Kolkata"

    '''    strOutFile = clsGReport.fnReportGeneration(gCompanyAddresses, "Server wise Member Sales Report from " & Format(mskFromDate.Value, "dd-MMM-yyyy") & "-" & Format(mskToDate.Value, "dd-MMM-yyyy"), "01-Apr-08", "31-Mar-09", "SNo", gUsername, fdataset, VFilePath, False)
    '''    gPrint = False
    '''    If strOutFile <> VFilePath Then
    '''        MsgBox(strOutFile, MsgBoxStyle.OKOnly + MsgBoxStyle.Information, Me.Text)
    '''    Else
    '''        If gPrint = False Then
    '''            OpenTextFile(vOutfile)
    '''        Else
    '''            PrintTextFile1(VFilePath)
    '''        End If
    '''    End If
    '''End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ''gPrint = True
            ''Call printoperation()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub frmServerWiseMember_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mskFromDate.Value = Now
            mskToDate.Value = Now
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub



    Private Sub mskFromDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskFromDate.KeyPress
        Try
            If Asc((e.KeyChar)) = 13 Then
                mskToDate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub mskToDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mskToDate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                cmdShow.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ssGrid.ClearRange(1, 1, -1, -1, True)
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub frmServerWiseMember_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Dim i, Pt As Integer
            If e.KeyCode = Keys.F7 Then
                Search = InputBox("ENTER SERVER NAME/CODE", "SEARCH")
                If Search <> "" Then
                    For i = 0 To ssGrid.MaxRows
                        ssGrid.Row = i
                        ssGrid.Col = ssGrid.ActiveCol
                        If UCase(Search) = UCase(Mid(ssGrid.Text, 1, Len(Search))) Then
                            ssGrid.SetActiveCell(ssGrid.ActiveCol, i)
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try

    End Sub
End Class
