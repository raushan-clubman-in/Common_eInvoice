Imports System.Data.SqlClient
Imports System.IO
Public Class OrdSalesregisterreport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblItemBasic, dblItemTax, dblItemNet As Double
        Dim dblGroupBasic, dblGroupTax, dblGroupNet As Double
        Dim dblGrandBasic, dblGrandTax, dblGrandNet As Double
        Dim dblCredittotal, dblcashtotal, dblcoupontotal, dblroomtotal As Double
        Dim dblclubtotal, dblempolyeetotal, dblpartytotal As Double
        Dim BILLDETAILS, SSQL As String
        Dim I, J, K As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            K = 1
            Filewrite.Write(Chr(15))
            Call ReportHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "ORDSALEREGISTERREPORT")
            If gdataset.Tables("ORDSALEREGISTERREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ORDSALEREGISTERREPORT").Rows
                    If pagesize > 58 Then
                        For I = 0 To 180
                            Filewrite.Write("-")
                        Next
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(PAGEHEAD, FROMDATE, TODATE)
                    End If
                    If BILLDETAILS <> Trim(dr("BILLDETAILS")) Then
                        Filewrite.Write("{0,-5}", Mid(Trim(K) & ".", 1, 5))
                        Filewrite.Write("{0,-15}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                        Filewrite.Write("{0,-20}", Mid(Trim(CStr(dr("BILLDETAILS"))), 1, 20))
                        SQLSTRING = " SELECT ISNULL(MEMBERSTATUS,'') AS MEMBERSTATUS,ISNULL(PAYMENTCODE,'') AS PAYMENTCODE  FROM PAYMENTMODEMASTER "
                        SQLSTRING = SQLSTRING & "WHERE PAYMENTCODE = '" & Trim(dr("PAYMENTMODE")) & "' AND ISNULL(FREEZE,'')<>'Y'"
                        gconnection.getDataSet(SQLSTRING, "PAYMENTMODEMASTER")
                        If gdataset.Tables("PAYMENTMODEMASTER").Rows.Count > 0 Then
                            If Trim(gdataset.Tables("PAYMENTMODEMASTER").Rows(0).Item("MEMBERSTATUS")) = "NO" Then
                                Filewrite.WriteLine("{0,-15}", Mid(Trim(CStr(dr("REMARKS"))), 1, 50))
                            Else
                                Filewrite.WriteLine("{0,-15}", Mid(Mid(Trim(CStr(dr("MCODE"))), 1, 10) & "  " & Mid(Trim(CStr(dr("MNAME"))), 1, 35), 1, 50))
                            End If
                        Else
                            Filewrite.WriteLine("{0,-15}", Mid(Trim(CStr(dr("REMARKS"))), 1, 50))
                        End If
                        BILLDETAILS = Trim(dr("BILLDETAILS"))
                        SSQL = "SELECT ITEMCODE,ITEMDESC,SUM(QTY) AS QTY,RATE,AMOUNT FROM KOT_DET WHERE BILLDETAILS = '" & Trim(CStr(dr("BILLDETAILS"))) & "'"
                        SSQL = SSQL & " GROUP BY ITEMCODE,ITEMDESC,RATE,AMOUNT"
                        gconnection.getDataSet(SSQL, "KOTDETAILS")
                        If gdataset.Tables("KOTDETAILS").Rows.Count > 0 Then
                            For I = 0 To gdataset.Tables("KOTDETAILS").Rows.Count - 1 Step 1
                                With gdataset.Tables("KOTDETAILS").Rows(I)
                                    Filewrite.Write("{0,-5}{1,-15}{2,-20}{3,-15}", "", "", "", "")
                                    Filewrite.Write("{0,-10}", Mid(Trim(CStr(.Item("ITEMCODE"))), 1, 10))
                                    Filewrite.Write("{0,-22}", Mid(Trim(CStr(.Item("ITEMDESC"))), 1, 22))
                                    Filewrite.Write("{0,10}", Mid(Format(Val(.Item("QTY")), "0.00"), 1, 10))
                                    If Trim(CStr(dr("PAYMENTMODE"))) = "CREDIT" Then
                                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                                        pagesize = pagesize + 1
                                    ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "CASH" Then
                                        Filewrite.WriteLine("{0,10}{1,10}", "", Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                                        pagesize = pagesize + 1
                                    ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "COUPON" Then
                                        Filewrite.WriteLine("{0,10}{1,10}{2,10}", "", "", Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                                        pagesize = pagesize + 1
                                    ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "ROOM" Then
                                        Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}", "", "", "", Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                                        pagesize = pagesize + 1
                                    ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "CLUB" Then
                                        Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}", "", "", "", "", Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                                        pagesize = pagesize + 1
                                    ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "EMOLOYEE" Then
                                        Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}", "", "", "", "", "", Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                                        pagesize = pagesize + 1
                                    ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "PARTY" Then
                                        Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}", "", "", "", "", "", "", Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                                        pagesize = pagesize + 1
                                    Else
                                        Filewrite.WriteLine()
                                        pagesize = pagesize + 1
                                    End If
                                End With
                            Next I
                            Filewrite.Write("{0,-5}{1,-15}{2,-20}{3,-15}", "", "", "", "")
                            Filewrite.Write("{0,-10}{1,22}{2,-10}", "", "TOTAL :", "")
                            If Trim(CStr(dr("PAYMENTMODE"))) = "CREDIT" Then
                                Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "CASH" Then
                                Filewrite.WriteLine("{0,10}{1,10}", "", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "COUPON" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}", "", "", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "ROOM" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}", "", "", "", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "CLUB" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}", "", "", "", "", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "EMOLOYEE" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}", "", "", "", "", "", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "PARTY" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}", "", "", "", "", "", "", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            Else
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            'dblGrandBasic = dblGrandBasic + Format(Val(dr("BASIC")), "0.00")
                            Filewrite.Write("{0,-5}{1,-15}{2,-20}{3,-15}", "", "", "", "")
                            Filewrite.Write("{0,-10}{1,22}{2,-10}", "", "TAX :", "")
                            If Trim(CStr(dr("PAYMENTMODE"))) = "CREDIT" Then
                                Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "CASH" Then
                                Filewrite.WriteLine("{0,10}{1,10}", "", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "COUPON" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}", "", "", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "ROOM" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}", "", "", "", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "CLUB" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}", "", "", "", "", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "EMPLOYEE" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}", "", "", "", "", "", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "PARTY" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}", "", "", "", "", "", "", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                                pagesize = pagesize + 1
                            Else
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            'dblGrandTax = dblGrandTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                            Filewrite.Write("{0,-5}{1,-15}{2,-20}{3,-15}", "", "", "", "")
                            Filewrite.Write("{0,-10}{1,22}{2,-10}", "", "BILL AMOUNT :", "")
                            If Trim(CStr(dr("PAYMENTMODE"))) = "CREDIT" Then
                                Filewrite.Write("{0,10}", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,12}", "", "", "", "", "", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                dblCredittotal = dblCredittotal + Format(Val(dr("NETAMOUNT")), "0.00")
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "CASH" Then
                                Filewrite.Write("{0,10}{1,10}", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,12}", "", "", "", "", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                dblcashtotal = dblcashtotal + Format(Val(dr("NETAMOUNT")), "0.00")
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "COUPON" Then
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}", "", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,12}", "", "", "", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                dblcoupontotal = dblcoupontotal + Format(Val(dr("NETAMOUNT")), "0.00")
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "ROOM" Then
                                Filewrite.Write("{0,10}{1,10}{2,10}{3,10}", "", "", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,12}", "", "", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                dblroomtotal = dblroomtotal + Format(Val(dr("NETAMOUNT")), "0.00")
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "CLUB" Then
                                Filewrite.Write("{0,10}{1,10}{2,10}{3,10}{4,10}", "", "", "", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                Filewrite.WriteLine("{0,10}{1,10}{2,12}", "", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                dblclubtotal = dblclubtotal + Format(Val(dr("NETAMOUNT")), "0.00")
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "EMPLOYEE" Then
                                Filewrite.Write("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}", "", "", "", "", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                Filewrite.WriteLine("{0,10}{1,12}", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                dblempolyeetotal = dblempolyeetotal + Format(Val(dr("NETAMOUNT")), "0.00")
                                pagesize = pagesize + 1
                            ElseIf Trim(CStr(dr("PAYMENTMODE"))) = "PARTY" Then
                                Filewrite.Write("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}", "", "", "", "", "", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                Filewrite.WriteLine("{0,12}", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 10))
                                dblpartytotal = dblpartytotal + Format(Val(dr("NETAMOUNT")), "0.00")
                                pagesize = pagesize + 1
                            Else
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            dblGrandNet = dblGrandNet + Format(Val(dr("NETAMOUNT")), "0.00")
                            If pagesize > 58 Then
                                For I = 0 To 180
                                    Filewrite.Write("-")
                                Next
                                Filewrite.Write(Chr(12))
                                pageno = pageno + 1
                                Call ReportHeader(PAGEHEAD, FROMDATE, TODATE)
                            End If
                        End If
                        K = K + 1
                    End If
                Next dr
                Filewrite.WriteLine(StrDup(180, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-11}{1,-80}{2,17}{3,10}", " ", "GRAND TOTAL ===>", Mid(Format(Val(dblCredittotal), "0.00"), 1, 10), Mid(Format(Val(dblcashtotal), "0.00"), 1, 10))
                Filewrite.Write("{0,10}{1,10}", Mid(Format(Val(dblcoupontotal), "0.00"), 1, 10), Mid(Format(Val(dblroomtotal), "0.00"), 1, 10))
                Filewrite.Write("{0,10}{1,10}", Mid(Format(Val(dblclubtotal), "0.00"), 1, 10), Mid(Format(Val(dblempolyeetotal), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,10}{1,12}", Mid(Format(Val(dblpartytotal), "0.00"), 1, 10), Mid(Format(Val(dblGrandNet), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(180, "="))
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
            Filewrite.WriteLine("{0,-30}{1,128}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-40}{2,-30}{3,-54}{4,-30}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-40}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,80}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,170}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,128}{2,20}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(180, "="))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-5}{1,-15}{2,-20}{3,-15}{4,-10}", "SL", "BILL", "BILL", "MEMBER", "ITEM CODE")
            Filewrite.WriteLine("{0,-22}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}{7,10}{8,10}{9,12}", "ITEM DESCRIPTION", "QTY", "CREDIT", "CASH", "COUPON", "ROOM", "CLUB", "EMPLOYEE", "PARTY", "TOTAL")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-5}{1,-15}{2,-20}{3,-15}{4,-10}", "NO", "DATE", "NUMBER", "NAME", "")
            Filewrite.WriteLine("{0,-22}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}{7,10}{8,10}{9,12}", "", "", "", "", "", "", "", "", "", "")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(180, "="))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
