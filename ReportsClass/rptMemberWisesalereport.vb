Imports System.Data.SqlClient
Imports System.IO
Public Class rptMemberWisesalereport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblBasicAmt, dblTaxAmt, dblPackAmt, dblNetAmt As Double
        Dim dblGrandBasic, dblGrandTax, dblGrandPackAmt, dblGrandNet As Double
        Dim MCode, Billdetails As String
        Dim Mcodebool As Boolean
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
            gconnection.getDataSet(SQLSTRING, "MEMBERWISESALEREGISTER")
            If gdataset.Tables("MEMBERWISESALEREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("MEMBERWISESALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If Billdetails <> Trim(CStr(dr("BILLNO"))) Then
                        Filewrite.Write("{0,-12}{1,-20}", Mid(Format(CDate(dr("BILLDATE")), "dd-MMM-yyyy"), 1, 12), Mid(Trim(CStr(dr("BILLNO"))), 1, 18))
                        Filewrite.Write("{0,-10}{1,-25}", Mid(Trim(CStr(dr("MCODE"))), 1, 10), Mid(Trim(CStr(dr("MNAME"))), 1, 25))
                        Filewrite.Write("{0,-5}{1,10}", Mid(Trim(CStr(dr("SCODE"))), 1, 10), Mid(Format(Val(dr("BILLAMOUNT")), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}{1,10}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10), Mid(Format(Val(dr("PACKAMOUNT")), "0.00"), 1, 10))
                        Filewrite.WriteLine("{0,10}{1,-5}{2,-15}", Mid(Format(Val(dr("TOTALAMOUNT")), "0.00"), 1, 10), "", Mid(Trim(CStr(dr("REMARKS"))), 1, 15))
                        pagesize = pagesize + 1
                        pagesize = pagesize + 1
                        dblGrandBasic = Val(dblGrandBasic) + Format(Val(dr("BILLAMOUNT")), "0.00")
                        dblGrandTax = Val(dblGrandTax) + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblGrandPackAmt = Val(dblGrandPackAmt) + Format(Val(dr("PACKAMOUNT")), "0.00")
                        dblGrandNet = Val(dblGrandNet) + Format(Val(dr("TOTALAMOUNT")), "0.00")
                        Billdetails = dr("BILLNO")
                        I = I + 1
                    End If
                Next
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                '''******************************************** $  GRAND TOTAL $   ****************************************''''
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-12}{1,-20}{2,-10}{3,-25}{4,-5}", "", "GRAND TOTAL =====>", "", "", "")
                Filewrite.Write("{0,10}", Mid(Format(Val(dblGrandBasic), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(dblGrandTax), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(dblGrandPackAmt), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,10}", Mid(Format(Val(dblGrandNet), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                '''************************************** $  COMPLETE GRAND TOTAL $   **************************************''''
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
            Filewrite.WriteLine(StrDup(135, "="))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-12}{1,-20}{2,-10}{3,-25}{4,-5}", "BILL", "BILL", "MEMBER", "MEMBER", "SCODE")
            Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,-5}{5,-15}", "BASIC", "SURCHARGE", "PACKING", "BILL", "", "KOT NO")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-12}{1,-20}{2,-10}{3,-25}{4,-5}", "DATE", "NUMBER", "CODE", "NAME", "")
            Filewrite.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,-5}{5,-15}", "AMOUNT", "AMOUNT", "AMOUNT", "AMOUNT", "", "")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "="))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
