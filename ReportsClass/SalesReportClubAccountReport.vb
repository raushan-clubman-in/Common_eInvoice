Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Public Class SalesReportClubAccountReport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal SQLSTRING2 As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim J, I, PosCount As Integer
        Dim TotalPos, Clubtotal, Grandtotal As Double
        Dim Posdesc, Clubaccount As String
        Dim boolclub As Boolean
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
            gconnection.getDataSet(SQLSTRING, "CLUBSALEREGISTER")
            If gdataset.Tables("CLUBSALEREGISTER").Rows.Count > 0 Then
                gconnection.getDataSet(SQLSTRING2, "COUNT")
                Filewrite.WriteLine()
                pagesize = pagesize + 1

                For Each dr In gdataset.Tables("CLUBSALEREGISTER").Rows
                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(79, "-"))
                        pagesize = pagesize + 1
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                    End If
                    If Clubaccount <> dr("SUBPAYMENTNAME") Then
                        If boolclub = True Then
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            'Filewrite.Write("{0,-20}{1,-22}", "Total Document :", Format(Val(PosCount), "0"))
                            Filewrite.Write("{0,-20}{1,-22}", "Total Document :", Format(Val(gdataset.Tables("COUNT").Rows(I).Item("DOCCOUNT")), "0"))
                            Filewrite.WriteLine("{0,9}{1,-10}{2,10}", "", "Club Total =====>", Format(Val(Clubtotal), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write(Chr(14) & Chr(15) & Mid(Trim(dr("SUBPAYMENTNAME")), 1, 30))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Clubaccount = dr("SUBPAYMENTNAME")
                            Clubtotal = 0
                            PosCount = 0
                            I = I + 1
                        Else
                            Filewrite.Write(Chr(14) & Chr(15) & Mid(Trim(dr("SUBPAYMENTNAME")), 1, 30))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Clubaccount = dr("SUBPAYMENTNAME")
                            Clubtotal = 0
                            PosCount = 0
                            boolclub = True
                        End If
                    End If
                    If Posdesc <> dr("POSDESC") Then
                        Filewrite.Write("{0,-5}{1,-22}", " ", Mid(Trim(dr("POSDESC")), 1, 20))
                        Posdesc = dr("POSDESC")
                        PosCount = PosCount + 1
                        TotalPos = TotalPos + 1
                    Else
                        Filewrite.Write("{0,-5}{1,-22}", " ", "")
                        PosCount = PosCount + 1
                        TotalPos = TotalPos + 1
                    End If
                    Filewrite.Write("{0,-12}", Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"))
                    Filewrite.Write("{0,-20}", Mid(Trim(dr("BILLNO")), 1, 20))
                    Filewrite.Write("{0,-10}", Mid(Trim(dr("SCODE")), 1, 18))
                    Filewrite.WriteLine("{0,10}", Format(Val(dr("AMOUNT")), "0.00"))
                    pagesize = pagesize + 1
                    Clubtotal = Clubtotal + Format(Val(dr("AMOUNT")), "0.00")
                    Grandtotal = Grandtotal + Format(Val(dr("AMOUNT")), "0.00")

                Next
                Filewrite.WriteLine(StrDup(79, "."))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-20}{1,-22}", "Total Document :", Format(Val(PosCount), "0"))
                Filewrite.WriteLine("{0,9}{1,-10}{2,10}", "", "Group Total =====>", Format(Val(Clubtotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "."))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-20}{1,-22}", "Total Document :", Format(Val(TotalPos), "0"))
                Filewrite.WriteLine("{0,9}{1,-10}{2,10}", "", "Grand Total =====>", Format(Val(Grandtotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "="))
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
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-27}{1,-12}{2,-20}{3,-10}{4,10}", "CLUB/", "BILL", "BILL", "SERVER", "NET")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-27}{1,-12}{2,-20}{3,-10}{4,10}", "LOCATION", "DATE", "NUMBER", "CODE", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
