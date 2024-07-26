Imports System.Data.SqlClient
Imports System.IO
Public Class rptPendingbillsummary
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Detailsection(ByVal Sqlstring As String, ByVal pageheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim i As Integer
        Dim boolKOTdetails, boolServer, boolgrouptotal As Boolean
        Dim ServerName, Billdetails, MemberCode, Rowprint, Todaydate As String
        Dim KOTAmount, GroupAmount, GrandAmount, BearerTotal, TotalAmount As Double
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(pageheading, mskfromdate, msktodate)
            gconnection.getDataSet(Sqlstring, "PENDINGKOTREGISTERSUMMARY")
            If gdataset.Tables("PENDINGKOTREGISTERSUMMARY").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("PENDINGKOTREGISTERSUMMARY").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        pagesize = pagesize + 1
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(pageheading, mskfromdate, msktodate)
                    End If
                    If Billdetails <> Trim(CStr(dr("KOTDETAILS"))) Then
                        Filewrite.Write("{0,-18}", Mid(Trim(Format(dr("KOTDATE"), "dd/MM/yyyy")), 1, 15))
                        Filewrite.Write("{0,-20}", Mid(Trim(dr("KOTDETAILS")), 1, 20))
                        Filewrite.Write("{0,-12}", Mid(Trim(dr("MCODE")), 1, 10))
                        Filewrite.Write("{0,-30}", Mid(Trim(dr("MNAME")), 1, 30))
                        Filewrite.Write("{0,-12}", Mid(Trim(dr("SERVERCODE")), 1, 10))
                        Filewrite.Write("{0,-20}", Mid(Trim(dr("PAYMENTTYPE")), 1, 30))
                        Filewrite.WriteLine("{0,12}", Mid(Format(Math.Round(Val(dr("TOTALAMOUNT"))), "0.00"), 1, 12))
                        pagesize = pagesize + 1
                        GrandAmount = Val(GrandAmount) + Format(Val(dr("TOTALAMOUNT")), "0.00")
                        Billdetails = dr("KOTDETAILS")
                        TotalAmount = 0
                    End If
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                ''''******************************************** $  GRAND TOTAL $   ****************************************''''
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                TotalAmount = Format(Val(GrandAmount), "0.00")
                Filewrite.WriteLine("{0,-82}{1,-30}{2,12}", "", "TOTAL AMOUNT :", Mid(Format(Math.Round(Val(TotalAmount)), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                ''''************************************** $  COMPLETE GRAND TOTAL $   **************************************''''
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
            Filewrite.Write(Chr(15))
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
            'Filewrite.WriteLine("{0,64}{1,-10}", " ", "DETAILS")
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-18}{1,-20}{2,-12}{3,-30}{4,-12}", "BILL", "BILL", "MEMBER", "MEMBER", "SERVER")
            Filewrite.WriteLine("{0,-20}{1,12}", "PAYMENT", "BILL AMOUNT")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-18}{1,-20}{2,-12}{3,-30}{4,-12}", "DATE", "NUMBER", "CODE", "NAME", "CODE")
            Filewrite.WriteLine("{0,-30}{1,12}", "MODE", "")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
