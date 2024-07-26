Imports System.Data.SqlClient
Imports System.IO
Imports System.Math
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
        Me.lbl_Finalbill.TabIndex = 3
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
        Me.CmdClear.TabIndex = 2
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
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Cmd_ToBill
        '
        Me.Cmd_ToBill.Image = CType(resources.GetObject("Cmd_ToBill.Image"), System.Drawing.Image)
        Me.Cmd_ToBill.Location = New System.Drawing.Point(384, 72)
        Me.Cmd_ToBill.Name = "Cmd_ToBill"
        Me.Cmd_ToBill.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ToBill.TabIndex = 5
        '
        'Cmd_FromBill
        '
        Me.Cmd_FromBill.Image = CType(resources.GetObject("Cmd_FromBill.Image"), System.Drawing.Image)
        Me.Cmd_FromBill.Location = New System.Drawing.Point(384, 24)
        Me.Cmd_FromBill.Name = "Cmd_FromBill"
        Me.Cmd_FromBill.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_FromBill.TabIndex = 4
        '
        'txt_ToBill
        '
        Me.txt_ToBill.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToBill.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToBill.Location = New System.Drawing.Point(160, 72)
        Me.txt_ToBill.Name = "txt_ToBill"
        Me.txt_ToBill.Size = New System.Drawing.Size(224, 29)
        Me.txt_ToBill.TabIndex = 1
        Me.txt_ToBill.Text = ""
        '
        'txt_FromBill
        '
        Me.txt_FromBill.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromBill.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromBill.Location = New System.Drawing.Point(160, 24)
        Me.txt_FromBill.Name = "txt_FromBill"
        Me.txt_FromBill.Size = New System.Drawing.Size(224, 29)
        Me.txt_FromBill.TabIndex = 0
        Me.txt_FromBill.Text = ""
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
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Controls.Add(Me.CmdPrint)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox2.TabIndex = 1
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
        'grp_FinalbillRegister
        '
        Me.grp_FinalbillRegister.BackgroundImage = CType(resources.GetObject("grp_FinalbillRegister.BackgroundImage"), System.Drawing.Image)
        Me.grp_FinalbillRegister.Controls.Add(Me.lbl_Wait)
        Me.grp_FinalbillRegister.Controls.Add(Me.ProgressBar1)
        Me.grp_FinalbillRegister.Location = New System.Drawing.Point(16, 72)
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
        Me.KeyPreview = True
        Me.Name = "FinalBillReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FINAL BILL REGISTER"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.grp_FinalbillRegister.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim chkbool As Boolean
    Dim gconnetion As New GlobalClass
    Dim gconnection As New GlobalClass


    Private Sub FinalBillReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txt_FromBill.Text = ""
            txt_ToBill.Text = ""
            txt_FromBill.ReadOnly = False
            txt_ToBill.ReadOnly = False
            txt_FromBill.Focus()
            grp_FinalbillRegister.Top = 1000
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
            gconnetion.getDataSet(SQLSTRING, "USER")
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
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            txt_FromBill.Text = ""
            txt_ToBill.Text = ""
            txt_FromBill.ReadOnly = False
            txt_ToBill.ReadOnly = False
            txt_FromBill.Focus()
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub Validatedate()
        Try
            chkbool = False
            If Trim(txt_FromBill.Text) = "" Then
                MessageBox.Show("From Billno Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_FromBill.Text = ""
                txt_FromBill.Focus()
                Exit Sub
            End If
            If Trim(txt_ToBill.Text) = "" Then
                MessageBox.Show("To Billno Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_ToBill.Text = ""
                txt_ToBill.Focus()
                Exit Sub
            End If
            chkbool = True
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            gPrint = False
            Call Validatedate() '''--> Check Validation
            If chkbool = False Then Exit Sub
            grp_FinalbillRegister.Top = 76
            grp_FinalbillRegister.Left = 16
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        Try
            gPrint = True
            Call Validatedate() '''--> Check Validation
            If chkbool = False Then Exit Sub
            grp_FinalbillRegister.Top = 76
            grp_FinalbillRegister.Left = 16
            Me.ProgressBar1.Value = 2
            Me.Timer1.Interval = 30
            Me.Timer1.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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




    Public Sub BillPrintOperation_MCC()
        Try
            Randomize()
            Dim rowj, Loopindex, i, Pagesize, CountItem, in1, Fo As Integer
            Dim Rowprint, vCaption, vPath, Fsize(), Forder(), billdetails, rupeesword, REMARKS As String
            Dim BillNo, sql, Kot, vOutfile, vheader, vline, round, vFilepath, str, Otherbillno As String
            Dim RoundOff, RoundDiff, TotalAmount, TaxAmount, taxpercentage As Double
            Dim ds As New DataSet
            Dim Otherbool, boolOtherBill As Boolean
            Dim Filewrite As StreamWriter
            Dim vpagenumber, Vrowcount As Long
            Dim headercount As Double

            Dim SSQLROOM As String

            gCompanyname = MyCompanyName
            gCompanyAddress(0) = Address1
            gCompanyAddress(1) = Address2
            Gheader = "TAX  INVOICE"
            vpagenumber = 1
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"

            sql = "SELECT BILL_HDR.PAYMENTMODE,BILL_HDR.MCODE,BILL_HDR.MNAME,BILL_HDR.SCODE,BILL_HDR.SNAME,BILL_HDR.REMARKS,"
            sql = sql & "D.BILLDETAILS,D.KOTNO,D.KOTDETAILS,D.KOTDATE,ITEMCODE,D.KOTNO,ITEMDESC,D.POSCODE,D.UOM,D.QTY,"
            sql = sql & "D.RATE,AMOUNT,TAXTYPE,TAXPERC,ISNULL(TAXCODE,'') as TAXCODE,ISNULL(D.TAXAMOUNT,0) as TAXAMOUNT,"
            sql = sql & "ITEMTYPE,BILLDATE,BILLTIME,BILL_HDR.adduserid as adduserid,"
            sql = sql & "ISNULL(GUEST,'') AS GUEST,ISNULL(CAST(ROOMNO AS VARCHAR),'') AS ROOMNO,ISNULL(CAST(BILL_HDR.CHKID AS VARCHAR),'') AS CHKID"
            sql = sql & " FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
            sql = sql & " WHERE D.Billdetails BETWEEN '" & Trim(txt_FromBill.Text) & "' AND '" & Trim(txt_ToBill.Text) & "' AND ISNULL(KotStatus,'N')='N' "
            sql = sql & " ORDER BY D.BillDetails"

            gconnection.getDataSet(sql, "ReportTable")
            Dim adduserid As String
            adduserid = ""
            If gdataset.Tables("ReportTable").Rows.Count > 0 Then
                adduserid = Trim(gdataset.Tables("ReportTable").Rows(0).Item("ADDUSERID"))
                Filewrite = File.AppendText(vFilepath)
                vline = ""
                BillNo = Trim(gdataset.Tables("ReportTable").Rows(0).Item("BillDetails"))
                REMARKS = Trim(gdataset.Tables("ReportTable").Rows(0).Item("REMARKS"))
                taxpercentage = Val(gdataset.Tables("ReportTable").Rows(0).Item("TaxPerc"))
                Kot = ""
                For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                    CountItem = CountItem + 1
                    boolOtherBill = False
                    headercount = 1
                    If Trim(BillNo) <> Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")) Then
                        If Vrowcount <= 32 Then
                            For i = 1 To 17 - Vrowcount
                                Filewrite.WriteLine("")
                            Next
                        End If

                        'Vrowcount = 0
                        If Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")) = "ROOM" Then
                            Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                            Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("GUEST") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("ROOMNO")) & ")")
                        Else
                            Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("PAYMENTMODE")), 1, 10)))
                            Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("MCODE")) & ")")
                        End If
                        If Len(Rowprint) < 45 Then
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                            Filewrite.WriteLine()
                            Vrowcount = Vrowcount + 2
                        Else
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                            Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                            Vrowcount = Vrowcount + 2
                        End If
                        Vrowcount = Vrowcount + 2
                        Rowprint = Space(40) & "----------"
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1
                        Rowprint = Space(42) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 6) & Space(6 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 6)))
                        Filewrite.WriteLine(Rowprint)
                        Vrowcount = Vrowcount + 1
                        '4
                        If Format(Val(taxpercentage), "0.00") = "12.50" Then
                            Rowprint = "Add VAT @ 12.50%"
                        ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                            Rowprint = "Add Service Tax @ 12.24%"
                        ElseIf Format(Val(taxpercentage), "0.00") = "2.00" Then
                            Rowprint = "Add VAT @ 2% ON F & B"
                        Else
                            Rowprint = "Bills Payable On Presentation"
                        End If
                        Rowprint = Rowprint & Space(39 - Len(Rowprint)) & Format(Val(TaxAmount), "0.00")
                        Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                        '5
                        Vrowcount = Vrowcount + 1
                        Filewrite.Write("N O  T I P P I N G")
                        Rowprint = Space(22) & "----------"
                        Filewrite.WriteLine(Rowprint)
                        '6
                        Vrowcount = Vrowcount + 1
                        If Format(Val(taxpercentage), "0.00") = "12.50" Then
                            Rowprint = "Our VAT No : 12345678901  Total :  "
                        ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                            Rowprint = "Our ST No : 123456789 TNL Total :  "
                        Else
                            Rowprint = "                          Total :  "
                        End If
                        Rowprint = Rowprint & Space(40 - Len(Rowprint)) & Format(TaxAmount + TotalAmount, "0.00")
                        Filewrite.WriteLine(Rowprint)
                        '7
                        Vrowcount = Vrowcount + 1
                        RoundOff = Val(TaxAmount + TotalAmount)
                        round = CStr(RoundOff)
                        If round.IndexOf(".") <= 0 Then
                            round = round.Insert(round.Length - 1, ".00")
                        End If
                        If Val(Split(round, ".")(1)) >= 50 Then
                            RoundOff = Math.Ceiling(RoundOff)
                        Else
                            RoundOff = Math.Floor(RoundOff)
                        End If
                        If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                            RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                            Rowprint = "                 Rounded Off :(+)"
                        Else
                            RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                            Rowprint = "                 Rounded Off :(-)"
                        End If
                        Rowprint = Rowprint & Space(40 - Len(Rowprint)) & Format(Val(RoundDiff), "0.00")

                        For i = 0 To 50
                            Filewrite.Write("-")
                        Next
                        Filewrite.WriteLine()
                        '9
                        Vrowcount = Vrowcount + 1
                        rupeesword = ConvertRupees(Format(IIf(gRoundOffFlag = True, Math.Round(TaxAmount + TotalAmount), TaxAmount + TotalAmount), "0.00"))
                        Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 40) & Space(40 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 40)))
                        Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(IIf(gRoundOffFlag = True, Math.Round(TaxAmount + TotalAmount), TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
                        Filewrite.WriteLine(Rowprint)
                        '10
                        Vrowcount = Vrowcount + 1
                        For i = 0 To 50
                            Filewrite.Write("-")
                        Next
                        Filewrite.WriteLine("")
                        '11
                        Vrowcount = Vrowcount + 1
                        Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname
                        Filewrite.WriteLine(Rowprint)
                        '12
                        Vrowcount = Vrowcount + 1
                        Dim ssql As String
                        ssql = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
                        ssql = ssql & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
                        ssql = ssql & " WHERE D.Billdetails = '" & BillNo & "' "
                        ssql = ssql & " AND ISNULL(KotStatus,'N')='N'"
                        ssql = ssql & " order by d.billdetails"
                        gconnection.getDataSet(ssql, "rTable")
                        For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                            Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
                        Next
                        If Len(Kot) < 31 Then
                            Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                            Filewrite.WriteLine(Rowprint)
                            Filewrite.WriteLine()
                            Vrowcount = Vrowcount + 1
                        Else
                            Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                            Filewrite.WriteLine(Rowprint)
                            Rowprint = "             " & Mid(Kot, 31, Len(Kot)) & "."
                            Filewrite.WriteLine(Rowprint)
                            Vrowcount = Vrowcount + 1
                        End If
                        '14
                        Kot = ""
                        If Trim(REMARKS) <> "" Then
                            If Len(Trim(REMARKS)) < 50 Then
                                Filewrite.WriteLine("             " & Trim(REMARKS))
                                Filewrite.WriteLine()
                                Vrowcount = Vrowcount + 1
                            Else
                                Filewrite.WriteLine("             " & Mid(Trim(REMARKS), 1, 50))
                                Filewrite.WriteLine("             " & Mid(Trim(REMARKS), 51, 50))
                                Vrowcount = Vrowcount + 1
                            End If
                        End If
                        '16
                        If Vrowcount > 32 Then
                            For i = 1 To 77 - Vrowcount
                                Filewrite.WriteLine("")
                            Next
                        End If

                        If Vrowcount <= 32 Then
                            For i = 1 To 8
                                Filewrite.WriteLine("")
                            Next
                        End If

                        BillNo = gdataset.Tables("ReportTable").Rows(rowj).Item("BillDetails")
                        Kot = ""
                        TotalAmount = 0
                        TaxAmount = 0
                        taxpercentage = Val(gdataset.Tables("ReportTable").Rows(rowj).Item("TaxPerc"))
                        Vrowcount = 0
                        boolOtherBill = True
                        CountItem = 1
                    End If
                    If Vrowcount = 0 Then
                        If headercount = 1 Then
                            headercount = 2
                            Rowprint = Chr(18) & Chr(27) & Chr(106) & Chr(200) & Chr(27) & Chr(14) & Chr(27) & Chr(71) & Chr(18) & Chr(27) + "E" & gCompanyname & Chr(27) & "F" & Chr(20) & Chr(27) & Chr(72)
                            Filewrite.WriteLine(Rowprint)
                            '1
                            Vrowcount = Vrowcount + 1
                            Rowprint = Space(13) & gCompanyAddress(0)
                            Filewrite.WriteLine(Rowprint)
                            '2
                            Vrowcount = Vrowcount + 1
                            Rowprint = Space(13) & gCompanyAddress(1)
                            Filewrite.WriteLine(Rowprint)
                            '3
                            Vrowcount = Vrowcount + 1
                            If Format(Val(taxpercentage), "0.00") = "12.50" Then
                                Gheader = " TAX  INVOICE "
                            Else
                                Gheader = " CREDIT  MEMO "
                            End If
                            Filewrite.WriteLine("")
                            '4
                            Vrowcount = Vrowcount + 1
                            Rowprint = Chr(18) & Chr(27) + "E" & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader & Chr(27) + "F" & Chr(18)
                            Filewrite.WriteLine(Rowprint)
                            Rowprint = "BILL:"
                            Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(BillNo) & Chr(27) + "F" & Chr(18)
                            Filewrite.Write(Rowprint)
                            Rowprint = Chr(15) & Space(20 - Len(Trim(BillNo)))
                            Rowprint = Rowprint & "TIME :"
                            'Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "HH:mm:ss")
                            Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillTime"), "T")
                            Filewrite.WriteLine(Rowprint)
                            '5
                            Vrowcount = Vrowcount + 1
                            Rowprint = "SERVER :"
                            Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SCODE"))
                            Filewrite.Write(Rowprint)
                            Rowprint = "(" & Mid(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME"), 1, 25) & ")" & Space(25 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME") & "(" & gdataset.Tables("ReportTable").Rows(rowj).Item("SNAME") & ")"), 1, 25))) & Chr(27) + "F" & Chr(15)
                            Rowprint = Rowprint & "DATE :"
                            Rowprint = Rowprint & Format(gdataset.Tables("ReportTable").Rows(rowj).Item("BillDate"), "dd/MM/yyyy")
                            Filewrite.WriteLine(Rowprint)
                            '6
                            Vrowcount = Vrowcount + 1
                            Pagesize = Pagesize + 1

                            For i = 0 To 50
                                Filewrite.Write("-")
                            Next
                            Filewrite.WriteLine()
                            '7
                            Vrowcount = Vrowcount + 1
                            Rowprint = "SNo  ITEM DESCRIPTION          QTY   RATE   AMOUNT"
                            '12345678901234567890123456789012345678901234567890123456789012345678901234567890
                            Filewrite.WriteLine(Rowprint & Chr(15))
                            '8
                            Vrowcount = Vrowcount + 1
                            For i = 0 To 50
                                Filewrite.Write("-")
                            Next
                            Filewrite.WriteLine()
                            '9
                            Vrowcount = Vrowcount + 1
                        End If
                    End If

                    With gdataset.Tables("ReportTable").Rows(rowj)
                        Rowprint = ""
                        Rowprint = Mid(CountItem, 1, 3) & "." & Space(3 - Len(Mid(CountItem, 1, 3)))
                        '   Rowprint = Rowprint & Mid(Trim(.Item("ITEMCODE") & ""), 1, 6) & Space(6 - Len(Mid(Trim(.Item("ITEMCODE") & ""), 1, 6)))
                        Rowprint = Rowprint & Mid(Trim(.Item("ITEMDESC") & ""), 1, 25) & Mid(Trim(".............................."), 1, 25 - Len(Mid(Trim(.Item("ITEMDESC") & ""), 1, 25)))
                        Rowprint = Rowprint & Mid(Val(.Item("QTY") & ""), 1, 3) & Space(3 - Len(Mid(Trim(.Item("QTY") & ""), 1, 3))) & Space(1)
                        Rowprint = Rowprint & Mid(Trim(.Item("UOM") & ""), 1, 3) & Space(3 - Len(Mid(Trim(.Item("UOM") & ""), 1, 3)))
                        Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("RATE") & ""), "0.00"), 1, 8)
                        Rowprint = Rowprint & Space(8 - Len(Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8))) & Mid(Format(Val(.Item("AMOUNT") & ""), "0.00"), 1, 8)
                        TotalAmount = TotalAmount + Val(.Item("Amount"))
                        TaxAmount = TaxAmount + Val(.Item("TaxAmount"))
                        Filewrite.WriteLine(Rowprint & Chr(15))
                        Vrowcount = Vrowcount + 1
                    End With
                Next rowj
                If Vrowcount <= 32 Then
                    For i = 1 To 17 - Vrowcount
                        Filewrite.WriteLine("")
                    Next
                End If

                'Vrowcount = 0
                'Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10) & ":" & Space(11 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 10)))
                'Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MCODE")) & ")")
                If Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")) = "ROOM" Then
                    Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 5) & ":" & Space(5 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 5)))
                    Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("ROOMNO") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("GUEST")) & ")")
                Else
                    Rowprint = Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 5) & ":" & Space(5 - Len(Mid(Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("PAYMENTMODE")), 1, 5)))
                    Rowprint = Rowprint & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MNAME") & "(" & Trim(gdataset.Tables("ReportTable").Rows(rowj - 1).Item("MCODE")) & ")")
                End If
                If Len(Rowprint) < 45 Then
                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Rowprint & Chr(27) + "F" & Chr(15))
                    Filewrite.WriteLine()
                Else
                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Mid(Rowprint, 1, 44) & Chr(27) + "F" & Chr(15))
                    Filewrite.WriteLine(Chr(18) & Chr(27) + "E" & Space(9) & Mid(Rowprint, 45, 35) & Chr(27) + "F" & Chr(15))
                End If

                Vrowcount = Vrowcount + 2
                Rowprint = Space(40) & "----------"
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
                Rowprint = Space(40) & Space(10 - Len(Mid(Trim(Format(TotalAmount, "0.00")), 1, 10))) & Mid(Trim(Format(TotalAmount, "0.00")), 1, 10)
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
                '4
                If Format(Val(taxpercentage), "0.00") = "12.50" Then
                    Rowprint = "Add VAT @ 12.50%"
                ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                    Rowprint = "Add Service Tax @ 12.24%"
                ElseIf Format(Val(taxpercentage), "0.00") = "2.00" Then
                    Rowprint = "Add VAT @ 2% ON F & B"
                Else
                    Rowprint = "Bills Payable On Presentation"
                End If
                Rowprint = Rowprint & Space(40 - Len(Rowprint)) & Space(10 - Len(Mid(Trim(Format(TaxAmount, "0.00")), 1, 10))) & Mid(Trim(Format(TaxAmount, "0.00")), 1, 10)
                Filewrite.WriteLine(Rowprint & Chr(14) & Chr(15))
                Vrowcount = Vrowcount + 1
                Filewrite.Write("N O  T I P P I N G")
                'Vrowcount = Vrowcount + 1
                Rowprint = Space(22) & "----------"
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
                If Format(Val(taxpercentage), "0.00") = "12.50" Then
                    Rowprint = "Our VAT No : 12345678901   Total :"
                ElseIf Format(Val(taxpercentage), "0.00") = "12.24" Then
                    Rowprint = "Our ST No : 123456789 TNL, Total :"
                Else
                    Rowprint = "                           Total :"
                End If
                Rowprint = Rowprint & Space(40 - Len(Rowprint)) & Space(10 - Len(Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 10))) & Mid(Trim(Format(TaxAmount + TotalAmount, "0.00")), 1, 10)
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
                RoundOff = Val(TaxAmount + TotalAmount)
                round = CStr(RoundOff)
                If round.IndexOf(".") <= 0 Then
                    round = round.Insert(round.Length - 1, ".00")
                End If
                If Val(Split(round, ".")(1)) >= 50 Then
                    RoundOff = Math.Ceiling(RoundOff)
                Else
                    RoundOff = Math.Floor(RoundOff)
                End If
                If Val(RoundOff) > Val(TaxAmount + TotalAmount) Then
                    RoundDiff = RoundOff - (TaxAmount + TotalAmount)
                    Rowprint = "                  Rounded Off :(+)"
                Else
                    RoundDiff = (TaxAmount + TotalAmount) - RoundOff
                    Rowprint = "                  Rounded Off :(-)"
                End If
                Rowprint = Rowprint & Space(40 - Len(Rowprint)) & Space(10 - Len(Mid(Trim(Format(RoundDiff, "0.00")), 1, 10))) & Mid(Trim(Format(RoundDiff, "0.00")), 1, 10)
                'ROUNDED OFF
                '     Filewrite.WriteLine(Rowprint)
                '  Vrowcount = Vrowcount + 1
                For i = 0 To 50
                    Filewrite.Write("-")
                Next
                Filewrite.WriteLine()
                Vrowcount = Vrowcount + 1
                rupeesword = ConvertRupees(Format(IIf(gRoundOffFlag = True, Math.Round(TaxAmount + TotalAmount), TaxAmount + TotalAmount), "0.00"))

                Rowprint = Mid(Trim("Rupees " & rupeesword & " Only."), 1, 40) & Space(40 - Len(Mid(Trim("Rupees" & rupeesword & "Only."), 1, 40)))
                Rowprint = Rowprint & Chr(18) & Chr(27) + "E" & Format(IIf(gRoundOffFlag = True, Math.Round(TaxAmount + TotalAmount), TaxAmount + TotalAmount), "0.00") & Chr(27) + "F" & Chr(15)
                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
                For i = 0 To 50
                    Filewrite.Write("-")
                Next
                Filewrite.WriteLine("")
                Vrowcount = Vrowcount + 1
                '            Rowprint = "Prepared By :" & gUsername & " From " & gCompanyname
                Rowprint = "Prepared By :" & adduserid & " From " & gCompanyname

                Filewrite.WriteLine(Rowprint)
                Vrowcount = Vrowcount + 1
                Dim sstring As String
                sstring = "SELECT distinct D.KOTNO,d.billdetails,D.KOTDETAILS,D.KOTDATE "
                sstring = sstring & "  FROM KOT_DET D INNER JOIN BILL_HDR ON BILL_HDR.BILLDETAILS = D.BILLDETAILS "
                sstring = sstring & " WHERE D.Billdetails = '" & BillNo & "' "
                sstring = sstring & " AND ISNULL(KotStatus,'N')='N'"
                sstring = sstring & " order by d.billdetails"
                gconnection.getDataSet(sstring, "rTable")
                For i = 0 To gdataset.Tables("rTable").Rows.Count - 1
                    Kot = Kot & "," & gdataset.Tables("rTable").Rows(i).Item("Kotno")
                Next
                If Len(Kot) < 31 Then
                    Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Kot & "."
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 1
                Else
                    Rowprint = "Remarks     : Ref. KOT NO.(s) -" & Mid(Kot, 1, 30) & "-"
                    Filewrite.WriteLine(Rowprint)
                    Rowprint = "             " & Mid(Kot, 31, 30) & "."
                    Filewrite.WriteLine(Rowprint)
                    Vrowcount = Vrowcount + 2
                End If
                If Trim(REMARKS) <> "" Then
                    If Len(Trim(REMARKS)) < 50 Then
                        Filewrite.WriteLine("             " & Trim(REMARKS))
                        Vrowcount = Vrowcount + 1
                    Else
                        Filewrite.WriteLine("             " & Mid(Trim(REMARKS), 1, 50))
                        Filewrite.WriteLine("             " & Mid(Trim(REMARKS), 51, 50))
                        Vrowcount = Vrowcount + 2
                    End If
                End If

                If Vrowcount <= 32 Then
                    For i = 1 To 10
                        Filewrite.WriteLine("")
                    Next
                End If
                If Vrowcount > 32 Then
                    For i = 1 To 77 - Vrowcount
                        Filewrite.WriteLine("")
                    Next
                End If

                Filewrite.Close()
                If gPrint = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile1(vFilepath)
                End If
            Else
                MessageBox.Show("Invalid BillNo or Bill is not Yet generated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub FinalBillRegister()
        Try
            Dim i As Integer
            Dim sqlstring As String
            Call Validatedate() '''--> Check Validation
            If chkbool = False Then Exit Sub
            sqlstring = "SELECT * FROM VIEWFILLBILLSELECTION"
            sqlstring = sqlstring & " WHERE BILLDETAILS  BETWEEN '" & Trim(txt_FromBill.Text) & "' AND '" & Trim(txt_ToBill.Text) & "' AND ISNULL(KotStatus,'N')='N' ORDER BY BILLDETAILS "
            Dim ColumnHeading() As String = {"SLNo", "CODE", "ITEM DESCRIPTION", "QTY", "UOM", "RATE", "AMOUNT"}
            Dim ReportHeading() As String = {MyCompanyName, Address1, Address2}
            Dim ColumnSize() As Integer = {6, 6, 35, 12, 10, 10}
            Dim Objfinalbillregister As New finalbillregister
            Objfinalbillregister.ReportDetails(sqlstring, ReportHeading, ColumnHeading, ColumnSize)
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_FromBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FromBill.Click
        Try
            Dim vform As New ListOperattion1
            gSQLString = "SELECT ISNULL(BILLDETAILS,'') AS BILLDETAILS,CONVERT( VARCHAR(12),BILLDATE,100) FROM BILL_HDR"
            If Trim(Search) = "" Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " "
            End If
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
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_ToBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ToBill.Click
        Try
            Dim vform As New ListOperattion1
            gSQLString = "SELECT ISNULL(BILLDETAILS,'') AS BILLDETAILS,CONVERT( VARCHAR(12),BILLDATE,100) FROM BILL_HDR"
            If Trim(Search) = "" Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " "
            End If
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
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_FromBill_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FromBill.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_FromBill.Text) = "" Then
                    Call Cmd_FromBill_Click(sender, e)
                Else
                    Call txt_FromBill_Validated(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_ToBill_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ToBill.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_ToBill.Text) = "" Then
                    Call Cmd_ToBill_Click(sender, e)
                Else
                    Call txt_ToBill_Validated(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_FromBill_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FromBill.Validated
        Dim j, i As Integer
        Dim sqlstring As String
        Dim dt As New DataTable
        If Trim(txt_FromBill.Text) <> "" Then
            Try
                sqlstring = "SELECT * FROM Bill_Hdr WHERE BillNo='" & Format(Val(Trim(txt_FromBill.Text)), "000000") & "'OR Billdetails='" & Trim(txt_FromBill.Text) & "'"
                gconnetion.getDataSet(sqlstring, "Bill_Hdr")
                txt_FromBill.Text = Trim(gdataset.Tables("Bill_Hdr").Rows(0).Item("Billdetails") & "")
                txt_FromBill.ReadOnly = True
                txt_ToBill.Focus()
            Catch ex As Exception
                MessageBox.Show("Enter valid KOT No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
                '04/05/2008
                sqlstring = "SELECT * FROM Bill_Hdr WHERE BillNo='" & Format(Val(Trim(txt_ToBill.Text)), "000000") & "'OR Billdetails='" & Trim(txt_ToBill.Text) & "'"
                gconnetion.getDataSet(sqlstring, "Bill_Hdr")
                txt_ToBill.Text = Trim(gdataset.Tables("Bill_Hdr").Rows(0).Item("Billdetails") & "")
                txt_ToBill.ReadOnly = True
                CmdView.Focus()
            Catch ex As Exception
                MessageBox.Show("Enter valid KOT No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub txt_FromBill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FromBill.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_FromBill.Enabled = True Then
                    Search = Trim(txt_FromBill.Text)
                    Call Cmd_FromBill_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_ToBill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ToBill.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_ToBill.Enabled = True Then
                    Search = Trim(txt_ToBill.Text)
                    Call Cmd_ToBill_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
                '  Call FinalBillRegister()
                Call BillPrintOperation_MCC()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FinalBillReport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
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
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
End Class