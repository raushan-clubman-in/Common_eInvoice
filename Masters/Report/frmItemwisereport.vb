Imports System.Data.SqlClient
Public Class frmItemwisereport
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
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents Chk_SelectAllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents LstGroup As System.Windows.Forms.CheckedListBox
    Friend WithEvents LstPOS As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_SelectAllPos As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grp_Salebillitemwise As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkNonRate As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmItemwisereport))
        Me.CmdClear = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdView = New System.Windows.Forms.Button
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.Chk_SelectAllGroup = New System.Windows.Forms.CheckBox
        Me.LstGroup = New System.Windows.Forms.CheckedListBox
        Me.LstPOS = New System.Windows.Forms.CheckedListBox
        Me.Chk_SelectAllPos = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grp_Salebillitemwise = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.chkNonRate = New System.Windows.Forms.CheckBox
        Me.GroupBox2.SuspendLayout()
        Me.grp_Salebillitemwise.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(136, 496)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 4
        Me.CmdClear.Text = "Clear[F6]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Controls.Add(Me.CmdPrint)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Location = New System.Drawing.Point(120, 480)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox2.TabIndex = 3
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
        Me.CmdView.TabIndex = 0
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
        Me.CmdPrint.TabIndex = 1
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
        Me.cmdexit.TabIndex = 2
        Me.cmdexit.Text = "Exit[F11]"
        '
        'Chk_SelectAllGroup
        '
        Me.Chk_SelectAllGroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllGroup.Location = New System.Drawing.Point(427, 56)
        Me.Chk_SelectAllGroup.Name = "Chk_SelectAllGroup"
        Me.Chk_SelectAllGroup.Size = New System.Drawing.Size(136, 24)
        Me.Chk_SelectAllGroup.TabIndex = 16
        Me.Chk_SelectAllGroup.Text = "SELECT ALL "
        '
        'LstGroup
        '
        Me.LstGroup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LstGroup.Location = New System.Drawing.Point(424, 112)
        Me.LstGroup.Name = "LstGroup"
        Me.LstGroup.Size = New System.Drawing.Size(264, 277)
        Me.LstGroup.TabIndex = 17
        '
        'LstPOS
        '
        Me.LstPOS.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LstPOS.Location = New System.Drawing.Point(56, 112)
        Me.LstPOS.Name = "LstPOS"
        Me.LstPOS.Size = New System.Drawing.Size(272, 277)
        Me.LstPOS.TabIndex = 18
        '
        'Chk_SelectAllPos
        '
        Me.Chk_SelectAllPos.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllPos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllPos.Location = New System.Drawing.Point(56, 56)
        Me.Chk_SelectAllPos.Name = "Chk_SelectAllPos"
        Me.Chk_SelectAllPos.Size = New System.Drawing.Size(128, 24)
        Me.Chk_SelectAllPos.TabIndex = 19
        Me.Chk_SelectAllPos.Text = "SELECT ALL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 544)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(423, 18)
        Me.Label4.TabIndex = 417
        Me.Label4.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 24)
        Me.Label1.TabIndex = 418
        Me.Label1.Text = "POS LOCATION:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(424, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 24)
        Me.Label2.TabIndex = 419
        Me.Label2.Text = "GROUP DESCRIPTION :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 25)
        Me.Label3.TabIndex = 420
        Me.Label3.Text = "ITEM MASTER PRINTING"
        '
        'Timer1
        '
        '
        'grp_Salebillitemwise
        '
        Me.grp_Salebillitemwise.BackgroundImage = CType(resources.GetObject("grp_Salebillitemwise.BackgroundImage"), System.Drawing.Image)
        Me.grp_Salebillitemwise.Controls.Add(Me.lbl_Wait)
        Me.grp_Salebillitemwise.Controls.Add(Me.ProgressBar1)
        Me.grp_Salebillitemwise.Location = New System.Drawing.Point(120, 424)
        Me.grp_Salebillitemwise.Name = "grp_Salebillitemwise"
        Me.grp_Salebillitemwise.Size = New System.Drawing.Size(496, 56)
        Me.grp_Salebillitemwise.TabIndex = 421
        Me.grp_Salebillitemwise.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(248, 22)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 18)
        Me.lbl_Wait.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 10)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(480, 40)
        Me.ProgressBar1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(70, 400)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox1.TabIndex = 422
        Me.CheckBox1.Text = "SALE RATE"
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(198, 400)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox2.TabIndex = 423
        Me.CheckBox2.Text = "PURCHASE RATE"
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(366, 400)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(168, 24)
        Me.CheckBox3.TabIndex = 424
        Me.CheckBox3.Text = "SALE RATE (VAT)"
        '
        'chkNonRate
        '
        Me.chkNonRate.BackColor = System.Drawing.Color.Transparent
        Me.chkNonRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNonRate.Location = New System.Drawing.Point(534, 400)
        Me.chkNonRate.Name = "chkNonRate"
        Me.chkNonRate.Size = New System.Drawing.Size(168, 24)
        Me.chkNonRate.TabIndex = 425
        Me.chkNonRate.Text = "WITHOUT RATE"
        '
        'frmItemwisereport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(734, 564)
        Me.Controls.Add(Me.chkNonRate)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.grp_Salebillitemwise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chk_SelectAllPos)
        Me.Controls.Add(Me.LstPOS)
        Me.Controls.Add(Me.Chk_SelectAllGroup)
        Me.Controls.Add(Me.LstGroup)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmItemwisereport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEM MASTER PRINTING"
        Me.GroupBox2.ResumeLayout(False)
        Me.grp_Salebillitemwise.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ssql As String
    Public Myconn As New SqlConnection
    Dim ds As DataSet
    Dim chkbool As Boolean
    Dim da As New SqlDataAdapter
    Dim vconn As New GlobalClass
    Private Sub FillPOS()   '''***************************** To fill POS details from POSMaster  *****************'''
        Try
            LstPOS.Items.Clear()
            Dim i As Integer
            ssql = "SELECT DISTINCT POSCODE,POSDESC FROM POSMASTER where len(poscode)>2"
            vconn.getDataSet(ssql, "POSMASTER")
            If gdataset.Tables("POSMASTER").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("POSMASTER").Rows.Count - 1
                    With gdataset.Tables("POSMASTER").Rows(i)
                        LstPOS.Items.Add(Trim(.Item("POSDESC")))
                    End With
                Next i
            End If
            LstPOS.Sorted = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
            vconn.getDataSet(SQLSTRING, "USER")
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
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillGroup()   '''***************************** To fill Group details from GroupMaster  *****************'''
        Try
            LstGroup.Items.Clear()
            Dim i As Integer
            ssql = "SELECT DISTINCT GROUPCODE,GROUPDESC FROM GROUPMASTER "
            vconn.getDataSet(ssql, "GROUPMASTER")
            If gdataset.Tables("GROUPMASTER").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("GROUPMASTER").Rows.Count - 1
                    With gdataset.Tables("GROUPMASTER").Rows(i)
                        LstGroup.Items.Add(Trim(.Item("GROUPDESC")))
                    End With
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Chk_SelectAllPos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllPos.CheckedChanged
        Try
            Dim i As Integer
            If Chk_SelectAllPos.Checked = True Then
                For i = 0 To LstPOS.Items.Count - 1
                    LstPOS.SetItemChecked(i, True)
                Next
            Else
                For i = 0 To LstPOS.Items.Count - 1
                    LstPOS.SetItemChecked(i, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
                Me.grp_Salebillitemwise.Top = 1000
                Call viewItemmasterprinting()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub viewItemmasterprinting()
        Try
            Dim Sqlstring, GroupCode() As String
            Dim i As Integer
            Sqlstring = " SELECT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMDESC,'') AS ITEMDESC,"
            Sqlstring = Sqlstring & " ISNULL(R.UOM,'') AS UOM,ISNULL(R.PURCAHSERATE,0) AS PURCHASERATE,ISNULL(R.ITEMRATE,0) AS ITEMRATE,CASE WHEN ISNULL(Z.TAXPERCENTAGE,0)<>0 THEN ROUND(R.ITEMRATE+(R.ITEMRATE*(Z.TAXPERCENTAGE/100)),0) ELSE R.ITEMRATE END AS VATRATE,"
            Sqlstring = Sqlstring & " ISNULL(PL.POS,'') AS POSCODE,ISNULL(P.POSDESC,'') AS POSDESC,ISNULL(I.GROUPCODE,'') AS GROUPCODE,"
            Sqlstring = Sqlstring & " ISNULL(G.GROUPDESC,'') AS GROUPDESC,ISNULL(I.FREEZE,'') AS FREEZE,ISNULL(R.ENDINGDATE,'') AS ENDINGDATE FROM ITEMMASTER AS I INNER JOIN RATEMASTER AS R ON R.ITEMCODE = I.ITEMCODE INNER JOIN ITEMTYPEMASTER AS Z ON I.ITEMTYPECODE=Z.ITEMTYPECODE "
            Sqlstring = Sqlstring & " INNER JOIN POSMENULINK AS PL ON PL.ITEMCODE = I.ITEMCODE INNER JOIN POSMASTER AS P ON P.POSCODE = PL.POS"
            Sqlstring = Sqlstring & " INNER JOIN GROUPMASTER AS G ON G.GROUPCODE = I.GROUPCODE "
            If LstPOS.CheckedItems.Count <> 0 Then
                Sqlstring = Sqlstring & " WHERE POSDESC IN ("
                For i = 0 To LstPOS.CheckedItems.Count - 1
                    Sqlstring = Sqlstring & "'" & Trim(LstPOS.CheckedItems(i)) & "', "
                Next i
                Sqlstring = Mid(Sqlstring, 1, Len(Sqlstring) - 2)
                Sqlstring = Sqlstring & ")"
            Else
                MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            If LstGroup.CheckedItems.Count <> 0 Then
                Sqlstring = Sqlstring & " AND GROUPDESC IN ("
                For i = 0 To LstGroup.CheckedItems.Count - 1
                    Sqlstring = Sqlstring & "'" & Trim(LstGroup.CheckedItems(i)) & "', "
                Next
                Sqlstring = Mid(Sqlstring, 1, Len(Sqlstring) - 2)
                Sqlstring = Sqlstring & ")"
            Else
                MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            Sqlstring = Sqlstring & " AND ISNULL(I.FREEZE,'') <> 'Y' AND  ISNULL(R.ENDINGDATE,'')=''"
            Sqlstring = Sqlstring & " GROUP BY P.POSDESC,PL.POS,I.GROUPCODE,G.GROUPDESC,I.ITEMCODE,"
            Sqlstring = Sqlstring & " I.ITEMDESC,R.UOM,R.PURCAHSERATE,R.ITEMRATE,I.FREEZE,R.ENDINGDATE,Z.TAXPERCENTAGE ORDER BY GROUPDESC,POSDESC,ITEMCODE,ITEMDESC"
            Dim heading() As String = {"ITEM MASTER CHECKLIST", LstPOS.CheckedItems(0)}
            Dim ObjItemmasterchecklist As New rptItemmasterchecklist
            If CheckBox1.Checked = True And CheckBox2.Checked = False Then
                ObjItemmasterchecklist.printdatasale(Sqlstring, heading, Format(Now, "dd-MMM-yyyy"), Format(Now, "dd-MMM-yyyy"))
            ElseIf CheckBox2.Checked = True And CheckBox1.Checked = False Then
                ObjItemmasterchecklist.printdatapurchase(Sqlstring, heading, Format(Now, "dd-MMM-yyyy"), Format(Now, "dd-MMM-yyyy"))
            ElseIf CheckBox3.Checked = True Then
                ObjItemmasterchecklist.printdatasalevat(Sqlstring, heading, Format(Now, "dd-MMM-yyyy"), Format(Now, "dd-MMM-yyyy"))
            ElseIf chkNonRate.Checked = True And CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False Then
                ObjItemmasterchecklist.printwithoutrate(Sqlstring, heading, Format(Now, "dd-MMM-yyyy"), Format(Now, "dd-MMM-yyyy"))
            Else
                ObjItemmasterchecklist.printdata(Sqlstring, heading, Format(Now, "dd-MMM-yyyy"), Format(Now, "dd-MMM-yyyy"))
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_SelectAllGroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllGroup.CheckedChanged
        Try
            Dim i As Integer
            If Chk_SelectAllGroup.Checked = True Then
                For i = 0 To LstGroup.Items.Count - 1
                    LstGroup.SetItemChecked(i, True)
                Next i
            Else
                For i = 0 To LstGroup.Items.Count - 1
                    LstGroup.SetItemChecked(i, False)
                Next i
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            LstPOS.Items.Clear()
            LstGroup.Items.Clear()
            Chk_SelectAllGroup.Checked = False
            Chk_SelectAllPos.Checked = False
            Call FillGroup()
            Call FillPOS()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
            If LstPOS.CheckedItems.Count = 0 Then
                MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            If LstGroup.CheckedItems.Count = 0 Then
                MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            gPrint = False
            grp_Salebillitemwise.Top = 424
            grp_Salebillitemwise.Left = 120
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            If LstPOS.CheckedItems.Count = 0 Then
                MsgBox("Select the location(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            If LstGroup.CheckedItems.Count = 0 Then
                MsgBox("Select the Group(s)", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
                Exit Sub
            End If
            gPrint = True
            grp_Salebillitemwise.Top = 424
            grp_Salebillitemwise.Left = 120
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub frmItemwisereport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call FillPOS()
            Call FillGroup()
            grp_Salebillitemwise.Top = 1000
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_SelectAllPos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Chk_SelectAllPos.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                LstPOS.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub LstPOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstPOS.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Chk_SelectAllGroup.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Chk_SelectAllGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Chk_SelectAllGroup.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                LstGroup.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub LstGroup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstGroup.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                CmdView.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub frmItemwisereport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Dim i As Integer
            If e.KeyCode = Keys.F9 Then
                Call CmdView_Click(sender, e)
            End If
            If e.KeyCode = Keys.F8 Then
                Call CmdPrint_Click(sender, e)
            End If
            If e.KeyCode = Keys.F6 Then
                Call CmdClear_Click(sender, e)
            End If
            If e.KeyCode = Keys.F11 Then
                Me.Close()
            End If
            If e.KeyCode = Keys.F2 Then
                Chk_SelectAllPos.Checked = True
                For i = 0 To LstPOS.Items.Count - 1
                    LstPOS.SetItemChecked(i, True)
                Next
                Chk_SelectAllGroup.Checked = True
                For i = 0 To LstGroup.Items.Count - 1
                    LstGroup.SetItemChecked(i, True)
                Next i
            End If
            If e.KeyCode = Keys.F7 Then
                Search = InputBox("ENTER TEXT", "SEARCH")
                If LstPOS.SelectedIndex = 0 Then
                    Call Search_Item(LstPOS, Search)
                ElseIf LstGroup.SelectedIndex = 0 Then
                    Call Search_Item(LstGroup, Search)
                End If
            End If
            If e.KeyCode = Keys.Escape Then
                Call cmdexit_Click(sender, e)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
End Class
