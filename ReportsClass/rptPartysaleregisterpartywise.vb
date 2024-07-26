Imports System.Data.SqlClient
Imports System.IO
Public Class rptPartysaleregisterpartywise
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblMcodeBasic, dblDayBasic, dblGrandBasic As Double
        Dim Billdatebool, Mcodebool As Boolean
        Dim CstrMcode As String
        Dim Billdate As Date
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
            Call ReportHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "PARTYSALEREGISTERPARTYWISE")
            If gdataset.Tables("PARTYSALEREGISTERPARTYWISE").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("PARTYSALEREGISTERPARTYWISE").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(78, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If CStr(CstrMcode) <> CStr(dr("MCODE")) Then
                        If Mcodebool = True Then
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}{1,-18}{2,-10}{3,10}", "", "Party Total =====>", "", Format(Math.Round(Val(dblMcodeBasic)), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-10}", Mid(Trim(CStr(dr("MCODE"))), 1, 10))
                            Filewrite.WriteLine("{0,-30}", "=>" & Mid(Trim(CStr(dr("MNAME"))), 1, 28))
                            pagesize = pagesize + 1
                            CstrMcode = Trim(dr("MCODE"))
                            dblMcodeBasic = 0
                        Else
                            Filewrite.Write("{0,-10}", Mid(Trim(CStr(dr("MCODE"))), 1, 10))
                            Filewrite.WriteLine("{0,-30}", "=>" & Mid(Trim(CStr(dr("MNAME"))), 1, 28))
                            pagesize = pagesize + 1
                            CstrMcode = Trim(dr("MCODE"))
                            Mcodebool = True
                        End If
                    End If
                    If Format(DateValue(Billdate), "dd/MM/yyyy") <> Format(CDate(dr("BILLDATE")), "dd/MM/yyyy") Then
                        If Billdatebool = True Then
                            'Filewrite.WriteLine(StrDup(78, "."))
                            'pagesize = pagesize + 1
                            'Filewrite.WriteLine("{0,-40}{1,-18}{2,-10}{3,10}", "", "Day Total =====>", "", Format(Val(dblDayBasic), "0.00"))
                            'pagesize = pagesize + 1
                            'Filewrite.WriteLine(StrDup(78, "."))
                            'pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-5}{1,-35}", "", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                            pagesize = pagesize + 1
                            Billdate = CDate(dr("BILLDATE"))
                            dblDayBasic = 0
                        Else
                            Filewrite.WriteLine("{0,-5}{1,-35}", "", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                            pagesize = pagesize + 1
                            Billdate = CDate(dr("BILLDATE"))
                            Billdatebool = True
                        End If
                    End If
                    Filewrite.Write("{0,-10}{1,-30}", "", Mid(Trim(CStr(dr("POSDESC"))), 1, 20))
                    Filewrite.Write("{0,-18}", Mid(Trim(CStr(dr("BILLDETAILS"))), 1, 20))
                    Filewrite.Write("{0,-10}", Mid(Trim(CStr(dr("SERVERCODE"))), 1, 12))
                    Filewrite.WriteLine("{0,10}", Mid(Format(Math.Round(Val(dr("NETAMOUNT"))), "0.00"), 1, 10))
                    pagesize = pagesize + 1
                    dblMcodeBasic = Val(dblMcodeBasic) + Format(Val(dr("NETAMOUNT")), "0.00")
                    dblDayBasic = Val(dblDayBasic) + Format(Val(dr("NETAMOUNT")), "0.00")
                    dblGrandBasic = Val(dblGrandBasic) + Format(Val(dr("NETAMOUNT")), "0.00")
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                '''********************************************************* Print Mcode Total ************************************************'''
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-40}{1,-18}{2,-10}{3,10}", "", "Party Total =====>", "", Format(Math.Round(Val(dblMcodeBasic)), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                '''********************************************************* Print Day Total ************************************************'''
                'Filewrite.WriteLine(StrDup(78, "."))
                'pagesize = pagesize + 1
                'Filewrite.WriteLine("{0,-40}{1,-18}{2,-10}{3,10}", "", "Day Total =====>", "", Format(Val(dblDayBasic), "0.00"))
                'pagesize = pagesize + 1
                'Filewrite.WriteLine(StrDup(78, "."))
                'pagesize = pagesize + 1
                '''********************************************************* Print Grand Total ************************************************'''
                Filewrite.WriteLine(StrDup(78, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-40}{1,-18}{2,-10}{3,10}", "", "Grand Total =====>", "", Format(Math.Round(Val(dblGrandBasic)), "0.00"))
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


    Private Function ReportHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
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
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-40}{1,-18}{2,-10}{3,10}", "PARTY/DATE/LOCATION", "BILL NUMER", "SERVER", "NET AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
