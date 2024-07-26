Imports System.Data.SqlClient
Imports System.IO
Public Class CouponSalesRegisterReport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblBasic, dblTax, dblService, dblNet, dblGrandBasic, dblGrandTax, dblGrandService, dblGrandNet As Double
        Dim POSdesc As String
        Dim POSbool As Boolean
        Dim J, I As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "COUPONSALESREGISTERREPORT")
            If gdataset.Tables("COUPONSALESREGISTERREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("COUPONSALESREGISTERREPORT").Rows
                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If POSdesc <> Trim(CStr(dr("POSDESC"))) Then
                        If POSbool = True Then
                            Filewrite.WriteLine()
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-35}{1,15}", "Group Total :", Mid(Format(Val(dblBasic), "0.00"), 1, 10))
                            Filewrite.Write("{0,15}{1,15}", Mid(Format(Val(dblTax), "0.00"), 1, 10), "")
                            Filewrite.WriteLine("{0,15}{1,-15}", Mid(Format(Val(dblNet), "0.00"), 1, 10), "")
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-15}", Mid(Trim(CStr(dr("POSDESC"))), 1, 15))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            POSbool = True
                            dblBasic = 0 : dblTax = 0 : dblService = 0 : dblNet = 0
                        Else
                            Filewrite.WriteLine("{0,-15}", Mid(Trim(CStr(dr("POSDESC"))), 1, 15))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            POSbool = True
                            dblBasic = 0 : dblTax = 0 : dblService = 0 : dblNet = 0
                        End If
                    End If
                    Filewrite.Write("{0,-15}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 15))
                    Filewrite.Write("{0,-20}", Mid(Trim(CStr(dr("BILLNO"))), 1, 20))
                    Filewrite.Write("{0,15}", Mid(Format(Val(dr("TOTALAMOUNT")), "0.00"), 1, 15))
                    dblBasic = dblBasic + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    dblGrandBasic = dblGrandBasic + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    Filewrite.Write("{0,15}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 15))
                    dblTax = dblTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                    dblGrandTax = dblGrandTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                    Filewrite.Write("{0,15}", "")
                    Filewrite.Write("{0,15}{1,-5}", Mid(Format(Val(dr("BILLAMOUNT")), "0.00"), 1, 15), "")
                    dblNet = dblNet + Format(Val(dr("BILLAMOUNT")), "0.00")
                    dblGrandNet = dblGrandNet + Format(Val(dr("BILLAMOUNT")), "0.00")
                    Filewrite.Write("{0,-15}", Mid(Trim(CStr(dr("SCODE"))), 1, 15))
                    'Begin
                    'Filewrite.Write("{0,-15}", Mid(Trim(CStr(dr("SNAME"))), 1, 15))
                    Filewrite.WriteLine("{0,-15}", Mid(Trim(CStr(dr("SNAME"))), 1, 15))
                    'End
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "-"))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-35}{1,15}", "Group Total :", Mid(Format(Val(dblBasic), "0.00"), 1, 10))
                Filewrite.Write("{0,15}{1,15}", Mid(Format(Val(dblTax), "0.00"), 1, 10), "")
                Filewrite.WriteLine("{0,15}{1,15}", Mid(Format(Val(dblNet), "0.00"), 1, 10), "")
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-35}{1,15}", "Grand Total :", Mid(Format(Val(dblGrandBasic), "0.00"), 1, 10))
                Filewrite.Write("{0,15}{1,15}", Mid(Format(Val(dblGrandTax), "0.00"), 1, 10), "")
                Filewrite.WriteLine("{0,15}{1,15}", Mid(Format(Val(dblGrandNet), "0.00"), 1, 10), "")
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
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-15}{1,-20}{2,15}{3,15}{4,15}", "BILL", "BILL", "BASIC", PrintTaxheading1, "SERVICE")
            Filewrite.WriteLine("{0,15}{1,-5}{2,-15}{3,-15}", "NET", "", "SERVER", "SERVER")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-15}{1,-20}{2,15}{3,15}{4,15}", "DATE", "NUMBER", "AMOUNT", PrintTaxheading2, "CHARGE")
            Filewrite.WriteLine("{0,15}{1,-5}{2,-15} {3,-15}", "AMOUNT", "", "CODE", "NAME")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
