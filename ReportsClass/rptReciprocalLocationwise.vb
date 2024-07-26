Imports System.Data.SqlClient
Imports System.IO
Public Class rptReciprocalLocationwise
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblBasic, dblTax, dblNet, dblPaid As Double
        Dim dblGrandBasic, dblGrandTax, dblGrandNet, dblGrandPaid As Double
        Dim varPOSDESC As String
        Dim POSDESCbool As Boolean
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
            Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "RECIPROCALSALEREGISTERLOC")
            If gdataset.Tables("RECIPROCALSALEREGISTERLOC").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("RECIPROCALSALEREGISTERLOC").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If Trim(CStr(varPOSDESC)) <> Trim(CStr(dr("POSDESC"))) Then
                        If POSDESCbool = True Then
                            Filewrite.WriteLine(StrDup(135, "."))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-30}{1,12}{2,12}{3,12}{4,12}", "Day Total =====>", Format(Val(dblBasic), "0.00"), Format(Val(dblTax), "0.00"), Format(Val(dblNet), "0.00"), Format(Val(dblPaid), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "."))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-35}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 35) & ":")
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-30}", "------------------------------")
                            pagesize = pagesize + 1
                            varPOSDESC = CStr(dr("POSDESC"))
                            dblBasic = 0 : dblTax = 0 : dblNet = 0 : dblPaid = 0
                        Else
                            Filewrite.WriteLine("{0,-20}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 20) & ":")
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}", "-------------------------")
                            pagesize = pagesize + 1
                            varPOSDESC = CStr(dr("POSDESC"))
                            POSDESCbool = True
                            dblBasic = 0 : dblTax = 0 : dblNet = 0 : dblPaid = 0
                        End If
                    End If
                    Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                    Filewrite.Write("{0,-18}", Mid(Trim(CStr(dr("BILLDETAILS"))), 1, 18))
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 8))
                    dblBasic = dblBasic + Format(Val(dr("BASIC")), "0.00")
                    dblGrandBasic = dblGrandBasic + Format(Val(dr("BASIC")), "0.00")
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 8))
                    dblTax = dblTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                    dblGrandTax = dblGrandTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                    Filewrite.Write("{0,12}", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 8))
                    dblNet = dblNet + Format(Val(dr("NETAMOUNT")), "0.00")
                    dblGrandNet = dblGrandNet + Format(Val(dr("NETAMOUNT")), "0.00")
                    Filewrite.Write("{0,12}{1,-4}", Mid(Format(Val(dr("PAID")), "0.00"), 1, 8), "")
                    dblPaid = dblPaid + Format(Val(dr("PAID")), "0.00")
                    dblGrandPaid = dblGrandPaid + Format(Val(dr("PAID")), "0.00")
                    Filewrite.Write("{0,-18}", Mid(Trim(CStr(dr("RECEIPTNUMBER"))), 1, 15))
                    If Format(CDate(dr("RECEIPTDATE")), "dd-MM-yyyy") = "1900-01-01" Then
                        Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("RECEIPTDATE")), "dd/MM/yyyy"), 1, 12))
                    Else
                        Filewrite.Write("{0,-12}", "")
                    End If
                    If Val(dr("BALANCEAMOUNT")) = 0 Then
                        Filewrite.Write("{0,10}{1,-4}", "", "")
                    Else
                        Filewrite.Write("{0,10}{1,-4}", Mid(Format(Val(dr("BALANCEAMOUNT")), "0.00"), 1, 8), "")
                    End If
                    Filewrite.WriteLine("{0,-10}", Mid(Trim(CStr(dr("SERVERCODE"))), 1, 15))
                    pagesize = pagesize + 1
                Next dr
                Filewrite.WriteLine(StrDup(135, "."))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-30}{1,12}{2,12}{3,12}{4,12}", "Day Total =====>", Format(Val(dblBasic), "0.00"), Format(Val(dblTax), "0.00"), Format(Val(dblNet), "0.00"), Format(Val(dblPaid), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "."))
                pagesize = pagesize + 1
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-30}{1,12}{2,12}{3,12}{4,12}", "Grand Total =====>", Format(Val(dblGrandBasic), "0.00"), Format(Val(dblGrandTax), "0.00"), Format(Val(dblGrandNet), "0.00"), Format(Val(dblGrandPaid), "0.00"))
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
    Private Function PrintHeader(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
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
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(15))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-12}{1,-18}{2,12}{3,12}{4,12}", "BILL", "BILL", "BASIC", PrintTaxheading1, "NET")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-10}", "PAID", "", "RECEIPT", "RECEIPT", "BALANCE", "", "SERVER")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-12}{1,-18}{2,12}{3,12}{4,12}", "DATE", "NUMBER", "AMOUNT", PrintTaxheading2, "AMOUNT")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-10}", "AMOUNT", "", "NUMBER", "DATE", "AMOUNT", "", "CODE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
