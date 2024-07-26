Imports System.Data.SqlClient
Imports System.io
Public Class rptRoomsaleregisterdatewise
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblRoomBasic, dblRoomTax, dblRoomSERCHG, dblRoomPACK, dblRoomTotal, dblRoomBalance, dblRoomPaid, dblDayBasic, dblDayTax, dblDayTotal, dblDayBalance, dblDayPaid, DBLDAYPACK, DBLDAYSERCHG As Double
        Dim dblGrandBasic, dblGrandTax, dblGrandTotal, dblGrandBalance, dblGrandPaid, DBLGRANDPACK, DBLGRANDSERCHG, dblRoomno As Double
        Dim Billdatebool, Roomnobool As Boolean
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
            gconnection.getDataSet(SQLSTRING, "ROOMSALEREGISTERDATEWISE")
            If gdataset.Tables("ROOMSALEREGISTERDATEWISE").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ROOMSALEREGISTERDATEWISE").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(160, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If Format(DateValue(Billdate), "dd/MM/yyyy") <> Format(CDate(dr("BILLDATE")), "dd/MM/yyyy") Then
                        If Billdatebool = True Then
                            Filewrite.WriteLine(StrDup(160, "."))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-30}{1,12}{2,12}{3,12}{4,12}{5,12}", "Day Total =====>", Format(Val(dblDayBasic), "0.00"), Format(Val(dblDayTax), "0.00"), Format(Val(DBLDAYPACK), "0.00"), Format(Val(DBLDAYSERCHG), "0.00"), Format(Val(dblDayTotal), "0.00"))
                            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblDayPaid), "0.00"), "", "", "", Format(Val(dblDayBalance), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(160, "."))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-32}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                            pagesize = pagesize + 1
                            Billdate = CDate(dr("BILLDATE"))
                            dblDayBasic = 0 : dblDayTax = 0 : DBLDAYPACK = 0 : DBLDAYSERCHG = 0 : dblDayTotal = 0 : dblDayBalance = 0
                        Else
                            Filewrite.WriteLine("{0,-32}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                            pagesize = pagesize + 1
                            Billdate = CDate(dr("BILLDATE"))
                            Billdatebool = True
                        End If
                    End If
                    If Val(dblRoomno) <> Val(dr("ROOMNO")) Then
                        If Roomnobool = True Then
                            Filewrite.WriteLine(StrDup(160, "-"))
                            pagesize = pagesize + 1
                            'Filewrite.Write("{0,-30}{1,12}{2,12}{3,12}{4,12}{5,12}", "Room Total =====>", Format(Val(dblRoomBasic), "0.00"), Format(Val(dblRoomTax), "0.00"), Format(Val(dblRoomTotal), "0.00"))
                            'Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblRoomPaid), "0.00"), "", "", "", Format(Val(dblRoomBalance), "0.00"))

                            Filewrite.Write("{0,-30}{1,12}{2,12}{3,12}{4,12}{5,12}", "Room Total =====>", Format(Val(dblRoomBasic), "0.00"), Format(Val(dblRoomTax), "0.00"), Format(Val(dblRoomPACK), "0.00"), Format(Val(dblRoomSERCHG), "0.00"), Format(Val(dblRoomTotal), "0.00"))
                            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblRoomPaid), "0.00"), "", "", "", Format(Val(dblRoomBalance), "0.00"))

                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(160, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-10}", Mid(Val(dr("ROOMNO")), 1, 5))
                            Filewrite.WriteLine("{0,-22}", "Guest Room No. : " & Mid(Val(dr("ROOMNO")), 1, 5))
                            pagesize = pagesize + 1
                            dblRoomno = Val(dr("ROOMNO"))
                            dblRoomBasic = 0 : dblRoomTax = 0 : dblRoomPACK = 0 : dblRoomTax = 0 : dblRoomTotal = 0 : dblRoomBalance = 0
                        Else
                            Filewrite.Write("{0,-10}", Mid(Val(dr("ROOMNO")), 1, 5))
                            Filewrite.WriteLine("{0,-22}", "Guest Room No. : " & Mid(Val(dr("ROOMNO")), 1, 5))
                            pagesize = pagesize + 1
                            dblRoomno = Val(dr("ROOMNO"))
                            Roomnobool = True
                        End If
                    End If
                    Filewrite.Write("{0,-30}", Mid(Trim(CStr(dr("BILLNO"))), 1, 20))
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 8))
                    dblRoomBasic = Val(dblRoomBasic) + Format(Val(dr("BASIC")), "0.00")
                    dblDayBasic = Val(dblDayBasic) + Format(Val(dr("BASIC")), "0.00")
                    dblGrandBasic = Val(dblGrandBasic) + Format(Val(dr("BASIC")), "0.00")
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("SALETAX")), "0.00"), 1, 8))

                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("PACKAMOUNT")), "0.00"), 1, 8))
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("SER_CHG")), "0.00"), 1, 8))

                    dblRoomTax = Val(dblRoomTax) + Format(Val(dr("SALETAX")), "0.00")
                    dblRoomPACK = Val(dblRoomPACK) + Format(Val(dr("PACKAMOUNT")), "0.00")
                    dblRoomSERCHG = Val(dblRoomSERCHG) + Format(Val(dr("SER_CHG")), "0.00")


                    DBLDAYSERCHG = Val(DBLDAYSERCHG) + Format(Val(dr("SER_CHG")), "0.00")
                    DBLGRANDSERCHG = Val(DBLGRANDSERCHG) + Format(Val(dr("SER_CHG")), "0.00")

                    DBLDAYPACK = Val(DBLDAYPACK) + Format(Val(dr("PACKAMOUNT")), "0.00")
                    DBLGRANDPACK = Val(DBLGRANDPACK) + Format(Val(dr("PACKAMOUNT")), "0.00")

                    dblDayTax = Val(dblDayTax) + Format(Val(dr("SALETAX")), "0.00")
                    dblGrandTax = Val(dblGrandTax) + Format(Val(dr("SALETAX")), "0.00")



                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 8))
                    dblRoomTotal = Val(dblRoomTotal) + Format(Val(dr("NETAMOUNT")), "0.00")
                    dblDayTotal = Val(dblDayTotal) + Format(Val(dr("NETAMOUNT")), "0.00")
                    dblGrandTotal = Val(dblGrandTotal) + Format(Val(dr("NETAMOUNT")), "0.00")
                    Filewrite.Write("{0,12}{1,-4}", Mid(Format(Val(dr("PAIDAMOUNT")), "0.00"), 1, 8), "")
                    dblRoomPaid = Val(dblRoomPaid) + Format(Val(dr("PAIDAMOUNT")), "0.00")
                    dblDayPaid = Val(dblDayPaid) + Format(Val(dr("PAIDAMOUNT")), "0.00")
                    dblGrandPaid = Val(dblGrandPaid) + Format(Val(dr("PAIDAMOUNT")), "0.00")
                    Filewrite.Write("{0,-18}", Mid(Trim(CStr(dr("RECEIPTDETAILS"))), 1, 15))
                    If Format(CDate(dr("RECEIPTDATE")), "dd-MM-yyyy") <> "01-01-1900" Then
                        Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("RECEIPTDATE")), "dd/MM/yyyy"), 1, 12))
                    Else
                        Filewrite.Write("{0,-12}", "")
                    End If
                    If Val(dr("BALANCEAMT")) = 0 Then
                        Filewrite.Write("{0,10}{1,-4}", "", "")
                    Else
                        Filewrite.Write("{0,10}{1,-4}", Mid(Format(Val(dr("BALANCEAMT")), "0.00"), 1, 8), "")
                        dblRoomBalance = Val(dblRoomBalance) + Format(Val(dr("BALANCEAMT")), "0.00")
                        dblDayBalance = Val(dblDayBalance) + Format(Val(dr("BALANCEAMT")), "0.00")
                        dblGrandBalance = Val(dblGrandBalance) + Format(Val(dr("BALANCEAMT")), "0.00")
                    End If
                    Filewrite.WriteLine("{0,-10}", Mid(Trim(CStr(dr("SCODE"))), 1, 15))
                    pagesize = pagesize + 1
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                '''********************************************************* Print Room Total ************************************************'''
                Filewrite.WriteLine(StrDup(160, "-"))
                pagesize = pagesize + 1
                'Filewrite.Write("{0,-30}{1,12}{2,12}{3,12}", "Room Total =====>", Format(Val(dblRoomBasic), "0.00"), Format(Val(dblRoomTax), "0.00"), Format(Val(dblRoomPACK), "0.00"), Format(Val(dblRoomSERCHG), "0.00"), Format(Val(dblRoomTotal), "0.00"))
                'Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblRoomPaid), "0.00"), "", "", "", Format(Val(dblRoomBalance), "0.00"))
                Filewrite.Write("{0,-30}{1,12}{2,12}{3,12}{4,12}{5,12}", "Room Total =====>", Format(Val(dblRoomBasic), "0.00"), Format(Val(dblRoomTax), "0.00"), Format(Val(dblRoomPACK), "0.00"), Format(Val(dblRoomSERCHG), "0.00"), Format(Val(dblRoomTotal), "0.00"))
                Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblRoomPaid), "0.00"), "", "", "", Format(Val(dblRoomBalance), "0.00"))

                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(160, "-"))
                pagesize = pagesize + 1
                '''********************************************************* Print Day Total ************************************************'''
                Filewrite.WriteLine(StrDup(160, "."))
                pagesize = pagesize + 1
                'Filewrite.Write("{0,-30}{1,12}{2,12}{3,12}", "Day Total =====>", Format(Val(dblDayBasic), "0.00"), Format(Val(dblDayTax), "0.00"), Format(Val(dblDayTotal), "0.00"))
                'Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblDayPaid), "0.00"), "", "", "", Format(Val(dblDayBalance), "0.00"))

                Filewrite.Write("{0,-30}{1,12}{2,12}{3,12}{4,12}{5,12}", "Day Total =====>", Format(Val(dblDayBasic), "0.00"), Format(Val(dblDayTax), "0.00"), Format(Val(DBLDAYPACK), "0.00"), Format(Val(DBLDAYSERCHG), "0.00"), Format(Val(dblDayTotal), "0.00"))
                Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblDayPaid), "0.00"), "", "", "", Format(Val(dblDayBalance), "0.00"))

                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(160, "."))
                pagesize = pagesize + 1
                '''********************************************************* Print Grand Total ************************************************'''
                Filewrite.WriteLine(StrDup(160, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-30}{1,12}{2,12}{3,12}{4,12}{5,12}", "Grand Total =====>", Format(Val(dblGrandBasic), "0.00"), Format(Val(dblGrandTax), "0.00"), Format(Val(DBLGRANDPACK), "0.00"), Format(Val(DBLGRANDSERCHG), "0.00"), Format(Val(dblGrandTotal), "0.00"))
                Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}", Format(Val(dblGrandPaid), "0.00"), "", "", "", Format(Val(dblGrandBalance), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(160, "="))
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
            Filewrite.WriteLine(StrDup(160, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,12}{2,12}{3,12}{4,12}{5,12}", "BILL DATE", "BASIC", "VAT", "AC-CHG", "KICH_CHG", "NET")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-10}", "PAID", "", "RECEIPT", "RECEIPT", "BALANCE", "", "SERVER")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,12}{2,12}{3,12}{4,12}{5,12}", "ROOM BILL NUMBER", "AMOUNT", "", "", "", "AMOUNT")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-10}", "AMOUNT", "", "NUMBER", "DATE", "AMOUNT", "", "CODE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(160, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINTING REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
