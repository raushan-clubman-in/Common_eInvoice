Imports System.Data.SqlClient
Imports System.IO
Imports System.Math
Public Class TALLYPOSTINGTOTAL
    Inherits System.Windows.Forms.Form
    Dim itembool, chkbool, smartcardbool As Boolean
    Dim TotalItemCount As Integer
    Dim gconnection As New GlobalClass
    Dim boolSearchResult, boolSearchNext, boolAddLess As Boolean
    Dim TALLYADDFLAG, TALLYUPDATEFLAG, TALLYCANCELFLAG As Boolean
    Public pageno, pagesize As Integer
    Dim dr As DataRow
    Dim SerHttp As New MSXML2.ServerXMLHTTP30
    Dim xmlDom As New MSXML2.DOMDocument30
    Dim strRequestXML As String
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dtp_Todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TALLYPOSTINGTOTAL))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.dtp_Todate = New System.Windows.Forms.DateTimePicker
        Me.dtp_fromdate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Member Transfer"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(328, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(216, 48)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Member balanceTransfer"
        '
        'dtp_Todate
        '
        Me.dtp_Todate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Todate.Location = New System.Drawing.Point(576, 352)
        Me.dtp_Todate.Name = "dtp_Todate"
        Me.dtp_Todate.Size = New System.Drawing.Size(168, 26)
        Me.dtp_Todate.TabIndex = 2
        '
        'dtp_fromdate
        '
        Me.dtp_fromdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_fromdate.Location = New System.Drawing.Point(208, 352)
        Me.dtp_fromdate.Name = "dtp_fromdate"
        Me.dtp_fromdate.Size = New System.Drawing.Size(168, 26)
        Me.dtp_fromdate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FROM_DATE"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(456, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TO_DATE"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(592, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(216, 48)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Cash Bank Voucher Transfer"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(32, 112)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(216, 48)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Notes and  Journal Transfer"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(328, 112)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(216, 48)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Monthbill Transfer"
        '
        'TALLYPOSTING
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(960, 437)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_fromdate)
        Me.Controls.Add(Me.dtp_Todate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "TALLYPOSTING"
        Me.Text = "TALLYPOSTING"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myconnection As New ADODB.Connection
        Dim ssql As String
        Dim sval1 As Double
        Try
            myconnection.Open(gTallyDsn)

            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30

            Dim xmlDom As New MSXML2.DOMDocument30

            Dim strRequestXML, strRequestXML2 As String
            Dim strstring, sqlstring, MCODE, MNAME, LEDGER As String
            Dim i, rowi, ROWJJ As Integer
            Dim AMOUNT As Double
            strstring = "select membertype,typedesc from membertype "
            gconnection.getDataSet(strstring, "member")
            If gdataset.Tables("member").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("member").Rows.Count - 1
                    ssql = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Groups' where $Name='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(i).Item("TYPEDESC")))) & "'"
                    vfill.Open(ssql, myconnection)
                    If vfill.EOF Then
                        'strstring = "SELECT a.membertypecode as membertypecode,b.typedesc as typedesc,a.mcode as mcode,a.mname as mname,a.padd1 as padd1,a.padd2 as padd2,a.padd3 as padd3,a.pcity as pcity,a.pstate as pstate,a.ppin as ppin,a.pcountry as pcountry,a.pemail as pemail,a.pphone1 as pphone1, a.pphone2 as pphone2, a.pcell as pcell, a.creditlimit as creditlimit from membermaster a,membertype b WHERE  a.membertypecode=b.membertype"
                        strstring = "select membertype,typedesc from membertype where typedesc='" & Trim(gdataset.Tables("member").Rows(i).Item("TYPEDESC")) & "'"
                        gconnection.getDataSet(strstring, "membermaster")
                        If gdataset.Tables("membermaster").Rows.Count > 0 Then
                            strRequestXML = ""
                            strRequestXML = strRequestXML & "<ENVELOPE>"
                            strRequestXML = strRequestXML & "<HEADER>"
                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                            strRequestXML = strRequestXML & "</HEADER>"
                            strRequestXML = strRequestXML & "<BODY>"
                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                            strRequestXML = strRequestXML & "</STATICVARIABLES>"

                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                            strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"

                            strRequestXML = strRequestXML & "<GROUP NAME='" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("TYPEDESC")))) & "' ACTION='Create'>"
                            strRequestXML = strRequestXML & "<NAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("TYPEDESC")))) & "</NAME>"
                            strRequestXML = strRequestXML & "<PARENT>Sundry Debtors</PARENT>"
                            strRequestXML = strRequestXML & "<ISSUBLEDGER>No</ISSUBLEDGER>"
                            strRequestXML = strRequestXML & "<ISBILLWISEON>No</ISBILLWISEON>"
                            strRequestXML = strRequestXML & "<ISCOSTCENTRESON>No</ISCOSTCENTRESON>"
                            strRequestXML = strRequestXML & "</GROUP>"
                            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                            strRequestXML = strRequestXML & "</BODY>"
                            strRequestXML = strRequestXML & "</ENVELOPE>"

                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                            SerHttp.send(strRequestXML)
                        End If

                    End If
                    vfill.Close()
                Next

            End If
            strstring = "SELECT a.membertypecode as membertypecode,b.typedesc as typedesc,isnull(a.MCODE,'') as mcode,isnull(a.mname,'') as mname,isnull(a.contadd1,'') as padd1,isnull(a.contadd2,'') as padd2,isnull(a.contadd3,'') as padd3,isnull(a.contcity,'') as pcity,isnull(a.contstate,'') as pstate,isnull(a.contpin,'') as ppin,isnull(a.contcountry,'') as pcountry,isnull(a.contemail,'') as pemail,isnull(a.contphone1,'') as pphone1, isnull(a.contphone2,'') as pphone2, isnull(a.contcell,'') as pcell, isnull(a.creditlimit,0) as creditlimit from membermaster a,membertype b WHERE a.membertypecode=b.membertype"
            gconnection.getDataSet(strstring, "member")
            'gconnection.getDataSet(strstring, "member")
            If gdataset.Tables("member").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("member").Rows.Count - 1
                    ssql = "Select $Name,$ClosingBalance from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Ledger' where $$IsBelongsTo:$$GroupSundryDebtors and $Name=($Name='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(i).Item("mcode")))) & "' OR $Name='" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(i).Item("mname")))) & "')"
                    '" & Funapos(Funamp(Trim(gdataset.Tables("member").Rows(i).Item("mname")))) & "'"
                    vfill.Open(ssql, myconnection)
                    If vfill.EOF Then
                        strstring = "SELECT a.membertypecode as membertypecode,b.typedesc as typedesc,isnull(a.MCODE,'') as mcode,isnull(a.mname,'') as mname,isnull(a.contadd1,'') as padd1,isnull(a.contadd2,'') as padd2,isnull(a.contadd3,'') as padd3,isnull(a.contcity,'') as pcity,isnull(a.contstate,'') as pstate,isnull(a.contpin,'') as ppin,isnull(a.contcountry,'') as pcountry,isnull(a.contemail,'') as pemail,isnull(a.contphone1,'') as pphone1, isnull(a.contphone2,'') as pphone2, isnull(a.contcell,'') as pcell, isnull(a.creditlimit,0) as creditlimit from membermaster a,membertype b WHERE mcode='" & Trim(gdataset.Tables("member").Rows(i).Item("mcode")) & "' and a.membertypecode=b.membertype"
                        gconnection.getDataSet(strstring, "membermaster")
                        If gdataset.Tables("membermaster").Rows.Count > 0 Then
                            strRequestXML = ""
                            strRequestXML = strRequestXML & "<ENVELOPE>"
                            strRequestXML = strRequestXML & "<HEADER>"
                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                            strRequestXML = strRequestXML & "</HEADER>"
                            strRequestXML = strRequestXML & "<BODY>"
                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REPORTNAME>All Masters</REPORTNAME>"
                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                            strRequestXML = strRequestXML & "</STATICVARIABLES>"


                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                            strRequestXML = strRequestXML & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                            strRequestXML = strRequestXML & "<LEDGER NAME='" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "' ACTION='Create'>"
                            strRequestXML = strRequestXML & "<ADDRESS.LIST>"
                            strRequestXML = strRequestXML & "<ADDRESS1>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD1")))) & "</ADDRESS1>"
                            strRequestXML = strRequestXML & "<ADDRESS2>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD2")))) & "</ADDRESS2>"
                            strRequestXML = strRequestXML & "<ADDRESS3>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PADD3")))) & "</ADDRESS3>"
                            strRequestXML = strRequestXML & "<ADDRESS4>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PCITY")))) & "</ADDRESS4>"
                            strRequestXML = strRequestXML & "<ADDRESS5>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PSTATE")))) & "</ADDRESS5>"

                            strRequestXML = strRequestXML & "</ADDRESS.LIST>"

                            strRequestXML = strRequestXML & "<ADDITIONALNAME.LIST>"
                            strRequestXML = strRequestXML & "<ADDITIONALNAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MCODE")))) & "</ADDITIONALNAME>"
                            strRequestXML = strRequestXML & "</ADDITIONALNAME.LIST>"

                            strRequestXML = strRequestXML & "<EMAIL>info@databasesoftware.in</EMAIL>"
                            strRequestXML = strRequestXML & "<PINCODE>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("PPIN")))) & "</PINCODE>"
                            strRequestXML = strRequestXML & "<PARENT>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("typedesc")))) & " </PARENT>"
                            strRequestXML = strRequestXML & "<LEDGERPHONE>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pphone1")))) & " </LEDGERPHONE>"
                            strRequestXML = strRequestXML & "<LEDGERFAX>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pphone2")))) & " </LEDGERFAX>"
                            strRequestXML = strRequestXML & "<LEDGERCONTACT>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("pcell")))) & "</LEDGERCONTACT>"
                            strRequestXML = strRequestXML & "<CREDITLIMIT> " & Trim(gdataset.Tables("membermaster").Rows(0).Item("CREDITLIMIT")) & "</CREDITLIMIT>"
                            strRequestXML = strRequestXML & "<LANGUAGENAME.LIST>"
                            strRequestXML = strRequestXML & "<NAME.LIST>"

                            strRequestXML = strRequestXML & "  <NAME>" & Funapos(Funamp(Trim(gdataset.Tables("membermaster").Rows(0).Item("MNAME")))) & "</NAME>"
                            strRequestXML = strRequestXML & "  </NAME.LIST>"
                            'strRequestXML = strRequestXML & " <DSPOpAmt>2601.95</DSPOpAmt>"
                            strRequestXML = strRequestXML & "  <LANGUAGEID>1033</LANGUAGEID>"
                            strRequestXML = strRequestXML & "  </LANGUAGENAME.LIST>"
                            strRequestXML = strRequestXML & "  </LEDGER>"
                            strRequestXML = strRequestXML & "  </TALLYMESSAGE>"
                            strRequestXML = strRequestXML & "</REQUESTDATA>"
                            strRequestXML = strRequestXML & "</IMPORTDATA>"
                            strRequestXML = strRequestXML & "</BODY>"
                            strRequestXML = strRequestXML & "</ENVELOPE>"

                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                            SerHttp.send(strRequestXML)

                        End If
                    End If
                    vfill.Close()
                Next

            End If
            'Select Case Mid(CStr(cmd_add.Text), 1, 1)
            '    Case "A"
            '        TALLYADDFLAG = True
            '    Case Else
            '        TALLYUPDATEFLAG = True
            'End Select

            MsgBox("Successcully Created", vbInformation, "KOT Create")
        Catch ex As Exception
            'Select Case Mid(CStr(cmd_add.Text), 1, 1)
            '    Case "A"
            '        TALLYADDFLAG = False
            '    Case Else
            '        TALLYUPDATEFLAG = False
            'End Select
            MessageBox.Show("Check The Error : Tally " & ex.Message, gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim myconnection As New ADODB.Connection
        Dim ssql As String
        Dim sval1 As Double
        Try

            myconnection.Open(gTallyDsn)

            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30

            Dim xmlDom As New MSXML2.DOMDocument30

            Dim strRequestXML, strRequestXML2 As String
            Dim strstring, sqlstring, MCODE, MNAME, LEDGER As String
            Dim i, rowi, ROWJJ As Integer
            Dim AMOUNT As Double
            ssql = " select slcode as mcode,isnull(sldesc,'')+'['+isnull(slcode,'')+']' as mname ,isnull(balance,0) as AMOUNT,'dr' as crdr from tally3 where balance>0"
            ssql = ssql & "union all  "
            ssql = ssql & "select slcode as mcode,isnull(sldesc,'')+'['+isnull(slcode,'')+']' as mname ,isnull(balance,0)*-1 as AMOUNT,'cr' as crdr from tally3 where balance<0"
            gconnection.getDataSet(ssql, "acc")
            'gconnection.getDataSet(sqlstring, "TALLYMST")
            strRequestXML = ""
            If gdataset.Tables("acc").Rows.Count > 0 Then
                For rowi = 0 To gdataset.Tables("acc").Rows.Count - 1
                    With gdataset.Tables("acc").Rows(rowi)
                        MCODE = .Item("MCODE")
                        MNAME = .Item("MNAME")
                        AMOUNT = .Item("AMOUNT")
                        ROWJJ = 0
                        strRequestXML = ""
                        strRequestXML = strRequestXML & "<ENVELOPE>"
                        strRequestXML = strRequestXML & "<HEADER>"
                        strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                        strRequestXML = strRequestXML & "</HEADER>"
                        strRequestXML = strRequestXML & "<BODY>"
                        strRequestXML = strRequestXML & "<IMPORTDATA>"
                        strRequestXML = strRequestXML & "<REQUESTDESC>"
                        strRequestXML = strRequestXML & "<REPORTNAME>Vouchers</REPORTNAME>"
                        strRequestXML = strRequestXML & "<STATICVARIABLES>"
                        strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                        strRequestXML = strRequestXML & "</STATICVARIABLES>"
                        strRequestXML = strRequestXML & "</REQUESTDESC>"
                        strRequestXML = strRequestXML & "<REQUESTDATA>"
                        strRequestXML = strRequestXML & "<TALLYMESSAGE>"
                        strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='journal' ACTION='Create'>"       ' for create /
                        ' update / delete
                        strRequestXML = strRequestXML & "<DATE>" & Format(dtp_Todate.Value, "yyyyMMdd") & "</DATE>" ' kotdate
                        strRequestXML = strRequestXML & "<NARRATION>" & Format(dtp_Todate.Value, "MMM yyyy") & " Bill</NARRATION>"
                        strRequestXML = strRequestXML & "<VOUCHERTYPENAME>journal</VOUCHERTYPENAME>"
                        strRequestXML = strRequestXML & "<VOUCHERNUMBER>" & Trim(rowi + 1) & Format(dtp_Todate.Value, "/MMM-yyyy") & "</VOUCHERNUMBER>"
                        strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(MNAME)) & "</PARTYLEDGERNAME>"
                        strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(MNAME)) & "</PARTYNAME>"
                        strRequestXML = strRequestXML & "<EFFECTIVEDATE>" & Format(dtp_Todate.Value, "yyyyMMdd") & "</EFFECTIVEDATE>" ' kotdate

                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(MNAME)) & "</LEDGERNAME>"
                        strRequestXML = strRequestXML & "<GSTCLASS/>"
                        strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                        strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                        strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                        strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                        If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "dr" Then
                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        Else
                            strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        End If
                        strRequestXML = strRequestXML & "<BILLALLOCATIONS.LIST>"
                        strRequestXML = strRequestXML & "<NAME>journal</NAME>"
                        strRequestXML = strRequestXML & "<BILLCREDITPERIOD>45 Days</BILLCREDITPERIOD>"
                        strRequestXML = strRequestXML & "<BILLTYPE>New Ref</BILLTYPE>"
                        'strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("KOTHDR_AMT").Rows(0).Item("BILLAMT")) & "</AMOUNT>"    'net amount
                        'strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "dr" Then
                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        Else
                            strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        End If
                        strRequestXML = strRequestXML & "</BILLALLOCATIONS.LIST>"
                        strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"
                        LEDGER = ""
                        AMOUNT = 0
                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                        strRequestXML = strRequestXML & "<LEDGERNAME>member'ssundrydebtors</LEDGERNAME>"
                        strRequestXML = strRequestXML & "<GSTCLASS/>"
                        strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                        strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                        strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                        strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>"
                        If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "cr" Then
                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        Else
                            strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        End If
                        strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"


                        strRequestXML = strRequestXML & "</VOUCHER>"
                        strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                        strRequestXML = strRequestXML & "</REQUESTDATA>"
                        strRequestXML = strRequestXML & "</IMPORTDATA>"
                        strRequestXML = strRequestXML & "</BODY>"
                        strRequestXML = strRequestXML & "</ENVELOPE>"
                        SerHttp.open("POST", gTallyOdbc & gTallyPort)
                        SerHttp.send(strRequestXML)
                        Dim resstr, errorstr, j
                        Dim errmsg As Boolean = False
                        resstr = SerHttp.responseText
                        xmlDom.loadXML(resstr)
                    End With
                Next
            End If
            MsgBox("Successcully Created", vbInformation, "member balance Create")
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim myconnection As New ADODB.Connection
        Dim ssql As String
        Dim sval1 As Double
        Try
            myconnection.Open(gTallyDsn)

            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30

            Dim xmlDom As New MSXML2.DOMDocument30

            Dim strRequestXML, strRequestXML2, voucherno, deb As String
            Dim strstring, sqlstring, MCODE, MNAME, LEDGER As String
            Dim i, rowi, ROWJJ As Integer
            Dim AMOUNT As Double
            ssql = " select voucherno,voucherdate,accountcode,acdesc,slcode as mcode,isnull(sldesc,'') as mname ,isnull(AMOUNT,0) as AMOUNT, crdr ,instrumentno from cashbank where voucherdate between '" & Format(dtp_fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' order by voucherno,crdr"
            'ssql = ssql & "union all  "
            'ssql = ssql & "select slcode as mcode,isnull(sldesc,'')+'['+isnull(slcode,'')+']' as mname ,isnull(balance,0)*-1 as AMOUNT,'cr' as crdr from tally3 where balance<0"
            gconnection.getDataSet(ssql, "acc")
            'gconnection.getDataSet(sqlstring, "TALLYMST")
            strRequestXML = ""
            If gdataset.Tables("acc").Rows.Count > 0 Then
                For rowi = 0 To gdataset.Tables("acc").Rows.Count - 1
                    With gdataset.Tables("acc").Rows(rowi)

                        If voucherno <> .Item("voucherno") Then
                            If strRequestXML <> "" Then
                                strRequestXML = strRequestXML & "</VOUCHER>"
                                strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                strRequestXML = strRequestXML & "</REQUESTDATA>"
                                strRequestXML = strRequestXML & "</IMPORTDATA>"
                                strRequestXML = strRequestXML & "</BODY>"
                                strRequestXML = strRequestXML & "</ENVELOPE>"
                                SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                SerHttp.send(strRequestXML)
                                Dim resstr, errorstr, j
                                Dim errmsg As Boolean = False
                                resstr = SerHttp.responseText
                                xmlDom.loadXML(resstr)
                                strRequestXML = ""
                            End If
                            voucherno = .Item("voucherno")
                            If .Item("mcode") <> "" Then
                                MCODE = .Item("MCODE")
                                MNAME = .Item("MNAME")
                            Else
                                MCODE = .Item("accountcode")
                                MNAME = .Item("acdesc")
                            End If
                            AMOUNT = .Item("AMOUNT")
                            ROWJJ = 0
                            strRequestXML = strRequestXML & "<ENVELOPE>"
                            strRequestXML = strRequestXML & "<HEADER>"
                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                            strRequestXML = strRequestXML & "</HEADER>"
                            strRequestXML = strRequestXML & "<BODY>"
                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REPORTNAME>Vouchers</REPORTNAME>"
                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                            strRequestXML = strRequestXML & "</STATICVARIABLES>"
                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                            strRequestXML = strRequestXML & "<TALLYMESSAGE>"
                            strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='Reciept' ACTION='Create'>"       ' for create /
                            ' update / delete
                            strRequestXML = strRequestXML & "<DATE>" & Format(dtp_Todate.Value, "yyyyMMdd") & "</DATE>" ' kotdate
                            strRequestXML = strRequestXML & "<NARRATION>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("instrumentno")) & "</NARRATION>"
                            strRequestXML = strRequestXML & "<VOUCHERTYPENAME>Receipt</VOUCHERTYPENAME>"
                            strRequestXML = strRequestXML & "<VOUCHERNUMBER>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("voucherno")) & "</VOUCHERNUMBER>"
                            strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(MNAME)) & "</PARTYLEDGERNAME>"
                            strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(MNAME)) & "</PARTYNAME>"
                            strRequestXML = strRequestXML & "<EFFECTIVEDATE>" & Format(CDate(gdataset.Tables("acc").Rows(rowi).Item("voucherdate")), "yyyyMMdd") & "</EFFECTIVEDATE>"  ' kotdate

                        End If

                        voucherno = .Item("voucherno")
                        If .Item("mcode") <> "" Then
                            MCODE = .Item("MCODE")
                            MNAME = .Item("MNAME")
                        Else
                            MCODE = .Item("accountcode")
                            MNAME = .Item("acdesc")
                        End If
                        AMOUNT = .Item("AMOUNT")
                        ROWJJ = 0


                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(MNAME)) & "</LEDGERNAME>"
                        strRequestXML = strRequestXML & "<GSTCLASS/>"
                        strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                        strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                        strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                        strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                        If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "dr" Then
                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        Else
                            strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        End If
                        strRequestXML = strRequestXML & "<BILLALLOCATIONS.LIST>"
                        strRequestXML = strRequestXML & "<NAME>Receipt</NAME>"
                        strRequestXML = strRequestXML & "<BILLCREDITPERIOD>45 Days</BILLCREDITPERIOD>"
                        strRequestXML = strRequestXML & "<BILLTYPE>New Ref</BILLTYPE>"
                        'strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("KOTHDR_AMT").Rows(0).Item("BILLAMT")) & "</AMOUNT>"    'net amount
                        'strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "dr" Then
                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        Else
                            strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        End If
                        strRequestXML = strRequestXML & "</BILLALLOCATIONS.LIST>"
                        strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"
                        LEDGER = ""
                        AMOUNT = 0
                        'strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                        'strRequestXML = strRequestXML & "<LEDGERNAME>member'ssundrydebtors</LEDGERNAME>"
                        'strRequestXML = strRequestXML & "<GSTCLASS/>"
                        'strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                        'strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                        'strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                        'strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>"
                        'If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "cr" Then
                        '    strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        'Else
                        '    strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        'End If
                        'strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"



                    End With
                Next
            End If
            ssql = "update journalentry set posttallyflag='y' where voucherno in(select voucherno from cashbank) and voucherdate between '" & Format(dtp_fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
            gconnection.dataOperation(2, ssql, "rau")
            MsgBox("Successcully Created", vbInformation, "member balance Create")
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim myconnection As New ADODB.Connection
        Dim ssql As String
        Dim sval1 As Double
        Try
            myconnection.Open(gTallyDsn)

            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30

            Dim xmlDom As New MSXML2.DOMDocument30

            Dim strRequestXML, strRequestXML2, voucherno, deb As String
            Dim strstring, sqlstring, MCODE, MNAME, LEDGER As String
            Dim i, rowi, ROWJJ As Integer
            Dim AMOUNT As Double
            ssql = " select voucherno,voucherdate,accountcode,acdesc,slcode as mcode,isnull(sldesc,'')+'['+isnull(slcode,'')+']' as mname ,isnull(AMOUNT,0) as AMOUNT, crdr ,instrumentno from notes where voucherdate between '" & Format(dtp_fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' order by voucherno,crdr"
            'ssql = ssql & "union all  "
            'ssql = ssql & "select slcode as mcode,isnull(sldesc,'')+'['+isnull(slcode,'')+']' as mname ,isnull(balance,0)*-1 as AMOUNT,'cr' as crdr from tally3 where balance<0"
            gconnection.getDataSet(ssql, "acc")
            'gconnection.getDataSet(sqlstring, "TALLYMST")
            strRequestXML = ""
            If gdataset.Tables("acc").Rows.Count > 0 Then
                For rowi = 0 To gdataset.Tables("acc").Rows.Count - 1
                    With gdataset.Tables("acc").Rows(rowi)

                        If voucherno <> .Item("voucherno") Then
                            If strRequestXML <> "" Then
                                strRequestXML = strRequestXML & "</VOUCHER>"
                                strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                strRequestXML = strRequestXML & "</REQUESTDATA>"
                                strRequestXML = strRequestXML & "</IMPORTDATA>"
                                strRequestXML = strRequestXML & "</BODY>"
                                strRequestXML = strRequestXML & "</ENVELOPE>"
                                SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                SerHttp.send(strRequestXML)
                                Dim resstr, errorstr, j
                                Dim errmsg As Boolean = False
                                resstr = SerHttp.responseText
                                xmlDom.loadXML(resstr)
                                strRequestXML = ""
                            End If
                            voucherno = .Item("voucherno")
                            If .Item("mcode") <> "" Then
                                MCODE = .Item("MCODE")
                                MNAME = .Item("MNAME")
                            Else
                                MCODE = .Item("accountcode")
                                MNAME = .Item("acdesc")
                            End If
                            AMOUNT = .Item("AMOUNT")
                            ROWJJ = 0
                            strRequestXML = strRequestXML & "<ENVELOPE>"
                            strRequestXML = strRequestXML & "<HEADER>"
                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                            strRequestXML = strRequestXML & "</HEADER>"
                            strRequestXML = strRequestXML & "<BODY>"
                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REPORTNAME>Vouchers</REPORTNAME>"
                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                            strRequestXML = strRequestXML & "</STATICVARIABLES>"
                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                            strRequestXML = strRequestXML & "<TALLYMESSAGE>"
                            strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='journal' ACTION='Create'>"       ' for create /
                            ' update / delete
                            strRequestXML = strRequestXML & "<DATE>" & Format(dtp_Todate.Value, "yyyyMMdd") & "</DATE>" ' kotdate
                            strRequestXML = strRequestXML & "<NARRATION>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("instrumentno")) & "</NARRATION>"
                            strRequestXML = strRequestXML & "<VOUCHERTYPENAME>journal</VOUCHERTYPENAME>"
                            strRequestXML = strRequestXML & "<VOUCHERNUMBER>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("voucherno")) & "</VOUCHERNUMBER>"
                            strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(MNAME)) & "</PARTYLEDGERNAME>"
                            strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(MNAME)) & "</PARTYNAME>"
                            strRequestXML = strRequestXML & "<EFFECTIVEDATE>" & Format(CDate(gdataset.Tables("acc").Rows(rowi).Item("voucherdate")), "yyyyMMdd") & "</EFFECTIVEDATE>"  ' kotdate

                        End If

                        voucherno = .Item("voucherno")
                        If .Item("mcode") <> "" Then
                            MCODE = .Item("MCODE")
                            MNAME = .Item("MNAME")
                        Else
                            MCODE = .Item("accountcode")
                            MNAME = .Item("acdesc")
                        End If
                        AMOUNT = .Item("AMOUNT")
                        ROWJJ = 0


                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(MNAME)) & "</LEDGERNAME>"
                        strRequestXML = strRequestXML & "<GSTCLASS/>"
                        strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                        strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                        strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                        strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                        If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "dr" Then
                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        Else
                            strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        End If
                        strRequestXML = strRequestXML & "<BILLALLOCATIONS.LIST>"
                        strRequestXML = strRequestXML & "<NAME>journal</NAME>"
                        strRequestXML = strRequestXML & "<BILLCREDITPERIOD>45 Days</BILLCREDITPERIOD>"
                        strRequestXML = strRequestXML & "<BILLTYPE>New Ref</BILLTYPE>"
                        'strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("KOTHDR_AMT").Rows(0).Item("BILLAMT")) & "</AMOUNT>"    'net amount
                        'strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "dr" Then
                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        Else
                            strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        End If
                        strRequestXML = strRequestXML & "</BILLALLOCATIONS.LIST>"
                        strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"
                        LEDGER = ""
                        AMOUNT = 0
                        'strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                        'strRequestXML = strRequestXML & "<LEDGERNAME>member'ssundrydebtors</LEDGERNAME>"
                        'strRequestXML = strRequestXML & "<GSTCLASS/>"
                        'strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
                        'strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                        'strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                        'strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>"
                        'If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "cr" Then
                        '    strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        'Else
                        '    strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        'End If
                        'strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"



                    End With
                Next
            End If
            ssql = "update journalentry set posttallyflag='y' where voucherno in(select voucherno from notes) and voucherdate between '" & Format(dtp_fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "'"
            gconnection.dataOperation(2, ssql, "rau")
            MsgBox("Successcully Created", vbInformation, "member balance Create")
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim myconnection As New ADODB.Connection
        Dim ssql As String
        Dim sval1 As Double
        Try
            ssql = "exec MONTHLYACCOUNTSPOSTINGtally " & Month(dtp_Todate.Value) & ", '" & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
            gconnection.ExcuteStoreProcedure(ssql)

            myconnection.Open(gTallyDsn)

            Dim vfill As New ADODB.Recordset
            Dim SerHttp As New MSXML2.ServerXMLHTTP30

            Dim xmlDom As New MSXML2.DOMDocument30

            Dim strRequestXML, strRequestXML2, voucherno As String
            Dim strstring, sqlstring, MCODE, MNAME, LEDGER As String
            Dim i, rowi, ROWJJ As Integer
            Dim AMOUNT As Double
            ' FOR GROUP
            ''==========================================================================
            ssql = " select voucherno,voucherdate,accountcode,acdesc,slcode as mcode,isnull(sldesc,'')+'['+isnull(slcode,'')+']' as mname ,isnull(AMOUNT,0) as AMOUNT, crdr  from ucmonthbill_view where voucherdate between '" & Format(dtp_fromdate.Value, "dd/MMM/yyyy") & "' and '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' order by voucherno,crdr"
            'ssql = ssql & "union all  "
            'ssql = ssql & "select slcode as mcode,isnull(sldesc,'')+'['+isnull(slcode,'')+']' as mname ,isnull(balance,0)*-1 as AMOUNT,'cr' as crdr from tally3 where balance<0"
            gconnection.getDataSet(ssql, "acc")
            'gconnection.getDataSet(sqlstring, "TALLYMST")
            strRequestXML = ""
            If gdataset.Tables("acc").Rows.Count > 0 Then
                For rowi = 0 To gdataset.Tables("acc").Rows.Count - 1
                    With gdataset.Tables("acc").Rows(rowi)

                        If voucherno <> .Item("voucherno") Then
                            If strRequestXML <> "" Then
                                strRequestXML = strRequestXML & "</VOUCHER>"
                                strRequestXML = strRequestXML & "</TALLYMESSAGE>"
                                strRequestXML = strRequestXML & "</REQUESTDATA>"
                                strRequestXML = strRequestXML & "</IMPORTDATA>"
                                strRequestXML = strRequestXML & "</BODY>"
                                strRequestXML = strRequestXML & "</ENVELOPE>"
                                SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                SerHttp.send(strRequestXML)
                                Dim resstr, errorstr, j
                                Dim errmsg As Boolean = False
                                resstr = SerHttp.responseText
                                xmlDom.loadXML(resstr)
                                strRequestXML = ""
                            End If
                            voucherno = .Item("voucherno")
                            If .Item("mcode") <> "" Then
                                MCODE = .Item("MCODE")
                                MNAME = .Item("MNAME")
                            Else
                                MCODE = .Item("accountcode")
                                MNAME = .Item("acdesc")
                            End If



                            If MNAME = "LAWN TENIIS SUBSCRIPTION" Then
                                MNAME = "TENNIS SUBSCRIPTION"
                            End If
                            If MNAME = "MEMBERS SUBSCRIPTION" Then
                                MNAME = "MEMBER'S SUBSCRIPTION"
                            End If
                            If MNAME = "MISC INCOME (GH)" Then
                                MNAME = "MISC.INCOME(GH)"
                            End If
                            If MNAME = "SALE OF ICECREAM" Then
                                MNAME = "SALE OF ICECREAMS"
                            End If
                            If MNAME = "SALE OF LIQUEUR(7C)" Then
                                MNAME = "SALE OF liquor"
                            End If
                            If MNAME = "SALE OF LIQUEUR(9I)" Then
                                MNAME = "SALE OF liquor"
                            End If
                            If MNAME = "SALE OF RESTAURANT(BARBEY CUBE)" Then
                                MNAME = "SALE OF restaurant items"
                            End If
                            If MNAME = "SALE OF RESTAURANT(CAKE COUNTER)" Then
                                MNAME = "SALE OF restaurant items"
                            End If
                            If MNAME = "SALE OF RESTURANT ITEMS(KITCHEN COUNTER)" Then
                                MNAME = "SALE OF restaurant items"
                            End If
                            If MNAME = "SALE OF SOFTDRINKS" Then
                                MNAME = "SALE OF SOFT DRINKS"
                            End If
                            If MNAME = "SALE SUPER BOWL" Then
                                MNAME = "income from bowling alley"
                            End If
                            If MNAME = "VAT" Then
                                MNAME = "VAT COLLECTED"
                            End If
                            ''=======================================================================================
                            ssql = "Select $Name,$ClosingBalance from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Ledger' where  $Name='" & Funapos(Funamp(Trim(MNAME))) & "'"
                            vfill.Open(ssql, myconnection)
                            If vfill.EOF Then
                                strRequestXML2 = ""
                                strRequestXML2 = strRequestXML2 & "<ENVELOPE>"
                                strRequestXML2 = strRequestXML2 & "<HEADER>"
                                strRequestXML2 = strRequestXML2 & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                                strRequestXML2 = strRequestXML2 & "</HEADER>"
                                strRequestXML2 = strRequestXML2 & "<BODY>"
                                strRequestXML2 = strRequestXML2 & "<IMPORTDATA>"
                                strRequestXML2 = strRequestXML2 & "<REQUESTDESC>"
                                strRequestXML2 = strRequestXML2 & "<REPORTNAME>All Masters</REPORTNAME>"
                                strRequestXML2 = strRequestXML2 & "<STATICVARIABLES>"
                                strRequestXML2 = strRequestXML2 & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                                strRequestXML2 = strRequestXML2 & "</STATICVARIABLES>"


                                strRequestXML2 = strRequestXML2 & "</REQUESTDESC>"
                                strRequestXML2 = strRequestXML2 & "<REQUESTDATA>"
                                strRequestXML2 = strRequestXML2 & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                                strRequestXML2 = strRequestXML2 & "<GROUP NAME='incomefrommembers'>"
                                strRequestXML2 = strRequestXML2 & "<NAME>incomefrommembers</NAME>"
                                strRequestXML2 = strRequestXML2 & "<PARENT>incomefrommembers</PARENT>"
                                strRequestXML2 = strRequestXML2 & "<LEDGER NAME='" & Funapos(Funamp(Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")))) & "' ACTION='Create'>"
                                strRequestXML2 = strRequestXML2 & "<ADDITIONALNAME.LIST>"
                                strRequestXML2 = strRequestXML2 & "<ADDITIONALNAME>" & Funapos(Funamp(Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")))) & "</ADDITIONALNAME>"
                                strRequestXML2 = strRequestXML2 & "</ADDITIONALNAME.LIST>"

                                strRequestXML2 = strRequestXML2 & "<LANGUAGENAME.LIST>"
                                strRequestXML2 = strRequestXML2 & "<NAME.LIST>"

                                strRequestXML2 = strRequestXML2 & "  <NAME>" & Funapos(Funamp(Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")))) & "</NAME>"
                                strRequestXML2 = strRequestXML2 & "  </NAME.LIST>"
                                'strRequestXML2 = strRequestXML2 & " <DSPOpAmt>2601.95</DSPOpAmt>"
                                strRequestXML2 = strRequestXML2 & "  <LANGUAGEID>1033</LANGUAGEID>"
                                strRequestXML2 = strRequestXML2 & "  </LANGUAGENAME.LIST>"
                                strRequestXML2 = strRequestXML2 & "  </LEDGER>"
                                strRequestXML2 = strRequestXML2 & "  </TALLYMESSAGE>"
                                strRequestXML2 = strRequestXML2 & "</REQUESTDATA>"
                                strRequestXML2 = strRequestXML2 & "</IMPORTDATA>"
                                strRequestXML2 = strRequestXML2 & "</BODY>"
                                strRequestXML2 = strRequestXML2 & "</ENVELOPE>"

                                SerHttp.open("POST", gTallyOdbc & gTallyPort)
                                SerHttp.send(strRequestXML2)

                                '    End If
                                'End If

                            End If
                            AMOUNT = .Item("AMOUNT")
                            ROWJJ = 0
                            strRequestXML = strRequestXML & "<ENVELOPE>"
                            strRequestXML = strRequestXML & "<HEADER>"
                            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                            strRequestXML = strRequestXML & "</HEADER>"
                            strRequestXML = strRequestXML & "<BODY>"
                            strRequestXML = strRequestXML & "<IMPORTDATA>"
                            strRequestXML = strRequestXML & "<REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REPORTNAME>Vouchers</REPORTNAME>"
                            strRequestXML = strRequestXML & "<STATICVARIABLES>"
                            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                            strRequestXML = strRequestXML & "</STATICVARIABLES>"
                            strRequestXML = strRequestXML & "</REQUESTDESC>"
                            strRequestXML = strRequestXML & "<REQUESTDATA>"
                            strRequestXML = strRequestXML & "<TALLYMESSAGE>"
                            strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='journal' ACTION='Create'>"       ' for create /
                            ' update / delete
                            strRequestXML = strRequestXML & "<DATE>" & Format(dtp_Todate.Value, "yyyyMMdd") & "</DATE>" ' kotdate
                            strRequestXML = strRequestXML & "<NARRATION>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("instrumentno")) & "</NARRATION>"
                            strRequestXML = strRequestXML & "<VOUCHERTYPENAME>journal</VOUCHERTYPENAME>"
                            strRequestXML = strRequestXML & "<VOUCHERNUMBER>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("voucherno")) & "</VOUCHERNUMBER>"
                            strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(MNAME)) & "</PARTYLEDGERNAME>"
                            strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(MNAME)) & "</PARTYNAME>"
                            strRequestXML = strRequestXML & "<EFFECTIVEDATE>" & Format(CDate(gdataset.Tables("acc").Rows(rowi).Item("voucherdate")), "yyyyMMdd") & "</EFFECTIVEDATE>"  ' kotdate

                        End If

                        voucherno = .Item("voucherno")
                        If .Item("mcode") <> "" Then
                            MCODE = .Item("MCODE")
                            MNAME = .Item("MNAME")
                        Else
                            MCODE = .Item("accountcode")
                            MNAME = .Item("acdesc")
                        End If
                        AMOUNT = .Item("AMOUNT")
                        ROWJJ = 0
                        If MNAME = "LAWN TENIIS SUBSCRIPTION" Then
                            MNAME = "TENNIS SUBSCRIPTION"
                        End If
                        If MNAME = "MEMBERS SUBSCRIPTION" Then
                            MNAME = "MEMBER'S SUBSCRIPTION"
                        End If
                        If MNAME = "MISC INCOME (GH)" Then
                            MNAME = "MISC.INCOME(GH)"
                        End If
                        If MNAME = "SALE OF ICECREAM" Then
                            MNAME = "SALE OF ICECREAMS"
                        End If
                        If MNAME = "SALE OF LIQUEUR(7C)" Then
                            MNAME = "SALE OF liquor"
                        End If
                        If MNAME = "SALE OF LIQUEUR(9I)" Then
                            MNAME = "SALE OF liquor"
                        End If
                        If MNAME = "SALE OF RESTAURANT(BARBEY CUBE)" Then
                            MNAME = "SALE OF restaurant items"
                        End If
                        If MNAME = "SALE OF RESTAURANT(CAKE COUNTER)" Then
                            MNAME = "SALE OF restaurant items"
                        End If
                        If MNAME = "SALE OF RESTURANT ITEMS(KITCHEN COUNTER)" Then
                            MNAME = "SALE OF restaurant items"
                        End If
                        If MNAME = "SALE OF SOFTDRINKS" Then
                            MNAME = "SALE OF SOFT DRINKS"
                        End If
                        If MNAME = "SALE SUPER BOWL" Then
                            MNAME = "income from bowling alley"
                        End If
                        If MNAME = "VAT" Then
                            MNAME = "VAT COLLECTED"
                        End If
                        ''=======================================================================================
                        ssql = "Select $Name,$ClosingBalance from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Ledger' where  $Name='" & Funapos(Funamp(Trim(MNAME))) & "'"
                        vfill.Open(ssql, myconnection)
                        If vfill.EOF Then
                            strRequestXML2 = ""
                            strRequestXML2 = strRequestXML2 & "<ENVELOPE>"
                            strRequestXML2 = strRequestXML2 & "<HEADER>"
                            strRequestXML2 = strRequestXML2 & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
                            strRequestXML2 = strRequestXML2 & "</HEADER>"
                            strRequestXML2 = strRequestXML2 & "<BODY>"
                            strRequestXML2 = strRequestXML2 & "<IMPORTDATA>"
                            strRequestXML2 = strRequestXML2 & "<REQUESTDESC>"
                            strRequestXML2 = strRequestXML2 & "<REPORTNAME>All Masters</REPORTNAME>"
                            strRequestXML2 = strRequestXML2 & "<STATICVARIABLES>"
                            strRequestXML2 = strRequestXML2 & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
                            strRequestXML2 = strRequestXML2 & "</STATICVARIABLES>"


                            strRequestXML2 = strRequestXML2 & "</REQUESTDESC>"
                            strRequestXML2 = strRequestXML2 & "<REQUESTDATA>"
                            strRequestXML2 = strRequestXML2 & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
                            strRequestXML2 = strRequestXML2 & "<GROUP NAME='incomefrommembers'>"
                            strRequestXML2 = strRequestXML2 & "<NAME>incomefrommembers</NAME>"
                            strRequestXML2 = strRequestXML2 & "<PARENT>incomefrommembers</PARENT>"
                            strRequestXML2 = strRequestXML2 & "<LEDGER NAME='" & Funapos(Funamp(Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")))) & "' ACTION='Create'>"
                            strRequestXML2 = strRequestXML2 & "<ADDITIONALNAME.LIST>"
                            strRequestXML2 = strRequestXML2 & "<ADDITIONALNAME>" & Funapos(Funamp(Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")))) & "</ADDITIONALNAME>"
                            strRequestXML2 = strRequestXML2 & "</ADDITIONALNAME.LIST>"

                            strRequestXML2 = strRequestXML2 & "<LANGUAGENAME.LIST>"
                            strRequestXML2 = strRequestXML2 & "<NAME.LIST>"

                            strRequestXML2 = strRequestXML2 & "  <NAME>" & Funapos(Funamp(Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")))) & "</NAME>"
                            strRequestXML2 = strRequestXML2 & "  </NAME.LIST>"
                            'strRequestXML2 = strRequestXML2 & " <DSPOpAmt>2601.95</DSPOpAmt>"
                            strRequestXML2 = strRequestXML2 & "  <LANGUAGEID>1033</LANGUAGEID>"
                            strRequestXML2 = strRequestXML2 & "  </LANGUAGENAME.LIST>"
                            strRequestXML2 = strRequestXML2 & "  </LEDGER>"
                            strRequestXML2 = strRequestXML2 & "  </TALLYMESSAGE>"
                            strRequestXML2 = strRequestXML2 & "</REQUESTDATA>"
                            strRequestXML2 = strRequestXML2 & "</IMPORTDATA>"
                            strRequestXML2 = strRequestXML2 & "</BODY>"
                            strRequestXML2 = strRequestXML2 & "</ENVELOPE>"

                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
                            SerHttp.send(strRequestXML2)

                            '    End If
                            'End If

                        End If

                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(MNAME)) & "</LEDGERNAME>"
                        strRequestXML = strRequestXML & "<GSTCLASS/>"
                        strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
                        strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
                        strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
                        strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
                        If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "dr" Then
                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        Else
                            strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        End If
                        strRequestXML = strRequestXML & "<BILLALLOCATIONS.LIST>"
                        strRequestXML = strRequestXML & "<NAME>journal</NAME>"
                        strRequestXML = strRequestXML & "<BILLCREDITPERIOD>45 Days</BILLCREDITPERIOD>"
                        strRequestXML = strRequestXML & "<BILLTYPE>New Ref</BILLTYPE>"
                        If gdataset.Tables("acc").Rows(rowi).Item("crdr") = "dr" Then
                            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        Else
                            strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("acc").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
                        End If
                        strRequestXML = strRequestXML & "</BILLALLOCATIONS.LIST>"
                        strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"
                        LEDGER = ""
                        AMOUNT = 0


                    End With
                Next
            End If
            ssql = "update monthbill set tallypost='y' where monthno=" & Month(dtp_fromdate.Value) & ""
            gconnection.dataOperation(2, ssql, "rau")
            'sqlstring = "SELECT A.MCODE AS MCODE,A.MNAME AS MNAME,ISNULL(SUM(ISNULL(A.amount,0)),0) AS AMOUNT FROM ucmonthbill_view A WHERE A.KOTDATE BETWEEN '" & Format(dtp_fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' and mname<>'[]' GROUP BY A.MCODE,A.MNAME ORDER BY A.MCODE"
            'gconnection.getDataSet(sqlstring, "TALLYMST")
            'If gdataset.Tables("TALLYMST").Rows.Count > 0 Then
            '    For rowi = 0 To gdataset.Tables("TALLYMST").Rows.Count - 1
            '        With gdataset.Tables("TALLYMST").Rows(rowi)
            '            MCODE = .Item("MCODE")
            '            MNAME = .Item("MNAME")
            '            AMOUNT = .Item("AMOUNT")
            '            'for MONTH BILL create
            '            ROWJJ = 0

            '            strRequestXML = ""
            '            strRequestXML = strRequestXML & "<ENVELOPE>"
            '            strRequestXML = strRequestXML & "<HEADER>"
            '            strRequestXML = strRequestXML & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
            '            strRequestXML = strRequestXML & "</HEADER>"
            '            strRequestXML = strRequestXML & "<BODY>"
            '            strRequestXML = strRequestXML & "<IMPORTDATA>"
            '            strRequestXML = strRequestXML & "<REQUESTDESC>"
            '            strRequestXML = strRequestXML & "<REPORTNAME>Vouchers</REPORTNAME>"
            '            strRequestXML = strRequestXML & "<STATICVARIABLES>"
            '            strRequestXML = strRequestXML & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
            '            strRequestXML = strRequestXML & "</STATICVARIABLES>"
            '            strRequestXML = strRequestXML & "</REQUESTDESC>"
            '            strRequestXML = strRequestXML & "<REQUESTDATA>"
            '            strRequestXML = strRequestXML & "<TALLYMESSAGE>"
            '            strRequestXML = strRequestXML & "<VOUCHER VCHTYPE='Sales' ACTION='Create'>"       ' for create /
            '            ' update / delete
            '            strRequestXML = strRequestXML & "<DATE>" & Format(dtp_Todate.Value, "yyyyMMdd") & "</DATE>" ' kotdate
            '            strRequestXML = strRequestXML & "<NARRATION>" & Format(dtp_Todate.Value, "MMM yyyy") & " Bill</NARRATION>"
            '            strRequestXML = strRequestXML & "<VOUCHERTYPENAME>Sales</VOUCHERTYPENAME>"
            '            strRequestXML = strRequestXML & "<VOUCHERNUMBER>" & Trim(rowi + 1) & Format(dtp_Todate.Value, "/MMM-yyyy") & "</VOUCHERNUMBER>"
            '            strRequestXML = strRequestXML & "<PARTYLEDGERNAME>" & Funapos(Funamp(MNAME)) & "</PARTYLEDGERNAME>"
            '            strRequestXML = strRequestXML & "<PARTYNAME>" & Funapos(Funamp(MNAME)) & "</PARTYNAME>"
            '            strRequestXML = strRequestXML & "<EFFECTIVEDATE>" & Format(dtp_Todate.Value, "yyyyMMdd") & "</EFFECTIVEDATE>" ' kotdate

            '            strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
            '            strRequestXML = strRequestXML & "<LEDGERNAME>" & Funapos(Funamp(MNAME)) & "</LEDGERNAME>"
            '            strRequestXML = strRequestXML & "<GSTCLASS/>"
            '            strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>Yes</ISDEEMEDPOSITIVE>"
            '            strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
            '            strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
            '            strRequestXML = strRequestXML & "<ISPARTYLEDGER>Yes</ISPARTYLEDGER>"
            '            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"

            '            strRequestXML = strRequestXML & "<BILLALLOCATIONS.LIST>"
            '            strRequestXML = strRequestXML & "<NAME>BILL</NAME>"
            '            strRequestXML = strRequestXML & "<BILLCREDITPERIOD>45 Days</BILLCREDITPERIOD>"
            '            strRequestXML = strRequestXML & "<BILLTYPE>New Ref</BILLTYPE>"
            '            strRequestXML = strRequestXML & "<AMOUNT>-" & Trim(gdataset.Tables("TALLYMST").Rows(rowi).Item("AMOUNT")) & "</AMOUNT>"
            '            strRequestXML = strRequestXML & "</BILLALLOCATIONS.LIST>"
            '            strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"

            '            sqlstring = "SELECT A.MCODE AS MCODE,A.MNAME AS MNAME,ISNULL(acdesc,'') AS acdesc,ISNULL(SUM(ISNULL(A.AMOUNT,0)),0) AS AMOUNT FROM ucmonthbill_view A WHERE A.KOTDATE BETWEEN '" & Format(dtp_fromdate.Value, "dd/MMM/yyyy") & "' AND '" & Format(dtp_Todate.Value, "dd/MMM/yyyy") & "' AND A.MCODE='" & gdataset.Tables("TALLYMST").Rows(rowi).Item("MCODE") & "'  GROUP BY A.MCODE,A.MNAME,acdesc ORDER BY A.MCODE"
            '            gconnection.getDataSet(sqlstring, "TALLYMM")
            '            If gdataset.Tables("TALLYMM").Rows.Count > 0 Then
            '                For ROWJJ = 0 To gdataset.Tables("TALLYMM").Rows.Count - 1
            '                    LEDGER = ""
            '                    AMOUNT = 0
            '                    With gdataset.Tables("TALLYMM").Rows(ROWJJ)
            '                        LEDGER = Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc"))
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "LAWN TENIIS SUBSCRIPTION" Then
            '                            LEDGER = "TENNIS SUBSCRIPTION"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "MEMBERS SUBSCRIPTION" Then
            '                            LEDGER = "MEMBER'S SUBSCRIPTION"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "MISC INCOME (GH)" Then
            '                            LEDGER = "MISC.INCOME(GH)"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "SALE OF ICECREAM" Then
            '                            LEDGER = "SALE OF ICECREAMS"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "SALE OF LIQUEUR(7C)" Then
            '                            LEDGER = "SALE OF liquor"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "SALE OF LIQUEUR(9I)" Then
            '                            LEDGER = "SALE OF liquor"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "SALE OF RESTAURANT(BARBEY CUBE)" Then
            '                            LEDGER = "SALE OF restaurant items"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "SALE OF RESTAURANT(CAKE COUNTER)" Then
            '                            LEDGER = "SALE OF restaurant items"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "SALE OF RESTURANT ITEMS(KITCHEN COUNTER)" Then
            '                            LEDGER = "SALE OF restaurant items"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "SALE OF SOFTDRINKS" Then
            '                            LEDGER = "SALE OF SOFT DRINKS"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "SALE SUPER BOWL" Then
            '                            LEDGER = "income from bowling alley"
            '                        End If
            '                        If Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")) = "VAT" Then
            '                            LEDGER = "VAT COLLECTED"
            '                        End If
            '                        ''=======================================================================================
            '                        ssql = "Select $Name,$ClosingBalance from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Ledger' where  $Name='" & Funapos(Funamp(Trim(LEDGER))) & "'"
            '                        vfill.Open(ssql, myconnection)
            '                        If vfill.EOF Then
            '                            strRequestXML2 = ""
            '                            strRequestXML2 = strRequestXML2 & "<ENVELOPE>"
            '                            strRequestXML2 = strRequestXML2 & "<HEADER>"
            '                            strRequestXML2 = strRequestXML2 & "<TALLYREQUEST>Import Data</TALLYREQUEST>"
            '                            strRequestXML2 = strRequestXML2 & "</HEADER>"
            '                            strRequestXML2 = strRequestXML2 & "<BODY>"
            '                            strRequestXML2 = strRequestXML2 & "<IMPORTDATA>"
            '                            strRequestXML2 = strRequestXML2 & "<REQUESTDESC>"
            '                            strRequestXML2 = strRequestXML2 & "<REPORTNAME>All Masters</REPORTNAME>"
            '                            strRequestXML2 = strRequestXML2 & "<STATICVARIABLES>"
            '                            strRequestXML2 = strRequestXML2 & "<SVCURRENTCOMPANY>" & Trim(gTallyCompanyName) & "</SVCURRENTCOMPANY>"
            '                            strRequestXML2 = strRequestXML2 & "</STATICVARIABLES>"


            '                            strRequestXML2 = strRequestXML2 & "</REQUESTDESC>"
            '                            strRequestXML2 = strRequestXML2 & "<REQUESTDATA>"
            '                            strRequestXML2 = strRequestXML2 & "<TALLYMESSAGE xmlns:UDF='TallyUDF'>"
            '                            strRequestXML2 = strRequestXML2 & "<GROUP NAME='incomefrommembers'>"
            '                            strRequestXML2 = strRequestXML2 & "<NAME>incomefrommembers</NAME>"
            '                            strRequestXML2 = strRequestXML2 & "<PARENT>incomefrommembers</PARENT>"
            '                            strRequestXML2 = strRequestXML2 & "<LEDGER NAME='" & Funapos(Funamp(Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")))) & "' ACTION='Create'>"
            '                            strRequestXML2 = strRequestXML2 & "<ADDITIONALNAME.LIST>"
            '                            strRequestXML2 = strRequestXML2 & "<ADDITIONALNAME>" & Funapos(Funamp(Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")))) & "</ADDITIONALNAME>"
            '                            strRequestXML2 = strRequestXML2 & "</ADDITIONALNAME.LIST>"

            '                            strRequestXML2 = strRequestXML2 & "<LANGUAGENAME.LIST>"
            '                            strRequestXML2 = strRequestXML2 & "<NAME.LIST>"

            '                            strRequestXML2 = strRequestXML2 & "  <NAME>" & Funapos(Funamp(Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("acdesc")))) & "</NAME>"
            '                            strRequestXML2 = strRequestXML2 & "  </NAME.LIST>"
            '                            'strRequestXML2 = strRequestXML2 & " <DSPOpAmt>2601.95</DSPOpAmt>"
            '                            strRequestXML2 = strRequestXML2 & "  <LANGUAGEID>1033</LANGUAGEID>"
            '                            strRequestXML2 = strRequestXML2 & "  </LANGUAGENAME.LIST>"
            '                            strRequestXML2 = strRequestXML2 & "  </LEDGER>"
            '                            strRequestXML2 = strRequestXML2 & "  </TALLYMESSAGE>"
            '                            strRequestXML2 = strRequestXML2 & "</REQUESTDATA>"
            '                            strRequestXML2 = strRequestXML2 & "</IMPORTDATA>"
            '                            strRequestXML2 = strRequestXML2 & "</BODY>"
            '                            strRequestXML2 = strRequestXML2 & "</ENVELOPE>"

            '                            SerHttp.open("POST", gTallyOdbc & gTallyPort)
            '                            SerHttp.send(strRequestXML2)

            '                            '    End If
            '                            'End If

            '                        End If
            '                        ''======================================================================================
            '                        strRequestXML = strRequestXML & "<ALLLEDGERENTRIES.LIST>"
            '                        strRequestXML = strRequestXML & "<LEDGERNAME>" & Trim(LEDGER) & "</LEDGERNAME>"
            '                        strRequestXML = strRequestXML & "<GSTCLASS/>"
            '                        strRequestXML = strRequestXML & "<ISDEEMEDPOSITIVE>No</ISDEEMEDPOSITIVE>"
            '                        strRequestXML = strRequestXML & "<LEDGERFROMITEM>No</LEDGERFROMITEM>"
            '                        strRequestXML = strRequestXML & "<REMOVEZEROENTRIES>No</REMOVEZEROENTRIES>"
            '                        strRequestXML = strRequestXML & "<ISPARTYLEDGER>No</ISPARTYLEDGER>"
            '                        strRequestXML = strRequestXML & "<AMOUNT>" & Trim(gdataset.Tables("TALLYMM").Rows(ROWJJ).Item("AMOUNT")) & "</AMOUNT>"
            '                        strRequestXML = strRequestXML & "</ALLLEDGERENTRIES.LIST>"
            '                    End With
            '                    vfill.Close()
            '                Next
            '            End If

            '            strRequestXML = strRequestXML & "</VOUCHER>"
            '            strRequestXML = strRequestXML & "</TALLYMESSAGE>"
            '            strRequestXML = strRequestXML & "</REQUESTDATA>"
            '            strRequestXML = strRequestXML & "</IMPORTDATA>"
            '            strRequestXML = strRequestXML & "</BODY>"
            '            strRequestXML = strRequestXML & "</ENVELOPE>"
            '            SerHttp.open("POST", gTallyOdbc & gTallyPort)
            '            SerHttp.send(strRequestXML)

            '            'for tally error
            '            'new for tally xml error
            '            'begin

            '            Dim resstr, errorstr, j
            '            Dim errmsg As Boolean = False
            '            resstr = SerHttp.responseText
            '            ' MsgBox(resstr)
            '            xmlDom.loadXML(resstr)
            '        End With
            '    Next
            'End If
            MsgBox("Successcully Created", vbInformation, "member balance Create")
        Catch ex As Exception
            MessageBox.Show("Check The Error : Tally " & ex.Message, gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try

    End Sub

    Private Sub TALLYPOSTINGTOTAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
