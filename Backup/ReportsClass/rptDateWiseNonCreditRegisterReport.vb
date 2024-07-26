Imports System.Data.SqlClient
Imports System.IO
Public Class rptDateWiseNonCreditRegisterReport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal PAGEHEADER() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim POSDAYTOTAL, MEMBERTOTAL, GRANDTOTAL, DBLDATENET, DBLDATEPAID, DBLDATEBALANCE As Double
        Dim DBLBASIC, DBLTAX, DBLNET, DBLPAID, DBLBALANCE, DBLDATEBASIC, DBLDATETAX As Double
        Dim J, I, POSCOUNT, POSGRAND, POSTOTAL As Integer
        Dim POSDESC, MEMBERCODE, BILLDETAILS As String
        Dim POSBOOL, MEMBERBOOL, BILLDATEBOOL As Boolean
        Dim BILLDATE As Date
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call ReportHeader(PAGEHEADER, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "NONCREDITREGISTERDATEWISE")
            If gdataset.Tables("NONCREDITREGISTERDATEWISE").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("NONCREDITREGISTERDATEWISE").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(PAGEHEADER, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If DateValue(BILLDATE) <> DateValue(dr("BILLDATE")) Then
                        If BILLDATEBOOL = True Then
                            'Filewrite.WriteLine(StrDup(135, "."))
                            'pagesize = pagesize + 1
                            'Filewrite.Write("{0,-32}{1,12}{2,12}{3,12}{4,12}", "Day Total =====>", Format(Val(DBLDATEBASIC), "0.00"), Format(Val(DBLDATETAX), "0.00"), Format(Val(DBLDATENET), "0.00"), Format(Val(DBLDATEPAID), "0.00"))
                            'Filewrite.WriteLine("{0,-4}{1,-18}{2,-12}{3,10}", "", "", "", Format(Val(DBLDATEBALANCE), "0.00"))
                            'pagesize = pagesize + 1
                            'Filewrite.WriteLine(StrDup(135, "."))
                            'pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-30}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                            pagesize = pagesize + 1
                            BILLDATE = DateValue(dr("BILLDATE"))
                            MEMBERCODE = ""
                            MEMBERBOOL = False
                            DBLDATEBASIC = 0 : DBLDATETAX = 0 : DBLDATENET = 0 : DBLDATEPAID = 0
                        Else
                            Filewrite.WriteLine("{0,-30}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                            pagesize = pagesize + 1
                            BILLDATE = DateValue(dr("BILLDATE"))
                            BILLDATEBOOL = True
                            MEMBERCODE = ""
                            MEMBERBOOL = False
                            DBLDATEBASIC = 0 : DBLDATETAX = 0 : DBLDATENET = 0 : DBLDATEPAID = 0
                        End If
                    End If
                    If MEMBERCODE <> Trim(CStr(dr("MCODE"))) Then
                        If MEMBERBOOL = True Then
                            Filewrite.WriteLine(StrDup(135, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-32}{1,12}{2,12}{3,12}{4,12}", "Member Total =====>", Format(Val(DBLBASIC), "0.00"), Format(Val(DBLTAX), "0.00"), Format(Val(DBLNET), "0.00"), Format(Val(DBLPAID), "0.00"))
                            Filewrite.WriteLine("{0,-4}{1,-18}{2,-12}{3,10}", "", "", "", Format(Val(DBLBALANCE), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("MNAME"))), 1, 30) & "[ " & Mid(Trim(CStr(dr("MCODE"))), 1, 10) & " ]")
                            pagesize = pagesize + 1
                            MEMBERCODE = Trim(CStr(dr("MCODE")))
                            pagesize = pagesize + 1
                            MEMBERTOTAL = 0
                            DBLBASIC = 0 : DBLTAX = 0 : DBLNET = 0 : DBLPAID = 0
                        Else
                            Filewrite.WriteLine("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("MNAME"))), 1, 30) & "[ " & Mid(Trim(CStr(dr("MCODE"))), 1, 10) & " ]")
                            pagesize = pagesize + 1
                            MEMBERCODE = Trim(CStr(dr("MCODE")))
                            pagesize = pagesize + 1
                            POSCOUNT = 0
                            MEMBERBOOL = True
                            DBLBASIC = 0 : DBLTAX = 0 : DBLNET = 0 : DBLPAID = 0
                        End If
                    End If
                    If BILLDETAILS <> Trim(CStr(dr("BILLDETAILS"))) Then
                        Filewrite.Write("{0,-32}", Mid(Trim(CStr(dr("BILLDETAILS"))), 1, 20))
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 8))
                        DBLBASIC = Val(DBLBASIC) + Format(Val(dr("BASIC")), "0.00")
                        DBLDATEBASIC = Val(DBLDATEBASIC) + Format(Val(dr("BASIC")), "0.00")
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 8))
                        DBLTAX = Val(DBLTAX) + Format(Val(dr("TAXAMOUNT")), "0.00")
                        DBLDATETAX = Val(DBLDATETAX) + Format(Val(dr("TAXAMOUNT")), "0.00")
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 8))
                        DBLNET = Val(DBLNET) + Format(Val(dr("NETAMOUNT")), "0.00")
                        DBLDATENET = Val(DBLDATENET) + Format(Val(dr("NETAMOUNT")), "0.00")
                        GRANDTOTAL = Val(GRANDTOTAL) + Format(Val(dr("NETAMOUNT")), "0.00")
                        Filewrite.Write("{0,12}{1,-4}", Mid(Format(Val(dr("PAIDAMOUNT")), "0.00"), 1, 8), "")
                        DBLPAID = Val(DBLPAID) + Format(Val(dr("PAIDAMOUNT")), "0.00")
                        DBLDATEPAID = Val(DBLDATEPAID) + Format(Val(dr("PAIDAMOUNT")), "0.00")
                        Filewrite.Write("{0,-18}", Mid(Trim(CStr(dr("RECEIPTNUMBER"))), 1, 15))
                        If Format(CDate(dr("RECEIPTDATE")), "dd-MM-yyyy") = "1900-01-01" Then
                            Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("RECEIPTDATE")), "dd/MM/yyyy"), 1, 12))
                        Else
                            Filewrite.Write("{0,-12}", "")
                        End If
                        If Val(dr("BALANCEAMT")) = 0 Then
                            Filewrite.Write("{0,10}{1,-4}", "", "")
                        Else
                            Filewrite.Write("{0,10}{1,-4}", Mid(Format(Val(dr("BALANCEAMT")), "0.00"), 1, 8), "")
                            DBLBALANCE = Val(DBLBALANCE) + Format(Val(dr("BALANCEAMT")), "0.00")
                            DBLDATEBALANCE = Val(DBLDATEBALANCE) + Format(Val(dr("BALANCEAMT")), "0.00")
                        End If
                        Filewrite.WriteLine("{0,-10}", Mid(Trim(CStr(dr("SERVERCODE"))), 1, 15))
                        pagesize = pagesize + 1
                        BILLDETAILS = Trim(CStr(dr("BILLDETAILS")))
                    End If
                Next dr
                '''**************************************** PRINT TOTAL DOCUMENT  ************************************************'''
                Filewrite.WriteLine(StrDup(135, "-"))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-32}{1,12}{2,12}{3,12}{4,12}", "Member Total =====>", Format(Val(DBLBASIC), "0.00"), Format(Val(DBLTAX), "0.00"), Format(Val(DBLNET), "0.00"), Format(Val(DBLPAID), "0.00"))
                Filewrite.WriteLine("{0,-4}{1,-18}{2,-12}{3,10}", "", "", "", Format(Val(DBLBALANCE), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "-"))
                pagesize = pagesize + 1
                '''**************************************** COMPLETE  TOTAL DOCUMENT   ************************************************'''
                '''**************************************** PRINT DAY TOTAL  ************************************************'''
                'Filewrite.WriteLine(StrDup(135, "."))
                'pagesize = pagesize + 1
                'Filewrite.Write("{0,-32}{1,12}{2,12}{3,12}{4,12}", "Day Total =====>", Format(Val(DBLDATEBASIC), "0.00"), Format(Val(DBLDATETAX), "0.00"), Format(Val(DBLDATENET), "0.00"), Format(Val(DBLDATEPAID), "0.00"))
                'Filewrite.WriteLine("{0,-4}{1,-18}{2,-12}{3,10}", "", "", "", Format(Val(DBLDATEBALANCE), "0.00"))
                'pagesize = pagesize + 1
                'Filewrite.WriteLine(StrDup(135, "."))
                'pagesize = pagesize + 1
                '''**************************************** PRINT DAY TOTAL  ************************************************'''
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-20}{1,-18}{2,-20}{3,10}", "Total Document :", Format(Val(POSGRAND), "0"), "Grand Total =====>", Format(Val(GRANDTOTAL), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
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
    Private Function ReportHeader(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-32}{1,12}{2,12}{3,12}", "BILL DATE", "BASIC", PrintTaxheading1, "NET")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-10}", "PAID", "", "RECEIPT", "RECEIPT", "BALANCE", "", "SERVER")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-32}{1,12}{2,12}{3,12}", "BILL NUMBER", "AMOUNT", PrintTaxheading2, "AMOUNT")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-10}", "AMOUNT", "", "NUMBER", "DATE", "AMOUNT", "", "CODE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
