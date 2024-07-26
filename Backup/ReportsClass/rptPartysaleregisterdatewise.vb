Imports System.Data.SqlClient
Imports System.IO
Public Class rptPartysaleregisterdatewise
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal SQLSTRING2 As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblMcodeBasic, dblMcodeTax, dblMcodeTotal, dblMcodeBalance, dblMcodePaid, dblDayBasic, dblDayTax As Double
        Dim dblGrandBasic, dblGrandTax, dblGrandTotal, dblGrandBalance, dblGrandPaid, dblDayTotal, dblDayBalance, dblDayPaid As Double
        Dim Billdatebool, Mcodebool As Boolean
        Dim CstrMcode, Cstrbilldetails As String
        Dim Billdate As Date
        Dim I As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call ReportHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "PARTYSALEREGISTERDATEWISE")
            If gdataset.Tables("PARTYSALEREGISTERDATEWISE").Rows.Count > 0 Then
                ''FOR TOTAL CALCULATION
                ''=====================
                'gconnection.getDataSet(SQLSTRING2, "TOTCOUNT")

                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("PARTYSALEREGISTERDATEWISE").Rows
                    If CStr(dr("MCODE")) = "KR1328" Then
                        Debug.WriteLine("AA")
                    End If
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If Format(DateValue(Billdate), "dd/MM/yyyy") <> Format(CDate(dr("BILLDATE")), "dd/MM/yyyy") Then
                        If Billdatebool = True Then
                            Filewrite.WriteLine(StrDup(135, "."))
                            pagesize = pagesize + 1
                            dblDayBalance = Math.Floor(dblDayTotal) - Math.Floor(dblDayPaid)
                            dblGrandBalance = Val(dblGrandBalance) + Val(dblDayBalance)
                            Filewrite.Write("{0,-30}{1,12}{2,10}{3,12}", "Day Total =====>", Format(Val(dblDayBasic), "0.00"), Format(Val(dblDayTax), "0.00"), Format(Val(dblDayTotal), "0.00"))
                            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblDayPaid), "0.00"), "", "", "", Format(Math.Round(Val(dblDayBalance)), "0.00"))
                            'Filewrite.Write("{0,-30}{1,12}{2,10}{3,12}", "Day Total =====>", Format(Val(gdataset.Tables("TOTCOUNT").Rows(I).Item("BASICTOT")), "0.00"), Format(Val(gdataset.Tables("TOTCOUNT").Rows(I).Item("TAXTOT")), "0.00"), Format(Val(gdataset.Tables("TOTCOUNT").Rows(I).Item("NETTOT")), "0.00"))
                            'Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(gdataset.Tables("TOTCOUNT").Rows(I).Item("PAIDAMTTOT")), "0.00"), "", "", "", Format(Val(dblDayBalance), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "."))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-30}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                            pagesize = pagesize + 1
                            Billdate = CDate(dr("BILLDATE"))
                            dblDayBasic = 0 : dblDayTax = 0 : dblDayTotal = 0 : dblDayBalance = 0 : dblDayPaid = 0

                            'I = I + 1
                        Else
                            Filewrite.WriteLine("{0,-30}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                            pagesize = pagesize + 1
                            Billdate = CDate(dr("BILLDATE"))

                            Billdatebool = True

                        End If
                    End If
                    If CStr(CstrMcode) <> CStr(dr("MCODE")) Then
                        If Mcodebool = True Then
                            Filewrite.WriteLine(StrDup(135, "-"))
                            pagesize = pagesize + 1
                            dblMcodeBalance = Math.Floor(dblMcodeTotal) - Math.Floor(dblMcodePaid)
                            Filewrite.Write("{0,-30}{1,12}{2,10}{3,12}", "Party Total =====>", Format(Val(dblMcodeBasic), "0.00"), Format(Val(dblMcodeTax), "0.00"), Format(Val(dblMcodeTotal), "0.00"))
                            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblMcodePaid), "0.00"), "", "", "", Format(Math.Round(Val(dblMcodeBalance)), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-10}", Mid(Trim(CStr(dr("MCODE"))), 1, 10))
                            Filewrite.WriteLine("{0,-20}", "=>" & Mid(Trim(CStr(dr("MNAME"))), 1, 18))
                            pagesize = pagesize + 1
                            CstrMcode = Trim(dr("MCODE"))
                            dblMcodeBasic = 0 : dblMcodeTax = 0 : dblMcodeTotal = 0 : dblMcodeBalance = 0 : dblMcodePaid = 0
                        Else

                            Filewrite.Write("{0,-10}", Mid(Trim(CStr(dr("MCODE"))), 1, 5))
                            Filewrite.WriteLine("{0,-20}", "=>" & Mid(Trim(CStr(dr("MNAME"))), 1, 18))
                            pagesize = pagesize + 1
                            CstrMcode = Trim(dr("MCODE"))
                            Mcodebool = True
                        End If
                    End If
                    '====
                    If Trim(CStr(Cstrbilldetails)) <> Trim(CStr(dr("BILLDETAILS"))) Then
                        dblMcodeBasic = Val(dblMcodeBasic) + Format(Val(dr("BASIC")), "0.00")
                        dblDayBasic = Val(dblDayBasic) + Format(Val(dr("BASIC")), "0.00")
                        'dblGrandBasic = Val(dblGrandBasic) + Format(Val(dr("BASIC")), "0.00")
                        dblMcodeTax = Val(dblMcodeTax) + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblDayTax = Val(dblDayTax) + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblGrandTax = Val(dblGrandTax) + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblMcodeTotal = Val(dblMcodeTotal) + Format(Val(dr("NETAMOUNT")), "0.00")
                        dblDayTotal = Val(dblDayTotal) + Format(Val(dr("NETAMOUNT")), "0.00")
                        dblGrandTotal = Val(dblGrandTotal) + Format(Val(dr("NETAMOUNT")), "0.00")
                    End If


                    dblMcodePaid = Val(dblMcodePaid) + Format(Val(dr("PAIDAMT")), "0.00")
                    dblDayPaid = Val(dblDayPaid) + Format(Val(dr("PAIDAMT")), "0.00")
                    dblGrandPaid = Val(dblGrandPaid) + Format(Val(dr("PAIDAMT")), "0.00")


                    '====




                    Filewrite.Write("{0,-30}", Mid(Trim(CStr(dr("BILLDETAILS"))), 1, 30))
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 12))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 12))
                    Filewrite.Write("{0,12}{1,-4}", Mid(Format(Val(dr("PAIDAMT")), "0.00"), 1, 12), "")

                    ''''dblMcodeBasic = Val(dblMcodeBasic) + Format(Val(dr("BASIC")), "0.00")
                    ''''dblDayBasic = Val(dblDayBasic) + Format(Val(dr("BASIC")), "0.00")
                    ''''dblGrandBasic = Val(dblGrandBasic) + Format(Val(dr("BASIC")), "0.00")

                    ''''dblMcodeTax = Val(dblMcodeTax) + Format(Val(dr("TAXAMOUNT")), "0.00")
                    ''''dblDayTax = Val(dblDayTax) + Format(Val(dr("TAXAMOUNT")), "0.00")
                    ''''dblGrandTax = Val(dblGrandTax) + Format(Val(dr("TAXAMOUNT")), "0.00")

                    ''''dblMcodeTotal = Val(dblMcodeTotal) + Format(Val(dr("NETAMOUNT")), "0.00")
                    ''''dblDayTotal = Val(dblDayTotal) + Format(Val(dr("NETAMOUNT")), "0.00")
                    ''''dblGrandTotal = Val(dblGrandTotal) + Format(Val(dr("NETAMOUNT")), "0.00")

                    ''''dblMcodePaid = Val(dblMcodePaid) + Format(Val(dr("PAIDAMT")), "0.00")
                    ''''dblDayPaid = Val(dblDayPaid) + Format(Val(dr("PAIDAMT")), "0.00")
                    ''''dblGrandPaid = Val(dblGrandPaid) + Format(Val(dr("PAIDAMT")), "0.00")
                    Filewrite.Write("{0,-18}", Mid(Trim(CStr(dr("RECEIPTNO"))), 1, 15))

                    If Format(CDate(dr("RECEIPTDATE")), "dd-MM-yyyy") <> "1900-01-01" Then
                        Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("RECEIPTDATE")), "dd/MM/yyyy"), 1, 12))
                    Else
                        Filewrite.Write("{0,-12}", "")
                    End If
                    If Val(dr("BALANCEAMT")) = 0 Then
                        Filewrite.Write("{0,10}{1,-4}", "", "")
                    Else
                        Filewrite.Write("{0,10}{1,-4}", Mid(Format(Val(dr("BALANCEAMT")), "0.00"), 1, 8), "")
                        dblMcodeBalance = Val(dblMcodeBalance) + Format(Val(dr("BALANCEAMT")), "0.00")
                        'dblDayBalance = Val(dblDayBalance) + Format(Val(dr("BALANCEAMT")), "0.00")
                        'dblGrandBalance = Val(dblGrandBalance) + Format(Val(dr("BALANCEAMT")), "0.00")
                    End If
                    Filewrite.WriteLine("{0,-10}", Mid(Trim(CStr(dr("SERVERCODE"))), 1, 12))
                    pagesize = pagesize + 1
                    Cstrbilldetails = CStr(dr("BILLDETAILS"))
                    ''======
                    'End If
                    ''========
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                '''********************************************************* Print Room Total ************************************************'''
                Filewrite.WriteLine(StrDup(135, "-"))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-30}{1,12}{2,10}{3,12}", "Party Total =====>", Format(Val(dblMcodeBasic), "0.00"), Format(Val(dblMcodeTax), "0.00"), Format(Val(dblMcodeTotal), "0.00"))
                Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblMcodePaid), "0.00"), "", "", "", Format(Val(dblMcodeBalance), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "-"))
                pagesize = pagesize + 1
                '''********************************************************* Print Day Total ************************************************'''
                Filewrite.WriteLine(StrDup(135, "."))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-30}{1,12}{2,10}{3,12}", "Day Total =====>", Format(Val(dblDayBasic), "0.00"), Format(Val(dblDayTax), "0.00"), Format(Val(dblDayTotal), "0.00"))
                Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblDayPaid), "0.00"), "", "", "", Format(Val(dblDayBalance), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "."))
                pagesize = pagesize + 1
                '''********************************************************* Print Grand Total ************************************************'''
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-30}{1,12}{2,10}{3,12}", "Grand Total =====>", Format(Val(dblGrandBasic), "0.00"), Format(Val(dblGrandTax), "0.00"), Format(Val(dblGrandTotal), "0.00"))
                Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblGrandPaid), "0.00"), "", "", "", Format(Math.Round(Val(dblGrandBalance)), "0.00"))
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


    Private Function ReportHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
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
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(15))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,12}{2,10}{3,12}", "BILL DATE", "BASIC", PrintTaxheading1, "NET")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-10}", "PAID", "", "RECEIPT", "RECEIPT", "BALANCE", "", "SERVER")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,12}{2,10}{3,12}", "PARTY BILL NO", "AMOUNT", PrintTaxheading2, "AMOUNT")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-10}", "AMOUNT", "", "NUMBER", "DATE", "AMOUNT", "", "CODE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
