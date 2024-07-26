Imports System.Data.SqlClient
Imports System.IO
Public Class SalesRegisterDateWiseReport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
  
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal SQLSTRING2 As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim Posdesc, Billdate, Billdetails, Billamount, printString As String
        Dim Dblbasicamount, Dbltaxamount, DblNetamount, dblBalanceamount, totalDoc As Double
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
            gconnection.getDataSet(SQLSTRING, "DATEWISESALEREGISTER1")
            If gdataset.Tables("DATEWISESALEREGISTER1").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("DATEWISESALEREGISTER1").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                    End If
                    If Posdesc <> Trim(dr("POSDESC")) Then
                        Filewrite.WriteLine("{0,-30}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 25) & ":")
                        pagesize = pagesize + 1
                        Filewrite.WriteLine("{0,-30}", "-------------------------")
                        pagesize = pagesize + 1
                        Posdesc = Trim(dr("POSDESC"))
                    End If
                    If Billdate <> dr("BILLDATE") Then
                        Filewrite.Write("{0,-14}", Mid(Format(dr("BILLDATE"), "dd/MM/yyyy"), 1, 10))
                        Billdate = dr("BILLDATE")
                    Else
                        Filewrite.Write("{0,-14}", " ")
                    End If
                    If Billdetails <> dr("BILLDETAILS") Then

                        Filewrite.Write("{0,-20}", Mid(CStr(dr("BILLDETAILS")), 1, 20))
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 8))
                        Dblbasicamount = Val(Dblbasicamount) + Format(Val(dr("AMOUNT")), "0.00")
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 8))
                        Dbltaxamount = Val(Dbltaxamount) + Format(Val(dr("TAXAMOUNT")), "0.00")
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("TOTAMT")), "0.00"), 1, 8))
                        DblNetamount = Val(DblNetamount) + Format(Val(dr("TOTAMT")), "0.00")
                        Filewrite.Write("{0,-4}{1,-20}", " ", Mid(CStr(dr("RECEIPTNUMBER")), 1, 20))
                        Filewrite.Write("{0,12}{1,-4}", Mid(Format(Val(dr("BALANCEAMT")), "0.00"), 1, 8), "")
                        dblBalanceamount = Val(dblBalanceamount) + Format(Val(dr("BALANCEAMT")), "0.00")
                        Filewrite.Write("{0,-15}", Mid(CStr(dr("PAYMENTMODE")), 1, 20))
                        Filewrite.Write("{0,-13}", Mid(CStr(dr("SERVERCODE")), 1, 20))
                        Billdetails = Trim(dr("BILLDETAILS"))
                        Billamount = dr("AMOUNT")
                    Else
                        Filewrite.Write("{0,-20}{1,12}{2,12}{3,12}{4,-4}{5,-20}{6,12}{7,-4}{8,-15}{9,-13}", " ", " ", " ", " ", " ", " ", " ", " ", "", "")
                    End If
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1
                    totalDoc = totalDoc + 1
                Next dr
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-14}{1,-20}", " ", "GRAND TOTAL ===>")
                Filewrite.Write("{0,12}", Format(Val(Dblbasicamount), "0.00"))
                Filewrite.Write("{0,12}", Format(Val(Dbltaxamount), "0.00"))
                Filewrite.Write("{0,12}", Format(Val(DblNetamount), "0.00"))
                Filewrite.Write("{0,-4}{1,-20}{2,12}", "", "", Format(Val(dblBalanceamount), "0.00"))
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,20}{1,-20}", "TOTAL DOCUMENT(S):==>     ", Format(Val(totalDoc), "0"))
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                ''Total payment mode wise========================
                Filewrite.WriteLine("SUMMARY")
                Filewrite.WriteLine(StrDup(7, "="))
                gconnection.getDataSet(SQLSTRING2, "GROUPTOTAL")
                If gdataset.Tables("GROUPTOTAL").Rows.Count > 0 Then
                    For I = 0 To gdataset.Tables("grouptotal").Rows.Count - 1
                        Filewrite.WriteLine("{0,-16}{1,26}", gdataset.Tables("grouptotal").Rows(I).Item("paymentmode"), Format(Math.Round(Val(gdataset.Tables("grouptotal").Rows(I).Item("amount"))), "0.00"))
                        pagesize = pagesize + 1
                    Next
                End If
                Filewrite.WriteLine(StrDup(42, "="))
                ''===============================================

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
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "="))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-14}{1,-20}{2,12}{3,12}{4,12}{5,-4}", "BILL", "BILL", "BASIC", PrintTaxheading1, "NET", "")
            Filewrite.WriteLine("{0,-20}{1,12}{2,-4}{3,-15}{4,-13}", "RECEIPT", "BALANCE", "", "PAYMENT", "SERVER")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-14}{1,-20}{2,12}{3,12}{4,12}{5,-4}", "DATE", "NUMBER", "AMOUNT", PrintTaxheading2, "AMOUNT", "")
            Filewrite.WriteLine("{0,-20}{1,12}{2,-4}{3,-15}{4,-13}", "NUMBER", "AMOUNT", "", "MODE", "CODE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "="))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
