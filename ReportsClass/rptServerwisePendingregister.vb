Imports System.Data.SqlClient
Imports System.IO
Public Class rptServerwisePendingregister
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Detailsection(ByVal Sqlstring As String, ByVal SQLSTRING2 As String, ByVal pageheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim i As Integer
        Dim boolKOTdetails, boolServer, boolgrouptotal As Boolean
        Dim ServerName, Billdetails, MemberCode, Rowprint, Todaydate, sCode As String
        Dim KOTAmount, GroupAmount, GrandAmount, BearerTotal, TotalAmount, totDoc, gDocno As Double
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(pageheading, mskfromdate, msktodate)
            gconnection.getDataSet(Sqlstring, "PENDINBILLREGISTER")
            If gdataset.Tables("PENDINBILLREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("PENDINBILLREGISTER").Rows
                    If pagesize > 54 Then
                        Filewrite.Write(StrDup(79, "-"))
                        pagesize = pagesize + 1
                        'pagesize = 0
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(pageheading, mskfromdate, msktodate)
                    End If

                    If sCode <> Trim(CStr(dr("SCODE"))) Then
                        If boolgrouptotal = True Then
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-17}", "Total Document(s):")
                            Filewrite.Write("{0,-9}", Val(totDoc))
                            Filewrite.Write("{0,27}", "Group Total =====>")
                            Filewrite.WriteLine("{0,24}", Format(Math.Round(Val(TotalAmount)), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                        End If
                        Filewrite.WriteLine(dr("SNAME") & "  " & dr("SCODE"))
                        boolgrouptotal = True
                        TotalAmount = 0
                        totDoc = 0
                        sCode = Trim(CStr(dr("SCODE")))
                    End If
                    Filewrite.Write("{0,36}", Mid(Trim(Format(dr("BILLDATE"), "dd/MM/yyyy")), 1, 15))
                    Filewrite.Write("{0,2}", "")
                    Filewrite.Write("{0,-18}", Mid(Trim(dr("BILLDETAILS")), 1, 20))
                    Filewrite.Write("{0,-6}", Mid(Trim(dr("PAYMENTMODE")), 1, 6))
                    Filewrite.Write("{0,-7}", Mid(Trim(dr("MCODE")), 1, 30))
                    Filewrite.WriteLine("{0,9}", Mid(Format(Math.Round(Val(dr("TOTALAMOUNT"))), "0.00"), 1, 12))
                    pagesize = pagesize + 1
                    GrandAmount = Val(GrandAmount) + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    TotalAmount = Val(TotalAmount) + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    totDoc = totDoc + 1
                    gDocno = gDocno + 1
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "-"))
                Filewrite.Write("{0,-17}", "Total Document(s):")
                Filewrite.Write("{0,-9}", Val(totDoc))
                Filewrite.Write("{0,27}", "Group Total =====>")
                Filewrite.WriteLine("{0,24}", Format(Math.Round(Val(TotalAmount)), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "-"))
                pagesize = pagesize + 1

                ''''******************************************** $  GRAND TOTAL $   ****************************************''''
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
                TotalAmount = Format(Val(GrandAmount), "0.00")
                Filewrite.WriteLine("{0,17}{1,-17}{2,-20}{3,22}", "TOTAL DOCUMENT(S) :", gDocno, "GRAND TOTAL :=====>", Mid(Format(Math.Round(Val(TotalAmount)), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine()

                ''''************************************** $  COMPLETE GRAND TOTAL $   **************************************''''
                ''''Sqlstring = "SELECT PAYMENTMODE,SUM(ISNULL(TOTALAMOUNT ,0)) AS AMOUNT "
                ''''Sqlstring = Sqlstring & " FROM BILL_HDR WHERE PAYMENTMODE NOT IN('CLUB','CREDIT') AND CAST(CONVERT(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN "
                ''''Sqlstring = Sqlstring & " '" & Format(mskfromdate, "yyyy-MM-dd") & "' AND ' " & Format(msktodate, "yyyy-MM-dd") & "'"
                ''''Sqlstring = Sqlstring & " AND PAYMENTMODE NOT IN('CLUB','CREDIT') AND ISNULL(DELFLAG,'') <>'Y' AND "
                ''''Sqlstring = Sqlstring & " ISNULL(CROSTATUS,'')<>'Y' AND BILLDETAILS NOT IN (SELECT BILLNO FROM RECEIPT_DETAILS) "
                ''''Sqlstring = Sqlstring & " GROUP BY PAYMENTMODE"

                gconnection.getDataSet(SQLSTRING2, "GROUPTOTAL")
                If gdataset.Tables("GROUPTOTAL").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("grouptotal").Rows.Count - 1
                        Filewrite.WriteLine("{0,36}{1,-16}{2,26}", "", gdataset.Tables("grouptotal").Rows(i).Item("paymentmode"), Format(Math.Round(Val(gdataset.Tables("grouptotal").Rows(i).Item("amount"))), "0.00"))
                    Next
                End If
                Filewrite.WriteLine(StrDup(79, "="))
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Public Function Ason_Section(ByVal Sqlstring As String, ByVal SQLSTRING2 As String, ByVal pageheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date, ByRef Paymode() As String, ByVal AsOnDate As Date)
        'Public Function Detailsection()
        Dim i As Integer
        Dim boolKOTdetails, boolServer, boolgrouptotal As Boolean
        Dim ServerName, Billdetails, MemberCode, Rowprint, Todaydate, sCode, Pm As String
        Dim KOTAmount, GroupAmount, GrandAmount, BearerTotal, TotalAmount, totDoc, gDocno As Double
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader_ason(pageheading, mskfromdate, msktodate, AsOnDate)
            gconnection.getDataSet(Sqlstring, "PENDINBILLREGISTER")
            If gdataset.Tables("PENDINBILLREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("PENDINBILLREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(79, "-"))
                        pagesize = pagesize + 1
                        'pagesize = 0
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader_ason(pageheading, mskfromdate, msktodate, AsOnDate)
                    End If

                    If sCode <> Trim(CStr(dr("SCODE"))) Then
                        If boolgrouptotal = True Then
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-17}", "Total Document(s):")
                            Filewrite.Write("{0,-9}", Val(totDoc))
                            Filewrite.Write("{0,27}", "Group Total =====>")
                            Filewrite.WriteLine("{0,24}", Format(Math.Round(Val(TotalAmount)), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                        End If
                        Filewrite.WriteLine(dr("SNAME") & "  " & dr("SCODE"))
                        boolgrouptotal = True
                        TotalAmount = 0
                        totDoc = 0
                        sCode = Trim(CStr(dr("SCODE")))
                    End If
                    Filewrite.Write("{0,36}", Mid(Trim(Format(dr("BILLDATE"), "dd/MM/yyyy")), 1, 15))
                    Filewrite.Write("{0,2}", "")
                    Filewrite.Write("{0,-18}", Mid(Trim(dr("BILLDETAILS")), 1, 20))
                    Filewrite.Write("{0,-6}", Mid(Trim(dr("PAYMENTMODE")), 1, 6))
                    Filewrite.Write("{0,-7}", Mid(Trim(dr("MCODE")), 1, 30))
                    Filewrite.WriteLine("{0,9}", Mid(Format(Math.Round(Val(dr("TOTALAMOUNT"))), "0.00"), 1, 12))
                    pagesize = pagesize + 1
                    GrandAmount = Val(GrandAmount) + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    TotalAmount = Val(TotalAmount) + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    totDoc = totDoc + 1
                    gDocno = gDocno + 1
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "-"))
                Filewrite.Write("{0,-17}", "Total Document(s):")
                Filewrite.Write("{0,-9}", Val(totDoc))
                Filewrite.Write("{0,27}", "Group Total =====>")
                Filewrite.WriteLine("{0,24}", Format(Math.Round(Val(TotalAmount)), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "-"))
                pagesize = pagesize + 1

                ''''******************************************** $  GRAND TOTAL $   ****************************************''''
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
                TotalAmount = Format(Val(GrandAmount), "0.00")
                Filewrite.WriteLine("{0,17}{1,-17}{2,-20}{3,22}", "TOTAL DOCUMENT(S) :", gDocno, "GRAND TOTAL :=====>", Mid(Format(Math.Round(Val(TotalAmount)), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine()

                ''''************************************** $  COMPLETE GRAND TOTAL $   **************************************''''
                '''For i = 0 To Paymode.Length - 1
                '''    Pm = Pm & "'" & Paymode(i) & "'" & ","
                '''Next
                '''Pm = Mid(Pm, 1, (Len(Pm) - 1))
                '''Sqlstring = "SELECT  FROM BILL_HDR WHERE CAST(CONVERT(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN "
                '''Sqlstring = Sqlstring & " '" & Format(mskfromdate, "yyyy-MM-dd") & "' AND ' " & Format(msktodate, "yyyy-MM-dd") & "'"
                '''Sqlstring = Sqlstring & " AND PAYMENTMODE NOT IN('CLUB','CREDIT') AND ISNULL(DELFLAG,'') <>'Y' AND AND ISNULL(CROSTATUS,'')<>'Y' AND BILLDETAILS NOT IN (SELECT BILLNO FROM RECEIPT_DETAILS) ORDER BY SCODE"
                '''Sqlstring = "SELECT PAYMENTMODE,SUM(ISNULL(TOTALAMOUNT ,0)) AS AMOUNT "
                '''Sqlstring = Sqlstring & " FROM BILL_HDR WHERE PAYMENTMODE NOT IN('CLUB','CREDIT') AND CAST(CONVERT(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN "
                '''Sqlstring = Sqlstring & " '" & Format(mskfromdate, "yyyy-MM-dd") & "' AND ' " & Format(msktodate, "yyyy-MM-dd") & "'"
                '''Sqlstring = Sqlstring & " AND PAYMENTMODE  IN(" & Pm & ") AND ISNULL(DELFLAG,'') <>'Y' AND "
                '''Sqlstring = Sqlstring & " ISNULL(CROSTATUS,'')<>'Y' AND BILLDETAILS NOT IN (SELECT BILLNO FROM RECEIPT_DETAILS) "
                '''Sqlstring = Sqlstring & " GROUP BY PAYMENTMODE"
                gconnection.getDataSet(SQLSTRING2, "GROUPTOTAL")
                If gdataset.Tables("GROUPTOTAL").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("grouptotal").Rows.Count - 1
                        Filewrite.WriteLine("{0,36}{1,-16}{2,26}", "", gdataset.Tables("grouptotal").Rows(i).Item("paymentmode"), Format(Math.Round(Val(gdataset.Tables("grouptotal").Rows(i).Item("amount"))), "0.00"))
                    Next
                End If
                Filewrite.WriteLine(StrDup(79, "="))
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function PrintHeader(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        Dim prnDoc As String
        pagesize = 0
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''

            ' Filewrite.Write(Chr(15))
            Filewrite.Write(Chr(18) & Chr(27) + "E" & Chr(27) + "F")
            Filewrite.WriteLine("{0,23}{1,20}{2,11}{3,25}", "", "", " ", "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            prnDoc = "SERVER/                   BILL        BILL                                 NET"
            Filewrite.WriteLine(prnDoc)
            'Filewrite.WriteLine("{0,-15}{1,-12}{2,-18}{3,5}{4,-4}{5,-6}{6,8}{7,11}", "SERVER", "KOT", "KOT", "QTY", "", "UOM", "RATE", "NET")
            pagesize = pagesize + 1
            prnDoc = "                          DATE        NUMBER            MODE  CODE      AMOUNT"
            'Filewrite.WriteLine("{0,-15}{1,-12}{2,-18}{3,5}{4,-4}{5,-6}{6,8}{7,11}", "LOCATION", "DATE", "NUMBER", "", "", "", "", "AMOUNT")
            Filewrite.WriteLine(prnDoc)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function PrintHeader_ason(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date, ByVal asondate As Date)
        Dim I As Integer
        Dim prnDoc As String
        pagesize = 0
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''

            ' Filewrite.Write(Chr(15))
            Filewrite.Write(Chr(18) & Chr(27) + "E" & Chr(27) + "F")
            Filewrite.WriteLine("{0,23}{1,20}{2,11}{3,25}", "", "", " ", "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,73}{2,10}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.Write(Chr(14) & Chr(15) & "AS ON  " & Format(asondate, "MMM dd,yyyy"))
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            prnDoc = "SERVER/                   BILL        BILL                                 NET"
            Filewrite.WriteLine(prnDoc)
            'Filewrite.WriteLine("{0,-15}{1,-12}{2,-18}{3,5}{4,-4}{5,-6}{6,8}{7,11}", "SERVER", "KOT", "KOT", "QTY", "", "UOM", "RATE", "NET")
            pagesize = pagesize + 1
            prnDoc = "                          DATE        NUMBER            MODE  CODE      AMOUNT"
            'Filewrite.WriteLine("{0,-15}{1,-12}{2,-18}{3,5}{4,-4}{5,-6}{6,8}{7,11}", "LOCATION", "DATE", "NUMBER", "", "", "", "", "AMOUNT")
            Filewrite.WriteLine(prnDoc)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function

End Class
