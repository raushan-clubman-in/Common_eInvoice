Imports System.Data.SqlClient
Imports System.IO
Public Class rptPaymentmodewise
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow

    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal columnheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, POSGrand As Double
        Dim POStotal, POSGrandtotal, Qtytotal, Ratetotal, amounttotal, PaymentTotal As Double
        Dim Membername, Posdesc, Paymentmode, Billdetails, SSQL As String
        Dim Memberbool, POSbool, Paymentbool As Boolean
        Dim I, J As Integer
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(columnheading, mskfromdate, msktodate)
            gconnection.getDataSet(SQLSTRING, "SETTLEMENTREGISTER")
            If gdataset.Tables("SETTLEMENTREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("SETTLEMENTREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(78, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(columnheading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If Paymentmode <> Trim(CStr(dr("PAYMENTMODE"))) Then
                        If Paymentbool = True Then
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Group Total :", "", "", Format(Val(PaymentTotal), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("PAYMENTMODE"))), 1, 15))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Paymentmode = Trim(CStr(dr("PAYMENTMODE")))
                            pagesize = pagesize + 1
                            Posdesc = ""
                            Membername = ""
                            PaymentTotal = 0
                        Else
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("PAYMENTMODE"))), 1, 15))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Paymentmode = Trim(CStr(dr("PAYMENTMODE")))
                            pagesize = pagesize + 1
                            Paymentbool = True
                        End If
                    End If
                    If Membername <> Trim(CStr(dr("MNAME"))) Then
                        If Memberbool = True Then
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(POSCount), "0"), "Member Total =====>", Format(Val(POStotal), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("MNAME"))), 1, 35) & "-" & Mid(Trim(CStr(dr("MCODE"))), 1, 10))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Membername = Trim(CStr(dr("MNAME")))
                            pagesize = pagesize + 1
                            POSCount = 0
                            POStotal = 0
                            Posdesc = ""
                        Else
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("MNAME"))), 1, 15) & "-" & Mid(Trim(CStr(dr("MCODE"))), 1, 5))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Membername = Trim(CStr(dr("MNAME")))
                            pagesize = pagesize + 1
                            Memberbool = True
                            POSCount = 0
                            POStotal = 0
                        End If
                    End If
                    If Posdesc <> Trim(CStr(dr("POSDESC"))) Then
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                        Filewrite.Write("{0,-5}", "")
                        Filewrite.Write("{0,-15}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("POSDESC"))), 1, 15))
                        Filewrite.WriteLine(Chr(18))
                        pagesize = pagesize + 1
                        Posdesc = Trim(CStr(dr("POSDESC")))
                        POSCount = POSCount + 1
                        POSGrand = POSGrand + 1
                    End If
                    If Billdetails <> Trim(CStr(dr("BILLNO"))) Then
                        Filewrite.Write("{0,-20}{1,-12}", "", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                        Filewrite.Write("{0,-20}", Mid(Trim(CStr(dr("BILLNO"))), 1, 20))
                        Filewrite.Write("{0,-15}", Mid(Trim(CStr(dr("SCODE"))), 1, 18))
                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("BILLAMT")), "0.00"), 1, 8))
                        pagesize = pagesize + 1
                        POStotal = POStotal + Format(Val(dr("BILLAMT")), "0.00")
                        POSGrandtotal = POSGrandtotal + Format(Val(dr("BILLAMT")), "0.00")
                        PaymentTotal = PaymentTotal + Format(Val(dr("BILLAMT")), "0.00")
                        SSQL = "SELECT ITEMCODE,ITEMDESC,QTY,RATE,AMT FROM VIEWPAYMENTMODEWISEREPORT WHERE BILLNO = '" & Trim(CStr(dr("BILLNO"))) & "'"
                        gconnection.getDataSet(SSQL, "VIEWPAYMENTMODEWISEREPORT")
                        If gdataset.Tables("VIEWPAYMENTMODEWISEREPORT").Rows.Count > 0 Then
                            Filewrite.Write("{0,-20}", "")
                            Filewrite.WriteLine(StrDup(58, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-10}{2,-24}{3,-6}{4,7}{5,10}", "", "ITEMCODE", "ITEMDESC", "QTY", "RATE", "AMOUNT")
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-20}", "")
                            Filewrite.WriteLine(StrDup(58, "-"))
                            pagesize = pagesize + 1
                            For J = 0 To gdataset.Tables("VIEWPAYMENTMODEWISEREPORT").Rows.Count - 1
                                Filewrite.Write("{0,-20}{1,-10}{2,-24}", "", Mid(Trim(CStr(gdataset.Tables("VIEWPAYMENTMODEWISEREPORT").Rows(J).Item("ITEMCODE"))), 1, 10), Mid(Trim(CStr(gdataset.Tables("VIEWPAYMENTMODEWISEREPORT").Rows(J).Item("ITEMDESC"))), 1, 24))
                                Filewrite.WriteLine("{0,-6}{1,7}{2,10}", Format(Val(gdataset.Tables("VIEWPAYMENTMODEWISEREPORT").Rows(J).Item("QTY")), "0.00"), Format(Val(gdataset.Tables("VIEWPAYMENTMODEWISEREPORT").Rows(J).Item("RATE")), "0.00"), Format(Val(gdataset.Tables("VIEWPAYMENTMODEWISEREPORT").Rows(J).Item("AMT")), "0.00"))
                                pagesize = pagesize + 1
                                Qtytotal = Qtytotal + Val(gdataset.Tables("VIEWPAYMENTMODEWISEREPORT").Rows(J).Item("QTY"))
                                Ratetotal = Ratetotal + Val(gdataset.Tables("VIEWPAYMENTMODEWISEREPORT").Rows(J).Item("RATE"))
                                amounttotal = amounttotal + Val(gdataset.Tables("VIEWPAYMENTMODEWISEREPORT").Rows(J).Item("AMT"))
                            Next
                            Filewrite.Write("{0,-20}", "")
                            Filewrite.WriteLine(StrDup(58, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-34}{2,-6}{3,7}{4,10}", "", "ITEM TOTAL ======>", Format(Val(Qtytotal), "0.00"), Format(Val(Ratetotal), "0.00"), Format(Val(amounttotal), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-20}", "")
                            Filewrite.WriteLine(StrDup(58, "-"))
                            pagesize = pagesize + 1
                            Qtytotal = 0 : Ratetotal = 0 : amounttotal = 0
                        End If
                        Billdetails = Trim(CStr(dr("BILLNO")))
                    End If
                Next dr
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Group Total :", "", "", Format(Val(PaymentTotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(POSCount), "0"), "Member Total =====>", Format(Val(POStotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(POSGrand), "0"), "Grand Total =====>", Format(Val(POSGrandtotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "="))
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
    Private Function PrintHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
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
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "DETILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-12}{2,-20}{3,-15}{4,10}", "MEMBER/", "BILL", "BILL", "SERVER", "NET")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-12}{2,-20}{3,-15}{4,10}", "LOCATION", "DATE", "NUMBER", "CODE", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
