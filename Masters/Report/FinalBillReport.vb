Public Class FinalBillReport
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
    Friend WithEvents lbl_Finalbill As System.Windows.Forms.Label
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Tobill As System.Windows.Forms.Label
    Friend WithEvents lbl_Frombill As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents txt_FromBill As System.Windows.Forms.TextBox
    Friend WithEvents txt_ToBill As System.Windows.Forms.TextBox
    Friend WithEvents grp_FinalbillRegister As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Cmd_ToBill As System.Windows.Forms.Button
    Friend WithEvents Cmd_FromBill As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FinalBillReport))
        Me.lbl_Finalbill = New System.Windows.Forms.Label
        Me.CmdClear = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmd_ToBill = New System.Windows.Forms.Button
        Me.Cmd_FromBill = New System.Windows.Forms.Button
        Me.txt_ToBill = New System.Windows.Forms.TextBox
        Me.txt_FromBill = New System.Windows.Forms.TextBox
        Me.lbl_Tobill = New System.Windows.Forms.Label
        Me.lbl_Frombill = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdView = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.grp_FinalbillRegister = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp_FinalbillRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Finalbill
        '
        Me.lbl_Finalbill.AutoSize = True
        Me.lbl_Finalbill.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Finalbill.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Finalbill.Location = New System.Drawing.Point(176, 16)
        Me.lbl_Finalbill.Name = "lbl_Finalbill"
        Me.lbl_Finalbill.Size = New System.Drawing.Size(225, 25)
        Me.lbl_Finalbill.TabIndex = 22
        Me.lbl_Finalbill.Text = "FINAL BILL REGISTER"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(32, 191)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 20
        Me.CmdClear.Text = "Clear[F6]"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Cmd_ToBill)
        Me.GroupBox1.Controls.Add(Me.Cmd_FromBill)
        Me.GroupBox1.Controls.Add(Me.txt_ToBill)
        Me.GroupBox1.Controls.Add(Me.txt_FromBill)
        Me.GroupBox1.Controls.Add(Me.lbl_Tobill)
        Me.GroupBox1.Controls.Add(Me.lbl_Frombill)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 113)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Cmd_ToBill
        '
        Me.Cmd_ToBill.Image = CType(resources.GetObject("Cmd_ToBill.Image"), System.Drawing.Image)
        Me.Cmd_ToBill.Location = New System.Drawing.Point(384, 72)
        Me.Cmd_ToBill.Name = "Cmd_ToBill"
        Me.Cmd_ToBill.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_ToBill.TabIndex = 39
        '
        'Cmd_FromBill
        '
        Me.Cmd_FromBill.Image = CType(resources.GetObject("Cmd_FromBill.Image"), System.Drawing.Image)
        Me.Cmd_FromBill.Location = New System.Drawing.Point(384, 24)
        Me.Cmd_FromBill.Name = "Cmd_FromBill"
        Me.Cmd_FromBill.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_FromBill.TabIndex = 38
        '
        'txt_ToBill
        '
        Me.txt_ToBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ToBill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToBill.Location = New System.Drawing.Point(160, 72)
        Me.txt_ToBill.Name = "txt_ToBill"
        Me.txt_ToBill.Size = New System.Drawing.Size(224, 26)
        Me.txt_ToBill.TabIndex = 5
        Me.txt_ToBill.Text = ""
        '
        'txt_FromBill
        '
        Me.txt_FromBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FromBill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromBill.Location = New System.Drawing.Point(160, 24)
        Me.txt_FromBill.Name = "txt_FromBill"
        Me.txt_FromBill.Size = New System.Drawing.Size(224, 26)
        Me.txt_FromBill.TabIndex = 4
        Me.txt_FromBill.Text = ""
        '
        'lbl_Tobill
        '
        Me.lbl_Tobill.AutoSize = True
        Me.lbl_Tobill.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tobill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tobill.Location = New System.Drawing.Point(88, 72)
        Me.lbl_Tobill.Name = "lbl_Tobill"
        Me.lbl_Tobill.Size = New System.Drawing.Size(64, 22)
        Me.lbl_Tobill.TabIndex = 3
        Me.lbl_Tobill.Text = "To Bill :"
        '
        'lbl_Frombill
        '
        Me.lbl_Frombill.AutoSize = True
        Me.lbl_Frombill.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Frombill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frombill.Location = New System.Drawing.Point(72, 24)
        Me.lbl_Frombill.Name = "lbl_Frombill"
        Me.lbl_Frombill.Size = New System.Drawing.Size(84, 22)
        Me.lbl_Frombill.TabIndex = 2
        Me.lbl_Frombill.Text = "From Bill :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Controls.Add(Me.CmdPrint)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(136, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 13
        Me.CmdView.Text = "View [F9]"
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Image = CType(resources.GetObject("CmdPrint.Image"), System.Drawing.Image)
        Me.CmdPrint.Location = New System.Drawing.Point(256, 16)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.CmdPrint.TabIndex = 14
        Me.CmdPrint.Text = " Print [F8]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(376, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 15
        Me.cmdexit.Text = "Exit[F11]"
        '
        'grp_FinalbillRegister
        '
        Me.grp_FinalbillRegister.BackgroundImage = CType(resources.GetObject("grp_FinalbillRegister.BackgroundImage"), System.Drawing.Image)
        Me.grp_FinalbillRegister.Controls.Add(Me.lbl_Wait)
        Me.grp_FinalbillRegister.Controls.Add(Me.ProgressBar1)
        Me.grp_FinalbillRegister.Location = New System.Drawing.Point(16, 1000)
        Me.grp_FinalbillRegister.Name = "grp_FinalbillRegister"
        Me.grp_FinalbillRegister.Size = New System.Drawing.Size(496, 80)
        Me.grp_FinalbillRegister.TabIndex = 23
        Me.grp_FinalbillRegister.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(256, 32)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 18)
        Me.lbl_Wait.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 24)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(464, 40)
        Me.ProgressBar1.TabIndex = 0
        '
        'Timer1
        '
        '
        'FinalBillReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(528, 246)
        Me.ControlBox = False
        Me.Controls.Add(Me.grp_FinalbillRegister)
        Me.Controls.Add(Me.lbl_Finalbill)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FinalBillReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FinalBillReport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grp_FinalbillRegister.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim chkbool As Boolean
    Dim gconnetion As New GlobalClass

    Private Sub FinalBillReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_FromBill.Text = ""
        txt_ToBill.Text = ""
        txt_FromBill.ReadOnly = False
        txt_ToBill.ReadOnly = False
        txt_FromBill.Focus()
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        txt_FromBill.Text = ""
        txt_ToBill.Text = ""
        txt_FromBill.ReadOnly = False
        txt_ToBill.ReadOnly = False
        txt_FromBill.Focus()
    End Sub
    Public Sub Validatedate()
        chkbool = False
        If Trim(txt_FromBill.Text) = "" Then
            MessageBox.Show("From Billno Can't be blank", "Calcutta Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_FromBill.Text = ""
            txt_FromBill.Focus()
            Exit Sub
        End If
        If Trim(txt_ToBill.Text) = "" Then
            MessageBox.Show("To Billno Can't be blank", "Calcutta Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_ToBill.Text = ""
            txt_ToBill.Focus()
            Exit Sub
        End If
        chkbool = True
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Call Validatedate() '''--> Check Validation
        If chkbool = False Then Exit Sub
        grp_FinalbillRegister.Top = 72
        grp_FinalbillRegister.Left = 8
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 100
        Me.Timer1.Enabled = True
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        gPrint = True
        Call CmdView_Click(sender, e)
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub
    Private Sub FinalBillRegister()
        Dim i As Integer
        Dim sqlstring As String
        Call Validatedate() '''--> Check Validation
        If chkbool = False Then Exit Sub
        sqlstring = "SELECT D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,B.MCODE,B.MNAME,B.PAYMENTMODE,"
        sqlstring = sqlstring & " D.RATE,B.SCODE,B.SNAME,D.AMOUNT,D.TAXTYPE,D.TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,"
        sqlstring = sqlstring & " ITEMTYPE,BILLDATE,BILLTIME  FROM KOT_DET D INNER JOIN BILL_HDR B ON B.BILLDETAILS = D.BILLDETAILS "
        sqlstring = sqlstring & " WHERE D.Billdetails  BETWEEN '" & Trim(txt_FromBill.Text) & "' AND '" & Trim(txt_ToBill.Text) & "' AND ISNULL(KotStatus,'N')='N' ORDER BY D.BillDetails "
        Dim ColumnHeading() As String = {"SLNo", "CODE", "ITEM DESCRIPTION", "QUANTITY", "RATE", "AMOUNT"}
        Dim ReportHeading() As String = {"THE CALCUTTA SWIMMING CLUB", "1,STRAND ROAD", "KOLKATTA-700001."}
        Dim ColumnSize() As Integer = {6, 6, 38, 11, 10, 7}
        Dim Objfinalbillregister As New finalbillregister
        Objfinalbillregister.begin()
        Objfinalbillregister.buttonclick(gconnetion.sqlconnection, sqlstring, ReportHeading, ColumnHeading, ColumnSize)
    End Sub

    Private Sub Cmd_FromBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FromBill.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT Billdetails,Convert(varchar, BillDate,100) FROM BILL_HDR"
        M_WhereCondition = ""
        vform.Field = " BILLDETAILS,BILLDATE "
        vform.vFormatstring = "                 BILL NO                    |                      BILLDATE               |"
        vform.vCaption = "BILL DETAILS HELP"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_FromBill.Text = Trim(vform.keyfield & "")
            Call txt_FromBill_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub Cmd_ToBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ToBill.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT Billdetails,Convert(varchar, BillDate,100) FROM BILL_HDR"
        M_WhereCondition = ""
        vform.Field = " BILLDETAILS,BILLDATE "
        vform.vFormatstring = "                 BILL NO                    |                      BILLDATE               |"
        vform.vCaption = "BILL DETAILS HELP"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_ToBill.Text = Trim(vform.keyfield & "")
            Call txt_ToBill_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_FromBill_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FromBill.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call txt_FromBill_Validated(sender, e)
        End If
    End Sub

    Private Sub txt_ToBill_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ToBill.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call txt_ToBill_Validated(sender, e)
        End If
    End Sub

    Private Sub txt_FromBill_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FromBill.Validated
        Dim j, i As Integer
        Dim sqlstring As String
        Dim dt As New DataTable
        If Trim(txt_FromBill.Text) <> "" Then
            Try
                sqlstring = "SELECT * FROM Bill_Hdr WHERE BillNo='" & Trim(txt_FromBill.Text) & "'OR Billdetails='" & Trim(txt_FromBill.Text) & "'"
                gconnetion.getDataSet(sqlstring, "Bill_Hdr")
                txt_FromBill.Text = Trim(gdataset.Tables("Bill_Hdr").Rows(0).Item("Billdetails") & "")
                txt_FromBill.ReadOnly = True
                txt_ToBill.Focus()
            Catch ex As Exception
                MessageBox.Show("Enter valid KOT No :" & ex.Message, "Calcutta Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txt_ToBill_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ToBill.Validated
        Dim j, i As Integer
        Dim sqlstring As String
        Dim dt As New DataTable
        If Trim(txt_ToBill.Text) <> "" Then
            Try
                sqlstring = "SELECT * FROM Bill_Hdr WHERE BillNo='" & Trim(txt_ToBill.Text) & "'OR Billdetails='" & Trim(txt_ToBill.Text) & "'"
                gconnetion.getDataSet(sqlstring, "Bill_Hdr")
                txt_ToBill.Text = Trim(gdataset.Tables("Bill_Hdr").Rows(0).Item("Billdetails") & "")
                txt_ToBill.ReadOnly = True
                CmdView.Focus()
            Catch ex As Exception
                MessageBox.Show("Enter valid KOT No :" & ex.Message, "Calcutta Swimming Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txt_FromBill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FromBill.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call Cmd_FromBill_Click(sender, e)
        End If
    End Sub

    Private Sub txt_ToBill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ToBill.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call Cmd_ToBill_Click(sender, e)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_FinalbillRegister.Top = 1000
            Call FinalBillRegister()
        End If
    End Sub
End Class
