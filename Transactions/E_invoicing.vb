Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports WinHttp
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Collections.Generic
Imports System.Collections.Generic.List(Of String)
Imports System.Linq.Enumerable


Public Class E_invoicing
    Dim gconnection As New GlobalClass
    Dim TRANSNO As Integer
    Dim rs As New Resizer1
    Dim Sperc, Samt, Staxamt As Double
    Dim serverdate As Date
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim billno, LASTAMENDMENTID, tabname, vouchernott, query1 As String
    Dim boolchk As Boolean

    Private Sub LOADMINDATES()

        Try


            query1 = " SELECT getdate() as dated from accountssetup "
            gconnection.getDataSet(query1, "PV")
            If gdataset.Tables("PV").Rows.Count > 0 Then
                serverdate = (gdataset.Tables("PV").Rows(0).Item(0))
            End If
        Catch ex As Exception
            MsgBox("ERROR!")
        End Try

    End Sub
    Public Sub checkValidation()
        Try
            Dim totpay, totusage As Double
            Dim remainingclosed As Int16
            boolchk = False

            query1 = "seLECT * FROM  party_fuction_booking_for_events  where CAST(function_date AS DATE)=CAST('" & Format(CDate(serverdate), "dd-MMM-yyyy") & "' AS DATE) AND eventbookingstatus IN ('FINALISED') AND  eventbookingno='" + lbl_eventno.Text + "' and function_slno='" + lbl_functionno.Text + "'"
            gconnection.getDataSet(query1, "SSS")
            If gdataset.Tables("SSS").Rows.Count > 0 Then
                If serverdate < gdataset.Tables("SSS").Rows(0).Item("function_date") Or serverdate > gdataset.Tables("SSS").Rows(0).Item("function_date") Then
                    MessageBox.Show("this function cannot be started now", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Exit Sub
                End If
            Else
                MessageBox.Show("this function cannot be started now", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            boolchk = True
        Catch EX As Exception
            MsgBox(EX.ToString)
        End Try
    End Sub
    Public Sub resizeFormResolution()
        Dim T, U As Integer
        Me.ResizeRedraw = True

        T = CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)
        U = CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        If U = 800 Then
            T = T - 20
        End If
        If U = 1280 Then
            T = T - 20
        End If
        If U = 1360 Then
            T = T - 55
        End If
    End Sub

    Private Function GenerateCode() As Integer
        Try
            gSQLString = "SELECT ISNULL(MAX(CODE),0)+1 FROM PARTY_HSN_MASTER"
            gconnection.getDataSet(gSQLString, "S")
            If gdataset.Tables("S").Rows.Count > 0 Then
                Return gdataset.Tables("S").Rows(0).Item(0)
            End If
        Catch ex As Exception

        End Try
        Return 0

    End Function
    Private Sub SaveOperation()
        Try
            checkValidation()
            If boolchk = False Then
                Exit Sub
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub



    Private Sub common_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackgroundImageLayout = ImageLayout.Stretch
        'rs.FindAllControls(Me)
        'Me.resizeFormResolution()

        'rs.ResizeAllControls(Me)
        'Me.WindowState = FormWindowState.Maximized

        Me.DoubleBuffered = True
        Label_Freeze.Visible = False
        'If gUserCategory <> "S" Then
        '    Call GetRights()
        'End If
        query1 = "  SELECT getdate() as dated from accountssetup "
        gconnection.getDataSet(query1, "PV")
        If gdataset.Tables("PV").Rows.Count > 0 Then
            serverdate = (gdataset.Tables("PV").Rows(0).Item(0))


        End If
        DTP_FROMDATE.Value = serverdate
        DTP_TODATE.Value = serverdate
        'DTP_TODATE.Value = DateAdd(DateInterval.Day, 7, serverdate)
        LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Value)
        ' BTN_SAVE.Enabled = False
        changecolor()

    End Sub


    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs)
        SaveOperation()
        '    BTN_SAVE.Enabled = False
        LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Value)
    End Sub

    Private Sub TaxInvoice4Inch(ByVal TrnNo As Integer, ttype As String)
        Dim sqlstring, SSQL, LocName, OthBill, PosName As String
        Dim Viewer As New ReportViwer

        Dim pic As Image

        Dim r

        r = New TaxInvoiceA4


        Dim POSdesc(), MemberCode() As String
        Dim SQLSTRING2 As String

        sqlstring = "select * from gstbiltransDET_log where transno = " & TrnNo & ""
        Call Viewer.GetDetails1(sqlstring, "Table2", r)
        sqlstring = "select Doc_No,'-Rate of CGST – ' as Item_PrdDesc,Round(Item_GstRt / 2,2) as Item_GstRt,Sum(Item_CgstAmt) as Item_SgstAmt from gstbiltransDET_log where transno = " & TrnNo & " and isnull(Item_GstRt,0) > 0 group by Doc_No,Item_GstRt Union all "
        sqlstring = sqlstring & " select Doc_No,'-Rate of SGST – ' as Item_PrdDesc,Round(Item_GstRt / 2,2) as Item_GstRt,Sum(Item_SgstAmt) as Item_SgstAmt from gstbiltransDET_log where transno = " & TrnNo & " and isnull(Item_GstRt,0) > 0 group by Doc_No,Item_GstRt Union all "
        sqlstring = sqlstring & " select Doc_No,'-Rate of Cess -' as Item_PrdDesc,Round(Item_CesRt,2) as Item_GstRt,Sum(Item_CesAmt) as Item_SgstAmt from gstbiltransDET_log where transno = " & TrnNo & " and isnull(Item_CesRt,0) > 0 group by Doc_No,Item_CesRt Union all "
        sqlstring = sqlstring & " select Doc_No,'-Add. Cess -' as Item_PrdDesc,100 as Item_GstRt,Sum(Item_CesNonAdvlAmt) as Item_SgstAmt from gstbiltransDET_log where transno = " & TrnNo & " and isnull(Item_CesNonAdvlAmt,0) > 0 group by Doc_No "
        Call Viewer.GetDetails1(sqlstring, "Table3", r)
        sqlstring = "select * from gstbiltranshdr_log where transno = " & TrnNo & ""
        Call Viewer.GetDetails1(sqlstring, "Table1", r)

        ''PosName = gconnection.getvalue("SELECT posdesc FROM posmaster WHERE poscode IN (SELECT TOP 1 POSCODE FROM KOT_det WHERE BILLDETAILS = '" & Trim(txt_BillNo.Text) & "')")
        ''If PosName = Nothing Then
        ''    PosName = ""
        ''End If
        ''Dim TXTOBJ1 As CrystalDecisions.CrystalReports.Engine.TextObject
        ''TXTOBJ1 = r.ReportDefinition.ReportObjects("Text7")
        ''TXTOBJ1.Text = PosName

        Viewer.Show()
        Viewer.BringToFront()
    End Sub


    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub
    Private Sub SETWIDTH()

        If gridFNStatus.RowCount > 0 Then
            gridFNStatus.Columns(0).Width = 150
            gridFNStatus.Columns(1).Width = 85
            gridFNStatus.Columns(2).Width = 100
            gridFNStatus.Columns(3).Width = 120
            gridFNStatus.Columns(4).Width = 150
            gridFNStatus.Columns(5).Width = 120
            gridFNStatus.Columns(6).Width = 110
            gridFNStatus.Columns(7).Width = 110
            gridFNStatus.Columns(8).Width = 150

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LOADALLFUNCTIONS(ByVal fromdate As Date, ByVal todate As Date)

        gridFNStatus.DataSource = Nothing
        '   gSQLString = "select t.BILLDETAILS,BOOKINGNO,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct case when billdate<='29 aug 2021' then 'PAR/'+right('000000'+cast(BILLDETAILS as varchar(20)) ,6) else 'PAR/'+right('000000'+cast(BILLDETAILS as varchar(20)) ,6)+'/'+finyear end as BILLDETAILS ,a.eventbookingno AS  BOOKINGNO,billdate AS BILLDATE,b.CLIENTCODE,b.CLIENTDESC,isnull(c.gstinno,'') gstinno from party_billdetails a,PARTY_EVENT_BOOKING b,membermaster c where a.eventbookingno=b.eventbookingno and b.clientcode=c.mcode and b.clienttype='CLUB MEMBER' and isnull(c.gstinno,'')<>''and billdate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name())) union all select distinct case when billdate<='29 aug 2021' then 'PAR/'+right('000000'+cast(BILLDETAILS as varchar(20)) ,6) else 'PAR/'+right('000000'+cast(BILLDETAILS as varchar(20)) ,6)+'/'+finyear end as BILLDETAILS ,a.eventbookingno AS  BOOKINGNO,billdate AS BILLDATE,b.CLIENTCODE,b.CLIENTDESC,isnull(c.gstinno,'') gstinno from party_billdetails a, PARTY_EVENT_BOOKING b,PMS_NONMEMBER_master c where a.eventbookingno=b.eventbookingno and b.clientcode=c.mcode and b.clienttype<>'CLUB MEMBER' and isnull(c.gstinno,'')<>''and billdate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on cast(t.BOOKINGNO as varchar(40))=replace(d.billdetails,'PAR','') and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        If OPERATION_TYPE.Text = "POSBILL" Then
            'gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   BILLDETAILS ,billdate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from BILL_hdr a ,membermaster c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' and billdetails  in(select billdetails from kot_det where POSCODE in(select poscode from posmaster where isnull(Cat_Name,'')='' )) and isnull(delflag,'')<>'Y'and billdate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   BILLDETAILS ,CAST(CONVERT(VARCHAR(11),BILLDATE,106) AS DATETIME) AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from BILL_hdr a ,membermaster c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' and billdetails  in(select billdetails from kot_det where POSCODE in(select poscode from posmaster where isnull(Cat_Name,'')='' )) and isnull(delflag,'')<>'Y'and CAST(CONVERT(VARCHAR(11),BILLDATE,106) AS DATETIME) between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where CAST(CONVERT(VARCHAR(11),BILLDATE,106) AS DATETIME) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            If gCompName = "SATC" Then
                gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   BILLDETAILS ,billdate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from BILL_hdr a ,membermaster c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' AND A.PayMentmode <> 'PARTY' and billdetails  in(select billdetails from kot_det where POSCODE in(select poscode from posmaster where isnull(Cat_Name,'')='' )) and isnull(delflag,'')<>'Y'and billdate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "BCL" Then
                gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   BILLDETAILS ,billdate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from BILL_hdr a ,membermaster c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' AND A.PayMentmode NOT IN ('ROOM','PARTY') and billdetails  in(select billdetails from kot_det where POSCODE in(select poscode from posmaster where isnull(Cat_Name,'')='' )) and isnull(delflag,'')<>'Y' AND SUBSTRING(BILLDETAILS,1,1) <> 'N'  and billdate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "JSCA" Then
                gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   BILLDETAILS ,billdate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from BILL_hdr a ,VIEW_MEMBER_EINVOICE c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' and billdetails  in(select billdetails from kot_det where POSCODE in(select poscode from posmaster where isnull(Cat_Name,'')='' )) and isnull(delflag,'')<>'Y' AND ISNULL(PAYMENTMODE,'') NOT IN ('ROOM','PARTY') and billdate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "KGA" Then
                gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   BILLDETAILS ,CAST(CONVERT(VARCHAR(11),BILLDATE,106) AS DATETIME) AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from BILL_hdr a ,membermaster c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(a.TaxAmount,0) > 0 and billdetails  in(select billdetails from kot_det where POSCODE in(select poscode from posmaster where isnull(Cat_Name,'')='' )) and isnull(delflag,'')<>'Y'and CAST(CONVERT(VARCHAR(11),BILLDATE,106) AS DATETIME) between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where CAST(CONVERT(VARCHAR(11),BILLDATE,106) AS DATETIME) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            End If
        ElseIf OPERATION_TYPE.Text = "GOLF COURSE" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   DOCNO AS BILLDETAILS ,DOCDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno  from GMS_GREENFEE_HDR a ,membermaster c where a.MEMBERCODE=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(A.VOID,'')<>'Y' AND LOCATION = 'GOLF COURSE' and DOCDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where cast(convert(varchar(11),BILLDATE,106) as datetime) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "DRIVING RANGE" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   DOCNO AS BILLDETAILS ,DOCDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno  from GMS_GREENFEE_HDR a ,membermaster c where a.MEMBERCODE=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(A.VOID,'')<>'Y' AND LOCATION = 'DRIVING RANGE' and DOCDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where cast(convert(varchar(11),BILLDATE,106) as datetime) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "COACHING" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo, cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   DOCNO AS BILLDETAILS ,DOCDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from GMS_COACHING_HDR a ,membermaster c where a.MEMBERCODE=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(A.VOID,'')<>'Y' and DOCDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where cast(convert(varchar(11),BILLDATE,106) as datetime) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "BALLSALE" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo, cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   DOCNO AS BILLDETAILS ,DOCDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from GMS_BALL_HDR a ,membermaster c where a.MEMBERCODE=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(A.VOID,'')<>'Y' and DOCDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where cast(convert(varchar(11),BILLDATE,106) as datetime) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "HIRINGGOLF" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo, cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   DOCNO AS BILLDETAILS ,DOCDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from GMS_GOLFHIRING_HDR a ,membermaster c where a.MEMBERCODE=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(A.VOID,'')<>'Y' AND LOCATION = 'GOLF COURSE' and DOCDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where cast(convert(varchar(11),BILLDATE,106) as datetime) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "HIRINGDRIVING" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo, cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   DOCNO AS BILLDETAILS ,DOCDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from GMS_GOLFHIRING_HDR a ,membermaster c where a.MEMBERCODE=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(A.VOID,'')<>'Y' AND LOCATION = 'DRIVING RANGE' and DOCDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where cast(convert(varchar(11),BILLDATE,106) as datetime) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "CAMPFEE" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo, cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   RECEIPTNO AS BILLDETAILS ,RECEIPTDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from GMS_CAMPREC_DET a ,membermaster c where a.MEMBERCODE=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(A.VOID,'')<>'Y' AND LOCATION = 'DRIVING RANGE' and RECEIPTDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where cast(convert(varchar(11),BILLDATE,106) as datetime) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "CARTISSUE" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo, cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   REC_NO AS BILLDETAILS ,REC_DATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from GMS_CARTISSUE_DET a ,membermaster c where a.MEMBERCODE=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(A.VOID,'')<>'Y'  and REC_DATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where cast(convert(varchar(11),BILLDATE,106) as datetime) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "SHORT" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo, cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   DOCNO AS BILLDETAILS ,DOCDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from GMS_SHORTGAME_HDR a ,membermaster c where a.MEMBERCODE=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(A.VOID,'')<>'Y'  and DOCDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where cast(convert(varchar(11),BILLDATE,106) as datetime) between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "SUBSCRIPTION" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct billno as  BILLDETAILS ,billdate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from SUBSPOSTING a ,membermaster c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(c.gstinno,'')<>'NA' and isnull(a.Void,'')<>'Y'and billdate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "ENTFEE" Then
            'gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select  DOCNO BILLDETAILS ,DOCDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from membermaster c,ENTRANCEFEE_RECEIPTS a inner join MEMBER_APPLICATION_MASTER b on a.ApplnCode=b.APPLNO where b.MEMBERID=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(a.Freeze,'')<>'Y'and DOCDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select  DOCNO BILLDETAILS ,DOCDATE AS BILLDATE,a.ApplnCode as CLIENTCODE,a.Applnname CLIENTDESC,isnull(a.GSTINNO,'') gstinno from  ENTRANCEFEE_RECEIPTS a inner join MEMBER_APPLICATION_MASTER b on a.ApplnCode=b.APPLNO where   isnull(a.gstinno,'')<>'' and isnull(a.Freeze,'')<>'Y'and DOCDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        ElseIf OPERATION_TYPE.Text = "DEBITNOTE" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct VoucherNo BILLDETAILS ,VoucherDate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from membermaster c,journalentry a  where a.SLCode=c.mcode and VoucherType IN ('CDN','ACDN','CCDN') and CreditDebit='DEBIT' and isnull(a.void,'')<>'Y' and isnull(c.gstinno,'')<>'' and isnull(a.Void,'')<>'Y'and VoucherDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            If gCompName = "KGA" Then
                gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct VoucherNo BILLDETAILS ,VoucherDate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from membermaster c,journalentry a  where a.SLCode=c.mcode and VoucherType IN ('DBN') and CreditDebit='DEBIT' and isnull(a.void,'')<>'Y' and isnull(c.gstinno,'')<>'' and isnull(a.Void,'')<>'Y'and VoucherDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            End If
        ElseIf OPERATION_TYPE.Text = "CREDITNOTE" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct VoucherNo BILLDETAILS ,VoucherDate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from membermaster c,journalentry a  where a.SLCode=c.mcode and VoucherType IN ('CCN') and CreditDebit='CREDIT' and isnull(a.void,'')<>'Y'  and isnull(c.gstinno,'')<>'' and isnull(a.Void,'')<>'Y'and VoucherDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            If gCompName = "KGA" Then
                'gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct VoucherNo BILLDETAILS ,VoucherDate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from membermaster c,journalentry a  where a.SLCode=c.mcode and VoucherType IN ('CRN') and CreditDebit='CREDIT' and isnull(a.void,'')<>'Y'  and isnull(c.gstinno,'')<>'' and isnull(a.Void,'')<>'Y'and VoucherDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
                gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct VoucherNo BILLDETAILS ,VoucherDate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from membermaster c,journalentry a  where a.SLCode=c.mcode and VoucherType IN ('CRN') and CreditDebit='CREDIT' and isnull(a.void,'')<>'Y'  and isnull(c.gstinno,'')<>'' and isnull(a.Void,'')<>'Y'and VoucherDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on 'CRN'+t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "SATC" Then
                gSQLString = "select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct VoucherNo BILLDETAILS ,VoucherDate AS BILLDATE,c.slcode as CLIENTCODE,c.slname CLIENTDESC,isnull(c.gstinno,'') gstinno from ACCOUNTSSUBLEDGERMASTER c,journalentry a  where  a.SLCode=c.slcode and a.AccountCode = c.accode and VoucherType IN ('VCN') and CreditDebit='CREDIT' and isnull(A.void,'')<>'Y'  and isnull(c.gstinno,'')<>'' and isnull(a.Void,'')<>'Y'and VoucherDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "CPC" Then
                gSQLString = "select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct VoucherNo BILLDETAILS ,VoucherDate AS BILLDATE,c.slcode as CLIENTCODE,c.slname CLIENTDESC,isnull(c.gstinno,'') gstinno from ACCOUNTSSUBLEDGERMASTER c,journalentry a  where  a.SLCode=c.slcode and a.AccountCode = c.accode and VoucherType IN ('CCN') and CreditDebit='CREDIT' and isnull(A.void,'')<>'Y'  and isnull(c.gstinno,'')<>'' and isnull(a.Void,'')<>'Y'and VoucherDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            End If
        ElseIf OPERATION_TYPE.Text = "INVOICE" Then
            gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct  VoucherNo BILLDETAILS ,VoucherDate AS BILLDATE,case when SLCode='' then partycode else SLCode end as CLIENTCODE,case when SLCode='' then partynm else SLDesc end CLIENTDESC,gstinno from  VW_SERVICEBILLVOUCHERprint a  where isnull(gstinno,'')<>'' and isnull(a.Void,'')<>'Y' and CreditDebit<>'' and itemcode <> 'ROUNDOFF' and VoucherDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            If gCompName = "CSC" Then
                gSQLString = " select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select distinct  VoucherNo BILLDETAILS ,VoucherDate AS BILLDATE,SLCode  as CLIENTCODE, SLDesc  CLIENTDESC,(select m.gstinno from accountssubledgermaster m where m.accode=a.accountcode and m.slcode=a.slcode) as gstinno   from  journalentry  a  where isnull((select m.gstinno from accountssubledgermaster m where m.accode=a.accountcode and m.slcode=a.slcode),'')<>'' and isnull(a.Void,'')<>'Y' and CreditDebit<>'' and vouchertype in(select prefix from accountsdoctypemaster where category ='SERVICE BILL')  AND VoucherType NOT IN ('SBIL','CBIL') and VoucherDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            End If
        ElseIf OPERATION_TYPE.Text = "PARTY" Then
            If gCompName = "SATC" Then
                gSQLString = " select  t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select DISTINCT  VNo AS BILLDETAILS ,A.VDate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.HSN,'') gstinno from Tbl_RoomParty_Settlement a ,membermaster c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' AND TType = 'PARTY' and Billno  in(select billdetails from kot_det where POSCODE in(select poscode from posmaster where isnull(Cat_Name,'')='' and isnull(freeze,'')<>'Y')) and isnull(A.Void,'')<>'Y'and A.VDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "BCL" Then
                gSQLString = " select  t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from (select DISTINCT  BILLNO AS BILLDETAILS ,A.PARTYDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from PARTY_hDR a ,membermaster c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' AND BOOKINGTYPE = 'BILLING'  and isnull(A.Void,'')<>'Y'and A.PARTYDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "JSCA" Then
                gSQLString = " select  t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from (select DISTINCT  BILL_NO AS BILLDETAILS ,A.BILLDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from RoomParty_eInvoice a ,VIEW_MEMBER_EINVOICE c where a.mcode=c.mcode and isnull(c.gstinno,'')<>'' AND isnull(BILL_NO,'') <> ''  AND DataType = 'PARTY' and A.BILLDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            Else
                Exit Sub
            End If
        ElseIf OPERATION_TYPE.Text = "ROOM" Then
            If gCompName = "SATC" Then
                gSQLString = " select  t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select DISTINCT  VNo AS BILLDETAILS ,A.VDate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.HSN,'') gstinno from Tbl_RoomParty_Settlement a ,membermaster c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' AND TType = 'ROOM' and Billno  in(select billdetails from kot_det where POSCODE in(select poscode from posmaster where isnull(Cat_Name,'')='' and isnull(freeze,'')<>'Y')) and isnull(A.Void,'')<>'Y'and A.VDate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "BCL" Then
                gSQLString = " select  t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from (select DISTINCT  BILL_NO AS BILLDETAILS ,A.BILLDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from RPT_ROOMBILL_EINVOICE a ,membermaster c where a.mcode=c.mcode and isnull(c.gstinno,'')<>'' AND isnull(BILL_NO,'') <> '' and A.BILLDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "CSC" Then
                gSQLString = " select  t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from (select DISTINCT  BILL_NO AS BILLDETAILS ,A.BILLDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from RPT_ROOMBILL_EINVOICE a ,membermaster c where a.mcode=c.mcode and isnull(c.gstinno,'')<>'' AND isnull(BILL_NO,'') <> '' and A.BILLDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "ITC" Then
                gSQLString = " select  t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from (select DISTINCT  BILL_NO AS BILLDETAILS ,A.BILLDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from RPT_ROOMBILL_EINVOICE a ,membermaster c where a.mcode=c.mcode and isnull(c.gstinno,'')<>'' AND isnull(BILL_NO,'') <> '' and A.BILLDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            ElseIf gCompName = "JSCA" Then
                gSQLString = " select  t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from (select DISTINCT  BILL_NO AS BILLDETAILS ,A.BILLDATE AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from RoomParty_eInvoice a ,VIEW_MEMBER_EINVOICE c where a.mcode=c.mcode and isnull(c.gstinno,'')<>'' AND isnull(BILL_NO,'') <> ''  AND DataType = 'ROOM' and A.BILLDATE between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
            Else
                Exit Sub
            End If
        ElseIf OPERATION_TYPE.Text = "GUESTENTRY" Then
            gSQLString = "select t.BILLDETAILS,BILLDATE,CLIENTCODE,CLIENTDESC,GSTINNO,case when iSNULL(success,'')='tru' then 'TRUE' when  iSNULL(success,'')='fals' then 'FALSE' else iSNULL(success,'') end as success ,iSNULL(MSG,'')as MSG	,isnull(ackNo,'')as ackNo,cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') when  iSNULL(success,'')='fals' then (select  img  from buttonimage where btnname='delete') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(select   bill_no as BILLDETAILS ,billdate AS BILLDATE,c.mcode as CLIENTCODE,c.mname CLIENTDESC,isnull(c.gstinno,'') gstinno from GR_BILL_HDR a ,membermaster c where a.mcode=c.mcode  and isnull(c.gstinno,'')<>'' and isnull(VOID,'')<>'Y'and billdate between (select fromdate from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BILLDETAILS=d.BILLDETAILS and isnull(void,'')<>'Y' where BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        End If
        gconnection.getDataSet(gSQLString, "PAY1")
        '        gSQLString1 = "select cast(case when iSNULL(success,'')='tru' then (select  img  from buttonimage where btnname='DETAILS') else (select  img  from buttonimage where btnname='EDIT') end  as image) as ACTION from(
        'select distinct 'PAR/'+right(('000000'+billdetails),6) as BILLDETAILS ,a.eventbookingno AS  BOOKINGNO,billdate AS BILLDATE,b.CLIENTCODE,b.CLIENTDESC,isnull(c.gstinno,'') gstinno from party_billdetails a,
        'PARTY_EVENT_BOOKING b,membermaster c where a.eventbookingno=b.eventbookingno and b.clientcode=c.mcode and b.clienttype='CLUB MEMBER' and isnull(c.gstinno,'')<>''and billdate between (select fromdate from master..clubmaster 
        'where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))
        'union all
        'select distinct 'PAR/'+right(('000000'+billdetails),6) as BILLDETAILS ,a.eventbookingno AS  BOOKINGNO,billdate AS BILLDATE,b.CLIENTCODE,b.CLIENTDESC,isnull(c.gstinno,'') gstinno from party_billdetails a,
        'PARTY_EVENT_BOOKING b,PMS_NONMEMBER_master c where a.eventbookingno=b.eventbookingno and b.clientcode=c.mcode and b.clienttype<>'CLUB MEMBER' and isnull(c.gstinno,'')<>''and billdate between (select fromdate 
        'from master..clubmaster where datafile=(select db_name())) and (select todate from master..clubmaster where datafile=(select db_name()))) t left outer join GSPIRNUPDATE d on t.BOOKINGNO=replace(d.billdetails,'PAR','') and BILLDATE between '" + Format(fromdate, "dd/MMM/yyyy") + "' and '" + Format(todate, "dd/MMM/yyyy") + "' "
        '        gconnection.getDataSet(gSQLString1, "PAY2")


        If gdataset.Tables("PAY1").Rows.Count > 0 Then
            gridFNStatus.DataSource = gdataset.Tables("PAY1")

            '''===================================================================
            'Dim i1 As Integer
            'i1 = gridFNStatus.Rows.Count - 1
            'While i1 > 0
            '    i1 = gridFNStatus.Rows.Count - 1
            '    Dim r1 As DataGridViewRow

            '    r1 = gridFNStatus.Rows(i1)
            '    gridFNStatus.Rows.Remove(r1)
            'End While
            ''  Dim i As Integer
            'i1 = gridFNStatus.Columns.Count - 1
            'While i1 > 0
            '    i1 = gridFNStatus.Columns.Count - 1
            '    Dim r1 As DataGridViewColumn
            '    r1 = gridFNStatus.Columns(i1)
            '    gridFNStatus.Columns.Remove(r1)
            'End While


            'gridFNStatus.DataSource = Nothing

            'Dim dt1 As DataTable = New DataTable()
            'Dim n As Integer
            'n = 0
            'Dim j As Integer
            'For j = 0 To gdataset.Tables("PAY1").Columns.Count - 2
            '    ' Dim colX As New DataGridViewImageColumn()
            '    Dim colX As New DataGridViewTextBoxColumn()
            '    colX.Name = gdataset.Tables("PAY1").Columns(j).ColumnName
            '    'colX.HeaderText = ""
            '    '  colX.ImageLayout = DataGridViewImageCellLayout.Stretch

            '    'colX.ToolTipText = dt.Rows(j).Item(2)
            '    gridFNStatus.Columns.Add(colX)
            '    dt1.Columns.Add(gdataset.Tables("PAY1").Columns(j).ColumnName)

            'Next
            'For j = gdataset.Tables("PAY1").Columns.Count - 1 To gdataset.Tables("PAY1").Columns.Count - 1
            '    Dim colX As New DataGridViewImageColumn()
            '    ' Dim colX As New DataGridViewTextBoxColumn()
            '    colX.Name = gdataset.Tables("PAY1").Columns(j).ColumnName
            '    'colX.HeaderText = ""
            '    colX.ImageLayout = DataGridViewImageCellLayout.Stretch

            '    'colX.ToolTipText = dt.Rows(j).Item(2)
            '    gridFNStatus.Columns.Add(colX)
            '    dt1.Columns.Add(gdataset.Tables("PAY1").Columns(j).ColumnName)

            'Next

            'gconnection.getDataSet(gSQLString, "PAY1")
            ''For j = 0 To dt.Rows.Count - 1
            ''    R(j) = dt.Rows(j).Item(1)
            ''Next

            'For i = 0 To gdataset.Tables("PAY1").Rows.Count - 1
            '    Dim R As DataRow = dt1.NewRow
            '    For j = 0 To gdataset.Tables("PAY1").Columns.Count - 1
            '        ' Dim colX As New DataGridViewImageColumn()
            '        'Dim colX As New DataGridViewTextBoxColumn()
            '        'colX.Name = gdataset.Tables("PAY1").Rows(j).Item(2)
            '        'colX.HeaderText = ""
            '        '  colX.ImageLayout = DataGridViewImageCellLayout.Stretch

            '        'colX.ToolTipText = dt.Rows(j).Item(2)
            '        '  DataGridView1.Columns.Add(colX)
            '        R(j) = gdataset.Tables("PAY1").Rows(i).Item(j)

            '    Next
            '    'For j = gdataset.Tables("PAY1").Columns.Count - 1 To gdataset.Tables("PAY1").Columns.Count - 1
            '    '    Dim ImgStream As MemoryStream = New MemoryStream(CType(gdataset.Tables("PAY1").Rows(i).Item("ACTION"), Byte()))
            '    '    Dim bm As New Bitmap(ImgStream)
            '    '    'picSignatur.Image = bm
            '    '    'Dim _image As New Bitmap(DirectCast(gdataset.Tables("PAY1").Rows(j).Item("ACTION"), System.Drawing.Bitmap))
            '    '    '  colX.Image = bm
            '    '    R(j) = bm

            '    'Next
            '    dt1.Rows.Add(R)
            'Next
            '''''''============================================
            'gridFNStatus.DataSource = Nothing
            ''gridFNStatus.DataSource = dt1
            'For i = 0 To dt1.Rows.Count - 1
            '    gridFNStatus.Rows.Add()
            '    For j = 0 To dt1.Columns.Count - 1
            '        gridFNStatus.Rows(i).Cells(j).Value = dt1.Rows(i).Item(j)
            '    Next
            '    ' For j = dt1.Columns.Count - 1 To dt1.Columns.Count - 1

            '    'Dim bytMEMimage() As Byte = gdataset.Tables("PAY2").Rows(i).Item("ACTION")
            '    'Dim bm As New MemoryStream(bytMEMimage)
            '    'Dim ImgStream As MemoryStream = New MemoryStream(CType(gdataset.Tables("PAY1").Rows(i).Item("ACTION"), Byte()))
            '    'Dim bm As New Bitmap(ImgStream)
            '    '   PictureBox1.Image = Image.FromStream(bm)
            '    '    'Dim _image As New Bitmap(DirectCast(gdataset.Tables("PAY1").Rows(j).Item("ACTION"), System.Drawing.Bitmap))
            '    '    '  colX.Image = bm
            '    '    R(j) = bm

            '    'vOutfile = Mid("Pho" & (Rnd() * 800000), 1, 8)
            '    'VFilePath = AppPath & "\Reports\" & vOutfile & ".JPG"
            '    'If File.Exists(VFilePath) = True Then
            '    '    File.Delete(VFilePath)
            '    'End If
            '    'Dim myBitmap As Bitmap = CType(Bitmap.FromStream(bm), Bitmap)
            '    'myBitmap.Save(VFilePath)
            '    'myBitmap.Dispose()
            '    'DirectCast(bm, System.Drawing.Image)
            '    ' Dim dj As New DataGridViewImageCell
            '    ' dj.ImageLayout = DataGridViewImageCellLayout.Stretch
            '    ' dj.
            '    '(DataGridViewImageColumn)gridFNStatus.Rows(i).Cells(j).  = Image;

            '    '  Next
            'Next

            For i = 0 To gridFNStatus.Rows.Count - 1
                gridFNStatus.Rows(i).Height = 50
                Dim cell As DataGridViewImageCell = gridFNStatus.Rows(i).Cells(8)
                cell.ImageLayout = DataGridViewImageCellLayout.Zoom
            Next
            ''Dim r As Integer
            ''r = gridFNStatus.Columns.Count - 1

            ''If gridFNStatus.Columns.Count > gdataset.Tables("PAY1").Columns.Count Then

            ''    gridFNStatus.Columns.Remove("ACTION")
            ''End If



            ''     DataGridView1.DataSource = Nothing

            ''Dim dt1 As DataTable = New DataTable()
            ''Dim n As Integer
            ''n = 0
            ''   Dim j As Integer
            ''For j = 0 To gdataset.Tables("PAY1").Rows.Count - 1
            ''    Dim colX As New DataGridViewImageColumn()
            ''    ' Dim colX As New DataGridViewTextBoxColumn()
            ''    colX.Name = "ACTION"
            ''    'colX.HeaderText = ""
            ''    colX.ImageLayout = DataGridViewImageCellLayout.Stretch
            ''    Dim ImgStream As MemoryStream = New MemoryStream(CType(gdataset.Tables("PAY1").Rows(j).Item("ACTION"), Byte()))
            ''    Dim bm As New Bitmap(ImgStream)
            ''    'picSignatur.Image = bm
            ''    'Dim _image As New Bitmap(DirectCast(gdataset.Tables("PAY1").Rows(j).Item("ACTION"), System.Drawing.Bitmap))
            ''    colX.Image = bm
            ''    'colX.ToolTipText = dt.Rows(j).Item(2)
            ''    gridFNStatus.Columns.Add(colX)
            ''    ' dt1.Columns.Add(dt.Rows(j).Item(2))

            ''Next
            ''gridFNStatus.AutoResizeColumnHeadersHeight()
            ''  gridFNStatus.RowTemplate.MinimumHeight = 400
            ''If gridFNStatus.Columns.Count > gdataset.Tables("PAY1").Columns.Count Then

            ''    gridFNStatus.Columns.Remove("btn")
            ''End If

            '' Dim img As New DataGridViewImageColumn()
            ''Dim inImg As Image = Image.FromFile("E:\WORKINGSOURCE\RAUSHAN\SOURCECHS\Ambuja\RAUSHAN\neotiaall\SpecialParty\bin\Debug\details.png")
            ''img.Image = inImg
            ''gridFNStatus.Columns.Add(img)
            ''img.HeaderText = "Image"
            ''img.Name = "img"

            ''Dim col As New DataGridViewImageColumn
            ''col.HeaderText = "Click Data"
            ''col.Name = "btn"
            ''gridFNStatus.Columns.Add(col)
            ''r = gridFNStatus.Columns.Count - 1
            For i = 0 To gridFNStatus.Rows.Count - 1
                If Not String.IsNullOrEmpty(gridFNStatus.Rows(i).Cells(1).Value) Then
                    lbl_eventno.Text = gridFNStatus.Rows(i).Cells(1).Value
                    If gridFNStatus.Rows(i).Cells(5).Value = "TRUE" Then
                        gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.Green
                        gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                    If gridFNStatus.Rows(i).Cells(5).Value = "FALSE" Then
                        gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.Red
                        gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                    If gridFNStatus.Rows(i).Cells(5).Value = "" Then
                        gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.Black
                        gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.White
                        '
                        'col.Name = "btn"
                        'col.UseColumnTextForButtonValue = True
                    End If
                End If
            Next
            'For i = 0 To gridFNStatus.Rows.Count - 1
            '    If gridFNStatus.Rows(i).Cells(6).Value = "TRUE" Then

            '        Dim cn As New SqlConnection(gconnection.sqlconnection)
            '        Dim sssql As String
            '        '   If gdataset.Tables("PAY1").Rows(i).Item("success") = "TRUE" Then
            '        sssql = "select  img as ACTION from buttonimage where btnname='DETAILS'"


            '        'sssql = " ThenSelect * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            '        Dim cmd As New SqlCommand(sssql, cn)
            '        Dim da As New SqlDataAdapter(cmd)
            '        Dim ds As New DataSet
            '        da.Fill(ds, "sm_image")
            '        Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            '        If c > 0 Then
            '            Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("ACTION")
            '            Dim stmMEMimage As New MemoryStream(bytMEMimage)
            '            PictureBox1.Image = Image.FromStream(stmMEMimage)
            '            vOutfile = Mid("Pho" & (Rnd() * 800000), 1, 8)
            '            VFilePath = AppPath & "\Reports\" & vOutfile & ".JPG"
            '            If File.Exists(VFilePath) = True Then
            '                File.Delete(VFilePath)
            '            End If
            '            Dim myBitmap As Bitmap = CType(Bitmap.FromStream(stmMEMimage), Bitmap)
            '            myBitmap.Save(VFilePath)
            '            myBitmap.Dispose()
            '            Dim cell As DataGridViewImageCell = gridFNStatus.Rows(i).Cells(9)
            '            cell.Value = Image.FromStream(stmMEMimage)
            '        Else
            '            PictureBox1.Image = Nothing
            '        End If
            '    Else

            '        Dim cn As New SqlConnection(gconnection.sqlconnection)
            '        Dim sssql As String
            '        sssql = "select  img as ACTION from buttonimage where btnname='EDIT'"
            '        Dim cmd As New SqlCommand(sssql, cn)
            '        Dim da As New SqlDataAdapter(cmd)
            '        Dim ds As New DataSet
            '        da.Fill(ds, "sm_image")
            '        Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            '        If c > 0 Then
            '            Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("ACTION")
            '            Dim stmMEMimage As New MemoryStream(bytMEMimage)
            '            PictureBox1.Image = Image.FromStream(stmMEMimage)
            '            vOutfile = Mid("Pho" & (Rnd() * 800000), 1, 8)
            '            VFilePath = AppPath & "\Reports\" & vOutfile & ".JPG"
            '            If File.Exists(VFilePath) = True Then
            '                File.Delete(VFilePath)
            '            End If
            '            Dim myBitmap As Bitmap = CType(Bitmap.FromStream(stmMEMimage), Bitmap)
            '            myBitmap.Save(VFilePath)
            '            myBitmap.Dispose()
            '            Dim cell As DataGridViewImageCell = gridFNStatus.Rows(i).Cells(9)
            '            cell.Value = Image.FromStream(stmMEMimage)
            '        Else
            '            PictureBox1.Image = Nothing
            '        End If

            '        '                    Me.gridFNStatus.Rows(i).Cells(9).Value = System.Drawing.Image.FromFile _
            '        '("E:\WORKINGSOURCE\RAUSHAN\SOURCECHS\Ambuja\RAUSHAN\neotiaall\SpecialParty\bin\Debug\edit.png")
            '        '   gridFNStatus.Rows(i).Height = 50
            '        'Dim img As Bitmap

            '        'img = New Bitmap("E:\WORKINGSOURCE\RAUSHAN\SOURCECHS\Ambuja\RAUSHAN\neotiaall\SpecialParty\bin\Debug\edit.png")

            '        'gridFNStatus.Rows(i).Cells(r).Value = img
            '        'col.ImageLayout = DataGridViewImageCellLayout.Stretch

            '        ' col.Image = Image.FromFile("E:\WORKINGSOURCE\RAUSHAN\SOURCECHS\Ambuja\RAUSHAN\neotiaall\SpecialParty\bin\Debug\edit.png")
            '    End If
            'Next

            SETWIDTH()

        End If
    End Sub

    Public Function servicechargedetails(ByVal ITEMTYPE As String, ByVal itemcode As String, ByVal EVNO As String, ByVal FNNO As String, ByVal amount As Double) As Boolean

        ' query1 = "EXEC  EXEC PARTY_GETSERVICECHARGEDETAILS('" + GetCode(CmbItemCode.Text) + "') "
        If ITEMTYPE = "Miscellaneous" Then


            query1 = "PARTY_GETMISCTAXCODE  '" + EVNO + "' ,'" + FNNO + "','" + itemcode + "' "
            gconnection.getDataSet(query1, "PARTY_GETMISCTAXCODE")
            If gdataset.Tables("PARTY_GETMISCTAXCODE").Rows.Count > 0 Then
                Sperc = gdataset.Tables("PARTY_GETMISCTAXCODE").Rows(0).Item(2)
                If Sperc > 0 Then
                    Samt = (Val(amount) * Sperc) / 100
                    If Val(gdataset.Tables("PARTY_GETMISCTAXCODE").Rows(0).Item(1)) > 0 Then
                        Staxamt = (Samt * Val(gdataset.Tables("PARTY_GETMISCTAXCODE").Rows(0).Item(1))) / 100
                    End If

                    Return True
                End If
            Else
                Sperc = 0.00
                Samt = 0.00
                Staxamt = 0.00

            End If
        Else
            query1 = "EXEC    PARTY_GETSERVICECHARGEDETAILS '" + itemcode + "' "
            gconnection.getDataSet(query1, "WERT")
            If gdataset.Tables("WERT").Rows.Count > 0 Then
                Sperc = gdataset.Tables("WERT").Rows(0).Item(0)
                If Sperc > 0 Then
                    Samt = (Val(amount) * Sperc) / 100
                    query1 = "EXEC    PARTY_GETSERVICECHARGEtaxperc '" + itemcode + "','" + EVNO + "','" + FNNO + "' "
                    gconnection.getDataSet(query1, "WERTE")
                    If gdataset.Tables("WERTE").Rows.Count > 0 Then
                        If Val(gdataset.Tables("WERTE").Rows(0).Item(0)) > 0 Then
                            Staxamt = (Samt * Val(gdataset.Tables("WERTE").Rows(0).Item(0))) / 100
                        End If

                    End If
                    Return True
                End If
            Else
                Sperc = 0.00
                Samt = 0.00
                Staxamt = 0.00

            End If
        End If

    End Function
    Private Sub cancelfunction(ByVal evno As String, ByVal fnno As String)
        Dim INSERT(0), ITEMCODE, ITEMDESC, menutype, Sql, slno As String
        Dim servicechargeperc, TOTALTAXPERC, canamt, taxamt, totamt As Double

        menutype = "Cancellation"

        query1 = "SELECT * FROM party_fuction_booking_for_events WHERE EVENTBOOKINGNO='" + evno + "' AND FUNCTION_SLNO='" + fnno + "' AND ISNULL(STATUS,'')  not IN ('CANCELLED','CLOSED','STARTED')  "
        gconnection.getDataSet(query1, "party_fuction_booking_for_events")
        If gdataset.Tables("party_fuction_booking_for_events").Rows.Count > 0 Then
        Else

            MessageBox.Show("This Function cannot be cancelled")
            Exit Sub
        End If
        If MessageBox.Show("Do you Want to proceed !", " Cancellation", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
            query1 = " EXEC PARTY_GETCANCELLATION_FUNCTION_ITEMS"
            gconnection.getDataSet(query1, "cancg1")
            If gdataset.Tables("cancg1").Rows.Count > 0 Then
                ITEMCODE = gdataset.Tables("cancg1").Rows(0).Item("POSCODE")
                ITEMDESC = gdataset.Tables("cancg1").Rows(0).Item("posdesc")
                servicechargeperc = gdataset.Tables("cancg1").Rows(0).Item("servicechargeperc")
                TOTALTAXPERC = gdataset.Tables("cancg1").Rows(0).Item("TOTALTAXPERC")

            Else
                MessageBox.Show("Please create one item in Item Mapping Master for cancellation")
                Exit Sub
            End If
        End If

        Try
            query1 = " EXEC PARTY_GETCANCELLATION_FUNCTION_canperc '" + evno + "','" + fnno + "'"
            gconnection.getDataSet(query1, "cancg12")
            If gdataset.Tables("cancg12").Rows.Count > 0 Then
                canamt = gdataset.Tables("cancg12").Rows(0).Item(0)
                taxamt = Val((canamt * TOTALTAXPERC) / 100)
                totamt = canamt + taxamt
                Sperc = servicechargeperc
                Samt = (canamt * Sperc) / 100
                Staxamt = (Samt * TOTALTAXPERC) / 100
            Else
                canamt = 0
                canamt = 0
                taxamt = 0
                totamt = 0
                Sperc = 0
                Samt = 0
                Staxamt = 0
            End If


            Sql = " select isnull( max([ITEMSLNO]),0)+1 as slno  from PARTY_SALES where [eventbookingno]='" & evno & "' and [function_slno]='" & fnno & "'   "
            gconnection.getDataSet(Sql, "ddp")
            If gdataset.Tables("ddp").Rows.Count > 0 Then
                slno = gdataset.Tables("ddp").Rows(0).Item(0)
            End If


            gSQLString = "INSERT INTO PARTY_SALES([eventbookingno],[function_slno],[itemtype],[itemcode],[itemdesc],[ITEMSLNO],[sacno],[rate],[pax],[qty],[discounttype],[dicountcode],[discount],[amount],[amountafterdiscount],[taxamount],[totalamount],[adduser],[addatetime],[void],[LASTAMEMNDMENTID],SERCPERC,SERCAMT  ,SERCTAXAMT  )"
            gSQLString = gSQLString & " values ('" & evno & "','" & fnno & "','" + menutype + "','" & ITEMCODE & "','" & ITEMDESC & "'," & slno & ",'0','1','1','1','','',0," & Val(canamt) & "," & Val(canamt) & " ,'" & Val(taxamt) & "','" & Val(totamt) & "','" & gUsername & "',getdate(),'N','0','" & Val(Sperc) & "','" & Val(Samt) & "','" & Val(Staxamt) & "') "
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = gSQLString


            gSQLString = "INSERT INTO PARTY_SALE_AMENDMENT([eventbookingno],[function_slno],[itemtype],[itemcode],[itemdesc],[ITEMSLNO],[sacno],[rate],[pax],[qty],[discounttype],[dicountcode],[discount],[amount],[amountafterdiscount],[taxamount],[totalamount],[adduser],[addatetime],[void],[LASTAMEMNDMENTID],SERCPERC,SERCAMT  ,SERCTAXAMT  )"
            gSQLString = gSQLString & " values ('" & evno & "','" & fnno & "','" + menutype + "','" & ITEMCODE & "','" & ITEMDESC & "'," & slno & ",'0','1','1','1','','',0," & Val(canamt) & "," & Val(canamt) & " ,'" & Val(taxamt) & "','" & Val(totamt) & "','" & gUsername & "',getdate(),'N','0','" & Val(Sperc) & "','" & Val(Samt) & "','" & Val(Staxamt) & "') "
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = gSQLString




            gSQLString = " Update PARTY_SALES set [eventbookingstatus]=f.eventbookingstatus,[event_type]=f.event_type,[eventdesc]=f.eventdesc,[event_from_date]=f.event_from_date,[event_to_date]=f.event_to_date , function_date= f.function_date, function_fromtime=f.function_fromtime  ,function_totime=f.function_totime from party_fuction_booking_for_events f where f.function_slno=PARTY_SALES.function_slno and f.eventbookingno=PARTY_SALES.eventbookingno and PARTY_SALES.function_slno='" & fnno & "' and PARTY_SALES.eventbookingno='" & evno & "'"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = gSQLString
            gSQLString = " Update PARTY_SALE_AMENDMENT set [eventbookingstatus]=f.eventbookingstatus,[event_type]=f.event_type,[eventdesc]=f.eventdesc,[event_from_date]=f.event_from_date,[event_to_date]=f.event_to_date , function_date= f.function_date, function_fromtime=f.function_fromtime  ,function_totime=f.function_totime from party_fuction_booking_for_events f where f.function_slno=PARTY_SALE_AMENDMENT.function_slno and f.eventbookingno=PARTY_SALE_AMENDMENT.eventbookingno and PARTY_SALE_AMENDMENT.function_slno='" & fnno & "' and PARTY_SALE_AMENDMENT.eventbookingno='" & evno & "'"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = gSQLString

            gSQLString = " INSERT INTO [dbo].[PARTY_SALES_TAX]([eventbookingno],[eventbookingstatus],[event_type],[eventdesc],[LASTAMEMNDMENTID],[function_slno],[itemcode],[sacno],[rate],[pax],[qty],[discount],[amount],[amountafterdiscount],[TAXGROUPCODE],[TAXCODE],[TAXON],[TAXPERCENT],[taxamT],[adduser],[addatetime],[void],[voiduser],[voiddatatime],[ITEMSLNO]) "
            gSQLString = gSQLString & " select [eventbookingno],[eventbookingstatus],[event_type],[eventdesc],[LASTAMEMNDMENTID],[function_slno],[itemcode],[sacno],[rate],[pax],[qty],[discount],[amount],[amountafterdiscount],[TAXGROUPCODE],[TAXCODE],0,taxperc,(taxamount)/(TOTALTAXPERC/TAXPERC),s.[adduser],getdate(),'N',[voiduser],[voiddatatime],[ITEMSLNO] from PARTY_SALES s inner join PARTY_ITEMTAXMAPPING t on s.itemcode=t.poscode where  ISNULL(t.VOID,'')<>'Y' and cast( function_date as date) between efdate and  cast(function_date as date) and  s.function_slno='" & fnno & "' and s.eventbookingno='" & evno & "'  and s.itemcode='" & ITEMCODE & "' AND ISNULL(S.VOID,'')<>'Y'  "
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = gSQLString

            gSQLString = " INSERT INTO [dbo].[PARTY_SALES_TAX]([eventbookingno],[eventbookingstatus],[event_type],[eventdesc],[LASTAMEMNDMENTID],[function_slno],[itemcode],[sacno],[rate],[pax],[qty],[discount],[amount],[amountafterdiscount],[TAXGROUPCODE],[TAXCODE],[TAXON],[TAXPERCENT],[taxamT],[adduser],[addatetime],[void],[voiduser],[voiddatatime],[ITEMSLNO],SERCHG) "
            gSQLString = gSQLString & " select [eventbookingno],[eventbookingstatus],[event_type],[eventdesc],[LASTAMEMNDMENTID],[function_slno],[itemcode],[sacno],[rate],[pax],[qty],[discount],[SERCAMT],[SERCAMT],[TAXGROUPCODE],[TAXCODE],0,taxperc,(SERCTAXAMT)/(TOTALTAXPERC/TAXPERC),s.[adduser],getdate(),'N',[voiduser],[voiddatatime],[ITEMSLNO],'SERCHG' from PARTY_SALES s inner join PARTY_ITEMTAXMAPPING t on s.itemcode=t.poscode where  ISNULL(t.VOID,'')<>'Y' and cast( function_date as date) between efdate and  cast(function_date as date) and  s.function_slno='" & fnno & "' and s.eventbookingno='" & evno & "'  and s.itemcode='" & ITEMCODE & "' AND ISNULL(SERCAMT,0)>0 AND ISNULL(S.VOID,'')<>'Y'  "
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = gSQLString

            gSQLString = " INSERT INTO [dbo].[PARTY_SALE_AMENDMENT_TAX]([eventbookingno],[eventbookingstatus],[event_type],[eventdesc],[LASTAMEMNDMENTID],[function_slno],[itemcode],[sacno],[rate],[pax],[qty],[discount],[amount],[amountafterdiscount],[TAXGROUPCODE],[TAXCODE],[TAXON],[TAXPERCENT],[taxamT],[adduser],[addatetime],[void],[voiduser],[voiddatatime],[ITEMSLNO]) "
            gSQLString = gSQLString & " select [eventbookingno],[eventbookingstatus],[event_type],[eventdesc],[LASTAMEMNDMENTID],[function_slno],[itemcode],[sacno],[rate],[pax],[qty],[discount],[amount],[amountafterdiscount],[TAXGROUPCODE],[TAXCODE],0,taxperc,(taxamount)/(TOTALTAXPERC/TAXPERC),s.[adduser],getdate(),'N',[voiduser],[voiddatatime],[ITEMSLNO] from PARTY_SALES s inner join PARTY_ITEMTAXMAPPING t on s.itemcode=t.poscode where  ISNULL(t.VOID,'')<>'Y' and cast( function_date as date) between efdate and  cast(function_date as date) and  s.function_slno='" & fnno & "' and s.eventbookingno='" & evno & "'  and s.itemcode='" & ITEMCODE & "' AND ISNULL(S.VOID,'')<>'Y' "
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = gSQLString

            gSQLString = " INSERT INTO [dbo].[PARTY_SALE_AMENDMENT_TAX]([eventbookingno],[eventbookingstatus],[event_type],[eventdesc],[LASTAMEMNDMENTID],[function_slno],[itemcode],[sacno],[rate],[pax],[qty],[discount],[amount],[amountafterdiscount],[TAXGROUPCODE],[TAXCODE],[TAXON],[TAXPERCENT],[taxamT],[adduser],[addatetime],[void],[voiduser],[voiddatatime],[ITEMSLNO],SERCHG) "
            gSQLString = gSQLString & " select [eventbookingno],[eventbookingstatus],[event_type],[eventdesc],[LASTAMEMNDMENTID],[function_slno],[itemcode],[sacno],[rate],[pax],[qty],[discount],[SERCAMT],[SERCAMT],[TAXGROUPCODE],[TAXCODE],0,taxperc,(SERCTAXAMT)/(TOTALTAXPERC/TAXPERC),s.[adduser],getdate(),'N',[voiduser],[voiddatatime],[ITEMSLNO],'SERCHG' from PARTY_SALES s inner join PARTY_ITEMTAXMAPPING t on s.itemcode=t.poscode where  ISNULL(t.VOID,'')<>'Y' and cast( function_date as date) between efdate and  cast(function_date as date) and  s.function_slno='" & fnno & "' and s.eventbookingno='" & evno & "'  and s.itemcode='" & ITEMCODE & "' AND ISNULL(SERCAMT,0)>0 AND ISNULL(S.VOID,'')<>'Y' "
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = gSQLString

            query1 = "exec cancelfunction'" & evno & "','" & fnno & "'"
            ReDim Preserve INSERT(INSERT.Length)
            INSERT(INSERT.Length - 1) = query1
            gconnection.MoreTransold(INSERT)
            LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Value)
        Catch ex As Exception

        End Try

    End Sub
    Private Sub gridFNStatus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    'Private Sub gridFNStatus_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles gridFNStatus.CellFormatting
    '    Dim row As DataGridViewRow = gridFNStatus.Rows(e.RowIndex)



    '    If row.Cells(1).Value = "FINALISED" And row.Cells(9).Value = "STARTED" Then
    '        row.DefaultCellStyle.BackColor = Color.Green
    '        row.DefaultCellStyle.ForeColor = Color.White
    '    End If
    '    If row.Cells(1).Value = "FINALISED" And row.Cells(9).Value = "CLOSED" Then
    '        row.DefaultCellStyle.BackColor = Color.Red
    '        row.DefaultCellStyle.ForeColor = Color.White
    '    End If
    '    If row.Cells(1).Value = "PROVISIONAL" Then
    '        row.DefaultCellStyle.BackColor = Color.Yellow
    '        row.DefaultCellStyle.ForeColor = Color.Black
    '    End If
    '    If row.Cells(1).Value = "TENTATIVE" Then
    '        row.DefaultCellStyle.BackColor = Color.LightYellow
    '        row.DefaultCellStyle.ForeColor = Color.Black
    '    End If
    '    If row.Cells(1).Value = "CONFIRMED" Then
    '        row.DefaultCellStyle.BackColor = Color.GreenYellow
    '        row.DefaultCellStyle.ForeColor = Color.Black
    '    End If
    '    If row.Cells(1).Value = "CANCELLED" Then
    '        row.DefaultCellStyle.BackColor = Color.Black
    '        row.DefaultCellStyle.ForeColor = Color.White
    '    End If
    '    If row.Cells(1).Value = "FINALISED" Then
    '        row.DefaultCellStyle.BackColor = Color.MediumVioletRed
    '        row.DefaultCellStyle.ForeColor = Color.White
    '    End If

    'End Sub

    Private Sub gridFNStatus_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles gridFNStatus.CellDoubleClick
        If Not String.IsNullOrEmpty(gridFNStatus.Rows(e.RowIndex).Cells(0).Value) And e.RowIndex >= 0 Then
            lbl_eventno.Text = gridFNStatus.Rows(e.RowIndex).Cells(0).Value.ToString()
            lbl_functionno.Text = gridFNStatus.Rows(e.RowIndex).Cells(5).Value.ToString()
            'Dim Sql = " select isnull(cancelfunction,'')cancelfunction  from party_setup where  cancelfunction='True'   "
            'gconnection.getDataSet(Sql, "sgsdgf")
            If UCase(lbl_functionno.Text) = "TRUE" Then
                If MessageBox.Show("Do You Want to See Details?", "caption", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    printbilll(lbl_eventno.Text, OPERATION_TYPE.Text)
                Else
                End If
            ElseIf UCase(lbl_functionno.Text) = "FALSE" Then
                ''If OPERATION_TYPE.Text = "GOLF COURSE" Then
                ''    lbl_eventno.Text = "G/" & lbl_eventno.Text
                ''ElseIf OPERATION_TYPE.Text = "DRIVING RANGE" Then
                ''    lbl_eventno.Text = "D/" & lbl_eventno.Text
                ''End If
                If gCompName = "KGA" Then
                    If OPERATION_TYPE.Text = "CREDITNOTE" Then
                        query1 = "update GSPIRNUPDATE set void='Y' where billdetails = 'CRN" + lbl_eventno.Text + "' and isnull(Void,'') <> 'Y'"
                        gconnection.getDataSet(query1, "ggst")
                    Else
                        query1 = "update GSPIRNUPDATE set void='Y' where billdetails = '" + lbl_eventno.Text + "' and isnull(Void,'') <> 'Y'"
                        gconnection.getDataSet(query1, "ggst")
                    End If
                Else
                    query1 = "update GSPIRNUPDATE set void='Y' where billdetails = '" + lbl_eventno.Text + "' and isnull(Void,'') <> 'Y'"
                    gconnection.getDataSet(query1, "ggst")
                End If
                LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Value)
            Else
                If MessageBox.Show("Do You Want to Generate E_Invoice?", "caption", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    generateeinvoice(lbl_eventno.Text)
                End If
            End If


            '  LOADALLFUNCTIONS()



        End If
    End Sub
    Private Sub generateeinvoice(ByVal eventno As String)
        Dim BTransNo As Integer
        If OPERATION_TYPE.Text = "POSBILL" Then
            query1 = " select BILLDETAILS from Bill_hdr where billdetails='" + eventno + "'and isnull(delflag,'')<>'Y'"
        ElseIf OPERATION_TYPE.Text = "GOLF COURSE" Then
            query1 = " select DOCNO AS BILLDETAILS from GMS_GREENFEE_HDR where DOCNO='" + eventno + "' and isnull(VOID,'') <> 'Y' AND LOCATION = 'GOLF COURSE' "
        ElseIf OPERATION_TYPE.Text = "DRIVING RANGE" Then
            query1 = " select DOCNO AS BILLDETAILS from GMS_GREENFEE_HDR where DOCNO='" + eventno + "' and isnull(VOID,'') <> 'Y' AND LOCATION = 'DRIVING RANGE' "
        ElseIf OPERATION_TYPE.Text = "COACHING" Then
            query1 = " select DOCNO AS BILLDETAILS from GMS_COACHING_HDR where DOCNO='" + eventno + "' and isnull(VOID,'') <> 'Y'  "
        ElseIf OPERATION_TYPE.Text = "BALLSALE" Then
            query1 = " select DOCNO AS BILLDETAILS from GMS_BALL_HDR where DOCNO='" + eventno + "' and isnull(VOID,'') <> 'Y'  "
        ElseIf OPERATION_TYPE.Text = "HIRINGGOLF" Then
            query1 = " select DOCNO AS BILLDETAILS from GMS_GOLFHIRING_HDR where DOCNO='" + eventno + "' and isnull(VOID,'') <> 'Y'  "
        ElseIf OPERATION_TYPE.Text = "HIRINGDRIVING" Then
            query1 = " select DOCNO AS BILLDETAILS from GMS_GOLFHIRING_HDR where DOCNO='" + eventno + "' and isnull(VOID,'') <> 'Y'  "
        ElseIf OPERATION_TYPE.Text = "CAMPFEE" Then
            query1 = " select RECEIPTNO AS BILLDETAILS from GMS_CAMPREC_DET where RECEIPTNO='" + eventno + "' and isnull(VOID,'') <> 'Y'  "
        ElseIf OPERATION_TYPE.Text = "CARTISSUE" Then
            query1 = " select REC_NO AS BILLDETAILS from GMS_CARTISSUE_DET where REC_NO='" + eventno + "' and isnull(VOID,'') <> 'Y'   "
        ElseIf OPERATION_TYPE.Text = "SHORT" Then
            query1 = " select DOCNO AS BILLDETAILS from GMS_SHORTGAME_HDR where DOCNO='" + eventno + "' and isnull(VOID,'') <> 'Y'   "
        ElseIf OPERATION_TYPE.Text = "SUBSCRIPTION" Then
            query1 = " select billno as BILLDETAILS from SUBSPOSTING where Billno='" + eventno + "'and isnull(void,'')<>'Y'"
        ElseIf OPERATION_TYPE.Text = "ENTFEE" Then
            query1 = " select DOCNO as BILLDETAILS from ENTRANCEFEE_RECEIPTS where DOCNO='" + eventno + "'and isnull(Freeze,'')<>'Y'"
        ElseIf OPERATION_TYPE.Text = "DEBITNOTE" Then
            query1 = " select distinct VoucherNo as BILLDETAILS from journalentry where VoucherNo='" + eventno + "'and isnull(void,'')<>'Y' and  VoucherType IN ('CDN','ACDN','CCDN') and CreditDebit='DEBIT'"
            If gCompName = "KGA" Then
                query1 = " select distinct VoucherNo as BILLDETAILS from journalentry where VoucherNo='" + eventno + "'and isnull(void,'')<>'Y' and  VoucherType IN ('DBN') and CreditDebit='DEBIT'"
            End If
        ElseIf OPERATION_TYPE.Text = "CREDITNOTE" Then
            query1 = " select distinct VoucherNo as BILLDETAILS from journalentry where VoucherNo='" + eventno + "'and isnull(void,'')<>'Y' and  VoucherType IN ('CCN') and CreditDebit='CREDIT'"
            If gCompName = "KGA" Then
                query1 = " select distinct VoucherNo as BILLDETAILS from journalentry where VoucherNo='" + eventno + "'and isnull(void,'')<>'Y' and  VoucherType IN ('CRN') and CreditDebit='CREDIT'"
            ElseIf gCompName = "SATC" Then
                query1 = " select distinct VoucherNo as BILLDETAILS from journalentry where VoucherNo='" + eventno + "'and isnull(void,'')<>'Y' and  VoucherType IN ('VCN') and CreditDebit='CREDIT'"
            End If
        ElseIf OPERATION_TYPE.Text = "INVOICE" Then
            query1 = " select distinct VoucherNo as BILLDETAILS from VW_SERVICEBILLVOUCHERprint where VoucherNo='" + eventno + "'and isnull(void,'')<>'Y'"
        ElseIf OPERATION_TYPE.Text = "PARTY" Then
            If gCompName = "SATC" Then
                query1 = " select distinct VNo as BILLDETAILS from Tbl_RoomParty_Settlement where VNo='" + eventno + "' and isnull(void,'')<>'Y' AND TType = 'PARTY' "
            ElseIf gCompName = "JSCA" Then
                query1 = " select distinct bill_no as BILLDETAILS from RoomParty_eInvoice where BILL_NO ='" + eventno + "' "
            Else
                query1 = " select distinct BILLNO as BILLDETAILS from PARTY_hDR where BillNo='" + eventno + "' and isnull(freeze,'')<>'Y' AND BOOKINGTYPE = 'BILLING' "
            End If
        ElseIf OPERATION_TYPE.Text = "ROOM" Then
            If gCompName = "SATC" Then
                query1 = " select distinct VNo as BILLDETAILS from Tbl_RoomParty_Settlement where VNo='" + eventno + "'and isnull(void,'')<>'Y' AND TType = 'ROOM' "
            ElseIf gCompName = "BCL" Then
                query1 = " select distinct bill_no as BILLDETAILS from RPT_ROOMBILL_EINVOICE where bill_no ='" + eventno + "' "
            ElseIf gCompName = "CSC" Then
                query1 = " select distinct bill_no as BILLDETAILS from RPT_ROOMBILL_EINVOICE where bill_no ='" + eventno + "' "
            ElseIf gCompName = "ITC" Then
                query1 = " select distinct bill_no as BILLDETAILS from RPT_ROOMBILL_EINVOICE where bill_no ='" + eventno + "' "
            ElseIf gCompName = "JSCA" Then
                query1 = " select distinct bill_no as BILLDETAILS from RoomParty_eInvoice where BILL_NO ='" + eventno + "' "
            Else
                query1 = " select distinct BILLNO as BILLDETAILS from roomcheckin where isnull(BILLNO,'') = '" + eventno + "' And RoomStatus = 'OCCUPIED' and isnull(Checkout,'') = 'Y' "
            End If
        ElseIf OPERATION_TYPE.Text = "GUESTENTRY" Then
            query1 = " select BILL_NO as BILLDETAILS from GR_BILL_HDR where BILL_NO='" + eventno + "'and isnull(VOID,'')<>'Y' "
        End If
        gconnection.getDataSet(query1, "party_billdetails")
        If gdataset.Tables("party_billdetails").Rows.Count > 0 Then
        Else

            MessageBox.Show("Bill has generated not Generated" + CStr(gdataset.Tables("party_billdetails").Rows(0).Item(0)))
            Exit Sub
        End If
        If OPERATION_TYPE.Text = "POSBILL" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','POSBILL'"
        ElseIf OPERATION_TYPE.Text = "GOLF COURSE" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','GOLF COURSE'"
        ElseIf OPERATION_TYPE.Text = "DRIVING RANGE" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','DRIVING RANGE'"
        ElseIf OPERATION_TYPE.Text = "COACHING" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','COACHING'"
        ElseIf OPERATION_TYPE.Text = "BALLSALE" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','BALLSALE'"
        ElseIf OPERATION_TYPE.Text = "HIRINGGOLF" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','HIRINGGOLF'"
        ElseIf OPERATION_TYPE.Text = "HIRINGDRIVING" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','HIRINGDRIVING'"
        ElseIf OPERATION_TYPE.Text = "CAMPFEE" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','CAMPFEE'"
        ElseIf OPERATION_TYPE.Text = "CARTISSUE" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','CARTISSUE'"
        ElseIf OPERATION_TYPE.Text = "SHORT" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','SHORT'"
        ElseIf OPERATION_TYPE.Text = "SUBSCRIPTION" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','SUBSCRIPTION'"
        ElseIf OPERATION_TYPE.Text = "ENTFEE" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','ENTFEE'"
        ElseIf OPERATION_TYPE.Text = "DEBITNOTE" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','DEBITNOTE'"
        ElseIf OPERATION_TYPE.Text = "CREDITNOTE" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','CREDITNOTE'"
        ElseIf OPERATION_TYPE.Text = "INVOICE" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','INVOICE'"
        ElseIf OPERATION_TYPE.Text = "PARTY" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','PARTY'"
        ElseIf OPERATION_TYPE.Text = "ROOM" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','ROOM'"
        ElseIf OPERATION_TYPE.Text = "GUESTENTRY" Then
            query1 = " Exec SP_GetInvoice '" + eventno + "','GUESTENTRY'"
        End If
        ' Select Case* From party_fuction_booking_for_events Where eventbookingno ='" + eventno + "' and isnull(void,'')<>'y'"
        gconnection.getDataSet(query1, "ddff")

        If gdataset.Tables("ddff").Rows.Count > 0 Then

            If gCompName = "KGA" Then
                BTransNo = gconnection.getvalue("Select Isnull(Max(transno),0) as TransNo from gstbiltranshdr_log Where Doc_No = '" & eventno & "'")
                SQLSTRING = "select isnull(Val_TotInvVal,0) as Val_TotInvVal from gstbiltranshdr_log  where transno = " & BTransNo & ""
                gconnection.getDataSet(SQLSTRING, "CalAmt")
                If gdataset.Tables("CalAmt").Rows.Count > 0 Then
                    If MessageBox.Show("Total Value of Bill is : " & Format(gdataset.Tables("CalAmt").Rows(0).Item(0), "0.00") & ", Want to Continue?", "Bill Value", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
            End If
            'query1 = " Select * from party_fuction_booking_for_events where eventbookingno='" + eventno + "' and  isnull(status,'')<>'closed' and isnull(status,'') not in ('Cancelled') and eventbookingstatus<>'CANCELLED' and isnull(void,'')<>'y'"
            'gconnection.getDataSet(query1, "dd")
            'If gdataset.Tables("dd").Rows.Count > 0 Then
            '    MessageBox.Show("All the functions of the events has not closed yet")
            'Else
            'query1 = "exec PROC_PARTY_GENERATEBILL '" + eventno + "'"
            '    gconnection.ExcuteStoreProcedure(query1)

            'query1 = "   Select  (select case when (select clienttype from PARTY_EVENT_BOOKING where eventbookingno='" + eventno + "')='MEMBER' then (Select  isnull(gstinno,'') from membermaster where mcode=(select top 1  clientcode from PARTY_EVENT_BOOKING where eventbookingno='" + eventno + "')) else (select  isnull(gstinno,'') from pms_nonmember_master where mcode=(select top 1  clientcode from PARTY_EVENT_BOOKING where eventbookingno='" + eventno + "')) end )as gstinno"
            'gconnection.getDataSet(query1, "dd11")
            'If gdataset.Tables("dd11").Rows.Count > 0 Then

            ''If OPERATION_TYPE.Text = "GOLF COURSE" Then
            ''    eventno = "G/" & eventno
            ''ElseIf OPERATION_TYPE.Text = "DRIVING RANGE" Then
            ''    eventno = "D/" & eventno
            ''End If

            query1 = "select * from GSPIRNUPDATE where billdetails = '" + eventno + "' and isnull(Void,'') <> 'Y'"
            gconnection.getDataSet(query1, "ggst")
            If gdataset.Tables("ggst").Rows.Count > 0 Then
                MessageBox.Show("IRN Already Created,First Delete then try again for new Registration")
                Exit Sub
            End If
            Dim Reqid As String
            query1 = "select top 1 ReqId from GSPIRNUPDATE where billdetails =  '" + eventno + "' AND ISNULL(void,'') = 'Y' order by adddatetime desc"
            gconnection.getDataSet(query1, "ggst1")
            If gdataset.Tables("ggst1").Rows.Count Then
                Reqid = gdataset.Tables("ggst1").Rows(0).Item(0).ToString()
            End If
            vOutfile = Mid("" & (Rnd() * 800000), 1, 8)
            Reqid = Math.Round(Convert.ToDecimal(vOutfile))

            query1 = "  Select  gspappid,gspappsecret,user_name,password,gstin from gspdetails "
            gconnection.getDataSet(query1, "gspdetails")
            If gdataset.Tables("gspdetails").Rows.Count > 0 Then
                Dim gspappid, gspappsecret, user_name, password, gstin As String
                gspappid = Trim(gdataset.Tables("gspdetails").Rows(0).Item("gspappid"))
                gspappsecret = Trim(gdataset.Tables("gspdetails").Rows(0).Item("gspappsecret"))
                user_name = Trim(gdataset.Tables("gspdetails").Rows(0).Item("user_name"))
                password = Trim(gdataset.Tables("gspdetails").Rows(0).Item("password"))
                gstin = Trim(gdataset.Tables("gspdetails").Rows(0).Item("gstin"))
                Dim xmlobj
                Dim strPostData, params As String
                Dim USERID, SID, PWD, SMCODE As String
                Dim i As Integer
                Dim url As String
                Dim HttpReq As New WinHttpRequest

                Try
                    Dim token As String
                    SMCODE = eventno
                    url = "https://gsp.adaequare.com/gsp/authenticate?action=GSP&grant_type=token"
                    HttpReq.Open("POST", url, False)
                    HttpReq.SetRequestHeader("gspappid", gspappid)
                    HttpReq.SetRequestHeader("gspappsecret", gspappsecret)
                    HttpReq.Send()
                    Dim result2 As String
                    result2 = HttpReq.ResponseText
                    If Len(result2) > 1 Then
                        Dim ser As JObject = JObject.Parse(result2)
                        Dim data As List(Of JToken) = ser.Children().ToList
                        Dim output As String = ""

                        ' desbool = False
                        For Each item As JProperty In data
                            item.CreateReader()
                            Select Case UCase(item.Name)
                                Case "ACCESS_TOKEN"
                                    '  desbool = True
                                    token = Mid(item.Value.ToString(), 2, Len(item.Value.ToString()) - 2)
                            End Select
                        Next
                    End If
                    url = "https://gsp.adaequare.com/enriched/ei/api/invoice"
                    Dim insert As String
                    Dim dt As DataTable
                    SQLSTRING = "exec get_einvoice '" & SMCODE & "','" & gdataset.Tables("ddff").Rows(0).Item(0) & "'"
                    dt = gconnection.GetValues(SQLSTRING)
                    If dt.Rows.Count > 0 Then
                        params = dt.Rows(0).Item(0)
                    End If
                    url = "https://gsp.adaequare.com/enriched/ei/api/invoice"
                    Try
                        'Dim s As String = "0BD5628ACD927FDC1E9B9B39QW8767DE64B6B40D"
                        's = Trim(s.ToString())
                        'Dim Str As String
                        '' Str = s.ToString()
                        'Dim Str1 As String = s.Replace(vbCr, "").Replace(vbLf, "")
                        'Str = Str1.ToString()
                        ''  HttpReq.Open("POST", url, False)
                        HttpReq.Open("POST", url, False)
                        'Dim tttoken As String = "{"content-Type":"application/json","user_name":"adqgspjkusr1","password":"Gsp@1234","gstin":"01AMBPG7773M002","requestid":"PAR/" + SMCODE,"Authorization""Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJnc3"}"
                        HttpReq.SetRequestHeader("Content-Type", "application/json")
                        HttpReq.SetRequestHeader("user_name", user_name)
                        HttpReq.SetRequestHeader("password", password)
                        HttpReq.SetRequestHeader("gstin", gstin)
                        HttpReq.SetRequestHeader("requestid", Reqid + SMCODE) '"PAR" +
                        'HttpReq.SetRequestHeader("Client Id", "9042BCE129364B80B032E774DD8E903F")
                        'HttpReq.SetRequestHeader("Client Secret", "D6A83A9CGC3F1G4B2FG9ADFGBA9374E8F633")
                        HttpReq.SetRequestHeader("Authorization", "Bearer " + token)
                        '  HttpReq.SetRequestHeader("Content-Type", "Content-Type: Application/json")
                        ' HttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                        HttpReq.Send(params)
                        Dim result As String
                        result = HttpReq.ResponseText

                        '  Me.bKEY = Encoding.ASCII.GetBytes(s)
                        '  HttpReq.SetRequestHeader("Content-Type", "X-Auth-Key :" & s)
                        '   HttpReq.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded")
                        ' HttpReq.SetRequestHeader("Content-Type", "Content-Type:application/json")
                        '  HttpReq.Send(params)
                        '  Dim result As String
                        ' result = HttpReq.ResponseText
                        'result = (Mid(result, 2, Len(result) - 2))


                        Dim CC As New SqlConnection
                        CC.ConnectionString = gconnection.Getconnection()
                        CC.Open()

                        Dim osqlcommand As New SqlCommand
                        osqlcommand = New SqlCommand("proc_GSPIRNUPDATE", CC)
                        osqlcommand.CommandType = CommandType.StoredProcedure
                        Dim desbool As Boolean
                        desbool = False
                        Dim msgbool As Boolean
                        msgbool = False
                        Dim AckNobool As Boolean
                        AckNobool = False
                        Dim AckDtbool As Boolean
                        AckDtbool = False
                        Dim Irnbool As Boolean
                        Irnbool = False
                        Dim SignedInvoicebool As Boolean
                        SignedInvoicebool = False
                        Dim SignedQRCodebool As Boolean
                        SignedQRCodebool = False
                        Dim Statusbool As Boolean
                        Statusbool = False

                        If Len(result) > 1 Then
                            Dim ser As JObject = JObject.Parse(result)
                            Dim data As List(Of JToken) = ser.Children().ToList
                            Dim output As String = ""


                            For Each item As JProperty In data
                                item.CreateReader()
                                Select Case item.Name
                                    Case "success"
                                        desbool = True
                                        osqlcommand.Parameters.Add("@val", SqlDbType.VarChar, 8000).Value = Mid(item.Value.ToString(), 1, Len(item.Value.ToString()) - 1)
                                    Case "message"
                                        msgbool = True
                                        osqlcommand.Parameters.Add("@msg", SqlDbType.VarChar, 8000).Value = Mid(item.Value.ToString(), 2, Len(item.Value.ToString()) - 2)
                                    Case "result"
                                        Dim ser1 As JObject = JObject.Parse(item.Value.ToString())
                                        Dim data1 As List(Of JToken) = ser1.Children().ToList
                                        Dim output1 As String = ""
                                        For Each item1 As JProperty In data1
                                            item1.CreateReader()
                                            Select Case item1.Name
                                                Case "AckNo"
                                                    AckNobool = True
                                                    osqlcommand.Parameters.Add("@AckNo", SqlDbType.VarChar, 1000).Value = item1.Value.ToString()
                                                Case "AckDt"
                                                    AckDtbool = True
                                                    osqlcommand.Parameters.Add("@AckDt", SqlDbType.DateTime).Value = Mid(item1.Value.ToString(), 2, Len(item1.Value.ToString()) - 2)
                                                Case "Irn"
                                                    Irnbool = True
                                                    osqlcommand.Parameters.Add("@Irn", SqlDbType.Text).Value = Mid(item1.Value.ToString(), 2, Len(item1.Value.ToString()) - 1)
                                                Case "SignedInvoice"
                                                    SignedInvoicebool = True
                                                    osqlcommand.Parameters.Add("@SignedInvoice", SqlDbType.Text).Value = Mid(item1.Value.ToString(), 2, Len(item1.Value.ToString()) - 1)
                                                Case "SignedQRCode"
                                                    SignedQRCodebool = True
                                                    osqlcommand.Parameters.Add("@SignedQRCode", SqlDbType.Text).Value = Mid(item1.Value.ToString(), 2, Len(item1.Value.ToString()) - 1)
                                                Case "Status"
                                                    Statusbool = True
                                                    osqlcommand.Parameters.Add("@Status", SqlDbType.VarChar, 100).Value = Mid(item1.Value.ToString(), 2, Len(item1.Value.ToString()) - 1)
                                            End Select
                                        Next
                                End Select
                            Next
                        End If

                        If desbool = False Then
                            osqlcommand.Parameters.Add("@val", SqlDbType.VarChar, 8000).Value = "FALSE"
                        End If

                        If msgbool = False Then
                            osqlcommand.Parameters.Add("@msg", SqlDbType.VarChar, 8000).Value = "FAILED"
                        End If

                        If AckNobool = False Then
                            osqlcommand.Parameters.Add("@AckNo", SqlDbType.VarChar, 8000).Value = ""
                        End If

                        If AckDtbool = False Then
                            osqlcommand.Parameters.Add("@AckDt", SqlDbType.DateTime).Value = "01-jan-1900"
                        End If

                        If Irnbool = False Then
                            osqlcommand.Parameters.Add("@Irn", SqlDbType.Text).Value = ""
                        End If

                        If SignedInvoicebool = False Then
                            osqlcommand.Parameters.Add("@SignedInvoice", SqlDbType.Text).Value = ""
                        End If

                        If SignedQRCodebool = False Then
                            osqlcommand.Parameters.Add("@SignedQRCode", SqlDbType.Text).Value = ""
                        End If

                        If Statusbool = False Then
                            osqlcommand.Parameters.Add("@Status", SqlDbType.VarChar, 100).Value = ""
                        End If
                        'If desbool = False Then
                        '        Dim result1 As String
                        '        result1 = result.Replace(vbCr, "").Replace(vbLf, "")
                        '        result1 = result1.Replace(", ", "")
                        '        result1 = result1.Replace(" '", "")
                        '        result1 = result1.Replace("""", "")
                        '        osqlcommand.Parameters.Add("@val", SqlDbType.VarChar, 1000).Value = result1
                        '    End If

                        'osqlcommand.Parameters.Add("@tbl", SqlDbType.VarChar, 50).Value = "mobile_membermasteruinserted"
                        osqlcommand.Parameters.Add("@adduser", SqlDbType.VarChar, 50).Value = gUsername
                        If OPERATION_TYPE.Text = "CREDITNOTE" Then
                            If gCompName = "KGA" Then
                                osqlcommand.Parameters.Add("@key", SqlDbType.VarChar, 50).Value = "CRN" + SMCODE
                            Else
                                osqlcommand.Parameters.Add("@key", SqlDbType.VarChar, 50).Value = SMCODE
                            End If
                        Else
                            osqlcommand.Parameters.Add("@key", SqlDbType.VarChar, 50).Value = SMCODE
                        End If
                        ' varchar(50),@col varchar(50),@key varchar(50)
                        osqlcommand.ExecuteNonQuery()
                        If desbool = True Then
                            ''If Reqid = "" Then
                            ''    Reqid = "0"
                            ''Else
                            ''    Reqid = (Val(Reqid) + 1).ToString()
                            ''End If
                            SQLSTRING = "UPDATE GSPIRNUPDATE SET ReqId = '" + Reqid + "' where billdetails = '" + SMCODE + "' and isnull(Void,'') <> 'Y'"
                            gconnection.ExcuteStoreProcedure(SQLSTRING)
                        End If

                        '  exec mobileupdstatus '','mobile_membermasteruinserted','membership_number','a1'
                    Catch exception As Exception

                    End Try

                    'MsgBox(HttpReq.ResponseText)


                Catch
                End Try
            End If
            ' End If
            '  End If
        Else
            MessageBox.Show("No any events found!")
        End If
        LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Text)
    End Sub
    Private Sub printbilll(ByVal bookingno As String, ByVal ttype As String)
        'query1 = " select billdetails,case when billdate<='29 aug 2021' then 'PAR\'+right('000000'+cast(BILLDETAILS as varchar(20)) ,6) else 'PAR/'+right('000000'+cast(BILLDETAILS as varchar(20)) ,6)+'/'+finyear end AS VOUCHERNO from party_BILLDETAILS where eventbookingno='" + bookingno + "'"
        'gconnection.getDataSet(query1, "ddffF")
        'If gdataset.Tables("ddffF").Rows.Count > 0 Then
        '    Dim Sel As Boolean
        '    Dim QrPath As String
        '    Dim qAFILE As File
        '    Dim QrCodeCard As String
        '    Dim Cardcode As String


        '    Dim path As String
        '    Dim pic As Image
        '    Dim irn As String
        '    path = ""
        '    irn = ""
        '    query1 = "select * from GSPIRNUPDATE where billdetails = 'par" + bookingno + "' and isnull(Void,'') <> 'Y'"
        '    gconnection.getDataSet(query1, "tttt")
        '    If gdataset.Tables("tttt").Rows.Count > 0 Then
        '        Cardcode = gdataset.Tables("tttt").Rows(0).Item("billdetails").ToString()
        '        QrCodeCard = gdataset.Tables("tttt").Rows(0).Item("billdetails").ToString()
        '        irn = gdataset.Tables("tttt").Rows(0).Item("irn").ToString()
        '        Call QrGenerate(gdataset.Tables("tttt").Rows(0).Item("SignedQRCode").ToString())

        '        '' ''Cardcode = "UPI-INDC055"
        '        '' ''QrCodeCard = "upi://pay?pa=kargolfa@icici&pn=KarnatakaGolfAssociation&tn=INDC055&tr=ATC10/3656&am=3&cu=INR&mc=5411"
        '        '' ''Call QrGenerate("upi://pay?pa=kargolfa@icici&pn=KarnatakaGolfAssociation&tn=INDC055&tr=ATC10/3656&am=3&cu=INR&mc=5411")
        '        If QrCodeCard <> "" Then
        '            QrPath = Application.StartupPath & "\Reports\" & Cardcode & ".jpeg"
        '            If qAFILE.Exists(QrPath) Then
        '                qAFILE.Delete(QrPath)
        '            End If
        '            Pic_QR.Image.Save(QrPath, System.Drawing.Imaging.ImageFormat.Jpeg)
        '        End If
        '    Else

        '    End If



        '    ''  MessageBox.Show("Save QR Done")
        '    billno = gdataset.Tables("ddffF").Rows(0).Item(0)
        '    vouchernott = gdataset.Tables("ddffF").Rows(0).Item(1)
        '    ViewInvoices("Tax Invoice", billno, vouchernott, QrPath, irn, bookingno)
        '    Else
        '        MessageBox.Show("Bill Has not generated")
        '    End If
        'End Sub
        'Private Sub ViewInvoices(ByVal bookingno As String, ByVal ttype As String)
        Try

            Dim TransNo As Integer
            Dim Bill_NO As String
            Dim TYPE(0) As String
            Bill_NO = bookingno
            'gconnection.ExcuteStoreProcedure("Exec SP_GetInvoice '" & Bill_NO & "','" & ttype & "'")
            TransNo = gconnection.getvalue("Select Isnull(Max(transno),0) as TransNo from gstbiltranshdr_log Where Doc_No = '" & Bill_NO & "'")
            'Call TaxInvoice3Inch(TransNo)

            Dim sqlstring As String
            Dim Viewer As New ReportViwer
            Dim r

            'If Cmb_Printsize.Text = "A4" Then
            r = New TaxInvoiceA4
            'E 'lseIf Cmb_Printsize.Text = "I4" Then
            ' r = New TaxInvoice4Inch
            '  Else
            'r = New TaxInvoice3Inch
            '  End If
            sqlstring = "select * from gstbiltransDET_log where transno = " & TransNo & ""
            Call Viewer.GetDetails1(sqlstring, "Table2", r)
            sqlstring = "select Doc_No,'-Rate of CGST – ' as Item_PrdDesc,Round(Item_GstRt / 2,2) as Item_GstRt,Sum(Item_CgstAmt) as Item_SgstAmt from gstbiltransDET_log where transno = " & TransNo & " and isnull(Item_GstRt,0) > 0 group by Doc_No,Item_GstRt Union all "
            sqlstring = sqlstring & " select Doc_No,'-Rate of SGST – ' as Item_PrdDesc,Round(Item_GstRt / 2,2) as Item_GstRt,Sum(Item_SgstAmt) as Item_SgstAmt from gstbiltransDET_log where transno = " & TransNo & " and isnull(Item_GstRt,0) > 0 group by Doc_No,Item_GstRt Union all "
            sqlstring = sqlstring & " select Doc_No,'-Cess' as Item_PrdDesc,Round(Item_CesRt,2) as Item_GstRt,Sum(Item_CesAmt) as Item_SgstAmt from gstbiltransDET_log where transno = " & TransNo & " and isnull(Item_CesRt,0) > 0 group by Doc_No,Item_CesRt "
            Call Viewer.GetDetails1(sqlstring, "Table3", r)
            sqlstring = "select * from gstbiltranshdr_log where transno = " & TransNo & ""
            Call Viewer.GetDetails1(sqlstring, "Table1", r)
            Viewer.Show()
            If gPrint = True Then
                Viewer.CrystalReportViewer1.PrintReport()
                Viewer.Close()
            End If

        Catch ex As Exception
            MsgBox("Problem in report:" & ex.Message, MsgBoxStyle.Critical)
            'Timer1.Enabled = True
        End Try
    End Sub
    Private Sub QrGenerate(ByVal Qry As String)
        Dim TxtString As String
        If Qry <> "" Then
            TxtString = Mid(Qry, 1, Len(Qry) - 1)
            'Dim bmp As Bitmap = MessagingToolkit.QRCode.Codec.QRCodeEncoder.Encode(TxtString.ToString())
            'New Bitmap(encoder.Encode(textencode.Text), New Size(200, 200)); 

            Pic_QR.Image = QR_Generator.Encode(TxtString.ToString())
            '            Dim encoder As New QRCodeEncoder()
            'encoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
            'encoder.QRCodeScale = 10;
            'Bitmap img = encoder.Encode("ddef04d8-7450-42d1-bc48-a94c3d6dae66");
        Else
            Pic_QR.Image = Nothing
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        gridFNStatus.DataSource = gdataset.Tables("PAY1")
        Dim cm As CurrencyManager = BindingContext(gridFNStatus.DataSource)
        If Trim(TextBox1.Text) <> "" Then
            Dim intCount As Integer = 0

            'For k = 0 To gridFNStatus.RowCount - 1
            '    gridFNStatus.Rows(k).Visible = False

            'Next
            For Each R In gridFNStatus.Rows
                cm.SuspendBinding()
                R.Visible = False
                cm.ResumeBinding()

            Next

            Dim MAXROW As Integer = gridFNStatus.RowCount - 1
            Dim MAXCOL As Integer = gridFNStatus.ColumnCount - 1
            For Each myRow As DataGridViewRow In gridFNStatus.Rows
                Dim intCount1 As Integer = 0
                For Each myCell In myRow.Cells
                    If (gridFNStatus.Rows(intCount).Cells(intCount1).Value.ToString().ToUpper().Contains(TextBox1.Text.ToUpper())) Then
                        gridFNStatus.Rows(intCount).Visible = True

                    End If
                    intCount1 = intCount1 + 1
                Next
                intCount = intCount + 1
                If intCount >= MAXROW Then
                    Exit For
                End If
            Next
        ElseIf Keys.KeyCode = 65535 Then

            For Each R In gridFNStatus.Rows
                cm.SuspendBinding()
                R.Visible = True
            Next
        End If

    End Sub

    Private Sub DTP_TODATE_ValueChanged(sender As Object, e As EventArgs) Handles DTP_TODATE.ValueChanged
        If DateDiff(DateInterval.Day, DTP_FROMDATE.Value, DTP_TODATE.Value) < 0 Then
            MsgBox("To Date Cannot be less than from date")
            Exit Sub
        Else
            LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Value)
        End If
    End Sub

    Private Sub DTP_FROMDATE_ValueChanged(sender As Object, e As EventArgs) Handles DTP_FROMDATE.ValueChanged
        If DateDiff(DateInterval.Day, DTP_FROMDATE.Value, DTP_TODATE.Value) < 0 Then
            MsgBox("To Date Cannot be less than from date")
            Exit Sub
        Else
            LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Value)
        End If
    End Sub
    Private Sub changecolor()
        For i = 0 To gridFNStatus.Rows.Count - 1
            If Not String.IsNullOrEmpty(gridFNStatus.Rows(i).Cells(1).Value) Then
                lbl_eventno.Text = gridFNStatus.Rows(i).Cells(1).Value
                ''If gridFNStatus.Rows(i).Cells(6).Value = "TRUE" Then
                ''    gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.Green
                ''    gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.White
                ''End If
                ''If gridFNStatus.Rows(i).Cells(6).Value <> "TRUE" Then
                ''    gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.Red
                ''    gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.White
                ''End If

                If gridFNStatus.Rows(i).Cells(5).Value = "TRUE" Then
                    gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.Green
                    gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
                If gridFNStatus.Rows(i).Cells(5).Value = "FALSE" Then
                    gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
                If gridFNStatus.Rows(i).Cells(5).Value = "" Then
                    gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.Black
                    gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.White
                End If
                'If gridFNStatus.Rows(i).Cells(3).Value = "PROVISIONAL" Then
                '    gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.YellowGreen
                '    gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                'End If
                'If gridFNStatus.Rows(i).Cells(3).Value = "TENTATIVE" Then
                '    gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.LightYellow
                '    gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                'End If
                'If gridFNStatus.Rows(i).Cells(3).Value = "CONFIRMED" Then
                '    gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
                '    gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.Black
                'End If
                'If gridFNStatus.Rows(i).Cells(3).Value = "CANCELLED" Then
                '    gridFNStatus.Rows(i).DefaultCellStyle.BackColor = Color.Black
                '    gridFNStatus.Rows(i).DefaultCellStyle.ForeColor = Color.White
                'End If
                'gridFNStatus.Columns(0).Width = 450
            End If
        Next
        SETWIDTH()
    End Sub
    Private Sub gridFNStatus_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridFNStatus.ColumnHeaderMouseClick
        changecolor()
    End Sub

    Private Sub btn_cancelfunction_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you Sure! To cancel this function, All the items will deleted and cancellation charges will be applicable", "Cancel Event", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then

            cancelfunction(lbl_eventno.Text, lbl_functionno.Text)


        End If

    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Text)
    End Sub
    'Private Sub reload()
    '    DTP_FROMDATE.Value = serverdate
    '    DTP_TODATE.Value = DateAdd(DateInterval.Day, 7, serverdate)
    '    LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Value)
    '    BTN_SAVE.Enabled = False
    '    changecolor()
    'End Sub
    'Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
    '    LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Value)
    'End Sub

    Private Sub gridFNStatus_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles gridFNStatus.RowsAdded
        changecolor()
    End Sub

    Private Sub gridFNStatus_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles gridFNStatus.CellContentClick

    End Sub

    Private Sub E_invoicing_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LOADALLFUNCTIONS(DTP_FROMDATE.Value, DTP_TODATE.Text)
    End Sub

    Private Sub Label_Freeze_Click(sender As Object, e As EventArgs) Handles Label_Freeze.Click

    End Sub
End Class