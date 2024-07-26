Imports System.Data.SqlClient
Imports System.IO
Public Class pendingkot
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Detailsection(ByVal Sqlstring As String, ByVal pageheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim i, sno, GSNO As Integer
        Dim boolKOTdetails, boolServer, boolgrouptotal As Boolean
        Dim ServerName, KOTdetails, MemberCode, Rowprint, Todaydate As String
        Dim KOTAmount, GroupAmount, Grouptax, GrandAmount, Grandtax, BearerTotal, Bearertax, TotalAmount, Totaltax As Double
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            'Call PrintHeader(pageheading, mskfromdate, msktodate)
            Filewrite.WriteLine(Trim(gMAINCompanyname))
            Filewrite.WriteLine(Trim(pageheading(0)) & " From " & Format(mskfromdate, "dd/MM/yyyy") & " TO " & Format(msktodate, "dd/MM/yyyy") & "     PAGE NO:" & pageno)
            Filewrite.WriteLine(StrDup(73, "="))
            Filewrite.WriteLine("{0,5}{1,15}{2,12}{3,10}{4,12}{5,15}", " SNO ", "KOTNO", "KOTDATE", " TOTAL AMOUNT", "USER NAME", "PAYMENTMODE")
            Filewrite.WriteLine(StrDup(73, "="))
            gconnection.getDataSet(Sqlstring, "PENDINGKOTREGISTER")
            pagesize = 0
            If gdataset.Tables("PENDINGKOTREGISTER").Rows.Count > 0 Then
                pagesize = pagesize + 1
                MemberCode = ""
                TotalAmount = 0
                sno = 0
                GSNO = 0
                For Each dr In gdataset.Tables("PENDINGKOTREGISTER").Rows
                    If MemberCode <> CStr(dr("serverCODE")) Then
                        If GSNO > 0 Then
                            Filewrite.WriteLine(StrDup(55, "="))
                            Filewrite.WriteLine("{0,5}{1,15}{2,12}{3,10}{4,12}{5,15}", "", "TOTAL", "", Mid(Format(Val(TotalAmount), "0.00"), 1, 10), "", "")
                            Filewrite.WriteLine(StrDup(55, "="))
                            pagesize = pagesize + 2
                        End If
                        Filewrite.WriteLine()
                        Filewrite.WriteLine("{0,-10}{1,-6}{2,-40}", "WAITER :", Mid(Trim(dr("servercode")), 1, 6), Mid(Trim(dr("SERVERNAME")), 1, 40))
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                        MemberCode = dr("serverCODE")
                        TotalAmount = 0
                        sno = 0
                    End If
                    If pagesize > 60 Then
                        pageno = pageno + 1
                        Filewrite.WriteLine(StrDup(73, "="))
                        Filewrite.WriteLine(Chr(12))
                        Filewrite.WriteLine(Trim("TOWER CLUB"))
                        Filewrite.WriteLine(Trim(pageheading(0)) & " From " & Format(mskfromdate, "dd/MM/yyyy") & " TO " & Format(msktodate, "dd/MM/yyyy") & "     PAGE NO:" & pageno)
                        Filewrite.WriteLine(StrDup(73, "="))
                        Filewrite.WriteLine("{0,5}{1,15}{2,12}{3,10}{4,12}{5,15}", " SNO ", "KOTNO", "KOTDATE", " TOTAL AMOUNT", "USER NAME", "PAYMENTMODE")
                        Filewrite.WriteLine(StrDup(73, "="))
                        pagesize = 3
                    End If
                    sno = sno + 1
                    GSNO = GSNO + 1


                    Filewrite.WriteLine("{0,5}{1,15}{2,12}{3,10}{4,12}{5,15}", Format(sno, "0"), Mid(dr("KOTDETAILS"), 1, 10), Mid(Format(dr("KOTDATE"), "dd/MM/yyyy"), 1, 10), Mid(Format(Val(dr("TOTALAMOUNT")), "0.00"), 1, 10), Mid(dr("ADDUSERID"), 1, 15), Mid(dr("PAYMENTTYPE"), 1, 10))
                    pagesize = pagesize + 1
                    TotalAmount = TotalAmount + dr("TOTALAMOUNT")
                    GrandAmount = GrandAmount + dr("TOTALAMOUNT")
                Next dr
                Filewrite.WriteLine(StrDup(73, "="))
                Filewrite.WriteLine("{0,5}{1,15}{2,12}{3,10}{4,12}{5,15}", "", "TOTAL", "", Mid(Format(Val(TotalAmount), "0.00"), 1, 10), "", "")
                Filewrite.WriteLine(StrDup(73, "="))
                Filewrite.WriteLine("{0,5}{1,15}{2,12}{3,10}{4,12}{5,15}", "", "GRAND TOTAL", "", Mid(Format(GrandAmount, "0.00"), 1, 10), "", "TOTAL.KOT:(" & Format(GSNO, "0") & ")")
                Filewrite.WriteLine(StrDup(73, "="))
            Else
                Filewrite.WriteLine()
                Filewrite.WriteLine()
                Filewrite.WriteLine(Chr(14) & Chr(15) & "No pending KOT for today")
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
            Filewrite.WriteLine("{0,40}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1

            Filewrite.WriteLine("{0,-30}{1,30}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1


            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            'If flag = 1 Then
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "DETAILS")
            'Else
            '   Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            'End If
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(132, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-20}{1,-10}{2,-10}{3,-25}{4,-10}", "SERVER/", "BILL", "ITEM", "ITEM", "QTY")
            Filewrite.WriteLine("{0,-10}{1,10}{2,12}{3,12}{4,12}", "UOM", "RATE", PrintTaxheading1, "AMOUNT", "NETAMOUNT")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-20}{1,-10}{2,-10}{3,-25}{4,-10}", "BILL DATE", "NUMBER", "CODE", "DESCRIPTION", "")
            Filewrite.WriteLine("{0,-10}{1,10}{2,12}{3,12}{3,12}", "", "", PrintTaxheading2, "", "")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(132, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function


End Class
