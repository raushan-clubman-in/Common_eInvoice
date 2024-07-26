Imports System.IO
Public Class frmSelectivemanualbill
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
    Friend WithEvents grp_FinalbillRegister As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_Finalbill As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_ToKot As System.Windows.Forms.Button
    Friend WithEvents Cmd_FromKot As System.Windows.Forms.Button
    Friend WithEvents txt_ToKot As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromKot As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Tobill As System.Windows.Forms.Label
    Friend WithEvents lbl_Frombill As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSelectivemanualbill))
        Me.grp_FinalbillRegister = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lbl_Finalbill = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmd_ToKot = New System.Windows.Forms.Button
        Me.Cmd_FromKot = New System.Windows.Forms.Button
        Me.txt_ToKot = New System.Windows.Forms.TextBox
        Me.txt_FromKot = New System.Windows.Forms.TextBox
        Me.lbl_Tobill = New System.Windows.Forms.Label
        Me.lbl_Frombill = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grp_FinalbillRegister.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_FinalbillRegister
        '
        Me.grp_FinalbillRegister.BackgroundImage = CType(resources.GetObject("grp_FinalbillRegister.BackgroundImage"), System.Drawing.Image)
        Me.grp_FinalbillRegister.Controls.Add(Me.lbl_Wait)
        Me.grp_FinalbillRegister.Controls.Add(Me.ProgressBar1)
        Me.grp_FinalbillRegister.Location = New System.Drawing.Point(8, 80)
        Me.grp_FinalbillRegister.Name = "grp_FinalbillRegister"
        Me.grp_FinalbillRegister.Size = New System.Drawing.Size(496, 80)
        Me.grp_FinalbillRegister.TabIndex = 28
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
        'lbl_Finalbill
        '
        Me.lbl_Finalbill.AutoSize = True
        Me.lbl_Finalbill.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Finalbill.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Finalbill.Location = New System.Drawing.Point(80, 17)
        Me.lbl_Finalbill.Name = "lbl_Finalbill"
        Me.lbl_Finalbill.Size = New System.Drawing.Size(333, 25)
        Me.lbl_Finalbill.TabIndex = 27
        Me.lbl_Finalbill.Text = "SELECTIVE  BILL PRINT  REPORT"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Cmd_ToKot)
        Me.GroupBox1.Controls.Add(Me.Cmd_FromKot)
        Me.GroupBox1.Controls.Add(Me.txt_ToKot)
        Me.GroupBox1.Controls.Add(Me.txt_FromKot)
        Me.GroupBox1.Controls.Add(Me.lbl_Tobill)
        Me.GroupBox1.Controls.Add(Me.lbl_Frombill)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 113)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'Cmd_ToKot
        '
        Me.Cmd_ToKot.Image = CType(resources.GetObject("Cmd_ToKot.Image"), System.Drawing.Image)
        Me.Cmd_ToKot.Location = New System.Drawing.Point(384, 72)
        Me.Cmd_ToKot.Name = "Cmd_ToKot"
        Me.Cmd_ToKot.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ToKot.TabIndex = 3
        '
        'Cmd_FromKot
        '
        Me.Cmd_FromKot.Image = CType(resources.GetObject("Cmd_FromKot.Image"), System.Drawing.Image)
        Me.Cmd_FromKot.Location = New System.Drawing.Point(384, 24)
        Me.Cmd_FromKot.Name = "Cmd_FromKot"
        Me.Cmd_FromKot.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_FromKot.TabIndex = 1
        '
        'txt_ToKot
        '
        Me.txt_ToKot.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToKot.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToKot.Location = New System.Drawing.Point(160, 72)
        Me.txt_ToKot.Name = "txt_ToKot"
        Me.txt_ToKot.Size = New System.Drawing.Size(224, 29)
        Me.txt_ToKot.TabIndex = 2
        Me.txt_ToKot.Text = ""
        '
        'txt_FromKot
        '
        Me.txt_FromKot.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromKot.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromKot.Location = New System.Drawing.Point(160, 24)
        Me.txt_FromKot.Name = "txt_FromKot"
        Me.txt_FromKot.Size = New System.Drawing.Size(224, 29)
        Me.txt_FromKot.TabIndex = 0
        Me.txt_FromKot.Text = ""
        '
        'lbl_Tobill
        '
        Me.lbl_Tobill.AutoSize = True
        Me.lbl_Tobill.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tobill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tobill.Location = New System.Drawing.Point(65, 72)
        Me.lbl_Tobill.Name = "lbl_Tobill"
        Me.lbl_Tobill.Size = New System.Drawing.Size(83, 22)
        Me.lbl_Tobill.TabIndex = 3
        Me.lbl_Tobill.Text = "TO BILL :"
        '
        'lbl_Frombill
        '
        Me.lbl_Frombill.AutoSize = True
        Me.lbl_Frombill.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Frombill.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frombill.Location = New System.Drawing.Point(40, 24)
        Me.lbl_Frombill.Name = "lbl_Frombill"
        Me.lbl_Frombill.Size = New System.Drawing.Size(109, 22)
        Me.lbl_Frombill.TabIndex = 2
        Me.lbl_Frombill.Text = "FROM BILL :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdPrint)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
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
        Me.CmdPrint.TabIndex = 2
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
        Me.cmdexit.TabIndex = 3
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(16, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 0
        Me.CmdClear.Text = "Clear[F6]"
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
        Me.CmdView.TabIndex = 1
        Me.CmdView.Text = "View [F9]"
        '
        'Timer1
        '
        '
        'frmSelectivemanualbill
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(512, 262)
        Me.Controls.Add(Me.grp_FinalbillRegister)
        Me.Controls.Add(Me.lbl_Finalbill)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmSelectivemanualbill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECTIVE BILL PRINT"
        Me.grp_FinalbillRegister.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim sqlstring As String
    Dim chkbool As Boolean
    Private Sub Cmd_FromKot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FromKot.Click
        Try
            Dim vform As New ListOperattion1

            gSQLString = "SELECT ISNULL(KOTDETAILS,'') AS KOTDETAILS,CONVERT(VARCHAR(12), KOTDATE,100) FROM KOT_HDR "
            M_WhereCondition = " WHERE DOCTYPE <> 'SALE'"
            vform.Field = " KOTDETAILS,KOTDATE "
            vform.vFormatstring = "                 BILL NO                    |                      BILL DATE               |"
            vform.vCaption = "KOT DETAILS HELP"
            vform.KeyPos = 0
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_FromKot.Text = Trim(vform.keyfield & "")
                Call txt_FromKot_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub GetRights()
        Try
            Dim i, j, k, x As Integer
            Dim vmain, vsmod, vssmod As Long
            Dim ssql, SQLSTRING As String
            Dim M1 As New MainMenu
            Dim chstr As String
            SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='ACCOUNTS INTEGRATION' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
            gconnection.getDataSet(SQLSTRING, "USER")
            If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                    With gdataset.Tables("USER").Rows(i)
                        chstr = abcdMINUS(.Item("RIGHTS"))
                    End With
                Next
            End If
            Me.CmdView.Enabled = False
            Me.CmdPrint.Enabled = False
            'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
            If Len(chstr) > 0 Then
                Dim Right() As Char
                Right = chstr.ToCharArray
                For x = 0 To Right.Length - 1
                    If Right(x) = "A" Then
                        Me.CmdView.Enabled = True
                        Me.CmdPrint.Enabled = True
                        Exit Sub
                    End If
                    If Right(x) = "V" Then
                        Me.CmdView.Enabled = True
                        Me.CmdPrint.Enabled = True
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_ToKot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ToKot.Click
        Try
            Dim vform As New ListOperattion1
            gSQLString = "SELECT ISNULL(KOTDETAILS,'') AS KOTDETAILS,CONVERT(VARCHAR(12), KOTDATE,100) FROM KOT_HDR"
            M_WhereCondition = " WHERE DOCTYPE <> 'SALE'"
            vform.Field = " KOTDETAILS,KOTDATE "
            vform.vFormatstring = "                 BILL NO                    |                      BILL DATE               |"
            vform.vCaption = "KOT DETAILS HELP"
            vform.KeyPos = 0
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_ToKot.Text = Trim(vform.keyfield & "")
                Call txt_ToKot_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            txt_FromKot.Text = ""
            txt_ToKot.Text = ""
            txt_FromKot.ReadOnly = False
            txt_ToKot.ReadOnly = False
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            txt_FromKot.Focus()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            gPrint = False
            Call Validatedate()
            If chkbool = False Then Exit Sub
            grp_FinalbillRegister.Top = 80
            grp_FinalbillRegister.Left = 8
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            gPrint = True
            Call Validatedate()
            If chkbool = False Then Exit Sub
            grp_FinalbillRegister.Top = 80
            grp_FinalbillRegister.Left = 8
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
                Me.ProgressBar1.Value += 1
                Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
            Else
                Me.Timer1.Enabled = False
                Me.ProgressBar1.Value = 0
                Me.grp_FinalbillRegister.Top = 1000
                '            Call PrintOperation()
                Call BillPrintOperation_MCC()
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_FromKot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FromKot.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_FromKot.Text) = "" Then
                    Call Cmd_FromKot_Click(sender, e)
                Else
                    Call txt_FromKot_Validated(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_ToKot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ToKot.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_ToKot.Text) = "" Then
                    Call Cmd_ToKot_Click(sender, e)
                Else
                    Call txt_ToKot_Validated(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_FromKot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FromKot.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_FromKot.Enabled = True Then
                    Search = Trim(txt_FromKot.Text)
                    Call Cmd_FromKot_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_ToKot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ToKot.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_ToKot.Enabled = True Then
                    Search = Trim(txt_ToKot.Text)
                    Call Cmd_ToKot_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_FromKot_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FromKot.Validated
        Dim j, i As Integer
        Dim sqlstring As String
        Dim dt As New DataTable
        If Trim(txt_FromKot.Text) <> "" Then
            Try
                'Begin
                'sqlstring = "SELECT * FROM KOT_Hdr WHERE KOTNo='" & Trim(txt_FromKot.Text) & "' AND  DOCTYPE <> 'SALES'OR KOTdetails='" & Trim(txt_FromKot.Text) & "' AND  DOCTYPE <> 'SALES'"
                sqlstring = "SELECT * FROM KOT_Hdr WHERE (KOTNo='" & Format(Val(Trim(txt_FromKot.Text)), "000000") & "' OR KOTdetails='" & Trim(txt_FromKot.Text) & "') AND  DOCTYPE <> 'SALE'"
                'End
                gconnection.getDataSet(sqlstring, "KOT_Hdr")
                txt_FromKot.Text = Trim(gdataset.Tables("KOT_Hdr").Rows(0).Item("KOTdetails") & "")
                txt_FromKot.ReadOnly = True
                txt_ToKot.Focus()
            Catch ex As Exception
                MessageBox.Show("Enter valid KOT No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub txt_ToKot_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ToKot.Validated
        Dim j, i As Integer
        Dim sqlstring As String
        Dim dt As New DataTable
        If Trim(txt_ToKot.Text) <> "" Then
            Try
                'Begin
                'sqlstring = "SELECT * FROM Kot_Hdr WHERE KOTNo='" & Trim(txt_ToKot.Text) & "' AND  DOCTYPE <> 'SALES' OR KOTdetails='" & Trim(txt_ToKot.Text) & "' AND  DOCTYPE <> 'SALES'"
                sqlstring = "SELECT * FROM Kot_Hdr WHERE (KOTNo='" & Format(Val(Trim(txt_ToKot.Text)), "000000") & "' OR KOTdetails='" & Trim(txt_ToKot.Text) & "') AND  DOCTYPE <> 'SALE'"
                'End
                gconnection.getDataSet(sqlstring, "KOT_Hdr")
                txt_ToKot.Text = Trim(gdataset.Tables("KOT_Hdr").Rows(0).Item("KOTDETAILS") & "")
                txt_ToKot.ReadOnly = True
                CmdView.Focus()
            Catch ex As Exception
                MessageBox.Show("Enter valid KOT No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Public Sub Validatedate()
        Try
            chkbool = False
            If Trim(txt_FromKot.Text) = "" Then
                MessageBox.Show("From KOT No Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_FromKot.Text = ""
                txt_FromKot.Focus()
                Exit Sub
            End If
            If Trim(txt_ToKot.Text) = "" Then
                MessageBox.Show("To KOT No Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_ToKot.Text = ""
                txt_ToKot.Focus()
                Exit Sub
            End If
            chkbool = True
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Public Sub BillPrintOperation_MCC()
        Try
            Randomize()
            Dim vOutfile, vheader, vFilepath, vline, Kot, Bill, amtword, paymentmode, rupeesword, REMARKS As String
            Dim ssql, vCaption, vPath, str, Sqlstring, billdetails, Fsize(), Forder(), Round, Roundedvalue(), Rowprint As String
            Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, Taxpercentage, RoundOff1 As Double
            Dim Loopindex, i, Fo, in1, CountItem, rowj As Integer
            Dim Vrowcount, vpagenumber As Long
            Dim Filewrite As StreamWriter
            gCompanyname = MyCompanyName
            gCompanyname = gShortName
            gCompanyAddress(0) = Address1
            gCompanyAddress(1) = Address2
            Gheader = " V O U C H E R "
            vpagenumber = 1
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
            Sqlstring = " SELECT ISNULL(D.KOTNO,'') AS KOTNO,ISNULL(D.BILLDETAILS,'') AS BILLDETAILS,ISNULL(D.KOTDETAILS,'') AS KOTDETAILS, "
            Sqlstring = Sqlstring & " D.KOTDATE AS KOTDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE,ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(D.POSCODE,'') AS POSCODE,"
            Sqlstring = Sqlstring & " ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(D.TAXTYPE,'') AS TAXTYPE, ISNULL(D.TAXPERC,0) AS TAXPERC,"
            Sqlstring = Sqlstring & " ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXAMOUNT,0) AS TAXAMOUNT,ISNULL(D.ITEMTYPE,'') AS ITEMTYPE,ISNULL(H.MCODE,'') AS MCODE,"
            Sqlstring = Sqlstring & " ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.STCODE,'') AS STCODE,ISNULL(H.SERVERNAME,'') AS SERVERNAME,ISNULL(H.PAYMENTTYPE,'') AS PAYMENTTYPE,ISNULL(H.GUEST,'') AS GUEST,"
            Sqlstring = Sqlstring & " ISNULL(H.ROOMNO,'') AS ROOMNO,ISNULL(H.DISCOUNTAMT,0) AS DISCOUNTAMT,ISNULL(H.PACKAMT,0) AS PACKAMOUNT,ISNULL(H.TOTAL,0) AS TOTAL,ISNULL(H.TOTALTAX,0) AS TOTALTAX,"
            Sqlstring = Sqlstring & " ISNULL(H.BILLAMOUNT,0) AS BILLAMOUNT,ISNULL(H.ROUNDOFF,0) AS ROUNDOFF,ISNULL(H.ADDUSERID,'') AS ADDUSERID,ISNULL(H.REMARKS,'') AS REMARKS,H.ADDDATETIME AS ADDDATETIME,"
            Sqlstring = Sqlstring & " ISNULL(H.DELFLAG,'') AS DELFLAG FROM KOT_HDR AS H INNER JOIN KOT_DET AS D ON H.KOTDETAILS = D.KOTDETAILS "
            Sqlstring = Sqlstring & " WHERE BILLDETAILS BETWEEN '" & Trim(txt_FromKot.Text) & "' AND '" & Trim(txt_ToKot.Text) & "' ORDER BY BILLDETAILS,ITEMCODE"
            gconnection.getDataSet(Sqlstring, "Manualbilldetails")
            If gdataset.Tables("Manualbilldetails").Rows.Count > 0 Then
                Filewrite = File.AppendText(vFilepath)

                vline = "" : Kot = "" : Bill = "" : Taxpercentage = 0
                For rowj = 0 To gdataset.Tables("Manualbilldetails").Rows.Count - 1
                    Bill = Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("BILLDETAILS"))
                    Taxpercentage = Val(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("TAXPERC"))

                    billdetails = "'" & Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("BILLDETAILS")) & "'"
                    paymentmode = Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE"))
                    REMARKS = Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("REMARKS"))

                    CountItem = CountItem + 1
                    If Trim(Bill) <> Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("BillDetails")) Then
                        If Vrowcount <= 17 Then
                            For i = 1 To 17 - Vrowcount
                                Filewrite.WriteLine("")
                            Next
                        End If
                        Vrowcount = 0
                        If gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "ROOM" Then
                            Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                            Rowprint = Rowprint & " : " & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("GUEST") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("ROOMNO") & "]"
                        ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "R.MEMBER" Then
                            Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                            Rowprint = Rowprint & " : " & "RECIPROCAL MEMBER"
                        ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "PENDING" Then
                            Rowprint = "MEMEBER NAME :"
                            Rowprint = Rowprint & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]"
                        Else
                            Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                            Rowprint = Rowprint & ":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]"
                        End If

                        If Len(Rowprint) < 45 Then
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                            Filewrite.WriteLine()
                        Else
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                        End If
                        Vrowcount = Vrowcount + 2

                        Filewrite.WriteLine("{0,-40}{1,10}", "", StrDup(10, "-"))
                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine("{0,-40}{1,10}", "", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")), "0.00"))
                        Vrowcount = Vrowcount + 1
                        Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("TAXCODE")) & "' "
                        gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
                        If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                            Sqlstring = "SELECT ISNULL(DATAFILE,'') FROM MASTER..CLUBMASTER WHERE DATAFILE = '" & gDatabase & "'"
                            gconnection.getDataSet(Sqlstring, "CLUBMASTER")
                            If gdataset.Tables("CLUBMASTER").Rows.Count > 0 Then
                                Filewrite.Write("{0,-12}{1,28}", "PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                                Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                            Else
                                Filewrite.Write("{0,-2}{1,38}", "", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                                Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                            End If
                            Vrowcount = Vrowcount + 1
                        End If
                        If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")) > 0 Then
                            Filewrite.Write("{0,40}", "                PACKING CHARGES @ 10%:")
                            Filewrite.WriteLine("{0,10}", Format((Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))), "0.00"))
                            Vrowcount = Vrowcount + 1
                        End If
                        If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")) > 0 Then
                            Filewrite.Write("{0,40}", "                 DISCOUNT PERCENTAGE :")
                            Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                            Vrowcount = Vrowcount + 1
                        End If
                        Filewrite.WriteLine("{0,-50}", "")
                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine("{0,-40}{1,10}", "", StrDup(10, "-"))
                        Vrowcount = Vrowcount + 1
                        Filewrite.Write("{0,-21}{1,19}", "", "TOTAL :")
                        Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))), "0.00"))
                        Vrowcount = Vrowcount + 1
                        If gRoundOffFlag = True Then
                            RoundOff = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")))

                            Round = CStr(RoundOff)

                            RoundOff1 = Mid(Format(Val(RoundOff), "0.00"), Len(Format(Val(RoundOff), "0.00")) - 1, Len(Format(Val(RoundOff), "0.00")))
                            If Format(Val(RoundOff1), "00") = 50 Then
                                RoundOff = Math.Ceiling(RoundOff)
                            ElseIf Format(Val(RoundOff1), "00") > 50 Then
                                RoundOff = Math.Ceiling(RoundOff)
                            Else
                                RoundOff = Math.Floor(RoundOff)
                            End If
                            If Val(RoundOff) > Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))) Then
                                RoundDiff = RoundOff - (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")))
                                Filewrite.Write("{0,-21}{1,-19}", "", "ROUNDED OFF(+):")
                            Else
                                RoundDiff = (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))) - RoundOff
                                Filewrite.Write("{0,-21}{1,-19}", "", "ROUNDED OFF(-):")
                            End If
                            Filewrite.WriteLine("{0,10}", Format(Val(RoundDiff), "0.00"))
                            Vrowcount = Vrowcount + 1
                        Else
                            RoundOff = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")))

                            Round = CStr(RoundOff)

                            RoundOff1 = Mid(Format(Val(RoundOff), "0.00"), Len(Format(Val(RoundOff), "0.00")) - 1, Len(Format(Val(RoundOff), "0.00")))
                            If Format(Val(RoundOff1), "00") = 50 Then
                                RoundOff = Math.Ceiling(RoundOff)
                            ElseIf Format(Val(RoundOff1), "00") > 50 Then
                                RoundOff = Math.Ceiling(RoundOff)
                            Else
                                RoundOff = Math.Floor(RoundOff)
                            End If
                            If Val(RoundOff) > Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))) Then
                                RoundDiff = RoundOff - (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")))
                            Else
                                RoundDiff = (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))) - RoundOff
                            End If
                        End If

                        Filewrite.WriteLine(StrDup(50, "-"))
                        Vrowcount = Vrowcount + 1
                        rupeesword = ConvertRupees(Format(IIf(gRoundOffFlag = True, Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))), Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))), "0.00"))
                        Filewrite.Write("{0,-50}", Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 50))

                        Rowprint = Chr(18) & Chr(27) + "E" & Format(IIf(gRoundOffFlag = True, Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00") & Chr(27) + "F" & Chr(15)
                        Filewrite.WriteLine("{0,-10}", Rowprint)

                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine(StrDup(50, "-"))
                        Vrowcount = Vrowcount + 1
                        Filewrite.Write("{0,-5}{1,-15}", "USER:", Mid(UCase(gUsername), 1, 15))
                        Filewrite.WriteLine("{0,30}", Mid(MyCompanyName, 1, 30))
                        Vrowcount = Vrowcount + 1

                        If Trim(REMARKS) <> "" Then
                            If Len(Trim(REMARKS)) < 65 Then
                                Filewrite.WriteLine("Remarks : " & Trim(REMARKS))
                                Vrowcount = Vrowcount + 1
                            Else
                                Filewrite.WriteLine("Remarks : " & Mid(Trim(REMARKS), 1, 50))
                                Filewrite.WriteLine("          " & Mid(Trim(REMARKS), 51, 50))
                                Vrowcount = Vrowcount + 2
                            End If
                        End If
                        If Vrowcount <= 24 Then
                            For i = 1 To 24 - Vrowcount
                                Filewrite.WriteLine("")
                            Next
                        End If

                        Kot = ""
                        Bill = gdataset.Tables("ReportTable").Rows(rowj).Item("BILLDETAILS")
                        Taxpercentage = Val(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("TAXPERC"))
                        TotalAmount = 0 : TaxAmount = 0 : Vrowcount = 0 : CountItem = 1
                    End If
                    If Kot <> gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTNO") Then
                        If Trim(Kot) <> "" Then
                            Kot = Kot & "," & gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTNO")
                        Else
                            Kot = gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTNO")
                        End If
                    End If
                    If (Vrowcount = 0 Or Vrowcount >= 17) Then
                        If Vrowcount >= 17 Then
                            Vrowcount = 0
                            If gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "ROOM" Then
                                Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                                Rowprint = Rowprint & " : " & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("GUEST") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("ROOMNO") & "]"
                            ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "R.MEMBER" Then
                                Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                                Rowprint = Rowprint & " : " & "RECIPROCAL MEMBER"
                            ElseIf gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE") = "PENDING" Then
                                Rowprint = "MEMEBER NAME :"
                                Rowprint = Rowprint & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]"
                            Else
                                Rowprint = gdataset.Tables("Manualbilldetails").Rows(rowj).Item("PAYMENTTYPE")
                                Rowprint = Rowprint & ":" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(rowj).Item("MCODE") & "]"
                                If Len(Rowprint) < 45 Then
                                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                                    Filewrite.WriteLine()
                                Else
                                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                                End If
                                Vrowcount = Vrowcount + 2
                            End If


                            Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("Manualbilldetails").Rows(rowj).Item("TAXCODE")) & "' "
                            gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
                            If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                                Sqlstring = "SELECT ISNULL(DATAFILE,'') FROM MASTER..CLUBMASTER WHERE DATAFILE = '" & gDatabase & "'"
                                gconnection.getDataSet(Sqlstring, "CLUBMASTER")
                                If gdataset.Tables("CLUBMASTER").Rows.Count > 0 Then
                                    Filewrite.Write("{0,-12}{1,28}", "PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                                    Filewrite.WriteLine("{0,-10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                                Else
                                    Filewrite.WriteLine("")
                                End If
                                Filewrite.WriteLine("")
                                Vrowcount = Vrowcount + 1
                            End If
                            If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")) > 0 Then
                                Filewrite.Write("{0,40}", "             PACKING CHARGES @ 10.2% :")
                                Filewrite.WriteLine("{0,-10}", Format((Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))), "0.00"))
                                Filewrite.WriteLine("")
                                Vrowcount = Vrowcount + 1
                            End If
                            If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")) > 0 Then
                                Filewrite.Write("{0,40}", "                 DISCOUNT PERCENTAGE :")
                                Filewrite.WriteLine("{0,-10}", Mid(Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                                Filewrite.WriteLine("")
                                Vrowcount = Vrowcount + 1
                            End If
                            Filewrite.WriteLine("")
                            Vrowcount = Vrowcount + 1

                            Filewrite.WriteLine("")
                            Vrowcount = Vrowcount + 1

                            Filewrite.WriteLine("")
                            Vrowcount = Vrowcount + 1
                            RoundOff = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")))
                            Round = CStr(RoundOff)

                            RoundOff1 = Mid(Format(Val(RoundOff), "0.00"), Len(Format(Val(RoundOff), "0.00")) - 1, Len(Format(Val(RoundOff), "0.00")))
                            If Format(Val(RoundOff1), "00") = 50 Then
                                RoundOff = Math.Ceiling(RoundOff)
                            ElseIf Format(Val(RoundOff1), "00") > 50 Then
                                RoundOff = Math.Ceiling(RoundOff)
                            Else
                                RoundOff = Math.Floor(RoundOff)
                            End If
                            If Val(RoundOff) > Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))) Then
                                RoundDiff = RoundOff - (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")))
                            Else
                                RoundDiff = (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))) - RoundOff
                            End If
                            Filewrite.WriteLine("")
                            Vrowcount = Vrowcount + 1
                            Filewrite.WriteLine("")
                            Vrowcount = Vrowcount + 1
                            Filewrite.WriteLine("")
                            Vrowcount = Vrowcount + 1
                            Filewrite.WriteLine("")
                            Vrowcount = Vrowcount + 1
                            Filewrite.Write("{0,-5}{1,-15}", "USER:", Mid(UCase(gUsername), 1, 15))
                            Filewrite.WriteLine("{0,-30}", Mid(MyCompanyName, 1, 30))
                            Vrowcount = Vrowcount + 1
                            'Filewrite.WriteLine("{0,-14}{1,-20}", "REMARKS :   ", Mid(gdataset.Tables("Manualbilldetails").Rows(0).Item("REMARKS"), 1, 20))
                            If Trim(REMARKS) <> "" Then
                                If Len(Trim(REMARKS)) < 50 Then
                                    Filewrite.WriteLine("Remarks : " & Trim(REMARKS))
                                    Vrowcount = Vrowcount + 1
                                Else
                                    Filewrite.WriteLine("Remarks : " & Mid(Trim(REMARKS), 1, 50))
                                    Filewrite.WriteLine("          " & Mid(Trim(REMARKS), 51, 50))
                                    Vrowcount = Vrowcount + 2
                                End If
                            End If
                            'Vrowcount = Vrowcount + 1

                            Filewrite.WriteLine("")
                            Filewrite.WriteLine(Space(40) & "Continued....")
                            Vrowcount = Vrowcount + 2

                            If Vrowcount <= 24 Then
                                For i = 1 To 24 - Vrowcount
                                    Filewrite.WriteLine("")
                                Next
                            End If
                            'End
                        End If

                        Vrowcount = 0
                        Sqlstring = "SELECT ISNULL(BillPrintHeader,'') AS BillPrintHeader FROM POSSETUP"
                        gconnection.getDataSet(Sqlstring, "POSSETUP")
                        If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                            If Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPrintHeader")) = "YES" Then
                                vheader = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Chr(27) & "E" & gCompanyname & Chr(27) & "F" & Chr(20) & Chr(27) & Chr(72)
                                Filewrite.WriteLine(vheader)
                                vheader = Space(13) & gCompanyAddress(0)
                                Filewrite.WriteLine(vheader)
                                vheader = Space(13) & gCompanyAddress(1)
                                Filewrite.WriteLine(vheader)
                                Vrowcount = 3
                            End If
                        End If
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        If gdataset.Tables("Manualbilldetails").Rows(0).Item("DELFLAG") <> "Y" Then
                            vheader = Chr(14) & Chr(15) & Space((20 / 2) - (Len(Gheader) / 2)) & Gheader
                        Else
                            vheader = Chr(14) & Chr(15) & Space((20 / 2) - (Len(Gheader) / 2)) & " V O U C H E R [D E L E T E D]"
                        End If
                        Filewrite.WriteLine("")
                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine(vheader)
                        Vrowcount = Vrowcount + 1

                        Filewrite.Write("{0,-11}{1,-18}{2,-6}", Mid("BILL   NO:", 1, 10), Mid(Bill, 1, 18), "")
                        Filewrite.WriteLine("{0,-5}{1,-10}", "TIME:", Format(gdataset.Tables("Manualbilldetails").Rows(0).Item("ADDDATETIME"), "HH:mm:ss"))
                        Vrowcount = Vrowcount + 1
                        Filewrite.Write("{0,-10}{1,-24}{2,-1}", Mid("SERVER NO:", 1, 10), Mid(CStr(gdataset.Tables("Manualbilldetails").Rows(0).Item("SERVERNAME")) & "   [" & CStr(gdataset.Tables("Manualbilldetails").Rows(0).Item("STCODE")) & "]", 1, 24), "")
                        Filewrite.WriteLine("{0,-5}{1,-10}", "DATE:", Format(CDate(gdataset.Tables("Manualbilldetails").Rows(0).Item("KOTDATE")), "dd/MM/yyyy"))
                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine(StrDup(50, "-"))
                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine("{0,-4}{1,-20}{2,-6}{3,3}{4,7}{5,10}", "SLNO", "ITEM DESCRIPTION", "QTY", "UOM", "RATE", "AMOUNT")
                        Vrowcount = Vrowcount + 1
                        Filewrite.WriteLine(StrDup(50, "-"))
                        Vrowcount = Vrowcount + 1
                    End If
                    With gdataset.Tables("Manualbilldetails").Rows(rowj)
                        Filewrite.Write("{0,-4}", Mid(CountItem & ".", 1, 4))
                        Filewrite.Write("{0,-20}{1,-6}{2,-3}", Mid(Trim(.Item("ITEMDESC")) & Trim("...................."), 1, 20), Mid(Format(Val(.Item("QTY")), "0.00"), 1, 6), Mid(Trim(.Item("UOM")), 1, 3))
                        Filewrite.WriteLine("{0,7}{1,10}", Mid(Format(Val(.Item("RATE")), "0.00"), 1, 7), Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                        TotalAmount = TotalAmount + Val(.Item("Amount"))
                        TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                        Vrowcount = Vrowcount + 1
                    End With
                Next rowj
                If Vrowcount <= 17 Then
                    For i = 1 To 17 - Vrowcount
                        Filewrite.WriteLine("")
                    Next
                End If
                Vrowcount = 0
                If gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "ROOM" Then
                    Rowprint = gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE")
                    Rowprint = Rowprint & " : " & gdataset.Tables("Manualbilldetails").Rows(0).Item("GUEST") & " [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("ROOMNO") & "]"
                ElseIf gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "R.MEMBER" Then
                    Rowprint = gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE")
                    Rowprint = Rowprint & " : " & "RECIPROCAL MEMBER"
                ElseIf gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE") = "PENDING" Then
                    Rowprint = "MEMEBER NAME :"
                    Rowprint = Rowprint & gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]"
                Else
                    Rowprint = gdataset.Tables("Manualbilldetails").Rows(0).Item("PAYMENTTYPE")
                    Rowprint = Rowprint & ":" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MNAME") & " [" & gdataset.Tables("Manualbilldetails").Rows(0).Item("MCODE") & "]"
                    If Len(Rowprint) < 45 Then
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine()
                    Else
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                        Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                    End If
                End If



                Vrowcount = Vrowcount + 2
                Filewrite.WriteLine("{0,-40}{1,-10}", "", StrDup(10, "-"))
                Vrowcount = Vrowcount + 1
                Filewrite.WriteLine("{0,-40}{1,10}", "", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")), "0.00"))
                Vrowcount = Vrowcount + 1
                Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("Manualbilldetails").Rows(0).Item("TAXCODE")) & "' "
                gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
                If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                    Filewrite.Write("{0,-12}{1,28}", "PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                    Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")), "0.00"))
                    Vrowcount = Vrowcount + 1
                End If
                If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")) > 0 Then
                    Filewrite.Write("{0,40}", "             PACKING CHARGES @ 10.2% :")
                    Filewrite.WriteLine("{0,10}", Format((Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))), "0.00"))
                    Vrowcount = Vrowcount + 1
                End If
                If Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")) > 0 Then
                    Filewrite.Write("{0,40}", "                 DISCOUNT PERCENTAGE :")
                    Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                    Vrowcount = Vrowcount + 1
                End If
                Filewrite.WriteLine("{0,-50}", "")
                Vrowcount = Vrowcount + 1
                Filewrite.WriteLine("{0,-40}{1,10}", "", StrDup(10, "-"))
                Vrowcount = Vrowcount + 1
                Filewrite.Write("{0,-21}{1,19}", "", "TOTAL :")
                Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))), "0.00"))
                Vrowcount = Vrowcount + 1

                If gRoundOffFlag = True Then
                    RoundOff = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")))
                    Round = CStr(RoundOff)
                    RoundOff1 = Mid(Format(Val(RoundOff), "0.00"), Len(Format(Val(RoundOff), "0.00")) - 1, Len(Format(Val(RoundOff), "0.00")))
                    If Format(Val(RoundOff1), "00") = 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    ElseIf Format(Val(RoundOff1), "00") > 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    Else
                        RoundOff = Math.Floor(RoundOff)
                    End If

                    If Val(RoundOff) > Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))) Then
                        RoundDiff = RoundOff - (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")))

                        Filewrite.Write("{0,-20}{1,20}", "", "ROUNDED OFF(+):")
                    Else
                        RoundDiff = (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))) - RoundOff
                        Filewrite.Write("{0,-20}{1,20}", "", "ROUNDED OFF(-):")
                    End If
                    Filewrite.WriteLine("{0,10}", Format(Val(RoundDiff), "0.00"))
                    Vrowcount = Vrowcount + 1
                Else
                    RoundOff = Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")))
                    Round = CStr(RoundOff)
                    RoundOff1 = Mid(Format(Val(RoundOff), "0.00"), Len(Format(Val(RoundOff), "0.00")) - 1, Len(Format(Val(RoundOff), "0.00")))
                    If Format(Val(RoundOff1), "00") = 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    ElseIf Format(Val(RoundOff1), "00") > 50 Then
                        RoundOff = Math.Ceiling(RoundOff)
                    Else
                        RoundOff = Math.Floor(RoundOff)
                    End If

                    If Val(RoundOff) > Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))) Then
                        RoundDiff = RoundOff - (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT")))

                        '    Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(+):")
                    Else
                        RoundDiff = (Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))) - RoundOff
                        ' Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(-):")
                    End If
                    '  Filewrite.WriteLine("{0,10}", Format(Val(RoundDiff), "0.00"))
                    '  Vrowcount = Vrowcount + 1
                End If

                Filewrite.WriteLine(StrDup(50, "-"))
                Vrowcount = Vrowcount + 1
                rupeesword = ConvertRupees(Format(IIf(gRoundOffFlag = True, Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))), Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("PACKAMOUNT"))), "0.00"))
                Filewrite.Write("{0,-50}", Mid(Trim("RUPEES " & rupeesword & " ONLY."), 1, 69))
                'Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00"))
                Rowprint = Chr(18) & Chr(27) + "E" & Format(IIf(gRoundOffFlag = True, Math.Round(Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), Val(gdataset.Tables("Manualbilldetails").Rows(0).Item("BILLAMOUNT"))), "0.00") & Chr(27) + "F" & Chr(15)
                Filewrite.WriteLine("{0,10}", Rowprint)
                Vrowcount = Vrowcount + 1
                Filewrite.WriteLine(StrDup(50, "-"))
                Vrowcount = Vrowcount + 1
                Filewrite.Write("{0,-5}{1,-15}", "USER:", Mid(UCase(gUsername), 1, 15))
                Filewrite.WriteLine("{0,30}", Mid(MyCompanyName, 1, 30))
                Vrowcount = Vrowcount + 1

                If Trim(REMARKS) <> "" Then
                    If Len(Trim(REMARKS)) < 50 Then
                        Filewrite.WriteLine("Remarks : " & Trim(REMARKS))
                        Vrowcount = Vrowcount + 1
                    Else
                        Filewrite.WriteLine("Remarks : " & Mid(Trim(REMARKS), 1, 50))
                        Filewrite.WriteLine("          " & Mid(Trim(REMARKS), 51, 50))
                        Vrowcount = Vrowcount + 2
                    End If
                End If

                If Vrowcount <= 24 Then
                    For i = 1 To 24 - Vrowcount
                        Filewrite.WriteLine("")
                    Next
                End If

                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(vFilepath)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Function ConvertRupees(ByVal Value As Double) As String
        Try
            Dim strText, TempString, TxtArray(5) As String
            Dim locNumber, AbsValue, DecimalValue, NumArray(5), Remain, Loopindex As Double
            NumArray(0) = 7
            NumArray(1) = 5
            NumArray(2) = 3
            NumArray(3) = 2
            TxtArray(0) = " CRORE"
            TxtArray(1) = " LAKH(S)"
            TxtArray(2) = " THOUSAND"
            TxtArray(3) = " HUNDRED"
            AbsValue = Value
            For Loopindex = 0 To 3
                locNumber = (AbsValue - (AbsValue Mod (10 ^ NumArray(Loopindex)))) / (10 ^ NumArray(Loopindex))
                If locNumber > 99 Then
                    strText = strText & ConvertRupees(locNumber) & TxtArray(Loopindex)
                    AbsValue = AbsValue - (locNumber * (10 ^ NumArray(Loopindex)))
                Else
                    If locNumber <> 0 Then
                        If locNumber > 19 Then
                            strText = strText & NumValString(((locNumber - (locNumber Mod 10)) / 10) * 10) & NumValString(locNumber Mod 10) & TxtArray(Loopindex)
                        Else
                            strText = strText & NumValString(locNumber) & TxtArray(Loopindex)
                        End If
                        AbsValue = AbsValue - (locNumber * (10 ^ NumArray(Loopindex)))
                    End If
                End If
            Next Loopindex
            If AbsValue <> 0 Then
                If AbsValue > 19 Then
                    strText = strText & NumValString(((AbsValue - (AbsValue Mod 10)) / 10) * 10) & NumValString(AbsValue Mod 10) & TxtArray(Loopindex)
                Else
                    strText = strText & NumValString(AbsValue)
                End If
            End If
            ConvertRupees = strText
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Function NumValString(ByVal Value As Double)
        Try
            Select Case Value
                Case 1
                    NumValString = " ONE"
                Case 2
                    NumValString = " TWO"
                Case 3
                    NumValString = " THREE"
                Case 4
                    NumValString = " FOUR"
                Case 5
                    NumValString = " FIVE"
                Case 6
                    NumValString = " SIX"
                Case 7
                    NumValString = " SEVEN"
                Case 8
                    NumValString = " EIGHT"
                Case 9
                    NumValString = " NINE"
                Case 10
                    NumValString = " TEN"
                Case 11
                    NumValString = " ELEVEN"
                Case 12
                    NumValString = " TWELVE"
                Case 13
                    NumValString = " THIRTEEN"
                Case 14
                    NumValString = " FOURTEEN"
                Case 15
                    NumValString = " FIFTEEN"
                Case 16
                    NumValString = " SIXTEEN"
                Case 17
                    NumValString = " SEVENTEEN"
                Case 18
                    NumValString = " EIGHTEEN"
                Case 19
                    NumValString = " NINETEEN"
                Case 20
                    NumValString = " TWENTY"
                Case 30
                    NumValString = " THIRTY"
                Case 40
                    NumValString = " FOURTY"
                Case 50
                    NumValString = " FIFTY"
                Case 60
                    NumValString = " SIXTY"
                Case 70
                    NumValString = " SEVENTY"
                Case 80
                    NumValString = " EIGHTY"
                Case 90
                    NumValString = " NINETY"
                Case Else
                    NumValString = ""
            End Select
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function


    Public Sub PrintOperation()
        Try
            Dim i As Integer
            Dim sqlstring As String
            Call Validatedate() '''--> Check Validation
            If chkbool = False Then Exit Sub
            sqlstring = " SELECT ISNULL(D.BILLDETAILS,'') AS BILLDETAILS,ISNULL(D.KOTNO,'') AS KOTNO,ISNULL(D.KOTDETAILS,'') AS KOTDETAILS,"
            sqlstring = sqlstring & " D.KOTDATE AS KOTDATE,ISNULL(D.ITEMCODE,'') AS ITEMCODE,ISNULL(D.ITEMDESC,'') AS ITEMDESC,ISNULL(D.POSCODE,'') AS POSCODE,"
            sqlstring = sqlstring & " ISNULL(D.UOM,'') AS UOM,ISNULL(D.QTY,0) AS QTY,ISNULL(D.RATE,0) AS RATE,ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(D.TAXTYPE,'') AS TAXTYPE,"
            sqlstring = sqlstring & " ISNULL(D.TAXPERC,0) AS TAXPERC,ISNULL(D.TAXCODE,'') AS TAXCODE,ISNULL(D.TAXAMOUNT,0) AS TAXAMOUNT,ISNULL(D.ITEMTYPE,'') AS ITEMTYPE,"
            sqlstring = sqlstring & " ISNULL(H.MCODE,'') AS MCODE,ISNULL(H.MNAME,'') AS MNAME,ISNULL(H.STCODE,'') AS STCODE,ISNULL(H.SERVERNAME,'') AS SERVERNAME,"
            sqlstring = sqlstring & " ISNULL(H.TOTALTAX,0) AS TOTALTAX,ISNULL(H.GUEST,'') AS GUEST,ISNULL(H.PAYMENTTYPE,'') AS PAYMENTTYPE,ISNULL(H.ROOMNO,'') AS ROOMNO,"
            sqlstring = sqlstring & " ISNULL(H.DISCOUNTAMT,0) AS DISCOUNTAMT,ISNULL(H.PACKAMT,0) AS PACKAMT,ISNULL(H.TOTAL,0) AS TOTAL,ISNULL(H.BILLAMOUNT,0) AS BILLAMOUNT,"
            sqlstring = sqlstring & " ISNULL(H.ADDUSERID,'') AS ADDUSERID,ISNULL(H.REMARKS,'') AS REMARKS,H.ADDDATETIME AS ADDDATETIME,ISNULL(H.DELFLAG,'') AS DELFLAG,ISNULL(H.ROUNDOFF,0) AS ROUNDOFF FROM KOT_HDR AS H INNER JOIN KOT_DET AS D ON H.KOTDETAILS = D.KOTDETAILS"
            sqlstring = sqlstring & " WHERE D.BILLDETAILS  BETWEEN '" & Trim(txt_FromKot.Text) & "' AND '" & Trim(txt_ToKot.Text) & "' AND ISNULL(D.KOTSTATUS,'N')='N' AND DOCTYPE<>'SALE' ORDER BY BILLDETAILS "
            Dim ColumnHeading() As String = {"SLNo", "CODE", "ITEM DESCRIPTION", "QTY", "UOM", "RATE", "AMOUNT"}
            Dim ReportHeading() As String = {MyCompanyName, Address1, Address2}
            Dim ColumnSize() As Integer = {6, 6, 35, 12, 10, 10}
            Dim ObjManualbillregister As New finalbillregister
            ObjManualbillregister.ReportDetails(sqlstring, ReportHeading, ColumnHeading, ColumnSize)
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub


    Private Sub frmSelectivemanualbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txt_FromKot.Text = ""
            txt_ToKot.Text = ""
            txt_FromKot.ReadOnly = False
            txt_ToKot.ReadOnly = False
            txt_FromKot.Focus()
            grp_FinalbillRegister.Top = 1000
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub frmSelectivemanualbill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F9 Then
                Call CmdView_Click(sender, e)
            End If
            If e.KeyCode = Keys.F11 Then
                Me.Close()
            End If
            If e.KeyCode = Keys.F8 Then
                Call CmdPrint_Click(sender, e)
            End If
            If e.KeyCode = Keys.F6 Then
                Call CmdClear_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
End Class
