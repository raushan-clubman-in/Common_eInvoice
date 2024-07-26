'V Mahendra
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class SalesUOMRelation
    Inherits System.Windows.Forms.Form
    Dim vconn As New GlobalClass
    Dim insert(0) As String
    Dim ssql As String
    Dim vseqno As Double
    Dim i As Integer
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SalesUOMRelation))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.Label16 = New System.Windows.Forms.Label
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.ssGrid)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(664, 256)
        Me.GroupBox4.TabIndex = 319
        Me.GroupBox4.TabStop = False
        '
        'ssGrid
        '
        Me.ssGrid.ContainingControl = Me
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(8, 16)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(648, 232)
        Me.ssGrid.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(216, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(291, 31)
        Me.Label16.TabIndex = 321
        Me.Label16.Text = "SALES UOM RELATION"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(64, 312)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 328
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(408, 312)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 326
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(296, 312)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 327
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(176, 312)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 325
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(520, 312)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 324
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(48, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(592, 56)
        Me.GroupBox2.TabIndex = 323
        Me.GroupBox2.TabStop = False
        '
        'SalesUOMRelation
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(686, 357)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "SalesUOMRelation"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES UOM RELATION"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ssGrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssGrid.LeaveCell
        Dim vacctcode1 As String
        Dim vacctcode2 As String
        Dim vval As String
        ssGrid.GetText(1, ssGrid.ActiveRow, vacctcode1)
        ssGrid.GetText(2, ssGrid.ActiveRow, vacctcode2)
        If Trim(vacctcode1 & "") <> "" And Trim(vacctcode2 & "") <> "" Then
            For i = 1 To ssGrid.DataRowCnt
                ssGrid.Row = i
                ssGrid.Col = 2
                If Trim(ssGrid.Text) <> "" Then
                    If Trim(ssGrid.Text) = Trim(vacctcode2) And ssGrid.Row <> ssGrid.ActiveRow Then
                        ssGrid.Col = 1
                        If Trim(ssGrid.Text) = Trim(vacctcode1) Then
                            MessageBox.Show("UOM Code already Selected", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ssGrid.ClearRange(1, ssGrid.ActiveRow, 5, ssGrid.ActiveRow, True)
                            ssGrid.DeleteRows(ssGrid.ActiveRow, 1)
                            ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                            Call FillUOM()
                            Exit Sub
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub SalesUOMRelation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillUOM()
        Call FillGride()
        UOMRelabool = True
        Mevalidate.Equals(False)
        ssGrid.SetActiveCell(1, 1)
        Cmd_Freeze.Enabled = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='ACCOUNTS INTEGRATION' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        vconn.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.Cmd_Add.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub FillUOM()
        Dim ds As New DataSet
        Dim vUom As String
        Dim j As Integer
        j = 1
        ssql = "SELECT uomdesc FROM UOMMaster"
        vconn.getDataSet(ssql, "UOMMaster")
        If gdataset.Tables("UOMMaster").Rows.Count > 0 Then
            For j = 1 To 50
                For i = 0 To gdataset.Tables("UOMMaster").Rows.Count - 1
                    vUom = gdataset.Tables("UOMMaster").Rows(i).Item("uomdesc")
                    ssGrid.Row = j
                    ssGrid.Col = 1
                    ssGrid.TypeComboBoxString = vUom
                    ssGrid.Col = 2
                    ssGrid.TypeComboBoxString = vUom
                Next
            Next
        End If
    End Sub
    Private Function FillGride()
        Dim j As Integer
        Dim vUom1, vUom2, vMes1, vMes2, Vrow
        Dim ds As New DataSet
        ssql = "SELECT UOM1,UOM2,Ratio1,Ratio2 FROM UOMRelation"
        vconn.getDataSet(ssql, "UOMRelation")
        If gdataset.Tables("UOMRelation").Rows.Count > 0 Then
            For j = 1 To 50
                For i = 0 To gdataset.Tables("UOMRelation").Rows.Count - 1
                    vUom1 = gdataset.Tables("UOMRelation").Rows(i).Item("UOM1")
                    vUom2 = gdataset.Tables("UOMRelation").Rows(i).Item("UOM2")
                    vMes1 = gdataset.Tables("UOMRelation").Rows(i).Item("Ratio1")
                    vMes2 = gdataset.Tables("UOMRelation").Rows(i).Item("Ratio2")
                    ssGrid.Row = i + 1
                    ssGrid.Col = 1
                    ssGrid.SetText(1, ssGrid.Row, vUom1)
                    ssGrid.Col = 2
                    ssGrid.SetText(2, ssGrid.Row, vUom2)
                    ssGrid.Col = 3
                    ssGrid.SetText(3, ssGrid.Row, vMes1)
                    ssGrid.Col = 5
                    ssGrid.SetText(5, ssGrid.Row, vMes2)
                Next
            Next
            Vrow = ssGrid.ActiveRow
        End If
    End Function

    Private Sub ssGrid_ButtonClicked(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_ButtonClickedEvent) Handles ssGrid.ButtonClicked
        Dim vUomRelat1, vUomRelat2, vRow
        Dim gvalidate As Boolean
        Dim i As Integer, k As Integer
        Dim VUOM1, VUOM2, VMes1, VMes2
        Dim uom1, uom2
        ssGrid.Row = ssGrid.ActiveRow
        ssGrid.Col = 1
        vUomRelat1 = ssGrid.Text
        ssGrid.Col = 2
        vUomRelat2 = ssGrid.Text
        ssql = "SELECT UOM1,UOM2 FROM UOMRelation WHERE UOM1 = '" & Trim(vUomRelat1) & "' AND UOM2 = '" & Trim(vUomRelat2) & "'"
        vconn.getDataSet(ssql, "UOM")
        If gdataset.Tables(0).Rows.Count <= 0 Then
            Exit Sub
        End If
        If ssGrid.ActiveCol = 6 Then
            If Trim(VUOM1) = Trim(uom1) And Trim(VUOM2) = Trim(uom2) Then
                ssGrid.Row = ssGrid.ActiveRow
                ssGrid.Col = 1
                uom1 = ssGrid.Text
                ssGrid.Col = 2
                uom2 = ssGrid.Text
                ssGrid.Col = 1
                VUOM1 = Trim(ssGrid.Text)
                If Trim(VUOM1) <> "" Then
                    gvalidate = True
                Else
                    gvalidate = False
                End If
                ssGrid.Col = 2
                VUOM2 = Trim(ssGrid.Text)
                If Trim(VUOM2) <> "" Then
                    gvalidate = True
                Else
                    gvalidate = False
                End If
                ssGrid.Col = 3
                VMes1 = Trim(ssGrid.Text)
                If Trim(VMes1) <> "" Then
                    gvalidate = True
                Else
                    gvalidate = False
                End If
                ssGrid.Col = 5
                VMes2 = Trim(ssGrid.Text)
                If Trim(VMes2) <> "" Then
                    gvalidate = True
                Else
                    gvalidate = False
                End If
                If gvalidate = True Then
                    ssql = "UPDATE UOMrelation SET UOM1 = '" & Trim(VUOM1) & "' , UOM2='" & Trim(VUOM2) & "'"
                    ssql = ssql & ",Ratio1='" & Trim(VMes1) & "',Ratio2='" & Trim(VMes2) & "' "
                    ssql = ssql & " WHERE uom1='" & Trim(vUomRelat1) & "' AND uom2 = '" & Trim(vUomRelat2) & "'"
                End If
            End If
        End If
    End Sub

    Private Sub SalesUOMRelation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
        End If
        If e.KeyCode = Keys.F7 Then
            Call Cmd_Add_Click(Cmd_Add, e)
        End If
        If e.KeyCode = Keys.F9 Then
            Cmd_View_Click(Cmd_View, e)
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
        End If
        If e.KeyCode = Keys.F3 Then
            ssGrid.Row = ssGrid.ActiveRow
            ssGrid.ClearRange(1, ssGrid.ActiveRow, 5, ssGrid.ActiveRow, True)
            ssGrid.DeleteRows(ssGrid.ActiveRow, 1)
            ssGrid.SetActiveCell(1, 1)
        End If
    End Sub

    Private Function Mevalidate() As Boolean
        Mevalidate = True
        For i = 1 To ssGrid.DataRowCnt
            ssGrid.Row = i
            ssGrid.Col = 1
            If ssGrid.Text = "" Then
                Mevalidate = False
                MsgBox("UOM1 Cann't be Blank", MsgBoxStyle.Information, MyCompanyName)
                ssGrid.Focus()
                Exit Function
            End If
            ssGrid.Col = 2
            If ssGrid.Text = "" Then
                Mevalidate = False
                MsgBox("UOM2 Cann't be Blank", MsgBoxStyle.Information, MyCompanyName)
                ssGrid.Focus()
                Exit Function
            End If
            ssGrid.Col = 3
            If ssGrid.Text = "" Then
                Mevalidate = False
                MsgBox("Measurment1 Cann't be Blank", MsgBoxStyle.Information, MyCompanyName)
                ssGrid.Focus()
                Exit Function
            End If
            ssGrid.Col = 5
            If ssGrid.Text = "" Then
                Mevalidate = False
                MsgBox("Measurment2 Cann't be Blank", MsgBoxStyle.Information, MyCompanyName)
                ssGrid.Focus()
                Exit Function
            End If
        Next
    End Function

    Private Sub SalesUOMRelation_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        UOMRelabool = False
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        ssGrid.ClearRange(1, 1, -1, -1, True)
        ssGrid.SetActiveCell(1, 1)
        Call FillGride()
        Cmd_Add.Text = "Add [F7]"
        Cmd_Freeze.Enabled = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim VUOM1, VUOM2, VMES1, VMES2, UOMVAL1, UOMVAL2 As String
        ssql = "SELECT * FROM UOMRELATION"
        vconn.getDataSet(ssql, "UOMRELATION")
        If gdataset.Tables("UOMRELATION").Rows.Count > 0 Then
            ssGrid.GetText(1, ssGrid.ActiveRow, VUOM1)
            ssGrid.GetText(2, ssGrid.ActiveRow, VUOM2)
            If Mevalidate() = False Then
                Exit Sub
            Else
                ssql = "DELETE FROM UOMRELATION"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = ssql
            End If
            For i = 1 To ssGrid.DataRowCnt
                ssql = "INSERT INTO UOMRELATION(UOM1,UOM2,Ratio1,Ratio2,AddUserId,Adddatetime) "
                ssGrid.Row = i
                ssGrid.Col = 1
                VUOM1 = ssGrid.Text
                ssql = ssql & " VALUES('" & Trim(VUOM1 & "") & "',"
                ssGrid.Col = 2
                VUOM2 = ssGrid.Text
                ssql = ssql & "'" & Trim(VUOM2 & "") & "',"
                ssGrid.Col = 3
                VMES1 = ssGrid.Text
                ssql = ssql & "'" & Trim(VMES1 & "") & "',"
                ssGrid.Col = 5
                VMES2 = ssGrid.Text
                ssql = ssql & "'" & Trim(VMES2 & "") & "',"
                ssql = ssql & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = ssql
            Next
        Else
            For i = 1 To ssGrid.DataRowCnt
                ssql = "INSERT INTO UOMRELATION(UOM1,UOM2,Ratio1,Ratio2,AddUserId,Adddatetime)  "
                ssGrid.Row = i
                ssGrid.Col = 1
                VUOM1 = ssGrid.Text
                ssql = ssql & " VALUES('" & Trim(VUOM1 & "") & "',"
                ssGrid.Col = 2
                VUOM2 = ssGrid.Text
                ssql = ssql & "'" & Trim(VUOM2 & "") & "',"
                ssGrid.Col = 3
                VMES1 = ssGrid.Text
                ssql = ssql & "'" & Trim(VMES1 & "") & "',"
                ssGrid.Col = 5
                VMES2 = ssGrid.Text
                ssql = ssql & "'" & Trim(VMES2 & "") & "',"
                ssql = ssql & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = ssql
            Next
        End If
        vconn.MORETRANSOLD(insert)
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM UOMRelation"
        Gheader = "SALES UOM RELATION VIEW "
        FrReport.SsGridReport.SetText(2, 1, "UOM1")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "UOM2")
        FrReport.SsGridReport.SetText(3, 2, 10)
        FrReport.SsGridReport.SetText(2, 2, "RATIO1")
        FrReport.SsGridReport.SetText(3, 2, 10)
        FrReport.SsGridReport.SetText(2, 2, "RATIO2")
        FrReport.SsGridReport.SetText(3, 2, 10)
        FrReport.Show()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
End Class
