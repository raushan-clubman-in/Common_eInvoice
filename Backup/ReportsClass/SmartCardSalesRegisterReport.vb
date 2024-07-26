Imports System.Data.SqlClient
Imports System.io
Public Class SmartCardSalesRegisterReport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal CONN As String, ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal COLUMNHEAD() As String, ByVal SIZE() As Integer, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblBasic, dblTax, dblNet, dblPaid As Double
        Dim ddblBasic, ddblTax, ddblNet, ddblPaid As Double
        Dim POSGrand, POSCount, POSTOTAL As Double
        Dim POSBool As Boolean

        '06/05/2008
        Dim POSDESC As String
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
            Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "CASHSALEREGISTER")
            If gdataset.Tables("CASHSALEREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("CASHSALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If POSDESC <> Trim(CStr(dr("POSDESC"))) Then
                        If POSBool = True Then
                            Filewrite.WriteLine(StrDup(135, "="))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,15}", "Total Document :", Format(Val(POSCount), "0"), "POS Total =====>", Format(Val(POSTOTAL), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "="))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("POSDESC"))), 1, 35) & "-" & Mid(Trim(CStr(dr("POSCODE"))), 1, 10))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            POSDESC = Trim(CStr(dr("POSDESC")))
                            pagesize = pagesize + 1
                            POSCount = 0
                            POSTOTAL = 0
                        Else
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("POSDESC"))), 1, 15) & "-" & Mid(Trim(CStr(dr("POSCODE"))), 1, 5))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            POSDESC = Trim(CStr(dr("POSDESC")))
                            pagesize = pagesize + 1
                            POSBool = True
                            POSCount = 0
                            POSTOTAL = 0
                        End If
                    End If
                    Filewrite.Write("{0,-14}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                    Filewrite.Write("{0,-20}", Mid(Trim(CStr(dr("BILLNO"))), 1, 20))
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("BILLAMOUNT")), "0.00"), 1, 8))
                    dblBasic = dblBasic + Format(Val(dr("BILLAMOUNT")), "0.00")
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 8))
                    dblTax = dblTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("TOTALAMOUNT")), "0.00"), 1, 8))
                    dblNet = dblNet + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    Filewrite.Write("{0,12}{1,-4}", Mid(Format(Val(dr("PAIDAMOUNT")), "0.00"), 1, 8), "")
                    dblPaid = dblPaid + Format(Val(dr("PAIDAMOUNT")), "0.00")
                    Filewrite.Write("{0,-18}", Mid(Trim(CStr(dr("RECEIPTDETAILS"))), 1, 15))
                    If Format(CDate(dr("RECEIPTDATE")), "dd-MM-yyyy") = "1900-01-01" Then
                        Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("RECEIPTDATE")), "dd/MM/yyyy"), 1, 12))
                    Else
                        Filewrite.Write("{0,-12}", "")
                    End If
                    If Val(dr("BALANCEAMT")) = 0 Then
                        Filewrite.Write("{0,10}", "")
                    Else
                        Filewrite.Write("{0,10}", Mid(Format(Val(dr("BALANCEAMT")), "0.00"), 1, 8))
                    End If
                    Filewrite.WriteLine("{0,-4}{1,-12}", "", Mid(Trim(CStr(dr("SCODE"))), 1, 15))
                    POSDESC = Trim(dr("POSDESC"))
                    POSTOTAL = POSTOTAL + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    pagesize = pagesize + 1
                    POSCount = POSCount + 1
                    POSGrand = POSGrand + 1
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                'Filewrite.WriteLine("{0,-34}{1,12}{2,12}{3,12}{4,12}", "Grand Total =====>", Format(Val(dblBasic), "0.00"), Format(Val(dblTax), "0.00"), Format(Val(dblNet), "0.00"), Format(Val(dblPaid), "0.00"))
                Filewrite.WriteLine("{0,-34}{1,12}{2,12}{3,12}", "Grand Total =====>", Format(Val(dblBasic), "0.00"), Format(Val(dblTax), "0.00"), Format(Val(dblNet), "0.00"))
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
    Private Function PrintHeader(ByVal Heading() As String, ByVal colsize() As Integer, ByVal mskfromdate As Date, ByVal msktodate As Date)
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
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-14}{1,-20}{2,12}{3,12}{4,12}", "BILL", "BILL", "BASIC", PrintTaxheading1, "NET")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-12}", "PAID", "", "RECEIPT", "RECEIPT", "BALANCE", "", "SERVER")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-14}{1,-20}{2,12}{3,12}{4,12}", "DATE", "NUMBER", "AMOUNT", PrintTaxheading2, "AMOUNT")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-12}", "AMOUNT", "", "NUMBER", "DATE", "AMOUNT", "", "CODE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
